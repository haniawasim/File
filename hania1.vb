m﻿Module Module1

    Sub Main()
        Dim Name As String
        Dim MemberIdNumber As String

        Console.WriteLine("Enter name: ")
        Name:  Console.ReadLine

        Console.WriteLine("Enter memberIdnumber: ")
        MemberIdNumber: Console.ReadLine

        FileOpen(1, "d:/helloworld/sRec.txt", OpenMode.Append)
        FileClose(1)
    End Sub

End Module
