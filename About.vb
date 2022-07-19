Imports System.Windows.Forms
' importatation du module E/S
Imports System.IO

Public Class Dabout

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        System.Diagnostics.Process.Start("mailto:vincent.guerrier@symphonyretailai.com?subject=Search")

    End Sub

    Private Sub LLBlinkCQ_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LLBlinkCQ.LinkClicked
        System.Diagnostics.Process.Start("https://eyc.sharepoint.com/sites/RS_SCM_RD/All_Documents/Search%20Help.pdf")
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim CurDir As String

        CurDir = System.IO.Directory.GetCurrentDirectory
        System.Diagnostics.Process.Start(CurDir)

        'Try
        '    CurDir = System.IO.Directory.GetCurrentDirectory
        '    Dim fichiers() As String = Directory.GetFiles(CurDir, "*.txt")

        '    ' trie des fichiers par ordre alphabétique
        '    Array.Sort(fichiers)

        '    If (fichiers.Length > 0) Then
        '        ' le nom du fichiers sera (temporairement) le dernier de la liste
        '        nomFichier = fichiers(fichiers.Length - 1)
        '        'nomFichier = "Log.txt"
        '        'récupération des informations du fichier
        '        Dim fi As New FileInfo(nomFichier)
        '        'si le fichier est supérieur à la taille max on remer le nom du fichier à vide
        '        If (fi.Length > 800000) Then
        '            nomFichier = ""
        '        End If
        '    End If

        '    fileReader = My.Computer.FileSystem.ReadAllText(nomFichier)
        '    MsgBox(fileReader)

        '    'Dim CurDir As String
        '    'Dim i As Integer
        '    'Try

        '    '    affichage Log
        '    '        CurDir = System.IO.Directory.GetCurrentDirectory
        '    '    Dim fichiers() As String = Directory.GetFiles(CurDir, "*.txt")
        '    '    Dim nomFichier As String = ""
        '    '    trie des fichiers par ordre alphabétique
        '    '        Array.Sort(fichiers)
        '    '    si on a au moins un fichiers
        '    '        If (fichiers.Length > 0) Then
        '    '        le nom du fichiers sera (temporairement) le dernier de la liste
        '    '            nomFichier = fichiers(fichiers.Length - 1)
        '    '        nomFichier = "Log.txt"
        '    '        récupération des informations du fichier
        '    '            Dim fi As New FileInfo(nomFichier)
        '    '        si le fichier est supérieur à la taille max on remer le nom du fichier à vide
        '    '            If (fi.Length > 800000) Then
        '    '            nomFichier = ""
        '    '        End If
        '    '    End If

        '    '    si le nom du fichier est vide on va créer un nouveau fichier
        '    '        If nomFichier = "" Then
        '    '        nomFichier = CurDir + "\" + "Log" + "_" + CStr(fichiers.Length) + ".txt"
        '    '    End If
        '    '    ouverture d'un lien vers le fichier
        '    '    Dim sr As New StreamReader(nomFichier)
        '    '    Dim line As String
        '    '    Read And display lines from the file until the end of 
        '    '         the File Is reached.
        '    '        line = sr.ReadLine()
        '    '        While ((sr.ReadLine()) IsNot DBNull.Value)
        '    '        line = line + sr.ReadLine()
        '    '        Console.WriteLine(line)
        '    '    End While
        '    '    MsgBox(line)

        '    '    fermeture du lien vers le fichier
        '    '        sr.Close()

        'Catch ex As Exception
        '    'erreur, impossible d'ecrire dans le fichier
        '    MsgBox("Erreur de lecture du fichier LOG : " + ex.Message)
        'End Try
    End Sub


End Class
