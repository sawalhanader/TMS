Imports System.Windows.Forms
Imports Microsoft.Data.SqlClient

Public Class arrAddFlight
    Dim cnnn As New SqlConnection

    ''' <summary>
    ''' Handles the Cancel button click event. Sets DialogResult to Cancel and closes the form.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    ''' <summary>
    ''' Handles the CellValueChanged event for Da1. Populates row details from the mobile table when a cell value changes.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A DataGridViewCellEventArgs that contains the event data.</param>
    Private Sub Da1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Da1.CellValueChanged
        Try
            Dim sqm As String
            sqm = "select * from mobile where ID=" & Da1.CurrentCell.Value
            Dim dnd As New SqlDataAdapter(sqm, home.cn)
            Dim dqd As New System.Data.DataTable
            dnd.Fill(dqd)

            Da1.CurrentRow.Cells(1).Value = dqd.Rows(0).Item("Name")
            Da1.CurrentRow.Cells(2).Value = dqd.Rows(0).Item("HomeAddress")
            Da1.CurrentRow.Cells(3).Value = dqd.Rows(0).Item("areaa")
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Handles the FormClosed event for arrAddFlight. Closes the connection if open.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A FormClosedEventArgs that contains the event data.</param>
    Private Sub arrAddFlight_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If cnnn.State = ConnectionState.Open Then
            cnnn.Close()
        End If
    End Sub

    ''' <summary>
    ''' Handles the OK button click event. Inserts new crew records into Arrival based on the DataGridView values.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub OK_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Dim insf As String
            Dim ik As Integer = 0
            Dim cf As Integer

            While ik <= Da1.RowCount - 2
                If ik = 0 Then
                    cf = 1
                Else
                    cf = 0
                End If

                insf = "insert into Arrival values(N'" & Home.ToolStripLabel6.Text & "',N'" & TextBox1.Text & "',N'" & TextBox2.Text & "'," & Da1(0, ik).Value & ",N'****',N'" & Da1(1, ik).Value & "',N'" & Da1(2, ik).Value & "',N'',N'',N'',N'New Inserted'," & Da1(3, ik).Value & "," & cf & "," & ik & ",0,0," & Home.UserName & ",N'')"
                Dim ins As New SqlCommand
                ins.Connection = Home.cn
                ins.CommandText = insf
                ins.ExecuteNonQuery()
                ik = ik + 1
            End While
            Me.Close()
            MessageBox.Show("The new Crew will be inserted after Update ")
        Catch ex As Exception
            Home.ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        cnnn.Close()
        Me.Close()
    End Sub
End Class
