Public Class splashScreen

    ''' <summary>
    ''' Initializes a new instance of the splashScreen class and sets up scaling.
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        Me.AutoScaleMode = AutoScaleMode.Dpi
    End Sub

    ''' <summary>
    ''' Handles the KeyDown event for the splash screen. Closes the form if Escape is pressed.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">A KeyEventArgs that contains the event data.</param>
    Private Sub Form5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Handles the Load event for the splash screen. Starts the timer and sets the copyright label.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        ' Set copyright label
        Label3.Text = $"© RJ - Transportation 2013-{Date.Now.Year} " & vbCrLf & "Developed By Nader Sawalha"
    End Sub

    ''' <summary>
    ''' Handles the Tick event for Timer1. Shows the home form, stops the timer, and hides the splash screen.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        home.Show()
        Timer1.Stop()
        Me.Hide()
    End Sub
End Class