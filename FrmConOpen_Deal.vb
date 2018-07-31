Imports TALLY.DBControl
Public Class FrmConOpen_Deal
    Inherits System.Windows.Forms.Form

    Dim sqlContain As String
    Dim dvContain As New DataView()
    Dim i, iChecked As Integer

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
    Friend WithEvents txtOriginalSealNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtContainer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConOpen_Deal))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.txtOriginalSealNO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContainer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOriginalSealNO
        '
        Me.txtOriginalSealNO.Location = New System.Drawing.Point(234, 172)
        Me.txtOriginalSealNO.MaxLength = 20
        Me.txtOriginalSealNO.Name = "txtOriginalSealNO"
        Me.txtOriginalSealNO.TabIndex = 243
        Me.txtOriginalSealNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(174, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 18)
        Me.Label4.TabIndex = 245
        Me.Label4.Text = "铅封号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContainer
        '
        Me.txtContainer.Location = New System.Drawing.Point(68, 172)
        Me.txtContainer.MaxLength = 12
        Me.txtContainer.Name = "txtContainer"
        Me.txtContainer.TabIndex = 242
        Me.txtContainer.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 244
        Me.Label3.Text = "集装箱号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowSort = True
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1DBG.Location = New System.Drawing.Point(0, 2)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowDivider = GridLines1
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.ScrollTips = False
        Me.C1DBG.Size = New System.Drawing.Size(340, 166)
        Me.C1DBG.TabIndex = 246
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(172, 200)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 247
        Me.btQuit.Text = "退出"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(104, 200)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 248
        Me.btSave.Text = "确定"
        '
        'FrmConOpen_Deal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(340, 229)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btSave, Me.btQuit, Me.C1DBG, Me.txtOriginalSealNO, Me.Label4, Me.txtContainer, Me.Label3})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConOpen_Deal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "拆箱查验信息 处理"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConOpen_Deal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetData()
        Me.txtContainer.Focus()
    End Sub

    Private Sub SetData()
        sqlContain = "SELECT CON_TALLY_DETAIL_ID, CONTAINER_NO, BAYNO, SIZE_CON, SEALNO, EFL_Name, OPENBOX FROM CON_TALLY_DETAIL LEFT OUTER JOIN Code_ConEFLType ON FULLOREMPTY = EFL_Code LEFT OUTER JOIN CON_TALLY_LIST ON CON_TALLY_DETAIL.CON_TALLY_LIST_ID = CON_TALLY_LIST.CON_TALLY_LIST_ID WHERE ship_id = '" & Ship_ID & "'"
        dvContain = Filldata(sqlContain)
        Me.C1DBG.DataSource = dvContain
        Me.C1DBG.Splits(0).DisplayColumns("CON_TALLY_DETAIL_ID").Visible = False
        Me.C1DBG.Columns("CONTAINER_NO").Caption = "集装箱号"
        Me.C1DBG.Columns("BAYNO").Caption = "贝位号"
        Me.C1DBG.Columns("SIZE_CON").Caption = "箱尺寸"
        Me.C1DBG.Columns("SEALNO").Caption = "铅封号"
        Me.C1DBG.Columns("EFL_Name").Caption = "空重箱"
        Me.C1DBG.Columns("OPENBOX").Caption = "查验"

        Me.C1DBG.Columns("OPENBOX").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
        Me.C1DBG.Columns("OPENBOX").ValueItems.Translate = True
        Dim v1 As New C1.Win.C1TrueDBGrid.ValueItem()
        v1.DisplayValue = "未验"
        v1.Value = 0
        Me.C1DBG.Columns("OPENBOX").ValueItems.Values.Add(v1)
        Dim v2 As New C1.Win.C1TrueDBGrid.ValueItem()
        v2.DisplayValue = "已验"
        v2.Value = 1
        Me.C1DBG.Columns("OPENBOX").ValueItems.Values.Add(v2)

        iChecked = 0
        For i = 0 To dvContain.Count - 1
            If dvContain(i)("OPENBOX") = 1 Then
                iChecked += 1
            End If
        Next
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "合计" & dvContain.Count & "条"
        Me.C1DBG.Columns.Item("BAYNO").FooterText = "查验" & iChecked & "条"
        Me.C1DBG.FetchRowStyles = True
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

        Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 80
        Me.C1DBG.Splits(0).DisplayColumns("BAYNO").Width = 50
        Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 40
        Me.C1DBG.Splits(0).DisplayColumns("SEALNO").Width = 60
        Me.C1DBG.Splits(0).DisplayColumns("EFL_Name").Width = 35
        Me.C1DBG.Splits(0).DisplayColumns("OPENBOX").Width = 40
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlUpdateOpenBox As String
        sqlUpdateOpenBox = "update con_tally_detail set OPENBOX = 1, SEALNO = '" & Trim(Me.txtOriginalSealNO.Text) & "' where CONTAINER_NO = '" & Trim(txtContainer.Text) & "'"
        If Trim(txtContainer.Text) <> "" And dvContain.Count > 0 Then
            If Trim(Me.txtOriginalSealNO.Text) <> "" Then
                ExecSql(sqlUpdateOpenBox)
                SetData()
                'txtContainer_Leave(sender, e)
            Else
                MessageBox.Show("请输入铅封号", "操作提示")
                Me.txtOriginalSealNO.Focus()
            End If
        Else
            MessageBox.Show("请输入正确的集装箱号", "操作提示")
            Me.txtContainer.Focus()
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtContainer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContainer.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtOriginalSealNO.Focus()
            txtContainer_Leave(sender, e)
        End If
    End Sub

    Private Sub txtOriginalSealNO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOriginalSealNO.KeyDown
        If e.KeyCode = Keys.Enter Then Me.btSave.Focus()
    End Sub

    Private Sub txtContainer_Leave(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles txtContainer.Leave
        dvContain.RowFilter = "CONTAINER_NO='" & Trim(Me.txtContainer.Text) & "'"
        If dvContain.Count = 0 Then
            dvContain.RowFilter = "1=1"
            'Me.C1DBG.DataSource = dvContain
        End If
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("OPENBOX").CellValue(e.Row) = 0 Then
            e.CellStyle.BackColor = System.Drawing.Color.White
        ElseIf Me.C1DBG.Columns("OPENBOX").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        End If
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        Me.txtContainer.Text = Me.C1DBG.Columns("CONTAINER_NO").Text
        Me.txtOriginalSealNO.Text = Me.C1DBG.Columns("SEALNO").Text
    End Sub
End Class
