Module Module1

    Sub Main()
        Dim str As String
        Dim strlen, i, alpha, num, special As Integer
        Dim ch As Char
        str = " "
        strlen = 0
        i = 0
        alpha = 0
        num = 0
        special = 0
        Console.WriteLine("Enter a String : ")
        str = Console.ReadLine()
        strlen = Len(str)
        str = LCase(str)
        For i = 1 To strlen
            ch = Mid(str, i, 1)
            If ch >= "a" And ch <= "z" Then
                alpha = alpha + 1
            ElseIf ch >= "0" And ch <= "9" Then
                num = num + 1
            Else
                special = special + 1
            End If
Next
        Console.WriteLine("Number of alphabets =" & alpha)
        Console.WriteLine("Number of numbers =" & num)
        Console.WriteLine("Number of special charachters =" & special)

        Console.ReadKey()


    End Sub

End Module
