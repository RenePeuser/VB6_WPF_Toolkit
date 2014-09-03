Option Strict On

Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Windows.Forms.Integration
Imports VB6_WPF_Toolkit_ControlTemplates.Controls

Namespace Controls

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class WpfSlider
        Inherits System.Windows.Forms.UserControl

        'WpfSlider overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'ElementHost um WPF Elemente zu hosten
        Private _elementHost As ElementHost

        'WPF Button Element
        Private WithEvents _wpfSliderControl As WpfSliderControl

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            _elementHost = New ElementHost
            _wpfSliderControl = New WpfSliderControl

            Me.SuspendLayout()
            '
            '_elementHost
            '
            Me._elementHost.Dock = System.Windows.Forms.DockStyle.Fill
            Me._elementHost.Location = New System.Drawing.Point(0, 0)
            Me._elementHost.Margin = New System.Windows.Forms.Padding(0)
            Me._elementHost.Name = "_elementHost"
            Me._elementHost.Size = New System.Drawing.Size(Me.Width, Me.Height)
            Me._elementHost.TabIndex = 0
            Me._elementHost.Child = _wpfSliderControl
            '
            'WpfButton
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me._elementHost)
            Me.Name = "WpfSlider"
            Me.ResumeLayout(False)



        End Sub

    End Class
End Namespace