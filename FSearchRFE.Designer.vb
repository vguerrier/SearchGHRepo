<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FSearchRFE
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
        Me.TBCRFE = New System.Windows.Forms.TextBox()
        Me.LBDesc = New System.Windows.Forms.Label()
        Me.TBTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBCustomer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBStatus = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBProduct = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBDomain = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBManager = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBTDD = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBRDD = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RTBDesc = New System.Windows.Forms.RichTextBox()
        Me.TBType = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RTBSol = New System.Windows.Forms.RichTextBox()
        Me.TBWorstream = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CBGcent = New System.Windows.Forms.ComboBox()
        Me.LbGcent2 = New System.Windows.Forms.Label()
        Me.BSearch = New System.Windows.Forms.Button()
        Me.TBTrans = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBCRFE
        '
        Me.TBCRFE.BackColor = System.Drawing.SystemColors.Window
        Me.TBCRFE.Location = New System.Drawing.Point(81, 66)
        Me.TBCRFE.Name = "TBCRFE"
        Me.TBCRFE.ReadOnly = True
        Me.TBCRFE.Size = New System.Drawing.Size(179, 20)
        Me.TBCRFE.TabIndex = 5
        '
        'LBDesc
        '
        Me.LBDesc.AutoSize = True
        Me.LBDesc.BackColor = System.Drawing.SystemColors.Window
        Me.LBDesc.Location = New System.Drawing.Point(19, 69)
        Me.LBDesc.Name = "LBDesc"
        Me.LBDesc.Size = New System.Drawing.Size(56, 13)
        Me.LBDesc.TabIndex = 4
        Me.LBDesc.Text = "Code RFE"
        '
        'TBTitle
        '
        Me.TBTitle.BackColor = System.Drawing.SystemColors.Window
        Me.TBTitle.Location = New System.Drawing.Point(384, 66)
        Me.TBTitle.Name = "TBTitle"
        Me.TBTitle.ReadOnly = True
        Me.TBTitle.Size = New System.Drawing.Size(179, 20)
        Me.TBTitle.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(351, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Title"
        '
        'TBCustomer
        '
        Me.TBCustomer.BackColor = System.Drawing.SystemColors.Window
        Me.TBCustomer.Location = New System.Drawing.Point(81, 101)
        Me.TBCustomer.Name = "TBCustomer"
        Me.TBCustomer.ReadOnly = True
        Me.TBCustomer.Size = New System.Drawing.Size(179, 20)
        Me.TBCustomer.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(24, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Customer"
        '
        'TBStatus
        '
        Me.TBStatus.BackColor = System.Drawing.SystemColors.Window
        Me.TBStatus.Location = New System.Drawing.Point(81, 138)
        Me.TBStatus.Name = "TBStatus"
        Me.TBStatus.ReadOnly = True
        Me.TBStatus.Size = New System.Drawing.Size(179, 20)
        Me.TBStatus.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(38, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(14, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Solution"
        '
        'TBProduct
        '
        Me.TBProduct.BackColor = System.Drawing.SystemColors.Window
        Me.TBProduct.Location = New System.Drawing.Point(81, 211)
        Me.TBProduct.Name = "TBProduct"
        Me.TBProduct.ReadOnly = True
        Me.TBProduct.Size = New System.Drawing.Size(179, 20)
        Me.TBProduct.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(31, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Product"
        '
        'TBDomain
        '
        Me.TBDomain.BackColor = System.Drawing.SystemColors.Window
        Me.TBDomain.Location = New System.Drawing.Point(81, 249)
        Me.TBDomain.Name = "TBDomain"
        Me.TBDomain.ReadOnly = True
        Me.TBDomain.Size = New System.Drawing.Size(179, 20)
        Me.TBDomain.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(31, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Domain"
        '
        'TBManager
        '
        Me.TBManager.BackColor = System.Drawing.SystemColors.Window
        Me.TBManager.Location = New System.Drawing.Point(384, 208)
        Me.TBManager.Name = "TBManager"
        Me.TBManager.ReadOnly = True
        Me.TBManager.Size = New System.Drawing.Size(179, 20)
        Me.TBManager.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(329, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Manager"
        '
        'TBTDD
        '
        Me.TBTDD.BackColor = System.Drawing.SystemColors.Window
        Me.TBTDD.Location = New System.Drawing.Point(384, 97)
        Me.TBTDD.Name = "TBTDD"
        Me.TBTDD.ReadOnly = True
        Me.TBTDD.Size = New System.Drawing.Size(179, 20)
        Me.TBTDD.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(260, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Theorical Delivery Date"
        '
        'TBRDD
        '
        Me.TBRDD.BackColor = System.Drawing.SystemColors.Window
        Me.TBRDD.Location = New System.Drawing.Point(384, 135)
        Me.TBRDD.Name = "TBRDD"
        Me.TBRDD.ReadOnly = True
        Me.TBRDD.Size = New System.Drawing.Size(179, 20)
        Me.TBRDD.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(282, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Real Delivery Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(12, 491)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Description"
        '
        'RTBDesc
        '
        Me.RTBDesc.BackColor = System.Drawing.Color.White
        Me.RTBDesc.Location = New System.Drawing.Point(15, 507)
        Me.RTBDesc.Name = "RTBDesc"
        Me.RTBDesc.ReadOnly = True
        Me.RTBDesc.Size = New System.Drawing.Size(773, 192)
        Me.RTBDesc.TabIndex = 143
        Me.RTBDesc.Text = ""
        '
        'TBType
        '
        Me.TBType.BackColor = System.Drawing.SystemColors.Window
        Me.TBType.Location = New System.Drawing.Point(81, 174)
        Me.TBType.Name = "TBType"
        Me.TBType.ReadOnly = True
        Me.TBType.Size = New System.Drawing.Size(179, 20)
        Me.TBType.TabIndex = 145
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Location = New System.Drawing.Point(8, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 144
        Me.Label11.Text = "Type Solution"
        '
        'RTBSol
        '
        Me.RTBSol.BackColor = System.Drawing.Color.White
        Me.RTBSol.Location = New System.Drawing.Point(15, 296)
        Me.RTBSol.Name = "RTBSol"
        Me.RTBSol.ReadOnly = True
        Me.RTBSol.Size = New System.Drawing.Size(773, 192)
        Me.RTBSol.TabIndex = 146
        Me.RTBSol.Text = ""
        '
        'TBWorstream
        '
        Me.TBWorstream.BackColor = System.Drawing.SystemColors.Window
        Me.TBWorstream.Location = New System.Drawing.Point(384, 171)
        Me.TBWorstream.Name = "TBWorstream"
        Me.TBWorstream.ReadOnly = True
        Me.TBWorstream.Size = New System.Drawing.Size(179, 20)
        Me.TBWorstream.TabIndex = 148
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Location = New System.Drawing.Point(314, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 147
        Me.Label12.Text = "Workstream"
        '
        'CBGcent
        '
        Me.CBGcent.BackColor = System.Drawing.Color.White
        Me.CBGcent.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBGcent.FormattingEnabled = True
        Me.CBGcent.Location = New System.Drawing.Point(384, 249)
        Me.CBGcent.Name = "CBGcent"
        Me.CBGcent.Size = New System.Drawing.Size(308, 21)
        Me.CBGcent.TabIndex = 158
        '
        'LbGcent2
        '
        Me.LbGcent2.AutoSize = True
        Me.LbGcent2.BackColor = System.Drawing.Color.White
        Me.LbGcent2.ForeColor = System.Drawing.Color.Black
        Me.LbGcent2.Location = New System.Drawing.Point(381, 231)
        Me.LbGcent2.Name = "LbGcent2"
        Me.LbGcent2.Size = New System.Drawing.Size(70, 13)
        Me.LbGcent2.TabIndex = 157
        Me.LbGcent2.Text = "CARD (CRM)"
        '
        'BSearch
        '
        Me.BSearch.BackColor = System.Drawing.SystemColors.Window
        Me.BSearch.FlatAppearance.BorderSize = 0
        Me.BSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSearch.Image = Global.WindowsApplication1.My.Resources.Resources.search3_p
        Me.BSearch.Location = New System.Drawing.Point(353, 247)
        Me.BSearch.Name = "BSearch"
        Me.BSearch.Size = New System.Drawing.Size(25, 25)
        Me.BSearch.TabIndex = 159
        Me.BSearch.UseVisualStyleBackColor = False
        '
        'TBTrans
        '
        Me.TBTrans.BackColor = System.Drawing.SystemColors.Window
        Me.TBTrans.Location = New System.Drawing.Point(579, 85)
        Me.TBTrans.Name = "TBTrans"
        Me.TBTrans.ReadOnly = True
        Me.TBTrans.Size = New System.Drawing.Size(179, 20)
        Me.TBTrans.TabIndex = 161
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Location = New System.Drawing.Point(576, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 13)
        Me.Label13.TabIndex = 160
        Me.Label13.Text = "Transfert Date CSO/Maint"
        '
        'FSearchRFE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 707)
        Me.Controls.Add(Me.TBTrans)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BSearch)
        Me.Controls.Add(Me.CBGcent)
        Me.Controls.Add(Me.LbGcent2)
        Me.Controls.Add(Me.TBWorstream)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.RTBSol)
        Me.Controls.Add(Me.TBType)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.RTBDesc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TBRDD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBTDD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBManager)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBDomain)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBProduct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBCustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBCRFE)
        Me.Controls.Add(Me.LBDesc)
        Me.Name = "FSearchRFE"
        Me.Text = "RFE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBCRFE As TextBox
    Friend WithEvents LBDesc As Label
    Friend WithEvents TBTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBCustomer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBStatus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBProduct As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBDomain As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBManager As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBTDD As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBRDD As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RTBDesc As RichTextBox
    Friend WithEvents TBType As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents RTBSol As RichTextBox
    Friend WithEvents TBWorstream As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CBGcent As ComboBox
    Friend WithEvents LbGcent2 As Label
    Friend WithEvents BSearch As Button
    Friend WithEvents TBTrans As TextBox
    Friend WithEvents Label13 As Label
End Class
