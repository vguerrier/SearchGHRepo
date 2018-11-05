Imports Oracle.DataAccess.Client
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports Oracle.DataAccess.Types
Imports MaterialSkin

Public Class FSearchWorkstream
    Private Sub FSearchWorkstream_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function RequestWS(ByVal WS As String) As String


        RequestWS = "Select aldata_accountname, "                  '0
        RequestWS = RequestWS + "aldata_branch, "                       '1
        RequestWS = RequestWS + "aldata_categoryname, "                 '2
        RequestWS = RequestWS + "aldata_defaultassignedgroupname, "     '3
        RequestWS = RequestWS + "aldata_defaultproductname, "           '4
        RequestWS = RequestWS + "aldata_defaultteamname, "              '5
        RequestWS = RequestWS + "aldata_defaultversionname, "           '6
        RequestWS = RequestWS + "aldata_managedbyname, "                '7
        RequestWS = RequestWS + "aldata_name, "                         '8
        RequestWS = RequestWS + "createdbyname, "                       '9
        RequestWS = RequestWS + "createdon, "                           '10
        RequestWS = RequestWS + "eyc_typename, "                        '11
        RequestWS = RequestWS + "modifiedbyname,  "                     '12
        RequestWS = RequestWS + "modifiedon, "                          '13
        RequestWS = RequestWS + "owneridname, "                         '14
        RequestWS = RequestWS + "statecodename "                       '15
        RequestWS = RequestWS + "from Filteredaldata_workstream c "
        RequestWS = RequestWS + "Where c.aldata_name Like ('" + WS + "') "
        'RequestWS = RequestWS + "Where c.aldata_accountname Like ('" + CaseN + "') "

    End Function

    Function GetGcentInfoCQ(RFE As String) As String
        Dim CQbase As String

        CQbase = "cqcentral"

        GetGcentInfoCQ = "select   s.name, a.label, a.numerofiche from  "
        GetGcentInfoCQ = GetGcentInfoCQ & CQbase & ".anomalie a,"
        GetGcentInfoCQ = GetGcentInfoCQ & CQbase & ".statedef s,"
        GetGcentInfoCQ = GetGcentInfoCQ & CQbase & ".rfe r "
        GetGcentInfoCQ = GetGcentInfoCQ & " where a.State = s.ID "
        GetGcentInfoCQ = GetGcentInfoCQ & " And a.rfecode = r.dbid"
        GetGcentInfoCQ = GetGcentInfoCQ & " And r.code Like '%" + RFE + "%'"

    End Function

    Function Cardinfo(card As String, status As String, label As String) As String

        If status = "Corrigée" Then
            status = "C"
        ElseIf status = "Ouverte" Then
            status = "O"
        ElseIf status = "Assignée" Then
            status = "A"
        ElseIf status = "En_qualification" Then
            status = "EQ"
        ElseIf status = "A_installer" Then
            status = "AI"
        ElseIf status = "En_Integration" Then
            status = "EI"
        ElseIf status = "A_Qualifier" Then
            status = "AQ"
        ElseIf status = "En_Attente" Then
            status = "EA"
        ElseIf status = "Being_Delivered" Then
            status = "BD"
        ElseIf status = "Analyse_Estimation_Impact" Then
            status = "AEI"
        ElseIf status = "Rejetée" Then
            status = "R"
        ElseIf status = "Codée" Then
            status = "CO"
        ElseIf status = "Attente_approbation" Then
            status = "AA"
        ElseIf status = "Refusée" Then
            status = "Ref"
        ElseIf status = "Fermée" Then
            status = "F"
        End If

        Cardinfo = card + "  " + status + "  " + label


    End Function

    Public Function researchWS(WS As String) As Integer
        'Dim dr As OleDb.OleDbDataReader
        Dim Sqldb As String = "Data Source=seyccrmsqlsip1;Integrated Security=SSPI;Initial Catalog=crm_MSCRM"
        Dim SqlConn As New SqlClient.SqlConnection(Sqldb)
        Dim SqlCmd As New SqlCommand
        Dim req As String
        Dim myReader As SqlDataReader

        Dim nbRFE As Integer
        Dim Oradb2 As String = "Provider=OraOLEDB.Oracle.1;Password=READCQUEST;Persist Security Info=True;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1;"
        Dim SqlConn2 As New OleDb.OleDbConnection(Oradb2) 'OracleConnection(oradb2)
        Dim SqlCmd2 As OleDb.OleDbCommand
        Dim myReader2 As OleDb.OleDbDataReader
        Dim nbrow2 As Integer
        Dim status, label As String
        'ex : Gold Specific 
        nbRFE = 0

        'opening the connection
        SqlConn.Open()
        SqlCmd = SqlConn.CreateCommand()
        req = RequestWS(WS)

        SqlCmd.CommandText = req
        myReader = SqlCmd.ExecuteReader()

        'conn.Open()
        'Dim request As String = RequestWS(WS)
        'myCommand = New OleDb.OleDbCommand(request, conn)
        'dr = myCommand.ExecuteReader()

        researchWS = 0

        If myReader.Read() Then
            nbRFE = nbRFE + 1
            TBWorkstream.Text = WS

            'TBTitle.Text = dr.GetValue(0)

            If myReader.GetValue(0) IsNot DBNull.Value Then
                TBCustomer.Text = myReader.GetValue(0)
            End If
            If myReader.GetValue(11) IsNot DBNull.Value Then
                TBType.Text = myReader.GetValue(11)
            End If
            If myReader.GetValue(3) IsNot DBNull.Value Then
                TBAGroup.Text = myReader.GetValue(3)
            End If
            If myReader.GetValue(10) IsNot DBNull.Value Then
                TBCD.Text = myReader.GetValue(10)
            End If
            If myReader.GetValue(4) IsNot DBNull.Value Then
                TBProduct.Text = myReader.GetValue(4)
            End If
            If myReader.GetValue(9) IsNot DBNull.Value Then
                TBCreated.Text = myReader.GetValue(9)
            End If
            If myReader.GetValue(7) IsNot DBNull.Value Then
                TBManaged.Text = myReader.GetValue(7)
            End If
            If myReader.GetValue(13) IsNot DBNull.Value Then
                TBMD.Text = myReader.GetValue(13)
            End If
            If myReader.GetValue(12) IsNot DBNull.Value Then
                TBModified.Text = myReader.GetValue(12)
            End If
            If myReader.GetValue(14) IsNot DBNull.Value Then
                TBOwner.Text = myReader.GetValue(14)
            End If
            If myReader.GetValue(6) IsNot DBNull.Value Then
                TBProductVersion.Text = myReader.GetValue(6)
            End If
            If myReader.GetValue(15) IsNot DBNull.Value Then
                TBState.Text = myReader.GetValue(15)
            End If
        End If
        SqlConn.Close()
        SqlConn.Dispose()



        'recherche des fiches liées au RFE
        req = GetGcentInfoCQ(WS)
        'opening the connection
        SqlConn2.Open()
        SqlCmd2 = New OleDb.OleDbCommand(req, SqlConn2)
        SqlCmd2.CommandText = req
        myReader2 = SqlCmd2.ExecuteReader()

        nbrow2 = 0
        While myReader2.Read()
            nbrow2 = nbrow2 + 1
            status = myReader2.Item(0)
            If myReader2.Item(1) IsNot DBNull.Value Then
                label = myReader2.Item(1)
            Else
                label = ""
            End If

            Cardinfo(myReader2.Item(2), status, label)
            CBGcent.Items.Add(Cardinfo(myReader2.Item(2), status, label))
            CBGcent.Text = Cardinfo(myReader2.Item(2), status, label)

            If nbrow2 > 1 Then
                CBGcent.ForeColor = Color.Red
            Else
                CBGcent.ForeColor = Color.Black
            End If
        End While

        'If nbRFE <> 0 Then
        'Me.Show()
        'End If
        researchWS = nbRFE
    End Function


    Private Sub BSearch_Click_1(sender As Object, e As EventArgs) Handles BSearch.Click
        FSearch.MSTSearch.Text = Mid(CBGcent.Text, 1, 13)

        FSearch.Research(0)
    End Sub
    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click

    End Sub
End Class