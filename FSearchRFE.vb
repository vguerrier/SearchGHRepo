Imports Oracle.DataAccess.Client
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports Oracle.DataAccess.Types
Imports MaterialSkin

Public Class FSearchRFE
    Private Sub FSearchRFE_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance



        'SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
        'SkinManager.ColorScheme = New ColorScheme(Primary.Yellow500, Primary.Yellow700, Primary.Yellow100, Accent.Yellow200, TextShade.WHITE)
        'SkinManager.ROBOTO_MEDIUM_10 = New Font("Microsoft Sans Serif", 8.25)
        'SkinManager.ROBOTO_MEDIUM_10 = New Font("Algerian", 8)
    End Sub

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
        RequestRFE = RequestRFE + "r.GAPDESC as                                                 desription "   '10
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
        RequestRFE = RequestRFE + "and u.AUSIDENT = r.gappjtmgr_ident "



    End Function

    Public Function researchRFE(RFE As String) As Integer
        Dim myCommand As OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim Oradb As String = "Provider=OraOLEDB.Oracle.1;Password=RFE_READ;Persist Security Info=True;User ID=RFE_READ;Data Source=RDTOOLS;"
        Dim conn As New OleDb.OleDbConnection(Oradb) 'OracleConnection(oradb)
        Dim nbRFE As Integer

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

            TBCustomer.Text = dr.GetValue(1)
            TBType.Text = dr.GetValue(2)
            TBDomain.Text = dr.GetValue(3)
            TBManager.Text = dr.GetValue(6)
            TBProduct.Text = dr.GetValue(5)
            RTBSol.Text = dr.GetValue(9)
            TBStatus.Text = dr.GetValue(4)
            TBTDD.Text = dr.GetValue(7)
            TBRDD.Text = dr.GetValue(8)
            RTBDesc.Text = dr.GetValue(10)
        End If
        conn.Close()
        conn.Dispose()

        If nbRFE <> 0 Then
            Me.Show()
        End If
        researchRFE = nbRFE
    End Function

End Class