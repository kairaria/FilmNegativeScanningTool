Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmQA
    Private query, date1, date2, imgname, destfilepath As String

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmHome
        DateTimePicker2.Value = DateTime.Now
    End Sub
    Private Sub loadcbo()
        date1 = Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss")
        date2 = Format(DateTimePicker2.Value, "yyyy-MM-dd HH:mm:ss")
        Try
            query = "Select Distinct(clerk) from nmg_scan where saa_ngapi between '" & date1 & "' and '" & date2 & "' order by clerk ASC"
            Dim da As New MySqlDataAdapter(query, connection)

            da.GetFillParameters()
            Dim ds As New DataSet()
            da.Fill(ds)
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.ValueMember = "clerk"
            ComboBox1.DisplayMember = "clerk"

            ds.Dispose()
            da.Dispose()
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            connection.Close()
        End Try
    End Sub
    Private Sub load_list()
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        date1 = Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss")
        date2 = Format(DateTimePicker2.Value, "yyyy-MM-dd HH:mm:ss")
        query = "Select filename from nmg_scan where (saa_ngapi between '" & date1 & "' and '" & date2 & "') AND (clerk like '" & Trim(ComboBox1.Text) & "') order by filename ASC"
        Try
            Dim da As New MySqlDataAdapter(query, connection)

            da.GetFillParameters()
            Dim ds As New DataSet

            If da.Fill(ds) Then
                DataGridView1.DataSource = ds.Tables(0)
                DataGridView1.Focus()
            End If
            ds.Dispose()
            da.Dispose()
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            connection.Close()
        End Try

    End Sub
    Private Sub load_img()
        Try
            If IsNothing(PictureBox1.Image) Then
                PictureBox1.Image = Nothing
            Else
                PictureBox1.Image.Dispose()
                PictureBox1.Image = Nothing
            End If
            ImgFilePath = DataGridView1.CurrentRow.Cells(0).Value
            Dim bitImg As New Bitmap(ImgFilePath)
            PictureBox1.Image = bitImg
        Catch ex As Exception
            MsgBox(ex.Message, , "Image to be rescanned")
        End Try

    End Sub



    Private Sub search()
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        date1 = Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss")
        date2 = Format(DateTimePicker2.Value, "yyyy-MM-dd HH:mm:ss")
        query = "Select filename from nmg_scan where clerk like '" & Trim(ComboBox1.Text) & "' AND filename like '" & "%" & Trim(TextBox1.Text) & "%" & "' AND saa_ngapi between '" & date1 & "' and '" & date2 & "'  order by filename ASC"
        Try
            Dim da As New MySqlDataAdapter(query, connection)

            da.GetFillParameters()
            Dim ds As New DataSet

            If da.Fill(ds) Then
                DataGridView1.DataSource = ds.Tables(0)
                DataGridView1.Focus()
            End If
            ds.Dispose()
            da.Dispose()
            connection.Close()

            'ImgFilePath = "\\isako\Client_Data\Clark County\Phase II\" & Trim(ComboBox1.Text) & ".pdf"
            'WebBrowser1.Navigate(ImgFilePath)
        Catch ex As Exception
            MsgBox(ex.Message)
            connection.Close()
        End Try
        'For i As Integer = 0 To DataGridView1.ColumnCount - 1
        'DataGridView1.Columns(0).Visible = False
        'Next
    End Sub
    Private Sub DeleteImg()
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            Try
                'If MsgBox("Do you want to delete all the records for the File " & FileName & " in batch " & Batch & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                UpdateRecord("Insert into nmg_scan_del(clerk,filename) VALUES('" & GetUserName() & "','" & Replace(row.Cells(0).Value, "\", "\\") & "'); Delete from NMG_scan WHERE filename like '" & row.Cells(0).Value & "'; ")
                'updateRecord("Update  Set clerk = '" & GetUserName() & "',box = Trim(' " & TextBox1.Text.ToLower & " '),filename = '" & fileName & "' WHERE box like '" & Trim(TextBox1.Text.ToLower) & "' AND filename like '" & fileName & "'")

                'End If
                Dim imgname As String = row.Cells(0).Value
                destfilepath = imgname
                If File.Exists(destfilepath) Then
                    File.Delete(destfilepath)
                End If

                imgname = imgname.Replace(".jpeg", ".tif")
                imgname = imgname.Replace("JPEGs", "\TIFFs\")
                destfilepath = imgname

                If File.Exists(destfilepath) Then
                    File.Delete(destfilepath)
                End If

                MsgBox("Image # " & row.Cells(0).Value & " has been deleted.", MsgBoxStyle.Information)
                connection.Close()
                'load_list()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
                connection.Close()
            End Try
        Next
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        loadcbo()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        loadcbo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        load_list()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        search()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeleteImg()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RotateImg()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        InvertImg()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As EventArgs) Handles DataGridView1.CellContentClick
        load_img()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        load_img()
    End Sub


    Private Sub RotateImg()
        Dim Path As String = DataGridView1.CurrentRow.Cells(0).Value
        Dim bitmapImg As New Bitmap(Path)
        bitmapImg.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox1.Image = bitmapImg
        If MsgBox("Save file?", MsgBoxStyle.YesNo, "Save New file") = MsgBoxResult.Yes Then
            Dim tmpPath = Replace(Path, ".jpeg", "_tmp.jpeg")
            Dim tiffPath = Replace(Replace(Path, "\JPEGs\", "\TIFFs\"), ".jpeg", ".tif")
            bitmapImg.RotateFlip(RotateFlipType.Rotate90FlipNone)
            bitmapImg.Save(tmpPath)
            bitmapImg.Dispose()
            bitmapImg = Nothing
            File.Delete(Path)
            File.Delete(tiffPath)
            bitmapImg = Bitmap.FromFile(tmpPath)
            bitmapImg.RotateFlip(RotateFlipType.Rotate270FlipNone)
            bitmapImg.Save(Path)
            bitmapImg.Save(tiffPath)
            File.Delete(tmpPath)
        End If
    End Sub
    Private Sub InvertImg()
        Dim Path As String = DataGridView1.CurrentRow.Cells(0).Value
        Dim bitmapImg As New Bitmap(Path)
        bitmapImg = Invert(bitmapImg, False)
        PictureBox1.Image = bitmapImg
        If MsgBox("Save file?", MsgBoxStyle.YesNo, "Save New file") = MsgBoxResult.Yes Then
            Dim tmpPath = Replace(Path, ".jpeg", "_tmp.jpeg")
            Dim tiffPath = Replace(Replace(Path, "\JPEGs\", "\TIFFs\"), ".jpeg", ".tif")
            bitmapImg.RotateFlip(RotateFlipType.Rotate90FlipNone)
            bitmapImg.Save(tmpPath)
            bitmapImg.Dispose()
            bitmapImg = Nothing
            PictureBox1.Image = bitmapImg
            File.Delete(tiffPath)
            File.Delete(Path)
            bitmapImg = Bitmap.FromFile(tmpPath)
            PictureBox1.Image = bitmapImg
            bitmapImg.RotateFlip(RotateFlipType.Rotate270FlipNone)
            bitmapImg.Save(Path)
            bitmapImg.Save(tiffPath)
            PictureBox1.Image = Nothing
            File.Delete(tmpPath)
        End If
    End Sub

End Class