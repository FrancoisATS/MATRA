Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Reflection
Imports System.Globalization
Imports Preactor
Imports System.Data.SqlClient
Imports System.Text

Namespace Tools
    Friend Class Outils
        Friend Function Clone(Of T)(ByVal inputObj As T) As T
            'creating a Memorystream which works like a temporary storeage '
            Using memStrm As New MemoryStream()
                'Binary Formatter for serializing the object into memory stream '
                Dim binFormatter As New BinaryFormatter(Nothing, New StreamingContext(StreamingContextStates.Clone))

                'talks for itself '
                binFormatter.Serialize(memStrm, inputObj)

                'setting the memorystream to the start of it '
                memStrm.Seek(0, SeekOrigin.Begin)

                'try to cast the serialized item into our Item '
                Try
                    Return DirectCast(binFormatter.Deserialize(memStrm), T)
                Catch ex As Exception
                    Trace.TraceError(ex.Message)
                    Return Nothing
                End Try
            End Using
        End Function
        Friend Function Fich_to_List(Optional ByVal Entete As Boolean = False) As List(Of String)
            If Not File.Exists(Path) Then
                Return Nothing
            End If

            Dim SReader As StreamReader = New StreamReader(Path, System.Text.Encoding.GetEncoding(1252))
            Dim Count As Integer = 0
            Dim MyList As New List(Of String)
            '   db.DisplayStatus("Lecture Fichier", "Calcul des registres a montrer")
            If Entete Then
                SReader.ReadLine()
            End If
            Do
                MyList.Add(SReader.ReadLine)
                Count = Count + 1
            Loop Until SReader.EndOfStream
            '  db.DestroyStatus()
            SReader.Close()
            SReader = Nothing
            Return MyList
        End Function
        Friend Function Fich_to_List(ByVal SeparateurDecimal As Char, Optional ByVal Entete As Boolean = False) As List(Of List(Of String))
            If Not File.Exists(Path) Then
                Return Nothing
            End If

            Dim SReader As StreamReader = New StreamReader(Path, System.Text.Encoding.UTF8)
            Dim Count As Integer = 0
            Dim MyList As New List(Of List(Of String))
            '   db.DisplayStatus("Lecture Fichier", "Calcul des registres a montrer")

            If SReader.EndOfStream Then
                SReader.Close()
                SReader = Nothing
                Return MyList
            End If

            If Entete Then
                SReader.ReadLine()
            End If

            If SReader.EndOfStream Then
                SReader.Close()
                SReader = Nothing
                Return MyList
            End If

            Do
                MyList.Add(SReader.ReadLine.Split(SeparateurDecimal).ToList)
                Count = Count + 1
            Loop Until SReader.EndOfStream
            '  db.DestroyStatus()
            SReader.Close()
            SReader = Nothing
            Return MyList
        End Function
        Private ReadOnly Property GetWeekNumber(ByVal MyDate As DateTime) As Integer
            Get
                Return DatePart(DateInterval.WeekOfYear, MyDate, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)
            End Get
        End Property
        Private ReadOnly Property Get_Monday(ByVal MyDate As DateTime) As DateTime
            Get
                Return (MyDate.AddDays(-MyDate.DayOfWeek + 1))
            End Get
        End Property
        Friend Function ErrorToTable(ByVal Erreur As String, ByVal Table As String, ByVal Ligne As String, ByVal Preactor As IPreactor) As Integer

            Dim Record As Integer

            Record = Preactor.CreateRecord(Pr_Erreurs.Table)
            Preactor.WriteField(Pr_Erreurs.TableErreur, Record, Table)
            Preactor.WriteField(Pr_Erreurs.Libelle_Erreur, Record, Erreur)
            Preactor.WriteField(Pr_Erreurs.Ligne, Record, Ligne)

            Return 1

        End Function

        'Friend Function GetWeight(ByVal Preactor As IPreactor) As List(Of Weight)


        '    Dim poids As Weight = New Weight()
        '    Dim ListWeight As List(Of Weight) = New List(Of Weight)()
        '    ' Get the connection string
        '    Dim connectionString = Preactor.ParseShellString(Preactor.ReadFieldString(Pr_Chemins.Parametrage_SQL, 1))

        '    ' Create a connection to the database
        '    Dim connection = New SqlConnection(connectionString)

        '    ' Open the connection
        '    connection.Open()

        '    ' Define the sql to select the calendar states
        '    Dim sql = "SELECT NativeName,Weight,FieldType " +
        '              " FROM SystemData.FieldDefinition F INNER JOIN SystemData.WeightSetValues W On " +
        '              " W.FieldDefinitionId = F.FieldDefinitionId " +
        '              " WHERE Weight > 0 "

        '    ' Create a new command
        '    Dim command = New SqlCommand(sql, connection)

        '    ' Execute the command and get a reader
        '    Dim reader = command.ExecuteReader()

        '    ' Get the ordinals for the fields we are interested in
        '    Dim efficiencyOrdinal = reader.GetOrdinal("Weight")
        '    Dim nameOrdinal = reader.GetOrdinal("NativeName")
        '    Dim typeOrdinal = reader.GetOrdinal("FieldType")
        '    ' Create a new string builder
        '    Dim result = New StringBuilder()

        '    ' Loop through all of the rows
        '    While (reader.Read())

        '        Dim weight As Weight = New Weight()

        '        ' Get the state name and efficiency
        '        Dim name As String = reader.GetString(nameOrdinal)
        '        Dim efficiency As Double = reader.GetDouble(efficiencyOrdinal)
        '        Dim type As Integer = reader.GetInt32(typeOrdinal)
        '        weight.SetWeight = efficiency
        '        weight.SetName = name
        '        weight.SetType = type
        '        ListWeight.Add(weight)

        '    End While

        '    ' Close the connection
        '    connection.Close()

        '    Return ListWeight

        'End Function
        Friend Function Get_Conversion(Temps As Double, TypeTemps As Integer) As Double

            If TypeTemps = 1 Then
                'heures
                Temps = Temps / 24
            ElseIf TypeTemps = 2 Then
                'minutes
                Temps = Temps / 1440
            ElseIf TypeTemps = 3 Then
                'secondes
                Temps = Temps / 86400
            Else
                Temps = 0
            End If

            Return Temps

        End Function
        Friend Function Get_Statut(NumStatut As String) As String

            If NumStatut = "1" Then
                Return "Prévisionnel"
            ElseIf NumStatut = "2" Then
                Return "Confirmé"
            ElseIf NumStatut = "3" Then
                Return "Lancé"
            ElseIf (NumStatut = "4") Then
                Return "Démarré"
            ElseIf (NumStatut = "5") Then
                Return "Cloturé"
            End If
            Return "Lancé"

        End Function
        Friend Function Get_TypeProcess(NumStatut As String) As String

            If NumStatut = "0" Then
                Return "Temps par item"
            ElseIf NumStatut = "1" Then
                Return "Temps par lot"
            ElseIf NumStatut = "2" Then
                Return "Taux par heure"
            End If
            Return "Temps par lot"

        End Function
        Friend Function Get_EtatAvancement(NumStatut As String) As String

            If NumStatut = "2" Then
                Return "Non commencée"
            ElseIf NumStatut = "3" Then
                Return "Suspendue"
            ElseIf NumStatut = "4" Then
                Return "En cours"
            ElseIf NumStatut = "5" Then
                Return "Terminée"
            End If
            Return "Non commencée"

        End Function

        Friend Function Get_EtatAvancement2(NumStatut As String) As String

            If NumStatut = "C" Then
                Return "Commencée"
            ElseIf NumStatut = "S" Then
                Return "Suspendue"
            ElseIf NumStatut = "N" Then
                Return "Non commencée"
            ElseIf NumStatut = "T" Then
                Return "Terminée"
            End If
            Return "Non commencée"

        End Function

        Friend Function Get_TransferType(Type As String) As String

            If Type = "0" Then
                Return "Quantité de transfert Après"
            ElseIf Type = "1" Then
                Return "Quantité complète Après"
            End If
            Return "Quantité complète Après"

        End Function
    End Class
End Namespace
