Imports System.Data
Imports System.Data.OleDb
Imports Oracle.DataAccess.Client ' ODP.NET Oracle managed provider
Imports Oracle.DataAccess.Types
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.IO


Public Class FSearchGcent

    Private Sub BSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSearch.Click
        FSearch.MSTSearch.Text = TBCase.Text

        FSearch.Research(0)

    End Sub

    'Private Sub SqlBlob2File(ByVal DestFilePath As String)
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

        Dim PictureCol As Integer = 0 ' the column # of the BLOB field

        Dim myCommand As OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim Oradb As String = "Provider=OraOLEDB.Oracle.1;Password=READCQUEST;Persist Security Info=True;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1;"

        Dim conn As New OleDb.OleDbConnection(Oradb) 'OracleConnection(oradb)

        'Dim cn As New SqlConnection("Provider=OraOLEDB.Oracle.1;Password=READCQUEST;Persist Security Info=True;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1;")
        Dim cmd As String = "select atb.data   from cqcentral.anomalie         Ta,        cqcentral.attachments      Tat,        cqcentral.attachments_blob atb  where Ta.dbid = Tat.entity_dbid(+)  and Tat.dbid = atb.attachments_dbid    and Ta.numerofiche = 'GCENT15070806'"
        'Dim DestFilePath As String = "C:\test.doc"
        Dim DestFilePath As String = "c:\tempSearch\MyTest.xlsx"

        conn.Open()
        'myCommand.Open()
        myCommand = New OleDb.OleDbCommand(cmd, conn)

        'Dim dr As SqlDataReader = cmd.ExecuteReader()
        dr = myCommand.ExecuteReader()
        dr.Read()
        Dim b(dr.GetBytes(PictureCol, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
        dr.GetBytes(PictureCol, 0, b, 0, b.Length)
        dr.Close()
        conn.Close()
        Dim fs As New System.IO.FileStream(DestFilePath, IO.FileMode.Create, IO.FileAccess.Write)
        fs.Write(b, 0, b.Length)
        fs.Close()
    End Sub

    Function RequestCQ(ByVal Card As String) As String

        Dim Request As String
        Dim CQbase As String



        CQbase = "cqcentral"

        If InStr(Card, "GTOP") > 0 Then
            CQbase = "cqgtop"
        End If
        If InStr(Card, "GADMI") > 0 Then
            CQbase = "cqgadmin"
        End If
        If InStr(Card, "GSTOC") > 0 Then
            CQbase = "CQGOLDSTOCK"
        End If
        If InStr(Card, "GTRAC") > 0 Then
            CQbase = "cqgtrack"
        End If
        If InStr(Card, "GCAS") > 0 Then
            CQbase = "cqcas"
        End If
        If InStr(Card, "GEVEN") > 0 Then
            CQbase = "CQGOLDEVENTS"
        End If


        Request = " select Ta.numerofiche,"             '0
        Request = Request & " Ta.titre,"                '1
        Request = Request & "Ts.name,"                  '2
        Request = Request & "Ta.NUMEROREFERENCE,"       '3
        Request = Request & "Tu.login_name,"            '4
        Request = Request & "Tc.nom,"                   '5
        Request = Request & "Ta.label,"                 '6
        Request = Request & "Tp.NOM Produit,"           '7
        Request = Request & "Ta.dateplanifauplustot + 2/24,"    '8
        Request = Request & "Ta.RETROFITCARD retrofit,"         '9
        Request = Request & "Td.name,"                  '10
        Request = Request & "Tdr.name,"                 '11
        Request = Request & "Ta.dateplanifauplustard_1 + 2/24," '12
        Request = Request & "Ta.reportfiche,"           '13
        Request = Request & "Ta.id,"                    '14
        Request = Request & "Tr.nom,"                 '15
        Request = Request & "Ta.typereference,"         '16
        Request = Request & "Ta.numeroreference,"       '17
        Request = Request & "to_char(Th.action_timestamp, 'DD/MM/YY') OPENING_DATE, "   '18
        Request = Request & "Ta.SEVERITE, "             '19
        Request = Request & "Ta.LOGS, "                 '20
        Request = Request & "Tr.nom, "                '21
        Request = Request & "Ta.FLDCOLUMN_1, "          '22
        Request = Request & "Ta.expectedcorrectiondate, "       '23
        Request = Request & "Ta.Description2, "         '24
        Request = Request & "Ta.FUNCTIONALDESCRIPTION, "        '25
        Request = Request & "Ta.MODIFICATIONDESCRIPTION, "      '26
        Request = Request & "Ta.SOURCESMODIFIES, "      '27
        Request = Request & "Tu2.login_name, "          '28
        Request = Request & "Tvo.name,  "               '29

        Request = Request & "replace(substr((select SUBSTR(replace(Tvo.name,'/','\'), 1, INSTR(Tvo.name, '@')) AS gauche from dual), INSTR((select SUBSTR(replace(Tvo.name,'/','\'), 1, INSTR(Tvo.name, '@')) AS gauche from dual),'\',-1) + 1),'@',''), "  '30
        Request = Request & "Ta.urgence,  "             '31
        Request = Request & "Ta.dbid,  "                 '32
        Request = Request & "ta.identificationexterne, " '33
        'Request = Request & "ta.originpatch, " '33
        Request = Request & "ta.datelivraisoninterne, "  '34
        Request = Request & "ta.internalstate "  '35
        Request = Request & "from "
        Request = Request & CQbase & ".anomalie     Ta,"
        Request = Request & CQbase & ".statedef     Ts,"
        Request = Request & CQbase & ".client       Tc,"
        Request = Request & CQbase & ".subproduct   Td,"
        Request = Request & CQbase & ".domainrecord Tdr,"
        Request = Request & CQbase & ".users        Tu,"
        Request = Request & CQbase & ".users        Tu2,"
        Request = Request & CQbase & ".produit      Tp,"
        Request = Request & CQbase & ".History      Th, "
        Request = Request & CQbase & ".cc_change_set      Tcs,"
        Request = Request & CQbase & ".cc_vob_object      Tvo, "
        Request = Request & CQbase & ".parent_child_links Tpcl, "
        Request = Request & CQbase & ".rfe                Tr "
        Request = Request & "where(Ta.state = Ts.id) "
        Request = Request & "and Ta.assigne = Tu.dbid "
        Request = Request & "and Ta.chefprojet = Tu2.dbid "
        Request = Request & "and Ta.PRODUIT_1 = Tp.dbid "
        Request = Request & "and Ta.client_champ = Tc.dbid "
        Request = Request & "and Ta.Domain_1 = Tdr.dbid "
        Request = Request & "and Ta.subproduct = Td.dbid "
        Request = Request & "and Ta.DBID = Th.entity_dbid "
        Request = Request & "and Th.action_name = 'Ouvrir' "
        Request = Request & "and Ta.cc_change_set = Tcs.dbid "
        Request = Request & "and Tcs.dbid = Tpcl.parent_dbid(+) "
        Request = Request & "and 16778186 = Tpcl.parent_fielddef_id(+) "
        Request = Request & "and Tpcl.child_dbid = Tvo.dbid(+) "
        Request = Request & "and Ta.rfecode = Tr.dbid "
        Request = Request & "and Ta.numerofiche = '" + Card + "'"

        RequestCQ = Request

    End Function
    Function RequestCQDoc(ByVal Card As String) As String

        Dim Request As String
        Dim CQbase As String

        CQbase = "cqcentral"

        If InStr(Card, "GTOP") > 0 Then
            CQbase = "cqgtop"
        End If
        If InStr(Card, "GADMI") > 0 Then
            CQbase = "cqgadmin"
        End If

        If InStr(Card, "GSTOC") > 0 Then
            CQbase = "CQGOLDSTOCK"
        End If
        If InStr(Card, "GTRAC") > 0 Then
            CQbase = "cqgtrack"
        End If
        If InStr(Card, "GCAS") > 0 Then
            CQbase = "cqcas"
        End If
        If InStr(Card, "GEVEN") > 0 Then
            CQbase = "CQGOLDEVENTS"
        End If

        Request = " select Ta.numerofiche, Tat.filename from "
        Request = Request & CQbase & ".anomalie     Ta,"
        Request = Request & CQbase & ".attachments      Tat "
        Request = Request & "where Ta.dbid = Tat.entity_dbid(+) "
        Request = Request & "and Ta.numerofiche = '" + Card + "' "
        Request = Request & "order by tat.dbid "


        RequestCQDoc = Request

    End Function
    Function RequestGlib(ByVal Card As String) As String

        Dim Request As String

        Request = "select Ta.numerofiche,"
        Request = Request & " Ta.titre,"
        Request = Request & " Ts.name,"
        Request = Request & " Tu.login_name,"
        Request = Request & " Ta.dateplanifauplustot + 2 / 24,"
        Request = Request & " Ta.dateplanifauplustard_1 + 2 / 24,"
        Request = Request & " Ta.id,"
        Request = Request & " to_char(Th.action_timestamp, 'DD/MM/YY') OPENING_DATE,"
        Request = Request & " Ta.Description2,"
        Request = Request & " Ta.severity,"
        Request = Request & " ta.fldcolumn,"
        Request = Request & " ta.numversion,"
        Request = Request & " tm.nom,"
        Request = Request & " ta.fermeturedoublon, ta.fermeturepaspb, ta.fermeturerejetee, ta.fermeturelivree, ta.otherversion, ta.ref_card, ta.ref_case, ta.framework, Ta.dbid"
        Request = Request & " from cqglib.anomalie     Ta,"
        Request = Request & " cqglib.statedef     Ts,"
        Request = Request & " cqglib.users        Tu,"
        Request = Request & " cqglib.History      Th,"
        Request = Request & " cqglib.modulerecord tm"
        Request = Request & " where(Ta.state = Ts.id)"
        Request = Request & " and ta.modulechamp = tm.dbid"
        Request = Request & " and Ta.assigne = Tu.dbid"
        Request = Request & " and Ta.DBID = Th.entity_dbid"
        Request = Request & " and Th.action_name = 'Ouvrir'"
        Request = Request & " and Ta.numerofiche = '" + Card + "'"




        RequestGlib = Request

    End Function

    Function RequestGcentHistory(ByVal Card As String) As String

        Dim CQbase As String

        CQbase = "cqcentral"

        If InStr(Card, "GTOP") > 0 Then
            CQbase = "cqgtop"
        End If
        If InStr(Card, "GADMI") > 0 Then
            CQbase = "cqgadmin"
        End If

        If InStr(Card, "GSTOC") > 0 Then
            CQbase = "CQGOLDSTOCK"
        End If
        If InStr(Card, "GTRAC") > 0 Then
            CQbase = "cqgtrack"
        End If
        If InStr(Card, "GCAS") > 0 Then
            CQbase = "cqcas"
        End If
        If InStr(Card, "GEVEN") > 0 Then
            CQbase = "CQGOLDEVENTS"
        End If

        RequestGcentHistory = "select distinct T1.DBID,"
        RequestGcentHistory = RequestGcentHistory & " T1.action_timestamp,"
        RequestGcentHistory = RequestGcentHistory & " T1.user_name,"
        RequestGcentHistory = RequestGcentHistory & " T1.action_name,"
        RequestGcentHistory = RequestGcentHistory & " T1.old_state,"
        RequestGcentHistory = RequestGcentHistory & " T1.new_state from "
        RequestGcentHistory = RequestGcentHistory & CQbase & ".history T1, "
        RequestGcentHistory = RequestGcentHistory & CQbase & ".anomalie a"
        RequestGcentHistory = RequestGcentHistory & " where a.dbid = T1.entity_dbid"
        RequestGcentHistory = RequestGcentHistory & " and a.numerofiche = '" + Card + "'"
        RequestGcentHistory = RequestGcentHistory & " and t1.entitydef_name <> 'cc_vob_object'"
        RequestGcentHistory = RequestGcentHistory & " and t1.entitydef_name <> 'cc_change_set'"
        RequestGcentHistory = RequestGcentHistory & "  order by 2 desc"
        'RequestGcentHistory = RequestGcentHistory & " and T1.Action_Timestamp > (select T2.action_timestamp"
        'RequestGcentHistory = RequestGcentHistory & " from cqcentral.history T2"
        'RequestGcentHistory = RequestGcentHistory & " where(a.dbid = T2.entity_dbid)"
        'RequestGcentHistory = RequestGcentHistory & " and T2.action_name = 'Ouvrir'"
        'RequestGcentHistory = RequestGcentHistory & " and rownum = 1)"
        'RequestGcentHistory = RequestGcentHistory & "  order by 2"

    End Function

    Function RequestGlibHistory(ByVal Card As String) As String

        RequestGlibHistory = "select distinct T1.DBID,"
        RequestGlibHistory = RequestGlibHistory & " T1.action_timestamp,"
        RequestGlibHistory = RequestGlibHistory & " T1.user_name,"
        RequestGlibHistory = RequestGlibHistory & " T1.action_name,"
        RequestGlibHistory = RequestGlibHistory & " T1.old_state,"
        RequestGlibHistory = RequestGlibHistory & " T1.new_state"
        RequestGlibHistory = RequestGlibHistory & " from cqglib.history T1, cqglib.anomalie a"
        RequestGlibHistory = RequestGlibHistory & " where a.dbid = T1.entity_dbid"
        RequestGlibHistory = RequestGlibHistory & " and a.numerofiche = '" + Card + "' order by 2"

    End Function

    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    Function GetGcentRetInfo(gcent As String) As String
        Dim CQbase As String

        CQbase = "cqcentral"

        If InStr(gcent, "GTOP") > 0 Then
            CQbase = "cqgtop"
        End If
        If InStr(gcent, "GADMI") > 0 Then
            CQbase = "cqgadmin"
        End If
        If InStr(gcent, "GSTOC") > 0 Then
            CQbase = "CQGOLDSTOCK"
        End If
        If InStr(gcent, "GTRAC") > 0 Then
            CQbase = "cqgtrack"
        End If
        If InStr(gcent, "GCAS") > 0 Then
            CQbase = "cqcas"
        End If
        If InStr(gcent, "GEVEN") > 0 Then
            CQbase = "CQGOLDEVENTS"
        End If

        GetGcentRetInfo = "select   s.name, a.label, a.numerofiche from  "
        GetGcentRetInfo = GetGcentRetInfo & CQbase & ".anomalie a,"
        GetGcentRetInfo = GetGcentRetInfo & CQbase & ".statedef s"
        GetGcentRetInfo = GetGcentRetInfo & " where a.State = s.ID"
        GetGcentRetInfo = GetGcentRetInfo & " and a.reportfiche like '%" + gcent + "%'"

    End Function
    Public Function researchCQ() As Integer
        'crmtest_MSCRM()
        'Provider=OraOLEDB.Oracle.1;Password=READCQUEST;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1
        'Dim oradb As String = "Data Source=seyccrmsqlsip1.fi;User Id=readcquest;Password=readcquest;"

        Dim myCommand As OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim Oradb As String = "Provider=OraOLEDB.Oracle.1;Password=READCQUEST;Persist Security Info=True;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1;"
        Dim GCENT As String
        Dim req As String
        'Data Source=myOracleServer;Persist Security Info=False";
        'Dim Oradb As String = "Data Source=CQSCM1_SEYCSMC1;User Id=readcquest;Password=readcquest;Provider=OraOLEDB.Oracle;OLEDB.NET=True;LazyLoad=1;"
        Dim conn As New OleDb.OleDbConnection(Oradb) 'OracleConnection(oradb)
        Dim pos As Integer
        'Dim oradb As String = "Data Source=CQSCM1_SEYCSMC1;User Id=readcquest;Password=readcquest;"
        'Dim conn As New OracleConnection(oradb)
        'Dim cmd As New OracleCommand
        'Dim dr As OracleDataReader
        Dim SqlConn2 As New OleDb.OleDbConnection(Oradb) 'OracleConnection(oradb)
        Dim SqlCmd2 As OleDb.OleDbCommand
        Dim myReader2 As OleDb.OleDbDataReader
        Dim nbrow2 As Integer
        Dim status As String
        Dim label As String
        Dim link As String
        ''GCENT17030635



        Me.TopMost = True
        Me.TopMost = False
        ' On vide
        GCENT = TBGcent.Text
        ClearTextBox(Me)
        'TBGcent.Text = GCENT

        'TBGcent.Text = ""
        TBTitle.Text = ""
        TBState.Text = ""
        TBCase.Text = ""
        TBAssigned.Text = ""
        TBCustomer.Text = ""
        TBLabel.Text = ""
        TBProduct.Text = ""
        TBIDD.Text = ""
        CBRetrofit.Checked = False
        TBDomain.Text = ""
        TBSubProduct.Text = "1"
        TBRDate.Text = ""
        TBRetCard.Text = ""
        TBSev.Text = ""
        RTBDOTI.Text = ""
        RTBLog.Text = ""
        'RTBad.Text = ""
        RTBDOTM.Text = ""
        RTBDesc.Text = ""
        RTBms.Text = ""
        CBGcent.Text = ""
        CBGcent.Items.Clear()

        conn.Open()

        'opening the connection
        Dim request As String = RequestCQ(Trim(GCENT))
        'request = "select 1 from dual"
        myCommand = New OleDb.OleDbCommand(request, conn)

        'executing the command and assigning it to connection
        dr = myCommand.ExecuteReader()

        'dr.Read()
        'dr.GetValue(0)
        'conn.Close()
        'conn.Open()
        '        cmd.Connection = conn
        'cmd.CommandText = "select titre from cqcentral.anomalie where numerofiche = '" + Me.MSTSearch.Text + "'"
        '        cmd.CommandText = RequestGcent(Trim(TBGcent.Text))

        '        cmd.CommandType = CommandType.Text

        '        dr = cmd.ExecuteReader()

        'If dr.Read() Then
        researchCQ = 0
        While dr.Read()
            LbTitle.Visible = True
            researchCQ = 1
            'Me.Size = New Size(776, 536)
            'pour lire la liste des sources modifées, on a un enregistrement par sources, il faut donc lire tous les enregistrements et ajouter à la liste
            'If dr.GetValue(0) <> TBGcent.Text Then
            TBGcent.Text = dr.GetValue(0)

            TBTitle.Text = dr.GetValue(1)
            TBState.Text = dr.GetValue(2)
            TBCase.Text = dr.GetValue(3)

            If dr.GetValue(4) IsNot DBNull.Value Then
                TBAssigned.Text = dr.GetValue(4)
            End If
            TBCustomer.Text = dr.GetValue(5)
            LbCustomer.Text = "Customer"
            If dr.GetValue(6) IsNot DBNull.Value Then
                LbLabel.Text = "Label"
                TBLabel.Text = dr.GetValue(6)
            End If
            TBProduct.Text = dr.GetValue(7)
            If dr.GetValue(8) IsNot DBNull.Value Then
                TBIDD.Text = dr.GetValue(8)
            End If
            If dr.GetValue(9) IsNot DBNull.Value Then
                CBRetrofit.Checked = dr.GetValue(9)
            End If

            If dr.GetValue(10) IsNot DBNull.Value Then
                TBSubProduct.Text = dr.Item(10)
            End If

            TBDomain.Text = dr.GetValue(11)

            If dr.GetValue(12) IsNot DBNull.Value Then
                TBRDate.Text = dr.GetValue(12)
            End If
            If dr.GetValue(13) IsNot DBNull.Value Then

                TBRetCard.Text = dr.GetValue(13)
            End If
            If dr.GetValue(19) IsNot DBNull.Value Then
                TBSev.Text = dr.GetValue(19)
            End If
            'log history
            If dr.GetValue(20) IsNot DBNull.Value Then
                RTBLog.Text = dr.GetValue(20)
            End If

            'code rfe
            If dr.GetValue(21) IsNot DBNull.Value Then
                TBRFE.Text = dr.GetValue(21)
            End If
            'Source to modify
            If dr.GetValue(22) IsNot DBNull.Value Then
                LBstom.Text = "Source to modify"
                TBstom.Text = dr.GetValue(22)
            End If
            'Estimated correction date
            If dr.GetValue(23) IsNot DBNull.Value Then
                LbECD.Text = "Estimated Correction Date"
                TBECD.Text = dr.GetValue(23)
            End If
            'Description
            If dr.GetValue(24) IsNot DBNull.Value Then
                RTBDesc.Text = dr.GetValue(24)
            End If
            'Description of the issue (for customers)
            If dr.GetValue(25) IsNot DBNull.Value Then
                RTBDOTI.Text = dr.GetValue(25)
            End If
            'Description des modifications
            If dr.GetValue(26) IsNot DBNull.Value Then
                RTBDOTM.Text = dr.GetValue(26)
            End If
            'Sources modifiées
            'If dr.GetValue(29) IsNot DBNull.Value Then
            ' RTBms.Text = dr.GetValue(29)
            'End If
            'Project Manager
            If dr.GetValue(28) IsNot DBNull.Value Then
                TBCP.Text = dr.GetValue(28)
            End If
            'urgence
            If dr.GetValue(31) IsNot DBNull.Value Then
                TBUrgence.Text = dr.GetValue(31)
            End If
            'link
            If dr.GetValue(32) IsNot DBNull.Value Then
                link = dr.GetValue(32)
                LbLink.Text = "http://seycscm1/cqweb/main?command=GenerateMainFrame&service=CQ&schema=cqaldata&contextid=GCENT&entityID=" + link + "&entityDefName=Anomalie"

            End If
            'Patch externe
            If dr.GetValue(33) IsNot DBNull.Value Then
                TBPatch.Text = dr.GetValue(33)
            End If
            'Delivery date
            If dr.GetValue(34) IsNot DBNull.Value Then
                TBDeliveryPatch.Text = dr.GetValue(34)
            End If
            If dr.GetValue(35) IsNot DBNull.Value Then
                If TBState.Text = "En_Attente" Then
                    TBState.Text = TBState.Text + " " + dr.GetValue(35)
                End If
            End If

            If dr.GetValue(29) IsNot DBNull.Value Then

                ' contiendra un nombre de caractère 


                pos = RTBms.Text.Length
                RTBms.AppendText(dr.GetValue(30)) ' on ajoute la chaine dans la richtextbox
                RTBms.AppendText(" :")
                RTBms.SelectionStart = pos 'on met le curseur juste avant la chaine rajouté
                RTBms.SelectionLength = dr.GetValue(30).Length 'On indique que le curseur sélectionnera la chaine jusqu'à la fin
                RTBms.SelectionColor = Color.Red 'on met la sélection en rouge
                'RTBms.SelectionFont = New Font("Comic Sans MS", 8) 'on change le font
                RTBms.AppendText(vbCrLf)
                RTBms.AppendText(dr.GetValue(29))
                RTBms.AppendText(vbCrLf)
                'RTBms.Text = RTBms.Text + vbCrLf + vbCrLf + dr.GetValue(30) + ":" + vbCrLf + dr.GetValue(29)
                'RTBms.Text = dr.GetValue(30) + vbCrLf + vbCrLf + dr.GetValue(29)
            End If


            'Else
            '    'on ajoute à la liste des sources modifiées
            '    If dr.GetValue(29) IsNot DBNull.Value Then
            '        'RTBms.Text = dr.GetValue(27) + ":" + vbCrLf + RTBms.Text + vbCrLf + vbCrLf + dr.GetValue(29)
            '        RTBms.Text = RTBms.Text + vbCrLf + vbCrLf + dr.GetValue(29)
            '    End If
            'End If
        End While



        conn.Close()
        conn.Dispose()

        '-----
        'on recherche les fiches de retrofits de cette fiche

        'on enrichie avec label et status de la fiche.
        SqlConn2.Open()
        If TBGcent.Text = "" Then
            'Throw New System.Exception("")
            Throw New Exception("Not a Case")
        End If

        req = GetGcentRetInfo(TBGcent.Text)
        SqlCmd2 = New OleDb.OleDbCommand(req, SqlConn2)
        SqlCmd2.CommandText = req
        myReader2 = SqlCmd2.ExecuteReader()

        nbrow2 = 0
        While myReader2.Read()

            status = myReader2.Item(0)

            If status = "Corrigée" Then
                status = "C"
            ElseIf status = "Ouverte" Then
                status = "O"
            ElseIf status = "Assignée" Then
                status = "A"
            ElseIf status = "En_qualification" Then
                status = "EQ"
            ElseIf status = "A_installer" Then
                status = "AI"
            ElseIf status = "En_Integration" Then
                status = "EI"
            ElseIf status = "A_Qualifier" Then
                status = "AQ"
            ElseIf status = "En_Attente" Then
                status = "EA"
            ElseIf status = "Being_Delivered" Then
                status = "BD"
            ElseIf status = "Analyse_Estimation_Impact" Then
                status = "AEI"
            ElseIf status = "Rejetée" Then
                status = "R"
            ElseIf status = "Codée" Then
                status = "C"
            ElseIf status = "Attente_approbation" Then
                status = "AA"
            ElseIf status = "Refusée" Then
                status = "Ref"
            ElseIf status = "Fermée" Then
                status = "F"
            End If


            label = ""
            If myReader2.Item(1) IsNot DBNull.Value Then
                label = myReader2.Item(1)
            End If

            TBGcentRet.Text = myReader2.Item(2)
            CBGcent.Text = myReader2.Item(2) + "  " + status + "  " + label
            CBGcent.Items.Add(myReader2.Item(2) + "  " + status + "  " + label)
            nbrow2 = nbrow2 + 1
            If nbrow2 > 1 Then
                CBGcent.ForeColor = Color.Red
            End If

        End While
        SqlConn2.Close()
        '-----



        'on cherche les documents associés
        conn = New OleDb.OleDbConnection(Oradb) 'OracleConnection(oradb)
        conn.Open()

        'opening the connection
        request = RequestCQDoc(Trim(GCENT))
        'request = "select 1 from dual"
        myCommand = New OleDb.OleDbCommand(request, conn)

        'executing the command and assigning it to connection
        dr = myCommand.ExecuteReader()

        ' While dr.Read()
        'Attached document
        ' If dr.GetValue(1) IsNot DBNull.Value Then
        ' RTBad.Text = RTBad.Text + vbCrLf + dr.GetValue(1)
        ' End If
        ' End While

        LVad.Items.Clear()

        While dr.Read()

            Dim LVIDoc As New ListViewItem(dr.GetValue(1).ToString)

            LbTitle.Visible = True
            'Me.Size = New Size(776, 700)


            LVIDoc.SubItems.Add(dr.GetValue(1).ToString)
            'LVITime.SubItems.Add(dr.GetValue(5).ToString)
            'LVITime.SubItems.Add(myReader.GetValue(4).ToString)

            LVad.Items.AddRange(New ListViewItem() {LVIDoc})


        End While

        If TBUrgence.Text = "High" And TBSev.Text = "Blocking" Then
            TBUrgence.ForeColor = Color.Red
            TBSev.ForeColor = Color.Red
        Else
            TBUrgence.ForeColor = Color.Black
            TBSev.ForeColor = Color.Black
        End If
        BGcentHistory()
    End Function

    Public Function researchGlib() As Integer
        'crmtest_MSCRM()
        'Provider=OraOLEDB.Oracle.1;Password=READCQUEST;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1
        'Dim oradb As String = "Data Source=seyccrmsqlsip1.fi;User Id=readcquest;Password=readcquest;"

        Dim myCommand As OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim Oradb As String = "Provider=OraOLEDB.Oracle.1;Password=READCQUEST;Persist Security Info=True;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1;"

        'Data Source=myOracleServer;Persist Security Info=False";
        'Dim Oradb As String = "Data Source=CQSCM1_SEYCSMC1;User Id=readcquest;Password=readcquest;Provider=OraOLEDB.Oracle;OLEDB.NET=True;LazyLoad=1;"
        Dim conn As New OleDb.OleDbConnection(Oradb) 'OracleConnection(oradb)

        'Dim oradb As String = "Data Source=CQSCM1_SEYCSMC1;User Id=readcquest;Password=readcquest;"
        'Dim conn As New OracleConnection(oradb)
        'Dim cmd As New OracleCommand
        'Dim dr As OracleDataReader

        Me.TopMost = True
        Me.TopMost = False

        'TBGcent.Text = ""
        TBTitle.Text = ""
        TBState.Text = ""
        TBCase.Text = ""
        TBAssigned.Text = ""
        TBCustomer.Text = ""
        TBLabel.Text = ""
        TBProduct.Text = ""
        TBIDD.Text = ""
        CBRetrofit.Checked = False
        TBDomain.Text = ""
        TBSubProduct.Text = "1"
        TBRDate.Text = ""
        TBRetCard.Text = ""
        TBSev.Text = ""
        RTBDOTI.Text = ""
        RTBLog.Text = ""
        'RTBad.Text = ""
        RTBDOTM.Text = ""
        RTBDesc.Text = ""
        RTBms.Text = ""

        conn.Open()

        'opening the connection
        Dim request As String = RequestGlib(Trim(TBGcent.Text))
        'request = "select 1 from dual"
        myCommand = New OleDb.OleDbCommand(request, conn)

        'executing the command and assigning it to connection
        dr = myCommand.ExecuteReader()
        researchGlib = 0
        If dr.Read() Then
            researchGlib = 1
            LbTitle.Visible = True
            'Me.Size = New Size(776, 536)
            TBGcent.Text = dr.GetValue(0)
            TBTitle.Text = dr.GetValue(1)
            TBState.Text = dr.GetValue(2)

            'If dr.GetValue(10) IsNot DBNull.Value Then
            '    TBCase.Text = dr.GetValue(10)
            'End If

            If dr.GetValue(3) IsNot DBNull.Value Then
                TBAssigned.Text = dr.GetValue(3)
            End If
            'TBCustomer.Text = dr.GetValue(5)
            'label
            If dr.GetValue(10) IsNot DBNull.Value Then
                LbLabel.Text = "References (Branch)"
                TBLabel.Text = dr.GetValue(10)
            End If
            'TBProduct.Text = dr.GetValue(7)
            If dr.GetValue(4) IsNot DBNull.Value Then
                TBIDD.Text = dr.GetValue(4)
            End If
            'If dr.GetValue(9) IsNot DBNull.Value Then
            '    CBRetrofit.Checked = dr.GetValue(9)
            'End If

            'TBDomain.Text = dr.GetValue(10)
            'TBSubProduct.Text = "1" 'dr.Item(11)

            If dr.GetValue(5) IsNot DBNull.Value Then
                TBRDate.Text = dr.GetValue(5)
            End If
            'If dr.GetValue(13) IsNot DBNull.Value Then
            '    TBRetCard.Text = dr.GetValue(13)
            'End If
            '
            'severité
            If dr.GetValue(9) IsNot DBNull.Value Then
                TBSev.Text = dr.GetValue(9)
            End If
            'log history
            'If dr.GetValue(20) IsNot DBNull.Value Then
            'RTBLog.Text = dr.GetValue(20)
            'End If
            ''code rfe
            'If dr.GetValue(21) IsNot DBNull.Value Then
            '    TBRFE.Text = dr.GetValue(21)
            'End If
            ''Source to modify
            'If dr.GetValue(22) IsNot DBNull.Value Then
            '    TBstom.Text = dr.GetValue(22)
            'End If
            ''Estimated correction date
            'If dr.GetValue(23) IsNot DBNull.Value Then
            'TBECD.Text = dr.GetValue(23)
            'End If
            'Description
            If dr.GetValue(8) IsNot DBNull.Value Then
                RTBDesc.Text = dr.GetValue(8)
            End If
            ''Description of the issue (for customers)
            'If dr.GetValue(25) IsNot DBNull.Value Then
            '    RTBDOTI.Text = dr.GetValue(25)
            'End If
            ''Description des modifications
            'If dr.GetValue(26) IsNot DBNull.Value Then
            '    RTBDOTM.Text = dr.GetValue(26)
            'End If
            ''Sources modifiées
            'If dr.GetValue(27) IsNot DBNull.Value Then
            '    RTBms.Text = dr.GetValue(27)
            'End If
            ''Sources modifiées
            'If dr.GetValue(28) IsNot DBNull.Value Then
            '    TBCP.Text = dr.GetValue(28)
            'End If
            If dr.GetValue(12) IsNot DBNull.Value Then
                LbCustomer.Text = "Framework"
                TBCustomer.Text = dr.GetValue(12)
            End If
            If dr.GetValue(11) IsNot DBNull.Value Then
                LBstom.Text = "Framework Version"
                TBstom.Text = dr.GetValue(11)
            ElseIf dr.GetValue(20) IsNot DBNull.Value Then
                LBstom.Text = "Framework Version Expected"
                TBstom.Text = dr.GetValue(20)
            End If
            'link
            If dr.GetValue(21) IsNot DBNull.Value Then
                Dim link As String = dr.GetValue(21)
                LbLink.Text = "http://seycscm1/cqweb/main?command=GenerateMainFrame&service=CQ&schema=cqaldata&contextid=GCENT&entityID=" + link + "&entityDefName=Anomalie"

            End If
            'fermerture motif
            LbECD.Text = "Close reason"
            Dim motif As String
            motif = ""
            If dr.GetValue(13) = 1 Then
                motif = "Doublon (Duplicated Card)"
            End If
            If dr.GetValue(14) = 1 Then
                motif = "Pas un Pb (Not a problem)"
            End If
            If dr.GetValue(15) = 1 Then
                motif = "Rejetée (Rejected)"
            End If
            If dr.GetValue(16) = 1 Then
                motif = "Corrigée (Fixed)"
            End If
            TBECD.Text = motif
            If dr.GetValue(17) IsNot DBNull.Value Then
                LbCP.Text = "Framework Other Versions"
                TBCP.Text = dr.GetValue(17)
            End If
            If dr.GetValue(18) IsNot DBNull.Value Then
                LbRetCard.Text = "GCENT linked"
                TBRetCard.Text = dr.GetValue(18)
            End If
            'case
            If dr.GetValue(19) IsNot DBNull.Value Then
                TBCase.Text = dr.GetValue(19)
            End If
        End If
        conn.Close()
        conn.Dispose()

        BGlibHistory()

    End Function

    'Private Sub BHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHistory.Click
    Private Sub BGcentHistory()
        Dim myCommand As OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim Oradb As String = "Provider=OraOLEDB.Oracle.1;Password=READCQUEST;Persist Security Info=True;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1;"

        'Data Source=myOracleServer;Persist Security Info=False";
        'Dim Oradb As String = "Data Source=CQSCM1_SEYCSMC1;User Id=readcquest;Password=readcquest;Provider=OraOLEDB.Oracle;OLEDB.NET=True;LazyLoad=1;"
        Dim conn As New OleDb.OleDbConnection(Oradb) 'OracleConnection(oradb)

        conn.Open()
        'opening the connection
        Dim request As String = RequestGcentHistory(Trim(TBGcent.Text))
        'request = "select 1 from dual"
        myCommand = New OleDb.OleDbCommand(request, conn)

        'executing the command and assigning it to connection
        dr = myCommand.ExecuteReader()

        'dr.Read()
        'dr.GetValue(0)
        'conn.Close()
        'conn.Open()
        '        cmd.Connection = conn
        'cmd.CommandText = "select titre from cqcentral.anomalie where numerofiche = '" + Me.MSTSearch.Text + "'"
        '        cmd.CommandText = RequestGcent(Trim(TBGcent.Text))

        '        cmd.CommandType = CommandType.Text

        '        dr = cmd.ExecuteReader()

        'If dr.Read() Then

        LVHistory.Items.Clear()

        While dr.Read()

            Dim LVITime As New ListViewItem(dr.GetValue(1).ToString)

            LbTitle.Visible = True
            'Me.Size = New Size(776, 700)


            LVITime.SubItems.Add(dr.GetValue(2).ToString)
            LVITime.SubItems.Add(dr.GetValue(3).ToString)
            LVITime.SubItems.Add(dr.GetValue(5).ToString)
            LVITime.SubItems.Add(dr.GetValue(4).ToString)

            LVHistory.Items.AddRange(New ListViewItem() {LVITime})

        End While
        'End If
        conn.Close()
        conn.Dispose()
    End Sub

    'Private Sub BHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHistory.Click
    Private Sub BGlibHistory()
        Dim myCommand As OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim Oradb As String = "Provider=OraOLEDB.Oracle.1;Password=READCQUEST;Persist Security Info=True;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1;"

        'Data Source=myOracleServer;Persist Security Info=False";
        'Dim Oradb As String = "Data Source=CQSCM1_SEYCSMC1;User Id=readcquest;Password=readcquest;Provider=OraOLEDB.Oracle;OLEDB.NET=True;LazyLoad=1;"
        Dim conn As New OleDb.OleDbConnection(Oradb) 'OracleConnection(oradb)

        conn.Open()
        'opening the connection
        Dim request As String = RequestGlibHistory(Trim(TBGcent.Text))
        'request = "select 1 from dual"
        myCommand = New OleDb.OleDbCommand(request, conn)

        'executing the command and assigning it to connection
        dr = myCommand.ExecuteReader()

        'dr.Read()
        'dr.GetValue(0)
        'conn.Close()
        'conn.Open()
        '        cmd.Connection = conn
        'cmd.CommandText = "select titre from cqcentral.anomalie where numerofiche = '" + Me.MSTSearch.Text + "'"
        '        cmd.CommandText = RequestGcent(Trim(TBGcent.Text))

        '        cmd.CommandType = CommandType.Text

        '        dr = cmd.ExecuteReader()

        'If dr.Read() Then

        LVHistory.Items.Clear()

        While dr.Read()

            Dim LVITime As New ListViewItem(dr.GetValue(1).ToString)

            LbTitle.Visible = True
            'Me.Size = New Size(776, 700)


            LVITime.SubItems.Add(dr.GetValue(2).ToString)
            LVITime.SubItems.Add(dr.GetValue(3).ToString)
            LVITime.SubItems.Add(dr.GetValue(5).ToString)
            LVITime.SubItems.Add(dr.GetValue(4).ToString)

            LVHistory.Items.AddRange(New ListViewItem() {LVITime})

        End While
        'End If
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        TBRetCard.Text = Replace(TBRetCard.Text, ",", "")
        FSearch.MSTSearch.Text = TBRetCard.Text
        FSearch.Research(0)
    End Sub

    Sub Mail(CaseN As String, Card As String, Customer As String, title As String)
        Dim OutMail As Object
        Dim OutApp As Object
        Dim ret As Integer
        Dim Subj As String


        If ret = 0 Then
            OutApp = CreateObject("Outlook.Application")
            OutMail = OutApp.CreateItem(0)
            Subj = "[" & Customer & "] " & CaseN & " " & Card


            With OutMail
                .To = ""
                .BCC = ""
                .Subject = Subj
                .HTMLBody = ""
                '.HTMLBody = RangetoHTMLPlanif(Card, CaseN, Customer, title)
                .Display()
            End With
        End If

    End Sub

    Function RangetoHTMLPlanif(gcent As String, CaseN As String, Cust As String, title As String)

        Dim fso As Object
        Dim ts As Object

        Dim Message As String = ""

        'Read all data from the htm file into RangetoHTML
        fso = CreateObject("Scripting.FileSystemObject")
        'ts = fso.GetFile(TempFile).OpenAsTextStream(1, -2)
        'ajout = "<br> <font color=""red"" >" & WsExe.Cells(17, 4) & "</font> <br>"
        'If Lang = "FR" Then
        '    message = "<font size=2 face=""Arial"" >Bonjour " & Prenom & ", <br><br> Peux-tu planifier ce case <br>" & CaseN & " fiche " & gcent & " <br><FONT color=""red""> peux-tu également envoyer la date à l'équipe support.<br>pour le client " & Cust & "</FONT> <br> Priority Score : " & SP & "<br> Merci <br><br>Cordialement, </font>"
        '    message = message & "<br><font size=2 face=""Arial"" color=""#000066"" ><strong>Vincent Guerrier</strong>, Project Manager Maintenance, Product Support Retail, Symphony EYC<br>Office : +33 1 73 04 1759<br><a href=""mailto:vincent.guerrier@eyc.com"">vincent.guerrier@eyc.com</a> | <a href=""http://www.eyc.com/"">www.eyc.com</a><br>29-31, rue du Colonel Pierre Avia | 75015 Paris | France</font>"

        'Else

        'Message = "<font size=2 face=""Arial"" >Hi " & Prenom & ",<br><br> The expected correction date has been updated to <font color=""red"">" & ecd & "</font> for " & Cust & "<br>" & CaseN & " Card " & gcent & " <br>" & "<br> Title : " & title & ".<br> CRM ECD has been updated <br><br> Regards, <br></font><br>"
        'Message = Message & "<br><font size=2 face=""Arial"" color=""#000066"" ><strong>Mandaw Fall GALLAND</strong>, Project Manager Maintenance, Developer, Product Support Retail, Symphony GOLD<br>Office : +33 1 73 04 1759<br><a href=""mailto:mandaw-fall.galland@eyc.com"">mandaw-fall.galland@eyc.com</a> | <a href=""http://www.eyc.com/"">www.eyc.com</a><br>29-31, rue du Colonel Pierre Avia | 75015 Paris | France</font>"

        '        Cordialement,

        'Mandaw Fall GALLAND, Developer, Product Support Retail, Symphony GOLD 
        'Mobile: +33 6 66 76 66 90
        'mandaw-fall.galland@eyc.com  | http://www.eyc.com/gold/fr/gold/fr   

        'Symphony EYC S.A.S. | 31, rue du Colonel Pierre Avia | 75015 Paris | France


        RangetoHTMLPlanif = Message '& ts.readall
        'ts.Close()
        RangetoHTMLPlanif = Replace(RangetoHTMLPlanif, "align=center x:publishsource=",
                              "align=left x:publishsource=")


        ts = Nothing
        fso = Nothing
    End Function

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        System.Diagnostics.Process.Start("mailto:? subject=" + "[" & Replace(TBCustomer.Text, "&", "") & "] " & TBCase.Text & " " & TBGcent.Text)
    End Sub


    Private Sub LVad_DoubleClick(sender As System.Object, e As System.EventArgs) Handles LVad.DoubleClick
        Dim PictureCol As Integer = 0 ' the column # of the BLOB field

        Dim myCommand As OleDb.OleDbCommand
        Dim Ind As Integer
        Dim gcent As String
        Dim dr As OleDb.OleDbDataReader
        Dim Oradb As String = "Provider=OraOLEDB.Oracle.1;Password=READCQUEST;Persist Security Info=True;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1;"

        Dim conn As New OleDb.OleDbConnection(Oradb) 'OracleConnection(oradb)
        Try
            'Dim cn As New SqlConnection("Provider=OraOLEDB.Oracle.1;Password=READCQUEST;Persist Security Info=True;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1;")
            gcent = TBGcent.Text
            Dim cmd As String = "Select atb.data   from cqcentral.anomalie Ta, cqcentral.attachments Tat, cqcentral.attachments_blob atb where Ta.dbid = Tat.entity_dbid(+) And Tat.dbid = atb.attachments_dbid And Ta.numerofiche = " + "'" + gcent + "' order by tat.dbid"
            'Dim DestFilePath As String = "C:\test.doc"
            'Dim saveFileDialog1 As New SaveFileDialog()
            'saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
            'saveFileDialog1.Title = "Save the document"
            'saveFileDialog1.FileName = LVad.FocusedItem.SubItems(0).Text
            'saveFileDialog1.InitialDirectory = "c:\temp\"
            'saveFileDialog1.ShowDialog()
            Dim DestFilePath As String = "c:\tempSearch\" + LVad.FocusedItem.SubItems(0).Text

            If My.Computer.FileSystem.DirectoryExists("c:\tempSearch\") Then
            Else
                If My.Forms.frmMessage.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    ' OK button pressed
                    My.Computer.FileSystem.CreateDirectory("c:\tempSearch\")
                    LVad_DoubleClick(sender, e)
                Else
                    MsgBox("File not saved")
                    GoTo sortie
                End If
            End If

            conn.Open()
            'myCommand.Open()
            myCommand = New OleDb.OleDbCommand(cmd, conn)

            'Dim dr As SqlDataReader = cmd.ExecuteReader()
            dr = myCommand.ExecuteReader()

            Ind = LVad.FocusedItem.Index
            For r = 0 To Ind
                dr.Read()
            Next

            Dim b(dr.GetBytes(PictureCol, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
            dr.GetBytes(PictureCol, 0, b, 0, b.Length)
            dr.Close()
            conn.Close()
            Dim fs As New System.IO.FileStream(DestFilePath, IO.FileMode.Create, IO.FileAccess.Write)
            'Dim fs As New System.IO.FileStream(saveFileDialog1.OpenFile(), IO.FileMode.Create, IO.FileAccess.Write)


            'Try
            fs.Write(b, 0, b.Length)
            fs.Close()
            System.Diagnostics.Process.Start("C:\tempSearch")

        Catch

        End Try
sortie:
    End Sub

    Sub efface()
        Try
            Dim DestFilePath As String = "c:\tempSearch\"

            For Each foundFile As String In My.Computer.FileSystem.GetFiles(
                DestFilePath,
                Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                File.Delete(foundFile)
                'My.Computer.FileSystem.DeleteFile(foundFile,
                '    Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                '    Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently)
            Next
        Catch
            'Throw New Exception("Please b")
        End Try
    End Sub

    Private Sub FSearchGcent_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        efface()
    End Sub

    Private Sub BSearch2_Click(sender As System.Object, e As System.EventArgs) Handles BSearch2.Click

        FSearch.MSTSearch.Text = Mid(CBGcent.Text, 1, 13)

        FSearch.Research(0)
    End Sub



    Private Sub LLBlinkCQ_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LLBlinkCQ.LinkClicked
        System.Diagnostics.Process.Start(LbLink.Text)

    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Len(TBLabel.Text) >= 9 Then
            FSearch.MSTSearch.Text = TBLabel.Text.Substring(0, 9)
        Else
            FSearch.MSTSearch.Text = TBLabel.Text
        End If
        FSearch.Research(0)
    End Sub

    Private Sub BRessource_Click(sender As Object, e As EventArgs) Handles BRessource.Click

        If FRessources.researchRes(TBAssigned.Text) <> 0 Then
            FRessources.Show()
        Else
            MessageBox.Show("Not a R&D Ressource", "Warning", MessageBoxButtons.OKCancel)
        End If
    End Sub

    Private Sub BRFE_Click(sender As Object, e As EventArgs) Handles BRFE.Click
        Dim cus, rfe As String

        If TBRFE.Text <> "" Then
            cus = "(" + TBCustomer.Text + ")"
            rfe = Replace(TBRFE.Text, cus, "")
            FSearch.MSTSearch.Text = rfe
            FSearch.Research(5)
        End If
    End Sub

    Function RequestCardTitle(card As String, base As String) As String

        Dim Request As String
        Dim CQbase As String

        CQbase = "cqcentral"

        If InStr(base, "GTOP") > 0 Then
            CQbase = "cqgtop"
        End If
        If InStr(base, "GADMI") > 0 Then
            CQbase = "cqgadmin"
        End If

        If InStr(base, "GSTOC") > 0 Then
            CQbase = "CQGOLDSTOCK"
        End If
        If InStr(base, "GTRAC") > 0 Then
            CQbase = "cqgtrack"
        End If
        If InStr(base, "GCAS") > 0 Then
            CQbase = "cqcas"
        End If
        If InStr(base, "GEVEN") > 0 Then
            CQbase = "CQGOLDEVENTS"
        End If
        If InStr(base, "GLIB") > 0 Then
            CQbase = "cqglib"
        End If

        Request = " Select a.numerofiche, a.titre from "
        Request = Request & CQbase & ".anomalie a "
        Request = Request & "where lower(a.titre) like '%" + LCase(Trim(card)) + "%'"

        RequestCardTitle = Request

    End Function


    Public Function researchCQTitle() As Cases()
        Dim myCommand As OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim Oradb As String = "Provider=OraOLEDB.Oracle.1;Password=READCQUEST;Persist Security Info=True;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1;"
        Dim conn As New OleDb.OleDbConnection(Oradb) 'OracleConnection(oradb)
        Dim req As String
        Dim NbRow As Integer
        Dim LstCase() As Cases
        Dim Lstbase() As String = {"cqcentral", "GTOP", "GADMI", "GSTOC", "GTRAC", "GCAS", "GEVEN", "GLIB"}

        LstCase = Nothing
        For Each base In Lstbase

            req = RequestCardTitle(Trim(TBGcent.Text), base)
            conn.Open()
            'myCommand.Open()
            myCommand = New OleDb.OleDbCommand(req, conn)

            'Dim dr As SqlDataReader = cmd.ExecuteReader()
            dr = myCommand.ExecuteReader()

            'LstCase(0).Number = "0"



            'myReader = dr.Read()
            NbRow = 0
            While dr.Read()
                If dr.Item(0) IsNot DBNull.Value Then
                    ReDim Preserve LstCase(NbRow)
                    LstCase(NbRow).Number = dr.Item(0)
                    If dr.Item(1) IsNot DBNull.Value Then
                        LstCase(NbRow).Title = dr.Item(1)
                    End If
                    LstCase(NbRow).Type = "CARD"
                    NbRow = NbRow + 1
                End If
            End While
            conn.Close()
            'Nb = UBound(LstCase)
        Next
        researchCQTitle = LstCase

    End Function

    Private Sub BPatch_Click(sender As Object, e As EventArgs) Handles BPatch.Click


        If TBPatch.Text <> "" Then
            FSearch.MSTSearch.Text = TBPatch.Text
            FSearch.Research(7)
        End If
    End Sub

End Class

