Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("6572f566-0679-4e65-83fe-ccb4cdeacc10", "76dd001a-92df-48ca-9be2-98cbc001c7d3")> _
Public Class EntryPoint
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        M_EntryPoint.Run(preactorComObject, pespComObject)

        Return 0
    End Function
End Class
