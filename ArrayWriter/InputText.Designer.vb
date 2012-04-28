<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputText
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtArrayName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.cmdCreateArray = New System.Windows.Forms.Button()
        Me.cmdCopyOutput = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtInput)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(7, 16)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(280, 88)
        Me.txtInput.TabIndex = 0
        '
        'txtArrayName
        '
        Me.txtArrayName.Location = New System.Drawing.Point(135, 129)
        Me.txtArrayName.Name = "txtArrayName"
        Me.txtArrayName.Size = New System.Drawing.Size(116, 20)
        Me.txtArrayName.TabIndex = 1
        Me.txtArrayName.Text = "Array"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Array name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOutput)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 110)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(7, 16)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(280, 88)
        Me.txtOutput.TabIndex = 2
        '
        'cmdCreateArray
        '
        Me.cmdCreateArray.Location = New System.Drawing.Point(12, 272)
        Me.cmdCreateArray.Name = "cmdCreateArray"
        Me.cmdCreateArray.Size = New System.Drawing.Size(140, 21)
        Me.cmdCreateArray.TabIndex = 3
        Me.cmdCreateArray.Text = "Create Array"
        Me.cmdCreateArray.UseVisualStyleBackColor = True
        '
        'cmdCopyOutput
        '
        Me.cmdCopyOutput.Enabled = False
        Me.cmdCopyOutput.Location = New System.Drawing.Point(165, 272)
        Me.cmdCopyOutput.Name = "cmdCopyOutput"
        Me.cmdCopyOutput.Size = New System.Drawing.Size(140, 21)
        Me.cmdCopyOutput.TabIndex = 4
        Me.cmdCopyOutput.Text = "Copy Output to Clipboard"
        Me.cmdCopyOutput.UseVisualStyleBackColor = True
        '
        'InputText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 305)
        Me.Controls.Add(Me.cmdCopyOutput)
        Me.Controls.Add(Me.cmdCreateArray)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtArrayName)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InputText"
        Me.Text = "Array Creator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtArrayName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents cmdCreateArray As System.Windows.Forms.Button
    Friend WithEvents cmdCopyOutput As System.Windows.Forms.Button
End Class
