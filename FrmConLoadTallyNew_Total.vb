Imports TALLY.DBControl
Public Class FrmConLoadTallyNew_Total
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler dtpTimeBegin.KeyDown, AddressOf FrmConLoadTallyNew_Total_KeyDown
        AddHandler dtpTimeEnd.KeyDown, AddressOf FrmConLoadTallyNew_Total_KeyDown
        AddHandler ccbClerk.KeyDown, AddressOf FrmConLoadTallyNew_Total_KeyDown
        AddHandler ccbConsign.KeyDown, AddressOf FrmConLoadTallyNew_Total_KeyDown
        AddHandler txtShip.KeyDown, AddressOf FrmConLoadTallyNew_Total_KeyDown
        AddHandler txtVoyage.KeyDown, AddressOf FrmConLoadTallyNew_Total_KeyDown
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
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents labResult As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtContainerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LbYard As System.Windows.Forms.Label
    Friend WithEvents LbTotal As System.Windows.Forms.Label
    Friend WithEvents lb20 As System.Windows.Forms.Label
    Friend WithEvents lbElse As System.Windows.Forms.Label
    Friend WithEvents lb40 As System.Windows.Forms.Label
    Friend WithEvents C1Total As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbBegin As System.Windows.Forms.Label
    Friend WithEvents lbEnd As System.Windows.Forms.Label
    Friend WithEvents btnPartConStat As System.Windows.Forms.Button
    Friend WithEvents rbnEdit As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSave As System.Windows.Forms.RadioButton
    Friend WithEvents btnPersonConStat As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ccbClerk As C1.Win.C1List.C1Combo
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ccbConsign As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbc As System.Windows.Forms.TabControl
    Friend WithEvents tpDept As System.Windows.Forms.TabPage
    Friend WithEvents tpVoyage As System.Windows.Forms.TabPage
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnIsPrintNoCheckStat As System.Windows.Forms.Button
    Friend WithEvents btReport As System.Windows.Forms.Button
    Friend WithEvents cbDept As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadTallyNew_Total))
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btReport = New System.Windows.Forms.Button
        Me.labResult = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.txtContainerNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.LbYard = New System.Windows.Forms.Label
        Me.btnPartConStat = New System.Windows.Forms.Button
        Me.LbTotal = New System.Windows.Forms.Label
        Me.lb20 = New System.Windows.Forms.Label
        Me.lbElse = New System.Windows.Forms.Label
        Me.lb40 = New System.Windows.Forms.Label
        Me.C1Total = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbBegin = New System.Windows.Forms.Label
        Me.lbEnd = New System.Windows.Forms.Label
        Me.rbnEdit = New System.Windows.Forms.RadioButton
        Me.rbnSave = New System.Windows.Forms.RadioButton
        Me.btnPersonConStat = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ccbClerk = New C1.Win.C1List.C1Combo
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ccbConsign = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbc = New System.Windows.Forms.TabControl
        Me.tpDept = New System.Windows.Forms.TabPage
        Me.cbDept = New System.Windows.Forms.ComboBox
        Me.tpVoyage = New System.Windows.Forms.TabPage
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnIsPrintNoCheckStat = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccbClerk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ccbConsign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbc.SuspendLayout()
        Me.tpDept.SuspendLayout()
        Me.tpVoyage.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(406, 4)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(118, 21)
        Me.dtpTimeEnd.TabIndex = 417
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(348, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 419
        Me.Label8.Text = "结束时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(230, 4)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(118, 21)
        Me.dtpTimeBegin.TabIndex = 416
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(172, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 418
        Me.Label7.Text = "开始时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(818, 592)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 22)
        Me.btQuit.TabIndex = 421
        Me.btQuit.Text = "退出"
        '
        'btReport
        '
        Me.btReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btReport.Location = New System.Drawing.Point(534, 592)
        Me.btReport.Name = "btReport"
        Me.btReport.Size = New System.Drawing.Size(65, 22)
        Me.btReport.TabIndex = 420
        Me.btReport.Text = "报表"
        '
        'labResult
        '
        Me.labResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labResult.Font = New System.Drawing.Font("仿宋_GB2312", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.labResult.ForeColor = System.Drawing.Color.Green
        Me.labResult.Location = New System.Drawing.Point(138, 40)
        Me.labResult.Name = "labResult"
        Me.labResult.Size = New System.Drawing.Size(220, 24)
        Me.labResult.TabIndex = 422
        Me.labResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C1DBG
        '
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 114)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(900, 436)
        Me.C1DBG.TabIndex = 423
        Me.C1DBG.Text = "C1TrueDBGrid1"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>432</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 896, 432</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 896, 432</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'txtContainerNo
        '
        Me.txtContainerNo.Location = New System.Drawing.Point(60, 88)
        Me.txtContainerNo.MaxLength = 12
        Me.txtContainerNo.Name = "txtContainerNo"
        Me.txtContainerNo.Size = New System.Drawing.Size(120, 21)
        Me.txtContainerNo.TabIndex = 428
        Me.txtContainerNo.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 429
        Me.Label3.Text = "集装箱号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LbYard
        '
        Me.LbYard.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LbYard.Location = New System.Drawing.Point(4, 32)
        Me.LbYard.Name = "LbYard"
        Me.LbYard.Size = New System.Drawing.Size(130, 22)
        Me.LbYard.TabIndex = 431
        Me.LbYard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPartConStat
        '
        Me.btnPartConStat.Location = New System.Drawing.Point(208, 88)
        Me.btnPartConStat.Name = "btnPartConStat"
        Me.btnPartConStat.Size = New System.Drawing.Size(90, 22)
        Me.btnPartConStat.TabIndex = 433
        Me.btnPartConStat.Text = "部门装箱统计"
        '
        'LbTotal
        '
        Me.LbTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbTotal.Location = New System.Drawing.Point(484, 552)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(92, 20)
        Me.LbTotal.TabIndex = 439
        Me.LbTotal.Text = "合计："
        Me.LbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LbTotal.Visible = False
        '
        'lb20
        '
        Me.lb20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb20.Location = New System.Drawing.Point(578, 552)
        Me.lb20.Name = "lb20"
        Me.lb20.Size = New System.Drawing.Size(92, 20)
        Me.lb20.TabIndex = 440
        Me.lb20.Text = "20'X"
        Me.lb20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lb20.Visible = False
        '
        'lbElse
        '
        Me.lbElse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbElse.Location = New System.Drawing.Point(766, 552)
        Me.lbElse.Name = "lbElse"
        Me.lbElse.Size = New System.Drawing.Size(92, 20)
        Me.lbElse.TabIndex = 442
        Me.lbElse.Text = "其它："
        Me.lbElse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbElse.Visible = False
        '
        'lb40
        '
        Me.lb40.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb40.Location = New System.Drawing.Point(672, 552)
        Me.lb40.Name = "lb40"
        Me.lb40.Size = New System.Drawing.Size(92, 20)
        Me.lb40.TabIndex = 441
        Me.lb40.Text = "40'X"
        Me.lb40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lb40.Visible = False
        '
        'C1Total
        '
        Me.C1Total.AllowUpdate = False
        Me.C1Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.C1Total.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Total.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1Total.Location = New System.Drawing.Point(0, 551)
        Me.C1Total.Name = "C1Total"
        Me.C1Total.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Total.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Total.PreviewInfo.ZoomFactor = 75
        Me.C1Total.Size = New System.Drawing.Size(372, 74)
        Me.C1Total.TabIndex = 443
        Me.C1Total.Text = "C1TrueDBGrid1"
        Me.C1Total.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>70</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyl" & _
        "e parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><Fi" & _
        "lterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""" & _
        "Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headin" & _
        "g"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inactiv" & _
        "eStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" " & _
        "/><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle par" & _
        "ent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0," & _
        " 0, 368, 70</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderSty" & _
        "le></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""No" & _
        "rmal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer" & _
        """ /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive""" & _
        " /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><" & _
        "Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" />" & _
        "<Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector""" & _
        " /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" />" & _
        "</NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</" & _
        "Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 368, 70</Cli" & _
        "entArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle par" & _
        "ent="""" me=""Style15"" /></Blob>"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(-2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 445
        Me.Label1.Text = "部门"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbBegin
        '
        Me.lbBegin.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbBegin.Location = New System.Drawing.Point(136, 32)
        Me.lbBegin.Name = "lbBegin"
        Me.lbBegin.Size = New System.Drawing.Size(130, 22)
        Me.lbBegin.TabIndex = 446
        Me.lbBegin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbEnd
        '
        Me.lbEnd.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbEnd.Location = New System.Drawing.Point(268, 32)
        Me.lbEnd.Name = "lbEnd"
        Me.lbEnd.Size = New System.Drawing.Size(130, 22)
        Me.lbEnd.TabIndex = 447
        Me.lbEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbnEdit
        '
        Me.rbnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbnEdit.Checked = True
        Me.rbnEdit.Location = New System.Drawing.Point(394, 576)
        Me.rbnEdit.Name = "rbnEdit"
        Me.rbnEdit.Size = New System.Drawing.Size(80, 20)
        Me.rbnEdit.TabIndex = 450
        Me.rbnEdit.TabStop = True
        Me.rbnEdit.Text = "导出编辑"
        '
        'rbnSave
        '
        Me.rbnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbnSave.Location = New System.Drawing.Point(394, 598)
        Me.rbnSave.Name = "rbnSave"
        Me.rbnSave.Size = New System.Drawing.Size(80, 20)
        Me.rbnSave.TabIndex = 451
        Me.rbnSave.Text = "导出保存"
        '
        'btnPersonConStat
        '
        Me.btnPersonConStat.Location = New System.Drawing.Point(304, 88)
        Me.btnPersonConStat.Name = "btnPersonConStat"
        Me.btnPersonConStat.Size = New System.Drawing.Size(90, 22)
        Me.btnPersonConStat.TabIndex = 452
        Me.btnPersonConStat.Text = "理箱记录"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 454
        Me.Label2.Text = "理货员"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ccbClerk
        '
        Me.ccbClerk.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.ccbClerk.AutoDropDown = True
        Me.ccbClerk.Caption = ""
        Me.ccbClerk.CaptionHeight = 17
        Me.ccbClerk.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ccbClerk.ColumnCaptionHeight = 18
        Me.ccbClerk.ColumnFooterHeight = 18
        Me.ccbClerk.ContentHeight = 16
        Me.ccbClerk.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.ccbClerk.EditorBackColor = System.Drawing.SystemColors.Window
        Me.ccbClerk.EditorFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ccbClerk.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.ccbClerk.EditorHeight = 16
        Me.ccbClerk.Enabled = False
        Me.ccbClerk.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.ccbClerk.ItemHeight = 15
        Me.ccbClerk.Location = New System.Drawing.Point(62, 14)
        Me.ccbClerk.MatchEntryTimeout = CType(2000, Long)
        Me.ccbClerk.MaxDropDownItems = CType(20, Short)
        Me.ccbClerk.MaxLength = 32767
        Me.ccbClerk.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.ccbClerk.Name = "ccbClerk"
        Me.ccbClerk.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.ccbClerk.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.ccbClerk.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ccbClerk.Size = New System.Drawing.Size(118, 22)
        Me.ccbClerk.TabIndex = 455
        Me.ccbClerk.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{}HighlightRow{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:Near;}OddRow{}Reco" & _
        "rdSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Border:Raised,," & _
        "1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{}Style11{}St" & _
        "yle1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowColSelect=""False"" " & _
        "Name=""Split[0,0]"" CaptionHeight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight" & _
        "=""18"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 116, 1" & _
        "56</ClientRect><Height>156</Height><VScrollBar><Width>16</Width></VScrollBar><HS" & _
        "crollBar><Height>16</Height></HScrollBar><CaptionStyle parent=""Style2"" me=""Style" & _
        "9"" /><EvenRowStyle parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" m" & _
        "e=""Style3"" /><GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Hea" & _
        "ding"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><Inac" & _
        "tiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style" & _
        "8"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle " & _
        "parent=""Selected"" me=""Style5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1" & _
        "List.ListBoxView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style par" & _
        "ent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=" & _
        """Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""" & _
        "Normal"" me=""Selected"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent" & _
        "=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Hea" & _
        "ding"" me=""RecordSelector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><" & _
        "vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" & _
        "aultRecSelWidth>16</DefaultRecSelWidth></Blob>"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ccbConsign)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ccbClerk)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.labResult)
        Me.GroupBox2.Location = New System.Drawing.Point(540, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 84)
        Me.GroupBox2.TabIndex = 456
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "筛选"
        '
        'ccbConsign
        '
        Me.ccbConsign.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.ccbConsign.AutoDropDown = True
        Me.ccbConsign.Caption = ""
        Me.ccbConsign.CaptionHeight = 17
        Me.ccbConsign.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ccbConsign.ColumnCaptionHeight = 18
        Me.ccbConsign.ColumnFooterHeight = 18
        Me.ccbConsign.ContentHeight = 16
        Me.ccbConsign.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.ccbConsign.EditorBackColor = System.Drawing.SystemColors.Window
        Me.ccbConsign.EditorFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ccbConsign.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.ccbConsign.EditorHeight = 16
        Me.ccbConsign.Enabled = False
        Me.ccbConsign.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.ccbConsign.ItemHeight = 15
        Me.ccbConsign.Location = New System.Drawing.Point(240, 14)
        Me.ccbConsign.MatchEntryTimeout = CType(2000, Long)
        Me.ccbConsign.MaxDropDownItems = CType(20, Short)
        Me.ccbConsign.MaxLength = 32767
        Me.ccbConsign.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.ccbConsign.Name = "ccbConsign"
        Me.ccbConsign.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.ccbConsign.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.ccbConsign.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ccbConsign.Size = New System.Drawing.Size(118, 22)
        Me.ccbConsign.TabIndex = 457
        Me.ccbConsign.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{}HighlightRow{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}RecordSelector{Alig" & _
        "nImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;For" & _
        "eColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}Style9{AlignHorz:" & _
        "Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowColSelect=""False"" " & _
        "Name=""Split[0,0]"" CaptionHeight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight" & _
        "=""18"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 116, 1" & _
        "56</ClientRect><Height>156</Height><VScrollBar><Width>16</Width></VScrollBar><HS" & _
        "crollBar><Height>16</Height></HScrollBar><CaptionStyle parent=""Style2"" me=""Style" & _
        "9"" /><EvenRowStyle parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" m" & _
        "e=""Style3"" /><GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Hea" & _
        "ding"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><Inac" & _
        "tiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style" & _
        "8"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle " & _
        "parent=""Selected"" me=""Style5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1" & _
        "List.ListBoxView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style par" & _
        "ent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=" & _
        """Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""" & _
        "Normal"" me=""Selected"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent" & _
        "=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Hea" & _
        "ding"" me=""RecordSelector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><" & _
        "vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" & _
        "aultRecSelWidth>16</DefaultRecSelWidth></Blob>"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(184, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 456
        Me.Label4.Text = "委托"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbc
        '
        Me.tbc.Controls.Add(Me.tpDept)
        Me.tbc.Controls.Add(Me.tpVoyage)
        Me.tbc.Location = New System.Drawing.Point(2, 0)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(536, 84)
        Me.tbc.TabIndex = 457
        '
        'tpDept
        '
        Me.tpDept.Controls.Add(Me.Label7)
        Me.tpDept.Controls.Add(Me.dtpTimeEnd)
        Me.tpDept.Controls.Add(Me.LbYard)
        Me.tpDept.Controls.Add(Me.Label8)
        Me.tpDept.Controls.Add(Me.dtpTimeBegin)
        Me.tpDept.Controls.Add(Me.lbBegin)
        Me.tpDept.Controls.Add(Me.lbEnd)
        Me.tpDept.Controls.Add(Me.Label1)
        Me.tpDept.Controls.Add(Me.cbDept)
        Me.tpDept.Location = New System.Drawing.Point(4, 21)
        Me.tpDept.Name = "tpDept"
        Me.tpDept.Size = New System.Drawing.Size(528, 59)
        Me.tpDept.TabIndex = 0
        Me.tpDept.Text = "部门统计"
        '
        'cbDept
        '
        Me.cbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDept.Location = New System.Drawing.Point(52, 4)
        Me.cbDept.MaxDropDownItems = 20
        Me.cbDept.Name = "cbDept"
        Me.cbDept.Size = New System.Drawing.Size(120, 20)
        Me.cbDept.TabIndex = 463
        '
        'tpVoyage
        '
        Me.tpVoyage.Controls.Add(Me.txtShipName)
        Me.tpVoyage.Controls.Add(Me.Label9)
        Me.tpVoyage.Controls.Add(Me.txtVoyage)
        Me.tpVoyage.Controls.Add(Me.Label5)
        Me.tpVoyage.Controls.Add(Me.txtShip)
        Me.tpVoyage.Controls.Add(Me.Label6)
        Me.tpVoyage.Location = New System.Drawing.Point(4, 21)
        Me.tpVoyage.Name = "tpVoyage"
        Me.tpVoyage.Size = New System.Drawing.Size(528, 59)
        Me.tpVoyage.TabIndex = 1
        Me.tpVoyage.Text = "船次统计"
        '
        'txtShipName
        '
        Me.txtShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtShipName.Location = New System.Drawing.Point(132, 32)
        Me.txtShipName.MaxLength = 40
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(200, 21)
        Me.txtShipName.TabIndex = 336
        Me.txtShipName.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(100, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 17)
        Me.Label9.TabIndex = 337
        Me.Label9.Text = "船名"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(212, 6)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(120, 21)
        Me.txtVoyage.TabIndex = 332
        Me.txtVoyage.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(180, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 17)
        Me.Label5.TabIndex = 335
        Me.Label5.Text = "航次"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(56, 6)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(120, 21)
        Me.txtShip.TabIndex = 331
        Me.txtShip.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 17)
        Me.Label6.TabIndex = 334
        Me.Label6.Text = "船码"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnIsPrintNoCheckStat
        '
        Me.btnIsPrintNoCheckStat.Location = New System.Drawing.Point(400, 88)
        Me.btnIsPrintNoCheckStat.Name = "btnIsPrintNoCheckStat"
        Me.btnIsPrintNoCheckStat.Size = New System.Drawing.Size(90, 22)
        Me.btnIsPrintNoCheckStat.TabIndex = 462
        Me.btnIsPrintNoCheckStat.Text = "出证未进港"
        '
        'FrmConLoadTallyNew_Total
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(902, 625)
        Me.Controls.Add(Me.btnPartConStat)
        Me.Controls.Add(Me.btnIsPrintNoCheckStat)
        Me.Controls.Add(Me.btnPersonConStat)
        Me.Controls.Add(Me.tbc)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.rbnSave)
        Me.Controls.Add(Me.rbnEdit)
        Me.Controls.Add(Me.C1Total)
        Me.Controls.Add(Me.LbTotal)
        Me.Controls.Add(Me.lb20)
        Me.Controls.Add(Me.lbElse)
        Me.Controls.Add(Me.lb40)
        Me.Controls.Add(Me.txtContainerNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btReport)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadTallyNew_Total"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装拆箱箱信息 统计"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccbClerk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ccbConsign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbc.ResumeLayout(False)
        Me.tpDept.ResumeLayout(False)
        Me.tpVoyage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Enum Stats   '统计表类别名称
        Empty
        PartConStat
        PersonConStat
        IsPrintNoCheckStat
    End Enum
    Dim oldStat As Stats = Stats.Empty
    Dim nowStat As Stats = Stats.Empty
    Class OperStat   '操作的统计表
        Public Shared statName As Stats = Stats.Empty
        Public Shared StatButton As Button = Nothing
        Sub New()

        End Sub
        Sub New(ByVal statOper As Stats, ByVal btnOper As Button)
            statName = statOper
            StatButton = btnOper
        End Sub
    End Class
    Dim lastStat As OperStat
    Dim btnStatLast As Button   '上一次点击的统计按钮

    Public Enum Oper
        None
        Edit
        Save
        Print
    End Enum
    Dim excelOper As Oper = Oper.None   '操作名

    Dim blNext As Boolean '检查执行条件是否满足
    Structure IsChange  '统计条件变化标志
        Dim strDeptOld As String
        Dim dtBeginOld As Date
        Dim dtEndOld As Date
        Dim strShipOld As String
        Dim strVoyageOld As String
        Dim strStatTermOld As String    '统计条件
        Dim strBtnTermOld As String     '按钮附加条件
        Dim blChange As Boolean
        Sub New(ByVal strStatTerm As String, ByVal strDept As String, ByVal dtBegin As Date, ByVal dtEnd As Date)
            Me.strDeptOld = strDept
            Me.dtBeginOld = dtBegin
            Me.dtEndOld = dtEnd
            Me.strShipOld = ""
            Me.strVoyageOld = ""
            Me.strStatTermOld = strStatTerm
            Me.strBtnTermOld = ""
            Me.blChange = True
        End Sub
    End Structure
    Dim changeStat As IsChange

    Dim sqlCount As String
    Dim dvCount As New DataView
    Dim strYard As String
    Dim sqlConTotal As String
    Dim dvConTotal As New DataView
    Dim i As Integer
    Dim strContainer As String
    Dim sum20, sum40, sumElse As Integer
    Dim sqlDept As String
    Dim dvDept As DataView

    Dim sqlClerk As String
    Dim dvClerk As DataView

    Dim sqlConsign As String
    Dim dvConsign As DataView

    Private Sub FrmConLoadTallyNew_Total_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpTimeBegin.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpTimeEnd.CustomFormat = Me.dtpTimeBegin.CustomFormat
        'Me.dtpTimeEnd.CustomFormat = "yyyy'年'MM'月'dd'日'"
        Me.dtpTimeBegin.Value = Now.Date.Add(New TimeSpan(6, 0, 0))
        Me.dtpTimeEnd.Value = Now.Date.Add(New TimeSpan(20, 0, 0))

        Const strDeptCodeHead As String = "26.11.30"
        sqlDept = "SELECT Code_Yard_ID, DeptCode, Code_Yard_Name FROM Code_Yard order by DeptCode,Code_Yard_ID"
        dvDept = Filldata(sqlDept)

        Me.cbDept.DataSource = dvDept

        Me.cbDept.DisplayMember = "Code_Yard_Name"
        Me.cbDept.ValueMember = "DeptCode"
        If G_DeptCode = "26" OrElse G_DeptCode = "26.01" OrElse G_DeptCode = "26.11" OrElse G_DeptCode = strDeptCodeHead OrElse G_DeptCode = "26.11.30.09" Then
            Me.cbDept.Enabled = True
        Else
            dvDept.RowFilter = "DeptCode = '" & G_DeptCode & "'"
            If dvDept.Count = 1 Then
                Me.cbDept.Enabled = False
            ElseIf dvDept.Count > 1 Then
                Me.cbDept.Enabled = True
                dvDept.RowFilter = "DeptCode = '" & G_DeptCode & "' or DeptCode='00'"
            Else
                Me.btnPartConStat.Enabled = False
                Me.btnPersonConStat.Enabled = False
                Me.btnIsPrintNoCheckStat.Enabled = False
            End If
        End If

        sqlClerk = "select A.Name,A.Work_No,A.Tally_Short,B.Dept_Code from Tally_Clerk A join DepartMent B on (subString(A.Dept_Code,3,6)=B.ClerkDept or subString(A.Dept_Code,3,3)=B.ClerkDept) where A.Dept_Code like '2[69].12%' ORDER BY A.NAME, A.DEPT_CODE"
        dvClerk = Filldata(sqlClerk)
        Me.ccbClerk.DataSource = dvClerk
        Me.ccbClerk.DisplayMember = "Name"
        Me.ccbClerk.ValueMember = "Name"
        Me.ccbClerk.ColumnHeaders = False
        Me.ccbClerk.Splits(0).DisplayColumns("Work_No").Visible = False
        Me.ccbClerk.Splits(0).DisplayColumns("Dept_Code").Visible = False
        Me.ccbClerk.Splits(0).DisplayColumns("Name").Width = (Me.ccbClerk.Width - 20) / 2
        Me.ccbClerk.Splits(0).DisplayColumns("Tally_Short").Width = (Me.ccbClerk.Width - 20) / 2
        'Me.ccbClerk.DropDownWidth = Me.ccbClerk.Width

        sqlConsign = "SELECT CODE_SHIP_AGENT, SHIPAGENT_SHORT, SHIPAGENT_ENG FROM CODE_SHIP_AGENT where Mark <> '1' OR Mark IS NULL ORDER BY SHIPAGENT_SHORT"
        dvConsign = Filldata(sqlConsign)
        ccbConsign.DataSource = dvConsign
        ccbConsign.DisplayMember = "SHIPAGENT_SHORT"
        ccbConsign.ValueMember = "CODE_SHIP_AGENT"
        Me.ccbConsign.ColumnHeaders = False
        Me.ccbConsign.Splits(0).DisplayColumns("CODE_SHIP_AGENT").Visible = False
        Me.ccbConsign.Splits(0).DisplayColumns("SHIPAGENT_SHORT").AutoSize()
        Me.ccbConsign.Splits(0).DisplayColumns("SHIPAGENT_ENG").AutoSize()
        Me.ccbConsign.DropDownWidth = Me.ccbConsign.Splits(0).DisplayColumns("SHIPAGENT_SHORT").Width + Me.ccbConsign.Splits(0).DisplayColumns("SHIPAGENT_ENG").Width + 20

        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBG.FetchRowStyles = True
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = Color.CadetBlue
        changeStat = New IsChange(Me.tbc.SelectedTab.Name, "", Me.dtpTimeBegin.Value, Me.dtpTimeEnd.Value)
        lastStat = New OperStat(Stats.Empty, Nothing)
    End Sub
    Private Sub OperCheck(ByRef change As IsChange) '操作检查
        Select Case Me.tbc.SelectedTab.Name
            Case Me.tpDept.Name
                If Me.dtpTimeBegin.Value <= Me.dtpTimeEnd.Value Then
                    blNext = True
                Else
                    MessageBox.Show("开始时间不得晚于结束时间", "提示")
                    Me.dtpTimeBegin.Focus()
                    blNext = False
                End If
                If blNext Then
                    If Me.cbDept.SelectedIndex >= 0 Then
                        If change.strDeptOld <> dvDept(Me.cbDept.SelectedIndex)("Code_Yard_ID") Then
                            change.strDeptOld = dvDept(Me.cbDept.SelectedIndex)("Code_Yard_ID")
                            change.blChange = True
                        End If
                    End If
                    If change.dtBeginOld <> Me.dtpTimeBegin.Value Then
                        change.dtBeginOld = Me.dtpTimeBegin.Value
                        change.blChange = True
                    End If
                    If change.dtEndOld <> Me.dtpTimeEnd.Value Then
                        change.dtEndOld = Me.dtpTimeEnd.Value
                        change.blChange = True
                    End If
                End If
            Case Me.tpVoyage.Name
                If Me.txtShip.Text <> "" Then
                    blNext = True
                Else
                    MessageBox.Show("船名不可空", "提示")
                    Me.txtShip.Focus()
                    blNext = False
                End If
                If blNext Then
                    If Me.txtVoyage.Text <> "" Then
                        blNext = True
                    Else
                        MessageBox.Show("航次不可空", "提示")
                        Me.txtVoyage.Focus()
                        blNext = False
                    End If
                End If
                If blNext Then
                    If change.strShipOld <> Me.txtShip.Text Then
                        change.strShipOld = Me.txtShip.Text
                        change.blChange = True
                    End If
                    If change.strVoyageOld <> Me.txtVoyage.Text Then
                        change.strVoyageOld = Me.txtVoyage.Text
                        change.blChange = True
                    End If
                End If
            Case Else
                Exit Select
        End Select
        If blNext Then
            If change.strStatTermOld <> Me.tbc.SelectedTab.Name Then
                change.strStatTermOld = Me.tbc.SelectedTab.Name
                change.blChange = True
            End If
        End If
        If blNext Then
            Dim strBtnTermNew As String '处理按钮附加条件
            Select Case nowStat
                Case Stats.PartConStat
                    strBtnTermNew = ""
                Case Stats.PersonConStat
                    strBtnTermNew = ""
                Case Stats.IsPrintNoCheckStat   '非外托箱、验箱、空箱、陆桥箱 出证未查验
                    strBtnTermNew = " Checked='0' and printed='1' and WorkType='2' and Ship_Code<>'LQX' and CODE_TALLY_TYPE not in ('0','3','4','5','7') "
                Case Else
                    strBtnTermNew = ""
            End Select
            If change.strBtnTermOld <> strBtnTermNew Then
                change.strBtnTermOld = strBtnTermNew
                change.blChange = True
            End If
        End If
    End Sub

    Private Sub btnPartConStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPartConStat.Click
        nowStat = Stats.PartConStat
        GetStatReport(nowStat, New OperStat(nowStat, sender))
    End Sub

    Private Sub btnPersonConStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPersonConStat.Click
        nowStat = Stats.PersonConStat
        GetStatReport(nowStat, New OperStat(nowStat, sender))
    End Sub

    Private Sub btnIsPrintNoCheckStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIsPrintNoCheckStat.Click
        nowStat = Stats.IsPrintNoCheckStat
        GetStatReport(nowStat, New OperStat(nowStat, sender))
    End Sub

    Dim strClerkFilterOld As String

    Private Sub GetStatReport(ByVal nowStat As Stats, ByVal CurrentStat As OperStat) '获得统计数据
        OperCheck(changeStat)
        If blNext Then
            If changeStat.blChange OrElse IsNothing(dvConTotal) Then   '改变统计条件或者是首次做该报表的统计
                Dim strDynamicTerm As String    '动态查询条件
                Select Case Me.tbc.SelectedTab.Name
                    Case Me.tpDept.Name     '按部门查询
                        strYard = dvDept(Me.cbDept.SelectedIndex)("Code_Yard_ID")
                        Dim strSubTerm As String    '得到部门条件
                        If Me.cbDept.Items.Count > 1 Then
                            If Me.cbDept.SelectedValue <> "00" Then '单个场站
                                Me.LbYard.Text = Me.cbDept.Text
                                strSubTerm = " and CodeYard = '" & strYard & "' "
                                dvClerk.RowFilter = "Dept_Code='" & Me.cbDept.SelectedValue & "'"
                            Else
                                If dvDept.RowFilter = "" Then   '所有的场站
                                    Me.LbYard.Text = "所有部门"
                                    strSubTerm = ""
                                    dvClerk.RowFilter = "Dept_Code='26.11.30.20'"  '其它场站对应所有部门理货员，否则会重复
                                Else    '单个部门多个场站
                                    Me.LbYard.Text = ""
                                    strSubTerm = ""
                                    Dim i As Integer
                                    For i = 1 To dvDept.Count - 1
                                        Me.LbYard.Text += "/" & dvDept(i)("Code_Yard_Name")
                                        strSubTerm += ",'" & dvDept(i)("Code_Yard_ID") & "'"
                                    Next
                                    Me.LbYard.Text = Me.LbYard.Text.Substring(1)
                                    strSubTerm = " and CodeYard in (" & strSubTerm.Substring(1) & ") "
                                    dvClerk.RowFilter = "Dept_Code='" & Me.cbDept.SelectedValue & "'"
                                End If
                            End If
                        Else    '单个部门单个场站
                            Me.LbYard.Text = Me.cbDept.Text
                            strSubTerm = "and CodeYard = '" & strYard & "'"
                            dvClerk.RowFilter = "Dept_Code='" & Me.cbDept.SelectedValue & "'"
                        End If
                        strDynamicTerm = " ConTime>='" & Me.dtpTimeBegin.Value & "' and ConTime<'" & Me.dtpTimeEnd.Value & "' " & strSubTerm
                    Case Me.tpVoyage.Name   '按船次查询
                        strDynamicTerm = " Ship_Code='" & Me.txtShip.Text & "' and Voyage='" & Me.txtVoyage.Text & "' "
                    Case Else
                        Exit Select
                End Select
                If changeStat.strBtnTermOld <> "" Then
                    strDynamicTerm += " and " & changeStat.strBtnTermOld
                End If

                strClerkFilterOld = dvClerk.RowFilter
                Me.lbBegin.Text = Me.dtpTimeBegin.Value.ToString("yyyy-MM-dd HH:mm")
                Me.lbEnd.Text = Me.dtpTimeEnd.Value.ToString("yyyy-MM-dd HH:mm")
                sqlCount = "SELECT COUNT(*) AS ConSum FROM View_StatConLoadYard " & _
                    " WHERE USER_NAME = '" & G_User & "' AND " & strDynamicTerm
                dvCount = Filldata(sqlCount)
                Me.labResult.Text = ""
                Me.labResult.Text = G_User & "录入" & dvCount(0)(0) & "箱"

                Call getConTotal(strDynamicTerm)
                ComputeSum()
                GetSum(strDynamicTerm)
                Me.dtpTimeBegin.Focus()
                Me.ccbClerk.Enabled = True
                Me.ccbConsign.Enabled = True
                changeStat.blChange = False
            End If

            '奇怪的是lastStat自动更新,这里的条件判断总是False,代码不能执行,所以后面重写了改写了这部分
            If lastStat.statName <> CurrentStat.statName Then '改变了统计报表 只影响打印导出 数据源不变
                If lastStat.statName <> Stats.Empty Then    '非首次统计操作
                    lastStat.StatButton.ForeColor = SystemColors.ControlText
                End If
                lastStat.statName = CurrentStat.statName
                lastStat.StatButton = CurrentStat.StatButton
                lastStat.StatButton.ForeColor = Color.Red
            End If
            If oldStat <> nowStat Then
                If oldStat <> Stats.Empty Then
                    btnStatLast.ForeColor = SystemColors.ControlText
                End If
                oldStat = nowStat
                btnStatLast = CurrentStat.StatButton
                btnStatLast.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub getConTotal(ByVal strSubTerm As String)
        'sqlConTotal = "SELECT CONTAINER_NO, BLNO, Code_SHIPNAME.CHI_VESSEL, Voyage, CheckTime, USER_NAME FROM CON_LOAD_TALLY_LIST LEFT OUTER JOIN Code_SHIPNAME ON CON_LOAD_TALLY_LIST.CHI_VESSEL = Code_SHIPNAME.SPCODE " & _
        '        "WHERE (CodeYard = '" & strYard & "') AND (DATEDIFF(mi, CheckTime, '" & Me.dtpTimeBegin.Value & "') <= 0) AND (DATEDIFF(mi, CheckTime, '" & Me.dtpTimeEnd.Value & "') >= 0) " & _
        '        " order by CONTAINER_NO "
        sqlConTotal = "SELECT CodeYard,StateC,Checked,Printed,InOutPort,WorkType,CODE_TALLY_TYPE,CODE_CON_CONSIGN,Ship_Code,CHI_VESSEL,Voyage,BLNO,[NO],SHIPAGENT_SHORT,WorkTypeDesc, " & _
            " NAME_TALLY_TYPE,CONTAINER_NO,SIZE_CON,CONTAINER_TYPE,NEWSEALNO,GoodsCha,AMOUNT,PackDesc,CLERK,ConTime,PrintPerson,PrintTime,USER_NAME,Code_Yard_Name FROM View_StatConLoadYard " & _
            " WHERE " & strSubTerm & " ORDER BY chi_vessel, voyage, NAME_TALLY_TYPE "
        dvConTotal = Filldata(sqlConTotal)
        Me.C1DBG.DataSource = dvConTotal
        Me.C1DBG.Splits(0).DisplayColumns("CodeYard").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("StateC").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("Printed").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("Checked").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("InOutPort").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("WorkType").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("CODE_TALLY_TYPE").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("CODE_CON_CONSIGN").Visible = False
        If Me.cbDept.SelectedValue <> "00" Then
            Me.C1DBG.Splits(0).DisplayColumns("Code_Yard_Name").Visible = False
        End If
        Me.C1DBG.Columns("Ship_Code").Caption = "船码"
        Me.C1DBG.Columns("CHI_VESSEL").Caption = "船名"
        Me.C1DBG.Columns("Voyage").Caption = "航次"
        Me.C1DBG.Columns("BLNO").Caption = "提单号"
        Me.C1DBG.Columns("NO").Caption = "理货单号"
        Me.C1DBG.Columns("SHIPAGENT_SHORT").Caption = "货代"
        Me.C1DBG.Columns("WorkTypeDesc").Caption = "作业"
        Me.C1DBG.Columns("NAME_TALLY_TYPE").Caption = "箱类"
        Me.C1DBG.Columns("CONTAINER_NO").Caption = "箱号"
        Me.C1DBG.Columns("SIZE_CON").Caption = "尺寸"
        Me.C1DBG.Columns("CONTAINER_TYPE").Caption = "箱型"
        Me.C1DBG.Columns("NEWSEALNO").Caption = "铅封"
        Me.C1DBG.Columns("GoodsCha").Caption = "货名"
        Me.C1DBG.Columns("AMOUNT").Caption = "件数"
        Me.C1DBG.Columns("PackDesc").Caption = "包装"
        Me.C1DBG.Columns("Clerk").Caption = "理货员"
        Me.C1DBG.Columns("ConTime").Caption = "装箱时间"
        Me.C1DBG.Columns("PrintPerson").Caption = "出证人"
        Me.C1DBG.Columns("PrintTime").Caption = "出证时间"
        Me.C1DBG.Columns("USER_NAME").Caption = "录入员"
        Me.C1DBG.Columns("Code_Yard_Name").Caption = "场站"
        Me.C1DBG.Columns("ConTime").NumberFormat = "yy-MM-dd HH:mm"
        Me.C1DBG.Columns("PrintTime").NumberFormat = "yy-MM-dd HH:mm"
        SetDGWidth2(Me.C1DBG, 2)
        Me.C1DBG.Columns("Ship_Code").FooterText = "合计"
        Me.C1DBG.Columns("CHI_VESSEL").FooterText = dvConTotal.Count & "项"
    End Sub

    Dim sqlSum As String
    Dim dvSum As DataView
    Private Sub GetSum(ByVal strSubTerm As String)
        Try
            sqlSum = "SELECT StateName, COUNT(*) AS ConSum, SUM([20']) AS [20Sum], SUM([40']) AS [40Sum], SUM([Else]) AS ElseSum" & _
                        " FROM (SELECT CASE WHEN StateC <= '1' THEN '未出证' WHEN StateC >= '2' THEN '出证' END AS StateName, SIZE_CON, " & _
                        " CASE WHEN SIZE_CON = 20 THEN 1 END AS [20'], CASE WHEN SIZE_CON IN (40, 45) THEN 1 END AS [40'], " & _
                        " CASE WHEN SIZE_CON NOT IN (20, 40, 45) or SIZE_CON is null THEN 1 END AS [Else] FROM View_StatConLoadYard " & _
                        " WHERE " & strSubTerm & ") A GROUP BY StateName"
            dvSum = Filldata(sqlSum)
            Me.C1Total.DataSource = dvSum
            Me.C1Total.Columns("StateName").Caption = ""
            Me.C1Total.Columns("ConSum").Caption = "合计"
            Me.C1Total.Columns("20Sum").Caption = "20英尺"
            Me.C1Total.Columns("40Sum").Caption = "40英尺"
            Me.C1Total.Columns("ElseSum").Caption = "其它"
            SetDGWidth2(Me.C1Total, 10)
            Me.C1Total.AllowAddNew = True
            Me.C1Total.Row = dvSum.Count
            Me.C1Total.Columns("StateName").Text = "总计"
            Me.C1Total.Columns("ConSum").Text = GetDataSum(dvSum, "ConSum")
            Me.C1Total.Columns("20Sum").Text = GetDataSum(dvSum, "20Sum")
            Me.C1Total.Columns("40Sum").Text = GetDataSum(dvSum, "40Sum")
            Me.C1Total.Columns("ElseSum").Text = GetDataSum(dvSum, "ElseSum")
            If Me.C1Total.Columns("ConSum").Value = 0 Then
                Me.C1Total.Columns("ConSum").Value = DBNull.Value
            End If
            If Me.C1Total.Columns("20Sum").Value = 0 Then
                Me.C1Total.Columns("20Sum").Value = DBNull.Value
            End If
            If Me.C1Total.Columns("40Sum").Value = 0 Then
                Me.C1Total.Columns("40Sum").Value = DBNull.Value
            End If
            If Me.C1Total.Columns("ElseSum").Value = 0 Then
                Me.C1Total.Columns("ElseSum").Value = DBNull.Value
            End If
            Me.C1Total.Row = 0
            Me.C1Total.AllowAddNew = False
            Me.C1Total.UpdateData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComputeSum()
        sum20 = 0
        sum40 = 0
        sumElse = 0
        Dim i As Integer
        For i = 0 To dvConTotal.Count - 1
            Select Case Me.C1DBG.Columns("SIZE_CON").CellText(i)
                Case 20
                    sum20 += 1
                Case 40, 45
                    sum40 += 1
                Case Else
                    sumElse += 1
            End Select
        Next
        LbTotal.Text = "合计："
        lb20.Text = "20' X "
        lb40.Text = "40' X "
        lbElse.Text = "其它："
        If dvConTotal.Count > 0 Then
            LbTotal.Text = LbTotal.Text & dvConTotal.Count
            If sum20 > 0 Then
                lb20.Text = lb20.Text & sum20
            End If
            If sum40 > 0 Then
                lb40.Text = lb40.Text & sum40
            End If
            If sumElse > 0 Then
                lbElse.Text = lbElse.Text & sumElse
            End If
        End If
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("USER_NAME").CellText(e.Row) = G_User Then
            e.CellStyle.ForeColor = System.Drawing.Color.Green
        End If
        If Me.C1DBG.Columns("Checked").CellText(e.Row) = "1" Then
            e.CellStyle.BackColor = System.Drawing.Color.Cyan
        End If
        'If Me.C1DBG.Columns("StateC").CellText(e.Row) > "2" Then
        '    e.CellStyle.BackColor = System.Drawing.Color.Wheat
        'Else

        'End If
    End Sub

    Private Sub txtContainerNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContainerNo.Leave
        strContainer = Me.txtContainerNo.Text.Trim.ToUpper
        For i = 0 To dvConTotal.Count - 1
            If Me.C1DBG.Columns("CONTAINER_NO").CellText(i) Like "*" & strContainer & "*" Then
                Me.C1DBG.SelectedRows.Clear()
                Me.C1DBG.SelectedRows.Add(i)
                Me.C1DBG.Row = i
            End If
        Next
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtContainerNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContainerNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.C1DBG.Focus()
            Me.txtContainerNo.Focus()
        End If
    End Sub

    Private Sub btReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReport.Click
        If Me.rbnEdit.Checked Then
            excelOper = Oper.Edit
        Else
            excelOper = Oper.Save
        End If
        DealExcel()
        GC.Collect()
    End Sub

    Dim PathStr As String = System.Reflection.Assembly.GetExecutingAssembly.Location
    Private Sub DealExcel()
        Dim xlApp As Excel.Application
        xlApp = New Excel.ApplicationClass
        Dim xlBook As Excel.Workbook
        Dim xlSheet As Excel.Worksheet
        Try
            PathStr = substr(PathStr)
            'DealReport
            Select Case lastStat.statName
                Case Stats.PartConStat
                    DealPartConStat(xlApp, xlBook, xlSheet)
                Case Stats.PersonConStat
                    DealPersonConStat(xlApp, xlBook, xlSheet)
                Case Stats.IsPrintNoCheckStat
                    DealIsPrintNoCheckStat(xlApp, xlBook, xlSheet)
                Case Stats.Empty
                Case Else
            End Select

            If excelOper = Oper.Edit Then   '导出编辑
                xlApp.Visible = True
            ElseIf excelOper = Oper.Save Then '导出保存
                Dim sfDialog As SaveFileDialog = New SaveFileDialog
                sfDialog.FileName = ""
                sfDialog.InitialDirectory = PathStr & "report\"
                If System.IO.Directory.Exists(sfDialog.InitialDirectory) = False Then
                    System.IO.Directory.CreateDirectory(sfDialog.InitialDirectory)
                End If
                sfDialog.RestoreDirectory = True
                sfDialog.AddExtension = True
                sfDialog.DefaultExt = ".xls"
                sfDialog.Filter = "Excel文件(*.xls)|*.xls"
                If sfDialog.ShowDialog() = DialogResult.OK Then
                    xlBook.SaveCopyAs(sfDialog.FileName)
                End If
                xlBook.Close(False, Type.Missing, Type.Missing) '关闭工作簿
                xlApp.Quit()
            ElseIf excelOper = Oper.Print Then '打印
                xlSheet.PrintOut(1, Type.Missing, 1, False, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
                xlBook.Close(False, Type.Missing, Type.Missing) '关闭工作簿
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.DisplayAlerts = False
            xlApp.Quit()
        End Try
    End Sub

    Private Sub DealPartConStat(ByRef xlApp As Excel.Application, ByRef xlBook As Excel.Workbook, ByRef xlSheet As Excel.Worksheet)
        Dim strExcelName As String = "部门装箱统计.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "部门装箱统计"
        xlBook = xlApp.Workbooks.Add(strPath)
        xlSheet = xlBook.Worksheets(strSheetName)

        xlSheet.Cells(5, 3) = Me.LbYard.Text
        xlSheet.Cells(5, "G") = "自 " & Me.lbBegin.Text & "   至 " & Me.lbEnd.Text
        Dim strCurBillNo As String
        Dim i As Integer    '当前页行标
        Dim totalNum As Integer     '总记录数
        totalNum = dvConTotal.Count

        Dim iCurrentRow, iBase As Integer
        iBase = 9
        For i = 0 To totalNum - 1
            iCurrentRow = iBase + i
            xlSheet.Cells(iCurrentRow, 1) = i + 1
            xlSheet.Cells(iCurrentRow, 2) = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
            xlSheet.Cells(iCurrentRow, 3) = Me.C1DBG.Columns("Voyage").CellText(i)

            strCurBillNo = Me.C1DBG.Columns("BLNO").CellText(i)
            If strCurBillNo Like "*[##]" Then
                strCurBillNo = strCurBillNo.Substring(0, strCurBillNo.Length - 2)
            End If
            xlSheet.Cells(iCurrentRow, 4) = strCurBillNo

            xlSheet.Cells(iCurrentRow, 5) = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
            xlSheet.Cells(iCurrentRow, 6) = Me.C1DBG.Columns("SIZE_CON").CellText(i) & Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i)
            xlSheet.Cells(iCurrentRow, 7) = Me.C1DBG.Columns("AMOUNT").CellText(i)
            xlSheet.Cells(iCurrentRow, 8) = Me.C1DBG.Columns("NAME_TALLY_TYPE").CellText(i)
            xlSheet.Cells(iCurrentRow, 9) = Me.C1DBG.Columns("ConTime").CellText(i)
            xlSheet.Cells(iCurrentRow, 10) = Me.C1DBG.Columns("PrintTime").CellText(i)
        Next

        'xlSheet.Cells(9 + i, 1) = "合计：" & dvConTotal.Count
        'xlSheet.Cells(9 + i, 3) = "20'X " & sum20
        'xlSheet.Cells(9 + i, 5) = "40'X " & sum40
        'xlSheet.Cells(9 + i, 7) = "其它：" & sumElse
        xlSheet.Cells(10 + i, "I") = "统计人：" & G_User
        xlSheet.Cells(11 + i, "I") = "统计时间：" & Now().Date
        xlSheet.Cells.Range(xlSheet.Cells(10 + i, "I"), xlSheet.Cells(10 + i, "J")).Merge()
        xlSheet.Cells.Range(xlSheet.Cells(11 + i, "I"), xlSheet.Cells(11 + i, "J")).Merge()

        iCurrentRow += 1
        xlSheet.Cells(iCurrentRow, "E") = "合计"
        xlSheet.Cells(iCurrentRow, "F") = "20英尺"
        xlSheet.Cells(iCurrentRow, "G") = "40英尺"
        xlSheet.Cells(iCurrentRow, "H") = "其它"

        iBase = iCurrentRow + 1
        Dim x As Integer
        For x = 0 To dvSum.Count - 1
            iCurrentRow = iBase + x
            xlSheet.Cells(iCurrentRow, "D") = Me.C1Total.Columns("StateName").CellText(x)
            xlSheet.Cells(iCurrentRow, "E") = Me.C1Total.Columns("ConSum").CellText(x)
            xlSheet.Cells(iCurrentRow, "F") = Me.C1Total.Columns("20Sum").CellText(x)
            xlSheet.Cells(iCurrentRow, "G") = Me.C1Total.Columns("40Sum").CellText(x)
            xlSheet.Cells(iCurrentRow, "H") = Me.C1Total.Columns("ElseSum").CellText(x)
        Next
        xlSheet.Range(xlSheet.Cells(iCurrentRow - dvSum.Count, "D"), xlSheet.Cells(iCurrentRow, "H")).Borders.LineStyle = 1
    End Sub

    Private Sub DealPersonConStat(ByRef xlApp As Excel.Application, ByRef xlBook As Excel.Workbook, ByRef xlSheet As Excel.Worksheet)
        Dim i, j As Integer
        Dim strExcelName As String = "理箱记录.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "Sheet"
        xlBook = xlApp.Workbooks.Add(strPath)
        Dim iMaxPage As Integer = 5     '最大页数
        Dim iRowNum As Integer = 25     '最大行数
        Dim iFactPage As Integer    '实际页数
        Dim iFactRow As Integer     '实际行数
        If dvConTotal.Count <= iMaxPage * iRowNum Then
            iFactPage = Fix((dvConTotal.Count - 1) / iRowNum) + 1
        Else
            iFactPage = iMaxPage
            MessageBox.Show("记录超过" & iMaxPage * iRowNum & "条部分无法导出", "提示")
        End If
        For j = 0 To iFactPage - 1
            xlSheet = xlBook.Worksheets(strSheetName & (j + 1))
            xlSheet.Activate()
            xlSheet.Cells(2, "C") = Me.LbYard.Text
            xlSheet.Cells(2, "H") = Me.dtpTimeBegin.Value.ToString("yyyy年MM月dd日 HH:mm")
            xlSheet.Cells(2, "M") = Me.dtpTimeEnd.Value.ToString("yyyy年MM月dd日 HH:mm")
            xlSheet.Cells(2, "S") = "第" & (j + 1) & "页 共" & iFactPage & "页"

            Dim rowStart As Integer = 6     'Excel中循环起始行位置
            If j < iFactPage - 1 Then
                iFactRow = iRowNum
            Else
                iFactRow = dvConTotal.Count Mod iRowNum
            End If
            For i = 0 To iFactRow - 1
                xlSheet.Cells(rowStart + i, "B") = Me.C1DBG.Columns("SHIPAGENT_SHORT").CellText(i + j * iRowNum)
                xlSheet.Cells(rowStart + i, "C") = Me.C1DBG.Columns("WorkTypeDesc").CellText(i + j * iRowNum)
                xlSheet.Cells(rowStart + i, "D") = Me.C1DBG.Columns("CHI_VESSEL").CellText(i + j * iRowNum)
                xlSheet.Cells(rowStart + i, "F") = Me.C1DBG.Columns("Voyage").CellText(i)
                xlSheet.Cells(rowStart + i, "G") = Me.C1DBG.Columns("BLNO").CellText(i + j * iRowNum)
                xlSheet.Cells(rowStart + i, "J") = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
                xlSheet.Cells(rowStart + i, "L") = Me.C1DBG.Columns("SIZE_CON").CellText(i + j * iRowNum) & Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i + j * iRowNum)
                xlSheet.Cells(rowStart + i, "M") = Me.C1DBG.Columns("NEWSEALNO").CellText(i + j * iRowNum)
                xlSheet.Cells(rowStart + i, "P") = Me.C1DBG.Columns("GoodsCha").CellText(i + j * iRowNum)
                xlSheet.Cells(rowStart + i, "R") = Me.C1DBG.Columns("PackDesc").CellText(i + j * iRowNum)
                xlSheet.Cells(rowStart + i, "S") = Me.C1DBG.Columns("AMOUNT").CellText(i + j * iRowNum)
            Next
            xlSheet.Cells(31, "C") = strClerkOld
        Next
    End Sub

    Private Sub DealIsPrintNoCheckStat(ByRef xlApp As Excel.Application, ByRef xlBook As Excel.Workbook, ByRef xlSheet As Excel.Worksheet)
        Dim i, j As Integer
        Dim strExcelName As String = "出证未进港统计表.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "tally"
        xlBook = xlApp.Workbooks.Add(strPath)
        Dim iMaxPage As Integer = 1     '最大页数
        Dim iRowNum As Integer = 25     '最大行数
        Dim iFactPage As Integer    '实际页数
        Dim iFactRow As Integer     '实际行数
        Dim rowStart As Integer = 9   '循环起始行位置
        If iMaxPage = 1 Then
            iFactPage = iMaxPage
            xlSheet = xlBook.Worksheets(strSheetName)
            xlSheet.Activate()
            Select Case Me.tbc.SelectedTab.Name
                Case Me.tpDept.Name
                    xlSheet.Cells(5, "B") = "起止时间："
                    xlSheet.Cells(5, "C") = Me.lbBegin.Text & "-" & Me.lbEnd.Text
                Case Me.tpVoyage.Name
                    xlSheet.Cells(5, "B") = "船次："
                    xlSheet.Cells(5, "C") = Me.txtShipName.Text & "/" & Me.txtVoyage.Text
            End Select
            xlSheet.Cells(5, "I") = Now

            For i = 0 To dvConTotal.Count - 1
                xlSheet.Cells(rowStart + i, "A") = i + 1
                xlSheet.Cells(rowStart + i, "B") = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
                xlSheet.Cells(rowStart + i, "C") = Me.C1DBG.Columns("Voyage").CellText(i)
                xlSheet.Cells(rowStart + i, "D") = Me.C1DBG.Columns("BLNO").CellText(i)
                xlSheet.Cells(rowStart + i, "E") = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
                xlSheet.Cells(rowStart + i, "F") = Me.C1DBG.Columns("SIZE_CON").CellText(i)
                xlSheet.Cells(rowStart + i, "G") = Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i)
                xlSheet.Cells(rowStart + i, "H") = Me.C1DBG.Columns("Code_Yard_Name").CellText(i)
                xlSheet.Cells(rowStart + i, "I") = Me.C1DBG.Columns("ConTime").CellText(i)
                xlSheet.Cells(rowStart + i, "J") = Me.C1DBG.Columns("PrintTime").CellText(i)
            Next
            xlSheet.Range(xlSheet.Cells(rowStart + i, "A"), xlSheet.Cells(rowStart + i, "J")).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = 1
            If dvConTotal.Count > 0 Then
                xlSheet.Cells(rowStart + i, "B") = Me.lb20.Text
                xlSheet.Cells(rowStart + i, "D") = Me.lb40.Text
                xlSheet.Cells(rowStart + i, "E") = Me.lbElse.Text
            End If
            xlSheet.Cells(rowStart + i, "H") = "统计:"
            xlSheet.Cells(rowStart + i, "I") = G_User
        Else

        End If
    End Sub

    Private Sub FrmConLoadTallyNew_Total_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.dtpTimeBegin.Focused Then
                Me.dtpTimeEnd.Focus()
            ElseIf Me.dtpTimeEnd.Focused Then
                Me.btnPartConStat.Focus()
            ElseIf Me.ccbClerk.Focused Then
                Me.ccbConsign.Focus()
            ElseIf Me.ccbConsign.Focused Then
                Me.ccbClerk.Focus()
            ElseIf Me.txtShip.Focused Then
                Me.txtVoyage.Focus()
            ElseIf Me.txtVoyage.Focused Then
                Me.btnPartConStat.Focus()
            End If
        End If
    End Sub

    Dim strClerkOld As String
    Private Sub ccbClerk_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ccbClerk.Leave
        If ccbClerk.SelectedIndex = -1 Then     '当为用户输入，且可能是助记码时检查
            If dvClerk.RowFilter <> strClerkFilterOld Then
                Dim strValue As String
                If Me.ccbClerk.SelectedIndex = -1 Then
                    Me.ccbClerk.Text = Me.ccbClerk.Text.Trim.ToUpper    '这个赋值语句必须在RowFilter之前写，否则会导致RowFilter还原
                End If
                strValue = Me.ccbClerk.Text     '暂存一下，否则改变RowFilter会令SelectedIndex变为-1
                dvClerk.RowFilter = strClerkFilterOld
                Me.ccbClerk.Text = strValue
                If Me.ccbClerk.SelectedIndex < 0 AndAlso Me.ccbClerk.Text <> "" Then
                    Dim i As Integer
                    i = Me.ccbClerk.FindString(Me.ccbClerk.Text, 0, "Tally_Short")
                    Me.ccbClerk.SelectedIndex = i
                End If
            Else
                If Me.ccbClerk.SelectedIndex = -1 Then
                    Me.ccbClerk.Text = Me.ccbClerk.Text.Trim.ToUpper
                    If Me.ccbClerk.SelectedIndex < 0 AndAlso Me.ccbClerk.Text <> "" Then
                        Dim i As Integer
                        i = Me.ccbClerk.FindString(Me.ccbClerk.Text, 0, "Tally_Short")
                        Me.ccbClerk.SelectedIndex = i
                    End If
                End If
            End If
            If ccbClerk.SelectedIndex = -1 Then     '筛选Grid
                ccbClerk_SelectedValueChanged(sender, e)
            End If
        Else
            If dvClerk.RowFilter <> strClerkFilterOld Then
                strClerkOld = Me.ccbClerk.Text
                dvClerk.RowFilter = strClerkFilterOld
                Me.ccbClerk.Text = strClerkOld
            End If
        End If
        strClerkOld = Me.ccbClerk.Text
    End Sub

    Dim strFilterClerk, strFilterAgent As String

    Private Sub ccbClerk_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ccbClerk.SelectedValueChanged
        If Me.ccbClerk.SelectedIndex >= 0 Then
            strFilterClerk = " Clerk='" & Me.ccbClerk.Text & "' "
        Else
            If Me.ccbClerk.Text <> "" Then
                strFilterClerk = " Clerk='" & Me.ccbClerk.Text & "' "
            Else
                strFilterClerk = ""
            End If
        End If
        FilterData()
    End Sub

    Private Sub ccbClerk_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ccbClerk.TextChanged
        If Me.ccbClerk.SelectedIndex < 0 Then
            If Me.ccbClerk.Text Like "[a-zA-Z]*" Then
                If strClerkFilterOld <> "" Then
                    dvClerk.RowFilter += " and Tally_Short like '" & Me.ccbClerk.Text.Trim.ToUpper & "%'"
                Else
                    dvClerk.RowFilter = " Tally_Short like '" & Me.ccbClerk.Text.Trim.ToUpper & "%'"
                End If
            Else
                dvClerk.RowFilter = strClerkFilterOld
            End If
        End If
    End Sub

    Dim strAgentOld As String
    Private Sub ccbConsign_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ccbConsign.Leave
        If ccbConsign.SelectedIndex = -1 Then     '当为用户输入，且可能是助记码时检查
            If dvConsign.RowFilter <> "" Then
                Dim strValue As String
                If Me.ccbConsign.SelectedIndex = -1 Then
                    Me.ccbConsign.Text = Me.ccbConsign.Text.Trim.ToUpper    '这个赋值语句必须在RowFilter之前写，否则会导致RowFilter还原
                End If
                strValue = Me.ccbConsign.Text     '暂存一下，否则改变RowFilter会令SelectedIndex变为-1
                dvConsign.RowFilter = ""
                Me.ccbConsign.Text = strValue
                If Me.ccbConsign.SelectedIndex < 0 AndAlso Me.ccbConsign.Text <> "" Then
                    Dim i As Integer
                    i = Me.ccbConsign.FindString(Me.ccbConsign.Text, 0, "SHIPAGENT_ENG")
                    Me.ccbConsign.SelectedIndex = i
                End If
            Else
                If Me.ccbConsign.SelectedIndex = -1 Then
                    Me.ccbConsign.Text = Me.ccbConsign.Text.Trim.ToUpper
                    If Me.ccbConsign.SelectedIndex < 0 AndAlso Me.ccbConsign.Text <> "" Then
                        Dim i As Integer
                        i = Me.ccbConsign.FindString(Me.ccbConsign.Text, 0, "SHIPAGENT_ENG")
                        Me.ccbConsign.SelectedIndex = i
                    End If
                End If
            End If
            If ccbConsign.SelectedIndex = -1 Then   '筛选Grid
                ccbConsign_SelectedValueChanged(sender, e)
            End If
        Else
            If dvConsign.RowFilter <> "" Then
                strAgentOld = Me.ccbConsign.Text
                dvConsign.RowFilter = ""
                Me.ccbConsign.Text = strAgentOld
            End If
        End If
        strAgentOld = Me.ccbConsign.Text
    End Sub

    Private Sub ccbConsign_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ccbConsign.SelectedValueChanged
        If Me.ccbConsign.SelectedIndex >= 0 Then
            strFilterAgent = " SHIPAGENT_SHORT='" & Me.ccbConsign.Text & "' "
        Else
            If Me.ccbConsign.Text <> "" Then
                strFilterAgent = " SHIPAGENT_SHORT='" & Me.ccbConsign.Text & "' "
            Else
                strFilterAgent = ""
            End If
        End If
        FilterData()
    End Sub

    Private Sub ccbConsign_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ccbConsign.TextChanged
        If Me.ccbConsign.SelectedIndex < 0 Then
            If Me.ccbConsign.Text Like "[a-zA-Z]*" Then
                dvConsign.RowFilter = "SHIPAGENT_ENG like '" & Me.ccbConsign.Text.Trim.ToUpper & "%'"
            Else
                dvConsign.RowFilter = ""
            End If
        End If
    End Sub

    Private Sub FilterData()
        dvConTotal.RowFilter = strFilterClerk
        If strFilterAgent <> "" Then
            If dvConTotal.RowFilter <> "" Then
                dvConTotal.RowFilter += " and " & strFilterAgent
            Else
                dvConTotal.RowFilter = strFilterAgent
            End If
        End If
        Me.C1DBG.Columns("CHI_VESSEL").FooterText = dvConTotal.Count & "项"
    End Sub

    Dim sqlShipCode As String
    Dim dvShipCode As New DataView
    Dim shipMark As Boolean
    Dim strShipEng As String

    Private Sub txtShip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtShip.Leave
        Me.txtShip.Text = Me.txtShip.Text.Trim.ToUpper
        sqlShipCode = "SELECT SPCODE, CHI_VESSEL,Eng_VESSEL FROM Code_SHIPNAME WHERE (SPCODE = '" & Me.txtShip.Text & "' or CHI_VESSEL = '" & Me.txtShip.Text & "')"
        dvShipCode = Filldata(sqlShipCode)
        txtShipName.Clear()
        If dvShipCode.Count > 0 Then
            Me.txtShip.Text = dvShipCode(0)("SPCODE")
            If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                Me.txtShipName.Text = dvShipCode(0)("CHI_VESSEL")
            End If
            If Not IsDBNull(dvShipCode(0)("Eng_VESSEL")) Then
                strShipEng = dvShipCode(0)("Eng_VESSEL")
                Me.txtShipName.Text += "/" & dvShipCode(0)("ENG_VESSEL")
            Else
                strShipEng = ""
            End If
            shipMark = True
        Else
            shipMark = False
        End If
    End Sub

    Private Sub tbc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbc.Click
        Select Case Me.tbc.SelectedTab.Name
            Case Me.tpDept.Name
                Me.cbDept.Focus()
            Case Me.tpVoyage.Name
                Me.txtShip.Focus()
            Case Else
                Exit Select
        End Select
    End Sub

End Class
