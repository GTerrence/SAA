<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.LbData = New System.Windows.Forms.Label()
        Me.LbMOde = New System.Windows.Forms.Label()
        Me.TbData = New System.Windows.Forms.TextBox()
        Me.CbMode = New System.Windows.Forms.ComboBox()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.ChBlock = New System.Windows.Forms.CheckBox()
        Me.RbOn1 = New System.Windows.Forms.RadioButton()
        Me.RbOn2 = New System.Windows.Forms.RadioButton()
        Me.LibLeft = New System.Windows.Forms.ListBox()
        Me.BtnAR = New System.Windows.Forms.Button()
        Me.BtnR = New System.Windows.Forms.Button()
        Me.BtnL = New System.Windows.Forms.Button()
        Me.BtnAL = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LibRight = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbData
        '
        Me.LbData.AutoSize = True
        Me.LbData.Location = New System.Drawing.Point(30, 23)
        Me.LbData.Name = "LbData"
        Me.LbData.Size = New System.Drawing.Size(30, 13)
        Me.LbData.TabIndex = 0
        Me.LbData.Text = "Data"
        '
        'LbMOde
        '
        Me.LbMOde.AutoSize = True
        Me.LbMOde.Location = New System.Drawing.Point(30, 50)
        Me.LbMOde.Name = "LbMOde"
        Me.LbMOde.Size = New System.Drawing.Size(34, 13)
        Me.LbMOde.TabIndex = 1
        Me.LbMOde.Text = "Mode"
        '
        'TbData
        '
        Me.TbData.Location = New System.Drawing.Point(114, 23)
        Me.TbData.Name = "TbData"
        Me.TbData.Size = New System.Drawing.Size(124, 20)
        Me.TbData.TabIndex = 2
        '
        'CbMode
        '
        Me.CbMode.FormattingEnabled = True
        Me.CbMode.Items.AddRange(New Object() {"Add", "Replace"})
        Me.CbMode.Location = New System.Drawing.Point(114, 50)
        Me.CbMode.Name = "CbMode"
        Me.CbMode.Size = New System.Drawing.Size(124, 21)
        Me.CbMode.TabIndex = 3
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(114, 82)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(75, 23)
        Me.BtnProses.TabIndex = 4
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'ChBlock
        '
        Me.ChBlock.AutoSize = True
        Me.ChBlock.Location = New System.Drawing.Point(350, 82)
        Me.ChBlock.Name = "ChBlock"
        Me.ChBlock.Size = New System.Drawing.Size(53, 17)
        Me.ChBlock.TabIndex = 5
        Me.ChBlock.Text = "Block"
        Me.ChBlock.UseVisualStyleBackColor = True
        '
        'RbOn1
        '
        Me.RbOn1.AutoSize = True
        Me.RbOn1.Location = New System.Drawing.Point(9, 12)
        Me.RbOn1.Name = "RbOn1"
        Me.RbOn1.Size = New System.Drawing.Size(55, 17)
        Me.RbOn1.TabIndex = 6
        Me.RbOn1.TabStop = True
        Me.RbOn1.Text = "Active"
        Me.RbOn1.UseVisualStyleBackColor = True
        '
        'RbOn2
        '
        Me.RbOn2.AutoSize = True
        Me.RbOn2.Location = New System.Drawing.Point(245, 12)
        Me.RbOn2.Name = "RbOn2"
        Me.RbOn2.Size = New System.Drawing.Size(55, 17)
        Me.RbOn2.TabIndex = 7
        Me.RbOn2.TabStop = True
        Me.RbOn2.Text = "Active"
        Me.RbOn2.UseVisualStyleBackColor = True
        '
        'LibLeft
        '
        Me.LibLeft.FormattingEnabled = True
        Me.LibLeft.Location = New System.Drawing.Point(105, 158)
        Me.LibLeft.Name = "LibLeft"
        Me.LibLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LibLeft.Size = New System.Drawing.Size(120, 147)
        Me.LibLeft.TabIndex = 8
        '
        'BtnAR
        '
        Me.BtnAR.Location = New System.Drawing.Point(249, 166)
        Me.BtnAR.Name = "BtnAR"
        Me.BtnAR.Size = New System.Drawing.Size(75, 23)
        Me.BtnAR.TabIndex = 9
        Me.BtnAR.Text = ">>"
        Me.BtnAR.UseVisualStyleBackColor = True
        '
        'BtnR
        '
        Me.BtnR.Location = New System.Drawing.Point(249, 195)
        Me.BtnR.Name = "BtnR"
        Me.BtnR.Size = New System.Drawing.Size(75, 23)
        Me.BtnR.TabIndex = 10
        Me.BtnR.Text = ">"
        Me.BtnR.UseVisualStyleBackColor = True
        '
        'BtnL
        '
        Me.BtnL.Location = New System.Drawing.Point(249, 224)
        Me.BtnL.Name = "BtnL"
        Me.BtnL.Size = New System.Drawing.Size(75, 23)
        Me.BtnL.TabIndex = 11
        Me.BtnL.Text = "<"
        Me.BtnL.UseVisualStyleBackColor = True
        '
        'BtnAL
        '
        Me.BtnAL.Location = New System.Drawing.Point(249, 253)
        Me.BtnAL.Name = "BtnAL"
        Me.BtnAL.Size = New System.Drawing.Size(75, 23)
        Me.BtnAL.TabIndex = 12
        Me.BtnAL.Text = "<<"
        Me.BtnAL.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(249, 282)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 13
        Me.BtnHapus.Text = "X"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'LibRight
        '
        Me.LibRight.FormattingEnabled = True
        Me.LibRight.Location = New System.Drawing.Point(350, 158)
        Me.LibRight.Name = "LibRight"
        Me.LibRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LibRight.Size = New System.Drawing.Size(120, 147)
        Me.LibRight.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbOn2)
        Me.Panel1.Controls.Add(Me.RbOn1)
        Me.Panel1.Location = New System.Drawing.Point(105, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 41)
        Me.Panel1.TabIndex = 15
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LibRight)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnAL)
        Me.Controls.Add(Me.BtnL)
        Me.Controls.Add(Me.BtnR)
        Me.Controls.Add(Me.BtnAR)
        Me.Controls.Add(Me.LibLeft)
        Me.Controls.Add(Me.ChBlock)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.CbMode)
        Me.Controls.Add(Me.TbData)
        Me.Controls.Add(Me.LbMOde)
        Me.Controls.Add(Me.LbData)
        Me.Name = "FormMain"
        Me.Text = "Main Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbData As Label
    Friend WithEvents LbMOde As Label
    Friend WithEvents TbData As TextBox
    Friend WithEvents CbMode As ComboBox
    Friend WithEvents BtnProses As Button
    Friend WithEvents ChBlock As CheckBox
    Friend WithEvents RbOn1 As RadioButton
    Friend WithEvents RbOn2 As RadioButton
    Friend WithEvents LibLeft As ListBox
    Friend WithEvents BtnAR As Button
    Friend WithEvents BtnR As Button
    Friend WithEvents BtnL As Button
    Friend WithEvents BtnAL As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents LibRight As ListBox
    Friend WithEvents Panel1 As Panel
End Class
