Imports System.Windows.Markup

Public Class BooleanToTextConverter
    Inherits MarkupExtension
    Implements IValueConverter

    Public Function Convert(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
        If value Is Nothing Then Return "null"

        If CBool(value) Then
            Return "Yes"
        Else
            Return "No"
        End If
    End Function

    Public Function ConvertBack(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New System.NotImplementedException()
    End Function

    Public Overrides Function ProvideValue(ByVal serviceProvider As System.IServiceProvider) As Object
        Return Me
    End Function
End Class
