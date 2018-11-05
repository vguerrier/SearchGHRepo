Imports Oracle.DataAccess.Client
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports Oracle.DataAccess.Types
Imports MaterialSkin

Public Class FSearchRFE
    'Private Sub FSearchRFE_Load(sender As Object, e As EventArgs) Handles Me.Load

    '    Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance



    '    'SkinManager.AddFormToManage(Me)
    '    SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
    '    'SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    '    SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
    '    'SkinManager.ColorScheme = New ColorScheme(Primary.Yellow500, Primary.Yellow700, Primary.Yellow100, Accent.Yellow200, TextShade.WHITE)
    '    'SkinManager.ROBOTO_MEDIUM_10 = New Font("Microsoft Sans Serif", 8.25)
    '    'SkinManager.ROBOTO_MEDIUM_10 = New Font("Algerian", 8)
    'End Sub

    Function RequestRFE(ByVal CaseN As String) As String


        RequestRFE = "select r.gaptitr as                                                             Title, "  '0
        RequestRFE = RequestRFE + "c.clilibe as                                                       Client, " '1
        RequestRFE = RequestRFE + "decode(s.solorig, 1, 'STD', decode(s.solorig, 2, 'SPE', 'OTH')) as Type, "   '2
        RequestRFE = RequestRFE + "d.adonum || '-' || lib_dom.tladesc as                              Domain, " '3
        RequestRFE = RequestRFE + "lib_sta.tladesc as                                                 Status, " '4
        RequestRFE = RequestRFE + "lib_app.tladesc as                                                Product, " '5
        RequestRFE = RequestRFE + "u.ausdesc                                                          PM, "     '6
        RequestRFE = RequestRFE + "to_char(r.gapdplg, 'DD-MM-RR') as                   initial_delivery_date, " '7
        RequestRFE = RequestRFE + "to_char(r.gapdrlg, 'DD-MM-RR') as                    real_delivery_Date, "   '8
        RequestRFE = RequestRFE + "r.GAPCOMPC as                                            Macro_estimate, "   '9
        RequestRFE = RequestRFE + "r.GAPDESC as                                                 desription, "   '10
        RequestRFE = RequestRFE + "r.gapcrmstream as                                              Workstream, " '11
        RequestRFE = RequestRFE + "r.gapknwtsf as                                               transfert   "   '12
        RequestRFE = RequestRFE + "from gap r, "
        RequestRFE = RequestRFE + "Client c, "
        RequestRFE = RequestRFE + "Projet p, "
        RequestRFE = RequestRFE + "solution s, "
        RequestRFE = RequestRFE + "Adm_Statut statut, "
        RequestRFE = RequestRFE + "Adm_Application a, "
        RequestRFE = RequestRFE + "TRA_LIB_ADM lib_dom, "
        RequestRFE = RequestRFE + "TRA_LIB_ADM lib_sta, "
        RequestRFE = RequestRFE + "TRA_LIB_ADM lib_app, "
        RequestRFE = RequestRFE + "Adm_Domaine d, "
        RequestRFE = RequestRFE + "v_adm_users u "
        RequestRFE = RequestRFE + "where upper(r.gapcode) = upper('" + CaseN + "') "
        RequestRFE = RequestRFE + "and p.proclient = c.cliident "
        RequestRFE = RequestRFE + "and r.gapproj = p.proident "
        RequestRFE = RequestRFE + "and r.gapappli = a.aapident "
        RequestRFE = RequestRFE + "and r.gapstatu = statut.staident "
        RequestRFE = RequestRFE + "and r.gapident = s.solgap "
        RequestRFE = RequestRFE + "and (s.solactu = 1 or s.solactu is null) "
        RequestRFE = RequestRFE + "and r.gapdoma = d.adoident "
        RequestRFE = RequestRFE + "and lib_dom.tlaident = d.adolibe "
        RequestRFE = RequestRFE + "and lib_dom.langue = 'GB' "
        RequestRFE = RequestRFE + "and lib_sta.tlaident = statut.stalibe "
        RequestRFE = RequestRFE + "and lib_sta.langue = 'GB' "
        RequestRFE = RequestRFE + "and lib_app.tlaident = a.aaplibe "
        RequestRFE = RequestRFE + "and lib_app.langue = 'GB' "
        RequestRFE = RequestRFE + "and u.AUSIDENT(+) = r.gappjtmgr_ident "



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

    Public Function researchRFE(RFE As String) As Integer
        Dim myCommand As OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim Oradb As String = "Provider=OraOLEDB.Oracle.1;Password=RFE_READ;Persist Security Info=True;User ID=RFE_READ;Data Source=RDTOOLS;"
        Dim conn As New OleDb.OleDbConnection(Oradb) 'OracleConnection(oradb)
        Dim nbRFE As Integer
        Dim Oradb2 As String = "Provider=OraOLEDB.Oracle.1;Password=READCQUEST;Persist Security Info=True;User ID=READCQUEST;Data Source=CQSCM1_SEYCSMC1;"
        Dim SqlConn2 As New OleDb.OleDbConnection(Oradb2) 'OracleConnection(oradb2)
        Dim SqlCmd2 As OleDb.OleDbCommand
        Dim myReader2 As OleDb.OleDbDataReader
        Dim nbrow2 As Integer
        Dim status, label As String
        'ex : RN37022 
        nbRFE = 0

        'opening the connection
        conn.Open()
        Dim request As String = RequestRFE(RFE)
        myCommand = New OleDb.OleDbCommand(request, conn)
        dr = myCommand.ExecuteReader()

        researchRFE = 0

        If dr.Read() Then
            nbRFE = nbRFE + 1
            TBCRFE.Text = RFE
            TBTitle.Text = dr.GetValue(0)

            If dr.GetValue(1) IsNot DBNull.Value Then
                TBCustomer.Text = dr.GetValue(1)
            End If
            If dr.GetValue(2) IsNot DBNull.Value Then
                TBType.Text = dr.GetValue(2)
            End If
            If dr.GetValue(3) IsNot DBNull.Value Then
                TBDomain.Text = dr.GetValue(3)
            End If
            If dr.GetValue(6) IsNot DBNull.Value Then
                TBManager.Text = dr.GetValue(6)
            End If
            If dr.GetValue(5) IsNot DBNull.Value Then
                TBProduct.Text = dr.GetValue(5)
            End If
            If dr.GetValue(9) IsNot DBNull.Value Then
                RTBSol.Text = dr.GetValue(9)
            End If
            If dr.GetValue(4) IsNot DBNull.Value Then
                TBStatus.Text = dr.GetValue(4)
            End If
            If dr.GetValue(7) IsNot DBNull.Value Then
                TBTDD.Text = dr.GetValue(7)
            End If
            If dr.GetValue(8) IsNot DBNull.Value Then
                TBRDD.Text = dr.GetValue(8)
            End If
            If dr.GetValue(10) IsNot DBNull.Value Then
                RTBDesc.Text = dr.GetValue(10)
            End If
            If dr.GetValue(11) IsNot DBNull.Value Then
                TBWorstream.Text = dr.GetValue(11)
            End If
            If dr.GetValue(12) IsNot DBNull.Value Then
                TBTrans.Text = dr.GetValue(12)
            End If
        End If
        conn.Close()
        conn.Dispose()



        'recherche des fiches liées au RFE
        Dim req As String = GetGcentInfoCQ(RFE)
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

        If nbRFE <> 0 Then
            'Me.Show()
        End If
        researchRFE = nbRFE
    End Function


    Private Sub BSearch_Click_1(sender As Object, e As EventArgs) Handles BSearch.Click
        FSearch.MSTSearch.Text = Mid(CBGcent.Text, 1, 13)

        FSearch.Research(0)
    End Sub
End Class