Public Class FillImageCell_Falcon   ''猎鹰船图
    Inherits FillImageCell

    '填写ORIGINAL面图单元格
    Public Shared Sub FillOriginalCell(ByVal i As Integer)
        Select Case TongBayNo(c1dbg.Columns("BayNo").CellText(i))
            '''
            '添加 MAIN DECK 贝1/3/27/29
            '''''
        Case "010182"   '首尾纵向
                FillVerCell(22, 38, i)
            Case "010184"   '首尾纵向
                FillVerCell(22, 40, i)
            Case "010282"   '首尾纵向
                FillVerCell(22, 42, i)
            Case "010284"   '首尾纵向
                FillVerCell(22, 44, i)
            Case "030182"   '首尾纵向
                FillVerCell(11, 38, i)
            Case "030184"   '首尾纵向
                FillVerCell(11, 40, i)
            Case "030282"   '首尾纵向
                FillVerCell(11, 42, i)
            Case "030284"   '首尾纵向
                FillVerCell(11, 44, i)
            Case "270182"   '首尾纵向
                FillVerCell(22, 4, i)
            Case "270184"   '首尾纵向
                FillVerCell(22, 6, i)
            Case "270282"   '首尾纵向
                FillVerCell(22, 8, i)
            Case "270284"   '首尾纵向
                FillVerCell(22, 10, i)
            Case "290182"   '首尾纵向
                FillVerCell(11, 4, i)
            Case "290184"   '首尾纵向
                FillVerCell(11, 6, i)
            Case "290282"   '首尾纵向
                FillVerCell(11, 8, i)
            Case "290284"   '首尾纵向
                FillVerCell(11, 10, i)
                '''
                '添加 MAIN DECK 贝5
                '''''
            Case "050882"   '中间横向
                FillHorCell(8, 35, i)
            Case "050884"   '中间横向
                FillHorCell(6, 35, i)

            Case "050684"   '中间横向
                FillHorCell(11, 35, i)
            Case "050682"   '中间横向
                FillHorCell(13, 35, i)
            Case "050484"   '中间横向
                FillHorCell(15, 35, i)
            Case "050482"   '中间横向
                FillHorCell(17, 35, i)
            Case "050284"   '中间横向
                FillHorCell(19, 35, i)
            Case "050282"   '中间横向
                FillHorCell(21, 35, i)
            Case "050184"   '中间横向
                FillHorCell(23, 35, i)
            Case "050182"   '中间横向
                FillHorCell(25, 35, i)
            Case "050384"   '中间横向
                FillHorCell(27, 35, i)
            Case "050382"   '中间横向
                FillHorCell(29, 35, i)
            Case "050584"   '中间横向
                FillHorCell(31, 35, i)
            Case "050582"   '中间横向
                FillHorCell(33, 35, i)

            Case "050782"   '中间横向
                FillHorCell(36, 35, i)
            Case "050784"   '中间横向
                FillHorCell(38, 35, i)
                '''
                '添加 MAIN DECK 贝7
                '''''
            Case "070882"   '中间横向
                FillHorCell(8, 32, i)
            Case "070884"   '中间横向
                FillHorCell(6, 32, i)

            Case "070684"   '中间横向
                FillHorCell(11, 32, i)
            Case "070682"   '中间横向
                FillHorCell(13, 32, i)
            Case "070484"   '中间横向
                FillHorCell(15, 32, i)
            Case "070482"   '中间横向
                FillHorCell(17, 32, i)
            Case "070284"   '中间横向
                FillHorCell(19, 32, i)
            Case "070282"   '中间横向
                FillHorCell(21, 32, i)
            Case "070184"   '中间横向
                FillHorCell(23, 32, i)
            Case "070182"   '中间横向
                FillHorCell(25, 32, i)
            Case "070384"   '中间横向
                FillHorCell(27, 32, i)
            Case "070382"   '中间横向
                FillHorCell(29, 32, i)
            Case "070584"   '中间横向
                FillHorCell(31, 32, i)
            Case "070582"   '中间横向
                FillHorCell(33, 32, i)

            Case "070782"   '中间横向
                FillHorCell(36, 32, i)
            Case "070784"   '中间横向
                FillHorCell(38, 32, i)
                '''
                '添加 MAIN DECK 贝9
                '''''
            Case "090882"   '中间横向
                FillHorCell(8, 30, i)
            Case "090884"   '中间横向
                FillHorCell(6, 30, i)

            Case "090684"   '中间横向
                FillHorCell(11, 30, i)
            Case "090682"   '中间横向
                FillHorCell(13, 30, i)
            Case "090484"   '中间横向
                FillHorCell(15, 30, i)
            Case "090482"   '中间横向
                FillHorCell(17, 30, i)
            Case "090284"   '中间横向
                FillHorCell(19, 30, i)
            Case "090282"   '中间横向
                FillHorCell(21, 30, i)
            Case "090184"   '中间横向
                FillHorCell(23, 30, i)
            Case "090182"   '中间横向
                FillHorCell(25, 30, i)
            Case "090384"   '中间横向
                FillHorCell(27, 30, i)
            Case "090382"   '中间横向
                FillHorCell(29, 30, i)
            Case "090584"   '中间横向
                FillHorCell(31, 30, i)
            Case "090582"   '中间横向
                FillHorCell(33, 30, i)

            Case "090782"   '中间横向
                FillHorCell(36, 30, i)
            Case "090784"   '中间横向
                FillHorCell(38, 30, i)
                '''
                '添加 MAIN DECK 贝11
                '''''
            Case "110882"   '中间横向
                FillHorCell(8, 28, i)
            Case "110884"   '中间横向
                FillHorCell(6, 28, i)

            Case "110782"   '中间横向
                FillHorCell(36, 28, i)
            Case "110784"   '中间横向
                FillHorCell(38, 28, i)
                '''
                '添加 MAIN DECK 贝13
                '''''
            Case "130882"   '中间横向
                FillHorCell(8, 26, i)
            Case "130884"   '中间横向
                FillHorCell(6, 26, i)

            Case "130782"   '中间横向
                FillHorCell(36, 26, i)
            Case "130784"   '中间横向
                FillHorCell(38, 26, i)
                '''
                '添加 MAIN DECK 贝15
                '''''
            Case "150882"   '中间横向
                FillHorCell(8, 24, i)
            Case "150884"   '中间横向
                FillHorCell(6, 24, i)

            Case "150684"   '中间横向
                FillHorCell(11, 24, i)
            Case "150682"   '中间横向
                FillHorCell(13, 24, i)
            Case "150484"   '中间横向
                FillHorCell(15, 24, i)
            Case "150482"   '中间横向
                FillHorCell(17, 24, i)
            Case "150284"   '中间横向
                FillHorCell(19, 24, i)
            Case "150282"   '中间横向
                FillHorCell(21, 24, i)
            Case "150184"   '中间横向
                FillHorCell(23, 24, i)
            Case "150182"   '中间横向
                FillHorCell(25, 24, i)
            Case "150384"   '中间横向
                FillHorCell(27, 24, i)
            Case "150382"   '中间横向
                FillHorCell(29, 24, i)
            Case "150584"   '中间横向
                FillHorCell(31, 24, i)
            Case "150582"   '中间横向
                FillHorCell(33, 24, i)

            Case "150782"   '中间横向
                FillHorCell(36, 24, i)
            Case "150784"   '中间横向
                FillHorCell(38, 24, i)
                '''
                '添加 MAIN DECK 贝17
                '''''
            Case "170882"   '中间横向
                FillHorCell(8, 22, i)
            Case "170884"   '中间横向
                FillHorCell(6, 22, i)

            Case "170684"   '中间横向
                FillHorCell(11, 22, i)
            Case "170682"   '中间横向
                FillHorCell(13, 22, i)
            Case "170484"   '中间横向
                FillHorCell(15, 22, i)
            Case "170482"   '中间横向
                FillHorCell(17, 22, i)
            Case "170284"   '中间横向
                FillHorCell(19, 22, i)
            Case "170282"   '中间横向
                FillHorCell(21, 22, i)
            Case "170184"   '中间横向
                FillHorCell(23, 22, i)
            Case "170182"   '中间横向
                FillHorCell(25, 22, i)
            Case "170384"   '中间横向
                FillHorCell(27, 22, i)
            Case "170382"   '中间横向
                FillHorCell(29, 22, i)
            Case "170584"   '中间横向
                FillHorCell(31, 22, i)
            Case "170582"   '中间横向
                FillHorCell(33, 22, i)

            Case "170782"   '中间横向
                FillHorCell(36, 22, i)
            Case "170784"   '中间横向
                FillHorCell(38, 22, i)
                '''
                '添加 MAIN DECK 贝19
                '''''
            Case "190882"   '中间横向
                FillHorCell(8, 20, i)
            Case "190884"   '中间横向
                FillHorCell(6, 20, i)

            Case "190684"   '中间横向
                FillHorCell(11, 20, i)
            Case "190682"   '中间横向
                FillHorCell(13, 20, i)
            Case "190484"   '中间横向
                FillHorCell(15, 20, i)
            Case "190482"   '中间横向
                FillHorCell(17, 20, i)
            Case "190284"   '中间横向
                FillHorCell(19, 20, i)
            Case "190282"   '中间横向
                FillHorCell(21, 20, i)
            Case "190184"   '中间横向
                FillHorCell(23, 20, i)
            Case "190182"   '中间横向
                FillHorCell(25, 20, i)
            Case "190384"   '中间横向
                FillHorCell(27, 20, i)
            Case "190382"   '中间横向
                FillHorCell(29, 20, i)
            Case "190584"   '中间横向
                FillHorCell(31, 20, i)
            Case "190582"   '中间横向
                FillHorCell(33, 20, i)

            Case "190782"   '中间横向
                FillHorCell(36, 20, i)
            Case "190784"   '中间横向
                FillHorCell(38, 20, i)
                '''
                '添加 MAIN DECK 贝21
                '''''
            Case "210684"   '中间横向
                FillHorCell(11, 17, i)
            Case "210682"   '中间横向
                FillHorCell(13, 17, i)
            Case "210484"   '中间横向
                FillHorCell(15, 17, i)
            Case "210482"   '中间横向
                FillHorCell(17, 17, i)
            Case "210284"   '中间横向
                FillHorCell(19, 17, i)
            Case "210282"   '中间横向
                FillHorCell(21, 17, i)
            Case "210184"   '中间横向
                FillHorCell(23, 17, i)
            Case "210182"   '中间横向
                FillHorCell(25, 17, i)
            Case "210384"   '中间横向
                FillHorCell(27, 17, i)
            Case "210382"   '中间横向
                FillHorCell(29, 17, i)
            Case "210584"   '中间横向
                FillHorCell(31, 17, i)
            Case "210582"   '中间横向
                FillHorCell(33, 17, i)
                '''
                '添加 MAIN DECK 贝23
                '''''
            Case "230882"   '中间横向
                FillHorCell(8, 15, i)
            Case "230884"   '中间横向
                FillHorCell(6, 15, i)

            Case "230684"   '中间横向
                FillHorCell(11, 15, i)
            Case "230682"   '中间横向
                FillHorCell(13, 15, i)
            Case "230484"   '中间横向
                FillHorCell(15, 15, i)
            Case "230482"   '中间横向
                FillHorCell(17, 15, i)
            Case "230284"   '中间横向
                FillHorCell(19, 15, i)
            Case "230282"   '中间横向
                FillHorCell(21, 15, i)
            Case "230184"   '中间横向
                FillHorCell(23, 15, i)
            Case "230182"   '中间横向
                FillHorCell(25, 15, i)
            Case "230384"   '中间横向
                FillHorCell(27, 15, i)
            Case "230382"   '中间横向
                FillHorCell(29, 15, i)
            Case "230584"   '中间横向
                FillHorCell(31, 15, i)
            Case "230582"   '中间横向
                FillHorCell(33, 15, i)

            Case "230782"   '中间横向
                FillHorCell(36, 15, i)
            Case "230784"   '中间横向
                FillHorCell(38, 15, i)
                '''
                '添加 MAIN DECK 贝25
                '''''
            Case "250882"   '中间横向
                FillHorCell(8, 13, i)
            Case "250884"   '中间横向
                FillHorCell(6, 13, i)

            Case "250684"   '中间横向
                FillHorCell(11, 13, i)
            Case "250682"   '中间横向
                FillHorCell(13, 13, i)
            Case "250484"   '中间横向
                FillHorCell(15, 13, i)
            Case "250482"   '中间横向
                FillHorCell(17, 13, i)
            Case "250284"   '中间横向
                FillHorCell(19, 13, i)
            Case "250282"   '中间横向
                FillHorCell(21, 13, i)
            Case "250184"   '中间横向
                FillHorCell(23, 13, i)
            Case "250182"   '中间横向
                FillHorCell(25, 13, i)
            Case "250384"   '中间横向
                FillHorCell(27, 13, i)
            Case "250382"   '中间横向
                FillHorCell(29, 13, i)
            Case "250584"   '中间横向
                FillHorCell(31, 13, i)
            Case "250582"   '中间横向
                FillHorCell(33, 13, i)

            Case "250782"   '中间横向
                FillHorCell(36, 13, i)
            Case "250784"   '中间横向
                FillHorCell(38, 13, i)

                '''
                '添加 CAR DECK 贝5
                '''''
            Case "050410"   '中间横向
                FillHorCell(42, 35, i)
            Case "050210"   '中间横向
                FillHorCell(44, 35, i)
            Case "050010"   '中间横向
                FillHorCell(46, 35, i)
            Case "050110"   '中间横向
                FillHorCell(48, 35, i)
            Case "050310"   '中间横向
                FillHorCell(50, 35, i)
                '''
                '添加 CAR DECK 贝7
                '''''
            Case "070410"   '中间横向
                FillHorCell(42, 32, i)
            Case "070210"   '中间横向
                FillHorCell(44, 32, i)
            Case "070010"   '中间横向
                FillHorCell(46, 32, i)
            Case "070110"   '中间横向
                FillHorCell(48, 32, i)
            Case "070310"   '中间横向
                FillHorCell(50, 32, i)
                '''
                '添加 CAR DECK 贝9
                '''''
            Case "090410"   '中间横向
                FillHorCell(42, 30, i)
            Case "090210"   '中间横向
                FillHorCell(44, 30, i)
            Case "090010"   '中间横向
                FillHorCell(46, 30, i)
            Case "090110"   '中间横向
                FillHorCell(48, 30, i)
            Case "090310"   '中间横向
                FillHorCell(50, 30, i)

                '''
                '添加 CAR DECK 贝15
                '''''
            Case "150410"   '中间横向
                FillHorCell(42, 24, i)
            Case "150210"   '中间横向
                FillHorCell(44, 24, i)
            Case "150010"   '中间横向
                FillHorCell(46, 24, i)
            Case "150110"   '中间横向
                FillHorCell(48, 24, i)
            Case "150310"   '中间横向
                FillHorCell(50, 24, i)
                '''
                '添加 CAR DECK 贝17
                '''''
            Case "170410"   '中间横向
                FillHorCell(42, 22, i)
            Case "170210"   '中间横向
                FillHorCell(44, 22, i)
            Case "170010"   '中间横向
                FillHorCell(46, 22, i)
            Case "170110"   '中间横向
                FillHorCell(48, 22, i)
            Case "170310"   '中间横向
                FillHorCell(50, 22, i)
                '''
                '添加 CAR DECK 贝19
                '''''
            Case "190410"   '中间横向
                FillHorCell(42, 20, i)
            Case "190210"   '中间横向
                FillHorCell(44, 20, i)
            Case "190010"   '中间横向
                FillHorCell(46, 20, i)
            Case "190110"   '中间横向
                FillHorCell(48, 20, i)
            Case "190310"   '中间横向
                FillHorCell(50, 20, i)
                '''
                '添加 CAR DECK 贝21
                '''''
            Case "210410"   '中间横向
                FillHorCell(42, 17, i)
            Case "210210"   '中间横向
                FillHorCell(44, 17, i)
            Case "210010"   '中间横向
                FillHorCell(46, 17, i)
            Case "210110"   '中间横向
                FillHorCell(48, 17, i)
            Case "210310"   '中间横向
                FillHorCell(50, 17, i)
                '''
                '添加 CAR DECK 贝23
                '''''
            Case "230410"   '中间横向
                FillHorCell(42, 15, i)
            Case "230210"   '中间横向
                FillHorCell(44, 15, i)
            Case "230010"   '中间横向
                FillHorCell(46, 15, i)
            Case "230110"   '中间横向
                FillHorCell(48, 15, i)
            Case "230310"   '中间横向
                FillHorCell(50, 15, i)
                '''
                '添加 CAR DECK 贝25
                '''''
            Case "250410"   '中间横向
                FillHorCell(42, 13, i)
            Case "250210"   '中间横向
                FillHorCell(44, 13, i)
            Case "250010"   '中间横向
                FillHorCell(46, 13, i)
            Case "250110"   '中间横向
                FillHorCell(48, 13, i)
            Case "250310"   '中间横向
                FillHorCell(50, 13, i)

                '''
                '添加 FREEBOARD DECK 贝5
                '''''
            Case "050408"   '中间横向
                FillHorCell(54, 35, i)
            Case "050406"   '中间横向
                FillHorCell(56, 35, i)
            Case "050208"   '中间横向
                FillHorCell(58, 35, i)
            Case "050206"   '中间横向
                FillHorCell(60, 35, i)
            Case "050008"   '中间横向
                FillHorCell(62, 35, i)
            Case "050006"   '中间横向
                FillHorCell(64, 35, i)
            Case "050108"   '中间横向
                FillHorCell(66, 35, i)
            Case "050106"   '中间横向
                FillHorCell(68, 35, i)
            Case "050308"   '中间横向
                FillHorCell(70, 35, i)
            Case "050306"   '中间横向
                FillHorCell(72, 35, i)
                '''
                '添加 FREEBOARD DECK 贝7
                '''''
            Case "070408"   '中间横向
                FillHorCell(54, 32, i)
            Case "070406"   '中间横向
                FillHorCell(56, 32, i)
            Case "070208"   '中间横向
                FillHorCell(58, 32, i)
            Case "070206"   '中间横向
                FillHorCell(60, 32, i)
            Case "070008"   '中间横向
                FillHorCell(62, 32, i)
            Case "070006"   '中间横向
                FillHorCell(64, 32, i)
            Case "070108"   '中间横向
                FillHorCell(66, 32, i)
            Case "070106"   '中间横向
                FillHorCell(68, 32, i)
            Case "070308"   '中间横向
                FillHorCell(70, 32, i)
            Case "070306"   '中间横向
                FillHorCell(72, 32, i)
                '''
                '添加 FREEBOARD DECK 贝9
                '''''
            Case "090408"   '中间横向
                FillHorCell(54, 30, i)
            Case "090406"   '中间横向
                FillHorCell(56, 30, i)
            Case "090208"   '中间横向
                FillHorCell(58, 30, i)
            Case "090206"   '中间横向
                FillHorCell(60, 30, i)
            Case "090008"   '中间横向
                FillHorCell(62, 30, i)
            Case "090006"   '中间横向
                FillHorCell(64, 30, i)
            Case "090108"   '中间横向
                FillHorCell(66, 30, i)
            Case "090106"   '中间横向
                FillHorCell(68, 30, i)
            Case "090308"   '中间横向
                FillHorCell(70, 30, i)
            Case "090306"   '中间横向
                FillHorCell(72, 30, i)
                '''
                '添加 FREEBOARD DECK 贝15
                '''''
            Case "150408"   '中间横向
                FillHorCell(54, 24, i)
            Case "150406"   '中间横向
                FillHorCell(56, 24, i)
            Case "150208"   '中间横向
                FillHorCell(58, 24, i)
            Case "150206"   '中间横向
                FillHorCell(60, 24, i)
            Case "150008"   '中间横向
                FillHorCell(62, 24, i)
            Case "150006"   '中间横向
                FillHorCell(64, 24, i)
            Case "150108"   '中间横向
                FillHorCell(66, 24, i)
            Case "150106"   '中间横向
                FillHorCell(68, 24, i)
            Case "150308"   '中间横向
                FillHorCell(70, 24, i)
            Case "150306"   '中间横向
                FillHorCell(72, 24, i)
                '''
                '添加 FREEBOARD DECK 贝17
                '''''
            Case "170408"   '中间横向
                FillHorCell(54, 22, i)
            Case "170406"   '中间横向
                FillHorCell(56, 22, i)
            Case "170208"   '中间横向
                FillHorCell(58, 22, i)
            Case "170206"   '中间横向
                FillHorCell(60, 22, i)
            Case "170008"   '中间横向
                FillHorCell(62, 22, i)
            Case "170006"   '中间横向
                FillHorCell(64, 22, i)
            Case "170108"   '中间横向
                FillHorCell(66, 22, i)
            Case "170106"   '中间横向
                FillHorCell(68, 22, i)
            Case "170308"   '中间横向
                FillHorCell(70, 22, i)
            Case "170306"   '中间横向
                FillHorCell(72, 22, i)
                '''
                '添加 FREEBOARD DECK 贝19
                '''''
            Case "190408"   '中间横向
                FillHorCell(54, 20, i)
            Case "190406"   '中间横向
                FillHorCell(56, 20, i)
            Case "190208"   '中间横向
                FillHorCell(58, 20, i)
            Case "190206"   '中间横向
                FillHorCell(60, 20, i)
            Case "090008"   '中间横向
                FillHorCell(62, 20, i)
            Case "190006"   '中间横向
                FillHorCell(64, 20, i)
            Case "190108"   '中间横向
                FillHorCell(66, 20, i)
            Case "190106"   '中间横向
                FillHorCell(68, 20, i)
            Case "190308"   '中间横向
                FillHorCell(70, 20, i)
            Case "190306"   '中间横向
                FillHorCell(72, 20, i)
                '''
                '添加 FREEBOARD DECK 贝21
                '''''
            Case "210408"   '中间横向
                FillHorCell(54, 17, i)
            Case "210406"   '中间横向
                FillHorCell(56, 17, i)
            Case "210208"   '中间横向
                FillHorCell(58, 17, i)
            Case "210206"   '中间横向
                FillHorCell(60, 17, i)
            Case "210008"   '中间横向
                FillHorCell(62, 17, i)
            Case "210006"   '中间横向
                FillHorCell(64, 17, i)
            Case "210108"   '中间横向
                FillHorCell(66, 17, i)
            Case "210106"   '中间横向
                FillHorCell(68, 17, i)
            Case "210308"   '中间横向
                FillHorCell(70, 17, i)
            Case "210306"   '中间横向
                FillHorCell(72, 17, i)
                '''
                '添加 FREEBOARD DECK 贝23
                '''''
            Case "230408"   '中间横向
                FillHorCell(54, 15, i)
            Case "230406"   '中间横向
                FillHorCell(56, 15, i)
            Case "230208"   '中间横向
                FillHorCell(58, 15, i)
            Case "230206"   '中间横向
                FillHorCell(60, 15, i)
            Case "070008"   '中间横向
                FillHorCell(62, 15, i)
            Case "230006"   '中间横向
                FillHorCell(64, 15, i)
            Case "230108"   '中间横向
                FillHorCell(66, 15, i)
            Case "230106"   '中间横向
                FillHorCell(68, 15, i)
            Case "230308"   '中间横向
                FillHorCell(70, 15, i)
            Case "230306"   '中间横向
                FillHorCell(72, 15, i)
                '''
                '添加 FREEBOARD DECK 贝25
                '''''
            Case "250408"   '中间横向
                FillHorCell(54, 13, i)
            Case "250406"   '中间横向
                FillHorCell(56, 13, i)
            Case "250208"   '中间横向
                FillHorCell(58, 13, i)
            Case "250206"   '中间横向
                FillHorCell(60, 13, i)
            Case "250008"   '中间横向
                FillHorCell(62, 13, i)
            Case "250006"   '中间横向
                FillHorCell(64, 13, i)
            Case "250108"   '中间横向
                FillHorCell(66, 13, i)
            Case "250106"   '中间横向
                FillHorCell(68, 13, i)
            Case "250308"   '中间横向
                FillHorCell(70, 13, i)
            Case "250306"   '中间横向
                FillHorCell(72, 13, i)

                '''
                '添加 LOWER DECK 贝5
                '''''
            Case "050404"   '中间横向
                FillHorCell(76, 35, i)
            Case "050402"   '中间横向
                FillHorCell(78, 35, i)
            Case "050204"   '中间横向
                FillHorCell(80, 35, i)
            Case "050202"   '中间横向
                FillHorCell(82, 35, i)
            Case "050004"   '中间横向
                FillHorCell(84, 35, i)
            Case "050002"   '中间横向
                FillHorCell(86, 35, i)
            Case "050104"   '中间横向
                FillHorCell(88, 35, i)
            Case "050102"   '中间横向
                FillHorCell(90, 35, i)
            Case "050304"   '中间横向
                FillHorCell(92, 35, i)
            Case "050302"   '中间横向
                FillHorCell(94, 35, i)
                '''
                '添加 LOWER DECK 贝7
                '''''
            Case "070404"   '中间横向
                FillHorCell(76, 32, i)
            Case "070402"   '中间横向
                FillHorCell(78, 32, i)
            Case "070204"   '中间横向
                FillHorCell(80, 32, i)
            Case "070202"   '中间横向
                FillHorCell(82, 32, i)
            Case "070004"   '中间横向
                FillHorCell(84, 32, i)
            Case "070002"   '中间横向
                FillHorCell(86, 32, i)
            Case "070104"   '中间横向
                FillHorCell(88, 32, i)
            Case "070102"   '中间横向
                FillHorCell(90, 32, i)
            Case "070304"   '中间横向
                FillHorCell(92, 32, i)
            Case "070302"   '中间横向
                FillHorCell(94, 32, i)
                '''
                '添加 LOWER DECK 贝9
                '''''
            Case "090404"   '中间横向
                FillHorCell(76, 30, i)
            Case "090402"   '中间横向
                FillHorCell(78, 30, i)
            Case "090204"   '中间横向
                FillHorCell(80, 30, i)
            Case "090202"   '中间横向
                FillHorCell(82, 30, i)
            Case "090004"   '中间横向
                FillHorCell(84, 30, i)
            Case "090002"   '中间横向
                FillHorCell(86, 30, i)
            Case "090104"   '中间横向
                FillHorCell(88, 30, i)
            Case "090102"   '中间横向
                FillHorCell(90, 30, i)
            Case "090304"   '中间横向
                FillHorCell(92, 30, i)
            Case "090302"   '中间横向
                FillHorCell(94, 30, i)
                '''
                '添加 LOWER DECK 贝15
                '''''
            Case "150404"   '中间横向
                FillHorCell(76, 24, i)
            Case "150402"   '中间横向
                FillHorCell(78, 24, i)
            Case "150204"   '中间横向
                FillHorCell(80, 24, i)
            Case "150202"   '中间横向
                FillHorCell(82, 24, i)
            Case "150004"   '中间横向
                FillHorCell(84, 24, i)
            Case "150002"   '中间横向
                FillHorCell(86, 24, i)
            Case "150104"   '中间横向
                FillHorCell(88, 24, i)
            Case "150102"   '中间横向
                FillHorCell(90, 24, i)
            Case "150304"   '中间横向
                FillHorCell(92, 24, i)
            Case "150302"   '中间横向
                FillHorCell(94, 24, i)
                '''
                '添加 LOWER DECK 贝17
                '''''
            Case "170404"   '中间横向
                FillHorCell(76, 22, i)
            Case "170402"   '中间横向
                FillHorCell(78, 22, i)
            Case "170204"   '中间横向
                FillHorCell(80, 22, i)
            Case "170202"   '中间横向
                FillHorCell(82, 22, i)
            Case "170004"   '中间横向
                FillHorCell(84, 22, i)
            Case "170002"   '中间横向
                FillHorCell(86, 22, i)
            Case "170104"   '中间横向
                FillHorCell(88, 22, i)
            Case "170102"   '中间横向
                FillHorCell(90, 22, i)
            Case "170304"   '中间横向
                FillHorCell(92, 22, i)
            Case "170302"   '中间横向
                FillHorCell(94, 22, i)
                '''
                '添加 LOWER DECK 贝19
                '''''
            Case "190404"   '中间横向
                FillHorCell(76, 20, i)
            Case "190402"   '中间横向
                FillHorCell(78, 20, i)
            Case "190204"   '中间横向
                FillHorCell(80, 20, i)
            Case "190202"   '中间横向
                FillHorCell(82, 20, i)
            Case "190004"   '中间横向
                FillHorCell(84, 20, i)
            Case "190002"   '中间横向
                FillHorCell(86, 20, i)
            Case "190104"   '中间横向
                FillHorCell(88, 20, i)
            Case "190102"   '中间横向
                FillHorCell(90, 20, i)
            Case "190304"   '中间横向
                FillHorCell(92, 20, i)
            Case "190302"   '中间横向
                FillHorCell(94, 20, i)
                '''
                '添加 LOWER DECK 贝21
                '''''
            Case "210404"   '中间横向
                FillHorCell(76, 17, i)
            Case "210402"   '中间横向
                FillHorCell(78, 17, i)
            Case "210204"   '中间横向
                FillHorCell(80, 17, i)
            Case "210202"   '中间横向
                FillHorCell(82, 17, i)
            Case "210004"   '中间横向
                FillHorCell(84, 17, i)
            Case "210002"   '中间横向
                FillHorCell(86, 17, i)
            Case "210104"   '中间横向
                FillHorCell(88, 17, i)
            Case "210102"   '中间横向
                FillHorCell(90, 17, i)
            Case "210304"   '中间横向
                FillHorCell(92, 17, i)
            Case "210302"   '中间横向
                FillHorCell(94, 17, i)
                '''
                '添加 LOWER DECK 贝23
                '''''
            Case "230404"   '中间横向
                FillHorCell(76, 15, i)
            Case "230402"   '中间横向
                FillHorCell(78, 15, i)
            Case "230204"   '中间横向
                FillHorCell(80, 15, i)
            Case "230202"   '中间横向
                FillHorCell(82, 15, i)
            Case "230004"   '中间横向
                FillHorCell(84, 15, i)
            Case "230002"   '中间横向
                FillHorCell(86, 15, i)
            Case "230104"   '中间横向
                FillHorCell(88, 15, i)
            Case "230102"   '中间横向
                FillHorCell(90, 15, i)
            Case "230304"   '中间横向
                FillHorCell(92, 15, i)
            Case "230302"   '中间横向
                FillHorCell(94, 15, i)
                '''
                '添加 LOWER DECK 贝25
                '''''
            Case "250404"   '中间横向
                FillHorCell(76, 13, i)
            Case "250402"   '中间横向
                FillHorCell(78, 13, i)
            Case "250204"   '中间横向
                FillHorCell(80, 13, i)
            Case "250202"   '中间横向
                FillHorCell(82, 13, i)
            Case "250004"   '中间横向
                FillHorCell(84, 13, i)
            Case "250002"   '中间横向
                FillHorCell(86, 13, i)
            Case "250104"   '中间横向
                FillHorCell(88, 13, i)
            Case "250102"   '中间横向
                FillHorCell(90, 13, i)
            Case "250304"   '中间横向
                FillHorCell(92, 13, i)
            Case "250302"   '中间横向
                FillHorCell(94, 13, i)

        End Select
    End Sub

    '填写MainDeck面图单元格
    Public Shared Sub FillMainDeckCell(ByVal i As Integer)
        Select Case TongBayNo(c1dbg.Columns("BayNo").CellText(i))
            '''
            '添加 MAIN DECK 贝1/3/27/29
            '''''
        Case "010182"   '首尾纵向
                FillVerCell(22, 38, i)
            Case "010184"   '首尾纵向
                FillVerCell(22, 40, i)
            Case "010282"   '首尾纵向
                FillVerCell(22, 42, i)
            Case "010284"   '首尾纵向
                FillVerCell(22, 44, i)
            Case "030182"   '首尾纵向
                FillVerCell(11, 38, i)
            Case "030184"   '首尾纵向
                FillVerCell(11, 40, i)
            Case "030282"   '首尾纵向
                FillVerCell(11, 42, i)
            Case "030284"   '首尾纵向
                FillVerCell(11, 44, i)
            Case "270182"   '首尾纵向
                FillVerCell(22, 4, i)
            Case "270184"   '首尾纵向
                FillVerCell(22, 6, i)
            Case "270282"   '首尾纵向
                FillVerCell(22, 8, i)
            Case "270284"   '首尾纵向
                FillVerCell(22, 10, i)
            Case "290182"   '首尾纵向
                FillVerCell(11, 4, i)
            Case "290184"   '首尾纵向
                FillVerCell(11, 6, i)
            Case "290282"   '首尾纵向
                FillVerCell(11, 8, i)
            Case "290284"   '首尾纵向
                FillVerCell(11, 10, i)
                '''
                '添加 MAIN DECK 贝5
                '''''
            Case "050882"   '中间横向
                FillHorCell(8, 35, i)
            Case "050884"   '中间横向
                FillHorCell(6, 35, i)

            Case "050684"   '中间横向
                FillHorCell(11, 35, i)
            Case "050682"   '中间横向
                FillHorCell(13, 35, i)
            Case "050484"   '中间横向
                FillHorCell(15, 35, i)
            Case "050482"   '中间横向
                FillHorCell(17, 35, i)
            Case "050284"   '中间横向
                FillHorCell(19, 35, i)
            Case "050282"   '中间横向
                FillHorCell(21, 35, i)
            Case "050184"   '中间横向
                FillHorCell(23, 35, i)
            Case "050182"   '中间横向
                FillHorCell(25, 35, i)
            Case "050384"   '中间横向
                FillHorCell(27, 35, i)
            Case "050382"   '中间横向
                FillHorCell(29, 35, i)
            Case "050584"   '中间横向
                FillHorCell(31, 35, i)
            Case "050582"   '中间横向
                FillHorCell(33, 35, i)

            Case "050782"   '中间横向
                FillHorCell(36, 35, i)
            Case "050784"   '中间横向
                FillHorCell(38, 35, i)
                '''
                '添加 MAIN DECK 贝7
                '''''
            Case "070882"   '中间横向
                FillHorCell(8, 32, i)
            Case "070884"   '中间横向
                FillHorCell(6, 32, i)

            Case "070684"   '中间横向
                FillHorCell(11, 32, i)
            Case "070682"   '中间横向
                FillHorCell(13, 32, i)
            Case "070484"   '中间横向
                FillHorCell(15, 32, i)
            Case "070482"   '中间横向
                FillHorCell(17, 32, i)
            Case "070284"   '中间横向
                FillHorCell(19, 32, i)
            Case "070282"   '中间横向
                FillHorCell(21, 32, i)
            Case "070184"   '中间横向
                FillHorCell(23, 32, i)
            Case "070182"   '中间横向
                FillHorCell(25, 32, i)
            Case "070384"   '中间横向
                FillHorCell(27, 32, i)
            Case "070382"   '中间横向
                FillHorCell(29, 32, i)
            Case "070584"   '中间横向
                FillHorCell(31, 32, i)
            Case "070582"   '中间横向
                FillHorCell(33, 32, i)

            Case "070782"   '中间横向
                FillHorCell(36, 32, i)
            Case "070784"   '中间横向
                FillHorCell(38, 32, i)
                '''
                '添加 MAIN DECK 贝9
                '''''
            Case "090882"   '中间横向
                FillHorCell(8, 30, i)
            Case "090884"   '中间横向
                FillHorCell(6, 30, i)

            Case "090684"   '中间横向
                FillHorCell(11, 30, i)
            Case "090682"   '中间横向
                FillHorCell(13, 30, i)
            Case "090484"   '中间横向
                FillHorCell(15, 30, i)
            Case "090482"   '中间横向
                FillHorCell(17, 30, i)
            Case "090284"   '中间横向
                FillHorCell(19, 30, i)
            Case "090282"   '中间横向
                FillHorCell(21, 30, i)
            Case "090184"   '中间横向
                FillHorCell(23, 30, i)
            Case "090182"   '中间横向
                FillHorCell(25, 30, i)
            Case "090384"   '中间横向
                FillHorCell(27, 30, i)
            Case "090382"   '中间横向
                FillHorCell(29, 30, i)
            Case "090584"   '中间横向
                FillHorCell(31, 30, i)
            Case "090582"   '中间横向
                FillHorCell(33, 30, i)

            Case "090782"   '中间横向
                FillHorCell(36, 30, i)
            Case "090784"   '中间横向
                FillHorCell(38, 30, i)
                '''
                '添加 MAIN DECK 贝11
                '''''
            Case "110882"   '中间横向
                FillHorCell(8, 28, i)
            Case "110884"   '中间横向
                FillHorCell(6, 28, i)

            Case "110782"   '中间横向
                FillHorCell(36, 28, i)
            Case "110784"   '中间横向
                FillHorCell(38, 28, i)
                '''
                '添加 MAIN DECK 贝13
                '''''
            Case "130882"   '中间横向
                FillHorCell(8, 26, i)
            Case "130884"   '中间横向
                FillHorCell(6, 26, i)

            Case "130782"   '中间横向
                FillHorCell(36, 26, i)
            Case "130784"   '中间横向
                FillHorCell(38, 26, i)
                '''
                '添加 MAIN DECK 贝15
                '''''
            Case "150882"   '中间横向
                FillHorCell(8, 24, i)
            Case "150884"   '中间横向
                FillHorCell(6, 24, i)

            Case "150684"   '中间横向
                FillHorCell(11, 24, i)
            Case "150682"   '中间横向
                FillHorCell(13, 24, i)
            Case "150484"   '中间横向
                FillHorCell(15, 24, i)
            Case "150482"   '中间横向
                FillHorCell(17, 24, i)
            Case "150284"   '中间横向
                FillHorCell(19, 24, i)
            Case "150282"   '中间横向
                FillHorCell(21, 24, i)
            Case "150184"   '中间横向
                FillHorCell(23, 24, i)
            Case "150182"   '中间横向
                FillHorCell(25, 24, i)
            Case "150384"   '中间横向
                FillHorCell(27, 24, i)
            Case "150382"   '中间横向
                FillHorCell(29, 24, i)
            Case "150584"   '中间横向
                FillHorCell(31, 24, i)
            Case "150582"   '中间横向
                FillHorCell(33, 24, i)

            Case "150782"   '中间横向
                FillHorCell(36, 24, i)
            Case "150784"   '中间横向
                FillHorCell(38, 24, i)
                '''
                '添加 MAIN DECK 贝17
                '''''
            Case "170882"   '中间横向
                FillHorCell(8, 22, i)
            Case "170884"   '中间横向
                FillHorCell(6, 22, i)

            Case "170684"   '中间横向
                FillHorCell(11, 22, i)
            Case "170682"   '中间横向
                FillHorCell(13, 22, i)
            Case "170484"   '中间横向
                FillHorCell(15, 22, i)
            Case "170482"   '中间横向
                FillHorCell(17, 22, i)
            Case "170284"   '中间横向
                FillHorCell(19, 22, i)
            Case "170282"   '中间横向
                FillHorCell(21, 22, i)
            Case "170184"   '中间横向
                FillHorCell(23, 22, i)
            Case "170182"   '中间横向
                FillHorCell(25, 22, i)
            Case "170384"   '中间横向
                FillHorCell(27, 22, i)
            Case "170382"   '中间横向
                FillHorCell(29, 22, i)
            Case "170584"   '中间横向
                FillHorCell(31, 22, i)
            Case "170582"   '中间横向
                FillHorCell(33, 22, i)

            Case "170782"   '中间横向
                FillHorCell(36, 22, i)
            Case "170784"   '中间横向
                FillHorCell(38, 22, i)
                '''
                '添加 MAIN DECK 贝19
                '''''
            Case "190882"   '中间横向
                FillHorCell(8, 20, i)
            Case "190884"   '中间横向
                FillHorCell(6, 20, i)

            Case "190684"   '中间横向
                FillHorCell(11, 20, i)
            Case "190682"   '中间横向
                FillHorCell(13, 20, i)
            Case "190484"   '中间横向
                FillHorCell(15, 20, i)
            Case "190482"   '中间横向
                FillHorCell(17, 20, i)
            Case "190284"   '中间横向
                FillHorCell(19, 20, i)
            Case "190282"   '中间横向
                FillHorCell(21, 20, i)
            Case "190184"   '中间横向
                FillHorCell(23, 20, i)
            Case "190182"   '中间横向
                FillHorCell(25, 20, i)
            Case "190384"   '中间横向
                FillHorCell(27, 20, i)
            Case "190382"   '中间横向
                FillHorCell(29, 20, i)
            Case "190584"   '中间横向
                FillHorCell(31, 20, i)
            Case "190582"   '中间横向
                FillHorCell(33, 20, i)

            Case "190782"   '中间横向
                FillHorCell(36, 20, i)
            Case "190784"   '中间横向
                FillHorCell(38, 20, i)
                '''
                '添加 MAIN DECK 贝21
                '''''
            Case "210684"   '中间横向
                FillHorCell(11, 17, i)
            Case "210682"   '中间横向
                FillHorCell(13, 17, i)
            Case "210484"   '中间横向
                FillHorCell(15, 17, i)
            Case "210482"   '中间横向
                FillHorCell(17, 17, i)
            Case "210284"   '中间横向
                FillHorCell(19, 17, i)
            Case "210282"   '中间横向
                FillHorCell(21, 17, i)
            Case "210184"   '中间横向
                FillHorCell(23, 17, i)
            Case "210182"   '中间横向
                FillHorCell(25, 17, i)
            Case "210384"   '中间横向
                FillHorCell(27, 17, i)
            Case "210382"   '中间横向
                FillHorCell(29, 17, i)
            Case "210584"   '中间横向
                FillHorCell(31, 17, i)
            Case "210582"   '中间横向
                FillHorCell(33, 17, i)
                '''
                '添加 MAIN DECK 贝23
                '''''
            Case "230882"   '中间横向
                FillHorCell(8, 15, i)
            Case "230884"   '中间横向
                FillHorCell(6, 15, i)

            Case "230684"   '中间横向
                FillHorCell(11, 15, i)
            Case "230682"   '中间横向
                FillHorCell(13, 15, i)
            Case "230484"   '中间横向
                FillHorCell(15, 15, i)
            Case "230482"   '中间横向
                FillHorCell(17, 15, i)
            Case "230284"   '中间横向
                FillHorCell(19, 15, i)
            Case "230282"   '中间横向
                FillHorCell(21, 15, i)
            Case "230184"   '中间横向
                FillHorCell(23, 15, i)
            Case "230182"   '中间横向
                FillHorCell(25, 15, i)
            Case "230384"   '中间横向
                FillHorCell(27, 15, i)
            Case "230382"   '中间横向
                FillHorCell(29, 15, i)
            Case "230584"   '中间横向
                FillHorCell(31, 15, i)
            Case "230582"   '中间横向
                FillHorCell(33, 15, i)

            Case "230782"   '中间横向
                FillHorCell(36, 15, i)
            Case "230784"   '中间横向
                FillHorCell(38, 15, i)
                '''
                '添加 MAIN DECK 贝25
                '''''
            Case "250882"   '中间横向
                FillHorCell(8, 13, i)
            Case "250884"   '中间横向
                FillHorCell(6, 13, i)

            Case "250684"   '中间横向
                FillHorCell(11, 13, i)
            Case "250682"   '中间横向
                FillHorCell(13, 13, i)
            Case "250484"   '中间横向
                FillHorCell(15, 13, i)
            Case "250482"   '中间横向
                FillHorCell(17, 13, i)
            Case "250284"   '中间横向
                FillHorCell(19, 13, i)
            Case "250282"   '中间横向
                FillHorCell(21, 13, i)
            Case "250184"   '中间横向
                FillHorCell(23, 13, i)
            Case "250182"   '中间横向
                FillHorCell(25, 13, i)
            Case "250384"   '中间横向
                FillHorCell(27, 13, i)
            Case "250382"   '中间横向
                FillHorCell(29, 13, i)
            Case "250584"   '中间横向
                FillHorCell(31, 13, i)
            Case "250582"   '中间横向
                FillHorCell(33, 13, i)

            Case "250782"   '中间横向
                FillHorCell(36, 13, i)
            Case "250784"   '中间横向
                FillHorCell(38, 13, i)

        End Select
    End Sub
    '填写CarDeck面图单元格
    Public Shared Sub FillCarDeckCell(ByVal i As Integer)
        Select Case TongBayNo(c1dbg.Columns("BayNo").CellText(i))
            '''
            '添加 CAR DECK 贝5
            '''''
        Case "050410"   '中间横向
                FillHorCell(42, 35, i)
            Case "050210"   '中间横向
                FillHorCell(44, 35, i)
            Case "050010"   '中间横向
                FillHorCell(46, 35, i)
            Case "050110"   '中间横向
                FillHorCell(48, 35, i)
            Case "050310"   '中间横向
                FillHorCell(50, 35, i)
                '''
                '添加 CAR DECK 贝7
                '''''
            Case "070410"   '中间横向
                FillHorCell(42, 32, i)
            Case "070210"   '中间横向
                FillHorCell(44, 32, i)
            Case "070010"   '中间横向
                FillHorCell(46, 32, i)
            Case "070110"   '中间横向
                FillHorCell(48, 32, i)
            Case "070310"   '中间横向
                FillHorCell(50, 32, i)
                '''
                '添加 CAR DECK 贝9
                '''''
            Case "090410"   '中间横向
                FillHorCell(42, 30, i)
            Case "090210"   '中间横向
                FillHorCell(44, 30, i)
            Case "090010"   '中间横向
                FillHorCell(46, 30, i)
            Case "090110"   '中间横向
                FillHorCell(48, 30, i)
            Case "090310"   '中间横向
                FillHorCell(50, 30, i)

                '''
                '添加 CAR DECK 贝15
                '''''
            Case "150410"   '中间横向
                FillHorCell(42, 24, i)
            Case "150210"   '中间横向
                FillHorCell(44, 24, i)
            Case "150010"   '中间横向
                FillHorCell(46, 24, i)
            Case "150110"   '中间横向
                FillHorCell(48, 24, i)
            Case "150310"   '中间横向
                FillHorCell(50, 24, i)
                '''
                '添加 CAR DECK 贝17
                '''''
            Case "170410"   '中间横向
                FillHorCell(42, 22, i)
            Case "170210"   '中间横向
                FillHorCell(44, 22, i)
            Case "170010"   '中间横向
                FillHorCell(46, 22, i)
            Case "170110"   '中间横向
                FillHorCell(48, 22, i)
            Case "170310"   '中间横向
                FillHorCell(50, 22, i)
                '''
                '添加 CAR DECK 贝19
                '''''
            Case "190410"   '中间横向
                FillHorCell(42, 20, i)
            Case "190210"   '中间横向
                FillHorCell(44, 20, i)
            Case "190010"   '中间横向
                FillHorCell(46, 20, i)
            Case "190110"   '中间横向
                FillHorCell(48, 20, i)
            Case "190310"   '中间横向
                FillHorCell(50, 20, i)
                '''
                '添加 CAR DECK 贝21
                '''''
            Case "210410"   '中间横向
                FillHorCell(42, 17, i)
            Case "210210"   '中间横向
                FillHorCell(44, 17, i)
            Case "210010"   '中间横向
                FillHorCell(46, 17, i)
            Case "210110"   '中间横向
                FillHorCell(48, 17, i)
            Case "210310"   '中间横向
                FillHorCell(50, 17, i)
                '''
                '添加 CAR DECK 贝23
                '''''
            Case "230410"   '中间横向
                FillHorCell(42, 15, i)
            Case "230210"   '中间横向
                FillHorCell(44, 15, i)
            Case "230010"   '中间横向
                FillHorCell(46, 15, i)
            Case "230110"   '中间横向
                FillHorCell(48, 15, i)
            Case "230310"   '中间横向
                FillHorCell(50, 15, i)
                '''
                '添加 CAR DECK 贝25
                '''''
            Case "250410"   '中间横向
                FillHorCell(42, 13, i)
            Case "250210"   '中间横向
                FillHorCell(44, 13, i)
            Case "250010"   '中间横向
                FillHorCell(46, 13, i)
            Case "250110"   '中间横向
                FillHorCell(48, 13, i)
            Case "250310"   '中间横向
                FillHorCell(50, 13, i)

        End Select
    End Sub
    '填写FreeBoardDeck面图单元格
    Public Shared Sub FillFreeBoardDeckCell(ByVal i As Integer)
        Select Case TongBayNo(c1dbg.Columns("BayNo").CellText(i))
            '''
            '添加 FREEBOARD DECK 贝5
            '''''
        Case "050408"   '中间横向
                FillHorCell(54, 35, i)
            Case "050406"   '中间横向
                FillHorCell(56, 35, i)
            Case "050208"   '中间横向
                FillHorCell(58, 35, i)
            Case "050206"   '中间横向
                FillHorCell(60, 35, i)
            Case "050008"   '中间横向
                FillHorCell(62, 35, i)
            Case "050006"   '中间横向
                FillHorCell(64, 35, i)
            Case "050108"   '中间横向
                FillHorCell(66, 35, i)
            Case "050106"   '中间横向
                FillHorCell(68, 35, i)
            Case "050308"   '中间横向
                FillHorCell(70, 35, i)
            Case "050306"   '中间横向
                FillHorCell(72, 35, i)
                '''
                '添加 FREEBOARD DECK 贝7
                '''''
            Case "070408"   '中间横向
                FillHorCell(54, 32, i)
            Case "070406"   '中间横向
                FillHorCell(56, 32, i)
            Case "070208"   '中间横向
                FillHorCell(58, 32, i)
            Case "070206"   '中间横向
                FillHorCell(60, 32, i)
            Case "070008"   '中间横向
                FillHorCell(62, 32, i)
            Case "070006"   '中间横向
                FillHorCell(64, 32, i)
            Case "070108"   '中间横向
                FillHorCell(66, 32, i)
            Case "070106"   '中间横向
                FillHorCell(68, 32, i)
            Case "070308"   '中间横向
                FillHorCell(70, 32, i)
            Case "070306"   '中间横向
                FillHorCell(72, 32, i)
                '''
                '添加 FREEBOARD DECK 贝9
                '''''
            Case "090408"   '中间横向
                FillHorCell(54, 30, i)
            Case "090406"   '中间横向
                FillHorCell(56, 30, i)
            Case "090208"   '中间横向
                FillHorCell(58, 30, i)
            Case "090206"   '中间横向
                FillHorCell(60, 30, i)
            Case "090008"   '中间横向
                FillHorCell(62, 30, i)
            Case "090006"   '中间横向
                FillHorCell(64, 30, i)
            Case "090108"   '中间横向
                FillHorCell(66, 30, i)
            Case "090106"   '中间横向
                FillHorCell(68, 30, i)
            Case "090308"   '中间横向
                FillHorCell(70, 30, i)
            Case "090306"   '中间横向
                FillHorCell(72, 30, i)
                '''
                '添加 FREEBOARD DECK 贝15
                '''''
            Case "150408"   '中间横向
                FillHorCell(54, 24, i)
            Case "150406"   '中间横向
                FillHorCell(56, 24, i)
            Case "150208"   '中间横向
                FillHorCell(58, 24, i)
            Case "150206"   '中间横向
                FillHorCell(60, 24, i)
            Case "150008"   '中间横向
                FillHorCell(62, 24, i)
            Case "150006"   '中间横向
                FillHorCell(64, 24, i)
            Case "150108"   '中间横向
                FillHorCell(66, 24, i)
            Case "150106"   '中间横向
                FillHorCell(68, 24, i)
            Case "150308"   '中间横向
                FillHorCell(70, 24, i)
            Case "150306"   '中间横向
                FillHorCell(72, 24, i)
                '''
                '添加 FREEBOARD DECK 贝17
                '''''
            Case "170408"   '中间横向
                FillHorCell(54, 22, i)
            Case "170406"   '中间横向
                FillHorCell(56, 22, i)
            Case "170208"   '中间横向
                FillHorCell(58, 22, i)
            Case "170206"   '中间横向
                FillHorCell(60, 22, i)
            Case "170008"   '中间横向
                FillHorCell(62, 22, i)
            Case "170006"   '中间横向
                FillHorCell(64, 22, i)
            Case "170108"   '中间横向
                FillHorCell(66, 22, i)
            Case "170106"   '中间横向
                FillHorCell(68, 22, i)
            Case "170308"   '中间横向
                FillHorCell(70, 22, i)
            Case "170306"   '中间横向
                FillHorCell(72, 22, i)
                '''
                '添加 FREEBOARD DECK 贝19
                '''''
            Case "190408"   '中间横向
                FillHorCell(54, 20, i)
            Case "190406"   '中间横向
                FillHorCell(56, 20, i)
            Case "190208"   '中间横向
                FillHorCell(58, 20, i)
            Case "190206"   '中间横向
                FillHorCell(60, 20, i)
            Case "090008"   '中间横向
                FillHorCell(62, 20, i)
            Case "190006"   '中间横向
                FillHorCell(64, 20, i)
            Case "190108"   '中间横向
                FillHorCell(66, 20, i)
            Case "190106"   '中间横向
                FillHorCell(68, 20, i)
            Case "190308"   '中间横向
                FillHorCell(70, 20, i)
            Case "190306"   '中间横向
                FillHorCell(72, 20, i)
                '''
                '添加 FREEBOARD DECK 贝21
                '''''
            Case "210408"   '中间横向
                FillHorCell(54, 17, i)
            Case "210406"   '中间横向
                FillHorCell(56, 17, i)
            Case "210208"   '中间横向
                FillHorCell(58, 17, i)
            Case "210206"   '中间横向
                FillHorCell(60, 17, i)
            Case "210008"   '中间横向
                FillHorCell(62, 17, i)
            Case "210006"   '中间横向
                FillHorCell(64, 17, i)
            Case "210108"   '中间横向
                FillHorCell(66, 17, i)
            Case "210106"   '中间横向
                FillHorCell(68, 17, i)
            Case "210308"   '中间横向
                FillHorCell(70, 17, i)
            Case "210306"   '中间横向
                FillHorCell(72, 17, i)
                '''
                '添加 FREEBOARD DECK 贝23
                '''''
            Case "230408"   '中间横向
                FillHorCell(54, 15, i)
            Case "230406"   '中间横向
                FillHorCell(56, 15, i)
            Case "230208"   '中间横向
                FillHorCell(58, 15, i)
            Case "230206"   '中间横向
                FillHorCell(60, 15, i)
            Case "070008"   '中间横向
                FillHorCell(62, 15, i)
            Case "230006"   '中间横向
                FillHorCell(64, 15, i)
            Case "230108"   '中间横向
                FillHorCell(66, 15, i)
            Case "230106"   '中间横向
                FillHorCell(68, 15, i)
            Case "230308"   '中间横向
                FillHorCell(70, 15, i)
            Case "230306"   '中间横向
                FillHorCell(72, 15, i)
                '''
                '添加 FREEBOARD DECK 贝25
                '''''
            Case "250408"   '中间横向
                FillHorCell(54, 13, i)
            Case "250406"   '中间横向
                FillHorCell(56, 13, i)
            Case "250208"   '中间横向
                FillHorCell(58, 13, i)
            Case "250206"   '中间横向
                FillHorCell(60, 13, i)
            Case "250008"   '中间横向
                FillHorCell(62, 13, i)
            Case "250006"   '中间横向
                FillHorCell(64, 13, i)
            Case "250108"   '中间横向
                FillHorCell(66, 13, i)
            Case "250106"   '中间横向
                FillHorCell(68, 13, i)
            Case "250308"   '中间横向
                FillHorCell(70, 13, i)
            Case "250306"   '中间横向
                FillHorCell(72, 13, i)

        End Select
    End Sub
    '填写LowerHold面图单元格
    Public Shared Sub FillLowerHoldCell(ByVal i As Integer)
        Select Case TongBayNo(c1dbg.Columns("BayNo").CellText(i))
            '''
            '添加 LOWER DECK 贝5
            '''''
        Case "050404"   '中间横向
                FillHorCell(76, 35, i)
            Case "050402"   '中间横向
                FillHorCell(78, 35, i)
            Case "050204"   '中间横向
                FillHorCell(80, 35, i)
            Case "050202"   '中间横向
                FillHorCell(82, 35, i)
            Case "050004"   '中间横向
                FillHorCell(84, 35, i)
            Case "050002"   '中间横向
                FillHorCell(86, 35, i)
            Case "050104"   '中间横向
                FillHorCell(88, 35, i)
            Case "050102"   '中间横向
                FillHorCell(90, 35, i)
            Case "050304"   '中间横向
                FillHorCell(92, 35, i)
            Case "050302"   '中间横向
                FillHorCell(94, 35, i)
                '''
                '添加 LOWER DECK 贝7
                '''''
            Case "070404"   '中间横向
                FillHorCell(76, 32, i)
            Case "070402"   '中间横向
                FillHorCell(78, 32, i)
            Case "070204"   '中间横向
                FillHorCell(80, 32, i)
            Case "070202"   '中间横向
                FillHorCell(82, 32, i)
            Case "070004"   '中间横向
                FillHorCell(84, 32, i)
            Case "070002"   '中间横向
                FillHorCell(86, 32, i)
            Case "070104"   '中间横向
                FillHorCell(88, 32, i)
            Case "070102"   '中间横向
                FillHorCell(90, 32, i)
            Case "070304"   '中间横向
                FillHorCell(92, 32, i)
            Case "070302"   '中间横向
                FillHorCell(94, 32, i)
                '''
                '添加 LOWER DECK 贝9
                '''''
            Case "090404"   '中间横向
                FillHorCell(76, 30, i)
            Case "090402"   '中间横向
                FillHorCell(78, 30, i)
            Case "090204"   '中间横向
                FillHorCell(80, 30, i)
            Case "090202"   '中间横向
                FillHorCell(82, 30, i)
            Case "090004"   '中间横向
                FillHorCell(84, 30, i)
            Case "090002"   '中间横向
                FillHorCell(86, 30, i)
            Case "090104"   '中间横向
                FillHorCell(88, 30, i)
            Case "090102"   '中间横向
                FillHorCell(90, 30, i)
            Case "090304"   '中间横向
                FillHorCell(92, 30, i)
            Case "090302"   '中间横向
                FillHorCell(94, 30, i)
                '''
                '添加 LOWER DECK 贝15
                '''''
            Case "150404"   '中间横向
                FillHorCell(76, 24, i)
            Case "150402"   '中间横向
                FillHorCell(78, 24, i)
            Case "150204"   '中间横向
                FillHorCell(80, 24, i)
            Case "150202"   '中间横向
                FillHorCell(82, 24, i)
            Case "150004"   '中间横向
                FillHorCell(84, 24, i)
            Case "150002"   '中间横向
                FillHorCell(86, 24, i)
            Case "150104"   '中间横向
                FillHorCell(88, 24, i)
            Case "150102"   '中间横向
                FillHorCell(90, 24, i)
            Case "150304"   '中间横向
                FillHorCell(92, 24, i)
            Case "150302"   '中间横向
                FillHorCell(94, 24, i)
                '''
                '添加 LOWER DECK 贝17
                '''''
            Case "170404"   '中间横向
                FillHorCell(76, 22, i)
            Case "170402"   '中间横向
                FillHorCell(78, 22, i)
            Case "170204"   '中间横向
                FillHorCell(80, 22, i)
            Case "170202"   '中间横向
                FillHorCell(82, 22, i)
            Case "170004"   '中间横向
                FillHorCell(84, 22, i)
            Case "170002"   '中间横向
                FillHorCell(86, 22, i)
            Case "170104"   '中间横向
                FillHorCell(88, 22, i)
            Case "170102"   '中间横向
                FillHorCell(90, 22, i)
            Case "170304"   '中间横向
                FillHorCell(92, 22, i)
            Case "170302"   '中间横向
                FillHorCell(94, 22, i)
                '''
                '添加 LOWER DECK 贝19
                '''''
            Case "190404"   '中间横向
                FillHorCell(76, 20, i)
            Case "190402"   '中间横向
                FillHorCell(78, 20, i)
            Case "190204"   '中间横向
                FillHorCell(80, 20, i)
            Case "190202"   '中间横向
                FillHorCell(82, 20, i)
            Case "190004"   '中间横向
                FillHorCell(84, 20, i)
            Case "190002"   '中间横向
                FillHorCell(86, 20, i)
            Case "190104"   '中间横向
                FillHorCell(88, 20, i)
            Case "190102"   '中间横向
                FillHorCell(90, 20, i)
            Case "190304"   '中间横向
                FillHorCell(92, 20, i)
            Case "190302"   '中间横向
                FillHorCell(94, 20, i)
                '''
                '添加 LOWER DECK 贝21
                '''''
            Case "210404"   '中间横向
                FillHorCell(76, 17, i)
            Case "210402"   '中间横向
                FillHorCell(78, 17, i)
            Case "210204"   '中间横向
                FillHorCell(80, 17, i)
            Case "210202"   '中间横向
                FillHorCell(82, 17, i)
            Case "210004"   '中间横向
                FillHorCell(84, 17, i)
            Case "210002"   '中间横向
                FillHorCell(86, 17, i)
            Case "210104"   '中间横向
                FillHorCell(88, 17, i)
            Case "210102"   '中间横向
                FillHorCell(90, 17, i)
            Case "210304"   '中间横向
                FillHorCell(92, 17, i)
            Case "210302"   '中间横向
                FillHorCell(94, 17, i)
                '''
                '添加 LOWER DECK 贝23
                '''''
            Case "230404"   '中间横向
                FillHorCell(76, 15, i)
            Case "230402"   '中间横向
                FillHorCell(78, 15, i)
            Case "230204"   '中间横向
                FillHorCell(80, 15, i)
            Case "230202"   '中间横向
                FillHorCell(82, 15, i)
            Case "230004"   '中间横向
                FillHorCell(84, 15, i)
            Case "230002"   '中间横向
                FillHorCell(86, 15, i)
            Case "230104"   '中间横向
                FillHorCell(88, 15, i)
            Case "230102"   '中间横向
                FillHorCell(90, 15, i)
            Case "230304"   '中间横向
                FillHorCell(92, 15, i)
            Case "230302"   '中间横向
                FillHorCell(94, 15, i)
                '''
                '添加 LOWER DECK 贝25
                '''''
            Case "250404"   '中间横向
                FillHorCell(76, 13, i)
            Case "250402"   '中间横向
                FillHorCell(78, 13, i)
            Case "250204"   '中间横向
                FillHorCell(80, 13, i)
            Case "250202"   '中间横向
                FillHorCell(82, 13, i)
            Case "250004"   '中间横向
                FillHorCell(84, 13, i)
            Case "250002"   '中间横向
                FillHorCell(86, 13, i)
            Case "250104"   '中间横向
                FillHorCell(88, 13, i)
            Case "250102"   '中间横向
                FillHorCell(90, 13, i)
            Case "250304"   '中间横向
                FillHorCell(92, 13, i)
            Case "250302"   '中间横向
                FillHorCell(94, 13, i)
        End Select
    End Sub
End Class
