Public Class FrmHis_Query
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDept As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtWorker As System.Windows.Forms.TextBox
    Friend WithEvents txtTable As System.Windows.Forms.TextBox
    Friend WithEvents 操作表名 As System.Windows.Forms.Label
    Friend WithEvents txtOper As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOldData As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNowData As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDept = New System.Windows.Forms.TextBox
        Me.txtTime = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtWorker = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTable = New System.Windows.Forms.TextBox
        Me.操作表名 = New System.Windows.Forms.Label
        Me.txtOper = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtOldData = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNowData = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnQuit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "操作部门"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDept
        '
        Me.txtDept.BackColor = System.Drawing.SystemColors.Control
        Me.txtDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDept.Location = New System.Drawing.Point(80, 8)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.ReadOnly = True
        Me.txtDept.TabIndex = 1
        Me.txtDept.Text = ""
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.SystemColors.Control
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTime.Location = New System.Drawing.Point(264, 8)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(168, 21)
        Me.txtTime.TabIndex = 3
        Me.txtTime.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "操作时间"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWorker
        '
        Me.txtWorker.BackColor = System.Drawing.SystemColors.Control
        Me.txtWorker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWorker.Location = New System.Drawing.Point(528, 8)
        Me.txtWorker.Name = "txtWorker"
        Me.txtWorker.ReadOnly = True
        Me.txtWorker.TabIndex = 5
        Me.txtWorker.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(456, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "操作员"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTable
        '
        Me.txtTable.BackColor = System.Drawing.SystemColors.Control
        Me.txtTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTable.Location = New System.Drawing.Point(352, 40)
        Me.txtTable.Name = "txtTable"
        Me.txtTable.ReadOnly = True
        Me.txtTable.Size = New System.Drawing.Size(176, 21)
        Me.txtTable.TabIndex = 9
        Me.txtTable.Text = ""
        '
        '操作表名
        '
        Me.操作表名.Location = New System.Drawing.Point(280, 40)
        Me.操作表名.Name = "操作表名"
        Me.操作表名.Size = New System.Drawing.Size(72, 23)
        Me.操作表名.TabIndex = 8
        Me.操作表名.Text = "操作表名"
        Me.操作表名.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOper
        '
        Me.txtOper.BackColor = System.Drawing.SystemColors.Control
        Me.txtOper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOper.Location = New System.Drawing.Point(120, 40)
        Me.txtOper.Name = "txtOper"
        Me.txtOper.ReadOnly = True
        Me.txtOper.Size = New System.Drawing.Size(144, 21)
        Me.txtOper.TabIndex = 7
        Me.txtOper.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(48, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "操作"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOldData
        '
        Me.txtOldData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOldData.BackColor = System.Drawing.SystemColors.Control
        Me.txtOldData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOldData.Location = New System.Drawing.Point(16, 88)
        Me.txtOldData.Multiline = True
        Me.txtOldData.Name = "txtOldData"
        Me.txtOldData.ReadOnly = True
        Me.txtOldData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOldData.Size = New System.Drawing.Size(656, 64)
        Me.txtOldData.TabIndex = 11
        Me.txtOldData.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "修改前数据"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNowData
        '
        Me.txtNowData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNowData.BackColor = System.Drawing.SystemColors.Control
        Me.txtNowData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNowData.Location = New System.Drawing.Point(16, 176)
        Me.txtNowData.Multiline = True
        Me.txtNowData.Name = "txtNowData"
        Me.txtNowData.ReadOnly = True
        Me.txtNowData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNowData.Size = New System.Drawing.Size(656, 64)
        Me.txtNowData.TabIndex = 15
        Me.txtNowData.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(-8, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "当前数据"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Location = New System.Drawing.Point(303, 248)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.TabIndex = 16
        Me.btnQuit.Text = "关闭"
        '
        'FrmHis_Query
        '
        Me.AcceptButton = Me.btnQuit
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(680, 278)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.txtNowData)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOldData)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTable)
        Me.Controls.Add(Me.操作表名)
        Me.Controls.Add(Me.txtOper)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtWorker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmHis_Query"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmHis_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Hide()
    End Sub

    Private Sub FrmHis_Query_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
End Class
