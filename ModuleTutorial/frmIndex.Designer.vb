<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndex
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
        Me.btnNextForm = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numRandom1 = New System.Windows.Forms.NumericUpDown()
        Me.numRandom2 = New System.Windows.Forms.NumericUpDown()
        CType(Me.numRandom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRandom2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNextForm
        '
        Me.btnNextForm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNextForm.Location = New System.Drawing.Point(109, 176)
        Me.btnNextForm.Name = "btnNextForm"
        Me.btnNextForm.Size = New System.Drawing.Size(75, 35)
        Me.btnNextForm.TabIndex = 0
        Me.btnNextForm.Text = "Send to next form"
        Me.btnNextForm.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.Location = New System.Drawing.Point(99, 69)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Insert Name Below"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Two Numbers"
        '
        'numRandom1
        '
        Me.numRandom1.Location = New System.Drawing.Point(99, 109)
        Me.numRandom1.Name = "numRandom1"
        Me.numRandom1.Size = New System.Drawing.Size(46, 20)
        Me.numRandom1.TabIndex = 4
        '
        'numRandom2
        '
        Me.numRandom2.Location = New System.Drawing.Point(149, 109)
        Me.numRandom2.Name = "numRandom2"
        Me.numRandom2.Size = New System.Drawing.Size(46, 20)
        Me.numRandom2.TabIndex = 5
        '
        'frmIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.numRandom2)
        Me.Controls.Add(Me.numRandom1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnNextForm)
        Me.Name = "frmIndex"
        Me.Text = "Form1"
        CType(Me.numRandom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRandom2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNextForm As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numRandom1 As NumericUpDown
    Friend WithEvents numRandom2 As NumericUpDown
End Class
