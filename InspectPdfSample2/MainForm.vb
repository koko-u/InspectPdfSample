Imports iText.Kernel.Geom
Imports iText.Kernel.Pdf

Public Class MainForm

    Private ReadOnly _pdfPageSizeModel As PdfPageSizeModel = New PdfPageSizeModel()
    Private ReadOnly _standardPageSizeModel As StandardPageSizeModel = New StandardPageSizeModel()

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        FileNameTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.FileName))

        OpenPdfFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        PdfWidthPointTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.WidthPoint))
        PdfHeightPointTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.HeightPoint))
        PdfWidthInchesTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.WidthInches))
        PdfHeightInchesTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.HeightInches))
        PdfWidthCmTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.WidthCm))
        PdfHeightCmTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.HeightCm))

        With PageSizeComboBox.Items
            .Add(StandardPageSize.A0)
            .Add(StandardPageSize.A1)
            .Add(StandardPageSize.A2)
            .Add(StandardPageSize.A3)
            .Add(StandardPageSize.A4)
            .Add(StandardPageSize.A5)
            .Add(StandardPageSize.A6)
            .Add(StandardPageSize.A7)
            .Add(StandardPageSize.B0)
            .Add(StandardPageSize.B1)
            .Add(StandardPageSize.B2)
            .Add(StandardPageSize.B3)
            .Add(StandardPageSize.B4)
            .Add(StandardPageSize.B5)
            .Add(StandardPageSize.B6)
            .Add(StandardPageSize.B7)
        End With

        StandardWidthPointTextBox.DataBindings.Add(NameOf(TextBox.Text), _standardPageSizeModel, NameOf(StandardPageSizeModel.WidthPointText))
        StandardHeightPointTextBox.DataBindings.Add(NameOf(TextBox.Text), _standardPageSizeModel, NameOf(StandardPageSizeModel.HeightPoint))
        StandardWidthInchesTextBox.DataBindings.Add(NameOf(TextBox.Text), _standardPageSizeModel, NameOf(StandardPageSizeModel.WidthInches))
        StandardHeightInchesTextBox.DataBindings.Add(NameOf(TextBox.Text), _standardPageSizeModel, NameOf(StandardPageSizeModel.HeightInches))
        StandardWidthCmTextBox.DataBindings.Add(NameOf(TextBox.Text), _standardPageSizeModel, NameOf(StandardPageSizeModel.WidthCm))
        StandardHeightCmTextBox.DataBindings.Add(NameOf(TextBox.Text), _standardPageSizeModel, NameOf(StandardPageSizeModel.HeightCm))

        PageSizeComboBox.SelectedIndex = 0

    End Sub

    Private Sub OpenDialogButton_Click(sender As Object, e As EventArgs) Handles OpenDialogButton.Click
        If OpenPdfFileDialog.ShowDialog() = DialogResult.OK Then
            Using reader As New PdfReader(OpenPdfFileDialog.FileName)
                Using document As New PdfDocument(reader)

                    _pdfPageSizeModel.FileName = OpenPdfFileDialog.FileName
                    Dim pageSize = GetPage(document)
                    _pdfPageSizeModel.WidthPoint = pageSize.GetWidth()
                    _pdfPageSizeModel.HeightPoint = pageSize.GetHeight()
                End Using
            End Using
        End If

    End Sub

    Private Sub PageSizeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles PageSizeComboBox.SelectedIndexChanged

        _standardPageSizeModel.PageSize = PageSizeComboBox.SelectedItem
    End Sub

    Private Function GetPage(document As PdfDocument) As Rectangle
        If document.GetNumberOfPages() = 0 Then Return Nothing


        Dim pageSize = document.GetFirstPage().GetPageSize()

        Dim forDebug As New Dictionary(Of Integer, Rectangle)() From {{1, pageSize}}

        For i = 2 To document.GetNumberOfPages()
            If Not pageSize.EqualsWithEpsilon(document.GetPage(i).GetPageSize(), 1.0F) Then
                forDebug.Add(i, document.GetPage(i).GetPageSize())
            End If
        Next

        Return pageSize

    End Function
End Class
