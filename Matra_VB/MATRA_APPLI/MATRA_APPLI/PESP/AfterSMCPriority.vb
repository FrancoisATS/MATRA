Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("2b73dc83-040b-4992-b6d7-b375c4cc7571", "3a9c34c8-bb41-4133-80b2-f75f3cedea15")> _
Public Class AfterSMCPriority
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)


        Pr_Order_Links.Init_List()
        Pr_Orders.Init_List2()
        Pr_Demand.Init_List()
        Dim ListLinks = Pr_Order_Links.ToList
        Dim ListOrders = Pr_Orders.ToList
        Dim ListOrders2 = Pr_Demand.ToList

        For i = 1 To preactor.RecordCount(Pr_Orders.Table)
            preactor.WriteField(Pr_Orders.Priority, i, 999999)
            If (preactor.ReadFieldString(Pr_Orders.CodeCondition, i) = "SAV") Then
                preactor.WriteField(Pr_Orders.Sous_ensemble, i, 0)
            End If

        Next

        Dim query = From order In ListOrders
                    Where order.Statut_Operation = "Partiellement declare" AndAlso order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Table_Attribute_1 = "PRIO_PROD" AndAlso order.Belongs_to_Order_No = "PARENT"
                    Order By order.Latest_Start_Date
                    Select order
        Dim priorite = 0

        'On recherce les partiellement badgé
        For Each Item In query
            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If


        Next


        Dim query2 = From order In ListOrders
                     Where order.Statut_Operation = "Partiellement declare" AndAlso order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Belongs_to_Order_No = "PARENT"
                     Order By order.Latest_Start_Date
                     Select order


        'On recherce les partiellement badgé
        For Each Item In query2
            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If


        Next


        Dim query3 = From order In ListOrders
                     Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Table_Attribute_1 = "PRIO_PROD" AndAlso order.Belongs_to_Order_No = "PARENT" AndAlso order.Client.Contains("PROTO") AndAlso order.Statut_Ordre = "Debute"
                     Order By order.Latest_Start_Date
                     Select order


        'On recherce les partiellement badgé
        For Each Item In query3
            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If


        Next








        Dim query5 = From order In ListOrders
                     Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Table_Attribute_1 = "PRIO_PROD" AndAlso order.Belongs_to_Order_No = "PARENT" AndAlso order.CodeCondition = "SAV" AndAlso order.Statut_Ordre = "Debute"
                     Order By order.Latest_Start_Date
                     Select order


        'On recherce les partiellement badgé
        For Each Item In query5
            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If


        Next






        Dim query7 = From order In ListOrders
                     Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Table_Attribute_1 = "PRIO_PROD" AndAlso order.Belongs_to_Order_No = "PARENT" AndAlso order.Statut_Ordre = "Debute"
                     Order By order.Latest_Start_Date
                     Select order


        'On recherce les partiellement badgé
        For Each Item In query7
            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If


        Next





        Dim query9 = From order In ListOrders
                     Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Belongs_to_Order_No = "PARENT" AndAlso order.Client.Contains("PROTO") AndAlso order.Statut_Ordre = "Debute"
                     Order By order.Latest_Start_Date
                     Select order


        'On recherce les partiellement badgé
        For Each Item In query9
            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If


        Next


        Dim query4 = From order In ListOrders
                     Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Table_Attribute_1 = "PRIO_PROD" AndAlso order.Belongs_to_Order_No = "PARENT" AndAlso order.Client.Contains("PROTO") AndAlso order.Statut_Ordre = "Reserve"
                     Order By order.Latest_Start_Date
                     Select order


        'On recherce les partiellement badgé
        For Each Item In query4
            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If


        Next


        Dim query6 = From order In ListOrders
                     Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Table_Attribute_1 = "PRIO_PROD" AndAlso order.Belongs_to_Order_No = "PARENT" AndAlso order.CodeCondition = "SAV" AndAlso order.Statut_Ordre = "Reserve"
                     Order By order.Latest_Start_Date
                     Select order


        'On recherce les partiellement badgé
        For Each Item In query6
            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If

        Next

        Dim query8 = From order In ListOrders
                     Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Table_Attribute_1 = "PRIO_PROD" AndAlso order.Belongs_to_Order_No = "PARENT" AndAlso order.Statut_Ordre = "Reserve"
                     Order By order.Latest_Start_Date
                     Select order


        'On recherce les partiellement badgé
        For Each Item In query8
            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If


        Next

        Dim query11 = From order In ListOrders
                      Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Belongs_to_Order_No = "PARENT" AndAlso order.Client.Contains("PROTO") AndAlso order.Statut_Ordre = "Reserve"
                      Order By order.Latest_Start_Date
                      Select order


        'On recherce les partiellement badgé
        For Each Item In query11
            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If


        Next




        Dim query12 = From order In ListOrders
                      Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Table_Attribute_1 = "PRIO_PROD" AndAlso order.Belongs_to_Order_No = "PARENT" AndAlso order.Client.Contains("PROTO")
                      Order By order.Latest_Start_Date
                      Select order


        'On recherce les partiellement badgé
        For Each Item In query12
            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1

            End If

        Next



        Dim query13 = From order In ListOrders
                      Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Table_Attribute_1 = "PRIO_PROD" AndAlso order.Belongs_to_Order_No = "PARENT" AndAlso order.CodeCondition = "SAV"
                      Order By order.Latest_Start_Date
                      Select order

        'On recherce les partiellement badgé
        For Each Item In query13
            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If


        Next




        Dim query14 = From order In ListOrders
                      Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Table_Attribute_1 = "PRIO_PROD" AndAlso order.Belongs_to_Order_No = "PARENT"
                      Order By order.Latest_Start_Date
                      Select order


        'On recherce les partiellement badgé
        For Each Item In query14
            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If


        Next




        Dim query15 = From order In ListOrders
                      Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Belongs_to_Order_No = "PARENT" AndAlso order.CodeCondition = "SAV"
                      Order By order.Latest_Start_Date
                      Select order
        'On recherce les partiellement badgé
        For Each Item In query15

            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If
        Next




        Dim query17 = From order In ListOrders
                      Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Belongs_to_Order_No = "PARENT" AndAlso order.Statut_Ordre = "Debute"
                      Order By order.Latest_Start_Date
                      Select order
        'On recherce les partiellement badgé
        For Each Item In query17

            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If
        Next


        Dim query18 = From order In ListOrders
                      Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Belongs_to_Order_No = "PARENT" AndAlso order.Statut_Ordre = "Reserve"
                      Order By order.Latest_Start_Date
                      Select order
        'On recherce les partiellement badgé
        For Each Item In query18

            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If
        Next





        Dim query19 = From order In ListOrders
                      Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Statut_Ordre = "Debute"
                      Order By order.Latest_Start_Date
                      Select order
        'On recherce les partiellement badgé
        For Each Item In query19

            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If
        Next


        Dim query20 = From order In ListOrders
                      Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False AndAlso order.Statut_Ordre = "Reserve"
                      Order By order.Latest_Start_Date
                      Select order
        'On recherce les partiellement badgé
        For Each Item In query20

            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If
        Next




        Dim query21 = From order In ListOrders
                      Where order.Table_Attribute_1 <> "OF_BLOQUE" AndAlso order.SupportVisualisation = False
                      Order By order.Latest_Start_Date
                      Select order
        'On recherce les partiellement badgé
        For Each Item In query21

            If (preactor.ReadFieldInt(Pr_Orders.Priority, Item.Record) = 999999) Then
                preactor.WriteField(Pr_Orders.Priority, Item.Record, priorite)
                priorite = priorite + 1
            End If
        Next




        Return 0
    End Function
End Class
