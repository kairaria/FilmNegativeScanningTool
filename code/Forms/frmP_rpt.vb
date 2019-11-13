Imports MySql.Data.MySqlClient
'Imports JabDLL

Public Class frmP_rpt
    Private Sub frmNMGPrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmHome
        Me.Text = "Productivity Report"
    End Sub


    Private Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Label5.Visible = True
            Label5.Text = "ON"
            Label5.BackColor = Color.DarkGreen
            Label5.Refresh()
        ElseIf RadioButton3.Checked = False Then
            Label5.Visible = True
            Label5.Text = "OFF"
            Label5.BackColor = Color.Red
            Label5.Refresh()
        End If
    End Sub
    Public Function SelectRows(ByVal dataSet As DataSet, ByVal connection As String, ByVal query As String) As DataSet

        Dim date1 As String = Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss")
        Dim date2 As String = Format(DateTimePicker2.Value, "yyyy-MM-dd HH:mm:ss")
        Dim conn As New MySqlConnection(connection)
        Dim adapter As New MySqlDataAdapter()
        adapter.SelectCommand = New MySqlCommand(query, conn)
        adapter.Fill(dataSet)
        Return dataSet
    End Function
    Private isExecuting As Boolean
    Private Sub Form_FormClosing(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.FormClosingEventArgs) _
        Handles Me.FormClosing
        If isExecuting Then
            MessageBox.Show(Me, "Cannot close the form until " & _
                "the pending asynchronous command has completed. Please wait...")
            e.Cancel = True
        End If
    End Sub
    Private Sub DisplayStatus(ByVal Text As String)
        Me.Label6.Text = Text
    End Sub

    Private Sub DisplayResults(ByVal Text As String)
        Me.Label6.Text = Text
        DisplayStatus("Ready")
    End Sub
    Private Delegate Sub DisplayInfoDelegate(ByVal Text As String)
    Private Sub HandleCallback(ByVal result As IAsyncResult)
        Try
            ' Retrieve the original command object, passed 
            ' to this procedure in the AsyncState property 
            ' of the IAsyncResult parameter. 
            Dim command As MySqlCommand = CType(result.AsyncState, MySqlCommand)
            Dim rowCount As Integer = command.EndExecuteNonQuery(result)
            Dim rowText As String = " rows affected."
            If rowCount = 1 Then
                rowText = " row affected."
            End If
            rowText = rowCount & rowText

            ' You may not interact with the form and its contents 
            ' from a different thread, and this callback procedure 
            ' is all but guaranteed to be running from a different thread 
            ' than the form. Therefore you cannot simply call code that  
            ' displays the results, like this: 
            ' DisplayResults(rowText) 

            ' Instead, you must call the procedure from the form's thread. 
            ' One simple way to accomplish this is to call the Invoke 
            ' method of the form, which calls the delegate you supply 
            ' from the form's thread.  
            Dim del As New DisplayInfoDelegate(AddressOf DisplayResults)
            Me.Invoke(del, rowText)

        Catch ex As Exception
            ' Because you are now running code in a separate thread,  
            ' if you do not handle the exception here, none of your other 
            ' code catches the exception. Because none of your code 
            ' is on the call stack in this thread, there is nothing 
            ' higher up the stack to catch the exception if you do not  
            ' handle it here. You can either log the exception or  
            ' invoke a delegate (as in the non-error case in this  
            ' example) to display the error on the form. In no case 
            ' can you simply display the error without executing a delegate 
            ' as in the Try block here.  

            ' You can create the delegate instance as you  
            ' invoke it, like this: 
            Me.Invoke(New DisplayInfoDelegate(AddressOf DisplayStatus), _
                String.Format("Ready(last error: {0}", ex.Message))
        Finally
            isExecuting = False
            If connection IsNot Nothing Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim date1 As String = Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss")
        Dim date2 As String = Format(DateTimePicker2.Value, "yyyy-MM-dd HH:mm:ss")


        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView2.DataSource = Nothing
        DataGridView2.Rows.Clear()
        DisplayStatus("Executing...")
        Label6.Refresh()

        If isExecuting = True Then
            MessageBox.Show(Me,
               "Already executing. Please wait until the current Operation has Completed ")
        Else
            If RadioButton1.Checked = True Then
                Try
                    'DisplayResults("")
                    'DisplayStatus("Connecting...")

                    Dim query1 As String = "SELECT clerk as `Operator`, count(distinct `recID`) as `Images Scanned` FROM nmg_scan where saa_ngapi between '" & date1 & "' and '" & date2 & "' group by clerk ORDER BY Operator;"

                    Dim da1 As New MySqlDataAdapter(query1, connection)
                    da1.GetFillParameters()
                    Dim ds1 As New DataSet()
                    If da1.Fill(ds1) Then
                        DataGridView1.DataSource = ds1.Tables(0)
                    End If
                    connection.Close()
                    connection.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connection.Close()
                    connection.Dispose()
                End Try

                'Try
                DisplayResults("")
                DisplayStatus("Connecting...")
                Label6.Refresh()

                Dim query2 As String = "Drop TABLE if exists  nmgprod_t;create table nmgprod_t ( PRIMARY KEY (id),KEY(`recid`),KEY(`clerk`),key(`saa_ngapi`)) engine=InnoDB select `number`() AS `id`, r.`recid`, r.clerk, r.saa_ngapi from nmg_scan r where saa_ngapi between '" & date1 & "' and '" & date2 & "'  order by clerk,saa_ngapi;"
                Dim query4 As String = "select * from nmgresult_t;"
                Dim query3 As String = "Drop TABLE if exists nmgresult_t; create table nmgresult_t	select DMO,count(dmo)+1 `Image scans`,sum(active)/3600 `Active hours`,(count(dmo)+1)/(sum(active)/3600) `Scans per hour`,sum(idle)/3600 `Idle hrs`, (sum(idle)/(sum(active)+sum(idle)))*100 `% Idle hours`,(sum(idle)+sum(active))/3600 `Total hours` from (select dmo,date(t1) siku,if(secs<300,secs,0) active, case when secs>=300 and secs<3600 then secs else 0 end as idle,secs from (Select q.id,q.clerk DMO,unix_timestamp(q.saa_ngapi)-unix_timestamp(p.saa_ngapi) secs,p.saa_ngapi t1,q.saa_ngapi t2 from nmgprod_t q join nmgprod_t p on q.id=p.id+1 and q.clerk=p.clerk) g) d group by dmo; select * from nmgresult_t;"

                Dim command, command2, command3 As MySqlCommand

                command = New MySqlCommand(query2, connection)
                command2 = New MySqlCommand(query3, connection)
                command3 = New MySqlCommand("SET Global connect_timeout = 999999;SET Global wait_timeout = 999999;SET Global interactive_timeout = 999999;", connection)
                connection.Open()
                Dim dbread As MySqlDataReader
                dbread = command3.ExecuteReader()
                dbread.Close()
                dbread = command.ExecuteReader()
                dbread.Close()
                dbread = command2.ExecuteReader()
                dbread.Close()
                command.ExecuteNonQuery()
                Label6.Refresh()
                DisplayStatus("Executing...")
                Label6.Refresh()
                isExecuting = True
                Dim da2 As New MySqlDataAdapter(query4, connection)
                'da2.GetFillParameters()
                Dim ds2 As New DataSet()
                If da2.Fill(ds2) Then
                    DataGridView2.DataSource = ds2.Tables(0)
                End If
                connection.Close()
                connection.Dispose()
                isExecuting = False
                ' Dim callback As New AsyncCallback(AddressOf HandleCallback)
                'command.BeginExecuteNonQuery(callback, command)
                'Catch ex As Exception
                isExecuting = False
                'DisplayStatus(String.Format("Ready (last error: {0})", ex.Message))
                If connection IsNot Nothing Then
                    connection.Close()
                End If
                'MsgBox(ex.Message)
                connection.Close()
                connection.Dispose()
                'End Try
                DisplayStatus("Complete")
                Label6.Refresh()
            ElseIf RadioButton2.Checked = True Then
                Try
                    Dim query80 As String = "SELECT clerk as `Operator`, count(distinct recid) as `Records deleted` FROM nmg_scan_del where saa_ngapi between '" & date1 & "' and '" & date2 & "' group by clerk ORDER BY Operator"
                    Dim da80 As New MySqlDataAdapter(query80, connection)
                    da80.GetFillParameters()
                    Dim ds80 As New DataSet()
                    If da80.Fill(ds80) Then
                        DataGridView1.DataSource = ds80.Tables(0)
                    End If
                    connection.Close()
                    connection.Dispose()
                    'isExecuting = False
                Catch ex As Exception
                    MsgBox(ex.Message)
                    connection.Close()
                    connection.Dispose()
                End Try

            End If

        End If
        DisplayStatus("Complete")
        Label6.Refresh()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class