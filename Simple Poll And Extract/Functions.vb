Imports Nini.Config

Module Functions
    Dim dataPath As String = AppDomain.CurrentDomain.BaseDirectory
    Dim settingsFile As New IniConfigSource(dataPath & "settings.ini")
    Public Function GetBotToken() As String
        Dim token As String = settingsFile.Configs("SETTINGS").Get("Token")
        Return token
    End Function

    Public Function GetBotPrefix() As String
        Dim prefix As String = settingsFile.Configs("SETTINGS").Get("Prefix")
        Return prefix
    End Function

    Public Function GetBotName() As String
        Dim name As String = settingsFile.Configs("SETTINGS").Get("Name")
        Return name
    End Function

    Public Function GetBotIcon() As String
        Dim icon As String = settingsFile.Configs("SETTINGS").Get("IconURL")
        Return icon
    End Function

    Public Function GetReactionList() As String
        Dim reactions As String = settingsFile.Configs("SETTINGS").Get("Reactions")
        Return reactions
    End Function

    Public Function GetDevKey() As String
        Dim devkey As String = settingsFile.Configs("PASTEBIN").Get("DevKey")
        Return devkey
    End Function

    Public Function GetPasteBinUsername() As String
        Dim user As String = settingsFile.Configs("PASTEBIN").Get("Username")
        Return user
    End Function

    Public Function GetPasteBinPassword() As String
        Dim pass As String = settingsFile.Configs("PASTEBIN").Get("Password")
        Return pass
    End Function

    Public Function GetPasteBinVisibility() As String
        Dim vis As String = settingsFile.Configs("PASTEBIN").Get("Visibility")
        Return vis
    End Function
End Module
