Public Class FillImageCell_QDStar   '青岛皇后船图
    Inherits FillImageCell

    '纵向贝位
    Public Shared Shadows Sub FillVerCell(ByVal a As Integer, ByVal b As Integer, ByVal i As Integer)
        If Not IsDBNull(dv(i)("CONTAINER_NO")) Then
            xlSheet.Cells(a, b) = dv(i)("CONTAINER_NO")
            xlSheet.Cells(a, b - 2) = dv(i)("SIZE_CON") & dv(i)("CONTAINER_TYPE")
            If Not IsDBNull(dv(i)("CONTAINER_TYPE")) AndAlso dv(i)("CONTAINER_TYPE") Like "R?" Then
                xlSheet.Cells(a + 6, b - 2) = "R"
                xlSheet.Cells(a + 9, b - 2) = dv(i)("TEMPERATURE_SETTING")
            ElseIf Not IsDBNull(dv(i)("DANGER_GRADE")) AndAlso Trim(dv(i)("DANGER_GRADE")).Length > 0 Then
                xlSheet.Cells(a + 6, b - 2) = "D"
                xlSheet.Cells(a + 9, b - 2) = dv(i)("DANGER_GRADE")
            Else
                xlSheet.Cells(a + 6, b - 2) = dv(i)("FULLOREMPTY")
            End If
            If Not IsDBNull(dv(i)("GROSSWEIGHT")) Then
                xlSheet.Cells(a + 7, b - 4) = Format(dv(i)("GROSSWEIGHT") / 1000, "0.##")
            End If
        End If
        xlSheet.Cells(a, b - 4) = dv(i)("Tray")
    End Sub

    '横向贝位
    Public Shared Shadows Sub FillHorCell(ByVal a As Integer, ByVal b As Integer, ByVal i As Integer)
        If Not IsDBNull(dv(i)("CONTAINER_NO")) Then
            xlSheet.Cells(a, b) = dv(i)("CONTAINER_NO")
            xlSheet.Cells(a + 2, b) = dv(i)("SIZE_CON") & dv(i)("CONTAINER_TYPE")
            If Not IsDBNull(dv(i)("CONTAINER_TYPE")) AndAlso dv(i)("CONTAINER_TYPE") Like "R?" Then
                xlSheet.Cells(a + 2, b + 5) = "R"
                xlSheet.Cells(a + 2, b + 8) = dv(i)("TEMPERATURE_SETTING")
            ElseIf Not IsDBNull(dv(i)("DANGER_GRADE")) AndAlso Trim(dv(i)("DANGER_GRADE")).Length > 0 Then
                xlSheet.Cells(a + 2, b + 5) = "D"
                xlSheet.Cells(a + 2, b + 8) = dv(i)("DANGER_GRADE")
            Else
                xlSheet.Cells(a + 2, b + 5) = dv(i)("FULLOREMPTY")
            End If
            If Not IsDBNull(dv(i)("GROSSWEIGHT")) Then
                xlSheet.Cells(a + 4, b + 6) = Format(dv(i)("GROSSWEIGHT") / 1000, "0.##")
            End If
        End If
        xlSheet.Cells(a + 4, b) = dv(i)("Tray")
    End Sub

    '填写ORIGINAL面图单元格
    Public Shared Sub FillOriginalCell(ByVal i As Integer)
        ''如果Excel中有的Deck中所有贝位的相对位置相同，可以选择调用各个填写程序。可以减少重复代码
        ''如果全部位置都相同，就不用在这里写Select Case代码了
        ''如果没有相应的Deck可以不调用，或者程序为空
        'FillMainDeckCell(i)
        'FillCarDeckCell(i)
        'FillFreeBoardDeckCell(i)
        'FillLowerHoldCell(i)
        If dv(i)("BayNo") Like "*[89]#" Then
            FillCDeckCell(i)
        Else
            FillDDeckCell(i)
        End If
    End Sub

    '填写C-Deck面图单元格
    Public Shared Sub FillCDeckCell(ByVal i As Integer)
        Select Case TongBayNo(dv(i)("BayNo"))
            '贝09'''
            Case "090682"
                FillHorCell(12, 175, i)
            Case "090482"
                FillHorCell(20, 175, i)
            Case "090182"
                FillHorCell(42, 175, i)
            Case "090382"
                FillHorCell(50, 175, i)
            Case "090582"
                FillHorCell(58, 175, i)
                '贝11
            Case "110682"
                FillHorCell(12, 164, i)
            Case "110482"
                FillHorCell(20, 164, i)
            Case "110182"
                FillHorCell(42, 164, i)
            Case "110382"
                FillHorCell(50, 164, i)
            Case "110582"
                FillHorCell(58, 164, i)
                '贝13
            Case "130682"
                FillHorCell(12, 152, i)
            Case "130482"
                FillHorCell(20, 152, i)
            Case "130182"
                FillHorCell(42, 152, i)
            Case "130382"
                FillHorCell(50, 152, i)
            Case "130582"
                FillHorCell(58, 152, i)
                '贝15
            Case "150682"
                FillHorCell(12, 141, i)
            Case "150482"
                FillHorCell(20, 141, i)
            Case "150182"
                FillHorCell(42, 141, i)
            Case "150382"
                FillHorCell(50, 141, i)
            Case "150582"
                FillHorCell(58, 141, i)
                '贝17
            Case "170682"
                FillHorCell(12, 129, i)
            Case "170482"
                FillHorCell(20, 129, i)
            Case "170182"
                FillHorCell(42, 129, i)
            Case "170382"
                FillHorCell(50, 129, i)
            Case "170582"
                FillHorCell(58, 129, i)
                '贝19
            Case "190682"
                FillHorCell(12, 118, i)
            Case "190482"
                FillHorCell(20, 118, i)
            Case "190182"
                FillHorCell(42, 118, i)
            Case "190382"
                FillHorCell(50, 118, i)
            Case "190582"
                FillHorCell(58, 118, i)
                '贝21
            Case "210682"
                FillHorCell(12, 106, i)
            Case "210482"
                FillHorCell(20, 106, i)
            Case "210382"
                FillHorCell(50, 106, i)
            Case "210582"
                FillHorCell(58, 106, i)
                '贝23
            Case "230682"
                FillHorCell(12, 95, i)
            Case "230482"
                FillHorCell(20, 95, i)
            Case "230382"
                FillHorCell(50, 95, i)
            Case "230582"
                FillHorCell(58, 95, i)
                '贝25
            Case "250682"
                FillHorCell(12, 83, i)
            Case "250482"
                FillHorCell(20, 83, i)
            Case "250282"
                FillHorCell(28, 83, i)
            Case "250182"
                FillHorCell(42, 83, i)
            Case "250382"
                FillHorCell(50, 83, i)
            Case "250582"
                FillHorCell(58, 83, i)
                '贝27
            Case "270682"
                FillHorCell(12, 72, i)
            Case "270482"
                FillHorCell(20, 72, i)
            Case "270282"
                FillHorCell(28, 72, i)
            Case "270182"
                FillHorCell(42, 72, i)
            Case "270382"
                FillHorCell(50, 72, i)
            Case "270582"
                FillHorCell(58, 72, i)
                '贝29
            Case "290682"
                FillHorCell(12, 60, i)
            Case "290482"
                FillHorCell(20, 60, i)
            Case "290282"
                FillHorCell(28, 60, i)
            Case "290182"
                FillHorCell(42, 60, i)
            Case "290382"
                FillHorCell(50, 60, i)
            Case "290582"
                FillHorCell(58, 60, i)
                '贝31
            Case "310682"
                FillHorCell(12, 49, i)
            Case "310482"
                FillHorCell(20, 49, i)
            Case "310282"
                FillHorCell(28, 49, i)
            Case "310182"
                FillHorCell(42, 49, i)
            Case "310382"
                FillHorCell(50, 49, i)
            Case "310582"
                FillHorCell(58, 49, i)
                '贝33
            Case "330682"
                FillHorCell(12, 37, i)
            Case "330482"
                FillHorCell(20, 37, i)
            Case "330282"
                FillHorCell(28, 37, i)
            Case "330382"
                FillHorCell(50, 37, i)
            Case "330582"
                FillHorCell(58, 37, i)
                '贝35
            Case "350682"
                FillHorCell(12, 26, i)
            Case "350482"
                FillHorCell(20, 26, i)
            Case "350282"
                FillHorCell(28, 26, i)
            Case "350382"
                FillHorCell(50, 26, i)
            Case "350582"
                FillHorCell(58, 26, i)
                '贝37
            Case "370682"
                FillHorCell(12, 14, i)
            Case "370482"
                FillHorCell(20, 14, i)
            Case "370282"
                FillHorCell(28, 14, i)
            Case "370182"
                FillHorCell(42, 14, i)
            Case "370382"
                FillHorCell(50, 14, i)
            Case "370582"
                FillHorCell(58, 14, i)
                '贝39
            Case "390682"
                FillHorCell(12, 3, i)
            Case "390482"
                FillHorCell(20, 3, i)
            Case "390282"
                FillHorCell(28, 3, i)
            Case "390182"
                FillHorCell(42, 3, i)
            Case "390382"
                FillHorCell(50, 3, i)
            Case "390582"
                FillHorCell(58, 3, i)
        End Select
    End Sub
    '填写D-Deck面图单元格
    Public Shared Sub FillDDeckCell(ByVal i As Integer)
        Select Case TongBayNo(dv(i)("BayNo"))
            '贝1'''
            Case "010202"
                FillHorCell(94, 221, i)
                '贝3'''
            Case "030202"
                FillHorCell(94, 210, i)
                '贝5'''
            Case "050402"
                FillHorCell(86, 198, i)
            Case "050202"
                FillHorCell(94, 198, i)
            Case "050102"
                FillHorCell(103, 198, i)
                '贝7'''
            Case "070402"
                FillHorCell(86, 187, i)
            Case "070202"
                FillHorCell(94, 187, i)
            Case "070102"
                FillHorCell(103, 187, i)
            Case "070302"
                FillHorCell(111, 187, i)
            Case "070502"
                FillHorCell(119, 187, i)
                '贝9'''
            Case "090602"
                FillHorCell(78, 175, i)
            Case "090402"
                FillHorCell(86, 175, i)
            Case "090202"
                FillHorCell(94, 175, i)
            Case "090102"
                FillHorCell(103, 175, i)
            Case "090302"
                FillHorCell(111, 175, i)
            Case "090502"
                FillHorCell(119, 175, i)
                '贝11'''
            Case "110602"
                FillHorCell(78, 164, i)
            Case "110402"
                FillHorCell(86, 164, i)
            Case "110202"
                FillHorCell(94, 164, i)
            Case "110102"
                FillHorCell(103, 164, i)
            Case "110302"
                FillHorCell(111, 164, i)
            Case "110502"
                FillHorCell(119, 164, i)
                '贝13'''
            Case "130602"
                FillHorCell(78, 152, i)
            Case "130402"
                FillHorCell(86, 152, i)
            Case "130202"
                FillHorCell(94, 152, i)
            Case "130102"
                FillHorCell(103, 152, i)
            Case "130302"
                FillHorCell(111, 152, i)
            Case "130502"
                FillHorCell(119, 152, i)
                '贝15''
            Case "150602"
                FillHorCell(78, 141, i)
            Case "150402"
                FillHorCell(86, 141, i)
            Case "150202"
                FillHorCell(94, 141, i)
            Case "150102"
                FillHorCell(103, 141, i)
            Case "150302"
                FillHorCell(111, 141, i)
            Case "150502"
                FillHorCell(119, 141, i)
                '贝17''
            Case "170602"
                FillHorCell(78, 129, i)
            Case "170402"
                FillHorCell(86, 129, i)
            Case "170202"
                FillHorCell(94, 129, i)
            Case "170102"
                FillHorCell(103, 129, i)
            Case "170302"
                FillHorCell(111, 129, i)
            Case "170502"
                FillHorCell(119, 129, i)
                '贝19''
            Case "190602"
                FillHorCell(78, 118, i)
            Case "190402"
                FillHorCell(86, 118, i)
            Case "190202"
                FillHorCell(94, 118, i)
            Case "190102"
                FillHorCell(103, 118, i)
            Case "190302"
                FillHorCell(111, 118, i)
            Case "190502"
                FillHorCell(119, 118, i)
                '贝21''
            Case "210602"
                FillHorCell(78, 106, i)
            Case "210402"
                FillHorCell(86, 106, i)
            Case "210202"
                FillHorCell(94, 106, i)
            Case "210102"
                FillHorCell(103, 106, i)
            Case "210302"
                FillHorCell(111, 106, i)
            Case "210502"
                FillHorCell(119, 106, i)
                '贝23''
            Case "230602"
                FillHorCell(78, 95, i)
            Case "230402"
                FillHorCell(86, 95, i)
            Case "230202"
                FillHorCell(94, 95, i)
            Case "230102"
                FillHorCell(103, 95, i)
            Case "230302"
                FillHorCell(111, 95, i)
            Case "230502"
                FillHorCell(119, 95, i)
                '贝25
            Case "250602"
                FillHorCell(78, 83, i)
            Case "250402"
                FillHorCell(86, 83, i)
            Case "250202"
                FillHorCell(94, 83, i)
            Case "250102"
                FillHorCell(103, 83, i)
            Case "250302"
                FillHorCell(111, 83, i)
            Case "250502"
                FillHorCell(119, 83, i)
                '贝27
            Case "270602"
                FillHorCell(78, 72, i)
            Case "270402"
                FillHorCell(86, 72, i)
            Case "270202"
                FillHorCell(94, 72, i)
            Case "270102"
                FillHorCell(103, 72, i)
            Case "270302"
                FillHorCell(111, 72, i)
            Case "270502"
                FillHorCell(119, 72, i)
                '贝29
            Case "290602"
                FillHorCell(78, 60, i)
            Case "290402"
                FillHorCell(86, 60, i)
            Case "290202"
                FillHorCell(94, 60, i)
            Case "290102"
                FillHorCell(103, 60, i)
            Case "290302"
                FillHorCell(111, 60, i)
            Case "290502"
                FillHorCell(119, 60, i)
                '贝31''
            Case "310602"
                FillHorCell(78, 49, i)
            Case "310402"
                FillHorCell(86, 49, i)
            Case "310202"
                FillHorCell(94, 49, i)
            Case "310102"
                FillHorCell(103, 49, i)
            Case "310302"
                FillHorCell(111, 49, i)
            Case "310502"
                FillHorCell(119, 49, i)
                '贝33
            Case "330602"
                FillHorCell(74, 37, i)
            Case "330402"
                FillHorCell(82, 37, i)
            Case "330202"
                FillHorCell(90, 37, i)
            Case "330002"
                FillHorCell(99, 37, i)
            Case "330102"
                FillHorCell(107, 37, i)
            Case "330302"
                FillHorCell(115, 37, i)
            Case "330502"
                FillHorCell(123, 37, i)
                '贝35
            Case "350602"
                FillHorCell(74, 26, i)
            Case "350402"
                FillHorCell(82, 26, i)
            Case "350202"
                FillHorCell(90, 26, i)
            Case "350002"
                FillHorCell(99, 26, i)
            Case "350102"
                FillHorCell(107, 26, i)
            Case "350302"
                FillHorCell(115, 26, i)
            Case "350502"
                FillHorCell(123, 26, i)
                '贝37
            Case "370602"
                FillHorCell(78, 14, i)
            Case "370402"
                FillHorCell(86, 14, i)
            Case "370202"
                FillHorCell(94, 14, i)
            Case "370102"
                FillHorCell(103, 14, i)
                '贝39
            Case "390602"
                FillHorCell(78, 3, i)
            Case "390402"
                FillHorCell(86, 3, i)
            Case "390202"
                FillHorCell(94, 3, i)
            Case "390102"
                FillHorCell(103, 3, i)
        End Select
    End Sub
End Class
