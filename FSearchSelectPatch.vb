Imports MaterialSkin
Imports System.Data
Imports System.Data.OleDb
Imports Oracle.ManagedDataAccess.Client ' ODP.NET Oracle managed provider
Imports Oracle.ManagedDataAccess.Types
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.IO



Public Class FsearchSelectPatch

    Private lvwColumnSorter As ListViewColumnSorter

    Private Sub FSearchSelectPatch_Load(sender As Object, e As EventArgs) Handles Me.Load

        lvwColumnSorter = New ListViewColumnSorter()
        Me.LVPatch.ListViewItemSorter = lvwColumnSorter
        'LVPatch.Items.Clear()
    End Sub


    Function RequestPatch(Patch As String) As String
        Dim CQbase As String

        CQbase = "cqcentral"


        RequestPatch = "(select a.numeroreference, a.numerofiche, c.nom, a.titre, r.nom from  "
        RequestPatch = RequestPatch & " cqcentral.anomalie a, cqcentral.client c, cqcentral.rfe r "
        RequestPatch = RequestPatch & " where a.rfecode = r.dbid and a.client_champ = c.dbid and a.identificationexterne = '" + Patch + "'"
        RequestPatch = RequestPatch & " union select a.numeroreference, a.numerofiche, c.nom , a.titre, r.nom from cqgtop.anomalie a, cqgtop.client c, cqgtop.rfe r "
        RequestPatch = RequestPatch & " where a.rfecode = r.dbid and a.client_champ = c.dbid and a.identificationexterne = '" + Patch + "'"
        RequestPatch = RequestPatch & " union select a.numeroreference, a.numerofiche, c.nom , a.titre, r.nom from CQGOLDSTOCK.anomalie a, CQGOLDSTOCK.client c, CQGOLDSTOCK.rfe r "
        RequestPatch = RequestPatch & " where a.rfecode = r.dbid and a.client_champ = c.dbid and a.identificationexterne = '" + Patch + "'"
        RequestPatch = RequestPatch & " union select a.numeroreference, a.numerofiche, c.nom , a.titre, r.nom from cqgtrack.anomalie a, cqgtrack.client c, cqgtrack.rfe r "
        RequestPatch = RequestPatch & " where a.rfecode = r.dbid and a.client_champ = c.dbid and a.identificationexterne = '" + Patch + "'"
        RequestPatch = RequestPatch & " union select a.numeroreference, a.numerofiche, c.nom , a.titre, r.nom from cqcas.anomalie a, cqcas.client c, cqcas.rfe r "
        RequestPatch = RequestPatch & " where a.rfecode = r.dbid and a.client_champ = c.dbid and a.identificationexterne = '" + Patch + "'"
        RequestPatch = RequestPatch & " union select a.numeroreference, a.numerofiche, c.nom , a.titre, r.nom from cqgadmin.anomalie a, cqgadmin.client c, cqgadmin.rfe r "
        RequestPatch = RequestPatch & " where a.rfecode = r.dbid and a.client_champ = c.dbid and a.identificationexterne = '" + Patch + "'"
        RequestPatch = RequestPatch & " union select a.numeroreference, a.numerofiche, c.nom , a.titre, r.nom from CQGOLDEVENTS.anomalie a, CQGOLDEVENTS.client c, CQGOLDEVENTS.rfe r "
        RequestPatch = RequestPatch & " where a.rfecode = r.dbid and a.client_champ = c.dbid and a.identificationexterne = '" + Patch + "')"
        RequestPatch = RequestPatch & " order by 1 asc"


    End Function

    Private Sub LVChoice_DoubleClick(sender As System.Object, e As System.EventArgs) Handles LVPatch.DoubleClick
        Dim comment As String
        Dim nb As Point



        LVPatch.FullRowSelect = True
        'Donnees = CStr(Item.Item(Index.Item(0)).SubItems(0).Text)

        comment = LVPatch.FocusedItem.SubItems(1).Text
        If InStr(LVPatch.FocusedItem.SubItems(0).Text, "CAS-") <> 0 Then
            FSearch.MSTSearch.Text = LVPatch.FocusedItem.SubItems(0).Text
        Else
            FSearch.MSTSearch.Text = LVPatch.FocusedItem.SubItems(1).Text
        End If
        FSearch.Research(0)
        'FSearch.MSTSearch.Text = LVPatch.FocusedItem.SubItems(1).Text
        'FSearch.MSTSearch.Text = "tyty"
        nb = LVPatch.FocusedItem.Position
        TBNB.Text = nb.X.ToString + " " + nb.Y.ToString
        'TBNB.Text = LVPatch.SelectedItems.Item(0).Text
        'TBNB.Text = LVPatch.SelectedItems(0).Text

        'Me.Close()
    End Sub
    Public Function researchPatch(patch As String) As Integer
        Dim oradb As String = "Data Source=CQSCM1_SEYCSMC1;User Id=readcquest;Password=readcquest;"
        Dim conn As New OracleConnection(oradb)
        Dim myCommand As New OracleCommand
        Dim dr As OracleDataReader

        Dim nb As Integer
        'Dim LVITime As New ListViewItem()
        'CEN510-SP26JUL18-18

        nb = 0
        TBPatch.Text = patch
        'opening the connection
        conn.Open()
        Dim request As String = RequestPatch(patch)
        'request = "select 1 from dual"
        myCommand = conn.CreateCommand()
        myCommand.CommandText = request

        'executing the command and assigning it to connection
        dr = myCommand.ExecuteReader()
        While dr.Read()
            Dim LVITime As New ListViewItem(dr.GetValue(0).ToString)
            'If dr.GetValue(0) IsNot DBNull.Value Then
            '    LVITime.SubItems.Add(dr.GetValue(0))
            'End If
            If dr.GetValue(1) IsNot DBNull.Value Then
                LVITime.SubItems.Add(dr.GetValue(1))
            Else
                LVITime.SubItems.Add("")
            End If
            If dr.GetValue(2) IsNot DBNull.Value Then
                LVITime.SubItems.Add(dr.GetValue(2))
            Else
                LVITime.SubItems.Add("")
            End If
            If dr.GetValue(4) IsNot DBNull.Value Then
                LVITime.SubItems.Add(dr.GetValue(4))
            Else
                LVITime.SubItems.Add("")
            End If
            If dr.GetValue(3) IsNot DBNull.Value Then
                LVITime.SubItems.Add(dr.GetValue(3))
            Else
                LVITime.SubItems.Add("")
            End If
            nb = nb + 1
            LVPatch.Items.AddRange(New ListViewItem() {LVITime})

        End While
        TBNB.Text = nb
        researchPatch = nb
    End Function

    Private Sub LVPatch_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles LVPatch.ColumnClick
        ' Determine if the clicked column is already the column that is 
        ' being sorted.
        If (e.Column = lvwColumnSorter.SortColumn) Then
            ' Reverse the current sort direction for this column.
            If (lvwColumnSorter.Order = 1) Then
                lvwColumnSorter.Order = 2
            Else
                lvwColumnSorter.Order = 1
            End If
        Else
            ' Set the column number that is to be sorted; default to ascending.
            lvwColumnSorter.SortColumn = e.Column
            If (lvwColumnSorter.Order = 1) Then
                lvwColumnSorter.Order = 2
            Else
                lvwColumnSorter.Order = 1
            End If
            'lvwColumnSorter.Order = SortOrder.Ascending
        End If

        'If e.Column = lvwColumnSorter.SortColumn And lvwColumnSorter.Order = SortOrder.Descending Then
        '    lvwColumnSorter.Order = SortOrder.Ascending
        'Else
        '    lvwColumnSorter.Order = SortOrder.Descending
        'End If

        ' Perform the sort with these new sort options.
        Me.LVPatch.Sort()
        'Me.
    End Sub
End Class