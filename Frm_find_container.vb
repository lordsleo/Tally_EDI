Imports TALLY.DBControl
Public Class Frm_find_container
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
    Friend WithEvents txt_container_No As System.Windows.Forms.TextBox
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_find_container))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = CType(New C1.Win.C1TrueDBGrid.Util.GridLines, C1.Win.C1TrueDBGrid.Util.GridLines)
        Me.c1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.txt_container_No = New System.Windows.Forms.TextBox
        Me.btn_enter = New System.Windows.Forms.Button
        Me.btn_cancle = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.c1dbg.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.c1dbg.Location = New System.Drawing.Point(0, 69)
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
        Me.c1dbg.Size = New System.Drawing.Size(706, 470)
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
        ", 0, 702, 466</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "yout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 7" & _
        "02, 466</ClientArea></Blob>"
        '
        'txt_container_No
        '
        Me.txt_container_No.Location = New System.Drawing.Point(279, 23)
        Me.txt_container_No.Name = "txt_container_No"
        Me.txt_container_No.TabIndex = 1
        Me.txt_container_No.Text = ""
        '
        'btn_enter
        '
        Me.btn_enter.Enabled = False
        Me.btn_enter.Location = New System.Drawing.Point(395, 21)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(65, 24)
        Me.btn_enter.TabIndex = 2
        Me.btn_enter.Text = "确认"
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(469, 21)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(65, 24)
        Me.btn_cancle.TabIndex = 3
        Me.btn_cancle.Text = "取消"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(173, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "查找箱号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Frm_find_container
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(706, 539)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cancle)
        Me.Controls.Add(Me.btn_enter)
        Me.Controls.Add(Me.txt_container_No)
        Me.Controls.Add(Me.c1dbg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_find_container"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查找箱号"
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim strsql As String
    Dim ds_container As New DataSet()
    Dim sqlda_container As New SqlClient.SqlDataAdapter()
    'Dim ds_oldbayno As New DataSet()
    Dim i As Integer = 0
    Dim sqlport As String
    Dim dsloadport As New DataSet
    Dim dsunloadport As New DataSet
    Dim strcheck As String
    Dim dscheck As New DataSet

    Private Sub Frm_find_container_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txt_container_No.Select()

    End Sub

    Private Sub txt_container_No_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_container_No.TextChanged
        Me.btn_enter.Enabled = True
        strsql = "select CON_IMAGE_ID,SHIP_ID,CONTAINER_NO,BAYNO,CODE_LOAD_PORT,CODE_UNLOAD_PORT,moved,oldbayno,FULLOREMPTY,BLNO,GROSSWEIGHT from con_image where ship_id=" & Ship_ID & " and container_No like '%" & Me.txt_container_No.Text & "%'"
        Me.c1dbg.DataSource = Updatedata(sqlda_container, strsql, ds_container)
        'Getdata(strsql, ds_oldbayno)
        Me.c1dbg.Columns.Item("moved").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
        Me.c1dbg.Columns.Item("moved").ValueItems.Translate = True
        Dim i As Integer
        Dim dstrue As New DataSet()
        Dim dw As New DataView()
        dstrue.Reset()
        dw = Getdata("select Value,Descri from true", dstrue)
        For i = 0 To dstrue.Tables(0).Rows.Count - 1
            Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
            vi.DisplayValue = dstrue.Tables(0).Rows(i)("Descri")
            vi.Value = dstrue.Tables(0).Rows(i)("Value")
            Me.c1dbg.Columns.Item("moved").ValueItems.Values.Add(vi)
        Next
        '装货港 '卸货港
        'Me.c1dbg.Columns.Item("CODE_LOAD_PORT").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
        'Me.c1dbg.Columns.Item("CODE_LOAD_PORT").ValueItems.Translate = True
        'Me.c1dbg.Columns.Item("code_unload_port").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
        'Me.c1dbg.Columns.Item("code_unload_port").ValueItems.Translate = True
        'sqlport = "SELECT CODE_PORT FROM CODE_PORT ORDER BY CODE_PORT"
        'Getdata(sqlport, dsloadport)
        'For i = 0 To dsloadport.Tables(0).Rows.Count - 1
        '    Dim loadport As New C1.Win.C1TrueDBGrid.ValueItem
        '    loadport.Value = dsloadport.Tables(0).Rows(i).Item("CODE_PORT")
        '    loadport.DisplayValue = dsloadport.Tables(0).Rows(i).Item("CODE_PORT")
        '    '装货港
        '    Me.c1dbg.Columns.Item("code_load_port").ValueItems.Values.Add(loadport)
        '    '卸货港
        '    Me.c1dbg.Columns.Item("code_unload_port").ValueItems.Values.Add(loadport)
        'Next
      
        caption()
        columnswidth()
    End Sub

    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        'For j = 0 To ds_container.Tables(0).Rows.Count - 1
        '    If ds_container.Tables(0).Rows(j).Item("moved") = 1 Then
        '        ds_container.Tables(0).Rows(j).Item("oldbayno") = ds_oldbayno.Tables(0).Rows(j).Item("bayno")
        '    End If

        'Next
        '判断装货港  卸货港是否正确
        Me.c1dbg.MoveFirst()
        'For i = 0 To ds_container.Tables(0).Rows.Count - 1
        '    strcheck = "SELECT CODE_PORT FROM CODE_PORT where right(code_port,3)=right('" & Me.c1dbg.Columns.Item("code_load_port").Text & "',3)"
        '    Getdata(strcheck, dscheck)
        '    If dscheck.Tables(0).Rows.Count = 0 Then
        '        MsgBox("第" & i + 1 & "行的装货港代码错误，请检查！", MsgBoxStyle.OKOnly, "提示")
        '        Exit Sub
        '    End If
        '    strcheck = "SELECT CODE_PORT FROM CODE_PORT where right(code_port,3)=right('" & Me.c1dbg.Columns.Item("code_unload_port").Text & "',3)"
        '    Getdata(strcheck, dscheck)
        '    If dscheck.Tables(0).Rows.Count = 0 Then
        '        MsgBox("第" & i + 1 & "行的卸货港代码错误，请检查！", MsgBoxStyle.OKOnly, "提示")
        '        Exit Sub
        '    End If
        'Next
        sqlda_container.Update(ds_container)
        Me.btn_enter.Enabled = False
        Me.txt_container_No.Text = ""
        Me.txt_container_No.Select()
        ds_container.Clear()
    End Sub

    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub

    Private Sub caption()
        Me.c1dbg.Splits(0).DisplayColumns.Item("con_image_id").Visible = False
        Me.c1dbg.Splits(0).DisplayColumns.Item("ship_id").Visible = False
        '  Me.c1dbg.Splits(0).DisplayColumns.Item("oldbayno").Visible = False
        Me.c1dbg.Columns.Item("container_no").Caption = "箱号"
        Me.c1dbg.Columns.Item("FULLOREMPTY").Caption = "箱空重"
        Me.c1dbg.Columns.Item("BAYNO").Caption = "贝位号"
        Me.c1dbg.Columns.Item("BLNO").Caption = "提单号"
        Me.c1dbg.Columns.Item("GROSSWEIGHT").Caption = "毛重"
        'Me.c1dbg.Columns.Item("code_load_port").Caption = "装货港"
        Me.c1dbg.Columns.Item("moved").Caption = "倒箱"
        Me.c1dbg.Columns.Item("oldbayno").Caption = "老贝位号"
        Me.c1dbg.Columns.Item("CODE_LOAD_PORT").Caption = "装货港代码"
        Me.c1dbg.Columns.Item("CODE_UNLOAD_PORT").Caption = "卸货港代码"
        Me.c1dbg.Splits(0).DisplayColumns.Item("container_no").Locked = True
        Me.c1dbg.Splits(0).DisplayColumns.Item("FULLOREMPTY").Locked = True
        Me.c1dbg.Splits(0).DisplayColumns.Item("BLNO").Locked = True
        'Me.c1dbg.Splits(0).DisplayColumns.Item("GROSSWEIGHT").Locked = True
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
    End Sub
End Class
