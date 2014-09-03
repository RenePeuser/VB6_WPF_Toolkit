Imports System.Windows.Controls

Public Class WpfDocumentViewerControl
    Public ReadOnly Property DocumentViewerControl As DocumentViewer
        Get
            Return _documentViewer
        End Get
    End Property

    Public Sub OpenDocument(ByVal sPath As String)
        Dim xps As Xps.Packaging.XpsDocument = New Xps.Packaging.XpsDocument(sPath, IO.FileAccess.Read)
        _documentViewer.Document = xps.GetFixedDocumentSequence()
    End Sub

End Class
