<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FSearchGcent
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSearchGcent))
        Me.CBRetrofit = New System.Windows.Forms.CheckBox()
        Me.TBRetCard = New System.Windows.Forms.TextBox()
        Me.LbRetCard = New System.Windows.Forms.Label()
        Me.TBRDate = New System.Windows.Forms.TextBox()
        Me.LbRD = New System.Windows.Forms.Label()
        Me.TBIDD = New System.Windows.Forms.TextBox()
        Me.LbIDD = New System.Windows.Forms.Label()
        Me.TBSev = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LVHistory = New System.Windows.Forms.ListView()
        Me.CHTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHUser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHAction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHNState = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CGOState = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TBGcent = New System.Windows.Forms.TextBox()
        Me.LbGcent2 = New System.Windows.Forms.Label()
        Me.TBCustomer = New System.Windows.Forms.TextBox()
        Me.LbCustomer = New System.Windows.Forms.Label()
        Me.TBAssigned = New System.Windows.Forms.TextBox()
        Me.LbAssigned = New System.Windows.Forms.Label()
        Me.TBSubProduct = New System.Windows.Forms.TextBox()
        Me.LbSubProduct = New System.Windows.Forms.Label()
        Me.TBProduct = New System.Windows.Forms.TextBox()
        Me.LbProduct = New System.Windows.Forms.Label()
        Me.TBDomain = New System.Windows.Forms.TextBox()
        Me.LbDomain = New System.Windows.Forms.Label()
        Me.TBLabel = New System.Windows.Forms.TextBox()
        Me.LbLabel = New System.Windows.Forms.Label()
        Me.TBCase = New System.Windows.Forms.TextBox()
        Me.LBCase = New System.Windows.Forms.Label()
        Me.LbState = New System.Windows.Forms.Label()
        Me.TBState = New System.Windows.Forms.TextBox()
        Me.LbTitle = New System.Windows.Forms.Label()
        Me.TBTitle = New System.Windows.Forms.TextBox()
        Me.TBRFE = New System.Windows.Forms.TextBox()
        Me.LbRFE = New System.Windows.Forms.Label()
        Me.TBECD = New System.Windows.Forms.TextBox()
        Me.LbECD = New System.Windows.Forms.Label()
        Me.TBstom = New System.Windows.Forms.TextBox()
        Me.LBstom = New System.Windows.Forms.Label()
        Me.RTBLog = New System.Windows.Forms.RichTextBox()
        Me.RTBDesc = New System.Windows.Forms.RichTextBox()
        Me.LBDesc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RTBDOTI = New System.Windows.Forms.RichTextBox()
        Me.LBDOTI = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RTBDOTM = New System.Windows.Forms.RichTextBox()
        Me.RTBms = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBCP = New System.Windows.Forms.TextBox()
        Me.LbCP = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LVad = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TBUrgence = New System.Windows.Forms.TextBox()
        Me.LbUrg = New System.Windows.Forms.Label()
        Me.CBGcent = New System.Windows.Forms.ComboBox()
        Me.LbGcret = New System.Windows.Forms.Label()
        Me.TBGcent2 = New System.Windows.Forms.TextBox()
        Me.TBGcentRet = New System.Windows.Forms.TextBox()
        Me.LLBlinkCQ = New System.Windows.Forms.LinkLabel()
        Me.LbLink = New System.Windows.Forms.Label()
        Me.TBPatch = New System.Windows.Forms.TextBox()
        Me.LbPatch = New System.Windows.Forms.Label()
        Me.TBDeliveryPatch = New System.Windows.Forms.TextBox()
        Me.LBdelDate = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BRessource = New System.Windows.Forms.Button()
        Me.Bsearch = New System.Windows.Forms.Button()
        Me.Bsearch2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CBRetrofit
        '
        Me.CBRetrofit.AutoSize = True
        Me.CBRetrofit.BackColor = System.Drawing.Color.White
        Me.CBRetrofit.Enabled = False
        Me.CBRetrofit.Location = New System.Drawing.Point(331, 257)
        Me.CBRetrofit.Name = "CBRetrofit"
        Me.CBRetrofit.Size = New System.Drawing.Size(60, 17)
        Me.CBRetrofit.TabIndex = 105
        Me.CBRetrofit.Text = "Retrofit"
        Me.CBRetrofit.UseVisualStyleBackColor = False
        '
        'TBRetCard
        '
        Me.TBRetCard.BackColor = System.Drawing.Color.White
        Me.TBRetCard.Location = New System.Drawing.Point(311, 234)
        Me.TBRetCard.Name = "TBRetCard"
        Me.TBRetCard.ReadOnly = True
        Me.TBRetCard.Size = New System.Drawing.Size(120, 20)
        Me.TBRetCard.TabIndex = 104
        '
        'LbRetCard
        '
        Me.LbRetCard.AutoSize = True
        Me.LbRetCard.BackColor = System.Drawing.Color.White
        Me.LbRetCard.Location = New System.Drawing.Point(311, 218)
        Me.LbRetCard.Name = "LbRetCard"
        Me.LbRetCard.Size = New System.Drawing.Size(86, 13)
        Me.LbRetCard.TabIndex = 103
        Me.LbRetCard.Text = "Cards Retrofitted"
        '
        'TBRDate
        '
        Me.TBRDate.BackColor = System.Drawing.Color.White
        Me.TBRDate.Location = New System.Drawing.Point(459, 234)
        Me.TBRDate.Name = "TBRDate"
        Me.TBRDate.ReadOnly = True
        Me.TBRDate.Size = New System.Drawing.Size(140, 20)
        Me.TBRDate.TabIndex = 102
        '
        'LbRD
        '
        Me.LbRD.AutoSize = True
        Me.LbRD.BackColor = System.Drawing.Color.White
        Me.LbRD.Location = New System.Drawing.Point(459, 218)
        Me.LbRD.Name = "LbRD"
        Me.LbRD.Size = New System.Drawing.Size(72, 13)
        Me.LbRD.TabIndex = 101
        Me.LbRD.Text = "Revised Date"
        '
        'TBIDD
        '
        Me.TBIDD.BackColor = System.Drawing.Color.White
        Me.TBIDD.Location = New System.Drawing.Point(459, 196)
        Me.TBIDD.Name = "TBIDD"
        Me.TBIDD.ReadOnly = True
        Me.TBIDD.Size = New System.Drawing.Size(140, 20)
        Me.TBIDD.TabIndex = 100
        '
        'LbIDD
        '
        Me.LbIDD.AutoSize = True
        Me.LbIDD.BackColor = System.Drawing.Color.White
        Me.LbIDD.Location = New System.Drawing.Point(459, 180)
        Me.LbIDD.Name = "LbIDD"
        Me.LbIDD.Size = New System.Drawing.Size(110, 13)
        Me.LbIDD.TabIndex = 99
        Me.LbIDD.Text = "Initial Date of Delivery"
        '
        'TBSev
        '
        Me.TBSev.BackColor = System.Drawing.Color.White
        Me.TBSev.Location = New System.Drawing.Point(167, 158)
        Me.TBSev.Name = "TBSev"
        Me.TBSev.ReadOnly = True
        Me.TBSev.Size = New System.Drawing.Size(140, 20)
        Me.TBSev.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(167, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Severity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "History"
        '
        'LVHistory
        '
        Me.LVHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHTime, Me.CHUser, Me.CHAction, Me.CHNState, Me.CGOState})
        Me.LVHistory.GridLines = True
        Me.LVHistory.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.LVHistory.Location = New System.Drawing.Point(23, 274)
        Me.LVHistory.Name = "LVHistory"
        Me.LVHistory.Size = New System.Drawing.Size(485, 226)
        Me.LVHistory.TabIndex = 95
        Me.LVHistory.UseCompatibleStateImageBehavior = False
        Me.LVHistory.View = System.Windows.Forms.View.Details
        '
        'CHTime
        '
        Me.CHTime.Text = "Time"
        Me.CHTime.Width = 79
        '
        'CHUser
        '
        Me.CHUser.Text = "User"
        Me.CHUser.Width = 88
        '
        'CHAction
        '
        Me.CHAction.Text = "Action"
        Me.CHAction.Width = 98
        '
        'CHNState
        '
        Me.CHNState.DisplayIndex = 4
        Me.CHNState.Text = "New State"
        Me.CHNState.Width = 98
        '
        'CGOState
        '
        Me.CGOState.DisplayIndex = 3
        Me.CGOState.Text = "Old State"
        Me.CGOState.Width = 99
        '
        'TBGcent
        '
        Me.TBGcent.BackColor = System.Drawing.Color.White
        Me.TBGcent.Location = New System.Drawing.Point(24, 81)
        Me.TBGcent.Name = "TBGcent"
        Me.TBGcent.ReadOnly = True
        Me.TBGcent.Size = New System.Drawing.Size(151, 20)
        Me.TBGcent.TabIndex = 93
        '
        'LbGcent2
        '
        Me.LbGcent2.AutoSize = True
        Me.LbGcent2.BackColor = System.Drawing.Color.White
        Me.LbGcent2.Location = New System.Drawing.Point(21, 65)
        Me.LbGcent2.Name = "LbGcent2"
        Me.LbGcent2.Size = New System.Drawing.Size(37, 13)
        Me.LbGcent2.TabIndex = 92
        Me.LbGcent2.Text = "CARD"
        '
        'TBCustomer
        '
        Me.TBCustomer.BackColor = System.Drawing.Color.White
        Me.TBCustomer.Location = New System.Drawing.Point(459, 158)
        Me.TBCustomer.Name = "TBCustomer"
        Me.TBCustomer.ReadOnly = True
        Me.TBCustomer.Size = New System.Drawing.Size(140, 20)
        Me.TBCustomer.TabIndex = 90
        '
        'LbCustomer
        '
        Me.LbCustomer.AutoSize = True
        Me.LbCustomer.BackColor = System.Drawing.Color.White
        Me.LbCustomer.Location = New System.Drawing.Point(459, 142)
        Me.LbCustomer.Name = "LbCustomer"
        Me.LbCustomer.Size = New System.Drawing.Size(51, 13)
        Me.LbCustomer.TabIndex = 89
        Me.LbCustomer.Text = "Customer"
        '
        'TBAssigned
        '
        Me.TBAssigned.BackColor = System.Drawing.Color.White
        Me.TBAssigned.Location = New System.Drawing.Point(311, 158)
        Me.TBAssigned.Name = "TBAssigned"
        Me.TBAssigned.ReadOnly = True
        Me.TBAssigned.Size = New System.Drawing.Size(120, 20)
        Me.TBAssigned.TabIndex = 88
        '
        'LbAssigned
        '
        Me.LbAssigned.AutoSize = True
        Me.LbAssigned.BackColor = System.Drawing.Color.White
        Me.LbAssigned.Location = New System.Drawing.Point(311, 142)
        Me.LbAssigned.Name = "LbAssigned"
        Me.LbAssigned.Size = New System.Drawing.Size(50, 13)
        Me.LbAssigned.TabIndex = 87
        Me.LbAssigned.Text = "Assigned"
        '
        'TBSubProduct
        '
        Me.TBSubProduct.BackColor = System.Drawing.Color.White
        Me.TBSubProduct.Location = New System.Drawing.Point(167, 234)
        Me.TBSubProduct.Name = "TBSubProduct"
        Me.TBSubProduct.ReadOnly = True
        Me.TBSubProduct.Size = New System.Drawing.Size(140, 20)
        Me.TBSubProduct.TabIndex = 86
        '
        'LbSubProduct
        '
        Me.LbSubProduct.AutoSize = True
        Me.LbSubProduct.BackColor = System.Drawing.Color.White
        Me.LbSubProduct.Location = New System.Drawing.Point(167, 218)
        Me.LbSubProduct.Name = "LbSubProduct"
        Me.LbSubProduct.Size = New System.Drawing.Size(66, 13)
        Me.LbSubProduct.TabIndex = 85
        Me.LbSubProduct.Text = "Sub-Product"
        '
        'TBProduct
        '
        Me.TBProduct.BackColor = System.Drawing.Color.White
        Me.TBProduct.Location = New System.Drawing.Point(167, 196)
        Me.TBProduct.Name = "TBProduct"
        Me.TBProduct.ReadOnly = True
        Me.TBProduct.Size = New System.Drawing.Size(140, 20)
        Me.TBProduct.TabIndex = 84
        '
        'LbProduct
        '
        Me.LbProduct.AutoSize = True
        Me.LbProduct.BackColor = System.Drawing.Color.White
        Me.LbProduct.Location = New System.Drawing.Point(167, 180)
        Me.LbProduct.Name = "LbProduct"
        Me.LbProduct.Size = New System.Drawing.Size(44, 13)
        Me.LbProduct.TabIndex = 83
        Me.LbProduct.Text = "Product"
        '
        'TBDomain
        '
        Me.TBDomain.BackColor = System.Drawing.Color.White
        Me.TBDomain.Location = New System.Drawing.Point(23, 234)
        Me.TBDomain.Name = "TBDomain"
        Me.TBDomain.ReadOnly = True
        Me.TBDomain.Size = New System.Drawing.Size(140, 20)
        Me.TBDomain.TabIndex = 82
        '
        'LbDomain
        '
        Me.LbDomain.AutoSize = True
        Me.LbDomain.BackColor = System.Drawing.Color.White
        Me.LbDomain.Location = New System.Drawing.Point(20, 218)
        Me.LbDomain.Name = "LbDomain"
        Me.LbDomain.Size = New System.Drawing.Size(43, 13)
        Me.LbDomain.TabIndex = 81
        Me.LbDomain.Text = "Domain"
        '
        'TBLabel
        '
        Me.TBLabel.BackColor = System.Drawing.Color.White
        Me.TBLabel.Location = New System.Drawing.Point(23, 196)
        Me.TBLabel.Name = "TBLabel"
        Me.TBLabel.ReadOnly = True
        Me.TBLabel.Size = New System.Drawing.Size(120, 20)
        Me.TBLabel.TabIndex = 80
        '
        'LbLabel
        '
        Me.LbLabel.AutoSize = True
        Me.LbLabel.BackColor = System.Drawing.Color.White
        Me.LbLabel.Location = New System.Drawing.Point(20, 180)
        Me.LbLabel.Name = "LbLabel"
        Me.LbLabel.Size = New System.Drawing.Size(33, 13)
        Me.LbLabel.TabIndex = 79
        Me.LbLabel.Text = "Label"
        '
        'TBCase
        '
        Me.TBCase.BackColor = System.Drawing.Color.White
        Me.TBCase.Location = New System.Drawing.Point(181, 81)
        Me.TBCase.Name = "TBCase"
        Me.TBCase.ReadOnly = True
        Me.TBCase.Size = New System.Drawing.Size(151, 20)
        Me.TBCase.TabIndex = 78
        '
        'LBCase
        '
        Me.LBCase.AutoSize = True
        Me.LBCase.BackColor = System.Drawing.Color.White
        Me.LBCase.Location = New System.Drawing.Point(178, 65)
        Me.LBCase.Name = "LBCase"
        Me.LBCase.Size = New System.Drawing.Size(35, 13)
        Me.LBCase.TabIndex = 77
        Me.LBCase.Text = "CASE"
        '
        'LbState
        '
        Me.LbState.AutoSize = True
        Me.LbState.BackColor = System.Drawing.Color.White
        Me.LbState.Location = New System.Drawing.Point(19, 142)
        Me.LbState.Name = "LbState"
        Me.LbState.Size = New System.Drawing.Size(37, 13)
        Me.LbState.TabIndex = 76
        Me.LbState.Text = "Status"
        '
        'TBState
        '
        Me.TBState.BackColor = System.Drawing.Color.White
        Me.TBState.Location = New System.Drawing.Point(23, 158)
        Me.TBState.Name = "TBState"
        Me.TBState.ReadOnly = True
        Me.TBState.Size = New System.Drawing.Size(140, 20)
        Me.TBState.TabIndex = 75
        '
        'LbTitle
        '
        Me.LbTitle.AutoSize = True
        Me.LbTitle.BackColor = System.Drawing.Color.White
        Me.LbTitle.Location = New System.Drawing.Point(19, 104)
        Me.LbTitle.Name = "LbTitle"
        Me.LbTitle.Size = New System.Drawing.Size(27, 13)
        Me.LbTitle.TabIndex = 74
        Me.LbTitle.Text = "Title"
        '
        'TBTitle
        '
        Me.TBTitle.BackColor = System.Drawing.Color.White
        Me.TBTitle.Location = New System.Drawing.Point(22, 121)
        Me.TBTitle.Name = "TBTitle"
        Me.TBTitle.ReadOnly = True
        Me.TBTitle.Size = New System.Drawing.Size(904, 20)
        Me.TBTitle.TabIndex = 73
        '
        'TBRFE
        '
        Me.TBRFE.BackColor = System.Drawing.Color.White
        Me.TBRFE.Location = New System.Drawing.Point(311, 196)
        Me.TBRFE.Name = "TBRFE"
        Me.TBRFE.ReadOnly = True
        Me.TBRFE.Size = New System.Drawing.Size(140, 20)
        Me.TBRFE.TabIndex = 107
        '
        'LbRFE
        '
        Me.LbRFE.AutoSize = True
        Me.LbRFE.BackColor = System.Drawing.Color.White
        Me.LbRFE.Location = New System.Drawing.Point(311, 180)
        Me.LbRFE.Name = "LbRFE"
        Me.LbRFE.Size = New System.Drawing.Size(56, 13)
        Me.LbRFE.TabIndex = 106
        Me.LbRFE.Text = "RFE Code"
        '
        'TBECD
        '
        Me.TBECD.BackColor = System.Drawing.Color.White
        Me.TBECD.Location = New System.Drawing.Point(603, 196)
        Me.TBECD.Name = "TBECD"
        Me.TBECD.ReadOnly = True
        Me.TBECD.Size = New System.Drawing.Size(140, 20)
        Me.TBECD.TabIndex = 113
        '
        'LbECD
        '
        Me.LbECD.AutoSize = True
        Me.LbECD.BackColor = System.Drawing.Color.White
        Me.LbECD.Location = New System.Drawing.Point(603, 180)
        Me.LbECD.Name = "LbECD"
        Me.LbECD.Size = New System.Drawing.Size(130, 13)
        Me.LbECD.TabIndex = 112
        Me.LbECD.Text = "Estimated Correction Date"
        '
        'TBstom
        '
        Me.TBstom.BackColor = System.Drawing.Color.White
        Me.TBstom.Location = New System.Drawing.Point(603, 158)
        Me.TBstom.Name = "TBstom"
        Me.TBstom.ReadOnly = True
        Me.TBstom.Size = New System.Drawing.Size(140, 20)
        Me.TBstom.TabIndex = 109
        '
        'LBstom
        '
        Me.LBstom.AutoSize = True
        Me.LBstom.BackColor = System.Drawing.Color.White
        Me.LBstom.Location = New System.Drawing.Point(603, 142)
        Me.LBstom.Name = "LBstom"
        Me.LBstom.Size = New System.Drawing.Size(86, 13)
        Me.LBstom.TabIndex = 108
        Me.LBstom.Text = "Source to modify"
        '
        'RTBLog
        '
        Me.RTBLog.BackColor = System.Drawing.Color.White
        Me.RTBLog.Location = New System.Drawing.Point(515, 274)
        Me.RTBLog.Name = "RTBLog"
        Me.RTBLog.ReadOnly = True
        Me.RTBLog.Size = New System.Drawing.Size(411, 110)
        Me.RTBLog.TabIndex = 114
        Me.RTBLog.Text = ""
        '
        'RTBDesc
        '
        Me.RTBDesc.BackColor = System.Drawing.Color.White
        Me.RTBDesc.Location = New System.Drawing.Point(23, 594)
        Me.RTBDesc.Name = "RTBDesc"
        Me.RTBDesc.ReadOnly = True
        Me.RTBDesc.Size = New System.Drawing.Size(450, 264)
        Me.RTBDesc.TabIndex = 115
        Me.RTBDesc.Text = ""
        '
        'LBDesc
        '
        Me.LBDesc.AutoSize = True
        Me.LBDesc.BackColor = System.Drawing.Color.White
        Me.LBDesc.Location = New System.Drawing.Point(20, 578)
        Me.LBDesc.Name = "LBDesc"
        Me.LBDesc.Size = New System.Drawing.Size(60, 13)
        Me.LBDesc.TabIndex = 116
        Me.LBDesc.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(511, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Log History"
        '
        'RTBDOTI
        '
        Me.RTBDOTI.BackColor = System.Drawing.Color.White
        Me.RTBDOTI.Location = New System.Drawing.Point(24, 518)
        Me.RTBDOTI.Name = "RTBDOTI"
        Me.RTBDOTI.ReadOnly = True
        Me.RTBDOTI.Size = New System.Drawing.Size(902, 20)
        Me.RTBDOTI.TabIndex = 118
        Me.RTBDOTI.Text = ""
        '
        'LBDOTI
        '
        Me.LBDOTI.AutoSize = True
        Me.LBDOTI.BackColor = System.Drawing.Color.White
        Me.LBDOTI.Location = New System.Drawing.Point(21, 502)
        Me.LBDOTI.Name = "LBDOTI"
        Me.LBDOTI.Size = New System.Drawing.Size(117, 13)
        Me.LBDOTI.TabIndex = 119
        Me.LBDOTI.Text = "Description of the issue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 540)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 13)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Description of the modifications"
        '
        'RTBDOTM
        '
        Me.RTBDOTM.BackColor = System.Drawing.Color.White
        Me.RTBDOTM.Location = New System.Drawing.Point(22, 556)
        Me.RTBDOTM.Name = "RTBDOTM"
        Me.RTBDOTM.ReadOnly = True
        Me.RTBDOTM.Size = New System.Drawing.Size(904, 20)
        Me.RTBDOTM.TabIndex = 120
        Me.RTBDOTM.Text = ""
        '
        'RTBms
        '
        Me.RTBms.BackColor = System.Drawing.Color.White
        Me.RTBms.Location = New System.Drawing.Point(476, 594)
        Me.RTBms.Name = "RTBms"
        Me.RTBms.ReadOnly = True
        Me.RTBms.Size = New System.Drawing.Size(450, 264)
        Me.RTBms.TabIndex = 122
        Me.RTBms.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(512, 578)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Modified Sources"
        '
        'TBCP
        '
        Me.TBCP.BackColor = System.Drawing.Color.White
        Me.TBCP.Location = New System.Drawing.Point(603, 234)
        Me.TBCP.Name = "TBCP"
        Me.TBCP.ReadOnly = True
        Me.TBCP.Size = New System.Drawing.Size(140, 20)
        Me.TBCP.TabIndex = 125
        '
        'LbCP
        '
        Me.LbCP.AutoSize = True
        Me.LbCP.BackColor = System.Drawing.Color.White
        Me.LbCP.Location = New System.Drawing.Point(603, 218)
        Me.LbCP.Name = "LbCP"
        Me.LbCP.Size = New System.Drawing.Size(85, 13)
        Me.LbCP.TabIndex = 124
        Me.LbCP.Text = "Project Manager"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(515, 389)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Attached Documents"
        '
        'LVad
        '
        Me.LVad.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.LVad.GridLines = True
        Me.LVad.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.LVad.Location = New System.Drawing.Point(514, 405)
        Me.LVad.Name = "LVad"
        Me.LVad.Size = New System.Drawing.Size(411, 110)
        Me.LVad.TabIndex = 131
        Me.LVad.UseCompatibleStateImageBehavior = False
        Me.LVad.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Document"
        Me.ColumnHeader1.Width = 406
        '
        'TBUrgence
        '
        Me.TBUrgence.BackColor = System.Drawing.Color.White
        Me.TBUrgence.Location = New System.Drawing.Point(747, 158)
        Me.TBUrgence.Name = "TBUrgence"
        Me.TBUrgence.ReadOnly = True
        Me.TBUrgence.Size = New System.Drawing.Size(178, 20)
        Me.TBUrgence.TabIndex = 133
        '
        'LbUrg
        '
        Me.LbUrg.AutoSize = True
        Me.LbUrg.BackColor = System.Drawing.Color.White
        Me.LbUrg.Location = New System.Drawing.Point(750, 142)
        Me.LbUrg.Name = "LbUrg"
        Me.LbUrg.Size = New System.Drawing.Size(48, 13)
        Me.LbUrg.TabIndex = 132
        Me.LbUrg.Text = "Urgence"
        '
        'CBGcent
        '
        Me.CBGcent.BackColor = System.Drawing.Color.White
        Me.CBGcent.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBGcent.FormattingEnabled = True
        Me.CBGcent.Location = New System.Drawing.Point(483, 83)
        Me.CBGcent.Name = "CBGcent"
        Me.CBGcent.Size = New System.Drawing.Size(308, 21)
        Me.CBGcent.TabIndex = 135
        '
        'LbGcret
        '
        Me.LbGcret.AutoSize = True
        Me.LbGcret.BackColor = System.Drawing.Color.White
        Me.LbGcret.Location = New System.Drawing.Point(483, 65)
        Me.LbGcret.Name = "LbGcret"
        Me.LbGcret.Size = New System.Drawing.Size(104, 13)
        Me.LbGcret.TabIndex = 134
        Me.LbGcret.Text = "Card Retrofited From"
        '
        'TBGcent2
        '
        Me.TBGcent2.Location = New System.Drawing.Point(485, 83)
        Me.TBGcent2.Name = "TBGcent2"
        Me.TBGcent2.Size = New System.Drawing.Size(122, 20)
        Me.TBGcent2.TabIndex = 136
        '
        'TBGcentRet
        '
        Me.TBGcentRet.Location = New System.Drawing.Point(483, 83)
        Me.TBGcentRet.Name = "TBGcentRet"
        Me.TBGcentRet.Size = New System.Drawing.Size(122, 20)
        Me.TBGcentRet.TabIndex = 138
        '
        'LLBlinkCQ
        '
        Me.LLBlinkCQ.AutoSize = True
        Me.LLBlinkCQ.BackColor = System.Drawing.Color.White
        Me.LLBlinkCQ.Location = New System.Drawing.Point(127, 63)
        Me.LLBlinkCQ.Name = "LLBlinkCQ"
        Me.LLBlinkCQ.Size = New System.Drawing.Size(45, 13)
        Me.LLBlinkCQ.TabIndex = 140
        Me.LLBlinkCQ.TabStop = True
        Me.LLBlinkCQ.Text = "Link CQ"
        Me.ToolTip1.SetToolTip(Me.LLBlinkCQ, "Open CQ Web")
        '
        'LbLink
        '
        Me.LbLink.AutoSize = True
        Me.LbLink.BackColor = System.Drawing.Color.White
        Me.LbLink.Location = New System.Drawing.Point(250, 65)
        Me.LbLink.Name = "LbLink"
        Me.LbLink.Size = New System.Drawing.Size(37, 13)
        Me.LbLink.TabIndex = 141
        Me.LbLink.Text = "CARD"
        Me.LbLink.Visible = False
        '
        'TBPatch
        '
        Me.TBPatch.BackColor = System.Drawing.Color.White
        Me.TBPatch.Location = New System.Drawing.Point(748, 196)
        Me.TBPatch.Name = "TBPatch"
        Me.TBPatch.ReadOnly = True
        Me.TBPatch.Size = New System.Drawing.Size(177, 20)
        Me.TBPatch.TabIndex = 143
        '
        'LbPatch
        '
        Me.LbPatch.AutoSize = True
        Me.LbPatch.BackColor = System.Drawing.Color.White
        Me.LbPatch.Location = New System.Drawing.Point(750, 180)
        Me.LbPatch.Name = "LbPatch"
        Me.LbPatch.Size = New System.Drawing.Size(76, 13)
        Me.LbPatch.TabIndex = 142
        Me.LbPatch.Text = "Delivery Patch"
        '
        'TBDeliveryPatch
        '
        Me.TBDeliveryPatch.BackColor = System.Drawing.Color.White
        Me.TBDeliveryPatch.Location = New System.Drawing.Point(747, 234)
        Me.TBDeliveryPatch.Name = "TBDeliveryPatch"
        Me.TBDeliveryPatch.ReadOnly = True
        Me.TBDeliveryPatch.Size = New System.Drawing.Size(178, 20)
        Me.TBDeliveryPatch.TabIndex = 145
        '
        'LBdelDate
        '
        Me.LBdelDate.AutoSize = True
        Me.LBdelDate.BackColor = System.Drawing.Color.White
        Me.LBdelDate.Location = New System.Drawing.Point(750, 218)
        Me.LBdelDate.Name = "LBdelDate"
        Me.LBdelDate.Size = New System.Drawing.Size(109, 13)
        Me.LBdelDate.TabIndex = 144
        Me.LBdelDate.Text = "Internal Delivery Date"
        '
        'BRessource
        '
        Me.BRessource.BackColor = System.Drawing.Color.White
        Me.BRessource.FlatAppearance.BorderSize = 0
        Me.BRessource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRessource.Image = Global.WindowsApplication1.My.Resources.Resources.search3_p
        Me.BRessource.Location = New System.Drawing.Point(433, 155)
        Me.BRessource.Name = "BRessource"
        Me.BRessource.Size = New System.Drawing.Size(25, 25)
        Me.BRessource.TabIndex = 156
        Me.ToolTip1.SetToolTip(Me.BRessource, "Ressource R&D informtaion")
        Me.BRessource.UseVisualStyleBackColor = False
        '
        'Bsearch
        '
        Me.Bsearch.FlatAppearance.BorderSize = 0
        Me.Bsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsearch.Image = Global.WindowsApplication1.My.Resources.Resources.search2
        Me.Bsearch.Location = New System.Drawing.Point(341, 63)
        Me.Bsearch.Name = "Bsearch"
        Me.Bsearch.Size = New System.Drawing.Size(50, 50)
        Me.Bsearch.TabIndex = 155
        Me.ToolTip1.SetToolTip(Me.Bsearch, "Case information")
        Me.Bsearch.UseVisualStyleBackColor = True
        '
        'Bsearch2
        '
        Me.Bsearch2.BackColor = System.Drawing.Color.White
        Me.Bsearch2.FlatAppearance.BorderSize = 0
        Me.Bsearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsearch2.Image = Global.WindowsApplication1.My.Resources.Resources.search3_p
        Me.Bsearch2.Location = New System.Drawing.Point(797, 76)
        Me.Bsearch2.Name = "Bsearch2"
        Me.Bsearch2.Size = New System.Drawing.Size(25, 25)
        Me.Bsearch2.TabIndex = 154
        Me.ToolTip1.SetToolTip(Me.Bsearch2, "Card information")
        Me.Bsearch2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.search3_p
        Me.Button1.Location = New System.Drawing.Point(433, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 153
        Me.ToolTip1.SetToolTip(Me.Button1, "Card retrofited details")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.search3_p
        Me.Button3.Location = New System.Drawing.Point(145, 196)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(20, 20)
        Me.Button3.TabIndex = 152
        Me.ToolTip1.SetToolTip(Me.Button3, "Customer information")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.Mail_i
        Me.Button2.Location = New System.Drawing.Point(397, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 129
        Me.ToolTip1.SetToolTip(Me.Button2, "Mail")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FSearchGcent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(941, 869)
        Me.Controls.Add(Me.BRessource)
        Me.Controls.Add(Me.Bsearch)
        Me.Controls.Add(Me.Bsearch2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TBDeliveryPatch)
        Me.Controls.Add(Me.LBdelDate)
        Me.Controls.Add(Me.TBPatch)
        Me.Controls.Add(Me.LbPatch)
        Me.Controls.Add(Me.LbLink)
        Me.Controls.Add(Me.LLBlinkCQ)
        Me.Controls.Add(Me.CBGcent)
        Me.Controls.Add(Me.TBGcent2)
        Me.Controls.Add(Me.LbGcret)
        Me.Controls.Add(Me.TBUrgence)
        Me.Controls.Add(Me.LbUrg)
        Me.Controls.Add(Me.LVad)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBCP)
        Me.Controls.Add(Me.LbCP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RTBms)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RTBDOTM)
        Me.Controls.Add(Me.LBDOTI)
        Me.Controls.Add(Me.RTBDOTI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBDesc)
        Me.Controls.Add(Me.RTBDesc)
        Me.Controls.Add(Me.RTBLog)
        Me.Controls.Add(Me.TBECD)
        Me.Controls.Add(Me.LbECD)
        Me.Controls.Add(Me.TBstom)
        Me.Controls.Add(Me.LBstom)
        Me.Controls.Add(Me.TBRFE)
        Me.Controls.Add(Me.LbRFE)
        Me.Controls.Add(Me.CBRetrofit)
        Me.Controls.Add(Me.TBRetCard)
        Me.Controls.Add(Me.LbRetCard)
        Me.Controls.Add(Me.TBRDate)
        Me.Controls.Add(Me.LbRD)
        Me.Controls.Add(Me.TBIDD)
        Me.Controls.Add(Me.LbIDD)
        Me.Controls.Add(Me.TBSev)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LVHistory)
        Me.Controls.Add(Me.TBGcent)
        Me.Controls.Add(Me.LbGcent2)
        Me.Controls.Add(Me.TBCustomer)
        Me.Controls.Add(Me.LbCustomer)
        Me.Controls.Add(Me.TBAssigned)
        Me.Controls.Add(Me.LbAssigned)
        Me.Controls.Add(Me.TBSubProduct)
        Me.Controls.Add(Me.LbSubProduct)
        Me.Controls.Add(Me.TBProduct)
        Me.Controls.Add(Me.LbProduct)
        Me.Controls.Add(Me.TBDomain)
        Me.Controls.Add(Me.LbDomain)
        Me.Controls.Add(Me.TBLabel)
        Me.Controls.Add(Me.LbLabel)
        Me.Controls.Add(Me.TBCase)
        Me.Controls.Add(Me.LBCase)
        Me.Controls.Add(Me.LbState)
        Me.Controls.Add(Me.TBState)
        Me.Controls.Add(Me.LbTitle)
        Me.Controls.Add(Me.TBTitle)
        Me.Controls.Add(Me.TBGcentRet)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FSearchGcent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Card"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBRetrofit As System.Windows.Forms.CheckBox
    Friend WithEvents TBRetCard As System.Windows.Forms.TextBox
    Friend WithEvents LbRetCard As System.Windows.Forms.Label
    Friend WithEvents TBRDate As System.Windows.Forms.TextBox
    Friend WithEvents LbRD As System.Windows.Forms.Label
    Friend WithEvents TBIDD As System.Windows.Forms.TextBox
    Friend WithEvents LbIDD As System.Windows.Forms.Label
    Friend WithEvents TBSev As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LVHistory As System.Windows.Forms.ListView
    Friend WithEvents CHTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents CHUser As System.Windows.Forms.ColumnHeader
    Friend WithEvents CHAction As System.Windows.Forms.ColumnHeader
    Friend WithEvents CHNState As System.Windows.Forms.ColumnHeader
    Friend WithEvents CGOState As System.Windows.Forms.ColumnHeader
    Friend WithEvents TBGcent As System.Windows.Forms.TextBox
    Friend WithEvents LbGcent2 As System.Windows.Forms.Label
    Friend WithEvents TBCustomer As System.Windows.Forms.TextBox
    Friend WithEvents LbCustomer As System.Windows.Forms.Label
    Friend WithEvents TBAssigned As System.Windows.Forms.TextBox
    Friend WithEvents LbAssigned As System.Windows.Forms.Label
    Friend WithEvents TBSubProduct As System.Windows.Forms.TextBox
    Friend WithEvents LbSubProduct As System.Windows.Forms.Label
    Friend WithEvents TBProduct As System.Windows.Forms.TextBox
    Friend WithEvents LbProduct As System.Windows.Forms.Label
    Friend WithEvents TBDomain As System.Windows.Forms.TextBox
    Friend WithEvents LbDomain As System.Windows.Forms.Label
    Friend WithEvents TBLabel As System.Windows.Forms.TextBox
    Friend WithEvents LbLabel As System.Windows.Forms.Label
    Friend WithEvents TBCase As System.Windows.Forms.TextBox
    Friend WithEvents LBCase As System.Windows.Forms.Label
    Friend WithEvents LbState As System.Windows.Forms.Label
    Friend WithEvents TBState As System.Windows.Forms.TextBox
    Friend WithEvents LbTitle As System.Windows.Forms.Label
    Friend WithEvents TBTitle As System.Windows.Forms.TextBox
    Friend WithEvents TBRFE As System.Windows.Forms.TextBox
    Friend WithEvents LbRFE As System.Windows.Forms.Label
    Friend WithEvents TBECD As System.Windows.Forms.TextBox
    Friend WithEvents LbECD As System.Windows.Forms.Label
    Friend WithEvents TBstom As System.Windows.Forms.TextBox
    Friend WithEvents LBstom As System.Windows.Forms.Label
    Friend WithEvents RTBLog As System.Windows.Forms.RichTextBox
    Friend WithEvents RTBDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents LBDesc As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RTBDOTI As System.Windows.Forms.RichTextBox
    Friend WithEvents LBDOTI As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RTBDOTM As System.Windows.Forms.RichTextBox
    Friend WithEvents RTBms As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBCP As System.Windows.Forms.TextBox
    Friend WithEvents LbCP As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LVad As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TBUrgence As System.Windows.Forms.TextBox
    Friend WithEvents LbUrg As System.Windows.Forms.Label
    Friend WithEvents CBGcent As System.Windows.Forms.ComboBox
    Friend WithEvents LbGcret As System.Windows.Forms.Label
    Friend WithEvents TBGcent2 As System.Windows.Forms.TextBox
    Friend WithEvents TBGcentRet As System.Windows.Forms.TextBox
    Friend WithEvents LLBlinkCQ As System.Windows.Forms.LinkLabel
    Friend WithEvents LbLink As System.Windows.Forms.Label
    Friend WithEvents TBPatch As System.Windows.Forms.TextBox
    Friend WithEvents LbPatch As System.Windows.Forms.Label
    Friend WithEvents TBDeliveryPatch As System.Windows.Forms.TextBox
    Friend WithEvents LBdelDate As System.Windows.Forms.Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Bsearch2 As Button
    Friend WithEvents Bsearch As Button
    Friend WithEvents BRessource As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
