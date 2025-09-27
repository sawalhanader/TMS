Imports Microsoft.Data.SqlClient

Public Class insertNewArr
    Public cnn As New SqlConnection
    Dim ins As Integer

    ''' <summary>
    ''' Handles the click event for Button1. Inserts a new crew record into the Arrival table if an ID is provided.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Label7.Text = "There is no ID Number to inserte it"
            Label7.ForeColor = Color.Red
        Else
            home.DataGridView6.CurrentRow.Cells(3).Value = TextBox1.Text
            Dim cm As New SqlCommand
            Dim ST As String
            Dim getallr As String
            getallr = "Select ADate,ArrTime , Flight,RNum  from Arrival Where ArrID = " & home.DataGridView6.CurrentRow.Cells(0).Value
            Dim adgetallr As New SqlDataAdapter(getallr, cnn)
            Dim dtins As New Data.DataTable
            adgetallr.Fill(dtins)
            Label5.Text = dtins.Rows(0).Item(2).ToString
            Label6.Text = dtins.Rows(0).Item(1).ToString
            Dim adst As String
            adst = "Select * from mobile where id= " & TextBox1.Text
            Dim ad As New SqlDataAdapter(adst, cnn)
            Dim adds As New Data.DataTable
            ad.Fill(adds)
            ' (FDate,ArrTime,Flight,CArName,CEnName,GPSNote,RNum,isinsert)
            ST = "insert into Arrival values(N'" & home.ToolStripLabel6.Text & "',N'" & Label6.Text & "',N'" & Label5.Text & "'," & TextBox1.Text & ",N'****',N'" & adds.Rows(0).Item("Name") & "',N'" & adds.Rows(0).Item("HomeAddress") & "',N'',N'',N'',N'New Inserted'," & adds.Rows(0).Item("areaa") & "," & 0 & "," & ins & ",0,0," & home.UserName & ",N'')"
            cm = New SqlCommand(ST, cnn)
            cm.ExecuteNonQuery()
            TextBox1.Text = ""
            Label7.Text = ""
            cnn.Close()
            Me.Close()
            MessageBox.Show("The new Crew will be inserted after Update ")
        End If
    End Sub

    ''' <summary>
    ''' Handles the Load event for the insertNewArr form. Loads arrival data and sets label values.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub insertnew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cm As New SqlCommand
        Dim getallr As String
        getallr = "Select ADate,ArrTime , Flight,RNum  from Arrival Where ArrID = " & home.DataGridView6.CurrentRow.Cells(0).Value
        Dim adgetallr As New SqlDataAdapter(getallr, home.cn)
        Dim dtins As New Data.DataTable
        adgetallr.Fill(dtins)
        ins = dtins.Rows(0).Item(3)
        Label5.Text = dtins.Rows(0).Item(2).ToString
        Label6.Text = dtins.Rows(0).Item(1).ToString
    End Sub
End Class