﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCustomer))
        Me.TVCus = New System.Windows.Forms.TreeView()
        Me.TBCus = New System.Windows.Forms.TextBox()
        Me.TBFramework = New System.Windows.Forms.TextBox()
        Me.LBFramework = New System.Windows.Forms.Label()
        Me.LBURL = New System.Windows.Forms.Label()
        Me.TBFSpring = New System.Windows.Forms.TextBox()
        Me.LBFSpring = New System.Windows.Forms.Label()
        Me.TBOracle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBServer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBEnvType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBJava = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TBPVI = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BDB = New System.Windows.Forms.Button()
        Me.CBSchemas = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TBProduct = New System.Windows.Forms.TextBox()
        Me.LLBURL = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BBacklog = New System.Windows.Forms.Button()
        Me.TBLabel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBBranchType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBDesc = New System.Windows.Forms.TextBox()
        Me.LBDesc = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CBWorkstream = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BSearch = New System.Windows.Forms.Button()
        Me.CBRfe = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBRfe = New System.Windows.Forms.TextBox()
        Me.TBWs = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TVCus
        '
        Me.TVCus.Location = New System.Drawing.Point(19, 101)
        Me.TVCus.Name = "TVCus"
        Me.TVCus.Size = New System.Drawing.Size(325, 669)
        Me.TVCus.TabIndex = 0
        '
        'TBCus
        '
        Me.TBCus.BackColor = System.Drawing.Color.White
        Me.TBCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCus.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TBCus.Location = New System.Drawing.Point(19, 69)
        Me.TBCus.Name = "TBCus"
        Me.TBCus.ReadOnly = True
        Me.TBCus.Size = New System.Drawing.Size(325, 26)
        Me.TBCus.TabIndex = 1
        '
        'TBFramework
        '
        Me.TBFramework.Enabled = False
        Me.TBFramework.Location = New System.Drawing.Point(13, 35)
        Me.TBFramework.Name = "TBFramework"
        Me.TBFramework.Size = New System.Drawing.Size(300, 20)
        Me.TBFramework.TabIndex = 7
        '
        'LBFramework
        '
        Me.LBFramework.AutoSize = True
        Me.LBFramework.Location = New System.Drawing.Point(10, 20)
        Me.LBFramework.Name = "LBFramework"
        Me.LBFramework.Size = New System.Drawing.Size(59, 13)
        Me.LBFramework.TabIndex = 6
        Me.LBFramework.Text = "Framework"
        '
        'LBURL
        '
        Me.LBURL.AutoSize = True
        Me.LBURL.Location = New System.Drawing.Point(10, 140)
        Me.LBURL.Name = "LBURL"
        Me.LBURL.Size = New System.Drawing.Size(38, 13)
        Me.LBURL.TabIndex = 10
        Me.LBURL.Text = "URL : "
        '
        'TBFSpring
        '
        Me.TBFSpring.Location = New System.Drawing.Point(13, 75)
        Me.TBFSpring.Name = "TBFSpring"
        Me.TBFSpring.ReadOnly = True
        Me.TBFSpring.Size = New System.Drawing.Size(300, 20)
        Me.TBFSpring.TabIndex = 9
        '
        'LBFSpring
        '
        Me.LBFSpring.AutoSize = True
        Me.LBFSpring.Location = New System.Drawing.Point(10, 60)
        Me.LBFSpring.Name = "LBFSpring"
        Me.LBFSpring.Size = New System.Drawing.Size(92, 13)
        Me.LBFSpring.TabIndex = 8
        Me.LBFSpring.Text = "Framework Spring"
        '
        'TBOracle
        '
        Me.TBOracle.Location = New System.Drawing.Point(13, 115)
        Me.TBOracle.Name = "TBOracle"
        Me.TBOracle.ReadOnly = True
        Me.TBOracle.Size = New System.Drawing.Size(300, 20)
        Me.TBOracle.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Oracle"
        '
        'TBServer
        '
        Me.TBServer.Location = New System.Drawing.Point(13, 75)
        Me.TBServer.Name = "TBServer"
        Me.TBServer.ReadOnly = True
        Me.TBServer.Size = New System.Drawing.Size(269, 20)
        Me.TBServer.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Server"
        '
        'TBEnvType
        '
        Me.TBEnvType.Location = New System.Drawing.Point(13, 35)
        Me.TBEnvType.Name = "TBEnvType"
        Me.TBEnvType.ReadOnly = True
        Me.TBEnvType.Size = New System.Drawing.Size(300, 20)
        Me.TBEnvType.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Environment Type"
        '
        'TBJava
        '
        Me.TBJava.Location = New System.Drawing.Point(13, 155)
        Me.TBJava.Name = "TBJava"
        Me.TBJava.ReadOnly = True
        Me.TBJava.Size = New System.Drawing.Size(300, 20)
        Me.TBJava.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Java"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.TBPVI)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.BDB)
        Me.GroupBox2.Controls.Add(Me.CBSchemas)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TBJava)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TBOracle)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TBServer)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TBEnvType)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(358, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 264)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Environment Information"
        '
        'TBPVI
        '
        Me.TBPVI.Location = New System.Drawing.Point(13, 234)
        Me.TBPVI.Name = "TBPVI"
        Me.TBPVI.ReadOnly = True
        Me.TBPVI.Size = New System.Drawing.Size(300, 20)
        Me.TBPVI.TabIndex = 165
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(237, 13)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "Select a Schema : Last Product Version Installed"
        '
        'BDB
        '
        Me.BDB.FlatAppearance.BorderSize = 0
        Me.BDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BDB.ForeColor = System.Drawing.Color.Black
        Me.BDB.Image = Global.WindowsApplication1.My.Resources.Resources.database
        Me.BDB.Location = New System.Drawing.Point(288, 191)
        Me.BDB.Name = "BDB"
        Me.BDB.Size = New System.Drawing.Size(25, 25)
        Me.BDB.TabIndex = 162
        Me.ToolTip1.SetToolTip(Me.BDB, "Launch PL/SQL developper on the Schema selected")
        Me.BDB.UseVisualStyleBackColor = True
        '
        'CBSchemas
        '
        Me.CBSchemas.BackColor = System.Drawing.Color.White
        Me.CBSchemas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBSchemas.FormattingEnabled = True
        Me.CBSchemas.Location = New System.Drawing.Point(13, 195)
        Me.CBSchemas.Name = "CBSchemas"
        Me.CBSchemas.Size = New System.Drawing.Size(269, 21)
        Me.CBSchemas.TabIndex = 161
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.putty_dark_24
        Me.Button1.Location = New System.Drawing.Point(291, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.Button1, "Launch Putty on server")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 146
        Me.Label10.Text = "Oracle Schemas"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Controls.Add(Me.TBProduct)
        Me.GroupBox3.Controls.Add(Me.LLBURL)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.LBURL)
        Me.GroupBox3.Controls.Add(Me.TBFSpring)
        Me.GroupBox3.Controls.Add(Me.LBFSpring)
        Me.GroupBox3.Controls.Add(Me.TBFramework)
        Me.GroupBox3.Controls.Add(Me.LBFramework)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(358, 489)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(322, 160)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Application Information"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 143
        Me.Label8.Text = "Product"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(237, 140)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(45, 13)
        Me.LinkLabel1.TabIndex = 142
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Process"
        '
        'TBProduct
        '
        Me.TBProduct.Location = New System.Drawing.Point(13, 115)
        Me.TBProduct.Name = "TBProduct"
        Me.TBProduct.ReadOnly = True
        Me.TBProduct.Size = New System.Drawing.Size(300, 20)
        Me.TBProduct.TabIndex = 26
        '
        'LLBURL
        '
        Me.LLBURL.AutoSize = True
        Me.LLBURL.Location = New System.Drawing.Point(47, 140)
        Me.LLBURL.Name = "LLBURL"
        Me.LLBURL.Size = New System.Drawing.Size(27, 13)
        Me.LLBURL.TabIndex = 141
        Me.LLBURL.TabStop = True
        Me.LLBURL.Text = "Link"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Product"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.BBacklog)
        Me.GroupBox1.Controls.Add(Me.TBLabel)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TBBranchType)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBDesc)
        Me.GroupBox1.Controls.Add(Me.LBDesc)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(358, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 142)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Branch Information"
        '
        'BBacklog
        '
        Me.BBacklog.FlatAppearance.BorderSize = 0
        Me.BBacklog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBacklog.ForeColor = System.Drawing.Color.Black
        Me.BBacklog.Image = Global.WindowsApplication1.My.Resources.Resources.Backlog
        Me.BBacklog.Location = New System.Drawing.Point(288, 8)
        Me.BBacklog.Name = "BBacklog"
        Me.BBacklog.Size = New System.Drawing.Size(25, 25)
        Me.BBacklog.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.BBacklog, "Customer Backlog")
        Me.BBacklog.UseVisualStyleBackColor = True
        '
        'TBLabel
        '
        Me.TBLabel.Location = New System.Drawing.Point(13, 115)
        Me.TBLabel.Name = "TBLabel"
        Me.TBLabel.ReadOnly = True
        Me.TBLabel.Size = New System.Drawing.Size(300, 20)
        Me.TBLabel.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Label"
        '
        'TBBranchType
        '
        Me.TBBranchType.Location = New System.Drawing.Point(13, 75)
        Me.TBBranchType.Name = "TBBranchType"
        Me.TBBranchType.ReadOnly = True
        Me.TBBranchType.Size = New System.Drawing.Size(300, 20)
        Me.TBBranchType.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Type"
        '
        'TBDesc
        '
        Me.TBDesc.Location = New System.Drawing.Point(13, 35)
        Me.TBDesc.Name = "TBDesc"
        Me.TBDesc.ReadOnly = True
        Me.TBDesc.Size = New System.Drawing.Size(300, 20)
        Me.TBDesc.TabIndex = 3
        '
        'LBDesc
        '
        Me.LBDesc.AutoSize = True
        Me.LBDesc.Location = New System.Drawing.Point(10, 20)
        Me.LBDesc.Name = "LBDesc"
        Me.LBDesc.Size = New System.Drawing.Size(60, 13)
        Me.LBDesc.TabIndex = 2
        Me.LBDesc.Text = "Description"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.CBWorkstream)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.BSearch)
        Me.GroupBox4.Controls.Add(Me.CBRfe)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.TBRfe)
        Me.GroupBox4.Controls.Add(Me.TBWs)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(358, 655)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(322, 115)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "RFE && Workstream"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Window
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.search3_p
        Me.Button2.Location = New System.Drawing.Point(290, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(23, 25)
        Me.Button2.TabIndex = 164
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CBWorkstream
        '
        Me.CBWorkstream.BackColor = System.Drawing.Color.White
        Me.CBWorkstream.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBWorkstream.FormattingEnabled = True
        Me.CBWorkstream.Location = New System.Drawing.Point(13, 75)
        Me.CBWorkstream.Name = "CBWorkstream"
        Me.CBWorkstream.Size = New System.Drawing.Size(269, 21)
        Me.CBWorkstream.TabIndex = 163
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 162
        Me.Label9.Text = "Workstream"
        '
        'BSearch
        '
        Me.BSearch.BackColor = System.Drawing.SystemColors.Window
        Me.BSearch.FlatAppearance.BorderSize = 0
        Me.BSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSearch.Image = Global.WindowsApplication1.My.Resources.Resources.search3_p
        Me.BSearch.Location = New System.Drawing.Point(290, 33)
        Me.BSearch.Name = "BSearch"
        Me.BSearch.Size = New System.Drawing.Size(23, 25)
        Me.BSearch.TabIndex = 161
        Me.BSearch.UseVisualStyleBackColor = False
        '
        'CBRfe
        '
        Me.CBRfe.BackColor = System.Drawing.Color.White
        Me.CBRfe.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBRfe.FormattingEnabled = True
        Me.CBRfe.Location = New System.Drawing.Point(13, 35)
        Me.CBRfe.Name = "CBRfe"
        Me.CBRfe.Size = New System.Drawing.Size(269, 21)
        Me.CBRfe.TabIndex = 160
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "RFE"
        '
        'TBRfe
        '
        Me.TBRfe.Location = New System.Drawing.Point(109, 35)
        Me.TBRfe.Name = "TBRfe"
        Me.TBRfe.Size = New System.Drawing.Size(100, 20)
        Me.TBRfe.TabIndex = 165
        '
        'TBWs
        '
        Me.TBWs.Location = New System.Drawing.Point(151, 75)
        Me.TBWs.Name = "TBWs"
        Me.TBWs.Size = New System.Drawing.Size(100, 20)
        Me.TBWs.TabIndex = 166
        '
        'FCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(709, 780)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TBCus)
        Me.Controls.Add(Me.TVCus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Information"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TVCus As System.Windows.Forms.TreeView
    Friend WithEvents TBCus As System.Windows.Forms.TextBox
    Friend WithEvents TBFramework As System.Windows.Forms.TextBox
    Friend WithEvents LBFramework As System.Windows.Forms.Label
    Friend WithEvents LBURL As System.Windows.Forms.Label
    Friend WithEvents TBFSpring As System.Windows.Forms.TextBox
    Friend WithEvents LBFSpring As System.Windows.Forms.Label
    Friend WithEvents TBOracle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBServer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBEnvType As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBJava As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBDesc As System.Windows.Forms.Label
    Friend WithEvents TBDesc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBBranchType As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TBProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LLBURL As System.Windows.Forms.LinkLabel
    Friend WithEvents TBLabel As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BBacklog As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CBWorkstream As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BSearch As Button
    Friend WithEvents CBRfe As ComboBox
    Friend WithEvents TBRfe As TextBox
    Friend WithEvents TBWs As TextBox
    Friend WithEvents CBSchemas As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BDB As Button
    Friend WithEvents TBPVI As TextBox
    Friend WithEvents Label11 As Label
End Class
