Imports TheShapes.Rectangle
Imports System.Text.RegularExpressions

Module App

    Public arrMenu() As String = {"1. Rectangle", "2. Circle", "3. Triangle"}

    Sub Main()
        Dim userChoice As Integer
        Dim userShapeInput As Double

        Console.WriteLine("Welcome to The Shapes Calculator!" & vbNewLine & vbNewLine & "Please choose from the available menu below:")
        For Each menu In arrMenu
            Console.WriteLine(menu)
        Next
        Console.Write("Enter menu number: ")
        userChoice = userInput(Of Integer)("[123]")

        Select Case userChoice
            Case 1
                Console.Write("Enter the length (cm): ")
                userShapeInput = userInput(Of Double)()
                Dim objRect As New Rectangle(userShapeInput)
                objRect.setAreaPrice(500)
                objRect.print()
            Case 2
                Console.Write("Enter the radius (cm): ")
                userShapeInput = userInput(Of Double)()
                Dim objCirc As New Circle(userShapeInput)
                objCirc.setAreaPrice(120)
                objCirc.print()
            Case 3
                Console.Write("Enter the baseline (cm): ")
                Dim userShapeInputBaseLine As Double = userInput(Of Double)()
                Console.Write("Enter the height (cm): ")
                Dim userShapeInputHeight As Double = userInput(Of Double)()
                Dim objTri As New Triangle(userShapeInputBaseLine, userShapeInputHeight)
                objTri.setAreaPrice(250)
                objTri.print()
        End Select
        Console.ReadKey()
    End Sub

    Public Function userInput(Of T)(Optional regex_pattern As String = Nothing) As T
        Dim rawInput As String
        Dim uInput As T

        While (True)
            Try
                rawInput = Console.ReadLine()
                uInput = Convert.ChangeType(rawInput, GetType(T))

                ' check if the input type is correct
                If uInput.GetType() Is GetType(T) Then
                    If Not String.IsNullOrEmpty(regex_pattern) Then
                        ' validate with regex pattern
                        Dim regexp As New Regex(regex_pattern)
                        ' we convert the generic type to a string
                        Dim match = regexp.Match(uInput.ToString)

                        If match.Success Then
                            ' return input if all conditions are correct
                            Return uInput
                        Else
                            ' input not comply with regex pattern
                            Console.WriteLine("Error! Input is unrecognized.")
                        End If
                    Else
                        Return uInput
                    End If
                End If
            Catch ex As Exception
                Console.WriteLine("Error! {0}", ex.Message)
            End Try
        End While

    End Function

End Module
