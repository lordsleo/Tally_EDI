Public Class FrmConLoadFinalCheck_Select
    Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��
        AddHandler txtShip.KeyDown, AddressOf FrmConLoadFinalCheck_Select_KeyDown
        AddHandler txtVoyage.KeyDown, AddressOf FrmConLoadFinalCheck_Select_KeyDown
        AddHandler txtBillNO.KeyDown, AddressOf FrmConLoadFinalCheck_Select_KeyDown
        AddHandler txtContainerNo.KeyDown, AddressOf FrmConLoadFinalCheck_Select_KeyDown

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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtContainerNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtContainerNo
        '
        Me.txtContainerNo.Location = New System.Drawing.Point(82, 86)
        Me.txtContainerNo.MaxLength = 20
        Me.txtContainerNo.Name = "txtContainerNo"
        Me.txtContainerNo.Size = New System.Drawing.Size(130, 21)
        Me.txtContainerNo.TabIndex = 3
        Me.txtContainerNo.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 429
        Me.Label3.Text = "���"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(114, 116)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 5
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(46, 116)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 4
        Me.btSave.Text = "ȷ��"
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(82, 60)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 2
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 427
        Me.Label4.Text = "�ᵥ��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(82, 34)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 1
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 426
        Me.Label1.Text = "����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(82, 8)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 0
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 425
        Me.Label2.Text = "��Ӣ����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConLoadFinalCheck_Select
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(224, 147)
        Me.Controls.Add(Me.txtContainerNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVoyage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtShip)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadFinalCheck_Select"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "���вյ����Ĳ���"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim strShip, strBillNo, strVoyage, strContainerNo As String
    Public Shared flag As Boolean
    Public Shared strSelect As String

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        strShip = Me.txtShip.Text.Trim.ToUpper
        strVoyage = Me.txtVoyage.Text.Trim.ToUpper
        strBillNo = Me.txtBillNO.Text.Trim.ToUpper
        strContainerNo = Me.txtContainerNo.Text.Trim.ToUpper

        strSelect = " (chi_vessel like '%" & strShip & "%' or eng_vessel like '%" & strShip & "%') and voyage like '%" & strVoyage & "%' and blno like '%" & strBillNo & "%' and CONTAINER_NO like '%" & strContainerNo & "%' "
        flag = True
        Me.Close()
    End Sub

    Private Sub FrmConLoadFinalCheck_Select_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            If Me.txtShip.Focused Then
                Me.txtVoyage.Focus()
            ElseIf Me.txtVoyage.Focused Then
                Me.txtBillNO.Focus()
            ElseIf Me.txtBillNO.Focused Then
                Me.txtContainerNo.Focus()
            ElseIf Me.txtContainerNo.Focused Then
                Me.btSave.Focus()
            End If
        End If
    End Sub
End Class
