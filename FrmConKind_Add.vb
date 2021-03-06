Imports TALLY.DBControl
Public Class FrmConKind_Add
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHI As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.txtENG = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCHI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(156, 92)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 164
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(88, 92)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 163
        Me.btSave.Text = "确认"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(20, 92)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 162
        Me.btAdd.Text = "清空"
        '
        'txtENG
        '
        Me.txtENG.Location = New System.Drawing.Point(64, 60)
        Me.txtENG.MaxLength = 30
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(178, 21)
        Me.txtENG.TabIndex = 158
        Me.txtENG.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 157
        Me.Label3.Text = "英文描述"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCHI
        '
        Me.txtCHI.Location = New System.Drawing.Point(64, 30)
        Me.txtCHI.MaxLength = 30
        Me.txtCHI.Name = "txtCHI"
        Me.txtCHI.Size = New System.Drawing.Size(178, 21)
        Me.txtCHI.TabIndex = 156
        Me.txtCHI.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "中文描述"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 2)
        Me.txtCode.MaxLength = 4
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(178, 21)
        Me.txtCode.TabIndex = 154
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "代码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(4, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 165
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'FrmConKind_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(246, 119)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btQuit, Me.btSave, Me.btAdd, Me.txtENG, Me.Label3, Me.txtCHI, Me.Label2, Me.txtCode, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConKind_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱类别信息_增加"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCHI.Focus()
        End If
    End Sub
    Private Sub txtCHI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCHI.KeyPress
        If e.KeyChar = Chr(13) Then
            txtENG.Focus()
        End If
    End Sub
    Private Sub txtENG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtENG.KeyPress
        If e.KeyChar = Chr(13) Then
            btSave.Focus()
        End If
    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen

        sqlstr = "select * from code_con_Kind where CON_KIND_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("CON_KIND_ID")
            txtCode.Text = ds.Tables(0).Rows(0).Item("CODE_CON_KIND")
            txtCHI.Text = ds.Tables(0).Rows(0).Item("CON_KIND_CHI")
            txtENG.Text = ds.Tables(0).Rows(0).Item("CON_KIND_ENG")
        End If


        txtCode.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        txtCHI.Text = ""
        txtENG.Text = ""
        txtCode.Text = ""
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim dsSave As New DataSet()
            If Getdata("select * from CODE_CON_KIND where CODE_CON_KIND='" & Trim(txtCode.Text) & "'", dsSave).Count > 0 Then
                MsgBox("可能已存在此箱型信息,请注意检查!")
                Exit Sub
            End If
            If Len(Trim(txtCode.Text)) > 0 And Len(Trim(txtCHI.Text)) > 0 And Len(Trim(txtENG.Text)) > 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()

                row("CODE_CON_KIND") = Trim(txtCode.Text)
                row("CON_KIND_CHI") = Trim(txtCHI.Text)
                row("CON_KIND_ENG") = Trim(txtENG.Text)

                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
                Me.Close()
            Else
                MsgBox("箱型代码,中英文描述不能为空!", MsgBoxStyle.Critical, "提示")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

End Class
