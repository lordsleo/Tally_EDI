Imports TALLY.DBControl

Public Class FrmConReload

    Dim dsexport As New DataSet

    Private Sub FrmConReload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TxtVessel.Text = G_ShipName
        TxtVesselEng.Text = G_ShipName_Eng
        TxtVoyage.Text = G_Voyage

        FillClbVoyage()
    End Sub

    Private Sub FillClbVoyage()
        Dim ds As New DataSet
        Dim dv As New DataView
        Dim str_sql As String

        str_sql = String.Format("select VOYAGE,SHIP_ID from sship where chi_vessel='{0}' and inoutport='0' order by SHIP_ID desc ", TxtVessel.Text)
        'str_sql = String.Format("select VOYAGE,SHIP_ID from sship where chi_vessel='{0}' and ship_statu<>'4' and inoutport='0' order by SHIP_ID desc ", TxtVessel.Text)
        dv = DBControl.Getdata(str_sql, ds)
        clb_voyage.DataSource = dv
        clb_voyage.DisplayMember = "VOYAGE"
        clb_voyage.ValueMember = "SHIP_ID"
    End Sub

    Private Sub ClearClbVoyage()
        For i As Integer = 0 To Me.clb_voyage.Items.Count - 1
            clb_voyage.SetItemChecked(i, False)
        Next
    End Sub

    '重新填充航次信息
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFind.Click
        FillClbVoyage()
    End Sub

    Private Sub BtClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtClear.Click
        ClearClbVoyage()
    End Sub

    Private Sub BtExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtExport.Click
        If clb_voyage.CheckedItems.Count > 1 Then
            MessageBox.Show("对应的进口航次必须为单选，请重新做出选择！", "选择错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearClbVoyage()
        Else
            For i As Integer = 0 To clb_voyage.CheckedItems.Count - 1
                Dim dv As DataRowView = DirectCast(clb_voyage.CheckedItems(i), DataRowView)
                'MessageBox.Show(dv("SHIP_ID").ToString())
                'MessageBox.Show(Ship_ID)
                Dim strsql As String
                strsql = String.Format("conrestone {0}, {1}", dv("SHIP_ID").ToString(), Ship_ID)
                DBControl.Getdata(strsql, dsexport)
                If dsexport.Tables(0).Rows.Count > 0 Then
                    Export_data()
                Else
                    MessageBox.Show("未找到倒箱数据！")
                    Refresh()
                End If
            Next
        End If
    End Sub

    Private Sub BtExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtExit.Click
        Close()
    End Sub

    Private Sub Export_data()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim t As Integer
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "ConRestone_model.xls", pathstr + "ConRestone.xls")
            Filepath = pathstr + "ConRestone.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("Sheet1"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True

            xlsheet.Select()
            'xlsheet.Cells(1, 1) = "CONTAINER_NO"
            'xlsheet.Cells(1, 2) = "ENG_VESSEL"
            'xlsheet.Cells(1, 3) = "VOYAGE_I"
            'xlsheet.Cells(1, 4) = "BAYNO_I"
            'xlsheet.Cells(1, 5) = "VOYAGE_E"
            'xlsheet.Cells(1, 6) = "BAYNO_E"

            For t = 0 To dsexport.Tables(0).Rows.Count - 1
                xlsheet.Cells(t + 2, 1) = dsexport.Tables(0).Rows(t).Item("CONTAINER_NO")
                xlsheet.Cells(t + 2, 2) = dsexport.Tables(0).Rows(t).Item("ENG_VESSEL")
                xlsheet.Cells(t + 2, 3) = "'" + dsexport.Tables(0).Rows(t).Item("VOYAGE_I")
                xlsheet.Cells(t + 2, 4) = "'" + dsexport.Tables(0).Rows(t).Item("BAYNO_I")
                xlsheet.Cells(t + 2, 5) = "'" + dsexport.Tables(0).Rows(t).Item("VOYAGE_E")
                xlsheet.Cells(t + 2, 6) = "'" + dsexport.Tables(0).Rows(t).Item("BAYNO_E")
            Next
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

End Class