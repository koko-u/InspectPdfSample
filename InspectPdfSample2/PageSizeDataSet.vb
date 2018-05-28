Partial Class PageSizeDataSet
    Partial Public Class ASizeDataTableDataTable
        Private Sub ASizeDataTableDataTable_Initialized(sender As Object, e As EventArgs) _
            Handles Me.Initialized

            AddASizeDataTableRow("A0", "118.9cm x 84.1cm")
            AddASizeDataTableRow("A1", " 84.1cm x 59.4cm")
            AddASizeDataTableRow("A2", " 59.4cm x 42.0cm")
            AddASizeDataTableRow("A3", " 42.0cm x 29.7cm")
            AddASizeDataTableRow("A4", " 29.7cm x 21.0cm")
            AddASizeDataTableRow("A5", " 21.0cm x 14.8cm")
            AddASizeDataTableRow("A6", " 14.8cm x 10.5cm")
            AddASizeDataTableRow("A7", " 10.5cm x 07.4cm")

        End Sub
    End Class

    Partial Public Class BSizeDataTableDataTable
        Private Sub BSizeDataTableDataTable_Initialized(sender As Object, e As EventArgs) _
            Handles Me.Initialized

            AddBSizeDataTableRow("B0", "145.6cm x 103.0cm")
            AddBSizeDataTableRow("B1", "103.0cm x  72.8cm")
            AddBSizeDataTableRow("B2", " 72.8cm x  51.5cm")
            AddBSizeDataTableRow("B3", " 51.5cm x  36.4cm")
            AddBSizeDataTableRow("B4", " 36.4cm x  25.7cm")
            AddBSizeDataTableRow("B5", " 25.7cm x  18.2cm")
            AddBSizeDataTableRow("B6", " 18.2cm x  12.8cm")
            AddBSizeDataTableRow("B7", " 12.8cm x  09.1cm")

        End Sub
    End Class
End Class
