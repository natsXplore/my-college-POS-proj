<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportForm))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties9 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties10 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties11 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties12 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.dgReport = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbCount = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.btnNext = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnPrevious = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnLast = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnFirst = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.tbSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateTime = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        CType(Me.dgReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgReport
        '
        Me.dgReport.AllowCustomTheming = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgReport.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgReport.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgReport.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgReport.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgReport.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dgReport.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgReport.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.dgReport.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.dgReport.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.dgReport.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgReport.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgReport.CurrentTheme.Name = Nothing
        Me.dgReport.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgReport.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgReport.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgReport.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dgReport.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgReport.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgReport.EnableHeadersVisualStyles = False
        Me.dgReport.GridColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.dgReport.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.dgReport.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgReport.HeaderForeColor = System.Drawing.Color.White
        Me.dgReport.Location = New System.Drawing.Point(6, 57)
        Me.dgReport.Name = "dgReport"
        Me.dgReport.RowHeadersVisible = False
        Me.dgReport.RowTemplate.Height = 40
        Me.dgReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReport.Size = New System.Drawing.Size(1192, 385)
        Me.dgReport.TabIndex = 0
        Me.dgReport.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'Column1
        '
        Me.Column1.DividerWidth = 1
        Me.Column1.FillWeight = 104.4712!
        Me.Column1.HeaderText = "Transaction ID"
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.DividerWidth = 1
        Me.Column3.FillWeight = 132.0815!
        Me.Column3.HeaderText = "Product name"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DividerWidth = 1
        Me.Column4.FillWeight = 71.39257!
        Me.Column4.HeaderText = "Total item"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DividerWidth = 1
        Me.Column5.FillWeight = 91.02158!
        Me.Column5.HeaderText = "Total amount"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DividerWidth = 1
        Me.Column6.FillWeight = 86.38203!
        Me.Column6.HeaderText = "Amount paid"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.DividerWidth = 1
        Me.Column7.FillWeight = 81.21828!
        Me.Column7.HeaderText = "Change"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.DividerWidth = 1
        Me.Column8.FillWeight = 132.0815!
        Me.Column8.HeaderText = "Transaction date"
        Me.Column8.Name = "Column8"
        '
        'tbCount
        '
        Me.tbCount.AcceptsReturn = False
        Me.tbCount.AcceptsTab = False
        Me.tbCount.AnimationSpeed = 200
        Me.tbCount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbCount.BackColor = System.Drawing.Color.Transparent
        Me.tbCount.BackgroundImage = CType(resources.GetObject("tbCount.BackgroundImage"), System.Drawing.Image)
        Me.tbCount.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.tbCount.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.tbCount.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCount.BorderColorIdle = System.Drawing.Color.Silver
        Me.tbCount.BorderRadius = 1
        Me.tbCount.BorderThickness = 1
        Me.tbCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCount.DefaultFont = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCount.DefaultText = ""
        Me.tbCount.FillColor = System.Drawing.Color.White
        Me.tbCount.HideSelection = True
        Me.tbCount.IconLeft = Nothing
        Me.tbCount.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCount.IconPadding = 10
        Me.tbCount.IconRight = Nothing
        Me.tbCount.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCount.Lines = New String(-1) {}
        Me.tbCount.Location = New System.Drawing.Point(552, 448)
        Me.tbCount.MaxLength = 32767
        Me.tbCount.MinimumSize = New System.Drawing.Size(100, 35)
        Me.tbCount.Modified = False
        Me.tbCount.Multiline = False
        Me.tbCount.Name = "tbCount"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.tbCount.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.Empty
        StateProperties2.FillColor = System.Drawing.Color.White
        StateProperties2.ForeColor = System.Drawing.Color.Empty
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.tbCount.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.tbCount.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.tbCount.OnIdleState = StateProperties4
        Me.tbCount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCount.PlaceholderForeColor = System.Drawing.Color.Black
        Me.tbCount.PlaceholderText = ""
        Me.tbCount.ReadOnly = False
        Me.tbCount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbCount.SelectedText = ""
        Me.tbCount.SelectionLength = 0
        Me.tbCount.SelectionStart = 0
        Me.tbCount.ShortcutsEnabled = True
        Me.tbCount.Size = New System.Drawing.Size(100, 45)
        Me.tbCount.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.tbCount.TabIndex = 20
        Me.tbCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbCount.TextMarginBottom = 0
        Me.tbCount.TextMarginLeft = 5
        Me.tbCount.TextMarginTop = 0
        Me.tbCount.TextPlaceholder = ""
        Me.tbCount.UseSystemPasswordChar = False
        Me.tbCount.WordWrap = True
        '
        'btnNext
        '
        Me.btnNext.AllowToggling = False
        Me.btnNext.AnimationSpeed = 200
        Me.btnNext.AutoGenerateColors = False
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnNext.BackgroundImage = CType(resources.GetObject("btnNext.BackgroundImage"), System.Drawing.Image)
        Me.btnNext.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnNext.ButtonText = ""
        Me.btnNext.ButtonTextMarginLeft = 0
        Me.btnNext.ColorContrastOnClick = 45
        Me.btnNext.ColorContrastOnHover = 45
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnNext.CustomizableEdges = BorderEdges1
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNext.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btnNext.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnNext.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnNext.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.IconMarginLeft = 11
        Me.btnNext.IconPadding = 10
        Me.btnNext.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnNext.IdleBorderRadius = 3
        Me.btnNext.IdleBorderThickness = 1
        Me.btnNext.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnNext.IdleIconLeftImage = CType(resources.GetObject("btnNext.IdleIconLeftImage"), System.Drawing.Image)
        Me.btnNext.IdleIconRightImage = Nothing
        Me.btnNext.IndicateFocus = False
        Me.btnNext.Location = New System.Drawing.Point(658, 448)
        Me.btnNext.Name = "btnNext"
        StateProperties5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties5.BorderRadius = 3
        StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties5.BorderThickness = 1
        StateProperties5.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties5.ForeColor = System.Drawing.Color.White
        StateProperties5.IconLeftImage = Nothing
        StateProperties5.IconRightImage = Nothing
        Me.btnNext.onHoverState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties6.BorderRadius = 3
        StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties6.BorderThickness = 1
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.White
        StateProperties6.IconLeftImage = Nothing
        StateProperties6.IconRightImage = Nothing
        Me.btnNext.OnPressedState = StateProperties6
        Me.btnNext.Size = New System.Drawing.Size(49, 45)
        Me.btnNext.TabIndex = 18
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNext.TextMarginLeft = 0
        Me.btnNext.UseDefaultRadiusAndThickness = True
        '
        'btnPrevious
        '
        Me.btnPrevious.AllowToggling = False
        Me.btnPrevious.AnimationSpeed = 200
        Me.btnPrevious.AutoGenerateColors = False
        Me.btnPrevious.BackColor = System.Drawing.Color.Transparent
        Me.btnPrevious.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnPrevious.BackgroundImage = CType(resources.GetObject("btnPrevious.BackgroundImage"), System.Drawing.Image)
        Me.btnPrevious.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnPrevious.ButtonText = ""
        Me.btnPrevious.ButtonTextMarginLeft = 0
        Me.btnPrevious.ColorContrastOnClick = 45
        Me.btnPrevious.ColorContrastOnHover = 45
        Me.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btnPrevious.CustomizableEdges = BorderEdges2
        Me.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrevious.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btnPrevious.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnPrevious.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnPrevious.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious.IconMarginLeft = 11
        Me.btnPrevious.IconPadding = 10
        Me.btnPrevious.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnPrevious.IdleBorderRadius = 3
        Me.btnPrevious.IdleBorderThickness = 1
        Me.btnPrevious.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnPrevious.IdleIconLeftImage = CType(resources.GetObject("btnPrevious.IdleIconLeftImage"), System.Drawing.Image)
        Me.btnPrevious.IdleIconRightImage = Nothing
        Me.btnPrevious.IndicateFocus = False
        Me.btnPrevious.Location = New System.Drawing.Point(497, 448)
        Me.btnPrevious.Name = "btnPrevious"
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties7.BorderRadius = 3
        StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties7.BorderThickness = 1
        StateProperties7.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties7.ForeColor = System.Drawing.Color.White
        StateProperties7.IconLeftImage = Nothing
        StateProperties7.IconRightImage = Nothing
        Me.btnPrevious.onHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties8.BorderRadius = 3
        StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties8.BorderThickness = 1
        StateProperties8.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties8.ForeColor = System.Drawing.Color.White
        StateProperties8.IconLeftImage = Nothing
        StateProperties8.IconRightImage = Nothing
        Me.btnPrevious.OnPressedState = StateProperties8
        Me.btnPrevious.Size = New System.Drawing.Size(49, 45)
        Me.btnPrevious.TabIndex = 17
        Me.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPrevious.TextMarginLeft = 0
        Me.btnPrevious.UseDefaultRadiusAndThickness = True
        '
        'btnLast
        '
        Me.btnLast.AllowToggling = False
        Me.btnLast.AnimationSpeed = 200
        Me.btnLast.AutoGenerateColors = False
        Me.btnLast.BackColor = System.Drawing.Color.Transparent
        Me.btnLast.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnLast.BackgroundImage = CType(resources.GetObject("btnLast.BackgroundImage"), System.Drawing.Image)
        Me.btnLast.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnLast.ButtonText = ""
        Me.btnLast.ButtonTextMarginLeft = 0
        Me.btnLast.ColorContrastOnClick = 45
        Me.btnLast.ColorContrastOnHover = 45
        Me.btnLast.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.btnLast.CustomizableEdges = BorderEdges3
        Me.btnLast.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLast.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btnLast.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnLast.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnLast.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnLast.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnLast.ForeColor = System.Drawing.Color.White
        Me.btnLast.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnLast.IconMarginLeft = 11
        Me.btnLast.IconPadding = 10
        Me.btnLast.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnLast.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnLast.IdleBorderRadius = 3
        Me.btnLast.IdleBorderThickness = 1
        Me.btnLast.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnLast.IdleIconLeftImage = CType(resources.GetObject("btnLast.IdleIconLeftImage"), System.Drawing.Image)
        Me.btnLast.IdleIconRightImage = Nothing
        Me.btnLast.IndicateFocus = False
        Me.btnLast.Location = New System.Drawing.Point(713, 448)
        Me.btnLast.Name = "btnLast"
        StateProperties9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties9.BorderRadius = 3
        StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties9.BorderThickness = 1
        StateProperties9.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties9.ForeColor = System.Drawing.Color.White
        StateProperties9.IconLeftImage = Nothing
        StateProperties9.IconRightImage = Nothing
        Me.btnLast.onHoverState = StateProperties9
        StateProperties10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties10.BorderRadius = 3
        StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties10.BorderThickness = 1
        StateProperties10.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties10.ForeColor = System.Drawing.Color.White
        StateProperties10.IconLeftImage = Nothing
        StateProperties10.IconRightImage = Nothing
        Me.btnLast.OnPressedState = StateProperties10
        Me.btnLast.Size = New System.Drawing.Size(49, 45)
        Me.btnLast.TabIndex = 16
        Me.btnLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLast.TextMarginLeft = 0
        Me.btnLast.UseDefaultRadiusAndThickness = True
        '
        'btnFirst
        '
        Me.btnFirst.AllowToggling = False
        Me.btnFirst.AnimationSpeed = 200
        Me.btnFirst.AutoGenerateColors = False
        Me.btnFirst.BackColor = System.Drawing.Color.Transparent
        Me.btnFirst.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnFirst.BackgroundImage = CType(resources.GetObject("btnFirst.BackgroundImage"), System.Drawing.Image)
        Me.btnFirst.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnFirst.ButtonText = ""
        Me.btnFirst.ButtonTextMarginLeft = 0
        Me.btnFirst.ColorContrastOnClick = 45
        Me.btnFirst.ColorContrastOnHover = 45
        Me.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.btnFirst.CustomizableEdges = BorderEdges4
        Me.btnFirst.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFirst.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btnFirst.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnFirst.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnFirst.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnFirst.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnFirst.ForeColor = System.Drawing.Color.White
        Me.btnFirst.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirst.IconMarginLeft = 11
        Me.btnFirst.IconPadding = 10
        Me.btnFirst.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirst.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnFirst.IdleBorderRadius = 3
        Me.btnFirst.IdleBorderThickness = 1
        Me.btnFirst.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnFirst.IdleIconLeftImage = CType(resources.GetObject("btnFirst.IdleIconLeftImage"), System.Drawing.Image)
        Me.btnFirst.IdleIconRightImage = Nothing
        Me.btnFirst.IndicateFocus = False
        Me.btnFirst.Location = New System.Drawing.Point(442, 448)
        Me.btnFirst.Name = "btnFirst"
        StateProperties11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties11.BorderRadius = 3
        StateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties11.BorderThickness = 1
        StateProperties11.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties11.ForeColor = System.Drawing.Color.White
        StateProperties11.IconLeftImage = Nothing
        StateProperties11.IconRightImage = Nothing
        Me.btnFirst.onHoverState = StateProperties11
        StateProperties12.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties12.BorderRadius = 3
        StateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties12.BorderThickness = 1
        StateProperties12.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        StateProperties12.ForeColor = System.Drawing.Color.White
        StateProperties12.IconLeftImage = Nothing
        StateProperties12.IconRightImage = Nothing
        Me.btnFirst.OnPressedState = StateProperties12
        Me.btnFirst.Size = New System.Drawing.Size(49, 45)
        Me.btnFirst.TabIndex = 15
        Me.btnFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnFirst.TextMarginLeft = 0
        Me.btnFirst.UseDefaultRadiusAndThickness = True
        '
        'tbSearch
        '
        Me.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbSearch.BackColor = System.Drawing.Color.White
        Me.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSearch.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tbSearch.ForeColor = System.Drawing.Color.Black
        Me.tbSearch.HintForeColor = System.Drawing.Color.Black
        Me.tbSearch.HintText = "Search Transaction ID"
        Me.tbSearch.isPassword = False
        Me.tbSearch.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbSearch.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tbSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tbSearch.LineThickness = 3
        Me.tbSearch.Location = New System.Drawing.Point(7, 17)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.tbSearch.MaxLength = 32767
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(1190, 33)
        Me.tbSearch.TabIndex = 21
        Me.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1228, 73)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BackToolStripMenuItem.Image = CType(resources.GetObject("BackToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(62, 69)
        Me.BackToolStripMenuItem.Text = "Back"
        Me.BackToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RefreshToolStripMenuItem.Image = Global.Jonathan_Abiva_Point_of_Sale.My.Resources.Resources.refresh_50px
        Me.RefreshToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(66, 69)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        Me.RefreshToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Image = Global.Jonathan_Abiva_Point_of_Sale.My.Resources.Resources.more_info_50px
        Me.AboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Space), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 69)
        Me.AboutToolStripMenuItem.Text = "About"
        Me.AboutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(311, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(606, 58)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "TRANSACTION REPORT"
        '
        'dateTime
        '
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgReport)
        Me.GroupBox1.Controls.Add(Me.btnFirst)
        Me.GroupBox1.Controls.Add(Me.btnLast)
        Me.GroupBox1.Controls.Add(Me.tbSearch)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Controls.Add(Me.tbCount)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1204, 499)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(970, 40)
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
        Me.lblDate.Location = New System.Drawing.Point(970, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(71, 29)
        Me.lblDate.TabIndex = 31
        Me.lblDate.Text = "Date"
        '
        'reportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1228, 645)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "reportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reportForm"
        CType(Me.dgReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgReport As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents tbCount As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents btnNext As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnPrevious As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnLast As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnFirst As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents tbSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents dateTime As Timer
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
