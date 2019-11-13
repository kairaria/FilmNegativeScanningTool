<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmP_rpt
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmP_rpt))
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.DataGridView2 = New System.Windows.Forms.DataGridView()
		Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadioButton2.Location = New System.Drawing.Point(567, 17)
		Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(294, 24)
		Me.RadioButton2.TabIndex = 1
		Me.RadioButton2.Text = "SELECT DELETED RECORDS"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.GroupBox1.Controls.Add(Me.RadioButton2)
		Me.GroupBox1.Controls.Add(Me.RadioButton1)
		Me.GroupBox1.Location = New System.Drawing.Point(18, 158)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox1.Size = New System.Drawing.Size(987, 52)
		Me.GroupBox1.TabIndex = 6449
		Me.GroupBox1.TabStop = False
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Checked = True
		Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadioButton1.Location = New System.Drawing.Point(39, 17)
		Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(275, 24)
		Me.RadioButton1.TabIndex = 0
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "SELECT KEYED RECORDS "
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'DataGridView2
		'
		Me.DataGridView2.AllowUserToAddRows = False
		Me.DataGridView2.AllowUserToDeleteRows = False
		Me.DataGridView2.AllowUserToOrderColumns = True
		Me.DataGridView2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
		Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Location = New System.Drawing.Point(612, 220)
		Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.DataGridView2.Name = "DataGridView2"
		Me.DataGridView2.ReadOnly = True
		Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView2.Size = New System.Drawing.Size(807, 622)
		Me.DataGridView2.TabIndex = 6448
		'
		'DateTimePicker2
		'
		Me.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm:ss"
		Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.DateTimePicker2.Location = New System.Drawing.Point(639, 34)
		Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.DateTimePicker2.Name = "DateTimePicker2"
		Me.DateTimePicker2.Size = New System.Drawing.Size(294, 26)
		Me.DateTimePicker2.TabIndex = 6447
		Me.DateTimePicker2.Value = New Date(2013, 1, 1, 0, 0, 0, 0)
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(458, 34)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(156, 25)
		Me.Label2.TabIndex = 6446
		Me.Label2.Text = "End Date/Time"
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss"
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.DateTimePicker1.Location = New System.Drawing.Point(228, 34)
		Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(218, 26)
		Me.DateTimePicker1.TabIndex = 6445
		Me.DateTimePicker1.Value = New Date(2013, 1, 1, 0, 0, 0, 0)
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(39, 38)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(164, 25)
		Me.Label1.TabIndex = 6444
		Me.Label1.Text = "Start Date/Time"
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AllowUserToOrderColumns = True
		Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(14, 220)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(561, 622)
		Me.DataGridView1.TabIndex = 6443
		'
		'Button1
		'
		Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Button1.Location = New System.Drawing.Point(1191, 49)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(219, 55)
		Me.Button1.TabIndex = 6442
		Me.Button1.Text = "Export to Excel"
		Me.Button1.UseVisualStyleBackColor = True
		Me.Button1.Visible = False
		'
		'Button2
		'
		Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Button2.Location = New System.Drawing.Point(966, 48)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(219, 55)
		Me.Button2.TabIndex = 6441
		Me.Button2.Text = "Generate"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(136, 88)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(79, 25)
		Me.Label3.TabIndex = 6451
		Me.Label3.Text = "Project"
		Me.Label3.Visible = False
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.TextBox1.Location = New System.Drawing.Point(228, 85)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(218, 26)
		Me.TextBox1.TabIndex = 6450
		Me.TextBox1.Visible = False
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.RadioButton3)
		Me.GroupBox2.Location = New System.Drawing.Point(1038, 158)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox2.Size = New System.Drawing.Size(381, 52)
		Me.GroupBox2.TabIndex = 6452
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Visible = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.Green
		Me.Label5.Location = New System.Drawing.Point(256, 20)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(44, 25)
		Me.Label5.TabIndex = 3
		Me.Label5.Text = "ON"
		Me.Label5.Visible = False
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadioButton3.Location = New System.Drawing.Point(36, 17)
		Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(196, 24)
		Me.RadioButton3.TabIndex = 2
		Me.RadioButton3.Text = "FILTER BY BATCH"
		Me.RadioButton3.UseVisualStyleBackColor = True
		Me.RadioButton3.Visible = False
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(548, 85)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(79, 25)
		Me.Label4.TabIndex = 6454
		Me.Label4.Text = "Batch#"
		Me.Label4.Visible = False
		'
		'TextBox2
		'
		Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.TextBox2.Location = New System.Drawing.Point(639, 82)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(294, 26)
		Me.TextBox2.TabIndex = 6453
		Me.TextBox2.Visible = False
		'
		'Label6
		'
		Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(18, 129)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(74, 25)
		Me.Label6.TabIndex = 6455
		Me.Label6.Text = "Status"
		'
		'frmP_rpt
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.ClientSize = New System.Drawing.Size(1437, 843)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.DataGridView2)
		Me.Controls.Add(Me.DateTimePicker2)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.DateTimePicker1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Button2)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "frmP_rpt"
		Me.Text = "1st Key Productivity Report"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
