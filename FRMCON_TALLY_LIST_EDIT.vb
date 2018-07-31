Imports TALLY.DBControl
Imports Microsoft.VisualBasic

Public Class FRMCON_TALLY_LIST_EDIT
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
    Friend WithEvents BtADD As System.Windows.Forms.Button
    Friend WithEvents BtDELETE As System.Windows.Forms.Button
    Friend WithEvents BtADDALL As System.Windows.Forms.Button
    Friend WithEvents BtDELETEALL As System.Windows.Forms.Button
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents C1IMAGE As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cbRELOAD As System.Windows.Forms.CheckBox
    Friend WithEvents TxtBAY As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbHOLIDAY As System.Windows.Forms.CheckBox
    Friend WithEvents CBSEA_AFFAIRE_CARGO As System.Windows.Forms.CheckBox
    Friend WithEvents CBNIGHT_MARK As System.Windows.Forms.CheckBox
    Friend WithEvents CBANCHORAGE_REMARK As System.Windows.Forms.CheckBox
    Friend WithEvents CBMARK As System.Windows.Forms.CheckBox
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
    Friend WithEvents TxtCONTAINERNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtseachbay As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RBROW As System.Windows.Forms.RadioButton
    Friend WithEvents RBCOL As System.Windows.Forms.RadioButton
    Friend WithEvents TxtTEAM_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents C1TALLY As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt3 As System.Windows.Forms.TextBox
    Friend WithEvents Txt4 As System.Windows.Forms.TextBox
    Friend WithEvents BtADD_CONTAINER As System.Windows.Forms.Button
    Friend WithEvents Txt58F As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Txt58E As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRMCON_TALLY_LIST_EDIT))
        Me.TXTCON_TALLY_LIST_ID = New System.Windows.Forms.TextBox
        Me.BtADD = New System.Windows.Forms.Button
        Me.BtDELETE = New System.Windows.Forms.Button
        Me.BtADDALL = New System.Windows.Forms.Button
        Me.BtDELETEALL = New System.Windows.Forms.Button
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.BTOK = New System.Windows.Forms.Button
        Me.C1IMAGE = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cbRELOAD = New System.Windows.Forms.CheckBox
        Me.TxtBAY = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtNO = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbHOLIDAY = New System.Windows.Forms.CheckBox
        Me.CBSEA_AFFAIRE_CARGO = New System.Windows.Forms.CheckBox
        Me.CBNIGHT_MARK = New System.Windows.Forms.CheckBox
        Me.CBANCHORAGE_REMARK = New System.Windows.Forms.CheckBox
        Me.CBMARK = New System.Windows.Forms.CheckBox
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
        Me.TxtCONTAINERNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txtseachbay = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.RBROW = New System.Windows.Forms.RadioButton
        Me.RBCOL = New System.Windows.Forms.RadioButton
        Me.TxtTEAM_NO = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
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
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.C1TALLY = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Txt1 = New System.Windows.Forms.TextBox
        Me.Txt2 = New System.Windows.Forms.TextBox
        Me.Txt3 = New System.Windows.Forms.TextBox
        Me.Txt4 = New System.Windows.Forms.TextBox
        Me.BtADD_CONTAINER = New System.Windows.Forms.Button
        Me.Txt58F = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Txt58E = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        CType(Me.C1IMAGE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TALLY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTCON_TALLY_LIST_ID
        '
        Me.TXTCON_TALLY_LIST_ID.Location = New System.Drawing.Point(575, 94)
        Me.TXTCON_TALLY_LIST_ID.Name = "TXTCON_TALLY_LIST_ID"
        Me.TXTCON_TALLY_LIST_ID.Size = New System.Drawing.Size(24, 21)
        Me.TXTCON_TALLY_LIST_ID.TabIndex = 118
        Me.TXTCON_TALLY_LIST_ID.Text = ""
        Me.TXTCON_TALLY_LIST_ID.Visible = False
        '
        'BtADD
        '
        Me.BtADD.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtADD.Location = New System.Drawing.Point(258, 280)
        Me.BtADD.Name = "BtADD"
        Me.BtADD.Size = New System.Drawing.Size(26, 22)
        Me.BtADD.TabIndex = 117
        Me.BtADD.Text = ">"
        '
        'BtDELETE
        '
        Me.BtDELETE.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtDELETE.Location = New System.Drawing.Point(258, 318)
        Me.BtDELETE.Name = "BtDELETE"
        Me.BtDELETE.Size = New System.Drawing.Size(26, 22)
        Me.BtDELETE.TabIndex = 116
        Me.BtDELETE.Text = "<"
        '
        'BtADDALL
        '
        Me.BtADDALL.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtADDALL.Location = New System.Drawing.Point(258, 356)
        Me.BtADDALL.Name = "BtADDALL"
        Me.BtADDALL.Size = New System.Drawing.Size(26, 22)
        Me.BtADDALL.TabIndex = 115
        Me.BtADDALL.Text = ">>"
        '
        'BtDELETEALL
        '
        Me.BtDELETEALL.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtDELETEALL.Location = New System.Drawing.Point(258, 394)
        Me.BtDELETEALL.Name = "BtDELETEALL"
        Me.BtDELETEALL.Size = New System.Drawing.Size(26, 22)
        Me.BtDELETEALL.TabIndex = 114
        Me.BtDELETEALL.Text = "<<"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(392, 554)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 112
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(298, 554)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 111
        Me.BTOK.Text = "确认"
        '
        'C1IMAGE
        '
        Me.C1IMAGE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1IMAGE.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1IMAGE.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1IMAGE.Location = New System.Drawing.Point(2, 178)
        Me.C1IMAGE.Name = "C1IMAGE"
        Me.C1IMAGE.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1IMAGE.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1IMAGE.PreviewInfo.ZoomFactor = 75
        Me.C1IMAGE.Size = New System.Drawing.Size(251, 366)
        Me.C1IMAGE.TabIndex = 109
        Me.C1IMAGE.Text = "C1TrueDBGrid1"
        Me.C1IMAGE.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>362</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 247, 362</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 247, 362</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'cbRELOAD
        '
        Me.cbRELOAD.Location = New System.Drawing.Point(365, 94)
        Me.cbRELOAD.Name = "cbRELOAD"
        Me.cbRELOAD.Size = New System.Drawing.Size(65, 18)
        Me.cbRELOAD.TabIndex = 146
        Me.cbRELOAD.Text = "重装"
        '
        'TxtBAY
        '
        Me.TxtBAY.Location = New System.Drawing.Point(272, 34)
        Me.TxtBAY.MaxLength = 20
        Me.TxtBAY.Name = "TxtBAY"
        Me.TxtBAY.Size = New System.Drawing.Size(108, 21)
        Me.TxtBAY.TabIndex = 145
        Me.TxtBAY.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(200, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "舱/排位"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNO
        '
        Me.TxtNO.Location = New System.Drawing.Point(88, 34)
        Me.TxtNO.MaxLength = 12
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(108, 21)
        Me.TxtNO.TabIndex = 143
        Me.TxtNO.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "编号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbHOLIDAY
        '
        Me.cbHOLIDAY.Location = New System.Drawing.Point(227, 94)
        Me.cbHOLIDAY.Name = "cbHOLIDAY"
        Me.cbHOLIDAY.Size = New System.Drawing.Size(65, 18)
        Me.cbHOLIDAY.TabIndex = 141
        Me.cbHOLIDAY.Text = "节假日"
        '
        'CBSEA_AFFAIRE_CARGO
        '
        Me.CBSEA_AFFAIRE_CARGO.Location = New System.Drawing.Point(501, 94)
        Me.CBSEA_AFFAIRE_CARGO.Name = "CBSEA_AFFAIRE_CARGO"
        Me.CBSEA_AFFAIRE_CARGO.Size = New System.Drawing.Size(65, 18)
        Me.CBSEA_AFFAIRE_CARGO.TabIndex = 140
        Me.CBSEA_AFFAIRE_CARGO.Text = "海事"
        '
        'CBNIGHT_MARK
        '
        Me.CBNIGHT_MARK.Location = New System.Drawing.Point(159, 94)
        Me.CBNIGHT_MARK.Name = "CBNIGHT_MARK"
        Me.CBNIGHT_MARK.Size = New System.Drawing.Size(64, 18)
        Me.CBNIGHT_MARK.TabIndex = 139
        Me.CBNIGHT_MARK.Text = "夜班"
        '
        'CBANCHORAGE_REMARK
        '
        Me.CBANCHORAGE_REMARK.Location = New System.Drawing.Point(433, 94)
        Me.CBANCHORAGE_REMARK.Name = "CBANCHORAGE_REMARK"
        Me.CBANCHORAGE_REMARK.Size = New System.Drawing.Size(64, 18)
        Me.CBANCHORAGE_REMARK.TabIndex = 138
        Me.CBANCHORAGE_REMARK.Text = "锚地"
        '
        'CBMARK
        '
        Me.CBMARK.Location = New System.Drawing.Point(297, 94)
        Me.CBMARK.Name = "CBMARK"
        Me.CBMARK.Size = New System.Drawing.Size(64, 18)
        Me.CBMARK.TabIndex = 137
        Me.CBMARK.Text = "出舱"
        '
        'TxtCROSS_PERSON
        '
        Me.TxtCROSS_PERSON.Location = New System.Drawing.Point(272, 60)
        Me.TxtCROSS_PERSON.MaxLength = 10
        Me.TxtCROSS_PERSON.Name = "TxtCROSS_PERSON"
        Me.TxtCROSS_PERSON.Size = New System.Drawing.Size(108, 21)
        Me.TxtCROSS_PERSON.TabIndex = 136
        Me.TxtCROSS_PERSON.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(200, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 22)
        Me.Label12.TabIndex = 135
        Me.Label12.Text = "交接人员"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombTALLY_CLERK3
        '
        Me.CombTALLY_CLERK3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CombTALLY_CLERK3.Location = New System.Drawing.Point(643, 60)
        Me.CombTALLY_CLERK3.Name = "CombTALLY_CLERK3"
        Me.CombTALLY_CLERK3.Size = New System.Drawing.Size(100, 20)
        Me.CombTALLY_CLERK3.TabIndex = 134
        '
        'CombTALLY_CLERK2
        '
        Me.CombTALLY_CLERK2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CombTALLY_CLERK2.Location = New System.Drawing.Point(643, 34)
        Me.CombTALLY_CLERK2.Name = "CombTALLY_CLERK2"
        Me.CombTALLY_CLERK2.Size = New System.Drawing.Size(100, 20)
        Me.CombTALLY_CLERK2.TabIndex = 133
        '
        'CombTALLY_CLERK1
        '
        Me.CombTALLY_CLERK1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CombTALLY_CLERK1.Location = New System.Drawing.Point(643, 8)
        Me.CombTALLY_CLERK1.Name = "CombTALLY_CLERK1"
        Me.CombTALLY_CLERK1.Size = New System.Drawing.Size(100, 20)
        Me.CombTALLY_CLERK1.TabIndex = 132
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(571, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 22)
        Me.Label9.TabIndex = 131
        Me.Label9.Text = "理货员3"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(571, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 22)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "理货员2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(571, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 22)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "理货员1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombBERTHNO
        '
        Me.CombBERTHNO.Location = New System.Drawing.Point(88, 60)
        Me.CombBERTHNO.Name = "CombBERTHNO"
        Me.CombBERTHNO.Size = New System.Drawing.Size(108, 20)
        Me.CombBERTHNO.TabIndex = 128
        '
        'TxtYARD_NO
        '
        Me.TxtYARD_NO.Location = New System.Drawing.Point(272, 8)
        Me.TxtYARD_NO.MaxLength = 20
        Me.TxtYARD_NO.Name = "TxtYARD_NO"
        Me.TxtYARD_NO.Size = New System.Drawing.Size(108, 21)
        Me.TxtYARD_NO.TabIndex = 127
        Me.TxtYARD_NO.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(200, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 22)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "库场车驳号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 22)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "泊位号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTime_from
        '
        Me.TxtTime_from.Location = New System.Drawing.Point(457, 34)
        Me.TxtTime_from.MaxLength = 4
        Me.TxtTime_from.Name = "TxtTime_from"
        Me.TxtTime_from.Size = New System.Drawing.Size(108, 21)
        Me.TxtTime_from.TabIndex = 124
        Me.TxtTime_from.Text = ""
        '
        'Txttime_to
        '
        Me.Txttime_to.Location = New System.Drawing.Point(457, 60)
        Me.Txttime_to.MaxLength = 4
        Me.Txttime_to.Name = "Txttime_to"
        Me.Txttime_to.Size = New System.Drawing.Size(108, 21)
        Me.Txttime_to.TabIndex = 123
        Me.Txttime_to.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(385, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 22)
        Me.Label13.TabIndex = 122
        Me.Label13.Text = "作业日期"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTPdate
        '
        Me.DTPdate.CustomFormat = "yyyy-MM-dd"
        Me.DTPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPdate.Location = New System.Drawing.Point(457, 8)
        Me.DTPdate.Name = "DTPdate"
        Me.DTPdate.Size = New System.Drawing.Size(108, 21)
        Me.DTPdate.TabIndex = 121
        Me.DTPdate.Value = New Date(2004, 4, 28, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(385, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 22)
        Me.Label11.TabIndex = 120
        Me.Label11.Text = "作业止时间"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(385, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "作业起时间"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCONTAINERNO
        '
        Me.TxtCONTAINERNO.Location = New System.Drawing.Point(122, 150)
        Me.TxtCONTAINERNO.MaxLength = 20
        Me.TxtCONTAINERNO.Name = "TxtCONTAINERNO"
        Me.TxtCONTAINERNO.Size = New System.Drawing.Size(74, 21)
        Me.TxtCONTAINERNO.TabIndex = 148
        Me.TxtCONTAINERNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(66, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 22)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "查找箱号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtseachbay
        '
        Me.Txtseachbay.Location = New System.Drawing.Point(36, 150)
        Me.Txtseachbay.MaxLength = 2
        Me.Txtseachbay.Name = "Txtseachbay"
        Me.Txtseachbay.Size = New System.Drawing.Size(28, 21)
        Me.Txtseachbay.TabIndex = 150
        Me.Txtseachbay.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(4, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 22)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "贝号"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RBROW
        '
        Me.RBROW.Location = New System.Drawing.Point(248, 152)
        Me.RBROW.Name = "RBROW"
        Me.RBROW.Size = New System.Drawing.Size(48, 20)
        Me.RBROW.TabIndex = 167
        Me.RBROW.Text = "按层"
        '
        'RBCOL
        '
        Me.RBCOL.Location = New System.Drawing.Point(198, 152)
        Me.RBCOL.Name = "RBCOL"
        Me.RBCOL.Size = New System.Drawing.Size(48, 20)
        Me.RBCOL.TabIndex = 166
        Me.RBCOL.Text = "按列"
        '
        'TxtTEAM_NO
        '
        Me.TxtTEAM_NO.Location = New System.Drawing.Point(88, 8)
        Me.TxtTEAM_NO.MaxLength = 2
        Me.TxtTEAM_NO.Name = "TxtTEAM_NO"
        Me.TxtTEAM_NO.Size = New System.Drawing.Size(108, 21)
        Me.TxtTEAM_NO.TabIndex = 169
        Me.TxtTEAM_NO.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(16, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 22)
        Me.Label14.TabIndex = 168
        Me.Label14.Text = "工班号"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTEU
        '
        Me.TxtTEU.Location = New System.Drawing.Point(614, 120)
        Me.TxtTEU.MaxLength = 10
        Me.TxtTEU.Name = "TxtTEU"
        Me.TxtTEU.Size = New System.Drawing.Size(25, 21)
        Me.TxtTEU.TabIndex = 201
        Me.TxtTEU.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(578, 120)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 22)
        Me.Label23.TabIndex = 200
        Me.Label23.Text = "TEU："
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTOTAL
        '
        Me.TxtTOTAL.Location = New System.Drawing.Point(552, 120)
        Me.TxtTOTAL.MaxLength = 10
        Me.TxtTOTAL.Name = "TxtTOTAL"
        Me.TxtTOTAL.Size = New System.Drawing.Size(25, 21)
        Me.TxtTOTAL.TabIndex = 199
        Me.TxtTOTAL.Text = ""
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(510, 120)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 22)
        Me.Label24.TabIndex = 198
        Me.Label24.Text = "合计："
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt45F
        '
        Me.Txt45F.Location = New System.Drawing.Point(356, 120)
        Me.Txt45F.MaxLength = 10
        Me.Txt45F.Name = "Txt45F"
        Me.Txt45F.Size = New System.Drawing.Size(25, 21)
        Me.Txt45F.TabIndex = 197
        Me.Txt45F.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(320, 120)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 22)
        Me.Label21.TabIndex = 196
        Me.Label21.Text = "45F："
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt45E
        '
        Me.Txt45E.Location = New System.Drawing.Point(296, 120)
        Me.Txt45E.MaxLength = 10
        Me.Txt45E.Name = "Txt45E"
        Me.Txt45E.Size = New System.Drawing.Size(25, 21)
        Me.Txt45E.TabIndex = 195
        Me.Txt45E.Text = ""
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(260, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 22)
        Me.Label22.TabIndex = 194
        Me.Label22.Text = "45E："
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt40F
        '
        Me.Txt40F.Location = New System.Drawing.Point(234, 120)
        Me.Txt40F.MaxLength = 10
        Me.Txt40F.Name = "Txt40F"
        Me.Txt40F.Size = New System.Drawing.Size(25, 21)
        Me.Txt40F.TabIndex = 193
        Me.Txt40F.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(198, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 22)
        Me.Label19.TabIndex = 192
        Me.Label19.Text = "40F："
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt40E
        '
        Me.Txt40E.Location = New System.Drawing.Point(174, 120)
        Me.Txt40E.MaxLength = 10
        Me.Txt40E.Name = "Txt40E"
        Me.Txt40E.Size = New System.Drawing.Size(25, 21)
        Me.Txt40E.TabIndex = 191
        Me.Txt40E.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(138, 120)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 22)
        Me.Label20.TabIndex = 190
        Me.Label20.Text = "40E："
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt20F
        '
        Me.Txt20F.Location = New System.Drawing.Point(112, 120)
        Me.Txt20F.MaxLength = 10
        Me.Txt20F.Name = "Txt20F"
        Me.Txt20F.Size = New System.Drawing.Size(25, 21)
        Me.Txt20F.TabIndex = 189
        Me.Txt20F.Text = ""
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(76, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 22)
        Me.Label18.TabIndex = 188
        Me.Label18.Text = "20F："
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt20E
        '
        Me.Txt20E.Location = New System.Drawing.Point(52, 120)
        Me.Txt20E.MaxLength = 10
        Me.Txt20E.Name = "Txt20E"
        Me.Txt20E.Size = New System.Drawing.Size(25, 21)
        Me.Txt20E.TabIndex = 187
        Me.Txt20E.Text = ""
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(16, 120)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 22)
        Me.Label17.TabIndex = 186
        Me.Label17.Text = "20E："
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(520, 550)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 20)
        Me.Label16.TabIndex = 203
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(70, 550)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 20)
        Me.Label15.TabIndex = 202
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C1TALLY
        '
        Me.C1TALLY.AllowAddNew = True
        Me.C1TALLY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1TALLY.FetchRowStyles = True
        Me.C1TALLY.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TALLY.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1TALLY.Location = New System.Drawing.Point(290, 178)
        Me.C1TALLY.Name = "C1TALLY"
        Me.C1TALLY.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TALLY.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TALLY.PreviewInfo.ZoomFactor = 75
        Me.C1TALLY.Size = New System.Drawing.Size(462, 364)
        Me.C1TALLY.TabIndex = 204
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
        " HorizontalScrollGroup=""1""><Height>360</Height><CaptionStyle parent=""Style2"" me=" & _
        """Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""Eve" & _
        "nRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterSty" & _
        "le parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><Head" & _
        "ingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow""" & _
        " me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle paren" & _
        "t=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style1" & _
        "1"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""S" & _
        "tyle1"" /><ClientRect>0, 0, 458, 360</ClientRect><BorderSide>0</BorderSide><Borde" & _
        "rStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles" & _
        "><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style par" & _
        "ent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent" & _
        "=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=" & _
        """Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=" & _
        """Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Head" & _
        "ing"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent" & _
        "=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</h" & _
        "orzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><Clien" & _
        "tArea>0, 0, 458, 360</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" />" & _
        "<PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(370, 152)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(48, 21)
        Me.Txt1.TabIndex = 205
        Me.Txt1.Text = ""
        Me.Txt1.Visible = False
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(418, 152)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(48, 21)
        Me.Txt2.TabIndex = 206
        Me.Txt2.Text = ""
        Me.Txt2.Visible = False
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(466, 152)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(48, 21)
        Me.Txt3.TabIndex = 207
        Me.Txt3.Text = ""
        Me.Txt3.Visible = False
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(514, 152)
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(48, 21)
        Me.Txt4.TabIndex = 208
        Me.Txt4.Text = ""
        Me.Txt4.Visible = False
        '
        'BtADD_CONTAINER
        '
        Me.BtADD_CONTAINER.Location = New System.Drawing.Point(670, 118)
        Me.BtADD_CONTAINER.Name = "BtADD_CONTAINER"
        Me.BtADD_CONTAINER.Size = New System.Drawing.Size(65, 24)
        Me.BtADD_CONTAINER.TabIndex = 213
        Me.BtADD_CONTAINER.Text = "添加"
        '
        'Txt58F
        '
        Me.Txt58F.Location = New System.Drawing.Point(482, 120)
        Me.Txt58F.MaxLength = 10
        Me.Txt58F.Name = "Txt58F"
        Me.Txt58F.Size = New System.Drawing.Size(28, 21)
        Me.Txt58F.TabIndex = 212
        Me.Txt58F.Text = ""
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(446, 120)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 22)
        Me.Label25.TabIndex = 211
        Me.Label25.Text = "58F："
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt58E
        '
        Me.Txt58E.Location = New System.Drawing.Point(418, 120)
        Me.Txt58E.MaxLength = 10
        Me.Txt58E.Name = "Txt58E"
        Me.Txt58E.Size = New System.Drawing.Size(28, 21)
        Me.Txt58E.TabIndex = 210
        Me.Txt58E.Text = ""
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(382, 120)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(36, 22)
        Me.Label26.TabIndex = 209
        Me.Label26.Text = "58E："
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRMCON_TALLY_LIST_EDIT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(758, 590)
        Me.Controls.Add(Me.BtADD_CONTAINER)
        Me.Controls.Add(Me.Txt58F)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Txt58E)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Txt4)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.C1TALLY)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
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
        Me.Controls.Add(Me.TxtTEAM_NO)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.RBROW)
        Me.Controls.Add(Me.RBCOL)
        Me.Controls.Add(Me.Txtseachbay)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtCONTAINERNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbRELOAD)
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
        Me.Controls.Add(Me.TXTCON_TALLY_LIST_ID)
        Me.Controls.Add(Me.BtADD)
        Me.Controls.Add(Me.BtDELETE)
        Me.Controls.Add(Me.BtADDALL)
        Me.Controls.Add(Me.BtDELETEALL)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTOK)
        Me.Controls.Add(Me.C1IMAGE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMCON_TALLY_LIST_EDIT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "理箱单_编辑"
        CType(Me.C1IMAGE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TALLY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCON_TALLY_LIST_EDIT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            CombTALLY_CLERK1.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk1"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk1")))
            CombTALLY_CLERK2.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk2"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk2")))
            CombTALLY_CLERK3.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk3"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk3")))
            Call CBNIGHT_SELECT()
        End If
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
        'Txt20E.Text = ds.Tables(0).Rows(0).Item("e20")
        'Txt20F.Text = ds.Tables(0).Rows(0).Item("f20")
        'Txt40E.Text = ds.Tables(0).Rows(0).Item("e40")
        'Txt40F.Text = ds.Tables(0).Rows(0).Item("f40")
        'Txt45E.Text = ds.Tables(0).Rows(0).Item("e45")
        'Txt45F.Text = ds.Tables(0).Rows(0).Item("f45")
        'TxtTOTAL.Text = ds.Tables(0).Rows(0).Item("con_total")
        'TxtTEU.Text = ds.Tables(0).Rows(0).Item("teu")

        'E20 = Txt20E.Text
        'F20 = Txt20F.Text
        'E40 = Txt40E.Text
        'F40 = Txt40F.Text
        'E45 = Txt45E.Text
        'F45 = Txt45F.Text
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
        TOTAL = ds.Tables(0).Rows(0).Item("con_total")
        'TEU = TxtTEU.Text
        TxtTEAM_NO.Focus()
        Me.C1TALLY.Refresh()
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

    Private Sub DTPdate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPdate.Leave
        'Call clerk()
        'CombTALLY_CLERK1.SelectedValue = ""
        'CombTALLY_CLERK2.SelectedValue = ""
        'CombTALLY_CLERK3.SelectedValue = ""
    End Sub

    Private Sub TxtTime_from_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTime_from.Leave
        'Call clerk()
        'CombTALLY_CLERK1.SelectedValue = ""
        'CombTALLY_CLERK2.SelectedValue = ""
        'CombTALLY_CLERK3.SelectedValue = ""
        Call CBNIGHT_SELECT()
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
            dwimage = Getdata("select CON_HATCH_RECORD_ID,CONTAINER_NO,SIZE_CON,FULLOREMPTY,weight,SEALNO,BAYNO,BAYCOL,BAYROW from VIEWCON_TALLY_HATCH where ship_id='" & Ship_ID & "' and CONTAINER_NO like '%" & Trim(TxtCONTAINERNO.Text) & "%' and bayno like '" & Txtseachbay.Text & "%'", dsimage)
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

    Private Sub C1TALLY_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1TALLY.RowColChange
        Dim ds_con As New DataSet
        Try
            If e.LastRow <> -1 And Me.C1TALLY.Columns.Item("CON_TALLY_LIST_ID").Text = "" Then
                Me.C1TALLY.Columns.Item("CON_TALLY_LIST_ID").Text = TXTCON_TALLY_LIST_ID.Text
                'Me.C1TALLY.Columns.Item("RELOAD").Value = 0
                Me.C1TALLY.Columns.Item("OPENBOX").Value = 0
                'Me.C1TALLY.Columns.Item("UnLoad_Mark").Value = "0"
                'Me.C1TALLY.Columns.Item("OUT_HATCH").Value = 0
                Me.C1TALLY.Columns.Item("CODE_SHIP_AGENT").Value = agent
            End If
            Label16.Text = "共" & TOTAL & "个"
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtADD.Click
        If TOTAL >= 30 Then
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
                TOTAL = TOTAL + 1
                'If Me.C1TALLY.Columns.Item("SIZE_CON").Text = 20 Then
                '    If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "E" Then
                '        E20 = E20 + 1
                '    End If
                '    If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "F" Then
                '        F20 = F20 + 1
                '    End If
                'End If
                'If Me.C1TALLY.Columns.Item("SIZE_CON").Text = 40 Then
                '    If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "E" Then
                '        E40 = E40 + 1
                '    End If
                '    If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "F" Then
                '        F40 = F40 + 1
                '    End If
                'End If
                'If Me.C1TALLY.Columns.Item("SIZE_CON").Text = 45 Then
                '    If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "E" Then
                '        E45 = E45 + 1
                '    End If
                '    If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "F" Then
                '        F45 = F45 + 1
                '    End If
                'End If
                'TEU = E20 + F20 + (E40 + F40) * 2 + (E45 + F45) * 2.5
                'Txt20E.Text = E20
                'Txt20F.Text = F20
                'Txt40E.Text = E40
                'Txt40F.Text = F40
                'Txt45E.Text = E45
                'Txt45F.Text = F45
                'TxtTOTAL.Text = TOTAL
                'TxtTEU.Text = TEU
                Me.C1TALLY.Row = Me.C1TALLY.Row + 1
                'Call calcucontain()
                Label16.Text = "共" & TOTAL & "个"
                TxtCONTAINERNO.Text = ""
                TxtCONTAINERNO.Focus()
                Call Txtseachbay_TextChanged(sender, e)
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Private Sub BtADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtADD.Click
    '    Try
    '        Me.C1TALLY.MoveLast()
    '        Me.C1TALLY.Row = Me.C1TALLY.Row + 1
    '        Me.C1TALLY.Columns.Item("CON_TALLY_LIST_ID").Text = TXTCON_TALLY_LIST_ID.Text
    '        Me.C1TALLY.Columns.Item("CONTAINER_NO").Value = Me.C1IMAGE.Columns.Item("CONTAINER_NO").Text
    '        Me.C1TALLY.Columns.Item("SIZE_CON").Value = Me.C1IMAGE.Columns.Item("SIZE_CON").Text
    '        Me.C1TALLY.Columns.Item("FULLOREMPTY").Value = Me.C1IMAGE.Columns.Item("FULLOREMPTY").Text
    '        Me.C1TALLY.Columns.Item("SEALNO").Value = Me.C1IMAGE.Columns.Item("SEALNO").Text
    '        Me.C1TALLY.Columns.Item("BAYNO").Value = Me.C1IMAGE.Columns.Item("BAYNO").Text
    '        Me.C1TALLY.Columns.Item("weight").Value = Me.C1IMAGE.Columns.Item("weight").Text
    '        'Me.C1TALLY.Columns.Item("RELOAD").Value = 0
    '        Me.C1TALLY.Columns.Item("OPENBOX").Value = 0
    '        Me.C1TALLY.Columns.Item("UnLoad_Mark").Value = "0"
    '        'Me.C1TALLY.Columns.Item("OUT_HATCH").Value = 0
    '        Me.C1TALLY.Columns.Item("CODE_SHIP_AGENT").Value = agent
    '        ExecSql("update CON_HATCH_RECORD set Unload_Mark='1' where CON_HATCH_RECORD_ID='" & Me.C1IMAGE.Columns.Item("CON_HATCH_RECORD_ID").Text & "'")
    '        Me.C1TALLY.Row = Me.C1TALLY.Row + 1
    '        TxtCONTAINERNO.Text = ""
    '        TxtCONTAINERNO.Focus()
    '        Call Txtseachbay_TextChanged(sender, e)
    '        Call calcucontain()
    '        Label16.Text = "共" & ds_sub.Tables(0).Rows.Count & "个"
    '    Catch ex As System.Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub BtDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDELETE.Click
        Dim ds_update As New DataSet
        Try
            dw = Getdata("select * from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and container_no='" & Me.C1TALLY.Columns.Item("container_no").Text & "'", ds_update)
            If ds_update.Tables(0).Rows.Count > 0 Then
                ExecSql("update CON_HATCH_RECORD set unload_mark='0' where CON_HATCH_RECORD_ID='" & ds_update.Tables(0).Rows(0).Item("CON_HATCH_RECORD_ID") & "'")
                ExecSql("update con_image set Unload_Mark='0' where ship_id='" & Ship_ID & "' and container_no='" & Me.C1TALLY.Columns.Item("CONTAINER_NO").Text & "'")
            End If
            TOTAL = TOTAL - 1
            'If Me.C1TALLY.Columns.Item("SIZE_CON").Text = 20 Then
            '    If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "E" Then
            '        E20 = E20 - 1
            '    End If
            '    If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "F" Then
            '        F20 = F20 - 1
            '    End If
            'End If
            'If Me.C1TALLY.Columns.Item("SIZE_CON").Text = 40 Then
            '    If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "E" Then
            '        E40 = E40 - 1
            '    End If
            '    If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "F" Then
            '        F40 = F40 - 1
            '    End If
            'End If
            'If Me.C1TALLY.Columns.Item("SIZE_CON").Text = 45 Then
            '    If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "E" Then
            '        E45 = E45 - 1
            '    End If
            '    If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "F" Then
            '        F45 = F45 - 1
            '    End If
            'End If
            'TEU = E20 + F20 + (E40 + F40) * 2 + (E45 + F45) * 2.5
            'Txt20E.Text = E20
            'Txt20F.Text = F20
            'Txt40E.Text = E40
            'Txt40F.Text = F40
            'Txt45E.Text = E45
            'Txt45F.Text = F45
            'TxtTOTAL.Text = TOTAL
            'TxtTEU.Text = TEU
            Call Txtseachbay_TextChanged(sender, e)
            Me.C1TALLY.AllowDelete = True
            Me.C1TALLY.Delete()
            Me.C1TALLY.AllowDelete = False
            Label16.Text = "共" & TOTAL & "个"
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtADDALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtADDALL.Click
        Dim i As Integer
        If dsimage.Tables(0).Rows.Count + TOTAL > 30 Then
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
                    TOTAL = TOTAL + 1
                    '    If Me.C1TALLY.Columns.Item("SIZE_CON").Text = 20 Then
                    '        If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "E" Then
                    '            E20 = E20 + 1
                    '        End If
                    '        If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "F" Then
                    '            F20 = F20 + 1
                    '        End If
                    '    End If
                    '    If Me.C1TALLY.Columns.Item("SIZE_CON").Text = 40 Then
                    '        If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "E" Then
                    '            E40 = E40 + 1
                    '        End If
                    '        If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "F" Then
                    '            F40 = F40 + 1
                    '        End If
                    '    End If
                    '    If Me.C1TALLY.Columns.Item("SIZE_CON").Text = 45 Then
                    '        If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "E" Then
                    '            E45 = E45 + 1
                    '        End If
                    '        If Me.C1TALLY.Columns.Item("FULLOREMPTY").Text = "F" Then
                    '            F45 = F45 + 1
                    '        End If
                    '    End If
                Next
                'TEU = E20 + F20 + (E40 + F40) * 2 + (E45 + F45) * 2.5
                'Txt20E.Text = E20
                'Txt20F.Text = F20
                'Txt40E.Text = E40
                'Txt40F.Text = F40
                'Txt45E.Text = E45
                'Txt45F.Text = F45
                'TxtTOTAL.Text = TOTAL
                'TxtTEU.Text = TEU
                TxtCONTAINERNO.Text = ""
                TxtCONTAINERNO.Focus()
                Call Txtseachbay_TextChanged(sender, e)
                C1TALLY.Refresh()
                Me.C1TALLY.MoveFirst()
                Label16.Text = "共" & TOTAL & "个"
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try
        End If
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
            Label16.Text = "共" & TOTAL & "个"
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

    Private Sub C1TALLY_BeforeColEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles C1TALLY.BeforeColEdit
        Try
            Txt1.Text = Trim(Me.C1TALLY.Columns.Item("size_con").Text)
            Txt2.Text = Trim(Me.C1TALLY.Columns.Item("FULLOREMPTY").Text)
            If e.ColIndex = 2 Then
                oldcon = Me.C1TALLY.Columns.Item("container_no").Text
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1TALLY_AfterColEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1TALLY.AfterColEdit
        Dim ds_CRITERION As New DataSet
        Try
            'Txt3.Text = Trim(Me.C1TALLY.Columns.Item("size_con").Text)
            'Txt4.Text = Trim(Me.C1TALLY.Columns.Item("FULLOREMPTY").Text)
            'If Txt1.Text <> Txt3.Text Or Txt2.Text <> Txt4.Text Then
            '    If Txt1.Text = 20 Then   '把修改前的箱去掉
            '        If Txt2.Text = "E" Then
            '            E20 = E20 - 1
            '        End If
            '        If Txt2.Text = "F" Then
            '            F20 = F20 - 1
            '        End If
            '    End If
            '    If Txt1.Text = 40 Then
            '        If Txt2.Text = "E" Then
            '            E40 = E40 - 1
            '        End If
            '        If Txt2.Text = "F" Then
            '            F40 = F40 - 1
            '        End If
            '    End If
            '    If Txt1.Text = 45 Then
            '        If Txt2.Text = "E" Then
            '            E45 = E45 - 1
            '        End If
            '        If Txt2.Text = "F" Then
            '            F45 = F45 - 1
            '        End If
            '    End If
            '    If Txt3.Text = 20 Then   '加上修改后的箱
            '        If Txt4.Text = "E" Then
            '            E20 = E20 + 1
            '        End If
            '        If Txt4.Text = "F" Then
            '            F20 = F20 + 1
            '        End If
            '    End If
            '    If Txt3.Text = 40 Then
            '        If Txt4.Text = "E" Then
            '            E40 = E40 + 1
            '        End If
            '        If Txt4.Text = "F" Then
            '            F40 = F40 + 1
            '        End If
            '    End If
            '    If Txt3.Text = 45 Then
            '        If Txt4.Text = "E" Then
            '            E45 = E45 + 1
            '        End If
            '        If Txt4.Text = "F" Then
            '            F45 = F45 + 1
            '        End If
            '    End If
            '    TEU = E20 + F20 + (E40 + F40) * 2 + (E45 + F45) * 2.5
            '    Txt20E.Text = E20
            '    Txt20F.Text = F20
            '    Txt40E.Text = E40
            '    Txt40F.Text = F40
            '    Txt45E.Text = E45
            '    Txt45F.Text = F45
            '    TxtTOTAL.Text = TOTAL
            '    TxtTEU.Text = TEU
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

    Private Sub C1TALLY_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1TALLY.FetchRowStyle
        If Me.C1TALLY.Columns("unload_mark").CellValue(e.Row) = "1" Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        End If
    End Sub

    Private Sub CONTAIN(ByVal CONTAINERNO As String, ByVal oldCONTAINERNO As String)
        Try
            If Len(CONTAINERNO) > 0 Then

                Dim ds_con As New DataSet

                If INOUT_MARK <> "1" Then   '出舱时没有溢出
                    If RELOAD <> "1" Then   '重装时没有溢出

                        dw = Getdata("select * from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and Unload_Mark='1' and CONTAINER_NO='" & oldCONTAINERNO & "' ", ds_con)
                        If ds_con.Tables(0).Rows.Count > 0 Then
                            ExecSql("update CON_HATCH_RECORD set Unload_Mark='0' where CON_HATCH_RECORD_ID='" & ds_con.Tables(0).Rows(0).Item("CON_HATCH_RECORD_ID") & "'")
                            ExecSql("update con_image set Unload_Mark='0' where ship_id='" & Ship_ID & "' and container_no='" & oldCONTAINERNO & "'")
                        End If
                        ds_con.Reset()
                        dw = Getdata("select * from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and Unload_Mark='0' and CONTAINER_NO='" & CONTAINERNO & "' ", ds_con)

                        If ds_con.Tables(0).Rows.Count > 0 Then
                            ExecSql("update CON_HATCH_RECORD set Unload_Mark='1' where CON_HATCH_RECORD_ID='" & ds_con.Tables(0).Rows(0).Item("CON_HATCH_RECORD_ID") & "'")
                            ExecSql("update con_image set Unload_Mark='0' where ship_id='" & Ship_ID & "' and container_no='" & CONTAINERNO & "'")
                            Me.C1TALLY.Columns.Item("UnLoad_Mark").Text = "0"
                        Else
                            ds_con.Reset()
                            dw = Getdata("select * from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and  CONTAINER_NO='" & CONTAINERNO & "' ", ds_con)
                            If ds_con.Tables(0).Rows.Count > 0 Then
                                ds_con.Reset()
                                dw = Getdata("select * from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and Unload_Mark='1' CONTAINER_NO='" & CONTAINERNO & "' ", ds_con)
                                MsgBox("该箱已卸, 请查实!")
                            Else
                                MsgBox("船图箱信息中没有该箱号！该箱为溢出。")
                                Me.C1TALLY.Columns.Item("UnLoad_Mark").Text = "1"
                            End If

                        End If
                    End If

                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1tally_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1TALLY.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.C1TALLY.Col = 9 Then
                Me.C1TALLY.Row = Me.C1TALLY.Row + 1
                Me.C1TALLY.Col = 1
                SendKeys.Send("{LEFT}")
            End If
        End If
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Dim dskey As New DataSet
        Dim cmark As String
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

            ' ExecSql("UPDATE con_tally_list set e20='" & Txt20E.Text & "',f20='" & Txt20F.Text & "',e40='" & Txt40E.Text & "',f40='" & Txt40F.Text & "',e45='" & Txt45E.Text & "',f45='" & Txt45F.Text & "',con_total='" & TxtTOTAL.Text & "',teu='" & TxtTEU.Text & "' where con_tally_list_id='" & TXTCON_TALLY_LIST_ID.Text & "'")
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

            'Call check()
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
                                    dw = Getdata("select * from con_tally_LIST where ship_id='" & Ship_ID & "' and no='" & TxtNO.Text & "' and INOUT_MARK='" & cmark & "' and CON_TALLY_LIST_ID<>'" & ID & "' ", dskey)
                                    If dskey.Tables(0).Rows.Count > 0 Then
                                        MsgBox("该理箱单已经存在！")
                                    Else
                                        If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                                            OperateHistory(G_DeptName, Now, G_User, "编辑", "con_tally_list", ID, "con_tally_list_id")
                                            ds.Tables(0).Rows(0).Item("ship_id") = Trim(Ship_ID)
                                            ds.Tables(0).Rows(0).Item("NO") = Trim(TxtNO.Text)
                                            ds.Tables(0).Rows(0).Item("team_NO") = Trim(TxtTEAM_NO.Text)
                                            ds.Tables(0).Rows(0).Item("berthno") = IIf(Len(Trim(CombBERTHNO.SelectedValue)) > 0, Trim(CombBERTHNO.SelectedValue), "")
                                            ds.Tables(0).Rows(0).Item("bay") = IIf(Len(Trim(TxtBAY.Text)) > 0, Trim(TxtBAY.Text), "")
                                            If CBMARK.Checked = True Then
                                                ds.Tables(0).Rows(0).Item("INOUT_MARK") = "1"
                                            Else
                                                ds.Tables(0).Rows(0).Item("INOUT_MARK") = "0"
                                            End If
                                            If CBNIGHT_MARK.Checked = True Then
                                                ds.Tables(0).Rows(0).Item("NIGHT_MARK") = "1"
                                            Else
                                                ds.Tables(0).Rows(0).Item("NIGHT_MARK") = "0"
                                            End If
                                            If cbHOLIDAY.Checked = True Then
                                                ds.Tables(0).Rows(0).Item("HOLIDAY") = "1"
                                            Else
                                                ds.Tables(0).Rows(0).Item("HOLIDAY") = "0"
                                            End If
                                            If CBANCHORAGE_REMARK.Checked = True Then
                                                ds.Tables(0).Rows(0).Item("ANCHORAGE_REMARK") = "1"
                                            Else
                                                ds.Tables(0).Rows(0).Item("ANCHORAGE_REMARK") = "0"
                                            End If
                                            If CBSEA_AFFAIRE_CARGO.Checked = True Then
                                                ds.Tables(0).Rows(0).Item("SEA_AFFAIRE_CARGO") = "1"
                                            Else
                                                ds.Tables(0).Rows(0).Item("SEA_AFFAIRE_CARGO") = "0"
                                            End If
                                            If cbRELOAD.Checked = True Then
                                                ds.Tables(0).Rows(0).Item("RELOAD") = "1"
                                            Else
                                                ds.Tables(0).Rows(0).Item("RELOAD") = "0"
                                            End If

                                            ds.Tables(0).Rows(0).Item("YARD_NO") = IIf(Len(Trim(TxtYARD_NO.Text)) > 0, Trim(TxtYARD_NO.Text), "")
                                            ds.Tables(0).Rows(0).Item("DATE") = DTPdate.Value
                                            ds.Tables(0).Rows(0).Item("time_from") = TxtTime_from.Text
                                            ds.Tables(0).Rows(0).Item("time_to") = Txttime_to.Text
                                            'ds.Tables(0).Rows(0).Item("TALLY_CLERK1") = IIf(Len(Trim(CombTALLY_CLERK1.SelectedValue)) > 0, Trim(CombTALLY_CLERK1.SelectedValue), "00")
                                            'ds.Tables(0).Rows(0).Item("TALLY_CLERK2") = IIf(Len(Trim(CombTALLY_CLERK2.SelectedValue)) > 0, Trim(CombTALLY_CLERK2.SelectedValue), "00")
                                            'ds.Tables(0).Rows(0).Item("TALLY_CLERK3") = IIf(Len(Trim(CombTALLY_CLERK3.SelectedValue)) > 0, Trim(CombTALLY_CLERK3.SelectedValue), "00")
                                            ds.Tables(0).Rows(0).Item("TALLY_CLERK3") = Trim(G_User)
                                            ds.Tables(0).Rows(0).Item("CROSS_PERSON") = IIf(Len(Trim(TxtCROSS_PERSON.Text)) > 0, Trim(TxtCROSS_PERSON.Text), "")
                                            'ds.Tables(0).Rows(0).Item("user_name") = Trim(G_User)
                                            sqlda_sub.Update(ds_sub)
                                            sqlda.Update(ds)

                                            Call BTQUIT_Click(sender, e)

                                        End If
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

    'Private Sub calcucontain()
    'Dim i As Integer
    'E20 = 0
    'F20 = 0
    'E40 = 0
    'F40 = 0
    'E45 = 0
    'F45 = 0
    'TOTAL = 0
    'TEU = 0
    'Try

    '    If ds_sub.Tables(0).Rows.Count > 0 Then
    '        For i = 0 To ds_sub.Tables(0).Rows.Count - 1
    '            If ds_sub.Tables(0).Rows(i).Item("SIZE_CON") = "20" Then
    '                If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "E" Then
    '                    E20 = E20 + 1
    '                End If
    '                If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "F" Then
    '                    F20 = F20 + 1
    '                End If
    '            End If
    '            If ds_sub.Tables(0).Rows(i).Item("SIZE_CON") = "40" Then
    '                If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "E" Then
    '                    E40 = E40 + 1
    '                End If
    '                If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "F" Then
    '                    F40 = F40 + 1
    '                End If
    '            End If
    '            If ds_sub.Tables(0).Rows(i).Item("SIZE_CON") = "45" Then
    '                If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "E" Then
    '                    E45 = E45 + 1
    '                End If
    '                If ds_sub.Tables(0).Rows(i).Item("FULLOREMPTY") = "F" Then
    '                    F45 = F45 + 1
    '                End If
    '            End If
    '        Next
    '    End If
    '    TOTAL = E20 + F20 + E40 + F40 + E45 + F45
    '    TEU = E20 + F20 + E40 * 2 + F40 * 2 + E45 * 2.5 + F45 * 2.5
    '    Txt20E.Text = E20
    '    Txt20F.Text = F20
    '    Txt40E.Text = E40
    '    Txt40F.Text = F40
    '    Txt45E.Text = E45
    '    Txt45F.Text = F45
    '    TxtTOTAL.Text = TOTAL
    '    TxtTEU.Text = TEU
    'Catch ex As System.Exception
    '    MsgBox(ex.Message)
    'End Try
    'End Sub

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
