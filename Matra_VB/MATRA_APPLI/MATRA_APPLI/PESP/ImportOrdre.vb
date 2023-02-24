Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("21ce5eea-ba96-4cb1-afd9-05817514ea9c", "4a03665f-da5b-4349-9f29-4991cfeb056b")> _
Public Class ImportOrdre
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        Run_ImportOFs(preactor)

        Return 0
    End Function
End Class
