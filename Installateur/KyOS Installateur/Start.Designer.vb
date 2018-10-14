<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.KyOSIL = New System.Windows.Forms.Label()
        Me.ThemeT = New System.Windows.Forms.Label()
        Me.ThemeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ThemeBtn = New KyOS_Installateur.FlatToggle()
        Me.FlatLabel3 = New KyOS_Installateur.FlatLabel()
        Me.KyOSIEI = New KyOS_Installateur.FlatAlertBox()
        Me.KyOSII = New KyOS_Installateur.FlatAlertBox()
        Me.CloseInstall = New KyOS_Installateur.FlatLabel()
        Me.KyOSIBI = New KyOS_Installateur.FlatButton()
        Me.KyOSIBINSTALL = New KyOS_Installateur.FlatButton()
        Me.FlatButton1 = New KyOS_Installateur.FlatButton()
        Me.SuspendLayout()
        '
        'KyOSIL
        '
        Me.KyOSIL.AutoSize = True
        Me.KyOSIL.Font = New System.Drawing.Font("Cartoonist", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KyOSIL.ForeColor = System.Drawing.Color.White
        Me.KyOSIL.Location = New System.Drawing.Point(285, 40)
        Me.KyOSIL.Name = "KyOSIL"
        Me.KyOSIL.Size = New System.Drawing.Size(285, 91)
        Me.KyOSIL.TabIndex = 26
        Me.KyOSIL.Text = "KyOS"
        '
        'ThemeT
        '
        Me.ThemeT.AutoSize = True
        Me.ThemeT.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThemeT.ForeColor = System.Drawing.Color.White
        Me.ThemeT.Location = New System.Drawing.Point(12, 280)
        Me.ThemeT.Name = "ThemeT"
        Me.ThemeT.Size = New System.Drawing.Size(115, 20)
        Me.ThemeT.TabIndex = 40
        Me.ThemeT.Text = "Mode Sombre :"
        '
        'ThemeTimer
        '
        Me.ThemeTimer.Interval = 1
        '
        'ThemeBtn
        '
        Me.ThemeBtn.BackColor = System.Drawing.Color.Transparent
        Me.ThemeBtn.Checked = True
        Me.ThemeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ThemeBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ThemeBtn.Location = New System.Drawing.Point(133, 275)
        Me.ThemeBtn.Name = "ThemeBtn"
        Me.ThemeBtn.Options = KyOS_Installateur.FlatToggle._Options.Style3
        Me.ThemeBtn.Size = New System.Drawing.Size(76, 33)
        Me.ThemeBtn.TabIndex = 39
        Me.ThemeBtn.Text = "FlatToggle1"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel3.Location = New System.Drawing.Point(298, 131)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(80, 14)
        Me.FlatLabel3.TabIndex = 38
        Me.FlatLabel3.Text = "édition de base"
        '
        'KyOSIEI
        '
        Me.KyOSIEI.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.KyOSIEI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KyOSIEI.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.KyOSIEI.kind = KyOS_Installateur.FlatAlertBox._Kind.[Error]
        Me.KyOSIEI.Location = New System.Drawing.Point(53, 202)
        Me.KyOSIEI.Name = "KyOSIEI"
        Me.KyOSIEI.Size = New System.Drawing.Size(748, 42)
        Me.KyOSIEI.TabIndex = 37
        Me.KyOSIEI.Text = "KyOS est déjà installé sur l'ordinateur"
        Me.KyOSIEI.Visible = False
        '
        'KyOSII
        '
        Me.KyOSII.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.KyOSII.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KyOSII.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.KyOSII.kind = KyOS_Installateur.FlatAlertBox._Kind.Success
        Me.KyOSII.Location = New System.Drawing.Point(53, 202)
        Me.KyOSII.Name = "KyOSII"
        Me.KyOSII.Size = New System.Drawing.Size(748, 42)
        Me.KyOSII.TabIndex = 36
        Me.KyOSII.Text = "Installation terminé"
        Me.KyOSII.Visible = False
        '
        'CloseInstall
        '
        Me.CloseInstall.AutoSize = True
        Me.CloseInstall.BackColor = System.Drawing.Color.Transparent
        Me.CloseInstall.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseInstall.ForeColor = System.Drawing.Color.White
        Me.CloseInstall.Location = New System.Drawing.Point(822, 12)
        Me.CloseInstall.Name = "CloseInstall"
        Me.CloseInstall.Size = New System.Drawing.Size(20, 21)
        Me.CloseInstall.TabIndex = 35
        Me.CloseInstall.Text = "X"
        '
        'KyOSIBI
        '
        Me.KyOSIBI.BackColor = System.Drawing.Color.Transparent
        Me.KyOSIBI.BaseColor = System.Drawing.Color.SteelBlue
        Me.KyOSIBI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KyOSIBI.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.KyOSIBI.Location = New System.Drawing.Point(12, 55)
        Me.KyOSIBI.Name = "KyOSIBI"
        Me.KyOSIBI.Rounded = False
        Me.KyOSIBI.Size = New System.Drawing.Size(104, 37)
        Me.KyOSIBI.TabIndex = 34
        Me.KyOSIBI.Text = "Informations"
        Me.KyOSIBI.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'KyOSIBINSTALL
        '
        Me.KyOSIBINSTALL.BackColor = System.Drawing.Color.Transparent
        Me.KyOSIBINSTALL.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KyOSIBINSTALL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KyOSIBINSTALL.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.KyOSIBINSTALL.Location = New System.Drawing.Point(53, 164)
        Me.KyOSIBINSTALL.Name = "KyOSIBINSTALL"
        Me.KyOSIBINSTALL.Rounded = False
        Me.KyOSIBINSTALL.Size = New System.Drawing.Size(748, 32)
        Me.KyOSIBINSTALL.TabIndex = 28
        Me.KyOSIBINSTALL.Text = "Démarrer"
        Me.KyOSIBINSTALL.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.DarkOrange
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(12, 12)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(104, 37)
        Me.FlatButton1.TabIndex = 41
        Me.FlatButton1.Text = "Options"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(854, 323)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.ThemeT)
        Me.Controls.Add(Me.ThemeBtn)
        Me.Controls.Add(Me.FlatLabel3)
        Me.Controls.Add(Me.KyOSIEI)
        Me.Controls.Add(Me.KyOSII)
        Me.Controls.Add(Me.CloseInstall)
        Me.Controls.Add(Me.KyOSIBI)
        Me.Controls.Add(Me.KyOSIBINSTALL)
        Me.Controls.Add(Me.KyOSIL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KyOS - Installation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KyOSIL As Label
    Friend WithEvents KyOSIBINSTALL As FlatButton
    Friend WithEvents KyOSIBI As FlatButton
    Friend WithEvents CloseInstall As FlatLabel
    Friend WithEvents KyOSII As FlatAlertBox
    Friend WithEvents KyOSIEI As FlatAlertBox
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents ThemeT As Label
    Friend WithEvents ThemeTimer As Timer
    Friend WithEvents ThemeBtn As FlatToggle
    Friend WithEvents FlatButton1 As FlatButton
End Class
