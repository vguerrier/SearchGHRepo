<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FsearchSelectPatch
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
        Me.TBNB = New System.Windows.Forms.TextBox()
        Me.LbNB = New System.Windows.Forms.Label()
        Me.LBCase = New System.Windows.Forms.Label()
        Me.LVPatch = New System.Windows.Forms.ListView()
        Me.CHNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHCard = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHClient = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHRFE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TBPatch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TBNB
        '
        Me.TBNB.BackColor = System.Drawing.SystemColors.Window
        Me.TBNB.Location = New System.Drawing.Point(533, 62)
        Me.TBNB.Name = "TBNB"
        Me.TBNB.ReadOnly = True
        Me.TBNB.Size = New System.Drawing.Size(179, 20)
        Me.TBNB.TabIndex = 76
        '
        'LbNB
        '
        Me.LbNB.AutoSize = True
        Me.LbNB.BackColor = System.Drawing.SystemColors.Window
        Me.LbNB.Location = New System.Drawing.Point(500, 65)
        Me.LbNB.Name = "LbNB"
        Me.LbNB.Size = New System.Drawing.Size(21, 13)
        Me.LbNB.TabIndex = 75
        Me.LbNB.Text = "Nb"
        '
        'LBCase
        '
        Me.LBCase.AutoSize = True
        Me.LBCase.BackColor = System.Drawing.Color.White
        Me.LBCase.ForeColor = System.Drawing.Color.Black
        Me.LBCase.Location = New System.Drawing.Point(19, 65)
        Me.LBCase.Name = "LBCase"
        Me.LBCase.Size = New System.Drawing.Size(114, 13)
        Me.LBCase.TabIndex = 74
        Me.LBCase.Text = "List of cards in patch : "
        '
        'LVPatch
        '
        Me.LVPatch.AllowColumnReorder = True
        Me.LVPatch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHNom, Me.CHCard, Me.CHClient, Me.CHRFE, Me.CHTitle})
        Me.LVPatch.GridLines = True
        Me.LVPatch.Location = New System.Drawing.Point(12, 97)
        Me.LVPatch.MultiSelect = False
        Me.LVPatch.Name = "LVPatch"
        Me.LVPatch.Size = New System.Drawing.Size(944, 336)
        Me.LVPatch.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.LVPatch.TabIndex = 73
        Me.LVPatch.UseCompatibleStateImageBehavior = False
        Me.LVPatch.View = System.Windows.Forms.View.Details
        '
        'CHNom
        '
        Me.CHNom.Text = "Case"
        Me.CHNom.Width = 99
        '
        'CHCard
        '
        Me.CHCard.Text = "Card"
        Me.CHCard.Width = 134
        '
        'CHClient
        '
        Me.CHClient.Text = "Customer"
        Me.CHClient.Width = 183
        '
        'CHRFE
        '
        Me.CHRFE.Text = "Code RFE"
        Me.CHRFE.Width = 72
        '
        'CHTitle
        '
        Me.CHTitle.Text = "Title"
        Me.CHTitle.Width = 452
        '
        'TBPatch
        '
        Me.TBPatch.BackColor = System.Drawing.SystemColors.Window
        Me.TBPatch.Location = New System.Drawing.Point(139, 62)
        Me.TBPatch.Name = "TBPatch"
        Me.TBPatch.ReadOnly = True
        Me.TBPatch.Size = New System.Drawing.Size(282, 20)
        Me.TBPatch.TabIndex = 77
        '
        'FsearchSelectPatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 445)
        Me.Controls.Add(Me.TBPatch)
        Me.Controls.Add(Me.TBNB)
        Me.Controls.Add(Me.LbNB)
        Me.Controls.Add(Me.LBCase)
        Me.Controls.Add(Me.LVPatch)
        Me.Name = "FsearchSelectPatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "External Patch information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBNB As TextBox
    Friend WithEvents LbNB As Label
    Friend WithEvents LBCase As Label
    Friend WithEvents CHNom As ColumnHeader
    Friend WithEvents CHCard As ColumnHeader
    Friend WithEvents CHTitle As ColumnHeader
    Friend WithEvents TBPatch As TextBox
    Friend WithEvents CHClient As ColumnHeader
    Friend WithEvents LVPatch As ListView
    Friend WithEvents CHRFE As ColumnHeader
End Class
