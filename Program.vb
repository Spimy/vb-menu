Imports System

Module Program
    Sub Main(args As String())
        With New MainMenuAuto()
            .Display()
            .SelectOption(True)
        End With

        'With New MainMenuManual()
        '    .Display()
        '    .SelectOption()
        'End With
    End Sub
End Module
