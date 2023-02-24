Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("a7772f13-43c2-4845-8002-c443c3f6ff15", "40b21320-664c-4e15-b10a-85a148efa4f3")> _
Public Class ImportSorties
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        Run_ImportSorties(preactor)

        Return 0
    End Function
End Class
