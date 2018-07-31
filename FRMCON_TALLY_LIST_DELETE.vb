Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FRMCON_TALLY_LIST_DELETE
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
    Friend WithEvents BTDELETE As System.Windows.Forms.Button
    Friend WithEvents cbRELOAD As System.Windows.Forms.CheckBox
    Friend WithEvents cbHOLIDAY As System.Windows.Forms.CheckBox
    Friend WithEvents CBSEA_AFFAIRE_CARGO As System.Windows.Forms.CheckBox
    Friend WithEvents CBNIGHT_MARK As System.Windows.Forms.CheckBox
    Friend WithEvents CBANCHORAGE_REMARK As System.Windows.Forms.CheckBox
    Friend WithEvents CBMARK As System.Windows.Forms.CheckBox
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
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRMCON_TALLY_LIST_DELETE))
        Me.TXTCON_TALLY_LIST_ID = New System.Windows.Forms.TextBox
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.C1TALLY = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.BTDELETE = New System.Windows.Forms.Button
        Me.cbRELOAD = New System.Windows.Forms.CheckBox
        Me.cbHOLIDAY = New System.Windows.Forms.CheckBox
        Me.CBSEA_AFFAIRE_CARGO = New System.Windows.Forms.CheckBox
        Me.CBNIGHT_MARK = New System.Windows.Forms.CheckBox
        Me.CBANCHORAGE_REMARK = New System.Windows.Forms.CheckBox
        Me.CBMARK = New System.Windows.Forms.CheckBox
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        CType(Me.C1TALLY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTCON_TALLY_LIST_ID
        '
        Me.TXTCON_TALLY_LIST_ID.Location = New System.Drawing.Point(698, 138)
        Me.TXTCON_TALLY_LIST_ID.Name = "TXTCON_TALLY_LIST_ID"
        Me.TXTCON_TALLY_LIST_ID.Size = New System.Drawing.Size(22, 21)
        Me.TXTCON_TALLY_LIST_ID.TabIndex = 184
        Me.TXTCON_TALLY_LIST_ID.Text = ""
        Me.TXTCON_TALLY_LIST_ID.Visible = False
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(602, 390)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(66, 24)
        Me.BTQUIT.TabIndex = 183
        Me.BTQUIT.Text = "取消"
        '
        'C1TALLY
        '
        Me.C1TALLY.AllowAddNew = True
        Me.C1TALLY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1TALLY.FetchRowStyles = True
        Me.C1TALLY.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TALLY.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1TALLY.Location = New System.Drawing.Point(8, 120)
        Me.C1TALLY.Name = "C1TALLY"
        Me.C1TALLY.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TALLY.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TALLY.PreviewInfo.ZoomFactor = 75
        Me.C1TALLY.Size = New System.Drawing.Size(536, 312)
        Me.C1TALLY.TabIndex = 182
        Me.C1TALLY.Text = "C1TrueDBGrid2"
        Me.C1TALLY.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" FetchRowStyles=""True"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><Height>308</Height><CaptionStyle parent=""Style2"" me=" & _
        """Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""Eve" & _
        "nRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterSty" & _
        "le parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><Head" & _
        "ingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow""" & _
        " me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle paren" & _
        "t=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style1" & _
        "1"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""S" & _
        "tyle1"" /><ClientRect>0, 0, 532, 308</ClientRect><BorderSide>0</BorderSide><Borde" & _
        "rStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles" & _
        "><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style par" & _
        "ent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent" & _
        "=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=" & _
        """Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=" & _
        """Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Head" & _
        "ing"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent" & _
        "=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</h" & _
        "orzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><Clien" & _
        "tArea>0, 0, 532, 308</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" />" & _
        "<PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'BTDELETE
        '
        Me.BTDELETE.Location = New System.Drawing.Point(602, 358)
        Me.BTDELETE.Name = "BTDELETE"
        Me.BTDELETE.Size = New System.Drawing.Size(66, 24)
        Me.BTDELETE.TabIndex = 185
        Me.BTDELETE.Text = "确认"
        '
        'cbRELOAD
        '
        Me.cbRELOAD.Enabled = False
        Me.cbRELOAD.Location = New System.Drawing.Point(602, 248)
        Me.cbRELOAD.Name = "cbRELOAD"
        Me.cbRELOAD.Size = New System.Drawing.Size(65, 18)
        Me.cbRELOAD.TabIndex = 191
        Me.cbRELOAD.Text = "重装"
        '
        'cbHOLIDAY
        '
        Me.cbHOLIDAY.Enabled = False
        Me.cbHOLIDAY.Location = New System.Drawing.Point(602, 196)
        Me.cbHOLIDAY.Name = "cbHOLIDAY"
        Me.cbHOLIDAY.Size = New System.Drawing.Size(65, 18)
        Me.cbHOLIDAY.TabIndex = 190
        Me.cbHOLIDAY.Text = "节假日"
        '
        'CBSEA_AFFAIRE_CARGO
        '
        Me.CBSEA_AFFAIRE_CARGO.Enabled = False
        Me.CBSEA_AFFAIRE_CARGO.Location = New System.Drawing.Point(602, 300)
        Me.CBSEA_AFFAIRE_CARGO.Name = "CBSEA_AFFAIRE_CARGO"
        Me.CBSEA_AFFAIRE_CARGO.Size = New System.Drawing.Size(65, 18)
        Me.CBSEA_AFFAIRE_CARGO.TabIndex = 189
        Me.CBSEA_AFFAIRE_CARGO.Text = "海事"
        '
        'CBNIGHT_MARK
        '
        Me.CBNIGHT_MARK.Enabled = False
        Me.CBNIGHT_MARK.Location = New System.Drawing.Point(602, 170)
        Me.CBNIGHT_MARK.Name = "CBNIGHT_MARK"
        Me.CBNIGHT_MARK.Size = New System.Drawing.Size(65, 18)
        Me.CBNIGHT_MARK.TabIndex = 188
        Me.CBNIGHT_MARK.Text = "夜班"
        '
        'CBANCHORAGE_REMARK
        '
        Me.CBANCHORAGE_REMARK.Enabled = False
        Me.CBANCHORAGE_REMARK.Location = New System.Drawing.Point(602, 274)
        Me.CBANCHORAGE_REMARK.Name = "CBANCHORAGE_REMARK"
        Me.CBANCHORAGE_REMARK.Size = New System.Drawing.Size(65, 18)
        Me.CBANCHORAGE_REMARK.TabIndex = 187
        Me.CBANCHORAGE_REMARK.Text = "锚地"
        '
        'CBMARK
        '
        Me.CBMARK.Enabled = False
        Me.CBMARK.Location = New System.Drawing.Point(602, 222)
        Me.CBMARK.Name = "CBMARK"
        Me.CBMARK.Size = New System.Drawing.Size(65, 18)
        Me.CBMARK.TabIndex = 186
        Me.CBMARK.Text = "出舱"
        '
        'TxtBAY
        '
        Me.TxtBAY.Enabled = False
        Me.TxtBAY.Location = New System.Drawing.Point(258, 34)
        Me.TxtBAY.MaxLength = 20
        Me.TxtBAY.Name = "TxtBAY"
        Me.TxtBAY.Size = New System.Drawing.Size(108, 21)
        Me.TxtBAY.TabIndex = 213
        Me.TxtBAY.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(186, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 212
        Me.Label3.Text = "舱/排位"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNO
        '
        Me.TxtNO.Enabled = False
        Me.TxtNO.Location = New System.Drawing.Point(72, 34)
        Me.TxtNO.MaxLength = 10
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(108, 21)
        Me.TxtNO.TabIndex = 211
        Me.TxtNO.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 22)
        Me.Label1.TabIndex = 210
        Me.Label1.Text = "编号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCROSS_PERSON
        '
        Me.TxtCROSS_PERSON.Enabled = False
        Me.TxtCROSS_PERSON.Location = New System.Drawing.Point(258, 58)
        Me.TxtCROSS_PERSON.MaxLength = 10
        Me.TxtCROSS_PERSON.Name = "TxtCROSS_PERSON"
        Me.TxtCROSS_PERSON.Size = New System.Drawing.Size(108, 21)
        Me.TxtCROSS_PERSON.TabIndex = 209
        Me.TxtCROSS_PERSON.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(186, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 22)
        Me.Label12.TabIndex = 208
        Me.Label12.Text = "交接人员"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombTALLY_CLERK3
        '
        Me.CombTALLY_CLERK3.Enabled = False
        Me.CombTALLY_CLERK3.Location = New System.Drawing.Point(626, 60)
        Me.CombTALLY_CLERK3.Name = "CombTALLY_CLERK3"
        Me.CombTALLY_CLERK3.Size = New System.Drawing.Size(108, 20)
        Me.CombTALLY_CLERK3.TabIndex = 207
        '
        'CombTALLY_CLERK2
        '
        Me.CombTALLY_CLERK2.Enabled = False
        Me.CombTALLY_CLERK2.Location = New System.Drawing.Point(626, 34)
        Me.CombTALLY_CLERK2.Name = "CombTALLY_CLERK2"
        Me.CombTALLY_CLERK2.Size = New System.Drawing.Size(108, 20)
        Me.CombTALLY_CLERK2.TabIndex = 206
        '
        'CombTALLY_CLERK1
        '
        Me.CombTALLY_CLERK1.Enabled = False
        Me.CombTALLY_CLERK1.Location = New System.Drawing.Point(626, 6)
        Me.CombTALLY_CLERK1.Name = "CombTALLY_CLERK1"
        Me.CombTALLY_CLERK1.Size = New System.Drawing.Size(108, 20)
        Me.CombTALLY_CLERK1.TabIndex = 205
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(554, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 22)
        Me.Label9.TabIndex = 204
        Me.Label9.Text = "理货员3"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(554, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 22)
        Me.Label8.TabIndex = 203
        Me.Label8.Text = "理货员2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(554, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 22)
        Me.Label7.TabIndex = 202
        Me.Label7.Text = "理货员1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombBERTHNO
        '
        Me.CombBERTHNO.Enabled = False
        Me.CombBERTHNO.Location = New System.Drawing.Point(72, 60)
        Me.CombBERTHNO.Name = "CombBERTHNO"
        Me.CombBERTHNO.Size = New System.Drawing.Size(108, 20)
        Me.CombBERTHNO.TabIndex = 201
        '
        'TxtYARD_NO
        '
        Me.TxtYARD_NO.Enabled = False
        Me.TxtYARD_NO.Location = New System.Drawing.Point(258, 8)
        Me.TxtYARD_NO.MaxLength = 20
        Me.TxtYARD_NO.Name = "TxtYARD_NO"
        Me.TxtYARD_NO.Size = New System.Drawing.Size(108, 21)
        Me.TxtYARD_NO.TabIndex = 200
        Me.TxtYARD_NO.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(186, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 22)
        Me.Label5.TabIndex = 199
        Me.Label5.Text = "库场车驳号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 22)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "泊位号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTime_from
        '
        Me.TxtTime_from.Enabled = False
        Me.TxtTime_from.Location = New System.Drawing.Point(442, 32)
        Me.TxtTime_from.MaxLength = 4
        Me.TxtTime_from.Name = "TxtTime_from"
        Me.TxtTime_from.Size = New System.Drawing.Size(108, 21)
        Me.TxtTime_from.TabIndex = 197
        Me.TxtTime_from.Text = ""
        '
        'Txttime_to
        '
        Me.Txttime_to.Enabled = False
        Me.Txttime_to.Location = New System.Drawing.Point(442, 58)
        Me.Txttime_to.MaxLength = 4
        Me.Txttime_to.Name = "Txttime_to"
        Me.Txttime_to.Size = New System.Drawing.Size(108, 21)
        Me.Txttime_to.TabIndex = 196
        Me.Txttime_to.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(370, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 22)
        Me.Label13.TabIndex = 195
        Me.Label13.Text = "作业日期"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPdate
        '
        Me.DTPdate.CustomFormat = "yyyy-MM-dd"
        Me.DTPdate.Enabled = False
        Me.DTPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPdate.Location = New System.Drawing.Point(442, 6)
        Me.DTPdate.Name = "DTPdate"
        Me.DTPdate.Size = New System.Drawing.Size(108, 21)
        Me.DTPdate.TabIndex = 194
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(370, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 22)
        Me.Label11.TabIndex = 193
        Me.Label11.Text = "作业止时间"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(370, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 192
        Me.Label6.Text = "作业起时间"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTEAM_NO
        '
        Me.TxtTEAM_NO.Enabled = False
        Me.TxtTEAM_NO.Location = New System.Drawing.Point(72, 8)
        Me.TxtTEAM_NO.MaxLength = 3
        Me.TxtTEAM_NO.Name = "TxtTEAM_NO"
        Me.TxtTEAM_NO.Size = New System.Drawing.Size(108, 21)
        Me.TxtTEAM_NO.TabIndex = 215
        Me.TxtTEAM_NO.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(16, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 22)
        Me.Label14.TabIndex = 214
        Me.Label14.Text = "工班号"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(578, 132)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 20)
        Me.Label16.TabIndex = 216
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTEU
        '
        Me.TxtTEU.Enabled = False
        Me.TxtTEU.Location = New System.Drawing.Point(667, 90)
        Me.TxtTEU.MaxLength = 10
        Me.TxtTEU.Name = "TxtTEU"
        Me.TxtTEU.Size = New System.Drawing.Size(44, 21)
        Me.TxtTEU.TabIndex = 232
        Me.TxtTEU.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(629, 90)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 20)
        Me.Label23.TabIndex = 231
        Me.Label23.Text = "TEU："
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTOTAL
        '
        Me.TxtTOTAL.Enabled = False
        Me.TxtTOTAL.Location = New System.Drawing.Point(581, 90)
        Me.TxtTOTAL.MaxLength = 10
        Me.TxtTOTAL.Name = "TxtTOTAL"
        Me.TxtTOTAL.Size = New System.Drawing.Size(44, 21)
        Me.TxtTOTAL.TabIndex = 230
        Me.TxtTOTAL.Text = ""
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(540, 90)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 20)
        Me.Label24.TabIndex = 229
        Me.Label24.Text = "合计："
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt45F
        '
        Me.Txt45F.Enabled = False
        Me.Txt45F.Location = New System.Drawing.Point(495, 90)
        Me.Txt45F.MaxLength = 10
        Me.Txt45F.Name = "Txt45F"
        Me.Txt45F.Size = New System.Drawing.Size(44, 21)
        Me.Txt45F.TabIndex = 228
        Me.Txt45F.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(457, 90)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 20)
        Me.Label21.TabIndex = 227
        Me.Label21.Text = "45F："
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt45E
        '
        Me.Txt45E.Enabled = False
        Me.Txt45E.Location = New System.Drawing.Point(409, 90)
        Me.Txt45E.MaxLength = 10
        Me.Txt45E.Name = "Txt45E"
        Me.Txt45E.Size = New System.Drawing.Size(44, 21)
        Me.Txt45E.TabIndex = 226
        Me.Txt45E.Text = ""
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(371, 90)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 20)
        Me.Label22.TabIndex = 225
        Me.Label22.Text = "45E："
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt40F
        '
        Me.Txt40F.Enabled = False
        Me.Txt40F.Location = New System.Drawing.Point(323, 90)
        Me.Txt40F.MaxLength = 10
        Me.Txt40F.Name = "Txt40F"
        Me.Txt40F.Size = New System.Drawing.Size(44, 21)
        Me.Txt40F.TabIndex = 224
        Me.Txt40F.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(285, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 20)
        Me.Label19.TabIndex = 223
        Me.Label19.Text = "40F："
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt40E
        '
        Me.Txt40E.Enabled = False
        Me.Txt40E.Location = New System.Drawing.Point(237, 90)
        Me.Txt40E.MaxLength = 10
        Me.Txt40E.Name = "Txt40E"
        Me.Txt40E.Size = New System.Drawing.Size(44, 21)
        Me.Txt40E.TabIndex = 222
        Me.Txt40E.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(199, 90)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 20)
        Me.Label20.TabIndex = 221
        Me.Label20.Text = "40E："
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt20F
        '
        Me.Txt20F.Enabled = False
        Me.Txt20F.Location = New System.Drawing.Point(151, 90)
        Me.Txt20F.MaxLength = 10
        Me.Txt20F.Name = "Txt20F"
        Me.Txt20F.Size = New System.Drawing.Size(44, 21)
        Me.Txt20F.TabIndex = 220
        Me.Txt20F.Text = ""
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(113, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 20)
        Me.Label18.TabIndex = 219
        Me.Label18.Text = "20F："
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt20E
        '
        Me.Txt20E.Enabled = False
        Me.Txt20E.Location = New System.Drawing.Point(65, 90)
        Me.Txt20E.MaxLength = 10
        Me.Txt20E.Name = "Txt20E"
        Me.Txt20E.Size = New System.Drawing.Size(44, 21)
        Me.Txt20E.TabIndex = 218
        Me.Txt20E.Text = ""
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(27, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 20)
        Me.Label17.TabIndex = 217
        Me.Label17.Text = "20E："
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(602, 322)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(114, 18)
        Me.CheckBox1.TabIndex = 189
        Me.CheckBox1.Text = "不清除完船信息"
        '
        'FRMCON_TALLY_LIST_DELETE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(738, 440)
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
        Me.Controls.Add(Me.cbRELOAD)
        Me.Controls.Add(Me.cbHOLIDAY)
        Me.Controls.Add(Me.CBSEA_AFFAIRE_CARGO)
        Me.Controls.Add(Me.CBNIGHT_MARK)
        Me.Controls.Add(Me.CBANCHORAGE_REMARK)
        Me.Controls.Add(Me.CBMARK)
        Me.Controls.Add(Me.BTDELETE)
        Me.Controls.Add(Me.TXTCON_TALLY_LIST_ID)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.C1TALLY)
        Me.Controls.Add(Me.CheckBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMCON_TALLY_LIST_DELETE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "理箱单_删除"
        CType(Me.C1TALLY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCON_TALLY_LIST_DELETE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Call clerk()

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
        Me.C1TALLY.Columns.Item("FULLOREMPTY").Caption = "空/重箱"
        'Me.C1TALLY.Columns.Item("OUT_HATCH").Caption = "出舱"
        'Me.C1TALLY.Columns.Item("RELOAD").Caption = "重装"
        Me.C1TALLY.Columns.Item("CHECKSEAL").Caption = "铅封查验"
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
    'Private Sub GETIMAGE()
    '    Try
    '        dw = Getdata("select CON_IMAGE_ID,CONTAINER_NO,SIZE_CON,FULLOREMPTY,SEALNO,BAYNO from VIEWCON_TALLY_IMAGE where ship_id='" & Ship_ID & "'", dsimage)
    '        C1IMAGE.DataSource = dsimage.Tables(0).DefaultView
    '        C1IMAGE.Splits(0).DisplayColumns.Item("SIZE_CON").Visible = False
    '        C1IMAGE.Splits(0).DisplayColumns.Item("FULLOREMPTY").Visible = False
    '        C1IMAGE.Splits(0).DisplayColumns.Item("CON_IMAGE_ID").Visible = False

    '        C1IMAGE.Columns.Item("CONTAINER_NO").Caption = "箱号"
    '        C1IMAGE.Columns.Item("SEALNO").Caption = "铅封号"
    '        C1IMAGE.Columns.Item("BAYNO").Caption = "贝位号"
    '        Call SetC1IMAGEWidth()
    '        C1IMAGE.Refresh()

    '    Catch ex As System.Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Private Sub C1TALLY_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1TALLY.FetchRowStyle
        If Me.C1TALLY.Columns("unload_mark").CellValue(e.Row) = "1" Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        End If
    End Sub
    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub
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

    Private Sub BTDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTDELETE.Click
        Dim i As Integer
        Dim ds_update As New DataSet
        Try
            If MsgBox("确认要删除吗？这将同时删除本条理箱单和理箱单明细表的内容！", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "删除", "con_tally_list", ID, "con_tally_list_id")
                '写入操作日志文件
                Dim st_log As String
                Dim Address() As System.Net.IPAddress
                Dim a As Integer
                Dim myname As String
                Dim ip As String
                Address = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList
                myname = System.Net.Dns.GetHostName().ToString()
                For a = 0 To UBound(Address)
                    ip = ip & Chr(13) & Address(a).ToString()
                Next
                st_log = String.Format("insert into con_info(worktype, shipid, cntr, bayno, truckno, ioport, workno, instime, message, dx) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}') ", "rollback", Ship_ID, ds_sub.Tables(0).Rows(i).Item("container_no"), " ", " ", " ", G_WorkNo, Now.ToString(), "rollback_ok" + "." + myname + "." + ip, " ")
                ExecSql(st_log)

                If CheckBox1.Checked = False Then
                    For i = 0 To ds_sub.Tables(0).Rows.Count - 1
                        dw = Getdata("select * from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and container_no='" & ds_sub.Tables(0).Rows(i).Item("container_no") & "'", ds_update)
                        If ds_update.Tables(0).Rows.Count > 0 Then
                            ExecSql("update CON_HATCH_RECORD set unload_mark='0' where CON_HATCH_RECORD_ID='" & ds_update.Tables(0).Rows(0).Item("CON_HATCH_RECORD_ID") & "'")
                        End If
                        ds_update.Reset()
                        dw = Getdata("select * from con_image where ship_id='" & Ship_ID & "' and container_no='" & ds_sub.Tables(0).Rows(i).Item("container_no") & "'", ds_update)
                        If ds_update.Tables(0).Rows.Count > 0 Then
                            ExecSql("update con_image set unload_mark='0' where con_image_id='" & ds_update.Tables(0).Rows(0).Item("con_image_id") & "'")
                        End If
                    Next
                End If
                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)
                ExecSql("delete from con_tally_detail where con_tally_list_id=" & ID)
                Call BTQUIT_Click(sender, e)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
