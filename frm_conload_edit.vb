Imports TALLY.DBControl
Public Class frm_conload_edit
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
    Friend WithEvents dt_LISTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_FEE_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents cb_ACCOUNT_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_cheap_rate As System.Windows.Forms.TextBox
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_NO As System.Windows.Forms.TextBox
    Friend WithEvents txt_CHI_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents txt_VOYAGE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cb_CODE_PAY_MEN As System.Windows.Forms.ComboBox
    Friend WithEvents c1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cb_check As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_INCHARGER As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_PREPAREDMAN As System.Windows.Forms.TextBox
    Friend WithEvents txt_clear_no As System.Windows.Forms.TextBox
    Friend WithEvents ckb_clear As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ckTransfer As System.Windows.Forms.CheckBox
    Friend WithEvents dtWORKTIME_BEGIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtWORKTIME_END As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtCharge As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_conload_edit))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.dt_LISTDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtWORKTIME_BEGIN = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtWORKTIME_END = New System.Windows.Forms.DateTimePicker()
        Me.ckTransfer = New System.Windows.Forms.CheckBox()
        Me.txt_clear_no = New System.Windows.Forms.TextBox()
        Me.ckb_clear = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_check = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_INCHARGER = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_PREPAREDMAN = New System.Windows.Forms.TextBox()
        Me.cb_ACCOUNT_TYPE = New System.Windows.Forms.ComboBox()
        Me.cb_FEE_TYPE = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_cheap_rate = New System.Windows.Forms.TextBox()
        Me.txt_NO = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_CHI_VESSEL = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_VOYAGE = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_CODE_PAY_MEN = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.c1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.btn_cancle = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtCharge = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt_LISTDATE
        '
        Me.dt_LISTDATE.CustomFormat = "yyyy/MM/dd"
        Me.dt_LISTDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_LISTDATE.Location = New System.Drawing.Point(68, 25)
        Me.dt_LISTDATE.Name = "dt_LISTDATE"
        Me.dt_LISTDATE.Size = New System.Drawing.Size(100, 21)
        Me.dt_LISTDATE.TabIndex = 20
        Me.dt_LISTDATE.Value = New Date(2003, 12, 24, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "制单日期"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtWORKTIME_BEGIN, Me.Label8, Me.Label9, Me.dtWORKTIME_END, Me.ckTransfer, Me.txt_clear_no, Me.ckb_clear, Me.Label5, Me.cb_check, Me.Label13, Me.Label3, Me.cb_INCHARGER, Me.Label7, Me.txt_PREPAREDMAN, Me.cb_ACCOUNT_TYPE, Me.cb_FEE_TYPE, Me.dt_LISTDATE, Me.Label4, Me.Label1, Me.Label2, Me.Label12, Me.txt_cheap_rate, Me.txt_NO, Me.Label14, Me.txt_CHI_VESSEL, Me.Label15, Me.txt_VOYAGE, Me.Label16, Me.Label6, Me.cb_CODE_PAY_MEN})
        Me.GroupBox1.Location = New System.Drawing.Point(11, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 174)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "帐单信息"
        '
        'dtWORKTIME_BEGIN
        '
        Me.dtWORKTIME_BEGIN.CustomFormat = "yyyy/MM/dd"
        Me.dtWORKTIME_BEGIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtWORKTIME_BEGIN.Location = New System.Drawing.Point(370, 84)
        Me.dtWORKTIME_BEGIN.Name = "dtWORKTIME_BEGIN"
        Me.dtWORKTIME_BEGIN.Size = New System.Drawing.Size(100, 21)
        Me.dtWORKTIME_BEGIN.TabIndex = 50
        Me.dtWORKTIME_BEGIN.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(314, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 23)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "完工日期"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(314, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 23)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "开工日期"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Visible = False
        '
        'dtWORKTIME_END
        '
        Me.dtWORKTIME_END.CustomFormat = "yyyy/MM/dd"
        Me.dtWORKTIME_END.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtWORKTIME_END.Location = New System.Drawing.Point(370, 112)
        Me.dtWORKTIME_END.Name = "dtWORKTIME_END"
        Me.dtWORKTIME_END.Size = New System.Drawing.Size(100, 21)
        Me.dtWORKTIME_END.TabIndex = 49
        '
        'ckTransfer
        '
        Me.ckTransfer.Location = New System.Drawing.Point(532, 82)
        Me.ckTransfer.Name = "ckTransfer"
        Me.ckTransfer.Size = New System.Drawing.Size(50, 24)
        Me.ckTransfer.TabIndex = 46
        Me.ckTransfer.Text = "转帐"
        '
        'txt_clear_no
        '
        Me.txt_clear_no.Location = New System.Drawing.Point(450, 20)
        Me.txt_clear_no.Name = "txt_clear_no"
        Me.txt_clear_no.Size = New System.Drawing.Size(16, 21)
        Me.txt_clear_no.TabIndex = 45
        Me.txt_clear_no.Text = ""
        Me.txt_clear_no.Visible = False
        '
        'ckb_clear
        '
        Me.ckb_clear.Location = New System.Drawing.Point(366, 18)
        Me.ckb_clear.Name = "ckb_clear"
        Me.ckb_clear.Size = New System.Drawing.Size(52, 24)
        Me.ckb_clear.TabIndex = 44
        Me.ckb_clear.Text = "冲销"
        Me.ckb_clear.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(426, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 23)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "冲销帐单号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'cb_check
        '
        Me.cb_check.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_check.Location = New System.Drawing.Point(518, 140)
        Me.cb_check.Name = "cb_check"
        Me.cb_check.Size = New System.Drawing.Size(100, 20)
        Me.cb_check.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(474, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 23)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "审核人"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(474, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 23)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "主管人"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_INCHARGER
        '
        Me.cb_INCHARGER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_INCHARGER.Location = New System.Drawing.Point(518, 112)
        Me.cb_INCHARGER.Name = "cb_INCHARGER"
        Me.cb_INCHARGER.Size = New System.Drawing.Size(100, 20)
        Me.cb_INCHARGER.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(314, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 23)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "制单人"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_PREPAREDMAN
        '
        Me.txt_PREPAREDMAN.Enabled = False
        Me.txt_PREPAREDMAN.Location = New System.Drawing.Point(370, 140)
        Me.txt_PREPAREDMAN.Name = "txt_PREPAREDMAN"
        Me.txt_PREPAREDMAN.TabIndex = 35
        Me.txt_PREPAREDMAN.Text = ""
        '
        'cb_ACCOUNT_TYPE
        '
        Me.cb_ACCOUNT_TYPE.Location = New System.Drawing.Point(210, 140)
        Me.cb_ACCOUNT_TYPE.Name = "cb_ACCOUNT_TYPE"
        Me.cb_ACCOUNT_TYPE.Size = New System.Drawing.Size(100, 20)
        Me.cb_ACCOUNT_TYPE.TabIndex = 28
        '
        'cb_FEE_TYPE
        '
        Me.cb_FEE_TYPE.Location = New System.Drawing.Point(210, 112)
        Me.cb_FEE_TYPE.Name = "cb_FEE_TYPE"
        Me.cb_FEE_TYPE.Size = New System.Drawing.Size(100, 20)
        Me.cb_FEE_TYPE.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(152, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "费收类别"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(152, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "财务类别"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(4, 140)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 23)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "优惠率"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_cheap_rate
        '
        Me.txt_cheap_rate.Location = New System.Drawing.Point(48, 140)
        Me.txt_cheap_rate.Name = "txt_cheap_rate"
        Me.txt_cheap_rate.TabIndex = 26
        Me.txt_cheap_rate.Text = ""
        '
        'txt_NO
        '
        Me.txt_NO.BackColor = System.Drawing.SystemColors.Window
        Me.txt_NO.Enabled = False
        Me.txt_NO.Location = New System.Drawing.Point(258, 25)
        Me.txt_NO.Name = "txt_NO"
        Me.txt_NO.TabIndex = 26
        Me.txt_NO.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(176, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 23)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "本船帐单编号"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_CHI_VESSEL
        '
        Me.txt_CHI_VESSEL.Enabled = False
        Me.txt_CHI_VESSEL.Location = New System.Drawing.Point(48, 84)
        Me.txt_CHI_VESSEL.Name = "txt_CHI_VESSEL"
        Me.txt_CHI_VESSEL.TabIndex = 24
        Me.txt_CHI_VESSEL.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(4, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 23)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "船名"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_VOYAGE
        '
        Me.txt_VOYAGE.Enabled = False
        Me.txt_VOYAGE.Location = New System.Drawing.Point(48, 112)
        Me.txt_VOYAGE.Name = "txt_VOYAGE"
        Me.txt_VOYAGE.TabIndex = 24
        Me.txt_VOYAGE.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(4, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 23)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "航次"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(152, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 23)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "收费对象"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_CODE_PAY_MEN
        '
        Me.cb_CODE_PAY_MEN.Location = New System.Drawing.Point(210, 84)
        Me.cb_CODE_PAY_MEN.Name = "cb_CODE_PAY_MEN"
        Me.cb_CODE_PAY_MEN.Size = New System.Drawing.Size(100, 20)
        Me.cb_CODE_PAY_MEN.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1dbg})
        Me.GroupBox2.Location = New System.Drawing.Point(11, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(624, 240)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "帐单明细"
        '
        'c1dbg
        '
        Me.c1dbg.AllowAddNew = True
        Me.c1dbg.AllowDelete = True
        Me.c1dbg.AllowFilter = True
        Me.c1dbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.c1dbg.AllowSort = True
        Me.c1dbg.CaptionHeight = 18
        Me.c1dbg.CollapseColor = System.Drawing.Color.Black
        Me.c1dbg.DataChanged = False
        Me.c1dbg.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1dbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1dbg.ExpandColor = System.Drawing.Color.Black
        Me.c1dbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbg.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.c1dbg.Location = New System.Drawing.Point(3, 17)
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
        Me.c1dbg.Size = New System.Drawing.Size(618, 220)
        Me.c1dbg.TabIndex = 0
        Me.c1dbg.Text = "C1TrueDBGrid1"
        Me.c1dbg.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" Colu" & _
        "mnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" Def" & _
        "RecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0" & _
        ", 0, 614, 216</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "yout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 6" & _
        "14, 216</ClientArea></Blob>"
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(334, 454)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(65, 24)
        Me.btn_enter.TabIndex = 29
        Me.btn_enter.Text = "确认"
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(420, 454)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(65, 24)
        Me.btn_cancle.TabIndex = 30
        Me.btn_cancle.Text = "取消"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(248, 454)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(65, 24)
        Me.btnPrint.TabIndex = 29
        Me.btnPrint.Text = "打印"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(162, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 24)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "计算器"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(22, 448)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 23)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "付款"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(22, 476)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 23)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "找零"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCash
        '
        Me.txtCash.ForeColor = System.Drawing.Color.Brown
        Me.txtCash.Location = New System.Drawing.Point(56, 449)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(70, 21)
        Me.txtCash.TabIndex = 48
        Me.txtCash.Text = ""
        '
        'txtCharge
        '
        Me.txtCharge.ForeColor = System.Drawing.Color.Brown
        Me.txtCharge.Location = New System.Drawing.Point(56, 477)
        Me.txtCharge.Name = "txtCharge"
        Me.txtCharge.Size = New System.Drawing.Size(70, 21)
        Me.txtCharge.TabIndex = 48
        Me.txtCharge.Text = ""
        '
        'frm_conload_edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(646, 503)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCash, Me.Label10, Me.btn_cancle, Me.btn_enter, Me.GroupBox2, Me.GroupBox1, Me.btnPrint, Me.Button1, Me.Label11, Me.txtCharge})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_conload_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "其他帐单_编辑"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds_fee_type As New DataSet() '费收类别
    Dim ds_account_type As New DataSet() '财务类别
    Dim ds_bill_list As New DataSet() '帐单
    Dim ds_bill_detail As New DataSet() '帐单明细
    Dim ds_bill_detail_first As New DataSet()
    Dim sqlda_bill_list As New SqlClient.SqlDataAdapter() '帐单
    Dim sqlda_bill_detail As New SqlClient.SqlDataAdapter() '帐单明细
    Dim ds_check_bill As New DataSet() '检验帐单
    Dim str_BILL_ID As String '发票ID
    Dim ds_max_no As New DataSet() '最大序号
    Dim ds_no As New DataSet() '查找有无编号
    Dim ds_code_pay_men As New DataSet() '副款人
    Dim ds_ship_statu As New DataSet() '船舶状态
    Dim ds_ACCOUNT_LIST_ID As New DataSet()
    Dim ds_unit As New DataSet() '单位
    Dim ds_code_ship_type As New DataSet() '内外贸
    '  Dim ds_CODE_PAY_MEN As New DataSet()
    Dim sqlconn As New SqlClient.SqlConnection(connstr)
    Dim sqlcmd As New SqlClient.SqlCommand()
    Dim sqlad As New SqlClient.SqlDataAdapter()

    Dim ds_clear As New DataSet() '冲淆帐单
    Dim ds_manager As New DataSet() ' '填充主官人
    Dim ds_check As New DataSet()   '填充审核人

    Dim i, b As Integer

    Public strBillNo As String '提单号 潘改
    Public blSave As Boolean

    Private Sub FrmBill_list_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '填写制单人
        Me.txt_PREPAREDMAN.Text = G_User
        '填充主官人
        Getdata("select name from code_manager", ds_manager)
        For i = 0 To ds_manager.Tables(0).Rows.Count - 1
            Me.cb_INCHARGER.Items.Add(ds_manager.Tables(0).Rows(i).Item(0))
        Next
        Me.cb_INCHARGER.Text = ds_manager.Tables(0).Rows(0).Item(0)
        '填充审核人
        For i = 0 To Getdata("select name from code_check", ds_check).Count - 1
            Me.cb_check.Items.Add(ds_check.Tables(0).Rows(i).Item(0))
        Next
        Me.cb_check.Text = ds_check.Tables(0).Rows(0).Item(0)

        '费收类别
        Me.cb_FEE_TYPE.DataSource = Getdata("select CODE_FEE_TYPE,FEE_TYPE from code_FEE_TYPE", ds_fee_type)
        Me.cb_FEE_TYPE.ValueMember = "CODE_FEE_TYPE"
        Me.cb_FEE_TYPE.DisplayMember = "FEE_TYPE"
        '财务类别
        Me.cb_ACCOUNT_TYPE.DataSource = Getdata("select Account_Type,Code_Account_Type from code_account_type", ds_account_type)
        Me.cb_ACCOUNT_TYPE.DisplayMember = "Account_Type"
        Me.cb_ACCOUNT_TYPE.ValueMember = "Code_Account_Type"
        '收费对象
        '船舶代理公司
        Me.cb_CODE_PAY_MEN.DataSource = Getdata("select CODE_SHIP_AGENT,SHIPAGENT_CHA, SHIPAGENT_SHORT from code_ship_agent where Mark <> '1' OR Mark IS NULL ORDER BY SHIPAGENT_SHORT ", ds_code_pay_men)
        Me.cb_CODE_PAY_MEN.DisplayMember = "SHIPAGENT_SHORT"
        Me.cb_CODE_PAY_MEN.ValueMember = "CODE_SHIP_AGENT"

        '帐单
        Updatedata(sqlda_bill_list, "select * from bill_list where ACCOUNT_LIST_ID=" & ID, ds_bill_list)
        If ds_bill_list.Tables(0).Rows.Count > 0 Then
            On Error GoTo rr
            txt_CHI_VESSEL.Text = ds_bill_list.Tables(0).Rows(0).Item("CHI_VESSEL")
            txt_VOYAGE.Text = ds_bill_list.Tables(0).Rows(0).Item("VOYAGE")
            txt_NO.Text = ds_bill_list.Tables(0).Rows(0).Item("no")
            Me.cb_INCHARGER.Text = ds_bill_list.Tables(0).Rows(0).Item("INCHARGER")
            dt_LISTDATE.Value = ds_bill_list.Tables(0).Rows(0).Item("LISTDATE")
            cb_FEE_TYPE.SelectedValue = ds_bill_list.Tables(0).Rows(0).Item("FEE_TYPE")   '费收类别
            cb_ACCOUNT_TYPE.SelectedValue = ds_bill_list.Tables(0).Rows(0).Item("ACCOUNT_TYPE")   '财务类别
            Me.cb_CODE_PAY_MEN.SelectedValue = ds_bill_list.Tables(0).Rows(0).Item("CODE_PAY_MEN")   '收费对象
            Me.cb_check.Text = ds_bill_list.Tables(0).Rows(0).Item("CHECKEDMAN")
            '转帐
            If ds_bill_list.Tables(0).Rows(0).Item("transfer") = 1 Then
                Me.ckTransfer.Checked = True
            Else
                Me.ckTransfer.Checked = False
            End If
            '冲淆标志
            '开工时间
            Me.dtWORKTIME_BEGIN.Value = ds_bill_list.Tables(0).Rows(0).Item("WORKTIME_BEGIN")
            '完工时间
            Me.dtWORKTIME_END.Value = ds_bill_list.Tables(0).Rows(0).Item("WORKTIME_END")
            'txt_PREPAREDMAN.Text = ds_bill_list.Tables(0).Rows(0).Item("PREPAREDMAN")
            '冲消帐单
            If ds_bill_list.Tables(0).Rows(0).Item("clear_no") Is System.DBNull.Value Then
            Else
                Me.txt_clear_no.Text = ds_bill_list.Tables(0).Rows(0).Item("clear_no")
            End If
            If ds_bill_list.Tables(0).Rows(0).Item("clear") > 0 Then
                Me.ckb_clear.Checked = True
            End If
rr:
            Resume Next
        End If
        '   由内外贸判断中英文

        Me.c1dbg.DataSource = Updatedata(sqlda_bill_detail, "select ACCOUNT_DETAIL_ID,ACCOUNT_LIST_ID,FEE_CODE,Tally_items_CHA as fee_name,FEE_AMOUNT,UNIT,FEE_RATE,MONEY,USER_NAME from view_bill_detail where  ACCOUNT_LIST_ID=" & ID, ds_bill_detail_first)
        Me.c1dbg.Row = Me.c1dbg.Row + 1
        Me.c1dbg.Splits(0).DisplayColumns.Item("ACCOUNT_DETAIL_ID").Visible = False
        Me.c1dbg.Splits(0).DisplayColumns.Item("ACCOUNT_LIST_ID").Visible = False
        Me.c1dbg.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False '制单人
        Me.c1dbg.Columns.Item("fee_code").Caption = "费率代码"
        Me.c1dbg.Columns.Item("fee_name").Caption = "费率名称"
        Me.c1dbg.Columns.Item("fee_amount").Caption = "计费数量"
        Me.c1dbg.Columns.Item("unit").Caption = "单位"
        Me.c1dbg.Columns.Item("fee_rate").Caption = "单价"
        Me.c1dbg.Columns.Item("money").Caption = "金额"
        Me.c1dbg.Splits(0).DisplayColumns.Item("fee_code").Button = True
        Me.c1dbg.Columns("unit").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
        Me.c1dbg.Columns("unit").ValueItems.Translate = True
        '合计
        Me.c1dbg.ColumnFooters = True
        Me.c1dbg.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.c1dbg.Columns.Item("fee_code").FooterText = "合计 共" & ds_bill_detail_first.Tables(0).Rows.Count & "条"
        Dim totalMoney As Double
        totalMoney = 0
        Me.c1dbg.MoveFirst()
        For i = 0 To ds_bill_detail_first.Tables(0).Rows.Count - 1
            '金额
            totalMoney = totalMoney + Me.c1dbg.Columns.Item("money").Text
            '合计
            '  totalMoney = totalMoney + ds_bill_detail_first.Tables(0).Rows(i).Item("money")
            Me.c1dbg.MoveNext()
        Next
        '合计
        Me.c1dbg.Columns.Item("money").FooterText = totalMoney

        '中文单位
        Getdata("select unit_cha from code_fee where unit_cha is not null group by unit_cha", ds_unit) '中文
        For i = 0 To ds_unit.Tables(0).Rows.Count - 1
            Dim life As New C1.Win.C1TrueDBGrid.ValueItem()
            life.Value = ds_unit.Tables(0).Rows(i).Item("unit_cha")
            life.DisplayValue = ds_unit.Tables(0).Rows(i).Item("unit_cha")
            Me.c1dbg.Columns("unit").ValueItems.Values.Add(life)
        Next
        '帐单
        columnswidth()
    End Sub


    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        'Getdata("select ACCOUNT_LIST_ID,no from bill_list where CHI_VESSEL='" & Me.txt_CHI_VESSEL.Text & "'and VOYAGE='" & Me.txt_VOYAGE.Text & "'and  no='" & Trim(Me.txt_NO.Text) & "'", ds_no) '判断编号
        'Getdata("select max(no) from bill_list where CHI_VESSEL='" & Me.txt_CHI_VESSEL.Text & "'and VOYAGE='" & Me.txt_VOYAGE.Text & "'", ds_max_no) '最大植
        '首先判断是否为冲淆帐单的
        If Me.ckb_clear.Checked = True Then
            If Getdata("select No from bill_list where  no= '" & Me.txt_clear_no.Text & "' and CHI_VESSEL='" & Me.txt_CHI_VESSEL.Text & "'and VOYAGE='" & Me.txt_VOYAGE.Text & "'", ds_clear).Count = 0 Then
                MsgBox("冲销帐单号不存在，请查验！", MsgBoxStyle.OKOnly, "提示！")
                Exit Sub
            End If
        End If

        str_BILL_ID = "select BILL_ID from bill_list where CHI_VESSEL='" & Me.txt_CHI_VESSEL.Text & "'and VOYAGE='" & Me.txt_VOYAGE.Text & "'and  no='" & Trim(Me.txt_NO.Text) & "'"
        Getdata(str_BILL_ID, ds_check_bill) '判断发票号

        'If ds_no.Tables(0).Rows().Count > 0 Then '有编号If CType(Len(ds_check_bill.Tables(0).Rows(0).Item("no")), Integer) < CType(ds_max_no.Tables(0).Rows(0).Item(0), Integer) Then

        If ds_check_bill.Tables(0).Rows(0).Item("BILL_ID") Is System.DBNull.Value Then '无发票ＩＤ

            Me.c1dbg.MoveLast()
            b = Me.c1dbg.Row
            Me.c1dbg.MoveFirst()

            For i = Me.c1dbg.Row To b
                If Len(Trim(Me.c1dbg.Columns.Item("fee_code").Text.ToString)) > 0 Then   '非率代码和几费数量 And Len(Trim(Me.txt_FEE_AMOUNT.Text)) > 0
                    'If Len(Trim(Me.c1dbg.Columns.Item("fee_amount").Text.ToString)) > 0 Then
                    'Else
                    '    MsgBox("请在第'" & Me.c1dbg.Row & "'行输入计费数量！", MsgBoxStyle.OKOnly, "提示")
                    '    Exit Sub
                    'End If
                Else
                    MsgBox("请在第'" & Me.c1dbg.Row + 1 & "'行选择费收项目！", MsgBoxStyle.OKOnly, "提示！")
                    Exit Sub
                End If
                Me.c1dbg.MoveNext()
            Next
            ' 修改帐单
            '更新帐单
            ds_bill_list.Tables(0).Rows(0).Item("CHI_VESSEL") = txt_CHI_VESSEL.Text
            ds_bill_list.Tables(0).Rows(0).Item("VOYAGE") = txt_VOYAGE.Text
            ds_bill_list.Tables(0).Rows(0).Item("LISTDATE") = DatePart(DateInterval.Year, Me.dt_LISTDATE.Value) & "-" & DatePart(DateInterval.Month, Me.dt_LISTDATE.Value) & "-" & DatePart(DateInterval.Day, Me.dt_LISTDATE.Value)
            ds_bill_list.Tables(0).Rows(0).Item("no") = txt_NO.Text
            ds_bill_list.Tables(0).Rows(0).Item("INCHARGER") = Me.cb_INCHARGER.Text
            ds_bill_list.Tables(0).Rows(0).Item("CHECKEDMAN") = Me.cb_check.Text
            ds_bill_list.Tables(0).Rows(0).Item("PREPAREDMAN") = txt_PREPAREDMAN.Text
            ds_bill_list.Tables(0).Rows(0).Item("FEE_TYPE") = cb_FEE_TYPE.SelectedValue     '费收类别
            ds_bill_list.Tables(0).Rows(0).Item("ACCOUNT_TYPE") = cb_ACCOUNT_TYPE.SelectedValue      '财务类别
            ds_bill_list.Tables(0).Rows(0).Item("CODE_PAY_MEN") = Me.cb_CODE_PAY_MEN.SelectedValue      '收费对象
            '转帐
            If Me.ckTransfer.Checked = True Then
                ds_bill_list.Tables(0).Rows(0).Item("transfer") = 1
            Else
                ds_bill_list.Tables(0).Rows(0).Item("transfer") = 0
            End If
            '冲淆标志
            If Me.ckb_clear.Checked = True Then
                '填写本帐单编号
                ds_bill_list.Tables(0).Rows(0).Item("clear") = 1
                ds_bill_list.Tables(0).Rows(0).Item("clear_no") = Me.txt_clear_no.Text
                '填写被冲淆帐单编号
                ExecSql("update bill_list set clear=2 , clear_No='" & Me.txt_NO.Text & "' where no='" & Me.txt_clear_no.Text & "' and CHI_VESSEL='" & Me.txt_CHI_VESSEL.Text & "'and VOYAGE='" & Me.txt_VOYAGE.Text & "'")

            End If
            '取消冲淆标志
            If Me.ckb_clear.Checked = False Then
                '填写本帐单编号
                ds_bill_list.Tables(0).Rows(0).Item("clear") = 0
                ds_bill_list.Tables(0).Rows(0).Item("clear_no") = System.DBNull.Value
                '填写被冲淆帐单编号
                ExecSql("update bill_list set clear=0 , clear_No=null where no='" & Me.txt_clear_no.Text & "' and CHI_VESSEL='" & Me.txt_CHI_VESSEL.Text & "'and VOYAGE='" & Me.txt_VOYAGE.Text & "'")

            End If

            Try
                sqlda_bill_list.Update(ds_bill_list)
            Catch ex As System.Exception
                MsgBox(ex)
            End Try

            ' 修改帐单明细()
            ExecSql("delete from bill_detail where ACCOUNT_LIST_ID=" & ID)
            Updatedata(sqlda_bill_detail, "select * from bill_detail where ACCOUNT_LIST_ID=" & ID, ds_bill_detail)
            Me.c1dbg.MoveFirst()
            For i = Me.c1dbg.Row To b
                If Len(Trim(Me.c1dbg.Columns.Item("fee_code").Text.ToString)) > 0 Then   '非率代码和几费数量 And Len(Trim(Me.txt_FEE_AMOUNT.Text)) > 0
                    '  If Len(Trim(Me.c1dbg.Columns.Item("fee_amount").Text.ToString)) > 0 Then

                    Dim row As DataRow
                    row = ds_bill_detail.Tables(0).NewRow
                    row("ACCOUNT_LIST_ID") = ID
                    row("FEE_CODE") = Me.c1dbg.Columns.Item("fee_code").Text.ToString
                    row("FEE_AMOUNT") = IIf(Len(Trim(Me.c1dbg.Columns.Item("fee_amount").Text)) > 0, Me.c1dbg.Columns.Item("fee_amount").Text.ToString, 0)
                    row("UNIT") = Me.c1dbg.Columns.Item("unit").Text.ToString
                    row("FEE_RATE") = IIf(Len(Trim(Me.c1dbg.Columns.Item("fee_rate").Text)) > 0, Me.c1dbg.Columns.Item("fee_rate").Text.ToString, 0)
                    '''金额
                    If Len(Trim(Me.c1dbg.Columns.Item("money").Text.ToString)) > 0 Then
                        row("MONEY") = Me.c1dbg.Columns.Item("money").Text.ToString
                    Else
                        '判断优惠汇率\几费数量\单价\是否存在
                        If Len(Trim(Me.c1dbg.Columns.Item("fee_amount").Text.ToString)) > 0 And Len(Trim(Me.c1dbg.Columns.Item("fee_rate").Text.ToString)) > 0 Then
                            If Len(Trim(Me.txt_cheap_rate.Text)) > 0 Then
                                Try
                                    row("MONEY") = CType(Me.c1dbg.Columns.Item("fee_amount").Text, Double) * CType(Me.c1dbg.Columns.Item("fee_rate").Text, Double) * CType(Me.txt_cheap_rate.Text, Double)
                                Catch ex As System.Exception
                                    MsgBox(ex)
                                End Try
                            Else
                                Try
                                    row("MONEY") = CType(Me.c1dbg.Columns.Item("fee_amount").Text, Double) * CType(Me.c1dbg.Columns.Item("fee_rate").Text, Double)
                                Catch es As System.Exception
                                    MsgBox(es)
                                End Try
                            End If
                        End If
                    End If
                    row("USER_NAME") = Me.txt_PREPAREDMAN.Text

                    ds_bill_detail.Tables(0).Rows.Add(row)
                    sqlda_bill_detail.Update(ds_bill_detail)

                    Me.Close()
                    blSave = True
                    'Else
                    '    MsgBox("请输入计费数量！", MsgBoxStyle.OKOnly, "提示")
                    'End If
                Else
                    MsgBox("请选择费收项目！", MsgBoxStyle.OKOnly, "提示！")
                End If
                Me.c1dbg.MoveNext()
            Next
        Else
            '有发票ＩＤ
            MsgBox("该船名航次已被封存！", MsgBoxStyle.OKOnly, "提示！")
        End If

        'Else '无编号
        '    MsgBox("该船名航次无此帐单编号！", MsgBoxStyle.OKOnly, "提示！")
        'End If
    End Sub
   

    Private Sub c1dbg_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles c1dbg.ButtonClick
        If e.ColIndex = 2 Then
            Dim frm As New FrmFeeSelect()
            frm.ShowDialog()
            Me.c1dbg.Columns.Item("fee_code").Text = G_SelectCode
            Dim str_fee_code As String
            Dim ds_cha As New DataSet()
            str_fee_code = "select tally_items_cha,unit_cha,unit_eng from code_fee where fee_code='" & G_SelectCode & "'"
            Getdata(str_fee_code, ds_cha)
            If ds_cha.Tables(0).Rows.Count > 0 Then
                Me.c1dbg.Columns.Item("fee_name").Text = ds_cha.Tables(0).Rows(0).Item(0) '费率名称
                Try
                    Me.c1dbg.Columns.Item("unit").Text = ds_cha.Tables(0).Rows(0).Item("unit_cha") '单位
                Catch
                End Try

                Dim str_unit As String
                Dim ds_unit As New DataSet()
                str_unit = "select price_pre from account_work where fee_code='" & G_SelectCode & "'"
                Try
                    Getdata(str_unit, ds_unit)
                    ' Me.txt_unit.Text = ds_unit.Tables(0).Rows(0).Item("unit") '单位
                    Me.c1dbg.Columns.Item("fee_rate").Text = ds_unit.Tables(0).Rows(0).Item("price_pre") '单价
                Catch ' ex As System.Exception
                    ' MsgBox(ex)
                End Try
            End If
        End If
    End Sub


    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub

    Private Sub columnswidth()
        Dim j As Integer
        For j = 0 To Me.c1dbg.Columns.Count - 1
            Me.c1dbg.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.c1dbg.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width < 60 Then
                Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width = 60
            Else
                If Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If

        Next
        Me.c1dbg.Splits(0).DisplayColumns.Item("fee_rate").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far
        Me.c1dbg.Splits(0).DisplayColumns.Item("money").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

        'Me.c1dbg.Splits(0).DisplayColumns.Item("no").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        'Me.c1dbg.Splits(0).DisplayColumns.Item("Descri").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        'Me.c1dbg.Splits(0).DisplayColumns.Item("Account_Type").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    End Sub

    Private Sub c1dbg_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles c1dbg.AfterColEdit
        If e.ColIndex = 2 Then
            If Len(Trim(Me.c1dbg.Columns.Item("fee_code").Text)) > 0 Then
                G_SelectCode = Trim(Me.c1dbg.Columns.Item("fee_code").Text)

                Dim str_fee_code As String
                Dim ds_cha As New DataSet()
                str_fee_code = "select tally_items_cha,unit_cha,unit_eng from code_fee where fee_code='" & G_SelectCode & "'"

                If Getdata(str_fee_code, ds_cha).Count > 0 Then
                    Me.c1dbg.Columns.Item("fee_name").Text = ds_cha.Tables(0).Rows(0).Item(0) '费率名称
                    Me.c1dbg.Columns.Item("unit").Text = ds_cha.Tables(0).Rows(0).Item("unit_cha") '单位
                    Dim str_unit As String
                    Dim ds_unit As New DataSet()
                    str_unit = "select price_pre from account_work where fee_code='" & G_SelectCode & "'"
                    Try
                        Getdata(str_unit, ds_unit)
                        ' Me.txt_unit.Text = ds_unit.Tables(0).Rows(0).Item("unit") '单位
                        Me.c1dbg.Columns.Item("fee_rate").Text = ds_unit.Tables(0).Rows(0).Item("price_pre") '单价
                    Catch ex As System.Exception
                        MsgBox(ex)
                    End Try
                Else
                    MsgBox("无此费率代码，请重新输入！", MsgBoxStyle.OKOnly, "提示！")
                End If
            End If
        End If
        '判断优惠汇率和单价是否存在
        If e.ColIndex = 4 Or e.ColIndex = 6 Then
            If Len(Trim(Me.c1dbg.Columns.Item("fee_rate").Text)) > 0 Then
                If Len(Trim(Me.c1dbg.Columns.Item("fee_amount").Text)) > 0 Then
                    If Len(Trim(Me.txt_cheap_rate.Text)) > 0 Then
                        Try
                            Me.c1dbg.Columns.Item("money").Text = CType(Me.c1dbg.Columns.Item("fee_amount").Text, Double) * CType(Me.c1dbg.Columns.Item("fee_rate").Text, Double) * CType(Me.txt_cheap_rate.Text, Double)
                        Catch ex As System.Exception
                            MsgBox(ex)
                        End Try
                    Else
                        Try
                            Me.c1dbg.Columns.Item("money").Text = CType(Me.c1dbg.Columns.Item("fee_amount").Text, Double) * CType(Me.c1dbg.Columns.Item("fee_rate").Text, Double)
                        Catch es As System.Exception
                            MsgBox(es)
                        End Try
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintBill()
        GC.Collect()
        Me.Close()
    End Sub

    Private Sub PrintBill()
        Dim xlApp As Excel.Application
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet

        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        Try
            '潘改
            'FilePath = CurDir()
            'FileCopy(FilePath + "\zhuweixin2.xls", FilePath + "\copy_zhuweixin.xls")
            'FilePath = FilePath + "\copy_zhuweixin.xls"
            PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
            PathStr = substr(PathStr)
            FilePath = PathStr + "copy_zhuweixin.xls"
            FileCopy(PathStr & "zhuweixin2.xls", FilePath)

            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets("conLoadFee"), Excel.Worksheet)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = False
            'xlBook.Sheets("conLoadFee").select()
            'CHI_VESSEL,VOYAGE,NO,listdate,Descri,Account_Type,SHIPAGENT_CHA,FEE_CODE,Tally_items_CHA,
            'FEE_AMOUNT,UNIT_cha,cast(cast(FEE_RATE as numeric(10,2)) as varchar) as fee_rate,cast(cast(MONEY as numeric(10,2)) as varchar) as money

            xlSheet.Cells(1, 9) = strBillNo '提单号，潘改
            '船名
            xlSheet.Cells(3, 1) = Me.txt_CHI_VESSEL.Text
            '航次
            xlSheet.Cells(3, 4) = Me.txt_VOYAGE.Text
            '国际‘

            '帐单编号
            xlSheet.Cells(2, 10) = Me.txt_NO.Text
            '制单日期
            xlSheet.Cells(3, 9) = Me.dt_LISTDATE.Value
            '开工日期

            '完工日期
            xlSheet.Cells(4, 6) = Me.dtWORKTIME_END.Value

            Dim totalMoney As Double
            totalMoney = 0
            Me.c1dbg.MoveFirst()
            For i = 0 To ds_bill_detail_first.Tables(0).Rows.Count - 1
                '理货项目
                xlSheet.Cells(i + 6, 1) = Me.c1dbg.Columns.Item("fee_name")
                '积肥食粮
                xlSheet.Cells(i + 6, 4) = Me.c1dbg.Columns.Item("fee_amount")
                '单位
                xlSheet.Cells(i + 6, 5) = Me.c1dbg.Columns.Item("unit")
                '非率
                xlSheet.Cells(i + 6, 7) = Me.c1dbg.Columns.Item("FEE_RATE")
                '金额
                xlSheet.Cells(i + 6, 9) = Me.c1dbg.Columns.Item("money")
                '合计
                totalMoney = totalMoney + ds_bill_detail_first.Tables(0).Rows(i).Item("money")
                Me.c1dbg.MoveNext()
            Next
            '合计
            xlSheet.Cells(12, 11) = totalMoney
            xlSheet.Cells(12, 4) = MakeBigWord(totalMoney)
            '主管
            xlSheet.Cells(14, 2) = Me.cb_INCHARGER.Text
            '审核
            xlSheet.Cells(14, 4) = Me.cb_check.Text
            '制单
            xlSheet.Cells(14, 7) = Me.txt_PREPAREDMAN.Text
            xlSheet.PrintOut()
            xlApp.Quit()
            '此帐单打印完成后应该到完成截面里
            ds_bill_list.Tables(0).Rows(0).Item("printed") = 1
            Try
                sqlda_bill_list.Update(ds_bill_list)
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("calc.exe")

    End Sub


    Private Sub txtCash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCash.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Me.txtCharge.Text = Math.Round(CType(Me.txtCash.Text, Single) - CType(Me.c1dbg.Columns.Item("money").FooterText, Single), 1)
            Catch ex As System.Exception
                MsgBox("请检查输入的金额", MsgBoxStyle.OKOnly, "提示")
            End Try
        End If
    End Sub
End Class
