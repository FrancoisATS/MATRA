Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("f223c557-24e5-4bbc-99eb-b9782e8d5c50", "4350725d-e39f-417b-b9f8-b95e27586107")> _
Public Class ImportNomenclature
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        Run_ImportNomenclature(preactor)

        Return 0
    End Function
End Class
