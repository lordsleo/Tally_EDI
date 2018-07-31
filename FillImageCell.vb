Public Class FillImageCell
    Public Shared c1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Public Shared dv As DataView
    Public Shared xlSheet As Excel.Worksheet

    '通贝转换
    Public Shared Function TongBayNo(ByVal strBayNo As String) As String
        If strBayNo Like "#[24680]*" Then
            '得到“前通贝号”
            Dim strBayNoFont As String
            strBayNoFont = strBayNo.Trim
            strBayNoFont = String.Concat(CStr(CInt(String.Concat("2", strBayNoFont.Substring(0, 2))) - 1), strBayNoFont.Substring(2, 4)).Substring(1, 6)
            Return strBayNoFont
        Else
            Return strBayNo
        End If
    End Function

    '首尾纵向贝位
    Public Shared Sub FillVerCell(ByVal a As Integer, ByVal b As Integer, ByVal i As Integer)
        xlSheet.Cells(a, b) = c1dbg.Columns("CONTAINER_NO").CellText(i)
        If Not IsDBNull(c1dbg.Columns("GROSSWEIGHT").CellValue(i)) Then
            xlSheet.Cells(a + 8, b) = Format(c1dbg.Columns("GROSSWEIGHT").CellValue(i) / 1000, "0.##")
        End If
        xlSheet.Cells(a, b + 1) = c1dbg.Columns("CODE_LOAD_PORT").CellText(i) & "/" & c1dbg.Columns("CODE_UNLOAD_PORT").CellText(i) & "/" & c1dbg.Columns("SIZE_CON").CellText(i) & c1dbg.Columns("CONTAINER_TYPE").CellText(i)
        If c1dbg.Columns("CONTAINER_TYPE").CellText(i) Like "R?" Then
            xlSheet.Cells(a + 8, b + 1) = "R"
        ElseIf c1dbg.Columns("DANGER_GRADE").CellText(i).Length > 0 Then
            xlSheet.Cells(a + 8, b + 1) = "D"
        Else
            xlSheet.Cells(a + 8, b + 1) = c1dbg.Columns("FULLOREMPTY").CellText(i)
        End If
    End Sub

    '中间横向贝位
    Public Shared Sub FillHorCell(ByVal a As Integer, ByVal b As Integer, ByVal i As Integer)
        xlSheet.Cells(a, b) = c1dbg.Columns("CONTAINER_NO").CellText(i)
        If Not IsDBNull(c1dbg.Columns("GROSSWEIGHT").CellValue(i)) Then
            xlSheet.Cells(a, b + 1) = Format(c1dbg.Columns("GROSSWEIGHT").CellValue(i) / 1000, "0.##")
        End If
        xlSheet.Cells(a - 1, b) = c1dbg.Columns("CODE_LOAD_PORT").CellText(i) & "/" & c1dbg.Columns("CODE_UNLOAD_PORT").CellText(i) & " " & c1dbg.Columns("SIZE_CON").CellText(i) & c1dbg.Columns("CONTAINER_TYPE").CellText(i)
        If c1dbg.Columns("CONTAINER_TYPE").CellText(i) Like "R?" Then
            xlSheet.Cells(a - 1, b + 1) = "R"
        ElseIf c1dbg.Columns("DANGER_GRADE").CellText(i).Length > 0 Then
            xlSheet.Cells(a - 1, b + 1) = "D"
        Else
            xlSheet.Cells(a - 1, b + 1) = c1dbg.Columns("FULLOREMPTY").CellText(i)
        End If
    End Sub
    '清空指定区域内容
    Public Shared Sub ClearCell(ByVal iBegin As Integer, ByVal iEnd As Integer, ByVal jBegin As Integer, ByVal jEnd As Integer)
        Dim i, j As Integer
        For i = iBegin To iEnd
            For j = jBegin To jEnd
                xlSheet.Cells(i, j) = ""
            Next
        Next
    End Sub

End Class
