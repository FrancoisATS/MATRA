
Option Strict On
Option Explicit On

Imports Preactor.Interop.PreactorObject
Imports Preactor
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

<ComVisible(True)>
<Microsoft.VisualBasic.ComClass("62932c65-33a2-4086-8c39-fd22d1469a0c", "4d08f7fc-62dd-483c-a8d1-ada3fdd6ab3f")>
Public Class Algo
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        'TODO : Your code goes here

        Dim planningboard As IPlanningBoard = preactor.PlanningBoard
        If planningboard Is Nothing Then
            MessageBox.Show("This Rule must be run from the Sequencer")
            Return 0
        End If ' if the planning board wasn't available

        'On gère manuellement les évènements des presses.
        Dim EventParameters As Nullable(Of EventDetails)



        EventParameters = planningboard.NextEvent()

        While EventParameters.HasValue

            ScheduleOperations(preactor, EventParameters)

            EventParameters = planningboard.NextEvent()
        End While ' whilst there is another event

        Return 0
    End Function

    Private Sub ScheduleOperations(ByRef preactor As IPreactor, EventParameters As EventDetails?)

        Dim planningboard As IPlanningBoard = preactor.PlanningBoard
        Dim OpRecord As Integer
        Dim CurrentRank As Integer
        Dim TestOpResults As Nullable(Of Preactor.OperationTimes)
        Dim ResourceFree As Boolean

        Dim ResourceRecord As Integer
        Dim QName As String
        Dim TestEventTime As Date

        Select Case EventParameters.Value.EventType

            Case EventTypes.OperationFinished
                ' Event Parameter 1 is the Operation record that finished
                ' Event Parameter 2 is the Resource record that became available
                ' check all resources for this event because secondary constraints may have changed
                ResourceRecord = EventParameters.Value.Parameter2
                OpRecord = EventParameters.Value.Parameter1
                QName = planningboard.GetResourceQueueName(ResourceRecord)
                TestEventTime = EventParameters.Value.EventTime
            'Une opération se termine    

            'Case EventTypes.QueueChange
            '    ' Event Parameter 1 is the number of the queue that changed
            '    ' check all resources which use this queue
            '    'Exit Sub
            '    ResourceRecord = EventParameters.Value.Parameter1
            '    QName = planningboard.GetResourceQueueName(ResourceRecord)
            '    TestEventTime = EventParameters.Value.EventTime

            'Case EventTypes.ShiftChange
            '    ' Event Parameter 2 is the Resource record that had a shift change
            '    ' check the resource that had the shift change
            '    ResourceRecord = EventParameters.Value.Parameter2
            '    QName = planningboard.GetResourceQueueName(ResourceRecord)
            '    TestEventTime = EventParameters.Value.EventTime

            Case EventTypes.UserEvent
                ResourceRecord = EventParameters.Value.Parameter2
                QName = planningboard.GetResourceQueueName(ResourceRecord)
                TestEventTime = EventParameters.Value.EventTime
            Case Else

        End Select

        OpRecord = 0
        CurrentRank = 1

        ResourceFree = planningboard.IsResourceFree(ResourceRecord,
                                       TestEventTime.AddDays(planningboard.SchedulingAccuracy))

        planningboard.RankQueueByFieldName(QName, "Priority", QueueRanking.Ascending)

        While (planningboard.GetOperationInQueue(QName, CurrentRank, OpRecord) And ResourceFree)

            TestOpResults = planningboard.TestOperationOnResource(OpRecord, ResourceRecord,
                                                    TestEventTime)
            If Not TestOpResults.HasValue Then
                CurrentRank = CurrentRank + 1
                Continue While
            End If ' if the test Op didn't return a value

            'If (TestOpResults.Value.ChangeStart <= TestEventTime.AddDays(planningboard.SchedulingAccuracy)) Then

            planningboard.PutOperationOnResource(OpRecord, ResourceRecord,
                                    TestOpResults.Value.ChangeStart) ' if the operation could start now
            'Else
            'CurrentRank = CurrentRank + 1 ' increment the rank so that we test the next job in the queue
            'End If ' if the operation could start now
            ' is the resource still free at this time?
            ResourceFree = planningboard.IsResourceFree(ResourceRecord,
                                       TestEventTime.AddDays(planningboard.SchedulingAccuracy))
        End While ' whilst there is another operation in the queue
    End Sub
End Class
