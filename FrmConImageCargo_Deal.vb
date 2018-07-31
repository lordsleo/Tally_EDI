Imports TALLY.DBControl
Public Class FrmConImageCargo_Deal
    Inherits System.Windows.Forms.Form

    Dim dsShip As New DataSet() '船舶数据集
    Dim SqlStrShip As String  '船舶条件语句
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String

    Dim VesselID As Integer
    Dim Vessel, Voyage As String

    Public Shared sqlExistBay As String
    Public Shared dvExistBay As New DataView()
    Public Shared strNewShipID As String

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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConImageCargo_Deal))
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowFilter = False
        Me.C1DBGV.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.CaptionHeight = 18
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(0, 28)
        Me.C1DBGV.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.RecordSelectorWidth = 16
        Me.C1DBGV.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBGV.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBGV.RowHeight = 16
        Me.C1DBGV.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBGV.Size = New System.Drawing.Size(334, 116)
        Me.C1DBGV.TabIndex = 11
        Me.C1DBGV.Text = "C1DBGV"
        Me.C1DBGV.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style14{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" & _
        "tyle9{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionH" & _
        "eight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><ClientRect>0, 0, 330, 112</ClientRect><BorderSide>0<" & _
        "/BorderSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Ed" & _
        "itor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle" & _
        " parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><G" & _
        "roupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style" & _
        "2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle paren" & _
        "t=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSel" & _
        "ectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selecte" & _
        "d"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.Merg" & _
        "eView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal" & _
        """ me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" m" & _
        "e=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=" & _
        """Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Hig" & _
        "hlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""Od" & _
        "dRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=" & _
        """FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</" & _
        "vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16" & _
        "</DefaultRecSelWidth><ClientArea>0, 0, 330, 112</ClientArea><PrintPageHeaderStyl" & _
        "e parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob" & _
        ">"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "将不在本港卸下的集装箱全部导出到下列某船次中"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(170, 150)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 575
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(102, 150)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 574
        Me.btSave.Text = "确认"
        '
        'FrmConImageCargo_Deal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(334, 177)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C1DBGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConImageCargo_Deal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱船图信息 导出"
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConImageCargo_Deal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dvVessel As New DataView()
        Try
            dvVessel = Filldata("SELECT SHIP_ID, V_ID, CHI_VESSEL, VOYAGE  FROM SSHIP WHERE (SHIP_ID = '" & Ship_ID & "')")
            VesselID = dvVessel.Item(0)("V_ID")
            Vessel = dvVessel.Item(0)("CHI_VESSEL")
            Voyage = dvVessel.Item(0)("VOYAGE")     '取得导出船次的 V_ID 船名 航次

            SortShip = " Order by Ship_Statu,SSHIP.DEPT_CODE " '默认的排序 
            FirmShip = " where SSHIP.DEPT_CODE LIKE '" & G_DeptCode & "%' " '船舶不变的条件设计
            SqlStrShip = " where (SSHIP.DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','0')) and (V_ID='" & VesselID & "' and ship_id<>'" & Ship_ID & "' and SSHIP.InOutPort='1') "
            Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '*****************调用航次信息
            Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub myDataGridShip(ByVal Sql As String) '**************航次信息
        Dim strsql As String
        Dim i As Integer
        strsql = "SELECT SSHIP.SHIP_ID AS ID, Code_InOutPort.InOutPort, Code_Trade.S_Trade, SHIP_STATU, DEPARTMENT.DEPT_CODE, SSHIP.BERTHNO, SSHIP.V_ID, SSHIP.ENG_VESSEL, SSHIP.CHI_VESSEL, SSHIP.VOYAGE, Code_InOutPort.InOutPort_Name, Code_Trade.Trade, DEPARTMENT.DEPT_NAME FROM SSHIP LEFT OUTER JOIN Code_Trade ON SSHIP.S_TRADE = Code_Trade.S_Trade  LEFT OUTER JOIN Code_InOutPort ON SSHIP.INOUTPORT = Code_InOutPort.InOutPort LEFT OUTER JOIN DEPARTMENT ON SSHIP.DEPT_CODE = DEPARTMENT.DEPT_CODE " '船舶条件语句 不改部分
        strsql = strsql & Sql
        Try
            Me.C1DBGV.DataSource = Getdata(strsql, dsShip)
            For i = 0 To 7 '设计部显示的列
                Me.C1DBGV.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            Call SetColumnWidthShip() '设计列宽度
            Me.C1DBGV.Columns.Item("CHI_VESSEL").Caption = "船名"
            Me.C1DBGV.Columns.Item("VOYAGE").Caption = "航次"
            Me.C1DBGV.Columns.Item("InOutPort_Name").Caption = "进出口"
            Me.C1DBGV.Columns.Item("Trade").Caption = "内外贸"
            Me.C1DBGV.Columns.Item("DEPT_NAME").Caption = "部门"

            Me.C1DBGV.FetchRowStyles = True
            Me.C1DBGV.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidthShip() '************航次列宽
        Dim i As Integer
        Try
            Me.C1DBGV.Splits(0).DisplayColumns.Item("CHI_VESSEL").Width = 70
            Me.C1DBGV.Splits(0).DisplayColumns.Item("VOYAGE").Width = 50
            Me.C1DBGV.Splits(0).DisplayColumns.Item("InOutPort_Name").Width = 40
            Me.C1DBGV.Splits(0).DisplayColumns.Item("Trade").Width = 40
            Me.C1DBGV.Splits(0).DisplayColumns.Item("DEPT_NAME").Width = 80
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1DBGV_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGV.FetchRowStyle
        If Me.C1DBGV.Columns("Ship_Statu").CellValue(e.Row) = 2 Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        ElseIf Me.C1DBGV.Columns("Ship_Statu").CellValue(e.Row) = 3 Then
            e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 0 Then
            e.CellStyle.BackColor = System.Drawing.Color.Cyan
        End If
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim i As Integer
        Dim ErrMessage As String = ""
        Dim CountBay As Integer

        Try
            If dsShip.Tables(0).Rows.Count > 0 Then
                Dim sqlCount As String
                Dim dvCount As New DataView()
                sqlCount = "select CONTAINER_NO FROM CON_IMAGE  WHERE SHIP_ID = '" & Ship_ID & "' and CODE_UNLOAD_PORT not like '%LYG%' " & _
                            "and CONTAINER_NO not in ( select CONTAINER_NO from CON_IMAGE where SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "' ) " & _
                            "and dbo.ConOtherMode(CONTAINER_NO) not in ( select CONTAINER_NO from CON_IMAGE where SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "' ) " & _
                            "and BAYNO NOT IN (SELECT BAYNO FROM CON_IMAGE WHERE SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') " & _
                            "and substring(cast('2'+substring(BAYNO,1,2)+1 as char(3))+right(BAYNO,4),2,6) NOT IN (SELECT BAYNO FROM CON_IMAGE WHERE SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') " & _
                            "and substring(cast('2'+substring(BAYNO,1,2)-1 as char(3))+right(BAYNO,4),2,6) NOT IN (SELECT BAYNO FROM CON_IMAGE WHERE SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') "
                dvCount = Filldata(sqlCount)
                '在导入船次中箱号贝位号(包括通贝情况)都不存在的箱号

                Dim sqlExistCon As String
                Dim dvExistCon As New DataView()
                sqlExistCon = "SELECT CONTAINER_NO,bayno FROM CON_IMAGE " & _
                    "WHERE SHIP_ID = '" & Ship_ID & "' and CODE_UNLOAD_PORT not like '%LYG%' " & _
                    "and ( CONTAINER_NO IN (SELECT CONTAINER_NO FROM CON_IMAGE WHERE SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') " & _
                    "or  dbo.ConOtherMode(CONTAINER_NO) IN (SELECT CONTAINER_NO FROM CON_IMAGE WHERE SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') ) "
                dvExistCon = Filldata(sqlExistCon)
                '找出将要导出的船次（Ship_ID）中卸货港 not like '%LYG%' 且与将要导入的船次（Me.C1DBGV.Columns("ID").Text）中箱号重复的 所有箱号

                sqlExistBay = "SELECT CONTAINER_NO,bayno FROM CON_IMAGE " & _
                    "WHERE SHIP_ID = '" & Ship_ID & "' and CODE_UNLOAD_PORT not like '%LYG%' " & _
                    "and  CONTAINER_NO not IN (SELECT CONTAINER_NO FROM CON_IMAGE WHERE SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') " & _
                    "and  dbo.ConOtherMode(CONTAINER_NO) not IN (SELECT CONTAINER_NO FROM CON_IMAGE WHERE SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') " & _
                    "and ( BAYNO IN (SELECT BAYNO FROM CON_IMAGE WHERE SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') " & _
                    "or substring(cast('2'+substring(BAYNO,1,2)+1 as char(3))+right(BAYNO,4),2,6)  IN (SELECT BAYNO FROM CON_IMAGE WHERE SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') " & _
                    "or substring(cast('2'+substring(BAYNO,1,2)-1 as char(3))+right(BAYNO,4),2,6)  IN (SELECT BAYNO FROM CON_IMAGE WHERE SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') ) "
                dvExistBay = Filldata(sqlExistBay)
                '类似sqlExistCon，箱号不同，但贝位号同，请用户修改贝位号

                Dim sqlInsertContainer As String    '换了原航次中的 ship_id .忽略Unload_Mark
                sqlInsertContainer = "insert into CON_IMAGE (SHIP_ID, CONTAINER_NO, FULLOREMPTY, SEALNO, BAYNO, BLNO, CODE_LOAD_PORT, Load_Port, CODE_UNLOAD_PORT, Unload_Port, CODE_DELIVERY, DELIVERY, AMOUNT, GROSSWEIGHT, VOLUME, TEMPERATURE_UNIT, TEMPERATURE_SETTING, MIN_TEMPERATURE, MAX_TEMPERATURE, DANGER_GRADE, DANGER_PAGENO, DANGER_NO, DANGER_MARK, PASS_MARK, SHORT_UNLOAD, USER_NAME, Demo, ConDemo, OLDBAYNO, MOVED, USER_CODE,CodeLoadPort,CodeUnLoadPort,CodeDelivery,CodeConType,Code_Con_Company) " & _
                    "SELECT  '" & Me.C1DBGV.Columns("ID").Text & "', CONTAINER_NO, FULLOREMPTY, SEALNO, BAYNO, BLNO, CODE_LOAD_PORT, LOAD_PORT, CODE_UNLOAD_PORT, UNLOAD_PORT, CODE_DELIVERY, DELIVERY, AMOUNT, GROSSWEIGHT, VOLUME, TEMPERATURE_UNIT, TEMPERATURE_SETTING, MIN_TEMPERATURE, MAX_TEMPERATURE, DANGER_GRADE, DANGER_PAGENO, DANGER_NO, DANGER_MARK, PASS_MARK, SHORT_UNLOAD, USER_NAME, Demo, ConDemo, OLDBAYNO, MOVED, USER_CODE,CodeLoadPort,CodeUnLoadPort,CodeDelivery,CodeConType,Code_Con_Company FROM CON_IMAGE " & _
                    "WHERE SHIP_ID = '" & Ship_ID & "' and CODE_UNLOAD_PORT not like '%LYG%' " & _
                        "and CONTAINER_NO not in ( select CONTAINER_NO from CON_IMAGE where SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') " & _
                        "and dbo.ConOtherMode(CONTAINER_NO) not in ( select CONTAINER_NO from CON_IMAGE where SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') " & _
                        "and  BAYNO NOT IN (SELECT BAYNO FROM CON_IMAGE WHERE SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') " & _
                        "and substring(cast('2'+substring(BAYNO,1,2)+1 as char(3))+right(BAYNO,4),2,6) NOT IN (SELECT BAYNO FROM CON_IMAGE WHERE SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') " & _
                        "and substring(cast('2'+substring(BAYNO,1,2)-1 as char(3))+right(BAYNO,4),2,6) NOT IN (SELECT BAYNO FROM CON_IMAGE WHERE SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') "
                '将将要导出的船次中卸货港 not like '%LYG%' 且与将要导入的船次中箱号和贝位号都不重复的箱信息插入到表中
                ExecSql(sqlInsertContainer)

                '删除目标航次中本港卸箱
                Dim sqlDelCon As String
                sqlDelCon = "Delete from Con_Image where Ship_ID=" & Me.C1DBGV.Columns("ID").Value & _
                    " and Container_No in (select Container_No from Con_Image where Ship_ID=" & Ship_ID & " and Code_Unload_Port like '%LYG%')"
                ExecSql(sqlDelCon)

                Dim sqlUpdateCon As String
                sqlUpdateCon = "update d set FULLOREMPTY=s.FULLOREMPTY, SEALNO=s.SEALNO, BLNO=s.BLNO, CODE_LOAD_PORT=s.CODE_LOAD_PORT, " & _
                    "Load_Port=s.Load_Port, CODE_UNLOAD_PORT=s.CODE_UNLOAD_PORT, Unload_Port=s.Unload_Port, " & _
                    "CODE_DELIVERY=s.CODE_DELIVERY, DELIVERY=s.DELIVERY, AMOUNT=s.AMOUNT, GROSSWEIGHT=s.GROSSWEIGHT, " & _
                    "VOLUME=s.VOLUME, TEMPERATURE_UNIT=s.TEMPERATURE_UNIT, TEMPERATURE_SETTING=s.TEMPERATURE_SETTING, " & _
                    "MIN_TEMPERATURE=s.MIN_TEMPERATURE, MAX_TEMPERATURE=s.MAX_TEMPERATURE, DANGER_GRADE=s.DANGER_GRADE, " & _
                    "DANGER_PAGENO=s.DANGER_PAGENO, DANGER_NO=s.DANGER_NO, DANGER_MARK=s.DANGER_MARK, PASS_MARK=s.PASS_MARK, " & _
                    "SHORT_UNLOAD=s.SHORT_UNLOAD, Demo=s.Demo, " & _
                    "ConDemo=s.ConDemo, OLDBAYNO=s.OLDBAYNO ,CodeLoadPort=s.CodeLoadPort,CodeUnLoadPort=s.CodeUnLoadPort,CodeDelivery=s.CodeDelivery,CodeConType=s.CodeConType,Code_Con_Company=s.Code_Con_Company " & _
                    "FROM CON_IMAGE d INNER JOIN CON_IMAGE s ON ( d.CONTAINER_NO = s.CONTAINER_NO or d.CONTAINER_NO = dbo.ConOtherMode(s.CONTAINER_NO) ) AND d.CON_IMAGE_ID <> s.CON_IMAGE_ID " & _
                    "WHERE (s.SHIP_ID = '" & Ship_ID & "') AND (d.SHIP_ID = '" & Me.C1DBGV.Columns("ID").Text & "') AND (s.CODE_UNLOAD_PORT NOT LIKE '%LYG%') and d.Moved=0"

                ExecSql(sqlUpdateCon)   '更新已存在的箱信息，贝位号保留不更新 忽略Unload_Mark,捣箱的不要更新

                If dvExistBay.Count > 0 Then
                    strNewShipID = Me.C1DBGV.Columns("ID").Text
                    Dim FrmDealSub As New FrmConImageCargo_DealSub()
                    FrmDealSub.ShowDialog()
                    CountBay = FrmDealSub.CountCon
                End If
                'For i = 0 To dvExist.Count - 1
                '    If (i + 1) Mod 5 = 0 Then
                '        ErrMessage = ErrMessage & dvExist(i)(0) & Chr(10)
                '    Else
                '        ErrMessage = ErrMessage & dvExist(i)(0) & "   "
                '    End If
                'Next
                'If dvExist.Count > 0 Then
                '    If MessageBox.Show("此船次下列箱号已存在，这部分不能导入，确定导入其它箱号吗？" & Chr(10) & ErrMessage, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                '        Exit Sub
                '    End If
                'End If

                MessageBox.Show("共有 " & (dvCount.Count + dvExistCon.Count + CountBay) & " 个集装箱从 " & Vessel & " " & Voyage & "次 导出到 " & Me.C1DBGV.Columns("CHI_VESSEL").Text & " " & Me.C1DBGV.Columns("VOYAGE").Text & "次" & _
                            Chr(10) & "其中箱号贝位号都不存在的 " & dvCount.Count & "个" & _
                            Chr(10) & "        箱号存在的" & dvExistCon.Count & "个" & _
                            Chr(10) & "        箱号不存在贝位号存在的" & CountBay & "个", "操作结果")
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
