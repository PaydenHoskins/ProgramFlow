
Option Explicit On
Option Strict On
Option Compare Text

Module ProgramFlow

    Sub Main()
        Dim FirstNumber As Integer
        Dim SecondNumber As Integer
        Dim GetOutOfHere As Boolean
        Dim UserInput As String
        Dim Operation As Integer
        Console.WriteLine("Type 'Q' at any point to Quit")
        Do
            Do
                GetOutOfHere = False

                Console.WriteLine("Enter Number: ")
                UserInput = Console.ReadLine()
                Console.WriteLine($"You entered {UserInput}.")
                Try
                    FirstNumber = CInt(UserInput)
                    GetOutOfHere = True
                Catch ex As Exception
                    If UserInput <> "Q" Then
                        Console.WriteLine($"You Entered {UserInput}, that is not a whole number...")
                    ElseIf UserInput = "Q" Then
                        GetOutOfHere = True
                    End If
                End Try
            Loop While GetOutOfHere = False

            GetOutOfHere = False

            Do While UserInput <> "Q" And GetOutOfHere = False
                Console.WriteLine("Enter Number: ")
                UserInput = Console.ReadLine()
                Console.WriteLine($"You entered {UserInput}.")
                Try
                    SecondNumber = CInt(UserInput)
                    GetOutOfHere = True
                Catch ex As Exception
                    If UserInput <> "Q" Then
                        Console.WriteLine($"You Entered {UserInput}, this is not a whole number...")
                    ElseIf UserInput = "Q" Then
                        GetOutOfHere = True
                    End If
                End Try
            Loop
            GetOutOfHere = False
            Do While UserInput <> "Q" And GetOutOfHere = False
                Console.WriteLine("Select Opertion: ")
                Console.WriteLine("1.Add")
                Console.WriteLine("2.Subtract")
                Console.WriteLine("3.Multiply")
                Console.WriteLine("4.Divide")
                Console.WriteLine("Input you choice below.")
                UserInput = Console.ReadLine()
                Try
                    Operation = CInt(UserInput)

                    If Operation = 1 Then
                        Console.WriteLine($"{FirstNumber} + {SecondNumber} = " & SecondNumber + FirstNumber)
                        GetOutOfHere = True
                    ElseIf Operation = 2 Then
                        Console.WriteLine($"{FirstNumber} - {SecondNumber} = " & SecondNumber - FirstNumber)
                        GetOutOfHere = True
                    ElseIf Operation = 3 Then
                        Console.WriteLine($"{FirstNumber} * {SecondNumber} = " & SecondNumber * FirstNumber)
                        GetOutOfHere = True
                    ElseIf Operation = 4 Then
                        Console.WriteLine($"{FirstNumber} / {SecondNumber} = " & SecondNumber / FirstNumber)
                        GetOutOfHere = True
                    ElseIf Operation > 4 Then
                        Console.WriteLine($"You choose {Operation} please choose 1-4.")
                    ElseIf Operation < 1 Then
                        Console.WriteLine($"You choose {Operation} please choose 1-4.")
                    End If
                Catch ex As Exception
                    Console.WriteLine($"You choose {Operation} please choose 1-4.")
                End Try
            Loop
        Loop While UserInput <> "Q"
        Console.WriteLine("Have A Nice Day!")

    End Sub

End Module
