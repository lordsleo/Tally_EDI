Imports TALLY.DBControl

Public Class FrmConLoadTally_AllConvert

    Private Sub FrmConLoadTally_AllConvert_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If blSave Then
            'FrmConLoadTally.mnuRefresh_Click(sender, e)
        End If
    End Sub

    Private Sub FrmConLoadTally_AllConvert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public blSave As Boolean
    Dim blOldMark, blNewMark As Boolean '新旧查找成功标记
    Dim strShipOldFind, strVoyageOldFind As String
    Dim strShipNewFind, strVoyageNewFind As String
    Dim sqlBillOld, sqlConOld As String
    Dim dvBillOld, dvConOld As DataView
    Dim sqlBillNew, sqlConNew As String
    Dim dvBillNew, dvConNew As DataView

    Private Sub btnFindOld_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindOld.Click
        If blShipMarkOld AndAlso txtVoyageOld.Text <> "" Then   '船码航次有效
            If strShipOldFind <> txtShipOld.Text OrElse strVoyageOldFind <> txtVoyageOld.Text Then  '船码或航次改变
                FillDataOld(txtShipOld.Text, txtVoyageOld.Text)
                strShipOldFind = txtShipOld.Text
                strVoyageOldFind = txtVoyageOld.Text
                Me.txtShipNew.Focus()
            End If
        End If
    End Sub

    Private Sub FillDataOld(ByVal strShipCode As String, ByVal strVoyage As String)
        sqlBillOld = "select Blno from Con_Load_Tally where Chi_Vessel='" & strShipCode & "' and Voyage='" & strVoyage & "'"
        dvBillOld = Filldata(sqlBillOld)
        sqlConOld = "select Blno,Container_No from Con_Load_Tally_List where Chi_Vessel='" & strShipCode & "' and Voyage='" & strVoyage & "'"
        dvConOld = Filldata(sqlConOld)
        Me.C1BillOld.DataSource = dvBillOld
        Me.C1BillOld.Columns("Blno").Caption = "提单"
        Me.C1BillOld.Splits(0).DisplayColumns("Blno").Width = IIf(C1BillOld.Width - 50 > 70, C1BillOld.Width - 50, 70)
        Me.C1BillOld.Columns("Blno").FooterText = dvBillOld.Count & "项"

        Me.C1ConOld.DataSource = dvConOld
        Me.C1ConOld.Columns("Blno").Caption = "提单"
        Me.C1ConOld.Columns("Container_No").Caption = "箱号"
        Me.C1ConOld.Splits(0).DisplayColumns("Blno").Width = 70
        Me.C1ConOld.Splits(0).DisplayColumns("Container_No").Width = 90
        Me.C1ConOld.Columns("Container_No").FooterText = dvConOld.Count & "项"

        If dvBillOld.Count > 0 AndAlso dvConOld.Count > 0 Then
            blOldMark = True
        Else
            blOldMark = False
        End If
    End Sub

    Private Sub btnFindNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindNew.Click
        If blShipMarkNew AndAlso txtVoyageNew.Text <> "" Then   '船码航次有效
            If strShipNewFind <> txtShipNew.Text OrElse strVoyageNewFind <> txtVoyageNew.Text Then  '船码或航次改变
                FillDataNew(txtShipNew.Text, txtVoyageNew.Text)
                strShipNewFind = txtShipNew.Text
                strVoyageNewFind = txtVoyageNew.Text
            End If
        End If
    End Sub

    Private Sub FillDataNew(ByVal strShipCode As String, ByVal strVoyage As String)
        sqlBillNew = "select Blno from Con_Load_Tally where Chi_Vessel='" & strShipCode & "' and Voyage='" & strVoyage & "'"
        dvBillNew = Filldata(sqlBillNew)
        sqlConNew = "select Blno,Container_No from Con_Load_Tally_List where Chi_Vessel='" & strShipCode & "' and Voyage='" & strVoyage & "'"
        dvConNew = Filldata(sqlConNew)
        Me.C1BillNew.DataSource = dvBillNew
        Me.C1BillNew.Columns("Blno").Caption = "提单"
        Me.C1BillNew.Splits(0).DisplayColumns("Blno").Width = IIf(C1BillNew.Width - 50 > 70, C1BillNew.Width - 50, 70)
        Me.C1BillNew.Columns("Blno").FooterText = dvBillNew.Count & "项"

        Me.C1ConNew.DataSource = dvConNew
        Me.C1ConNew.Columns("Blno").Caption = "提单"
        Me.C1ConNew.Columns("Container_No").Caption = "箱号"
        Me.C1ConNew.Splits(0).DisplayColumns("Blno").Width = 70
        Me.C1ConNew.Splits(0).DisplayColumns("Container_No").Width = 90
        Me.C1ConNew.Columns("Container_No").FooterText = dvConNew.Count & "项"

        If dvBillNew.Count > 0 AndAlso dvConNew.Count > 0 Then
            blNewMark = True
        Else
            blNewMark = False
        End If
    End Sub

    Dim blShipMarkOld As Boolean
    Dim blShipMarkNew As Boolean
    Dim strShipOldPre As String
    Dim strShipNewPre As String

    Private Sub txtShipOld_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtShipOld.Leave
        Me.txtShipOld.Text = Me.txtShipOld.Text.Trim.ToUpper
        If strShipOldPre <> Me.txtShipOld.Text AndAlso Me.txtShipOld.Text <> "" Then
            Me.txtShipNameOld.Text = GetShipName(Me.txtShipOld.Text, False, True, blShipMarkOld)
            strShipOldPre = Me.txtShipOld.Text
        End If
    End Sub

    Private Sub txtShipNew_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShipNew.Leave
        Me.txtShipNew.Text = Me.txtShipNew.Text.Trim.ToUpper
        If strShipNewPre <> Me.txtShipNew.Text AndAlso Me.txtShipNew.Text <> "" Then
            Me.txtShipNameNew.Text = GetShipName(Me.txtShipNew.Text, False, True, blShipMarkNew)
            strShipNewPre = Me.txtShipNew.Text
        End If
    End Sub

    Private Sub txtVoyageOld_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVoyageOld.Leave
        Me.txtVoyageOld.Text = Me.txtVoyageOld.Text.Trim.ToUpper
    End Sub

    Private Sub txtVoyageNew_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVoyageNew.Leave
        Me.txtVoyageNew.Text = Me.txtVoyageNew.Text.Trim.ToUpper
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If blOldMark Then
            If blNewMark Then
                '检查重复
                '暂不允许操作
                txtShipNew.Focus()
                MessageBox.Show("新船次已有数据", "提示")
            Else
                If MessageBox.Show("确定要换船吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    '先清除垃圾数据
                    If dvBillNew.Count > 0 Then
                        ExecSql("delete from Con_Load_Tally where Chi_Vessel='" & strShipNewFind & "' and Voyage='" & strVoyageNewFind & "'")
                    End If
                    If dvConNew.Count > 0 Then
                        ExecSql("delete from Con_Load_Tally_List where Chi_Vessel='" & strShipNewFind & "' and Voyage='" & strVoyageNewFind & "'")
                    End If
                    '变更船次
                    '记录操作
                    Dim strPivotalOper As String
                    strPivotalOper = "原船" & strShipOldFind & "," & strVoyageOldFind & " 新船" & strShipNewFind & "," & strVoyageNewFind
                    OperRecord(G_DeptName, G_User, "换船修改", strPivotalOper, "Con_Load_Tally")
                    OperPreConLoadTallyList(G_DeptName, Now, G_User, "换船修改", 0)
                    '变更
                    Dim sqlAllConvert As String
                    sqlAllConvert = "update Con_Load_Tally set Chi_Vessel='" & strShipNewFind & "', Voyage='" & strVoyageNewFind & "' where Chi_Vessel='" & strShipOldFind & "' and Voyage='" & strVoyageOldFind & "'"
                    ExecSql(sqlAllConvert)
                    blSave = True
                    '完成后刷新界面
                    FillDataOld(strShipOldFind, strVoyageOldFind)
                    FillDataNew(strShipNewFind, strVoyageNewFind)
                End If
            End If
        Else
            txtShipOld.Focus()
            MessageBox.Show("请确定原有船次", "提示")
        End If
    End Sub

    Private Sub FrmConLoadTally_AllConvert_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, txtVoyageOld.KeyDown, txtVoyageNew.KeyDown, txtShipOld.KeyDown, txtShipNew.KeyDown, txtShipNameOld.KeyDown, txtShipNameNew.KeyDown, btnFindOld.KeyDown, btnFindNew.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtShipOld.Focused Then
                Me.txtVoyageOld.Focus()
            ElseIf Me.txtVoyageOld.Focused Then
                Me.btnFindOld.Focus()
                Me.btnFindOld_Click(sender, e)
            ElseIf Me.txtShipNew.Focused Then
                Me.txtVoyageNew.Focus()
            ElseIf Me.txtVoyageNew.Focused Then
                Me.btnFindNew.Focus()
                Me.btnFindNew_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class