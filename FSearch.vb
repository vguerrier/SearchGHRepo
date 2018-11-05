Imports Oracle.DataAccess.Client
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.IO
Imports MaterialSkin


Public Class FSearch
    Dim LStCase(20) As String
    Dim nbSearch As Integer
    Dim IndSearch As Integer
    Dim Nav As Boolean
    Dim sw As DateTime
    Dim buttonUp As Boolean = False
    Dim holdButtonDuration As Integer = 2000

    'Dim TBIDD As Object

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Size = New Size(300, 104)
        Dim curdir As String
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        BBack.Visible = False
        BNext.Visible = False
        Nav = False
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
        'SkinManager.ROBOTO_MEDIUM_10 = New Font("Microsoft Sans Serif", 8.25)
        'SkinManager.ROBOTO_MEDIUM_10 = New Font("Algerian", 8)

        curdir = System.IO.Directory.GetCurrentDirectory
        'curdir = "C:\logs"
        If My.Computer.FileSystem.DirectoryExists(curdir) Then
        Else
            'If My.Forms.frmMessage.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            ' OK button pressed
            My.Computer.FileSystem.CreateDirectory(curdir)

        End If
        If My.Computer.FileSystem.DirectoryExists("c:\tempSearch\") Then
        Else

            If My.Forms.frmMessage.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                ' OK button pressed
                My.Computer.FileSystem.CreateDirectory("c:\tempSearch\")

            End If
        End If

        If My.Computer.FileSystem.DirectoryExists(curdir) Then
        Else
            If My.Forms.Dlogs.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                ' OK button pressed
                My.Computer.FileSystem.CreateDirectory(curdir)

            End If
        End If

        EcrireLog("", "", curdir)

    End Sub



    Public Sub Research(type As Integer)
        'ret <> 0 on trouvé 
        'ret = 0 on a rien trouvé

        'on identifie la recherche à effectuer : Case, Gcent ou infos branche clients
        'type poermet d'identifier quel type on recherche.
        '0 : pas de type
        '1 case
        '2 gcent
        '3 client
        '4 ressource
        '5 rfe
        '6 workstream

        Dim ret, retRFE, retcus As Integer


        If Nav = False Then
            LStCase(nbSearch) = Me.MSTSearch.Text
        End If
        nbSearch = nbSearch + 1
        If nbSearch > 20 Then
            nbSearch = 0
            IndSearch = 0
            Nav = False
        End If
        If Nav = False Then
            IndSearch = IndSearch + 1
            'Else
            '    nbSearch = nbSearch + 1
        End If

        If nbSearch > 1 And IndSearch > 1 Then
            BBack.Visible = True
        Else
            BBack.Visible = False
        End If

        'si le répertoire n'existe pas on propose de le créer sinon on ne pourra pas sauvegarder les documents
        If My.Computer.FileSystem.DirectoryExists("c:\tempSearch\") Then
        Else
            If My.Forms.frmMessage.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                ' OK button pressed
                My.Computer.FileSystem.CreateDirectory("c:\tempSearch\")

            End If
        End If

        ret = 0
        retRFE = 0
        Try
            If type = 0 Then

                If MMCBBranch.Checked Then
                    'recherche sur les infos clients
                    FCustomer.TBCus.Text = Me.MSTSearch.Text
                    FCustomer.Show()
                    FCustomer.researchCus()
                    MCBBranch.Checked = False
                Else

                    If InStr(Trim(Me.MSTSearch.Text), "GCENT") > 0 Or InStr(Trim(Me.MSTSearch.Text), "GTOP") > 0 Or InStr(Trim(Me.MSTSearch.Text), "GADMI") > 0 Or InStr(Trim(Me.MSTSearch.Text), "GSTOC") > 0 Or InStr(Trim(Me.MSTSearch.Text), "GTRAC") > 0 Or InStr(Trim(Me.MSTSearch.Text), "GCAS") > 0 Then
                        'on recherche une GCENT
                        'on va ouvrir la form GCENT

                        FSearchGcent.TBGcent.Text = Me.MSTSearch.Text
                        FSearchGcent.Show()
                        ret = FSearchGcent.researchCQ()
                    Else
                        If InStr(Trim(Me.MSTSearch.Text), "GLIB") > 0 Then
                            'on recherche une GCENT
                            'on va ouvrir la form GCENT
                            Dim toto = Me.MSTSearch.Text
                            FSearchGcent.TBGcent.Text = Me.MSTSearch.Text
                            FSearchGcent.Show()
                            ret = FSearchGcent.researchGlib()
                        Else
                            'on recherche un case
                            'on va ouvrir la form CASE
                            FSearchCase.RTBCase.Text = Me.MSTSearch.Text
                            'FSearchCase.Show()
                            If MMCBCusCase.Checked Then
                                ' on recherche par numéro du client
                                ret = FSearchCase.researchCase(1)
                                If ret <> 0 Then
                                    FSearchCase.Show()
                                End If

                                MCBCusCase.Checked = False
                            Else
                                ret = FSearchCase.researchCase(0)
                                If ret <> 0 Then
                                    FSearchCase.Show()
                                End If
                                MCBCusCase.Checked = False
                            End If
                            'End If
                        End If
                    End If

                    If ret = 0 Then
                        'recherche sur les infos clients
                        FCustomer.TBCus.Text = Me.MSTSearch.Text

                        ret = FCustomer.researchCus()
                        If ret <> 0 Then
                            'FCustomer.Show()
                        End If
                        MCBBranch.Checked = False
                    End If

                    If ret = 0 Then
                        'recherche sur les infos Ressources
                        ret = FRessources.researchRes(Me.MSTSearch.Text)
                        If ret <> 0 Then
                            FRessources.Show()
                        End If
                    End If

                    If ret = 0 Then
                        retRFE = FSearchRFE.researchRFE(Me.MSTSearch.Text)
                        If retRFE = 0 Then
                            retRFE = FSearchWorkstream.researchWS(Me.MSTSearch.Text)
                            If retRFE <> 0 Then
                                FSearchRFE.Show()
                            End If
                        Else
                            'si on trouve un rfe on va chercher aussi si on a un workstream car ils peuvent avoir le même nom
                            ret = FSearchWorkstream.researchWS(Me.MSTSearch.Text)
                            If ret <> 0 And retRFE = 0 Then
                                FSearchWorkstream.Show()
                            Else
                                'on a le cas où on a un RFE et un workstream avec le même nom. on propose le choix.
                                FSearchSelect.Show()
                                FSearchSelect.List(Me.MSTSearch.Text, "RFE")
                                FSearchSelect.List(Me.MSTSearch.Text, "Workstream")
                            End If
                        End If
                    End If



                    If ret = 0 Then
                        MsgBox("Not a card, Case, customer or ressource please retry")
                    End If
                End If
            Else
                Select Case type
                    Case 1
                        ret = FSearchCase.researchCase(0)
                        If ret <> 0 Then
                            FSearchCase.Show()
                        End If
                    Case 2
                        If InStr(Trim(Me.MSTSearch.Text), "GCENT") > 0 Or InStr(Trim(Me.MSTSearch.Text), "GTOP") > 0 Or InStr(Trim(Me.MSTSearch.Text), "GADMI") > 0 Or InStr(Trim(Me.MSTSearch.Text), "GSTOC") > 0 Or InStr(Trim(Me.MSTSearch.Text), "GTRAC") > 0 Or InStr(Trim(Me.MSTSearch.Text), "GCAS") > 0 Then
                            'on recherche une GCENT
                            'on va ouvrir la form GCENT

                            FSearchGcent.TBGcent.Text = Me.MSTSearch.Text
                            FSearchGcent.Show()
                            ret = FSearchGcent.researchCQ()
                        Else
                            If InStr(Trim(Me.MSTSearch.Text), "GLIB") > 0 Then
                                'on recherche une GCENT
                                'on va ouvrir la form GCENT
                                Dim toto = Me.MSTSearch.Text
                                FSearchGcent.TBGcent.Text = Me.MSTSearch.Text
                                FSearchGcent.Show()
                                ret = FSearchGcent.researchGlib()
                            End If
                        End If
                    Case 3
                        FCustomer.TBCus.Text = Me.MSTSearch.Text

                        ret = FCustomer.researchCus()
                        If ret <> 0 Then
                            'FCustomer.Show()
                        End If
                    Case 4
                        ret = FRessources.researchRes(Me.MSTSearch.Text)
                        If ret <> 0 Then
                            FRessources.Show()
                        End If
                    Case 5
                        'recherche sur les RFE
                        ret = FSearchRFE.researchRFE(Me.MSTSearch.Text)
                        If ret <> 0 Then
                            FSearchRFE.Show()
                        End If
                    Case 6
                        'recherche sur les workstream
                        ret = FSearchWorkstream.researchWS(Me.MSTSearch.Text)
                        If ret <> 0 Then
                            FSearchWorkstream.Show()
                        End If

                End Select


            End If
        Catch ex As Exception
            If retcus = 0 Then
                MsgBox("Not a card or a case, please retry")

            Else
                MsgBox(ex.Message)
            End If
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TBSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then
            'Call Research(0)
            Research(0)
            'supprime lebbep quand on presse enter
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub BSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Research(0)
        'Me.Size = New Size(314, 704)
        'FSearchCase.Size = New Size(776, 455)
    End Sub


    Private Sub LLBlinkCQ_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("https://intranet.eyc.com/product/Gold/ProductSupportRetail/Documents/Search Help.pdf")
    End Sub



    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)
        Dabout.Show()
    End Sub

    Private Sub MCBBranch_Click(sender As Object, e As System.EventArgs) Handles MCBBranch.Click
        MCBCusCase.Checked = False
    End Sub

    Private Sub MCBCusCase_Click(sender As Object, e As System.EventArgs) Handles MCBCusCase.Click
        MCBBranch.Checked = False
    End Sub

    Private Sub LLBlinkCQ_LinkClicked_1(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LLBlinkCQ.LinkClicked
        System.Diagnostics.Process.Start("https://intranet.eyc.com/product/Gold/ProductSupportRetail/Documents/Search Help.pdf")
    End Sub

    Private Sub MFBSearch_Click(sender As Object, e As EventArgs) Handles MFBSearch.Click
        Nav = False
        Research(0)
    End Sub


    Private Sub MSTSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MSTSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Call Research(0)
            Nav = False
            Research(0)
            'supprime lebbep quand on presse enter
            e.SuppressKeyPress = True
        End If
    End Sub



    Private Sub BPlus_Click(sender As Object, e As EventArgs) Handles BPlus.Click
        If Me.Height = 135 Then
            Me.Height = 220
            BPlus.Visible = False
            Bminus.Visible = True

        Else
            Me.Height = 135
            BPlus.Visible = True
            Bminus.Visible = False
        End If
    End Sub

    Private Sub Bminus_Click(sender As Object, e As EventArgs) Handles Bminus.Click
        If Me.Height = 135 Then
            Me.Height = 220
            BPlus.Visible = False
            Bminus.Visible = True

        Else
            Me.Height = 135
            BPlus.Visible = True
            Bminus.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dabout.Show()
    End Sub

    Private Sub FSearch_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

    End Sub


    Private Sub BBack_MouseDown(sender As Object, e As MouseEventArgs) Handles BBack.MouseDown

        buttonUp = False
        sw = DateTime.Now
        While (e.Button = MouseButtons.Left And e.Clicks = 1 And (buttonUp = False And (DateTime.Now - sw).TotalMilliseconds < holdButtonDuration))
            Application.DoEvents()
        End While
        If ((DateTime.Now - sw).TotalMilliseconds >= holdButtonDuration) Then
            Llong.Location = New Point(e.X + BBack.Location.X, e.Y + BBack.Location.Y)
            Llong.Visible = False

            'MessageBox.Show("Long")
        End If
    End Sub

    Private Sub BBack_MouseUp(sender As Object, e As MouseEventArgs) Handles BBack.MouseUp

        buttonUp = True
    End Sub


    Private Sub BBack_Click(sender As Object, e As EventArgs) Handles BBack.Click
        IndSearch = IndSearch - 1
        Nav = True
        If IndSearch > 0 Then
            'MsgBox(LStCase(IndSearch - 1))
            Me.MSTSearch.Text = LStCase(IndSearch - 1)
            BNext.Visible = True
            nbSearch = nbSearch - 1
            Research(0)
        Else
            BBack.Visible = False
        End If
    End Sub

    Private Sub BNext_Click(sender As Object, e As EventArgs) Handles BNext.Click
        IndSearch = IndSearch + 1
        Nav = True
        If IndSearch <= nbSearch Then
            'MsgBox(LStCase(IndSearch - 1))
            Me.MSTSearch.Text = LStCase(IndSearch - 1)
            BBack.Visible = True
            nbSearch = nbSearch - 1
            Research(0)
            If IndSearch = nbSearch Then
                BNext.Visible = False
            End If
        Else
            BNext.Visible = False
        End If

    End Sub

End Class