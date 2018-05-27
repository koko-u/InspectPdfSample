Imports iTextSharp.text

Public Class StandardPageSize
    Public ReadOnly Property Size As Rectangle
    Public ReadOnly Property Name As String

    Public Sub New(pageSizeName As String)
        Trace.Assert(IsSupportPageSize(pageSizeName))

        Name = pageSizeName
        Size = PageSize.GetRectangle(pageSizeName)
    End Sub

    ''' <inheritdoc />
    Public Overrides Function ToString() As String
        Return Name
    End Function

    Private Shared Function IsSupportPageSize(pageSizeName As String) As Boolean
        Select Case pageSizeName
            Case "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7"
                Return True
            Case "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7"
                Return True
            Case Else
                Return False
        End Select
    End Function
End Class
