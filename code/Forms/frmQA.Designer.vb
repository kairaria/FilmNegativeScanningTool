<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQA
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQA))
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Button5)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Button4)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Button3)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
		Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
		Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
		Me.SplitContainer1.Panel2.Controls.Add(Me.ComboBox1)
		Me.SplitContainer1.Size = New System.Drawing.Size(1344, 712)
		Me.SplitContainer1.SplitterDistance = 764
		Me.SplitContainer1.SplitterWidth = 6
		Me.SplitContainer1.TabIndex = 0
		'
		'PictureBox1
		'
		Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(764, 712)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
		Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
		Me.GroupBox1.Location = New System.Drawing.Point(235, 14)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox1.Size = New System.Drawing.Size(302, 143)
		Me.GroupBox1.TabIndex = 18
		Me.GroupBox1.TabStop = False
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(14, 98)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(77, 20)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "End Date"
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(14, 38)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(83, 20)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Start Date"
		'
		'DateTimePicker2
		'
		Me.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm:ss"
		Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.DateTimePicker2.Location = New System.Drawing.Point(100, 89)
		Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.DateTimePicker2.Name = "DateTimePicker2"
		Me.DateTimePicker2.Size = New System.Drawing.Size(187, 26)
		Me.DateTimePicker2.TabIndex = 1
		Me.DateTimePicker2.Value = New Date(2118, 8, 23, 14, 57, 0, 0)
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss"
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.DateTimePicker1.Location = New System.Drawing.Point(100, 29)
		Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(187, 26)
		Me.DateTimePicker1.TabIndex = 0
		Me.DateTimePicker1.Value = New Date(2018, 2, 23, 0, 0, 0, 0)
		'
		'Button5
		'
		Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Button5.Location = New System.Drawing.Point(186, 654)
		Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(178, 35)
		Me.Button5.TabIndex = 26
		Me.Button5.Text = "Invert(Negatives)"
		Me.Button5.UseVisualStyleBackColor = True
		Me.Button5.Visible = False
		'
		'Button4
		'
		Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Button4.Location = New System.Drawing.Point(19, 654)
		Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(112, 35)
		Me.Button4.TabIndex = 25
		Me.Button4.Text = "Rotate"
		Me.Button4.UseVisualStyleBackColor = True
		Me.Button4.Visible = False
		'
		'Button3
		'
		Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Button3.Location = New System.Drawing.Point(419, 654)
		Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(112, 35)
		Me.Button3.TabIndex = 24
		Me.Button3.Text = "Delete"
		Me.Button3.UseVisualStyleBackColor = True
		Me.Button3.Visible = False
		'
		'Button2
		'
		Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Button2.Location = New System.Drawing.Point(416, 178)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(112, 35)
		Me.Button2.TabIndex = 23
		Me.Button2.Text = "Search"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.TextBox1.Location = New System.Drawing.Point(19, 187)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(313, 26)
		Me.TextBox1.TabIndex = 22
		'
		'Button1
		'
		Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Button1.Location = New System.Drawing.Point(91, 78)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(142, 35)
		Me.Button1.TabIndex = 21
		Me.Button1.Text = "Load Image List"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(19, 243)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(509, 389)
		Me.DataGridView1.TabIndex = 20
		'
		'ComboBox1
		'
		Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(19, 40)
		Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(205, 28)
		Me.ComboBox1.TabIndex = 19
		'
		'frmQA
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
		Me.AutoScroll = True
		Me.AutoSize = True
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.BackColor = System.Drawing.Color.LightSkyBlue
		Me.ClientSize = New System.Drawing.Size(1344, 712)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "frmQA"
		Me.Text = "Quality Checking"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.Panel2.PerformLayout()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
End Class
