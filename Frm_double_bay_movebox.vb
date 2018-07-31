Imports TALLY.DBControl
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Math
Imports System.Drawing.Printing
Public Class Frm_double_bay_movebox
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意：以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents Pl_bay_map As System.Windows.Forms.Panel
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_defined_bay As System.Windows.Forms.ComboBox
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents gp_first_bay As System.Windows.Forms.GroupBox
    Friend WithEvents gp_secend_bay As System.Windows.Forms.GroupBox
    Friend WithEvents gp_change As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_ENG_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents txt_VOYAGE As System.Windows.Forms.TextBox
    Friend WithEvents txt_POL As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_secend As System.Windows.Forms.ComboBox
    Friend WithEvents pl_third As System.Windows.Forms.Panel
    Friend WithEvents pl_secend As System.Windows.Forms.Panel
    Friend WithEvents txt_container_no As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents c1dbg_secend As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents gp_first_c1 As System.Windows.Forms.GroupBox
    Friend WithEvents gp_secend_c1 As System.Windows.Forms.GroupBox
    Friend WithEvents ckb_block As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_double_bay_movebox))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Dim GridLines2 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.gp_first_bay = New System.Windows.Forms.GroupBox()
        Me.Pl_bay_map = New System.Windows.Forms.Panel()
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_defined_bay = New System.Windows.Forms.ComboBox()
        Me.btn_cancle = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_secend = New System.Windows.Forms.ComboBox()
        Me.gp_first_c1 = New System.Windows.Forms.GroupBox()
        Me.c1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.gp_secend_bay = New System.Windows.Forms.GroupBox()
        Me.pl_secend = New System.Windows.Forms.Panel()
        Me.gp_change = New System.Windows.Forms.GroupBox()
        Me.pl_third = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_ENG_VESSEL = New System.Windows.Forms.TextBox()
        Me.txt_VOYAGE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_POL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckb_block = New System.Windows.Forms.CheckBox()
        Me.txt_container_no = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gp_secend_c1 = New System.Windows.Forms.GroupBox()
        Me.c1dbg_secend = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gp_first_bay.SuspendLayout()
        Me.gp_first_c1.SuspendLayout()
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_secend_bay.SuspendLayout()
        Me.gp_change.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gp_secend_c1.SuspendLayout()
        CType(Me.c1dbg_secend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gp_first_bay
        '
        Me.gp_first_bay.Controls.AddRange(New System.Windows.Forms.Control() {Me.Pl_bay_map})
        Me.gp_first_bay.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.gp_first_bay.ForeColor = System.Drawing.Color.IndianRed
        Me.gp_first_bay.Location = New System.Drawing.Point(20, 36)
        Me.gp_first_bay.Name = "gp_first_bay"
        Me.gp_first_bay.Size = New System.Drawing.Size(320, 340)
        Me.gp_first_bay.TabIndex = 0
        Me.gp_first_bay.TabStop = False
        '
        'Pl_bay_map
        '
        Me.Pl_bay_map.AutoScroll = True
        Me.Pl_bay_map.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pl_bay_map.Location = New System.Drawing.Point(3, 25)
        Me.Pl_bay_map.Name = "Pl_bay_map"
        Me.Pl_bay_map.Size = New System.Drawing.Size(314, 312)
        Me.Pl_bay_map.TabIndex = 5
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(552, 8)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(52, 24)
        Me.btn_enter.TabIndex = 10
        Me.btn_enter.Text = "确认"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(314, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "FIRST"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_defined_bay
        '
        Me.cmb_defined_bay.Location = New System.Drawing.Point(350, 10)
        Me.cmb_defined_bay.Name = "cmb_defined_bay"
        Me.cmb_defined_bay.Size = New System.Drawing.Size(44, 20)
        Me.cmb_defined_bay.TabIndex = 7
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(604, 8)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(52, 24)
        Me.btn_cancle.TabIndex = 9
        Me.btn_cancle.Text = "返回"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(394, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "SECEND"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_secend
        '
        Me.cmb_secend.Location = New System.Drawing.Point(436, 10)
        Me.cmb_secend.Name = "cmb_secend"
        Me.cmb_secend.Size = New System.Drawing.Size(44, 20)
        Me.cmb_secend.TabIndex = 7
        '
        'gp_first_c1
        '
        Me.gp_first_c1.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1dbg})
        Me.gp_first_c1.Dock = System.Windows.Forms.DockStyle.Right
        Me.gp_first_c1.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.gp_first_c1.ForeColor = System.Drawing.Color.IndianRed
        Me.gp_first_c1.Location = New System.Drawing.Point(662, 0)
        Me.gp_first_c1.Name = "gp_first_c1"
        Me.gp_first_c1.Size = New System.Drawing.Size(184, 755)
        Me.gp_first_c1.TabIndex = 6
        Me.gp_first_c1.TabStop = False
        '
        'c1dbg
        '
        Me.c1dbg.AllowFilter = True
        Me.c1dbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.c1dbg.AllowSort = True
        Me.c1dbg.CaptionHeight = 18
        Me.c1dbg.CollapseColor = System.Drawing.Color.Black
        Me.c1dbg.DataChanged = False
        Me.c1dbg.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1dbg.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveDown
        Me.c1dbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1dbg.ExpandColor = System.Drawing.Color.Black
        Me.c1dbg.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.c1dbg.ForeColor = System.Drawing.SystemColors.Control
        Me.c1dbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbg.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.c1dbg.Location = New System.Drawing.Point(3, 25)
        Me.c1dbg.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.c1dbg.Name = "c1dbg"
        Me.c1dbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbg.PreviewInfo.ZoomFactor = 75
        Me.c1dbg.PrintInfo.ShowOptionsDialog = False
        Me.c1dbg.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.c1dbg.RowDivider = GridLines1
        Me.c1dbg.RowHeight = 16
        Me.c1dbg.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1dbg.ScrollTips = False
        Me.c1dbg.Size = New System.Drawing.Size(178, 727)
        Me.c1dbg.TabIndex = 0
        Me.c1dbg.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{Font:宋体, 9pt;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" & _
        "t;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor" & _
        ":Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style" & _
        "8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><S" & _
        "plits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCaptionHei" & _
        "ght=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSelectorW" & _
        "idth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1"">" & _
        "<ClientRect>0, 0, 174, 723</ClientRect><BorderSide>0</BorderSide><CaptionStyle p" & _
        "arent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRo" & _
        "wStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Sty" & _
        "le13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me" & _
        "=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle par" & _
        "ent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" />" & _
        "<OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSe" & _
        "lector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style par" & _
        "ent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles" & _
        "><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style par" & _
        "ent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent" & _
        "=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=" & _
        """Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=" & _
        """Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Head" & _
        "ing"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent" & _
        "=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</h" & _
        "orzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><Clien" & _
        "tArea>0, 0, 174, 723</ClientArea></Blob>"
        '
        'gp_secend_bay
        '
        Me.gp_secend_bay.Controls.AddRange(New System.Windows.Forms.Control() {Me.pl_secend})
        Me.gp_secend_bay.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.gp_secend_bay.ForeColor = System.Drawing.Color.IndianRed
        Me.gp_secend_bay.Location = New System.Drawing.Point(20, 376)
        Me.gp_secend_bay.Name = "gp_secend_bay"
        Me.gp_secend_bay.Size = New System.Drawing.Size(320, 340)
        Me.gp_secend_bay.TabIndex = 7
        Me.gp_secend_bay.TabStop = False
        '
        'pl_secend
        '
        Me.pl_secend.AutoScroll = True
        Me.pl_secend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pl_secend.Location = New System.Drawing.Point(3, 25)
        Me.pl_secend.Name = "pl_secend"
        Me.pl_secend.Size = New System.Drawing.Size(314, 312)
        Me.pl_secend.TabIndex = 6
        '
        'gp_change
        '
        Me.gp_change.Controls.AddRange(New System.Windows.Forms.Control() {Me.pl_third})
        Me.gp_change.Location = New System.Drawing.Point(342, 202)
        Me.gp_change.Name = "gp_change"
        Me.gp_change.Size = New System.Drawing.Size(314, 322)
        Me.gp_change.TabIndex = 0
        Me.gp_change.TabStop = False
        Me.gp_change.Text = "临时存放"
        '
        'pl_third
        '
        Me.pl_third.AutoScroll = True
        Me.pl_third.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pl_third.Location = New System.Drawing.Point(3, 17)
        Me.pl_third.Name = "pl_third"
        Me.pl_third.Size = New System.Drawing.Size(308, 302)
        Me.pl_third.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-2, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "船名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXT_ENG_VESSEL
        '
        Me.TXT_ENG_VESSEL.Location = New System.Drawing.Point(28, 10)
        Me.TXT_ENG_VESSEL.Name = "TXT_ENG_VESSEL"
        Me.TXT_ENG_VESSEL.TabIndex = 12
        Me.TXT_ENG_VESSEL.Text = ""
        '
        'txt_VOYAGE
        '
        Me.txt_VOYAGE.Location = New System.Drawing.Point(158, 10)
        Me.txt_VOYAGE.Name = "txt_VOYAGE"
        Me.txt_VOYAGE.TabIndex = 12
        Me.txt_VOYAGE.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(128, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "航次"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_POL
        '
        Me.txt_POL.Location = New System.Drawing.Point(288, 10)
        Me.txt_POL.Name = "txt_POL"
        Me.txt_POL.Size = New System.Drawing.Size(26, 21)
        Me.txt_POL.TabIndex = 12
        Me.txt_POL.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(258, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "POL"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_cancle, Me.cmb_defined_bay, Me.TXT_ENG_VESSEL, Me.Label2, Me.txt_VOYAGE, Me.btn_enter, Me.Label1, Me.Label3, Me.cmb_secend, Me.Label5, Me.Label4, Me.txt_POL, Me.ckb_block})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 36)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'ckb_block
        '
        Me.ckb_block.Location = New System.Drawing.Point(492, 8)
        Me.ckb_block.Name = "ckb_block"
        Me.ckb_block.Size = New System.Drawing.Size(62, 24)
        Me.ckb_block.TabIndex = 16
        Me.ckb_block.Text = "块操作"
        '
        'txt_container_no
        '
        Me.txt_container_no.Location = New System.Drawing.Point(418, 593)
        Me.txt_container_no.Name = "txt_container_no"
        Me.txt_container_no.TabIndex = 14
        Me.txt_container_no.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(370, 592)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "箱号"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gp_secend_c1
        '
        Me.gp_secend_c1.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1dbg_secend})
        Me.gp_secend_c1.Dock = System.Windows.Forms.DockStyle.Right
        Me.gp_secend_c1.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.gp_secend_c1.ForeColor = System.Drawing.Color.IndianRed
        Me.gp_secend_c1.Location = New System.Drawing.Point(846, 0)
        Me.gp_secend_c1.Name = "gp_secend_c1"
        Me.gp_secend_c1.Size = New System.Drawing.Size(184, 755)
        Me.gp_secend_c1.TabIndex = 6
        Me.gp_secend_c1.TabStop = False
        '
        'c1dbg_secend
        '
        Me.c1dbg_secend.AllowFilter = True
        Me.c1dbg_secend.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.c1dbg_secend.AllowSort = True
        Me.c1dbg_secend.CaptionHeight = 18
        Me.c1dbg_secend.CollapseColor = System.Drawing.Color.Black
        Me.c1dbg_secend.DataChanged = False
        Me.c1dbg_secend.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1dbg_secend.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveDown
        Me.c1dbg_secend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1dbg_secend.ExpandColor = System.Drawing.Color.Black
        Me.c1dbg_secend.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.c1dbg_secend.ForeColor = System.Drawing.SystemColors.Control
        Me.c1dbg_secend.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbg_secend.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.c1dbg_secend.Location = New System.Drawing.Point(3, 25)
        Me.c1dbg_secend.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.c1dbg_secend.Name = "c1dbg_secend"
        Me.c1dbg_secend.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbg_secend.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbg_secend.PreviewInfo.ZoomFactor = 75
        Me.c1dbg_secend.PrintInfo.ShowOptionsDialog = False
        Me.c1dbg_secend.RecordSelectorWidth = 16
        GridLines2.Color = System.Drawing.Color.DarkGray
        GridLines2.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.c1dbg_secend.RowDivider = GridLines2
        Me.c1dbg_secend.RowHeight = 16
        Me.c1dbg_secend.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1dbg_secend.ScrollTips = False
        Me.c1dbg_secend.Size = New System.Drawing.Size(178, 727)
        Me.c1dbg_secend.TabIndex = 0
        Me.c1dbg_secend.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Borde" & _
        "r:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" Colu" & _
        "mnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" Def" & _
        "RecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0" & _
        ", 0, 174, 723</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
        """ me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent" & _
        "=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><Foot" & _
        "erStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" />" & _
        "<HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""Highligh" & _
        "tRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle " & _
        "parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""S" & _
        "tyle11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" " & _
        "me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style paren" & _
        "t="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading""" & _
        " me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me" & _
        "=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""" & _
        "Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""" & _
        "EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""Reco" & _
        "rdSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me" & _
        "=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><La" & _
        "yout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 1" & _
        "74, 723</ClientArea></Blob>"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(466, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 24)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "刷新"
        '
        'Frm_double_bay_movebox
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1030, 755)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label6, Me.txt_container_no, Me.GroupBox1, Me.gp_secend_bay, Me.gp_first_c1, Me.gp_first_bay, Me.gp_change, Me.gp_secend_c1, Me.Button1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_double_bay_movebox"
        Me.Text = "贝间倒箱"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gp_first_bay.ResumeLayout(False)
        Me.gp_first_c1.ResumeLayout(False)
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_secend_bay.ResumeLayout(False)
        Me.gp_change.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gp_secend_c1.ResumeLayout(False)
        CType(Me.c1dbg_secend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds_defined_bay As New DataSet()
    Dim storedpagesettings As PageSettings
    '填充C1 
    Dim ds_c1dbg As New DataSet()
    Dim sqlda_c1dbg As New SqlClient.SqlDataAdapter()
    Dim ds_c1dbg_secend As New DataSet()
    Dim sqlda_c1dbg_secend As New SqlClient.SqlDataAdapter()
    '船信息
    Dim container_No As String '箱号
    Dim unload_port As String '卸货港首字母
    Dim rect_width As Integer = 14
    Dim rect_width_half As Integer = 7
    Dim v_id As Integer
    Dim ENG_VESSEL As String
    Dim CHI_VESSEL As String
    Dim VOYAGE As String
    Dim ds_exist_bay As New DataSet()
    Dim ds_ship As New DataSet()
    Dim i, j, n, k As Integer
    Dim col_count As Integer
    Dim ds_oldbayno As New DataSet() '修改前箱子的贝位号
    Dim ds_size_con As New DataSet() '判断箱子的大小
    'first
    Dim bmp_bay_map As Bitmap
    Dim bmpgraphics_bay_map As Graphics
    Dim first_mark As Integer
    Dim block_first_mark As Integer
    Dim pl_first_point1x As Integer '在panel third上第一次有效单击的横坐标
    Dim pl_first_point1y As Integer '在panel third上第一次有效单击的纵坐标
    'secend
    Dim bmp_bay_map_secend As Bitmap
    Dim bmpgraphics_secend As Graphics
    Dim secend_mark As Integer '判断刷新标志
    Dim block_second_mark As Integer
    'third panel
    Dim bmp_bay_map_third As Bitmap
    Dim bmpgraphics_third As Graphics
    Dim third_mark As Integer '判断刷新标志
    Dim block_third_mark As Integer
    Dim distoleft_third As Integer
    Dim pl_third_point1x As Integer '在panel third上第一次有效单击的横坐标
    Dim pl_third_point1y As Integer '在panel third上第一次有效单击的纵坐标

    Dim pen_line As New Pen(Color.Black, 1)
    Dim print_result As New PrintDocument()
    Dim distolefe As Integer = 0 '距左边距移动的位移
    Dim distotop As Integer = 0 '最上面一行写BAY
    Dim ff As New FontFamily("宋体")
    Dim f As New Font(ff, 6)
    Dim f_container As New Font(ff, 4)
    Dim bay_f As New Font(ff, 25, FontStyle.Bold)
    Dim container_f As New Font(ff, 10, FontStyle.Regular)
    Dim bru_fill As New SolidBrush(Color.Blue) '有箱子的填充色
    Dim bru_sys As SolidBrush ' 系统的填充色

    Dim bru_selected As New SolidBrush(Color.Green)    '单击选中矩形的填充色
    '计算贝列
    Dim strcon As Integer '左边空列标志
    Dim strsmallcol As Integer '有无空列的最小列
    Dim strbigcol As Integer '有无空列的最大列

    '甲板 'panel first上的最大列最小列
    Dim ds_board_char As New DataSet()
    Dim small_row_first As Integer '在屏幕上的最小行
    Dim small_col_first As Integer
    Dim big_row_first As Integer
    Dim big_col_first As Integer
    'panel second 上的最大列最小列
    Dim big_col_second As Integer
    Dim small_col_second As Integer
    Dim small_row_second As Integer '在屏幕上的最小行
    Dim big_row_second As Integer

    Dim ds_board As New DataSet()
    Dim bay_row As String
    Dim bay_col As String
    Dim ds_unuse_col As New DataSet()
    Dim BAYNO As String
    Dim ds_container As New DataSet() '找箱号
    '舱内
    Dim ds_cabin As New DataSet()
    Dim ds_cabin_char As New DataSet()
    Dim small_row_cabin_first As Integer
    Dim small_col_cabin_first As Integer
    Dim big_row_cabin_first As Integer
    Dim big_col_cabin_first As Integer
    'panel second 上的最大列最小列
    Dim big_col_cabin_second As Integer
    Dim small_col_cabin_second As Integer
    Dim small_row_cabin_second As Integer
    Dim big_row_cabin_second As Integer

    Dim bay_row_cabin As String
    Dim bay_col_cabin As String
    'Dim storepagesettings As New PageSettings()
    '鼠标单击事件
    Dim p As Point
    Dim color1 As Color
    Dim rectx As Single
    Dim recty As Single
    Dim j_col As Integer
    Dim i_row As Integer
    Dim col_count_board_first As Integer
    Dim col_count_cabin_first As Integer
    Dim col_count_board_second As Integer
    Dim col_count_cabin_second As Integer

    Dim mark As String
    Dim btn_count As Integer = 0 '鼠标单击次数
    Dim bayno_check As String
    Dim bayno_check_joint As String
    Dim bayno_add As String '通贝的贝位好
    Dim sql_str_bayno As String
    Dim ds_bayno As New DataSet()
    '第一个中转third panel
    Dim arrthird(19, 19) As String  '存放400个数据(箱号)
    Dim arrunload_port(19, 19) As String '存放400个卸货港标志
    Dim arr_row As Integer '数组中的行号
    Dim arr_col As Integer '数组中的列号
    'block块操作
    Dim i_block As Integer
    Dim j_block As Integer '块操作循环变量
    Dim block_secondpoint As Point '块操作的第二点
    Dim block_row As Integer '块的行
    Dim block_col As Integer '块的列
    Dim bool_block As Boolean = False '块标志
    Dim bool_block_second As Boolean '判断要插入的位置是否有足够的位置放置选择好的块
    Dim arrblock(19, 19) As String '存放400个数据(箱号) 块数据
    Dim arrblock_unload_port(19, 19) As String '存放400个卸货港标志  块数据
    Dim block_third_pointx As Integer '块操作的第三点的横坐标
    Dim block_third_pointy As Integer '块操作的第三点的纵坐标
    Private Sub Frm_double_bay_movebox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '系统填充色
        bru_sys = New SolidBrush(Me.BackColor)
        'first
        bmp_bay_map = New Bitmap(800, 900) '(Me.Pl_bay_map.Width, Me.Pl_bay_map.Height) 
        bmpgraphics_bay_map = Graphics.FromImage(bmp_bay_map)
        Me.Pl_bay_map.BackgroundImage = bmp_bay_map
        'secend
        bmp_bay_map_secend = New Bitmap(800, 900)
        bmpgraphics_secend = Graphics.FromImage(bmp_bay_map_secend)
        Me.pl_secend.BackgroundImage = bmp_bay_map_secend
        'third panel
        bmp_bay_map_third = New Bitmap(600, 600)
        bmpgraphics_third = Graphics.FromImage(bmp_bay_map_third)
        Me.pl_third.BackgroundImage = bmp_bay_map_third
        'third panel的左边锯
        distoleft_third = rect_width
        third_panel_map() '画临时存放的大矩形
        'forth panel

        pen_line.DashStyle = DashStyle.Solid
        '写船名
        If Getdata("select VESSEL_ID,VESSEL.ENG_VESSEL,VESSEL.CHI_VESSEL, sship.VOYAGE from VESSEL,sship where sship.ship_id=" & Ship_ID & " and sship.v_id=VESSEL.VESSEL_id", ds_ship).Count > 0 Then
            v_id = ds_ship.Tables(0).Rows(0).Item("VESSEL_id")
            ENG_VESSEL = ds_ship.Tables(0).Rows(0).Item("ENG_VESSEL")
            '中文船名可以不要
            '   CHI_VESSEL = ds_ship.Tables(0).Rows(0).Item("CHI_VESSEL")
            VOYAGE = ds_ship.Tables(0).Rows(0).Item("VOYAGE")
            '写船名航次
            Me.TXT_ENG_VESSEL.Text = ENG_VESSEL
            Me.txt_VOYAGE.Text = VOYAGE
            Me.txt_POL.Text = "LYG"
            '写已存在的贝列
            If Getdata("select  bay_num from con_map,sship where sship.ship_id='" & Ship_ID & "' and sship.v_id=con_map.v_id group by bay_num order by bay_num", ds_exist_bay).Count > 0 Then
                For i = 0 To ds_exist_bay.Tables(0).Rows.Count - 1
                    Me.cmb_defined_bay.Items.Add(ds_exist_bay.Tables(0).Rows(i).Item("bay_num"))
                    Me.cmb_secend.Items.Add(ds_exist_bay.Tables(0).Rows(i).Item("bay_num"))
                Next
            End If
        End If
    End Sub

    Private Sub third_panel_map()
        '清空
        bmpgraphics_third.Clear(Me.BackColor)
        '画矩形
        For i = 0 To 19
            For j = 0 To 19
                bmpgraphics_third.DrawRectangle(pen_line, distoleft_third + i * rect_width, j * rect_width, rect_width, rect_width)
            Next
        Next
        '画行号
        For j = 0 To 19
            If j < 9 Then
                bmpgraphics_third.DrawString("0" & (j + 1), Me.Font, Brushes.Black, 0, j * rect_width + 2)
            Else
                bmpgraphics_third.DrawString(j + 1, Me.Font, Brushes.Black, 0, j * rect_width + 2)
            End If
        Next
        '画列号
        For i = 0 To 19
            If i < 9 Then
                bmpgraphics_third.DrawString("0" & (i + 1), Me.Font, Brushes.Black, distoleft_third + i * rect_width, 20 * rect_width + 1)
            Else
                bmpgraphics_third.DrawString((i + 1), Me.Font, Brushes.Black, distoleft_third + i * rect_width, 20 * rect_width + 1)
            End If
        Next
        Me.pl_third.Refresh()
    End Sub

    Private Sub cmb_defined_bay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_defined_bay.TextChanged
        'panel
        Me.gp_first_bay.Text = "BAY " & Me.cmb_defined_bay.Text
        '甲板
        small_col_first = 0
        big_col_first = 0
        small_row_first = 0
        big_row_first = 0
        '舱内
        small_col_cabin_first = 0
        big_col_cabin_first = 0
        small_row_cabin_first = 0
        big_row_cabin_first = 0
        show_bay_map_first(bmpgraphics_bay_map, Trim(Me.cmb_defined_bay.Text), big_col_first, small_col_first, big_col_cabin_first, small_col_cabin_first)
        'c1
        Me.gp_first_c1.Text = "BAY " & Me.cmb_defined_bay.Text
        fill_c1dbg()
        Me.Pl_bay_map.Refresh()
    End Sub

    Private Sub cmb_secend_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_secend.TextChanged
        'panel
        Me.gp_secend_bay.Text = "BAY " & Me.cmb_secend.Text
        '甲板
        small_col_second = 0
        big_col_second = 0
        small_row_second = 0
        big_row_second = 0
        '舱内
        small_col_cabin_second = 0
        big_col_cabin_second = 0
        small_row_cabin_second = 0
        big_row_cabin_second = 0
        show_bay_map_second(bmpgraphics_secend, Trim(Me.cmb_secend.Text), big_col_second, small_col_second, big_col_cabin_second, small_col_cabin_second)
        'bc1_secend
        Me.gp_secend_c1.Text = "BAY " & Me.cmb_secend.Text
        Me.pl_secend.Refresh()
        fill_c1dbg_secend()
    End Sub

    '填充C1_first
    Private Sub fill_c1dbg()
        If Len(Trim(Me.cmb_defined_bay.Text)) > 0 Then
            If CType(Me.cmb_defined_bay.Text, Integer) + 1 < 10 Then
                bayno_add = "0" & CType(Me.cmb_defined_bay.Text, Integer) + 1
            Else
                bayno_add = CType(Me.cmb_defined_bay.Text, Integer) + 1
            End If
            Me.c1dbg.DataSource = Updatedata(sqlda_c1dbg, "select CONTAINER_NO,BAYNO,CON_IMAGE_ID from con_image where (bayno like '" & Trim(Me.cmb_defined_bay.Text) & "%'  or bayno like '" & bayno_add & "%') and ship_id=" & Ship_ID, ds_c1dbg)
            Me.c1dbg.Columns.Item(1).Caption = "贝位号"
            Me.c1dbg.Columns.Item(0).Caption = "箱号"
            Me.c1dbg.Splits(0).DisplayColumns.Item(0).Width = 83
            Me.c1dbg.Splits(0).DisplayColumns.Item(1).Width = 57
            Me.c1dbg.Splits(0).DisplayColumns.Item(0).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            Me.c1dbg.Splits(0).DisplayColumns.Item(1).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            Me.c1dbg.Splits(0).DisplayColumns.Item(2).Visible = False
            Me.c1dbg.Refresh()
        End If

    End Sub

    '填充c1_secend
    Private Sub fill_c1dbg_secend()
        If Len(Trim(Me.cmb_secend.Text)) > 0 Then
            If CType(Me.cmb_secend.Text, Integer) + 1 < 10 Then
                bayno_add = "0" & CType(Me.cmb_secend.Text, Integer) + 1
            Else
                bayno_add = CType(Me.cmb_secend.Text, Integer) + 1

            End If
            Me.c1dbg_secend.DataSource = Updatedata(sqlda_c1dbg_secend, "select CONTAINER_NO,BAYNO,CON_IMAGE_ID from con_image where (bayno like '" & Trim(Me.cmb_secend.Text) & "%' or bayno like '" & bayno_add & "%') and ship_id=" & Ship_ID, ds_c1dbg_secend)
            Me.c1dbg_secend.Columns.Item(1).Caption = "贝位号"
            Me.c1dbg_secend.Columns.Item(0).Caption = "箱号"
            Me.c1dbg_secend.Splits(0).DisplayColumns.Item(0).Width = 83
            Me.c1dbg_secend.Splits(0).DisplayColumns.Item(1).Width = 57
            Me.c1dbg_secend.Splits(0).DisplayColumns.Item(0).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            Me.c1dbg_secend.Splits(0).DisplayColumns.Item(1).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            Me.c1dbg_secend.Splits(0).DisplayColumns.Item(2).Visible = False
            Me.c1dbg_secend.Refresh()
        End If

    End Sub

    Private Sub show_bay_map_second(ByVal bmpgraphics_bay_map As Graphics, ByVal str_selected_bay As String, ByRef big_col As Integer, ByRef small_col As Integer, ByRef big_col_cabin As Integer, ByRef small_col_cabin As Integer)
        '清空
        bmpgraphics_bay_map.Clear(Me.BackColor)

        ''甲板取甲板的列数
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & str_selected_bay & "' and location='board' order by id", ds_board).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & str_selected_bay & "' and location='board'", ds_board_char)
            small_row_second = ds_board_char.Tables(0).Rows(0).Item("small_row") '取甲板屏幕的最小行
            big_row_second = ds_board_char.Tables(0).Rows(0).Item("big_row") '取甲板屏幕的最大行
            small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") '取甲板屏幕的最小列
            big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") '取甲板屏幕的最大列
        End If
        '取舱内的列数
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & str_selected_bay & "' and location='cabin' order by id", ds_cabin).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & str_selected_bay & "' and location='cabin'", ds_cabin_char)
            small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") '取舱内屏幕的最小列
            big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") '取舱内屏幕的最大列
            small_row_cabin_second = ds_cabin_char.Tables(0).Rows(0).Item("small_row") '取舱内屏幕的最小行
            big_row_cabin_second = ds_cabin_char.Tables(0).Rows(0).Item("big_row") '取舱内屏幕的最大行
        End If
        '甲板开始
        If ds_board.Tables(0).Rows.Count > 0 Then
            '计算甲板结果图的顶点位置
            If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '比较甲板和舱内的列数
                col_count = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If
            ''画甲板矩形
            For i = small_row_second To big_row_second 'i是在屏幕上的行数
                For j = small_col To big_col 'j是在屏幕上的列数
                    If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_second) + j - small_col).Item("user_char") = 1 Then
                        '矩形
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * rect_width_half + rect_width * (j - small_col + 1), distotop + rect_width * 10 - rect_width * (i - small_row_second + 1), rect_width, rect_width)
                        '贝位号
                        BAYNO = ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_second) + j - small_col).Item("bay_num") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_second) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_second) + j - small_col).Item("bay_row")
                        '通贝贝位号
                        '计算通贝贝号+1
                        If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_second) + j - small_col).Item("bay_num") + 1 < 10 Then
                            bayno_add = "0" & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_second) + j - small_col).Item("bay_num") + 1
                        Else
                            bayno_add = ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_second) + j - small_col).Item("bay_num") + 1
                        End If
                        '计算通贝贝位号
                        bayno_add = bayno_add & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_second) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_second) + j - small_col).Item("bay_row")
                        '判断此通贝贝位号有无箱号
                        '判断此贝位号有无箱号
                        If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT from con_image where  (con_image.BAYNO='" & BAYNO & "' or con_image.BAYNO='" & bayno_add & "')and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            '填充矩形
                            bmpgraphics_bay_map.FillRectangle(bru_fill, distolefe + col_count * rect_width_half + rect_width * (j - small_col + 1) + 1, distotop + rect_width * 10 - rect_width * (i - small_row_second + 1) + 1, rect_width - 1, rect_width - 1)
                            bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("code_unload_port"), container_f, Brushes.DarkGray, distolefe + col_count * rect_width_half + rect_width * (j - small_col + 1) + 2, distotop + rect_width * 10 - rect_width * (i - small_row_second + 1) + 1)
                        End If

                    End If
                Next
            Next
            '画贝层
            For i = small_row_second To big_row_second '战位最大屏列,按行读，行坐标先变
                bay_row = 78 + i * 2
                bmpgraphics_bay_map.DrawString(bay_row, Me.Font, Brushes.Black, distolefe, distotop + rect_width * 10 - rect_width * (i - small_row_second + 1) + 2)  '贝层
            Next
            ''写贝列
            n = big_col - small_col + 1
            strcon = 1
            strsmallcol = small_col
            strbigcol = big_col
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & str_selected_bay & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col = "0" & k * 2
                        Else
                            bay_col = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col = "0" & k * 2
                            Else
                                bay_col = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_bay_map.DrawString(bay_col, Me.Font, Brushes.Black, distolefe + col_count * rect_width_half + rect_width * (j - strsmallcol + strcon), distotop + rect_width * 10 + 1)   '贝列
            Next
        End If '甲板结束
        ''舱内开始
        If ds_cabin.Tables(0).Rows.Count > 0 Then
            '计算舱内结果图的顶点位置
            If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                col_count = (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If
            ''画舱内矩形
            For i = small_row_cabin_second To big_row_cabin_second
                For j = small_col_cabin To big_col_cabin
                    If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_second) + j - small_col_cabin).Item("user_char") = 1 Then
                        '矩形
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * rect_width_half + rect_width * (j - small_col_cabin + 1), distotop + rect_width * 11 + (big_row_cabin_second - small_row_cabin_second + 1) * rect_width - rect_width * (i - small_row_cabin_second + 1), rect_width, rect_width)
                        '贝位号
                        BAYNO = ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_second) + j - small_col_cabin).Item("bay_num") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_second) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_second) + j - small_col_cabin).Item("bay_row")
                        '通贝贝位号
                        '计算通贝贝号
                        If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_second) + j - small_col_cabin).Item("bay_num") + 1 < 10 Then
                            bayno_add = "0" & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_second) + j - small_col_cabin).Item("bay_num") + 1
                        Else
                            bayno_add = ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_second) + j - small_col_cabin).Item("bay_num") + 1
                        End If
                        '计算通贝贝位号
                        bayno_add = bayno_add & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_second) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_second) + j - small_col_cabin).Item("bay_row")
                        '判断此通贝贝位号有无箱号
                        '判断此贝位号有无箱号
                        If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT from con_image where ( con_image.BAYNO='" & BAYNO & "' or con_image.BAYNO='" & bayno_add & "') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            '填充矩形
                            bmpgraphics_bay_map.FillRectangle(bru_fill, distolefe + col_count * rect_width_half + rect_width * (j - small_col_cabin + 1) + 1, distotop + rect_width * 11 + (big_row_cabin_second - small_row_cabin_second + 1) * rect_width - rect_width * (i - small_row_cabin_second + 1) + 1, rect_width - 1, rect_width - 1)
                            bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("code_unload_port"), container_f, Brushes.DarkGray, distolefe + col_count * rect_width_half + rect_width * (j - small_col_cabin + 1) + 2, distotop + rect_width * 11 + (big_row_cabin_second - small_row_cabin_second + 1) * rect_width - rect_width * (i - small_row_cabin_second + 1) + 1)
                        End If
                    End If
                Next
            Next
            '画贝层
            For i = small_row_cabin_second To big_row_cabin_second '战位最大屏列,按行读，行坐标先变
                If i * 2 < 10 Then
                    bay_row_cabin = "0" & i * 2
                Else
                    bay_row_cabin = i * 2
                End If
                bmpgraphics_bay_map.DrawString(bay_row_cabin, Me.Font, Brushes.Black, distolefe, distotop + rect_width * 11 + (big_row_cabin_second - small_row_cabin_second + 1 + 1) * rect_width - rect_width * (i - small_row_cabin_second + 1) - rect_width + 1) '贝层
            Next
            ''写贝列
            n = big_col_cabin - small_col_cabin + 1
            strcon = 1
            strsmallcol = small_col_cabin
            strbigcol = big_col_cabin
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & str_selected_bay & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col_cabin + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col_cabin = "0" & k * 2
                        Else
                            bay_col_cabin = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col_cabin = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col_cabin = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col_cabin + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col_cabin = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col_cabin = "0" & k * 2
                            Else
                                bay_col_cabin = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col_cabin = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col_cabin = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_bay_map.DrawString(bay_col_cabin, Me.Font, Brushes.Black, distolefe + col_count * rect_width_half + rect_width * (j - strsmallcol + strcon), distotop + rect_width * 11 + (big_row_cabin_second - small_row_cabin_second + 1) * rect_width + 1) '贝列
            Next
        End If
        ' Me.Pl_bay_map.Refresh()
    End Sub
    'first bay
    Private Sub show_bay_map_first(ByVal bmpgraphics_bay_map As Graphics, ByVal str_selected_bay As String, ByRef big_col As Integer, ByRef small_col As Integer, ByRef big_col_cabin As Integer, ByRef small_col_cabin As Integer)
        '清空
        bmpgraphics_bay_map.Clear(Me.BackColor)

        ''甲板取甲板的列数
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & str_selected_bay & "' and location='board' order by id", ds_board).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & str_selected_bay & "' and location='board'", ds_board_char)
            small_row_first = ds_board_char.Tables(0).Rows(0).Item("small_row") '取甲板屏幕的最小行
            big_row_first = ds_board_char.Tables(0).Rows(0).Item("big_row") '取甲板屏幕的最大行
            small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") '取甲板屏幕的最小列
            big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") '取甲板屏幕的最大列
        End If
        '取舱内的列数
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & str_selected_bay & "' and location='cabin' order by id", ds_cabin).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & str_selected_bay & "' and location='cabin'", ds_cabin_char)
            small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") '取舱内屏幕的最小列
            big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") '取舱内屏幕的最大列
            small_row_cabin_first = ds_cabin_char.Tables(0).Rows(0).Item("small_row") '取舱内屏幕的最小行
            big_row_cabin_first = ds_cabin_char.Tables(0).Rows(0).Item("big_row") '取舱内屏幕的最大行
        End If
        '甲板开始
        If ds_board.Tables(0).Rows.Count > 0 Then
            '计算甲板结果图的顶点位置
            If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '比较甲板和舱内的列数
                col_count = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If
            ''画甲板矩形
            For i = small_row_first To big_row_first 'i是在屏幕上的行数
                For j = small_col To big_col 'j是在屏幕上的列数
                    If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_first) + j - small_col).Item("user_char") = 1 Then
                        '矩形
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * rect_width_half + rect_width * (j - small_col + 1), distotop + rect_width * 10 - rect_width * (i - small_row_first + 1), rect_width, rect_width)
                        '贝位号
                        BAYNO = ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_first) + j - small_col).Item("bay_num") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_first) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_first) + j - small_col).Item("bay_row")
                        '通贝贝位号
                        '计算通贝贝号+1
                        If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_first) + j - small_col).Item("bay_num") + 1 < 10 Then
                            bayno_add = "0" & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_first) + j - small_col).Item("bay_num") + 1
                        Else
                            bayno_add = ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_first) + j - small_col).Item("bay_num") + 1
                        End If
                        '计算通贝贝位号
                        bayno_add = bayno_add & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_first) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row_first) + j - small_col).Item("bay_row")
                        '判断此通贝贝位号有无箱号
                        '判断此贝位号有无箱号
                        If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT from con_image where  (con_image.BAYNO='" & BAYNO & "' or con_image.BAYNO='" & bayno_add & "')and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            '填充矩形
                            bmpgraphics_bay_map.FillRectangle(bru_fill, distolefe + col_count * rect_width_half + rect_width * (j - small_col + 1) + 1, distotop + rect_width * 10 - rect_width * (i - small_row_first + 1) + 1, rect_width - 1, rect_width - 1)
                            bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("code_unload_port"), container_f, Brushes.DarkGray, distolefe + col_count * rect_width_half + rect_width * (j - small_col + 1) + 2, distotop + rect_width * 10 - rect_width * (i - small_row_first + 1) + 1)
                        End If

                    End If
                Next
            Next
            '画贝层
            For i = small_row_first To big_row_first '战位最大屏列,按行读，行坐标先变
                bay_row = 78 + i * 2
                bmpgraphics_bay_map.DrawString(bay_row, Me.Font, Brushes.Black, distolefe, distotop + rect_width * 10 - rect_width * (i - small_row_first + 1) + 2)  '贝层
            Next
            ''写贝列
            n = big_col - small_col + 1
            strcon = 1
            strsmallcol = small_col
            strbigcol = big_col
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & str_selected_bay & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col = "0" & k * 2
                        Else
                            bay_col = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col = "0" & k * 2
                            Else
                                bay_col = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_bay_map.DrawString(bay_col, Me.Font, Brushes.Black, distolefe + col_count * rect_width_half + rect_width * (j - strsmallcol + strcon), distotop + rect_width * 10 + 1)   '贝列
            Next
        End If '甲板结束
        ''舱内开始
        If ds_cabin.Tables(0).Rows.Count > 0 Then
            '计算舱内结果图的顶点位置
            If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                col_count = (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If
            ''画舱内矩形
            For i = small_row_cabin_first To big_row_cabin_first
                For j = small_col_cabin To big_col_cabin
                    If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_first) + j - small_col_cabin).Item("user_char") = 1 Then
                        '矩形
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * rect_width_half + rect_width * (j - small_col_cabin + 1), distotop + rect_width * 11 + (big_row_cabin_first - small_row_cabin_first + 1) * rect_width - rect_width * (i - small_row_cabin_first + 1), rect_width, rect_width)
                        '贝位号
                        BAYNO = ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_first) + j - small_col_cabin).Item("bay_num") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_first) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_first) + j - small_col_cabin).Item("bay_row")
                        '通贝贝位号
                        '计算通贝贝号
                        If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_first) + j - small_col_cabin).Item("bay_num") + 1 < 10 Then
                            bayno_add = "0" & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_first) + j - small_col_cabin).Item("bay_num") + 1
                        Else
                            bayno_add = ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_first) + j - small_col_cabin).Item("bay_num") + 1
                        End If
                        '计算通贝贝位号
                        bayno_add = bayno_add & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_first) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin_first) + j - small_col_cabin).Item("bay_row")
                        '判断此通贝贝位号有无箱号
                        '判断此贝位号有无箱号
                        If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT from con_image where ( con_image.BAYNO='" & BAYNO & "' or con_image.BAYNO='" & bayno_add & "') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            '填充矩形
                            bmpgraphics_bay_map.FillRectangle(bru_fill, distolefe + col_count * rect_width_half + rect_width * (j - small_col_cabin + 1) + 1, distotop + rect_width * 11 + (big_row_cabin_first - small_row_cabin_first + 1) * rect_width - rect_width * (i - small_row_cabin_first + 1) + 1, rect_width - 1, rect_width - 1)
                            bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("code_unload_port"), container_f, Brushes.DarkGray, distolefe + col_count * rect_width_half + rect_width * (j - small_col_cabin + 1) + 2, distotop + rect_width * 11 + (big_row_cabin_first - small_row_cabin_first + 1) * rect_width - rect_width * (i - small_row_cabin_first + 1) + 1)
                        End If
                    End If
                Next
            Next
            '画贝层
            For i = small_row_cabin_first To big_row_cabin_first '战位最大屏列,按行读，行坐标先变
                If i * 2 < 10 Then
                    bay_row_cabin = "0" & i * 2
                Else
                    bay_row_cabin = i * 2
                End If
                bmpgraphics_bay_map.DrawString(bay_row_cabin, Me.Font, Brushes.Black, distolefe, distotop + rect_width * 11 + (big_row_cabin_first - small_row_cabin_first + 1 + 1) * rect_width - rect_width * (i - small_row_cabin_first + 1) - rect_width + 1) '贝层
            Next
            ''写贝列
            n = big_col_cabin - small_col_cabin + 1
            strcon = 1
            strsmallcol = small_col_cabin
            strbigcol = big_col_cabin
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & str_selected_bay & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col_cabin + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col_cabin = "0" & k * 2
                        Else
                            bay_col_cabin = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col_cabin = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col_cabin = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col_cabin + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col_cabin = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col_cabin = "0" & k * 2
                            Else
                                bay_col_cabin = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col_cabin = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col_cabin = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_bay_map.DrawString(bay_col_cabin, Me.Font, Brushes.Black, distolefe + col_count * rect_width_half + rect_width * (j - strsmallcol + strcon), distotop + rect_width * 11 + (big_row_cabin_first - small_row_cabin_first + 1) * rect_width + 1) '贝列
            Next
        End If
        ' Me.Pl_bay_map.Refresh()
    End Sub
    'first bay
    Private Sub Pl_bay_map_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pl_bay_map.MouseDown
        If e.Button = MouseButtons.Left Then
            '鼠标第一次单击开始
            color1 = bmp_bay_map.GetPixel(e.X, e.Y)
            '计算甲板结果图的顶点位置
            If (big_col_cabin_first - small_col_cabin_first + 1) - (big_col_first - small_col_first + 1) >= 0 Then '比较甲板和舱内的列数
                col_count_board_first = (big_col_cabin_first - small_col_cabin_first + 1) - (big_col_first - small_col_first + 1) ''甲板上列数和舱内的差额
            Else
                col_count_board_first = 0
            End If
            '计算舱内结果图的顶点位置
            If (big_col_first - small_col_first + 1) - (big_col_cabin_first - small_col_cabin_first + 1) >= 0 Then
                col_count_cabin_first = (big_col_first - small_col_first + 1) - (big_col_cabin_first - small_col_cabin_first + 1) ''甲板上列数和舱内的差额
            Else
                col_count_cabin_first = 0
            End If

            ''处理块
            If Me.ckb_block.Checked = True Then
                If color1.ToArgb = Color.Blue.ToArgb Or color1.ToArgb = Color.DarkGray.ToArgb Then
                    '背景有色的情况开始
                    If first_mark = 1 Then
                        '块操作开始
                        first_mark = 0
                        block_first_mark = 1 '标志选种的块在first panel 上
                        bool_block = True
                        '计算矩形原点
                        block_secondpoint.Y = Fix(e.Y / rect_width) * rect_width   '  纵坐标
                        ' 横坐标
                        If block_secondpoint.Y < distotop + rect_width * 11 Then
                            mark = "board"
                            '在甲板上
                            block_secondpoint.X = Fix((e.X - 14 - col_count_board_first * rect_width_half) / rect_width)
                            '平行
                            j_col = Fix(block_secondpoint.X) + 1
                            block_secondpoint.X = 14 + col_count_board_first * rect_width_half + (block_secondpoint.X) * rect_width
                            '平列
                            i_row = Fix((distotop + rect_width * 10 - block_secondpoint.Y) / rect_width) + small_row_first - 1
                        Else
                            mark = "cabin"
                            '在舱内
                            block_secondpoint.X = Fix((e.X - 14 - col_count_cabin_first * rect_width_half) / rect_width)
                            '平行
                            j_col = Fix(block_secondpoint.X) + 1
                            block_secondpoint.X = 14 + col_count_cabin_first * rect_width_half + (block_secondpoint.X) * rect_width
                            '平列
                            i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_first - small_row_cabin_first + 1) * rect_width) - block_secondpoint.Y) / rect_width) + small_row_cabin_first - 1
                        End If
                        block_row = (block_secondpoint.Y - pl_first_point1y) / rect_width + 1 '块的行数
                        block_col = (block_secondpoint.X - pl_first_point1x) / rect_width + 1 '块的列数
                        '判断块是否有效
                        For i_block = 0 To block_row - 1
                            For j_block = 0 To block_col - 1
                                If bmp_bay_map.GetPixel(pl_first_point1x + j_block * rect_width + 2, pl_first_point1y + i_block * rect_width + 2).ToArgb <> Color.Blue.ToArgb And bmp_bay_map.GetPixel(pl_first_point1x + i_block * rect_width + 2, pl_first_point1y + j_block * rect_width + 2).ToArgb <> Color.DarkGray.ToArgb Then
                                    block_first_mark = 0 '标志选种的块在first panel 上
                                    bool_block = False
                                End If
                            Next
                        Next
                        '处理有效块
                        If bool_block = True Then
                            For i_block = 0 To block_row - 1
                                For j_block = 0 To block_col - 1
                                    '填充有效块
                                    bmpgraphics_bay_map.FillRectangle(bru_selected, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                    '记下块的每个箱号和卸货港
                                    p.X = pl_first_point1x + j_block * rect_width
                                    p.Y = pl_first_point1y + i_block * rect_width
                                    recty = p.Y / rect_width
                                    recty = Fix(recty) * rect_width
                                    If recty < distotop + rect_width * 11 Then
                                        rectx = (p.X - 14 - col_count_board_first * rect_width_half) / rect_width
                                        mark = "board"
                                        i_row = Fix((distotop + rect_width * 10 - recty) / rect_width) + small_row_first - 1
                                        j_col = Fix(rectx) + 1
                                    Else
                                        rectx = (p.X - 14 - col_count_cabin_first * rect_width_half) / rect_width ' 
                                        mark = "cabin"
                                        i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_first - small_row_cabin_first + 1) * rect_width) - recty) / rect_width) + small_row_cabin_first - 1
                                        j_col = Fix(rectx) + 1
                                    End If
                                    If Getdata("select bay_num + bay_col + bay_row from con_map where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and location='" & mark & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'and screen_col='" & j_col & "' and screen_row='" & i_row & "'", ds_bayno).Count > 0 Then
                                        bayno_check = ds_bayno.Tables(0).Rows(0).Item(0)
                                        ''''''找数据库中是否存在通贝的箱子
                                        If CType(Mid(bayno_check, 1, 2), Integer) + 1 < 10 Then
                                            bayno_check_joint = "0" & Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 5)
                                        Else
                                            bayno_check_joint = Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4)
                                        End If

                                        If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT from con_image where  (con_image.BAYNO='" & bayno_check & "' or con_image.BAYNO='" & bayno_check_joint & "') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                            '箱号
                                            arrblock(i_block, j_block) = ds_container.Tables(0).Rows(0).Item("container_no")
                                            '卸货港首字母
                                            arrblock_unload_port(i_block, j_block) = ds_container.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
                                        End If
                                    End If
                                Next
                            Next
                            Me.Pl_bay_map.Refresh()
                        End If
                    Else
                        'first_mark=0的情况
                        btn_count = 1 '鼠标第一次有效单机
                        first_mark = 1 '在first panel上有效单季
                        secend_mark = 0 '在secend panel上的单季无效
                        third_mark = 0 '在third panel上的淡季有效
                        p.X = e.X
                        p.Y = e.Y
                        recty = p.Y / rect_width
                        recty = Fix(recty) * rect_width
                        If recty < distotop + rect_width * 11 Then
                            rectx = (p.X - 14 - col_count_board_first * rect_width_half) / rect_width
                            mark = "board"
                            i_row = Fix((distotop + rect_width * 10 - recty) / rect_width) + small_row_first - 1
                            j_col = Fix(rectx) + 1
                            ' 横坐标
                            pl_first_point1x = 14 + col_count_board_first * rect_width_half + (j_col - 1) * rect_width
                        Else
                            rectx = (p.X - 14 - col_count_cabin_first * rect_width_half) / rect_width ' 
                            mark = "cabin"
                            i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_first - small_row_cabin_first + 1) * rect_width) - recty) / rect_width) + small_row_cabin_first - 1
                            j_col = Fix(rectx) + 1
                            ' 横坐标
                            pl_first_point1x = 14 + col_count_cabin_first * rect_width_half + (j_col - 1) * rect_width
                        End If
                        '记下点所属的矩形的横纵坐标
                        '  纵坐标
                        pl_first_point1y = recty
                        If Getdata("select bay_num + bay_col + bay_row from con_map where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and location='" & mark & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'and screen_col='" & j_col & "' and screen_row='" & i_row & "'", ds_bayno).Count > 0 Then
                            bayno_check = ds_bayno.Tables(0).Rows(0).Item(0)
                            ''''''找数据库中是否存在通贝的箱子
                            If CType(Mid(bayno_check, 1, 2), Integer) + 1 < 10 Then
                                bayno_check_joint = "0" & Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 5)
                            Else
                                bayno_check_joint = Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4)
                            End If

                            If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT from con_image where ( con_image.BAYNO='" & bayno_check & "' or con_image.BAYNO='" & bayno_check_joint & "') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                '箱号
                                container_No = ds_container.Tables(0).Rows(0).Item("container_no")
                                Me.txt_container_no.Text = ds_container.Tables(0).Rows(0).Item("container_no")
                                '卸货港首字母
                                unload_port = ds_container.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
                            End If
                        End If
                    End If
                    '背景有色的情况结束
                Else
                    '背景色为空的情况
                    If color1.ToArgb <> Color.Blue.ToArgb And color1.ToArgb <> Color.DarkGray.ToArgb And color1.ToArgb <> Color.Green.ToArgb Then
                        If bool_block = True Then
                            bool_block = False

                            '处理选择好的块,记下第三点的坐标
                            p.X = e.X
                            p.Y = e.Y
                            recty = p.Y / rect_width
                            recty = Fix(recty) * rect_width
                            If recty < distotop + rect_width * 11 Then
                                rectx = (p.X - 14 - col_count_board_first * rect_width_half) / rect_width
                                mark = "board"
                                i_row = Fix((distotop + rect_width * 10 - recty) / rect_width) + small_row_first - 1
                                j_col = Fix(rectx) + 1
                                ' 块的第三点的横坐标
                                block_third_pointx = 14 + col_count_board_first * rect_width_half + (j_col - 1) * rect_width
                            Else
                                rectx = (p.X - 14 - col_count_cabin_first * rect_width_half) / rect_width ' 
                                mark = "cabin"
                                i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_first - small_row_cabin_first + 1) * rect_width) - recty) / rect_width) + small_row_cabin_first - 1
                                j_col = Fix(rectx) + 1
                                ' 块的第三点的横坐标
                                block_third_pointx = 14 + col_count_cabin_first * rect_width_half + (j_col - 1) * rect_width
                            End If
                            '块的第三点的 纵坐标
                            block_third_pointy = recty
                            '查看是否有足够的空间放选择好的块
                            bool_block_second = True
                            For i_block = 0 To block_row - 1
                                If bool_block_second = False Then
                                    Exit For
                                End If
                                For j_block = 0 To block_col - 1
                                    ''判断选种的箱子有没有大箱
                                    '’如果有大箱，要判断此贝是否通贝
                                    Getdata("select size_con from CON_CRITERION,con_image where CON_CRITERION.container_No=con_image.container_no and con_image.ship_id='" & Ship_ID & "' and CON_CRITERION.container_No='" & arrblock(i_block, j_block) & "'", ds_size_con)
                                    If ds_size_con.Tables(0).Rows(0).Item(0) > 20 Then
                                        '箱尺寸大于20
                                        '判断此贝是否为通贝
                                        Getdata("select joint from con_bay where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and  bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'", ds_bayno)
                                        If ds_bayno.Tables(0).Rows(0).Item(0) = 0 Then
                                            bool_block_second = False
                                            MsgBox("箱号为'" & arrblock(i_block, j_block) & "'的箱子是大箱，此贝非通贝，不能放，请查验！", MsgBoxStyle.OKOnly, "提示")
                                            pl_third_refresh()
                                            Exit For
                                        End If
                                    End If
                                    'If recty < distotop + rect_width * 11 Then
                                    '    '查看甲板横坐标是否满足
                                    '    If block_third_pointx + j_block * rect_width > rect_width * (big_col - small_col + 1) Then
                                    '        bool_block_second = False
                                    '        MsgBox("没有足够的贝位号放置已选择的块，请检验！", MsgBoxStyle.OKOnly, "提示！")
                                    '        Exit For
                                    '    End If
                                    '    '查看甲板纵坐标是否满足
                                    '    If block_third_pointy + i_block * rect_width < rect_width * 10 - (big_row - small_row + 1) * rect_width Or block_third_pointy + i_block * rect_width > rect_width * 10 Then
                                    '        bool_block_second = False
                                    '        MsgBox("没有足够的贝位号放置已选择的块，请检验！", MsgBoxStyle.OKOnly, "提示！")
                                    '        Exit For
                                    '    End If
                                    'Else
                                    '    '查看藏内横坐标是否满足
                                    '    If block_third_pointx + j_block * rect_width > rect_width * (big_col_cabin - small_col_cabin + 1) Then
                                    '        bool_block_second = False
                                    '        MsgBox("没有足够的贝位号放置已选择的块，请检验！", MsgBoxStyle.OKOnly, "提示！")
                                    '        Exit For
                                    '    End If
                                    '    '查看藏内纵坐标是否满足
                                    '    If block_third_pointy + i_block * rect_width > rect_width * 11 + (big_row_cabin - small_row_cabin + 1) * rect_width Or block_third_pointy + i_block * rect_width < rect_width * 11 Then
                                    '        bool_block_second = False
                                    '        MsgBox("没有足够的贝位号放置已选择的块，请检验！", MsgBoxStyle.OKOnly, "提示！")
                                    '        Exit For
                                    '    End If
                                    'End If

                                    If bmp_bay_map.GetPixel(block_third_pointx + j_block * rect_width + 2, block_third_pointy + i_block * rect_width + 2).ToArgb = Color.Blue.ToArgb Or bmp_bay_map.GetPixel(block_third_pointx + i_block * rect_width + 2, block_third_pointy + j_block * rect_width + 2).ToArgb = Color.DarkGray.ToArgb Then
                                        bool_block_second = False
                                        MsgBox("没有足够的贝位号放置已选择的块，请检验！", MsgBoxStyle.OKOnly, "提示！")
                                        pl_third_refresh()
                                        Exit For
                                    End If
                                Next
                            Next

                            If bool_block_second = True Then
                                '存在足够的空间放置选择好的块
                                For i_block = 0 To block_row - 1
                                    For j_block = 0 To block_col - 1
                                        p.X = block_third_pointx + j_block * rect_width
                                        p.Y = block_third_pointy + i_block * rect_width
                                        recty = p.Y / rect_width
                                        recty = Fix(recty) * rect_width
                                        If recty < distotop + rect_width * 11 Then
                                            rectx = (p.X - 14 - col_count_board_first * rect_width_half) / rect_width
                                            mark = "board"
                                            i_row = Fix((distotop + rect_width * 10 - recty) / rect_width) + small_row_first - 1
                                            j_col = Fix(rectx) + 1
                                        Else
                                            rectx = (p.X - 14 - col_count_cabin_first * rect_width_half) / rect_width ' 
                                            mark = "cabin"
                                            i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_first - small_row_cabin_first + 1) * rect_width) - recty) / rect_width) + small_row_cabin_first - 1
                                            j_col = Fix(rectx) + 1
                                        End If
                                        If Getdata("select bay_num + bay_col + bay_row from con_map where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and location='" & mark & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'and screen_col='" & j_col & "' and screen_row='" & i_row & "' and user_char=1", ds_bayno).Count > 0 Then
                                            bayno_check = ds_bayno.Tables(0).Rows(0).Item(0)
                                            ''''取出箱子的尺寸判断是否属于大箱
                                            Getdata("select size_con from CON_CRITERION,con_image where CON_CRITERION.container_No=con_image.container_no and con_image.ship_id='" & Ship_ID & "' and CON_CRITERION.container_No='" & arrblock(i_block, j_block) & "'", ds_size_con)
                                            If ds_size_con.Tables(0).Rows(0).Item(0) <= 20 Then
                                                ''箱尺寸小于20
                                                '判断原贝位号是否为空OLDBAYNO,填充此字段
                                                Getdata("select moved,oldbayno,CODE_LOAD_PORT,CODE_UNLOAD_PORT from con_image where container_no='" & arrblock(i_block, j_block) & "'  and ship_Id=" & Ship_ID, ds_oldbayno)
                                                If ds_oldbayno.Tables(0).Rows(0).Item("moved") = 0 Then '原贝位号是否为空OLDBAYNO
                                                    If (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_load_port")) Like "*lyg*") Or (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_unload_port")) Like "*lyg*") Then
                                                        '装货港和卸货港都不为连云港时，填充oldbayno
                                                    Else
                                                        ExecSql("UPDATE con_image set oldbayno=bayno,moved=1 where container_No='" & arrblock(i_block, j_block) & "'  and ship_Id=" & Ship_ID)
                                                    End If
                                                End If
                                                '更新新贝位号
                                                ExecSql("UPDATE con_image set bayno='" & bayno_check & "' where container_No='" & arrblock(i_block, j_block) & "' and ship_Id=" & Ship_ID)
                                                '清空贝位号箱号
                                                bayno_check = ""
                                                container_No = ""
                                            Else
                                                '箱尺寸大于20
                                                '判断此贝是否为通贝
                                                Getdata("select joint from con_bay where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and  bay_num='" & Mid(bayno_check, 1, 2) & "'", ds_bayno)
                                                If ds_bayno.Tables(0).Rows(0).Item(0) = 1 Then
                                                    '通贝
                                                    '判断原贝位号是否为空OLDBAYNO,填充此字段
                                                    Getdata("select moved,oldbayno,CODE_LOAD_PORT,CODE_UNLOAD_PORT from con_image where container_no='" & arrblock(i_block, j_block) & "'  and ship_Id=" & Ship_ID, ds_oldbayno)
                                                    If ds_oldbayno.Tables(0).Rows(0).Item("moved") = 0 Then '原贝位号是否为空OLDBAYNO
                                                        If (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_load_port")) Like "*lyg*") Or (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_unload_port")) Like "*lyg*") Then
                                                            '装货港和卸货港都不为连云港时，填充oldbayno
                                                        Else
                                                            ExecSql("UPDATE con_image set oldbayno=bayno,moved=1 where container_No='" & arrblock(i_block, j_block) & "'  and ship_Id=" & Ship_ID)
                                                        End If
                                                    End If
                                                    '更新新贝位号
                                                    If CType(Mid(bayno_check, 1, 2), Integer) + 1 < 10 Then
                                                        bayno_check_joint = "0" & Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4) '55555555555
                                                    Else
                                                        bayno_check_joint = Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4)
                                                    End If
                                                    '偶数bay
                                                    If CType(Mid(bayno_check, 1, 2), Integer) Mod 2 = 0 Then
                                                        bayno_check_joint = bayno_check
                                                    End If
                                                    ExecSql("UPDATE con_image set bayno='" & bayno_check_joint & "' where container_No='" & arrblock(i_block, j_block) & "' and ship_Id=" & Ship_ID)
                                                    '清空贝位号箱号
                                                    bayno_check = ""
                                                    container_No = ""
                                                Else
                                                    '不通贝
                                                    MsgBox("非通贝，不能放大箱子，请查验！", MsgBoxStyle.OKOnly, "提示！")
                                                    pl_third_refresh()
                                                    Exit Sub
                                                End If
                                            End If


                                            ''判断原贝位号是否为空OLDBAYNO,填充此字段
                                            'Getdata("select oldbayno,CODE_LOAD_PORT,CODE_UNLOAD_PORT from con_image where container_no='" & arrblock(i_block, j_block) & "' and ship_Id=" & Ship_ID, ds_oldbayno)
                                            'If ds_oldbayno.Tables(0).Rows(0).Item("oldbayno") Is System.DBNull.Value Then '原贝位号是否为空OLDBAYNO
                                            '    If (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_load_port")) Like "*lyg*") Or (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_unload_port")) Like "*lyg*") Then
                                            '        '装货港和卸货港都不为连云港时，填充oldbayno
                                            '    Else
                                            '        ExecSql("UPDATE con_image set oldbayno=bayno where container_No='" & arrblock(i_block, j_block) & "' and ship_Id=" & Ship_ID)
                                            '    End If
                                            'End If

                                            '''更新箱子的新贝位号
                                            'ExecSql("UPDATE con_image set bayno='" & bayno_check & "' where container_No='" & arrblock(i_block, j_block) & "' and ship_Id=" & Ship_ID)

                                            ' 判断是甲板还是舱内
                                            If recty < distotop + rect_width * 11 Then
                                                '填充移动后BAY作在矩形的颜色
                                                bmpgraphics_bay_map.FillRectangle(bru_fill, 14 + (col_count_board_first) * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1, rect_width - 1, rect_width - 1)
                                                '填充移动后BAY作在矩形的卸货港
                                                bmpgraphics_bay_map.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, 14 + col_count_board_first * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1)
                                            Else
                                                '填充移动后BAY作在矩形的颜色
                                                bmpgraphics_bay_map.FillRectangle(bru_fill, 14 + (col_count_cabin_first) * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1, rect_width - 1, rect_width - 1)
                                                '填充移动后BAY作在矩形的卸货港
                                                bmpgraphics_bay_map.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, 14 + col_count_cabin_first * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1)
                                            End If


                                            '判断是从哪里得来的箱号
                                            If block_first_mark = 1 Then '本贝内移动
                                                '填充移动前BAY作在矩形的颜色
                                                bmpgraphics_bay_map.FillRectangle(bru_sys, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            End If
                                            If block_second_mark = 1 Then '本贝内移动
                                                '填充移动前BAY作在矩形的颜色
                                                bmpgraphics_secend.FillRectangle(bru_sys, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            End If
                                            If block_third_mark = 1 Then
                                                '填充移动前BAY作在矩形的颜色
                                                bmpgraphics_third.FillRectangle(bru_sys, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            End If

                                        End If
                                    Next
                                Next
                                If block_first_mark = 1 Then
                                    block_first_mark = 0
                                End If
                                If block_second_mark = 1 Then
                                    block_second_mark = 0
                                    Me.pl_secend.Refresh()
                                End If
                                If block_third_mark = 1 Then
                                    Me.pl_third.Refresh()
                                End If
                                Me.Pl_bay_map.Refresh()
                                fill_c1dbg()
                                fill_c1dbg_secend()
                            Else
                                '恢复已选种的有效块
                                For i_block = 0 To block_row - 1
                                    For j_block = 0 To block_col - 1
                                        '没有足够的空间放置选择好的块
                                        '判断是从哪里得来的箱号
                                        If block_first_mark = 1 Then '本贝内移动
                                            '恢复有效块
                                            bmpgraphics_bay_map.FillRectangle(bru_fill, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            '恢复卸货港
                                            bmpgraphics_bay_map.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1)
                                        End If
                                        If block_second_mark = 1 Then '本贝内移动
                                            '恢复有效块
                                            bmpgraphics_secend.FillRectangle(bru_fill, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            '恢复卸货港
                                            bmpgraphics_secend.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1)
                                        End If
                                        If block_third_mark = 1 Then
                                            '恢复有效块
                                            bmpgraphics_third.FillRectangle(bru_fill, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            '恢复卸货港
                                            bmpgraphics_third.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1)
                                        End If
                                    Next
                                Next
                                If block_first_mark = 1 Then
                                    block_first_mark = 0
                                End If
                                If block_second_mark = 1 Then
                                    block_second_mark = 0
                                    Me.pl_secend.Refresh()
                                End If
                                If block_third_mark = 1 Then
                                    Me.pl_third.Refresh()
                                End If
                                Me.Pl_bay_map.Refresh()
                                fill_c1dbg()
                                fill_c1dbg_secend()
                            End If
                        End If
                        '背景色为空的情况结束
                    End If
                End If
            End If
            ''处理块结束

            ''处理单个箱子
            If Me.ckb_block.Checked = False Then
                If color1.ToArgb = Color.Blue.ToArgb Or color1.ToArgb = Color.DarkGray.ToArgb Then '
                    btn_count = 1 '鼠标第一次有效单机
                    first_mark = 1 '在first panel上有效单季
                    secend_mark = 0 '在secend panel上的单季无效
                    third_mark = 0 '在third panel上的淡季有效
                    p.X = e.X
                    p.Y = e.Y
                    recty = p.Y / rect_width
                    recty = Fix(recty) * rect_width
                    If recty < distotop + rect_width * 11 Then
                        rectx = (p.X - 14 - col_count_board_first * rect_width_half) / rect_width
                        mark = "board" 'distotop + rect_width * 10 - rect_width * (i - small_row + 1)
                        i_row = Fix((distotop + rect_width * 10 - recty) / rect_width) + small_row_first - 1
                        j_col = Fix(rectx) + 1
                        ' 横坐标
                        pl_first_point1x = 14 + col_count_board_first * rect_width_half + (j_col - 1) * rect_width
                    Else
                        rectx = (p.X - 14 - col_count_cabin_first * rect_width_half) / rect_width ' 
                        mark = "cabin" 'distotop + rect_width * 11 + (big_row_cabin - small_row_cabin + 1) * rect_width - rect_width * (i - small_row_cabin + 1)
                        i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_first - small_row_cabin_first + 1) * rect_width) - recty) / rect_width) + small_row_cabin_first - 1
                        j_col = Fix(rectx) + 1
                        ' 横坐标
                        pl_first_point1x = 14 + col_count_cabin_first * rect_width_half + (j_col - 1) * rect_width
                    End If
                    '记下点所属的矩形的横纵坐标
                    '  纵坐标
                    pl_first_point1y = recty
                    If Getdata("select bay_num + bay_col + bay_row from con_map where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and location='" & mark & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'and screen_col='" & j_col & "' and screen_row='" & i_row & "'", ds_bayno).Count > 0 Then
                        bayno_check = ds_bayno.Tables(0).Rows(0).Item(0)
                        ''''''找数据库中是否存在通贝的箱子
                        If CType(Mid(bayno_check, 1, 2), Integer) + 1 < 10 Then
                            bayno_check_joint = "0" & Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4) '555555555
                        Else
                            bayno_check_joint = Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4)
                        End If

                        If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT from con_image where  (con_image.BAYNO='" & bayno_check & "' or con_image.BAYNO='" & bayno_check_joint & "') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            '箱号
                            container_No = ds_container.Tables(0).Rows(0).Item("container_no")
                            Me.txt_container_no.Text = ds_container.Tables(0).Rows(0).Item("container_no")
                            '卸货港首字母
                            unload_port = ds_container.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
                        End If
                    End If
                Else
                    '空白色
                    If color1.ToArgb = Me.BackColor.ToArgb Then
                        If btn_count Mod 2 = 1 Then
                            btn_count = 0
                            '鼠标第二次单击
                            '计算甲板结果图的顶点位置
                            p.X = e.X
                            p.Y = e.Y
                            recty = p.Y / rect_width
                            recty = Fix(recty) * rect_width
                            If recty < distotop + rect_width * 11 Then
                                rectx = (p.X - 14 - col_count_board_first * rect_width_half) / rect_width
                                'rectx = Fix(rectx) * rect_width
                                mark = "board"
                                i_row = Fix((distotop + rect_width * 10 - recty) / rect_width) + small_row_first - 1
                                j_col = Fix(rectx) + 1
                            Else
                                rectx = (p.X - 14 - col_count_cabin_first * rect_width_half) / rect_width ' 
                                mark = "cabin"
                                i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_first - small_row_cabin_first + 1) * rect_width) - recty) / rect_width) + small_row_cabin_first - 1
                                j_col = Fix(rectx) + 1
                            End If
                            If Getdata("select bay_num + bay_col + bay_row from con_map where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and location='" & mark & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'and screen_col='" & j_col & "' and screen_row='" & i_row & "' and user_char=1", ds_bayno).Count > 0 Then
                                bayno_check = ds_bayno.Tables(0).Rows(0).Item(0)
                                ''''取出箱子的尺寸判断是否属于大箱
                                Getdata("select size_con from CON_CRITERION,con_image where CON_CRITERION.container_No=con_image.container_no and con_image.ship_id='" & Ship_ID & "' and CON_CRITERION.container_No='" & container_No & "'", ds_size_con)
                                If ds_size_con.Tables(0).Rows(0).Item(0) <= 20 Then
                                    ''箱尺寸小于20
                                    '判断原贝位号是否为空OLDBAYNO,填充此字段
                                    Getdata("select moved,oldbayno,CODE_LOAD_PORT,CODE_UNLOAD_PORT from con_image where container_no='" & container_No & "'  and ship_Id=" & Ship_ID, ds_oldbayno)
                                    If ds_oldbayno.Tables(0).Rows(0).Item("moved") = 0 Then '原贝位号是否为空OLDBAYNO
                                        If (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_load_port")) Like "*lyg*") Or (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_unload_port")) Like "*lyg*") Then
                                            '装货港和卸货港都不为连云港时，填充oldbayno
                                        Else
                                            ExecSql("UPDATE con_image set oldbayno=bayno,moved=1 where container_No='" & container_No & "'  and ship_Id=" & Ship_ID)
                                        End If
                                    End If
                                    '更新新贝位号
                                    ExecSql("UPDATE con_image set bayno='" & bayno_check & "' where container_No='" & container_No & "' and ship_Id=" & Ship_ID)
                                    '清空贝位号箱号
                                    bayno_check = ""
                                    container_No = ""
                                Else
                                    '箱尺寸大于20
                                    '判断此贝是否为通贝
                                    Getdata("select joint from con_bay where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and  bay_num='" & Mid(bayno_check, 1, 2) & "'", ds_bayno)
                                    If ds_bayno.Tables(0).Rows(0).Item(0) = 1 Then
                                        '通贝
                                        '判断原贝位号是否为空OLDBAYNO,填充此字段
                                        Getdata("select moved,oldbayno,CODE_LOAD_PORT,CODE_UNLOAD_PORT from con_image where container_no='" & container_No & "'  and ship_Id=" & Ship_ID, ds_oldbayno)
                                        If ds_oldbayno.Tables(0).Rows(0).Item("moved") = 0 Then '原贝位号是否为空OLDBAYNO
                                            If (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_load_port")) Like "*lyg*") Or (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_unload_port")) Like "*lyg*") Then
                                                '装货港和卸货港都不为连云港时，填充oldbayno
                                            Else
                                                ExecSql("UPDATE con_image set oldbayno=bayno,moved=1 where container_No='" & container_No & "'  and ship_Id=" & Ship_ID)
                                            End If
                                        End If
                                        '更新新贝位号
                                        If CType(Mid(bayno_check, 1, 2), Integer) + 1 < 10 Then
                                            bayno_check_joint = "0" & Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4) '5555555
                                        Else
                                            bayno_check_joint = Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4)
                                        End If
                                        '偶数bay
                                        If CType(Mid(bayno_check, 1, 2), Integer) Mod 2 = 0 Then
                                            bayno_check_joint = bayno_check
                                        End If
                                        ExecSql("UPDATE con_image set bayno='" & bayno_check_joint & "' where container_No='" & container_No & "' and ship_Id=" & Ship_ID)
                                        '清空贝位号箱号
                                        bayno_check = ""
                                        container_No = ""
                                    Else
                                        '不通贝
                                        MsgBox("非通贝，不能放大箱子，请查验！", MsgBoxStyle.OKOnly, "提示！")
                                        pl_third_refresh()
                                        Exit Sub
                                    End If
                                End If



                                'first panel

                                ' 判断是甲板还是舱内
                                If recty < distotop + rect_width * 11 Then
                                    '填充移动后BAY作在矩形的颜色
                                    bmpgraphics_bay_map.FillRectangle(bru_fill, 14 + (col_count_board_first) * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1, rect_width - 1, rect_width - 1)
                                    '填充移动后BAY作在矩形的卸货港
                                    bmpgraphics_bay_map.DrawString(unload_port, container_f, Brushes.DarkGray, 14 + col_count_board_first * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1)
                                Else
                                    '填充移动后BAY作在矩形的颜色
                                    bmpgraphics_bay_map.FillRectangle(bru_fill, 14 + (col_count_cabin_first) * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1, rect_width - 1, rect_width - 1)
                                    '填充移动后BAY作在矩形的卸货港
                                    bmpgraphics_bay_map.DrawString(unload_port, container_f, Brushes.DarkGray, 14 + col_count_cabin_first * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1)
                                End If


                                '判断是从哪里得来的箱号
                                If first_mark = 1 Then '本贝内移动
                                    first_mark = 0
                                    '填充移动前BAY作在矩形的颜色
                                    bmpgraphics_bay_map.FillRectangle(bru_sys, pl_first_point1x + 1, pl_first_point1y + 1, rect_width - 1, rect_width - 1)
                                    Me.Pl_bay_map.Refresh()
                                End If
                                If secend_mark = 1 Then
                                    secend_mark = 0
                                    '填充移动前BAY作在矩形的颜色
                                    bmpgraphics_secend.FillRectangle(bru_sys, pl_first_point1x + 1, pl_first_point1y + 1, rect_width - 1, rect_width - 1)
                                    Me.pl_secend.Refresh()
                                    fill_c1dbg_secend()
                                End If
                                If third_mark = 1 Then '中街
                                    show_third_pl()
                                    third_mark = 0
                                    fill_c1dbg_secend()
                                End If
                                Me.Pl_bay_map.Refresh()
                                fill_c1dbg()
                            End If
                        End If
                        '空白色结束
                    End If

                End If
                '处理单个箱子结束
            End If
        End If
    End Sub

    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        'first c1
        '排序，判断是否有重贝位的箱子 CONTAINER_NO,BAYNO
        Dim i As Integer
        Dim j As Integer
        For i = 0 To Me.ds_c1dbg.Tables(0).Rows.Count - 2
            For j = i + 1 To Me.ds_c1dbg.Tables(0).Rows.Count - 1
                If Me.ds_c1dbg.Tables(0).Rows(i).Item("BAYNO") = Me.ds_c1dbg.Tables(0).Rows(j).Item("BAYNO") Then
                    MsgBox("存在同贝位的箱子，贝位号为" & Me.ds_c1dbg.Tables(0).Rows(i).Item("BAYNO") & "，请查验", MsgBoxStyle.OKOnly, "提示")
                    Exit Sub
                End If
            Next
        Next
        For i = 0 To Me.ds_c1dbg_secend.Tables(0).Rows.Count - 2
            For j = i + 1 To Me.ds_c1dbg_secend.Tables(0).Rows.Count - 1
                If Me.ds_c1dbg_secend.Tables(0).Rows(i).Item("BAYNO") = Me.ds_c1dbg_secend.Tables(0).Rows(j).Item("BAYNO") Then
                    MsgBox("存在同贝位的箱子，贝位号为" & Me.ds_c1dbg_secend.Tables(0).Rows(i).Item("BAYNO") & "，请查验", MsgBoxStyle.OKOnly, "提示")
                    Exit Sub
                End If
            Next
        Next
        Try
            sqlda_c1dbg.Update(ds_c1dbg)
            Me.c1dbg.Refresh()
        Catch
        End Try

        'secend c1
        Try
            sqlda_c1dbg_secend.Update(ds_c1dbg_secend)
            Me.c1dbg_secend.Refresh()
        Catch
        End Try

        Try
            fill_c1dbg()
            show_bay_map_first(bmpgraphics_bay_map, Trim(Me.cmb_defined_bay.Text), big_col_first, small_col_first, big_col_cabin_first, small_col_cabin_first)
            Me.Pl_bay_map.Refresh()
        Catch
        End Try

        Try
            fill_c1dbg_secend()
            show_bay_map_second(bmpgraphics_secend, Trim(Me.cmb_secend.Text), big_col_second, small_col_second, big_col_cabin_second, small_col_cabin_second)
            Me.pl_secend.Refresh()
        Catch
        End Try
    End Sub

    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub



    Private Sub pl_secend_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pl_secend.MouseDown
        If e.Button = MouseButtons.Left Then
            '鼠标第一次单击开始
            color1 = bmp_bay_map_secend.GetPixel(e.X, e.Y)
            '计算甲板结果图的顶点位置
            If (big_col_cabin_second - small_col_cabin_second + 1) - (big_col_second - small_col_second + 1) >= 0 Then '比较甲板和舱内的列数
                col_count_board_second = (big_col_cabin_second - small_col_cabin_second + 1) - (big_col_second - small_col_second + 1) ''甲板上列数和舱内的差额
            Else
                col_count_board_second = 0
            End If
            '计算舱内结果图的顶点位置
            If (big_col_second - small_col_second + 1) - (big_col_cabin_second - small_col_cabin_second + 1) >= 0 Then
                col_count_cabin_second = (big_col_second - small_col_second + 1) - (big_col_cabin_second - small_col_cabin_second + 1) ''甲板上列数和舱内的差额
            Else
                col_count_cabin_second = 0
            End If

            ''处理块
            If Me.ckb_block.Checked = True Then
                If color1.ToArgb = Color.Blue.ToArgb Or color1.ToArgb = Color.DarkGray.ToArgb Then
                    '背景有色的情况开始
                    If secend_mark = 1 Then
                        '块操作开始
                        secend_mark = 0
                        block_second_mark = 1 '标志选种的块在second panel 上
                        bool_block = True
                        '计算矩形原点
                        block_secondpoint.Y = Fix(e.Y / rect_width) * rect_width   '  纵坐标
                        ' 横坐标
                        If block_secondpoint.Y < distotop + rect_width * 11 Then
                            mark = "board"
                            '在甲板上
                            block_secondpoint.X = Fix((e.X - 14 - col_count_board_second * rect_width_half) / rect_width)
                            '平行
                            j_col = Fix(block_secondpoint.X) + 1
                            block_secondpoint.X = 14 + col_count_board_second * rect_width_half + (block_secondpoint.X) * rect_width
                            '平列
                            i_row = Fix((distotop + rect_width * 10 - block_secondpoint.Y) / rect_width) + small_row_second - 1
                        Else
                            mark = "cabin"
                            '在舱内
                            block_secondpoint.X = Fix((e.X - 14 - col_count_cabin_second * rect_width_half) / rect_width)
                            '平行
                            j_col = Fix(block_secondpoint.X) + 1
                            block_secondpoint.X = 14 + col_count_cabin_second * rect_width_half + (block_secondpoint.X) * rect_width
                            '平列
                            i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_second - small_row_cabin_second + 1) * rect_width) - block_secondpoint.Y) / rect_width) + small_row_cabin_second - 1
                        End If
                        block_row = (block_secondpoint.Y - pl_first_point1y) / rect_width + 1 '块的行数
                        block_col = (block_secondpoint.X - pl_first_point1x) / rect_width + 1 '块的列数
                        '判断块是否有效
                        For i_block = 0 To block_row - 1
                            For j_block = 0 To block_col - 1
                                If bmp_bay_map_secend.GetPixel(pl_first_point1x + j_block * rect_width + 2, pl_first_point1y + i_block * rect_width + 2).ToArgb <> Color.Blue.ToArgb And bmp_bay_map_secend.GetPixel(pl_first_point1x + i_block * rect_width + 2, pl_first_point1y + j_block * rect_width + 2).ToArgb <> Color.DarkGray.ToArgb Then
                                    block_second_mark = 0 '标志选种的块在second panel 上
                                    bool_block = False
                                End If
                            Next
                        Next
                        '处理有效块
                        If bool_block = True Then
                            For i_block = 0 To block_row - 1
                                For j_block = 0 To block_col - 1
                                    '填充有效块
                                    bmpgraphics_secend.FillRectangle(bru_selected, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                    '记下块的每个箱号和卸货港
                                    p.X = pl_first_point1x + j_block * rect_width
                                    p.Y = pl_first_point1y + i_block * rect_width
                                    recty = p.Y / rect_width
                                    recty = Fix(recty) * rect_width
                                    If recty < distotop + rect_width * 11 Then
                                        rectx = (p.X - 14 - col_count_board_second * rect_width_half) / rect_width
                                        mark = "board"
                                        i_row = Fix((distotop + rect_width * 10 - recty) / rect_width) + small_row_second - 1
                                        j_col = Fix(rectx) + 1
                                    Else
                                        rectx = (p.X - 14 - col_count_cabin_second * rect_width_half) / rect_width ' 
                                        mark = "cabin"
                                        i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_second - small_row_cabin_second + 1) * rect_width) - recty) / rect_width) + small_row_cabin_second - 1
                                        j_col = Fix(rectx) + 1
                                    End If
                                    If Getdata("select bay_num + bay_col + bay_row from con_map where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and location='" & mark & "' and bay_num='" & Trim(Me.cmb_secend.Text) & "'and screen_col='" & j_col & "' and screen_row='" & i_row & "'", ds_bayno).Count > 0 Then
                                        bayno_check = ds_bayno.Tables(0).Rows(0).Item(0)
                                        ''''''找数据库中是否存在通贝的箱子
                                        If CType(Mid(bayno_check, 1, 2), Integer) + 1 < 10 Then
                                            bayno_check_joint = "0" & Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 5)
                                        Else
                                            bayno_check_joint = Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4)
                                        End If
                                        If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT from con_image where  (con_image.BAYNO='" & bayno_check & "' or con_image.BAYNO='" & bayno_check_joint & "') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                            '箱号
                                            arrblock(i_block, j_block) = ds_container.Tables(0).Rows(0).Item("container_no")
                                            '卸货港首字母
                                            arrblock_unload_port(i_block, j_block) = ds_container.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
                                        End If
                                    End If
                                Next
                            Next
                            Me.pl_secend.Refresh()
                        End If
                    Else
                        'second_mark=0的情况
                        btn_count = 1 '鼠标第一次有效单机
                        first_mark = 0 '在first panel上单季无效
                        secend_mark = 1 '在secend panel上的有效单季
                        third_mark = 0 '在third panel上的淡季无效
                        p.X = e.X
                        p.Y = e.Y
                        recty = p.Y / rect_width
                        recty = Fix(recty) * rect_width
                        If recty < distotop + rect_width * 11 Then
                            rectx = (p.X - 14 - col_count_board_second * rect_width_half) / rect_width
                            mark = "board"
                            i_row = Fix((distotop + rect_width * 10 - recty) / rect_width) + small_row_second - 1
                            j_col = Fix(rectx) + 1
                            ' 横坐标
                            pl_first_point1x = 14 + col_count_board_second * rect_width_half + (j_col - 1) * rect_width
                        Else
                            rectx = (p.X - 14 - col_count_cabin_second * rect_width_half) / rect_width ' 
                            mark = "cabin"
                            i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_second - small_row_cabin_second + 1) * rect_width) - recty) / rect_width) + small_row_cabin_second - 1
                            j_col = Fix(rectx) + 1
                            ' 横坐标
                            pl_first_point1x = 14 + col_count_cabin_second * rect_width_half + (j_col - 1) * rect_width
                        End If
                        '记下点所属的矩形的横纵坐标
                        '  纵坐标
                        pl_first_point1y = recty
                        If Getdata("select bay_num + bay_col + bay_row from con_map where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and location='" & mark & "' and bay_num='" & Trim(Me.cmb_secend.Text) & "'and screen_col='" & j_col & "' and screen_row='" & i_row & "'", ds_bayno).Count > 0 Then
                            bayno_check = ds_bayno.Tables(0).Rows(0).Item(0)
                            ''''''找数据库中是否存在通贝的箱子
                            If CType(Mid(bayno_check, 1, 2), Integer) + 1 < 10 Then
                                bayno_check_joint = "0" & Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 5)
                            Else
                                bayno_check_joint = Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4)
                            End If
                            If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT from con_image where  (con_image.BAYNO='" & bayno_check & "' or con_image.BAYNO='" & bayno_check_joint & "') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                '箱号
                                container_No = ds_container.Tables(0).Rows(0).Item("container_no")
                                Me.txt_container_no.Text = ds_container.Tables(0).Rows(0).Item("container_no")
                                '卸货港首字母
                                unload_port = ds_container.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
                            End If
                        End If
                    End If
                    '背景有色的情况结束
                Else
                    '背景色为空的情况
                    If color1.ToArgb <> Color.Blue.ToArgb And color1.ToArgb <> Color.DarkGray.ToArgb And color1.ToArgb <> Color.Green.ToArgb Then
                        If bool_block = True Then
                            bool_block = False

                            '处理选择好的块,记下第三点的坐标
                            p.X = e.X
                            p.Y = e.Y
                            recty = p.Y / rect_width
                            recty = Fix(recty) * rect_width
                            If recty < distotop + rect_width * 11 Then
                                rectx = (p.X - 14 - col_count_board_second * rect_width_half) / rect_width
                                mark = "board"
                                i_row = Fix((distotop + rect_width * 10 - recty) / rect_width) + small_row_second - 1
                                j_col = Fix(rectx) + 1
                                ' 块的第三点的横坐标
                                block_third_pointx = 14 + col_count_board_second * rect_width_half + (j_col - 1) * rect_width
                            Else
                                rectx = (p.X - 14 - col_count_cabin_second * rect_width_half) / rect_width ' 
                                mark = "cabin"
                                i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_second - small_row_cabin_second + 1) * rect_width) - recty) / rect_width) + small_row_cabin_second - 1
                                j_col = Fix(rectx) + 1
                                ' 块的第三点的横坐标
                                block_third_pointx = 14 + col_count_cabin_second * rect_width_half + (j_col - 1) * rect_width
                            End If
                            '块的第三点的 纵坐标
                            block_third_pointy = recty
                            '查看是否有足够的空间放选择好的块
                            bool_block_second = True
                            For i_block = 0 To block_row - 1
                                If bool_block_second = False Then
                                    Exit For
                                End If
                                For j_block = 0 To block_col - 1
                                    ''判断选种的箱子有没有大箱
                                    '’如果有大箱，要判断此贝是否通贝
                                    Getdata("select size_con from CON_CRITERION,con_image where CON_CRITERION.container_No=con_image.container_no and con_image.ship_id='" & Ship_ID & "' and CON_CRITERION.container_No='" & arrblock(i_block, j_block) & "'", ds_size_con)
                                    If ds_size_con.Tables(0).Rows(0).Item(0) > 20 Then
                                        '箱尺寸大于20
                                        '判断此贝是否为通贝
                                        Getdata("select joint from con_bay where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and  bay_num='" & Trim(Me.cmb_secend.Text) & "'", ds_bayno)
                                        If ds_bayno.Tables(0).Rows(0).Item(0) = 0 Then
                                            bool_block_second = False
                                            MsgBox("箱号为'" & arrblock(i_block, j_block) & "'的箱子是大箱，此贝非通贝，不能放，请查验！", MsgBoxStyle.OKOnly, "提示")
                                            pl_third_refresh()
                                            Exit For
                                        End If
                                    End If
                                    'If recty < distotop + rect_width * 11 Then
                                    '    '查看甲板横坐标是否满足
                                    '    If block_third_pointx + j_block * rect_width > rect_width * (big_col - small_col + 1) Then
                                    '        bool_block_second = False
                                    '        Exit For
                                    '    End If
                                    '    '查看甲板纵坐标是否满足
                                    '    If block_third_pointy + i_block * rect_width < rect_width * 10 - (big_row - small_row + 1) * rect_width Or block_third_pointy + i_block * rect_width > rect_width * 10 Then
                                    '        bool_block_second = False
                                    '        Exit For
                                    '    End If
                                    'Else
                                    '    '查看藏内横坐标是否满足
                                    '    If block_third_pointx + j_block * rect_width > rect_width * (big_col_cabin - small_col_cabin + 1) Then
                                    '        bool_block_second = False
                                    '        Exit For
                                    '    End If
                                    '    '查看藏内纵坐标是否满足
                                    '    If block_third_pointy + i_block * rect_width > rect_width * 11 + (big_row_cabin - small_row_cabin + 1) * rect_width Or block_third_pointy + i_block * rect_width < rect_width * 11 Then
                                    '        bool_block_second = False
                                    '        Exit For
                                    '    End If
                                    'End If

                                    If bmp_bay_map_secend.GetPixel(block_third_pointx + j_block * rect_width + 2, block_third_pointy + i_block * rect_width + 2).ToArgb = Color.Blue.ToArgb Or bmp_bay_map_secend.GetPixel(block_third_pointx + i_block * rect_width + 2, block_third_pointy + j_block * rect_width + 2).ToArgb = Color.DarkGray.ToArgb Then
                                        bool_block_second = False
                                        MsgBox("没有足够的贝位号放置已选择的块，请检验！", MsgBoxStyle.OKOnly, "提示！")
                                        pl_third_refresh()
                                        Exit For
                                    End If
                                Next
                            Next

                            If bool_block_second = True Then
                                '存在足够的空间放置选择好的块
                                For i_block = 0 To block_row - 1
                                    For j_block = 0 To block_col - 1
                                        p.X = block_third_pointx + j_block * rect_width
                                        p.Y = block_third_pointy + i_block * rect_width
                                        recty = p.Y / rect_width
                                        recty = Fix(recty) * rect_width
                                        If recty < distotop + rect_width * 11 Then
                                            rectx = (p.X - 14 - col_count_board_second * rect_width_half) / rect_width
                                            mark = "board"
                                            i_row = Fix((distotop + rect_width * 10 - recty) / rect_width) + small_row_second - 1
                                            j_col = Fix(rectx) + 1
                                        Else
                                            rectx = (p.X - 14 - col_count_cabin_second * rect_width_half) / rect_width ' 
                                            mark = "cabin"
                                            i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_second - small_row_cabin_second + 1) * rect_width) - recty) / rect_width) + small_row_cabin_second - 1
                                            j_col = Fix(rectx) + 1
                                        End If
                                        If Getdata("select bay_num + bay_col + bay_row from con_map where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and location='" & mark & "' and bay_num='" & Trim(Me.cmb_secend.Text) & "'and screen_col='" & j_col & "' and screen_row='" & i_row & "' and user_char=1", ds_bayno).Count > 0 Then
                                            bayno_check = ds_bayno.Tables(0).Rows(0).Item(0)
                                            ''''取出箱子的尺寸判断是否属于大箱
                                            Getdata("select size_con from CON_CRITERION,con_image where CON_CRITERION.container_No=con_image.container_no and con_image.ship_id='" & Ship_ID & "' and CON_CRITERION.container_No='" & arrblock(i_block, j_block) & "'", ds_size_con)
                                            If ds_size_con.Tables(0).Rows(0).Item(0) <= 20 Then
                                                ''箱尺寸小于20
                                                '判断原贝位号是否为空OLDBAYNO,填充此字段
                                                Getdata("select moved,oldbayno,CODE_LOAD_PORT,CODE_UNLOAD_PORT from con_image where container_no='" & arrblock(i_block, j_block) & "'  and ship_Id=" & Ship_ID, ds_oldbayno)
                                                If ds_oldbayno.Tables(0).Rows(0).Item("moved") = 0 Then '原贝位号是否为空OLDBAYNO
                                                    If (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_load_port")) Like "*lyg*") Or (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_unload_port")) Like "*lyg*") Then
                                                        '装货港和卸货港都不为连云港时，填充oldbayno
                                                    Else
                                                        ExecSql("UPDATE con_image set oldbayno=bayno,moved=1 where container_No='" & arrblock(i_block, j_block) & "'  and ship_Id=" & Ship_ID)
                                                    End If
                                                End If
                                                '更新新贝位号
                                                ExecSql("UPDATE con_image set bayno='" & bayno_check & "' where container_No='" & arrblock(i_block, j_block) & "' and ship_Id=" & Ship_ID)
                                                '清空贝位号箱号
                                                bayno_check = ""
                                                container_No = ""
                                            Else
                                                '箱尺寸大于20
                                                '判断此贝是否为通贝
                                                Getdata("select joint from con_bay where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and  bay_num='" & Mid(bayno_check, 1, 2) & "'", ds_bayno)
                                                If ds_bayno.Tables(0).Rows(0).Item(0) = 1 Then
                                                    '通贝
                                                    '判断原贝位号是否为空OLDBAYNO,填充此字段
                                                    Getdata("select moved,oldbayno,CODE_LOAD_PORT,CODE_UNLOAD_PORT from con_image where container_no='" & arrblock(i_block, j_block) & "'  and ship_Id=" & Ship_ID, ds_oldbayno)
                                                    If ds_oldbayno.Tables(0).Rows(0).Item("moved") = 0 Then '原贝位号是否为空OLDBAYNO
                                                        If (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_load_port")) Like "*lyg*") Or (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_unload_port")) Like "*lyg*") Then
                                                            '装货港和卸货港都不为连云港时，填充oldbayno
                                                        Else
                                                            ExecSql("UPDATE con_image set oldbayno=bayno,moved=1 where container_No='" & arrblock(i_block, j_block) & "'  and ship_Id=" & Ship_ID)
                                                        End If
                                                    End If
                                                    '更新新贝位号
                                                    If CType(Mid(bayno_check, 1, 2), Integer) + 1 < 10 Then
                                                        bayno_check_joint = "0" & Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4) '555555
                                                    Else
                                                        bayno_check_joint = Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4)
                                                    End If
                                                    '偶数bay
                                                    If CType(Mid(bayno_check, 1, 2), Integer) Mod 2 = 0 Then
                                                        bayno_check_joint = bayno_check
                                                    End If
                                                    ExecSql("UPDATE con_image set bayno='" & bayno_check_joint & "' where container_No='" & arrblock(i_block, j_block) & "' and ship_Id=" & Ship_ID)
                                                    '清空贝位号箱号
                                                    bayno_check = ""
                                                    container_No = ""
                                                Else
                                                    '不通贝
                                                    MsgBox("非通贝，不能放大箱子，请查验！", MsgBoxStyle.OKOnly, "提示！")
                                                    pl_third_refresh()
                                                    Exit Sub
                                                End If
                                            End If

                                            ''判断原贝位号是否为空OLDBAYNO,填充此字段
                                            'Getdata("select oldbayno,CODE_LOAD_PORT,CODE_UNLOAD_PORT from con_image where container_no='" & arrblock(i_block, j_block) & "' and ship_Id=" & Ship_ID, ds_oldbayno)
                                            'If ds_oldbayno.Tables(0).Rows(0).Item("oldbayno") Is System.DBNull.Value Then '原贝位号是否为空OLDBAYNO
                                            '    If (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_load_port")) Like "*lyg*") Or (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_unload_port")) Like "*lyg*") Then
                                            '        '装货港和卸货港都不为连云港时，填充oldbayno
                                            '    Else
                                            '        ExecSql("UPDATE con_image set oldbayno=bayno where container_No='" & arrblock(i_block, j_block) & "' and ship_Id=" & Ship_ID)
                                            '    End If
                                            'End If

                                            '''更新箱子的新贝位号
                                            'ExecSql("UPDATE con_image set bayno='" & bayno_check & "' where container_No='" & arrblock(i_block, j_block) & "' and ship_Id=" & Ship_ID)
                                            '' 判断是甲板还是舱内
                                            If recty < distotop + rect_width * 11 Then
                                                '填充移动后BAY作在矩形的颜色
                                                bmpgraphics_secend.FillRectangle(bru_fill, 14 + (col_count_board_second) * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1, rect_width - 1, rect_width - 1)
                                                '填充移动后BAY作在矩形的卸货港
                                                bmpgraphics_secend.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, 14 + col_count_board_second * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1)
                                            Else
                                                '填充移动后BAY作在矩形的颜色
                                                bmpgraphics_secend.FillRectangle(bru_fill, 14 + (col_count_cabin_second) * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1, rect_width - 1, rect_width - 1)
                                                '填充移动后BAY作在矩形的卸货港
                                                bmpgraphics_secend.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, 14 + col_count_cabin_second * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1)
                                            End If


                                            '判断是从哪里得来的箱号
                                            If block_second_mark = 1 Then '本贝内移动
                                                '填充移动前BAY作在矩形的颜色
                                                bmpgraphics_secend.FillRectangle(bru_sys, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            End If
                                            If block_first_mark = 1 Then
                                                '填充移动前BAY作在矩形的颜色
                                                bmpgraphics_bay_map.FillRectangle(bru_sys, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            End If
                                            If block_third_mark = 1 Then
                                                '填充移动前BAY作在矩形的颜色
                                                bmpgraphics_third.FillRectangle(bru_sys, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            End If
                                        End If
                                    Next
                                Next
                                If block_first_mark = 1 Then
                                    block_first_mark = 0
                                    Me.Pl_bay_map.Refresh()

                                End If
                                If block_third_mark = 1 Then
                                    block_third_mark = 0
                                    Me.pl_third.Refresh()
                                End If
                                '刷新second panel
                                block_second_mark = 0
                                Me.pl_secend.Refresh()
                                fill_c1dbg()
                                fill_c1dbg_secend()
                            Else
                                '恢复已选种的有效块
                                For i_block = 0 To block_row - 1
                                    For j_block = 0 To block_col - 1
                                        '没有足够的空间放置选择好的块
                                        '判断是从哪里得来的箱号
                                        If block_first_mark = 1 Then '本贝内移动
                                            '恢复有效块
                                            bmpgraphics_bay_map.FillRectangle(bru_fill, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            '恢复卸货港
                                            bmpgraphics_bay_map.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1)
                                        End If
                                        If block_second_mark = 1 Then '本贝内移动
                                            '恢复有效块
                                            bmpgraphics_secend.FillRectangle(bru_fill, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            '恢复卸货港
                                            bmpgraphics_secend.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1)
                                        End If
                                        If block_third_mark = 1 Then
                                            '恢复有效块
                                            bmpgraphics_third.FillRectangle(bru_fill, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            '恢复卸货港
                                            bmpgraphics_third.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1)
                                        End If
                                    Next
                                Next
                                If block_first_mark = 1 Then
                                    block_first_mark = 0
                                    Me.Pl_bay_map.Refresh()
                                End If
                                If block_second_mark = 1 Then
                                    block_second_mark = 0
                                    '  Me.pl_secend.Refresh()
                                End If
                                If block_third_mark = 1 Then
                                    Me.pl_third.Refresh()
                                End If
                                fill_c1dbg()
                                fill_c1dbg_secend()
                                Me.pl_secend.Refresh()
                            End If
                        End If
                        '背景色为空的情况结束
                    End If
                End If
            End If
            ''处理块结束

            ''处理单个箱子
            If Me.ckb_block.Checked = False Then
                If color1.ToArgb = Color.Blue.ToArgb Or color1.ToArgb = Color.DarkGray.ToArgb Then
                    btn_count = 1
                    first_mark = 0 '在first panel上有效单季
                    secend_mark = 1 '在secend panel上的单季无效
                    third_mark = 0 '在third panel上的淡季有效
                    p.X = e.X
                    p.Y = e.Y
                    recty = p.Y / rect_width
                    recty = Fix(recty) * rect_width
                    If recty < distotop + rect_width * 11 Then
                        rectx = (p.X - 14 - col_count_board_second * rect_width_half) / rect_width
                        mark = "board"
                        i_row = Fix((distotop + rect_width * 10 - recty) / rect_width) + small_row_second - 1
                        j_col = Fix(rectx) + 1
                        ' 横坐标
                        pl_first_point1x = 14 + col_count_board_second * rect_width_half + (j_col - 1) * rect_width
                    Else
                        rectx = (p.X - 14 - col_count_cabin_second * rect_width_half) / rect_width ' 
                        mark = "cabin"
                        i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_second - small_row_cabin_second + 1) * rect_width) - recty) / rect_width) + small_row_cabin_second - 1
                        j_col = Fix(rectx) + 1
                        ' 横坐标
                        pl_first_point1x = 14 + col_count_cabin_second * rect_width_half + (j_col - 1) * rect_width
                    End If
                    '记下点所属的矩形的横纵坐标
                    '  纵坐标
                    pl_first_point1y = recty

                    '填充矩形
                    'bmpgraphics_secend.FillRectangle(bru_selected, pl_first_point1x + 1, pl_first_point1y + 1, rect_width - 1, rect_width - 1)
                    'Me.pl_secend.Refresh()

                    bayno_check = "select bay_num + bay_col + bay_row from con_map where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and location='" & mark & "' and bay_num='" & Trim(Me.cmb_secend.Text) & "'and screen_col='" & j_col & "' and screen_row='" & i_row & "'"
                    If Getdata(bayno_check, ds_bayno).Count > 0 Then
                        bayno_check = ds_bayno.Tables(0).Rows(0).Item(0)
                        ''''''找数据库中是否存在通贝的箱子
                        If CType(Mid(bayno_check, 1, 2), Integer) + 1 < 10 Then
                            bayno_check_joint = "0" & Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 5)
                        Else
                            bayno_check_joint = Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4)
                        End If

                        If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT from con_image where ( con_image.BAYNO='" & bayno_check & "' or con_image.BAYNO='" & bayno_check_joint & "' ) and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            '箱号
                            container_No = ds_container.Tables(0).Rows(0).Item("container_no")
                            Me.txt_container_no.Text = ds_container.Tables(0).Rows(0).Item("container_no")
                            '卸货港首字母
                            unload_port = ds_container.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
                        End If
                    End If
                Else
                    '空白色
                    If color1.ToArgb = Me.BackColor.ToArgb Then
                        If btn_count Mod 2 = 1 Then
                            btn_count = 0
                            '鼠标第二次单击
                            p.X = e.X
                            p.Y = e.Y
                            recty = p.Y / rect_width
                            recty = Fix(recty) * rect_width
                            If recty < distotop + rect_width * 11 Then
                                rectx = (p.X - 14 - col_count_board_second * rect_width_half) / rect_width
                                mark = "board"
                                i_row = Fix((distotop + rect_width * 10 - recty) / rect_width) + small_row_second - 1
                                j_col = Fix(rectx) + 1
                            Else
                                rectx = (p.X - 14 - col_count_cabin_second * rect_width_half) / rect_width ' 
                                mark = "cabin"
                                i_row = Fix(((distotop + rect_width * 11 + (big_row_cabin_second - small_row_cabin_second + 1) * rect_width) - recty) / rect_width) + small_row_cabin_second - 1
                                j_col = Fix(rectx) + 1
                            End If
                            bayno_check = "select bay_num + bay_col + bay_row from con_map where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and location='" & mark & "' and bay_num='" & Trim(Me.cmb_secend.Text) & "'and screen_col='" & j_col & "' and screen_row='" & i_row & "' and user_char=1"
                            If Getdata(bayno_check, ds_bayno).Count > 0 Then
                                bayno_check = ds_bayno.Tables(0).Rows(0).Item(0)

                                ''''取出箱子的尺寸判断是否属于大箱
                                Getdata("select size_con from CON_CRITERION,con_image where CON_CRITERION.container_No=con_image.container_no and con_image.ship_id='" & Ship_ID & "' and CON_CRITERION.container_No='" & container_No & "'", ds_size_con)
                                If ds_size_con.Tables(0).Rows(0).Item(0) <= 20 Then
                                    ''箱尺寸小于20
                                    '判断原贝位号是否为空OLDBAYNO,填充此字段
                                    Getdata("select moved,oldbayno,CODE_LOAD_PORT,CODE_UNLOAD_PORT from con_image where container_no='" & container_No & "'  and ship_Id=" & Ship_ID, ds_oldbayno)
                                    If ds_oldbayno.Tables(0).Rows(0).Item("moved") = 0 Then '原贝位号是否为空OLDBAYNO
                                        If (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_load_port")) Like "*lyg*") Or (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_unload_port")) Like "*lyg*") Then
                                            '装货港和卸货港都不为连云港时，填充oldbayno
                                        Else
                                            ExecSql("UPDATE con_image set oldbayno=bayno,moved=1 where container_No='" & container_No & "'  and ship_Id=" & Ship_ID)
                                        End If
                                    End If
                                    '更新新贝位号
                                    ExecSql("UPDATE con_image set bayno='" & bayno_check & "' where container_No='" & container_No & "' and ship_Id=" & Ship_ID)
                                    '清空贝位号箱号
                                    bayno_check = ""
                                    container_No = ""
                                Else
                                    '箱尺寸大于20
                                    '判断此贝是否为通贝
                                    Getdata("select joint from con_bay where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and  bay_num='" & Mid(bayno_check, 1, 2) & "'", ds_bayno)
                                    If ds_bayno.Tables(0).Rows(0).Item(0) = 1 Then
                                        '通贝
                                        '判断原贝位号是否为空OLDBAYNO,填充此字段
                                        Getdata("select moved,oldbayno,CODE_LOAD_PORT,CODE_UNLOAD_PORT from con_image where container_no='" & container_No & "'  and ship_Id=" & Ship_ID, ds_oldbayno)
                                        If ds_oldbayno.Tables(0).Rows(0).Item("moved") = 0 Then '原贝位号是否为空OLDBAYNO
                                            If (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_load_port")) Like "*lyg*") Or (LCase(ds_oldbayno.Tables(0).Rows(0).Item("code_unload_port")) Like "*lyg*") Then
                                                '装货港和卸货港都不为连云港时，填充oldbayno
                                            Else
                                                ExecSql("UPDATE con_image set oldbayno=bayno,moved=1 where container_No='" & container_No & "'  and ship_Id=" & Ship_ID)
                                            End If
                                        End If
                                        '更新新贝位号
                                        If CType(Mid(bayno_check, 1, 2), Integer) + 1 < 10 Then
                                            bayno_check_joint = "0" & Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4) '55555
                                        Else
                                            bayno_check_joint = Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4)
                                        End If
                                        '偶数bay
                                        If CType(Mid(bayno_check, 1, 2), Integer) Mod 2 = 0 Then
                                            bayno_check_joint = bayno_check
                                        End If
                                        ExecSql("UPDATE con_image set bayno='" & bayno_check_joint & "' where container_No='" & container_No & "' and ship_Id=" & Ship_ID)
                                        '清空贝位号箱号
                                        bayno_check = ""
                                        container_No = ""
                                    Else
                                        '不通贝
                                        MsgBox("非通贝，不能放大箱子，请查验！", MsgBoxStyle.OKOnly, "提示！")
                                        pl_third_refresh()
                                        Exit Sub
                                    End If
                                End If


                                'second panel

                                ' 判断是甲板还是舱内
                                If recty < distotop + rect_width * 11 Then
                                    '填充移动后BAY作在矩形的颜色
                                    bmpgraphics_secend.FillRectangle(bru_fill, 14 + (col_count_board_second) * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1, rect_width - 1, rect_width - 1)
                                    '填充移动后BAY作在矩形的卸货港
                                    bmpgraphics_secend.DrawString(unload_port, container_f, Brushes.DarkGray, 14 + col_count_board_second * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1)
                                Else
                                    '填充移动后BAY作在矩形的颜色
                                    bmpgraphics_secend.FillRectangle(bru_fill, 14 + (col_count_cabin_second) * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1, rect_width - 1, rect_width - 1)
                                    '填充移动后BAY作在矩形的卸货港
                                    bmpgraphics_secend.DrawString(unload_port, container_f, Brushes.DarkGray, 14 + col_count_cabin_second * rect_width_half + (j_col - 1) * rect_width + 1, recty + 1)
                                End If

                                If first_mark = 1 Then
                                    first_mark = 0
                                    '填充移动前BAY作在矩形的颜色
                                    bmpgraphics_bay_map.FillRectangle(bru_sys, pl_first_point1x + 1, pl_first_point1y + 1, rect_width - 1, rect_width - 1)
                                    Me.Pl_bay_map.Refresh()
                                    fill_c1dbg()
                                End If
                                If secend_mark = 1 Then
                                    secend_mark = 0
                                    '填充移动前BAY作在矩形的颜色
                                    bmpgraphics_secend.FillRectangle(bru_sys, pl_first_point1x + 1, pl_first_point1y + 1, rect_width - 1, rect_width - 1)
                                End If
                                If third_mark = 1 Then '中街
                                    show_third_pl()
                                    third_mark = 0
                                    fill_c1dbg()
                                End If

                                Me.pl_secend.Refresh()
                                fill_c1dbg_secend()
                            End If
                        End If
                        '空白色
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub pl_third_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pl_third.MouseDown
        If e.Button = MouseButtons.Left Then
            '鼠标第一次单击开始
            color1 = bmp_bay_map_third.GetPixel(e.X, e.Y)
            ''处理块
            If Me.ckb_block.Checked = True Then
                If color1.ToArgb = Color.Blue.ToArgb Or color1.ToArgb = Color.DarkGray.ToArgb Then
                    '背景有色的情况开始
                    If third_mark = 1 Then
                        '块操作开始
                        third_mark = 0
                        block_third_mark = 1 '标志选种的块在third panel 上
                        bool_block = True

                        'arr_col = Fix((e.X - distoleft_third) / rect_width) '屏幕中的列数
                        'arr_row = Fix(e.Y / rect_width) '屏幕中的行数

                        block_row = Fix((e.Y - pl_first_point1y) / rect_width) + 1 '块的行数
                        block_col = Fix((e.X - pl_first_point1x) / rect_width) + 1 '块的列数
                        '判断块是否有效
                        For i_block = 0 To block_row - 1
                            For j_block = 0 To block_col - 1
                                If bmp_bay_map_third.GetPixel(pl_first_point1x + j_block * rect_width + 2, pl_first_point1y + i_block * rect_width + 2).ToArgb <> Color.Blue.ToArgb And bmp_bay_map_third.GetPixel(pl_first_point1x + j_block * rect_width + 2, pl_first_point1y + i_block * rect_width + 2).ToArgb <> Color.DarkGray.ToArgb Then
                                    bool_block = False
                                    Exit For
                                End If
                            Next
                        Next
                        '处理有效块
                        If bool_block = True Then
                            For i_block = 0 To block_row - 1
                                For j_block = 0 To block_col - 1
                                    '填充有效块
                                    bmpgraphics_third.FillRectangle(bru_selected, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                    '填充卸货港
                                    bmpgraphics_third.DrawString(arrunload_port(arr_row + i_block, arr_col + j_block), container_f, Brushes.DarkGray, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1)
                                    '记下块的每个箱号和卸货港
                                    '箱号
                                    arrblock(i_block, j_block) = arrthird(arr_row + i_block, arr_col + j_block)
                                    '卸货港首字母
                                    arrblock_unload_port(i_block, j_block) = arrunload_port(arr_row + i_block, arr_col + j_block)
                                Next
                            Next
                            Me.pl_third.Refresh()
                        End If
                    Else
                        'third_mark=0的情况
                        btn_count = 1 '鼠标第一次有效单机
                        first_mark = 0 '在first panel上单季无效
                        secend_mark = 0 '在secend panel上的淡季无效
                        third_mark = 1 '在third panel上的有效单季
                        '计算在数组中的位置
                        arr_col = Fix((e.X - distoleft_third) / rect_width) '屏幕中的列数-1
                        arr_row = Fix(e.Y / rect_width) '屏幕中的行数-1
                        pl_third_point1x = arr_col
                        pl_third_point1y = arr_row
                        ' 横坐标
                        pl_first_point1x = distoleft_third + arr_col * rect_width
                        '  纵坐标
                        pl_first_point1y = arr_row * rect_width
                        '箱号
                        container_No = arrthird(arr_row, arr_col)
                        Me.txt_container_no.Text = arrthird(arr_row, arr_col)
                        '卸货港首字母
                        unload_port = arrunload_port(arr_row, arr_col)
                    End If
                    '背景有色的情况结束
                Else
                    '背景色为空的情况
                    If color1.ToArgb <> Color.Blue.ToArgb And color1.ToArgb <> Color.DarkGray.ToArgb And color1.ToArgb <> Color.Green.ToArgb Then
                        If bool_block = True Then
                            bool_block = False
                            '计算在数组中的位置
                            arr_col = Fix((e.X - distoleft_third) / rect_width) '屏幕中的列数-1
                            arr_row = Fix(e.Y / rect_width) '屏幕中的行数-1
                            '处理选择好的块,记下第三点的坐标
                            ' 块的第三点的横坐标
                            block_third_pointx = distoleft_third + Fix((e.X - distoleft_third) / rect_width) * rect_width
                            '块的第三点的 纵坐标
                            block_third_pointy = Fix(e.Y / rect_width) * rect_width

                            '查看是否有足够的空间放选择好的块
                            bool_block_second = True
                            For i_block = 0 To block_row - 1
                                For j_block = 0 To block_col - 1
                                    If bmp_bay_map_third.GetPixel(block_third_pointx + j_block * rect_width + 2, block_third_pointy + i_block * rect_width + 2).ToArgb = Color.Blue.ToArgb Or bmp_bay_map_secend.GetPixel(block_third_pointx + i_block * rect_width + 2, block_third_pointy + j_block * rect_width + 2).ToArgb = Color.DarkGray.ToArgb Then
                                        bool_block_second = False
                                        Exit For
                                    End If
                                Next
                            Next

                            If bool_block_second = True Then
                                '存在足够的空间放置选择好的块
                                For i_block = 0 To block_row - 1
                                    For j_block = 0 To block_col - 1
                                        p.X = block_third_pointx + j_block * rect_width
                                        p.Y = block_third_pointy + i_block * rect_width
                                        recty = p.Y / rect_width
                                        recty = Fix(recty) * rect_width
                                        '记下块的每个箱号和卸货港
                                        '箱号
                                        arrthird(arr_row + i_block, arr_col + j_block) = arrblock(i_block, j_block)
                                        '卸货港首字母
                                        arrunload_port(arr_row + i_block, arr_col + j_block) = arrblock_unload_port(i_block, j_block)
                                        '填充移动后BAY作在矩形的颜色
                                        bmpgraphics_third.FillRectangle(bru_fill, block_third_pointx + j_block * rect_width + 1, block_third_pointy + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                        '填充移动后BAY作在矩形的卸货港
                                        bmpgraphics_third.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, block_third_pointx + j_block * rect_width, block_third_pointy + i_block * rect_width)

                                        '判断是从哪里得来的箱号
                                        If block_second_mark = 1 Then '本贝内移动
                                            '填充移动前BAY作在矩形的颜色
                                            bmpgraphics_secend.FillRectangle(bru_sys, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                        End If
                                        If block_first_mark = 1 Then
                                            '填充移动前BAY作在矩形的颜色
                                            bmpgraphics_bay_map.FillRectangle(bru_sys, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                        End If
                                        If block_third_mark = 1 Then
                                            '填充移动前BAY作在矩形的颜色
                                            bmpgraphics_third.FillRectangle(bru_sys, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                        End If
                                    Next
                                Next
                                If block_first_mark = 1 Then
                                    block_first_mark = 0
                                    Me.Pl_bay_map.Refresh()
                                    fill_c1dbg()
                                End If
                                '刷新second panel
                                If block_second_mark = 1 Then
                                    block_second_mark = 0
                                    Me.pl_secend.Refresh()
                                    fill_c1dbg_secend()
                                End If
                                '刷新third panel
                                block_third_mark = 0
                                Me.pl_third.Refresh()
                            Else
                                '没有足够的空间放置选择好的块
                                '恢复已选种的有效块
                                For i_block = 0 To block_row - 1
                                    For j_block = 0 To block_col - 1
                                        If block_second_mark = 1 Then
                                            '恢复有效块
                                            bmpgraphics_secend.FillRectangle(bru_fill, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            '恢复卸货港
                                            bmpgraphics_secend.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1)
                                        End If
                                        If block_first_mark = 1 Then
                                            '恢复有效块
                                            bmpgraphics_bay_map.FillRectangle(bru_fill, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            '恢复卸货港
                                            bmpgraphics_bay_map.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1)
                                        End If
                                        If block_third_mark = 1 Then
                                            '恢复有效块
                                            bmpgraphics_third.FillRectangle(bru_fill, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1, rect_width - 1, rect_width - 1)
                                            '恢复卸货港
                                            bmpgraphics_third.DrawString(arrblock_unload_port(i_block, j_block), container_f, Brushes.DarkGray, pl_first_point1x + j_block * rect_width + 1, pl_first_point1y + i_block * rect_width + 1)
                                        End If
                                    Next
                                Next
                                If block_second_mark = 1 Then
                                    block_second_mark = 0
                                    Me.pl_secend.Refresh()
                                End If
                                If block_first_mark = 1 Then
                                    block_first_mark = 0
                                    Me.Pl_bay_map.Refresh()
                                End If
                                '刷新third panel
                                block_third_mark = 0
                                Me.pl_third.Refresh()
                            End If
                        End If
                        '背景色为空的情况结束
                    End If
                End If
            End If
            ''处理块结束
            '单个箱子开始
            If Me.ckb_block.Checked = False Then
                If color1.ToArgb = Color.Blue.ToArgb Or color1.ToArgb = Color.DarkGray.ToArgb Then
                    '有色
                    btn_count = btn_count + 1
                    '刷新标志
                    third_mark = 1
                    first_mark = 0 '在first panel上有效单季
                    secend_mark = 0 '在secend panel上有效单季
                    '计算在数组中的位置
                    arr_col = Fix((e.X - distoleft_third) / rect_width) '屏幕中的列数
                    arr_row = Fix(e.Y / rect_width) '屏幕中的行数
                    pl_third_point1x = arr_col
                    pl_third_point1y = arr_row
                    '箱号
                    container_No = arrthird(arr_row, arr_col)
                    Me.txt_container_no.Text = arrthird(arr_row, arr_col)
                    '卸货港标志
                    unload_port = arrunload_port(arr_row, arr_col)
                Else
                    '空白色
                    If color1.ToArgb = Me.BackColor.ToArgb Then
                        If btn_count Mod 2 = 1 Then
                            If e.X > 14 And e.X < 294 And e.Y < 280 Then
                                btn_count = 0
                                '计算在数组中的位置
                                arr_col = Fix((e.X - distoleft_third) / rect_width) '屏幕中的列数
                                arr_row = Fix(e.Y / rect_width) '屏幕中的行数
                                '记下箱号
                                arrthird(arr_row, arr_col) = container_No
                                '记下卸货港标志
                                arrunload_port(arr_row, arr_col) = unload_port
                                '填充矩形，画卸货港的首字母
                                bmpgraphics_third.FillRectangle(bru_fill, distoleft_third + arr_col * rect_width + 1, arr_row * rect_width + 1, rect_width - 1, rect_width - 1)
                                bmpgraphics_third.DrawString(unload_port, container_f, Brushes.DarkGray, distoleft_third + arr_col * rect_width + 1, arr_row * rect_width + 1)

                                If first_mark = 1 Then
                                    first_mark = 0
                                    '填充移动前BAY作在矩形的颜色
                                    bmpgraphics_bay_map.FillRectangle(bru_sys, pl_first_point1x + 1, pl_first_point1y + 1, rect_width - 1, rect_width - 1)
                                    Me.Pl_bay_map.Refresh()
                                End If
                                If secend_mark = 1 Then
                                    secend_mark = 0
                                    '填充移动前BAY作在矩形的颜色
                                    bmpgraphics_secend.FillRectangle(bru_sys, pl_first_point1x + 1, pl_first_point1y + 1, rect_width - 1, rect_width - 1)
                                    Me.pl_secend.Refresh()
                                End If
                                If third_mark = 1 Then '中街
                                    third_mark = 0
                                    show_third_pl()
                                End If

                                Me.pl_third.Refresh()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    '刷新 third panel
    Private Sub show_third_pl()
        bmpgraphics_third.FillRectangle(bru_sys, distoleft_third + pl_third_point1x * rect_width + 1, pl_third_point1y * rect_width + 1, rect_width - 1, rect_width - 1)
        Me.pl_third.Refresh()
    End Sub

    Private Sub ckb_block_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ckb_block.CheckedChanged
        first_mark = 0
        secend_mark = 0
        third_mark = 0
        btn_count = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pl_third_refresh()
    End Sub

    ''''刷新屏幕的函数
    Private Sub pl_third_refresh()
        Dim frm As New Frm_refresh
        frm.Show()
        frm.ShowInTaskbar = False
    End Sub
End Class
