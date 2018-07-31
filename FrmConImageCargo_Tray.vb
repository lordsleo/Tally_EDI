Imports TALLY.DBControl
Public Class FrmConImageCargo_Tray
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1Show As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOnlyTray As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConImageCargo_Tray))
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1Show = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnOnlyTray = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Show, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(564, 452)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 581
        Me.btQuit.Text = "退出"
        '
        'btSave
        '
        Me.btSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btSave.Location = New System.Drawing.Point(492, 452)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 580
        Me.btSave.Text = "确认"
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(456, 20)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.RecordSelectorWidth = 16
        Me.C1DBG.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBG.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.Size = New System.Drawing.Size(240, 424)
        Me.C1DBG.TabIndex = 579
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.Visible = False
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{BackColor:CadetBlue;}Ca" & _
        "ption{AlignHorz:Center;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;Bac" & _
        "kColor:Highlight;}Style12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}He" & _
        "ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" & _
        ";BackColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}S" & _
        "tyle1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSi" & _
        "zing=""None"" CaptionHeight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" " & _
        "MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" Ver" & _
        "ticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 236, 420</Clien" & _
        "tRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2"" me=""Style10"" /><Ed" & _
        "itorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style" & _
        "8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Foot" & _
        "er"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent" & _
        "=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" />" & _
        "<InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""" & _
        "Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedS" & _
        "tyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.W" & _
        "in.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><" & _
        "Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Styl" & _
        "e parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style" & _
        " parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style par" & _
        "ent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style pa" & _
        "rent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style" & _
        " parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedSt" & _
        "yles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><D" & _
        "efaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 236, 420</ClientArea>" & _
        "<PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" m" & _
        "e=""Style15"" /></Blob>"
        '
        'C1Show
        '
        Me.C1Show.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1Show.AllowUpdate = False
        Me.C1Show.CaptionHeight = 18
        Me.C1Show.ColumnFooters = True
        Me.C1Show.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1Show.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Show.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1Show.Location = New System.Drawing.Point(0, 0)
        Me.C1Show.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1Show.Name = "C1Show"
        Me.C1Show.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Show.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Show.PreviewInfo.ZoomFactor = 75
        Me.C1Show.RecordSelectorWidth = 16
        Me.C1Show.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Show.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1Show.RowHeight = 16
        Me.C1Show.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Show.Size = New System.Drawing.Size(696, 444)
        Me.C1Show.TabIndex = 582
        Me.C1Show.Text = "C1TrueDBGrid1"
        Me.C1Show.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{BackColor:CadetBlue;}Ca" & _
        "ption{AlignHorz:Center;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;Bac" & _
        "kColor:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}He" & _
        "ading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlTex" & _
        "t;AlignVert:Center;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}S" & _
        "tyle9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSi" & _
        "zing=""None"" CaptionHeight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" " & _
        "MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" Ver" & _
        "ticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 692, 440</Clien" & _
        "tRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2"" me=""Style10"" /><Ed" & _
        "itorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style" & _
        "8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Foot" & _
        "er"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent" & _
        "=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" />" & _
        "<InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""" & _
        "Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedS" & _
        "tyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.W" & _
        "in.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><" & _
        "Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Styl" & _
        "e parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style" & _
        " parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style par" & _
        "ent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style pa" & _
        "rent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style" & _
        " parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedSt" & _
        "yles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><D" & _
        "efaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 692, 440</ClientArea>" & _
        "<PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" m" & _
        "e=""Style15"" /></Blob>"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(460, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 583
        Me.Label1.Text = "处理托盘信息"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'btnOnlyTray
        '
        Me.btnOnlyTray.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOnlyTray.Location = New System.Drawing.Point(52, 452)
        Me.btnOnlyTray.Name = "btnOnlyTray"
        Me.btnOnlyTray.Size = New System.Drawing.Size(92, 24)
        Me.btnOnlyTray.TabIndex = 584
        Me.btnOnlyTray.Text = "单独处理托盘"
        '
        'FrmConImageCargo_Tray
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(696, 481)
        Me.Controls.Add(Me.btnOnlyTray)
        Me.Controls.Add(Me.C1Show)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConImageCargo_Tray"
        Me.ShowInTaskbar = False
        Me.Text = "集装箱船图信息 托盘"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Show, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlShow As String
    Dim dvShow As DataView
    Dim sqlDeal As String
    Dim dvDeal As DataView
    Dim daDeal As New SqlClient.SqlDataAdapter
    Dim dsDeal As New DataSet

    Dim sqlConImage As String
    Dim dvConImage As DataView
    Dim daConImage As New SqlClient.SqlDataAdapter
    Dim dsConImage As New DataSet

    Dim sqlConCriterion As String
    Dim dvConCriterion As DataView
    Dim daConCriterion As New SqlClient.SqlDataAdapter
    Dim dsConCriterion As New DataSet

    Dim sqlTray As String
    Dim dvTray As DataView
    Dim daTray As New SqlClient.SqlDataAdapter
    Dim dsTray As New DataSet

    Private Sub FrmConImageCargo_Tray_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlShow = "ConImage_TrayFull " & Ship_ID
        ShowTray()
        'sqlDeal = "select CON_IMAGE_ID,SHIP_ID,CONTAINER_NO,VOLUME,BAYNO,TPMARK,USER_NAME from Con_Image where Ship_ID=" & Ship_ID & " and TPMARK='1'"
        'InitDealTray()
        sqlConImage = "select * from Con_Image where Ship_ID=" & Ship_ID
        dvConImage = Updatedata(daConImage, sqlConImage, dsConImage)
        sqlConCriterion = "select * from Con_Criterion where Container_No in (select Container_No from Con_Image where Ship_ID=" & Ship_ID & ")"
        dvConCriterion = Updatedata(daConCriterion, sqlConCriterion, dsConCriterion)
        sqlTray = "Select * from Con_Image_Tray where Ship_ID =" & Ship_ID
        dvTray = Updatedata(daTray, sqlTray, dsTray)
        dvTray.Table.Columns("SHIP_ID").DefaultValue = Ship_ID
        dvConImage.AllowNew = True
        dvConCriterion.AllowNew = True
        dvTray.AllowNew = True
    End Sub

    Private Sub ShowTray()
        dvShow = Filldata(sqlShow)
        Me.C1Show.DataSource = dvShow
        Me.C1Show.Columns("CONTAINER_NO").Caption = "箱号"
        Me.C1Show.Columns("SIZE_CON").Caption = "尺寸"
        Me.C1Show.Columns("CONTAINER_TYPE").Caption = "箱型"
        Me.C1Show.Columns("FULLOREMPTY").Caption = "空重"
        Me.C1Show.Columns("BAYNO").Caption = "贝位号"
        Me.C1Show.Columns("Tray").Caption = "托盘号"
        Me.C1Show.Columns("GROSSWEIGHT").Caption = "总重"
        Me.C1Show.Columns("TEMPERATURE_SETTING").Caption = "冷藏温度"
        Me.C1Show.Columns("TEMPERATURE_UNIT").Caption = "温标"
        Me.C1Show.Columns("DANGER_GRADE").Caption = "危品等级"
        SetDGWidthFull(Me.C1Show)
        Me.C1Show.Columns("CONTAINER_NO").FooterText = "计" & dvShow.Count & "个"

        Me.C1Show.Caption = "箱托盘贝位信息查看处理"
        Me.C1Show.AllowUpdate = True
        Me.C1Show.AllowColMove = False
        Me.C1Show.Splits(0).DisplayColumns("CONTAINER_NO").Locked = True

    End Sub

    Private Sub InitDealTray()
        dvDeal = Updatedata(daDeal, sqlDeal, dsDeal)
        dvDeal.Table.Columns("SHIP_ID").DefaultValue = Ship_ID
        dvDeal.Table.Columns("TPMARK").DefaultValue = "1"
        dvDeal.Table.Columns("USER_NAME").DefaultValue = G_User
        Me.C1DBG.DataSource = dvDeal
        Me.C1DBG.Columns("CONTAINER_NO").Caption = "托盘号"
        Me.C1DBG.Columns("VOLUME").Caption = "尺寸"
        Me.C1DBG.Columns("BAYNO").Caption = "贝位号"
        Me.C1DBG.Splits(0).DisplayColumns("CON_IMAGE_ID").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("SHIP_ID").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("TPMARK").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("USER_NAME").Visible = False
        SetDGWidthFull(Me.C1DBG)
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "计" & dvDeal.Count & "个"
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            'daDeal.Update(dsDeal)
            'ShowTray()
            'Updatedata(daDeal, sqlDeal, dsDeal)

            daConImage.Update(dsConImage)
            dsConImage.AcceptChanges()
            daConCriterion.Update(dsConCriterion)
            dsConCriterion.AcceptChanges()
            daTray.Update(dsTray)
            dsTray.AcceptChanges()
            'Updatedata(daConImage, sqlConImage, dsConImage)
            'Updatedata(daConCriterion, sqlConCriterion, dsConCriterion)
            'Updatedata(daTray, sqlTray, dsTray)
            ShowTray()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterInsert
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "计" & dvDeal.Count & "个"
    End Sub

    Private Sub C1DBG_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterDelete
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "计" & dvDeal.Count & "个"
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Me.C1DBG.Col = 4 Then
            Me.C1DBG.Row += 1
            Me.C1DBG.Col = 2
            SendKeys.Send("{Left}")
        End If
    End Sub
    Dim iLastPos(3) As Integer

    Private Sub C1Show_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1Show.AfterColUpdate
        
        'Dim strColName As String
        'strColName = Me.C1Show.Columns(e.ColIndex).DataField
        'Select Case strColName
        '    Case "TEMPERATURE_SETTING"
        '        If Me.C1Show.Columns("TEMPERATURE_SETTING").Text <> "" Then
        '            Me.C1Show.Columns("TEMPERATURE_UNIT").Text = "C"
        '        Else
        '            Me.C1Show.Columns("TEMPERATURE_UNIT").Value = System.DBNull.Value
        '        End If

        'End Select

    End Sub

    Private Sub C1Show_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles C1Show.BeforeColUpdate
        Try
            '新旧值不等才执行       CellText为旧值 Text为新值
            'If Me.C1Show.Columns(e.ColIndex).Text <> Me.C1Show.Columns(e.ColIndex).Text.Trim.ToUpper Then
            '    Me.C1Show.Columns(e.ColIndex).Text = Me.C1Show.Columns(e.ColIndex).Text.Trim.ToUpper
            'End If
            If String.Compare(Me.C1Show.Columns(e.ColIndex).Text, Me.C1Show.Columns(e.ColIndex).CellText(Me.C1Show.Row), True) <> 0 Then
                Dim drNewrow As DataRow
                Dim i As Integer
                Dim strUniqueKey As String
                Dim strColName As String
                strColName = Me.C1Show.Columns(e.ColIndex).DataField.ToUpper
                Select Case strColName
                    Case "SIZE_CON", "CONTAINER_TYPE"
                        If Me.C1Show.Columns("CONTAINER_NO").Text <> "" Then
                            strUniqueKey = Me.C1Show.Columns("CONTAINER_NO").Text
                            If String.Compare(strUniqueKey, dvConCriterion(iLastPos(1))("CONTAINER_NO"), True) = 0 Then
                                i = iLastPos(1)
                            Else
                                For i = 0 To dvConCriterion.Count - 1
                                    If String.Compare(strUniqueKey, dvConCriterion(i)("CONTAINER_NO"), True) = 0 Then
                                        Exit For
                                    End If
                                Next
                            End If
                            If i < dvConCriterion.Count Then    '找到   修改
                            Else    '找不到 如果箱号存在就增加
                                If strUniqueKey <> "" Then
                                    drNewrow = dvConCriterion.Table.NewRow()
                                    dvConCriterion.Table.Rows.Add(drNewrow)
                                    dvConCriterion(i)("CONTAINER_NO") = strUniqueKey
                                End If
                            End If
                            If Me.C1Show.Columns(strColName).Text <> "" Then
                                dvConCriterion(i)(strColName) = Me.C1Show.Columns(strColName).Text
                            End If
                            If IsDBNull(dvConCriterion(i)("CON_WEIGHT")) Then
                                Select Case Me.C1Show.Columns("SIZE_CON").Text
                                    Case "20"
                                        dvConCriterion(i)("CON_WEIGHT") = 2300
                                    Case "40"
                                        If Me.C1Show.Columns("CONTAINER_TYPE").Text Like "*H*" Then
                                            dvConCriterion(i)("CON_WEIGHT") = 4000
                                        Else
                                            dvConCriterion(i)("CON_WEIGHT") = 3800
                                        End If
                                    Case "45"
                                        dvConCriterion(i)("CON_WEIGHT") = 5000
                                End Select
                            End If
                            iLastPos(1) = i
                        End If
                    Case "Tray".ToUpper
                        If IsDBNull(e.OldValue) Then
                            If Me.C1Show.Columns("Tray").Text <> "" Then
                                '增加
                                iLastPos(2) = dvTray.Count
                                drNewrow = dvTray.Table.NewRow()
                                dvTray.Table.Rows.Add(drNewrow)
                                dvTray(iLastPos(2))("Tray") = Me.C1Show.Columns("Tray").Text
                                If Me.C1Show.Columns("BayNo").Text <> "" Then
                                    dvTray(iLastPos(2))("BayNo") = Me.C1Show.Columns("BayNo").Text
                                End If
                            End If
                        Else
                            '查找
                            strUniqueKey = Me.C1Show.Columns("Tray").CellText(Me.C1Show.Row)    '旧值
                            If String.Compare(strUniqueKey, dvTray(iLastPos(2))("Tray"), True) = 0 Then
                                i = iLastPos(2)
                            Else
                                For i = 0 To dvTray.Count - 1
                                    If String.Compare(strUniqueKey, dvTray(i)("Tray"), True) = 0 Then
                                        Exit For
                                    End If
                                Next
                            End If
                            If i < dvTray.Count Then
                                If Me.C1Show.Columns("Tray").Text <> "" Then
                                    '修改
                                    dvTray(i)("Tray") = Me.C1Show.Columns("Tray").Text
                                    iLastPos(2) = i
                                Else
                                    '删除
                                    dvTray(i).Delete()
                                End If
                            End If
                        End If
                    Case Else

                        If strColName = "BayNo".ToUpper Then
                            '改托盘表
                            If Me.C1Show.Columns("Tray").Text <> "" Then
                                strUniqueKey = Me.C1Show.Columns("Tray").Text
                                If String.Compare(strUniqueKey, dvTray(iLastPos(2))("Tray"), True) = 0 Then
                                    i = iLastPos(2)
                                Else
                                    For i = 0 To dvTray.Count - 1
                                        If String.Compare(strUniqueKey, dvTray(i)("Tray"), True) = 0 Then
                                            Exit For
                                        End If
                                    Next
                                End If
                                If i < dvTray.Count Then
                                    dvTray(i)(strColName) = Me.C1Show.Columns(strColName).Text
                                    iLastPos(2) = i
                                End If
                            End If
                        End If
                        '改船图表
                        If Me.C1Show.Columns("CONTAINER_NO").Text <> "" Then
                            strUniqueKey = Me.C1Show.Columns("CONTAINER_NO").Text
                            If String.Compare(strUniqueKey, dvConImage(iLastPos(0))("CONTAINER_NO"), True) = 0 Then
                                i = iLastPos(0)
                            Else
                                For i = 0 To dvConImage.Count - 1
                                    If String.Compare(strUniqueKey, dvConImage(i)("CONTAINER_NO"), True) = 0 Then
                                        Exit For
                                    End If
                                Next
                            End If
                            If i < dvConImage.Count Then    '找到   修改
                                dvConImage(i)(strColName) = Me.C1Show.Columns(strColName).Text
                                iLastPos(0) = i
                            End If
                        End If
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnOnlyTray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOnlyTray.Click
        Dim frm As New FrmConImage_TrayOnly
        frm.ShowDialog()
        Updatedata(daConImage, sqlConImage, dsConImage)
        Updatedata(daConCriterion, sqlConCriterion, dsConCriterion)
        Updatedata(daTray, sqlTray, dsTray)
        ShowTray()
    End Sub

    Private Sub C1Show_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1Show.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Me.C1Show.Col = 9 Then
            Me.C1Show.Row += 1
            Me.C1Show.Col = 0
            SendKeys.Send("{Left}")
        End If
    End Sub

    Private Sub C1Show_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1Show.AfterColEdit

    End Sub

    Private Sub C1Show_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles C1Show.BeforeColEdit
        If Me.C1Show.Columns(e.ColIndex).Text <> Me.C1Show.Columns(e.ColIndex).Text.Trim.ToUpper Then
            Me.C1Show.Columns(e.ColIndex).Text = Me.C1Show.Columns(e.ColIndex).Text.Trim.ToUpper
        End If
    End Sub
End Class
