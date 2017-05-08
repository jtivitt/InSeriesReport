<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InSeriesReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.RackNbr = New System.Windows.Forms.TextBox()
        Me.RackID = New System.Windows.Forms.TextBox()
        Me.VINNbr = New System.Windows.Forms.TextBox()
        Me.LabelsRadio = New System.Windows.Forms.RadioButton()
        Me.AuditReportRadio = New System.Windows.Forms.RadioButton()
        Me.AuditTotalsRadio = New System.Windows.Forms.RadioButton()
        Me.TruckLoadsRadio = New System.Windows.Forms.RadioButton()
        Me.InventoryRadio = New System.Windows.Forms.RadioButton()
        Me.UserRadio = New System.Windows.Forms.RadioButton()
        Me.VerifyLabelRadio = New System.Windows.Forms.RadioButton()
        Me.SupplierRadio = New System.Windows.Forms.RadioButton()
        Me.SelectReportLabel = New System.Windows.Forms.Label()
        Me.RackNbrLabel = New System.Windows.Forms.Label()
        Me.RackIDLabel = New System.Windows.Forms.Label()
        Me.RotationNbrLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VinNbrLabel = New System.Windows.Forms.Label()
        Me.SelectPartCombo = New System.Windows.Forms.ComboBox()
        Me.SelectPartLabel = New System.Windows.Forms.Label()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.SelectPrinterCombo = New System.Windows.Forms.ComboBox()
        Me.SelectPrinterLabel = New System.Windows.Forms.Label()
        Me.PrinterLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RotationNbrStart = New System.Windows.Forms.TextBox()
        Me.RotationNbrEnd = New System.Windows.Forms.TextBox()
        Me.PartLabelText = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(962, 29)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(151, 37)
        Me.SearchButton.TabIndex = 0
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'RackNbr
        '
        Me.RackNbr.Location = New System.Drawing.Point(300, 72)
        Me.RackNbr.Name = "RackNbr"
        Me.RackNbr.Size = New System.Drawing.Size(144, 20)
        Me.RackNbr.TabIndex = 2
        Me.RackNbr.Text = "928"
        '
        'RackID
        '
        Me.RackID.Location = New System.Drawing.Point(300, 98)
        Me.RackID.Name = "RackID"
        Me.RackID.Size = New System.Drawing.Size(144, 20)
        Me.RackID.TabIndex = 3
        Me.RackID.Text = "1816732"
        '
        'VINNbr
        '
        Me.VINNbr.Location = New System.Drawing.Point(300, 150)
        Me.VINNbr.Name = "VINNbr"
        Me.VINNbr.Size = New System.Drawing.Size(144, 20)
        Me.VINNbr.TabIndex = 6
        '
        'LabelsRadio
        '
        Me.LabelsRadio.AutoSize = True
        Me.LabelsRadio.Location = New System.Drawing.Point(16, 44)
        Me.LabelsRadio.Name = "LabelsRadio"
        Me.LabelsRadio.Size = New System.Drawing.Size(56, 17)
        Me.LabelsRadio.TabIndex = 10
        Me.LabelsRadio.TabStop = True
        Me.LabelsRadio.Text = "Labels"
        Me.LabelsRadio.UseVisualStyleBackColor = True
        '
        'AuditReportRadio
        '
        Me.AuditReportRadio.AutoSize = True
        Me.AuditReportRadio.Location = New System.Drawing.Point(16, 67)
        Me.AuditReportRadio.Name = "AuditReportRadio"
        Me.AuditReportRadio.Size = New System.Drawing.Size(84, 17)
        Me.AuditReportRadio.TabIndex = 11
        Me.AuditReportRadio.TabStop = True
        Me.AuditReportRadio.Text = "Audit Report"
        Me.AuditReportRadio.UseVisualStyleBackColor = True
        '
        'AuditTotalsRadio
        '
        Me.AuditTotalsRadio.AutoSize = True
        Me.AuditTotalsRadio.Location = New System.Drawing.Point(16, 90)
        Me.AuditTotalsRadio.Name = "AuditTotalsRadio"
        Me.AuditTotalsRadio.Size = New System.Drawing.Size(81, 17)
        Me.AuditTotalsRadio.TabIndex = 12
        Me.AuditTotalsRadio.TabStop = True
        Me.AuditTotalsRadio.Text = "Audit Totals"
        Me.AuditTotalsRadio.UseVisualStyleBackColor = True
        '
        'TruckLoadsRadio
        '
        Me.TruckLoadsRadio.AutoSize = True
        Me.TruckLoadsRadio.Location = New System.Drawing.Point(16, 113)
        Me.TruckLoadsRadio.Name = "TruckLoadsRadio"
        Me.TruckLoadsRadio.Size = New System.Drawing.Size(85, 17)
        Me.TruckLoadsRadio.TabIndex = 13
        Me.TruckLoadsRadio.TabStop = True
        Me.TruckLoadsRadio.Text = "Truck Loads"
        Me.TruckLoadsRadio.UseVisualStyleBackColor = True
        '
        'InventoryRadio
        '
        Me.InventoryRadio.AutoSize = True
        Me.InventoryRadio.Location = New System.Drawing.Point(16, 136)
        Me.InventoryRadio.Name = "InventoryRadio"
        Me.InventoryRadio.Size = New System.Drawing.Size(69, 17)
        Me.InventoryRadio.TabIndex = 14
        Me.InventoryRadio.TabStop = True
        Me.InventoryRadio.Text = "Inventory"
        Me.InventoryRadio.UseVisualStyleBackColor = True
        '
        'UserRadio
        '
        Me.UserRadio.AutoSize = True
        Me.UserRadio.Location = New System.Drawing.Point(16, 159)
        Me.UserRadio.Name = "UserRadio"
        Me.UserRadio.Size = New System.Drawing.Size(47, 17)
        Me.UserRadio.TabIndex = 15
        Me.UserRadio.TabStop = True
        Me.UserRadio.Text = "User"
        Me.UserRadio.UseVisualStyleBackColor = True
        '
        'VerifyLabelRadio
        '
        Me.VerifyLabelRadio.AutoSize = True
        Me.VerifyLabelRadio.Location = New System.Drawing.Point(16, 182)
        Me.VerifyLabelRadio.Name = "VerifyLabelRadio"
        Me.VerifyLabelRadio.Size = New System.Drawing.Size(80, 17)
        Me.VerifyLabelRadio.TabIndex = 16
        Me.VerifyLabelRadio.TabStop = True
        Me.VerifyLabelRadio.Text = "Verify Label"
        Me.VerifyLabelRadio.UseVisualStyleBackColor = True
        '
        'SupplierRadio
        '
        Me.SupplierRadio.AutoSize = True
        Me.SupplierRadio.Location = New System.Drawing.Point(16, 205)
        Me.SupplierRadio.Name = "SupplierRadio"
        Me.SupplierRadio.Size = New System.Drawing.Size(92, 17)
        Me.SupplierRadio.TabIndex = 17
        Me.SupplierRadio.TabStop = True
        Me.SupplierRadio.Text = "Supplier Label"
        Me.SupplierRadio.UseVisualStyleBackColor = True
        '
        'SelectReportLabel
        '
        Me.SelectReportLabel.AutoSize = True
        Me.SelectReportLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectReportLabel.Location = New System.Drawing.Point(12, 9)
        Me.SelectReportLabel.Name = "SelectReportLabel"
        Me.SelectReportLabel.Size = New System.Drawing.Size(107, 20)
        Me.SelectReportLabel.TabIndex = 19
        Me.SelectReportLabel.Text = "Select Report"
        '
        'RackNbrLabel
        '
        Me.RackNbrLabel.AutoSize = True
        Me.RackNbrLabel.Location = New System.Drawing.Point(251, 75)
        Me.RackNbrLabel.Name = "RackNbrLabel"
        Me.RackNbrLabel.Size = New System.Drawing.Size(43, 13)
        Me.RackNbrLabel.TabIndex = 20
        Me.RackNbrLabel.Text = "Rack#:"
        '
        'RackIDLabel
        '
        Me.RackIDLabel.AutoSize = True
        Me.RackIDLabel.Location = New System.Drawing.Point(247, 101)
        Me.RackIDLabel.Name = "RackIDLabel"
        Me.RackIDLabel.Size = New System.Drawing.Size(47, 13)
        Me.RackIDLabel.TabIndex = 21
        Me.RackIDLabel.Text = "RackID:"
        '
        'RotationNbrLabel
        '
        Me.RotationNbrLabel.AutoSize = True
        Me.RotationNbrLabel.Location = New System.Drawing.Point(237, 127)
        Me.RotationNbrLabel.Name = "RotationNbrLabel"
        Me.RotationNbrLabel.Size = New System.Drawing.Size(57, 13)
        Me.RotationNbrLabel.TabIndex = 22
        Me.RotationNbrLabel.Text = "Rotation#:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(370, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "-"
        '
        'VinNbrLabel
        '
        Me.VinNbrLabel.AutoSize = True
        Me.VinNbrLabel.Location = New System.Drawing.Point(259, 153)
        Me.VinNbrLabel.Name = "VinNbrLabel"
        Me.VinNbrLabel.Size = New System.Drawing.Size(35, 13)
        Me.VinNbrLabel.TabIndex = 24
        Me.VinNbrLabel.Text = "VIN#:"
        '
        'SelectPartCombo
        '
        Me.SelectPartCombo.FormattingEnabled = True
        Me.SelectPartCombo.Location = New System.Drawing.Point(300, 45)
        Me.SelectPartCombo.Name = "SelectPartCombo"
        Me.SelectPartCombo.Size = New System.Drawing.Size(144, 21)
        Me.SelectPartCombo.TabIndex = 25
        '
        'SelectPartLabel
        '
        Me.SelectPartLabel.AutoSize = True
        Me.SelectPartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectPartLabel.Location = New System.Drawing.Point(296, 9)
        Me.SelectPartLabel.Name = "SelectPartLabel"
        Me.SelectPartLabel.Size = New System.Drawing.Size(87, 20)
        Me.SelectPartLabel.TabIndex = 29
        Me.SelectPartLabel.Text = "Select Part"
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(962, 76)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(151, 37)
        Me.PrintButton.TabIndex = 30
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'SelectPrinterCombo
        '
        Me.SelectPrinterCombo.FormattingEnabled = True
        Me.SelectPrinterCombo.Location = New System.Drawing.Point(685, 45)
        Me.SelectPrinterCombo.Name = "SelectPrinterCombo"
        Me.SelectPrinterCombo.Size = New System.Drawing.Size(216, 21)
        Me.SelectPrinterCombo.TabIndex = 31
        '
        'SelectPrinterLabel
        '
        Me.SelectPrinterLabel.AutoSize = True
        Me.SelectPrinterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectPrinterLabel.Location = New System.Drawing.Point(681, 9)
        Me.SelectPrinterLabel.Name = "SelectPrinterLabel"
        Me.SelectPrinterLabel.Size = New System.Drawing.Size(104, 20)
        Me.SelectPrinterLabel.TabIndex = 32
        Me.SelectPrinterLabel.Text = "Select Printer"
        '
        'PrinterLabel
        '
        Me.PrinterLabel.AutoSize = True
        Me.PrinterLabel.Location = New System.Drawing.Point(640, 48)
        Me.PrinterLabel.Name = "PrinterLabel"
        Me.PrinterLabel.Size = New System.Drawing.Size(40, 13)
        Me.PrinterLabel.TabIndex = 33
        Me.PrinterLabel.Text = "Printer:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1276, 452)
        Me.DataGridView1.TabIndex = 34
        '
        'RotationNbrStart
        '
        Me.RotationNbrStart.Location = New System.Drawing.Point(300, 124)
        Me.RotationNbrStart.Name = "RotationNbrStart"
        Me.RotationNbrStart.Size = New System.Drawing.Size(61, 20)
        Me.RotationNbrStart.TabIndex = 37
        Me.RotationNbrStart.Text = "5663"
        '
        'RotationNbrEnd
        '
        Me.RotationNbrEnd.Location = New System.Drawing.Point(386, 124)
        Me.RotationNbrEnd.Name = "RotationNbrEnd"
        Me.RotationNbrEnd.Size = New System.Drawing.Size(58, 20)
        Me.RotationNbrEnd.TabIndex = 38
        Me.RotationNbrEnd.Text = "5686"
        '
        'PartLabelText
        '
        Me.PartLabelText.AutoSize = True
        Me.PartLabelText.Location = New System.Drawing.Point(265, 48)
        Me.PartLabelText.Name = "PartLabelText"
        Me.PartLabelText.Size = New System.Drawing.Size(29, 13)
        Me.PartLabelText.TabIndex = 39
        Me.PartLabelText.Text = "Part:"
        '
        'InSeriesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 721)
        Me.Controls.Add(Me.PartLabelText)
        Me.Controls.Add(Me.RotationNbrEnd)
        Me.Controls.Add(Me.RotationNbrStart)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PrinterLabel)
        Me.Controls.Add(Me.SelectPrinterLabel)
        Me.Controls.Add(Me.SelectPrinterCombo)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.SelectPartLabel)
        Me.Controls.Add(Me.SelectPartCombo)
        Me.Controls.Add(Me.VinNbrLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RotationNbrLabel)
        Me.Controls.Add(Me.RackIDLabel)
        Me.Controls.Add(Me.RackNbrLabel)
        Me.Controls.Add(Me.SelectReportLabel)
        Me.Controls.Add(Me.SupplierRadio)
        Me.Controls.Add(Me.VerifyLabelRadio)
        Me.Controls.Add(Me.UserRadio)
        Me.Controls.Add(Me.InventoryRadio)
        Me.Controls.Add(Me.TruckLoadsRadio)
        Me.Controls.Add(Me.AuditTotalsRadio)
        Me.Controls.Add(Me.AuditReportRadio)
        Me.Controls.Add(Me.LabelsRadio)
        Me.Controls.Add(Me.VINNbr)
        Me.Controls.Add(Me.RackID)
        Me.Controls.Add(Me.RackNbr)
        Me.Controls.Add(Me.SearchButton)
        Me.Name = "InSeriesReport"
        Me.Text = "InSeriesReport"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchButton As Button
    Friend WithEvents RackNbr As TextBox
    Friend WithEvents RackID As TextBox
    Friend WithEvents VINNbr As TextBox
    Friend WithEvents LabelsRadio As RadioButton
    Friend WithEvents AuditReportRadio As RadioButton
    Friend WithEvents AuditTotalsRadio As RadioButton
    Friend WithEvents TruckLoadsRadio As RadioButton
    Friend WithEvents InventoryRadio As RadioButton
    Friend WithEvents UserRadio As RadioButton
    Friend WithEvents VerifyLabelRadio As RadioButton
    Friend WithEvents SupplierRadio As RadioButton
    Friend WithEvents SelectReportLabel As Label
    Friend WithEvents RackNbrLabel As Label
    Friend WithEvents RackIDLabel As Label
    Friend WithEvents RotationNbrLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents VinNbrLabel As Label
    Friend WithEvents SelectPartCombo As ComboBox
    Friend WithEvents SelectPartLabel As Label
    Friend WithEvents PrintButton As Button
    Friend WithEvents SelectPrinterCombo As ComboBox
    Friend WithEvents SelectPrinterLabel As Label
    Friend WithEvents PrinterLabel As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InSeriesReprint1BindingSource As BindingSource
    Friend WithEvents RotationNbrStart As TextBox
    Friend WithEvents RotationNbrEnd As TextBox
    Friend WithEvents PartLabelText As Label
End Class
