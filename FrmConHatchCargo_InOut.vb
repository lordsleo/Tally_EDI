Imports TALLY.DBControl
Public Class FrmConHatchCargo_InOut

    Public blSave As Boolean
    Dim sqlBill As String
    Dim dsBill As New DataSet
    Dim dvBill As DataView
    Private Sub FrmConHatchCargo_InOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlBill = "select CON_HATCH_LIST_ID,Blno,InOutMark from Con_Hatch_List where Ship_ID=" & Ship_ID & " order by Blno"
        dvBill = Getdata(sqlBill, dsBill)
        Dim i As Integer
        For i = 0 To dvBill.Count - 1
            If Convert.IsDBNull(dvBill(i)("InOutMark")) Then
                dvBill(i)("InOutMark") = 0
            End If
        Next
        C1DBG.DataSource = dvBill
        C1DBG.Columns("Blno").Caption = "提单号"
        C1DBG.Columns("InOutMark").Caption = "内外贸"
        C1DBG.Splits(0).DisplayColumns("CON_HATCH_LIST_ID").Visible = False


        Dim vi As C1.Win.C1TrueDBGrid.ValueItem
        C1DBG.Columns("InOutMark").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
        C1DBG.Columns("InOutMark").ValueItems.Translate = True
        vi = New C1.Win.C1TrueDBGrid.ValueItem("1", True)
        C1DBG.Columns("InOutMark").ValueItems.Values.Add(vi)
        vi = New C1.Win.C1TrueDBGrid.ValueItem("0", False)
        C1DBG.Columns("InOutMark").ValueItems.Values.Add(vi)
        C1DBG.Splits(0).DisplayColumns("Blno").Locked = True
        C1DBG.Splits(0).DisplayColumns("CON_HATCH_LIST_ID").Locked = True
        C1DBG.ColumnFooters = True
        C1DBG.Columns("Blno").FooterText = "提单" & C1DBG.RowCount & "个"
        
    End Sub

    Private Sub C1DBG_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColUpdate
        C1DBG.Columns("InOutMark").FooterText = "内贸" & GetDataSum(dvBill, "InOutMark") & "个"
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If C1DBG.Columns("InOutMark").CellValue(e.Row) = "1" Then
            e.CellStyle.BackColor = Color.LightCyan
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("确定保存吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            Dim i As Integer
            For i = 0 To dvBill.Count - 1
                If dvBill(i)("InOutMark").ToString() = "0" Then
                    dvBill(i)("InOutMark") = DBNull.Value
                End If
            Next
            RunUpdata(sqlBill, dsBill)
            blSave = True
            Close()
        End If
    End Sub
End Class