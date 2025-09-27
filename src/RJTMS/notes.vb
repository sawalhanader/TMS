Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Diagnostics

''' <summary>
''' Form used to create or edit a single note record in the Notes table.
''' Supports creating new notes for a specific date or editing an existing note by Id.
''' </summary>
Public Class noteDetails
    ' Keep the Designer partial (InitializeComponent + Friend WithEvents controls).

    ''' <summary>
    ''' Connection string read from application settings (__My.Settings.remoteDB__).
    ''' </summary>
    Private ReadOnly connStr As String = My.Settings.remoteDB

    ''' <summary>
    ''' Maximum allowed note length to avoid very large payloads and DoS by huge input.
    ''' Adjust to match the database column length (NVARCHAR(MAX) can be -1; pick a reasonable app-side limit).
    ''' </summary>
    Private Const MAX_NOTE_LENGTH As Integer = 4000

    ''' <summary>
    ''' True when the form operates in Edit mode (editing an existing note).
    ''' False when creating a new note.
    ''' </summary>
    Private modeIsEdit As Boolean = False

    ''' <summary>
    ''' When in edit mode, holds the database Id of the note being edited.
    ''' </summary>
    Private editId As Integer = 0

    ''' <summary>
    ''' Constructor used to create a new note pre-populated for a specific date.
    ''' Initializes UI, sets default states and wires necessary event handlers.
    ''' </summary>
    ''' <param name="selectedDate">Date to assign to the new note (time portion is ignored).</param>
    Public Sub New(selectedDate As DateTime)
        InitializeComponent()

        ' Operate in create-new-note mode.
        modeIsEdit = False
        editId = 0

        ' Initialize UI state.
        NoteDateTime.Value = selectedDate.Date
        btnDelete.Enabled = False
        Me.Text = "Create Note"

        ' Default "Important" checkbox state for new notes.
        chkImportant.Checked = False

        ' Wire handlers (safe even if designer also wires them).
        AddHandler btnsave.Click, AddressOf btnsave_Click
        AddHandler btnDelete.Click, AddressOf btndelete_Click
    End Sub

    ''' <summary>
    ''' Constructor used to edit an existing note by Id.
    ''' Loads the existing note data into the form fields.
    ''' </summary>
    ''' <param name="noteId">Database Id of the note to edit.</param>
    Public Sub New(noteId As Integer)
        InitializeComponent()

        ' Validate incoming id to avoid accidental misuse.
        If noteId <= 0 Then
            MessageBox.Show("Invalid note identifier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        modeIsEdit = True
        editId = noteId

        btnDelete.Enabled = True
        Me.Text = "Edit Note"

        AddHandler btnsave.Click, AddressOf btnsave_Click
        AddHandler btnDelete.Click, AddressOf btndelete_Click

        ' Load existing note data from the database.
        LoadNoteById(noteId)
    End Sub

    ''' <summary>
    ''' Loads a note record from the database and populates the UI fields.
    ''' If the record is not found the form is closed.
    ''' </summary>
    ''' <param name="id">Database Id of the note to load.</param>
    Private Sub LoadNoteById(id As Integer)
        If String.IsNullOrWhiteSpace(connStr) Then
            MessageBox.Show("Database is not configured.", "Configuration error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Using cmd As New SqlCommand("SELECT NoteDate, NoteValue, Important FROM Notes WHERE Id = @id", conn)
                    cmd.Parameters.Add(New SqlParameter("@id", SqlDbType.Int) With {.Value = id})
                    cmd.CommandTimeout = 30
                    ' cmd.Prepare() -- Removed

                    Using rdr = cmd.ExecuteReader()
                        If rdr.Read() Then
                            Dim dt = If(IsDBNull(rdr("NoteDate")), DateTime.Today, Convert.ToDateTime(rdr("NoteDate")))
                            NoteDateTime.Value = dt

                            NoteValue.Text = If(IsDBNull(rdr("NoteValue")), String.Empty, rdr("NoteValue").ToString())
                            chkImportant.Checked = If(IsDBNull(rdr("Important")), False, Convert.ToBoolean(rdr("Important")))
                        Else
                            MessageBox.Show("Note not found.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Trace.WriteLine($"[{NameOf(noteDetails)}.LoadNoteById] {ex.ToString()}")
            MessageBox.Show("Failed to load note. See logs for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Save (insert or update) the current note to the database.
    ''' This handler is wired to the Save button click.
    ''' </summary>
    ''' <param name="sender">The source of the event (Save button).</param>
    ''' <param name="e">Event arguments.</param>
    Private Sub btnsave_Click(sender As Object, e As EventArgs)
        Dim dateValue As DateTime = NoteDateTime.Value.Date
        Dim text As String = NoteValue.Text.Trim()
        Dim important As Boolean = chkImportant.Checked

        If String.IsNullOrWhiteSpace(text) Then
            MessageBox.Show("Note is empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If text.Length > MAX_NOTE_LENGTH Then
            MessageBox.Show($"Note is too long. Maximum length is {MAX_NOTE_LENGTH} characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(connStr) Then
            MessageBox.Show("Database is not configured.", "Configuration error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()
                If modeIsEdit Then
                    If editId <= 0 Then
                        MessageBox.Show("Invalid note identifier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    Using cmd As New SqlCommand("UPDATE Notes SET NoteDate = @d, NoteValue = @v, Important = @important WHERE Id = @id", conn)
                        cmd.Parameters.Add(New SqlParameter("@d", SqlDbType.DateTime2) With {.Value = dateValue})
                        cmd.Parameters.Add(New SqlParameter("@v", SqlDbType.NVarChar, MAX_NOTE_LENGTH) With {.Value = text})
                        cmd.Parameters.Add(New SqlParameter("@important", SqlDbType.Bit) With {.Value = important})
                        cmd.Parameters.Add(New SqlParameter("@id", SqlDbType.Int) With {.Value = editId})
                        cmd.CommandTimeout = 30
                        ' cmd.Prepare() -- Removed
                        cmd.ExecuteNonQuery()
                    End Using
                Else
                    Using cmd As New SqlCommand("INSERT INTO Notes (NoteDate, NoteValue, Important) VALUES (@d, @v, @important)", conn)
                        cmd.Parameters.Add(New SqlParameter("@d", SqlDbType.DateTime2) With {.Value = dateValue})
                        cmd.Parameters.Add(New SqlParameter("@v", SqlDbType.NVarChar, MAX_NOTE_LENGTH) With {.Value = text})
                        cmd.Parameters.Add(New SqlParameter("@important", SqlDbType.Bit) With {.Value = important})
                        cmd.CommandTimeout = 30
                        ' cmd.Prepare() -- Removed
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            End Using

            ' Indicate success to the caller and close the dialog.
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            ' Log detailed exception, present generic message to user so internal info isn't leaked.
            Trace.WriteLine($"[{NameOf(noteDetails)}.btnsave_Click] {ex.ToString()}")
            MessageBox.Show("Failed to save note. Please try again or contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>       
    ''' Handler for the Delete button. Prompts for confirmation and then deletes the record.
    ''' Only active when editing an existing note.
    ''' </summary>
    ''' <param name="sender">The source of the event (Delete button).</param>
    ''' <param name="e">Event arguments.</param>
    Private Sub btndelete_Click(sender As Object, e As EventArgs)
        If Not modeIsEdit Then Return

        If editId <= 0 Then
            MessageBox.Show("Invalid note identifier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If MessageBox.Show("Delete this note?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
            Return
        End If

        If String.IsNullOrWhiteSpace(connStr) Then
            MessageBox.Show("Database is not configured.", "Configuration error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Using cmd As New SqlCommand("DELETE FROM Notes WHERE Id = @id", conn)
                    cmd.Parameters.Add(New SqlParameter("@id", SqlDbType.Int) With {.Value = editId})
                    cmd.CommandTimeout = 30
                    ' cmd.Prepare() -- Removed
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Indicate success to the caller and close the dialog.
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Trace.WriteLine($"[{NameOf(noteDetails)}.btndelete_Click] {ex.ToString()}")
            MessageBox.Show("Failed to delete note. Please try again or contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Ensure event handlers are removed when the form is closed to avoid duplicate invocations
    ''' if the form instance is recreated during the lifetime of the application.
    ''' </summary>
    ''' <param name="e">Form closed event arguments.</param>
    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        ' Remove handlers to avoid duplicated calls if form is recreated.
        Try
            RemoveHandler btnsave.Click, AddressOf btnsave_Click
        Catch ex As Exception
            Trace.WriteLine($"[{NameOf(noteDetails)}.OnFormClosed] RemoveHandler btnsave: {ex.ToString()}")
        End Try
        Try
            RemoveHandler btnDelete.Click, AddressOf btndelete_Click
        Catch ex As Exception
            Trace.WriteLine($"[{NameOf(noteDetails)}.OnFormClosed] RemoveHandler btnDelete: {ex.ToString()}")
        End Try
        MyBase.OnFormClosed(e)
    End Sub
End Class