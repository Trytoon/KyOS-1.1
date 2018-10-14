<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CloseInstall = New KyOS_Installateur.FlatLabel()
        Me.KyOSIL = New System.Windows.Forms.Label()
        Me.ThemeT = New System.Windows.Forms.Label()
        Me.ThemeBtn = New KyOS_Installateur.FlatToggle()
        Me.SuspendLayout()
        '
        'CloseInstall
        '
        Me.CloseInstall.AutoSize = True
        Me.CloseInstall.BackColor = System.Drawing.Color.Transparent
        Me.CloseInstall.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseInstall.ForeColor = System.Drawing.Color.White
        Me.CloseInstall.Location = New System.Drawing.Point(224, 10)
        Me.CloseInstall.Name = "CloseInstall"
        Me.CloseInstall.Size = New System.Drawing.Size(20, 21)
        Me.CloseInstall.TabIndex = 36
        Me.CloseInstall.Text = "X"
        '
        'KyOSIL
        '
        Me.KyOSIL.AutoSize = True
        Me.KyOSIL.Font = New System.Drawing.Font("Cartoonist", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KyOSIL.ForeColor = System.Drawing.Color.White
        Me.KyOSIL.Location = New System.Drawing.Point(10, 10)
        Me.KyOSIL.Name = "KyOSIL"
        Me.KyOSIL.Size = New System.Drawing.Size(155, 34)
        Me.KyOSIL.TabIndex = 37
        Me.KyOSIL.Text = "Options"
        '
        'ThemeT
        '
        Me.ThemeT.AutoSize = True
        Me.ThemeT.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThemeT.ForeColor = System.Drawing.Color.White
        Me.ThemeT.Location = New System.Drawing.Point(29, 61)
        Me.ThemeT.Name = "ThemeT"
        Me.ThemeT.Size = New System.Drawing.Size(115, 20)
        Me.ThemeT.TabIndex = 41
        Me.ThemeT.Text = "Mode Sombre :"
        '
        'ThemeBtn
        '
        Me.ThemeBtn.BackColor = System.Drawing.Color.Transparent
        Me.ThemeBtn.Checked = True
        Me.ThemeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ThemeBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ThemeBtn.Location = New System.Drawing.Point(150, 56)
        Me.ThemeBtn.Name = "ThemeBtn"
        Me.ThemeBtn.Options = KyOS_Installateur.FlatToggle._Options.Style3
        Me.ThemeBtn.Size = New System.Drawing.Size(76, 33)
        Me.ThemeBtn.TabIndex = 42
        Me.ThemeBtn.Text = "FlatToggle1"
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.ThemeBtn)
        Me.Controls.Add(Me.ThemeT)
        Me.Controls.Add(Me.KyOSIL)
        Me.Controls.Add(Me.CloseInstall)
        Me.Name = "Options"
        Me.Size = New System.Drawing.Size(255, 107)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseInstall As FlatLabel
    Friend WithEvents KyOSIL As Label
    Friend WithEvents ThemeT As Label
    Friend WithEvents ThemeBtn As FlatToggle
End Class
