' importatation du module E/S
Imports System.IO

Module LogMod

    'objet de log qui sera unique (singleton)
    Private objLog As log4Raid

    'procédure qui sera appeler pour ecrire dans un fichier log (exemple)
    Public Sub EcrireLog(type As String, texte As String, directory As String)
        If (objLog Is Nothing) Then
            'objLog = New log4Raid(Environment.CurrentDirectory + "\logs", "Log")
            objLog = New log4Raid(directory, "Log")

        End If
        objLog.EcrireLog(type, texte)
    End Sub

    'classe de log
    Private Class log4Raid
        'format de la date
        Private date_format As String
        'chemin vers le dossier des logs
        Private path As String
        'nom de base des fichiers de log
        Private base_name As String
        'longeur max avant de changer de numéro de fichier
        Private file_length As Long

        Public Sub New(p_path As String, p_base_name As String, Optional ByVal p_file_length As Long = 800000, Optional ByVal p_date_format As String = "dd/MM/yyyy HH:mm:ss")
            path = p_path
            base_name = p_base_name
            file_length = p_file_length
            date_format = p_date_format
        End Sub

        Public Sub EcrireLog(type As String, texte As String)
            Try
                'recherche du nom de fichier
                'liste des fichiers du repertoire
                Dim fichiers() As String = Directory.GetFiles(path, "*.txt")
                'definition du nom du fichier
                Dim nomFichier As String = ""
                ' trie des fichiers par ordre alphabétique
                Array.Sort(fichiers)
                'si on a au moins un fichiers
                If (fichiers.Length > 0) Then
                    ' le nom du fichiers sera (temporairement) le dernier de la liste
                    nomFichier = fichiers(fichiers.Length - 1)
                    'récupération des informations du fichier
                    Dim fi As New FileInfo(nomFichier)
                    'si le fichier est supérieur à la taille max on remer le nom du fichier à vide
                    If (fi.Length > file_length) Then
                        nomFichier = ""
                    End If
                End If

                ' si le nom du fichier est vide on va créer un nouveau fichier
                If nomFichier = "" Then
                    nomFichier = path + "\" + base_name + "_" + CStr(fichiers.Length) + ".txt"
                End If
                'ouverture d'un lien vers le fichier
                Dim LogStream As New StreamWriter(nomFichier, True, System.Text.Encoding.UTF8)
                'ecriture sur le fichier
                LogStream.WriteLine(Format(Now(), date_format) + ": " + type + " : " + texte)
                'fermeture du lien vers le fichier
                LogStream.Close()
            Catch ex As Exception
                'erreur, impossible d'ecrire dans le fichier
                MsgBox("Erreur d'écriture dans les fichiers LOG : " + ex.Message)
            End Try
        End Sub
    End Class
End Module
