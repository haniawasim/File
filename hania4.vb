Module Module1
Tasl 1.4
    Sub Main()

        Dim Name As String
        Dim MemberIdNumber As String
        Dim NewMemberId As String

        Console.Write("Enter name: ")
name:   Console.ReadLine()
        Console.WriteLine("Enter memberIdnumber: ")
MemberIdNumber: Console.ReadLine()
        Console.WriteLine("Enter newmemberId: ")
newmemberId: Console.ReadLine()

        FileOpen(1, "d:/helloworld/sRec.txt", OpenMode.Append)


        WriteLine(1, Name)
        WriteLine(1, MemberIdNumber)
        WriteLine(1, NewMemberId)

        FileClose(1)
    End Sub

End Module
