Imports TALLY.DBControl
Public Class FrmConSealExam_Add
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim Count As Integer
    Dim dvSealNo As New DataView()

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtNo.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler ccbContainer.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler ccbNewSealNo.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler txtWorkPlace.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler txtOriginalSealNO.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler cbOgSealCondition.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler txtRemark.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler cbSealType.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler dtpTimeBegin.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler dtpTimeEnd.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler cbSealKind.KeyDown, AddressOf FrmConSealExam_Add_KeyDown
        AddHandler cbSealPerson.KeyDown, AddressOf FrmConSealExam_Add_KeyDown

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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbSealType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtOriginalSealNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWorkPlace As System.Windows.Forms.TextBox
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents cbOgSealCondition As System.Windows.Forms.ComboBox
    Friend WithEvents cbSealKind As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbSealPerson As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ccbNewSealNo As C1.Win.C1List.C1Combo
    Friend WithEvents ccbContainer As C1.Win.C1List.C1Combo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConSealExam_Add))
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnClear = New System.Windows.Forms.Button
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.txtRemark = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbSealType = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtOriginalSealNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtWorkPlace = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbOgSealCondition = New System.Windows.Forms.ComboBox
        Me.cbSealKind = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbSealPerson = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.ccbNewSealNo = New C1.Win.C1List.C1Combo
        Me.ccbContainer = New C1.Win.C1List.C1Combo
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccbNewSealNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccbContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(190, 375)
        Me.C1DBG.TabIndex = 11
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionH" & _
        "eight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><Height>371</Height><CaptionStyle parent=""Style2"" me=" & _
        """Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""Eve" & _
        "nRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterSty" & _
        "le parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><Head" & _
        "ingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow""" & _
        " me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle paren" & _
        "t=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style1" & _
        "1"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""S" & _
        "tyle1"" /><ClientRect>0, 0, 186, 371</ClientRect><BorderSide>0</BorderSide><Borde" & _
        "rStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles" & _
        "><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style par" & _
        "ent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent" & _
        "=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=" & _
        """Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=" & _
        """Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Head" & _
        "ing"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent" & _
        "=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</h" & _
        "orzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><Clien" & _
        "tArea>0, 0, 186, 371</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" />" & _
        "<PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(202, 348)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 24)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "清空"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(338, 348)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 12
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(270, 348)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 11
        Me.btSave.Text = "确认"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(202, 296)
        Me.txtRemark.MaxLength = 100
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(200, 46)
        Me.txtRemark.TabIndex = 14
        Me.txtRemark.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(198, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 267
        Me.Label10.Text = "备注"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(198, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 266
        Me.Label9.Text = "原铅封情况"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(272, 208)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeEnd.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(198, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 265
        Me.Label8.Text = "结束时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(272, 184)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeBegin.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(198, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 264
        Me.Label7.Text = "开始时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSealType
        '
        Me.cbSealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSealType.Location = New System.Drawing.Point(272, 136)
        Me.cbSealType.Name = "cbSealType"
        Me.cbSealType.Size = New System.Drawing.Size(130, 20)
        Me.cbSealType.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(198, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 263
        Me.Label6.Text = "机械封类型"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOriginalSealNO
        '
        Me.txtOriginalSealNO.Location = New System.Drawing.Point(272, 232)
        Me.txtOriginalSealNO.MaxLength = 20
        Me.txtOriginalSealNO.Name = "txtOriginalSealNO"
        Me.txtOriginalSealNO.Size = New System.Drawing.Size(130, 21)
        Me.txtOriginalSealNO.TabIndex = 7
        Me.txtOriginalSealNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(198, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 262
        Me.Label4.Text = "原铅封号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(198, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 261
        Me.Label5.Text = "新铅封号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(198, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 260
        Me.Label3.Text = "集装箱号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(190, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 259
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtWorkPlace
        '
        Me.txtWorkPlace.Location = New System.Drawing.Point(272, 160)
        Me.txtWorkPlace.MaxLength = 50
        Me.txtWorkPlace.Name = "txtWorkPlace"
        Me.txtWorkPlace.Size = New System.Drawing.Size(130, 21)
        Me.txtWorkPlace.TabIndex = 4
        Me.txtWorkPlace.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(198, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 270
        Me.Label1.Text = "工作地点"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(272, 6)
        Me.txtNo.MaxLength = 10
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(130, 21)
        Me.txtNo.TabIndex = 0
        Me.txtNo.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(198, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 272
        Me.Label2.Text = "编号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbOgSealCondition
        '
        Me.cbOgSealCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOgSealCondition.Location = New System.Drawing.Point(272, 256)
        Me.cbOgSealCondition.Name = "cbOgSealCondition"
        Me.cbOgSealCondition.Size = New System.Drawing.Size(130, 20)
        Me.cbOgSealCondition.TabIndex = 275
        '
        'cbSealKind
        '
        Me.cbSealKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSealKind.Location = New System.Drawing.Point(272, 88)
        Me.cbSealKind.Name = "cbSealKind"
        Me.cbSealKind.Size = New System.Drawing.Size(130, 20)
        Me.cbSealKind.TabIndex = 276
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(200, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 277
        Me.Label11.Text = "铅封类型"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSealPerson
        '
        Me.cbSealPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSealPerson.Location = New System.Drawing.Point(272, 112)
        Me.cbSealPerson.Name = "cbSealPerson"
        Me.cbSealPerson.Size = New System.Drawing.Size(130, 20)
        Me.cbSealPerson.TabIndex = 278
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(200, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 279
        Me.Label12.Text = "施封人"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ccbNewSealNo
        '
        Me.ccbNewSealNo.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.ccbNewSealNo.AutoDropDown = True
        Me.ccbNewSealNo.Caption = ""
        Me.ccbNewSealNo.CaptionHeight = 17
        Me.ccbNewSealNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ccbNewSealNo.ColumnCaptionHeight = 18
        Me.ccbNewSealNo.ColumnFooterHeight = 18
        Me.ccbNewSealNo.ColumnHeaders = False
        Me.ccbNewSealNo.ContentHeight = 16
        Me.ccbNewSealNo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.ccbNewSealNo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.ccbNewSealNo.EditorFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ccbNewSealNo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.ccbNewSealNo.EditorHeight = 16
        Me.ccbNewSealNo.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.ccbNewSealNo.ItemHeight = 15
        Me.ccbNewSealNo.Location = New System.Drawing.Point(272, 60)
        Me.ccbNewSealNo.MatchEntryTimeout = CType(2000, Long)
        Me.ccbNewSealNo.MaxDropDownItems = CType(20, Short)
        Me.ccbNewSealNo.MaxLength = 32767
        Me.ccbNewSealNo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.ccbNewSealNo.Name = "ccbNewSealNo"
        Me.ccbNewSealNo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.ccbNewSealNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.ccbNewSealNo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ccbNewSealNo.Size = New System.Drawing.Size(130, 22)
        Me.ccbNewSealNo.TabIndex = 332
        Me.ccbNewSealNo.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'ccbContainer
        '
        Me.ccbContainer.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.ccbContainer.AutoDropDown = True
        Me.ccbContainer.Caption = ""
        Me.ccbContainer.CaptionHeight = 17
        Me.ccbContainer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ccbContainer.ColumnCaptionHeight = 18
        Me.ccbContainer.ColumnFooterHeight = 18
        Me.ccbContainer.ColumnHeaders = False
        Me.ccbContainer.ContentHeight = 16
        Me.ccbContainer.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.ccbContainer.EditorBackColor = System.Drawing.SystemColors.Window
        Me.ccbContainer.EditorFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ccbContainer.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.ccbContainer.EditorHeight = 16
        Me.ccbContainer.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.ccbContainer.ItemHeight = 15
        Me.ccbContainer.Location = New System.Drawing.Point(272, 32)
        Me.ccbContainer.MatchEntryTimeout = CType(2000, Long)
        Me.ccbContainer.MaxDropDownItems = CType(20, Short)
        Me.ccbContainer.MaxLength = 32767
        Me.ccbContainer.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.ccbContainer.Name = "ccbContainer"
        Me.ccbContainer.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.ccbContainer.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.ccbContainer.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ccbContainer.Size = New System.Drawing.Size(130, 22)
        Me.ccbContainer.TabIndex = 331
        Me.ccbContainer.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
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
        'FrmConSealExam_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(412, 375)
        Me.Controls.Add(Me.ccbNewSealNo)
        Me.Controls.Add(Me.ccbContainer)
        Me.Controls.Add(Me.cbSealPerson)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbSealKind)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbOgSealCondition)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtWorkPlace)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpTimeEnd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpTimeBegin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbSealType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtOriginalSealNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.C1DBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConSealExam_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱验封施封信息 增加"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccbNewSealNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccbContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConSealExam_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim dvSealType As New DataView()
        Dim dvWorkType As New DataView()
        Dim sqlstr, sqlSealType, sqlWorkType As String
        Me.StartPosition = FormStartPosition.CenterScreen

        Dim dvConInfo As New DataView()
        Dim sqlConInfo As String    '显示该船次所有箱号铅封号
        'sqlConInfo = "SELECT CON_TALLY_DETAIL.CONTAINER_NO, CON_TALLY_DETAIL.SEALNO FROM CON_TALLY_DETAIL INNER JOIN CON_TALLY_LIST ON CON_TALLY_DETAIL.CON_TALLY_LIST_ID = CON_TALLY_LIST.CON_TALLY_LIST_ID WHERE CON_TALLY_LIST.SHIP_ID = '" & Ship_ID & "' ORDER BY CON_TALLY_DETAIL.CONTAINER_NO"
        sqlConInfo = "SELECT CONTAINER_NO,SEALNO FROM Con_Hatch_Record WHERE SHIP_ID = '" & Ship_ID & "' ORDER BY CONTAINER_NO"
        dvConInfo = Filldata(sqlConInfo)
        Me.C1DBG.DataSource = dvConInfo
        Me.C1DBG.Columns("CONTAINER_NO").Caption = "集装箱号"
        Me.C1DBG.Columns("SEALNO").Caption = "铅封号"
        Count = dvConInfo.Count
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "共" & Count & "条记录"
        Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 78
        Me.C1DBG.Splits(0).DisplayColumns("SEALNO").Width = 80

        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

        ccbContainer.DataSource = Filldata(sqlConInfo)
        ccbContainer.DisplayMember = "CONTAINER_NO"
        ccbContainer.ValueMember = "CONTAINER_NO"
        Me.ccbContainer.Splits(0).DisplayColumns("CONTAINER_NO").AutoSize()
        Me.ccbContainer.Splits(0).DisplayColumns("SEALNO").AutoSize()
        Me.ccbContainer.DropDownWidth = Me.ccbContainer.Splits(0).DisplayColumns("CONTAINER_NO").Width + Me.ccbContainer.Splits(0).DisplayColumns("SEALNO").Width + 20

        Dim sqlSealNo As String
        '选出本部门可用铅封号
        sqlSealNo = "select SEALNO from SEAL_RECORD where Dept_Code= '" & G_DeptCode & "' and SEAL_STATE = '2' and Use_Mark='0' and Logout_Mark='0' order by SEALNO "
        dvSealNo = Filldata(sqlSealNo)
        ccbNewSealNo.DataSource = dvSealNo
        ccbNewSealNo.DisplayMember = "SEALNO"
        ccbNewSealNo.ValueMember = "SEALNO"
        Me.ccbNewSealNo.Splits(0).DisplayColumns("SEALNO").AutoSize()
        Me.ccbNewSealNo.DropDownWidth = Me.ccbNewSealNo.Splits(0).DisplayColumns("SEALNO").Width + 20

        sqlSealType = "select Code_Seal_Type,Seal_Type from Code_Seal_Type  "
        dvSealType = Filldata(sqlSealType)
        cbSealType.DataSource = dvSealType
        cbSealType.DisplayMember = "Seal_Type"
        cbSealType.ValueMember = "Code_Seal_Type"

        Dim sqlOgSealCondition As String = "SELECT Code_SealCircs, SealCircs_CHI, SealCircs_Eng FROM Code_SealCircs ORDER BY Code_SealCircs"
        Dim dvOgSealCondition As New DataView()
        dvOgSealCondition = Filldata(sqlOgSealCondition)
        Me.cbOgSealCondition.DataSource = dvOgSealCondition
        Me.cbOgSealCondition.DisplayMember = "SealCircs_CHI"
        Me.cbOgSealCondition.ValueMember = "Code_SealCircs"

        Dim sqlSealkind As String
        Dim dvSealkind As DataView
        sqlSealkind = "SELECT ID, Code, KindDesc FROM Code_SealKind ORDER BY ID"
        dvSealkind = Filldata(sqlSealkind)
        Me.cbSealKind.DataSource = dvSealkind
        Me.cbSealKind.DisplayMember = "KindDesc"
        Me.cbSealKind.ValueMember = "Code"
        Dim sqlSealPerson As String
        Dim dvSealPerson As DataView
        sqlSealPerson = "SELECT ID, Code, PersonDesc FROM Code_SealPerson ORDER BY ID"
        dvSealPerson = Filldata(sqlSealPerson)
        Me.cbSealPerson.DataSource = dvSealPerson
        Me.cbSealPerson.DisplayMember = "PersonDesc"
        Me.cbSealPerson.ValueMember = "Code"

        sqlstr = "select * from Seal_Exam where SEAL_EXAM_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        dtpTimeEnd.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("ID")
            'txtShip.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            'txtVoyage.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            txtNo.Text = ds.Tables(0).Rows(0).Item("NO")
            ccbContainer.Text = ds.Tables(0).Rows(0).Item("CONTAINER_NO")
            ccbNewSealNo.Text = ds.Tables(0).Rows(0).Item("NEWSEALNO")
            cbSealKind.SelectedValue = ds.Tables(0).Rows(0).Item("SealType")
            cbSealPerson.SelectedValue = ds.Tables(0).Rows(0).Item("SealPerson")
            cbSealType.SelectedValue = ds.Tables(0).Rows(0).Item("Seal_Type")
            txtWorkPlace.Text = ds.Tables(0).Rows(0).Item("WORK_PLACE")
            txtOriginalSealNO.Text = ds.Tables(0).Rows(0).Item("ORIGINESEALNO")
            Me.cbOgSealCondition.SelectedValue = ds.Tables(0).Rows(0).Item("ORIGINESEALNO_CONDITION")
            txtRemark.Text = ds.Tables(0).Rows(0).Item("REMARK")
            dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")
            dtpTimeEnd.Value = ds.Tables(0).Rows(0).Item("TIME_TO")
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        Me.ccbContainer.SelectedValue = Me.C1DBG.Columns("CONTAINER_NO").Text
        Me.txtOriginalSealNO.Text = Me.C1DBG.Columns("SEALNO").Text
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.txtNo.Clear()
        Me.ccbContainer.SelectedValue = ""
        Me.ccbNewSealNo.SelectedValue = ""
        Me.txtWorkPlace.Clear()
        Me.txtOriginalSealNO.Clear()
        Me.cbOgSealCondition.SelectedValue = "00"
        Me.txtRemark.Clear()
        Me.cbSealType.SelectedValue = "0"
        Me.dtpTimeBegin.Value = Now
        Me.dtpTimeEnd.Value = Now
        Me.cbSealKind.SelectedIndex = 0
        Me.cbSealPerson.SelectedIndex = 0
    End Sub
  
    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim strNewSeal, strOldSeal, strsqlNoCon, strsql, strsqlexist, strsqlstate As String
        Dim dv As New DataView()
        Dim i As Integer
        strNewSeal = UCase(Trim(ccbNewSealNo.Text))      '铅封号保存全部大写
        strOldSeal = UCase(Trim(txtOriginalSealNO.Text))
        strsqlNoCon = "select * from seal_exam where SHIP_ID= '" & Ship_ID & _
            "' and ( CONTAINER_NO= '" & Trim(ccbContainer.Text) & "' or NO = '" & Trim(txtNo.Text) & "')"
        strsql = "select * from SEAL_EXAM where "
        'strsqlexist = "select * from SEAL_RECORD where SEALNO = '" & strNewSeal & "'"
        'strsqlstate = "select * from SEAL_RECORD where SEALNO = '" & strNewSeal & _
        '    "' and Dept_Code= '" & G_DeptCode & "' and SEAL_STATE = '2' "
        Dim Mark As Boolean = False
        Try
            If Trim(txtNo.Text) <> "" Then
                If ccbContainer.SelectedValue <> Nothing Then
                    If DateDiff(DateInterval.Minute, Me.dtpTimeBegin.Value, Me.dtpTimeEnd.Value) >= 0 Then
                        If ccbNewSealNo.SelectedValue <> Nothing Or strNewSeal = "" Then
                            Mark = True
                        Else
                            For i = 0 To dvSealNo.Count - 1
                                If dvSealNo.Item(i)("SEALNO") = strNewSeal Then Exit For
                            Next
                            If i < dvSealNo.Count Then
                                Mark = True
                            Else
                                Me.ccbNewSealNo.Focus()
                                If MessageBox.Show("新铅封号不存在，确定吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                                    Mark = True
                                End If
                            End If
                        End If
                    Else
                        Me.dtpTimeBegin.Focus()
                        MessageBox.Show("开始时间应在结束时间之前。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    Me.ccbContainer.Focus()
                    MessageBox.Show("请选择集装箱号！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Me.txtNo.Focus()
                MessageBox.Show("编号不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If Mark = True Then
                If Filldata(strsqlNoCon).Count = 0 Then
                    If strNewSeal <> "" Then        '新加铅封号不为空
                        'If verifySealSingle(strNewSeal) Then        '铅封检验   在此不必了 因为都是从库表中选出的
                        dv = Filldata(strsql & " NEWSEALNO = '" & strNewSeal & "'")
                        If dv.Count = 0 Then        '新加铅封未使用过     
                            'If Filldata(strsqlexist).Count = 1 Then     '此铅封已入库   在此不必了  因为所选出的铅封号都是在库的
                            '    If Filldata(strsqlstate).Count = 1 Then '新铅封状态检查通过  在此不必了  因为所选出的铅封号都是能用的
                            '添加此施封记录，然后在库表中修改此铅封记录
                            If strOldSeal = "" Then
                                If Me.cbOgSealCondition.SelectedValue = "00" Then
                                    AddSealExam(strNewSeal, strOldSeal)         '只施封
                                    Me.Close()
                                Else
                                    Me.cbOgSealCondition.Focus()
                                    MessageBox.Show("不验封时不能选原铅封情况！", "错误提示")
                                End If
                            Else
                                'If verifySealSingle(strOldSeal) Then
                                dv = Filldata(strsql & " ORIGINESEALNO = '" & strOldSeal & "'")
                                If dv.Count = 0 Then    '原铅封可以增加
                                    AddSealExam(strNewSeal, strOldSeal)     '验封后再施封
                                    Me.Close()
                                Else
                                    MessageBox.Show("已存在验封施封记录，请检查", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                                'Else
                                'MessageBox.Show("旧铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                'End If
                            End If
                            '    Else
                            '        MessageBox.Show("新铅封号不在本部门或已被使用或注销！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            '    End If
                            'Else    '此铅封未入库
                            'End If
                        Else
                            MessageBox.Show("已存在施封记录，请检查", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        'Else
                        '    MessageBox.Show("新铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'End If
                    Else        '新加铅封号为空,只验封不施封，输入旧铅封号
                        If strOldSeal <> "" Then
                            If cbSealType.SelectedValue = 0 Then
                                'If verifySealSingle(strOldSeal) Then    '铅封检验
                                dv = Filldata(strsql & " ORIGINESEALNO = '" & strOldSeal & "'")
                                If dv.Count = 0 Then    '原铅封可以增加
                                    AddSealExam(strNewSeal, strOldSeal)     '只验封
                                    Me.Close()
                                Else
                                    MessageBox.Show("已存在验封记录，请检查", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                                'Else
                                '    MessageBox.Show("旧铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                'End If
                            Else
                                Me.cbSealType.Focus()
                                MessageBox.Show("不施封时不能选新加铅封类型！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            Me.ccbNewSealNo.Focus()
                            MessageBox.Show("新旧铅封号不能全为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Else
                    Me.txtNo.Focus()
                    MessageBox.Show("编号或箱号已被使用过，不可重复", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As System.Exception
            'MessageBox.Show(ex.Message, "意外处理", MessageBoxButtons.OK)
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddSealExam(ByVal strNewSeal As String, ByVal strOldSeal As String)
        Dim row As DataRow
        row = ds.Tables(0).NewRow()

        'row.Item("CHI_VESSEL") = Trim(txtShip.Text)
        'row.Item("VOYAGE") = Trim(txtVoyage.Text)

        row.Item("NO") = Trim(txtNo.Text)
        row.Item("CONTAINER_NO") = Trim(ccbContainer.Text)
        row.Item("NEWSEALNO") = strNewSeal
        row.Item("ORIGINESEALNO") = strOldSeal
        row.Item("ORIGINESEALNO_CONDITION") = Me.cbOgSealCondition.SelectedValue
        row.Item("REMARK") = Trim(txtRemark.Text)
        row.Item("WORK_PLACE") = Trim(txtWorkPlace.Text)

        row.Item("TIME_FROM") = dtpTimeBegin.Value
        row.Item("TIME_TO") = dtpTimeEnd.Value
        row.Item("Seal_Type") = cbSealType.SelectedValue
        row.Item("SealType") = cbSealKind.SelectedValue
        row.Item("SealPerson") = cbSealPerson.SelectedValue

        row.Item("Ship_ID") = Ship_ID
        row.Item("WORKTYPE") = "2"
        row.Item("Dept_Code") = G_DeptCode
        row.Item("USER_NAME") = G_User

        ds.Tables(0).Rows.Add(row)
        sqlda.Update(ds)
    End Sub

    Private Function verifySealSingle(ByVal strSeal As String) As Boolean   '大写非空字符串 COSCATO34582
        Dim i As Short
        Dim c As Char
        If Len(strSeal) >= 2 Then
            For i = Len(strSeal) To 1 Step -1
                c = Mid(strSeal, i, 1)
                If c >= "0" And c <= "9" Then

                Else
                    If c >= "A" And c <= "Z" Then
                        Exit For
                    Else
                        MessageBox.Show("存在非法字符", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If i >= 1 And i < Len(strSeal) Then ' 从exit for 来
                For i = i - 1 To 1 Step -1
                    c = Mid(strSeal, i, 1)
                    If (c >= "A" And c <= "Z") Or (c >= "0" And c <= "9") Then

                    Else
                        Exit For
                    End If
                Next
                If i < 1 Then
                    Return True
                    Exit Function
                Else
                    MessageBox.Show("存在非法字符", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("字符串非法", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf Len(strSeal) = 1 Then
            MessageBox.Show("字符串长度不足", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If      '为空不判断，直接返回 false
        Return False
        Exit Function
    End Function

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub cbContainer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TypeName(Me.ccbContainer.SelectedValue) = "String" Then
            Dim i As Integer
            For i = 0 To Count - 1
                If Me.C1DBG.Columns("CONTAINER_NO").CellValue(i) = Me.ccbContainer.Text Then Exit For
            Next
            If i < Count Then
                Me.C1DBG.Row = i
                Me.txtOriginalSealNO.Text = Me.C1DBG.Columns("SEALNO").Text
            End If
        End If
    End Sub

    Private Sub cbContainer_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.ccbContainer.SelectedIndex = -1 Then
            If Me.ccbContainer.Text <> Me.ccbContainer.Text.Trim.ToUpper Then
                Me.ccbContainer.Text = Me.ccbContainer.Text.Trim.ToUpper
            End If
        End If
        If Me.C1DBG.Columns("CONTAINER_NO").Text <> Me.ccbContainer.Text Then
            Dim i As Integer
            For i = 0 To Count - 1
                If Me.C1DBG.Columns("CONTAINER_NO").CellValue(i) = Me.ccbContainer.Text Then Exit For
            Next
            If i < Count Then
                Me.C1DBG.Row = i
                Me.txtOriginalSealNO.Text = Me.C1DBG.Columns("SEALNO").Text
                Call Me.C1DBG_DoubleClick(sender, e)
            End If
        End If
    End Sub

    Private Sub cbNewSealNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'If TypeName(cbNewSealNo.SelectedValue) <> "String" And Trim(cbNewSealNo.Text) <> "" Then
            '    Dim i As Integer
            '    For i = 0 To dvSealNo.Count - 1
            '        If dvSealNo.Item(i)("SEALNO") = Trim(Me.cbNewSealNo.Text) Then Exit For
            '    Next
            '    If i >= dvSealNo.Count Then
            '        MessageBox.Show("请选择或清空新铅封号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmConSealExam_Add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If Me.txtNo.Focused Then
                Me.ccbContainer.Focus()
            ElseIf Me.ccbContainer.Focused Then
                Me.ccbNewSealNo.Focus()
            ElseIf Me.ccbNewSealNo.Focused Then
                Me.cbSealKind.Focus()
            ElseIf Me.cbSealKind.Focused Then
                Me.cbSealPerson.Focus()
            ElseIf Me.cbSealPerson.Focused Then
                Me.cbSealType.Focus()
            ElseIf Me.cbSealType.Focused Then
                Me.txtWorkPlace.Focus()
            ElseIf Me.txtWorkPlace.Focused Then
                Me.dtpTimeBegin.Focus()
            ElseIf Me.dtpTimeBegin.Focused Then
                Me.dtpTimeEnd.Focus()
            ElseIf Me.dtpTimeEnd.Focused Then
                Me.txtOriginalSealNO.Focus()
            ElseIf Me.txtOriginalSealNO.Focused Then
                Me.cbOgSealCondition.Focus()
            ElseIf Me.cbOgSealCondition.Focused Then
                Me.txtRemark.Focus()
            ElseIf Me.txtRemark.Focused Then
                Me.btSave.Focus()
            End If
        End If
    End Sub

End Class
