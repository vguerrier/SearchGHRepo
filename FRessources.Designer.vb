<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRessources
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LbName = New System.Windows.Forms.Label()
        Me.TBName = New System.Windows.Forms.TextBox()
        Me.LCQLogin = New System.Windows.Forms.Label()
        Me.TBCQLogin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBCountry = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBCompany = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBManager = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBJob = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBRHEndDate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBRHStartDate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBTeamEndDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBTeamStartDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBAXName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBTeam = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBTeam2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBCity = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBGender = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TBLDAPName = New System.Windows.Forms.TextBox()
        Me.BBack = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Bnext = New MaterialSkin.Controls.MaterialFlatButton()
        Me.LBactual = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'LbName
        '
        Me.LbName.AutoSize = True
        Me.LbName.BackColor = System.Drawing.Color.White
        Me.LbName.ForeColor = System.Drawing.Color.Black
        Me.LbName.Location = New System.Drawing.Point(28, 110)
        Me.LbName.Name = "LbName"
        Me.LbName.Size = New System.Drawing.Size(153, 13)
        Me.LbName.TabIndex = 44
        Me.LbName.Text = "Name (First name + Last name)"
        '
        'TBName
        '
        Me.TBName.Location = New System.Drawing.Point(31, 127)
        Me.TBName.Name = "TBName"
        Me.TBName.Size = New System.Drawing.Size(179, 20)
        Me.TBName.TabIndex = 43
        '
        'LCQLogin
        '
        Me.LCQLogin.AutoSize = True
        Me.LCQLogin.BackColor = System.Drawing.Color.White
        Me.LCQLogin.ForeColor = System.Drawing.Color.Black
        Me.LCQLogin.Location = New System.Drawing.Point(445, 110)
        Me.LCQLogin.Name = "LCQLogin"
        Me.LCQLogin.Size = New System.Drawing.Size(51, 13)
        Me.LCQLogin.TabIndex = 46
        Me.LCQLogin.Text = "CQ Login"
        '
        'TBCQLogin
        '
        Me.TBCQLogin.BackColor = System.Drawing.SystemColors.Window
        Me.TBCQLogin.Location = New System.Drawing.Point(448, 127)
        Me.TBCQLogin.Name = "TBCQLogin"
        Me.TBCQLogin.ReadOnly = True
        Me.TBCQLogin.Size = New System.Drawing.Size(179, 20)
        Me.TBCQLogin.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(237, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Country"
        '
        'TBCountry
        '
        Me.TBCountry.BackColor = System.Drawing.SystemColors.Window
        Me.TBCountry.Location = New System.Drawing.Point(240, 127)
        Me.TBCountry.Name = "TBCountry"
        Me.TBCountry.ReadOnly = True
        Me.TBCountry.Size = New System.Drawing.Size(179, 20)
        Me.TBCountry.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(237, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Company"
        '
        'TBCompany
        '
        Me.TBCompany.BackColor = System.Drawing.SystemColors.Window
        Me.TBCompany.Location = New System.Drawing.Point(240, 358)
        Me.TBCompany.Name = "TBCompany"
        Me.TBCompany.ReadOnly = True
        Me.TBCompany.Size = New System.Drawing.Size(179, 20)
        Me.TBCompany.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(28, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Manager"
        '
        'TBManager
        '
        Me.TBManager.BackColor = System.Drawing.SystemColors.Window
        Me.TBManager.Location = New System.Drawing.Point(31, 173)
        Me.TBManager.Name = "TBManager"
        Me.TBManager.ReadOnly = True
        Me.TBManager.Size = New System.Drawing.Size(179, 20)
        Me.TBManager.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(445, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Job"
        '
        'TBJob
        '
        Me.TBJob.BackColor = System.Drawing.SystemColors.Window
        Me.TBJob.Location = New System.Drawing.Point(448, 173)
        Me.TBJob.Name = "TBJob"
        Me.TBJob.ReadOnly = True
        Me.TBJob.Size = New System.Drawing.Size(179, 20)
        Me.TBJob.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(445, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "RH End Date"
        '
        'TBRHEndDate
        '
        Me.TBRHEndDate.BackColor = System.Drawing.SystemColors.Window
        Me.TBRHEndDate.Location = New System.Drawing.Point(448, 265)
        Me.TBRHEndDate.Name = "TBRHEndDate"
        Me.TBRHEndDate.ReadOnly = True
        Me.TBRHEndDate.Size = New System.Drawing.Size(179, 20)
        Me.TBRHEndDate.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(237, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "RH Start Date"
        '
        'TBRHStartDate
        '
        Me.TBRHStartDate.BackColor = System.Drawing.SystemColors.Window
        Me.TBRHStartDate.Location = New System.Drawing.Point(240, 265)
        Me.TBRHStartDate.Name = "TBRHStartDate"
        Me.TBRHStartDate.ReadOnly = True
        Me.TBRHStartDate.Size = New System.Drawing.Size(179, 20)
        Me.TBRHStartDate.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(236, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Team End Date"
        '
        'TBTeamEndDate
        '
        Me.TBTeamEndDate.BackColor = System.Drawing.SystemColors.Window
        Me.TBTeamEndDate.Location = New System.Drawing.Point(239, 219)
        Me.TBTeamEndDate.Name = "TBTeamEndDate"
        Me.TBTeamEndDate.ReadOnly = True
        Me.TBTeamEndDate.Size = New System.Drawing.Size(179, 20)
        Me.TBTeamEndDate.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(28, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Team Start Date"
        '
        'TBTeamStartDate
        '
        Me.TBTeamStartDate.BackColor = System.Drawing.SystemColors.Window
        Me.TBTeamStartDate.Location = New System.Drawing.Point(31, 219)
        Me.TBTeamStartDate.Name = "TBTeamStartDate"
        Me.TBTeamStartDate.ReadOnly = True
        Me.TBTeamStartDate.Size = New System.Drawing.Size(179, 20)
        Me.TBTeamStartDate.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(28, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "AX Name"
        '
        'TBAXName
        '
        Me.TBAXName.BackColor = System.Drawing.SystemColors.Window
        Me.TBAXName.Location = New System.Drawing.Point(31, 265)
        Me.TBAXName.Name = "TBAXName"
        Me.TBAXName.ReadOnly = True
        Me.TBAXName.Size = New System.Drawing.Size(179, 20)
        Me.TBAXName.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(237, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Team"
        '
        'TBTeam
        '
        Me.TBTeam.BackColor = System.Drawing.SystemColors.Window
        Me.TBTeam.Location = New System.Drawing.Point(240, 173)
        Me.TBTeam.Name = "TBTeam"
        Me.TBTeam.ReadOnly = True
        Me.TBTeam.Size = New System.Drawing.Size(179, 20)
        Me.TBTeam.TabIndex = 55
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(445, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Email"
        '
        'TBEmail
        '
        Me.TBEmail.BackColor = System.Drawing.SystemColors.Window
        Me.TBEmail.Location = New System.Drawing.Point(448, 219)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.ReadOnly = True
        Me.TBEmail.Size = New System.Drawing.Size(179, 20)
        Me.TBEmail.TabIndex = 77
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(445, 294)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Team"
        '
        'TBTeam2
        '
        Me.TBTeam2.BackColor = System.Drawing.SystemColors.Window
        Me.TBTeam2.Location = New System.Drawing.Point(448, 311)
        Me.TBTeam2.Name = "TBTeam2"
        Me.TBTeam2.ReadOnly = True
        Me.TBTeam2.Size = New System.Drawing.Size(179, 20)
        Me.TBTeam2.TabIndex = 73
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(237, 294)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 13)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "City"
        '
        'TBCity
        '
        Me.TBCity.BackColor = System.Drawing.SystemColors.Window
        Me.TBCity.Location = New System.Drawing.Point(240, 311)
        Me.TBCity.Name = "TBCity"
        Me.TBCity.ReadOnly = True
        Me.TBCity.Size = New System.Drawing.Size(179, 20)
        Me.TBCity.TabIndex = 71
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(28, 341)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Gender"
        '
        'TBGender
        '
        Me.TBGender.BackColor = System.Drawing.SystemColors.Window
        Me.TBGender.Location = New System.Drawing.Point(31, 358)
        Me.TBGender.Name = "TBGender"
        Me.TBGender.ReadOnly = True
        Me.TBGender.Size = New System.Drawing.Size(179, 20)
        Me.TBGender.TabIndex = 69
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(28, 294)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "LDAP Name"
        '
        'TBLDAPName
        '
        Me.TBLDAPName.BackColor = System.Drawing.SystemColors.Window
        Me.TBLDAPName.Location = New System.Drawing.Point(31, 311)
        Me.TBLDAPName.Name = "TBLDAPName"
        Me.TBLDAPName.ReadOnly = True
        Me.TBLDAPName.Size = New System.Drawing.Size(179, 20)
        Me.TBLDAPName.TabIndex = 67
        '
        'BBack
        '
        Me.BBack.AutoSize = True
        Me.BBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BBack.BackColor = System.Drawing.SystemColors.Window
        Me.BBack.Depth = 0
        Me.BBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BBack.Icon = Global.WindowsApplication1.My.Resources.Resources.back
        Me.BBack.Image = Global.WindowsApplication1.My.Resources.Resources._next
        Me.BBack.Location = New System.Drawing.Point(531, 59)
        Me.BBack.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BBack.MouseState = MaterialSkin.MouseState.HOVER
        Me.BBack.Name = "BBack"
        Me.BBack.Primary = False
        Me.BBack.Size = New System.Drawing.Size(44, 36)
        Me.BBack.TabIndex = 152
        Me.ToolTip1.SetToolTip(Me.BBack, "previous information")
        Me.BBack.UseVisualStyleBackColor = False
        '
        'Bnext
        '
        Me.Bnext.AutoSize = True
        Me.Bnext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Bnext.BackColor = System.Drawing.SystemColors.Window
        Me.Bnext.Depth = 0
        Me.Bnext.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bnext.Icon = Global.WindowsApplication1.My.Resources.Resources._next
        Me.Bnext.Image = Global.WindowsApplication1.My.Resources.Resources._next
        Me.Bnext.Location = New System.Drawing.Point(583, 59)
        Me.Bnext.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Bnext.MouseState = MaterialSkin.MouseState.HOVER
        Me.Bnext.Name = "Bnext"
        Me.Bnext.Primary = False
        Me.Bnext.Size = New System.Drawing.Size(44, 36)
        Me.Bnext.TabIndex = 151
        Me.ToolTip1.SetToolTip(Me.Bnext, "next information")
        Me.Bnext.UseVisualStyleBackColor = False
        '
        'LBactual
        '
        Me.LBactual.AutoSize = True
        Me.LBactual.BackColor = System.Drawing.Color.White
        Me.LBactual.ForeColor = System.Drawing.Color.Black
        Me.LBactual.Location = New System.Drawing.Point(28, 71)
        Me.LBactual.Name = "LBactual"
        Me.LBactual.Size = New System.Drawing.Size(63, 13)
        Me.LBactual.TabIndex = 153
        Me.LBactual.Text = "Actual team"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Window
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.Mail_i
        Me.Button2.Location = New System.Drawing.Point(97, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 154
        Me.ToolTip1.SetToolTip(Me.Button2, "Mail")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FRessources
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 398)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LBactual)
        Me.Controls.Add(Me.BBack)
        Me.Controls.Add(Me.Bnext)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TBTeam2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TBCity)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TBGender)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TBLDAPName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBRHEndDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBRHStartDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBTeamEndDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBTeamStartDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBAXName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TBTeam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBJob)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBManager)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBCompany)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBCountry)
        Me.Controls.Add(Me.LCQLogin)
        Me.Controls.Add(Me.TBCQLogin)
        Me.Controls.Add(Me.LbName)
        Me.Controls.Add(Me.TBName)
        Me.Location = New System.Drawing.Point(21, 69)
        Me.Name = "FRessources"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ressource"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbName As Label
    Friend WithEvents TBName As TextBox
    Friend WithEvents LCQLogin As Label
    Friend WithEvents TBCQLogin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBCountry As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBCompany As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBManager As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBJob As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBRHEndDate As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBRHStartDate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBTeamEndDate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBTeamStartDate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBAXName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBTeam As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBTeam2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TBCity As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TBGender As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TBLDAPName As TextBox
    Friend WithEvents Bnext As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents BBack As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents LBactual As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
