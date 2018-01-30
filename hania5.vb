Module Module1
Task 1.5
    Sub Main()

        Dim Name As String
        Dim MemberIdNumber As String
        Dim TelephoneNumber As String
        Dim Membershipstartdate As Date

        FileOpen(1, "d/helloworld/sRec.txt", OpenMode.Input)
        FileOpen(2, "d:/helloworld/sRec.txt", OpenMode.Append)

        Console.WriteLine("Enter telephoneno.for name: ",& Name)
telephonenumber: Console.ReadLine()
        Console.WriteLine("Enter Membership Startdate for name: ", & Name)
MemSD:  Console.ReadLine()

        WriteLine(2, Name)
        WriteLine(2, MemID)
        WriteLine(2, Telephoneno.)
        WriteLine(2, MemSD)

        FileClose(1)
        FileClose(2)


    End Sub

End Module
