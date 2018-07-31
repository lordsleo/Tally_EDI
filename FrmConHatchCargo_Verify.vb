Imports TALLY.DBControl
Public Class FrmConHatchCargo_Verify
    Inherits System.Windows.Forms.Form

    Dim sqlHatch, sqlImage As String
    Dim dvHatch As New DataView()
    Dim dvImage As New DataView

    Dim dsHatch As New DataSet
    Dim dsImage As New DataSet

    Dim sqlHatchTemp, sqlImageTemp As String
    Dim dvHatchTemp As New DataView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Dim dvImageTemp As New DataView
    ''' <summary>
    ''' 船舶内外贸标志
    ''' </summary>
    ''' <remarks></remarks>
    Public strShipTrade As String

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents C1DBGB As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBGP As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnSingleLeft As System.Windows.Forms.Button
    Friend WithEvents btnTotalLeft As System.Windows.Forms.Button
    Friend WithEvents btnSingleRight As System.Windows.Forms.Button
    Friend WithEvents btnTotalRight As System.Windows.Forms.Button
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConHatchCargo_Verify))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.C1DBGB = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1DBGP = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnSingleLeft = New System.Windows.Forms.Button
        Me.btnTotalLeft = New System.Windows.Forms.Button
        Me.btnSingleRight = New System.Windows.Forms.Button
        Me.btnTotalRight = New System.Windows.Forms.Button
        Me.btQuit = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.C1DBGB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBGP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "舱单中多出箱信息"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(476, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "船图中多出箱信息 (提单号可改）"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C1DBGB
        '
        Me.C1DBGB.AllowFilter = False
        Me.C1DBGB.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGB.AllowUpdate = False
        Me.C1DBGB.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGB.Images.Add(CType(resources.GetObject("C1DBGB.Images"), System.Drawing.Image))
        Me.C1DBGB.Location = New System.Drawing.Point(2, 30)
        Me.C1DBGB.Name = "C1DBGB"
        Me.C1DBGB.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGB.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGB.PreviewInfo.ZoomFactor = 75
        Me.C1DBGB.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGB.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGB.Size = New System.Drawing.Size(410, 200)
        Me.C1DBGB.TabIndex = 11
        Me.C1DBGB.Text = "C1DBGB"
        Me.C1DBGB.PropBag = resources.GetString("C1DBGB.PropBag")
        '
        'C1DBGP
        '
        Me.C1DBGP.AllowFilter = False
        Me.C1DBGP.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGP.AllowUpdate = False
        Me.C1DBGP.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGP.Images.Add(CType(resources.GetObject("C1DBGP.Images"), System.Drawing.Image))
        Me.C1DBGP.Location = New System.Drawing.Point(482, 30)
        Me.C1DBGP.Name = "C1DBGP"
        Me.C1DBGP.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGP.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGP.PreviewInfo.ZoomFactor = 75
        Me.C1DBGP.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGP.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGP.Size = New System.Drawing.Size(410, 200)
        Me.C1DBGP.TabIndex = 12
        Me.C1DBGP.Text = "C1DBGP"
        Me.C1DBGP.PropBag = resources.GetString("C1DBGP.PropBag")
        '
        'btnSingleLeft
        '
        Me.btnSingleLeft.Location = New System.Drawing.Point(419, 48)
        Me.btnSingleLeft.Name = "btnSingleLeft"
        Me.btnSingleLeft.Size = New System.Drawing.Size(55, 24)
        Me.btnSingleLeft.TabIndex = 13
        Me.btnSingleLeft.Text = ">"
        '
        'btnTotalLeft
        '
        Me.btnTotalLeft.Location = New System.Drawing.Point(419, 146)
        Me.btnTotalLeft.Name = "btnTotalLeft"
        Me.btnTotalLeft.Size = New System.Drawing.Size(55, 24)
        Me.btnTotalLeft.TabIndex = 14
        Me.btnTotalLeft.Text = ">>"
        '
        'btnSingleRight
        '
        Me.btnSingleRight.Location = New System.Drawing.Point(419, 86)
        Me.btnSingleRight.Name = "btnSingleRight"
        Me.btnSingleRight.Size = New System.Drawing.Size(55, 24)
        Me.btnSingleRight.TabIndex = 15
        Me.btnSingleRight.Text = "<"
        '
        'btnTotalRight
        '
        Me.btnTotalRight.Location = New System.Drawing.Point(419, 186)
        Me.btnTotalRight.Name = "btnTotalRight"
        Me.btnTotalRight.Size = New System.Drawing.Size(55, 24)
        Me.btnTotalRight.TabIndex = 16
        Me.btnTotalRight.Text = "<< "
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(415, 236)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 621
        Me.btQuit.Text = "关闭"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(2, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(408, 23)
        Me.Label3.TabIndex = 622
        Me.Label3.Text = "注1：仅校验本港装卸箱号。茶色表示箱号存在却不是本港装卸，不可操作"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(486, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(400, 23)
        Me.Label4.TabIndex = 623
        Me.Label4.Text = "注2：外贸船船图多出箱校验至舱单为内贸"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmConHatchCargo_Verify
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(894, 263)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btnTotalRight)
        Me.Controls.Add(Me.btnSingleRight)
        Me.Controls.Add(Me.btnTotalLeft)
        Me.Controls.Add(Me.btnSingleLeft)
        Me.Controls.Add(Me.C1DBGP)
        Me.Controls.Add(Me.C1DBGB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConHatchCargo_Verify"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱舱单船图校验"
        CType(Me.C1DBGB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBGP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConHatchCargo_Verify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim dvHatch As New DataView()
        Try
            If FrmConHatchCargo.InOutCode = "0" Then    '进口 卸港是连云港的 
                sqlHatchTemp = "SELECT CON_HATCH_RECORD_ID, CON_HATCH_LIST_ID, BLNO, LOAD_PORT, UNLOAD_PORT, CONTAINER_NO, EFL_Name, SEALNO, BAYNO FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_UNLOAD_PORT LIKE '%LYG%' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "') order by BLNO, CONTAINER_NO "
                sqlImageTemp = "SELECT ID, OVER_Height, CONTAINER_NO, EFL_Name, SEALNO, BAYNO, BLNO, Load_Port, Unload_Port FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_UNLOAD_PORT LIKE '%LYG%' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "') order by CONTAINER_NO, BLNO "
            ElseIf FrmConHatchCargo.InOutCode = "1" Then    '出口   装港是连云港的
                sqlHatchTemp = "SELECT CON_HATCH_RECORD_ID, CON_HATCH_LIST_ID, BLNO, LOAD_PORT, UNLOAD_PORT, CONTAINER_NO, EFL_Name, SEALNO, BAYNO FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_LOAD_PORT LIKE '%LYG%' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "') order by BLNO, CONTAINER_NO "
                sqlImageTemp = "SELECT ID, OVER_Height, CONTAINER_NO, EFL_Name, SEALNO, BAYNO, BLNO, Load_Port, Unload_Port FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_LOAD_PORT LIKE '%LYG%' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "') order by CONTAINER_NO, BLNO "
            Else    '进出口为空 找出所有多出来的
                sqlHatchTemp = "SELECT CON_HATCH_RECORD_ID, CON_HATCH_LIST_ID, BLNO, LOAD_PORT, UNLOAD_PORT, CONTAINER_NO, EFL_Name, SEALNO, BAYNO FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "')"
                sqlImageTemp = "SELECT ID, OVER_Height, CONTAINER_NO, EFL_Name, SEALNO, BAYNO, BLNO, Load_Port, Unload_Port FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "')"
            End If

            If FrmConHatchCargo.InOutCode = "0" Then    '进口 卸港是连云港的
                sqlHatch = "SELECT CON_HATCH_RECORD_ID, CON_HATCH_LIST_ID, BLNO, LOAD_PORT, UNLOAD_PORT, CONTAINER_NO, EFL_Name, SEALNO, BAYNO FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_UNLOAD_PORT LIKE '%LYG%' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_UNLOAD_PORT LIKE '%LYG%') order by BLNO, CONTAINER_NO "
                sqlImage = "SELECT ID, OVER_Height, CONTAINER_NO, EFL_Name, SEALNO, BAYNO, BLNO, Load_Port, Unload_Port FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_UNLOAD_PORT LIKE '%LYG%' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_UNLOAD_PORT LIKE '%LYG%') order by CONTAINER_NO, BLNO "
            ElseIf FrmConHatchCargo.InOutCode = "1" Then    '出口   装港是连云港的
                sqlHatch = "SELECT CON_HATCH_RECORD_ID, CON_HATCH_LIST_ID, BLNO, LOAD_PORT, UNLOAD_PORT, CONTAINER_NO, EFL_Name, SEALNO, BAYNO FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_LOAD_PORT LIKE '%LYG%' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_LOAD_PORT LIKE '%LYG%') order by BLNO, CONTAINER_NO "
                sqlImage = "SELECT ID, OVER_Height, CONTAINER_NO, EFL_Name, SEALNO, BAYNO, BLNO, Load_Port, Unload_Port FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_LOAD_PORT LIKE '%LYG%' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_LOAD_PORT LIKE '%LYG%') order by CONTAINER_NO, BLNO "
            Else    '进出口为空 找出所有多出来的
                sqlHatch = "SELECT CON_HATCH_RECORD_ID, CON_HATCH_LIST_ID, BLNO, LOAD_PORT, UNLOAD_PORT, CONTAINER_NO, EFL_Name, SEALNO, BAYNO FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "')"
                sqlImage = "SELECT ID, OVER_Height, CONTAINER_NO, EFL_Name, SEALNO, BAYNO, BLNO, Load_Port, Unload_Port FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "')"
            End If
            Call UpdateC1DBGB()
            Call UpdateC1DBGP()
            Call CompDeal()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CompDeal()
        dvHatchTemp = Filldata(sqlHatchTemp)
        dvImageTemp = Filldata(sqlImageTemp)
        Dim i, j As Integer
        If dvHatch.Count = dvHatchTemp.Count Then
            For i = 0 To dvHatch.Count - 1
                dvHatch(i)("Temp") = 0
            Next
        Else
            For i = 0 To dvHatch.Count - 1
                For j = 0 To dvHatchTemp.Count - 1
                    If dvHatch(i)("CON_HATCH_RECORD_ID") = dvHatchTemp(j)("CON_HATCH_RECORD_ID") Then
                        dvHatch(i)("Temp") = 0
                        Exit For
                    End If
                Next
                If j >= dvHatchTemp.Count Then  '在dvHatchTemp中找不到该箱号，标记不可导
                    dvHatch(i)("Temp") = 1
                End If
            Next
        End If

        If dvImage.Count = dvImageTemp.Count Then
            For i = 0 To dvImage.Count - 1
                dvImage(i)("Temp") = 0
            Next
        Else
            For i = 0 To dvImage.Count - 1
                For j = 0 To dvImageTemp.Count - 1
                    If dvImage(i)("CONTAINER_NO") = dvImageTemp(j)("CONTAINER_NO") Then
                        dvImage(i)("Temp") = 0
                        Exit For
                    End If
                Next
                If j >= dvImageTemp.Count Then
                    dvImage(i)("Temp") = 1
                End If
            Next
        End If
    End Sub

    Private Sub UpdateC1DBGB()
        dvHatch = Getdata(sqlHatch, dsHatch)
        dsHatch.Tables(0).Columns.Add("Temp", GetType(Integer))
        dsHatch.Tables(0).Columns("Temp").DefaultValue = 0
        Me.C1DBGB.DataSource = dvHatch

        Me.C1DBGB.Columns("BLNO").Caption = "提单号"
        Me.C1DBGB.Columns("LOAD_PORT").Caption = "装货港"
        Me.C1DBGB.Columns("UNLOAD_PORT").Caption = "卸货港"
        Me.C1DBGB.Columns("CONTAINER_NO").Caption = "集装箱号"
        Me.C1DBGB.Columns("EFL_Name").Caption = "箱状态"
        Me.C1DBGB.Columns("SEALNO").Caption = "铅封号"
        Me.C1DBGB.Columns("BAYNO").Caption = "贝位号"

        Me.C1DBGB.Splits(0).DisplayColumns("BLNO").Width = 90
        Me.C1DBGB.Splits(0).DisplayColumns("LOAD_PORT").Width = 60
        Me.C1DBGB.Splits(0).DisplayColumns("UNLOAD_PORT").Width = 60
        Me.C1DBGB.Splits(0).DisplayColumns("CONTAINER_NO").Width = 90
        Me.C1DBGB.Splits(0).DisplayColumns("EFL_Name").Width = 30
        Me.C1DBGB.Splits(0).DisplayColumns("SEALNO").Width = 70
        Me.C1DBGB.Splits(0).DisplayColumns("BAYNO").Width = 45

        Me.C1DBGB.Splits(0).DisplayColumns("CON_HATCH_RECORD_ID").Visible = False
        Me.C1DBGB.Splits(0).DisplayColumns("CON_HATCH_LIST_ID").Visible = False
        Me.C1DBGB.Splits(0).DisplayColumns("Temp").Visible = False
        Me.C1DBGB.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBGB.ColumnFooters = True
        Me.C1DBGB.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGB.Columns.Item("BLNO").FooterText = "共" & dvHatch.Count & "个"
        Me.C1DBGB.FetchRowStyles = True
    End Sub

    Private Sub UpdateC1DBGP()
        dvImage = Getdata(sqlImage, dsImage)
        dsImage.Tables(0).Columns.Add("Temp", GetType(Integer))
        dsImage.Tables(0).Columns("Temp").DefaultValue = 0
        Me.C1DBGP.DataSource = dvImage

        Me.C1DBGP.Columns("CONTAINER_NO").Caption = "集装箱号"
        Me.C1DBGP.Columns("EFL_Name").Caption = "箱状态"
        Me.C1DBGP.Columns("SEALNO").Caption = "铅封号"
        Me.C1DBGP.Columns("BAYNO").Caption = "贝位号"
        Me.C1DBGP.Columns("BLNO").Caption = "提单号"
        Me.C1DBGP.Columns("Load_Port").Caption = "装货港"
        Me.C1DBGP.Columns("Unload_Port").Caption = "卸货港"

        Me.C1DBGP.Splits(0).DisplayColumns("CONTAINER_NO").Width = 90
        Me.C1DBGP.Splits(0).DisplayColumns("EFL_Name").Width = 30
        Me.C1DBGP.Splits(0).DisplayColumns("SEALNO").Width = 70
        Me.C1DBGP.Splits(0).DisplayColumns("BAYNO").Width = 45
        Me.C1DBGP.Splits(0).DisplayColumns("BLNO").Width = 90
        Me.C1DBGP.Splits(0).DisplayColumns("Load_Port").Width = 60
        Me.C1DBGP.Splits(0).DisplayColumns("Unload_Port").Width = 60

        Me.C1DBGP.Splits(0).DisplayColumns("ID").Visible = False
        Me.C1DBGP.Splits(0).DisplayColumns("OVER_Height").Visible = False
        Me.C1DBGP.Splits(0).DisplayColumns("Temp").Visible = False
        Me.C1DBGP.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBGP.ColumnFooters = True
        Me.C1DBGP.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGP.Columns.Item("CONTAINER_NO").FooterText = "共" & dvImage.Count & "个"
        Me.C1DBGP.FetchRowStyles = True

        Me.C1DBGP.AllowUpdate = True
        Me.C1DBGP.Splits(0).DisplayColumns("CONTAINER_NO").Locked = True
        Me.C1DBGP.Splits(0).DisplayColumns("EFL_Name").Locked = True
        Me.C1DBGP.Splits(0).DisplayColumns("SEALNO").Locked = True
        Me.C1DBGP.Splits(0).DisplayColumns("BAYNO").Locked = True
        Me.C1DBGP.Splits(0).DisplayColumns("Load_Port").Locked = True
        Me.C1DBGP.Splits(0).DisplayColumns("Unload_Port").Locked = True

    End Sub

    Private Sub btnSingleLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSingleLeft.Click
        If dvHatch.Count > 0 Then
            If Me.C1DBGB.Columns("Temp").Text = "0" Then
                Dim sqlSLeft As String
                sqlSLeft = "insert into Con_Image(SHIP_ID,CONTAINER_NO,FULLOREMPTY,SEALNO,BAYNO,BLNO,CODE_LOAD_PORT,Load_Port,CODE_UNLOAD_PORT,Unload_Port,CODE_DELIVERY,DELIVERY,AMOUNT,GROSSWEIGHT,VOLUME,TEMPERATURE_UNIT,TEMPERATURE_SETTING,MIN_TEMPERATURE,MAX_TEMPERATURE,DANGER_GRADE,DANGER_PAGENO,DANGER_NO,DANGER_MARK,PASS_MARK,SHORT_UNLOAD,UNLOAD_MARK,USER_NAME,Demo,ConDemo,OLDBAYNO,MOVED,USER_CODE) " & _
                        " SELECT SHIP_ID, CONTAINER_NO, FULLOREMPTY, SEALNO, BAYNO, BLNO, CODE_LOAD_PORT, LOAD_PORT, CODE_UNLOAD_PORT, UNLOAD_PORT, CODE_PLACE_RECEIVE, PLACE_RECEIVE, AMOUNT, WEIGHT, VOLUME, TempUnit, ReeferTemp, NULL, NULL, DangerGrade, DANGER_PAGENO, DANGER_NO, DangerMark, PASS_MARK, SHORT_UNLOAD, Unload_Mark, '" & G_User & "', '', '', '', 0, USER_CODE FROM View_HatchCargoTwo WHERE CON_HATCH_RECORD_ID = '" & Me.C1DBGB.Columns("CON_HATCH_RECORD_ID").Text & "' AND CON_HATCH_LIST_ID = '" & Me.C1DBGB.Columns("CON_HATCH_LIST_ID").Text & "'"
                Try
                    ExecSql(sqlSLeft)
                    Call UpdateC1DBGB()
                    Call UpdateC1DBGP()
                    Call CompDeal()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("该箱信息在船图中已存在，但非本港装卸箱，请检查。", "提示")
            End If
        End If
    End Sub

    Private Sub btnSingleRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSingleRight.Click
        If dvImage.Count > 0 Then
            If Me.C1DBGP.Columns("Temp").Text = "0" Then
                Dim sqlBillExist As String
                Dim dvBillExist As New DataView
                Dim strBillNO As String

                Dim sqlSRightMain, sqlSRightSub, sqlSRightRelation As String

                Dim sqlConInfo As String
                Dim dvConInfo As New DataView

                Try
                    'If Trim(Me.C1DBGP.Columns("BLNO").Text).Length > 0 Or Trim(C1DBGP.Columns("EFL_Name").Text) = "空箱" Then
                    '    If Trim(Me.C1DBGP.Columns("BLNO").Text).Length > 0 Then
                    '        strBillNO = Trim(Me.C1DBGP.Columns("BLNO").Text)
                    '    Else    '空箱无提单号时
                    '        strBillNO = "EMPTY"
                    '    End If
                    'Else
                    '    MessageBox.Show("非空箱没有提单号不能导入舱单", "操作提示")
                    'End If
                    If Trim(Me.C1DBGP.Columns("BLNO").Text).Length > 0 Then
                        strBillNO = Trim(Me.C1DBGP.Columns("BLNO").Text)
                    Else
                        If Trim(C1DBGP.Columns("EFL_Name").Text) = "空箱" Then
                            strBillNO = "EMPTY"  '空箱无提单号时
                        Else
                            strBillNO = "0"     '非空箱无提单号时
                        End If
                    End If
                    sqlBillExist = "SELECT BLNO, MARK, SHIP_ID FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' and  BLNO = '" & strBillNO & "'"
                    dvBillExist = Filldata(sqlBillExist)
                    If dvBillExist.Count = 0 Then
                        If (strShipTrade = "2") Then    '外贸船 多出的提单算内贸
                            sqlSRightMain = "insert into CON_HATCH_LIST(SHIP_ID,BLNO,PRE_SHIPCODE,PRE_SHIPNAME,PRE_VOYAGE,CODE_PLACE_RECEIVE,PLACE_RECEIVE,CODE_LOAD_PORT,LOAD_PORT,CONSIGNMENT_ITEM,LOAD_DATE,EMPTY_MARK,CODE_UNLOAD_PORT,UNLOAD_PORT,MARK,CODE_GOODS,GOODS_ENG,GOODS_CHA,CONTAINER_MARK,CONTAINER,AMOUNT,CODE_PACK,PACK,PIECE_WEIGHT,NETWEIGHT,GROSS_WEIGHT,SIZE_MEASURE,REFRIGERATE_TEMPERATURE,RECEIVER,NOTIFY_PERSON,TEMPERATURE,DANGER_GRADE,DANGER_NO,DANGER_PAGENO,DANGER_MARK,USER_NAME,Report,InOutMark)" & _
                            " SELECT SHIP_ID, '" & strBillNO & "', '', '', '', CODE_DELIVERY, DELIVERY, CODE_LOAD_PORT, Load_Port, '', '" & Now & "', FULLOREMPTY, CODE_UNLOAD_PORT, Unload_Port, 'NO MARK', '0000', '', '', FULLOREMPTY, 1, AMOUNT, '000', '', NULL, isnull(GROSSWEIGHT,0.00) - isnull(CON_WEIGHT,0.00), GROSSWEIGHT, VOLUME, TEMPERATURE_SETTING, '', '', TEMPERATURE_UNIT, DANGER_GRADE, DANGER_NO, DANGER_PAGENO, DANGER_MARK, '" & G_User & "',null,'1' FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").Text & "'"
                        Else
                            sqlSRightMain = "insert into CON_HATCH_LIST(SHIP_ID,BLNO,PRE_SHIPCODE,PRE_SHIPNAME,PRE_VOYAGE,CODE_PLACE_RECEIVE,PLACE_RECEIVE,CODE_LOAD_PORT,LOAD_PORT,CONSIGNMENT_ITEM,LOAD_DATE,EMPTY_MARK,CODE_UNLOAD_PORT,UNLOAD_PORT,MARK,CODE_GOODS,GOODS_ENG,GOODS_CHA,CONTAINER_MARK,CONTAINER,AMOUNT,CODE_PACK,PACK,PIECE_WEIGHT,NETWEIGHT,GROSS_WEIGHT,SIZE_MEASURE,REFRIGERATE_TEMPERATURE,RECEIVER,NOTIFY_PERSON,TEMPERATURE,DANGER_GRADE,DANGER_NO,DANGER_PAGENO,DANGER_MARK,USER_NAME,Report)" & _
                            " SELECT SHIP_ID, '" & strBillNO & "', '', '', '', CODE_DELIVERY, DELIVERY, CODE_LOAD_PORT, Load_Port, '', '" & Now & "', FULLOREMPTY, CODE_UNLOAD_PORT, Unload_Port, 'NO MARK', '0000', '', '', FULLOREMPTY, 1, AMOUNT, '000', '', NULL, isnull(GROSSWEIGHT,0.00) - isnull(CON_WEIGHT,0.00), GROSSWEIGHT, VOLUME, TEMPERATURE_SETTING, '', '', TEMPERATURE_UNIT, DANGER_GRADE, DANGER_NO, DANGER_PAGENO, DANGER_MARK, '" & G_User & "',null FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").Text & "'"
                        End If
                        sqlSRightRelation = "insert into CON_HATCH_CARGO(SHIP_ID,BLNO,CONTAINER_NO,mark,AMOUNT,NETWEIGHT,TOTAL_WEIGHT,USER_NAME)" & _
                            " SELECT SHIP_ID, '" & strBillNO & "', CONTAINER_NO, 'NO MARK', NULL, NULL, NULL, '" & G_User & "' FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").Text & "'"
                    Else
                        sqlConInfo = "SELECT ISNULL(AMOUNT, 0) AS AMOUNT, ISNULL(GROSSWEIGHT, 0.00) AS GROSSWEIGHT, ISNULL(CON_WEIGHT, 0.00) AS CON_WEIGHT  FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").Text & "'"
                        dvConInfo = Filldata(sqlConInfo)
                        If dvConInfo.Count = 1 Then     '船图中有且仅有一条箱信息
                            'sqlSRightMain = "update CON_HATCH_LIST set CONTAINER = CONTAINER + 1, AMOUNT = AMOUNT + '" & dvConInfo(0)("AMOUNT") & "', GROSS_WEIGHT = GROSS_WEIGHT + '" & dvConInfo(0)("GROSSWEIGHT") & "', NETWEIGHT= NETWEIGHT + '" & dvConInfo(0)("GROSSWEIGHT") - dvConInfo(0)("CON_WEIGHT") & "' where SHIP_ID = '" & Ship_ID & "' and BLNO = '" & dvBillExist(0)("BLNO") & "' and Mark = '" & dvBillExist(0)("Mark") & "'"
                            sqlSRightMain = "update CON_HATCH_LIST set CONTAINER = isnull(CONTAINER,0) + 1, AMOUNT = isnull(AMOUNT,0) + '" & dvConInfo(0)("AMOUNT") & "', GROSS_WEIGHT = isnull(GROSS_WEIGHT,0.00) + '" & dvConInfo(0)("GROSSWEIGHT") & "', NETWEIGHT= isnull(NETWEIGHT,0.00) + '" & dvConInfo(0)("GROSSWEIGHT") - dvConInfo(0)("CON_WEIGHT") & "' where SHIP_ID = '" & Ship_ID & "' and BLNO = '" & dvBillExist(0)("BLNO") & "'"
                        Else
                            'sqlSRightMain = "update CON_HATCH_LIST set CONTAINER = CONTAINER + 1 where SHIP_ID = '" & Ship_ID & "' and BLNO = '" & dvBillExist(0)("BLNO") & "' and Mark = '" & dvBillExist(0)("Mark") & "'"
                            sqlSRightMain = "update CON_HATCH_LIST set CONTAINER = isnull(CONTAINER,0) + 1 where SHIP_ID = '" & Ship_ID & "' and BLNO = '" & dvBillExist(0)("BLNO") & "'"
                        End If
                        sqlSRightRelation = "insert into CON_HATCH_CARGO(SHIP_ID,BLNO,CONTAINER_NO,mark,AMOUNT,NETWEIGHT,TOTAL_WEIGHT,USER_NAME)" & _
                                " SELECT SHIP_ID, '" & strBillNO & "', CONTAINER_NO, '" & dvBillExist(0)("Mark") & "', NULL, NULL, NULL, '" & G_User & "' FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").Text & "'"
                    End If

                    If Me.C1DBGP.Columns("OVER_Height").Text = "" Or Me.C1DBGP.Columns("OVER_Height").Text = "0" Then   '箱高正常
                        sqlSRightSub = "insert into CON_HATCH_RECORD(SHIP_ID,CONTAINER_NO,SEALNO,SealCheck,SIZE_CON,CONTAINER_TYPE,OVER_HEIGHT,FULLOREMPTY,BAYNO,BLNO,CODE_GOODS,AMOUNT,WEIGHT,VOLUME,Code_MANUFACTURER,MANUFACTURER,CODE_KEEPER,KEEPER,ReeferTemp,TempUnit,DangerGrade,DangerMark,POSITION_CONTAINER,PASS_MARK,SHORT_UNLOAD,Unload_Mark,USER_NAME,USER_CODE) " & _
                            " SELECT SHIP_ID, CONTAINER_NO, SEALNO, null, SIZE_CON, CONTAINER_TYPE, '0', FULLOREMPTY, BAYNO, null, null, AMOUNT, GROSSWEIGHT, VOLUME, Code_Con_Company, Con_Company_CHI, '00', '', TEMPERATURE_SETTING,TEMPERATURE_UNIT,DANGER_GRADE,DANGER_MARK, '', PASS_MARK, SHORT_UNLOAD, UNLOAD_MARK, '" & G_User & "', USER_CODE FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").Text & "'"
                    Else    '箱高超高
                        sqlSRightSub = "insert into CON_HATCH_RECORD(SHIP_ID,CONTAINER_NO,SEALNO,SealCheck,SIZE_CON,CONTAINER_TYPE,OVER_HEIGHT,FULLOREMPTY,BAYNO,BLNO,CODE_GOODS,AMOUNT,WEIGHT,VOLUME,Code_MANUFACTURER,MANUFACTURER,CODE_KEEPER,KEEPER,ReeferTemp,TempUnit,DangerGrade,DangerMark,POSITION_CONTAINER,PASS_MARK,SHORT_UNLOAD,Unload_Mark,USER_NAME,USER_CODE) " & _
                            " SELECT SHIP_ID, CONTAINER_NO, SEALNO, null, SIZE_CON, CONTAINER_TYPE, '1', FULLOREMPTY, BAYNO, null, null, AMOUNT, GROSSWEIGHT, VOLUME, Code_Con_Company, Con_Company_CHI, '00', '', TEMPERATURE_SETTING,TEMPERATURE_UNIT,DANGER_GRADE,DANGER_MARK, '', PASS_MARK, SHORT_UNLOAD, UNLOAD_MARK, '" & G_User & "', USER_CODE FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").Text & "'"
                    End If

                    ExecSql(sqlSRightMain)
                    ExecSql(sqlSRightSub)
                    ExecSql(sqlSRightRelation)

                    Dim sqlEditConImage As String   '不管是否修改了提单号都更新舱单表
                    sqlEditConImage = "update con_image set BLNO = '" & Trim(Me.C1DBGP.Columns("BLNO").Text) & "' where CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").Text & "'"
                    ExecSql(sqlEditConImage)

                    Call UpdateC1DBGB()
                    Call UpdateC1DBGP()
                    Call CompDeal()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("该箱信息在舱单中已存在，但非本港装卸箱，请检查。", "提示")
            End If
        End If
    End Sub

    Private Sub btnTotalLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalLeft.Click
        If dvHatch.Count > 0 Then
            Dim sqlTLeft As String
            If FrmConHatchCargo.InOutCode = "0" Then    '进口
                sqlTLeft = "insert into Con_Image(SHIP_ID,CONTAINER_NO,FULLOREMPTY,SEALNO,BAYNO,BLNO,CODE_LOAD_PORT,Load_Port,CODE_UNLOAD_PORT,Unload_Port,CODE_DELIVERY,DELIVERY,AMOUNT,GROSSWEIGHT,VOLUME,TEMPERATURE_UNIT,TEMPERATURE_SETTING,MIN_TEMPERATURE,MAX_TEMPERATURE,DANGER_GRADE,DANGER_PAGENO,DANGER_NO,DANGER_MARK,PASS_MARK,SHORT_UNLOAD,UNLOAD_MARK,USER_NAME,Demo,ConDemo,OLDBAYNO,MOVED,USER_CODE) " & _
                    " SELECT SHIP_ID, CONTAINER_NO, FULLOREMPTY, SEALNO, BAYNO, BLNO, CODE_LOAD_PORT, LOAD_PORT, CODE_UNLOAD_PORT, UNLOAD_PORT, CODE_PLACE_RECEIVE, PLACE_RECEIVE, AMOUNT, WEIGHT, VOLUME, TempUnit, ReeferTemp, NULL, NULL, DangerGrade, DANGER_PAGENO, DANGER_NO, DangerMark, PASS_MARK, SHORT_UNLOAD, Unload_Mark, '" & G_User & "', '', '', '', 0, USER_CODE FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_UNLOAD_PORT LIKE '%LYG%' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "')"
            ElseIf FrmConHatchCargo.InOutCode = "1" Then    '出口
                sqlTLeft = "insert into Con_Image(SHIP_ID,CONTAINER_NO,FULLOREMPTY,SEALNO,BAYNO,BLNO,CODE_LOAD_PORT,Load_Port,CODE_UNLOAD_PORT,Unload_Port,CODE_DELIVERY,DELIVERY,AMOUNT,GROSSWEIGHT,VOLUME,TEMPERATURE_UNIT,TEMPERATURE_SETTING,MIN_TEMPERATURE,MAX_TEMPERATURE,DANGER_GRADE,DANGER_PAGENO,DANGER_NO,DANGER_MARK,PASS_MARK,SHORT_UNLOAD,UNLOAD_MARK,USER_NAME,Demo,ConDemo,OLDBAYNO,MOVED,USER_CODE) " & _
                    " SELECT SHIP_ID, CONTAINER_NO, FULLOREMPTY, SEALNO, BAYNO, BLNO, CODE_LOAD_PORT, LOAD_PORT, CODE_UNLOAD_PORT, UNLOAD_PORT, CODE_PLACE_RECEIVE, PLACE_RECEIVE, AMOUNT, WEIGHT, VOLUME, TempUnit, ReeferTemp, NULL, NULL, DangerGrade, DANGER_PAGENO, DANGER_NO, DangerMark, PASS_MARK, SHORT_UNLOAD, Unload_Mark, '" & G_User & "', '', '', '', 0, USER_CODE FROM View_HatchCargoTwo WHERE SHIP_ID = '" & Ship_ID & "' AND CODE_LOAD_PORT LIKE '%LYG%' AND CONTAINER_NO NOT IN (SELECT CONTAINER_NO FROM View_ConImage WHERE SHIP_ID = '" & Ship_ID & "')"
            End If
            Try
                ExecSql(sqlTLeft)
                Call UpdateC1DBGB()
                Call UpdateC1DBGP()
                Call CompDeal()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnTotalRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalRight.Click
        If dvImage.Count > 0 Then
            Dim sqlBillExist As String
            Dim dvBillExist As New DataView
            Dim strBillNO As String
            Dim i As Integer
            Dim strErr As String = ""
            Dim sqlSRightMain, sqlSRightSub, sqlSRightRelation As String

            Dim sqlConInfo As String
            Dim dvConInfo As New DataView

            Try
                For i = 0 To dvImage.Count - 1  '循环插入每条记录
                    If Me.C1DBGP.Columns("Temp").CellText(i) = "0" Then
                        'If Trim(Me.C1DBGP.Columns("BLNO").CellText(i)).Length > 0 Or Trim(C1DBGP.Columns("EFL_Name").CellText(i)) = "空箱" Then
                        '    If Trim(Me.C1DBGP.Columns("BLNO").CellText(i)).Length > 0 Then
                        '        strBillNO = Trim(Me.C1DBGP.Columns("BLNO").CellText(i))
                        '    Else    '空箱无提单号时
                        '        strBillNO = "EMPTY"
                        '    End If
                        'Else
                        '    If (i + 1) Mod 10 = 0 Then
                        '        strErr = strErr & Me.C1DBGP.Columns("CONTAINER_NO").CellText(i) & Chr(10)
                        '    Else
                        '        strErr = strErr & Me.C1DBGP.Columns("CONTAINER_NO").CellText(i) & " "
                        '    End If
                        'End If
                        If Trim(Me.C1DBGP.Columns("BLNO").CellText(i)).Length > 0 Then
                            strBillNO = Trim(Me.C1DBGP.Columns("BLNO").CellText(i))
                        Else
                            If Trim(C1DBGP.Columns("EFL_Name").CellText(i)) = "空箱" Then
                                strBillNO = "EMPTY"
                            Else
                                strBillNO = "0"
                            End If
                        End If
                        sqlBillExist = "SELECT BLNO, MARK, SHIP_ID FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' and  BLNO = '" & strBillNO & "'"
                        dvBillExist = Filldata(sqlBillExist)
                        If dvBillExist.Count = 0 Then
                            If (strShipTrade = "2") Then    '外贸船 多出的提单算内贸
                                sqlSRightMain = "insert into CON_HATCH_LIST(SHIP_ID,BLNO,PRE_SHIPCODE,PRE_SHIPNAME,PRE_VOYAGE,CODE_PLACE_RECEIVE,PLACE_RECEIVE,CODE_LOAD_PORT,LOAD_PORT,CONSIGNMENT_ITEM,LOAD_DATE,EMPTY_MARK,CODE_UNLOAD_PORT,UNLOAD_PORT,MARK,CODE_GOODS,GOODS_ENG,GOODS_CHA,CONTAINER_MARK,CONTAINER,AMOUNT,CODE_PACK,PACK,PIECE_WEIGHT,NETWEIGHT,GROSS_WEIGHT,SIZE_MEASURE,REFRIGERATE_TEMPERATURE,RECEIVER,NOTIFY_PERSON,TEMPERATURE,DANGER_GRADE,DANGER_NO,DANGER_PAGENO,DANGER_MARK,USER_NAME,Report,InOutMark)" & _
                                " SELECT SHIP_ID, '" & strBillNO & "', '', '', '', CODE_DELIVERY, DELIVERY, CODE_LOAD_PORT, Load_Port, '', '" & Now & "', FULLOREMPTY, CODE_UNLOAD_PORT, Unload_Port, 'NO MARK', '0000', '', '', FULLOREMPTY, 1, AMOUNT, '000', '', NULL, isnull(GROSSWEIGHT,0.00) - isnull(CON_WEIGHT,0.00), GROSSWEIGHT, VOLUME, TEMPERATURE_SETTING, '', '', TEMPERATURE_UNIT, DANGER_GRADE, DANGER_NO, DANGER_PAGENO, DANGER_MARK, '" & G_User & "', null,'1' FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").CellText(i) & "'"
                            Else
                                sqlSRightMain = "insert into CON_HATCH_LIST(SHIP_ID,BLNO,PRE_SHIPCODE,PRE_SHIPNAME,PRE_VOYAGE,CODE_PLACE_RECEIVE,PLACE_RECEIVE,CODE_LOAD_PORT,LOAD_PORT,CONSIGNMENT_ITEM,LOAD_DATE,EMPTY_MARK,CODE_UNLOAD_PORT,UNLOAD_PORT,MARK,CODE_GOODS,GOODS_ENG,GOODS_CHA,CONTAINER_MARK,CONTAINER,AMOUNT,CODE_PACK,PACK,PIECE_WEIGHT,NETWEIGHT,GROSS_WEIGHT,SIZE_MEASURE,REFRIGERATE_TEMPERATURE,RECEIVER,NOTIFY_PERSON,TEMPERATURE,DANGER_GRADE,DANGER_NO,DANGER_PAGENO,DANGER_MARK,USER_NAME,Report)" & _
                                " SELECT SHIP_ID, '" & strBillNO & "', '', '', '', CODE_DELIVERY, DELIVERY, CODE_LOAD_PORT, Load_Port, '', '" & Now & "', FULLOREMPTY, CODE_UNLOAD_PORT, Unload_Port, 'NO MARK', '0000', '', '', FULLOREMPTY, 1, AMOUNT, '000', '', NULL, isnull(GROSSWEIGHT,0.00) - isnull(CON_WEIGHT,0.00), GROSSWEIGHT, VOLUME, TEMPERATURE_SETTING, '', '', TEMPERATURE_UNIT, DANGER_GRADE, DANGER_NO, DANGER_PAGENO, DANGER_MARK, '" & G_User & "', null FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").CellText(i) & "'"
                            End If
                            sqlSRightRelation = "insert into CON_HATCH_CARGO(SHIP_ID,BLNO,CONTAINER_NO,mark,AMOUNT,NETWEIGHT,TOTAL_WEIGHT,USER_NAME)" & _
                                " SELECT SHIP_ID, '" & strBillNO & "', CONTAINER_NO, 'NO MARK', NULL, NULL, NULL, '" & G_User & "' FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").CellText(i) & "'"
                        Else
                            sqlConInfo = "SELECT ISNULL(AMOUNT, 0) AS AMOUNT, ISNULL(GROSSWEIGHT, 0.00) AS GROSSWEIGHT, ISNULL(CON_WEIGHT, 0.00) AS CON_WEIGHT  FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").Text & "'"
                            dvConInfo = Filldata(sqlConInfo)
                            If dvConInfo.Count = 1 Then     '船图中有且仅有一条箱信息
                                'sqlSRightMain = "update CON_HATCH_LIST set CONTAINER = CONTAINER + 1, AMOUNT = AMOUNT + '" & dvConInfo(0)("AMOUNT") & "', GROSS_WEIGHT = GROSS_WEIGHT + '" & dvConInfo(0)("GROSSWEIGHT") & "', NETWEIGHT= NETWEIGHT + '" & dvConInfo(0)("GROSSWEIGHT") - dvConInfo(0)("CON_WEIGHT") & "' where SHIP_ID = '" & Ship_ID & "' and BLNO = '" & dvBillExist(0)("BLNO") & "' and Mark = '" & dvBillExist(0)("Mark") & "'"
                                sqlSRightMain = "update CON_HATCH_LIST set CONTAINER = isnull(CONTAINER,0) + 1, AMOUNT = isnull(AMOUNT,0) + '" & dvConInfo(0)("AMOUNT") & "', GROSS_WEIGHT = isnull(GROSS_WEIGHT,0.00) + '" & dvConInfo(0)("GROSSWEIGHT") & "', NETWEIGHT= isnull(NETWEIGHT,0.00) + '" & dvConInfo(0)("GROSSWEIGHT") - dvConInfo(0)("CON_WEIGHT") & "' where SHIP_ID = '" & Ship_ID & "' and BLNO = '" & dvBillExist(0)("BLNO") & "'"
                            Else
                                'sqlSRightMain = "update CON_HATCH_LIST set CONTAINER = CONTAINER + 1 where SHIP_ID = '" & Ship_ID & "' and BLNO = '" & dvBillExist(0)("BLNO") & "' and Mark = '" & dvBillExist(0)("Mark") & "'"
                                sqlSRightMain = "update CON_HATCH_LIST set CONTAINER = isnull(CONTAINER,0) + 1 where SHIP_ID = '" & Ship_ID & "' and BLNO = '" & dvBillExist(0)("BLNO") & "'"
                            End If
                            sqlSRightRelation = "insert into CON_HATCH_CARGO(SHIP_ID,BLNO,CONTAINER_NO,mark,AMOUNT,NETWEIGHT,TOTAL_WEIGHT,USER_NAME)" & _
                                " SELECT SHIP_ID, '" & strBillNO & "', CONTAINER_NO, '" & dvBillExist(0)("Mark") & "', NULL, NULL, NULL, '" & G_User & "' FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").CellText(i) & "'"
                        End If

                        If Me.C1DBGP.Columns("OVER_Height").Text = "" Or Me.C1DBGP.Columns("OVER_Height").Text = "0" Then   '箱高正常
                            sqlSRightSub = "insert into CON_HATCH_RECORD(SHIP_ID,CONTAINER_NO,SEALNO,SealCheck,SIZE_CON,CONTAINER_TYPE,OVER_HEIGHT,FULLOREMPTY,BAYNO,BLNO,CODE_GOODS,AMOUNT,WEIGHT,VOLUME,Code_MANUFACTURER,MANUFACTURER,CODE_KEEPER,KEEPER,ReeferTemp,TempUnit,DangerGrade,DangerMark,POSITION_CONTAINER,PASS_MARK,SHORT_UNLOAD,Unload_Mark,USER_NAME,USER_CODE) " & _
                                " SELECT SHIP_ID, CONTAINER_NO, SEALNO, null, SIZE_CON, CONTAINER_TYPE, '0', FULLOREMPTY, BAYNO, null, null, AMOUNT, GROSSWEIGHT, VOLUME, Code_Con_Company, Con_Company_CHI, '00', '', TEMPERATURE_SETTING,TEMPERATURE_UNIT,DANGER_GRADE,DANGER_MARK, '', PASS_MARK, SHORT_UNLOAD, UNLOAD_MARK, '" & G_User & "', USER_CODE FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").CellText(i) & "'"
                        Else    '箱高超高
                            sqlSRightSub = "insert into CON_HATCH_RECORD(SHIP_ID,CONTAINER_NO,SEALNO,SealCheck,SIZE_CON,CONTAINER_TYPE,OVER_HEIGHT,FULLOREMPTY,BAYNO,BLNO,CODE_GOODS,AMOUNT,WEIGHT,VOLUME,Code_MANUFACTURER,MANUFACTURER,CODE_KEEPER,KEEPER,ReeferTemp,TempUnit,DangerGrade,DangerMark,POSITION_CONTAINER,PASS_MARK,SHORT_UNLOAD,Unload_Mark,USER_NAME,USER_CODE) " & _
                                " SELECT SHIP_ID, CONTAINER_NO, SEALNO, null, SIZE_CON, CONTAINER_TYPE, '1', FULLOREMPTY, BAYNO, null, null, AMOUNT, GROSSWEIGHT, VOLUME, Code_Con_Company, Con_Company_CHI, '00', '', TEMPERATURE_SETTING,TEMPERATURE_UNIT,DANGER_GRADE,DANGER_MARK, '', PASS_MARK, SHORT_UNLOAD, UNLOAD_MARK, '" & G_User & "', USER_CODE FROM View_ConImageTwo WHERE CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").CellText(i) & "'"
                        End If

                        ExecSql(sqlSRightMain)
                        ExecSql(sqlSRightSub)
                        ExecSql(sqlSRightRelation)

                        Dim sqlEditConImage As String   '不管是否修改了提单号都更新舱单表
                        sqlEditConImage = "update con_image set BLNO = '" & Trim(Me.C1DBGP.Columns("BLNO").CellText(i)) & "' where CON_IMAGE_ID = '" & Me.C1DBGP.Columns("ID").CellText(i) & "'"
                        ExecSql(sqlEditConImage)
                    Else
                        Me.C1DBGP.Row = i
                        Me.C1DBGP.SelectedRows.Clear()
                        Me.C1DBGP.SelectedRows.Add(i)
                        MessageBox.Show("集装箱" & Me.C1DBGP.Columns("CONTAINER_NO").CellText(i) & "信息在舱单中已存在，但非本港装卸箱，请检查。", "提示")
                    End If
                Next
                'If strErr.Length > 0 Then
                '    MessageBox.Show("以下非空箱没有提单号不能导入舱单" & Chr(10) & strErr, "操作提示")
                'End If

                Call UpdateC1DBGB()
                Call UpdateC1DBGP()
                Call CompDeal()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub C1DBGB_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGB.FetchRowStyle
        If Me.C1DBGB.Columns("Temp").CellText(e.Row) = "1" Then
            e.CellStyle.BackColor = System.Drawing.Color.Tan
        End If
    End Sub

    Private Sub C1DBGP_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGP.FetchRowStyle
        If Me.C1DBGP.Columns("Temp").CellText(e.Row) = "1" Then
            e.CellStyle.BackColor = System.Drawing.Color.Tan
        End If
    End Sub
End Class
