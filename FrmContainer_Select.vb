Public Class FrmContainer_Select
    Inherits System.Windows.Forms.Form

    Dim strBillNo, strContainerNo, strBayNo As String
    Public Shared flag As Boolean
    Public Shared strSelect As String

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д dispose ����������б�
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

    'ע��: ���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents txtContainerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBayNo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtContainerNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBayNo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtContainerNo
        '
        Me.txtContainerNo.Location = New System.Drawing.Point(88, 8)
        Me.txtContainerNo.MaxLength = 20
        Me.txtContainerNo.Name = "txtContainerNo"
        Me.txtContainerNo.Size = New System.Drawing.Size(130, 21)
        Me.txtContainerNo.TabIndex = 0
        Me.txtContainerNo.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(14, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 423
        Me.Label3.Text = "���"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(88, 60)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 2
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 422
        Me.Label4.Text = "�ᵥ��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBayNo
        '
        Me.txtBayNo.Location = New System.Drawing.Point(88, 34)
        Me.txtBayNo.MaxLength = 7
        Me.txtBayNo.Name = "txtBayNo"
        Me.txtBayNo.Size = New System.Drawing.Size(130, 21)
        Me.txtBayNo.TabIndex = 1
        Me.txtBayNo.Text = ""
        '
        'Label14
        '
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Location = New System.Drawing.Point(14, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 503
        Me.Label14.Text = "��λ��"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(120, 90)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 4
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(52, 90)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 3
        Me.btSave.Text = "ȷ��"
        '
        'FrmContainer_Select
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(230, 121)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.txtBayNo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtContainerNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmContainer_Select"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��װ����Ϣ ����"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmContainer_Select_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        flag = False
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        strContainerNo = Me.txtContainerNo.Text.Trim.ToUpper
        strBayNo = Me.txtBayNo.Text.Trim
        strBillNo = Me.txtBillNO.Text.Trim.ToUpper
        strSelect = " CONTAINER_NO like '%" & strContainerNo & "%' and (BAYNO like '%" & strBayNo & "%' or BAYNO is null) and (BLNO like '%" & strBillNo & "%' or BLNO is null) "
        flag = True
        Me.Close()
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtContainerNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContainerNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtBayNo.Focus()
        End If
    End Sub

    Private Sub txtBayNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBayNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtBillNO.Focus()
        End If
    End Sub

    Private Sub txtBillNO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBillNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btSave.Focus()
        End If
    End Sub
End Class
