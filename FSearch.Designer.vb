﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSearch))
        Me.MCBCusCase = New System.Windows.Forms.CheckBox()
        Me.MCBBranch = New System.Windows.Forms.CheckBox()
        Me.MSTSearch = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bminus = New System.Windows.Forms.Button()
        Me.BPlus = New System.Windows.Forms.Button()
        Me.MFBSearch = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MMCBCusCase = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MMCBBranch = New MaterialSkin.Controls.MaterialCheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BBack = New System.Windows.Forms.Button()
        Me.BNext = New System.Windows.Forms.Button()
        Me.Llong = New System.Windows.Forms.Label()
        Me.MCBTitle = New MaterialSkin.Controls.MaterialCheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MCB_RFE = New MaterialSkin.Controls.MaterialCheckBox()
        Me.SuspendLayout()
        '
        'MCBCusCase
        '
        Me.MCBCusCase.AutoSize = True
        Me.MCBCusCase.Location = New System.Drawing.Point(31, 141)
        Me.MCBCusCase.Name = "MCBCusCase"
        Me.MCBCusCase.Size = New System.Drawing.Size(174, 17)
        Me.MCBCusCase.TabIndex = 143
        Me.MCBCusCase.Text = "Search Customer Case Number"
        Me.MCBCusCase.UseVisualStyleBackColor = True
        '
        'MCBBranch
        '
        Me.MCBBranch.AutoSize = True
        Me.MCBBranch.Location = New System.Drawing.Point(31, 164)
        Me.MCBBranch.Name = "MCBBranch"
        Me.MCBBranch.Size = New System.Drawing.Size(199, 17)
        Me.MCBBranch.TabIndex = 144
        Me.MCBBranch.Text = "Search Customer/Branch/Env name"
        Me.MCBBranch.UseVisualStyleBackColor = True
        '
        'MSTSearch
        '
        Me.MSTSearch.Depth = 0
        Me.MSTSearch.Hint = ""
        Me.MSTSearch.Location = New System.Drawing.Point(31, 97)
        Me.MSTSearch.MaxLength = 32767
        Me.MSTSearch.MouseState = MaterialSkin.MouseState.HOVER
        Me.MSTSearch.Name = "MSTSearch"
        Me.MSTSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MSTSearch.SelectedText = ""
        Me.MSTSearch.SelectionLength = 0
        Me.MSTSearch.SelectionStart = 0
        Me.MSTSearch.Size = New System.Drawing.Size(179, 22)
        Me.MSTSearch.TabIndex = 0
        Me.MSTSearch.TabStop = False
        Me.MSTSearch.UseSystemPasswordChar = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.question_mark2
        Me.Button1.Location = New System.Drawing.Point(2, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(18, 18)
        Me.Button1.TabIndex = 150
        Me.ToolTip1.SetToolTip(Me.Button1, "About")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bminus
        '
        Me.Bminus.FlatAppearance.BorderSize = 0
        Me.Bminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bminus.Image = Global.WindowsApplication1.My.Resources.Resources.minus2
        Me.Bminus.Location = New System.Drawing.Point(1, 100)
        Me.Bminus.Name = "Bminus"
        Me.Bminus.Size = New System.Drawing.Size(16, 16)
        Me.Bminus.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Bminus, "Options panel -")
        Me.Bminus.UseVisualStyleBackColor = True
        Me.Bminus.Visible = False
        '
        'BPlus
        '
        Me.BPlus.FlatAppearance.BorderSize = 0
        Me.BPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BPlus.Image = Global.WindowsApplication1.My.Resources.Resources.plus
        Me.BPlus.Location = New System.Drawing.Point(1, 100)
        Me.BPlus.Name = "BPlus"
        Me.BPlus.Size = New System.Drawing.Size(16, 16)
        Me.BPlus.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BPlus, "Options panel")
        Me.BPlus.UseVisualStyleBackColor = True
        '
        'MFBSearch
        '
        Me.MFBSearch.AutoSize = True
        Me.MFBSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MFBSearch.Depth = 0
        Me.MFBSearch.Icon = Global.WindowsApplication1.My.Resources.Resources.search2
        Me.MFBSearch.Image = Global.WindowsApplication1.My.Resources.Resources.search2
        Me.MFBSearch.Location = New System.Drawing.Point(217, 83)
        Me.MFBSearch.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MFBSearch.MouseState = MaterialSkin.MouseState.HOVER
        Me.MFBSearch.Name = "MFBSearch"
        Me.MFBSearch.Primary = False
        Me.MFBSearch.Size = New System.Drawing.Size(44, 36)
        Me.MFBSearch.TabIndex = 149
        Me.ToolTip1.SetToolTip(Me.MFBSearch, "Search")
        Me.MFBSearch.UseVisualStyleBackColor = True
        '
        'MMCBCusCase
        '
        Me.MMCBCusCase.AutoSize = True
        Me.MMCBCusCase.Depth = 0
        Me.MMCBCusCase.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MMCBCusCase.Location = New System.Drawing.Point(10, 137)
        Me.MMCBCusCase.Margin = New System.Windows.Forms.Padding(0)
        Me.MMCBCusCase.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MMCBCusCase.MouseState = MaterialSkin.MouseState.HOVER
        Me.MMCBCusCase.Name = "MMCBCusCase"
        Me.MMCBCusCase.Ripple = True
        Me.MMCBCusCase.Size = New System.Drawing.Size(223, 30)
        Me.MMCBCusCase.TabIndex = 151
        Me.MMCBCusCase.Text = "Search Customer Case Number"
        Me.MMCBCusCase.UseVisualStyleBackColor = True
        '
        'MMCBBranch
        '
        Me.MMCBBranch.AutoSize = True
        Me.MMCBBranch.Depth = 0
        Me.MMCBBranch.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MMCBBranch.Location = New System.Drawing.Point(10, 162)
        Me.MMCBBranch.Margin = New System.Windows.Forms.Padding(0)
        Me.MMCBBranch.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MMCBBranch.MouseState = MaterialSkin.MouseState.HOVER
        Me.MMCBBranch.Name = "MMCBBranch"
        Me.MMCBBranch.Ripple = True
        Me.MMCBBranch.Size = New System.Drawing.Size(251, 30)
        Me.MMCBBranch.TabIndex = 153
        Me.MMCBBranch.Text = "Search Customer/Branch/Env name"
        Me.MMCBBranch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 16)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "CARD/CASE/CUSTOMER"
        '
        'BBack
        '
        Me.BBack.BackColor = System.Drawing.Color.White
        Me.BBack.FlatAppearance.BorderSize = 0
        Me.BBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBack.ForeColor = System.Drawing.SystemColors.Window
        Me.BBack.Image = Global.WindowsApplication1.My.Resources.Resources.backS
        Me.BBack.Location = New System.Drawing.Point(211, 57)
        Me.BBack.Name = "BBack"
        Me.BBack.Size = New System.Drawing.Size(25, 25)
        Me.BBack.TabIndex = 158
        Me.ToolTip1.SetToolTip(Me.BBack, "Previous search")
        Me.BBack.UseVisualStyleBackColor = False
        '
        'BNext
        '
        Me.BNext.BackColor = System.Drawing.Color.White
        Me.BNext.FlatAppearance.BorderSize = 0
        Me.BNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BNext.ForeColor = System.Drawing.SystemColors.Window
        Me.BNext.Image = Global.WindowsApplication1.My.Resources.Resources.nextS
        Me.BNext.Location = New System.Drawing.Point(242, 57)
        Me.BNext.Name = "BNext"
        Me.BNext.Size = New System.Drawing.Size(25, 25)
        Me.BNext.TabIndex = 159
        Me.ToolTip1.SetToolTip(Me.BNext, "Next search")
        Me.BNext.UseVisualStyleBackColor = False
        '
        'Llong
        '
        Me.Llong.AutoSize = True
        Me.Llong.Location = New System.Drawing.Point(145, 90)
        Me.Llong.Name = "Llong"
        Me.Llong.Size = New System.Drawing.Size(0, 13)
        Me.Llong.TabIndex = 160
        Me.Llong.Visible = False
        '
        'MCBTitle
        '
        Me.MCBTitle.AutoSize = True
        Me.MCBTitle.Depth = 0
        Me.MCBTitle.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MCBTitle.Location = New System.Drawing.Point(10, 187)
        Me.MCBTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.MCBTitle.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MCBTitle.MouseState = MaterialSkin.MouseState.HOVER
        Me.MCBTitle.Name = "MCBTitle"
        Me.MCBTitle.Ripple = True
        Me.MCBTitle.Size = New System.Drawing.Size(182, 30)
        Me.MCBTitle.TabIndex = 161
        Me.MCBTitle.Text = "Search by content in title"
        Me.MCBTitle.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(229, 33)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(29, 13)
        Me.LinkLabel1.TabIndex = 162
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Tag = ""
        Me.LinkLabel1.Text = "Help"
        '
        'MCB_RFE
        '
        Me.MCB_RFE.AutoSize = True
        Me.MCB_RFE.Depth = 0
        Me.MCB_RFE.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MCB_RFE.Location = New System.Drawing.Point(10, 212)
        Me.MCB_RFE.Margin = New System.Windows.Forms.Padding(0)
        Me.MCB_RFE.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MCB_RFE.MouseState = MaterialSkin.MouseState.HOVER
        Me.MCB_RFE.Name = "MCB_RFE"
        Me.MCB_RFE.Ripple = True
        Me.MCB_RFE.Size = New System.Drawing.Size(118, 30)
        Me.MCB_RFE.TabIndex = 163
        Me.MCB_RFE.Text = "Search by RFE"
        Me.MCB_RFE.UseVisualStyleBackColor = True
        '
        'FSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(270, 135)
        Me.Controls.Add(Me.MCB_RFE)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.MCBTitle)
        Me.Controls.Add(Me.Llong)
        Me.Controls.Add(Me.BNext)
        Me.Controls.Add(Me.BBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MMCBBranch)
        Me.Controls.Add(Me.MMCBCusCase)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bminus)
        Me.Controls.Add(Me.BPlus)
        Me.Controls.Add(Me.MFBSearch)
        Me.Controls.Add(Me.MSTSearch)
        Me.Controls.Add(Me.MCBBranch)
        Me.Controls.Add(Me.MCBCusCase)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Search"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MCBCusCase As CheckBox
    Friend WithEvents MCBBranch As CheckBox
    Friend WithEvents MSTSearch As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MFBSearch As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents BPlus As Button
    Friend WithEvents Bminus As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MMCBCusCase As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MMCBBranch As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BBack As Button
    Friend WithEvents BNext As Button
    Friend WithEvents Llong As Label
    Friend WithEvents MCBTitle As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents MCB_RFE As MaterialSkin.Controls.MaterialCheckBox
End Class
