Public Class WpfSliderControl
    Public ReadOnly Property SliderControl As Slider
        Get
            Return _slider
        End Get
    End Property

    Private Sub _slider_ValueChanged(sender As System.Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of System.Double)) Handles _slider.ValueChanged
        RaiseEvent SliderValueChanged(e.NewValue)
    End Sub

    Public Event SliderValueChanged(ByVal value As Double)

End Class
