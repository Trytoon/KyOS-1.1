Imports System.Environment
Imports System.Net
Public Class Form1
    Dim TrueValue As String = "true"
    Dim FalseValue As String = "false"
    Dim A As New WebClient
    Dim INSTALL As New WebClient
    Dim VersionINSTALL As String = INSTALL.DownloadString("http://kyos-update.livehost.fr/kyos_version/versionINSTALL.txt")
    Dim COSV = MsgBox("Voulez-vous que KyOS soit votre OS par défault ?", vbYesNo + vbQuestion, "KyOS Installation")

    Private Sub CloseInstall_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
    Private Sub StartInstall_Click(sender As Object, e As EventArgs)
        My.Settings.installKyOS = FalseValue
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\KyOS")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\KyOS\Fonts")
        TimerProgressBarInstall.Start()
        Installico.Start()
    End Sub

    Private Sub TimerProgressBarInstall_Tick(sender As Object, e As EventArgs)
        KyOSIBAR.Increment(1)
        If KyOSIBAR.Value = 100 Then
            Verif()
        End If
    End Sub

    Private Sub Verif()
        If My.Computer.FileSystem.DirectoryExists("C:\Program Files\KyOS\KyOS.exe") Then
            If My.Computer.FileSystem.DirectoryExists("C:\Program Files\KyOS\kyos.ico") Then
                MsgBox("Désolé, mais KyOS est déjà installé :/", vbOKOnly + MsgBoxStyle.Critical, "Erreur 100")
                TimerProgressBarInstall.Stop()
            Else
                My.Computer.Network.DownloadFile("http://kyos-update.livehost.fr/kyos_install/kyos.ico", "C:\Program Files\KyOS\KyOS.ico", False, 500)
            End If
        Else
            My.Computer.Network.DownloadFile("http://kyos-update.livehost.fr/kyos_install/" + VersionINSTALL + "/KyOS.exe", "C:\Program Files\KyOS\KyOS.exe", False, 500)
            My.Computer.Network.DownloadFile("http://kyos-update.livehost.fr/kyos_install/kyos.ico", "C:\Program Files\KyOS\KyOS.ico", False, 500)
            My.Computer.Network.DownloadFile("http://kyos-update.livehost.fr/kyos_install/KyLice.ttf", "C:\Program Files\KyOS\Fonts\KyLice.ttf", False, 500)
            My.Settings.installKyOS = TrueValue
            My.Settings.Save()
        End If
        Using key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts")
            key.SetValue("Description du Font", "KyLice.ttf")
            key.Close()
        End Using
    End Sub
    Private Sub Installico_Tick(sender As Object, e As EventArgs)
        Dim Bureau As IWshRuntimeLibrary.WshShell
        Dim Raccourci As IWshRuntimeLibrary.WshShortcut
        Dim Nom As String
        Bureau = New IWshRuntimeLibrary.WshShell
        Dim chemin As String = Environment.GetFolderPath(Environment.SpecialFolder.System)

        If My.Settings.installKyOS = TrueValue Then
            Nom = My.Computer.FileSystem.SpecialDirectories.Desktop & "\KyOS.lnk"
            Raccourci = CType(Bureau.CreateShortcut(Nom), IWshRuntimeLibrary.WshShortcut)
            Raccourci.TargetPath = "C:\Program Files\KyOS\KyOS.exe"
            Raccourci.IconLocation = "C:\Program Files\KyOS\KyOS.ico"
            Raccourci.Save()
            Installico.Stop()
            Shell("C:\Program Files\KyOS\KyOS.exe")
            Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.installKyOS = TrueValue Then
            KyOSIBINSTALL.Visible = False
            KyOSIEI.Visible = True
            KyOSIBAR.Visible = False
            KyOSIBD.Visible = True
        Else
            KyOSIBINSTALL.Visible = True
            KyOSIEI.Visible = False
            KyOSIBAR.Visible = True
            KyOSIBD.Visible = False
        End If
    End Sub

    Private Sub Uninstall_Click(sender As Object, e As EventArgs)
        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\KyOS", FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Settings.installKyOS = FalseValue
        My.Settings.Save()
        Close()
    End Sub

    Private Sub KyOSIBINSTALL_Click(sender As Object, e As EventArgs) Handles KyOSIBINSTALL.Click
        OSVERIFI.Start()
        'COSV()
    End Sub

    Private Sub OSVERIFI_Tick(sender As Object, e As EventArgs) Handles OSVERIFI.Tick
        If COSV = vbYes Then
            MsgBox("KyOS sera votre OS de défault")
            KyOSInstall.Start()
            KyOSInstallpo.Visible = True
        Else
            MsgBox("Windows sera votre OS")
        End If
    End Sub

    Private Sub KyOSInstall_Tick(sender As Object, e As EventArgs) Handles KyOSInstall.Tick

    End Sub
End Class
