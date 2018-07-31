Imports TALLY.DBControl
Public Class FrmConImageCargo_BayNo
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtContainerNo.KeyDown, AddressOf FrmConImageCargo_BayNo_KeyDown
        AddHandler txtNewBay.KeyDown, AddressOf FrmConImageCargo_BayNo_KeyDown
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtContainerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents C1Repeat As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOldBay As System.Windows.Forms.TextBox
    Friend WithEvents txtNewBay As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConImageCargo_BayNo))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtContainerNo = New System.Windows.Forms.TextBox
        Me.txtOldBay = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNewBay = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1Repeat = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btQuit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Repeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "箱号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContainerNo
        '
        Me.txtContainerNo.Location = New System.Drawing.Point(74, 8)
        Me.txtContainerNo.MaxLength = 12
        Me.txtContainerNo.Name = "txtContainerNo"
        Me.txtContainerNo.TabIndex = 0
        Me.txtContainerNo.Text = ""
        '
        'txtOldBay
        '
        Me.txtOldBay.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtOldBay.Location = New System.Drawing.Point(74, 34)
        Me.txtOldBay.MaxLength = 8
        Me.txtOldBay.Name = "txtOldBay"
        Me.txtOldBay.ReadOnly = True
        Me.txtOldBay.TabIndex = 1
        Me.txtOldBay.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "原贝号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNewBay
        '
        Me.txtNewBay.Location = New System.Drawing.Point(74, 60)
        Me.txtNewBay.MaxLength = 8
        Me.txtNewBay.Name = "txtNewBay"
        Me.txtNewBay.TabIndex = 2
        Me.txtNewBay.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "新贝号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(3, 17)
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
        Me.C1DBG.Size = New System.Drawing.Size(206, 236)
        Me.C1DBG.TabIndex = 6
        Me.C1DBG.Text = "C1TrueDBGrid1"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 202, 232</ClientRect><BorderSide>0</BorderSide><CaptionSt" & _
        "yle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><E" & _
        "venRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me" & _
        "=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Grou" & _
        "p"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyl" & _
        "e parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style" & _
        "4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""Rec" & _
        "ordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Styl" & _
        "e parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedS" & _
        "tyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Styl" & _
        "e parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style p" & _
        "arent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style pa" & _
        "rent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style pa" & _
        "rent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=" & _
        """Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style p" & _
        "arent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits" & _
        ">1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><" & _
        "ClientArea>0, 0, 202, 232</ClientArea><PrintPageHeaderStyle parent="""" me=""Style1" & _
        "4"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'C1Repeat
        '
        Me.C1Repeat.CaptionHeight = 18
        Me.C1Repeat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Repeat.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Repeat.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1Repeat.Location = New System.Drawing.Point(3, 17)
        Me.C1Repeat.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1Repeat.Name = "C1Repeat"
        Me.C1Repeat.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Repeat.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Repeat.PreviewInfo.ZoomFactor = 75
        Me.C1Repeat.RecordSelectorWidth = 16
        Me.C1Repeat.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Repeat.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1Repeat.RowHeight = 16
        Me.C1Repeat.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Repeat.Size = New System.Drawing.Size(168, 158)
        Me.C1Repeat.TabIndex = 7
        Me.C1Repeat.Text = "C1TrueDBGrid1"
        Me.C1Repeat.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 164, 154</ClientRect><BorderSide>0</BorderSide><CaptionSt" & _
        "yle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><E" & _
        "venRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me" & _
        "=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Grou" & _
        "p"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyl" & _
        "e parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style" & _
        "4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""Rec" & _
        "ordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Styl" & _
        "e parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedS" & _
        "tyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Styl" & _
        "e parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style p" & _
        "arent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style pa" & _
        "rent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style pa" & _
        "rent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=" & _
        """Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style p" & _
        "arent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits" & _
        ">1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><" & _
        "ClientArea>0, 0, 164, 154</ClientArea><PrintPageHeaderStyle parent="""" me=""Style1" & _
        "4"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(146, 270)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 4
        Me.btQuit.Text = "关闭"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C1Repeat)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 178)
        Me.GroupBox1.TabIndex = 578
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "重复的贝位"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.C1DBG)
        Me.GroupBox2.Location = New System.Drawing.Point(176, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(212, 256)
        Me.GroupBox2.TabIndex = 579
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "修改的贝位"
        '
        'FrmConImageCargo_BayNo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(388, 300)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.txtNewBay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOldBay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtContainerNo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConImageCargo_BayNo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "修改贝位号"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Repeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim iConID As Integer   '箱信息ID，且用于判断是否找到
    Dim strFind As String   '查找箱号
    Dim dvFind As New DataView
    Dim dvTemp As New DataView  '存放修改过的临时数据
    Dim sqlRepeat As String
    Dim dvRepeat As New DataView
    Dim dsRepeat As New DataSet

    Private Sub FrmConImageCargo_BayNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '显示重复贝位
            sqlRepeat = "SELECT BAYNO,CONTAINER_NO FROM CON_IMAGE WHERE SHIP_ID = " & Ship_ID & " " & _
                       "and BAYNO in (SELECT BAYNO FROM CON_IMAGE WHERE SHIP_ID = " & Ship_ID & " group by BAYNO having count(*)>1)"
            dvRepeat = Getdata(sqlRepeat, dsRepeat)
            Me.C1Repeat.DataSource = dvRepeat
            Me.C1Repeat.Splits(0).DisplayColumns("BAYNO").AutoSize()
            Me.C1Repeat.Splits(0).DisplayColumns("CONTAINER_NO").AutoSize()
            Me.C1Repeat.Columns("BAYNO").Caption = "贝位号"
            Me.C1Repeat.Columns("CONTAINER_NO").Caption = "箱号"
            '列出修改的箱贝位号
            dvTemp.Table = New DataTable("TT")
            dvTemp.Table.Columns.Add("CONTAINER_NO", GetType(String))
            dvTemp.Table.Columns.Add("OldBay", GetType(String))
            dvTemp.Table.Columns.Add("NewBay", GetType(String))
            Me.C1DBG.DataSource = dvTemp
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").AutoSize()
            Me.C1DBG.Splits(0).DisplayColumns("OldBay").AutoSize()
            Me.C1DBG.Splits(0).DisplayColumns("NewBay").AutoSize()
            Me.C1DBG.Columns("CONTAINER_NO").Caption = "箱号"
            Me.C1DBG.Columns("OldBay").Caption = "原贝位"
            Me.C1DBG.Columns("NewBay").Caption = "新贝位"
            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.PaleGoldenrod
            Me.C1DBG.Columns("CONTAINER_NO").FooterText = "计" & dvTemp.Count & "项"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
        If Len(Trim(str)) = 12 And Mid(Trim(str), 5, 1) = " " Then
            str = Mid(Trim(str), 1, 4) & Mid(Trim(str), 6, 7)
        ElseIf Len(Trim(str)) <> 11 Then
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

    Private Sub txtContainerNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContainerNo.Leave
        iConID = 0 '重置
        txtContainerNo.Text = Me.txtContainerNo.Text.Trim.ToUpper()
        'If (CheckConNO(Me.txtContainerNo.Text) <> 0) Then
        strFind = "select CON_IMAGE_ID,CONTAINER_NO,BAYNO from CON_IMAGE where SHIP_ID = " & Ship_ID & " and CONTAINER_NO Like '%" & txtContainerNo.Text & "%'"
        dvFind = Filldata(strFind)
        If dvFind.Count = 1 Then
            iConID = dvFind(0)("CON_IMAGE_ID")
            txtContainerNo.Text = dvFind(0)("CONTAINER_NO")
            If (IsDBNull(dvFind(0)("BAYNO")) = False) Then
                txtOldBay.Text = dvFind(0)("BAYNO")
            Else
                txtOldBay.Text = ""
            End If
            txtNewBay.Text = txtOldBay.Text
        ElseIf dvFind.Count = 0 Then
            'MessageBox.Show("不能找到该箱信息", "提示")
            txtOldBay.Clear()
            txtNewBay.Clear()
            dvFind.Dispose()
            txtContainerNo.Focus()
        ElseIf dvFind.Count > 1 Then
            'MessageBox.Show("该箱号重复，不能修改", "提示")
            txtOldBay.Clear()
            txtNewBay.Clear()
            dvFind.Dispose()
            txtContainerNo.Focus()
        End If
        'Else
        'MessageBox.Show("箱号有误，请检查", "提示")
        'End If
    End Sub

    Private Sub txtNewBay_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewBay.Leave
        txtNewBay.Text = txtNewBay.Text.Trim
        If (iConID > 0) Then '找到且唯一
            '新贝位不空有效且与原贝位不同，修改
            If txtNewBay.Text.Length > 0 Then
                If txtNewBay.Text Like "######" Then
                    If txtNewBay.Text <> txtOldBay.Text Then
                        '直接修改，不提示可能出现的贝位重复
                        Dim strEditBay As String
                        strEditBay = "update CON_IMAGE set BAYNO='" & txtNewBay.Text & "' where CON_IMAGE_ID=" & iConID & ""
                        ExecSql(strEditBay)
                        '更新重复贝位
                        dsRepeat.Clear()
                        RunUpdata(sqlRepeat, dsRepeat)
                        '显示修改数据
                        Me.C1DBG.Row = dvTemp.Count
                        Me.C1DBG.Columns("CONTAINER_NO").Text = Me.txtContainerNo.Text
                        Me.C1DBG.Columns("OldBay").Text = Me.txtOldBay.Text
                        Me.C1DBG.Columns("NewBay").Text = Me.txtNewBay.Text
                        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "计" & dvTemp.Count & "项"
                    End If
                Else
                    MessageBox.Show("新贝位号格式不正确，修改无效", "提示")
                End If
            End If
        End If
    End Sub

    Private Sub FrmConImageCargo_BayNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtContainerNo.Focused Then
                Me.txtNewBay.Focus()
            ElseIf Me.txtNewBay.Focused Then
                Me.txtContainerNo.Focus()
            End If
        End If
    End Sub

    Private Sub FrmConImageCargo_BayNo_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If dvRepeat.Count > 0 Then
            If MessageBox.Show("存在重复贝位，仍然要退出吗？", "警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                Me.Close()
            Else

            End If
        End If
    End Sub
End Class
