<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputFile
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
        Me.txtSrcFile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCreateArray = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtArrayName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtSrcFile
        '
        Me.txtSrcFile.Location = New System.Drawing.Point(12, 26)
        Me.txtSrcFile.Name = "txtSrcFile"
        Me.txtSrcFile.Size = New System.Drawing.Size(179, 20)
        Me.txtSrcFile.TabIndex = 0
        Me.txtSrcFile.Text = "words.txt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File Containing Wordlist:"
        '
        'cmdCreateArray
        '
        Me.cmdCreateArray.Location = New System.Drawing.Point(31, 91)
        Me.cmdCreateArray.Name = "cmdCreateArray"
        Me.cmdCreateArray.Size = New System.Drawing.Size(140, 21)
        Me.cmdCreateArray.TabIndex = 3
        Me.cmdCreateArray.Text = "Create Array"
        Me.cmdCreateArray.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Array name:"
        '
        'txtArrayName
        '
        Me.txtArrayName.Location = New System.Drawing.Point(12, 65)
        Me.txtArrayName.Name = "txtArrayName"
        Me.txtArrayName.Size = New System.Drawing.Size(179, 20)
        Me.txtArrayName.TabIndex = 4
        Me.txtArrayName.Text = "Array"
        '
        'InputFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 122)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtArrayName)
        Me.Controls.Add(Me.cmdCreateArray)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSrcFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "InputFile"
        Me.Text = "Array Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSrcFile As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCreateArray As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtArrayName As System.Windows.Forms.TextBox

End Class
