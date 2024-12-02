<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScuba
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumberOfMembers = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbDiveList = New System.Windows.Forms.ListBox()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDive = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(358, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Oceanic Scuba Expeditions"
        '
        'cboLocation
        '
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Items.AddRange(New Object() {"Australia", "England", "Finland", "Ghana"})
        Me.cboLocation.Location = New System.Drawing.Point(415, 61)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(114, 25)
        Me.cboLocation.TabIndex = 1
        Me.cboLocation.Text = "Select Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(400, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number in Dive Team:"
        '
        'txtNumberOfMembers
        '
        Me.txtNumberOfMembers.Location = New System.Drawing.Point(548, 93)
        Me.txtNumberOfMembers.Name = "txtNumberOfMembers"
        Me.txtNumberOfMembers.Size = New System.Drawing.Size(25, 25)
        Me.txtNumberOfMembers.TabIndex = 3
        Me.txtNumberOfMembers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(419, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Select Scuba Dive:"
        '
        'lbDiveList
        '
        Me.lbDiveList.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiveList.FormattingEnabled = True
        Me.lbDiveList.Items.AddRange(New Object() {"Tiger Shark", "Fathom Chasm", "Namena Sunken Ship"})
        Me.lbDiveList.Location = New System.Drawing.Point(422, 158)
        Me.lbDiveList.Name = "lbDiveList"
        Me.lbDiveList.Size = New System.Drawing.Size(113, 43)
        Me.lbDiveList.TabIndex = 5
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCost.Location = New System.Drawing.Point(372, 213)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(83, 37)
        Me.btnCost.TabIndex = 6
        Me.btnCost.Text = "Dive Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(495, 213)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 37)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(400, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dive:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(400, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cost:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(400, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Length:"
        '
        'lblDive
        '
        Me.lblDive.AutoSize = True
        Me.lblDive.BackColor = System.Drawing.Color.Transparent
        Me.lblDive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lblDive.Location = New System.Drawing.Point(455, 263)
        Me.lblDive.Name = "lblDive"
        Me.lblDive.Size = New System.Drawing.Size(34, 17)
        Me.lblDive.TabIndex = 4
        Me.lblDive.Text = "Dive"
        Me.lblDive.Visible = False
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.BackColor = System.Drawing.Color.Transparent
        Me.lblCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lblCost.Location = New System.Drawing.Point(455, 287)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(35, 17)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Cost"
        Me.lblCost.Visible = False
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.BackColor = System.Drawing.Color.Transparent
        Me.lblLength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lblLength.Location = New System.Drawing.Point(455, 310)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(50, 17)
        Me.lblLength.TabIndex = 4
        Me.lblLength.Text = "Length"
        Me.lblLength.Visible = False
        '
        'frmScuba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FirstGUI_VB.My.Resources.Resources.face_paint_profile_abstraction_95073_1920x1080
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(602, 352)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lbDiveList)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDive)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumberOfMembers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboLocation)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmScuba"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Oceanic Scuba Expeditions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumberOfMembers As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbDiveList As ListBox
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDive As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblLength As Label
End Class
