Imports TALLY.DBControl
Public Class FrmConLoadCheck_Total
    Inherits System.Windows.Forms.Form

    Dim sqlCount As String
    Dim dvCount As New DataView()
    Dim strYard As String

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents labResult As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.labResult = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labResult
        '
        Me.labResult.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.labResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labResult.Font = New System.Drawing.Font("����_GB2312", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.labResult.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.labResult.Location = New System.Drawing.Point(16, 64)
        Me.labResult.Name = "labResult"
        Me.labResult.Size = New System.Drawing.Size(194, 36)
        Me.labResult.TabIndex = 429
        Me.labResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(118, 110)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 428
        Me.btQuit.Text = "�˳�"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(50, 110)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 427
        Me.btSave.Text = "ȷ��"
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(84, 34)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeEnd.TabIndex = 424
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(10, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 426
        Me.Label8.Text = "����ʱ��"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(84, 8)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeBegin.TabIndex = 423
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 425
        Me.Label7.Text = "��ʼʱ��"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConLoadCheck_Total
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(226, 141)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.labResult, Me.btQuit, Me.btSave, Me.dtpTimeEnd, Me.Label8, Me.dtpTimeBegin, Me.Label7})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadCheck_Total"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "װ�������Ų��� ͳ��"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConLoadCheck_Total_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        Me.dtpTimeEnd.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        Me.dtpTimeEnd.Value = Now
        'strYard = FrmConLoadCheck.strCodeYard
        strYard = "07"
        If G_DeptCode = "26.11.12" Then
            strYard = "21"
        End If
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        sqlCount = "SELECT COUNT(*) AS ConSum FROM CON_LOAD_TALLY_LIST " & _
            "WHERE (CodeYard = '" & strYard & "') AND (USER_NAME = '" & G_User & "') AND (DATEDIFF(mi, CheckTime, '" & Me.dtpTimeBegin.Value & "') <= 0) AND (DATEDIFF(mi, CheckTime, '" & Me.dtpTimeEnd.Value & "') >= 0) "
        dvCount = Filldata(sqlCount)
        Me.labResult.Text = ""
        Me.labResult.Text = dvCount(0)(0) & "��"
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
