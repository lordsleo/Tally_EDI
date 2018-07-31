Imports TALLY.DBControl
Public Class FrmFindPort
    Inherits System.Windows.Forms.Form
    Dim dstemp As New DataSet
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
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btFind As System.Windows.Forms.Button
    Friend WithEvents btSure As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmFindPort))
        Me.txtFind = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btFind = New System.Windows.Forms.Button
        Me.btSure = New System.Windows.Forms.Button
        Me.btCancel = New System.Windows.Forms.Button
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(84, 12)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(180, 21)
        Me.txtFind.TabIndex = 0
        Me.txtFind.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "输入检索条件"
        '
        'btFind
        '
        Me.btFind.Location = New System.Drawing.Point(268, 12)
        Me.btFind.Name = "btFind"
        Me.btFind.Size = New System.Drawing.Size(44, 23)
        Me.btFind.TabIndex = 8
        Me.btFind.Text = "查找"
        '
        'btSure
        '
        Me.btSure.Location = New System.Drawing.Point(112, 148)
        Me.btSure.Name = "btSure"
        Me.btSure.Size = New System.Drawing.Size(56, 23)
        Me.btSure.TabIndex = 9
        Me.btSure.Text = "确认"
        '
        'btCancel
        '
        Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancel.Location = New System.Drawing.Point(176, 148)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(54, 23)
        Me.btCancel.TabIndex = 10
        Me.btCancel.Text = "取消"
        '
        'C1DBG
        '
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(4, 42)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.RecordSelectorWidth = 17
        Me.C1DBG.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBG.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.Size = New System.Drawing.Size(328, 100)
        Me.C1DBG.TabIndex = 11
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style14{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" & _
        "tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 324, 96</ClientRect><BorderSide>0</BorderSide><CaptionSty" & _
        "le parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><Ev" & _
        "enRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=" & _
        """Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group" & _
        """ me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle" & _
        " parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4" & _
        """ /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""Reco" & _
        "rdSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style" & _
        " parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedSt" & _
        "yles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style" & _
        " parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style pa" & _
        "rent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style par" & _
        "ent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style par" & _
        "ent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""" & _
        "Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style pa" & _
        "rent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>" & _
        "1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><C" & _
        "lientArea>0, 0, 324, 96</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14""" & _
        " /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'FrmFindPort
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btCancel
        Me.ClientSize = New System.Drawing.Size(336, 173)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btSure)
        Me.Controls.Add(Me.btFind)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmFindPort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "港口代码查找"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFind.Click
        Dim str As String
        dstemp.Reset()
        C1DBG.DataSource = Getdata("select CODE_PORT,PORT_ENG,PORT_CHA from code_port where code_port  like '" & Me.txtFind.Text.ToUpper.Trim() & "%' or PORT_CHA like '" & Me.txtFind.Text.ToUpper.Trim() & "%' or PORT_ENG like '" & Me.txtFind.Text.ToUpper.Trim() & "%'", dstemp)

        Me.C1DBG.Columns.Item("CODE_PORT").Caption = "港名代码"
        Me.C1DBG.Columns.Item("PORT_ENG").Caption = "港口英文名称"
        Me.C1DBG.Columns.Item("PORT_CHA").Caption = "港口中文名称"

    End Sub

    Private Sub btSure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSure.Click
        If dstemp.Tables.Count > 0 Then
            If dstemp.Tables(0).Rows.Count > 0 Then
                PortCode = Me.C1DBG.Columns("code_port").Text.Trim()
            Else
                PortCode = ""
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        PortCode = ""
        Me.Close()
    End Sub

    Private Sub txtFind_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFind.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btFind_Click(sender, e)
            Me.C1DBG.Focus()
        End If
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        If dstemp.Tables(0).Rows.Count > 0 Then
            PortCode = Me.C1DBG.Columns("code_port").Text.Trim()
            Me.Close()
        Else
            PortCode = ""
        End If

    End Sub
End Class
