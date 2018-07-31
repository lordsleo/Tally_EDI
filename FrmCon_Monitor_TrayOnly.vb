Imports TALLY.DBControl
Public Class FrmCon_Monitor_TrayOnly
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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCon_Monitor_TrayOnly))
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(326, 356)
        Me.C1DBG.TabIndex = 580
        Me.C1DBG.Text = "C1DBG"
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
        "ticalScrollGroup=""1"" HorizontalScrollGroup=""1""><Height>352</Height><CaptionStyle" & _
        " parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><Even" & _
        "RowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""S" & _
        "tyle13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" " & _
        "me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle p" & _
        "arent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" " & _
        "/><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""Record" & _
        "Selector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style p" & _
        "arent=""Normal"" me=""Style1"" /><ClientRect>0, 0, 322, 352</ClientRect><BorderSide>" & _
        "0</BorderSide><BorderStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView><" & _
        "/Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""H" & _
        "eading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Capt" & _
        "ion"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Select" & _
        "ed"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightR" & _
        "ow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /" & _
        "><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""Filter" & _
        "Bar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSpl" & _
        "its><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</Defau" & _
        "ltRecSelWidth><ClientArea>0, 0, 322, 352</ClientArea><PrintPageHeaderStyle paren" & _
        "t="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'btQuit
        '
        Me.btQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(191, 382)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 583
        Me.btQuit.Text = "退出"
        '
        'btSave
        '
        Me.btSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btSave.Location = New System.Drawing.Point(71, 382)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 582
        Me.btSave.Text = "确认"
        '
        'FrmCon_Monitor_TrayOnly
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(326, 435)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.C1DBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCon_Monitor_TrayOnly"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "单独处理托盘"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlDeal As String
    Dim dvDeal As DataView
    Dim daDeal As New SqlClient.SqlDataAdapter
    Dim dsDeal As New DataSet
    Dim str_query, bh, bhno As String
    Dim dsbox, dscontally, dsboxtemp, dsno As New DataSet
    Dim bhlen As Integer

    Private Sub FrmCon_Monitor_TrayOnly_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitDealTray()
    End Sub

    Private Sub InitDealTray()
        sqlDeal = "Select ID,SHIP_ID,TRAY,BAYNO,USER_NAME from Con_Image_Tray where Ship_ID =" & Ship_ID & " and unload_mark=0 and tray is not null "
        dvDeal = Updatedata(daDeal, sqlDeal, dsDeal)
        dvDeal.Table.Columns("SHIP_ID").DefaultValue = Ship_ID
        dvDeal.Table.Columns("USER_NAME").DefaultValue = G_User
        Me.C1DBG.DataSource = dvDeal
        Me.C1DBG.Columns("TRAY").Caption = "托盘号"
        Me.C1DBG.Columns("BAYNO").Caption = "贝位号"
        Me.C1DBG.Splits(0).DisplayColumns("ID").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("SHIP_ID").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("USER_NAME").Visible = False
        SetDGWidthFull(Me.C1DBG)
        Me.C1DBG.Columns("TRAY").FooterText = "计" & dvDeal.Count & "项"
        If dvDeal.Count > 0 Then
            btSave.Enabled = True
        Else
            btSave.Enabled = False
        End If
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        tallytray()
        InitDealTray()
        'daDeal.Update(dsDeal) 
        'dsDeal.AcceptChanges()
    End Sub

    Private Sub tallytray()
        Dim t As String
        Dim tt As DateTime
        Dim endtime As String

        t = C1DBG.Row
        tt = Date.Now
        endtime = tt.Hour.ToString().PadLeft(2, "0") + tt.Minute.ToString().PadLeft(2, "0")

        str_query = "SELECT max(NO) from CON_TALLY_LIST where ship_id='" & Ship_ID & "' and TEAM_NO='99' AND TALLY_CLERK1='" & G_WorkNo & "' and inout_mark='3' and reload='3'"
        Getdata(str_query, dsbox)
        If (dsbox.Tables(0).Rows(0)(0) Is System.DBNull.Value) Then
            bhno = "tp" + G_WorkNo & "99" & "0001"
        Else
            bhlen = System.Convert.ToString(dsbox.Tables(0).Rows(0)(0)).Length
            bh = System.Convert.ToInt64(System.Convert.ToString(dsbox.Tables(0).Rows(0)(0)).Substring(10)) + 1
            bhno = System.Convert.ToString(dsbox.Tables(0).Rows(0)(0)).Substring(0, 10) + System.Convert.ToString(bh).PadLeft(bhlen - 10, "0")
        End If
        str_query = " INSERT INTO CON_TALLY_LIST(SHIP_ID, TEAM_NO, NO, DATE, TIME_FROM, TIME_TO, BerthNO, NIGHT_MARK, HOLIDAY, INOUT_MARK, RELOAD, ANCHORAGE_REMARK, SEA_AFFAIRE_CARGO, Tally_Clerk1, USER_NAME) VALUES('" & Ship_ID & "','99','" & bhno & "','" & tt & "','" & endtime & "','" & endtime & "','0','0','0','3','3','0','0','" & G_WorkNo & "','" & G_WorkNo & "')"
        ExecSql(str_query)
        str_query = "select con_tally_list_id from CON_TALLY_LIST where ship_id='" & Ship_ID & "' and no='" & bhno & "'"
        Getdata(str_query, dscontally)
        str_query = "SELECT * from Con_Image_Tray where ID='" & C1DBG.Columns(0).CellText(t) & "'"
        Getdata(str_query, dsboxtemp)
        str_query = "INSERT INTO CON_TALLY_DETAIL(CON_TALLY_LIST_ID, CONTAINER_NO, BAYNO, UnLoad_Mark) VALUES ('" & dscontally.Tables(0).Rows(0)(0) & "','" & dsboxtemp.Tables(0).Rows(0)("tray") & "','" & dsboxtemp.Tables(0).Rows(0)("BAYNO") & "','1')"
        ExecSql(str_query)

        str_query = "SELECT * from CON_IMAGE_TRAY where ship_id='" & Ship_ID & "' and tray='" & dsboxtemp.Tables(0).Rows(0)("tray") & "' and BAYNO='" & dsboxtemp.Tables(0).Rows(0)("POS") & "'"
        Getdata(str_query, dsno)
        If dsno.Tables(0).Rows.Count > 0 Then
            ExecSql("update con_image_tray set unload_mark='1',CLERK='" & G_WorkNo & "',CLERKTIME='" & Date.Today & "' where ship_id='" & Ship_ID & "' and tray='" & dsboxtemp.Tables(0).Rows(0)("tray") & "'")
        Else
            'str_query = "insert into con_image_tray(SHIP_ID, TRAY, BAYNO, CLERK, USER_NAME, unload_mark, CLERKTIME) VALUES ('" & Ship_ID & "','" & dsboxtemp.Tables(0).Rows(0)("tray") & "','" & dsboxtemp.Tables(0).Rows(0)("BAYNO") & "','" & G_WorkNo & "','1','" & Date.Today & "')"
            'ExecSql(str_query)
        End If


        str_query = "SELECT * from CON_IMAGE_TRAY where ship_id='" & Ship_ID & "' and tray='" & dsboxtemp.Tables(0).Rows(0)("tray") & "' and BAYNO='" & dsboxtemp.Tables(0).Rows(0)("POS") & "'"
        Getdata(str_query, dsno)
        If dsno.Tables(0).Rows.Count > 0 Then
            ExecSql("update con_image_tray set unload_mark='1',CLERK='" & G_WorkNo & "',CLERKTIME='" & Date.Today & "' where ship_id='" & Ship_ID & "' and tray='" & dsboxtemp.Tables(0).Rows(0)("tray") & "' and BAYNO='" & dsboxtemp.Tables(0).Rows(0)("POS") & "' ")
        Else
            'str_query = "insert into con_image_tray(SHIP_ID, TRAY, BAYNO, CLERK, USER_NAME, unload_mark, CLERKTIME) VALUES ('" & Ship_ID & "','" & dsboxtemp.Tables(0).Rows(0)("tray") & "','" & dsboxtemp.Tables(0).Rows(0)("POS") & "','" & G_WorkNo & "','1','" & Date.Today & "')"
            'ExecSql(str_query)
        End If
    End Sub

    Private Sub C1DBG_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColEdit
        'If Me.C1DBG.Columns(e.ColIndex).Text <> Me.C1DBG.Columns(e.ColIndex).Text.Trim.ToUpper Then
        '    Me.C1DBG.Columns(e.ColIndex).Text = Me.C1DBG.Columns(e.ColIndex).Text.Trim.ToUpper
        'End If
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        'If e.KeyCode = Keys.Enter AndAlso Me.C1DBG.Col = 3 Then
        '    Me.C1DBG.Row += 1
        '    Me.C1DBG.Col = 2
        '    SendKeys.Send("{Left}")
        'End If
    End Sub

End Class
