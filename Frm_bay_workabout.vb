Imports TALLY.DBControl
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Math
Imports System.Drawing.Printing
Public Class Frm_bay_workabout
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_printpreview As System.Windows.Forms.Button
    Friend WithEvents btn_pagesetup As System.Windows.Forms.Button
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_defined_bay As System.Windows.Forms.ComboBox
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    Friend WithEvents Pl_bay_map As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_container_no As System.Windows.Forms.TextBox
    Friend WithEvents txt_bay As System.Windows.Forms.TextBox
    Friend WithEvents txt_load As System.Windows.Forms.TextBox
    Friend WithEvents txt_unload As System.Windows.Forms.TextBox
    Friend WithEvents txt_DELIVERY As System.Windows.Forms.TextBox
    Friend WithEvents txt_size_con As System.Windows.Forms.TextBox
    Friend WithEvents txt_CONTAINER_TYPE As System.Windows.Forms.TextBox
    Friend WithEvents txt_GROSSWEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents txt_port1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_port2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_port4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_port3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_port7 As System.Windows.Forms.TextBox
    Friend WithEvents txt_port6 As System.Windows.Forms.TextBox
    Friend WithEvents txt_port8 As System.Windows.Forms.TextBox
    Friend WithEvents txt_port5 As System.Windows.Forms.TextBox
    Friend WithEvents txt_port9 As System.Windows.Forms.TextBox
    Friend WithEvents txt_port10 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_scale_rate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_all As System.Windows.Forms.Button
    Friend WithEvents chklyg As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txt_oldbay As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_sealno As System.Windows.Forms.TextBox
    Friend WithEvents txt_work_no As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_work_date As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chklyg = New System.Windows.Forms.CheckBox
        Me.btn_all = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_scale_rate = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btn_printpreview = New System.Windows.Forms.Button
        Me.btn_pagesetup = New System.Windows.Forms.Button
        Me.btn_enter = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_defined_bay = New System.Windows.Forms.ComboBox
        Me.btn_cancle = New System.Windows.Forms.Button
        Me.Pl_bay_map = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_port1 = New System.Windows.Forms.TextBox
        Me.txt_port2 = New System.Windows.Forms.TextBox
        Me.txt_port4 = New System.Windows.Forms.TextBox
        Me.txt_port3 = New System.Windows.Forms.TextBox
        Me.txt_port7 = New System.Windows.Forms.TextBox
        Me.txt_port6 = New System.Windows.Forms.TextBox
        Me.txt_port8 = New System.Windows.Forms.TextBox
        Me.txt_port5 = New System.Windows.Forms.TextBox
        Me.txt_port9 = New System.Windows.Forms.TextBox
        Me.txt_port10 = New System.Windows.Forms.TextBox
        Me.txt_container_no = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_bay = New System.Windows.Forms.TextBox
        Me.txt_load = New System.Windows.Forms.TextBox
        Me.txt_unload = New System.Windows.Forms.TextBox
        Me.txt_DELIVERY = New System.Windows.Forms.TextBox
        Me.txt_size_con = New System.Windows.Forms.TextBox
        Me.txt_GROSSWEIGHT = New System.Windows.Forms.TextBox
        Me.txt_CONTAINER_TYPE = New System.Windows.Forms.TextBox
        Me.txt_oldbay = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_sealno = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_work_no = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_work_date = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chklyg)
        Me.GroupBox1.Controls.Add(Me.btn_all)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_scale_rate)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btn_printpreview)
        Me.GroupBox1.Controls.Add(Me.btn_pagesetup)
        Me.GroupBox1.Controls.Add(Me.btn_enter)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_defined_bay)
        Me.GroupBox1.Controls.Add(Me.btn_cancle)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 74)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chklyg
        '
        Me.chklyg.Location = New System.Drawing.Point(32, 44)
        Me.chklyg.Name = "chklyg"
        Me.chklyg.Size = New System.Drawing.Size(90, 24)
        Me.chklyg.TabIndex = 17
        Me.chklyg.Text = "过滤空贝位"
        '
        'btn_all
        '
        Me.btn_all.Location = New System.Drawing.Point(430, 16)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(30, 24)
        Me.btn_all.TabIndex = 16
        Me.btn_all.Text = "全船打印"
        Me.btn_all.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(84, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 23)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "%"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Visible = False
        '
        'txt_scale_rate
        '
        Me.txt_scale_rate.Location = New System.Drawing.Point(50, 44)
        Me.txt_scale_rate.Name = "txt_scale_rate"
        Me.txt_scale_rate.Size = New System.Drawing.Size(34, 21)
        Me.txt_scale_rate.TabIndex = 14
        Me.txt_scale_rate.Text = ""
        Me.txt_scale_rate.Visible = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(10, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 23)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "缩放"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label11.Visible = False
        '
        'btn_printpreview
        '
        Me.btn_printpreview.Location = New System.Drawing.Point(290, 16)
        Me.btn_printpreview.Name = "btn_printpreview"
        Me.btn_printpreview.Size = New System.Drawing.Size(24, 24)
        Me.btn_printpreview.TabIndex = 12
        Me.btn_printpreview.Text = "打印预揽"
        Me.btn_printpreview.Visible = False
        '
        'btn_pagesetup
        '
        Me.btn_pagesetup.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_pagesetup.Location = New System.Drawing.Point(308, 22)
        Me.btn_pagesetup.Name = "btn_pagesetup"
        Me.btn_pagesetup.Size = New System.Drawing.Size(92, 44)
        Me.btn_pagesetup.TabIndex = 11
        Me.btn_pagesetup.Text = "刷新"
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(362, 16)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(24, 24)
        Me.btn_enter.TabIndex = 10
        Me.btn_enter.Text = "单贝打印"
        Me.btn_enter.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(158, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "BAY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_defined_bay
        '
        Me.cmb_defined_bay.Location = New System.Drawing.Point(204, 44)
        Me.cmb_defined_bay.Name = "cmb_defined_bay"
        Me.cmb_defined_bay.Size = New System.Drawing.Size(68, 20)
        Me.cmb_defined_bay.TabIndex = 7
        '
        'btn_cancle
        '
        Me.btn_cancle.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btn_cancle.Location = New System.Drawing.Point(462, 22)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(92, 44)
        Me.btn_cancle.TabIndex = 9
        Me.btn_cancle.Text = "取消"
        '
        'Pl_bay_map
        '
        Me.Pl_bay_map.AutoScroll = True
        Me.Pl_bay_map.BackColor = System.Drawing.SystemColors.Control
        Me.Pl_bay_map.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pl_bay_map.ForeColor = System.Drawing.Color.White
        Me.Pl_bay_map.Location = New System.Drawing.Point(0, 74)
        Me.Pl_bay_map.Name = "Pl_bay_map"
        Me.Pl_bay_map.Size = New System.Drawing.Size(580, 673)
        Me.Pl_bay_map.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_port1)
        Me.GroupBox2.Controls.Add(Me.txt_port2)
        Me.GroupBox2.Controls.Add(Me.txt_port4)
        Me.GroupBox2.Controls.Add(Me.txt_port3)
        Me.GroupBox2.Controls.Add(Me.txt_port7)
        Me.GroupBox2.Controls.Add(Me.txt_port6)
        Me.GroupBox2.Controls.Add(Me.txt_port8)
        Me.GroupBox2.Controls.Add(Me.txt_port5)
        Me.GroupBox2.Controls.Add(Me.txt_port9)
        Me.GroupBox2.Controls.Add(Me.txt_port10)
        Me.GroupBox2.Controls.Add(Me.txt_container_no)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_bay)
        Me.GroupBox2.Controls.Add(Me.txt_load)
        Me.GroupBox2.Controls.Add(Me.txt_unload)
        Me.GroupBox2.Controls.Add(Me.txt_DELIVERY)
        Me.GroupBox2.Controls.Add(Me.txt_size_con)
        Me.GroupBox2.Controls.Add(Me.txt_GROSSWEIGHT)
        Me.GroupBox2.Controls.Add(Me.txt_CONTAINER_TYPE)
        Me.GroupBox2.Controls.Add(Me.txt_oldbay)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_sealno)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_work_no)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txt_work_date)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(580, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 747)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "箱信息"
        '
        'txt_port1
        '
        Me.txt_port1.Location = New System.Drawing.Point(22, 618)
        Me.txt_port1.Name = "txt_port1"
        Me.txt_port1.ReadOnly = True
        Me.txt_port1.Size = New System.Drawing.Size(72, 21)
        Me.txt_port1.TabIndex = 9
        Me.txt_port1.Text = ""
        Me.txt_port1.Visible = False
        '
        'txt_port2
        '
        Me.txt_port2.Location = New System.Drawing.Point(106, 618)
        Me.txt_port2.Name = "txt_port2"
        Me.txt_port2.ReadOnly = True
        Me.txt_port2.Size = New System.Drawing.Size(72, 21)
        Me.txt_port2.TabIndex = 8
        Me.txt_port2.Text = ""
        Me.txt_port2.Visible = False
        '
        'txt_port4
        '
        Me.txt_port4.Location = New System.Drawing.Point(106, 639)
        Me.txt_port4.Name = "txt_port4"
        Me.txt_port4.ReadOnly = True
        Me.txt_port4.Size = New System.Drawing.Size(72, 21)
        Me.txt_port4.TabIndex = 10
        Me.txt_port4.Text = ""
        Me.txt_port4.Visible = False
        '
        'txt_port3
        '
        Me.txt_port3.Location = New System.Drawing.Point(22, 639)
        Me.txt_port3.Name = "txt_port3"
        Me.txt_port3.ReadOnly = True
        Me.txt_port3.Size = New System.Drawing.Size(72, 21)
        Me.txt_port3.TabIndex = 12
        Me.txt_port3.Text = ""
        Me.txt_port3.Visible = False
        '
        'txt_port7
        '
        Me.txt_port7.Location = New System.Drawing.Point(22, 681)
        Me.txt_port7.Name = "txt_port7"
        Me.txt_port7.ReadOnly = True
        Me.txt_port7.Size = New System.Drawing.Size(72, 21)
        Me.txt_port7.TabIndex = 11
        Me.txt_port7.Text = ""
        Me.txt_port7.Visible = False
        '
        'txt_port6
        '
        Me.txt_port6.Location = New System.Drawing.Point(106, 660)
        Me.txt_port6.Name = "txt_port6"
        Me.txt_port6.ReadOnly = True
        Me.txt_port6.Size = New System.Drawing.Size(72, 21)
        Me.txt_port6.TabIndex = 4
        Me.txt_port6.Text = ""
        Me.txt_port6.Visible = False
        '
        'txt_port8
        '
        Me.txt_port8.Location = New System.Drawing.Point(106, 681)
        Me.txt_port8.Name = "txt_port8"
        Me.txt_port8.ReadOnly = True
        Me.txt_port8.Size = New System.Drawing.Size(72, 21)
        Me.txt_port8.TabIndex = 3
        Me.txt_port8.Text = ""
        Me.txt_port8.Visible = False
        '
        'txt_port5
        '
        Me.txt_port5.Location = New System.Drawing.Point(22, 660)
        Me.txt_port5.Name = "txt_port5"
        Me.txt_port5.ReadOnly = True
        Me.txt_port5.Size = New System.Drawing.Size(72, 21)
        Me.txt_port5.TabIndex = 5
        Me.txt_port5.Text = ""
        Me.txt_port5.Visible = False
        '
        'txt_port9
        '
        Me.txt_port9.Location = New System.Drawing.Point(22, 702)
        Me.txt_port9.Name = "txt_port9"
        Me.txt_port9.ReadOnly = True
        Me.txt_port9.Size = New System.Drawing.Size(72, 21)
        Me.txt_port9.TabIndex = 7
        Me.txt_port9.Text = ""
        Me.txt_port9.Visible = False
        '
        'txt_port10
        '
        Me.txt_port10.Location = New System.Drawing.Point(106, 702)
        Me.txt_port10.Name = "txt_port10"
        Me.txt_port10.ReadOnly = True
        Me.txt_port10.Size = New System.Drawing.Size(72, 21)
        Me.txt_port10.TabIndex = 6
        Me.txt_port10.Text = ""
        Me.txt_port10.Visible = False
        '
        'txt_container_no
        '
        Me.txt_container_no.Location = New System.Drawing.Point(70, 98)
        Me.txt_container_no.Name = "txt_container_no"
        Me.txt_container_no.Size = New System.Drawing.Size(124, 21)
        Me.txt_container_no.TabIndex = 1
        Me.txt_container_no.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "装货港"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "卸货港"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "目的港"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(20, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "贝位"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(20, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "箱号"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(20, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "尺寸"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(20, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "箱重"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(20, 386)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "箱型"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_bay
        '
        Me.txt_bay.Location = New System.Drawing.Point(70, 134)
        Me.txt_bay.Name = "txt_bay"
        Me.txt_bay.Size = New System.Drawing.Size(124, 21)
        Me.txt_bay.TabIndex = 1
        Me.txt_bay.Text = ""
        '
        'txt_load
        '
        Me.txt_load.Location = New System.Drawing.Point(70, 242)
        Me.txt_load.Name = "txt_load"
        Me.txt_load.Size = New System.Drawing.Size(124, 21)
        Me.txt_load.TabIndex = 1
        Me.txt_load.Text = ""
        '
        'txt_unload
        '
        Me.txt_unload.Location = New System.Drawing.Point(70, 278)
        Me.txt_unload.Name = "txt_unload"
        Me.txt_unload.Size = New System.Drawing.Size(124, 21)
        Me.txt_unload.TabIndex = 1
        Me.txt_unload.Text = ""
        '
        'txt_DELIVERY
        '
        Me.txt_DELIVERY.Location = New System.Drawing.Point(70, 314)
        Me.txt_DELIVERY.Name = "txt_DELIVERY"
        Me.txt_DELIVERY.Size = New System.Drawing.Size(124, 21)
        Me.txt_DELIVERY.TabIndex = 1
        Me.txt_DELIVERY.Text = ""
        '
        'txt_size_con
        '
        Me.txt_size_con.Location = New System.Drawing.Point(70, 350)
        Me.txt_size_con.Name = "txt_size_con"
        Me.txt_size_con.Size = New System.Drawing.Size(124, 21)
        Me.txt_size_con.TabIndex = 1
        Me.txt_size_con.Text = ""
        '
        'txt_GROSSWEIGHT
        '
        Me.txt_GROSSWEIGHT.Location = New System.Drawing.Point(70, 422)
        Me.txt_GROSSWEIGHT.Name = "txt_GROSSWEIGHT"
        Me.txt_GROSSWEIGHT.Size = New System.Drawing.Size(124, 21)
        Me.txt_GROSSWEIGHT.TabIndex = 1
        Me.txt_GROSSWEIGHT.Text = ""
        '
        'txt_CONTAINER_TYPE
        '
        Me.txt_CONTAINER_TYPE.Location = New System.Drawing.Point(70, 386)
        Me.txt_CONTAINER_TYPE.Name = "txt_CONTAINER_TYPE"
        Me.txt_CONTAINER_TYPE.Size = New System.Drawing.Size(124, 21)
        Me.txt_CONTAINER_TYPE.TabIndex = 1
        Me.txt_CONTAINER_TYPE.Text = ""
        '
        'txt_oldbay
        '
        Me.txt_oldbay.Location = New System.Drawing.Point(70, 170)
        Me.txt_oldbay.Name = "txt_oldbay"
        Me.txt_oldbay.Size = New System.Drawing.Size(124, 21)
        Me.txt_oldbay.TabIndex = 1
        Me.txt_oldbay.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(12, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "配载贝位"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_sealno
        '
        Me.txt_sealno.Location = New System.Drawing.Point(70, 206)
        Me.txt_sealno.Name = "txt_sealno"
        Me.txt_sealno.Size = New System.Drawing.Size(124, 21)
        Me.txt_sealno.TabIndex = 1
        Me.txt_sealno.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(12, 206)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 23)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "铅封号"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_work_no
        '
        Me.txt_work_no.Location = New System.Drawing.Point(70, 458)
        Me.txt_work_no.Name = "txt_work_no"
        Me.txt_work_no.Size = New System.Drawing.Size(124, 21)
        Me.txt_work_no.TabIndex = 1
        Me.txt_work_no.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(20, 458)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 23)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "理货员"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_work_date
        '
        Me.txt_work_date.Location = New System.Drawing.Point(70, 494)
        Me.txt_work_date.Name = "txt_work_date"
        Me.txt_work_date.Size = New System.Drawing.Size(124, 21)
        Me.txt_work_date.TabIndex = 1
        Me.txt_work_date.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(12, 494)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 23)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "理货时间"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Interval = 20000
        '
        'Frm_bay_workabout
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(780, 747)
        Me.Controls.Add(Me.Pl_bay_map)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_bay_workabout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "作业进度查询"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim notshowbaymap As Integer
    Dim ds_defined_bay As New DataSet
    Dim storedpagesettings As PageSettings
    '船信息
    Dim v_id As Integer
    Dim ENG_VESSEL As String
    Dim CHI_VESSEL As String
    Dim VOYAGE As String
    Dim ds_exist_bay As New DataSet
    Dim ds_ship As New DataSet
    Dim i, j, n, k As Integer
    Dim col_count As Integer
    Dim bmp_bay_map As Bitmap
    Dim bmpgraphics_bay_map As Graphics
    Dim pen_line As New Pen(Color.Black, 1)
    Dim print_result As New PrintDocument
    Dim distolefe As Integer = 0 '距左边距移动的位移
    Dim distotop As Integer = 40 '最上面一行写BAY
    Dim xChange As Integer = 40 '横坐标便宜距离
    Const yRect As Integer = 56 '举行的高度
    Dim ff As New FontFamily("宋体") 'Arial
    Dim f As New Font(ff, 6)
    Dim f_container As New Font(ff, 10) '8.3
    Dim bay_f As New Font(ff, 10, FontStyle.Bold)
    Dim container_f As New Font(ff, 13, FontStyle.Regular)
    Dim bru_fill As New SolidBrush(Color.Blue)
    Dim pen_cross As New Pen(Color.Black, 0.5) '画差
    '甲板
    Dim ds_board_char As New DataSet
    Dim small_row As Integer
    Dim small_col As Integer
    Dim big_row As Integer
    Dim big_col As Integer
    Dim ds_board As New DataSet
    Dim bay_row As String
    Dim bay_col As String
    Dim ds_unuse_col As New DataSet
    Dim BAYNO As String
    Dim bayno_joint As String '通贝的贝位号
    Dim BAYNO_MID As String '贝号-
    Dim BAYNO_MID_1 As String '贝号-
    Dim ds_container As New DataSet   '找箱号
    Dim board_height As Integer = 0 '甲板的高度''''=200
    Dim board_height_print As Integer = 0 '甲板的高度——打印=400
    '舱内
    Dim ds_cabin As New DataSet
    Dim ds_cabin_char As New DataSet
    Dim small_row_cabin As Integer
    Dim small_col_cabin As Integer
    Dim big_row_cabin As Integer
    Dim big_col_cabin As Integer
    Dim bay_row_cabin As String
    Dim bay_col_cabin As String
    '   Dim storepagesettings As New PageSettings()
    '鼠标单击事件
    Dim p As Point
    Dim color1 As Color
    Dim rectx As Single
    Dim recty As Single
    Dim j_col As Integer
    Dim i_row As Integer
    Dim col_count_board As Integer
    Dim col_count_cabin As Integer
    Dim mark As String
    Dim bayno_check As String '检查数据库中是否有此贝位号上的箱子
    Dim bayno_check_joint As String '检查数据库中是否有此通贝贝位号上的箱子
    Dim sql_str_bayno As String
    Dim ds_bayno As New DataSet
    Dim dsjoint As New DataSet
    ''''''处理行毛重统计的问题
    Dim row_GROSSWEIGHT As Single '行毛重
    Dim total_GROSSWEIGHT As Single '总毛重
    Dim row_GROSSWEIGHT_str As String
    Dim total_GROSSWEIGHT_str As String
    '定义卸货港显示的代码
    Dim ds_unload_port As New DataSet
    '定义存放卸货港显示代码的数组
    Dim substitute(10) As String
    Dim ptdlg As PrintDialog
    Dim topsize As Integer

    Private Sub Frm_bay_workabout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        topsize = 5
        notshowbaymap = 0
        bmp_bay_map = New Bitmap(Me.Pl_bay_map.Width, Me.Pl_bay_map.Height)  '(800, 900)
        bmpgraphics_bay_map = Graphics.FromImage(bmp_bay_map)
        Me.Pl_bay_map.BackgroundImage = bmp_bay_map
        pen_line.DashStyle = DashStyle.Solid
        '写船名
        If Getdata("select VESSEL_ID,VESSEL.ENG_VESSEL,VESSEL.CHI_VESSEL, sship.VOYAGE from VESSEL,sship where sship.ship_id=" & Ship_ID & " and sship.v_id=VESSEL.VESSEL_id", ds_ship).Count > 0 Then
            v_id = ds_ship.Tables(0).Rows(0).Item("VESSEL_id")
            ENG_VESSEL = ds_ship.Tables(0).Rows(0).Item("ENG_VESSEL")
            CHI_VESSEL = ds_ship.Tables(0).Rows(0).Item("CHI_VESSEL")
            VOYAGE = ds_ship.Tables(0).Rows(0).Item("VOYAGE")
            '写连云港外理
            bmpgraphics_bay_map.DrawString("COSTACO LIANYUNGANG  连云港外理", Me.Font, Brushes.Black, distolefe + 0, distotop - 10 + topsize)
            '写船名航次
            bmpgraphics_bay_map.DrawString("VESSEL:" & ENG_VESSEL, Me.Font, Brushes.Black, distolefe + 40 + 190, distotop - 10 + topsize)
            bmpgraphics_bay_map.DrawString("VOY:" & VOYAGE, Me.Font, Brushes.Black, distolefe + 40 + 320, distotop - 10 + topsize)
            bmpgraphics_bay_map.DrawString("POL：LYG", Me.Font, Brushes.Black, distolefe + 40 + 420, distotop - 10 + topsize)
            '写BAY
            bmpgraphics_bay_map.DrawString("BAY： " & Me.cmb_defined_bay.Text, bay_f, Brushes.Black, distolefe + 40 + 20 + 500, distotop - 10 + topsize)
            Me.Pl_bay_map.Refresh()
            '写已存在的贝列_全船
            cmbbaylist()
        End If
    End Sub

    Private Sub cmbbaylist()
        '写已存在的贝列_全船
        If Getdata("select bay_num from con_map,sship where sship.ship_id='" & Ship_ID & "' and sship.v_id=con_map.v_id group by bay_num order by bay_num", ds_exist_bay).Count > 0 Then
            For i = 0 To ds_exist_bay.Tables(0).Rows.Count - 1
                Me.cmb_defined_bay.Items.Add(ds_exist_bay.Tables(0).Rows(i).Item("bay_num"))
            Next
        End If
    End Sub

    Private Sub cmblygbaylist()
        '写已存在的贝列_全船
        If Getdata("sp_get_lyg_bay " & Ship_ID & ",'" & GL_IOPORT & "' ", ds_exist_bay).Count > 0 Then
            For i = 0 To ds_exist_bay.Tables(0).Rows.Count - 1
                Me.cmb_defined_bay.Items.Add(ds_exist_bay.Tables(0).Rows(i).Item("bay_num"))
            Next
        End If
    End Sub

    Private Sub chklyg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklyg.CheckedChanged
        Me.cmb_defined_bay.Items.Clear()
        If chklyg.Checked = True Then
            cmblygbaylist()
        Else
            cmbbaylist()
        End If
    End Sub

    Private Sub cmb_defined_bay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_defined_bay.TextChanged
        Me.cmb_defined_bay.Refresh()
        If notshowbaymap = 0 Then
            show_bay_map(bmpgraphics_bay_map)
        End If
        txt_null()
        Me.Timer1.Start()
    End Sub

    Private Sub show_bay_map(ByVal bmpgraphics_bay_map As Graphics)
        '显示卸货港的首字母代码表示
        'txt_unload_port()
        '清空
        'bmpgraphics_bay_map  Pl_bay_map.Dispose()

        'bmpgraphics_bay_map.Dispose()

        bmpgraphics_bay_map.Clear(Color.White)
        small_col = 0
        big_col = 0
        distolefe = 20
        distotop = 0
        'distotop = 0
        small_col_cabin = 0
        big_col_cabin = 0
        '''计算甲板的高度
        board_height = 0
        ''甲板取甲板的列数
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='board' order by id", ds_board).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='board'", ds_board_char)
            small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") '取甲板屏幕的最小行
            big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") '取甲板屏幕的最大行
            small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") '取甲板屏幕的最小列
            big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") '取甲板屏幕的最大列
            '''计算甲板的高度
            board_height = (big_row - small_row + 1) * 20
        End If
        '取舱内的列数
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='cabin' order by id", ds_cabin).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='cabin'", ds_cabin_char)
            small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") '取舱内屏幕的最小列
            big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") '取舱内屏幕的最大列
            small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row") '取舱内屏幕的最小行
            big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row") '取舱内屏幕的最大行
        End If
        '写连云港外理
        bmpgraphics_bay_map.DrawString("COSTACO LIANYUNGANG  连云港外理", Me.Font, Brushes.Black, distolefe + 0, distotop + topsize)
        '写船名航次
        bmpgraphics_bay_map.DrawString("VESSEL:" & ENG_VESSEL, Me.Font, Brushes.Black, distolefe + 40 + 190, distotop + topsize)
        bmpgraphics_bay_map.DrawString("VOY:" & VOYAGE, Me.Font, Brushes.Black, distolefe + 40 + 320, distotop + topsize)
        bmpgraphics_bay_map.DrawString("POL：LYG", Me.Font, Brushes.Black, distolefe + 40 + 420, distotop + topsize)
        '写BAY
        bmpgraphics_bay_map.DrawString("BAY： " & Me.cmb_defined_bay.Text, bay_f, Brushes.Black, distolefe + 40 + 20 + 500, distotop + topsize)
        '甲板开始
        If ds_board.Tables(0).Rows.Count > 0 Then
            '计算甲板结果图的顶点位置
            If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '比较甲板和舱内的列数
                col_count = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If
            ''画甲板矩形
            For i = small_row To big_row
                For j = small_col To big_col
                    If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then
                        '矩形
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * 10 + 20 * (j - small_col + 1), distotop + board_height + 20 - 20 * (i - small_row + 1) + 20, 20, 20)
                        '贝位号
                        BAYNO = ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                        '判断此贝位号有无箱号
                        'If Getdata("select con_image.CONTAINER_NO,con_unload_port_substitute.substitute  from con_image left join con_unload_port_substitute on con_image.ship_id=con_unload_port_substitute.ship_id and right(con_image.code_unload_port,3)=right(con_unload_port_substitute.code_unload_port,3)  where  con_image.BAYNO='" & BAYNO & "'and (con_image.CODE_LOAD_PORT like '%lyg%' or con_image.CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                        If Getdata("select CONTAINER_NO,unload_mark substitute from con_image where BAYNO='" & BAYNO & "'and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            '判断卸货港应该用什么样的颜色
                            fill_rectangle_color()
                            '填充矩形
                            bmpgraphics_bay_map.FillRectangle(bru_fill, distolefe + col_count * 10 + 20 * (j - small_col + 1) + 1, distotop + board_height + 20 - 20 * (i - small_row + 1) + 1 + 20, 19, 19)
                            bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("substitute"), container_f, Brushes.Black, distolefe + col_count * 10 + 20 * (j - small_col + 1) + 2, distotop + board_height + 20 - 20 * (i - small_row + 1) + 1 + 20)
                        End If
                        '判断此 Bay 是否为通 Bay
                        dsjoint.Reset()
                        If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and joint='1'", dsjoint).Count > 0 Then

                            '通贝贝位号
                            '计算通贝贝号
                            If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") + 1 < 10 Then
                                bayno_joint = "0" & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") + 1
                            Else
                                bayno_joint = ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") + 1
                            End If
                            '计算通贝贝位号
                            bayno_joint = bayno_joint & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                            '判断此通贝贝位号有无箱号
                            'If Getdata("select con_image.CONTAINER_NO,con_unload_port_substitute.substitute  from con_image left join con_unload_port_substitute on con_image.ship_id=con_unload_port_substitute.ship_id and right(con_image.code_unload_port,3)=right(con_unload_port_substitute.code_unload_port,3)  where  con_image.BAYNO='" & bayno_joint & "' and (con_image.CODE_LOAD_PORT like '%lyg%' or con_image.CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            If Getdata("select CONTAINER_NO,unload_mark substitute from con_image where BAYNO='" & bayno_joint & "'and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                '判断卸货港应该用什么样的颜色
                                fill_rectangle_color()
                                '填充矩形
                                bmpgraphics_bay_map.FillRectangle(bru_fill, distolefe + col_count * 10 + 20 * (j - small_col + 1) + 1, distotop + board_height + 20 - 20 * (i - small_row + 1) + 1 + 20, 19, 19)
                                bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("substitute"), container_f, Brushes.Black, distolefe + col_count * 10 + 20 * (j - small_col + 1) + 2, distotop + board_height + 20 - 20 * (i - small_row + 1) + 1 + 20)
                            End If
                        End If
                        '贝位号--贝号减一
                        BAYNO_MID = ""
                        If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1 < 10 Then
                            BAYNO_MID = "0" & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1
                            BAYNO_MID = BAYNO_MID & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                        Else
                            BAYNO_MID = ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1
                            BAYNO_MID = BAYNO_MID & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                        End If
                        '判断此 Bay 是否为通 Bay
                        BAYNO_MID_1 = Mid(Trim(BAYNO_MID), 1, 2)
                        If CType(BAYNO_MID_1, Int16) Mod 2 = 0 Then
                            BAYNO_MID_1 = CType(BAYNO_MID_1, Int16) - 1
                        End If
                        If BAYNO_MID_1.Trim().Length = 1 Then
                            BAYNO_MID_1 = "0" & BAYNO_MID_1.Trim()
                        End If
                        dsjoint.Reset()
                        If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & BAYNO_MID_1 & "' and joint='1'", dsjoint).Count > 0 Then

                            '判断此贝位号有无箱号
                            If Len(Trim(BAYNO_MID)) > 0 Then
                                'If Getdata("select CONTAINER_NO,unload_mark substitute from con_image where BAYNO='" & BAYNO & "'and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                If Getdata("select substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT,FULLOREMPTY,substring(ltrim(CONTAINER_TYPE),1,1) CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where  con_image.BAYNO='" & BAYNO_MID & "' and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                    bmpgraphics_bay_map.DrawLine(pen_cross, distolefe + col_count * 10 + 20 * (j - small_col + 1) + 1, distotop + board_height + 20 - 20 * (i - small_row + 1) + 1 + 20, distolefe + col_count * 10 + 20 * (j - small_col + 1) + 19, distotop + board_height + 20 - 20 * (i - small_row + 1) + 20 + 19)
                                    bmpgraphics_bay_map.DrawLine(pen_cross, distolefe + col_count * 10 + 20 * (j - small_col + 1) + 1, distotop + board_height + 20 - 20 * (i - small_row + 1) + 19 + 20, distolefe + col_count * 10 + 20 * (j - small_col + 1) + 19, distotop + board_height + 20 - 20 * (i - small_row + 1) + 20 + 1)
                                End If
                            End If
                        End If
                    End If
                Next
            Next
            '画贝层
            For i = small_row To big_row '战位最大屏列,按行读，行坐标先变
                bay_row = 78 + i * 2
                bmpgraphics_bay_map.DrawString(bay_row, Me.Font, Brushes.Black, distolefe + 5, distotop + board_height + 20 + 20 - 20 * (i - small_row + 1) - 20 + 5 + 20) '贝层
            Next
            ''写贝列
            n = big_col - small_col + 1
            'bay_row = 78 + i * 2
            Dim strcon As Integer
            strcon = 1
            Dim strsmallcol As Integer
            strsmallcol = small_col
            Dim strbigcol As Integer
            strbigcol = big_col
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col = "0" & k * 2
                        Else
                            bay_col = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col = "0" & k * 2
                            Else
                                bay_col = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_bay_map.DrawString(bay_col, Me.Font, Brushes.Black, distolefe + col_count * 10 + 20 * (j - strsmallcol + strcon) + 3, distotop + board_height + 20 + 3 - (big_row - small_row + 1) * 20) '贝列
            Next
        End If '甲板结束
        ''舱内开始
        If ds_cabin.Tables(0).Rows.Count > 0 Then
            '计算舱内结果图的顶点位置
            If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                col_count = (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If
            ''画舱内矩形
            For i = small_row_cabin To big_row_cabin
                For j = small_col_cabin To big_col_cabin
                    If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("user_char") = 1 Then
                        '矩形
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * 10 + 20 * (j - small_col_cabin + 1), distotop + board_height + 40 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1) + 20, 20, 20) '   bmpgraphics_result_cabin.DrawRectangle(pen_line, 20 * (j - small_col_cabin + 1), 200 - 20 * (i - small_row_cabin + 1), 20, 20
                        '贝位号
                        BAYNO = ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                        '判断此贝位号有无箱号
                        'If Getdata("select con_image.CONTAINER_NO,con_unload_port_substitute.substitute  from con_image left join con_unload_port_substitute on con_image.ship_id=con_unload_port_substitute.ship_id and right(con_image.code_unload_port,3)=right(con_unload_port_substitute.code_unload_port,3) where  con_image.BAYNO='" & BAYNO & "'and (con_image.CODE_LOAD_PORT like '%lyg%' or con_image.CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                        If Getdata("select CONTAINER_NO,unload_mark substitute from con_image where BAYNO='" & BAYNO & "'and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            '判断卸货港应该用什么样的颜色
                            fill_rectangle_color()
                            '填充矩形
                            bmpgraphics_bay_map.FillRectangle(bru_fill, distolefe + col_count * 10 + 20 * (j - small_col_cabin + 1) + 1, distotop + board_height + 40 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1) + 1 + 20, 19, 19)
                            bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("substitute"), container_f, Brushes.Black, distolefe + col_count * 10 + 20 * (j - small_col_cabin + 1) + 2, distotop + board_height + 40 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1) + 1 + 20)
                        End If
                        '判断此 Bay 是否为通 Bay
                        dsjoint.Reset()
                        If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and joint='1'", dsjoint).Count > 0 Then

                            '通贝贝位号
                            '计算通贝贝号
                            If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") + 1 < 10 Then
                                bayno_joint = "0" & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") + 1
                            Else
                                bayno_joint = ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") + 1
                            End If
                            '计算通贝贝位号
                            bayno_joint = bayno_joint & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                            '判断此通贝贝位号有无箱号
                            'If Getdata("select con_image.CONTAINER_NO,con_unload_port_substitute.substitute  from con_image left join con_unload_port_substitute on con_image.ship_id=con_unload_port_substitute.ship_id and right(con_image.code_unload_port,3)=right(con_unload_port_substitute.code_unload_port,3)  where  con_image.BAYNO='" & bayno_joint & "' and (con_image.CODE_LOAD_PORT like '%lyg%' or con_image.CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            If Getdata("select CONTAINER_NO,unload_mark substitute from con_image where BAYNO='" & bayno_joint & "'and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                '判断卸货港应该用什么样的颜色
                                fill_rectangle_color()
                                '填充矩形
                                bmpgraphics_bay_map.FillRectangle(bru_fill, distolefe + col_count * 10 + 20 * (j - small_col_cabin + 1) + 1, distotop + board_height + 40 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1) + 1 + 20, 19, 19)
                                bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("substitute"), container_f, Brushes.Black, distolefe + col_count * 10 + 20 * (j - small_col_cabin + 1) + 2, distotop + board_height + 40 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1) + 1 + 20)
                            End If
                        End If
                        '贝位号--贝号减一
                        If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1 < 10 Then
                            BAYNO_MID = "0" & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1
                            BAYNO_MID = BAYNO_MID & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                        Else
                            BAYNO_MID = ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1
                            BAYNO_MID = BAYNO_MID & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                        End If
                        '判断此 Bay 是否为通 Bay
                        BAYNO_MID_1 = Mid(Trim(BAYNO_MID), 1, 2)
                        If CType(BAYNO_MID_1, Int16) Mod 2 = 0 Then
                            BAYNO_MID_1 = CType(BAYNO_MID_1, Int16) - 1
                        End If
                        If BAYNO_MID_1.Trim().Length = 1 Then
                            BAYNO_MID_1 = "0" & BAYNO_MID_1.Trim()
                        End If
                        dsjoint.Reset()
                        If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & BAYNO_MID_1 & "' and joint='1'", dsjoint).Count > 0 Then

                            '判断此贝位号有无箱号
                            'If Getdata("select substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT,FULLOREMPTY,substring(ltrim(CONTAINER_TYPE),1,1) CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where  con_image.BAYNO='" & BAYNO_MID & "' and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            If Getdata("select substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT,FULLOREMPTY,substring(ltrim(CONTAINER_TYPE),1,1) CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where  con_image.BAYNO='" & BAYNO_MID & "' and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                bmpgraphics_bay_map.DrawLine(pen_cross, distolefe + col_count * 10 + 20 * (j - small_col_cabin + 1) + 1, distotop + board_height + 40 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1) + 1 + 20, distolefe + col_count * 10 + 20 * (j - small_col_cabin + 1) + 19, distotop + board_height + 40 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1) + 19 + 20)
                                bmpgraphics_bay_map.DrawLine(pen_cross, distolefe + col_count * 10 + 20 * (j - small_col_cabin + 1) + 1, distotop + board_height + 40 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1) + 19 + 20, distolefe + col_count * 10 + 20 * (j - small_col_cabin + 1) + 19, distotop + board_height + 40 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1) + 1 + 20)
                            End If
                        End If
                    End If
                Next
            Next
            '画贝层
            For i = small_row_cabin To big_row_cabin '战位最大屏列,按行读，行坐标先变
                If i * 2 < 10 Then
                    bay_row_cabin = "0" & i * 2
                Else
                    bay_row_cabin = i * 2
                End If
                bmpgraphics_bay_map.DrawString(bay_row_cabin, Me.Font, Brushes.Black, distolefe + 5, distotop + board_height + 40 + (big_row_cabin - small_row_cabin + 1 + 1) * 20 - 20 * (i - small_row_cabin + 1) - 20 + 5 + 20) '贝层
            Next
            ''写贝列
            n = big_col_cabin - small_col_cabin + 1
            'bay_row_cabin = 78 + i * 2
            Dim strcon As Integer
            strcon = 1
            Dim strsmallcol As Integer
            strsmallcol = small_col_cabin
            Dim strbigcol As Integer
            strbigcol = big_col_cabin
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                'For j = small_col_cabin To big_col_cabin '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col_cabin + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col_cabin = "0" & k * 2
                        Else
                            bay_col_cabin = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col_cabin = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col_cabin = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col_cabin + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col_cabin = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col_cabin = "0" & k * 2
                            Else
                                bay_col_cabin = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col_cabin = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col_cabin = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_bay_map.DrawString(bay_col_cabin, Me.Font, Brushes.Black, distolefe + col_count * 10 + 20 * (j - strsmallcol + strcon) + 3, distotop + board_height + 40 + (big_row_cabin - small_row_cabin + 1) * 20 + 1 + 20) '贝列
            Next
        End If
        Me.Pl_bay_map.Refresh()
        'bmpgraphics_bay_map.Dispose()
        'pen_line.Dispose()
        'bru_fill.Dispose()
        'pen_cross.Dispose()
    End Sub

    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub

    Private Sub btn_pagesetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pagesetup.Click
        Try
            Me.cmb_defined_bay.Refresh()
            If notshowbaymap = 0 Then
                show_bay_map(bmpgraphics_bay_map)
            End If
            txt_null()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Pl_bay_map_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pl_bay_map.MouseDown
        color1 = bmp_bay_map.GetPixel(e.X, e.Y)
        If color1.ToArgb <> Color.White.ToArgb Then 'color1.ToArgb = Color.Blue.ToArgb Or color1.ToArgb = Color.DarkGray.ToArgb Then
            '计算甲板结果图的顶点位置
            If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '比较甲板和舱内的列数
                col_count_board = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''甲板上列数和舱内的差额
            Else
                col_count_board = 0
            End If
            '计算舱内结果图的顶点位置
            If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                col_count_cabin = (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) ''甲板上列数和舱内的差额
            Else
                col_count_cabin = 0
            End If
            txt_null()
            p.X = e.X
            p.Y = e.Y ' - 10
            recty = p.Y / 20
            recty = Fix(recty) * 20
            If recty < distotop + board_height + 20 + 20 Then
                rectx = (p.X + (col_count_board Mod 2) * 10) / 20
                rectx = Fix(rectx) * 20
                mark = "board" ' distolefe + col_count * 10 + 20 * (j - small_col + 1), distotop + board_height + 20 - 20 * (i - small_row + 1) + 20, 20, 20)
                i_row = Fix((distotop + board_height + 20 + 20 - recty) / 20) + small_row - 1
                j_col = Fix((rectx - distolefe - col_count_board * 10) / 20) + small_col - 1
            Else
                rectx = (p.X + (col_count_cabin Mod 2) * 10) / 20
                rectx = Fix(rectx) * 20
                mark = "cabin" ' distotop + 240 + (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1)
                i_row = Fix(((distotop + board_height + 40 + 20 + (big_row_cabin - small_row_cabin + 1) * 20) - recty) / 20) + small_row_cabin - 1
                j_col = Fix((rectx - distolefe - col_count_cabin * 10) / 20) + small_col_cabin - 1
            End If
            bayno_check = "select bay_num + bay_col + bay_row from con_map where v_id=(select v_id from sship where ship_id='" & Ship_ID & "') and location='" & mark & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'and screen_col='" & j_col & "' and screen_row='" & i_row & "'"
            If Getdata(bayno_check, ds_bayno).Count > 0 Then
                bayno_check = ds_bayno.Tables(0).Rows(0).Item(0)
                ''''''找数据库中是否存在通贝的箱子
                If CType(Mid(bayno_check, 1, 2), Integer) + 1 < 10 Then
                    bayno_check_joint = "0" & Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 5)
                Else
                    bayno_check_joint = Mid(bayno_check, 1, 2) + 1 & Mid(bayno_check, 3, 4)
                End If

                'If Getdata("select con_image.CONTAINER_NO,CODE_LOAD_PORT,CODE_UNLOAD_PORT,CODE_DELIVERY,GROSSWEIGHT,SIZE_CON,CONTAINER_TYPE,sealno,oldbayno,work_no,work_date from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where   ( con_image.BAYNO='" & bayno_check & "'or con_image.BAYNO='" & bayno_check_joint & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%')   and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                If Getdata("select con_image.CONTAINER_NO,CODE_LOAD_PORT,CODE_UNLOAD_PORT,CODE_DELIVERY,GROSSWEIGHT,SIZE_CON,CONTAINER_TYPE,sealno,oldbayno,TALLY_CLERK.NAME,work_date from CON_IMAGE LEFT OUTER JOIN TALLY_CLERK ON CON_IMAGE.WORK_NO = TALLY_CLERK.WORK_NO LEFT OUTER JOIN CON_CRITERION ON CON_IMAGE.CONTAINER_NO = CON_CRITERION.CONTAINER_NO  where   ( con_image.BAYNO='" & bayno_check & "'or con_image.BAYNO='" & bayno_check_joint & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%')   and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                    '装货钢
                    If ds_container.Tables(0).Rows(0).Item("CODE_LOAD_PORT") Is System.DBNull.Value Then
                    Else
                        Me.txt_load.Text = ds_container.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
                    End If
                    '卸货杠
                    If ds_container.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT") Is System.DBNull.Value Then
                    Else
                        Me.txt_unload.Text = ds_container.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
                    End If
                    '目的港
                    If ds_container.Tables(0).Rows(0).Item("CODE_DELIVERY") Is System.DBNull.Value Then
                    Else
                        Me.txt_DELIVERY.Text = ds_container.Tables(0).Rows(0).Item("CODE_DELIVERY")
                    End If
                    '箱号
                    If ds_container.Tables(0).Rows(0).Item("container_no") Is System.DBNull.Value Then
                    Else
                        Me.txt_container_no.Text = ds_container.Tables(0).Rows(0).Item("container_no")
                    End If
                    ''贝位号
                    'Me.txt_bay.Text = bayno_check
                    '尺寸
                    If ds_container.Tables(0).Rows(0).Item("SIZE_CON") Is System.DBNull.Value Then
                    Else
                        Me.txt_size_con.Text = ds_container.Tables(0).Rows(0).Item("SIZE_CON")
                    End If
                    '箱行
                    If ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") Is System.DBNull.Value Then
                    Else
                        Me.txt_CONTAINER_TYPE.Text = ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE")
                    End If
                    '毛箱重
                    If ds_container.Tables(0).Rows(0).Item("GROSSWEIGHT") Is System.DBNull.Value Then
                    Else
                        Me.txt_GROSSWEIGHT.Text = ds_container.Tables(0).Rows(0).Item("GROSSWEIGHT")
                    End If
                    '配载贝位
                    If ds_container.Tables(0).Rows(0).Item("oldbayno") Is System.DBNull.Value Then
                    Else
                        Me.txt_oldbay.Text = ds_container.Tables(0).Rows(0).Item("oldbayno")
                    End If
                    '铅封号
                    If ds_container.Tables(0).Rows(0).Item("sealno") Is System.DBNull.Value Then
                    Else
                        Me.txt_sealno.Text = ds_container.Tables(0).Rows(0).Item("sealno")
                    End If
                    '理货员
                    If ds_container.Tables(0).Rows(0).Item("NAME") Is System.DBNull.Value Then
                    Else
                        Me.txt_work_no.Text = ds_container.Tables(0).Rows(0).Item("NAME")
                    End If
                    '理货时间
                    If ds_container.Tables(0).Rows(0).Item("work_date") Is System.DBNull.Value Then
                    Else
                        Me.txt_work_date.Text = ds_container.Tables(0).Rows(0).Item("work_date")
                    End If
                End If
                '贝位号
                If Getdata("select con_image.CONTAINER_NO,CODE_LOAD_PORT,CODE_UNLOAD_PORT,CODE_DELIVERY,GROSSWEIGHT,SIZE_CON,CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where ( con_image.BAYNO='" & bayno_check & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%')  and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                    '贝位号
                    Me.txt_bay.Text = bayno_check
                Else
                    If Getdata("select con_image.CONTAINER_NO,CODE_LOAD_PORT,CODE_UNLOAD_PORT,CODE_DELIVERY,GROSSWEIGHT,SIZE_CON,CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where (con_image.BAYNO='" & bayno_check_joint & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%')  and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                        '贝位号
                        Me.txt_bay.Text = bayno_check_joint
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txt_null()
        Me.txt_bay.Text = ""
        Me.txt_load.Text = ""
        Me.txt_unload.Text = ""
        Me.txt_DELIVERY.Text = ""
        Me.txt_container_no.Text = ""
        Me.txt_size_con.Text = ""
        Me.txt_CONTAINER_TYPE.Text = ""
        Me.txt_GROSSWEIGHT.Text = ""

        txt_oldbay.Text = ""
        txt_sealno.Text = ""
        txt_work_no.Text = ""
        txt_work_date.Text = ""

    End Sub

    Private Sub fill_rectangle_color()
        '判断卸货港应该用什么样的颜色
        Select Case ds_container.Tables(0).Rows(0).Item("substitute")
            Case "0"
                bru_fill.Color = Color.Blue
            Case "1"
                bru_fill.Color = Color.Red
                'Case substitute(2)
                '    bru_fill.Color = Color.Green
                'Case substitute(3)
                '    bru_fill.Color = Color.Orange
                'Case substitute(4)
                '    bru_fill.Color = Color.Yellow
                'Case substitute(5)
                '    bru_fill.Color = Color.Gold
                'Case substitute(6)
                '    bru_fill.Color = Color.Chocolate
                'Case substitute(7)
                '    bru_fill.Color = Color.Olive
                'Case substitute(8)
                '    bru_fill.Color = Color.Silver
                'Case substitute(9)
                '    bru_fill.Color = Color.Tomato
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Timer1.Stop()
        btn_pagesetup_Click(sender, e)
        Me.Timer1.Start()
    End Sub

    Private Sub Frm_bay_workabout_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub

End Class
