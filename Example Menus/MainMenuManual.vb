Public Class MainMenuManual : Inherits BaseMenu

    Sub New()
        MyBase.New(
            MenuContext:={
                "1. Add 2 numbers",
                "2. Subtract 2 numbers",
                "3. Exit"
            },
            MenuTitle:="Main Menu Manual"
        )
    End Sub

    Function InputNums() As Integer()
        Console.Write("First number: ")
        Dim Num1 As Integer = Console.ReadLine

        Console.Write("Second number: ")
        Dim Num2 As Integer = Console.ReadLine

        Return {Num1, Num2}
    End Function

    Overloads Sub SelectOption()
        Dim MenuOption As Integer = MyBase.SelectOption()

        Select Case MenuOption
            Case 1
                Dim Nums As Integer() = Me.InputNums()
                Console.WriteLine("Result of {0} + {1} = {2}", Nums(0), Nums(1), Nums(0) + Nums(1))
            Case 2
                Dim Nums As Integer() = Me.InputNums()
                Console.WriteLine("Result of {0} - {1} = {2}", Nums(0), Nums(1), Nums(0) - Nums(1))
            Case 3 : Environment.Exit(0)
        End Select

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadKey()

        Me.Display()
        Me.SelectOption()
    End Sub

End Class
