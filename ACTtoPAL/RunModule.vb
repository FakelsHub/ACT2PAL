Module RunModule
    Friend DropFile() As String
    Friend FileData() As Byte

    Friend Sub Main()
        Dim arg = My.Application.CommandLineArgs()
        If arg.Count > 0 Then
            ConvertPaL(arg(0))
            Application.Exit()
        Else
            MainForm.ShowDialog()
        End If
    End Sub

    Friend Sub ConvertPaL(ByVal pFile As String)
        FileData = IO.File.ReadAllBytes(pFile)
        For i As Integer = 0 To FileData.Length - 1
            If FileData(i) > &HFC Then FileData(i) = &HFC
            FileData(i) = FileData(i) >> 2
        Next
        IO.File.WriteAllBytes(pFile.Remove(pFile.LastIndexOf(".")) & ".pal", FileData)
    End Sub

End Module
