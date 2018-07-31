Imports TALLY.DBControl
Imports Microsoft.VisualBasic

Public Class FRMCON_TALLY_LIST_ADD
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim dwimage As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim ds_sub As New DataSet()
    Dim sqlda_sub As New SqlClient.SqlDataAdapter()
    Dim dsberth As New DataSet()
    Dim dsclerk As New DataSet()
    Dim dsclerk2 As New DataSet()
    Dim dsclerk3 As New DataSet()
    Dim INOUT_MARK As String
    Dim NIGHT_MARK As String
    Dim HOLIDAY As String
    Dim ANCHORAGE_REMARK As String
    Dim SEA_AFFAIRE_CARGO As String
    Dim RELOAD As String

    Dim E20 As Integer
    Dim F20 As Integer
    Dim E40 As Integer
    Dim F40 As Integer
    Dim E45 As Integer
    Dim F45 As Integer
    Dim TOTAL As Integer
    Dim TEU As Integer

    Dim oldcon As String
    Dim dsimage As New DataSet()
    Dim agent As String



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
    Friend WithEvents TxtTime_from As System.Windows.Forms.TextBox
    Friend WithEvents Txttime_to As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DTPdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CombBERTHNO As System.Windows.Forms.ComboBox
    Friend WithEvents TxtYARD_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CombTALLY_CLERK3 As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK2 As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCROSS_PERSON As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbHOLIDAY As System.Windows.Forms.CheckBox
    Friend WithEvents CBSEA_AFFAIRE_CARGO As System.Windows.Forms.CheckBox
    Friend WithEvents CBNIGHT_MARK As System.Windows.Forms.CheckBox
    Friend WithEvents CBANCHORAGE_REMARK As System.Windows.Forms.CheckBox
    Friend WithEvents CBMARK As System.Windows.Forms.CheckBox
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtBAY As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents BTNOK As System.Windows.Forms.Button
    Friend WithEvents BtDELETEALL As System.Windows.Forms.Button
    Friend WithEvents BtADDALL As System.Windows.Forms.Button
    Friend WithEvents BtDELETE As System.Windows.Forms.Button
    Friend WithEvents BtADD As System.Windows.Forms.Button
    Friend WithEvents C1IMAGE As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1TALLY As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TXTCON_TALLY_LIST_ID As System.Windows.Forms.TextBox
    Friend WithEvents cbRELOAD As System.Windows.Forms.CheckBox
    Friend WithEvents TxtCONTAINERNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtseachbay As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RBROW As System.Windows.Forms.RadioButton
    Friend WithEvents RBCOL As System.Windows.Forms.RadioButton
    Friend WithEvents TxtTEAM_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Txt20E As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Txt20F As System.Windows.Forms.TextBox
    Friend WithEvents Txt40F As System.Windows.Forms.TextBox
    Friend WithEvents Txt40E As System.Windows.Forms.TextBox
    Friend WithEvents Txt45F As System.Windows.Forms.TextBox
    Friend WithEvents Txt45E As System.Windows.Forms.TextBox
    Friend WithEvents TxtTEU As System.Windows.Forms.TextBox
    Friend WithEvents TxtTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Txt58F As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Txt58E As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents BtADD_CONTAINER As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRMCON_TALLY_LIST_ADD))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines2 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.TxtTime_from = New System.Windows.Forms.TextBox
        Me.Txttime_to = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.DTPdate = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CombBERTHNO = New System.Windows.Forms.ComboBox
        Me.TxtYARD_NO = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CombTALLY_CLERK3 = New System.Windows.Forms.ComboBox
        Me.CombTALLY_CLERK2 = New System.Windows.Forms.ComboBox
        Me.CombTALLY_CLERK1 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtCROSS_PERSON = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbHOLIDAY = New System.Windows.Forms.CheckBox
        Me.CBSEA_AFFAIRE_CARGO = New System.Windows.Forms.CheckBox
        Me.CBNIGHT_MARK = New System.Windows.Forms.CheckBox
        Me.CBANCHORAGE_REMARK = New System.Windows.Forms.CheckBox
        Me.CBMARK = New System.Windows.Forms.CheckBox
        Me.TxtNO = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtBAY = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.C1IMAGE = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1TALLY = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.BTOK = New System.Windows.Forms.Button
        Me.BTNOK = New System.Windows.Forms.Button
        Me.BtDELETEALL = New System.Windows.Forms.Button
        Me.BtADDALL = New System.Windows.Forms.Button
        Me.BtDELETE = New System.Windows.Forms.Button
        Me.BtADD = New System.Windows.Forms.Button
        Me.TXTCON_TALLY_LIST_ID = New System.Windows.Forms.TextBox
        Me.cbRELOAD = New System.Windows.Forms.CheckBox
        Me.TxtCONTAINERNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txtseachbay = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.RBROW = New System.Windows.Forms.RadioButton
        Me.RBCOL = New System.Windows.Forms.RadioButton
        Me.TxtTEAM_NO = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Txt20E = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Txt20F = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Txt40F = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Txt40E = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Txt45F = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Txt45E = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TxtTEU = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.TxtTOTAL = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Txt58F = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Txt58E = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.BtADD_CONTAINER = New System.Windows.Forms.Button
        CType(Me.C1IMAGE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TALLY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTime_from
        '
        Me.TxtTime_from.Location = New System.Drawing.Point(461, 34)
        Me.TxtTime_from.MaxLength = 4
        Me.TxtTime_from.Name = "TxtTime_from"
        Me.TxtTime_from.Size = New System.Drawing.Size(108, 21)
        Me.TxtTime_from.TabIndex = 50
        Me.TxtTime_from.Text = ""
        '
        'Txttime_to
        '
        Me.Txttime_to.Location = New System.Drawing.Point(461, 60)
        Me.Txttime_to.MaxLength = 4
        Me.Txttime_to.Name = "Txttime_to"
        Me.Txttime_to.Size = New System.Drawing.Size(108, 21)
        Me.Txttime_to.TabIndex = 49
        Me.Txttime_to.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(389, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 22)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "作业日期"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPdate
        '
        Me.DTPdate.CustomFormat = "yyyy-MM-dd"
        Me.DTPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPdate.Location = New System.Drawing.Point(461, 8)
        Me.DTPdate.Name = "DTPdate"
        Me.DTPdate.Size = New System.Drawing.Size(108, 21)
        Me.DTPdate.TabIndex = 47
        Me.DTPdate.Value = New Date(2004, 4, 28, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(389, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 22)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "作业止时间"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(389, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "作业起时间"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombBERTHNO
        '
        Me.CombBERTHNO.Location = New System.Drawing.Point(92, 60)
        Me.CombBERTHNO.Name = "CombBERTHNO"
        Me.CombBERTHNO.Size = New System.Drawing.Size(108, 20)
        Me.CombBERTHNO.TabIndex = 54
        '
        'TxtYARD_NO
        '
        Me.TxtYARD_NO.Location = New System.Drawing.Point(276, 8)
        Me.TxtYARD_NO.MaxLength = 20
        Me.TxtYARD_NO.Name = "TxtYARD_NO"
        Me.TxtYARD_NO.Size = New System.Drawing.Size(108, 21)
        Me.TxtYARD_NO.TabIndex = 53
        Me.TxtYARD_NO.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(204, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 22)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "库场车驳号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 22)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "泊位号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombTALLY_CLERK3
        '
        Me.CombTALLY_CLERK3.Location = New System.Drawing.Point(644, 60)
        Me.CombTALLY_CLERK3.Name = "CombTALLY_CLERK3"
        Me.CombTALLY_CLERK3.Size = New System.Drawing.Size(102, 20)
        Me.CombTALLY_CLERK3.TabIndex = 60
        '
        'CombTALLY_CLERK2
        '
        Me.CombTALLY_CLERK2.Location = New System.Drawing.Point(645, 34)
        Me.CombTALLY_CLERK2.Name = "CombTALLY_CLERK2"
        Me.CombTALLY_CLERK2.Size = New System.Drawing.Size(100, 20)
        Me.CombTALLY_CLERK2.TabIndex = 59
        '
        'CombTALLY_CLERK1
        '
        Me.CombTALLY_CLERK1.Location = New System.Drawing.Point(645, 8)
        Me.CombTALLY_CLERK1.Name = "CombTALLY_CLERK1"
        Me.CombTALLY_CLERK1.Size = New System.Drawing.Size(100, 20)
        Me.CombTALLY_CLERK1.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(573, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 22)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "理货员3"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(573, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 22)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "理货员2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(573, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 22)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "理货员1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCROSS_PERSON
        '
        Me.TxtCROSS_PERSON.Location = New System.Drawing.Point(276, 60)
        Me.TxtCROSS_PERSON.MaxLength = 10
        Me.TxtCROSS_PERSON.Name = "TxtCROSS_PERSON"
        Me.TxtCROSS_PERSON.Size = New System.Drawing.Size(108, 21)
        Me.TxtCROSS_PERSON.TabIndex = 62
        Me.TxtCROSS_PERSON.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(204, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 22)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "交接人员"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbHOLIDAY
        '
        Me.cbHOLIDAY.Location = New System.Drawing.Point(246, 90)
        Me.cbHOLIDAY.Name = "cbHOLIDAY"
        Me.cbHOLIDAY.Size = New System.Drawing.Size(65, 18)
        Me.cbHOLIDAY.TabIndex = 67
        Me.cbHOLIDAY.Text = "节假日"
        '
        'CBSEA_AFFAIRE_CARGO
        '
        Me.CBSEA_AFFAIRE_CARGO.Location = New System.Drawing.Point(520, 90)
        Me.CBSEA_AFFAIRE_CARGO.Name = "CBSEA_AFFAIRE_CARGO"
        Me.CBSEA_AFFAIRE_CARGO.Size = New System.Drawing.Size(65, 18)
        Me.CBSEA_AFFAIRE_CARGO.TabIndex = 66
        Me.CBSEA_AFFAIRE_CARGO.Text = "海事"
        '
        'CBNIGHT_MARK
        '
        Me.CBNIGHT_MARK.Location = New System.Drawing.Point(178, 90)
        Me.CBNIGHT_MARK.Name = "CBNIGHT_MARK"
        Me.CBNIGHT_MARK.Size = New System.Drawing.Size(64, 18)
        Me.CBNIGHT_MARK.TabIndex = 65
        Me.CBNIGHT_MARK.Text = "夜班"
        '
        'CBANCHORAGE_REMARK
        '
        Me.CBANCHORAGE_REMARK.Location = New System.Drawing.Point(452, 90)
        Me.CBANCHORAGE_REMARK.Name = "CBANCHORAGE_REMARK"
        Me.CBANCHORAGE_REMARK.Size = New System.Drawing.Size(64, 18)
        Me.CBANCHORAGE_REMARK.TabIndex = 64
        Me.CBANCHORAGE_REMARK.Text = "锚地"
        '
        'CBMARK
        '
        Me.CBMARK.Location = New System.Drawing.Point(316, 90)
        Me.CBMARK.Name = "CBMARK"
        Me.CBMARK.Size = New System.Drawing.Size(64, 18)
        Me.CBMARK.TabIndex = 63
        Me.CBMARK.Text = "出舱"
        '
        'TxtNO
        '
        Me.TxtNO.Location = New System.Drawing.Point(92, 34)
        Me.TxtNO.MaxLength = 10
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(108, 21)
        Me.TxtNO.TabIndex = 69
        Me.TxtNO.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "编号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBAY
        '
        Me.TxtBAY.Location = New System.Drawing.Point(276, 34)
        Me.TxtBAY.MaxLength = 20
        Me.TxtBAY.Name = "TxtBAY"
        Me.TxtBAY.Size = New System.Drawing.Size(108, 21)
        Me.TxtBAY.TabIndex = 71
        Me.TxtBAY.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(204, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "舱/排位"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1IMAGE
        '
        Me.C1IMAGE.AllowFilter = True
        Me.C1IMAGE.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1IMAGE.AllowSort = True
        Me.C1IMAGE.CaptionHeight = 18
        Me.C1IMAGE.CollapseColor = System.Drawing.Color.Black
        Me.C1IMAGE.DataChanged = False
        Me.C1IMAGE.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1IMAGE.ExpandColor = System.Drawing.Color.Black
        Me.C1IMAGE.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1IMAGE.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1IMAGE.Location = New System.Drawing.Point(4, 186)
        Me.C1IMAGE.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1IMAGE.Name = "C1IMAGE"
        Me.C1IMAGE.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1IMAGE.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1IMAGE.PreviewInfo.ZoomFactor = 75
        Me.C1IMAGE.PrintInfo.ShowOptionsDialog = False
        Me.C1IMAGE.RecordSelectorWidth = 17
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1IMAGE.RowDivider = GridLines1
        Me.C1IMAGE.RowHeight = 16
        Me.C1IMAGE.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1IMAGE.ScrollTips = False
        Me.C1IMAGE.Size = New System.Drawing.Size(269, 342)
        Me.C1IMAGE.TabIndex = 72
        Me.C1IMAGE.Text = "C1TrueDBGrid1"
        Me.C1IMAGE.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" Colu" & _
        "mnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" Def" & _
        "RecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0" & _
        ", 0, 265, 338</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "yout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 2" & _
        "65, 338</ClientArea></Blob>"
        '
        'C1TALLY
        '
        Me.C1TALLY.AllowAddNew = True
        Me.C1TALLY.AllowFilter = True
        Me.C1TALLY.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1TALLY.AllowSort = True
        Me.C1TALLY.CaptionHeight = 18
        Me.C1TALLY.CollapseColor = System.Drawing.Color.Black
        Me.C1TALLY.DataChanged = False
        Me.C1TALLY.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1TALLY.Enabled = False
        Me.C1TALLY.ExpandColor = System.Drawing.Color.Black
        Me.C1TALLY.FetchRowStyles = True
        Me.C1TALLY.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TALLY.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1TALLY.Location = New System.Drawing.Point(310, 186)
        Me.C1TALLY.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1TALLY.Name = "C1TALLY"
        Me.C1TALLY.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TALLY.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TALLY.PreviewInfo.ZoomFactor = 75
        Me.C1TALLY.PrintInfo.ShowOptionsDialog = False
        Me.C1TALLY.RecordSelectorWidth = 17
        GridLines2.Color = System.Drawing.Color.DarkGray
        GridLines2.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1TALLY.RowDivider = GridLines2
        Me.C1TALLY.RowHeight = 16
        Me.C1TALLY.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1TALLY.ScrollTips = False
        Me.C1TALLY.Size = New System.Drawing.Size(442, 342)
        Me.C1TALLY.TabIndex = 73
        Me.C1TALLY.Text = "C1TrueDBGrid2"
        Me.C1TALLY.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" Colu" & _
        "mnFooterHeight=""18"" FetchRowStyles=""True"" MarqueeStyle=""DottedCellBorder"" Record" & _
        "SelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollG" & _
        "roup=""1""><ClientRect>0, 0, 438, 338</ClientRect><BorderSide>0</BorderSide><Capti" & _
        "onStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" " & _
        "/><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar" & _
        """ me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""" & _
        "Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRow" & _
        "Style parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""S" & _
        "tyle4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=" & _
        """RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><" & _
        "Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><Na" & _
        "medStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><" & _
        "Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Sty" & _
        "le parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Styl" & _
        "e parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Styl" & _
        "e parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style par" & _
        "ent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Sty" & _
        "le parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSp" & _
        "lits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWid" & _
        "th><ClientArea>0, 0, 438, 338</ClientArea></Blob>"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(542, 152)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 75
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(448, 152)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 74
        Me.BTOK.Text = "确认"
        '
        'BTNOK
        '
        Me.BTNOK.Enabled = False
        Me.BTNOK.Location = New System.Drawing.Point(344, 540)
        Me.BTNOK.Name = "BTNOK"
        Me.BTNOK.Size = New System.Drawing.Size(65, 24)
        Me.BTNOK.TabIndex = 76
        Me.BTNOK.Text = "确认"
        '
        'BtDELETEALL
        '
        Me.BtDELETEALL.Enabled = False
        Me.BtDELETEALL.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtDELETEALL.Location = New System.Drawing.Point(278, 386)
        Me.BtDELETEALL.Name = "BtDELETEALL"
        Me.BtDELETEALL.Size = New System.Drawing.Size(26, 22)
        Me.BtDELETEALL.TabIndex = 77
        Me.BtDELETEALL.Text = "<<"
        '
        'BtADDALL
        '
        Me.BtADDALL.Enabled = False
        Me.BtADDALL.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtADDALL.Location = New System.Drawing.Point(278, 344)
        Me.BtADDALL.Name = "BtADDALL"
        Me.BtADDALL.Size = New System.Drawing.Size(26, 22)
        Me.BtADDALL.TabIndex = 78
        Me.BtADDALL.Text = ">>"
        '
        'BtDELETE
        '
        Me.BtDELETE.Enabled = False
        Me.BtDELETE.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtDELETE.Location = New System.Drawing.Point(278, 304)
        Me.BtDELETE.Name = "BtDELETE"
        Me.BtDELETE.Size = New System.Drawing.Size(26, 22)
        Me.BtDELETE.TabIndex = 79
        Me.BtDELETE.Text = "<"
        '
        'BtADD
        '
        Me.BtADD.Enabled = False
        Me.BtADD.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtADD.Location = New System.Drawing.Point(278, 264)
        Me.BtADD.Name = "BtADD"
        Me.BtADD.Size = New System.Drawing.Size(26, 22)
        Me.BtADD.TabIndex = 80
        Me.BtADD.Text = ">"
        '
        'TXTCON_TALLY_LIST_ID
        '
        Me.TXTCON_TALLY_LIST_ID.Location = New System.Drawing.Point(17, 88)
        Me.TXTCON_TALLY_LIST_ID.Name = "TXTCON_TALLY_LIST_ID"
        Me.TXTCON_TALLY_LIST_ID.Size = New System.Drawing.Size(52, 21)
        Me.TXTCON_TALLY_LIST_ID.TabIndex = 81
        Me.TXTCON_TALLY_LIST_ID.Text = ""
        Me.TXTCON_TALLY_LIST_ID.Visible = False
        '
        'cbRELOAD
        '
        Me.cbRELOAD.Location = New System.Drawing.Point(384, 90)
        Me.cbRELOAD.Name = "cbRELOAD"
        Me.cbRELOAD.Size = New System.Drawing.Size(65, 18)
        Me.cbRELOAD.TabIndex = 82
        Me.cbRELOAD.Text = "重装"
        '
        'TxtCONTAINERNO
        '
        Me.TxtCONTAINERNO.Location = New System.Drawing.Point(122, 154)
        Me.TxtCONTAINERNO.MaxLength = 20
        Me.TxtCONTAINERNO.Name = "TxtCONTAINERNO"
        Me.TxtCONTAINERNO.Size = New System.Drawing.Size(76, 21)
        Me.TxtCONTAINERNO.TabIndex = 84
        Me.TxtCONTAINERNO.Text = ""
        Me.TxtCONTAINERNO.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(66, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 22)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "查找箱号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtseachbay
        '
        Me.Txtseachbay.Location = New System.Drawing.Point(36, 154)
        Me.Txtseachbay.MaxLength = 2
        Me.Txtseachbay.Name = "Txtseachbay"
        Me.Txtseachbay.Size = New System.Drawing.Size(30, 21)
        Me.Txtseachbay.TabIndex = 86
        Me.Txtseachbay.Text = ""
        Me.Txtseachbay.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 22)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "贝号"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RBROW
        '
        Me.RBROW.Location = New System.Drawing.Point(250, 154)
        Me.RBROW.Name = "RBROW"
        Me.RBROW.Size = New System.Drawing.Size(48, 20)
        Me.RBROW.TabIndex = 165
        Me.RBROW.Text = "按层"
        '
        'RBCOL
        '
        Me.RBCOL.Location = New System.Drawing.Point(202, 154)
        Me.RBCOL.Name = "RBCOL"
        Me.RBCOL.Size = New System.Drawing.Size(48, 20)
        Me.RBCOL.TabIndex = 164
        Me.RBCOL.Text = "按列"
        '
        'TxtTEAM_NO
        '
        Me.TxtTEAM_NO.Location = New System.Drawing.Point(92, 8)
        Me.TxtTEAM_NO.MaxLength = 3
        Me.TxtTEAM_NO.Name = "TxtTEAM_NO"
        Me.TxtTEAM_NO.Size = New System.Drawing.Size(108, 21)
        Me.TxtTEAM_NO.TabIndex = 167
        Me.TxtTEAM_NO.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(20, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 22)
        Me.Label14.TabIndex = 166
        Me.Label14.Text = "工班号"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(76, 534)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 20)
        Me.Label15.TabIndex = 168
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(526, 534)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 20)
        Me.Label16.TabIndex = 169
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt20E
        '
        Me.Txt20E.Location = New System.Drawing.Point(42, 118)
        Me.Txt20E.MaxLength = 10
        Me.Txt20E.Name = "Txt20E"
        Me.Txt20E.Size = New System.Drawing.Size(28, 21)
        Me.Txt20E.TabIndex = 171
        Me.Txt20E.Text = ""
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(6, 118)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 22)
        Me.Label17.TabIndex = 170
        Me.Label17.Text = "20E："
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt20F
        '
        Me.Txt20F.Location = New System.Drawing.Point(106, 118)
        Me.Txt20F.MaxLength = 10
        Me.Txt20F.Name = "Txt20F"
        Me.Txt20F.Size = New System.Drawing.Size(28, 21)
        Me.Txt20F.TabIndex = 173
        Me.Txt20F.Text = ""
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(70, 118)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 22)
        Me.Label18.TabIndex = 172
        Me.Label18.Text = "20F："
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt40F
        '
        Me.Txt40F.Location = New System.Drawing.Point(234, 118)
        Me.Txt40F.MaxLength = 10
        Me.Txt40F.Name = "Txt40F"
        Me.Txt40F.Size = New System.Drawing.Size(28, 21)
        Me.Txt40F.TabIndex = 177
        Me.Txt40F.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(198, 118)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 22)
        Me.Label19.TabIndex = 176
        Me.Label19.Text = "40F："
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt40E
        '
        Me.Txt40E.Location = New System.Drawing.Point(170, 118)
        Me.Txt40E.MaxLength = 10
        Me.Txt40E.Name = "Txt40E"
        Me.Txt40E.Size = New System.Drawing.Size(28, 21)
        Me.Txt40E.TabIndex = 175
        Me.Txt40E.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(134, 118)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 22)
        Me.Label20.TabIndex = 174
        Me.Label20.Text = "40E："
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt45F
        '
        Me.Txt45F.Location = New System.Drawing.Point(362, 118)
        Me.Txt45F.MaxLength = 10
        Me.Txt45F.Name = "Txt45F"
        Me.Txt45F.Size = New System.Drawing.Size(28, 21)
        Me.Txt45F.TabIndex = 181
        Me.Txt45F.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(326, 118)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 22)
        Me.Label21.TabIndex = 180
        Me.Label21.Text = "45F："
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt45E
        '
        Me.Txt45E.Location = New System.Drawing.Point(298, 118)
        Me.Txt45E.MaxLength = 10
        Me.Txt45E.Name = "Txt45E"
        Me.Txt45E.Size = New System.Drawing.Size(28, 21)
        Me.Txt45E.TabIndex = 179
        Me.Txt45E.Text = ""
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(262, 118)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 22)
        Me.Label22.TabIndex = 178
        Me.Label22.Text = "45E："
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTEU
        '
        Me.TxtTEU.Location = New System.Drawing.Point(624, 118)
        Me.TxtTEU.MaxLength = 10
        Me.TxtTEU.Name = "TxtTEU"
        Me.TxtTEU.Size = New System.Drawing.Size(28, 21)
        Me.TxtTEU.TabIndex = 185
        Me.TxtTEU.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(588, 118)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 22)
        Me.Label23.TabIndex = 184
        Me.Label23.Text = "TEU："
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTOTAL
        '
        Me.TxtTOTAL.Location = New System.Drawing.Point(560, 118)
        Me.TxtTOTAL.MaxLength = 10
        Me.TxtTOTAL.Name = "TxtTOTAL"
        Me.TxtTOTAL.Size = New System.Drawing.Size(28, 21)
        Me.TxtTOTAL.TabIndex = 183
        Me.TxtTOTAL.Text = ""
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(518, 118)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 22)
        Me.Label24.TabIndex = 182
        Me.Label24.Text = "合计："
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt58F
        '
        Me.Txt58F.Location = New System.Drawing.Point(490, 118)
        Me.Txt58F.MaxLength = 10
        Me.Txt58F.Name = "Txt58F"
        Me.Txt58F.Size = New System.Drawing.Size(28, 21)
        Me.Txt58F.TabIndex = 189
        Me.Txt58F.Text = ""
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(454, 118)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 22)
        Me.Label25.TabIndex = 188
        Me.Label25.Text = "58F："
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt58E
        '
        Me.Txt58E.Location = New System.Drawing.Point(426, 118)
        Me.Txt58E.MaxLength = 10
        Me.Txt58E.Name = "Txt58E"
        Me.Txt58E.Size = New System.Drawing.Size(28, 21)
        Me.Txt58E.TabIndex = 187
        Me.Txt58E.Text = ""
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(390, 118)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(36, 22)
        Me.Label26.TabIndex = 186
        Me.Label26.Text = "58E："
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtADD_CONTAINER
        '
        Me.BtADD_CONTAINER.Location = New System.Drawing.Point(676, 116)
        Me.BtADD_CONTAINER.Name = "BtADD_CONTAINER"
        Me.BtADD_CONTAINER.Size = New System.Drawing.Size(65, 24)
        Me.BtADD_CONTAINER.TabIndex = 190
        Me.BtADD_CONTAINER.Text = "添加"
        '
        'FRMCON_TALLY_LIST_ADD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(762, 576)
        Me.Controls.Add(Me.BtADD_CONTAINER)
        Me.Controls.Add(Me.Txt58F)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Txt58E)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TxtTEU)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TxtTOTAL)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Txt45F)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Txt45E)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Txt40F)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Txt40E)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Txt20F)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Txt20E)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtTEAM_NO)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.RBROW)
        Me.Controls.Add(Me.RBCOL)
        Me.Controls.Add(Me.Txtseachbay)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtCONTAINERNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbRELOAD)
        Me.Controls.Add(Me.TXTCON_TALLY_LIST_ID)
        Me.Controls.Add(Me.BtADD)
        Me.Controls.Add(Me.BtDELETE)
        Me.Controls.Add(Me.BtADDALL)
        Me.Controls.Add(Me.BtDELETEALL)
        Me.Controls.Add(Me.BTNOK)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTOK)
        Me.Controls.Add(Me.C1TALLY)
        Me.Controls.Add(Me.C1IMAGE)
        Me.Controls.Add(Me.TxtBAY)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbHOLIDAY)
        Me.Controls.Add(Me.CBSEA_AFFAIRE_CARGO)
        Me.Controls.Add(Me.CBNIGHT_MARK)
        Me.Controls.Add(Me.CBANCHORAGE_REMARK)
        Me.Controls.Add(Me.CBMARK)
        Me.Controls.Add(Me.TxtCROSS_PERSON)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CombTALLY_CLERK3)
        Me.Controls.Add(Me.CombTALLY_CLERK2)
        Me.Controls.Add(Me.CombTALLY_CLERK1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CombBERTHNO)
        Me.Controls.Add(Me.TxtYARD_NO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTime_from)
        Me.Controls.Add(Me.Txttime_to)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DTPdate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMCON_TALLY_LIST_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "理箱单_增加"
        CType(Me.C1IMAGE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TALLY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCON_TALLY_LIST_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds_agent As New DataSet
        On Error GoTo Err
        dw = Getdata("select CODE_BERTH,NAME_BERTH from CODE_BERTH ", dsberth)
        CombBERTHNO.DataSource = dsberth.Tables(0).DefaultView
        CombBERTHNO.DisplayMember = "NAME_BERTH"
        CombBERTHNO.ValueMember = "CODE_BERTH"

        dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk)
        CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
        CombTALLY_CLERK1.DisplayMember = "name"
        CombTALLY_CLERK1.ValueMember = "work_no"

        dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk2)
        CombTALLY_CLERK2.DataSource = dsclerk2.Tables(0).DefaultView
        CombTALLY_CLERK2.DisplayMember = "name"
        CombTALLY_CLERK2.ValueMember = "work_no"

        'dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk3)
        'CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
        'CombTALLY_CLERK3.DisplayMember = "name"
        'CombTALLY_CLERK3.ValueMember = "work_no"

        dw = Getdata("select * from sship where ship_id='" & Ship_ID & "'", ds_agent)
        If ds_agent.Tables(0).Rows.Count > 0 Then
            agent = IIf(IsDBNull(ds_agent.Tables(0).Rows(0).Item("agent")), "", ds_agent.Tables(0).Rows(0).Item("agent"))
        End If
        dw = Updatedata(sqlda, "select * from con_tally_list where con_tally_list_ID='" & ID & "'", ds)
        If ds.Tables(0).DefaultView.Count > 0 Then


            TxtYARD_NO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("YARD_NO"))), "", Trim(ds.Tables(0).Rows(0).Item("YARD_NO")))
            If ds.Tables(0).Rows(0).Item("INOUT_MARK") = 1 Then
                CBMARK.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("reload") = 1 Then
                cbRELOAD.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("NIGHT_MARK") = 1 Then
                CBNIGHT_MARK.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("HOLIDAY") = 1 Then
                cbHOLIDAY.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("ANCHORAGE_REMARK") = 1 Then
                CBANCHORAGE_REMARK.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("SEA_AFFAIRE_CARGO") = 1 Then
                CBSEA_AFFAIRE_CARGO.Checked = True
            End If
            TxtTime_from.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_from"))), "", Trim(ds.Tables(0).Rows(0).Item("time_from")))
            Txttime_to.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_to"))), "", Trim(ds.Tables(0).Rows(0).Item("time_to")))
            CombBERTHNO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("BERTHNO"))), "", Trim(ds.Tables(0).Rows(0).Item("BERTHNO")))
            TxtCROSS_PERSON.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("CROSS_PERSON"))), "", Trim(ds.Tables(0).Rows(0).Item("CROSS_PERSON")))
            DTPdate.Value = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("date"))), Now, Trim(ds.Tables(0).Rows(0).Item("date")))
            TxtTEAM_NO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("team_no"))), "", Trim(ds.Tables(0).Rows(0).Item("team_no")))
            TxtBAY.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("BAY"))), "", Trim(ds.Tables(0).Rows(0).Item("BAY")))
            Call clerk()
            CombTALLY_CLERK1.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk1"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk1")))
            CombTALLY_CLERK2.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk2"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk2")))
            CombTALLY_CLERK3.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk3"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk3")))
            Call CBNIGHT_SELECT()
        End If
        CombTALLY_CLERK1.Text = ""
        CombTALLY_CLERK2.Text = ""
        'CombTALLY_CLERK3.Text = ""

        Call GETIMAGE()

        dw = Updatedata(sqlda_sub, "select * from CON_TALLY_DETAIL where CON_TALLY_LIST_ID='" & TXTCON_TALLY_LIST_ID.Text & "'", ds_sub)
        C1TALLY.DataSource = ds_sub.Tables(0).DefaultView
        Me.C1TALLY.Splits(0).DisplayColumns.Item("CON_TALLY_DETAIL_ID").Visible = False
        Me.C1TALLY.Splits(0).DisplayColumns.Item("CON_TALLY_LIST_ID").Visible = False
        Me.C1TALLY.Splits(0).DisplayColumns.Item("OPENBOX").Visible = False
        Me.C1TALLY.Splits(0).DisplayColumns.Item("UnLoad_Mark").Visible = False
        Me.C1TALLY.Splits(0).DisplayColumns.Item("CODE_SHIP_AGENT").Visible = False

        Me.C1TALLY.Columns.Item("BAYNO").Caption = "贝位号"
        Me.C1TALLY.Columns.Item("CONTAINER_NO").Caption = "箱号"
        Me.C1TALLY.Columns.Item("weight").Caption = "重量"

        Me.C1TALLY.Columns.Item("SIZE_CON").Caption = "箱尺寸"
        Me.C1TALLY.Columns.Item("SEALNO").Caption = "铅封号"
        Me.C1TALLY.Columns.Item("SEAL_STATE").Caption = "铅封状态"
        Me.C1TALLY.Columns.Item("FULLOREMPTY").Caption = "重箱"
        Me.C1TALLY.Columns.Item("CHECKSEAL").Caption = "铅封查验"

        Me.C1TALLY.Splits(0).DisplayColumns.Item("CONTAINER_NO").Width = 90
        Me.C1TALLY.Splits(0).DisplayColumns.Item("SEALNO").Width = 100
        Me.C1TALLY.Splits(0).DisplayColumns.Item("BAYNO").Width = 50
        Me.C1TALLY.Splits(0).DisplayColumns.Item("FULLOREMPTY").Width = 30
        Me.C1TALLY.Splits(0).DisplayColumns.Item("SIZE_CON").Width = 50
        Me.C1TALLY.Splits(0).DisplayColumns.Item("SEAL_STATE").Width = 60
        Me.C1TALLY.Splits(0).DisplayColumns.Item("CHECKSEAL").Width = 100
        Me.C1TALLY.Splits(0).DisplayColumns.Item("weight").Width = 50
        Label16.Text = "共" & ds_sub.Tables(0).Rows.Count & "个"
        BtADD_CONTAINER.Enabled = False
        Txt20E.Text = 0
        Txt20F.Text = 0
        Txt40E.Text = 0
        Txt40F.Text = 0
        Txt45E.Text = 0
        Txt45F.Text = 0
        Txt58E.Text = 0
        Txt58F.Text = 0
        TxtTOTAL.Text = 0
        TxtTEU.Text = 0
        TxtTEAM_NO.Focus()
        oldcon = ""
        Me.C1TALLY.Refresh()

        Exit Sub
Err:
        Resume Next
    End Sub
    Private Sub CBNIGHT_SELECT()
        CBNIGHT_MARK.Enabled = True
        If Len(Trim(TxtTime_from.Text)) = 4 Then
            If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(TxtTime_from.Text), 3, 2), Integer) < 60 Then
                If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) >= 6 And CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 22 Then
                    CBNIGHT_MARK.Checked = False
                    CBNIGHT_MARK.Enabled = False
                End If
                If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 6 Or CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) = 22 Or CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) = 23 Then
                    CBNIGHT_MARK.Checked = True
                    CBNIGHT_MARK.Enabled = True
                End If
            Else
                MsgBox("开始时间输入有误！")
                TxtTime_from.Focus()
            End If
        Else
            MsgBox("开始时间输入有误！")
            TxtTime_from.Focus()
        End If
    End Sub

    Private Sub clerk()
        Try

            dw = Getdata("exec sp_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPdate.Value & "'", dsclerk)
            CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
            CombTALLY_CLERK1.DisplayMember = "name"
            CombTALLY_CLERK1.ValueMember = "work_no"

            dw = Getdata("exec sp_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPdate.Value & "'", dsclerk2)
            CombTALLY_CLERK2.DataSource = dsclerk2.Tables(0).DefaultView
            CombTALLY_CLERK2.DisplayMember = "name"
            CombTALLY_CLERK2.ValueMember = "work_no"

            dw = Getdata("exec sp_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPdate.Value & "'", dsclerk3)
            CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
            CombTALLY_CLERK3.DisplayMember = "name"
            CombTALLY_CLERK3.ValueMember = "work_no"

        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub DTPdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPdate.Leave

        Call clerk()
        CombTALLY_CLERK1.SelectedValue = ""
        CombTALLY_CLERK2.SelectedValue = ""
        CombTALLY_CLERK3.SelectedValue = ""
    End Sub

    Private Sub TxtTime_from_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTime_from.Leave

        Call clerk()
        CombTALLY_CLERK1.SelectedValue = ""
        CombTALLY_CLERK2.SelectedValue = ""
        CombTALLY_CLERK3.SelectedValue = ""
        Call CBNIGHT_SELECT()
    End Sub
    Private Function CheckConNO(ByVal sm As String) As Integer 'return 0 箱号有错 1 校验有错 2 校验正确
        Dim S() As Integer = {10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 34, 35, 36, 37, 38}
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim l As Integer
        i = 0
        str = UCase(sm)
        If Len(Trim(sm)) = 12 And Mid(Trim(sm), 5, 1) = " " Then
            str = Mid(Trim(sm), 1, 4) & Mid(Trim(sm), 6, 7)
        ElseIf Len(Trim(sm)) <> 11 Then
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

    Private Sub CBMARK_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBMARK.Leave
        If CBMARK.Checked = True Then
            INOUT_MARK = "1"
        Else
            INOUT_MARK = "0"
        End If
    End Sub
    Private Sub cbRELOAD_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbRELOAD.Leave
        If cbRELOAD.Checked = True Then
            RELOAD = "1"
        Else
            RELOAD = "0"
        End If
    End Sub
    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Dim i As Integer
        Dim dwsub As New DataView
        Dim dskey As New DataSet
        Dim cmark As String

        Try
            If Len(Trim(TxtNO.Text)) > 0 Then
                If Len(Trim(DTPdate.Value)) > 0 Then
                    If Len(Trim(TxtTime_from.Text)) = 4 Then
                        If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(TxtTime_from.Text), 3, 2), Integer) < 60 Then
                            If Len(Trim(Txttime_to.Text)) = 4 Then
                                If CType(Mid(Trim(Txttime_to.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(Txttime_to.Text), 3, 2), Integer) < 60 Then
                                    If CBMARK.Checked = True Then
                                        cmark = "1"
                                    Else
                                        cmark = "0"
                                    End If
                                    dw = Getdata("select * from con_tally_LIST where ship_id='" & Ship_ID & "' and no='" & TxtNO.Text & "' and INOUT_MARK='" & cmark & "' ", dskey)
                                    If dskey.Tables(0).Rows.Count > 0 Then
                                        MsgBox("该理箱单已经存在！")
                                    Else
                                        Try
                                            Dim row As DataRow
                                            row = ds.Tables(0).NewRow

                                            row("ship_id") = Trim(Ship_ID)
                                            row("NO") = Trim(TxtNO.Text)
                                            row("team_NO") = Trim(TxtTEAM_NO.Text)
                                            row("berthno") = IIf(Len(Trim(CombBERTHNO.SelectedValue)) > 0, Trim(CombBERTHNO.SelectedValue), "")
                                            row("bay") = IIf(Len(Trim(TxtBAY.Text)) > 0, Trim(TxtBAY.Text), "")
                                            If CBMARK.Checked = True Then
                                                row("INOUT_MARK") = "1"
                                                INOUT_MARK = "1"
                                            Else
                                                row("INOUT_MARK") = "0"
                                                INOUT_MARK = "0"
                                            End If
                                            If CBNIGHT_MARK.Checked = True Then
                                                row("NIGHT_MARK") = "1"
                                                NIGHT_MARK = "1"
                                            Else
                                                row("NIGHT_MARK") = "0"
                                                NIGHT_MARK = "0"
                                            End If
                                            If cbHOLIDAY.Checked = True Then
                                                row("HOLIDAY") = "1"
                                                HOLIDAY = "1"
                                            Else
                                                row("HOLIDAY") = "0"
                                                HOLIDAY = "0"
                                            End If
                                            If CBANCHORAGE_REMARK.Checked = True Then
                                                row("ANCHORAGE_REMARK") = "1"
                                                ANCHORAGE_REMARK = "1"
                                            Else
                                                row("ANCHORAGE_REMARK") = "0"
                                                ANCHORAGE_REMARK = "0"
                                            End If
                                            If CBSEA_AFFAIRE_CARGO.Checked = True Then
                                                row("SEA_AFFAIRE_CARGO") = "1"
                                                SEA_AFFAIRE_CARGO = "1"
                                            Else
                                                row("SEA_AFFAIRE_CARGO") = "0"
                                                SEA_AFFAIRE_CARGO = "0"
                                            End If
                                            If cbRELOAD.Checked = True Then
                                                row("RELOAD") = "1"
                                                RELOAD = "1"
                                            Else
                                                row("RELOAD") = "0"
                                                RELOAD = "0"
                                            End If


                                            row("YARD_NO") = IIf(Len(Trim(TxtYARD_NO.Text)) > 0, Trim(TxtYARD_NO.Text), "")
                                            row("DATE") = DTPdate.Value
                                            row("time_from") = TxtTime_from.Text
                                            row("time_to") = Txttime_to.Text
                                            row("TALLY_CLERK1") = IIf(Len(Trim(CombTALLY_CLERK1.SelectedValue)) > 0, Trim(CombTALLY_CLERK1.SelectedValue), "00")
                                            row("TALLY_CLERK2") = IIf(Len(Trim(CombTALLY_CLERK2.SelectedValue)) > 0, Trim(CombTALLY_CLERK2.SelectedValue), "00")
                                            row("TALLY_CLERK3") = IIf(Len(Trim(CombTALLY_CLERK3.SelectedValue)) > 0, Trim(CombTALLY_CLERK3.SelectedValue), "00")
                                            row("CROSS_PERSON") = IIf(Len(Trim(TxtCROSS_PERSON.Text)) > 0, Trim(TxtCROSS_PERSON.Text), "")
                                            row("user_name") = Trim(G_User)

                                            ds.Tables(0).Rows.Add(row)
                                            sqlda.Update(ds)
                                            ds.Reset()
                                            dw = Getdata("select * from CON_TALLY_LIST where ship_id='" & Ship_ID & "' order by CON_TALLY_LIST_ID desc", ds)
                                            If ds.Tables(0).Rows.Count > 0 Then
                                                For i = 0 To ds.Tables(0).Rows.Count - 1
                                                    If CType(ds.Tables(0).Rows(i).Item("NO"), String) = Trim(TxtNO.Text) Then
                                                        'If CType(ds.Tables(0).Rows(i).Item("BERTHNO"), String) = IIf(Len(Trim(CombBERTHNO.SelectedValue)) > 0, Trim(CombBERTHNO.SelectedValue), "") Then
                                                        '    If CType(ds.Tables(0).Rows(i).Item("CROSS_PERSON"), String) = IIf(Len(Trim(TxtCROSS_PERSON.Text)) > 0, Trim(TxtCROSS_PERSON.Text), "") Then
                                                        '        If CType(ds.Tables(0).Rows(i).Item("INOUT_MARK"), String) = INOUT_MARK Then
                                                        '            If CType(ds.Tables(0).Rows(i).Item("NIGHT_MARK"), String) = NIGHT_MARK Then
                                                        '                If CType(ds.Tables(0).Rows(i).Item("HOLIDAY"), String) = HOLIDAY Then
                                                        '                    If CType(ds.Tables(0).Rows(i).Item("ANCHORAGE_REMARK"), String) = ANCHORAGE_REMARK Then
                                                        '                        If CType(ds.Tables(0).Rows(i).Item("SEA_AFFAIRE_CARGO"), String) = SEA_AFFAIRE_CARGO Then
                                                        '                            If CType(ds.Tables(0).Rows(i).Item("RELOAD"), String) = RELOAD Then
                                                        '                                If CType(ds.Tables(0).Rows(i).Item("YARD_NO"), String) = IIf(Len(Trim(TxtYARD_NO.Text)) > 0, Trim(TxtYARD_NO.Text), "") Then
                                                        '                                    If Year(ds.Tables(0).Rows(i).Item("date")) = Year(DTPdate.Value) And Month(ds.Tables(0).Rows(i).Item("date")) = Month(DTPdate.Value) And Day(ds.Tables(0).Rows(i).Item("date")) = Day(DTPdate.Value) Then
                                                        '                                        If CType(ds.Tables(0).Rows(i).Item("TIME_FROM"), String) = TxtTime_from.Text Then
                                                        '                                            If CType(ds.Tables(0).Rows(i).Item("time_to"), String) = Txttime_to.Text Then
                                                        '                                                If CType(ds.Tables(0).Rows(i).Item("TALLY_CLERK1"), String) = IIf(Len(Trim(CombTALLY_CLERK1.SelectedValue)) > 0, Trim(CombTALLY_CLERK1.SelectedValue), "") Then
                                                        '                                                    If CType(ds.Tables(0).Rows(i).Item("TALLY_CLERK2"), String) = IIf(Len(Trim(CombTALLY_CLERK2.SelectedValue)) > 0, Trim(CombTALLY_CLERK2.SelectedValue), "") Then
                                                        '                                                        If CType(ds.Tables(0).Rows(i).Item("TALLY_CLERK3"), String) = IIf(Len(Trim(CombTALLY_CLERK3.SelectedValue)) > 0, Trim(CombTALLY_CLERK3.SelectedValue), "") Then
                                                        '                                                            If CType(ds.Tables(0).Rows(i).Item("bay"), String) = Trim(TxtBAY.Text) Then
                                                        TXTCON_TALLY_LIST_ID.Text = ds.Tables(0).Rows(i).Item("CON_TALLY_LIST_ID")
                                                        Exit For
                                                        '                                                            End If
                                                        '                                                        End If
                                                        '                                                    End If
                                                        '                                                End If
                                                        '                                            End If
                                                        '                                        End If
                                                        '                                    End If
                                                        '                                End If
                                                        '                            End If
                                                        '                        End If
                                                        '                    End If
                                                        '                End If
                                                        '            End If
                                                        '        End If
                                                        '    End If
                                                        'End If
                                                    End If
                                                Next i
                                            End If

                                            'dwsub = Updatedata(sqlda_sub, "select * from CON_TALLY_DETAIL where CON_TALLY_LIST_ID='" & TXTCON_TALLY_LIST_ID.Text & "'", ds_sub)

                                            BTNOK.Enabled = True
                                            BtADD.Enabled = True
                                            BtDELETE.Enabled = True
                                            BtADDALL.Enabled = True
                                            BtDELETEALL.Enabled = True
                                            TxtCONTAINERNO.Visible = True
                                            Txtseachbay.Visible = True

                                            Me.C1TALLY.Enabled = True

                                            TxtNO.Enabled = False
                                            TxtTEAM_NO.Enabled = False
                                            CombBERTHNO.Enabled = False
                                            TxtBAY.Enabled = False
                                            TxtYARD_NO.Enabled = False
                                            TxtCROSS_PERSON.Enabled = False
                                            DTPdate.Enabled = False
                                            TxtTime_from.Enabled = False
                                            Txttime_to.Enabled = False
                                            CombTALLY_CLERK1.Enabled = False
                                            CombTALLY_CLERK2.Enabled = False
                                            CombTALLY_CLERK3.Enabled = False
                                            CBMARK.Enabled = False
                                            cbHOLIDAY.Enabled = False
                                            CBNIGHT_MARK.Enabled = False
                                            CBANCHORAGE_REMARK.Enabled = False
                                            CBSEA_AFFAIRE_CARGO.Enabled = False
                                            cbRELOAD.Enabled = False
                                            BTOK.Enabled = False
                                            BTQUIT.Enabled = False
                                            BtADD_CONTAINER.Enabled = True

                                            If ds_sub.Tables(0).Rows.Count = 0 Then
                                                Me.C1TALLY.Select()
                                                Me.C1TALLY.Row = Me.C1TALLY.Row + 1
                                                'Me.C1dbg.Columns.Item("cargo_list_id").Value = TxtCARGO_LIST_ID.Text
                                            End If


                                            Me.C1TALLY.Refresh()
                                            'Call ITEM_FILL()

                                        Catch ex As System.Exception
                                            MsgBox(ex.Message)

                                        End Try
                                    End If
                                Else
                                    MsgBox("作业止时间填写错误！请填写4位数字，不加冒号。")
                                End If
                            Else
                                MsgBox("作业止时间填写错误！请填写4位数字，不加冒号。")
                            End If
                        Else
                            MsgBox("作业起时间填写错误！请填写4位数字，不加冒号。")
                        End If
                    Else
                        MsgBox("作业起时间填写错误！请填写4位数字，不加冒号。")
                    End If
                Else
                    MsgBox("作业日期不能为空！")
                End If

            Else
                MsgBox("编号不能为空！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

    Private Sub C1TALLY_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1TALLY.RowColChange

        Try
            If e.LastRow <> -1 And Me.C1TALLY.Columns.Item("CON_TALLY_LIST_ID").Text = "" Then
                Me.C1TALLY.Columns.Item("CON_TALLY_LIST_ID").Text = TXTCON_TALLY_LIST_ID.Text
                'Me.C1TALLY.Columns.Item("RELOAD").Value = 0
                Me.C1TALLY.Columns.Item("OPENBOX").Value = 0
                Me.C1TALLY.Columns.Item("UnLoad_Mark").Value = 0
                'Me.C1TALLY.Columns.Item("OUT_HATCH").Value = 0
                Me.C1TALLY.Columns.Item("CODE_SHIP_AGENT").Value = agent
            End If
            Label16.Text = "共" & ds_sub.Tables(0).Rows.Count & "个"
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub C1tally_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1TALLY.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.C1TALLY.Col = 9 Then
                Me.C1TALLY.Row = Me.C1TALLY.Row + 1
                Me.C1TALLY.Col = 1
                SendKeys.Send("{LEFT}")
            End If
        End If
    End Sub
    Private Sub CONTAIN(ByVal CONTAINERNO As String, ByVal oldCONTAINERNO As String)
        Try
            Dim ds_con As New DataSet

            If INOUT_MARK <> "1" Then   '出舱时没有溢出
                If RELOAD <> "1" Then   '重装时没有溢出
                    dw = Getdata("select * from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and Unload_Mark='1' and CONTAINER_NO='" & oldCONTAINERNO & "' ", ds_con)
                    If ds_con.Tables(0).Rows.Count > 0 Then
                        ExecSql("update CON_HATCH_RECORD set Unload_Mark='0' where CON_HATCH_RECORD_ID='" & ds_con.Tables(0).Rows(0).Item("CON_HATCH_RECORD_ID") & "'")
                        ExecSql("update con_image set Unload_Mark='0' where ship_id='" & Ship_ID & "' and Unload_Mark='1' and container_no='" & oldCONTAINERNO & "'")
                        'Else
                        '    MsgBox("船图箱信息中没有该箱号！请查实后重新输入。")
                    End If
                    ds_con.Reset()
                    dw = Getdata("select * from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and Unload_Mark='0' and CONTAINER_NO='" & CONTAINERNO & "' ", ds_con)

                    If ds_con.Tables(0).Rows.Count > 0 Then
                        ExecSql("update CON_HATCH_RECORD set Unload_Mark='1' where CON_HATCH_RECORD_ID='" & ds_con.Tables(0).Rows(0).Item("CON_HATCH_RECORD_ID") & "'")
                        ExecSql("update con_image set Unload_Mark='1' where ship_id='" & Ship_ID & "' and Unload_Mark='0' and container_no='" & CONTAINERNO & "'")
                    Else
                        MsgBox("船图箱信息中没有该箱号！该箱为溢出。")
                        Me.C1TALLY.Columns.Item("UnLoad_Mark").Value = 1
                        'e.CellStyle.BackColor = System.Drawing.Color.White
                        'Me.C1TALLY.SelectedStyle.BackColor = System.Drawing.Color.Blue

                        'Me.C1TALLY.Refresh()

                    End If
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Private Sub CONTAIN(ByVal CONTAINERNO As String, ByVal oldCONTAINERNO As String)
    '    Try
    '        If Len(CONTAINERNO) > 0 Then

    '            Dim ds_con As New DataSet

    '            If INOUT_MARK <> "1" Then   '出舱时没有溢出
    '                If RELOAD <> "1" Then   '重装时没有溢出

    '                    dw = Getdata("select * from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and Unload_Mark='1' and CONTAINER_NO='" & oldCONTAINERNO & "' ", ds_con)
    '                    If ds_con.Tables(0).Rows.Count > 0 Then
    '                        ExecSql("update CON_HATCH_RECORD set Unload_Mark='0' where CON_HATCH_RECORD_ID='" & ds_con.Tables(0).Rows(0).Item("CON_HATCH_RECORD_ID") & "'")
    '                    End If
    '                    ds_con.Reset()
    '                    dw = Getdata("select * from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and Unload_Mark='0' and CONTAINER_NO='" & CONTAINERNO & "' ", ds_con)

    '                    If ds_con.Tables(0).Rows.Count > 0 Then
    '                        ExecSql("update CON_HATCH_RECORD set Unload_Mark='1' where CON_HATCH_RECORD_ID='" & ds_con.Tables(0).Rows(0).Item("CON_HATCH_RECORD_ID") & "'")
    '                        Me.C1TALLY.Columns.Item("UnLoad_Mark").Text = "0"
    '                    Else
    '                        ds_con.Reset()
    '                        dw = Getdata("select * from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and  CONTAINER_NO='" & CONTAINERNO & "' ", ds_con)
    '                        If ds_con.Tables(0).Rows.Count > 0 Then
    '                            ds_con.Reset()
    '                            dw = Getdata("select * from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and Unload_Mark='1' CONTAINER_NO='" & CONTAINERNO & "' ", ds_con)
    '                            MsgBox("该箱已卸, 请查实!")
    '                        Else
    '                            MsgBox("船图箱信息中没有该箱号！该箱为溢出。")
    '                            Me.C1TALLY.Columns.Item("UnLoad_Mark").Text = "1"
    '                        End If

    '                    End If
    '                End If

    '            End If
    '        End If
    '    Catch ex As System.Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Private Sub TxtCONTAINERNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCONTAINERNO.TextChanged
        Dim dsquery As New DataSet
        Try
            If Len(Trim(TxtCONTAINERNO.Text)) > 0 Then
                'dw = Getdata("select CON_HATCH_RECORD_ID,CONTAINER_NO,SIZE_CON,FULLOREMPTY,weight,SEALNO,BAYNO from VIEWCON_TALLY_HATCH where ship_id='" & Ship_ID & "' and CONTAINER_NO like '%" & Trim(TxtCONTAINERNO.Text) & "%' and bayno like '" & Txtseachbay.Text & "%'", dsquery)
                dsimage.Reset()
                dwimage = Getdata("select CON_HATCH_RECORD_ID,CONTAINER_NO,SIZE_CON,FULLOREMPTY,weight,SEALNO,BAYNO,BAYCOL,BAYROW from VIEWCON_TALLY_HATCH where ship_id='" & Ship_ID & "' and CONTAINER_NO like '%" & Trim(TxtCONTAINERNO.Text) & "%' and bayno like '" & Txtseachbay.Text & "%'", dsimage)

                C1IMAGE.DataSource = dsimage.Tables(0).DefaultView
                C1IMAGE.Splits(0).DisplayColumns.Item("SIZE_CON").Visible = False
                C1IMAGE.Splits(0).DisplayColumns.Item("FULLOREMPTY").Visible = False
                C1IMAGE.Splits(0).DisplayColumns.Item("CON_HATCH_RECORD_ID").Visible = False
                C1IMAGE.Splits(0).DisplayColumns.Item("weight").Visible = False
                C1IMAGE.Splits(0).DisplayColumns.Item("BAYCOL").Visible = False
                C1IMAGE.Splits(0).DisplayColumns.Item("BAYROW").Visible = False
                C1IMAGE.Columns.Item("CONTAINER_NO").Caption = "箱号"
                C1IMAGE.Columns.Item("SEALNO").Caption = "铅封号"
                C1IMAGE.Columns.Item("BAYNO").Caption = "贝位号"

                C1IMAGE.Splits(0).DisplayColumns.Item("CONTAINER_NO").Width = 90
                C1IMAGE.Splits(0).DisplayColumns.Item("SEALNO").Width = 80
                C1IMAGE.Splits(0).DisplayColumns.Item("BAYNO").Width = 50
                'Call SetC1IMAGEWidth()
                C1IMAGE.Refresh()
                If RBCOL.Checked = True Then
                    dwimage.Sort = "baycol,bayrow"
                ElseIf RBROW.Checked = True Then
                    dwimage.Sort = "bayrow,baycol"
                End If
                Label15.Text = "共" & dsimage.Tables(0).Rows.Count & "个"
            Else
                Call GETIMAGE()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Txtseachbay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtseachbay.TextChanged
        Dim dsquery As New DataSet
        Try
            If Len(Trim(Txtseachbay.Text)) > 0 Then
                dsimage.Reset()
                dwimage = Getdata("select CON_HATCH_RECORD_ID,CONTAINER_NO,SIZE_CON,FULLOREMPTY,weight,SEALNO,BAYNO,BAYCOL,BAYROW from VIEWCON_TALLY_HATCH where ship_id='" & Ship_ID & "' and CONTAINER_NO like '%" & Trim(TxtCONTAINERNO.Text) & "%' and bayno like '" & Txtseachbay.Text & "%'", dsimage)

                C1IMAGE.DataSource = dsimage.Tables(0).DefaultView
                C1IMAGE.Splits(0).DisplayColumns.Item("SIZE_CON").Visible = False
                C1IMAGE.Splits(0).DisplayColumns.Item("FULLOREMPTY").Visible = False
                C1IMAGE.Splits(0).DisplayColumns.Item("CON_HATCH_RECORD_ID").Visible = False
                C1IMAGE.Splits(0).DisplayColumns.Item("weight").Visible = False
                C1IMAGE.Splits(0).DisplayColumns.Item("BAYCOL").Visible = False
                C1IMAGE.Splits(0).DisplayColumns.Item("BAYROW").Visible = False
                C1IMAGE.Columns.Item("CONTAINER_NO").Caption = "箱号"
                C1IMAGE.Columns.Item("SEALNO").Caption = "铅封号"
                C1IMAGE.Columns.Item("BAYNO").Caption = "贝位号"

                C1IMAGE.Splits(0).DisplayColumns.Item("CONTAINER_NO").Width = 90
                C1IMAGE.Splits(0).DisplayColumns.Item("SEALNO").Width = 80
                C1IMAGE.Splits(0).DisplayColumns.Item("BAYNO").Width = 50
                'Call SetC1IMAGEWidth()
                C1IMAGE.Refresh()
                If RBCOL.Checked = True Then
                    dwimage.Sort = "baycol,bayrow"
                ElseIf RBROW.Checked = True Then
                    dwimage.Sort = "bayrow,baycol"
                End If
                Label15.Text = "共" & dsimage.Tables(0).Rows.Count & "个"
            Else
                Call TxtCONTAINERNO_TextChanged(sender, e)
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GETIMAGE()
        Try
            dwimage = Getdata("select CON_HATCH_RECORD_ID,CONTAINER_NO,SIZE_CON,FULLOREMPTY,weight,SEALNO,BAYNO,BAYCOL,BAYROW from VIEWCON_TALLY_HATCH where ship_id='" & Ship_ID & "' and CONTAINER_NO like '%" & Trim(TxtCONTAINERNO.Text) & "%' and bayno like '%" & Txtseachbay.Text & "%'", dsimage)
            C1IMAGE.DataSource = dsimage.Tables(0).DefaultView
            C1IMAGE.Splits(0).DisplayColumns.Item("SIZE_CON").Visible = True
            C1IMAGE.Splits(0).DisplayColumns.Item("FULLOREMPTY").Visible = False
            C1IMAGE.Splits(0).DisplayColumns.Item("CON_HATCH_RECORD_ID").Visible = False
            C1IMAGE.Splits(0).DisplayColumns.Item("weight").Visible = False
            C1IMAGE.Splits(0).DisplayColumns.Item("BAYCOL").Visible = False
            C1IMAGE.Splits(0).DisplayColumns.Item("BAYROW").Visible = False
            C1IMAGE.Columns.Item("CONTAINER_NO").Caption = "箱号"
            C1IMAGE.Columns.Item("SEALNO").Caption = "铅封号"
            C1IMAGE.Columns.Item("BAYNO").Caption = "贝位号"
            C1IMAGE.Columns.Item("SIZE_CON").Caption = "尺寸"
            C1IMAGE.Splits(0).DisplayColumns.Item("CONTAINER_NO").Width = 80
            C1IMAGE.Splits(0).DisplayColumns.Item("SEALNO").Width = 60
            C1IMAGE.Splits(0).DisplayColumns.Item("BAYNO").Width = 50
            C1IMAGE.Splits(0).DisplayColumns.Item("SIZE_CON").Width = 20
            C1IMAGE.Refresh()
            If RBCOL.Checked = True Then
                dwimage.Sort = "baycol,bayrow"
            ElseIf RBROW.Checked = True Then
                dwimage.Sort = "bayrow,baycol"
            End If
            Label15.Text = "共" & dsimage.Tables(0).Rows.Count & "个"
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtADD.Click
        If ds_sub.Tables(0).Rows.Count >= 30 Then
            MsgBox("每张理箱单最多只能填30个箱子！")
        Else
            Try
                Me.C1TALLY.MoveLast()
                Me.C1TALLY.Row = Me.C1TALLY.Row + 1
                Me.C1TALLY.Columns.Item("CON_TALLY_LIST_ID").Text = TXTCON_TALLY_LIST_ID.Text
                Me.C1TALLY.Columns.Item("CONTAINER_NO").Value = Me.C1IMAGE.Columns.Item("CONTAINER_NO").Text
                Me.C1TALLY.Columns.Item("SIZE_CON").Value = Me.C1IMAGE.Columns.Item("SIZE_CON").Text
                Me.C1TALLY.Columns.Item("FULLOREMPTY").Value = Me.C1IMAGE.Columns.Item("FULLOREMPTY").Text
                Me.C1TALLY.Columns.Item("SEALNO").Value = Me.C1IMAGE.Columns.Item("SEALNO").Text
                Me.C1TALLY.Columns.Item("BAYNO").Value = Me.C1IMAGE.Columns.Item("BAYNO").Text
                Me.C1TALLY.Columns.Item("weight").Value = Me.C1IMAGE.Columns.Item("weight").Text
                'Me.C1TALLY.Columns.Item("RELOAD").Value = 0
                Me.C1TALLY.Columns.Item("OPENBOX").Value = 0
                Me.C1TALLY.Columns.Item("UnLoad_Mark").Value = 0
                'Me.C1TALLY.Columns.Item("OUT_HATCH").Value = 0
                Me.C1TALLY.Columns.Item("CODE_SHIP_AGENT").Value = agent
                ExecSql("update CON_HATCH_RECORD set Unload_Mark='1' where CON_HATCH_RECORD_ID='" & Me.C1IMAGE.Columns.Item("CON_HATCH_RECORD_ID").Text & "'")
                ExecSql("update con_image set Unload_Mark='1' where ship_id='" & Ship_ID & "' and container_no='" & Me.C1IMAGE.Columns.Item("CONTAINER_NO").Text & "'")
                Me.C1TALLY.Row = Me.C1TALLY.Row + 1
                'Call calcucontain()
                Label16.Text = "共" & ds_sub.Tables(0).Rows.Count & "个"
                TxtCONTAINERNO.Text = ""
                TxtCONTAINERNO.Focus()
                Call Txtseachbay_TextChanged(sender, e)
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtADDALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtADDALL.Click
        Dim i As Integer
        If dsimage.Tables(0).Rows.Count + ds_sub.Tables(0).Rows.Count > 30 Then
            MsgBox("每张理箱单最多只能填30个箱子！")
        Else

            Try
                Me.C1TALLY.MoveLast()
                For i = 0 To dsimage.Tables(0).Rows.Count - 1
                    Me.C1TALLY.Row = Me.C1TALLY.Row + 1
                    Me.C1TALLY.Columns.Item("CON_TALLY_LIST_ID").Text = TXTCON_TALLY_LIST_ID.Text
                    Me.C1TALLY.Columns.Item("CONTAINER_NO").Value = dsimage.Tables(0).Rows(i).Item("CONTAINER_NO")
                    Me.C1TALLY.Columns.Item("SIZE_CON").Value = dsimage.Tables(0).Rows(i).Item("SIZE_CON")
                    Me.C1TALLY.Columns.Item("FULLOREMPTY").Value = dsimage.Tables(0).Rows(i).Item("FULLOREMPTY")
                    Me.C1TALLY.Columns.Item("SEALNO").Value = dsimage.Tables(0).Rows(i).Item("SEALNO")
                    Me.C1TALLY.Columns.Item("BAYNO").Value = dsimage.Tables(0).Rows(i).Item("BAYNO")
                    Me.C1TALLY.Columns.Item("weight").Value = dsimage.Tables(0).Rows(i).Item("weight")
                    'Me.C1TALLY.Columns.Item("RELOAD").Value = 0
                    Me.C1TALLY.Columns.Item("OPENBOX").Value = 0
                    Me.C1TALLY.Columns.Item("UnLoad_Mark").Value = 0
                    'Me.C1TALLY.Columns.Item("OUT_HATCH").Value = 0
                    Me.C1TALLY.Columns.Item("CODE_SHIP_AGENT").Value = agent
                    ExecSql("update CON_HATCH_RECORD set Unload_Mark='1' where CON_HATCH_RECORD_ID='" & dsimage.Tables(0).Rows(i).Item("CON_HATCH_RECORD_ID") & "'")
                    ExecSql("update con_image set Unload_Mark='1' where ship_id='" & Ship_ID & "' and container_no='" & dsimage.Tables(0).Rows(i).Item("CONTAINER_NO") & "'")
                Next

                TxtCONTAINERNO.Text = ""
                TxtCONTAINERNO.Focus()
                Call Txtseachbay_TextChanged(sender, e)
                C1TALLY.Refresh()
                Me.C1TALLY.MoveFirst()
                'Call calcucontain()
                Label16.Text = "共" & ds_sub.Tables(0).Rows.Count & "个"
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub BtDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDELETE.Click
        Dim ds_update As New DataSet

        dw = Getdata("select * from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and container_no='" & Me.C1TALLY.Columns.Item("container_no").Text & "'", ds_update)
        If ds_update.Tables(0).Rows.Count > 0 Then
            ExecSql("update CON_HATCH_RECORD set unload_mark='0' where CON_HATCH_RECORD_ID='" & ds_update.Tables(0).Rows(0).Item("CON_HATCH_RECORD_ID") & "'")
            ExecSql("update con_image set Unload_Mark='0' where ship_id='" & Ship_ID & "' and container_no='" & Me.C1TALLY.Columns.Item("CONTAINER_NO").Text & "'")
        End If
        Call Txtseachbay_TextChanged(sender, e)
        Me.C1TALLY.AllowDelete = True
        Me.C1TALLY.Delete()
        Me.C1TALLY.AllowDelete = False
        Me.C1TALLY.MoveFirst()
        'Call calcucontain()
        Label16.Text = "共" & ds_sub.Tables(0).Rows.Count & "个"

        ' Me.C1TALLY.Refresh()
    End Sub

    Private Sub BtDELETEALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDELETEALL.Click
        Dim i As Integer
        Dim J As Integer

        Try
            Me.C1TALLY.MoveLast()
            J = Me.C1TALLY.Row.ToString

            Me.C1TALLY.Row = 0
            For i = 0 To J
                Call BtDELETE_Click(sender, e)
                'Me.C1TALLY.Row = Me.C1TALLY.Row + 1 
            Next

            Call Txtseachbay_TextChanged(sender, e)
            C1TALLY.Refresh()
            Me.C1TALLY.MoveFirst()
            'Call calcucontain()
            Label16.Text = "共" & ds_sub.Tables(0).Rows.Count & "个"
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNOK.Click

        Dim i As Integer
        Dim j As Integer

        Try
            'If Len(Trim(Txt20E.Text)) = 0 Then
            '    Txt20E.Text = 0
            'End If
            'If Len(Trim(Txt20F.Text)) = 0 Then
            '    Txt20F.Text = 0
            'End If
            'If Len(Trim(Txt40E.Text)) = 0 Then
            '    Txt40E.Text = 0
            'End If
            'If Len(Trim(Txt40F.Text)) = 0 Then
            '    Txt40F.Text = 0
            'End If
            'If Len(Trim(Txt45E.Text)) = 0 Then
            '    Txt45E.Text = 0
            'End If
            'If Len(Trim(Txt45F.Text)) = 0 Then
            '    Txt45F.Text = 0
            'End If
            'If Len(Trim(TxtTOTAL.Text)) = 0 Then
            '    TxtTOTAL.Text = 0
            'End If
            'If Len(Trim(TxtTEU.Text)) = 0 Then
            '    TxtTEU.Text = 0
            'End If

            'ExecSql("UPDATE con_tally_list set e20='" & Txt20E.Text & "',f20='" & Txt20F.Text & "',e40='" & Txt40E.Text & "',f40='" & Txt40F.Text & "',e45='" & Txt45E.Text & "',f45='" & Txt45F.Text & "',con_total='" & TxtTOTAL.Text & "',teu='" & TxtTEU.Text & "' where con_tally_list_id='" & TXTCON_TALLY_LIST_ID.Text & "'")
            Me.C1TALLY.MoveLast()
            j = Me.C1TALLY.Row
            Me.C1TALLY.MoveFirst()

            For i = 0 To j
                If Len(Trim(Me.C1TALLY.Columns.Item("CONTAINER_NO").Text)) > 0 Then
                    If Len(Trim(Me.C1TALLY.Columns.Item("SIZE_CON").Text)) > 0 Then
                        If Len(Trim(Me.C1TALLY.Columns.Item("FULLOREMPTY").Text)) > 0 Then

                        Else
                            MsgBox("录入有错误，请检查！")
                            Me.C1TALLY.Row = i
                            Exit Sub
                        End If
                    Else
                        MsgBox("录入有错误，请检查！")
                        Me.C1TALLY.Row = i
                        Exit Sub
                    End If
                Else
                    MsgBox("录入有错误，请检查！")
                    Me.C1TALLY.Row = i
                    Exit Sub
                End If
                Me.C1TALLY.MoveNext()
            Next i
            Me.C1TALLY.MoveFirst()
            sqlda_sub.Update(ds_sub)
            Call BTQUIT_Click(sender, e)
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RBCOL_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RBCOL.CheckedChanged
        Call Txtseachbay_TextChanged(sender, e)
    End Sub

    Private Sub RBROW_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RBROW.CheckedChanged
        Call Txtseachbay_TextChanged(sender, e)
    End Sub
    Private Sub C1TALLY_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles C1TALLY.BeforeColEdit
        Try
            If e.ColIndex = 2 Then
                oldcon = Me.C1TALLY.Columns.Item("container_no").Text
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub C1TALLY_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1TALLY.AfterColEdit
        Dim ds_CRITERION As New DataSet
        Try
            'If e.ColIndex = 2 Then
            '    dw = Getdata("select * from con_CRITERION where CONTAINER_NO='" & Me.C1TALLY.Columns.Item("CONTAINER_NO").Text.ToString & "'", ds_CRITERION)
            '    If ds_CRITERION.Tables(0).Rows.Count > 0 Then
            '        Call CONTAIN(Me.C1TALLY.Columns.Item("CONTAINER_NO").Text.ToString, oldcon)
            '    Else
            '        If Len(Trim(Me.C1TALLY.Columns.Item("CONTAINER_NO").Text.ToString)) > 0 Then
            '            If CheckConNO(Me.C1TALLY.Columns.Item("CONTAINER_NO").Text.ToString) = 2 Then
            '                Call CONTAIN(Me.C1TALLY.Columns.Item("CONTAINER_NO").Text.ToString, oldcon)
            '            Else
            '                If MsgBox("箱号正确吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
            '                    Call CONTAIN(Me.C1TALLY.Columns.Item("CONTAINER_NO").Text.ToString, oldcon)
            '                End If
            '            End If
            '        End If
            '    End If
            'End If

            If e.ColIndex = 2 Then
                If Len(Trim(Me.C1TALLY.Columns.Item("CONTAINER_NO").Text.ToString)) > 0 Then
                    dw = Getdata("select * from con_CRITERION where CONTAINER_NO='" & Me.C1TALLY.Columns.Item("CONTAINER_NO").Text.ToString & "'", ds_CRITERION)
                    If ds_CRITERION.Tables(0).Rows.Count > 0 Then
                        If Len(Trim(Me.C1TALLY.Columns.Item("size_con").Text)) = 0 Then
                            Me.C1TALLY.Columns.Item("size_con").Value = ds_CRITERION.Tables(0).Rows(0).Item("size_con")
                        End If
                        If Len(Trim(Me.C1TALLY.Columns.Item("FULLOREMPTY").Text)) = 0 Then
                            Me.C1TALLY.Columns.Item("FULLOREMPTY").Value = "E"
                        End If
                        If Len(Trim(Me.C1TALLY.Columns.Item("WEIGHT").Text)) = 0 Then
                            Me.C1TALLY.Columns.Item("WEIGHT").Value = ds_CRITERION.Tables(0).Rows(0).Item("con_weight")
                        End If
                        Call CONTAIN(Me.C1TALLY.Columns.Item("CONTAINER_NO").Text.ToString, oldcon)
                    Else
                        If CheckConNO(Me.C1TALLY.Columns.Item("CONTAINER_NO").Text.ToString) = 2 Then
                            Call CONTAIN(Me.C1TALLY.Columns.Item("CONTAINER_NO").Text.ToString, oldcon)

                        Else
                            If MsgBox("箱号正确吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                                Call CONTAIN(Me.C1TALLY.Columns.Item("CONTAINER_NO").Text.ToString, oldcon)
                            End If
                        End If
                    End If
                    Call Txtseachbay_TextChanged(sender, e)
                Else
                    MsgBox("箱号不能为空！")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CombBERTHNO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombBERTHNO.Leave
        Dim DSSELECT As New DataSet
        Try
            If Len(Trim(CombBERTHNO.Text)) > 0 Then
                If Mid(Trim(CombBERTHNO.Text), 1, 1) = "0" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "1" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "2" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "3" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "4" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "5" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "6" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "7" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "8" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "9" Then
                    dw = Getdata("SELECT * FROM CODE_BERTH WHERE CODE_BERTH='" & Trim(CombBERTHNO.Text) & "'", DSSELECT)
                    If DSSELECT.Tables(0).Rows.Count > 0 Then
                        CombBERTHNO.SelectedValue = Trim(CombBERTHNO.Text)
                    Else
                        MsgBox("没有该泊位号，请检查输入是否正确！")
                        CombBERTHNO.Focus()
                    End If
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1TALLY_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1TALLY.FetchRowStyle
        If Me.C1TALLY.Columns("unload_mark").CellValue(e.Row) = "1" Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        End If
    End Sub
    Private Sub BtADD_CONTAINER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtADD_CONTAINER.Click
        Dim dwsp As New DataView
        Dim dssp As New DataSet
        Dim dwsp1 As New DataView
        Dim dssp1 As New DataSet
        Dim i As Integer
        If CType(Trim(TxtTOTAL.Text), Integer) + ds_sub.Tables(0).Rows.Count > 30 Then
            MsgBox("每张理箱单最多只能填30个箱！")
        Else
            If Len(Trim(Txt20E.Text)) = 0 Then
                Txt20E.Text = 0
            End If
            If Len(Trim(Txt20F.Text)) = 0 Then
                Txt20F.Text = 0
            End If
            If Len(Trim(Txt40E.Text)) = 0 Then
                Txt40E.Text = 0
            End If
            If Len(Trim(Txt40F.Text)) = 0 Then
                Txt40F.Text = 0
            End If
            If Len(Trim(Txt45E.Text)) = 0 Then
                Txt45E.Text = 0
            End If
            If Len(Trim(Txt45F.Text)) = 0 Then
                Txt45F.Text = 0
            End If
            If Len(Trim(TxtTOTAL.Text)) = 0 Then
                TxtTOTAL.Text = 0
            End If
            If Len(Trim(TxtTEU.Text)) = 0 Then
                TxtTEU.Text = 0
            End If
            dwsp1 = Getdata("exec spcon_calcu_containers '" & Ship_ID & "'", dssp1)
            If dssp1.Tables(0).Rows(0).Item("e20") >= CType(Txt20E.Text, Integer) Then
                If dssp1.Tables(0).Rows(0).Item("f20") >= CType(Txt20F.Text, Integer) Then
                    If dssp1.Tables(0).Rows(0).Item("e40") >= CType(Txt40E.Text, Integer) Then
                        If dssp1.Tables(0).Rows(0).Item("f40") >= CType(Txt40F.Text, Integer) Then
                            If dssp1.Tables(0).Rows(0).Item("e45") >= CType(Txt45E.Text, Integer) Then
                                If dssp1.Tables(0).Rows(0).Item("f45") >= CType(Txt45F.Text, Integer) Then
                                    If dssp1.Tables(0).Rows(0).Item("e58") >= CType(Txt58E.Text, Integer) Then
                                        If dssp1.Tables(0).Rows(0).Item("f58") >= CType(Txt58F.Text, Integer) Then

                                            dwsp = Getdata("exec spcon_add_containers '" & Ship_ID & "', '" & CType(Txt20E.Text, Integer) & "','" & CType(Txt20F.Text, Integer) & "','" & CType(Txt40E.Text, Integer) & "','" & CType(Txt40F.Text, Integer) & "','" & CType(Txt45E.Text, Integer) & "','" & CType(Txt45F.Text, Integer) & "','" & CType(Txt58E.Text, Integer) & "','" & CType(Txt58F.Text, Integer) & "'", dssp)
                                            Call Txtseachbay_TextChanged(sender, e)
                                            Try
                                                Me.C1TALLY.MoveLast()
                                                For i = 0 To dssp.Tables(0).Rows.Count - 1
                                                    Me.C1TALLY.Row = Me.C1TALLY.Row + 1
                                                    Me.C1TALLY.Columns.Item("CON_TALLY_LIST_ID").Text = TXTCON_TALLY_LIST_ID.Text
                                                    Me.C1TALLY.Columns.Item("CONTAINER_NO").Value = dssp.Tables(0).Rows(i).Item("CONTAINER_NO")
                                                    Me.C1TALLY.Columns.Item("SIZE_CON").Value = dssp.Tables(0).Rows(i).Item("SIZE_CON")
                                                    Me.C1TALLY.Columns.Item("FULLOREMPTY").Value = dssp.Tables(0).Rows(i).Item("FULLOREMPTY")
                                                    Me.C1TALLY.Columns.Item("SEALNO").Value = dssp.Tables(0).Rows(i).Item("SEALNO")
                                                    Me.C1TALLY.Columns.Item("BAYNO").Value = dssp.Tables(0).Rows(i).Item("BAYNO")
                                                    Me.C1TALLY.Columns.Item("weight").Value = dssp.Tables(0).Rows(i).Item("weight")
                                                    Me.C1TALLY.Columns.Item("OPENBOX").Value = 0
                                                    Me.C1TALLY.Columns.Item("UnLoad_Mark").Value = 0
                                                    Me.C1TALLY.Columns.Item("CODE_SHIP_AGENT").Value = agent
                                                Next
                                                Me.C1TALLY.Row = Me.C1TALLY.Row + 1
                                                Label16.Text = "共" & ds_sub.Tables(0).Rows.Count & "个"
                                            Catch ex As System.Exception
                                                MsgBox(ex.Message)
                                            End Try
                                            Txt20E.Text = 0
                                            Txt20F.Text = 0
                                            Txt40E.Text = 0
                                            Txt40F.Text = 0
                                            Txt45E.Text = 0
                                            Txt45F.Text = 0
                                            Txt58E.Text = 0
                                            Txt58F.Text = 0
                                        Else
                                            MsgBox("舱单中只有" & dssp1.Tables(0).Rows(0).Item("f58") & "个58英尺重箱未理！")
                                            Exit Sub
                                        End If
                                    Else
                                        MsgBox("舱单中只有" & dssp1.Tables(0).Rows(0).Item("e58") & "个58英尺空箱未理！")
                                        Exit Sub
                                    End If
                                Else
                                    MsgBox("舱单中只有" & dssp1.Tables(0).Rows(0).Item("f45") & "个45英尺重箱未理！")
                                    Exit Sub
                                End If
                            Else
                                MsgBox("舱单中只有" & dssp1.Tables(0).Rows(0).Item("e45") & "个45英尺空箱未理！")
                                Exit Sub
                            End If
                        Else
                            MsgBox("舱单中只有" & dssp1.Tables(0).Rows(0).Item("f40") & "个40英尺重箱未理！")
                            Exit Sub
                        End If
                    Else
                        MsgBox("舱单中只有" & dssp1.Tables(0).Rows(0).Item("e40") & "个40英尺空箱未理！")
                        Exit Sub
                    End If
                Else
                    MsgBox("舱单中只有" & dssp1.Tables(0).Rows(0).Item("f20") & "个20英尺重箱未理！")
                    Exit Sub
                End If
            Else
                MsgBox("舱单中只有" & dssp1.Tables(0).Rows(0).Item("e20") & "个20英尺空箱未理！")
                Exit Sub
            End If
        End If
    End Sub
    'Private Sub calcucontain()
    '    Dim i As Integer
    '    E20 = 0
    '    F20 = 0
    '    E40 = 0
    '    F40 = 0
    '    E45 = 0
    '    F45 = 0
    '    TOTAL = 0
    '    TEU = 0
    '    Try
    '        If ds_sub.Tables(0).Rows.Count > 0 Then
    '            For i = 0 To ds_sub.Tables(0).Rows.Count - 1
    '                If ds_sub.Tables(0).Rows(i).Item("SIZE_CON") = "20" Then
    '                    If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "E" Then
    '                        E20 = E20 + 1
    '                    End If
    '                    If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "F" Then
    '                        F20 = F20 + 1
    '                    End If
    '                End If
    '                If ds_sub.Tables(0).Rows(i).Item("SIZE_CON") = "40" Then
    '                    If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "E" Then
    '                        E40 = E40 + 1
    '                    End If
    '                    If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "F" Then
    '                        F40 = F40 + 1
    '                    End If
    '                End If
    '                If ds_sub.Tables(0).Rows(i).Item("SIZE_CON") = "45" Then
    '                    If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "E" Then
    '                        E45 = E45 + 1
    '                    End If
    '                    If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "F" Then
    '                        F45 = F45 + 1
    '                    End If
    '                End If
    '            Next
    '        End If
    '        TOTAL = E20 + F20 + E40 + F40 + E45 + F45
    '        TEU = E20 + F20 + E40 * 2 + F40 * 2 + E45 * 2.5 + F45 * 2.5
    '        Txt20E.Text = E20
    '        Txt20F.Text = F20
    '        Txt40E.Text = E40
    '        Txt40F.Text = F40
    '        Txt45E.Text = E45
    '        Txt45F.Text = F45
    '        TxtTOTAL.Text = TOTAL
    '        TxtTEU.Text = TEU
    '    Catch ex As System.Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Private Sub Txt20E_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt20E.TextChanged
        TxtTOTAL.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer)
        TxtTEU.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + 2 * (CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer)) + CType((2.5 * (CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer))), Integer) + 3 * (CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer))
    End Sub

    Private Sub Txt20F_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt20F.TextChanged
        TxtTOTAL.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer)
        TxtTEU.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + 2 * (CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer)) + CType((2.5 * (CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer))), Integer) + 3 * (CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer))
    End Sub

    Private Sub Txt40E_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt40E.TextChanged
        TxtTOTAL.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer)
        TxtTEU.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + 2 * (CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer)) + CType((2.5 * (CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer))), Integer) + 3 * (CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer))
    End Sub

    Private Sub Txt40F_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt40F.TextChanged
        TxtTOTAL.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer)
        TxtTEU.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + 2 * (CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer)) + CType((2.5 * (CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer))), Integer) + 3 * (CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer))
    End Sub

    Private Sub Txt45E_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt45E.TextChanged
        TxtTOTAL.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer)
        TxtTEU.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + 2 * (CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer)) + CType((2.5 * (CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer))), Integer) + 3 * (CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer))
    End Sub

    Private Sub Txt45F_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt45F.TextChanged
        TxtTOTAL.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer)
        TxtTEU.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + 2 * (CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer)) + CType((2.5 * (CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer))), Integer) + 3 * (CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer))
    End Sub

    Private Sub Txt58E_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt58E.TextChanged
        TxtTOTAL.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer)
        TxtTEU.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + 2 * (CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer)) + CType((2.5 * (CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer))), Integer) + 3 * (CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer))
    End Sub

    Private Sub Txt58F_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt58F.TextChanged
        TxtTOTAL.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer)
        TxtTEU.Text = CType(IIf(Len(Trim(Txt20E.Text)) > 0, Trim(Txt20E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt20F.Text)), Trim(Txt20F.Text), 0), Integer) + 2 * (CType(IIf(Len(Trim(Txt40E.Text)), Trim(Txt40E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt40F.Text)), Trim(Txt40F.Text), 0), Integer)) + CType((2.5 * (CType(IIf(Len(Trim(Txt45E.Text)), Trim(Txt45E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt45F.Text)), Trim(Txt45F.Text), 0), Integer))), Integer) + 3 * (CType(IIf(Len(Trim(Txt58E.Text)), Trim(Txt58E.Text), 0), Integer) + CType(IIf(Len(Trim(Txt58F.Text)), Trim(Txt58F.Text), 0), Integer))
    End Sub

    Private Sub TxtCONTAINERNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCONTAINERNO.KeyPress
        If e.KeyChar = Chr(13) Then
            BtADD.Focus()
        End If
    End Sub
    Private Sub BtADD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BtADD.KeyPress
        If e.KeyChar = Chr(13) Then
            Call BtADD_Click(sender, e)
        End If
    End Sub
    Private Sub Txtteam_NO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTEAM_NO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNO.Focus()
        End If
    End Sub

    Private Sub TxtNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNO.KeyPress
        If e.KeyChar = Chr(13) Then
            CombBERTHNO.Focus()
        End If
    End Sub

    Private Sub CombBERTHNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombBERTHNO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtYARD_NO.Focus()
        End If
    End Sub
    Private Sub TxtYARD_NO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtYARD_NO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtBAY.Focus()
        End If
    End Sub

    Private Sub TxtBAY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBAY.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtCROSS_PERSON.Focus()
        End If
    End Sub
    Private Sub TxtCROSS_PERSON_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCROSS_PERSON.KeyPress
        If e.KeyChar = Chr(13) Then
            DTPdate.Focus()
        End If
    End Sub
    Private Sub DTPdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPdate.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtTime_from.Focus()
        End If
    End Sub
    Private Sub TxtTime_from_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTime_from.KeyPress
        If e.KeyChar = Chr(13) Then
            Txttime_to.Focus()
        End If
    End Sub
    Private Sub Txttime_to_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txttime_to.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK1.Focus()
        End If
    End Sub
    Private Sub CombTALLY_CLERK1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK1.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK2.Focus()
        End If
    End Sub
    Private Sub CombTALLY_CLERK2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK2.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK3.Focus()
        End If
    End Sub
    Private Sub CombTALLY_CLERK3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK3.KeyPress
        If e.KeyChar = Chr(13) Then
            CBNIGHT_MARK.Focus()
        End If
    End Sub
    Private Sub CBNIGHT_MARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBNIGHT_MARK.KeyPress
        If e.KeyChar = Chr(13) Then
            cbHOLIDAY.Focus()
        End If
    End Sub
    Private Sub cbHOLIDAY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbHOLIDAY.KeyPress
        If e.KeyChar = Chr(13) Then
            CBMARK.Focus()
        End If
    End Sub
    Private Sub CBMARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBMARK.KeyPress
        If e.KeyChar = Chr(13) Then
            cbRELOAD.Focus()
        End If
    End Sub

    Private Sub cbRELOAD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbRELOAD.KeyPress
        If e.KeyChar = Chr(13) Then
            CBANCHORAGE_REMARK.Focus()
        End If
    End Sub
    Private Sub CBANCHORAGE_REMARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBANCHORAGE_REMARK.KeyPress
        If e.KeyChar = Chr(13) Then
            CBSEA_AFFAIRE_CARGO.Focus()
        End If
    End Sub
    Private Sub CBSEA_AFFAIRE_CARGO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBSEA_AFFAIRE_CARGO.KeyPress
        If e.KeyChar = Chr(13) Then
            BTOK.Focus()
        End If
    End Sub
    Private Sub Txt20E_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt20E.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt20F.Focus()
        End If
    End Sub
    Private Sub Txt20F_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt20F.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt40E.Focus()
        End If
    End Sub
    Private Sub Txt40E_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt40E.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt40F.Focus()
        End If
    End Sub
    Private Sub Txt40F_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt40F.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt45E.Focus()
        End If
    End Sub
    Private Sub Txt45E_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt45E.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt45F.Focus()
        End If
    End Sub
    Private Sub Txt45F_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt45F.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt58E.Focus()
        End If
    End Sub
    Private Sub Txt58E_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt58E.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt58F.Focus()
        End If
    End Sub
    Private Sub Txt58F_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt58F.KeyPress
        If e.KeyChar = Chr(13) Then
            BtADD_CONTAINER.Focus()
        End If
    End Sub
End Class
