Imports Preactor
Imports System.IO
Imports System.Windows.Forms
Imports System.Globalization
Imports System.Data.SqlClient
Imports Preactor.Interop.PreactorObject


Public Module Mdl_Import



    Private MyOutils As Tools.Outils
    Private Chemin As String
    Private Record As Integer
    Private Fichier As String
    Private Ligne As String
    Private Erreur As Boolean


#Region "Import des Postes"
    Public Function Run_ImportPostes(ByVal Preactor As IPreactor) As Integer

        Dim CodeRessource As String
        Dim LibelleRessource As String
        Dim Calendrier As String
        Dim NbRessource As String
        Dim groupResourceRecord As Integer
        Dim size As MatrixDimensions

        Try
            'Recuperation du chemin et fichiers parametres
            Chemin = Preactor.ReadFieldString(Pr_Chemins.Repertoire_des_fichiers_dimportation, 1)
            Fichier = Preactor.ReadFieldString(Pr_Chemins.Fichier_des_postes_de_charges, 1)

            If (Chemin = "" Or Fichier = "") Then
                MessageBox.Show("Le chemin ou le dossier des postes n'est pas paramétré")
                Return 1
                Exit Function
            End If


            Path = Chemin + "\" + Fichier

            MyOutils = New Tools.Outils

            Dim MyList As List(Of List(Of String)) = MyOutils.Fich_to_List(CChar(";"), True)

            Preactor.DisplayStatus("MATRA  Importation des Ressources", "Mise à Jour des données", "Patientez SVP...")

            If MyList Is Nothing Then
                MessageBox.Show("Aucune donnée dans le fichier")
                Return 1
                Exit Function
            End If

            Preactor.DisplayStatus("MATRA  Importation des Ressources", "Mise à Jour des données", "Patientez SVP...")
            Index = 0
            For Each Item In MyList

                Erreur = False
                Preactor.UpdateStatus(Index, MyList.Count)
                'Test si l'Item contient tous les champs 
                If (Item.Count() < 4) Then
                    Ligne = "Ligne : " + Index.ToString
                    For Each Valeur In Item
                        Ligne = Ligne + "|" + Valeur
                    Next
                    MyOutils.ErrorToTable("Tous les champs ne sont pas renseignés", Fichier, Ligne, Preactor)
                    Erreur = True
                Else
                    CodeRessource = Item(0)
                    LibelleRessource = Item(1)
                    Calendrier = Item(2)
                    NbRessource = Item(3)

                    If (CodeRessource = "") Then
                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("Le code poste n'est pas renseigné", Fichier, Ligne, Preactor)
                        Erreur = True
                        GoTo Erreur
                    End If


                    Record = Preactor.FindMatchingRecord(Pr_Resources.Name, 0, CodeRessource)
                    If (Record <= 0) Then
                        Record = Preactor.CreateRecord(Pr_Resources.Table)
                    End If
                    Preactor.WriteField(Pr_Resources.Name, Record, CodeRessource)
                    Preactor.WriteField(Pr_Resources.Attribute_1, Record, LibelleRessource)
                    Preactor.WriteField(Pr_Resources.Attribute_2, Record, NbRessource)
                    Preactor.WriteField(Pr_Resources.Attribute_3, Record, Calendrier)
                End If



                Record = Preactor.FindMatchingRecord(Pr_Resource_Groups.Name, 0, CodeRessource)
                If (Record <= 0) Then
                    Record = Preactor.CreateRecord(Pr_Resource_Groups.Table)
                End If
                Preactor.WriteField(Pr_Resource_Groups.Name, Record, CodeRessource)


                groupResourceRecord = Preactor.FindMatchingRecord(Pr_Resource_Groups.Name, 0, CodeRessource)
                If (groupResourceRecord > 0) Then

                    Dim resourceRecord = Preactor.FindMatchingRecord(Pr_Resources.Name, 0, CodeRessource)
                    Dim resourceBelongToGroup = False

                    'On regarde si la ressource existe deja
                    Dim NbMax = Preactor.MatrixFieldSize(Pr_Resource_Groups.Resources, groupResourceRecord)
                    Dim j = 1
                    For j = 1 To NbMax.X
                        Dim matrixResource = Preactor.ReadFieldString(Pr_Resource_Groups.Resources, groupResourceRecord, j)
                        If matrixResource.Equals(CodeRessource) Then
                            resourceBelongToGroup = True
                            Exit For
                        End If
                    Next j

                    'Si non exisante, on l'ajoute
                    If resourceRecord > 0 And resourceBelongToGroup = False Then
                        size = Preactor.MatrixFieldSize(Pr_Resource_Groups.Resources, groupResourceRecord)
                        Preactor.SetAutoListSize(Pr_Resource_Groups.Resources, groupResourceRecord, size.X + 1)
                        Preactor.WriteListField(Pr_Resource_Groups.Resources, groupResourceRecord, CodeRessource, size.X + 1)
                    End If
                End If


Erreur:
            Next
            Preactor.Commit(Pr_Resources.Table)
            Preactor.Commit(Pr_Resource_Groups.Table)
        Catch ex As Exception

            Preactor.DestroyStatus()
            MsgBox(ex.Message)
        End Try

        Return 1
    End Function
#End Region


#Region "Import des stocks"
    Public Function Run_ImportStocks(ByVal Preactor As IPreactor) As Integer

        Dim Identifiant As String
        Dim CodeArticle As String
        Dim Designation As String
        Dim QteDispo As String
        Dim Depot As String
        Dim CodeCondition As String
        Dim QteReserve As String
        Dim Emplacement As String
        Dim Separateur = System.Globalization.CultureInfo.InstalledUICulture.NumberFormat.NumberDecimalSeparator

        Try


            'Recuperation du chemin et fichiers parametres
            Chemin = Preactor.ReadFieldString(Pr_Chemins.Repertoire_des_fichiers_dimportation, 1)
            Fichier = Preactor.ReadFieldString(Pr_Chemins.Fichier_des_Stocks, 1)

            If (Chemin = "" Or Fichier = "") Then
                MessageBox.Show("Le chemin ou le dossier des stocks n'est pas paramétré")
                Return 1
                Exit Function
            End If

            Preactor.Load(Pr_Orders.Table, "SCHEDULE")

            Path = Chemin + "\" + Fichier

            MyOutils = New Tools.Outils
            Dim DateImport As DateTime = DateTime.Now
            Dim MyList As List(Of List(Of String)) = MyOutils.Fich_to_List(CChar(";"), True)

            Preactor.DisplayStatus("MATRA  Importation des stocks", "Mise à Jour des données", "Patientez SVP...")

            If MyList Is Nothing Then
                MessageBox.Show("Aucune donnée dans le fichier")
                Return 1
                Exit Function
            End If

            Preactor.DisplayStatus("MATRA  Importation des stocks", "Mise à Jour des données", "Patientez SVP...")
            Index = 0
            For Each Item In MyList

                Erreur = False
                Index = Index + 1
                Preactor.UpdateStatus(Index, MyList.Count)
                'Test si l'Item contient tous les champs 
                If (Item.Count() < 3) Then
                    Ligne = "Ligne : " + Index.ToString
                    For Each Valeur In Item
                        Ligne = Ligne + "|" + Valeur
                    Next
                    MyOutils.ErrorToTable("Tous les champs ne sont pas renseignés", Fichier, Ligne, Preactor)
                    Erreur = True
                Else
                    CodeArticle = Item(0)
                    Designation = Item(1)
                    CodeCondition = Item(2)
                    QteDispo = Item(3)
                    QteDispo = Item(3).Replace(",", Separateur)
                    QteDispo = Item(3).Replace(".", Separateur)
                    Emplacement = Item(5)
                    QteReserve = Item(4)
                    QteReserve = Item(4).Replace(",", Separateur)
                    QteReserve = Item(4).Replace(".", Separateur)


                    'Test de la clé primaire
                    If (CodeArticle = "") Then
                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("L'identifiant n'est pas renseigné", Fichier, Ligne, Preactor)
                        Erreur = True
                        GoTo Erreur
                    End If

                    Identifiant = "Stock_" + CodeArticle + "_" + CodeCondition + "_" + Emplacement

                    Record = Preactor.FindMatchingRecord(Pr_Supply.Order_No, 0, Identifiant)
                    If (Record <= 0) Then
                        Record = Preactor.CreateRecord(Pr_Supply.Table)
                    End If
                    Preactor.WriteField(Pr_Supply.Order_No, Record, Identifiant)
                    Preactor.WriteField(Pr_Supply.Part_No, Record, CodeArticle)
                    Preactor.WriteField(Pr_Supply.Quantity, Record, QteDispo.Replace(",", "."))
                    Preactor.WriteField(Pr_Supply.Supply_Date, Record, DateAdd(DateInterval.Day, -1, Date.Now))
                    Preactor.WriteField(Pr_Supply.Order_Type, Record, "Stock")
                    Preactor.WriteField(Pr_Supply.String_Attribute_1, Record, DateImport.ToString)
                    Preactor.WriteField(Pr_Supply.Description, Record, Designation)
                    Preactor.WriteField(Pr_Supply.String_Attribute_2, Record, Emplacement)
                    Preactor.WriteField(Pr_Supply.String_Attribute_3, Record, CodeCondition)
                    Preactor.WriteField(Pr_Supply.Priority, Record, QteReserve)
                End If
Erreur:
            Next

            Pr_Supply.Init_List()

            Dim ListOrdre2 = (From ordre2 In Pr_Supply.ToList
                              Where ordre2.String_Attribute_1 <> DateImport.ToString And ordre2.Order_Type = "Stock"
                              Order By ordre2.Record Descending Select ordre2).ToList.Distinct


            For Each Item In ListOrdre2
                Preactor.DeleteRecord(Pr_Supply.Table, Item.Record)
            Next

            Preactor.Commit(Pr_Supply.Table, "SCHEDULE")
        Catch ex As Exception

            Preactor.DestroyStatus()
            MsgBox(ex.Message)
        End Try

        Return 1
    End Function

#End Region

#Region "Import des sorties"

    Public Function Run_ImportSorties(ByVal Preactor As IPreactor) As Integer

        Dim NumCommande As String
        Dim NumLigne As String
        Dim NumLivr As String
        Dim Designation As String
        Dim Identifiant As String
        Dim CodeArticle As String
        Dim Delai As String
        Dim Qte As String
        Dim Client As String

        Dim DateImport As String
        Dim Separateur = System.Globalization.CultureInfo.InstalledUICulture.NumberFormat.NumberDecimalSeparator
        Try
            'Recuperation du chemin et fichiers parametres
            Chemin = Preactor.ReadFieldString(Pr_Chemins.Repertoire_des_fichiers_dimportation, 1)
            Fichier = Preactor.ReadFieldString(Pr_Chemins.Fichier_des_Commandes, 1)

            If (Chemin = "" Or Fichier = "") Then
                MessageBox.Show("Le chemin ou le dossier des sorties n'est pas paramétré")
                Return 1
                Exit Function
            End If



            Path = Chemin + "\" + Fichier

            MyOutils = New Tools.Outils
            DateImport = Date.Now.ToString
            Dim MyList As List(Of List(Of String)) = MyOutils.Fich_to_List(CChar(";"), True)

            Preactor.DisplayStatus("MATRA  Importation des sorties", "Mise à Jour des données", "Patientez SVP...")

            If MyList Is Nothing Then
                MessageBox.Show("Aucune donnée dans le fichier")
                Return 1
                Exit Function
            End If

            Preactor.DisplayStatus("MATRA  Importation des sorties", "Mise à Jour des données", "Patientez SVP...")
            Index = 0
            For Each Item In MyList
                Index = Index + 1
                Erreur = False
                Preactor.UpdateStatus(Index, MyList.Count)
                'Test si l'Item contient tous les champs 
                If (Item.Count() < 8) Then
                    Ligne = "Ligne : " + Index.ToString
                    For Each Valeur In Item
                        Ligne = Ligne + "|" + Valeur
                    Next
                    MyOutils.ErrorToTable("Tous les champs ne sont pas renseignés", Fichier, Ligne, Preactor)
                    Erreur = True
                Else
                    NumCommande = Item(0)
                    NumLigne = Item(1)
                    NumLivr = Item(2)
                    CodeArticle = Item(3)
                    Designation = Item(4)
                    Qte = Item(5)
                    Qte = Item(5).Replace(",", Separateur)
                    Qte = Item(5).Replace(".", Separateur)
                    Delai = Item(6)
                    Client = Item(7)
                    'Test de la clé primaire
                    If (NumCommande = "") Then
                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("Le numéro de commande n'est pas renseigné", Fichier, Ligne, Preactor)
                        Erreur = True
                        GoTo Erreur
                    End If

                    If (NumLigne = "") Then
                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("Le numéro de ligne de commande n'est pas renseigné", Fichier, Ligne, Preactor)
                        Erreur = True
                        GoTo Erreur
                    End If


                    If (Qte = "") Then
                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("La numéro quantite n'est pas renseigné", Fichier, Ligne, Preactor)
                        Erreur = True
                        GoTo Erreur
                    End If


                    If (Qte = "0") Then
                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("La quantite est à 0", Fichier, Ligne, Preactor)
                        Erreur = True
                        GoTo Erreur
                    End If


                    If (CodeArticle = "") Then
                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("La code article n'est pas renseignée", Fichier, Ligne, Preactor)
                        Erreur = True
                        GoTo Erreur
                    End If

                    Identifiant = NumCommande + "_" + NumLigne + "_" + NumLivr

                    Record = Preactor.FindMatchingRecord(Pr_Demand.Order_No, 0, Identifiant)
                    If (Record <= 0) Then
                        Record = Preactor.CreateRecord(Pr_Demand.Table)
                    End If
                    Preactor.WriteField(Pr_Demand.Order_No, Record, Identifiant)
                    Preactor.WriteField(Pr_Demand.Part_No, Record, CodeArticle)
                    Preactor.WriteField(Pr_Demand.Quantity, Record, Qte.Replace(",", "."))
                    Preactor.WriteField(Pr_Demand.Demand_Date, Record, DateTime.ParseExact(Delai, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    Preactor.WriteField(Pr_Demand.String_Attribute_1, Record, NumLivr)
                    Preactor.WriteField(Pr_Demand.String_Attribute_2, Record, Client)
                    Preactor.WriteField(Pr_Demand.String_Attribute_3, Record, Designation)
                    Preactor.WriteField(Pr_Demand.String_Attribute_4, Record, DateImport)
                    Preactor.WriteField(Pr_Demand.Order_Line, Record, NumLigne)



                End If
Erreur:
            Next

            Pr_Demand.Init_List()

            Dim ListOrdre2 = (From ordre2 In Pr_Demand.ToList
                              Where ordre2.String_Attribute_4 <> DateImport
                              Order By ordre2.Record Descending Select ordre2).ToList.Distinct


            For Each Item In ListOrdre2
                Preactor.DeleteRecord(Pr_Demand.Table, Item.Record)
            Next

            Preactor.Commit(Pr_Demand.Table, "SCHEDULE")
        Catch ex As Exception

            Preactor.DestroyStatus()
            MsgBox(ex.Message)
        End Try

        Return 1
    End Function

#End Region

#Region "Import des nomenclatures"
    Public Function Run_ImportNomenclature(ByVal Preactor As IPreactor) As Integer


        Dim CodeOF As String
        Dim CodeOper As String
        Dim Composant As String
        Dim Quantite As String
        Dim Designation As String
        Dim DateImport As String


        Try
            Dim Separateur = System.Globalization.CultureInfo.InstalledUICulture.NumberFormat.NumberDecimalSeparator
            'Recuperation du chemin et fichiers parametres
            Chemin = Preactor.ReadFieldString(Pr_Chemins.Repertoire_des_fichiers_dimportation, 1)
            Fichier = Preactor.ReadFieldString(Pr_Chemins.Fichier_des_Nomenclatures_OF, 1)

            If (Chemin = "" Or Fichier = "") Then
                MessageBox.Show("Le chemin ou le dossier des nomenclatures n'est pas paramétré")
                Return 1
                Exit Function
            End If



            Path = Chemin + "\" + Fichier

            MyOutils = New Tools.Outils


            Dim MyList As List(Of List(Of String)) = MyOutils.Fich_to_List(CChar(";"), True)

            Preactor.DisplayStatus("MATRA  Importation des nomenclatures", "Mise à Jour des données", "Patientez SVP...")

            DateImport = Date.Now.ToString
            If MyList Is Nothing Then
                MessageBox.Show("Aucune donnée dans le fichier")
                Return 1
                Exit Function
            End If

            Preactor.DisplayStatus("MATRA  Importation des nomenclatures", "Mise à Jour des données", "Patientez SVP...")
            Index = 0
            For Each Item In MyList
                Index = Index + 1
                Preactor.UpdateStatus(Index, MyList.Count)
                Erreur = False

                'Test si l'Item contient tous les champs 
                If (Item.Count() < 5) Then
                    Ligne = "Ligne : " + Index.ToString
                    For Each Valeur In Item
                        Ligne = Ligne + "|" + Valeur
                    Next
                    MyOutils.ErrorToTable("Tous les champs ne sont pas renseignés", Fichier, Ligne, Preactor)
                    Erreur = True
                Else
                    CodeOF = Item(0)
                    CodeOper = Item(1)
                    Composant = Item(2)
                    Designation = Item(3)
                    Quantite = Item(4).Replace(",", Separateur)
                    Quantite = Item(4).Replace(".", Separateur)



                    'Test de la clé primaire
                    If (CodeOF = "") Then
                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("L'identifiant n'est pas renseigné", Fichier, Ligne, Preactor)
                        Erreur = True
                        GoTo Erreur
                    End If



                    Record = Preactor.FindMatchingRecord(Pr_Bill_of_Materials.Spare_String_Field_1, 0, CodeOF + "_" + CodeOper + "_" + Composant)
                    If (Record <= 0) Then
                        Record = Preactor.CreateRecord(Pr_Bill_of_Materials.Table)
                    End If
                    Preactor.WriteField(Pr_Bill_of_Materials.Spare_String_Field_1, Record, CodeOF + "_" + CodeOper + "_" + Composant)
                    Preactor.WriteField(Pr_Bill_of_Materials.Spare_String_Field_2, Record, DateImport)
                    Preactor.WriteField(Pr_Bill_of_Materials.Order_No, Record, CodeOF)
                    Preactor.WriteField(Pr_Bill_of_Materials.Belongs_to_BOM, Record, CodeOF)
                    Preactor.WriteField(Pr_Bill_of_Materials.Op_No, Record, CodeOper)
                    Preactor.WriteField(Pr_Bill_of_Materials.Required_Part_No, Record, Composant)
                    Preactor.WriteField(Pr_Bill_of_Materials.Required_Quantity, Record, Quantite)
                    Preactor.WriteField(Pr_Bill_of_Materials.Multiple_Quantity, Record, 0)
                    Preactor.WriteField(Pr_Bill_of_Materials.Multiply_by_order_quantity, Record, 0)
                    Preactor.WriteField(Pr_Bill_of_Materials.Spare_String_Field_3, Record, Designation)
                    Preactor.WriteField(Pr_Bill_of_Materials.Ignore_Shortages, Record, True)

                End If

                'On recherche la première opération de l'OF
                If (CodeOper = "0" Or CodeOper = "") Then

                    Dim preactorRecord = Preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, CodeOF)
                    If (preactorRecord > 0) Then
                        Dim operation = Preactor.ReadFieldInt(Pr_Orders.Op_No, preactorRecord)
                        Preactor.WriteField(Pr_Bill_of_Materials.Op_No, Record, operation)

                        If (Preactor.ReadFieldString(Pr_Orders.Part_No, preactorRecord) = Composant) Then
                            Preactor.DeleteRecord(Pr_Bill_of_Materials.Table, Record)
                        End If
                    End If

                End If


Erreur:
            Next

            Pr_Bill_of_Materials.Init_List()

            Dim ListOrdre2 = (From ordre2 In Pr_Bill_of_Materials.ToList
                              Where ordre2.Spare_String_Field_2 <> DateImport
                              Order By ordre2.Record Descending Select ordre2).ToList.Distinct


            For Each Item In ListOrdre2
                Preactor.DeleteRecord(Pr_Bill_of_Materials.Table, Item.Record)
            Next

            Preactor.Commit(Pr_Bill_of_Materials.Table, "SCHEDULE")
            Preactor.DestroyStatus()
        Catch ex As Exception

            Preactor.DestroyStatus()
            MsgBox(ex.Message)
        End Try

        Return 1
    End Function
#End Region

    '#Region "Import des Ofs"
    Public Function Run_ImportOFs(ByVal Preactor As IPreactor) As Integer

        Dim CodeOF As String
        Dim TypeOrdre As String
        Dim Client As String
        Dim Article As String
        Dim Designation As String
        Dim NoSeri As String
        Dim QteLanc As String
        Dim Priorite As String
        Dim CodeCondition As String
        Dim StatutOF As String
        Dim DateBesoin As String
        Dim CodeOper As String
        Dim DesignationOperation As String
        Dim DateDebut As String
        Dim DateFin As String
        Dim QteOperation As String
        Dim TempsRestant As String
        Dim TempsTransport As String
        Dim TempsDeTranportTemp As Double
        Dim DernierPointage As String
        Dim StatutOperation As String
        Dim Note As String
        Dim OpParallele As String
        Dim Centre As String
        Dim DescriptionCentre As String
        Dim Ilot As String
        Dim AJustementTemps As String
        Dim Support As String
        Dim Employe As String
        Dim Qualification As String
        Dim Gflux As String = ""
        Dim DateImport As String
        Dim Verrou As String
        Dim NBrow As Integer
        Dim ResRec As Integer
        Try

            Dim Separateur = System.Globalization.CultureInfo.InstalledUICulture.NumberFormat.NumberDecimalSeparator
            'Recuperation du chemin et fichiers parametres
            Chemin = Preactor.ReadFieldString(Pr_Chemins.Repertoire_des_fichiers_dimportation, 1)
            Fichier = Preactor.ReadFieldString(Pr_Chemins.Fichier_des_OFs_Fermes, 1)

            If (Chemin = "" Or Fichier = "") Then
                MessageBox.Show("Le chemin ou le dossier des OF n'est pas paramétré")
                Return 1
                Exit Function
            End If



            Path = Chemin + "\" + Fichier

            MyOutils = New Tools.Outils


            Dim MyList As List(Of List(Of String)) = MyOutils.Fich_to_List(CChar(";"), True)

            Preactor.DisplayStatus("MATRA  Importation des OF", "Mise à Jour des données", "Patientez SVP...")

            DateImport = Date.Now.ToString
            If MyList Is Nothing Then
                MessageBox.Show("Aucune donnée dans le fichier")
                Return 1
                Exit Function
            End If

            'Purge
            'On regarde s'il y a au moins 1 enregistrement
            NBrow = Preactor.RecordCount(Pr_Orders.Table)

            'RAZ Flag
            For i As Integer = 1 To NBrow
                Preactor.WriteField(Pr_Orders.Toggle_Attribute_1, i, 0)
                Preactor.WriteField(Pr_Orders.Toggle_Attribute_2, i, 0)
            Next



            For Each Item In MyList
                If (CodeOF <> "") Then


                    CodeOF = Item(2)
                    CodeOper = Item(5)

                    Dim Cpt = Preactor.FindMatchingRecord(Pr_Orders.Order_No, 0, CodeOF)

                    While (Cpt > 0)
                        Preactor.WriteField(Pr_Orders.Toggle_Attribute_2, Cpt, 1)
                        Cpt = Preactor.FindMatchingRecord(Pr_Orders.Order_No, Cpt, CodeOF)
                    End While

                    Dim Cpt2 = Preactor.FindMatchingRecord(Pr_Orders.Identifiant, 0, CodeOF + "_" + CodeOper)

                    While (Cpt2 > 0)
                        Preactor.WriteField(Pr_Orders.Toggle_Attribute_1, Cpt2, 1)
                        Cpt2 = Preactor.FindMatchingRecord(Pr_Orders.Identifiant, Cpt2, CodeOF + "_" + CodeOper)
                    End While

                End If
            Next


            'Purge des opérations 
            For i As Integer = NBrow To 1 Step -1
                If (Preactor.ReadFieldBool(Pr_Orders.Toggle_Attribute_2, i) = False) Then
                    Preactor.DeleteRecord(Pr_Orders.Table, i)
                End If
            Next
            Dim DateImport2 = Date.Now
            Preactor.Commit(Pr_Orders.Table, "SCHEDULE")
            Pr_Orders.Init_List()
            NBrow = Preactor.RecordCount(Pr_Orders.Table)
            Dim Cpt3 = 0
            'On met dans le passé les autres
            For i As Integer = 1 To NBrow
                If (Preactor.ReadFieldBool(Pr_Orders.Toggle_Attribute_1, i) = False) Then
                    Preactor.WriteField(Pr_Orders.Setup_Start, i, DateImport2.AddDays(-10).AddSeconds(Cpt3))
                    Preactor.WriteField(Pr_Orders.Start_Time, i, DateImport2.AddDays(-10).AddSeconds(Cpt3))
                    Preactor.WriteField(Pr_Orders.End_Time, i, DateImport2.AddDays(-10).AddSeconds(Cpt3 + 1))
                    Preactor.WriteField(Pr_Orders.Operation_Progress, i, "Terminée")
                    Preactor.WriteField(Pr_Orders.Use_Actual_Times, i, True)
                    Preactor.WriteField(Pr_Orders.Quantity, i, 0)
                    Preactor.WriteField(Pr_Orders.Mid_Batch_Quantity, Record, 0)
                    Preactor.WriteField(Pr_Orders.Mid_Batch_Time, Record, "Indéfini")
                    Cpt3 = Cpt3 + 2
                End If
            Next



            Preactor.DisplayStatus("MATRA  Importation des OF", "Mise à Jour des données", "Patientez SVP...")
            Preactor.Load(Pr_Orders.Table, "SCHEDULE")
            Index = 0
            For Each Item In MyList
                If (Item(0) = "10094880") Then
                    Dim ici = ""
                End If


                Preactor.UpdateStatus(Index, MyList.Count)
                Erreur = False

                'Test si l'Item contient tous les champs 
                If (Item.Count() < 29) Then
                    Ligne = "Ligne : " + Index.ToString
                    For Each Valeur In Item
                        Ligne = Ligne + "|" + Valeur
                    Next
                    MyOutils.ErrorToTable("Tous les champs ne sont pas renseignés", Fichier, Ligne, Preactor)
                    Erreur = True
                Else
                    CodeOF = Item(0)
                    TypeOrdre = Item(1)
                    Client = Item(2)
                    Article = Item(3)
                    Designation = Item(4)
                    NoSeri = Item(5)
                    QteLanc = Item(6).Replace(",", ".")
                    QteLanc = Item(6).Replace(",", Separateur)
                    QteLanc = Item(6).Replace(".", Separateur)
                    Priorite = Item(7)
                    CodeCondition = Item(8)
                    Gflux = Item(9)
                    StatutOF = Item(10)
                    DateBesoin = Item(11)
                    CodeOper = Item(12)
                    DesignationOperation = Item(13)
                    DateDebut = Item(14)
                    DateFin = Item(15)
                    QteOperation = Item(16).Replace(",", ".")
                    QteOperation = Item(16).Replace(",", Separateur)
                    QteOperation = Item(16).Replace(".", Separateur)
                    TempsRestant = Item(17).Replace(",", ".")
                    TempsRestant = Item(17).Replace(",", Separateur)
                    TempsRestant = Item(17).Replace(".", Separateur)
                    TempsTransport = Item(18).Replace(",", ".")
                    TempsTransport = Item(18).Replace(",", Separateur)
                    TempsTransport = Item(18).Replace(".", Separateur)
                    DernierPointage = Item(19)
                    StatutOperation = Item(20)
                    Note = Item(21)
                    OpParallele = Item(22)
                    Centre = Item(23)
                    DescriptionCentre = Item(24)
                    Ilot = Item(25)
                    AJustementTemps = Item(26)
                    Support = Item(27)
                    Employe = Item(28)
                    Qualification = Item(29)
                    Verrou = Item(30)

                    If (IsDate(DateDebut)) = False Then
                        DateDebut = ""
                    End If
                    'Test de la clé primaire
                    If (CodeOF = "") Then
                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("L'identifiant n'est pas renseigné", Fichier, Ligne, Preactor)
                        Erreur = True
                        GoTo Erreur
                    End If

                    If (IsNumeric(TempsRestant) = False) Then
                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("La temps restant n'est pas numerique", Fichier, Ligne, Preactor)
                        Erreur = True
                        GoTo Erreur
                    End If


                    If (IsNumeric(QteLanc) = False) Then
                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("La quantite lancee n'est pas numerique", Fichier, Ligne, Preactor)
                        Erreur = True
                        GoTo Erreur
                    End If


                    If (Convert.ToDouble(QteLanc) <= 0) Then
                        Ligne = "Ligne : " + Index.ToString + "|"
                        For Each Valeur In Item
                            Ligne = Ligne + "|" + Valeur
                        Next
                        MyOutils.ErrorToTable("La quantité n'est pas renseigné", Fichier, Ligne, Preactor)
                        Erreur = True
                        GoTo Erreur
                    End If


                    Record = Preactor.FindMatchingRecord(Pr_Orders.Identifiant, 0, CodeOF + "_" + CodeOper)
                    If (Record <= 0) Then
                        Record = Preactor.CreateRecord(Pr_Orders.Table)
                        Preactor.WriteField(Pr_Orders.Date_Attribute_1, Record, DateImport)
                    End If





                    'Preactor.WriteField(Pr_Orders.Identifiant, Record, CodeOF + "_" + CodeOper)
                    Preactor.WriteField(Pr_Orders.Belongs_to_Order_No, Record, CodeOF)
                        Preactor.WriteField(Pr_Orders.Order_No, Record, CodeOF)
                        Preactor.WriteField(Pr_Orders.Order_Type, Record, TypeOrdre)

                        Preactor.WriteField(Pr_Orders.Statut_Ordre, Record, StatutOF)
                        Preactor.WriteField(Pr_Orders.Statut_Operation, Record, StatutOperation)

                        Preactor.WriteField(Pr_Orders.Client, Record, Client)
                        Preactor.WriteField(Pr_Orders.Part_No, Record, Article)
                        Preactor.WriteField(Pr_Orders.Product, Record, Designation)
                        Preactor.WriteField(Pr_Orders.NoSeri, Record, NoSeri)
                        Preactor.WriteField(Pr_Orders.Quantity, Record, QteLanc)

                        If (Priorite <> "") Then
                            Dim recordattribut = Preactor.FindMatchingRecord(Pr_Attribute_1.Name, 0, Priorite)
                        If (recordattribut > 0) Then
                            Preactor.WriteField(Pr_Orders.Table_Attribute_1, Record, recordattribut)
                        Else

                            recordattribut = Preactor.FindMatchingRecord(Pr_Attribute_1.Name, 0, "Defaut")
                            If (recordattribut > 0) Then
                                Preactor.WriteField(Pr_Orders.Table_Attribute_1, Record, recordattribut)
                            End If
                        End If
                        Else
                            Dim recordattribut = Preactor.FindMatchingRecord(Pr_Attribute_1.Name, 0, "Defaut")
                            If (recordattribut > 0) Then
                                Preactor.WriteField(Pr_Orders.Table_Attribute_1, Record, recordattribut)
                            End If
                        End If
                        Preactor.WriteField(Pr_Orders.CodeCondition, Record, CodeCondition)
                        Preactor.WriteField(Pr_Orders.DateDebut, Record, DateDebut)
                        Preactor.WriteField(Pr_Orders.DateFin, Record, DateFin)


                    If (Index > 0) Then
                        If (MyList(Index - 1)(0) = CodeOF) Then
                            Preactor.WriteField(Pr_Orders.TempsTransport, Record, TempsDeTranportTemp / 24.0)
                        Else
                            TempsDeTranportTemp = 0.0
                        End If
                    End If

                    TempsDeTranportTemp = Convert.ToDouble(TempsTransport)

                    Preactor.WriteField(Pr_Orders.OpParallele, Record, OpParallele)
                        Preactor.WriteField(Pr_Orders.Centre, Record, Centre)
                        Preactor.WriteField(Pr_Orders.Description_Centre, Record, DescriptionCentre)
                        Preactor.WriteField(Pr_Orders.AJustementTemps, Record, AJustementTemps)
                        Preactor.WriteField(Pr_Orders.Support, Record, Support)

                        If (Priorite = "OF_BLOQUE") Then
                            Preactor.WriteField(Pr_Orders.Planifier, Record, 0)
                        Else
                            Preactor.WriteField(Pr_Orders.Planifier, Record, 1)
                        End If

                        If (Support = "") Then
                            Preactor.WriteField(Pr_Orders.SupportVisualisation, Record, 0)
                        Else
                            Preactor.WriteField(Pr_Orders.SupportVisualisation, Record, 1)
                            Preactor.WriteField(Pr_Orders.Planifier, Record, 0)
                        End If
                        Preactor.WriteField(Pr_Orders.Employe, Record, Employe)
                        Preactor.WriteField(Pr_Orders.Qualification, Record, Qualification)
                        Preactor.WriteField(Pr_Orders.GFLUX, Record, Gflux)
                        Preactor.WriteField(Pr_Orders.Order_Status, Record, StatutOF)

                        'If (DateDebut <> "") Then


                        '    If (Index > 0) Then
                        '        If (MyList(Index - 1)(0) <> MyList(Index)(0)) Then
                        '            Preactor.WriteField(Pr_Orders.Due_Date, Record, DateTime.ParseExact(DateDebut, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))

                        '        End If
                        '    Else
                        '        Preactor.WriteField(Pr_Orders.Due_Date, Record, DateTime.ParseExact(DateDebut, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))

                        '    End If
                        'Else
                        Preactor.WriteField(Pr_Orders.Due_Date, Record, DateTime.ParseExact(DateBesoin, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))

                    If (Priorite = "OF_BLOQUE" And StatutOF = "Debute") Then
                        Preactor.WriteField(Pr_Orders.Due_Date, Record, DateTime.ParseExact("31/12/2030", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                        Preactor.WriteField(Pr_Orders.Date_Attribute_2, Record, DateTime.ParseExact("31/12/2030", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    Else
                        Preactor.WriteField(Pr_Orders.Date_Attribute_2, Record, DateTime.ParseExact(DateBesoin, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    End If

                        'End If
                        Preactor.WriteField(Pr_Orders.Op_No, Record, CodeOper)
                        Preactor.WriteField(Pr_Orders.Operation_Name, Record, DesignationOperation)


                        Preactor.WriteField(Pr_Orders.Process_Time_Type, Record, "Temps par lot")

                        Preactor.WriteField(Pr_Orders.Batch_Time, Record, Convert.ToDouble(TempsRestant) / 24.0)

                        Preactor.WriteField(Pr_Orders.Notes, Record, Note)


                    'ResRec = Preactor.FindMatchingRecord(Pr_Resources.Name, 0, Ilot)
                    'If ResRec > 0 Then
                    '    Dim ResNum = Preactor.ReadFieldInt(Pr_Resources.Number, ResRec)
                    '    Preactor.WriteField(Pr_Orders.Required_Resource, Record, ResRec)
                    'End If

                    Preactor.WriteField(Pr_Orders.Resource_Group, Record, Ilot)

                    If (Verrou = "TRUE") Then

                        If (Convert.ToDateTime(DateDebut) < DateTime.Now) Then
                            DateDebut = DateTime.Now.ToString
                        End If

                        Preactor.WriteField(Pr_Orders.Setup_Start, Record, DateDebut)
                        Preactor.WriteField(Pr_Orders.Start_Time, Record, DateDebut)
                        Preactor.WriteField(Pr_Orders.End_Time, Record, "Indéfini")
                        Preactor.WriteField(Pr_Orders.Operation_Progress, Record, "En cours")

                        Dim NbMax = Preactor.MatrixFieldSize("Orders", "Resource Data", Record)
                        For j = 1 To NbMax.X
                            Dim matrixResource = Preactor.ReadFieldString("Orders", "Resource Data", Record, j)
                            Dim recordRessource = Preactor.FindMatchingRecord(Pr_Resources.Name, 0, Preactor.ReadFieldString(Pr_Orders.Resource_Data, Record, j))

                            If (recordRessource > 0) Then

                                Preactor.WriteField(Pr_Orders.Resource, Record, Preactor.ReadFieldString(Pr_Resources.Name, recordRessource))
                                Exit For
                            End If

                        Next j
                        Preactor.WriteField(Pr_Orders.Use_Actual_Times, Record, True)
                        If (Convert.ToInt32(QteLanc) > 0) Then
                            Preactor.WriteField(Pr_Orders.Mid_Batch_Quantity, Record, Convert.ToInt32(QteLanc) - 1)

                        Else
                            Preactor.WriteField(Pr_Orders.Mid_Batch_Quantity, Record, 0)
                        End If
                        Preactor.WriteField(Pr_Orders.Mid_Batch_Time, Record, DateDebut)
                    End If

                    Preactor.UpdateRecord(Pr_Orders.Table, Record)

                    End If
Erreur:
                Index = Index + 1
            Next

            'Recuperation de la designation article



            'Pr_Orders.Init_List()

            'Dim ListOrdre2 = (From ordre2 In Pr_Orders.ToList
            '                  Where (ordre2.DateImport <> DateImport Or ordre2.Quantity <= 0 Or ordre2.Order_Status = "Terminée") AndAlso ordre2.Order_Type <> "Vente"
            '                  Order By ordre2.Record Descending Select ordre2).ToList.Distinct


            'For Each Item In ListOrdre2
            '    Preactor.DeleteRecord(Pr_Orders.Table, Item.Record)
            'Next

            Preactor.Commit(Pr_Orders.Table, "SCHEDULE")
            Preactor.DestroyStatus()
        Catch ex As Exception

            Preactor.DestroyStatus()
            MsgBox(ex.Message)
        End Try

        Return 1
    End Function
End Module
