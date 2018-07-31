Public Class FillImageCell_CKStar   '中韩之星船图
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
                FillHorCell(13, 175, i)
            Case "090482"
                FillHorCell(21, 175, i)
            Case "090282"
                FillHorCell(29, 175, i)
            Case "090182"
                FillHorCell(43, 175, i)
            Case "090382"
                FillHorCell(51, 175, i)
            Case "090582"
                FillHorCell(59, 175, i)
                '贝11
            Case "110682"
                FillHorCell(13, 164, i)
            Case "110482"
                FillHorCell(21, 164, i)
            Case "110282"
                FillHorCell(29, 164, i)
            Case "110182"
                FillHorCell(43, 164, i)
            Case "110382"
                FillHorCell(51, 164, i)
            Case "110582"
                FillHorCell(59, 164, i)
                '贝13
            Case "130682"
                FillHorCell(13, 152, i)
            Case "130482"
                FillHorCell(21, 152, i)
            Case "130282"
                FillHorCell(29, 152, i)
            Case "130182"
                FillHorCell(43, 152, i)
            Case "130382"
                FillHorCell(51, 152, i)
            Case "130582"
                FillHorCell(59, 152, i)
                '贝15
            Case "150682"
                FillHorCell(13, 141, i)
            Case "150482"
                FillHorCell(21, 141, i)
            Case "150282"
                FillHorCell(29, 141, i)
            Case "150182"
                FillHorCell(43, 141, i)
            Case "150382"
                FillHorCell(51, 141, i)
            Case "150582"
                FillHorCell(59, 141, i)
                '贝17
            Case "170682"
                FillHorCell(13, 129, i)
            Case "170482"
                FillHorCell(21, 129, i)
            Case "170282"
                FillHorCell(29, 129, i)
            Case "170182"
                FillHorCell(43, 129, i)
            Case "170382"
                FillHorCell(51, 129, i)
            Case "170582"
                FillHorCell(59, 129, i)
                '贝19
            Case "190682"
                FillHorCell(13, 118, i)
            Case "190482"
                FillHorCell(21, 118, i)
            Case "190282"
                FillHorCell(29, 118, i)
            Case "190182"
                FillHorCell(43, 118, i)
            Case "190382"
                FillHorCell(51, 118, i)
            Case "190582"
                FillHorCell(59, 118, i)
                '贝21
            Case "210682"
                FillHorCell(13, 106, i)
            Case "210482"
                FillHorCell(23, 106, i)
            Case "210282"
                FillHorCell(31, 106, i)
            Case "210182"
                FillVerCell(40, 114, i)
            Case "210382"
                FillVerCell(53, 114, i)
                '贝21
            Case "230682"
                FillHorCell(13, 95, i)
            Case "230482"
                FillHorCell(23, 95, i)
            Case "230282"
                FillHorCell(31, 95, i)
            Case "230182"
                FillHorCell(40, 97, i)
            Case "230382"
                FillHorCell(48, 97, i)
            Case "230582"
                FillHorCell(56, 97, i)
                '贝25
            Case "250682"
                FillHorCell(14, 83, i)
            Case "250482"
                FillHorCell(22, 83, i)
            Case "250182"
                FillHorCell(40, 86, i)
            Case "250382"
                FillHorCell(48, 86, i)
            Case "250582"
                FillHorCell(56, 86, i)
                '贝27
            Case "270682"
                FillHorCell(14, 72, i)
            Case "270482"
                FillHorCell(22, 72, i)
            Case "270182"
                FillHorCell(40, 74, i)
            Case "270382"
                FillHorCell(48, 74, i)
            Case "270582"
                FillHorCell(56, 74, i)
                '贝29
            Case "290682"
                FillHorCell(14, 60, i)
            Case "290482"
                FillHorCell(22, 60, i)
            Case "290182"
                FillHorCell(40, 63, i)
            Case "290382"
                FillHorCell(48, 63, i)
            Case "290582"
                FillHorCell(56, 63, i)
                '贝31
            Case "310682"
                FillHorCell(14, 49, i)
            Case "310482"
                FillHorCell(22, 49, i)
            Case "310182"
                FillHorCell(40, 51, i)
            Case "310382"
                FillHorCell(48, 51, i)
            Case "310582"
                FillHorCell(56, 51, i)
                '贝33
            Case "330682"
                FillHorCell(14, 37, i)
            Case "330482"
                FillHorCell(22, 37, i)
            Case "330182"
                FillHorCell(40, 40, i)
            Case "330382"
                FillHorCell(48, 40, i)
            Case "330582"
                FillHorCell(56, 40, i)
                '贝35
            Case "350682"
                FillHorCell(14, 26, i)
            Case "350482"
                FillHorCell(22, 26, i)
            Case "350182"
                FillHorCell(43, 25, i)
            Case "350382"
                FillHorCell(51, 25, i)
            Case "350582"
                FillHorCell(59, 25, i)
                '贝37
            Case "370682"
                FillHorCell(14, 14, i)
            Case "370482"
                FillHorCell(22, 14, i)
            Case "370282"
                FillHorCell(30, 14, i)
            Case "370182"
                FillHorCell(43, 14, i)
            Case "370382"
                FillHorCell(51, 14, i)
            Case "370582"
                FillHorCell(59, 14, i)

        End Select
    End Sub
    '填写D-Deck面图单元格
    Public Shared Sub FillDDeckCell(ByVal i As Integer)
        Select Case TongBayNo(dv(i)("BayNo"))
            '贝1'''
        Case "010002"
                FillHorCell(96, 222, i)
                '贝3'''
            Case "030002"
                FillHorCell(96, 211, i)
                '贝5'''
            Case "050602"
                FillHorCell(75, 199, i)
            Case "050402"
                FillHorCell(83, 199, i)
            Case "050202"
                FillHorCell(91, 199, i)
            Case "050502"
                FillHorCell(116, 199, i)
            Case "050302"
                FillHorCell(108, 199, i)
            Case "050102"
                FillHorCell(100, 199, i)
                '贝7'''
            Case "070602"
                FillHorCell(75, 188, i)
            Case "070402"
                FillHorCell(83, 188, i)
            Case "070202"
                FillHorCell(91, 188, i)
            Case "070502"
                FillHorCell(116, 188, i)
            Case "070302"
                FillHorCell(108, 188, i)
            Case "070102"
                FillHorCell(100, 188, i)
                '贝9'''
            Case "090602"
                FillHorCell(75, 176, i)
            Case "090402"
                FillHorCell(83, 176, i)
            Case "090202"
                FillHorCell(91, 176, i)
            Case "090502"
                FillHorCell(116, 176, i)
            Case "090302"
                FillHorCell(108, 176, i)
            Case "090102"
                FillHorCell(100, 176, i)
                '贝11'''
            Case "110602"
                FillHorCell(75, 165, i)
            Case "110402"
                FillHorCell(83, 165, i)
            Case "110202"
                FillHorCell(91, 165, i)
            Case "110502"
                FillHorCell(116, 165, i)
            Case "110302"
                FillHorCell(108, 165, i)
            Case "110102"
                FillHorCell(100, 165, i)

                '贝13'''
            Case "130602"
                FillHorCell(75, 152, i)
            Case "130402"
                FillHorCell(83, 152, i)
            Case "130202"
                FillHorCell(91, 152, i)
            Case "130102"
                FillHorCell(100, 152, i)
            Case "130302"
                FillHorCell(108, 152, i)
            Case "130502"
                FillHorCell(116, 152, i)
                '贝15''
            Case "150602"
                FillHorCell(75, 141, i)
            Case "150402"
                FillHorCell(83, 141, i)
            Case "150202"
                FillHorCell(91, 141, i)
            Case "150102"
                FillHorCell(100, 141, i)
            Case "150302"
                FillHorCell(108, 141, i)
            Case "150502"
                FillHorCell(116, 141, i)
                '贝17''
            Case "170602"
                FillHorCell(75, 129, i)
            Case "170402"
                FillHorCell(83, 129, i)
            Case "170202"
                FillHorCell(91, 129, i)
            Case "170102"
                FillHorCell(100, 129, i)
            Case "170302"
                FillHorCell(108, 129, i)
            Case "170502"
                FillHorCell(116, 129, i)
                '贝19''
            Case "190602"
                FillHorCell(75, 118, i)
            Case "190402"
                FillHorCell(83, 118, i)
            Case "190202"
                FillHorCell(91, 118, i)
            Case "190102"
                FillHorCell(100, 118, i)
            Case "190302"
                FillHorCell(108, 118, i)
            Case "190502"
                FillHorCell(116, 118, i)
                '贝21''
            Case "210602"
                FillHorCell(75, 106, i)
            Case "210402"
                FillHorCell(83, 106, i)
            Case "210202"
                FillHorCell(91, 106, i)
            Case "210102"
                FillHorCell(100, 106, i)
            Case "210302"
                FillHorCell(108, 106, i)
            Case "210502"
                FillHorCell(116, 106, i)
                '贝23''
            Case "230602"
                FillHorCell(75, 95, i)
            Case "230402"
                FillHorCell(83, 95, i)
            Case "230202"
                FillHorCell(91, 95, i)
            Case "230102"
                FillHorCell(100, 95, i)
            Case "230302"
                FillHorCell(108, 95, i)
            Case "230502"
                FillHorCell(116, 95, i)
                '贝25
            Case "250602"
                FillHorCell(75, 83, i)
            Case "250402"
                FillHorCell(83, 83, i)
            Case "250202"
                FillHorCell(91, 83, i)
            Case "250102"
                FillHorCell(100, 83, i)
            Case "250302"
                FillHorCell(108, 83, i)
            Case "250502"
                FillHorCell(116, 83, i)
                '贝27
            Case "270602"
                FillHorCell(75, 72, i)
            Case "270402"
                FillHorCell(83, 72, i)
            Case "270202"
                FillHorCell(91, 72, i)
            Case "270102"
                FillHorCell(100, 72, i)
            Case "270302"
                FillHorCell(108, 72, i)
            Case "270502"
                FillHorCell(116, 72, i)
                '贝29
            Case "290602"
                FillHorCell(75, 60, i)
            Case "290402"
                FillHorCell(83, 60, i)
            Case "290202"
                FillHorCell(91, 60, i)
            Case "290102"
                FillHorCell(100, 60, i)
            Case "290302"
                FillHorCell(108, 60, i)
            Case "290502"
                FillHorCell(116, 60, i)
                '贝31''
            Case "310602"
                FillHorCell(75, 49, i)
            Case "310402"
                FillHorCell(83, 49, i)
            Case "310202"
                FillHorCell(91, 49, i)
            Case "310102"
                FillHorCell(100, 49, i)
            Case "310302"
                FillHorCell(108, 49, i)
            Case "310502"
                FillHorCell(116, 49, i)
                '贝33
            Case "330602"
                FillHorCell(75, 37, i)
            Case "330402"
                FillHorCell(83, 37, i)
            Case "330202"
                FillHorCell(91, 37, i)
            Case "330102"
                FillHorCell(100, 37, i)
            Case "330302"
                FillHorCell(108, 37, i)
            Case "330502"
                FillHorCell(116, 37, i)
                '贝35
            Case "350602"
                FillHorCell(75, 26, i)
            Case "350402"
                FillHorCell(83, 26, i)
            Case "350202"
                FillHorCell(91, 26, i)
            Case "350102"
                FillHorCell(100, 26, i)
            Case "350302"
                FillHorCell(108, 26, i)
            Case "350502"
                FillHorCell(116, 26, i)
                '贝37
            Case "370402"
                FillHorCell(79, 14, i)
            Case "370202"
                FillHorCell(87, 14, i)
            Case "370002"
                FillHorCell(95, 14, i)
            Case "370102"
                FillHorCell(103, 14, i)
            Case "370302"
                FillHorCell(111, 14, i)
                '贝39
            Case "390402"
                FillHorCell(79, 3, i)
            Case "390202"
                FillHorCell(87, 3, i)
            Case "390002"
                FillHorCell(95, 3, i)
            Case "390102"
                FillHorCell(103, 3, i)
            Case "390302"
                FillHorCell(111, 3, i)
        End Select
    End Sub
End Class
