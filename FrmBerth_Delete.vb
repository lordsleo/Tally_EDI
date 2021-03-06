Imports TALLY.DBControl
Public Class FrmBerth_Delete
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
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents txtDept As System.Windows.Forms.ComboBox
    Friend WithEvents txtDock As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btResume = New System.Windows.Forms.Button()
        Me.txtDept = New System.Windows.Forms.ComboBox()
        Me.txtDock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(106, 144)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 127
        Me.btQuit.Text = "取消"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(38, 144)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 126
        Me.btResume.Text = "确认"
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(84, 88)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(112, 20)
        Me.txtDept.TabIndex = 125
        '
        'txtDock
        '
        Me.txtDock.Location = New System.Drawing.Point(84, 116)
        Me.txtDock.MaxLength = 12
        Me.txtDock.Name = "txtDock"
        Me.txtDock.Size = New System.Drawing.Size(112, 21)
        Me.txtDock.TabIndex = 123
        Me.txtDock.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "所属码头"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "所属理货站"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(84, 58)
        Me.txtCompany.MaxLength = 12
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(112, 21)
        Me.txtCompany.TabIndex = 120
        Me.txtCompany.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "所属公司"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(84, 28)
        Me.txtName.MaxLength = 10
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(112, 21)
        Me.txtName.TabIndex = 118
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "泊位名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(84, 0)
        Me.txtCode.MaxLength = 2
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(112, 21)
        Me.txtCode.TabIndex = 116
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "泊位号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 124
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'FrmBerth_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(200, 171)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btQuit, Me.btResume, Me.txtDept, Me.txtDock, Me.Label5, Me.Label4, Me.txtCompany, Me.Label3, Me.txtName, Me.Label2, Me.txtCode, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBerth_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "泊位信息_删除"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtName.Focus()
        End If
    End Sub
    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCompany.Focus()
        End If
    End Sub
    Private Sub txtcompany_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompany.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDept.Focus()
        End If
    End Sub

    Private Sub txtDept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDept.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDock.Focus()
        End If
    End Sub

    Private Sub txtdock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDock.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btResume_Click(sender, e)
            txtName.Focus()
        End If
    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim ds1 As New DataSet()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select Dept_Code,Dept_Name from Department Order by Dept_Code"
        dw = Getdata(sqlstr, ds1)
        txtDept.DataSource = ds1.Tables(0).DefaultView
        txtDept.DisplayMember = "Dept_Name"
        txtDept.ValueMember = "Dept_Code"

        sqlstr = "select * from code_berth where Berth_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("Berth_ID")
            txtCode.Text = ds.Tables(0).Rows(0).Item("code_berth")
            txtName.Text = ds.Tables(0).Rows(0).Item("Name_berth")
            txtCompany.Text = ds.Tables(0).Rows(0).Item("company")
            txtDept.SelectedValue = ds.Tables(0).Rows(0).Item("Dept_Code")
            txtDock.Text = ds.Tables(0).Rows(0).Item("Dock")
        End If


        txtName.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtName.Text = ""
        txtCompany.Text = ""
        txtDock.Text = ""
        txtCode.Text = ""
    End Sub


    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("你确认要删除吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "删除", "Code_Berth", Trim(txtID.Text), "Berth_ID")

                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)
                Call btQuit_Click(sender, e)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
