<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockDev
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stockDev))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.btnBrowseImage = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBrowseImage
        '
        Me.btnBrowseImage.AllowToggling = False
        Me.btnBrowseImage.AnimationSpeed = 200
        Me.btnBrowseImage.AutoGenerateColors = False
        Me.btnBrowseImage.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowseImage.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBrowseImage.BackgroundImage = CType(resources.GetObject("btnBrowseImage.BackgroundImage"), System.Drawing.Image)
        Me.btnBrowseImage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnBrowseImage.ButtonText = "BACK"
        Me.btnBrowseImage.ButtonTextMarginLeft = 0
        Me.btnBrowseImage.ColorContrastOnClick = 45
        Me.btnBrowseImage.ColorContrastOnHover = 45
        Me.btnBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnBrowseImage.CustomizableEdges = BorderEdges1
        Me.btnBrowseImage.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBrowseImage.DisabledBorderColor = System.Drawing.Color.Transparent
        Me.btnBrowseImage.DisabledFillColor = System.Drawing.Color.Transparent
        Me.btnBrowseImage.DisabledForecolor = System.Drawing.Color.Transparent
        Me.btnBrowseImage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnBrowseImage.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnBrowseImage.ForeColor = System.Drawing.Color.White
        Me.btnBrowseImage.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowseImage.IconMarginLeft = 11
        Me.btnBrowseImage.IconPadding = 10
        Me.btnBrowseImage.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowseImage.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBrowseImage.IdleBorderRadius = 3
        Me.btnBrowseImage.IdleBorderThickness = 1
        Me.btnBrowseImage.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBrowseImage.IdleIconLeftImage = Nothing
        Me.btnBrowseImage.IdleIconRightImage = Nothing
        Me.btnBrowseImage.IndicateFocus = False
        Me.btnBrowseImage.Location = New System.Drawing.Point(12, 12)
        Me.btnBrowseImage.Name = "btnBrowseImage"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(238, Byte), Integer))
        StateProperties1.BorderRadius = 3
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(238, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btnBrowseImage.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 3
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.btnBrowseImage.OnPressedState = StateProperties2
        Me.btnBrowseImage.Size = New System.Drawing.Size(60, 23)
        Me.btnBrowseImage.TabIndex = 7
        Me.btnBrowseImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBrowseImage.TextMarginLeft = 0
        Me.btnBrowseImage.UseDefaultRadiusAndThickness = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-124, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(691, 341)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(294, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 359)
        Me.Panel1.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(278, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Course: Bachelor of Science in Computer Science"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(253, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Email address: abivajonathan17@gmail.com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Location: San Felipe, Zambales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "School: President Ramon Magsaysay State University"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Birthday: June 26, 2001"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age: 20 years old"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name: Jonathan Cañeta Abiva"
        '
        'stockDev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(616, 339)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBrowseImage)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "stockDev"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "stockDev"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBrowseImage As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
End Class
