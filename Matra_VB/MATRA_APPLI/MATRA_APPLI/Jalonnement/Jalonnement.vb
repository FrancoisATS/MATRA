Option Strict On
Option Explicit On

Imports Preactor.Interop.PreactorObject
Imports Preactor

Imports System.Runtime.InteropServices
<ComVisible(True)>
<Microsoft.VisualBasic.ComClass("6a0c85a4-a12d-462d-a0ac-e81841375f9b", "91b8e990-32bb-4581-8078-b6aac51416d7")>
Public Class Jalonnement
#Region "Variables"
    ' Preactor vars
    Private PR As IPreactor
    Private pb As IPlanningBoard

    ' For dates calculation
    Dim EtatCourant As Nullable(Of Preactor.CalendarState)
    Dim EtatPrecedent As Nullable(Of Preactor.CalendarState)
    Dim ChangementEtat As Nullable(Of Preactor.CalendarStateChange)

    ' For dict and lists initialization
    Private MyOrdersList As List(Of Pr_OrdersJalon.Tbl)
    Private MyResourcesList As List(Of Pr_ResourcesJalon.Tbl)

    Private MyMarginDict As Dictionary(Of Integer, Double)
    Private ResNoRecDict As Dictionary(Of Integer, Integer)

    Private PrevOpDict As Dictionary(Of Integer, List(Of Integer))
    Private NextOpDict As Dictionary(Of Integer, List(Of Integer))

    Private MyJalonVar As Jalon_Variables
    Private OpJalonVarDict As New Dictionary(Of Integer, Jalon_Variables)

    Private MyOrdersCount As Integer
    Private JalonVar As New Dictionary(Of String, Integer)
#End Region

#Region "Run"
    ''' <summary>
    ''' Run the jalonnement
    ''' </summary>
    ''' <param name="preactorComObject"></param>
    ''' <param name="pespComObject"></param>
    ''' <returns></returns>
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        ' Init Preactor var
        PR = PreactorFactory.CreatePreactorObject(preactorComObject)
        pb = PR.PlanningBoard

        ' Check classifications existance
        Dim MyCheckClassif As New CheckClassif
        If Not MyCheckClassif.RunCheck(PR) Then Return 0

        ' Init lists
        Init_Lists()

        ' Init operations
        Init_Operations()

        'Jalonnement
        PR.DisplayStatus("Jalonnement", "Ecriture des dates")
        For Each order In MyOrdersList
            PR.UpdateStatus(order.Record, MyOrdersCount)
            Dim ActualDueDate = Pr_OrdersJalon.GetRecord(order.Record).ActualDueDate
            If pb.GetNextOperation(order.Record, 1) < 0 Then Jalon_Ope(order.Record, ActualDueDate)
        Next
        PR.DestroyStatus()

        Dim Utilisation = pb.GetUtilisationData(1, pb.TerminatorTime, pb.TerminatorTime.AddDays(1))

        ' Commit
        'PR.Commit(Pr_OrdersJalon.Table, "Schedule")

        Return 0
    End Function
#End Region

#Region "Initilization"
    ''' <summary>
    ''' Initialize the different lists
    ''' </summary>
    Private Sub Init_Lists()
        PR.DisplayStatus("Jalonnement", "Initialisation des listes")

        FieldsJalonnement.init(PR)
        Pr_ResourcesJalon.Init_List()
        Pr_OrdersJalon.Init_List()
        MyOrdersList = Pr_OrdersJalon.ToList
        MyResourcesList = Pr_ResourcesJalon.ToList

        ' Init marge jalonnement
        MyMarginDict = New Dictionary(Of Integer, Double)
        ResNoRecDict = New Dictionary(Of Integer, Integer)
        JalonVar.Clear()

        For Each res In MyResourcesList
            ResNoRecDict.Add(res.Number, res.Record)
            'MyMarginDict.Add(res.Record, res.MargeJalonnement)

        Next

        FillMarginDict()

        PR.DestroyStatus()
    End Sub
    ''' <summary>
    ''' Function which allows to get, for a selected operation and a selected resource, its margin
    ''' </summary>
    Private Sub FillMarginDict()
        Dim MargeJalTable = Pr_MargeJalJalon.FFPMargeJal.FormatNumber
        If MargeJalTable = Pr_ResourcesJalon.Table Then
            For Each res In MyResourcesList
                MyMarginDict.Add(res.Record, PR.ReadFieldDouble(Pr_MargeJalJalon.FFPMargeJal, res.Record))
            Next
        ElseIf MargeJalTable = Pr_OrdersJalon.Table Then

            For Each op In MyOrdersList
                MyMarginDict.Add(op.Record, PR.ReadFieldDouble(Pr_MargeJalJalon.FFPMargeJal, op.Record))
            Next
        Else
            MyMarginDict.Add(0, PR.ReadFieldDouble(Pr_MargeJalJalon.FFPMargeJal, 1))
        End If
    End Sub

    ''' <summary>
    ''' Initialize the different informations needed for the operations
    ''' </summary>
    Private Sub Init_Operations()
        PR.DisplayStatus("Jalonnement", "Initialisation opérations")

        MyOrdersCount = MyOrdersList.Count
        NextOpDict = New Dictionary(Of Integer, List(Of Integer))
        PrevOpDict = New Dictionary(Of Integer, List(Of Integer))

        'MyOrdersList.OrderByDescending(Function(x) x.Record)

        For Each order In MyOrdersList
            PR.UpdateStatus(order.Record, MyOrdersCount)
            FillDictOp(order, True) ' Dict for previous operations
            FillDictOp(order, False) ' Dict for next operations
            Init_Ope(order.Record) ' Initialize operations
            ResetDates(order)
        Next

        PR.DestroyStatus()
    End Sub

    ''' <summary>
    ''' Sets the jalonnement dates to -1 for the operation
    ''' </summary>
    ''' <param name="order"></param>
    Private Sub ResetDates(ByVal order As Pr_OrdersJalon.Tbl)
        PR.WriteField(Pr_OrdersJalon.EarliestStartCustom, order.Record, -1)
        PR.WriteField(Pr_OrdersJalon.LatestEndCustom, order.Record, -1)
        PR.WriteField(Pr_OrdersJalon.LatestStartCustom, order.Record, -1)
    End Sub

    ''' <summary>
    ''' Fills the next and previous dictionaries
    ''' </summary>
    ''' <param name="order"></param>
    ''' <param name="direction"></param>
    Private Sub FillDictOp(ByVal order As Pr_OrdersJalon.Tbl, ByVal direction As Boolean)
        ' Get the operations before or after the current op
        Dim CurrentOp As Integer
        Dim Index = 1
        Dim CurrentOpList As New List(Of Integer)



        Do

            ' Select according to direction
            If direction Then
                CurrentOp = pb.GetPreviousOperation(order.Record, Index)
            Else
                CurrentOp = pb.GetNextOperation(order.Record, Index)
            End If

            ' Create list
            If CurrentOp < 0 Then Exit Do



            Index += 1
            CurrentOpList.Add(CurrentOp)
        Loop

        ' Fill in the right dictionary
        Dim CurrentOpListCopy As New List(Of Integer)(CurrentOpList)
        If direction Then


            PrevOpDict.Add(order.Record, CurrentOpListCopy)
        Else
            NextOpDict.Add(order.Record, CurrentOpListCopy)
        End If
    End Sub
    ''' <summary>
    ''' Initializes for one operation an object with all the information needed
    ''' </summary>
    ''' <param name="Record"></param>
    Private Sub Init_Ope(ByVal Record As Integer)
        Dim MyRecord = Pr_OrdersJalon.GetRecord(Record)

        Dim MyVariables As New Jalon_Variables
        Dim MyTime As Double = 0
        Dim Qty As Double = MyRecord.Quantity
        'Dim ResName As String
        'Dim ResRecord As Integer
        Dim RequiredRes As Boolean = False


        Dim Dic_Temps As New Dictionary(Of Integer, Double)
        If MyRecord.Required_Resource > 0 Then RequiredRes = True


        For ResPos = 0 To MyRecord.Resource_Data.Count - 1

            If (PR.ReadFieldString(Pr_Orders.Order_No, Record)) = "10105686" Then
                Dim ici = PR.ReadFieldString(Pr_Orders.Resource_Group, Record)
                If (ici = "ILOT04") Then
                    ici = ""
                End If

            End If


            'If MyRecord.Automatic_Sequencing(ResPos) Then
            Dim resourcerecord = PR.FindMatchingRecord(Pr_Resources.Number, 0, MyRecord.Resource_Data(ResPos))
                Dim recordcalendar = PR.FindMatchingRecord(Pr_Primary_Calendar_Periods.Resource, 0, PR.ReadFieldString(Pr_Resources.Name, resourcerecord))
                While recordcalendar > 0
                    If (PR.ReadFieldInt(Pr_Primary_Calendar_Periods.Is_Exception, recordcalendar) = 1) Then
                        Dic_Temps.Add(ResNoRecDict(MyRecord.Resource_Data(ResPos)), MyRecord.Real_Op_Time_Per_Item.Item(ResPos))
                        Exit While
                    End If
                    recordcalendar = PR.FindMatchingRecord(Pr_Primary_Calendar_Periods.Resource, recordcalendar, PR.ReadFieldString(Pr_Resources.Name, resourcerecord))
                End While




        Next

        If Dic_Temps.Count > 0 Then
            MyTime = (Dic_Temps.Values.Min + Dic_Temps.Values.Max) / 2
        End If

        ' Fill the jalon var and fill dictionary
        MyVariables.Dic_Resource_Temps = Dic_Temps
        MyVariables.Temps_Proces = PR.ReadFieldDouble(Pr_Orders.Batch_Time, Record)
        MyVariables.Qty = Qty
        MyVariables.Chevauchement = MyRecord.Chevauchement
        MyVariables.Temps_Transfert = MyRecord.Temps_Transfert
        MyVariables.Temps_Setup = MyRecord.Temps_Setup
        MyVariables.DelaiInterOperation = MyRecord.DelaiInterOperation
        OpJalonVarDict.Add(Record, MyVariables)

    End Sub
#End Region

#Region "Global calculation launch"
    ''' <summary>
    ''' Calculates the jalonnement dates for the specified Record
    ''' </summary>
    ''' <param name="Record"></param>
    Private Sub Jalon_Ope(ByVal Record As Integer, ByVal ActualDueDate As Date)
        If ActualDueDate.ToOADate < 0 Then Exit Sub

        MyJalonVar = OpJalonVarDict.Item(Record)

        CalculateLatestEnd(Record, ActualDueDate)
        CalculateLatestStart(Record, ActualDueDate)
        '  CalculateEarliestStart(Record)

        ' Calculate for previous operations
        Jalon_Ope_Prec(Record)

    End Sub

    ''' <summary>
    ''' Calculate Latest End
    ''' </summary>
    ''' <param name="Record"></param>
    ''' <param name="ActualDueDate"></param>
    Private Sub CalculateLatestEnd(ByVal Record As Integer, ByRef ActualDueDate As Date)



        If PR.ReadFieldDouble(Pr_OrdersJalon.Operation_Progress, Record) = 2 Then ' Non commence ->2
            Dim Original_Fin_Plus_tard As DateTime = PR.ReadFieldDateTime(Pr_OrdersJalon.LatestEndCustom, Record)

            If Original_Fin_Plus_tard.ToOADate = -1 Or Original_Fin_Plus_tard >= ActualDueDate Then

                ActualDueDate = ActualDueDate.AddDays(-MyJalonVar.Temps_Transfert)
                If (PR.ReadFieldString(Pr_OrdersJalon.LatestEndCustom, Record) = "Indéfini") Then
                    PR.WriteField(Pr_OrdersJalon.LatestEndCustom, Record, ActualDueDate)
                Else
                    If (PR.ReadFieldDateTime(Pr_OrdersJalon.LatestEndCustom, Record) > ActualDueDate) Then
                        PR.WriteField(Pr_OrdersJalon.LatestEndCustom, Record, ActualDueDate)
                    End If
                End If

                    Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub

    ''' <summary>
    ''' Calculate latest start
    ''' </summary>
    ''' <param name="Record"></param>
    ''' <param name="ActualDueDate"></param>
    Private Sub CalculateLatestStart(ByVal Record As Integer, ByRef ActualDueDate As Date)

        If (PR.ReadFieldString(Pr_Orders.Order_No, Record) = "10107533") Then
            Dim ici = ""
        End If
        Dim Temps_Operation As Double
        'If MyJalonVar.Chevauchement > -1 Then
        '    If MyJalonVar.Chevauchement > MyJalonVar.Qty Then
        '        MyJalonVar.Chevauchement = MyJalonVar.Qty
        '    End If
        '    If (MyJalonVar.DelaiInterOperation > 0) Then
        '        Dim ici = ""
        '    End If
        '    Temps_Operation = MyJalonVar.DelaiInterOperation + MyJalonVar.Temps_Setup + (MyJalonVar.Temps_Proces) - (MyJalonVar.Temps_Proces * MyJalonVar.Chevauchement)
        'Else

        Temps_Operation = MyJalonVar.Temps_Setup + (MyJalonVar.Temps_Proces)
        'End If

        If Temps_Operation < 0 Then Temps_Operation = 0

        Dim MyDate As DateTime
        If MyJalonVar.Temps_Transfert > 0 And NextOpDict.ContainsKey(Record) Then
            'MyDate = Calcul_Date_Deb_Plus_Tard(ActualDueDate.AddDays(-MyJalonVar.Temps_Transfert), MyJalonVar)
            MyDate = CalculateDate(Record, ActualDueDate, 2)
        Else
            'MyDate = Calcul_Date_Deb_Plus_Tard(ActualDueDate, MyJalonVar)
            MyDate = CalculateDate(Record, ActualDueDate, 2)
        End If

        If (PR.ReadFieldString(Pr_OrdersJalon.LatestStartCustom, Record) = "Indéfini") Then
            PR.WriteField(Pr_OrdersJalon.LatestStartCustom, Record, MyDate)
        Else
            If (PR.ReadFieldDateTime(Pr_OrdersJalon.LatestStartCustom, Record) > MyDate) Then
                PR.WriteField(Pr_OrdersJalon.LatestStartCustom, Record, MyDate)
            End If
        End If



    End Sub

    ''' <summary>
    ''' Calculate earliest start
    ''' </summary>
    ''' <param name="Record"></param>
    Private Sub CalculateEarliestStart(ByVal Record As Integer)
        Dim MyNewDate = PR.ReadFieldDateTime(Pr_OrdersJalon.LatestStartCustom, Record)
        'Dim MyDate = Calcul_Date_Deb_Plus_Tot(MyNewDate, MyJalonVar)
        Dim MyDate = CalculateDate(Record, MyNewDate, 1)
        If MyDate.ToOADate <= 0 Then
            PR.WriteField(Pr_OrdersJalon.EarliestStartCustom, Record, -1)
        Else
            PR.WriteField(Pr_OrdersJalon.EarliestStartCustom, Record, MyDate)
        End If

    End Sub

    ''' <summary>
    ''' For all the previous ops, calculate the dates
    ''' </summary>
    ''' <param name="Record"></param>
    Private Sub Jalon_Ope_Prec(ByVal Record As Integer)
        'Dim MyDate = Pr_OrdersJalon.GetRecord(Record).LatestStartCustom
        Dim MyDate = PR.ReadFieldDateTime(Pr_OrdersJalon.LatestStartCustom, Record)
        If PrevOpDict.ContainsKey(Record) Then
            Dim Mylist As List(Of Integer) = PrevOpDict.Item(Record)
            For i As Integer = 0 To Mylist.Count - 1
                Jalon_Ope(Mylist.Item(i), MyDate)
            Next
        Else
            PR.WriteField(Pr_OrdersJalon.EarliestStartCustom, Record, MyDate)
        End If
    End Sub
#End Region

#Region "Core Dates Calculation"


    ''' <summary>
    ''' Calculation type : 1 for earliest start, 2 for latest start, 3 for latest end
    ''' </summary>
    ''' <param name="Record"></param>
    ''' <param name="MyDateInit"></param>
    ''' <param name="CalculationType"></param>
    ''' <returns></returns>
    Private Function CalculateDate(ByVal Record As Integer, ByVal MyDateInit As Date, ByVal CalculationType As Integer) As Date
        ' Get the jalon variable associated to the record
        Dim Var = OpJalonVarDict.Item(Record)

        Dim Temps_Operation As Double

        Try



            ' In case date NOK return previous date
            If IsNothing(Var.Dic_Resource_Temps) Then Return MyDateInit

            If MyDateInit < pb.TerminatorTime Then

                Select Case CalculationType
                    Case 1
                        If Var.Dic_Resource_Temps.Count > 0 Then
                            Temps_Operation = GetMargin(Record, Var.Dic_Resource_Temps.Keys.First)
                        Else
                            Temps_Operation = -1
                        End If
                        If Temps_Operation < 0 Then
                            Return Nothing
                        Else
                            Return MyDateInit.AddDays(-Temps_Operation)
                        End If
                    Case Else
                        If Var.Chevauchement > -1 Then
                            If Var.Chevauchement > Var.Qty Then
                                Var.Chevauchement = Var.Qty
                            End If
                            Temps_Operation = Var.Temps_Setup + ((Var.Temps_Proces)) - (Var.Temps_Proces * Var.Chevauchement)
                        Else
                            Temps_Operation = Var.Temps_Setup + ((Var.Temps_Proces))
                        End If

                        Return MyDateInit.AddDays(-Temps_Operation)
                End Select

            End If

            Dim L_Calcul As New List(Of DateTime)

            ' for each resource
            For Each Key In Var.Dic_Resource_Temps.Keys
                EtatCourant = pb.GetCurrentCalendarState(Key, MyDateInit)
                Dim Efficacite As Double
                If EtatCourant Is Nothing Then
                    Efficacite = 0
                Else
                    Efficacite = EtatCourant.Value.Efficiency
                End If
                MyDateInit = MyDateInit.AddDays(pb.SchedulingAccuracy)


                Dim MyDate As DateTime = MyDateInit
                Dim MyOldChangeStart As DateTime
                If Efficacite = 0 Then

                    GetPreviousOpening(MyOldChangeStart, MyDate, Efficacite, Key)

                    ' Part changing in the different calculations
                    If ChangementEtat IsNot Nothing And MyDate > MyDateInit.AddDays(-300) Then
                        Select Case CalculationType
                            Case 1
                                ' Earliest start
                                MyDate = MyDate.AddDays(-100 * pb.SchedulingAccuracy())
                            Case 2
                                ' Latest start
                                MyDate = MyOldChangeStart.AddDays(pb.SchedulingAccuracy())
                            Case 3
                                ' Latest end
                                L_Calcul.Add(MyOldChangeStart)
                                Continue For
                        End Select
                    End If

                Else
                    EtatPrecedent = EtatCourant.Value
                End If

                Dim MyDateJalon As DateTime = MyDate
                Dim TotalTemps As Double = 0

                ' Calculation fo the temps manquante
                Dim TempsManquante As Double
                Select Case CalculationType
                    Case 1
                        'TempsManquante = MyMarginDict(Key)
                        TempsManquante = GetMargin(Record, Key)
                        If TempsManquante < 0 Then
                            Return Nothing
                        End If
                    Case 2
                        If Var.Chevauchement > -1 Then
                            If Var.Chevauchement > Var.Qty Then
                                Var.Chevauchement = Var.Qty
                            End If
                            TempsManquante = Var.Temps_Setup + ((Var.Temps_Proces)) - (Var.Temps_Proces * Var.Chevauchement)
                        Else
                            TempsManquante = Var.Temps_Setup + ((Var.Temps_Proces))
                        End If
                    Case 3
                        Continue For
                End Select

                Do
                    ChangementEtat = pb.GetPreviousCalendarState(Key, MyDate.AddSeconds(-1))
                    If Not ChangementEtat.HasValue Then
                        Exit Do
                    Else
                        Efficacite = ChangementEtat.Value.CurrentState.Efficiency
                        TotalTemps = TotalTemps + ((Efficacite * DateDiff(DateInterval.Second, ChangementEtat.Value.ChangeTime, MyDate)) / (3600 * 2400))
                        MyDate = ChangementEtat.Value.ChangeTime
                    End If
                Loop Until TotalTemps > TempsManquante

                If TotalTemps > TempsManquante Then
                    Dim TempsRestant = TotalTemps - TempsManquante
                    L_Calcul.Add(MyDate.AddDays(TempsRestant * 100 / Efficacite))
                End If
            Next







            Dim datemax = 0.0

            For i As Integer = 0 To L_Calcul.Count - 1
                If L_Calcul.Item(i).ToOADate > datemax Then
                    datemax = L_Calcul.Item(i).ToOADate
                End If
            Next

            If datemax > 0 Then
                Return Date.FromOADate(datemax)
            End If


        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

        Return MyDateInit

    End Function
#End Region

#Region "Tools"
    Private Function GetMargin(ByVal Record As Integer, ByVal Resource As Integer) As Double
        Dim MargeJalTable = Pr_MargeJalJalon.FFPMargeJal.FormatNumber
        If MargeJalTable = Pr_ResourcesJalon.Table Then
            Return MyMarginDict(Resource)
        ElseIf MargeJalTable = Pr_OrdersJalon.Table Then
            Return MyMarginDict(Record)
        Else
            Return MyMarginDict(0)
        End If
    End Function

    Private Sub GetPreviousOpening(ByRef MyOldChangeStart As DateTime, ByRef MyDate As DateTime, ByRef Efficacite As Double, ByVal Resource As Integer)
        Do
            MyOldChangeStart = MyDate
            ChangementEtat = pb.GetPreviousCalendarState(Resource, MyDate)
            If Not ChangementEtat.HasValue Then
                Exit Do
            Else
                EtatPrecedent = ChangementEtat.Value.CurrentState
                MyDate = ChangementEtat.Value.ChangeTime
                Efficacite = EtatPrecedent.Value.Efficiency
            End If
        Loop Until Efficacite > 0
    End Sub
#End Region

End Class
