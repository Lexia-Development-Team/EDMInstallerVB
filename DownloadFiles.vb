Imports System.IO
Imports System.Net
Public Class DownloadFiles
    Public Sub downloadEDM()

        If (File.Exists(Application.StartupPath + "/EDM.jar")) Then

            MessageBox.Show("Hey, You Already Downloaded it. Moving file.")

        Else

            Dim client As WebClient = New WebClient()

            Using (client)

                client.DownloadFile("http://addons-origin.cursecdn.com/files/2237/271/[1.7.10]EDM-4.1.0-Universal.jar", "EDM.jar")
            End Using
        End If
    End Sub

    Public Sub DownloadForge()

        If (File.Exists(Application.StartupPath + "/forge.exe")) Then

            Console.WriteLine("Already Downloaded Forge, going to install.")

        Else

            Dim client As WebClient = New WebClient

            Using (client)

                client.DownloadFile("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.7.10-10.13.2.1291/forge-1.7.10-10.13.2.1291-installer-win.exe", "forge.exe")
                Console.WriteLine("Downloaded Forge")
            End Using
        End If
    End Sub

End Class