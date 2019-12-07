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
        Me.LibKepala = New System.Windows.Forms.ListBox()
        Me.LibEkor = New System.Windows.Forms.ListBox()
        Me.Tmrandom1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tmrandom2 = New System.Windows.Forms.Timer(Me.components)
        Me.LibAwal = New System.Windows.Forms.ListBox()
        Me.LibAkhir = New System.Windows.Forms.ListBox()
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
        Me.LbDadu.Font = New System.Drawing.Font("Niagara Engraved", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDadu.Location = New System.Drawing.Point(576, 9)
        Me.LbDadu.Name = "LbDadu"
        Me.LbDadu.Size = New System.Drawing.Size(46, 68)
        Me.LbDadu.TabIndex = 1
        Me.LbDadu.Text = "_"
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
        Me.Tm1.Interval = 500
        '
        'LibKepala
        '
        Me.LibKepala.FormattingEnabled = True
        Me.LibKepala.Location = New System.Drawing.Point(484, 222)
        Me.LibKepala.Name = "LibKepala"
        Me.LibKepala.Size = New System.Drawing.Size(120, 95)
        Me.LibKepala.TabIndex = 4
        '
        'LibEkor
        '
        Me.LibEkor.FormattingEnabled = True
        Me.LibEkor.Location = New System.Drawing.Point(631, 222)
        Me.LibEkor.Name = "LibEkor"
        Me.LibEkor.Size = New System.Drawing.Size(120, 95)
        Me.LibEkor.TabIndex = 5
        '
        'Tmrandom1
        '
        Me.Tmrandom1.Interval = 50
        '
        'Tmrandom2
        '
        Me.Tmrandom2.Enabled = True
        Me.Tmrandom2.Interval = 50
        '
        'LibAwal
        '
        Me.LibAwal.FormattingEnabled = True
        Me.LibAwal.Location = New System.Drawing.Point(484, 343)
        Me.LibAwal.Name = "LibAwal"
        Me.LibAwal.Size = New System.Drawing.Size(120, 95)
        Me.LibAwal.TabIndex = 6
        '
        'LibAkhir
        '
        Me.LibAkhir.FormattingEnabled = True
        Me.LibAkhir.Location = New System.Drawing.Point(631, 343)
        Me.LibAkhir.Name = "LibAkhir"
        Me.LibAkhir.Size = New System.Drawing.Size(120, 95)
        Me.LibAkhir.TabIndex = 7
        '
        'FormPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LibAkhir)
        Me.Controls.Add(Me.LibAwal)
        Me.Controls.Add(Me.LibEkor)
        Me.Controls.Add(Me.LibKepala)
        Me.Controls.Add(Me.TbCheat)
        Me.Controls.Add(Me.BtnCheat)
        Me.Controls.Add(Me.LbDadu)
        Me.Controls.Add(Me.BtnDadu)
        Me.Name = "FormPlay"
        Me.Text = "ULAR DAN TANGGA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDadu As Button
    Friend WithEvents LbDadu As Label
    Friend WithEvents BtnCheat As Button
    Friend WithEvents TbCheat As TextBox
    Friend WithEvents Tm1 As Timer
    Friend WithEvents LibKepala As ListBox
    Friend WithEvents LibEkor As ListBox
    Friend WithEvents Tmrandom1 As Timer
    Friend WithEvents Tmrandom2 As Timer
    Friend WithEvents LibAwal As ListBox
    Friend WithEvents LibAkhir As ListBox
End Class
