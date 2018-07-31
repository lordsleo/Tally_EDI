Imports TALLY.DBControl
Public Class Frm_Bonus_Add
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim dsBonus As New DataSet()
    Dim dwBonus As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDept As System.Windows.Forms.ComboBox
    Friend WithEvents c1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Bonus_Add))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.txtDept = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.c1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnQuit = New System.Windows.Forms.Button
        CType(Me.c1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(74, 10)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(170, 20)
        Me.txtDept.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "部门名称"
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
        Me.c1DBG.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveDown
        Me.c1DBG.ExpandColor = System.Drawing.Color.Black
        Me.c1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.c1DBG.Location = New System.Drawing.Point(3, 37)
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
        Me.c1DBG.Size = New System.Drawing.Size(752, 412)
        Me.c1DBG.TabIndex = 2
        Me.c1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        ", 0, 748, 408</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
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
        "48, 408</ClientArea></Blob>"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(170, 455)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 24)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "确认"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(392, 455)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(121, 24)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "取消"
        '
        'Frm_Bonus_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(758, 481)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.c1DBG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDept)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_Bonus_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "奖金录入"
        CType(Me.c1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_Bonus_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dsDept As New DataSet()

        Me.StartPosition = FormStartPosition.CenterScreen
        'G_DeptCode               为用户部门
        sqlstr = "select dept_code,dept_name from department where rtrim(dept_code)<>'00' and dept_code like '" & G_DeptCode + "%" & "' Order by dept_code"
        dw = Getdata(sqlstr, dsDept)
        txtDept.DataSource = dsDept.Tables(0).DefaultView
        txtDept.DisplayMember = "dept_name"
        txtDept.ValueMember = "dept_code"

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

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim i As Int16
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim WorkNo As String

        Try
            If MsgBox("你确认要保存吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                For i = 0 To dwBonus.Count - 1
                    WorkNo = dwBonus(i).Item("work_no")
                    sqlstr = "select * from rs_workersalary where work_no='" & WorkNo & "'"
                    dw = Updatedata(sqlda, sqlstr, ds)
                    If ds.Tables(0).Rows.Count > 0 Then
                        ds.Tables(0).Rows(0).Item("bonus") = dwBonus(i).Item("bonus")
                        ds.Tables(0).Rows(0).Item("bonus1") = dwBonus(i).Item("bonus1")
                        ds.Tables(0).Rows(0).Item("bonus2") = dwBonus(i).Item("bonus2")
                        ds.Tables(0).Rows(0).Item("bonus3") = dwBonus(i).Item("bonus3")
                        sqlda.Update(ds)
                    End If
                Next
                MsgBox("保存完毕！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub c1DBG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1DBG.Click

    End Sub

    Private Sub Frm_Bonus_Add_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        
    End Sub

    Private Sub c1DBG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles c1DBG.KeyPress
 
    End Sub
End Class
