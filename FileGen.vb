Imports System.IO
Imports Newtonsoft.Json

Public Class FileGen

    Private RunLocation As String = Application.StartupPath

    Public forgevalue As ForgeValue = New ForgeValue()
    Public modvalue As ModValue = New ModValue()

    Public Sub genDefaults()
        forgevalue.Name = "MinecraftForge"
        forgevalue.Value = "false"
        modvalue.Name = "EDM"
        modvalue.Value = "false"
        Console.WriteLine("Generated defaults")
    End Sub

    Public Sub run()

        File.WriteAllText(RunLocation + "/config.json", JsonConvert.SerializeObject(forgevalue))
        File.WriteAllText(RunLocation + "/config.json", JsonConvert.SerializeObject(modvalue))
        Dim files As StreamWriter = File.CreateText(RunLocation + "/config.json")
        ' serialize JSON directly to a file
        Using (files)
            Dim serializer As JsonSerializer
            serializer = New JsonSerializer()
            serializer.Serialize(files, forgevalue)
            serializer.Serialize(files, modvalue)
        End Using

    End Sub
End Class