Module Module1
Task 2.5

    Sub Main()
        Dim s As String
        Dim a As Integer
        Dim b As Integer
        Console.Write("Enter string: ")
        s = Console.ReadLine()
        For i = 1 To Len(s) - 2
            If Mid(s, i, 3) = "not" Then
                a = i
            ElseIf Mid(s, i, 3) = "bad" Then \
                b = i
            End If
        Next
        If b > a And a > 0 Then
            s = Mid(s, 1, a - 1) & "good" & Mid(s, b + 3)
        End If

        Console.WriteLine(s)
        Console.ReadKey()


    End Sub

End Module
