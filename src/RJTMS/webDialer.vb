Imports Microsoft.Web.WebView2.Core

Public Class webDialer
    Public Property NavigateURL As String

    Private Async Sub Webdialer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AddHandler WebView21.CoreWebView2InitializationCompleted, AddressOf WebView2Ready
            Await WebView21.EnsureCoreWebView2Async(Nothing)
        Catch
        End Try
    End Sub

    Private Sub WebView2Ready(sender As Object, e As CoreWebView2InitializationCompletedEventArgs)
        Try
            If e.IsSuccess AndAlso Not String.IsNullOrEmpty(NavigateURL) Then
                WebView21.CoreWebView2.Navigate(NavigateURL)
            End If
        Catch
        End Try
    End Sub

    Public Async Sub InitializeWebView(Optional url As String = "")
        Try
            If Not String.IsNullOrEmpty(url) Then
                NavigateURL = url
            End If

            If WebView21.CoreWebView2 Is Nothing Then
                Await WebView21.EnsureCoreWebView2Async(Nothing)
            Else
                WebView21.CoreWebView2.Navigate(NavigateURL)
            End If
        Catch
        End Try
    End Sub
End Class
