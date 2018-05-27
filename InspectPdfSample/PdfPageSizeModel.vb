Imports System.ComponentModel

Public Class PdfPageSizeModel
    Implements INotifyPropertyChanged

    Const Tolerance As Single = 0.0001

    Public Event PropertyChanged As PropertyChangedEventHandler _
        Implements INotifyPropertyChanged.PropertyChanged

    Private _fileName As String
    Public Property FileName As String
        Get
            Return _fileName
        End Get
        Set
            If Not String.Equals(_fileName, Value) Then
                _fileName = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(FileName)))
            End If
        End Set
    End Property

    Private _widthPoint As Single
    Public Property WidthPoint As Single
        Get
            Return _widthPoint
        End Get
        Set
            If Math.Abs(_widthPoint - Value) > Tolerance Then
                _widthPoint = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(WidthPointText)))
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(WidthInches)))
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(WidthCm)))
            End If
        End Set
    End Property
    Public ReadOnly Property WidthPointText As String
        Get
            Return WidthPoint.ToString()
        End Get
    End Property

    Public ReadOnly Property WidthInches As Single
        Get
            Return WidthPoint / 72.0F
        End Get
    End Property
    Public ReadOnly Property WidthCm As Single
        Get
            Return WidthInches * 2.54F
        End Get
    End Property

    Private _heightPoint As Single
    Public Property HeightPoint As Single
        Get
            Return _heightPoint
        End Get
        Set
            If Math.Abs(_heightPoint - Value) > Tolerance Then
                _heightPoint = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(HeightPoint)))
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(HeightInches)))
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(HeightCm)))
            End If

        End Set
    End Property

    Public ReadOnly Property HeightInches As Single
        Get
            Return HeightPoint / 72.0F
        End Get
    End Property
    Public ReadOnly Property HeightCm As Single
        Get
            Return HeightInches * 2.54F
        End Get
    End Property

End Class
