Module Module1
Task 2.4

    Sub Main()
        Dim s1 As String
        Dim s2 As String
        Dim newS As String = ""
        Console.Write("Enter first string: ")
        s1 = Console.ReadLine()
        Console.Write("Enter second string: ")
        s2 = Console.ReadLine()
        newS = Mid(s2, 1, 2) & Mid(s1, 3) & " " & Mid(s1, 1, 2) & Mid(s2, 3)
        Console.WriteLine(newS)
        Console.ReadKey()

    End Sub

End Module
