<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFitness
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAverageWeight = New System.Windows.Forms.Label()
        Me.lstWeight = New System.Windows.Forms.ListBox()
        Me.btnEnterWeight = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(579, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.FirstGUI_VB.My.Resources.Resources.triangle_light_dark_shape_88545_1920x1080
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lblAverageWeight)
        Me.Panel1.Controls.Add(Me.lstWeight)
        Me.Panel1.Controls.Add(Me.btnEnterWeight)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(579, 352)
        Me.Panel1.TabIndex = 1
        '
        'lblAverageWeight
        '
        Me.lblAverageWeight.AutoSize = True
        Me.lblAverageWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lblAverageWeight.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageWeight.Location = New System.Drawing.Point(300, 305)
        Me.lblAverageWeight.Name = "lblAverageWeight"
        Me.lblAverageWeight.Size = New System.Drawing.Size(230, 20)
        Me.lblAverageWeight.TabIndex = 3
        Me.lblAverageWeight.Text = "Average weight loss is 11.2 lbs"
        '
        'lstWeight
        '
        Me.lstWeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWeight.FormattingEnabled = True
        Me.lstWeight.ItemHeight = 16
        Me.lstWeight.Location = New System.Drawing.Point(382, 133)
        Me.lstWeight.Name = "lstWeight"
        Me.lstWeight.Size = New System.Drawing.Size(70, 148)
        Me.lstWeight.TabIndex = 2
        '
        'btnEnterWeight
        '
        Me.btnEnterWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnEnterWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnterWeight.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterWeight.Location = New System.Drawing.Point(318, 80)
        Me.btnEnterWeight.Name = "btnEnterWeight"
        Me.btnEnterWeight.Size = New System.Drawing.Size(182, 36)
        Me.btnEnterWeight.TabIndex = 1
        Me.btnEnterWeight.Text = "Enter Weight Loss"
        Me.btnEnterWeight.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fitness Challenge" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Team Weight Loss"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFitness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 376)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFitness"
        Me.Text = "Fitness Challenge"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAverageWeight As Label
    Friend WithEvents lstWeight As ListBox
    Friend WithEvents btnEnterWeight As Button
    Friend WithEvents Label1 As Label
End Class
