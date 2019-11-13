<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScan))
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.DynamicDotNetTwain1 = New Dynamsoft.DotNet.TWAIN.DynamicDotNetTwain()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.btnRefresh = New System.Windows.Forms.Button()
		Me.btnEdit = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.DynamicDotNetTwain1)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.AutoScroll = True
		Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
		Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox4)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
		Me.SplitContainer1.Panel2.Controls.Add(Me.btnRefresh)
		Me.SplitContainer1.Panel2.Controls.Add(Me.btnEdit)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox3)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox2)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
		Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
		Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
		Me.SplitContainer1.Size = New System.Drawing.Size(1344, 712)
		Me.SplitContainer1.SplitterDistance = 848
		Me.SplitContainer1.SplitterWidth = 6
		Me.SplitContainer1.TabIndex = 0
		'
		'DynamicDotNetTwain1
		'
		Me.DynamicDotNetTwain1.AnnotationFillColor = System.Drawing.Color.White
		Me.DynamicDotNetTwain1.AnnotationPen = Nothing
		Me.DynamicDotNetTwain1.AnnotationTextColor = System.Drawing.Color.Black
		Me.DynamicDotNetTwain1.AnnotationTextFont = Nothing
		Me.DynamicDotNetTwain1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DynamicDotNetTwain1.IfShowCancelDialogWhenImageTransfer = False
		Me.DynamicDotNetTwain1.IfThrowException = False
		Me.DynamicDotNetTwain1.Location = New System.Drawing.Point(0, 0)
		Me.DynamicDotNetTwain1.LogLevel = CType(0, Short)
		Me.DynamicDotNetTwain1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.DynamicDotNetTwain1.Name = "DynamicDotNetTwain1"
		Me.DynamicDotNetTwain1.PDFMarginBottom = CType(0UI, UInteger)
		Me.DynamicDotNetTwain1.PDFMarginLeft = CType(0UI, UInteger)
		Me.DynamicDotNetTwain1.PDFMarginRight = CType(0UI, UInteger)
		Me.DynamicDotNetTwain1.PDFMarginTop = CType(0UI, UInteger)
		Me.DynamicDotNetTwain1.PDFXConformance = CType(0UI, UInteger)
		Me.DynamicDotNetTwain1.ProductFamily = "Dynamic .NET TWAIN (.NET Framewor"
		Me.DynamicDotNetTwain1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.DynamicDotNetTwain1.Size = New System.Drawing.Size(848, 712)
		Me.DynamicDotNetTwain1.TabIndex = 0
		Me.DynamicDotNetTwain1.TIFFCompressionType = Dynamsoft.DotNet.TWAIN.Enums.DWTTIFFCompressionType.TIFF_JPEG
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(4, 474)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(176, 25)
		Me.Label4.TabIndex = 40
		Me.Label4.Text = "Date 'yyyy-MM-dd'"
		'
		'TextBox4
		'
		Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox4.Location = New System.Drawing.Point(9, 504)
		Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(182, 30)
		Me.TextBox4.TabIndex = 34
		'
		'Button2
		'
		Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(9, 626)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(87, 67)
		Me.Button2.TabIndex = 39
		Me.Button2.Text = "Rotate Left"
		Me.Button2.UseVisualStyleBackColor = True
		Me.Button2.Visible = False
		'
		'btnRefresh
		'
		Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRefresh.Location = New System.Drawing.Point(218, 631)
		Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.btnRefresh.Name = "btnRefresh"
		Me.btnRefresh.Size = New System.Drawing.Size(247, 67)
		Me.btnRefresh.TabIndex = 38
		Me.btnRefresh.Text = "Refresh Image"
		Me.btnRefresh.UseVisualStyleBackColor = True
		'
		'btnEdit
		'
		Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEdit.Location = New System.Drawing.Point(122, 631)
		Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.btnEdit.Name = "btnEdit"
		Me.btnEdit.Size = New System.Drawing.Size(88, 67)
		Me.btnEdit.TabIndex = 37
		Me.btnEdit.Text = "Rotate Right"
		Me.btnEdit.UseVisualStyleBackColor = True
		Me.btnEdit.Visible = False
		'
		'Button1
		'
		Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(9, 540)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(456, 76)
		Me.Button1.TabIndex = 36
		Me.Button1.Text = "Capture"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TextBox3
		'
		Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox3.Location = New System.Drawing.Point(398, 504)
		Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(67, 30)
		Me.TextBox3.TabIndex = 35
		'
		'TextBox2
		'
		Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox2.Location = New System.Drawing.Point(90, 439)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(375, 30)
		Me.TextBox2.TabIndex = 32
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(58, 400)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(412, 30)
		Me.TextBox1.TabIndex = 30
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(393, 474)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(72, 25)
		Me.Label3.TabIndex = 33
		Me.Label3.Text = "Slide #"
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(4, 439)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(67, 25)
		Me.Label2.TabIndex = 31
		Me.Label2.Text = "Folder"
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(4, 403)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(46, 25)
		Me.Label1.TabIndex = 29
		Me.Label1.Text = "Box"
		'
		'PictureBox1
		'
		Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.PictureBox1.Location = New System.Drawing.Point(4, 75)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(464, 315)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 28
		Me.PictureBox1.TabStop = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.GroupBox1.Controls.Add(Me.RadioButton2)
		Me.GroupBox1.Controls.Add(Me.RadioButton1)
		Me.GroupBox1.Location = New System.Drawing.Point(4, 14)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox1.Size = New System.Drawing.Size(466, 57)
		Me.GroupBox1.TabIndex = 27
		Me.GroupBox1.TabStop = False
		'
		'RadioButton2
		'
		Me.RadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadioButton2.ForeColor = System.Drawing.Color.Red
		Me.RadioButton2.Location = New System.Drawing.Point(293, 21)
		Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(90, 26)
		Me.RadioButton2.TabIndex = 1
		Me.RadioButton2.Text = "Slides"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'RadioButton1
		'
		Me.RadioButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Checked = True
		Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadioButton1.ForeColor = System.Drawing.Color.Red
		Me.RadioButton1.Location = New System.Drawing.Point(38, 21)
		Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(124, 26)
		Me.RadioButton1.TabIndex = 0
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "Negatives"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'frmScan
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
		Me.AutoScroll = True
		Me.AutoSize = True
		Me.ClientSize = New System.Drawing.Size(1344, 712)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MinimizeBox = False
		Me.Name = "frmScan"
		Me.Text = "Negatives Scanner"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.Panel2.PerformLayout()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DynamicDotNetTwain1 As Dynamsoft.DotNet.TWAIN.DynamicDotNetTwain
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
