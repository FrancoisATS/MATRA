Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor



<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("42475813-c4a0-4658-8830-5bdb1be2b894", "1b0d879f-ec3a-40f2-a5ce-61bbb5cda848")> _
Public Class AfterSMCCommande
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)
        Dim planningboard = preactor.PlanningBoard

        preactor.Clear("Lien")

        For i = 1 To preactor.RecordCount(Pr_Orders.Table)
            preactor.WriteField(Pr_Orders.Table, "Commande", i, "")
            preactor.WriteField(Pr_Orders.Date_Attribute_2, i, "Indéfini")
        Next
        ''preactor.Commit(Pr_Order_Links.Table, "SCHEDULE")
        '''Recuperation des bons orders links
        ''preactor.Load(Pr_Order_Links.Table, "SCHEDULE")
        ''preactor.Load(Pr_Orders.Table, "SCHEDULE")
        Pr_Order_Links.Init_List()
        Pr_Orders.Init_List2()
        Pr_Demand.Init_List()
        Dim ListLinks = Pr_Order_Links.ToList
        Dim ListOrders = Pr_Orders.ToList
        Dim ListOrders2 = Pr_Demand.ToList


        Dim query10 = From link In ListLinks
                      Join Order In ListOrders
                                     On Order.Number Equals link.From_Internal_Supply_Order
                      Join Demand In ListOrders2
                                    On Demand.Number Equals link.To_External_Demand_Order
                      Order By Demand.Demand_Date
                      Select Order.Order_No.ToString + ";" + Demand.Demand_Date.ToString + ";" + Demand.Order_No.ToString

        query10 = query10.Distinct

        Dim index = 0
        Dim OFLie = ""
        Dim ListVariable = New List(Of Variables.AffectationDateCommande)

        For Each item In query10
            Dim Variable As Variables.AffectationDateCommande = New Variables.AffectationDateCommande
            Variable.Ordre = item.Split(";"c)(0).ToString
            Variable.DateOrdre = Convert.ToDateTime(item.Split(";"c)(1))
            Variable.Commande = item.Split(";"c)(2).ToString
            ListVariable.Add(Variable)
        Next

        index = 0

        For Each item In ListVariable

            Dim Record = preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, item.Ordre)


            If (Record > 0) Then
                If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, Record) = "Indéfini") Then
                    preactor.WriteField(Pr_Orders.Date_Attribute_2, Convert.ToInt32(Record), item.DateOrdre)
                    preactor.WriteField(Pr_Orders.Table, "Commande", Convert.ToInt32(Record), item.Commande)
                    preactor.WriteField(Pr_Orders.Sous_ensemble, Record, 0)
                End If

            End If

        Next




        For Each item In ListVariable

            Dim Record = preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, item.Ordre)





            If (Record > 0) Then
                preactor.WriteField(Pr_Orders.Date_Attribute_2, Convert.ToInt32(Record), item.DateOrdre)
                preactor.WriteField(Pr_Orders.Table, "Commande", Convert.ToInt32(Record), item.Commande)


                Dim ListRecord = New List(Of String)
                ParcoursOperation2(ListRecord, Record, preactor, planningboard)

                ListRecord.Add(Record.ToString)


                For Each item2 In ListRecord
                    If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, Convert.ToInt32(item2)) = "Indéfini") Then
                        preactor.WriteField(Pr_Orders.Date_Attribute_2, Convert.ToInt32(item2), item.DateOrdre)
                    End If
                Next

                For Each item3 In ListRecord

                    Dim Record5 = preactor.CreateRecord("Lien")
                    Dim RecordCommande = preactor.FindMatchingRecord(Pr_Demand.Order_No, 0, item.Commande)
                    Dim Commande = preactor.ReadFieldInt(Pr_Demand.Number, RecordCommande)
                    Dim Ordre = preactor.ReadFieldInt(Pr_Orders.Number, Convert.ToInt32(item3))


                    preactor.WriteField("Lien", "RecordCommande", Record5, Commande)
                    preactor.WriteField("Lien", "RecordOF", Record5, Ordre)
                    If (preactor.ReadFieldString(Pr_Orders.Table, "Commande", Convert.ToInt32(item3)) = "") Then

                        preactor.WriteField(Pr_Orders.Table, "Commande", Convert.ToInt32(item3), item.Commande)
                    End If
                Next


            End If

        Next



        For i = 1 To preactor.RecordCount(Pr_Orders.Table)
            If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, i) = "Indéfini") Then
                preactor.WriteField(Pr_Orders.Date_Attribute_2, i, preactor.ReadFieldDateTime(Pr_Orders.Due_Date, i))
            End If
        Next


        preactor.Commit("Lien")

        Return 0
    End Function


    Friend Function ParcoursOperation2(ByRef ListRecord As List(Of String), CurrentRecord As Integer, ByVal Preactor As IPreactor, planningboard As IPlanningBoard) As List(Of String)



        Dim NextOPeration = planningboard.GetNextOperation(CurrentRecord, 1)
        If (NextOPeration > 0) Then
            ListRecord.Add(NextOPeration.ToString)
        End If

        If (NextOPeration > 0) Then

            ParcoursOperation2(ListRecord, NextOPeration, Preactor, planningboard)
        Else
            ParcoursOperationP2(ListRecord, CurrentRecord, Preactor, planningboard, 1)
        End If



        Return ListRecord

    End Function

    Friend Function ParcoursOperationP2(ByRef ListRecord As List(Of String), CurrentRecord As Integer, ByVal Preactor As IPreactor, planningboard As IPlanningBoard, Index As Integer) As List(Of String)



        Dim PreviousOPeration = planningboard.GetPreviousOperation(CurrentRecord, Index)

        While (PreviousOPeration > 0)


            If (PreviousOPeration > 0) Then
                ListRecord.Add(PreviousOPeration.ToString)
            End If

            If (PreviousOPeration > 0) Then
                ParcoursOperationP2(ListRecord, PreviousOPeration, Preactor, planningboard, 1)
            End If
            Index = Index + 1
            PreviousOPeration = planningboard.GetPreviousOperation(CurrentRecord, Index)
        End While

        Return ListRecord

    End Function

End Class
