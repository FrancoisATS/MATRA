Imports Preactor

Friend Class FieldsJalonnement

    Private Sub New()
    End Sub

    Friend Shared PR As IPreactor

    Friend Shared Sub init(ByVal PR As IPreactor)

        FieldsJalonnement.PR = PR

        Pr_ResourcesJalon.init(PR)
        Pr_OrdersJalon.init(PR)
        Pr_MargeJalJalon.init(PR)

    End Sub


End Class

Friend Class Pr_MargeJalJalon

    Private Sub New()
    End Sub

    Friend Shared FFPMargeJal As FormatFieldPair
    Friend Shared List As List(Of Tbl)

    Friend Shared Sub init(ByVal PR As IPreactor)
        FFPMargeJal = PR.FindFirstClassificationString("MARGE JALONNEMENT").Value
    End Sub

    Private Shared MyList As List(Of Tbl)

    Friend Shared Sub Init_List()
        MyList = New List(Of Tbl)
        Dim Records As Integer = FieldsJalonnement.PR.RecordCount(FFPMargeJal.FormatNumber)
        For Record As Integer = 1 To Records
            Dim MyItem As New Tbl
            MyItem.Record = Record

            MyList.Add(MyItem)
        Next

    End Sub

    Friend Shared ReadOnly Property ToList As List(Of Tbl)
        Get
            Return MyList
        End Get
    End Property

    Friend Shared ReadOnly Property GetRecord(ByVal Record As Integer) As Tbl
        Get
            If MyList.Count >= Record Then
                Return MyList.Item(Record - 1)
            Else
                Return Nothing
            End If
        End Get
    End Property

    Friend Structure Tbl
        Friend Record As Integer
        Friend Number As Integer

    End Structure
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class
Friend Class Pr_ResourcesJalon
    Private Sub New()
    End Sub

    Friend Shared Table As Integer

    Friend Shared Number As FormatFieldPair
    Friend Shared Name As FormatFieldPair

    Friend Shared List As List(Of Tbl)

    Friend Shared Sub init(ByVal PR As IPreactor)

        Table = PR.FindFirstClassificationString("RESOURCES TABLE").Value.FormatNumber

        Number = New FormatFieldPair(Table, PR.FindFirstClassificationString("RESOURCES TABLE").Value.FieldNumber)
        Name = New FormatFieldPair(Table, PR.FindFirstClassificationString("SEQ WINDOW").Value.FieldNumber)

    End Sub

    Private Shared MyList As List(Of Tbl)

    Friend Shared Sub Init_List()
        MyList = New List(Of Tbl)
        Dim Records As Integer = FieldsJalonnement.PR.RecordCount(Table)
        For Record As Integer = 1 To Records
            Dim MyItem As New Tbl
            MyItem.Record = Record
            MyItem.Number = FieldsJalonnement.PR.ReadFieldInt(Number, Record)

            MyList.Add(MyItem)
        Next

    End Sub

    Friend Shared ReadOnly Property ToList As List(Of Tbl)
        Get
            Return MyList
        End Get
    End Property

    Friend Shared ReadOnly Property GetRecord(ByVal Record As Integer) As Tbl
        Get
            If MyList.Count >= Record Then
                Return MyList.Item(Record - 1)
            Else
                Return Nothing
            End If
        End Get
    End Property

    Friend Structure Tbl
        Friend Record As Integer
        Friend Number As Integer
        Friend MargeJalonnement As Double
    End Structure
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class

Friend Class Pr_OrdersJalon
    Private Sub New()
    End Sub

    Friend Shared Table As Integer

    Friend Shared ActualDueDate As FormatFieldPair
    Friend Shared EarliestStartCustom As FormatFieldPair
    Friend Shared LatestStartCustom As FormatFieldPair
    Friend Shared LatestEndCustom As FormatFieldPair
    Friend Shared Quantity As FormatFieldPair
    Friend Shared Automatic_Sequencing As FormatFieldPair
    Friend Shared Required_Resource As FormatFieldPair
    Friend Shared Real_Op_Time_Per_Item As FormatFieldPair
    Friend Shared Operation_Progress As FormatFieldPair
    Friend Shared Resource_Data As FormatFieldPair
    Friend Shared Transfer_Quantity As FormatFieldPair
    Friend Shared Waiting_Time As FormatFieldPair
    Friend Shared Setup_Time As FormatFieldPair

    Friend Shared DayAdded As Integer = 0

    Friend Shared List As List(Of Tbl)

    Friend Shared Sub init(ByVal PR As IPreactor)

        Table = PR.FindFirstClassificationString("ORDERS TABLE").Value.FormatNumber

        ActualDueDate = New FormatFieldPair(Table, PR.FindFirstClassificationString("DUE DATE JALONNEMENT").Value.FieldNumber)

        Dim TestShowDate = FieldsJalonnement.PR.FindClassificationString("SHOW DATE")
        For Each element In TestShowDate
            If element.FormatNumber = ActualDueDate.FormatNumber AndAlso element.FieldNumber = ActualDueDate.FieldNumber Then
                DayAdded = 1
                Exit For
            End If
        Next


        EarliestStartCustom = New FormatFieldPair(Table, PR.FindFirstClassificationString("EARLIEST START JALONNEMENT").Value.FieldNumber)
        LatestStartCustom = New FormatFieldPair(Table, PR.FindFirstClassificationString("LATEST START JALONNEMENT").Value.FieldNumber)
        LatestEndCustom = New FormatFieldPair(Table, PR.FindFirstClassificationString("LATEST END JALONNEMENT").Value.FieldNumber)
        For Each Field In PR.FindClassificationString("QUANTITY")
            If Field.FormatNumber = Table Then
                Quantity = New FormatFieldPair(Table, Field.FieldNumber)
                Exit For
            End If
        Next
        Automatic_Sequencing = New FormatFieldPair(Table, PR.FindFirstClassificationString("AUTO SEQ RESTRICT").Value.FieldNumber)
        Required_Resource = New FormatFieldPair(Table, PR.FindFirstClassificationString("FORCE WINDOW").Value.FieldNumber)
        Real_Op_Time_Per_Item = New FormatFieldPair(Table, PR.FindFirstClassificationString("PROCESS TIME JALONNEMENT").Value.FieldNumber)
        Operation_Progress = New FormatFieldPair(Table, PR.FindFirstClassificationString("OPERATION PROGRESS JALONNEMENT").Value.FieldNumber)
        Transfer_Quantity = New FormatFieldPair(Table, PR.FindFirstClassificationString("START OFFSET").Value.FieldNumber)
        Waiting_Time = New FormatFieldPair(Table, PR.FindFirstClassificationString("END OFFSET").Value.FieldNumber)
        Setup_Time = New FormatFieldPair(Table, PR.FindFirstClassificationString("SETUP TIME JALONNEMENT").Value.FieldNumber)
        Resource_Data = New FormatFieldPair(Table, PR.FindFirstClassificationString("RESOURCE DATA JALONNEMENT").Value.FieldNumber)

    End Sub

    Private Shared MyList As List(Of Tbl)

    Friend Shared Sub Init_List()
        MyList = New List(Of Tbl)
        Dim Records As Integer = FieldsJalonnement.PR.RecordCount(Table)
        For Record As Integer = 1 To Records
            Dim MyItem As New Tbl
            MyItem.Record = Record
            MyItem.ActualDueDate = FieldsJalonnement.PR.ReadFieldDateTime(ActualDueDate, Record).AddDays(DayAdded)

            MyItem.Resource_Data = New List(Of Integer)
            MyItem.Automatic_Sequencing = New List(Of Boolean)
            MyItem.Real_Op_Time_Per_Item = New List(Of Double)

            Dim MyType = FieldsJalonnement.PR.GetFieldType(Real_Op_Time_Per_Item)

            For i = 1 To FieldsJalonnement.PR.MatrixFieldSize(Resource_Data, Record).X
                MyItem.Resource_Data.Add(FieldsJalonnement.PR.ReadFieldInt(Resource_Data, Record, i))
                MyItem.Automatic_Sequencing.Add(FieldsJalonnement.PR.ReadFieldBool(Automatic_Sequencing, Record))

                MyItem.Real_Op_Time_Per_Item.Add(Math.Max(FieldsJalonnement.PR.ReadFieldDouble("Orders", "Batch Time", Record), 0))

            Next

            MyItem.Required_Resource = FieldsJalonnement.PR.ReadFieldInt(Required_Resource, Record)
            MyItem.Quantity = FieldsJalonnement.PR.ReadFieldDouble(Quantity, Record)

            MyItem.Chevauchement = FieldsJalonnement.PR.ReadFieldDouble(Transfer_Quantity, Record)
            MyItem.Temps_Transfert = FieldsJalonnement.PR.ReadFieldDouble("Orders", "Slack Time After Last Operation", Record)
            If (MyItem.Temps_Transfert = -1) Then
                MyItem.Temps_Transfert = 0
            End If
            'MyItem.Temps_Transfert = 0.0

            MyItem.Temps_Setup = Math.Max(FieldsJalonnement.PR.ReadFieldDouble(Setup_Time, Record), 0)
            MyItem.DelaiInterOperation = 0

            MyList.Add(MyItem)
        Next


    End Sub

    Friend Shared ReadOnly Property ToList As List(Of Tbl)
        Get
            Return MyList
        End Get
    End Property

    Friend Shared ReadOnly Property GetRecord(ByVal Record As Integer) As Tbl
        Get
            If MyList.Count >= Record Then
                Return MyList.Item(Record - 1)
            Else
                Return Nothing
            End If
        End Get
    End Property

    Friend Structure Tbl
        Friend Record As Integer

        Friend ActualDueDate As Date
        Friend EarliestStartCustom As Date
        Friend LatestStartCustom As Date
        Friend LatestEndCustom As Date
        Friend Quantity As Double
        Friend Required_Resource As Integer
        Friend Real_Op_Time_Per_Item As List(Of Double)
        Friend Resource_Data As List(Of Integer)
        Friend Automatic_Sequencing As List(Of Boolean)
        Friend Chevauchement As Double
        Friend Temps_Transfert As Double
        Friend DelaiInterOperation As Double
        Friend Temps_Setup As Double
    End Structure
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class

Public Class Jalon_Variables
    Public Qty As Double
    Public Chevauchement As Double
    Public DelaiInterOperation As Double
    Public Temps_Transfert As Double
    Public Temps_Proces As Double
    Public Temps_Setup As Double
    Public Dic_Resource_Temps As Dictionary(Of Integer, Double)
End Class