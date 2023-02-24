'Option Strict On
Option Explicit On

Imports Preactor.Interop.PreactorObject
Imports Preactor


Module Variables
    Private Actual_Path As String
    Private Count As Integer
    Private Actual_PathError As String
    'Conversion_Dictionary<ITEM (Product Code), <Unit Origin(Number), <Unit Destination(Number),Facteur Conversion> > >
    Private Conversion_Dictionary As Dictionary(Of String, Dictionary(Of Integer, Dictionary(Of Integer, Double)))
    Private Dic_Unit_str_To_Unit_num As Dictionary(Of String, Integer)
    Friend Enum Process_Type As Integer
        Float = 1
        Coater = 2
        OLC = 3
        Mirror = 4
        Laminate = 5
        Packaging = 6
        Unspecified = -1
    End Enum

    Friend Property Path() As String
        Get
            Return Actual_Path
        End Get
        Set(value As String)
            Actual_Path = value
        End Set
    End Property
    Friend Property PathError() As String
        Get
            Return Actual_PathError
        End Get
        Set(value As String)
            Actual_PathError = value
        End Set
    End Property
    Friend Property Index() As Integer
        Get
            Return Count
        End Get
        Set(value As Integer)
            Count = value
        End Set
    End Property

    Friend Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Friend Function GetTimeSpan(ByVal Value As String) As TimeSpan
        Dim Days As Integer
        Dim Hours As Integer
        Dim Minutes As Integer
        Dim Secondes As Integer

        If Value.IndexOf(CChar(".")) > 0 Then
            ' Days // Hours // Minutes // Secondes
            Try
                Dim MyDays As String = Split(Value, CChar("."))(0)
                Dim MyHours As String = Split(Split(Value, CChar("."))(1), CChar(":"))(0)
                Dim MyMinutes As String = Split(Value, CChar(":"))(1)
                Dim MySecondes As String = Split(Value, CChar(":"))(2)
                Days = Integer.Parse(MyDays)
                Hours = Integer.Parse(MyHours)
                Minutes = Integer.Parse(MyMinutes)
                Secondes = Integer.Parse(MySecondes)
            Catch ex As Exception

                Return Nothing
            End Try
        Else
            ' Hours // Minutes // Secondes
            Try
                Dim MyHours As String = Split(Value, CChar(":"))(0)
                Dim MyMinutes As String = Split(Value, CChar(":"))(1)
                Dim MySecondes As String = Split(Value, CChar(":"))(2)
                Hours = Integer.Parse(MyHours)
                Minutes = Integer.Parse(MyMinutes)
                Secondes = Integer.Parse(MySecondes)
            Catch ex As Exception

                Return Nothing
            End Try
        End If

        Return New TimeSpan(Days, Hours, Minutes, Secondes)
    End Function



    Friend Structure Product_Version
        Friend Resource As String
        Friend Priority As Integer
    End Structure

    Friend Class Suivi_Product
        Friend Id As Long
        'Friend Id2 As Integer
        Friend ResourceName As String
        Friend Product As String
        Friend Quantity As Double
        Friend DateSuivi As Date
    End Class

    Friend Structure AffectationDateCommande
        Friend Ordre As String
        Friend Commande As String
        Friend DateOrdre As DateTime
    End Structure

End Module


