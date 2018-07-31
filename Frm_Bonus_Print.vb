Imports TALLY.DBControl
Public Class Frm_Bonus_Print
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
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents c1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDept As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bonus As System.Windows.Forms.RadioButton
    Friend WithEvents bonus1 As System.Windows.Forms.RadioButton
    Friend WithEvents bonus2 As System.Windows.Forms.RadioButton
    Friend WithEvents bonus3 As System.Windows.Forms.RadioButton
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_maker As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Manager As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Bonus_Print))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.btnQuit = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.c1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDept = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.bonus3 = New System.Windows.Forms.RadioButton
        Me.bonus2 = New System.Windows.Forms.RadioButton
        Me.bonus1 = New System.Windows.Forms.RadioButton
        Me.bonus = New System.Windows.Forms.RadioButton
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_maker = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_Manager = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.c1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(138, 499)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(121, 24)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "取消"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(5, 499)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(121, 24)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "打印"
        '
        'c1DBG
        '
        Me.c1DBG.AllowFilter = True
        Me.c1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.c1DBG.AllowSort = True
        Me.c1DBG.CaptionHeight = 18
        Me.c1DBG.CollapseColor = System.Drawing.Color.Black
        Me.c1DBG.DataChanged = False
        Me.c1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1DBG.ExpandColor = System.Drawing.Color.Black
        Me.c1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.c1DBG.Location = New System.Drawing.Point(4, 39)
        Me.c1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.c1DBG.Name = "c1DBG"
        Me.c1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1DBG.PreviewInfo.ZoomFactor = 75
        Me.c1DBG.PrintInfo.ShowOptionsDialog = False
        Me.c1DBG.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.c1DBG.RowDivider = GridLines1
        Me.c1DBG.RowHeight = 16
        Me.c1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1DBG.ScrollTips = False
        Me.c1DBG.Size = New System.Drawing.Size(752, 455)
        Me.c1DBG.TabIndex = 7
        Me.c1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        ", 0, 748, 451</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "48, 451</ClientArea></Blob>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "部门名称"
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(81, 11)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(170, 20)
        Me.txtDept.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bonus3)
        Me.GroupBox1.Controls.Add(Me.bonus2)
        Me.GroupBox1.Controls.Add(Me.bonus1)
        Me.GroupBox1.Controls.Add(Me.bonus)
        Me.GroupBox1.Location = New System.Drawing.Point(253, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 32)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "打印选择"
        '
        'bonus3
        '
        Me.bonus3.Location = New System.Drawing.Point(345, 11)
        Me.bonus3.Name = "bonus3"
        Me.bonus3.Size = New System.Drawing.Size(60, 19)
        Me.bonus3.TabIndex = 3
        Me.bonus3.Text = "奖金4"
        '
        'bonus2
        '
        Me.bonus2.Location = New System.Drawing.Point(242, 11)
        Me.bonus2.Name = "bonus2"
        Me.bonus2.Size = New System.Drawing.Size(60, 19)
        Me.bonus2.TabIndex = 2
        Me.bonus2.Text = "奖金3"
        '
        'bonus1
        '
        Me.bonus1.Location = New System.Drawing.Point(139, 11)
        Me.bonus1.Name = "bonus1"
        Me.bonus1.Size = New System.Drawing.Size(60, 19)
        Me.bonus1.TabIndex = 1
        Me.bonus1.Text = "奖金2"
        '
        'bonus
        '
        Me.bonus.Checked = True
        Me.bonus.Location = New System.Drawing.Point(36, 11)
        Me.bonus.Name = "bonus"
        Me.bonus.Size = New System.Drawing.Size(60, 19)
        Me.bonus.TabIndex = 0
        Me.bonus.TabStop = True
        Me.bonus.Text = "奖金1"
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(643, 502)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(95, 21)
        Me.DTP1.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(579, 503)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "打印日期"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_maker
        '
        Me.txt_maker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_maker.Location = New System.Drawing.Point(499, 502)
        Me.txt_maker.Name = "txt_maker"
        Me.txt_maker.Size = New System.Drawing.Size(74, 21)
        Me.txt_maker.TabIndex = 20
        Me.txt_maker.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(426, 503)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "制表人"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Manager
        '
        Me.txt_Manager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Manager.Location = New System.Drawing.Point(339, 502)
        Me.txt_Manager.Name = "txt_Manager"
        Me.txt_Manager.Size = New System.Drawing.Size(74, 21)
        Me.txt_Manager.TabIndex = 18
        Me.txt_Manager.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(265, 502)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "部门负责人"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Bonus_Print
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(758, 523)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_maker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Manager)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.c1DBG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDept)
        Me.Name = "Frm_Bonus_Print"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "打印奖金单"
        CType(Me.c1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim FieldName As String
    Dim ds As New DataSet
    Dim dsBonus As New DataSet
    Dim dwBonus As New DataView
    Dim sqlda As New SqlClient.SqlDataAdapter
    Private Sub Frm_Bonus_Print_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView
        Dim sqlstr As String
        Dim dsDept As New DataSet

        Me.StartPosition = FormStartPosition.CenterScreen
        'G_DeptCode为用户部门
        sqlstr = "select dept_code,dept_name from department where rtrim(dept_code)<>'00' and dept_code like '" & G_DeptCode + "%" & "'  Order by dept_code"
        dw = Getdata(sqlstr, dsDept)
        txtDept.DataSource = dsDept.Tables(0).DefaultView
        txtDept.DisplayMember = "dept_name"
        txtDept.ValueMember = "dept_code"

        DTP1.Value = System.DateTime.Now

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub txtDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDept.SelectedIndexChanged

    End Sub

    Private Sub txtDept_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDept.SelectionChangeCommitted
        Dim sqlstr As String
        Dim Dept_Code As String

        Dept_Code = txtDept.SelectedValue

        sqlstr = "select * from view_bonus where dept_code='" & Dept_Code & "' Order by dept_code,xuhao"
        dwBonus = Getdata(sqlstr, dsBonus)
        Me.c1DBG.DataSource = dwBonus
        Me.c1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
        Me.c1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
        Me.c1DBG.Splits(0).DisplayColumns.Item(2).Visible = False
        Me.c1DBG.Splits(0).DisplayColumns.Item(3).Visible = False

        Me.c1DBG.Columns.Item(4).Caption = "工号"
        Me.c1DBG.Splits(0).DisplayColumns.Item(4).AllowFocus = False
        Me.c1DBG.Columns.Item(5).Caption = "姓名"
        Me.c1DBG.Splits(0).DisplayColumns.Item(5).AllowFocus = False
        Me.c1DBG.Columns.Item(6).Caption = "金额1"
        Me.c1DBG.Columns.Item(7).Caption = "金额2"
        Me.c1DBG.Columns.Item(8).Caption = "金额3"
        Me.c1DBG.Columns.Item(9).Caption = "金额4"
        Me.c1DBG.Splits(0).DisplayColumns.Item(10).Visible = False

        SetDeptDetail()

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        Dim Col_B As Integer
        Dim i As Int16
        Dim SourceFileName As String
        Dim Total_Bonus As Single

        KillExcelProcess()

        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "Report.xls"
            SourceFileName = PathStr + "ReportTemplet.xls"
            FileCopy(SourceFileName, FilePath)

            xlApp = New Excel.Application     '注意一定要有New，这样才能有EXCEL进程的接口实例
            xlBook = xlApp.Workbooks.Add(FilePath)    '不要用New，这一句已经使xlBook指向了实例
            xlSheet = xlBook.Worksheets("bonus")

            xlBook.Sheets("bonus").Select()
            xlSheet.Application.Visible = True

            Total_Bonus = 0
            Row = 4
            Col_B = 1
            Me.c1DBG.MoveFirst()
            For i = 0 To dsBonus.Tables(0).Rows.Count - 1 '数据
                Col = Col_B
                xlSheet.Cells(Row, Col) = Str(i + 1)
                Col = Col + 1
                xlSheet.Cells(Row, Col) = Me.c1DBG.Columns("name").Text.ToString
                Col = Col + 1
                xlSheet.Cells(Row, Col) = Me.c1DBG.Columns(FieldName).Text.ToString
                Total_Bonus = Total_Bonus + Math.Round(CType(Me.c1DBG.Columns(FieldName).Text.ToString, Single), 2)
                Row = Row + 1
                If Row > 40 Then
                    Row = 4
                    Col_B = 5
                End If
                Me.c1DBG.MoveNext()
            Next i
            xlSheet.Cells(41, 2) = Math.Round(Total_Bonus, 2)
            xlSheet.Cells(41, 7) = DBControl.MakeBigWord(Math.Round(Total_Bonus, 2))
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub Frm_Bonus_Print_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

    End Sub

    Private Sub c1DBG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1DBG.Click

    End Sub

    Private Sub c1DBG_HeadClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles c1DBG.HeadClick

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox1.Click

    End Sub

    Private Sub bonus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bonus.CheckedChanged
        FieldName = "bonus"
    End Sub

    Private Sub bonus1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bonus1.CheckedChanged
        FieldName = "bonus1"
    End Sub

    Private Sub bonus2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bonus2.CheckedChanged
        FieldName = "bonus2"
    End Sub

    Private Sub bonus3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bonus3.CheckedChanged
        FieldName = "bonus3"
    End Sub

    '取得部门负责人、制表人
    Private Function SetDeptDetail()
        Dim dsDept As New DataSet
        Dim dsUser As New DataSet
        Dim dw As New DataView
        Dim sqlstr As String
        Dim Dept_Code As String

        Dept_Code = txtDept.SelectedValue

        txt_maker.Text = ""
        txt_Manager.Text = ""

        dsDept.Reset()
        sqlstr = "select * from DEPARTMENT where dept_code='" + Dept_Code + "'"
        dw = DBControl.Getdata(sqlstr, dsDept)
        txt_Manager.Text = dsDept.Tables(0).Rows(0)("dept_manag")

        dsUser.Reset()
        sqlstr = "select * from SYSTEM_USER_TABLE where SERIAL_NAM='" + G_User_Serial + "'"
        dw = DBControl.Getdata(sqlstr, dsUser)
        txt_maker.Text = dsUser.Tables(0).Rows(0)("NAME")

    End Function

End Class
