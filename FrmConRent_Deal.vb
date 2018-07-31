Imports TALLY.DBControl
Public Class FrmConRent_Deal
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Public Shared strAgent As String = ""
    Public Shared mark As Boolean = False

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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents cbShipAgent As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConRent_Deal))
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cbShipAgent = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 0)
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
        Me.C1DBG.Size = New System.Drawing.Size(20, 73)
        Me.C1DBG.TabIndex = 11
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style14{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" & _
        "tyle9{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionH" & _
        "eight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><ClientRect>0, 0, 16, 69</ClientRect><BorderSide>0</B" & _
        "orderSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Edit" & _
        "or"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle p" & _
        "arent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><Gro" & _
        "upStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2""" & _
        " /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=" & _
        """Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelec" & _
        "torStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected""" & _
        " me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeV" & _
        "iew></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" " & _
        "me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=" & _
        """Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""S" & _
        "elected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highl" & _
        "ightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddR" & _
        "ow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""F" & _
        "ilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</ve" & _
        "rtSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</" & _
        "DefaultRecSelWidth><ClientArea>0, 0, 16, 69</ClientArea><PrintPageHeaderStyle pa" & _
        "rent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'cbShipAgent
        '
        Me.cbShipAgent.Location = New System.Drawing.Point(80, 10)
        Me.cbShipAgent.MaxDropDownItems = 20
        Me.cbShipAgent.Name = "cbShipAgent"
        Me.cbShipAgent.Size = New System.Drawing.Size(130, 20)
        Me.cbShipAgent.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "选择船代公司"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(110, 42)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 15
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(42, 42)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 14
        Me.btSave.Text = "确认"
        '
        'FrmConRent_Deal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(214, 73)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbShipAgent)
        Me.Controls.Add(Me.C1DBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConRent_Deal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "互租箱位信息 处理"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConRent_Deal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlShipAgent As String = "SELECT CODE_SHIP_AGENT, SHIPAGENT_CHA, SHIPAGENT_SHORT FROM CODE_SHIP_AGENT WHERE (Mark = '1') ORDER BY SHIPAGENT_SHORT"
        Dim dvShipAgent As New DataView()
        dvShipAgent = Filldata(sqlShipAgent)
        Me.cbShipAgent.DataSource = dvShipAgent
        Me.cbShipAgent.DisplayMember = "SHIPAGENT_SHORT"
        Me.cbShipAgent.ValueMember = "CODE_SHIP_AGENT"
        Me.C1DBG.Visible = False
        'Dim sqlContain As String = "SELECT CON_TALLY_DETAIL_ID, CONTAINER_NO, CODE_SHIP_AGENT FROM CON_TALLY_DETAIL WHERE CON_TALLY_LIST_ID IN (SELECT con_tally_list_id FROM con_tally_list WHERE ship_id = '" & Ship_ID & "')"
        'Dim dvContain As New DataView()
        'Me.C1DBG.DataSource = Updatedata(sqlda, sqlContain, ds)
        'Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        'Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
        'Me.C1DBG.Columns.Item("CODE_SHIP_AGENT").Caption = "船代公司"

        'Me.C1DBG.Columns("CODE_SHIP_AGENT").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
        'Me.C1DBG.Columns("CODE_SHIP_AGENT").ValueItems.Translate = True
        'Dim i As Short
        'For i = 0 To dvShipAgent.Count - 1
        '    Dim VI As New C1.Win.C1TrueDBGrid.ValueItem()
        '    VI.DisplayValue = dvShipAgent.Item(i)(1)
        '    VI.Value = dvShipAgent.Item(i)(0)
        '    Me.C1DBG.Columns.Item("CODE_SHIP_AGENT").ValueItems.Values.Add(VI)
        'Next

    End Sub

    Private Sub cbShipAgent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShipAgent.SelectedIndexChanged
        'Dim i As Short
        'For i = 0 To Me.C1DBG.SelectedRows.Count - 1
        '    Me.C1DBG.Row = Me.C1DBG.SelectedRows.Item(i)
        '    Me.C1DBG.Columns("CODE_SHIP_AGENT").Value = Me.cbShipAgent.SelectedValue
        'Next
        'Me.C1DBG.Refresh()

        'If TypeName(Me.cbShipAgent.SelectedValue) = "String" Then
        '    strAgent = Me.cbShipAgent.SelectedValue
        'End If
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        'sqlda.Update(ds)
        'Call Me.FrmConRent_Deal_Load(sender, e)

        strAgent = Me.cbShipAgent.SelectedValue
        mark = True
        Me.Close()
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        mark = False
        Me.Close()
    End Sub

    Private Sub cbShipAgent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbShipAgent.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btSave.Focus()
        End If
    End Sub
End Class
