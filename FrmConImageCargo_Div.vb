Imports TALLY.DBControl
Public Class FrmConImageCargo_Div
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents lbPorts As System.Windows.Forms.ListBox
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ckbOverlay As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConImageCargo_Div))
        Me.lbPorts = New System.Windows.Forms.ListBox
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ckbOverlay = New System.Windows.Forms.CheckBox
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbPorts
        '
        Me.lbPorts.ItemHeight = 12
        Me.lbPorts.Location = New System.Drawing.Point(14, 30)
        Me.lbPorts.Name = "lbPorts"
        Me.lbPorts.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbPorts.Size = New System.Drawing.Size(162, 112)
        Me.lbPorts.TabIndex = 0
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowFilter = False
        Me.C1DBGV.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.CaptionHeight = 18
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(14, 146)
        Me.C1DBGV.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.RecordSelectorWidth = 17
        Me.C1DBGV.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBGV.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBGV.RowHeight = 16
        Me.C1DBGV.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBGV.Size = New System.Drawing.Size(334, 116)
        Me.C1DBGV.TabIndex = 12
        Me.C1DBGV.Text = "C1DBGV"
        Me.C1DBGV.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionH" & _
        "eight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1""" & _
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
        "vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17" & _
        "</DefaultRecSelWidth><ClientArea>0, 0, 330, 112</ClientArea><PrintPageHeaderStyl" & _
        "e parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob" & _
        ">"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(202, 268)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 577
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(134, 268)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 576
        Me.btSave.Text = "确认"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 20)
        Me.Label1.TabIndex = 578
        Me.Label1.Text = "选择本船次中有关港口箱信息分入对应船次中"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ckbOverlay
        '
        Me.ckbOverlay.Checked = True
        Me.ckbOverlay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbOverlay.Location = New System.Drawing.Point(230, 94)
        Me.ckbOverlay.Name = "ckbOverlay"
        Me.ckbOverlay.Size = New System.Drawing.Size(116, 24)
        Me.ckbOverlay.TabIndex = 579
        Me.ckbOverlay.Text = "覆盖原有箱信息"
        '
        'FrmConImageCargo_Div
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(364, 298)
        Me.Controls.Add(Me.ckbOverlay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.C1DBGV)
        Me.Controls.Add(Me.lbPorts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConImageCargo_Div"
        Me.ShowInTaskbar = False
        Me.Text = "集装箱船图信息 分船"
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim strPortCol As String
    Dim sqlVoyage As String
    Dim dvVoyage As DataView

    Private Sub FrmConImageCargo_Div_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim iVesselID As Integer
            Dim strVessel, Voyage As String
            Dim strInOut As String
            Dim strTrade As String
            Dim strBerth As String
            Dim strShipGoods As String

            Dim dvVessel As DataView
            dvVessel = Filldata("SELECT * FROM SSHIP WHERE SHIP_ID = " & Ship_ID)
            iVesselID = dvVessel.Item(0)("V_ID")

            strInOut = IIf(IsDBNull(dvVessel(0)("INOUTPORT")), "", dvVessel(0)("INOUTPORT"))
            If strInOut = "0" Then
                strPortCol = "CODE_LOAD_PORT"
            Else
                strPortCol = "CODE_UNLOAD_PORT"
            End If
            strTrade = IIf(IsDBNull(dvVessel(0)("S_TRADE")), "", dvVessel(0)("S_TRADE"))
            strBerth = IIf(IsDBNull(dvVessel(0)("BERTHNO")), "", dvVessel(0)("BERTHNO"))
            strShipGoods = IIf(IsDBNull(dvVessel(0)("CODE_GOODS")), "", dvVessel(0)("CODE_GOODS"))

            Dim sqlPorts As String
            Dim dvPorts As DataView
            sqlPorts = "select " & strPortCol & ",IsNull(PORT_CHA,'')+' '+ " & strPortCol & " PortName from (select " & strPortCol & " from Con_Image where Ship_ID=" & Ship_ID & " Group by " & strPortCol & ") A left join Code_Port B on " & strPortCol & "=CODE_PORT order by PORT_CHA"
            dvPorts = Filldata(sqlPorts)
            Me.lbPorts.DataSource = dvPorts
            Me.lbPorts.DisplayMember = "PortName"
            Me.lbPorts.ValueMember = strPortCol

            sqlVoyage = "SELECT SHIP_ID,A.InOutPort,A.S_Trade,SHIP_STATU,V_ID,ENG_VESSEL,CHI_VESSEL,VOYAGE,B.InOutPort_Name,C.Trade,BERTHNO " & _
                " FROM SSHIP A LEFT JOIN Code_InOutPort B ON A.INOUTPORT = B.InOutPort LEFT JOIN Code_Trade C ON A.S_TRADE = C.S_Trade " & _
                " where V_ID= " & iVesselID & " and Ship_ID<>" & Ship_ID & " and A.InOutPort='" & strInOut & "' and A.S_Trade<>'" & strTrade & "' and BERTHNO='" & strBerth & "' and CODE_GOODS='" & strShipGoods & "' and Ship_Statu<'4'"
            dvVoyage = Filldata(sqlVoyage)
            Me.C1DBGV.DataSource = dvVoyage
            Dim i As Integer
            For i = 0 To 5
                Me.C1DBGV.Splits(0).DisplayColumns(i).Visible = False
            Next
            Me.C1DBGV.Columns.Item("CHI_VESSEL").Caption = "船名"
            Me.C1DBGV.Columns.Item("VOYAGE").Caption = "航次"
            Me.C1DBGV.Columns.Item("InOutPort_Name").Caption = "进出口"
            Me.C1DBGV.Columns.Item("Trade").Caption = "内外贸"
            Me.C1DBGV.Columns.Item("BERTHNO").Caption = "泊位"
            Me.C1DBGV.Splits(0).DisplayColumns.Item("CHI_VESSEL").Width = 70
            Me.C1DBGV.Splits(0).DisplayColumns.Item("VOYAGE").Width = 50
            Me.C1DBGV.Splits(0).DisplayColumns.Item("InOutPort_Name").Width = 40
            Me.C1DBGV.Splits(0).DisplayColumns.Item("Trade").Width = 40
            Me.C1DBGV.Splits(0).DisplayColumns.Item("BERTHNO").Width = 40
            Me.C1DBGV.FetchRowStyles = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub lbPorts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbPorts.SelectedIndexChanged

    End Sub

    Private Sub C1DBGV_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGV.FetchRowStyle
        Select Case Me.C1DBGV.Columns("Ship_Statu").CellText(e.Row)
            Case "2"
                e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
            Case "3"
                e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
            Case "0"
                e.CellStyle.BackColor = System.Drawing.Color.Cyan
        End Select
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        If dvVoyage.Count > 0 Then
            If Me.lbPorts.SelectedItems.Count > 0 Then
                If MessageBox.Show("确定分船吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                    Dim strPortList As String
                    Dim i As Integer
                    For i = 0 To Me.lbPorts.SelectedItems.Count - 1
                        strPortList &= "'" & Me.lbPorts.SelectedItems.Item(i)(strPortCol) & "',"
                    Next
                    strPortList = strPortList.Remove(strPortList.Length - 1, 1)
                    'Dim sqlDelOld As String
                    'Dim sqlDivData As String
                    'If Me.ckbOverlay.Checked Then
                    '    sqlDelOld = "delete from Con_Image where Ship_ID=" & Me.C1DBGV.Columns("Ship_ID").Value & _
                    '        " and Container_No in (select Container_No from Con_Image where Ship_ID=" & Ship_ID & " and " & strPortCol & " in (" & strPortList & "))"
                    'Else
                    '    sqlDelOld = "delete from Con_Image where Ship_ID=" & Ship_ID & " and " & strPortCol & " in (" & strPortList & ")" & _
                    '        " and Container_No in (select Container_No from Con_Image where Ship_ID=" & Me.C1DBGV.Columns("Ship_ID").Value & ")"
                    'End If
                    'sqlDivData = "update Con_Image set Ship_ID=" & Me.C1DBGV.Columns("Ship_ID").Value & " where Ship_ID=" & Ship_ID & " and " & strPortCol & " in (" & strPortList & ")"
                    'ExecSql(sqlDelOld & " " & sqlDivData)
                    strPortList = strPortList.Replace("'", "''")
                    Dim blOverlay As Integer
                    If Me.ckbOverlay.Checked Then
                        blOverlay = 1
                    Else
                        blOverlay = 0
                    End If

                    Dim sqlDivShip As String
                    sqlDivShip = "spDivShip " & Ship_ID & "," & Me.C1DBGV.Columns("Ship_ID").Value & ",'" & strPortList & "'," & blOverlay & ""
                    Try
                        ExecSql(sqlDivShip)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    Me.Close()
                End If
            Else
                Me.lbPorts.Focus()
                MessageBox.Show("请选择要分出的港口", "提示")
            End If
        End If
    End Sub
End Class
