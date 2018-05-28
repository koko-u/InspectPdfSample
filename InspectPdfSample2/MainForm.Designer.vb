<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OpenPdfFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StandardWidthCmTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StandardWidthInchesTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.StandardWidthPointTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StandardHeightCmTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StandardHeightInchesTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.StandardHeightPointTextBox = New System.Windows.Forms.TextBox()
        Me.PageSizeComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PdfHeightCmTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PdfHeightInchesTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PdfHeightPointTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PdfWidthCmTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PdfWidthInchesTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PdfWidthPointTextBox = New System.Windows.Forms.TextBox()
        Me.OpenDialogButton = New System.Windows.Forms.Button()
        Me.FileNameTextBox = New System.Windows.Forms.TextBox()
        Me.PageSizeDataSet = New InspectPdfSample2.PageSizeDataSet()
        Me.ASizeDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DimensionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSizeDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DimensionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PageSizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASizeDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSizeDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenPdfFileDialog
        '
        Me.OpenPdfFileDialog.DefaultExt = "pdf"
        Me.OpenPdfFileDialog.Filter = "PDF files|*.pdf"
        Me.OpenPdfFileDialog.Title = "対象のPDFファイルを選択"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SizeDataGridViewTextBoxColumn1, Me.DimensionDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.BSizeDataTableBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(512, 238)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 21
        Me.DataGridView2.Size = New System.Drawing.Size(240, 200)
        Me.DataGridView2.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SizeDataGridViewTextBoxColumn, Me.DimensionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ASizeDataTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(512, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(242, 200)
        Me.DataGridView1.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(430, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 12)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "cm"
        '
        'StandardWidthCmTextBox
        '
        Me.StandardWidthCmTextBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StandardWidthCmTextBox.Location = New System.Drawing.Point(324, 19)
        Me.StandardWidthCmTextBox.Name = "StandardWidthCmTextBox"
        Me.StandardWidthCmTextBox.ReadOnly = True
        Me.StandardWidthCmTextBox.Size = New System.Drawing.Size(100, 23)
        Me.StandardWidthCmTextBox.TabIndex = 4
        Me.StandardWidthCmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(271, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 12)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Inch"
        '
        'StandardWidthInchesTextBox
        '
        Me.StandardWidthInchesTextBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StandardWidthInchesTextBox.Location = New System.Drawing.Point(165, 19)
        Me.StandardWidthInchesTextBox.Name = "StandardWidthInchesTextBox"
        Me.StandardWidthInchesTextBox.ReadOnly = True
        Me.StandardWidthInchesTextBox.Size = New System.Drawing.Size(100, 23)
        Me.StandardWidthInchesTextBox.TabIndex = 2
        Me.StandardWidthInchesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(113, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 12)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Point"
        '
        'StandardWidthPointTextBox
        '
        Me.StandardWidthPointTextBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StandardWidthPointTextBox.Location = New System.Drawing.Point(7, 19)
        Me.StandardWidthPointTextBox.Name = "StandardWidthPointTextBox"
        Me.StandardWidthPointTextBox.ReadOnly = True
        Me.StandardWidthPointTextBox.Size = New System.Drawing.Size(100, 23)
        Me.StandardWidthPointTextBox.TabIndex = 0
        Me.StandardWidthPointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.StandardWidthCmTextBox)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.StandardWidthInchesTextBox)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.StandardWidthPointTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 273)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(481, 76)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Width"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.StandardHeightCmTextBox)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.StandardHeightInchesTextBox)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.StandardHeightPointTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 364)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(481, 76)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Height"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(430, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 12)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "cm"
        '
        'StandardHeightCmTextBox
        '
        Me.StandardHeightCmTextBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StandardHeightCmTextBox.Location = New System.Drawing.Point(324, 19)
        Me.StandardHeightCmTextBox.Name = "StandardHeightCmTextBox"
        Me.StandardHeightCmTextBox.ReadOnly = True
        Me.StandardHeightCmTextBox.Size = New System.Drawing.Size(100, 23)
        Me.StandardHeightCmTextBox.TabIndex = 4
        Me.StandardHeightCmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(271, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 12)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Inch"
        '
        'StandardHeightInchesTextBox
        '
        Me.StandardHeightInchesTextBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StandardHeightInchesTextBox.Location = New System.Drawing.Point(165, 19)
        Me.StandardHeightInchesTextBox.Name = "StandardHeightInchesTextBox"
        Me.StandardHeightInchesTextBox.ReadOnly = True
        Me.StandardHeightInchesTextBox.Size = New System.Drawing.Size(100, 23)
        Me.StandardHeightInchesTextBox.TabIndex = 2
        Me.StandardHeightInchesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(113, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 12)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Point"
        '
        'StandardHeightPointTextBox
        '
        Me.StandardHeightPointTextBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StandardHeightPointTextBox.Location = New System.Drawing.Point(7, 19)
        Me.StandardHeightPointTextBox.Name = "StandardHeightPointTextBox"
        Me.StandardHeightPointTextBox.ReadOnly = True
        Me.StandardHeightPointTextBox.Size = New System.Drawing.Size(100, 23)
        Me.StandardHeightPointTextBox.TabIndex = 0
        Me.StandardHeightPointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PageSizeComboBox
        '
        Me.PageSizeComboBox.FormattingEnabled = True
        Me.PageSizeComboBox.Location = New System.Drawing.Point(12, 247)
        Me.PageSizeComboBox.Name = "PageSizeComboBox"
        Me.PageSizeComboBox.Size = New System.Drawing.Size(121, 20)
        Me.PageSizeComboBox.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.PdfHeightCmTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PdfHeightInchesTextBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.PdfHeightPointTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 76)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Height"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(430, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "cm"
        '
        'PdfHeightCmTextBox
        '
        Me.PdfHeightCmTextBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PdfHeightCmTextBox.Location = New System.Drawing.Point(324, 19)
        Me.PdfHeightCmTextBox.Name = "PdfHeightCmTextBox"
        Me.PdfHeightCmTextBox.ReadOnly = True
        Me.PdfHeightCmTextBox.Size = New System.Drawing.Size(100, 23)
        Me.PdfHeightCmTextBox.TabIndex = 4
        Me.PdfHeightCmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(271, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 12)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Inch"
        '
        'PdfHeightInchesTextBox
        '
        Me.PdfHeightInchesTextBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PdfHeightInchesTextBox.Location = New System.Drawing.Point(165, 19)
        Me.PdfHeightInchesTextBox.Name = "PdfHeightInchesTextBox"
        Me.PdfHeightInchesTextBox.ReadOnly = True
        Me.PdfHeightInchesTextBox.Size = New System.Drawing.Size(100, 23)
        Me.PdfHeightInchesTextBox.TabIndex = 2
        Me.PdfHeightInchesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(113, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 12)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Point"
        '
        'PdfHeightPointTextBox
        '
        Me.PdfHeightPointTextBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PdfHeightPointTextBox.Location = New System.Drawing.Point(7, 19)
        Me.PdfHeightPointTextBox.Name = "PdfHeightPointTextBox"
        Me.PdfHeightPointTextBox.ReadOnly = True
        Me.PdfHeightPointTextBox.Size = New System.Drawing.Size(100, 23)
        Me.PdfHeightPointTextBox.TabIndex = 0
        Me.PdfHeightPointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PdfWidthCmTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PdfWidthInchesTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PdfWidthPointTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 76)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Width"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(430, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "cm"
        '
        'PdfWidthCmTextBox
        '
        Me.PdfWidthCmTextBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PdfWidthCmTextBox.Location = New System.Drawing.Point(324, 19)
        Me.PdfWidthCmTextBox.Name = "PdfWidthCmTextBox"
        Me.PdfWidthCmTextBox.ReadOnly = True
        Me.PdfWidthCmTextBox.Size = New System.Drawing.Size(100, 23)
        Me.PdfWidthCmTextBox.TabIndex = 4
        Me.PdfWidthCmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Inch"
        '
        'PdfWidthInchesTextBox
        '
        Me.PdfWidthInchesTextBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PdfWidthInchesTextBox.Location = New System.Drawing.Point(165, 19)
        Me.PdfWidthInchesTextBox.Name = "PdfWidthInchesTextBox"
        Me.PdfWidthInchesTextBox.ReadOnly = True
        Me.PdfWidthInchesTextBox.Size = New System.Drawing.Size(100, 23)
        Me.PdfWidthInchesTextBox.TabIndex = 2
        Me.PdfWidthInchesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Point"
        '
        'PdfWidthPointTextBox
        '
        Me.PdfWidthPointTextBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PdfWidthPointTextBox.Location = New System.Drawing.Point(7, 19)
        Me.PdfWidthPointTextBox.Name = "PdfWidthPointTextBox"
        Me.PdfWidthPointTextBox.ReadOnly = True
        Me.PdfWidthPointTextBox.Size = New System.Drawing.Size(100, 23)
        Me.PdfWidthPointTextBox.TabIndex = 0
        Me.PdfWidthPointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OpenDialogButton
        '
        Me.OpenDialogButton.AutoSize = True
        Me.OpenDialogButton.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OpenDialogButton.Location = New System.Drawing.Point(418, 12)
        Me.OpenDialogButton.Name = "OpenDialogButton"
        Me.OpenDialogButton.Padding = New System.Windows.Forms.Padding(2)
        Me.OpenDialogButton.Size = New System.Drawing.Size(75, 26)
        Me.OpenDialogButton.TabIndex = 10
        Me.OpenDialogButton.Text = "参照..."
        Me.OpenDialogButton.UseVisualStyleBackColor = True
        '
        'FileNameTextBox
        '
        Me.FileNameTextBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FileNameTextBox.Location = New System.Drawing.Point(12, 12)
        Me.FileNameTextBox.Name = "FileNameTextBox"
        Me.FileNameTextBox.ReadOnly = True
        Me.FileNameTextBox.Size = New System.Drawing.Size(400, 23)
        Me.FileNameTextBox.TabIndex = 9
        Me.FileNameTextBox.TabStop = False
        '
        'PageSizeDataSet
        '
        Me.PageSizeDataSet.DataSetName = "PageSizeDataSet"
        Me.PageSizeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ASizeDataTableBindingSource
        '
        Me.ASizeDataTableBindingSource.DataMember = "ASizeDataTable"
        Me.ASizeDataTableBindingSource.DataSource = Me.PageSizeDataSet
        '
        'SizeDataGridViewTextBoxColumn
        '
        Me.SizeDataGridViewTextBoxColumn.DataPropertyName = "Size"
        Me.SizeDataGridViewTextBoxColumn.HeaderText = "Size"
        Me.SizeDataGridViewTextBoxColumn.Name = "SizeDataGridViewTextBoxColumn"
        Me.SizeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DimensionDataGridViewTextBoxColumn
        '
        Me.DimensionDataGridViewTextBoxColumn.DataPropertyName = "Dimension"
        Me.DimensionDataGridViewTextBoxColumn.HeaderText = "Dimension"
        Me.DimensionDataGridViewTextBoxColumn.Name = "DimensionDataGridViewTextBoxColumn"
        Me.DimensionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BSizeDataTableBindingSource
        '
        Me.BSizeDataTableBindingSource.DataMember = "BSizeDataTable"
        Me.BSizeDataTableBindingSource.DataSource = Me.PageSizeDataSet
        '
        'SizeDataGridViewTextBoxColumn1
        '
        Me.SizeDataGridViewTextBoxColumn1.DataPropertyName = "Size"
        Me.SizeDataGridViewTextBoxColumn1.HeaderText = "Size"
        Me.SizeDataGridViewTextBoxColumn1.Name = "SizeDataGridViewTextBoxColumn1"
        Me.SizeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DimensionDataGridViewTextBoxColumn1
        '
        Me.DimensionDataGridViewTextBoxColumn1.DataPropertyName = "Dimension"
        Me.DimensionDataGridViewTextBoxColumn1.HeaderText = "Dimension"
        Me.DimensionDataGridViewTextBoxColumn1.Name = "DimensionDataGridViewTextBoxColumn1"
        Me.DimensionDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PageSizeComboBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OpenDialogButton)
        Me.Controls.Add(Me.FileNameTextBox)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PageSizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASizeDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSizeDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenPdfFileDialog As OpenFileDialog
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents StandardWidthCmTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents StandardWidthInchesTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents StandardWidthPointTextBox As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents StandardHeightCmTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents StandardHeightInchesTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents StandardHeightPointTextBox As TextBox
    Friend WithEvents PageSizeComboBox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PdfHeightCmTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PdfHeightInchesTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PdfHeightPointTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PdfWidthCmTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PdfWidthInchesTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PdfWidthPointTextBox As TextBox
    Friend WithEvents OpenDialogButton As Button
    Friend WithEvents FileNameTextBox As TextBox
    Friend WithEvents SizeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DimensionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BSizeDataTableBindingSource As BindingSource
    Friend WithEvents PageSizeDataSet As PageSizeDataSet
    Friend WithEvents SizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DimensionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ASizeDataTableBindingSource As BindingSource
End Class
