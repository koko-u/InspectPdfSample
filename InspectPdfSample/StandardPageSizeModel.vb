Imports System.ComponentModel

Public Class StandardPageSizeModel
    Implements INotifyPropertyChanged

    Const Tolerance As Single = 0.0001

    Public Event PropertyChanged As PropertyChangedEventHandler _
        Implements INotifyPropertyChanged.PropertyChanged

    Private _pageSize As StandardPageSize
    Public Property PageSize As Object
        Get
            Return _pageSize
        End Get
        Set
            Dim standardPageSize = DirectCast(Value, StandardPageSize)
            If standardPageSize IsNot Nothing Then
                If _pageSize Is Nothing OrElse Not String.Equals(_pageSize.Name, standardPageSize.Name) Then
                    _pageSize = standardPageSize
                    WidthPoint = _pageSize.Size.Width
                    HeightPoint = _pageSize.Size.Height
                End If
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
