Imports Oracle.DataAccess.Client
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports Oracle.DataAccess.Types
Imports System.Data.Common
Imports MaterialSkin
Imports Excel = Microsoft.Office.Interop.Excel

'Imports DataGridViewAutoFilter;




Public Class FBacklog

    Private lvwColumnSorter As ListViewColumnSorter
    Dim FirstOpened, iStatus, iWorkstream, iAssign, iVTP, iPriority As Integer

    Function RequestBacklog(Client As String, dist As String, Opt As Integer, Optgcent As Integer) As String
        'Opt = 1 si on veut les cases fermés
        RequestBacklog = ""
        Select Case dist
            Case "state"
                RequestBacklog = "select distinct c.statuscodename as State "
            Case "Priority"
                RequestBacklog = "select distinct c.prioritycodename as ""Priority"""
            Case "Assign_Group"
                RequestBacklog = "select distinct c.aldata_assignedgroupname as ""Assign_Group"" "
            Case "Workstream"
                RequestBacklog = "select distinct c.aldata_workstreamname as Workstream "
            Case "VTP"
                RequestBacklog = "select distinct c.aldata_validatetargetpatch as VTP "
            Case Else
                RequestBacklog = "SELECT c.ticketnumber as ""Case"", "                                  '1
                'RequestBacklog = RequestBacklog & "c.customeridname, "
                RequestBacklog = RequestBacklog & "c.sfmig_ranking as ""Priority Score"",  "                      '2
                'RequestBacklog = RequestBacklog & "c.aldata_functionaldomainname, "         '3
                If Optgcent = 1 Then
                    RequestBacklog = RequestBacklog & "cq.aldata_clearquestbugnumber as ""CQ_Card"", "         '5
                End If
                RequestBacklog = RequestBacklog & "c.statuscodename as State, "                      '4
                'RequestBacklog = RequestBacklog & "c.productidname, "                       '6
                RequestBacklog = RequestBacklog & "c.prioritycodename as Priority, "                    '7
                RequestBacklog = RequestBacklog & "CONVERT(date,c.sfmig_expecteddeliverydate,103) as EDD, "          '8
                RequestBacklog = RequestBacklog & "CONVERT(date,c.aldata_expectedcorrectiondate,103) as ECD, "       '23
                'RequestBacklog = RequestBacklog & "c.owneridname as Owner, "                         '9
                RequestBacklog = RequestBacklog & "c.aldata_assignedgroupname as ""Assign_Group"", "            '10
                RequestBacklog = RequestBacklog & "c.aldata_validatetargetpatch as VTP, "          '11
                RequestBacklog = RequestBacklog & "c.title as Title, "                               '12
                RequestBacklog = RequestBacklog & "c.aldata_workstreamname as Workstream, "               '13

                RequestBacklog = RequestBacklog & "CONVERT(date,c.createdonutc,103) as ""Created_Date"", "                        '14
                RequestBacklog = RequestBacklog & "CONVERT(date,c.sfmig_laststatuschangeutc,103) as ""LastStatusDate"" "           '15

        End Select
        'RequestBacklog = RequestBacklog & "c.sfmig_truelastmodifieddateutc, "       '15
        'RequestBacklog = RequestBacklog & "c.sfmig_srclientnumber, "                '16
        'RequestBacklog = RequestBacklog & "c.sfmig_prodenvtname, "                  '17
        'RequestBacklog = RequestBacklog & "cq.aldata_assignedto, "                  '18
        'RequestBacklog = RequestBacklog & "cq.aldata_label as Label, "              '19
        'RequestBacklog = RequestBacklog & "cq.aldata_state as ""CQ State"", "       '20
        'RequestBacklog = RequestBacklog & "c.aldata_assignedpersonname, "           '21
        'RequestBacklog = RequestBacklog & "c.sfmig_rejectedsolutionscount, "        '22
        'RequestBacklog = RequestBacklog & "c.sfmig_targetpatch, "                   '24
        'RequestBacklog = RequestBacklog & "convert(sql_variant,c.incidentid), "     '25
        'RequestBacklog = RequestBacklog & "c.aldata_versionidname, "                '26
        'RequestBacklog = RequestBacklog & "c.sfmig_srclientnumber "                 '27
        RequestBacklog = RequestBacklog & RequestBacklogGen(Client, Optgcent)

        If Opt = 1 Then
            RequestBacklog = RequestBacklog + RequestBacklogClosed(Client, dist, Optgcent)
        End If
        RequestBacklog = RequestBacklog & " order by 1 desc"

    End Function
    Function RequestBacklogGen(Client As String, optgcent As Integer) As String


        If optgcent = 0 Then
            RequestBacklogGen = "FROM FilteredIncident c "
        Else
            RequestBacklogGen = "FROM FilteredIncident c WITH (NOLOCK) "
            RequestBacklogGen = RequestBacklogGen & "LEFT OUTER JOIN Filteredaldata_clearquestbug cq WITH (NOLOCK) ON c.incidentid = cq.aldata_case "
        End If


        RequestBacklogGen = RequestBacklogGen & "WHERE 1 = 1 "
        RequestBacklogGen = RequestBacklogGen & "and c.statuscode not in (5, 6) /*5=closed;6=cancelled,129770007=livre*/ "
        RequestBacklogGen = RequestBacklogGen & "and c.customeridname like '%" & Client & "%' "



    End Function

    Function RequestBacklogClosed(Client As String, dist As String, Optgcent As Integer) As String
        'Opt = 1 si on veut les cases fermés
        RequestBacklogClosed = "Union "
        Select Case dist
            Case "state"
                RequestBacklogClosed = " Union select top 30 distinct c.statuscodename as State "
            Case "Priority"
                RequestBacklogClosed = " Union select top 30  distinct c.prioritycodename as ""Priority"""
            Case "Assign_Group"
                RequestBacklogClosed = " Union select top 30  distinct c.aldata_assignedgroupname as ""Assign_Group"" "
            Case "Workstream"
                RequestBacklogClosed = " Union select top 30  distinct c.aldata_workstreamname as Workstream "
            Case "condition 3", "condition 4"


            Case Else
                RequestBacklogClosed = " Union select * from (SELECT top 30  c.ticketnumber as ""Case"", "                                  '1
                'RequestBacklogClosed = RequestBacklogClosed & "c.customeridname, "
                RequestBacklogClosed = RequestBacklogClosed & "c.sfmig_ranking as ""Priority Score"",  "                      '2
                'RequestBacklogClosed = RequestBacklogClosed & "c.aldata_functionaldomainname, "         '3
                If Optgcent = 1 Then
                    RequestBacklogClosed = RequestBacklogClosed & "cq.aldata_clearquestbugnumber as ""CQ_Card"", "         '5
                End If        '5
                RequestBacklogClosed = RequestBacklogClosed & "c.statuscodename as State, "                      '4
                'RequestBacklogClosed = RequestBacklogClosed & "c.productidname, "                       '6
                RequestBacklogClosed = RequestBacklogClosed & "c.prioritycodename as Priority, "                    '7
                RequestBacklogClosed = RequestBacklogClosed & "CONVERT(date,c.sfmig_expecteddeliverydate,103) as EDD, "          '8
                RequestBacklogClosed = RequestBacklogClosed & "CONVERT(date,c.aldata_expectedcorrectiondate,103) as ECD, "       '23
                'RequestBacklogClosed = RequestBacklogClosed & "c.owneridname as Owner, "                         '9
                RequestBacklogClosed = RequestBacklogClosed & "c.aldata_assignedgroupname as ""Assign_Group"", "            '10
                RequestBacklogClosed = RequestBacklogClosed & "c.aldata_validatetargetpatch as VTP, "          '11
                RequestBacklogClosed = RequestBacklogClosed & "c.title as Title, "                               '12
                RequestBacklogClosed = RequestBacklogClosed & "c.aldata_workstreamname as Workstream, "               '13

                RequestBacklogClosed = RequestBacklogClosed & "CONVERT(date,c.createdonutc,103) as ""Created_Date"", "                        '14
                RequestBacklogClosed = RequestBacklogClosed & "CONVERT(date,c.sfmig_laststatuschangeutc,103) as ""LastStatusDate"" "           '15
                RequestBacklogClosed = RequestBacklogClosed & RequestBacklogClosedGen(Client, Optgcent)


        End Select
        'RequestBacklogClosed = RequestBacklogClosed & "c.sfmig_truelastmodifieddateutc, "       '15
        'RequestBacklogClosed = RequestBacklogClosed & "c.sfmig_srclientnumber, "                '16
        'RequestBacklogClosed = RequestBacklogClosed & "c.sfmig_prodenvtname, "                  '17
        'RequestBacklogClosed = RequestBacklogClosed & "cq.aldata_assignedto, "                  '18
        'RequestBacklogClosed = RequestBacklogClosed & "cq.aldata_label as Label, "                       '19
        'RequestBacklogClosed = RequestBacklogClosed & "cq.aldata_state as ""CQ State"", "                       '20
        'RequestBacklogClosed = RequestBacklogClosed & "c.aldata_assignedpersonname, "           '21
        'RequestBacklogClosed = RequestBacklogClosed & "c.sfmig_rejectedsolutionscount, "        '22
        'RequestBacklogClosed = RequestBacklogClosed & "c.sfmig_targetpatch, "                   '24
        'RequestBacklogClosed = RequestBacklogClosed & "convert(sql_variant,c.incidentid), "     '25
        'RequestBacklogClosed = RequestBacklogClosed & "c.aldata_versionidname, "                '26
        'RequestBacklogClosed = RequestBacklogClosed & "c.sfmig_srclientnumber "                 '27


    End Function

    Function RequestBacklogClosedGen(Client As String, Optgcent As Integer) As String


        If Optgcent = 0 Then
            RequestBacklogClosedGen = "FROM FilteredIncident c "
        Else
            RequestBacklogClosedGen = "FROM FilteredIncident c WITH (NOLOCK) "
            RequestBacklogClosedGen = RequestBacklogClosedGen & "LEFT OUTER JOIN Filteredaldata_clearquestbug cq WITH (NOLOCK) ON c.incidentid = cq.aldata_case "
        End If


        RequestBacklogClosedGen = RequestBacklogClosedGen & "WHERE 1 = 1 "
        'Si opt = 1 alors on veut les cases fermés
        RequestBacklogClosedGen = RequestBacklogClosedGen & "and c.statuscode = 5 /*5=closed;6=cancelled,129770007=livre*/ "
        RequestBacklogClosedGen = RequestBacklogClosedGen & "and c.customeridname like '%" & Client & "%' "
        RequestBacklogClosedGen = RequestBacklogClosedGen & "order by LastStatusDate desc) as ClosedReq"


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

        GetGcentInfo = "select  T5.name, T1.label, Tu.login_name, T1.dateplanifauplustot + 1, T1.reportfiche retrofit from "
        GetGcentInfo = GetGcentInfo & CQbase & ".anomalie T1, "
        GetGcentInfo = GetGcentInfo & CQbase & ".statedef T5, "
        GetGcentInfo = GetGcentInfo & CQbase & ".users Tu "
        GetGcentInfo = GetGcentInfo & " where T1.State = T5.ID"
        GetGcentInfo = GetGcentInfo & " And T1.assigne = Tu.dbid "
        GetGcentInfo = GetGcentInfo & " and T1.numerofiche = '" + gcent + "'"

    End Function

    Function researchBacklog() As Integer
        Dim Sqldb As String = "Data Source=seyccrmsqlsip1;Integrated Security=SSPI;Initial Catalog=crm_MSCRM"
        Dim SqlConn As New SqlClient.SqlConnection(Sqldb)
        Dim SqlCmd As New SqlCommand
        Dim Oradb As String = "Provider=OraOLEDB.Oracle.1;Password=READCQUEST;Persist Security Info=True;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1;"
        Dim SqlConn2 As New OleDb.OleDbConnection(Oradb) 'OracleConnection(oradb)
        Dim SqlCmd2 As OleDb.OleDbCommand
        Dim myReader As SqlDataReader
        Dim myReader2 As OleDb.OleDbDataReader
        Dim req As String
        Dim nbrow As Integer
        Dim Opt, OptGcent As Integer
        Dim MonDataSet, MonDataSetState, MonDataSetPriority, MonDataSetAgroup, MonDataSetWorkstream, MonDataSetVTP As New DataSet
        Dim Adaptateur As New SqlDataAdapter
        'Dim toto As String

        researchBacklog = 0
        Opt = 0
        If CBClosed.Checked Then
            Opt = 1
        End If

        OptGcent = 0
        If CBGcent.Checked Then
            OptGcent = 1
        End If

        Try
            SqlConn.Open()
            SqlCmd = SqlConn.CreateCommand()
            req = RequestBacklog(Replace(Trim(TBCus.Text), "'", "''"), "", Opt, OptGcent)

            SqlCmd.CommandText = req

            Adaptateur.SelectCommand = SqlCmd
            Adaptateur.Fill(MonDataSet, "backlog")

            myReader = SqlCmd.ExecuteReader()

            DGVBacklog.DataSource = MonDataSet.Tables("backlog")


            'ajout de la colonne Status pour la gcent
            If OptGcent Then
                MonDataSet.Tables("backlog").Columns.Add("Card Status", GetType(String))
                MonDataSet.Tables("backlog").Columns.Add("Label", GetType(String))
                MonDataSet.Tables("backlog").Columns.Add("Assigned", GetType(String))
                MonDataSet.Tables("backlog").Columns.Add("Correction Date", GetType(String))
                MonDataSet.Tables("backlog").Columns.Add("Retrofited from Card", GetType(String))

                'Ta.label, Tu.login_name, Ta.dateplanifauplustot + 1, Ta.RETROFITCARD retrofit
                SqlConn2.Open()

                For Each k In MonDataSet.Tables("backlog").Rows


                    'recherche des infos de la fiche 
                    If k.item("CQ_Card") IsNot DBNull.Value Then
                        req = GetGcentInfo(k.item("CQ_Card"))
                        SqlCmd2 = New OleDb.OleDbCommand(req, SqlConn2)
                        SqlCmd2.CommandText = req
                        myReader2 = SqlCmd2.ExecuteReader()
                        myReader2.Read()
                        k.item("Card Status") = myReader2.Item(0)
                        If myReader2.Item(1) IsNot DBNull.Value Then
                            k.item("Label") = myReader2.Item(1)
                        End If

                        If myReader2.Item(2) IsNot DBNull.Value Then
                            k.item("Assigned") = myReader2.Item(2)
                        End If
                        If myReader2.Item(3) IsNot DBNull.Value Then
                            k.item("Correction Date") = myReader2.Item(3)
                        End If
                        If myReader2.Item(4) IsNot DBNull.Value Then
                            k.item("Retrofited from Card") = Replace(myReader2.Item(4), ",", "")

                        End If
                    End If
                Next
                DGVBacklog.Columns("CQ_Card").DefaultCellStyle.BackColor = Color.Yellow
                DGVBacklog.Columns("Card Status").DefaultCellStyle.BackColor = Color.Yellow
                DGVBacklog.Columns("Label").DefaultCellStyle.BackColor = Color.Yellow
                DGVBacklog.Columns("Assigned").DefaultCellStyle.BackColor = Color.Yellow
                DGVBacklog.Columns("Correction Date").DefaultCellStyle.BackColor = Color.Yellow
                DGVBacklog.Columns("Retrofited from Card").DefaultCellStyle.BackColor = Color.Yellow
            End If

            'DGVBacklog.DataSource = BS1
            BS1.DataSource = DGVBacklog.DataSource
            'BS1.Filter = "state='In Progress'"
            nbrow = MonDataSet.Tables(0).Rows.Count

            'on ajuste l'ordre des colonnes
            AdjustColumnOrder(OptGcent)

            If nbrow = 0 Then
                'MsgBox("No backlog")
                researchBacklog = 0
                Me.Close()
                Exit Function
            Else researchBacklog = nbrow
            End If

            DGVBacklog.Columns("Priority Score").DefaultCellStyle.Format = "n1"


            SqlConn.Close()
            myReader.Close()


            '*********filtre*************
            SqlConn.Open()
            SqlCmd = SqlConn.CreateCommand()
            req = RequestBacklog(Replace(Trim(TBCus.Text), "'", "''"), "state", Opt, OptGcent)


            SqlCmd.CommandText = req

            Adaptateur.SelectCommand = SqlCmd
            Adaptateur.Fill(MonDataSetState, "backlog")

            myReader = SqlCmd.ExecuteReader()

            CLBFilterState.DataSource = MonDataSetState.Tables("backlog")
            CLBFilterState.DisplayMember = "State"

            SqlConn.Close()
            myReader.Close()

            '*********filtre priorité*************
            SqlConn.Open()
            SqlCmd = SqlConn.CreateCommand()
            req = RequestBacklog(Replace(Trim(TBCus.Text), "'", "''"), "Priority", Opt, OptGcent)


            SqlCmd.CommandText = req

            Adaptateur.SelectCommand = SqlCmd
            Adaptateur.Fill(MonDataSetPriority, "backlog")

            myReader = SqlCmd.ExecuteReader()

            CLBFilterPriority.DataSource = MonDataSetPriority.Tables("backlog")
            CLBFilterPriority.DisplayMember = "Priority"

            SqlConn.Close()
            myReader.Close()

            '*********filtre Assign_Group*************
            SqlConn.Open()
            SqlCmd = SqlConn.CreateCommand()
            req = RequestBacklog(Replace(Trim(TBCus.Text), "'", "''"), "Assign_Group", Opt, OptGcent)


            SqlCmd.CommandText = req

            Adaptateur.SelectCommand = SqlCmd
            Adaptateur.Fill(MonDataSetAgroup, "backlog")

            myReader = SqlCmd.ExecuteReader()

            CLBFilterAGroup.DataSource = MonDataSetAgroup.Tables("backlog")
            CLBFilterAGroup.DisplayMember = "Assign_Group"

            SqlConn.Close()
            myReader.Close()

            '*********filtre Workstream*************
            SqlConn.Open()
            SqlCmd = SqlConn.CreateCommand()
            req = RequestBacklog(Replace(Trim(TBCus.Text), "'", "''"), "Workstream", Opt, OptGcent)


            SqlCmd.CommandText = req

            Adaptateur.SelectCommand = SqlCmd
            Adaptateur.Fill(MonDataSetWorkstream, "backlog")

            myReader = SqlCmd.ExecuteReader()

            CLBFilterWorkstream.DataSource = MonDataSetWorkstream.Tables("backlog")
            CLBFilterWorkstream.DisplayMember = "Workstream"

            SqlConn.Close()
            myReader.Close()

            '*********filtre VTP*************
            SqlConn.Open()
            SqlCmd = SqlConn.CreateCommand()
            req = RequestBacklog(Replace(Trim(TBCus.Text), "'", "''"), "VTP", Opt, OptGcent)


            SqlCmd.CommandText = req

            Adaptateur.SelectCommand = SqlCmd
            Adaptateur.Fill(MonDataSetVTP, "backlog")

            myReader = SqlCmd.ExecuteReader()

            CLBVTP.DataSource = MonDataSetVTP.Tables("backlog")
            CLBVTP.DisplayMember = "VTP"

            SqlConn.Close()
            myReader.Close()

            TBNbCases.Text = nbrow
            ' MessageBox.Show(nbrow)

            DGVBacklog.Columns("Priority Score").DefaultCellStyle.Format = "n0"
            If FirstOpened = 1 Then
                FirstOpened = 0
                Checkedlist()

            End If
        Catch ex As Exception
            Opt = Opt
            'MsgBox("Not a card or a case, please retry")
            'MsgBox(ex.Message)
        End Try

    End Function

    Private Sub AdjustColumnOrder(Optgcent As Integer)
        Dim i As Integer
        i = 0

        DGVBacklog.Columns("Case").DisplayIndex = 0
        DGVBacklog.Columns("Priority Score").DisplayIndex = 1
        If Optgcent = 1 Then
            DGVBacklog.Columns("CQ_Card").DisplayIndex = 2
            DGVBacklog.Columns("Card Status").DisplayIndex = 3
            DGVBacklog.Columns("CQ_Card").DisplayIndex = 4
            DGVBacklog.Columns("Card Status").DisplayIndex = 5
            DGVBacklog.Columns("Label").DisplayIndex = 6
            DGVBacklog.Columns("Assigned").DisplayIndex = 7
            DGVBacklog.Columns("Correction Date").DisplayIndex = 8
            DGVBacklog.Columns("Retrofited from Card").DisplayIndex = 9
            i = 8
        End If
        DGVBacklog.Columns("State").DisplayIndex = 2 + i
        DGVBacklog.Columns("Priority").DisplayIndex = 3 + i
        DGVBacklog.Columns("EDD").DisplayIndex = 4 + i
        DGVBacklog.Columns("ECD").DisplayIndex = 5 + i
        DGVBacklog.Columns("Assign_Group").DisplayIndex = 6 + i
        DGVBacklog.Columns("VTP").DisplayIndex = 7 + i
        DGVBacklog.Columns("Title").DisplayIndex = 8 + i
        DGVBacklog.Columns("Workstream").DisplayIndex = 9 + i
        DGVBacklog.Columns("Created_Date").DisplayIndex = 10 + i
        DGVBacklog.Columns("LastStatusDate").DisplayIndex = 11 + i
    End Sub

    Private Sub DGVBacklog_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVBacklog.CellContentDoubleClick
        'MsgBox(Me.DGVBacklog.CurrentCell.Value)
        FSearch.MSTSearch.Text = Me.DGVBacklog.CurrentCell.Value
        FSearch.Research(0)
    End Sub

    Private Sub BBfilter_Click(sender As System.Object, e As System.EventArgs) Handles Bfilter.Click
        Dim filtreState, FiltrePriority, FiltreAGroup, FiltreWorkstream, FiltreVTP As String
        Dim nbs, nbs2 As Integer
        Dim Itemchk As String

        'MsgBox(CLBFilterState.SelectedItem.ToString())
        researchBacklog()


        'For i As Integer = 0 To CLBFilterState.Items.Count - 1
        ' If CLBFilterState.
        ' .SetItemChecked(i, False) Then
        ' Next

        '***********State************
        filtreState = " ( state='"
        nbs = 0
        nbs2 = 0
        For Each itemChecked In CLBFilterState.CheckedItems
            If nbs = 0 Then
                filtreState = filtreState & itemChecked.item("State").ToString & "'"
                'MsgBox(itemChecked.item("State").ToString)
            Else
                filtreState = filtreState & " or " & "state='" & itemChecked.item("State").ToString & "'"
            End If
            nbs = nbs + 1
        Next

        If filtreState = " ( state='" Then
            filtreState = ""
            nbs2 = 0
        Else
            nbs2 = 1
            filtreState = filtreState & ") "
        End If


        '***********Priority************
        FiltrePriority = " ( Priority='"
        nbs = 0
        If nbs2 <> 0 Then
            FiltrePriority = " and" & FiltrePriority
        End If
        For Each itemChecked In CLBFilterPriority.CheckedItems
            If nbs = 0 Then
                FiltrePriority = FiltrePriority & itemChecked.item("Priority").ToString & "'"
                'MsgBox(itemChecked.item("State").ToString)
            Else
                FiltrePriority = FiltrePriority & " or " & "Priority='" & itemChecked.item("Priority").ToString & "'"
            End If
            nbs = nbs + 1
        Next

        If FiltrePriority = " ( Priority='" Or FiltrePriority = " and ( Priority='" Then
            FiltrePriority = ""
            'nbs2 = 0
        Else
            nbs2 = 1
            FiltrePriority = FiltrePriority & ") "
        End If


        '***********Assign_Group************
        FiltreAGroup = " ( Assign_Group='"
        nbs = 0
        If nbs2 <> 0 Then
            FiltreAGroup = " and" & FiltreAGroup
        End If
        For Each itemChecked In CLBFilterAGroup.CheckedItems
            If nbs = 0 Then
                FiltreAGroup = FiltreAGroup & itemChecked.item("Assign_Group").ToString & "'"
                'MsgBox(itemChecked.item("State").ToString)
            Else
                FiltreAGroup = FiltreAGroup & " or " & "Assign_Group='" & itemChecked.item("Assign_Group").ToString & "'"
            End If
            nbs = nbs + 1
        Next

        If FiltreAGroup = " ( Assign_Group='" Or FiltreAGroup = " and ( Assign_Group='" Then
            FiltreAGroup = ""

            'nbs2 = 0
        Else
            nbs2 = 1
            FiltreAGroup = FiltreAGroup & ") "
        End If

        '***********Workstream************
        FiltreWorkstream = " ( Workstream "

        nbs = 0
        If nbs2 <> 0 Then
            FiltreWorkstream = " and" & FiltreWorkstream
        End If
        For Each itemChecked In CLBFilterWorkstream.CheckedItems
            If itemChecked.item("Workstream").ToString = "" Then
                Itemchk = "is null"
            Else
                Itemchk = "='" & itemChecked.item("Workstream").ToString & "'"
            End If
            If nbs = 0 Then
                FiltreWorkstream = FiltreWorkstream & Itemchk
                'MsgBox(itemChecked.item("State").ToString)
            Else
                FiltreWorkstream = FiltreWorkstream & " or Workstream " & Itemchk
            End If
            nbs = nbs + 1
        Next

        If FiltreWorkstream = " ( Workstream " Or FiltreWorkstream = " and ( Workstream " Then
            FiltreWorkstream = ""

            'nbs2 = 0
        Else
            nbs2 = 1
            FiltreWorkstream = FiltreWorkstream & ") "
        End If
        'FiltreWorkstream = " ( Workstream='"
        'nbs = 0
        'If nbs2 <> 0 Then
        '    FiltreWorkstream = " and" & FiltreWorkstream
        'End If
        'For Each itemChecked In CLBFilterWorkstream.CheckedItems
        '    If nbs = 0 Then
        '        FiltreWorkstream = FiltreWorkstream & itemChecked.item("Workstream").ToString & "'"
        '        'MsgBox(itemChecked.item("State").ToString)
        '    Else
        '        FiltreWorkstream = FiltreWorkstream & " or " & "Workstream='" & itemChecked.item("Workstream").ToString & "'"
        '    End If
        '    nbs = nbs + 1
        'Next

        'If FiltreWorkstream = " ( Workstream='" Or FiltreWorkstream = " and ( Workstream='" Then
        '    FiltreWorkstream = ""

        '    'nbs2 = 0
        'Else
        '    nbs2 = 1
        '    FiltreWorkstream = FiltreWorkstream & ") "
        'End If

        '***********VTP************
        FiltreVTP = " ( VTP "

        nbs = 0
        If nbs2 <> 0 Then
            FiltreVTP = " and" & FiltreVTP
        End If
        For Each itemChecked In CLBVTP.CheckedItems
            If itemChecked.item("VTP").ToString = "" Then
                Itemchk = "is null"
            Else
                Itemchk = "='" & itemChecked.item("VTP").ToString & "'"
            End If
            If nbs = 0 Then
                FiltreVTP = FiltreVTP & Itemchk
                'MsgBox(itemChecked.item("State").ToString)
            Else
                FiltreVTP = FiltreVTP & " or VTP " & Itemchk
            End If
            nbs = nbs + 1
        Next

        If FiltreVTP = " ( VTP " Or FiltreVTP = " and ( VTP " Then
            FiltreVTP = ""

            'nbs2 = 0
        Else
            nbs2 = 1
            FiltreVTP = FiltreVTP & ") "
        End If


        BS1.Filter = filtreState + FiltrePriority + FiltreAGroup + FiltreWorkstream + FiltreVTP
        TBNbCases.Text = BS1.Count

    End Sub


    Private Sub FBacklog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance


        FirstOpened = 1
        iStatus = 1
        iWorkstream = 1
        iAssign = 1
        iVTP = 1
        iPriority = 1
        Checkedlist()
        'SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
        'SkinManager.ROBOTO_MEDIUM_10 = New Font("Microsoft Sans Serif", 8.25)
        'SkinManager.ROBOTO_MEDIUM_10 = New Font("Algerian", 8)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BExcel.Click
        'Export Excel

        Dim objExcel = CreateObject("Excel.Application")
        Dim fsoObject = CreateObject("Scripting.FileSystemObject")
        Dim i, OptGcent As Integer

        objExcel.Visible = True
        objExcel.Workbooks.Add()

        ' Ajout des titres de colonnes
        OptGcent = 0
        If CBGcent.Checked Then
            OptGcent = 1
        End If
        objExcel.Cells(1, 1).Value = TBCus.Text
        objExcel.Cells(2, 1).Value = "Case"
        objExcel.Cells(2, 1).Font.ColorIndex = 5
        objExcel.Cells(2, 2).Value = "Priority Score"
        objExcel.Cells(2, 2).Font.ColorIndex = 5

        i = 0
        If OptGcent = 1 Then
            objExcel.Cells(2, 3).Value = "CQ_Card"
            objExcel.Cells(2, 3).Font.ColorIndex = 5
            objExcel.Cells(2, 4).Value = "Card Status"
            objExcel.Cells(2, 4).Font.ColorIndex = 5

            objExcel.Cells(2, 3).Value = "CQ_Card"
            objExcel.Cells(2, 3).Font.ColorIndex = 5
            objExcel.Cells(2, 3).Value = "Card Status"
            objExcel.Cells(2, 3).Font.ColorIndex = 5
            objExcel.Cells(2, 3).Value = "Label"
            objExcel.Cells(2, 3).Font.ColorIndex = 5
            objExcel.Cells(2, 3).Value = "Assigned"
            objExcel.Cells(2, 3).Font.ColorIndex = 5
            objExcel.Cells(2, 3).Value = "Correction Date"
            objExcel.Cells(2, 3).Font.ColorIndex = 5
            objExcel.Cells(2, 3).Value = "Retrofited from Card"
            objExcel.Cells(2, 3).Font.ColorIndex = 5
            i = 8
        End If
        objExcel.Cells(2, 3 + i).Value = "State"
        objExcel.Cells(2, 3 + i).Font.ColorIndex = 5
        objExcel.Cells(2, 4 + i).Value = "Priority"
        objExcel.Cells(2, 4 + i).Font.ColorIndex = 5
        objExcel.Cells(2, 5 + i).Value = "EDD"
        objExcel.Cells(2, 5 + i).Font.ColorIndex = 5
        objExcel.Cells(2, 6 + i).Value = "ECD"
        objExcel.Cells(2, 6 + i).Font.ColorIndex = 5
        objExcel.Cells(2, 7 + i).Value = "Assign Group"
        objExcel.Cells(2, 7 + i).Font.ColorIndex = 5
        objExcel.Cells(2, 8 + i).Value = "VTP"
        objExcel.Cells(2, 8 + i).Font.ColorIndex = 5
        objExcel.Cells(2, 9 + i).Value = "Title"
        objExcel.Cells(2, 9 + i).Font.ColorIndex = 5
        objExcel.Cells(2, 10 + i).Value = "Workstream"
        objExcel.Cells(2, 10 + i).Font.ColorIndex = 5
        objExcel.Cells(2, 11 + i).Value = "Created Date"
        objExcel.Cells(2, 11 + i).Font.ColorIndex = 5
        objExcel.Cells(2, 12 + i).Value = "LastStatusDate"
        objExcel.Cells(2, 12 + i).Font.ColorIndex = 5

        'Export Each Row Start
        i = 0
        For j As Integer = 3 To DGVBacklog.Rows.Count + 2
            Dim columnIndex As Integer = 0
            'Do Until columnIndex = 12 + i

            objExcel.Cells(j, 1).Value = DGVBacklog.Item(0, j - 3).Value.ToString
            objExcel.Cells(j, 2).Value = DGVBacklog.Item(1, j - 3).Value
            If OptGcent = 1 Then
                objExcel.Cells(j, 3).Value = DGVBacklog.Item(2, j - 3).Value
                objExcel.Cells(j, 4).Value = DGVBacklog.Item(3, j - 3).Value
                objExcel.Cells(j, 3).Value = DGVBacklog.Item(4, j - 3).Value
                objExcel.Cells(j, 4).Value = DGVBacklog.Item(5, j - 3).Value
                objExcel.Cells(j, 3).Value = DGVBacklog.Item(6, j - 3).Value
                objExcel.Cells(j, 4).Value = DGVBacklog.Item(7, j - 3).Value
                objExcel.Cells(j, 3).Value = DGVBacklog.Item(8, j - 3).Value
                objExcel.Cells(j, 4).Value = DGVBacklog.Item(9, j - 3).Value
                i = 8
            End If
            objExcel.Cells(j, 3 + i).Value = DGVBacklog.Item(2 + i, j - 3).Value
            objExcel.Cells(j, 4 + i).Value = DGVBacklog.Item(3 + i, j - 3).Value
            objExcel.Cells(j, 5 + i).Value = DGVBacklog.Item(4 + i, j - 3).Value
            objExcel.Cells(j, 6 + i).Value = DGVBacklog.Item(5 + i, j - 3).Value
            objExcel.Cells(j, 7 + i).Value = DGVBacklog.Item(6 + i, j - 3).Value
            objExcel.Cells(j, 8 + i).Value = DGVBacklog.Item(7 + i, j - 3).Value
            objExcel.Cells(j, 9 + i).Value = DGVBacklog.Item(8 + i, j - 3).Value
            objExcel.Cells(j, 10 + i).Value = DGVBacklog.Item(9 + i, j - 3).Value
            objExcel.Cells(j, 11 + i).Value = DGVBacklog.Item(10 + i, j - 3).Value
            objExcel.Cells(j, 12 + i).Value = DGVBacklog.Item(11 + i, j - 3).Value
            'Loop
        Next

        ' Autofit des cellules Excel

        objExcel.Columns("A:N").Select()
        objExcel.Selection.Columns.AutoFit()
        objExcel.Range("A1").Select()
        'Export Each Row End
    End Sub

    Private Sub FilterRemove_Click(sender As Object, e As EventArgs) Handles FilterRemove.Click

        For i As Integer = 0 To CLBFilterState.Items.Count - 1
            CLBFilterState.SetItemChecked(i, False)
        Next
        Button1.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        For i As Integer = 0 To CLBFilterPriority.Items.Count - 1
            CLBFilterPriority.SetItemChecked(i, False)
        Next
        Button2.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        For i As Integer = 0 To CLBFilterAGroup.Items.Count - 1
            CLBFilterAGroup.SetItemChecked(i, False)
        Next
        Button3.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        For i As Integer = 0 To CLBFilterWorkstream.Items.Count - 1
            CLBFilterWorkstream.SetItemChecked(i, False)
        Next
        Button4.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        For i As Integer = 0 To CLBVTP.Items.Count - 1
            CLBVTP.SetItemChecked(i, False)
        Next
        Button5.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
    End Sub

    Private Sub Checkedlist()
        'Dim i As Integer
        ''tick all the item in the filer list
        'For i = 0 To CLBFilterState.Items.Count - 1
        '    CLBFilterState.SetItemChecked(i, True)
        'Next
        'For i = 0 To CLBFilterPriority.Items.Count - 1
        '    CLBFilterPriority.SetItemChecked(i, True)
        'Next
        'For i = 0 To CLBFilterAGroup.Items.Count - 1
        '    CLBFilterAGroup.SetItemChecked(i, True)
        'Next
        'For i = 0 To CLBFilterWorkstream.Items.Count - 1
        '    CLBFilterWorkstream.SetItemChecked(i, True)
        'Next
    End Sub

    Private Sub BBacklog_Click(sender As Object, e As EventArgs) Handles BBacklog.Click
        FsearchEvolution.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If iStatus = 0 Then
            For i As Integer = 0 To CLBFilterState.Items.Count - 1
                CLBFilterState.SetItemChecked(i, False)
            Next
            iStatus = 1
            Button1.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        Else
            For i As Integer = 0 To CLBFilterState.Items.Count - 1
                CLBFilterState.SetItemChecked(i, True)
            Next
            iStatus = 0
            Button1.Image = Global.WindowsApplication1.My.Resources.Resources.uncheckall
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If iPriority = 0 Then
            For i As Integer = 0 To CLBFilterPriority.Items.Count - 1
                CLBFilterPriority.SetItemChecked(i, False)
            Next
            iPriority = 1
            Button2.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        Else
            For i As Integer = 0 To CLBFilterPriority.Items.Count - 1
                CLBFilterPriority.SetItemChecked(i, True)
            Next
            iPriority = 0
            Button2.Image = Global.WindowsApplication1.My.Resources.Resources.uncheckall
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If iAssign = 0 Then
            For i As Integer = 0 To CLBFilterAGroup.Items.Count - 1
                CLBFilterAGroup.SetItemChecked(i, False)
            Next
            iAssign = 1
            Button3.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        Else
            For i As Integer = 0 To CLBFilterAGroup.Items.Count - 1
                CLBFilterAGroup.SetItemChecked(i, True)
            Next
            iAssign = 0
            Button3.Image = Global.WindowsApplication1.My.Resources.Resources.uncheckall
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If iWorkstream = 0 Then
            For i As Integer = 0 To CLBFilterWorkstream.Items.Count - 1
                CLBFilterWorkstream.SetItemChecked(i, False)
            Next
            iWorkstream = 1
            Button4.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        Else
            For i As Integer = 0 To CLBFilterWorkstream.Items.Count - 1
                CLBFilterWorkstream.SetItemChecked(i, True)
            Next
            iWorkstream = 0
            Button4.Image = Global.WindowsApplication1.My.Resources.Resources.uncheckall
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If iVTP = 0 Then
            For i As Integer = 0 To CLBVTP.Items.Count - 1
                CLBVTP.SetItemChecked(i, False)
            Next
            iVTP = 1
            Button5.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        Else
            For i As Integer = 0 To CLBVTP.Items.Count - 1
                CLBVTP.SetItemChecked(i, True)
            Next
            iVTP = 0
            Button5.Image = Global.WindowsApplication1.My.Resources.Resources.uncheckall
        End If
    End Sub
End Class