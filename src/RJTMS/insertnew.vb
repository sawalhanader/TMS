Imports Microsoft.Data.SqlClient

Public Class insertnew
    ''' <summary>
    ''' Handles the Load event for the insertnew form. Loads roster data and sets label values.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub insertnew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            home.cn.Open()
            Dim cm As New SqlCommand
            Dim getallr As String
            getallr = "Select FDate,PickupTime , Flight,BRFTime,RNum  from FullRoster Where RID = " & home.D1.CurrentRow.Cells(20).Value
            Dim adgetallr As New SqlDataAdapter(getallr, home.cn)
            Dim dtins As New Data.DataTable
            adgetallr.Fill(dtins)
            Label5.Text = dtins.Rows(0).Item(2).ToString
            Label6.Text = dtins.Rows(0).Item(1).ToString
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Handles the KeyDown event for TextBox1. Adds a new row to Da1 when Enter is pressed and a valid ID is entered.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A KeyEventArgs that contains the event data.</param>
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim sqm As String
                sqm = "select * from mobile where ID=" & TextBox1.Text
                Dim dnd As New SqlDataAdapter(sqm, home.cn)
                Dim dqd As New System.Data.DataTable
                dnd.Fill(dqd)
                Da1.Rows.Add(dqd.Rows(0).Item("id"), dqd.Rows(0).Item("Name"), dqd.Rows(0).Item("HomeAddress"))
            End If
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Handles the click event for Button1. Inserts a new crew record into FullRoster if an ID is provided.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '    Try
        If home.cn.State = ConnectionState.Closed Then
            home.cn.Open()
        End If
        If TextBox1.Text = "" Then
            Label7.Text = "There is no ID Number to inserte it"
            Label7.ForeColor = Color.Red
        Else
            home.D1.CurrentRow.Cells(3).Value = TextBox1.Text
            Dim cm As New SqlCommand
            Dim ST As String
            Dim getallr As String
            getallr = "Select FDate,PickupTime , Flight,BRFTime,RNum  from FullRoster Where RID = " & home.D1.CurrentRow.Cells(20).Value
            Dim adgetallr As New SqlDataAdapter(getallr, home.cn)
            Dim dtins As New Data.DataTable
            adgetallr.Fill(dtins)
            Label5.Text = dtins.Rows(0).Item(2).ToString
            Label6.Text = dtins.Rows(0).Item(1).ToString
            Dim adst As String
            adst = "Select * from mobile where id= " & TextBox1.Text
            Dim ad As New SqlDataAdapter(adst, home.cn)
            Dim adds As New Data.DataTable
            ad.Fill(adds)
            Dim insrttext As String
            If CheckBox1.Checked Then
                insrttext = "New Inserted [Ex.Crew]"
            Else
                insrttext = "New Inserted"
            End If
            ' (FDate,PickupTime,Flight,CArName,CEnName,GPSNote,RNum,isinsert)
            '" & Convert.ToDateTime(dtins.Rows(0).Item(0).ToString) & "'
            Dim newerror As New SqlCommand
            newerror.Connection = home.cn
            newerror.CommandText = "set dateformat dmy"
            newerror.ExecuteNonQuery()
            ST = "insert into FullRoster Values (N'" & dtins.Rows(0).Item(0).ToString & "',N'" & dtins.Rows(0).Item(1).ToString & "',N'" & dtins.Rows(0).Item(2).ToString & "'," & TextBox1.Text & ",'****',N'" & adds.Rows(0).Item(3).ToString & "',N'" & adds.Rows(0).Item(1).ToString & "',N'" & adds.Rows(0).Item(4).ToString & "','','',''" & insrttext & "'," & adds.Rows(0).Item(2) & ",N'" & dtins.Rows(0).Item(3).ToString & "' ,'','',N'00:00:00',0," & dtins.Rows(0).Item(4) & "," & home.UserName & ",0,0,0,'" & Convert.ToDateTime(dtins.Rows(0).Item(0).ToString) & "' )"
            cm = New SqlCommand(ST, home.cn)
            cm.ExecuteNonQuery()
            TextBox1.Text = ""
            Label7.Text = ""
            home.cn.Close()
            ' Me.Close()
            MessageBox.Show("The new Crew will be inserted after Update ")
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Handles the MouseClick event for Da1. Sets TextBox1 text to the selected row's ID.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A MouseEventArgs that contains the event data.</param>
    Private Sub Da1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Da1.MouseClick
        TextBox1.Text = Da1.CurrentRow.Cells(0).Value
    End Sub
End Class