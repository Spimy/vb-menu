Public Class MainMenuAuto : Inherits BaseMenu

    Sub New()
        MyBase.New({
            "Add 2 numbers",
            "Subtract 2 numbers",
            "Exit"
        }, True)
    End Sub

    Function InputNums() As Integer()
        Console.Write("First number: ")
        Dim Num1 As Integer = Console.ReadLine

        Console.Write("Second number: ")
        Dim Num2 As Integer = Console.ReadLine

        Return {Num1, Num2}
    End Function

    Sub Option1()
        Dim Nums As Integer() = Me.InputNums()
        Console.WriteLine("Result of {0} + {1} = {2}", Nums(0), Nums(1), Nums(0) + Nums(1))
    End Sub

    Sub Option2()
        Dim Nums As Integer() = Me.InputNums()
        Console.WriteLine("Result of {0} - {1} = {2}", Nums(0), Nums(1), Nums(0) - Nums(1))
    End Sub

    Sub Option3()
        Environment.Exit(0)
    End Sub

End Class
