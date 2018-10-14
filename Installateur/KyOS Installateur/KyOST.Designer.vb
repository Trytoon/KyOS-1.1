<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KyOST
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
        Me.FlatLabel1 = New KyOS_Installateur.FlatLabel()
        Me.FlatLabel2 = New KyOS_Installateur.FlatLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.FlatButton1 = New KyOS_Installateur.FlatButton()
        Me.FlatLabel3 = New KyOS_Installateur.FlatLabel()
        Me.SuspendLayout()
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Cartoonist", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(12, 11)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(64, 21)
        Me.FlatLabel1.TabIndex = 0
        Me.FlatLabel1.Text = "KyOS"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(12, 44)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(262, 22)
        Me.FlatLabel2.TabIndex = 1
        Me.FlatLabel2.Text = "Téléchargement de KyOS..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 84)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(647, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.IndianRed
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(557, 113)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton1.TabIndex = 3
        Me.FlatButton1.Text = "Annuler"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel3.Location = New System.Drawing.Point(19, 113)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(80, 14)
        Me.FlatLabel3.TabIndex = 4
        Me.FlatLabel3.Text = "édition de base"
        '
        'KyOST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.FlatLabel3)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.FlatLabel2)
        Me.Controls.Add(Me.FlatLabel1)
        Me.Name = "KyOST"
        Me.Size = New System.Drawing.Size(676, 152)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatLabel3 As FlatLabel
End Class
