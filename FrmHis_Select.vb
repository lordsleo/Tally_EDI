Public Class FrmHis_Select
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtDept.KeyDown, AddressOf FrmHis_Select_KeyDown
        AddHandler txtWorker.KeyDown, AddressOf FrmHis_Select_KeyDown
        AddHandler txtOper.KeyDown, AddressOf FrmHis_Select_KeyDown
        AddHandler txtTable.KeyDown, AddressOf FrmHis_Select_KeyDown
        AddHandler txtOldData.KeyDown, AddressOf FrmHis_Select_KeyDown
        AddHandler ckbBegin.KeyDown, AddressOf FrmHis_Select_KeyDown
        AddHandler dtpBegin.KeyDown, AddressOf FrmHis_Select_KeyDown
        AddHandler ckbEnd.KeyDown, AddressOf FrmHis_Select_KeyDown
        AddHandler dtpEnd.KeyDown, AddressOf FrmHis_Select_KeyDown

        AddHandler txtDept.Leave, AddressOf FrmHis_Select_Leave
        AddHandler txtWorker.Leave, AddressOf FrmHis_Select_Leave
        AddHandler txtOper.Leave, AddressOf FrmHis_Select_Leave
        AddHandler txtTable.Leave, AddressOf FrmHis_Select_Leave
        AddHandler txtOldData.Leave, AddressOf FrmHis_Select_Leave

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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtTable As System.Windows.Forms.TextBox
    Friend WithEvents 操作表名 As System.Windows.Forms.Label
    Friend WithEvents txtOper As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtWorker As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDept As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtOldData As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbBegin As System.Windows.Forms.CheckBox
    Friend WithEvents ckbEnd As System.Windows.Forms.CheckBox
    Friend WithEvents gbTime As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.txtTable = New System.Windows.Forms.TextBox
        Me.操作表名 = New System.Windows.Forms.Label
        Me.txtOper = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtWorker = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDept = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtOldData = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbTime = New System.Windows.Forms.GroupBox
        Me.ckbEnd = New System.Windows.Forms.CheckBox
        Me.ckbBegin = New System.Windows.Forms.CheckBox
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.dtpBegin = New System.Windows.Forms.DateTimePicker
        Me.gbTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(136, 264)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 8
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(64, 264)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 7
        Me.btSave.Text = "确认"
        '
        'txtTable
        '
        Me.txtTable.Location = New System.Drawing.Point(104, 112)
        Me.txtTable.Name = "txtTable"
        Me.txtTable.Size = New System.Drawing.Size(120, 21)
        Me.txtTable.TabIndex = 3
        Me.txtTable.Text = ""
        '
        '操作表名
        '
        Me.操作表名.Location = New System.Drawing.Point(32, 112)
        Me.操作表名.Name = "操作表名"
        Me.操作表名.Size = New System.Drawing.Size(72, 23)
        Me.操作表名.TabIndex = 447
        Me.操作表名.Text = "操作表名"
        Me.操作表名.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOper
        '
        Me.txtOper.Location = New System.Drawing.Point(104, 80)
        Me.txtOper.Name = "txtOper"
        Me.txtOper.Size = New System.Drawing.Size(120, 21)
        Me.txtOper.TabIndex = 2
        Me.txtOper.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 445
        Me.Label3.Text = "操作"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWorker
        '
        Me.txtWorker.Location = New System.Drawing.Point(104, 48)
        Me.txtWorker.Name = "txtWorker"
        Me.txtWorker.Size = New System.Drawing.Size(120, 21)
        Me.txtWorker.TabIndex = 1
        Me.txtWorker.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(32, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 23)
        Me.Label6.TabIndex = 443
        Me.Label6.Text = "操作员"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(104, 16)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(120, 21)
        Me.txtDept.TabIndex = 0
        Me.txtDept.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(32, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 441
        Me.Label7.Text = "操作部门"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOldData
        '
        Me.txtOldData.Location = New System.Drawing.Point(104, 144)
        Me.txtOldData.Name = "txtOldData"
        Me.txtOldData.Size = New System.Drawing.Size(120, 21)
        Me.txtOldData.TabIndex = 4
        Me.txtOldData.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 449
        Me.Label1.Text = "操作前数据"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbTime
        '
        Me.gbTime.Controls.Add(Me.ckbEnd)
        Me.gbTime.Controls.Add(Me.ckbBegin)
        Me.gbTime.Controls.Add(Me.dtpEnd)
        Me.gbTime.Controls.Add(Me.dtpBegin)
        Me.gbTime.Location = New System.Drawing.Point(24, 176)
        Me.gbTime.Name = "gbTime"
        Me.gbTime.Size = New System.Drawing.Size(216, 80)
        Me.gbTime.TabIndex = 6
        Me.gbTime.TabStop = False
        Me.gbTime.Text = "操作时间"
        '
        'ckbEnd
        '
        Me.ckbEnd.Location = New System.Drawing.Point(8, 48)
        Me.ckbEnd.Name = "ckbEnd"
        Me.ckbEnd.Size = New System.Drawing.Size(80, 20)
        Me.ckbEnd.TabIndex = 2
        Me.ckbEnd.Text = "结束时间"
        '
        'ckbBegin
        '
        Me.ckbBegin.Location = New System.Drawing.Point(8, 16)
        Me.ckbBegin.Name = "ckbBegin"
        Me.ckbBegin.Size = New System.Drawing.Size(80, 20)
        Me.ckbBegin.TabIndex = 0
        Me.ckbBegin.Text = "开始时间"
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEnd.Enabled = False
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(88, 48)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(120, 21)
        Me.dtpEnd.TabIndex = 3
        '
        'dtpBegin
        '
        Me.dtpBegin.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpBegin.Enabled = False
        Me.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBegin.Location = New System.Drawing.Point(88, 16)
        Me.dtpBegin.Name = "dtpBegin"
        Me.dtpBegin.Size = New System.Drawing.Size(120, 21)
        Me.dtpBegin.TabIndex = 1
        '
        'FrmHis_Select
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(264, 294)
        Me.Controls.Add(Me.gbTime)
        Me.Controls.Add(Me.txtOldData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTable)
        Me.Controls.Add(Me.操作表名)
        Me.Controls.Add(Me.txtOper)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtWorker)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmHis_Select"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查找"
        Me.gbTime.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shared flag As Boolean
    Public Shared strSelect As String

    Private Sub ckbBegin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbBegin.CheckedChanged
        Me.dtpBegin.Enabled = Me.ckbBegin.Checked
    End Sub

    Private Sub ckbEnd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbEnd.CheckedChanged
        Me.dtpEnd.Enabled = Me.ckbEnd.Checked
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        strSelect = "1=1"
        If Me.txtDept.Text <> "" Then
            strSelect += " and Dept_Name like '%" & Me.txtDept.Text & "%'"
        End If
        If Me.txtWorker.Text <> "" Then
            strSelect += " and OperateWorker like '%" & Me.txtWorker.Text & "%'"
        End If
        If Me.txtOper.Text <> "" Then
            strSelect += " and OperateType like '%" & Me.txtOper.Text & "%'"
        End If
        If Me.txtTable.Text <> "" Then
            strSelect += " and OperateTable = '" & Me.txtTable.Text & "'"
        End If
        If Me.txtOldData.Text <> "" Then
            strSelect += " and OperateDemo like '%" & Me.txtOldData.Text & "%'"
        End If
        If Me.ckbBegin.Checked Then
            strSelect += " and OperateTime >= '" & Me.dtpBegin.Value & "'"
        End If
        If Me.ckbEnd.Checked Then
            strSelect += " and OperateTime <= '" & Me.dtpEnd.Value & "'"
        End If
        flag = True
        Me.Close()
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FrmHis_Select_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtDept.Focused Then
                Me.txtWorker.Focus()
            ElseIf Me.txtWorker.Focused Then
                Me.txtOper.Focus()
            ElseIf Me.txtOper.Focused Then
                Me.txtTable.Focus()
            ElseIf Me.txtTable.Focused Then
                Me.txtOldData.Focus()
            ElseIf Me.txtOldData.Focused Then
                Me.ckbBegin.Focus()
            ElseIf Me.ckbBegin.Focused Then
                If Me.ckbBegin.Checked Then
                    Me.dtpBegin.Focus()
                Else
                    Me.ckbEnd.Focus()
                End If
            ElseIf Me.dtpBegin.Focused Then
                Me.ckbEnd.Focus()
            ElseIf Me.ckbEnd.Focused Then
                If Me.ckbEnd.Checked Then
                    Me.dtpEnd.Focus()
                Else
                    Me.btSave.Focus()
                    Me.btSave_Click(sender, e)
                End If
            ElseIf Me.dtpEnd.Focused Then
                Me.btSave.Focus()
                Me.btSave_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub FrmHis_Select_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        If sender Is Me.txtDept Then
            Me.txtDept.Text = Me.txtDept.Text.Trim
        ElseIf sender Is Me.txtWorker Then
            Me.txtWorker.Text = Me.txtWorker.Text.Trim
        ElseIf sender Is Me.txtOper Then
            Me.txtOper.Text = Me.txtOper.Text.Trim
        ElseIf sender Is Me.txtTable Then
            Me.txtTable.Text = Me.txtTable.Text.Trim
        ElseIf sender Is Me.txtOldData Then
            Me.txtOldData.Text = Me.txtOldData.Text.Trim
        End If
    End Sub
End Class
