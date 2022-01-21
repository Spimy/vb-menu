Public MustInherit Class BaseMenu

    Protected ReadOnly MenuContext As String()

    Sub New(MenuContext As String(), Optional PrefixNum As Boolean = False)
        If Not PrefixNum Then
            Me.MenuContext = MenuContext
        Else
            Me.MenuContext = MenuContext.Select(
                Function(Context, Index)
                    Return String.Format("{0}. {1}", Index + 1, Context)
                End Function
            ).ToArray()
        End If
    End Sub

    Public Sub Display(Optional MenuTitle As String = Nothing, Optional PrefixNum As Boolean = False)
        Console.Clear()

        If MenuTitle IsNot Nothing Then
            Console.WriteLine("-= {0} =-", MenuTitle)
        End If

        Console.WriteLine(String.Join(Environment.NewLine, MenuContext))
    End Sub

    Public Function SelectOption(Optional AutoHandle As Boolean = False) As Integer
        Dim MenuOption As String = ""

        While Not Integer.TryParse(MenuOption, Nothing) OrElse (MenuOption < 1 Or MenuOption > Me.MenuContext.Length)
            Console.Write("Option: ")
            MenuOption = Console.ReadLine
        End While

        Console.Clear()

        If AutoHandle Then
            Dim Method As Reflection.MethodInfo = Me.GetType().GetMethod(String.Format("Option{0}", MenuOption))

            If Method Is Nothing Then
                Console.WriteLine("Method not implemented. Press any key continue...")
            Else
                Method.Invoke(Me, Array.Empty(Of Object))
                Console.WriteLine()
                Console.WriteLine("Press any key continue...")
            End If

            Console.ReadKey()

            Me.Display()
            Me.SelectOption(True)
        End If

        Return MenuOption ' Automatically casted as integer because of function return type
    End Function

End Class
