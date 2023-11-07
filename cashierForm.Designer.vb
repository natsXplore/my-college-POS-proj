<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cashierForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cashierForm))
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.back = New System.Windows.Forms.ToolStripMenuItem()
        Me.refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.about = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbCashier = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.label = New System.Windows.Forms.Label()
        Me.comboProductList = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbBarcode = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTransaction = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbTotal = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbQuantity = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbStock = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbPrice = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbChange = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbAmountPaid = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbTotalAmount = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbTotalItems = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dateTime = New System.Windows.Forms.Timer(Me.components)
        Me.btnPay = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnAddtoCart = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnReceipt = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.dgCashier = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.back, Me.refresh, Me.delete, Me.about})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1065, 73)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.White
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(62, 69)
        Me.back.Text = "BACK"
        Me.back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'refresh
        '
        Me.refresh.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh.ForeColor = System.Drawing.Color.White
        Me.refresh.Image = Global.Jonathan_Abiva_Point_of_Sale.My.Resources.Resources.refresh_50px
        Me.refresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(77, 69)
        Me.refresh.Text = "REFRESH"
        Me.refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.ForeColor = System.Drawing.Color.White
        Me.delete.Image = Global.Jonathan_Abiva_Point_of_Sale.My.Resources.Resources.Delete_50px
        Me.delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(92, 69)
        Me.delete.Text = "DELETE ALL"
        Me.delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'about
        '
        Me.about.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.about.ForeColor = System.Drawing.Color.White
        Me.about.Image = Global.Jonathan_Abiva_Point_of_Sale.My.Resources.Resources.more_info_50px
        Me.about.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(62, 69)
        Me.about.Text = "ABOUT"
        Me.about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(260, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(545, 58)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CASHIERING SYSTEM"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbCashier)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.comboProductList)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbBarcode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbTransaction)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(589, 122)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Details"
        '
        'tbCashier
        '
        Me.tbCashier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbCashier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbCashier.BackColor = System.Drawing.Color.White
        Me.tbCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbCashier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCashier.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbCashier.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCashier.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCashier.ForeColor = System.Drawing.Color.Black
        Me.tbCashier.HintForeColor = System.Drawing.Color.Black
        Me.tbCashier.HintText = ""
        Me.tbCashier.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbCashier.isPassword = False
        Me.tbCashier.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbCashier.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tbCashier.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbCashier.LineThickness = 3
        Me.tbCashier.Location = New System.Drawing.Point(112, 20)
        Me.tbCashier.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCashier.MaxLength = 32767
        Me.tbCashier.Name = "tbCashier"
        Me.tbCashier.Size = New System.Drawing.Size(185, 33)
        Me.tbCashier.TabIndex = 11
        Me.tbCashier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.Black
        Me.label.Location = New System.Drawing.Point(8, 37)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(55, 16)
        Me.label.TabIndex = 10
        Me.label.Text = "Cashier:"
        '
        'comboProductList
        '
        Me.comboProductList.BackColor = System.Drawing.Color.White
        Me.comboProductList.BorderColor = System.Drawing.Color.Black
        Me.comboProductList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboProductList.DropDownHeight = 200
        Me.comboProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboProductList.FocusedColor = System.Drawing.Color.Empty
        Me.comboProductList.FocusedState.Parent = Me.comboProductList
        Me.comboProductList.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboProductList.ForeColor = System.Drawing.Color.Black
        Me.comboProductList.FormattingEnabled = True
        Me.comboProductList.HoverState.Parent = Me.comboProductList
        Me.comboProductList.IntegralHeight = False
        Me.comboProductList.ItemHeight = 30
        Me.comboProductList.ItemsAppearance.Parent = Me.comboProductList
        Me.comboProductList.Location = New System.Drawing.Point(392, 68)
        Me.comboProductList.Name = "comboProductList"
        Me.comboProductList.ShadowDecoration.Parent = Me.comboProductList
        Me.comboProductList.Size = New System.Drawing.Size(185, 36)
        Me.comboProductList.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(313, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Product list:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(323, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Barcode:"
        '
        'tbBarcode
        '
        Me.tbBarcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbBarcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbBarcode.BackColor = System.Drawing.Color.White
        Me.tbBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBarcode.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbBarcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbBarcode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBarcode.ForeColor = System.Drawing.Color.Black
        Me.tbBarcode.HintForeColor = System.Drawing.Color.Black
        Me.tbBarcode.HintText = ""
        Me.tbBarcode.isPassword = False
        Me.tbBarcode.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbBarcode.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tbBarcode.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbBarcode.LineThickness = 3
        Me.tbBarcode.Location = New System.Drawing.Point(392, 20)
        Me.tbBarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.tbBarcode.MaxLength = 32767
        Me.tbBarcode.Name = "tbBarcode"
        Me.tbBarcode.Size = New System.Drawing.Size(185, 33)
        Me.tbBarcode.TabIndex = 2
        Me.tbBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Transaction ID:"
        '
        'tbTransaction
        '
        Me.tbTransaction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbTransaction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbTransaction.BackColor = System.Drawing.Color.White
        Me.tbTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTransaction.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbTransaction.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTransaction.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTransaction.ForeColor = System.Drawing.Color.Black
        Me.tbTransaction.HintForeColor = System.Drawing.Color.Black
        Me.tbTransaction.HintText = ""
        Me.tbTransaction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbTransaction.isPassword = False
        Me.tbTransaction.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbTransaction.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tbTransaction.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbTransaction.LineThickness = 3
        Me.tbTransaction.Location = New System.Drawing.Point(112, 71)
        Me.tbTransaction.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTransaction.MaxLength = 32767
        Me.tbTransaction.Name = "tbTransaction"
        Me.tbTransaction.Size = New System.Drawing.Size(185, 33)
        Me.tbTransaction.TabIndex = 0
        Me.tbTransaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbTotal)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tbQuantity)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbStock)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbPrice)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(607, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 122)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Details"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(215, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Sub total:"
        '
        'tbTotal
        '
        Me.tbTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbTotal.BackColor = System.Drawing.Color.White
        Me.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotal.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotal.ForeColor = System.Drawing.Color.Black
        Me.tbTotal.HintForeColor = System.Drawing.Color.Black
        Me.tbTotal.HintText = ""
        Me.tbTotal.isPassword = False
        Me.tbTotal.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbTotal.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tbTotal.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbTotal.LineThickness = 3
        Me.tbTotal.Location = New System.Drawing.Point(285, 71)
        Me.tbTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTotal.MaxLength = 32767
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(152, 33)
        Me.tbTotal.TabIndex = 15
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(215, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Quantity:"
        '
        'tbQuantity
        '
        Me.tbQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbQuantity.BackColor = System.Drawing.Color.White
        Me.tbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQuantity.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbQuantity.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQuantity.ForeColor = System.Drawing.Color.Black
        Me.tbQuantity.HintForeColor = System.Drawing.Color.Black
        Me.tbQuantity.HintText = ""
        Me.tbQuantity.isPassword = False
        Me.tbQuantity.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbQuantity.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tbQuantity.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbQuantity.LineThickness = 3
        Me.tbQuantity.Location = New System.Drawing.Point(285, 20)
        Me.tbQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.tbQuantity.MaxLength = 32767
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.Size = New System.Drawing.Size(152, 33)
        Me.tbQuantity.TabIndex = 13
        Me.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Stock:"
        '
        'tbStock
        '
        Me.tbStock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbStock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbStock.BackColor = System.Drawing.Color.White
        Me.tbStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbStock.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbStock.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStock.ForeColor = System.Drawing.Color.Black
        Me.tbStock.HintForeColor = System.Drawing.Color.Black
        Me.tbStock.HintText = ""
        Me.tbStock.isPassword = False
        Me.tbStock.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbStock.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tbStock.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbStock.LineThickness = 3
        Me.tbStock.Location = New System.Drawing.Point(53, 71)
        Me.tbStock.Margin = New System.Windows.Forms.Padding(4)
        Me.tbStock.MaxLength = 32767
        Me.tbStock.Name = "tbStock"
        Me.tbStock.Size = New System.Drawing.Size(155, 33)
        Me.tbStock.TabIndex = 11
        Me.tbStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Price:"
        '
        'tbPrice
        '
        Me.tbPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbPrice.BackColor = System.Drawing.Color.White
        Me.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPrice.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrice.ForeColor = System.Drawing.Color.Black
        Me.tbPrice.HintForeColor = System.Drawing.Color.Black
        Me.tbPrice.HintText = ""
        Me.tbPrice.isPassword = False
        Me.tbPrice.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbPrice.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tbPrice.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbPrice.LineThickness = 3
        Me.tbPrice.Location = New System.Drawing.Point(53, 20)
        Me.tbPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPrice.MaxLength = 32767
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(155, 33)
        Me.tbPrice.TabIndex = 0
        Me.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.tbChange)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.tbAmountPaid)
        Me.GroupBox3.Location = New System.Drawing.Point(322, 509)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(311, 124)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Change:"
        '
        'tbChange
        '
        Me.tbChange.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbChange.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbChange.BackColor = System.Drawing.Color.White
        Me.tbChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbChange.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbChange.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbChange.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbChange.ForeColor = System.Drawing.Color.Black
        Me.tbChange.HintForeColor = System.Drawing.Color.Black
        Me.tbChange.HintText = ""
        Me.tbChange.isPassword = False
        Me.tbChange.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbChange.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tbChange.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbChange.LineThickness = 3
        Me.tbChange.Location = New System.Drawing.Point(94, 71)
        Me.tbChange.Margin = New System.Windows.Forms.Padding(4)
        Me.tbChange.MaxLength = 32767
        Me.tbChange.Name = "tbChange"
        Me.tbChange.Size = New System.Drawing.Size(210, 33)
        Me.tbChange.TabIndex = 23
        Me.tbChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Amount paid:"
        '
        'tbAmountPaid
        '
        Me.tbAmountPaid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbAmountPaid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbAmountPaid.BackColor = System.Drawing.Color.White
        Me.tbAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbAmountPaid.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbAmountPaid.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAmountPaid.ForeColor = System.Drawing.Color.Black
        Me.tbAmountPaid.HintForeColor = System.Drawing.Color.Black
        Me.tbAmountPaid.HintText = ""
        Me.tbAmountPaid.isPassword = False
        Me.tbAmountPaid.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbAmountPaid.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tbAmountPaid.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbAmountPaid.LineThickness = 3
        Me.tbAmountPaid.Location = New System.Drawing.Point(94, 20)
        Me.tbAmountPaid.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAmountPaid.MaxLength = 32767
        Me.tbAmountPaid.Name = "tbAmountPaid"
        Me.tbAmountPaid.Size = New System.Drawing.Size(210, 33)
        Me.tbAmountPaid.TabIndex = 21
        Me.tbAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Total Amount:"
        '
        'tbTotalAmount
        '
        Me.tbTotalAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbTotalAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbTotalAmount.BackColor = System.Drawing.Color.White
        Me.tbTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotalAmount.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTotalAmount.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalAmount.ForeColor = System.Drawing.Color.Black
        Me.tbTotalAmount.HintForeColor = System.Drawing.Color.Black
        Me.tbTotalAmount.HintText = ""
        Me.tbTotalAmount.isPassword = False
        Me.tbTotalAmount.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbTotalAmount.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tbTotalAmount.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbTotalAmount.LineThickness = 3
        Me.tbTotalAmount.Location = New System.Drawing.Point(103, 70)
        Me.tbTotalAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTotalAmount.MaxLength = 32767
        Me.tbTotalAmount.Name = "tbTotalAmount"
        Me.tbTotalAmount.Size = New System.Drawing.Size(194, 33)
        Me.tbTotalAmount.TabIndex = 19
        Me.tbTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(8, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Total items:"
        '
        'tbTotalItems
        '
        Me.tbTotalItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbTotalItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbTotalItems.BackColor = System.Drawing.Color.White
        Me.tbTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTotalItems.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbTotalItems.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTotalItems.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalItems.ForeColor = System.Drawing.Color.Black
        Me.tbTotalItems.HintForeColor = System.Drawing.Color.Black
        Me.tbTotalItems.HintText = ""
        Me.tbTotalItems.isPassword = False
        Me.tbTotalItems.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbTotalItems.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tbTotalItems.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbTotalItems.LineThickness = 3
        Me.tbTotalItems.Location = New System.Drawing.Point(103, 19)
        Me.tbTotalItems.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTotalItems.MaxLength = 32767
        Me.tbTotalItems.Name = "tbTotalItems"
        Me.tbTotalItems.Size = New System.Drawing.Size(194, 33)
        Me.tbTotalItems.TabIndex = 17
        Me.tbTotalItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.tbTotalItems)
        Me.GroupBox4.Controls.Add(Me.tbTotalAmount)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 510)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(304, 123)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        '
        'dateTime
        '
        '
        'btnPay
        '
        Me.btnPay.AllowToggling = False
        Me.btnPay.AnimationSpeed = 200
        Me.btnPay.AutoGenerateColors = False
        Me.btnPay.BackColor = System.Drawing.Color.Transparent
        Me.btnPay.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnPay.BackgroundImage = CType(resources.GetObject("btnPay.BackgroundImage"), System.Drawing.Image)
        Me.btnPay.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnPay.ButtonText = "Pay"
        Me.btnPay.ButtonTextMarginLeft = 0
        Me.btnPay.ColorContrastOnClick = 45
        Me.btnPay.ColorContrastOnHover = 45
        Me.btnPay.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btnPay.CustomizableEdges = BorderEdges2
        Me.btnPay.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPay.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btnPay.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnPay.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnPay.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnPay.IconMarginLeft = 60
        Me.btnPay.IconPadding = 10
        Me.btnPay.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnPay.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnPay.IdleBorderRadius = 3
        Me.btnPay.IdleBorderThickness = 1
        Me.btnPay.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnPay.IdleIconLeftImage = CType(resources.GetObject("btnPay.IdleIconLeftImage"), System.Drawing.Image)
        Me.btnPay.IdleIconRightImage = Nothing
        Me.btnPay.IndicateFocus = False
        Me.btnPay.Location = New System.Drawing.Point(639, 580)
        Me.btnPay.Name = "btnPay"
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties3.BorderRadius = 3
        StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties3.ForeColor = System.Drawing.Color.White
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.btnPay.onHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.BorderRadius = 3
        StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.btnPay.OnPressedState = StateProperties4
        Me.btnPay.Size = New System.Drawing.Size(216, 53)
        Me.btnPay.TabIndex = 24
        Me.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPay.TextMarginLeft = 0
        Me.btnPay.UseDefaultRadiusAndThickness = True
        '
        'btnAddtoCart
        '
        Me.btnAddtoCart.AllowToggling = False
        Me.btnAddtoCart.AnimationSpeed = 200
        Me.btnAddtoCart.AutoGenerateColors = False
        Me.btnAddtoCart.BackColor = System.Drawing.Color.Transparent
        Me.btnAddtoCart.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnAddtoCart.BackgroundImage = CType(resources.GetObject("btnAddtoCart.BackgroundImage"), System.Drawing.Image)
        Me.btnAddtoCart.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnAddtoCart.ButtonText = "ADD TO CART"
        Me.btnAddtoCart.ButtonTextMarginLeft = 0
        Me.btnAddtoCart.ColorContrastOnClick = 45
        Me.btnAddtoCart.ColorContrastOnHover = 45
        Me.btnAddtoCart.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.btnAddtoCart.CustomizableEdges = BorderEdges3
        Me.btnAddtoCart.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddtoCart.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btnAddtoCart.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAddtoCart.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAddtoCart.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnAddtoCart.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnAddtoCart.ForeColor = System.Drawing.Color.White
        Me.btnAddtoCart.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddtoCart.IconMarginLeft = 130
        Me.btnAddtoCart.IconPadding = 10
        Me.btnAddtoCart.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddtoCart.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnAddtoCart.IdleBorderRadius = 3
        Me.btnAddtoCart.IdleBorderThickness = 1
        Me.btnAddtoCart.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnAddtoCart.IdleIconLeftImage = CType(resources.GetObject("btnAddtoCart.IdleIconLeftImage"), System.Drawing.Image)
        Me.btnAddtoCart.IdleIconRightImage = Nothing
        Me.btnAddtoCart.IndicateFocus = False
        Me.btnAddtoCart.Location = New System.Drawing.Point(639, 521)
        Me.btnAddtoCart.Name = "btnAddtoCart"
        StateProperties5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties5.BorderRadius = 3
        StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties5.BorderThickness = 1
        StateProperties5.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties5.ForeColor = System.Drawing.Color.White
        StateProperties5.IconLeftImage = Nothing
        StateProperties5.IconRightImage = Nothing
        Me.btnAddtoCart.onHoverState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties6.BorderRadius = 3
        StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties6.BorderThickness = 1
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.White
        StateProperties6.IconLeftImage = Nothing
        StateProperties6.IconRightImage = Nothing
        Me.btnAddtoCart.OnPressedState = StateProperties6
        Me.btnAddtoCart.Size = New System.Drawing.Size(414, 53)
        Me.btnAddtoCart.TabIndex = 23
        Me.btnAddtoCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAddtoCart.TextMarginLeft = 0
        Me.btnAddtoCart.UseDefaultRadiusAndThickness = True
        '
        'btnReceipt
        '
        Me.btnReceipt.AllowToggling = False
        Me.btnReceipt.AnimationSpeed = 200
        Me.btnReceipt.AutoGenerateColors = False
        Me.btnReceipt.BackColor = System.Drawing.Color.Transparent
        Me.btnReceipt.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnReceipt.BackgroundImage = CType(resources.GetObject("btnReceipt.BackgroundImage"), System.Drawing.Image)
        Me.btnReceipt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnReceipt.ButtonText = "Receipt"
        Me.btnReceipt.ButtonTextMarginLeft = 0
        Me.btnReceipt.ColorContrastOnClick = 45
        Me.btnReceipt.ColorContrastOnHover = 45
        Me.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnReceipt.CustomizableEdges = BorderEdges1
        Me.btnReceipt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnReceipt.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btnReceipt.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnReceipt.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnReceipt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnReceipt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnReceipt.ForeColor = System.Drawing.Color.White
        Me.btnReceipt.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceipt.IconMarginLeft = 40
        Me.btnReceipt.IconPadding = 10
        Me.btnReceipt.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceipt.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnReceipt.IdleBorderRadius = 3
        Me.btnReceipt.IdleBorderThickness = 1
        Me.btnReceipt.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnReceipt.IdleIconLeftImage = CType(resources.GetObject("btnReceipt.IdleIconLeftImage"), System.Drawing.Image)
        Me.btnReceipt.IdleIconRightImage = Nothing
        Me.btnReceipt.IndicateFocus = False
        Me.btnReceipt.Location = New System.Drawing.Point(861, 580)
        Me.btnReceipt.Name = "btnReceipt"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties1.BorderRadius = 3
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btnReceipt.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 3
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.btnReceipt.OnPressedState = StateProperties2
        Me.btnReceipt.Size = New System.Drawing.Size(192, 53)
        Me.btnReceipt.TabIndex = 28
        Me.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnReceipt.TextMarginLeft = 0
        Me.btnReceipt.UseDefaultRadiusAndThickness = True
        '
        'dgCashier
        '
        Me.dgCashier.AllowCustomTheming = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgCashier.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCashier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCashier.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCashier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgCashier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCashier.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCashier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgCashier.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCashier.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCashier.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgCashier.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dgCashier.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgCashier.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.dgCashier.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.dgCashier.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.dgCashier.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCashier.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgCashier.CurrentTheme.Name = Nothing
        Me.dgCashier.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgCashier.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCashier.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgCashier.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dgCashier.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCashier.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgCashier.EnableHeadersVisualStyles = False
        Me.dgCashier.GridColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.dgCashier.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.dgCashier.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgCashier.HeaderForeColor = System.Drawing.Color.White
        Me.dgCashier.Location = New System.Drawing.Point(12, 262)
        Me.dgCashier.Name = "dgCashier"
        Me.dgCashier.RowHeadersVisible = False
        Me.dgCashier.RowTemplate.Height = 40
        Me.dgCashier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCashier.Size = New System.Drawing.Size(1041, 241)
        Me.dgCashier.TabIndex = 29
        Me.dgCashier.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DividerWidth = 1
        Me.DataGridViewTextBoxColumn1.FillWeight = 79.02618!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Barcode ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DividerWidth = 1
        Me.DataGridViewTextBoxColumn2.FillWeight = 228.6039!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DividerWidth = 1
        Me.DataGridViewTextBoxColumn3.FillWeight = 51.43805!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DividerWidth = 1
        Me.DataGridViewTextBoxColumn4.FillWeight = 76.8869!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DividerWidth = 1
        Me.DataGridViewTextBoxColumn5.FillWeight = 82.98355!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(830, 40)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(73, 29)
        Me.lblTime.TabIndex = 32
        Me.lblTime.Text = "Time"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(830, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(71, 29)
        Me.lblDate.TabIndex = 31
        Me.lblDate.Text = "Date"
        '
        'cashierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1065, 642)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dgCashier)
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnAddtoCart)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "cashierForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cashierForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgCashier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents back As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbBarcode As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTransaction As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents comboProductList As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbStock As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbPrice As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbTotal As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbQuantity As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbTotalAmount As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tbTotalItems As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbChange As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbAmountPaid As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnPay As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnAddtoCart As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents refresh As ToolStripMenuItem
    Friend WithEvents delete As ToolStripMenuItem
    Friend WithEvents about As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dateTime As Timer
    Friend WithEvents btnReceipt As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents dgCashier As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents label As Label
    Friend WithEvents tbCashier As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
