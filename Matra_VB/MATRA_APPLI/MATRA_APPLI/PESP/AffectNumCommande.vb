Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor
Imports System.Data.SqlClient
Imports System.Text




Public Class OFAffect
    Public Ordre As String
    Public Commande As String
    Public DateAffect As String


End Class

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("671bfd87-659b-4f28-a324-b3ebefd3ab1e", "a908775d-f0dd-4e49-8378-2e2fad593386")> _
Public Class AffectNumCommande
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)


        For i = 1 To preactor.RecordCount(Pr_Orders.Table)
            preactor.WriteField(Pr_Orders.Table, "Commande", i, "")
            preactor.WriteField(Pr_Orders.Table, "Date Save", i, preactor.ReadFieldDateTime(Pr_Orders.Due_Date, i))
            preactor.WriteField(Pr_Orders.Date_Attribute_2, i, "Indéfini")


        Next

        Dim MyList = New List(Of OFAffect)
        Dim MyList1 = New List(Of OFAffect)
        Dim MyList2 = New List(Of OFAffect)
        Dim MyList3 = New List(Of OFAffect)
        Dim MyList4 = New List(Of OFAffect)
        Dim MyList5 = New List(Of OFAffect)
        Dim MyList6 = New List(Of OFAffect)
        Dim MyList7 = New List(Of OFAffect)
        Dim MyList8 = New List(Of OFAffect)
        Dim MyList9 = New List(Of OFAffect)
        Dim MyList10 = New List(Of OFAffect)
        ' Get the connection string
        Dim connectionString As String = preactor.ParseShellString("{DB CONNECT STRING}")


        ' Create a connection to the database
        Dim connection = New SqlConnection(connectionString)

        preactor.Commit(Pr_Orders.Table, "SCHEDULE")
        '' Open the connection
        'connection.Open()

        '' Define the sql to select the calendar states
        'Dim sql = "MAJOrdo"


        '' Create a new command
        'Dim Command = New SqlCommand(sql, connection)
        'Dim reader = Command.ExecuteReader()
        'connection.Close()


        Dim Sql = " SELECT DISTINCT " +
                  " D.OrderNo As 'Commande',  " +
                  " D.DemandDate,   " +
                  " CONVERT(VARCHAR(10),D.DemandDate,103) as 'Date commande',   " +
                  " ISNULL(O1.OrderNo,'NA') AS 'OF chapeau',  " +
                  " ISNULL(O2.OrderNo,'NA') AS  'OF SE 1', " +
                  "           ISNULL(O3.OrderNo,'NA')  AS 'OF SE 2' , " +
                  " ISNULL(O4.OrderNo,'NA')  AS 'OF SE 3', " +
                  "            ISNULL(O5.OrderNo,'NA') AS  'OF SE 4', " +
                  "          ISNULL(O6.OrderNo,'NA')  AS 'OF SE 5' , " +
                  " ISNULL(O7.OrderNo,'NA')  AS 'OF SE 6', " +
                  "            ISNULL(O8.OrderNo,'NA') AS  'OF SE 7', " +
                  "           ISNULL(O9.OrderNo,'NA')  AS 'OF SE 8' , " +
                  " ISNULL(O10.OrderNo,'NA')  AS 'OF SE 9' " +
                  " From UserData.Orders O1   " +
                  " INNER JOIN UserData.OrderLinks L1 On   " +
                  " L1.FromInternalSupplyOrder = O1.OrdersId and O1.OpSeqMarker = 2   " +
                  " INNER JOIN UserData.Demand D ON D.DemandId = L1.ToExternalDemandOrder  " +
                  "          LEFT JOIN UserData.OrderLinks L2 ON  " +
                  "          L2.ToInternalDemandOrder IN (SELECT   O.OrdersId  FROM UserData.Orders O WHERE  O.OrderNo = O1.OrderNo )  " +
                  " LEFT JOIN UserData.Orders O2 ON L2.FromInternalSupplyOrder = O2.OrdersId                            " +
                  "          LEFT JOIN UserData.OrderLinks L3 ON  " +
                  "          L3.ToInternalDemandOrder IN (SELECT   O.OrdersId  FROM UserData.Orders O WHERE  O.OrderNo = O2.OrderNo )  " +
                  " LEFT JOIN UserData.Orders O3 ON L3.FromInternalSupplyOrder = O3.OrdersId  " +
                  "                       LEFT JOIN UserData.OrderLinks L4 ON  " +
                  "          L4.ToInternalDemandOrder IN (SELECT   O.OrdersId  FROM UserData.Orders O WHERE  O.OrderNo = O3.OrderNo )  " +
                  " LEFT JOIN UserData.Orders O4 ON L4.FromInternalSupplyOrder = O4.OrdersId           " +
                  "                       LEFT JOIN UserData.OrderLinks L5 ON  " +
                  "          L5.ToInternalDemandOrder IN (SELECT   O.OrdersId  FROM UserData.Orders O WHERE  O.OrderNo = O4.OrderNo )  " +
                  " LEFT JOIN UserData.Orders O5 ON L5.FromInternalSupplyOrder = O5.OrdersId  " +
                  "                       LEFT JOIN UserData.OrderLinks L6 ON  " +
                  "          L6.ToInternalDemandOrder IN (SELECT   O.OrdersId  FROM UserData.Orders O WHERE  O.OrderNo = O5.OrderNo )  " +
                  " LEFT JOIN UserData.Orders O6 ON L6.FromInternalSupplyOrder = O6.OrdersId  " +
                  "                 LEFT JOIN UserData.OrderLinks L7 On  " +
                  "          L7.ToInternalDemandOrder IN (SELECT   O.OrdersId  FROM UserData.Orders O WHERE  O.OrderNo = O6.OrderNo )  " +
                  " LEFT JOIN UserData.Orders O7 ON L7.FromInternalSupplyOrder = O7.OrdersId " +
                  "          LEFT JOIN UserData.OrderLinks L8 On  " +
                  "          L8.ToInternalDemandOrder IN (SELECT   O.OrdersId  FROM UserData.Orders O WHERE  O.OrderNo = O7.OrderNo )  " +
                  " LEFT JOIN UserData.Orders O8 ON L8.FromInternalSupplyOrder = O8.OrdersId  " +
                  "                  LEFT JOIN UserData.OrderLinks L9 ON  " +
                  "          L9.ToInternalDemandOrder IN (SELECT   O.OrdersId  FROM UserData.Orders O WHERE  O.OrderNo = O8.OrderNo )  " +
                  " LEFT JOIN UserData.Orders O9 ON L9.FromInternalSupplyOrder = O9.OrdersId  " +
                  "            LEFT JOIN UserData.OrderLinks L10 ON  " +
                  "          L10.ToInternalDemandOrder IN (SELECT   O.OrdersId  FROM UserData.Orders O WHERE  O.OrderNo = O9.OrderNo )  " +
                  " LEFT JOIN UserData.Orders O10 ON L10.FromInternalSupplyOrder = O10.OrdersId   " +
                  " ORDER BY D.DemandDate "



        '
        connection = New SqlConnection(connectionString)

        ' Open the connection
        connection.Open()

        Dim Command = New SqlCommand(Sql, connection)
        Command.CommandTimeout = 3000

        ' Execute the command and get a reader
        Dim reader = Command.ExecuteReader()

        ' Get the ordinals for the fields we are interested in
        Dim Commande = reader.GetOrdinal("Commande")
        Dim DateCommande = reader.GetOrdinal("Date commande")
        Dim OF2 = reader.GetOrdinal("OF chapeau")
        Dim OF3 = reader.GetOrdinal("OF SE 1")
        Dim OF4 = reader.GetOrdinal("OF SE 2")
        Dim OF5 = reader.GetOrdinal("OF SE 3")
        Dim OF6 = reader.GetOrdinal("OF SE 4")
        Dim OF7 = reader.GetOrdinal("OF SE 5")
        Dim OF8 = reader.GetOrdinal("OF SE 6")
        Dim OF9 = reader.GetOrdinal("OF SE 7")
        Dim OF10 = reader.GetOrdinal("OF SE 8")
        Dim OF11 = reader.GetOrdinal("OF SE 9")

        ' Create a new string builder
        Dim result = New StringBuilder()
        Dim Index = 0
        ' Loop through all of the rows
        While (reader.Read())


            Index = Index + 1
            Dim enregistrement As New OFAffect
            enregistrement.Commande = reader.GetString(Commande)
            enregistrement.DateAffect = reader.GetString(DateCommande)
            enregistrement.Ordre = reader.GetString(OF2)
            MyList1.Add(enregistrement)

            enregistrement = New OFAffect

            enregistrement.Commande = reader.GetString(Commande)
            enregistrement.DateAffect = reader.GetString(DateCommande)
            enregistrement.Ordre = reader.GetString(OF3)

            MyList2.Add(enregistrement)
            enregistrement = New OFAffect

            enregistrement.Commande = reader.GetString(Commande)
            enregistrement.DateAffect = reader.GetString(DateCommande)
            enregistrement.Ordre = reader.GetString(OF4)
            MyList3.Add(enregistrement)
            enregistrement = New OFAffect
            enregistrement.Commande = reader.GetString(Commande)
            enregistrement.DateAffect = reader.GetString(DateCommande)
            enregistrement.Ordre = reader.GetString(OF5)
            MyList4.Add(enregistrement)
            enregistrement = New OFAffect
            enregistrement.Commande = reader.GetString(Commande)
            enregistrement.DateAffect = reader.GetString(DateCommande)
            enregistrement.Ordre = reader.GetString(OF6)
            MyList5.Add(enregistrement)
            enregistrement = New OFAffect
            enregistrement.Commande = reader.GetString(Commande)
            enregistrement.DateAffect = reader.GetString(DateCommande)
            enregistrement.Ordre = reader.GetString(OF7)
            MyList6.Add(enregistrement)
            enregistrement = New OFAffect
            enregistrement.Commande = reader.GetString(Commande)
            enregistrement.DateAffect = reader.GetString(DateCommande)
            enregistrement.Ordre = reader.GetString(OF8)
            MyList7.Add(enregistrement)
            enregistrement = New OFAffect
            enregistrement.Commande = reader.GetString(Commande)
            enregistrement.DateAffect = reader.GetString(DateCommande)
            enregistrement.Ordre = reader.GetString(OF9)
            MyList8.Add(enregistrement)
            enregistrement = New OFAffect
            enregistrement.Commande = reader.GetString(Commande)
            enregistrement.DateAffect = reader.GetString(DateCommande)
            enregistrement.Ordre = reader.GetString(OF10)
            MyList9.Add(enregistrement)
            enregistrement = New OFAffect
            enregistrement.Commande = reader.GetString(Commande)
            enregistrement.DateAffect = reader.GetString(DateCommande)
            enregistrement.Ordre = reader.GetString(OF11)
            MyList10.Add(enregistrement)

        End While


        For Each Item In MyList1

            If (Item.Ordre <> "" And Item.Commande <> "" And Item.DateAffect <> "") Then

                Dim recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, Item.Ordre)
                While (recordOF > 0)

                    If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, recordOF) = "Indéfini") Then
                        preactor.WriteField(Pr_Orders.Date_Attribute_2, recordOF, Item.DateAffect)
                        preactor.WriteField(Pr_Orders.Table, "Commande", recordOF, Item.Commande)
                        preactor.WriteField(Pr_Orders.Sous_ensemble, recordOF, 0)
                    End If
                    recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, recordOF, Item.Ordre)
                End While



            End If


        Next
        For Each Item In MyList2

            If (Item.Ordre <> "" And Item.Commande <> "" And Item.DateAffect <> "") Then

                Dim recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, Item.Ordre)
                While (recordOF > 0)

                    If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, recordOF) = "Indéfini") Then
                        preactor.WriteField(Pr_Orders.Date_Attribute_2, recordOF, Item.DateAffect)
                        preactor.WriteField(Pr_Orders.Table, "Commande", recordOF, Item.Commande)
                        preactor.WriteField(Pr_Orders.Sous_ensemble, recordOF, 0)
                    End If
                    recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, recordOF, Item.Ordre)
                End While



            End If


        Next
        For Each Item In MyList3

            If (Item.Ordre <> "" And Item.Commande <> "" And Item.DateAffect <> "") Then

                Dim recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, Item.Ordre)
                While (recordOF > 0)

                    If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, recordOF) = "Indéfini") Then
                        preactor.WriteField(Pr_Orders.Date_Attribute_2, recordOF, Item.DateAffect)
                        preactor.WriteField(Pr_Orders.Table, "Commande", recordOF, Item.Commande)
                        preactor.WriteField(Pr_Orders.Sous_ensemble, recordOF, 0)
                    End If
                    recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, recordOF, Item.Ordre)
                End While



            End If


        Next
        For Each Item In MyList4

            If (Item.Ordre <> "" And Item.Commande <> "" And Item.DateAffect <> "") Then

                Dim recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, Item.Ordre)
                While (recordOF > 0)

                    If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, recordOF) = "Indéfini") Then
                        preactor.WriteField(Pr_Orders.Date_Attribute_2, recordOF, Item.DateAffect)
                        preactor.WriteField(Pr_Orders.Table, "Commande", recordOF, Item.Commande)
                        preactor.WriteField(Pr_Orders.Sous_ensemble, recordOF, 0)
                    End If
                    recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, recordOF, Item.Ordre)
                End While



            End If


        Next
        For Each Item In MyList5

            If (Item.Ordre <> "" And Item.Commande <> "" And Item.DateAffect <> "") Then

                Dim recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, Item.Ordre)
                While (recordOF > 0)

                    If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, recordOF) = "Indéfini") Then
                        preactor.WriteField(Pr_Orders.Date_Attribute_2, recordOF, Item.DateAffect)
                        preactor.WriteField(Pr_Orders.Table, "Commande", recordOF, Item.Commande)
                        preactor.WriteField(Pr_Orders.Sous_ensemble, recordOF, 0)
                    End If
                    recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, recordOF, Item.Ordre)
                End While



            End If


        Next



        For Each Item In MyList6

            If (Item.Ordre <> "" And Item.Commande <> "" And Item.DateAffect <> "") Then

                Dim recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, Item.Ordre)
                While (recordOF > 0)

                    If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, recordOF) = "Indéfini") Then
                        preactor.WriteField(Pr_Orders.Date_Attribute_2, recordOF, Item.DateAffect)
                        preactor.WriteField(Pr_Orders.Table, "Commande", recordOF, Item.Commande)
                        preactor.WriteField(Pr_Orders.Sous_ensemble, recordOF, 0)
                    End If
                    recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, recordOF, Item.Ordre)
                End While



            End If


        Next
        For Each Item In MyList7

            If (Item.Ordre <> "" And Item.Commande <> "" And Item.DateAffect <> "") Then

                Dim recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, Item.Ordre)
                While (recordOF > 0)

                    If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, recordOF) = "Indéfini") Then
                        preactor.WriteField(Pr_Orders.Date_Attribute_2, recordOF, Item.DateAffect)
                        preactor.WriteField(Pr_Orders.Table, "Commande", recordOF, Item.Commande)
                        preactor.WriteField(Pr_Orders.Sous_ensemble, recordOF, 0)
                    End If
                    recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, recordOF, Item.Ordre)
                End While



            End If


        Next
        For Each Item In MyList8

            If (Item.Ordre <> "" And Item.Commande <> "" And Item.DateAffect <> "") Then

                Dim recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, Item.Ordre)
                While (recordOF > 0)

                    If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, recordOF) = "Indéfini") Then
                        preactor.WriteField(Pr_Orders.Date_Attribute_2, recordOF, Item.DateAffect)
                        preactor.WriteField(Pr_Orders.Table, "Commande", recordOF, Item.Commande)
                        preactor.WriteField(Pr_Orders.Sous_ensemble, recordOF, 0)
                    End If
                    recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, recordOF, Item.Ordre)
                End While



            End If


        Next
        For Each Item In MyList9

            If (Item.Ordre <> "" And Item.Commande <> "" And Item.DateAffect <> "") Then

                Dim recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, Item.Ordre)
                While (recordOF > 0)

                    If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, recordOF) = "Indéfini") Then
                        preactor.WriteField(Pr_Orders.Date_Attribute_2, recordOF, Item.DateAffect)
                        preactor.WriteField(Pr_Orders.Table, "Commande", recordOF, Item.Commande)
                        preactor.WriteField(Pr_Orders.Sous_ensemble, recordOF, 0)
                    End If
                    recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, recordOF, Item.Ordre)
                End While



            End If


        Next
        For Each Item In MyList10

            If (Item.Ordre <> "" And Item.Commande <> "" And Item.DateAffect <> "") Then

                Dim recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, Item.Ordre)
                While (recordOF > 0)

                    If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, recordOF) = "Indéfini") Then
                        preactor.WriteField(Pr_Orders.Date_Attribute_2, recordOF, Item.DateAffect)
                        preactor.WriteField(Pr_Orders.Table, "Commande", recordOF, Item.Commande)
                        preactor.WriteField(Pr_Orders.Sous_ensemble, recordOF, 0)
                    End If
                    recordOF = preactor.FindMatchingRecord(Pr_Orders.Order_No, recordOF, Item.Ordre)
                End While



            End If


        Next


        For i = 1 To preactor.RecordCount(Pr_Orders.Table)

            If (preactor.ReadFieldString(Pr_Orders.Date_Attribute_2, i) = "Indéfini") Then
                preactor.WriteField(Pr_Orders.Date_Attribute_2, i, preactor.ReadFieldDateTime(Pr_Orders.Table, "Date Save", i))
            End If
        Next

        ' Close the connection
        connection.Close()

        preactor.Commit(Pr_Orders.Table, "SCHEDULE")

        preactor.Redraw()



        Return 0
    End Function
End Class
