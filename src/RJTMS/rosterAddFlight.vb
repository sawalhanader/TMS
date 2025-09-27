Imports System.Windows.Forms
Imports System.Data.Sql
Imports Microsoft.Data.SqlClient


Public Class rosterAddFlight
    Dim cnnn As New SqlConnection
    Dim hh As Integer = 0

    ''' <summary>
    ''' Handles the OK button click event. Inserts new crew records into FullRoster based on the DataGridView values.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Dim brf As String
            If Convert.ToDateTime(TextBox1.Text.ToString) >= Convert.ToDateTime("6:00:00 Am") And Convert.ToDateTime(TextBox1.Text.ToString) <= Convert.ToDateTime("9:00:00 pm") Then
                brf = Convert.ToDateTime(TextBox1.Text.ToString).AddMinutes(+120).ToShortTimeString
            Else
                brf = Convert.ToDateTime(TextBox1.Text.ToString).AddMinutes(+90).ToShortTimeString
            End If
            Dim insf As String
            Dim ik As Integer = 0
            Dim cf As Integer
            While ik <= Da1.RowCount - 2
                If ik = 0 Then
                    cf = 1
                Else
                    cf = 0
                End If
                Dim newerror As New SqlCommand
                newerror.Connection = home.cn
                newerror.CommandText = "set dateformat dmy"
                newerror.ExecuteNonQuery()
                insf = " insert into FullRoster values(N'" & home.ToolStripLabel1.Text & "',N'" & TextBox1.Text & "',N'" & TextBox2.Text & "'," & Da1(0, ik).Value & ",N'****',N'" & Da1(1, ik).Value & "',N'" & Da1(2, ik).Value & "',N'" & Da1(3, ik).Value & "',N'',N'',N'',N''," & Da1(4, ik).Value & ",N'" & brf & "',N'',N'',N'00:00:00'," & cf & "," & ik & ",0,0,0,0,'" & Convert.ToDateTime(Label3.Text) & "')"
                Dim ins As New SqlCommand
                ins.Connection = home.cn
                ins.CommandText = insf
                ins.ExecuteNonQuery()
                ik = ik + 1
            End While
            Me.Close()
            MessageBox.Show("The new Crew will be inserted after Update ")
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            home.ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        '   cnnn.Close()
    End Sub

    ''' <summary>
    ''' Handles the Cancel button click event. Closes the form and sets DialogResult to Cancel.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        '   cnnn.Close()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Handles the Load event for the rosterAddFlight form. Opens the connection if closed and sets Label3 text.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub rosterAddFlight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If home.cn.State = ConnectionState.Closed Then
            home.cn.Open()
        End If
        Label3.Text = home.ToolStripLabel1.Text
    End Sub

    ''' <summary>
    ''' Handles the CellValueChanged event for Da1. Populates row details from the mobile table when a cell value changes.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A DataGridViewCellEventArgs that contains the event data.</param>
    Private Sub Da1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Da1.CellValueChanged
        Try
            ' Check if CurrentCell is not Nothing before accessing its properties
            If Da1.CurrentCell IsNot Nothing AndAlso Da1.CurrentCell.Value IsNot Nothing AndAlso Da1.CurrentCell.Value.ToString() <> "" Then
                Dim sqm As String
                sqm = "select * from mobile where ID=" & Da1.CurrentCell.Value
                Dim dnd As New SqlDataAdapter(sqm, home.cn)
                Dim dqd As New System.Data.DataTable
                dnd.Fill(dqd)

                Da1.CurrentRow.Cells(1).Value = dqd.Rows(0).Item("Phone")
                Da1.CurrentRow.Cells(2).Value = dqd.Rows(0).Item("Name")
                Da1.CurrentRow.Cells(3).Value = dqd.Rows(0).Item("HomeAddress")
                Da1.CurrentRow.Cells(4).Value = dqd.Rows(0).Item("areaa")
            End If
        Catch ex As Exception
            ' Optionally log or handle the exception
        End Try
    End Sub

    ''' <summary>
    ''' Handles the CellContentClick event for Da1. (No implementation)
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A DataGridViewCellEventArgs that contains the event data.</param>
    Private Sub Da1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Da1.CellContentClick
        ' No implementation
    End Sub
End Class
