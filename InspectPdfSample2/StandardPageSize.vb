Imports iText.Kernel.Geom

Public Class StandardPageSize
    Public ReadOnly Property Size As Rectangle
    Public ReadOnly Property Name As String

    Public Shared A0 As StandardPageSize = New StandardPageSize("A0")
    Public Shared A1 As StandardPageSize = New StandardPageSize("A1")
    Public Shared A2 As StandardPageSize = New StandardPageSize("A2")
    Public Shared A3 As StandardPageSize = New StandardPageSize("A3")
    Public Shared A4 As StandardPageSize = New StandardPageSize("A4")
    Public Shared A5 As StandardPageSize = New StandardPageSize("A5")
    Public Shared A6 As StandardPageSize = New StandardPageSize("A6")
    Public Shared A7 As StandardPageSize = New StandardPageSize("A7")

    Public Shared B0 As StandardPageSize = New StandardPageSize("B0")
    Public Shared B1 As StandardPageSize = New StandardPageSize("B1")
    Public Shared B2 As StandardPageSize = New StandardPageSize("B2")
    Public Shared B3 As StandardPageSize = New StandardPageSize("B3")
    Public Shared B4 As StandardPageSize = New StandardPageSize("B4")
    Public Shared B5 As StandardPageSize = New StandardPageSize("B5")
    Public Shared B6 As StandardPageSize = New StandardPageSize("B6")
    Public Shared B7 As StandardPageSize = New StandardPageSize("B7")


    Private Sub New(pageSizeName As String)

        Name = pageSizeName
        Select Case pageSizeName
            Case "A0"
                Size = PageSize.A0
            Case "A1"
                Size = PageSize.A1
            Case "A2"
                Size = PageSize.A2
            Case "A3"
                Size = PageSize.A3
            Case "A4"
                Size = PageSize.A4
            Case "A5"
                Size = PageSize.A5
            Case "A6"
                Size = PageSize.A6
            Case "A7"
                Size = PageSize.A7

            Case "B0"
                Size = PageSize.B0
            Case "B1"
                Size = PageSize.B1
            Case "B2"
                Size = PageSize.B2
            Case "B3"
                Size = PageSize.B3
            Case "B4"
                Size = PageSize.B4
            Case "B5"
                Size = PageSize.B5
            Case "B6"
                Size = PageSize.B6
            Case "B7"
                Size = PageSize.B7

            Case Else
                Throw New ArgumentException()
        End Select

    End Sub

    ''' <inheritdoc />
    Public Overrides Function ToString() As String
        Return Name
    End Function

End Class
