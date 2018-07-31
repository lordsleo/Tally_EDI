Imports TALLY.DBControl
Public Class Frm_con_summary_unite
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
    Friend WithEvents c1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_con_summary_unite))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.c1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.btn_cancle = New System.Windows.Forms.Button()
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1dbg
        '
        Me.c1dbg.AllowFilter = True
        Me.c1dbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.c1dbg.AllowSort = True
        Me.c1dbg.CaptionHeight = 18
        Me.c1dbg.CollapseColor = System.Drawing.Color.Black
        Me.c1dbg.DataChanged = False
        Me.c1dbg.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1dbg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.c1dbg.ExpandColor = System.Drawing.Color.Black
        Me.c1dbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbg.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.c1dbg.Location = New System.Drawing.Point(0, 53)
        Me.c1dbg.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.c1dbg.Name = "c1dbg"
        Me.c1dbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbg.PreviewInfo.ZoomFactor = 75
        Me.c1dbg.PrintInfo.ShowOptionsDialog = False
        Me.c1dbg.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.c1dbg.RowDivider = GridLines1
        Me.c1dbg.RowHeight = 16
        Me.c1dbg.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1dbg.ScrollTips = False
        Me.c1dbg.Size = New System.Drawing.Size(448, 264)
        Me.c1dbg.TabIndex = 0
        Me.c1dbg.Text = "C1TrueDBGrid1"
        Me.c1dbg.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Borde" & _
        "r:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" Colu" & _
        "mnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" Def" & _
        "RecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0" & _
        ", 0, 444, 260</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "yout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 4" & _
        "44, 260</ClientArea></Blob>"
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(148, 12)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(65, 24)
        Me.btn_enter.TabIndex = 1
        Me.btn_enter.Text = "确定"
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(236, 12)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(65, 24)
        Me.btn_cancle.TabIndex = 1
        Me.btn_cancle.Text = "取消"
        '
        'Frm_con_summary_unite
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(448, 317)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_enter, Me.c1dbg, Me.btn_cancle})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_con_summary_unite"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "合并装货港"
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim k, h As Integer
    Dim portCount As Integer = 0
    Private Sub Frm_con_summary_unite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ExecSql("delete from code_loadport_unite where ship_id=" & Ship_ID)
        '  ExecSql("insert into code_loadport_unite(ship_id,code_load_port,port_cha,port_eng) select ship_id,code_load_port,port_cha,port_eng from con_image,code_port where code_port=code_load_port and  ship_id=" & Ship_ID & " group by code_load_port,ship_id,port_cha,port_eng")
        Me.c1dbg.DataSource = Updatedata(sqlda, "select * from code_loadport_unite where ship_id=" & Ship_ID, ds)

        Me.c1dbg.Columns.Item("head").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
        Me.c1dbg.Columns.Item("head").ValueItems.Translate = True
        Dim i As Integer
        Dim dstrue As New DataSet()
        Dim dw As New DataView()
        dstrue.Reset()
        dw = Getdata("select Value,Descri from true", dstrue)
        'Do While Me.c1dbg.Columns.Item("moved").ValueItems.Values.Count > 0
        '    Me.c1dbg.Columns.Item("moved").ValueItems.Values.RemoveAt(0)
        'Loop
        For i = 0 To dstrue.Tables(0).Rows.Count - 1
            Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
            vi.DisplayValue = dstrue.Tables(0).Rows(i)("Descri")
            vi.Value = dstrue.Tables(0).Rows(i)("Value")
            Me.c1dbg.Columns.Item("head").ValueItems.Values.Add(vi)
        Next

        columnswidth()
        caption()
    End Sub
    Private Sub caption()
        Me.c1dbg.Splits(0).DisplayColumns.Item("id").Visible = False
        Me.c1dbg.Splits(0).DisplayColumns.Item("ship_id").Visible = False
        Me.c1dbg.Columns.Item("code_load_port").Caption = "装货港代码"
        Me.c1dbg.Columns.Item("port_cha").Caption = "中文名称"
        Me.c1dbg.Columns.Item("port_eng").Caption = "英文名称"
        Me.c1dbg.Columns.Item("mark").Caption = "合并序号"
        Me.c1dbg.Columns.Item("head").Caption = "列名港"
    End Sub

    Private Sub columnswidth()
        Dim j As Integer
        For j = 0 To Me.c1dbg.Columns.Count - 1
            Me.c1dbg.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.c1dbg.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width < 60 Then
                Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width = 60
            Else
                If Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If

        Next
        'Me.C1DBG.Splits(0).DisplayColumns.Item("fee_rate").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far
        'Me.C1DBG.Splits(0).DisplayColumns.Item("money").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far

        'Me.C1DBG.Splits(0).DisplayColumns.Item("no").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        'Me.C1DBG.Splits(0).DisplayColumns.Item("Descri").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        'Me.C1DBG.Splits(0).DisplayColumns.Item("Account_Type").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    End Sub

    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        'portCount = ds.Tables(0).Rows.Count
        'For k = 0 To ds.Tables(0).Rows.Count - 1
        '    If ds.Tables(0).Rows(k).Item("mark") Is System.DBNull.Value Then
        '        MsgBox("请在第" & k + 1 & " 行输入合并序号", MsgBoxStyle.OKOnly, "提示")
        '        Exit Sub
        '    End If
        'Next
        'For k = 0 To ds.Tables(0).Rows.Count - 2
        '    For h = k + 1 To ds.Tables(0).Rows.Count - 1
        '        If ds.Tables(0).Rows(h).Item("mark") = ds.Tables(0).Rows(k).Item("mark") Then
        '            portCount = portCount - 1
        '        End If
        '    Next
        'Next
        'If portCount > 4 Then
        '    MsgBox("请再次合并装货港！", MsgBoxStyle.OKOnly, "提示")
        '    Exit Sub
        'End If
        sqlda.Update(ds)
        Me.Close()
    End Sub

    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub
End Class
