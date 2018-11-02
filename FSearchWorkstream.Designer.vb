<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSearchWorkstream
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BSearch = New System.Windows.Forms.Button()
        Me.CBGcent = New System.Windows.Forms.ComboBox()
        Me.LbGcent2 = New System.Windows.Forms.Label()
        Me.TBType = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBProductVersion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBMD = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBCD = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBModified = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBManaged = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBProduct = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBAGroup = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBCustomer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBCreated = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBWorkstream = New System.Windows.Forms.TextBox()
        Me.LBDesc = New System.Windows.Forms.Label()
        Me.TBOwner = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBState = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BSearch
        '
        Me.BSearch.BackColor = System.Drawing.SystemColors.Window
        Me.BSearch.FlatAppearance.BorderSize = 0
        Me.BSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSearch.Image = Global.WindowsApplication1.My.Resources.Resources.search3_p
        Me.BSearch.Location = New System.Drawing.Point(29, 336)
        Me.BSearch.Name = "BSearch"
        Me.BSearch.Size = New System.Drawing.Size(25, 25)
        Me.BSearch.TabIndex = 184
        Me.BSearch.UseVisualStyleBackColor = False
        '
        'CBGcent
        '
        Me.CBGcent.BackColor = System.Drawing.Color.White
        Me.CBGcent.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBGcent.FormattingEnabled = True
        Me.CBGcent.Location = New System.Drawing.Point(60, 338)
        Me.CBGcent.Name = "CBGcent"
        Me.CBGcent.Size = New System.Drawing.Size(308, 21)
        Me.CBGcent.TabIndex = 183
        '
        'LbGcent2
        '
        Me.LbGcent2.AutoSize = True
        Me.LbGcent2.BackColor = System.Drawing.Color.White
        Me.LbGcent2.ForeColor = System.Drawing.Color.Black
        Me.LbGcent2.Location = New System.Drawing.Point(57, 320)
        Me.LbGcent2.Name = "LbGcent2"
        Me.LbGcent2.Size = New System.Drawing.Size(70, 13)
        Me.LbGcent2.TabIndex = 182
        Me.LbGcent2.Text = "CARD (CRM)"
        '
        'TBType
        '
        Me.TBType.BackColor = System.Drawing.SystemColors.Window
        Me.TBType.Location = New System.Drawing.Point(503, 172)
        Me.TBType.Name = "TBType"
        Me.TBType.ReadOnly = True
        Me.TBType.Size = New System.Drawing.Size(179, 20)
        Me.TBType.TabIndex = 181
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Location = New System.Drawing.Point(466, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 180
        Me.Label12.Text = "Type"
        '
        'TBProductVersion
        '
        Me.TBProductVersion.BackColor = System.Drawing.SystemColors.Window
        Me.TBProductVersion.Location = New System.Drawing.Point(110, 209)
        Me.TBProductVersion.Name = "TBProductVersion"
        Me.TBProductVersion.ReadOnly = True
        Me.TBProductVersion.Size = New System.Drawing.Size(179, 20)
        Me.TBProductVersion.TabIndex = 179
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Location = New System.Drawing.Point(19, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 178
        Me.Label11.Text = "Product Version"
        '
        'TBMD
        '
        Me.TBMD.BackColor = System.Drawing.SystemColors.Window
        Me.TBMD.Location = New System.Drawing.Point(503, 209)
        Me.TBMD.Name = "TBMD"
        Me.TBMD.ReadOnly = True
        Me.TBMD.Size = New System.Drawing.Size(179, 20)
        Me.TBMD.TabIndex = 177
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(407, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 176
        Me.Label9.Text = "Modification Date"
        '
        'TBCD
        '
        Me.TBCD.BackColor = System.Drawing.SystemColors.Window
        Me.TBCD.Location = New System.Drawing.Point(503, 98)
        Me.TBCD.Name = "TBCD"
        Me.TBCD.ReadOnly = True
        Me.TBCD.Size = New System.Drawing.Size(179, 20)
        Me.TBCD.TabIndex = 175
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(425, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 174
        Me.Label8.Text = "Creation Date"
        '
        'TBModified
        '
        Me.TBModified.BackColor = System.Drawing.SystemColors.Window
        Me.TBModified.Location = New System.Drawing.Point(503, 135)
        Me.TBModified.Name = "TBModified"
        Me.TBModified.ReadOnly = True
        Me.TBModified.Size = New System.Drawing.Size(179, 20)
        Me.TBModified.TabIndex = 173
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(436, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 172
        Me.Label7.Text = "Modified by"
        '
        'TBManaged
        '
        Me.TBManaged.BackColor = System.Drawing.SystemColors.Window
        Me.TBManaged.Location = New System.Drawing.Point(110, 250)
        Me.TBManaged.Name = "TBManaged"
        Me.TBManaged.ReadOnly = True
        Me.TBManaged.Size = New System.Drawing.Size(179, 20)
        Me.TBManaged.TabIndex = 171
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(35, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "Managed by"
        '
        'TBProduct
        '
        Me.TBProduct.BackColor = System.Drawing.SystemColors.Window
        Me.TBProduct.Location = New System.Drawing.Point(110, 172)
        Me.TBProduct.Name = "TBProduct"
        Me.TBProduct.ReadOnly = True
        Me.TBProduct.Size = New System.Drawing.Size(179, 20)
        Me.TBProduct.TabIndex = 169
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(57, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "Product"
        '
        'TBAGroup
        '
        Me.TBAGroup.BackColor = System.Drawing.SystemColors.Window
        Me.TBAGroup.Location = New System.Drawing.Point(110, 139)
        Me.TBAGroup.Name = "TBAGroup"
        Me.TBAGroup.ReadOnly = True
        Me.TBAGroup.Size = New System.Drawing.Size(179, 20)
        Me.TBAGroup.TabIndex = 167
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(31, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Assign Group"
        '
        'TBCustomer
        '
        Me.TBCustomer.BackColor = System.Drawing.SystemColors.Window
        Me.TBCustomer.Location = New System.Drawing.Point(110, 102)
        Me.TBCustomer.Name = "TBCustomer"
        Me.TBCustomer.ReadOnly = True
        Me.TBCustomer.Size = New System.Drawing.Size(179, 20)
        Me.TBCustomer.TabIndex = 165
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(53, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Customer"
        '
        'TBCreated
        '
        Me.TBCreated.BackColor = System.Drawing.SystemColors.Window
        Me.TBCreated.Location = New System.Drawing.Point(503, 67)
        Me.TBCreated.Name = "TBCreated"
        Me.TBCreated.ReadOnly = True
        Me.TBCreated.Size = New System.Drawing.Size(179, 20)
        Me.TBCreated.TabIndex = 163
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(439, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Created by"
        '
        'TBWorkstream
        '
        Me.TBWorkstream.BackColor = System.Drawing.SystemColors.Window
        Me.TBWorkstream.Location = New System.Drawing.Point(110, 67)
        Me.TBWorkstream.Name = "TBWorkstream"
        Me.TBWorkstream.ReadOnly = True
        Me.TBWorkstream.Size = New System.Drawing.Size(179, 20)
        Me.TBWorkstream.TabIndex = 161
        '
        'LBDesc
        '
        Me.LBDesc.AutoSize = True
        Me.LBDesc.BackColor = System.Drawing.SystemColors.Window
        Me.LBDesc.Location = New System.Drawing.Point(37, 70)
        Me.LBDesc.Name = "LBDesc"
        Me.LBDesc.Size = New System.Drawing.Size(64, 13)
        Me.LBDesc.TabIndex = 160
        Me.LBDesc.Text = "Workstream"
        '
        'TBOwner
        '
        Me.TBOwner.BackColor = System.Drawing.SystemColors.Window
        Me.TBOwner.Location = New System.Drawing.Point(503, 246)
        Me.TBOwner.Name = "TBOwner"
        Me.TBOwner.ReadOnly = True
        Me.TBOwner.Size = New System.Drawing.Size(179, 20)
        Me.TBOwner.TabIndex = 186
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(459, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 185
        Me.Label4.Text = "Owner"
        '
        'TBState
        '
        Me.TBState.BackColor = System.Drawing.SystemColors.Window
        Me.TBState.Location = New System.Drawing.Point(110, 287)
        Me.TBState.Name = "TBState"
        Me.TBState.ReadOnly = True
        Me.TBState.Size = New System.Drawing.Size(179, 20)
        Me.TBState.TabIndex = 188
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(69, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 187
        Me.Label10.Text = "State"
        '
        'FSearchWorkstream
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TBState)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TBOwner)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BSearch)
        Me.Controls.Add(Me.CBGcent)
        Me.Controls.Add(Me.LbGcent2)
        Me.Controls.Add(Me.TBType)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TBProductVersion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TBMD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBCD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBModified)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBManaged)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBProduct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBAGroup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBCustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBCreated)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBWorkstream)
        Me.Controls.Add(Me.LBDesc)
        Me.Name = "FSearchWorkstream"
        Me.Text = "Search Workstream"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BSearch As Button
    Friend WithEvents CBGcent As ComboBox
    Friend WithEvents LbGcent2 As Label
    Friend WithEvents TBType As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TBProductVersion As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBMD As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBCD As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBModified As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBManaged As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBProduct As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBAGroup As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBCustomer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBCreated As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBWorkstream As TextBox
    Friend WithEvents LBDesc As Label
    Friend WithEvents TBOwner As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBState As TextBox
    Friend WithEvents Label10 As Label
End Class
