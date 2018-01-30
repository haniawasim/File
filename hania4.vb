Module Module1
Tasl 1.4
    Sub Main()

        Dim Name As String
        Dim MemberIdNumber As String


        Console.Write("Enter name: ")
        name:    Console.ReadLine
        Console.WriteLine("Enter memberIdnumber: ")
        MemberIdNumber:  Console.ReadLine
        
        FileOpen(1, "d:/helloworld/sRec.txt", OpenMode.Append)


        WriteLine(1, Name)
        WriteLine(1, MemberIdNumber)
        

        FileClose(1)
    End Sub

End Module
