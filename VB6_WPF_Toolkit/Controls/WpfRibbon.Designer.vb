Option Strict On

Imports System.Windows.Forms
Imports System.ComponentModel
Imports VB6_WPF_Toolkit_ControlTemplates.Controls

Namespace Controls

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class WpfRibbon
        Inherits System.Windows.Forms.UserControl

        'WpfRibbon overrides dispose to clean up the component list.
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
        Private _elementHost As System.Windows.Forms.Integration.ElementHost

        'WPF Button Element

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me._elementHost = New System.Windows.Forms.Integration.ElementHost()
            Me.WpfRibbonControl1 = New VB6_WPF_Toolkit_ControlTemplates.Controls.WpfRibbonControl()
            Me.SuspendLayout()
            '
            '_elementHost
            '
            Me._elementHost.Dock = System.Windows.Forms.DockStyle.Fill
            Me._elementHost.Location = New System.Drawing.Point(0, 0)
            Me._elementHost.Name = "_elementHost"
            Me._elementHost.Size = New System.Drawing.Size(301, 157)
            Me._elementHost.TabIndex = 0
            Me._elementHost.Child = Me.WpfRibbonControl1
            '
            'WpfRibbon
            '
            Me.Controls.Add(Me._elementHost)
            Me.Name = "WpfRibbon"
            Me.Size = New System.Drawing.Size(301, 157)
            Me.ResumeLayout(False)

        End Sub
        Private WpfRibbonControl1 As VB6_WPF_Toolkit_ControlTemplates.Controls.WpfRibbonControl

    End Class
End Namespace