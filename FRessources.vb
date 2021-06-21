Imports System.Data
Imports Oracle.ManagedDataAccess.Client ' ODP.NET Oracle managed provider
Imports Oracle.ManagedDataAccess.Types
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.IO
Imports System.DirectoryServices
Imports MaterialSkin



Public Class FRessources

    Private Structure ressource
        Public Country As String
        Public Last_name As String
        Public First_name As String
        Public Company As String
        Public Manager As String
        Public Job As String
        Public Team As String
        Public TeamStartDate As String
        Public TeamEndDate As String
        Public AXname As String
        Public RHStartDate As String
        Public RHEndDate As String
        Public LDAPName As String
        Public City As String
        Public Team2 As String
        Public Gender As String
        Public ClearQuestLogin As String
        Public Email As String
        Public Symphony As Boolean

    End Structure

    Private Structure Type_AD_Extraction
        Public User_Name As String
        Public User_Login As String
        Public User_Department As String
        Public User_Company As String
        Public User_Mail As String
        Public User_TelephoneNumber As String
    End Structure

    Dim Tressource() As ressource
    Dim nbrow, currow As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
        'SkinManager.ROBOTO_MEDIUM_10 = New Font("Microsoft Sans Serif", 8.25)
        'SkinManager.ROBOTO_MEDIUM_10 = New Font("Algerian", 8)

    End Sub

    Function RequestRessourceCount(name As String) As String

        RequestRessourceCount = "Select count(*) From V_GLOBAL_RDRESOURCES t "
        RequestRessourceCount = RequestRessourceCount & "Where lower(t.LASTNAME) = lower('" + Trim(name) + "') "
        RequestRessourceCount = RequestRessourceCount & "Or lower(t.FIRSTNAME) = lower('" + Trim(name) + "') "
        RequestRessourceCount = RequestRessourceCount & "Or lower(t.AX_NAME) = lower('" + Trim(name) + "') "
        RequestRessourceCount = RequestRessourceCount & "Or lower(t.LDAP_NAME) = lower('" + Trim(name) + "') "
        RequestRessourceCount = RequestRessourceCount & "Or lower(t.CLEARQUESTLOGIN) = lower('" + Trim(name) + "') "

    End Function

    Function RequestRessource(name As String) As String

        RequestRessource = "Select * From V_GLOBAL_RDRESOURCES t "
        RequestRessource = RequestRessource & "Where lower(t.LASTNAME) = lower('" + Trim(name) + "') "
        RequestRessource = RequestRessource & "Or lower(t.FIRSTNAME) = lower('" + Trim(name) + "') "
        RequestRessource = RequestRessource & "Or lower(t.AX_NAME) = lower('" + Trim(name) + "') "
        RequestRessource = RequestRessource & "Or lower(t.LDAP_NAME) = lower('" + Trim(name) + "') "
        RequestRessource = RequestRessource & "Or lower(t.CLEARQUESTLOGIN) = lower('" + Trim(name) + "') "
        RequestRessource = RequestRessource & " order by  t.LASTNAME, t.TEAM_END desc, t.TEAM_START desc "

    End Function

    Function RequestRessourceCountCQ(name As String) As String

        RequestRessourceCountCQ = "Select count(*) From cqcentral.users u "
        RequestRessourceCountCQ = RequestRessourceCountCQ & "Where lower(u.login_name) = lower('" + Trim(name) + "') "
        RequestRessourceCountCQ = RequestRessourceCountCQ & "Or lower(u.fullname) = lower('" + Trim(name) + "') "




    End Function

    Function RequestRessourceCQ(name As String) As String

        RequestRessourceCQ = "Select u.is_active, u.login_name, u.fullname, u.email From cqcentral.users u "
        RequestRessourceCQ = RequestRessourceCQ & "Where lower(u.login_name) = lower('" + Trim(name) + "') "
        RequestRessourceCQ = RequestRessourceCQ & "Or lower(u.fullname) = lower('" + Trim(name) + "') "

    End Function

    Public Function Test() As Integer
        Dim dr As OracleDataReader
        'Dim oradb As String = "Data Source=RDTOOLS;User Id=READ_ONLY;Password=READ_ONLY;"
        'Dim oradb As String = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 10.132.16.133)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = RDTOOLS)));User ID=READ_ONLY;Password=READ_ONLY"
        Dim oradb As String = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 10.132.16.133)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = RDTOOLS)));User ID=RFE_READ;Password=RFE_READ"
        Dim myCommand As OracleCommand
        Dim conn As New OracleConnection(oradb)
        Dim request As String


        'Dim Tressource() As ressource

        'opening the connection count
        conn.Open()

        request = "Select t.p_customer from V_INFRA_BRANCH t "
        'request = RequestRessourceCount(Replace("angot", "'", "''"))
        myCommand = conn.CreateCommand()
        myCommand.CommandText = request
        dr = myCommand.ExecuteReader()
        Return 0

    End Function

    Public Function researchRes(name As String) As Integer

        Dim dr As OracleDataReader
        'Dim oradb As String = "Data Source=RDTOOLS;User Id=READ_ONLY;Password=READ_ONLY;"
        Dim oradb As String = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 10.132.16.133)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = RDTOOLS)));User ID=READ_ONLY;Password=READ_ONLY"
        Dim myCommand As OracleCommand
        Dim conn As New OracleConnection(oradb)
        Dim request As String


        Bnext.Visible = False
        BBack.Visible = False
        'Dim Tressource() As ressource

        'opening the connection count
        nbrow = 0
        conn.Open()

        request = RequestRessourceCount(Replace(name, "'", "''"))
        myCommand = conn.CreateCommand()
        myCommand.CommandText = request
        dr = myCommand.ExecuteReader()
        'remplissage du treeview
        researchRes = 0
        dr.Read()
        nbrow = dr.GetValue(0)
        conn.Close()

        ReDim Tressource(nbrow)



        'opening the connection
        conn.Open()

        request = RequestRessource(Replace(name, "'", "''"))
        myCommand = conn.CreateCommand()
        myCommand.CommandText = request
        dr = myCommand.ExecuteReader()
        'remplissage du treeview
        researchRes = 0

        If nbrow > 1 Then
            Bnext.Visible = True

        End If

        If nbrow = 0 Then
            researchRes = 0
            Me.Close()
            Exit Function
        Else researchRes = nbrow
        End If

        Dim nb = 0
        While dr.Read()
            Tressource(nb).Symphony = False
            If dr.GetValue(3) IsNot DBNull.Value Then
                Tressource(nb).Country = dr.GetValue(3)
            End If
            If dr.GetValue(0) IsNot DBNull.Value Then
                Tressource(nb).Last_name = dr.GetValue(0)
            End If
            If dr.GetValue(1) IsNot DBNull.Value Then
                Tressource(nb).First_name = dr.GetValue(1)
            End If
            If dr.GetValue(2) IsNot DBNull.Value Then
                Tressource(nb).Company = dr.GetValue(2)
            End If
            If dr.GetValue(5) IsNot DBNull.Value Then
                Tressource(nb).Manager = dr.GetValue(5)
            End If
            If dr.GetValue(6) IsNot DBNull.Value Then
                Tressource(nb).Job = dr.GetValue(6)
            End If
            If dr.GetValue(13) IsNot DBNull.Value Then
                Tressource(nb).Team = dr.GetValue(13)
            End If
            If dr.GetValue(11) IsNot DBNull.Value Then
                Tressource(nb).TeamStartDate = dr.GetValue(11)
            End If
            If dr.GetValue(12) IsNot DBNull.Value Then
                Tressource(nb).TeamEndDate = dr.GetValue(12)
            Else
                Tressource(nb).Symphony = True
            End If
            If dr.GetValue(16) IsNot DBNull.Value Then
                Tressource(nb).AXname = dr.GetValue(16)
            End If
            If dr.GetValue(8) IsNot DBNull.Value Then
                Tressource(nb).RHStartDate = dr.GetValue(8)
            End If
            If dr.GetValue(9) IsNot DBNull.Value Then
                Tressource(nb).RHEndDate = dr.GetValue(9)
            End If
            If dr.GetValue(17) IsNot DBNull.Value Then
                Tressource(nb).LDAPName = dr.GetValue(17)
            End If
            If dr.GetValue(4) IsNot DBNull.Value Then
                Tressource(nb).City = dr.GetValue(4)
            End If
            If dr.GetValue(23) IsNot DBNull.Value Then
                Tressource(nb).Team2 = dr.GetValue(23)
            End If
            If dr.GetValue(14) IsNot DBNull.Value Then
                Tressource(nb).Gender = dr.GetValue(14)
            End If
            If dr.GetValue(15) IsNot DBNull.Value Then
                Tressource(nb).ClearQuestLogin = dr.GetValue(15)
            End If
            If dr.GetValue(19) IsNot DBNull.Value Then
                Tressource(nb).Email = dr.GetValue(19)
            End If
            nb = nb + 1

        End While
        currow = 0
        If nbrow > 0 Then

            If Tressource(0).Symphony = True Then
                LBactual.ForeColor = Color.Red
                LBactual.Text = "Actual Position"
            Else
                LBactual.ForeColor = Color.Black
                LBactual.Text = "Old Position"
            End If
            'Country            1
            TBCountry.Text = Tressource(0).Country
            'MyModule.Customers.CustomerName = dr.GetValue(1)
            'Last_name          2
            TBName.Text = Tressource(0).First_name + " " + Tressource(0).Last_name

            'TBName.Text = dr.GetValue(2)
            'First_name         3
            'TBName.Text = Tressource(0)
            'Company           4
            TBCompany.Text = Tressource(0).Company
            'Manager            5
            TBManager.Text = Tressource(0).Manager
            'Job                6
            TBJob.Text = Tressource(0).Job
            'Team               7
            TBTeam.Text = Tressource(0).Team
            'Team Start date    14
            TBTeamStartDate.Text = Tressource(0).TeamStartDate
            'Team End Date      13
            TBTeamEndDate.Text = Tressource(0).TeamEndDate
            'AX name            17
            TBAXName.Text = Tressource(0).AXname
            'RH Start Date      18
            TBRHStartDate.Text = Tressource(0).RHStartDate
            'RH Start End       19
            TBRHEndDate.Text = Tressource(0).RHEndDate
            'LDAP Name          20
            TBLDAPName.Text = Tressource(0).LDAPName
            'City               22
            TBCity.Text = Tressource(0).City
            'team               24
            TBTeam2.Text = Tressource(0).Team2
            'Gender             25
            TBGender.Text = Tressource(0).Gender
            'ClearQuest Login   26
            TBCQLogin.Text = Tressource(0).ClearQuestLogin
            'Email              30
            TBEmail.Text = Tressource(0).Email
        End If
        If nbrow <> 0 Then
            'ns = GetObject("LDAP:")
        End If
    End Function

    Public Function researchResCQ(name As String) As Integer

        Dim dr As OracleDataReader
        'Dim oradb As String = "Data Source=RDTOOLS;User Id=READ_ONLY;Password=READ_ONLY;"
        Dim oradb As String = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 10.132.16.30)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = CQSCM1)));User ID=READCQUEST;Password=READCQUEST"
        Dim myCommand As OracleCommand
        Dim conn As New OracleConnection(oradb)
        Dim request As String


        Bnext.Visible = False
        BBack.Visible = False
        'Dim Tressource() As ressource

        'opening the connection count
        nbrow = 0
        conn.Open()

        request = RequestRessourceCountCQ(Replace(name, "'", "''"))
        myCommand = conn.CreateCommand()
        myCommand.CommandText = request
        dr = myCommand.ExecuteReader()
        'remplissage du treeview
        researchResCQ = 0
        dr.Read()
        nbrow = dr.GetValue(0)
        conn.Close()

        ReDim Tressource(nbrow)



        'opening the connection
        conn.Open()

        request = RequestRessourceCQ(Replace(name, "'", "''"))
        myCommand = conn.CreateCommand()
        myCommand.CommandText = request
        dr = myCommand.ExecuteReader()
        'remplissage du treeview
        researchResCQ = 0

        If nbrow > 1 Then
            Bnext.Visible = True

        End If

        If nbrow = 0 Then
            researchResCQ = 0
            Me.Close()
            Exit Function
        Else researchResCQ = nbrow
        End If

        Dim nb = 0
        While dr.Read()
            TBName.Text = dr.GetValue(2)
            TBCQLogin.Text = dr.GetValue(1)
            TBEmail.Text = dr.GetValue(3)

            If dr.GetValue(0) = 1 Then
                LBactual.ForeColor = Color.Red
                LBactual.Text = "CQ Search : Active"
            Else
                LBactual.ForeColor = Color.Black
                LBactual.Text = "CQ Search : Inactive"
            End If
            nb = nb + 1

        End While

    End Function


    Sub Extract_AD_UserName_And_UserLogin()
        'metthode d'extraction des info LDAP, active directory. info non pertinente
        'non utilisé


        Dim accountcontrol
        Const ADS_SCOPE_SUBTREE = 2
        ' Dim objRootDSE


        ' Création du fichier Excel

        Dim objExcel = CreateObject("Excel.Application")
        Dim fsoObject = CreateObject("Scripting.FileSystemObject")

        objExcel.Visible = True
        objExcel.Workbooks.Add()

        objExcel.Cells(1, 1).Value = "Liste des Comptes " & " le " & FormatDateTime(Now, vbLongDate)
        objExcel.Cells(1, 1).Font.Bold = True
        objExcel.Cells(1, 1).Font.Size = 10
        objExcel.Cells(1, 1).Font.ColorIndex = 3


        ' Ajout des titres de colonnes

        objExcel.Cells(2, 2).Value = "Last name"
        objExcel.Cells(2, 2).Font.ColorIndex = 5
        objExcel.Cells(2, 3).Value = "First name"
        objExcel.Cells(2, 3).Font.ColorIndex = 5
        objExcel.Cells(2, 4).Value = "samAccountName"
        objExcel.Cells(2, 4).Font.ColorIndex = 5
        objExcel.Cells(2, 5).Value = "Department"
        objExcel.Cells(2, 5).Font.ColorIndex = 5
        objExcel.Cells(2, 6).Value = "Phone number"
        objExcel.Cells(2, 6).Font.ColorIndex = 5
        objExcel.Cells(2, 7).Value = "Mail"
        objExcel.Cells(2, 7).Font.ColorIndex = 5
        objExcel.Cells(2, 8).Value = "userPrincipalName"
        objExcel.Cells(2, 8).Font.ColorIndex = 5
        objExcel.Cells(2, 9).Value = "distinguishedName"
        objExcel.Cells(2, 9).Font.ColorIndex = 5
        objExcel.Cells(2, 10).Value = "homeDirectory"
        objExcel.Cells(2, 10).Font.ColorIndex = 5
        objExcel.Cells(2, 11).Value = "homeDrive"
        objExcel.Cells(2, 11).Font.ColorIndex = 5
        objExcel.Cells(2, 12).Value = "canonicalName"
        objExcel.Cells(2, 12).Font.ColorIndex = 5
        objExcel.Cells(2, 13).Value = "scriptPath"
        objExcel.Cells(2, 13).Font.ColorIndex = 5
        objExcel.Cells(2, 14).Value = "userAccountControl"
        objExcel.Cells(2, 14).Font.ColorIndex = 5


        ' Connexion Active directory et selection des données

        Dim objRootDSE, strDNSDomain, objCommand, objConnection
        Dim strBase ', strFilter, strAttributes, strQuery ' objRecordSet

        ' Determine DNS domain name.
        objRootDSE = GetObject("LDAP://RootDSE")
        strDNSDomain = objRootDSE.Get("defaultNamingContext")

        ' Use ADO to search Active Directory.
        objCommand = CreateObject("ADODB.Command")
        objConnection = CreateObject("ADODB.Connection")
        objConnection.Provider = "ADsDSOObject"
        objConnection.Open("Active Directory Provider")
        objCommand.ActiveConnection = objConnection
        strBase = "<LDAP://" & strDNSDomain & ">"

        objCommand.Properties("Page Size") = 100
        objCommand.Properties("Searchscope") = ADS_SCOPE_SUBTREE
        objCommand.CommandText =
"SELECT givenName, SN, samAccountName, department, telephoneNumber, mail, userPrincipalName, distinguishedName, homeDirectory, homeDrive, canonicalName, scriptPath, userAccountControl" _
& " FROM " & "'LDAP://" & strDNSDomain & "' WHERE " _
           & "objectCategory='person' AND objectClass='user' ORDER BY samAccountName"

        Dim objRecordSet = objCommand.Execute

        objRecordSet.MoveFirst()
        Dim x = 3

        ' Export des données vers Excel

        Do Until objRecordSet.EOF
            objExcel.Cells(x, 2).Value =
                objRecordSet.Fields("SN").Value
            objExcel.Cells(x, 3).Value =
                objRecordSet.Fields("givenName").Value
            objExcel.Cells(x, 4).Value =
                objRecordSet.Fields("samAccountName").Value
            objExcel.Cells(x, 5).Value =
                objRecordSet.Fields("department").Value
            objExcel.Cells(x, 6).Value =
                objRecordSet.Fields("telephoneNumber").Value
            objExcel.Cells(x, 7).Value =
                objRecordSet.Fields("mail").Value
            objExcel.Cells(x, 8).Value =
                objRecordSet.Fields("userPrincipalName").Value
            objExcel.Cells(x, 9).Value =
                objRecordSet.Fields("distinguishedName").Value
            objExcel.Cells(x, 10).Value =
                objRecordSet.Fields("homeDirectory").Value
            objExcel.Cells(x, 11).Value =
                objRecordSet.Fields("homeDrive").Value
            objExcel.Cells(x, 12).Value =
                objRecordSet.Fields("canonicalName").Value
            objExcel.Cells(x, 13).Value =
                objRecordSet.Fields("scriptPath").Value


            ' Check du User Account Control pour déterminer si les comptes sont Enabled
            ' ou Disabled

            accountcontrol = objRecordSet.Fields("userAccountControl").Value

            If accountcontrol And 2 Then
                objExcel.Cells(x, 14).Value = "Disabled"
            Else : objExcel.Cells(x, 14).Value = "enabled"
            End If

            x = x + 1
            objRecordSet.MoveNext()
        Loop


        ' Autofit des cellules Excel

        objExcel.Columns("B:N").Select()
        objExcel.Selection.Columns.AutoFit()
        objExcel.Range("A1").Select()

        ' Clean up.
        objConnection.Close()
        objRootDSE = Nothing
        objCommand = Nothing
        objConnection = Nothing
        objRecordSet = Nothing


        ' Fin de Script

    End Sub

    Private Sub BBack_Click(sender As Object, e As EventArgs) Handles BBack.Click
        currow = currow - 1
        If currow = 0 Then
            BBack.Visible = False
        End If
        Bnext.Visible = True
        If Tressource(currow).Symphony = True Then
            LBactual.ForeColor = Color.Red
            LBactual.Text = "Actual Position"
        Else
            LBactual.ForeColor = Color.Black
            LBactual.Text = "Old Position"
        End If

        'Country            1
        TBCountry.Text = Tressource(currow).Country
            'MyModule.Customers.CustomerName = dr.GetValue(1)
            'Last_name          2
            TBName.Text = Tressource(currow).First_name + " " + Tressource(currow).Last_name

            'TBName.Text = dr.GetValue(2)
            'First_name         3
            'TBName.Text = Tressource(Currow)
            'Company           4
            TBCompany.Text = Tressource(currow).Company
            'Manager            5
            TBManager.Text = Tressource(currow).Manager
            'Job                6
            TBJob.Text = Tressource(currow).Job
            'Team               7
            TBTeam.Text = Tressource(currow).Team
            'Team Start date    14
            TBTeamStartDate.Text = Tressource(currow).TeamStartDate
            'Team End Date      13
            TBTeamEndDate.Text = Tressource(currow).TeamEndDate
            'AX name            17
            TBAXName.Text = Tressource(currow).AXname
            'RH Start Date      18
            TBRHStartDate.Text = Tressource(currow).RHStartDate
            'RH Start End       19
            TBRHEndDate.Text = Tressource(currow).RHEndDate
            'LDAP Name          20
            TBLDAPName.Text = Tressource(currow).LDAPName
            'City               22
            TBCity.Text = Tressource(currow).City
            'team               24
            TBTeam2.Text = Tressource(currow).Team2
            'Gender             25
            TBGender.Text = Tressource(currow).Gender
            'ClearQuest Login   26
            TBCQLogin.Text = Tressource(currow).ClearQuestLogin
            'Email              30
            TBEmail.Text = Tressource(currow).Email

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TBEmail.Text <> "" Then
            'Mail(TBCase.Text, TBGcent.Text, TBCustomer.Text, TBTitle.Text)
            'eMail.To = toEmail;
            System.Diagnostics.Process.Start("mailto:" + TBEmail.Text + "?") 'subject=" + "[" & TBCustomer.Text & "] " & TBCase.Text & " " & TBGcent.Text)
        Else
            MessageBox.Show("Warning", "Email is empty", MessageBoxButtons.OKCancel)
        End If
    End Sub

    Private Sub Bnext_Click(sender As Object, e As EventArgs) Handles Bnext.Click
        currow = currow + 1
        If nbrow - 1 >= currow Then
            If nbrow - 1 = currow Then
                Bnext.Visible = False
            End If
            BBack.Visible = True
            If Tressource(currow).Symphony = True Then
                LBactual.ForeColor = Color.Red
                LBactual.Text = "Actual Position"
            Else
                LBactual.ForeColor = Color.Black
                LBactual.Text = "Old Position"
            End If

            'Country            1
            TBCountry.Text = Tressource(currow).Country
            'MyModule.Customers.CustomerName = dr.GetValue(1)
            'Last_name          2
            TBName.Text = Tressource(currow).First_name + " " + Tressource(currow).Last_name

            'TBName.Text = dr.GetValue(2)
            'First_name         3
            'TBName.Text = Tressource(Currow)
            'Company           4
            TBCompany.Text = Tressource(currow).Company
            'Manager            5
            TBManager.Text = Tressource(currow).Manager
            'Job                6
            TBJob.Text = Tressource(currow).Job
            'Team               7
            TBTeam.Text = Tressource(currow).Team
            'Team Start date    14
            TBTeamStartDate.Text = Tressource(currow).TeamStartDate
            'Team End Date      13
            TBTeamEndDate.Text = Tressource(currow).TeamEndDate
            'AX name            17
            TBAXName.Text = Tressource(currow).AXname
            'RH Start Date      18
            TBRHStartDate.Text = Tressource(currow).RHStartDate
            'RH Start End       19
            TBRHEndDate.Text = Tressource(currow).RHEndDate
            'LDAP Name          20
            TBLDAPName.Text = Tressource(currow).LDAPName
            'City               22
            TBCity.Text = Tressource(currow).City
            'team               24
            TBTeam2.Text = Tressource(currow).Team2
            'Gender             25
            TBGender.Text = Tressource(currow).Gender
            'ClearQuest Login   26
            TBCQLogin.Text = Tressource(currow).ClearQuestLogin
            'Email              30
            TBEmail.Text = Tressource(currow).Email
        End If

    End Sub
End Class