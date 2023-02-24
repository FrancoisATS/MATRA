Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.InteropServices
Imports Preactor.Interop.PreactorObject
Imports Preactor
Imports System.Windows.Forms

<ComVisible(True)> _
<Microsoft.VisualBasic.ComClass("c2104a46-1623-4415-abcc-0ccecb072b19", "90a3b23b-6a9f-420c-be57-50198271dfff")> _
Public Class ImportCalendrier
    Public Function Run(ByRef preactorComObject As PreactorObj, ByRef pespComObject As Object) As Integer

        Dim preactor As IPreactor = PreactorFactory.CreatePreactorObject(preactorComObject)

        Dim RessourceSecondaire As String
        Dim DateDeb As String
        Dim DateFin As String
        Dim Qte As String
        Dim Calendrier As String
        Dim Ligne As String
        Dim Defaut As String
        Dim DateImport As String
        Dim Record As Integer
        Dim Fichier As String
        Dim Erreur As Boolean = False
        Try
            'Recuperation du chemin et fichiers parametres
            Dim Chemin = preactor.ReadFieldString(Pr_Chemins.Repertoire_des_fichiers_dimportation, 1)
            Fichier = preactor.ReadFieldString(Pr_Chemins.Table, "Fichier des calendriers", 1)
            Dim ressourcemanquanteaffichage = ""
            If (Chemin = "" Or Fichier = "") Then
                MessageBox.Show("Le chemin ou le dossier des régleurs n'est pas paramétré")
                Return 1
                Exit Function
            End If



            Path = Chemin + "\" + Fichier

            Dim MyOutils = New Tools.Outils

            preactor.Load(Pr_Primary_Calendar_Periods.Table, "SCHEDULE")

            Dim MyList As List(Of List(Of String)) = MyOutils.Fich_to_List(CChar(";"), True)

            preactor.DisplayStatus("MATRA  Importation des calendriers", "Mise à Jour des données", "Patientez SVP...")

            DateImport = Date.Now.ToString
            If MyList Is Nothing Then
                MessageBox.Show("Aucune donnée dans le fichier")
                Return 1
                Exit Function
            End If

            preactor.DisplayStatus("MATRA  Importation des calendriers", "Mise à Jour des données", "Patientez SVP...")
            Index = 0

            preactor.Clear(Pr_Primary_Calendar_Periods.Table)

            For i = 1 To preactor.RecordCount(Pr_Resources.Table)
                If (preactor.ReadFieldString(Pr_Resources.Finite_or_Infinite, i) = "Finie") Then
                    Record = preactor.CreateRecord(Pr_Primary_Calendar_Periods.Table)
                    preactor.WriteField(Pr_Primary_Calendar_Periods.Resource, Record, preactor.ReadFieldInt(Pr_Resources.Number, i))
                    preactor.WriteField(Pr_Primary_Calendar_Periods.Is_Exception, Record, 0)
                    preactor.WriteField(Pr_Primary_Calendar_Periods.Reference_Date, Record, "01/01/2000 00:00")
                    preactor.WriteField(Pr_Primary_Calendar_Periods.Reference_Date_Type, Record, 0)
                    preactor.WriteField(Pr_Primary_Calendar_Periods.Template, Record, "Off Shift Day")
                End If
            Next



            For Each Item In MyList
                Index = Index + 1
                preactor.UpdateStatus(Index, MyList.Count)
                Erreur = False

                'Test si l'Item contient tous les champs 
                If (Item.Count() < 4) Then
                    Ligne = "Ligne : " + Index.ToString
                    For Each Valeur In Item
                        Ligne = Ligne + "|" + Valeur
                    Next
                    MyOutils.ErrorToTable("Tous les champs ne sont pas renseignés", Fichier, Ligne, preactor)
                    Erreur = True
                Else
                    RessourceSecondaire = Trim(Item(0))
                    DateDeb = Trim(Item(3))
                    DateFin = Trim(Item(4))
                    Calendrier = Trim(Item(2))

                    If (Calendrier = "") Then

                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("Le calendrier n'est pas renseigné", Fichier, Ligne, preactor)
                        Erreur = True
                        GoTo Erreur
                    Else
                        Dim recordCalendrier = preactor.FindMatchingRecord(Pr_Primary_Resource_Templates.Name, 0, Calendrier)
                        If (recordCalendrier <= 0) Then
                            Erreur = True
                            GoTo Erreur
                        End If
                    End If


                    'Test de la clé primaire
                    If (RessourceSecondaire = "") Then
                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("L'identifiant n'est pas renseigné", Fichier, Ligne, preactor)
                        Erreur = True
                        GoTo Erreur
                    End If






                    Dim ressourcerecord = preactor.FindMatchingRecord(Pr_Resources.Name, 0, RessourceSecondaire)




                    If (ressourcerecord > 0) Then


                        Record = preactor.CreateRecord(Pr_Primary_Calendar_Periods.Table)
                            preactor.WriteField(Pr_Primary_Calendar_Periods.Resource, Record, preactor.ReadFieldInt(Pr_Resources.Number, ressourcerecord))
                            preactor.WriteField(Pr_Primary_Calendar_Periods.From_Date, Record, DateDeb)
                            preactor.WriteField(Pr_Primary_Calendar_Periods.To_Date, Record, DateFin)
                            preactor.WriteField(Pr_Primary_Calendar_Periods.Is_Exception, Record, 1)
                            preactor.WriteField(Pr_Primary_Calendar_Periods.Reference_Date, Record, "01/01/2000 00:00")
                            preactor.WriteField(Pr_Primary_Calendar_Periods.Reference_Date_Type, Record, 0)
                            preactor.WriteField(Pr_Primary_Calendar_Periods.Template, Record, Calendrier)

                    Else
                            ressourcemanquanteaffichage = ressourcemanquanteaffichage + RessourceSecondaire + ","
                        MyOutils.ErrorToTable("l'ILOT " + RessourceSecondaire + " n'existe pas dans les calendriers", Fichier, "Calendriers", preactor)

                    End If




                End If



Erreur:
            Next

            If (ressourcemanquanteaffichage <> "") Then
                MessageBox.Show("Il manque : " + ressourcemanquanteaffichage + " dans preactor")
            End If
            preactor.Commit(Pr_Primary_Calendar_Periods.Table, "SCHEDULE")

            preactor.DestroyStatus()
        Catch ex As Exception

            preactor.DestroyStatus()
            MsgBox(ex.Message)
        End Try

        Return 1

        Return 0
    End Function
End Class
