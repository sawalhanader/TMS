Imports System.Windows.Forms
Imports Microsoft.Data.SqlClient


Public Class crewSearch
    ''' <summary>
    ''' Handles the OK button click event. Sets DialogResult to OK and closes the form.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

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
    ''' Handles the KeyDown event for the crewSearch form. Triggers search on Enter and closes on Escape.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A KeyEventArgs that contains the event data.</param>
    Private Sub crewSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Enter Then
            Button1.PerformClick()
        End If
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Handles the Load event for the crewSearch form. Sets the owner to home.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub crewSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Owner = home
    End Sub

    ''' <summary>
    ''' Handles the DoubleClick event for TextBox3. Triggers Button1 click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub TextBox3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.DoubleClick
        Button1.PerformClick()
    End Sub

    ''' <summary>
    ''' Handles the click event for Button1. Initiates a web dialer call and logs the call in CallOutRoster.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        webDialer.Close()
        Try
            If TextBox3.Text.Replace(" ", "").Length = 9 Then
                webDialer.InitializeWebView("https://rjammccmp.rj.com/webdialer/Webdialer?destination=90" & TextBox3.Text & "&ref=devdevext")
            ElseIf TextBox3.Text.Replace(" ", "").Length = 7 Then
                webDialer.InitializeWebView("rjammccmp.rj.com/webdialer/Webdialer?destination=9" & TextBox3.Text & "")
            End If
            Dim CallOutRoster As New SqlCommand
            CallOutRoster.Connection = home.cn
            CallOutRoster.CommandText = "insert into CallOutRoster values (" & home.UserName & "," & TextBox1.Text & ",N'" & System.DateTime.Now & "',N'" & TextBox2.Text & "',N'" & TextBox3.Text & "')"
            CallOutRoster.ExecuteNonQuery()
        Catch ex As Exception
            home.ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
    End Sub

    ''' <summary>
    ''' Handles the click event for Button2. Closes the form.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Handles the MouseDoubleClick event for TextBox3. Triggers Button1 click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A MouseEventArgs that contains the event data.</param>
    Private Sub TextBox3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox3.MouseDoubleClick
        Button1.PerformClick()
    End Sub
End Class
