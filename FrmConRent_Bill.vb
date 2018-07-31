Imports TALLY.DBControl
Public Class FrmConRent_Bill
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
    Friend WithEvents lbBill As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cbShipAgent As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lbBill = New System.Windows.Forms.ListBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.cbShipAgent = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnQuit = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbBill
        '
        Me.lbBill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbBill.ItemHeight = 12
        Me.lbBill.Location = New System.Drawing.Point(3, 17)
        Me.lbBill.MultiColumn = True
        Me.lbBill.Name = "lbBill"
        Me.lbBill.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbBill.Size = New System.Drawing.Size(148, 340)
        Me.lbBill.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(196, 284)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "确定"
        '
        'cbShipAgent
        '
        Me.cbShipAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbShipAgent.Location = New System.Drawing.Point(164, 28)
        Me.cbShipAgent.MaxDropDownItems = 20
        Me.cbShipAgent.Name = "cbShipAgent"
        Me.cbShipAgent.Size = New System.Drawing.Size(160, 20)
        Me.cbShipAgent.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbBill)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(154, 361)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "提单号"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(164, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Tag = ""
        Me.Label1.Text = "确定货代"
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Location = New System.Drawing.Point(196, 328)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "退出"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(164, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Tag = ""
        Me.Label2.Text = "选空重置"
        '
        'FrmConRent_Bill
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(332, 361)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbShipAgent)
        Me.Controls.Add(Me.btnSave)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConRent_Bill"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "互租箱位 按提单处理"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public blSave As Boolean
    Dim sqlBill As String
    Dim dvBill As DataView
    Private Sub FrmConRent_Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        sqlBill = "SELECT BLNO FROM CON_HATCH_LIST WHERE SHIP_ID = " & Ship_ID & " ORDER BY BLNO"
        dvBill = Filldata(sqlBill)
        Me.lbBill.DataSource = dvBill
        Me.lbBill.ValueMember = "BLNO"
        Me.lbBill.DisplayMember = "BLNO"

        Dim sqlShipAgent As String
        Dim dvShipAgent As DataView
        sqlShipAgent = "SELECT CODE_SHIP_AGENT, SHIPAGENT_SHORT FROM CODE_SHIP_AGENT ORDER BY SHIPAGENT_SHORT"
        dvShipAgent = Filldata(sqlShipAgent)
        Me.cbShipAgent.DataSource = dvShipAgent
        Me.cbShipAgent.DisplayMember = "SHIPAGENT_SHORT"
        Me.cbShipAgent.ValueMember = "CODE_SHIP_AGENT"

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strBills As String
        Dim i As Integer
        For i = 0 To Me.lbBill.SelectedItems.Count - 1
            strBills = strBills & "'" & Me.lbBill.SelectedItems.Item(i)("BLNO") & "',"
        Next

        If strBills <> "" Then
            strBills = strBills.Substring(0, strBills.Length - 1)
            If MessageBox.Show("确定吗？", "提示", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                Dim sqlAlter As String
                sqlAlter = "update CON_TALLY_DETAIL set CODE_SHIP_AGENT=nullif('" & Me.cbShipAgent.SelectedValue & "','00') WHERE " & _
                    " CON_TALLY_LIST_ID IN (SELECT con_tally_list_id FROM con_tally_list WHERE ship_id = " & Ship_ID & ")" & _
                    " AND CONTAINER_NO IN (SELECT container_no FROM con_hatch_cargo WHERE ship_id = " & Ship_ID & " and blno in(" & strBills & "))"
                ExecSql(sqlAlter)
                Me.Close()
                blSave = True
            End If
        Else
            Me.lbBill.Focus()
            MessageBox.Show("请选择提单号", "提示")
        End If
    End Sub

    Private Sub cbShipAgent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShipAgent.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Me.Text = Convert.ToString(Me.cbShipAgent.SelectedItem)
            'Me.Button1.Text = dvBill(Me.lbBill.SelectedIndices(0))("BLNO")
            Dim dtRow As DataRowView
            dtRow = Me.lbBill.SelectedItem
            Me.Text = dtRow("BLNO")
            'Me.Text = CType(Me.cbShipAgent.SelectedItem, DataRowView)(cbShipAgent.DisplayMember)
            Me.Text = Me.cbShipAgent.SelectedItem(0)

        Catch ex As Exception

        End Try
    End Sub
End Class
