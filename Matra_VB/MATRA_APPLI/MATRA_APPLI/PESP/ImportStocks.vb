Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("c520e0d5-03f8-462d-8114-90a48a8cfe84", "0806a9b9-9610-4da5-acb3-78f225b03a43")> _
Public Class ImportStocks
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        Run_ImportStocks(preactor)

        Return 0
    End Function
End Class
