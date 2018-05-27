Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class MainForm

    Private ReadOnly _pdfPageSizeModel As New PdfPageSizeModel()
    Private ReadOnly _standardPageSizeModel As New StandardPageSizeModel()

    Private Sub OpenDialogButton_Click(sender As Object, e As EventArgs) _
        Handles OpenDialogButton.Click

        If OpenPdfFileDialog.ShowDialog() = DialogResult.OK Then
            Using reader As New PdfReader(OpenPdfFileDialog.FileName)
                _pdfPageSizeModel.FileName = OpenPdfFileDialog.FileName
                Dim pageSize = GetPage(reader)
                _pdfPageSizeModel.WidthPoint = pageSize.Width
                _pdfPageSizeModel.HeightPoint = pageSize.Height
            End Using
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        FileNameTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.FileName))

        OpenPdfFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        PdfWidthPointTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.WidthPoint))
        PdfHeightPointTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.HeightPoint))
        PdfWidthInchesTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.WidthInches))
        PdfHeightInchesTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.HeightInches))
        PdfWidthCmTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.WidthCm))
        PdfHeightCmTextBox.DataBindings.Add(NameOf(TextBox.Text), _pdfPageSizeModel, NameOf(PdfPageSizeModel.HeightCm))

        Dim pages = New List(Of String) From {
                "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7",
                "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7"}
        PageSizeComboBox.Items.AddRange(pages.Select(Function(n) New StandardPageSize(n)).ToArray())

        StandardWidthPointTextBox.DataBindings.Add(NameOf(TextBox.Text), _standardPageSizeModel, NameOf(StandardPageSizeModel.WidthPointText))
        StandardHeightPointTextBox.DataBindings.Add(NameOf(TextBox.Text), _standardPageSizeModel, NameOf(StandardPageSizeModel.HeightPoint))
        StandardWidthInchesTextBox.DataBindings.Add(NameOf(TextBox.Text), _standardPageSizeModel, NameOf(StandardPageSizeModel.WidthInches))
        StandardHeightInchesTextBox.DataBindings.Add(NameOf(TextBox.Text), _standardPageSizeModel, NameOf(StandardPageSizeModel.HeightInches))
        StandardWidthCmTextBox.DataBindings.Add(NameOf(TextBox.Text), _standardPageSizeModel, NameOf(StandardPageSizeModel.WidthCm))
        StandardHeightCmTextBox.DataBindings.Add(NameOf(TextBox.Text), _standardPageSizeModel, NameOf(StandardPageSizeModel.HeightCm))

        PageSizeComboBox.SelectedIndex = 0
    End Sub

    Private Sub PageSizeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles PageSizeComboBox.SelectedIndexChanged

        _standardPageSizeModel.PageSize = PageSizeComboBox.SelectedItem
    End Sub

    Private Function GetPage(reader As PdfReader) As Rectangle
        If reader.NumberOfPages = 0 Then Return Nothing

        Dim pageSize = reader.GetPageSize(1)

        Dim forDebug As New Dictionary(Of Integer, Rectangle)() From {{1, pageSize}}

        For i = 2 To reader.NumberOfPages
            If Math.Abs(pageSize.Width - reader.GetPageSize(i).Width) > 1.0 OrElse
               Math.Abs(pageSize.Height - reader.GetPageSize(i).Height) > 1.0 Then
                forDebug.Add(i, reader.GetPageSize(i))
                'Return Nothing
            End If
        Next

        Return pageSize

    End Function
End Class
