Imports System.Web.Mail
Imports System.IO
Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmWriteMailReport
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet
    Dim dw As New DataView
    Dim sqlstr As String
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbRoute As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbTrade As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbHgLoad As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDel As System.Windows.Forms.RadioButton
    Friend WithEvents rbAdd As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBGX As System.Windows.Forms.RadioButton
    Friend WithEvents RBZX As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RBQT As System.Windows.Forms.RadioButton
    Friend WithEvents RBWM As System.Windows.Forms.RadioButton
    Friend WithEvents RBNM As System.Windows.Forms.RadioButton
    Dim BackUpFile As String

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
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btRead As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LSign As System.Windows.Forms.TextBox
    Friend WithEvents PB As System.Windows.Forms.ProgressBar
    Friend WithEvents LNextPort As System.Windows.Forms.Label
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents rbJT As System.Windows.Forms.RadioButton
    Friend WithEvents LShipOwner As System.Windows.Forms.Label
    Friend WithEvents LShipCompany As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbEmail As System.Windows.Forms.ComboBox
    Friend WithEvents txtShipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LJinChu As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LVoyage As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LEnglish As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LChina As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btWriteNew As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents OpenFile As System.Windows.Forms.Button
    Friend WithEvents 船长 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTallyName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents 开工时间 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LStartTime As System.Windows.Forms.TextBox
    Friend WithEvents LEndTime As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.btRead = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.LSign = New System.Windows.Forms.TextBox
        Me.PB = New System.Windows.Forms.ProgressBar
        Me.LNextPort = New System.Windows.Forms.Label
        Me.GB = New System.Windows.Forms.GroupBox
        Me.rbJT = New System.Windows.Forms.RadioButton
        Me.LShipOwner = New System.Windows.Forms.Label
        Me.LShipCompany = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbEmail = New System.Windows.Forms.ComboBox
        Me.txtShipCode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LJinChu = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LVoyage = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LEnglish = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LChina = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btWriteNew = New System.Windows.Forms.Button
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.OpenFile = New System.Windows.Forms.Button
        Me.船长 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtPhoneCode = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTallyName = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LStartTime = New System.Windows.Forms.TextBox
        Me.开工时间 = New System.Windows.Forms.Label
        Me.LEndTime = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbRoute = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbTrade = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbHgLoad = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbDel = New System.Windows.Forms.RadioButton
        Me.rbAdd = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RBZX = New System.Windows.Forms.RadioButton
        Me.RBGX = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RBQT = New System.Windows.Forms.RadioButton
        Me.RBWM = New System.Windows.Forms.RadioButton
        Me.RBNM = New System.Windows.Forms.RadioButton
        Me.GB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btRead
        '
        Me.btRead.Location = New System.Drawing.Point(15, 286)
        Me.btRead.Name = "btRead"
        Me.btRead.Size = New System.Drawing.Size(70, 22)
        Me.btRead.TabIndex = 91
        Me.btRead.Text = "查看报文"
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(91, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 14)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "IMO"
        '
        'LSign
        '
        Me.LSign.Location = New System.Drawing.Point(116, 40)
        Me.LSign.Name = "LSign"
        Me.LSign.Size = New System.Drawing.Size(78, 21)
        Me.LSign.TabIndex = 89
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(13, 312)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(366, 18)
        Me.PB.TabIndex = 88
        '
        'LNextPort
        '
        Me.LNextPort.Location = New System.Drawing.Point(371, 224)
        Me.LNextPort.Name = "LNextPort"
        Me.LNextPort.Size = New System.Drawing.Size(8, 8)
        Me.LNextPort.TabIndex = 86
        Me.LNextPort.Visible = False
        '
        'GB
        '
        Me.GB.Controls.Add(Me.rbJT)
        Me.GB.Location = New System.Drawing.Point(91, 262)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(91, 48)
        Me.GB.TabIndex = 85
        Me.GB.TabStop = False
        Me.GB.Text = "报文格式"
        '
        'rbJT
        '
        Me.rbJT.Checked = True
        Me.rbJT.Location = New System.Drawing.Point(5, 25)
        Me.rbJT.Name = "rbJT"
        Me.rbJT.Size = New System.Drawing.Size(83, 20)
        Me.rbJT.TabIndex = 0
        Me.rbJT.TabStop = True
        Me.rbJT.Text = "交通部平台"
        '
        'LShipOwner
        '
        Me.LShipOwner.Location = New System.Drawing.Point(341, 250)
        Me.LShipOwner.Name = "LShipOwner"
        Me.LShipOwner.Size = New System.Drawing.Size(8, 8)
        Me.LShipOwner.TabIndex = 84
        Me.LShipOwner.Visible = False
        '
        'LShipCompany
        '
        Me.LShipCompany.Location = New System.Drawing.Point(355, 250)
        Me.LShipCompany.Name = "LShipCompany"
        Me.LShipCompany.Size = New System.Drawing.Size(6, 8)
        Me.LShipCompany.TabIndex = 83
        Me.LShipCompany.Visible = False
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(197, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "收文用户"
        '
        'cbEmail
        '
        Me.cbEmail.Location = New System.Drawing.Point(253, 40)
        Me.cbEmail.Name = "cbEmail"
        Me.cbEmail.Size = New System.Drawing.Size(130, 20)
        Me.cbEmail.TabIndex = 81
        '
        'txtShipCode
        '
        Me.txtShipCode.Location = New System.Drawing.Point(45, 40)
        Me.txtShipCode.Name = "txtShipCode"
        Me.txtShipCode.Size = New System.Drawing.Size(46, 21)
        Me.txtShipCode.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(15, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 14)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "船码"
        '
        'LJinChu
        '
        Me.LJinChu.Location = New System.Drawing.Point(253, 24)
        Me.LJinChu.Name = "LJinChu"
        Me.LJinChu.Size = New System.Drawing.Size(128, 14)
        Me.LJinChu.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(197, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "进出口"
        '
        'LVoyage
        '
        Me.LVoyage.Location = New System.Drawing.Point(71, 24)
        Me.LVoyage.Name = "LVoyage"
        Me.LVoyage.Size = New System.Drawing.Size(124, 14)
        Me.LVoyage.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(15, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "航次"
        '
        'LEnglish
        '
        Me.LEnglish.Location = New System.Drawing.Point(253, 4)
        Me.LEnglish.Name = "LEnglish"
        Me.LEnglish.Size = New System.Drawing.Size(128, 16)
        Me.LEnglish.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(197, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "英文船名"
        '
        'LChina
        '
        Me.LChina.Location = New System.Drawing.Point(71, 4)
        Me.LChina.Name = "LChina"
        Me.LChina.Size = New System.Drawing.Size(124, 16)
        Me.LChina.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "中文船名"
        '
        'btWriteNew
        '
        Me.btWriteNew.Location = New System.Drawing.Point(15, 258)
        Me.btWriteNew.Name = "btWriteNew"
        Me.btWriteNew.Size = New System.Drawing.Size(70, 24)
        Me.btWriteNew.TabIndex = 70
        Me.btWriteNew.Text = "生成报文"
        '
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(13, 234)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(366, 21)
        Me.txtFile.TabIndex = 69
        '
        'OpenFile
        '
        Me.OpenFile.Location = New System.Drawing.Point(319, 236)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(62, 20)
        Me.OpenFile.TabIndex = 68
        Me.OpenFile.Text = "打开文件"
        Me.OpenFile.Visible = False
        '
        '船长
        '
        Me.船长.Location = New System.Drawing.Point(13, 164)
        Me.船长.Name = "船长"
        Me.船长.Size = New System.Drawing.Size(80, 16)
        Me.船长.TabIndex = 92
        Me.船长.Text = "船长大副姓名"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(89, 162)
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(292, 21)
        Me.txtName.TabIndex = 93
        '
        'txtPhoneCode
        '
        Me.txtPhoneCode.Location = New System.Drawing.Point(117, 186)
        Me.txtPhoneCode.MaxLength = 50
        Me.txtPhoneCode.Name = "txtPhoneCode"
        Me.txtPhoneCode.Size = New System.Drawing.Size(264, 21)
        Me.txtPhoneCode.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(13, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "船长大副联系号码"
        '
        'txtTallyName
        '
        Me.txtTallyName.Location = New System.Drawing.Point(107, 210)
        Me.txtTallyName.MaxLength = 35
        Me.txtTallyName.Name = "txtTallyName"
        Me.txtTallyName.Size = New System.Drawing.Size(274, 21)
        Me.txtTallyName.TabIndex = 97
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(13, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "理货责任人名称"
        '
        'LStartTime
        '
        Me.LStartTime.Location = New System.Drawing.Point(68, 114)
        Me.LStartTime.MaxLength = 35
        Me.LStartTime.Name = "LStartTime"
        Me.LStartTime.Size = New System.Drawing.Size(126, 21)
        Me.LStartTime.TabIndex = 100
        '
        '开工时间
        '
        Me.开工时间.ForeColor = System.Drawing.Color.DarkRed
        Me.开工时间.Location = New System.Drawing.Point(11, 116)
        Me.开工时间.Name = "开工时间"
        Me.开工时间.Size = New System.Drawing.Size(54, 16)
        Me.开工时间.TabIndex = 99
        Me.开工时间.Text = "开工时间"
        '
        'LEndTime
        '
        Me.LEndTime.Location = New System.Drawing.Point(249, 114)
        Me.LEndTime.MaxLength = 35
        Me.LEndTime.Name = "LEndTime"
        Me.LEndTime.Size = New System.Drawing.Size(132, 21)
        Me.LEndTime.TabIndex = 102
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(197, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "完工时间"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(11, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "航次标志"
        '
        'cbRoute
        '
        Me.cbRoute.Location = New System.Drawing.Point(73, 62)
        Me.cbRoute.Name = "cbRoute"
        Me.cbRoute.Size = New System.Drawing.Size(83, 20)
        Me.cbRoute.TabIndex = 103
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(197, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 16)
        Me.Label12.TabIndex = 106
        Me.Label12.Text = "内外贸"
        '
        'cbTrade
        '
        Me.cbTrade.Location = New System.Drawing.Point(253, 62)
        Me.cbTrade.Name = "cbTrade"
        Me.cbTrade.Size = New System.Drawing.Size(130, 20)
        Me.cbTrade.TabIndex = 105
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(11, 142)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "装卸货地"
        '
        'cbHgLoad
        '
        Me.cbHgLoad.Location = New System.Drawing.Point(69, 139)
        Me.cbHgLoad.Name = "cbHgLoad"
        Me.cbHgLoad.Size = New System.Drawing.Size(312, 20)
        Me.cbHgLoad.TabIndex = 107
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbDel)
        Me.GroupBox1.Controls.Add(Me.rbAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(183, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 48)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "报文类型"
        '
        'rbDel
        '
        Me.rbDel.Location = New System.Drawing.Point(98, 24)
        Me.rbDel.Name = "rbDel"
        Me.rbDel.Size = New System.Drawing.Size(83, 20)
        Me.rbDel.TabIndex = 1
        Me.rbDel.Text = "删除"
        '
        'rbAdd
        '
        Me.rbAdd.Checked = True
        Me.rbAdd.Location = New System.Drawing.Point(6, 24)
        Me.rbAdd.Name = "rbAdd"
        Me.rbAdd.Size = New System.Drawing.Size(83, 20)
        Me.rbAdd.TabIndex = 0
        Me.rbAdd.TabStop = True
        Me.rbAdd.Text = "增加"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBZX)
        Me.GroupBox2.Controls.Add(Me.RBGX)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox2.Location = New System.Drawing.Point(13, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 46)
        Me.GroupBox2.TabIndex = 110
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "航线类别(必选)"
        '
        'RBZX
        '
        Me.RBZX.Location = New System.Drawing.Point(77, 21)
        Me.RBZX.Name = "RBZX"
        Me.RBZX.Size = New System.Drawing.Size(51, 20)
        Me.RBZX.TabIndex = 1
        Me.RBZX.Text = "支线"
        '
        'RBGX
        '
        Me.RBGX.Location = New System.Drawing.Point(5, 20)
        Me.RBGX.Name = "RBGX"
        Me.RBGX.Size = New System.Drawing.Size(51, 20)
        Me.RBGX.TabIndex = 0
        Me.RBGX.Text = "干线"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RBQT)
        Me.GroupBox3.Controls.Add(Me.RBWM)
        Me.GroupBox3.Controls.Add(Me.RBNM)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox3.Location = New System.Drawing.Point(173, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 46)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "贸易类别(必选)"
        '
        'RBQT
        '
        Me.RBQT.Location = New System.Drawing.Point(134, 21)
        Me.RBQT.Name = "RBQT"
        Me.RBQT.Size = New System.Drawing.Size(51, 20)
        Me.RBQT.TabIndex = 2
        Me.RBQT.Text = "其它"
        '
        'RBWM
        '
        Me.RBWM.Location = New System.Drawing.Point(71, 20)
        Me.RBWM.Name = "RBWM"
        Me.RBWM.Size = New System.Drawing.Size(51, 20)
        Me.RBWM.TabIndex = 1
        Me.RBWM.Text = "外贸"
        '
        'RBNM
        '
        Me.RBNM.Location = New System.Drawing.Point(5, 20)
        Me.RBNM.Name = "RBNM"
        Me.RBNM.Size = New System.Drawing.Size(51, 20)
        Me.RBNM.TabIndex = 0
        Me.RBNM.Text = "内贸"
        '
        'FrmWriteMailReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(391, 339)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbHgLoad)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbTrade)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbRoute)
        Me.Controls.Add(Me.OpenFile)
        Me.Controls.Add(Me.LEndTime)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LStartTime)
        Me.Controls.Add(Me.开工时间)
        Me.Controls.Add(Me.txtTallyName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPhoneCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.船长)
        Me.Controls.Add(Me.btRead)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LSign)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.LNextPort)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.LShipOwner)
        Me.Controls.Add(Me.LShipCompany)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbEmail)
        Me.Controls.Add(Me.txtShipCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LJinChu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LVoyage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LEnglish)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LChina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btWriteNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmWriteMailReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "生成理货报告报文"
        Me.GB.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FrmWriteMailReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds1 As New DataSet
        Dim dw1 As New DataView
        Dim ds2 As New DataSet
        Dim dw2 As New DataView
        Dim ds3 As New DataSet
        Dim dw3 As New DataView
        Dim ds4 As New DataSet
        Dim dw4 As New DataView
        Dim ds5 As New DataSet
        Dim dw5 As New DataView
        Dim PathStr As String
        Dim FilePath As String

        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "EDIINI.INI"
            Dim sr As New StreamReader(FilePath) '打开报文文件
            txtFile.Text = sr.ReadLine()
            BackUpFile = sr.ReadLine()
            BackUpFile = sr.ReadLine()
            txtFile.Text = sr.ReadLine()
            sr.Close()
        Catch
        End Try

        sqlstr = "select * from EMail_Cust order by ID"
        dw1 = Getdata(sqlstr, ds1)
        cbEmail.DataSource = ds1.Tables(0).DefaultView
        cbEmail.DisplayMember = "E_Name"
        cbEmail.ValueMember = "E_Code"
        cbEmail.SelectedValue = "2301"

        sqlstr = "select * from code_route "
        dw2 = Getdata(sqlstr, ds2)
        cbRoute.DataSource = ds2.Tables(0).DefaultView
        cbRoute.DisplayMember = "routename"
        cbRoute.ValueMember = "coderoute"

        sqlstr = "select * from Code_Trade order by Trade_ID"
        dw3 = Getdata(sqlstr, ds3)
        cbTrade.DataSource = ds3.Tables(0).DefaultView
        cbTrade.DisplayMember = "Trade"
        cbTrade.ValueMember = "S_Trade"

        sqlstr = "select S_Trade,coderoute from sship where ship_id=" & Ship_ID

        If Getdata(sqlstr, ds4).Count > 0 Then
            cbRoute.SelectedValue = ds4.Tables(0).Rows(0).Item("coderoute")
            cbTrade.SelectedValue = ds4.Tables(0).Rows(0).Item("S_Trade")
        End If
        sqlstr = "select Code_HGLoad,HGLoad from TB_Code_HGLoad where vis_mark='1' order by px desc"

        If Getdata(sqlstr, ds5).Count > 0 Then
            cbHgLoad.DataSource = ds5.Tables(0).DefaultView
            cbHgLoad.DisplayMember = "HGLoad"
            cbHgLoad.ValueMember = "Code_HGLoad"
        End If
    End Sub

    Private Sub OpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFile.Click
        OpenFileDialog.AddExtension = True
        OpenFileDialog.DefaultExt = "*.*"
        OpenFileDialog.InitialDirectory = txtFile.Text
        OpenFileDialog.ShowDialog()
        txtFile.Text = OpenFileDialog.FileName

    End Sub

    Private Function CheckConNO(ByVal CNO As String) As Integer 'return 0 箱号有错 1 校验有错 2 校验正确
        Dim S() As Integer = {10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 34, 35, 36, 37, 38}
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim l As Integer
        i = 0
        str = UCase(CNO)
        If Len(Trim(UCase(CNO))) = 12 And Mid(Trim(UCase(CNO)), 5, 1) = " " Then
            str = Mid(Trim(UCase(CNO)), 1, 4) & Mid(Trim(UCase(CNO)), 6, 7)
        Else
            Return 0
        End If
        k = 1
        For j = 1 To 4
            If Asc(Mid(Trim(str), j, 1)) >= Asc("A") And Asc(Mid(Trim(str), j, 1)) <= Asc("Z") Then
                i = i + S(Asc(Mid(Trim(str), j, 1)) - Asc("A")) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next

        For j = 5 To 10
            If Asc(Mid(Trim(str), j, 1)) >= Asc("0") And Asc(Mid(Trim(str), j, 1)) <= Asc("9") Then
                i = i + CInt(Mid(Trim(str), j, 1)) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next
        If i Mod 11 = CInt(Mid(Trim(str), 11, 1)) Or (i Mod 11) - 10 = CInt(Mid(Trim(str), 11, 1)) Then
            Return 2
        Else
            Return 1
        End If
    End Function
    Private Function EditFetch(ByVal str As String) As String
        Dim s As String
        Dim se As String
        Dim j As Integer
        s = ""
        j = 1
        Do While j <= Len(str)
            se = Mid(str, j, 1)
            If se = "?" Then
                j = j + 1
                se = Mid(str, j, 1)
                If se = ":" Or se = "'" Or se = "?" Then
                    s = s & se
                Else
                    s = s & "?" & se
                End If
            End If
            If se = ":" Or se = "'" Then
                Exit Do
            Else
                s = s & se
            End If
            j = j + 1
        Loop
        EditFetch = s
    End Function

    Private Sub btWriteNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btWriteNew.Click
        If RBGX.Checked = True Or RBZX.Checked = True Then
            If RBNM.Checked = True Or RBWM.Checked = True Or RBQT.Checked = True Then
                If txtShipCode.Text.Trim().Length() > 0 And LSign.Text.Trim().Length() > 0 Then
                    If rbJT.Checked = True Then
                        Call WriteZH()
                    End If
                Else
                    MsgBox("船码 和 呼号 都不能为空!!!")
                End If
            Else
                MsgBox("请选择贸易类别!!!")
            End If
        Else
            MsgBox("请选择航线类别!!!")
        End If
    End Sub

    Private Sub WriteZH()
        On Error GoTo Err
        '******************************************中海
        Dim txtLine As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim k As Integer = 0
        Dim str As String
        Dim Ss As String '开工时间
        Dim Es As String '完工时间
        Dim s As String
        Dim dwt As New DataView
        Dim dst As New DataSet
        Dim dwt1 As New DataView
        Dim dst1 As New DataSet
        Dim dwt2 As New DataView
        Dim dst2 As New DataSet
        Dim dwt3 As New DataView
        Dim dst3 As New DataSet
        Dim dst4 As New DataSet
        Dim dwt4 As New DataView
        Dim strFile As String
        Dim ConType As String = "" '箱尺寸类型
        Dim ConOverFront As String = "" '前超
        Dim ConOverBack As String = "" '后超
        Dim ConOverLeft As String = "" '左超
        Dim ConOverRight As String = "" '右超
        Dim ConOverHeight As String = "" '超高
        Dim ConTareWeight As String = "" '箱皮重
        Dim ImExport As String = "" '进出口
        Dim ExPlaceCode As String = "" '装货地代码
        Dim ImPlaceCode As String = "" '卸货地代码
        Dim Trade As String = "1"
        Dim GZX As String = "1"
        Dim dss As New DataSet
        Dim dws As New DataView
        Dim ReportType As String = "2"
        If rbAdd.Checked = True Then
            ReportType = "2"
        Else
            If rbDel.Checked = True Then
                ReportType = "3"
            End If
        End If
        If RBNM.Checked = True Then
            Trade = "2"
        Else
            Trade = "1"
        End If
        If RBGX.Checked = True Then
            GZX = "1"
        Else
            GZX = "2"
        End If
        If LJinChu.Text.Trim() = "进口" Then
            ImExport = "IMPORT"
            ImPlaceCode = cbHgLoad.SelectedValue.ToString().Trim() + "/2301"
        Else
            ImExport = "EXPORT"
            ExPlaceCode = cbHgLoad.SelectedValue.ToString().Trim() + "/2301"
        End If
        If (txtFile.Text.Trim().Substring(txtFile.Text.Trim().Length() - 1, 1) <> "\") Then
            txtFile.Text = txtFile.Text & "\"
        End If
        strFile = txtFile.Text & "CCTALLY" & UCase(LSign.Text.Trim()) & UCase(txtShipCode.Text.Trim()) & LVoyage.Text & ".txt"

        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件
        '**************写00行
        txtLine = "00:CCTALLY:" & ImExport & ":" & ReportType & ":2310139007805:2301:" & Trim(CType(Year(Now), String))
        s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtLine = txtLine & s & "'"
        sw.WriteLine(txtLine)

        '************写05
        If txtName.Text.Trim().Length() > 0 Then
            txtLine = "05:" & txtName.Text.Trim() & ":" & txtPhoneCode.Text.Trim() & ":" & "TE'"
            sw.WriteLine(txtLine)
            i = 2
        End If
        '**************写06
        txtLine = "06:2310139007805:" & txtTallyName.Text.Trim() & "::'"
        i = i + 1
        sw.WriteLine(txtLine)
        '*************写10
        If LStartTime.Text.ToString().Length() > 0 Then
            Ss = Trim(CType(Year(CType(LEndTime.Text.ToString(), Date)), String))
            Ss = Ss & Mid("0" & Trim(CType(Month(CType(LStartTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Month(CType(LStartTime.Text.ToString(), Date)), String))) - 1, 2)
            Ss = Ss & Mid("0" & Trim(CType(Day(CType(LStartTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Day(CType(LStartTime.Text.ToString(), Date)), String))) - 1, 2)
            Ss = Ss & Mid("0" & Trim(CType(Hour(CType(LStartTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Hour(CType(LStartTime.Text.ToString(), Date)), String))) - 1, 2)
            Ss = Ss & Mid("0" & Trim(CType(Minute(CType(LStartTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Minute(CType(LStartTime.Text.ToString(), Date)), String))) - 1, 2)
            Ss = Ss & "086"
        Else
            Ss = ""
        End If

        If LEndTime.Text.ToString().Length() > 0 Then
            Es = Trim(CType(Year(CType(LEndTime.Text.ToString(), Date)), String))
            Es = Es & Mid("0" & Trim(CType(Month(CType(LEndTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Month(CType(LEndTime.Text.ToString(), Date)), String))) - 1, 2)
            Es = Es & Mid("0" & Trim(CType(Day(CType(LEndTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Day(CType(LEndTime.Text.ToString(), Date)), String))) - 1, 2)
            Es = Es & Mid("0" & Trim(CType(Hour(CType(LEndTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Hour(CType(LEndTime.Text.ToString(), Date)), String))) - 1, 2)
            Es = Es & Mid("0" & Trim(CType(Minute(CType(LEndTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Minute(CType(LEndTime.Text.ToString(), Date)), String))) - 1, 2)
            Es = Es & "086"
        Else
            Es = ""
        End If
        txtLine = "10:" & UCase(Trim(txtShipCode.Text)) & ":" & UCase(Trim(LEnglish.Text)) & ":1:" & LVoyage.Text & ":" & LSign.Text.Trim() & ":2301:" & ExPlaceCode & "::" & ImPlaceCode & "::" & Ss & ":" & Es & ":" & GZX & ":" & Trade & "'"
        i = i + 1
        sw.WriteLine(txtLine)
        '************写12 提单循环

        'txtLine = "11:" & UCase(LShipOwner.Text) & ":" & UCase(LShipOwner.Text) & "'"
        'sw.WriteLine(txtLine)
        'i = i + 1
        'sqlstr = "select DISTINCT BLNO,LOAD_DATE,AMOUNT,CODE_PACK,PACK,GROSS_WEIGHT,NETWEIGHT,SIZE_MEASURE,GOODS_ENG,EMPTY_MARK,TEMPERATURE,MARK,DANGER_GRADE,DANGER_NO,DANGER_PAGENO,DANGER_MARK,CODE_LOAD_PORT,CODE_UNLOAD_PORT,CODE_PLACE_RECEIVE,REFRIGERATE_TEMPERATURE  from VIEW_CON_HATCH_CARGO where Ship_ID=" & Ship_ID

        'sqlstr = "select DISTINCT BLNO,AMOUNT,CODE_PACK,PACK,GROSS_WEIGHT,SIZE_MEASURE  from VIEW_CON_HATCH_CARGO where Ship_ID=" & Ship_ID & " order by BLNO"
        If ImExport = "IMPORT" Then  '进口
            sqlstr = "select DISTINCT BLNO,AMOUNT,CODE_PACK,PACK,GROSS_WEIGHT,SIZE_MEASURE  from VIEW_CON_Report where INOUT_MARK='0' and Reload = '0' and edimark='0' and Ship_ID=" & Ship_ID & " and unload_mark='1' order by BLNO"
        Else  '出口
            sqlstr = "select DISTINCT BLNO,AMOUNT,CODE_PACK,PACK,GROSS_WEIGHT,SIZE_MEASURE  from VIEW_CON_Report where INOUT_MARK='0' and Reload = '0' and edimark='0' and Ship_ID=" & Ship_ID & " and unload_mark='1' and BLNO is not null order by BLNO"

        End If
        dw = Getdata(sqlstr, ds)

        PB.Maximum = dw.Count
        PB.Value = 0

        Do While j < dw.Count
            PB.Value = j
            sqlstr = ""

            '********************************12
            If IsDBNull(ds.Tables(0).Rows(j).Item("BLNO")) Then
                txtLine = "12:FDCA" & LSign.Text.Trim() & LVoyage.Text.Trim() & "::1:::1:1:1'"
            Else
                txtLine = "12:" & UCase(ds.Tables(0).Rows(j).Item("BLNO")) & "::"
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("AMOUNT")) Then
                    txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("AMOUNT")) & ":"
                Else
                    txtLine = txtLine & ":"
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CODE_PACK")) Then
                    txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("CODE_PACK")) & ":"
                Else
                    txtLine = txtLine & ":"
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("PACK")) Then
                    txtLine = txtLine & RetStr(Trim(ds.Tables(0).Rows(j).Item("PACK"))) & ":"
                Else
                    txtLine = txtLine & ":"
                End If

                If Not IsDBNull(ds.Tables(0).Rows(j).Item("GROSS_WEIGHT")) Then
                    txtLine = txtLine & Trim(CType(ds.Tables(0).Rows(j).Item("GROSS_WEIGHT"), Single))
                End If
                txtLine = txtLine & ":"
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("SIZE_MEASURE")) Then
                    txtLine = txtLine & Trim(CType(ds.Tables(0).Rows(j).Item("SIZE_MEASURE"), Single)) & ":1'"
                Else
                    txtLine = txtLine & ":1'"
                End If
            End If
            i = i + 1
            j = j + 1
            sw.WriteLine(txtLine)
        Loop

        '********************************50 52

        dst.Reset()
        str = "select * from TB_CODEVESSEL_REL where CODE_VESSEL='" & txtShipCode.Text.Trim() & "'"
        If (Getdata(str, dst).Count > 0) Then
            'str = "select DISTINCT CONTAINER_NO,SEALNO,FULLOREMPTY,SIZE_CON,CONTAINER_TYPE,BAYNO,SealType,SealPerson,Sealmark,BLNO from VIEW_CON_HATCH_CARGO where Ship_ID=" & Ship_ID & " order by CONTAINER_NO"
            If ImExport = "IMPORT" Then  '进口
                str = "select DISTINCT CONTAINER_NO,SEALNO,FULLOREMPTY,SIZE_CON,CONTAINER_TYPE,BAYNO,SealType,SealPerson,Sealmark from VIEW_CON_Report where INOUT_MARK='0' and Reload = '0' and edimark='0' and Ship_ID=" & Ship_ID & " order by CONTAINER_NO"
            Else
                str = "select DISTINCT CONTAINER_NO,SEALNO,FULLOREMPTY,SIZE_CON,CONTAINER_TYPE,BAYNO,SealType,SealPerson,Sealmark from VIEW_CON_Report where INOUT_MARK='0' and Reload = '0' and edimark='0' and Ship_ID=" & Ship_ID & " and blno is not null order by CONTAINER_NO"
            End If
        Else
            'str = "select DISTINCT CONTAINER_NO,SEALNO,FULLOREMPTY,SIZE_CON,CONTAINER_TYPE,BAYNO,SealType,SealPerson,Sealmark,BLNO from VIEW_CON_HATCH_CARGO where Ship_ID=" & Ship_ID & " and unload_mark='1'  order by CONTAINER_NO"
            If ImExport = "IMPORT" Then  '进口
                str = "select DISTINCT CONTAINER_NO,SEALNO,FULLOREMPTY,SIZE_CON,CONTAINER_TYPE,BAYNO,SealType,SealPerson,Sealmark from VIEW_CON_Report where INOUT_MARK='0' and Reload = '0' and edimark='0' and Ship_ID=" & Ship_ID & " and unload_mark='1'  order by CONTAINER_NO"
            Else
                str = "select DISTINCT CONTAINER_NO,SEALNO,FULLOREMPTY,SIZE_CON,CONTAINER_TYPE,BAYNO,SealType,SealPerson,Sealmark from VIEW_CON_Report where INOUT_MARK='0' and Reload = '0' and edimark='0' and Ship_ID=" & Ship_ID & " and unload_mark='1' and blno is not null order by CONTAINER_NO"
            End If
        End If

        dst.Reset()

        dwt = Getdata(str, dst)

        If dwt.Count > 0 Then
            k = 0
            Do While k < dwt.Count
                ConType = "" '箱尺寸类型

                If Not IsDBNull(dst.Tables(0).Rows(k).Item("SIZE_CON")) Then
                    ConType = Trim(dst.Tables(0).Rows(k).Item("SIZE_CON")) & Trim(dst.Tables(0).Rows(k).Item("CONTAINER_TYPE"))
                Else
                    str = "select CONTAINER_NO,FULLOREMPTY,Size_Con,CONTAINER_Type from View_ConImage where Ship_ID=" & Ship_ID & " and CONTAINER_NO='" & Trim(dst.Tables(0).Rows(k).Item("CONTAINER_NO")) & "'"
                    dwt4 = Getdata(str, dst4)
                    If dwt4.Count > 0 Then
                        ConType = Trim(dst4.Tables(0).Rows(0).Item("Size_Con")) & Trim(dst4.Tables(0).Rows(0).Item("CONTAINER_Type"))
                    End If
                End If

                str = "select * from CODE_TYPE_SHIP_RELATION where CONTAINER_NO='" & UCase(dst.Tables(0).Rows(k).Item("Container_No")) & "' and CODE_SHIP_OWNER='CUS'" 'and CODE_SHIP_OWNER='COSW'"
                dwt1 = Getdata(str, dst1)
                If dwt1.Count > 0 Then
                    ConType = Trim(dst1.Tables(0).Rows(0).Item("CODE_CON_TYPE"))
                Else
                    dst1.Reset()
                    str = "select * from CODE_CON_TYPE where CODE_CON_TYPE='" & ConType & "' and CODE_SHIP_OWNER='CUS'" 'and CODE_SHIP_OWNER='COSW'"
                    dwt1 = Getdata(str, dst1)
                    If dwt1.Count > 0 Then
                        ConType = Trim(dst1.Tables(0).Rows(0).Item("CODE_SHIP_TYPE"))
                    Else
                        ConType = ConType
                    End If
                End If

                dst2.Reset()
                str = "select DISTINCT BLNO from VIEW_CON_Report where INOUT_MARK='0' and Reload = '0' and Ship_ID=" & Ship_ID & " and CONTAINER_NO='" & Trim(dst.Tables(0).Rows(k).Item("CONTAINER_NO")) & "'"
                dwt2 = Getdata(str, dst2)

                dst3.Reset()
                str = "select CONTAINER_NO,FULLOREMPTY,CodeConType from Con_Image where Ship_ID=" & Ship_ID & " and CONTAINER_NO='" & Trim(dst.Tables(0).Rows(k).Item("CONTAINER_NO")) & "'"
                dwt3 = Getdata(str, dst3)
                If IsDBNull(dst2.Tables(0).Rows(0).Item("BLNO")) Then
                    txtLine = "50:FDCA" & LSign.Text.Trim() & LVoyage.Text.Trim() & ":" & Trim(dst.Tables(0).Rows(k).Item("CONTAINER_NO")) & ":"
                Else

                    txtLine = "50:" & Trim(dst2.Tables(0).Rows(0).Item("BLNO")) & ":" & Trim(dst.Tables(0).Rows(k).Item("CONTAINER_NO")) & ":"
                End If
                If Trim(ConType).Length > 0 Then
                    txtLine = txtLine & Trim(ConType) & ":"
                Else
                    If IsDBNull(dst3.Tables(0).Rows(0).Item("CODECONTYPE")) Then
                        txtLine = txtLine & Trim(ConType) & ":"
                    Else
                        txtLine = txtLine & Trim(dst3.Tables(0).Rows(0).Item("CODECONTYPE")) & ":"
                    End If
                End If

                If IsDBNull(dst.Tables(0).Rows(k).Item("FULLOREMPTY")) Then
                    If IsDBNull(dst3.Tables(0).Rows(0).Item("FULLOREMPTY")) Then
                        txtLine = txtLine & ":"
                    Else
                        txtLine = txtLine & Trim(dst3.Tables(0).Rows(0).Item("FULLOREMPTY")) & ":"
                    End If
                Else
                    txtLine = txtLine & Trim(dst.Tables(0).Rows(k).Item("FULLOREMPTY")) & ":"
                End If
                    '*********************残损信息
                    dss.Reset()
                    sqlstr = "select *  from CON_SHORT where Ship_ID=" & Ship_ID & " and CONTAINER_NO='" & Trim(dst.Tables(0).Rows(k).Item("CONTAINER_NO")) & "'"
                    dws = Getdata(sqlstr, dss)
                    If dws.Count > 0 Then
                        If Not IsDBNull(dss.Tables(0).Rows(0).Item("csdm")) Then
                            txtLine = txtLine & RetStr(Trim(dss.Tables(0).Rows(0).Item("csdm"))) & "::"
                        Else
                            txtLine = txtLine & "::"
                        End If
                        If Not IsDBNull(dss.Tables(0).Rows(0).Item("csfw")) Then
                            txtLine = txtLine & RetStr(Trim(dss.Tables(0).Rows(0).Item("csfw"))) & ":"
                        Else
                            txtLine = txtLine & ":"
                        End If
                        If Not IsDBNull(dss.Tables(0).Rows(0).Item("DAMAGED_CONDITION")) Then
                            txtLine = txtLine & RetStr(Trim(dss.Tables(0).Rows(0).Item("DAMAGED_CONDITION"))) & "::"
                        Else
                            txtLine = txtLine & "::"
                        End If
                    Else
                        txtLine = txtLine & ":::::"
                    End If

                    dss.Reset()
                    sqlstr = "select BAYNO,GROSSWEIGHT,CODE_LOAD_PORT,LoadPort,CODE_UNLOAD_PORT,Unload_Port,Code_Con_Company  from View_Con_MailReport where Ship_ID=" & Ship_ID & " and CONTAINER_NO='" & Trim(dst.Tables(0).Rows(k).Item("CONTAINER_NO")) & "'"
                    dws = Getdata(sqlstr, dss)
                    If dws.Count > 0 Then

                        If Not IsDBNull(dss.Tables(0).Rows(0).Item("BAYNO")) Then
                            txtLine = txtLine & "0" & Trim(dss.Tables(0).Rows(0).Item("BAYNO")) & ":"
                        Else
                            txtLine = txtLine & ":"
                        End If
                        If Not IsDBNull(dss.Tables(0).Rows(0).Item("GROSSWEIGHT")) Then
                            txtLine = txtLine & Trim(dss.Tables(0).Rows(0).Item("GROSSWEIGHT")) & ":"
                        Else
                            txtLine = txtLine & ":"
                        End If
                        If Not IsDBNull(dss.Tables(0).Rows(0).Item("Code_Con_Company")) Then
                            txtLine = txtLine & Trim(dss.Tables(0).Rows(0).Item("Code_Con_Company")) & ":"
                        Else
                            txtLine = txtLine & ":"
                        End If

                        If Not IsDBNull(dss.Tables(0).Rows(0).Item("CODE_LOAD_PORT")) Then
                            txtLine = txtLine & Trim(dss.Tables(0).Rows(0).Item("CODE_LOAD_PORT")) & ":"
                        Else
                            txtLine = txtLine & ":"
                        End If
                        If Not IsDBNull(dss.Tables(0).Rows(0).Item("LoadPort")) Then
                            txtLine = txtLine & Trim(dss.Tables(0).Rows(0).Item("LoadPort")) & ":"
                        Else
                            txtLine = txtLine & ":"
                        End If
                        If Not IsDBNull(dss.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")) Then
                            txtLine = txtLine & Trim(dss.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")) & ":"
                        Else
                            txtLine = txtLine & ":"
                        End If
                        If Not IsDBNull(dss.Tables(0).Rows(0).Item("Unload_Port")) Then
                            txtLine = txtLine & Trim(dss.Tables(0).Rows(0).Item("Unload_Port")) & "'"
                        Else
                            txtLine = txtLine & "'"
                        End If

                        sw.WriteLine(txtLine)
                        i = i + 1
                    Else
                        txtLine = txtLine & "'"
                        sw.WriteLine(txtLine)
                        i = i + 1
                    End If

                    '****************************铅封号
                    If Not IsDBNull(dst.Tables(0).Rows(k).Item("SealMark")) Then
                        If Trim(dst.Tables(0).Rows(k).Item("SealMark")) = "1" Then
                            If Trim(dst.Tables(0).Rows(k).Item("FullOrEmpty")) = "F" Or Trim(dst.Tables(0).Rows(k).Item("FullOrEmpty")) = "L" Then
                                txtLine = "52:M/" & RetSealNO(Trim(dst.Tables(0).Rows(k).Item("SealNO"))) & "'"
                            Else
                                txtLine = "52:'"
                            End If
                            sw.WriteLine(txtLine)
                            i = i + 1
                        Else
                            If Not IsDBNull(dst.Tables(0).Rows(k).Item("SealNO")) Then
                                If Len(Trim(dst.Tables(0).Rows(k).Item("SealNO"))) Then
                                    If Trim(dst.Tables(0).Rows(k).Item("FullOrEmpty")) = "F" Or Trim(dst.Tables(0).Rows(k).Item("FullOrEmpty")) = "L" Then
                                        txtLine = "52:M/" & RetSealNO(Trim(dst.Tables(0).Rows(k).Item("SealNO"))) & "'"
                                    Else
                                        txtLine = "52:'"
                                    End If
                                    sw.WriteLine(txtLine)
                                    i = i + 1
                                Else
                                    dss.Reset()
                                    sqlstr = "select SealNO,FullOrEmpty from CON_Image where Ship_ID=" & Ship_ID & " and CONTAINER_NO='" & Trim(dst.Tables(0).Rows(k).Item("CONTAINER_NO")) & "'"
                                    dws = Getdata(sqlstr, dss)
                                    If dws.Count > 0 Then
                                        If Not IsDBNull(dss.Tables(0).Rows(0).Item("SealNO")) Then
                                            If Len(Trim(dss.Tables(0).Rows(0).Item("SealNO"))) > 0 Then
                                                If Trim(dss.Tables(0).Rows(0).Item("FullOrEmpty")) = "F" Or Trim(dss.Tables(0).Rows(0).Item("FullOrEmpty")) = "L" Then
                                                    txtLine = "52:M/" & RetSealNO(Trim(dss.Tables(0).Rows(0).Item("SealNO"))) & "'"
                                                Else
                                                    txtLine = "52:'"
                                                End If
                                                sw.WriteLine(txtLine)
                                                i = i + 1
                                            Else
                                                If Not IsDBNull(dss.Tables(0).Rows(0).Item("FullOrEmpty")) Then
                                                    If Trim(dss.Tables(0).Rows(0).Item("FullOrEmpty")) = "F" Or Trim(dss.Tables(0).Rows(0).Item("FullOrEmpty")) = "L" Then
                                                        txtLine = "52:0'"
                                                    Else
                                                        txtLine = "52:'"
                                                    End If
                                                    sw.WriteLine(txtLine)
                                                    i = i + 1

                                                End If
                                            End If
                                        Else
                                            If Not IsDBNull(dss.Tables(0).Rows(0).Item("FullOrEmpty")) Then
                                                If Trim(dss.Tables(0).Rows(0).Item("FullOrEmpty")) = "F" Or Trim(dss.Tables(0).Rows(0).Item("FullOrEmpty")) = "L" Then
                                                    txtLine = "52:0'"
                                                Else
                                                    txtLine = "52:'"
                                                End If

                                                sw.WriteLine(txtLine)
                                                i = i + 1

                                            End If

                                        End If
                                    Else
                                        txtLine = "52:'"
                                        sw.WriteLine(txtLine)
                                        i = i + 1
                                    End If
                                End If

                            Else
                                dss.Reset()
                                sqlstr = "select SealNO,FullOrEmpty  from CON_Image where Ship_ID=" & Ship_ID & " and CONTAINER_NO='" & Trim(dst.Tables(0).Rows(k).Item("CONTAINER_NO")) & "'"
                                dws = Getdata(sqlstr, dss)
                                If dws.Count > 0 Then
                                    If Not IsDBNull(dss.Tables(0).Rows(0).Item("SealNO")) Then
                                        If Len(Trim(dss.Tables(0).Rows(0).Item("SealNO"))) > 0 Then
                                            If Trim(dss.Tables(0).Rows(0).Item("FullOrEmpty")) = "F" Or Trim(dss.Tables(0).Rows(0).Item("FullOrEmpty")) = "L" Then
                                                txtLine = "52:M/" & RetSealNO(Trim(dss.Tables(0).Rows(0).Item("SealNO"))) & "'"
                                            Else
                                                txtLine = "52:'"
                                            End If
                                            sw.WriteLine(txtLine)
                                            i = i + 1

                                        End If
                                    Else
                                        txtLine = "52:'"
                                        sw.WriteLine(txtLine)
                                        i = i + 1
                                    End If
                                Else
                                    txtLine = "52:'"
                                    sw.WriteLine(txtLine)
                                    i = i + 1
                                End If
                            End If

                        End If
                    Else
                        txtLine = "52:'"
                        sw.WriteLine(txtLine)
                        i = i + 1
                    End If
                    k = k + 1
            Loop
        End If
        txtLine = "99:" & Trim(CType(i + 1, String)) & "'"
        sw.WriteLine(txtLine)
        sw.Close()
        MsgBox("理货报告生成完成,谢谢! 报文共 " & Trim(CType(i + 1, String)) & " 行 共 " & j & " 个提单 共 " & k & " 个箱子!")
        Exit Sub
Err:
        MsgBox(Err.Description)
    End Sub

    Private Function FindPort(ByVal Port As String, ByVal Company As String) As String
        Dim dsPort As New DataSet
        Dim dwPort As New DataView
        Dim str As String
        str = "select * from Code_Port_Relation where Code_Port='" & Port & "' and Code_SHIPOWNER='" & Company & "'"
        dwPort = Getdata(str, dsPort)
        If dwPort.Count > 0 Then
            FindPort = dsPort.Tables(0).Rows(0).Item("Code_Port_Relation") & ":" & dsPort.Tables(0).Rows(0).Item("Port_Relation")
        Else
            FindPort = Port & ":"
        End If
    End Function
    Private Function RetSealNO(ByVal Pstr As String) As String
        Dim i As Integer

        Dim sstr As String
        sstr = ""
        For i = 1 To Pstr.Trim().Length()
            If (Asc(Mid(Pstr, i, 1)) >= Asc("0") And Asc(Mid(Pstr, i, 1)) <= Asc("9")) Or (Asc(Mid(Pstr, i, 1)) >= Asc("a") And Asc(Mid(Pstr, i, 1)) <= Asc("z")) Or (Asc(Mid(Pstr, i, 1)) >= Asc("A") And Asc(Mid(Pstr, i, 1)) <= Asc("Z")) Then

                sstr = sstr & Mid(Pstr, i, 1)

            End If
        Next
        RetSealNO = sstr
    End Function
    Private Function RetStr(ByVal Pstr As String) As String
        Dim i As Integer

        Dim sstr As String
        sstr = ""
        For i = 1 To Pstr.Trim().Length()
            If Mid(Pstr, i, 1) = "?" Or Mid(Pstr, i, 1) = ":" Or Mid(Pstr, i, 1) = "'" Then
                sstr = sstr & "?" & Mid(Pstr, i, 1)
            Else
                sstr = sstr & Mid(Pstr, i, 1)
            End If
        Next
        RetStr = sstr

    End Function

    Private Sub btRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRead.Click
        Dim PathStr As String
        Dim FilePath As String
        Dim strFile As String

        If (txtFile.Text.Trim().Substring(txtFile.Text.Trim().Length() - 1, 1) <> "\") Then

            txtFile.Text = txtFile.Text & "\"

        End If

        strFile = txtFile.Text & "CCTALLY" & UCase(LSign.Text.Trim()) & UCase(txtShipCode.Text.Trim()) & LVoyage.Text & ".txt"

        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "NOTEPAD.EXE"
            Shell(FilePath & " " & strFile, AppWinStyle.NormalFocus, True)
        Catch
        End Try
    End Sub

    Private Sub PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB.Click

    End Sub
End Class
