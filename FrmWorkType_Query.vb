Imports TALLY.DBControl
Public Class FrmWorkType_Query
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮�������κγ�ʼ��

    End Sub

    '������д��������������б���
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtWorkType As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.txtWorkType = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(94, 72)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 139
        Me.btQuit.Text = "����"
        '
        'txtWorkType
        '
        Me.txtWorkType.Location = New System.Drawing.Point(82, 42)
        Me.txtWorkType.MaxLength = 40
        Me.txtWorkType.Name = "txtWorkType"
        Me.txtWorkType.Size = New System.Drawing.Size(170, 21)
        Me.txtWorkType.TabIndex = 137
        Me.txtWorkType.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "�����������"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(82, 8)
        Me.txtCode.MaxLength = 4
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(170, 21)
        Me.txtCode.TabIndex = 135
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "����������"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 140
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'FrmWorkType_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(254, 99)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btQuit, Me.txtWorkType, Me.Label2, Me.txtCode, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWorkType_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�������_�鿴"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select * from CODE_WorkTYPE where WorkTYPE_ID=" & ID & ""

        dw = Getdata(sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("WorkTYPE_ID")
            txtCode.Text = ds.Tables(0).Rows(0).Item("Code_WorkTYPE")
            txtWorkType.Text = ds.Tables(0).Rows(0).Item("WorkTYPE")

        End If
        txtCode.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtWorkType.Focus()
        End If
    End Sub

    Private Sub txtWorkTYPE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWorkType.KeyPress
        If e.KeyChar = Chr(13) Then
            btQuit.Focus()
        End If
    End Sub
End Class