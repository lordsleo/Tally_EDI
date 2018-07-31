Imports TALLY.DBControl
Imports System.Web.Mail
Imports System.IO
Imports Microsoft.VisualBasic
Public Class FrmConLoadFinal_Report
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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents lbShipCode As System.Windows.Forms.Label
    Friend WithEvents lbShipName As System.Windows.Forms.Label
    Friend WithEvents lbVoyage As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cbEmail As System.Windows.Forms.ComboBox
    Friend WithEvents Send As System.Windows.Forms.Button
    Friend WithEvents btRead As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnStatis As System.Windows.Forms.Button
    Friend WithEvents tbcStatis As System.Windows.Forms.TabControl
    Friend WithEvents tbpSummary As System.Windows.Forms.TabPage
    Friend WithEvents tbpDetail As System.Windows.Forms.TabPage
    Friend WithEvents tbpCon As System.Windows.Forms.TabPage
    Friend WithEvents C1Sum As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1Bill As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1Con As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1BillCon As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1Extra As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1ExtraTotal As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Splitter3 As System.Windows.Forms.Splitter
    Friend WithEvents C1StateTotal As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1State As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lbConTotal As System.Windows.Forms.Label
    Friend WithEvents lbExplain As System.Windows.Forms.Label
    Friend WithEvents rbnReadCheck As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadFinal_Report))
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btSave = New System.Windows.Forms.Button
        Me.btQuit = New System.Windows.Forms.Button
        Me.lbShipCode = New System.Windows.Forms.Label
        Me.lbShipName = New System.Windows.Forms.Label
        Me.lbVoyage = New System.Windows.Forms.Label
        Me.btnTotal = New System.Windows.Forms.Button
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.cbEmail = New System.Windows.Forms.ComboBox
        Me.Send = New System.Windows.Forms.Button
        Me.btRead = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnStatis = New System.Windows.Forms.Button
        Me.tbcStatis = New System.Windows.Forms.TabControl
        Me.tbpSummary = New System.Windows.Forms.TabPage
        Me.lbConTotal = New System.Windows.Forms.Label
        Me.lbExplain = New System.Windows.Forms.Label
        Me.C1Sum = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpDetail = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.C1Con = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1Bill = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.C1BillCon = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpCon = New System.Windows.Forms.TabPage
        Me.Splitter3 = New System.Windows.Forms.Splitter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.C1Extra = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1ExtraTotal = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.C1State = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1StateTotal = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.rbnReadCheck = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcStatis.SuspendLayout()
        Me.tbpSummary.SuspendLayout()
        CType(Me.C1Sum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpDetail.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.C1Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Bill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.C1BillCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpCon.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.C1Extra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ExtraTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.C1State, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1StateTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBG
        '
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 28)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.RecordSelectorWidth = 17
        Me.C1DBG.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBG.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.Size = New System.Drawing.Size(240, 438)
        Me.C1DBG.TabIndex = 667
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{Font:Arial, 9pt;}HighlightRow{ForeColor:HighlightText;BackCol" & _
        "or:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Headin" & _
        "g{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Bac" & _
        "kColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style" & _
        "1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=" & _
        """18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBo" & _
        "rder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" Horiz" & _
        "ontalScrollGroup=""1""><ClientRect>0, 0, 236, 434</ClientRect><BorderSide>0</Borde" & _
        "rSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" " & _
        "me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle paren" & _
        "t=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupSt" & _
        "yle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><" & _
        "HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Ina" & _
        "ctive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorS" & _
        "tyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=" & _
        """Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 236, 434</ClientArea><PrintPageHeaderStyle pare" & _
        "nt="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(4, 548)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(62, 22)
        Me.btSave.TabIndex = 669
        Me.btSave.Text = "生成报文"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(188, 548)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(58, 22)
        Me.btQuit.TabIndex = 670
        Me.btQuit.Text = "退出"
        '
        'lbShipCode
        '
        Me.lbShipCode.BackColor = System.Drawing.Color.Lavender
        Me.lbShipCode.Location = New System.Drawing.Point(2, 4)
        Me.lbShipCode.Name = "lbShipCode"
        Me.lbShipCode.Size = New System.Drawing.Size(78, 20)
        Me.lbShipCode.TabIndex = 722
        Me.lbShipCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbShipName
        '
        Me.lbShipName.BackColor = System.Drawing.Color.Lavender
        Me.lbShipName.Location = New System.Drawing.Point(82, 4)
        Me.lbShipName.Name = "lbShipName"
        Me.lbShipName.Size = New System.Drawing.Size(78, 20)
        Me.lbShipName.TabIndex = 723
        Me.lbShipName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbVoyage
        '
        Me.lbVoyage.BackColor = System.Drawing.Color.Lavender
        Me.lbVoyage.Location = New System.Drawing.Point(162, 4)
        Me.lbVoyage.Name = "lbVoyage"
        Me.lbVoyage.Size = New System.Drawing.Size(78, 20)
        Me.lbVoyage.TabIndex = 724
        Me.lbVoyage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(108, 472)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(64, 22)
        Me.btnTotal.TabIndex = 726
        Me.btnTotal.Text = "全部"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(62, 520)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(172, 21)
        Me.txtFile.TabIndex = 731
        Me.txtFile.Text = ""
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(8, 500)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(54, 16)
        Me.Label39.TabIndex = 730
        Me.Label39.Text = "收文用户"
        '
        'cbEmail
        '
        Me.cbEmail.Location = New System.Drawing.Point(62, 498)
        Me.cbEmail.Name = "cbEmail"
        Me.cbEmail.Size = New System.Drawing.Size(172, 20)
        Me.cbEmail.TabIndex = 729
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(128, 548)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(58, 22)
        Me.Send.TabIndex = 728
        Me.Send.Text = "发送"
        '
        'btRead
        '
        Me.btRead.Location = New System.Drawing.Point(68, 548)
        Me.btRead.Name = "btRead"
        Me.btRead.Size = New System.Drawing.Size(58, 22)
        Me.btRead.TabIndex = 727
        Me.btRead.Text = "查看"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 522)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 18)
        Me.Label1.TabIndex = 732
        Me.Label1.Text = "文件路径"
        '
        'btnStatis
        '
        Me.btnStatis.Location = New System.Drawing.Point(178, 472)
        Me.btnStatis.Name = "btnStatis"
        Me.btnStatis.Size = New System.Drawing.Size(64, 22)
        Me.btnStatis.TabIndex = 733
        Me.btnStatis.Text = "统计"
        '
        'tbcStatis
        '
        Me.tbcStatis.Controls.Add(Me.tbpSummary)
        Me.tbcStatis.Controls.Add(Me.tbpDetail)
        Me.tbcStatis.Controls.Add(Me.tbpCon)
        Me.tbcStatis.Dock = System.Windows.Forms.DockStyle.Right
        Me.tbcStatis.Location = New System.Drawing.Point(248, 0)
        Me.tbcStatis.Name = "tbcStatis"
        Me.tbcStatis.SelectedIndex = 0
        Me.tbcStatis.Size = New System.Drawing.Size(546, 575)
        Me.tbcStatis.TabIndex = 734
        '
        'tbpSummary
        '
        Me.tbpSummary.Controls.Add(Me.lbConTotal)
        Me.tbpSummary.Controls.Add(Me.lbExplain)
        Me.tbpSummary.Controls.Add(Me.C1Sum)
        Me.tbpSummary.Location = New System.Drawing.Point(4, 21)
        Me.tbpSummary.Name = "tbpSummary"
        Me.tbpSummary.Size = New System.Drawing.Size(538, 550)
        Me.tbpSummary.TabIndex = 0
        Me.tbpSummary.Text = "分港汇总"
        '
        'lbConTotal
        '
        Me.lbConTotal.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbConTotal.Location = New System.Drawing.Point(6, 402)
        Me.lbConTotal.Name = "lbConTotal"
        Me.lbConTotal.Size = New System.Drawing.Size(324, 23)
        Me.lbConTotal.TabIndex = 670
        Me.lbConTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbExplain
        '
        Me.lbExplain.Location = New System.Drawing.Point(6, 428)
        Me.lbExplain.Name = "lbExplain"
        Me.lbExplain.Size = New System.Drawing.Size(466, 76)
        Me.lbExplain.TabIndex = 669
        '
        'C1Sum
        '
        Me.C1Sum.CaptionHeight = 18
        Me.C1Sum.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1Sum.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Sum.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Sum.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1Sum.Location = New System.Drawing.Point(0, 0)
        Me.C1Sum.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1Sum.Name = "C1Sum"
        Me.C1Sum.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Sum.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Sum.PreviewInfo.ZoomFactor = 75
        Me.C1Sum.RecordSelectorWidth = 17
        Me.C1Sum.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Sum.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1Sum.RowHeight = 16
        Me.C1Sum.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Sum.Size = New System.Drawing.Size(538, 396)
        Me.C1Sum.TabIndex = 668
        Me.C1Sum.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{Font:Arial, 9pt;}HighlightRow{ForeColor:HighlightText;BackCol" & _
        "or:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Headin" & _
        "g{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Al" & _
        "ignVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style" & _
        "9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=" & _
        """18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBo" & _
        "rder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" Horiz" & _
        "ontalScrollGroup=""1""><ClientRect>0, 0, 534, 392</ClientRect><BorderSide>0</Borde" & _
        "rSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" " & _
        "me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle paren" & _
        "t=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupSt" & _
        "yle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><" & _
        "HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Ina" & _
        "ctive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorS" & _
        "tyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=" & _
        """Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 534, 392</ClientArea><PrintPageHeaderStyle pare" & _
        "nt="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'tbpDetail
        '
        Me.tbpDetail.Controls.Add(Me.Panel2)
        Me.tbpDetail.Controls.Add(Me.Splitter1)
        Me.tbpDetail.Controls.Add(Me.Panel1)
        Me.tbpDetail.Location = New System.Drawing.Point(4, 21)
        Me.tbpDetail.Name = "tbpDetail"
        Me.tbpDetail.Size = New System.Drawing.Size(538, 550)
        Me.tbpDetail.TabIndex = 1
        Me.tbpDetail.Text = "分港明细"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Splitter2)
        Me.Panel2.Controls.Add(Me.C1Con)
        Me.Panel2.Controls.Add(Me.C1Bill)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 275)
        Me.Panel2.TabIndex = 673
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(232, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(2, 275)
        Me.Splitter2.TabIndex = 671
        Me.Splitter2.TabStop = False
        '
        'C1Con
        '
        Me.C1Con.CaptionHeight = 18
        Me.C1Con.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Con.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Con.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Con.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.C1Con.Location = New System.Drawing.Point(232, 0)
        Me.C1Con.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1Con.Name = "C1Con"
        Me.C1Con.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Con.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Con.PreviewInfo.ZoomFactor = 75
        Me.C1Con.RecordSelectorWidth = 17
        Me.C1Con.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Con.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1Con.RowHeight = 16
        Me.C1Con.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Con.Size = New System.Drawing.Size(306, 275)
        Me.C1Con.TabIndex = 670
        Me.C1Con.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{Font:Arial, 9pt;}HighlightRow{ForeColor:HighlightText;BackCol" & _
        "or:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Headin" & _
        "g{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Bac" & _
        "kColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style" & _
        "1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=" & _
        """18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBo" & _
        "rder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" Horiz" & _
        "ontalScrollGroup=""1""><ClientRect>0, 0, 302, 271</ClientRect><BorderSide>0</Borde" & _
        "rSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" " & _
        "me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle paren" & _
        "t=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupSt" & _
        "yle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><" & _
        "HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Ina" & _
        "ctive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorS" & _
        "tyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=" & _
        """Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 302, 271</ClientArea><PrintPageHeaderStyle pare" & _
        "nt="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'C1Bill
        '
        Me.C1Bill.CaptionHeight = 18
        Me.C1Bill.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1Bill.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Bill.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Bill.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.C1Bill.Location = New System.Drawing.Point(0, 0)
        Me.C1Bill.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1Bill.Name = "C1Bill"
        Me.C1Bill.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Bill.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Bill.PreviewInfo.ZoomFactor = 75
        Me.C1Bill.RecordSelectorWidth = 17
        Me.C1Bill.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Bill.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1Bill.RowHeight = 16
        Me.C1Bill.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Bill.Size = New System.Drawing.Size(232, 275)
        Me.C1Bill.TabIndex = 669
        Me.C1Bill.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{Font:Arial, 9pt;}HighlightRow{ForeColor:HighlightText;BackCol" & _
        "or:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Headin" & _
        "g{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Bac" & _
        "kColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style" & _
        "1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=" & _
        """18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBo" & _
        "rder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" Horiz" & _
        "ontalScrollGroup=""1""><ClientRect>0, 0, 228, 271</ClientRect><BorderSide>0</Borde" & _
        "rSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" " & _
        "me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle paren" & _
        "t=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupSt" & _
        "yle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><" & _
        "HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Ina" & _
        "ctive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorS" & _
        "tyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=" & _
        """Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 228, 271</ClientArea><PrintPageHeaderStyle pare" & _
        "nt="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 275)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(538, 3)
        Me.Splitter1.TabIndex = 674
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.C1BillCon)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 278)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 272)
        Me.Panel1.TabIndex = 672
        '
        'C1BillCon
        '
        Me.C1BillCon.CaptionHeight = 18
        Me.C1BillCon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1BillCon.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1BillCon.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1BillCon.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.C1BillCon.Location = New System.Drawing.Point(0, 0)
        Me.C1BillCon.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1BillCon.Name = "C1BillCon"
        Me.C1BillCon.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1BillCon.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1BillCon.PreviewInfo.ZoomFactor = 75
        Me.C1BillCon.RecordSelectorWidth = 17
        Me.C1BillCon.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1BillCon.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1BillCon.RowHeight = 16
        Me.C1BillCon.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1BillCon.Size = New System.Drawing.Size(538, 272)
        Me.C1BillCon.TabIndex = 671
        Me.C1BillCon.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{Font:Arial, 9pt;}HighlightRow{ForeColor:HighlightText;BackCol" & _
        "or:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Headin" & _
        "g{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Bac" & _
        "kColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style" & _
        "1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=" & _
        """18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBo" & _
        "rder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" Horiz" & _
        "ontalScrollGroup=""1""><ClientRect>0, 0, 534, 268</ClientRect><BorderSide>0</Borde" & _
        "rSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" " & _
        "me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle paren" & _
        "t=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupSt" & _
        "yle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><" & _
        "HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Ina" & _
        "ctive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorS" & _
        "tyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=" & _
        """Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 534, 268</ClientArea><PrintPageHeaderStyle pare" & _
        "nt="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'tbpCon
        '
        Me.tbpCon.Controls.Add(Me.Splitter3)
        Me.tbpCon.Controls.Add(Me.Panel4)
        Me.tbpCon.Controls.Add(Me.Panel3)
        Me.tbpCon.Location = New System.Drawing.Point(4, 21)
        Me.tbpCon.Name = "tbpCon"
        Me.tbpCon.Size = New System.Drawing.Size(538, 550)
        Me.tbpCon.TabIndex = 2
        Me.tbpCon.Text = "箱统计"
        '
        'Splitter3
        '
        Me.Splitter3.Location = New System.Drawing.Point(262, 0)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(3, 550)
        Me.Splitter3.TabIndex = 675
        Me.Splitter3.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.C1Extra)
        Me.Panel4.Controls.Add(Me.C1ExtraTotal)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(262, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(276, 550)
        Me.Panel4.TabIndex = 674
        '
        'C1Extra
        '
        Me.C1Extra.CaptionHeight = 18
        Me.C1Extra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Extra.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Extra.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Extra.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.C1Extra.Location = New System.Drawing.Point(0, 0)
        Me.C1Extra.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1Extra.Name = "C1Extra"
        Me.C1Extra.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Extra.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Extra.PreviewInfo.ZoomFactor = 75
        Me.C1Extra.RecordSelectorWidth = 17
        Me.C1Extra.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Extra.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1Extra.RowHeight = 16
        Me.C1Extra.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Extra.Size = New System.Drawing.Size(276, 348)
        Me.C1Extra.TabIndex = 670
        Me.C1Extra.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{Font:Arial, 9pt;}HighlightRow{ForeColor:HighlightText;BackCol" & _
        "or:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Headin" & _
        "g{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Bac" & _
        "kColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style" & _
        "1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=" & _
        """18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBo" & _
        "rder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" Horiz" & _
        "ontalScrollGroup=""1""><ClientRect>0, 0, 272, 344</ClientRect><BorderSide>0</Borde" & _
        "rSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" " & _
        "me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle paren" & _
        "t=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupSt" & _
        "yle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><" & _
        "HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Ina" & _
        "ctive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorS" & _
        "tyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=" & _
        """Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 272, 344</ClientArea><PrintPageHeaderStyle pare" & _
        "nt="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'C1ExtraTotal
        '
        Me.C1ExtraTotal.CaptionHeight = 18
        Me.C1ExtraTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1ExtraTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1ExtraTotal.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1ExtraTotal.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.C1ExtraTotal.Location = New System.Drawing.Point(0, 348)
        Me.C1ExtraTotal.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1ExtraTotal.Name = "C1ExtraTotal"
        Me.C1ExtraTotal.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1ExtraTotal.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1ExtraTotal.PreviewInfo.ZoomFactor = 75
        Me.C1ExtraTotal.RecordSelectorWidth = 17
        Me.C1ExtraTotal.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1ExtraTotal.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1ExtraTotal.RowHeight = 16
        Me.C1ExtraTotal.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1ExtraTotal.Size = New System.Drawing.Size(276, 202)
        Me.C1ExtraTotal.TabIndex = 672
        Me.C1ExtraTotal.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{Font:Arial, 9pt;}HighlightRow{ForeColor:HighlightText;BackCol" & _
        "or:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Headin" & _
        "g{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Al" & _
        "ignVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style" & _
        "9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=" & _
        """18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBo" & _
        "rder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" Horiz" & _
        "ontalScrollGroup=""1""><ClientRect>0, 0, 272, 198</ClientRect><BorderSide>0</Borde" & _
        "rSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" " & _
        "me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle paren" & _
        "t=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupSt" & _
        "yle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><" & _
        "HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Ina" & _
        "ctive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorS" & _
        "tyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=" & _
        """Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 272, 198</ClientArea><PrintPageHeaderStyle pare" & _
        "nt="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.C1State)
        Me.Panel3.Controls.Add(Me.C1StateTotal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(262, 550)
        Me.Panel3.TabIndex = 673
        '
        'C1State
        '
        Me.C1State.CaptionHeight = 18
        Me.C1State.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1State.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1State.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1State.Images.Add(CType(resources.GetObject("resource7"), System.Drawing.Image))
        Me.C1State.Location = New System.Drawing.Point(0, 0)
        Me.C1State.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1State.Name = "C1State"
        Me.C1State.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1State.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1State.PreviewInfo.ZoomFactor = 75
        Me.C1State.RecordSelectorWidth = 17
        Me.C1State.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1State.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1State.RowHeight = 16
        Me.C1State.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1State.Size = New System.Drawing.Size(262, 348)
        Me.C1State.TabIndex = 669
        Me.C1State.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{Font:Arial, 9pt;}HighlightRow{ForeColor:HighlightText;BackCol" & _
        "or:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Headin" & _
        "g{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Al" & _
        "ignVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style" & _
        "9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=" & _
        """18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBo" & _
        "rder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" Horiz" & _
        "ontalScrollGroup=""1""><ClientRect>0, 0, 258, 344</ClientRect><BorderSide>0</Borde" & _
        "rSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" " & _
        "me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle paren" & _
        "t=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupSt" & _
        "yle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><" & _
        "HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Ina" & _
        "ctive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorS" & _
        "tyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=" & _
        """Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 258, 344</ClientArea><PrintPageHeaderStyle pare" & _
        "nt="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'C1StateTotal
        '
        Me.C1StateTotal.CaptionHeight = 18
        Me.C1StateTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1StateTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1StateTotal.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1StateTotal.Images.Add(CType(resources.GetObject("resource8"), System.Drawing.Image))
        Me.C1StateTotal.Location = New System.Drawing.Point(0, 348)
        Me.C1StateTotal.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1StateTotal.Name = "C1StateTotal"
        Me.C1StateTotal.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1StateTotal.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1StateTotal.PreviewInfo.ZoomFactor = 75
        Me.C1StateTotal.RecordSelectorWidth = 17
        Me.C1StateTotal.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1StateTotal.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1StateTotal.RowHeight = 16
        Me.C1StateTotal.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1StateTotal.Size = New System.Drawing.Size(262, 202)
        Me.C1StateTotal.TabIndex = 671
        Me.C1StateTotal.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{Font:Arial, 9pt;}HighlightRow{ForeColor:HighlightText;BackCol" & _
        "or:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Headin" & _
        "g{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Al" & _
        "ignVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style" & _
        "9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=" & _
        """18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBo" & _
        "rder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" Horiz" & _
        "ontalScrollGroup=""1""><ClientRect>0, 0, 258, 198</ClientRect><BorderSide>0</Borde" & _
        "rSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" " & _
        "me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle paren" & _
        "t=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupSt" & _
        "yle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><" & _
        "HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Ina" & _
        "ctive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorS" & _
        "tyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=" & _
        """Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView>" & _
        "</Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""" & _
        "Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Cap" & _
        "tion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selec" & _
        "ted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highlight" & _
        "Row"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" " & _
        "/><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filte" & _
        "rBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSp" & _
        "lits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</Defa" & _
        "ultRecSelWidth><ClientArea>0, 0, 258, 198</ClientArea><PrintPageHeaderStyle pare" & _
        "nt="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'rbnReadCheck
        '
        Me.rbnReadCheck.Location = New System.Drawing.Point(6, 472)
        Me.rbnReadCheck.Name = "rbnReadCheck"
        Me.rbnReadCheck.Size = New System.Drawing.Size(88, 22)
        Me.rbnReadCheck.TabIndex = 735
        Me.rbnReadCheck.Text = "报文校正卸港"
        '
        'FrmConLoadFinal_Report
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(794, 575)
        Me.Controls.Add(Me.rbnReadCheck)
        Me.Controls.Add(Me.tbcStatis)
        Me.Controls.Add(Me.btnStatis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.cbEmail)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.btRead)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lbVoyage)
        Me.Controls.Add(Me.lbShipName)
        Me.Controls.Add(Me.lbShipCode)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.btQuit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadFinal_Report"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "出口集装箱放行 装箱单报文"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcStatis.ResumeLayout(False)
        Me.tbpSummary.ResumeLayout(False)
        CType(Me.C1Sum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpDetail.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.C1Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Bill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.C1BillCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpCon.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.C1Extra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ExtraTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.C1State, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1StateTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dvGetBill As New DataView
    Dim dsGetBill As New DataSet
    Dim daGetBill As New SqlClient.SqlDataAdapter
    Dim selCount As Integer = 0
    Dim iSum As Integer = 0

    Private Sub FrmConLoadFinal_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sqlShip As String
        sqlShip = "SELECT SHIP_ID,SSHIP.ENG_VESSEL,SSHIP.CHI_VESSEL,VOYAGE,Vessel_Code FROM SSHIP LEFT OUTER JOIN VESSEL ON V_ID = VESSEL_ID where SHIP_ID='" & Ship_ID & "'"
        Dim dvShip As New DataView
        dvShip = Filldata(sqlShip)
        If dvShip.Count > 0 Then
            If Not IsDBNull(dvShip(0)("CHI_VESSEL")) Then
                Me.lbShipName.Text = dvShip(0)("CHI_VESSEL")
            End If
            If Not IsDBNull(dvShip(0)("VOYAGE")) Then
                Me.lbVoyage.Text = dvShip(0)("VOYAGE")
            End If
            If Not IsDBNull(dvShip(0)("Vessel_Code")) Then
                Me.lbShipCode.Text = dvShip(0)("Vessel_Code")
            End If
        End If
        'Me.lbShipCode.Text = FrmConLoadFinalCheck.strShip
        'Me.lbShipName.Text = FrmConLoadFinalCheck.strShipName
        'Me.lbVoyage.Text = FrmConLoadFinalCheck.strVoyage
        Dim sqlGetBill As String

        'sqlGetBill = "SELECT CON_LOAD_TALLY_ID, BLNO, Report, checked FROM CON_LOAD_TALLY WHERE SHIP_ID = '" & Ship_ID & "'"
        sqlGetBill = "SELECT CON_HATCH_LIST_ID, BLNO, Report FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' and (CODE_LOAD_PORT = 'CNLYG' or CODE_LOAD_PORT = 'LYG')"
        ' 选出连云港装的提单
        dvGetBill = Updatedata(daGetBill, sqlGetBill, dsGetBill)
        dsGetBill.Tables(0).Columns.Add("checked", GetType(Boolean))
        Me.C1DBG.DataSource = dvGetBill

        Me.C1DBG.Splits(0).DisplayColumns("CON_HATCH_LIST_ID").Visible = False

        Me.C1DBG.Splits(0).DisplayColumns("BLNO").Width = 100
        Me.C1DBG.Splits(0).DisplayColumns("Report").Width = 50
        Me.C1DBG.Splits(0).DisplayColumns("checked").Width = 20
        Me.C1DBG.Columns("BLNO").Caption = "提单号"
        Me.C1DBG.Columns("Report").Caption = "有报文"
        Me.C1DBG.Columns("checked").Caption = "选择"
        Me.C1DBG.FetchRowStyles = True
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBG.Columns("checked").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
        Me.C1DBG.Columns("checked").ValueItems.Translate = True

        'Dim sqlValue As String
        'Dim dvValue As New DataView
        'sqlValue = "SELECT Value, Descri FROM True"
        'dvValue = Filldata(sqlValue)
        'Dim i As Integer
        'For i = 0 To dvValue.Count - 1
        '    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
        '    vi.DisplayValue = Trim(dvValue(i)("Descri"))
        '    vi.Value = Trim(dvValue(i)("Value"))
        '    Me.C1DBG.Columns("checked").ValueItems.Values.Add(vi)
        'Next

        Me.C1DBG.Splits(0).DisplayColumns("BLNO").Locked = True
        Me.C1DBG.Splits(0).DisplayColumns("Report").Locked = True
        Me.C1DBG.Columns("BLNO").FooterText = "计" & dvGetBill.Count & "条"
        Call btnTotal_Click(sender, e)

        txtFile.Text = "D:\EDI\BOCK\"
        Dim ds1 As New DataSet
        Dim dw1 As New DataView
        Dim sqlstr As String

        sqlstr = "select * from EMail_Cust order by ID"
        dw1 = Getdata(sqlstr, ds1)
        cbEmail.DataSource = ds1.Tables(0).DefaultView
        cbEmail.DisplayMember = "E_Name"
        cbEmail.ValueMember = "E_Code"

        Call Me.InitStatisGrid()
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Not IsDBNull(Me.C1DBG.Columns("Report").CellValue(e.Row)) Then
            e.CellStyle.BackColor = System.Drawing.Color.MistyRose
        End If
    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Dim I As Integer
        Me.C1DBG.Focus()
        If selCount Mod 2 = 0 Then
            For I = 0 To Me.dvGetBill.Count - 1
                Me.C1DBG.Row = I
                Me.C1DBG.Columns("checked").Value = True
            Next
            Me.btnTotal.Text = "全消"
        Else
            For I = 0 To Me.dvGetBill.Count - 1
                Me.C1DBG.Row = I
                Me.C1DBG.Columns("checked").Value = False
            Next
            Me.btnTotal.Text = "全选"
        End If
        Me.btQuit.Focus()
        selCount += 1
    End Sub

    Private Sub InitStatisGrid()
        Dim strGridName As String
        strGridName = "分港总数统计"
        Call SetC1Grid(Me.C1Sum, strGridName)
        strGridName = "分港提单"
        Call SetC1Grid(Me.C1Bill, strGridName)
        strGridName = "分港箱号"
        Call SetC1Grid(Me.C1Con, strGridName)
        strGridName = "分港提单箱号"
        Call SetC1Grid(Me.C1BillCon, strGridName)
        strGridName = "箱状态尺寸分港统计"
        Call SetC1Grid(Me.C1State, strGridName)
        strGridName = "特种箱分港统计"
        Call SetC1Grid(Me.C1Extra, strGridName)
        strGridName = "箱状态尺寸合计"
        Call SetC1Grid(Me.C1StateTotal, strGridName)
        strGridName = "特种箱合计"
        Call SetC1Grid(Me.C1ExtraTotal, strGridName)

    End Sub

    Private Sub SetC1Grid(ByRef C1One As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal strCaption As String)
        C1One.FetchRowStyles = True
        C1One.ColumnFooters = True
        C1One.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        C1One.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        C1One.Caption = strCaption
    End Sub

    Private Sub Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Send.Click
        Dim ds1 As New DataSet
        Dim dw1 As New DataView
        Dim ds2 As New DataSet
        Dim dw2 As New DataView
        Dim sqlstr As String
        sqlstr = "select * from EMail_Cust where E_Code='" & Trim(cbEmail.SelectedValue) & "'"
        dw1 = Getdata(sqlstr, ds1)
        sqlstr = "select * from EMail_Cust where E_Code='COSTACO'"
        dw2 = Getdata(sqlstr, ds2)

        Call Sendmail(Trim(ds1.Tables(0).Rows(0).Item("E_Mail")), Trim(ds2.Tables(0).Rows(0).Item("E_Mail")))
    End Sub
    Private Sub Sendmail(ByVal Sendto As String, ByVal From As String)
        On Error GoTo Err
        Dim Mail As New MailMessage
        Dim FileName As String
        Dim Subject As String
        Dim str As String
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim sqlstr As String

        FileName = txtFile.Text & UCase(lbShipCode.Text) & UCase(lbVoyage.Text) & ".txt"
        Subject = "COSTOR ShipName: " & lbShipName.Text & " VON:" & lbVoyage.Text

        'Add a File Attachment if specified
        If FileName <> "" Then
            Mail.Attachments.Add(New MailAttachment(FileName))
        End If
        'setup some e-mail information

        With Mail
            .From = From
            .To = Sendto
            .Subject = Subject
            .Body = cbEmail.Text & " 你好！" & Chr(13) & Chr(10) & Subject & Chr(13) & Chr(10) & " COSTACO(LYGWL)" & Chr(13) & Chr(10) & CType(Now, String)
            .Priority = MailPriority.High
        End With
        'send then e-mail message

        'SmtpMail.SmtpServer = MailServer

        SmtpMail.Send(Mail)
        MsgBox("报文已发送，谢谢使用!")
        File.Copy(FileName, "D:\EDI\BackUp\" & Mid(FileName, Len(substr(FileName)) + 1), True)
        File.Delete(FileName)
        Exit Sub
Err:
        MsgBox(Err.Description)
    End Sub

    Private Sub btRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRead.Click
        On Error GoTo Err
        Dim PathStr As String
        Dim FilePath As String
        Dim strFile As String

        strFile = txtFile.Text & UCase(lbShipCode.Text) & UCase(lbVoyage.Text) & ".txt"
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)

        FilePath = PathStr + "NOTEPAD.EXE"
        Shell(FilePath & " " & strFile, AppWinStyle.NormalFocus, True)
        Exit Sub
Err:
        MsgBox(Err.Description)
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim str As String

        Dim i As Integer
        str = ""
        Me.C1DBG.Focus()
        If dvGetBill.Count > 0 Then
            'Me.C1DBG.MoveFirst()
            'If Me.C1DBG.Columns("checked").Value = 1 Then
            '    str = "'" & Trim(Me.C1DBG.Columns("BLNO").Value).ToUpper() & "',"
            '    Me.C1DBG.Columns("Report").Text = "1"
            'End If
            'i = 1
            'Do While i < dvGetBill.Count
            '    Me.C1DBG.MoveNext()
            '    If Me.C1DBG.Columns("checked").Value = 1 Then
            '        str = str & "'" & Trim(Me.C1DBG.Columns("BLNO").Value).ToUpper() & "',"
            '        Me.C1DBG.Columns("Report").Text = "1"
            '    End If
            '    i = i + 1
            'Loop
            Try
                Dim strBillNo As String
                Dim j As Integer
                For i = 0 To dvGetBill.Count - 1
                    Me.C1DBG.Row = i
                    '处理带“##”的提单
                    If Me.C1DBG.Columns("checked").Text = True Then
                        strBillNo = Me.C1DBG.Columns("BLNO").Value
                        If strBillNo Like "*[#][#]" Then
                            strBillNo = strBillNo.Substring(0, strBillNo.Length - 2)
                        End If
                        For j = 0 To i - 1
                            If Me.C1DBG.Columns("checked").CellText(j) = True Then
                                If C1DBG.Columns("BLNO").CellText(j) Like strBillNo & "[#][#]" Then
                                    Exit For
                                End If
                            End If
                        Next
                        If j >= i Then
                            str = str & "'" & strBillNo & "',"
                        End If
                        Me.C1DBG.Columns("Report").Text = "1"
                    End If
                Next
                str = str.Substring(0, str.Length - 1)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        Me.C1DBG.Refresh()
        Me.btQuit.Focus()
        If Trim(str).Length > 0 Then
            daGetBill.Update(dsGetBill)
            Call MakeMail(str)
        Else
            MsgBox("没有选中提单，不能生成报文！")
        End If

    End Sub
    Private Sub MakeMail(ByVal str As String)
        On Error GoTo Err
        Dim sqlstr As String
        Dim strFile As String
        Dim txtline As String
        Dim ShipOwner As String
        Dim s As String
        Dim dss As New DataSet
        Dim dst As New DataSet
        Dim i As Integer = 0 '记录行数
        Dim j As Integer
        Dim k As Integer
        Dim nnnn As String
        sqlstr = "select Code_ShipOwner from SSHIP where ship_id=" & Ship_ID
        If Getdata(sqlstr, dss).Count > 0 Then
            If Not IsDBNull(dss.Tables(0).Rows(0).Item(0)) Then
                ShipOwner = Trim(dss.Tables(0).Rows(0).Item(0))
            Else
                ShipOwner = ""
            End If
        Else
            ShipOwner = ""
        End If

        strFile = txtFile.Text & UCase(lbShipCode.Text) & UCase(lbVoyage.Text) & ".txt"
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate) '打开报文文件
        '********************************00
        txtline = "00:COTEMP:CONTAINER LoADING LIST:9:LYGWL:" & Trim(cbEmail.SelectedValue) & ":" & Trim(CType(Year(Now), String))
        s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & s & "'"
        sw.WriteLine(txtline)
        '*******************************10
        txtline = "10:" & UCase(lbShipCode.Text) & "::" & UCase(lbVoyage.Text) & ":" & ShipOwner & ":::'"
        sw.WriteLine(txtline)
        i = 2
        j = 1
        '*******************************50
        sqlstr = "select DISTINCT CONTAINER_NO,SIZE_CON,CONTAINER_TYPE,FULLOREMPTY,LOAD_DATE,SEALNO,CODE_KEEPER  from VIEW_CON_HATCH_CARGO where Ship_ID=" & Ship_ID & " and UPPER(BLNO) IN (" & str & ")"
        dss.Reset()
        If Getdata(sqlstr, dss).Count > 0 Then
            nnnn = ""
            Do While j <= dss.Tables(0).Rows.Count
                If Trim(dss.Tables(0).Rows(j - 1).Item("CONTAINER_NO")) <> nnnn Then
                    txtline = "50:" & Trim(dss.Tables(0).Rows(j - 1).Item("CONTAINER_NO")) & ":"
                    txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("SIZE_CON"))
                    txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("CONTAINER_TYPE"))
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("FULLOREMPTY")) & ":0:"
                    txtline = txtline & Trim(CType(Year(dss.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String))
                    s = Mid("0" & Trim(CType(Month(dss.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String)), Len("0" & Trim(CType(Month(dss.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Day(dss.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String)), Len("0" & Trim(CType(Day(dss.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Hour(dss.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String)), Len("0" & Trim(CType(Hour(dss.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Minute(dss.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String)), Len("0" & Trim(CType(Minute(dss.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String))) - 1, 2)
                    txtline = txtline & s
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("SEALNO")) & ":"
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("CODE_KEEPER"))
                    txtline = txtline & "::::::'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    nnnn = Trim(dss.Tables(0).Rows(j - 1).Item("CONTAINER_NO"))
                End If
                j = j + 1
            Loop
        End If

        '***************************** 提单循环
        sqlstr = "select DISTINCT BLNO,AMOUNT,PACK,GROSS_WEIGHT,SIZE_MEASURE,GOODS_ENG,TEMPERATURE,MARK,DANGER_GRADE,DANGER_NO,DANGER_PAGENO,DANGER_MARK,CODE_LOAD_PORT,CODE_UNLOAD_PORT,CODE_PLACE_RECEIVE, Refrigerate_Temperature  from VIEW_CON_HATCH_CARGO where Ship_ID=" & Ship_ID & " and UPPER(BLNO) IN (" & str & ")"
        dss.Reset()
        If Getdata(sqlstr, dss).Count > 0 Then
            j = 1
            Do While j <= dss.Tables(0).Rows.Count
                '************************************51
                txtline = "51:" & Trim(dss.Tables(0).Rows(j - 1).Item("BLNO")) & "'"
                sw.WriteLine(txtline)
                i = i + 1
                '************************************52
                txtline = "52:1:" & dss.Tables(0).Rows(j - 1)("AMOUNT").ToString() & "::" & dss.Tables(0).Rows(j - 1).Item("PACK").ToString().Trim() & ":"
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("GROSS_WEIGHT")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("GROSS_WEIGHT")).Length() > 0 Then
                        txtline = txtline & Trim(CType(dss.Tables(0).Rows(j - 1).Item("GROSS_WEIGHT"), Single).ToString()) & ":"
                    Else
                        txtline = txtline & ":"
                    End If
                Else
                    txtline = txtline & ":"
                End If
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("SIZE_MEASURE")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("SIZE_MEASURE")).Length() > 0 Then
                        txtline = txtline & Trim(CType(dss.Tables(0).Rows(j - 1).Item("SIZE_MEASURE"), Single).ToString()) & ":"
                    Else
                        txtline = txtline & ":"
                    End If
                Else
                    txtline = txtline & ":"
                End If

                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("TEMPERATURE")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("TEMPERATURE")).Length() > 0 Then
                        'If dss.Tables(0).Rows(j - 1).Item("Refrigerate_Temperature") <> 0 Then
                        '要零上温度加正号
                        Dim strTemp As String
                        strTemp = dss.Tables(0).Rows(j - 1).Item("Refrigerate_Temperature")
                        If strTemp Like "#*" Then
                            strTemp = "+" & strTemp
                        End If
                        txtline = txtline & "C:" & strTemp & "::'"
                        'txtline = txtline & "C:" & Trim(CType(dss.Tables(0).Rows(j - 1).Item("Refrigerate_Temperature"), Single).ToString()) & "::'"
                    Else
                        txtline = txtline & ":::'"
                    End If
                Else
                txtline = txtline & ":::'"
                End If
                sw.WriteLine(txtline)
                i = i + 1
                '************************************53
                txtline = "53:" & Trim(dss.Tables(0).Rows(j - 1).Item("GOODS_ENG").ToString()) & "'"
                sw.WriteLine(txtline)
                i = i + 1
                '************************************54
                txtline = "54:" & Trim(dss.Tables(0).Rows(j - 1).Item("MARK").ToString()) & "'"
                sw.WriteLine(txtline)
                i = i + 1
                '************************************55
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("DANGER_GRADE")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("DANGER_GRADE")).Length() > 0 Then
                        txtline = "55:" & Trim(dss.Tables(0).Rows(j - 1).Item("DANGER_GRADE")) & ":"
                        txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("DANGER_PAGENO")) & ":"
                        txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("DANGER_NO")) & ":"
                        txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("DANGER_MARK")) & "::::'"
                        sw.WriteLine(txtline)
                        i = i + 1
                    End If
                End If
                '************************************11
                txtline = "11:" & Trim(dss.Tables(0).Rows(j - 1)("CODE_UNLOAD_PORT").ToString()) & ":" & FindPort(Trim(dss.Tables(0).Rows(j - 1)("CODE_UNLOAD_PORT").ToString())) & ":" & Trim(dss.Tables(0).Rows(j - 1)("CODE_LOAD_PORT").ToString()) & ":" & FindPort(Trim(dss.Tables(0).Rows(j - 1)("CODE_LOAD_PORT").ToString())) & ":::" & Trim(dss.Tables(0).Rows(j - 1)("CODE_PLACE_RECEIVE").ToString()) & ":" & FindPort(Trim(dss.Tables(0).Rows(j - 1)("CODE_PLACE_RECEIVE").ToString())) & "'"
                sw.WriteLine(txtline)
                i = i + 1
                '************************************56
                dst.Reset()
                sqlstr = "select CONTAINER_NO,SIZE_CON,CONAMOUNT,WEIGHT,VOLUME from VIEW_CON_HATCH_CARGO where Ship_ID=" & Ship_ID & " and UPPER(BLNO) IN ('" & Trim(dss.Tables(0).Rows(j - 1).Item("BLNO")).ToUpper() & "')"
                If Getdata(sqlstr, dst).Count > 0 Then
                    k = 1
                    Do While k <= dst.Tables(0).Rows.Count
                        txtline = "56:" & Trim(dst.Tables(0).Rows(k - 1).Item("CONTAINER_NO")) & ":"
                        If Not IsDBNull(dst.Tables(0).Rows(j - 1).Item("CONAMOUNT")) Then
                            If Trim(dst.Tables(0).Rows(j - 1).Item("CONAMOUNT")).Length() > 0 Then
                                txtline = txtline & Trim(dst.Tables(0).Rows(k - 1).Item("CONAMOUNT")) & ":"
                            Else
                                txtline = txtline & ":"
                            End If
                        Else
                            txtline = txtline & ":"
                        End If
                        If Trim(dst.Tables(0).Rows(k - 1).Item("SIZE_CON")) = "20" Then
                            txtline = txtline & "2300:" '***************皮重
                        ElseIf Trim(dst.Tables(0).Rows(k - 1).Item("SIZE_CON")) = "40" Then
                            txtline = txtline & "3800:" '***************皮重
                        ElseIf Trim(dst.Tables(0).Rows(k - 1).Item("SIZE_CON")) = "45" Then
                            txtline = txtline & "4700:" '***************皮重
                        Else
                            txtline = txtline & ":"
                        End If
                        If Not IsDBNull(dst.Tables(0).Rows(j - 1).Item("WEIGHT")) Then
                            If Trim(dst.Tables(0).Rows(j - 1).Item("WEIGHT")).Length() > 0 Then
                                txtline = txtline & Trim(CType(dst.Tables(0).Rows(k - 1).Item("WEIGHT"), Single).ToString()) & ":"
                            Else
                                txtline = txtline & ":"
                            End If
                        Else
                            txtline = txtline & ":"
                        End If

                        'If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("VOLUME")) Then
                        '    If Trim(dss.Tables(0).Rows(j - 1).Item("VOLUME")).Length() > 0 Then
                        '        txtline = txtline & Trim(CType(dst.Tables(0).Rows(k - 1).Item("VOLUME"), Single).ToString()) & "'"
                        '    Else
                        '        txtline = txtline & "'"
                        '    End If
                        'Else
                        '    txtline = txtline & "'"
                        'End If
                        If Not IsDBNull(dst.Tables(0).Rows(j - 1).Item("VOLUME")) Then
                            If Trim(dst.Tables(0).Rows(j - 1).Item("VOLUME")).Length() > 0 Then
                                txtline = txtline & Trim(CType(dst.Tables(0).Rows(k - 1).Item("VOLUME"), Single).ToString())
                            Else
                                txtline = txtline
                            End If
                        Else
                            txtline = txtline
                        End If
                        txtline = txtline & "'"
                        sw.WriteLine(txtline)
                        i = i + 1
                        k = k + 1
                    Loop
                End If

                j = j + 1
            Loop

        End If
        txtline = "99:" & i + 1 & "'"
        sw.WriteLine(txtline)
        MsgBox("报文已生成完毕，共 " & i + 1 & " 行 ")
        sw.Close()
        Exit Sub
Err:
        'MsgBox("报文生成出错在：" & Trim(dss.Tables(0).Rows(j - 1).Item("CONTAINER_NO")))
        Resume Next
    End Sub
    Private Function FindPort(ByVal Port As String) As String
        Dim dsPort As New DataSet
        Dim dwPort As New DataView
        Dim str As String
        str = "select * from Code_Port where Code_Port='" & Port & "'"
        dsPort.Reset()
        dwPort = Getdata(str, dsPort)
        If dwPort.Count > 0 Then
            FindPort = dsPort.Tables(0).Rows(0).Item("PORT_ENG")
        Else
            FindPort = Port
        End If
    End Function
    Private Sub C1EFTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1StateTotal.Click

    End Sub

    Private Sub btnStatis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatis.Click
        Try

            Dim strBillStr, strBillNo As String
            Dim i, j As Integer
            strBillStr = ""
            For i = 0 To dvGetBill.Count - 1
                Me.C1DBG.Row = i
                '处理带“##”的提单
                If Me.C1DBG.Columns("checked").Text = True Then
                    strBillNo = Me.C1DBG.Columns("BLNO").Value
                    If strBillNo Like "*[#][#]" Then
                        strBillNo = strBillNo.Substring(0, strBillNo.Length - 2)
                    End If
                    For j = 0 To i - 1
                        If Me.C1DBG.Columns("checked").CellText(j) = True Then
                            If C1DBG.Columns("BLNO").CellText(j) Like strBillNo & "[#][#]" Then
                                Exit For
                            End If
                        End If
                    Next
                    If j >= i Then
                        strBillStr = strBillStr & "'" & strBillNo & "',"
                    End If
                    Me.C1DBG.Columns("Report").Text = "1"
                End If
            Next
            strBillStr = strBillStr.Substring(0, strBillStr.Length - 1)

            Dim dvSum As New DataView
            Dim dvSumTotal As New DataView
            Dim dvBill As New DataView
            Dim dvCon As New DataView
            Dim dvBillCon As New DataView
            Dim dvState As New DataView
            Dim dvExtra As New DataView
            Dim dvStateTotal As New DataView
            Dim dvExtraTotal As New DataView

            Dim sqlSum, sqlSumTotal As String
            Dim sqlBill As String
            Dim sqlCon As String
            Dim sqlBillCon As String
            Dim sqlState As String
            Dim sqlExtra As String
            Dim sqlStateTotal As String
            Dim sqlExtraTotal As String
            sqlSum = "SELECT CODE_UNLOAD_PORT, COUNT(DISTINCT BLNO) AS BLNO_Sum, COUNT(DISTINCT CONTAINER_NO) AS CONTAINER_Sum, COUNT(*) AS Total FROM View_HatchCargoLYG WHERE (SHIP_ID = '" & Ship_ID & "') AND blno in (" & strBillStr & ") GROUP BY CODE_UNLOAD_PORT"
            sqlSumTotal = "SELECT COUNT(DISTINCT CODE_UNLOAD_PORT) AS CODE_UNLOAD_PORT_sum, COUNT(DISTINCT BLNO) AS BLNO_Sum, COUNT(DISTINCT CONTAINER_NO) AS CONTAINER_Sum, COUNT(*) AS Total FROM View_HatchCargoLYG WHERE (SHIP_ID = '" & Ship_ID & "') AND blno in (" & strBillStr & ") "

            sqlBill = "SELECT CODE_UNLOAD_PORT, BLNO,count(*) as ConSum FROM View_HatchCargoLYG WHERE (SHIP_ID = '" & Ship_ID & "') AND blno in (" & strBillStr & ") Group BY CODE_UNLOAD_PORT, BLNO ORDER BY CODE_UNLOAD_PORT, BLNO"

            sqlCon = "SELECT CODE_UNLOAD_PORT, CONTAINER_NO, count(CONTAINER_NO) BillSum, Max(FULLOREMPTY) FULLOREMPTY, Max(SIZE_CON) SIZE_CON, Max(CONTAINER_TYPE) CONTAINER_TYPE FROM View_HatchCargoLYG WHERE (SHIP_ID = '" & Ship_ID & "') AND blno in (" & strBillStr & ") Group BY CODE_UNLOAD_PORT, CONTAINER_NO ORDER BY CODE_UNLOAD_PORT, CONTAINER_NO"

            sqlBillCon = "SELECT CODE_UNLOAD_PORT, BLNO, CONTAINER_NO, FULLOREMPTY, SIZE_CON, CONTAINER_TYPE FROM View_HatchCargoLYG WHERE (SHIP_ID = '" & Ship_ID & "') AND blno in (" & strBillStr & ") ORDER BY CODE_UNLOAD_PORT, BLNO, CONTAINER_NO"

            sqlState = "SELECT CODE_UNLOAD_PORT, SIZE_CON, FULLOREMPTY, COUNT(DISTINCT CONTAINER_NO) AS CONTAINER_Sum FROM View_HatchCargoLYG WHERE (SHIP_ID = '" & Ship_ID & "') AND blno in (" & strBillStr & ") GROUP BY CODE_UNLOAD_PORT, FULLOREMPTY, SIZE_CON Order BY CODE_UNLOAD_PORT, FULLOREMPTY, SIZE_CON"

            sqlExtra = "SELECT CODE_UNLOAD_PORT, SIZE_CON, CONTAINER_TYPE, COUNT(DISTINCT CONTAINER_NO) AS CONTAINER_Sum FROM View_HatchCargoLYG WHERE (SHIP_ID = '" & Ship_ID & "') AND (FULLOREMPTY = 'F' OR FULLOREMPTY = 'L')  and blno in (" & strBillStr & ") GROUP BY CODE_UNLOAD_PORT, CONTAINER_TYPE, SIZE_CON Order BY CODE_UNLOAD_PORT, CONTAINER_TYPE, SIZE_CON"

            sqlStateTotal = "SELECT SIZE_CON, FULLOREMPTY, COUNT(DISTINCT CONTAINER_NO) AS CONTAINER_Sum FROM View_HatchCargoLYG WHERE (SHIP_ID = '" & Ship_ID & "') AND blno in (" & strBillStr & ") GROUP BY FULLOREMPTY, SIZE_CON ORDER BY FULLOREMPTY, SIZE_CON"

            sqlExtraTotal = "SELECT SIZE_CON, CONTAINER_TYPE, COUNT(DISTINCT CONTAINER_NO) AS CONTAINER_Sum FROM View_HatchCargoLYG WHERE (SHIP_ID = '" & Ship_ID & "') AND (FULLOREMPTY = 'F' OR FULLOREMPTY = 'L')  and blno in (" & strBillStr & ") GROUP BY CONTAINER_TYPE, SIZE_CON order by CONTAINER_TYPE, SIZE_CON"
            dvSum = Filldata(sqlSum)
            dvSumTotal = Filldata(sqlSumTotal)
            dvBill = Filldata(sqlBill)
            dvCon = Filldata(sqlCon)
            dvBillCon = Filldata(sqlBillCon)
            dvState = Filldata(sqlState)
            dvExtra = Filldata(sqlExtra)
            dvStateTotal = Filldata(sqlStateTotal)
            dvExtraTotal = Filldata(sqlExtraTotal)
            Me.C1Sum.DataSource = dvSum
            Me.C1Bill.DataSource = dvBill
            Me.C1Con.DataSource = dvCon
            Me.C1BillCon.DataSource = dvBillCon
            Me.C1State.DataSource = dvState
            Me.C1Extra.DataSource = dvExtra
            Me.C1StateTotal.DataSource = dvStateTotal
            Me.C1ExtraTotal.DataSource = dvExtraTotal


            Me.C1Sum.Columns("CODE_UNLOAD_PORT").Caption = "卸货港"
            Me.C1Sum.Columns("BLNO_Sum").Caption = "提单数"
            Me.C1Sum.Columns("CONTAINER_Sum").Caption = "箱数"
            Me.C1Sum.Columns("Total").Caption = "提单箱数"
            Me.C1Sum.Columns("CODE_UNLOAD_PORT").FooterText = "计" & dvSum.Count & "港"

            Me.C1Bill.Columns("CODE_UNLOAD_PORT").Caption = "卸货港"
            Me.C1Bill.Columns("BLNO").Caption = "提单"
            Me.C1Bill.Columns("ConSum").Caption = "提单箱数"
            Me.C1Bill.Columns("BLNO").FooterText = "计" & dvBill.Count & "提单"

            Me.C1Con.Columns("CODE_UNLOAD_PORT").Caption = "卸货港"
            Me.C1Con.Columns("CONTAINER_NO").Caption = "箱号"
            Me.C1Con.Columns("BillSum").Caption = "提单数"
            Me.C1Con.Columns("FULLOREMPTY").Caption = "状态"
            Me.C1Con.Columns("SIZE_CON").Caption = "尺寸"
            Me.C1Con.Columns("CONTAINER_TYPE").Caption = "箱型"
            Me.C1Con.Columns("CONTAINER_NO").FooterText = "计" & dvCon.Count & "箱"

            Me.C1BillCon.Columns("CODE_UNLOAD_PORT").Caption = "卸货港"
            Me.C1BillCon.Columns("BLNO").Caption = "提单"
            Me.C1BillCon.Columns("CONTAINER_NO").Caption = "箱号"
            Me.C1BillCon.Columns("FULLOREMPTY").Caption = "状态"
            Me.C1BillCon.Columns("SIZE_CON").Caption = "尺寸"
            Me.C1BillCon.Columns("CONTAINER_TYPE").Caption = "箱型"
            Me.C1BillCon.Columns("CONTAINER_NO").FooterText = "计" & dvBillCon.Count & "提单箱"

            Me.C1State.Columns("CODE_UNLOAD_PORT").Caption = "卸货港"
            Me.C1State.Columns("SIZE_CON").Caption = "尺寸"
            Me.C1State.Columns("FULLOREMPTY").Caption = "状态"
            Me.C1State.Columns("CONTAINER_Sum").Caption = "箱数"
            Me.C1State.Columns("CODE_UNLOAD_PORT").FooterText = "计" & dvState.Count & "项"

            Me.C1Extra.Columns("CODE_UNLOAD_PORT").Caption = "卸货港"
            Me.C1Extra.Columns("SIZE_CON").Caption = "尺寸"
            Me.C1Extra.Columns("CONTAINER_TYPE").Caption = "箱型"
            Me.C1Extra.Columns("CONTAINER_Sum").Caption = "箱数"
            Me.C1Extra.Columns("CODE_UNLOAD_PORT").FooterText = "计" & dvExtra.Count & "项"

            Me.C1StateTotal.Columns("SIZE_CON").Caption = "箱尺寸"
            Me.C1StateTotal.Columns("FULLOREMPTY").Caption = "状态"
            Me.C1StateTotal.Columns("CONTAINER_Sum").Caption = "箱数"
            Me.C1StateTotal.Columns("SIZE_CON").FooterText = "计" & dvStateTotal.Count & "项"

            Me.C1ExtraTotal.Columns("SIZE_CON").Caption = "箱尺寸"
            Me.C1ExtraTotal.Columns("CONTAINER_TYPE").Caption = "箱型"
            Me.C1ExtraTotal.Columns("CONTAINER_Sum").Caption = "箱数"
            Me.C1ExtraTotal.Columns("SIZE_CON").FooterText = "计" & dvExtraTotal.Count & "项"

            'Call SetGridWidth(C1Sum)
            'Call SetGridWidth(C1Bill)
            Call SetGridWidth(C1Con)
            Call SetGridWidth(C1BillCon)
            Call SetGridWidth(C1State)
            Call SetGridWidth(C1Extra)
            Call SetGridWidth(C1StateTotal)
            Call SetGridWidth(C1ExtraTotal)

            Me.C1Sum.Splits(0).DisplayColumns("CODE_UNLOAD_PORT").Width = 60
            Me.C1Sum.Splits(0).DisplayColumns("BLNO_Sum").Width = 50
            Me.C1Sum.Splits(0).DisplayColumns("CONTAINER_Sum").Width = 50
            Me.C1Sum.Splits(0).DisplayColumns("Total").Width = 70

            Me.C1Bill.Splits(0).DisplayColumns("CODE_UNLOAD_PORT").Width = 50
            Me.C1Bill.Splits(0).DisplayColumns("BLNO").Width = 96
            Me.C1Bill.Splits(0).DisplayColumns("ConSum").Width = 70

            Me.C1Con.Splits(0).DisplayColumns("CODE_UNLOAD_PORT").Width = 50
            Me.C1Con.Splits(0).DisplayColumns("CONTAINER_NO").Width = 86
            Me.C1Con.Splits(0).DisplayColumns("BillSum").Width = 70

            Me.C1BillCon.Splits(0).DisplayColumns("CODE_UNLOAD_PORT").Width = 50
            Me.C1BillCon.Splits(0).DisplayColumns("BLNO").Width = 96
            Me.C1BillCon.Splits(0).DisplayColumns("CONTAINER_NO").Width = 86

            Me.C1State.Splits(0).DisplayColumns("CODE_UNLOAD_PORT").Width = 50

            Me.C1Extra.Splits(0).DisplayColumns("CODE_UNLOAD_PORT").Width = 50

            Call ComputeCol(Me.C1Sum, "BLNO_Sum", dvSum.Count)
            Me.C1Sum.Columns("BLNO_Sum").FooterText = iSum & "单"

            Call ComputeCol(Me.C1Sum, "CONTAINER_Sum", dvSum.Count)
            Me.C1Sum.Columns("CONTAINER_Sum").FooterText = iSum & "箱"

            Call ComputeCol(Me.C1Sum, "Total", dvSum.Count)
            Me.C1Sum.Columns("Total").FooterText = iSum & "提单箱"

            Call ComputeCol(Me.C1Bill, "ConSum", dvBill.Count)
            Me.C1Bill.Columns("ConSum").FooterText = iSum & "提单箱"

            Call ComputeCol(Me.C1Con, "BillSum", dvCon.Count)
            Me.C1Con.Columns("BillSum").FooterText = iSum & "提单箱"

            Call ComputeCol(Me.C1State, "CONTAINER_Sum", dvState.Count)
            Me.C1State.Columns("CONTAINER_Sum").FooterText = iSum & "箱"

            Call ComputeCol(Me.C1Extra, "CONTAINER_Sum", dvExtra.Count)
            Me.C1Extra.Columns("CONTAINER_Sum").FooterText = iSum & "箱"

            Call ComputeCol(Me.C1StateTotal, "CONTAINER_Sum", dvStateTotal.Count)
            Me.C1StateTotal.Columns("CONTAINER_Sum").FooterText = iSum & "箱"

            Call ComputeCol(Me.C1ExtraTotal, "CONTAINER_Sum", dvExtraTotal.Count)
            Me.C1ExtraTotal.Columns("CONTAINER_Sum").FooterText = iSum & "箱"

            Me.lbConTotal.Text = "不分港总计 " & dvSumTotal(0)("CODE_UNLOAD_PORT_sum") & "港 " & dvSumTotal(0)("BLNO_Sum") & "单 " & dvSumTotal(0)("CONTAINER_Sum") & "箱 " & dvSumTotal(0)("Total") & "提单箱"
            Me.lbExplain.Text = "说明：提单箱数针对拼箱，表示提单中包含的箱数。多数情况下，提单箱数和箱数合计相等；若提单箱数大于箱数，必定有拼箱。" & Chr(10) & "正常情况下，分港总数统计和不分港总计对应数据相等，如果出现两者箱总数不等，可能是有拼箱在不同卸货港。"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SetGridWidth(ByRef COne As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
        Dim i As Integer
        For i = 0 To COne.Columns.Count - 1
            COne.Splits(0).DisplayColumns(i).Width = 42
        Next
    End Sub

    Private Sub ComputeCol(ByRef COne As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal strColName As String, ByVal iCount As Integer)
        Dim i As Integer
        iSum = 0
        For i = 0 To iCount - 1
            iSum += COne.Columns(strColName).CellText(i)
        Next
    End Sub

    Private Sub C1Con_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1Con.FetchRowStyle
        If C1Con.Columns("FULLOREMPTY").CellValue(e.Row) = "L" Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleVioletRed
        End If
    End Sub

    Private Sub C1BillCon_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1BillCon.FetchRowStyle
        If C1BillCon.Columns("FULLOREMPTY").CellValue(e.Row) = "L" Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleVioletRed
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click

    End Sub

    Private Sub rbnReadCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnReadCheck.Click
        Dim fm As New FrmReadMailList_T
        fm.LShipCode.Text = Me.lbShipCode.Text
        fm.LChina.Text = Me.lbShipName.Text
        fm.LVoyage.Text = Me.lbVoyage.Text
        fm.ShowDialog()
    End Sub
End Class
