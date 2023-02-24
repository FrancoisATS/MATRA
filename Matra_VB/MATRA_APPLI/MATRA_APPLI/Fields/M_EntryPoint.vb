Imports Preactor.Interop.PreactorObject
Imports Preactor
Imports System.IO

Module M_EntryPoint
    Friend Sub Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object)

        Dim PR As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        'TODO : Your code goes here
        Dim MyPath As String = PR.ParseShellString("{PATH}")

        Dim SWriter As StreamWriter
        SWriter = New StreamWriter(MyPath & "\Fields.vb")

        SWriter.WriteLine("Option Strict On")
        SWriter.WriteLine("Option Explicit On")
        SWriter.WriteLine()
        SWriter.WriteLine("Imports Preactor.Interop.PreactorObject")
        SWriter.WriteLine("Imports Preactor")
        SWriter.WriteLine()
        SWriter.WriteLine(" '*****************************************************")
        SWriter.WriteLine("' FIELDS")
        SWriter.WriteLine(" '*****************************************************")
        SWriter.WriteLine()
        SWriter.WriteLine("Friend Class Fields")
        SWriter.WriteLine()
        SWriter.WriteLine("Private Sub New()")
        SWriter.WriteLine("End Sub")
        SWriter.WriteLine()
        SWriter.WriteLine("Friend Shared PR As IPreactor")
        SWriter.WriteLine()
        SWriter.WriteLine("Friend Shared Sub init(ByVal PR As IPreactor)")
        SWriter.WriteLine()
        SWriter.WriteLine("Fields.PR = PR")
        SWriter.WriteLine()
        For i As Integer = 1 To PR.FormatCount
            Dim FormatName As String = PR.GetFormatName(i)
            If Mid(FormatName, 1, 3) = "PCO" Then
                Continue For
            End If
            If Mid(FormatName, 1, 3) = "PIO" Then
                Continue For
            End If
            If Mid(FormatName, 1, 4) = "PESP" Then
                Continue For
            End If
            Dim MyTable As String = FormatTable(FormatName)
            SWriter.WriteLine(MyTable & ".init(PR)")
        Next

        SWriter.WriteLine()
        SWriter.WriteLine("End Sub")
        SWriter.WriteLine()
        SWriter.WriteLine("End Class")



        For i As Integer = 1 To PR.FormatCount
            Dim FormatName As String = PR.GetFormatName(i)
            Dim MyTable As String = FormatTable(FormatName)
            If Mid(FormatName, 1, 3) = "PCO" Then
                Continue For
            End If
            If Mid(FormatName, 1, 3) = "PIO" Then
                Continue For
            End If
            If Mid(FormatName, 1, 4) = "PESP" Then
                Continue For
            End If
            SWriter.WriteLine()
            SWriter.WriteLine()
            SWriter.WriteLine("Friend Class " & MyTable)
            SWriter.WriteLine("Private Sub New()")
            SWriter.WriteLine("End Sub")
            SWriter.WriteLine()
            SWriter.WriteLine("Friend Shared Table As Integer")
            SWriter.WriteLine()

            Dim FieldCount As Integer = PR.FieldCount(i)
            For j As Integer = 1 To FieldCount
                If PR.GetFieldType(i, j) = PreactorFieldType.Null Then
                    Continue For
                End If
                Dim MyField As String = FormatField(PR.GetFieldName(i, j))
                SWriter.WriteLine("Friend Shared " & MyField & " As FormatFieldPair")
            Next

            SWriter.WriteLine()
            SWriter.WriteLine("Friend Shared List As List(Of Tbl)")
            SWriter.WriteLine()


            SWriter.WriteLine("Friend Shared Sub init(ByVal PR As IPreactor)")
            SWriter.WriteLine()
            SWriter.WriteLine("Table = PR.GetFormatNumber(" & Chr(34) & FormatName & Chr(34) & ")")
            SWriter.WriteLine()

            For j As Integer = 1 To FieldCount
                If PR.GetFieldType(i, j) = PreactorFieldType.Null Then
                    Continue For
                End If
                Dim FieldName As String = PR.GetFieldName(i, j)
                Dim MyField As String = FormatField(FieldName)

                SWriter.WriteLine(MyField & " = New FormatFieldPair(Table, PR.GetFieldNumber(Table, " & Chr(34) & FieldName & Chr(34) & "))")
            Next
            SWriter.WriteLine()
            SWriter.WriteLine("End Sub")
            SWriter.WriteLine()
            SWriter.WriteLine("Private Shared MyList As List (Of Tbl)")
            ''add tolist property structure

            SWriter.WriteLine()
            SWriter.WriteLine("Friend Shared Sub Init_List()")
            SWriter.WriteLine("MyList = New List (Of Tbl)")
            'SWriter.WriteLine("Get")
            'SWriter.WriteLine()
            SWriter.WriteLine("Dim Records As Integer = Fields.PR.RecordCount(Table)")
            SWriter.WriteLine("For Record As Integer = 1 To Records")
            SWriter.WriteLine("Dim MyItem As New Tbl")
            SWriter.WriteLine("MyItem.Record = Record")

            For j As Integer = 1 To FieldCount
                Dim FieldName As String = PR.GetFieldName(i, j)
                Dim MyField As String = FormatField(FieldName)

                Select Case PR.GetFieldType(i, j)
                    Case PreactorFieldType.String
                        SWriter.WriteLine("MyItem." & MyField & " = Fields.PR.ReadFieldString(" & MyField & ", Record)")
                    Case PreactorFieldType.String Or PreactorFieldType.FreeFormatString
                        SWriter.WriteLine("MyItem." & MyField & " = Fields.PR.ReadFieldString(" & MyField & ", Record)")
                    Case PreactorFieldType.FreeFormatString
                        SWriter.WriteLine("MyItem." & MyField & " = Fields.PR.ReadFieldString(" & MyField & ", Record)")
                    Case PreactorFieldType.Toggle
                        SWriter.WriteLine("MyItem." & MyField & " = Fields.PR.ReadFieldBool(" & MyField & ", Record)")
                    Case PreactorFieldType.Real
                        SWriter.WriteLine("MyItem." & MyField & " = Fields.PR.ReadFieldDouble(" & MyField & ", Record)")
                    Case PreactorFieldType.Duration
                        SWriter.WriteLine("MyItem." & MyField & " = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(" & MyField & ", Record))")
                    Case PreactorFieldType.DateTime
                        SWriter.WriteLine("MyItem." & MyField & " = Fields.PR.ReadFieldDatetime(" & MyField & ", Record)")
                    Case PreactorFieldType.Integer
                        SWriter.WriteLine("MyItem." & MyField & " = Fields.PR.ReadFieldInt(" & MyField & ", Record)")
                    Case PreactorFieldType.Null
                        Continue For
                    Case Else
                        Continue For
                End Select
            Next

            SWriter.WriteLine()
            SWriter.WriteLine("MyList.Add(MyItem)")
            SWriter.WriteLine()
            SWriter.WriteLine("Next")
            SWriter.WriteLine()
            SWriter.WriteLine("End Sub")



            SWriter.WriteLine()
            SWriter.WriteLine("Friend Shared ReadOnly Property ToList As List(Of Tbl)")
            SWriter.WriteLine("Get")
            SWriter.WriteLine("Return MyList")
            SWriter.WriteLine("End Get")
            SWriter.WriteLine("End Property")
            SWriter.WriteLine()

            SWriter.WriteLine("Friend Shared ReadOnly Property GetRecord(ByVal Record As Integer) As Tbl")
            SWriter.WriteLine("Get ")
            SWriter.WriteLine("If MyList.Count >= Record Then")
            SWriter.WriteLine("Return  MyList.item(Record-1)")
            SWriter.WriteLine("Else")
            SWriter.WriteLine("Return Nothing")
            SWriter.WriteLine("End If")
            SWriter.WriteLine("End Get")
            SWriter.WriteLine("End Property")
            SWriter.WriteLine()

            'SWriter.WriteLine("Friend Shared ReadOnly Property GetItem(ByVal Item As Integer) As Tbl")
            'SWriter.WriteLine("Get ")
            'SWriter.WriteLine("Return  MyList.item(Item)")
            'SWriter.WriteLine("End Get")
            'SWriter.WriteLine("End Property")
            'SWriter.WriteLine()

            'SWriter.WriteLine("Friend Shared ReadOnly Property GetRecord(ByVal Record As Integer) As Tbl")
            'SWriter.WriteLine("Get ")
            'SWriter.WriteLine("If (From XXX In Mylist Select XXX Where XXX.Record = Record).Count = 0 Then")
            'SWriter.WriteLine("Return Nothing")
            'SWriter.WriteLine("Else")
            'SWriter.WriteLine("Return (From XXX In Mylist Select XXX Where XXX.Record = Record).first")
            ' SWriter.WriteLine("End If")
            'SWriter.WriteLine("End Get")
            'SWriter.WriteLine("End Property")
            'SWriter.WriteLine()

            SWriter.WriteLine("Friend Structure Tbl")
            SWriter.WriteLine("Friend Record As Integer")
            For j As Integer = 1 To FieldCount
                Dim FieldName As String = PR.GetFieldName(i, j)
                Dim MyField As String = FormatField(FieldName)

                Select Case PR.GetFieldType(i, j)
                    Case PreactorFieldType.String
                        SWriter.WriteLine("Friend " & MyField & " As String")
                    Case PreactorFieldType.String Or PreactorFieldType.FreeFormatString
                        SWriter.WriteLine("Friend " & MyField & " As String")
                    Case PreactorFieldType.FreeFormatString
                        SWriter.WriteLine("Friend " & MyField & " As String")
                    Case PreactorFieldType.Toggle
                        SWriter.WriteLine("Friend " & MyField & " As Boolean")
                    Case PreactorFieldType.Real
                        SWriter.WriteLine("Friend " & MyField & " As Double")
                    Case PreactorFieldType.Duration
                        SWriter.WriteLine("Friend " & MyField & " As TimeSpan")
                    Case PreactorFieldType.DateTime
                        SWriter.WriteLine("Friend " & MyField & " As DateTime")
                    Case PreactorFieldType.Integer
                        SWriter.WriteLine("Friend " & MyField & " As Integer")
                    Case PreactorFieldType.Integer
                        SWriter.WriteLine("Friend " & MyField & " As Integer")
                    Case PreactorFieldType.Null
                        Continue For
                    Case Else
                        Continue For

                End Select


            Next
            SWriter.WriteLine("End Structure")
            SWriter.WriteLine("Protected Overrides Sub Finalize()")
            SWriter.WriteLine("MyBase.Finalize()")
            SWriter.WriteLine("End Sub")
            SWriter.WriteLine()
            SWriter.WriteLine("End Class")
            SWriter.WriteLine()
        Next

        SWriter.Close()
        SWriter = Nothing
    End Sub
    Private Function FormatField(ByVal Field As String) As String
        Field = Field.Replace(CChar(" "), CChar("_"))
        Field = Field.Replace(CChar("'"), String.Empty)
        Field = Field.Replace(CChar("."), String.Empty)
        Field = Field.Replace(CChar("¿"), String.Empty)
        Field = Field.Replace(CChar("?"), String.Empty)
        Field = Field.Replace(CChar("+"), CChar("_"))
        Field = Field.Replace(CChar("-"), CChar("_"))
        Field = Field.Replace(CChar("/"), CChar("_"))
        Field = Field.Replace(CChar("\"), CChar("_"))
        Field = Field.Replace(CChar("["), CChar("_"))
        Field = Field.Replace(CChar("]"), CChar("_"))
        Field = Field.Replace(CChar("("), CChar("_"))
        Field = Field.Replace(CChar(")"), CChar("_"))
        Field = Field.Replace(CChar("%"), "Percent")
        Field = Field.Replace(CChar("°"), String.Empty)
        Field = Field.Replace(CChar("|"), String.Empty)
        If Field = "Error" Then
            Return "Error_"
        End If
        If Field = "Date" Then
            Return "Date_"
        End If
        If Field = "Default" Then
            Return "Default_"
        End If
        If Field = "Operator" Then
            Return "Operator_"
        End If
        Dim Mydbl As Double
        If Double.TryParse(Field.Substring(0, 1).ToString, Mydbl) Then
            Field = "_" & Field
        End If

        Return Field
    End Function
    Private Function FormatTable(ByVal Table As String) As String
        Table = Table.Replace(CChar(" "), CChar("_"))
        Table = Table.Replace(CChar("'"), String.Empty)
        Table = Table.Replace(CChar("."), String.Empty)
        Table = Table.Replace(CChar("¿"), String.Empty)
        Table = Table.Replace(CChar("?"), String.Empty)
        Table = Table.Replace(CChar("+"), CChar("_"))
        Table = Table.Replace(CChar("-"), CChar("_"))
        Table = Table.Replace(CChar("/"), CChar("_"))
        Table = Table.Replace(CChar("\"), CChar("_"))
        Table = Table.Replace(CChar("["), CChar("_"))
        Table = Table.Replace(CChar("]"), CChar("_"))
        Table = Table.Replace(CChar("("), CChar("_"))
        Table = Table.Replace(CChar(")"), CChar("_"))
        Table = Table.Replace(CChar("%"), "Percent")
        Table = Table.Replace(CChar("°"), String.Empty)
        Table = Table.Replace(CChar("|"), String.Empty)

        Return "Pr_" & Table
    End Function

End Module
