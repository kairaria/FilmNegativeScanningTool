Imports Dynamsoft.DotNet.TWAIN.Enums
Imports System.IO

Public Class frmScan
    Private fileName, filepath, filepath2, jpath, tpath As String
    Private ImgAcq As Boolean
    Public Sub Select_Source()
        Try
            DynamicDotNetTwain1.LicenseKeys = "295E8B8609F789F0209009C8D8D12D1C"
            DynamicDotNetTwain1.SupportedDeviceType = EnumSupportedDeviceType.SDT_ALL
            DynamicDotNetTwain1.SelectSource() ' = False Then ' select source
            DynamicDotNetTwain1.SetVideoContainer(Me.PictureBox1) ' display preview in PictureBox
            DynamicDotNetTwain1.OpenSource() ' make source work
            DynamicDotNetTwain1.BitDepth = 24
            DynamicDotNetTwain1.Resolution = 600
            If UseScannerUI = True Then
                DynamicDotNetTwain1.IfShowUI = True
                DynamicDotNetTwain1.EnableSourceUI()
            End If

        Catch exp As Exception
            MessageBox.Show(exp.Message)
        End Try
    End Sub

    Private Sub AcquireSave_Image()
        If TextBox1.Text.ToLower = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Fill the Box,Folder and Slide #.", , "Omitted info.")
            Exit Sub
        End If

        Try
            DynamicDotNetTwain1.IfThrowException = False
            DynamicDotNetTwain1.EnableSource() ' acquire image
            If RadioButton1.Checked Then
                DynamicDotNetTwain1.Invert(0)
            Else
            End If
            ImgAcq = True
            Save_Image()
        Catch exp As Exception
            MessageBox.Show(exp.Message & vbNewLine & DynamicDotNetTwain1.ErrorString)
        End Try
    End Sub
    Private Sub Save_Image()
        Try
            connection.Close()
            If MsgBox("Save Image?", vbYesNo, "Scan successful") = vbYes Then
                fileName = TextBox2.Text.Trim() & "_" & TextBox4.Text.Trim() & "_" & TextBox3.Text.Trim().ToLower
                filepath = "\\127.0.0.1\Negatives Scanning\JPEGs\" & TextBox1.Text.ToLower.Trim() & "\".ToLower
                filepath2 = "\\127.0.0.1\Negatives Scanning\TIFFs\" & TextBox1.Text.ToLower.Trim() & "\".ToLower
                If VerifyFileName(fileName) Then
                    jpath = filepath & fileName & ".jpeg"
                    tpath = filepath2 & fileName & ".tif"
                End If

                Try
                    'Create Directory if it does not exist
                    If Not Directory.Exists(filepath) Or Not Directory.Exists(filepath2) Then
                        Directory.CreateDirectory(filepath)
                        Directory.CreateDirectory(filepath2)
                    End If
                    Dim jPathExists As Boolean = File.Exists(jpath)
                    Dim tPathExists As Boolean = File.Exists(tpath)

                    'Set DPI to 600
                    DynamicDotNetTwain1.CopyToClipboard(0)
                    Dim ScanImg As New Bitmap(Clipboard.GetImage)
                    ScanImg.SetResolution(600, 600)
                    'Save as Jpeg && Tiff
                    ScanImg.Save(jpath, Imaging.ImageFormat.Jpeg)
                    ScanImg.Save(tpath, Imaging.ImageFormat.Tiff)

                    'Capture the scan for productivity and tracking
                    If jPathExists = False And tPathExists = False Then
                        UpdateRecord("Insert into NMG_scan (clerk,filename) VALUES ('" & GetUserName() & "',Trim(' " & Replace(jpath, "\", "\\") & " '))")
                    ElseIf (jPathExists Or tPathExists) Then
                        If MsgBox("Image had been Scanned. Do you want to capture it again?", MsgBoxStyle.YesNo, "Duplicate Scan") = MsgBoxResult.Yes Then
                            UpdateRecord("Update NMG_scan Set clerk = '" & GetUserName() & "' WHERE filename like Trim(' " & Replace(jpath, "\", "\\") & " ')")
                        End If
                    End If
                    'Clear image scan in memory and preview
                    Remove_Images()
                    PictureBox1.Image = Nothing
                    'Auto Increment Slide #
                    TextBox3.Text += 1

                Catch ex As Exception
                    MsgBox(ex.Message & vbNewLine & DynamicDotNetTwain1.ErrorString)
                Finally
                    DynamicDotNetTwain1.DisableSource()

                End Try
            Else

                Exit Sub
            End If
        Catch exp As Exception
            MessageBox.Show(exp.Message & vbNewLine & DynamicDotNetTwain1.ErrorString)
        End Try
    End Sub
    Private Sub Remove_Images()
        DynamicDotNetTwain1.RemoveAllImages() ' remove image
        ImgAcq = False
    End Sub

    Private Function VerifyFileName(ByVal fileName As String) As Boolean
        Try

            If fileName.LastIndexOfAny(System.IO.Path.GetInvalidFileNameChars()) = -1 Then
                Return True
            End If

        Catch ex As Exception

        End Try
        MessageBox.Show("The file name contains invalid chars!", "Save Image To File", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return False
    End Function
    Private Sub Edit_Image()
        DynamicDotNetTwain1.ShowImageEditor()
    End Sub

    Private Sub Form_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then

            If ImgAcq = True Then
                Save_Image()
            Else
                AcquireSave_Image()
            End If
        ElseIf e.KeyCode = Keys.Right And e.Modifiers = Keys.Control Then
            Rotate_Image_Right()
        ElseIf e.KeyCode = Keys.Left And e.Modifiers = Keys.Control Then
            Rotate_Image_Left()
        End If

    End Sub


    Private Sub Form_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        DynamicDotNetTwain1.DisableSource()

    End Sub

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Timer1.Start()
        MdiParent = frmHome

        Select_Source()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AcquireSave_Image()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Rotate_Image_Right()
    End Sub
    Private Sub Refresh_Image()
        DynamicDotNetTwain1.RemoveAllImages()
        ImgAcq = False
        If TextBox1.Text.ToLower = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Fill the Box,Folder and Slide #.", , "Omitted info.")
            Exit Sub
        Else

            DynamicDotNetTwain1.IfThrowException = True
            DynamicDotNetTwain1.EnableSource() ' acquire image
            If RadioButton1.Checked Then
                DynamicDotNetTwain1.Invert(0)
            Else
            End If
            ImgAcq = True
            Save_Image()
        End If
    End Sub

    Private Sub Rotate_Image_Left()

        DynamicDotNetTwain1.RotateLeft(0)
        Save_Image()
    End Sub
    Private Sub Rotate_Image_Right()

        DynamicDotNetTwain1.RotateRight(0)
        Save_Image()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Refresh_Image()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Rotate_Image_Left()
    End Sub

#Region "Skip Evaluation Pop up"

#End Region

End Class
