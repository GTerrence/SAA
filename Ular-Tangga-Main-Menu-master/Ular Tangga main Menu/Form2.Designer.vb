<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPlay
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnDadu = New System.Windows.Forms.Button()
        Me.LbDadu = New System.Windows.Forms.Label()
        Me.BtnCheat = New System.Windows.Forms.Button()
        Me.TbCheat = New System.Windows.Forms.TextBox()
        Me.Tm1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BtnDadu
        '
        Me.BtnDadu.Location = New System.Drawing.Point(579, 99)
        Me.BtnDadu.Name = "BtnDadu"
        Me.BtnDadu.Size = New System.Drawing.Size(75, 23)
        Me.BtnDadu.TabIndex = 0
        Me.BtnDadu.Text = "Dadu"
        Me.BtnDadu.UseVisualStyleBackColor = True
        '
        'LbDadu
        '
        Me.LbDadu.AutoSize = True
        Me.LbDadu.Location = New System.Drawing.Point(595, 48)
        Me.LbDadu.Name = "LbDadu"
        Me.LbDadu.Size = New System.Drawing.Size(10, 13)
        Me.LbDadu.TabIndex = 1
        Me.LbDadu.Text = "."
        '
        'BtnCheat
        '
        Me.BtnCheat.Location = New System.Drawing.Point(579, 193)
        Me.BtnCheat.Name = "BtnCheat"
        Me.BtnCheat.Size = New System.Drawing.Size(75, 23)
        Me.BtnCheat.TabIndex = 2
        Me.BtnCheat.Text = "Cheat"
        Me.BtnCheat.UseVisualStyleBackColor = True
        '
        'TbCheat
        '
        Me.TbCheat.Location = New System.Drawing.Point(568, 147)
        Me.TbCheat.Name = "TbCheat"
        Me.TbCheat.Size = New System.Drawing.Size(100, 20)
        Me.TbCheat.TabIndex = 3
        '
        'Tm1
        '
        Me.Tm1.Enabled = True
        Me.Tm1.Interval = 500
        '
        'FormPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TbCheat)
        Me.Controls.Add(Me.BtnCheat)
        Me.Controls.Add(Me.LbDadu)
        Me.Controls.Add(Me.BtnDadu)
        Me.Name = "FormPlay"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDadu As Button
    Friend WithEvents LbDadu As Label
    Friend WithEvents BtnCheat As Button
    Friend WithEvents TbCheat As TextBox
    Friend WithEvents Tm1 As Timer
End Class
