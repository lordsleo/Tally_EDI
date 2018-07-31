Imports TALLY.DBControl
Public Class FrmConRent_BillNew
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
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbShipAgent As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbShow As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbShipComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConRent_BillNew))
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBillNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbShipAgent = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbShipComp = New System.Windows.Forms.ComboBox
        Me.lbShow = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.C1DBG.Caption = "本港所有提单"
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FetchRowStyles = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(-4, 70)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(520, 424)
        Me.C1DBG.TabIndex = 585
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 586
        Me.Label1.Text = "确定提单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNo
        '
        Me.txtBillNo.Location = New System.Drawing.Point(68, 8)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(120, 21)
        Me.txtBillNo.TabIndex = 587
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 589
        Me.Label2.Tag = ""
        Me.Label2.Text = "租箱船代"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbShipAgent
        '
        Me.cbShipAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbShipAgent.Location = New System.Drawing.Point(68, 44)
        Me.cbShipAgent.MaxDropDownItems = 20
        Me.cbShipAgent.Name = "cbShipAgent"
        Me.cbShipAgent.Size = New System.Drawing.Size(120, 20)
        Me.cbShipAgent.TabIndex = 588
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(192, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 591
        Me.Label3.Tag = ""
        Me.Label3.Text = "租箱船公司"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbShipComp
        '
        Me.cbShipComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbShipComp.Location = New System.Drawing.Point(260, 44)
        Me.cbShipComp.MaxDropDownItems = 20
        Me.cbShipComp.Name = "cbShipComp"
        Me.cbShipComp.Size = New System.Drawing.Size(120, 20)
        Me.cbShipComp.TabIndex = 590
        '
        'lbShow
        '
        Me.lbShow.ForeColor = System.Drawing.Color.Blue
        Me.lbShow.Location = New System.Drawing.Point(256, 8)
        Me.lbShow.Name = "lbShow"
        Me.lbShow.Size = New System.Drawing.Size(236, 20)
        Me.lbShow.TabIndex = 592
        Me.lbShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btQuit
        '
        Me.btQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(448, 496)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 595
        Me.btQuit.Text = "退出"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(448, 40)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 594
        Me.btSave.Text = "确定"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(192, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 596
        Me.Label4.Text = "回车确定"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(384, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 597
        Me.Label5.Text = "选空重置"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(4, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 4)
        Me.GroupBox1.TabIndex = 598
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'FrmConRent_BillNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(522, 523)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.lbShow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbShipComp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbShipAgent)
        Me.Controls.Add(Me.txtBillNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C1DBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConRent_BillNew"
        Me.ShowInTaskbar = False
        Me.Text = "互租箱位按提单处理"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim sqlGetBill As String
    Dim dvGetBill As DataView
    Dim dsGetBill As New DataSet
    Public blSave As Boolean
    Public strAgent As String   '本船船代

    Private Sub FrmConRent_BillNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlShipAgent As String
        Dim dvShipAgent As DataView
        sqlShipAgent = "SELECT CODE_SHIP_AGENT, SHIPAGENT_SHORT FROM CODE_SHIP_AGENT where Mark='1' or Mark is Null ORDER BY SHIPAGENT_SHORT"
        dvShipAgent = Filldata(sqlShipAgent)
        dvShipAgent.RowFilter = "CODE_SHIP_AGENT<>'" & strAgent & "'"
        Me.cbShipAgent.DataSource = dvShipAgent
        Me.cbShipAgent.DisplayMember = "SHIPAGENT_SHORT"
        Me.cbShipAgent.ValueMember = "CODE_SHIP_AGENT"

        Dim sqlShipComp As String
        Dim dvShipComp As DataView
        sqlShipComp = "SELECT CODE_SHIPOWNER, SHIPOWNER_SHORT FROM CODE_SHIP_OWNER ORDER BY SHIPOWNER_SHORT"
        dvShipComp = Filldata(sqlShipComp)
        Me.cbShipComp.DataSource = dvShipComp
        Me.cbShipComp.DisplayMember = "SHIPOWNER_SHORT"
        Me.cbShipComp.ValueMember = "CODE_SHIPOWNER"

        sqlGetBill = "SELECT CODE_SHIP_AGENT,CODE_SHIP_COMP,BLNO, ShipAgent, ShipComp,HatchConSum,TallyConSum,TallyMark FROM View_ConTallyRent WHERE SHIP_ID =" & Ship_ID
        dvGetBill = Getdata(sqlGetBill, dsGetBill)
        Me.C1DBG.DataSource = dvGetBill
        Me.C1DBG.Columns("BLNO").Caption = "提单号"
        Me.C1DBG.Columns("ShipAgent").Caption = "互租船代"
        Me.C1DBG.Columns("ShipComp").Caption = "互租船公司"
        Me.C1DBG.Columns("HatchConSum").Caption = "舱单箱数"
        Me.C1DBG.Columns("TallyConSum").Caption = "实理箱数"
        Me.C1DBG.Columns("TallyMark").Caption = "理箱完"
        Me.C1DBG.Splits(0).DisplayColumns("BLNO").Width = 100
        Me.C1DBG.Splits(0).DisplayColumns("ShipAgent").Width = 100
        Me.C1DBG.Splits(0).DisplayColumns("ShipComp").Width = 100
        Me.C1DBG.Splits(0).DisplayColumns("HatchConSum").AutoSize()
        Me.C1DBG.Splits(0).DisplayColumns("TallyConSum").AutoSize()
        Me.C1DBG.Splits(0).DisplayColumns("TallyMark").AutoSize()

        Me.C1DBG.Splits(0).DisplayColumns("CODE_SHIP_AGENT").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("CODE_SHIP_COMP").Visible = False
        Me.C1DBG.Columns("BLNO").FooterText = "计" & dvGetBill.Count & "项"
    End Sub

    Private Sub txtBillNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBillNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtBillNo_Leave(sender, e)
        End If
    End Sub

    Dim blBeing, blFinish As Boolean

    Private Sub txtBillNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNo.Leave
        Me.txtBillNo.Text = Me.txtBillNo.Text.Trim.ToUpper
        Dim i As Integer
        If Me.txtBillNo.Text <> Me.C1DBG.Columns("BLNO").Text Then
            For i = 0 To dvGetBill.Count - 1
                If Me.txtBillNo.Text = Me.C1DBG.Columns("BLNO").CellText(i) Then
                    Exit For
                End If
            Next
            If i < dvGetBill.Count Then
                Me.C1DBG.Row = i
                Me.C1DBG.SelectedRows.Clear()
                Me.C1DBG.SelectedRows.Add(i)
                ChangeBillData()
            Else
                Me.lbShow.Text = "该提单不存在"
                blBeing = False
            End If
        Else
            ChangeBillData()
        End If
    End Sub

    Private Sub ChangeBillData() '改变提单号且存在时，更新标志和相关数据
        blBeing = True
        If Me.C1DBG.Columns("HatchConSum").Value > Me.C1DBG.Columns("TallyConSum").Value Then
            blFinish = False
            Me.lbShow.Text = "该提单存在 但未理完箱"
        Else
            blFinish = True
            Me.lbShow.Text = "该提单存在 已理完"
        End If
        Me.cbShipAgent.SelectedValue = Me.C1DBG.Columns("CODE_SHIP_AGENT").Text
        Me.cbShipComp.SelectedValue = Me.C1DBG.Columns("CODE_SHIP_COMP").Text
    End Sub

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
        If e.LastRow <> Me.C1DBG.Row Then
            Me.txtBillNo.Text = Me.C1DBG.Columns("BLNO").Text
            ChangeBillData()
        End If
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("HatchConSum").CellValue(e.Row) > Me.C1DBG.Columns("TallyConSum").CellValue(e.Row) Then
            e.CellStyle.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick

    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        If blBeing AndAlso blFinish Then
            If MessageBox.Show("确定吗？", "提示", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                '修正空值
                If Me.cbShipAgent.SelectedIndex = -1 Then
                    Me.cbShipAgent.SelectedIndex = 0
                End If
                If Me.cbShipComp.SelectedIndex = -1 Then
                    Me.cbShipComp.SelectedIndex = 0
                End If
                Dim sqlAlter As String
                sqlAlter = "update CON_TALLY_DETAIL set CODE_SHIP_AGENT=nullif('" & Me.cbShipAgent.SelectedValue & "','00'),CODE_SHIP_COMP=nullif('" & Me.cbShipComp.SelectedValue & "','00') WHERE " & _
                    " CON_TALLY_LIST_ID IN (SELECT con_tally_list_id FROM con_tally_list WHERE ship_id = " & Ship_ID & ")" & _
                    " AND CONTAINER_NO IN (SELECT container_no FROM con_hatch_cargo WHERE ship_id = " & Ship_ID & " and blno ='" & Me.txtBillNo.Text & "')"
                ExecSql(sqlAlter)
                blSave = True
                Dim i As Integer
                i = Me.C1DBG.Row
                dsGetBill.Clear()
                RunUpdata(sqlGetBill, dsGetBill)
                Me.C1DBG.Columns("BLNO").FooterText = "计" & dvGetBill.Count & "项"
                Me.C1DBG.Row = i
                Me.C1DBG.SelectedRows.Add(i)
            End If
        Else
            Me.txtBillNo.Focus()
            MessageBox.Show("请确定有效的理完箱的提单号", "提示")
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
