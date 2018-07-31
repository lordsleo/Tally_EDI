Imports TALLY.DBControl
Public Class FrmContainerOutPort_Select
    Inherits System.Windows.Forms.Form

    Dim sqlShipCode, strShip, strBillNo, strVoyage, strContainerNo, strNo As String
    Dim dvShipCode As New DataView()
    Public Shared flag As Boolean
    Public Shared strSelect As String

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtContainerNo.Leave, AddressOf FrmContainerOutPort_Select_Leave
        AddHandler txtBillNO.Leave, AddressOf FrmContainerOutPort_Select_Leave
        AddHandler txtSealNo.Leave, AddressOf FrmContainerOutPort_Select_Leave
        AddHandler txtShip.Leave, AddressOf FrmContainerOutPort_Select_Leave
        AddHandler txtVoyage.Leave, AddressOf FrmContainerOutPort_Select_Leave
        AddHandler txtNo.Leave, AddressOf FrmContainerOutPort_Select_Leave

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
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtContainerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSealNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.txtContainerNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSealNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(86, 104)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 4
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 413
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(86, 80)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 3
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 412
        Me.Label2.Text = "船码船名"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(86, 32)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 1
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 415
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(152, 160)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 7
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(80, 160)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 6
        Me.btSave.Text = "确认"
        '
        'txtContainerNo
        '
        Me.txtContainerNo.Location = New System.Drawing.Point(86, 8)
        Me.txtContainerNo.MaxLength = 20
        Me.txtContainerNo.Name = "txtContainerNo"
        Me.txtContainerNo.Size = New System.Drawing.Size(130, 21)
        Me.txtContainerNo.TabIndex = 0
        Me.txtContainerNo.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 419
        Me.Label3.Text = "箱号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(86, 128)
        Me.txtNo.MaxLength = 20
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(130, 21)
        Me.txtNo.TabIndex = 5
        Me.txtNo.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 421
        Me.Label5.Text = "理货单编号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSealNo
        '
        Me.txtSealNo.Location = New System.Drawing.Point(86, 56)
        Me.txtSealNo.MaxLength = 20
        Me.txtSealNo.Name = "txtSealNo"
        Me.txtSealNo.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNo.TabIndex = 2
        Me.txtSealNo.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 423
        Me.Label6.Text = "铅封号"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmContainerOutPort_Select
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(242, 191)
        Me.Controls.Add(Me.txtSealNo)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.txtContainerNo)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.txtVoyage)
        Me.Controls.Add(Me.txtShip)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmContainerOutPort_Select"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装拆箱理货单信息 选择查找"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmContainerOutPort_Select_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strSelect = "1=1"
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        strShip = Me.txtShip.Text.Trim.ToUpper
        sqlShipCode = "SELECT SPCODE, CHI_VESSEL FROM Code_SHIPNAME WHERE (SPCODE = '" & strShip & "' or CHI_VESSEL = '" & strShip & "')"
        dvShipCode = Filldata(sqlShipCode)
        If dvShipCode.Count > 0 Then
            strShip = dvShipCode(0)("SPCODE")
        End If
        strVoyage = Me.txtVoyage.Text
        strBillNo = Me.txtBillNO.Text
        strContainerNo = Me.txtContainerNo.Text
        strNo = Me.txtNo.Text

        'strSelect = " chi_vessel like '%" & strShip & "%' and voyage like '%" & strVoyage & "%' and blno like '%" & strBillNo & "%' and CONTAINER_NO like '%" & strContainerNo & "%' and NO like '%" & strNo & "%' "
        If strShip.Length > 0 Then
            strSelect += " and chi_vessel like '%" & strShip & "%'"
        End If
        If strVoyage.Length > 0 Then
            strSelect += " and voyage like '%" & strVoyage & "%'"
        End If
        If strBillNo.Length > 0 Then
            strSelect += " and blno like '%" & strBillNo & "%'"
        End If
        If strContainerNo.Length > 0 Then
            strSelect += " and CONTAINER_NO like '%" & strContainerNo & "%'"
        End If
        If strNo.Length > 0 Then
            strSelect += " and NO like '%" & strNo & "%'"
        End If
        If Me.txtSealNo.Text.Length > 0 Then
            strSelect += " and NewSealNo like '%" & Me.txtSealNo.Text & "%'"
        End If
        If strSelect.Length > 5 Then
            flag = True
            Me.Close()
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        flag = False
        Me.Close()
    End Sub

    Private Sub txtContainerNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContainerNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtBillNO.Focus()
        End If
    End Sub

    Private Sub txtBillNO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBillNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtSealNo.Focus()
        End If
    End Sub

    Private Sub txtSealNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSealNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtShip.Focus()
        End If
    End Sub

    Private Sub txtShip_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShip.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtVoyage.Focus()
        End If
    End Sub

    Private Sub txtVoyage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoyage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btSave.Focus()
            Me.btSave_Click(sender, e)
        End If
    End Sub

    Private Sub txtNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btSave.Focus()
            Me.btSave_Click(sender, e)
        End If
    End Sub

    Private Sub FrmContainerOutPort_Select_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        If sender Is Me.txtContainerNo Then
            Me.txtContainerNo.Text = Me.txtContainerNo.Text.Trim.ToUpper
        ElseIf sender Is Me.txtBillNO Then
            Me.txtBillNO.Text = Me.txtBillNO.Text.Trim.ToUpper
        ElseIf sender Is Me.txtSealNo Then
            Me.txtSealNo.Text = Me.txtSealNo.Text.Trim.ToUpper
        ElseIf sender Is Me.txtShip Then
            Me.txtShip.Text = Me.txtShip.Text.Trim.ToUpper
        ElseIf sender Is Me.txtVoyage Then
            Me.txtVoyage.Text = Me.txtVoyage.Text.Trim.ToUpper
        ElseIf sender Is Me.txtNo Then
            Me.txtNo.Text = Me.txtNo.Text.Trim.ToUpper
        End If
    End Sub

End Class
