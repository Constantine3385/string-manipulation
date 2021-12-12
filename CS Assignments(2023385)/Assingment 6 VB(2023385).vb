Module Module1

    Sub Main()
        Dim Count As Integer
        Count = 0

        Console.Write("please enter the number of donuts :")
        Count = Console.ReadLine

        If Count > 9 Then
            Console.WriteLine("Number of Donuts = Many")
        Else : Console.WriteLine("Number of Donuts = " & Count)

        End If
        Console.ReadKey()

    End Sub

End Module
