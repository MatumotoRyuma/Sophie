Imports System.IO.Path
Imports System.Windows
Imports System.Windows.Controls

Class Sophie : Inherits Application
    Shared Sub Main(args As String())
        Dim app As New Sophie
        app.StartupUri = New Uri(Combine(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase,"Window.xaml"))
        app.Run()
    End Sub

    Private appHasLaunched As Boolean = False

    Protected Overrides Sub OnActivated(ea As EventArgs)
        If appHasLaunched Then Return
        appHasLaunched = True
        Dim content = DirectCast(MainWindow.Content, FrameworkElement)
        Dim browser = DirectCast(content.FindName("Browser"), WebBrowser)
        Dim back = DirectCast(content.FindName("Back"), Button)
        Dim forward = DirectCast(content.FindName("Forward"), Button)
        Dim reload = DirectCast(content.FindName("Reload"), Button)
        Dim move = DirectCast(content.FindName("Move"), Button)
        Dim url = DirectCast(content.FindName("Url"), TextBox)
        AddHandler back.Click, Sub(s, e) If browser.CanGoBack Then browser.GoBack()
        AddHandler forward.Click, Sub(s, e) If browser.CanGoForward Then browser.GoForward()
        AddHandler reload.Click, AddressOf browser.Refresh
        AddHandler move.Click, Sub(s, e) browser.Navigate(New Uri(url.Text))
        AddHandler url.KeyDown, Sub(s, e) If e.Key = System.Windows.Input.Key.Enter Then browser.Navigate(New Uri(url.Text))
        AddHandler browser.Navigated, Sub(s, e) url.Text = browser.Source.ToString()
    End Sub
End Class