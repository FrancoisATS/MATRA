Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("1748f501-6314-462f-9311-bd857cc20daa", "e228ce2c-9e93-4861-b7a2-d6130e4e7249")> _
Public Class AfterSMC2
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        Pr_Orders.Init_List2()

        Dim ListOrders = Pr_Orders.ToList

        Dim index = 0
        Dim query = From Order In ListOrders
                    Order By Order.Due_Date Ascending
                    Select Order

        For Each Item In query
            index = index + 1
            preactor.WriteField(Pr_Orders.Priority, Item.Record, index)

        Next

        Return 0
    End Function
End Class
