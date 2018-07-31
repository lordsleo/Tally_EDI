Imports TALLY.DBControl
Public Class FrmConImageCargo_UnloadPort
    Inherits System.Windows.Forms.Form

    Dim dvPortNow As New DataView
    Dim dvPortOg As New DataView
    Dim dsPortOg As New DataSet

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
    Friend WithEvents lbUnLoadPortOg As System.Windows.Forms.ListBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnTotalRight As System.Windows.Forms.Button
    Friend WithEvents btnSingleRight As System.Windows.Forms.Button
    Friend WithEvents btnSingleLeft As System.Windows.Forms.Button
    Friend WithEvents ckbAll As System.Windows.Forms.CheckBox
    Friend WithEvents cbPortNow As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConImageCargo_UnloadPort))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbPortNow = New System.Windows.Forms.ComboBox
        Me.lbUnLoadPortOg = New System.Windows.Forms.ListBox
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnTotalRight = New System.Windows.Forms.Button
        Me.btnSingleRight = New System.Windows.Forms.Button
        Me.btnSingleLeft = New System.Windows.Forms.Button
        Me.ckbAll = New System.Windows.Forms.CheckBox
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "该船次所有卸货港"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(274, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "新的港名"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbPortNow
        '
        Me.cbPortNow.Location = New System.Drawing.Point(272, 284)
        Me.cbPortNow.MaxDropDownItems = 20
        Me.cbPortNow.Name = "cbPortNow"
        Me.cbPortNow.Size = New System.Drawing.Size(132, 20)
        Me.cbPortNow.TabIndex = 1
        '
        'lbUnLoadPortOg
        '
        Me.lbUnLoadPortOg.ItemHeight = 12
        Me.lbUnLoadPortOg.Location = New System.Drawing.Point(276, 24)
        Me.lbUnLoadPortOg.Name = "lbUnLoadPortOg"
        Me.lbUnLoadPortOg.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbUnLoadPortOg.Size = New System.Drawing.Size(128, 232)
        Me.lbUnLoadPortOg.Sorted = True
        Me.lbUnLoadPortOg.TabIndex = 0
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(238, 314)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 580
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(170, 314)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 2
        Me.btSave.Text = "确认"
        '
        'C1DBG
        '
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.FetchRowStyles = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 24)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(212, 280)
        Me.C1DBG.TabIndex = 581
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" FetchRowStyles=""True"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><Height>276</Height><CaptionStyle parent=""Style2"" me=" & _
        """Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""Eve" & _
        "nRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterSty" & _
        "le parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><Head" & _
        "ingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow""" & _
        " me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle paren" & _
        "t=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style1" & _
        "1"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""S" & _
        "tyle1"" /><ClientRect>0, 0, 208, 276</ClientRect><BorderSide>0</BorderSide><Borde" & _
        "rStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles" & _
        "><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style par" & _
        "ent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent" & _
        "=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=" & _
        """Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=" & _
        """Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Head" & _
        "ing"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent" & _
        "=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</h" & _
        "orzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><Clien" & _
        "tArea>0, 0, 208, 276</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" />" & _
        "<PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(280, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 582
        Me.Label3.Text = "将要变更的港名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnTotalRight
        '
        Me.btnTotalRight.Location = New System.Drawing.Point(220, 212)
        Me.btnTotalRight.Name = "btnTotalRight"
        Me.btnTotalRight.Size = New System.Drawing.Size(48, 24)
        Me.btnTotalRight.TabIndex = 586
        Me.btnTotalRight.Text = "<< "
        '
        'btnSingleRight
        '
        Me.btnSingleRight.Location = New System.Drawing.Point(220, 112)
        Me.btnSingleRight.Name = "btnSingleRight"
        Me.btnSingleRight.Size = New System.Drawing.Size(48, 24)
        Me.btnSingleRight.TabIndex = 585
        Me.btnSingleRight.Text = "<"
        '
        'btnSingleLeft
        '
        Me.btnSingleLeft.Location = New System.Drawing.Point(220, 74)
        Me.btnSingleLeft.Name = "btnSingleLeft"
        Me.btnSingleLeft.Size = New System.Drawing.Size(48, 24)
        Me.btnSingleLeft.TabIndex = 583
        Me.btnSingleLeft.Text = ">"
        '
        'ckbAll
        '
        Me.ckbAll.Location = New System.Drawing.Point(14, 314)
        Me.ckbAll.Name = "ckbAll"
        Me.ckbAll.Size = New System.Drawing.Size(90, 24)
        Me.ckbAll.TabIndex = 587
        Me.ckbAll.Text = "全部改变"
        '
        'FrmConImageCargo_UnloadPort
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(404, 347)
        Me.Controls.Add(Me.ckbAll)
        Me.Controls.Add(Me.btnTotalRight)
        Me.Controls.Add(Me.btnSingleRight)
        Me.Controls.Add(Me.btnSingleLeft)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.lbUnLoadPortOg)
        Me.Controls.Add(Me.cbPortNow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConImageCargo_UnloadPort"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱船图信息 卸货港修改"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConImageCargo_UnloadPort_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlPortNow As String
        sqlPortNow = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY PORT_CHA"
        dvPortNow = Filldata(sqlPortNow)
        Me.cbPortNow.DataSource = dvPortNow
        Me.cbPortNow.DisplayMember = "PORT_CHA"
        Me.cbPortNow.ValueMember = "CODE_PORT"

        Me.C1DBG.FetchRowStyles = True
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

        Dim sqlPortOg As String
        sqlPortOg = "SELECT DISTINCT CODE_UNLOAD_PORT, PORT_CHA, PORT_Eng FROM CON_IMAGE LEFT OUTER JOIN CODE_PORT ON CODE_UNLOAD_PORT = CODE_PORT WHERE (SHIP_ID = '" & Ship_ID & "') order by code_unload_port "
        Try
            Call GetPort(sqlPortOg)
            Dim i As Integer
            Me.C1DBG.Focus()
            For i = 0 To dvPortOg.Count - 1
                Me.C1DBG.Row = i
                Me.C1DBG.Columns("Flag").Value = "0"
            Next
            Me.btQuit.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GetPort(ByVal sqlGetPort As String)
        Getdata(sqlGetPort, dsPortOg)
        dsPortOg.Tables(0).Columns.Add("flag", GetType(String))
        dsPortOg.Tables(0).Columns("flag").DefaultValue = "0"
        dvPortOg = dsPortOg.Tables(0).DefaultView
        Me.C1DBG.DataSource = dvPortOg
        Try
            Me.C1DBG.Columns("CODE_UNLOAD_PORT").Caption = "卸港代码"
            Me.C1DBG.Columns("PORT_CHA").Caption = "卸港中文"
            Me.C1DBG.Columns("PORT_Eng").Caption = "卸港英文"
            Me.C1DBG.Splits(0).DisplayColumns("flag").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("CODE_UNLOAD_PORT").Width = 50
            Me.C1DBG.Splits(0).DisplayColumns("PORT_CHA").Width = 70
            Me.C1DBG.Splits(0).DisplayColumns("PORT_Eng").Width = 70
            Me.C1DBG.Columns("CODE_UNLOAD_PORT").FooterText = "计" & dvPortOg.Count & "港"
         
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlAlterUnLoadPort As String
        If Me.lbUnLoadPortOg.Items.Count = dvPortOg.Count Then
            Me.ckbAll.Checked = True
        End If
        If Me.cbPortNow.SelectedIndex < 0 Then
            MessageBox.Show("请选择已存在的港口。", "提示")
            Exit Sub
        End If
        If Me.ckbAll.Checked = True Then
            sqlAlterUnLoadPort = "UPDATE CON_IMAGE SET CODE_UNLOAD_PORT = '" & Me.cbPortNow.SelectedValue & "', Unload_Port = '" & dvPortNow(Me.cbPortNow.SelectedIndex)("PORT_Eng") & "' WHERE (SHIP_ID = '" & Ship_ID & "')"
        Else
            If Me.lbUnLoadPortOg.Items.Count > 0 Then
                sqlAlterUnLoadPort = " CODE_UNLOAD_PORT='" & Me.lbUnLoadPortOg.Items(0) & "' "
                Dim i As Integer
                For i = 1 To Me.lbUnLoadPortOg.Items.Count - 1
                    sqlAlterUnLoadPort = sqlAlterUnLoadPort & "or CODE_UNLOAD_PORT='" & Me.lbUnLoadPortOg.Items(i) & "' "
                Next
                sqlAlterUnLoadPort = "(" & sqlAlterUnLoadPort & ")"
                'UPDATE CON_IMAGE SET CODE_UNLOAD_PORT = '', Unload_Port = '' WHERE (SHIP_ID = '') AND (CODE_UNLOAD_PORT = '')
                sqlAlterUnLoadPort = "UPDATE CON_IMAGE SET CODE_UNLOAD_PORT = '" & Me.cbPortNow.SelectedValue & "', Unload_Port = '" & dvPortNow(Me.cbPortNow.SelectedIndex)("PORT_Eng") & "' WHERE (SHIP_ID = '" & Ship_ID & "') AND " & sqlAlterUnLoadPort
            Else
                MessageBox.Show("请选择要更改的港口。", "提示")
                Exit Sub
            End If
        End If
        If MessageBox.Show("即将变更选中的卸货港为新港名‘" & Me.cbPortNow.Text & "’，可以吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            ExecSql(sqlAlterUnLoadPort)
            Me.Close()
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub ckbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbAll.CheckedChanged
        If Me.ckbAll.Checked = True Then
            Dim i As Integer
            Me.C1DBG.Focus()
            For i = 0 To dvPortOg.Count - 1
                Me.C1DBG.Row = i
                If Me.C1DBG.Columns("flag").Text = "0" Then
                    Me.lbUnLoadPortOg.Items.Add(Me.C1DBG.Columns("CODE_UNLOAD_PORT").Text)
                    Me.C1DBG.Columns("flag").Text = "1"
                End If
            Next
            Me.btQuit.Focus()
            Me.C1DBG.Focus()
            Me.btnSingleLeft.Enabled = False
            Me.btnSingleRight.Enabled = False
            Me.btnTotalRight.Enabled = False
        Else
            Me.btnSingleLeft.Enabled = True
            Me.btnSingleRight.Enabled = True
            Me.btnTotalRight.Enabled = True
        End If
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Not IsDBNull(Me.C1DBG.Columns("flag").CellValue(e.Row)) Then
            If Me.C1DBG.Columns("flag").CellValue(e.Row) = "1" Then
                e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
            End If
        End If
    End Sub

    Private Sub btnSingleLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSingleLeft.Click
        Dim i As Integer
        Me.C1DBG.Focus()
        For i = 0 To Me.C1DBG.SelectedRows.Count - 1
            Me.C1DBG.Row = Me.C1DBG.SelectedRows(i)
            If Me.C1DBG.Columns("flag").Text = "0" Then
                Me.lbUnLoadPortOg.Items.Add(Me.C1DBG.Columns("CODE_UNLOAD_PORT").Text)
                Me.C1DBG.Columns("flag").Text = "1"
            End If
        Next
        Me.btQuit.Focus()
        Me.C1DBG.Focus()
    End Sub

    Private Sub btnSingleRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSingleRight.Click
        Dim i, j As Integer
        Me.C1DBG.Focus()
        'me.lbUnLoadPortOg.SelectedIndices.Item(0)

        For i = 0 To Me.lbUnLoadPortOg.SelectedItems.Count - 1  '虽然循环中移除选中项，.Count也自动减一，却并不影响这里的循环条件
            For j = 0 To dvPortOg.Count - 1
                Me.C1DBG.Row = j
                If Me.C1DBG.Columns("CODE_UNLOAD_PORT").Text = Me.lbUnLoadPortOg.SelectedItems.Item(0) Then
                    Me.C1DBG.Columns("flag").Text = "0"
                End If
            Next
            Me.lbUnLoadPortOg.Items.Remove(Me.lbUnLoadPortOg.SelectedItems.Item(0))
        Next
        Me.lbUnLoadPortOg.Focus()
    End Sub

    Private Sub btnTotalRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalRight.Click
        Dim i As Integer
        Me.C1DBG.Focus()
        For i = 0 To dvPortOg.Count - 1
            Me.C1DBG.Row = i
            Me.C1DBG.Columns("flag").Text = "0"
        Next
        Me.btQuit.Focus()
        Me.C1DBG.Focus()
        Me.lbUnLoadPortOg.Items.Clear()
    End Sub

    Private Sub cbPortNow_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPortNow.Leave
        Try
            Dim i As Integer
            For i = 0 To dvPortNow.Count - 1
                If Not IsDBNull(dvPortNow(i)("PORT_CHA")) Then
                    If dvPortNow(i)("CODE_PORT") Like Me.cbPortNow.Text.Trim.ToUpper & "*" Or dvPortNow(i)("PORT_CHA") Like Me.cbPortNow.Text.Trim.ToUpper & "*" Then
                        Me.cbPortNow.SelectedValue = dvPortNow(i)("CODE_PORT")
                        Exit For
                    End If
                Else
                    If dvPortNow(i)("CODE_PORT") Like Me.cbPortNow.Text.Trim.ToUpper & "*" Then
                        Me.cbPortNow.SelectedValue = dvPortNow(i)("CODE_PORT")
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbPortNow_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbPortNow.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btSave.Focus()
        End If
    End Sub
End Class
