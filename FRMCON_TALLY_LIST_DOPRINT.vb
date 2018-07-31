Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FRMCON_TALLY_LIST_DOPRINT
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim dw_sub As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim ds_sub As New DataSet()
    Dim sqlda_sub As New SqlClient.SqlDataAdapter()
    Dim dwship As New DataView()
    Dim dwbay As New DataView()
    Dim dsbay As New DataSet()
    Dim totalcount As Integer
    Dim dw_bay As New DataView()
    Dim ds_bay As New DataSet()


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
    Friend WithEvents Txtseachbay As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtADD As System.Windows.Forms.Button
    Friend WithEvents BtDELETE As System.Windows.Forms.Button
    Friend WithEvents BtADDALL As System.Windows.Forms.Button
    Friend WithEvents BtDELETEALL As System.Windows.Forms.Button
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents C1TALLY As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1IMAGE As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RBCOL As System.Windows.Forms.RadioButton
    Friend WithEvents RBROW As System.Windows.Forms.RadioButton
    Friend WithEvents RBCHA As System.Windows.Forms.RadioButton
    Friend WithEvents RBENG As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RBDESC As System.Windows.Forms.RadioButton
    Friend WithEvents RBASC As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRMCON_TALLY_LIST_DOPRINT))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Dim GridLines2 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.Txtseachbay = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtADD = New System.Windows.Forms.Button()
        Me.BtDELETE = New System.Windows.Forms.Button()
        Me.BtADDALL = New System.Windows.Forms.Button()
        Me.BtDELETEALL = New System.Windows.Forms.Button()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTOK = New System.Windows.Forms.Button()
        Me.C1TALLY = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1IMAGE = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RBCOL = New System.Windows.Forms.RadioButton()
        Me.RBROW = New System.Windows.Forms.RadioButton()
        Me.RBCHA = New System.Windows.Forms.RadioButton()
        Me.RBENG = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RBDESC = New System.Windows.Forms.RadioButton()
        Me.RBASC = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.C1TALLY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1IMAGE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtseachbay
        '
        Me.Txtseachbay.Location = New System.Drawing.Point(38, 10)
        Me.Txtseachbay.MaxLength = 2
        Me.Txtseachbay.Name = "Txtseachbay"
        Me.Txtseachbay.Size = New System.Drawing.Size(30, 21)
        Me.Txtseachbay.TabIndex = 160
        Me.Txtseachbay.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 22)
        Me.Label10.TabIndex = 159
        Me.Label10.Text = "贝号"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtADD
        '
        Me.BtADD.Enabled = False
        Me.BtADD.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtADD.Location = New System.Drawing.Point(346, 190)
        Me.BtADD.Name = "BtADD"
        Me.BtADD.Size = New System.Drawing.Size(26, 22)
        Me.BtADD.TabIndex = 158
        Me.BtADD.Text = ">"
        '
        'BtDELETE
        '
        Me.BtDELETE.Enabled = False
        Me.BtDELETE.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtDELETE.Location = New System.Drawing.Point(346, 228)
        Me.BtDELETE.Name = "BtDELETE"
        Me.BtDELETE.Size = New System.Drawing.Size(26, 22)
        Me.BtDELETE.TabIndex = 157
        Me.BtDELETE.Text = "<"
        '
        'BtADDALL
        '
        Me.BtADDALL.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtADDALL.Location = New System.Drawing.Point(346, 266)
        Me.BtADDALL.Name = "BtADDALL"
        Me.BtADDALL.Size = New System.Drawing.Size(26, 22)
        Me.BtADDALL.TabIndex = 156
        Me.BtADDALL.Text = ">>"
        '
        'BtDELETEALL
        '
        Me.BtDELETEALL.Enabled = False
        Me.BtDELETEALL.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtDELETEALL.Location = New System.Drawing.Point(346, 304)
        Me.BtDELETEALL.Name = "BtDELETEALL"
        Me.BtDELETEALL.Size = New System.Drawing.Size(26, 22)
        Me.BtDELETEALL.TabIndex = 155
        Me.BtDELETEALL.Text = "<<"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(626, 8)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 154
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(552, 8)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 153
        Me.BTOK.Text = "打印"
        '
        'C1TALLY
        '
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
        Me.C1TALLY.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1TALLY.Location = New System.Drawing.Point(380, 42)
        Me.C1TALLY.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1TALLY.Name = "C1TALLY"
        Me.C1TALLY.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TALLY.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TALLY.PreviewInfo.ZoomFactor = 75
        Me.C1TALLY.PrintInfo.ShowOptionsDialog = False
        Me.C1TALLY.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1TALLY.RowDivider = GridLines1
        Me.C1TALLY.RowHeight = 16
        Me.C1TALLY.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1TALLY.ScrollTips = False
        Me.C1TALLY.Size = New System.Drawing.Size(392, 534)
        Me.C1TALLY.TabIndex = 152
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
        "SelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollG" & _
        "roup=""1""><ClientRect>0, 0, 388, 530</ClientRect><BorderSide>0</BorderSide><Capti" & _
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
        "lits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWid" & _
        "th><ClientArea>0, 0, 388, 530</ClientArea></Blob>"
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
        Me.C1IMAGE.Images.Add(CType(resources.GetObject("resource.Images1"), System.Drawing.Bitmap))
        Me.C1IMAGE.Location = New System.Drawing.Point(6, 42)
        Me.C1IMAGE.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1IMAGE.Name = "C1IMAGE"
        Me.C1IMAGE.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1IMAGE.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1IMAGE.PreviewInfo.ZoomFactor = 75
        Me.C1IMAGE.PrintInfo.ShowOptionsDialog = False
        Me.C1IMAGE.RecordSelectorWidth = 16
        GridLines2.Color = System.Drawing.Color.DarkGray
        GridLines2.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1IMAGE.RowDivider = GridLines2
        Me.C1IMAGE.RowHeight = 16
        Me.C1IMAGE.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1IMAGE.ScrollTips = False
        Me.C1IMAGE.Size = New System.Drawing.Size(334, 534)
        Me.C1IMAGE.TabIndex = 151
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
        "mnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" Def" & _
        "RecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0" & _
        ", 0, 330, 530</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "yout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 3" & _
        "30, 530</ClientArea></Blob>"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(692, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 161
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RBCOL
        '
        Me.RBCOL.Location = New System.Drawing.Point(6, 14)
        Me.RBCOL.Name = "RBCOL"
        Me.RBCOL.Size = New System.Drawing.Size(50, 20)
        Me.RBCOL.TabIndex = 162
        Me.RBCOL.Text = "按列"
        '
        'RBROW
        '
        Me.RBROW.Location = New System.Drawing.Point(58, 14)
        Me.RBROW.Name = "RBROW"
        Me.RBROW.Size = New System.Drawing.Size(50, 20)
        Me.RBROW.TabIndex = 163
        Me.RBROW.Text = "按层"
        '
        'RBCHA
        '
        Me.RBCHA.Location = New System.Drawing.Point(58, 14)
        Me.RBCHA.Name = "RBCHA"
        Me.RBCHA.Size = New System.Drawing.Size(50, 20)
        Me.RBCHA.TabIndex = 163
        Me.RBCHA.Text = "中文"
        '
        'RBENG
        '
        Me.RBENG.Location = New System.Drawing.Point(6, 14)
        Me.RBENG.Name = "RBENG"
        Me.RBENG.Size = New System.Drawing.Size(50, 20)
        Me.RBENG.TabIndex = 162
        Me.RBENG.Text = "英文"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.RBROW, Me.RBCOL})
        Me.GroupBox1.Location = New System.Drawing.Point(82, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 38)
        Me.GroupBox1.TabIndex = 164
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.RBCHA, Me.RBENG})
        Me.GroupBox2.Location = New System.Drawing.Point(196, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 38)
        Me.GroupBox2.TabIndex = 165
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(348, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 22)
        Me.Label2.TabIndex = 166
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.RBDESC, Me.RBASC})
        Me.GroupBox3.Location = New System.Drawing.Point(310, -2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 38)
        Me.GroupBox3.TabIndex = 167
        Me.GroupBox3.TabStop = False
        '
        'RBDESC
        '
        Me.RBDESC.Location = New System.Drawing.Point(58, 14)
        Me.RBDESC.Name = "RBDESC"
        Me.RBDESC.Size = New System.Drawing.Size(50, 20)
        Me.RBDESC.TabIndex = 163
        Me.RBDESC.Text = "倒序"
        '
        'RBASC
        '
        Me.RBASC.Location = New System.Drawing.Point(6, 14)
        Me.RBASC.Name = "RBASC"
        Me.RBASC.Size = New System.Drawing.Size(50, 20)
        Me.RBASC.TabIndex = 162
        Me.RBASC.Text = "顺序"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(438, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 24)
        Me.Button1.TabIndex = 168
        Me.Button1.Text = "单贝打印"
        '
        'FRMCON_TALLY_LIST_DOPRINT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(778, 583)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.GroupBox3, Me.Label2, Me.GroupBox2, Me.GroupBox1, Me.Label1, Me.Txtseachbay, Me.Label10, Me.BtADD, Me.BtDELETE, Me.BtADDALL, Me.BtDELETEALL, Me.BTQUIT, Me.BTOK, Me.C1TALLY, Me.C1IMAGE})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMCON_TALLY_LIST_DOPRINT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱理箱单_预配"
        CType(Me.C1TALLY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1IMAGE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCON_TALLY_LIST_DOPRINT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GETIMAGE()
        dw_sub = Updatedata(sqlda_sub, "select CONTAINER_NO,SEALNO,SIZE_CON,FULLOREMPTY,BAYNO from CON_TALLY_DETAIL where CON_TALLY_LIST_ID='0'", ds_sub)
        C1TALLY.DataSource = ds_sub.Tables(0).DefaultView

        Me.C1TALLY.Columns.Item("BAYNO").Caption = "贝位号"
        Me.C1TALLY.Columns.Item("CONTAINER_NO").Caption = "箱号"
        Me.C1TALLY.Columns.Item("SIZE_CON").Caption = "尺寸"
        Me.C1TALLY.Columns.Item("SEALNO").Caption = "铅封号"
        Me.C1TALLY.Columns.Item("FULLOREMPTY").Caption = "空/重"

        Me.C1TALLY.Splits(0).DisplayColumns.Item("CONTAINER_NO").Width = 90
        Me.C1TALLY.Splits(0).DisplayColumns.Item("SEALNO").Width = 100
        Me.C1TALLY.Splits(0).DisplayColumns.Item("BAYNO").Width = 50
        Me.C1TALLY.Splits(0).DisplayColumns.Item("FULLOREMPTY").Width = 40
        Me.C1TALLY.Splits(0).DisplayColumns.Item("SIZE_CON").Width = 30
        Me.C1IMAGE.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1TALLY.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1TALLY.Refresh()
        Me.C1TALLY.MoveLast()

        Label1.Text = "计 " & ds_sub.Tables(0).Rows.Count & " 个"
        totalcount = 0
        ds_sship.Reset()
        dwship = Getdata("select * from View_SSHIP where ship_id='" & Ship_ID & "'", ds_sship)
    End Sub

    Private Sub Txtseachbay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtseachbay.TextChanged
        Dim dsquery As New DataSet
        Try
            If Len(Trim(Txtseachbay.Text)) > 0 And RBCOL.Checked = True Then
                dw.RowFilter = "bayno like '" & Txtseachbay.Text & "%'"
                If RBDESC.Checked = True Then
                    dw.Sort = "baycol desc"
                Else
                    dw.Sort = "baycol asc"
                End If

                C1IMAGE.Refresh()
                Me.C1IMAGE.MoveLast()
                If Me.C1IMAGE.Row = 0 Then
                    BtADDALL.Enabled = False
                Else
                    BtADDALL.Enabled = True
                End If
                Me.C1TALLY.MoveLast()
                If Me.C1TALLY.Row = 0 Then
                    BtDELETEALL.Enabled = False
                Else
                    BtDELETEALL.Enabled = True
                End If
            ElseIf Len(Trim(Txtseachbay.Text)) > 0 Then

                dw.RowFilter = "bayno like '" & Txtseachbay.Text & "%' "
                If RBDESC.Checked = True Then
                    dw.Sort = "bayrow desc"
                Else
                    dw.Sort = "bayrow asc"
                End If
                C1IMAGE.Refresh()
                Me.C1IMAGE.MoveLast()
                If Me.C1IMAGE.Row = 0 Then
                    BtADDALL.Enabled = False
                Else
                    BtADDALL.Enabled = True
                End If
                Me.C1TALLY.MoveLast()
                If Me.C1TALLY.Row = 0 Then
                    BtDELETEALL.Enabled = False
                Else
                    BtDELETEALL.Enabled = True
                End If
            Else
                dw.RowFilter = "1=1"
                If RBCOL.Checked = True Then
                    If RBDESC.Checked = True Then
                        dw.Sort = "baycol desc"
                    Else
                        dw.Sort = "baycol asc"
                    End If
                Else
                    If RBDESC.Checked = True Then
                        dw.Sort = "bayrow desc"
                    Else
                        dw.Sort = "bayrow asc"
                    End If
                End If
            End If
            C1IMAGE.Refresh()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GETIMAGE()
        Try
            dw = Filldata("select CONTAINER_NO,BAYNO,SIZE_CON,FULLOREMPTY,SEALNO,substring(ISNULL(bayno,'      '),3,2) as baycol,substring(ISNULL(bayno,'      '),5,2)as bayrow from VIEWCON_TALLY_HATCH where ship_id='" & Ship_ID & "' order by bayno")
            C1IMAGE.DataSource = dw
            C1IMAGE.Splits(0).DisplayColumns.Item("baycol").Visible = False
            C1IMAGE.Splits(0).DisplayColumns.Item("bayrow").Visible = False
            C1IMAGE.Columns.Item("CONTAINER_NO").Caption = "箱号"
            C1IMAGE.Columns.Item("SEALNO").Caption = "铅封号"
            C1IMAGE.Columns.Item("BAYNO").Caption = "贝位号"
            C1IMAGE.Columns.Item("SIZE_CON").Caption = "尺寸"
            C1IMAGE.Columns.Item("FULLOREMPTY").Caption = "空/重"
            C1IMAGE.Splits(0).DisplayColumns.Item("CONTAINER_NO").Width = 90
            C1IMAGE.Splits(0).DisplayColumns.Item("SEALNO").Width = 80
            C1IMAGE.Splits(0).DisplayColumns.Item("BAYNO").Width = 50
            C1IMAGE.Splits(0).DisplayColumns.Item("SIZE_CON").Width = 30
            C1IMAGE.Splits(0).DisplayColumns.Item("FULLOREMPTY").Width = 40
            Me.C1IMAGE.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            'Me.C1IMAGE.ColumnFooters = True
            'Me.C1IMAGE.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            'Me.C1IMAGE.Columns("CONTAINER_NO").FooterText = "合计" & dw.Count & "条"

            C1IMAGE.Refresh()
            If RBCOL.Checked = True Then
                If RBDESC.Checked = True Then
                    dw.Sort = "baycol desc"
                Else
                    dw.Sort = "baycol asc"
                End If
            Else
                If RBDESC.Checked = True Then
                    dw.Sort = "bayrow desc"
                Else
                    dw.Sort = "bayrow asc"
                End If
                'Else
                '    If RBDESC.Checked = True Then
                '        dw.Sort = "bayno desc"
                '    Else
                '        dw.Sort = "bayno asc"
                '    End If
            End If
            C1IMAGE.Refresh()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtADD.Click
        Dim i As Integer
        Dim j As Integer
        Dim q As Integer
        Try
            Me.C1TALLY.Refresh()
            If Me.C1IMAGE.SelectedRows.Count > 0 Then
                i = 0
                j = 0
                q = Me.C1IMAGE.SelectedRows.Count
                Me.C1TALLY.MoveLast()
                j = totalcount + q
                If j <= 30 Then
                    Me.C1IMAGE.AllowDelete = True
                    Me.C1TALLY.AllowAddNew = True
                    Me.C1TALLY.Focus()
                    For i = 0 To Me.C1IMAGE.SelectedRows.Count - 1
                        Me.C1TALLY.Row = Me.C1TALLY.Row + 1
                        Me.C1IMAGE.Row = Me.C1IMAGE.SelectedRows.Item(i)
                        Me.C1TALLY.Columns.Item("CONTAINER_NO").Value = Me.C1IMAGE.Columns.Item("CONTAINER_NO").Text
                        Me.C1TALLY.Columns.Item("SIZE_CON").Value = Me.C1IMAGE.Columns.Item("SIZE_CON").Text
                        Me.C1TALLY.Columns.Item("FULLOREMPTY").Value = Me.C1IMAGE.Columns.Item("FULLOREMPTY").Text
                        Me.C1TALLY.Columns.Item("SEALNO").Value = Me.C1IMAGE.Columns.Item("SEALNO").Text
                        Me.C1TALLY.Columns.Item("BAYNO").Value = Me.C1IMAGE.Columns.Item("BAYNO").Text
                        'Me.C1IMAGE.SelectedRows.RemoveAt(i)
                    Next
                    Me.C1IMAGE.Row = Me.C1IMAGE.SelectedRows.Item(0)
                    For i = 0 To q - 1
                        Me.C1IMAGE.Delete()
                    Next
                Else
                    MsgBox("超过每张可打印箱数（30个），请调整！")
                    Exit Sub
                End If
                Me.C1TALLY.MoveLast()
                Me.C1TALLY.Refresh()
                Label1.Text = "计 " & ds_sub.Tables(0).Rows.Count + 1 & " 个"
                totalcount = ds_sub.Tables(0).Rows.Count + 1
                Me.C1IMAGE.MoveLast()
                If Me.C1IMAGE.Row = 0 Then
                    BtADDALL.Enabled = False
                Else
                    BtADDALL.Enabled = True
                End If
                Me.C1IMAGE.Row = 0
                Me.C1IMAGE.AllowDelete = False
                Me.C1TALLY.AllowAddNew = False
                Call Txtseachbay_TextChanged(sender, e)
                Me.C1TALLY.Refresh()
                BtADD.Enabled = False
                Me.C1IMAGE.Refresh()
                Me.C1IMAGE.MoveFirst()

            Else
                MsgBox("请选择箱子！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
            Me.C1IMAGE.AllowDelete = False
            Me.C1TALLY.AllowAddNew = False
            Me.C1TALLY.MoveLast()
            Label1.Text = "计 " & Me.C1TALLY.Row + 1 & " 个"
            totalcount = Me.C1TALLY.Row + 1
            Call Txtseachbay_TextChanged(sender, e)
            Me.C1IMAGE.Refresh()

        End Try
    End Sub

    Private Sub BtDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDELETE.Click
        Dim i As Integer
        Dim j As Integer
        Dim q As Integer

        Try
            If Me.C1TALLY.SelectedRows.Count > 0 Then
                Dim ds_update As New DataSet
                Me.C1TALLY.AllowDelete = True
                Me.C1IMAGE.AllowAddNew = True
                Me.C1TALLY.AllowAddNew = True

                q = Me.C1TALLY.SelectedRows.Count
                Me.C1IMAGE.MoveLast()
                For i = 0 To Me.C1TALLY.SelectedRows.Count - 1
                    Me.C1IMAGE.Row = Me.C1IMAGE.Row + 1
                    Me.C1TALLY.Row = Me.C1TALLY.SelectedRows.Item(i)
                    Me.C1IMAGE.Columns.Item("CONTAINER_NO").Value = Me.C1TALLY.Columns.Item("CONTAINER_NO").Text
                    Me.C1IMAGE.Columns.Item("SIZE_CON").Value = Me.C1TALLY.Columns.Item("SIZE_CON").Text
                    Me.C1IMAGE.Columns.Item("FULLOREMPTY").Value = Me.C1TALLY.Columns.Item("FULLOREMPTY").Text
                    Me.C1IMAGE.Columns.Item("SEALNO").Value = Me.C1TALLY.Columns.Item("SEALNO").Text
                    Me.C1IMAGE.Columns.Item("BAYNO").Value = Me.C1TALLY.Columns.Item("BAYNO").Text
                    Me.C1IMAGE.Columns.Item("BAYCOL").Value = Mid(IIf(Len(Trim(Me.C1TALLY.Columns.Item("BAYNO").Text)) = 6, Trim(Me.C1TALLY.Columns.Item("BAYNO").Text), "      "), 3, 2)
                    Me.C1IMAGE.Columns.Item("BAYROW").Value = Mid(IIf(Len(Trim(Me.C1TALLY.Columns.Item("BAYNO").Text)) = 6, Trim(Me.C1TALLY.Columns.Item("BAYNO").Text), "      "), 5, 2)
                Next
                Me.C1TALLY.Row = Me.C1TALLY.SelectedRows.Item(0)
                For i = 0 To q - 1
                    Me.C1TALLY.Delete()
                Next
                Me.C1IMAGE.Row = 0
                Label1.Text = "计 " & ds_sub.Tables(0).Rows.Count & " 个"
                totalcount = ds_sub.Tables(0).Rows.Count
                If ds_sub.Tables(0).Rows.Count = 0 Then
                    BtDELETEALL.Enabled = False
                Else
                    BtDELETEALL.Enabled = True
                End If
                Me.C1TALLY.Row = 0
                Me.C1TALLY.AllowDelete = False
                Me.C1IMAGE.AllowAddNew = False
                Me.C1TALLY.AllowAddNew = False

                Call Txtseachbay_TextChanged(sender, e)
                Me.C1TALLY.Refresh()
                Me.C1IMAGE.Refresh()
                Me.C1IMAGE.MoveFirst()
                BtDELETE.Enabled = False
            Else
                MsgBox("请选择箱子！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
            Me.C1TALLY.MoveLast()
            Label1.Text = "计 " & Me.C1TALLY.Row + 1 & " 个"
            totalcount = Me.C1TALLY.Row + 1
            Me.C1TALLY.AllowDelete = False
            Me.C1IMAGE.AllowAddNew = False
            Me.C1TALLY.AllowAddNew = False


        End Try
    End Sub

    Private Sub BtADDALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtADDALL.Click
        Dim i As Integer
        Dim j As Integer
        Dim q As Integer
        Try

            Me.C1IMAGE.MoveLast()
            j = Me.C1IMAGE.Row
            Me.C1TALLY.MoveLast()
            q = Me.C1TALLY.Row
            Me.C1IMAGE.Row = 0
            If j + q <= 30 Then
                Me.C1IMAGE.AllowDelete = True
                Me.C1TALLY.AllowAddNew = True
                For i = 0 To j
                    Me.C1TALLY.Row = Me.C1TALLY.Row + 1
                    Me.C1TALLY.Columns.Item("CONTAINER_NO").Value = Me.C1IMAGE.Columns.Item("CONTAINER_NO").Text
                    Me.C1TALLY.Columns.Item("SIZE_CON").Value = Me.C1IMAGE.Columns.Item("SIZE_CON").Text
                    Me.C1TALLY.Columns.Item("FULLOREMPTY").Value = Me.C1IMAGE.Columns.Item("FULLOREMPTY").Text
                    Me.C1TALLY.Columns.Item("SEALNO").Value = Me.C1IMAGE.Columns.Item("SEALNO").Text
                    Me.C1TALLY.Columns.Item("BAYNO").Value = Me.C1IMAGE.Columns.Item("BAYNO").Text
                    Me.C1IMAGE.Row = Me.C1IMAGE.Row + 1
                Next
                Me.C1IMAGE.Row = 0
                For i = 0 To j
                    Me.C1IMAGE.Delete()
                    Me.C1IMAGE.Row = Me.C1IMAGE.Row + 1
                Next
                Me.C1IMAGE.Row = 0
                Call Txtseachbay_TextChanged(sender, e)
                Me.C1IMAGE.Refresh()
                Me.C1IMAGE.MoveFirst()
                C1TALLY.Refresh()
                Me.C1TALLY.MoveLast()
                Label1.Text = "计 " & ds_sub.Tables(0).Rows.Count + 1 & " 个"
                totalcount = ds_sub.Tables(0).Rows.Count + 1
            Else
                MsgBox("超过每张可打印箱数（30个），请调整！")
                Exit Sub
            End If
            Me.C1IMAGE.AllowDelete = False
            Me.C1TALLY.AllowAddNew = False
            BtADDALL.Enabled = False

        Catch ex As System.Exception
            MsgBox(ex.Message)
            Me.C1IMAGE.AllowDelete = False
            Me.C1TALLY.AllowAddNew = False
            Me.C1TALLY.MoveLast()
            Label1.Text = "计 " & Me.C1TALLY.Row + 1 & " 个"
            totalcount = Me.C1TALLY.Row + 1
        End Try
    End Sub

    Private Sub BtDELETEALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDELETEALL.Click
        Dim i As Integer
        Dim j As Integer
        Dim q As Integer

        Try
            Me.C1TALLY.MoveLast()
            j = Me.C1TALLY.Row
            Me.C1IMAGE.AllowAddNew = True
            Me.C1TALLY.AllowDelete = True
            Me.C1IMAGE.MoveLast()
            Me.C1TALLY.Row = 0
            For i = 0 To j
                Me.C1IMAGE.Row = Me.C1IMAGE.Row + 1
                Me.C1IMAGE.Columns.Item("CONTAINER_NO").Value = Me.C1TALLY.Columns.Item("CONTAINER_NO").Text
                Me.C1IMAGE.Columns.Item("SIZE_CON").Value = Me.C1TALLY.Columns.Item("SIZE_CON").Text
                Me.C1IMAGE.Columns.Item("FULLOREMPTY").Value = Me.C1TALLY.Columns.Item("FULLOREMPTY").Text
                Me.C1IMAGE.Columns.Item("SEALNO").Value = Me.C1TALLY.Columns.Item("SEALNO").Text
                Me.C1IMAGE.Columns.Item("BAYNO").Value = Me.C1TALLY.Columns.Item("BAYNO").Text
                Me.C1IMAGE.Columns.Item("BAYCOL").Value = Mid(IIf(Len(Trim(Me.C1TALLY.Columns.Item("BAYNO").Text)) = 6, Trim(Me.C1TALLY.Columns.Item("BAYNO").Text), "      "), 3, 2)
                Me.C1IMAGE.Columns.Item("BAYROW").Value = Mid(IIf(Len(Trim(Me.C1TALLY.Columns.Item("BAYNO").Text)) = 6, Trim(Me.C1TALLY.Columns.Item("BAYNO").Text), "      "), 5, 2)

                Me.C1TALLY.Row = Me.C1TALLY.Row + 1
            Next
            Me.C1TALLY.Row = 0
            For i = 0 To j
                Me.C1TALLY.Delete()
                Me.C1TALLY.Row = Me.C1TALLY.Row + 1
            Next
            Me.C1TALLY.Row = 0
            Label1.Text = "计  0  个"
            totalcount = 0
            Call Txtseachbay_TextChanged(sender, e)
            Me.C1IMAGE.Refresh()
            Me.C1IMAGE.MoveFirst()
            C1TALLY.Refresh()
            Me.C1IMAGE.AllowAddNew = False
            Me.C1TALLY.AllowDelete = False
            BtDELETEALL.Enabled = False
        Catch ex As System.Exception
            MsgBox(ex.Message)
            Me.C1IMAGE.AllowAddNew = False
            Me.C1TALLY.AllowDelete = False
            Me.C1TALLY.MoveLast()
            Label1.Text = "计 " & ds_sub.Tables(0).Rows.Count & " 个"
            totalcount = ds_sub.Tables(0).Rows.Count

        End Try
    End Sub

    Private Sub C1IMAGE_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles C1IMAGE.MouseUp
        If Me.C1IMAGE.SelectedRows.Count > 0 Then
            BtADD.Enabled = True
        End If
    End Sub

    Private Sub C1TALLY_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles C1TALLY.MouseUp
        If Me.C1TALLY.SelectedRows.Count > 0 Then
            BtDELETE.Enabled = True
        End If
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim others As String
        Dim bayitem(30) As String
        Dim i As Integer
        Dim readbay As String
        Dim j As Integer
        Dim q As Integer
        Dim x1 As Integer
        Dim x2 As Integer
        Dim x3 As Integer
        Dim x4 As Integer
        Dim x5 As Integer
        Dim x6 As Integer
        Dim x As Integer


        Try
            RecordExcelProcess()
            If totalcount > 0 Then
                Me.C1TALLY.Focus()
                Me.C1TALLY.MoveFirst()
                Me.C1TALLY.MoveNext()
                Me.C1TALLY.MoveFirst()
                readbay = ""
                For j = 0 To 29
                    bayitem(j) = "0"
                Next
                For i = 0 To totalcount - 1
                    q = 0
                    For j = 0 To 29
                        If bayitem(j) <> 0 Then
                            q = j + 1
                        Else
                            Exit For
                        End If
                    Next


                    If Len(Trim(ds_sub.Tables(0).Rows(i).Item("bayno"))) < 2 Then
                        readbay = "0"
                    Else
                        readbay = IIf(IsDBNull(Mid(ds_sub.Tables(0).Rows(i).Item("bayno"), 1, 2)), "", Mid(ds_sub.Tables(0).Rows(i).Item("bayno"), 1, 2))
                    End If
                    For j = 0 To 29
                        If bayitem(j) = readbay Then
                            Exit For
                        End If
                    Next
                    'MsgBox(j)
                    If j = 30 Then
                        bayitem(q) = readbay
                    End If
                Next
                readbay = ""
                For j = 0 To 29
                    If bayitem(j) <> 0 Then
                        readbay = readbay + "/" + bayitem(j)
                    Else
                        Exit For
                    End If
                Next
                If Len(readbay) > 2 Then
                    readbay = Mid(readbay, 2, Len(readbay))
                End If
                If totalcount > 30 Then
                    MsgBox("箱数超过30,请检查!")
                    Exit Sub
                Else
                    If RBCHA.Checked = True Then
                        pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
                        pathstr = substr(pathstr)
                        FileCopy(pathstr + "Report_zlp3.xls", pathstr + "Report.xls")
                        Filepath = pathstr + "report.xls"
                        xlapp = CType(CreateObject("excel.application"), Excel.Application)
                        xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
                        xlsheet = CType(xlbook.Worksheets("理箱单（C）"), Excel.Worksheet)
                        xlapp.DisplayAlerts = False
                        xlsheet.Application.Visible = False
                        xlsheet.Select()

                        xlsheet.Cells(11, 2) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")))
                        xlsheet.Cells(11, 5) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("Voyage"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("Voyage")))
                        xlsheet.Cells(11, 9) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("berthno"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("berthno")))

                        xlsheet.Cells(11, 14) = readbay

                        If totalcount <= 15 Then
                            For row = 0 To totalcount - 1
                                xlsheet.Cells(16 + row, 1) = ds_sub.Tables(0).Rows(row)("CONTAINER_NO")
                                xlsheet.Cells(16 + row, 3) = ds_sub.Tables(0).Rows(row)("SEALNO")
                                xlsheet.Cells(16 + row, 4) = ds_sub.Tables(0).Rows(row)("SIZE_CON")
                                xlsheet.Cells(16 + row, 5) = ds_sub.Tables(0).Rows(row)("FULLOREMPTY")
                                If ds_sub.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                                    xlsheet.Cells(16 + row, 3) = "────"
                                End If
                            Next row
                        ElseIf totalcount > 15 And totalcount <= 30 Then
                            For row = 0 To 14
                                xlsheet.Cells(16 + row, 1) = ds_sub.Tables(0).Rows(row)("CONTAINER_NO")
                                xlsheet.Cells(16 + row, 3) = ds_sub.Tables(0).Rows(row)("SEALNO")
                                xlsheet.Cells(16 + row, 4) = ds_sub.Tables(0).Rows(row)("SIZE_CON")
                                xlsheet.Cells(16 + row, 5) = ds_sub.Tables(0).Rows(row)("FULLOREMPTY")
                                If ds_sub.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                                    xlsheet.Cells(16 + row, 3) = "────"
                                End If
                            Next row
                            For row = 15 To totalcount - 1
                                xlsheet.Cells(1 + row, 7) = ds_sub.Tables(0).Rows(row)("CONTAINER_NO")
                                xlsheet.Cells(1 + row, 11) = ds_sub.Tables(0).Rows(row)("SEALNO")
                                xlsheet.Cells(1 + row, 13) = ds_sub.Tables(0).Rows(row)("SIZE_CON")
                                xlsheet.Cells(1 + row, 15) = ds_sub.Tables(0).Rows(row)("FULLOREMPTY")
                                If ds_sub.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                                    xlsheet.Cells(1 + row, 11) = "────"
                                End If
                            Next row
                        End If
                        x1 = 0
                        x2 = 0
                        x3 = 0
                        x4 = 0

                        For i = 0 To ds_sub.Tables(0).Rows.Count - 1
                            If ds_sub.Tables(0).Rows(i)("SIZE_CON") = 20 And ds_sub.Tables(0).Rows(i)("FULLOREMPTY") = "F" Then
                                x1 += 1
                            End If
                            If ds_sub.Tables(0).Rows(i)("SIZE_CON") = 20 And ds_sub.Tables(0).Rows(i)("FULLOREMPTY") = "E" Then
                                x2 += 1
                            End If
                            If ds_sub.Tables(0).Rows(i)("SIZE_CON") = 40 And ds_sub.Tables(0).Rows(i)("FULLOREMPTY") = "F" Then
                                x3 += 1
                            End If
                            If ds_sub.Tables(0).Rows(i)("SIZE_CON") = 40 And ds_sub.Tables(0).Rows(i)("FULLOREMPTY") = "E" Then
                                x4 += 1
                            End If
                            If ds_sub.Tables(0).Rows(i)("SIZE_CON") = 45 And ds_sub.Tables(0).Rows(i)("FULLOREMPTY") = "F" Then
                                x5 += 1
                            End If
                            If ds_sub.Tables(0).Rows(i)("SIZE_CON") = 45 And ds_sub.Tables(0).Rows(i)("FULLOREMPTY") = "E" Then
                                x6 += 1
                            End If
                        Next
                        xlsheet.Cells(32, 12) = x1
                        xlsheet.Cells(33, 12) = x2
                        xlsheet.Cells(34, 12) = x3
                        xlsheet.Cells(35, 12) = x4
                        xlsheet.Cells(32, 15) = x5
                        xlsheet.Cells(33, 15) = x6
                        xlsheet.Cells(35, 15) = totalcount
                        'xlsheet.PrintPreview()
                        xlsheet.PrintOut()
                    Else
                        pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
                        pathstr = substr(pathstr)
                        FileCopy(pathstr + "Report_zlp3.xls", pathstr + "Report.xls")
                        Filepath = pathstr + "report.xls"
                        xlapp = CType(CreateObject("excel.application"), Excel.Application)
                        xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
                        xlsheet = CType(xlbook.Worksheets("理箱单（E）"), Excel.Worksheet)
                        xlapp.DisplayAlerts = False
                        xlsheet.Application.Visible = False
                        xlsheet.Select()

                        xlsheet.Cells(11, 2) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")))
                        xlsheet.Cells(11, 5) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("Voyage"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("Voyage")))
                        xlsheet.Cells(11, 9) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("berthno"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("berthno")))

                        xlsheet.Cells(11, 14) = readbay

                        If totalcount <= 15 Then
                            For row = 0 To totalcount - 1
                                xlsheet.Cells(16 + row, 1) = ds_sub.Tables(0).Rows(row)("CONTAINER_NO")
                                xlsheet.Cells(16 + row, 3) = ds_sub.Tables(0).Rows(row)("SEALNO")
                                xlsheet.Cells(16 + row, 4) = ds_sub.Tables(0).Rows(row)("SIZE_CON")
                                xlsheet.Cells(16 + row, 5) = ds_sub.Tables(0).Rows(row)("FULLOREMPTY")
                                If ds_sub.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                                    xlsheet.Cells(16 + row, 3) = "────"
                                End If
                            Next row
                        ElseIf totalcount > 15 And totalcount <= 30 Then
                            For row = 0 To 14
                                xlsheet.Cells(16 + row, 1) = ds_sub.Tables(0).Rows(row)("CONTAINER_NO")
                                xlsheet.Cells(16 + row, 3) = ds_sub.Tables(0).Rows(row)("SEALNO")
                                xlsheet.Cells(16 + row, 4) = ds_sub.Tables(0).Rows(row)("SIZE_CON")
                                xlsheet.Cells(16 + row, 5) = ds_sub.Tables(0).Rows(row)("FULLOREMPTY")
                                If ds_sub.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                                    xlsheet.Cells(16 + row, 3) = "────"
                                End If
                            Next row
                            For row = 15 To totalcount - 1
                                xlsheet.Cells(1 + row, 7) = ds_sub.Tables(0).Rows(row)("CONTAINER_NO")
                                xlsheet.Cells(1 + row, 11) = ds_sub.Tables(0).Rows(row)("SEALNO")
                                xlsheet.Cells(1 + row, 13) = ds_sub.Tables(0).Rows(row)("SIZE_CON")
                                xlsheet.Cells(1 + row, 15) = ds_sub.Tables(0).Rows(row)("FULLOREMPTY")
                                If ds_sub.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                                    xlsheet.Cells(1 + row, 11) = "────"
                                End If
                            Next row
                        End If
                        x1 = 0
                        x2 = 0
                        x3 = 0
                        x4 = 0
                        x5 = 0
                        x6 = 0
                        For i = 0 To ds_sub.Tables(0).Rows.Count - 1
                            If ds_sub.Tables(0).Rows(i)("SIZE_CON") = 20 And ds_sub.Tables(0).Rows(i)("FULLOREMPTY") = "F" Then
                                x1 += 1
                            End If
                            If ds_sub.Tables(0).Rows(i)("SIZE_CON") = 20 And ds_sub.Tables(0).Rows(i)("FULLOREMPTY") = "E" Then
                                x2 += 1
                            End If
                            If ds_sub.Tables(0).Rows(i)("SIZE_CON") = 40 And ds_sub.Tables(0).Rows(i)("FULLOREMPTY") = "F" Then
                                x3 += 1
                            End If
                            If ds_sub.Tables(0).Rows(i)("SIZE_CON") = 40 And ds_sub.Tables(0).Rows(i)("FULLOREMPTY") = "E" Then
                                x4 += 1
                            End If
                            If ds_sub.Tables(0).Rows(i)("SIZE_CON") = 45 And ds_sub.Tables(0).Rows(i)("FULLOREMPTY") = "F" Then
                                x5 += 1
                            End If
                            If ds_sub.Tables(0).Rows(i)("SIZE_CON") = 45 And ds_sub.Tables(0).Rows(i)("FULLOREMPTY") = "E" Then
                                x6 += 1
                            End If
                        Next
                        xlsheet.Cells(32, 12) = x1
                        xlsheet.Cells(33, 12) = x2
                        xlsheet.Cells(34, 12) = x3
                        xlsheet.Cells(35, 12) = x4
                        xlsheet.Cells(32, 15) = x5
                        xlsheet.Cells(33, 15) = x6
                        xlsheet.Cells(35, 15) = totalcount
                        ' xlsheet.PrintPreview()
                        xlsheet.PrintOut()
                    End If
                End If
                'ds_sub.Tables(0).Rows.Clear()
                'Label1.Text = "计 0 个"
                ds_sub.Reset()
                dw_sub = Updatedata(sqlda_sub, "select CONTAINER_NO,SEALNO,SIZE_CON,FULLOREMPTY,BAYNO from CON_TALLY_DETAIL where CON_TALLY_LIST_ID='0'", ds_sub)
                C1TALLY.DataSource = ds_sub.Tables(0).DefaultView

                Me.C1TALLY.Columns.Item("BAYNO").Caption = "贝位号"
                Me.C1TALLY.Columns.Item("CONTAINER_NO").Caption = "箱号"
                Me.C1TALLY.Columns.Item("SIZE_CON").Caption = "尺寸"
                Me.C1TALLY.Columns.Item("SEALNO").Caption = "铅封号"
                Me.C1TALLY.Columns.Item("FULLOREMPTY").Caption = "空/重"

                Me.C1TALLY.Splits(0).DisplayColumns.Item("CONTAINER_NO").Width = 90
                Me.C1TALLY.Splits(0).DisplayColumns.Item("SEALNO").Width = 100
                Me.C1TALLY.Splits(0).DisplayColumns.Item("BAYNO").Width = 50
                Me.C1TALLY.Splits(0).DisplayColumns.Item("FULLOREMPTY").Width = 40
                Me.C1TALLY.Splits(0).DisplayColumns.Item("SIZE_CON").Width = 30
                Me.C1IMAGE.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
                Me.C1TALLY.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
                Me.C1TALLY.Refresh()
                Me.C1TALLY.MoveLast()

                Label1.Text = "计 " & ds_sub.Tables(0).Rows.Count & " 个"
                totalcount = 0
            Else
                MsgBox("请选择箱子！")
            End If
            KillExcelProcess()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub RBCOL_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RBCOL.CheckedChanged
        Call Txtseachbay_TextChanged(sender, e)
    End Sub

    Private Sub RBROW_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RBROW.CheckedChanged
        Call Txtseachbay_TextChanged(sender, e)
    End Sub

    Private Sub C1IMAGE_SelChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles C1IMAGE.SelChange
        Label2.Text = C1IMAGE.SelectedRows.Count
    End Sub

    Private Sub RBASC_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RBASC.CheckedChanged
        Call Txtseachbay_TextChanged(sender, e)
    End Sub

    Private Sub RBDESC_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RBDESC.CheckedChanged
        Call Txtseachbay_TextChanged(sender, e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Len(Trim(Txtseachbay.Text)) > 0 Then
                If RBCOL.Checked = True Then
                    If RBDESC.Checked = True Then
                        ds_bay.Reset()
                        dw_bay = Getdata("select CONTAINER_NO,BAYNO,SIZE_CON,FULLOREMPTY,SEALNO,substring(ISNULL(bayno,'      '),3,2) as baycol,substring(ISNULL(bayno,'      '),5,2)as bayrow from VIEWCON_TALLY_HATCH where ship_id='" & Ship_ID & "' and bayno like '" & Trim(Txtseachbay.Text) & "%' order by baycol desc", ds_bay)
                    Else
                        ds_bay.Reset()
                        dw_bay = Getdata("select CONTAINER_NO,BAYNO,SIZE_CON,FULLOREMPTY,SEALNO,substring(ISNULL(bayno,'      '),3,2) as baycol,substring(ISNULL(bayno,'      '),5,2)as bayrow from VIEWCON_TALLY_HATCH where ship_id='" & Ship_ID & "' and bayno like '" & Trim(Txtseachbay.Text) & "%' order by baycol asc", ds_bay)
                    End If
                ElseIf RBROW.Checked = True Then
                    If RBDESC.Checked = True Then
                        ds_bay.Reset()
                        dw_bay = Getdata("select CONTAINER_NO,BAYNO,SIZE_CON,FULLOREMPTY,SEALNO,substring(ISNULL(bayno,'      '),3,2) as baycol,substring(ISNULL(bayno,'      '),5,2)as bayrow from VIEWCON_TALLY_HATCH where ship_id='" & Ship_ID & "' and bayno like '" & Trim(Txtseachbay.Text) & "%' order by bayrow desc", ds_bay)
                    Else
                        ds_bay.Reset()
                        dw_bay = Getdata("select CONTAINER_NO,BAYNO,SIZE_CON,FULLOREMPTY,SEALNO,substring(ISNULL(bayno,'      '),3,2) as baycol,substring(ISNULL(bayno,'      '),5,2)as bayrow from VIEWCON_TALLY_HATCH where ship_id='" & Ship_ID & "' and bayno like '" & Trim(Txtseachbay.Text) & "%' order by bayrow asc", ds_bay)
                    End If
                Else
                    If RBDESC.Checked = True Then
                        ds_bay.Reset()
                        dw_bay = Getdata("select CONTAINER_NO,BAYNO,SIZE_CON,FULLOREMPTY,SEALNO,substring(ISNULL(bayno,'      '),3,2) as baycol,substring(ISNULL(bayno,'      '),5,2)as bayrow from VIEWCON_TALLY_HATCH where ship_id='" & Ship_ID & "' and bayno like '" & Trim(Txtseachbay.Text) & "%' order by bayno desc", ds_bay)
                    Else
                        ds_bay.Reset()
                        dw_bay = Getdata("select CONTAINER_NO,BAYNO,SIZE_CON,FULLOREMPTY,SEALNO,substring(ISNULL(bayno,'      '),3,2) as baycol,substring(ISNULL(bayno,'      '),5,2)as bayrow from VIEWCON_TALLY_HATCH where ship_id='" & Ship_ID & "' and bayno like '" & Trim(Txtseachbay.Text) & "%' order by bayno asc", ds_bay)
                    End If
                End If
                If RBCHA.Checked = True Then
                    Call bay_cha()
                Else
                    Call bay_eng()
                End If
            Else
                MsgBox("请输入贝号！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bay_cha()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim i As Integer
        Dim j As Integer
        Dim q As Integer
        Dim k As Integer
        Dim x1 As Integer
        Dim x2 As Integer
        Dim x3 As Integer
        Dim x4 As Integer
        Dim x5 As Integer
        Dim x6 As Integer
        Try
            If ds_bay.Tables(0).Rows.Count > 0 Then

                If ds_bay.Tables(0).Rows.Count <= 30 Then  '单张
                    RecordExcelProcess()
                    pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
                    pathstr = substr(pathstr)
                    FileCopy(pathstr + "Report_zlp3.xls", pathstr + "Report.xls")
                    Filepath = pathstr + "report.xls"
                    xlapp = CType(CreateObject("excel.application"), Excel.Application)
                    xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
                    xlsheet = CType(xlbook.Worksheets("理箱单（C）"), Excel.Worksheet)
                    xlapp.DisplayAlerts = False
                    xlsheet.Application.Visible = False
                    xlsheet.Select()

                    xlsheet.Cells(11, 2) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")))
                    xlsheet.Cells(11, 5) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("Voyage"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("Voyage")))
                    xlsheet.Cells(11, 9) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("berthno"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("berthno")))

                    xlsheet.Cells(11, 14) = Trim(Txtseachbay.Text)

                    If ds_bay.Tables(0).Rows.Count <= 15 Then
                        For row = 0 To ds_bay.Tables(0).Rows.Count - 1
                            xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row)("CONTAINER_NO")
                            xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row)("SEALNO")
                            xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row)("SIZE_CON")
                            xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row)("FULLOREMPTY")
                            If ds_bay.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                                xlsheet.Cells(16 + row, 3) = "────"
                            End If
                        Next row
                    ElseIf ds_bay.Tables(0).Rows.Count > 15 And ds_bay.Tables(0).Rows.Count <= 30 Then
                        For row = 0 To 14
                            xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row)("CONTAINER_NO")
                            xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row)("SEALNO")
                            xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row)("SIZE_CON")
                            xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row)("FULLOREMPTY")
                            If ds_bay.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                                xlsheet.Cells(16 + row, 3) = "────"
                            End If
                        Next row
                        For row = 15 To ds_bay.Tables(0).Rows.Count - 1
                            xlsheet.Cells(1 + row, 7) = ds_bay.Tables(0).Rows(row)("CONTAINER_NO")
                            xlsheet.Cells(1 + row, 11) = ds_bay.Tables(0).Rows(row)("SEALNO")
                            xlsheet.Cells(1 + row, 13) = ds_bay.Tables(0).Rows(row)("SIZE_CON")
                            xlsheet.Cells(1 + row, 15) = ds_bay.Tables(0).Rows(row)("FULLOREMPTY")
                            If ds_bay.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                                xlsheet.Cells(1 + row, 11) = "────"
                            End If
                        Next row
                    End If
                    x1 = 0
                    x2 = 0
                    x3 = 0
                    x4 = 0
                    x5 = 0
                    x6 = 0
                    For k = 0 To ds_bay.Tables(0).Rows.Count - 1
                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                            x1 += 1
                        End If
                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                            x2 += 1
                        End If
                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                            x3 += 1
                        End If
                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                            x4 += 1
                        End If
                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                            x5 += 1
                        End If
                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                            x6 += 1
                        End If
                    Next
                    xlsheet.Cells(32, 12) = x1
                    xlsheet.Cells(33, 12) = x2
                    xlsheet.Cells(34, 12) = x3
                    xlsheet.Cells(35, 12) = x4
                    xlsheet.Cells(32, 15) = x5
                    xlsheet.Cells(33, 15) = x6
                    xlsheet.Cells(35, 15) = ds_bay.Tables(0).Rows.Count


                    'xlsheet.PrintPreview()
                    xlsheet.PrintOut()
                    KillExcelProcess()
                ElseIf ds_bay.Tables(0).Rows.Count > 30 Then '多张
                    j = ds_bay.Tables(0).Rows.Count / 30    '整张J张
                    q = ds_bay.Tables(0).Rows.Count - j * 30 '余数
                    RecordExcelProcess()
                    pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
                    pathstr = substr(pathstr)
                    FileCopy(pathstr + "Report_zlp3.xls", pathstr + "Report.xls")
                    Filepath = pathstr + "report.xls"
                    xlapp = CType(CreateObject("excel.application"), Excel.Application)
                    xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
                    For i = 0 To j - 1

                        If i = 0 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（C）1"), Excel.Worksheet)
                        End If
                        If i = 1 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（C）2"), Excel.Worksheet)
                        End If
                        If i = 2 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（C）3"), Excel.Worksheet)
                        End If
                        If i = 3 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（C）4"), Excel.Worksheet)
                        End If
                        If i = 4 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（C）5"), Excel.Worksheet)
                        End If
                        If i = 5 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（C）6"), Excel.Worksheet)
                        End If
                        If i = 6 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（C）7"), Excel.Worksheet)
                        End If
                        If i = 7 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（C）8"), Excel.Worksheet)
                        End If
                        If i = 8 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（C）9"), Excel.Worksheet)
                        End If
                        If i = 9 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（C）10"), Excel.Worksheet)
                        End If
                        If i = 10 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（C）11"), Excel.Worksheet)
                        End If
                        If i = 11 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（C）12"), Excel.Worksheet)
                        End If

                        xlapp.DisplayAlerts = False
                        xlsheet.Application.Visible = False
                        xlsheet.Select()

                        xlsheet.Cells(11, 2) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")))
                        xlsheet.Cells(11, 5) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("Voyage"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("Voyage")))
                        xlsheet.Cells(11, 9) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("berthno"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("berthno")))

                        xlsheet.Cells(11, 14) = Trim(Txtseachbay.Text)

                        For row = 0 To 14
                            xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row + i * 30)("CONTAINER_NO")
                            xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row + i * 30)("SEALNO")
                            xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row + i * 30)("SIZE_CON")
                            xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row + i * 30)("FULLOREMPTY")
                            If ds_bay.Tables(0).Rows(row + i * 30)("FULLOREMPTY") = "E" Then
                                xlsheet.Cells(16 + row, 3) = "────"
                            End If
                        Next row
                        For row = 15 To 29
                            xlsheet.Cells(1 + row, 7) = ds_bay.Tables(0).Rows(row + i * 30)("CONTAINER_NO")
                            xlsheet.Cells(1 + row, 11) = ds_bay.Tables(0).Rows(row + i * 30)("SEALNO")
                            xlsheet.Cells(1 + row, 13) = ds_bay.Tables(0).Rows(row + i * 30)("SIZE_CON")
                            xlsheet.Cells(1 + row, 15) = ds_bay.Tables(0).Rows(row + i * 30)("FULLOREMPTY")
                            If ds_bay.Tables(0).Rows(row + i * 30)("FULLOREMPTY") = "E" Then
                                xlsheet.Cells(1 + row, 11) = "────"
                            End If
                        Next row
                        x1 = 0
                        x2 = 0
                        x3 = 0
                        x4 = 0
                        x5 = 0
                        x6 = 0
                        For k = i * 30 To i * 30 + 29
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                                x1 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                                x2 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                                x3 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                                x4 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                                x5 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                                x6 += 1
                            End If
                        Next k
                        xlsheet.Cells(32, 12) = x1
                        xlsheet.Cells(33, 12) = x2
                        xlsheet.Cells(34, 12) = x3
                        xlsheet.Cells(35, 12) = x4
                        xlsheet.Cells(32, 15) = x5
                        xlsheet.Cells(33, 15) = x6
                        xlsheet.Cells(35, 15) = "30"
                        'xlsheet.PrintPreview()
                        xlsheet.PrintOut()

                    Next i
                    'KillExcelProcess()
                    If q > 0 Then
                        'RecordExcelProcess()
                        'pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
                        'pathstr = substr(pathstr)
                        'FileCopy(pathstr + "Report_zlp3.xls", pathstr + "Report.xls")
                        'Filepath = pathstr + "report.xls"
                        'xlapp = CType(CreateObject("excel.application"), Excel.Application)
                        'xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
                        xlsheet = CType(xlbook.Worksheets("理箱单（C）13"), Excel.Worksheet)
                        xlapp.DisplayAlerts = False
                        xlsheet.Application.Visible = False
                        xlsheet.Select()

                        xlsheet.Cells(11, 2) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")))
                        xlsheet.Cells(11, 5) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("Voyage"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("Voyage")))
                        xlsheet.Cells(11, 9) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("berthno"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("berthno")))

                        xlsheet.Cells(11, 14) = Trim(Txtseachbay.Text)

                        If q <= 15 Then
                            For row = 0 To q - 1
                                xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row + j * 30)("CONTAINER_NO")
                                xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row + j * 30)("SEALNO")
                                xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row + j * 30)("SIZE_CON")
                                xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY")
                                If ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY") = "E" Then
                                    xlsheet.Cells(16 + row, 3) = "────"
                                End If
                            Next row
                        ElseIf q > 15 And q < 30 Then
                            For row = 0 To 14
                                xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row + j * 30)("CONTAINER_NO")
                                xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row + j * 30)("SEALNO")
                                xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row + j * 30)("SIZE_CON")
                                xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY")
                                If ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY") = "E" Then
                                    xlsheet.Cells(16 + row, 3) = "────"
                                End If
                            Next row
                            For row = 15 To q - 1
                                xlsheet.Cells(1 + row, 7) = ds_bay.Tables(0).Rows(row + j * 30)("CONTAINER_NO")
                                xlsheet.Cells(1 + row, 11) = ds_bay.Tables(0).Rows(row + j * 30)("SEALNO")
                                xlsheet.Cells(1 + row, 13) = ds_bay.Tables(0).Rows(row + j * 30)("SIZE_CON")
                                xlsheet.Cells(1 + row, 15) = ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY")
                                If ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY") = "E" Then
                                    xlsheet.Cells(1 + row, 11) = "────"
                                End If
                            Next row
                        End If
                        x1 = 0
                        x2 = 0
                        x3 = 0
                        x4 = 0
                        x5 = 0
                        x6 = 0
                        For k = ds_bay.Tables(0).Rows.Count - q To ds_bay.Tables(0).Rows.Count - 1
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                                x1 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                                x2 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                                x3 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                                x4 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                                x5 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                                x6 += 1
                            End If
                        Next k
                        xlsheet.Cells(32, 12) = x1
                        xlsheet.Cells(33, 12) = x2
                        xlsheet.Cells(34, 12) = x3
                        xlsheet.Cells(35, 12) = x4
                        xlsheet.Cells(32, 15) = x5
                        xlsheet.Cells(33, 15) = x6
                        xlsheet.Cells(35, 15) = q
                        'xlsheet.PrintPreview()
                        xlsheet.PrintOut()

                    End If
                    KillExcelProcess()
                End If
            Else
                MsgBox("该贝上没有箱，请查实！")
            End If
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub

    Private Sub bay_eng()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim i As Integer
        Dim j As Integer
        Dim q As Integer
        Dim k As Integer
        Dim x1 As Integer
        Dim x2 As Integer
        Dim x3 As Integer
        Dim x4 As Integer
        Dim x5 As Integer
        Dim x6 As Integer
        Try
            If ds_bay.Tables(0).Rows.Count > 0 Then

                If ds_bay.Tables(0).Rows.Count <= 30 Then  '单张
                    RecordExcelProcess()
                    pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
                    pathstr = substr(pathstr)
                    FileCopy(pathstr + "Report_zlp3.xls", pathstr + "Report.xls")
                    Filepath = pathstr + "report.xls"
                    xlapp = CType(CreateObject("excel.application"), Excel.Application)
                    xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
                    xlsheet = CType(xlbook.Worksheets("理箱单（E）"), Excel.Worksheet)
                    xlapp.DisplayAlerts = False
                    xlsheet.Application.Visible = False
                    xlsheet.Select()

                    xlsheet.Cells(11, 2) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")))
                    xlsheet.Cells(11, 5) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("Voyage"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("Voyage")))
                    xlsheet.Cells(11, 9) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("berthno"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("berthno")))

                    xlsheet.Cells(11, 14) = Trim(Txtseachbay.Text)

                    If ds_bay.Tables(0).Rows.Count <= 15 Then
                        For row = 0 To ds_bay.Tables(0).Rows.Count - 1
                            xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row)("CONTAINER_NO")
                            xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row)("SEALNO")
                            xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row)("SIZE_CON")
                            xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row)("FULLOREMPTY")
                            If ds_bay.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                                xlsheet.Cells(16 + row, 3) = "────"
                            End If
                        Next row
                    ElseIf ds_bay.Tables(0).Rows.Count > 15 And ds_bay.Tables(0).Rows.Count <= 30 Then
                        For row = 0 To 14
                            xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row)("CONTAINER_NO")
                            xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row)("SEALNO")
                            xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row)("SIZE_CON")
                            xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row)("FULLOREMPTY")
                            If ds_bay.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                                xlsheet.Cells(16 + row, 3) = "────"
                            End If
                        Next row
                        For row = 15 To ds_bay.Tables(0).Rows.Count - 1
                            xlsheet.Cells(1 + row, 7) = ds_bay.Tables(0).Rows(row)("CONTAINER_NO")
                            xlsheet.Cells(1 + row, 11) = ds_bay.Tables(0).Rows(row)("SEALNO")
                            xlsheet.Cells(1 + row, 13) = ds_bay.Tables(0).Rows(row)("SIZE_CON")
                            xlsheet.Cells(1 + row, 15) = ds_bay.Tables(0).Rows(row)("FULLOREMPTY")
                            If ds_bay.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                                xlsheet.Cells(1 + row, 11) = "────"
                            End If
                        Next row
                    End If
                    x1 = 0
                    x2 = 0
                    x3 = 0
                    x4 = 0
                    x5 = 0
                    x6 = 0
                    For k = 0 To ds_bay.Tables(0).Rows.Count - 1
                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                            x1 += 1
                        End If
                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                            x2 += 1
                        End If
                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                            x3 += 1
                        End If
                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                            x4 += 1
                        End If
                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                            x5 += 1
                        End If
                        If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                            x6 += 1
                        End If
                    Next
                    xlsheet.Cells(32, 12) = x1
                    xlsheet.Cells(33, 12) = x2
                    xlsheet.Cells(34, 12) = x3
                    xlsheet.Cells(35, 12) = x4
                    xlsheet.Cells(32, 15) = x5
                    xlsheet.Cells(33, 15) = x6
                    xlsheet.Cells(35, 15) = ds_bay.Tables(0).Rows.Count
                    'xlsheet.PrintPreview()
                    xlsheet.PrintOut()
                    KillExcelProcess()
                ElseIf ds_bay.Tables(0).Rows.Count > 30 Then '多张
                    j = ds_bay.Tables(0).Rows.Count / 30    '整张J张
                    q = ds_bay.Tables(0).Rows.Count - j * 30 '余数
                    RecordExcelProcess()
                    pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
                    pathstr = substr(pathstr)
                    FileCopy(pathstr + "Report_zlp3.xls", pathstr + "Report.xls")
                    Filepath = pathstr + "report.xls"
                    xlapp = CType(CreateObject("excel.application"), Excel.Application)
                    xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
                    For i = 0 To j - 1

                        If i = 0 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（E）1"), Excel.Worksheet)
                        End If
                        If i = 1 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（E）2"), Excel.Worksheet)
                        End If
                        If i = 2 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（E）3"), Excel.Worksheet)
                        End If
                        If i = 3 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（E）4"), Excel.Worksheet)
                        End If
                        If i = 4 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（E）5"), Excel.Worksheet)
                        End If
                        If i = 5 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（E）6"), Excel.Worksheet)
                        End If
                        If i = 6 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（E）7"), Excel.Worksheet)
                        End If
                        If i = 7 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（E）8"), Excel.Worksheet)
                        End If
                        If i = 8 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（E）9"), Excel.Worksheet)
                        End If
                        If i = 9 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（E）10"), Excel.Worksheet)
                        End If
                        If i = 10 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（E）11"), Excel.Worksheet)
                        End If
                        If i = 11 Then
                            xlsheet = CType(xlbook.Worksheets("理箱单（E）12"), Excel.Worksheet)
                        End If

                        xlapp.DisplayAlerts = False
                        xlsheet.Application.Visible = False
                        xlsheet.Select()

                        xlsheet.Cells(11, 2) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")))
                        xlsheet.Cells(11, 5) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("Voyage"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("Voyage")))
                        xlsheet.Cells(11, 9) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("berthno"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("berthno")))

                        xlsheet.Cells(11, 14) = Trim(Txtseachbay.Text)

                        For row = 0 To 14
                            xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row + i * 30)("CONTAINER_NO")
                            xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row + i * 30)("SEALNO")
                            xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row + i * 30)("SIZE_CON")
                            xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row + i * 30)("FULLOREMPTY")
                            If ds_bay.Tables(0).Rows(row + i * 30)("FULLOREMPTY") = "E" Then
                                xlsheet.Cells(16 + row, 3) = "────"
                            End If
                        Next row
                        For row = 15 To 29
                            xlsheet.Cells(1 + row, 7) = ds_bay.Tables(0).Rows(row + i * 30)("CONTAINER_NO")
                            xlsheet.Cells(1 + row, 11) = ds_bay.Tables(0).Rows(row + i * 30)("SEALNO")
                            xlsheet.Cells(1 + row, 13) = ds_bay.Tables(0).Rows(row + i * 30)("SIZE_CON")
                            xlsheet.Cells(1 + row, 15) = ds_bay.Tables(0).Rows(row + i * 30)("FULLOREMPTY")
                            If ds_bay.Tables(0).Rows(row + i * 30)("FULLOREMPTY") = "E" Then
                                xlsheet.Cells(1 + row, 11) = "────"
                            End If
                        Next row
                        x1 = 0
                        x2 = 0
                        x3 = 0
                        x4 = 0
                        x5 = 0
                        x6 = 0
                        For k = i * 30 To i * 30 + 29
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                                x1 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                                x2 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                                x3 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                                x4 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                                x5 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                                x6 += 1
                            End If
                        Next k
                        xlsheet.Cells(32, 12) = x1
                        xlsheet.Cells(33, 12) = x2
                        xlsheet.Cells(34, 12) = x3
                        xlsheet.Cells(35, 12) = x4
                        xlsheet.Cells(32, 15) = x5
                        xlsheet.Cells(33, 15) = x6
                        xlsheet.Cells(35, 15) = "30"
                        'xlsheet.PrintPreview()
                        xlsheet.PrintOut()

                    Next i
                    'KillExcelProcess()
                    If q > 0 Then
                        'RecordExcelProcess()
                        'pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
                        'pathstr = substr(pathstr)
                        'FileCopy(pathstr + "Report_zlp3.xls", pathstr + "Report.xls")
                        'Filepath = pathstr + "report.xls"
                        'xlapp = CType(CreateObject("excel.application"), Excel.Application)
                        'xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
                        xlsheet = CType(xlbook.Worksheets("理箱单（E）13"), Excel.Worksheet)
                        xlapp.DisplayAlerts = False
                        xlsheet.Application.Visible = False
                        xlsheet.Select()

                        xlsheet.Cells(11, 2) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")))
                        xlsheet.Cells(11, 5) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("Voyage"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("Voyage")))
                        xlsheet.Cells(11, 9) = IIf(IsDBNull(Trim(ds_sship.Tables(0).Rows(0).Item("berthno"))), "", Trim(ds_sship.Tables(0).Rows(0).Item("berthno")))

                        xlsheet.Cells(11, 14) = Trim(Txtseachbay.Text)

                        If q <= 15 Then
                            For row = 0 To q - 1
                                xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row + j * 30)("CONTAINER_NO")
                                xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row + j * 30)("SEALNO")
                                xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row + j * 30)("SIZE_CON")
                                xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY")
                                If ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY") = "E" Then
                                    xlsheet.Cells(16 + row, 3) = "────"
                                End If
                            Next row
                        ElseIf q > 15 And q < 30 Then
                            For row = 0 To 14
                                xlsheet.Cells(16 + row, 1) = ds_bay.Tables(0).Rows(row + j * 30)("CONTAINER_NO")
                                xlsheet.Cells(16 + row, 3) = ds_bay.Tables(0).Rows(row + j * 30)("SEALNO")
                                xlsheet.Cells(16 + row, 4) = ds_bay.Tables(0).Rows(row + j * 30)("SIZE_CON")
                                xlsheet.Cells(16 + row, 5) = ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY")
                                If ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY") = "E" Then
                                    xlsheet.Cells(16 + row, 3) = "────"
                                End If
                            Next row
                            For row = 15 To q - 1
                                xlsheet.Cells(1 + row, 7) = ds_bay.Tables(0).Rows(row + j * 30)("CONTAINER_NO")
                                xlsheet.Cells(1 + row, 11) = ds_bay.Tables(0).Rows(row + j * 30)("SEALNO")
                                xlsheet.Cells(1 + row, 13) = ds_bay.Tables(0).Rows(row + j * 30)("SIZE_CON")
                                xlsheet.Cells(1 + row, 15) = ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY")
                                If ds_bay.Tables(0).Rows(row + j * 30)("FULLOREMPTY") = "E" Then
                                    xlsheet.Cells(1 + row, 11) = "────"
                                End If
                            Next row
                        End If
                        x1 = 0
                        x2 = 0
                        x3 = 0
                        x4 = 0
                        x5 = 0
                        x6 = 0
                        For k = ds_bay.Tables(0).Rows.Count - q To ds_bay.Tables(0).Rows.Count - 1
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                                x1 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 20 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                                x2 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                                x3 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 40 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                                x4 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "F" Then
                                x5 += 1
                            End If
                            If ds_bay.Tables(0).Rows(k)("SIZE_CON") = 45 And ds_bay.Tables(0).Rows(k)("FULLOREMPTY") = "E" Then
                                x6 += 1
                            End If
                        Next k
                        xlsheet.Cells(32, 12) = x1
                        xlsheet.Cells(33, 12) = x2
                        xlsheet.Cells(34, 12) = x3
                        xlsheet.Cells(35, 12) = x4
                        xlsheet.Cells(32, 15) = x5
                        xlsheet.Cells(33, 15) = x6
                        xlsheet.Cells(35, 15) = q
                        'xlsheet.PrintPreview()
                        xlsheet.PrintOut()

                    End If
                    KillExcelProcess()
                End If
            Else
                MsgBox("该贝上没有箱，请查实！")
            End If
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub

End Class
