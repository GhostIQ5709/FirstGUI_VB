<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDecking
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
        Me.pnlImage = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFootage = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbComposite = New System.Windows.Forms.RadioButton()
        Me.rbRedwood = New System.Windows.Forms.RadioButton()
        Me.rbPTLumber = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlImage
        '
        Me.pnlImage.BackgroundImage = Global.FirstGUI_VB.My.Resources.Resources.sky_stars_background_points_85061_1920x1080
        Me.pnlImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlImage.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlImage.Location = New System.Drawing.Point(332, 0)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(300, 367)
        Me.pnlImage.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Decking Cost Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Square Footage:"
        '
        'txtFootage
        '
        Me.txtFootage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFootage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txtFootage.Location = New System.Drawing.Point(192, 59)
        Me.txtFootage.Name = "txtFootage"
        Me.txtFootage.Size = New System.Drawing.Size(54, 29)
        Me.txtFootage.TabIndex = 2
        Me.txtFootage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbComposite)
        Me.GroupBox1.Controls.Add(Me.rbRedwood)
        Me.GroupBox1.Controls.Add(Me.rbPTLumber)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(49, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 121)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Decking Type"
        '
        'rbComposite
        '
        Me.rbComposite.AutoSize = True
        Me.rbComposite.Location = New System.Drawing.Point(20, 81)
        Me.rbComposite.Name = "rbComposite"
        Me.rbComposite.Size = New System.Drawing.Size(88, 21)
        Me.rbComposite.TabIndex = 0
        Me.rbComposite.TabStop = True
        Me.rbComposite.Text = "Composite"
        Me.rbComposite.UseVisualStyleBackColor = True
        '
        'rbRedwood
        '
        Me.rbRedwood.AutoSize = True
        Me.rbRedwood.Location = New System.Drawing.Point(20, 53)
        Me.rbRedwood.Name = "rbRedwood"
        Me.rbRedwood.Size = New System.Drawing.Size(82, 21)
        Me.rbRedwood.TabIndex = 0
        Me.rbRedwood.TabStop = True
        Me.rbRedwood.Text = "Redwood"
        Me.rbRedwood.UseVisualStyleBackColor = True
        '
        'rbPTLumber
        '
        Me.rbPTLumber.AutoSize = True
        Me.rbPTLumber.Location = New System.Drawing.Point(20, 24)
        Me.rbPTLumber.Name = "rbPTLumber"
        Me.rbPTLumber.Size = New System.Drawing.Size(177, 21)
        Me.rbPTLumber.TabIndex = 0
        Me.rbPTLumber.TabStop = True
        Me.rbPTLumber.Text = "Pressure Treated Lumber"
        Me.rbPTLumber.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cost Estimate:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(176, 261)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(40, 19)
        Me.lblCost.TabIndex = 1
        Me.lblCost.Text = "Cost"
        '
        'btnCost
        '
        Me.btnCost.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(69, 313)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(75, 34)
        Me.btnCost.TabIndex = 4
        Me.btnCost.Text = "Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(192, 313)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 34)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmDecking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 367)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFootage)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlImage)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Name = "frmDecking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Decking Cost Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlImage As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFootage As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbComposite As RadioButton
    Friend WithEvents rbRedwood As RadioButton
    Friend WithEvents rbPTLumber As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
End Class
