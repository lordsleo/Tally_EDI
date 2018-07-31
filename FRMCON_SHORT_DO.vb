Imports TALLY.DBControl
Public Class FRMCON_SHORT_DO
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()

    Dim dssp As New DataSet()
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
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRMCON_SHORT_DO))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTOK = New System.Windows.Forms.Button()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = True
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = True
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1DBG.Location = New System.Drawing.Point(10, 8)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowDivider = GridLines1
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.ScrollTips = False
        Me.C1DBG.Size = New System.Drawing.Size(242, 132)
        Me.C1DBG.TabIndex = 1
        Me.C1DBG.Text = "C1TrueDBGrid1"
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(139, 160)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 41
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(57, 160)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 40
        Me.BTOK.Text = "确认"
        '
        'FRMCON_SHORT_DO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(260, 205)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.BTQUIT, Me.BTOK, Me.C1DBG})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMCON_SHORT_DO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱残损溢短_处理"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCON_SHORT_DO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err

        'If MsgBox("是否生成实际溢短数据？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
        dw = Getdata("exec spcon_short '" & Ship_ID & "'", dssp)
        If dssp.Tables(0).Rows.Count > 0 Then
            Me.C1DBG.DataSource = dssp.Tables(0).DefaultView
            Me.C1DBG.Columns.Item(0).Caption = "箱号"
            Me.C1DBG.Columns.Item(1).Caption = "铅封号"
            Me.C1DBG.Columns.Item(2).Caption = "溢短标志"
            Call SetColumnWidth() '设计列宽度
            Me.C1DBG.Refresh()
        Else
            MsgBox("没有溢短！")
            Me.BTOK.Enabled = False
        End If
        'End If

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub SetColumnWidth()
        Dim j As Integer
        For j = 0 To Me.C1DBG.Columns.Count - 1
            Me.C1DBG.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Try
            Dim i As Integer
            Dim row As DataRow
            If MsgBox("确认要生成溢短单吗？这将删除以前本航次的溢短单！", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                dw = Updatedata(sqlda, "select * from con_short where ship_id='" & Ship_ID & "' and (len(DAMAGED_CODE)=0 or DAMAGED_CODE is null or DAMAGED_CODE='00') and (len(DAMAGED_TYPE)=0 or DAMAGED_TYPE is null or DAMAGED_TYPE='00') and (DAMAGED_CONDITION is null or len(DAMAGED_CONDITION)=0)", ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        Call OperateHistory(G_DeptName, Now, G_User, "删除", "con_short", ds.Tables(0).Rows(i).Item("con_short_id"), "con_short_id")
                        ExecSql("delete from con_short where con_short_id='" & ds.Tables(0).Rows(i).Item("con_short_id") & "'")
                        sqlda.Update(ds)
                    Next
                End If
                For i = 0 To dssp.Tables(0).Rows.Count - 1
                    row = ds.Tables(0).NewRow
                    row("ship_id") = Trim(Ship_ID)
                    row("DAMAGED_CODE") = "00"
                    row("DAMAGED_CONDITION") = ""
                    row("REMARK") = ""
                    row("DAMAGED_TYPE") = "00"
                    row("SEALNO") = dssp.Tables(0).Rows(i).Item("SEALNO")
                    row("DAMAGE_OVER_SHORT_TYPE") = dssp.Tables(0).Rows(i).Item("DAMAGE_OVER_SHORT_TYPE")
                    row("container_no") = dssp.Tables(0).Rows(i).Item("container_no")
                    row("USER_NAME") = Trim(G_User)
                    row("printout") = "0"
                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                Next
                Call BTQUIT_Click(sender, e)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

