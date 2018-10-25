<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.chkDiscount = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalTicks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkBox = New System.Windows.Forms.CheckBox()
        Me.chkPav = New System.Windows.Forms.CheckBox()
        Me.chkLawn = New System.Windows.Forms.CheckBox()
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.txtPav = New System.Windows.Forms.TextBox()
        Me.txtLawn = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.Location = New System.Drawing.Point(313, 54)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(105, 21)
        Me.chkDiscount.TabIndex = 1
        Me.chkDiscount.Text = "10% &discount"
        Me.chkDiscount.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total tickets:"
        '
        'lblTotalTicks
        '
        Me.lblTotalTicks.Enabled = False
        Me.lblTotalTicks.Location = New System.Drawing.Point(27, 196)
        Me.lblTotalTicks.Name = "lblTotalTicks"
        Me.lblTotalTicks.Size = New System.Drawing.Size(79, 25)
        Me.lblTotalTicks.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total due:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.Enabled = False
        Me.lblTotalDue.Location = New System.Drawing.Point(152, 196)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(79, 25)
        Me.lblTotalDue.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Location = New System.Drawing.Point(262, 196)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 27)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Location = New System.Drawing.Point(343, 196)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 27)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkBox
        '
        Me.chkBox.AutoSize = True
        Me.chkBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBox.Location = New System.Drawing.Point(6, 27)
        Me.chkBox.Name = "chkBox"
        Me.chkBox.Size = New System.Drawing.Size(45, 19)
        Me.chkBox.TabIndex = 0
        Me.chkBox.Text = "&Box"
        Me.chkBox.UseVisualStyleBackColor = True
        '
        'chkPav
        '
        Me.chkPav.AutoSize = True
        Me.chkPav.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPav.Location = New System.Drawing.Point(160, 25)
        Me.chkPav.Name = "chkPav"
        Me.chkPav.Size = New System.Drawing.Size(68, 19)
        Me.chkPav.TabIndex = 1
        Me.chkPav.Text = "&Pavilion"
        Me.chkPav.UseVisualStyleBackColor = True
        '
        'chkLawn
        '
        Me.chkLawn.AutoSize = True
        Me.chkLawn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLawn.Location = New System.Drawing.Point(85, 27)
        Me.chkLawn.Name = "chkLawn"
        Me.chkLawn.Size = New System.Drawing.Size(54, 19)
        Me.chkLawn.TabIndex = 2
        Me.chkLawn.Text = "&Lawn"
        Me.chkLawn.UseVisualStyleBackColor = True
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(6, 63)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(30, 25)
        Me.txtBox.TabIndex = 3
        Me.txtBox.Visible = False
        '
        'txtPav
        '
        Me.txtPav.Location = New System.Drawing.Point(160, 63)
        Me.txtPav.Name = "txtPav"
        Me.txtPav.Size = New System.Drawing.Size(30, 25)
        Me.txtPav.TabIndex = 4
        Me.txtPav.Visible = False
        '
        'txtLawn
        '
        Me.txtLawn.Location = New System.Drawing.Point(85, 63)
        Me.txtLawn.Name = "txtLawn"
        Me.txtLawn.Size = New System.Drawing.Size(30, 25)
        Me.txtLawn.TabIndex = 5
        Me.txtLawn.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPav)
        Me.GroupBox1.Controls.Add(Me.txtBox)
        Me.GroupBox1.Controls.Add(Me.txtLawn)
        Me.GroupBox1.Controls.Add(Me.chkPav)
        Me.GroupBox1.Controls.Add(Me.chkBox)
        Me.GroupBox1.Controls.Add(Me.chkLawn)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 258)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalTicks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkDiscount)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ticket Miser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkDiscount As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalTicks As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalDue As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkBox As CheckBox
    Friend WithEvents chkPav As CheckBox
    Friend WithEvents chkLawn As CheckBox
    Friend WithEvents txtBox As TextBox
    Friend WithEvents txtPav As TextBox
    Friend WithEvents txtLawn As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
