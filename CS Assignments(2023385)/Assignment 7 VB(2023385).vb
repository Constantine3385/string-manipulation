Module Module1

    Sub Main()
        Dim Str1, Str2, fStr, lstr As String
        Str1 = ""
        Str2 = ""
        fStr = ""
        lstr = ""

        Console.Write("input string to process :")

        Str1 = Console.ReadLine

        fStr = Left(Str1, 2)
        lstr = Right(Str1, 2)
        Str2 = fStr & lstr

        Console.WriteLine("processed string = " & Str2)
        Console.ReadKey()

    End Sub

End Module
