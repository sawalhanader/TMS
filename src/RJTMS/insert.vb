Imports System.Data.SqlClient

Public Class Form2
    Dim w As Integer = 0
    Dim rr As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' MessageBox.Show(Form1.tt2.SelectedIndex)
        If Main.tt2.SelectedIndex = 1 Then

            w = 0
            Main.Focus()
            'Form1.D1.Focus()
            If TextBox1.Text = "" Then

                Label2.Text = " Please enter a Search Text"
            Else
                If IsNumeric(TextBox1.Text) Then
                    Main.FindeGS(TextBox1.Text, Main.D1)

                Else
                    Main.FindGS(TextBox1.Text, Main.D1, w, rr)
                End If
            End If
        ElseIf Main.tt2.SelectedIndex = 0 Then

            w = 0
            Main.Focus()
            'Form1.D1.Focus()
            If TextBox1.Text = "" Then

                Label2.Text = " Please enter a Search Text"
            Else
                If IsNumeric(TextBox1.Text) Then
                    Main.Finde(TextBox1.Text, Main.D1)

                Else
                    Main.Find(TextBox1.Text, Main.D1, w, rr)
                End If
            End If

        End If
    End Sub



    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '   Button1.PerformClick()
        'End If
        'If e.KeyCode = Keys.Right Then
        '    Button3.PerformClick()
        ' End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        Me.MaximizeBox = False
        If Main.arabic.Text = "English" Then
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

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus

    End Sub

    Private Sub TextBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseDoubleClick

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer
        If Main.tt2.SelectedIndex = 1 Then

            Try









                For i = Main.D2.CurrentRow.Index + 1 To Main.D2.Rows.Count


                    If Main.D2.Rows(i).Cells(1).Value.ToString.Contains(TextBox1.Text) Then

                        Main.D2.FirstDisplayedScrollingRowIndex = i
                        Main.D2.Rows(i).Selected = True
                        Main.Focus()

                        Exit Sub



                    End If





                Next



            Catch ex As Exception
                i = 0

                Me.Label2.Visible = True
                Me.Label2.Text = "NO Record Was Found"

            End Try

        ElseIf Main.tt2.SelectedIndex = 0 Then


            Try









                For i = Main.D1.CurrentRow.Index + 1 To Main.D1.Rows.Count


                    If Main.D1.Rows(i).Cells(6).Value.ToString.Contains(TextBox1.Text) Then

                        Main.D1.FirstDisplayedScrollingRowIndex = i
                        Main.D1.Rows(i).Selected = True
                        Main.Focus()
                        Main.D1.Rows(i).Cells(5).Selected = True
                        Exit Sub



                    End If





                Next



            Catch ex As Exception
                i = 0

                Me.Label2.Visible = True
                Me.Label2.Text = "NO Record Was Found"

            End Try
        End If



    End Sub
End Class