Public Class FillImageCell_Falcon   ''��ӥ��ͼ
    Inherits FillImageCell

    '��дORIGINAL��ͼ��Ԫ��
    Public Shared Sub FillOriginalCell(ByVal i As Integer)
        Select Case TongBayNo(c1dbg.Columns("BayNo").CellText(i))
            '''
            '��� MAIN DECK ��1/3/27/29
            '''''
        Case "010182"   '��β����
                FillVerCell(22, 38, i)
            Case "010184"   '��β����
                FillVerCell(22, 40, i)
            Case "010282"   '��β����
                FillVerCell(22, 42, i)
            Case "010284"   '��β����
                FillVerCell(22, 44, i)
            Case "030182"   '��β����
                FillVerCell(11, 38, i)
            Case "030184"   '��β����
                FillVerCell(11, 40, i)
            Case "030282"   '��β����
                FillVerCell(11, 42, i)
            Case "030284"   '��β����
                FillVerCell(11, 44, i)
            Case "270182"   '��β����
                FillVerCell(22, 4, i)
            Case "270184"   '��β����
                FillVerCell(22, 6, i)
            Case "270282"   '��β����
                FillVerCell(22, 8, i)
            Case "270284"   '��β����
                FillVerCell(22, 10, i)
            Case "290182"   '��β����
                FillVerCell(11, 4, i)
            Case "290184"   '��β����
                FillVerCell(11, 6, i)
            Case "290282"   '��β����
                FillVerCell(11, 8, i)
            Case "290284"   '��β����
                FillVerCell(11, 10, i)
                '''
                '��� MAIN DECK ��5
                '''''
            Case "050882"   '�м����
                FillHorCell(8, 35, i)
            Case "050884"   '�м����
                FillHorCell(6, 35, i)

            Case "050684"   '�м����
                FillHorCell(11, 35, i)
            Case "050682"   '�м����
                FillHorCell(13, 35, i)
            Case "050484"   '�м����
                FillHorCell(15, 35, i)
            Case "050482"   '�м����
                FillHorCell(17, 35, i)
            Case "050284"   '�м����
                FillHorCell(19, 35, i)
            Case "050282"   '�м����
                FillHorCell(21, 35, i)
            Case "050184"   '�м����
                FillHorCell(23, 35, i)
            Case "050182"   '�м����
                FillHorCell(25, 35, i)
            Case "050384"   '�м����
                FillHorCell(27, 35, i)
            Case "050382"   '�м����
                FillHorCell(29, 35, i)
            Case "050584"   '�м����
                FillHorCell(31, 35, i)
            Case "050582"   '�м����
                FillHorCell(33, 35, i)

            Case "050782"   '�м����
                FillHorCell(36, 35, i)
            Case "050784"   '�м����
                FillHorCell(38, 35, i)
                '''
                '��� MAIN DECK ��7
                '''''
            Case "070882"   '�м����
                FillHorCell(8, 32, i)
            Case "070884"   '�м����
                FillHorCell(6, 32, i)

            Case "070684"   '�м����
                FillHorCell(11, 32, i)
            Case "070682"   '�м����
                FillHorCell(13, 32, i)
            Case "070484"   '�м����
                FillHorCell(15, 32, i)
            Case "070482"   '�м����
                FillHorCell(17, 32, i)
            Case "070284"   '�м����
                FillHorCell(19, 32, i)
            Case "070282"   '�м����
                FillHorCell(21, 32, i)
            Case "070184"   '�м����
                FillHorCell(23, 32, i)
            Case "070182"   '�м����
                FillHorCell(25, 32, i)
            Case "070384"   '�м����
                FillHorCell(27, 32, i)
            Case "070382"   '�м����
                FillHorCell(29, 32, i)
            Case "070584"   '�м����
                FillHorCell(31, 32, i)
            Case "070582"   '�м����
                FillHorCell(33, 32, i)

            Case "070782"   '�м����
                FillHorCell(36, 32, i)
            Case "070784"   '�м����
                FillHorCell(38, 32, i)
                '''
                '��� MAIN DECK ��9
                '''''
            Case "090882"   '�м����
                FillHorCell(8, 30, i)
            Case "090884"   '�м����
                FillHorCell(6, 30, i)

            Case "090684"   '�м����
                FillHorCell(11, 30, i)
            Case "090682"   '�м����
                FillHorCell(13, 30, i)
            Case "090484"   '�м����
                FillHorCell(15, 30, i)
            Case "090482"   '�м����
                FillHorCell(17, 30, i)
            Case "090284"   '�м����
                FillHorCell(19, 30, i)
            Case "090282"   '�м����
                FillHorCell(21, 30, i)
            Case "090184"   '�м����
                FillHorCell(23, 30, i)
            Case "090182"   '�м����
                FillHorCell(25, 30, i)
            Case "090384"   '�м����
                FillHorCell(27, 30, i)
            Case "090382"   '�м����
                FillHorCell(29, 30, i)
            Case "090584"   '�м����
                FillHorCell(31, 30, i)
            Case "090582"   '�м����
                FillHorCell(33, 30, i)

            Case "090782"   '�м����
                FillHorCell(36, 30, i)
            Case "090784"   '�м����
                FillHorCell(38, 30, i)
                '''
                '��� MAIN DECK ��11
                '''''
            Case "110882"   '�м����
                FillHorCell(8, 28, i)
            Case "110884"   '�м����
                FillHorCell(6, 28, i)

            Case "110782"   '�м����
                FillHorCell(36, 28, i)
            Case "110784"   '�м����
                FillHorCell(38, 28, i)
                '''
                '��� MAIN DECK ��13
                '''''
            Case "130882"   '�м����
                FillHorCell(8, 26, i)
            Case "130884"   '�м����
                FillHorCell(6, 26, i)

            Case "130782"   '�м����
                FillHorCell(36, 26, i)
            Case "130784"   '�м����
                FillHorCell(38, 26, i)
                '''
                '��� MAIN DECK ��15
                '''''
            Case "150882"   '�м����
                FillHorCell(8, 24, i)
            Case "150884"   '�м����
                FillHorCell(6, 24, i)

            Case "150684"   '�м����
                FillHorCell(11, 24, i)
            Case "150682"   '�м����
                FillHorCell(13, 24, i)
            Case "150484"   '�м����
                FillHorCell(15, 24, i)
            Case "150482"   '�м����
                FillHorCell(17, 24, i)
            Case "150284"   '�м����
                FillHorCell(19, 24, i)
            Case "150282"   '�м����
                FillHorCell(21, 24, i)
            Case "150184"   '�м����
                FillHorCell(23, 24, i)
            Case "150182"   '�м����
                FillHorCell(25, 24, i)
            Case "150384"   '�м����
                FillHorCell(27, 24, i)
            Case "150382"   '�м����
                FillHorCell(29, 24, i)
            Case "150584"   '�м����
                FillHorCell(31, 24, i)
            Case "150582"   '�м����
                FillHorCell(33, 24, i)

            Case "150782"   '�м����
                FillHorCell(36, 24, i)
            Case "150784"   '�м����
                FillHorCell(38, 24, i)
                '''
                '��� MAIN DECK ��17
                '''''
            Case "170882"   '�м����
                FillHorCell(8, 22, i)
            Case "170884"   '�м����
                FillHorCell(6, 22, i)

            Case "170684"   '�м����
                FillHorCell(11, 22, i)
            Case "170682"   '�м����
                FillHorCell(13, 22, i)
            Case "170484"   '�м����
                FillHorCell(15, 22, i)
            Case "170482"   '�м����
                FillHorCell(17, 22, i)
            Case "170284"   '�м����
                FillHorCell(19, 22, i)
            Case "170282"   '�м����
                FillHorCell(21, 22, i)
            Case "170184"   '�м����
                FillHorCell(23, 22, i)
            Case "170182"   '�м����
                FillHorCell(25, 22, i)
            Case "170384"   '�м����
                FillHorCell(27, 22, i)
            Case "170382"   '�м����
                FillHorCell(29, 22, i)
            Case "170584"   '�м����
                FillHorCell(31, 22, i)
            Case "170582"   '�м����
                FillHorCell(33, 22, i)

            Case "170782"   '�м����
                FillHorCell(36, 22, i)
            Case "170784"   '�м����
                FillHorCell(38, 22, i)
                '''
                '��� MAIN DECK ��19
                '''''
            Case "190882"   '�м����
                FillHorCell(8, 20, i)
            Case "190884"   '�м����
                FillHorCell(6, 20, i)

            Case "190684"   '�м����
                FillHorCell(11, 20, i)
            Case "190682"   '�м����
                FillHorCell(13, 20, i)
            Case "190484"   '�м����
                FillHorCell(15, 20, i)
            Case "190482"   '�м����
                FillHorCell(17, 20, i)
            Case "190284"   '�м����
                FillHorCell(19, 20, i)
            Case "190282"   '�м����
                FillHorCell(21, 20, i)
            Case "190184"   '�м����
                FillHorCell(23, 20, i)
            Case "190182"   '�м����
                FillHorCell(25, 20, i)
            Case "190384"   '�м����
                FillHorCell(27, 20, i)
            Case "190382"   '�м����
                FillHorCell(29, 20, i)
            Case "190584"   '�м����
                FillHorCell(31, 20, i)
            Case "190582"   '�м����
                FillHorCell(33, 20, i)

            Case "190782"   '�м����
                FillHorCell(36, 20, i)
            Case "190784"   '�м����
                FillHorCell(38, 20, i)
                '''
                '��� MAIN DECK ��21
                '''''
            Case "210684"   '�м����
                FillHorCell(11, 17, i)
            Case "210682"   '�м����
                FillHorCell(13, 17, i)
            Case "210484"   '�м����
                FillHorCell(15, 17, i)
            Case "210482"   '�м����
                FillHorCell(17, 17, i)
            Case "210284"   '�м����
                FillHorCell(19, 17, i)
            Case "210282"   '�м����
                FillHorCell(21, 17, i)
            Case "210184"   '�м����
                FillHorCell(23, 17, i)
            Case "210182"   '�м����
                FillHorCell(25, 17, i)
            Case "210384"   '�м����
                FillHorCell(27, 17, i)
            Case "210382"   '�м����
                FillHorCell(29, 17, i)
            Case "210584"   '�м����
                FillHorCell(31, 17, i)
            Case "210582"   '�м����
                FillHorCell(33, 17, i)
                '''
                '��� MAIN DECK ��23
                '''''
            Case "230882"   '�м����
                FillHorCell(8, 15, i)
            Case "230884"   '�м����
                FillHorCell(6, 15, i)

            Case "230684"   '�м����
                FillHorCell(11, 15, i)
            Case "230682"   '�м����
                FillHorCell(13, 15, i)
            Case "230484"   '�м����
                FillHorCell(15, 15, i)
            Case "230482"   '�м����
                FillHorCell(17, 15, i)
            Case "230284"   '�м����
                FillHorCell(19, 15, i)
            Case "230282"   '�м����
                FillHorCell(21, 15, i)
            Case "230184"   '�м����
                FillHorCell(23, 15, i)
            Case "230182"   '�м����
                FillHorCell(25, 15, i)
            Case "230384"   '�м����
                FillHorCell(27, 15, i)
            Case "230382"   '�м����
                FillHorCell(29, 15, i)
            Case "230584"   '�м����
                FillHorCell(31, 15, i)
            Case "230582"   '�м����
                FillHorCell(33, 15, i)

            Case "230782"   '�м����
                FillHorCell(36, 15, i)
            Case "230784"   '�м����
                FillHorCell(38, 15, i)
                '''
                '��� MAIN DECK ��25
                '''''
            Case "250882"   '�м����
                FillHorCell(8, 13, i)
            Case "250884"   '�м����
                FillHorCell(6, 13, i)

            Case "250684"   '�м����
                FillHorCell(11, 13, i)
            Case "250682"   '�м����
                FillHorCell(13, 13, i)
            Case "250484"   '�м����
                FillHorCell(15, 13, i)
            Case "250482"   '�м����
                FillHorCell(17, 13, i)
            Case "250284"   '�м����
                FillHorCell(19, 13, i)
            Case "250282"   '�м����
                FillHorCell(21, 13, i)
            Case "250184"   '�м����
                FillHorCell(23, 13, i)
            Case "250182"   '�м����
                FillHorCell(25, 13, i)
            Case "250384"   '�м����
                FillHorCell(27, 13, i)
            Case "250382"   '�м����
                FillHorCell(29, 13, i)
            Case "250584"   '�м����
                FillHorCell(31, 13, i)
            Case "250582"   '�м����
                FillHorCell(33, 13, i)

            Case "250782"   '�м����
                FillHorCell(36, 13, i)
            Case "250784"   '�м����
                FillHorCell(38, 13, i)

                '''
                '��� CAR DECK ��5
                '''''
            Case "050410"   '�м����
                FillHorCell(42, 35, i)
            Case "050210"   '�м����
                FillHorCell(44, 35, i)
            Case "050010"   '�м����
                FillHorCell(46, 35, i)
            Case "050110"   '�м����
                FillHorCell(48, 35, i)
            Case "050310"   '�м����
                FillHorCell(50, 35, i)
                '''
                '��� CAR DECK ��7
                '''''
            Case "070410"   '�м����
                FillHorCell(42, 32, i)
            Case "070210"   '�м����
                FillHorCell(44, 32, i)
            Case "070010"   '�м����
                FillHorCell(46, 32, i)
            Case "070110"   '�м����
                FillHorCell(48, 32, i)
            Case "070310"   '�м����
                FillHorCell(50, 32, i)
                '''
                '��� CAR DECK ��9
                '''''
            Case "090410"   '�м����
                FillHorCell(42, 30, i)
            Case "090210"   '�м����
                FillHorCell(44, 30, i)
            Case "090010"   '�м����
                FillHorCell(46, 30, i)
            Case "090110"   '�м����
                FillHorCell(48, 30, i)
            Case "090310"   '�м����
                FillHorCell(50, 30, i)

                '''
                '��� CAR DECK ��15
                '''''
            Case "150410"   '�м����
                FillHorCell(42, 24, i)
            Case "150210"   '�м����
                FillHorCell(44, 24, i)
            Case "150010"   '�м����
                FillHorCell(46, 24, i)
            Case "150110"   '�м����
                FillHorCell(48, 24, i)
            Case "150310"   '�м����
                FillHorCell(50, 24, i)
                '''
                '��� CAR DECK ��17
                '''''
            Case "170410"   '�м����
                FillHorCell(42, 22, i)
            Case "170210"   '�м����
                FillHorCell(44, 22, i)
            Case "170010"   '�м����
                FillHorCell(46, 22, i)
            Case "170110"   '�м����
                FillHorCell(48, 22, i)
            Case "170310"   '�м����
                FillHorCell(50, 22, i)
                '''
                '��� CAR DECK ��19
                '''''
            Case "190410"   '�м����
                FillHorCell(42, 20, i)
            Case "190210"   '�м����
                FillHorCell(44, 20, i)
            Case "190010"   '�м����
                FillHorCell(46, 20, i)
            Case "190110"   '�м����
                FillHorCell(48, 20, i)
            Case "190310"   '�м����
                FillHorCell(50, 20, i)
                '''
                '��� CAR DECK ��21
                '''''
            Case "210410"   '�м����
                FillHorCell(42, 17, i)
            Case "210210"   '�м����
                FillHorCell(44, 17, i)
            Case "210010"   '�м����
                FillHorCell(46, 17, i)
            Case "210110"   '�м����
                FillHorCell(48, 17, i)
            Case "210310"   '�м����
                FillHorCell(50, 17, i)
                '''
                '��� CAR DECK ��23
                '''''
            Case "230410"   '�м����
                FillHorCell(42, 15, i)
            Case "230210"   '�м����
                FillHorCell(44, 15, i)
            Case "230010"   '�м����
                FillHorCell(46, 15, i)
            Case "230110"   '�м����
                FillHorCell(48, 15, i)
            Case "230310"   '�м����
                FillHorCell(50, 15, i)
                '''
                '��� CAR DECK ��25
                '''''
            Case "250410"   '�м����
                FillHorCell(42, 13, i)
            Case "250210"   '�м����
                FillHorCell(44, 13, i)
            Case "250010"   '�м����
                FillHorCell(46, 13, i)
            Case "250110"   '�м����
                FillHorCell(48, 13, i)
            Case "250310"   '�м����
                FillHorCell(50, 13, i)

                '''
                '��� FREEBOARD DECK ��5
                '''''
            Case "050408"   '�м����
                FillHorCell(54, 35, i)
            Case "050406"   '�м����
                FillHorCell(56, 35, i)
            Case "050208"   '�м����
                FillHorCell(58, 35, i)
            Case "050206"   '�м����
                FillHorCell(60, 35, i)
            Case "050008"   '�м����
                FillHorCell(62, 35, i)
            Case "050006"   '�м����
                FillHorCell(64, 35, i)
            Case "050108"   '�м����
                FillHorCell(66, 35, i)
            Case "050106"   '�м����
                FillHorCell(68, 35, i)
            Case "050308"   '�м����
                FillHorCell(70, 35, i)
            Case "050306"   '�м����
                FillHorCell(72, 35, i)
                '''
                '��� FREEBOARD DECK ��7
                '''''
            Case "070408"   '�м����
                FillHorCell(54, 32, i)
            Case "070406"   '�м����
                FillHorCell(56, 32, i)
            Case "070208"   '�м����
                FillHorCell(58, 32, i)
            Case "070206"   '�м����
                FillHorCell(60, 32, i)
            Case "070008"   '�м����
                FillHorCell(62, 32, i)
            Case "070006"   '�м����
                FillHorCell(64, 32, i)
            Case "070108"   '�м����
                FillHorCell(66, 32, i)
            Case "070106"   '�м����
                FillHorCell(68, 32, i)
            Case "070308"   '�м����
                FillHorCell(70, 32, i)
            Case "070306"   '�м����
                FillHorCell(72, 32, i)
                '''
                '��� FREEBOARD DECK ��9
                '''''
            Case "090408"   '�м����
                FillHorCell(54, 30, i)
            Case "090406"   '�м����
                FillHorCell(56, 30, i)
            Case "090208"   '�м����
                FillHorCell(58, 30, i)
            Case "090206"   '�м����
                FillHorCell(60, 30, i)
            Case "090008"   '�м����
                FillHorCell(62, 30, i)
            Case "090006"   '�м����
                FillHorCell(64, 30, i)
            Case "090108"   '�м����
                FillHorCell(66, 30, i)
            Case "090106"   '�м����
                FillHorCell(68, 30, i)
            Case "090308"   '�м����
                FillHorCell(70, 30, i)
            Case "090306"   '�м����
                FillHorCell(72, 30, i)
                '''
                '��� FREEBOARD DECK ��15
                '''''
            Case "150408"   '�м����
                FillHorCell(54, 24, i)
            Case "150406"   '�м����
                FillHorCell(56, 24, i)
            Case "150208"   '�м����
                FillHorCell(58, 24, i)
            Case "150206"   '�м����
                FillHorCell(60, 24, i)
            Case "150008"   '�м����
                FillHorCell(62, 24, i)
            Case "150006"   '�м����
                FillHorCell(64, 24, i)
            Case "150108"   '�м����
                FillHorCell(66, 24, i)
            Case "150106"   '�м����
                FillHorCell(68, 24, i)
            Case "150308"   '�м����
                FillHorCell(70, 24, i)
            Case "150306"   '�м����
                FillHorCell(72, 24, i)
                '''
                '��� FREEBOARD DECK ��17
                '''''
            Case "170408"   '�м����
                FillHorCell(54, 22, i)
            Case "170406"   '�м����
                FillHorCell(56, 22, i)
            Case "170208"   '�м����
                FillHorCell(58, 22, i)
            Case "170206"   '�м����
                FillHorCell(60, 22, i)
            Case "170008"   '�м����
                FillHorCell(62, 22, i)
            Case "170006"   '�м����
                FillHorCell(64, 22, i)
            Case "170108"   '�м����
                FillHorCell(66, 22, i)
            Case "170106"   '�м����
                FillHorCell(68, 22, i)
            Case "170308"   '�м����
                FillHorCell(70, 22, i)
            Case "170306"   '�м����
                FillHorCell(72, 22, i)
                '''
                '��� FREEBOARD DECK ��19
                '''''
            Case "190408"   '�м����
                FillHorCell(54, 20, i)
            Case "190406"   '�м����
                FillHorCell(56, 20, i)
            Case "190208"   '�м����
                FillHorCell(58, 20, i)
            Case "190206"   '�м����
                FillHorCell(60, 20, i)
            Case "090008"   '�м����
                FillHorCell(62, 20, i)
            Case "190006"   '�м����
                FillHorCell(64, 20, i)
            Case "190108"   '�м����
                FillHorCell(66, 20, i)
            Case "190106"   '�м����
                FillHorCell(68, 20, i)
            Case "190308"   '�м����
                FillHorCell(70, 20, i)
            Case "190306"   '�м����
                FillHorCell(72, 20, i)
                '''
                '��� FREEBOARD DECK ��21
                '''''
            Case "210408"   '�м����
                FillHorCell(54, 17, i)
            Case "210406"   '�м����
                FillHorCell(56, 17, i)
            Case "210208"   '�м����
                FillHorCell(58, 17, i)
            Case "210206"   '�м����
                FillHorCell(60, 17, i)
            Case "210008"   '�м����
                FillHorCell(62, 17, i)
            Case "210006"   '�м����
                FillHorCell(64, 17, i)
            Case "210108"   '�м����
                FillHorCell(66, 17, i)
            Case "210106"   '�м����
                FillHorCell(68, 17, i)
            Case "210308"   '�м����
                FillHorCell(70, 17, i)
            Case "210306"   '�м����
                FillHorCell(72, 17, i)
                '''
                '��� FREEBOARD DECK ��23
                '''''
            Case "230408"   '�м����
                FillHorCell(54, 15, i)
            Case "230406"   '�м����
                FillHorCell(56, 15, i)
            Case "230208"   '�м����
                FillHorCell(58, 15, i)
            Case "230206"   '�м����
                FillHorCell(60, 15, i)
            Case "070008"   '�м����
                FillHorCell(62, 15, i)
            Case "230006"   '�м����
                FillHorCell(64, 15, i)
            Case "230108"   '�м����
                FillHorCell(66, 15, i)
            Case "230106"   '�м����
                FillHorCell(68, 15, i)
            Case "230308"   '�м����
                FillHorCell(70, 15, i)
            Case "230306"   '�м����
                FillHorCell(72, 15, i)
                '''
                '��� FREEBOARD DECK ��25
                '''''
            Case "250408"   '�м����
                FillHorCell(54, 13, i)
            Case "250406"   '�м����
                FillHorCell(56, 13, i)
            Case "250208"   '�м����
                FillHorCell(58, 13, i)
            Case "250206"   '�м����
                FillHorCell(60, 13, i)
            Case "250008"   '�м����
                FillHorCell(62, 13, i)
            Case "250006"   '�м����
                FillHorCell(64, 13, i)
            Case "250108"   '�м����
                FillHorCell(66, 13, i)
            Case "250106"   '�м����
                FillHorCell(68, 13, i)
            Case "250308"   '�м����
                FillHorCell(70, 13, i)
            Case "250306"   '�м����
                FillHorCell(72, 13, i)

                '''
                '��� LOWER DECK ��5
                '''''
            Case "050404"   '�м����
                FillHorCell(76, 35, i)
            Case "050402"   '�м����
                FillHorCell(78, 35, i)
            Case "050204"   '�м����
                FillHorCell(80, 35, i)
            Case "050202"   '�м����
                FillHorCell(82, 35, i)
            Case "050004"   '�м����
                FillHorCell(84, 35, i)
            Case "050002"   '�м����
                FillHorCell(86, 35, i)
            Case "050104"   '�м����
                FillHorCell(88, 35, i)
            Case "050102"   '�м����
                FillHorCell(90, 35, i)
            Case "050304"   '�м����
                FillHorCell(92, 35, i)
            Case "050302"   '�м����
                FillHorCell(94, 35, i)
                '''
                '��� LOWER DECK ��7
                '''''
            Case "070404"   '�м����
                FillHorCell(76, 32, i)
            Case "070402"   '�м����
                FillHorCell(78, 32, i)
            Case "070204"   '�м����
                FillHorCell(80, 32, i)
            Case "070202"   '�м����
                FillHorCell(82, 32, i)
            Case "070004"   '�м����
                FillHorCell(84, 32, i)
            Case "070002"   '�м����
                FillHorCell(86, 32, i)
            Case "070104"   '�м����
                FillHorCell(88, 32, i)
            Case "070102"   '�м����
                FillHorCell(90, 32, i)
            Case "070304"   '�м����
                FillHorCell(92, 32, i)
            Case "070302"   '�м����
                FillHorCell(94, 32, i)
                '''
                '��� LOWER DECK ��9
                '''''
            Case "090404"   '�м����
                FillHorCell(76, 30, i)
            Case "090402"   '�м����
                FillHorCell(78, 30, i)
            Case "090204"   '�м����
                FillHorCell(80, 30, i)
            Case "090202"   '�м����
                FillHorCell(82, 30, i)
            Case "090004"   '�м����
                FillHorCell(84, 30, i)
            Case "090002"   '�м����
                FillHorCell(86, 30, i)
            Case "090104"   '�м����
                FillHorCell(88, 30, i)
            Case "090102"   '�м����
                FillHorCell(90, 30, i)
            Case "090304"   '�м����
                FillHorCell(92, 30, i)
            Case "090302"   '�м����
                FillHorCell(94, 30, i)
                '''
                '��� LOWER DECK ��15
                '''''
            Case "150404"   '�м����
                FillHorCell(76, 24, i)
            Case "150402"   '�м����
                FillHorCell(78, 24, i)
            Case "150204"   '�м����
                FillHorCell(80, 24, i)
            Case "150202"   '�м����
                FillHorCell(82, 24, i)
            Case "150004"   '�м����
                FillHorCell(84, 24, i)
            Case "150002"   '�м����
                FillHorCell(86, 24, i)
            Case "150104"   '�м����
                FillHorCell(88, 24, i)
            Case "150102"   '�м����
                FillHorCell(90, 24, i)
            Case "150304"   '�м����
                FillHorCell(92, 24, i)
            Case "150302"   '�м����
                FillHorCell(94, 24, i)
                '''
                '��� LOWER DECK ��17
                '''''
            Case "170404"   '�м����
                FillHorCell(76, 22, i)
            Case "170402"   '�м����
                FillHorCell(78, 22, i)
            Case "170204"   '�м����
                FillHorCell(80, 22, i)
            Case "170202"   '�м����
                FillHorCell(82, 22, i)
            Case "170004"   '�м����
                FillHorCell(84, 22, i)
            Case "170002"   '�м����
                FillHorCell(86, 22, i)
            Case "170104"   '�м����
                FillHorCell(88, 22, i)
            Case "170102"   '�м����
                FillHorCell(90, 22, i)
            Case "170304"   '�м����
                FillHorCell(92, 22, i)
            Case "170302"   '�м����
                FillHorCell(94, 22, i)
                '''
                '��� LOWER DECK ��19
                '''''
            Case "190404"   '�м����
                FillHorCell(76, 20, i)
            Case "190402"   '�м����
                FillHorCell(78, 20, i)
            Case "190204"   '�м����
                FillHorCell(80, 20, i)
            Case "190202"   '�м����
                FillHorCell(82, 20, i)
            Case "190004"   '�м����
                FillHorCell(84, 20, i)
            Case "190002"   '�м����
                FillHorCell(86, 20, i)
            Case "190104"   '�м����
                FillHorCell(88, 20, i)
            Case "190102"   '�м����
                FillHorCell(90, 20, i)
            Case "190304"   '�м����
                FillHorCell(92, 20, i)
            Case "190302"   '�м����
                FillHorCell(94, 20, i)
                '''
                '��� LOWER DECK ��21
                '''''
            Case "210404"   '�м����
                FillHorCell(76, 17, i)
            Case "210402"   '�м����
                FillHorCell(78, 17, i)
            Case "210204"   '�м����
                FillHorCell(80, 17, i)
            Case "210202"   '�м����
                FillHorCell(82, 17, i)
            Case "210004"   '�м����
                FillHorCell(84, 17, i)
            Case "210002"   '�м����
                FillHorCell(86, 17, i)
            Case "210104"   '�м����
                FillHorCell(88, 17, i)
            Case "210102"   '�м����
                FillHorCell(90, 17, i)
            Case "210304"   '�м����
                FillHorCell(92, 17, i)
            Case "210302"   '�м����
                FillHorCell(94, 17, i)
                '''
                '��� LOWER DECK ��23
                '''''
            Case "230404"   '�м����
                FillHorCell(76, 15, i)
            Case "230402"   '�м����
                FillHorCell(78, 15, i)
            Case "230204"   '�м����
                FillHorCell(80, 15, i)
            Case "230202"   '�м����
                FillHorCell(82, 15, i)
            Case "230004"   '�м����
                FillHorCell(84, 15, i)
            Case "230002"   '�м����
                FillHorCell(86, 15, i)
            Case "230104"   '�м����
                FillHorCell(88, 15, i)
            Case "230102"   '�м����
                FillHorCell(90, 15, i)
            Case "230304"   '�м����
                FillHorCell(92, 15, i)
            Case "230302"   '�м����
                FillHorCell(94, 15, i)
                '''
                '��� LOWER DECK ��25
                '''''
            Case "250404"   '�м����
                FillHorCell(76, 13, i)
            Case "250402"   '�м����
                FillHorCell(78, 13, i)
            Case "250204"   '�м����
                FillHorCell(80, 13, i)
            Case "250202"   '�м����
                FillHorCell(82, 13, i)
            Case "250004"   '�м����
                FillHorCell(84, 13, i)
            Case "250002"   '�м����
                FillHorCell(86, 13, i)
            Case "250104"   '�м����
                FillHorCell(88, 13, i)
            Case "250102"   '�м����
                FillHorCell(90, 13, i)
            Case "250304"   '�м����
                FillHorCell(92, 13, i)
            Case "250302"   '�м����
                FillHorCell(94, 13, i)

        End Select
    End Sub

    '��дMainDeck��ͼ��Ԫ��
    Public Shared Sub FillMainDeckCell(ByVal i As Integer)
        Select Case TongBayNo(c1dbg.Columns("BayNo").CellText(i))
            '''
            '��� MAIN DECK ��1/3/27/29
            '''''
        Case "010182"   '��β����
                FillVerCell(22, 38, i)
            Case "010184"   '��β����
                FillVerCell(22, 40, i)
            Case "010282"   '��β����
                FillVerCell(22, 42, i)
            Case "010284"   '��β����
                FillVerCell(22, 44, i)
            Case "030182"   '��β����
                FillVerCell(11, 38, i)
            Case "030184"   '��β����
                FillVerCell(11, 40, i)
            Case "030282"   '��β����
                FillVerCell(11, 42, i)
            Case "030284"   '��β����
                FillVerCell(11, 44, i)
            Case "270182"   '��β����
                FillVerCell(22, 4, i)
            Case "270184"   '��β����
                FillVerCell(22, 6, i)
            Case "270282"   '��β����
                FillVerCell(22, 8, i)
            Case "270284"   '��β����
                FillVerCell(22, 10, i)
            Case "290182"   '��β����
                FillVerCell(11, 4, i)
            Case "290184"   '��β����
                FillVerCell(11, 6, i)
            Case "290282"   '��β����
                FillVerCell(11, 8, i)
            Case "290284"   '��β����
                FillVerCell(11, 10, i)
                '''
                '��� MAIN DECK ��5
                '''''
            Case "050882"   '�м����
                FillHorCell(8, 35, i)
            Case "050884"   '�м����
                FillHorCell(6, 35, i)

            Case "050684"   '�м����
                FillHorCell(11, 35, i)
            Case "050682"   '�м����
                FillHorCell(13, 35, i)
            Case "050484"   '�м����
                FillHorCell(15, 35, i)
            Case "050482"   '�м����
                FillHorCell(17, 35, i)
            Case "050284"   '�м����
                FillHorCell(19, 35, i)
            Case "050282"   '�м����
                FillHorCell(21, 35, i)
            Case "050184"   '�м����
                FillHorCell(23, 35, i)
            Case "050182"   '�м����
                FillHorCell(25, 35, i)
            Case "050384"   '�м����
                FillHorCell(27, 35, i)
            Case "050382"   '�м����
                FillHorCell(29, 35, i)
            Case "050584"   '�м����
                FillHorCell(31, 35, i)
            Case "050582"   '�м����
                FillHorCell(33, 35, i)

            Case "050782"   '�м����
                FillHorCell(36, 35, i)
            Case "050784"   '�м����
                FillHorCell(38, 35, i)
                '''
                '��� MAIN DECK ��7
                '''''
            Case "070882"   '�м����
                FillHorCell(8, 32, i)
            Case "070884"   '�м����
                FillHorCell(6, 32, i)

            Case "070684"   '�м����
                FillHorCell(11, 32, i)
            Case "070682"   '�м����
                FillHorCell(13, 32, i)
            Case "070484"   '�м����
                FillHorCell(15, 32, i)
            Case "070482"   '�м����
                FillHorCell(17, 32, i)
            Case "070284"   '�м����
                FillHorCell(19, 32, i)
            Case "070282"   '�м����
                FillHorCell(21, 32, i)
            Case "070184"   '�м����
                FillHorCell(23, 32, i)
            Case "070182"   '�м����
                FillHorCell(25, 32, i)
            Case "070384"   '�м����
                FillHorCell(27, 32, i)
            Case "070382"   '�м����
                FillHorCell(29, 32, i)
            Case "070584"   '�м����
                FillHorCell(31, 32, i)
            Case "070582"   '�м����
                FillHorCell(33, 32, i)

            Case "070782"   '�м����
                FillHorCell(36, 32, i)
            Case "070784"   '�м����
                FillHorCell(38, 32, i)
                '''
                '��� MAIN DECK ��9
                '''''
            Case "090882"   '�м����
                FillHorCell(8, 30, i)
            Case "090884"   '�м����
                FillHorCell(6, 30, i)

            Case "090684"   '�м����
                FillHorCell(11, 30, i)
            Case "090682"   '�м����
                FillHorCell(13, 30, i)
            Case "090484"   '�м����
                FillHorCell(15, 30, i)
            Case "090482"   '�м����
                FillHorCell(17, 30, i)
            Case "090284"   '�м����
                FillHorCell(19, 30, i)
            Case "090282"   '�м����
                FillHorCell(21, 30, i)
            Case "090184"   '�м����
                FillHorCell(23, 30, i)
            Case "090182"   '�м����
                FillHorCell(25, 30, i)
            Case "090384"   '�м����
                FillHorCell(27, 30, i)
            Case "090382"   '�м����
                FillHorCell(29, 30, i)
            Case "090584"   '�м����
                FillHorCell(31, 30, i)
            Case "090582"   '�м����
                FillHorCell(33, 30, i)

            Case "090782"   '�м����
                FillHorCell(36, 30, i)
            Case "090784"   '�м����
                FillHorCell(38, 30, i)
                '''
                '��� MAIN DECK ��11
                '''''
            Case "110882"   '�м����
                FillHorCell(8, 28, i)
            Case "110884"   '�м����
                FillHorCell(6, 28, i)

            Case "110782"   '�м����
                FillHorCell(36, 28, i)
            Case "110784"   '�м����
                FillHorCell(38, 28, i)
                '''
                '��� MAIN DECK ��13
                '''''
            Case "130882"   '�м����
                FillHorCell(8, 26, i)
            Case "130884"   '�м����
                FillHorCell(6, 26, i)

            Case "130782"   '�м����
                FillHorCell(36, 26, i)
            Case "130784"   '�м����
                FillHorCell(38, 26, i)
                '''
                '��� MAIN DECK ��15
                '''''
            Case "150882"   '�м����
                FillHorCell(8, 24, i)
            Case "150884"   '�м����
                FillHorCell(6, 24, i)

            Case "150684"   '�м����
                FillHorCell(11, 24, i)
            Case "150682"   '�м����
                FillHorCell(13, 24, i)
            Case "150484"   '�м����
                FillHorCell(15, 24, i)
            Case "150482"   '�м����
                FillHorCell(17, 24, i)
            Case "150284"   '�м����
                FillHorCell(19, 24, i)
            Case "150282"   '�м����
                FillHorCell(21, 24, i)
            Case "150184"   '�м����
                FillHorCell(23, 24, i)
            Case "150182"   '�м����
                FillHorCell(25, 24, i)
            Case "150384"   '�м����
                FillHorCell(27, 24, i)
            Case "150382"   '�м����
                FillHorCell(29, 24, i)
            Case "150584"   '�м����
                FillHorCell(31, 24, i)
            Case "150582"   '�м����
                FillHorCell(33, 24, i)

            Case "150782"   '�м����
                FillHorCell(36, 24, i)
            Case "150784"   '�м����
                FillHorCell(38, 24, i)
                '''
                '��� MAIN DECK ��17
                '''''
            Case "170882"   '�м����
                FillHorCell(8, 22, i)
            Case "170884"   '�м����
                FillHorCell(6, 22, i)

            Case "170684"   '�м����
                FillHorCell(11, 22, i)
            Case "170682"   '�м����
                FillHorCell(13, 22, i)
            Case "170484"   '�м����
                FillHorCell(15, 22, i)
            Case "170482"   '�м����
                FillHorCell(17, 22, i)
            Case "170284"   '�м����
                FillHorCell(19, 22, i)
            Case "170282"   '�м����
                FillHorCell(21, 22, i)
            Case "170184"   '�м����
                FillHorCell(23, 22, i)
            Case "170182"   '�м����
                FillHorCell(25, 22, i)
            Case "170384"   '�м����
                FillHorCell(27, 22, i)
            Case "170382"   '�м����
                FillHorCell(29, 22, i)
            Case "170584"   '�м����
                FillHorCell(31, 22, i)
            Case "170582"   '�м����
                FillHorCell(33, 22, i)

            Case "170782"   '�м����
                FillHorCell(36, 22, i)
            Case "170784"   '�м����
                FillHorCell(38, 22, i)
                '''
                '��� MAIN DECK ��19
                '''''
            Case "190882"   '�м����
                FillHorCell(8, 20, i)
            Case "190884"   '�м����
                FillHorCell(6, 20, i)

            Case "190684"   '�м����
                FillHorCell(11, 20, i)
            Case "190682"   '�м����
                FillHorCell(13, 20, i)
            Case "190484"   '�м����
                FillHorCell(15, 20, i)
            Case "190482"   '�м����
                FillHorCell(17, 20, i)
            Case "190284"   '�м����
                FillHorCell(19, 20, i)
            Case "190282"   '�м����
                FillHorCell(21, 20, i)
            Case "190184"   '�м����
                FillHorCell(23, 20, i)
            Case "190182"   '�м����
                FillHorCell(25, 20, i)
            Case "190384"   '�м����
                FillHorCell(27, 20, i)
            Case "190382"   '�м����
                FillHorCell(29, 20, i)
            Case "190584"   '�м����
                FillHorCell(31, 20, i)
            Case "190582"   '�м����
                FillHorCell(33, 20, i)

            Case "190782"   '�м����
                FillHorCell(36, 20, i)
            Case "190784"   '�м����
                FillHorCell(38, 20, i)
                '''
                '��� MAIN DECK ��21
                '''''
            Case "210684"   '�м����
                FillHorCell(11, 17, i)
            Case "210682"   '�м����
                FillHorCell(13, 17, i)
            Case "210484"   '�м����
                FillHorCell(15, 17, i)
            Case "210482"   '�м����
                FillHorCell(17, 17, i)
            Case "210284"   '�м����
                FillHorCell(19, 17, i)
            Case "210282"   '�м����
                FillHorCell(21, 17, i)
            Case "210184"   '�м����
                FillHorCell(23, 17, i)
            Case "210182"   '�м����
                FillHorCell(25, 17, i)
            Case "210384"   '�м����
                FillHorCell(27, 17, i)
            Case "210382"   '�м����
                FillHorCell(29, 17, i)
            Case "210584"   '�м����
                FillHorCell(31, 17, i)
            Case "210582"   '�м����
                FillHorCell(33, 17, i)
                '''
                '��� MAIN DECK ��23
                '''''
            Case "230882"   '�м����
                FillHorCell(8, 15, i)
            Case "230884"   '�м����
                FillHorCell(6, 15, i)

            Case "230684"   '�м����
                FillHorCell(11, 15, i)
            Case "230682"   '�м����
                FillHorCell(13, 15, i)
            Case "230484"   '�м����
                FillHorCell(15, 15, i)
            Case "230482"   '�м����
                FillHorCell(17, 15, i)
            Case "230284"   '�м����
                FillHorCell(19, 15, i)
            Case "230282"   '�м����
                FillHorCell(21, 15, i)
            Case "230184"   '�м����
                FillHorCell(23, 15, i)
            Case "230182"   '�м����
                FillHorCell(25, 15, i)
            Case "230384"   '�м����
                FillHorCell(27, 15, i)
            Case "230382"   '�м����
                FillHorCell(29, 15, i)
            Case "230584"   '�м����
                FillHorCell(31, 15, i)
            Case "230582"   '�м����
                FillHorCell(33, 15, i)

            Case "230782"   '�м����
                FillHorCell(36, 15, i)
            Case "230784"   '�м����
                FillHorCell(38, 15, i)
                '''
                '��� MAIN DECK ��25
                '''''
            Case "250882"   '�м����
                FillHorCell(8, 13, i)
            Case "250884"   '�м����
                FillHorCell(6, 13, i)

            Case "250684"   '�м����
                FillHorCell(11, 13, i)
            Case "250682"   '�м����
                FillHorCell(13, 13, i)
            Case "250484"   '�м����
                FillHorCell(15, 13, i)
            Case "250482"   '�м����
                FillHorCell(17, 13, i)
            Case "250284"   '�м����
                FillHorCell(19, 13, i)
            Case "250282"   '�м����
                FillHorCell(21, 13, i)
            Case "250184"   '�м����
                FillHorCell(23, 13, i)
            Case "250182"   '�м����
                FillHorCell(25, 13, i)
            Case "250384"   '�м����
                FillHorCell(27, 13, i)
            Case "250382"   '�м����
                FillHorCell(29, 13, i)
            Case "250584"   '�м����
                FillHorCell(31, 13, i)
            Case "250582"   '�м����
                FillHorCell(33, 13, i)

            Case "250782"   '�м����
                FillHorCell(36, 13, i)
            Case "250784"   '�м����
                FillHorCell(38, 13, i)

        End Select
    End Sub
    '��дCarDeck��ͼ��Ԫ��
    Public Shared Sub FillCarDeckCell(ByVal i As Integer)
        Select Case TongBayNo(c1dbg.Columns("BayNo").CellText(i))
            '''
            '��� CAR DECK ��5
            '''''
        Case "050410"   '�м����
                FillHorCell(42, 35, i)
            Case "050210"   '�м����
                FillHorCell(44, 35, i)
            Case "050010"   '�м����
                FillHorCell(46, 35, i)
            Case "050110"   '�м����
                FillHorCell(48, 35, i)
            Case "050310"   '�м����
                FillHorCell(50, 35, i)
                '''
                '��� CAR DECK ��7
                '''''
            Case "070410"   '�м����
                FillHorCell(42, 32, i)
            Case "070210"   '�м����
                FillHorCell(44, 32, i)
            Case "070010"   '�м����
                FillHorCell(46, 32, i)
            Case "070110"   '�м����
                FillHorCell(48, 32, i)
            Case "070310"   '�м����
                FillHorCell(50, 32, i)
                '''
                '��� CAR DECK ��9
                '''''
            Case "090410"   '�м����
                FillHorCell(42, 30, i)
            Case "090210"   '�м����
                FillHorCell(44, 30, i)
            Case "090010"   '�м����
                FillHorCell(46, 30, i)
            Case "090110"   '�м����
                FillHorCell(48, 30, i)
            Case "090310"   '�м����
                FillHorCell(50, 30, i)

                '''
                '��� CAR DECK ��15
                '''''
            Case "150410"   '�м����
                FillHorCell(42, 24, i)
            Case "150210"   '�м����
                FillHorCell(44, 24, i)
            Case "150010"   '�м����
                FillHorCell(46, 24, i)
            Case "150110"   '�м����
                FillHorCell(48, 24, i)
            Case "150310"   '�м����
                FillHorCell(50, 24, i)
                '''
                '��� CAR DECK ��17
                '''''
            Case "170410"   '�м����
                FillHorCell(42, 22, i)
            Case "170210"   '�м����
                FillHorCell(44, 22, i)
            Case "170010"   '�м����
                FillHorCell(46, 22, i)
            Case "170110"   '�м����
                FillHorCell(48, 22, i)
            Case "170310"   '�м����
                FillHorCell(50, 22, i)
                '''
                '��� CAR DECK ��19
                '''''
            Case "190410"   '�м����
                FillHorCell(42, 20, i)
            Case "190210"   '�м����
                FillHorCell(44, 20, i)
            Case "190010"   '�м����
                FillHorCell(46, 20, i)
            Case "190110"   '�м����
                FillHorCell(48, 20, i)
            Case "190310"   '�м����
                FillHorCell(50, 20, i)
                '''
                '��� CAR DECK ��21
                '''''
            Case "210410"   '�м����
                FillHorCell(42, 17, i)
            Case "210210"   '�м����
                FillHorCell(44, 17, i)
            Case "210010"   '�м����
                FillHorCell(46, 17, i)
            Case "210110"   '�м����
                FillHorCell(48, 17, i)
            Case "210310"   '�м����
                FillHorCell(50, 17, i)
                '''
                '��� CAR DECK ��23
                '''''
            Case "230410"   '�м����
                FillHorCell(42, 15, i)
            Case "230210"   '�м����
                FillHorCell(44, 15, i)
            Case "230010"   '�м����
                FillHorCell(46, 15, i)
            Case "230110"   '�м����
                FillHorCell(48, 15, i)
            Case "230310"   '�м����
                FillHorCell(50, 15, i)
                '''
                '��� CAR DECK ��25
                '''''
            Case "250410"   '�м����
                FillHorCell(42, 13, i)
            Case "250210"   '�м����
                FillHorCell(44, 13, i)
            Case "250010"   '�м����
                FillHorCell(46, 13, i)
            Case "250110"   '�м����
                FillHorCell(48, 13, i)
            Case "250310"   '�м����
                FillHorCell(50, 13, i)

        End Select
    End Sub
    '��дFreeBoardDeck��ͼ��Ԫ��
    Public Shared Sub FillFreeBoardDeckCell(ByVal i As Integer)
        Select Case TongBayNo(c1dbg.Columns("BayNo").CellText(i))
            '''
            '��� FREEBOARD DECK ��5
            '''''
        Case "050408"   '�м����
                FillHorCell(54, 35, i)
            Case "050406"   '�м����
                FillHorCell(56, 35, i)
            Case "050208"   '�м����
                FillHorCell(58, 35, i)
            Case "050206"   '�м����
                FillHorCell(60, 35, i)
            Case "050008"   '�м����
                FillHorCell(62, 35, i)
            Case "050006"   '�м����
                FillHorCell(64, 35, i)
            Case "050108"   '�м����
                FillHorCell(66, 35, i)
            Case "050106"   '�м����
                FillHorCell(68, 35, i)
            Case "050308"   '�м����
                FillHorCell(70, 35, i)
            Case "050306"   '�м����
                FillHorCell(72, 35, i)
                '''
                '��� FREEBOARD DECK ��7
                '''''
            Case "070408"   '�м����
                FillHorCell(54, 32, i)
            Case "070406"   '�м����
                FillHorCell(56, 32, i)
            Case "070208"   '�м����
                FillHorCell(58, 32, i)
            Case "070206"   '�м����
                FillHorCell(60, 32, i)
            Case "070008"   '�м����
                FillHorCell(62, 32, i)
            Case "070006"   '�м����
                FillHorCell(64, 32, i)
            Case "070108"   '�м����
                FillHorCell(66, 32, i)
            Case "070106"   '�м����
                FillHorCell(68, 32, i)
            Case "070308"   '�м����
                FillHorCell(70, 32, i)
            Case "070306"   '�м����
                FillHorCell(72, 32, i)
                '''
                '��� FREEBOARD DECK ��9
                '''''
            Case "090408"   '�м����
                FillHorCell(54, 30, i)
            Case "090406"   '�м����
                FillHorCell(56, 30, i)
            Case "090208"   '�м����
                FillHorCell(58, 30, i)
            Case "090206"   '�м����
                FillHorCell(60, 30, i)
            Case "090008"   '�м����
                FillHorCell(62, 30, i)
            Case "090006"   '�м����
                FillHorCell(64, 30, i)
            Case "090108"   '�м����
                FillHorCell(66, 30, i)
            Case "090106"   '�м����
                FillHorCell(68, 30, i)
            Case "090308"   '�м����
                FillHorCell(70, 30, i)
            Case "090306"   '�м����
                FillHorCell(72, 30, i)
                '''
                '��� FREEBOARD DECK ��15
                '''''
            Case "150408"   '�м����
                FillHorCell(54, 24, i)
            Case "150406"   '�м����
                FillHorCell(56, 24, i)
            Case "150208"   '�м����
                FillHorCell(58, 24, i)
            Case "150206"   '�м����
                FillHorCell(60, 24, i)
            Case "150008"   '�м����
                FillHorCell(62, 24, i)
            Case "150006"   '�м����
                FillHorCell(64, 24, i)
            Case "150108"   '�м����
                FillHorCell(66, 24, i)
            Case "150106"   '�м����
                FillHorCell(68, 24, i)
            Case "150308"   '�м����
                FillHorCell(70, 24, i)
            Case "150306"   '�м����
                FillHorCell(72, 24, i)
                '''
                '��� FREEBOARD DECK ��17
                '''''
            Case "170408"   '�м����
                FillHorCell(54, 22, i)
            Case "170406"   '�м����
                FillHorCell(56, 22, i)
            Case "170208"   '�м����
                FillHorCell(58, 22, i)
            Case "170206"   '�м����
                FillHorCell(60, 22, i)
            Case "170008"   '�м����
                FillHorCell(62, 22, i)
            Case "170006"   '�м����
                FillHorCell(64, 22, i)
            Case "170108"   '�м����
                FillHorCell(66, 22, i)
            Case "170106"   '�м����
                FillHorCell(68, 22, i)
            Case "170308"   '�м����
                FillHorCell(70, 22, i)
            Case "170306"   '�м����
                FillHorCell(72, 22, i)
                '''
                '��� FREEBOARD DECK ��19
                '''''
            Case "190408"   '�м����
                FillHorCell(54, 20, i)
            Case "190406"   '�м����
                FillHorCell(56, 20, i)
            Case "190208"   '�м����
                FillHorCell(58, 20, i)
            Case "190206"   '�м����
                FillHorCell(60, 20, i)
            Case "090008"   '�м����
                FillHorCell(62, 20, i)
            Case "190006"   '�м����
                FillHorCell(64, 20, i)
            Case "190108"   '�м����
                FillHorCell(66, 20, i)
            Case "190106"   '�м����
                FillHorCell(68, 20, i)
            Case "190308"   '�м����
                FillHorCell(70, 20, i)
            Case "190306"   '�м����
                FillHorCell(72, 20, i)
                '''
                '��� FREEBOARD DECK ��21
                '''''
            Case "210408"   '�м����
                FillHorCell(54, 17, i)
            Case "210406"   '�м����
                FillHorCell(56, 17, i)
            Case "210208"   '�м����
                FillHorCell(58, 17, i)
            Case "210206"   '�м����
                FillHorCell(60, 17, i)
            Case "210008"   '�м����
                FillHorCell(62, 17, i)
            Case "210006"   '�м����
                FillHorCell(64, 17, i)
            Case "210108"   '�м����
                FillHorCell(66, 17, i)
            Case "210106"   '�м����
                FillHorCell(68, 17, i)
            Case "210308"   '�м����
                FillHorCell(70, 17, i)
            Case "210306"   '�м����
                FillHorCell(72, 17, i)
                '''
                '��� FREEBOARD DECK ��23
                '''''
            Case "230408"   '�м����
                FillHorCell(54, 15, i)
            Case "230406"   '�м����
                FillHorCell(56, 15, i)
            Case "230208"   '�м����
                FillHorCell(58, 15, i)
            Case "230206"   '�м����
                FillHorCell(60, 15, i)
            Case "070008"   '�м����
                FillHorCell(62, 15, i)
            Case "230006"   '�м����
                FillHorCell(64, 15, i)
            Case "230108"   '�м����
                FillHorCell(66, 15, i)
            Case "230106"   '�м����
                FillHorCell(68, 15, i)
            Case "230308"   '�м����
                FillHorCell(70, 15, i)
            Case "230306"   '�м����
                FillHorCell(72, 15, i)
                '''
                '��� FREEBOARD DECK ��25
                '''''
            Case "250408"   '�м����
                FillHorCell(54, 13, i)
            Case "250406"   '�м����
                FillHorCell(56, 13, i)
            Case "250208"   '�м����
                FillHorCell(58, 13, i)
            Case "250206"   '�м����
                FillHorCell(60, 13, i)
            Case "250008"   '�м����
                FillHorCell(62, 13, i)
            Case "250006"   '�м����
                FillHorCell(64, 13, i)
            Case "250108"   '�м����
                FillHorCell(66, 13, i)
            Case "250106"   '�м����
                FillHorCell(68, 13, i)
            Case "250308"   '�м����
                FillHorCell(70, 13, i)
            Case "250306"   '�м����
                FillHorCell(72, 13, i)

        End Select
    End Sub
    '��дLowerHold��ͼ��Ԫ��
    Public Shared Sub FillLowerHoldCell(ByVal i As Integer)
        Select Case TongBayNo(c1dbg.Columns("BayNo").CellText(i))
            '''
            '��� LOWER DECK ��5
            '''''
        Case "050404"   '�м����
                FillHorCell(76, 35, i)
            Case "050402"   '�м����
                FillHorCell(78, 35, i)
            Case "050204"   '�м����
                FillHorCell(80, 35, i)
            Case "050202"   '�м����
                FillHorCell(82, 35, i)
            Case "050004"   '�м����
                FillHorCell(84, 35, i)
            Case "050002"   '�м����
                FillHorCell(86, 35, i)
            Case "050104"   '�м����
                FillHorCell(88, 35, i)
            Case "050102"   '�м����
                FillHorCell(90, 35, i)
            Case "050304"   '�м����
                FillHorCell(92, 35, i)
            Case "050302"   '�м����
                FillHorCell(94, 35, i)
                '''
                '��� LOWER DECK ��7
                '''''
            Case "070404"   '�м����
                FillHorCell(76, 32, i)
            Case "070402"   '�м����
                FillHorCell(78, 32, i)
            Case "070204"   '�м����
                FillHorCell(80, 32, i)
            Case "070202"   '�м����
                FillHorCell(82, 32, i)
            Case "070004"   '�м����
                FillHorCell(84, 32, i)
            Case "070002"   '�м����
                FillHorCell(86, 32, i)
            Case "070104"   '�м����
                FillHorCell(88, 32, i)
            Case "070102"   '�м����
                FillHorCell(90, 32, i)
            Case "070304"   '�м����
                FillHorCell(92, 32, i)
            Case "070302"   '�м����
                FillHorCell(94, 32, i)
                '''
                '��� LOWER DECK ��9
                '''''
            Case "090404"   '�м����
                FillHorCell(76, 30, i)
            Case "090402"   '�м����
                FillHorCell(78, 30, i)
            Case "090204"   '�м����
                FillHorCell(80, 30, i)
            Case "090202"   '�м����
                FillHorCell(82, 30, i)
            Case "090004"   '�м����
                FillHorCell(84, 30, i)
            Case "090002"   '�м����
                FillHorCell(86, 30, i)
            Case "090104"   '�м����
                FillHorCell(88, 30, i)
            Case "090102"   '�м����
                FillHorCell(90, 30, i)
            Case "090304"   '�м����
                FillHorCell(92, 30, i)
            Case "090302"   '�м����
                FillHorCell(94, 30, i)
                '''
                '��� LOWER DECK ��15
                '''''
            Case "150404"   '�м����
                FillHorCell(76, 24, i)
            Case "150402"   '�м����
                FillHorCell(78, 24, i)
            Case "150204"   '�м����
                FillHorCell(80, 24, i)
            Case "150202"   '�м����
                FillHorCell(82, 24, i)
            Case "150004"   '�м����
                FillHorCell(84, 24, i)
            Case "150002"   '�м����
                FillHorCell(86, 24, i)
            Case "150104"   '�м����
                FillHorCell(88, 24, i)
            Case "150102"   '�м����
                FillHorCell(90, 24, i)
            Case "150304"   '�м����
                FillHorCell(92, 24, i)
            Case "150302"   '�м����
                FillHorCell(94, 24, i)
                '''
                '��� LOWER DECK ��17
                '''''
            Case "170404"   '�м����
                FillHorCell(76, 22, i)
            Case "170402"   '�м����
                FillHorCell(78, 22, i)
            Case "170204"   '�м����
                FillHorCell(80, 22, i)
            Case "170202"   '�м����
                FillHorCell(82, 22, i)
            Case "170004"   '�м����
                FillHorCell(84, 22, i)
            Case "170002"   '�м����
                FillHorCell(86, 22, i)
            Case "170104"   '�м����
                FillHorCell(88, 22, i)
            Case "170102"   '�м����
                FillHorCell(90, 22, i)
            Case "170304"   '�м����
                FillHorCell(92, 22, i)
            Case "170302"   '�м����
                FillHorCell(94, 22, i)
                '''
                '��� LOWER DECK ��19
                '''''
            Case "190404"   '�м����
                FillHorCell(76, 20, i)
            Case "190402"   '�м����
                FillHorCell(78, 20, i)
            Case "190204"   '�м����
                FillHorCell(80, 20, i)
            Case "190202"   '�м����
                FillHorCell(82, 20, i)
            Case "190004"   '�м����
                FillHorCell(84, 20, i)
            Case "190002"   '�м����
                FillHorCell(86, 20, i)
            Case "190104"   '�м����
                FillHorCell(88, 20, i)
            Case "190102"   '�м����
                FillHorCell(90, 20, i)
            Case "190304"   '�м����
                FillHorCell(92, 20, i)
            Case "190302"   '�м����
                FillHorCell(94, 20, i)
                '''
                '��� LOWER DECK ��21
                '''''
            Case "210404"   '�м����
                FillHorCell(76, 17, i)
            Case "210402"   '�м����
                FillHorCell(78, 17, i)
            Case "210204"   '�м����
                FillHorCell(80, 17, i)
            Case "210202"   '�м����
                FillHorCell(82, 17, i)
            Case "210004"   '�м����
                FillHorCell(84, 17, i)
            Case "210002"   '�м����
                FillHorCell(86, 17, i)
            Case "210104"   '�м����
                FillHorCell(88, 17, i)
            Case "210102"   '�м����
                FillHorCell(90, 17, i)
            Case "210304"   '�м����
                FillHorCell(92, 17, i)
            Case "210302"   '�м����
                FillHorCell(94, 17, i)
                '''
                '��� LOWER DECK ��23
                '''''
            Case "230404"   '�м����
                FillHorCell(76, 15, i)
            Case "230402"   '�м����
                FillHorCell(78, 15, i)
            Case "230204"   '�м����
                FillHorCell(80, 15, i)
            Case "230202"   '�м����
                FillHorCell(82, 15, i)
            Case "230004"   '�м����
                FillHorCell(84, 15, i)
            Case "230002"   '�м����
                FillHorCell(86, 15, i)
            Case "230104"   '�м����
                FillHorCell(88, 15, i)
            Case "230102"   '�м����
                FillHorCell(90, 15, i)
            Case "230304"   '�м����
                FillHorCell(92, 15, i)
            Case "230302"   '�м����
                FillHorCell(94, 15, i)
                '''
                '��� LOWER DECK ��25
                '''''
            Case "250404"   '�м����
                FillHorCell(76, 13, i)
            Case "250402"   '�м����
                FillHorCell(78, 13, i)
            Case "250204"   '�м����
                FillHorCell(80, 13, i)
            Case "250202"   '�м����
                FillHorCell(82, 13, i)
            Case "250004"   '�м����
                FillHorCell(84, 13, i)
            Case "250002"   '�м����
                FillHorCell(86, 13, i)
            Case "250104"   '�м����
                FillHorCell(88, 13, i)
            Case "250102"   '�м����
                FillHorCell(90, 13, i)
            Case "250304"   '�м����
                FillHorCell(92, 13, i)
            Case "250302"   '�м����
                FillHorCell(94, 13, i)
        End Select
    End Sub
End Class
