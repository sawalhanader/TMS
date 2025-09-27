<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Me.components = New System.ComponentModel.Container()
        Dim lblNoData As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search & Change")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add New")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Crew", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search & Change")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add New")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ground Staff", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search & Change")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add New")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drivers", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Records")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Report")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("KM Report", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11})
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMNDataSet2 = New TMS.CMNDataSet2()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrewsBYAreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasternAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WesternAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllAreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.arabic = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.tt2 = New System.Windows.Forms.TabControl()
        Me.rosterTab = New System.Windows.Forms.TabPage()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BottomLabel = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip7 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.صعودونزولToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.نزولToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.صعودToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALONEBYEMAILToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.D1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.groundStaffTab = New System.Windows.Forms.TabPage()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MenuStrip5 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.CANCELONCALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.NoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ShifteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EarlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EarlyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegularToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EarlyToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegularToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip6 = New System.Windows.Forms.MenuStrip()
        Me.AloneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.D2 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.cgsTab = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.ComboBox13 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.TextBox44 = New System.Windows.Forms.TextBox()
        Me.TextBox45 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.driverLinkTab = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView9 = New System.Windows.Forms.DataGridView()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.TextBox39 = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.D3 = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.arrivalsRjTab = New System.Windows.Forms.TabPage()
        Me.WebView22 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.ArrivalsTab = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton21 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton22 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton23 = New System.Windows.Forms.ToolStripButton()
        Me.notesTab = New System.Windows.Forms.TabPage()
        Me.dgvCalendar = New System.Windows.Forms.DataGridView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmbMonth = New System.Windows.Forms.ToolStripComboBox()
        Me.cmbYear = New System.Windows.Forms.ToolStripComboBox()
        Me.ordersTab = New System.Windows.Forms.TabPage()
        Me.WebView23 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.createRosterTab = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.FleetTeastBtn = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.RESTORBTN = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.btnroster = New System.Windows.Forms.Button()
        Me.txtfleetwatch = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblroster = New System.Windows.Forms.Label()
        Me.lblfleetwatch = New System.Windows.Forms.Label()
        Me.testtext = New System.Windows.Forms.TextBox()
        Me.txtroster = New System.Windows.Forms.TextBox()
        Me.kmRreportTab = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.KMReports = New System.Windows.Forms.GroupBox()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.cmbReports = New System.Windows.Forms.ComboBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.dtpto = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.orderRecords = New System.Windows.Forms.GroupBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.chkSpecial = New System.Windows.Forms.CheckBox()
        Me.chkGroundStaff = New System.Windows.Forms.CheckBox()
        Me.chkDriver = New System.Windows.Forms.CheckBox()
        Me.txtendKm = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.txtStartKm = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cmbDriver = New System.Windows.Forms.ComboBox()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtBusNo = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtOrderId = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.reportsTab = New System.Windows.Forms.TabPage()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblDateOnly = New System.Windows.Forms.Label()
        Me.txtDateOnly = New System.Windows.Forms.DateTimePicker()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cmbArea = New System.Windows.Forms.ComboBox()
        Me.lbltoDate = New System.Windows.Forms.Label()
        Me.txtToDate = New System.Windows.Forms.DateTimePicker()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.txtFromDate = New System.Windows.Forms.DateTimePicker()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.lblKeyword = New System.Windows.Forms.Label()
        Me.cmbreportType = New System.Windows.Forms.ComboBox()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataGridView8 = New System.Windows.Forms.DataGridView()
        Me.Column13 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.TextBox42 = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.TextBox40 = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.D9 = New System.Windows.Forms.DataGridView()
        Me.Column32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel10 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel12 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel11 = New System.Windows.Forms.LinkLabel()
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.Column11 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMNDataSet11 = New TMS.CMNDataSet1()
        Me.CMNDataSet = New TMS.CMNDataSet()
        Me.CMNDataSet1 = New TMS.CMNDataSet()
        Me.BusTableAdapter = New TMS.CMNDataSetTableAdapters.busTableAdapter()
        Me.DriverTableAdapter = New TMS.CMNDataSetTableAdapters.DriverTableAdapter()
        Me.GSTableAdapter = New TMS.CMNDataSetTableAdapters.GSTableAdapter()
        Me.BusTableAdapter1 = New TMS.CMNDataSet1TableAdapters.busTableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmsTableAdapter = New TMS.CMNDataSet2TableAdapters.smsTableAdapter()
        Me.DriverTableAdapter1 = New TMS.CMNDataSet2TableAdapters.DriverTableAdapter()
        Me.BusTableAdapter2 = New TMS.CMNDataSet2TableAdapters.busTableAdapter()
        Me.BindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me._هواتف_عربي___ImportErrorsTableAdapter1 = New TMS.CMNDataSet2TableAdapters._هواتف_عربي___ImportErrorsTableAdapter()
        Me.BusTableAdapter3 = New TMS.CMNDataSet1TableAdapters.busTableAdapter()
        Me.BindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMN3DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        lblNoData = New System.Windows.Forms.Label()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMNDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.tt2.SuspendLayout()
        Me.rosterTab.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.D1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.groundStaffTab.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.MenuStrip5.SuspendLayout()
        Me.MenuStrip4.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.MenuStrip6.SuspendLayout()
        CType(Me.D2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.cgsTab.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.driverLinkTab.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.arrivalsRjTab.SuspendLayout()
        CType(Me.WebView22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ArrivalsTab.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip5.SuspendLayout()
        Me.notesTab.SuspendLayout()
        CType(Me.dgvCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.ordersTab.SuspendLayout()
        CType(Me.WebView23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.createRosterTab.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.kmRreportTab.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.KMReports.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.orderRecords.SuspendLayout()
        Me.reportsTab.SuspendLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMNDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMNDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMN3DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNoData
        '
        lblNoData.AutoSize = True
        lblNoData.ForeColor = System.Drawing.Color.Red
        lblNoData.Location = New System.Drawing.Point(215, 76)
        lblNoData.Name = "lblNoData"
        lblNoData.Size = New System.Drawing.Size(57, 16)
        lblNoData.TabIndex = 5
        lblNoData.Text = "No Data"
        lblNoData.Visible = False
        '
        'BindingSource4
        '
        Me.BindingSource4.DataMember = "bus"
        Me.BindingSource4.DataSource = Me.BindingSource3
        '
        'BindingSource3
        '
        Me.BindingSource3.DataSource = Me.CMNDataSet2
        Me.BindingSource3.Position = 0
        '
        'CMNDataSet2
        '
        Me.CMNDataSet2.DataSetName = "CMNDataSet2"
        Me.CMNDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.MenuStrip1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel9)
        Me.SplitContainer2.Size = New System.Drawing.Size(1221, 752)
        Me.SplitContainer2.SplitterDistance = 25
        Me.SplitContainer2.SplitterWidth = 5
        Me.SplitContainer2.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem, Me.arabic, Me.UPDATEToolStripMenuItem, Me.Refresh})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1221, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrewsBYAreasToolStripMenuItem, Me.UsersManagementToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'CrewsBYAreasToolStripMenuItem
        '
        Me.CrewsBYAreasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasternAreaToolStripMenuItem, Me.WesternAreaToolStripMenuItem, Me.AllAreasToolStripMenuItem})
        Me.CrewsBYAreasToolStripMenuItem.Name = "CrewsBYAreasToolStripMenuItem"
        Me.CrewsBYAreasToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.CrewsBYAreasToolStripMenuItem.Text = "Crews BY Areas"
        '
        'EasternAreaToolStripMenuItem
        '
        Me.EasternAreaToolStripMenuItem.Name = "EasternAreaToolStripMenuItem"
        Me.EasternAreaToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.EasternAreaToolStripMenuItem.Text = "Eastern Area (الشرقي)"
        '
        'WesternAreaToolStripMenuItem
        '
        Me.WesternAreaToolStripMenuItem.Name = "WesternAreaToolStripMenuItem"
        Me.WesternAreaToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.WesternAreaToolStripMenuItem.Text = "Western Area (الغربي)"
        '
        'AllAreasToolStripMenuItem
        '
        Me.AllAreasToolStripMenuItem.Name = "AllAreasToolStripMenuItem"
        Me.AllAreasToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.AllAreasToolStripMenuItem.Text = "All Areas (جميع المناطق)"
        '
        'UsersManagementToolStripMenuItem
        '
        Me.UsersManagementToolStripMenuItem.Name = "UsersManagementToolStripMenuItem"
        Me.UsersManagementToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.UsersManagementToolStripMenuItem.Text = "Users Management"
        Me.UsersManagementToolStripMenuItem.Visible = False
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(478, 26)
        Me.AboutToolStripMenuItem.Text = "&Administration And Support Services Management System"
        '
        'arabic
        '
        Me.arabic.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.arabic.Name = "arabic"
        Me.arabic.Size = New System.Drawing.Size(56, 24)
        Me.arabic.Text = "عربي"
        '
        'UPDATEToolStripMenuItem
        '
        Me.UPDATEToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.UPDATEToolStripMenuItem.Name = "UPDATEToolStripMenuItem"
        Me.UPDATEToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.UPDATEToolStripMenuItem.Text = "UPDATE"
        '
        'Refresh
        '
        Me.Refresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(72, 24)
        Me.Refresh.Text = "Refresh"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.tt2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1221, 722)
        Me.Panel9.TabIndex = 3
        '
        'tt2
        '
        Me.tt2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tt2.Controls.Add(Me.rosterTab)
        Me.tt2.Controls.Add(Me.groundStaffTab)
        Me.tt2.Controls.Add(Me.cgsTab)
        Me.tt2.Controls.Add(Me.driverLinkTab)
        Me.tt2.Controls.Add(Me.arrivalsRjTab)
        Me.tt2.Controls.Add(Me.ArrivalsTab)
        Me.tt2.Controls.Add(Me.notesTab)
        Me.tt2.Controls.Add(Me.ordersTab)
        Me.tt2.Controls.Add(Me.createRosterTab)
        Me.tt2.Controls.Add(Me.kmRreportTab)
        Me.tt2.Controls.Add(Me.reportsTab)
        Me.tt2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tt2.Location = New System.Drawing.Point(0, 0)
        Me.tt2.Margin = New System.Windows.Forms.Padding(4)
        Me.tt2.Name = "tt2"
        Me.tt2.Padding = New System.Drawing.Point(3, 3)
        Me.tt2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tt2.RightToLeftLayout = True
        Me.tt2.SelectedIndex = 0
        Me.tt2.Size = New System.Drawing.Size(1221, 722)
        Me.tt2.TabIndex = 0
        '
        'rosterTab
        '
        Me.rosterTab.Controls.Add(Me.DateTimePicker2)
        Me.rosterTab.Controls.Add(Me.GroupBox15)
        Me.rosterTab.Controls.Add(Me.Label11)
        Me.rosterTab.Controls.Add(Me.GroupBox1)
        Me.rosterTab.Controls.Add(Me.ToolStrip1)
        Me.rosterTab.Location = New System.Drawing.Point(4, 28)
        Me.rosterTab.Margin = New System.Windows.Forms.Padding(4)
        Me.rosterTab.Name = "rosterTab"
        Me.rosterTab.Padding = New System.Windows.Forms.Padding(4)
        Me.rosterTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rosterTab.Size = New System.Drawing.Size(1213, 690)
        Me.rosterTab.TabIndex = 0
        Me.rosterTab.Text = "Roster"
        Me.rosterTab.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(740, 10)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker2.TabIndex = 13
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.Panel7)
        Me.GroupBox15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox15.Location = New System.Drawing.Point(4, 647)
        Me.GroupBox15.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox15.Size = New System.Drawing.Size(1205, 39)
        Me.GroupBox15.TabIndex = 3
        Me.GroupBox15.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.BottomLabel)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 15)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1205, 24)
        Me.Panel7.TabIndex = 0
        '
        'BottomLabel
        '
        Me.BottomLabel.BackColor = System.Drawing.Color.White
        Me.BottomLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BottomLabel.Cursor = System.Windows.Forms.Cursors.No
        Me.BottomLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottomLabel.ForeColor = System.Drawing.Color.Tomato
        Me.BottomLabel.Location = New System.Drawing.Point(0, 0)
        Me.BottomLabel.Multiline = False
        Me.BottomLabel.Name = "BottomLabel"
        Me.BottomLabel.ReadOnly = True
        Me.BottomLabel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.BottomLabel.Size = New System.Drawing.Size(1205, 24)
        Me.BottomLabel.TabIndex = 0
        Me.BottomLabel.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(472, 25)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.D1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(4, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 39)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(1205, 655)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Roster"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.MenuStrip7)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(0, 347)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(147, 180)
        Me.Panel2.TabIndex = 2
        Me.Panel2.Visible = False
        '
        'MenuStrip7
        '
        Me.MenuStrip7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip7.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.MenuStrip7.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip7.Name = "MenuStrip7"
        Me.MenuStrip7.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip7.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip7.Size = New System.Drawing.Size(145, 28)
        Me.MenuStrip7.TabIndex = 10
        Me.MenuStrip7.Text = "ALONE"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem7, Me.ALONEBYEMAILToolStripMenuItem})
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(105, 24)
        Me.ToolStripMenuItem3.Text = "    Alone    "
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem8})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.ShowShortcutKeys = False
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(231, 26)
        Me.ToolStripMenuItem4.Text = "ALONE BY SMS"
        Me.ToolStripMenuItem4.Visible = False
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(214, 26)
        Me.ToolStripMenuItem5.Text = "Pickup & Drop-off"
        Me.ToolStripMenuItem5.ToolTipText = "Pickup & Drop-off"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(214, 26)
        Me.ToolStripMenuItem6.Text = "Drop-off"
        Me.ToolStripMenuItem6.ToolTipText = "Drop-off"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(214, 26)
        Me.ToolStripMenuItem8.Text = "Pickup"
        Me.ToolStripMenuItem8.ToolTipText = "Pickup"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.صعودونزولToolStripMenuItem, Me.نزولToolStripMenuItem, Me.صعودToolStripMenuItem})
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(231, 26)
        Me.ToolStripMenuItem7.Text = "ALONE BY CALL"
        '
        'صعودونزولToolStripMenuItem
        '
        Me.صعودونزولToolStripMenuItem.Name = "صعودونزولToolStripMenuItem"
        Me.صعودونزولToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.صعودونزولToolStripMenuItem.Text = "Pickup & Drop-off"
        '
        'نزولToolStripMenuItem
        '
        Me.نزولToolStripMenuItem.Name = "نزولToolStripMenuItem"
        Me.نزولToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.نزولToolStripMenuItem.Text = "Drop-off"
        '
        'صعودToolStripMenuItem
        '
        Me.صعودToolStripMenuItem.Name = "صعودToolStripMenuItem"
        Me.صعودToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.صعودToolStripMenuItem.Text = "Pickup"
        '
        'ALONEBYEMAILToolStripMenuItem
        '
        Me.ALONEBYEMAILToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11})
        Me.ALONEBYEMAILToolStripMenuItem.Name = "ALONEBYEMAILToolStripMenuItem"
        Me.ALONEBYEMAILToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.ALONEBYEMAILToolStripMenuItem.Text = "ALONE BY EMAIL"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(214, 26)
        Me.ToolStripMenuItem9.Text = "Pickup & Drop-off"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(214, 26)
        Me.ToolStripMenuItem10.Text = "Drop-off"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(214, 26)
        Me.ToolStripMenuItem11.Text = "Pickup"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(27, 149)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 20)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Add Flight"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(28, 76)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 20)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Switched"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(4, 123)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(118, 20)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Cancel on Call"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 100)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 20)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "    No Show    "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1, 31)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 20)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "       Delete      "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(-1, 53)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "        Insert       "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 19)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1197, 597)
        Me.Panel1.TabIndex = 1
        Me.Panel1.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(251, 594)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(641, 21)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Copyright RJ - Transportation (2013-2025)  Developed By Nader Sawalha"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label15.Visible = False
        '
        'D1
        '
        Me.D1.AllowUserToAddRows = False
        Me.D1.AllowUserToDeleteRows = False
        Me.D1.AllowUserToResizeColumns = False
        Me.D1.AllowUserToResizeRows = False
        Me.D1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.D1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.D1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.D1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.D1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.D1.Location = New System.Drawing.Point(4, 19)
        Me.D1.Margin = New System.Windows.Forms.Padding(4)
        Me.D1.MultiSelect = False
        Me.D1.Name = "D1"
        Me.D1.RowHeadersVisible = False
        Me.D1.RowHeadersWidth = 51
        Me.D1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.D1.ShowEditingIcon = False
        Me.D1.ShowRowErrors = False
        Me.D1.Size = New System.Drawing.Size(1197, 597)
        Me.D1.StandardTab = True
        Me.D1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripButton, Me.ToolStripSeparator3, Me.ToolStripTextBox1, Me.ToolStripButton1, Me.ToolStripSeparator4, Me.ToolStripButton2, Me.ToolStripLabel1, Me.ToolStripButton3, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1.Size = New System.Drawing.Size(1205, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(265, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(85, 24)
        Me.ToolStripButton1.Text = "Search"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton2.Text = "-"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Enabled = False
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(137, 24)
        Me.ToolStripLabel1.Text = "                                "
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton3.Text = "+"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(92, 24)
        Me.ToolStripButton6.Text = "Load Roster"
        '
        'groundStaffTab
        '
        Me.groundStaffTab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.groundStaffTab.Controls.Add(Me.DateTimePicker1)
        Me.groundStaffTab.Controls.Add(Me.GroupBox6)
        Me.groundStaffTab.Controls.Add(Me.ToolStrip2)
        Me.groundStaffTab.Location = New System.Drawing.Point(4, 28)
        Me.groundStaffTab.Margin = New System.Windows.Forms.Padding(4)
        Me.groundStaffTab.Name = "groundStaffTab"
        Me.groundStaffTab.Padding = New System.Windows.Forms.Padding(4)
        Me.groundStaffTab.Size = New System.Drawing.Size(1213, 690)
        Me.groundStaffTab.TabIndex = 5
        Me.groundStaffTab.Text = "Ground Staff"
        Me.groundStaffTab.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(383, 7)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker1.TabIndex = 12
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox6.Controls.Add(Me.Panel4)
        Me.GroupBox6.Controls.Add(Me.D2)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(4, 32)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(1205, 654)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "G-S"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(265, 6)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 6
        Me.MonthCalendar1.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.MenuStrip5)
        Me.Panel4.Controls.Add(Me.MenuStrip4)
        Me.Panel4.Controls.Add(Me.MenuStrip3)
        Me.Panel4.Controls.Add(Me.MenuStrip2)
        Me.Panel4.Controls.Add(Me.MenuStrip6)
        Me.Panel4.Location = New System.Drawing.Point(407, 212)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 146)
        Me.Panel4.TabIndex = 4
        Me.Panel4.Visible = False
        '
        'MenuStrip5
        '
        Me.MenuStrip5.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuStrip5.Location = New System.Drawing.Point(0, 84)
        Me.MenuStrip5.Name = "MenuStrip5"
        Me.MenuStrip5.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip5.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip5.Size = New System.Drawing.Size(208, 28)
        Me.MenuStrip5.TabIndex = 11
        Me.MenuStrip5.Text = "MenuStrip5"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(151, 24)
        Me.ToolStripMenuItem2.Text = "         Delete            "
        '
        'MenuStrip4
        '
        Me.MenuStrip4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CANCELONCALLToolStripMenuItem})
        Me.MenuStrip4.Location = New System.Drawing.Point(0, 56)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip4.Size = New System.Drawing.Size(208, 28)
        Me.MenuStrip4.TabIndex = 8
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'CANCELONCALLToolStripMenuItem
        '
        Me.CANCELONCALLToolStripMenuItem.Name = "CANCELONCALLToolStripMenuItem"
        Me.CANCELONCALLToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.CANCELONCALLToolStripMenuItem.Text = " CANCEL ON CALL  "
        '
        'MenuStrip3
        '
        Me.MenuStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 28)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip3.Size = New System.Drawing.Size(208, 28)
        Me.MenuStrip3.TabIndex = 7
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'NoToolStripMenuItem
        '
        Me.NoToolStripMenuItem.Name = "NoToolStripMenuItem"
        Me.NoToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.NoToolStripMenuItem.Text = "       NO SHOW        "
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShifteToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 116)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip2.Size = New System.Drawing.Size(208, 28)
        Me.MenuStrip2.TabIndex = 6
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ShifteToolStripMenuItem
        '
        Me.ShifteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.BToolStripMenuItem, Me.CToolStripMenuItem})
        Me.ShifteToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ShifteToolStripMenuItem.Name = "ShifteToolStripMenuItem"
        Me.ShifteToolStripMenuItem.Size = New System.Drawing.Size(137, 24)
        Me.ShifteToolStripMenuItem.Text = "       Shift         "
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EarlyToolStripMenuItem, Me.RegularToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShowShortcutKeys = False
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(104, 26)
        Me.ToolStripMenuItem1.Text = "A"
        '
        'EarlyToolStripMenuItem
        '
        Me.EarlyToolStripMenuItem.Name = "EarlyToolStripMenuItem"
        Me.EarlyToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.EarlyToolStripMenuItem.Text = "Early"
        '
        'RegularToolStripMenuItem
        '
        Me.RegularToolStripMenuItem.Name = "RegularToolStripMenuItem"
        Me.RegularToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.RegularToolStripMenuItem.Text = "Regular"
        '
        'BToolStripMenuItem
        '
        Me.BToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EarlyToolStripMenuItem1, Me.RegularToolStripMenuItem1})
        Me.BToolStripMenuItem.Name = "BToolStripMenuItem"
        Me.BToolStripMenuItem.Size = New System.Drawing.Size(104, 26)
        Me.BToolStripMenuItem.Text = "B"
        '
        'EarlyToolStripMenuItem1
        '
        Me.EarlyToolStripMenuItem1.Name = "EarlyToolStripMenuItem1"
        Me.EarlyToolStripMenuItem1.Size = New System.Drawing.Size(150, 26)
        Me.EarlyToolStripMenuItem1.Text = "Early"
        '
        'RegularToolStripMenuItem1
        '
        Me.RegularToolStripMenuItem1.Name = "RegularToolStripMenuItem1"
        Me.RegularToolStripMenuItem1.Size = New System.Drawing.Size(150, 26)
        Me.RegularToolStripMenuItem1.Text = "Regular"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EarlyToolStripMenuItem2, Me.RegularToolStripMenuItem2})
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(104, 26)
        Me.CToolStripMenuItem.Text = "C"
        '
        'EarlyToolStripMenuItem2
        '
        Me.EarlyToolStripMenuItem2.Name = "EarlyToolStripMenuItem2"
        Me.EarlyToolStripMenuItem2.Size = New System.Drawing.Size(150, 26)
        Me.EarlyToolStripMenuItem2.Text = "Early"
        '
        'RegularToolStripMenuItem2
        '
        Me.RegularToolStripMenuItem2.Name = "RegularToolStripMenuItem2"
        Me.RegularToolStripMenuItem2.Size = New System.Drawing.Size(150, 26)
        Me.RegularToolStripMenuItem2.Text = "Regular"
        '
        'MenuStrip6
        '
        Me.MenuStrip6.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AloneToolStripMenuItem})
        Me.MenuStrip6.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip6.Name = "MenuStrip6"
        Me.MenuStrip6.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip6.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip6.Size = New System.Drawing.Size(208, 28)
        Me.MenuStrip6.TabIndex = 10
        Me.MenuStrip6.Text = "Alone"
        '
        'AloneToolStripMenuItem
        '
        Me.AloneToolStripMenuItem.Checked = True
        Me.AloneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AloneToolStripMenuItem.Name = "AloneToolStripMenuItem"
        Me.AloneToolStripMenuItem.Size = New System.Drawing.Size(150, 24)
        Me.AloneToolStripMenuItem.Text = "         Alone             "
        '
        'D2
        '
        Me.D2.AllowUserToResizeColumns = False
        Me.D2.AllowUserToResizeRows = False
        Me.D2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.D2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.D2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.D2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.D2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.D2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.D2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.D2.GridColor = System.Drawing.Color.WhiteSmoke
        Me.D2.Location = New System.Drawing.Point(4, 19)
        Me.D2.Margin = New System.Windows.Forms.Padding(4)
        Me.D2.MultiSelect = False
        Me.D2.Name = "D2"
        Me.D2.RowHeadersVisible = False
        Me.D2.RowHeadersWidth = 51
        Me.D2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.D2.ShowEditingIcon = False
        Me.D2.Size = New System.Drawing.Size(1197, 631)
        Me.D2.TabIndex = 1
        Me.D2.TabStop = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.ToolStripComboBox1, Me.ToolStripButton8, Me.ToolStripLabel2, Me.ToolStripButton7})
        Me.ToolStrip2.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip2.Size = New System.Drawing.Size(1205, 28)
        Me.ToolStrip2.Stretch = True
        Me.ToolStrip2.TabIndex = 10
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 28)
        Me.ToolStripSeparator6.Visible = False
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"All", "Morrning & Early Morrning", "Evening &  Early Evening", "Night & Early Nigh"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(160, 28)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(29, 25)
        Me.ToolStripButton8.Text = "-"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.BackColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Enabled = False
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(137, 25)
        Me.ToolStripLabel2.Text = "                                "
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(29, 25)
        Me.ToolStripButton7.Text = "+"
        '
        'cgsTab
        '
        Me.cgsTab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cgsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cgsTab.Controls.Add(Me.SplitContainer1)
        Me.cgsTab.Location = New System.Drawing.Point(4, 28)
        Me.cgsTab.Margin = New System.Windows.Forms.Padding(4)
        Me.cgsTab.Name = "cgsTab"
        Me.cgsTab.Padding = New System.Windows.Forms.Padding(4)
        Me.cgsTab.Size = New System.Drawing.Size(1213, 690)
        Me.cgsTab.TabIndex = 1
        Me.cgsTab.Text = "Crew & Ground Staff Modification"
        Me.cgsTab.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox16)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Size = New System.Drawing.Size(1205, 682)
        Me.SplitContainer1.SplitterDistance = 187
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 7
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(4)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node7"
        TreeNode1.Text = "Search & Change"
        TreeNode2.Name = "Node8"
        TreeNode2.Text = "Add New"
        TreeNode3.Name = "Crew"
        TreeNode3.Text = "Crew"
        TreeNode4.Name = "Node14"
        TreeNode4.Text = "Search & Change"
        TreeNode5.Name = "Node1"
        TreeNode5.Text = "Add New"
        TreeNode6.Name = "GS"
        TreeNode6.Text = "Ground Staff"
        TreeNode7.Name = "Node1"
        TreeNode7.Text = "Search & Change"
        TreeNode8.Name = "Node2"
        TreeNode8.Text = "Add New"
        TreeNode9.Name = "d"
        TreeNode9.Text = "Drivers"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6, TreeNode9})
        Me.TreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TreeView1.RightToLeftLayout = True
        Me.TreeView1.Size = New System.Drawing.Size(187, 682)
        Me.TreeView1.TabIndex = 7
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.Label76)
        Me.GroupBox16.Controls.Add(Me.ComboBox13)
        Me.GroupBox16.Controls.Add(Me.Button6)
        Me.GroupBox16.Controls.Add(Me.Label77)
        Me.GroupBox16.Controls.Add(Me.Label79)
        Me.GroupBox16.Controls.Add(Me.Button7)
        Me.GroupBox16.Controls.Add(Me.Label81)
        Me.GroupBox16.Controls.Add(Me.Label82)
        Me.GroupBox16.Controls.Add(Me.TextBox44)
        Me.GroupBox16.Controls.Add(Me.TextBox45)
        Me.GroupBox16.Controls.Add(Me.Button8)
        Me.GroupBox16.Location = New System.Drawing.Point(16, 10)
        Me.GroupBox16.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox16.Size = New System.Drawing.Size(881, 240)
        Me.GroupBox16.TabIndex = 10
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Search & Change"
        Me.GroupBox16.Visible = False
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(295, 90)
        Me.Label76.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(36, 16)
        Me.Label76.TabIndex = 15
        Me.Label76.Text = "Area"
        '
        'ComboBox13
        '
        Me.ComboBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox13.FormattingEnabled = True
        Me.ComboBox13.Items.AddRange(New Object() {"Eastern Area", "Western Area"})
        Me.ComboBox13.Location = New System.Drawing.Point(205, 117)
        Me.ComboBox13.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox13.Name = "ComboBox13"
        Me.ComboBox13.Size = New System.Drawing.Size(219, 37)
        Me.ComboBox13.TabIndex = 14
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(553, 192)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 41)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(15, 162)
        Me.Label77.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(317, 16)
        Me.Label77.TabIndex = 12
        Me.Label77.Text = "* Please enter a value to be change and press Save"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(536, 55)
        Me.Label79.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(0, 16)
        Me.Label79.TabIndex = 9
        Me.Label79.Visible = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(445, 192)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 41)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Save"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(80, 90)
        Me.Label81.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(44, 16)
        Me.Label81.TabIndex = 6
        Me.Label81.Text = "Name"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(3, 42)
        Me.Label82.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(79, 16)
        Me.Label82.TabIndex = 2
        Me.Label82.Text = "Search Text"
        '
        'TextBox44
        '
        Me.TextBox44.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox44.Location = New System.Drawing.Point(8, 117)
        Me.TextBox44.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox44.Multiline = True
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New System.Drawing.Size(185, 41)
        Me.TextBox44.TabIndex = 2
        '
        'TextBox45
        '
        Me.TextBox45.Location = New System.Drawing.Point(95, 37)
        Me.TextBox45.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New System.Drawing.Size(132, 22)
        Me.TextBox45.TabIndex = 0
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(299, 34)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 28)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Search"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label65)
        Me.GroupBox4.Controls.Add(Me.ComboBox11)
        Me.GroupBox4.Controls.Add(Me.Button24)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.TextBox11)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Button20)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.TextBox12)
        Me.GroupBox4.Controls.Add(Me.TextBox13)
        Me.GroupBox4.Controls.Add(Me.TextBox14)
        Me.GroupBox4.Controls.Add(Me.Button21)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 240)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(881, 234)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search & Change"
        Me.GroupBox4.Visible = False
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(747, 79)
        Me.Label65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(36, 16)
        Me.Label65.TabIndex = 17
        Me.Label65.Text = "Area"
        '
        'ComboBox11
        '
        Me.ComboBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Items.AddRange(New Object() {"Eastern Area", "Western Area"})
        Me.ComboBox11.Location = New System.Drawing.Point(657, 106)
        Me.ComboBox11.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(219, 37)
        Me.ComboBox11.TabIndex = 16
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(553, 183)
        Me.Button24.Margin = New System.Windows.Forms.Padding(4)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(100, 41)
        Me.Button24.TabIndex = 13
        Me.Button24.Text = "Delete"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(15, 161)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(317, 16)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "* Please enter a value to be change and press Save"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(492, 86)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(58, 16)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "Address"
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(429, 106)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(219, 41)
        Me.TextBox11.TabIndex = 4
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(536, 55)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(0, 16)
        Me.Label28.TabIndex = 9
        Me.Label28.Visible = False
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(445, 183)
        Me.Button20.Margin = New System.Windows.Forms.Padding(4)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(100, 41)
        Me.Button20.TabIndex = 5
        Me.Button20.Text = "Save"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(265, 86)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(99, 16)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Mobile Number"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(80, 86)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(44, 16)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Name"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(3, 42)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(79, 16)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Search Text"
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(8, 106)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(185, 41)
        Me.TextBox12.TabIndex = 2
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(95, 37)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(132, 22)
        Me.TextBox13.TabIndex = 0
        '
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(203, 106)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(219, 41)
        Me.TextBox14.TabIndex = 3
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(299, 34)
        Me.Button21.Margin = New System.Windows.Forms.Padding(4)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(100, 28)
        Me.Button21.TabIndex = 1
        Me.Button21.Text = "Search"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label66)
        Me.GroupBox5.Controls.Add(Me.ComboBox12)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.TextBox15)
        Me.GroupBox5.Controls.Add(Me.Button23)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.TextBox16)
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Controls.Add(Me.TextBox17)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.TextBox18)
        Me.GroupBox5.Controls.Add(Me.TextBox19)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 472)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(1133, 224)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Add New"
        Me.GroupBox5.Visible = False
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(965, 31)
        Me.Label66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(36, 16)
        Me.Label66.TabIndex = 21
        Me.Label66.Text = "Area"
        '
        'ComboBox12
        '
        Me.ComboBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Items.AddRange(New Object() {"Eastern Area", "Western Area"})
        Me.ComboBox12.Location = New System.Drawing.Point(885, 50)
        Me.ComboBox12.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(219, 37)
        Me.ComboBox12.TabIndex = 20
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(29, 103)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(309, 16)
        Me.Label32.TabIndex = 19
        Me.Label32.Text = "* Please enter values to be Added and press Save"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(871, 128)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(219, 40)
        Me.TextBox15.TabIndex = 18
        Me.TextBox15.Visible = False
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(487, 123)
        Me.Button23.Margin = New System.Windows.Forms.Padding(4)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(100, 41)
        Me.Button23.TabIndex = 11
        Me.Button23.Text = "Save"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(720, 31)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(36, 16)
        Me.Label33.TabIndex = 15
        Me.Label33.Text = "ADD"
        '
        'TextBox16
        '
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(657, 50)
        Me.TextBox16.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox16.Multiline = True
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(219, 40)
        Me.TextBox16.TabIndex = 10
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(492, 31)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(99, 16)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = "Mobile Number"
        '
        'TextBox17
        '
        Me.TextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(429, 50)
        Me.TextBox17.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox17.Multiline = True
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(219, 40)
        Me.TextBox17.TabIndex = 9
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(265, 31)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(44, 16)
        Me.Label35.TabIndex = 11
        Me.Label35.Text = "Name"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(80, 31)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(20, 16)
        Me.Label36.TabIndex = 10
        Me.Label36.Text = "ID"
        '
        'TextBox18
        '
        Me.TextBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(8, 50)
        Me.TextBox18.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox18.Multiline = True
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(185, 40)
        Me.TextBox18.TabIndex = 7
        '
        'TextBox19
        '
        Me.TextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(203, 50)
        Me.TextBox19.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox19.Multiline = True
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(219, 40)
        Me.TextBox19.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Location = New System.Drawing.Point(64, 745)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1187, 224)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add New"
        Me.GroupBox3.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(973, 31)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 16)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Area"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Eastern Area", "Western Area"})
        Me.ComboBox3.Location = New System.Drawing.Point(885, 52)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(219, 37)
        Me.ComboBox3.TabIndex = 20
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(17, 105)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(309, 16)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "* Please enter values to be Added and press Save"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(657, 128)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(219, 40)
        Me.TextBox8.TabIndex = 18
        Me.TextBox8.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(484, 127)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 41)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(747, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ADD"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(657, 50)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(219, 40)
        Me.TextBox7.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(492, 31)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Mobile Number"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(429, 50)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(219, 40)
        Me.TextBox6.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ID"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(8, 50)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(185, 40)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(203, 50)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(219, 40)
        Me.TextBox5.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Button25)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Location = New System.Drawing.Point(935, 62)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(881, 240)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search & Change"
        Me.GroupBox2.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(721, 43)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(64, 20)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Alone"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(747, 90)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Area"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Eastern Area", "Western Area"})
        Me.ComboBox2.Location = New System.Drawing.Point(657, 117)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(219, 37)
        Me.ComboBox2.TabIndex = 14
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(553, 192)
        Me.Button25.Margin = New System.Windows.Forms.Padding(4)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(100, 41)
        Me.Button25.TabIndex = 13
        Me.Button25.Text = "Delete"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 162)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(317, 16)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "* Please enter a value to be change and press Save"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(492, 90)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 16)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Address"
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(429, 117)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(219, 38)
        Me.TextBox10.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(536, 55)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(445, 192)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 41)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mobile Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search Text"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(8, 117)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(185, 41)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(95, 37)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(203, 117)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(219, 41)
        Me.TextBox2.TabIndex = 3
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(299, 34)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(100, 28)
        Me.Button10.TabIndex = 1
        Me.Button10.Text = "Search"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'driverLinkTab
        '
        Me.driverLinkTab.BackColor = System.Drawing.Color.WhiteSmoke
        Me.driverLinkTab.Controls.Add(Me.Panel5)
        Me.driverLinkTab.Location = New System.Drawing.Point(4, 28)
        Me.driverLinkTab.Margin = New System.Windows.Forms.Padding(4)
        Me.driverLinkTab.Name = "driverLinkTab"
        Me.driverLinkTab.Padding = New System.Windows.Forms.Padding(4)
        Me.driverLinkTab.Size = New System.Drawing.Size(1213, 690)
        Me.driverLinkTab.TabIndex = 2
        Me.driverLinkTab.Text = "Bus & Driver"
        Me.driverLinkTab.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DataGridView9)
        Me.Panel5.Controls.Add(Me.Label75)
        Me.Panel5.Controls.Add(Me.Label71)
        Me.Panel5.Controls.Add(Me.TextBox39)
        Me.Panel5.Controls.Add(Me.Label67)
        Me.Panel5.Controls.Add(Me.ComboBox1)
        Me.Panel5.Controls.Add(Me.D3)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(4, 4)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1205, 682)
        Me.Panel5.TabIndex = 6
        '
        'DataGridView9
        '
        Me.DataGridView9.AllowUserToAddRows = False
        Me.DataGridView9.AllowUserToDeleteRows = False
        Me.DataGridView9.AllowUserToResizeColumns = False
        Me.DataGridView9.AllowUserToResizeRows = False
        Me.DataGridView9.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView9.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView9.ColumnHeadersHeight = 29
        Me.DataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView9.Location = New System.Drawing.Point(661, 144)
        Me.DataGridView9.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView9.MultiSelect = False
        Me.DataGridView9.Name = "DataGridView9"
        Me.DataGridView9.ReadOnly = True
        Me.DataGridView9.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView9.RowHeadersVisible = False
        Me.DataGridView9.RowHeadersWidth = 51
        Me.DataGridView9.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView9.Size = New System.Drawing.Size(297, 308)
        Me.DataGridView9.TabIndex = 13
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(767, 47)
        Me.Label75.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(99, 16)
        Me.Label75.TabIndex = 12
        Me.Label75.Text = "7th circle buses"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(296, 47)
        Me.Label71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(124, 16)
        Me.Label71.TabIndex = 11
        Me.Label71.Text = "Door to Door buses"
        '
        'TextBox39
        '
        Me.TextBox39.Location = New System.Drawing.Point(257, 66)
        Me.TextBox39.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(221, 22)
        Me.TextBox39.TabIndex = 10
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(171, 66)
        Me.Label67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(64, 16)
        Me.Label67.TabIndex = 9
        Me.Label67.Text = "keyword :"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"7 circle Staff", "Airport Staff", "7 circle shutell staff", "All Staff"})
        Me.ComboBox1.Location = New System.Drawing.Point(257, 106)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(221, 24)
        Me.ComboBox1.TabIndex = 8
        '
        'D3
        '
        Me.D3.AllowUserToAddRows = False
        Me.D3.AllowUserToDeleteRows = False
        Me.D3.AllowUserToResizeColumns = False
        Me.D3.AllowUserToResizeRows = False
        Me.D3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.D3.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.D3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.D3.ColumnHeadersHeight = 29
        Me.D3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.D3.Location = New System.Drawing.Point(187, 144)
        Me.D3.Margin = New System.Windows.Forms.Padding(4)
        Me.D3.MultiSelect = False
        Me.D3.Name = "D3"
        Me.D3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.D3.RowHeadersVisible = False
        Me.D3.RowHeadersWidth = 51
        Me.D3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.D3.Size = New System.Drawing.Size(297, 567)
        Me.D3.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(4, 14)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(608, 18)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Please type in the BUS column last three digits of the license plate  to be linke" &
    "d with a driver."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(929, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'arrivalsRjTab
        '
        Me.arrivalsRjTab.Controls.Add(Me.WebView22)
        Me.arrivalsRjTab.Location = New System.Drawing.Point(4, 28)
        Me.arrivalsRjTab.Margin = New System.Windows.Forms.Padding(4)
        Me.arrivalsRjTab.Name = "arrivalsRjTab"
        Me.arrivalsRjTab.Padding = New System.Windows.Forms.Padding(4)
        Me.arrivalsRjTab.Size = New System.Drawing.Size(1213, 690)
        Me.arrivalsRjTab.TabIndex = 11
        Me.arrivalsRjTab.Text = "Arrivals"
        Me.arrivalsRjTab.UseVisualStyleBackColor = True
        '
        'WebView22
        '
        Me.WebView22.AllowExternalDrop = True
        Me.WebView22.CreationProperties = Nothing
        Me.WebView22.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView22.Location = New System.Drawing.Point(4, 4)
        Me.WebView22.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WebView22.Name = "WebView22"
        Me.WebView22.Size = New System.Drawing.Size(1205, 682)
        Me.WebView22.Source = New System.Uri("https://fly.rj.com/Arrivals", System.UriKind.Absolute)
        Me.WebView22.TabIndex = 0
        Me.WebView22.ZoomFactor = 1.0R
        '
        'ArrivalsTab
        '
        Me.ArrivalsTab.Controls.Add(Me.GroupBox9)
        Me.ArrivalsTab.Controls.Add(Me.ToolStrip5)
        Me.ArrivalsTab.Location = New System.Drawing.Point(4, 28)
        Me.ArrivalsTab.Margin = New System.Windows.Forms.Padding(4)
        Me.ArrivalsTab.Name = "ArrivalsTab"
        Me.ArrivalsTab.Padding = New System.Windows.Forms.Padding(4)
        Me.ArrivalsTab.Size = New System.Drawing.Size(1213, 690)
        Me.ArrivalsTab.TabIndex = 12
        Me.ArrivalsTab.Text = "Arr"
        Me.ArrivalsTab.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Panel3)
        Me.GroupBox9.Controls.Add(Me.Panel6)
        Me.GroupBox9.Controls.Add(Me.DataGridView6)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.Location = New System.Drawing.Point(4, 31)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox9.Size = New System.Drawing.Size(1205, 655)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "GroupBox9"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label39)
        Me.Panel3.Controls.Add(Me.Label40)
        Me.Panel3.Controls.Add(Me.Label41)
        Me.Panel3.Controls.Add(Me.Label43)
        Me.Panel3.Controls.Add(Me.Label44)
        Me.Panel3.Controls.Add(Me.Label45)
        Me.Panel3.Location = New System.Drawing.Point(0, 347)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(147, 162)
        Me.Panel3.TabIndex = 2
        Me.Panel3.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(27, 132)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(84, 20)
        Me.Label39.TabIndex = 9
        Me.Label39.Text = "Add Flight"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(31, 107)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(77, 20)
        Me.Label40.TabIndex = 8
        Me.Label40.Text = "Switched"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(0, 82)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(131, 20)
        Me.Label41.TabIndex = 6
        Me.Label41.Text = "        Alone        "
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(3, 58)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(126, 20)
        Me.Label43.TabIndex = 4
        Me.Label43.Text = "      No Show    "
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(1, 31)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(128, 20)
        Me.Label44.TabIndex = 3
        Me.Label44.Text = "        Delete      "
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(3, 5)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(126, 20)
        Me.Label45.TabIndex = 2
        Me.Label45.Text = "        Insert       "
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(4, 19)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1197, 632)
        Me.Panel6.TabIndex = 1
        '
        'DataGridView6
        '
        Me.DataGridView6.AllowUserToAddRows = False
        Me.DataGridView6.AllowUserToDeleteRows = False
        Me.DataGridView6.AllowUserToResizeColumns = False
        Me.DataGridView6.AllowUserToResizeRows = False
        Me.DataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView6.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView6.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView6.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DataGridView6.Location = New System.Drawing.Point(4, 19)
        Me.DataGridView6.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView6.MultiSelect = False
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.RowHeadersVisible = False
        Me.DataGridView6.RowHeadersWidth = 51
        Me.DataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView6.ShowEditingIcon = False
        Me.DataGridView6.ShowRowErrors = False
        Me.DataGridView6.Size = New System.Drawing.Size(1197, 632)
        Me.DataGridView6.StandardTab = True
        Me.DataGridView6.TabIndex = 0
        '
        'ToolStrip5
        '
        Me.ToolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip5.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton19, Me.ToolStripSeparator11, Me.ToolStripButton21, Me.ToolStripLabel6, Me.ToolStripButton22, Me.ToolStripButton23})
        Me.ToolStrip5.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip5.Size = New System.Drawing.Size(1205, 27)
        Me.ToolStrip5.TabIndex = 1
        Me.ToolStrip5.Text = "ToolStrip5"
        '
        'ToolStripButton19
        '
        Me.ToolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton19.Image = CType(resources.GetObject("ToolStripButton19.Image"), System.Drawing.Image)
        Me.ToolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton19.Name = "ToolStripButton19"
        Me.ToolStripButton19.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton19.Text = "&Open"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton21
        '
        Me.ToolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton21.Image = CType(resources.GetObject("ToolStripButton21.Image"), System.Drawing.Image)
        Me.ToolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton21.Name = "ToolStripButton21"
        Me.ToolStripButton21.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton21.Text = "-"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.BackColor = System.Drawing.Color.White
        Me.ToolStripLabel6.Enabled = False
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(137, 24)
        Me.ToolStripLabel6.Text = "                                "
        '
        'ToolStripButton22
        '
        Me.ToolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton22.Image = CType(resources.GetObject("ToolStripButton22.Image"), System.Drawing.Image)
        Me.ToolStripButton22.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton22.Name = "ToolStripButton22"
        Me.ToolStripButton22.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton22.Text = "+"
        '
        'ToolStripButton23
        '
        Me.ToolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton23.Image = CType(resources.GetObject("ToolStripButton23.Image"), System.Drawing.Image)
        Me.ToolStripButton23.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton23.Name = "ToolStripButton23"
        Me.ToolStripButton23.Size = New System.Drawing.Size(93, 24)
        Me.ToolStripButton23.Text = "Load Arrival"
        '
        'notesTab
        '
        Me.notesTab.Controls.Add(Me.dgvCalendar)
        Me.notesTab.Controls.Add(Me.ToolStrip3)
        Me.notesTab.Location = New System.Drawing.Point(4, 28)
        Me.notesTab.Margin = New System.Windows.Forms.Padding(4)
        Me.notesTab.Name = "notesTab"
        Me.notesTab.Padding = New System.Windows.Forms.Padding(4)
        Me.notesTab.Size = New System.Drawing.Size(1213, 690)
        Me.notesTab.TabIndex = 15
        Me.notesTab.Text = "Notes"
        Me.notesTab.UseVisualStyleBackColor = True
        '
        'dgvCalendar
        '
        Me.dgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCalendar.Location = New System.Drawing.Point(4, 32)
        Me.dgvCalendar.Name = "dgvCalendar"
        Me.dgvCalendar.RowHeadersWidth = 51
        Me.dgvCalendar.RowTemplate.Height = 24
        Me.dgvCalendar.Size = New System.Drawing.Size(1205, 654)
        Me.dgvCalendar.TabIndex = 3
        '
        'ToolStrip3
        '
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbMonth, Me.cmbYear})
        Me.ToolStrip3.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1205, 28)
        Me.ToolStrip3.TabIndex = 2
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmbMonth
        '
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 28)
        '
        'cmbYear
        '
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 28)
        '
        'ordersTab
        '
        Me.ordersTab.Controls.Add(Me.WebView23)
        Me.ordersTab.Location = New System.Drawing.Point(4, 28)
        Me.ordersTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ordersTab.Name = "ordersTab"
        Me.ordersTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ordersTab.Size = New System.Drawing.Size(1213, 690)
        Me.ordersTab.TabIndex = 16
        Me.ordersTab.Text = "Orders"
        Me.ordersTab.UseVisualStyleBackColor = True
        '
        'WebView23
        '
        Me.WebView23.AllowExternalDrop = True
        Me.WebView23.CreationProperties = Nothing
        Me.WebView23.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView23.Location = New System.Drawing.Point(3, 2)
        Me.WebView23.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WebView23.Name = "WebView23"
        Me.WebView23.Size = New System.Drawing.Size(1207, 686)
        Me.WebView23.TabIndex = 0
        Me.WebView23.ZoomFactor = 1.0R
        '
        'createRosterTab
        '
        Me.createRosterTab.Controls.Add(Me.GroupBox8)
        Me.createRosterTab.Controls.Add(Me.GroupBox7)
        Me.createRosterTab.Location = New System.Drawing.Point(4, 28)
        Me.createRosterTab.Name = "createRosterTab"
        Me.createRosterTab.Padding = New System.Windows.Forms.Padding(3)
        Me.createRosterTab.Size = New System.Drawing.Size(1213, 690)
        Me.createRosterTab.TabIndex = 17
        Me.createRosterTab.Text = "Create Roster"
        Me.createRosterTab.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.DataGridView1)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 240)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1207, 447)
        Me.GroupBox8.TabIndex = 55
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Roster"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(1201, 424)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.Label24)
        Me.GroupBox7.Controls.Add(Me.FleetTeastBtn)
        Me.GroupBox7.Controls.Add(Me.Button11)
        Me.GroupBox7.Controls.Add(Me.RESTORBTN)
        Me.GroupBox7.Controls.Add(Me.Button12)
        Me.GroupBox7.Controls.Add(Me.btnroster)
        Me.GroupBox7.Controls.Add(Me.txtfleetwatch)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.lblroster)
        Me.GroupBox7.Controls.Add(Me.lblfleetwatch)
        Me.GroupBox7.Controls.Add(Me.testtext)
        Me.GroupBox7.Controls.Add(Me.txtroster)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1207, 237)
        Me.GroupBox7.TabIndex = 54
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Create Roster"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label24.Location = New System.Drawing.Point(3, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(1201, 214)
        Me.Label24.TabIndex = 38
        Me.Label24.Text = "processing , please wait ...."
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label24.Visible = False
        '
        'FleetTeastBtn
        '
        Me.FleetTeastBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FleetTeastBtn.ForeColor = System.Drawing.Color.White
        Me.FleetTeastBtn.Location = New System.Drawing.Point(450, 35)
        Me.FleetTeastBtn.Name = "FleetTeastBtn"
        Me.FleetTeastBtn.Size = New System.Drawing.Size(75, 29)
        Me.FleetTeastBtn.TabIndex = 36
        Me.FleetTeastBtn.Text = "Browse"
        Me.FleetTeastBtn.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(450, 74)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 27)
        Me.Button11.TabIndex = 34
        Me.Button11.Text = "Browse"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'RESTORBTN
        '
        Me.RESTORBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RESTORBTN.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.RESTORBTN.ForeColor = System.Drawing.Color.White
        Me.RESTORBTN.Location = New System.Drawing.Point(275, 167)
        Me.RESTORBTN.Name = "RESTORBTN"
        Me.RESTORBTN.Size = New System.Drawing.Size(176, 51)
        Me.RESTORBTN.TabIndex = 32
        Me.RESTORBTN.Text = "CLEAR"
        Me.RESTORBTN.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button12.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Location = New System.Drawing.Point(103, 167)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(166, 51)
        Me.Button12.TabIndex = 30
        Me.Button12.Text = "RUN"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'btnroster
        '
        Me.btnroster.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnroster.ForeColor = System.Drawing.Color.White
        Me.btnroster.Location = New System.Drawing.Point(447, 112)
        Me.btnroster.Name = "btnroster"
        Me.btnroster.Size = New System.Drawing.Size(75, 28)
        Me.btnroster.TabIndex = 14
        Me.btnroster.Text = "Browse"
        Me.btnroster.UseVisualStyleBackColor = False
        '
        'txtfleetwatch
        '
        Me.txtfleetwatch.Enabled = False
        Me.txtfleetwatch.Location = New System.Drawing.Point(109, 40)
        Me.txtfleetwatch.Name = "txtfleetwatch"
        Me.txtfleetwatch.Size = New System.Drawing.Size(330, 24)
        Me.txtfleetwatch.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(6, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 21)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "AIRCRAFT"
        '
        'lblroster
        '
        Me.lblroster.AutoSize = True
        Me.lblroster.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblroster.Location = New System.Drawing.Point(9, 117)
        Me.lblroster.Name = "lblroster"
        Me.lblroster.Size = New System.Drawing.Size(73, 21)
        Me.lblroster.TabIndex = 12
        Me.lblroster.Text = "ROSTER"
        '
        'lblfleetwatch
        '
        Me.lblfleetwatch.AutoSize = True
        Me.lblfleetwatch.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblfleetwatch.Location = New System.Drawing.Point(12, 45)
        Me.lblfleetwatch.Name = "lblfleetwatch"
        Me.lblfleetwatch.Size = New System.Drawing.Size(57, 21)
        Me.lblfleetwatch.TabIndex = 13
        Me.lblfleetwatch.Text = "FLEET"
        '
        'testtext
        '
        Me.testtext.Enabled = False
        Me.testtext.Location = New System.Drawing.Point(109, 79)
        Me.testtext.Name = "testtext"
        Me.testtext.Size = New System.Drawing.Size(330, 24)
        Me.testtext.TabIndex = 9
        '
        'txtroster
        '
        Me.txtroster.Enabled = False
        Me.txtroster.Location = New System.Drawing.Point(109, 114)
        Me.txtroster.Name = "txtroster"
        Me.txtroster.Size = New System.Drawing.Size(330, 24)
        Me.txtroster.TabIndex = 9
        '
        'kmRreportTab
        '
        Me.kmRreportTab.Controls.Add(Me.SplitContainer3)
        Me.kmRreportTab.Location = New System.Drawing.Point(4, 28)
        Me.kmRreportTab.Name = "kmRreportTab"
        Me.kmRreportTab.Padding = New System.Windows.Forms.Padding(3)
        Me.kmRreportTab.Size = New System.Drawing.Size(1213, 690)
        Me.kmRreportTab.TabIndex = 18
        Me.kmRreportTab.Text = "KM Report"
        Me.kmRreportTab.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TreeView2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.KMReports)
        Me.SplitContainer3.Panel2.Controls.Add(Me.orderRecords)
        Me.SplitContainer3.Size = New System.Drawing.Size(1207, 684)
        Me.SplitContainer3.SplitterDistance = 152
        Me.SplitContainer3.TabIndex = 49
        '
        'TreeView2
        '
        Me.TreeView2.BackColor = System.Drawing.SystemColors.Menu
        Me.TreeView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView2.Location = New System.Drawing.Point(0, 0)
        Me.TreeView2.Name = "TreeView2"
        TreeNode10.Checked = True
        TreeNode10.Name = "Records"
        TreeNode10.Text = "Records"
        TreeNode11.Name = "Report"
        TreeNode11.Text = "Report"
        TreeNode12.Name = "KM Report"
        TreeNode12.Text = "KM Report"
        Me.TreeView2.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode12})
        Me.TreeView2.Size = New System.Drawing.Size(152, 684)
        Me.TreeView2.TabIndex = 48
        '
        'KMReports
        '
        Me.KMReports.Controls.Add(Me.SplitContainer4)
        Me.KMReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KMReports.Location = New System.Drawing.Point(0, 0)
        Me.KMReports.Name = "KMReports"
        Me.KMReports.Size = New System.Drawing.Size(1051, 684)
        Me.KMReports.TabIndex = 49
        Me.KMReports.TabStop = False
        Me.KMReports.Text = "Reports"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 18)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.btnExport)
        Me.SplitContainer4.Panel1.Controls.Add(Me.cmbReports)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label84)
        Me.SplitContainer4.Panel1.Controls.Add(Me.btnSearch)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label85)
        Me.SplitContainer4.Panel1.Controls.Add(Me.dtpto)
        Me.SplitContainer4.Panel1.Controls.Add(Me.dtpFrom)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label86)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer4.Size = New System.Drawing.Size(1045, 663)
        Me.SplitContainer4.SplitterDistance = 87
        Me.SplitContainer4.TabIndex = 48
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(640, 13)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(240, 51)
        Me.btnExport.TabIndex = 47
        Me.btnExport.Text = "Export Excel"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'cmbReports
        '
        Me.cmbReports.FormattingEnabled = True
        Me.cmbReports.Location = New System.Drawing.Point(16, 31)
        Me.cmbReports.Name = "cmbReports"
        Me.cmbReports.Size = New System.Drawing.Size(168, 24)
        Me.cmbReports.TabIndex = 0
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(13, 13)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(83, 16)
        Me.Label84.TabIndex = 1
        Me.Label84.Text = "Report Type"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(461, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(171, 51)
        Me.btnSearch.TabIndex = 46
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(214, 12)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(38, 16)
        Me.Label85.TabIndex = 2
        Me.Label85.Text = "From"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtpto
        '
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(343, 33)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(97, 22)
        Me.dtpto.TabIndex = 5
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(217, 33)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(97, 22)
        Me.dtpFrom.TabIndex = 3
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(340, 12)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(24, 16)
        Me.Label86.TabIndex = 4
        Me.Label86.Text = "To"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(1045, 572)
        Me.dgv.TabIndex = 47
        '
        'orderRecords
        '
        Me.orderRecords.Controls.Add(Me.Label83)
        Me.orderRecords.Controls.Add(Me.btnDelete)
        Me.orderRecords.Controls.Add(Me.btnUpdate)
        Me.orderRecords.Controls.Add(Me.btnInsert)
        Me.orderRecords.Controls.Add(Me.chkSpecial)
        Me.orderRecords.Controls.Add(Me.chkGroundStaff)
        Me.orderRecords.Controls.Add(Me.chkDriver)
        Me.orderRecords.Controls.Add(Me.txtendKm)
        Me.orderRecords.Controls.Add(Me.Label78)
        Me.orderRecords.Controls.Add(Me.txtStartKm)
        Me.orderRecords.Controls.Add(Me.Label46)
        Me.orderRecords.Controls.Add(Me.Label38)
        Me.orderRecords.Controls.Add(Me.cmbDriver)
        Me.orderRecords.Controls.Add(Me.txtDate)
        Me.orderRecords.Controls.Add(Me.Label37)
        Me.orderRecords.Controls.Add(Me.txtBusNo)
        Me.orderRecords.Controls.Add(Me.Label47)
        Me.orderRecords.Controls.Add(Me.txtOrderId)
        Me.orderRecords.Controls.Add(Me.Label80)
        Me.orderRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.orderRecords.Location = New System.Drawing.Point(0, 0)
        Me.orderRecords.Name = "orderRecords"
        Me.orderRecords.Size = New System.Drawing.Size(1051, 684)
        Me.orderRecords.TabIndex = 0
        Me.orderRecords.TabStop = False
        Me.orderRecords.Text = "Order Records"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.ForeColor = System.Drawing.Color.Red
        Me.Label83.Location = New System.Drawing.Point(6, 152)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(0, 16)
        Me.Label83.TabIndex = 48
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.Window
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDelete.Location = New System.Drawing.Point(358, 171)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(147, 51)
        Me.btnDelete.TabIndex = 47
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(172, 171)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(173, 51)
        Me.btnUpdate.TabIndex = 46
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInsert.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(1, 171)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(165, 51)
        Me.btnInsert.TabIndex = 45
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'chkSpecial
        '
        Me.chkSpecial.AutoSize = True
        Me.chkSpecial.Location = New System.Drawing.Point(642, 97)
        Me.chkSpecial.Name = "chkSpecial"
        Me.chkSpecial.Size = New System.Drawing.Size(131, 20)
        Me.chkSpecial.TabIndex = 44
        Me.chkSpecial.Text = "Special Missions"
        Me.chkSpecial.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSpecial.UseVisualStyleBackColor = True
        '
        'chkGroundStaff
        '
        Me.chkGroundStaff.AutoSize = True
        Me.chkGroundStaff.Location = New System.Drawing.Point(523, 97)
        Me.chkGroundStaff.Name = "chkGroundStaff"
        Me.chkGroundStaff.Size = New System.Drawing.Size(102, 20)
        Me.chkGroundStaff.TabIndex = 43
        Me.chkGroundStaff.Text = "Ground Staff"
        Me.chkGroundStaff.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkGroundStaff.UseVisualStyleBackColor = True
        '
        'chkDriver
        '
        Me.chkDriver.AutoSize = True
        Me.chkDriver.Location = New System.Drawing.Point(423, 97)
        Me.chkDriver.Name = "chkDriver"
        Me.chkDriver.Size = New System.Drawing.Size(82, 20)
        Me.chkDriver.TabIndex = 42
        Me.chkDriver.Text = "Captains"
        Me.chkDriver.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkDriver.UseVisualStyleBackColor = True
        '
        'txtendKm
        '
        Me.txtendKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtendKm.Location = New System.Drawing.Point(211, 95)
        Me.txtendKm.Name = "txtendKm"
        Me.txtendKm.Size = New System.Drawing.Size(171, 22)
        Me.txtendKm.TabIndex = 38
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(211, 76)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(53, 16)
        Me.Label78.TabIndex = 37
        Me.Label78.Text = "End Km"
        '
        'txtStartKm
        '
        Me.txtStartKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStartKm.Location = New System.Drawing.Point(6, 95)
        Me.txtStartKm.Name = "txtStartKm"
        Me.txtStartKm.Size = New System.Drawing.Size(171, 22)
        Me.txtStartKm.TabIndex = 36
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(6, 76)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(56, 16)
        Me.Label46.TabIndex = 35
        Me.Label46.Text = "Start Km"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(559, 24)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(43, 16)
        Me.Label38.TabIndex = 34
        Me.Label38.Text = "Driver"
        '
        'cmbDriver
        '
        Me.cmbDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDriver.FormattingEnabled = True
        Me.cmbDriver.Location = New System.Drawing.Point(559, 42)
        Me.cmbDriver.Name = "cmbDriver"
        Me.cmbDriver.Size = New System.Drawing.Size(165, 24)
        Me.cmbDriver.TabIndex = 33
        '
        'txtDate
        '
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDate.Location = New System.Drawing.Point(410, 42)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(107, 22)
        Me.txtDate.TabIndex = 32
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(410, 23)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(36, 16)
        Me.Label37.TabIndex = 31
        Me.Label37.Text = "Date"
        '
        'txtBusNo
        '
        Me.txtBusNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusNo.Location = New System.Drawing.Point(211, 44)
        Me.txtBusNo.Name = "txtBusNo"
        Me.txtBusNo.Size = New System.Drawing.Size(171, 22)
        Me.txtBusNo.TabIndex = 30
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(211, 25)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(51, 16)
        Me.Label47.TabIndex = 29
        Me.Label47.Text = "Bus No"
        '
        'txtOrderId
        '
        Me.txtOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrderId.Location = New System.Drawing.Point(6, 44)
        Me.txtOrderId.Name = "txtOrderId"
        Me.txtOrderId.Size = New System.Drawing.Size(171, 22)
        Me.txtOrderId.TabIndex = 28
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(6, 25)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(57, 16)
        Me.Label80.TabIndex = 27
        Me.Label80.Text = "Order ID"
        '
        'reportsTab
        '
        Me.reportsTab.Controls.Add(Me.SplitContainer6)
        Me.reportsTab.Location = New System.Drawing.Point(4, 28)
        Me.reportsTab.Name = "reportsTab"
        Me.reportsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.reportsTab.Size = New System.Drawing.Size(1213, 690)
        Me.reportsTab.TabIndex = 19
        Me.reportsTab.Text = "Reports"
        Me.reportsTab.UseVisualStyleBackColor = True
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer6.Name = "SplitContainer6"
        Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.btnExportExcel)
        Me.SplitContainer6.Panel1.Controls.Add(Me.btnLoad)
        Me.SplitContainer6.Panel1.Controls.Add(Me.lblDateOnly)
        Me.SplitContainer6.Panel1.Controls.Add(Me.txtDateOnly)
        Me.SplitContainer6.Panel1.Controls.Add(Me.lblArea)
        Me.SplitContainer6.Panel1.Controls.Add(Me.cmbArea)
        Me.SplitContainer6.Panel1.Controls.Add(Me.lbltoDate)
        Me.SplitContainer6.Panel1.Controls.Add(Me.txtToDate)
        Me.SplitContainer6.Panel1.Controls.Add(Me.lblFromDate)
        Me.SplitContainer6.Panel1.Controls.Add(Me.txtFromDate)
        Me.SplitContainer6.Panel1.Controls.Add(Me.lblRecordCount)
        Me.SplitContainer6.Panel1.Controls.Add(lblNoData)
        Me.SplitContainer6.Panel1.Controls.Add(Me.txtKeyword)
        Me.SplitContainer6.Panel1.Controls.Add(Me.Label87)
        Me.SplitContainer6.Panel1.Controls.Add(Me.lblKeyword)
        Me.SplitContainer6.Panel1.Controls.Add(Me.cmbreportType)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.dgvResults)
        Me.SplitContainer6.Size = New System.Drawing.Size(1207, 684)
        Me.SplitContainer6.SplitterDistance = 106
        Me.SplitContainer6.TabIndex = 6
        '
        'btnExportExcel
        '
        Me.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExportExcel.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnExportExcel.ForeColor = System.Drawing.Color.White
        Me.btnExportExcel.Location = New System.Drawing.Point(1067, 30)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(135, 51)
        Me.btnExportExcel.TabIndex = 58
        Me.btnExportExcel.Text = "Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = False
        Me.btnExportExcel.Visible = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLoad.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Location = New System.Drawing.Point(823, 30)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(240, 51)
        Me.btnLoad.TabIndex = 57
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'lblDateOnly
        '
        Me.lblDateOnly.AutoSize = True
        Me.lblDateOnly.Location = New System.Drawing.Point(682, 12)
        Me.lblDateOnly.Name = "lblDateOnly"
        Me.lblDateOnly.Size = New System.Drawing.Size(36, 16)
        Me.lblDateOnly.TabIndex = 56
        Me.lblDateOnly.Text = "Date"
        Me.lblDateOnly.Visible = False
        '
        'txtDateOnly
        '
        Me.txtDateOnly.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDateOnly.Location = New System.Drawing.Point(685, 30)
        Me.txtDateOnly.Name = "txtDateOnly"
        Me.txtDateOnly.Size = New System.Drawing.Size(108, 22)
        Me.txtDateOnly.TabIndex = 55
        Me.txtDateOnly.Visible = False
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(12, 57)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(36, 16)
        Me.lblArea.TabIndex = 53
        Me.lblArea.Text = "Area"
        Me.lblArea.Visible = False
        '
        'cmbArea
        '
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(15, 76)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(177, 24)
        Me.cmbArea.TabIndex = 54
        Me.cmbArea.Visible = False
        '
        'lbltoDate
        '
        Me.lbltoDate.AutoSize = True
        Me.lbltoDate.Location = New System.Drawing.Point(559, 13)
        Me.lbltoDate.Name = "lbltoDate"
        Me.lbltoDate.Size = New System.Drawing.Size(24, 16)
        Me.lbltoDate.TabIndex = 52
        Me.lbltoDate.Text = "To"
        Me.lbltoDate.Visible = False
        '
        'txtToDate
        '
        Me.txtToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtToDate.Location = New System.Drawing.Point(562, 31)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Size = New System.Drawing.Size(108, 22)
        Me.txtToDate.TabIndex = 51
        Me.txtToDate.Visible = False
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(436, 13)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(38, 16)
        Me.lblFromDate.TabIndex = 50
        Me.lblFromDate.Text = "From"
        Me.lblFromDate.Visible = False
        '
        'txtFromDate
        '
        Me.txtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFromDate.Location = New System.Drawing.Point(439, 31)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Size = New System.Drawing.Size(108, 22)
        Me.txtFromDate.TabIndex = 49
        Me.txtFromDate.Visible = False
        '
        'lblRecordCount
        '
        Me.lblRecordCount.AutoSize = True
        Me.lblRecordCount.Location = New System.Drawing.Point(287, 76)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(0, 16)
        Me.lblRecordCount.TabIndex = 6
        Me.lblRecordCount.Visible = False
        '
        'txtKeyword
        '
        Me.txtKeyword.Location = New System.Drawing.Point(216, 32)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(204, 22)
        Me.txtKeyword.TabIndex = 3
        Me.txtKeyword.Visible = False
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(12, 11)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(83, 16)
        Me.Label87.TabIndex = 0
        Me.Label87.Text = "Report Type"
        '
        'lblKeyword
        '
        Me.lblKeyword.AutoSize = True
        Me.lblKeyword.Location = New System.Drawing.Point(213, 13)
        Me.lblKeyword.Name = "lblKeyword"
        Me.lblKeyword.Size = New System.Drawing.Size(59, 16)
        Me.lblKeyword.TabIndex = 2
        Me.lblKeyword.Text = "Keyword"
        Me.lblKeyword.Visible = False
        '
        'cmbreportType
        '
        Me.cmbreportType.FormattingEnabled = True
        Me.cmbreportType.Location = New System.Drawing.Point(15, 30)
        Me.cmbreportType.Name = "cmbreportType"
        Me.cmbreportType.Size = New System.Drawing.Size(177, 24)
        Me.cmbreportType.TabIndex = 1
        '
        'dgvResults
        '
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResults.Location = New System.Drawing.Point(0, 0)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.RowHeadersWidth = 51
        Me.dgvResults.RowTemplate.Height = 24
        Me.dgvResults.Size = New System.Drawing.Size(1207, 574)
        Me.dgvResults.TabIndex = 4
        '
        'Timer2
        '
        Me.Timer2.Interval = 900000
        '
        'BindingSource5
        '
        Me.BindingSource5.DataMember = "bus"
        Me.BindingSource5.DataSource = Me.BindingSource3
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.AutoScroll = True
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.SplitContainer2)
        Me.ToolStripContainer2.ContentPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(1221, 752)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(1221, 777)
        Me.ToolStripContainer2.TabIndex = 4
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'Timer3
        '
        Me.Timer3.Interval = 500
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.BackColor = System.Drawing.Color.White
        Me.ToolStripLabel4.Enabled = False
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripLabel4.Text = "                                "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.BackColor = System.Drawing.Color.White
        Me.ToolStripLabel5.Enabled = False
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripLabel5.Text = "                                "
        '
        'Timer4
        '
        Me.Timer4.Interval = 150
        '
        'Timer5
        '
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 27)
        '
        'DataGridView8
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView8.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView8.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView8.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView8.Location = New System.Drawing.Point(4, 19)
        Me.DataGridView8.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView8.Name = "DataGridView8"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView8.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView8.RowHeadersWidth = 51
        Me.DataGridView8.Size = New System.Drawing.Size(1205, 325)
        Me.DataGridView8.TabIndex = 1
        '
        'Column13
        '
        Me.Column13.HeaderText = "Edit Crew"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.Text = "Edit Crew"
        Me.Column13.UseColumnTextForButtonValue = True
        Me.Column13.Width = 125
        '
        'Column23
        '
        Me.Column23.HeaderText = "Order Status"
        Me.Column23.Items.AddRange(New Object() {"In Process", "Close", "Hold", "Delete", "Without Crew", "Close Without End KM"})
        Me.Column23.MinimumWidth = 6
        Me.Column23.Name = "Column23"
        Me.Column23.Width = 125
        '
        'Column24
        '
        Me.Column24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column24.HeaderText = "Shatel Time"
        Me.Column24.MinimumWidth = 6
        Me.Column24.Name = "Column24"
        Me.Column24.ReadOnly = True
        Me.Column24.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column24.Width = 125
        '
        'Column22
        '
        Me.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column22.HeaderText = "End KM"
        Me.Column22.MinimumWidth = 6
        Me.Column22.Name = "Column22"
        Me.Column22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column22.Width = 125
        '
        'Column21
        '
        Me.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column21.HeaderText = "Start KM"
        Me.Column21.MinimumWidth = 6
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column21.Width = 125
        '
        'Column20
        '
        Me.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column20.HeaderText = "End Time"
        Me.Column20.MinimumWidth = 6
        Me.Column20.Name = "Column20"
        Me.Column20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column20.Width = 125
        '
        'Column19
        '
        Me.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column19.HeaderText = "Start Time"
        Me.Column19.MinimumWidth = 6
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column19.Width = 125
        '
        'Column18
        '
        Me.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column18.HeaderText = "Driver"
        Me.Column18.MinimumWidth = 6
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column18.Width = 125
        '
        'Column17
        '
        Me.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column17.HeaderText = "Bus"
        Me.Column17.MinimumWidth = 6
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column17.Width = 125
        '
        'Column16
        '
        Me.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column16.HeaderText = "Order ID"
        Me.Column16.MinimumWidth = 6
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column16.Width = 125
        '
        'GroupBox14
        '
        Me.GroupBox14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox14.Location = New System.Drawing.Point(4, 344)
        Me.GroupBox14.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox14.Size = New System.Drawing.Size(1205, 308)
        Me.GroupBox14.TabIndex = 2
        Me.GroupBox14.TabStop = False
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(11, 129)
        Me.Label74.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(30, 16)
        Me.Label74.TabIndex = 19
        '
        'TextBox42
        '
        Me.TextBox42.Location = New System.Drawing.Point(77, 126)
        Me.TextBox42.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New System.Drawing.Size(132, 22)
        Me.TextBox42.TabIndex = 20
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(11, 86)
        Me.Label73.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(43, 16)
        Me.Label73.TabIndex = 21
        '
        'TextBox41
        '
        Me.TextBox41.Enabled = False
        Me.TextBox41.Location = New System.Drawing.Point(77, 82)
        Me.TextBox41.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New System.Drawing.Size(132, 22)
        Me.TextBox41.TabIndex = 22
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(229, 42)
        Me.Label72.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(56, 16)
        Me.Label72.TabIndex = 23
        '
        'TextBox40
        '
        Me.TextBox40.Location = New System.Drawing.Point(312, 38)
        Me.TextBox40.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(132, 22)
        Me.TextBox40.TabIndex = 24
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(229, 90)
        Me.Label70.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(68, 16)
        Me.Label70.TabIndex = 27
        '
        'TextBox38
        '
        Me.TextBox38.Location = New System.Drawing.Point(312, 86)
        Me.TextBox38.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(132, 22)
        Me.TextBox38.TabIndex = 28
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(229, 129)
        Me.Label69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(73, 16)
        Me.Label69.TabIndex = 29
        '
        'TextBox37
        '
        Me.TextBox37.Enabled = False
        Me.TextBox37.Location = New System.Drawing.Point(312, 126)
        Me.TextBox37.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(132, 22)
        Me.TextBox37.TabIndex = 30
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(9, 42)
        Me.Label68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(57, 16)
        Me.Label68.TabIndex = 31
        '
        'TextBox36
        '
        Me.TextBox36.Enabled = False
        Me.TextBox36.Location = New System.Drawing.Point(77, 38)
        Me.TextBox36.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(132, 22)
        Me.TextBox36.TabIndex = 32
        '
        'TextBox35
        '
        Me.TextBox35.Location = New System.Drawing.Point(77, 210)
        Me.TextBox35.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.ReadOnly = True
        Me.TextBox35.Size = New System.Drawing.Size(103, 22)
        Me.TextBox35.TabIndex = 33
        '
        'TextBox34
        '
        Me.TextBox34.Enabled = False
        Me.TextBox34.Location = New System.Drawing.Point(200, 210)
        Me.TextBox34.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(103, 22)
        Me.TextBox34.TabIndex = 34
        '
        'D9
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.D9.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.D9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.D9.DefaultCellStyle = DataGridViewCellStyle5
        Me.D9.Dock = System.Windows.Forms.DockStyle.Right
        Me.D9.Location = New System.Drawing.Point(605, 19)
        Me.D9.Margin = New System.Windows.Forms.Padding(4)
        Me.D9.Name = "D9"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.D9.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.D9.RowHeadersWidth = 51
        Me.D9.Size = New System.Drawing.Size(596, 285)
        Me.D9.TabIndex = 35
        '
        'Column32
        '
        Me.Column32.HeaderText = "ID"
        Me.Column32.MinimumWidth = 6
        Me.Column32.Name = "Column32"
        Me.Column32.ReadOnly = True
        Me.Column32.Visible = False
        Me.Column32.Width = 125
        '
        'Column31
        '
        Me.Column31.HeaderText = "Status"
        Me.Column31.MinimumWidth = 6
        Me.Column31.Name = "Column31"
        Me.Column31.ReadOnly = True
        Me.Column31.Width = 125
        '
        'Column30
        '
        Me.Column30.HeaderText = "Pickup Time"
        Me.Column30.MinimumWidth = 6
        Me.Column30.Name = "Column30"
        Me.Column30.ReadOnly = True
        Me.Column30.Width = 125
        '
        'Column29
        '
        Me.Column29.HeaderText = "Destination"
        Me.Column29.MinimumWidth = 6
        Me.Column29.Name = "Column29"
        Me.Column29.ReadOnly = True
        Me.Column29.Width = 125
        '
        'Column28
        '
        Me.Column28.HeaderText = "HomeAddress"
        Me.Column28.MinimumWidth = 6
        Me.Column28.Name = "Column28"
        Me.Column28.ReadOnly = True
        Me.Column28.Width = 125
        '
        'Column27
        '
        Me.Column27.HeaderText = "ArName"
        Me.Column27.MinimumWidth = 6
        Me.Column27.Name = "Column27"
        Me.Column27.ReadOnly = True
        Me.Column27.Width = 125
        '
        'Column26
        '
        Me.Column26.HeaderText = "OrderID"
        Me.Column26.MinimumWidth = 6
        Me.Column26.Name = "Column26"
        Me.Column26.ReadOnly = True
        Me.Column26.Visible = False
        Me.Column26.Width = 125
        '
        'Column25
        '
        Me.Column25.HeaderText = "COrderID"
        Me.Column25.MinimumWidth = 6
        Me.Column25.Name = "Column25"
        Me.Column25.ReadOnly = True
        Me.Column25.Visible = False
        Me.Column25.Width = 125
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 27)
        '
        'toolStripSeparator13
        '
        Me.toolStripSeparator13.Name = "toolStripSeparator13"
        Me.toolStripSeparator13.Size = New System.Drawing.Size(6, 27)
        '
        'toolStripSeparator14
        '
        Me.toolStripSeparator14.Name = "toolStripSeparator14"
        Me.toolStripSeparator14.Size = New System.Drawing.Size(6, 27)
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(8, 34)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(30, 16)
        Me.Label42.TabIndex = 0
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(75, 31)
        Me.TextBox21.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(132, 22)
        Me.TextBox21.TabIndex = 1
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(8, 98)
        Me.Label48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(43, 16)
        Me.Label48.TabIndex = 2
        '
        'TextBox22
        '
        Me.TextBox22.Enabled = False
        Me.TextBox22.Location = New System.Drawing.Point(75, 95)
        Me.TextBox22.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(132, 22)
        Me.TextBox22.TabIndex = 3
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(235, 38)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(56, 16)
        Me.Label50.TabIndex = 4
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(301, 34)
        Me.TextBox24.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(132, 22)
        Me.TextBox24.TabIndex = 5
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(235, 102)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(53, 16)
        Me.Label49.TabIndex = 6
        '
        'TextBox23
        '
        Me.TextBox23.Enabled = False
        Me.TextBox23.Location = New System.Drawing.Point(301, 98)
        Me.TextBox23.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(132, 22)
        Me.TextBox23.TabIndex = 7
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(451, 39)
        Me.Label54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(68, 16)
        Me.Label54.TabIndex = 8
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(525, 36)
        Me.TextBox28.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(132, 22)
        Me.TextBox28.TabIndex = 9
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(459, 103)
        Me.Label53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(65, 16)
        Me.Label53.TabIndex = 10
        '
        'TextBox27
        '
        Me.TextBox27.Enabled = False
        Me.TextBox27.Location = New System.Drawing.Point(525, 100)
        Me.TextBox27.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(132, 22)
        Me.TextBox27.TabIndex = 11
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(685, 43)
        Me.Label52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(73, 16)
        Me.Label52.TabIndex = 12
        '
        'TextBox26
        '
        Me.TextBox26.Enabled = False
        Me.TextBox26.Location = New System.Drawing.Point(775, 39)
        Me.TextBox26.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(132, 22)
        Me.TextBox26.TabIndex = 13
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(685, 107)
        Me.Label51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(57, 16)
        Me.Label51.TabIndex = 14
        '
        'TextBox25
        '
        Me.TextBox25.Enabled = False
        Me.TextBox25.Location = New System.Drawing.Point(775, 100)
        Me.TextBox25.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(132, 22)
        Me.TextBox25.TabIndex = 15
        '
        'TextBox29
        '
        Me.TextBox29.Location = New System.Drawing.Point(935, 41)
        Me.TextBox29.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(103, 22)
        Me.TextBox29.TabIndex = 17
        '
        'TextBox30
        '
        Me.TextBox30.Enabled = False
        Me.TextBox30.Location = New System.Drawing.Point(937, 100)
        Me.TextBox30.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(103, 22)
        Me.TextBox30.TabIndex = 18
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(8, 33)
        Me.Label55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(49, 16)
        Me.Label55.TabIndex = 7
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(72, 23)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox5.TabIndex = 8
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(8, 70)
        Me.Label56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(52, 16)
        Me.Label56.TabIndex = 9
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(72, 66)
        Me.ComboBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox6.TabIndex = 10
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(8, 113)
        Me.Label57.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(52, 16)
        Me.Label57.TabIndex = 11
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(72, 103)
        Me.ComboBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox7.TabIndex = 12
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(324, 32)
        Me.Label60.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(52, 16)
        Me.Label60.TabIndex = 13
        '
        'ComboBox10
        '
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Location = New System.Drawing.Point(388, 22)
        Me.ComboBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox10.TabIndex = 14
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(324, 69)
        Me.Label59.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(52, 16)
        Me.Label59.TabIndex = 15
        '
        'ComboBox9
        '
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Location = New System.Drawing.Point(388, 65)
        Me.ComboBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox9.TabIndex = 16
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(324, 112)
        Me.Label58.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(49, 16)
        Me.Label58.TabIndex = 17
        '
        'ComboBox8
        '
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(388, 102)
        Me.ComboBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox8.TabIndex = 18
        '
        'TextBox31
        '
        Me.TextBox31.Location = New System.Drawing.Point(781, 20)
        Me.TextBox31.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(69, 22)
        Me.TextBox31.TabIndex = 19
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(655, 23)
        Me.Label61.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(109, 16)
        Me.Label61.TabIndex = 20
        '
        'TextBox32
        '
        Me.TextBox32.Location = New System.Drawing.Point(781, 66)
        Me.TextBox32.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(240, 22)
        Me.TextBox32.TabIndex = 21
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(691, 70)
        Me.Label62.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(82, 16)
        Me.Label62.TabIndex = 22
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(793, 92)
        Me.Label64.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(192, 16)
        Me.Label64.TabIndex = 24
        '
        'TextBox33
        '
        Me.TextBox33.Location = New System.Drawing.Point(781, 110)
        Me.TextBox33.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(69, 22)
        Me.TextBox33.TabIndex = 25
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(655, 113)
        Me.Label63.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(103, 16)
        Me.Label63.TabIndex = 26
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LinkLabel1.Location = New System.Drawing.Point(235, 28)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(28, 14)
        Me.LinkLabel1.TabIndex = 27
        Me.LinkLabel1.TabStop = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LinkLabel2.Location = New System.Drawing.Point(261, 28)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(43, 14)
        Me.LinkLabel2.TabIndex = 28
        Me.LinkLabel2.TabStop = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LinkLabel3.Location = New System.Drawing.Point(261, 73)
        Me.LinkLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(43, 14)
        Me.LinkLabel3.TabIndex = 29
        Me.LinkLabel3.TabStop = True
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LinkLabel4.Location = New System.Drawing.Point(235, 73)
        Me.LinkLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(28, 14)
        Me.LinkLabel4.TabIndex = 30
        Me.LinkLabel4.TabStop = True
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LinkLabel6.Location = New System.Drawing.Point(261, 112)
        Me.LinkLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(43, 14)
        Me.LinkLabel6.TabIndex = 31
        Me.LinkLabel6.TabStop = True
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LinkLabel5.Location = New System.Drawing.Point(235, 112)
        Me.LinkLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(28, 14)
        Me.LinkLabel5.TabIndex = 32
        Me.LinkLabel5.TabStop = True
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LinkLabel8.Location = New System.Drawing.Point(580, 30)
        Me.LinkLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(43, 14)
        Me.LinkLabel8.TabIndex = 33
        Me.LinkLabel8.TabStop = True
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LinkLabel7.Location = New System.Drawing.Point(553, 30)
        Me.LinkLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(28, 14)
        Me.LinkLabel7.TabIndex = 34
        Me.LinkLabel7.TabStop = True
        '
        'LinkLabel10
        '
        Me.LinkLabel10.AutoSize = True
        Me.LinkLabel10.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LinkLabel10.Location = New System.Drawing.Point(580, 73)
        Me.LinkLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel10.Name = "LinkLabel10"
        Me.LinkLabel10.Size = New System.Drawing.Size(43, 14)
        Me.LinkLabel10.TabIndex = 35
        Me.LinkLabel10.TabStop = True
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.LinkLabel9.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LinkLabel9.Location = New System.Drawing.Point(553, 73)
        Me.LinkLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(28, 14)
        Me.LinkLabel9.TabIndex = 36
        Me.LinkLabel9.TabStop = True
        '
        'LinkLabel12
        '
        Me.LinkLabel12.AutoSize = True
        Me.LinkLabel12.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LinkLabel12.Location = New System.Drawing.Point(580, 110)
        Me.LinkLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel12.Name = "LinkLabel12"
        Me.LinkLabel12.Size = New System.Drawing.Size(43, 14)
        Me.LinkLabel12.TabIndex = 37
        Me.LinkLabel12.TabStop = True
        '
        'LinkLabel11
        '
        Me.LinkLabel11.AutoSize = True
        Me.LinkLabel11.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LinkLabel11.Location = New System.Drawing.Point(553, 110)
        Me.LinkLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel11.Name = "LinkLabel11"
        Me.LinkLabel11.Size = New System.Drawing.Size(28, 14)
        Me.LinkLabel11.TabIndex = 38
        Me.LinkLabel11.TabStop = True
        '
        'DataGridView7
        '
        Me.DataGridView7.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView7.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView7.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView7.Location = New System.Drawing.Point(4, 19)
        Me.DataGridView7.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView7.Name = "DataGridView7"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView7.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView7.RowHeadersWidth = 51
        Me.DataGridView7.Size = New System.Drawing.Size(1197, 290)
        Me.DataGridView7.TabIndex = 0
        '
        'Column11
        '
        Me.Column11.HeaderText = "Delete"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.Text = "Delete"
        Me.Column11.ToolTipText = "Delete"
        Me.Column11.UseColumnTextForButtonValue = True
        Me.Column11.Width = 50
        '
        'Column14
        '
        Me.Column14.HeaderText = "Pickup Time"
        Me.Column14.MinimumWidth = 6
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 125
        '
        'Column15
        '
        Me.Column15.HeaderText = "ID"
        Me.Column15.MinimumWidth = 6
        Me.Column15.Name = "Column15"
        Me.Column15.Width = 125
        '
        'Column12
        '
        Me.Column12.HeaderText = "Status"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 125
        '
        'Column10
        '
        Me.Column10.HeaderText = "Destination"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "Address"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Crew Name"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Crew ID"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "Driver"
        Me.BindingSource2.DataSource = Me.CMNDataSet2
        '
        'CMNDataSet11
        '
        Me.CMNDataSet11.DataSetName = "CMNDataSet1"
        Me.CMNDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CMNDataSet
        '
        Me.CMNDataSet.DataSetName = "CMNDataSet"
        Me.CMNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CMNDataSet1
        '
        Me.CMNDataSet1.DataSetName = "CMNDataSet"
        Me.CMNDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BusTableAdapter
        '
        Me.BusTableAdapter.ClearBeforeFill = True
        '
        'DriverTableAdapter
        '
        Me.DriverTableAdapter.ClearBeforeFill = True
        '
        'GSTableAdapter
        '
        Me.GSTableAdapter.ClearBeforeFill = True
        '
        'BusTableAdapter1
        '
        Me.BusTableAdapter1.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "bus"
        Me.BindingSource1.DataSource = Me.CMNDataSet11
        '
        'SmsTableAdapter
        '
        Me.SmsTableAdapter.ClearBeforeFill = True
        '
        'DriverTableAdapter1
        '
        Me.DriverTableAdapter1.ClearBeforeFill = True
        '
        'BusTableAdapter2
        '
        Me.BusTableAdapter2.ClearBeforeFill = True
        '
        'BindingSource6
        '
        Me.BindingSource6.DataSource = Me.CMNDataSet2
        Me.BindingSource6.Position = 0
        '
        '_هواتف_عربي___ImportErrorsTableAdapter1
        '
        Me._هواتف_عربي___ImportErrorsTableAdapter1.ClearBeforeFill = True
        '
        'BusTableAdapter3
        '
        Me.BusTableAdapter3.ClearBeforeFill = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 777)
        Me.Controls.Add(Me.ToolStripContainer2)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crew Transportation Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMNDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.tt2.ResumeLayout(False)
        Me.rosterTab.ResumeLayout(False)
        Me.rosterTab.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip7.ResumeLayout(False)
        Me.MenuStrip7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.D1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.groundStaffTab.ResumeLayout(False)
        Me.groundStaffTab.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.MenuStrip5.ResumeLayout(False)
        Me.MenuStrip5.PerformLayout()
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.MenuStrip6.ResumeLayout(False)
        Me.MenuStrip6.PerformLayout()
        CType(Me.D2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.cgsTab.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.driverLinkTab.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.arrivalsRjTab.ResumeLayout(False)
        CType(Me.WebView22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ArrivalsTab.ResumeLayout(False)
        Me.ArrivalsTab.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip5.ResumeLayout(False)
        Me.ToolStrip5.PerformLayout()
        Me.notesTab.ResumeLayout(False)
        Me.notesTab.PerformLayout()
        CType(Me.dgvCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ordersTab.ResumeLayout(False)
        CType(Me.WebView23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.createRosterTab.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.kmRreportTab.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.KMReports.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.orderRecords.ResumeLayout(False)
        Me.orderRecords.PerformLayout()
        Me.reportsTab.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel1.PerformLayout()
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMNDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMNDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMN3DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMNDataSet As TMS.CMNDataSet
    Friend WithEvents BusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BusTableAdapter As TMS.CMNDataSetTableAdapters.busTableAdapter
    Friend WithEvents CMNDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriverTableAdapter As TMS.CMNDataSetTableAdapters.DriverTableAdapter
    Friend WithEvents DriverBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BusBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DriverBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GSBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents CMNDataSet1 As TMS.CMNDataSet
    Friend WithEvents GSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GSTableAdapter As TMS.CMNDataSetTableAdapters.GSTableAdapter
    Friend WithEvents CMNDataSet11BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMNDataSet11 As TMS.CMNDataSet1
    Friend WithEvents BusBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents BusTableAdapter1 As TMS.CMNDataSet1TableAdapters.busTableAdapter
    Friend WithEvents DriverDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMNDataSet2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMNDataSet2 As TMS.CMNDataSet2
    Friend WithEvents SmsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SmsTableAdapter As TMS.CMNDataSet2TableAdapters.smsTableAdapter
    Friend WithEvents NumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SmstxtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DriverTableAdapter1 As TMS.CMNDataSet2TableAdapters.DriverTableAdapter
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents BusTableAdapter2 As TMS.CMNDataSet2TableAdapters.busTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents BindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents CMN3DataSetBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents BindingSource7 As System.Windows.Forms.BindingSource

    Friend WithEvents BindingSource8 As System.Windows.Forms.BindingSource
    Friend WithEvents _هواتف_عربي___ImportErrorsTableAdapter1 As TMS.CMNDataSet2TableAdapters._هواتف_عربي___ImportErrorsTableAdapter
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents tt2 As TabControl
    Friend WithEvents rosterTab As TabPage
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip7 As MenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents صعودونزولToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents نزولToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents صعودToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ALONEBYEMAILToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Public WithEvents D1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents groundStaffTab As TabPage
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MenuStrip5 As MenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MenuStrip4 As MenuStrip
    Friend WithEvents CANCELONCALLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents NoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ShifteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EarlyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EarlyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegularToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EarlyToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents RegularToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MenuStrip6 As MenuStrip
    Friend WithEvents AloneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents D2 As DataGridView
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents cgsTab As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents Label76 As Label
    Friend WithEvents ComboBox13 As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label77 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Label81 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents TextBox44 As TextBox
    Friend WithEvents TextBox45 As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label65 As Label
    Friend WithEvents ComboBox11 As ComboBox
    Friend WithEvents Button24 As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Button20 As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Button21 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label66 As Label
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Button23 As Button
    Friend WithEvents Label33 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button25 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents driverLinkTab As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridView9 As DataGridView
    Friend WithEvents Label75 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents TextBox39 As TextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents D3 As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents arrivalsRjTab As TabPage
    Friend WithEvents ArrivalsTab As TabPage
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Panel6 As Panel
    Public WithEvents DataGridView6 As DataGridView
    Friend WithEvents ToolStrip5 As ToolStrip
    Friend WithEvents ToolStripButton19 As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripButton21 As ToolStripButton
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents ToolStripButton22 As ToolStripButton
    Friend WithEvents ToolStripButton23 As ToolStripButton
    Friend WithEvents notesTab As TabPage
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents DataGridView8 As DataGridView
    Friend WithEvents Column13 As DataGridViewButtonColumn
    Friend WithEvents Column23 As DataGridViewComboBoxColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents Label74 As Label
    Friend WithEvents TextBox42 As TextBox
    Friend WithEvents Label73 As Label
    Friend WithEvents TextBox41 As TextBox
    Friend WithEvents Label72 As Label
    Friend WithEvents TextBox40 As TextBox
    Friend WithEvents Label70 As Label
    Friend WithEvents TextBox38 As TextBox
    Friend WithEvents Label69 As Label
    Friend WithEvents TextBox37 As TextBox
    Friend WithEvents Label68 As Label
    Friend WithEvents TextBox36 As TextBox
    Friend WithEvents TextBox35 As TextBox
    Friend WithEvents TextBox34 As TextBox
    Friend WithEvents D9 As DataGridView
    Friend WithEvents Column32 As DataGridViewTextBoxColumn
    Friend WithEvents Column31 As DataGridViewTextBoxColumn
    Friend WithEvents Column30 As DataGridViewTextBoxColumn
    Friend WithEvents Column29 As DataGridViewTextBoxColumn
    Friend WithEvents Column28 As DataGridViewTextBoxColumn
    Friend WithEvents Column27 As DataGridViewTextBoxColumn
    Friend WithEvents Column26 As DataGridViewTextBoxColumn
    Friend WithEvents Column25 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents toolStripSeparator13 As ToolStripSeparator
    Friend WithEvents toolStripSeparator14 As ToolStripSeparator
    Friend WithEvents Label42 As Label
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents TextBox28 As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents TextBox29 As TextBox
    Friend WithEvents TextBox30 As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label56 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label57 As Label
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents Label60 As Label
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents Label59 As Label
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents Label58 As Label
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents TextBox31 As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents TextBox32 As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents Label63 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents LinkLabel10 As LinkLabel
    Friend WithEvents LinkLabel9 As LinkLabel
    Friend WithEvents LinkLabel12 As LinkLabel
    Friend WithEvents LinkLabel11 As LinkLabel
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents Column11 As DataGridViewButtonColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents WebView22 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents ordersTab As TabPage
    Friend WithEvents WebView23 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents createRosterTab As TabPage
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents FleetTeastBtn As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents RESTORBTN As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents btnroster As Button
    Friend WithEvents txtfleetwatch As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblroster As Label
    Friend WithEvents lblfleetwatch As Label
    Friend WithEvents testtext As TextBox
    Friend WithEvents txtroster As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BusTableAdapter3 As CMNDataSet1TableAdapters.busTableAdapter
    Friend WithEvents dgvCalendar As DataGridView
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents cmbMonth As ToolStripComboBox
    Friend WithEvents cmbYear As ToolStripComboBox
    Friend WithEvents kmRreportTab As TabPage
    Friend WithEvents TreeView2 As TreeView
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents orderRecords As GroupBox
    Friend WithEvents chkSpecial As CheckBox
    Friend WithEvents chkGroundStaff As CheckBox
    Friend WithEvents chkDriver As CheckBox
    Friend WithEvents txtendKm As TextBox
    Friend WithEvents Label78 As Label
    Friend WithEvents txtStartKm As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents cmbDriver As ComboBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents Label37 As Label
    Friend WithEvents txtBusNo As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents txtOrderId As TextBox
    Friend WithEvents Label80 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents Label83 As Label
    Friend WithEvents reportsTab As TabPage
    Friend WithEvents SplitContainer6 As SplitContainer
    Friend WithEvents lblDateOnly As Label
    Friend WithEvents txtDateOnly As DateTimePicker
    Friend WithEvents lblArea As Label
    Friend WithEvents cmbArea As ComboBox
    Friend WithEvents lbltoDate As Label
    Friend WithEvents txtToDate As DateTimePicker
    Friend WithEvents lblFromDate As Label
    Friend WithEvents txtFromDate As DateTimePicker
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents txtKeyword As TextBox
    Friend WithEvents Label87 As Label
    Friend WithEvents lblKeyword As Label
    Friend WithEvents cmbreportType As ComboBox
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrewsBYAreasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EasternAreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WesternAreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllAreasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Refresh As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents KMReports As GroupBox
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents btnExport As Button
    Friend WithEvents cmbReports As ComboBox
    Friend WithEvents Label84 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label85 As Label
    Friend WithEvents dtpto As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents Label86 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents BottomLabel As RichTextBox
    Friend WithEvents arabic As ToolStripMenuItem
End Class
