<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Main))
        Me.BunifuElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.BunifuDragControl_H = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl_L = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.btnCBR = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCDR = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnADR = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnABR = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPopDensity = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDblTime = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNaPopGrowth = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnGPopGrowth = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNePopGrowth = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnFuture = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pnlCrude = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton11 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pnlActual = New System.Windows.Forms.Panel()
        Me.pnlPopGrowth = New System.Windows.Forms.Panel()
        Me.pnlDblTime = New System.Windows.Forms.Panel()
        Me.pnlPopDens = New System.Windows.Forms.Panel()
        Me.pnlFuture = New System.Windows.Forms.Panel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblHeaderData = New System.Windows.Forms.Label()
        Me.lblHeaderOut = New System.Windows.Forms.Label()
        Me.lblBirths = New System.Windows.Forms.Label()
        Me.lblDeaths = New System.Windows.Forms.Label()
        Me.lblTotalBirths = New System.Windows.Forms.Label()
        Me.lblTotalDeaths = New System.Windows.Forms.Label()
        Me.lblImmigrants = New System.Windows.Forms.Label()
        Me.lblEmigrants = New System.Windows.Forms.Label()
        Me.lblTotalPop = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnClear = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCrude.SuspendLayout()
        Me.pnlActual.SuspendLayout()
        Me.pnlPopGrowth.SuspendLayout()
        Me.pnlDblTime.SuspendLayout()
        Me.pnlPopDens.SuspendLayout()
        Me.pnlFuture.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse
        '
        Me.BunifuElipse.ElipseRadius = 5
        Me.BunifuElipse.TargetControl = Me
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.picExit)
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Location = New System.Drawing.Point(0, -1)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(642, 57)
        Me.pnlHeader.TabIndex = 0
        '
        'picExit
        '
        Me.picExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picExit.Image = CType(resources.GetObject("picExit.Image"), System.Drawing.Image)
        Me.picExit.Location = New System.Drawing.Point(596, 16)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(26, 26)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExit.TabIndex = 1
        Me.picExit.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(242, 17)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(146, 25)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "APES Calculator"
        '
        'BunifuDragControl_H
        '
        Me.BunifuDragControl_H.Fixed = True
        Me.BunifuDragControl_H.Horizontal = True
        Me.BunifuDragControl_H.TargetControl = Me.pnlHeader
        Me.BunifuDragControl_H.Vertical = True
        '
        'BunifuDragControl_L
        '
        Me.BunifuDragControl_L.Fixed = True
        Me.BunifuDragControl_L.Horizontal = True
        Me.BunifuDragControl_L.TargetControl = Me.lblHeader
        Me.BunifuDragControl_L.Vertical = True
        '
        'btnCBR
        '
        Me.btnCBR.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnCBR.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCBR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCBR.BorderRadius = 5
        Me.btnCBR.ButtonText = "Crude Birth Rate"
        Me.btnCBR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCBR.DisabledColor = System.Drawing.Color.Gray
        Me.btnCBR.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCBR.Iconimage = CType(resources.GetObject("btnCBR.Iconimage"), System.Drawing.Image)
        Me.btnCBR.Iconimage_right = Nothing
        Me.btnCBR.Iconimage_right_Selected = Nothing
        Me.btnCBR.Iconimage_Selected = Nothing
        Me.btnCBR.IconMarginLeft = 0
        Me.btnCBR.IconMarginRight = 0
        Me.btnCBR.IconRightVisible = False
        Me.btnCBR.IconRightZoom = 0R
        Me.btnCBR.IconVisible = False
        Me.btnCBR.IconZoom = 90.0R
        Me.btnCBR.IsTab = False
        Me.btnCBR.Location = New System.Drawing.Point(21, 26)
        Me.btnCBR.Name = "btnCBR"
        Me.btnCBR.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCBR.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCBR.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCBR.selected = False
        Me.btnCBR.Size = New System.Drawing.Size(135, 36)
        Me.btnCBR.TabIndex = 1
        Me.btnCBR.Text = "Crude Birth Rate"
        Me.btnCBR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCBR.Textcolor = System.Drawing.Color.White
        Me.btnCBR.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCDR
        '
        Me.btnCDR.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnCDR.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCDR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCDR.BorderRadius = 5
        Me.btnCDR.ButtonText = "Crude Death Rate"
        Me.btnCDR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCDR.DisabledColor = System.Drawing.Color.Gray
        Me.btnCDR.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCDR.Iconimage = CType(resources.GetObject("btnCDR.Iconimage"), System.Drawing.Image)
        Me.btnCDR.Iconimage_right = Nothing
        Me.btnCDR.Iconimage_right_Selected = Nothing
        Me.btnCDR.Iconimage_Selected = Nothing
        Me.btnCDR.IconMarginLeft = 0
        Me.btnCDR.IconMarginRight = 0
        Me.btnCDR.IconRightVisible = False
        Me.btnCDR.IconRightZoom = 0R
        Me.btnCDR.IconVisible = False
        Me.btnCDR.IconZoom = 90.0R
        Me.btnCDR.IsTab = False
        Me.btnCDR.Location = New System.Drawing.Point(21, 68)
        Me.btnCDR.Name = "btnCDR"
        Me.btnCDR.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCDR.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCDR.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCDR.selected = False
        Me.btnCDR.Size = New System.Drawing.Size(135, 36)
        Me.btnCDR.TabIndex = 2
        Me.btnCDR.Text = "Crude Death Rate"
        Me.btnCDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCDR.Textcolor = System.Drawing.Color.White
        Me.btnCDR.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnADR
        '
        Me.btnADR.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnADR.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnADR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnADR.BorderRadius = 5
        Me.btnADR.ButtonText = "Actual Death Rate"
        Me.btnADR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnADR.DisabledColor = System.Drawing.Color.Gray
        Me.btnADR.Iconcolor = System.Drawing.Color.Transparent
        Me.btnADR.Iconimage = CType(resources.GetObject("btnADR.Iconimage"), System.Drawing.Image)
        Me.btnADR.Iconimage_right = Nothing
        Me.btnADR.Iconimage_right_Selected = Nothing
        Me.btnADR.Iconimage_Selected = Nothing
        Me.btnADR.IconMarginLeft = 0
        Me.btnADR.IconMarginRight = 0
        Me.btnADR.IconRightVisible = False
        Me.btnADR.IconRightZoom = 0R
        Me.btnADR.IconVisible = False
        Me.btnADR.IconZoom = 90.0R
        Me.btnADR.IsTab = False
        Me.btnADR.Location = New System.Drawing.Point(21, 68)
        Me.btnADR.Name = "btnADR"
        Me.btnADR.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnADR.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnADR.OnHoverTextColor = System.Drawing.Color.White
        Me.btnADR.selected = False
        Me.btnADR.Size = New System.Drawing.Size(135, 36)
        Me.btnADR.TabIndex = 4
        Me.btnADR.Text = "Actual Death Rate"
        Me.btnADR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnADR.Textcolor = System.Drawing.Color.White
        Me.btnADR.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnABR
        '
        Me.btnABR.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnABR.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnABR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnABR.BorderRadius = 5
        Me.btnABR.ButtonText = "Actual Birth Rate"
        Me.btnABR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnABR.DisabledColor = System.Drawing.Color.Gray
        Me.btnABR.Iconcolor = System.Drawing.Color.Transparent
        Me.btnABR.Iconimage = CType(resources.GetObject("btnABR.Iconimage"), System.Drawing.Image)
        Me.btnABR.Iconimage_right = Nothing
        Me.btnABR.Iconimage_right_Selected = Nothing
        Me.btnABR.Iconimage_Selected = Nothing
        Me.btnABR.IconMarginLeft = 0
        Me.btnABR.IconMarginRight = 0
        Me.btnABR.IconRightVisible = False
        Me.btnABR.IconRightZoom = 0R
        Me.btnABR.IconVisible = False
        Me.btnABR.IconZoom = 90.0R
        Me.btnABR.IsTab = False
        Me.btnABR.Location = New System.Drawing.Point(21, 26)
        Me.btnABR.Name = "btnABR"
        Me.btnABR.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnABR.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnABR.OnHoverTextColor = System.Drawing.Color.White
        Me.btnABR.selected = False
        Me.btnABR.Size = New System.Drawing.Size(135, 36)
        Me.btnABR.TabIndex = 3
        Me.btnABR.Text = "Actual Birth Rate"
        Me.btnABR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnABR.Textcolor = System.Drawing.Color.White
        Me.btnABR.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnPopDensity
        '
        Me.btnPopDensity.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnPopDensity.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnPopDensity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPopDensity.BorderRadius = 5
        Me.btnPopDensity.ButtonText = "Population Density"
        Me.btnPopDensity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPopDensity.DisabledColor = System.Drawing.Color.Gray
        Me.btnPopDensity.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPopDensity.Iconimage = CType(resources.GetObject("btnPopDensity.Iconimage"), System.Drawing.Image)
        Me.btnPopDensity.Iconimage_right = Nothing
        Me.btnPopDensity.Iconimage_right_Selected = Nothing
        Me.btnPopDensity.Iconimage_Selected = Nothing
        Me.btnPopDensity.IconMarginLeft = 0
        Me.btnPopDensity.IconMarginRight = 0
        Me.btnPopDensity.IconRightVisible = False
        Me.btnPopDensity.IconRightZoom = 0R
        Me.btnPopDensity.IconVisible = False
        Me.btnPopDensity.IconZoom = 90.0R
        Me.btnPopDensity.IsTab = False
        Me.btnPopDensity.Location = New System.Drawing.Point(21, 28)
        Me.btnPopDensity.Name = "btnPopDensity"
        Me.btnPopDensity.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnPopDensity.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnPopDensity.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPopDensity.selected = False
        Me.btnPopDensity.Size = New System.Drawing.Size(135, 36)
        Me.btnPopDensity.TabIndex = 5
        Me.btnPopDensity.Text = "Population Density"
        Me.btnPopDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPopDensity.Textcolor = System.Drawing.Color.White
        Me.btnPopDensity.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnDblTime
        '
        Me.btnDblTime.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnDblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnDblTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDblTime.BorderRadius = 5
        Me.btnDblTime.ButtonText = "Doubling Time"
        Me.btnDblTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDblTime.DisabledColor = System.Drawing.Color.Gray
        Me.btnDblTime.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDblTime.Iconimage = CType(resources.GetObject("btnDblTime.Iconimage"), System.Drawing.Image)
        Me.btnDblTime.Iconimage_right = Nothing
        Me.btnDblTime.Iconimage_right_Selected = Nothing
        Me.btnDblTime.Iconimage_Selected = Nothing
        Me.btnDblTime.IconMarginLeft = 0
        Me.btnDblTime.IconMarginRight = 0
        Me.btnDblTime.IconRightVisible = False
        Me.btnDblTime.IconRightZoom = 0R
        Me.btnDblTime.IconVisible = False
        Me.btnDblTime.IconZoom = 90.0R
        Me.btnDblTime.IsTab = False
        Me.btnDblTime.Location = New System.Drawing.Point(20, 27)
        Me.btnDblTime.Name = "btnDblTime"
        Me.btnDblTime.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnDblTime.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnDblTime.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDblTime.selected = False
        Me.btnDblTime.Size = New System.Drawing.Size(135, 36)
        Me.btnDblTime.TabIndex = 6
        Me.btnDblTime.Text = "Doubling Time"
        Me.btnDblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDblTime.Textcolor = System.Drawing.Color.White
        Me.btnDblTime.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNaPopGrowth
        '
        Me.btnNaPopGrowth.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnNaPopGrowth.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnNaPopGrowth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNaPopGrowth.BorderRadius = 5
        Me.btnNaPopGrowth.ButtonText = "National Pop Growth"
        Me.btnNaPopGrowth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNaPopGrowth.DisabledColor = System.Drawing.Color.Gray
        Me.btnNaPopGrowth.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNaPopGrowth.Iconimage = CType(resources.GetObject("btnNaPopGrowth.Iconimage"), System.Drawing.Image)
        Me.btnNaPopGrowth.Iconimage_right = Nothing
        Me.btnNaPopGrowth.Iconimage_right_Selected = Nothing
        Me.btnNaPopGrowth.Iconimage_Selected = Nothing
        Me.btnNaPopGrowth.IconMarginLeft = 0
        Me.btnNaPopGrowth.IconMarginRight = 0
        Me.btnNaPopGrowth.IconRightVisible = False
        Me.btnNaPopGrowth.IconRightZoom = 0R
        Me.btnNaPopGrowth.IconVisible = False
        Me.btnNaPopGrowth.IconZoom = 90.0R
        Me.btnNaPopGrowth.IsTab = False
        Me.btnNaPopGrowth.Location = New System.Drawing.Point(20, 26)
        Me.btnNaPopGrowth.Name = "btnNaPopGrowth"
        Me.btnNaPopGrowth.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnNaPopGrowth.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnNaPopGrowth.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNaPopGrowth.selected = False
        Me.btnNaPopGrowth.Size = New System.Drawing.Size(135, 36)
        Me.btnNaPopGrowth.TabIndex = 7
        Me.btnNaPopGrowth.Text = "National Pop Growth"
        Me.btnNaPopGrowth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNaPopGrowth.Textcolor = System.Drawing.Color.White
        Me.btnNaPopGrowth.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnGPopGrowth
        '
        Me.btnGPopGrowth.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnGPopGrowth.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnGPopGrowth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGPopGrowth.BorderRadius = 5
        Me.btnGPopGrowth.ButtonText = "Global Pop Growth"
        Me.btnGPopGrowth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGPopGrowth.DisabledColor = System.Drawing.Color.Gray
        Me.btnGPopGrowth.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGPopGrowth.Iconimage = CType(resources.GetObject("btnGPopGrowth.Iconimage"), System.Drawing.Image)
        Me.btnGPopGrowth.Iconimage_right = Nothing
        Me.btnGPopGrowth.Iconimage_right_Selected = Nothing
        Me.btnGPopGrowth.Iconimage_Selected = Nothing
        Me.btnGPopGrowth.IconMarginLeft = 0
        Me.btnGPopGrowth.IconMarginRight = 0
        Me.btnGPopGrowth.IconRightVisible = False
        Me.btnGPopGrowth.IconRightZoom = 0R
        Me.btnGPopGrowth.IconVisible = False
        Me.btnGPopGrowth.IconZoom = 90.0R
        Me.btnGPopGrowth.IsTab = False
        Me.btnGPopGrowth.Location = New System.Drawing.Point(20, 68)
        Me.btnGPopGrowth.Name = "btnGPopGrowth"
        Me.btnGPopGrowth.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnGPopGrowth.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnGPopGrowth.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGPopGrowth.selected = False
        Me.btnGPopGrowth.Size = New System.Drawing.Size(135, 36)
        Me.btnGPopGrowth.TabIndex = 8
        Me.btnGPopGrowth.Text = "Global Pop Growth"
        Me.btnGPopGrowth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGPopGrowth.Textcolor = System.Drawing.Color.White
        Me.btnGPopGrowth.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNePopGrowth
        '
        Me.btnNePopGrowth.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnNePopGrowth.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnNePopGrowth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNePopGrowth.BorderRadius = 5
        Me.btnNePopGrowth.ButtonText = "Net Pop Growth"
        Me.btnNePopGrowth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNePopGrowth.DisabledColor = System.Drawing.Color.Gray
        Me.btnNePopGrowth.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNePopGrowth.Iconimage = CType(resources.GetObject("btnNePopGrowth.Iconimage"), System.Drawing.Image)
        Me.btnNePopGrowth.Iconimage_right = Nothing
        Me.btnNePopGrowth.Iconimage_right_Selected = Nothing
        Me.btnNePopGrowth.Iconimage_Selected = Nothing
        Me.btnNePopGrowth.IconMarginLeft = 0
        Me.btnNePopGrowth.IconMarginRight = 0
        Me.btnNePopGrowth.IconRightVisible = False
        Me.btnNePopGrowth.IconRightZoom = 0R
        Me.btnNePopGrowth.IconVisible = False
        Me.btnNePopGrowth.IconZoom = 90.0R
        Me.btnNePopGrowth.IsTab = False
        Me.btnNePopGrowth.Location = New System.Drawing.Point(20, 110)
        Me.btnNePopGrowth.Name = "btnNePopGrowth"
        Me.btnNePopGrowth.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnNePopGrowth.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnNePopGrowth.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNePopGrowth.selected = False
        Me.btnNePopGrowth.Size = New System.Drawing.Size(135, 36)
        Me.btnNePopGrowth.TabIndex = 9
        Me.btnNePopGrowth.Text = "Net Pop Growth"
        Me.btnNePopGrowth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNePopGrowth.Textcolor = System.Drawing.Color.White
        Me.btnNePopGrowth.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnFuture
        '
        Me.btnFuture.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnFuture.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnFuture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFuture.BorderRadius = 5
        Me.btnFuture.ButtonText = "Future Population"
        Me.btnFuture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFuture.DisabledColor = System.Drawing.Color.Gray
        Me.btnFuture.Iconcolor = System.Drawing.Color.Transparent
        Me.btnFuture.Iconimage = CType(resources.GetObject("btnFuture.Iconimage"), System.Drawing.Image)
        Me.btnFuture.Iconimage_right = Nothing
        Me.btnFuture.Iconimage_right_Selected = Nothing
        Me.btnFuture.Iconimage_Selected = Nothing
        Me.btnFuture.IconMarginLeft = 0
        Me.btnFuture.IconMarginRight = 0
        Me.btnFuture.IconRightVisible = False
        Me.btnFuture.IconRightZoom = 0R
        Me.btnFuture.IconVisible = False
        Me.btnFuture.IconZoom = 90.0R
        Me.btnFuture.IsTab = False
        Me.btnFuture.Location = New System.Drawing.Point(20, 28)
        Me.btnFuture.Name = "btnFuture"
        Me.btnFuture.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnFuture.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnFuture.OnHoverTextColor = System.Drawing.Color.White
        Me.btnFuture.selected = False
        Me.btnFuture.Size = New System.Drawing.Size(135, 36)
        Me.btnFuture.TabIndex = 10
        Me.btnFuture.Text = "Future Population"
        Me.btnFuture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnFuture.Textcolor = System.Drawing.Color.White
        Me.btnFuture.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pnlCrude
        '
        Me.pnlCrude.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.pnlCrude.Controls.Add(Me.BunifuFlatButton11)
        Me.pnlCrude.Controls.Add(Me.btnCBR)
        Me.pnlCrude.Controls.Add(Me.btnCDR)
        Me.pnlCrude.Location = New System.Drawing.Point(15, 73)
        Me.pnlCrude.Name = "pnlCrude"
        Me.pnlCrude.Size = New System.Drawing.Size(172, 129)
        Me.pnlCrude.TabIndex = 11
        '
        'BunifuFlatButton11
        '
        Me.BunifuFlatButton11.Activecolor = System.Drawing.Color.Empty
        Me.BunifuFlatButton11.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton11.BorderRadius = 5
        Me.BunifuFlatButton11.ButtonText = "Future Population"
        Me.BunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton11.Iconimage = CType(resources.GetObject("BunifuFlatButton11.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton11.Iconimage_right = Nothing
        Me.BunifuFlatButton11.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton11.Iconimage_Selected = Nothing
        Me.BunifuFlatButton11.IconMarginLeft = 0
        Me.BunifuFlatButton11.IconMarginRight = 0
        Me.BunifuFlatButton11.IconRightVisible = False
        Me.BunifuFlatButton11.IconRightZoom = 0R
        Me.BunifuFlatButton11.IconVisible = False
        Me.BunifuFlatButton11.IconZoom = 90.0R
        Me.BunifuFlatButton11.IsTab = False
        Me.BunifuFlatButton11.Location = New System.Drawing.Point(232, 298)
        Me.BunifuFlatButton11.Name = "BunifuFlatButton11"
        Me.BunifuFlatButton11.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BunifuFlatButton11.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton11.selected = False
        Me.BunifuFlatButton11.Size = New System.Drawing.Size(135, 36)
        Me.BunifuFlatButton11.TabIndex = 10
        Me.BunifuFlatButton11.Text = "Future Population"
        Me.BunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton11.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton11.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pnlActual
        '
        Me.pnlActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.pnlActual.Controls.Add(Me.btnABR)
        Me.pnlActual.Controls.Add(Me.btnADR)
        Me.pnlActual.Location = New System.Drawing.Point(15, 208)
        Me.pnlActual.Name = "pnlActual"
        Me.pnlActual.Size = New System.Drawing.Size(172, 129)
        Me.pnlActual.TabIndex = 12
        '
        'pnlPopGrowth
        '
        Me.pnlPopGrowth.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.pnlPopGrowth.Controls.Add(Me.btnNaPopGrowth)
        Me.pnlPopGrowth.Controls.Add(Me.btnGPopGrowth)
        Me.pnlPopGrowth.Controls.Add(Me.btnNePopGrowth)
        Me.pnlPopGrowth.Location = New System.Drawing.Point(193, 73)
        Me.pnlPopGrowth.Name = "pnlPopGrowth"
        Me.pnlPopGrowth.Size = New System.Drawing.Size(172, 170)
        Me.pnlPopGrowth.TabIndex = 13
        '
        'pnlDblTime
        '
        Me.pnlDblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.pnlDblTime.Controls.Add(Me.btnDblTime)
        Me.pnlDblTime.Location = New System.Drawing.Point(193, 249)
        Me.pnlDblTime.Name = "pnlDblTime"
        Me.pnlDblTime.Size = New System.Drawing.Size(172, 88)
        Me.pnlDblTime.TabIndex = 14
        '
        'pnlPopDens
        '
        Me.pnlPopDens.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.pnlPopDens.Controls.Add(Me.btnPopDensity)
        Me.pnlPopDens.Location = New System.Drawing.Point(15, 343)
        Me.pnlPopDens.Name = "pnlPopDens"
        Me.pnlPopDens.Size = New System.Drawing.Size(172, 88)
        Me.pnlPopDens.TabIndex = 15
        '
        'pnlFuture
        '
        Me.pnlFuture.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.pnlFuture.Controls.Add(Me.btnFuture)
        Me.pnlFuture.Location = New System.Drawing.Point(193, 343)
        Me.pnlFuture.Name = "pnlFuture"
        Me.pnlFuture.Size = New System.Drawing.Size(172, 88)
        Me.pnlFuture.TabIndex = 16
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(376, 230)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(251, 35)
        Me.BunifuSeparator1.TabIndex = 17
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'lblHeaderData
        '
        Me.lblHeaderData.AutoSize = True
        Me.lblHeaderData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderData.ForeColor = System.Drawing.Color.White
        Me.lblHeaderData.Location = New System.Drawing.Point(376, 260)
        Me.lblHeaderData.Name = "lblHeaderData"
        Me.lblHeaderData.Size = New System.Drawing.Size(128, 16)
        Me.lblHeaderData.TabIndex = 18
        Me.lblHeaderData.Text = "Current Saved Data:"
        '
        'lblHeaderOut
        '
        Me.lblHeaderOut.AutoSize = True
        Me.lblHeaderOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderOut.ForeColor = System.Drawing.Color.White
        Me.lblHeaderOut.Location = New System.Drawing.Point(373, 73)
        Me.lblHeaderOut.Name = "lblHeaderOut"
        Me.lblHeaderOut.Size = New System.Drawing.Size(49, 16)
        Me.lblHeaderOut.TabIndex = 19
        Me.lblHeaderOut.Text = "Output:"
        '
        'lblBirths
        '
        Me.lblBirths.AutoSize = True
        Me.lblBirths.ForeColor = System.Drawing.Color.White
        Me.lblBirths.Location = New System.Drawing.Point(387, 287)
        Me.lblBirths.Name = "lblBirths"
        Me.lblBirths.Size = New System.Drawing.Size(59, 13)
        Me.lblBirths.TabIndex = 20
        Me.lblBirths.Text = "Births: N/A"
        '
        'lblDeaths
        '
        Me.lblDeaths.AutoSize = True
        Me.lblDeaths.ForeColor = System.Drawing.Color.White
        Me.lblDeaths.Location = New System.Drawing.Point(387, 300)
        Me.lblDeaths.Name = "lblDeaths"
        Me.lblDeaths.Size = New System.Drawing.Size(67, 13)
        Me.lblDeaths.TabIndex = 21
        Me.lblDeaths.Text = "Deaths: N/A"
        '
        'lblTotalBirths
        '
        Me.lblTotalBirths.AutoSize = True
        Me.lblTotalBirths.ForeColor = System.Drawing.Color.White
        Me.lblTotalBirths.Location = New System.Drawing.Point(387, 313)
        Me.lblTotalBirths.Name = "lblTotalBirths"
        Me.lblTotalBirths.Size = New System.Drawing.Size(86, 13)
        Me.lblTotalBirths.TabIndex = 22
        Me.lblTotalBirths.Text = "Total Births: N/A"
        '
        'lblTotalDeaths
        '
        Me.lblTotalDeaths.AutoSize = True
        Me.lblTotalDeaths.ForeColor = System.Drawing.Color.White
        Me.lblTotalDeaths.Location = New System.Drawing.Point(387, 326)
        Me.lblTotalDeaths.Name = "lblTotalDeaths"
        Me.lblTotalDeaths.Size = New System.Drawing.Size(94, 13)
        Me.lblTotalDeaths.TabIndex = 23
        Me.lblTotalDeaths.Text = "Total Deaths: N/A"
        '
        'lblImmigrants
        '
        Me.lblImmigrants.AutoSize = True
        Me.lblImmigrants.ForeColor = System.Drawing.Color.White
        Me.lblImmigrants.Location = New System.Drawing.Point(387, 339)
        Me.lblImmigrants.Name = "lblImmigrants"
        Me.lblImmigrants.Size = New System.Drawing.Size(83, 13)
        Me.lblImmigrants.TabIndex = 24
        Me.lblImmigrants.Text = "Immigrants: N/A"
        '
        'lblEmigrants
        '
        Me.lblEmigrants.AutoSize = True
        Me.lblEmigrants.ForeColor = System.Drawing.Color.White
        Me.lblEmigrants.Location = New System.Drawing.Point(387, 352)
        Me.lblEmigrants.Name = "lblEmigrants"
        Me.lblEmigrants.Size = New System.Drawing.Size(79, 13)
        Me.lblEmigrants.TabIndex = 25
        Me.lblEmigrants.Text = "Emigrants: N/A"
        '
        'lblTotalPop
        '
        Me.lblTotalPop.AutoSize = True
        Me.lblTotalPop.ForeColor = System.Drawing.Color.White
        Me.lblTotalPop.Location = New System.Drawing.Point(387, 365)
        Me.lblTotalPop.Name = "lblTotalPop"
        Me.lblTotalPop.Size = New System.Drawing.Size(110, 13)
        Me.lblTotalPop.TabIndex = 26
        Me.lblTotalPop.Text = "Total Population: N/A"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(376, 99)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(251, 135)
        Me.txtOutput.TabIndex = 27
        '
        'btnClear
        '
        Me.btnClear.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.BorderRadius = 5
        Me.btnClear.ButtonText = "Clear Data"
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.DisabledColor = System.Drawing.Color.Gray
        Me.btnClear.Iconcolor = System.Drawing.Color.Transparent
        Me.btnClear.Iconimage = CType(resources.GetObject("btnClear.Iconimage"), System.Drawing.Image)
        Me.btnClear.Iconimage_right = Nothing
        Me.btnClear.Iconimage_right_Selected = Nothing
        Me.btnClear.Iconimage_Selected = Nothing
        Me.btnClear.IconMarginLeft = 0
        Me.btnClear.IconMarginRight = 0
        Me.btnClear.IconRightVisible = True
        Me.btnClear.IconRightZoom = 0R
        Me.btnClear.IconVisible = True
        Me.btnClear.IconZoom = 50.0R
        Me.btnClear.IsTab = False
        Me.btnClear.Location = New System.Drawing.Point(503, 404)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnClear.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnClear.OnHoverTextColor = System.Drawing.Color.White
        Me.btnClear.selected = False
        Me.btnClear.Size = New System.Drawing.Size(124, 35)
        Me.btnClear.TabIndex = 28
        Me.btnClear.Text = "Clear Data"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Textcolor = System.Drawing.Color.White
        Me.btnClear.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSave
        '
        Me.btnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.BorderRadius = 5
        Me.btnSave.ButtonText = "Save Output"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledColor = System.Drawing.Color.Gray
        Me.btnSave.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSave.Iconimage = CType(resources.GetObject("btnSave.Iconimage"), System.Drawing.Image)
        Me.btnSave.Iconimage_right = Nothing
        Me.btnSave.Iconimage_right_Selected = Nothing
        Me.btnSave.Iconimage_Selected = Nothing
        Me.btnSave.IconMarginLeft = 0
        Me.btnSave.IconMarginRight = 0
        Me.btnSave.IconRightVisible = True
        Me.btnSave.IconRightZoom = 0R
        Me.btnSave.IconVisible = True
        Me.btnSave.IconZoom = 50.0R
        Me.btnSave.IsTab = False
        Me.btnSave.Location = New System.Drawing.Point(373, 404)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSave.selected = False
        Me.btnSave.Size = New System.Drawing.Size(124, 35)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save Output"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Textcolor = System.Drawing.Color.White
        Me.btnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FRM_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(639, 449)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lblTotalPop)
        Me.Controls.Add(Me.lblEmigrants)
        Me.Controls.Add(Me.lblImmigrants)
        Me.Controls.Add(Me.lblTotalDeaths)
        Me.Controls.Add(Me.lblTotalBirths)
        Me.Controls.Add(Me.lblDeaths)
        Me.Controls.Add(Me.lblBirths)
        Me.Controls.Add(Me.lblHeaderOut)
        Me.Controls.Add(Me.lblHeaderData)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.pnlFuture)
        Me.Controls.Add(Me.pnlPopDens)
        Me.Controls.Add(Me.pnlDblTime)
        Me.Controls.Add(Me.pnlPopGrowth)
        Me.Controls.Add(Me.pnlActual)
        Me.Controls.Add(Me.pnlCrude)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_Main"
        Me.Text = "AOIT Joint Project"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCrude.ResumeLayout(False)
        Me.pnlActual.ResumeLayout(False)
        Me.pnlPopGrowth.ResumeLayout(False)
        Me.pnlDblTime.ResumeLayout(False)
        Me.pnlPopDens.ResumeLayout(False)
        Me.pnlFuture.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents picExit As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents BunifuDragControl_H As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl_L As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents pnlCrude As Panel
    Friend WithEvents btnCBR As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnCDR As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnFuture As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNePopGrowth As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnGPopGrowth As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNaPopGrowth As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDblTime As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPopDensity As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnADR As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnABR As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents pnlFuture As Panel
    Friend WithEvents pnlPopDens As Panel
    Friend WithEvents pnlDblTime As Panel
    Friend WithEvents pnlPopGrowth As Panel
    Friend WithEvents pnlActual As Panel
    Friend WithEvents BunifuFlatButton11 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblHeaderData As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lblBirths As Label
    Friend WithEvents lblHeaderOut As Label
    Friend WithEvents lblTotalPop As Label
    Friend WithEvents lblEmigrants As Label
    Friend WithEvents lblImmigrants As Label
    Friend WithEvents lblTotalDeaths As Label
    Friend WithEvents lblTotalBirths As Label
    Friend WithEvents lblDeaths As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnClear As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuFlatButton
End Class
