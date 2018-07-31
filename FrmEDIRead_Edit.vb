Imports TALLY.DBControl
Public Class FrmEDIRead_Edit
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btResume As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtSeal As System.Windows.Forms.TextBox
    Friend WithEvents txtStatu As System.Windows.Forms.TextBox
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents txtNO As System.Windows.Forms.TextBox
    Friend WithEvents txtGoodsEng As System.Windows.Forms.TextBox
    Friend WithEvents txtCodeGoods As System.Windows.Forms.TextBox
    Friend WithEvents txtBLNO As System.Windows.Forms.TextBox
    Friend WithEvents txtBay As System.Windows.Forms.TextBox
    Friend WithEvents txtLoadPort As System.Windows.Forms.TextBox
    Friend WithEvents txtLoadPortCode As System.Windows.Forms.TextBox
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents txtGoodsCHA As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtDelivery As System.Windows.Forms.TextBox
    Friend WithEvents txtDeliveryCode As System.Windows.Forms.TextBox
    Friend WithEvents txtUnLoadPort As System.Windows.Forms.TextBox
    Friend WithEvents txtTempUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtVolumn As System.Windows.Forms.TextBox
    Friend WithEvents txtTareWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtGrossWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtOverHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtTempMax As System.Windows.Forms.TextBox
    Friend WithEvents txtTempMin As System.Windows.Forms.TextBox
    Friend WithEvents txtTempSet As System.Windows.Forms.TextBox
    Friend WithEvents txtDangerClass As System.Windows.Forms.TextBox
    Friend WithEvents txtOverFront As System.Windows.Forms.TextBox
    Friend WithEvents txtOverRight As System.Windows.Forms.TextBox
    Friend WithEvents txtDangerMark As System.Windows.Forms.TextBox
    Friend WithEvents txtDangerNo As System.Windows.Forms.TextBox
    Friend WithEvents txtDangerPage As System.Windows.Forms.TextBox
    Friend WithEvents txtOverLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtUnLoadPortCode As System.Windows.Forms.TextBox
    Friend WithEvents txtKind As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtOverBack As System.Windows.Forms.TextBox
    Friend WithEvents txtShipLinerCode As System.Windows.Forms.TextBox
    Friend WithEvents txtKeeper As System.Windows.Forms.TextBox
    Friend WithEvents txtKeeperCode As System.Windows.Forms.TextBox
    Friend WithEvents txtShipLiner As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtSeal = New System.Windows.Forms.TextBox()
        Me.txtStatu = New System.Windows.Forms.TextBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.txtNO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btResume = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtGoodsEng = New System.Windows.Forms.TextBox()
        Me.txtCodeGoods = New System.Windows.Forms.TextBox()
        Me.txtBLNO = New System.Windows.Forms.TextBox()
        Me.txtBay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLoadPort = New System.Windows.Forms.TextBox()
        Me.txtLoadPortCode = New System.Windows.Forms.TextBox()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.txtGoodsCHA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtDelivery = New System.Windows.Forms.TextBox()
        Me.txtDeliveryCode = New System.Windows.Forms.TextBox()
        Me.txtUnLoadPort = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTempUnit = New System.Windows.Forms.TextBox()
        Me.txtVolumn = New System.Windows.Forms.TextBox()
        Me.txtTareWeight = New System.Windows.Forms.TextBox()
        Me.txtGrossWeight = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtOverHeight = New System.Windows.Forms.TextBox()
        Me.txtTempMax = New System.Windows.Forms.TextBox()
        Me.txtTempMin = New System.Windows.Forms.TextBox()
        Me.txtTempSet = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtDangerClass = New System.Windows.Forms.TextBox()
        Me.txtOverBack = New System.Windows.Forms.TextBox()
        Me.txtOverFront = New System.Windows.Forms.TextBox()
        Me.txtOverRight = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtShipLinerCode = New System.Windows.Forms.TextBox()
        Me.txtDangerMark = New System.Windows.Forms.TextBox()
        Me.txtDangerNo = New System.Windows.Forms.TextBox()
        Me.txtDangerPage = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtKind = New System.Windows.Forms.TextBox()
        Me.txtKeeper = New System.Windows.Forms.TextBox()
        Me.txtKeeperCode = New System.Windows.Forms.TextBox()
        Me.txtShipLiner = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtOverLeft = New System.Windows.Forms.TextBox()
        Me.txtUnLoadPortCode = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSeal
        '
        Me.txtSeal.Location = New System.Drawing.Point(78, 74)
        Me.txtSeal.MaxLength = 20
        Me.txtSeal.Name = "txtSeal"
        Me.txtSeal.Size = New System.Drawing.Size(130, 21)
        Me.txtSeal.TabIndex = 128
        Me.txtSeal.Text = ""
        '
        'txtStatu
        '
        Me.txtStatu.Location = New System.Drawing.Point(78, 50)
        Me.txtStatu.MaxLength = 20
        Me.txtStatu.Name = "txtStatu"
        Me.txtStatu.Size = New System.Drawing.Size(130, 21)
        Me.txtStatu.TabIndex = 127
        Me.txtStatu.Text = ""
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(78, 26)
        Me.txtSize.MaxLength = 20
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(130, 21)
        Me.txtSize.TabIndex = 126
        Me.txtSize.Text = ""
        '
        'txtNO
        '
        Me.txtNO.Location = New System.Drawing.Point(78, 2)
        Me.txtNO.MaxLength = 20
        Me.txtNO.Name = "txtNO"
        Me.txtNO.Size = New System.Drawing.Size(130, 21)
        Me.txtNO.TabIndex = 125
        Me.txtNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "铅封号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "箱状态"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "箱尺寸"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "箱号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(315, 314)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 120
        Me.btQuit.Text = "取消"
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(247, 314)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(65, 24)
        Me.btResume.TabIndex = 119
        Me.btResume.Text = "确认"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 118
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtGoodsEng
        '
        Me.txtGoodsEng.Location = New System.Drawing.Point(78, 194)
        Me.txtGoodsEng.MaxLength = 20
        Me.txtGoodsEng.Name = "txtGoodsEng"
        Me.txtGoodsEng.Size = New System.Drawing.Size(130, 21)
        Me.txtGoodsEng.TabIndex = 136
        Me.txtGoodsEng.Text = ""
        '
        'txtCodeGoods
        '
        Me.txtCodeGoods.Location = New System.Drawing.Point(78, 170)
        Me.txtCodeGoods.MaxLength = 20
        Me.txtCodeGoods.Name = "txtCodeGoods"
        Me.txtCodeGoods.Size = New System.Drawing.Size(130, 21)
        Me.txtCodeGoods.TabIndex = 135
        Me.txtCodeGoods.Text = ""
        '
        'txtBLNO
        '
        Me.txtBLNO.Location = New System.Drawing.Point(78, 122)
        Me.txtBLNO.MaxLength = 20
        Me.txtBLNO.Name = "txtBLNO"
        Me.txtBLNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBLNO.TabIndex = 134
        Me.txtBLNO.Text = ""
        '
        'txtBay
        '
        Me.txtBay.Location = New System.Drawing.Point(78, 98)
        Me.txtBay.MaxLength = 20
        Me.txtBay.Name = "txtBay"
        Me.txtBay.Size = New System.Drawing.Size(130, 21)
        Me.txtBay.TabIndex = 133
        Me.txtBay.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(-4, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "货物英文描述"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "货名代码"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 130
        Me.Label7.Text = "提单号"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(4, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "贝位号"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLoadPort
        '
        Me.txtLoadPort.Location = New System.Drawing.Point(78, 266)
        Me.txtLoadPort.MaxLength = 20
        Me.txtLoadPort.Name = "txtLoadPort"
        Me.txtLoadPort.Size = New System.Drawing.Size(130, 21)
        Me.txtLoadPort.TabIndex = 144
        Me.txtLoadPort.Text = ""
        '
        'txtLoadPortCode
        '
        Me.txtLoadPortCode.Location = New System.Drawing.Point(78, 242)
        Me.txtLoadPortCode.MaxLength = 20
        Me.txtLoadPortCode.Name = "txtLoadPortCode"
        Me.txtLoadPortCode.Size = New System.Drawing.Size(130, 21)
        Me.txtLoadPortCode.TabIndex = 143
        Me.txtLoadPortCode.Text = ""
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(78, 146)
        Me.txtMark.MaxLength = 20
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 142
        Me.txtMark.Text = ""
        '
        'txtGoodsCHA
        '
        Me.txtGoodsCHA.Location = New System.Drawing.Point(78, 218)
        Me.txtGoodsCHA.MaxLength = 20
        Me.txtGoodsCHA.Name = "txtGoodsCHA"
        Me.txtGoodsCHA.Size = New System.Drawing.Size(130, 21)
        Me.txtGoodsCHA.TabIndex = 141
        Me.txtGoodsCHA.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(4, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "装货港"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(4, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 139
        Me.Label10.Text = "装货港代码"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(4, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 138
        Me.Label11.Text = "标志"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(-4, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 18)
        Me.Label12.TabIndex = 137
        Me.Label12.Text = "货物中文描述"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(288, 74)
        Me.txtAmount.MaxLength = 20
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 152
        Me.txtAmount.Text = ""
        '
        'txtDelivery
        '
        Me.txtDelivery.Location = New System.Drawing.Point(288, 50)
        Me.txtDelivery.MaxLength = 20
        Me.txtDelivery.Name = "txtDelivery"
        Me.txtDelivery.Size = New System.Drawing.Size(130, 21)
        Me.txtDelivery.TabIndex = 151
        Me.txtDelivery.Text = ""
        '
        'txtDeliveryCode
        '
        Me.txtDeliveryCode.Location = New System.Drawing.Point(288, 26)
        Me.txtDeliveryCode.MaxLength = 20
        Me.txtDeliveryCode.Name = "txtDeliveryCode"
        Me.txtDeliveryCode.Size = New System.Drawing.Size(130, 21)
        Me.txtDeliveryCode.TabIndex = 150
        Me.txtDeliveryCode.Text = ""
        '
        'txtUnLoadPort
        '
        Me.txtUnLoadPort.Location = New System.Drawing.Point(288, 2)
        Me.txtUnLoadPort.MaxLength = 20
        Me.txtUnLoadPort.Name = "txtUnLoadPort"
        Me.txtUnLoadPort.Size = New System.Drawing.Size(130, 21)
        Me.txtUnLoadPort.TabIndex = 149
        Me.txtUnLoadPort.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(212, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 148
        Me.Label13.Text = "件数"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(212, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 147
        Me.Label14.Text = "目的港"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(212, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 146
        Me.Label15.Text = "目的港代码"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(212, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 145
        Me.Label16.Text = "卸货港"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempUnit
        '
        Me.txtTempUnit.Location = New System.Drawing.Point(288, 170)
        Me.txtTempUnit.MaxLength = 20
        Me.txtTempUnit.Name = "txtTempUnit"
        Me.txtTempUnit.Size = New System.Drawing.Size(130, 21)
        Me.txtTempUnit.TabIndex = 160
        Me.txtTempUnit.Text = ""
        '
        'txtVolumn
        '
        Me.txtVolumn.Location = New System.Drawing.Point(288, 146)
        Me.txtVolumn.MaxLength = 20
        Me.txtVolumn.Name = "txtVolumn"
        Me.txtVolumn.Size = New System.Drawing.Size(130, 21)
        Me.txtVolumn.TabIndex = 159
        Me.txtVolumn.Text = ""
        '
        'txtTareWeight
        '
        Me.txtTareWeight.Location = New System.Drawing.Point(288, 122)
        Me.txtTareWeight.MaxLength = 20
        Me.txtTareWeight.Name = "txtTareWeight"
        Me.txtTareWeight.Size = New System.Drawing.Size(130, 21)
        Me.txtTareWeight.TabIndex = 158
        Me.txtTareWeight.Text = ""
        '
        'txtGrossWeight
        '
        Me.txtGrossWeight.Location = New System.Drawing.Point(288, 98)
        Me.txtGrossWeight.MaxLength = 20
        Me.txtGrossWeight.Name = "txtGrossWeight"
        Me.txtGrossWeight.Size = New System.Drawing.Size(130, 21)
        Me.txtGrossWeight.TabIndex = 157
        Me.txtGrossWeight.Text = ""
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(208, 172)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 18)
        Me.Label17.TabIndex = 156
        Me.Label17.Text = "温度计量单位"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(212, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 155
        Me.Label18.Text = "体积"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(212, 124)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 154
        Me.Label19.Text = "箱皮重"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(212, 100)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 153
        Me.Label20.Text = "箱毛重"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOverHeight
        '
        Me.txtOverHeight.Location = New System.Drawing.Point(288, 266)
        Me.txtOverHeight.MaxLength = 20
        Me.txtOverHeight.Name = "txtOverHeight"
        Me.txtOverHeight.Size = New System.Drawing.Size(130, 21)
        Me.txtOverHeight.TabIndex = 168
        Me.txtOverHeight.Text = ""
        '
        'txtTempMax
        '
        Me.txtTempMax.Location = New System.Drawing.Point(288, 242)
        Me.txtTempMax.MaxLength = 20
        Me.txtTempMax.Name = "txtTempMax"
        Me.txtTempMax.Size = New System.Drawing.Size(130, 21)
        Me.txtTempMax.TabIndex = 167
        Me.txtTempMax.Text = ""
        '
        'txtTempMin
        '
        Me.txtTempMin.Location = New System.Drawing.Point(288, 218)
        Me.txtTempMin.MaxLength = 20
        Me.txtTempMin.Name = "txtTempMin"
        Me.txtTempMin.Size = New System.Drawing.Size(130, 21)
        Me.txtTempMin.TabIndex = 166
        Me.txtTempMin.Text = ""
        '
        'txtTempSet
        '
        Me.txtTempSet.Location = New System.Drawing.Point(288, 194)
        Me.txtTempSet.MaxLength = 20
        Me.txtTempSet.Name = "txtTempSet"
        Me.txtTempSet.Size = New System.Drawing.Size(130, 21)
        Me.txtTempSet.TabIndex = 165
        Me.txtTempSet.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(212, 266)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 164
        Me.Label21.Text = "超高"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(212, 244)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 163
        Me.Label22.Text = "最高温度"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(212, 220)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 18)
        Me.Label23.TabIndex = 162
        Me.Label23.Text = "最低温度"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(212, 196)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 161
        Me.Label24.Text = "设置温度"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDangerClass
        '
        Me.txtDangerClass.Location = New System.Drawing.Point(494, 74)
        Me.txtDangerClass.MaxLength = 20
        Me.txtDangerClass.Name = "txtDangerClass"
        Me.txtDangerClass.Size = New System.Drawing.Size(130, 21)
        Me.txtDangerClass.TabIndex = 176
        Me.txtDangerClass.Text = ""
        '
        'txtOverBack
        '
        Me.txtOverBack.Location = New System.Drawing.Point(494, 50)
        Me.txtOverBack.MaxLength = 20
        Me.txtOverBack.Name = "txtOverBack"
        Me.txtOverBack.Size = New System.Drawing.Size(130, 21)
        Me.txtOverBack.TabIndex = 175
        Me.txtOverBack.Text = ""
        '
        'txtOverFront
        '
        Me.txtOverFront.Location = New System.Drawing.Point(494, 26)
        Me.txtOverFront.MaxLength = 20
        Me.txtOverFront.Name = "txtOverFront"
        Me.txtOverFront.Size = New System.Drawing.Size(130, 21)
        Me.txtOverFront.TabIndex = 174
        Me.txtOverFront.Text = ""
        '
        'txtOverRight
        '
        Me.txtOverRight.Location = New System.Drawing.Point(494, 2)
        Me.txtOverRight.MaxLength = 20
        Me.txtOverRight.Name = "txtOverRight"
        Me.txtOverRight.Size = New System.Drawing.Size(130, 21)
        Me.txtOverRight.TabIndex = 173
        Me.txtOverRight.Text = ""
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(420, 74)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 18)
        Me.Label25.TabIndex = 172
        Me.Label25.Text = "危险品分类"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(420, 52)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 171
        Me.Label26.Text = "后超"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(420, 28)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 18)
        Me.Label27.TabIndex = 170
        Me.Label27.Text = "前超"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(420, 4)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 18)
        Me.Label28.TabIndex = 169
        Me.Label28.Text = "右超"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipLinerCode
        '
        Me.txtShipLinerCode.Location = New System.Drawing.Point(494, 170)
        Me.txtShipLinerCode.MaxLength = 20
        Me.txtShipLinerCode.Name = "txtShipLinerCode"
        Me.txtShipLinerCode.Size = New System.Drawing.Size(130, 21)
        Me.txtShipLinerCode.TabIndex = 184
        Me.txtShipLinerCode.Text = ""
        '
        'txtDangerMark
        '
        Me.txtDangerMark.Location = New System.Drawing.Point(494, 146)
        Me.txtDangerMark.MaxLength = 20
        Me.txtDangerMark.Name = "txtDangerMark"
        Me.txtDangerMark.Size = New System.Drawing.Size(130, 21)
        Me.txtDangerMark.TabIndex = 183
        Me.txtDangerMark.Text = ""
        '
        'txtDangerNo
        '
        Me.txtDangerNo.Location = New System.Drawing.Point(494, 122)
        Me.txtDangerNo.MaxLength = 20
        Me.txtDangerNo.Name = "txtDangerNo"
        Me.txtDangerNo.Size = New System.Drawing.Size(130, 21)
        Me.txtDangerNo.TabIndex = 182
        Me.txtDangerNo.Text = ""
        '
        'txtDangerPage
        '
        Me.txtDangerPage.Location = New System.Drawing.Point(494, 98)
        Me.txtDangerPage.MaxLength = 20
        Me.txtDangerPage.Name = "txtDangerPage"
        Me.txtDangerPage.Size = New System.Drawing.Size(130, 21)
        Me.txtDangerPage.TabIndex = 181
        Me.txtDangerPage.Text = ""
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(420, 172)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 18)
        Me.Label29.TabIndex = 180
        Me.Label29.Text = "箱公司代码"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(420, 148)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 18)
        Me.Label30.TabIndex = 179
        Me.Label30.Text = "危险品标签"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(420, 124)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 18)
        Me.Label31.TabIndex = 178
        Me.Label31.Text = "联合国编号"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(420, 100)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 177
        Me.Label32.Text = "危险品页号"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKind
        '
        Me.txtKind.Location = New System.Drawing.Point(494, 266)
        Me.txtKind.MaxLength = 20
        Me.txtKind.Name = "txtKind"
        Me.txtKind.Size = New System.Drawing.Size(130, 21)
        Me.txtKind.TabIndex = 192
        Me.txtKind.Text = ""
        '
        'txtKeeper
        '
        Me.txtKeeper.Location = New System.Drawing.Point(494, 242)
        Me.txtKeeper.MaxLength = 20
        Me.txtKeeper.Name = "txtKeeper"
        Me.txtKeeper.Size = New System.Drawing.Size(130, 21)
        Me.txtKeeper.TabIndex = 191
        Me.txtKeeper.Text = ""
        '
        'txtKeeperCode
        '
        Me.txtKeeperCode.Location = New System.Drawing.Point(494, 218)
        Me.txtKeeperCode.MaxLength = 20
        Me.txtKeeperCode.Name = "txtKeeperCode"
        Me.txtKeeperCode.Size = New System.Drawing.Size(130, 21)
        Me.txtKeeperCode.TabIndex = 190
        Me.txtKeeperCode.Text = ""
        '
        'txtShipLiner
        '
        Me.txtShipLiner.Location = New System.Drawing.Point(494, 194)
        Me.txtShipLiner.MaxLength = 20
        Me.txtShipLiner.Name = "txtShipLiner"
        Me.txtShipLiner.Size = New System.Drawing.Size(130, 21)
        Me.txtShipLiner.TabIndex = 189
        Me.txtShipLiner.Text = ""
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(420, 266)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 18)
        Me.Label33.TabIndex = 188
        Me.Label33.Text = "箱类别"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(420, 244)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 18)
        Me.Label34.TabIndex = 187
        Me.Label34.Text = "箱经营人"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(416, 220)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(80, 18)
        Me.Label35.TabIndex = 186
        Me.Label35.Text = "箱经营人代码"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(420, 196)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 18)
        Me.Label36.TabIndex = 185
        Me.Label36.Text = "箱公司"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(494, 290)
        Me.txtType.MaxLength = 20
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(130, 21)
        Me.txtType.TabIndex = 199
        Me.txtType.Text = ""
        '
        'txtOverLeft
        '
        Me.txtOverLeft.Location = New System.Drawing.Point(288, 290)
        Me.txtOverLeft.MaxLength = 20
        Me.txtOverLeft.Name = "txtOverLeft"
        Me.txtOverLeft.Size = New System.Drawing.Size(130, 21)
        Me.txtOverLeft.TabIndex = 198
        Me.txtOverLeft.Text = ""
        '
        'txtUnLoadPortCode
        '
        Me.txtUnLoadPortCode.Location = New System.Drawing.Point(78, 290)
        Me.txtUnLoadPortCode.MaxLength = 20
        Me.txtUnLoadPortCode.Name = "txtUnLoadPortCode"
        Me.txtUnLoadPortCode.Size = New System.Drawing.Size(130, 21)
        Me.txtUnLoadPortCode.TabIndex = 197
        Me.txtUnLoadPortCode.Text = ""
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(420, 292)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(72, 18)
        Me.Label38.TabIndex = 195
        Me.Label38.Text = "箱型代码"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(212, 292)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(72, 18)
        Me.Label39.TabIndex = 194
        Me.Label39.Text = "左超"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(4, 292)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(72, 18)
        Me.Label40.TabIndex = 193
        Me.Label40.Text = "卸货港代码"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmEDIRead_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(626, 341)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtType, Me.txtOverLeft, Me.txtUnLoadPortCode, Me.Label38, Me.Label39, Me.Label40, Me.txtKind, Me.txtKeeper, Me.txtKeeperCode, Me.txtShipLiner, Me.Label33, Me.Label34, Me.Label35, Me.Label36, Me.txtShipLinerCode, Me.txtDangerMark, Me.txtDangerNo, Me.txtDangerPage, Me.Label29, Me.Label30, Me.Label31, Me.Label32, Me.txtDangerClass, Me.txtOverBack, Me.txtOverFront, Me.txtOverRight, Me.Label25, Me.Label26, Me.Label27, Me.Label28, Me.txtOverHeight, Me.txtTempMax, Me.txtTempMin, Me.txtTempSet, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.txtTempUnit, Me.txtVolumn, Me.txtTareWeight, Me.txtGrossWeight, Me.Label17, Me.Label18, Me.Label19, Me.Label20, Me.txtAmount, Me.txtDelivery, Me.txtDeliveryCode, Me.txtUnLoadPort, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.txtLoadPort, Me.txtLoadPortCode, Me.txtMark, Me.txtGoodsCHA, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.txtGoodsEng, Me.txtCodeGoods, Me.txtBLNO, Me.txtBay, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.txtSeal, Me.txtStatu, Me.txtSize, Me.txtNO, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.btQuit, Me.btResume, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEDIRead_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "船舶报文信息_编辑"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String

        Me.StartPosition = FormStartPosition.CenterScreen

        sqlstr = "select * from Con_Image_Record where CON_IMAGE_RECORD_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ID
            txtNO.Text = ds.Tables(0).Rows(0).Item("Container_No")
            txtSize.Text = ds.Tables(0).Rows(0).Item("Size_Con")
            txtStatu.Text = ds.Tables(0).Rows(0).Item("FULLOREMPTY")
            txtSeal.Text = ds.Tables(0).Rows(0).Item("SEALNO")
            txtBay.Text = ds.Tables(0).Rows(0).Item("BAYNO")
            txtBLNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
            txtMark.Text = ds.Tables(0).Rows(0).Item("Mark")
            txtKind.Text = ds.Tables(0).Rows(0).Item("CODE_CON_KIND")
            txtType.Text = ds.Tables(0).Rows(0).Item("CODE_CON_Type")
            txtCodeGoods.Text = ds.Tables(0).Rows(0).Item("CODE_GOODS")
            txtGoodsEng.Text = ds.Tables(0).Rows(0).Item("Goods_Eng")
            txtGoodsCHA.Text = ds.Tables(0).Rows(0).Item("Goods_Cha")
            txtLoadPortCode.Text = ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
            txtLoadPort.Text = ds.Tables(0).Rows(0).Item("LOAD_PORT")
            txtUnLoadPortCode.Text = ds.Tables(0).Rows(0).Item("Code_unLOAD_PORT")
            txtUnLoadPort.Text = ds.Tables(0).Rows(0).Item("unLOAD_PORT")
            txtDeliveryCode.Text = ds.Tables(0).Rows(0).Item("CODE_DELIVERY")
            txtDelivery.Text = ds.Tables(0).Rows(0).Item("DELIVERY")
            txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            txtGrossWeight.Text = ds.Tables(0).Rows(0).Item("GrossWEIGHT")
            txtTareWeight.Text = ds.Tables(0).Rows(0).Item("TareWeight")
            txtVolumn.Text = ds.Tables(0).Rows(0).Item("VOLUME")
            txtTempUnit.Text = ds.Tables(0).Rows(0).Item("TEMPERATURE_UNIT")
            txtTempSet.Text = ds.Tables(0).Rows(0).Item("TEMPERATURE_SETTING")
            txtTempMax.Text = ds.Tables(0).Rows(0).Item("MAX_TEMPERATURE")
            txtTempMin.Text = ds.Tables(0).Rows(0).Item("MIN_TEMPERATURE")
            txtOverHeight.Text = ds.Tables(0).Rows(0).Item("OVER_HEIGHT")
            txtOverLeft.Text = ds.Tables(0).Rows(0).Item("OVER_LEFT")
            txtOverRight.Text = ds.Tables(0).Rows(0).Item("OVER_Right")
            txtOverFront.Text = ds.Tables(0).Rows(0).Item("OVER_BEFORE")
            txtOverBack.Text = ds.Tables(0).Rows(0).Item("OVER_Behind")
            txtDangerClass.Text = ds.Tables(0).Rows(0).Item("DANGER_GRADE")
            txtDangerPage.Text = ds.Tables(0).Rows(0).Item("DANGER_PAGENO")
            txtDangerNo.Text = ds.Tables(0).Rows(0).Item("DANGER_NO")
            txtDangerMark.Text = ds.Tables(0).Rows(0).Item("DANGER_MARK")
            txtShipLinerCode.Text = ds.Tables(0).Rows(0).Item("CODE_MANUFACTURER")
            txtShipLiner.Text = ds.Tables(0).Rows(0).Item("MANUFACTURER")
            txtKeeperCode.Text = ds.Tables(0).Rows(0).Item("CODE_KEEPER")
            txtKeeper.Text = ds.Tables(0).Rows(0).Item("KEEPER")
        End If
        txtNO.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResume.Click
        Try
            If MsgBox("你确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                Call OperateHistory(G_DeptName, Now, G_User, "修改", "Con_Image_Record", Trim(txtID.Text), "CON_IMAGE_RECORD_ID")

                ds.Tables(0).Rows(0).Item("Container_No") = txtNO.Text
                If Len(Trim(txtSize.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("Size_Con") = CType(Trim(txtSize.Text), Int32)
                End If
                ds.Tables(0).Rows(0).Item("FULLOREMPTY") = Trim(txtStatu.Text)
                ds.Tables(0).Rows(0).Item("SEALNO") = Trim(txtSeal.Text)
                ds.Tables(0).Rows(0).Item("BAYNO") = Trim(txtBay.Text)
                ds.Tables(0).Rows(0).Item("BLNO") = Trim(txtBLNO.Text)
                ds.Tables(0).Rows(0).Item("Mark") = Trim(txtMark.Text)
                ds.Tables(0).Rows(0).Item("CODE_CON_KIND") = Trim(txtKind.Text)
                ds.Tables(0).Rows(0).Item("CODE_CON_Type") = Trim(txtType.Text)
                ds.Tables(0).Rows(0).Item("CODE_GOODS") = Trim(txtCodeGoods.Text)
                ds.Tables(0).Rows(0).Item("Goods_Eng") = Trim(txtGoodsEng.Text)
                ds.Tables(0).Rows(0).Item("Goods_Cha") = Trim(txtGoodsCHA.Text)
                ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT") = Trim(txtLoadPortCode.Text)
                ds.Tables(0).Rows(0).Item("LOAD_PORT") = Trim(txtLoadPort.Text)
                ds.Tables(0).Rows(0).Item("Code_unLOAD_PORT") = Trim(txtUnLoadPortCode.Text)
                ds.Tables(0).Rows(0).Item("unLOAD_PORT") = Trim(txtUnLoadPort.Text)
                ds.Tables(0).Rows(0).Item("CODE_DELIVERY") = Trim(txtDeliveryCode.Text)
                ds.Tables(0).Rows(0).Item("DELIVERY") = Trim(txtDelivery.Text)
                If Len(Trim(txtAmount.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("AMOUNT") = CType(Trim(txtAmount.Text), Int32)
                End If
                If Len(Trim(txtGrossWeight.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("GrossWEIGHT") = CType(Trim(txtGrossWeight.Text), Double)
                End If
                If Len(Trim(txtTareWeight.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("TareWeight") = CType(Trim(txtTareWeight.Text), Double)
                End If
                If Len(Trim(txtVolumn.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("VOLUME") = CType(Trim(txtVolumn.Text), Double)
                End If
                ds.Tables(0).Rows(0).Item("TEMPERATURE_UNIT") = Trim(txtTempUnit.Text)
                If Len(Trim(txtTempSet.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("TEMPERATURE_SETTING") = CType(Trim(txtTempSet.Text), Double)
                End If
                If Len(Trim(txtTempMax.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("MAX_TEMPERATURE") = CType(Trim(txtTempMax.Text), Double)
                End If
                If Len(Trim(txtTempMin.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("MIN_TEMPERATURE") = CType(Trim(txtTempMin.Text), Double)
                End If
                If Len(Trim(txtOverHeight.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("OVER_HEIGHT") = CType(Trim(txtOverHeight.Text), Double)
                End If
                If Len(Trim(txtOverLeft.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("OVER_LEFT") = CType(Trim(txtOverLeft.Text), Double)
                End If
                If Len(Trim(txtOverRight.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("OVER_Right") = CType(Trim(txtOverRight.Text), Double)
                End If
                If Len(Trim(txtOverFront.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("OVER_BEFORE") = CType(Trim(txtOverFront.Text), Double)
                End If
                If Len(Trim(txtOverBack.Text)) > 0 Then
                    ds.Tables(0).Rows(0).Item("OVER_Behind") = CType(Trim(txtOverBack.Text), Double)
                End If
                ds.Tables(0).Rows(0).Item("DANGER_GRADE") = Trim(txtDangerClass.Text)
                ds.Tables(0).Rows(0).Item("DANGER_PAGENO") = Trim(txtDangerPage.Text)

            ds.Tables(0).Rows(0).Item("DANGER_NO") = Trim(txtDangerNo.Text)
            ds.Tables(0).Rows(0).Item("DANGER_MARK") = Trim(txtDangerMark.Text)
            ds.Tables(0).Rows(0).Item("CODE_MANUFACTURER") = Trim(txtShipLinerCode.Text)
            ds.Tables(0).Rows(0).Item("MANUFACTURER") = Trim(txtShipLiner.Text)
            ds.Tables(0).Rows(0).Item("CODE_KEEPER") = Trim(txtKeeperCode.Text)
            ds.Tables(0).Rows(0).Item("KEEPER") = Trim(txtKeeper.Text)

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
