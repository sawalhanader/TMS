<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usersControl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.usersList = New System.Windows.Forms.ListView()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.delete = New System.Windows.Forms.Button()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.originalID = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.Role = New System.Windows.Forms.Label()
        Me.TXName = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.TXOffice = New System.Windows.Forms.TextBox()
        Me.Name = New System.Windows.Forms.Label()
        Me.Office = New System.Windows.Forms.Label()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.grpPermissions = New System.Windows.Forms.GroupBox()
        Me.grpARRPer = New System.Windows.Forms.GroupBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1272, 642)
        Me.SplitContainer1.SplitterDistance = 272
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.LinkLabel1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Search)
        Me.SplitContainer2.Panel1.Controls.Add(Me.SearchLabel)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.usersList)
        Me.SplitContainer2.Size = New System.Drawing.Size(272, 642)
        Me.SplitContainer2.SplitterDistance = 49
        Me.SplitContainer2.TabIndex = 3
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(163, 28)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(66, 16)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "New User"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(12, 25)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(145, 22)
        Me.Search.TabIndex = 1
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(12, 6)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(50, 16)
        Me.SearchLabel.TabIndex = 2
        Me.SearchLabel.Text = "Search"
        '
        'usersList
        '
        Me.usersList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.usersList.HideSelection = False
        Me.usersList.Location = New System.Drawing.Point(0, 0)
        Me.usersList.Name = "usersList"
        Me.usersList.Size = New System.Drawing.Size(272, 589)
        Me.usersList.TabIndex = 0
        Me.usersList.UseCompatibleStateImageBehavior = False
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.delete)
        Me.SplitContainer3.Panel1.Controls.Add(Me.TBID)
        Me.SplitContainer3.Panel1.Controls.Add(Me.originalID)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnLoad)
        Me.SplitContainer3.Panel1.Controls.Add(Me.cmbRole)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Role)
        Me.SplitContainer3.Panel1.Controls.Add(Me.TXName)
        Me.SplitContainer3.Panel1.Controls.Add(Me.ID)
        Me.SplitContainer3.Panel1.Controls.Add(Me.TXOffice)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Name)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Office)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Size = New System.Drawing.Size(996, 642)
        Me.SplitContainer3.SplitterDistance = 82
        Me.SplitContainer3.TabIndex = 2
        Me.SplitContainer3.Visible = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Red
        Me.delete.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.delete.ForeColor = System.Drawing.Color.White
        Me.delete.Location = New System.Drawing.Point(833, 19)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(151, 51)
        Me.delete.TabIndex = 61
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = False
        Me.delete.Visible = False
        '
        'TBID
        '
        Me.TBID.Location = New System.Drawing.Point(13, 38)
        Me.TBID.Name = "TBID"
        Me.TBID.Size = New System.Drawing.Size(100, 22)
        Me.TBID.TabIndex = 1
        '
        'originalID
        '
        Me.originalID.Location = New System.Drawing.Point(13, 38)
        Me.originalID.Name = "originalID"
        Me.originalID.Size = New System.Drawing.Size(10, 22)
        Me.originalID.TabIndex = 60
        Me.originalID.Visible = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLoad.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Location = New System.Drawing.Point(705, 19)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(122, 51)
        Me.btnLoad.TabIndex = 58
        Me.btnLoad.Text = "Save"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'cmbRole
        '
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(498, 38)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(121, 24)
        Me.cmbRole.TabIndex = 10
        '
        'Role
        '
        Me.Role.AutoSize = True
        Me.Role.Location = New System.Drawing.Point(495, 19)
        Me.Role.Name = "Role"
        Me.Role.Size = New System.Drawing.Size(36, 16)
        Me.Role.TabIndex = 9
        Me.Role.Text = "Role"
        '
        'TXName
        '
        Me.TXName.Location = New System.Drawing.Point(140, 38)
        Me.TXName.Name = "TXName"
        Me.TXName.Size = New System.Drawing.Size(226, 22)
        Me.TXName.TabIndex = 3
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(10, 18)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(20, 16)
        Me.ID.TabIndex = 0
        Me.ID.Text = "ID"
        '
        'TXOffice
        '
        Me.TXOffice.Location = New System.Drawing.Point(384, 38)
        Me.TXOffice.Name = "TXOffice"
        Me.TXOffice.Size = New System.Drawing.Size(95, 22)
        Me.TXOffice.TabIndex = 5
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(137, 18)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(44, 16)
        Me.Name.TabIndex = 2
        Me.Name.Text = "Name"
        '
        'Office
        '
        Me.Office.AutoSize = True
        Me.Office.Location = New System.Drawing.Point(381, 18)
        Me.Office.Name = "Office"
        Me.Office.Size = New System.Drawing.Size(41, 16)
        Me.Office.TabIndex = 4
        Me.Office.Text = "Office"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.grpPermissions)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.grpARRPer)
        Me.SplitContainer4.Size = New System.Drawing.Size(996, 556)
        Me.SplitContainer4.SplitterDistance = 452
        Me.SplitContainer4.TabIndex = 2
        '
        'grpPermissions
        '
        Me.grpPermissions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpPermissions.Location = New System.Drawing.Point(0, 0)
        Me.grpPermissions.Name = "grpPermissions"
        Me.grpPermissions.Size = New System.Drawing.Size(452, 556)
        Me.grpPermissions.TabIndex = 1
        Me.grpPermissions.TabStop = False
        Me.grpPermissions.Text = "Permissions"
        '
        'grpARRPer
        '
        Me.grpARRPer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpARRPer.Location = New System.Drawing.Point(0, 0)
        Me.grpARRPer.Name = "grpARRPer"
        Me.grpARRPer.Size = New System.Drawing.Size(540, 556)
        Me.grpARRPer.TabIndex = 0
        Me.grpARRPer.TabStop = False
        Me.grpARRPer.Text = "Arrivals Permissions"
        '
        'usersControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 642)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Text = "Users Control"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Search As TextBox
    Friend WithEvents usersList As ListView
    Friend WithEvents grpPermissions As GroupBox
    Friend WithEvents SearchLabel As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents Role As Label
    Friend WithEvents TXName As TextBox
    Friend WithEvents ID As Label
    Friend WithEvents TBID As TextBox
    Friend WithEvents TXOffice As TextBox
    Friend Shadows WithEvents Name As Label
    Friend WithEvents Office As Label
    Friend WithEvents btnLoad As Button
    Friend WithEvents originalID As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents delete As Button
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents grpARRPer As GroupBox
End Class
