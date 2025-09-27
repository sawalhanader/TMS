Imports Microsoft.Data.SqlClient

Public Class rosterSearch
    Dim w As Integer = 0
    Dim rr As Integer
    Dim ident As Integer

    ''' <summary>
    ''' Handles the KeyDown event for the rosterSearch form.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A KeyEventArgs that contains the event data.</param>
    Private Sub rosterSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '   Button1.PerformClick()
        'End If
        'If e.KeyCode = Keys.Right Then
        '    Button3.PerformClick()
        ' End If
    End Sub

    ''' <summary>
    ''' Handles the Load event for the rosterSearch form. Sets up UI based on language.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub rosterSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        Me.MaximizeBox = False
        If home.arabic.Text = "English" Then
            Me.Text = "البحث"
            Label1.Text = "جملة البحث"
            Button1.Text = "بحث"
            Button3.Text = "بحث التالي"
            Button2.Text = "الغاء"
            TextBox1.Left = 35
            TextBox1.TextAlign = HorizontalAlignment.Right
            Label1.Left = 180
        End If
    End Sub

    ''' <summary>
    ''' Handles the VisibleChanged event for the rosterSearch form. Focuses TextBox1.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub rosterSearch_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        TextBox1.Focus()
    End Sub

    ''' <summary>
    ''' Handles the SelectedIndexChanged event for TabControl1. Adjusts form size based on selected tab.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Me.Width = 404
            Me.Height = 196
        Else
            If Not D2.RowCount = 0 Then
                Me.Width = home.Width
                Me.Height = 500
            End If
        End If
    End Sub

    ''' <summary>
    ''' Handles the TabIndexChanged event for TabControl1.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub TabControl1_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.TabIndexChanged
        ' No implementation
    End Sub

    ''' <summary>
    ''' Handles the Click event for Button6. Performs a search and populates D2 with results.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim cmdOLEDB As New SqlCommand
            Dim SQL As String
            Dim i As Integer = 0
            If IsNumeric(TextBox2.Text) Then
                If CheckBox1.Checked = True Then
                    SQL = "select FDate ,PickupTime,Flight,CID,CEnName, CMobile,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,DMnote,RID  from FullRoster  where Bus LIKE N'%" & TextBox2.Text & "%'AND FDate  =N'" & home.ToolStripLabel1.Text & "'"
                Else
                    SQL = "select FDate ,PickupTime,Flight,CID,CEnName,CMobile,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,DMnote,RID  from FullRoster  where Bus LIKE N'%" & TextBox2.Text & "%'AND FDate  =N'" & home.ToolStripLabel1.Text & "' and GPSCallTime=N''"
                End If
                Dim dn As New SqlDataAdapter(SQL, home.cn)
                Dim dq As New System.Data.DataTable
                dn.Fill(dq)
                D2.DataSource = dq
            Else
                If CheckBox1.Checked = True Then
                    SQL = "select FDate ,PickupTime,Flight,CID,CEnName,CMobile,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,DMnote,RID  from FullRoster  where Driver  LIKE N'%" & TextBox2.Text & "%'AND FDate  =N'" & home.ToolStripLabel1.Text & "'"
                Else
                    SQL = "select FDate ,PickupTime,Flight,CID,CEnName,CMobile,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,DMnote,RID  from FullRoster  where Driver  LIKE N'%" & TextBox2.Text & "%'AND FDate  =N'" & home.ToolStripLabel1.Text & "' and GPSCallTime=N''"
                End If
                Dim dnx As New SqlDataAdapter(SQL, home.cn)
                Dim dqx As New System.Data.DataTable
                dnx.Fill(dqx)
                D2.DataSource = dqx
            End If
            For mm = 0 To D2.RowCount - 2
                Dim hh As String = D2(7, mm).Value.ToString
                If Not D2(8, mm).Value.ToString = "" Then
                    D2.Rows(mm).DefaultCellStyle.BackColor = Color.LightBlue
                End If
                If D2(11, mm).Value = "Delete" Then
                    D2.Rows(mm).DefaultCellStyle.BackColor = Color.DarkOrange
                End If
                If D2(11, mm).Value = "Switched" Then
                    D2.Rows(mm).DefaultCellStyle.BackColor = Color.Violet
                End If
                If D2(11, mm).Value = "NO SHOW" Then
                    D2.Rows(mm).DefaultCellStyle.BackColor = Color.LightGreen
                End If
                If D2(11, mm).Value = "CANCEL ON CALL" Then
                    D2.Rows(mm).DefaultCellStyle.BackColor = Color.Yellow
                End If
                If D2(11, mm).Value = "Alone" Then
                    D2.Rows(mm).DefaultCellStyle.BackColor = Color.Tan
                End If
            Next
            If TabControl1.SelectedIndex = 0 Then
                Me.Width = 386
                Me.Height = 136
            Else
                If Not D2.CurrentCell.Value Is Nothing Then
                    Me.Width = home.Width
                    Me.Height = 500
                End If
            End If
            D2.Columns(14).Visible = False
        Catch ex As Exception
            ' Handle exception (optional)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the Click event for Button2. Closes the form.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Handles the Click event for Button1. Performs a search based on the selected tab and search text.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If home.tt2.SelectedIndex = 1 Then
            w = 0
            home.Focus()
            If TextBox1.Text = "" Then
                Label2.Text = " Please enter a Search Text"
            Else
                If IsNumeric(TextBox1.Text) Then
                    home.FindeGS(TextBox1.Text, home.D2)
                Else
                    home.FindGS(TextBox1.Text, home.D2, w, rr)
                End If
            End If
        ElseIf home.tt2.SelectedIndex = 0 Then
            w = 0
            home.Focus()
            If TextBox1.Text = "" And TextBox3.Text = "" Then
                Label2.Text = " Please enter a Search Text"
            ElseIf TextBox1.Text <> "" And TextBox3.Text = "" Then
                If IsNumeric(TextBox1.Text) Then
                    home.Finde(TextBox1.Text, home.D1)
                Else
                    home.Find(TextBox1.Text, home.D1, w, rr)
                End If
            ElseIf TextBox1.Text = "" And TextBox3.Text <> "" Then
                home.FindeFLIGHT(TextBox3.Text, home.D1)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Handles the Click event for Button3. Finds the next matching record in the grid.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If home.tt2.SelectedIndex = 1 Then
            Try
                Dim ii = 0
                For ii = home.D2.CurrentRow.Index + 1 To home.D2.Rows.Count - 1
                    If home.D2.Rows(ii).Cells(1).Value.ToString.Contains(TextBox1.Text) Then
                        home.D2.FirstDisplayedScrollingRowIndex = ii
                        home.D2.Rows(ii).Selected = True
                        home.Focus()
                        home.D2.Rows(ii).Cells(1).Selected = True
                        Exit Sub
                    End If
                Next
            Catch ex As Exception
                Me.Label2.Visible = True
                Me.Label2.Text = "NO Record Was Found"
            End Try
        ElseIf home.tt2.SelectedIndex = 0 Then
            Try
                Dim i1 As Integer = 0
                For i1 = home.D1.CurrentRow.Index + 1 To home.D1.Rows.Count
                    If home.D1.Rows(i1).Cells(6).Value.ToString.Contains(TextBox1.Text) Then
                        home.D1.FirstDisplayedScrollingRowIndex = i1
                        home.D1.Rows(i1).Selected = True
                        home.Focus()
                        home.D1.Rows(i1).Cells(5).Selected = True
                        Exit Sub
                    End If
                Next
            Catch ex As Exception
                Me.Label2.Visible = True
                Me.Label2.Text = "NO Record Was Found"
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Handles the Click event for Button5. Closes the form.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Handles the KeyDown event for TextBox1. Triggers Button1 click on Enter key.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A KeyEventArgs that contains the event data.</param>
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    ''' <summary>
    ''' Handles the KeyDown event for TextBox2. Triggers Button6 click on Enter key.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A KeyEventArgs that contains the event data.</param>
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button6.PerformClick()
        End If
    End Sub

    ''' <summary>
    ''' Handles the CellDoubleClick event for D2. Updates GPSCallTime and highlights the row.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A DataGridViewCellEventArgs that contains the event data.</param>
    Private Sub D2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles D2.CellDoubleClick
        ident = 1
        If D2.CurrentCell.ColumnIndex = 5 Then
            Dim SelectedThings As String = D2.CurrentCell.Value
            SelectedThings = SelectedThings.Replace(" ", "")
            Dim k As Integer = D2.CurrentCell.RowIndex
            D2.BeginEdit(True)
            Dim rowID As String = D2(14, k).Value.ToString
            D2(8, k).Value = D2(8, k).Value + " (" + System.DateTime.Now.ToShortTimeString.ToString + ") "
            D2.Rows(k).DefaultCellStyle.BackColor = Color.LightBlue
            Dim cm1 As New SqlCommand
            Dim Sqm As String
            Sqm = "update FullRoster set GPSCallTime=N'" & D2(8, k).Value & "',GPSOfficer = " & home.UserName & " where RID=" & rowID
            cm1 = New SqlCommand(Sqm, home.cn)
            cm1.ExecuteNonQuery()
            D2.EndEdit(True)
            If SelectedThings.Length = 9 Then
                'Webdialer.webdialer.Navigate("https://rjammccm2/webdialer/Webdialer?destination=90" & SelectedThings & "&ref=devdevext")
            ElseIf SelectedThings.Length = 7 Then
                'Webdialer.webdialer.Navigate("https://rjammccm2/webdialer/Webdialer?destination=9" & SelectedThings & "&ref=devdevext")
            ElseIf SelectedThings.Length = 4 Then
                'Webdialer.webdialer.Navigate("https://rjammccm2/webdialer/Webdialer?destination=" & SelectedThings & "&ref=devdevext")
            End If
            Dim searchs As String = D2(14, k).Value.ToString
            Findee(searchs, home.D1)
        End If
    End Sub

    ''' <summary>
    ''' Finds and highlights a row in D1 matching the search string.
    ''' </summary>
    ''' <param name="StrSearchString">The search string to find in D1.</param>
    ''' <param name="D1">The DataGridView to search.</param>
    ''' <returns>True if found, otherwise False.</returns>
    Public Function Findee(ByVal StrSearchString As String, ByVal D1 As DataGridView) As Boolean
        Dim intcount As Integer = 0
        For Each Row As DataGridViewRow In D1.Rows
            If D1.Rows(intcount).Cells(20).Value.ToString = StrSearchString.ToString Then
                If ident = 1 Then
                    D1.Rows(intcount).DefaultCellStyle.BackColor = Color.LightBlue
                    D1(8, intcount).Value = D1(8, intcount).Value + " (" + System.DateTime.Now.ToShortTimeString.ToString + ") "
                    Exit Function
                ElseIf ident = 2 Then
                    D1(11, intcount).Value = D2.CurrentRow.Cells(11).Value
                End If
            End If
            intcount += 1
        Next Row
    End Function

    ''' <summary>
    ''' Handles the CellValueChanged event for D2. Updates D1 if column 11 is changed.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A DataGridViewCellEventArgs that contains the event data.</param>
    Private Sub D2_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles D2.CellValueChanged
        Dim searchs As String = D2.CurrentRow.Cells(14).Value.ToString
        If D2.CurrentCell.ColumnIndex = 11 Then
            ident = 2
            Findee(searchs, home.D1)
        End If
    End Sub
End Class