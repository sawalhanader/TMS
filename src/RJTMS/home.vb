Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports System.IO.Directory
Imports System.Linq
Imports System.Text
Imports System.Globalization
Imports Gecko.WebIDL
Imports Microsoft.Data.Common
Imports System.Threading.Tasks
Imports System.Diagnostics
Imports Microsoft.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop.Access
Imports Microsoft.Office.Interop.Excel
Imports DataTable = System.Data.DataTable
Imports TMS.CMNDataSet1TableAdapters




Public Class home
    Dim kg As Integer
    Dim kg1 As Integer
    Dim kg2 As Integer
    Dim kg3 As Integer
    Dim kg4 As Integer
    Private currentNotes As DataTable
    Private marqueeSegments As New List(Of KeyValuePair(Of String, Integer))() ' (text, colorIndex) 1=red,2=black
    Private plainMarquee As String = ""
    Private scrollIndex As Integer = 0
    Private visibleLength As Integer = 80
    Private marqueeSpeed As Integer = 90
    Private totalMarqueeLength As Integer = 0 ' Total length without padding
    Private originalMarqueeLength As Integer = 0 ' Length of original content without extensions
    Private dm As New DataTable()
    Public UserName As String
    Public reportslogin As Boolean
    Dim userper As Integer = 0
    Public userid As Integer = 0
    Dim selected As Integer
    Dim d As String
    Dim f As String
    Dim v As String
    Dim apppath As String
    Dim rowind As Integer
    Public cn As New SqlConnection
    Public con As New SqlConnection
    Dim BLinec As Integer
    Dim y As String
    Dim brf As Integer
    Dim dateday22 As String
    Dim area As Integer = 0
    Dim roster As New Data.DataTable
    Public office As Integer
    Dim arrdata As New Data.DataTable
    Dim depdata As New Data.DataTable
    Dim area1 As String = "area1"
    Dim area2 As String = "area2"
    Dim area3 As String = "area3"
    Dim area4 As String = "area4"
    Dim area5 As String = "area5"
    Dim area6 As String = "area6"
    Dim userRname As String
    Dim Dtimezone As Integer = 3
    Dim testdate As String
    Dim KMspecialReports As Boolean
    'KMReporting
    Private cond As Integer = 0
    Private optn As Integer = 0
    Private STK As String = ""
    Private ENK As String = ""
    Private hidForModel As String = ""

    ' load bus locator
    Public Function locator(ByVal loc As String)

        Dim cmt As New SqlCommand
        Dim STtloc As String
        STtloc = "select Locator from locator where busnum = '" & loc & "'"
        Dim dkloc As New SqlDataAdapter(STtloc, cn)
        Dim dmloc As New System.Data.DataTable
        dkloc.Fill(dmloc)
        Process.Start(dmloc.Rows(0).Item(0))

    End Function

    '7th Circle Buses
    Public Function circlebuses()
        Dim SQL17circle As String = "select * from bus where areaa= 3  "
        Dim dnn7 As New SqlDataAdapter(SQL17circle, cn)
        Dim dqq7 As New System.Data.DataTable
        dnn7.Fill(dqq7)
        Dim w7 As Integer = 0
        While w7 <= dqq7.Rows.Count - 1

            DataGridView9.Rows.Add()
            DataGridView9.Item(0, w7).Value = dqq7.Rows(w7).Item("Driver")
            Try
                Dim SQLbuse7 As String = "select BUS from bus where drname = N'" & dqq7.Rows(w7).Item("Driver") & "'"
                Dim dnn7c As New SqlDataAdapter(SQLbuse7, cn)
                Dim dqq7c As New System.Data.DataTable
                dnn7c.Fill(dqq7c)
                DataGridView9.Item(1, w7).Value = dqq7c.Rows(0).Item("Bus")
            Catch ex As Exception

            End Try

            w7 = w7 + 1
        End While

        Dim w8 As Integer = 0
        While w8 <= DataGridView9.RowCount - 1
            If DataGridView9.Item(0, w8).Value = "" Then
                DataGridView9.Rows(w8).Visible = False
            End If
            w8 = w8 + 1
        End While

    End Function

    'apply arr (Arrivals) tab permissions
    Public Function ArrTabPermissions(ByVal ID As Integer)
        Try
            Dim SQLAp As String
            SQLAp = "select * from ARRPer where ID=" & ID & ""
            Dim dnn As New SqlDataAdapter(SQLAp, cn)
            Dim dqq As New System.Data.DataTable
            dnn.Fill(dqq)
            If dqq.Rows(0).Item(1) = 0 Then
                DataGridView6.Columns(0).Visible = False
            Else
                DataGridView6.Columns(0).ReadOnly = True
            End If
            If dqq.Rows(0).Item(2) = 0 Then
                DataGridView6.Columns(1).ReadOnly = True
            End If
            If dqq.Rows(0).Item(3) = 0 Then
                DataGridView6.Columns(2).ReadOnly = True
            End If
            If dqq.Rows(0).Item(4) = 0 Then
                DataGridView6.Columns(3).ReadOnly = True
            End If

            If dqq.Rows(0).Item(5) = 0 Then
                DataGridView6.Columns(4).ReadOnly = True
            End If
            If dqq.Rows(0).Item(6) = 0 Then
                DataGridView6.Columns(5).ReadOnly = True
            End If
            If dqq.Rows(0).Item(7) = 0 Then
                DataGridView6.Columns(6).ReadOnly = True
            End If
            If dqq.Rows(0).Item(8) = 0 Then
                DataGridView6.Columns(7).ReadOnly = True
            End If
            If dqq.Rows(0).Item(9) = 0 Then
                DataGridView6.Columns(8).ReadOnly = True
            End If
            If dqq.Rows(0).Item(10) = 0 Then
                DataGridView6.Columns(9).ReadOnly = True
            End If
            If dqq.Rows(0).Item(11) = 0 Then
                DataGridView6.Columns(10).ReadOnly = True
            End If
            If dqq.Rows(0).Item(12) = 0 Then
                DataGridView6.Columns(11).ReadOnly = True
            End If
            If dqq.Rows(0).Item(13) = 0 Then
                DataGridView6.Columns(12).Visible = False
            Else
                DataGridView6.Columns(12).ReadOnly = True
            End If
            If dqq.Rows(0).Item(14) = 0 Then
                DataGridView6.Columns(13).Visible = False
            Else
                DataGridView6.Columns(13).ReadOnly = True
            End If
            If dqq.Rows(0).Item(15) = 0 Then
                DataGridView6.Columns(14).Visible = False
            Else
                DataGridView6.Columns(14).ReadOnly = True
            End If
            If dqq.Rows(0).Item(16) = 0 Then
                DataGridView6.Columns(15).Visible = False
            Else
                DataGridView6.Columns(15).ReadOnly = True
            End If
            If dqq.Rows(0).Item(17) = 0 Then
                DataGridView6.Columns(16).Visible = False
            Else
                DataGridView6.Columns(16).ReadOnly = True
            End If
            If dqq.Rows(0).Item(18) = 0 Then
                DataGridView6.Columns(17).Visible = False
            Else
                DataGridView6.Columns(17).ReadOnly = True
            End If
            If dqq.Rows(0).Item(19) = 0 Then
                DataGridView6.Columns(18).Visible = False
            Else
                DataGridView6.Columns(18).ReadOnly = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    ' load webdialer helper function
    Public Function LoadWebdialer(ByVal URL As String)
        webDialer.InitializeWebView(URL)
    End Function

    ' apply user permissions for the whole system
    Public Function userPermissions(ByVal ID As Integer)
        'register user activity timestamp
        User()
        Try
            Dim SQLtp As String
            Dim SQLtp2 As String
            tt2.TabPages.Remove(groundStaffTab)
            tt2.TabPages.Remove(ArrivalsTab)

            SQLtp = "select * from Permissions where ID=" & ID & ""
            SQLtp2 = "select per from userr where ID=" & ID & ""
            Dim dnn2 As New SqlDataAdapter(SQLtp2, cn)
            Dim dt As New DataTable()
            dnn2.Fill(dt)
            userper = Convert.ToInt32(dt.Rows(0)("per"))
            Dim dnn As New SqlDataAdapter(SQLtp, cn)
            Dim dqq As New System.Data.DataTable
            dnn.Fill(dqq)
            If dqq.Rows(0).Item(1) = 0 Then
                tt2.TabPages.Remove(rosterTab)
            End If
            If dqq.Rows(0).Item(2) = 0 Then
                tt2.TabPages.Remove(groundStaffTab)
            End If
            If dqq.Rows(0).Item(3) = 0 Then
                tt2.TabPages.Remove(cgsTab)
            End If
            If dqq.Rows(0).Item(4) = 0 Then
                tt2.TabPages.Remove(driverLinkTab)
            End If
            If dqq.Rows(0).Item(5) = 0 Then
                tt2.TabPages.Remove(arrivalsRjTab)
            End If
            If dqq.Rows(0).Item(6) = 0 Then
                tt2.TabPages.Remove(ArrivalsTab)
            End If
            If dqq.Rows(0).Item(7) = 0 Then
                tt2.TabPages.Remove(ordersTab)
            End If
            If dqq.Rows(0).Item(8) = 0 Then
                tt2.TabPages.Remove(notesTab)
            End If
            If dqq.Rows(0).Item(9) = 0 Then
                OpenToolStripMenuItem.Visible = False
                OpenToolStripButton.Visible = False
            End If
            If dqq.Rows(0).Item(10) = 0 Then
                tt2.TabPages.Remove(reportsTab)
            End If
            If dqq.Rows(0).Item(11) = 0 Then
                arabic.Visible = False
            End If
            If dqq.Rows(0).Item(12) = 0 Then
                DateTimePicker1.Visible = False
            End If
            If dqq.Rows(0).Item(13) = 0 Then
                ToolStripButton19.Visible = False
            End If
            If dqq.Rows(0).Item(53) = 0 Then
                tt2.TabPages.Remove(createRosterTab)
            End If
            If dqq.Rows(0).Item(51) = 0 Then
                Dim found() As TreeNode = TreeView2.Nodes.Find("Records", True)
                For Each n As TreeNode In found
                    n.Remove()
                Next
                orderRecords.Visible = False
            End If
            If dqq.Rows(0).Item(50) = 0 Then
                Dim found() As TreeNode = TreeView2.Nodes.Find("Report", True)
                For Each n As TreeNode In found
                    n.Remove()
                Next
                KMReports.Visible = False
            End If
            If dqq.Rows(0).Item(50) = 0 And dqq.Rows(0).Item(51) = 0 Then
                tt2.TabPages.Remove(kmRreportTab)
            End If
            If userper = 3 Then
                UsersManagementToolStripMenuItem.Visible = True
            End If
            If dqq.Rows(0).Item(52) = 1 Then
                KMspecialReports = True
            End If
            kg4 = 1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    ' apply user permissions for roster gridview columns
    Public Function rosterper(ByVal ID As Integer)
        Try
            Dim SQLrper As String
            SQLrper = "select * from Permissions where ID=" & ID & ""
            Dim dnn As New SqlDataAdapter(SQLrper, cn)
            Dim dqq As New System.Data.DataTable
            dnn.Fill(dqq)
            If dqq.Rows(0).Item(14) = 0 Then
                D1.Columns(0).ReadOnly = True
            End If
            If dqq.Rows(0).Item(15) = 0 Then
                D1.Columns(1).ReadOnly = True
            End If
            If dqq.Rows(0).Item(16) = 0 Then
                D1.Columns(2).ReadOnly = True
            End If
            If dqq.Rows(0).Item(17) = 0 Then
                D1.Columns(3).ReadOnly = True
            End If
            If dqq.Rows(0).Item(18) = 0 Then
                D1.Columns(9).ReadOnly = True
            End If
            If dqq.Rows(0).Item(19) = 0 Then
                D1.Columns(11).ReadOnly = True
            End If
            If dqq.Rows(0).Item(20) = 0 Then
                D1.Columns(13).Visible = False
            Else
                D1.Columns(13).ReadOnly = True
            End If
            If dqq.Rows(0).Item(21) = 0 Then
                D1.Columns(14).Visible = False
            End If
            If dqq.Rows(0).Item(22) = 0 Then
                D1.Columns(15).Visible = False
            End If
            If dqq.Rows(0).Item(23) = 0 Then
                D1.Columns(16).Visible = False
            Else
                D1.Columns(16).ReadOnly = True
            End If
            If dqq.Rows(0).Item(24) = 0 Then
                D1.Columns(17).Visible = False
            Else
                D1.Columns(17).ReadOnly = True
            End If
            If dqq.Rows(0).Item(25) = 0 Then
                D1.Columns(18).Visible = False
            Else
                D1.Columns(18).ReadOnly = True
            End If
            If dqq.Rows(0).Item(26) = 0 Then
                D1.Columns(19).Visible = False
            Else
                D1.Columns(19).ReadOnly = True
            End If
            If dqq.Rows(0).Item(27) = 0 Then
                D1.Columns(20).Visible = False
            Else
                D1.Columns(20).ReadOnly = True
            End If
            If dqq.Rows(0).Item(28) = 0 Then
                D1.Columns(21).Visible = False
            Else
                D1.Columns(21).ReadOnly = True
            End If
            If dqq.Rows(0).Item(29) = 0 Then
                D1.Columns(22).Visible = False
            Else
                D1.Columns(22).ReadOnly = True
            End If
            If dqq.Rows(0).Item(30) = 0 Then
                D1.Columns(23).Visible = False
            Else
                D1.Columns(23).ReadOnly = True
            End If
            If dqq.Rows(0).Item(31) = 0 Then
                D1.Columns(24).Visible = False
            Else
                D1.Columns(24).ReadOnly = True
            End If
            If dqq.Rows(0).Item(32) = 0 Then
                D1.Columns(12).Visible = False
            Else
                D1.Columns(12).ReadOnly = True
            End If
            If dqq.Rows(0).Item(33) = 0 Then
                D1.Columns(5).Visible = False
            Else
                D1.Columns(5).ReadOnly = True
            End If
        Catch ex As Exception
        End Try
    End Function

    ' apply user permissions for ground staff Tab
    Public Function GSper(ByVal ID As Integer)
        Try
            Dim SQLgsper As String
            SQLgsper = "select * from Permissions where ID=" & ID & ""
            Dim dnn As New SqlDataAdapter(SQLgsper, cn)
            Dim dqq As New System.Data.DataTable
            dnn.Fill(dqq)
            If dqq.Rows(0).Item(34) = 0 Then
                D2.Columns(0).ReadOnly = True
            End If
            If dqq.Rows(0).Item(35) = 0 Then
                D2.Columns(1).ReadOnly = True
            End If
            If dqq.Rows(0).Item(36) = 0 Then
                D2.Columns(2).Visible = False
            Else
                D2.Columns(2).ReadOnly = True
            End If
            If dqq.Rows(0).Item(37) = 0 Then
                D2.Columns(3).ReadOnly = True
            End If
            If dqq.Rows(0).Item(38) = 0 Then
                D2.Columns(4).ReadOnly = True
            End If
            If dqq.Rows(0).Item(39) = 0 Then
                D2.Columns(5).ReadOnly = True
            End If
            If dqq.Rows(0).Item(40) = 0 Then
                D2.Columns(6).ReadOnly = True
            End If
            If dqq.Rows(0).Item(41) = 0 Then
                D2.Columns(7).Visible = False
            Else
                D2.Columns(7).ReadOnly = True
            End If
            If dqq.Rows(0).Item(42) = 0 Then
                D2.Columns(8).ReadOnly = True
            End If
            If dqq.Rows(0).Item(43) = 0 Then
                D2.Columns(9).ReadOnly = True
            End If
            If dqq.Rows(0).Item(44) = 0 Then
                D2.Columns(10).ReadOnly = True
            End If
            If dqq.Rows(0).Item(45) = 0 Then
                D2.Columns(11).Visible = False
            Else
                D2.Columns(11).ReadOnly = True
            End If
            If dqq.Rows(0).Item(46) = 0 Then
                D2.Columns(12).Visible = False
            Else
                D2.Columns(12).ReadOnly = True
            End If
            If dqq.Rows(0).Item(47) = 0 Then
                D2.Columns(13).Visible = False
            Else
                D2.Columns(13).ReadOnly = True
            End If
            If dqq.Rows(0).Item(48) = 0 Then
                D2.Columns(14).Visible = False
            Else
                D2.Columns(14).ReadOnly = True
            End If
            If dqq.Rows(0).Item(49) = 0 Then
                D2.Columns(15).Visible = False
            Else
                D2.Columns(15).ReadOnly = True
            End If
        Catch ex As Exception
        End Try
    End Function

    ' drivers search function
    Public Function driver()
        Try
            Dim SQL1 As String
            Dim SQL2 As String
            D3.Rows.Clear()

            SQL1 = "select * from driver where Driver like N'%" & TextBox39.Text & "%'"

            Dim dnn As New SqlDataAdapter(SQL1, cn)
            Dim dqq As New System.Data.DataTable
            dnn.Fill(dqq)
            Dim w As Integer = 0
            While w <= dqq.Rows.Count - 1
                D3.Rows.Add()

                D3.Item(0, w).Value = dqq.Rows(w).Item("Driver")
                'D3.Item(1, i).Value = dq.Rows(i).Item("Name")
                Try
                    SQL2 = "select BUS from bus where drname = N'" & dqq.Rows(w).Item("Driver") & "'"

                    Dim dnn1 As New SqlDataAdapter(SQL2, cn)
                    Dim dqq1 As New System.Data.DataTable
                    dnn1.Fill(dqq1)
                    D3.Item(1, w).Value = dqq1.Rows(0).Item("Bus")
                Catch ex As Exception
                End Try
                w = w + 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    ' send email function for ground staff tab
    Public Function sendmailGFS(ByVal ID As Integer, ByVal ccname As String)

        Try
            Dim g As Date = System.DateTime.Now.ToShortDateString
            ' MessageBox.Show(g)
            ' Dim cm As New OleDbCommand
            Dim ol As New Outlook.Application()
            Dim ns As Outlook.NameSpace
            Dim fdMail As Outlook.MAPIFolder
            ns = ol.GetNamespace("MAPI")
            ns.Logon(, , True, True)

            'creating a new MailItem object
            Dim newMail As Outlook.MailItem

            'gets defaultfolder for my Outlook Outbox
            fdMail = ns.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderOutbox)

            'assign values to the newMail MailItem
            newMail = fdMail.Items.Add(Outlook.OlItemType.olMailItem)
            newMail.Subject = "Pickup Notification"
            Dim msg As String
            Dim sig1 As String = "<font>Regards, </font><br><br>"
            Dim sig2 As String = "<font >Transportation Control Room </font><br>"
            Dim sig3 As String = "<font >AIRPORT SERVICES </font><br>"
            Dim sig4 As String = "<font >Tel : +962-6-4793660 </font><br>"
            Dim sig5 As String = "<font >Email: TCR@rj.com </font><br>"
            Dim sig6 As String = "<font '>Queen Alia International Airport </font><br>"
            Dim sig7 As String = "<font >Amman, Jordan </font><br>"
            Dim sig8 As String = "<font color=" & Chr(34) & "#ff0000" & Chr(34) & ">www.rj.com </font><br>"
            msg = "<font >Dear <br> <br> please contact transportation control room ASAP on 064793660</font><br><br><br><br>"
            newMail.HTMLBody = msg & sig1 & sig2 & sig3 & sig4 & sig5 & sig6 & sig7 & sig8
            ' newMail.Body = "Dear <br> <br> please contact rj control room ASAP on 064793660"
            newMail.To = ID & "@rj.com"
            newMail.CC = "TCR@rj.com"
            '  newMail.CC = "crew.scheduling@rj.com"
            newMail.SentOnBehalfOfName = "TCR@rj.com"
            ' newMail.To = "nader.sawalha@rj.com"
            newMail.SaveSentMessageFolder = fdMail
            Dim result As DialogResult = MessageBox.Show("To proceed sending pickup notification email to " & ccname & " please press yes", "", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                newMail.Send()
                '  Unicode Character “✉”
                D2.CurrentRow.Cells(1).Value = D2.CurrentRow.Cells(1).Value + " (✉)"
                Dim cmemail As New SqlCommand
                Dim Sqmemail As String
                Sqmemail = "update FullRoster set CEnName=N'" & D2.CurrentRow.Cells(1).Value & "' where RID=" & D2.CurrentRow.Cells(15).Value
                cmemail = New SqlCommand(Sqmemail, cn)
                cmemail.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    ' send email function for roster tab
    Public Function sendmail(ByVal ID As Integer, ByVal ccname As String)
        Try
            Dim g As Date = System.DateTime.Now.ToShortDateString
            ' MessageBox.Show(g)
            ' Dim cm As New OleDbCommand
            Dim ol As New Outlook.Application()
            Dim ns As Outlook.NameSpace
            Dim fdMail As Outlook.MAPIFolder
            ns = ol.GetNamespace("MAPI")
            ns.Logon(, , True, True)
            'creating a new MailItem object
            Dim newMail As Outlook.MailItem
            'gets defaultfolder for my Outlook Outbox
            fdMail = ns.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderOutbox)
            'assign values to the newMail MailItem
            newMail = fdMail.Items.Add(Outlook.OlItemType.olMailItem)
            newMail.Subject = "Pickup Notification"
            Dim msg As String
            Dim sig1 As String = "<font>Regards, </font><br><br>"
            Dim sig2 As String = "<font >Transportation Control Room </font><br>"
            Dim sig3 As String = "<font >AIRPORT SERVICES </font><br>"
            Dim sig4 As String = "<font >Tel : +962-6-4793660 </font><br>"
            Dim sig5 As String = "<font >Email: TCR@rj.com </font><br>"
            Dim sig6 As String = "<font '>Queen Alia International Airport </font><br>"
            Dim sig7 As String = "<font >Amman, Jordan </font><br>"
            Dim sig8 As String = "<font color=" & Chr(34) & "#ff0000" & Chr(34) & ">www.rj.com </font><br>"
            msg = "<font >Dear <br> <br> please contact transportation control room ASAP on 064793660</font><br><br><br><br>"
            newMail.HTMLBody = msg & sig1 & sig2 & sig3 & sig4 & sig5 & sig6 & sig7 & sig8
            newMail.To = ID & "@rj.com"
            newMail.CC = "TCR@rj.com;crew.scheduling@rj.com;Performance@rj.com"
            newMail.SentOnBehalfOfName = "TCR@rj.com"
            newMail.SaveSentMessageFolder = fdMail
            Dim result As DialogResult = MessageBox.Show("To proceed sending pickup notification email to " & ccname & " please press yes", "", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                newMail.Send()
                D1.CurrentRow.Cells(4).Value = D1.CurrentRow.Cells(4).Value + " (✉)"
                Dim cmemail As New SqlCommand
                Dim Sqmemail As String
                Sqmemail = "update FullRoster set CEnName=N'" & D1.CurrentRow.Cells(4).Value & "' where RID=" & D1.CurrentRow.Cells(20).Value
                cmemail = New SqlCommand(Sqmemail, cn)
                cmemail.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    ' centrelized error log helper function
    Public Function ErrorLog(ByVal ErrorText As String)
        Try
            Dim newerror As New SqlCommand
            newerror.Connection = cn
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dim msg As String
            msg = ErrorText
            msg = msg.Replace("'", "*")
            newerror.CommandText = "insert into errorlog values ( N'" & System.DateTime.Now & "'," & UserName & ",N'" & msg & "')"
            newerror.ExecuteNonQuery()
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
    End Function

    ' release com object helper function
    Public Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

    ' update user last active time REVIEW TO CALL IT ON APP LAUCH 
    Public Function User() As Boolean
        Try

            Dim cmj As New SqlCommand
            Dim STu As String
            STu = "update Userr set ttime='" & System.DateTime.Now.ToString & "' where ID='" & UserName & "'"
            cmj = New SqlCommand(STu, cn)
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            cmj.ExecuteNonQuery()
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
    End Function

    ' search function for roster tab
    Public Function finds(ByVal StrSearchString As String, ByVal D1 As DataGridView) As Boolean
        Try

            Dim intcount As Integer = 0
            For Each Row As DataGridViewRow In D1.Rows
                If D1.Rows(intcount).Cells(3).Value.ToString = StrSearchString.ToString Then
                    finds = True
                    rowind = intcount
                    Exit Function
                End If
                intcount += 1
            Next Row
            finds = False

        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
    End Function

    ' call number function
    Public Function callnum() As Boolean
        Try

            If D1.CurrentCell.ColumnIndex = 5 Then
                webDialer.Close()
                Dim SelectedThings As String = D1.CurrentCell.Value
                SelectedThings = SelectedThings.Replace(" ", "")
                Dim k As Integer = D1.CurrentCell.RowIndex
                D1.BeginEdit(True)
                D1(8, k).Value = D1(8, k).Value + " (" + System.DateTime.Now.ToShortTimeString.ToString + ") "
                D1.Rows(k).DefaultCellStyle.BackColor = Color.LightBlue
                D1.EndEdit(True)
                If SelectedThings.Length = 9 Then
                    LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=90" & SelectedThings & "")
                ElseIf SelectedThings.Length = 7 Then
                    LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=9" & SelectedThings & "")
                End If
            End If
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
            MessageBox.Show("NO Mobile Number To Call")
        End Try
        Me.Focus()
    End Function

    ' get driver name assigned to the bus
    Public Function DriverBus() As Boolean
        Dim cmt As New SqlCommand
        Dim STt As String
        Try
            Dim k As String = D1.CurrentCell.Value
            Dim j As Integer = D1.CurrentCell.RowIndex
            If D1(9, j).Value = "" Then
                D1(10, j).Value = ""
            End If
            STt = "select * from bus where Buss = '" & D1(9, j).Value & "'"
            Dim dk As New SqlDataAdapter(STt, cn)
            Dim dm As New System.Data.DataTable
            dk.Fill(dm)
            D1.BeginEdit(True)
            D1(10, j).Value = dm.Rows(0).Item("drname")
            D1.EndEdit()
            Exit Function
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        D1.Refresh()
    End Function

    ' calculate crew briefing time function
    Public Function brft(ByVal roi As Integer) As String
        Dim brfne As String
        If Convert.ToDateTime(D1(1, roi).Value.ToString) >= Convert.ToDateTime("6:00:00 Am") And Convert.ToDateTime(D1(1, roi).Value.ToString) <= Convert.ToDateTime("9:00:00 pm") Then
            brfne = Convert.ToDateTime(D1(1, roi).Value.ToString).AddMinutes(+120).ToShortTimeString
        Else
            brfne = Convert.ToDateTime(D1(1, roi).Value.ToString).AddMinutes(+90).ToShortTimeString
        End If
        Return (brfne)
    End Function

    ' search function for ground staff tab
    Public Function FindGS(ByVal StrSearchString As String, ByVal D1 As DataGridView, ByVal w As Integer, ByVal rr As Integer) As Boolean
        Try
            Dim intcount As Integer = 0
            D2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            For intcount = 0 To D2.Rows.Count
                If D2.Rows(intcount).Cells(1).Value.ToString.Contains(StrSearchString) Then
                    D2.FirstDisplayedScrollingRowIndex = intcount
                    D2.Rows(intcount).Selected = True
                    Exit Function
                End If
            Next
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        rosterSearch.Label2.Visible = True
        rosterSearch.Label2.Text = "NO Record Was Found"
        rosterSearch.TextBox1.SelectAll()
    End Function

    ' search function for roster tab
    Public Function Find(ByVal StrSearchString As String, ByVal D1 As DataGridView, ByVal w As Integer, ByVal rr As Integer) As Boolean
        Try
            Dim intcount As Integer = 0
            D1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            For intcount = 0 To D1.Rows.Count - 1
                If D1.Rows(intcount).Cells(6).Value.ToString.Contains(StrSearchString) Then
                    D1.FirstDisplayedScrollingRowIndex = intcount
                    D1.Rows(intcount).Selected = True
                    D1.Rows(intcount).Cells(5).Selected = True
                    Exit Function
                End If
            Next
            Find = False
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        rosterSearch.Label2.Visible = True
        rosterSearch.Label2.Text = "NO Record Was Found"
        rosterSearch.TextBox1.SelectAll()
    End Function

    ' search function for roster tab
    Public Function Finde(ByVal StrSearchString As String, ByVal D1 As DataGridView) As Boolean
        Try
            D1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Dim intcount As Integer = 0
            For Each Row As DataGridViewRow In D1.Rows
                If D1.Rows(intcount).Cells(3).Value.ToString = StrSearchString.ToString Then
                    D1.FirstDisplayedScrollingRowIndex = intcount
                    D1.Rows(intcount).Selected = True
                    D1.Rows(intcount).Cells(5).Selected = True
                    Finde = True
                    Exit Function
                End If
                intcount += 1
            Next Row
            Finde = False
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
            rosterSearch.Label2.Visible = True
            rosterSearch.Label2.Text = "NO Record Was Found'"
        End Try
        rosterSearch.TextBox1.SelectAll()
    End Function

    ' search function for roster tab by flight number
    Public Function FindeFLIGHT(ByVal StrSearchString As String, ByVal D1 As DataGridView) As Boolean
        Try
            D1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Dim intcount As Integer = 0
            For Each Row As DataGridViewRow In D1.Rows
                If D1.Rows(intcount).Cells(2).Value.ToString.Contains(StrSearchString.ToString) Then
                    D1.FirstDisplayedScrollingRowIndex = intcount
                    D1.Rows(intcount).Selected = True
                    FindeFLIGHT = True
                    Exit Function
                End If
                intcount += 1
            Next Row
            FindeFLIGHT = False
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
            rosterSearch.Label2.Visible = True
            rosterSearch.Label2.Text = "NO Record Was Found'"
        End Try
    End Function

    ' search function for ground staff tab by flight number
    Public Function FindeGS(ByVal StrSearchString As String, ByVal D1 As DataGridView) As Boolean
        Try
            D2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Dim intcount As Integer = 0
            For Each Row As DataGridViewRow In D2.Rows
                If D2.Rows(intcount).Cells(0).Value.ToString = StrSearchString.ToString Then
                    D2.FirstDisplayedScrollingRowIndex = intcount
                    D2.Rows(intcount).Selected = True
                    FindeGS = True
                    Exit Function
                End If
                intcount += 1
            Next Row
            FindeGS = False
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
            rosterSearch.Label2.Visible = True
            rosterSearch.Label2.Text = "NO Record Was Found'"
        End Try
        rosterSearch.TextBox1.SelectAll()
    End Function

    ' load roster from excel function
    Public Sub OPen(ByVal D1 As DataGridView, ByVal apppath As String)
        kg = 0
        Dim conConn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & apppath & ";Extended Properties=""Excel 12.0 Xml;HDR=YES""")
        conConn.Open()
        Dim strSql As String = "select DATE,Time,Flight,ID,NAME from [roster$]"
        Dim da As New OleDb.OleDbDataAdapter(strSql, conConn)
        Dim dt As New System.Data.DataTable
        da.Fill(dt)
        Dim Rdate As String
        Rdate = dt.Rows(0).Item("DATE")
        Dim NotNew As String
        NotNew = "*"
        Try
            Dim getFullRDD As New SqlCommand
            getFullRDD.CommandText = "Select FDate from FullRoster where FDate = N'" & Rdate & "'and RNum =1"
            getFullRDD.Connection = cn
            NotNew = getFullRDD.ExecuteScalar
        Catch ex As Exception

        End Try
        Dim cnnOLEDB As New OleDb.OleDbConnection
        Dim cmdOLEDB As New OleDbCommand
        Dim SQL As String
        D1.Columns.Add(0, "Date")
        D1.Columns.Add(1, "Time")
        D1.Columns.Add(2, "Flight")
        D1.Columns.Add(3, "ID")
        D1.Columns.Add(4, "Name")
        D1.Columns(0).ReadOnly = True
        D1.Columns(1).ReadOnly = True
        D1.Columns(2).ReadOnly = True
        D1.Columns(4).ReadOnly = True
        D1.Columns.Add(5, "Phone")
        D1.Columns(5).ReadOnly = True
        D1.Columns.Add(6, " Arabic Name")
        D1.Columns(6).ReadOnly = True
        D1.Columns.Add(7, "Address")
        D1.Columns(7).ReadOnly = True
        D1.Columns.Add(8, "timec")
        D1.Columns(8).ReadOnly = True
        D1.Columns.Add(9, "BUS")
        D1.Columns.Add(10, "Driver")
        D1.Columns(10).ReadOnly = True
        D1.Columns.Add(11, "Note")
        D1.Columns.Add(12, "Area")
        D1.Columns.Add(13, "BRF")
        D1.Columns(13).ReadOnly = True
        D1.Columns.Add(14, "ArTime")
        D1.Columns.Add(15, "DMnote")
        D1.Columns.Add(16, "Late")
        D1.Columns.Add(17, "CF")
        D1.Columns.Add(18, "RNum")
        D1.Columns.Add(19, "isinsert")
        D1.Columns.Add(20, "RID")
        D1.Columns.Add(21, "GPSofficer")
        D1.Columns.Add(22, "DM")
        D1.Columns.Add(23, "Transofficer")
        D1.Columns(12).Visible = False
        D1.Columns(5).DefaultCellStyle.Font = New System.Drawing.Font("Arial", 14, FontStyle.Bold)
        D1.Columns(6).DefaultCellStyle.Font = New System.Drawing.Font("Arial", 12, FontStyle.Bold)
        D1.Columns(6).DefaultCellStyle.ForeColor = Color.Red
        Dim ix As Integer = 0
        While ix <= dt.Rows.Count - 1
            D1.Rows.Add()
            D1.Item(3, ix).Value = dt.Rows(ix).Item("ID")
            D1.Item(4, ix).Value = dt.Rows(ix).Item("NAME")
            D1.Item(0, ix).Value = dt.Rows(ix).Item("Date")
            D1.Item(1, ix).Value = dt.Rows(ix).Item("Time")
            D1.Item(2, ix).Value = dt.Rows(ix).Item("Flight")
            If ix = 0 Then
                D1.Item(17, ix).Value = 1
            ElseIf D1.Item(2, ix).Value.ToString <> D1.Item(2, ix - 1).Value.ToString And D1.Item(0, ix).Value.ToString = D1.Item(0, ix - 1).Value.ToString Then
                D1.Item(17, ix).Value = 1
            Else
                D1.Item(0, ix).Value = D1.Item(0, ix - 1).Value
                D1.Item(1, ix).Value = D1.Item(1, ix - 1).Value
                D1.Item(2, ix).Value = D1.Item(2, ix - 1).Value
                D1.Item(17, ix).Value = 0
            End If
            ix = ix + 1
        End While
        Dim i As Integer = 0
        While i <= D1.RowCount - 2
            Try
                SQL = "select * from mobile where id= " & D1(3, i).Value
                Dim dn As New SqlDataAdapter(SQL, cn)
                Dim dq As New System.Data.DataTable
                dn.Fill(dq)
                Dim yy As String = dq.Rows(0).Item("Name").ToString.Replace("ـ", "")
                D1.Item(5, i).Value = dq.Rows(0).Item("Phone")
                D1.Item(6, i).Value = yy.Replace("*", "")
                D1.Item(7, i).Value = dq.Rows(0).Item("HomeAddress")
                D1.Item(12, i).Value = dq.Rows(0).Item("areaa")
                If dq.Rows(0).Item("areaa") = 3 Then
                    D1.Rows(i).DefaultCellStyle.BackColor = Color.Tan
                    D1(11, i).Value = "Alone"
                End If
                y = D1.Rows(i).Cells(0).Value
                If y.Replace(" ", "") = "" Then
                    D1(13, i).Value = Convert.ToDateTime(D1(13, i - 1).Value).ToShortTimeString
                Else
                    If D1(2, i).Value.ToString.Contains("dep ") Then
                        Dim dep As String = D1(2, i).Value.ToString.Substring(D1(2, i).Value.ToString.IndexOf("p") + 2, 5)
                        Dim brftt As String = Convert.ToDateTime(dep).AddMinutes(-90).ToShortTimeString
                        D1(13, i).Value = brftt
                    Else
                        If Convert.ToDateTime(D1(1, i).Value).ToShortTimeString >= "4:30 AM" And Convert.ToDateTime(D1(1, i).Value).ToShortTimeString <= "9:30 PM" Then
                            D1(13, i).Value = Convert.ToDateTime(D1(1, i).Value).AddMinutes(+120).ToShortTimeString
                        Else
                            D1(13, i).Value = Convert.ToDateTime(D1(1, i).Value).AddMinutes(+90).ToShortTimeString
                        End If
                    End If
                End If
            Catch ex As Exception
                D1.Item(5, i).Value = "No Data"
                D1.Item(6, i).Value = "No Data"
                D1.Item(7, i).Value = "No Data"
                D1.Item(8, i).Value = ""
                D1.Item(9, i).Value = ""
                D1.Item(10, i).Value = ""
                D1.Item(11, i).Value = ""
                D1.Item(12, i).Value = 10
                If y.Replace(" ", "") = "" Then
                    D1(13, i).Value = Convert.ToDateTime(D1(13, i - 1).Value).ToShortTimeString
                Else
                    D1.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                    brf = D1(2, i).Value.ToString.IndexOf("p")
                End If
                ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
            End Try
            i = i + 1
        End While
        cn.Close()
        Dim ins As Integer = 0
        Dim dat As String
        Dim tim As String
        Dim fli As String
        Dim CF As Integer
        Dim rname As String
        If NotNew = "" Then
            While ins <= D1.RowCount - 1
                Try
                    rname = D1(4, ins).Value.Replace("'", "")
                    Dim cmins As New SqlCommand
                    cmins.Connection = cn
                    If cn.State = ConnectionState.Closed Then
                        cn.Open()
                    End If
                    Dim newerror As New SqlCommand
                    newerror.Connection = cn
                    newerror.CommandText = "set dateformat dmy"
                    newerror.ExecuteNonQuery()
                    Dim datee As Date = Convert.ToDateTime(D1(0, ins).Value).ToLongDateString
                    cmins.CommandText = " insert into FullRoster values(N'" & D1(0, ins).Value & "',N'" & D1(1, ins).Value & "',N'" & D1(2, ins).Value & "'," & D1(3, ins).Value & ",N'" & rname & "',N'" & D1(5, ins).Value & "',N'" & D1(6, ins).Value & "',N'" & D1(7, ins).Value & "',N'" & D1(8, ins).Value & "',N'" & D1(9, ins).Value & "',N'" & D1(10, ins).Value & "',N'" & D1(11, ins).Value & "'," & D1(12, ins).Value & ",N'" & D1(13, ins).Value & "',N'" & D1(14, ins).Value & "',N'" & D1(15, ins).Value & "',N'00:00:00'," & D1(17, ins).Value & "," & ins & ",0,0,0,0,'" & Convert.ToDateTime(D1(0, ins).Value) & "')"
                    cmins.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                ins = ins + 1
            End While
            Dim upbrf As New SqlCommand
            upbrf.Connection = cn
            upbrf.CommandText = "Select"
            D1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            D1.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            D1.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            D1.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            D1.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            D1.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
            D1.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
            D1.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
            D1.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
            D1.Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
            D1.Columns(10).SortMode = DataGridViewColumnSortMode.NotSortable
            D1.Columns(11).SortMode = DataGridViewColumnSortMode.NotSortable
            If userid = 1 Then
                D1.Columns(5).Visible = False
                D1.Columns(3).ReadOnly = True
                D1.Columns(11).ReadOnly = True
                D1.Columns(9).ReadOnly = True
            End If
            Dim br As Integer = D1(2, 4).Value.ToString.IndexOf("p")
            br += 1
            If userper = 1 Then
                D1.Columns(5).Visible = False
                D1.Columns(3).ReadOnly = True
                D1.Columns(11).ReadOnly = True
                D1.Columns(9).ReadOnly = True
                D1.Columns(10).ReadOnly = True
                D1.Columns(16).Visible = False
                D1.Columns(18).Visible = False
                D1.Columns(17).Visible = False
                D1.Columns(19).Visible = False
                D1.Columns(20).Visible = False
                D1.Columns(21).Visible = False
                D1.Columns(22).Visible = False
                D1.Columns(23).Visible = False
            ElseIf userper = 2 Then
                DateTimePicker1.Visible = True
                D1.Columns(9).ReadOnly = True
                D1.Columns(10).ReadOnly = True
                D1.Columns(12).Visible = False
                D1.Columns(13).Visible = True
                D1.Columns(14).Visible = True
                D1.Columns(15).Visible = True
                D1.Columns(18).Visible = False
                D1.Columns(17).Visible = False
                D1.Columns(16).Visible = False
                D1.Columns(19).Visible = False
                D1.Columns(20).Visible = False
                D1.Columns(21).Visible = False
                D1.Columns(22).Visible = False
                D1.Columns(23).Visible = False
            ElseIf userper = 4 Then
                D1.Columns(20).Visible = False
                D1.Columns(18).Visible = False
                D1.Columns(17).Visible = False
                D1.Columns(16).Visible = False
                D1.Columns(19).Visible = False
                D1.Columns(5).Visible = False
                D1.Columns(3).ReadOnly = True
                D1.Columns(10).ReadOnly = True
                D1.Columns(11).ReadOnly = True
                D1.Columns(12).Visible = False
                D1.Columns(13).Visible = False
                D1.Columns(14).Visible = False
                D1.Columns(15).Visible = False
                D1.Columns(21).Visible = False
                D1.Columns(22).Visible = False
                D1.Columns(23).Visible = False
            ElseIf userper = 6 Then
                D1.Columns(13).Visible = False
                D1.Columns(14).Visible = False
                D1.Columns(15).Visible = False
                D1.Columns(18).Visible = False
                D1.Columns(17).Visible = False
                D1.Columns(16).Visible = False
                D1.Columns(19).Visible = False
                D1.Columns(20).Visible = False
                D1.Columns(21).Visible = False
                D1.Columns(22).Visible = False
                D1.Columns(23).Visible = False
            End If
        End If
    End Sub

    ' load arraivals from excel function
    Public Sub OPenarr(ByVal D1 As DataGridView, ByVal apppath As String)
        kg1 = 0
        Try

            Dim conConn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & apppath & ";Extended Properties=""Excel 12.0 Xml;HDR=YES""")
            conConn.Open()
            Dim strSql As String = "select Date,Time,Flight,ID,Name from [Arr$]"
            Dim da As New OleDb.OleDbDataAdapter(strSql, conConn)
            Dim dt As New System.Data.DataTable
            da.Fill(dt)
            Dim Rdate As String
            Rdate = dt.Rows(0).Item("Date")
            Dim NotNew As String
            NotNew = "*"
            Try
                Dim getFullRDD As New SqlCommand
                getFullRDD.CommandText = "Select ADate from Arrival where ADate = N'" & Rdate & "'and RNum =1"
                getFullRDD.Connection = cn
                NotNew = getFullRDD.ExecuteScalar
            Catch ex As Exception
                ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
            End Try
            Dim cnnOLEDB As New OleDb.OleDbConnection
            Dim cmdOLEDB As New OleDbCommand
            Dim SQL As String
            DataGridView6.Columns.Add(0, "Date")
            DataGridView6.Columns.Add(1, "Time")
            DataGridView6.Columns.Add(2, "Flight")
            DataGridView6.Columns.Add(3, "ID")
            DataGridView6.Columns.Add(4, "Name")
            DataGridView6.Columns(0).ReadOnly = True
            DataGridView6.Columns(2).ReadOnly = True
            DataGridView6.Columns(4).ReadOnly = True
            DataGridView6.Columns.Add(5, " Arabic Name")
            DataGridView6.Columns(5).ReadOnly = True
            DataGridView6.Columns.Add(6, "Address")
            DataGridView6.Columns(6).ReadOnly = True
            DataGridView6.Columns.Add(7, "ShatelBus")
            DataGridView6.Columns.Add(8, "BUSToHome")
            DataGridView6.Columns.Add(9, "Driver")
            DataGridView6.Columns(9).ReadOnly = True
            DataGridView6.Columns.Add(10, "Note")
            DataGridView6.Columns.Add(11, "Area")
            DataGridView6.Columns.Add(12, "DMnote")
            DataGridView6.Columns.Add(13, "CF")
            DataGridView6.Columns.Add(14, "RNum")
            DataGridView6.Columns.Add(15, "isinsert")
            DataGridView6.Columns.Add(16, "RID")
            DataGridView6.Columns.Add(17, "Transofficer")
            DataGridView6.Columns.Add(18, "Transofficer1")
            DataGridView6.Columns(11).Visible = False
            Dim i As Integer = 0
            While i <= dt.Rows.Count - 1
                DataGridView6.Rows.Add()
                DataGridView6.Item(0, i).Value = dt.Rows(i).Item("Date")
                DataGridView6.Item(2, i).Value = dt.Rows(i).Item("Flight")
                DataGridView6.Item(3, i).Value = dt.Rows(i).Item("ID")
                DataGridView6.Item(4, i).Value = dt.Rows(i).Item("Name")

                If dt.Rows(i).Item("Flight").ToString.Contains("arr") Then
                    DataGridView6.Item(1, i).Value = dt.Rows(i).Item("Flight").ToString.Substring(dt.Rows(i).Item("Flight").ToString.IndexOf("r") + 2, 6)
                Else
                    DataGridView6.Item(1, i).Value = dt.Rows(i).Item("Time")

                End If

                Try
                    SQL = "select * from mobile where id= " & DataGridView6(3, i).Value
                    Dim dn As New SqlDataAdapter(SQL, cn)
                    Dim dq As New System.Data.DataTable
                    dn.Fill(dq)
                    Dim yy As String = dq.Rows(0).Item("Name").ToString.Replace("ـ", "")
                    DataGridView6.Item(5, i).Value = yy.Replace("*", "")
                    DataGridView6.Item(6, i).Value = dq.Rows(0).Item("HomeAddress")
                    DataGridView6.Item(11, i).Value = dq.Rows(0).Item("areaa")
                    If dq.Rows(0).Item("areaa") = 3 Then
                        DataGridView6.Rows(i).DefaultCellStyle.BackColor = Color.Tan
                        DataGridView6.Rows(i).ReadOnly = True
                    End If
                    y = DataGridView6.Rows(i).Cells(0).Value

                Catch ex As Exception
                    DataGridView6.Item(0, i).Value = ""
                    DataGridView6.Item(1, i).Value = ""
                    DataGridView6.Item(2, i).Value = ""
                    DataGridView6.Item(5, i).Value = "No Data"
                    DataGridView6.Item(6, i).Value = "No Data"
                    DataGridView6.Item(11, i).Value = 10
                    ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
                End Try
                i = i + 1
            End While

            Dim ins As Integer = 0
            Dim dat As String
            Dim tim As String
            Dim fli As String
            Dim CF As Integer
            Dim rname As String

            If NotNew = "" Then


                Try
                    While ins <= DataGridView6.RowCount - 2

                        rname = DataGridView6(4, ins).Value.Replace("'", "")

                        Dim cmins As New SqlCommand
                        cmins.Connection = cn
                        If cn.State = ConnectionState.Closed Then
                            cn.Open()

                        End If

                        If DataGridView6(0, ins).Value.Replace(" ", "") = "" Then
                            CF = 0
                        Else
                            dat = DataGridView6(0, ins).Value
                            tim = DataGridView6(1, ins).Value
                            fli = DataGridView6(2, ins).Value
                            CF = 1
                        End If
                        cmins.CommandText = "insert into Arrival values(N'" & dat & "',N'" & tim.Replace(" ", "") & "',N'" & fli & "'," & DataGridView6(3, ins).Value & ",N'" & rname & "',N'" & DataGridView6(5, ins).Value & "',N'" & DataGridView6(6, ins).Value & "',N'',N'',N'',N''," & DataGridView6(11, ins).Value & "," & CF & "," & ins & ",0,0,0,N'')"

                        cmins.ExecuteNonQuery()
                        ins = ins + 1

                    End While
                Catch ex As Exception
                    ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
                End Try
                If userid = 1 Then
                    DataGridView6.Columns(5).Visible = False
                    DataGridView6.Columns(3).ReadOnly = True
                    DataGridView6.Columns(11).ReadOnly = True
                    DataGridView6.Columns(9).ReadOnly = True
                End If

            End If

        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
    End Sub

    ' form closing event
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If userper = 0 Then
            System.Windows.Forms.Application.Exit()
        Else
            Dim roc = MessageBox.Show("Do You Want To Exit ?", "Warning", MessageBoxButtons.OKCancel)
            If roc = DialogResult.OK Then
                Me.Hide()
                UPDATEToolStripMenuItem.PerformClick()
                e.Cancel = False
            ElseIf roc = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    ' keyboard shortcut handler to show the webdialer page (CTRL+F1) or perform search (space or right arrow)
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Control + Keys.F1 Then
            webDialer.Owner = Me
            webDialer.Close()
            LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer")
            webDialer.Show()

        End If
        If rosterSearch.Visible = True Then
            If e.KeyData = Keys.Space Or e.KeyData = Keys.Right Then
                rosterSearch.Button3.PerformClick()
            End If
        End If
    End Sub

    Private Sub LoadNotes()
        Try
            Dim STt1 As String = "SELECT * FROM notes WHERE NoteDate = @d"
            Dim dkk As New SqlDataAdapter(STt1, con)
            dkk.SelectCommand.Parameters.AddWithValue("@d", System.DateTime.Now.Date)

            currentNotes = New DataTable()
            dkk.Fill(currentNotes)

            marqueeSegments.Clear()
            plainMarquee = ""

            Dim separator As String = "   •••   " ' Separator between notes

            ' Build original marquee from notes
            For Each row As DataRow In currentNotes.Rows
                Dim noteText As String = If(IsDBNull(row.Item("NoteValue")), String.Empty, row.Item("NoteValue").ToString())
                Dim important As Integer = If(IsDBNull(row.Item("important")), 0, Convert.ToInt32(row.Item("important")))
                Dim colorIndex As Integer = If(important = 1, 1, 2) ' 1=red, 2=black

                Dim segText As String = noteText & separator
                marqueeSegments.Add(New KeyValuePair(Of String, Integer)(segText, colorIndex))
                plainMarquee &= segText
            Next

            If String.IsNullOrEmpty(plainMarquee) Then
                BottomLabel.Clear()
                Timer4.Stop()
                Return
            End If

            ' Store original length
            originalMarqueeLength = plainMarquee.Length

            ' Calculate optimal visible length based on control width
            UpdateVisibleLength()

            ' Create seamless infinite scrolling content
            ' Repeat content 3 times to ensure smooth looping
            If originalMarqueeLength > 0 Then
                Dim extendedMarquee As String = plainMarquee
                For i As Integer = 1 To 2 ' Add 2 more copies (total 3)
                    extendedMarquee &= plainMarquee
                Next
                plainMarquee = extendedMarquee
            End If

            ' Add leading spaces for smooth entry
            plainMarquee = New String(" ", visibleLength) & plainMarquee

            scrollIndex = 0
            Timer4.Interval = marqueeSpeed
            Timer4.Start()

        Catch ex As Exception
            MessageBox.Show("LoadNotes error: " & ex.Message)
        End Try
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Try
            If String.IsNullOrEmpty(plainMarquee) OrElse marqueeSegments.Count = 0 Then
                BottomLabel.Clear()
                Return
            End If

            Dim totalLen As Integer = plainMarquee.Length

            ' Continuous scrolling - never stop
            scrollIndex += 1

            ' Seamless loop detection - when we approach the end, wrap to equivalent position
            ' This prevents any visible jump or glitch
            If scrollIndex >= totalLen Then
                ' Wrap to equivalent position in the first segment for perfect loop
                scrollIndex = scrollIndex Mod originalMarqueeLength
                If scrollIndex < visibleLength Then
                    scrollIndex += visibleLength ' Ensure we're past the leading spaces
                End If
            End If

            ' Extract the visible window with wrap-around handling
            Dim window As String = GetVisibleWindow(scrollIndex, visibleLength, plainMarquee)

            ' Build and display the RTF with proper colors and centering
            DisplayMarqueeWindow(window, scrollIndex)

        Catch ex As Exception
            ' Silent error handling for smooth operation
        End Try
    End Sub

    Private Function GetVisibleWindow(startIndex As Integer, length As Integer, text As String) As String
        Dim totalLen As Integer = text.Length

        If startIndex + length <= totalLen Then
            Return text.Substring(startIndex, length)
        Else
            ' Handle wrap-around seamlessly
            Dim part1Len As Integer = totalLen - startIndex
            Dim part1 As String = text.Substring(startIndex, part1Len)
            Dim part2Len As Integer = length - part1Len
            Dim part2 As String = text.Substring(0, part2Len)
            Return part1 & part2
        End If
    End Function

    Private Sub DisplayMarqueeWindow(window As String, currentScrollIndex As Integer)
        Dim rtfBuilder As New System.Text.StringBuilder()

        ' RTF header with font and color table
        rtfBuilder.Append("{\rtf1\ansi\deff0")
        rtfBuilder.Append("{\fonttbl{\f0\fnil\fcharset0 " & BottomLabel.Font.Name & ";}}")
        rtfBuilder.Append("{\colortbl ;\red255\green0\blue0;\red0\green0\blue0;}") ' 1=red, 2=black
        rtfBuilder.Append("\viewkind4\uc1\pard\qc") ' Centered alignment

        ' Process each character in the window and apply correct colors
        For i As Integer = 0 To window.Length - 1
            Dim absolutePos As Integer = (currentScrollIndex + i) Mod plainMarquee.Length
            Dim colorIndex As Integer = GetColorForPosition(absolutePos)
            Dim currentChar As Char = window(i)

            rtfBuilder.Append("\cf" & colorIndex & " " & EscapeRtfChar(currentChar))
        Next

        rtfBuilder.Append("\par}")
        BottomLabel.Rtf = rtfBuilder.ToString()
    End Sub

    Private Function GetColorForPosition(position As Integer) As Integer
        ' Adjust for leading spaces
        Dim adjustedPos As Integer = position - visibleLength
        If adjustedPos < 0 Then
            ' This is in the leading spaces - use default black
            Return 2
        End If

        ' Map to original marquee pattern
        Dim patternPos As Integer = adjustedPos Mod originalMarqueeLength

        ' Find which segment this position belongs to
        Dim currentPos As Integer = 0
        For Each segment In marqueeSegments
            Dim segmentLength As Integer = segment.Key.Length
            If patternPos >= currentPos AndAlso patternPos < currentPos + segmentLength Then
                Return segment.Value ' Return the segment's color
            End If
            currentPos += segmentLength
        Next

        ' Default to black if not found (shouldn't happen)
        Return 2
    End Function

    Private Function EscapeRtfChar(c As Char) As String
        Select Case c
            Case "\" : Return "\\"
            Case "{" : Return "\{"
            Case "}" : Return "\}"
            Case vbCr, vbLf : Return "\par "
            Case Else : Return c.ToString()
        End Select
    End Function

    Private Sub UpdateVisibleLength()
        If BottomLabel.Width > 0 Then
            Using g As Graphics = BottomLabel.CreateGraphics()
                Dim avgCharWidth As Single = g.MeasureString("A", BottomLabel.Font).Width
                If avgCharWidth > 0 Then
                    visibleLength = Math.Max(100, CInt(BottomLabel.ClientSize.Width / avgCharWidth * 1.2))
                Else
                    visibleLength = 100 ' Fallback
                End If
            End Using
        End If
    End Sub

    Private Sub BottomLabel_Resize(sender As Object, e As EventArgs) Handles BottomLabel.Resize
        ' Update visible length when control is resized
        UpdateVisibleLength()

        ' Restart marquee with new dimensions if it was running
        If Timer4.Enabled Then
            LoadNotes()
        End If
    End Sub

    ' Call this function to refresh the notes display
    Public Sub RefreshNotes()
        LoadNotes()
    End Sub

    ' form load event
    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'add buttons to panel 8
        Dim intlift As Integer = 25
        Dim inttop As Integer = 25
        Dim intwidth As Integer = 50
        Dim inthight As Integer = 30
        Try
            Timer5.Interval = 1
            Timer5.Start()
            With BottomLabel
                .Dock = DockStyle.Fill
                .Text = ""
            End With
        Catch ex As Exception
        End Try
        Dim STt1 As String
        ToolStripLabel1.Text = System.DateTime.Now.Date.ToShortDateString
        ToolStripLabel2.Text = System.DateTime.Now.Date.ToShortDateString
        ToolStripLabel6.Text = System.DateTime.Now.Date.ToShortDateString
        ToolStrip5.Visible = True
        ToolStrip2.Visible = True
        ToolStrip1.Visible = True
        GroupBox14.Visible = False

        Label15.Text = "Copyright RJ - Transportation (2013-" & System.DateTime.Now.Year & ")  Developed By Nader Sawalha"

        ' get DB connection string from settings for con and cn objects
        con.ConnectionString = My.Settings.remoteDB
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        cn.ConnectionString = My.Settings.remoteDB
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If

        LoadNotes()


        Label56.Visible = False
        Label57.Visible = False
        Label58.Visible = False
        Label59.Visible = False
        Label60.Visible = False
        Label63.Visible = False
        ComboBox6.Visible = False
        ComboBox7.Visible = False
        ComboBox8.Visible = False
        ComboBox9.Visible = False
        ComboBox10.Visible = False
        TextBox33.Visible = False
        TextBox29.ReadOnly = True

        Label63.Visible = False
        LinkLabel3.Visible = False
        LinkLabel4.Visible = False
        LinkLabel5.Visible = False
        LinkLabel6.Visible = False
        LinkLabel7.Visible = False
        LinkLabel8.Visible = False
        LinkLabel9.Visible = False
        LinkLabel10.Visible = False
        LinkLabel11.Visible = False
        LinkLabel12.Visible = False

        GroupBox1.Text = System.DateTime.Now.Date
        splashScreen.Close()
        Panel1.Visible = True

        Label15.Visible = True

        Dim cmdOLEDB As New SqlCommand

        Dim SQL As String
        Dim SQL1 As String

        ComboBox2.Text = ComboBox2.Items(0)
        ComboBox3.Text = ComboBox3.Items(0)
        D3.Columns.Add(0, "Driver")
        D3.Columns(0).ReadOnly = True
        D3.Columns.Add(1, "BUS")

        DataGridView9.Columns.Add(0, "Driver")
        DataGridView9.Columns(0).ReadOnly = True
        DataGridView9.Columns.Add(1, "BUS")
        DataGridView9.Columns(1).ReadOnly = True

        SQL = "select * from Gss "
        Dim dn As New SqlDataAdapter(SQL, con)
        Dim dq As New System.Data.DataTable
        dn.Fill(dq)
        D2.Columns.Clear()
        D2.DataSource = dq
        ToolStripComboBox1.SelectedIndex = 0

        SQL1 = "select * from bus "
        Dim dnn As New SqlDataAdapter(SQL1, con)
        Dim dqq As New System.Data.DataTable
        dnn.Fill(dqq)
        Dim w As Integer = 0
        While w <= dqq.Rows.Count - 1
            D3.Rows.Add()
            D3.Item(0, w).Value = dqq.Rows(w).Item("Driver")
            w = w + 1
        End While

        circlebuses()

        Dim win As System.Security.Principal.WindowsIdentity
        win = System.Security.Principal.WindowsIdentity.GetCurrent()
        UserName = win.Name.Substring(win.Name.IndexOf("\") + 1)

        Dim SQL2 As String


        Try
            userPermissions(UserName)
            SQL2 = "select * from Userr where ID='" & UserName & "' "
            Dim dn1 As New SqlDataAdapter(SQL2, con)
            Dim dq1 As New System.Data.DataTable
            dn1.Fill(dq1)
            userper = (dq1.Rows(0).Item("Per"))
            office = (dq1.Rows(0).Item("Office"))
            userRname = (dq1.Rows(0).Item("Name"))
            TextBox29.Text = System.DateTime.Now.Date.ToShortDateString
            If office = 1 Then
                Label63.Text = "Arrive Time"
            End If

            ' apply general user role to hide/show controls and enable/disable features
            If dq1.Rows(0).Item("Per") = 3 Then
                DateTimePicker2.Visible = True
            End If

            If dq1.Rows(0).Item("Per") = 1 Then
                DateTimePicker2.Visible = True
                D2.Columns(2).Visible = False
                D2.Columns(4).Visible = False
                ToolStripTextBox1.Visible = False
                DateTimePicker2.Visible = False
            ElseIf dq1.Rows(0).Item("Per") = 2 Then
                D2.Columns(4).Visible = False
                DateTimePicker2.Visible = False
            ElseIf dq1.Rows(0).Item("Per") = 4 Then
                arabic.Visible = False
                D2.Columns(2).Visible = False
                D2.Columns(4).Visible = False
                ToolStripTextBox1.Visible = False
                ToolStripButton1.Visible = False
                DateTimePicker2.Visible = False
            ElseIf dq1.Rows(0).Item("Per") = 6 Then
                D2.Columns(4).Visible = False
                DateTimePicker2.Visible = False
            End If
        Catch ex As Exception
            userper = 0
            MessageBox.Show("YOU ARE NOT AUTHORIZED TO ACCESS THE SYSTEM")
            System.Windows.Forms.Application.Exit()
        End Try
        Try
        Catch ex As Exception
        End Try
        kg = 1
    End Sub

    ' keyboard shortcut handler for tab control to open file (CTRL+O), show webdialer (CTRL+F1) or perform search (CTRL+F)
    Private Sub TabControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tt2.KeyDown
        If e.KeyData = Keys.Control + Keys.O Then
            OpenToolStripButton.PerformClick()
        End If
        If e.KeyData = Keys.Control + Keys.F Then
            If Me Is Me Then
                If Label11.Text = "" Then
                Else
                    rosterSearch.Owner = Me
                    rosterSearch.Show()
                End If
            End If
        End If
        If e.KeyData = Keys.Control + Keys.F1 Then
            webDialer.Owner = Me
            webDialer.Close()
            LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer")
            webDialer.Show()
        End If
    End Sub

    ' double click event on textbox to launch webdialer (hidden) with the number in the textbox
    Private Sub TextBox4_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox4.MouseDoubleClick
        If TextBox4.Text = "" Then
        Else
            webDialer.Close()
            Dim number As String = TextBox4.Text.Replace(" ", "")
            If number.Length = 9 Then
                LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=90" & number & "&ref=devdevext")
            ElseIf number.Length = 4 Then
                LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=" & number & "&ref=devdevext")
            ElseIf number.Length = 7 Then
                LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=9" & number & "&ref=devdevext")
            End If
        End If
    End Sub

    ' double click event on textbox to launch webdialer (hidden) with the number in the textbox
    Private Sub TextBox2_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseDoubleClick
        webDialer.Close()
        If TextBox2.Text = "" Then
        Else
            Dim number As String = TextBox2.Text.Replace(" ", "")
            If number.Length = 9 Then
                LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=90" & number & "&ref=devdevext")
            ElseIf number.Length = 4 Then
                LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=" & number & "&ref=devdevext")
            ElseIf number.Length = 7 Then
                LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=9" & number & "&ref=devdevext")
            End If
        End If


    End Sub

    ' Save changes to existing contact button click event
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cm As New SqlCommand
        Dim cm1 As New SqlCommand
        Dim ST As String
        Try
            If CheckBox1.CheckState = CheckState.Checked Then
                selected = 3
            Else
                If ComboBox2.SelectedIndex = 0 Then
                    selected = 1
                Else
                    selected = 2
                End If
            End If
            ST = "update mobile set Name=N'" & TextBox3.Text & "' , Phone='" & TextBox2.Text & "' , HomeAddress=N'" & TextBox10.Text & "', areaa= " & selected & " where Id=" & Label8.Text
            cm = New SqlCommand(ST, cn)
            TextBox1.Text = ""
            TextBox10.Text = ""
            TextBox3.Text = ""
            TextBox2.Text = ""
            Label8.Text = ""
            ComboBox2.Text = ""
            ComboBox2.Enabled = True
            CheckBox1.CheckState = CheckState.Unchecked
            Label19.Text = "Saved"
            cm.ExecuteNonQuery()
        Catch ex As Exception
            Label19.Text = "There was an error, please make sure the information entered correctly and try again"
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
    End Sub

    ' Search for existing contact button click event
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If TextBox1.Text = "" Then
        Else
            Dim cm As New SqlCommand
            Dim dm As New System.Data.DataTable
            Dim ST As String
            Try
                If IsNumeric(TextBox1.Text) Then
                    ST = "select * from mobile where Id= " & TextBox1.Text
                    Dim dk As New SqlDataAdapter(ST, cn)
                    dk.Fill(dm)
                    TextBox2.Text = dm.Rows(0).Item("Phone")
                    TextBox3.Text = dm.Rows(0).Item("Name")
                    TextBox10.Text = dm.Rows(0).Item(4)
                    If dm.Rows(0).Item("areaa") = 1 Then
                        ComboBox2.Text = ComboBox2.Items(0)
                    Else
                        ComboBox2.Text = ComboBox2.Items(1)
                    End If
                    If dm.Rows(0).Item("areaa") = 3 Then
                        CheckBox1.Checked = True
                        CheckBox1.ForeColor = Color.Red
                    Else
                        CheckBox1.Checked = False
                        CheckBox1.ForeColor = Color.Black
                    End If
                    Label8.Text = dm.Rows(0).Item("Id")
                Else
                    ST = "select * from mobile where Name = N'" & TextBox1.Text.ToString & "' "
                    Dim dk As New SqlDataAdapter(ST, cn)
                    dk.Fill(dm)
                    TextBox2.Text = dm.Rows(0).Item("Phone")
                    TextBox3.Text = dm.Rows(0).Item("Name")
                    TextBox10.Text = dm.Rows(0).Item(4)
                    Label8.Text = dm.Rows(0).Item("Id")
                    If dm.Rows(0).Item("areaa") = 1 Then
                        ComboBox2.Text = ComboBox2.Items(0)
                    Else
                        ComboBox2.Text = ComboBox2.Items(1)
                    End If
                    If dm.Rows(0).Item("areaa") = 3 Then
                        CheckBox1.Checked = True
                        CheckBox1.ForeColor = Color.Red
                    Else
                        CheckBox1.Checked = False
                        CheckBox1.ForeColor = Color.Black
                    End If
                End If
                Label19.Text = "* Please enter a value to be change and press Save"
            Catch ex As Exception
                TextBox2.Text = "NO Match"
                TextBox3.Text = "NO Match"
                TextBox10.Text = "NO Match"
            End Try
        End If
    End Sub

    Private Sub arabic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arabic.Click
        If arabic.Text = "English" Then
            arabic.Text = "عربي"

            FileToolStripMenuItem.Alignment = ToolStripItemAlignment.Left
            ViewToolStripMenuItem.Alignment = ToolStripItemAlignment.Left
            HelpToolStripMenuItem.Alignment = ToolStripItemAlignment.Left
            OpenToolStripMenuItem.Alignment = ToolStripItemAlignment.Left
            ExitToolStripMenuItem.Alignment = ToolStripItemAlignment.Left
            HelpToolStripMenuItem.Alignment = ToolStripItemAlignment.Left
            AboutToolStripMenuItem.Alignment = ToolStripItemAlignment.Left
            tt2.RightToLeft = System.Windows.Forms.RightToLeft.No
            ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
            rosterTab.RightToLeft = System.Windows.Forms.RightToLeft.No
            groundStaffTab.RightToLeft = System.Windows.Forms.RightToLeft.No
            cgsTab.RightToLeft = System.Windows.Forms.RightToLeft.No
            driverLinkTab.RightToLeft = System.Windows.Forms.RightToLeft.No

            notesTab.RightToLeft = System.Windows.Forms.RightToLeft.No
            TreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No
            GroupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
            GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
            GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
            GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
            GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No

            rosterSearch.Text = "Search"
            rosterSearch.Label1.Text = "Search Text"
            rosterSearch.Button1.Text = "Search"
            rosterSearch.Button3.Text = "Find Next"
            rosterSearch.Button2.Text = "Cancel"
            rosterSearch.TextBox1.Left = 87
            rosterSearch.Label1.Left = 12

            ToolStripButton1.Text = "Search"

            FileToolStripMenuItem.Text = "&File"
            ViewToolStripMenuItem.Text = "&Viwe"
            HelpToolStripMenuItem.Text = "&Help"
            OpenToolStripMenuItem.Text = "&Open"
            ExitToolStripMenuItem.Text = "E&xit"
            AboutToolStripMenuItem.Text = "&About GPS"
            rosterTab.Text = "Roster"
            groundStaffTab.Text = "Ground Staff"
            cgsTab.Text = "Crew & Ground Staff Modification"
            driverLinkTab.Text = "Bus & Driver"

            arrivalsRjTab.Text = "Arrivals"
            ArrivalsTab.Text = "Arr"
            ordersTab.Text = "Orders"
            notesTab.Text = "Notes"
            reportsTab.Text = "Reports"
            kmRreportTab.Text = "KM Report"
            createRosterTab.Text = "Create Roster"
            CrewsBYAreasToolStripMenuItem.Text = "Crews BY Areas"
            UsersManagementToolStripMenuItem.Text = "Users Management"
            UPDATEToolStripMenuItem.Text = "UPDATE"
            ToolStripButton6.Text = "Load Roster"
            TreeView1.Nodes(0).Text = "Crew"
            TreeView1.Nodes(0).Nodes(0).Text = "Search & Change"
            TreeView1.Nodes(0).Nodes(1).Text = "Add New"
            TreeView1.Nodes(1).Text = "Ground Staff"
            TreeView1.Nodes(1).Nodes(0).Text = "Search & Change"
            TreeView1.Nodes(1).Nodes(1).Text = "Add New"
            Label17.Left = 10
            Label17.Text = "Please type in BUS column last three digits of the license plate  to be linked with a driver."

            GroupBox2.Text = "Search & Change"
            Label1.Text = "Search Text"
            Label2.Text = "Name"
            Label3.Text = "Mobile Number"
            Label18.Text = "Address"
            Label19.Text = "* Please enter a value to be change and press Save"
            Button10.Text = "Search"

            'Button2.Text = "Save"
            Button25.Text = "Dlelete"
            GroupBox4.Text = "Search & Change"
            Label31.Text = "Search Text"
            Label30.Text = "Name"
            Label29.Text = "Mobile Number"
            Label27.Text = "Address"
            Label26.Text = "* Please enter a value to be change and press Save"
            Button21.Text = "Search"

            Button20.Text = "Save"
            Button24.Text = "Delete"
            GroupBox3.Text = "Add New"
            Label5.Text = "ID"
            Label4.Text = "Name"
            Label6.Text = "Mobile Number"
            Label7.Text = "Address"

            Label20.Text = "* Please enter values to be Added and press Save"
            Button3.Text = "Save"
            GroupBox5.Text = "Add New"
            Label36.Text = "ID"
            Label35.Text = "Name"
            Label34.Text = "Mobile Number"
            Label33.Text = "Address"

            Label32.Text = "* Please enter values to be Added and press Save"
            Button23.Text = "Save"
            arabic.Alignment = ToolStripItemAlignment.Right

        ElseIf arabic.Text = "عربي" Then
            arabic.Text = "English"
            FileToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
            ViewToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
            HelpToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
            OpenToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
            ExitToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
            HelpToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
            AboutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
            tt2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            rosterTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            groundStaffTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            cgsTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            driverLinkTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes

            notesTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            TreeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            GroupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes

            rosterSearch.Text = "البحث"
            rosterSearch.Label1.Text = "جملة البحث"
            rosterSearch.Button1.Text = "بحث"
            rosterSearch.Button3.Text = "بحث التالي"
            rosterSearch.Button2.Text = "الغاء"
            rosterSearch.TextBox1.Left = 35
            rosterSearch.TextBox1.TextAlign = HorizontalAlignment.Right
            rosterSearch.Label1.Left = 180


            ToolStripButton1.Text = "بحث"
            Label17.Left = 120
            Label17.Text = "يرجى  كتابة الأرقام  الثلاثة  الأخيرة  من  لوحة  ترخيص  في  عمود الباص  ليتم  ربطها  مع  سائق."

            FileToolStripMenuItem.Text = "ملف"
            ViewToolStripMenuItem.Text = "عرض"
            HelpToolStripMenuItem.Text = "مساعدة"
            OpenToolStripMenuItem.Text = "فتح"
            ExitToolStripMenuItem.Text = "خروج"
            ToolStripButton6.Text = "تحميل الجدول"
            HelpToolStripMenuItem.Text = "مساعدة"
            AboutToolStripMenuItem.Text = "عن البرنامج"
            rosterTab.Text = "جدول المضيفين"
            arrivalsRjTab.Text = "الرحلات القادمة"
            ArrivalsTab.Text = "القادمون"
            ordersTab.Text = "طلبات الحركة"
            notesTab.Text = "الملاحظات"
            reportsTab.Text = "التقارير"
            kmRreportTab.Text = "تقارير الكيلومترات"
            createRosterTab.Text = "انشاء جدول المضيفين"
            groundStaffTab.Text = " الموظفات الارضيات"
            cgsTab.Text = "تعديلات الاطقم و الموظفات الارضيات"
            driverLinkTab.Text = "الآليات و السائقين"
            CrewsBYAreasToolStripMenuItem.Text = "المضيفين حسب المناطق"
            UsersManagementToolStripMenuItem.Text = "ادارة المستخدمين"
            UPDATEToolStripMenuItem.Text = "تحديث"
            TreeView1.Nodes(0).Text = "الاطقم"
            TreeView1.Nodes(0).Nodes(0).Text = "البحث و التعديل"
            TreeView1.Nodes(0).Nodes(1).Text = "اضافة جديد"
            TreeView1.Nodes(1).Text = "المظفات الارضيات"
            TreeView1.Nodes(1).Nodes(0).Text = "البحث و التعديل"
            TreeView1.Nodes(1).Nodes(1).Text = "اضافة جديد"
            GroupBox2.Text = "البحث و التعديل"
            Label1.Text = "جملة البحث"
            Label2.Text = "الاسم"
            Label3.Text = "رقم الهاتف"
            Label18.Text = "العنوان"
            Label19.Text = "يرجى تعديل البيانات ثم ضغط على حفظ"
            Button10.Text = "بحث"

            Button2.Text = "حفظ"
            Button25.Text = "مسح"
            GroupBox4.Text = "البحث و التعديل"
            Label31.Text = "جملة البحث"
            Label30.Text = "الاسم"
            Label29.Text = "رقم الهاتف"
            Label27.Text = "العنوان"
            Label26.Text = "يرجى تعديل البيانات ثم ضغط على حفظ"
            Button21.Text = "بحث"

            Button20.Text = "حفظ"
            Button24.Text = "مسح"
            GroupBox3.Text = "اضافة جديد"
            Label5.Text = "الرقم الوظيفي"
            Label4.Text = "الاسم"
            Label6.Text = "الهاتف"
            Label7.Text = "العنوان"

            Label20.Text = "يرجى ادخال البيانات و ضغط على حفظ"
            Button3.Text = "حفظ"
            GroupBox5.Text = "اضافة جديد"
            Label36.Text = "الرقم الوظيفي"
            Label35.Text = "الاسم"
            Label34.Text = "الهاتف"
            Label33.Text = "العنوان"

            Label32.Text = "يرجى ادخال البيانات و ضغط على حفظ"
            Button23.Text = "حفظ"
            arabic.Alignment = ToolStripItemAlignment.Left
        End If
    End Sub

    ' Update Roster and Ground Staff data from the database to the grids
    Private Sub UPDATEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATEToolStripMenuItem.Click


        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            Dim cm As New SqlCommand
            Dim cm1 As New SqlCommand
            Dim cm2 As New SqlCommand
            Dim cm3 As New SqlCommand
            Dim cm4 As New SqlCommand
            Dim cm5 As New SqlCommand

            Dim hh As Integer = 0
            Dim h1 As Integer = 0
            Dim hhh As Integer = 0
            Dim shs As Integer = 0
            Dim h As Integer = 0
            Dim ST As String
            Dim sst As String
            Dim str As String
            Dim sts As String

            If tt2.SelectedIndex = 0 Then
                ST = "select GPSCallTime,Bus,Driver,GPSNote,ArrTime,DMnote,late,RID from FullRoster where  (FDate=N'" & ToolStripLabel1.Text & "') and (GPSCallTime <> '' or Bus <> '' or Driver <> '' or GPSNote <> '' or ArrTime <> '' or DMnote <> '' )"
                Dim dnn As New SqlDataAdapter(ST, cn)
                Dim dqq As New System.Data.DataTable
                dnn.Fill(dqq)
                While hh <= dqq.Rows.Count - 1
                    For mm = 0 To D1.RowCount - 1
                        If dqq.Rows(hh).Item("RID") = D1(20, mm).Value Then
                            If dqq.Rows(hh).Item("GPSCallTime") <> "" Then
                                D1(8, mm).Value = dqq.Rows(hh).Item("GPSCallTime")
                                D1.Rows(mm).DefaultCellStyle.BackColor = Color.LightBlue
                            End If
                            If dqq.Rows(hh).Item("GPSNote") <> "" Then
                                D1(11, mm).Value = dqq.Rows(hh).Item("GPSNote")
                            End If
                            If dqq.Rows(hh).Item("GPSNote").ToString.Contains("Delete") Then
                                D1.Rows(mm).DefaultCellStyle.BackColor = Color.DarkOrange
                                D1(11, mm).Value = "Delete"
                            End If
                            If dqq.Rows(hh).Item("GPSNote").ToString.Contains("Switched") Then
                                D1.Rows(mm).DefaultCellStyle.BackColor = Color.Violet
                                D1(11, mm).Value = "Switched"
                            End If
                            If dqq.Rows(hh).Item("GPSNote").ToString.Contains("NO SHOW") Then
                                D1.Rows(mm).DefaultCellStyle.BackColor = Color.LightGreen
                                D1(11, mm).Value = "NO SHOW"
                            End If
                            If dqq.Rows(hh).Item("GPSNote").ToString.Contains("CANCEL ON CALL") Then
                                D1.Rows(mm).DefaultCellStyle.BackColor = Color.Yellow
                                D1(11, mm).Value = "CANCEL ON CALL"
                            End If
                            If dqq.Rows(hh).Item("GPSNote").ToString.Contains("Alone") Then
                                D1.Rows(mm).DefaultCellStyle.BackColor = Color.Tan
                                D1(11, mm).Value = "Alone"
                            End If
                            If dqq.Rows(hh).Item("late") <> "00:00:00" Then
                                D1.Rows(mm).DefaultCellStyle.BackColor = Color.Tomato
                            End If
                            If dqq.Rows(hh).Item("ArrTime") <> "" Then
                                D1(14, mm).Value = dqq.Rows(hh).Item("ArrTime")
                            End If
                            If dqq.Rows(hh).Item("DMnote") <> "" Then
                                D1(15, mm).Value = dqq.Rows(hh).Item("DMnote")
                            End If
                            If dqq.Rows(hh).Item("Bus") <> "" Then
                                D1(9, mm).Value = dqq.Rows(hh).Item("Bus")
                            End If
                            If dqq.Rows(hh).Item("Driver") <> "" Then
                                D1(10, mm).Value = dqq.Rows(hh).Item("Driver")

                            End If
                        End If

                    Next

                    hh = hh + 1
                End While

                D1.Refresh()
                '-----------------------------------

            ElseIf tt2.SelectedIndex = 1 And ToolStripComboBox1.SelectedIndex <> 0 Then


                str = "select * from GSShift where SDate =N'" & ToolStripLabel2.Text & "'"
                Dim dnf As New SqlDataAdapter(str, cn)
                Dim dqf As New System.Data.DataTable
                dnf.Fill(dqf)
                While h1 <= dqf.Rows.Count - 1

                    For m1 = 0 To D2.RowCount - 1

                        If dqf.Rows(h1).Item("GSShID") = D2(15, m1).Value Then


                            D2(5, m1).Value = dqf.Rows(h1).Item("GPSCallTime")
                            ' D2(5, m1).Value = dqf.Rows(h1).Item("Shift")
                            D2(8, m1).Value = dqf.Rows(h1).Item("GPSNote")
                            D2(9, m1).Value = dqf.Rows(h1).Item("Buss")
                            D2(10, m1).Value = dqf.Rows(h1).Item("Driver")
                            If dqf.Rows(h1).Item("GPSCallTime").ToString <> "" Then
                                D2.Rows(m1).DefaultCellStyle.BackColor = Color.LightBlue
                            End If
                            If dqf.Rows(h1).Item("GPSNote").ToString = "No Show" Then
                                D2.Rows(m1).DefaultCellStyle.BackColor = Color.LightGreen
                                D2(8, m1).Value = "No Show"

                            ElseIf dqf.Rows(h1).Item("GPSNote").ToString = "Cancel ON Call" Then
                                D2.Rows(m1).DefaultCellStyle.BackColor = Color.Yellow
                                D2(8, m1).Value = "CANCEL ON CALL"

                            ElseIf dqf.Rows(h1).Item("GPSNote").ToString = "Alone" Then
                                D2.Rows(m1).DefaultCellStyle.BackColor = Color.Tan
                                D2(8, m1).Value = "Alone"
                            End If

                        End If
                    Next

                    h1 = h1 + 1
                End While

                '-----------------------------------
            ElseIf tt2.SelectedIndex = 4 Then
                '  MessageBox.Show("sasd")
                sts = "select ShatelBus,Bus,Driver,TransOfficerNote,ArrID,DMNote from Arrival where  (ADate=N'" & ToolStripLabel6.Text & "') and (ShatelBus <> '' or Bus <> '' or Driver <> '' or TransOfficerNote <> '' or DMNote <> '' )"
                Dim ndn As New SqlDataAdapter(sts, cn)
                Dim qdq As New System.Data.DataTable
                ndn.Fill(qdq)
                While shs <= qdq.Rows.Count - 1
                    For sms = 0 To DataGridView6.RowCount - 1
                        If qdq.Rows(shs).Item("ArrID") = DataGridView6(0, sms).Value Then
                            If qdq.Rows(shs).Item("ShatelBus") <> "" Then
                                DataGridView6(7, sms).Value = qdq.Rows(shs).Item("ShatelBus")
                                DataGridView6.Rows(sms).DefaultCellStyle.BackColor = Color.LightBlue
                            End If
                            If qdq.Rows(shs).Item("Bus") <> "" Then
                                DataGridView6(8, sms).Value = qdq.Rows(shs).Item("Bus")
                                DataGridView6.Rows(sms).DefaultCellStyle.BackColor = Color.LightBlue
                            End If
                            If qdq.Rows(shs).Item("Driver") <> "" Then
                                DataGridView6(9, sms).Value = qdq.Rows(shs).Item("Driver")
                                DataGridView6.Rows(sms).DefaultCellStyle.BackColor = Color.LightBlue
                            End If
                            If qdq.Rows(shs).Item("TransOfficerNote") <> "" Then
                                DataGridView6(10, sms).Value = qdq.Rows(shs).Item("TransOfficerNote")

                            End If
                            If qdq.Rows(shs).Item("DMNote") <> "" Then
                                DataGridView6(17, sms).Value = qdq.Rows(shs).Item("DMNote")

                            End If
                        End If

                    Next

                    shs = shs + 1
                End While

                DataGridView6.Refresh()


            End If
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try



    End Sub

    ' Add new contact button click event
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cm As New SqlCommand
        Dim cm1 As New SqlCommand
        Try
            Dim ST As String
            Dim area As Integer
            If ComboBox3.SelectedIndex = 0 Then
                area = 1
            Else
                area = 2
            End If
            ST = "insert into mobile (Id,Name,Phone,HomeAddress,note,areaa) values (" & TextBox4.Text & ",N'" & TextBox5.Text & "','" & TextBox6.Text & "',N'" & TextBox7.Text & "',N'" & TextBox8.Text & "'," & area & " )"
            cm = New SqlCommand(ST, cn)
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            ComboBox3.Text = ""
            Label19.Text = "Saved"
            cm.ExecuteNonQuery()
        Catch ex As Exception
            Label19.Text = "There was an error, please make sure the information entered correctly and try again"
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
    End Sub

    ' right click event on datagrid to select row
    Private Sub D1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles D1.CellMouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            D1.Rows(e.RowIndex).Selected = True
            D1.CurrentCell = D1.Rows(e.RowIndex).Cells(0)
        End If
    End Sub

    ' double click event on datagrid to perform different actions based on user role and clicked column
    Private Sub D1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles D1.CellMouseDoubleClick
        Try
            If userper = 4 Then
                If D1.CurrentCell.ColumnIndex = 9 Then
                    locator(D1.CurrentCell.Value)
                End If
            End If
            If userper = 2 Or userper = 3 Or userper = 6 Then
                If D1.CurrentCell.ColumnIndex = 4 Then
                    sendmail(D1.CurrentRow.Cells(3).Value, D1.CurrentRow.Cells(6).Value)
                End If
                If D1.CurrentCell.ColumnIndex = 9 Then
                    locator(D1.CurrentCell.Value)
                End If
                If (D1.CurrentCell.ColumnIndex = 2 Or D1.CurrentCell.ColumnIndex = 1 Or D1.CurrentCell.ColumnIndex = 0) And D1.CurrentRow.Cells(17).Value = 1 Then
                    editDate.Show()
                End If
            End If
            webDialer.Close()
            If D1.CurrentCell.ColumnIndex = 5 Then
                Dim SelectedThings As String = D1.CurrentCell.Value
                SelectedThings = SelectedThings.Replace(" ", "")
                Dim k As Integer = D1.CurrentCell.RowIndex
                D1.BeginEdit(True)
                D1(8, k).Value = D1(8, k).Value + " (" + System.DateTime.Now.ToShortTimeString.ToString + ") "
                D1.Rows(k).DefaultCellStyle.BackColor = Color.LightBlue
                Dim cm1 As New SqlCommand
                Dim Sqm As String
                Sqm = "update FullRoster set GPSCallTime=N'" & D1(8, k).Value & "',GPSOfficer = " & UserName & " where RID=" & D1(20, k).Value
                cm1 = New SqlCommand(Sqm, cn)
                cm1.ExecuteNonQuery()

                D1.EndEdit(True)
                If SelectedThings.Length = 9 Then
                    'https://rjammccmp.rj.com/webdialer/Webdialer?destination=90796743337&ref=devdevext
                    LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=90" & SelectedThings & "")
                ElseIf SelectedThings.Length = 7 Then
                    LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=9" & SelectedThings & "")
                ElseIf SelectedThings.Length = 4 Then
                    LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=" & SelectedThings & "")
                End If
            End If
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' save changes to datagrid to DB event
    Private Sub D1_CellValueChanged1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles D1.CellValueChanged
        If kg = 1 Then
            Try
                Dim k As String = D1.CurrentCell.Value.ToString
                Dim j As Integer = D1.CurrentCell.RowIndex
                If D1.CurrentCell.ColumnIndex = 15 Then
                    Dim upnote As New SqlCommand
                    upnote.CommandText = "Update FullRoster set DMnote = N'" & D1(15, j).Value & "',DM = " & UserName & "where RID=" & D1(20, j).Value
                    upnote.Connection = cn
                    upnote.ExecuteNonQuery()
                End If
                If D1.CurrentCell.ColumnIndex = 14 Then
                    Dim fgh As DateTime
                    Dim uparr As New SqlCommand
                    uparr.CommandText = "update FullRoster set ArrTime = N'" & D1(14, j).Value.ToString & "' ,DM = " & UserName & " where RID=" & D1(20, j).Value
                    uparr.Connection = cn
                    uparr.ExecuteNonQuery()
                    If D1.CurrentRow.Cells(14).Value.ToString = "" Then
                        Dim uplarr As New SqlCommand
                        uplarr.CommandText = "update FullRoster set late = '00:00:00' where RID=" & D1(20, j).Value
                        uplarr.Connection = cn
                        uplarr.ExecuteNonQuery()
                    Else
                        If D1(1, j).Value <= "22:00" And (D1(13, j).Value >= "00:00" And D1(13, j).Value <= "03:00") Then
                            D1(14, j).Value = Convert.ToDateTime(D1(14, j).Value).ToShortTimeString
                            fgh = Convert.ToDateTime(D1(14, j).Value).AddMinutes(+1440)
                            If fgh > Convert.ToDateTime(D1(13, j).Value) Then
                                D1.CurrentRow.DefaultCellStyle.BackColor = Color.Azure
                                Dim larr As TimeSpan
                                Dim brft As DateTime
                                brft = Convert.ToDateTime(D1(13, j).Value)
                                larr = brft.Subtract(fgh)
                                Dim uplarr As New SqlCommand
                                uplarr.CommandText = "update FullRoster set late = '" & larr.ToString & "' where RID=" & D1(20, j).Value
                                uplarr.Connection = cn
                                uplarr.ExecuteNonQuery()
                                If fgh < Convert.ToDateTime(D1(13, j).Value) Then
                                    uplarr.CommandText = "update FullRoster set late = '00:00:00' where RID=" & D1(20, j).Value
                                    uplarr.Connection = cn
                                    uplarr.ExecuteNonQuery()
                                End If
                            End If
                        End If

                        If Convert.ToDateTime(D1(14, j).Value) > Convert.ToDateTime(D1(13, j).Value) Then
                            D1.CurrentRow.DefaultCellStyle.BackColor = Color.Azure
                            Dim skld As New DateTime
                            skld = Convert.ToDateTime(D1(14, j).Value)
                            Dim larr As TimeSpan
                            Dim brft As DateTime
                            brft = Convert.ToDateTime(D1(13, j).Value)
                            larr = brft.Subtract(skld)
                            Dim uplarr As New SqlCommand
                            uplarr.CommandText = "update FullRoster set late = '" & larr.ToString & "' where RID=" & D1(20, j).Value
                            uplarr.Connection = cn
                            uplarr.ExecuteNonQuery()
                        End If
                    End If
                    If Convert.ToDateTime(D1(14, j).Value) < Convert.ToDateTime(D1(13, j).Value) Or D1(14, j).Value = "" Then
                        Dim uplarr As New SqlCommand
                        uplarr.CommandText = "update FullRoster set late = '00:00:00' where RID=" & D1(20, j).Value
                        uplarr.Connection = cn
                        uplarr.ExecuteNonQuery()
                    End If
                End If
                If D1.CurrentCell.ColumnIndex = 11 Then
                    Dim cm11 As New SqlCommand
                    Dim Sqmm As String
                    If D1(11, j).Value.ToString = "" Then
                        D1(11, j).Value = ""
                    End If
                    Dim jj As String = D1(0, j).Value

                    Dim v11 As String = D1(8, j).Value
                    Sqmm = "update FullRoster set GPSNote=N'" & D1(11, j).Value.ToString & "',GPSOfficer = " & UserName & "  where RID=" & D1(20, j).Value
                    cm11 = New SqlCommand(Sqmm, cn)
                    cm11.ExecuteNonQuery()
                    If D1(11, j).Value.ToString = "" Then
                        If v11 <> "" Then
                            D1.CurrentRow.DefaultCellStyle.BackColor = Color.LightBlue
                        ElseIf jj <> " " And v11 = "" Then
                            D1.CurrentRow.DefaultCellStyle.BackColor = Color.LightGray
                        Else
                            D1.CurrentRow.DefaultCellStyle.BackColor = Color.White
                        End If
                    End If
                End If

                If D1.CurrentCell.ColumnIndex = 9 Then
                    Dim cmt As New SqlCommand
                    Dim STt As String
                    Dim ST3 As String
                    Try
                        If D1(9, j).Value.ToString = "" Then
                            D1(10, j).Value = ""
                        End If
                        If D1(9, j).Value.ToString <> "" Then
                            If D1(9, j).Value.ToString.Length = 3 Then

                                STt = "select drname,Bus from bus where Buss = '" & D1(9, j).Value & "'"
                                Dim dk As New SqlDataAdapter(STt, cn)
                                Dim dm As New System.Data.DataTable
                                dk.Fill(dm)
                                D1(10, j).Value = dm.Rows(0).Item("drname")
                                D1(9, j).Value = dm.Rows(0).Item("Bus")
                            End If
                        End If

                        ST3 = "update FullRoster set Bus='" & D1(9, j).Value.ToString & "',Driver=N'" & D1(10, j).Value & "',TransOfficer = " & UserName & " where RID = " & D1(20, j).Value
                        cmt = New SqlCommand(ST3, cn)
                        cmt.ExecuteNonQuery()
                        Exit Sub
                    Catch ex As Exception
                        ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
                    End Try
                End If
                If D1.CurrentCell.ColumnIndex = 3 Then
                    If D1.CurrentCell.Value.ToString <> "" Then
                        Try
                            Dim Sqm As String
                            Sqm = "select * from mobile where ID=" & D1.CurrentCell.Value
                            Dim dnd As New SqlDataAdapter(Sqm, cn)
                            Dim dqd As New System.Data.DataTable
                            dnd.Fill(dqd)
                            If dqd.Rows(0).Item("areaa") = 3 Then
                                D1.Rows(D1.CurrentRow.Index).DefaultCellStyle.BackColor = Color.Tan
                                D1(11, D1.CurrentRow.Index).Value = "Alone"
                            End If
                            D1.Item(5, D1.CurrentRow.Index).Value = dqd.Rows(0).Item("Phone")
                            D1.Item(6, D1.CurrentRow.Index).Value = dqd.Rows(0).Item("Name")
                            D1.Item(7, D1.CurrentRow.Index).Value = dqd.Rows(0).Item("HomeAddress")
                            D1.Item(12, D1.CurrentRow.Index).Value = dqd.Rows(0).Item("areaa")

                            Dim ST5 As String
                            Dim cm5 As New SqlCommand
                            ST5 = "update FullRoster set CMobile='" & D1(5, j).Value & "',CArName=N'" & D1(6, j).Value & "',CAdd=N'" & D1(7, j).Value & "',Area=" & dqd.Rows(0).Item("areaa") & "where RID=" & D1(20, j).Value
                            cm5 = New SqlCommand(ST5, cn)
                            cm5.ExecuteNonQuery()
                            Try
                                Dim cm As New SqlCommand
                                Dim STh As String
                            Catch ex As Exception
                                ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
                            End Try

                        Catch ex As Exception
                            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
                            D1.Item(5, D1.CurrentRow.Index).Value = "NO Match"
                            D1.Item(6, D1.CurrentRow.Index).Value = "No Match"
                            D1.Item(7, D1.CurrentRow.Index).Value = "No Match"
                        End Try
                    End If
                End If
            Catch ex As Exception
                ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
            End Try
        End If
    End Sub

    ' keydown event on datagrid to handle different actions based on user role and pressed key
    Private Sub D1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles D1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                webDialer.Close()
                If D1.CurrentCell.ColumnIndex = 5 Then
                    Dim SelectedThings As String = D1.CurrentCell.Value
                    SelectedThings = SelectedThings.Replace(" ", "")
                    Dim k As Integer = D1.CurrentCell.RowIndex
                    D1.BeginEdit(True)

                    D1(8, k).Value = D1(8, k).Value + " (" + System.DateTime.Now.ToShortTimeString.ToString + ") "
                    D1.Rows(k).DefaultCellStyle.BackColor = Color.LightBlue

                    Dim cm1 As New SqlCommand
                    Dim Sqm As String

                    Sqm = "update FullRoster set GPSCallTime=N'" & D1(8, k).Value & "',GPSOfficer = " & UserName & " where RID=" & D1(20, k).Value
                    cm1 = New SqlCommand(Sqm, cn)
                    cm1.ExecuteNonQuery()
                    D1.EndEdit(True)
                    If SelectedThings.Length = 9 Then
                        LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=90" & SelectedThings & "")
                    ElseIf SelectedThings.Length = 7 Then
                        LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=9" & SelectedThings & "")
                    ElseIf SelectedThings.Length = 4 Then
                        LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=" & SelectedThings & "")
                    End If
                    webDialer.Close()
                End If
            Catch ex As Exception
                ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
                MessageBox.Show(ex.Message)
            End Try
        End If
        If rosterSearch.Visible = True Then
            If e.KeyData = Keys.Space Or e.KeyData = Keys.Right Then
                rosterSearch.Button3.PerformClick()
            End If
        End If

        If e.KeyData = Keys.Control + Keys.F Then
            rosterSearch.Show()
        End If

        If e.KeyData = Keys.Control + Keys.F1 Then
            webDialer.Owner = Me
            webDialer.Close()
            webDialer.Show()
            LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer")
        End If
    End Sub

    ' right click event on datagrid to show/hide context menu based on user role and row index
    Private Sub D1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles D1.MouseDown
        If userper = 3 Or userper = 2 Or userper = 6 Or UserName = 1 Then
            If D1.CurrentRow.Index > D1.RowCount - 10 Then
                If MouseButtons = System.Windows.Forms.MouseButtons.Right Then
                    Panel2.Location = New System.Drawing.Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y - 270)
                    Panel2.Visible = True
                Else
                    If MouseButtons = System.Windows.Forms.MouseButtons.Left Then
                        Panel2.Visible = False
                    End If
                End If
            Else
                If MouseButtons = System.Windows.Forms.MouseButtons.Right Then
                    Panel2.Location = New System.Drawing.Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y - 130)
                    Panel2.Visible = True
                Else
                    If MouseButtons = System.Windows.Forms.MouseButtons.Left Then
                        Panel2.Visible = False
                    End If
                End If
            End If
        End If
    End Sub

    ' click event on context menu label to open insert new contact form
    Private Sub Label12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        Panel2.Hide()
        insertnew.Show()
    End Sub

    ' mouse hover event on context menu label to underline text
    Private Sub Label12_MouseHover1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label12.MouseHover
        Label12.Font = New System.Drawing.Font(Label12.Font, FontStyle.Underline)
    End Sub

    ' click event on context menu label to mark selected row as deleted
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        Dim cm1 As New SqlCommand
        Dim k As Integer = D1.CurrentRow.Index
        Dim Sqm As String
        Try
            Sqm = "update FullRoster set GPSNote=N'Delete',GPSOfficer = " & UserName & ",DMnote=N'Delete " & System.DateTime.Now.ToShortTimeString & "' where RID=" & D1(20, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D1(11, k).Value = "Delete"
            D1(15, k).Value = "Delete " & System.DateTime.Now.ToShortTimeString
            D1.Rows(k).DefaultCellStyle.BackColor = Color.DarkOrange
            D1.Rows(k).DefaultCellStyle.ForeColor = Color.Black
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")

        End Try
        Panel2.Visible = False
    End Sub

    ' mouse hover event on context menu label to underline text
    Private Sub Label12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label12.MouseLeave
        Label12.Font = New System.Drawing.Font(Label12.Font, FontStyle.Regular)
    End Sub

    ' mouse hover event on context menu label to underline text
    Private Sub Label13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label13.MouseHover
        Label13.Font = New System.Drawing.Font(Label13.Font, FontStyle.Underline)
    End Sub

    ' mouse leave event on context menu label to remove underline from text
    Private Sub Label13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label13.MouseLeave
        Label13.Font = New System.Drawing.Font(Label13.Font, FontStyle.Regular)
    End Sub

    ' event when user enters the CGS tab to hide the search form if open
    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cgsTab.Enter
        If kg4 = 1 Then
            If rosterSearch.Visible Then
                rosterSearch.Hide()
            End If
        End If
    End Sub

    ' keypress event on textbox to allow only numeric input
    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    ' text changed event on textbox to perform search when text is entered
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox10.Text = ""
        Else

            Button10.PerformClick()
        End If
    End Sub

    ' resize event on form to center certain controls
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Label15.Left = (Me.ClientSize.Width - Label15.Width) / 2

        Panel5.Left = (Me.ClientSize.Width - Panel5.Width) / 2
        Panel5.Top = (Me.ClientSize.Height - Panel5.Height) / 2
        '  D3.Left = (Me.ClientSize.Width - D3.Width) / 2
    End Sub

    ' double click event on Roster tab to show the search form if it is hidden
    Private Sub TabPage1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles rosterTab.DoubleClick
        If rosterSearch.Visible Then
            rosterSearch.Show()
        End If
    End Sub

    ' event when user enters the Ground Staff tab to show the search form if it is hidden
    Private Sub TabPage6_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles groundStaffTab.Enter
        If kg4 = 1 Then
            If rosterSearch.Visible Then
                rosterSearch.Show()
            End If
        End If
    End Sub

    ' event when user leaves the Ground Staff tab to hide the search form if it is open
    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        Try
            Dim cm1 As New SqlCommand
            Dim k As Integer = D1.CurrentRow.Index
            Dim Sqm As String
            Sqm = "update FullRoster set GPSNote=N'NO SHOW',GPSOfficer = " & UserName & ",DMnote=N'NO SHOW " & System.DateTime.Now.ToShortTimeString & "'  where RID=" & D1(20, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D1(11, k).Value = "NO SHOW"
            D1(15, k).Value = "NO SHOW " & System.DateTime.Now.ToShortTimeString
            D1.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        Panel2.Visible = False
    End Sub

    ' mouse hover event on context menu label to underline text
    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        Dim cm1 As New SqlCommand
        Dim k As Integer = D1.CurrentRow.Index
        Dim Sqm As String
        Try
            Sqm = "update FullRoster set GPSNote=N'CANCEL ON CALL',GPSOfficer = " & UserName & ",DMnote=N'CANCEL ON CALL " & System.DateTime.Now.ToShortTimeString & "'  where RID=" & D1(20, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D1(11, k).Value = "CANCEL ON CALL"
            D1(15, k).Value = "CANCEL ON CALL " & System.DateTime.Now.ToShortTimeString
            D1.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        Panel2.Visible = False
    End Sub

    ' mouse hover event on context menu label to underline text
    Private Sub D2_CellContentDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles D2.CellContentDoubleClick
        Try
            If userper = 2 Or userper = 3 Or userper = 6 And ToolStripComboBox1.SelectedText.ToString <> "ALL" Then
                If D2.CurrentCell.ColumnIndex = 1 Then
                    sendmailGFS(D2.CurrentRow.Cells(0).Value, D2.CurrentRow.Cells(1).Value)
                End If
            End If
            If D2.CurrentCell.ColumnIndex = 9 And D2.CurrentCell.Value <> "" Then
                If userper = 2 Or userper = 3 Or userper = 6 Or userper = 4 Then
                    locator(D2.CurrentCell.Value)
                End If
            End If
            webDialer.Close()
            If D2.CurrentCell.ColumnIndex = 2 Then
                D2.CurrentRow.DefaultCellStyle.BackColor = Color.LightBlue
                Dim SelectedThings As String = D2.CurrentCell.Value

                SelectedThings = SelectedThings.Replace(" ", "")
                Dim k As Integer = D2.CurrentCell.RowIndex

                D2.EndEdit(True)
                If SelectedThings.Length = 9 Then
                    LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=90" & SelectedThings & "")
                ElseIf SelectedThings.Length = 7 Then
                    LoadWebdialer("https://rjammccmp.rj.com/webdialer/Webdialer?destination=9" & SelectedThings & "")
                End If
            End If
            If ToolStripComboBox1.SelectedText.ToString <> "ALL" And D2.CurrentCell.ColumnIndex = 2 Then
                D2.BeginEdit(True)
                D2.CurrentRow.Cells(5).Value = D2.CurrentRow.Cells(5).Value + " (" + DateAndTime.Now.ToLongTimeString.ToString + ") "

                D2.EndEdit(True)
                Dim cm1 As New SqlCommand
                Dim kk As Integer = D2.CurrentRow.Index
                Dim Sqm As String

                Sqm = "update GSShift set GPSCallTime='" & D2(5, kk).Value & "', GPSCaller = " & UserName & "where GSShID = " & D2(15, kk).Value
                cm1 = New SqlCommand(Sqm, cn)
                cm1.ExecuteNonQuery()
            End If
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
    End Sub

    ' right click event on datagrid to select row
    Private Sub D2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles D2.CellMouseClick
        Try
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                D2.Rows(e.RowIndex).Selected = True
                D2.CurrentCell = D2.Rows(e.RowIndex).Cells(0)
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' double click event on datagrid to perform different actions based on user role and clicked column
    Private Sub D2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles D2.CellMouseDoubleClick
        If userper = 4 Or userper = 2 Or userper = 3 Or userper = 6 Then
            If D2.CurrentCell.ColumnIndex = 9 Then
                locator(D2.CurrentCell.Value)
            End If
        End If
    End Sub

    ' keydown event on datagrid to handle different actions based on user role and pressed key
    Private Sub D2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles D2.CellMouseDown
        Try
            If userper = 3 Or userper = 2 Or userper = 6 Then
                If System.DateTime.Now.Hour > 5 And System.DateTime.Now.Hour < 20 Then
                    MenuStrip2.Enabled = True
                Else
                    MenuStrip2.Enabled = False
                End If
                If MouseButtons = System.Windows.Forms.MouseButtons.Right Then
                    If ToolStripComboBox1.SelectedIndex = 0 Then
                        If D2.CurrentRow.Index < 20 Then
                            Panel4.Location = New System.Drawing.Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y - 100)
                            Panel4.Visible = True
                            ShifteToolStripMenuItem.Visible = True
                        Else
                            Panel4.Location = New System.Drawing.Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y - 240)
                            Panel4.Visible = True
                            ShifteToolStripMenuItem.Visible = True
                        End If
                    Else
                        If D2.CurrentRow.Index < 20 Then
                            Panel4.Location = New System.Drawing.Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y - 100)
                            Panel4.Visible = True
                            ShifteToolStripMenuItem.Visible = False
                        Else
                            Panel4.Location = New System.Drawing.Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y - 240)
                            Panel4.Visible = True
                            ShifteToolStripMenuItem.Visible = False

                        End If
                    End If
                Else
                    If MouseButtons = System.Windows.Forms.MouseButtons.Left Then
                        Panel4.Visible = False
                        MonthCalendar1.Visible = False
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' click event on context menu label to mark selected row as no show
    Private Sub Label21_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label21.MouseHover
        Label21.Font = New System.Drawing.Font(Label21.Font, FontStyle.Underline)
    End Sub

    ' mouse leave event on context menu label to remove underline from text
    Private Sub Label21_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label21.MouseLeave
        Label21.Font = New System.Drawing.Font(Label21.Font, FontStyle.Regular)
    End Sub

    ' click event on context menu label to mark selected row as cancel on call
    Private Sub Label22_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label22.MouseHover
        Label22.Font = New System.Drawing.Font(Label22.Font, FontStyle.Underline)
    End Sub

    ' mouse leave event on context menu label to remove underline from text
    Private Sub Label22_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label22.MouseLeave
        Label22.Font = New System.Drawing.Font(Label22.Font, FontStyle.Regular)
    End Sub

    ' event when user leaves the Driver Link tab to hide the search form if it is open
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim node As TreeNode
        node = e.Node
        If node.Name = "Node7" Then
            GroupBox3.Visible = False
            GroupBox4.Visible = False
            GroupBox5.Visible = False
            GroupBox2.Visible = True
            GroupBox2.Dock = DockStyle.Top
        ElseIf node.Name = "Node8" Then
            GroupBox2.Visible = False
            GroupBox4.Visible = False
            GroupBox5.Visible = False
            GroupBox3.Visible = True
            GroupBox3.Dock = DockStyle.Top
        ElseIf node.Name = "Node14" Then
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox5.Visible = False
            GroupBox4.Visible = True
            GroupBox4.Dock = DockStyle.Top
        ElseIf node.Name = "Node1" Then
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = False
            GroupBox5.Visible = True
            GroupBox5.Dock = DockStyle.Top
        End If
    End Sub

    ' Add new Ground Staff member to the database
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Dim cm As New SqlCommand
        Try
            Dim area As Integer
            If ComboBox12.SelectedIndex = 0 Then
                area = 1
            Else
                area = 2
            End If
            Dim ST As String
            ST = "insert into Gss(Id,Name,Phone,addd,Area) values (" & TextBox18.Text & ",N'" & TextBox19.Text & "','" & TextBox17.Text & "',N'" & TextBox16.Text & "'," & area & ")"
            cm = New SqlCommand(ST, cn)
            TextBox18.Text = ""
            TextBox19.Text = ""
            TextBox17.Text = ""
            TextBox16.Text = ""

            Label32.Text = "Saved"
            cm.ExecuteNonQuery()
        Catch ex As Exception
            Label32.Text = "There was an error, please make sure the information entered correctly and try again"
            MessageBox.Show(ex.Message)
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
    End Sub

    ' click event on context menu label to open the selected date in calendar
    Private Sub OpenToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenToolStripButton.PerformClick()
    End Sub

    ' click event on context menu label to close the application
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    ' click event on context menu label to refresh the CGS datagrid
    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.GSTableAdapter.FillBy(Me.CMNDataSet1.GS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' event when user enters the Driver Link tab to hide the search form if it is open
    Private Sub TabPage3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles driverLinkTab.Enter
        If rosterSearch.Visible Then
            rosterSearch.Hide()
        End If
    End Sub

    ' event when user enters the Crew Management tab to hide the search form if it is open
    Private Sub TabPage4_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        If rosterSearch.Visible Then
            rosterSearch.Hide()
        End If
    End Sub

    ' Delete a crew member from the database
    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Dim cm As New SqlCommand
        Dim cm1 As New SqlCommand
        Try
            Dim ST As String
            ST = "DELETE FROM mobile WHERE Id = " & Label8.Text
            cm = New SqlCommand(ST, cn)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox10.Text = ""
            Label8.Text = ""
            ComboBox2.Text = ""
            Label19.Text = "Deleted"
            cm.ExecuteNonQuery()
        Catch ex As Exception
            Label32.Text = "There was an error, please make sure the information entered correctly and try again"
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
    End Sub

    ' click event on about menu item to show the about box
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    ' cell value changed event on datagrid to update driver name in bus table
    Private Sub D3_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles D3.CellValueChanged
        If kg = 1 Then
            Try
                Dim cm As New SqlCommand
                Dim dmm As New System.Data.DataTable
                Dim ST As String
                If D3.CurrentCell.Value.ToString <> "" Then
                    If D3.CurrentCell.Value.ToString.Length = 3 Then
                        ST = "select * from bus where Buss= '" & D3.CurrentRow.Cells(1).Value & "'"
                        Dim dkk As New SqlDataAdapter(ST, cn)
                        dkk.Fill(dmm)
                        D3.CurrentRow.Cells(1).Value = dmm.Rows(0).Item("Bus")
                    End If
                End If
                Dim cm1 As New SqlCommand
                Dim Sqm As String
                Sqm = "update bus set drname=N'" & D3.CurrentRow.Cells(0).Value & "'  where Bus= '" & dmm.Rows(0).Item("Bus") & "'"
                cm1 = New SqlCommand(Sqm, cn)
                cm1.ExecuteNonQuery()

                Dim cm11 As New SqlCommand
                Dim Sqm1 As String
                Sqm1 = "update bus set drname=N''  where Bus <> '" & dmm.Rows(0).Item("Bus") & "' and drname=N'" & D3.CurrentRow.Cells(0).Value & "'"
                cm11 = New SqlCommand(Sqm1, cn)
                cm11.ExecuteNonQuery()
            Catch ex As Exception
            End Try
            circlebuses()

        End If
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.ShiftKey Then
            ToolStripButton1.PerformClick()
        End If
    End Sub

    ' click event on search button to find and display crew member details
    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If ToolStripTextBox1.Text <> "" Then
            Dim cmdOLEDB As New SqlCommand
            Dim SQL As String
            Dim i As Integer = 0

            Try
                If IsNumeric(ToolStripTextBox1.Text) Then
                    SQL = "select * from mobile where Id= " & ToolStripTextBox1.Text
                    Dim dn As New SqlDataAdapter(SQL, cn)
                    Dim dq As New System.Data.DataTable
                    dn.Fill(dq)
                    Dim yy As String = dq.Rows(0).Item("Name").ToString.Replace("ـ", "")
                    crewSearch.TextBox1.Text = dq.Rows(0).Item("ID")
                    crewSearch.TextBox3.Text = dq.Rows(0).Item("Phone")
                    crewSearch.TextBox2.Text = yy.Replace("*", "")
                    crewSearch.TextBox4.Text = dq.Rows(0).Item("HomeAddress")
                    crewSearch.Show()
                Else
                    'MessageBox.Show(ToolStripTextBox1.Text)
                    SQL = "select * from mobile where Name =N'" & ToolStripTextBox1.Text & "'"
                    Dim dnx As New SqlDataAdapter(SQL, cn)
                    Dim dqx As New System.Data.DataTable
                    dnx.Fill(dqx)

                    Dim yy As String = dqx.Rows(0).Item("Name").ToString.Replace("ـ", "")
                    crewSearch.TextBox1.Text = dqx.Rows(0).Item("ID")
                    crewSearch.TextBox3.Text = dqx.Rows(0).Item("Phone")
                    crewSearch.TextBox3.Select()
                    crewSearch.TextBox2.Text = yy.Replace("*", "")
                    crewSearch.TextBox4.Text = dqx.Rows(0).Item("HomeAddress")
                    crewSearch.Show()
                End If
            Catch ex As Exception
                ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
            End Try
        End If
    End Sub

    ' timer tick event to refresh the roster data every 15 minutes
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        UPDATEToolStripMenuItem.PerformClick()
    End Sub

    ' click event on refresh button to reload the roster data
    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Dim sw As New Stopwatch()
        sw.Start()
        BottomLabel.Text = "Loading Roster, Please wait"
        BottomLabel.Refresh()
        If kg <> 1 Then Return
        D1.DataSource = Nothing
        D1.Columns.Clear()
        Dim sql As String = "select * from FullRoster where FDate = N'" & ToolStripLabel1.Text & "' order by PickupTime ,RNum,RID"
        Dim da As New SqlDataAdapter(sql, cn)
        roster.Clear()
        da.Fill(roster)
        D1.DataSource = roster

        ' Set readonly/fonts as original (guarded)
        Try
            If D1.Columns.Count > 0 Then D1.Columns(0).ReadOnly = True
            If D1.Columns.Count > 1 Then D1.Columns(1).ReadOnly = True
            If D1.Columns.Count > 2 Then D1.Columns(2).ReadOnly = True
            If D1.Columns.Count > 4 Then D1.Columns(4).ReadOnly = True
            If D1.Columns.Count > 5 Then D1.Columns(5).ReadOnly = True
            If D1.Columns.Count > 6 Then D1.Columns(6).ReadOnly = True
            If D1.Columns.Count > 7 Then D1.Columns(7).ReadOnly = True
            If D1.Columns.Count > 8 Then D1.Columns(8).ReadOnly = True
            If D1.Columns.Count > 10 Then D1.Columns(10).ReadOnly = True
            If D1.Columns.Count > 13 Then D1.Columns(13).ReadOnly = True

            If D1.Columns.Count > 5 Then D1.Columns(5).DefaultCellStyle.Font = New System.Drawing.Font("Arial", 14, FontStyle.Bold)
            If D1.Columns.Count > 6 Then
                D1.Columns(6).DefaultCellStyle.Font = New System.Drawing.Font("Arial", 12, FontStyle.Bold)
                D1.Columns(6).DefaultCellStyle.ForeColor = Color.Red
            End If
        Catch
            BottomLabel.Text = ""
            BottomLabel.Refresh()
        End Try

        Try : D1.EnableHeadersVisualStyles = False : Catch : End Try
        Try
            Dim dgvType = D1.GetType()
            Dim pi = dgvType.GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
            If pi IsNot Nothing Then pi.SetValue(D1, True, Nothing)
        Catch
            BottomLabel.Text = ""
            BottomLabel.Refresh()
        End Try

        ' preserve original RID behavior/order
        Dim updateRIDs As New List(Of Integer)

        Dim oldVisible As Boolean = D1.Visible
        Try : D1.Visible = False : Catch : End Try
        D1.SuspendLayout()

        If roster Is Nothing OrElse roster.Rows.Count < 2 Then
            D1.ResumeLayout()
            Try : D1.Visible = oldVisible : Catch : End Try
            D1.Refresh()
        Else
            Dim data As DataTable = roster

            ' Cache metadata once
            Dim hasRID As Boolean = data.Columns.Contains("RID")
            Dim ridIdx As Integer = If(hasRID, data.Columns("RID").Ordinal, -1)
            Dim hasGPS As Boolean = data.Columns.Contains("GPSnote")
            Dim gpsIdx As Integer = If(hasGPS, data.Columns("GPSnote").Ordinal, -1)
            Dim hasArea As Boolean = data.Columns.Contains("Area")
            Dim areaIdx As Integer = If(hasArea, data.Columns("Area").Ordinal, -1)
            Dim colCount As Integer = data.Columns.Count
            Dim hasCol17 As Boolean = (colCount > 17)
            Dim hasCol12 As Boolean = (colCount > 12)
            Dim hasCol8 As Boolean = (colCount > 8)

            Dim rowsCount As Integer = data.Rows.Count

            ' Snapshot once (ItemArray is object() — cheap)
            Dim snapshots(rowsCount - 1)() As Object
            For i As Integer = 0 To rowsCount - 1
                snapshots(i) = data.Rows(i).ItemArray
            Next

            ' Prepare result arrays (per-row)
            Dim desiredBack(rowsCount - 1) As Integer
            For i As Integer = 0 To rowsCount - 1 : desiredBack(i) = -1 : Next
            Dim rowReadOnly(rowsCount - 1) As Boolean
            Dim setDGVCell11AsAlone(rowsCount - 1) As Boolean
            Dim enableCell0_1(rowsCount - 1) As Boolean
            Dim rowHadError(rowsCount - 1) As Boolean
            Dim setDataTableGPSAlone(rowsCount - 1) As Boolean
            Dim setDataTableCols012Blank(rowsCount - 1) As Boolean
            Dim ridVals(rowsCount - 1) As Integer
            Dim errorMsgs(rowsCount - 1) As String

            ' Cached color ints (local copies)
            Dim colTan = Color.Tan.ToArgb()
            Dim colLightGray = Color.LightGray.ToArgb()
            Dim colDarkOrange = Color.DarkOrange.ToArgb()
            Dim colLightGreen = Color.LightGreen.ToArgb()
            Dim colYellow = Color.Yellow.ToArgb()
            Dim colPink = Color.Pink.ToArgb()
            Dim colViolet = Color.Violet.ToArgb()
            Dim colLightBlue = Color.LightBlue.ToArgb()

            ' Parallel options: leave one core free for UI responsiveness
            Dim po As New ParallelOptions()
            Dim procs = Environment.ProcessorCount
            po.MaxDegreeOfParallelism = Math.Max(1, Math.Min(procs - 1, procs)) ' prefer procs-1, fallback to 1

            ' PARALLEL COMPUTE - thread-safe (each index only written by that index)
            Parallel.For(0, rowsCount, po, Sub(i)
                                               Try
                                                   Dim snap = snapshots(i)
                                                   Dim rosterGPSnote As String = ""
                                                   If hasGPS AndAlso gpsIdx >= 0 AndAlso gpsIdx < snap.Length Then
                                                       If snap(gpsIdx) IsNot Nothing AndAlso Not IsDBNull(snap(gpsIdx)) Then rosterGPSnote = Convert.ToString(snap(gpsIdx)) Else rosterGPSnote = ""
                                                   End If

                                                   Dim areaInt As Integer = 0
                                                   If hasArea AndAlso areaIdx >= 0 AndAlso areaIdx < snap.Length Then
                                                       If snap(areaIdx) IsNot Nothing AndAlso Not IsDBNull(snap(areaIdx)) Then Integer.TryParse(Convert.ToString(snap(areaIdx)), areaInt)
                                                   End If

                                                   If userper = 1 AndAlso rosterGPSnote.Contains("Switched") Then
                                                       rowReadOnly(i) = True
                                                   End If

                                                   If areaInt = 3 AndAlso rosterGPSnote = "Alone" Then
                                                       desiredBack(i) = colTan
                                                       If hasGPS Then
                                                           setDataTableGPSAlone(i) = True
                                                       Else
                                                           setDGVCell11AsAlone(i) = True
                                                       End If

                                                       If hasRID AndAlso ridIdx >= 0 AndAlso ridIdx < snap.Length Then
                                                           If snap(ridIdx) IsNot Nothing AndAlso Not IsDBNull(snap(ridIdx)) Then
                                                               Dim rv As Integer = 0
                                                               Integer.TryParse(Convert.ToString(snap(ridIdx)), rv)
                                                               If rv <> 0 Then ridVals(i) = rv
                                                           End If
                                                       End If
                                                   End If

                                                   Dim col17Int As Integer = 0
                                                   If hasCol17 AndAlso 17 < snap.Length Then
                                                       If snap(17) IsNot Nothing AndAlso Not IsDBNull(snap(17)) Then Integer.TryParse(Convert.ToString(snap(17)), col17Int)
                                                   End If

                                                   If col17Int = 0 Then
                                                       setDataTableCols012Blank(i) = True
                                                   Else
                                                       desiredBack(i) = colLightGray
                                                       enableCell0_1(i) = True
                                                   End If

                                                   Dim gpsNote As String = rosterGPSnote
                                                   If Not hasGPS Then gpsNote = ""

                                                   If gpsNote.Contains("Delete") Then
                                                       desiredBack(i) = colDarkOrange
                                                   ElseIf gpsNote.Contains("NO SHOW") Then
                                                       desiredBack(i) = colLightGreen
                                                   ElseIf gpsNote.Contains("CANCEL ON CALL") Then
                                                       desiredBack(i) = colYellow
                                                   ElseIf gpsNote.Contains("Alone") Then
                                                       desiredBack(i) = colTan
                                                   ElseIf gpsNote.Contains("New Inserted") Then
                                                       Dim col12Int As Integer = 0
                                                       If hasCol12 AndAlso 12 < snap.Length Then
                                                           If snap(12) IsNot Nothing AndAlso Not IsDBNull(snap(12)) Then Integer.TryParse(Convert.ToString(snap(12)), col12Int)
                                                       End If

                                                       If col12Int = 3 Then
                                                           desiredBack(i) = colTan
                                                           If hasGPS Then
                                                               setDataTableGPSAlone(i) = True
                                                           Else
                                                               setDGVCell11AsAlone(i) = True
                                                           End If

                                                           If hasRID AndAlso ridIdx >= 0 AndAlso ridIdx < snap.Length Then
                                                               If snap(ridIdx) IsNot Nothing AndAlso Not IsDBNull(snap(ridIdx)) Then
                                                                   Dim rv2 As Integer = 0
                                                                   Integer.TryParse(Convert.ToString(snap(ridIdx)), rv2)
                                                                   If rv2 <> 0 Then ridVals(i) = rv2
                                                               End If
                                                           End If
                                                       Else
                                                           desiredBack(i) = colPink
                                                       End If
                                                   ElseIf gpsNote.Contains("Switched") Then
                                                       desiredBack(i) = colViolet
                                                       If userper = 1 Then rowReadOnly(i) = True
                                                   End If

                                                   If hasCol8 AndAlso 8 < snap.Length Then
                                                       If snap(8) IsNot Nothing AndAlso Not IsDBNull(snap(8)) Then
                                                           If Convert.ToString(snap(8)) <> "" Then
                                                               desiredBack(i) = colLightBlue
                                                           End If
                                                       End If
                                                   End If

                                               Catch ex As Exception
                                                   rowHadError(i) = True
                                                   errorMsgs(i) = ex.Message + "Application Comment: ****" + ex.StackTrace() + "****"
                                               End Try
                                           End Sub)

            ' SINGLE-THREADED APPLY PASS (DataTable + DGV writes, in original order)
            Dim rowsToTouch As Integer = Math.Min(D1.Rows.Count, rowsCount)
            For i As Integer = 0 To rowsToTouch - 1
                Try
                    If rowHadError(i) Then
                        ' exact per-row fallback writes
                        Try
                            If D1.Columns.Count > 0 Then D1.Item(0, i).Value = " "
                            If D1.Columns.Count > 1 Then D1.Item(1, i).Value = " "
                            If D1.Columns.Count > 2 Then D1.Item(2, i).Value = " "
                            If D1.Columns.Count > 5 Then D1.Item(5, i).Value = "No Data"
                            If D1.Columns.Count > 6 Then D1.Item(6, i).Value = "No Data"
                            If D1.Columns.Count > 7 Then D1.Item(7, i).Value = "No Data"
                            If D1.Columns.Count > 8 Then D1.Item(8, i).Value = ""
                            If D1.Columns.Count > 9 Then D1.Item(9, i).Value = ""
                            If D1.Columns.Count > 10 Then D1.Item(10, i).Value = ""
                            If D1.Columns.Count > 11 Then D1.Item(11, i).Value = ""
                            If D1.Columns.Count > 12 Then D1.Item(12, i).Value = 10
                        Catch
                            BottomLabel.Text = ""
                            BottomLabel.Refresh()
                        End Try
                        If Not String.IsNullOrEmpty(errorMsgs(i)) Then ErrorLog(errorMsgs(i))
                        Continue For
                    End If

                    Dim dgvRow As DataGridViewRow = D1.Rows(i)
                    Dim dtRow As DataRow = data.Rows(i)

                    ' apply DataTable changes
                    If setDataTableGPSAlone(i) AndAlso hasGPS Then
                        Try : dtRow(gpsIdx) = "Alone" : Catch : End Try
                    End If
                    If setDataTableCols012Blank(i) Then
                        Try
                            If colCount > 0 Then dtRow(0) = ""
                            If colCount > 1 Then dtRow(1) = ""
                            If colCount > 2 Then dtRow(2) = ""
                        Catch : End Try
                    End If

                    If rowReadOnly(i) Then dgvRow.ReadOnly = True

                    If setDGVCell11AsAlone(i) Then
                        If dgvRow.Cells.Count > 11 Then dgvRow.Cells(11).Value = "Alone"
                    End If

                    If enableCell0_1(i) Then
                        If dgvRow.Cells.Count > 1 Then dgvRow.Cells(1).ReadOnly = False
                        If dgvRow.Cells.Count > 0 Then dgvRow.Cells(0).ReadOnly = False
                    Else
                        If colCount <= 2 Then
                            If dgvRow.Cells.Count > 0 Then dgvRow.Cells(0).Value = ""
                            If dgvRow.Cells.Count > 1 Then dgvRow.Cells(1).Value = ""
                            If dgvRow.Cells.Count > 2 Then dgvRow.Cells(2).Value = ""
                        End If
                    End If

                    If desiredBack(i) <> -1 Then dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(desiredBack(i))

                Catch ex As Exception
                    ' fallback exactly like original
                    Try
                        If D1.Columns.Count > 0 Then D1.Item(0, i).Value = " "
                        If D1.Columns.Count > 1 Then D1.Item(1, i).Value = " "
                        If D1.Columns.Count > 2 Then D1.Item(2, i).Value = " "
                        If D1.Columns.Count > 5 Then D1.Item(5, i).Value = "No Data"
                        If D1.Columns.Count > 6 Then D1.Item(6, i).Value = "No Data"
                        If D1.Columns.Count > 7 Then D1.Item(7, i).Value = "No Data"
                        If D1.Columns.Count > 8 Then D1.Item(8, i).Value = ""
                        If D1.Columns.Count > 9 Then D1.Item(9, i).Value = ""
                        If D1.Columns.Count > 10 Then D1.Item(10, i).Value = ""
                        If D1.Columns.Count > 11 Then D1.Item(11, i).Value = ""
                        If D1.Columns.Count > 12 Then D1.Item(12, i).Value = 10
                    Catch
                        BottomLabel.Text = ""
                        BottomLabel.Refresh()
                    End Try
                    ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
                End Try
            Next

            ' rebuild updateRIDs in original row order and preserve original .Distinct() behavior
            For i As Integer = 0 To rowsCount - 1
                If ridVals(i) <> 0 Then updateRIDs.Add(ridVals(i))
            Next
        End If

        ' Resume layout & final UI work
        D1.ResumeLayout()
        Try : D1.Visible = oldVisible : Catch : End Try
        D1.Refresh()

        If updateRIDs.Count > 0 Then
            updateRIDs = updateRIDs.Distinct().ToList()
            Dim ids As String = String.Join(",", updateRIDs)
            Dim Sqm As String = "UPDATE FullRoster SET GPSNote = N'Alone' WHERE RID IN (" & ids & ")"
            Using cm1 As New SqlCommand(Sqm, cn)
                cm1.ExecuteNonQuery()
            End Using
        End If

        Panel1.Visible = False
        Label15.Visible = False
        Me.WindowState = FormWindowState.Maximized
        Panel1.Visible = False
        kg = 1

        Try
            For c As Integer = 0 To 18
                If D1.Columns.Count > c Then D1.Columns(c).SortMode = DataGridViewColumnSortMode.NotSortable
            Next
        Catch
            BottomLabel.Text = ""
            BottomLabel.Refresh()
        End Try

        rosterper(UserName)
        ' Show success message
        BottomLabel.Text = "Roster Loaded Successfully."
        ' Use a timer to clear the message after 2 seconds
        Dim t As New Timer()
        t.Interval = 2000
        AddHandler t.Tick, Sub()
                               BottomLabel.Text = ""
                               t.Stop()
                           End Sub
        t.Start()
        Timer2.Start()

        sw.Stop()

        ErrorLog("ToolStripButton6_Click elapsed: " & sw.ElapsedMilliseconds.ToString() & " ms")
    End Sub

    ' click event on open button to load a new roster from an Excel file
    Private Sub OpenToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        D1.DataSource = Nothing
        D1.Refresh()
        Dim apppath As String
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Select Roster"
        fd.InitialDirectory = "\Desktop"
        fd.Filter = "All files (*.xlsx)|*.xlsx|All files (*.xlsx)|*.xlsx"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            Label11.Text = 1
            If D1.Columns.Count <> 0 Then
                Panel1.Visible = True
                Label15.Visible = True
                For rr = 0 To D1.Columns.Count - 1
                    D1.Columns.Remove(D1.Columns(0).Name)
                Next
            End If

            apppath = fd.FileName

            Me.OPen(D1, apppath)
            Panel1.Visible = False

            Label15.Visible = False

            Me.WindowState = FormWindowState.Maximized
            Dim loader As New SqlCommand
            loader.CommandText = "insert into loader values (N'" & System.DateTime.Now & "'," & UserName & ",N'" & apppath & "')"
            loader.Connection = cn
            loader.ExecuteNonQuery()

        End If
        Timer3.Start()
        kg = 1
    End Sub

    ' click event on context menu label to open the search form
    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cnnOLEDB As New OleDb.OleDbConnection
        Dim cmdOLEDB As New SqlCommand
        Dim SQL As String
        Dim i As Integer = 0

        Try
            If IsNumeric(ToolStripTextBox1.Text) Then
                SQL = "select * from mobile where Id= " & ToolStripTextBox1.Text
                Dim dn As New SqlDataAdapter(SQL, cn)
                Dim dq As New System.Data.DataTable
                dn.Fill(dq)
                Dim yy As String = dq.Rows(0).Item("Name").ToString.Replace("ـ", "")
                crewSearch.TextBox1.Text = dq.Rows(0).Item("ID")
                crewSearch.TextBox3.Text = dq.Rows(0).Item("Phone")
                crewSearch.TextBox2.Text = yy.Replace("*", "")
                crewSearch.TextBox4.Text = dq.Rows(0).Item("HomeAddress")
                crewSearch.Show()
            Else
                SQL = "select * from mobile where Name like '" & ToolStripTextBox1.Text & "'"
                Dim dn As New SqlDataAdapter(SQL, cn)
                Dim dq As New System.Data.DataTable
                dn.Fill(dq)

                Dim yy As String = dq.Rows(0).Item("Name").ToString.Replace("ـ", "")
                crewSearch.TextBox1.Text = dq.Rows(0).Item("ID")
                crewSearch.TextBox3.Text = dq.Rows(0).Item("Phone")
                crewSearch.TextBox3.Select()
                crewSearch.TextBox2.Text = yy.Replace("*", "")
                crewSearch.TextBox4.Text = dq.Rows(0).Item("HomeAddress")
                crewSearch.Show()
            End If

        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
    End Sub

    ' handle area selection change in driver assignment tab
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            kg = 3
            Dim SQL1 As String
            Dim SQL2 As String
            If ComboBox1.SelectedIndex = 3 Then
                D3.Rows.Clear()
                SQL1 = "select * from bus  "
            ElseIf ComboBox1.SelectedIndex = 1 Then
                D3.Rows.Clear()
                SQL1 = "select * from bus where areaa=2 "
            ElseIf ComboBox1.SelectedIndex = 2 Then
                D3.Rows.Clear()
                SQL1 = "select * from bus where areaa=3 "
            Else
                D3.Rows.Clear()
                SQL1 = "select * from bus where areaa = 1   "
            End If
            Dim dnn As New SqlDataAdapter(SQL1, cn)
            Dim dqq As New System.Data.DataTable
            dnn.Fill(dqq)
            Dim w As Integer = 0
            While w <= dqq.Rows.Count - 1
                D3.Rows.Add()
                D3.Item(0, w).Value = dqq.Rows(w).Item("Driver")
                Try
                    SQL2 = "select BUS from bus where drname = N'" & dqq.Rows(w).Item("Driver") & "'"
                    Dim dnn1 As New SqlDataAdapter(SQL2, cn)
                    Dim dqq1 As New System.Data.DataTable
                    dnn1.Fill(dqq1)
                    D3.Item(1, w).Value = dqq1.Rows(0).Item("Bus")
                Catch ex As Exception

                End Try
                w = w + 1
            End While
            kg = 1
        Catch ex As Exception
        End Try
    End Sub

    ' handle "All Areas" menu item click
    Private Sub AllAreasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllAreasToolStripMenuItem.Click
        Try
            If tt2.SelectedIndex = 1 Then
                area = 0

                D2.DataSource = Nothing
                Dim loadrText1 As String
                Dim rosterdata1 As New DataSet
                If ToolStripComboBox1.SelectedIndex = 0 Then
                    loadrText1 = "Select id,Name,Phone,addd From Gss "
                    Dim loadroster1 As New SqlDataAdapter(loadrText1, cn)
                    loadroster1.Fill(rosterdata1)
                ElseIf ToolStripComboBox1.SelectedIndex = 1 Then
                    loadrText1 = "select * from GSShift where (ShiftText= 'Morning' or ShiftText= 'Early Morning') and (SDate = N'" & ToolStripLabel2.Text & "')"
                    Dim loadroster1 As New SqlDataAdapter(loadrText1, cn)
                    loadroster1.Fill(rosterdata1)

                ElseIf ToolStripComboBox1.SelectedIndex = 2 Then
                    loadrText1 = "select * from GSShift where (ShiftText= 'Evening' or ShiftText= 'Early Evening') and (SDate = N'" & ToolStripLabel2.Text & "')"
                    Dim loadroster1 As New SqlDataAdapter(loadrText1, cn)
                    loadroster1.Fill(rosterdata1)

                ElseIf ToolStripComboBox1.SelectedIndex = 3 Then
                    loadrText1 = "select * from GSShift where (ShiftText= 'Night' or ShiftText= 'Early Night') and (SDate = N'" & ToolStripLabel2.Text & "')"
                    Dim loadroster1 As New SqlDataAdapter(loadrText1, cn)
                    loadroster1.Fill(rosterdata1)

                End If

                D2.DataSource = rosterdata1.Tables(0)

                If ToolStripComboBox1.SelectedIndex <> 0 Then
                    GSper(UserName)
                End If


                If userper = 1 And ToolStripComboBox1.SelectedIndex = 0 Then
                    D2.Columns(2).Visible = False
                ElseIf userper = 4 And ToolStripComboBox1.SelectedIndex = 0 Then
                    D2.Columns(2).Visible = False

                End If

            ElseIf tt2.SelectedIndex = 0 Then

                ToolStripButton6.PerformClick()
            ElseIf tt2.SelectedIndex = 4 Then

                ToolStripButton23.PerformClick()
            End If
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
    End Sub

    ' handle "Alone" checkbox change
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            ComboBox2.Enabled = False
        Else
            ComboBox2.Enabled = True
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer2.Start()
        Timer3.Stop()
    End Sub

    ' handle delete from roster
    Private Sub D1_CellValuePushed(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles D1.CellValuePushed
        If finds(D1.CurrentCell.Value, D1) Then
            D1.Rows.Remove(D1.Rows(rowind))
            Exit Sub
        End If
    End Sub

    ' handle switch to alone
    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click
        Dim cm1 As New SqlCommand
        Dim k As Integer = D1.CurrentRow.Index
        Dim Sqm As String
        Try
            Sqm = "update FullRoster set GPSNote=N'Switched' ,GPSOfficer = " & UserName & ",DMnote=N'Switched " & System.DateTime.Now.ToShortTimeString & "' where RID=" & D1(20, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D1(11, k).Value = "Switched"
            D1(15, k).Value = "Switched " & System.DateTime.Now.ToShortTimeString
            D1.CurrentRow.DefaultCellStyle.BackColor = Color.Violet
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        Panel2.Visible = False
    End Sub

    ' handle cancel on call
    Private Sub CANCELONCALLToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELONCALLToolStripMenuItem.Click
        If ToolStripComboBox1.SelectedIndex <> 0 Then
            Dim cm1 As New SqlCommand
            Dim k As Integer = D2.CurrentRow.Index
            Dim Sqm As String
            Sqm = "update GSShift set GPSNote='Cancel ON Call', GPSCaller = " & UserName & " where GSShID=" & D2(15, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D2.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow
            D2.CurrentRow.Cells(8).Value = "Cancel ON Call"
        End If
        Panel4.Hide()

    End Sub

    ' handle no show
    Private Sub NoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoToolStripMenuItem.Click
        If ToolStripComboBox1.SelectedIndex <> 0 Then
            Dim cm1 As New SqlCommand
            Dim k As Integer = D2.CurrentRow.Index
            Dim Sqm As String

            Sqm = "update GSShift set GPSNote='No Show', GPSCaller = " & UserName & " where GSShID=" & D2(15, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D2.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen
            D2.CurrentRow.Cells(8).Value = "No Show "
        End If
        Panel4.Hide()

    End Sub

    ' handle early shift insertion
    Private Sub EarlyToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EarlyToolStripMenuItem.Click
        Panel4.Visible = False
        Dim cm1 As New SqlCommand
        Dim k As Integer = D2.CurrentRow.Index
        Dim Sqm As String

        Sqm = "insert into GSShift values(" & D2(0, k).Value & ",N'" & D2(1, k).Value & "',N'" & D2(2, k).Value & "',N'" & D2(3, k).Value & "','Early Morning','','',0,'','',''," & D2(4, k).Value & "," & UserName & ",0,0)"
        cm1 = New SqlCommand(Sqm, cn)
        cm1.ExecuteNonQuery()
        MonthCalendar1.Visible = True
        MonthCalendar1.Focus()
    End Sub

    ' handle regular shift insertion
    Private Sub RegularToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegularToolStripMenuItem.Click
        Try
            Panel4.Visible = False
            Dim cm1 As New SqlCommand
            Dim k As Integer = D2.CurrentRow.Index
            Dim Sqm As String

            Sqm = "insert into GSShift values(" & D2(0, k).Value & ",N'" & D2(1, k).Value & "',N'" & D2(2, k).Value & "',N'" & D2(3, k).Value & "','Morning','','',0,'','',''," & D2(4, k).Value & "," & UserName & ",0,0)"
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            MonthCalendar1.Visible = True
            MonthCalendar1.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' handle evening shift insertion
    Private Sub EarlyToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EarlyToolStripMenuItem1.Click
        Panel4.Visible = False
        Dim cm1 As New SqlCommand
        Dim k As Integer = D2.CurrentRow.Index
        Dim Sqm As String
        Sqm = "insert into GSShift values(" & D2(0, k).Value & ",N'" & D2(1, k).Value & "',N'" & D2(2, k).Value & "',N'" & D2(3, k).Value & "','Early Evening','','',0,'','',''," & D2(4, k).Value & "," & UserName & ",0,0)"
        cm1 = New SqlCommand(Sqm, cn)
        cm1.ExecuteNonQuery()
        MonthCalendar1.Visible = True
        MonthCalendar1.Focus()
    End Sub

    ' handle evening shift insertion
    Private Sub RegularToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegularToolStripMenuItem1.Click
        Panel4.Visible = False
        Dim cm1 As New SqlCommand
        Dim k As Integer = D2.CurrentRow.Index
        Dim Sqm As String

        Sqm = "insert into GSShift values(" & D2(0, k).Value & ",N'" & D2(1, k).Value & "',N'" & D2(2, k).Value & "',N'" & D2(3, k).Value & "','Evening','','',0,'','',''," & D2(4, k).Value & "," & UserName & ",0,0)"
        cm1 = New SqlCommand(Sqm, cn)
        cm1.ExecuteNonQuery()

        MonthCalendar1.Visible = True
        MonthCalendar1.Focus()
    End Sub

    ' handle night shift insertion
    Private Sub EarlyToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EarlyToolStripMenuItem2.Click
        Panel4.Visible = False
        Dim cm1 As New SqlCommand
        Dim k As Integer = D2.CurrentRow.Index
        Dim Sqm As String

        Sqm = "insert into GSShift values(" & D2(0, k).Value & ",N'" & D2(1, k).Value & "',N'" & D2(2, k).Value & "',N'" & D2(3, k).Value & "','Early Night','','',0,'','',''," & D2(4, k).Value & "," & UserName & ",0,0)"
        cm1 = New SqlCommand(Sqm, cn)
        cm1.ExecuteNonQuery()

        MonthCalendar1.Visible = True
        MonthCalendar1.Focus()
    End Sub

    ' handle regular shift insertion
    Private Sub RegularToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegularToolStripMenuItem2.Click
        Panel4.Visible = False
        Dim cm1 As New SqlCommand
        Dim k As Integer = D2.CurrentRow.Index
        Dim Sqm As String

        Sqm = "insert into GSShift values(" & D2(0, k).Value & ",N'" & D2(1, k).Value & "',N'" & D2(2, k).Value & "',N'" & D2(3, k).Value & "','Night','','',0,'','',''," & D2(4, k).Value & "," & UserName & ",0,0)"
        cm1 = New SqlCommand(Sqm, cn)
        cm1.ExecuteNonQuery()

        MonthCalendar1.Visible = True
        MonthCalendar1.Focus()
    End Sub

    ' handle shift selection change
    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            Dim SQL1 As String
            If ToolStripComboBox1.SelectedIndex = 0 Then
                D2.Columns.Clear()
                SQL1 = "select * from Gss  "
                Dim dn As New SqlDataAdapter(SQL1, cn)
                Dim dq As New System.Data.DataTable
                dn.Fill(dq)
                D2.DataSource = dq
                D2.Columns(4).Visible = False
            ElseIf ToolStripComboBox1.SelectedIndex = 1 Then
                D2.Columns.Clear()
                SQL1 = "select * from GSShift where (ShiftText= 'Morning' or ShiftText= 'Early Morning') and ( SDate = N'" & ToolStripLabel2.Text & "' and GPSNote <> 'Delete')"
                Dim dn As New SqlDataAdapter(SQL1, cn)
                Dim dq As New System.Data.DataTable
                dn.Fill(dq)
                D2.DataSource = dq

                UPDATEToolStripMenuItem.PerformClick()

            ElseIf ToolStripComboBox1.SelectedIndex = 2 Then
                D2.Columns.Clear()
                SQL1 = "select * from GSShift where (ShiftText= 'Evening' or ShiftText= 'Early Evening') and ( SDate = N'" & ToolStripLabel2.Text & "' and GPSNote <> 'Delete')"

                Dim dn As New SqlDataAdapter(SQL1, cn)
                Dim dq As New System.Data.DataTable
                dn.Fill(dq)
                D2.DataSource = dq
                UPDATEToolStripMenuItem.PerformClick()
            Else
                D2.Columns.Clear()
                SQL1 = "select * from GSShift where (ShiftText= 'Night' or ShiftText= 'Early Night')and ( SDate = N'" & ToolStripLabel2.Text & "' and GPSNote <> 'Delete')"
                Dim dn As New SqlDataAdapter(SQL1, cn)
                Dim dq As New System.Data.DataTable
                dn.Fill(dq)
                D2.DataSource = dq
                UPDATEToolStripMenuItem.PerformClick()
            End If
            D2.Columns(0).ReadOnly = True
            D2.Columns(1).ReadOnly = True
            D2.Columns(2).ReadOnly = True
            D2.Columns(3).ReadOnly = True
            D2.Columns(4).ReadOnly = True
            D2.Columns(5).ReadOnly = True
            D2.Columns(6).ReadOnly = True
            D2.Columns(10).ReadOnly = True
            If ToolStripComboBox1.SelectedIndex <> 0 Then
                GSper(UserName)
            End If

            If userper = 1 Then
                D2.Columns(2).Visible = False
                D2.Columns(4).Visible = False
            ElseIf userper = 4 Then
                D2.Columns(2).Visible = False
                D2.Columns(4).Visible = False
            End If

        Catch ex As Exception

        End Try

    End Sub

    ' handle cell value changes in gs shift tab
    Private Sub D2_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles D2.CellValueChanged


        Try
            Dim j As Integer = D2.CurrentCell.RowIndex
            If D2.CurrentCell.ColumnIndex = 8 Then
                Dim cmt4 As New SqlCommand
                Dim ST4 As String
                ST4 = "update GSShift set GPSNote=N'" & D2(8, j).Value & "'where GSShID=" & D2(15, D2.CurrentRow.Index).Value
                cmt4 = New SqlCommand(ST4, cn)
                cmt4.ExecuteNonQuery()

                Dim cm11 As New SqlCommand
                Dim k As Integer = D2.CurrentRow.Index
                Dim Sqm As String

                Sqm = "insert into gsmodby values(" & D2(0, j).Value & ",N'" & D2(1, j).Value & "'," & UserName & ",N'" & System.DateTime.Now & "',N'" & D2(8, j).Value & "')"
                cm11 = New SqlCommand(Sqm, cn)
                cm11.ExecuteNonQuery()

            End If
            If D2.CurrentCell.ColumnIndex = 9 Then

                Dim cmt As New SqlCommand
                Dim STt3 As String
                Dim ST3 As String

                If D2(9, j).Value.ToString = "" Then
                    D2(10, j).Value = ""
                End If
                If D2(9, j).Value.ToString <> "" Then
                    If D2(9, j).Value.ToString.Length = 3 Then
                        'MessageBox.Show(D2(9, j).Value.ToString.Length)
                        STt3 = "select drname,Bus from bus where Buss = " & D2(9, j).Value
                        Dim dkw As New SqlDataAdapter(STt3, cn)
                        Dim dmw As New System.Data.DataTable
                        dkw.Fill(dmw)
                        D2(10, j).Value = dmw.Rows(0).Item("drname")
                        D2(9, j).Value = dmw.Rows(0).Item("Bus")
                    End If
                End If
                ST3 = "update GSShift set Buss=N'" & D2(9, j).Value & "',Driver=N'" & D2(10, j).Value & "',TransOfficer = " & UserName & "where GSShID=" & D2(15, D2.CurrentRow.Index).Value
                cmt = New SqlCommand(ST3, cn)
                cmt.ExecuteNonQuery()

                Exit Sub

            End If
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try

    End Sub

    ' handle date selection in gs shift tab
    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim sqll As New SqlCommand
        sqll.CommandText = "update GSShift set SDate = N'" & MonthCalendar1.SelectionRange.Start & "' where GSID =" & D2.CurrentRow.Cells(0).Value & "and Senc = 0"
        sqll.Connection = cn
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        sqll.ExecuteNonQuery()

        Dim checkSh As New SqlCommand
        checkSh.Connection = cn
        checkSh.CommandText = "select GSName from GSShift where Senc = 0"
        Dim getshift As New SqlCommand
        getshift.Connection = cn
        getshift.CommandText = "select GSShID From GSShift where SDate = N'" & MonthCalendar1.SelectionRange.Start & "' and  (GSName = N'" & checkSh.ExecuteScalar & "' and GPSNote <> 'Delete' and Senc = 1) "
        Try
            Dim deleteshift As New SqlCommand
            deleteshift.Connection = cn
            deleteshift.CommandText = "Update GSShift set GPSNote ='Delete', GPSCaller = " & UserName & ",GPSCallTime=N'" & System.DateTime.Now & "' Where GSShID = " & getshift.ExecuteScalar
            deleteshift.ExecuteNonQuery()
        Catch ex As Exception
            Dim upsenc1 As New SqlCommand
            upsenc1.CommandText = "update GSShift set Senc = 1"
            upsenc1.Connection = cn
            upsenc1.ExecuteNonQuery()
            MonthCalendar1.Visible = False
            MonthCalendar1.Update()
        End Try
        Dim upsenc As New SqlCommand
        upsenc.CommandText = "update GSShift set Senc = 1"
        upsenc.Connection = cn
        upsenc.ExecuteNonQuery()
        MonthCalendar1.Visible = False
        MonthCalendar1.Update()
    End Sub

    ' handle previous day dm shift tab
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        dateday22 = ToolStripLabel1.Text
        If dateday22 = System.DateTime.Now.Date.AddMinutes(-1440).ToShortDateString Then
        Else
            ToolStripLabel1.Text = Convert.ToDateTime(dateday22).AddMinutes(-1440).ToShortDateString
            dateday22 = ToolStripLabel1.Text
        End If
        ToolStripButton6.PerformClick()
    End Sub

    ' handle next day dm shift tab
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        dateday22 = ToolStripLabel1.Text
        If dateday22 = System.DateTime.Now.Date.AddMinutes(+1440).ToShortDateString Then
        Else
            ToolStripLabel1.Text = Convert.ToDateTime(dateday22).AddMinutes(+1440).ToShortDateString
            dateday22 = ToolStripLabel1.Text
        End If
        ToolStripButton6.PerformClick()
    End Sub

    ' handle next day gs shift tab
    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        dateday22 = ToolStripLabel2.Text
        If dateday22 = System.DateTime.Now.Date.AddMinutes(+1440).ToShortDateString Then
        Else
            ToolStripLabel2.Text = Convert.ToDateTime(dateday22).AddMinutes(+1440).ToShortDateString
            dateday22 = ToolStripLabel2.Text
        End If
    End Sub

    ' handle previous day gs shift tab
    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        dateday22 = ToolStripLabel2.Text
        If dateday22 = System.DateTime.Now.Date.AddMinutes(-1440).ToShortDateString Then
        Else
            ToolStripLabel2.Text = Convert.ToDateTime(dateday22).AddMinutes(-1440).ToShortDateString
            dateday22 = ToolStripLabel2.Text
        End If
    End Sub

    ' handle alone status
    Private Sub AloneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AloneToolStripMenuItem.Click
        If ToolStripComboBox1.SelectedIndex <> 0 Then

            Dim cm1 As New SqlCommand
            Dim k As Integer = D2.CurrentRow.Index
            Dim Sqm As String
            Sqm = "update GSShift set GPSNote='Alone', GPSCaller = " & UserName & ",GPSCallTime=N'" & System.DateTime.Now & "' where GSShID=" & D2(15, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()
            D2.CurrentRow.DefaultCellStyle.BackColor = Color.Tan
            D2.CurrentRow.Cells(8).Value = "Alone"

        End If
        Panel4.Hide()
    End Sub

    ' handle enter key in gs shift
    Private Sub D2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles D2.KeyDown
        If e.KeyCode = Keys.Enter Then
            callnum()
        End If
        If rosterSearch.Visible = True Then
            If e.KeyData = Keys.Space Or e.KeyData = Keys.Right Then
                rosterSearch.Button3.PerformClick()
            End If
        End If

        If e.KeyData = Keys.Control + Keys.F Then
            rosterSearch.Show()
        End If
    End Sub

    ' handle delete shift
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Panel4.Visible = False
        Dim cm1 As New SqlCommand
        Dim k As Integer = D2.CurrentRow.Index
        Dim Sqm As String
        Dim cmt4 As New SqlCommand
        Dim ST4 As String
        ST4 = "update GSShift set GPSNote=N'Delete', GPSCaller = " & UserName & ",GPSCallTime=N'" & System.DateTime.Now & "' where GSShID=" & D2(15, D2.CurrentRow.Index).Value
        cmt4 = New SqlCommand(ST4, cn)
        cmt4.ExecuteNonQuery()
        D2(8, k).Value = "Delete"
    End Sub

    ' open add flight panel
    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click
        rosterAddFlight.Show()
        Panel2.Hide()
    End Sub

    ' refresh webviews
    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click
        Try
            WebView22.CoreWebView2.Reload()
            WebView23.CoreWebView2.Reload()
        Catch ex As Exception
        End Try
    End Sub

    ' open arrival excel file
    Private Sub ToolStripButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton19.Click
        DataGridView6.DataSource = Nothing
        DataGridView6.Refresh()
        Dim apppath As String
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Select Roster"
        fd.InitialDirectory = "\Desktop"
        fd.Filter = "All files (*.xlsx)|*.xlsx|All files (*.xlsx)|*.xlsx"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            Label11.Text = 1
            If DataGridView6.Columns.Count <> 0 Then
                Panel6.Visible = True
            End If
            apppath = fd.FileName

            OPenarr(DataGridView6, apppath)
            Panel6.Visible = False
            Me.WindowState = FormWindowState.Maximized
            kg1 = 1
        End If
    End Sub

    ' handle next day arrival
    Private Sub ToolStripButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton22.Click
        dateday22 = ToolStripLabel6.Text
        If dateday22 = System.DateTime.Now.Date.AddMinutes(+1440).ToShortDateString Then

        Else
            ToolStripLabel6.Text = Convert.ToDateTime(dateday22).AddMinutes(+1440).ToShortDateString
            dateday22 = ToolStripLabel6.Text
        End If
        ToolStripButton23.PerformClick()
    End Sub

    ' handle previous day arrival tab
    Private Sub ToolStripButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton21.Click
        dateday22 = ToolStripLabel6.Text
        If dateday22 = System.DateTime.Now.Date.AddMinutes(-1440).ToShortDateString Then

        Else
            ToolStripLabel6.Text = Convert.ToDateTime(dateday22).AddMinutes(-1440).ToShortDateString
            dateday22 = ToolStripLabel6.Text
        End If
        ToolStripButton23.PerformClick()
    End Sub

    ' handle arrival tab
    Private Sub ToolStripButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton23.Click
        Dim arrival As New Data.DataTable
        DataGridView6.DataSource = Nothing
        DataGridView6.Columns.Clear()
        Dim str As String
        str = "select * from Arrival where ADate = N'" & ToolStripLabel6.Text & "' order by ArrTime ,RNum"
        Dim updateArr As New SqlDataAdapter(str, cn)
        arrival.Clear()

        updateArr.Fill(arrival)
        DataGridView6.DataSource = arrival

        DataGridView6.Columns(6).DefaultCellStyle.ForeColor = Color.Red

        Dim i As Integer = 0

        While i <= arrival.Rows.Count - 2
            Try
                If arrival.Rows(0).Item("Area") = 3 Then
                    DataGridView6.Rows(i).DefaultCellStyle.BackColor = Color.Tan
                    DataGridView6(11, i).Value = "Alone"

                    Dim cm1 As New SqlCommand
                    Dim Sqm As String
                    Sqm = "update Arrivel set Note=N'" & DataGridView6(10, i).Value & "'  where ArrID=" & DataGridView6(0, i).Value
                    cm1 = New SqlCommand(Sqm, cn)
                    cm1.ExecuteNonQuery()
                End If

                If office = 1 And DataGridView6(12, i).Value = 2 Then
                    DataGridView6(9, i).ReadOnly = True
                ElseIf office = 2 And DataGridView6(12, i).Value = 1 Then
                    DataGridView6(9, i).ReadOnly = True
                End If
                If DataGridView6(13, i).Value = 0 Then
                    DataGridView6(1, i).Value = ""
                    DataGridView6(2, i).Value = ""
                    DataGridView6(3, i).Value = ""

                Else
                    DataGridView6.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                    DataGridView6.Rows(i).Cells(1).ReadOnly = False
                    DataGridView6.Rows(i).Cells(0).ReadOnly = False
                End If
                If DataGridView6(12, i).Value = 1 Then
                    DataGridView6(8, i).ReadOnly = True
                End If

                If DataGridView6(11, i).Value.ToString.Contains("Delete") Then
                    DataGridView6.Rows(i).DefaultCellStyle.BackColor = Color.DarkOrange
                ElseIf DataGridView6(11, i).Value.ToString.Contains("NO SHOW") Then
                    DataGridView6.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                ElseIf DataGridView6(11, i).Value.ToString.Contains("CANCEL ON CALL") Then
                    DataGridView6.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
                ElseIf DataGridView6(11, i).Value.ToString.Contains("Alone") Then
                    DataGridView6.Rows(i).DefaultCellStyle.BackColor = Color.Tan
                ElseIf DataGridView6(11, i).Value.ToString.Contains("New Inserted") Then
                    DataGridView6.Rows(i).DefaultCellStyle.BackColor = Color.Pink
                ElseIf DataGridView6(11, i).Value.ToString.Contains("Switched") Then
                    DataGridView6.Rows(i).DefaultCellStyle.BackColor = Color.Violet

                End If
                If DataGridView6(8, i).Value.ToString <> "" Then
                    DataGridView6.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
                End If
                If DataGridView6(9, i).Value.ToString <> "" Then
                    DataGridView6.Rows(i).DefaultCellStyle.BackColor = Color.LightBlue
                End If

            Catch ex As Exception
                ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
            End Try
            i = i + 1
        End While


        ArrTabPermissions(UserName)

        Panel1.Visible = False

        Label15.Visible = False

        Me.WindowState = FormWindowState.Maximized
        Panel1.Visible = False

        kg = 1

        DataGridView6.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(10).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(11).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(12).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(13).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(14).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(15).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView6.Columns(16).SortMode = DataGridViewColumnSortMode.NotSortable
        kg1 = 1

    End Sub

    ' handling right click on datagridview6
    Private Sub DataGridView6_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView6.CellMouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            DataGridView6.Rows(e.RowIndex).Selected = True
            DataGridView6.CurrentCell = DataGridView6.Rows(e.RowIndex).Cells(1)
        End If

    End Sub

    ' handling cell value change in datagridview6
    Private Sub DataGridView6_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellValueChanged
        If kg1 = 1 Then

            Dim k As String = DataGridView6.CurrentCell.Value.ToString
            Dim j As Integer = DataGridView6.CurrentCell.RowIndex
            If DataGridView6.CurrentCell.ColumnIndex = 8 Then

                Dim cmt As New SqlCommand

                Dim ST3 As String

                Try
                    ST3 = "update Arrival set ShatelBus=N'" & DataGridView6(8, j).Value.ToString & "',TransOfficer1 = " & UserName & " where ArrID=" & DataGridView6(0, j).Value
                    cmt = New SqlCommand(ST3, cn)
                    cmt.ExecuteNonQuery()
                    DataGridView6.CurrentRow.DefaultCellStyle.BackColor = Color.LightSkyBlue
                    Exit Sub
                Catch ex As Exception

                    MessageBox.Show(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")

                End Try
            End If

            If DataGridView6.CurrentCell.ColumnIndex = 9 Then
                Dim cmt As New SqlCommand
                Dim STt As String
                Dim ST3 As String

                Try
                    If DataGridView6(9, j).Value.ToString = "" Then
                        DataGridView6(10, j).Value = ""
                    End If
                    If DataGridView6(9, j).Value.ToString <> "" Then
                        If DataGridView6(9, j).Value.ToString.Length = 3 Then

                            STt = "select drname,Bus from bus where Buss = '" & DataGridView6(9, j).Value & "'"
                            Dim dk As New SqlDataAdapter(STt, cn)
                            Dim dm As New System.Data.DataTable
                            dk.Fill(dm)
                            DataGridView6(10, j).Value = dm.Rows(0).Item("drname")
                            DataGridView6(9, j).Value = dm.Rows(0).Item("Bus")
                        End If
                    End If


                    ST3 = "update Arrival set Bus='" & DataGridView6(9, j).Value.ToString & "',Driver=N'" & DataGridView6(10, j).Value & "',TransOfficer1 = " & UserName & " where ArrID=" & DataGridView6(0, j).Value
                    cmt = New SqlCommand(ST3, cn)
                    cmt.ExecuteNonQuery()
                    DataGridView6.CurrentRow.DefaultCellStyle.BackColor = Color.LightBlue
                    Exit Sub
                Catch ex As Exception

                    MessageBox.Show(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")

                End Try
            End If

            If DataGridView6.CurrentCell.ColumnIndex = 11 Then
                If DataGridView6(11, j).Value.ToString = "" And DataGridView6(13, j).Value = 0 Then
                    DataGridView6.CurrentRow.DefaultCellStyle.BackColor = Color.White
                ElseIf DataGridView6(11, j).Value.ToString = "" And DataGridView6(13, j).Value = 1 Then
                    DataGridView6.CurrentRow.DefaultCellStyle.BackColor = Color.LightGray
                End If
                Dim cmt As New SqlCommand

                Dim ST3 As String
                Try
                    ST3 = "update Arrival set TransOfficerNote=N'" & DataGridView6(11, j).Value.ToString & "',TransOfficer1 = " & UserName & " where ArrID=" & DataGridView6(0, j).Value
                    cmt = New SqlCommand(ST3, cn)
                    cmt.ExecuteNonQuery()
                    Exit Sub
                Catch ex As Exception
                    MessageBox.Show(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
                End Try
            End If
        End If
    End Sub

    ' handling right click on datagridview6
    Private Sub DataGridView6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView6.MouseDown
        Try
            If userper = 3 Or (userper = 4 And office = 1) Then
                If DataGridView6.CurrentRow.Index > DataGridView6.RowCount - 10 Then
                    If MouseButtons = System.Windows.Forms.MouseButtons.Right Then
                        Panel3.Location = New System.Drawing.Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y - 270)
                        Panel3.Visible = True
                    Else
                        If MouseButtons = System.Windows.Forms.MouseButtons.Left Then
                            Panel3.Visible = False
                        End If
                    End If
                Else
                    If MouseButtons = System.Windows.Forms.MouseButtons.Right Then
                        Panel3.Location = New System.Drawing.Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y - 130)
                        Panel3.Visible = True
                    Else
                        If MouseButtons = System.Windows.Forms.MouseButtons.Left Then
                            Panel3.Visible = False
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label45.Click
        Panel3.Hide()
        insertNewArr.Show()
    End Sub

    ' handling switch button in datagridview6
    Private Sub Label44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label44.Click
        Dim cm1 As New SqlCommand
        Dim k As Integer = DataGridView6.CurrentRow.Index
        Dim Sqm As String
        Try
            Sqm = "update Arrival set TransOfficerNote=N'Delete',TransOfficer = " & UserName & " where ArrID=" & DataGridView6(0, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            DataGridView6(10, k).Value = "Delete"
            DataGridView6.Rows(k).DefaultCellStyle.BackColor = Color.DarkOrange
            DataGridView6.Rows(k).DefaultCellStyle.ForeColor = Color.Black
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")

        End Try
        Panel3.Visible = False

    End Sub

    ' handling switch button in datagridview6
    Private Sub Label43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label43.Click
        Dim cm1 As New SqlCommand
        Dim k As Integer = DataGridView6.CurrentRow.Index
        Dim Sqm As String
        Try
            Sqm = "update Arrival set TransOfficerNote=N'No Show',TransOfficer = " & UserName & " where ArrID=" & DataGridView6(0, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            DataGridView6(10, k).Value = "No Show"
            DataGridView6.Rows(k).DefaultCellStyle.BackColor = Color.LightGreen
            DataGridView6.Rows(k).DefaultCellStyle.ForeColor = Color.Black
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")

        End Try
        Panel3.Visible = False

    End Sub

    ' handling cancel on call
    Private Sub Label41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label41.Click
        Dim cm1 As New SqlCommand
        Dim k As Integer = DataGridView6.CurrentRow.Index
        Dim Sqm As String
        Try
            Sqm = "update Arrival set TransOfficerNote=N'Alone',TransOfficer = " & UserName & " where ArrID=" & DataGridView6(0, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            DataGridView6(10, k).Value = "Alone"
            DataGridView6.Rows(k).DefaultCellStyle.BackColor = Color.Tan
            DataGridView6.Rows(k).DefaultCellStyle.ForeColor = Color.Black
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")

        End Try
        Panel3.Visible = False
    End Sub

    ' handling switch button in arrival tab
    Private Sub Label40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label40.Click
        Dim cm1 As New SqlCommand
        Dim k As Integer = DataGridView6.CurrentRow.Index
        Dim Sqm As String
        Try
            Sqm = "update Arrival set TransOfficerNote=N'Switched',TransOfficer = " & UserName & " where ArrID=" & DataGridView6(0, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            DataGridView6(10, k).Value = "Switched"
            DataGridView6.Rows(k).DefaultCellStyle.BackColor = Color.Violet
            DataGridView6.Rows(k).DefaultCellStyle.ForeColor = Color.Black
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")

        End Try
        Panel3.Visible = False
    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click
        arrAddFlight.Show()
        Panel3.Hide()
    End Sub

    ' handling delete button in datagridview7
    Private Sub DataGridView7_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick
        Try
            If e.ColumnIndex = 7 Then
                DataGridView7.Rows.Remove(DataGridView7.CurrentRow)
            End If
        Catch ex As Exception

        End Try
    End Sub

    ' handling bus textbox
    Private Sub TextBox21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox21.TextChanged
        If TextBox21.Text = "" Then
            TextBox22.Text = ""
        End If

        If TextBox21.TextLength = 3 Then
            Try
                Dim cmt As New SqlCommand
                Dim STt As String
                Dim ST3 As String
                STt = "select drname,Bus from bus where Buss = '" & TextBox21.Text & "'"
                Dim dk As New SqlDataAdapter(STt, cn)
                Dim dm As New System.Data.DataTable
                dk.Fill(dm)
                TextBox22.Text = dm.Rows(0).Item("drname")
                TextBox21.Text = dm.Rows(0).Item("Bus")

            Catch ex As Exception

            End Try
        End If
    End Sub

    ' handling date textbox
    Private Sub TextBox29_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox29.Enter
        If TextBox29.TextLength <> 10 And TextBox29.Text <> "InsertDate" Then
            TextBox29.Text = System.DateTime.Now.Date.ToShortDateString
        End If
    End Sub

    ' handling date textbox
    Private Sub TextBox29_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox29.KeyDown
        If e.KeyCode = Keys.Down Then
            If Convert.ToDateTime(TextBox29.Text).ToShortDateString = System.DateTime.Now.Date.AddMinutes(+1440).ToShortDateString Then

            Else
                TextBox29.Text = Convert.ToDateTime(TextBox29.Text).AddMinutes(+1440).ToShortDateString
            End If
        End If
        If e.KeyCode = Keys.Up Then
            If Convert.ToDateTime(TextBox29.Text).ToShortDateString = System.DateTime.Now.Date.AddMinutes(-1440).ToShortDateString Then

            Else
                TextBox29.Text = Convert.ToDateTime(TextBox29.Text).AddMinutes(-1440).ToShortDateString
            End If
        End If
    End Sub

    ' handling date textbox
    Private Sub TextBox29_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox29.Leave
        If TextBox29.Text = "" Then
            TextBox29.Text = "Insert Date"
        End If
        If Not TextBox29.Text.Contains("/") Then
            TextBox29.Text = "Insert Date"
        End If
    End Sub

    ' handling date textbox
    Private Sub TextBox29_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox29.TextChanged
        If TextBox29.Text.Contains("/") And TextBox29.TextLength = 10 Then
            TextBox30.Text = Convert.ToDateTime(TextBox29.Text).DayOfWeek.ToString
            TextBox26.Text = userRname.ToString + " (" + UserName.ToString + ")"
            TextBox28.Text = System.DateTime.Now.Date.AddMinutes(+5).ToShortTimeString
            TextBox28.Text = Convert.ToDateTime(TextBox28.Text).ToLongTimeString
        ElseIf Not TextBox29.Text.Contains("/") And TextBox29.TextLength <> 10 Then
            TextBox30.Text = ""
            TextBox26.Text = ""
        ElseIf TextBox29.Text = "Insert Date" Then
            TextBox30.Text = ""
            TextBox26.Text = ""
        End If
    End Sub

    ' area comboboxes handling
    Private Sub TextBox31_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox31.TextChanged
        If TextBox31.Text <> "" And (TextBox31.Text.Contains(":") And TextBox31.TextLength = 5) Then
            If TextBox32.Text = "" And TextBox31.Text = "" Then
                ComboBox5.Items.Clear()
            ElseIf TextBox31.Text = "" Then
                arrdata.Clear()
            End If
            Try
                Dim getarr As String
                getarr = "select CID,CArName,ArrID,CAddress,Bus from Arrival where (ADate=N'" & TextBox29.Text & "' and Area = " & office & ") and (ShatelBus=N'" & TextBox31.Text & "' and Bus not like '%-%')"
                Dim arrdata As New Data.DataTable
                Dim arradab As New SqlDataAdapter(getarr, cn)
                arradab.Fill(arrdata)

                If arrdata.Rows.Count <> 0 Then
                    Dim z As Integer = 0
                    While z <= arrdata.Rows.Count - 1
                        If Not ComboBox5.Items.Contains(arrdata.Rows(z).Item(3)) Then
                            ComboBox5.Items.Add(arrdata.Rows(z).Item(3))
                        End If
                        z = z + 1
                    End While
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

    ' handling area comboboxes
    Private Sub ComboBox5_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedValueChanged
        Dim zz As Integer = 0
        ComboBox5.BackColor = Color.White
        If ComboBox5.SelectedItem <> area1 Then
            'Arrival Data in gridview

            While zz <= DataGridView7.RowCount - 1
                If ComboBox5.SelectedItem = DataGridView7.Rows(zz).Cells(2).Value Then
                    DataGridView7.Rows(zz).Cells(4).Value = "Delete becouse selecte another area from same combobox"
                    DataGridView7.Rows(zz).Visible = False
                End If
                zz = 1 + zz

            End While
            If TextBox31.Text <> "" Then
                zz = 0
                Dim fillgrid As String
                fillgrid = "select CID,CArName,ArrID,CAddress,Bus from Arrival where (ADate=N'" & TextBox29.Text & "' and Area = " & office & ") and (ShatelBus=N'" & TextBox31.Text & "' and Bus not like '%-%' and CAddress=N'" & ComboBox5.SelectedItem & "')"
                Dim adarea As New SqlDataAdapter(fillgrid, cn)
                Dim data1 As New Data.DataTable
                adarea.Fill(data1)

                While zz <= data1.Rows.Count - 1
                    If data1.Rows(zz).Item("CAddress") = ComboBox5.SelectedItem And data1.Rows(zz).Item("Bus") = "" Then
                        DataGridView7.Rows.Add(data1.Rows(zz).Item("CID"), data1.Rows(zz).Item("CArName"), data1.Rows(zz).Item("CAddress"), "To His Home", data1.Rows(zz).Item("ArrID"), 0)
                    End If
                    zz = zz + 1
                End While
            End If
            'End Arrival Data in gridview

            'Dep. Data in gridview

            Dim deporder As String
            If TextBox32.Text.Contains(",") Then
                If TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 15 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 19 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "%'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(30, 5) & "') and ( Bus not like '%-%' and Area= " & office & ")"
                End If
            Else
                deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and PickupTime = N'" & TextBox32.Text & "' and (Bus not like '%-%' and Area= " & office & ")"
            End If

            Dim deporadap As New SqlDataAdapter(deporder, cn)
            Dim depdata As New Data.DataTable
            deporadap.Fill(depdata)
            zz = 0
            While zz <= depdata.Rows.Count - 1
                If depdata.Rows(zz).Item("CAdd") = ComboBox5.SelectedItem And depdata.Rows(zz).Item("Bus") = "" Then
                    DataGridView7.Rows.Add(depdata.Rows(zz).Item("CID"), depdata.Rows(zz).Item("CArName"), depdata.Rows(zz).Item("CAdd"), "To Airport", 0, depdata.Rows(zz).Item("RID"), depdata.Rows(zz).Item("PickupTime"))
                End If
                zz = zz + 1
            End While
            'End Dep. Data in gridview

            zz = 0
            While zz <= ComboBox5.Items.Count - 1
                If Not ComboBox5.Items(zz) = ComboBox5.SelectedItem Then
                    ComboBox6.Items.Add(ComboBox5.Items(zz))
                End If
                zz = zz + 1
            End While

            zz = 0
            Dim same As Integer = 0
            Dim co As Integer = 0
            While zz <= DataGridView7.RowCount - 1
                While same >= DataGridView7.RowCount - 1
                    If DataGridView7.Rows(zz).Cells(0).Value = DataGridView7.Rows(same).Cells(0).Value Then
                        co = co + 1
                    End If
                    If co < 1 Then
                        DataGridView7.Rows(zz).Visible = False
                        DataGridView7.Rows(zz).Cells(4).Value = "Deleted befor Print"
                    End If
                    same = same + 1
                End While

                zz = zz + 1
                co = 0
            End While
            DataGridView7.Focus()
            If ComboBox6.Items.Count > 0 Then
                ComboBox6.Visible = True
                Label56.Visible = True
                ComboBox5.Enabled = False
                LinkLabel3.Visible = True
                LinkLabel4.Visible = True
            End If
            area1 = ComboBox5.SelectedItem
        End If

    End Sub

    ' handling area comboboxes
    Private Sub ComboBox6_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedValueChanged
        ComboBox6.BackColor = Color.White
        If ComboBox6.SelectedItem <> area2 Then
            'Arrival Data in gridview
            Dim zz As Integer = 0
            While zz <= DataGridView7.RowCount - 1
                If ComboBox6.SelectedItem = DataGridView7.Rows(zz).Cells(2).Value Then
                    DataGridView7.Rows(zz).Cells(4).Value = "Delete becouse selecte another area from same combobox"
                    DataGridView7.Rows(zz).Visible = False
                End If
                zz = 1 + zz

            End While

            If TextBox31.Text <> "" Then


                zz = 0
                Dim fillgrid As String
                fillgrid = "select CID,CArName,ArrID,CAddress,Bus from Arrival where (ADate=N'" & TextBox29.Text & "' and Area = " & office & ") and (ShatelBus=N'" & TextBox31.Text & "' and Bus not like '%-%' and CAddress=N'" & ComboBox6.SelectedItem & "')"
                Dim adarea As New SqlDataAdapter(fillgrid, cn)
                Dim data1 As New Data.DataTable
                adarea.Fill(data1)

                While zz <= data1.Rows.Count - 1
                    If data1.Rows(zz).Item("CAddress") = ComboBox6.SelectedItem And data1.Rows(zz).Item("Bus") = "" Then
                        DataGridView7.Rows.Add(data1.Rows(zz).Item("CID"), data1.Rows(zz).Item("CArName"), data1.Rows(zz).Item("CAddress"), "To His Home", data1.Rows(zz).Item("ArrID"), 0)
                    End If
                    zz = zz + 1
                End While
            End If
            'End Arrival Data in gridview

            'Dep. Data in gridview

            Dim deporder As String
            If TextBox32.Text.Contains(",") Then
                If TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 15 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 19 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "%'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(30, 5) & "') and ( Bus not like '%-%' and Area= " & office & ")"
                End If
            Else
                deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and PickupTime = N'" & TextBox32.Text & "' and (Bus not like '%-%' and Area= " & office & ")"
            End If

            Dim deporadap As New SqlDataAdapter(deporder, cn)
            Dim depdata As New Data.DataTable
            deporadap.Fill(depdata)
            zz = 0
            While zz <= depdata.Rows.Count - 1
                If depdata.Rows(zz).Item("CAdd") = ComboBox6.SelectedItem And depdata.Rows(zz).Item("Bus") = "" Then
                    DataGridView7.Rows.Add(depdata.Rows(zz).Item("CID"), depdata.Rows(zz).Item("CArName"), depdata.Rows(zz).Item("CAdd"), "To Airport", 0, depdata.Rows(zz).Item("RID"), depdata.Rows(zz).Item("PickupTime"))
                End If
                zz = zz + 1
            End While
            'End Dep. Data in gridview
            zz = 0
            While zz <= ComboBox6.Items.Count - 1
                If Not ComboBox6.Items(zz) = ComboBox6.SelectedItem Then
                    ComboBox7.Items.Add(ComboBox6.Items(zz))
                End If
                zz = zz + 1
            End While

            zz = 0
            Dim same As Integer = 0
            Dim co As Integer = 0
            While zz <= DataGridView7.RowCount - 1
                While same >= DataGridView7.RowCount - 1
                    If DataGridView7.Rows(zz).Cells(0).Value = DataGridView7.Rows(same).Cells(0).Value Then
                        co = co + 1
                    End If
                    If co < 1 Then
                        DataGridView7.Rows(zz).Visible = False
                        DataGridView7.Rows(zz).Cells(4).Value = "Deleted befor Print"
                    End If
                    same = same + 1
                End While

                zz = zz + 1
                co = 0
            End While
            DataGridView7.Focus()
            If ComboBox7.Items.Count > 0 Then
                ComboBox7.Visible = True
                Label57.Visible = True
                ComboBox6.Enabled = False
                LinkLabel5.Visible = True
                LinkLabel6.Visible = True
            End If
            area2 = ComboBox6.SelectedItem
        End If

    End Sub

    ' End Dep. Data in gridview
    Private Sub ComboBox7_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedValueChanged
        ComboBox7.BackColor = Color.White
        If ComboBox7.SelectedItem <> area3 Then
            'Arrival Data in gridview
            Dim zz As Integer = 0
            While zz <= DataGridView7.RowCount - 1
                If ComboBox7.SelectedItem = DataGridView7.Rows(zz).Cells(2).Value Then
                    DataGridView7.Rows.Remove(DataGridView7.Rows(zz))
                End If
                zz = 1 + zz
            End While

            If TextBox31.Text <> "" Then
                zz = 0
                Dim fillgrid As String
                fillgrid = "select CID,CArName,ArrID,CAddress,Bus from Arrival where (ADate=N'" & TextBox29.Text & "' and Area = " & office & ") and (ShatelBus=N'" & TextBox31.Text & "' and Bus not like '%-%' and CAddress=N'" & ComboBox7.SelectedItem & "')"
                Dim adarea As New SqlDataAdapter(fillgrid, cn)
                Dim data1 As New Data.DataTable
                adarea.Fill(data1)

                While zz <= data1.Rows.Count - 1
                    If data1.Rows(zz).Item("CAddress") = ComboBox7.SelectedItem And data1.Rows(zz).Item("Bus") = "" Then
                        DataGridView7.Rows.Add(data1.Rows(zz).Item("CID"), data1.Rows(zz).Item("CArName"), data1.Rows(zz).Item("CAddress"), "To His Home", data1.Rows(zz).Item("ArrID"), 0)
                    End If
                    zz = zz + 1
                End While
            End If
            'End Arrival Data in gridview

            'Dep. Data in gridview

            Dim deporder As String
            If TextBox32.Text.Contains(",") Then
                If TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 15 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 19 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "%'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(30, 5) & "') and ( Bus not like '%-%' and Area= " & office & ")"
                End If
            Else
                deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and PickupTime = N'" & TextBox32.Text & "' and (Bus not like '%-%' and Area= " & office & ")"
            End If

            Dim deporadap As New SqlDataAdapter(deporder, cn)
            Dim depdata As New Data.DataTable
            deporadap.Fill(depdata)
            zz = 0
            While zz <= depdata.Rows.Count - 1
                If depdata.Rows(zz).Item("CAdd") = ComboBox7.SelectedItem And depdata.Rows(zz).Item("Bus") = "" Then
                    DataGridView7.Rows.Add(depdata.Rows(zz).Item("CID"), depdata.Rows(zz).Item("CArName"), depdata.Rows(zz).Item("CAdd"), "To Airport", 0, depdata.Rows(zz).Item("RID"), depdata.Rows(zz).Item("PickupTime"))
                End If
                zz = zz + 1
            End While
            'End Dep. Data in gridview
            zz = 0
            While zz <= ComboBox7.Items.Count - 1
                If Not ComboBox7.Items(zz) = ComboBox7.SelectedItem Then
                    ComboBox10.Items.Add(ComboBox7.Items(zz))
                End If
                zz = zz + 1
            End While

            zz = 0
            Dim same As Integer = 0
            Dim co As Integer = 0
            While zz <= DataGridView7.RowCount - 1
                While same >= DataGridView7.RowCount - 1
                    If DataGridView7.Rows(zz).Cells(0).Value = DataGridView7.Rows(same).Cells(0).Value Then
                        co = co + 1
                    End If
                    If co < 1 Then
                        DataGridView7.Rows(zz).Visible = False
                        DataGridView7.Rows(zz).Cells(4).Value = "Deleted befor Print"
                    End If
                    same = same + 1
                End While

                zz = zz + 1
                co = 0
            End While
            DataGridView7.Focus()
            If ComboBox10.Items.Count > 0 Then
                ComboBox10.Visible = True
                Label60.Visible = True
                ComboBox7.Enabled = False
                LinkLabel7.Visible = True
                LinkLabel8.Visible = True
            End If
            area3 = ComboBox7.SelectedItem
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ComboBox5.Enabled = True
    End Sub

    Private Sub TextBox32_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox32.LostFocus
        If TextBox32.Text = "" Or Not TextBox32.Text.Contains(":") Or TextBox32.TextLength <= 4 Then
            Label63.Visible = False
            TextBox33.Visible = False
        End If
    End Sub

    ' Load Areas in combobox5
    Private Sub TextBox32_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox32.TextChanged
        Try
            ComboBox5.Items.Clear()
            ComboBox5.Enabled = True

            Dim deporder As String
            If TextBox32.Text.Contains(",") Then
                If TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                    TextBox33.Visible = True
                    Label63.Visible = True
                ElseIf TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                    TextBox33.Visible = True
                    Label63.Visible = True
                ElseIf TextBox32.Text.Length = 15 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                    TextBox33.Visible = True
                    Label63.Visible = True
                ElseIf TextBox32.Text.Length = 19 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "%'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(30, 5) & "') and ( Bus not like '%-%' and Area= " & office & ")"
                    TextBox33.Visible = True
                    Label63.Visible = True
                End If
            Else
                deporder = "Select PickupTime,CID,CArname,CAdd,Area,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and PickupTime = N'" & TextBox32.Text & "' and (Bus not like '%-%' and Area= " & office & ")"
                TextBox33.Visible = True
                Label63.Visible = True
            End If
            Dim depada As New SqlDataAdapter(deporder, cn)
            Dim depdata As New Data.DataTable
            depada.Fill(depdata)

            If TextBox32.Text <> "" And (TextBox32.Text.Contains(":") And TextBox32.TextLength >= 5) Then
                If TextBox32.Text = "" And TextBox29.Text = "" Then
                    ComboBox5.Items.Clear()
                    Label63.Visible = False
                    TextBox33.Visible = False
                ElseIf TextBox32.Text = "" Then
                    depdata.Clear()
                    Label63.Visible = False
                    TextBox33.Visible = False
                End If

                If TextBox32.Text <> "" Then
                    Try
                        If depdata.Rows.Count <> 0 Then
                            Dim z As Integer = 0
                            While z <= depdata.Rows.Count - 1
                                If Not ComboBox5.Items.Contains(depdata.Rows(z).Item(3)) Then
                                    ComboBox5.Items.Add(depdata.Rows(z).Item(3))
                                End If
                                z = z + 1
                            End While
                        End If

                    Catch ex As Exception

                    End Try
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' Load GSS info
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If TextBox13.Text = "" Then
        Else
            Dim cm As New SqlCommand
            Dim dm As New System.Data.DataTable
            Dim ST As String
            Try

                If IsNumeric(TextBox13.Text) Then

                    ST = "select * from Gss where Id=" & TextBox13.Text
                    Dim dk As New SqlDataAdapter(ST, cn)

                    dk.Fill(dm)
                    TextBox12.Text = dm.Rows(0).Item("Name")
                    TextBox14.Text = dm.Rows(0).Item("Phone")
                    TextBox11.Text = dm.Rows(0).Item("addd")

                    Label28.Text = dm.Rows(0).Item("Id")

                Else

                    ST = "select * from Gss where Name LIKE N'" & TextBox13.Text & "'"
                    Dim dk As New SqlDataAdapter(ST, cn)

                    dk.Fill(dm)
                    TextBox12.Text = dm.Rows(0).Item("Name")
                    TextBox14.Text = dm.Rows(0).Item("Phone")
                    TextBox11.Text = dm.Rows(0).Item("addd")
                    Label28.Text = dm.Rows(0).Item("Id")
                End If
                If dm.Rows(0).Item("Area") = 1 Then
                    ComboBox11.Text = ComboBox2.Items(0)
                Else
                    ComboBox11.Text = ComboBox2.Items(1)
                End If
                Label19.Text = "* Please enter a value to be change and press Save"

            Catch ex As Exception
                ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")

            End Try

        End If
    End Sub

    ' Save GSS
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Dim cm As New SqlCommand
        Dim cm1 As New SqlCommand
        Dim ST As String
        Try
            Dim area As Integer
            If ComboBox11.SelectedIndex = 0 Then
                area = 1
            Else
                area = 2
            End If

            ST = "update Gss set Name=N'" & TextBox12.Text & "' , Phone='" & TextBox14.Text & "' , addd=N'" & TextBox11.Text & "' , Area=" & area & "  where Id=" & Label28.Text
            cm = New SqlCommand(ST, cn)
            TextBox11.Text = ""
            TextBox12.Text = ""
            TextBox14.Text = ""
            Label28.Text = ""
            Label19.Text = "Saved"
            cm.ExecuteNonQuery()
        Catch ex As Exception
            Label19.Text = "There was an error, please make sure the information entered correctly and try again"
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")

        End Try
    End Sub

    ' Delete GSS
    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Dim cm As New SqlCommand
        Dim cm1 As New SqlCommand
        Try
            Dim ST As String
            ST = "DELETE FROM Gss WHERE Id = " & Label28.Text
            cm = New SqlCommand(ST, cn)
            TextBox14.Text = ""
            TextBox12.Text = ""
            TextBox13.Text = ""
            TextBox11.Text = ""
            Label28.Text = ""
            Label26.Text = "Deleted"

            cm.ExecuteNonQuery()
        Catch ex As Exception
            Label32.Text = "There was an error, please make sure the information entered correctly and try again"
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")

        End Try
    End Sub

    ' handling area comboboxes
    Private Sub ComboBox10_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectedValueChanged
        ComboBox10.BackColor = Color.White
        If ComboBox10.SelectedItem <> area4 Then
            'Arrival Data in gridview
            Dim zz As Integer = 0
            While zz <= DataGridView7.RowCount - 1
                If ComboBox10.SelectedItem = DataGridView7.Rows(zz).Cells(2).Value Then
                    DataGridView7.Rows(zz).Cells(4).Value = "Delete becouse selecte another area from same combobox"
                    DataGridView7.Rows(zz).Visible = False
                End If
                zz = 1 + zz
            End While
            If TextBox31.Text <> "" Then

                zz = 0
                Dim fillgrid As String
                fillgrid = "select CID,CArName,ArrID,CAddress,Bus from Arrival where (ADate=N'" & TextBox29.Text & "' and Area = " & office & ") and (ShatelBus=N'" & TextBox31.Text & "' and Bus not like '%-%' and CAddress=N'" & ComboBox10.SelectedItem & "')"
                Dim adarea As New SqlDataAdapter(fillgrid, cn)
                Dim data1 As New Data.DataTable
                adarea.Fill(data1)

                While zz <= data1.Rows.Count - 1
                    If data1.Rows(zz).Item("CAddress") = ComboBox10.SelectedItem And data1.Rows(zz).Item("Bus") = "" Then
                        DataGridView7.Rows.Add(data1.Rows(zz).Item("CID"), data1.Rows(zz).Item("CArName"), data1.Rows(zz).Item("CAddress"), "To His Home", data1.Rows(zz).Item("ArrID"), 0)
                    End If
                    zz = zz + 1
                End While
            End If
            'End Arrival Data in gridview

            'Dep. Data in gridview

            Dim deporder As String
            If TextBox32.Text.Contains(",") Then
                If TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 15 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 19 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "%'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(30, 5) & "') and ( Bus not like '%-%' and Area= " & office & ")"
                End If
            Else
                deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and PickupTime = N'" & TextBox32.Text & "' and (Bus not like '%-%' and Area= " & office & ")"
            End If

            Dim deporadap As New SqlDataAdapter(deporder, cn)
            Dim depdata As New Data.DataTable
            deporadap.Fill(depdata)
            zz = 0
            While zz <= depdata.Rows.Count - 1
                If depdata.Rows(zz).Item("CAdd") = ComboBox10.SelectedItem And depdata.Rows(zz).Item("Bus") = "" Then
                    DataGridView7.Rows.Add(depdata.Rows(zz).Item("CID"), depdata.Rows(zz).Item("CArName"), depdata.Rows(zz).Item("CAdd"), "To Airport", 0, depdata.Rows(zz).Item("RID"), depdata.Rows(zz).Item("PickupTime"))
                End If
                zz = zz + 1
            End While
            'End Dep. Data in gridview
            zz = 0
            While zz <= ComboBox10.Items.Count - 1
                If Not ComboBox10.Items(zz) = ComboBox10.SelectedItem Then
                    ComboBox9.Items.Add(ComboBox10.Items(zz))
                End If
                zz = zz + 1
            End While

            zz = 0
            Dim same As Integer = 0
            Dim co As Integer = 0
            While zz <= DataGridView7.RowCount - 1
                While same >= DataGridView7.RowCount - 1
                    If DataGridView7.Rows(zz).Cells(0).Value = DataGridView7.Rows(same).Cells(0).Value Then
                        co = co + 1
                    End If
                    If co < 1 Then
                        DataGridView7.Rows(zz).Visible = False
                        DataGridView7.Rows(zz).Cells(4).Value = "Deleted befor Print"
                    End If
                    same = same + 1
                End While

                zz = zz + 1
                co = 0
            End While
            DataGridView7.Focus()
            If ComboBox9.Items.Count > 0 Then
                ComboBox9.Visible = True
                Label59.Visible = True
                ComboBox10.Enabled = False
                LinkLabel9.Visible = True
                LinkLabel10.Visible = True
            End If
            area4 = ComboBox10.SelectedItem
        End If
    End Sub

    ' handling area comboboxes
    Private Sub ComboBox9_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox9.SelectedValueChanged
        ComboBox9.BackColor = Color.White
        If ComboBox9.SelectedItem <> area5 Then
            'Arrival Data in gridview
            Dim zz As Integer = 0
            While zz <= DataGridView7.RowCount - 1
                If ComboBox9.SelectedItem = DataGridView7.Rows(zz).Cells(2).Value Then
                    DataGridView7.Rows(zz).Cells(4).Value = "Delete becouse selecte another area from same combobox"
                    DataGridView7.Rows(zz).Visible = False
                End If
                zz = 1 + zz
            End While

            If TextBox31.Text <> "" Then
                zz = 0
                Dim fillgrid As String
                fillgrid = "select CID,CArName,ArrID,CAddress,Bus from Arrival where (ADate=N'" & TextBox29.Text & "' and Area = " & office & ") and (ShatelBus=N'" & TextBox31.Text & "' and Bus not like '%-%' and CAddress=N'" & ComboBox9.SelectedItem & "')"
                Dim adarea As New SqlDataAdapter(fillgrid, cn)
                Dim data1 As New Data.DataTable
                adarea.Fill(data1)

                While zz <= data1.Rows.Count - 1
                    If data1.Rows(zz).Item("CAddress") = ComboBox9.SelectedItem And data1.Rows(zz).Item("Bus") = "" Then
                        DataGridView7.Rows.Add(data1.Rows(zz).Item("CID"), data1.Rows(zz).Item("CArName"), data1.Rows(zz).Item("CAddress"), "To His Home", data1.Rows(zz).Item("ArrID"), 0)
                    End If
                    zz = zz + 1
                End While
            End If
            'End Arrival Data in gridview

            'Dep. Data in gridview
            Dim deporder As String
            If TextBox32.Text.Contains(",") Then
                If TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 15 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 19 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "%'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(30, 5) & "') and ( Bus not like '%-%' and Area= " & office & ")"
                End If
            Else
                deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and PickupTime = N'" & TextBox32.Text & "' and (Bus not like '%-%' and Area= " & office & ")"
            End If

            Dim deporadap As New SqlDataAdapter(deporder, cn)
            Dim depdata As New Data.DataTable
            deporadap.Fill(depdata)
            zz = 0
            While zz <= depdata.Rows.Count - 1
                If depdata.Rows(zz).Item("CAdd") = ComboBox9.SelectedItem And depdata.Rows(zz).Item("Bus") = "" Then
                    DataGridView7.Rows.Add(depdata.Rows(zz).Item("CID"), depdata.Rows(zz).Item("CArName"), depdata.Rows(zz).Item("CAdd"), "To Airport", 0, depdata.Rows(zz).Item("RID"), depdata.Rows(zz).Item("PickupTime"))
                End If
                zz = zz + 1
            End While
            'End Dep. Data in gridview
            zz = 0
            While zz <= ComboBox9.Items.Count - 1
                If Not ComboBox9.Items(zz) = ComboBox9.SelectedItem Then
                    ComboBox8.Items.Add(ComboBox9.Items(zz))
                End If
                zz = zz + 1
            End While
            zz = 0
            Dim same As Integer = 0
            Dim co As Integer = 0
            While zz <= DataGridView7.RowCount - 1
                While same >= DataGridView7.RowCount - 1
                    If DataGridView7.Rows(zz).Cells(0).Value = DataGridView7.Rows(same).Cells(0).Value Then
                        co = co + 1
                    End If
                    If co < 1 Then
                        DataGridView7.Rows(zz).Visible = False
                        DataGridView7.Rows(zz).Cells(4).Value = "Deleted befor Print"
                    End If
                    same = same + 1
                End While
                zz = zz + 1
                co = 0
            End While
            DataGridView7.Focus()
            If ComboBox8.Items.Count > 0 Then
                ComboBox8.Visible = True
                Label58.Visible = True
                ComboBox9.Enabled = False
                LinkLabel12.Visible = True
                LinkLabel11.Visible = True
            End If
            area5 = ComboBox9.SelectedItem
        End If
    End Sub

    ' handle ComboBox8 SelectedValueChanged
    Private Sub ComboBox8_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedValueChanged
        ComboBox8.BackColor = Color.White
        If ComboBox8.SelectedItem <> area6 Then
            'Arrival Data in gridview
            Dim zz As Integer = 0
            While zz <= DataGridView7.RowCount - 1
                If ComboBox8.SelectedItem = DataGridView7.Rows(zz).Cells(2).Value Then
                    DataGridView7.Rows(zz).Cells(4).Value = "Delete becouse selecte another area from same combobox"
                    DataGridView7.Rows(zz).Visible = False
                End If
                zz = 1 + zz

            End While
            If TextBox31.Text <> "" Then


                zz = 0
                Dim fillgrid As String
                fillgrid = "select CID,CArName,ArrID,CAddress,Bus from Arrival where (ADate=N'" & TextBox29.Text & "' and Area = " & office & ") and (ShatelBus=N'" & TextBox31.Text & "' and Bus not like '%-%' and CAddress=N'" & ComboBox8.SelectedItem & "')"
                Dim adarea As New SqlDataAdapter(fillgrid, cn)
                Dim data1 As New Data.DataTable
                adarea.Fill(data1)
                While zz <= data1.Rows.Count - 1
                    If data1.Rows(zz).Item("CAddress") = ComboBox8.SelectedItem And data1.Rows(zz).Item("Bus") = "" Then
                        DataGridView7.Rows.Add(data1.Rows(zz).Item("CID"), data1.Rows(zz).Item("CArName"), data1.Rows(zz).Item("CAddress"), "To His Home", data1.Rows(zz).Item("ArrID"), 0)
                    End If
                    zz = zz + 1
                End While
            End If
            'End Arrival Data in gridview

            'Dep. Data in gridview

            Dim deporder As String
            If TextBox32.Text.Contains(",") Then
                If TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 11 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 15 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "') and (Bus not like '%-%' and Area= " & office & ")"
                ElseIf TextBox32.Text.Length = 19 Then
                    deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and  (PickupTime = N'" & TextBox32.Text.Substring(0, 5) & "' or PickupTime = N'" & TextBox32.Text.Substring(6, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(12, 5) & "%'or PickupTime = N'" & TextBox32.Text.Substring(18, 5) & "'or PickupTime =N'" & TextBox32.Text.Substring(30, 5) & "') and ( Bus not like '%-%' and Area= " & office & ")"
                End If
            Else
                deporder = "Select PickupTime,CID,CArname,CAdd,Area,Bus,RID From FullRoster where FDate = N'" & TextBox29.Text & "' and PickupTime = N'" & TextBox32.Text & "' and (Bus not like '%-%' and Area= " & office & ")"
            End If

            Dim deporadap As New SqlDataAdapter(deporder, cn)
            Dim depdata As New Data.DataTable
            deporadap.Fill(depdata)
            zz = 0
            While zz <= depdata.Rows.Count - 1
                If depdata.Rows(zz).Item("CAdd") = ComboBox8.SelectedItem And depdata.Rows(zz).Item("Bus") = "" Then
                    DataGridView7.Rows.Add(depdata.Rows(zz).Item("CID"), depdata.Rows(zz).Item("CArName"), depdata.Rows(zz).Item("CAdd"), "To Airport", 0, depdata.Rows(zz).Item("RID"), depdata.Rows(zz).Item("PickupTime"))
                End If
                zz = zz + 1
            End While
            'End Dep. Data in gridview
            zz = 0
            Dim same As Integer = 0
            Dim co As Integer = 0
            While zz <= DataGridView7.RowCount - 1
                While same >= DataGridView7.RowCount - 1
                    If DataGridView7.Rows(zz).Cells(0).Value = DataGridView7.Rows(same).Cells(0).Value Then
                        co = co + 1
                    End If
                    If co < 1 Then
                        DataGridView7.Rows(zz).Visible = False
                        DataGridView7.Rows(zz).Cells(4).Value = "Deleted befor Print"
                    End If
                    same = same + 1
                End While
                zz = zz + 1
                co = 0
            End While
            ComboBox8.Enabled = False
            area6 = ComboBox8.SelectedItem
        End If
    End Sub
    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        ComboBox6.Enabled = True
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        ComboBox7.Enabled = True
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        ComboBox10.Enabled = True
    End Sub

    Private Sub LinkBottomLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        ComboBox9.Enabled = True
    End Sub

    Private Sub LinkLabel11_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        ComboBox8.Enabled = True
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim aa As Integer = 0
        Dim co As Integer = DataGridView7.RowCount - 1
        While aa <= co
            If DataGridView7.Rows(aa).Cells(2).Value = ComboBox5.SelectedItem Then
                DataGridView7.Rows.Remove(DataGridView7.Rows(aa))
                co = co - 1
                aa = aa - 1
            End If
            aa = aa + 1
        End While

    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim aa As Integer = 0
        Dim co As Integer = DataGridView7.RowCount - 1
        While aa <= co
            If DataGridView7.Rows(aa).Cells(2).Value = ComboBox6.SelectedItem Then
                DataGridView7.Rows.Remove(DataGridView7.Rows(aa))
                co = co - 1
                aa = aa - 1
            End If
            aa = aa + 1
        End While
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Dim aa As Integer = 0
        Dim co As Integer = DataGridView7.RowCount - 1
        While aa <= co
            If DataGridView7.Rows(aa).Cells(2).Value = ComboBox7.SelectedItem Then
                DataGridView7.Rows.Remove(DataGridView7.Rows(aa))
                co = co - 1
                aa = aa - 1
            End If
            aa = aa + 1
        End While
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Dim aa As Integer = 0
        Dim co As Integer = DataGridView7.RowCount - 1
        While aa <= co
            If DataGridView7.Rows(aa).Cells(2).Value = ComboBox10.SelectedItem Then
                DataGridView7.Rows.Remove(DataGridView7.Rows(aa))
                co = co - 1
                aa = aa - 1
            End If
            aa = aa + 1
        End While
    End Sub

    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        Dim aa As Integer = 0
        Dim co As Integer = DataGridView7.RowCount - 1
        While aa <= co
            If DataGridView7.Rows(aa).Cells(2).Value = ComboBox9.SelectedItem Then
                DataGridView7.Rows.Remove(DataGridView7.Rows(aa))
                co = co - 1
                aa = aa - 1
            End If
            aa = aa + 1
        End While
    End Sub

    Private Sub LinkLabel12_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        Dim aa As Integer = 0
        Dim co As Integer = DataGridView7.RowCount - 1
        While aa <= co
            If DataGridView7.Rows(aa).Cells(2).Value = ComboBox8.SelectedItem Then
                DataGridView7.Rows.Remove(DataGridView7.Rows(aa))
                co = co - 1
                aa = aa - 1
            End If
            aa = aa + 1
        End While
    End Sub

    ' CellValue Code
    Private Sub DataGridView8_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView8.CellValueChanged
        If kg3 = 1 Then ' if 1
            Dim closeTime As String
            closeTime = System.DateTime.Now.ToShortTimeString
            If DataGridView8.CurrentRow.Cells(4).Value.ToString.Contains(":") Then 'If 4
                closeTime = DataGridView8.CurrentRow.Cells(4).Value
            End If ' end if 4

            Dim updatestatus As New SqlCommand
            updatestatus.Connection = cn
            Dim colname As String = DataGridView8.Columns(e.ColumnIndex).Name
            If colname = "Column23" Then 'if 2
                If DataGridView8.CurrentRow.Cells(8).Value = "Close" Then 'if 3
                    If DataGridView8.CurrentRow.Cells(6).Value = 0 Then
                        updatestatus.CommandText = "update Orders set  OrderStatus=6, EndTime=N'" & closeTime & "' where OrderID = " & DataGridView8.CurrentRow.Cells(0).Value
                    Else
                        updatestatus.CommandText = "update Orders set  OrderStatus=2, EndTime=N'" & closeTime & "', EndKM = " & DataGridView8.CurrentRow.Cells(6).Value & " where OrderID = " & DataGridView8.CurrentRow.Cells(0).Value
                    End If
                    updatestatus.ExecuteNonQuery()
                    DataGridView8.CurrentRow.Cells(0).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(1).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(2).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(3).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(4).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(5).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(6).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(7).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(8).ReadOnly = True

                ElseIf DataGridView8.CurrentRow.Cells(8).Value = "Delete" Then 'if 3
                    DataGridView8.CurrentRow.Cells(0).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(1).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(2).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(3).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(4).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(5).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(6).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(7).ReadOnly = True
                    DataGridView8.CurrentRow.Cells(8).ReadOnly = True
                    updatestatus.CommandText = "update Orders set  OrderStatus=3, EndTime=N'Deleted at:" & System.DateTime.Now.ToShortTimeString & "' where OrderID = " & DataGridView8.CurrentRow.Cells(0).Value
                    updatestatus.ExecuteNonQuery()

                ElseIf DataGridView8.CurrentRow.Cells(8).Value = "In Process" Then 'if 3
                    updatestatus.CommandText = "update Orders set  OrderStatus=1, StartTime=N'" & System.DateTime.Now.ToShortTimeString & "',Bus=N'" & DataGridView8.CurrentRow.Cells(1).Value & "',DriverName =N'" & DataGridView8.CurrentRow.Cells(2).Value & "',StartKM =" & DataGridView8.CurrentRow.Cells(5).Value & ",DepShatelBus = N'" & DataGridView8.CurrentRow.Cells(7).Value & "' where OrderID = " & DataGridView8.CurrentRow.Cells(0).Value
                    updatestatus.ExecuteNonQuery()
                End If
            End If


            If DataGridView8.CurrentCell.ColumnIndex = 1 Then
                If DataGridView8.CurrentRow.Cells(1).Value.ToString.Length = 3 Then
                    Try
                        Dim cmt As New SqlCommand
                        Dim STt As String

                        STt = "select drname,Bus from bus where Buss = '" & DataGridView8.CurrentRow.Cells(1).Value & "'"
                        Dim dk As New SqlDataAdapter(STt, cn)
                        Dim dm As New System.Data.DataTable
                        dk.Fill(dm)
                        DataGridView8.CurrentRow.Cells(2).Value = dm.Rows(0).Item("drname")
                        DataGridView8.CurrentRow.Cells(1).Value = dm.Rows(0).Item("Bus")

                    Catch ex As Exception

                    End Try
                End If
            End If
            If DataGridView8.CurrentCell.ColumnIndex = 6 Then
                If DataGridView8.CurrentRow.Cells(8).Value = "Close Without End KM" Then
                    Dim updateKm As New SqlCommand
                    updateKm.Connection = cn
                    If cn.State = ConnectionState.Closed Then
                        cn.Open()
                    End If
                    MessageBox.Show("ana hon")
                    updateKm.CommandText = "Update Orders set EndKM = " & DataGridView8.CurrentRow.Cells(6).Value & ",OrderStatus = 2 where OrderID=" & DataGridView8.CurrentRow.Cells(0).Value
                    updateKm.ExecuteNonQuery()
                    DataGridView8.CurrentRow.Cells(8).Value = "Close"
                    DataGridView8.CurrentRow.ReadOnly = True
                End If
            End If

        End If
    End Sub

    ' show order details on double click
    Private Sub DataGridView8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView8.DoubleClick
        D9.Rows.Clear()
        TextBox36.Text = DataGridView8.CurrentRow.Cells(0).Value
        TextBox41.Text = DataGridView8.CurrentRow.Cells(2).Value
        TextBox42.Text = DataGridView8.CurrentRow.Cells(1).Value
        TextBox40.Text = DataGridView8.CurrentRow.Cells(5).Value
        TextBox38.Text = DataGridView8.CurrentRow.Cells(3).Value

        TextBox37.Text = TextBox26.Text
        GroupBox14.Visible = True
        Dim ortext As String
        Dim ord As New Data.DataTable
        ortext = "select * from CInOrder where OrderID = " & DataGridView8.CurrentRow.Cells(0).Value
        Dim orada As New SqlDataAdapter(ortext, cn)
        Dim cr As New Data.DataTable
        orada.Fill(cr)

        Dim c As Integer = 0
        While c <= cr.Rows.Count - 1
            D9.Rows.Add(cr.Rows(c).Item("COrderID"), cr.Rows(c).Item("OrderID"), cr.Rows(c).Item("ArName"), cr.Rows(c).Item("HomeAddress"), cr.Rows(c).Item("Destination"), cr.Rows(c).Item("PickupTime"))
            c = c + 1
        End While

        Dim tex As String
        tex = "Select ODate from Orders Where OrderID=" & DataGridView8.CurrentRow.Cells(0).Value
        Dim fd As New SqlDataAdapter(tex, cn)
        Dim tt As New Data.DataTable
        fd.Fill(tt)
        TextBox35.Text = tt.Rows(0).Item("ODate").ToString
        TextBox34.Text = Convert.ToDateTime(tt.Rows(0).Item("ODate").ToString).DayOfWeek.ToString
    End Sub

    ' show order details
    Private Sub Label25_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label25.MouseHover
        Label25.Font = New System.Drawing.Font(Label25.Font, FontStyle.Underline)
    End Sub

    ' remove order details
    Private Sub Label25_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label25.MouseLeave
        Label25.Font = New System.Drawing.Font(Label25.Font, FontStyle.Regular)
    End Sub

    ' show order details
    Private Sub Label23_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label23.MouseHover
        Label23.Font = New System.Drawing.Font(Label23.Font, FontStyle.Underline)
    End Sub

    ' remove order details
    Private Sub Label23_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label23.MouseLeave
        Label23.Font = New System.Drawing.Font(Label23.Font, FontStyle.Regular)
    End Sub

    ' show order details on click
    Private Sub DataGridView8_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView8.CellContentClick
        If DataGridView8.CurrentCell.ColumnIndex = 9 Then
            D9.Rows.Clear()
            TextBox36.Text = DataGridView8.CurrentRow.Cells(0).Value
            TextBox41.Text = DataGridView8.CurrentRow.Cells(2).Value
            TextBox42.Text = DataGridView8.CurrentRow.Cells(1).Value
            TextBox40.Text = DataGridView8.CurrentRow.Cells(5).Value
            TextBox38.Text = DataGridView8.CurrentRow.Cells(3).Value

            TextBox37.Text = TextBox26.Text
            GroupBox14.Visible = True
            Dim ortext As String
            Dim ord As New Data.DataTable
            ortext = "select * from CInOrder where OrderID = " & DataGridView8.CurrentRow.Cells(0).Value
            Dim orada As New SqlDataAdapter(ortext, cn)
            Dim cr As New Data.DataTable
            orada.Fill(cr)

            Dim c As Integer = 0
            While c <= cr.Rows.Count - 1
                D9.Rows.Add(cr.Rows(c).Item("COrderID"), cr.Rows(c).Item("OrderID"), cr.Rows(c).Item("ArName"), cr.Rows(c).Item("HomeAddress"), cr.Rows(c).Item("Destination"), cr.Rows(c).Item("PickupTime"))
                c = c + 1
            End While

            Dim tex As String
            tex = "Select ODate from Orders Where OrderID=" & DataGridView8.CurrentRow.Cells(0).Value
            Dim fd As New SqlDataAdapter(tex, cn)
            Dim tt As New Data.DataTable
            fd.Fill(tt)
            TextBox35.Text = tt.Rows(0).Item("ODate").ToString
            TextBox34.Text = Convert.ToDateTime(tt.Rows(0).Item("ODate").ToString).DayOfWeek.ToString
        End If
    End Sub

    ' driver search
    Private Sub TextBox39_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox39.KeyUp
        If e.KeyData = Keys.Enter Then
            driver()
        End If
    End Sub

    ' show selected date
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        ToolStripLabel2.Text = DateTimePicker1.Value.ToShortDateString
    End Sub

    ' handle pickup & drop-off alone by sms
    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Try
            Dim cm1 As New SqlCommand
            Dim k As Integer = D1.CurrentRow.Index
            Dim Sqm As String
            Sqm = "update FullRoster set GPSNote=N'Alone',GPSOfficer = " & UserName & ",DMnote=N'SMS صعود لوحده فقط" & System.DateTime.Now.ToShortTimeString & "' where RID=" & D1(20, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D1(11, k).Value = "Alone"

            D1(15, k).Value = "SMS صعود لوحده فقط" & System.DateTime.Now.ToShortTimeString
            D1.CurrentRow.DefaultCellStyle.BackColor = Color.Tan
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        Panel2.Visible = False
    End Sub

    ' handle drop-off alone
    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Try
            Dim cm1 As New SqlCommand
            Dim k As Integer = D1.CurrentRow.Index
            Dim Sqm As String
            Sqm = "update FullRoster set GPSNote=N'Alone',GPSOfficer = " & UserName & ",DMnote=N'SMS نزول لوحده فقط" & System.DateTime.Now.ToShortTimeString & "' where RID=" & D1(20, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D1(11, k).Value = "Alone"

            D1(15, k).Value = "SMS نزول لوحده فقط" & System.DateTime.Now.ToShortTimeString
            D1.CurrentRow.DefaultCellStyle.BackColor = Color.Tan
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        Panel2.Visible = False
    End Sub

    ' handle pickup & drop-off alone
    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Try

            Dim cm1 As New SqlCommand
            Dim k As Integer = D1.CurrentRow.Index
            Dim Sqm As String
            Sqm = "update FullRoster set GPSNote=N'Alone',GPSOfficer = " & UserName & ",DMnote=N'SMS صعود و نزول لوحده " & System.DateTime.Now.ToShortTimeString & "' where RID=" & D1(20, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D1(11, k).Value = "Alone"

            D1(15, k).Value = "SMS صعود و نزول لوحده " & System.DateTime.Now.ToShortTimeString
            D1.CurrentRow.DefaultCellStyle.BackColor = Color.Tan
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        Panel2.Visible = False
    End Sub

    ' handle pickup & drop-off alone
    Private Sub صعودونزولToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles صعودونزولToolStripMenuItem.Click
        Try

            Dim cm1 As New SqlCommand
            Dim k As Integer = D1.CurrentRow.Index
            Dim Sqm As String
            Sqm = "update FullRoster set GPSNote=N'Alone',GPSOfficer = " & UserName & ",DMnote=N'CALL Pickup & Drop-off " & System.DateTime.Now.ToShortTimeString & "' where RID=" & D1(20, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D1(11, k).Value = "Alone"

            D1(15, k).Value = "CALL Pickup & Drop-off " & System.DateTime.Now.ToShortTimeString
            D1.CurrentRow.DefaultCellStyle.BackColor = Color.Tan
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        Panel2.Visible = False
    End Sub

    ' handle drop-off alone
    Private Sub نزولToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles نزولToolStripMenuItem.Click
        Try

            Dim cm1 As New SqlCommand
            Dim k As Integer = D1.CurrentRow.Index
            Dim Sqm As String
            Sqm = "update FullRoster set GPSNote=N'Alone',GPSOfficer = " & UserName & ",DMnote=N'CALL نزول لوحده فقط" & System.DateTime.Now.ToShortTimeString & "' where RID=" & D1(20, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D1(11, k).Value = "Alone"

            D1(15, k).Value = "CALL نزول لوحده فقط" & System.DateTime.Now.ToShortTimeString
            D1.CurrentRow.DefaultCellStyle.BackColor = Color.Tan
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        Panel2.Visible = False
    End Sub

    ' handle pickup alone
    Private Sub صعودToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles صعودToolStripMenuItem.Click
        Try

            Dim cm1 As New SqlCommand
            Dim k As Integer = D1.CurrentRow.Index
            Dim Sqm As String
            Sqm = "update FullRoster set GPSNote=N'Alone',GPSOfficer = " & UserName & ",DMnote=N'CALL صعود لوحده فقط" & System.DateTime.Now.ToShortTimeString & "' where RID=" & D1(20, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D1(11, k).Value = "Alone"

            D1(15, k).Value = "CALL صعود لوحده فقط" & System.DateTime.Now.ToShortTimeString
            D1.CurrentRow.DefaultCellStyle.BackColor = Color.Tan
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        Panel2.Visible = False
    End Sub

    ' tooltip for bus location column
    Private Sub DataGridView9_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView9.CellFormatting
        DataGridView9.Columns(1).ToolTipText = "double click to open bus location on the map "
    End Sub

    ' open bus location on the map using locator
    Private Sub DataGridView9_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView9.CellMouseDoubleClick
        If DataGridView9.CurrentCell.ColumnIndex = 1 Then
            locator(DataGridView9.CurrentCell.Value)
        End If
    End Sub

    ' handle driver to bus mapping
    Private Sub DataGridView9_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView9.CellValueChanged
        If kg = 1 Then
            Try
                Dim cm As New SqlCommand
                Dim dmm As New System.Data.DataTable
                Dim ST As String
                If DataGridView9.CurrentCell.Value.ToString <> "" Then
                    If DataGridView9.CurrentCell.Value.ToString.Length = 3 Then
                        ST = "select * from bus where Buss= '" & DataGridView9.CurrentRow.Cells(1).Value & "'"

                        Dim dkk As New SqlDataAdapter(ST, cn)
                        dkk.Fill(dmm)
                        DataGridView9.CurrentRow.Cells(1).Value = dmm.Rows(0).Item("Bus")
                    End If
                End If

                Dim cm1 As New SqlCommand
                Dim Sqm As String
                Sqm = "update bus set drname=N'" & DataGridView9.CurrentRow.Cells(0).Value & "'  where Bus= '" & dmm.Rows(0).Item("Bus") & "'"
                cm1 = New SqlCommand(Sqm, cn)
                cm1.ExecuteNonQuery()

                Dim cm11 As New SqlCommand
                Dim Sqm1 As String
                Sqm1 = "update bus set drname=N''  where Bus <> '" & dmm.Rows(0).Item("Bus") & "' and drname=N'" & DataGridView9.CurrentRow.Cells(0).Value & "'"
                cm11 = New SqlCommand(Sqm1, cn)
                cm11.ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End If
    End Sub

    ' date time picker 2
    Private Sub DateTimePicker2_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        ToolStripLabel1.Text = DateTimePicker2.Value.ToShortDateString
    End Sub

    ' email alone both
    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Try
            Dim cm1 As New SqlCommand
            Dim k As Integer = D1.CurrentRow.Index
            Dim Sqm As String
            Sqm = "update FullRoster set GPSNote=N'Alone',GPSOfficer = " & UserName & ",DMnote=N'EMAIL صعود و نزول لوحده " & System.DateTime.Now.ToShortTimeString & "' where RID=" & D1(20, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D1(11, k).Value = "Alone"

            D1(15, k).Value = "EMAIL صعود و نزول لوحده " & System.DateTime.Now.ToShortTimeString
            D1.CurrentRow.DefaultCellStyle.BackColor = Color.Tan
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        Panel2.Visible = False
    End Sub

    ' email alone dropoff
    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        Try
            Dim cm1 As New SqlCommand
            Dim k As Integer = D1.CurrentRow.Index
            Dim Sqm As String
            Sqm = "update FullRoster set GPSNote=N'Alone',GPSOfficer = " & UserName & ",DMnote=N'EMAIL نزول لوحده فقط" & System.DateTime.Now.ToShortTimeString & "' where RID=" & D1(20, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D1(11, k).Value = "Alone"

            D1(15, k).Value = "EMAIL نزول لوحده فقط" & System.DateTime.Now.ToShortTimeString
            D1.CurrentRow.DefaultCellStyle.BackColor = Color.Tan
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        Panel2.Visible = False
    End Sub

    ' email alone pickup
    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        Try
            Dim cm1 As New SqlCommand
            Dim k As Integer = D1.CurrentRow.Index
            Dim Sqm As String
            Sqm = "update FullRoster set GPSNote=N'Alone',GPSOfficer = " & UserName & ",DMnote=N'EMAIL صعود لوحده فقط" & System.DateTime.Now.ToShortTimeString & "' where RID=" & D1(20, k).Value
            cm1 = New SqlCommand(Sqm, cn)
            cm1.ExecuteNonQuery()

            D1(11, k).Value = "Alone"

            D1(15, k).Value = "EMAIL صعود لوحده فقط" & System.DateTime.Now.ToShortTimeString
            D1.CurrentRow.DefaultCellStyle.BackColor = Color.Tan
        Catch ex As Exception
            ErrorLog(ex.Message + "Application Comment: ****" + ex.StackTrace() + "****")
        End Try
        Panel2.Visible = False
    End Sub

    ' tooltip for datagridview
    Private Sub D1_CellMouseEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles D1.CellMouseEnter
        D1.Columns(4).CellTemplate.ToolTipText = "a"
    End Sub

    ' fleet watch import
    Private Sub FleetTeastBtn_Click(sender As Object, e As EventArgs) Handles FleetTeastBtn.Click
        Dim FlightNumber As String = ""
        Dim AircraftType As String = ""
        Dim DeptTime As String = ""
        Dim Destination As String = ""
        OpenFileDialog1.ShowDialog()

        txtfleetwatch.Text = OpenFileDialog1.FileName
        If txtfleetwatch.Text.Contains("fleet") Then
            GroupBox2.Hide()

            Dim myCommand As New SqlCommand
            Dim strSQL As String = ""
            Dim TESTNEWSTR As String = ""
            Dim testarr As Array
            Dim testarr2 As Array

            Dim detTemp As String = "DELETE FLEET"
            Dim myCommand1 As New SqlCommand
            myCommand1 = New SqlCommand(detTemp, con)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            myCommand1.ExecuteNonQuery()
            myCommand1.Dispose()

            Try
                Using sr As New StreamReader(txtfleetwatch.Text)
                    testarr = sr.ReadToEnd().Trim.Split(Environment.NewLine)
                    System.Console.WriteLine(testarr)

                    Dim lines() As String = IO.File.ReadAllLines(System.IO.Path.GetFullPath(OpenFileDialog1.FileName))
                    Dim countindx As Integer = Array.FindIndex(lines, Function(s) s.Contains(" Date "))

                    For count1 = countindx To testarr.Length - 1

                        Dim s As String = testarr(count1).ToString
                        If s.Length > 15 Then
                            s = s.Insert(16, " ")
                            s = s.Insert(8, " ")
                            s = s.Insert(69, " ")
                        End If
                        Dim arr() As String = {" ", "  ", "   ", "    ", "     ", "      ", "       ", "        "}
                        Dim rep() As String = {","}
                        Dim i As Integer = Nothing

                        testarr2 = s.Split({" "}, StringSplitOptions.RemoveEmptyEntries)
                        If testarr2.Length > 1 And testarr2(0).ToString.TrimStart IsNot Nothing Then

                            If IsNumeric(testarr2(0).ToString.TrimStart.First) Then
                                If testarr2(2).ToString.StartsWith("0") Then
                                    FlightNumber = testarr2(2).ToString.Substring(1)
                                    If FlightNumber.ToString.StartsWith("0") Then
                                        FlightNumber = FlightNumber.Substring(1)
                                    End If
                                Else
                                    FlightNumber = testarr2(2).ToString
                                    If FlightNumber.ToString.StartsWith("0") Then
                                    End If
                                End If
                                AircraftType = testarr2(3)
                                'Dim asfry As String = testarr(count1).ToString.IndexOf("0215")
                                DeptTime = testarr2(6).ToString.Substring(0, 2) & ":" & testarr2(6).ToString.Substring(2, 2)
                                'Dim asfry As String = testarr(count1).ToString.IndexOf("BEY")
                                'Destination = testarr(count1).ToString.Substring(42).Trim
                                Destination = testarr2(testarr2.Length - 1).ToString.Substring(testarr2(testarr2.Length - 1).ToString.Length - 3)
                                If testarr2(testarr2.Length - 2).ToString.EndsWith(",") Then
                                    Destination = testarr2(testarr2.Length - 2).ToString.Substring(testarr2(testarr2.Length - 2).ToString.Length - 4) & Destination
                                End If
                                If AircraftType = "342" Then
                                    AircraftType = "340"
                                End If
                                If AircraftType = "323" Then
                                    AircraftType = "321"
                                End If
                                If AircraftType = "31F" Then
                                    AircraftType = "310"
                                End If
                                strSQL = "insert into FLEET ([FLIGHT_NUMBER],[AIRCRAFT_TYPE],[DEP_TIME],[DEST]) values ('" + FlightNumber + "','" + AircraftType + "','" + DeptTime + "','" + Destination + "')"
                                myCommand = New SqlCommand(strSQL, con)

                                myCommand.ExecuteNonQuery()

                            End If
                        End If
                    Next count1
                    '   Dim strSQL1 As String = "select ([FLIGHT_NUMBER],[AIRCRAFT_TYPE],[DEP_TIME],[DEST]) from FLEET "
                End Using
            Catch ex As Exception
                System.Console.WriteLine("The file could not be read:")
                MessageBox.Show(ex.Message)
            End Try
            GroupBox2.Show()
            'GroupBox3.Hide()
        Else
            MessageBox.Show("Error file name fleet")
            txtfleetwatch.Text = ""
        End If
    End Sub

    ' roaster import
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim testarr As Array
        Dim AircraftTypeN As String = ""
        Dim flighNum As String = ""
        Dim AugType As String = ""
        Dim DepTime As String = ""
        Dim dateT As String = ""
        Dim tempdeptime As Array
        Dim tempdeptime1 As String = ""

        OpenFileDialog1.ShowDialog()
        testtext.Text = OpenFileDialog1.FileName
        'SAVE TO EXCEL

        If testtext.Text.ToString.Contains("aircraft") Then

            Dim strSQL2 As String
            Dim Mcommand2 As SqlCommand
            Dim detTemp As String = "DELETE ROSTER1"
            Dim myCommand1 As SqlCommand
            myCommand1 = New SqlCommand(detTemp, con)
            myCommand1.ExecuteNonQuery()
            myCommand1.Dispose()
            '  Try
            Using sr As New StreamReader(testtext.Text)
                testarr = sr.ReadToEnd().Split(Environment.NewLine)

                System.Console.WriteLine(testarr)
                sr.Close()

                For seccound As Integer = 0 To testarr.Length - 1
                    '      MessageBox.Show(testarr(seccound).ToString.Trim)
                    Dim HJK As Integer = testarr(seccound).ToString.Replace(vbTab, "").Replace(" ", "").Length

                    If testarr(seccound).ToString.Trim <> "" And HJK > 30 Then
                        dateT = testarr(seccound).ToString.Trim.Replace(" ", "").Substring(6, 5).Trim

                        'dateT = testarr(seccound).ToString.Substring(11, 6).Trim
                        Dim thisMonth As String
                        Dim name As String
                        Dim ddatee As Date = Date.Now.AddDays(1).ToShortDateString
                        '  Dim ddate As Date = CDate(ddatee.ToString)
                        'ddatee.ToString("DD/MM/yyyy", CultureInfo.InvariantCulture)
                        Dim ddate As String = Format(ddatee, "MM/dd/yyyy")
                        Dim tday As String = ""

                        Dim temofltnum2 As Array = ddate.ToString.Trim.Split("/")
                        If temofltnum2(1) < 10 And Not temofltnum2(1).ToString.Contains("0") Then
                            tday = "0" & temofltnum2(1)
                        Else
                            tday = temofltnum2(1)
                        End If
                        '  MessageBox.Show(ddate)
                        '   tday = ddate.ToString.Substring(4, 1)
                        '   End If
                        If temofltnum2(0) < 10 And Not temofltnum2(0).ToString.Contains("0") Then
                            thisMonth = "0" & temofltnum2(0)
                        Else
                            thisMonth = temofltnum2(0)
                        End If
                        'thisMonth = temofltnum2(0)
                        name = MonthName(thisMonth, True)
                        Dim tempdateT As String = tday & "/" & thisMonth
                        ' MessageBox.Show(testarr(seccound).ToString.IndexOf("B"))
                        Dim s As String = testarr(seccound).ToString.IndexOf("B")
                        If tempdateT = dateT Then
                            Dim temofltnum As Array = testarr(seccound).ToString.Split(" ")

                            flighNum = temofltnum(0)


                            AugType = temofltnum(69)
                            Dim dept As Array = temofltnum(79).ToString.Split(vbTab)
                            DepTime = dept(1).ToString
                            ' tempdeptime = DepTime.ToString.Trim.Split(":")
                            ' tempdeptime1 = (tempdeptime(0) + Dtimezone)
                            ' If tempdeptime1 >= 24 Then
                            'mpdeptime1 = tempdeptime1 - 24
                            'End If
                            ' DepTime = tempdeptime1 & ":" & tempdeptime(1)
                            Dim arrayin As Integer
                            For arrayin = 56 To 66
                                If temofltnum(arrayin).ToString.Replace(vbTab, "") <> "." Then
                                    AircraftTypeN = temofltnum(arrayin)
                                    Exit For
                                End If

                            Next

                            'Dim s As String = testarr(seccound).ToString.IndexOf("7:20")

                            strSQL2 = "INSERT INTO ROSTER1 (FLIGHT_NUMBER,DEP_TIME,TOTAL_CREW_NUM,AIRCRAFTYPE) VALUES ('" & flighNum & "','" & DepTime & "','" & AugType & "','" & AircraftTypeN & "')" & ";"
                            Mcommand2 = New SqlCommand(strSQL2, con)
                            Mcommand2.ExecuteNonQuery()
                            Mcommand2.Dispose()
                        ElseIf dateT.Contains(name) Then
                            MessageBox.Show("You Requiested a rong date " & dateT)

                            Exit For
                        End If
                        btnroster.Enabled = True
                    End If
                Next seccound
            End Using
            'Catch ex As Exception
            ' Console.WriteLine("The file could not be read:")
            'MessageBox.Show(ex.Message)
            ' End Try
        Else
            MessageBox.Show("File Name Error")
            testtext.Text = ""
        End If
    End Sub

    ' handle roster file
    Private Sub btnroster_Click(sender As Object, e As EventArgs) Handles btnroster.Click
        'OpenFileDialog1.ShowDialog()
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        txtroster.Text = OpenFileDialog1.FileName
        Dim tempstrr As String
        tempstrr = txtroster.Text.Trim
        ' Check if the "OK" button was clicked
        If result = DialogResult.OK Then
            '  StartLongRunningOperation()
            Label24.Visible = True
            Me.Cursor = Cursors.WaitCursor
            If tempstrr.Contains("roster") Then
                Dim testarr As Array
                Dim teststr As String

                Dim tempint As Integer = 0
                xlApp = New Excel.Application
                xlWorkBook = xlApp.Workbooks.Open(tempstrr)

                xlWorkSheet = xlWorkBook.Worksheets(1)

                Dim myConnection As SqlConnection
                Dim myCommand As SqlCommand
                myConnection = con

                Dim detTemp As String = ""
                Dim myCommand10 As SqlCommand
                detTemp = "DELETE ROSTER2"
                myCommand10 = New SqlCommand(detTemp, con)
                myCommand10.ExecuteNonQuery()
                myCommand10.Dispose()
                myConnection.Close()

                'Dim strSQL As String
                Dim FlightNumber As String
                Dim DeptTime As String
                Dim temparr As Array

                Dim RowsRoster As Integer = xlApp.ActiveSheet.UsedRange.Rows.Count

                xlWorkSheet.Range("A4", "A" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous

                xlWorkSheet.Range("A4", "A" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                xlWorkSheet.Range("B4", "B" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range("B4", "B" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                xlWorkSheet.Range("C4", "C" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range("C4", "C" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                xlWorkSheet.Range("D4", "D" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range("D4", "D" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                xlWorkSheet.Range("E4", "E" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range("E4", "E" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                xlWorkSheet.Range("F4", "F" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range("F4", "F" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                xlWorkSheet.Range("G4", "G" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range("G4", "G" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                xlWorkSheet.Range("H4", "H" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range("H4", "H" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                xlWorkSheet.Range("I5", "I" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range("I4", "I" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous


                xlWorkSheet.Range("J5", "J" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                xlWorkSheet.Range("J4", "J" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous


                xlWorkSheet.Range("A6:J6").Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous

                xlWorkSheet.Range("A" & RowsRoster - 1 & ":" & "J" & RowsRoster - 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

                xlWorkSheet.Range("A4:J4").Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                'Dim maisstrtsrt As String = ""

                myConnection.Open()

                For pick As Integer = 10 To RowsRoster

                    Dim tests As String = xlWorkSheet.Cells(pick, 1).value
                    If xlWorkSheet.Cells(pick, 1).value Is Nothing Then

                    Else
                        If xlWorkSheet.Cells(pick, 1).value.ToString = "DATE" Then
                            Dim xlRange12 As Excel.Range = Nothing
                            xlRange12 = CType(xlWorkSheet.Rows(pick), Excel.Range)

                            xlRange12.Delete()
                        End If
                    End If
                Next pick

                For pick1 As Integer = 1 To RowsRoster
                    If xlWorkSheet.Cells(pick1, 2).value = "PickUp" Then
                        Dim xlRange1 As Excel.Range = Nothing
                        xlRange1 = CType(xlWorkSheet.Rows(pick1), Excel.Range)
                        xlRange1.Delete()

                    End If
                Next pick1
                xlWorkSheet.Rows(1 & ":" & 3).Delete()

                xlWorkSheet.Cells(1, 5).value = "Flight"

                Dim rowsc As Integer = xlApp.ActiveSheet.UsedRange.Rows.Count

                For bn As Integer = 1 To rowsc - 1
                    Dim za As String = xlWorkSheet.Cells(bn, 5).value
                    If xlWorkSheet.Cells(bn, 5).value.ToString = "" Then
                        xlWorkSheet.Cells(bn, 6).value = 1
                        xlWorkSheet.Cells(bn, 5).value = xlWorkSheet.Cells(bn - 1, 5).value
                        'xlWorkSheet.Cells(bn, 4).value = xlWorkSheet.Cells(bn - 1, 4).value
                        ' xlWorkSheet.Cells(bn, 3).value = xlWorkSheet.Cells(bn - 1, 3).value
                        xlWorkSheet.Cells(bn, 2).value = xlWorkSheet.Cells(bn - 1, 2).value
                        xlWorkSheet.Cells(bn, 1).value = xlWorkSheet.Cells(bn - 1, 1).value

                    End If

                Next bn

                For ssss As Integer = 2 To rowsc
                    Dim za As String = xlWorkSheet.Cells(ssss, 5).value
                    Dim za1 As String = xlWorkSheet.Cells(ssss - 1, 5).value

                    If xlWorkSheet.Cells(ssss, 5).value <> "" And xlWorkSheet.Cells(ssss, 5).value = xlWorkSheet.Cells(ssss - 1, 5).value Then
                        Dim strSQLdeletecell As String = ""
                        strSQLdeletecell = "insert into deletecell (rowid) values (" & ssss & ")"
                        myCommand = New SqlCommand(strSQLdeletecell, con)
                        '  myConnection.Open()
                        myCommand.ExecuteNonQuery()
                    End If
                Next ssss

                Dim SQL As String
                SQL = "select * from deletecell "
                Dim dn As New SqlDataAdapter(SQL, myConnection)
                Dim dq As New System.Data.DataTable
                dn.Fill(dq)

                For sc As Integer = 0 To dq.Rows.Count - 1

                    xlWorkSheet.Cells(dq.Rows(sc).Item("rowid"), 5) = ""
                    xlWorkSheet.Cells(dq.Rows(sc).Item("rowid"), 4) = ""
                    xlWorkSheet.Cells(dq.Rows(sc).Item("rowid"), 3) = ""
                    xlWorkSheet.Cells(dq.Rows(sc).Item("rowid"), 2) = ""
                    xlWorkSheet.Cells(dq.Rows(sc).Item("rowid"), 1) = ""

                Next sc


                For SS As Integer = 1 To RowsRoster

                    If xlWorkSheet.Cells(SS, 5).value <> "" Then
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("RJ") Then
                            'testlbl.Text = ""
                            temparr = xlWorkSheet.Cells(SS, 5).text.ToString.Trim.Split(" ")
                            FlightNumber = temparr(0).ToString.Substring(2)
                            DeptTime = temparr(2)

                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Range("E" & SS).Value.ToString.StartsWith("ASBY") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Range("E" & SS).Value.ToString.StartsWith("ASBY") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("MEET") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("AMDC") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("CDGC") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("QP") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("VLC") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("IFE") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("MSC") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("SRC") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("CC") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("YAC") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("JCC") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("SMC") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("SUP") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("CSAF") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("BCC") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("CSEC") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("GRD5") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("GRD2") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("GRD3") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("GRD1") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("PSC") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Range("E" & SS).Value.ToString.StartsWith("BSAF") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Range("E" & SS).Value.ToString.StartsWith("CONV") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Range("E" & SS).Value.ToString.StartsWith("BDG") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Range("E" & SS).Value.ToString.StartsWith("BCRM") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Range("E" & SS).Value.ToString.StartsWith("BSEC") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("GRD4") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("BRF") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("CCRM") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("GR") Then
                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        Dim con1 As New SqlConnection
                        Dim cmd1 As New SqlCommand
                        Dim da1 As New SqlDataAdapter
                        Dim ds1 As New DataSet("Data1")
                        Dim TempFltNum As String = ""
                        Dim TempDepTime As String = ""
                        Dim TempRostDepTime As String = ""
                        cmd1.CommandType = CommandType.Text
                        con1 = con
                        cmd1.Connection = con1
                        cmd1.CommandText = "select FLIGHT_NUMBER, DEP_TIME from roster1 where TOTAL_CREW_NUM = 'B'"
                        da1.SelectCommand = cmd1
                        da1.Fill(ds1, "Data1")
                        If ds1.Tables(0).Rows.Count > 0 Then
                            For i As Integer = 0 To ds1.Tables(0).Rows.Count - 1
                                TempDepTime = ds1.Tables(0).Rows(i).Item(1).ToString().Trim.Substring(0, 3) & ds1.Tables(0).Rows(i).Item(1).ToString().Trim.Substring(3, 2) + 1
                                TempFltNum = ds1.Tables(0).Rows(i).Item(0).ToString().Trim
                                If xlWorkSheet.Cells(SS, 5).value.ToString.Trim.Contains("RJ") Then

                                    TempRostDepTime = xlWorkSheet.Cells(SS, 2).value.ToString.Trim
                                    If xlWorkSheet.Cells(SS, 2).value.ToString.Trim.Substring(0, 2) < 4 And xlWorkSheet.Cells(SS, 2).value.ToString.Trim.Substring(0, 2) > 21 Then
                                        Dim sssr1 As String = xlWorkSheet.Cells(SS, 2).value.ToString.Trim.Substring(0, 2) + 3
                                        If sssr1 >= 24 Then
                                            sssr1 = sssr1 - 24
                                            If sssr1 < 10 Then
                                                TempRostDepTime = "0" & sssr1 & ":" & xlWorkSheet.Cells(SS, 2).value.ToString.Trim.Substring(3)
                                            End If
                                            TempRostDepTime = sssr1 & ":" & xlWorkSheet.Cells(SS, 2).value.ToString.Trim.Substring(3)
                                        End If

                                    Else
                                        Dim sssr1 As String = xlWorkSheet.Cells(SS, 2).value.ToString.Trim.Substring(0, 2) + Dtimezone
                                        Dim sssr2 As String = xlWorkSheet.Cells(SS, 2).value.ToString.Trim.Substring(3, 1) + Dtimezone
                                        If sssr1 >= 24 Then
                                            sssr1 = sssr1 - 24
                                        End If
                                        If sssr2 >= 6 Then
                                            sssr2 = sssr2 - 6
                                            sssr1 = sssr1 + 1
                                        End If
                                        If sssr1 < 10 Then
                                            TempRostDepTime = "0" & sssr1 & ":" & sssr2 & xlWorkSheet.Cells(SS, 2).value.ToString.Trim.Substring(4)

                                        End If
                                        TempRostDepTime = sssr1 & ":" & sssr2 & xlWorkSheet.Cells(SS, 2).value.ToString.Trim.Substring(4)
                                    End If

                                    If TempFltNum.Contains("C") Or TempFltNum.Contains("D") Then
                                        If TempDepTime = TempRostDepTime Then
                                            If xlWorkSheet.Cells(SS, 5).value.ToString.Contains("RJ" & TempFltNum.Substring(0, 3)) Then
                                                xlWorkSheet.Range("E" & (SS)).Value = "AUGMENTED"
                                                xlWorkSheet.Range("E" & (SS)).Font.Size = 12
                                                xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                                            End If
                                        End If
                                    Else
                                        If xlWorkSheet.Cells(SS, 5).value.ToString.StartsWith("RJ" & TempFltNum) Then
                                            xlWorkSheet.Range("E" & (SS + 1)).Value = "AUGMENTED"
                                            xlWorkSheet.Range("E" & (SS + 1)).Font.Size = 12
                                            xlWorkSheet.Range("A" & SS & ":" & "J" & SS).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                                        End If
                                    End If
                                End If
                            Next
                        End If



                    End If

                Next SS
                Dim crewId As String
                Dim strSQLt As String
                Dim rosterName As String
                Dim POS As String
                Dim arrr As Array
                Dim fltNum As String
                Dim FLTCOUNT As Integer = 0


                For zz As Integer = 1 To RowsRoster

                    If xlWorkSheet.Cells(zz, 5).text.ToString.Trim.StartsWith("RJ") Then


                        arrr = xlWorkSheet.Cells(zz, 5).value.ToString.Split(" ")

                        fltNum = arrr(0)
                        If fltNum <> "" Then


                            fltNum = fltNum.Substring(2)
                            FLTCOUNT = xlWorkSheet.Cells(zz, 6).text.ToString.Trim
                            FLTCOUNT = FLTCOUNT + zz - 1
                            For zzz As Integer = zz To FLTCOUNT
                                crewId = xlWorkSheet.Cells(zzz, 8).text.ToString.Trim
                                rosterName = xlWorkSheet.Cells(zzz, 9).text.ToString.Trim
                                POS = xlWorkSheet.Cells(zzz, 7).text.ToString.Trim
                                If rosterName.Contains("'") Then
                                    Dim temparr2 As Array
                                    temparr2 = rosterName.Split("'")
                                    rosterName = temparr2(0).ToString.Trim
                                    Dim testint As Integer = temparr2.Length
                                    For TE As Integer = 1 To temparr2.Length - 1
                                        rosterName = rosterName & temparr2(TE).ToString
                                    Next TE
                                    'rosterName = temparr2(0).ToString.Trim & temparr2(1).ToString
                                End If
                                strSQLt = "insert into ROSTER2 ([CREW_ID],[ROSTER_NAME],[POSITION],[FLIGHT_NUMBER]) values ('" + crewId + "'" + "," + "'" + rosterName + "'" + "," + "'" + POS + "'" + "," + "'" + fltNum + "')"
                                myCommand = New SqlCommand(strSQLt, con)
                                If myConnection.State = ConnectionState.Closed Then
                                    myConnection.Open()
                                End If
                                myCommand.ExecuteNonQuery()
                            Next zzz

                            myConnection.Close()
                        End If
                    End If


                Next zz


                'Console.Read()
                'myCommand.Dispose()

                testarr = txtroster.Text.Trim.Split(".")
                teststr = testarr(0)
                Dim savename As Array = teststr.Split("\")
                testdate = (Today.AddDays(1).Day) & "-" & Today.Month & "-" & Today.Year
                xlWorkBook.SaveAs(System.Windows.Forms.Application.StartupPath & "\" & savename(savename.Length - 1) & testdate)
                txtroster.Text = teststr & " " & testdate
                xlWorkBook.Close()
                xlApp.Quit()

                ReleaseObject(xlApp)
                ReleaseObject(xlWorkBook)
                ReleaseObject(xlWorkSheet)
            Else
                MessageBox.Show("FILE ERROR CHECK IF IT IS THE SAME FILE")
                txtroster.Text = ""

                ReleaseObject(xlApp)
                ReleaseObject(xlWorkBook)
                ReleaseObject(xlWorkSheet)
            End If
            'txtroster.Text = "f:\roster.xlsx"
            Label24.Visible = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    ' clear all data from database
    Private Sub RESTORBTN_Click(sender As Object, e As EventArgs) Handles RESTORBTN.Click

        Dim myCommand As SqlCommand
        Dim strsql As String

        strsql = "DELETE FLEET  DELETE ROSTER1 DELETE ROSTER2 DELETE deletecell "
        myCommand = New SqlCommand(strsql, con)
        If con.State = ConnectionState.Closed Then

            con.Open()
        End If
        myCommand.ExecuteNonQuery()

        txtfleetwatch.Text = ""

        txtroster.Text = ""
        testtext.Text = ""
        MessageBox.Show("CLEARED")
    End Sub

    ' create roster with flight details
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '  Try
        Label24.Visible = True
        Me.Cursor = Cursors.WaitCursor
        Dim ORIGIN_LINE As String = ""
        Dim A As String = ""
        Dim Aback As String = ""
        Dim bint As Integer = 0
        Dim STR As String = System.Windows.Forms.Application.StartupPath & "\roster" & testdate
        'System.Windows.Forms.Application.StartupPath & "\roster\"

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim myDataReader As SqlDataReader
        Dim myDataReader2 As SqlDataReader
        Dim repstr As String = ""
        'Dim myDataReaderBack As System.Data.SqlClient.SqlDataReader

        Dim myCommand As SqlCommand
        Dim myCommandBack As SqlCommand
        Dim myCommand1 As SqlCommand


        Dim strSQL As String
        Dim strSQLBSCK As String
        Dim TEMPSTR As String
        Dim arrr As Array
        Dim crewId As String
        xlApp = New Excel.Application

        xlWorkBook = xlApp.Workbooks.Open(STR)
        xlWorkSheet = xlWorkBook.Worksheets(1)
        Dim myConnection As SqlConnection
        myConnection = con

        Dim RowsRoster As Integer = xlApp.ActiveSheet.UsedRange.Rows.Count


        Dim ttempstrr As String = ""
        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        For sss As Integer = 1 To RowsRoster

            'Dim qa As String = xlWorkSheet.Cells(sss, 1).value.ToString
            Dim za As String = xlWorkSheet.Cells(sss, 5).value
            ' Try
            'If xlWorkSheet.Cells(sss, 1).value.ToString <> "" Then

            If xlWorkSheet.Cells(sss, 5).value <> "" Then

                If xlWorkSheet.Cells(sss, 5).value.ToString.StartsWith("RJ") Then

                    ORIGIN_LINE = xlWorkSheet.Cells(sss, 5).value.ToString.Trim
                    arrr = xlWorkSheet.Cells(sss, 5).value.ToString.Split(" ")
                    A = arrr(0)
                    A = A.Substring(2)
                    bint = A + 1
                    Aback = bint
                    strSQL = "SELECT RTRIM(LTRIM(FLIGHT_NUMBER)) AS FLIGHT_NUMBER,[AIRCRAFT_TYPE],[DEST] FROM FLEET where [FLIGHT_NUMBER]='" + A.Trim + "'"
                    myCommand = New SqlCommand(strSQL, myConnection)


                    myDataReader = myCommand.ExecuteReader()
                    If myDataReader.Read() Then

                        Dim AircraftType As String = myDataReader.Item("AIRCRAFT_TYPE")
                        Dim Destination As String = myDataReader.Item("DEST")

                        TEMPSTR = xlWorkSheet.Cells(sss, 5).text.ToString.Trim
                        Dim flighttext As String = TEMPSTR & " ( " & AircraftType.Trim & "-" & Destination.Trim & " )"

                        xlWorkSheet.Cells(sss, 5) = flighttext
                    Else

                    End If
                    myDataReader.Close()
                End If

            End If

        Next sss

        Dim cmdOLEDB As New SqlCommand

        Dim detTemp1 As String = "DELETE deletecell"
        Dim myCommanddelete As SqlCommand
        myCommanddelete = New SqlCommand(detTemp1, con)
        myCommanddelete.ExecuteNonQuery()
        myCommanddelete.Dispose()

        xlWorkSheet.Columns(3).EntireColumn.Delete()
        xlWorkSheet.Columns(3).EntireColumn.Delete()

        xlWorkSheet.Range("a2", "z" & (RowsRoster + 5)).Font.Size = 14
        xlWorkSheet.Range("A1:X1").EntireColumn.AutoFit()

        xlWorkSheet.Name = "Roster"
        'xlWorkBook.SaveAs(System.Windows.Forms.Application.StartupPath & "\roster\roster" & testdate)
        ' xlWorkBook.Close()
        ' xlApp.Quit()
        Using sfd As New SaveFileDialog()
            sfd.Title = "Save Roster"
            sfd.DefaultExt = "xlsx"
            sfd.FileName = "roster" & testdate

            sfd.Filter = "Excel Workbooks (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            sfd.AddExtension = True
            sfd.OverwritePrompt = True
            If sfd.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = sfd.FileName

                xlWorkBook.SaveAs(filePath)
                xlWorkBook.Close(SaveChanges:=False) ' Close without saving changes if not needed
                xlApp.Quit()
                MessageBox.Show("File saved successfully to: " & filePath, "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

                GroupBox8.Show()

                LoadExcelToDataGridView(filePath, "Roster", DataGridView1)
                ReleaseObject(xlApp)
                ReleaseObject(xlWorkBook)
                ReleaseObject(xlWorkSheet)
            End If
        End Using
        Label24.Visible = False
        Me.Cursor = Cursors.Default
        '  Catch ex As Exception
        '    Dim ssst As New StackTrace(True)
        '   ssst = New StackTrace(ex, True)
        '   MessageBox.Show("Line: " & ssst.GetFrame(0).GetFileLineNumber().ToString, "Error")
        '    End Try
        '  System.Diagnostics.Process.Start(LOGPath)
    End Sub

    ' Load Excel data into DataGridView
    Private Sub LoadExcelToDataGridView(filePath As String, sheetName As String, dataGrid As DataGridView)
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties=""Excel 12.0 Xml;HDR=YES;IMEX=1"""
        ' HDR=YES indicates that the first row contains column headers.
        ' IMEX=1 ensures mixed data types are handled correctly.

        Using con As New System.Data.OleDb.OleDbConnection(connectionString)
            con.Open()
            Dim query As String = $"SELECT * FROM [{sheetName}$]" ' Select all data from the specified sheet
            Using adapter As New OleDbDataAdapter(query, con)
                Dim dt1 As New DataTable
                adapter.Fill(dt1)
                dataGrid.DataSource = dt1 ' Bind the DataTable to the DataGridView
            End Using
            con.Close()
        End Using
    End Sub

    ' scrolling text handler at the bottom of the roster tab
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Dim dist As Integer = 3
        BottomLabel.Left -= dist
        If BottomLabel.Right <= 0 Then
            BottomLabel.Left = Me.Width
        End If
    End Sub

    'NOTES CALENDAR CODE

    Private Class NoteRecord
        Public Property Id As Integer
        Public Property NoteDate As DateTime
        Public Property NoteValue As String
        Public Property Important As Boolean
    End Class

    Private Class DayCellData
        Public Property [Date] As DateTime
        Public Property Notes As List(Of NoteRecord)
    End Class

    ' Build calendar grid for given month/year
    Private Sub BuildCalendar(year As Integer, month As Integer)
        dgvCalendar.SuspendLayout()
        dgvCalendar.Dock = DockStyle.Fill
        dgvCalendar.Columns.Clear()
        dgvCalendar.Rows.Clear()
        dgvCalendar.RowHeadersVisible = False
        dgvCalendar.AllowUserToAddRows = False
        dgvCalendar.ScrollBars = dgvCalendar.ScrollBars.None
        dgvCalendar.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvCalendar.ReadOnly = True

        ' Columns
        Dim days = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}
        For Each d In days
            Dim col As New DataGridViewTextBoxColumn()
            col.HeaderText = d
            col.SortMode = DataGridViewColumnSortMode.NotSortable
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvCalendar.Columns.Add(col)
        Next

        ' Rows
        Dim rowCount As Integer = 6
        For i As Integer = 1 To rowCount
            dgvCalendar.Rows.Add()
        Next

        ' Row heights
        Dim headerHeight As Integer = dgvCalendar.ColumnHeadersHeight
        Dim totalHeight As Integer = dgvCalendar.ClientSize.Height - headerHeight
        Dim rowHeight As Integer = totalHeight \ rowCount
        For Each row As DataGridViewRow In dgvCalendar.Rows
            row.Height = rowHeight
        Next

        ' Notes range
        Dim firstDayOfMonth As New DateTime(year, month, 1)
        Dim lastDayOfMonth As New DateTime(year, month, DateTime.DaysInMonth(year, month))
        Dim startDate As DateTime = firstDayOfMonth.AddDays(-CInt(firstDayOfMonth.DayOfWeek))
        Dim endDate As DateTime = lastDayOfMonth.AddDays(6 - CInt(lastDayOfMonth.DayOfWeek))
        Dim notesMap As Dictionary(Of DateTime, List(Of NoteRecord)) = GetNotesBetween(startDate, endDate)

        ' Fill calendar - only day number in Value, notes in Tag
        Dim dayDate As DateTime = startDate
        For r As Integer = 0 To rowCount - 1
            For c As Integer = 0 To 6
                Dim cell = dgvCalendar.Rows(r).Cells(c)
                cell.Tag = Nothing
                cell.Style.Alignment = DataGridViewContentAlignment.TopLeft
                cell.Style.ForeColor = Color.Black

                Dim notesList As List(Of NoteRecord) = If(notesMap.ContainsKey(dayDate), notesMap(dayDate), New List(Of NoteRecord)())

                ' Sort notes: important ones first
                notesList = notesList.OrderByDescending(Function(n) n.Important).ThenBy(Function(n) n.Id).ToList()

                ' Put only the day number in the Value (painting will draw notes)
                cell.Value = dayDate.Day.ToString()

                ' Back color for prev/next month days
                If dayDate.Month <> month Then
                    cell.Style.BackColor = Color.LightGray
                Else
                    cell.Style.BackColor = Color.White
                End If

                ' store tag with notes
                Dim dayData As New DayCellData With {
                    .[Date] = dayDate,
                    .Notes = notesList
                }
                cell.Tag = dayData

                dayDate = dayDate.AddDays(1)
            Next
        Next

        dgvCalendar.ResumeLayout()
    End Sub

    ' Fetch notes from DB between startDate and endDate (inclusive)
    Private Sub dgvCalendar_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvCalendar.CellPainting
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return

        Dim cell = dgvCalendar.Rows(e.RowIndex).Cells(e.ColumnIndex)
        Dim dayData As DayCellData = TryCast(cell.Tag, DayCellData)
        If dayData Is Nothing Then
            ' let default paint for empty/unknown cells
            Return
        End If

        e.Handled = True
        e.PaintBackground(e.CellBounds, True)

        Dim g As Graphics = e.Graphics
        Dim rect As System.Drawing.Rectangle = e.CellBounds

        ' Padding and fonts
        Dim padLeft As Integer = 4
        Dim padTop As Integer = 3
        Dim availableWidth As Integer = rect.Width - padLeft - 4
        If availableWidth <= 10 Then Return

        Dim dayFont As New System.Drawing.Font(e.CellStyle.Font, FontStyle.Bold)

        ' Determine day number color - red if any note is important
        Dim hasImportantNote As Boolean = dayData.Notes IsNot Nothing AndAlso dayData.Notes.Any(Function(n) n.Important)
        Dim dayColor As Color = If(hasImportantNote, Color.Red, Color.Black)

        ' Draw day number at top-left
        Dim dayNumberStr As String = dayData.Date.Day.ToString()
        TextRenderer.DrawText(g, dayNumberStr, dayFont, New System.Drawing.Point(rect.X + padLeft, rect.Y + padTop), dayColor, TextFormatFlags.Left Or TextFormatFlags.Top Or TextFormatFlags.NoPadding)

        ' compute y offset after day number
        Dim daySize As Size = TextRenderer.MeasureText(g, dayNumberStr, dayFont, New Size(availableWidth, rect.Height), TextFormatFlags.NoPadding)
        Dim yOffset As Integer = daySize.Height + 4

        ' area for notes
        Dim notesRect As New System.Drawing.Rectangle(rect.X + padLeft, rect.Y + yOffset, availableWidth, rect.Height - yOffset - 4)
        If notesRect.Height <= 0 Then Return

        Dim font As System.Drawing.Font = e.CellStyle.Font
        Dim lineHeight As Integer = TextRenderer.MeasureText(g, "A", font, New Size(1000, 1000), TextFormatFlags.NoPadding).Height

        Dim maxPreview As Integer = 4
        Dim currentY As Integer = notesRect.Y

        ' Ensure notes are sorted: important first
        Dim sortedNotes = If(dayData.Notes, New List(Of NoteRecord)()).OrderByDescending(Function(n) n.Important).ThenBy(Function(n) n.Id).ToList()

        For iNote As Integer = 0 To Math.Min(sortedNotes.Count - 1, maxPreview - 1)
            Dim noteRecord As NoteRecord = sortedNotes(iNote)
            Dim noteText As String = noteRecord.NoteValue
            If String.IsNullOrWhiteSpace(noteText) Then Continue For

            ' Determine note text color - red if important
            Dim noteColor As Color = If(noteRecord.Important, Color.Red, Color.Black)

            Dim bullet As String = "- "
            ' measure bullet width
            Dim bulletSize As Size = TextRenderer.MeasureText(g, bullet, font, New Size(10000, notesRect.Height), TextFormatFlags.NoPadding)
            Dim bulletWidth As Integer = Math.Min(bulletSize.Width, notesRect.Width \ 4) ' safety clamp

            Dim contentWidth As Integer = Math.Max(0, notesRect.Width - bulletWidth)

            ' Split into words and build wrapped lines for the note content (content lines DO NOT include the leading dash)
            Dim words() As String = noteText.Split(" "c)
            Dim cur As String = ""
            Dim wrappedLines As New List(Of String)
            For Each w In words
                Dim test As String = If(String.IsNullOrEmpty(cur), w, cur & " " & w)
                Dim testSize As Size = TextRenderer.MeasureText(g, test, font, New Size(10000, notesRect.Height), TextFormatFlags.NoPadding)
                If testSize.Width > contentWidth Then
                    If cur = "" Then
                        ' single very long word - force-break by character groups
                        Dim chunk As String = w
                        Dim pos As Integer = 0
                        While pos < chunk.Length
                            Dim take As Integer = 1
                            ' grow take until it doesn't fit
                            While pos + take <= chunk.Length
                                Dim cand As String = chunk.Substring(pos, take)
                                Dim candSize As Size = TextRenderer.MeasureText(g, cand, font, New Size(10000, notesRect.Height), TextFormatFlags.NoPadding)
                                If candSize.Width > contentWidth Then
                                    take -= 1
                                    Exit While
                                End If
                                take += 1
                            End While
                            If take <= 0 Then take = 1
                            wrappedLines.Add(chunk.Substring(pos, Math.Min(take, chunk.Length - pos)))
                            pos += take
                        End While
                    Else
                        wrappedLines.Add(cur)
                        cur = w
                    End If
                Else
                    cur = test
                End If
            Next
            If Not String.IsNullOrEmpty(cur) Then wrappedLines.Add(cur)

            ' Draw wrapped lines for this note:
            For li As Integer = 0 To wrappedLines.Count - 1
                If currentY + lineHeight > notesRect.Bottom Then
                    Exit For
                End If

                If li = 0 Then
                    ' first line: draw bullet then text (bullet at notesRect.X, text at notesRect.X + bulletWidth)
                    TextRenderer.DrawText(g, bullet, font, New System.Drawing.Rectangle(notesRect.X, currentY, bulletWidth, lineHeight), noteColor, TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.NoPadding)
                    TextRenderer.DrawText(g, wrappedLines(li), font, New System.Drawing.Rectangle(notesRect.X + bulletWidth, currentY, contentWidth, lineHeight), noteColor, TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.NoPadding)
                Else
                    ' continuation line: draw at indented x (no bullet)
                    TextRenderer.DrawText(g, wrappedLines(li), font, New System.Drawing.Rectangle(notesRect.X + bulletWidth, currentY, contentWidth, lineHeight), noteColor, TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.NoPadding)
                End If

                currentY += lineHeight
            Next

            ' small gap between notes
            currentY += 1
            If currentY > notesRect.Bottom Then Exit For
        Next
    End Sub

    ' Updated helper function: get notes between two dates including Important column
    Private Function GetNotesBetween(startDate As DateTime, endDate As DateTime) As Dictionary(Of DateTime, List(Of NoteRecord))
        Dim result As New Dictionary(Of DateTime, List(Of NoteRecord))()

        Using con As New SqlConnection(My.Settings.remoteDB)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Using cmd As New SqlCommand(
            "SELECT Id, NoteDate, NoteValue, Important FROM Notes WHERE NoteDate BETWEEN @start AND @end ORDER BY NoteDate, Id",
            con)
                cmd.Parameters.Add("@start", SqlDbType.Date).Value = startDate.Date
                cmd.Parameters.Add("@end", SqlDbType.Date).Value = endDate.Date

                Using rdr = cmd.ExecuteReader()
                    While rdr.Read()
                        Dim id = If(IsDBNull(rdr("Id")), 0, Convert.ToInt32(rdr("Id")))
                        Dim dt = If(IsDBNull(rdr("NoteDate")), DateTime.MinValue, Convert.ToDateTime(rdr("NoteDate"))).Date
                        Dim val = If(IsDBNull(rdr("NoteValue")), String.Empty, rdr("NoteValue").ToString())
                        Dim important = If(IsDBNull(rdr("Important")), False, Convert.ToBoolean(rdr("Important")))

                        Dim nr As New NoteRecord With {
                            .Id = id,
                            .NoteDate = dt,
                            .NoteValue = val,
                            .Important = important
                        }

                        If Not result.ContainsKey(dt) Then
                            result(dt) = New List(Of NoteRecord)()
                        End If
                        result(dt).Add(nr)
                    End While
                End Using
            End Using
        End Using

        Return result
    End Function

    ' Updated CellMouseClick to handle sorted notes (important first)
    Private Sub dgvCalendar_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCalendar.CellMouseClick
        ' ignore header clicks
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return

        Dim cell = dgvCalendar.Rows(e.RowIndex).Cells(e.ColumnIndex)
        If cell.Tag Is Nothing Then Return

        Dim dayData As DayCellData = TryCast(cell.Tag, DayCellData)
        If dayData Is Nothing Then Return

        ' Sort notes by important first (same as in painting)
        Dim sortedNotes = dayData.Notes.OrderByDescending(Function(n) n.Important).ThenBy(Function(n) n.Id).ToList()

        ' e.Y is already the Y offset relative to the top-left of the cell — no PointToClient needed
        Dim relativeY As Integer = e.Y

        ' line height using the grid's font
        Dim lineHeight As Integer = TextRenderer.MeasureText("A", dgvCalendar.Font).Height

        ' tolerance so clicking the top is easier
        Dim tolerance As Integer = 4

        ' If clicked near the first line (day number) -> create new note
        If relativeY <= lineHeight + tolerance Then
            Using newDlg As New noteDetails(dayData.Date)
                If newDlg.ShowDialog() = DialogResult.OK Then
                    BuildCalendar(CInt(cmbYear.SelectedItem), cmbMonth.SelectedIndex + 1)
                End If
            End Using
            Return
        End If

        ' Otherwise compute which note line was clicked
        Dim yAfterDayNumber As Integer = relativeY - lineHeight
        If yAfterDayNumber < 0 Then Return

        Dim noteIndex As Integer = CInt(Math.Floor(yAfterDayNumber / lineHeight))

        If sortedNotes IsNot Nothing AndAlso noteIndex >= 0 AndAlso noteIndex < sortedNotes.Count Then
            Dim nr As NoteRecord = sortedNotes(noteIndex)
            Using detailsDlg As New noteDetails(nr.Id)
                If detailsDlg.ShowDialog() = DialogResult.OK Then
                    BuildCalendar(CInt(cmbYear.SelectedItem), cmbMonth.SelectedIndex + 1)
                End If
            End Using
        End If
    End Sub

    ' Load month/year combos and build initial calendar
    Private Sub notesTab_Enter(sender As Object, e As EventArgs) Handles notesTab.Enter
        Dim curY As Integer = DateTime.Today.Year
        Dim curM As Integer = DateTime.Today.Month

        ' --- Month combo ---
        cmbMonth.Items.Clear()
        For m As Integer = 1 To 12
            cmbMonth.Items.Add(New DateTime(2000, m, 1).ToString("MMMM"))
        Next
        cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMonth.SelectedIndex = curM - 1

        ' --- Year combo ---
        cmbYear.Items.Clear()
        For y As Integer = curY - 13 To curY
            cmbYear.Items.Add(y)
        Next
        cmbYear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYear.SelectedItem = curY

        ' --- Remove previous handlers to avoid duplicates ---
        Try : RemoveHandler cmbMonth.SelectedIndexChanged, AddressOf cmbMonth_SelectedIndexChanged : Catch : End Try
        Try : RemoveHandler cmbYear.SelectedIndexChanged, AddressOf cmbYear_SelectedIndexChanged : Catch : End Try

        ' --- Attach change handlers ---
        AddHandler cmbMonth.SelectedIndexChanged, AddressOf cmbMonth_SelectedIndexChanged
        AddHandler cmbYear.SelectedIndexChanged, AddressOf cmbYear_SelectedIndexChanged

        ' --- Initial calendar build ---
        BuildCalendar(CInt(cmbYear.SelectedItem), cmbMonth.SelectedIndex + 1)
    End Sub

    ' Month changed
    Private Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbMonth.SelectedIndex < 0 OrElse cmbYear.SelectedItem Is Nothing Then Return
        BuildCalendar(CInt(cmbYear.SelectedItem), cmbMonth.SelectedIndex + 1)
    End Sub

    ' Year changed
    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbMonth.SelectedIndex < 0 OrElse cmbYear.SelectedItem Is Nothing Then Return
        BuildCalendar(CInt(cmbYear.SelectedItem), cmbMonth.SelectedIndex + 1)
    End Sub

    ' LOAD ORDERS WEBVIEW (connects to the mobile app system) [PREVIEW]
    Private Sub ordersTab_Enter(sender As Object, e As EventArgs) Handles ordersTab.Enter
        Dim bytes() As Byte = Encoding.UTF8.GetBytes(userid.ToString())
        Dim encoded As String = Convert.ToBase64String(bytes)
        WebView23.Source = New System.Uri("https://routico.kwalha.tech/?lang=ar&orgid=cmouY29t&s=" & encoded)
    End Sub

    ' Load drivers into combo box
    Private Sub LoadDrivers()
        Dim con As New SqlConnection(My.Settings.remoteDB)
        If con.State = ConnectionState.Closed Then

            con.Open()
        End If
        Dim cmd As New SqlCommand("SELECT driver FROM driver ORDER BY DRIVER", con)
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        cmbDriver.Items.Clear()
        While rdr.Read()
            Dim drivers As String = rdr("driver").ToString

            cmbDriver.Items.Add(drivers)
        End While
        rdr.Close()

    End Sub

    ' Get trip type based on checkboxes
    Private Function GetTripType() As Integer
        If chkDriver.Checked Then Return 1
        If chkGroundStaff.Checked Then Return 2
        If chkSpecial.Checked Then Return 3
        Return ""
    End Function

    ' create order record
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        ' Reset error label
        Label83.Text = ""

        ' Validate inputs
        If String.IsNullOrWhiteSpace(txtOrderId.Text) Then
            Label83.Text = "الرجاء إدخال رقم الطلب"
            Exit Sub
        End If

        If txtDate.Text = "" Then
            Label83.Text = "الرجاء إدخال التاريخ"
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtBusNo.Text) Then
            Label83.Text = "الرجاء إدخال رقم الباص"
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cmbDriver.Text) Then
            Label83.Text = "الرجاء اختيار السائق"
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtStartKm.Text) Then
            Label83.Text = "الرجاء إدخال بداية العداد"
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtendKm.Text) Then
            Label83.Text = "الرجاء إدخال نهاية العداد"
            Exit Sub
        End If

        If (Val(txtendKm.Text) - Val(txtStartKm.Text)) <= 0 Then
            Label83.Text = "ادخال خاطئ, يرجى التأكد من دقة الكيلومترات"
            Exit Sub
        End If

        Try
            Using cmd As New SqlCommand("
            INSERT INTO sariyah
                ([ORDER ID], [DATE], [BUS], [DRIVER], [START KM], [END KM], [DAILY KM], [MONTHLY KM], [KM], [type])
            VALUES
                (@orderid, @date, @bus, @driver, @startkm, @endkm, @dailykm, @monthlykm, @km, @type)", con)

                cmd.Parameters.AddWithValue("@orderid", txtOrderId.Text)
                cmd.Parameters.AddWithValue("@date", txtDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@bus", txtBusNo.Text)
                cmd.Parameters.AddWithValue("@driver", cmbDriver.Text)
                cmd.Parameters.AddWithValue("@startkm", txtStartKm.Text)
                cmd.Parameters.AddWithValue("@endkm", txtendKm.Text)
                ' Placeholder values for dailykm and monthlykm if not filled
                cmd.Parameters.AddWithValue("@dailykm", 0)
                cmd.Parameters.AddWithValue("@monthlykm", 0)
                cmd.Parameters.AddWithValue("@km", (Val(txtendKm.Text) - Val(txtStartKm.Text)))
                cmd.Parameters.AddWithValue("@type", GetTripType())

                cmd.ExecuteNonQuery()
            End Using
            txtOrderId.Controls.Clear()
            txtDate.Value = DateTime.Now
            txtBusNo.Clear()
            cmbDriver.SelectedIndex = -1
            txtStartKm.Clear()
            txtendKm.Clear()
            txtOrderId.Clear()
            chkDriver.Checked = False
            chkGroundStaff.Checked = False
            chkSpecial.Checked = False
        Catch ex As Exception

        End Try
    End Sub

    ' Update order record
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Reset error label
        Label83.Text = ""

        ' Validate inputs
        If String.IsNullOrWhiteSpace(txtOrderId.Text) Then
            Label83.Text = "الرجاء إدخال رقم الطلب"
            Exit Sub
        End If

        If txtDate.Text = "" Then
            Label83.Text = "الرجاء إدخال التاريخ"
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtBusNo.Text) Then
            Label83.Text = "الرجاء إدخال رقم الباص"
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cmbDriver.Text) Then
            Label83.Text = "الرجاء اختيار السائق"
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtStartKm.Text) Then
            Label83.Text = "الرجاء إدخال بداية العداد"
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtendKm.Text) Then
            Label83.Text = "الرجاء إدخال نهاية العداد"
            Exit Sub
        End If

        If (Val(txtendKm.Text) - Val(txtStartKm.Text)) <= 0 Then
            Label83.Text = "ادخال خاطئ, يرجى التأكد من دقة الكيلومترات"
            Exit Sub
        End If

        Try
            Dim cmd As New SqlCommand("
                UPDATE sariyah SET
                    [DATE]=@date, [BUS]=@bus, [DRIVER]=@driver,
                    [START KM]=@startkm, [END KM]=@endkm,
                    [KM]=@km, [type]=@type
                WHERE [ORDER ID]=@orderid
            ", con)

            cmd.Parameters.AddWithValue("@orderid", txtOrderId.Text)
            cmd.Parameters.AddWithValue("@date", txtDate.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@bus", txtBusNo.Text)
            cmd.Parameters.AddWithValue("@driver", cmbDriver.Text)
            cmd.Parameters.AddWithValue("@startkm", txtStartKm.Text)
            cmd.Parameters.AddWithValue("@endkm", txtendKm.Text)
            cmd.Parameters.AddWithValue("@km", (Val(txtendKm.Text) - Val(txtStartKm.Text)))
            cmd.Parameters.AddWithValue("@type", GetTripType())
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
        btnInsert.Visible = True
        txtOrderId.Controls.Clear()
        btnInsert.Visible = True
        txtDate.Value = DateTime.Now
        txtBusNo.Clear()
        cmbDriver.SelectedIndex = -1
        txtStartKm.Clear()
        txtendKm.Clear()
        chkDriver.Checked = False
        chkGroundStaff.Checked = False
        chkSpecial.Checked = False
    End Sub

    ' Delete order record
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim cmd As New SqlCommand("DELETE FROM sariyah WHERE [ORDER ID]=@orderid", con)
            cmd.Parameters.AddWithValue("@orderid", txtOrderId.Text)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
        btnInsert.Visible = True
        txtOrderId.Controls.Clear()
        btnInsert.Visible = True
        txtDate.Value = DateTime.Now
        txtBusNo.Clear()
        cmbDriver.SelectedIndex = -1
        txtStartKm.Clear()
        txtendKm.Clear()
        chkDriver.Checked = False
        chkGroundStaff.Checked = False
        chkSpecial.Checked = False
    End Sub

    ' Auto-load record when Order ID changes
    Private Sub txtOrderId_TextChanged(sender As Object, e As EventArgs) Handles txtOrderId.TextChanged
        ' guard: skip empty or non-numeric
        If String.IsNullOrWhiteSpace(txtOrderId.Text) Then
            btnInsert.Visible = True
            Exit Sub
        End If

        Dim orderId As String = txtOrderId.Text.Trim()

        Try
            If con.State = ConnectionState.Closed Then con.Open()

            Dim query As String = "SELECT TOP 1 [Order ID], [DATE], [BUS], [DRIVER], [START KM], [END KM], [DAILY KM], [MONTHLY KM], [KM], [type]
                               FROM sariyah WHERE [Order ID] = @orderId"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@orderId", orderId)
                'the checkboxes
                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    If rdr.Read() Then
                        ' populate fields
                        txtOrderId.Text = rdr("Order ID").ToString()
                        txtDate.Text = rdr("DATE").ToString()
                        txtBusNo.Text = rdr("BUS").ToString()
                        cmbDriver.Text = rdr("DRIVER").ToString()
                        txtStartKm.Text = rdr("START KM").ToString()
                        txtendKm.Text = rdr("END KM").ToString()

                        If rdr("type") = 1 Then
                            chkDriver.Checked = True
                            chkGroundStaff.Checked = False
                            chkSpecial.Checked = False
                        End If

                        If rdr("type") = 2 Then
                            chkDriver.Checked = False
                            chkGroundStaff.Checked = True
                            chkSpecial.Checked = False
                        End If

                        If rdr("type") = 3 Then
                            chkDriver.Checked = False
                            chkGroundStaff.Checked = False
                            chkSpecial.Checked = True
                        End If

                        btnInsert.Visible = False

                    Else
                        btnInsert.Visible = True
                        txtDate.Value = DateTime.Now
                        txtBusNo.Clear()
                        cmbDriver.SelectedIndex = -1
                        txtStartKm.Clear()
                        txtendKm.Clear()
                        chkDriver.Checked = False
                        chkGroundStaff.Checked = False
                        chkSpecial.Checked = False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while loading record: " & ex.Message)
        End Try
    End Sub

    ' handle driver checkbox
    Private Sub chkDriver_CheckedChanged(sender As Object, e As EventArgs) Handles chkDriver.CheckedChanged
        If chkDriver.Checked Then
            chkGroundStaff.Checked = False
            chkSpecial.Checked = False
        End If
    End Sub

    ' handle ground staff checkbox
    Private Sub chkGroundStaff_CheckedChanged(sender As Object, e As EventArgs) Handles chkGroundStaff.CheckedChanged
        If chkGroundStaff.Checked Then
            chkDriver.Checked = False
            chkSpecial.Checked = False
        End If
    End Sub

    ' handle special trip checkbox
    Private Sub chkSpecial_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpecial.CheckedChanged
        If chkSpecial.Checked Then
            chkDriver.Checked = False
            chkGroundStaff.Checked = False
        End If
    End Sub

    ' Auto-fill bus details on Enter key
    Private Sub txtBusNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim cmt As New SqlCommand
            Dim STt As String
            Try
                STt = "select drname,Bus from bus where Buss = '" & txtBusNo.Text & "'"
                Dim dk As New SqlDataAdapter(STt, con)
                Dim dm As New System.Data.DataTable
                dk.Fill(dm)
                txtBusNo.Text = dm.Rows(0).Item("Bus")
                txtDate.Focus()
            Catch ex As Exception

            End Try
        End If
    End Sub

    ' handle tree view selection to switch between records and reports
    Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView2.AfterSelect
        Dim key As String = If(String.IsNullOrEmpty(e.Node.Name), e.Node.Text, e.Node.Name)
        If key = "Records" Then
            orderRecords.Visible = True
            KMReports.Visible = False
        ElseIf key = "Report" Then
            orderRecords.Visible = False
            KMReports.Visible = True
        End If
    End Sub

    ' Jump to next field on Enter key
    Private Sub txtOrderId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOrderId.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtBusNo.Focus()
        End If
    End Sub
    ' Jump to next field on Enter key
    Private Sub txtDate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbDriver.Focus()
        End If
    End Sub
    ' Jump to next field on Enter key
    Private Sub cmbDriver_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbDriver.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtStartKm.Focus()
        End If
    End Sub
    ' Jump to next field on Enter key
    Private Sub txtStartKm_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStartKm.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtendKm.Focus()
        End If
    End Sub
    ' Last field - Enter triggers insert
    Private Sub txtendKm_KeyDown(sender As Object, e As KeyEventArgs) Handles txtendKm.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnInsert.PerformClick()
        End If
    End Sub

    ' Search button click handler
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        If con Is Nothing Then
            MessageBox.Show("Database connection not initialized. Call InitializeConnection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If cmbReports.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a report type.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim reportType As String = cmbReports.SelectedItem.ToString().Trim()
        Dim d As Date = dtpFrom.Value.Date
        Dim d1 As Date = dtpto.Value.Date

        Try
            If reportType = "الاخطاء" Then
                Dim sql As String = "SELECT [ORDER ID], BUS, DATE, DRIVER, [START KM], [END KM], KM, [type] " &
                                    "FROM sariyah WHERE DATE BETWEEN @d AND @d1 AND (KM < 0 OR KM = 0 OR KM > 170) ORDER BY KM"
                Dim da As New SqlDataAdapter(sql, con)
                da.SelectCommand.Parameters.AddWithValue("@d", d)
                da.SelectCommand.Parameters.AddWithValue("@d1", d1)
                dm.Clear()
                da.Fill(dm)
                dgv.DataSource = da

            ElseIf reportType = "الكل" OrElse reportType = "الكيلومترات" Then
                If reportType = "الكل" Then
                    Dim sql As String = "SELECT [ORDER ID], BUS, DATE, DRIVER, [START KM], [END KM], KM, [type] " &
                                                        "FROM sariyah WHERE DATE BETWEEN @d AND @d1 ORDER BY DATE"
                    Dim da As New SqlDataAdapter(sql, con)
                    da.SelectCommand.Parameters.AddWithValue("@d", d)
                    da.SelectCommand.Parameters.AddWithValue("@d1", d1)
                    Dim dtLocal As New DataTable()
                    da.Fill(dtLocal)
                    dgv.DataSource = dtLocal
                ElseIf reportType = "الكيلومترات" Then
                    Dim sql As String = "SELECT SUM(KM) AS TotalKM FROM sariyah WHERE DATE BETWEEN @d AND @d1"
                    Dim da As New SqlDataAdapter(sql, con)
                    da.SelectCommand.Parameters.AddWithValue("@d", d)
                    da.SelectCommand.Parameters.AddWithValue("@d1", d1)
                    Dim dtLocal As New DataTable()
                    da.Fill(dtLocal)
                    dgv.DataSource = dtLocal
                End If
            Else
                MessageBox.Show("Invalid credentials.", "Auth Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Query error: " & ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Export button click handler
    Private Sub BtnExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExport.Click
        If dgv Is Nothing OrElse dgv.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx|CSV (comma separated)|*.csv"
            sfd.FileName = "report.xlsx"
            If sfd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Dim path = sfd.FileName
            Dim ext = System.IO.Path.GetExtension(path).ToLowerInvariant()

            If ext = ".csv" Then
                ExportToCsv(path)
                MessageBox.Show("CSV exported to: " & path, "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Try
                    ExportToExcelInterop(path)
                    MessageBox.Show("Excel exported to: " & path, "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Excel export failed: " & ex.Message & vbCrLf & "Falling back to CSV.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Dim alt = System.IO.Path.ChangeExtension(path, ".csv")
                    ExportToCsv(alt)
                    MessageBox.Show("CSV exported to: " & alt, "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End Using
    End Sub

    ' Export to CSV helper
    Private Sub ExportToCsv(ByVal path As String)
        Using sw As New StreamWriter(path, False, System.Text.Encoding.UTF8)
            ' headers
            Dim headers = New List(Of String)()
            For Each col As DataGridViewColumn In dgv.Columns
                headers.Add("""" & col.HeaderText.Replace("""", """""") & """")
            Next
            sw.WriteLine(String.Join(",", headers))

            ' rows
            For Each row As DataGridViewRow In dgv.Rows
                Dim cells = New List(Of String)()
                For Each cell As DataGridViewCell In row.Cells
                    Dim text = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                    cells.Add("""" & text.Replace("""", """""") & """")
                Next
                sw.WriteLine(String.Join(",", cells))
            Next
            sw.Flush()
        End Using
    End Sub

    ' Export using Excel Interop
    Private Sub ExportToExcelInterop(ByVal path As String)
        Dim xlApp As Excel.Application = Nothing
        Dim xlWB As Excel.Workbook = Nothing
        Dim xlWS As Excel.Worksheet = Nothing

        Try
            xlApp = New Excel.Application()
            xlWB = xlApp.Workbooks.Add(Type.Missing)
            xlWS = CType(xlWB.Worksheets(1), Excel.Worksheet)

            ' headers
            For c As Integer = 0 To dgv.Columns.Count - 1
                xlWS.Cells(1, c + 1) = dgv.Columns(c).HeaderText
            Next

            ' data
            For r As Integer = 0 To dgv.Rows.Count - 1
                For c As Integer = 0 To dgv.Columns.Count - 1
                    Dim cellVal = If(dgv.Rows(r).Cells(c).Value, "")
                    xlWS.Cells(r + 2, c + 1) = cellVal
                Next
            Next

            xlWB.SaveAs(path)
            xlWB.Close()
            xlApp.Quit()
        Finally
            If xlWS IsNot Nothing Then Marshal.ReleaseComObject(xlWS)
            If xlWB IsNot Nothing Then Marshal.ReleaseComObject(xlWB)

            If xlApp IsNot Nothing Then Marshal.ReleaseComObject(xlApp)
            xlWS = Nothing
            xlWB = Nothing
            xlApp = Nothing
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

    ' Clean up on form close
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        Try
            If con IsNot Nothing Then
                If con.State = ConnectionState.Open Then con.Close()
                con.Dispose()
                con = Nothing
            End If
        Catch
        End Try
    End Sub

    ' KM Reporting Tab
    Private Sub kmRreportTab_Enter(sender As Object, e As EventArgs) Handles kmRreportTab.Enter
        LoadDrivers()
        cmbReports.DropDownStyle = ComboBoxStyle.DropDownList

        cmbReports.Items.Clear()
        cmbReports.Items.Add("الاخطاء")
        If KMspecialReports Then
            cmbReports.Items.Add("الكل")
            cmbReports.Items.Add("الكيلومترات")
        End If

        ' select first item by default
        If cmbReports.Items.Count > 0 Then
            cmbReports.SelectedIndex = 0
        End If
    End Sub

    ' Try parse input date string with multiple formats and return formatted output
    Private Function TryParseAndFormatDate(input As String, outputFormat As String, ByRef formatted As String) As Boolean
        formatted = String.Empty
        If String.IsNullOrWhiteSpace(input) Then
            Return False
        End If

        Dim formats() As String = {"dd/MM/yyyy", "d/M/yyyy", "dd/M/yyyy", "d/MM/yyyy", "yyyy-MM-dd", "yyyy/MM/dd"}
        Dim ci As CultureInfo = CultureInfo.GetCultureInfo("en-GB")
        Dim dt As DateTime

        ' Try exact formats first
        If DateTime.TryParseExact(input.Trim(), formats, ci, DateTimeStyles.None, dt) Then
            formatted = dt.ToString(outputFormat)
            Return True
        End If

        ' Fallback: general parse using en-GB culture
        If DateTime.TryParse(input.Trim(), ci, DateTimeStyles.None, dt) Then
            formatted = dt.ToString(outputFormat)
            Return True
        End If

        Return False
    End Function

    ' sql query builder based on report type and inputs
    Private Function BuildSqlQuery() As String
        Dim reportType As String = If(cmbreportType.SelectedItem, String.Empty).ToString().Trim()
        Dim keyword As String = If(txtKeyword.Text, String.Empty).Trim()
        Dim fromText As String = If(txtFromDate.Text, String.Empty).Trim()
        Dim toText As String = If(txtToDate.Text, String.Empty).Trim()
        Dim dateOnlyText As String = If(txtDateOnly.Text, String.Empty).Trim()

        ' FDate (display format dd/MM/yyyy) & Datee (SQL BETWEEN format yyyy-MM-dd)
        Dim fromFDate As String = String.Empty
        Dim toFDate As String = String.Empty
        Dim fromDatee As String = String.Empty
        Dim toDatee As String = String.Empty

        Dim parsedFromFDate As Boolean = TryParseAndFormatDate(fromText, "dd/MM/yyyy", fromFDate)
        Dim parsedToFDate As Boolean = TryParseAndFormatDate(toText, "dd/MM/yyyy", toFDate)
        Dim parsedFromDatee As Boolean = TryParseAndFormatDate(fromText, "yyyy-MM-dd", fromDatee)
        Dim parsedToDatee As Boolean = TryParseAndFormatDate(toText, "yyyy-MM-dd", toDatee)

        Dim query As String = String.Empty

        Select Case reportType
            Case "No Show"
                If IsNumeric(keyword) Then
                    query = "SELECT FDate,PickupTime,Flight,CID,CEnName,CMobile,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,DMnote " &
                        "FROM FullRoster WHERE (GPSNote = N'CANCEL ON CALL' OR GPSNote = N'NO SHOW') AND CID = " & Convert.ToInt32(keyword) & " ORDER BY RID"
                ElseIf parsedFromDatee AndAlso parsedToDatee Then
                    query = "BEGIN TRY SELECT FDate,PickupTime,Flight,CID,CEnName,CMobile,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,DMnote " &
                        "FROM FullRoster WHERE (GPSNote LIKE '%NO SHOW%' OR GPSNote LIKE '%CANCEL ON CALL%') AND Datee BETWEEN '" & fromDatee & "' AND '" & toDatee & "' END TRY BEGIN CATCH PRINT ERROR_MESSAGE(); END CATCH"
                ElseIf keyword.Contains("/") AndAlso TryParseAndFormatDate(keyword, "dd/MM/yyyy", fromFDate) Then
                    query = "SELECT FDate,PickupTime,Flight,CID,CEnName,CMobile,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,DMnote " &
                        "FROM FullRoster WHERE (GPSNote LIKE '%NO SHOW%' OR GPSNote LIKE '%CANCEL ON CALL%') AND FDate = '" & fromFDate & "' ORDER BY FDate, PickupTime"
                End If

            Case "Delay"
                If IsNumeric(keyword) Then
                    query = "SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                        "FROM FullRoster WHERE late <> N'00:00:00' AND CID = " & Convert.ToInt32(keyword) & " ORDER BY FDate, PickupTime"
                ElseIf parsedFromDatee AndAlso parsedToDatee Then
                    query = "BEGIN TRY SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                        "FROM FullRoster WHERE late <> N'00:00:00' AND Datee BETWEEN '" & fromDatee & "' AND '" & toDatee & "' END TRY BEGIN CATCH PRINT ERROR_MESSAGE(); END CATCH"
                ElseIf keyword.Contains("/") AndAlso TryParseAndFormatDate(keyword, "dd/MM/yyyy", fromFDate) Then
                    query = "SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                        "FROM FullRoster WHERE late <> N'00:00:00' AND FDate = '" & fromFDate & "' ORDER BY FDate, PickupTime"
                End If

            Case "Crew ID"
                If Not String.IsNullOrWhiteSpace(keyword) Then
                    If IsNumeric(keyword) Then
                        If parsedFromDatee AndAlso parsedToDatee Then
                            query = "BEGIN TRY SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                                "FROM FullRoster WHERE CID = " & Convert.ToInt32(keyword) & " AND Datee BETWEEN '" & fromDatee & "' AND '" & toDatee & "' ORDER BY FDate DESC END TRY BEGIN CATCH PRINT ERROR_MESSAGE(); END CATCH"
                        Else
                            query = "SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote,DAtee " &
                                "FROM FullRoster WHERE CID = " & Convert.ToInt32(keyword) & " ORDER BY DAtee DESC"
                        End If
                    Else
                        Dim escName As String = keyword.Replace("'", "''")
                        If parsedFromDatee AndAlso parsedToDatee Then
                            query = "BEGIN TRY SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                                "FROM FullRoster WHERE CArName = N'" & escName & "' AND Datee BETWEEN '" & fromDatee & "' AND '" & toDatee & "' END TRY BEGIN CATCH PRINT ERROR_MESSAGE(); END CATCH"
                        Else
                            query = "SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                                "FROM FullRoster WHERE CArName = N'" & escName & "' ORDER BY FDate, PickupTime"
                        End If
                    End If
                End If

            Case "Date Only"
                If dateOnlyText <> "dd/MM/yyyy" AndAlso TryParseAndFormatDate(dateOnlyText, "dd/MM/yyyy", fromFDate) Then
                    query = "SELECT FDate,PickupTime,Flight,CID,CEnName,CArName,CAdd,CMobile,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,DMnote " &
                        "FROM FullRoster WHERE FDate = '" & fromFDate & "' ORDER BY FDate, PickupTime"
                End If

            Case "GPS Officer"
                If Not String.IsNullOrEmpty(keyword) AndAlso IsNumeric(keyword) Then
                    If parsedFromDatee AndAlso parsedToDatee Then
                        query = "BEGIN TRY SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                            "FROM FullRoster WHERE GPSOfficer = " & Convert.ToInt32(keyword) & " AND Datee BETWEEN '" & fromDatee & "' AND '" & toDatee & "' END TRY BEGIN CATCH PRINT ERROR_MESSAGE(); END CATCH"
                    Else
                        query = "SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                            "FROM FullRoster WHERE GPSOfficer = " & Convert.ToInt32(keyword) & " ORDER BY FDate, PickupTime"
                    End If
                End If

            Case "By Date"
                If parsedFromDatee AndAlso parsedToDatee Then
                    query = "BEGIN TRY SELECT * FROM FullRoster WHERE Datee BETWEEN '" & fromDatee & "' AND '" & toDatee & "' ORDER BY FDate END TRY BEGIN CATCH PRINT ERROR_MESSAGE(); END CATCH"
                End If

            Case "Duty Manager"
                If Not String.IsNullOrEmpty(keyword) AndAlso IsNumeric(keyword) Then
                    If parsedFromDatee AndAlso parsedToDatee Then
                        query = "BEGIN TRY SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                            "FROM FullRoster WHERE DM = " & Convert.ToInt32(keyword) & " AND Datee BETWEEN '" & fromDatee & "' AND '" & toDatee & "' END TRY BEGIN CATCH PRINT ERROR_MESSAGE(); END CATCH"
                    Else
                        query = "SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                            "FROM FullRoster WHERE DM = " & Convert.ToInt32(keyword) & " ORDER BY FDate, PickupTime"
                    End If
                End If

            Case "Transportation Officer"
                If Not String.IsNullOrEmpty(keyword) AndAlso IsNumeric(keyword) Then
                    If parsedFromDatee AndAlso parsedToDatee Then
                        query = "BEGIN TRY SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                            "FROM FullRoster WHERE TransOfficer = " & Convert.ToInt32(keyword) & " AND Datee BETWEEN '" & fromDatee & "' AND '" & toDatee & "' END TRY BEGIN CATCH PRINT ERROR_MESSAGE(); END CATCH"
                    Else
                        query = "SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                            "FROM FullRoster WHERE TransOfficer = " & Convert.ToInt32(keyword) & " ORDER BY FDate, PickupTime"
                    End If
                End If

            Case "Address"
                If Not String.IsNullOrEmpty(keyword) Then
                    Dim escAdd As String = keyword.Replace("'", "''")
                    query = "SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,DMnote " &
                        "FROM FullRoster WHERE CAdd = N'" & escAdd & "'"
                End If

            Case "Area"
                Dim areaCode As Integer = 1
                If cmbArea.SelectedItem IsNot Nothing AndAlso cmbArea.SelectedItem.ToString().Trim() = "شرقي" Then
                    areaCode = 1
                Else
                    areaCode = 2
                End If

                If parsedFromDatee AndAlso parsedToDatee Then
                    query = "BEGIN TRY SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                        "FROM FullRoster WHERE Area = " & areaCode & " AND Datee BETWEEN '" & fromDatee & "' AND '" & toDatee & "' END TRY BEGIN CATCH PRINT ERROR_MESSAGE(); END CATCH"
                Else
                    query = "SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                        "FROM FullRoster WHERE Area = " & areaCode & " ORDER BY FDate, PickupTime"
                End If

            Case "Bus #"
                If Not String.IsNullOrEmpty(keyword) Then
                    Dim escBus As String = keyword.Replace("'", "''")
                    If parsedFromDatee AndAlso parsedToDatee AndAlso Not fromText.Contains("DD") Then
                        query = "BEGIN TRY SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                            "FROM FullRoster WHERE Bus = N'" & escBus & "' AND Datee BETWEEN '" & fromDatee & "' AND '" & toDatee & "' END TRY BEGIN CATCH PRINT ERROR_MESSAGE(); END CATCH"
                    Else
                        query = "SELECT FDate,PickupTime,Flight,CID,CArName,CAdd,GPSCallTime,Bus,Driver,GPSNote,BrfTime,ArrTime,late,DMnote " &
                            "FROM FullRoster WHERE Bus = N'" & escBus & "' ORDER BY FDate, PickupTime"
                    End If
                End If

            Case "SINGLE BUS", "BUS"
                If Not String.IsNullOrEmpty(keyword) Then
                    Dim escBusNumber As String = keyword.Replace("'", "''")
                    query = "SELECT * FROM Bus WHERE BusNumber = N'" & escBusNumber & "'"
                End If
            Case Else
                query = String.Empty
        End Select

        If String.IsNullOrWhiteSpace(query) Then
            Return String.Empty
        End If

        ' Always ensure commands run in GPS DB
        Return "USE [GPS]; " & query
    End Function

    ' Load data into reports DataGridView based on SQL query
    Private Sub LoadDataToGrid(query As String)
        If String.IsNullOrWhiteSpace(query) Then
            Return
        End If

        Try
            Dim table As New DataTable()
            Dim sqlq As String = "USE [GPS]; " & query
            Using da As New SqlDataAdapter(sqlq, con)
                If con Is Nothing Then
                    con = New SqlConnection(My.Settings.remoteDB)
                End If
                If con.State = ConnectionState.Closed Then con.Open()
                da.Fill(table)
            End Using

            dgvResults.DataSource = table

            ' Ensure UI updates
            Try
                dgvResults.Refresh()
                dgvResults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            Catch
            End Try
            ' Update UI hints (guarded in case controls are not present)
            Try
                lblRecordCount.Text = "Found (" & table.Rows.Count.ToString() & ") records."
                lblRecordCount.Visible = True
                btnExportExcel.Visible = (table.Rows.Count > 0)
            Catch
                ' ignore missing UI elements
            End Try
        Catch ex As Exception
            ErrorLog("LoadDataToGrid exception: " & ex.Message & " SQL: " & query)
        End Try
    End Sub

    ' Map role name to permission level
    Private Function GetUserRoleValue(roleName As String) As Integer
        Select Case roleName
            Case "ADMINIStrATOR" : Return 3
            Case "GPS" : Return 2
            Case "DM" : Return 1
            Case "Officer" : Return 4
            Case "GS" : Return 5
            Case Else : Return 0
        End Select
    End Function

    ' Map area name to code
    Private Function GetAreaCode(areaName As String) As Integer
        Select Case areaName
            Case "Eastern Area (الشرقي)" : Return 1
            Case "Western Area (الغربي)" : Return 2
            Case Else : Return 0
        End Select
    End Function

    ' Handle Load button click to generate report based on selected type and criteria
    Private Sub btnLoad_Click(sender As Object, e As EventArgs)
        Dim q = BuildSqlQuery()
        LoadDataToGrid(q)
    End Sub

    ' Handle report type selection changes to show/hide relevant input controls
    Private Sub cmbReportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbreportType.SelectedIndexChanged
        Dim selectedType = cmbreportType.SelectedItem.ToString()

        ' Show/hide date range controls
        Select Case selectedType
            Case "No Show", "By Date", "Delay", "Crew ID", "Area", "Bus #",
                 "Transportation Officer", "Duty Manager", "GPS Officer"

                lblFromDate.Visible = True
                lbltoDate.Visible = True
                txtFromDate.Visible = True
                txtToDate.Visible = True
                txtFromDate.Text = ""
                txtToDate.Text = ""

            Case Else
                lblFromDate.Visible = False
                lbltoDate.Visible = False
                txtFromDate.Visible = False
                txtToDate.Visible = False
        End Select

        ' Show/hide area dropdown
        If selectedType = "Area" Then
            lblArea.Visible = True
            cmbArea.Visible = True
            txtKeyword.Visible = False
        Else
            lblArea.Visible = False
            cmbArea.Visible = False
            txtKeyword.Visible = True
        End If

        ' Show/hide date only control
        If selectedType = "Date Only" Then
            lblDateOnly.Visible = True
            txtDateOnly.Visible = True
        Else
            lblDateOnly.Visible = False
            txtDateOnly.Visible = False
        End If

        ' Show/hide keyword input based on report type
        Select Case selectedType
            Case "No Show", "Delay", "Crew ID", "Bus #", "Transportation Officer",
                 "Duty Manager", "GPS Officer", "Address"

                lblKeyword.Visible = True
                txtKeyword.Visible = True
                txtKeyword.Text = ""

            Case Else
                lblKeyword.Visible = False
                txtKeyword.Visible = False
        End Select

        ' Enable/disable generate button based on selection
        btnLoad.Enabled = (selectedType <> "Please select")

        ' Clear previous results when changing report type
        dgvResults.DataSource = Nothing
        lblRecordCount.Visible = False
        btnExportExcel.Visible = False
    End Sub

    ' Initialize the report type dropdown based on user permission level
    Private Sub InitializeReportTypes()
        cmbreportType.Items.Clear()
        cmbreportType.Items.AddRange({
            "Please select",
            "No Show",
            "By Date",
            "Delay",
            "Crew ID"
        })

        ' Group all options for permission levels 2, 3, 4, 6
        If {2, 3, 4, 6}.Contains(userper) Then
            cmbreportType.Items.AddRange({
                "Area",
                "Bus #",
                "Transportation Officer",
                "Duty Manager",
                "GPS Officer",
                "Date Only",
                "Address"
            })
        End If
        cmbreportType.SelectedIndex = 0

        ' area dropdown
        cmbArea.Items.Add("شرقي") ' Eastern
        cmbArea.Items.Add("غربي") ' Western
        cmbArea.SelectedIndex = 0
    End Sub

    ' Initialize Report form and controls
    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeReportTypes()
        ' Set initial visibility
        lblFromDate.Visible = False
        lbltoDate.Visible = False
        txtFromDate.Visible = False
        txtToDate.Visible = False
        lblArea.Visible = False
        cmbArea.Visible = False
        lblDateOnly.Visible = False
        txtDateOnly.Visible = False
        lblKeyword.Visible = False
        txtKeyword.Visible = False
        lblRecordCount.Visible = False
        btnExportExcel.Visible = False
    End Sub

    ' fire Load data function based on selected report type and criteria
    Private Sub btnLoad_Click_1(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim q = BuildSqlQuery()
        LoadDataToGrid(q)
    End Sub

    ' Export data in dgvResults to CSV or Excel
    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If dgvResults Is Nothing OrElse dgvResults.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx|CSV (comma separated)|*.csv"
            sfd.FileName = "report.xlsx"
            If sfd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Dim path = sfd.FileName
            Dim ext = System.IO.Path.GetExtension(path).ToLowerInvariant()

            If ext = ".csv" Then
                ExportToCsv(path)
                MessageBox.Show("CSV exported to: " & path, "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Try
                    Dim xlApp As Excel.Application = Nothing
                    Dim xlWB As Excel.Workbook = Nothing
                    Dim xlWS As Excel.Worksheet = Nothing

                    Try
                        xlApp = New Excel.Application()
                        xlWB = xlApp.Workbooks.Add(Type.Missing)
                        xlWS = CType(xlWB.Worksheets(1), Excel.Worksheet)

                        ' headers
                        For c As Integer = 0 To dgvResults.Columns.Count - 1
                            xlWS.Cells(1, c + 1) = dgvResults.Columns(c).HeaderText
                        Next

                        ' data
                        For r As Integer = 0 To dgvResults.Rows.Count - 1
                            For c As Integer = 0 To dgvResults.Columns.Count - 1
                                Dim cellVal = If(dgvResults.Rows(r).Cells(c).Value, "")
                                xlWS.Cells(r + 2, c + 1) = cellVal
                            Next
                        Next

                        xlWB.SaveAs(path)
                        xlWB.Close()
                        xlApp.Quit()
                    Finally
                        If xlWS IsNot Nothing Then Marshal.ReleaseComObject(xlWS)
                        If xlWB IsNot Nothing Then Marshal.ReleaseComObject(xlWB)

                        If xlApp IsNot Nothing Then Marshal.ReleaseComObject(xlApp)
                        xlWS = Nothing
                        xlWB = Nothing
                        xlApp = Nothing
                        GC.Collect()
                        GC.WaitForPendingFinalizers()
                    End Try
                    MessageBox.Show("Excel exported to: " & path, "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception

                End Try
            End If
        End Using
    End Sub

    ' open users management dialog
    Private Sub UsersManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersManagementToolStripMenuItem.Click
        usersControl.Show()
    End Sub
End Class