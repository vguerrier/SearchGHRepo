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
    Dim FirstOpened As Integer

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
            Case "condition 3", "condition 4"


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

    Function researchBacklog() As Integer
        Dim Sqldb As String = "Data Source=seyccrmsqlsip1;Integrated Security=SSPI;Initial Catalog=crm_MSCRM"
        Dim SqlConn As New SqlClient.SqlConnection(Sqldb)
        Dim SqlCmd As New SqlCommand
        Dim myReader As SqlDataReader
        Dim req As String
        Dim nbrow As Integer
        Dim Opt, OptGcent As Integer
        Dim MonDataSet, MonDataSetState, MonDataSetPriority, MonDataSetAgroup, MonDataSetWorkstream As New DataSet
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
            req = RequestBacklog(Trim(TBCus.Text), "state", Opt, OptGcent)


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
            req = RequestBacklog(Trim(TBCus.Text), "Priority", Opt, OptGcent)


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
            req = RequestBacklog(Trim(TBCus.Text), "Assign_Group", Opt, OptGcent)


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
            req = RequestBacklog(Trim(TBCus.Text), "Workstream", Opt, OptGcent)


            SqlCmd.CommandText = req

            Adaptateur.SelectCommand = SqlCmd
            Adaptateur.Fill(MonDataSetWorkstream, "backlog")

            myReader = SqlCmd.ExecuteReader()

            CLBFilterWorkstream.DataSource = MonDataSetWorkstream.Tables("backlog")
            CLBFilterWorkstream.DisplayMember = "Workstream"

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
            i = 1
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
        FSearch.Research()
    End Sub

    Private Sub BBfilter_Click(sender As System.Object, e As System.EventArgs) Handles Bfilter.Click
        Dim filtreState, FiltrePriority, FiltreAGroup, FiltreWorkstream As String
        Dim nbs, nbs2 As Integer

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
        FiltreWorkstream = " ( Workstream='"
        nbs = 0
        If nbs2 <> 0 Then
            FiltreWorkstream = " and" & FiltreWorkstream
        End If
        For Each itemChecked In CLBFilterWorkstream.CheckedItems
            If nbs = 0 Then
                FiltreWorkstream = FiltreWorkstream & itemChecked.item("Workstream").ToString & "'"
                'MsgBox(itemChecked.item("State").ToString)
            Else
                FiltreWorkstream = FiltreWorkstream & " or " & "Workstream='" & itemChecked.item("Workstream").ToString & "'"
            End If
            nbs = nbs + 1
        Next

        If FiltreWorkstream = " ( Workstream='" Or FiltreWorkstream = " and ( Workstream='" Then
            FiltreWorkstream = ""

            'nbs2 = 0
        Else
            nbs2 = 1
            FiltreWorkstream = FiltreWorkstream & ") "
        End If

        BS1.Filter = filtreState + FiltrePriority + FiltreAGroup + FiltreWorkstream
        TBNbCases.Text = BS1.Count

    End Sub


    Private Sub FBacklog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance


        FirstOpened = 1
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
            i = 1
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
        For j As Integer = 3 To DGVBacklog.Rows.Count - 1
            Dim columnIndex As Integer = 0
            'Do Until columnIndex = 12 + i

            objExcel.Cells(j, 1).Value = DGVBacklog.Item(0, j - 2).Value.ToString
            objExcel.Cells(j, 2).Value = DGVBacklog.Item(1, j - 2).Value
            If OptGcent = 1 Then
                objExcel.Cells(j, 3).Value = DGVBacklog.Item(2, j - 2).Value
                i = 1
            End If
            objExcel.Cells(j, 3 + i).Value = DGVBacklog.Item(2 + i, j - 2).Value
            objExcel.Cells(j, 4 + i).Value = DGVBacklog.Item(3 + i, j - 2).Value
            objExcel.Cells(j, 5 + i).Value = DGVBacklog.Item(4 + i, j - 2).Value
            objExcel.Cells(j, 6 + i).Value = DGVBacklog.Item(5 + i, j - 2).Value
            objExcel.Cells(j, 7 + i).Value = DGVBacklog.Item(6 + i, j - 2).Value
            objExcel.Cells(j, 8 + i).Value = DGVBacklog.Item(7 + i, j - 2).Value
            objExcel.Cells(j, 9 + i).Value = DGVBacklog.Item(8 + i, j - 2).Value
            objExcel.Cells(j, 10 + i).Value = DGVBacklog.Item(9 + i, j - 2).Value
            objExcel.Cells(j, 11 + i).Value = DGVBacklog.Item(10 + i, j - 2).Value
            objExcel.Cells(j, 12 + i).Value = DGVBacklog.Item(11 + i, j - 2).Value
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
        For i As Integer = 0 To CLBFilterPriority.Items.Count - 1
            CLBFilterPriority.SetItemChecked(i, False)
        Next
        For i As Integer = 0 To CLBFilterAGroup.Items.Count - 1
            CLBFilterAGroup.SetItemChecked(i, False)
        Next
        For i As Integer = 0 To CLBFilterWorkstream.Items.Count - 1
            CLBFilterWorkstream.SetItemChecked(i, False)
        Next
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
End Class