<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Bar = New System.Windows.Forms.ProgressBar()
        Me.TextChargement = New System.Windows.Forms.Timer(Me.components)
        Me.Chargement = New System.Windows.Forms.Timer(Me.components)
        Me.ChargementText = New KyOS_Charger.FlatLabel()
        Me.Copyright = New KyOS_Charger.FlatLabel()
        Me.MAJtimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.Image = Global.KyOS_Charger.My.Resources.Resources.kyos_icon2
        Me.Logo.InitialImage = Global.KyOS_Charger.My.Resources.Resources.kyos_icon2
        Me.Logo.Location = New System.Drawing.Point(10, 7)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(288, 288)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'Bar
        '
        Me.Bar.Location = New System.Drawing.Point(-2, 332)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(312, 23)
        Me.Bar.TabIndex = 4
        '
        'TextChargement
        '
        Me.TextChargement.Interval = 500
        '
        'Chargement
        '
        Me.Chargement.Interval = 80
        '
        'ChargementText
        '
        Me.ChargementText.AutoSize = True
        Me.ChargementText.BackColor = System.Drawing.Color.Transparent
        Me.ChargementText.Font = New System.Drawing.Font("Cartoonist", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChargementText.ForeColor = System.Drawing.Color.White
        Me.ChargementText.Location = New System.Drawing.Point(67, 308)
        Me.ChargementText.Name = "ChargementText"
        Me.ChargementText.Size = New System.Drawing.Size(167, 21)
        Me.ChargementText.TabIndex = 1
        Me.ChargementText.Text = "Chargement..."
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.White
        Me.Copyright.Location = New System.Drawing.Point(33, 358)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(243, 17)
        Me.Copyright.TabIndex = 5
        Me.Copyright.Text = "©KyOS - Kycraft 2018 (Créé par Kyneas)"
        '
        'MAJtimer
        '
        Me.MAJtimer.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(308, 384)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Bar)
        Me.Controls.Add(Me.ChargementText)
        Me.Controls.Add(Me.Logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KyOS - Chargement..."
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Logo As PictureBox
    Friend WithEvents ChargementText As FlatLabel
    Friend WithEvents Bar As ProgressBar
    Friend WithEvents TextChargement As Timer
    Friend WithEvents Chargement As Timer
    Friend WithEvents Copyright As FlatLabel
    Friend WithEvents MAJtimer As Timer
End Class
