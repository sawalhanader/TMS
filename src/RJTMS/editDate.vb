Imports System.Windows.Forms
Imports Microsoft.Data.SqlClient

Public Class editDate
    ''' <summary>
    ''' Handles the OK button click event. Updates flight, briefing, date, and pickup time for selected records.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim dep As String
        Dim dep1 As String
        If home.D1.CurrentRow.Cells(2).Value.ToString.Contains("dep ") Then
            dep = home.D1.CurrentRow.Cells(2).Value.ToString.Remove(home.D1.CurrentRow.Cells(2).Value.ToString.IndexOf("p") + 2, 5)
            dep1 = dep.Insert(home.D1.CurrentCell.Value.ToString.IndexOf("p") + 11, TextBox3.Text)
        Else
            dep1 = home.D1.CurrentCell.Value.ToString
        End If
        Dim brf As DateTime
        If home.D1.CurrentRow.Cells(2).Value.ToString.Contains("dep ") Then
            brf = Convert.ToDateTime(TextBox3.Text).AddMinutes(-90).ToShortTimeString
            home.D1.CurrentRow.Cells(13).Value = brf
        Else
            If Convert.ToDateTime(TextBox2.Text).ToShortTimeString >= "4:30 AM" And Convert.ToDateTime(TextBox2.Text).ToShortTimeString <= "9:30 PM" Then
                brf = Convert.ToDateTime(TextBox2.Text).AddMinutes(+120).ToShortTimeString
            Else
                brf = Convert.ToDateTime(TextBox2.Text).AddMinutes(+90).ToShortTimeString
            End If
        End If
        Dim newerror As New SqlCommand
        newerror.Connection = home.cn
        newerror.CommandText = "set dateformat dmy"
        newerror.ExecuteNonQuery()
        Dim cm1 As New SqlCommand
        Dim Sqm As String
        If home.cn.State = ConnectionState.Closed Then
            home.cn.Open()
        End If
        Dim c As Integer = 0
        While c <= DataGridView1.RowCount - 2
            Sqm = "update FullRoster set Flight=N'" & dep1 & "',BrfTime=N'" & brf & "'where RID=" & DataGridView1(2, c).Value
            cm1 = New SqlCommand(Sqm, home.cn)
            cm1.ExecuteNonQuery()
            c = c + 1
        End While
        home.D1.CurrentRow.Cells(2).Value = dep1
        If TextBox1.Text <> home.ToolStripLabel1.Text Then
            Dim cm As New SqlCommand
            Dim Sqm1 As String
            If home.cn.State = ConnectionState.Closed Then
                home.cn.Open()
            End If
            Dim c1 As Integer = 0
            While c1 <= DataGridView1.RowCount - 2
                Sqm1 = "update FullRoster set Fdate=N'" & TextBox1.Text & "', Flight =N'" & home.D1.CurrentRow.Cells(2).Value.ToString + " (Delay) " & "',DAtee='" & Convert.ToDateTime(TextBox1.Text) & "'where RID=" & DataGridView1(2, c1).Value
                cm = New SqlCommand(Sqm1, home.cn)
                cm.ExecuteNonQuery()
                c1 = c1 + 1
            End While
            home.D1.CurrentRow.Cells(0).Value = TextBox1.Text
        End If
        If TextBox2.Text <> home.ToolStripLabel1.Text Then
            Dim cm11 As New SqlCommand
            Dim Sqm11 As String
            If home.cn.State = ConnectionState.Closed Then
                home.cn.Open()
            End If
            Dim c11 As Integer = 0
            While c11 <= DataGridView1.RowCount - 2
                Sqm11 = "update FullRoster set PickupTime=N'" & TextBox2.Text & "', Flight =N'" & home.D1.CurrentRow.Cells(2).Value.ToString + " (Delay) " & "'where RID=" & DataGridView1(2, c11).Value
                cm11 = New SqlCommand(Sqm11, home.cn)
                cm11.ExecuteNonQuery()
                c11 = c11 + 1
            End While
            home.D1.CurrentRow.Cells(0).Value = TextBox1.Text
        End If
        Me.Close()
    End Sub

    ''' <summary>
    ''' Handles the Cancel button click event. Closes the form and sets DialogResult to Cancel.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    ''' <summary>
    ''' Handles the Load event for the editDate form. Loads crew data for editing and sets up the form fields.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub EditDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim gtext As String
        gtext = "Select CID,CArName,RID from FullRoster Where FDate =N'" & home.ToolStripLabel1.Text & "'and (PickupTime='" & home.D1.CurrentRow.Cells(1).Value & "' and Flight = '" & home.D1.CurrentRow.Cells(2).Value & "')"
        Dim dat As New Data.DataTable
        If home.cn.State = ConnectionState.Closed Then
            home.cn.Open()
        End If
        Try
            Dim getcrew As New SqlDataAdapter(gtext, home.cn)
            getcrew.Fill(dat)
            DataGridView1.DataSource = dat
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(0).ReadOnly = True
            DataGridView1.Columns(1).ReadOnly = True
            TextBox1.Text = home.D1.CurrentRow.Cells(0).Value
            TextBox2.Text = home.D1.CurrentRow.Cells(1).Value
            TextBox3.Text = home.D1.CurrentRow.Cells(2).Value.ToString.Substring(home.D1.CurrentRow.Cells(2).Value.ToString.IndexOf("p") + 2, 5)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
