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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSearchSelect))
        Me.LBCase = New System.Windows.Forms.Label()
        Me.TBNB = New System.Windows.Forms.TextBox()
        Me.LbNB = New System.Windows.Forms.Label()
        Me.LVChoice = New System.Windows.Forms.ListView()
        Me.CHNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'LBCase
        '
        Me.LBCase.AutoSize = True
        Me.LBCase.BackColor = System.Drawing.Color.White
        Me.LBCase.ForeColor = System.Drawing.Color.Black
        Me.LBCase.Location = New System.Drawing.Point(38, 79)
        Me.LBCase.Name = "LBCase"
        Me.LBCase.Size = New System.Drawing.Size(377, 13)
        Me.LBCase.TabIndex = 70
        Me.LBCase.Text = "Search result brings more than one result. please choose a type. (Double click)"
        '
        'TBNB
        '
        Me.TBNB.BackColor = System.Drawing.SystemColors.Window
        Me.TBNB.Location = New System.Drawing.Point(552, 76)
        Me.TBNB.Name = "TBNB"
        Me.TBNB.ReadOnly = True
        Me.TBNB.Size = New System.Drawing.Size(179, 20)
        Me.TBNB.TabIndex = 72
        '
        'LbNB
        '
        Me.LbNB.AutoSize = True
        Me.LbNB.BackColor = System.Drawing.SystemColors.Window
        Me.LbNB.Location = New System.Drawing.Point(519, 79)
        Me.LbNB.Name = "LbNB"
        Me.LbNB.Size = New System.Drawing.Size(21, 13)
        Me.LbNB.TabIndex = 71
        Me.LbNB.Text = "Nb"
        '
        'LVChoice
        '
        Me.LVChoice.AllowColumnReorder = True
        Me.LVChoice.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHNom, Me.CHType})
        Me.LVChoice.GridLines = True
        Me.LVChoice.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.LVChoice.Location = New System.Drawing.Point(31, 105)
        Me.LVChoice.Name = "LVChoice"
        Me.LVChoice.Size = New System.Drawing.Size(783, 462)
        Me.LVChoice.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.LVChoice.TabIndex = 69
        Me.LVChoice.UseCompatibleStateImageBehavior = False
        Me.LVChoice.View = System.Windows.Forms.View.Details
        '
        'CHNom
        '
        Me.CHNom.Text = "Name"
        Me.CHNom.Width = 495
        '
        'CHType
        '
        Me.CHType.Text = "Type"
        Me.CHType.Width = 134
        '
        'FSearchSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 579)
        Me.Controls.Add(Me.TBNB)
        Me.Controls.Add(Me.LbNB)
        Me.Controls.Add(Me.LBCase)
        Me.Controls.Add(Me.LVChoice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FSearchSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LVChoice As ListView
    Friend WithEvents CHNom As ColumnHeader
    Friend WithEvents CHType As ColumnHeader
    Friend WithEvents LBCase As Label
    Friend WithEvents TBNB As TextBox
    Friend WithEvents LbNB As Label
End Class
