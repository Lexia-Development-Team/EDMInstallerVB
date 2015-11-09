Imports System.IO

Public Class MainWindow
    Public files As FileGen = New FileGen()
    Public Download As DownloadFiles = New DownloadFiles()
    Private InstallLocation As String = "Install Location"

    Private Sub InstallButton_Click(sender As Object, e As EventArgs) Handles InstallButton.Click
        If (files.modvalue.Value = "true") Then

            Console.WriteLine("It Worked!!!")
        End If

        If (File.Exists(Application.StartupPath + "/EDM.jar") = False) Then

            Download.downloadEDM()

        Else

            MessageBox.Show("Already Downloaded. Moving file...")

        End If

        If (File.Exists(InstallLocation + "/mods/EDM.jar") = False) Then


            File.Move(Application.StartupPath + "/EDM.jar", InstallLocation + "/mods/EDM.jar")

        Else

            Console.WriteLine("Oops!! Something went wrong!! " + files.modvalue.ToString() + " was not vaild or the config was tampered with, so no install happened.")

        End If

        If (files.forgevalue.Value = "true") Then

            Download.DownloadForge()
            System.Diagnostics.Process.Start(Application.StartupPath + "/forge.exe")

        Else

            Console.WriteLine("Oops!! Something went wrong!!")

        End If
    End Sub

    Private Sub EDMInstall_CheckedChanged(sender As Object, e As EventArgs) Handles EDMInstall.CheckedChanged
        If (EDMInstall.Checked = True) Then

            files.modvalue.Value = "true"
            files.run()
            Console.WriteLine(files.modvalue.Value)
        Else
            files.modvalue.Value = "false"
            files.run()
            Console.WriteLine(files.modvalue.Value)
        End If
    End Sub

    Private Sub ForgeInstall_CheckedChanged(sender As Object, e As EventArgs) Handles ForgeInstall.CheckedChanged
        If (ForgeInstall.Checked = True) Then

            files.forgevalue.Value = "true"
            files.run()
            Console.WriteLine(files.forgevalue.Value)
        Else
            files.forgevalue.Value = "false"
            files.run()
            Console.WriteLine(files.forgevalue.Value)
        End If
    End Sub

    Private Sub Version_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VersionSelector.SelectedIndexChanged

    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        FolderBrowser.RootFolder = Environment.SpecialFolder.ApplicationData
        ' Show the FolderBrowserDialog
        Dim result As DialogResult = FolderBrowser.ShowDialog()
        If (result = DialogResult.OK) Then

            Directory.Text = FolderBrowser.SelectedPath
            InstallLocation = FolderBrowser.SelectedPath

        End If
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        files.genDefaults()
        files.run()
    End Sub

    Private Sub Directory_TextChanged(sender As Object, e As EventArgs) Handles Directory.TextChanged

    End Sub
End Class