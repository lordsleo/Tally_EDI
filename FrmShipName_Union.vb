Imports TALLY.DBControl
Public Class FrmShipName_Union
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipPre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShipDis As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtShipPreName As System.Windows.Forms.TextBox
    Friend WithEvents txtShipDisName As System.Windows.Forms.TextBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btQuit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmShipName_Union))
        Me.txtShipPreName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtShipPre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShipDisName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShipDis = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnSave = New System.Windows.Forms.Button
        Me.btQuit = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtShipPreName
        '
        Me.txtShipPreName.Location = New System.Drawing.Point(64, 56)
        Me.txtShipPreName.MaxLength = 40
        Me.txtShipPreName.Name = "txtShipPreName"
        Me.txtShipPreName.ReadOnly = True
        Me.txtShipPreName.TabIndex = 332
        Me.txtShipPreName.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 334
        Me.Label3.Text = "中文船名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipPre
        '
        Me.txtShipPre.Location = New System.Drawing.Point(64, 24)
        Me.txtShipPre.MaxLength = 40
        Me.txtShipPre.Name = "txtShipPre"
        Me.txtShipPre.TabIndex = 331
        Me.txtShipPre.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 18)
        Me.Label2.TabIndex = 333
        Me.Label2.Text = "保留船码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipDisName
        '
        Me.txtShipDisName.Location = New System.Drawing.Point(64, 128)
        Me.txtShipDisName.MaxLength = 40
        Me.txtShipDisName.Name = "txtShipDisName"
        Me.txtShipDisName.ReadOnly = True
        Me.txtShipDisName.TabIndex = 336
        Me.txtShipDisName.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 18)
        Me.Label1.TabIndex = 338
        Me.Label1.Text = "中文船名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipDis
        '
        Me.txtShipDis.Location = New System.Drawing.Point(64, 96)
        Me.txtShipDis.MaxLength = 40
        Me.txtShipDis.Name = "txtShipDis"
        Me.txtShipDis.TabIndex = 335
        Me.txtShipDis.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 337
        Me.Label4.Text = "消除船码"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBG
        '
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Right
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(176, 0)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.RecordSelectorWidth = 17
        Me.C1DBG.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBG.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.Size = New System.Drawing.Size(288, 230)
        Me.C1DBG.TabIndex = 422
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 284, 226</ClientRect><BorderSide>0</BorderSide><CaptionSt" & _
        "yle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><E" & _
        "venRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me" & _
        "=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Grou" & _
        "p"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyl" & _
        "e parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style" & _
        "4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""Rec" & _
        "ordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Styl" & _
        "e parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedS" & _
        "tyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Styl" & _
        "e parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style p" & _
        "arent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style pa" & _
        "rent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style pa" & _
        "rent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=" & _
        """Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style p" & _
        "arent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits" & _
        ">1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><" & _
        "ClientArea>0, 0, 284, 226</ClientArea><PrintPageHeaderStyle parent="""" me=""Style1" & _
        "4"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(32, 192)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 446
        Me.btnSave.Text = "确定"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(96, 192)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 445
        Me.btQuit.Text = "退出"
        '
        'FrmShipName_Union
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(464, 230)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.txtShipDisName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtShipDis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtShipPreName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtShipPre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.C1DBG)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmShipName_Union"
        Me.Text = "合并船码"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmShipName_Union_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.C1DBG.Visible = False
        Me.Width = 200
    End Sub

    Dim strShipPre, strShipDis As String
    Dim blShipPreOper As Boolean
    Dim strShipPreInfo As String
    Dim blShipDisOper As Boolean
    Dim strShipDisInfo As String
    Dim strEng, strType, strNation, strLine As String

    Private Sub txtShipPre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtShipPre.Leave
        txtShipPre.Text = txtShipPre.Text.Trim.ToUpper
        If (strShipPre <> Me.txtShipPre.Text) Then
            If (Me.txtShipPre.Text <> "") Then
                Dim sqlGetShipCode As String
                Dim dvGetShipCode As DataView
                sqlGetShipCode = "SELECT * FROM Code_SHIPNAME WHERE SPCODE = '" & Me.txtShipPre.Text & "'"
                dvGetShipCode = Filldata(sqlGetShipCode)
                If (dvGetShipCode.Count > 0) Then
                    blShipPreOper = True
                    If Not IsDBNull(dvGetShipCode(0)("CHI_VESSEL")) Then
                        Me.txtShipPreName.Text = dvGetShipCode(0)("CHI_VESSEL")
                    Else
                        Me.txtShipPreName.Clear()
                    End If
                    If Not IsDBNull(dvGetShipCode(0)("Eng_VESSEL")) Then
                        strEng = dvGetShipCode(0)("Eng_VESSEL")
                    Else
                        strEng = ""
                    End If
                    strType = IIf(IsDBNull(dvGetShipCode(0)("sptype")), "", dvGetShipCode(0)("sptype"))
                    strNation = IIf(IsDBNull(dvGetShipCode(0)("spnation")), "", dvGetShipCode(0)("spnation"))
                    strLine = IIf(IsDBNull(dvGetShipCode(0)("spline")), "", dvGetShipCode(0)("spline"))
                    strShipPreInfo = ""
                Else
                    blShipPreOper = False
                    Me.txtShipPreName.Clear()
                    strShipPreInfo = "保留船码不存在"
                End If
            Else
                blShipPreOper = False
                Me.txtShipPreName.Clear()
                strShipPreInfo = "保留船码为空"
            End If
            strShipPre = Me.txtShipPre.Text
        End If
    End Sub

    Private Sub txtShipDis_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtShipDis.Leave
        txtShipDis.Text = txtShipDis.Text.Trim.ToUpper
        If (strShipDis <> Me.txtShipDis.Text) Then
            If (Me.txtShipDis.Text <> "") Then
                Dim sqlGetShipCode As String
                Dim dvGetShipCode As DataView
                sqlGetShipCode = "SELECT SPCODE, CHI_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & Me.txtShipDis.Text & "'"
                dvGetShipCode = Filldata(sqlGetShipCode)
                If (dvGetShipCode.Count > 0) Then
                    blShipDisOper = True
                    If Not IsDBNull(dvGetShipCode(0)("CHI_VESSEL")) Then
                        Me.txtShipDisName.Text = dvGetShipCode(0)("CHI_VESSEL")
                    Else
                        Me.txtShipDisName.Clear()
                    End If
                    strShipDisInfo = ""
                Else
                    blShipDisOper = False
                    Me.txtShipDisName.Clear()
                    strShipDisInfo = "消除船码不存在"
                End If
            Else
                blShipDisOper = False
                Me.txtShipDisName.Clear()
                strShipDisInfo = "消除船码为空"
            End If
            strShipDis = Me.txtShipDis.Text
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If blShipPreOper Then
            If blShipDisOper Then
                If Me.txtShipPre.Text <> Me.txtShipDis.Text Then
                    If MessageBox.Show("确定合并吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                        '第一步清除装拆箱空提单
                        Dim sqlDelEmptyBill As String
                        sqlDelEmptyBill = "delete A from Con_Load_Tally A where not exists (select * from Con_Load_Tally_List B where A.Chi_Vessel=B.Chi_Vessel and A.Voyage=B.Voyage and A.Blno=B.Blno and A.Work_Place=B.CodeYard)"
                        ExecSql(sqlDelEmptyBill)
                        '第二步检查装拆箱重复提单，无重复可以做 否则显示重复提单
                        Dim sqlCheckRepeat As String
                        Dim dvCheckRepeat As DataView
                        sqlCheckRepeat = "select A.No,A.blno,A.Time_From,C.Code_Yard_Name from CON_LOAD_TALLY A join CON_LOAD_TALLY B on A.blno=B.Blno and A.Work_Place=B.Work_Place and A.Voyage=B.Voyage " & _
                            " left join Code_Yard C on A.Work_Place=C.Code_Yard_ID " & _
                            " where A.chi_vessel='" & Me.txtShipPre.Text & "' and B.chi_vessel='" & Me.txtShipDis.Text & "' "
                        dvCheckRepeat = Filldata(sqlCheckRepeat)
                        If dvCheckRepeat.Count = 0 Then
                            Call OperateHistory(G_DeptName, Now, G_User, "修改合并", "Code_ShipName", Trim(txtShipDis.Text), "SPCODE")
                            '准备记录日志
                            ExecSql("Exec sp_ConLoadTallyListOperPre '" & G_DeptName & "','" & Now & "','" & G_User & "','合并船码'")

                            '第三步先死法删除保留船码
                            Dim sqlDelPre As String
                            sqlDelPre = "delete from Code_ShipName where SPCODE = '" & Me.txtShipPre.Text & "'"
                            '第四步后生法修改消除船码为保留船码
                            Dim sqlUpdateDis As String
                            sqlUpdateDis = "update Code_ShipName set SPCODE='" & Me.txtShipPre.Text & "',Eng_VESSEL='" & strEng & "',CHI_VESSEL='" & Me.txtShipPreName.Text & "',sptype='" & strType & "',spnation='" & strNation & "',spline='" & strLine & "' where SPCODE = '" & Me.txtShipDis.Text & "'"
                            ExecSql(sqlDelPre & " " & sqlUpdateDis)
                            Me.Close()
                        Else
                            Me.C1DBG.DataSource = dvCheckRepeat
                            Me.C1DBG.Columns("No").Caption = "编号"
                            Me.C1DBG.Columns("blno").Caption = "提单"
                            Me.C1DBG.Columns("Time_From").Caption = "时间"
                            Me.C1DBG.Columns("Code_Yard_Name").Caption = "场站"
                            Me.C1DBG.Columns("Time_From").NumberFormat = "yyyy-MM-dd"
                            SetDGWidth2(Me.C1DBG)
                            Me.C1DBG.Columns("No").FooterText = dvCheckRepeat.Count & "个"
                            Me.C1DBG.Visible = True
                            Me.Width = 264
                            strShipDisInfo = "请处理重复的提单"
                            MessageBox.Show(strShipDisInfo, "提示")
                        End If
                    End If
                Else
                    strShipDisInfo = "保留和消除船码相同"
                    Me.txtShipPre.Focus()
                    MessageBox.Show(strShipDisInfo, "提示")
                End If
            Else
                Me.txtShipDis.Focus()
                MessageBox.Show(strShipDisInfo, "提示")
            End If
        Else
            Me.txtShipPre.Focus()
            MessageBox.Show(strShipPreInfo, "提示")
        End If
    End Sub

    Private Sub txtShipPre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShipPre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtShipDis.Focus()
        End If
    End Sub

    Private Sub txtShipDis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShipDis.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnSave.Focus()
        End If
    End Sub
End Class
