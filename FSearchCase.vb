Imports Oracle.DataAccess.Client
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports Oracle.DataAccess.Types
Imports MaterialSkin



Public Class FSearchCase



    Private Sub FSearchCase_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance



        'SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
        'SkinManager.ColorScheme = New ColorScheme(Primary.Yellow500, Primary.Yellow700, Primary.Yellow100, Accent.Yellow200, TextShade.WHITE)
        'SkinManager.ROBOTO_MEDIUM_10 = New Font("Microsoft Sans Serif", 8.25)
        'SkinManager.ROBOTO_MEDIUM_10 = New Font("Algerian", 8)
    End Sub

    Private Sub BSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FSearch.MSTSearch.Text = Mid(CBGcent.Text, 1, 13)

        FSearch.Research(0)
    End Sub

    Function RequestCase(ByVal CaseN As String, Opt As Short) As String

        'option :
        '1 : on recherche par numéro de case du client
        RequestCase = "SELECT c.customeridname, "                           ' Account name
        RequestCase = RequestCase + "c.ticketnumber, "                      'Case #,
        RequestCase = RequestCase + "c.sfmig_ranking,                  "    'Priority Score",
        RequestCase = RequestCase + "c.aldata_functionaldomainname,  "      'Domain",
        RequestCase = RequestCase + "c.statuscodename,                 "    'Status",
        RequestCase = RequestCase + "cq.aldata_clearquestbugnumber,    "    'CQ Card",
        RequestCase = RequestCase + "c.productidname,                  "    'Module",
        RequestCase = RequestCase + "c.prioritycodename,               "    'Priority",
        RequestCase = RequestCase + "c.sfmig_expecteddeliverydate,     "    'Expected Delivery",
        RequestCase = RequestCase + "c.owneridname,                    "    'Owner",
        RequestCase = RequestCase + "c.aldata_assignedgroupname,       "    'Assigned Group",
        RequestCase = RequestCase + "c.aldata_validatetargetpatch,     "    'Validate Target Patch",
        RequestCase = RequestCase + "c.title,                          "    'Title",
        RequestCase = RequestCase + "c.aldata_workstreamname,          "    'Workstream",
        RequestCase = RequestCase + "c.createdonutc,                   "    'Created On (UTC)",
        RequestCase = RequestCase + "c.sfmig_truelastmodifieddateutc,  "    'Last Modified (UTC)",
        RequestCase = RequestCase + "c.sfmig_srclientnumber,           "    'Customer's Case #",
        RequestCase = RequestCase + "c.sfmig_prodenvtname,             "    'Production?",
        RequestCase = RequestCase + "cq.aldata_assignedto,             "    'CQ Assigned To",
        RequestCase = RequestCase + "cq.aldata_label,                  "    'CQ Label",
        RequestCase = RequestCase + "cq.aldata_state,                  "    'CQ State",
        RequestCase = RequestCase + "c.aldata_assignedpersonname,      "    'Assigned Person",
        RequestCase = RequestCase + "c.sfmig_rejectedsolutionscount,   "    '# Rejection",
        RequestCase = RequestCase + "c.aldata_expectedcorrectiondate,   "   'date_correction",
        RequestCase = RequestCase + "c.sfmig_targetpatch,                 "  'Target Patch"
        RequestCase = RequestCase + "c.aldata_versionidname,             " 'Version
        RequestCase = RequestCase + "convert(nvarchar(50), c.incidentid), " 'foreign key Filteredaldata_casecomment commentaire
        RequestCase = RequestCase + "c.description, "                        'Description
        RequestCase = RequestCase + "convert(sql_variant,c.incidentid) "
        RequestCase = RequestCase + "FROM FilteredIncident c WITH (NOLOCK) " '"
        RequestCase = RequestCase + "LEFT OUTER JOIN Filteredaldata_clearquestbug cq WITH (NOLOCK) ON c.incidentid = cq.aldata_case "
        If Opt = 0 Then
            RequestCase = RequestCase + "WHERE c.ticketnumber like '%" + Trim(CaseN) + "%'"
        Else
            'customer number
            RequestCase = RequestCase + "WHERE c.sfmig_srclientnumber = '" + Trim(CaseN) + "'"
        End If

    End Function

    Function RequestCaseTitle(ByVal CaseN As String) As String


        RequestCaseTitle = "SELECT c.ticketnumber, "                           ' Account name
        RequestCaseTitle = RequestCaseTitle + "c.title                        "    'Title",
        RequestCaseTitle = RequestCaseTitle + "FROM FilteredIncident c " '"
        RequestCaseTitle = RequestCaseTitle + "WHERE c.title like '%" + Trim(CaseN) + "%'"


    End Function

    Function RequestCaseComment(ByVal CaseN As String) As String

        'RequestCaseComment = "SELECT c.ticketnumber, "                           ' Case #
        'RequestCaseComment = RequestCaseComment + "cc.aldata_comment, "         'Comment #,
        'RequestCaseComment = RequestCaseComment + "cc.createdonutc,                  "    'date,
        'RequestCaseComment = RequestCaseComment + "cc.createdbyname                  "    'user,
        'RequestCaseComment = RequestCaseComment + "FROM FilteredIncident c, Filteredaldata_casecomment cc "
        'RequestCaseComment = RequestCaseComment + "WHERE c.ticketnumber like '%" + CaseN + "%' "
        'RequestCaseComment = RequestCaseComment + "and cc.aldata_case = c.incidentid "
        'RequestCaseComment = RequestCaseComment + "order by cc.createdonutc desc"

        RequestCaseComment = "SELECT cc.aldata_comment, "
        RequestCaseComment = RequestCaseComment + "cc.createdonutc, "
        RequestCaseComment = RequestCaseComment + "cc.createdbyname "
        RequestCaseComment = RequestCaseComment + "from Filteredaldata_casecomment cc "
        RequestCaseComment = RequestCaseComment + "where cc.aldata_case = '" + CaseN + "' "
        RequestCaseComment = RequestCaseComment + "order by cc.createdonutc desc"

    End Function
    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    Function GetGcentInfoCQ(caseN As String) As String
        Dim CQbase As String

        CQbase = "cqcentral"

        GetGcentInfoCQ = "select   s.name, a.label, a.numerofiche from  "
        GetGcentInfoCQ = GetGcentInfoCQ & CQbase & ".anomalie a,"
        GetGcentInfoCQ = GetGcentInfoCQ & CQbase & ".statedef s"
        GetGcentInfoCQ = GetGcentInfoCQ & " where a.State = s.ID"
        GetGcentInfoCQ = GetGcentInfoCQ & " and a.numeroreference like '%" + caseN + "%'"

    End Function


    Function GetGcentInfo(gcent As String) As String
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
        If InStr(gcent, "GEVEN") > 0 Then
            CQbase = "CQGOLDEVENTS"
        End If

        GetGcentInfo = "select  T5.name,T1.label, T1.identificationexterne from "
        GetGcentInfo = GetGcentInfo & CQbase & ".anomalie T1,"
        GetGcentInfo = GetGcentInfo & CQbase & ".statedef T5"
        GetGcentInfo = GetGcentInfo & " where T1.State = T5.ID"
        GetGcentInfo = GetGcentInfo & " and T1.numerofiche = '" + gcent + "'"

    End Function
    Function GetGlibCQ(caseN As String) As String
        Dim CQbase As String

        CQbase = "cqglib"

        GetGlibCQ = "select  a.framework, a.numerofiche, s.name, a.numversion from "
        GetGlibCQ = GetGlibCQ & CQbase & ".anomalie a, "
        GetGlibCQ = GetGlibCQ & CQbase & ".statedef s"
        GetGlibCQ = GetGlibCQ & " where a.state = s.id and a.ref_case = '" + caseN + "'"

    End Function

    Public Function researchCaseTitle() As Cases()
        Dim req As String
        Dim Sqldb As String = "Data Source=seyccrmsqlsip1;Integrated Security=SSPI;Initial Catalog=crm_MSCRM"
        Dim SqlConn As New SqlClient.SqlConnection(Sqldb)
        Dim SqlCmd As New SqlCommand
        Dim myReader As SqlDataReader
        Dim NbRow As Integer
        Dim LstCase() As Cases
        req = RequestCaseTitle(Trim(RTBCase.Text))
        'LstCase(0).Number = "0"
        LstCase = Nothing

        SqlConn.Open()
        SqlCmd = SqlConn.CreateCommand()
        SqlCmd.CommandText = req
        myReader = SqlCmd.ExecuteReader()
        NbRow = 0
        While myReader.Read()
            If myReader.Item(0) IsNot DBNull.Value Then
                ReDim Preserve LstCase(NbRow)
                LstCase(NbRow).Number = myReader.Item(0)
                If myReader.Item(1) IsNot DBNull.Value Then
                    LstCase(NbRow).Title = myReader.Item(1)
                End If
                LstCase(NbRow).Type = "Case"
                NbRow = NbRow + 1
            End If
        End While
        'Nb = UBound(LstCase)
        researchCaseTitle = LstCase

    End Function

    Public Function researchCase(CusCase As Short) As Integer

        Dim Sqldb As String = "Data Source=seyccrmsqlsip1;Integrated Security=SSPI;Initial Catalog=crm_MSCRM"
        Dim SqlConn As New SqlClient.SqlConnection(Sqldb)
        Dim SqlCmd As New SqlCommand
        Dim myReader As SqlDataReader
        Dim Oradb As String = "Provider=OraOLEDB.Oracle.1;Password=READCQUEST;Persist Security Info=True;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1;"
        Dim SqlConn2 As New OleDb.OleDbConnection(Oradb) 'OracleConnection(oradb)
        Dim SqlCmd2 As OleDb.OleDbCommand
        Dim myReader2 As OleDb.OleDbDataReader
        Dim req As String
        Dim NbRow As Integer
        Dim NbRow2 As Integer
        Dim nCase As String
        Dim FKcomment As String
        Dim Label As String
        Dim status As String
        Dim fiche(20) As String
        Dim noadd = False
        Dim framework As String
        Dim frameworkC As String
        FKcomment = "0"

        ' mise au premier plan
        Me.TopMost = True
        Me.TopMost = False

        RTBCase.Text = FSearch.MSTSearch.Text
        nCase = RTBCase.Text

        ClearTextBox(Me)
        RTBCase.Text = nCase
        researchCase = 0
        'Me.Size = New Size(314, 804)




        If (RTBCase.Text <> "" And Len(RTBCase.Text) >= 6) Or CusCase = 1 Then

            Try
                SqlConn.Open()
                SqlCmd = SqlConn.CreateCommand()
                If CusCase = 1 Then
                    'si on recherche par numéro de du client (ex Mantis pour Confo)
                    req = RequestCase(Trim(RTBCase.Text), 1)
                Else
                    req = RequestCase(Trim(RTBCase.Text), 0)
                End If
                SqlCmd.CommandText = req
                myReader = SqlCmd.ExecuteReader()


                'MsgBox(myReader.GetString(0) + " " + myReader.GetString(1) + " " + myReader.GetString(2) + " " + myReader.GetString(3) + " " + myReader.GetString(4) + " " + myReader.GetString(5))
                'MsgBox(myReader.GetString(0) + " " + myReader.GetString(1) + " " + myReader.GetString(3) + " " + myReader.GetString(4) + " " + myReader.GetString(5))

                '+ 0 Account name
                '+ 1 Case #,
                '2 Priority Score",
                '3 Domain",
                '+ 4 Status",
                '+ 5 CQ Card",
                '6 Module",
                '7 Priority",
                '8 Expected Delivery",
                '9 Owner",
                '+ 10 Assigned Group",
                '11 Validate Target Patch",
                '+ 12 Title",
                '13 Workstream",
                '14 Created On (UTC)",
                '15 Last Modified (UTC)",
                '16 Customer's Case #",
                '17 Production?",
                '18 CQ Assigned To",
                '19 CQ Label",
                '20 CQ State",
                '21 Assigned Person",
                '22 # Rejection",
                '23 date_correction",
                '24 Target Patch"
                TBSP.Text = ""
                TBGcent.Text = ""
                TBTitle.Text = ""
                TBState.Text = ""
                RTBCase.Text = ""
                TBAssigned.Text = ""
                TBCustomer.Text = ""
                TBModule.Text = ""
                TBEDD.Text = ""
                TBSev.Text = ""
                TBECD.Text = ""
                TBWorkstream.Text = ""
                TBvtp.Text = ""
                TBOwner.Text = ""
                TBCQState.Text = ""
                TBRejection.Text = ""
                TBAperson.Text = ""
                TBCreated.Text = ""
                TBLastModified.Text = ""
                TBCustomerCase.Text = ""
                TBCQAssignedto.Text = ""
                RTBDesc.Text = ""
                NbRow = 0
                CBGcent.Text = ""
                CBGcent.Items.Clear()
                CBGcent.ForeColor = Color.Black
                CBGcent2.Text = ""
                CBGcent2.Items.Clear()
                CBGcent2.ForeColor = Color.Black
                TBGlib.Visible = True
                CBGlib.Visible = True
                BGlib.Visible = True
                LBGlib.Visible = True
                Dim IncID As Guid



                While myReader.Read()

                    NbRow = NbRow + 1
                    'If myReader.Read() Then
                    LbTitle.Visible = True
                    'Me.Size = New Size(776, 336)
                    TBSP.Text = myReader.Item(2)
                    TBSP.Text = Replace(TBSP.Text, ",", "")
                    TBSP.Text = Replace(TBSP.Text, "0", "")

                    If myReader.Item(5) IsNot DBNull.Value Then
                        'TBGcent.Text = myReader.Item(5)
                        'CBGcent.Text = myReader.Item(5)
                        'CBGcent.Items.Add(myReader.Item(5))
                        If NbRow > 1 Then
                            CBGcent.ForeColor = Color.Red
                        End If
                        'on enrichie avec label et status de la fiche.
                        SqlConn2.Open()

                        req = GetGcentInfo(myReader.Item(5))
                        SqlCmd2 = New OleDb.OleDbCommand(req, SqlConn2)
                        SqlCmd2.CommandText = req
                        myReader2 = SqlCmd2.ExecuteReader()
                        myReader2.Read()
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

                        Label = ""
                        If myReader2.Item(1) IsNot DBNull.Value Then
                            Label = myReader2.Item(1)
                        End If

                        If myReader2.Item(2) IsNot DBNull.Value Then
                            If TBPatch.Text = "" Then
                                TBPatch.Text = myReader2.Item(2)
                            End If
                        End If



                        'Label = Mid(Label, 4, 9)
                        TBGcent.Text = myReader.Item(5)
                        fiche(NbRow) = TBGcent.Text
                        CBGcent.Text = myReader.Item(5) + "  " + status + "  " + Label
                        CBGcent.Items.Add(myReader.Item(5) + "  " + status + "  " + Label)
                        SqlConn2.Close()
                    End If



                    TBTitle.Text = myReader.Item(12)
                    TBState.Text = myReader.Item(4)
                    RTBCase.Text = myReader.Item(1)
                    If myReader.Item(10) IsNot DBNull.Value Then
                        TBAssigned.Text = myReader.Item(10)
                    End If
                    If myReader.Item(3) IsNot DBNull.Value Then
                        TBFD.Text = myReader.Item(3)
                    End If
                    TBCustomer.Text = myReader.Item(0)
                    If myReader.Item(6) IsNot DBNull.Value Then
                        TBModule.Text = myReader.Item(6)
                    End If
                    TBSev.Text = myReader.Item(7)
                    If myReader.Item(8) IsNot DBNull.Value Then
                        TBEDD.Text = myReader.Item(8)
                    End If

                    If myReader.Item(23) IsNot DBNull.Value Then
                        TBECD.Text = myReader.Item(23)
                    End If
                    If myReader.Item(13) IsNot DBNull.Value Then
                        TBWorkstream.Text = myReader.Item(13)
                    End If
                    If myReader.Item(11) IsNot DBNull.Value Then
                        TBvtp.Text = myReader.Item(11)
                    End If
                    If myReader.Item(9) IsNot DBNull.Value Then
                        TBOwner.Text = myReader.Item(9)
                    End If
                    If myReader.Item(20) IsNot DBNull.Value Then
                        TBCQState.Text = myReader.Item(20)
                    End If
                    If myReader.Item(22) IsNot DBNull.Value Then

                        TBRejection.Text = myReader.Item(22)
                        TBRejection.Text = Replace(TBRejection.Text, ",", "")
                        TBRejection.Text = Replace(TBRejection.Text, "0", "")
                    End If
                    If myReader.Item(21) IsNot DBNull.Value Then
                        TBAperson.Text = myReader.Item(21)
                    End If
                    If myReader.Item(14) IsNot DBNull.Value Then
                        TBCreated.Text = myReader.Item(14)
                    End If
                    If myReader.Item(15) IsNot DBNull.Value Then
                        TBLastModified.Text = myReader.Item(15)
                    End If
                    If myReader.Item(16) IsNot DBNull.Value Then
                        TBCustomerCase.Text = myReader.Item(16)
                    End If
                    If myReader.Item(18) IsNot DBNull.Value Then
                        TBCQAssignedto.Text = myReader.Item(18)
                    End If
                    If myReader.Item(25) IsNot DBNull.Value Then
                        TBVersion.Text = myReader.Item(25)
                    End If
                    If myReader.Item(26) IsNot DBNull.Value Then
                        FKcomment = myReader.Item(26)
                    End If
                    'description
                    If myReader.Item(27) IsNot DBNull.Value Then
                        RTBDesc.Text = myReader.Item(27)
                    End If
                    'Id
                    If myReader.Item(28) IsNot DBNull.Value Then
                        IncID = myReader.Item(28)

                        LbLink.Text = "https://crm.eyc.com/main.aspx?etc=112&id=%7b" + IncID.ToString() + "%7d&pagetype=entityrecord"
                    End If
                End While
                '-----
                'on recherche les fiches liées aux cases par CQ

                'on enrichie avec label et status de la fiche.
                SqlConn2.Open()
                If RTBCase.Text = "" Then
                    'Throw New System.Exception("")
                    If CusCase = 0 Then
                        Me.Close()
                        researchCase = 0
                        Throw New Exception("Not a Case")
                    Else
                        Me.Close()
                        researchCase = 0
                        Throw New Exception("Not a Customer Case Number")
                    End If
                End If

                req = GetGcentInfoCQ(RTBCase.Text)
                SqlCmd2 = New OleDb.OleDbCommand(req, SqlConn2)
                SqlCmd2.CommandText = req
                myReader2 = SqlCmd2.ExecuteReader()

                NbRow2 = 0
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
                        status = "CO"
                    ElseIf status = "Attente_approbation" Then
                        status = "AA"
                    ElseIf status = "Refusée" Then
                        status = "Ref"
                    ElseIf status = "Fermée" Then
                        status = "F"
                    End If


                    Label = ""
                    If myReader2.Item(1) IsNot DBNull.Value Then
                        Label = myReader2.Item(1)
                    End If


                    'Label = Mid(Label, 4, 9)
                    noadd = False

                    For i = 0 To NbRow
                        If myReader2.Item(2) = fiche(i) Then
                            noadd = True
                        End If

                    Next


                    If noadd = False Then
                        TBGcent2.Text = myReader2.Item(2)
                        CBGcent2.Text = myReader2.Item(2) + "  " + status + "  " + Label
                        CBGcent2.Items.Add(myReader2.Item(2) + "  " + status + "  " + Label)
                        NbRow2 = NbRow2 + 1
                        If NbRow2 > 1 Then
                            CBGcent2.ForeColor = Color.Red
                        End If

                    End If



                End While
                SqlConn2.Close()
                '-----
                'GLIB
                SqlConn2.Open()

                If RTBCase.Text <> "" Then
                    req = GetGlibCQ(RTBCase.Text)
                    SqlCmd2 = New OleDb.OleDbCommand(req, SqlConn2)
                    SqlCmd2.CommandText = req
                    myReader2 = SqlCmd2.ExecuteReader()
                    'myReader2.Read()
                    'status = myReader2.Item(0)
                    NbRow2 = 0
                    While myReader2.Read()

                        framework = myReader2.Item(0)
                        frameworkC = ""
                        Try
                            If myReader.Item(3) IsNot DBNull.Value Then
                                frameworkC = myReader.Item(3)
                            End If
                        Catch
                        End Try

                        noadd = False

                        For i = 0 To NbRow
                            If myReader2.Item(1) = fiche(i) Then
                                noadd = True
                            End If

                        Next

                        status = myReader2.Item(2)

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
                            status = "CO"
                        ElseIf status = "Attente_approbation" Then
                            status = "AA"
                        ElseIf status = "Refusée" Then
                            status = "Ref"
                        ElseIf status = "Fermée" Then
                            status = "F"
                        End If

                        NbRow2 = 0
                        If noadd = False Then
                            TBGlib.Text = myReader2.Item(1)
                            If status <> "O" Or status <> "A" Then
                                framework = framework
                            Else
                                framework = frameworkC
                            End If
                            CBGlib.Text = myReader2.Item(1) + "  " + status + "  " + framework

                            CBGlib.Items.Add(CBGlib.Text)
                            NbRow2 = NbRow2 + 1
                            If NbRow2 > 1 Then
                                CBGlib.ForeColor = Color.Red
                            End If
                        End If



                    End While

                    If NbRow2 = 0 Then
                        TBGlib.Visible = False
                        CBGlib.Visible = False
                        CBGlib.Visible = False
                        BGlib.Visible = False
                        LBGlib.Visible = False
                    End If

                    SqlConn2.Close()
                End If
                SqlConn.Close()
                BGCaseComment(FKcomment)

                researchCase = NbRow

            Catch ex As Exception
                'MsgBox("Not a card or a case, please retry")
                'MsgBox(ex.Message)
            End Try



        Else
            Me.Close()
            researchCase = 0

        End If

    End Function

    Private Sub BGCaseComment(FKcomment As String)

        Dim Sqldb As String = "Data Source=seyccrmsqlsip1;Integrated Security=SSPI;Initial Catalog=crm_MSCRM"
        Dim SqlConn As New SqlClient.SqlConnection(Sqldb)
        Dim SqlCmd As New SqlCommand
        Dim myReader As SqlDataReader
        Dim req As String

        Try
            SqlConn.Open()
            SqlCmd = SqlConn.CreateCommand()
            req = RequestCaseComment(FKcomment)
            SqlCmd.CommandText = req
            myReader = SqlCmd.ExecuteReader()

            LVComment.Items.Clear()

            While myReader.Read()

                Dim LVITime As New ListViewItem(myReader.GetValue(0).ToString)

                LbTitle.Visible = True
                'Me.Size = New Size(776, 700)


                LVITime.SubItems.Add(myReader.GetValue(2).ToString)
                LVITime.SubItems.Add(myReader.GetValue(1).ToString)
                'LVITime.SubItems.Add(dr.GetValue(5).ToString)
                'LVITime.SubItems.Add(myReader.GetValue(4).ToString)

                LVComment.Items.AddRange(New ListViewItem() {LVITime})

            End While
            SqlConn.Close()



        Catch ex As Exception
            MsgBox("Not a card, Customer case number or a case, please retry")
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RTBCase_LinkClicked(sender As Object, e As System.Windows.Forms.LinkClickedEventArgs) Handles RTBCase.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)

        'convert(sql_variant,c.incidentid) "IncID"

        'Addr = "https://crm.eyc.com/main.aspx?etc=112&id=%7b" + IncID + "%7d&pagetype=entityrecord"
        'Addr = Replace(Replace(Addr, "{", ""), "}", "")
        'WsSuiv.Hyperlinks.Add(cel, Addr)

    End Sub

    Private Sub LVComment_DoubleClick(sender As System.Object, e As System.EventArgs) Handles LVComment.DoubleClick
        Dim comment As String

        comment = LVComment.FocusedItem.SubItems(0).Text
        MsgBox(comment)

    End Sub


    Private Sub BSearch2_Click(sender As System.Object, e As System.EventArgs) Handles BSearch2.Click
        FSearch.MSTSearch.Text = Mid(CBGcent2.Text, 1, 13)

        FSearch.Research(0)
    End Sub

    Private Sub BGlib_Click(sender As System.Object, e As System.EventArgs) Handles BGlib.Click
        FSearch.MSTSearch.Text = Mid(CBGlib.Text, 1, 13)

        FSearch.Research(0)
    End Sub


    Private Sub LLBlinkCRM_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LLBlinkCRM.LinkClicked

        System.Diagnostics.Process.Start(LbLink.Text)


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FSearch.MSTSearch.Text = Mid(TBCustomer.Text, 1, 13)

        FSearch.Research(0)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BCustomer.Click
        'Dim ret As Integer
        FSearch.MSTSearch.Text = TBCustomer.Text

        FSearch.Research(0)
        'ret = FCustomer.TBCus.Text = TBCustomer.Text
        'FSearch.MSTSearch.Text = TBCustomer.Text

        'FCustomer.researchCus()
        'If ret <> 0 Then
        ' FCustomer.Show()
        'End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Bassigned.Click
        FRessources.researchRes(TBCQAssignedto.Text)
        FRessources.Show()
    End Sub

    Private Sub BSearch_Click_2(sender As Object, e As EventArgs) Handles BSearch.Click
        FSearch.MSTSearch.Text = Mid(CBGcent.Text, 1, 13)

        FSearch.Research(0)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("mailto:? subject=" + "[" & Replace(TBCustomer.Text, "&", "") & "] " & RTBCase.Text)
    End Sub

    Private Sub BPatch_Click(sender As Object, e As EventArgs) Handles BPatch.Click
        If TBPatch.Text <> "" Then
            FSearch.MSTSearch.Text = TBPatch.Text
            FSearch.Research(7)
        End If
    End Sub
End Class
