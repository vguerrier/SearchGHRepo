
Imports System.Data
Imports System.Data.OleDb
Imports Oracle.ManagedDataAccess.Client ' ODP.NET Oracle managed provider
Imports Oracle.ManagedDataAccess.Types
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.IO

Public Structure Appli
    Public Appliname As String
    Public Framework As String
    Public Framework_Spring As String
    Public BranchProduct As String
    Public URL As String
    Public Schemas() As String
End Structure

Public Structure Env
    Public Envname As String
    Public EnvType As String
    Public server As String
    Public Oracle As String
    Public java As String
    Public NbAppli As Integer
    Public NbSchemas As Integer

    Public Appli() As Appli
End Structure

Public Structure Branch
    Public Branchname As String
    Public Label As String
    Public BranchType As String
    Public Application As String
    Public Description As String
    Public NbEnv As Integer

    Public Env() As Env
End Structure

Public Structure Cus
    Public CustomerName As String
    Public Branch() As Branch
    Public NbBranch As Integer
End Structure

Module MyModule
    Public Const NbCusmax = 50
    Public Customers As Cus
    Declare Auto Function FindWindow Lib "User32.dll" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Public Declare Function IsWindowVisible Lib "User32" Alias "IsWindowVisible" (ByVal hWnd As IntPtr) As Boolean
    Public Declare Function ShowWindow Lib "User32" Alias "ShowWindow" (handle As IntPtr, nCmdShow As Integer) As Boolean

    Public Function GetBranchDesc(Branchname As String) As String
        Dim i As Integer
        i = 0

        While i < NbCusmax And Customers.Branch(i).Branchname <> Branchname
            i = i + 1
        End While
        If i < NbCusmax Then
            GetBranchDesc = Customers.Branch(i).Description
        Else
            GetBranchDesc = "No"
        End If

    End Function
    Public Function GetBranchType(Branchname As String) As String
        Dim i As Integer
        i = 0

        While i < NbCusmax And Customers.Branch(i).Branchname <> Branchname
            i = i + 1
        End While
        If i < NbCusmax Then
            GetBranchType = Customers.Branch(i).BranchType
        Else
            GetBranchType = "No"
        End If

    End Function

    'Public Function GetAppli(Appliname As String, branch As String) As Env
    '    Dim i, j As Integer
    '    Dim brch As Env
    '    i = 0
    '    j = 0

    '    brch.Envname = "no"

    '    While i < NbCusmax And j < NbCusmax
    '        i = i + 1
    '        While j < NbCusmax And Customers.Branch(i).Env(j).Envname <> Appliname
    '            j = j + 1
    '        End While
    '    End While
    '    If j < NbCusmax Then
    '        brch = Customers.Branch(i).Env(j)

    '    End If
    '    GetAppli = brch
    'End Function

End Module

Public Class FCustomer

    Function RequestBacklog(Branch As String) As String


        RequestBacklog = "select t.p_customer, t.BRANCHNAME, t2.ENVTYPE, t.BRANCHTYPE, t.p_label, t.DESCRIPTION, t2.P_SERVER, t2.P_ORACLE, t2.P_JAVA, t.application "
        RequestBacklog = RequestBacklog & "from V_INFRA_BRANCH t, v_infra_env t2 "
        RequestBacklog = RequestBacklog & "where(t.BRANCHNAME = t2.P_BRANCH) "
        RequestBacklog = RequestBacklog & "and (upper(t.BRANCHNAME) like upper('%" + Branch + "%') "
        'RequestBacklog = RequestCus & "or upper(t.P_LABEL) like upper('%" + Branch + "%')"
        RequestBacklog = RequestBacklog & "or upper(t.P_CUSTOMER) like upper('%" + Branch + "%') "
        RequestBacklog = RequestBacklog & "or t.p_label like'" + Branch + "%' ) "
        RequestBacklog = RequestBacklog & "order by 2 "


    End Function

    Function RequestAppli(Branch As String, envtype As String) As String
        RequestAppli = "select t1.branch, t1.appli, t1.client_version_value, t3.url, t1.SERVER_VERSION_VALUE, t3.CRMAPP "
        RequestAppli = RequestAppli & "from V_INFRA_FRAMEWORK_V6 t1, v_infra_dev_gold_url t3 "
        RequestAppli = RequestAppli & "where(t3.MAINAPP = t1.APPLI) "
        RequestAppli = RequestAppli & "and t3.BRANCH = t1.BRANCH "
        RequestAppli = RequestAppli & "and t1.BRANCH = '" & Branch & "' "
        RequestAppli = RequestAppli & "and t1.ENVTYPE = '" & envtype & "' "
    End Function

    Function RequestAppliOSchemas(Branch As String, envtype As String) As String
        RequestAppliOSchemas = "select t.OSID, t.ouser, t.domain from V_INFRA_OSCHEMA t "
        RequestAppliOSchemas = RequestAppliOSchemas & "where t.BRANCH = '" & Branch & "' "
        RequestAppliOSchemas = RequestAppliOSchemas & "and t.ENV = '" & envtype & "' "
    End Function

    Function RequestEnv(Env As String) As String
        RequestEnv = "select * from V_INFRA_ENV t"
        RequestEnv = RequestEnv & "where t.P_BRANCH ='%" + Env + "%'"

    End Function

    'Function RequestCus(Cus As String) As String

    '    RequestCus = "select t.p_customer, t.BRANCHNAME, t1.appli, t.BRANCHTYPE,  t.p_label, t.DESCRIPTION, t1.client_version_value, t3.url, t1.SERVER_VERSION_VALUE, t2.ENVTYPE, t2.P_SERVER, t2.P_ORACLE, t2.P_JAVA "
    '    RequestCus = RequestCus & "from V_INFRA_BRANCH t, V_INFRA_FRAMEWORK_V6 t1, v_infra_dev_gold_url t3, v_infra_env t2 "
    '    RequestCus = RequestCus & "where t.BRANCHNAME = t1.BRANCH(+) "
    '    RequestCus = RequestCus & "and t3.BRANCH = t.BRANCHNAME "
    '    RequestCus = RequestCus & "and t.BRANCHNAME = t2.P_BRANCH "
    '    RequestCus = RequestCus & "and t1.ENVTYPE = t2.ENVTYPE "
    '    RequestCus = RequestCus & "and t3.MAINAPP = t1.APPLI "
    '    RequestCus = RequestCus & "and (upper(t.BRANCHNAME) like upper('%" + Cus + "%') "
    '    'RequestCus = RequestCus & "or upper(t.P_LABEL) like upper('%" + Cus + "%')"
    '    RequestCus = RequestCus & "or upper(t.P_CUSTOMER) like upper('%" + Cus + "%')) "
    '    RequestCus = RequestCus & "order by 2"

    'End Function
    Function FoundEnv(env As String, j As Integer) As Integer
        Dim i As Integer
        Dim Found As Boolean
        'j is the index de la branche

        Found = False
        i = 0
        j = 0
        While i < NbCusmax And Found = False
            'env
            If MyModule.Customers.Branch(j).Env(i).Envname = env Then
                Found = True
                j = i
            End If
            i = i + 1
        End While
        FoundEnv = i
    End Function


    Public Function researchCus() As Integer
        Dim oradb As String = "Data Source=RDTOOLS;User Id=read_only;Password=read_only;"
        Dim conn As New OracleConnection(oradb)
        Dim myCommand As New OracleCommand
        Dim dr As OracleDataReader

        Dim oradb2 As String = "Data Source=RDTOOLS;User Id=RFE_READ;Password=RFE_READ;"
        Dim conn2 As New OracleConnection(oradb2)

        Dim conn3 As New OracleConnection(oradb)
        Dim myCommand3 As New OracleCommand
        Dim dr3 As OracleDataReader

        'Dim Customer As Env
        Dim found As Boolean
        Dim i, j, z, nbBranch, nbenv, nbappli, nbschema, IndEnv As Integer
        Dim env, branchname, BranchType, Description, Application, label As String

        TBDesc.Text = ""
        TBBranchType.Text = ""

        TBFramework.Text = ""
        TBFSpring.Text = ""
        LLBURL.Text = ""
        LBURL.Text = ""
        TBEnvType.Text = ""
        TBServer.Text = ""
        TBOracle.Text = ""
        TBJava.Text = ""
        BranchType = ""
        Description = ""
        label = ""
        Application = ""
        IndEnv = 0
        env = ""
        branchname = ""

        ReDim MyModule.Customers.Branch(NbCusmax)
        For i = 0 To NbCusmax
            ReDim MyModule.Customers.Branch(i).Env(NbCusmax)
            For j = 0 To NbCusmax
                ReDim MyModule.Customers.Branch(i).Env(j).Appli(NbCusmax)
            Next
        Next


        'opening the connection
        conn.Open()
        Dim request As String = RequestBacklog(Replace(Trim(TBCus.Text), "'", "''"))
        myCommand = conn.CreateCommand()
        myCommand.CommandText = request
        dr = myCommand.ExecuteReader()
        nbBranch = 0
        nbenv = 0
        'remplissage du treeview
        researchCus = 0
        nbenv = 0
        nbBranch = 0
        While dr.Read()
            'Customer Name
            researchCus = 1
            If dr.GetValue(0) IsNot DBNull.Value Then
                MyModule.Customers.CustomerName = dr.GetValue(0)
                TBCus.Text = dr.GetValue(0)
            End If
            If dr.GetValue(1) IsNot DBNull.Value Then
                branchname = dr.GetValue(1)
            End If

            If dr.GetValue(3) IsNot DBNull.Value Then
                BranchType = dr.GetValue(3)
            End If
            If dr.GetValue(9) IsNot DBNull.Value Then
                Application = dr.GetValue(9)
            End If
            'label
            If dr.GetValue(4) IsNot DBNull.Value Then
                label = dr.GetValue(4)
            End If
            If dr.GetValue(5) IsNot DBNull.Value Then
                Description = dr.GetValue(5)
                If Description = "Weekly Patch HF510 Maintenance branch" Then
                    i = i
                End If
            Else
                Description = ""
            End If
            If dr.GetValue(2) IsNot DBNull.Value Then
                env = dr.GetValue(2)
            End If

            If InStr(UCase(MyModule.Customers.CustomerName), UCase(TBCus.Text)) Then
                TBCus.Text = MyModule.Customers.CustomerName
            End If
            'on parcourt le tableau des branches pour savoir si on l'a deja remplit ou non
            found = False
            i = 0
            j = 0
            While i < NbCusmax And found = False
                'branches
                If MyModule.Customers.Branch(i).Branchname = branchname Then
                    found = True
                    j = i
                End If
                i = i + 1
            End While
            If branchname = "REM02" Then
                i = i
            End If
            'il n'existe pas, on insert
            If Not found Then
                nbenv = 0
                '******* Branch *****
                MyModule.Customers.Branch(nbBranch).Branchname = branchname
                'on ajoute le type de branche
                MyModule.Customers.Branch(nbBranch).BranchType = BranchType
                'on ajoute la description
                MyModule.Customers.Branch(nbBranch).Description = Description
                'on ajoute le label
                MyModule.Customers.Branch(nbBranch).Label = label
                'on ajoute l'application
                MyModule.Customers.Branch(nbBranch).Application = Application

                '******* Env *****
                MyModule.Customers.Branch(nbBranch).Env(nbenv).Envname = env
                MyModule.Customers.Branch(nbBranch).Env(nbenv).EnvType = env
                If dr.GetValue(6) IsNot DBNull.Value Then
                    MyModule.Customers.Branch(nbBranch).Env(nbenv).server = dr.GetValue(6)
                End If
                If dr.GetValue(8) IsNot DBNull.Value Then
                    MyModule.Customers.Branch(nbBranch).Env(nbenv).java = dr.GetValue(8)
                End If
                If dr.GetValue(7) IsNot DBNull.Value Then
                    MyModule.Customers.Branch(nbBranch).Env(nbenv).Oracle = dr.GetValue(7)
                End If
                MyModule.Customers.NbBranch = nbBranch
                nbBranch = nbBranch + 1
                MyModule.Customers.Branch(nbBranch).NbEnv = nbenv
                nbenv = 1

            Else
                'il existe deja, on insert l'appli dans la structure existante

                '******* Env *****
                MyModule.Customers.Branch(j).Env(nbenv).Envname = env
                MyModule.Customers.Branch(j).Env(nbenv).EnvType = env
                If dr.GetValue(6) IsNot DBNull.Value Then
                    MyModule.Customers.Branch(j).Env(nbenv).server = dr.GetValue(6)
                End If
                If dr.GetValue(8) IsNot DBNull.Value Then
                    MyModule.Customers.Branch(j).Env(nbenv).java = dr.GetValue(8)
                End If
                If dr.GetValue(7) IsNot DBNull.Value Then
                    MyModule.Customers.Branch(j).Env(nbenv).Oracle = dr.GetValue(7)
                End If

                MyModule.Customers.Branch(j).NbEnv = nbenv
                nbenv = nbenv + 1

            End If
        End While

        conn.Close()
        If nbBranch = 0 Then GoTo Fin
        Me.Show()
        conn.Open()
        'Appli
        'On parcourt les branchs et on recherche les appli
        For i = 0 To MyModule.Customers.NbBranch
            For j = 0 To MyModule.Customers.Branch(i).NbEnv

                request = RequestAppli(MyModule.Customers.Branch(i).Branchname, MyModule.Customers.Branch(i).Env(j).Envname)
                myCommand = conn.CreateCommand()
                myCommand.CommandText = request
                dr = myCommand.ExecuteReader()

                nbappli = 0

                '"select t1.branch, t1.appli, t1.client_version_value, t3.url, t1.SERVER_VERSION_VALUE, t1.SERVER_VERSION_VALUE "
                While dr.Read()
                    If dr.GetValue(1) IsNot DBNull.Value Then
                        MyModule.Customers.Branch(i).Env(j).Appli(nbappli).Appliname = dr.GetValue(1)
                    End If
                    If dr.GetValue(2) IsNot DBNull.Value Then
                        MyModule.Customers.Branch(i).Env(j).Appli(nbappli).Framework = dr.GetValue(2)
                    End If
                    If dr.GetValue(3) IsNot DBNull.Value Then
                        MyModule.Customers.Branch(i).Env(j).Appli(nbappli).URL = dr.GetValue(3)
                    End If
                    If dr.GetValue(4) IsNot DBNull.Value Then
                        MyModule.Customers.Branch(i).Env(j).Appli(nbappli).Framework_Spring = dr.GetValue(4)
                    End If
                    If dr.GetValue(5) IsNot DBNull.Value Then
                        MyModule.Customers.Branch(i).Env(j).Appli(nbappli).BranchProduct = dr.GetValue(5)
                    End If
                    nbappli = nbappli + 1
                    MyModule.Customers.Branch(i).Env(j).NbAppli = nbappli
                End While

                'recherche des schémas Oracle liés à la branche sélectionnée
                conn3.Open()
                request = RequestAppliOSchemas(MyModule.Customers.Branch(i).Branchname, MyModule.Customers.Branch(i).Env(j).Envname)
                myCommand3 = conn3.CreateCommand()
                myCommand3.CommandText = request
                dr3 = myCommand3.ExecuteReader()
                nbschema = 0
                While dr3.Read()
                    If dr.GetValue(1) IsNot DBNull.Value Then
                        MyModule.Customers.Branch(i).Env(j).Appli(nbappli).Appliname = dr.GetValue(1)
                    End If
                    nbschema = nbschema + 1
                End While

            Next
        Next
        conn.Close()


        'recherche des RFE

        conn2.Open()
        request = RequestRFE(Replace(Trim(TBCus.Text), "'", "''"))
        myCommand = conn2.CreateCommand()
        myCommand.CommandText = request
        dr = myCommand.ExecuteReader()
        Dim nbrow2 As Integer = 0
        While dr.Read()
            nbrow2 = nbrow2 + 1

            CBRfe.Items.Add(dr.Item(1) + " - " + dr.Item(0))

        End While
        dr.Close()

        'recherche des Workstream
        Dim Sqldb As String = "Data Source=seyccrmsqlsip1;Integrated Security=SSPI;Initial Catalog=crm_MSCRM"
        Dim SqlConn As New SqlClient.SqlConnection(Sqldb)
        Dim SqlCmd As New SqlCommand
        Dim req As String
        Dim myReader As SqlDataReader

        req = RequestWS(Replace(Trim(TBCus.Text), "'", "''"))
        SqlConn.Open()
        SqlCmd = SqlConn.CreateCommand()

        SqlCmd.CommandText = req
        myReader = SqlCmd.ExecuteReader()

        While myReader.Read()

            CBWorkstream.Items.Add(myReader.Item(1) + " - " + myReader.Item(0))
        End While
        myReader.Close()


Fin:
        FBacklog.LB_NB.Text = ""
        If nbBranch = 0 Then

            FBacklog.TBCus.Text = Me.TBCus.Text
            FBacklog.LB_NB.Text = "No Branch"


            'FBacklog.Show()
            researchCus = FBacklog.researchBacklog()
            If researchCus <> 0 Then
                FBacklog.Show()
            End If
            'MsgBox("Not a card, Case or Customer please retry")
            Me.Close()
            'researchCus = 1
        End If
        'affichage treeview, on parcourt la structure
        i = 0
        TVCus.Nodes.Clear()
        While i < NbCusmax And MyModule.Customers.Branch(i).Branchname <> ""

            TVCus.Nodes.Add(MyModule.Customers.Branch(i).Branchname + " - " + MyModule.Customers.Branch(i).Application + " - " + MyModule.Customers.Branch(i).BranchType)

            j = 0
            While j < NbCusmax And MyModule.Customers.Branch(i).Env(j).Envname <> ""

                TVCus.Nodes(i).Nodes.Add(MyModule.Customers.Branch(i).Env(j).EnvType)
                z = 0
                While z < NbCusmax And MyModule.Customers.Branch(i).Env(j).Appli(z).Appliname <> ""
                    TVCus.Nodes(i).Nodes(j).Nodes.Add(MyModule.Customers.Branch(i).Env(j).Appli(z).Appliname)

                    z = z + 1
                End While

                j = j + 1
            End While
            i = i + 1
        End While

    End Function


    Function RequestRFE(ByVal Cus As String) As String


        RequestRFE = "select r.gapcode, lib_sta.tladesc "
        RequestRFE = RequestRFE + "from gap r, Client c, Projet p, TRA_LIB_ADM lib_sta, Adm_Statut statut "
        RequestRFE = RequestRFE + "where p.proclient = c.cliident "
        RequestRFE = RequestRFE + "and r.gapproj = p.proident "
        RequestRFE = RequestRFE + "and r.gapstatu = statut.staident "
        RequestRFE = RequestRFE + "and lib_sta.tlaident = statut.stalibe "
        RequestRFE = RequestRFE + "and lib_sta.langue = 'GB' "
        RequestRFE = RequestRFE + "and lower(c.clilibe) like '%" + LCase(Cus) + "%' "
        RequestRFE = RequestRFE + "order by 2 "

    End Function

    Function RequestWS(ByVal WS As String) As String


        RequestWS = "Select c.aldata_name, "
        RequestWS = RequestWS + "statecodename "
        RequestWS = RequestWS + "From Filteredaldata_workstream c "
        RequestWS = RequestWS + "Where lower(c.aldata_accountname) Like ('%" + LCase(WS) + "%') "

    End Function


    Private Sub TVCus_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TVCus.AfterSelect
        Dim level As Integer
        Dim Index, IndexP, indexPP As Integer

        level = TVCus.SelectedNode.Level
        Index = TVCus.SelectedNode.Index
        TBDesc.Text = ""
        TBDesc.Text = MyModule.Customers.Branch(Index).Description
        TBBranchType.Text = MyModule.Customers.Branch(Index).BranchType
        TBLabel.Text = ""
        TBFramework.Text = ""
        TBFSpring.Text = ""
        LLBURL.Text = ""
        LBURL.Text = ""
        'TBBranchName.Text = ""
        TBEnvType.Text = ""
        TBServer.Text = ""
        TBOracle.Text = ""
        TBJava.Text = ""
        TBProduct.Text = ""

        If level = 1 Then

            IndexP = TVCus.SelectedNode.Parent.Index
            TBDesc.Text = MyModule.Customers.Branch(IndexP).Description
            TBLabel.Text = MyModule.Customers.Branch(IndexP).Label
            TBBranchType.Text = MyModule.Customers.Branch(IndexP).BranchType

            'TBBranchName.Text = MyModule.Customers.Branch(IndexP).Env(Index).Envname
            'TBFramework.Text = MyModule.Customers.Branch(IndexP).Env(Index).Appli(nbappli).Framework
            'TBFSpring.Text = MyModule.Customers.Branch(IndexP).Env(Index).Appli(nbappli).Framework_Spring
            'TBURL.Text = MyModule.Customers.Branch(IndexP).Env(Index).Appli(nbappli).URL

            TBEnvType.Text = MyModule.Customers.Branch(IndexP).Env(Index).EnvType
            TBServer.Text = MyModule.Customers.Branch(IndexP).Env(Index).server
            TBOracle.Text = MyModule.Customers.Branch(IndexP).Env(Index).Oracle
            TBJava.Text = MyModule.Customers.Branch(IndexP).Env(Index).java
            'TBProduct.Text = MyModule.Customers.Branch(IndexP).Env(Index).BranchProduct

        End If
        If level = 2 Then
            IndexP = TVCus.SelectedNode.Parent.Index
            indexPP = TVCus.SelectedNode.Parent.Parent.Index
            TBDesc.Text = MyModule.Customers.Branch(indexPP).Description
            TBLabel.Text = MyModule.Customers.Branch(indexPP).Label
            TBBranchType.Text = MyModule.Customers.Branch(indexPP).BranchType

            'TBBranchName.Text = MyModule.Customers.Branch(IndexP).Env(Index).Envname
            TBEnvType.Text = MyModule.Customers.Branch(indexPP).Env(IndexP).EnvType
            TBServer.Text = MyModule.Customers.Branch(indexPP).Env(IndexP).server
            TBOracle.Text = MyModule.Customers.Branch(indexPP).Env(IndexP).Oracle
            TBJava.Text = MyModule.Customers.Branch(indexPP).Env(IndexP).java
            TBFramework.Text = MyModule.Customers.Branch(indexPP).Env(IndexP).Appli(Index).Framework
            TBFSpring.Text = MyModule.Customers.Branch(indexPP).Env(IndexP).Appli(Index).Framework_Spring
            LLBURL.Text = MyModule.Customers.Branch(indexPP).Env(IndexP).Appli(Index).URL
            LBURL.Text = "URL"
            TBProduct.Text = MyModule.Customers.Branch(indexPP).Env(IndexP).Appli(Index).BranchProduct
        End If
    End Sub

    Private Sub LLBURL_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LLBURL.LinkClicked
        System.Diagnostics.Process.Start(LLBURL.Text)

    End Sub

    Private Sub BBacklog_Click(sender As System.Object, e As System.EventArgs) Handles BBacklog.Click
        FBacklog.TBCus.Text = Me.TBCus.Text
        If FBacklog.researchBacklog() = 0 Then
            MsgBox("No backlog")
        Else
            FBacklog.Show()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim processlink As String
        'System.Diagnostics.Process.Start(LLBURL.Text)
        processlink = "https://eyc.sharepoint.com/sites/RS_SCM_RD/All_Documents/Forms/Processes.aspx#InplviewHash02f9a5a8-6796-4791-8aed-0a21fcbcf995=FilterField1%3DCategory-FilterValue1%3DProcedure-FilterField2%3DActivity-FilterValue2%3DMaintenance-FilterField3%3DKeywords-FilterValue3%3DProcess%2520PDF"
        System.Diagnostics.Process.Start(processlink)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'On lance Putty sur le server
        'ligne de commande putty.exe <nom serveur>
        'Ensuite on récupère la fenêtre pour l'afficher car sinon elle est minimisée
        'pour cela via les fonction dans user32.dll, on récupère la main sur la fenêtre et on la restore.
        Try
            'on lance putty sur le serveur
            Shell("C:\Program Files (x86)\putty\putty.exe " & TBServer.Text)

            'on recherche la fenêtre par son titre, pour cela il faut qu'on trouve le nom de la fenêtre :
            '<servername> & ".eyc.com - Putty"
            Dim WindowTitle As String
            WindowTitle = TBServer.Text & ".eyc.com - Putty"
            Dim windowhandle As IntPtr = FindWindow(Nothing, WindowTitle)
            'test si on a trouvé la fenêtre ou non
            'If windowhandle = Nothing Then
            '    MessageBox.Show("Could not find window", "Window Does Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'Else
            '    If IsWindowVisible(windowhandle) = True Then
            '        MessageBox.Show("The window is visible", "Window Visible", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Else
            '        MessageBox.Show("The window is not visible", "Window Not Yet Visible", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    End If
            'End If

            'on restore la fenêtre
            ShowWindow(windowhandle, 1)
        Catch ex As Exception
            MsgBox("Problem to launch putty : " & vbCrLf & ex.Message & vbCrLf & "Please verify the path of Putty.exe" & vbCrLf & " or copy to C:\Program Files (x86)\putty\putty.exe")
        End Try

        'Shell("%systemroot%\system32\mstsc.exe ""C:\Users\guerrier\AppData\Roaming\Microsoft\Workspaces\{4B548D83-D065-4190-8D74-31A7214932C9}\Resource\Putty (GOLD Development 2012 R2).rdp"
    End Sub

    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click


        Dim str() = CBRfe.Text.Split("-")

        TBRfe.Text = str(1)

        FSearch.MSTSearch.Text = Trim(TBRfe.Text)

        FSearch.Research(5)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str() = CBWorkstream.Text.Split("-")

        TBWs.Text = str(1)

        FSearch.MSTSearch.Text = Trim(TBWs.Text)

        FSearch.Research(6)
    End Sub
End Class