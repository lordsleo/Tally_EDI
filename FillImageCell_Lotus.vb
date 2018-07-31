Public Class FillImageCell_Lotus    '莲花轮船图
    Inherits FillImageCell

    '横向贝位
    Public Shared Shadows Sub FillHorCell(ByVal a As Integer, ByVal b As Integer, ByVal i As Integer)
        If Not IsDBNull(dv(i)("CONTAINER_NO")) Then
            xlSheet.Cells(a, b) = dv(i)("CONTAINER_NO")
            xlSheet.Cells(a + 2, b) = dv(i)("SIZE_CON") & dv(i)("CONTAINER_TYPE")
            If Not IsDBNull(dv(i)("CONTAINER_TYPE")) AndAlso dv(i)("CONTAINER_TYPE") Like "R?" Then
                xlSheet.Cells(a + 2, b + 2) = "R"
                xlSheet.Cells(a + 2, b + 4) = dv(i)("TEMPERATURE_SETTING")
            ElseIf Not IsDBNull(dv(i)("DANGER_GRADE")) AndAlso Trim(dv(i)("DANGER_GRADE")).Length > 0 Then
                xlSheet.Cells(a + 2, b + 2) = "D"
                xlSheet.Cells(a + 2, b + 4) = dv(i)("DANGER_GRADE")
            Else
                xlSheet.Cells(a + 2, b + 2) = dv(i)("FULLOREMPTY")
            End If
            If Not IsDBNull(dv(i)("GROSSWEIGHT")) Then
                xlSheet.Cells(a + 4, b + 3) = Format(dv(i)("GROSSWEIGHT") / 1000, "0.##")
            End If
        End If
        xlSheet.Cells(a + 4, b) = dv(i)("Tray")
    End Sub

    ''' <summary>
    ''' 填写ORIGINAL面图单元格
    ''' </summary>
    Public Shared Sub FillOriginalCell(ByVal i As Integer)
        '如果Excel中有的Deck中所有贝位的相对位置相同，可以选择调用各个填写程序。可以减少重复代码
        '如果全部位置都相同，就不用在这里写Select Case代码了
        '如果没有相应的Deck可以不调用，或者程序为空
        If dv(i)("BayNo") Like "*02" Then
            Select Case TongBayNo(dv(i)("BayNo"))
                Case "010002"
                    FillHorCell(220, 129, i)
                Case "030002"
                    FillHorCell(220, 124, i)

                Case "050202"
                    FillHorCell(212, 118, i)
                Case "050002"
                    FillHorCell(220, 118, i)
                Case "050102"
                    FillHorCell(228, 118, i)
                Case "070202"
                    FillHorCell(212, 113, i)
                Case "070002"
                    FillHorCell(220, 113, i)
                Case "070102"
                    FillHorCell(228, 113, i)

                Case "090202"
                    FillHorCell(212, 107, i)
                Case "090002"
                    FillHorCell(220, 107, i)
                Case "090102"
                    FillHorCell(228, 107, i)
                Case "110202"
                    FillHorCell(212, 102, i)
                Case "110002"
                    FillHorCell(220, 102, i)
                Case "110102"
                    FillHorCell(228, 102, i)

                Case "130202"
                    FillHorCell(212, 96, i)
                Case "130002"
                    FillHorCell(220, 96, i)
                Case "130102"
                    FillHorCell(228, 96, i)
                Case "150202"
                    FillHorCell(212, 91, i)
                Case "150002"
                    FillHorCell(220, 91, i)
                Case "150102"
                    FillHorCell(228, 91, i)

                Case "170202"
                    FillHorCell(212, 85, i)
                Case "170002"
                    FillHorCell(220, 85, i)
                Case "170102"
                    FillHorCell(228, 85, i)
                Case "190202"
                    FillHorCell(212, 80, i)
                Case "190002"
                    FillHorCell(220, 80, i)
                Case "190102"
                    FillHorCell(228, 80, i)

                Case "210202"
                    FillHorCell(212, 74, i)
                Case "210002"
                    FillHorCell(220, 74, i)
                Case "210102"
                    FillHorCell(228, 74, i)
                Case "230202"
                    FillHorCell(212, 69, i)
                Case "230002"
                    FillHorCell(220, 69, i)
                Case "230102"
                    FillHorCell(228, 69, i)
            End Select
        ElseIf dv(i)("BayNo") Like "*04" Then
            Select Case TongBayNo(dv(i)("BayNo"))
                Case "010204"
                    FillHorCell(158, 118 + 11, i)
                Case "010104"
                    FillHorCell(174, 118 + 11, i)
                Case "030204"
                    FillHorCell(158, 113 + 11, i)
                Case "030104"
                    FillHorCell(174, 113 + 11, i)

                Case "050404"
                    FillHorCell(150, 107 + 11, i)
                Case "050204"
                    FillHorCell(158, 107 + 11, i)
                Case "050004"
                    FillHorCell(166, 107 + 11, i)
                Case "050104"
                    FillHorCell(174, 107 + 11, i)
                Case "050304"
                    FillHorCell(182, 107 + 11, i)

                Case "070404"
                    FillHorCell(150, 102 + 11, i)
                Case "070204"
                    FillHorCell(158, 102 + 11, i)
                Case "070004"
                    FillHorCell(166, 102 + 11, i)
                Case "070104"
                    FillHorCell(174, 102 + 11, i)
                Case "070304"
                    FillHorCell(182, 102 + 11, i)

                Case "090604"
                    FillHorCell(142, 96 + 11, i)
                Case "090404"
                    FillHorCell(150, 96 + 11, i)
                Case "090204"
                    FillHorCell(158, 96 + 11, i)
                Case "090004"
                    FillHorCell(166, 96 + 11, i)
                Case "090104"
                    FillHorCell(174, 96 + 11, i)
                Case "090304"
                    FillHorCell(182, 96 + 11, i)
                Case "090504"
                    FillHorCell(190, 96 + 11, i)

                Case "110604"
                    FillHorCell(142, 91 + 11, i)
                Case "110404"
                    FillHorCell(150, 91 + 11, i)
                Case "110204"
                    FillHorCell(158, 91 + 11, i)
                Case "110004"
                    FillHorCell(166, 91 + 11, i)
                Case "110104"
                    FillHorCell(174, 91 + 11, i)
                Case "110304"
                    FillHorCell(182, 91 + 11, i)
                Case "110504"
                    FillHorCell(190, 91 + 11, i)

                Case "130804"
                    FillHorCell(138, 85 + 11, i)
                Case "130604"
                    FillHorCell(146, 85 + 11, i)
                Case "130404"
                    FillHorCell(154, 85 + 11, i)
                Case "130204"
                    FillHorCell(162, 85 + 11, i)
                Case "130004"
                    FillHorCell(170, 85 + 11, i)
                Case "130104"
                    FillHorCell(178, 85 + 11, i)
                Case "130304"
                    FillHorCell(186, 85 + 11, i)
                Case "130504"
                    FillHorCell(194, 85 + 11, i)

                Case "150804"
                    FillHorCell(138, 80 + 11, i)
                Case "150604"
                    FillHorCell(146, 80 + 11, i)
                Case "150404"
                    FillHorCell(154, 80 + 11, i)
                Case "150204"
                    FillHorCell(162, 80 + 11, i)
                Case "150004"
                    FillHorCell(170, 80 + 11, i)
                Case "150104"
                    FillHorCell(178, 80 + 11, i)
                Case "150304"
                    FillHorCell(186, 80 + 11, i)
                Case "150504"
                    FillHorCell(194, 80 + 11, i)

                Case "170604"
                    FillHorCell(146, 74 + 11, i)
                Case "170404"
                    FillHorCell(154, 74 + 11, i)
                Case "170204"
                    FillHorCell(162, 74 + 11, i)
                Case "170004"
                    FillHorCell(170, 74 + 11, i)
                Case "170104"
                    FillHorCell(178, 74 + 11, i)
                Case "170304"
                    FillHorCell(186, 74 + 11, i)
                Case "170504"
                    FillHorCell(194, 74 + 11, i)

                Case "190604"
                    FillHorCell(146, 69 + 11, i)
                Case "190404"
                    FillHorCell(154, 69 + 11, i)
                Case "190204"
                    FillHorCell(162, 69 + 11, i)
                Case "190004"
                    FillHorCell(170, 69 + 11, i)
                Case "190104"
                    FillHorCell(178, 69 + 11, i)
                Case "190304"
                    FillHorCell(186, 69 + 11, i)
                Case "190504"
                    FillHorCell(194, 69 + 11, i)

                Case "210604"
                    FillHorCell(146, 63 + 11, i)
                Case "210404"
                    FillHorCell(154, 63 + 11, i)
                Case "210204"
                    FillHorCell(162, 63 + 11, i)
                Case "210004"
                    FillHorCell(170, 63 + 11, i)
                Case "210104"
                    FillHorCell(178, 63 + 11, i)
                Case "210304"
                    FillHorCell(186, 63 + 11, i)
                Case "210504"
                    FillHorCell(194, 63 + 11, i)

                Case "230604"
                    FillHorCell(146, 58 + 11, i)
                Case "230404"
                    FillHorCell(154, 58 + 11, i)
                Case "230204"
                    FillHorCell(162, 58 + 11, i)
                Case "230004"
                    FillHorCell(170, 58 + 11, i)
                Case "230104"
                    FillHorCell(178, 58 + 11, i)
                Case "230304"
                    FillHorCell(186, 58 + 11, i)
                Case "230504"
                    FillHorCell(194, 58 + 11, i)

                Case "250604"
                    FillHorCell(146, 52 + 11, i)
                Case "250404"
                    FillHorCell(154, 52 + 11, i)
                Case "250204"
                    FillHorCell(162, 52 + 11, i)
                Case "250004"
                    FillHorCell(170, 52 + 11, i)
                Case "250104"
                    FillHorCell(178, 52 + 11, i)
                Case "250304"
                    FillHorCell(186, 52 + 11, i)
                Case "250504"
                    FillHorCell(194, 52 + 11, i)

                Case "270604"
                    FillHorCell(146, 47 + 11, i)
                Case "270404"
                    FillHorCell(154, 47 + 11, i)
                Case "270204"
                    FillHorCell(162, 47 + 11, i)
                Case "270004"
                    FillHorCell(170, 47 + 11, i)
                Case "270104"
                    FillHorCell(178, 47 + 11, i)
                Case "270304"
                    FillHorCell(186, 47 + 11, i)
                Case "270504"
                    FillHorCell(194, 47 + 11, i)

                Case "290604"
                    FillHorCell(146, 41 + 11, i)
                Case "290404"
                    FillHorCell(154, 41 + 11, i)
                Case "290204"
                    FillHorCell(162, 41 + 11, i)
                Case "290004"
                    FillHorCell(170, 41 + 11, i)
                Case "290104"
                    FillHorCell(178, 41 + 11, i)
                Case "290304"
                    FillHorCell(186, 41 + 11, i)
                Case "290504"
                    FillHorCell(194, 41 + 11, i)

                Case "310604"
                    FillHorCell(146, 36 + 11, i)
                Case "310404"
                    FillHorCell(154, 36 + 11, i)
                Case "310204"
                    FillHorCell(162, 36 + 11, i)
                Case "310004"
                    FillHorCell(170, 36 + 11, i)
                Case "310104"
                    FillHorCell(178, 36 + 11, i)
                Case "310304"
                    FillHorCell(186, 36 + 11, i)
                Case "310504"
                    FillHorCell(194, 36 + 11, i)

                Case "330604"
                    FillHorCell(146, 30 + 11, i)
                Case "330404"
                    FillHorCell(154, 30 + 11, i)
                Case "330204"
                    FillHorCell(162, 30 + 11, i)
                Case "330004"
                    FillHorCell(170, 30 + 11, i)
                Case "330104"
                    FillHorCell(178, 30 + 11, i)
                Case "330304"
                    FillHorCell(186, 30 + 11, i)
                Case "330504"
                    FillHorCell(194, 30 + 11, i)

                Case "350604"
                    FillHorCell(146, 25 + 11, i)
                Case "350404"
                    FillHorCell(154, 25 + 11, i)
                Case "350204"
                    FillHorCell(162, 25 + 11, i)
                Case "350004"
                    FillHorCell(170, 25 + 11, i)
                Case "350104"
                    FillHorCell(178, 25 + 11, i)
                Case "350304"
                    FillHorCell(186, 25 + 11, i)
                Case "350504"
                    FillHorCell(194, 25 + 11, i)

                Case "370604"
                    FillHorCell(146, 19 + 11, i)
                Case "370404"
                    FillHorCell(154, 19 + 11, i)
                Case "370204"
                    FillHorCell(162, 19 + 11, i)
                Case "370004"
                    FillHorCell(170, 19 + 11, i)
                Case "370104"
                    FillHorCell(178, 19 + 11, i)
                Case "370304"
                    FillHorCell(186, 19 + 11, i)
                Case "370504"
                    FillHorCell(194, 19 + 11, i)
                Case "370704"
                    FillHorCell(202, 19 + 11, i)

                Case "390604"
                    FillHorCell(146, 14 + 11, i)
                Case "390404"
                    FillHorCell(154, 14 + 11, i)
                Case "390204"
                    FillHorCell(162, 14 + 11, i)
                Case "390004"
                    FillHorCell(170, 14 + 11, i)
                Case "390104"
                    FillHorCell(178, 14 + 11, i)
                Case "390304"
                    FillHorCell(186, 14 + 11, i)
                Case "390504"
                    FillHorCell(194, 14 + 11, i)
                Case "390704"
                    FillHorCell(202, 14 + 11, i)

                Case "410204"
                    FillHorCell(162, 8 + 11, i)
                Case "410004"
                    FillHorCell(170, 8 + 11, i)
                Case "410104"
                    FillHorCell(178, 8 + 11, i)
                Case "410304"
                    FillHorCell(186, 8 + 11, i)

                Case "430204"
                    FillHorCell(162, 3 + 11, i)
                Case "430004"
                    FillHorCell(170, 3 + 11, i)
                Case "430104"
                    FillHorCell(178, 3 + 11, i)
                Case "430304"
                    FillHorCell(186, 3 + 11, i)
            End Select
        Else
            FillFourDeckCell(i)
        End If
    End Sub

    ''' <summary>
    ''' 一舱 02层
    ''' </summary>
    Public Shared Sub FillOneDeckCell(ByVal i As Integer)
        Select Case TongBayNo(dv(i)("BayNo"))
            Case "010002"
                FillHorCell(27, 129, i)
            Case "030002"
                FillHorCell(27, 124, i)

            Case "050202"
                FillHorCell(19, 118, i)
            Case "050002"
                FillHorCell(27, 118, i)
            Case "050102"
                FillHorCell(35, 118, i)
            Case "070202"
                FillHorCell(19, 113, i)
            Case "070002"
                FillHorCell(27, 113, i)
            Case "070102"
                FillHorCell(35, 113, i)

            Case "090202"
                FillHorCell(19, 107, i)
            Case "090002"
                FillHorCell(27, 107, i)
            Case "090102"
                FillHorCell(35, 107, i)
            Case "110202"
                FillHorCell(19, 102, i)
            Case "110002"
                FillHorCell(27, 102, i)
            Case "110102"
                FillHorCell(35, 102, i)

            Case "130202"
                FillHorCell(19, 96, i)
            Case "130002"
                FillHorCell(27, 96, i)
            Case "130102"
                FillHorCell(35, 96, i)
            Case "150202"
                FillHorCell(19, 91, i)
            Case "150002"
                FillHorCell(27, 91, i)
            Case "150102"
                FillHorCell(35, 91, i)

            Case "170202"
                FillHorCell(19, 85, i)
            Case "170002"
                FillHorCell(27, 85, i)
            Case "170102"
                FillHorCell(35, 85, i)
            Case "190202"
                FillHorCell(19, 80, i)
            Case "190002"
                FillHorCell(27, 80, i)
            Case "190102"
                FillHorCell(35, 80, i)

            Case "210202"
                FillHorCell(19, 74, i)
            Case "210002"
                FillHorCell(27, 74, i)
            Case "210102"
                FillHorCell(35, 74, i)
            Case "230202"
                FillHorCell(19, 69, i)
            Case "230002"
                FillHorCell(27, 69, i)
            Case "230102"
                FillHorCell(35, 69, i)
        End Select
    End Sub

    ''' <summary>
    ''' 三舱 04层
    ''' </summary>
    Public Shared Sub FillThreeDeckCell(ByVal i As Integer)
        Select Case TongBayNo(dv(i)("BayNo"))
            Case "010204"
                FillHorCell(92, 118, i)
            Case "010104"
                FillHorCell(108, 118, i)
            Case "030204"
                FillHorCell(92, 113, i)
            Case "030104"
                FillHorCell(108, 113, i)

            Case "050404"
                FillHorCell(84, 107, i)
            Case "050204"
                FillHorCell(92, 107, i)
            Case "050004"
                FillHorCell(100, 107, i)
            Case "050104"
                FillHorCell(108, 107, i)
            Case "050304"
                FillHorCell(116, 107, i)

            Case "070404"
                FillHorCell(84, 102, i)
            Case "070204"
                FillHorCell(92, 102, i)
            Case "070004"
                FillHorCell(100, 102, i)
            Case "070104"
                FillHorCell(108, 102, i)
            Case "070304"
                FillHorCell(116, 102, i)

            Case "090604"
                FillHorCell(76, 96, i)
            Case "090404"
                FillHorCell(84, 96, i)
            Case "090204"
                FillHorCell(92, 96, i)
            Case "090004"
                FillHorCell(100, 96, i)
            Case "090104"
                FillHorCell(108, 96, i)
            Case "090304"
                FillHorCell(116, 96, i)
            Case "090504"
                FillHorCell(124, 96, i)

            Case "110604"
                FillHorCell(76, 91, i)
            Case "110404"
                FillHorCell(84, 91, i)
            Case "110204"
                FillHorCell(92, 91, i)
            Case "110004"
                FillHorCell(100, 91, i)
            Case "110104"
                FillHorCell(108, 91, i)
            Case "110304"
                FillHorCell(116, 91, i)
            Case "110504"
                FillHorCell(124, 91, i)

            Case "130804"
                FillHorCell(72, 85, i)
            Case "130604"
                FillHorCell(80, 85, i)
            Case "130404"
                FillHorCell(88, 85, i)
            Case "130204"
                FillHorCell(96, 85, i)
            Case "130004"
                FillHorCell(104, 85, i)
            Case "130104"
                FillHorCell(112, 85, i)
            Case "130304"
                FillHorCell(120, 85, i)
            Case "130504"
                FillHorCell(128, 85, i)

            Case "150804"
                FillHorCell(72, 80, i)
            Case "150604"
                FillHorCell(80, 80, i)
            Case "150404"
                FillHorCell(88, 80, i)
            Case "150204"
                FillHorCell(96, 80, i)
            Case "150004"
                FillHorCell(104, 80, i)
            Case "150104"
                FillHorCell(112, 80, i)
            Case "150304"
                FillHorCell(120, 80, i)
            Case "150504"
                FillHorCell(128, 80, i)

            Case "170604"
                FillHorCell(80, 74, i)
            Case "170404"
                FillHorCell(88, 74, i)
            Case "170204"
                FillHorCell(96, 74, i)
            Case "170004"
                FillHorCell(104, 74, i)
            Case "170104"
                FillHorCell(112, 74, i)
            Case "170304"
                FillHorCell(120, 74, i)
            Case "170504"
                FillHorCell(128, 74, i)

            Case "190604"
                FillHorCell(80, 69, i)
            Case "190404"
                FillHorCell(88, 69, i)
            Case "190204"
                FillHorCell(96, 69, i)
            Case "190004"
                FillHorCell(104, 69, i)
            Case "190104"
                FillHorCell(112, 69, i)
            Case "190304"
                FillHorCell(120, 69, i)
            Case "190504"
                FillHorCell(128, 69, i)

            Case "210604"
                FillHorCell(80, 63, i)
            Case "210404"
                FillHorCell(88, 63, i)
            Case "210204"
                FillHorCell(96, 63, i)
            Case "210004"
                FillHorCell(104, 63, i)
            Case "210104"
                FillHorCell(112, 63, i)
            Case "210304"
                FillHorCell(120, 63, i)
            Case "210504"
                FillHorCell(128, 63, i)

            Case "230604"
                FillHorCell(80, 58, i)
            Case "230404"
                FillHorCell(88, 58, i)
            Case "230204"
                FillHorCell(96, 58, i)
            Case "230004"
                FillHorCell(104, 58, i)
            Case "230104"
                FillHorCell(112, 58, i)
            Case "230304"
                FillHorCell(120, 58, i)
            Case "230504"
                FillHorCell(128, 58, i)

            Case "250604"
                FillHorCell(80, 52, i)
            Case "250404"
                FillHorCell(88, 52, i)
            Case "250204"
                FillHorCell(96, 52, i)
            Case "250004"
                FillHorCell(104, 52, i)
            Case "250104"
                FillHorCell(112, 52, i)
            Case "250304"
                FillHorCell(120, 52, i)
            Case "250504"
                FillHorCell(128, 52, i)

            Case "270604"
                FillHorCell(80, 47, i)
            Case "270404"
                FillHorCell(88, 47, i)
            Case "270204"
                FillHorCell(96, 47, i)
            Case "270004"
                FillHorCell(104, 47, i)
            Case "270104"
                FillHorCell(112, 47, i)
            Case "270304"
                FillHorCell(120, 47, i)
            Case "270504"
                FillHorCell(128, 47, i)

            Case "290604"
                FillHorCell(80, 41, i)
            Case "290404"
                FillHorCell(88, 41, i)
            Case "290204"
                FillHorCell(96, 41, i)
            Case "290004"
                FillHorCell(104, 41, i)
            Case "290104"
                FillHorCell(112, 41, i)
            Case "290304"
                FillHorCell(120, 41, i)
            Case "290504"
                FillHorCell(128, 41, i)

            Case "310604"
                FillHorCell(80, 36, i)
            Case "310404"
                FillHorCell(88, 36, i)
            Case "310204"
                FillHorCell(96, 36, i)
            Case "310004"
                FillHorCell(104, 36, i)
            Case "310104"
                FillHorCell(112, 36, i)
            Case "310304"
                FillHorCell(120, 36, i)
            Case "310504"
                FillHorCell(128, 36, i)

            Case "330604"
                FillHorCell(80, 30, i)
            Case "330404"
                FillHorCell(88, 30, i)
            Case "330204"
                FillHorCell(96, 30, i)
            Case "330004"
                FillHorCell(104, 30, i)
            Case "330104"
                FillHorCell(112, 30, i)
            Case "330304"
                FillHorCell(120, 30, i)
            Case "330504"
                FillHorCell(128, 30, i)

            Case "350604"
                FillHorCell(80, 25, i)
            Case "350404"
                FillHorCell(88, 25, i)
            Case "350204"
                FillHorCell(96, 25, i)
            Case "350004"
                FillHorCell(104, 25, i)
            Case "350104"
                FillHorCell(112, 25, i)
            Case "350304"
                FillHorCell(120, 25, i)
            Case "350504"
                FillHorCell(128, 25, i)

            Case "370604"
                FillHorCell(80, 19, i)
            Case "370404"
                FillHorCell(88, 19, i)
            Case "370204"
                FillHorCell(96, 19, i)
            Case "370004"
                FillHorCell(104, 19, i)
            Case "370104"
                FillHorCell(112, 19, i)
            Case "370304"
                FillHorCell(120, 19, i)
            Case "370504"
                FillHorCell(128, 19, i)
            Case "370704"
                FillHorCell(136, 19, i)

            Case "390604"
                FillHorCell(80, 14, i)
            Case "390404"
                FillHorCell(88, 14, i)
            Case "390204"
                FillHorCell(96, 14, i)
            Case "390004"
                FillHorCell(104, 14, i)
            Case "390104"
                FillHorCell(112, 14, i)
            Case "390304"
                FillHorCell(120, 14, i)
            Case "390504"
                FillHorCell(128, 14, i)
            Case "390704"
                FillHorCell(136, 14, i)

            Case "410204"
                FillHorCell(96, 8, i)
            Case "410004"
                FillHorCell(104, 8, i)
            Case "410104"
                FillHorCell(112, 8, i)
            Case "410304"
                FillHorCell(120, 8, i)

            Case "430204"
                FillHorCell(96, 3, i)
            Case "430004"
                FillHorCell(104, 3, i)
            Case "430104"
                FillHorCell(112, 3, i)
            Case "430304"
                FillHorCell(120, 3, i)

        End Select
    End Sub

    ''' <summary>
    ''' 四舱 06层
    ''' </summary>
    Public Shared Sub FillFourDeckCell(ByVal i As Integer)
        Select Case TongBayNo(dv(i)("BayNo"))
            Case "010406"
                FillHorCell(80, 129, i)
            Case "010206"
                FillHorCell(88, 129, i)
            Case "010006"
                FillHorCell(96, 129, i)
            Case "010106"
                FillHorCell(104, 129, i)
            Case "010306"
                FillHorCell(112, 129, i)
            Case "010506"
                FillHorCell(120, 129, i)

            Case "030406"
                FillHorCell(80, 124, i)
            Case "030206"
                FillHorCell(88, 124, i)
            Case "030006"
                FillHorCell(96, 124, i)
            Case "030106"
                FillHorCell(104, 124, i)
            Case "030306"
                FillHorCell(112, 124, i)
            Case "030506"
                FillHorCell(120, 124, i)

            Case "050406"
                FillHorCell(80, 118, i)
            Case "050206"
                FillHorCell(88, 118, i)
            Case "050006"
                FillHorCell(96, 118, i)
            Case "050106"
                FillHorCell(104, 118, i)
            Case "050306"
                FillHorCell(112, 118, i)
            Case "050506"
                FillHorCell(120, 118, i)

            Case "070406"
                FillHorCell(80, 113, i)
            Case "070206"
                FillHorCell(88, 113, i)
            Case "070006"
                FillHorCell(96, 113, i)
            Case "070106"
                FillHorCell(104, 113, i)
            Case "070306"
                FillHorCell(112, 113, i)
            Case "070506"
                FillHorCell(120, 113, i)

            Case "090606"
                FillHorCell(72, 107, i)
            Case "090406"
                FillHorCell(80, 107, i)
            Case "090206"
                FillHorCell(88, 107, i)
            Case "090006"
                FillHorCell(96, 107, i)
            Case "090106"
                FillHorCell(104, 107, i)
            Case "090306"
                FillHorCell(112, 107, i)
            Case "090506"
                FillHorCell(120, 107, i)
            Case "090706"
                FillHorCell(128, 107, i)

            Case "110606"
                FillHorCell(72, 102, i)
            Case "110406"
                FillHorCell(80, 102, i)
            Case "110206"
                FillHorCell(88, 102, i)
            Case "110006"
                FillHorCell(96, 102, i)
            Case "110106"
                FillHorCell(104, 102, i)
            Case "110306"
                FillHorCell(112, 102, i)
            Case "110506"
                FillHorCell(120, 102, i)
            Case "110706"
                FillHorCell(128, 102, i)

            Case "130606"
                FillHorCell(72, 96, i)
            Case "130406"
                FillHorCell(80, 96, i)
            Case "130206"
                FillHorCell(88, 96, i)
            Case "130006"
                FillHorCell(96, 96, i)
            Case "130106"
                FillHorCell(104, 96, i)
            Case "130306"
                FillHorCell(112, 96, i)
            Case "130506"
                FillHorCell(120, 96, i)
            Case "130706"
                FillHorCell(128, 96, i)

            Case "150606"
                FillHorCell(72, 91, i)
            Case "150406"
                FillHorCell(80, 91, i)
            Case "150206"
                FillHorCell(88, 91, i)
            Case "150006"
                FillHorCell(96, 91, i)
            Case "150106"
                FillHorCell(104, 91, i)
            Case "150306"
                FillHorCell(112, 91, i)
            Case "150506"
                FillHorCell(120, 91, i)
            Case "150706"
                FillHorCell(128, 91, i)

            Case "170406"
                FillHorCell(80, 85, i)
            Case "170206"
                FillHorCell(88, 85, i)
            Case "170006"
                FillHorCell(96, 85, i)
            Case "170106"
                FillHorCell(104, 85, i)
            Case "170306"
                FillHorCell(112, 85, i)
            Case "170506"
                FillHorCell(120, 85, i)

            Case "190406"
                FillHorCell(80, 80, i)
            Case "190206"
                FillHorCell(88, 80, i)
            Case "190006"
                FillHorCell(96, 80, i)
            Case "190106"
                FillHorCell(104, 80, i)
            Case "190306"
                FillHorCell(112, 80, i)
            Case "190506"
                FillHorCell(120, 80, i)


            Case "210406"
                FillHorCell(80, 74, i)
            Case "210206"
                FillHorCell(88, 74, i)
            Case "210006"
                FillHorCell(96, 74, i)
            Case "210106"
                FillHorCell(104, 74, i)
            Case "210306"
                FillHorCell(112, 74, i)
            Case "210506"
                FillHorCell(120, 74, i)

            Case "230406"
                FillHorCell(80, 69, i)
            Case "230206"
                FillHorCell(88, 69, i)
            Case "230006"
                FillHorCell(96, 69, i)
            Case "230106"
                FillHorCell(104, 69, i)
            Case "230306"
                FillHorCell(112, 69, i)
            Case "230506"
                FillHorCell(120, 69, i)

            Case "250606"
                FillHorCell(72, 63, i)
            Case "250406"
                FillHorCell(80, 63, i)
            Case "250206"
                FillHorCell(88, 63, i)
            Case "250006"
                FillHorCell(96, 63, i)
            Case "250106"
                FillHorCell(104, 63, i)
            Case "250306"
                FillHorCell(112, 63, i)
            Case "250506"
                FillHorCell(120, 63, i)

            Case "270606"
                FillHorCell(72, 58, i)
            Case "270406"
                FillHorCell(80, 58, i)
            Case "270206"
                FillHorCell(88, 58, i)
            Case "270006"
                FillHorCell(96, 58, i)
            Case "270106"
                FillHorCell(104, 58, i)
            Case "270306"
                FillHorCell(112, 58, i)
            Case "270506"
                FillHorCell(120, 58, i)

            Case "290606"
                FillHorCell(72, 52, i)
            Case "290406"
                FillHorCell(80, 52, i)
            Case "290206"
                FillHorCell(88, 52, i)
            Case "290006"
                FillHorCell(96, 52, i)
            Case "290106"
                FillHorCell(104, 52, i)
            Case "290306"
                FillHorCell(112, 52, i)
            Case "290506"
                FillHorCell(120, 52, i)

            Case "310606"
                FillHorCell(72, 47, i)
            Case "310406"
                FillHorCell(80, 47, i)
            Case "310206"
                FillHorCell(88, 47, i)
            Case "310006"
                FillHorCell(96, 47, i)
            Case "310106"
                FillHorCell(104, 47, i)
            Case "310306"
                FillHorCell(112, 47, i)
            Case "310506"
                FillHorCell(120, 47, i)

            Case "330606"
                FillHorCell(72, 41, i)
            Case "330406"
                FillHorCell(80, 41, i)
            Case "330206"
                FillHorCell(88, 41, i)
            Case "330306"
                FillHorCell(112, 41, i)
            Case "330506"
                FillHorCell(120, 41, i)

            Case "350606"
                FillHorCell(72, 36, i)
            Case "350406"
                FillHorCell(80, 36, i)
            Case "350206"
                FillHorCell(88, 36, i)
            Case "350306"
                FillHorCell(112, 36, i)
            Case "350506"
                FillHorCell(120, 36, i)

            Case "370306"
                FillHorCell(112, 30, i)
            Case "370506"
                FillHorCell(120, 30, i)
            Case "390306"
                FillHorCell(112, 25, i)
            Case "390506"
                FillHorCell(120, 25, i)
            Case "410306"
                FillHorCell(112, 19, i)
            Case "430306"
                FillHorCell(112, 14, i)
            Case "450106"
                FillHorCell(104, 8, i)
            Case "470106"
                FillHorCell(104, 3, i)
        End Select
    End Sub
End Class
