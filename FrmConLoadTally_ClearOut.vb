Imports TALLY.DBControl
Public Class FrmConLoadTally_ClearOut
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtConSum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRecordSum As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lbShow As System.Windows.Forms.Label
    Friend WithEvents lbClearSum As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFinishSum As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtUnFinishSum As System.Windows.Forms.TextBox
    Friend WithEvents txtAfterMost As System.Windows.Forms.TextBox
    Friend WithEvents txtForeMost As System.Windows.Forms.TextBox
    Friend WithEvents ckbEnsure As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadTally_ClearOut))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtConSum = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRecordSum = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.lbShow = New System.Windows.Forms.Label
        Me.lbClearSum = New System.Windows.Forms.Label
        Me.txtUnFinishSum = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFinishSum = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtAfterMost = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtForeMost = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ckbEnsure = New System.Windows.Forms.CheckBox
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 461)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "船码"
        '
        'txtShip
        '
        Me.txtShip.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtShip.Location = New System.Drawing.Point(42, 459)
        Me.txtShip.Name = "txtShip"
        Me.txtShip.TabIndex = 7
        Me.txtShip.Text = ""
        '
        'txtVoyage
        '
        Me.txtVoyage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVoyage.Location = New System.Drawing.Point(42, 485)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.TabIndex = 9
        Me.txtVoyage.Text = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 487)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "航次"
        '
        'txtShipName
        '
        Me.txtShipName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtShipName.Location = New System.Drawing.Point(178, 459)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(202, 21)
        Me.txtShipName.TabIndex = 8
        Me.txtShipName.Text = ""
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 461)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "船名"
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(294, 516)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(66, 22)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "清除(&C)"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(366, 516)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 22)
        Me.btnExit.TabIndex = 594
        Me.btnExit.Text = "退出(&X)"
        '
        'txtConSum
        '
        Me.txtConSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtConSum.BackColor = System.Drawing.Color.Lavender
        Me.txtConSum.Location = New System.Drawing.Point(178, 485)
        Me.txtConSum.Name = "txtConSum"
        Me.txtConSum.ReadOnly = True
        Me.txtConSum.Size = New System.Drawing.Size(78, 21)
        Me.txtConSum.TabIndex = 596
        Me.txtConSum.Text = ""
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 487)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 595
        Me.Label3.Text = "箱数"
        '
        'txtRecordSum
        '
        Me.txtRecordSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRecordSum.BackColor = System.Drawing.Color.Lavender
        Me.txtRecordSum.Location = New System.Drawing.Point(302, 485)
        Me.txtRecordSum.Name = "txtRecordSum"
        Me.txtRecordSum.ReadOnly = True
        Me.txtRecordSum.Size = New System.Drawing.Size(78, 21)
        Me.txtRecordSum.TabIndex = 598
        Me.txtRecordSum.Text = ""
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 487)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 597
        Me.Label5.Text = "记录数"
        '
        'C1DBG
        '
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(680, 455)
        Me.C1DBG.TabIndex = 599
        Me.C1DBG.Text = "C1TrueDBGrid1"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "=""1""><Height>451</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 676, 451</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 676, 451</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'lbShow
        '
        Me.lbShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbShow.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbShow.ForeColor = System.Drawing.Color.Green
        Me.lbShow.Location = New System.Drawing.Point(542, 516)
        Me.lbShow.Name = "lbShow"
        Me.lbShow.Size = New System.Drawing.Size(100, 20)
        Me.lbShow.TabIndex = 600
        '
        'lbClearSum
        '
        Me.lbClearSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbClearSum.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbClearSum.ForeColor = System.Drawing.Color.Green
        Me.lbClearSum.Location = New System.Drawing.Point(10, 516)
        Me.lbClearSum.Name = "lbClearSum"
        Me.lbClearSum.Size = New System.Drawing.Size(100, 20)
        Me.lbClearSum.TabIndex = 601
        '
        'txtUnFinishSum
        '
        Me.txtUnFinishSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnFinishSum.BackColor = System.Drawing.Color.Lavender
        Me.txtUnFinishSum.Location = New System.Drawing.Point(560, 486)
        Me.txtUnFinishSum.Name = "txtUnFinishSum"
        Me.txtUnFinishSum.ReadOnly = True
        Me.txtUnFinishSum.Size = New System.Drawing.Size(84, 21)
        Me.txtUnFinishSum.TabIndex = 605
        Me.txtUnFinishSum.Text = ""
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(516, 488)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 604
        Me.Label6.Text = "未导数"
        '
        'txtFinishSum
        '
        Me.txtFinishSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFinishSum.BackColor = System.Drawing.Color.Lavender
        Me.txtFinishSum.Location = New System.Drawing.Point(430, 486)
        Me.txtFinishSum.Name = "txtFinishSum"
        Me.txtFinishSum.ReadOnly = True
        Me.txtFinishSum.Size = New System.Drawing.Size(84, 21)
        Me.txtFinishSum.TabIndex = 603
        Me.txtFinishSum.Text = ""
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(386, 488)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 602
        Me.Label7.Text = "完成数"
        '
        'txtAfterMost
        '
        Me.txtAfterMost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAfterMost.BackColor = System.Drawing.Color.Lavender
        Me.txtAfterMost.Location = New System.Drawing.Point(560, 460)
        Me.txtAfterMost.Name = "txtAfterMost"
        Me.txtAfterMost.ReadOnly = True
        Me.txtAfterMost.Size = New System.Drawing.Size(84, 21)
        Me.txtAfterMost.TabIndex = 609
        Me.txtAfterMost.Text = ""
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(516, 462)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 17)
        Me.Label8.TabIndex = 608
        Me.Label8.Text = "最晚"
        '
        'txtForeMost
        '
        Me.txtForeMost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtForeMost.BackColor = System.Drawing.Color.Lavender
        Me.txtForeMost.Location = New System.Drawing.Point(430, 460)
        Me.txtForeMost.Name = "txtForeMost"
        Me.txtForeMost.ReadOnly = True
        Me.txtForeMost.Size = New System.Drawing.Size(84, 21)
        Me.txtForeMost.TabIndex = 607
        Me.txtForeMost.Text = ""
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(386, 462)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 17)
        Me.Label9.TabIndex = 606
        Me.Label9.Text = "最早"
        '
        'ckbEnsure
        '
        Me.ckbEnsure.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckbEnsure.Checked = True
        Me.ckbEnsure.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbEnsure.Location = New System.Drawing.Point(174, 516)
        Me.ckbEnsure.Name = "ckbEnsure"
        Me.ckbEnsure.Size = New System.Drawing.Size(104, 20)
        Me.ckbEnsure.TabIndex = 610
        Me.ckbEnsure.Text = "清除确认提示"
        '
        'FrmConLoadTally_ClearOut
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(680, 543)
        Me.Controls.Add(Me.ckbEnsure)
        Me.Controls.Add(Me.txtAfterMost)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtForeMost)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtUnFinishSum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFinishSum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbClearSum)
        Me.Controls.Add(Me.lbShow)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.txtRecordSum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtConSum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtShip)
        Me.Controls.Add(Me.txtVoyage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtShipName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadTally_ClearOut"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "清除外部数据"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlListShip As String
    Dim dvListShip As DataView
    Dim sqlShipCode As String
    Dim dvShipCode As New DataView
    Dim blFind As Boolean = True
    Dim strShip, strVoyage As String

    Private Sub FrmConLoadTally_ClearOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        db_rp.connstr = conn_rp '外理报文专用

        sqlListShip = "SELECT CODE_VESSEL,Max(VESSEL) VESSEL,Max(CHI_VESSEL) CHI_VESSEL,VOYAGE,COUNT(DISTINCT CTN_NO) ConSum,COUNT(*) RecordSum, " & _
            " COUNT(CASE ImportMark WHEN '1' THEN ImportMark END) FinishSum,COUNT(CASE ImportMark WHEN '0' THEN ImportMark END) UnFinishSum, " & _
            " MIN(CTN_STUFFINGTIME) ForeMost,MAX(CTN_STUFFINGTIME) AfterMost " & _
            " FROM TB_CONLOAD_CON A LEFT JOIN Code_SHIPNAME B ON CODE_VESSEL=SPCODE GROUP BY CODE_VESSEL,VOYAGE ORDER BY CODE_VESSEL,VOYAGE "
        dvListShip = db_rp.Filldata(sqlListShip)
        Me.C1DBG.DataSource = dvListShip
        Me.C1DBG.Columns("CODE_VESSEL").Caption = "船码"
        Me.C1DBG.Columns("VESSEL").Caption = "英船名"
        Me.C1DBG.Columns("CHI_VESSEL").Caption = "中船名"
        Me.C1DBG.Columns("VOYAGE").Caption = "航次"
        Me.C1DBG.Columns("ConSum").Caption = "箱数"
        Me.C1DBG.Columns("RecordSum").Caption = "记录数"
        Me.C1DBG.Columns("FinishSum").Caption = "完成数"
        Me.C1DBG.Columns("UnFinishSum").Caption = "未导数"
        Me.C1DBG.Columns("ForeMost").Caption = "最早"
        Me.C1DBG.Columns("AfterMost").Caption = "最晚"
        SetDGWidth3(Me.C1DBG)
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = Color.CadetBlue
        Me.C1DBG.Columns("CODE_VESSEL").FooterText = "计" & dvListShip.Count & "项"
        Dim C1Style As New C1.Win.C1TrueDBGrid.Style
        C1Style.Font = New Font(Me.C1DBG.Font, FontStyle.Bold)
        C1Style.BackColor = Color.Bisque
        C1Style.ForeColor = Color.MidnightBlue
        Me.C1DBG.AddCellStyle(C1.Win.C1TrueDBGrid.CellStyleFlag.CurrentCell, C1Style)
    End Sub

    Private Sub txtShip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtShip.Leave
        Me.txtShip.Text = Me.txtShip.Text.Trim.ToUpper
        If strShip <> Me.txtShip.Text Then
            strShip = Me.txtShip.Text
            sqlShipCode = "SELECT SPCODE, CHI_VESSEL,Eng_VESSEL FROM Code_SHIPNAME WHERE (SPCODE = '" & Me.txtShip.Text & "' or CHI_VESSEL = '" & Me.txtShip.Text & "')"
            dvShipCode = Filldata(sqlShipCode)
            txtShipName.Clear()
            If dvShipCode.Count > 0 Then
                Me.txtShip.Text = dvShipCode(0)("SPCODE")
                If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                    Me.txtShipName.Text = dvShipCode(0)("CHI_VESSEL")
                End If
                If Not IsDBNull(dvShipCode(0)("ENG_VESSEL")) Then
                    Me.txtShipName.Text += "/" & dvShipCode(0)("ENG_VESSEL")
                End If
            End If
            FindData()
        End If
    End Sub

    Private Sub txtVoyage_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVoyage.Leave
        txtVoyage.Text = txtVoyage.Text.Trim.ToUpper
        If strVoyage <> Me.txtVoyage.Text Then
            strVoyage = Me.txtVoyage.Text
            FindData()
        End If
    End Sub

    Private Sub FindData()
        If Me.txtShip.Text <> "" AndAlso Me.txtVoyage.Text <> "" Then
            'Dim sqlGetConSum As String
            'Dim dvGetConSum As DataView
            'sqlGetConSum = "SELECT COUNT(DISTINCT CTN_NO) ConSum, COUNT(*) RecordSum FROM TB_CONLOAD_CON WHERE CODE_VESSEL = '" & Me.txtShip.Text & "' AND VOYAGE = '" & Me.txtVoyage.Text & "'"
            'dvGetConSum = Filldata(sqlGetConSum)
            'If dvGetConSum.Count > 0 Then
            '    Me.txtConSum.Text = dvGetConSum(0)("ConSum")
            '    Me.txtRecordSum.Text = dvGetConSum(0)("RecordSum")
            'End If
            'blFind = True
            Dim i As Integer
            For i = 0 To dvListShip.Count - 1
                If Me.C1DBG.Columns("CODE_VESSEL").CellText(i) = strShip AndAlso Me.C1DBG.Columns("VOYAGE").CellText(i) = strVoyage Then
                    Me.C1DBG.Row = i
                    Exit For
                End If
            Next
            If i < dvListShip.Count Then
                blFind = True
                Me.lbShow.Text = "找到数据"
            Else
                Me.txtConSum.Clear()
                Me.txtRecordSum.Clear()
                blFind = False
                Me.lbShow.Text = "没找到"
            End If
        Else
            Me.txtConSum.Clear()
            Me.txtRecordSum.Clear()
            blFind = False
            Me.lbShow.Text = "没找到"
        End If

    End Sub

    Dim iClearSum As Integer

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If blFind Then
            If Me.ckbEnsure.Checked = False OrElse MessageBox.Show("确定要删除所有该船次的外部数据吗？", "警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                Dim sqlClearOut As String
                sqlClearOut = "Exec Sp_TbConLoad_Del '" & Me.txtShip.Text & "','" & Me.txtVoyage.Text & "'"
                db_rp.ExecSql(sqlClearOut)
                Me.lbShow.Text = "清除成功"
                If Me.C1DBG.Columns("CODE_VESSEL").Text = strShip AndAlso Me.C1DBG.Columns("VOYAGE").Text = strVoyage Then
                    Me.C1DBG.Delete()
                    C1DBG_AfterDelete(sender, e)
                End If
                blFind = False
                iClearSum += 1
                Me.lbClearSum.Text = "清除" & iClearSum & "船次"
                RefleshShow()
            End If
        Else
            Me.txtShip.Focus()
            MessageBox.Show("请确定清除船次", "提示")
        End If
    End Sub

    Private Sub txtShip_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShip.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtVoyage.Focus()
        End If
    End Sub

    Private Sub txtVoyage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoyage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnClear.Focus()
        End If
    End Sub

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
        If e.LastRow <> Me.C1DBG.Row Then
            RefleshShow()
            Me.C1DBG.Columns("VESSEL").FooterText = "第" & (Me.C1DBG.Row + 1) & "行"
        End If
    End Sub

    Private Sub RefleshShow()   '刷新显示信息
        Me.txtShip.Text = Me.C1DBG.Columns("CODE_VESSEL").Text
        Me.txtVoyage.Text = Me.C1DBG.Columns("VOYAGE").Text
        Me.txtConSum.Text = Me.C1DBG.Columns("ConSum").Text
        Me.txtRecordSum.Text = Me.C1DBG.Columns("RecordSum").Text
        Dim dtTime As DateTime
        dtTime = Me.C1DBG.Columns("ForeMost").Value
        Me.txtForeMost.Text = dtTime.ToString("yyyyMMdd HHmm")
        dtTime = Me.C1DBG.Columns("AfterMost").Value
        Me.txtAfterMost.Text = dtTime.ToString("yyyyMMdd HHmm")
        Me.txtFinishSum.Text = Me.C1DBG.Columns("FinishSum").Text
        Me.txtUnFinishSum.Text = Me.C1DBG.Columns("UnFinishSum").Text
        Me.txtShipName.Text = Me.C1DBG.Columns("CHI_VESSEL").Text
        If Me.txtShipName.Text.Trim <> "" Then
            If Me.C1DBG.Columns("VESSEL").Text.Trim <> "" Then
                Me.txtShipName.Text += "/" & Me.C1DBG.Columns("VESSEL").Text
            End If
        Else
            Me.txtShipName.Text += Me.C1DBG.Columns("VESSEL").Text
        End If
        strShip = Me.txtShip.Text
        strVoyage = Me.txtVoyage.Text
        blFind = True
        Me.lbShow.Text = "找到数据"
    End Sub

    Private Sub C1DBG_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterDelete
        Me.C1DBG.Columns("CODE_VESSEL").FooterText = "计" & dvListShip.Count & "项"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnFinishSum.TextChanged

    End Sub
End Class
