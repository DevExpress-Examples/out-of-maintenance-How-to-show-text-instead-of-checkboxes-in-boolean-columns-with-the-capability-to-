Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports DevExpress.Mvvm.DataAnnotations

Public Class ViewModel
    Public Property List As ObservableCollection(Of TestData)

    Public Sub New()
        List = New ObservableCollection(Of TestData)()

        For i As Integer = 0 To 30 - 1
            Dim t = New TestData() With {
                .Text = "Element" & i.ToString(),
                .Number = i,
                .IsChecked = i Mod 2 = 0,
                .IsChecked_Attribute = i Mod 2 <> 0
            }
            List.Add(t)
        Next
    End Sub
End Class

Public Class TestData
    Implements INotifyPropertyChanged

    Private _number As Integer
    Private _text As String
    Private _isChecked As Boolean
    Private _isChecked_Attribute As Boolean

    Public Property Number As Integer
        Get
            Return _number
        End Get
        Set(ByVal value As Integer)
            If _number = value Then Return
            _number = value
            NotifyChanged("Number")
        End Set
    End Property

    Public Property Text As String
        Get
            Return _text
        End Get
        Set(ByVal value As String)
            If _text = value Then Return
            _text = value
            NotifyChanged("Text")
        End Set
    End Property

    Public Property IsChecked As Boolean
        Get
            Return _isChecked
        End Get
        Set(ByVal value As Boolean)
            If _isChecked = value Then Return
            _isChecked = value
            NotifyChanged("IsChecked")
        End Set
    End Property

    <GridEditor(TemplateKey:="ComboBoxEditSettingsTemplate")>
    Public Property IsChecked_Attribute As Boolean
        Get
            Return _isChecked_Attribute
        End Get
        Set(ByVal value As Boolean)
            If _isChecked_Attribute = value Then Return
            _isChecked_Attribute = value
            NotifyChanged("IsChecked_Attribute")
        End Set
    End Property

    Private Sub NotifyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
