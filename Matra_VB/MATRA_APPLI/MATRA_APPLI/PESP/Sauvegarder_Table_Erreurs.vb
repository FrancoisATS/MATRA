Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor
Imports Preactor.Interop.PreactorObject

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("a4270953-0f88-4a10-9503-2f587878806d", "cd1f0c9c-900d-47e1-a09f-6098204b0a7f")> _
Public Class Sauvegarder_Table_Erreurs
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        preactor.Commit(Pr_Erreurs.Table)

        Return 0
    End Function
End Class
