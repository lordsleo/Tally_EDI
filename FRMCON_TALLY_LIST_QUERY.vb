Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FRMCON_TALLY_LIST_QUERY
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim dw As New DataView()
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
    'Dim oldrow As Integer
    Dim oldcon As String
    Dim dsimage As New DataSet()
    Dim agent As String

    Dim E20 As Integer
    Dim F20 As Integer
    Dim E40 As Integer
    Dim F40 As Integer
    Dim E45 As Integer
    Dim F45 As Integer
    Dim TOTAL As Integer
    Dim TEU As Integer
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
    Friend WithEvents TXTCON_TALLY_LIST_ID As System.Windows.Forms.TextBox
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents C1TALLY As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TxtBAY As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCROSS_PERSON As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CombTALLY_CLERK3 As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK2 As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CombBERTHNO As System.Windows.Forms.ComboBox
    Friend WithEvents TxtYARD_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTime_from As System.Windows.Forms.TextBox
    Friend WithEvents Txttime_to As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DTPdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbRELOAD As System.Windows.Forms.CheckBox
    Friend WithEvents cbHOLIDAY As System.Windows.Forms.CheckBox
    Friend WithEvents CBSEA_AFFAIRE_CARGO As System.Windows.Forms.CheckBox
    Friend WithEvents CBNIGHT_MARK As System.Windows.Forms.CheckBox
    Friend WithEvents CBANCHORAGE_REMARK As System.Windows.Forms.CheckBox
    Friend WithEvents CBMARK As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTEAM_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtTEU As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Txt45F As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Txt45E As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Txt40F As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Txt40E As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Txt20F As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Txt20E As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRMCON_TALLY_LIST_QUERY))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.TXTCON_TALLY_LIST_ID = New System.Windows.Forms.TextBox
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.C1TALLY = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TxtBAY = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtNO = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCROSS_PERSON = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.CombTALLY_CLERK3 = New System.Windows.Forms.ComboBox
        Me.CombTALLY_CLERK2 = New System.Windows.Forms.ComboBox
        Me.CombTALLY_CLERK1 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CombBERTHNO = New System.Windows.Forms.ComboBox
        Me.TxtYARD_NO = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtTime_from = New System.Windows.Forms.TextBox
        Me.Txttime_to = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.DTPdate = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbRELOAD = New System.Windows.Forms.CheckBox
        Me.cbHOLIDAY = New System.Windows.Forms.CheckBox
        Me.CBSEA_AFFAIRE_CARGO = New System.Windows.Forms.CheckBox
        Me.CBNIGHT_MARK = New System.Windows.Forms.CheckBox
        Me.CBANCHORAGE_REMARK = New System.Windows.Forms.CheckBox
        Me.CBMARK = New System.Windows.Forms.CheckBox
        Me.TxtTEAM_NO = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtTEU = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.TxtTOTAL = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Txt45F = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Txt45E = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Txt40F = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Txt40E = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Txt20F = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Txt20E = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        CType(Me.C1TALLY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTCON_TALLY_LIST_ID
        '
        Me.TXTCON_TALLY_LIST_ID.Location = New System.Drawing.Point(694, 130)
        Me.TXTCON_TALLY_LIST_ID.Name = "TXTCON_TALLY_LIST_ID"
        Me.TXTCON_TALLY_LIST_ID.Size = New System.Drawing.Size(22, 21)
        Me.TXTCON_TALLY_LIST_ID.TabIndex = 154
        Me.TXTCON_TALLY_LIST_ID.Text = ""
        Me.TXTCON_TALLY_LIST_ID.Visible = False
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(608, 380)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 149
        Me.BTQUIT.Text = "取消"
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
        Me.C1TALLY.ExpandColor = System.Drawing.Color.Black
        Me.C1TALLY.FetchRowStyles = True
        Me.C1TALLY.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TALLY.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1TALLY.Location = New System.Drawing.Point(8, 126)
        Me.C1TALLY.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1TALLY.Name = "C1TALLY"
        Me.C1TALLY.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TALLY.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TALLY.PreviewInfo.ZoomFactor = 75
        Me.C1TALLY.PrintInfo.ShowOptionsDialog = False
        Me.C1TALLY.RecordSelectorWidth = 17
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1TALLY.RowDivider = GridLines1
        Me.C1TALLY.RowHeight = 16
        Me.C1TALLY.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1TALLY.ScrollTips = False
        Me.C1TALLY.Size = New System.Drawing.Size(510, 312)
        Me.C1TALLY.TabIndex = 147
        Me.C1TALLY.Text = "C1TrueDBGrid2"
        Me.C1TALLY.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Borde" & _
        "r:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" Colu" & _
        "mnFooterHeight=""18"" FetchRowStyles=""True"" MarqueeStyle=""DottedCellBorder"" Record" & _
        "SelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollG" & _
        "roup=""1""><ClientRect>0, 0, 506, 308</ClientRect><BorderSide>0</BorderSide><Capti" & _
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
        "th><ClientArea>0, 0, 506, 308</ClientArea></Blob>"
        '
        'TxtBAY
        '
        Me.TxtBAY.Enabled = False
        Me.TxtBAY.Location = New System.Drawing.Point(262, 34)
        Me.TxtBAY.MaxLength = 20
        Me.TxtBAY.Name = "TxtBAY"
        Me.TxtBAY.Size = New System.Drawing.Size(108, 21)
        Me.TxtBAY.TabIndex = 145
        Me.TxtBAY.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(190, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "舱/排位"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNO
        '
        Me.TxtNO.Enabled = False
        Me.TxtNO.Location = New System.Drawing.Point(76, 34)
        Me.TxtNO.MaxLength = 10
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(108, 21)
        Me.TxtNO.TabIndex = 143
        Me.TxtNO.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 22)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "编号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCROSS_PERSON
        '
        Me.TxtCROSS_PERSON.Enabled = False
        Me.TxtCROSS_PERSON.Location = New System.Drawing.Point(262, 60)
        Me.TxtCROSS_PERSON.MaxLength = 10
        Me.TxtCROSS_PERSON.Name = "TxtCROSS_PERSON"
        Me.TxtCROSS_PERSON.Size = New System.Drawing.Size(108, 21)
        Me.TxtCROSS_PERSON.TabIndex = 136
        Me.TxtCROSS_PERSON.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(190, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 22)
        Me.Label12.TabIndex = 135
        Me.Label12.Text = "交接人员"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombTALLY_CLERK3
        '
        Me.CombTALLY_CLERK3.Enabled = False
        Me.CombTALLY_CLERK3.Location = New System.Drawing.Point(630, 60)
        Me.CombTALLY_CLERK3.Name = "CombTALLY_CLERK3"
        Me.CombTALLY_CLERK3.Size = New System.Drawing.Size(108, 20)
        Me.CombTALLY_CLERK3.TabIndex = 134
        '
        'CombTALLY_CLERK2
        '
        Me.CombTALLY_CLERK2.Enabled = False
        Me.CombTALLY_CLERK2.Location = New System.Drawing.Point(630, 34)
        Me.CombTALLY_CLERK2.Name = "CombTALLY_CLERK2"
        Me.CombTALLY_CLERK2.Size = New System.Drawing.Size(108, 20)
        Me.CombTALLY_CLERK2.TabIndex = 133
        '
        'CombTALLY_CLERK1
        '
        Me.CombTALLY_CLERK1.Enabled = False
        Me.CombTALLY_CLERK1.Location = New System.Drawing.Point(630, 8)
        Me.CombTALLY_CLERK1.Name = "CombTALLY_CLERK1"
        Me.CombTALLY_CLERK1.Size = New System.Drawing.Size(108, 20)
        Me.CombTALLY_CLERK1.TabIndex = 132
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(558, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 22)
        Me.Label9.TabIndex = 131
        Me.Label9.Text = "理货员3"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(558, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 22)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "理货员2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(558, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 22)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "理货员1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombBERTHNO
        '
        Me.CombBERTHNO.Enabled = False
        Me.CombBERTHNO.Location = New System.Drawing.Point(76, 62)
        Me.CombBERTHNO.Name = "CombBERTHNO"
        Me.CombBERTHNO.Size = New System.Drawing.Size(108, 20)
        Me.CombBERTHNO.TabIndex = 128
        '
        'TxtYARD_NO
        '
        Me.TxtYARD_NO.Enabled = False
        Me.TxtYARD_NO.Location = New System.Drawing.Point(262, 8)
        Me.TxtYARD_NO.MaxLength = 20
        Me.TxtYARD_NO.Name = "TxtYARD_NO"
        Me.TxtYARD_NO.Size = New System.Drawing.Size(108, 21)
        Me.TxtYARD_NO.TabIndex = 127
        Me.TxtYARD_NO.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(190, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 22)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "库场车驳号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "泊位号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTime_from
        '
        Me.TxtTime_from.Enabled = False
        Me.TxtTime_from.Location = New System.Drawing.Point(446, 32)
        Me.TxtTime_from.MaxLength = 4
        Me.TxtTime_from.Name = "TxtTime_from"
        Me.TxtTime_from.Size = New System.Drawing.Size(108, 21)
        Me.TxtTime_from.TabIndex = 124
        Me.TxtTime_from.Text = ""
        '
        'Txttime_to
        '
        Me.Txttime_to.Enabled = False
        Me.Txttime_to.Location = New System.Drawing.Point(446, 58)
        Me.Txttime_to.MaxLength = 4
        Me.Txttime_to.Name = "Txttime_to"
        Me.Txttime_to.Size = New System.Drawing.Size(108, 21)
        Me.Txttime_to.TabIndex = 123
        Me.Txttime_to.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(374, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 22)
        Me.Label13.TabIndex = 122
        Me.Label13.Text = "作业日期"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPdate
        '
        Me.DTPdate.CustomFormat = "yyyy-MM-dd"
        Me.DTPdate.Enabled = False
        Me.DTPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPdate.Location = New System.Drawing.Point(446, 6)
        Me.DTPdate.Name = "DTPdate"
        Me.DTPdate.Size = New System.Drawing.Size(108, 21)
        Me.DTPdate.TabIndex = 121
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(374, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 22)
        Me.Label11.TabIndex = 120
        Me.Label11.Text = "作业止时间"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(374, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "作业起时间"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbRELOAD
        '
        Me.cbRELOAD.Enabled = False
        Me.cbRELOAD.Location = New System.Drawing.Point(608, 256)
        Me.cbRELOAD.Name = "cbRELOAD"
        Me.cbRELOAD.Size = New System.Drawing.Size(65, 18)
        Me.cbRELOAD.TabIndex = 197
        Me.cbRELOAD.Text = "重装"
        '
        'cbHOLIDAY
        '
        Me.cbHOLIDAY.Enabled = False
        Me.cbHOLIDAY.Location = New System.Drawing.Point(608, 204)
        Me.cbHOLIDAY.Name = "cbHOLIDAY"
        Me.cbHOLIDAY.Size = New System.Drawing.Size(65, 18)
        Me.cbHOLIDAY.TabIndex = 196
        Me.cbHOLIDAY.Text = "节假日"
        '
        'CBSEA_AFFAIRE_CARGO
        '
        Me.CBSEA_AFFAIRE_CARGO.Enabled = False
        Me.CBSEA_AFFAIRE_CARGO.Location = New System.Drawing.Point(608, 308)
        Me.CBSEA_AFFAIRE_CARGO.Name = "CBSEA_AFFAIRE_CARGO"
        Me.CBSEA_AFFAIRE_CARGO.Size = New System.Drawing.Size(65, 18)
        Me.CBSEA_AFFAIRE_CARGO.TabIndex = 195
        Me.CBSEA_AFFAIRE_CARGO.Text = "海事"
        '
        'CBNIGHT_MARK
        '
        Me.CBNIGHT_MARK.Enabled = False
        Me.CBNIGHT_MARK.Location = New System.Drawing.Point(608, 178)
        Me.CBNIGHT_MARK.Name = "CBNIGHT_MARK"
        Me.CBNIGHT_MARK.Size = New System.Drawing.Size(65, 18)
        Me.CBNIGHT_MARK.TabIndex = 194
        Me.CBNIGHT_MARK.Text = "夜班"
        '
        'CBANCHORAGE_REMARK
        '
        Me.CBANCHORAGE_REMARK.Enabled = False
        Me.CBANCHORAGE_REMARK.Location = New System.Drawing.Point(608, 282)
        Me.CBANCHORAGE_REMARK.Name = "CBANCHORAGE_REMARK"
        Me.CBANCHORAGE_REMARK.Size = New System.Drawing.Size(65, 18)
        Me.CBANCHORAGE_REMARK.TabIndex = 193
        Me.CBANCHORAGE_REMARK.Text = "锚地"
        '
        'CBMARK
        '
        Me.CBMARK.Enabled = False
        Me.CBMARK.Location = New System.Drawing.Point(608, 230)
        Me.CBMARK.Name = "CBMARK"
        Me.CBMARK.Size = New System.Drawing.Size(65, 18)
        Me.CBMARK.TabIndex = 192
        Me.CBMARK.Text = "出舱"
        '
        'TxtTEAM_NO
        '
        Me.TxtTEAM_NO.Enabled = False
        Me.TxtTEAM_NO.Location = New System.Drawing.Point(76, 8)
        Me.TxtTEAM_NO.MaxLength = 3
        Me.TxtTEAM_NO.Name = "TxtTEAM_NO"
        Me.TxtTEAM_NO.Size = New System.Drawing.Size(108, 21)
        Me.TxtTEAM_NO.TabIndex = 199
        Me.TxtTEAM_NO.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(14, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 22)
        Me.Label14.TabIndex = 198
        Me.Label14.Text = "工班号"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(578, 134)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 20)
        Me.Label16.TabIndex = 217
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTEU
        '
        Me.TxtTEU.Enabled = False
        Me.TxtTEU.Location = New System.Drawing.Point(669, 94)
        Me.TxtTEU.MaxLength = 10
        Me.TxtTEU.Name = "TxtTEU"
        Me.TxtTEU.Size = New System.Drawing.Size(44, 21)
        Me.TxtTEU.TabIndex = 248
        Me.TxtTEU.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(631, 94)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 20)
        Me.Label23.TabIndex = 247
        Me.Label23.Text = "TEU："
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTOTAL
        '
        Me.TxtTOTAL.Enabled = False
        Me.TxtTOTAL.Location = New System.Drawing.Point(583, 94)
        Me.TxtTOTAL.MaxLength = 10
        Me.TxtTOTAL.Name = "TxtTOTAL"
        Me.TxtTOTAL.Size = New System.Drawing.Size(44, 21)
        Me.TxtTOTAL.TabIndex = 246
        Me.TxtTOTAL.Text = ""
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(543, 94)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 20)
        Me.Label24.TabIndex = 245
        Me.Label24.Text = "合计："
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt45F
        '
        Me.Txt45F.Enabled = False
        Me.Txt45F.Location = New System.Drawing.Point(497, 94)
        Me.Txt45F.MaxLength = 10
        Me.Txt45F.Name = "Txt45F"
        Me.Txt45F.Size = New System.Drawing.Size(44, 21)
        Me.Txt45F.TabIndex = 244
        Me.Txt45F.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(459, 94)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 20)
        Me.Label21.TabIndex = 243
        Me.Label21.Text = "45F："
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt45E
        '
        Me.Txt45E.Enabled = False
        Me.Txt45E.Location = New System.Drawing.Point(411, 94)
        Me.Txt45E.MaxLength = 10
        Me.Txt45E.Name = "Txt45E"
        Me.Txt45E.Size = New System.Drawing.Size(44, 21)
        Me.Txt45E.TabIndex = 242
        Me.Txt45E.Text = ""
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(373, 94)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 20)
        Me.Label22.TabIndex = 241
        Me.Label22.Text = "45E："
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt40F
        '
        Me.Txt40F.Enabled = False
        Me.Txt40F.Location = New System.Drawing.Point(325, 94)
        Me.Txt40F.MaxLength = 10
        Me.Txt40F.Name = "Txt40F"
        Me.Txt40F.Size = New System.Drawing.Size(44, 21)
        Me.Txt40F.TabIndex = 240
        Me.Txt40F.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(287, 94)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 20)
        Me.Label19.TabIndex = 239
        Me.Label19.Text = "40F："
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt40E
        '
        Me.Txt40E.Enabled = False
        Me.Txt40E.Location = New System.Drawing.Point(239, 94)
        Me.Txt40E.MaxLength = 10
        Me.Txt40E.Name = "Txt40E"
        Me.Txt40E.Size = New System.Drawing.Size(44, 21)
        Me.Txt40E.TabIndex = 238
        Me.Txt40E.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(201, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 20)
        Me.Label20.TabIndex = 237
        Me.Label20.Text = "40E："
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt20F
        '
        Me.Txt20F.Enabled = False
        Me.Txt20F.Location = New System.Drawing.Point(153, 94)
        Me.Txt20F.MaxLength = 10
        Me.Txt20F.Name = "Txt20F"
        Me.Txt20F.Size = New System.Drawing.Size(44, 21)
        Me.Txt20F.TabIndex = 236
        Me.Txt20F.Text = ""
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(115, 94)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 20)
        Me.Label18.TabIndex = 235
        Me.Label18.Text = "20F："
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt20E
        '
        Me.Txt20E.Enabled = False
        Me.Txt20E.Location = New System.Drawing.Point(67, 94)
        Me.Txt20E.MaxLength = 10
        Me.Txt20E.Name = "Txt20E"
        Me.Txt20E.Size = New System.Drawing.Size(44, 21)
        Me.Txt20E.TabIndex = 234
        Me.Txt20E.Text = ""
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(29, 94)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 20)
        Me.Label17.TabIndex = 233
        Me.Label17.Text = "20E："
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRMCON_TALLY_LIST_QUERY
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(742, 444)
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
        Me.Controls.Add(Me.TxtTEAM_NO)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbRELOAD)
        Me.Controls.Add(Me.cbHOLIDAY)
        Me.Controls.Add(Me.CBSEA_AFFAIRE_CARGO)
        Me.Controls.Add(Me.CBNIGHT_MARK)
        Me.Controls.Add(Me.CBANCHORAGE_REMARK)
        Me.Controls.Add(Me.CBMARK)
        Me.Controls.Add(Me.TXTCON_TALLY_LIST_ID)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.C1TALLY)
        Me.Controls.Add(Me.TxtBAY)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNO)
        Me.Controls.Add(Me.Label1)
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
        Me.Name = "FRMCON_TALLY_LIST_QUERY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "理箱单_查看"
        CType(Me.C1TALLY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCON_TALLY_LIST_QUERY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds_agent As New DataSet()
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

        dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk3)
        CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
        CombTALLY_CLERK3.DisplayMember = "name"
        CombTALLY_CLERK3.ValueMember = "work_no"

        dw = Getdata("select * from sship where ship_id='" & Ship_ID & "'", ds_agent)
        If ds_agent.Tables(0).Rows.Count > 0 Then
            agent = IIf(IsDBNull(ds_agent.Tables(0).Rows(0).Item("agent")), "", ds_agent.Tables(0).Rows(0).Item("agent"))
        End If
        dw = Updatedata(sqlda, "select * from con_tally_list where con_tally_list_ID='" & ID & "'", ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            TXTCON_TALLY_LIST_ID.Text = ID
            TxtNO.Text = ds.Tables(0).Rows(0).Item("no")
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
            'Call clerk()

            CombTALLY_CLERK1.Text = ""
            CombTALLY_CLERK2.Text = ""
            CombTALLY_CLERK3.Text = ""
            CombTALLY_CLERK1.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk1"))), "", Trim(ds.Tables(0).Rows(0).Item("tally_clerk1")))
            CombTALLY_CLERK2.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk2"))), "", Trim(ds.Tables(0).Rows(0).Item("tally_clerk2")))
            CombTALLY_CLERK3.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk3"))), "", Trim(ds.Tables(0).Rows(0).Item("tally_clerk3")))

        End If
        'Call GETIMAGE()
        'dw = Getdata("select CON_IMAGE_RECORD_ID,CONTAINER_NO,SIZE_CON,FULLOREMPTY,SEALNO,BAYNO from VIEWCON_TALLY_IMAGE where ship_id='" & Ship_ID & "'", dsimage)
        'C1IMAGE.DataSource = dsimage.Tables(0).DefaultView
        'C1IMAGE.Splits(0).DisplayColumns.Item("SIZE_CON").Visible = False
        'C1IMAGE.Splits(0).DisplayColumns.Item("FULLOREMPTY").Visible = False
        'C1IMAGE.Splits(0).DisplayColumns.Item("CON_IMAGE_RECORD_ID").Visible = False

        'C1IMAGE.Columns.Item("CONTAINER_NO").Caption = "箱号"
        'C1IMAGE.Columns.Item("SEALNO").Caption = "铅封号"
        'C1IMAGE.Columns.Item("BAYNO").Caption = "贝位号"
        'Call SetC1IMAGEWidth()
        'C1IMAGE.Refresh()
        dw = Updatedata(sqlda_sub, "select * from CON_TALLY_DETAIL where CON_TALLY_LIST_ID='" & ID & "'", ds_sub)
        C1TALLY.DataSource = ds_sub.Tables(0).DefaultView
        Me.C1TALLY.Splits(0).DisplayColumns.Item("CON_TALLY_DETAIL_ID").Visible = False
        Me.C1TALLY.Splits(0).DisplayColumns.Item("CON_TALLY_LIST_ID").Visible = False
        Me.C1TALLY.Splits(0).DisplayColumns.Item("OPENBOX").Visible = False
        Me.C1TALLY.Splits(0).DisplayColumns.Item("UnLoad_Mark").Visible = False
        Me.C1TALLY.Splits(0).DisplayColumns.Item("CODE_SHIP_AGENT").Visible = False

        Me.C1TALLY.Columns.Item("BAYNO").Caption = "贝位号"
        Me.C1TALLY.Columns.Item("CONTAINER_NO").Caption = "箱号"
        Me.C1TALLY.Columns.Item("SIZE_CON").Caption = "箱尺寸"
        Me.C1TALLY.Columns.Item("weight").Caption = "重量"

        Me.C1TALLY.Columns.Item("SEALNO").Caption = "铅封号"
        Me.C1TALLY.Columns.Item("SEAL_STATE").Caption = "铅封状态"
        Me.C1TALLY.Columns.Item("FULLOREMPTY").Caption = "重箱"
        'Me.C1TALLY.Columns.Item("OUT_HATCH").Caption = "出舱"
        'Me.C1TALLY.Columns.Item("RELOAD").Caption = "重装"
        Me.C1TALLY.Columns.Item("checkseal").Caption = "铅封查验"
        Me.C1TALLY.Splits(0).DisplayColumns.Item("CONTAINER_NO").Width = 90
        Me.C1TALLY.Splits(0).DisplayColumns.Item("SEALNO").Width = 110
        Me.C1TALLY.Splits(0).DisplayColumns.Item("BAYNO").Width = 60
        Me.C1TALLY.Splits(0).DisplayColumns.Item("FULLOREMPTY").Width = 40
        Me.C1TALLY.Splits(0).DisplayColumns.Item("SIZE_CON").Width = 50
        Me.C1TALLY.Splits(0).DisplayColumns.Item("SEAL_STATE").Width = 70
        Me.C1TALLY.Splits(0).DisplayColumns.Item("checkseal").Width = 100
        Me.C1TALLY.Splits(0).DisplayColumns.Item("weight").Width = 50
        Label16.Text = "共" & ds_sub.Tables(0).Rows.Count & "个"
        Me.C1TALLY.Refresh()

        'dw = Getdata("select * from con_tally ", ds_sub)
        'C1TALLY.DataSource = ds_sub.Tables(0).DefaultView
        'C1TALLY.Splits(0).DisplayColumns.Item("CODE_SHIP_AGENT").Visible = False
        'Me.C1TALLY.Columns.Item("BAYNO").Caption = "贝位号"
        'Me.C1TALLY.Columns.Item("CONTAINER_NO").Caption = "箱号"
        'Me.C1TALLY.Columns.Item("SIZE_CON").Caption = "箱尺寸"
        'Me.C1TALLY.Columns.Item("SEALNO").Caption = "铅封号"
        'Me.C1TALLY.Columns.Item("SEAL_STATE").Caption = "铅封状态"
        'Me.C1TALLY.Columns.Item("FULLOREMPTY").Caption = "空/重箱"
        'Me.C1TALLY.Columns.Item("OUT_HATCH").Caption = "出舱"
        'Me.C1TALLY.Columns.Item("RELOAD").Caption = "重装"

        'Call SetC1TALLYWidth()
        C1TALLY.Refresh()
        Call calcucontain()
        Exit Sub
Err:
        Resume Next
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
    'Private Sub SetC1IMAGEWidth()
    '    Dim j As Integer
    '    For j = 0 To Me.C1IMAGE.Columns.Count - 1
    '        Me.C1IMAGE.Splits(0).DisplayColumns.Item(j).AutoSize()
    '        Me.C1IMAGE.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

    '        If Me.C1IMAGE.Splits(0).DisplayColumns.Item(j).Width < 40 Then
    '            Me.C1IMAGE.Splits(0).DisplayColumns.Item(j).Width = 40
    '        Else
    '            If Me.C1IMAGE.Splits(0).DisplayColumns.Item(j).Width > 240 Then
    '                Me.C1IMAGE.Splits(0).DisplayColumns.Item(j).Width = 240
    '            End If
    '        End If
    '    Next
    'End Sub
    'Private Sub SetC1TALLYWidth()
    '    Dim j As Integer
    '    For j = 0 To Me.C1TALLY.Columns.Count - 1
    '        Me.C1TALLY.Splits(0).DisplayColumns.Item(j).AutoSize()
    '        Me.C1TALLY.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

    '        If Me.C1TALLY.Splits(0).DisplayColumns.Item(j).Width < 40 Then
    '            Me.C1TALLY.Splits(0).DisplayColumns.Item(j).Width = 40
    '        Else
    '            If Me.C1TALLY.Splits(0).DisplayColumns.Item(j).Width > 240 Then
    '                Me.C1TALLY.Splits(0).DisplayColumns.Item(j).Width = 240
    '            End If
    '        End If
    '    Next
    'End Sub
    'Private Sub ITEM_FILL()
    '    Try

    '        Dim i As Integer
    '        Dim dstrue As New DataSet()
    '        dstrue.Reset()
    '        dw = Getdata("select Value,Descri from true", dstrue)
    '        Me.C1TALLY.Columns.Item("OUT_HATCH").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
    '        Me.C1TALLY.Columns.Item("OUT_HATCH").ValueItems.Translate = True
    '        Do While Me.C1TALLY.Columns.Item("OUT_HATCH").ValueItems.Values.Count > 0
    '            Me.C1TALLY.Columns.Item("OUT_HATCH").ValueItems.Values.RemoveAt(0)
    '        Loop
    '        For i = 0 To dstrue.Tables(0).Rows.Count - 1
    '            Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
    '            vi.DisplayValue = dstrue.Tables(0).Rows(i)("Descri")
    '            vi.Value = dstrue.Tables(0).Rows(i)("Value")
    '            Me.C1TALLY.Columns.Item("OUT_HATCH").ValueItems.Values.Add(vi)
    '        Next

    '        Me.C1TALLY.Columns.Item("RELOAD").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
    '        Me.C1TALLY.Columns.Item("RELOAD").ValueItems.Translate = True
    '        Do While Me.C1TALLY.Columns.Item("RELOAD").ValueItems.Values.Count > 0
    '            Me.C1TALLY.Columns.Item("RELOAD").ValueItems.Values.RemoveAt(0)
    '        Loop
    '        For i = 0 To dstrue.Tables(0).Rows.Count - 1
    '            Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
    '            vi.DisplayValue = dstrue.Tables(0).Rows(i)("Descri")
    '            vi.Value = dstrue.Tables(0).Rows(i)("Value")
    '            Me.C1TALLY.Columns.Item("RELOAD").ValueItems.Values.Add(vi)
    '        Next

    '    Catch ex As System.Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub
    Private Sub calcucontain()
        Dim i As Integer
        E20 = 0
        F20 = 0
        E40 = 0
        F40 = 0
        E45 = 0
        F45 = 0
        TOTAL = 0
        TEU = 0
        Try

            If ds_sub.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds_sub.Tables(0).Rows.Count - 1
                    If ds_sub.Tables(0).Rows(i).Item("SIZE_CON") = "20" Then
                        If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "E" Then
                            E20 = E20 + 1
                        End If
                        If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "F" Then
                            F20 = F20 + 1
                        End If
                    End If
                    If ds_sub.Tables(0).Rows(i).Item("SIZE_CON") = "40" Then
                        If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "E" Then
                            E40 = E40 + 1
                        End If
                        If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "F" Then
                            F40 = F40 + 1
                        End If
                    End If
                    If ds_sub.Tables(0).Rows(i).Item("SIZE_CON") = "45" Then
                        If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "E" Then
                            E45 = E45 + 1
                        End If
                        If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "F" Then
                            F45 = F45 + 1
                        End If
                    End If
                Next
            End If
            TOTAL = E20 + F20 + E40 + F40 + E45 + F45
            TEU = E20 + F20 + E40 * 2 + F40 * 2 + E45 * 2.5 + F45 * 2.5
            Txt20E.Text = E20
            Txt20F.Text = F20
            Txt40E.Text = E40
            Txt40F.Text = F40
            Txt45E.Text = E45
            Txt45F.Text = F45
            TxtTOTAL.Text = TOTAL
            TxtTEU.Text = TEU
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1TALLY_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1TALLY.FetchRowStyle
        If Me.C1TALLY.Columns("unload_mark").CellValue(e.Row) = "1" Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        End If
    End Sub
    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

End Class
