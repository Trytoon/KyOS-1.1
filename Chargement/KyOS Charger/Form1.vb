Imports System.Environment
Imports System.Net
Public Class Form1
    Dim A As New WebClient
    Dim MAJ As New WebClient
    Dim Local As String = GetFolderPath(SpecialFolder.LocalApplicationData)
    Dim VersionA As String = My.Settings.VersionA
    Dim VersionMAJ As String = MAJ.DownloadString("http://kyos-update.livehost.fr/kyos_version/versionMAJ.txt")
    Dim Erreur208 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckUpdates()
        MAJtimer.Start()
    End Sub

    Sub CheckUpdates()
        If My.Computer.FileSystem.FileExists("C:\Program Files\KyOS\" + VersionA + "\KyOS.exe") Then
        Else
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\KyOS\" + VersionA + "\")
            My.Computer.Network.DownloadFile("http://kyos-update.livehost.fr/kyos_maj/" + VersionA + "/KyOS.exe", "C:\Program Files\KyOS\" + VersionA + "\KyOS.exe", False, 500)
        End If
        If My.Computer.FileSystem.FileExists("C:\Program Files\KyOS\" + VersionA + "\Fond\") Then
        Else
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\KyOS\" + VersionA + "\Fond\")
            My.Computer.Network.DownloadFile("http://kyos-update.livehost.fr/kyos_maj/" + VersionA + "/Fond/WallpaperDefault.png", "C:\Program Files\KyOS\" + VersionA + "\Fond\WallpaperDefault.png")
        End If
        If VersionA = VersionMAJ Then
            MAJtimer.Stop()
            Chargement.Start()
            TextChargement.Start()
        Else
            Erreur208 = MsgBox("KyOS n'est pas à jour" & vbNewLine & "Faire la Mise à Jour ?", vbYesNo + MsgBoxStyle.Critical, "Erreur 208")
        End If
    End Sub

    Private Sub MAJtimer_Tick(sender As Object, e As EventArgs) Handles MAJtimer.Tick
        If Erreur208 = vbYes Then
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\KyOS\" + VersionMAJ + "\")
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\KyOS\" + VersionMAJ + "\Fond\")
            My.Computer.Network.DownloadFile("http://kyos-update.livehost.fr/kyos_maj/" + VersionMAJ + "/Fond/WallpaperDefault.png", "C:\Program Files\KyOS\" + VersionMAJ + "\Fond\WallpaperDefault.png")
            My.Computer.Network.DownloadFile("http://kyos-update.livehost.fr/kyos_maj/" + VersionMAJ + "/KyOS.exe", "C:\Program Files\KyOS\" + VersionMAJ + "\KyOS.exe", False, 500)
            My.Settings.VersionA = VersionMAJ
            My.Settings.Save()
            MAJtimer.Stop()
            Refresh()
            Chargement.Start()
            TextChargement.Start()
        Else
            MAJtimer.Stop()
            TextChargement.Start()
            Chargement.Start()
        End If
    End Sub

    Private Sub TextChargement_Tick(sender As Object, e As EventArgs) Handles TextChargement.Tick
        If ChargementText.Text = "Chargement..." Then
            ChargementText.Text = "Chargement."
        ElseIf ChargementText.Text = "Chargement." Then
            ChargementText.Text = "Chargement.."
        ElseIf ChargementText.Text = "Chargement.." Then
            ChargementText.Text = "Chargement..."
        End If
    End Sub

    Private Sub Chargement_Tick(sender As Object, e As EventArgs) Handles Chargement.Tick
        Bar.Increment(1)
        If Bar.Value = 100 Then
            Shell("C:\Program Files\KyOS\" + VersionA + "\KyOS.exe")
            Chargement.Stop()
            Close()
        End If
    End Sub
End Class
