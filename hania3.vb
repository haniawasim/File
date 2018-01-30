Module Module1
Task 1.3
    Sub Main()

        Dim Name, searchName As String
        Dim MemberIdNumber As String
        Dim IsFound As Boolean
        isFound = False

        Console.Write("Enter name to search for :")
        searchName = Console.ReadLine
        FileOpen(1, "d/helloworld/sRec.txt", OpenMode.Input)

        While Not EOF(1) And isFound = False
            Input(1, sName)
            Input(1, sMemberId)

            If name = searchName Then
                isFound = True

                Console.WriteLine("Student name :" & name)
                Console.WriteLine("memberId :" & memid)

            End If
        End While
        FileClose(1)
        If isFound = False Then Console.WriteLine("Record not Found")

    End Sub

End Module
