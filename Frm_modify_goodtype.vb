Imports TALLY.DBControl
Public Class Frm_modify_goodtype
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
    Friend WithEvents c1dbgAppendFee As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_modify_goodtype))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = CType(New C1.Win.C1TrueDBGrid.Util.GridLines, C1.Win.C1TrueDBGrid.Util.GridLines)
        Dim GridLines2 As C1.Win.C1TrueDBGrid.Util.GridLines = CType(New C1.Win.C1TrueDBGrid.Util.GridLines, C1.Win.C1TrueDBGrid.Util.GridLines)
        Me.c1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btn_enter = New System.Windows.Forms.Button
        Me.btn_cancle = New System.Windows.Forms.Button
        Me.c1dbgAppendFee = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dbgAppendFee, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.c1dbg.Dock = System.Windows.Forms.DockStyle.Top
        Me.c1dbg.ExpandColor = System.Drawing.Color.Black
        Me.c1dbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbg.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.c1dbg.Location = New System.Drawing.Point(0, 0)
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
        Me.c1dbg.Size = New System.Drawing.Size(826, 298)
        Me.c1dbg.TabIndex = 0
        Me.c1dbg.Text = "C1TrueDBGrid1"
        Me.c1dbg.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        ", 0, 822, 294</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "yout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 8" & _
        "22, 294</ClientArea></Blob>"
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(340, 312)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(65, 24)
        Me.btn_enter.TabIndex = 1
        Me.btn_enter.Text = "确认"
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(422, 312)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(65, 24)
        Me.btn_cancle.TabIndex = 2
        Me.btn_cancle.Text = "取消"
        '
        'c1dbgAppendFee
        '
        Me.c1dbgAppendFee.AllowFilter = True
        Me.c1dbgAppendFee.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.c1dbgAppendFee.AllowSort = True
        Me.c1dbgAppendFee.CaptionHeight = 18
        Me.c1dbgAppendFee.CollapseColor = System.Drawing.Color.Black
        Me.c1dbgAppendFee.DataChanged = False
        Me.c1dbgAppendFee.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1dbgAppendFee.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.c1dbgAppendFee.ExpandColor = System.Drawing.Color.Black
        Me.c1dbgAppendFee.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgAppendFee.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.c1dbgAppendFee.Location = New System.Drawing.Point(0, 350)
        Me.c1dbgAppendFee.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.c1dbgAppendFee.Name = "c1dbgAppendFee"
        Me.c1dbgAppendFee.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgAppendFee.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgAppendFee.PreviewInfo.ZoomFactor = 75
        Me.c1dbgAppendFee.PrintInfo.ShowOptionsDialog = False
        Me.c1dbgAppendFee.RecordSelectorWidth = 16
        GridLines2.Color = System.Drawing.Color.DarkGray
        GridLines2.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.c1dbgAppendFee.RowDivider = GridLines2
        Me.c1dbgAppendFee.RowHeight = 16
        Me.c1dbgAppendFee.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1dbgAppendFee.ScrollTips = False
        Me.c1dbgAppendFee.Size = New System.Drawing.Size(826, 281)
        Me.c1dbgAppendFee.TabIndex = 3
        Me.c1dbgAppendFee.Text = "C1TrueDBGrid1"
        Me.c1dbgAppendFee.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        ", 0, 822, 277</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "yout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 8" & _
        "22, 277</ClientArea></Blob>"
        '
        'Frm_modify_goodtype
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(826, 631)
        Me.Controls.Add(Me.c1dbgAppendFee)
        Me.Controls.Add(Me.btn_cancle)
        Me.Controls.Add(Me.btn_enter)
        Me.Controls.Add(Me.c1dbg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_modify_goodtype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "理货结果表"
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dbgAppendFee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim str As String
    Dim j As Integer
    ''''''附加费用列表
    Dim dw As New DataView
    'Dim SqlStr As String  '条件语句
    'Dim SelectStr As String
    Private Sub Frm_modify_goodtype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        str = "select TALLY_RESULT_ID,SHIP_ID,BLNO,CODE_GOODS,PIECE_WEIGHT,ACCESSORY,GOODS_CHA,CODE_Goods_TYPE,MARK,MARK_PORT,TALLY_AMOUNT,AMOUNT,TOTAL_WEIGHT,SIZE_MEASURE,BASIC_AMOUNT,FEE_CODE,EMPTY_MARK,UNIT,FEE_AMOUNT from tally_result where ship_id=" & Ship_ID

        Me.c1dbg.DataSource = Updatedata(sqlda, str, ds)

        code_goods_type()
        SetColumnCaption()
        columnswidth()
        ''''''附加费用列表
        Getdata("select * from view_outhatch_sship where ship_id='" & Ship_ID & "'", ds_sship)
        Try
            DS_DO.Reset()

            If ds_sship.Tables(0).Rows.Count > 0 Then
                trade = ds_sship.Tables(0).Rows(0).Item("s_trade")
                If trade = "1" Then
                    dw = Getdata("exec sp_append_fee '" & Ship_ID & "'", DS_DO)
                    mark = "1"


                ElseIf trade = "2" Then
                    dw = Getdata("exec sp_append_fee_eng '" & Ship_ID & "'", DS_DO)
                    mark = "1"

                End If

            End If


            Call myDataGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub myDataGrid()
        Dim strsql As String
        Dim i As Integer
        Try
            If mark = "1" Then
                c1dbgAppendFee.Visible = True

                c1dbgAppendFee.DataSource = DS_DO.Tables(0).DefaultView
                c1dbgAppendFee.Refresh()
                Me.c1dbgAppendFee.Columns.Item("item").Caption = "项目"
                Me.c1dbgAppendFee.Columns.Item("time").Caption = "日期时间"
                Me.c1dbgAppendFee.Columns.Item("blno").Caption = "提单号"
                'Me.c1dbgAppendFee.Columns.Item("mark").Caption = "标志"
                Me.c1dbgAppendFee.Columns.Item("goods").Caption = "货名"
                Me.c1dbgAppendFee.Columns.Item("amount").Caption = "件数"
                Me.c1dbgAppendFee.Columns.Item("weight").Caption = "重量"
                Me.c1dbgAppendFee.Columns.Item("size_con").Caption = "尺寸"
                Me.c1dbgAppendFee.Columns.Item("user_name").Caption = "责任者"


                ' Call SetColumnWidth()
                Dim j As Integer
                For j = 0 To Me.c1dbgAppendFee.Columns.Count - 1
                    Me.c1dbgAppendFee.Splits(0).DisplayColumns.Item(j).AutoSize()
                    Me.c1dbgAppendFee.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                    If Me.c1dbgAppendFee.Splits(0).DisplayColumns.Item(j).Width < 30 Then
                        Me.c1dbgAppendFee.Splits(0).DisplayColumns.Item(j).Width = 30
                    Else
                        If Me.c1dbgAppendFee.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                            Me.c1dbgAppendFee.Splits(0).DisplayColumns.Item(j).Width = 120
                        End If
                    End If
                Next

            End If
            Me.c1dbg.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        sqlda.Update(ds)
        Me.Close()
    End Sub

    Private Sub code_goods_type()
        Me.c1dbg.Splits(0).DisplayColumns.Item("BLNO").Locked = True
        Me.c1dbg.Splits(0).DisplayColumns.Item("CODE_GOODS").Locked = True
        Me.c1dbg.Splits(0).DisplayColumns.Item("MARK").Locked = True
        Me.c1dbg.Splits(0).DisplayColumns.Item("TALLY_AMOUNT").Locked = True
        Me.c1dbg.Splits(0).DisplayColumns.Item("AMOUNT").Locked = True
        Me.c1dbg.Splits(0).DisplayColumns.Item("TOTAL_WEIGHT").Locked = True
        Me.c1dbg.Splits(0).DisplayColumns.Item("SIZE_MEASURE").Locked = True
        Me.c1dbg.Splits(0).DisplayColumns.Item("EMPTY_MARK").Locked = True
        Me.c1dbg.Splits(0).DisplayColumns.Item("UNIT").Locked = True
        Me.c1dbg.Splits(0).DisplayColumns.Item("FEE_CODE").Locked = True
        Me.c1dbg.Splits(0).DisplayColumns.Item("FEE_AMOUNT").Locked = True
        Me.c1dbg.Splits(0).DisplayColumns.Item("BASIC_AMOUNT").Locked = True

        Me.c1dbg.Splits(0).DisplayColumns.Item(0).Visible = False
        Me.c1dbg.Splits(0).DisplayColumns.Item(1).Visible = False
        Me.c1dbg.Splits(0).DisplayColumns.Item("MARK_PORT").Visible = False

        Me.c1dbg.Columns.Item("code_goods_type").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
        Dim ds_code As New DataSet
        Dim strcode As String
        strcode = "select code_goods_type from code_goods_type where code_goods_type<>'0'" ' and code_goods_type<>99
        Getdata(strcode, ds_code)
        For j = 0 To ds_code.Tables(0).Rows.Count - 1
            Dim leak As New C1.Win.C1TrueDBGrid.ValueItem
            leak.Value = ds_code.Tables(0).Rows(j).Item("code_goods_type")
            Me.c1dbg.Columns("code_goods_type").ValueItems.Values.Add(leak)
        Next
    End Sub
    Private Sub SetColumnCaption()
        Me.c1dbg.Columns.Item("BLNO").Caption = "提单号"
        Me.c1dbg.Columns.Item("CODE_GOODS").Caption = "舱单货类"
        Me.c1dbg.Columns.Item("MARK").Caption = "标志"
        Me.c1dbg.Columns.Item("TALLY_AMOUNT").Caption = "理货件数"
        Me.c1dbg.Columns.Item("AMOUNT").Caption = "原件数"
        Me.c1dbg.Columns.Item("TOTAL_WEIGHT").Caption = "总重量"
        Me.c1dbg.Columns.Item("SIZE_MEASURE").Caption = "体积尺寸"
        Me.c1dbg.Columns.Item("EMPTY_MARK").Caption = "空重"
        Me.c1dbg.Columns.Item("UNIT").Caption = "计费单位"
        Me.c1dbg.Columns.Item("FEE_CODE").Caption = "基本费率代码"
        Me.c1dbg.Columns.Item("FEE_AMOUNT").Caption = "单位计费数量"
        Me.c1dbg.Columns.Item("BASIC_AMOUNT").Caption = "基本计费数量"
        Me.c1dbg.Columns.Item("code_goods_type").Caption = "计费货类"
        Me.c1dbg.Columns.Item("ACCESSORY").Caption = "附件"
        Me.c1dbg.Columns.Item("GOODS_CHA").Caption = "中文描述"
        Me.c1dbg.Columns.Item("PIECE_WEIGHT").Caption = "件重"
    End Sub
    Private Sub columnswidth()
        Dim j As Integer
        For j = 0 To Me.c1dbg.Columns.Count - 1
            Me.c1dbg.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.c1dbg.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width < 30 Then
                Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width = 30
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
    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub
End Class
