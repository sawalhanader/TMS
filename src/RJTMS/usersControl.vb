Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms

Public Class usersControl

    ' Class to hold role name and its fixed value
    Private Class RoleItem
        Public Property Name As String
        Public Property Value As Integer
        Public Sub New(name As String, value As Integer)
            Me.Name = name
            Me.Value = value
        End Sub
        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    ' Permission mapping dictionary: Key = DB Column, Value = (UserFacingName, Description)
    Private ReadOnly PermissionMap As New Dictionary(Of String, (DisplayName As String, Description As String)) From {
    {"Roster", ("Roster (V)", "permissions to access roster")},
    {"GS", ("Ground Staff (V)", "permissions to access Ground Staff")},
    {"CG", ("Crew & Ground Staff Modification (V)", "permissions to access Crew & Ground Staff Modification")},
    {"BD", ("Bus & Driver (V)", "permissions to access Bus & Driver")},
    {"Arrivals", ("Arrivals (V)", "permissions to access Arrivals")},
    {"Arr", ("Arr (V)", "permissions to access Arr")},
    {"Orders", ("Orders (V)", "permissions to access Orders")},
    {"Note", ("Note (V)", "permissions to access Note")},
    {"uploadRoster", ("Upload Roster (V)", "permissions to upload roster")},
    {"Reports", ("Reports (V)", "permissions to extract report")},
    {"Arabic", ("Arabic (V)", "permissions to switch language")},
    {"GSSDate", ("GSS Date Picker (V)", "permission to use date picker")},
    {"uploadArrival", ("Upload Arrivals (V)", "permission to upload arrivals")},
    {"RFDate", ("FDate (R)", "permissions to modify flight date")},
    {"RPickupTime", ("PickupTime (R)", "permissions to modify flight pick-up time")},
    {"RFlight", ("Flight (R)", "permissions to modify flight")},
    {"RCID", ("CID (R)", "permissions to modify crew ID")},
    {"RBus", ("Bus (R)", "permissions to modify BUS NUMBER")},
    {"RGPSNote", ("GPSNote (R)", "permissions to modify note")},
    {"RBrfTime", ("BrfTime (V)", "permissions to view briefing time")},
    {"RArrTime", ("ArrTime (V)", "permissions to modify/enter crew arrival time")},
    {"RDMnote", ("DMnote (V)", "permissions to modify/enter duty manager note")},
    {"Rlate", ("late (V)", "permissions to view crew late arrival time")},
    {"RCF", ("CF (V)", "permission to view data column")},
    {"RRNum", ("RNum (V)", "permission to view data column")},
    {"Risinsert", ("isinsert (V)", "permission to view data column")},
    {"RRID", ("RID (V)", "permission to view data column")},
    {"RGPSOfficer", ("GPSOfficer (V)", "permission to view data column")},
    {"RDM", ("DM (V)", "permission to view data column")},
    {"RTransOfficer", ("TransOfficer (V)", "permission to view data column")},
    {"RDAtee", ("DAtee (V)", "permission to view data column")},
    {"Area", ("Area (V)", "permission to view data column")},
    {"CMobile", ("CMobile (V)", "permission to view data column")},
    {"gGSID", ("GSID (R)", "permission to alter data column")},
    {"gGSName", ("GSName (R)", "permission to alter data column")},
    {"gPhone", ("Phone (V)", "permission to view data column")},
    {"gAddress", ("Address (R)", "permission to alter data column")},
    {"gShiftText", ("ShiftText (R)", "permission to alter data column")},
    {"gGPSCallTime", ("GPSCallTime (R)", "permission to alter data column")},
    {"gSDate", ("SDate (R)", "permission to alter data column")},
    {"gSenc", ("Senc (V)", "permission to view data column")},
    {"gGPSNote", ("GPSNote (R)", "permission to alter data column")},
    {"gBuss", ("Buss (R)", "permission to alter data column")},
    {"gDriver", ("Driver (R)", "permission to alter data column")},
    {"gArea", ("Area (V)", "permission to view data column")},
    {"gGPSShift", ("GPSShift (V)", "permission to view data column")},
    {"gGPSCaller", ("GPSCaller (V)", "permission to view data column")},
    {"gTransOfficer", ("TransOfficer (V)", "permission to view data column")},
    {"gGSShID", ("GSShID (V)", "permission to view data column")},
    {"KMReport", ("KMReport (V)", "Allows to extract reports* with base report type الاخطاء")},
    {"KMInsert", ("KMInsert (R)", "Allows to insert a record")},
    {"KMReportType", ("KMAdvancedReportTypes (V)", "shows الكل and كيلومترات")},
    {"CreateRoster", ("Create Roster", "generate internal roster files by combining related files.")}
}

    ' ARRPer permissions mapping dictionary
    Private ReadOnly ARRPerMap As New Dictionary(Of String, (DisplayName As String, Description As String)) From {
    {"ID", ("ID (V)", "permission to view ID column")},
    {"ArrID", ("Arrival ID (V)", "permission to view Arrival ID column")},
    {"ADate", ("Arrival Date (V)", "permission to view Arrival Date column")},
    {"ArrTime", ("Arrival Time (V)", "permission to view Arrival Time column")},
    {"Flight", ("Flight (V)", "permission to view Flight column")},
    {"CID", ("CID (V)", "permission to view CID column")},
    {"CEnName", ("Crew English Name (V)", "permission to view Crew English Name column")},
    {"CArName", ("Crew Arabic Name (V)", "permission to view Crew Arabic Name column")},
    {"CAddress", ("Crew Address (V)", "permission to view Crew Address column")},
    {"ShatelBus", ("Shatel Bus (V)", "permission to view Shatel Bus column")},
    {"Bus", ("Bus (V)", "permission to view Bus column")},
    {"Driver", ("Driver (V)", "permission to view Driver column")},
    {"TransOfficerNote", ("Transport Officer Note (V)", "permission to view Transport Officer Note column")},
    {"Area", ("Area (V)", "permission to view Area column")},
    {"CF", ("CF (V)", "permission to view CF column")},
    {"RNum", ("RNum (V)", "permission to view RNum column")},
    {"TransOfficer", ("Transport Officer (V)", "permission to view Transport Officer column")},
    {"Transofficer1", ("Transport Officer 1 (V)", "permission to view Transport Officer 1 column")},
    {"isinserted", ("Is Inserted (V)", "permission to view Is Inserted column")},
    {"DMNote", ("DM Note (V)", "permission to view DM Note column")}
}


    ''' <summary>
    ''' Handles the load event for the usersControl. Initializes roles, user list, and permissions UI.
    ''' </summary>
    Private Sub usersControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate roles
        cmbRole.Items.Clear()
        cmbRole.Items.Add(New RoleItem("Administrator", 3))
        cmbRole.Items.Add(New RoleItem("GPS", 2))
        cmbRole.Items.Add(New RoleItem("DM", 1))
        cmbRole.Items.Add(New RoleItem("Officer", 4))
        cmbRole.Items.Add(New RoleItem("GS", 5))
        cmbRole.SelectedIndex = 0

        ' Setup ListView for Details view with two columns: ID first
        usersList.Clear()
        usersList.View = View.Details
        usersList.Columns.Add("ID", 50)
        usersList.Columns.Add("Name", 200)
        usersList.FullRowSelect = True

        LoadAllUsers()

        ' Create default permissions UI for both tables
        CreatePermissionCheckboxes(grpPermissions, PermissionMap, False)
        CreatePermissionCheckboxes(grpARRPer, ARRPerMap, False)
    End Sub

    ''' <summary>
    ''' Loads all users from the database and populates the usersList ListView.
    ''' </summary>
    Private Sub LoadAllUsers()
        usersList.Items.Clear()
        Using con As New SqlConnection(My.Settings.remoteDB)
            con.Open()
            Dim sql As String = "SELECT ID, Name FROM Userr"
            Using cmd As New SqlCommand(sql, con)
                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    While rdr.Read()
                        Dim lvi As New ListViewItem(rdr("ID").ToString()) ' ID first
                        lvi.SubItems.Add(rdr("Name").ToString())          ' Name second
                        usersList.Items.Add(lvi)
                    End While
                End Using
            End Using
        End Using

        ' Auto-resize columns to fit content
        usersList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    ''' <summary>
    ''' Creates permission checkboxes in the specified group box based on the provided mapping.
    ''' </summary>
    ''' <param name="container">The group box container</param>
    ''' <param name="permissionMapping">The permission mapping dictionary</param>
    ''' <param name="allChecked">If true, all checkboxes are checked by default.</param>
    Private Sub CreatePermissionCheckboxes(container As GroupBox, permissionMapping As Dictionary(Of String, (DisplayName As String, Description As String)), allChecked As Boolean)
        container.Controls.Clear()

        ' Create a tooltip for showing descriptions on hover
        Dim toolTip As New ToolTip With {
            .AutoPopDelay = 5000,
            .InitialDelay = 1000,
            .ReshowDelay = 500,
            .ShowAlways = True
        }

        ' Get column names from the mapping
        Dim col As Integer = 0
        Dim row As Integer = 0
        Dim maxPerColumn As Integer = 15

        For Each kvp In permissionMapping
            Dim colName As String = kvp.Key
            Dim displayName As String = kvp.Value.DisplayName
            Dim description As String = kvp.Value.Description

            Dim cb As New CheckBox With {
                .Name = "cb" & colName,
                .Text = displayName,
                .Checked = allChecked,
                .AutoSize = True,
                .Left = 10 + (col * 200),
                .Top = 10 + (row * 25)
            }

            ' Set tooltip with description
            toolTip.SetToolTip(cb, description)

            container.Controls.Add(cb)

            row += 1
            If row >= maxPerColumn Then
                row = 0
                col += 1
            End If
        Next

        ' Add explanatory labels below the last row of checkboxes
        Dim paddingTop As Integer = 25
        Dim labelLeft As Integer = 20

        Dim maxBottom As Integer = 0
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is CheckBox Then
                If ctrl.Bottom > maxBottom Then maxBottom = ctrl.Bottom
            End If
        Next

        Dim lblAlterData As New Label With {
            .Text = "(R) = Alter Data",
            .AutoSize = True,
            .Left = labelLeft,
            .Top = maxBottom + paddingTop,
            .Font = New Font(Me.Font, FontStyle.Bold)
        }
        Dim lblViewOnly As New Label With {
            .Text = "(V) = View Only",
            .AutoSize = True,
            .Left = labelLeft,
            .Top = lblAlterData.Bottom + 5,
            .Font = New Font(Me.Font, FontStyle.Bold)
        }

        container.Controls.Add(lblAlterData)
        container.Controls.Add(lblViewOnly)
    End Sub

    ''' <summary>
    ''' Loads permission values for a user into the permission checkboxes for both tables.
    ''' </summary>
    ''' <param name="userId">The user ID whose permissions to load.</param>
    Private Sub LoadPermissions(userId As Integer)
        ' Load Permissions table
        LoadPermissionsForTable(userId, "Permissions", grpPermissions, PermissionMap)

        ' Load ARRPer table
        LoadPermissionsForTable(userId, "ARRPer", grpARRPer, ARRPerMap)
    End Sub

    ''' <summary>
    ''' Loads permission values for a specific table into the corresponding group box.
    ''' </summary>
    ''' <param name="userId">The user ID</param>
    ''' <param name="tableName">The table name</param>
    ''' <param name="container">The group box container</param>
    ''' <param name="mapping">The permission mapping</param>
    Private Sub LoadPermissionsForTable(userId As Integer, tableName As String, container As GroupBox, mapping As Dictionary(Of String, (DisplayName As String, Description As String)))
        If container.Controls.Count = 0 Then
            CreatePermissionCheckboxes(container, mapping, False)
        End If

        ' Suspend layout while we change many checkboxes
        container.SuspendLayout()

        Using con As New SqlConnection(My.Settings.remoteDB)
            con.Open()
            Dim sql As String = $"SELECT * FROM {tableName} WHERE ID = @ID"
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@ID", userId)
                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    If rdr.Read() Then
                        For Each colName In mapping.Keys
                            Dim cbName As String = "cb" & colName
                            Dim ctrl = container.Controls.Cast(Of Control)().FirstOrDefault(Function(c) c.Name = cbName)
                            If ctrl IsNot Nothing Then
                                Dim cb = TryCast(ctrl, CheckBox)
                                If cb IsNot Nothing Then
                                    ' Handle case where column might not exist in the result
                                    Try
                                        Dim colValue As Integer = Convert.ToInt32(rdr(colName))
                                        cb.Checked = (colValue = 1)
                                    Catch ex As Exception
                                        ' Column doesn't exist or is null, leave checkbox unchecked
                                        cb.Checked = False
                                    End Try
                                End If
                            End If
                        Next
                    Else
                        ' No record found, uncheck all boxes
                        For Each colName In mapping.Keys
                            Dim cbName As String = "cb" & colName
                            Dim ctrl = container.Controls.Cast(Of Control)().FirstOrDefault(Function(c) c.Name = cbName)
                            If ctrl IsNot Nothing Then
                                Dim cb = TryCast(ctrl, CheckBox)
                                If cb IsNot Nothing Then
                                    cb.Checked = False
                                End If
                            End If
                        Next
                    End If
                End Using
            End Using
        End Using

        ' Resume layout
        container.ResumeLayout(True)
        container.PerformLayout()
    End Sub

    ''' <summary>
    ''' Handles the selection change event for the usersList ListView. Loads user details and permissions.
    ''' </summary>
    Private Sub usersList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usersList.SelectedIndexChanged
        If usersList.SelectedItems.Count = 0 Then Return

        Dim selectedId As Integer
        If Not Integer.TryParse(usersList.SelectedItems(0).SubItems(0).Text, selectedId) Then
            MessageBox.Show("Invalid user ID.")
            Return
        End If

        ' Load user details
        Using con As New SqlConnection(My.Settings.remoteDB)
            con.Open()

            ' Load user info
            Using cmd As New SqlCommand("SELECT Name, Office, per FROM Userr WHERE ID=@ID", con)
                cmd.Parameters.AddWithValue("@ID", selectedId)
                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    If rdr.Read() Then
                        TBID.Text = selectedId.ToString()
                        originalID.Text = selectedId.ToString()
                        TXName.Text = rdr("Name").ToString()
                        TXOffice.Text = rdr("Office").ToString()

                        ' Set role
                        Dim roleValue As Integer = Convert.ToInt32(rdr("per"))
                        For Each item As RoleItem In cmbRole.Items
                            If item.Value = roleValue Then
                                cmbRole.SelectedItem = item
                                Exit For
                            End If
                        Next
                    End If
                End Using
            End Using

            ' Load permissions for both tables
            LoadPermissions(selectedId)
        End Using
        SplitContainer3.Visible = True
        delete.Visible = True
    End Sub

    ''' <summary>
    ''' Handles the text changed event for the Search textbox. Filters the user list based on search text.
    ''' </summary>
    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        Dim searchText As String = Search.Text.Trim()

        If searchText = "" Then
            LoadAllUsers()
            Return
        End If

        usersList.Items.Clear()
        Using con As New SqlConnection(My.Settings.remoteDB)
            con.Open()
            Dim sql As String = "SELECT ID, Name FROM Userr WHERE CAST(ID AS NVARCHAR) LIKE @search OR Name LIKE @search"
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    While rdr.Read()
                        Dim lvi As New ListViewItem(rdr("ID").ToString()) ' ID first
                        lvi.SubItems.Add(rdr("Name").ToString())          ' Name second
                        usersList.Items.Add(lvi)
                    End While
                End Using
            End Using
        End Using

        ' Auto-resize columns to fit content
        usersList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    ''' <summary>
    ''' Handles the click event for the btnLoad button. Creates or updates a user and their permissions.
    ''' </summary>
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ' This button now handles both CREATE (when originalID.Text is empty) and UPDATE (when set)
        Dim isCreatingNew As Boolean = String.IsNullOrWhiteSpace(originalID.Text)

        Dim oldId As Integer = 0
        If Not isCreatingNew Then
            If Not Integer.TryParse(originalID.Text.Trim(), oldId) Then
                MessageBox.Show("Original ID is not valid.")
                Return
            End If
        End If

        ' Read new ID from TBID
        Dim newId As Integer
        If Not Integer.TryParse(TBID.Text.Trim(), newId) Then
            MessageBox.Show("Please enter a valid numeric ID.")
            Return
        End If

        Dim name As String = TXName.Text.Trim()
        Dim office As Integer
        Integer.TryParse(TXOffice.Text.Trim(), office)

        ' Role value
        Dim perValue As Integer = 0
        If cmbRole.SelectedItem IsNot Nothing Then
            Dim ri = TryCast(cmbRole.SelectedItem, RoleItem)
            If ri IsNot Nothing Then perValue = ri.Value
        End If

        ' Collect permissions from both tables
        Dim permCols As New Dictionary(Of String, Integer)
        Dim arrPerCols As New Dictionary(Of String, Integer)

        ' Get Permissions table permissions
        For Each ctrl As Control In grpPermissions.Controls
            Dim cb = TryCast(ctrl, CheckBox)
            If cb Is Nothing Then Continue For
            If Not cb.Name.StartsWith("cb") Then Continue For
            Dim colName As String = cb.Name.Substring(2) ' after "cb"
            permCols(colName) = If(cb.Checked, 1, 0)
        Next

        ' Get ARRPer table permissions
        For Each ctrl As Control In grpARRPer.Controls
            Dim cb = TryCast(ctrl, CheckBox)
            If cb Is Nothing Then Continue For
            If Not cb.Name.StartsWith("cb") Then Continue For
            Dim colName As String = cb.Name.Substring(2) ' after "cb"
            arrPerCols(colName) = If(cb.Checked, 1, 0)
        Next

        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("Name cannot be empty.")
            Return
        End If

        Using con As New SqlConnection(My.Settings.remoteDB)
            con.Open()
            Using tr = con.BeginTransaction()
                Try
                    ' If creating new, ensure ID doesn't exist
                    If isCreatingNew Then
                        Using chkCmd As New SqlCommand("SELECT COUNT(1) FROM Userr WHERE ID = @NewID", con, tr)
                            chkCmd.Parameters.AddWithValue("@NewID", newId)
                            If Convert.ToInt32(chkCmd.ExecuteScalar()) > 0 Then
                                MessageBox.Show($"ID {newId} already exists.")
                                tr.Rollback()
                                Return
                            End If
                        End Using

                        ' INSERT into Userr
                        Using insUser As New SqlCommand("INSERT INTO Userr (ID, Name, Office, per) VALUES (@ID, @Name, @Office, @Per)", con, tr)
                            insUser.Parameters.AddWithValue("@ID", newId)
                            insUser.Parameters.AddWithValue("@Name", name)
                            insUser.Parameters.AddWithValue("@Office", office)
                            insUser.Parameters.AddWithValue("@Per", perValue)
                            insUser.ExecuteNonQuery()
                        End Using

                        ' INSERT into Permissions
                        InsertPermissions(con, tr, newId, permCols, "Permissions")

                        ' INSERT into ARRPer
                        InsertPermissions(con, tr, newId, arrPerCols, "ARRPer")

                        tr.Commit()
                        originalID.Text = newId.ToString()
                    Else
                        ' Updating existing user
                        ' Check for ID conflict if changed
                        If newId <> oldId Then
                            Using chkCmd As New SqlCommand("SELECT COUNT(1) FROM Userr WHERE ID = @NewID", con, tr)
                                chkCmd.Parameters.AddWithValue("@NewID", newId)
                                If Convert.ToInt32(chkCmd.ExecuteScalar()) > 0 Then
                                    MessageBox.Show($"ID {newId} already exists.")
                                    tr.Rollback()
                                    Return
                                End If
                            End Using
                        End If

                        ' Update Userr
                        Using updUser As New SqlCommand("
                        UPDATE Userr 
                        SET ID=@NewID, Name=@Name, Office=@Office, per=@Per 
                        WHERE ID=@OldID", con, tr)

                            updUser.Parameters.AddWithValue("@NewID", newId)
                            updUser.Parameters.AddWithValue("@Name", name)
                            updUser.Parameters.AddWithValue("@Office", office)
                            updUser.Parameters.AddWithValue("@Per", perValue)
                            updUser.Parameters.AddWithValue("@OldID", oldId)

                            If updUser.ExecuteNonQuery() = 0 Then
                                MessageBox.Show("User record not found.")
                                tr.Rollback()
                                Return
                            End If
                        End Using

                        ' Update Permissions table
                        UpdatePermissionsTable(con, tr, oldId, newId, permCols, "Permissions")

                        ' Update ARRPer table
                        UpdatePermissionsTable(con, tr, oldId, newId, arrPerCols, "ARRPer")

                        tr.Commit()
                        originalID.Text = newId.ToString()
                    End If
                Catch ex As Exception
                    tr.Rollback()
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

        ' Refresh the list and optionally select the saved user
        LoadAllUsers()
    End Sub

    ''' <summary>
    ''' Inserts permissions into a permissions table
    ''' </summary>
    Private Sub InsertPermissions(con As SqlConnection, tr As SqlTransaction, userId As Integer, permissions As Dictionary(Of String, Integer), tableName As String)
        If permissions.Count = 0 Then Return

        Dim colNames As New List(Of String) From {"[ID]"}
        Dim paramNames As New List(Of String) From {"@ID"}
        Dim insPerm As New SqlCommand() With {.Connection = con, .Transaction = tr}
        insPerm.Parameters.AddWithValue("@ID", userId)

        For Each kvp In permissions
            colNames.Add("[" & kvp.Key & "]")
            Dim pName = "@p_" & kvp.Key
            paramNames.Add(pName)
            insPerm.Parameters.AddWithValue(pName, kvp.Value)
        Next

        insPerm.CommandText = $"INSERT INTO {tableName} ({String.Join(",", colNames)}) VALUES ({String.Join(",", paramNames)})"
        insPerm.ExecuteNonQuery()
    End Sub

    ''' <summary>
    ''' Updates permissions in a permissions table
    ''' </summary>
    Private Sub UpdatePermissionsTable(con As SqlConnection, tr As SqlTransaction, oldId As Integer, newId As Integer, permissions As Dictionary(Of String, Integer), tableName As String)
        If permissions.Count = 0 Then Return

        Dim permExists As Boolean
        Using chkPerm As New SqlCommand($"SELECT COUNT(1) FROM {tableName} WHERE ID=@OldID", con, tr)
            chkPerm.Parameters.AddWithValue("@OldID", oldId)
            permExists = (Convert.ToInt32(chkPerm.ExecuteScalar()) > 0)
        End Using

        If permExists Then
            ' Build UPDATE
            Dim setParts As New List(Of String)
            Dim updPerm As New SqlCommand() With {.Connection = con, .Transaction = tr}
            For Each kvp In permissions
                Dim pName = "@p_" & kvp.Key
                setParts.Add("[" & kvp.Key & "]=" & pName)
                updPerm.Parameters.AddWithValue(pName, kvp.Value)
            Next
            updPerm.CommandText = $"UPDATE {tableName} SET {String.Join(", ", setParts)}, ID=@NewID WHERE ID=@OldID"
            updPerm.Parameters.AddWithValue("@NewID", newId)
            updPerm.Parameters.AddWithValue("@OldID", oldId)
            updPerm.ExecuteNonQuery()
        Else
            ' Build INSERT
            InsertPermissions(con, tr, newId, permissions, tableName)
        End If
    End Sub

    ''' <summary>
    ''' Handles the Add New User link click event. Resets fields and creates standard permission checkboxes.
    ''' </summary>
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Reset fields
        SplitContainer3.Visible = True
        TXName.Text = String.Empty
        TXOffice.Text = String.Empty
        cmbRole.SelectedIndex = 0
        delete.Visible = False
        ' Keep TBID empty so user enters the employment number
        TBID.Text = String.Empty

        ' Mark as creating new user
        originalID.Text = String.Empty

        ' Create permissions checkboxes and set all checked (standard permissions)
        CreatePermissionCheckboxes(grpPermissions, PermissionMap, True)
        CreatePermissionCheckboxes(grpARRPer, ARRPerMap, True)
    End Sub

    ''' <summary>
    ''' Handles the delete button click event. Deletes the selected user and their permissions from the database.
    ''' </summary>
    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        ' Choose ID to delete: prefer the selected list item, fallback to TBID/originalID
        Dim idToDelete As Integer = 0
        Dim gotId As Boolean = False

        ' Prefer selected item in the listview
        If usersList.SelectedItems.Count > 0 Then
            If Integer.TryParse(usersList.SelectedItems(0).SubItems(0).Text, idToDelete) Then gotId = True
        End If

        ' If not from list, try TBID
        If Not gotId AndAlso Not String.IsNullOrWhiteSpace(TBID.Text) Then
            If Integer.TryParse(TBID.Text.Trim(), idToDelete) Then gotId = True
        End If

        ' If still not found, try originalID
        If Not gotId AndAlso Not String.IsNullOrWhiteSpace(originalID.Text) Then
            If Integer.TryParse(originalID.Text.Trim(), idToDelete) Then gotId = True
        End If

        If Not gotId Then
            MessageBox.Show("No valid user selected to delete.", "Delete user", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm
        Dim resp = MessageBox.Show($"Are you sure you want to permanently delete user ID {idToDelete}?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp <> DialogResult.Yes Then Return

        ' Perform deletion in a transaction
        Try
            Using con As New SqlConnection(My.Settings.remoteDB)
                con.Open()
                Using tr = con.BeginTransaction()
                    Try
                        ' Delete from Permissions table first
                        Using delPerm As New SqlCommand("DELETE FROM Permissions WHERE ID = @ID", con, tr)
                            delPerm.Parameters.AddWithValue("@ID", idToDelete)
                            delPerm.ExecuteNonQuery()
                        End Using

                        ' Delete from ARRPer table
                        Using delARRPer As New SqlCommand("DELETE FROM ARRPer WHERE ID = @ID", con, tr)
                            delARRPer.Parameters.AddWithValue("@ID", idToDelete)
                            delARRPer.ExecuteNonQuery()
                        End Using

                        ' Delete user record
                        Using delUser As New SqlCommand("DELETE FROM Userr WHERE ID = @ID", con, tr)
                            delUser.Parameters.AddWithValue("@ID", idToDelete)
                            Dim affected As Integer = delUser.ExecuteNonQuery()
                            If affected = 0 Then
                                ' No user deleted -> rollback and notify
                                tr.Rollback()
                                MessageBox.Show($"User ID {idToDelete} was not found.", "Delete user", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Return
                            End If
                        End Using

                        tr.Commit()
                    Catch ex As Exception
                        tr.Rollback()
                        MessageBox.Show("Error deleting user: " & ex.Message, "Delete user", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End Try
                End Using
            End Using

            ' Clear fields and refresh list
            TBID.Text = String.Empty
            originalID.Text = String.Empty
            TXName.Text = String.Empty
            TXOffice.Text = String.Empty
            cmbRole.SelectedIndex = 0
            grpPermissions.Controls.Clear()
            grpARRPer.Controls.Clear()
            SplitContainer3.Visible = False

            LoadAllUsers()
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Delete user", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class