Option Strict On
Option Explicit On
Imports System.Runtime.InteropServices
Imports Preactor

<ComVisible(True)>
<Microsoft.VisualBasic.ComClass("2b564a18-b38f-4b45-a6eb-5426554a31df", "d4bb7ada-a513-4626-94f5-53eb7f22e29b")>
Public Class CheckClassif

    Public ClassifsStrings As List(Of String)
    Public Function RunCheck(PR As IPreactor) As Boolean
        Dim MyTest = True
        ClassifsStrings = New List(Of String)
        FillClassifs()

        For Each classif In ClassifsStrings
            If PR.FindFirstClassificationString(classif).HasValue Then Continue For

            MsgBox("Classification " & classif & " is missing for jalonnement", MsgBoxStyle.Critical, "Jalonnement")
            MyTest = False
        Next

        Return MyTest
    End Function

    Private Sub FillClassifs()
        ClassifsStrings.Add("ORDERS TABLE")
        ClassifsStrings.Add("RESOURCES TABLE")
        ClassifsStrings.Add("MARGE JALONNEMENT")
        ClassifsStrings.Add("DUE DATE JALONNEMENT")
        ClassifsStrings.Add("EARLIEST START JALONNEMENT")
        ClassifsStrings.Add("LATEST START JALONNEMENT")
        ClassifsStrings.Add("LATEST END JALONNEMENT")
        ClassifsStrings.Add("QUANTITY")
        ClassifsStrings.Add("AUTO SEQ RESTRICT")
        ClassifsStrings.Add("FORCE WINDOW")
        ClassifsStrings.Add("SEQ WINDOW")
        ClassifsStrings.Add("PROCESS TIME JALONNEMENT")
        ClassifsStrings.Add("START OFFSET")
        ClassifsStrings.Add("END OFFSET")
        ClassifsStrings.Add("SETUP TIME JALONNEMENT")
        ClassifsStrings.Add("OPERATION PROGRESS JALONNEMENT")
        ClassifsStrings.Add("RESOURCE DATA JALONNEMENT")
    End Sub

End Class
