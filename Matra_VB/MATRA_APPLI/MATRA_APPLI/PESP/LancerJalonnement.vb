Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("19539b77-9a0a-430f-8307-95c5048a7f64", "e3edf48a-d2ac-4066-86b5-3ca94ef812f1")> _
Public Class LancerJalonnement
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        Dim Jalonnement As New Jalonnement
        Jalonnement.Run(preactorComObject, pespComObject)

        Return 0
    End Function
End Class
