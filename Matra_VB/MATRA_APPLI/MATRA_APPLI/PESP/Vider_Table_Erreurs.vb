Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor
Imports Preactor.Interop.PreactorObject

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("bcd94894-cde1-4a1f-b1e9-bb1505a5569a", "9f88ef3a-6f5c-4ae8-9a57-cd544bf47135")> _
Public Class Vider_Table_Erreurs
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        preactor.Clear(Pr_Erreurs.Table)

        Return 0
    End Function
End Class
