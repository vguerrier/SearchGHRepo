<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FSearchSelect
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
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.LVChoice = New System.Windows.Forms.ListView()
        Me.CHNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LBCase = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LVChoice
        '
        Me.LVChoice.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHNom, Me.CHType})
        Me.LVChoice.GridLines = True
        Me.LVChoice.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.LVChoice.Location = New System.Drawing.Point(31, 109)
        Me.LVChoice.Name = "LVChoice"
        Me.LVChoice.Size = New System.Drawing.Size(633, 147)
        Me.LVChoice.TabIndex = 69
        Me.LVChoice.UseCompatibleStateImageBehavior = False
        Me.LVChoice.View = System.Windows.Forms.View.Details
        '
        'CHNom
        '
        Me.CHNom.Text = "Name"
        Me.CHNom.Width = 450
        '
        'CHType
        '
        Me.CHType.Text = "Type"
        Me.CHType.Width = 340
        '
        'LBCase
        '
        Me.LBCase.AutoSize = True
        Me.LBCase.BackColor = System.Drawing.Color.White
        Me.LBCase.ForeColor = System.Drawing.Color.Black
        Me.LBCase.Location = New System.Drawing.Point(38, 79)
        Me.LBCase.Name = "LBCase"
        Me.LBCase.Size = New System.Drawing.Size(309, 13)
        Me.LBCase.TabIndex = 70
        Me.LBCase.Text = "Search result brings more than one result. please choose a type."
        '
        'FSearchSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 280)
        Me.Controls.Add(Me.LBCase)
        Me.Controls.Add(Me.LVChoice)
        Me.Name = "FSearchSelect"
        Me.Text = "Select Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LVChoice As ListView
    Friend WithEvents CHNom As ColumnHeader
    Friend WithEvents CHType As ColumnHeader
    Friend WithEvents LBCase As Label
End Class
