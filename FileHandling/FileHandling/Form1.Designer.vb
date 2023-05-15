<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.txtRead = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.box_Save = New System.Windows.Forms.SaveFileDialog()
        Me.box_open = New System.Windows.Forms.SaveFileDialog()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(141, 12)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(484, 237)
        Me.txtInfo.TabIndex = 0
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(151, 265)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(112, 34)
        Me.btnWrite.TabIndex = 1
        Me.btnWrite.Text = "&Write"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'txtRead
        '
        Me.txtRead.Location = New System.Drawing.Point(407, 265)
        Me.txtRead.Name = "txtRead"
        Me.txtRead.Size = New System.Drawing.Size(112, 34)
        Me.txtRead.TabIndex = 2
        Me.txtRead.Text = "Read"
        Me.txtRead.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(151, 316)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 34)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(407, 316)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(112, 34)
        Me.btnOpen.TabIndex = 4
        Me.btnOpen.Text = "&Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 450)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtRead)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.txtInfo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInfo As TextBox
    Friend WithEvents btnWrite As Button
    Friend WithEvents txtRead As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents box_Save As SaveFileDialog
    Friend WithEvents box_open As SaveFileDialog
    Friend WithEvents btnOpen As Button
End Class
