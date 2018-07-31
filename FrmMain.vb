Imports TALLY.DBControl
Public Class FrmMain
    Inherits System.Windows.Forms.Form
    Dim Menuitem(150) As Menuitem
    Dim ds As New DataSet
    Dim dv As DataView
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBJJ As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Dim sqlstr As String

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
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents stb As System.Windows.Forms.StatusBar
    Friend WithEvents StBDep As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StB_Department As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stbUser As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StB_User As System.Windows.Forms.StatusBarPanel
    Friend WithEvents STBT As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StB_Time As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem154 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem155 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem156 As System.Windows.Forms.MenuItem
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents WL1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL2_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL2_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_6 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_7 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_8 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_9 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents WL1_12 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_13 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_14 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_15 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_16 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_17 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_18 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_19 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_21 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_22 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_23 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_24 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_30 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_5 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_6 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_7 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_8 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_9 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_10 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_1_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_1_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_11 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_12 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_13 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_14 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_15 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_16 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_15 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11_2 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11_3 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11_4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11_5 As System.Windows.Forms.MenuItem
    Friend WithEvents WL12 As System.Windows.Forms.MenuItem
    Friend WithEvents WL12_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL12_2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_1_3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11_6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents WL4_1_4 As System.Windows.Forms.MenuItem
    Friend WithEvents WL11_7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents TTBBillPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBBill As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBInvoice As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBS1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBSeal As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBS2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBPassWord As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBLogoff As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents WL2_4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents WL8_6 As System.Windows.Forms.MenuItem
    Friend WithEvents WL2_6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents WL8_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL10_22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents TTBgz As System.Windows.Forms.ToolBarButton
    Friend WithEvents TTBInout As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_1 As System.Windows.Forms.MenuItem
    Friend WithEvents WL1_28 As System.Windows.Forms.MenuItem
    Friend WithEvents WL2_9 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.WL1 = New System.Windows.Forms.MenuItem
        Me.WL1_1 = New System.Windows.Forms.MenuItem
        Me.WL1_28 = New System.Windows.Forms.MenuItem
        Me.WL1_26 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.WL1_7 = New System.Windows.Forms.MenuItem
        Me.WL1_8 = New System.Windows.Forms.MenuItem
        Me.WL1_3 = New System.Windows.Forms.MenuItem
        Me.WL1_9 = New System.Windows.Forms.MenuItem
        Me.WL1_30 = New System.Windows.Forms.MenuItem
        Me.WL1_11 = New System.Windows.Forms.MenuItem
        Me.MenuItem152 = New System.Windows.Forms.MenuItem
        Me.WL1_6 = New System.Windows.Forms.MenuItem
        Me.WL1_24 = New System.Windows.Forms.MenuItem
        Me.WL1_22 = New System.Windows.Forms.MenuItem
        Me.WL1_23 = New System.Windows.Forms.MenuItem
        Me.WL1_13 = New System.Windows.Forms.MenuItem
        Me.WL1_14 = New System.Windows.Forms.MenuItem
        Me.WL1_15 = New System.Windows.Forms.MenuItem
        Me.MenuItem154 = New System.Windows.Forms.MenuItem
        Me.WL1_16 = New System.Windows.Forms.MenuItem
        Me.WL1_17 = New System.Windows.Forms.MenuItem
        Me.WL1_18 = New System.Windows.Forms.MenuItem
        Me.WL1_19 = New System.Windows.Forms.MenuItem
        Me.WL1_21 = New System.Windows.Forms.MenuItem
        Me.WL1_12 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.WL2 = New System.Windows.Forms.MenuItem
        Me.WL2_6 = New System.Windows.Forms.MenuItem
        Me.WL2_4 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.WL2_1 = New System.Windows.Forms.MenuItem
        Me.WL2_2 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.WL2_9 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.WL4 = New System.Windows.Forms.MenuItem
        Me.WL4_2 = New System.Windows.Forms.MenuItem
        Me.WL4_1 = New System.Windows.Forms.MenuItem
        Me.WL4_1_1 = New System.Windows.Forms.MenuItem
        Me.WL4_1_2 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.WL4_1_3 = New System.Windows.Forms.MenuItem
        Me.WL4_1_4 = New System.Windows.Forms.MenuItem
        Me.WL4_3 = New System.Windows.Forms.MenuItem
        Me.WL4_4 = New System.Windows.Forms.MenuItem
        Me.WL4_5 = New System.Windows.Forms.MenuItem
        Me.MenuItem156 = New System.Windows.Forms.MenuItem
        Me.WL4_6 = New System.Windows.Forms.MenuItem
        Me.WL4_7 = New System.Windows.Forms.MenuItem
        Me.WL4_8 = New System.Windows.Forms.MenuItem
        Me.WL4_10 = New System.Windows.Forms.MenuItem
        Me.WL4_11 = New System.Windows.Forms.MenuItem
        Me.MenuItem155 = New System.Windows.Forms.MenuItem
        Me.WL4_12 = New System.Windows.Forms.MenuItem
        Me.WL4_9 = New System.Windows.Forms.MenuItem
        Me.WL4_13 = New System.Windows.Forms.MenuItem
        Me.WL4_14 = New System.Windows.Forms.MenuItem
        Me.WL4_15 = New System.Windows.Forms.MenuItem
        Me.WL4_16 = New System.Windows.Forms.MenuItem
        Me.WL10 = New System.Windows.Forms.MenuItem
        Me.WL8_1 = New System.Windows.Forms.MenuItem
        Me.WL10_22 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.WL8_6 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.WL10_15 = New System.Windows.Forms.MenuItem
        Me.WL11 = New System.Windows.Forms.MenuItem
        Me.WL11_1 = New System.Windows.Forms.MenuItem
        Me.WL11_2 = New System.Windows.Forms.MenuItem
        Me.WL11_3 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.WL11_6 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.WL11_4 = New System.Windows.Forms.MenuItem
        Me.WL11_5 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.WL11_7 = New System.Windows.Forms.MenuItem
        Me.WL12 = New System.Windows.Forms.MenuItem
        Me.WL12_1 = New System.Windows.Forms.MenuItem
        Me.WL12_2 = New System.Windows.Forms.MenuItem
        Me.stb = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StBDep = New System.Windows.Forms.StatusBarPanel
        Me.StB_Department = New System.Windows.Forms.StatusBarPanel
        Me.stbUser = New System.Windows.Forms.StatusBarPanel
        Me.StB_User = New System.Windows.Forms.StatusBarPanel
        Me.STBT = New System.Windows.Forms.StatusBarPanel
        Me.StB_Time = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.TTBBillPrint = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.TTBBill = New System.Windows.Forms.ToolBarButton
        Me.TTBInvoice = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton
        Me.TTBS1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.TTBSeal = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton
        Me.TTBInout = New System.Windows.Forms.ToolBarButton
        Me.TTBgz = New System.Windows.Forms.ToolBarButton
        Me.TTBJJ = New System.Windows.Forms.ToolBarButton
        Me.TTBS2 = New System.Windows.Forms.ToolBarButton
        Me.TTBPassWord = New System.Windows.Forms.ToolBarButton
        Me.TTBLogoff = New System.Windows.Forms.ToolBarButton
        Me.TTBQuit = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StBDep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StB_Department, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StB_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StB_Time, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL1, Me.WL2, Me.WL4, Me.WL10, Me.WL11, Me.WL12})
        '
        'WL1
        '
        Me.WL1.Index = 0
        Me.WL1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL1_1, Me.WL1_28, Me.WL1_26, Me.MenuItem12, Me.WL1_7, Me.WL1_8, Me.WL1_3, Me.WL1_9, Me.WL1_30, Me.WL1_11, Me.MenuItem152, Me.WL1_6, Me.WL1_24, Me.WL1_22, Me.WL1_23, Me.WL1_13, Me.WL1_14, Me.WL1_15, Me.MenuItem154, Me.WL1_16, Me.WL1_17, Me.WL1_18, Me.WL1_19, Me.WL1_21, Me.WL1_12, Me.MenuItem10})
        Me.WL1.Text = "基础资料"
        '
        'WL1_1
        '
        Me.WL1_1.Index = 0
        Me.WL1_1.Text = "部门代码"
        '
        'WL1_28
        '
        Me.WL1_28.Index = 1
        Me.WL1_28.Text = "员工名录表"
        '
        'WL1_26
        '
        Me.WL1_26.Index = 2
        Me.WL1_26.Text = "班次信息"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 3
        Me.MenuItem12.Text = "-"
        '
        'WL1_7
        '
        Me.WL1_7.Index = 4
        Me.WL1_7.Text = "港名代码"
        '
        'WL1_8
        '
        Me.WL1_8.Index = 5
        Me.WL1_8.Text = "国籍代码"
        '
        'WL1_3
        '
        Me.WL1_3.Index = 6
        Me.WL1_3.Text = "泊位代码"
        '
        'WL1_9
        '
        Me.WL1_9.Index = 7
        Me.WL1_9.Text = "船代货代"
        '
        'WL1_30
        '
        Me.WL1_30.Index = 8
        Me.WL1_30.Text = "客户E_Mail"
        '
        'WL1_11
        '
        Me.WL1_11.Index = 9
        Me.WL1_11.Text = "船公司代码"
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 10
        Me.MenuItem152.Text = "-"
        '
        'WL1_6
        '
        Me.WL1_6.Index = 11
        Me.WL1_6.Text = "包装及缩写"
        '
        'WL1_24
        '
        Me.WL1_24.Index = 12
        Me.WL1_24.Text = "理货类别代码"
        '
        'WL1_22
        '
        Me.WL1_22.Index = 13
        Me.WL1_22.Text = "货物残损程度部位"
        '
        'WL1_23
        '
        Me.WL1_23.Index = 14
        Me.WL1_23.Text = "货物残损用语"
        '
        'WL1_13
        '
        Me.WL1_13.Index = 15
        Me.WL1_13.Text = "集装箱理货类型"
        '
        'WL1_14
        '
        Me.WL1_14.Index = 16
        Me.WL1_14.Text = "集装箱部位代码"
        '
        'WL1_15
        '
        Me.WL1_15.Index = 17
        Me.WL1_15.Text = "集装箱残损类别代码"
        '
        'MenuItem154
        '
        Me.MenuItem154.Index = 18
        Me.MenuItem154.Text = "-"
        '
        'WL1_16
        '
        Me.WL1_16.Index = 19
        Me.WL1_16.Text = "集装箱类别代码"
        '
        'WL1_17
        '
        Me.WL1_17.Index = 20
        Me.WL1_17.Text = "集装箱箱型代码"
        '
        'WL1_18
        '
        Me.WL1_18.Index = 21
        Me.WL1_18.Text = "集装箱箱规范"
        '
        'WL1_19
        '
        Me.WL1_19.Index = 22
        Me.WL1_19.Text = "箱号船公司箱型代码对照表"
        '
        'WL1_21
        '
        Me.WL1_21.Index = 23
        Me.WL1_21.Text = "集装箱运输条款"
        '
        'WL1_12
        '
        Me.WL1_12.Index = 24
        Me.WL1_12.Text = "集装箱船名码信息"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 25
        Me.MenuItem10.Text = "拖盘代码"
        '
        'WL2
        '
        Me.WL2.Index = 1
        Me.WL2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL2_6, Me.WL2_4, Me.MenuItem8, Me.MenuItem14, Me.WL2_1, Me.WL2_2, Me.MenuItem6, Me.WL2_9, Me.MenuItem13})
        Me.WL2.Text = "船舶调度"
        '
        'WL2_6
        '
        Me.WL2_6.Index = 0
        Me.WL2_6.Text = "值班派工"
        '
        'WL2_4
        '
        Me.WL2_4.Index = 1
        Me.WL2_4.Text = "值班信息"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.Text = "-"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Text = "出口放行"
        '
        'WL2_1
        '
        Me.WL2_1.Index = 4
        Me.WL2_1.Text = "船舶规范"
        '
        'WL2_2
        '
        Me.WL2_2.Index = 5
        Me.WL2_2.Text = "航次信息"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 6
        Me.MenuItem6.Text = "-"
        '
        'WL2_9
        '
        Me.WL2_9.Index = 7
        Me.WL2_9.Text = "监控中心"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 8
        Me.MenuItem13.Text = "数据审核"
        '
        'WL4
        '
        Me.WL4.Index = 2
        Me.WL4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL4_2, Me.WL4_1, Me.WL4_3, Me.WL4_4, Me.WL4_5, Me.MenuItem156, Me.WL4_6, Me.WL4_7, Me.WL4_8, Me.WL4_10, Me.WL4_11, Me.MenuItem155, Me.WL4_12, Me.WL4_9, Me.WL4_13, Me.WL4_14, Me.WL4_15, Me.WL4_16})
        Me.WL4.Text = "集装箱业务"
        '
        'WL4_2
        '
        Me.WL4_2.Index = 0
        Me.WL4_2.Text = "BAY位规范"
        '
        'WL4_1
        '
        Me.WL4_1.Index = 1
        Me.WL4_1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL4_1_1, Me.WL4_1_2, Me.MenuItem1, Me.WL4_1_3, Me.WL4_1_4})
        Me.WL4_1.Text = "报文处理"
        '
        'WL4_1_1
        '
        Me.WL4_1_1.Index = 0
        Me.WL4_1_1.Text = "接收船图报文"
        '
        'WL4_1_2
        '
        Me.WL4_1_2.Index = 1
        Me.WL4_1_2.Text = "发送船图报文"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Text = "-"
        '
        'WL4_1_3
        '
        Me.WL4_1_3.Index = 3
        Me.WL4_1_3.Text = "接收舱单报文"
        '
        'WL4_1_4
        '
        Me.WL4_1_4.Index = 4
        Me.WL4_1_4.Text = "发送舱单报文"
        '
        'WL4_3
        '
        Me.WL4_3.Index = 2
        Me.WL4_3.Text = "舱单信息"
        '
        'WL4_4
        '
        Me.WL4_4.Index = 3
        Me.WL4_4.Text = "船图信息"
        '
        'WL4_5
        '
        Me.WL4_5.Index = 4
        Me.WL4_5.Text = "船图处理"
        '
        'MenuItem156
        '
        Me.MenuItem156.Index = 5
        Me.MenuItem156.Text = "-"
        '
        'WL4_6
        '
        Me.WL4_6.Index = 6
        Me.WL4_6.Text = "现场资料"
        '
        'WL4_7
        '
        Me.WL4_7.Index = 7
        Me.WL4_7.Text = "待时记录"
        '
        'WL4_8
        '
        Me.WL4_8.Index = 8
        Me.WL4_8.Text = "验封记录"
        '
        'WL4_10
        '
        Me.WL4_10.Index = 9
        Me.WL4_10.Text = "验封施封"
        '
        'WL4_11
        '
        Me.WL4_11.Index = 10
        Me.WL4_11.Text = "互租箱位"
        '
        'MenuItem155
        '
        Me.MenuItem155.Index = 11
        Me.MenuItem155.Text = "-"
        '
        'WL4_12
        '
        Me.WL4_12.Index = 12
        Me.WL4_12.Text = "日报"
        Me.WL4_12.Visible = False
        '
        'WL4_9
        '
        Me.WL4_9.Index = 13
        Me.WL4_9.Text = "残损溢短单"
        '
        'WL4_13
        '
        Me.WL4_13.Index = 14
        Me.WL4_13.Text = "理货业务凭证"
        Me.WL4_13.Visible = False
        '
        'WL4_14
        '
        Me.WL4_14.Index = 15
        Me.WL4_14.Text = "理货汇总证明书"
        '
        'WL4_15
        '
        Me.WL4_15.Index = 16
        Me.WL4_15.Text = "附加费项目清单"
        '
        'WL4_16
        '
        Me.WL4_16.Index = 17
        Me.WL4_16.Text = "出口三表五清单"
        '
        'WL10
        '
        Me.WL10.Index = 3
        Me.WL10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL8_1, Me.WL10_22, Me.MenuItem7, Me.MenuItem9, Me.MenuItem16, Me.WL8_6, Me.MenuItem5, Me.WL10_15})
        Me.WL10.Text = "统计报表"
        '
        'WL8_1
        '
        Me.WL8_1.Index = 0
        Me.WL8_1.Text = "考勤管理"
        '
        'WL10_22
        '
        Me.WL10_22.Index = 1
        Me.WL10_22.Text = "员工月考勤处理"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.Text = "其他考勤处理"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 3
        Me.MenuItem9.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 4
        Me.MenuItem16.Text = "奖金查询"
        '
        'WL8_6
        '
        Me.WL8_6.Index = 5
        Me.WL8_6.Text = "当月工资查询"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.Text = "-"
        '
        'WL10_15
        '
        Me.WL10_15.Index = 7
        Me.WL10_15.Text = "EDI费收统计表"
        '
        'WL11
        '
        Me.WL11.Index = 4
        Me.WL11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL11_1, Me.WL11_2, Me.WL11_3, Me.MenuItem20, Me.MenuItem4, Me.WL11_6, Me.MenuItem11, Me.MenuItem15, Me.MenuItem2, Me.WL11_4, Me.WL11_5, Me.MenuItem3, Me.WL11_7})
        Me.WL11.Text = "系统管理"
        '
        'WL11_1
        '
        Me.WL11_1.Index = 0
        Me.WL11_1.Text = "密码修改"
        '
        'WL11_2
        '
        Me.WL11_2.Index = 1
        Me.WL11_2.Text = "用户设置"
        '
        'WL11_3
        '
        Me.WL11_3.Index = 2
        Me.WL11_3.Text = "角色设置"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 3
        Me.MenuItem20.Text = "清除excel"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Text = "-"
        '
        'WL11_6
        '
        Me.WL11_6.Index = 5
        Me.WL11_6.Text = "EDI 路径设置"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 6
        Me.MenuItem11.Text = "资料存取"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 7
        Me.MenuItem15.Text = "操作日志"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 8
        Me.MenuItem2.Text = "-"
        '
        'WL11_4
        '
        Me.WL11_4.Index = 9
        Me.WL11_4.Text = "注销"
        '
        'WL11_5
        '
        Me.WL11_5.Index = 10
        Me.WL11_5.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.WL11_5.Text = "退出(&X)"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 11
        Me.MenuItem3.Text = "-"
        Me.MenuItem3.Visible = False
        '
        'WL11_7
        '
        Me.WL11_7.Index = 12
        Me.WL11_7.Text = "系统智能升级"
        Me.WL11_7.Visible = False
        '
        'WL12
        '
        Me.WL12.Index = 5
        Me.WL12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.WL12_1, Me.WL12_2})
        Me.WL12.Text = "帮助"
        '
        'WL12_1
        '
        Me.WL12_1.Index = 0
        Me.WL12_1.Text = "帮助"
        '
        'WL12_2
        '
        Me.WL12_2.Index = 1
        Me.WL12_2.Text = "关于... ..."
        '
        'stb
        '
        Me.stb.Location = New System.Drawing.Point(0, 404)
        Me.stb.Name = "stb"
        Me.stb.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StBDep, Me.StB_Department, Me.stbUser, Me.StB_User, Me.STBT, Me.StB_Time, Me.StatusBarPanel2})
        Me.stb.ShowPanels = True
        Me.stb.Size = New System.Drawing.Size(956, 22)
        Me.stb.TabIndex = 3
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 35
        '
        'StBDep
        '
        Me.StBDep.Name = "StBDep"
        Me.StBDep.Text = "部门名称："
        Me.StBDep.Width = 80
        '
        'StB_Department
        '
        Me.StB_Department.Name = "StB_Department"
        Me.StB_Department.Width = 150
        '
        'stbUser
        '
        Me.stbUser.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.stbUser.Name = "stbUser"
        Me.stbUser.Text = "当前操作员："
        Me.stbUser.Width = 80
        '
        'StB_User
        '
        Me.StB_User.Name = "StB_User"
        Me.StB_User.Width = 150
        '
        'STBT
        '
        Me.STBT.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.STBT.Name = "STBT"
        Me.STBT.Text = "当前时间："
        Me.STBT.Width = 80
        '
        'StB_Time
        '
        Me.StB_Time.Name = "StB_Time"
        Me.StB_Time.Width = 200
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "连云港外轮理货有限公司    版权所有"
        Me.StatusBarPanel2.Width = 500
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        Me.ImageList.Images.SetKeyName(9, "")
        Me.ImageList.Images.SetKeyName(10, "")
        Me.ImageList.Images.SetKeyName(11, "")
        Me.ImageList.Images.SetKeyName(12, "")
        Me.ImageList.Images.SetKeyName(13, "")
        Me.ImageList.Images.SetKeyName(14, "")
        Me.ImageList.Images.SetKeyName(15, "WRITE3.ICO")
        Me.ImageList.Images.SetKeyName(16, "hg6.ico")
        Me.ImageList.Images.SetKeyName(17, "TIME.ICO")
        Me.ImageList.Images.SetKeyName(18, "2015-1.ico")
        Me.ImageList.Images.SetKeyName(19, "2015-02.ico")
        Me.ImageList.Images.SetKeyName(20, "2015-2.ico")
        Me.ImageList.Images.SetKeyName(21, "2015-3.ico")
        Me.ImageList.Images.SetKeyName(22, "2015-04.ico")
        Me.ImageList.Images.SetKeyName(23, "2015-05.ico")
        Me.ImageList.Images.SetKeyName(24, "2015-06.ico")
        Me.ImageList.Images.SetKeyName(25, "2015-07.ico")
        Me.ImageList.Images.SetKeyName(26, "2015-08.ico")
        Me.ImageList.Images.SetKeyName(27, "2015-09.ico")
        Me.ImageList.Images.SetKeyName(28, "2015-10.ico")
        Me.ImageList.Images.SetKeyName(29, "costaco.ICO")
        Me.ImageList.Images.SetKeyName(30, "image002.ico")
        Me.ImageList.Images.SetKeyName(31, "未标题-3.ico")
        '
        'Timer
        '
        Me.Timer.Interval = 50
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton10, Me.ToolBarButton9, Me.ToolBarButton5, Me.TTBBillPrint, Me.ToolBarButton2, Me.TTBBill, Me.TTBInvoice, Me.ToolBarButton8, Me.TTBS1, Me.ToolBarButton6, Me.ToolBarButton1, Me.TTBSeal, Me.ToolBarButton7, Me.TTBInout, Me.TTBgz, Me.TTBJJ, Me.TTBS2, Me.TTBPassWord, Me.TTBLogoff, Me.TTBQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(956, 41)
        Me.ToolBar.TabIndex = 6
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.ImageIndex = 17
        Me.ToolBarButton10.Name = "ToolBarButton10"
        Me.ToolBarButton10.Text = "当班考勤"
        Me.ToolBarButton10.ToolTipText = "当班考勤管理"
        Me.ToolBarButton10.Visible = False
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.ImageIndex = 16
        Me.ToolBarButton9.Name = "ToolBarButton9"
        Me.ToolBarButton9.Text = "出口放行"
        Me.ToolBarButton9.ToolTipText = "集装箱海关放行处理"
        Me.ToolBarButton9.Visible = False
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 13
        Me.ToolBarButton5.Name = "ToolBarButton5"
        Me.ToolBarButton5.Text = "现场监控"
        Me.ToolBarButton5.ToolTipText = "现场作业监控"
        '
        'TTBBillPrint
        '
        Me.TTBBillPrint.ImageIndex = 18
        Me.TTBBillPrint.Name = "TTBBillPrint"
        Me.TTBBillPrint.Text = "航次信息"
        Me.TTBBillPrint.ToolTipText = "航次信息"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 2
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Text = "接收舱单"
        Me.ToolBarButton2.ToolTipText = "接收舱单"
        '
        'TTBBill
        '
        Me.TTBBill.ImageIndex = 3
        Me.TTBBill.Name = "TTBBill"
        Me.TTBBill.Text = "接收船图"
        Me.TTBBill.ToolTipText = "接收船图"
        '
        'TTBInvoice
        '
        Me.TTBInvoice.ImageIndex = 13
        Me.TTBInvoice.Name = "TTBInvoice"
        Me.TTBInvoice.Text = "发送船图"
        Me.TTBInvoice.ToolTipText = "发送船图"
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.ImageIndex = 15
        Me.ToolBarButton8.Name = "ToolBarButton8"
        Me.ToolBarButton8.Text = "理货报告"
        Me.ToolBarButton8.ToolTipText = "发送理货报告"
        '
        'TTBS1
        '
        Me.TTBS1.Name = "TTBS1"
        Me.TTBS1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 2
        Me.ToolBarButton6.Name = "ToolBarButton6"
        Me.ToolBarButton6.Text = "舱单信息"
        Me.ToolBarButton6.ToolTipText = "舱单编辑修改信息"
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 4
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "船图信息"
        Me.ToolBarButton1.ToolTipText = "船图信息"
        '
        'TTBSeal
        '
        Me.TTBSeal.ImageIndex = 5
        Me.TTBSeal.Name = "TTBSeal"
        Me.TTBSeal.Text = "船图处理"
        Me.TTBSeal.ToolTipText = "船图处理"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 1
        Me.ToolBarButton7.Name = "ToolBarButton7"
        Me.ToolBarButton7.Text = "资料存取"
        Me.ToolBarButton7.ToolTipText = "单证资料上传下载"
        Me.ToolBarButton7.Visible = False
        '
        'TTBInout
        '
        Me.TTBInout.Name = "TTBInout"
        Me.TTBInout.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'TTBgz
        '
        Me.TTBgz.ImageIndex = 14
        Me.TTBgz.Name = "TTBgz"
        Me.TTBgz.Text = "工资查询"
        Me.TTBgz.ToolTipText = "工资查询"
        '
        'TTBJJ
        '
        Me.TTBJJ.ImageIndex = 6
        Me.TTBJJ.Name = "TTBJJ"
        Me.TTBJJ.Text = "奖金查询"
        Me.TTBJJ.ToolTipText = "奖金及缴税情况"
        '
        'TTBS2
        '
        Me.TTBS2.Name = "TTBS2"
        Me.TTBS2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'TTBPassWord
        '
        Me.TTBPassWord.ImageIndex = 8
        Me.TTBPassWord.Name = "TTBPassWord"
        Me.TTBPassWord.Text = "登录密码"
        Me.TTBPassWord.ToolTipText = "密码修改"
        '
        'TTBLogoff
        '
        Me.TTBLogoff.ImageIndex = 9
        Me.TTBLogoff.Name = "TTBLogoff"
        Me.TTBLogoff.Text = "系统注销"
        Me.TTBLogoff.ToolTipText = "注销"
        '
        'TTBQuit
        '
        Me.TTBQuit.ImageIndex = 10
        Me.TTBQuit.Name = "TTBQuit"
        Me.TTBQuit.Text = "退出系统"
        Me.TTBQuit.ToolTipText = "退出"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 13
        Me.ToolBarButton4.Name = "ToolBarButton4"
        Me.ToolBarButton4.Text = "现场监控"
        Me.ToolBarButton4.ToolTipText = "现场作业监控"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 7
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.Text = "舱单信息"
        Me.ToolBarButton3.ToolTipText = "舱单信息"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        '
        'FrmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(956, 426)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.stb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "连云港外轮理货信息管理系统_集装箱EDI子系统"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StBDep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StB_Department, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StB_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StB_Time, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub FrmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        End
    End Sub
    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StB_Department.Text = G_DeptName
        Me.StB_User.Text = G_User
        Me.Timer.Start()
        Menuitem(1) = WL1_1
        Menuitem(2) = WL11_1
        Menuitem(3) = WL11_2
        Menuitem(4) = WL11_3
        Menuitem(5) = WL1_28
        Menuitem(6) = WL1_3
        Menuitem(9) = WL1_6
        Menuitem(10) = WL1_7
        Menuitem(11) = WL1_8
        Menuitem(12) = WL1_9
        Menuitem(14) = WL1_11
        Menuitem(15) = WL1_13
        Menuitem(16) = WL1_14
        Menuitem(17) = WL1_16
        Menuitem(18) = WL1_21
        Menuitem(19) = WL1_22
        Menuitem(20) = WL1_23
        Menuitem(21) = WL1_24
        Menuitem(27) = WL1_12
        Menuitem(28) = WL1_15
        Menuitem(29) = WL1_17
        Menuitem(30) = WL1_18
        Menuitem(31) = WL1_19
        Menuitem(33) = WL1_30
        Menuitem(34) = WL11_6
        Menuitem(35) = WL2_1
        Menuitem(36) = WL2_2
        Menuitem(64) = WL4_1_1
        Menuitem(65) = WL4_1_2
        Menuitem(66) = WL4_1_3
        Menuitem(67) = WL4_2
        Menuitem(68) = WL4_3
        Menuitem(69) = WL4_4
        Menuitem(70) = WL4_5
        Menuitem(71) = WL4_6
        Menuitem(72) = WL4_7
        Menuitem(73) = WL4_8
        Menuitem(74) = WL4_9
        Menuitem(75) = WL4_10
        Menuitem(76) = WL4_11
        Menuitem(77) = WL4_12
        Menuitem(78) = WL4_13
        Menuitem(79) = WL4_14
        Menuitem(80) = WL4_15
        Menuitem(81) = WL4_16
        Menuitem(140) = WL1
        Menuitem(141) = WL2
        Menuitem(143) = WL4
        Menuitem(149) = WL10
        Menuitem(150) = WL11
        sqlstr = "select FUNC_CODE,FUNC_NAME,FUNC_CODE_View from View_UserPreview where PART_ID= " & G_Part_Id & " and Serial_Nam= '" & G_User_Serial & "'"
        dv = DBControl.Getdata(sqlstr, ds)
        Dim k As Integer '菜单是否可见的标志位
        Dim i As Integer
        Dim j As Integer
        'Try
        '    For i = 1 To 150
        '        k = 0
        '        For j = 0 To dv.Count - 1
        '            If Menuitem(i).Text = dv(j)("FUNC_Name") And dv(j)("FUNC_CODE_View") = 1 Then
        '                Menuitem(i).Enabled = True
        '                k = k + 1
        '                Exit For
        '            End If
        '        Next
        '        If k = 0 Then
        '            Menuitem(i).Enabled = False
        '        End If
        '    Next
        'Catch ex As System.Exception
        '    MsgBox(ex.Message)
        'End Try
        txupgrade()



    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Me.StB_Time.Text = Now()
        If TBar = 1 Then
            Me.ToolBar.Visible = True
        Else
            Me.ToolBar.Visible = False
        End If

        If Mnu = 1 Then
            WL1.Visible = True
            WL2.Visible = True
            WL4.Visible = True
            WL10.Visible = True
            WL11.Visible = True
            WL12.Visible = True
        Else
            WL1.Visible = False
            WL2.Visible = False
            WL4.Visible = False
            WL10.Visible = False
            WL11.Visible = False
            WL12.Visible = False
        End If
    End Sub

    Private Sub WL1_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_1.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmDepartMent
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_3.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmBERTH
        Frm.MdiParent = Me
        Frm.Show()
    End Sub



    Private Sub WL1_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_6.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmPack
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_7.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmPort
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_8.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmNationality
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_9.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmShipAgent
        Frm.MdiParent = Me
        Frm.Show()
    End Sub


    Private Sub WL1_11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_11.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmShipOwner
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_12.Click
        TBar = 0
        Mnu = 0
        Dim frm As New FrmShipName
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL1_13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_13.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmTallyType
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_14.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmConPosition
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_15.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmConDamagedType
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_16.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmConKind
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_17.Click
        TBar = 0
        Mnu = 0
        Dim frm As New FrmConType
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL1_18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_18.Click
        TBar = 0
        Mnu = 0
        Dim frm As New FrmCONCRITERION
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL1_19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_19.Click
        TBar = 0
        Mnu = 0
        Dim frm As New FrmTypeShipRelation
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL1_20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TBar = 0
        Mnu = 0
        Dim frm As New FrmCheck
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL1_21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_21.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmConTraffic
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_22.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCargoDamagedDegree
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_23_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_23.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCargoDamaged
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL1_24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_24.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmWorkType
        Frm.MdiParent = Me
        Frm.Show()
    End Sub
    'Private Sub WL1_26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_26.Click
    '    TBar = 0
    '    Mnu = 0
    '    Dim Frm As New FrmWorkBegin
    '    Frm.MdiParent = Me
    '    Frm.Show()
    'End Sub

    Private Sub WL1_28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_28.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmTallyClerk
        Frm.MdiParent = Me
        Frm.Show()
    End Sub


    Private Sub WL1_30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL1_30.Click
        TBar = 0
        Mnu = 0
        Dim frm As New FrmEmailName
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL2_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL2_1.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmVessel_Papers
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL2_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL2_2.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmSShip
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_2.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New Frm_bay_map
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_5.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New Frm_con_operate_map
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_6.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCon_Onport
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_7.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FRMCON_WAITFOR
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_9.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FRMCON_SHORT
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_12.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCON_DAILY_REPORT
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_13.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FRMCON_APPEND_FEE
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_14.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FRMCON_CERTIFICATE_SUM
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_15.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FRMCON_APPEND_FEE
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL11_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_1.Click
        Dim frm As New FrmUserPass
        frm.MdiParent = Me
        frm.Show()
    End Sub



    Private Sub WL11_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_2.Click
        TBar = 0
        Mnu = 0
        Dim frm As New FrmUser
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WL11_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_3.Click
        TBar = 0
        Mnu = 0
        Dim frm As New FrmPart
        frm.MdiParent = Me
        frm.Show()
    End Sub



    Private Sub WL4_1_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_1_1.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmEDIRead
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_1_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_1_2.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmEDIWrite
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL11_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_4.Click
        Dim Frm As New FrmLogin
        Frm.Show()
        Me.Hide()
    End Sub

    Private Sub WL11_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_5.Click
        End
    End Sub

    Private Sub WL4_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_3.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmConHatchCargo
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_4.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmConImageCargo
        Frm.MdiParent = Me
        Frm.Show()
    End Sub
    Private Sub WL4_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_8.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmConOpen
        Frm.MdiParent = Me
        Frm.Show()
    End Sub
    Private Sub WL4_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_10.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmConSealExam
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_11.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmConHatchCargo
        'Dim Frm As New FrmConRent
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_16.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmContainerListSummary
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL4_1_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_1_3.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmEDIReadList
        Frm.MdiParent = Me
        Frm.Show()
    End Sub



    Private Sub WL10_15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_15.Click
        Dim frm As New Frm_con_edi_stat_month
        frm.ShowDialog()

    End Sub


    Private Sub WL11_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_6.Click
        Dim Frm As New FrmEDIINI
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        TALLY.DBControl.KillTotalExcelProcess()  '清除所有EXCEL进程
    End Sub

    Private Sub WL4_1_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL4_1_4.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmEDIWriteList
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub txupgrade()
        Const strMainProcID As String = "1"     '主程序在UPGRADE表中的编号PROID
        Const strEditionFileName As String = "UpGrade.txt"
        Const strUpgradeProcName As String = "TallyEDIUpgrade.exe"

        Dim strPathApp As String = System.IO.Directory.GetCurrentDirectory()
        Dim strPathFile As String = strPathApp & "\\" & strEditionFileName
        Dim strPathProc As String = strPathApp & "\\" & strUpgradeProcName
        Dim strNowVersion As String
        Dim sqlEdition As String
        Dim dvEdition As New DataView
        sqlEdition = "SELECT UPID FROM UPGRADEEDI WHERE PROGRAM = 'TallyEDI' order by PROID"
        dvEdition = DBControl.Filldata(sqlEdition)
        Dim NextTo As Boolean = True
        Try
            If System.IO.File.Exists(strPathFile) Then
                Dim srReader As New System.IO.StreamReader(strPathFile)
                strNowVersion = srReader.ReadLine()
                If strNowVersion = dvEdition(0)("UPID") Then
                    NextTo = False
                End If
                srReader.Close()
            End If
            'If NextTo Then
            '    Me.Text = Me.Text + "    " + "当前版本为：" + strNowVersion + " 最新版本为：" + dvEdition(0)("UPID") + " 建议升级！"
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub WL11_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL11_7.Click
        Const strMainProcID As String = "1"     '主程序在UPGRADE表中的编号PROID
        Const strEditionFileName As String = "UpGrade.txt"
        Const strUpgradeProcName As String = "TallyEDIUpgrade.exe"

        Dim strPathApp As String = System.IO.Directory.GetCurrentDirectory()
        Dim strPathFile As String = strPathApp & "\\" & strEditionFileName
        Dim strPathProc As String = strPathApp & "\\" & strUpgradeProcName
        Dim strNowVersion As String
        Dim sqlEdition As String
        Dim dvEdition As New DataView
        sqlEdition = "SELECT UPID FROM UPGRADEEDI WHERE PROGRAM = 'TallyEDI' order by PROID"
        dvEdition = DBControl.Filldata(sqlEdition)
        Dim NextTo As Boolean = True
        Try
            If System.IO.File.Exists(strPathFile) Then
                Dim srReader As New System.IO.StreamReader(strPathFile)
                strNowVersion = srReader.ReadLine()
                If strNowVersion = dvEdition(0)("UPID") Then
                    NextTo = False
                End If
                srReader.Close()
            End If
            If NextTo Then
                If System.IO.File.Exists(strPathProc) Then
                    System.Diagnostics.Process.Start(strPathProc)
                    Application.Exit()
                Else
                    MessageBox.Show("升级程序不存在，请检查" & strPathProc, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("当前程序已是最新版本，无须更新", "提示")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick

        'If e.Button.Text = "当班考勤" Then
        '    Call WL8_1_Click(sender, e)
        'End If

        If e.Button.Text = "出口放行" Then
            Call MenuItem14_Click(sender, e)
        End If

        If e.Button.Text = "现场监控" Then
            Call WL2_9_Click(sender, e)
        End If

        If e.Button.Text = "航次信息" Then
            Call WL2_2_Click(sender, e)
        End If

        If e.Button.Text = "接收舱单" Then
            Call WL4_1_3_Click(sender, e)
        End If

        If e.Button.Text = "接收船图" Then
            Call WL4_1_1_Click(sender, e)
        End If

        If e.Button.Text = "发送船图" Then
            Call WL4_1_2_Click(sender, e)
        End If

        If e.Button.Text = "理货报告" Then
            Call WL4_1_4_Click(sender, e)
        End If

        If e.Button.Text = "舱单信息" Then
            Call WL4_3_Click(sender, e)
        End If

        If e.Button.Text = "船图信息" Then
            Call WL4_4_Click(sender, e)
        End If

        If e.Button.Text = "船图处理" Then
            Call WL4_5_Click(sender, e)
        End If

        If e.Button.Text = "资料存取" Then
            Call MenuItem11_Click(sender, e)
        End If

        If e.Button.Text = "工资查询" Then
            Call WL8_6_Click(sender, e)
        End If

        If e.Button.Text = "奖金查询" Then
            Call MenuItem16_Click(sender, e)
        End If

        If e.Button.Text = "登录密码" Then
            Dim frm As New FrmUserPass
            frm.ShowDialog()
        End If
        If e.Button.Text = "退出系统" Then
            End
        End If
        If e.Button.Text = "系统注销" Then
            Dim FrmLogin As New FrmLogin
            FrmLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub WL2_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL2_4.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmAttemper
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL8_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL8_1.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmABSENT
        Frm.MdiParent = Me
        Frm.Show()
    End Sub
    Private Sub WL8_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL8_6.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmTally_Wage
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL10_22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL10_22.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmABSENT_Print
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub WL2_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL2_6.Click
        'TBar = 0
        'Mnu = 0
        Dim Frm As New FrmAttemper_NewMain
        Frm.MinimizeBox = False
        Frm.MaximizeBox = False
        Frm.ShowDialog()
        'Frm.MdiParent = Me
        'Frm.Show()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmABSENT_Print_tmp
        Frm.MdiParent = Me
        Frm.Show()
    End Sub
    Private Sub WL2_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WL2_9.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmCon_Monitor
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'gl_xdf = "select * from tb_CON_INSTRUCTION where LoadUnload_Mark=1 and Error_Descr is not null and Error_Descr <>'' and Error_Descr <>'99'"
        'dv_xdf = Getdata(gl_xdf, ds_xdf)
        Dim info As String
        'info = DBControl.xdfinfo()

        If info <> "99" Then
            Timer1.Enabled = False
            Me.Button1.Location = New System.Drawing.Point(Me.Width - Button1.Width - 5, Label1.Location.Y)
            Label1.Text = info
            Button1.Visible = True
            Label1.Visible = True
            'System.Threading.Thread.Sleep(5000)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = ""
        Label1.Visible = False
        Button1.Visible = False
        Timer1.Enabled = True
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        TBar = 0
        Mnu = 0
        Dim Frm As New FrmTray
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        TBar = 0
        Mnu = 0
        'Dim Frm As New FrmFileView
        Dim Frm As New File_bak
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        '件杂货
        'If G_Part_Id <> "27" Or G_Part_Id = "19" Then
        '    TBar = 0
        '    Mnu = 0
        '    Dim Frm As New FrmCargo_verify
        '    Frm.MdiParent = Me
        '    Frm.Show()
        'End If
        '集装箱
        If G_Part_Id = "49" Or G_Part_Id = "24" Or G_Part_Id = "1" Then '审核员
            TBar = 0
            Mnu = 0
            Dim Frm As New FrmCon_Verify
            Frm.MdiParent = Me
            Frm.Show()
        End If
    End Sub


    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        If G_DeptCode = "26" Or G_DeptCode = "26.11.12" Then
            TBar = 0
            Mnu = 0
            Dim Frm As New FrmConLoadFinalNew
            Frm.MdiParent = Me
            Frm.Show()
        End If
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Dim Frm As New FrmHis
        Frm.ShowDialog()
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click

        TBar = 0
        Mnu = 0
        Dim Frm As New Frm_Bonus_New
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

End Class
