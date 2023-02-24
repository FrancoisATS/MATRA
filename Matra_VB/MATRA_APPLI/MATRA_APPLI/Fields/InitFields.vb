Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("a84cc7a2-d0bc-4d9e-9d9f-66376bb76556", "ead27de8-8550-447f-bd66-01f42560d6bd")> _
Public Class InitFields
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        Fields.init(preactor)

        Return 0
    End Function
End Class
