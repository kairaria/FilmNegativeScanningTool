Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Xml

Module ConnDb

    Public ImgFilePath As String
    Public UseScannerUI As Boolean
    Public connStr As String = "Database=nmg_scan;Data Source=127.0.0.1;User Id=root;Password=allblacks;Allow User Variables=True;character set=utf8;"
    Public connection As New MySqlConnection(connStr)

    Public Function GetUserName() As String
        If TypeOf My.User.CurrentPrincipal Is
         Security.Principal.WindowsPrincipal Then
            ' The application is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            ' The application is using custom authentication.
            Return My.User.Name
        End If
    End Function

    Public Function UpdateRecord(ByVal query As String) As Integer
        Try
            Dim rowsEffected As Integer = 0
            Dim cmd As New MySqlCommand(query, connection)
            connection.Open()
            cmd.CommandType = CommandType.Text
            rowsEffected = cmd.ExecuteNonQuery()
            connection.Close()
            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Invert(ByVal image As System.Drawing.Bitmap, ByVal InvertAlpha As Boolean) As System.Drawing.Bitmap
        Dim x As Integer
        Dim y As Integer
        For x = 0 To image.Width - 1 Step 1
            For y = 0 To image.Height - 1 Step 1
                Dim clr As Color = image.GetPixel(x, y)
                Dim clr2 As Color
                If InvertAlpha Then
                    clr2 = Color.FromArgb(255 - clr.A, 255 - clr.R, 255 - clr.G, 255 - clr.B)
                Else
                    clr2 = Color.FromArgb(clr.A, 255 - clr.R, 255 - clr.G, 255 - clr.B)
                End If
                image.SetPixel(x, y, clr2)
            Next
        Next
        Return image
    End Function

    Public Function GetFileName(ByVal ImgFilePath As String) As String
        Dim slashindex As Integer = ImgFilePath.LastIndexOf("\")
        Dim dotindex As Integer = ImgFilePath.LastIndexOf(".")
        GetFileName = ImgFilePath.Substring(slashindex + 1, dotindex - slashindex - 1)
    End Function
    Public Function GetVersion() As String
        Dim reader As XmlTextReader = New XmlTextReader("Negative Scanning.exe.manifest")
        Try
            Do While (reader.Read())
                Select Case reader.NodeType
                    Case XmlNodeType.Element 'Display beginning of element.
                        If reader.HasAttributes Then 'If attributes exist
                            While reader.MoveToNextAttribute()
                                If reader.Name = "version" Then
                                    Return "Ver. " & reader.Value
                                End If
                            End While
                        Else
                            Return "Could not Identify version"
                        End If
                End Select
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "Could not Identify version"
        End Try
        Return "Ver. " & reader.Value
    End Function
    Public Function GetDirectoryName(ByVal ImgFilePath As String) As String
        Dim directoryName As String = IO.Path.GetDirectoryName(ImgFilePath)
        Dim parentName As String = IO.Path.GetFileName(directoryName)
        GetDirectoryName = parentName
    End Function
    Public Function GetDirectoryPath(ByVal ImgFilePath As String) As String
        Dim directoryName As String = IO.Path.GetDirectoryName(ImgFilePath)
        GetDirectoryPath = directoryName
    End Function
    Public Function GetFileNameLastPart(ByVal ImgFilePath As String) As String
        Dim slashindex As Integer = ImgFilePath.LastIndexOf("-")
        Dim dotindex As Integer = ImgFilePath.LastIndexOf(".")
        GetFileNameLastPart = CInt(ImgFilePath.Substring(slashindex + 1, dotindex - slashindex - 1))
    End Function
    Public Function GetFileNameB4LastPart(ByVal ImgFilePath As String) As String
        Dim slashindex As Integer = ImgFilePath.LastIndexOf("\")
        Dim dotindex As Integer = ImgFilePath.LastIndexOf("-")
        GetFileNameB4LastPart = ImgFilePath.Substring(slashindex + 1, dotindex - slashindex)
    End Function
    Public Function GetBatch(ByVal ImgFilePath As String) As String
        Dim BatchPath As String = ImgFilePath.Replace("\" & GetFileName(ImgFilePath) & ".pdf", "")
        GetBatch = IO.Path.GetFileName(BatchPath)
    End Function
    Public Function GetSuperBatch(ByVal ImgFilePath As String) As String
        Dim BatchPath As String = IO.Path.GetDirectoryName(ImgFilePath)
        Dim SuperBatch As String = IO.Path.GetDirectoryName(BatchPath)
        GetSuperBatch = IO.Path.GetFileName(SuperBatch)
    End Function
    Public Function GetBatchNo(ByVal ImgFilePath As String) As String
        Dim BatchPath As String = ImgFilePath.Replace("\Images\" & GetFileName(ImgFilePath) & ".jpeg", "")
        GetBatchNo = IO.Path.GetFileName(BatchPath)
    End Function
    Public Function GetBatchNo1(ByVal ImgFilePath As String) As String
        Dim BatchPath As String = ImgFilePath.Replace("\Images\" & GetFileName(ImgFilePath) & ".j2k", "")
        GetBatchNo1 = IO.Path.GetFileName(BatchPath)
    End Function
    Public Function GetBatchNo2(ByVal ImgFilePath As String) As String
        Dim BatchPath As String = ImgFilePath.Replace("\Images\" & GetFileName(ImgFilePath) & ".jpg", "")
        GetBatchNo2 = IO.Path.GetFileName(BatchPath)
    End Function
    Public Function EditExifMetadata(path As String)
        'To avoid loss on compression Rotate before saving
        Dim tmpPath = "C:\Users\Public\TempScannedImgs\TempImg.jpg"
        If Not Directory.Exists("C:\Users\Public\TempScannedImgs\") Then
            Directory.CreateDirectory("C:\Users\Public\TempScannedImgs\")
        End If
        Dim bitmapImg As New Bitmap(path)
        bitmapImg.SetResolution(600, 600)
        bitmapImg.RotateFlip(RotateFlipType.Rotate90FlipNone)
        bitmapImg.Save(tmpPath)
        bitmapImg.Dispose()
        bitmapImg = Nothing
        File.Delete(path)
        bitmapImg = Bitmap.FromFile(tmpPath)
        bitmapImg.RotateFlip(RotateFlipType.Rotate270FlipNone)
        bitmapImg.Save(path)
        File.Delete(tmpPath)
        Return Nothing
    End Function

End Module

