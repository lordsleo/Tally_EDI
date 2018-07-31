Imports TALLY.DBControl
Public Class FrmConImageCargo_DealSub
    Inherits System.Windows.Forms.Form

    Dim dvContainer As New DataView()
    Dim dvConOg As New DataView()
    Dim strExportShipID As String
    Public CountCon As Integer

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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConImageCargo_DealSub))
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(2, 44)
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
        Me.C1DBG.Size = New System.Drawing.Size(314, 208)
        Me.C1DBG.TabIndex = 11
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        " HorizontalScrollGroup=""1""><ClientRect>0, 0, 310, 204</ClientRect><BorderSide>0<" & _
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
        "</DefaultRecSelWidth><ClientArea>0, 0, 310, 204</ClientArea><PrintPageHeaderStyl" & _
        "e parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob" & _
        ">"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 36)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "以下是导出船次中非连云港卸货箱在导入船次中箱号不存在而贝位号存在的数据信息。 修改贝位号确认导出。"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(160, 260)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 577
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(92, 260)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 576
        Me.btSave.Text = "确认"
        '
        'FrmConImageCargo_DealSub
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(318, 291)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C1DBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConImageCargo_DealSub"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱船图信息 导出特殊情况"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConImageCargo_DealSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlContainer As String
        strExportShipID = FrmConImageCargo_Deal.strNewShipID
        sqlContainer = FrmConImageCargo_Deal.sqlExistBay
        dvContainer = Filldata(sqlContainer)
        dvConOg = Filldata(sqlContainer)
        Me.C1DBG.DataSource = dvContainer
        Me.C1DBG.Columns("CONTAINER_NO").Caption = "集装箱号"
        Me.C1DBG.Columns("BAYNO").Caption = "贝位号"
        Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Locked = True

        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "合计" & dvContainer.Count & "条"
        'Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Visible = True
        'Me.C1DBG.Splits(0).DisplayColumns("BAYNO").Visible = True
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlExistBay, sqlInsertCon As String
        Dim dvExistBay As New DataView()
        Dim i, j As Integer
        Dim bayi, bayj As String

        Try
            For i = 0 To dvContainer.Count - 1  '贝位号检查(界面)
                bayi = Me.C1DBG.Columns("BAYNO").CellText(i)
                If bayi Like "######" Then
                    For j = i + 1 To dvContainer.Count - 1
                        bayj = Me.C1DBG.Columns("BAYNO").CellText(j)
                        If bayj Like "######" Then
                            If Mid(bayi, 3, 4) = Mid(bayj, 3, 4) Then
                                If Mid(bayi, 1, 2) = Mid(bayj, 1, 2) Or Mid(Mid(bayi, 1, 2) + 200 + 1, 2, 2) = Mid(bayj, 1, 2) Or Mid(Mid(bayi, 1, 2) + 200 - 1, 2, 2) = Mid(bayj, 1, 2) Then
                                    MessageBox.Show("第" & (i + 1) & "行和第" & (j + 1) & "行贝位号相同或是通贝情况，请重新输入贝位号", "提示")
                                    Me.C1DBG.Row = i
                                    Exit Sub
                                End If
                            End If
                        Else
                            MessageBox.Show("第" & (j + 1) & "行贝位号不规范", "提示")
                            Me.C1DBG.Row = j
                            Exit Sub
                        End If
                    Next
                Else
                    MessageBox.Show("第" & (i + 1) & "行贝位号不规范", "提示")
                    Me.C1DBG.Row = i
                    Exit For
                End If
            Next

            If i >= dvContainer.Count Then
                For i = 0 To dvContainer.Count - 1  '贝位号检查（数据库）
                    bayi = Me.C1DBG.Columns("BAYNO").CellText(i)
                    sqlExistBay = "SELECT CONTAINER_NO, BAYNO FROM CON_IMAGE WHERE SHIP_ID = '" & strExportShipID & "' AND ( BAYNO = '" & bayi & "' " & _
                    "or substring(cast('2'+substring(BAYNO,1,2)+1 as char(3))+right(BAYNO,4),2,6) = '" & bayi & "' or substring(cast('2'+substring(BAYNO,1,2)-1 as char(3))+right(BAYNO,4),2,6) = '" & bayi & "') "

                    dvExistBay = Filldata(sqlExistBay)
                    If dvExistBay.Count > 0 Then
                        MessageBox.Show("此贝位号在导出船次中存在，请重新输入贝位号", "提示")
                        Me.C1DBG.Row = i
                        Exit For
                    End If
                Next
            End If
            '不仅新贝位号要在导入船次中不存在，也不能和同批正常导出（箱号贝位号都不同）的箱贝位号有重复
            '此处没有同后者检验，因为在前面程序中让正常导出的代码先执行，将这部分导出放到最后执行，
            '要和后者检验的贝位号已存入导入船次中，通过以上检查就可以包括两种情况

            Dim oldBayNo As String
            If i >= dvContainer.Count Then  '贝位号检查不重复，可以插入
                For i = 0 To dvContainer.Count - 1
                    'oldBayNo = "000000"
                    'For j = 0 To dvConOg.Count - 1
                    '    If Me.C1DBG.Columns("CONTAINER_NO").CellText(i) = dvConOg(j)("CONTAINER_NO") Then
                    '        oldBayNo = dvConOg(j)("BAYNO")
                    '        Exit For
                    '    End If
                    'Next            '其实根本不要找原贝位号，用select可以找到
                    'sqlInsertCon = "insert into CON_IMAGE " & _
                    '    "SELECT  '" & strExportShipID & "', CONTAINER_NO, FULLOREMPTY, SEALNO, '" & Me.C1DBG.Columns("BAYNO").CellText(i) & "', BLNO, CODE_LOAD_PORT, LOAD_PORT, CODE_UNLOAD_PORT, UNLOAD_PORT, CODE_DELIVERY, DELIVERY, AMOUNT, GROSSWEIGHT, VOLUME, TEMPERATURE_UNIT, TEMPERATURE_SETTING, MIN_TEMPERATURE, MAX_TEMPERATURE, DANGER_GRADE, DANGER_PAGENO, DANGER_NO, DANGER_MARK, PASS_MARK, SHORT_UNLOAD, UNLOAD_MARK, '" & G_User & "', Demo, ConDemo, '" & oldBayNo & "' FROM CON_IMAGE " & _
                    '    "WHERE SHIP_ID = '" & Ship_ID & "' and CODE_UNLOAD_PORT not like '%LYG%' and CONTAINER_NO ='" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "'"
                    sqlInsertCon = "insert into CON_IMAGE (SHIP_ID, CONTAINER_NO, FULLOREMPTY, SEALNO, BAYNO, BLNO, CODE_LOAD_PORT, Load_Port, CODE_UNLOAD_PORT, Unload_Port, CODE_DELIVERY, DELIVERY, AMOUNT, GROSSWEIGHT, VOLUME, TEMPERATURE_UNIT, TEMPERATURE_SETTING, MIN_TEMPERATURE, MAX_TEMPERATURE, DANGER_GRADE, DANGER_PAGENO, DANGER_NO, DANGER_MARK, PASS_MARK, SHORT_UNLOAD, UNLOAD_MARK, USER_NAME, Demo, ConDemo, OLDBAYNO, MOVED, USER_CODE,CodeLoadPort,CodeUnLoadPort,CodeDelivery,CodeConType,Code_Con_Company)" & _
                        "SELECT  '" & strExportShipID & "', CONTAINER_NO, FULLOREMPTY, SEALNO, '" & Me.C1DBG.Columns("BAYNO").CellText(i) & "', BLNO, CODE_LOAD_PORT, LOAD_PORT, CODE_UNLOAD_PORT, UNLOAD_PORT, CODE_DELIVERY, DELIVERY, AMOUNT, GROSSWEIGHT, VOLUME, TEMPERATURE_UNIT, TEMPERATURE_SETTING, MIN_TEMPERATURE, MAX_TEMPERATURE, DANGER_GRADE, DANGER_PAGENO, DANGER_NO, DANGER_MARK, PASS_MARK, SHORT_UNLOAD, UNLOAD_MARK, '" & G_User & "', Demo, ConDemo, BayNo, 1, USER_CODE,CodeLoadPort,CodeUnLoadPort,CodeDelivery,CodeConType,Code_Con_Company FROM CON_IMAGE " & _
                        "WHERE SHIP_ID = '" & Ship_ID & "' and CODE_UNLOAD_PORT not like '%LYG%' and CONTAINER_NO ='" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "' "
                    ExecSql(sqlInsertCon)
                Next
                CountCon = dvContainer.Count
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
