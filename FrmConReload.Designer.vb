<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConReload
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtFind = New System.Windows.Forms.Button
        Me.LabVessel = New System.Windows.Forms.Label
        Me.clb_voyage = New System.Windows.Forms.CheckedListBox
        Me.TxtVessel = New System.Windows.Forms.TextBox
        Me.LabVesselEng = New System.Windows.Forms.Label
        Me.TxtVesselEng = New System.Windows.Forms.TextBox
        Me.LabVoyage = New System.Windows.Forms.Label
        Me.TxtVoyage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtClear = New System.Windows.Forms.Button
        Me.BtExport = New System.Windows.Forms.Button
        Me.BtExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtFind
        '
        Me.BtFind.Location = New System.Drawing.Point(278, 179)
        Me.BtFind.Name = "BtFind"
        Me.BtFind.Size = New System.Drawing.Size(85, 31)
        Me.BtFind.TabIndex = 0
        Me.BtFind.Text = "查找"
        Me.BtFind.UseVisualStyleBackColor = True
        Me.BtFind.Visible = False
        '
        'LabVessel
        '
        Me.LabVessel.AutoSize = True
        Me.LabVessel.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabVessel.Location = New System.Drawing.Point(25, 30)
        Me.LabVessel.Name = "LabVessel"
        Me.LabVessel.Size = New System.Drawing.Size(88, 16)
        Me.LabVessel.TabIndex = 1
        Me.LabVessel.Text = "中文船名："
        '
        'clb_voyage
        '
        Me.clb_voyage.CheckOnClick = True
        Me.clb_voyage.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.clb_voyage.FormattingEnabled = True
        Me.clb_voyage.Location = New System.Drawing.Point(55, 133)
        Me.clb_voyage.Name = "clb_voyage"
        Me.clb_voyage.Size = New System.Drawing.Size(171, 235)
        Me.clb_voyage.TabIndex = 2
        '
        'TxtVessel
        '
        Me.TxtVessel.Location = New System.Drawing.Point(108, 28)
        Me.TxtVessel.Name = "TxtVessel"
        Me.TxtVessel.Size = New System.Drawing.Size(127, 21)
        Me.TxtVessel.TabIndex = 3
        '
        'LabVesselEng
        '
        Me.LabVesselEng.AutoSize = True
        Me.LabVesselEng.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabVesselEng.Location = New System.Drawing.Point(25, 67)
        Me.LabVesselEng.Name = "LabVesselEng"
        Me.LabVesselEng.Size = New System.Drawing.Size(88, 16)
        Me.LabVesselEng.TabIndex = 1
        Me.LabVesselEng.Text = "英文船名："
        '
        'TxtVesselEng
        '
        Me.TxtVesselEng.Location = New System.Drawing.Point(108, 65)
        Me.TxtVesselEng.Name = "TxtVesselEng"
        Me.TxtVesselEng.Size = New System.Drawing.Size(127, 21)
        Me.TxtVesselEng.TabIndex = 3
        '
        'LabVoyage
        '
        Me.LabVoyage.AutoSize = True
        Me.LabVoyage.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabVoyage.Location = New System.Drawing.Point(252, 30)
        Me.LabVoyage.Name = "LabVoyage"
        Me.LabVoyage.Size = New System.Drawing.Size(56, 16)
        Me.LabVoyage.TabIndex = 1
        Me.LabVoyage.Text = "航次："
        '
        'TxtVoyage
        '
        Me.TxtVoyage.Location = New System.Drawing.Point(302, 28)
        Me.TxtVoyage.Name = "TxtVoyage"
        Me.TxtVoyage.Size = New System.Drawing.Size(101, 21)
        Me.TxtVoyage.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(25, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "关联对应的进口航次（单选）："
        '
        'BtClear
        '
        Me.BtClear.Location = New System.Drawing.Point(278, 233)
        Me.BtClear.Name = "BtClear"
        Me.BtClear.Size = New System.Drawing.Size(85, 30)
        Me.BtClear.TabIndex = 0
        Me.BtClear.Text = "清空重选"
        Me.BtClear.UseVisualStyleBackColor = True
        '
        'BtExport
        '
        Me.BtExport.Location = New System.Drawing.Point(278, 288)
        Me.BtExport.Name = "BtExport"
        Me.BtExport.Size = New System.Drawing.Size(85, 30)
        Me.BtExport.TabIndex = 0
        Me.BtExport.Text = "导出数据"
        Me.BtExport.UseVisualStyleBackColor = True
        '
        'BtExit
        '
        Me.BtExit.Location = New System.Drawing.Point(278, 338)
        Me.BtExit.Name = "BtExit"
        Me.BtExit.Size = New System.Drawing.Size(85, 30)
        Me.BtExit.TabIndex = 0
        Me.BtExit.Text = "返回"
        Me.BtExit.UseVisualStyleBackColor = True
        '
        'FrmConReload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 404)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtVoyage)
        Me.Controls.Add(Me.TxtVesselEng)
        Me.Controls.Add(Me.LabVoyage)
        Me.Controls.Add(Me.TxtVessel)
        Me.Controls.Add(Me.LabVesselEng)
        Me.Controls.Add(Me.clb_voyage)
        Me.Controls.Add(Me.LabVessel)
        Me.Controls.Add(Me.BtClear)
        Me.Controls.Add(Me.BtExit)
        Me.Controls.Add(Me.BtExport)
        Me.Controls.Add(Me.BtFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConReload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "倒箱信息查询"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtFind As System.Windows.Forms.Button
    Friend WithEvents LabVessel As System.Windows.Forms.Label
    Friend WithEvents clb_voyage As System.Windows.Forms.CheckedListBox
    Friend WithEvents TxtVessel As System.Windows.Forms.TextBox
    Friend WithEvents LabVesselEng As System.Windows.Forms.Label
    Friend WithEvents TxtVesselEng As System.Windows.Forms.TextBox
    Friend WithEvents LabVoyage As System.Windows.Forms.Label
    Friend WithEvents TxtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtClear As System.Windows.Forms.Button
    Friend WithEvents BtExport As System.Windows.Forms.Button
    Friend WithEvents BtExit As System.Windows.Forms.Button
End Class
