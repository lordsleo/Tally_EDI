Imports TALLY.DBControl
Public Class FrmConImage_Keeper
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbKeeper As System.Windows.Forms.ComboBox
    Friend WithEvents C1Stat As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btQuit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConImage_Keeper))
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbKeeper = New System.Windows.Forms.ComboBox
        Me.C1Stat = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnEnter = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Stat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FetchRowStyles = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(260, 0)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(472, 436)
        Me.C1DBG.TabIndex = 2
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionH" & _
        "eight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" FetchRowStyles=""True" & _
        """ MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" V" & _
        "erticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>432</Height><CaptionSty" & _
        "le parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><Ev" & _
        "enRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=" & _
        """Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group" & _
        """ me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle" & _
        " parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4" & _
        """ /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""Reco" & _
        "rdSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style" & _
        " parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 468, 432</ClientRect><BorderSid" & _
        "e>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView" & _
        "></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=" & _
        """Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Ca" & _
        "ption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Sele" & _
        "cted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filt" & _
        "erBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertS" & _
        "plits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Def" & _
        "aultRecSelWidth><ClientArea>0, 0, 468, 432</ClientArea><PrintPageHeaderStyle par" & _
        "ent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 588
        Me.Label1.Text = "经营人筛选"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbKeeper
        '
        Me.cbKeeper.Location = New System.Drawing.Point(76, 20)
        Me.cbKeeper.MaxDropDownItems = 20
        Me.cbKeeper.Name = "cbKeeper"
        Me.cbKeeper.Size = New System.Drawing.Size(120, 20)
        Me.cbKeeper.TabIndex = 0
        '
        'C1Stat
        '
        Me.C1Stat.AllowFilter = False
        Me.C1Stat.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1Stat.AllowUpdate = False
        Me.C1Stat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.C1Stat.FetchRowStyles = True
        Me.C1Stat.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Stat.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1Stat.Location = New System.Drawing.Point(0, 288)
        Me.C1Stat.Name = "C1Stat"
        Me.C1Stat.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Stat.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Stat.PreviewInfo.ZoomFactor = 75
        Me.C1Stat.Size = New System.Drawing.Size(260, 148)
        Me.C1Stat.TabIndex = 3
        Me.C1Stat.Text = "C1TrueDBGrid1"
        Me.C1Stat.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionH" & _
        "eight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" FetchRowStyles=""True" & _
        """ MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" V" & _
        "erticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>144</Height><CaptionSty" & _
        "le parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><Ev" & _
        "enRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=" & _
        """Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group" & _
        """ me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle" & _
        " parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4" & _
        """ /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""Reco" & _
        "rdSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style" & _
        " parent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 256, 144</ClientRect><BorderSid" & _
        "e>0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView" & _
        "></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=" & _
        """Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Ca" & _
        "ption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Sele" & _
        "cted"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Highligh" & _
        "tRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow""" & _
        " /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filt" & _
        "erBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertS" & _
        "plits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Def" & _
        "aultRecSelWidth><ClientArea>0, 0, 256, 144</ClientArea><PrintPageHeaderStyle par" & _
        "ent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(148, 60)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "选取"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(200, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 598
        Me.Label5.Text = "全选留空"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btQuit
        '
        Me.btQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(608, 440)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 4
        Me.btQuit.Text = "退出"
        '
        'FrmConImage_Keeper
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(732, 469)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.C1Stat)
        Me.Controls.Add(Me.cbKeeper)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C1DBG)
        Me.Name = "FrmConImage_Keeper"
        Me.Text = "经营人查看"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Stat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlConKeeper As String
    Dim dvConKeeper As DataView

    Dim dsTemp As New DataTable
    Dim dvTemp As DataView

    Private Sub FrmConImage_Keeper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.C1Stat.AllowColMove = False
        Me.C1Stat.AllowSort = False
        sqlConKeeper = "Select NIGHT_MARK,HOLIDAY,CONTAINER_NO,SIZE_CON,FULLOREMPTY,BLNO,Case when NIGHT_MARK<>'0' then '1' end NightDesc,Case when Holiday<>'0' then '1' end HolidayDesc, Code_Con_Company from View_ConTallyKeeper where Ship_ID=" & Ship_ID
        dvConKeeper = Filldata(sqlConKeeper)
        Me.C1DBG.DataSource = dvConKeeper
        Me.C1DBG.Columns("CONTAINER_NO").Caption = "箱号"
        Me.C1DBG.Columns("SIZE_CON").Caption = "箱尺"
        Me.C1DBG.Columns("FULLOREMPTY").Caption = "空重"
        Me.C1DBG.Columns("BLNO").Caption = "提单"
        Me.C1DBG.Columns("NightDesc").Caption = "夜"
        Me.C1DBG.Columns("HolidayDesc").Caption = "假"
        Me.C1DBG.Columns("Code_Con_Company").Caption = "经营人"
        Me.C1DBG.Splits(0).DisplayColumns("NIGHT_MARK").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("HOLIDAY").Visible = False
        SetDGWidth(C1DBG)
        'Me.cbKeeper.DroppedDown = True
        dvConKeeper.Sort = "Code_Con_Company,CONTAINER_NO"
        Dim strTemp As String
        Dim i As Integer
        For i = 0 To dvConKeeper.Count - 1
            If strTemp <> Me.C1DBG.Columns("Code_Con_Company").CellText(i) Then
                strTemp = Me.C1DBG.Columns("Code_Con_Company").CellText(i)
                Me.cbKeeper.Items.Add(strTemp)
            End If
        Next

        dvTemp = dsTemp.DefaultView
        dvTemp.Table.Columns.Add("分类", Type.GetType("System.String"))
        dvTemp.Table.Columns.Add("箱数", Type.GetType("System.Int32"))
        dvTemp.Table.Columns.Add("夜班", Type.GetType("System.Int32"))
        dvTemp.Table.Columns.Add("假日", Type.GetType("System.Int32"))
        dvTemp.AddNew()
        dvTemp.AddNew()
        dvTemp.AddNew()
        dvTemp.AddNew()
        dvTemp.AddNew()
        dvTemp(0)(0) = "20F"
        dvTemp(1)(0) = "20E"
        dvTemp(2)(0) = "40F"
        dvTemp(3)(0) = "40E"
        dvTemp(4)(0) = "Total"
        Me.C1Stat.DataSource = dvTemp
        SetDGWidthFull(C1Stat)
        GetStatData()
    End Sub

    Private Sub GetStatData()
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "计" & dvConKeeper.Count & "箱"
        Dim iNightSum, iHolidaySum As Integer
        Dim i As Integer
        For i = 0 To dvConKeeper.Count - 1
            If Me.C1DBG.Columns("NIGHT_MARK").CellText(i) <> "0" Then
                iNightSum += 1
            End If
            If Me.C1DBG.Columns("HOLIDAY").CellText(i) <> "0" Then
                iHolidaySum += 1
            End If
        Next
        Me.C1DBG.Columns("NightDesc").FooterText = iNightSum
        Me.C1DBG.Columns("HolidayDesc").FooterText = iHolidaySum
        Dim iCon20F, iN20F, iH20F As Integer
        Dim iCon20E, iN20E, iH20E As Integer
        Dim iCon40F, iN40F, iH40F As Integer
        Dim iCon40E, iN40E, iH40E As Integer
        For i = 0 To dvConKeeper.Count - 1
            If Me.C1DBG.Columns("SIZE_CON").CellText(i) = "20" Then
                If Me.C1DBG.Columns("FULLOREMPTY").CellText(i) = "F" Or Me.C1DBG.Columns("FULLOREMPTY").CellText(i) = "L" Then
                    iCon20F += 1
                    If Me.C1DBG.Columns("NIGHT_MARK").CellText(i) <> "0" Then
                        iN20F += 1
                    End If
                    If Me.C1DBG.Columns("HOLIDAY").CellText(i) <> "0" Then
                        iH20F += 1
                    End If
                ElseIf Me.C1DBG.Columns("FULLOREMPTY").CellText(i) = "E" Then
                    iCon20E += 1
                    If Me.C1DBG.Columns("NIGHT_MARK").CellText(i) <> "0" Then
                        iN20E += 1
                    End If
                    If Me.C1DBG.Columns("HOLIDAY").CellText(i) <> "0" Then
                        iH20E += 1
                    End If
                End If
            ElseIf Me.C1DBG.Columns("SIZE_CON").CellText(i) = "40" Then
                If Me.C1DBG.Columns("FULLOREMPTY").CellText(i) = "F" Or Me.C1DBG.Columns("FULLOREMPTY").CellText(i) = "L" Then
                    iCon40F += 1
                    If Me.C1DBG.Columns("NIGHT_MARK").CellText(i) <> "0" Then
                        iN40F += 1
                    End If
                    If Me.C1DBG.Columns("HOLIDAY").CellText(i) <> "0" Then
                        iH40F += 1
                    End If
                ElseIf Me.C1DBG.Columns("FULLOREMPTY").CellText(i) = "E" Then
                    iCon40E += 1
                    If Me.C1DBG.Columns("NIGHT_MARK").CellText(i) <> "0" Then
                        iN40E += 1
                    End If
                    If Me.C1DBG.Columns("HOLIDAY").CellText(i) <> "0" Then
                        iH40E += 1
                    End If
                End If
            End If
        Next
        
        dvTemp(0)("箱数") = iCon20F
        dvTemp(1)("箱数") = iCon20E
        dvTemp(2)("箱数") = iCon40F
        dvTemp(3)("箱数") = iCon40E
        dvTemp(4)("箱数") = iCon20F + iCon20E + iCon40F + iCon40E
        dvTemp(0)("夜班") = iN20F
        dvTemp(1)("夜班") = iN20E
        dvTemp(2)("夜班") = iN40F
        dvTemp(3)("夜班") = iN40E
        dvTemp(4)("夜班") = iN20F + iN20E + iN40F + iN40E
        dvTemp(0)("假日") = iH20F
        dvTemp(1)("假日") = iH20E
        dvTemp(2)("假日") = iH40F
        dvTemp(3)("假日") = iH40E
        dvTemp(4)("假日") = iH20F + iH20E + iH40F + iH40E
        Dim j As Integer
        For i = 0 To dvTemp.Count - 1
            For j = 1 To dvTemp.Table.Columns.Count - 1
                If dvTemp(i)(j) = 0 Then
                    dvTemp(i)(j) = DBNull.Value
                End If
            Next
        Next
        Me.C1Stat.Refresh()
    End Sub

    Private Sub cbKeeper_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbKeeper.Leave
        Me.cbKeeper.Text = Me.cbKeeper.Text.Trim
    End Sub

    Private Sub cbKeeper_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbKeeper.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnEnter.Focus()
            Me.btnEnter_Click(sender, e)
            Me.cbKeeper.Focus()
        End If
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Me.cbKeeper.Text = "" Then
            dvConKeeper.RowFilter = ""
        Else
            dvConKeeper.RowFilter = "Code_Con_Company='" & Me.cbKeeper.Text & "'"
        End If
        GetStatData()
    End Sub

    Private Sub cbKeeper_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbKeeper.GotFocus
        SendKeys.Send("%{Down}")
    End Sub
End Class
