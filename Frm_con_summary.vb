Imports TALLY.DBControl
Public Class Frm_con_summary
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
    Friend WithEvents btn_export As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents btn_unite As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents c1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_con_summary))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_cancle = New System.Windows.Forms.Button()
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.btn_unite = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.c1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_export
        '
        Me.btn_export.Location = New System.Drawing.Point(329, 26)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(65, 24)
        Me.btn_export.TabIndex = 1
        Me.btn_export.Text = "导出"
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(413, 26)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(65, 24)
        Me.btn_print.TabIndex = 1
        Me.btn_print.Text = "打印"
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(497, 26)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(65, 24)
        Me.btn_cancle.TabIndex = 1
        Me.btn_cancle.Text = "取消"
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(245, 26)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(65, 24)
        Me.btn_enter.TabIndex = 1
        Me.btn_enter.Text = "确定"
        '
        'btn_unite
        '
        Me.btn_unite.Location = New System.Drawing.Point(151, 26)
        Me.btn_unite.Name = "btn_unite"
        Me.btn_unite.Size = New System.Drawing.Size(76, 24)
        Me.btn_unite.TabIndex = 1
        Me.btn_unite.Text = "合并装货港"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_export, Me.btn_print, Me.btn_unite, Me.btn_cancle, Me.btn_enter})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'c1dbg
        '
        Me.c1dbg.AllowFilter = True
        Me.c1dbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.c1dbg.AllowSort = True
        Me.c1dbg.CaptionHeight = 18
        Me.c1dbg.CollapseColor = System.Drawing.Color.Black
        Me.c1dbg.ColumnHeaders = False
        Me.c1dbg.DataChanged = False
        Me.c1dbg.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1dbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1dbg.ExpandColor = System.Drawing.Color.Black
        Me.c1dbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbg.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.c1dbg.Location = New System.Drawing.Point(0, 64)
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
        Me.c1dbg.Size = New System.Drawing.Size(712, 413)
        Me.c1dbg.TabIndex = 3
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
        ", 0, 708, 409</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "08, 409</ClientArea></Blob>"
        '
        'Frm_con_summary
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 477)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1dbg, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "Frm_con_summary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "summary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim dsSummary As New DataSet()
    Dim dsCode_port As New DataSet()
    Dim i As Integer = 0
    Dim j As Integer = 0
    Dim row As Integer
    Dim dsshipname As New DataSet()
    Dim INOUTPORT As String
    Dim morePage As Boolean = False '是否为多页打印
    Dim bigPage As Boolean = False 'B4纸打印
    Dim commonPage As Boolean = False 'A4普通纸
    Dim printed As Boolean = False
    Dim export As Boolean = False
    'Dim Row As Integer
    Dim Col As Integer
    Private Sub Frm_con_summary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        morePage = False
        bigPage = False
        commonPage = False
        printed = False
        export = False

        ExecSql("delete from code_loadport_unite where ship_id=" & Ship_ID) '   使moved=0，去掉倒箱的装或港           
        ExecSql("insert into code_loadport_unite(ship_id,code_load_port,port_cha,port_eng) select distinct con_image.ship_id,right(con_image.code_load_port,3),port_cha,port_eng from con_image left outer join code_port on con_image.code_load_port= code_port where  ship_id=" & Ship_ID & " and moved=0  group by code_load_port,ship_id,port_cha,port_eng")
        Getdata("select ENG_VESSEL,INOUTPORT from sship where ship_id=" & Ship_ID, dsshipname)
        INOUTPORT = dsshipname.Tables(0).Rows(0).Item("INOUTPORT")
        btn_enter_Click(sender, e)
    End Sub

    Private Sub caption()
        Me.c1dbg.Splits(0).DisplayColumns.Item("number").Visible = False
        '   Me.c1dbg.Splits(0).DisplayColumns.Item(0).Merge

    End Sub

    Private Sub columnswidth()
        Dim j As Integer
        For j = 0 To Me.c1dbg.Columns.Count - 1
            Me.c1dbg.Columns.Item(j).Caption = "a"
            Me.c1dbg.Splits(0).DisplayColumns.Item(j).AutoSize()
            'Me.c1dbg.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment()

            If Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width < 15 Then
                Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width = 15
            Else
                If Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If

        Next
        'Me.c1dbg.Splits(0).DisplayColumns.Item(1).Width = 60
        'Me.c1dbg.Splits(0).DisplayColumns.Item(2).Width = 20
        'Me.C1DBG.Splits(0).DisplayColumns.Item("fee_rate").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far
        'Me.C1DBG.Splits(0).DisplayColumns.Item("money").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far
        'Me.C1DBG.Splits(0).DisplayColumns.Item("no").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        'Me.C1DBG.Splits(0).DisplayColumns.Item("Descri").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        'Me.C1DBG.Splits(0).DisplayColumns.Item("Account_Type").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    End Sub

    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub

    Private Sub btn_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_export.Click
        MakeExcel()
    End Sub


    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        morePage = False
        bigPage = False
        commonPage = False
        printed = False
        export = False

        If Getdata("exec sp_summary_check " & Ship_ID, dsCode_port).Count > 0 Then
            If dsCode_port.Tables(0).Rows(0).Item(0) > 4 Then
                MsgBox("请合并装货港", MsgBoxStyle.OKOnly, "提示")
            Else
                '判断进出口
                If INOUTPORT = 1 Then
                    '出口
                    Getdata("exec sp_summary " & Ship_ID, dsSummary)

                Else
                    '进口
                    Getdata("exec sp_summary_in " & Ship_ID, dsSummary)
                End If
                'Getdata("exec sp_summary " & Ship_ID, dsSummary)
                If dsSummary.Tables(0).Rows.Count <= 39 Then
                    'A4普通纸
                    commonPage = True
                End If
                If dsSummary.Tables(0).Rows.Count > 39 And dsSummary.Tables(0).Rows.Count <= 47 Then
                    'B4
                    bigPage = True
                End If
                If dsSummary.Tables(0).Rows.Count > 47 Then
                    '多页
                    morePage = True
                End If
                Me.c1dbg.DataSource = dsSummary.Tables(0).DefaultView
                'TOTAL
                Me.c1dbg.ColumnFooters = True
                Me.c1dbg.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
                Me.c1dbg.Columns.Item("code_unload_port").FooterText = "TOTAL"
                Dim sum As Decimal = 0
                'For j = 3 To Me.c1dbg.Columns.Count - 1
                '    sum = 0
                '    For i = 3 To dsSummary.Tables(0).Rows.Count - 1 - 4
                '        '   If dsSummary.Tables(0).Rows(i).Item("fullempty") = "F" Or dsSummary.Tables(0).Rows(i).Item("fullempty") = "E" Then
                '        sum = sum + IIf(dsSummary.Tables(0).Rows(i).Item(j) Is System.DBNull.Value, 0, dsSummary.Tables(0).Rows(i).Item(j))
                '        ' End If
                '    Next
                '    If sum > 0 Then
                '        Me.c1dbg.Columns.Item(j).FooterText = sum
                '    End If
                'Next
                For j = 0 To dsSummary.Tables(1).Rows.Count - 1
                    If dsSummary.Tables(1).Rows(j)("con_size").ToString() = "20" Then
                        Me.c1dbg.Columns.Item("e20count").FooterText = dsSummary.Tables(1).Rows(j)("conts").ToString()
                        Me.c1dbg.Columns.Item("e20").FooterText = dsSummary.Tables(1).Rows(j)("weight").ToString()
                    End If
                    If dsSummary.Tables(1).Rows(j)("con_size").ToString() = "40" Then
                        Me.c1dbg.Columns.Item("e40count").FooterText = dsSummary.Tables(1).Rows(j)("conts").ToString()
                        Me.c1dbg.Columns.Item("e40").FooterText = dsSummary.Tables(1).Rows(j)("weight").ToString()
                    End If
                    If dsSummary.Tables(1).Rows(j)("con_size").ToString() = "45" Then
                        Me.c1dbg.Columns.Item("e45count").FooterText = dsSummary.Tables(1).Rows(j)("conts").ToString()
                        Me.c1dbg.Columns.Item("e45").FooterText = dsSummary.Tables(1).Rows(j)("weight").ToString()
                    End If
                Next

                caption()
                columnswidth()
            End If
        End If
    End Sub

    Private Sub btn_unite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_unite.Click
        Dim frm As New Frm_con_summary_unite()
        frm.ShowDialog()
    End Sub

    Private Sub MakeExcel()
        Dim PathStr As String
        Dim FilePath As String

        export = True
        printed = False
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)

        Try
            FileCopy(PathStr + "\zhuweixin2.xls", PathStr + "\copy_zhuweixin2.xls")
            FilePath = PathStr + "\copy_zhuweixin2.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            If commonPage = True Then
                funcCommonPage()
                '  xlSheet.PrintOut()
            End If

            If bigPage = True Then
                funcBigPage()
                '  xlSheet.PrintOut()
            End If

            If morePage = True Then
                funcMorePage()
            End If
            'xlBook.Worksheets("summary").select()

            'xlSheet.PrintOut()
            '   xlApp.Quit()
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        '记录EXCEL进程
        RecordExcelProcess()

        Dim PathStr As String
        Dim FilePath As String

        export = False
        printed = True

        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FileCopy(PathStr + "\zhuweixin2.xls", PathStr + "\copy_zhuweixin2.xls")
            FilePath = PathStr + "\copy_zhuweixin2.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            If commonPage = True Then
                funcCommonPage()
                xlSheet.PrintOut()
            End If

            If bigPage = True Then
                funcBigPage()
                xlSheet.PrintOut()
            End If

            If morePage = True Then
                funcMorePage()
            End If
            'xlBook.Worksheets("summary").select()

            'xlSheet.PrintOut()
            '   xlApp.Quit()
            '清除EXCEL进程
            KillExcelProcess()
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub funcCommonPage()
        xlApp.DisplayAlerts = False
        xlSheet = CType(xlBook.Worksheets("summary"), Excel.Worksheet)

        If export = True Then
            xlSheet.Application.Visible = True
            xlBook.Worksheets("summary").select()
        End If
        If printed = True Then
            xlSheet.Application.Visible = False
        End If

        'MV.
        xlSheet.Cells(2, 3) = dsshipname.Tables(0).Rows(0).Item("ENG_VESSEL")
        'VOY.
        xlSheet.Cells(2, 9) = G_Voyage
        'DATE
        xlSheet.Cells(2, 23) = DatePart(DateInterval.Year, Today()) & " - " & IIf(DatePart(DateInterval.Month, Today()) < 10, "0" & DatePart(DateInterval.Month, Today()), DatePart(DateInterval.Month, Today())) & "-" & IIf(DatePart(DateInterval.Day, Today()) < 10, "0" & DatePart(DateInterval.Day, Today()), DatePart(DateInterval.Day, Today())) & "  " & IIf(DatePart(DateInterval.Hour, Now()) < 10, "0" & DatePart(DateInterval.Hour, Now()), DatePart(DateInterval.Hour, Now())) & ":" & IIf(DatePart(DateInterval.Minute, Now()) < 10, "0" & DatePart(DateInterval.Minute, Now()), DatePart(DateInterval.Minute, Now()))
        '装货港
        Me.c1dbg.MoveFirst()
        xlSheet.Cells(3, 3) = Me.c1dbg.Columns("a20").Text
        xlSheet.Cells(3, 9) = Me.c1dbg.Columns("b20").Text
        xlSheet.Cells(3, 15) = Me.c1dbg.Columns("c20").Text
        xlSheet.Cells(3, 21) = Me.c1dbg.Columns("d20").Text



        Me.c1dbg.MoveFirst()
        Me.c1dbg.MoveNext()
        Me.c1dbg.MoveNext()
        Me.c1dbg.MoveNext()
        For row = 3 To dsSummary.Tables(0).Rows.Count - 1 - 4 '数据-total
            '卸货港
            xlSheet.Cells(row + 3, 1) = dsSummary.Tables(0).Rows(row).Item("code_unload_port")
            '数据
            For Col = 3 To Me.c1dbg.Columns.Count - 1
                If Len(Trim(Me.c1dbg.Columns(Col).Text)) = 0 Then

                Else
                    xlSheet.Cells(row + 3, Col) = Me.c1dbg.Columns(Col).Text.ToString
                End If
                'If Len(Trim(Me.c1dbg.Columns(Col).Text)) = 0 Then
                '    xlSheet.Cells(Row + 3, Col) = 0
                'Else
                '    xlSheet.Cells(Row + 3, Col) = Me.c1dbg.Columns(Col).Text.ToString
                'End If
            Next Col
            Me.c1dbg.MoveNext()
        Next row
        '写total
        i = 0
        For row = dsSummary.Tables(0).Rows.Count - 1 - 3 To dsSummary.Tables(0).Rows.Count - 1 '去掉最上面3行表头
            i = i + 1
            '卸货港
            xlSheet.Cells(38, 1) = dsSummary.Tables(0).Rows(row).Item("code_unload_port")
            '数据
            For Col = 3 To Me.c1dbg.Columns.Count - 1
                If Len(Trim(Me.c1dbg.Columns(Col).Text)) = 0 Then

                Else
                    xlSheet.Cells(38 + i - 1, Col) = dsSummary.Tables(0).Rows(row).Item(Col)
                End If
            Next Col
            Me.c1dbg.MoveNext()
        Next
        '写合计TOTAL
        For i = 3 To Me.c1dbg.Columns.Count - 1
            xlSheet.Cells(42, i) = Me.c1dbg.Columns.Item(i).FooterText
        Next
    End Sub

    Private Sub funcBigPage()
        xlApp.DisplayAlerts = False

        xlSheet = CType(xlBook.Worksheets("summaryBig"), Excel.Worksheet)

        If export = True Then
            xlSheet.Application.Visible = True
            xlBook.Worksheets("summaryBig").select()
        End If
        If printed = True Then
            xlSheet.Application.Visible = False
        End If

        'MV.
        xlSheet.Cells(2, 3) = dsshipname.Tables(0).Rows(0).Item("ENG_VESSEL")
        'VOY.
        xlSheet.Cells(2, 9) = G_Voyage
        'DATE
        xlSheet.Cells(2, 23) = DatePart(DateInterval.Year, Today()) & " - " & IIf(DatePart(DateInterval.Month, Today()) < 10, "0" & DatePart(DateInterval.Month, Today()), DatePart(DateInterval.Month, Today())) & "-" & IIf(DatePart(DateInterval.Day, Today()) < 10, "0" & DatePart(DateInterval.Day, Today()), DatePart(DateInterval.Day, Today())) & "  " & IIf(DatePart(DateInterval.Hour, Now()) < 10, "0" & DatePart(DateInterval.Hour, Now()), DatePart(DateInterval.Hour, Now())) & ":" & IIf(DatePart(DateInterval.Minute, Now()) < 10, "0" & DatePart(DateInterval.Minute, Now()), DatePart(DateInterval.Minute, Now()))
        '装货港
        Me.c1dbg.MoveFirst()
        xlSheet.Cells(3, 3) = Me.c1dbg.Columns("a20").Text
        xlSheet.Cells(3, 9) = Me.c1dbg.Columns("b20").Text
        xlSheet.Cells(3, 15) = Me.c1dbg.Columns("c20").Text
        xlSheet.Cells(3, 21) = Me.c1dbg.Columns("d20").Text



        Me.c1dbg.MoveFirst()
        Me.c1dbg.MoveNext()
        Me.c1dbg.MoveNext()
        Me.c1dbg.MoveNext()
        For row = 3 To dsSummary.Tables(0).Rows.Count - 1 - 4 '数据
            '卸货港
            xlSheet.Cells(row + 3, 1) = dsSummary.Tables(0).Rows(row).Item("code_unload_port")
            '数据
            For Col = 3 To Me.c1dbg.Columns.Count - 1
                If Len(Trim(Me.c1dbg.Columns(Col).Text)) = 0 Then

                Else
                    xlSheet.Cells(row + 3, Col) = Me.c1dbg.Columns(Col).Text.ToString
                End If
                'If Len(Trim(Me.c1dbg.Columns(Col).Text)) = 0 Then
                '    xlSheet.Cells(Row + 3, Col) = 0
                'Else
                '    xlSheet.Cells(Row + 3, Col) = Me.c1dbg.Columns(Col).Text.ToString
                'End If
            Next Col
            Me.c1dbg.MoveNext()
        Next row
        '写total
        i = 0
        For row = dsSummary.Tables(0).Rows.Count - 1 - 3 To dsSummary.Tables(0).Rows.Count - 1
            i = i + 1
            '卸货港
            xlSheet.Cells(46, 1) = dsSummary.Tables(0).Rows(row).Item("code_unload_port")
            '数据
            For Col = 3 To Me.c1dbg.Columns.Count - 1
                If Len(Trim(Me.c1dbg.Columns(Col).Text)) = 0 Then

                Else
                    xlSheet.Cells(46 + i - 1, Col) = dsSummary.Tables(0).Rows(row).Item(Col)
                End If
            Next Col
            Me.c1dbg.MoveNext()
        Next
        '写合计TOTAL
        For i = 3 To Me.c1dbg.Columns.Count - 1
            xlSheet.Cells(50, i) = Me.c1dbg.Columns.Item(i).FooterText
        Next
    End Sub

    Private Sub funcMorePage()
        xlApp.DisplayAlerts = False
        Dim j As Integer
        Dim dataCount As Integer '当前页打印的数据条数
        Dim dsRow As Integer ''当前页打印的数据在数据集中的行数
        '翻页循环
        For j = 1 To 2
            If j = 1 Then
                xlSheet = CType(xlBook.Worksheets("summary1"), Excel.Worksheet)

                If export = True Then
                    xlSheet.Application.Visible = True
                    xlBook.Worksheets("summary1").select()
                End If
                If printed = True Then
                    xlSheet.Application.Visible = False
                End If

                dataCount = 39
                dsRow = 0
            End If

            If j = 2 Then
                xlSheet = CType(xlBook.Worksheets("summary2"), Excel.Worksheet)

                If export = True Then
                    xlSheet.Application.Visible = True
                    xlBook.Worksheets("summary2").select()
                End If
                If printed = True Then
                    xlSheet.Application.Visible = False
                End If

                dataCount = dsSummary.Tables(0).Rows.Count - 36 - 4
                dsRow = 36
              
            End If

            'MV.
            xlSheet.Cells(2, 3) = dsshipname.Tables(0).Rows(0).Item("ENG_VESSEL")
            'VOY.
            xlSheet.Cells(2, 9) = G_Voyage
            'DATE
            xlSheet.Cells(2, 23) = DatePart(DateInterval.Year, Today()) & " - " & IIf(DatePart(DateInterval.Month, Today()) < 10, "0" & DatePart(DateInterval.Month, Today()), DatePart(DateInterval.Month, Today())) & "-" & IIf(DatePart(DateInterval.Day, Today()) < 10, "0" & DatePart(DateInterval.Day, Today()), DatePart(DateInterval.Day, Today())) & "  " & IIf(DatePart(DateInterval.Hour, Now()) < 10, "0" & DatePart(DateInterval.Hour, Now()), DatePart(DateInterval.Hour, Now())) & ":" & IIf(DatePart(DateInterval.Minute, Now()) < 10, "0" & DatePart(DateInterval.Minute, Now()), DatePart(DateInterval.Minute, Now()))
            '装货港
            Me.c1dbg.MoveFirst()
            xlSheet.Cells(3, 3) = Me.c1dbg.Columns("a20").Text
            xlSheet.Cells(3, 9) = Me.c1dbg.Columns("b20").Text
            xlSheet.Cells(3, 15) = Me.c1dbg.Columns("c20").Text
            xlSheet.Cells(3, 21) = Me.c1dbg.Columns("d20").Text



            Me.c1dbg.MoveFirst()
            Me.c1dbg.MoveNext()
            Me.c1dbg.MoveNext()
            Me.c1dbg.MoveNext()
            If j = 2 Then
                For i = 1 To 36
                    Me.c1dbg.MoveNext()
                Next
            End If

            For row = 3 To dataCount - 1 '数据
                '卸货港
                xlSheet.Cells(row + 3, 1) = dsSummary.Tables(0).Rows(dsRow + row).Item("code_unload_port")
                '数据
                For Col = 3 To Me.c1dbg.Columns.Count - 1
                    If Len(Trim(Me.c1dbg.Columns(Col).Text)) = 0 Then

                    Else
                        xlSheet.Cells(row + 3, Col) = Me.c1dbg.Columns(Col).Text.ToString
                    End If
                    'If Len(Trim(Me.c1dbg.Columns(Col).Text)) = 0 Then
                    '    xlSheet.Cells(Row + 3, Col) = 0
                    'Else
                    '    xlSheet.Cells(Row + 3, Col) = Me.c1dbg.Columns(Col).Text.ToString
                    'End If
                Next Col
                Me.c1dbg.MoveNext()
            Next row
            '写合计TOTAL
            If j = 2 Then
                '写total
                i = 0
                For row = dsSummary.Tables(0).Rows.Count - 1 - 3 To dsSummary.Tables(0).Rows.Count - 1
                    i = i + 1
                    '卸货港
                    xlSheet.Cells(38 + i - 1, 1) = dsSummary.Tables(0).Rows(row).Item("code_unload_port")
                    '数据
                    For Col = 3 To Me.c1dbg.Columns.Count - 1
                        If Len(Trim(Me.c1dbg.Columns(Col).Text)) = 0 Then

                        Else
                            xlSheet.Cells(38 + i - 1, Col) = dsSummary.Tables(0).Rows(row).Item(Col) 'Me.c1dbg.Columns(Col).Text.ToString '
                        End If
                    Next Col
                    Me.c1dbg.MoveNext()
                Next
                For i = 3 To Me.c1dbg.Columns.Count - 1
                    xlSheet.Cells(42, i) = Me.c1dbg.Columns.Item(i).FooterText
                Next
            End If
            If printed = True Then
                xlSheet.PrintOut()
            End If
        Next '翻页循环

    End Sub

End Class
