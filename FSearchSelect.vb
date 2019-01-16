Imports MaterialSkin
Imports ListViewColumnSorter
Public Class FSearchSelect

    Private lvwColumnSorter As ListViewColumnSorter

    Private Sub FSearchSelect_Load(sender As Object, e As EventArgs) Handles Me.Load

        lvwColumnSorter = New ListViewColumnSorter()
        Me.LVChoice.ListViewItemSorter = lvwColumnSorter
        LVChoice.Items.Clear()
    End Sub
    Public Sub List(name As String, type As String)
        'LVChoice.Items.Clear()

        Dim LVITime As New ListViewItem(name)

        LVITime.SubItems.Add(type)
        LVChoice.Items.AddRange(New ListViewItem() {LVITime})

    End Sub

    Public Sub ListCases(name As String, type As String, Titre As String)
        'LVChoice.Items.Clear()

        Dim LVITime As New ListViewItem(name)
        LVITime.SubItems.Add(type)
        LVITime.SubItems.Add(Titre)
        LVChoice.Items.AddRange(New ListViewItem() {LVITime})

    End Sub

    Private Sub LVChoice_DoubleClick(sender As System.Object, e As System.EventArgs) Handles LVChoice.DoubleClick
        Dim comment As String

        comment = LVChoice.FocusedItem.SubItems(1).Text
        FSearch.MSTSearch.Text = LVChoice.FocusedItem.SubItems(0).Text
        'FSearch.MSTSearch.Text = "tyty"

        If comment = "Case" Then
            FSearch.Research(1)
        ElseIf comment = "Gcent" Then
            FSearch.Research(2)
        ElseIf comment = "Customer" Then
            FSearch.Research(3)
        ElseIf comment = "Ressource" Then
            FSearch.Research(4)
        ElseIf comment = "RFE" Then
            FSearch.Research(5)
        ElseIf comment = "Workstream" Then
            FSearch.Research(6)
        End If
        'Me.Close()
    End Sub



    Private Sub LVChoice_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles LVChoice.ColumnClick
        ' Determine if the clicked column is already the column that is 
        ' being sorted.
        If (e.Column = lvwColumnSorter.SortColumn) Then
            ' Reverse the current sort direction for this column.
            If (lvwColumnSorter.Order = SortOrder.Ascending) Then
                lvwColumnSorter.Order = SortOrder.Descending
            Else
                lvwColumnSorter.Order = SortOrder.Ascending
            End If
        Else
            ' Set the column number that is to be sorted; default to ascending.
            lvwColumnSorter.SortColumn = e.Column
            If (lvwColumnSorter.Order = SortOrder.Ascending) Then
                lvwColumnSorter.Order = SortOrder.Descending
            Else
                lvwColumnSorter.Order = SortOrder.Ascending
            End If
            'lvwColumnSorter.Order = SortOrder.Ascending
        End If

        'If e.Column = lvwColumnSorter.SortColumn And lvwColumnSorter.Order = SortOrder.Descending Then
        '    lvwColumnSorter.Order = SortOrder.Ascending
        'Else
        '    lvwColumnSorter.Order = SortOrder.Descending
        'End If

        ' Perform the sort with these new sort options.
        Me.LVChoice.Sort()
        'Me.
    End Sub
End Class