Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("0727585b-5f6f-404b-8913-419239b0585a", "7f3158bc-80ab-4f69-90fc-ab9cebf26c46")> _
Public Class Import_Ressource
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        Run_ImportPostes(preactor)

        Return 0
    End Function
End Class
