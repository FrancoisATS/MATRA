Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("cd6de520-9345-435a-acec-2a0090362c29", "15f2b20e-7c6c-43ae-8fdd-9eb96e3470ee")> _
Public Class Message
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)
        Dim planningboard = preactor.PlanningBoard
        Dim user = preactor.ParseShellString("{USER NAME}")
        Dim heure = DateTime.Now

        Dim message = "Le planning a été enregistré par " + user + " à " + heure.ToString
        Dim PESP_Extensions As IEventScriptsCore = EventScriptsFactory.CreateEventScriptCoreObject(preactorComObject, pespComObject)

        PESP_Extensions.WriteScriptVariable("Message", message)


        Return 0
    End Function
End Class
