Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("43d27340-bf65-4dad-bb14-a44fbbbd6074", "bf35fe36-1e54-411f-b4ab-bbe097fb0efc")> _
Public Class AfterSMC
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)
        Dim planningboard = preactor.PlanningBoard

        For i = 1 To preactor.RecordCount(Pr_Orders.Table)
            Dim record = planningboard.GetPreviousOperation(i, 1)
            If (record > 0) Then
                preactor.WriteField(Pr_Orders.IlotPrecedent, i, preactor.ReadFieldString(Pr_Orders.Resource_Group, record))

                If (preactor.ReadFieldString(Pr_Orders.Resource_Group, i) <> preactor.ReadFieldString(Pr_Orders.Resource_Group, record)) Then

                    If (preactor.ReadFieldString(Pr_Orders.Table_Attribute_1, i) <> "PRIO_PROD") Then
                        preactor.WriteField(Pr_Orders.TempsAttente, i, 4 / 24.0)
                    Else
                        preactor.WriteField(Pr_Orders.TempsAttente, i, 2 / 24.0)
                    End If

                Else
                    preactor.WriteField(Pr_Orders.IlotPrecedent, i, preactor.ReadFieldString(Pr_Orders.Resource_Group, i))
                    preactor.WriteField(Pr_Orders.TempsAttente, i, 0.0)
                End If
            Else
                preactor.WriteField(Pr_Orders.IlotPrecedent, i, preactor.ReadFieldString(Pr_Orders.Resource_Group, i))
                preactor.WriteField(Pr_Orders.TempsAttente, i, 0.0)
            End If



            If (preactor.ReadFieldString(Pr_Orders.Table_Attribute_1, i) = "OF_BLOQUE") Then
                planningboard.UnallocateOperation(i, OperationSelection.ThisOperation)
                preactor.WriteField(Pr_Orders.Resource, i, -1)
                preactor.WriteField(Pr_Orders.Start_Time, i, -1)
                preactor.WriteField(Pr_Orders.Setup_Start, i, -1)
                preactor.WriteField(Pr_Orders.End_Time, i, -1)
                preactor.WriteField(Pr_Orders.Table, "Planifier", i, 0)
            End If
            preactor.WriteField(Pr_Orders.Sous_ensemble, i, 1)
        Next

        Dim dapt = DateTime.Now

        For i = 1 To preactor.RecordCount(Pr_Orders.Table)

            If (preactor.ReadFieldString(Pr_Orders.Resource, i) <> "Indéfini" And preactor.ReadFieldString(Pr_Orders.Resource, i) = "ILOT71-01" And preactor.ReadFieldString(Pr_Orders.Operation_Progress, i) = "En cours") Then

                If (preactor.ReadFieldDateTime(Pr_Orders.End_Time, i) > dapt) Then
                    dapt = preactor.ReadFieldDateTime(Pr_Orders.End_Time, i)
                End If


            End If

        Next

        For i = 1 To preactor.RecordCount(Pr_Orders.Table)

            If (preactor.ReadFieldString(Pr_Orders.Resource_Group, i) = "ILOT71") And preactor.ReadFieldString(Pr_Orders.Operation_Progress, i) <> "En cours" Then


                preactor.WriteField(Pr_Orders.Earliest_Start_Date, i, dapt)



            End If

        Next




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
