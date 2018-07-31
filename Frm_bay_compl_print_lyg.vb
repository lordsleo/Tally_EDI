Imports TALLY.DBControl
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Math
Imports System.Drawing.Printing
Public Class Frm_bay_compl_print_lyg
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
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
        Me.chklyg.Location = New System.Drawing.Point(120, 16)
        Me.chklyg.Name = "chklyg"
        Me.chklyg.Size = New System.Drawing.Size(90, 24)
        Me.chklyg.TabIndex = 17
        Me.chklyg.Text = "过滤空贝位"
        '
        'btn_all
        '
        Me.btn_all.Location = New System.Drawing.Point(444, 42)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(70, 24)
        Me.btn_all.TabIndex = 16
        Me.btn_all.Text = "全船打印"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(84, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 23)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "%"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_scale_rate
        '
        Me.txt_scale_rate.Location = New System.Drawing.Point(50, 44)
        Me.txt_scale_rate.Name = "txt_scale_rate"
        Me.txt_scale_rate.Size = New System.Drawing.Size(34, 21)
        Me.txt_scale_rate.TabIndex = 14
        Me.txt_scale_rate.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(10, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 23)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "缩放"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_printpreview
        '
        Me.btn_printpreview.Location = New System.Drawing.Point(304, 42)
        Me.btn_printpreview.Name = "btn_printpreview"
        Me.btn_printpreview.Size = New System.Drawing.Size(64, 24)
        Me.btn_printpreview.TabIndex = 12
        Me.btn_printpreview.Text = "打印预揽"
        '
        'btn_pagesetup
        '
        Me.btn_pagesetup.Location = New System.Drawing.Point(230, 42)
        Me.btn_pagesetup.Name = "btn_pagesetup"
        Me.btn_pagesetup.Size = New System.Drawing.Size(64, 24)
        Me.btn_pagesetup.TabIndex = 11
        Me.btn_pagesetup.Text = "页面设置"
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(376, 42)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(64, 24)
        Me.btn_enter.TabIndex = 10
        Me.btn_enter.Text = "单贝打印"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(106, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "BAY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_defined_bay
        '
        Me.cmb_defined_bay.Location = New System.Drawing.Point(152, 44)
        Me.cmb_defined_bay.Name = "cmb_defined_bay"
        Me.cmb_defined_bay.Size = New System.Drawing.Size(68, 20)
        Me.cmb_defined_bay.TabIndex = 7
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(518, 42)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(70, 24)
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
        Me.txt_container_no.Location = New System.Drawing.Point(74, 173)
        Me.txt_container_no.Name = "txt_container_no"
        Me.txt_container_no.TabIndex = 1
        Me.txt_container_no.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "装货港"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "卸货港"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "目的港"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "贝位号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "箱号"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "尺寸"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 417)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "箱重"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(12, 382)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "箱形"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_bay
        '
        Me.txt_bay.Location = New System.Drawing.Point(74, 208)
        Me.txt_bay.Name = "txt_bay"
        Me.txt_bay.TabIndex = 1
        Me.txt_bay.Text = ""
        '
        'txt_load
        '
        Me.txt_load.Location = New System.Drawing.Point(74, 243)
        Me.txt_load.Name = "txt_load"
        Me.txt_load.TabIndex = 1
        Me.txt_load.Text = ""
        '
        'txt_unload
        '
        Me.txt_unload.Location = New System.Drawing.Point(74, 278)
        Me.txt_unload.Name = "txt_unload"
        Me.txt_unload.TabIndex = 1
        Me.txt_unload.Text = ""
        '
        'txt_DELIVERY
        '
        Me.txt_DELIVERY.Location = New System.Drawing.Point(74, 313)
        Me.txt_DELIVERY.Name = "txt_DELIVERY"
        Me.txt_DELIVERY.TabIndex = 1
        Me.txt_DELIVERY.Text = ""
        '
        'txt_size_con
        '
        Me.txt_size_con.Location = New System.Drawing.Point(74, 348)
        Me.txt_size_con.Name = "txt_size_con"
        Me.txt_size_con.TabIndex = 1
        Me.txt_size_con.Text = ""
        '
        'txt_GROSSWEIGHT
        '
        Me.txt_GROSSWEIGHT.Location = New System.Drawing.Point(74, 418)
        Me.txt_GROSSWEIGHT.Name = "txt_GROSSWEIGHT"
        Me.txt_GROSSWEIGHT.TabIndex = 1
        Me.txt_GROSSWEIGHT.Text = ""
        '
        'txt_CONTAINER_TYPE
        '
        Me.txt_CONTAINER_TYPE.Location = New System.Drawing.Point(74, 383)
        Me.txt_CONTAINER_TYPE.Name = "txt_CONTAINER_TYPE"
        Me.txt_CONTAINER_TYPE.TabIndex = 1
        Me.txt_CONTAINER_TYPE.Text = ""
        '
        'Frm_bay_compl_print_lyg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(780, 747)
        Me.Controls.Add(Me.Pl_bay_map)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_bay_compl_print_lyg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "连云港_单贝图"
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

    Private Sub Frm_bay_compl_print_lyg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub show_bay_map(ByVal bmpgraphics_bay_map As Graphics)
        '显示卸货港的首字母代码表示
        txt_unload_port()
        '清空
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
                        If Getdata("select con_image.CONTAINER_NO,con_unload_port_substitute.substitute  from con_image left join con_unload_port_substitute on con_image.ship_id=con_unload_port_substitute.ship_id and right(con_image.code_unload_port,3)=right(con_unload_port_substitute.code_unload_port,3)  where  con_image.BAYNO='" & BAYNO & "'and (con_image.CODE_LOAD_PORT like '%lyg%' or con_image.CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
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
                            If Getdata("select con_image.CONTAINER_NO,con_unload_port_substitute.substitute  from con_image left join con_unload_port_substitute on con_image.ship_id=con_unload_port_substitute.ship_id and right(con_image.code_unload_port,3)=right(con_unload_port_substitute.code_unload_port,3)  where  con_image.BAYNO='" & bayno_joint & "' and (con_image.CODE_LOAD_PORT like '%lyg%' or con_image.CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
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
                        If Getdata("select con_image.CONTAINER_NO,con_unload_port_substitute.substitute  from con_image left join con_unload_port_substitute on con_image.ship_id=con_unload_port_substitute.ship_id and right(con_image.code_unload_port,3)=right(con_unload_port_substitute.code_unload_port,3) where  con_image.BAYNO='" & BAYNO & "'and (con_image.CODE_LOAD_PORT like '%lyg%' or con_image.CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
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
                            If Getdata("select con_image.CONTAINER_NO,con_unload_port_substitute.substitute  from con_image left join con_unload_port_substitute on con_image.ship_id=con_unload_port_substitute.ship_id and right(con_image.code_unload_port,3)=right(con_unload_port_substitute.code_unload_port,3)  where  con_image.BAYNO='" & bayno_joint & "' and (con_image.CODE_LOAD_PORT like '%lyg%' or con_image.CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
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
    End Sub

    Private Sub print_bay_map(ByVal bmpgraphics_bay_map As Graphics)
        '清空
        bmpgraphics_bay_map.Clear(Color.White)
        small_col = 0
        big_col = 0
        distolefe = 0
        distotop = 10
        small_col_cabin = 0
        big_col_cabin = 0
        board_height_print = 0
        row_GROSSWEIGHT = 0 '行毛重值零
        total_GROSSWEIGHT = 0 '总毛重字零
        ''甲板取甲板的列数
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='board' order by id", ds_board).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='board'", ds_board_char)
            small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") '取甲板屏幕的最小行
            big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") '取甲板屏幕的最大行
            small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") '取甲板屏幕的最小列
            big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") '取甲板屏幕的最大列
            board_height_print = (big_row - small_row + 1) * yRect '''=800
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
        bmpgraphics_bay_map.DrawString("COSTACO LIANYUNGANG  连云港外理", Me.Font, Brushes.Black, distolefe + 0, distotop - 10 + topsize)
        '写船名航次
        bmpgraphics_bay_map.DrawString("VESSEL:" & ENG_VESSEL, Me.Font, Brushes.Black, distolefe + 40 + 190, distotop - 10 + topsize)
        bmpgraphics_bay_map.DrawString("VOY:" & VOYAGE, Me.Font, Brushes.Black, distolefe + 40 + 450, distotop - 10 + topsize)
        bmpgraphics_bay_map.DrawString("POL：LYG", Me.Font, Brushes.Black, distolefe + 40 + 600, distotop - 10 + topsize)
        '写BAY
        bmpgraphics_bay_map.DrawString("BAY： " & Me.cmb_defined_bay.Text, bay_f, Brushes.Black, distolefe + 40 + 20 + 750, distotop - 10 + topsize)
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
                row_GROSSWEIGHT = 0 '循环一行
                For j = small_col To big_col
                    If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then
                        '矩形
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * 40 + 80 * (j - small_col + 1) - xChange, distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2), 80, yRect)
                        '贝位号
                        BAYNO = ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
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
                        Else
                            bayno_joint = "000000"  '无通bay
                        End If
                        '判断此贝位号及通贝的贝位号上有无箱号
                        If Getdata("select con_image.CONTAINER_NO,right(CODE_LOAD_PORT,3) CODE_LOAD_PORT,right(CODE_UNLOAD_PORT,3) CODE_UNLOAD_PORT,right(CODE_DELIVERY,3) CODE_DELIVERY ,cast(cast(round(GROSSWEIGHT/1000,2) as numeric(9,2)) as varchar) as GROSSWEIGHT,SIZE_CON,CONTAINER_TYPE,FULLOREMPTY,TEMPERATURE_UNIT,TEMPERATURE_SETTING,MIN_TEMPERATURE,MAX_TEMPERATURE,DANGER_GRADE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where  (con_image.BAYNO='" & BAYNO & "' or con_image.BAYNO='" & bayno_joint & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            '装货钢
                            If ds_container.Tables(0).Rows(0).Item("CODE_LOAD_PORT") Is System.DBNull.Value Then
                            Else
                                bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("CODE_LOAD_PORT"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height_print - yRect * (i - small_row + 1) + 1 + yRect / 2)
                            End If
                            '卸货杠
                            If ds_container.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT") Is System.DBNull.Value Then
                            Else
                                bmpgraphics_bay_map.DrawString("/" & ds_container.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1) + 23, distotop + board_height_print - yRect * (i - small_row + 1) + 1 + yRect / 2)
                            End If
                            '目的港
                            If ds_container.Tables(0).Rows(0).Item("CODE_DELIVERY") Is System.DBNull.Value Then
                            Else
                                bmpgraphics_bay_map.DrawString("/" & ds_container.Tables(0).Rows(0).Item("CODE_DELIVERY"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1) + 49, distotop + board_height_print - yRect * (i - small_row + 1) + 1 + yRect / 2)
                            End If
                            '箱号
                            '处理12位箱号的情况，其中第五位一定是空格
                            If Len(ds_container.Tables(0).Rows(0).Item("container_No")) = 12 Then
                                ds_container.Tables(0).Rows(0).Item("container_No") = Mid(ds_container.Tables(0).Rows(0).Item("container_No"), 1, 4) & Mid(ds_container.Tables(0).Rows(0).Item("container_No"), 6, 7)
                            End If
                            bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("container_No"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height_print - yRect * (i - small_row + 1) + 13 + yRect / 2)
                            '尺寸
                            If ds_container.Tables(0).Rows(0).Item("SIZE_CON") Is System.DBNull.Value Then
                            Else
                                bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("SIZE_CON"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height_print - yRect * (i - small_row + 1) + 25 + yRect / 2)
                            End If
                            '箱行
                            If ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") Is System.DBNull.Value Then
                            Else
                                bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1) + 15, distotop + board_height_print - yRect * (i - small_row + 1) + 25 + yRect / 2)
                            End If
                            '毛箱重
                            If ds_container.Tables(0).Rows(0).Item("GROSSWEIGHT") Is System.DBNull.Value Then
                            Else
                                row_GROSSWEIGHT = row_GROSSWEIGHT + CType(ds_container.Tables(0).Rows(0).Item("GROSSWEIGHT"), Single)
                                bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("GROSSWEIGHT"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1) + 40, distotop + board_height_print - yRect * (i - small_row + 1) + 25 + yRect / 2)
                            End If
                            '空重
                            If ds_container.Tables(0).Rows(0).Item("FULLOREMPTY") Is System.DBNull.Value Then
                            Else
                                bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("FULLOREMPTY"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1) + 30, distotop + board_height_print - yRect * (i - small_row + 1) + 25 + yRect / 2)
                            End If
                            '冷藏箱温度、
                            If ds_container.Tables(0).Rows(0).Item("TEMPERATURE_UNIT") Is System.DBNull.Value Then
                            Else
                                If ds_container.Tables(0).Rows(0).Item("TEMPERATURE_SETTING") Is System.DBNull.Value Then
                                    If ds_container.Tables(0).Rows(0).Item("MIN_TEMPERATURE") Is System.DBNull.Value Then
                                        If ds_container.Tables(0).Rows(0).Item("MAX_TEMPERATURE") Is System.DBNull.Value Then
                                        Else
                                            bmpgraphics_bay_map.DrawString(CType(ds_container.Tables(0).Rows(0).Item("MAX_TEMPERATURE"), Single) & ds_container.Tables(0).Rows(0).Item("TEMPERATURE_UNIT"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1) + 50, distotop + board_height_print - yRect * (i - small_row + 1) + yRect - 16 + yRect / 2)
                                        End If
                                    Else
                                        bmpgraphics_bay_map.DrawString(CType(ds_container.Tables(0).Rows(0).Item("MIN_TEMPERATURE"), Single) & ds_container.Tables(0).Rows(0).Item("TEMPERATURE_UNIT"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1) + 50, distotop + board_height_print - yRect * (i - small_row + 1) + yRect - 16 + yRect / 2)
                                    End If
                                Else
                                    bmpgraphics_bay_map.DrawString(CType(ds_container.Tables(0).Rows(0).Item("TEMPERATURE_SETTING"), Single) & ds_container.Tables(0).Rows(0).Item("TEMPERATURE_UNIT"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1) + 50, distotop + board_height_print - yRect * (i - small_row + 1) + yRect - 16 + yRect / 2)
                                End If
                            End If
                            '危险品等级
                            If ds_container.Tables(0).Rows(0).Item("DANGER_GRADE") Is System.DBNull.Value Then
                            Else
                                If Len(Trim(ds_container.Tables(0).Rows(0).Item("DANGER_GRADE"))) > 0 Then
                                    bmpgraphics_bay_map.DrawString("D" & ds_container.Tables(0).Rows(0).Item("DANGER_GRADE"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1) + 50, distotop + board_height_print - yRect * (i - small_row + 1) + yRect - 16 + yRect / 2)
                                End If
                            End If
                        End If

                        ''写贝位号
                        'If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_LOAD_PORT),1,3) CODE_LOAD_PORT,substring(ltrim(CODE_UNLOAD_PORT),1,3) CODE_UNLOAD_PORT,CODE_DELIVERY,GROSSWEIGHT,SIZE_CON,CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where  (con_image.BAYNO='" & bayno_joint & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%')  and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                        '    bmpgraphics_bay_map.DrawString(bayno_joint, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2) + yRect - 16)
                        'Else
                        '    bmpgraphics_bay_map.DrawString(BAYNO, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2) + yRect - 16)
                        'End If
                        '' bmpgraphics_bay_map.DrawString(BAYNO, f, Brushes.Black, distolefe + col_count * 20 + 40 * (j - small_col + 1), distotop + board_height_print + 40 - 40 * (i - small_row + 1) + 32 + 20)
                        ''放贝位号的矩形
                        'bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2) + yRect - 16, 50, 16)
                        ''贝位号--贝号减一
                        BAYNO_MID = ""
                        If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1 < 10 Then
                            BAYNO_MID = "0" & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1
                            BAYNO_MID = BAYNO_MID & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                        Else
                            BAYNO_MID = ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1
                            BAYNO_MID = BAYNO_MID & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                        End If
                        '判断此贝位号有无箱号
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

                            If Len(Trim(BAYNO_MID)) > 0 Then
                                If Getdata("select substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT,FULLOREMPTY,substring(ltrim(CONTAINER_TYPE),1,1) CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where  con_image.BAYNO='" & BAYNO_MID & "' and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%')  and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                    bmpgraphics_bay_map.DrawLine(pen_cross, distolefe + col_count * 40 + 80 * (j - small_col + 1) - xChange + 1, distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2) + 1, distolefe + col_count * 40 + 80 * (j - small_col + 1) - xChange + 80 - 1, distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2) + yRect - 1)
                                    bmpgraphics_bay_map.DrawLine(pen_cross, distolefe + col_count * 40 + 80 * (j - small_col + 1) - xChange + 1, distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2) + yRect - 1, distolefe + col_count * 40 + 80 * (j - small_col + 1) - xChange + 80 - 1, distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2) + 1)
                                Else
                                    '写贝位号
                                    If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_LOAD_PORT),1,3) CODE_LOAD_PORT,substring(ltrim(CODE_UNLOAD_PORT),1,3) CODE_UNLOAD_PORT,CODE_DELIVERY,GROSSWEIGHT,SIZE_CON,CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where  (con_image.BAYNO='" & bayno_joint & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%')  and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                        bmpgraphics_bay_map.DrawString(bayno_joint, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2) + yRect - 16)
                                    Else
                                        bmpgraphics_bay_map.DrawString(BAYNO, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2) + yRect - 16)
                                    End If
                                    ' bmpgraphics_bay_map.DrawString(BAYNO, f, Brushes.Black, distolefe + col_count * 20 + 40 * (j - small_col + 1), distotop + board_height_print + 40 - 40 * (i - small_row + 1) + 32 + 20)
                                    '放贝位号的矩形
                                    bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2) + yRect - 16, 50, 16)
                                End If
                            End If
                        Else
                            '写贝位号
                            If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_LOAD_PORT),1,3) CODE_LOAD_PORT,substring(ltrim(CODE_UNLOAD_PORT),1,3) CODE_UNLOAD_PORT,CODE_DELIVERY,GROSSWEIGHT,SIZE_CON,CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where  (con_image.BAYNO='" & bayno_joint & "')  and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%')  and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                bmpgraphics_bay_map.DrawString(bayno_joint, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2) + yRect - 16)
                            Else
                                bmpgraphics_bay_map.DrawString(BAYNO, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2) + yRect - 16)
                            End If
                            ' bmpgraphics_bay_map.DrawString(BAYNO, f, Brushes.Black, distolefe + col_count * 20 + 40 * (j - small_col + 1), distotop + board_height_print + 40 - 40 * (i - small_row + 1) + 32 + 20)
                            '放贝位号的矩形
                            bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height_print - yRect * (i - small_row + 1) + CInt(yRect / 2) + yRect - 16, 50, 16)
                        End If
                    End If
                Next
                '写甲板行毛重总计
                If row_GROSSWEIGHT > 0 Then
                    '计算甲板贝的总毛重
                    total_GROSSWEIGHT = total_GROSSWEIGHT + row_GROSSWEIGHT
                    '使毛重保留两位小数
                    row_GROSSWEIGHT = Round(row_GROSSWEIGHT, 2)
                    If InStr(1, CType(row_GROSSWEIGHT, String), ".") = 0 Then
                        row_GROSSWEIGHT_str = CType(row_GROSSWEIGHT, String) & ".00"
                    ElseIf InStr(1, CType(row_GROSSWEIGHT, String), ".") + 1 = Len(CType(row_GROSSWEIGHT, String)) Then
                        row_GROSSWEIGHT_str = CType(row_GROSSWEIGHT, String) & "0"
                    Else
                        row_GROSSWEIGHT_str = CType(row_GROSSWEIGHT, String)
                    End If
                    If (big_col - small_col) - (big_col_cabin - small_col_cabin) >= 0 Then
                        '甲板列数多
                        bmpgraphics_bay_map.DrawString(row_GROSSWEIGHT_str, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (big_col - small_col + 1) + 40 + 40 + 4, distotop + board_height_print - yRect * (i - small_row + 1) + yRect)
                    Else
                        '舱内列数多
                        bmpgraphics_bay_map.DrawString(row_GROSSWEIGHT_str, f_container, Brushes.Black, distolefe - xChange + 80 * (big_col_cabin - small_col_cabin + 1) + 40 + 40 + 4, distotop + board_height_print - yRect * (i - small_row + 1) + yRect)
                    End If

                End If
            Next
            '写贝的总毛重
            ' bmpgraphics_bay_map.DrawString(row_GROSSWEIGHT, f_container, Brushes.Black, distolefe + col_count * 20 + 40 * (big_col - small_col + 1) + 20 + 30, distotop + board_height_print + 40 - 40 * (big_row - small_row + 1) + 20 + 20 + 20)
            '画贝层
            For i = small_row To big_row '战位最大屏列,按行读，行坐标先变
                bay_row = 78 + i * 2
                bmpgraphics_bay_map.DrawString(bay_row, Me.Font, Brushes.Black, distolefe + 10, distotop + board_height_print - yRect * (i - small_row + 1) + yRect) '贝层
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
                bmpgraphics_bay_map.DrawString(bay_col, Me.Font, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - strsmallcol + strcon) + 30, distotop + board_height_print + 15 - (big_row - small_row + 1) * yRect)   '贝列
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
                row_GROSSWEIGHT = 0 '循环一行
                For j = small_col_cabin To big_col_cabin
                    If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("user_char") = 1 Then
                        '矩形
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2), 80, yRect)
                        '贝位号
                        BAYNO = ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
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
                        Else
                            bayno_joint = "000000"
                        End If
                        '判断此贝位号有无箱号
                        If Getdata("select con_image.CONTAINER_NO,right(CODE_LOAD_PORT,3) CODE_LOAD_PORT,right(CODE_UNLOAD_PORT,3) CODE_UNLOAD_PORT,right(CODE_DELIVERY,3) CODE_DELIVERY ,cast(cast(round(GROSSWEIGHT/1000,2) as numeric(9,2)) as varchar) as GROSSWEIGHT,SIZE_CON,CONTAINER_TYPE,FULLOREMPTY,TEMPERATURE_UNIT,TEMPERATURE_SETTING,MIN_TEMPERATURE,MAX_TEMPERATURE,DANGER_GRADE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where  ( con_image.BAYNO='" & BAYNO & "' or con_image.BAYNO='" & bayno_joint & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                            '装货钢
                            If ds_container.Tables(0).Rows(0).Item("CODE_LOAD_PORT") Is System.DBNull.Value Then
                            Else
                                bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("CODE_LOAD_PORT"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + 1)
                            End If
                            '卸货杠
                            If ds_container.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT") Is System.DBNull.Value Then
                            Else
                                bmpgraphics_bay_map.DrawString("/" & ds_container.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1) + 23, distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + 1)
                            End If
                            '目的港
                            If ds_container.Tables(0).Rows(0).Item("CODE_DELIVERY") Is System.DBNull.Value Then
                            Else
                                bmpgraphics_bay_map.DrawString("/" & ds_container.Tables(0).Rows(0).Item("CODE_DELIVERY"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1) + 49, distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + 1)
                            End If
                            '箱号
                            If ds_container.Tables(0).Rows(0).Item("container_no") Is System.DBNull.Value Then
                            Else
                                '处理12位箱号的情况，其中第五位一定是空格
                                If Len(ds_container.Tables(0).Rows(0).Item("container_No")) = 12 Then
                                    ds_container.Tables(0).Rows(0).Item("container_No") = Mid(ds_container.Tables(0).Rows(0).Item("container_No"), 1, 4) & Mid(ds_container.Tables(0).Rows(0).Item("container_No"), 6, 7)
                                End If
                                bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("container_no"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + 13)
                            End If
                            '尺寸
                            If ds_container.Tables(0).Rows(0).Item("SIZE_CON") Is System.DBNull.Value Then
                            Else
                                bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("SIZE_CON"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + 25)
                            End If
                            '箱行
                            If ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") Is System.DBNull.Value Then
                            Else
                                bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1) + 15, distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + 25)
                            End If
                            '毛箱重
                            If ds_container.Tables(0).Rows(0).Item("GROSSWEIGHT") Is System.DBNull.Value Then
                            Else
                                row_GROSSWEIGHT = row_GROSSWEIGHT + CType(ds_container.Tables(0).Rows(0).Item("GROSSWEIGHT"), Single)
                                bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("GROSSWEIGHT"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1) + 40, distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + 25)
                            End If
                            '空重
                            If ds_container.Tables(0).Rows(0).Item("FULLOREMPTY") Is System.DBNull.Value Then
                            Else
                                bmpgraphics_bay_map.DrawString(ds_container.Tables(0).Rows(0).Item("FULLOREMPTY"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1) + 30, distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + 25)
                            End If
                            '冷藏箱温度、
                            If ds_container.Tables(0).Rows(0).Item("TEMPERATURE_UNIT") Is System.DBNull.Value Then
                            Else
                                If ds_container.Tables(0).Rows(0).Item("TEMPERATURE_SETTING") Is System.DBNull.Value Then
                                    If ds_container.Tables(0).Rows(0).Item("MIN_TEMPERATURE") Is System.DBNull.Value Then
                                        If ds_container.Tables(0).Rows(0).Item("MAX_TEMPERATURE") Is System.DBNull.Value Then
                                        Else
                                            bmpgraphics_bay_map.DrawString(CType(ds_container.Tables(0).Rows(0).Item("MAX_TEMPERATURE"), Single) & ds_container.Tables(0).Rows(0).Item("TEMPERATURE_UNIT"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1) + 50, distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16)
                                        End If
                                    Else
                                        bmpgraphics_bay_map.DrawString(CType(ds_container.Tables(0).Rows(0).Item("MIN_TEMPERATURE"), Single) & ds_container.Tables(0).Rows(0).Item("TEMPERATURE_UNIT"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1) + 50, distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16)
                                    End If
                                Else
                                    bmpgraphics_bay_map.DrawString(CType(ds_container.Tables(0).Rows(0).Item("TEMPERATURE_SETTING"), Single) & ds_container.Tables(0).Rows(0).Item("TEMPERATURE_UNIT"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1) + 50, distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16)
                                End If
                            End If
                            '危险品等级
                            If ds_container.Tables(0).Rows(0).Item("DANGER_GRADE") Is System.DBNull.Value Then
                            Else
                                If Len(Trim(ds_container.Tables(0).Rows(0).Item("DANGER_GRADE"))) > 0 Then
                                    bmpgraphics_bay_map.DrawString("D" & ds_container.Tables(0).Rows(0).Item("DANGER_GRADE"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1) + 50, distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16)
                                End If
                            End If
                        End If
                        ''写贝位号
                        'If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_LOAD_PORT),1,3) CODE_LOAD_PORT,substring(ltrim(CODE_UNLOAD_PORT),1,3) CODE_UNLOAD_PORT,CODE_DELIVERY,GROSSWEIGHT,SIZE_CON,CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where ( con_image.BAYNO='" & bayno_joint & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%')  and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                        '    bmpgraphics_bay_map.DrawString(bayno_joint, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16)
                        'Else
                        '    bmpgraphics_bay_map.DrawString(BAYNO, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16)
                        'End If
                        ''  bmpgraphics_bay_map.DrawString(BAYNO, f, Brushes.Black, distolefe + col_count * 20 + 40 * (j - small_col_cabin + 1), distotop + board_height_print + 80 + (big_row_cabin - small_row_cabin + 1) * 40 - 40 * (i - small_row_cabin + 1) + 32 + 20)
                        ''包含贝位号的举行
                        'bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16, 50, 16)
                        ''贝位号--贝号减一
                        If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1 < 10 Then
                            BAYNO_MID = "0" & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1
                            BAYNO_MID = BAYNO_MID & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                        Else
                            BAYNO_MID = ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1
                            BAYNO_MID = BAYNO_MID & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                        End If
                        '判断此贝位号有无箱号
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

                            If Getdata("select substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT,FULLOREMPTY,substring(ltrim(CONTAINER_TYPE),1,1) CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where  con_image.BAYNO='" & BAYNO_MID & "' and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%')   and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                '画差
                                bmpgraphics_bay_map.DrawLine(pen_cross, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1) + 1, distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + 1, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1) + 80 - 1, distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 1)
                                bmpgraphics_bay_map.DrawLine(pen_cross, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1) + 1, distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 1, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1) + 80 - 1, distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + 1)
                            Else
                                '写贝位号
                                If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_LOAD_PORT),1,3) CODE_LOAD_PORT,substring(ltrim(CODE_UNLOAD_PORT),1,3) CODE_UNLOAD_PORT,CODE_DELIVERY,GROSSWEIGHT,SIZE_CON,CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where ( con_image.BAYNO='" & bayno_joint & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%')  and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                    bmpgraphics_bay_map.DrawString(bayno_joint, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16)
                                Else
                                    bmpgraphics_bay_map.DrawString(BAYNO, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16)
                                End If
                                '  bmpgraphics_bay_map.DrawString(BAYNO, f, Brushes.Black, distolefe + col_count * 20 + 40 * (j - small_col_cabin + 1), distotop + board_height_print + 80 + (big_row_cabin - small_row_cabin + 1) * 40 - 40 * (i - small_row_cabin + 1) + 32 + 20)
                                '包含贝位号的举行
                                bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16, 50, 16)
                            End If
                        Else
                            '写贝位号
                            If Getdata("select con_image.CONTAINER_NO,substring(ltrim(CODE_LOAD_PORT),1,3) CODE_LOAD_PORT,substring(ltrim(CODE_UNLOAD_PORT),1,3) CODE_UNLOAD_PORT,CODE_DELIVERY,GROSSWEIGHT,SIZE_CON,CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where ( con_image.BAYNO='" & bayno_joint & "')  and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%')  and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                bmpgraphics_bay_map.DrawString(bayno_joint, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16)
                            Else
                                bmpgraphics_bay_map.DrawString(BAYNO, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16)
                            End If
                            '  bmpgraphics_bay_map.DrawString(BAYNO, f, Brushes.Black, distolefe + col_count * 20 + 40 * (j - small_col_cabin + 1), distotop + board_height_print + 80 + (big_row_cabin - small_row_cabin + 1) * 40 - 40 * (i - small_row_cabin + 1) + 32 + 20)
                            '包含贝位号的举行
                            bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height_print + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16, 50, 16)

                        End If
                    End If
                Next
                '写舱内行毛重总计
                If row_GROSSWEIGHT > 0 Then
                    '计算甲板贝的总毛重
                    total_GROSSWEIGHT = total_GROSSWEIGHT + row_GROSSWEIGHT
                    '使毛重保留两位小数
                    row_GROSSWEIGHT = Round(row_GROSSWEIGHT, 2)
                    If InStr(1, CType(row_GROSSWEIGHT, String), ".") = 0 Then
                        row_GROSSWEIGHT_str = CType(row_GROSSWEIGHT, String) & ".00"
                    ElseIf InStr(1, CType(row_GROSSWEIGHT, String), ".") + 1 = Len(CType(row_GROSSWEIGHT, String)) Then
                        row_GROSSWEIGHT_str = CType(row_GROSSWEIGHT, String) & "0"
                    Else
                        row_GROSSWEIGHT_str = CType(Round(row_GROSSWEIGHT, 2), String)
                    End If
                    If (big_col - small_col) - (big_col_cabin - small_col_cabin) >= 0 Then
                        '甲板列数多
                        bmpgraphics_bay_map.DrawString(row_GROSSWEIGHT_str, f_container, Brushes.Black, distolefe - xChange + 80 * (big_col - small_col + 1) + 40 + 40 + 4, distotop + board_height_print + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + yRect + 20)
                    Else
                        '舱内列数多
                        bmpgraphics_bay_map.DrawString(row_GROSSWEIGHT_str, f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (big_col_cabin - small_col_cabin + 1) + 40 + 40 + 4, distotop + board_height_print + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + yRect + 20)
                    End If

                End If
            Next
            '画贝层
            For i = small_row_cabin To big_row_cabin '战位最大屏列,按行读，行坐标先变
                If i * 2 < 10 Then
                    bay_row_cabin = "0" & i * 2
                Else
                    bay_row_cabin = i * 2
                End If
                bmpgraphics_bay_map.DrawString(bay_row_cabin, Me.Font, Brushes.Black, distolefe + 10, distotop + board_height_print + (big_row_cabin - small_row_cabin + 1 + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) - 10) '贝层
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
                bmpgraphics_bay_map.DrawString(bay_col_cabin, Me.Font, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - strsmallcol + strcon) + 30, distotop + board_height_print + yRect + (big_row_cabin - small_row_cabin + 1) * yRect - 8) '贝列
            Next
        End If
        '写贝的总毛重
        If total_GROSSWEIGHT > 0 Then
            total_GROSSWEIGHT = Round(total_GROSSWEIGHT, 2)
            '使毛重保留两位小数
            If InStr(1, CType(total_GROSSWEIGHT, String), ".") = 0 Then
                total_GROSSWEIGHT_str = "Total:" & CType(total_GROSSWEIGHT, String) & ".00"
            ElseIf InStr(1, CType(total_GROSSWEIGHT, String), ".") + 1 = Len(CType(total_GROSSWEIGHT, String)) Then
                total_GROSSWEIGHT_str = "Total:" & CType(total_GROSSWEIGHT, String) & "0"
            Else
                total_GROSSWEIGHT_str = "Total:" & CType(total_GROSSWEIGHT, String)
            End If
            If (big_col - small_col) - (big_col_cabin - small_col_cabin) >= 0 Then
                '甲板列数多
                bmpgraphics_bay_map.DrawString(total_GROSSWEIGHT_str, f_container, Brushes.Black, distolefe - xChange + 80 * (big_col - small_col + 1) + 40 + 10, distotop + board_height_print + yRect * (big_row_cabin - small_row_cabin + 1) + yRect - 8)
            Else
                '舱内列数多
                bmpgraphics_bay_map.DrawString(total_GROSSWEIGHT_str, f_container, Brushes.Black, distolefe - xChange + 80 * (big_col_cabin - small_col_cabin + 1) + 40 + 10, distotop + board_height_print + (big_row_cabin - small_row_cabin + 1) * yRect + yRect - 8)
            End If
        End If
        '画贝层
        Me.Pl_bay_map.Refresh()
    End Sub

    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        Try
            Dim pd As New PrintDocument
            'pd.DefaultPageSettings.Landscape = True
            AddHandler pd.PrintPage, AddressOf printpageeventhandler
            ' pd.printpage=pd.printpage+new PrintPageEventHandler(me.printpageeventhandler);
            If (Me.storedpagesettings Is System.DBNull.Value) = False Then
                pd.DefaultPageSettings = Me.storedpagesettings
            End If
            pd.DefaultPageSettings.Landscape = True
            'Dim dlg As New PrintDialog()
            'dlg.Document = pd
            'dlg.AllowSelection = True
            'dlg.AllowSomePages = True
            'Dim result As DialogResult
            'result = dlg.ShowDialog
            'If (result = DialogResult.OK) Then
            '    pd.Print()

            'End If
            If (ptdlg Is Nothing) Then '第一次打印
                ptdlg = New PrintDialog
                ptdlg.Document = pd
                ptdlg.AllowSelection = True
                ptdlg.AllowSomePages = True
                Dim result As DialogResult
                result = ptdlg.ShowDialog
                If (result = DialogResult.OK) Then
                    pd.Print()

                End If
            Else
                '非第一次打印
                pd.Print()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub printpageeventhandler(ByVal obj As System.Object, ByVal ev As PrintPageEventArgs)
        Dim g As Graphics
        g = ev.Graphics
        '   show_bay_map(g)

        If Len(Trim(Me.txt_scale_rate.Text)) > 0 Then
            Try
                Dim expandPercent As Single = CType(Me.txt_scale_rate.Text, Integer) / 100
                g.ScaleTransform(expandPercent, expandPercent)
            Catch
                MsgBox("请在缩放比例中输入数字！", MsgBoxStyle.OKOnly, "提示")
                Exit Sub
            End Try
        End If
        ' g.ScaleTransform(0.8, 0.8)
        print_bay_map(g)
        ev.HasMorePages = False

    End Sub

    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub

    Private Sub btn_pagesetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pagesetup.Click
        Try

            Dim psdlg As New PageSetupDialog

            psdlg.AllowMargins = False
            psdlg.AllowOrientation = False
            ' If Me.storedpagesettings Is System.DBNull.Value Then
            Me.storedpagesettings = New PageSettings
            '   End If
            psdlg.PageSettings = Me.storedpagesettings
            psdlg.PageSettings.Landscape = True
            psdlg.ShowDialog()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_printpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_printpreview.Click
        Try
            Dim pd As New PrintDocument
            'pd.DefaultPageSettings.Landscape = True
            AddHandler pd.PrintPage, AddressOf printpageeventhandler
            If (Me.storedpagesettings Is System.DBNull.Value) = False Then
                pd.DefaultPageSettings = Me.storedpagesettings
            End If
            pd.DefaultPageSettings.Landscape = True
            Dim dlg As New PrintPreviewDialog
            dlg.Document = pd
            dlg.ShowDialog()
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

                If Getdata("select con_image.CONTAINER_NO,CODE_LOAD_PORT,CODE_UNLOAD_PORT,CODE_DELIVERY,GROSSWEIGHT,SIZE_CON,CONTAINER_TYPE from con_image left outer join CON_CRITERION on con_image.container_No=CON_CRITERION.container_No  where   ( con_image.BAYNO='" & bayno_check & "'or con_image.BAYNO='" & bayno_check_joint & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%')   and con_image.ship_id=" & Ship_ID, ds_container).Count > 0 Then
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
    End Sub

    Private Sub txt_unload_port()
        '显示卸货港的首字母代码表示
        Me.txt_port1.Visible = False
        Me.txt_port2.Visible = False
        Me.txt_port3.Visible = False
        Me.txt_port4.Visible = False
        Me.txt_port5.Visible = False
        Me.txt_port6.Visible = False
        Me.txt_port7.Visible = False
        Me.txt_port8.Visible = False
        Me.txt_port9.Visible = False
        Me.txt_port10.Visible = False
        '清空卸货港数组
        Dim i As Integer
        For i = 0 To 9
            substitute(i) = ""
        Next
        Dim definedBay As String
        Dim definedBayAdd As String
        Dim portCount As Integer = 0
        definedBay = LTrim(RTrim(Me.cmb_defined_bay.Text))
        If definedBay + 1 < 10 Then
            definedBayAdd = "0" & definedBay + 1
        Else
            definedBayAdd = definedBay + 1
        End If
        If Getdata("select distinct con_image.code_unload_port,con_unload_port_substitute.substitute from con_image,con_unload_port_substitute where (con_image.BAYNO like '" & definedBay & "%' or con_image.BAYNO like '" & definedBayAdd & "%') and (con_image.CODE_LOAD_PORT like '%lyg%' or con_image.CODE_UNLOAD_PORT like '%lyg%') and con_unload_port_substitute.ship_id=con_image.ship_id and right(con_unload_port_substitute .code_unload_port,3)=right(con_image.code_unload_port,3) and  con_image.ship_id=" & Ship_ID, ds_unload_port).Count > 0 Then
            For portCount = 1 To ds_unload_port.Tables(0).Rows.Count
                Select Case portCount
                    Case 1
                        Me.txt_port1.Visible = True
                        Me.txt_port1.Text = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute") & " : " & ds_unload_port.Tables(0).Rows(portCount - 1).Item("code_unload_port")
                        '记下这个卸货港代码
                        substitute(portCount - 1) = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute")
                    Case 2
                        Me.txt_port2.Visible = True
                        Me.txt_port2.Text = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute") & " : " & ds_unload_port.Tables(0).Rows(portCount - 1).Item("code_unload_port")
                        '记下这个卸货港代码
                        substitute(portCount - 1) = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute")
                    Case 3
                        Me.txt_port3.Visible = True
                        Me.txt_port3.Text = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute") & " : " & ds_unload_port.Tables(0).Rows(portCount - 1).Item("code_unload_port")
                        '记下这个卸货港代码
                        substitute(portCount - 1) = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute")
                    Case 4
                        Me.txt_port4.Visible = True
                        Me.txt_port4.Text = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute") & " : " & ds_unload_port.Tables(0).Rows(portCount - 1).Item("code_unload_port")
                        '记下这个卸货港代码
                        substitute(portCount - 1) = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute")
                    Case 5
                        Me.txt_port5.Visible = True
                        Me.txt_port5.Text = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute") & " : " & ds_unload_port.Tables(0).Rows(portCount - 1).Item("code_unload_port")
                        '记下这个卸货港代码
                        substitute(portCount - 1) = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute")
                    Case 6
                        Me.txt_port6.Visible = True
                        Me.txt_port6.Text = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute") & " : " & ds_unload_port.Tables(0).Rows(portCount - 1).Item("code_unload_port")
                        '记下这个卸货港代码
                        substitute(portCount - 1) = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute")
                    Case 7
                        Me.txt_port7.Visible = True
                        Me.txt_port7.Text = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute") & " : " & ds_unload_port.Tables(0).Rows(portCount - 1).Item("code_unload_port")
                        '记下这个卸货港代码
                        substitute(portCount - 1) = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute")
                    Case 8
                        Me.txt_port8.Visible = True
                        Me.txt_port8.Text = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute") & " : " & ds_unload_port.Tables(0).Rows(portCount - 1).Item("code_unload_port")
                        '记下这个卸货港代码
                        substitute(portCount - 1) = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute")
                    Case 9
                        Me.txt_port9.Visible = True
                        Me.txt_port9.Text = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute") & " : " & ds_unload_port.Tables(0).Rows(portCount - 1).Item("code_unload_port")
                        '记下这个卸货港代码
                        substitute(portCount - 1) = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute")
                    Case 10
                        Me.txt_port10.Visible = True
                        Me.txt_port10.Text = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute") & " : " & ds_unload_port.Tables(0).Rows(portCount - 1).Item("code_unload_port")
                        '记下这个卸货港代码
                        substitute(portCount - 1) = ds_unload_port.Tables(0).Rows(portCount - 1).Item("substitute")
                End Select
            Next
        End If

    End Sub

    Private Sub fill_rectangle_color()
        '判断卸货港应该用什么样的颜色
        Select Case ds_container.Tables(0).Rows(0).Item("substitute")
            Case substitute(0)
                bru_fill.Color = Color.Blue
            Case substitute(1)
                bru_fill.Color = Color.Red
            Case substitute(2)
                bru_fill.Color = Color.Green
            Case substitute(3)
                bru_fill.Color = Color.Orange
            Case substitute(4)
                bru_fill.Color = Color.Yellow
            Case substitute(5)
                bru_fill.Color = Color.Gold
            Case substitute(6)
                bru_fill.Color = Color.Chocolate
            Case substitute(7)
                bru_fill.Color = Color.Olive
            Case substitute(8)
                bru_fill.Color = Color.Silver
            Case substitute(9)
                bru_fill.Color = Color.Tomato
        End Select
    End Sub

    Private Sub btn_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_all.Click
        Try
            notshowbaymap = 1
            MsgBox("打印已准备!  共打印:" & cmb_defined_bay.Items.Count & " 页")
            Dim i As Integer
            For i = 0 To cmb_defined_bay.Items.Count - 1
                cmb_defined_bay.Text = cmb_defined_bay.Items(i).ToString()
                cmb_defined_bay.Refresh()

                Dim pd As New PrintDocument
                'pd.DefaultPageSettings.Landscape = True
                AddHandler pd.PrintPage, AddressOf printpageeventhandler
                ' pd.printpage=pd.printpage+new PrintPageEventHandler(me.printpageeventhandler);
                If (Me.storedpagesettings Is System.DBNull.Value) = False Then
                    pd.DefaultPageSettings = Me.storedpagesettings
                End If
                pd.DefaultPageSettings.Landscape = True
                'Dim dlg As New PrintDialog()
                'dlg.Document = pd
                'dlg.AllowSelection = True
                'dlg.AllowSomePages = True
                'Dim result As DialogResult
                'result = dlg.ShowDialog
                'If (result = DialogResult.OK) Then
                '    pd.Print()
                'End If
                If (ptdlg Is Nothing) Then '第一次打印
                    ptdlg = New PrintDialog
                    ptdlg.Document = pd
                    ptdlg.AllowSelection = True
                    ptdlg.AllowSomePages = True
                    Dim result As DialogResult
                    result = ptdlg.ShowDialog
                    If (result = DialogResult.OK) Then
                        pd.Print()
                    End If
                Else
                    '非第一次打印
                    pd.Print()
                End If
            Next
            notshowbaymap = 0
            MsgBox("打印已完成,谢谢使用!  共打印:" & i & "个贝 最高贝为:" & cmb_defined_bay.Text)
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
