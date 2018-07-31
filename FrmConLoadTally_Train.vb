Imports TALLY.DBControl
Public Class FrmConLoadTally_Train
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
    Friend WithEvents txtContainerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBGH As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnGet As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents lbCon As System.Windows.Forms.ListBox
    Friend WithEvents btnTrans As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCount As System.Windows.Forms.Label
    Friend WithEvents btnCallPrint As System.Windows.Forms.Button
    Friend WithEvents cbPass As System.Windows.Forms.CheckBox
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents cbPlace As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadTally_Train))
        Me.txtContainerNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1DBGH = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnGet = New System.Windows.Forms.Button
        Me.btnReturn = New System.Windows.Forms.Button
        Me.lbCon = New System.Windows.Forms.ListBox
        Me.btnTrans = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnGetData = New System.Windows.Forms.Button
        Me.cbPlace = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbPass = New System.Windows.Forms.CheckBox
        Me.lbCount = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnCallPrint = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBGH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtContainerNo
        '
        Me.txtContainerNo.Location = New System.Drawing.Point(6, 30)
        Me.txtContainerNo.MaxLength = 12
        Me.txtContainerNo.Name = "txtContainerNo"
        Me.txtContainerNo.Size = New System.Drawing.Size(130, 21)
        Me.txtContainerNo.TabIndex = 426
        Me.txtContainerNo.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 427
        Me.Label3.Text = "集装箱号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBillNO
        '
        Me.txtBillNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBillNO.Location = New System.Drawing.Point(224, 80)
        Me.txtBillNO.MaxLength = 120
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(124, 21)
        Me.txtBillNO.TabIndex = 422
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(176, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 18)
        Me.Label4.TabIndex = 425
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVoyage.Location = New System.Drawing.Point(224, 58)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(124, 21)
        Me.txtVoyage.TabIndex = 421
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(176, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 424
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShip.Location = New System.Drawing.Point(224, 14)
        Me.txtShip.MaxLength = 10
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(124, 21)
        Me.txtShip.TabIndex = 420
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(176, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 423
        Me.Label2.Text = "船名码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(318, 508)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 429
        Me.btQuit.Text = "退出"
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(230, 508)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 428
        Me.btSave.Text = "修改保存"
        '
        'txtShipName
        '
        Me.txtShipName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtShipName.Location = New System.Drawing.Point(224, 36)
        Me.txtShipName.MaxLength = 40
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(124, 21)
        Me.txtShipName.TabIndex = 430
        Me.txtShipName.Text = ""
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(176, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 18)
        Me.Label5.TabIndex = 431
        Me.Label5.Text = "船名"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(4, 12)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.RecordSelectorWidth = 16
        Me.C1DBG.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBG.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.Size = New System.Drawing.Size(516, 488)
        Me.C1DBG.TabIndex = 432
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 512, 484</ClientRect><BorderSide>0</BorderSide><CaptionSt" & _
        "yle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><E" & _
        "venRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me" & _
        "=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Grou" & _
        "p"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyl" & _
        "e parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style" & _
        "4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""Rec" & _
        "ordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Styl" & _
        "e parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedS" & _
        "tyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Styl" & _
        "e parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style p" & _
        "arent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style pa" & _
        "rent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style pa" & _
        "rent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=" & _
        """Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style p" & _
        "arent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits" & _
        ">1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><" & _
        "ClientArea>0, 0, 512, 484</ClientArea><PrintPageHeaderStyle parent="""" me=""Style1" & _
        "4"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'C1DBGH
        '
        Me.C1DBGH.AllowUpdate = False
        Me.C1DBGH.CaptionHeight = 18
        Me.C1DBGH.FetchRowStyles = True
        Me.C1DBGH.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGH.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1DBGH.Location = New System.Drawing.Point(4, 54)
        Me.C1DBGH.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBGH.Name = "C1DBGH"
        Me.C1DBGH.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGH.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGH.PreviewInfo.ZoomFactor = 75
        Me.C1DBGH.RecordSelectorWidth = 16
        Me.C1DBGH.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBGH.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBGH.RowHeight = 16
        Me.C1DBGH.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBGH.Size = New System.Drawing.Size(166, 484)
        Me.C1DBGH.TabIndex = 433
        Me.C1DBGH.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{BackColor:Window;}Footer{}Capti" & _
        "on{AlignHorz:Center;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackCo" & _
        "lor:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Headi" & _
        "ng{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Ba" & _
        "ckColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Styl" & _
        "e1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight" & _
        "=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" FetchRowStyles=""True"" Mar" & _
        "queeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" Vertic" & _
        "alScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 162, 480</ClientRe" & _
        "ct><BorderSide>0</BorderSide><CaptionStyle parent=""Style2"" me=""Style10"" /><Edito" & _
        "rStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" " & _
        "/><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer""" & _
        " me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""H" & _
        "eading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><In" & _
        "activeStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Sty" & _
        "le9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyl" & _
        "e parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win." & _
        "C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Sty" & _
        "le parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style p" & _
        "arent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style pa" & _
        "rent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent" & _
        "=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style paren" & _
        "t=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style pa" & _
        "rent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyle" & _
        "s><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><Defa" & _
        "ultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 162, 480</ClientArea><Pr" & _
        "intPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""" & _
        "Style15"" /></Blob>"
        '
        'btnGet
        '
        Me.btnGet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGet.Location = New System.Drawing.Point(172, 184)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(42, 24)
        Me.btnGet.TabIndex = 434
        Me.btnGet.Text = ">"
        '
        'btnReturn
        '
        Me.btnReturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReturn.Location = New System.Drawing.Point(172, 274)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(42, 24)
        Me.btnReturn.TabIndex = 435
        Me.btnReturn.Text = "<"
        '
        'lbCon
        '
        Me.lbCon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCon.ItemHeight = 12
        Me.lbCon.Location = New System.Drawing.Point(214, 172)
        Me.lbCon.Name = "lbCon"
        Me.lbCon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbCon.Size = New System.Drawing.Size(134, 328)
        Me.lbCon.Sorted = True
        Me.lbCon.TabIndex = 588
        '
        'btnTrans
        '
        Me.btnTrans.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTrans.Location = New System.Drawing.Point(256, 510)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(64, 24)
        Me.btnTrans.TabIndex = 589
        Me.btnTrans.Text = "确定"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnGetData)
        Me.GroupBox1.Controls.Add(Me.cbPlace)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbPass)
        Me.GroupBox1.Controls.Add(Me.lbCount)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtShip)
        Me.GroupBox1.Controls.Add(Me.lbCon)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnReturn)
        Me.GroupBox1.Controls.Add(Me.txtContainerNo)
        Me.GroupBox1.Controls.Add(Me.txtVoyage)
        Me.GroupBox1.Controls.Add(Me.btnGet)
        Me.GroupBox1.Controls.Add(Me.txtShipName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnTrans)
        Me.GroupBox1.Controls.Add(Me.txtBillNO)
        Me.GroupBox1.Controls.Add(Me.C1DBGH)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 540)
        Me.GroupBox1.TabIndex = 590
        Me.GroupBox1.TabStop = False
        '
        'btnGetData
        '
        Me.btnGetData.Location = New System.Drawing.Point(236, 128)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(65, 22)
        Me.btnGetData.TabIndex = 645
        Me.btnGetData.Text = "查找"
        '
        'cbPlace
        '
        Me.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlace.Location = New System.Drawing.Point(228, 104)
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(120, 20)
        Me.cbPlace.TabIndex = 643
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(172, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 18)
        Me.Label8.TabIndex = 644
        Me.Label8.Text = "工作地点"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPass
        '
        Me.cbPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPass.Checked = True
        Me.cbPass.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPass.Location = New System.Drawing.Point(174, 506)
        Me.cbPass.Name = "cbPass"
        Me.cbPass.Size = New System.Drawing.Size(62, 22)
        Me.cbPass.TabIndex = 597
        Me.cbPass.Text = "进码头"
        '
        'lbCount
        '
        Me.lbCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCount.Location = New System.Drawing.Point(216, 154)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(132, 18)
        Me.lbCount.TabIndex = 596
        Me.lbCount.Text = "计0条"
        Me.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btSave)
        Me.GroupBox2.Controls.Add(Me.btnCallPrint)
        Me.GroupBox2.Controls.Add(Me.btQuit)
        Me.GroupBox2.Controls.Add(Me.C1DBG)
        Me.GroupBox2.Location = New System.Drawing.Point(354, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 540)
        Me.GroupBox2.TabIndex = 591
        Me.GroupBox2.TabStop = False
        '
        'btnCallPrint
        '
        Me.btnCallPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCallPrint.Location = New System.Drawing.Point(140, 508)
        Me.btnCallPrint.Name = "btnCallPrint"
        Me.btnCallPrint.Size = New System.Drawing.Size(64, 24)
        Me.btnCallPrint.TabIndex = 592
        Me.btnCallPrint.Text = "打印"
        '
        'FrmConLoadTally_Train
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(876, 543)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadTally_Train"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装拆箱火车大列处理"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBGH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlContainer As String
    Dim dsContainer As New DataSet()
    Dim daContainer As New SqlClient.SqlDataAdapter()
    Dim strShip, strVoyage, strBillNo, strContainer As String
    Dim dvCodeYard As New DataView()

    Dim sqlShipCode As String
    Dim dvShipCode As New DataView()
    Dim shipMark As Boolean
    Dim i, j As Integer

    Dim sqlConHche As String
    Dim dvConHche As New DataView()
    Dim dsConHche As New DataSet()
    Dim daConHche As New SqlClient.SqlDataAdapter()

    Dim Count, delSum As Integer
    Dim strYard, sqlYard As String
    Dim dvYard As New DataView()
    Dim strOperYard As String '操作的场站
    Public blSave As Boolean

    Private Sub FrmConLoadTally_Train_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlYard As String
        sqlYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix,DeptCode FROM Code_Yard where DeptCode like '" & G_DeptCode & "%' ORDER BY Code_Yard_ID"
        cbPlace.DataSource = Filldata(sqlYard)
        cbPlace.DisplayMember = "Code_Yard_Name"
        cbPlace.ValueMember = "Code_Yard_ID"
        sqlYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix, CodeMax, CodeYear, DeptCode FROM Code_Yard WHERE DeptCode = '" & G_DeptCode & "'"
        dvYard = Filldata(sqlYard)
        If dvYard.Count > 0 Then
            strYard = dvYard(0)("Code_Yard_ID")     '生成场站代码，哪个部门处理的火车大列，就是哪个部门的场站代码
        Else
            strYard = ""
        End If
        Me.cbPlace.SelectedValue = strYard
        strOperYard = strYard
        strShip = ""
        strVoyage = ""
        strBillNo = ""
        Me.txtShip.Focus()

        Me.C1DBGH.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBGH.ColumnFooters = True
        Me.C1DBGH.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGH.FetchRowStyles = True
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.FetchRowStyles = True

        sqlContainer = "SELECT CON_LOAD_TALLY_LIST_ID,CON_LOAD_TALLY_ID,SHIP_ID,CHI_VESSEL,Voyage,BLNO,CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,PACK_CHA,PACK_ENG,AMOUNT,WEIGHT,NetWeight,VOLUME,DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,USER_NAME,CodeYard,ReeferTemp,TempUnit,DangerGrade,DangerMark,Checked,CheckTime,Printed,PrintTime,PrintPerson,StateC,FullOrEmpty " & _
                " FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' AND CodeYard = '" & strYard & "' order by CONTAINER_NO "
        Call GetConHche()
        'Call GetContainer(sqlContainer)
    End Sub

    Private Sub GetConHche()
    
        'sqlConHche = "SELECT * FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = 'HCHE' AND Voyage = '001' AND BLNO = '001' order by CONTAINER_NO "
        'sqlConHche = "SELECT * FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = 'AS' AND Voyage = 'hche' order by CONTAINER_NO "
        'If strYard = "07" Then   '只有检查桥才有最大权限
        If strOperYard = "01" Then   '只有港内场站才有最大权限
            sqlConHche = "SELECT CON_LOAD_TALLY_LIST_ID,CodeYard,StateC,CHI_VESSEL,CONTAINER_NO,Voyage,BLNO,CodeYard CodeYardOg,CHI_VESSEL CHI_VESSELOg,Voyage VoyageOg,BLNO BLNOOg FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = 'HCHE' order by CONTAINER_NO "
        Else
            sqlConHche = "SELECT CON_LOAD_TALLY_LIST_ID,CodeYard,StateC,CHI_VESSEL,CONTAINER_NO,Voyage,BLNO,CodeYard CodeYardOg,CHI_VESSEL CHI_VESSELOg,Voyage VoyageOg,BLNO BLNOOg FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = 'HCHE' and StateC = '1' order by CONTAINER_NO "
            Me.cbPass.Checked = True
            Me.cbPass.Visible = False
        End If

        dvConHche = Updatedata(daConHche, sqlConHche, dsConHche)
        Me.C1DBGH.DataSource = dvConHche
        For i = 0 To Me.C1DBGH.Columns.Count - 1
            Me.C1DBGH.Splits(0).DisplayColumns(i).AutoSize()
        Next
        Me.C1DBGH.Splits(0).DisplayColumns("CON_LOAD_TALLY_LIST_ID").Visible = False
        Me.C1DBGH.Splits(0).DisplayColumns("CodeYard").Visible = False
        Me.C1DBGH.Splits(0).DisplayColumns("StateC").Visible = False
        Me.C1DBGH.Splits(0).DisplayColumns("CHI_VESSEL").Visible = False
        Me.C1DBGH.Splits(0).DisplayColumns("CodeYardOg").Visible = False
        'Me.C1DBGH.Splits(0).DisplayColumns("CHI_VESSELOg").Visible = False
        Me.C1DBGH.Splits(0).DisplayColumns("VoyageOg").Visible = False
        Me.C1DBGH.Splits(0).DisplayColumns("BLNOOg").Visible = False
        Me.C1DBGH.Columns("CONTAINER_NO").Caption = "箱号"
        Me.C1DBGH.Columns("Voyage").Caption = "航次"
        Me.C1DBGH.Columns("BLNO").Caption = "提单"
        Me.C1DBGH.Columns("CONTAINER_NO").FooterText = "合计" & dvConHche.Count & "箱"
    End Sub

    Private Sub GetContainer(ByVal sqlSelect)
        Me.C1DBG.AllowAddNew = False
        Try
            Me.C1DBG.DataSource = Updatedata(daContainer, sqlContainer, dsContainer)
            Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            Me.C1DBG.Columns("CONTAINER_NO").FooterText = "合计" & dsContainer.Tables(0).Rows.Count & "箱"
            Count = dsContainer.Tables(0).Rows.Count
            delSum = 0
            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SHIP_ID").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PACK_ENG").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("CHI_VESSEL").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("VOYAGE").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CodeYard").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Checked").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CheckTime").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns.Item("SecSealNO").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns.Item("ReasonOpenSeal").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Printed").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("BLNO").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("DAMAGED_AMOUNT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("DAMAGED_PACK").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("WEIGHT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintPerson").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("StateC").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("FullOrEmpty").Visible = False

            Me.C1DBG.Columns.Item("CHI_VESSEL").Caption = "船名"
            Me.C1DBG.Columns.Item("VOYAGE").Caption = "航次"
            Me.C1DBG.Columns.Item("BLNO").Caption = "提单号"
            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
            Me.C1DBG.Columns.Item("NEWSEALNO").Caption = "货单铅封号"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "箱尺寸"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
            Me.C1DBG.Columns.Item("AMOUNT").Caption = "件数"
            Me.C1DBG.Columns.Item("PACK_CHA").Caption = "包装"
            Me.C1DBG.Columns.Item("NetWeight").Caption = "货重(kg)"
            Me.C1DBG.Columns.Item("VOLUME").Caption = "体积(M3)"
            Me.C1DBG.Columns.Item("SecSealNO").Caption = "备注铅封号"
            Me.C1DBG.Columns.Item("ReasonOpenSeal").Caption = "开封原因"
            Me.C1DBG.Columns.Item("ReeferTemp").Caption = "冷藏温度"
            Me.C1DBG.Columns.Item("TempUnit").Caption = "温标"
            Me.C1DBG.Columns.Item("DangerGrade").Caption = "危品等级"
            Me.C1DBG.Columns.Item("DangerMark").Caption = "危品标签"

            'Me.C1DBG.Columns.Item("CON_LOAD_TALLY_ID").DefaultValue = ID
            'Me.C1DBG.Columns.Item("USER_NAME").DefaultValue = G_User
            'Me.C1DBG.Columns.Item("CHI_VESSEL").DefaultValue = strShip
            'Me.C1DBG.Columns.Item("VOYAGE").DefaultValue = strVoyage
            'Me.C1DBG.Columns.Item("CodeYard").DefaultValue = strYCode

            Call FieldFill()
            SetColumnWidth()
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FieldFill()
        Dim i As Integer
        Try
            Dim sqlConKind As String = "SELECT CODE_CON_KIND, CON_KIND_ENG FROM CODE_CON_KIND ORDER BY CODE_CON_KIND"
            Dim dvConKind As New DataView
            dvConKind = Filldata(sqlConKind)
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Translate = True
            For i = 0 To dvConKind.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvConKind(i)("CON_KIND_ENG")
                vi.Value = dvConKind(i)("CODE_CON_KIND")
                Me.C1DBG.Columns.Item("CONTAINER_TYPE").ValueItems.Values.Add(vi)
            Next

            Dim sqlPack As String = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK ORDER BY CODE_PACK"
            Dim dvPack As New DataView
            dvPack = Filldata(sqlPack)
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Translate = True
            For i = 0 To dvPack.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvPack(i)("PACK_CHA")
                vi.Value = dvPack(i)("CODE_PACK")
                Me.C1DBG.Columns.Item("PACK_CHA").ValueItems.Values.Add(vi)
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidth()
        Dim i As Integer
        Try
            i = 2
            Do While i < Me.C1DBG.Columns.Count
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Width = 60
                i = i + 1
            Loop
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("NEWSEALNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("BLNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("ReeferTemp").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("TempUnit").Width = 40
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGet.Click
        Me.C1DBGH.Focus()
        For i = 0 To Me.C1DBGH.SelectedRows.Count - 1
            Me.C1DBGH.Row = Me.C1DBGH.SelectedRows(i)
            If Me.C1DBGH.Columns("CHI_VESSEL").Text = "HCHE" Then
                If strShip = "HCHE" Then
                    Me.C1DBGH.Columns("CHI_VESSEL").Text = strShip & "1"
                Else
                    Me.C1DBGH.Columns("CHI_VESSEL").Text = strShip
                End If
                Me.C1DBGH.Columns("Voyage").Text = strVoyage
                Me.C1DBGH.Columns("BLNO").Text = strBillNo
                Me.C1DBGH.Columns("CodeYard").Text = strYard
                Me.lbCon.Items.Add(Me.C1DBGH.Columns("CONTAINER_NO").Text)
            End If
        Next
        Me.txtContainerNo.Focus()
        lbCount.Text = "计" & Me.lbCon.Items.Count & "条"
        Me.C1DBGH.Row += 1
        Me.C1DBGH.Row -= 1
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Me.C1DBGH.Focus()
        For i = 0 To Me.lbCon.SelectedItems.Count - 1
            For j = 0 To dvConHche.Count - 1
                Me.C1DBGH.Row = j
                If Me.lbCon.SelectedItems.Item(0) = Me.C1DBGH.Columns("CONTAINER_NO").Text Then
                    Me.C1DBGH.Columns("CHI_VESSEL").Text = "HCHE"
                    Me.C1DBGH.Columns("Voyage").Text = Me.C1DBGH.Columns("VoyageOg").Text
                    Me.C1DBGH.Columns("BLNO").Text = Me.C1DBGH.Columns("BLNOOg").Text
                    Me.C1DBGH.Columns("CodeYard").Text = Me.C1DBGH.Columns("CodeYardOg").Text
                    Exit For
                End If
            Next
            Me.lbCon.Items.Remove(Me.lbCon.SelectedItems.Item(0))
        Next
        Me.lbCon.Focus()
        lbCount.Text = "计" & Me.lbCon.Items.Count & "条"
        Me.C1DBGH.Row += 1
        Me.C1DBGH.Row -= 1
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtContainerNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContainerNo.Leave
        strContainer = Me.txtContainerNo.Text.Trim.ToUpper
        For i = 0 To dvConHche.Count - 1
            If Me.C1DBGH.Columns("CONTAINER_NO").CellText(i) Like "*" & strContainer & "*" Then
                Me.C1DBGH.SelectedRows.Clear()
                Me.C1DBGH.SelectedRows.Add(i)
                Me.C1DBGH.Row = i
            End If
        Next
    End Sub

    Private Sub C1DBGH_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGH.FetchRowStyle
        If Me.C1DBGH.Columns("StateC").CellText(e.Row) = "1" Then
            e.CellStyle.BackColor = System.Drawing.Color.Orchid
        ElseIf Me.C1DBGH.Columns("StateC").CellText(e.Row) <> "0" And Me.C1DBGH.Columns("StateC").CellText(e.Row) <> "1" Then
            e.CellStyle.BackColor = System.Drawing.Color.Linen
        End If
        If Me.C1DBGH.Columns("CHI_VESSEL").CellText(e.Row) <> "HCHE" Then
            e.CellStyle.BackColor = System.Drawing.Color.DarkSlateBlue
        End If
    End Sub

    Private Sub btnTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrans.Click
        Dim strNewNo As String
        Try
            If lbCon.Items.Count > 0 Then
                If shipMark = True Then
                    If strVoyage <> "" And strBillNo <> "" Then

                        Me.C1DBGH.Focus()
                        If Me.cbPass.Checked = True Then    '查验导出
                            For i = 0 To dvConHche.Count - 1
                                Me.C1DBGH.Row = i
                                If Me.C1DBGH.Columns("CHI_VESSEL").Text <> "HCHE" Then
                                    Me.C1DBGH.Columns("CHI_VESSEL").Text = strShip
                                    Me.C1DBGH.Columns("Voyage").Text = strVoyage
                                    Me.C1DBGH.Columns("BLNO").Text = strBillNo
                                    Me.C1DBGH.Columns("StateC").Text = "1"
                                End If
                            Next
                        Else    '未进码头，状态为0
                            For i = 0 To dvConHche.Count - 1
                                Me.C1DBGH.Row = i
                                If Me.C1DBGH.Columns("CHI_VESSEL").Text <> "HCHE" Then
                                    Me.C1DBGH.Columns("CHI_VESSEL").Text = strShip
                                    Me.C1DBGH.Columns("Voyage").Text = strVoyage
                                    Me.C1DBGH.Columns("BLNO").Text = strBillNo
                                    Me.C1DBGH.Columns("StateC").Text = "0"
                                End If
                            Next
                        End If
                        Me.btQuit.Focus()

                    Else
                        Me.txtVoyage.Focus()
                        MessageBox.Show("航次提单号不能为空", "提示")
                        Exit Sub
                    End If
                Else
                    Me.txtShip.Focus()
                    MessageBox.Show("船码 " & strShip & " 不存在，请重新输入", "提示")
                    Exit Sub
                End If
            Else
                MessageBox.Show("请选择要处理的箱号", "提示")
                Exit Sub
            End If

            If MessageBox.Show("确定检查无误，更改关系么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Dim sqlExistBill, sqlGetBill, strAutoNo As String
                sqlExistBill = "SELECT BLNO FROM CON_LOAD_TALLY WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' AND WORK_PLACE = '" & strYard & "'"
                If Filldata(sqlExistBill).Count = 0 Then   '没有提单场站信息 加  
                    strNewNo = GetAutoNo(strYard)    '生成理货单编号
                    sqlGetBill = "INSERT INTO CON_LOAD_TALLY (CHI_VESSEL, Voyage, InOutPort, CodeLoadPort, NO, WORK_PLACE, TIME_FROM, BLNO, WORKTYPE, CODE_TALLY_TYPE, USER_NAME, CODE_CON_CONSIGN, StateB) " & _
                                               "VALUES ('" & strShip & "', '" & strVoyage & "', '1', 'LYG', '" & strNewNo & "', '" & strYard & "', '" & Now & "', '" & strBillNo & "', '2', '3', '" & G_User & "', '00', '1')"
                    ExecSql(sqlGetBill)
                End If
                daConHche.Update(dsConHche)

                Call GetConHche()
                sqlContainer = "SELECT CON_LOAD_TALLY_LIST_ID,CON_LOAD_TALLY_ID,SHIP_ID,CHI_VESSEL,Voyage,BLNO,CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,PACK_CHA,PACK_ENG,AMOUNT,WEIGHT,NetWeight,VOLUME,DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,USER_NAME,CodeYard,ReeferTemp,TempUnit,DangerGrade,DangerMark,Checked,CheckTime,Printed,PrintTime,PrintPerson,StateC,FullOrEmpty " & _
                    " FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' AND CodeYard = '" & strYard & "' order by CONTAINER_NO "
                Call GetContainer(sqlContainer)
                Me.lbCon.Items.Clear()
                Me.lbCount.Text = "计0条"
                blSave = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function GetAutoNo(ByVal strYardValue As String) As String  '得到理货单编号，场站代码为参数
        Dim strAutoNo, sqlAutoNO, sqlUpdateYard As String
        Dim dvAutoNO As New DataView
        Dim iYear, iMaxNo As Integer
        strAutoNo = ""
        sqlAutoNO = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix, CodeMax, CodeYear, DeptCode FROM Code_Yard where Code_Yard_ID = '" & strYardValue & "'"
        dvAutoNO = Filldata(sqlAutoNO)
        If dvAutoNO.Count > 0 Then
            iYear = dvAutoNO(0)("CodeYear")
            iMaxNo = dvAutoNO(0)("CodeMax")
            If iYear + 1 = Now.Year Then    '如果到了下一年 年份加一 编号重置
                iYear = Now.Year
                iMaxNo = 1          '是否可以有0编号？不要
            Else    '否则编号加一
                iMaxNo = iMaxNo + 1
            End If
            '及时更新场站代码表最值、年值 减少冲突
            sqlUpdateYard = "update Code_Yard set CodeMax='" & iMaxNo & "', CodeYear='" & iYear & "' where Code_Yard_ID='" & strYardValue & "'"
            ExecSql(sqlUpdateYard)
            '生成编号
            strAutoNo = String.Concat(dvAutoNO(0)("CodePrefix"), iYear.ToString, Microsoft.VisualBasic.Right(String.Concat("00000", iMaxNo.ToString), 6))
        End If
        Return strAutoNo
    End Function

    Private Function CheckConNO(ByVal sm As String) As Integer 'return 0 箱号有错 1 校验有错 2 校验正确
        Dim S() As Integer = {10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 34, 35, 36, 37, 38}
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim l As Integer
        i = 0
        str = UCase(sm)
        If Len(Trim(str)) = 12 And Mid(Trim(str), 5, 1) = " " Then
            str = Mid(Trim(str), 1, 4) & Mid(Trim(str), 6, 7)
        ElseIf Len(Trim(str)) <> 11 Then
            Return 0
        End If
        k = 1
        For j = 1 To 4
            If Asc(Mid(Trim(str), j, 1)) >= Asc("A") And Asc(Mid(Trim(str), j, 1)) <= Asc("Z") Then
                i = i + S(Asc(Mid(Trim(str), j, 1).ToUpper) - Asc("A")) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next

        For j = 5 To 10
            If Asc(Mid(Trim(str), j, 1)) >= Asc("0") And Asc(Mid(Trim(str), j, 1)) <= Asc("9") Then
                i = i + CInt(Mid(Trim(str), j, 1)) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next
        If i Mod 11 = CInt(Mid(Trim(str), 11, 1)) Or (i Mod 11) - 10 = CInt(Mid(Trim(str), 11, 1)) Then
            Return 2
        Else
            Return 1
        End If
    End Function

    Private Function IsEqualConNo(ByVal ConOne As String, ByVal ConTwo As String) As Boolean    '判断箱号是否箱等
        Dim Flag As Boolean
        ConOne = ConOne.Trim.ToUpper
        ConTwo = ConTwo.Trim.ToUpper
        If ConOne.Length = ConTwo.Length Then
            If String.Equals(ConOne, ConTwo) Then
                Flag = True
            End If
        Else
            If String.Equals(ConOne, GetConOtherMode(ConTwo)) Then
                Flag = True
            End If
        End If
        Return Flag
    End Function

    Private Function GetConOtherMode(ByVal ConNo As String) As String   '得到箱号的另一种无空或有空形式
        ConNo = ConNo.Trim.ToUpper
        If ConNo.Length = 11 Then
            ConNo = ConNo.Insert(4, " ")
        ElseIf ConNo.Length = 12 Then
            ConNo = ConNo.Remove(4, 1)
        End If
        Return ConNo
    End Function

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim i, j As Integer

            Count = Count - delSum
            Me.C1DBG.Focus()
            For i = 0 To Count - 1
                Me.C1DBG.Row = i
                'Me.C1DBG.Columns("BLNO").Text = Me.C1DBG.Columns("BLNO").Text.Trim().ToUpper
                Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").Text.Trim().ToUpper
                Me.C1DBG.Columns("NEWSEALNO").Text = Me.C1DBG.Columns("NEWSEALNO").Text.Trim().ToUpper
                Me.C1DBG.Columns("CONTAINER_TYPE").Text = Me.C1DBG.Columns("CONTAINER_TYPE").Text.Trim().ToUpper
                Me.C1DBG.Columns("SecSealNO").Text = Me.C1DBG.Columns("SecSealNO").Text.Trim().ToUpper
                Me.C1DBG.Columns("ReasonOpenSeal").Text = Me.C1DBG.Columns("ReasonOpenSeal").Text.Trim()
                Me.C1DBG.Columns("DangerGrade").Text = Me.C1DBG.Columns("DangerGrade").Text.Trim()
                Me.C1DBG.Columns("DangerMark").Text = Me.C1DBG.Columns("DangerMark").Text.Trim()
                'Me.C1DBG.Columns("CHI_VESSEL").Text = strShip
                'Me.C1DBG.Columns("Voyage").Text = strVoyage
            Next
            Me.btQuit.Focus()

            Dim iConCheck, iConBeing As Integer
            Dim sqlBeing As String

            For i = 0 To Count - 1    '界面上检查箱号
                If Me.C1DBG.Columns("CONTAINER_NO").CellText(i) <> "" Then
                    iConCheck = CheckConNO(Me.C1DBG.Columns("CONTAINER_NO").CellText(i))
                    '箱号没有通过检验时
                    If iConCheck = 1 Or iConCheck = 0 Then
                        sqlBeing = "SELECT CONTAINER_NO FROM CON_CRITERION WHERE CONTAINER_NO = '" & C1DBG.Columns("CONTAINER_NO").CellText(i) & "' or CONTAINER_NO = '" & GetConOtherMode(C1DBG.Columns("CONTAINER_NO").CellText(i)) & "'"
                        iConBeing = Filldata(sqlBeing).Count
                        If iConBeing = 0 Then    '箱规范中不存在
                            Me.C1DBG.Row = i
                            Me.C1DBG.Col = 2
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            If MessageBox.Show("集装箱号 " & C1DBG.Columns("CONTAINER_NO").CellText(i) & " 校验不正确且在不存在于箱规范中！确定存在吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                Exit For
                            End If
                        End If
                    ElseIf iConCheck = 0 Then
                        Me.C1DBG.Row = i
                        Me.C1DBG.Col = 2
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        MessageBox.Show("集装箱号不规范！", "提示")
                        Exit For
                    End If

                    For j = 0 To i - 1
                        If IsEqualConNo(Me.C1DBG.Columns("CONTAINER_NO").CellText(i), Me.C1DBG.Columns("CONTAINER_NO").CellText(j)) Then
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            Me.C1DBG.SelectedRows.Add(j)
                            MessageBox.Show("第" & j + 1 & "行和第" & i + 1 & "行 同一提单下集装箱号重复！", "提示")
                            Exit Sub
                        End If
                    Next
                Else
                    Me.C1DBG.Row = i
                    Me.C1DBG.Col = 2
                    Me.C1DBG.SelectedRows.Clear()
                    Me.C1DBG.SelectedRows.Add(i)
                    MessageBox.Show("集装箱号不能为空！", "提示")
                    Exit For
                End If
            Next

            If Not IsNothing(Me.C1DBG.DataSource) Then
                If i >= Count Then     '全部通过检验
                    If MessageBox.Show("确定对以上箱信息的修改删除么？", "警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                        '记录操作日志
                        ExecSql("Exec sp_ConLoadTallyListOperPre '" & G_DeptName & "','" & Now & "','" & G_User & "'")

                        daContainer.Update(dsContainer)
                        MessageBox.Show("修改成功！", "")
                        Me.btQuit.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColEdit
        If e.ColIndex = 6 Then
            Dim sqlBeing As String = "SELECT * FROM CON_CRITERION WHERE CONTAINER_NO = '" & Me.C1DBG.Columns("CONTAINER_NO").Text.Trim.ToUpper & "' or CONTAINER_NO = '" & GetConOtherMode(Me.C1DBG.Columns("CONTAINER_NO").Text) & "'"
            Dim dvBeing As New DataView
            dvBeing = Filldata(sqlBeing)
            If dvBeing.Count >= 1 Then
                Me.C1DBG.Columns("SIZE_CON").Value = dvBeing.Item(0)("SIZE_CON")
                Me.C1DBG.Columns("CONTAINER_TYPE").Value = dvBeing.Item(0)("CONTAINER_TYPE")
            End If
        ElseIf e.ColIndex = 23 Then
            If IsNumeric(Me.C1DBG.Columns("ReeferTemp").Text) Then
                If Me.C1DBG.Columns("TempUnit").Text <> "C" AndAlso Me.C1DBG.Columns("TempUnit").Text <> "F" Then
                    Me.C1DBG.Columns("TempUnit").Text = "C"
                End If
            End If
        ElseIf e.ColIndex = 24 Then
            If Me.C1DBG.Columns("TempUnit").Text <> Me.C1DBG.Columns("TempUnit").Text.Trim.ToUpper Then
                Me.C1DBG.Columns("TempUnit").Text = Me.C1DBG.Columns("TempUnit").Text.Trim.ToUpper
            End If
        End If
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Return And (Me.C1DBG.Col = 19 OrElse Me.C1DBG.Col = 25) Then
            Me.C1DBG.Row += 1
            Me.C1DBG.Col = 2
            SendKeys.Send("{LEFT}")
        End If
    End Sub

    Private Sub C1DBG_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterDelete
        delSum += 1
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "合计" & Count - delSum & "箱"
    End Sub

    Private Sub txtShip_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShip.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtVoyage.Focus()
        End If
    End Sub

    Private Sub txtVoyage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoyage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtBillNO.Focus()
        End If
    End Sub

    Private Sub txtBillNO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBillNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnGetData.Focus()
        End If
    End Sub

    Private Sub cbPlace_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbPlace.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnGetData.Focus()
        End If
    End Sub

    Private Sub txtContainerNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContainerNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnGet.Focus()
        End If
    End Sub

    Private Sub txtShip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtShip.Leave
        Me.txtShip.Text = Me.txtShip.Text.Trim.ToUpper
        strShip = Me.txtShip.Text
        sqlShipCode = "SELECT SPCODE, CHI_VESSEL,ENG_VESSEL FROM Code_SHIPNAME WHERE (SPCODE = '" & strShip & "' or CHI_VESSEL = '" & strShip & "')"
        dvShipCode = Filldata(sqlShipCode)
        Me.txtShipName.Clear()
        If dvShipCode.Count > 0 Then
            strShip = dvShipCode(0)("SPCODE")
            Me.txtShip.Text = strShip
            If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                Me.txtShipName.Text = dvShipCode(0)("CHI_VESSEL")
            End If
            If Not IsDBNull(dvShipCode(0)("ENG_VESSEL")) Then
                Me.txtShipName.Text += "/" & dvShipCode(0)("ENG_VESSEL")
            End If
            shipMark = True
        Else
            shipMark = False
            MessageBox.Show("船码 " & strShip & " 不存在，请重新输入", "提示")
        End If
    End Sub

    Private Sub txtVoyage_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVoyage.Leave
        Me.txtVoyage.Text = Me.txtVoyage.Text.Trim.ToUpper
        strVoyage = Me.txtVoyage.Text
    End Sub

    Private Sub txtBillNO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNO.Leave
        Me.txtBillNO.Text = Me.txtBillNO.Text.Trim.ToUpper
        strBillNo = Me.txtBillNO.Text
    End Sub

    Private Sub cbPlace_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPlace.Leave
        strYard = Me.cbPlace.SelectedValue
    End Sub

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        If shipMark = True And strBillNo <> "" And strVoyage <> "" Then
            If strOperYard = "08" Then  '监管信息中心可改全部
                sqlContainer = "SELECT CON_LOAD_TALLY_LIST_ID,CON_LOAD_TALLY_ID,SHIP_ID,CHI_VESSEL,Voyage,BLNO,CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,PACK_CHA,PACK_ENG,AMOUNT,WEIGHT,NetWeight,VOLUME,DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,USER_NAME,CodeYard,ReeferTemp,TempUnit,DangerGrade,DangerMark,Checked,CheckTime,Printed,PrintTime,PrintPerson,StateC,FullOrEmpty " & _
                    " FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' AND CodeYard = '" & strYard & "' order by CONTAINER_NO "
            Else
                sqlContainer = "SELECT CON_LOAD_TALLY_LIST_ID,CON_LOAD_TALLY_ID,SHIP_ID,CHI_VESSEL,Voyage,BLNO,CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,PACK_CHA,PACK_ENG,AMOUNT,WEIGHT,NetWeight,VOLUME,DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,USER_NAME,CodeYard,ReeferTemp,TempUnit,DangerGrade,DangerMark,Checked,CheckTime,Printed,PrintTime,PrintPerson,StateC,FullOrEmpty " & _
                    " FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' AND CodeYard = '" & strYard & "' and StateC <=1 order by CONTAINER_NO "
            End If
            Call GetContainer(sqlContainer)
        End If
    End Sub

    Private Sub btnCallPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCallPrint.Click
        Dim sqlGetID As String
        Dim dvGetID As New DataView
        sqlGetID = "select CON_LOAD_TALLY_ID, CHI_VESSEL, VOYAGE, BLNO from CON_LOAD_Tally where BLNO = '" & strBillNo & _
                                            "' and CHI_VESSEL = '" & strShip & _
                                            "' and VOYAGE = '" & strVoyage & "' AND Work_Place = '" & strYard & "'"
        ID = 0
        Try
            dvGetID = Filldata(sqlGetID)
            If dvGetID.Count > 0 Then
                ID = dvGetID(0)("CON_LOAD_TALLY_ID")
                Dim FrmPrint As New FrmContainerOutPort_Query
                FrmPrint.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
