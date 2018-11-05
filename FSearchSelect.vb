Imports MaterialSkin
Public Class FSearchSelect

    Private Sub FSearchSelect_Load(sender As Object, e As EventArgs) Handles Me.Load

        LVChoice.Items.Clear()
    End Sub
    Public Sub List(name As String, type As String)
        'LVChoice.Items.Clear()

        Dim LVITime As New ListViewItem(name)

        LVITime.SubItems.Add(type)
        LVChoice.Items.AddRange(New ListViewItem() {LVITime})

    End Sub

    Private Sub LVChoice_DoubleClick(sender As System.Object, e As System.EventArgs) Handles LVChoice.DoubleClick
        Dim comment As String

        comment = LVChoice.FocusedItem.SubItems(1).Text
        'FSearch.MSTSearch.Text = comment

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
        Me.Close()
    End Sub


End Class