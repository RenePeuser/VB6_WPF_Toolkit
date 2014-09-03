Public Class WpfButtonControl

    Public ReadOnly Property ButtonControl As Button
        Get
            Return Me._button
        End Get
    End Property

    Private Sub _button_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles _button.Click
        RaiseEvent ButtonClick()
    End Sub

    Public Event ButtonClick()

End Class
