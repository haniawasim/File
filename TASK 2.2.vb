Module Module1
Task 2.2
    Sub Main()
        Dim txt As String
        Console.Write("Enter strings: ")
        txt = Console.ReadLine
        If Len(txt) < 2 Then
            Console.WriteLine("")
        Else : Console.WriteLine(Left(txt, 2) & Right(txt, 2))
        End If
        Console.ReadKey()

    End Sub

End Module
