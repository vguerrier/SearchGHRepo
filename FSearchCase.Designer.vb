<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FSearchCase
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSearchCase))
        Me.CHComments = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TBSev = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lhistory = New System.Windows.Forms.Label()
        Me.CHUser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LVComment = New System.Windows.Forms.ListView()
        Me.CHTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TBGcent = New System.Windows.Forms.TextBox()
        Me.LbGcent2 = New System.Windows.Forms.Label()
        Me.TBCustomer = New System.Windows.Forms.TextBox()
        Me.LbCustomer = New System.Windows.Forms.Label()
        Me.TBProduct = New System.Windows.Forms.TextBox()
        Me.LbProduct = New System.Windows.Forms.Label()
        Me.TBModule = New System.Windows.Forms.TextBox()
        Me.LbModule = New System.Windows.Forms.Label()
        Me.LBCase = New System.Windows.Forms.Label()
        Me.LbState = New System.Windows.Forms.Label()
        Me.TBState = New System.Windows.Forms.TextBox()
        Me.LbTitle = New System.Windows.Forms.Label()
        Me.TBTitle = New System.Windows.Forms.TextBox()
        Me.TBSP = New System.Windows.Forms.TextBox()
        Me.LbSP = New System.Windows.Forms.Label()
        Me.TBECD = New System.Windows.Forms.TextBox()
        Me.LbECD = New System.Windows.Forms.Label()
        Me.TBEDD = New System.Windows.Forms.TextBox()
        Me.LbEDD = New System.Windows.Forms.Label()
        Me.TBvtp = New System.Windows.Forms.TextBox()
        Me.Lbvtp = New System.Windows.Forms.Label()
        Me.LBAg = New System.Windows.Forms.Label()
        Me.TBLastModified = New System.Windows.Forms.TextBox()
        Me.LBLastModified = New System.Windows.Forms.Label()
        Me.TBWorkstream = New System.Windows.Forms.TextBox()
        Me.LBWorkstream = New System.Windows.Forms.Label()
        Me.TBCreated = New System.Windows.Forms.TextBox()
        Me.LBCreated = New System.Windows.Forms.Label()
        Me.TBAssigned = New System.Windows.Forms.TextBox()
        Me.LBOwner = New System.Windows.Forms.Label()
        Me.TBOwner = New System.Windows.Forms.TextBox()
        Me.TBCQState = New System.Windows.Forms.TextBox()
        Me.LBQState = New System.Windows.Forms.Label()
        Me.TBRejection = New System.Windows.Forms.TextBox()
        Me.LBRejection = New System.Windows.Forms.Label()
        Me.TBAperson = New System.Windows.Forms.TextBox()
        Me.LBAPerson = New System.Windows.Forms.Label()
        Me.TBCustomerCase = New System.Windows.Forms.TextBox()
        Me.LBCustomerCase = New System.Windows.Forms.Label()
        Me.TBCQAssignedto = New System.Windows.Forms.TextBox()
        Me.LBCQAssigned = New System.Windows.Forms.Label()
        Me.RTBCase = New System.Windows.Forms.RichTextBox()
        Me.CBGcent = New System.Windows.Forms.ComboBox()
        Me.TBVersion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBGcent2 = New System.Windows.Forms.ComboBox()
        Me.LGCENT2 = New System.Windows.Forms.Label()
        Me.TBGcent2 = New System.Windows.Forms.TextBox()
        Me.CBGlib = New System.Windows.Forms.ComboBox()
        Me.LBGlib = New System.Windows.Forms.Label()
        Me.TBGlib = New System.Windows.Forms.TextBox()
        Me.LbDesc = New System.Windows.Forms.Label()
        Me.RTBDesc = New System.Windows.Forms.RichTextBox()
        Me.LLBlinkCRM = New System.Windows.Forms.LinkLabel()
        Me.LbLink = New System.Windows.Forms.Label()
        Me.TBFD = New System.Windows.Forms.TextBox()
        Me.LbFunctionalDomain = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BGlib = New System.Windows.Forms.Button()
        Me.BSearch2 = New System.Windows.Forms.Button()
        Me.BSearch = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CHComments
        '
        Me.CHComments.Text = "Comment"
        Me.CHComments.Width = 520
        '
        'TBSev
        '
        Me.TBSev.Location = New System.Drawing.Point(216, 208)
        Me.TBSev.Name = "TBSev"
        Me.TBSev.Size = New System.Drawing.Size(182, 20)
        Me.TBSev.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(213, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Severity"
        '
        'Lhistory
        '
        Me.Lhistory.AutoSize = True
        Me.Lhistory.BackColor = System.Drawing.Color.White
        Me.Lhistory.ForeColor = System.Drawing.Color.Black
        Me.Lhistory.Location = New System.Drawing.Point(28, 569)
        Me.Lhistory.Name = "Lhistory"
        Me.Lhistory.Size = New System.Drawing.Size(56, 13)
        Me.Lhistory.TabIndex = 69
        Me.Lhistory.Text = "Comments"
        '
        'CHUser
        '
        Me.CHUser.Text = "User"
        Me.CHUser.Width = 104
        '
        'LVComment
        '
        Me.LVComment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHComments, Me.CHUser, Me.CHTime})
        Me.LVComment.GridLines = True
        Me.LVComment.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.LVComment.Location = New System.Drawing.Point(31, 585)
        Me.LVComment.Name = "LVComment"
        Me.LVComment.Size = New System.Drawing.Size(722, 241)
        Me.LVComment.TabIndex = 68
        Me.LVComment.UseCompatibleStateImageBehavior = False
        Me.LVComment.View = System.Windows.Forms.View.Details
        '
        'CHTime
        '
        Me.CHTime.Text = "Time"
        Me.CHTime.Width = 93
        '
        'TBGcent
        '
        Me.TBGcent.Location = New System.Drawing.Point(83, 79)
        Me.TBGcent.Name = "TBGcent"
        Me.TBGcent.Size = New System.Drawing.Size(122, 20)
        Me.TBGcent.TabIndex = 66
        '
        'LbGcent2
        '
        Me.LbGcent2.AutoSize = True
        Me.LbGcent2.BackColor = System.Drawing.Color.White
        Me.LbGcent2.ForeColor = System.Drawing.Color.Black
        Me.LbGcent2.Location = New System.Drawing.Point(80, 61)
        Me.LbGcent2.Name = "LbGcent2"
        Me.LbGcent2.Size = New System.Drawing.Size(70, 13)
        Me.LbGcent2.TabIndex = 65
        Me.LbGcent2.Text = "CARD (CRM)"
        '
        'TBCustomer
        '
        Me.TBCustomer.Location = New System.Drawing.Point(586, 208)
        Me.TBCustomer.Name = "TBCustomer"
        Me.TBCustomer.Size = New System.Drawing.Size(136, 20)
        Me.TBCustomer.TabIndex = 62
        '
        'LbCustomer
        '
        Me.LbCustomer.AutoSize = True
        Me.LbCustomer.BackColor = System.Drawing.Color.White
        Me.LbCustomer.ForeColor = System.Drawing.Color.Black
        Me.LbCustomer.Location = New System.Drawing.Point(583, 192)
        Me.LbCustomer.Name = "LbCustomer"
        Me.LbCustomer.Size = New System.Drawing.Size(51, 13)
        Me.LbCustomer.TabIndex = 61
        Me.LbCustomer.Text = "Customer"
        '
        'TBProduct
        '
        Me.TBProduct.Location = New System.Drawing.Point(216, 256)
        Me.TBProduct.Name = "TBProduct"
        Me.TBProduct.Size = New System.Drawing.Size(182, 20)
        Me.TBProduct.TabIndex = 50
        '
        'LbProduct
        '
        Me.LbProduct.AutoSize = True
        Me.LbProduct.BackColor = System.Drawing.Color.White
        Me.LbProduct.ForeColor = System.Drawing.Color.Black
        Me.LbProduct.Location = New System.Drawing.Point(213, 240)
        Me.LbProduct.Name = "LbProduct"
        Me.LbProduct.Size = New System.Drawing.Size(44, 13)
        Me.LbProduct.TabIndex = 49
        Me.LbProduct.Text = "Product"
        '
        'TBModule
        '
        Me.TBModule.Location = New System.Drawing.Point(31, 306)
        Me.TBModule.Name = "TBModule"
        Me.TBModule.Size = New System.Drawing.Size(179, 20)
        Me.TBModule.TabIndex = 46
        '
        'LbModule
        '
        Me.LbModule.AutoSize = True
        Me.LbModule.BackColor = System.Drawing.Color.White
        Me.LbModule.ForeColor = System.Drawing.Color.Black
        Me.LbModule.Location = New System.Drawing.Point(28, 290)
        Me.LbModule.Name = "LbModule"
        Me.LbModule.Size = New System.Drawing.Size(42, 13)
        Me.LbModule.TabIndex = 45
        Me.LbModule.Text = "Module"
        '
        'LBCase
        '
        Me.LBCase.AutoSize = True
        Me.LBCase.BackColor = System.Drawing.Color.White
        Me.LBCase.ForeColor = System.Drawing.Color.Black
        Me.LBCase.Location = New System.Drawing.Point(394, 61)
        Me.LBCase.Name = "LBCase"
        Me.LBCase.Size = New System.Drawing.Size(35, 13)
        Me.LBCase.TabIndex = 43
        Me.LBCase.Text = "CASE"
        '
        'LbState
        '
        Me.LbState.AutoSize = True
        Me.LbState.BackColor = System.Drawing.Color.White
        Me.LbState.ForeColor = System.Drawing.Color.Black
        Me.LbState.Location = New System.Drawing.Point(28, 191)
        Me.LbState.Name = "LbState"
        Me.LbState.Size = New System.Drawing.Size(32, 13)
        Me.LbState.TabIndex = 42
        Me.LbState.Text = "State"
        '
        'TBState
        '
        Me.TBState.Location = New System.Drawing.Point(31, 208)
        Me.TBState.Name = "TBState"
        Me.TBState.Size = New System.Drawing.Size(179, 20)
        Me.TBState.TabIndex = 41
        '
        'LbTitle
        '
        Me.LbTitle.AutoSize = True
        Me.LbTitle.BackColor = System.Drawing.Color.White
        Me.LbTitle.ForeColor = System.Drawing.Color.Black
        Me.LbTitle.Location = New System.Drawing.Point(28, 147)
        Me.LbTitle.Name = "LbTitle"
        Me.LbTitle.Size = New System.Drawing.Size(27, 13)
        Me.LbTitle.TabIndex = 40
        Me.LbTitle.Text = "Title"
        '
        'TBTitle
        '
        Me.TBTitle.Location = New System.Drawing.Point(31, 164)
        Me.TBTitle.Name = "TBTitle"
        Me.TBTitle.Size = New System.Drawing.Size(722, 20)
        Me.TBTitle.TabIndex = 39
        '
        'TBSP
        '
        Me.TBSP.Location = New System.Drawing.Point(556, 78)
        Me.TBSP.Name = "TBSP"
        Me.TBSP.Size = New System.Drawing.Size(151, 20)
        Me.TBSP.TabIndex = 73
        '
        'LbSP
        '
        Me.LbSP.AutoSize = True
        Me.LbSP.BackColor = System.Drawing.Color.White
        Me.LbSP.ForeColor = System.Drawing.Color.Black
        Me.LbSP.Location = New System.Drawing.Point(553, 61)
        Me.LbSP.Name = "LbSP"
        Me.LbSP.Size = New System.Drawing.Size(69, 13)
        Me.LbSP.TabIndex = 72
        Me.LbSP.Text = "Priority Score"
        '
        'TBECD
        '
        Me.TBECD.Location = New System.Drawing.Point(586, 256)
        Me.TBECD.Name = "TBECD"
        Me.TBECD.Size = New System.Drawing.Size(167, 20)
        Me.TBECD.TabIndex = 77
        '
        'LbECD
        '
        Me.LbECD.AutoSize = True
        Me.LbECD.BackColor = System.Drawing.Color.White
        Me.LbECD.ForeColor = System.Drawing.Color.Black
        Me.LbECD.Location = New System.Drawing.Point(583, 240)
        Me.LbECD.Name = "LbECD"
        Me.LbECD.Size = New System.Drawing.Size(126, 13)
        Me.LbECD.TabIndex = 76
        Me.LbECD.Text = "Expected CorrectionDate"
        '
        'TBEDD
        '
        Me.TBEDD.Location = New System.Drawing.Point(404, 256)
        Me.TBEDD.Name = "TBEDD"
        Me.TBEDD.Size = New System.Drawing.Size(176, 20)
        Me.TBEDD.TabIndex = 75
        '
        'LbEDD
        '
        Me.LbEDD.AutoSize = True
        Me.LbEDD.BackColor = System.Drawing.Color.White
        Me.LbEDD.ForeColor = System.Drawing.Color.Black
        Me.LbEDD.Location = New System.Drawing.Point(401, 240)
        Me.LbEDD.Name = "LbEDD"
        Me.LbEDD.Size = New System.Drawing.Size(119, 13)
        Me.LbEDD.TabIndex = 74
        Me.LbEDD.Text = "Expected Delivery Date"
        '
        'TBvtp
        '
        Me.TBvtp.Location = New System.Drawing.Point(31, 256)
        Me.TBvtp.Name = "TBvtp"
        Me.TBvtp.Size = New System.Drawing.Size(179, 20)
        Me.TBvtp.TabIndex = 79
        '
        'Lbvtp
        '
        Me.Lbvtp.AutoSize = True
        Me.Lbvtp.BackColor = System.Drawing.Color.White
        Me.Lbvtp.ForeColor = System.Drawing.Color.Black
        Me.Lbvtp.Location = New System.Drawing.Point(28, 240)
        Me.Lbvtp.Name = "Lbvtp"
        Me.Lbvtp.Size = New System.Drawing.Size(116, 13)
        Me.Lbvtp.TabIndex = 78
        Me.Lbvtp.Text = "Validated Target Patch"
        '
        'LBAg
        '
        Me.LBAg.AutoSize = True
        Me.LBAg.BackColor = System.Drawing.Color.White
        Me.LBAg.ForeColor = System.Drawing.Color.Black
        Me.LBAg.Location = New System.Drawing.Point(401, 192)
        Me.LBAg.Name = "LBAg"
        Me.LBAg.Size = New System.Drawing.Size(82, 13)
        Me.LBAg.TabIndex = 80
        Me.LBAg.Text = "Assigned Group"
        '
        'TBLastModified
        '
        Me.TBLastModified.Location = New System.Drawing.Point(404, 352)
        Me.TBLastModified.Name = "TBLastModified"
        Me.TBLastModified.Size = New System.Drawing.Size(174, 20)
        Me.TBLastModified.TabIndex = 89
        '
        'LBLastModified
        '
        Me.LBLastModified.AutoSize = True
        Me.LBLastModified.BackColor = System.Drawing.Color.White
        Me.LBLastModified.ForeColor = System.Drawing.Color.Black
        Me.LBLastModified.Location = New System.Drawing.Point(401, 336)
        Me.LBLastModified.Name = "LBLastModified"
        Me.LBLastModified.Size = New System.Drawing.Size(70, 13)
        Me.LBLastModified.TabIndex = 88
        Me.LBLastModified.Text = "Last Modified"
        '
        'TBWorkstream
        '
        Me.TBWorkstream.Location = New System.Drawing.Point(31, 352)
        Me.TBWorkstream.Name = "TBWorkstream"
        Me.TBWorkstream.Size = New System.Drawing.Size(179, 20)
        Me.TBWorkstream.TabIndex = 87
        '
        'LBWorkstream
        '
        Me.LBWorkstream.AutoSize = True
        Me.LBWorkstream.BackColor = System.Drawing.Color.White
        Me.LBWorkstream.ForeColor = System.Drawing.Color.Black
        Me.LBWorkstream.Location = New System.Drawing.Point(28, 336)
        Me.LBWorkstream.Name = "LBWorkstream"
        Me.LBWorkstream.Size = New System.Drawing.Size(64, 13)
        Me.LBWorkstream.TabIndex = 86
        Me.LBWorkstream.Text = "Workstream"
        '
        'TBCreated
        '
        Me.TBCreated.Location = New System.Drawing.Point(216, 352)
        Me.TBCreated.Name = "TBCreated"
        Me.TBCreated.Size = New System.Drawing.Size(182, 20)
        Me.TBCreated.TabIndex = 83
        '
        'LBCreated
        '
        Me.LBCreated.AutoSize = True
        Me.LBCreated.BackColor = System.Drawing.Color.White
        Me.LBCreated.ForeColor = System.Drawing.Color.Black
        Me.LBCreated.Location = New System.Drawing.Point(213, 336)
        Me.LBCreated.Name = "LBCreated"
        Me.LBCreated.Size = New System.Drawing.Size(44, 13)
        Me.LBCreated.TabIndex = 82
        Me.LBCreated.Text = "Created"
        '
        'TBAssigned
        '
        Me.TBAssigned.Location = New System.Drawing.Point(404, 208)
        Me.TBAssigned.Name = "TBAssigned"
        Me.TBAssigned.Size = New System.Drawing.Size(176, 20)
        Me.TBAssigned.TabIndex = 58
        '
        'LBOwner
        '
        Me.LBOwner.AutoSize = True
        Me.LBOwner.BackColor = System.Drawing.Color.White
        Me.LBOwner.ForeColor = System.Drawing.Color.Black
        Me.LBOwner.Location = New System.Drawing.Point(213, 290)
        Me.LBOwner.Name = "LBOwner"
        Me.LBOwner.Size = New System.Drawing.Size(38, 13)
        Me.LBOwner.TabIndex = 84
        Me.LBOwner.Text = "Owner"
        '
        'TBOwner
        '
        Me.TBOwner.Location = New System.Drawing.Point(216, 306)
        Me.TBOwner.Name = "TBOwner"
        Me.TBOwner.Size = New System.Drawing.Size(185, 20)
        Me.TBOwner.TabIndex = 85
        '
        'TBCQState
        '
        Me.TBCQState.Location = New System.Drawing.Point(586, 352)
        Me.TBCQState.Name = "TBCQState"
        Me.TBCQState.Size = New System.Drawing.Size(167, 20)
        Me.TBCQState.TabIndex = 91
        '
        'LBQState
        '
        Me.LBQState.AutoSize = True
        Me.LBQState.BackColor = System.Drawing.Color.White
        Me.LBQState.ForeColor = System.Drawing.Color.Black
        Me.LBQState.Location = New System.Drawing.Point(583, 336)
        Me.LBQState.Name = "LBQState"
        Me.LBQState.Size = New System.Drawing.Size(47, 13)
        Me.LBQState.TabIndex = 90
        Me.LBQState.Text = "CQState"
        '
        'TBRejection
        '
        Me.TBRejection.Location = New System.Drawing.Point(31, 402)
        Me.TBRejection.Name = "TBRejection"
        Me.TBRejection.Size = New System.Drawing.Size(179, 20)
        Me.TBRejection.TabIndex = 93
        '
        'LBRejection
        '
        Me.LBRejection.AutoSize = True
        Me.LBRejection.BackColor = System.Drawing.Color.White
        Me.LBRejection.ForeColor = System.Drawing.Color.Black
        Me.LBRejection.Location = New System.Drawing.Point(28, 386)
        Me.LBRejection.Name = "LBRejection"
        Me.LBRejection.Size = New System.Drawing.Size(52, 13)
        Me.LBRejection.TabIndex = 92
        Me.LBRejection.Text = "Rejection"
        '
        'TBAperson
        '
        Me.TBAperson.Location = New System.Drawing.Point(216, 402)
        Me.TBAperson.Name = "TBAperson"
        Me.TBAperson.Size = New System.Drawing.Size(182, 20)
        Me.TBAperson.TabIndex = 95
        '
        'LBAPerson
        '
        Me.LBAPerson.AutoSize = True
        Me.LBAPerson.BackColor = System.Drawing.Color.White
        Me.LBAPerson.ForeColor = System.Drawing.Color.Black
        Me.LBAPerson.Location = New System.Drawing.Point(213, 386)
        Me.LBAPerson.Name = "LBAPerson"
        Me.LBAPerson.Size = New System.Drawing.Size(86, 13)
        Me.LBAPerson.TabIndex = 94
        Me.LBAPerson.Text = "Assigned Person"
        '
        'TBCustomerCase
        '
        Me.TBCustomerCase.Location = New System.Drawing.Point(404, 402)
        Me.TBCustomerCase.Name = "TBCustomerCase"
        Me.TBCustomerCase.Size = New System.Drawing.Size(174, 20)
        Me.TBCustomerCase.TabIndex = 97
        '
        'LBCustomerCase
        '
        Me.LBCustomerCase.AutoSize = True
        Me.LBCustomerCase.BackColor = System.Drawing.Color.White
        Me.LBCustomerCase.ForeColor = System.Drawing.Color.Black
        Me.LBCustomerCase.Location = New System.Drawing.Point(401, 386)
        Me.LBCustomerCase.Name = "LBCustomerCase"
        Me.LBCustomerCase.Size = New System.Drawing.Size(85, 13)
        Me.LBCustomerCase.TabIndex = 96
        Me.LBCustomerCase.Text = "Customer's Case"
        '
        'TBCQAssignedto
        '
        Me.TBCQAssignedto.Location = New System.Drawing.Point(584, 402)
        Me.TBCQAssignedto.Name = "TBCQAssignedto"
        Me.TBCQAssignedto.Size = New System.Drawing.Size(169, 20)
        Me.TBCQAssignedto.TabIndex = 99
        '
        'LBCQAssigned
        '
        Me.LBCQAssigned.AutoSize = True
        Me.LBCQAssigned.BackColor = System.Drawing.Color.White
        Me.LBCQAssigned.ForeColor = System.Drawing.Color.Black
        Me.LBCQAssigned.Location = New System.Drawing.Point(583, 386)
        Me.LBCQAssigned.Name = "LBCQAssigned"
        Me.LBCQAssigned.Size = New System.Drawing.Size(80, 13)
        Me.LBCQAssigned.TabIndex = 98
        Me.LBCQAssigned.Text = "CQ Assigned to"
        '
        'RTBCase
        '
        Me.RTBCase.Location = New System.Drawing.Point(397, 78)
        Me.RTBCase.Name = "RTBCase"
        Me.RTBCase.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTBCase.Size = New System.Drawing.Size(149, 21)
        Me.RTBCase.TabIndex = 128
        Me.RTBCase.Text = ""
        '
        'CBGcent
        '
        Me.CBGcent.BackColor = System.Drawing.Color.White
        Me.CBGcent.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBGcent.FormattingEnabled = True
        Me.CBGcent.Location = New System.Drawing.Point(83, 79)
        Me.CBGcent.Name = "CBGcent"
        Me.CBGcent.Size = New System.Drawing.Size(308, 21)
        Me.CBGcent.TabIndex = 129
        '
        'TBVersion
        '
        Me.TBVersion.Location = New System.Drawing.Point(407, 306)
        Me.TBVersion.Name = "TBVersion"
        Me.TBVersion.Size = New System.Drawing.Size(173, 20)
        Me.TBVersion.TabIndex = 131
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(401, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Version"
        '
        'CBGcent2
        '
        Me.CBGcent2.BackColor = System.Drawing.Color.White
        Me.CBGcent2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBGcent2.FormattingEnabled = True
        Me.CBGcent2.Location = New System.Drawing.Point(83, 128)
        Me.CBGcent2.Name = "CBGcent2"
        Me.CBGcent2.Size = New System.Drawing.Size(308, 21)
        Me.CBGcent2.TabIndex = 134
        '
        'LGCENT2
        '
        Me.LGCENT2.AutoSize = True
        Me.LGCENT2.BackColor = System.Drawing.Color.White
        Me.LGCENT2.ForeColor = System.Drawing.Color.Black
        Me.LGCENT2.Location = New System.Drawing.Point(80, 112)
        Me.LGCENT2.Name = "LGCENT2"
        Me.LGCENT2.Size = New System.Drawing.Size(98, 13)
        Me.LGCENT2.TabIndex = 132
        Me.LGCENT2.Text = "CARD (ClearQuest)"
        '
        'TBGcent2
        '
        Me.TBGcent2.Location = New System.Drawing.Point(83, 128)
        Me.TBGcent2.Name = "TBGcent2"
        Me.TBGcent2.Size = New System.Drawing.Size(122, 20)
        Me.TBGcent2.TabIndex = 135
        '
        'CBGlib
        '
        Me.CBGlib.BackColor = System.Drawing.Color.White
        Me.CBGlib.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBGlib.FormattingEnabled = True
        Me.CBGlib.Location = New System.Drawing.Point(429, 127)
        Me.CBGlib.Name = "CBGlib"
        Me.CBGlib.Size = New System.Drawing.Size(308, 21)
        Me.CBGlib.TabIndex = 138
        '
        'LBGlib
        '
        Me.LBGlib.AutoSize = True
        Me.LBGlib.BackColor = System.Drawing.Color.White
        Me.LBGlib.ForeColor = System.Drawing.Color.Black
        Me.LBGlib.Location = New System.Drawing.Point(426, 112)
        Me.LBGlib.Name = "LBGlib"
        Me.LBGlib.Size = New System.Drawing.Size(92, 13)
        Me.LBGlib.TabIndex = 137
        Me.LBGlib.Text = "GLIB (ClearQuest)"
        '
        'TBGlib
        '
        Me.TBGlib.Location = New System.Drawing.Point(429, 127)
        Me.TBGlib.Name = "TBGlib"
        Me.TBGlib.Size = New System.Drawing.Size(122, 20)
        Me.TBGlib.TabIndex = 140
        '
        'LbDesc
        '
        Me.LbDesc.AutoSize = True
        Me.LbDesc.BackColor = System.Drawing.Color.White
        Me.LbDesc.ForeColor = System.Drawing.Color.Black
        Me.LbDesc.Location = New System.Drawing.Point(28, 436)
        Me.LbDesc.Name = "LbDesc"
        Me.LbDesc.Size = New System.Drawing.Size(60, 13)
        Me.LbDesc.TabIndex = 141
        Me.LbDesc.Text = "Description"
        '
        'RTBDesc
        '
        Me.RTBDesc.BackColor = System.Drawing.Color.White
        Me.RTBDesc.Location = New System.Drawing.Point(31, 452)
        Me.RTBDesc.Name = "RTBDesc"
        Me.RTBDesc.ReadOnly = True
        Me.RTBDesc.Size = New System.Drawing.Size(722, 110)
        Me.RTBDesc.TabIndex = 142
        Me.RTBDesc.Text = ""
        '
        'LLBlinkCRM
        '
        Me.LLBlinkCRM.AutoSize = True
        Me.LLBlinkCRM.BackColor = System.Drawing.Color.Transparent
        Me.LLBlinkCRM.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LLBlinkCRM.Location = New System.Drawing.Point(186, 61)
        Me.LLBlinkCRM.Name = "LLBlinkCRM"
        Me.LLBlinkCRM.Size = New System.Drawing.Size(54, 13)
        Me.LLBlinkCRM.TabIndex = 143
        Me.LLBlinkCRM.TabStop = True
        Me.LLBlinkCRM.Text = "Link CRM"
        '
        'LbLink
        '
        Me.LbLink.AutoSize = True
        Me.LbLink.BackColor = System.Drawing.Color.White
        Me.LbLink.ForeColor = System.Drawing.Color.Black
        Me.LbLink.Location = New System.Drawing.Point(255, 61)
        Me.LbLink.Name = "LbLink"
        Me.LbLink.Size = New System.Drawing.Size(37, 13)
        Me.LbLink.TabIndex = 144
        Me.LbLink.Text = "CARD"
        Me.LbLink.Visible = False
        '
        'TBFD
        '
        Me.TBFD.Location = New System.Drawing.Point(586, 306)
        Me.TBFD.Name = "TBFD"
        Me.TBFD.Size = New System.Drawing.Size(167, 20)
        Me.TBFD.TabIndex = 147
        '
        'LbFunctionalDomain
        '
        Me.LbFunctionalDomain.AutoSize = True
        Me.LbFunctionalDomain.BackColor = System.Drawing.Color.White
        Me.LbFunctionalDomain.ForeColor = System.Drawing.Color.Black
        Me.LbFunctionalDomain.Location = New System.Drawing.Point(580, 290)
        Me.LbFunctionalDomain.Name = "LbFunctionalDomain"
        Me.LbFunctionalDomain.Size = New System.Drawing.Size(95, 13)
        Me.LbFunctionalDomain.TabIndex = 146
        Me.LbFunctionalDomain.Text = "Functional Domain"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(728, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 145
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BGlib
        '
        Me.BGlib.FlatAppearance.BorderSize = 0
        Me.BGlib.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGlib.Location = New System.Drawing.Point(398, 124)
        Me.BGlib.Name = "BGlib"
        Me.BGlib.Size = New System.Drawing.Size(25, 25)
        Me.BGlib.TabIndex = 139
        Me.BGlib.UseVisualStyleBackColor = True
        '
        'BSearch2
        '
        Me.BSearch2.BackColor = System.Drawing.Color.White
        Me.BSearch2.FlatAppearance.BorderSize = 0
        Me.BSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSearch2.Image = Global.WindowsApplication1.My.Resources.Resources.search3_p
        Me.BSearch2.Location = New System.Drawing.Point(40, 124)
        Me.BSearch2.Name = "BSearch2"
        Me.BSearch2.Size = New System.Drawing.Size(25, 25)
        Me.BSearch2.TabIndex = 136
        Me.BSearch2.UseVisualStyleBackColor = False
        '
        'BSearch
        '
        Me.BSearch.AutoSize = True
        Me.BSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BSearch.BackColor = System.Drawing.Color.White
        Me.BSearch.Depth = 0
        Me.BSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BSearch.Icon = Global.WindowsApplication1.My.Resources.Resources.search2
        Me.BSearch.Image = Global.WindowsApplication1.My.Resources.Resources.search2
        Me.BSearch.Location = New System.Drawing.Point(21, 69)
        Me.BSearch.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BSearch.MouseState = MaterialSkin.MouseState.HOVER
        Me.BSearch.Name = "BSearch"
        Me.BSearch.Primary = False
        Me.BSearch.Size = New System.Drawing.Size(44, 36)
        Me.BSearch.TabIndex = 150
        Me.BSearch.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.search3_p
        Me.Button2.Location = New System.Drawing.Point(728, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 151
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FSearchCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 837)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BSearch)
        Me.Controls.Add(Me.TBFD)
        Me.Controls.Add(Me.LbFunctionalDomain)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LbLink)
        Me.Controls.Add(Me.LLBlinkCRM)
        Me.Controls.Add(Me.RTBDesc)
        Me.Controls.Add(Me.LbDesc)
        Me.Controls.Add(Me.CBGlib)
        Me.Controls.Add(Me.TBGlib)
        Me.Controls.Add(Me.BGlib)
        Me.Controls.Add(Me.LBGlib)
        Me.Controls.Add(Me.BSearch2)
        Me.Controls.Add(Me.CBGcent2)
        Me.Controls.Add(Me.TBGcent2)
        Me.Controls.Add(Me.LGCENT2)
        Me.Controls.Add(Me.TBVersion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBGcent)
        Me.Controls.Add(Me.RTBCase)
        Me.Controls.Add(Me.TBCQAssignedto)
        Me.Controls.Add(Me.LBCQAssigned)
        Me.Controls.Add(Me.TBCustomerCase)
        Me.Controls.Add(Me.LBCustomerCase)
        Me.Controls.Add(Me.TBAperson)
        Me.Controls.Add(Me.LBAPerson)
        Me.Controls.Add(Me.TBRejection)
        Me.Controls.Add(Me.LBRejection)
        Me.Controls.Add(Me.TBCQState)
        Me.Controls.Add(Me.LBQState)
        Me.Controls.Add(Me.TBLastModified)
        Me.Controls.Add(Me.LBLastModified)
        Me.Controls.Add(Me.TBWorkstream)
        Me.Controls.Add(Me.LBWorkstream)
        Me.Controls.Add(Me.TBOwner)
        Me.Controls.Add(Me.LBOwner)
        Me.Controls.Add(Me.TBCreated)
        Me.Controls.Add(Me.LBCreated)
        Me.Controls.Add(Me.LBAg)
        Me.Controls.Add(Me.TBvtp)
        Me.Controls.Add(Me.Lbvtp)
        Me.Controls.Add(Me.TBECD)
        Me.Controls.Add(Me.LbECD)
        Me.Controls.Add(Me.TBEDD)
        Me.Controls.Add(Me.LbEDD)
        Me.Controls.Add(Me.TBSP)
        Me.Controls.Add(Me.LbSP)
        Me.Controls.Add(Me.TBSev)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lhistory)
        Me.Controls.Add(Me.LVComment)
        Me.Controls.Add(Me.TBGcent)
        Me.Controls.Add(Me.LbGcent2)
        Me.Controls.Add(Me.TBCustomer)
        Me.Controls.Add(Me.LbCustomer)
        Me.Controls.Add(Me.TBAssigned)
        Me.Controls.Add(Me.TBProduct)
        Me.Controls.Add(Me.LbProduct)
        Me.Controls.Add(Me.TBModule)
        Me.Controls.Add(Me.LbModule)
        Me.Controls.Add(Me.LBCase)
        Me.Controls.Add(Me.LbState)
        Me.Controls.Add(Me.TBState)
        Me.Controls.Add(Me.LbTitle)
        Me.Controls.Add(Me.TBTitle)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FSearchCase"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Case"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CHComments As System.Windows.Forms.ColumnHeader
    Friend WithEvents TBSev As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lhistory As System.Windows.Forms.Label
    Friend WithEvents CHUser As System.Windows.Forms.ColumnHeader
    Friend WithEvents LVComment As System.Windows.Forms.ListView
    Friend WithEvents CHTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents TBGcent As System.Windows.Forms.TextBox
    Friend WithEvents LbGcent2 As System.Windows.Forms.Label
    Friend WithEvents TBCustomer As System.Windows.Forms.TextBox
    Friend WithEvents LbCustomer As System.Windows.Forms.Label
    Friend WithEvents TBProduct As System.Windows.Forms.TextBox
    Friend WithEvents LbProduct As System.Windows.Forms.Label
    Friend WithEvents TBModule As System.Windows.Forms.TextBox
    Friend WithEvents LbModule As System.Windows.Forms.Label
    Friend WithEvents LBCase As System.Windows.Forms.Label
    Friend WithEvents LbState As System.Windows.Forms.Label
    Friend WithEvents TBState As System.Windows.Forms.TextBox
    Friend WithEvents LbTitle As System.Windows.Forms.Label
    Friend WithEvents TBTitle As System.Windows.Forms.TextBox
    Friend WithEvents TBSP As System.Windows.Forms.TextBox
    Friend WithEvents LbSP As System.Windows.Forms.Label
    Friend WithEvents TBECD As System.Windows.Forms.TextBox
    Friend WithEvents LbECD As System.Windows.Forms.Label
    Friend WithEvents TBEDD As System.Windows.Forms.TextBox
    Friend WithEvents LbEDD As System.Windows.Forms.Label
    Friend WithEvents TBvtp As System.Windows.Forms.TextBox
    Friend WithEvents Lbvtp As System.Windows.Forms.Label
    Friend WithEvents LBAg As System.Windows.Forms.Label
    Friend WithEvents TBLastModified As System.Windows.Forms.TextBox
    Friend WithEvents LBLastModified As System.Windows.Forms.Label
    Friend WithEvents TBWorkstream As System.Windows.Forms.TextBox
    Friend WithEvents LBWorkstream As System.Windows.Forms.Label
    Friend WithEvents TBCreated As System.Windows.Forms.TextBox
    Friend WithEvents LBCreated As System.Windows.Forms.Label
    Friend WithEvents TBAssigned As System.Windows.Forms.TextBox
    Friend WithEvents LBOwner As System.Windows.Forms.Label
    Friend WithEvents TBOwner As System.Windows.Forms.TextBox
    Friend WithEvents TBCQState As System.Windows.Forms.TextBox
    Friend WithEvents LBQState As System.Windows.Forms.Label
    Friend WithEvents TBRejection As System.Windows.Forms.TextBox
    Friend WithEvents LBRejection As System.Windows.Forms.Label
    Friend WithEvents TBAperson As System.Windows.Forms.TextBox
    Friend WithEvents LBAPerson As System.Windows.Forms.Label
    Friend WithEvents TBCustomerCase As System.Windows.Forms.TextBox
    Friend WithEvents LBCustomerCase As System.Windows.Forms.Label
    Friend WithEvents TBCQAssignedto As System.Windows.Forms.TextBox
    Friend WithEvents LBCQAssigned As System.Windows.Forms.Label
    Friend WithEvents RTBCase As System.Windows.Forms.RichTextBox
    Friend WithEvents CBGcent As System.Windows.Forms.ComboBox
    Friend WithEvents TBVersion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBGcent2 As System.Windows.Forms.ComboBox
    Friend WithEvents LGCENT2 As System.Windows.Forms.Label
    Friend WithEvents TBGcent2 As System.Windows.Forms.TextBox
    Friend WithEvents BSearch2 As System.Windows.Forms.Button
    Friend WithEvents BGlib As System.Windows.Forms.Button
    Friend WithEvents CBGlib As System.Windows.Forms.ComboBox
    Friend WithEvents LBGlib As System.Windows.Forms.Label
    Friend WithEvents TBGlib As System.Windows.Forms.TextBox
    Friend WithEvents LbDesc As System.Windows.Forms.Label
    Friend WithEvents RTBDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents LLBlinkCRM As System.Windows.Forms.LinkLabel
    Friend WithEvents LbLink As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TBFD As TextBox
    Friend WithEvents LbFunctionalDomain As Label
    Friend WithEvents BSearch As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button2 As Button
End Class
