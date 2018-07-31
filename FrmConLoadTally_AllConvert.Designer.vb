<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConLoadTally_AllConvert
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConLoadTally_AllConvert))
        Me.gbOld = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShipOld = New System.Windows.Forms.TextBox
        Me.txtVoyageOld = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnFindOld = New System.Windows.Forms.Button
        Me.txtShipNameOld = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbNew = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtShipNew = New System.Windows.Forms.TextBox
        Me.txtVoyageNew = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnFindNew = New System.Windows.Forms.Button
        Me.txtShipNameNew = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.C1ConOld = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.C1BillOld = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.C1ConNew = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.C1BillNew = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.gbOld.SuspendLayout()
        Me.gbNew.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.C1ConOld, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1BillOld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.C1ConNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1BillNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbOld
        '
        Me.gbOld.Controls.Add(Me.Label1)
        Me.gbOld.Controls.Add(Me.txtShipOld)
        Me.gbOld.Controls.Add(Me.txtVoyageOld)
        Me.gbOld.Controls.Add(Me.Label2)
        Me.gbOld.Controls.Add(Me.btnFindOld)
        Me.gbOld.Controls.Add(Me.txtShipNameOld)
        Me.gbOld.Controls.Add(Me.Label4)
        Me.gbOld.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbOld.Location = New System.Drawing.Point(12, 8)
        Me.gbOld.Name = "gbOld"
        Me.gbOld.Size = New System.Drawing.Size(325, 76)
        Me.gbOld.TabIndex = 0
        Me.gbOld.TabStop = False
        Me.gbOld.Text = "原船查找"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "船码"
        '
        'txtShipOld
        '
        Me.txtShipOld.Location = New System.Drawing.Point(40, 14)
        Me.txtShipOld.Name = "txtShipOld"
        Me.txtShipOld.Size = New System.Drawing.Size(100, 21)
        Me.txtShipOld.TabIndex = 0
        '
        'txtVoyageOld
        '
        Me.txtVoyageOld.Location = New System.Drawing.Point(191, 14)
        Me.txtVoyageOld.Name = "txtVoyageOld"
        Me.txtVoyageOld.Size = New System.Drawing.Size(100, 21)
        Me.txtVoyageOld.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "航次"
        '
        'btnFindOld
        '
        Me.btnFindOld.Location = New System.Drawing.Point(220, 43)
        Me.btnFindOld.Name = "btnFindOld"
        Me.btnFindOld.Size = New System.Drawing.Size(60, 22)
        Me.btnFindOld.TabIndex = 2
        Me.btnFindOld.Text = "查找"
        '
        'txtShipNameOld
        '
        Me.txtShipNameOld.BackColor = System.Drawing.Color.Lavender
        Me.txtShipNameOld.Location = New System.Drawing.Point(40, 41)
        Me.txtShipNameOld.Name = "txtShipNameOld"
        Me.txtShipNameOld.ReadOnly = True
        Me.txtShipNameOld.Size = New System.Drawing.Size(145, 21)
        Me.txtShipNameOld.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "船名"
        '
        'gbNew
        '
        Me.gbNew.Controls.Add(Me.Label3)
        Me.gbNew.Controls.Add(Me.txtShipNew)
        Me.gbNew.Controls.Add(Me.txtVoyageNew)
        Me.gbNew.Controls.Add(Me.Label5)
        Me.gbNew.Controls.Add(Me.btnFindNew)
        Me.gbNew.Controls.Add(Me.txtShipNameNew)
        Me.gbNew.Controls.Add(Me.Label6)
        Me.gbNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbNew.Location = New System.Drawing.Point(355, 8)
        Me.gbNew.Name = "gbNew"
        Me.gbNew.Size = New System.Drawing.Size(325, 76)
        Me.gbNew.TabIndex = 1
        Me.gbNew.TabStop = False
        Me.gbNew.Text = "新船查找"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "船码"
        '
        'txtShipNew
        '
        Me.txtShipNew.Location = New System.Drawing.Point(40, 14)
        Me.txtShipNew.Name = "txtShipNew"
        Me.txtShipNew.Size = New System.Drawing.Size(100, 21)
        Me.txtShipNew.TabIndex = 0
        '
        'txtVoyageNew
        '
        Me.txtVoyageNew.Location = New System.Drawing.Point(191, 14)
        Me.txtVoyageNew.Name = "txtVoyageNew"
        Me.txtVoyageNew.Size = New System.Drawing.Size(100, 21)
        Me.txtVoyageNew.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "航次"
        '
        'btnFindNew
        '
        Me.btnFindNew.Location = New System.Drawing.Point(220, 43)
        Me.btnFindNew.Name = "btnFindNew"
        Me.btnFindNew.Size = New System.Drawing.Size(60, 22)
        Me.btnFindNew.TabIndex = 2
        Me.btnFindNew.Text = "查找"
        '
        'txtShipNameNew
        '
        Me.txtShipNameNew.BackColor = System.Drawing.Color.Lavender
        Me.txtShipNameNew.Location = New System.Drawing.Point(40, 41)
        Me.txtShipNameNew.Name = "txtShipNameNew"
        Me.txtShipNameNew.ReadOnly = True
        Me.txtShipNameNew.Size = New System.Drawing.Size(145, 21)
        Me.txtShipNameNew.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "船名"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.C1ConOld)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.C1BillOld)
        Me.Panel1.Location = New System.Drawing.Point(-1, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 360)
        Me.Panel1.TabIndex = 565
        '
        'C1ConOld
        '
        Me.C1ConOld.AllowColMove = False
        Me.C1ConOld.AllowUpdate = False
        Me.C1ConOld.ColumnFooters = True
        Me.C1ConOld.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1ConOld.FetchRowStyles = True
        Me.C1ConOld.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1ConOld.Images.Add(CType(resources.GetObject("C1ConOld.Images"), System.Drawing.Image))
        Me.C1ConOld.Location = New System.Drawing.Point(143, 0)
        Me.C1ConOld.Name = "C1ConOld"
        Me.C1ConOld.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1ConOld.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1ConOld.PreviewInfo.ZoomFactor = 75
        Me.C1ConOld.PrintInfo.PageSettings = CType(resources.GetObject("C1ConOld.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1ConOld.Size = New System.Drawing.Size(195, 360)
        Me.C1ConOld.TabIndex = 492
        Me.C1ConOld.PropBag = resources.GetString("C1ConOld.PropBag")
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(140, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 360)
        Me.Splitter1.TabIndex = 491
        Me.Splitter1.TabStop = False
        '
        'C1BillOld
        '
        Me.C1BillOld.AllowColMove = False
        Me.C1BillOld.AllowUpdate = False
        Me.C1BillOld.ColumnFooters = True
        Me.C1BillOld.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1BillOld.FetchRowStyles = True
        Me.C1BillOld.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1BillOld.Images.Add(CType(resources.GetObject("C1BillOld.Images"), System.Drawing.Image))
        Me.C1BillOld.Location = New System.Drawing.Point(0, 0)
        Me.C1BillOld.Name = "C1BillOld"
        Me.C1BillOld.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1BillOld.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1BillOld.PreviewInfo.ZoomFactor = 75
        Me.C1BillOld.PrintInfo.PageSettings = CType(resources.GetObject("C1BillOld.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1BillOld.Size = New System.Drawing.Size(140, 360)
        Me.C1BillOld.TabIndex = 490
        Me.C1BillOld.PropBag = resources.GetString("C1BillOld.PropBag")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.C1ConNew)
        Me.Panel2.Controls.Add(Me.Splitter2)
        Me.Panel2.Controls.Add(Me.C1BillNew)
        Me.Panel2.Location = New System.Drawing.Point(355, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 360)
        Me.Panel2.TabIndex = 566
        '
        'C1ConNew
        '
        Me.C1ConNew.AllowColMove = False
        Me.C1ConNew.AllowUpdate = False
        Me.C1ConNew.ColumnFooters = True
        Me.C1ConNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1ConNew.FetchRowStyles = True
        Me.C1ConNew.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1ConNew.Images.Add(CType(resources.GetObject("C1ConNew.Images"), System.Drawing.Image))
        Me.C1ConNew.Location = New System.Drawing.Point(143, 0)
        Me.C1ConNew.Name = "C1ConNew"
        Me.C1ConNew.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1ConNew.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1ConNew.PreviewInfo.ZoomFactor = 75
        Me.C1ConNew.PrintInfo.PageSettings = CType(resources.GetObject("C1ConNew.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1ConNew.Size = New System.Drawing.Size(197, 360)
        Me.C1ConNew.TabIndex = 492
        Me.C1ConNew.PropBag = resources.GetString("C1ConNew.PropBag")
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(140, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 360)
        Me.Splitter2.TabIndex = 491
        Me.Splitter2.TabStop = False
        '
        'C1BillNew
        '
        Me.C1BillNew.AllowColMove = False
        Me.C1BillNew.AllowUpdate = False
        Me.C1BillNew.ColumnFooters = True
        Me.C1BillNew.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1BillNew.FetchRowStyles = True
        Me.C1BillNew.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1BillNew.Images.Add(CType(resources.GetObject("C1BillNew.Images"), System.Drawing.Image))
        Me.C1BillNew.Location = New System.Drawing.Point(0, 0)
        Me.C1BillNew.Name = "C1BillNew"
        Me.C1BillNew.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1BillNew.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1BillNew.PreviewInfo.ZoomFactor = 75
        Me.C1BillNew.PrintInfo.PageSettings = CType(resources.GetObject("C1BillNew.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1BillNew.Size = New System.Drawing.Size(140, 360)
        Me.C1BillNew.TabIndex = 490
        Me.C1BillNew.PropBag = resources.GetString("C1BillNew.PropBag")
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(324, 456)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(68, 22)
        Me.btnSave.TabIndex = 567
        Me.btnSave.Text = "确定换船"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(470, 456)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 22)
        Me.btnExit.TabIndex = 595
        Me.btnExit.Text = "退出(&X)"
        '
        'FrmConLoadTally_AllConvert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(695, 484)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbNew)
        Me.Controls.Add(Me.gbOld)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadTally_AllConvert"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "整体换船"
        Me.gbOld.ResumeLayout(False)
        Me.gbOld.PerformLayout()
        Me.gbNew.ResumeLayout(False)
        Me.gbNew.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.C1ConOld, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1BillOld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.C1ConNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1BillNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbOld As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShipOld As System.Windows.Forms.TextBox
    Friend WithEvents txtVoyageOld As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFindOld As System.Windows.Forms.Button
    Friend WithEvents txtShipNameOld As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbNew As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtShipNew As System.Windows.Forms.TextBox
    Friend WithEvents txtVoyageNew As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnFindNew As System.Windows.Forms.Button
    Friend WithEvents txtShipNameNew As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents C1ConOld As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents C1BillOld As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents C1ConNew As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents C1BillNew As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
