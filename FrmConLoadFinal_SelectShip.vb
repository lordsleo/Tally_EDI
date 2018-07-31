Imports TALLY.DBControl
Public Class FrmConLoadFinal_SelectShip
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
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents cbShipCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDefault As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadFinal_SelectShip))
        Me.GBV = New System.Windows.Forms.GroupBox
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btResure = New System.Windows.Forms.Button
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btSave = New System.Windows.Forms.Button
        Me.btQuit = New System.Windows.Forms.Button
        Me.btnTotal = New System.Windows.Forms.Button
        Me.cbShipCode = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnDefault = New System.Windows.Forms.Button
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBV
        '
        Me.GBV.Controls.Add(Me.C1DBGV)
        Me.GBV.Location = New System.Drawing.Point(2, 80)
        Me.GBV.Name = "GBV"
        Me.GBV.Size = New System.Drawing.Size(322, 456)
        Me.GBV.TabIndex = 21
        Me.GBV.TabStop = False
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.CaptionHeight = 18
        Me.C1DBGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(3, 17)
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
        Me.C1DBGV.Size = New System.Drawing.Size(316, 436)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 312, 432</ClientRect><BorderSide>0</BorderSide><CaptionSt" & _
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
        "ClientArea>0, 0, 312, 432</ClientArea><PrintPageHeaderStyle parent="""" me=""Style1" & _
        "4"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'btResure
        '
        Me.btResure.Location = New System.Drawing.Point(244, 58)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(64, 22)
        Me.btResure.TabIndex = 17
        Me.btResure.Text = "查找"
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(224, 30)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(90, 21)
        Me.txtVoyage.TabIndex = 16
        Me.txtVoyage.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(162, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "航次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(68, 30)
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(90, 21)
        Me.txtShip.TabIndex = 15
        Me.txtShip.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "船码/船名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "从下列出口船次中查找选择："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(174, 542)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 669
        Me.btSave.Text = "确定"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(244, 542)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 670
        Me.btQuit.Text = "取消"
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(6, 58)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(60, 22)
        Me.btnTotal.TabIndex = 671
        Me.btnTotal.Text = "全部"
        '
        'cbShipCode
        '
        Me.cbShipCode.Location = New System.Drawing.Point(48, 544)
        Me.cbShipCode.MaxDropDownItems = 25
        Me.cbShipCode.Name = "cbShipCode"
        Me.cbShipCode.Size = New System.Drawing.Size(116, 20)
        Me.cbShipCode.TabIndex = 672
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 544)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 673
        Me.Label4.Text = "补船码"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(78, 58)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(64, 22)
        Me.btnDefault.TabIndex = 674
        Me.btnDefault.Text = "默认"
        '
        'FrmConLoadFinal_SelectShip
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(324, 579)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbShipCode)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GBV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btResure)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVoyage)
        Me.Controls.Add(Me.txtShip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadFinal_SelectShip"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "选择船名航次"
        Me.GBV.ResumeLayout(False)
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shared beSureMark As Boolean
    Dim sqlGetShip As String
    Dim dvGetShip As New DataView
    Dim sqlShipCode As String
    Dim dvShipCode As New DataView
    Dim ShipMark As Boolean
    Dim ShipIdx As Integer

    Private Sub FrmConLoadFinal_SelectShip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        beSureMark = False
        ShipMark = True
        sqlShipCode = "SELECT SPCODE, CHI_VESSEL, SPCODE + ' ' + CHI_VESSEL AS Comb FROM Code_SHIPNAME ORDER BY CHI_VESSEL"
        dvShipCode = Filldata(sqlShipCode)
        Me.cbShipCode.DataSource = dvShipCode
        Me.cbShipCode.DisplayMember = "Comb"
        Me.cbShipCode.ValueMember = "SPCODE"

        sqlGetShip = "SELECT SHIP_ID, V_ID, Vessel_Code, SSHIP.CHI_VESSEL, SSHIP.ENG_VESSEL, VOYAGE, INOUTPORT, SHIP_STATU FROM SSHIP INNER JOIN VESSEL ON V_ID = VESSEL_ID " & _
                                    " where INOUTPORT='1'"
        dvGetShip = Filldata(sqlGetShip)
        Call GetShip()
        Call btnDefault_Click(sender, e)
        Me.C1DBGV.FetchRowStyles = True
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBGV.ColumnFooters = True
        Me.C1DBGV.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.txtShip.Focus()
    End Sub

    Private Sub GetShip()
        Me.C1DBGV.DataSource = dvGetShip
        Me.C1DBGV.Columns("CHI_VESSEL").Caption = "船名(中)"
        Me.C1DBGV.Columns("ENG_VESSEL").Caption = "船名(英)"
        Me.C1DBGV.Columns("Vessel_Code").Caption = "船码"
        Me.C1DBGV.Columns("VOYAGE").Caption = "航次"
        Me.C1DBGV.Columns("SHIP_STATU").Caption = "状态"
        Me.C1DBGV.Splits(0).DisplayColumns("SHIP_ID").Visible = False
        Me.C1DBGV.Splits(0).DisplayColumns("V_ID").Visible = False
        Me.C1DBGV.Splits(0).DisplayColumns("INOUTPORT").Visible = False
        Me.C1DBGV.Splits(0).DisplayColumns("CHI_VESSEL").Width = 70
        Me.C1DBGV.Splits(0).DisplayColumns("ENG_VESSEL").Width = 60
        Me.C1DBGV.Splits(0).DisplayColumns("Vessel_Code").Width = 40
        Me.C1DBGV.Splits(0).DisplayColumns("VOYAGE").Width = 50
        Me.C1DBGV.Splits(0).DisplayColumns("SHIP_STATU").Width = 30
    End Sub

    Private Sub C1DBGV_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGV.FetchRowStyle
        If Not IsDBNull(Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row)) Then
            If Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 1 Then
                e.CellStyle.BackColor = System.Drawing.Color.White
            ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 2 Then
                e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
            ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 3 Then
                e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
            ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 4 Then
                e.CellStyle.BackColor = System.Drawing.Color.Pink
            End If
        End If
    End Sub

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        If Me.txtShip.Text <> "" Then
            If Me.txtVoyage.Text <> "" Then
                dvGetShip.RowFilter = "(Vessel_Code='" & Me.txtShip.Text & "' or CHI_VESSEL='" & Me.txtShip.Text & "') and voyage='" & Me.txtVoyage.Text & "'"
            Else
                dvGetShip.RowFilter = "(Vessel_Code='" & Me.txtShip.Text & "' or CHI_VESSEL='" & Me.txtShip.Text & "')"
            End If
        Else
            If Me.txtVoyage.Text <> "" Then
                dvGetShip.RowFilter = "voyage='" & Me.txtVoyage.Text & "'"
            Else
                '什么也不做
            End If
        End If
        Me.C1DBGV.Columns("CHI_VESSEL").FooterText = "合计" & dvGetShip.Count & ""
        Me.C1DBGV.Focus()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlVesselRenew As String
        If dvGetShip.Count > 0 Then
            If Me.C1DBGV.Columns("Vessel_Code").Text = "" Then  '没有船码时
                If ShipMark = True Then '有船码选择操作
                    If MessageBox.Show("将要为该名为 " & Me.C1DBGV.Columns("CHI_VESSEL").Text & " 的船舶补充船码 " & Me.cbShipCode.SelectedValue & "，确定么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                        If Me.C1DBGV.Columns("CHI_VESSEL").Text <> Me.dvShipCode(ShipIdx)("CHI_VESSEL") Then    ' 船名不一致要提示
                            If MessageBox.Show("该船名" & Me.C1DBGV.Columns("CHI_VESSEL").Text & "和补充的船码对应船名" & Me.dvShipCode(ShipIdx)("CHI_VESSEL") & "不一致，确定无误么？", "提示", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                                Exit Sub
                            End If
                        End If
                        If MessageBox.Show("即将导入该船次：" & Me.C1DBGV.Columns("CHI_VESSEL").Text & " " & Me.C1DBGV.Columns("VOYAGE").Text & "，确定么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                            sqlVesselRenew = "UPDATE VESSEL SET Vessel_Code = '" & Me.cbShipCode.SelectedValue & "' WHERE VESSEL_ID = '" & Me.C1DBGV.Columns("V_ID").Text & "'"
                            ExecSql(sqlVesselRenew)     '补充船码
                            Ship_ID = Me.C1DBGV.Columns("SHIP_ID").Text
                            beSureMark = True
                            Me.Close()
                        End If
                    End If
                Else
                    Me.cbShipCode.Focus()
                    MessageBox.Show("补充船码请直接选择或输入已存在的船码或船名。", "提示")
                End If
            Else    '有船码时
                If MessageBox.Show("即将导入该船次：" & Me.C1DBGV.Columns("CHI_VESSEL").Text & " " & Me.C1DBGV.Columns("VOYAGE").Text & "，确定么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                    Ship_ID = Me.C1DBGV.Columns("SHIP_ID").Text
                    beSureMark = True
                    Me.Close()
                End If
            End If
        Else
            MessageBox.Show("请选择船名航次。", "提示")
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtShip_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShip.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtVoyage.Focus()
        End If
    End Sub

    Private Sub txtVoyage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoyage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btResure.Focus()
        End If
    End Sub

    Private Sub C1DBGV_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBGV.RowColChange
        If e.LastRow <> Me.C1DBGV.Row Then
            Me.txtShip.Text = Me.C1DBGV.Columns("CHI_VESSEL").Text
            Me.txtVoyage.Text = Me.C1DBGV.Columns("VOYAGE").Text
        End If
    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        dvGetShip.RowFilter = ""
        dvGetShip.Sort = "SHIP_STATU,CHI_VESSEL,VOYAGE"
        Me.C1DBGV.Columns("CHI_VESSEL").FooterText = "合计" & dvGetShip.Count & ""
        Me.C1DBGV.Focus()
    End Sub

    Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
        dvGetShip.RowFilter = "SHIP_STATU in (1,2,3)"
        dvGetShip.Sort = "SHIP_STATU,CHI_VESSEL,VOYAGE"
        Me.C1DBGV.Columns("CHI_VESSEL").FooterText = "合计" & dvGetShip.Count & ""
        Me.C1DBGV.Focus()
    End Sub

    Private Sub cbShipCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbShipCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btSave.Focus()
        End If
    End Sub

    Private Sub cbShipCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbShipCode.Leave
        Try
            Me.cbShipCode.Text = Me.cbShipCode.Text.Trim.ToUpper
            Dim i As Integer
            For i = 0 To dvShipCode.Count - 1
                If Me.cbShipCode.Text = dvShipCode(i)("SPCODE") Or Me.cbShipCode.Text = dvShipCode(i)("CHI_VESSEL") Or Me.cbShipCode.Text = dvShipCode(i)("Comb") Then
                    Exit For
                End If
            Next
            If i < dvShipCode.Count Then
                Me.cbShipCode.SelectedValue = dvShipCode(i)("SPCODE")
                ShipIdx = i
                ShipMark = True
            Else
                ShipMark = False  '找不到相应的船名船码
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbShipCode_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbShipCode.SelectedValueChanged
        ShipMark = True
    End Sub

End Class
