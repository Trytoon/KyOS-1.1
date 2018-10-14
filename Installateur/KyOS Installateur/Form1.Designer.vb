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
        Me.KyOSIV = New System.Windows.Forms.Label()
        Me.KyOSIL = New System.Windows.Forms.Label()
        Me.TimerProgressBarInstall = New System.Windows.Forms.Timer(Me.components)
        Me.Installico = New System.Windows.Forms.Timer(Me.components)
        Me.KyOSIBAR = New System.Windows.Forms.ProgressBar()
        Me.OSVERIFI = New System.Windows.Forms.Timer(Me.components)
        Me.KyOSIBI = New KyOS_Installateur.FlatButton()
        Me.KyOSII = New KyOS_Installateur.FlatAlertBox()
        Me.CloseInstall = New KyOS_Installateur.FlatLabel()
        Me.KyOSIEI = New KyOS_Installateur.FlatAlertBox()
        Me.KyOSIBINSTALL = New KyOS_Installateur.FlatButton()
        Me.KyOSIBD = New KyOS_Installateur.FlatButton()
        Me.KyOSInstallpo = New KyOS_Installateur.KyOST()
        Me.KyOSInstall = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'KyOSIV
        '
        Me.KyOSIV.AutoSize = True
        Me.KyOSIV.Font = New System.Drawing.Font("Cartoonist", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KyOSIV.ForeColor = System.Drawing.Color.White
        Me.KyOSIV.Location = New System.Drawing.Point(348, 100)
        Me.KyOSIV.Name = "KyOSIV"
        Me.KyOSIV.Size = New System.Drawing.Size(82, 46)
        Me.KyOSIV.TabIndex = 26
        Me.KyOSIV.Text = "1.1"
        '
        'KyOSIL
        '
        Me.KyOSIL.AutoSize = True
        Me.KyOSIL.Font = New System.Drawing.Font("Cartoonist", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KyOSIL.ForeColor = System.Drawing.Color.White
        Me.KyOSIL.Location = New System.Drawing.Point(247, 9)
        Me.KyOSIL.Name = "KyOSIL"
        Me.KyOSIL.Size = New System.Drawing.Size(285, 91)
        Me.KyOSIL.TabIndex = 25
        Me.KyOSIL.Text = "KyOS"
        '
        'TimerProgressBarInstall
        '
        Me.TimerProgressBarInstall.Interval = 40
        '
        'Installico
        '
        Me.Installico.Interval = 1
        '
        'KyOSIBAR
        '
        Me.KyOSIBAR.Location = New System.Drawing.Point(-1, 371)
        Me.KyOSIBAR.Name = "KyOSIBAR"
        Me.KyOSIBAR.Size = New System.Drawing.Size(786, 23)
        Me.KyOSIBAR.TabIndex = 29
        '
        'OSVERIFI
        '
        Me.OSVERIFI.Interval = 1
        '
        'KyOSIBI
        '
        Me.KyOSIBI.BackColor = System.Drawing.Color.Transparent
        Me.KyOSIBI.BaseColor = System.Drawing.Color.SteelBlue
        Me.KyOSIBI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KyOSIBI.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.KyOSIBI.Location = New System.Drawing.Point(12, 9)
        Me.KyOSIBI.Name = "KyOSIBI"
        Me.KyOSIBI.Rounded = False
        Me.KyOSIBI.Size = New System.Drawing.Size(104, 37)
        Me.KyOSIBI.TabIndex = 33
        Me.KyOSIBI.Text = "Informations"
        Me.KyOSIBI.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'KyOSII
        '
        Me.KyOSII.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.KyOSII.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KyOSII.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.KyOSII.kind = KyOS_Installateur.FlatAlertBox._Kind.Success
        Me.KyOSII.Location = New System.Drawing.Point(18, 163)
        Me.KyOSII.Name = "KyOSII"
        Me.KyOSII.Size = New System.Drawing.Size(748, 42)
        Me.KyOSII.TabIndex = 32
        Me.KyOSII.Text = "Installation terminé"
        Me.KyOSII.Visible = False
        '
        'CloseInstall
        '
        Me.CloseInstall.AutoSize = True
        Me.CloseInstall.BackColor = System.Drawing.Color.Transparent
        Me.CloseInstall.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseInstall.ForeColor = System.Drawing.Color.White
        Me.CloseInstall.Location = New System.Drawing.Point(746, 9)
        Me.CloseInstall.Name = "CloseInstall"
        Me.CloseInstall.Size = New System.Drawing.Size(20, 21)
        Me.CloseInstall.TabIndex = 28
        Me.CloseInstall.Text = "X"
        '
        'KyOSIEI
        '
        Me.KyOSIEI.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.KyOSIEI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KyOSIEI.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.KyOSIEI.kind = KyOS_Installateur.FlatAlertBox._Kind.[Error]
        Me.KyOSIEI.Location = New System.Drawing.Point(18, 287)
        Me.KyOSIEI.Name = "KyOSIEI"
        Me.KyOSIEI.Size = New System.Drawing.Size(748, 42)
        Me.KyOSIEI.TabIndex = 31
        Me.KyOSIEI.Text = "KyOS est déjà installé sur l'ordinateur"
        Me.KyOSIEI.Visible = False
        '
        'KyOSIBINSTALL
        '
        Me.KyOSIBINSTALL.BackColor = System.Drawing.Color.Transparent
        Me.KyOSIBINSTALL.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KyOSIBINSTALL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KyOSIBINSTALL.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.KyOSIBINSTALL.Location = New System.Drawing.Point(18, 249)
        Me.KyOSIBINSTALL.Name = "KyOSIBINSTALL"
        Me.KyOSIBINSTALL.Rounded = False
        Me.KyOSIBINSTALL.Size = New System.Drawing.Size(748, 32)
        Me.KyOSIBINSTALL.TabIndex = 27
        Me.KyOSIBINSTALL.Text = "Démarrer"
        Me.KyOSIBINSTALL.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'KyOSIBD
        '
        Me.KyOSIBD.BackColor = System.Drawing.Color.Transparent
        Me.KyOSIBD.BaseColor = System.Drawing.Color.DarkRed
        Me.KyOSIBD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KyOSIBD.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.KyOSIBD.Location = New System.Drawing.Point(18, 211)
        Me.KyOSIBD.Name = "KyOSIBD"
        Me.KyOSIBD.Rounded = False
        Me.KyOSIBD.Size = New System.Drawing.Size(748, 32)
        Me.KyOSIBD.TabIndex = 30
        Me.KyOSIBD.Text = "Déinstaller"
        Me.KyOSIBD.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.KyOSIBD.Visible = False
        '
        'KyOSInstallpo
        '
        Me.KyOSInstallpo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.KyOSInstallpo.Location = New System.Drawing.Point(54, 129)
        Me.KyOSInstallpo.Name = "KyOSInstallpo"
        Me.KyOSInstallpo.Size = New System.Drawing.Size(676, 152)
        Me.KyOSInstallpo.TabIndex = 34
        Me.KyOSInstallpo.Visible = False
        '
        'KyOSInstall
        '
        Me.KyOSInstall.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(778, 393)
        Me.Controls.Add(Me.KyOSInstallpo)
        Me.Controls.Add(Me.KyOSIV)
        Me.Controls.Add(Me.KyOSIL)
        Me.Controls.Add(Me.KyOSIBI)
        Me.Controls.Add(Me.KyOSII)
        Me.Controls.Add(Me.CloseInstall)
        Me.Controls.Add(Me.KyOSIEI)
        Me.Controls.Add(Me.KyOSIBAR)
        Me.Controls.Add(Me.KyOSIBINSTALL)
        Me.Controls.Add(Me.KyOSIBD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KyOS - Installation"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KyOSIV As Label
    Friend WithEvents KyOSIL As Label
    Friend WithEvents TimerProgressBarInstall As Timer
    Friend WithEvents Installico As Timer
    Friend WithEvents KyOSIBI As FlatButton
    Friend WithEvents KyOSII As FlatAlertBox
    Friend WithEvents CloseInstall As FlatLabel
    Friend WithEvents KyOSIEI As FlatAlertBox
    Friend WithEvents KyOSIBAR As ProgressBar
    Friend WithEvents KyOSIBINSTALL As FlatButton
    Friend WithEvents KyOSIBD As FlatButton
    Friend WithEvents OSVERIFI As Timer
    Friend WithEvents KyOSInstallpo As KyOST
    Friend WithEvents KyOSInstall As Timer
End Class
