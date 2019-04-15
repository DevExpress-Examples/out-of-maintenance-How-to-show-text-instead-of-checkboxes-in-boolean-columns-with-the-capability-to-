Imports DevExpress.Mvvm.DataAnnotations

Class MainWindow
    Sub New()

        MetadataLocator.[Default] = MetadataLocator.Create().AddMetadata(Of Boolean, EditorProvider)()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class

Public Class EditorProvider
    Implements IMetadataProvider(Of Boolean)

    Public Sub BuildMetadata(ByVal builder As MetadataBuilder(Of Boolean)) Implements IMetadataProvider(Of Boolean).BuildMetadata
        builder.GridEditor("TextEditSettingsTemplate")
    End Sub
End Class

