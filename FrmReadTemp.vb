Public Class FrmReadTemp
    Inherits System.Windows.Forms.Form

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
        Me.Label1.Text = "纠正值："
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
        Me.btOK.Text = "确认"
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
        Me.Text = "读取船图报文纠正窗口"
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
