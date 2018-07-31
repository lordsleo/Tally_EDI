Imports TALLY.DBControl
Public Class FrmConImageCargo_DelBill
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConImageCargo_DelBill))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBillNo = New System.Windows.Forms.TextBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "提单号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNo
        '
        Me.txtBillNo.Location = New System.Drawing.Point(88, 8)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(120, 21)
        Me.txtBillNo.TabIndex = 1
        Me.txtBillNo.Text = ""
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Popup
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 32)
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
        Me.C1DBG.Size = New System.Drawing.Size(400, 296)
        Me.C1DBG.TabIndex = 13
        Me.C1DBG.Text = "C1DBGV"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{BackColor:CadetBlue;}Ca" & _
        "ption{AlignHorz:Center;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;Bac" & _
        "kColor:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}He" & _
        "ading{Wrap:True;AlignVert:Center;Border:Flat,ControlDark,0, 1, 0, 1;ForeColor:Co" & _
        "ntrolText;BackColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}S" & _
        "tyle13{}Style1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" A" & _
        "llowRowSizing=""None"" CaptionHeight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHei" & _
        "ght=""18"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth" & _
        "=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 396, 2" & _
        "92</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2"" me=""Style" & _
        "10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" " & _
        "me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle par" & _
        "ent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingSty" & _
        "le parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""S" & _
        "tyle7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""Odd" & _
        "Row"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><" & _
        "SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1""" & _
        " /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""No" & _
        "rmal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer" & _
        """ /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive""" & _
        " /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><" & _
        "Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" />" & _
        "<Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector""" & _
        " /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" />" & _
        "</NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</" & _
        "Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 396, 292</Cl" & _
        "ientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle pa" & _
        "rent="""" me=""Style15"" /></Blob>"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(224, 336)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 579
        Me.btQuit.Text = "关闭"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(152, 336)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 578
        Me.btSave.Text = "确定"
        '
        'FrmConImageCargo_DelBill
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(402, 368)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.txtBillNo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConImageCargo_DelBill"
        Me.Text = "提单删除"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlGetCon As String
    Dim dvGetCon As DataView
    Dim strBillNo As String

    Private Sub FrmConImageCargo_DelBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillC1()
        txtBillNo_Leave(sender, e)
    End Sub

    Private Sub FillC1()

        sqlGetCon = "select BLNO,CONTAINER_NO,FULLOREMPTY,SEALNO,BAYNO,USER_NAME,Unload_Mark from Con_Image where Ship_ID=" & Ship_ID & " order by CONTAINER_NO"
        dvGetCon = Filldata(sqlGetCon)
        Me.C1DBG.DataSource = dvGetCon
        Me.C1DBG.Columns("CONTAINER_NO").Caption = "箱号"
        Me.C1DBG.Columns("FULLOREMPTY").Caption = "空重"
        Me.C1DBG.Columns("SEALNO").Caption = "铅封"
        Me.C1DBG.Columns("BAYNO").Caption = "贝位"
        Me.C1DBG.Columns("USER_NAME").Caption = "录入"
        Me.C1DBG.Splits(0).DisplayColumns("BLNO").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("Unload_Mark").Visible = False
        SetDGWidth2(Me.C1DBG)
    End Sub

    Private Sub txtBillNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBillNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.C1DBG.Focus()
        End If
    End Sub

    Private Sub txtBillNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNo.Leave
        Me.txtBillNo.Text = Me.txtBillNo.Text.Trim().ToUpper()
        strBillNo = txtBillNo.Text
        dvGetCon.RowFilter = "BLNO='" & strBillNo & "'"
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "计" & dvGetCon.Count & "个"
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        If dvGetCon.Count > 0 Then
            If MessageBox.Show("确定要删除该提单吗？", "警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                dvGetCon.Sort = "CONTAINER_NO"
                Dim i As Integer
                Dim strTemp As String
                Dim sbTemp As New System.Text.StringBuilder(128, 2048)
                sbTemp.Append("BillNo=" & strBillNo & ",ConCount=" & dvGetCon.Count & ",")
                For i = 0 To dvGetCon.Count - 1
                    If sbTemp.Length < sbTemp.MaxCapacity - 12 Then
                        sbTemp.Append(Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & ",")
                    Else
                        sbTemp.Append(i & "未……,")
                        Exit For
                    End If
                Next
                sbTemp.Remove(sbTemp.Length - 1, 1)
                strTemp = sbTemp.ToString()
                If (System.Text.Encoding.Default.GetByteCount(strTemp) > sbTemp.MaxCapacity) Then
                    Dim byTemp As Byte()
                    byTemp = System.Text.Encoding.Default.GetBytes(strTemp)
                    strTemp = System.Text.Encoding.Default.GetString(byTemp, 0, sbTemp.MaxCapacity)
                End If

                Dim sqlDelLog As String
                sqlDelLog = "insert into OperateHistory (Dept_Name,OperateTime,OperateWorker,OperateType,OperateDemo,OperateTable) " & _
                    "values('" & G_DeptName & "',Getdate(),'" & G_User & "','提单删除','" & strTemp & "','Con_Image')"
                ExecSql(sqlDelLog)
                Dim sqlDelBill As String
                sqlDelBill = "delete from Con_Image where Ship_ID=" & Ship_ID & " and BLNO='" & strBillNo & "'"
                ExecSql(sqlDelBill)
                Me.Close()
            End If
        End If
    End Sub
End Class
