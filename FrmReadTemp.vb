Public Class FrmReadTemp
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents L As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents btOK As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.L = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.btOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L
        '
        Me.L.Location = New System.Drawing.Point(6, 14)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(278, 20)
        Me.L.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "����ֵ��"
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(64, 46)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(220, 21)
        Me.txt.TabIndex = 2
        Me.txt.Text = ""
        '
        'btOK
        '
        Me.btOK.Location = New System.Drawing.Point(113, 86)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(65, 24)
        Me.btOK.TabIndex = 3
        Me.btOK.Text = "ȷ��"
        '
        'FrmReadTemp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(290, 119)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btOK, Me.txt, Me.Label1, Me.L})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReadTemp"
        Me.Text = "��ȡ��ͼ���ľ�������"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click
        G_SelectCode = Trim(txt.Text)
        Me.Close()
    End Sub

    Private Sub FrmReadTemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        L.Text = G_SelectStr
    End Sub
End Class
