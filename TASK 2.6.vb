﻿Module Module1
Task 2.6
    Sub Main()
        Dim a As String
        Dim aFront As String
        Dim aBack As String
        Dim b As String
        Dim bFront As String
        Dim bBack As String
        Console.Write("Enter first string: ")
        a = Console.ReadLine()
        Console.Write("Enter second string: ")
        b = Console.ReadLine()
        If Len(a) Mod 2 = 0 Then
            aFront = Mid(a, 1, Len(a) / 2)
            aBack = Mid(a, (Len(a) / 2 + 1)
        Else
            aFront = Mid(a, 1, (Len(a) + 1) / 2)
            aBack = Mid(a, (Len(a) + 3) / 2)
        End If
        If Len(b) Mod 2 = 0 Then
            bFront = Mid(b, 1, Len(b) / 2)
            bBack = Mid(b, Len(b) / 2 + 1)
        Else
            bFront = Mid(b, 1, (Len(b) + 1) / 2)
            bBack = Mid(b, Len(b) + 3) / 2)
        End If
        Console.WriteLine(aFront & bFront & aBack & bBack)
        Console.ReadKey()
    End Sub

End Module
