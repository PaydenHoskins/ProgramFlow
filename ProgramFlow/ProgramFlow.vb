
Option Explicit On
Option Strict On
Option Compare Text

Module ProgramFlow

    Sub Main()
        Dim FirstNumber As Integer

        Do
            Console.WriteLine("In the second loop. Loop While FirstNumber <= 3")
            FirstNumber += 1
            Console.WriteLine($"FirstNUmber is {FirstNumber}!")
        Loop While FirstNumber <= 3

        Console.WriteLine()

    End Sub

End Module
