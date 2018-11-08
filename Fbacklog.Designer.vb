<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FBacklog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBacklog))
        Me.TBCus = New System.Windows.Forms.TextBox()
        Me.TBNbCases = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVBacklog = New System.Windows.Forms.DataGridView()
        Me.LState = New System.Windows.Forms.Label()
        Me.CLBFilterState = New System.Windows.Forms.CheckedListBox()
        Me.CLBFilterPriority = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LB_NB = New System.Windows.Forms.Label()
        Me.CLBFilterAGroup = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CLBFilterWorkstream = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FilterRemove = New System.Windows.Forms.Button()
        Me.CBClosed = New System.Windows.Forms.CheckBox()
        Me.CBGcent = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BExcel = New System.Windows.Forms.Button()
        Me.Bfilter = New System.Windows.Forms.Button()
        Me.CLBVTP = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BS1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BBacklog = New System.Windows.Forms.Button()
        CType(Me.DGVBacklog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBCus
        '
        Me.TBCus.BackColor = System.Drawing.Color.White
        Me.TBCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCus.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TBCus.Location = New System.Drawing.Point(12, 65)
        Me.TBCus.Name = "TBCus"
        Me.TBCus.ReadOnly = True
        Me.TBCus.Size = New System.Drawing.Size(331, 26)
        Me.TBCus.TabIndex = 2
        '
        'TBNbCases
        '
        Me.TBNbCases.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNbCases.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TBNbCases.Location = New System.Drawing.Point(489, 65)
        Me.TBNbCases.Name = "TBNbCases"
        Me.TBNbCases.Size = New System.Drawing.Size(100, 26)
        Me.TBNbCases.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(432, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Nb Cases"
        '
        'DGVBacklog
        '
        Me.DGVBacklog.AllowUserToAddRows = False
        Me.DGVBacklog.AllowUserToDeleteRows = False
        Me.DGVBacklog.AllowUserToOrderColumns = True
        Me.DGVBacklog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVBacklog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVBacklog.CausesValidation = False
        Me.DGVBacklog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DGVBacklog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBacklog.Location = New System.Drawing.Point(12, 266)
        Me.DGVBacklog.MultiSelect = False
        Me.DGVBacklog.Name = "DGVBacklog"
        Me.DGVBacklog.ReadOnly = True
        Me.DGVBacklog.ShowCellErrors = False
        Me.DGVBacklog.ShowCellToolTips = False
        Me.DGVBacklog.ShowEditingIcon = False
        Me.DGVBacklog.ShowRowErrors = False
        Me.DGVBacklog.Size = New System.Drawing.Size(1560, 531)
        Me.DGVBacklog.TabIndex = 99
        '
        'LState
        '
        Me.LState.AutoSize = True
        Me.LState.BackColor = System.Drawing.Color.White
        Me.LState.Location = New System.Drawing.Point(111, 98)
        Me.LState.Name = "LState"
        Me.LState.Size = New System.Drawing.Size(37, 13)
        Me.LState.TabIndex = 132
        Me.LState.Text = "Status"
        '
        'CLBFilterState
        '
        Me.CLBFilterState.CheckOnClick = True
        Me.CLBFilterState.FormattingEnabled = True
        Me.CLBFilterState.Location = New System.Drawing.Point(60, 114)
        Me.CLBFilterState.Name = "CLBFilterState"
        Me.CLBFilterState.Size = New System.Drawing.Size(140, 139)
        Me.CLBFilterState.TabIndex = 134
        '
        'CLBFilterPriority
        '
        Me.CLBFilterPriority.CheckOnClick = True
        Me.CLBFilterPriority.FormattingEnabled = True
        Me.CLBFilterPriority.Location = New System.Drawing.Point(230, 114)
        Me.CLBFilterPriority.Name = "CLBFilterPriority"
        Me.CLBFilterPriority.Size = New System.Drawing.Size(140, 139)
        Me.CLBFilterPriority.TabIndex = 136
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(281, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Priority"
        '
        'LB_NB
        '
        Me.LB_NB.AutoSize = True
        Me.LB_NB.BackColor = System.Drawing.Color.White
        Me.LB_NB.Location = New System.Drawing.Point(343, 77)
        Me.LB_NB.Name = "LB_NB"
        Me.LB_NB.Size = New System.Drawing.Size(0, 13)
        Me.LB_NB.TabIndex = 137
        '
        'CLBFilterAGroup
        '
        Me.CLBFilterAGroup.CheckOnClick = True
        Me.CLBFilterAGroup.FormattingEnabled = True
        Me.CLBFilterAGroup.Location = New System.Drawing.Point(400, 114)
        Me.CLBFilterAGroup.Name = "CLBFilterAGroup"
        Me.CLBFilterAGroup.Size = New System.Drawing.Size(140, 139)
        Me.CLBFilterAGroup.TabIndex = 139
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(435, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Assign Group"
        '
        'CLBFilterWorkstream
        '
        Me.CLBFilterWorkstream.CheckOnClick = True
        Me.CLBFilterWorkstream.FormattingEnabled = True
        Me.CLBFilterWorkstream.Location = New System.Drawing.Point(570, 114)
        Me.CLBFilterWorkstream.Name = "CLBFilterWorkstream"
        Me.CLBFilterWorkstream.Size = New System.Drawing.Size(140, 139)
        Me.CLBFilterWorkstream.TabIndex = 141
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(608, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Workstream"
        '
        'FilterRemove
        '
        Me.FilterRemove.BackColor = System.Drawing.Color.White
        Me.FilterRemove.FlatAppearance.BorderSize = 0
        Me.FilterRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilterRemove.Image = Global.WindowsApplication1.My.Resources.Resources.uncheckall
        Me.FilterRemove.Location = New System.Drawing.Point(20, 137)
        Me.FilterRemove.Name = "FilterRemove"
        Me.FilterRemove.Size = New System.Drawing.Size(22, 20)
        Me.FilterRemove.TabIndex = 142
        Me.ToolTip1.SetToolTip(Me.FilterRemove, "Remove filters")
        Me.FilterRemove.UseVisualStyleBackColor = False
        '
        'CBClosed
        '
        Me.CBClosed.AutoSize = True
        Me.CBClosed.BackColor = System.Drawing.Color.White
        Me.CBClosed.Location = New System.Drawing.Point(910, 114)
        Me.CBClosed.Name = "CBClosed"
        Me.CBClosed.Size = New System.Drawing.Size(143, 17)
        Me.CBClosed.TabIndex = 143
        Me.CBClosed.Text = "Closed Cases (30 limited)"
        Me.CBClosed.UseVisualStyleBackColor = False
        '
        'CBGcent
        '
        Me.CBGcent.AutoSize = True
        Me.CBGcent.BackColor = System.Drawing.Color.White
        Me.CBGcent.Location = New System.Drawing.Point(910, 140)
        Me.CBGcent.Name = "CBGcent"
        Me.CBGcent.Size = New System.Drawing.Size(165, 17)
        Me.CBGcent.TabIndex = 144
        Me.CBGcent.Text = "Add CQ Cards to the Case list"
        Me.CBGcent.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        Me.Button2.Location = New System.Drawing.Point(350, 94)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 20)
        Me.Button2.TabIndex = 149
        Me.ToolTip1.SetToolTip(Me.Button2, "All")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        Me.Button3.Location = New System.Drawing.Point(520, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(20, 20)
        Me.Button3.TabIndex = 150
        Me.ToolTip1.SetToolTip(Me.Button3, "All")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        Me.Button4.Location = New System.Drawing.Point(690, 94)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(20, 20)
        Me.Button4.TabIndex = 151
        Me.ToolTip1.SetToolTip(Me.Button4, "All")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        Me.Button5.Location = New System.Drawing.Point(860, 94)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(20, 20)
        Me.Button5.TabIndex = 152
        Me.ToolTip1.SetToolTip(Me.Button5, "All")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.checkall
        Me.Button1.Location = New System.Drawing.Point(180, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 20)
        Me.Button1.TabIndex = 148
        Me.ToolTip1.SetToolTip(Me.Button1, "All")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BExcel
        '
        Me.BExcel.AccessibleDescription = ""
        Me.BExcel.AccessibleName = ""
        Me.BExcel.BackColor = System.Drawing.Color.White
        Me.BExcel.FlatAppearance.BorderSize = 0
        Me.BExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BExcel.Image = CType(resources.GetObject("BExcel.Image"), System.Drawing.Image)
        Me.BExcel.Location = New System.Drawing.Point(910, 175)
        Me.BExcel.Name = "BExcel"
        Me.BExcel.Size = New System.Drawing.Size(30, 30)
        Me.BExcel.TabIndex = 145
        Me.ToolTip1.SetToolTip(Me.BExcel, "Excel Export")
        Me.BExcel.UseVisualStyleBackColor = False
        '
        'Bfilter
        '
        Me.Bfilter.BackColor = System.Drawing.Color.White
        Me.Bfilter.FlatAppearance.BorderSize = 0
        Me.Bfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bfilter.Image = CType(resources.GetObject("Bfilter.Image"), System.Drawing.Image)
        Me.Bfilter.Location = New System.Drawing.Point(12, 101)
        Me.Bfilter.Name = "Bfilter"
        Me.Bfilter.Size = New System.Drawing.Size(30, 30)
        Me.Bfilter.TabIndex = 130
        Me.ToolTip1.SetToolTip(Me.Bfilter, "Filter")
        Me.Bfilter.UseVisualStyleBackColor = False
        '
        'CLBVTP
        '
        Me.CLBVTP.CheckOnClick = True
        Me.CLBVTP.FormattingEnabled = True
        Me.CLBVTP.Location = New System.Drawing.Point(740, 114)
        Me.CLBVTP.Name = "CLBVTP"
        Me.CLBVTP.Size = New System.Drawing.Size(140, 139)
        Me.CLBVTP.TabIndex = 147
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(796, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "VTP"
        '
        'BBacklog
        '
        Me.BBacklog.FlatAppearance.BorderSize = 0
        Me.BBacklog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBacklog.ForeColor = System.Drawing.Color.Black
        Me.BBacklog.Image = Global.WindowsApplication1.My.Resources.Resources.Backlog
        Me.BBacklog.Location = New System.Drawing.Point(1112, 109)
        Me.BBacklog.Name = "BBacklog"
        Me.BBacklog.Size = New System.Drawing.Size(25, 25)
        Me.BBacklog.TabIndex = 153
        Me.ToolTip1.SetToolTip(Me.BBacklog, "Customer Backlog")
        Me.BBacklog.UseVisualStyleBackColor = True
        '
        'FBacklog
        '
        Me.AccessibleDescription = ""
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1584, 809)
        Me.Controls.Add(Me.BBacklog)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CLBVTP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BExcel)
        Me.Controls.Add(Me.CBGcent)
        Me.Controls.Add(Me.CBClosed)
        Me.Controls.Add(Me.FilterRemove)
        Me.Controls.Add(Me.CLBFilterWorkstream)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CLBFilterAGroup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LB_NB)
        Me.Controls.Add(Me.CLBFilterPriority)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CLBFilterState)
        Me.Controls.Add(Me.LState)
        Me.Controls.Add(Me.Bfilter)
        Me.Controls.Add(Me.DGVBacklog)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBNbCases)
        Me.Controls.Add(Me.TBCus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FBacklog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backlog"
        CType(Me.DGVBacklog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBCus As System.Windows.Forms.TextBox
    Friend WithEvents TBNbCases As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGVBacklog As System.Windows.Forms.DataGridView
    Friend WithEvents Bfilter As System.Windows.Forms.Button
    Friend WithEvents LState As System.Windows.Forms.Label
    Friend WithEvents CLBFilterState As System.Windows.Forms.CheckedListBox
    Friend WithEvents CLBFilterPriority As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LB_NB As System.Windows.Forms.Label
    Friend WithEvents BS1 As System.Windows.Forms.BindingSource
    Friend WithEvents CLBFilterAGroup As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CLBFilterWorkstream As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FilterRemove As System.Windows.Forms.Button
    Friend WithEvents CBClosed As CheckBox
    Friend WithEvents CBGcent As CheckBox
    Friend WithEvents BExcel As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CLBVTP As CheckedListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents BBacklog As Button
End Class
