Option Strict On
Option Explicit On

Imports Preactor.Interop.PreactorObject
Imports Preactor

 '*****************************************************
' FIELDS
 '*****************************************************

Friend Class Fields

Private Sub New()
End Sub

Friend Shared PR As IPreactor

Friend Shared Sub init(ByVal PR As IPreactor)

Fields.PR = PR

Pr_Custom_Check_Configuration.init(PR)
Pr_Preactor_Custom_Checks.init(PR)
Pr_External_Data_Mapping.init(PR)
Pr_Operation_Property_Settings.init(PR)
Pr_Sequencer_Settings.init(PR)
Pr_Extract_Settings.init(PR)
Pr_Application_Settings.init(PR)
Pr_Colors.init(PR)
Pr_Colours.init(PR)
Pr_Patterns.init(PR)
Pr_Constraint_Usage.init(PR)
Pr_Interval_Types.init(PR)
Pr_Effects.init(PR)
Pr_Time_Items.init(PR)
Pr_Finite.init(PR)
Pr_Window_State.init(PR)
Pr_Resource_Display_Options.init(PR)
Pr_Resource_Display_Styles.init(PR)
Pr_Seq_Overview_Modes.init(PR)
Pr_Process_Time_Type_Lookup.init(PR)
Pr_Batching_Method_Lookup.init(PR)
Pr_Cost_Behaviour_Lookup.init(PR)
Pr_Operation_Progress_Lookup.init(PR)
Pr_SMC_Rule_Types_Lookup.init(PR)
Pr_Order_Types.init(PR)
Pr_Stock_Flag_Lookup.init(PR)
Pr_Advanced_Filter_Settings.init(PR)
Pr_Format_Advanced_Filter_Selection.init(PR)
Pr_Order_Enquiry_Shortages.init(PR)
Pr_Setting_Set.init(PR)
Pr_SMT_Side.init(PR)
Pr_Preferred_Sequence_Fields.init(PR)
Pr_PSA_Setup.init(PR)
Pr_PSA_Order_Comparison_Files.init(PR)
Pr_PSA_Order_Comparison_Configuration.init(PR)
Pr_PSA_Order_Comparison_Actions.init(PR)
Pr_Support_Settings.init(PR)
Pr_SIMATIC_IT_Alerts.init(PR)
Pr_MES_Integration_Settings.init(PR)
Pr_Certificates.init(PR)
Pr_Calendar_States.init(PR)
Pr_Primary_Resource_Templates.init(PR)
Pr_Primary_Resource_Template_Periods.init(PR)
Pr_Primary_Calendar_Periods.init(PR)
Pr_Secondary_Resource_Templates.init(PR)
Pr_Secondary_Resource_Template_Periods.init(PR)
Pr_Secondary_Calendar_Periods.init(PR)
Pr_Calendar_Settings.init(PR)
Pr_Capacity_Group_Templates.init(PR)
Pr_Capacity_Group_Template_Periods.init(PR)
Pr_Capacity_Group_Calendar_Periods.init(PR)
Pr_Planning_Group_Templates.init(PR)
Pr_Planning_Group_Template_Periods.init(PR)
Pr_Planning_Group_Calendar_Periods.init(PR)
Pr_Sku_Templates.init(PR)
Pr_Sku_Template_Periods.init(PR)
Pr_Sku_Calendar_Periods.init(PR)
Pr_Sku_Planning_Group_Templates.init(PR)
Pr_Sku_Planning_Group_Template_Periods.init(PR)
Pr_Sku_Planning_Group_Calendar_Periods.init(PR)
Pr_MILP_Solver_Settings.init(PR)
Pr_Initial_Stock_Levels_With_Age.init(PR)
Pr_Product_Transport.init(PR)
Pr_Transport_Link.init(PR)
Pr_Sku_Planning_Group.init(PR)
Pr_Xcelerator_Share_Settings.init(PR)
Pr_Shortages.init(PR)
Pr_Supply.init(PR)
Pr_Demand.init(PR)
Pr_Bill_of_Materials.init(PR)
Pr_Product_Bill_of_Materials.init(PR)
Pr_Co_products.init(PR)
Pr_Product_Co_products.init(PR)
Pr_Purchased_Items.init(PR)
Pr_Ignore_Shortages.init(PR)
Pr_Order_Links.init(PR)
Pr_Material_Control_Configuration.init(PR)
Pr_Pegging_Rule_Set.init(PR)
Pr_Pegging_Rules.init(PR)
Pr_Orders.init(PR)
Pr_Products.init(PR)
Pr_Resource_Groups.init(PR)
Pr_Resources.init(PR)
Pr_Secondary_Constraints.init(PR)
Pr_Secondary_Constraint_Groups.init(PR)
Pr_Order_Status.init(PR)
Pr_Attribute_1.init(PR)
Pr_Attribute_2.init(PR)
Pr_Attribute_3.init(PR)
Pr_Attribute_4.init(PR)
Pr_Attribute_5.init(PR)
Pr_Sequencer_Configuration.init(PR)
Pr_Import_Export_Mapping.init(PR)
Pr_Data_Transfer_Mapping.init(PR)
Pr_Menu_Button_Mapping.init(PR)
Pr_Workspace_Files.init(PR)
Pr_APS_Rules_Dialog.init(PR)
Pr_Bottleneck_Selection.init(PR)
Pr_Preferred_Sequence_Dialog.init(PR)
Pr_Minimize_Setup_Dialog.init(PR)
Pr_Campaigning_Rule_Dialog.init(PR)
Pr_Demand_Status.init(PR)
Pr_Changeover_Groups.init(PR)
Pr_Tool_Configuration.init(PR)
Pr_Chemins.init(PR)
Pr_Erreurs.init(PR)
Pr_Lien.init(PR)

End Sub

End Class


Friend Class Pr_Custom_Check_Configuration
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Project_Name As FormatFieldPair
Friend Shared Class_Name As FormatFieldPair
Friend Shared Initialize_Function_Name As FormatFieldPair
Friend Shared Alternate_Return_Code_Function_Name As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Custom Check Configuration")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Project_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Project Name"))
Class_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Class Name"))
Initialize_Function_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Initialize Function Name"))
Alternate_Return_Code_Function_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Alternate Return Code Function Name"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Project_Name = Fields.PR.ReadFieldString(Project_Name, Record)
MyItem.Class_Name = Fields.PR.ReadFieldString(Class_Name, Record)
MyItem.Initialize_Function_Name = Fields.PR.ReadFieldString(Initialize_Function_Name, Record)
MyItem.Alternate_Return_Code_Function_Name = Fields.PR.ReadFieldString(Alternate_Return_Code_Function_Name, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Project_Name As String
Friend Class_Name As String
Friend Initialize_Function_Name As String
Friend Alternate_Return_Code_Function_Name As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Preactor_Custom_Checks
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Preactor Custom Checks")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_External_Data_Mapping
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Parent As FormatFieldPair
Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Data_Source_Type As FormatFieldPair
Friend Shared Data_Source_Name As FormatFieldPair
Friend Shared DataSet As FormatFieldPair
Friend Shared Query_Text As FormatFieldPair
Friend Shared Use_Credentials As FormatFieldPair
Friend Shared User_Name As FormatFieldPair
Friend Shared Password As FormatFieldPair
Friend Shared Mapping_Type As FormatFieldPair
Friend Shared Preactor_Table_Name As FormatFieldPair
Friend Shared Native_Table As FormatFieldPair
Friend Shared Description As FormatFieldPair
Friend Shared Enabled As FormatFieldPair
Friend Shared File_To_Import_From As FormatFieldPair
Friend Shared Separator As FormatFieldPair
Friend Shared Header_Included As FormatFieldPair
Friend Shared Preactor_Field_ID As FormatFieldPair
Friend Shared Column_Number As FormatFieldPair
Friend Shared Field_Type As FormatFieldPair
Friend Shared Field_Format As FormatFieldPair
Friend Shared On_Append As FormatFieldPair
Friend Shared On_Update As FormatFieldPair
Friend Shared On_Change As FormatFieldPair
Friend Shared On_No_Change As FormatFieldPair
Friend Shared Import_Identifier As FormatFieldPair
Friend Shared IgnoreBlankStrings As FormatFieldPair
Friend Shared Windows_Encoding As FormatFieldPair
Friend Shared Codepage As FormatFieldPair
Friend Shared Authorization_Mode As FormatFieldPair
Friend Shared Authorization_Certificate As FormatFieldPair
Friend Shared Query_Timeout As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("External Data Mapping")

Parent = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Parent"))
Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Data_Source_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Data Source Type"))
Data_Source_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Data Source Name"))
DataSet = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "DataSet"))
Query_Text = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Query Text"))
Use_Credentials = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Use Credentials"))
User_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Name"))
Password = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Password"))
Mapping_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Mapping Type"))
Preactor_Table_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Preactor Table Name"))
Native_Table = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Native Table"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))
Enabled = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Enabled"))
File_To_Import_From = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "File To Import From"))
Separator = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Separator"))
Header_Included = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Header Included"))
Preactor_Field_ID = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Preactor Field ID"))
Column_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Column Number"))
Field_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Field Type"))
Field_Format = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Field Format"))
On_Append = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "On Append"))
On_Update = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "On Update"))
On_Change = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "On Change"))
On_No_Change = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "On No Change"))
Import_Identifier = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Import Identifier"))
IgnoreBlankStrings = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "IgnoreBlankStrings"))
Windows_Encoding = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Windows Encoding"))
Codepage = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Codepage"))
Authorization_Mode = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Authorization Mode"))
Authorization_Certificate = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Authorization Certificate"))
Query_Timeout = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Query Timeout"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Parent = Fields.PR.ReadFieldString(Parent, Record)
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Data_Source_Type = Fields.PR.ReadFieldString(Data_Source_Type, Record)
MyItem.Data_Source_Name = Fields.PR.ReadFieldString(Data_Source_Name, Record)
MyItem.DataSet = Fields.PR.ReadFieldString(DataSet, Record)
MyItem.Query_Text = Fields.PR.ReadFieldString(Query_Text, Record)
MyItem.Use_Credentials = Fields.PR.ReadFieldBool(Use_Credentials, Record)
MyItem.User_Name = Fields.PR.ReadFieldString(User_Name, Record)
MyItem.Password = Fields.PR.ReadFieldString(Password, Record)
MyItem.Mapping_Type = Fields.PR.ReadFieldInt(Mapping_Type, Record)
MyItem.Preactor_Table_Name = Fields.PR.ReadFieldInt(Preactor_Table_Name, Record)
MyItem.Native_Table = Fields.PR.ReadFieldString(Native_Table, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)
MyItem.Enabled = Fields.PR.ReadFieldBool(Enabled, Record)
MyItem.File_To_Import_From = Fields.PR.ReadFieldString(File_To_Import_From, Record)
MyItem.Separator = Fields.PR.ReadFieldString(Separator, Record)
MyItem.Header_Included = Fields.PR.ReadFieldBool(Header_Included, Record)
MyItem.Preactor_Field_ID = Fields.PR.ReadFieldString(Preactor_Field_ID, Record)
MyItem.Column_Number = Fields.PR.ReadFieldInt(Column_Number, Record)
MyItem.Field_Type = Fields.PR.ReadFieldString(Field_Type, Record)
MyItem.Field_Format = Fields.PR.ReadFieldString(Field_Format, Record)
MyItem.On_Append = Fields.PR.ReadFieldString(On_Append, Record)
MyItem.On_Update = Fields.PR.ReadFieldString(On_Update, Record)
MyItem.On_Change = Fields.PR.ReadFieldString(On_Change, Record)
MyItem.On_No_Change = Fields.PR.ReadFieldString(On_No_Change, Record)
MyItem.Import_Identifier = Fields.PR.ReadFieldBool(Import_Identifier, Record)
MyItem.IgnoreBlankStrings = Fields.PR.ReadFieldBool(IgnoreBlankStrings, Record)
MyItem.Windows_Encoding = Fields.PR.ReadFieldBool(Windows_Encoding, Record)
MyItem.Codepage = Fields.PR.ReadFieldInt(Codepage, Record)
MyItem.Authorization_Mode = Fields.PR.ReadFieldInt(Authorization_Mode, Record)
MyItem.Authorization_Certificate = Fields.PR.ReadFieldString(Authorization_Certificate, Record)
MyItem.Query_Timeout = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Query_Timeout, Record))

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Parent As String
Friend Number As Integer
Friend Name As String
Friend Data_Source_Type As String
Friend Data_Source_Name As String
Friend DataSet As String
Friend Query_Text As String
Friend Use_Credentials As Boolean
Friend User_Name As String
Friend Password As String
Friend Mapping_Type As Integer
Friend Preactor_Table_Name As Integer
Friend Native_Table As String
Friend Description As String
Friend Enabled As Boolean
Friend File_To_Import_From As String
Friend Separator As String
Friend Header_Included As Boolean
Friend Preactor_Field_ID As String
Friend Column_Number As Integer
Friend Field_Type As String
Friend Field_Format As String
Friend On_Append As String
Friend On_Update As String
Friend On_Change As String
Friend On_No_Change As String
Friend Import_Identifier As Boolean
Friend IgnoreBlankStrings As Boolean
Friend Windows_Encoding As Boolean
Friend Codepage As Integer
Friend Authorization_Mode As Integer
Friend Authorization_Certificate As String
Friend Query_Timeout As TimeSpan
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Operation_Property_Settings
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Key As FormatFieldPair
Friend Shared Value As FormatFieldPair
Friend Shared Set_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Operation Property Settings")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Key = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Key"))
Value = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Value"))
Set_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Set Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Key = Fields.PR.ReadFieldString(Key, Record)
MyItem.Value = Fields.PR.ReadFieldString(Value, Record)
MyItem.Set_Id = Fields.PR.ReadFieldInt(Set_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Key As String
Friend Value As String
Friend Set_Id As Integer
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Sequencer_Settings
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Key As FormatFieldPair
Friend Shared Value As FormatFieldPair
Friend Shared Set_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Sequencer Settings")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Key = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Key"))
Value = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Value"))
Set_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Set Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Key = Fields.PR.ReadFieldString(Key, Record)
MyItem.Value = Fields.PR.ReadFieldString(Value, Record)
MyItem.Set_Id = Fields.PR.ReadFieldInt(Set_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Key As String
Friend Value As String
Friend Set_Id As Integer
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Extract_Settings
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Key As FormatFieldPair
Friend Shared Value As FormatFieldPair
Friend Shared Set_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Extract Settings")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Key = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Key"))
Value = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Value"))
Set_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Set Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Key = Fields.PR.ReadFieldString(Key, Record)
MyItem.Value = Fields.PR.ReadFieldString(Value, Record)
MyItem.Set_Id = Fields.PR.ReadFieldInt(Set_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Key As String
Friend Value As String
Friend Set_Id As Integer
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Application_Settings
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Register_COM_Object_in_the_ROT As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Application Settings")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Register_COM_Object_in_the_ROT = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Register COM Object in the ROT"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Register_COM_Object_in_the_ROT = Fields.PR.ReadFieldBool(Register_COM_Object_in_the_ROT, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Register_COM_Object_in_the_ROT As Boolean
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Colors
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Colors")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Colours
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Colours")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Patterns
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Patterns")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Constraint_Usage
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Constraint Usage")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Interval_Types
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Interval Types")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Effects
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Effects")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Time_Items
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Time Items")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Finite
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Finite")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Window_State
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Window State")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Resource_Display_Options
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Resource Display Options")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Resource_Display_Styles
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Resource Display Styles")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Seq_Overview_Modes
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Seq Overview Modes")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Process_Time_Type_Lookup
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Process Time Type Lookup")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Batching_Method_Lookup
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Batching Method Lookup")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Cost_Behaviour_Lookup
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Cost Behaviour Lookup")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Operation_Progress_Lookup
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Operation Progress Lookup")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_SMC_Rule_Types_Lookup
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("SMC Rule Types Lookup")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Order_Types
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Order Types")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Stock_Flag_Lookup
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Stock Flag Lookup")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Advanced_Filter_Settings
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Format As FormatFieldPair
Friend Shared Type As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Expression As FormatFieldPair
Friend Shared Parent As FormatFieldPair
Friend Shared Operator_ As FormatFieldPair
Friend Shared Reference As FormatFieldPair
Friend Shared SystemType As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Advanced Filter Settings")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Format = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Format"))
Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Type"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Expression = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Expression"))
Parent = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Parent"))
Operator_ = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operator"))
Reference = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference"))
SystemType = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "SystemType"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Format = Fields.PR.ReadFieldString(Format, Record)
MyItem.Type = Fields.PR.ReadFieldInt(Type, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Expression = Fields.PR.ReadFieldString(Expression, Record)
MyItem.Parent = Fields.PR.ReadFieldInt(Parent, Record)
MyItem.Operator_ = Fields.PR.ReadFieldInt(Operator_, Record)
MyItem.Reference = Fields.PR.ReadFieldInt(Reference, Record)
MyItem.SystemType = Fields.PR.ReadFieldInt(SystemType, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Format As String
Friend Type As Integer
Friend Name As String
Friend Expression As String
Friend Parent As Integer
Friend Operator_ As Integer
Friend Reference As Integer
Friend SystemType As Integer
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Format_Advanced_Filter_Selection
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Format As FormatFieldPair
Friend Shared FilterId As FormatFieldPair
Friend Shared Type As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Format Advanced Filter Selection")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Format = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Format"))
FilterId = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "FilterId"))
Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Type"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Format = Fields.PR.ReadFieldString(Format, Record)
MyItem.FilterId = Fields.PR.ReadFieldInt(FilterId, Record)
MyItem.Type = Fields.PR.ReadFieldInt(Type, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Format As String
Friend FilterId As Integer
Friend Type As Integer
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Order_Enquiry_Shortages
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Part_No As FormatFieldPair
Friend Shared Quantity As FormatFieldPair
Friend Shared Source_Table_Index As FormatFieldPair
Friend Shared Source_Record_Key As FormatFieldPair
Friend Shared Create_Order_Preference As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Order Enquiry Shortages")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Part No."))
Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Quantity"))
Source_Table_Index = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Source Table Index"))
Source_Record_Key = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Source Record Key"))
Create_Order_Preference = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Create Order Preference"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Part_No = Fields.PR.ReadFieldString(Part_No, Record)
MyItem.Quantity = Fields.PR.ReadFieldDouble(Quantity, Record)
MyItem.Source_Table_Index = Fields.PR.ReadFieldInt(Source_Table_Index, Record)
MyItem.Source_Record_Key = Fields.PR.ReadFieldInt(Source_Record_Key, Record)
MyItem.Create_Order_Preference = Fields.PR.ReadFieldString(Create_Order_Preference, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Part_No As String
Friend Quantity As Double
Friend Source_Table_Index As Integer
Friend Source_Record_Key As Integer
Friend Create_Order_Preference As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Setting_Set
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Set_Name As FormatFieldPair
Friend Shared Selected As FormatFieldPair
Friend Shared Settings_Table As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Setting Set")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Set_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Set Name"))
Selected = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Selected"))
Settings_Table = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Settings Table"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Set_Name = Fields.PR.ReadFieldString(Set_Name, Record)
MyItem.Selected = Fields.PR.ReadFieldBool(Selected, Record)
MyItem.Settings_Table = Fields.PR.ReadFieldString(Settings_Table, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Set_Name As String
Friend Selected As Boolean
Friend Settings_Table As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_SMT_Side
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("SMT Side")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Preferred_Sequence_Fields
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Critical_Ratio As FormatFieldPair
Friend Shared Dynamic_Priority As FormatFieldPair
Friend Shared Process_Time As FormatFieldPair
Friend Shared Setup_Time As FormatFieldPair
Friend Shared Dynamic_Critical_Ratio As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Preferred Sequence Fields")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Critical_Ratio = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Critical Ratio"))
Dynamic_Priority = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Dynamic Priority"))
Process_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Process Time"))
Setup_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Setup Time"))
Dynamic_Critical_Ratio = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Dynamic Critical Ratio"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Critical_Ratio = Fields.PR.ReadFieldInt(Critical_Ratio, Record)
MyItem.Dynamic_Priority = Fields.PR.ReadFieldInt(Dynamic_Priority, Record)
MyItem.Process_Time = Fields.PR.ReadFieldInt(Process_Time, Record)
MyItem.Setup_Time = Fields.PR.ReadFieldInt(Setup_Time, Record)
MyItem.Dynamic_Critical_Ratio = Fields.PR.ReadFieldInt(Dynamic_Critical_Ratio, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Critical_Ratio As Integer
Friend Dynamic_Priority As Integer
Friend Process_Time As Integer
Friend Setup_Time As Integer
Friend Dynamic_Critical_Ratio As Integer
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_PSA_Setup
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Week_Start_Day As FormatFieldPair
Friend Shared Filename As FormatFieldPair
Friend Shared Resource As FormatFieldPair
Friend Shared Resource_Group As FormatFieldPair
Friend Shared Secondary_Resource As FormatFieldPair
Friend Shared Attribute_Field_Name As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("PSA Setup")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Week_Start_Day = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Week Start Day"))
Filename = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Filename"))
Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource"))
Resource_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Group"))
Secondary_Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Secondary Resource"))
Attribute_Field_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute Field Name"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Week_Start_Day = Fields.PR.ReadFieldString(Week_Start_Day, Record)
MyItem.Filename = Fields.PR.ReadFieldString(Filename, Record)
MyItem.Resource = Fields.PR.ReadFieldString(Resource, Record)
MyItem.Resource_Group = Fields.PR.ReadFieldString(Resource_Group, Record)
MyItem.Secondary_Resource = Fields.PR.ReadFieldString(Secondary_Resource, Record)
MyItem.Attribute_Field_Name = Fields.PR.ReadFieldString(Attribute_Field_Name, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Week_Start_Day As String
Friend Filename As String
Friend Resource As String
Friend Resource_Group As String
Friend Secondary_Resource As String
Friend Attribute_Field_Name As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_PSA_Order_Comparison_Files
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared XML_Filename As FormatFieldPair
Friend Shared XSL_Filename As FormatFieldPair
Friend Shared CSS_Filename As FormatFieldPair
Friend Shared Publish_Folder As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("PSA Order Comparison Files")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
XML_Filename = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "XML Filename"))
XSL_Filename = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "XSL Filename"))
CSS_Filename = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "CSS Filename"))
Publish_Folder = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Publish Folder"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.XML_Filename = Fields.PR.ReadFieldString(XML_Filename, Record)
MyItem.XSL_Filename = Fields.PR.ReadFieldString(XSL_Filename, Record)
MyItem.CSS_Filename = Fields.PR.ReadFieldString(CSS_Filename, Record)
MyItem.Publish_Folder = Fields.PR.ReadFieldString(Publish_Folder, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend XML_Filename As String
Friend XSL_Filename As String
Friend CSS_Filename As String
Friend Publish_Folder As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_PSA_Order_Comparison_Configuration
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Field_Name As FormatFieldPair
Friend Shared Tab_Title As FormatFieldPair
Friend Shared Action As FormatFieldPair
Friend Shared Eval_Switch As FormatFieldPair
Friend Shared Color_Switch As FormatFieldPair
Friend Shared Exclude As FormatFieldPair
Friend Shared Evaluate As FormatFieldPair
Friend Shared Evaluated_Color As FormatFieldPair
Friend Shared Visible As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("PSA Order Comparison Configuration")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Field_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Field Name"))
Tab_Title = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Tab Title"))
Action = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Action"))
Eval_Switch = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Eval Switch"))
Color_Switch = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Color Switch"))
Exclude = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Exclude"))
Evaluate = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Evaluate"))
Evaluated_Color = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Evaluated Color"))
Visible = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Visible"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Field_Name = Fields.PR.ReadFieldString(Field_Name, Record)
MyItem.Tab_Title = Fields.PR.ReadFieldString(Tab_Title, Record)
MyItem.Action = Fields.PR.ReadFieldString(Action, Record)
MyItem.Eval_Switch = Fields.PR.ReadFieldBool(Eval_Switch, Record)
MyItem.Color_Switch = Fields.PR.ReadFieldBool(Color_Switch, Record)
MyItem.Exclude = Fields.PR.ReadFieldString(Exclude, Record)
MyItem.Evaluate = Fields.PR.ReadFieldString(Evaluate, Record)
MyItem.Evaluated_Color = Fields.PR.ReadFieldString(Evaluated_Color, Record)
MyItem.Visible = Fields.PR.ReadFieldBool(Visible, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Field_Name As String
Friend Tab_Title As String
Friend Action As String
Friend Eval_Switch As Boolean
Friend Color_Switch As Boolean
Friend Exclude As String
Friend Evaluate As String
Friend Evaluated_Color As String
Friend Visible As Boolean
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_PSA_Order_Comparison_Actions
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Description As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("PSA Order Comparison Actions")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Description As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Support_Settings
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared RealSupportEmailAddress As FormatFieldPair
Friend Shared Override As FormatFieldPair
Friend Shared Support_Email_Address As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Support Settings")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
RealSupportEmailAddress = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "RealSupportEmailAddress"))
Override = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Override?"))
Support_Email_Address = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Support Email Address"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.RealSupportEmailAddress = Fields.PR.ReadFieldString(RealSupportEmailAddress, Record)
MyItem.Override = Fields.PR.ReadFieldBool(Override, Record)
MyItem.Support_Email_Address = Fields.PR.ReadFieldString(Support_Email_Address, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend RealSupportEmailAddress As String
Friend Override As Boolean
Friend Support_Email_Address As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_SIMATIC_IT_Alerts
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Belongs_To_Family As FormatFieldPair
Friend Shared Number As FormatFieldPair
Friend Shared Read_Status As FormatFieldPair
Friend Shared Order_Id As FormatFieldPair
Friend Shared Reason As FormatFieldPair
Friend Shared User As FormatFieldPair
Friend Shared Operation_Id As FormatFieldPair
Friend Shared Change_Type As FormatFieldPair
Friend Shared Operation As FormatFieldPair
Friend Shared Op_Reason As FormatFieldPair
Friend Shared Routing_Change As FormatFieldPair
Friend Shared Property_Name As FormatFieldPair
Friend Shared Old_Value As FormatFieldPair
Friend Shared New_Value As FormatFieldPair
Friend Shared Type As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("SIMATIC IT Alerts")

Belongs_To_Family = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Belongs To Family"))
Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Read_Status = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Read Status"))
Order_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Id"))
Reason = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reason"))
User = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User"))
Operation_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation Id"))
Change_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Change Type"))
Operation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation"))
Op_Reason = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Op. Reason"))
Routing_Change = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Routing Change"))
Property_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Property Name"))
Old_Value = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Old Value"))
New_Value = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "New Value"))
Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Type"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Belongs_To_Family = Fields.PR.ReadFieldString(Belongs_To_Family, Record)
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Read_Status = Fields.PR.ReadFieldBool(Read_Status, Record)
MyItem.Order_Id = Fields.PR.ReadFieldString(Order_Id, Record)
MyItem.Reason = Fields.PR.ReadFieldString(Reason, Record)
MyItem.User = Fields.PR.ReadFieldString(User, Record)
MyItem.Operation_Id = Fields.PR.ReadFieldString(Operation_Id, Record)
MyItem.Change_Type = Fields.PR.ReadFieldString(Change_Type, Record)
MyItem.Operation = Fields.PR.ReadFieldString(Operation, Record)
MyItem.Op_Reason = Fields.PR.ReadFieldString(Op_Reason, Record)
MyItem.Routing_Change = Fields.PR.ReadFieldString(Routing_Change, Record)
MyItem.Property_Name = Fields.PR.ReadFieldString(Property_Name, Record)
MyItem.Old_Value = Fields.PR.ReadFieldString(Old_Value, Record)
MyItem.New_Value = Fields.PR.ReadFieldString(New_Value, Record)
MyItem.Type = Fields.PR.ReadFieldString(Type, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Belongs_To_Family As String
Friend Number As Integer
Friend Read_Status As Boolean
Friend Order_Id As String
Friend Reason As String
Friend User As String
Friend Operation_Id As String
Friend Change_Type As String
Friend Operation As String
Friend Op_Reason As String
Friend Routing_Change As String
Friend Property_Name As String
Friend Old_Value As String
Friend New_Value As String
Friend Type As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_MES_Integration_Settings
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Alerts_Enabled As FormatFieldPair
Friend Shared Refresh_Frequency As FormatFieldPair
Friend Shared Target_Platform As FormatFieldPair
Friend Shared Show_UA_Fields As FormatFieldPair
Friend Shared Publish_Dataset As FormatFieldPair
Friend Shared Service_URI As FormatFieldPair
Friend Shared Certificate As FormatFieldPair
Friend Shared OData_Command___Query_Timeout As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("MES Integration Settings")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Alerts_Enabled = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Alerts Enabled"))
Refresh_Frequency = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Refresh Frequency"))
Target_Platform = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Target Platform"))
Show_UA_Fields = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Show UA Fields"))
Publish_Dataset = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Publish Dataset"))
Service_URI = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Service URI"))
Certificate = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Certificate"))
OData_Command___Query_Timeout = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "OData Command / Query Timeout"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Alerts_Enabled = Fields.PR.ReadFieldBool(Alerts_Enabled, Record)
MyItem.Refresh_Frequency = Fields.PR.ReadFieldInt(Refresh_Frequency, Record)
MyItem.Target_Platform = Fields.PR.ReadFieldString(Target_Platform, Record)
MyItem.Show_UA_Fields = Fields.PR.ReadFieldBool(Show_UA_Fields, Record)
MyItem.Publish_Dataset = Fields.PR.ReadFieldString(Publish_Dataset, Record)
MyItem.Service_URI = Fields.PR.ReadFieldString(Service_URI, Record)
MyItem.Certificate = Fields.PR.ReadFieldString(Certificate, Record)
MyItem.OData_Command___Query_Timeout = Fields.PR.ReadFieldInt(OData_Command___Query_Timeout, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Alerts_Enabled As Boolean
Friend Refresh_Frequency As Integer
Friend Target_Platform As String
Friend Show_UA_Fields As Boolean
Friend Publish_Dataset As String
Friend Service_URI As String
Friend Certificate As String
Friend OData_Command___Query_Timeout As Integer
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Certificates
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Title As FormatFieldPair
Friend Shared Thumbprint As FormatFieldPair
Friend Shared From_Store As FormatFieldPair
Friend Shared Store As FormatFieldPair
Friend Shared Location As FormatFieldPair
Friend Shared Path As FormatFieldPair
Friend Shared Password As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Certificates")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Title = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Title"))
Thumbprint = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Thumbprint"))
From_Store = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "From Store"))
Store = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Store"))
Location = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Location"))
Path = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Path"))
Password = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Password"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Title = Fields.PR.ReadFieldString(Title, Record)
MyItem.Thumbprint = Fields.PR.ReadFieldString(Thumbprint, Record)
MyItem.From_Store = Fields.PR.ReadFieldBool(From_Store, Record)
MyItem.Store = Fields.PR.ReadFieldString(Store, Record)
MyItem.Location = Fields.PR.ReadFieldString(Location, Record)
MyItem.Path = Fields.PR.ReadFieldString(Path, Record)
MyItem.Password = Fields.PR.ReadFieldString(Password, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Title As String
Friend Thumbprint As String
Friend From_Store As Boolean
Friend Store As String
Friend Location As String
Friend Path As String
Friend Password As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Calendar_States
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Color As FormatFieldPair
Friend Shared Pattern As FormatFieldPair
Friend Shared Efficiency As FormatFieldPair
Friend Shared Cost_Factor As FormatFieldPair
Friend Shared Is_Setup_Allowed As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Calendar States")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Color = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Color"))
Pattern = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Pattern"))
Efficiency = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Efficiency"))
Cost_Factor = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Cost Factor"))
Is_Setup_Allowed = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Is Setup Allowed?"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Color = Fields.PR.ReadFieldString(Color, Record)
MyItem.Pattern = Fields.PR.ReadFieldInt(Pattern, Record)
MyItem.Efficiency = Fields.PR.ReadFieldDouble(Efficiency, Record)
MyItem.Cost_Factor = Fields.PR.ReadFieldDouble(Cost_Factor, Record)
MyItem.Is_Setup_Allowed = Fields.PR.ReadFieldBool(Is_Setup_Allowed, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Color As String
Friend Pattern As Integer
Friend Efficiency As Double
Friend Cost_Factor As Double
Friend Is_Setup_Allowed As Boolean
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Primary_Resource_Templates
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Color As FormatFieldPair
Friend Shared Reference_Date As FormatFieldPair
Friend Shared Length As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Primary Resource Templates")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Color = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Color"))
Reference_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date"))
Length = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Length"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Color = Fields.PR.ReadFieldString(Color, Record)
MyItem.Reference_Date = Fields.PR.ReadFieldDatetime(Reference_Date, Record)
MyItem.Length = Fields.PR.ReadFieldDouble(Length, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Color As String
Friend Reference_Date As DateTime
Friend Length As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Primary_Resource_Template_Periods
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Template As FormatFieldPair
Friend Shared Start_Offset As FormatFieldPair
Friend Shared Length As FormatFieldPair
Friend Shared Efficiency As FormatFieldPair
Friend Shared Cost_Factor As FormatFieldPair
Friend Shared State As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Primary Resource Template Periods")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Template"))
Start_Offset = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Start Offset"))
Length = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Length"))
Efficiency = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Efficiency"))
Cost_Factor = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Cost Factor"))
State = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "State"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Template = Fields.PR.ReadFieldString(Template, Record)
MyItem.Start_Offset = Fields.PR.ReadFieldDouble(Start_Offset, Record)
MyItem.Length = Fields.PR.ReadFieldDouble(Length, Record)
MyItem.Efficiency = Fields.PR.ReadFieldDouble(Efficiency, Record)
MyItem.Cost_Factor = Fields.PR.ReadFieldDouble(Cost_Factor, Record)
MyItem.State = Fields.PR.ReadFieldString(State, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Template As String
Friend Start_Offset As Double
Friend Length As Double
Friend Efficiency As Double
Friend Cost_Factor As Double
Friend State As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Primary_Calendar_Periods
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Resource As FormatFieldPair
Friend Shared Template As FormatFieldPair
Friend Shared State As FormatFieldPair
Friend Shared Is_Exception As FormatFieldPair
Friend Shared From_Date As FormatFieldPair
Friend Shared To_Date As FormatFieldPair
Friend Shared Reference_Date As FormatFieldPair
Friend Shared Reference_Date_Type As FormatFieldPair
Friend Shared Efficiency As FormatFieldPair
Friend Shared Cost_Factor As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Primary Calendar Periods")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource"))
Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Template"))
State = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "State"))
Is_Exception = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Is Exception?"))
From_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "From Date"))
To_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "To Date"))
Reference_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date"))
Reference_Date_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date Type"))
Efficiency = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Efficiency"))
Cost_Factor = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Cost Factor"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Resource = Fields.PR.ReadFieldString(Resource, Record)
MyItem.Template = Fields.PR.ReadFieldString(Template, Record)
MyItem.State = Fields.PR.ReadFieldString(State, Record)
MyItem.Is_Exception = Fields.PR.ReadFieldBool(Is_Exception, Record)
MyItem.From_Date = Fields.PR.ReadFieldDatetime(From_Date, Record)
MyItem.To_Date = Fields.PR.ReadFieldDatetime(To_Date, Record)
MyItem.Reference_Date = Fields.PR.ReadFieldDatetime(Reference_Date, Record)
MyItem.Reference_Date_Type = Fields.PR.ReadFieldString(Reference_Date_Type, Record)
MyItem.Efficiency = Fields.PR.ReadFieldDouble(Efficiency, Record)
MyItem.Cost_Factor = Fields.PR.ReadFieldDouble(Cost_Factor, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Resource As String
Friend Template As String
Friend State As String
Friend Is_Exception As Boolean
Friend From_Date As DateTime
Friend To_Date As DateTime
Friend Reference_Date As DateTime
Friend Reference_Date_Type As String
Friend Efficiency As Double
Friend Cost_Factor As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Secondary_Resource_Templates
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Reference_Date As FormatFieldPair
Friend Shared Length As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Secondary Resource Templates")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Reference_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date"))
Length = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Length"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Reference_Date = Fields.PR.ReadFieldDatetime(Reference_Date, Record)
MyItem.Length = Fields.PR.ReadFieldDouble(Length, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Reference_Date As DateTime
Friend Length As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Secondary_Resource_Template_Periods
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Template As FormatFieldPair
Friend Shared Start_Offset As FormatFieldPair
Friend Shared Length As FormatFieldPair
Friend Shared Min_Value As FormatFieldPair
Friend Shared Max_Value As FormatFieldPair
Friend Shared Span_Off_Shift As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Secondary Resource Template Periods")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Template"))
Start_Offset = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Start Offset"))
Length = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Length"))
Min_Value = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Min Value"))
Max_Value = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Max Value"))
Span_Off_Shift = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Span Off Shift"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Template = Fields.PR.ReadFieldString(Template, Record)
MyItem.Start_Offset = Fields.PR.ReadFieldDouble(Start_Offset, Record)
MyItem.Length = Fields.PR.ReadFieldDouble(Length, Record)
MyItem.Min_Value = Fields.PR.ReadFieldDouble(Min_Value, Record)
MyItem.Max_Value = Fields.PR.ReadFieldDouble(Max_Value, Record)
MyItem.Span_Off_Shift = Fields.PR.ReadFieldBool(Span_Off_Shift, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Template As String
Friend Start_Offset As Double
Friend Length As Double
Friend Min_Value As Double
Friend Max_Value As Double
Friend Span_Off_Shift As Boolean
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Secondary_Calendar_Periods
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Resource As FormatFieldPair
Friend Shared Template As FormatFieldPair
Friend Shared Is_Exception As FormatFieldPair
Friend Shared From_Date As FormatFieldPair
Friend Shared To_Date As FormatFieldPair
Friend Shared Reference_Date As FormatFieldPair
Friend Shared Reference_Date_Type As FormatFieldPair
Friend Shared Min_Value_Specified As FormatFieldPair
Friend Shared Min_Value As FormatFieldPair
Friend Shared Max_Value_Specified As FormatFieldPair
Friend Shared Max_Value As FormatFieldPair
Friend Shared Span_Off_Shift_Specified As FormatFieldPair
Friend Shared Span_Off_Shift As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Secondary Calendar Periods")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource"))
Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Template"))
Is_Exception = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Is Exception?"))
From_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "From Date"))
To_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "To Date"))
Reference_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date"))
Reference_Date_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date Type"))
Min_Value_Specified = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Min Value Specified"))
Min_Value = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Min Value"))
Max_Value_Specified = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Max Value Specified"))
Max_Value = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Max Value"))
Span_Off_Shift_Specified = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Span Off Shift Specified"))
Span_Off_Shift = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Span Off Shift"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Resource = Fields.PR.ReadFieldString(Resource, Record)
MyItem.Template = Fields.PR.ReadFieldString(Template, Record)
MyItem.Is_Exception = Fields.PR.ReadFieldBool(Is_Exception, Record)
MyItem.From_Date = Fields.PR.ReadFieldDatetime(From_Date, Record)
MyItem.To_Date = Fields.PR.ReadFieldDatetime(To_Date, Record)
MyItem.Reference_Date = Fields.PR.ReadFieldDatetime(Reference_Date, Record)
MyItem.Reference_Date_Type = Fields.PR.ReadFieldString(Reference_Date_Type, Record)
MyItem.Min_Value_Specified = Fields.PR.ReadFieldBool(Min_Value_Specified, Record)
MyItem.Min_Value = Fields.PR.ReadFieldDouble(Min_Value, Record)
MyItem.Max_Value_Specified = Fields.PR.ReadFieldBool(Max_Value_Specified, Record)
MyItem.Max_Value = Fields.PR.ReadFieldDouble(Max_Value, Record)
MyItem.Span_Off_Shift_Specified = Fields.PR.ReadFieldBool(Span_Off_Shift_Specified, Record)
MyItem.Span_Off_Shift = Fields.PR.ReadFieldBool(Span_Off_Shift, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Resource As String
Friend Template As String
Friend Is_Exception As Boolean
Friend From_Date As DateTime
Friend To_Date As DateTime
Friend Reference_Date As DateTime
Friend Reference_Date_Type As String
Friend Min_Value_Specified As Boolean
Friend Min_Value As Double
Friend Max_Value_Specified As Boolean
Friend Max_Value As Double
Friend Span_Off_Shift_Specified As Boolean
Friend Span_Off_Shift As Boolean
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Calendar_Settings
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Gap_Calendar_State As FormatFieldPair
Friend Shared Primary_Default_Template As FormatFieldPair
Friend Shared Primary_Default_State As FormatFieldPair
Friend Shared Secondary_Default_Template As FormatFieldPair
Friend Shared Undo_Redo_Stack_Size As FormatFieldPair
Friend Shared Combine_Like_Periods As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Calendar Settings")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Gap_Calendar_State = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Gap Calendar State"))
Primary_Default_Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Primary Default Template"))
Primary_Default_State = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Primary Default State"))
Secondary_Default_Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Secondary Default Template"))
Undo_Redo_Stack_Size = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Undo\Redo Stack Size"))
Combine_Like_Periods = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Combine Like Periods"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Gap_Calendar_State = Fields.PR.ReadFieldString(Gap_Calendar_State, Record)
MyItem.Primary_Default_Template = Fields.PR.ReadFieldString(Primary_Default_Template, Record)
MyItem.Primary_Default_State = Fields.PR.ReadFieldString(Primary_Default_State, Record)
MyItem.Secondary_Default_Template = Fields.PR.ReadFieldString(Secondary_Default_Template, Record)
MyItem.Undo_Redo_Stack_Size = Fields.PR.ReadFieldInt(Undo_Redo_Stack_Size, Record)
MyItem.Combine_Like_Periods = Fields.PR.ReadFieldBool(Combine_Like_Periods, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Gap_Calendar_State As String
Friend Primary_Default_Template As String
Friend Primary_Default_State As String
Friend Secondary_Default_Template As String
Friend Undo_Redo_Stack_Size As Integer
Friend Combine_Like_Periods As Boolean
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Capacity_Group_Templates
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Reference_Date As FormatFieldPair
Friend Shared Length As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Capacity Group Templates")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Reference_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date"))
Length = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Length"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Reference_Date = Fields.PR.ReadFieldDatetime(Reference_Date, Record)
MyItem.Length = Fields.PR.ReadFieldDouble(Length, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Reference_Date As DateTime
Friend Length As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Capacity_Group_Template_Periods
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Template As FormatFieldPair
Friend Shared Start_Offset As FormatFieldPair
Friend Shared Length As FormatFieldPair
Friend Shared Level As FormatFieldPair
Friend Shared Level_Increase As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Capacity Group Template Periods")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Template"))
Start_Offset = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Start Offset"))
Length = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Length"))
Level = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Level"))
Level_Increase = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Level Increase"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Template = Fields.PR.ReadFieldString(Template, Record)
MyItem.Start_Offset = Fields.PR.ReadFieldDouble(Start_Offset, Record)
MyItem.Length = Fields.PR.ReadFieldDouble(Length, Record)
MyItem.Level = Fields.PR.ReadFieldDouble(Level, Record)
MyItem.Level_Increase = Fields.PR.ReadFieldDouble(Level_Increase, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Template As String
Friend Start_Offset As Double
Friend Length As Double
Friend Level As Double
Friend Level_Increase As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Capacity_Group_Calendar_Periods
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Resource As FormatFieldPair
Friend Shared Template As FormatFieldPair
Friend Shared Is_Exception As FormatFieldPair
Friend Shared From_Date As FormatFieldPair
Friend Shared To_Date As FormatFieldPair
Friend Shared Reference_Date As FormatFieldPair
Friend Shared Reference_Date_Type As FormatFieldPair
Friend Shared Level As FormatFieldPair
Friend Shared Level_Increase As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Capacity Group Calendar Periods")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource"))
Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Template"))
Is_Exception = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Is Exception?"))
From_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "From Date"))
To_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "To Date"))
Reference_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date"))
Reference_Date_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date Type"))
Level = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Level"))
Level_Increase = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Level Increase"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Resource = Fields.PR.ReadFieldString(Resource, Record)
MyItem.Template = Fields.PR.ReadFieldString(Template, Record)
MyItem.Is_Exception = Fields.PR.ReadFieldBool(Is_Exception, Record)
MyItem.From_Date = Fields.PR.ReadFieldDatetime(From_Date, Record)
MyItem.To_Date = Fields.PR.ReadFieldDatetime(To_Date, Record)
MyItem.Reference_Date = Fields.PR.ReadFieldDatetime(Reference_Date, Record)
MyItem.Reference_Date_Type = Fields.PR.ReadFieldString(Reference_Date_Type, Record)
MyItem.Level = Fields.PR.ReadFieldDouble(Level, Record)
MyItem.Level_Increase = Fields.PR.ReadFieldDouble(Level_Increase, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Resource As String
Friend Template As String
Friend Is_Exception As Boolean
Friend From_Date As DateTime
Friend To_Date As DateTime
Friend Reference_Date As DateTime
Friend Reference_Date_Type As String
Friend Level As Double
Friend Level_Increase As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Planning_Group_Templates
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Reference_Date As FormatFieldPair
Friend Shared Length As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Planning Group Templates")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Reference_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date"))
Length = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Length"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Reference_Date = Fields.PR.ReadFieldDatetime(Reference_Date, Record)
MyItem.Length = Fields.PR.ReadFieldDouble(Length, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Reference_Date As DateTime
Friend Length As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Planning_Group_Template_Periods
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Template As FormatFieldPair
Friend Shared Start_Offset As FormatFieldPair
Friend Shared Length As FormatFieldPair
Friend Shared Level As FormatFieldPair
Friend Shared Level_Increase As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Planning Group Template Periods")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Template"))
Start_Offset = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Start Offset"))
Length = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Length"))
Level = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Level"))
Level_Increase = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Level Increase"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Template = Fields.PR.ReadFieldString(Template, Record)
MyItem.Start_Offset = Fields.PR.ReadFieldDouble(Start_Offset, Record)
MyItem.Length = Fields.PR.ReadFieldDouble(Length, Record)
MyItem.Level = Fields.PR.ReadFieldDouble(Level, Record)
MyItem.Level_Increase = Fields.PR.ReadFieldDouble(Level_Increase, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Template As String
Friend Start_Offset As Double
Friend Length As Double
Friend Level As Double
Friend Level_Increase As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Planning_Group_Calendar_Periods
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Resource As FormatFieldPair
Friend Shared Template As FormatFieldPair
Friend Shared Is_Exception As FormatFieldPair
Friend Shared From_Date As FormatFieldPair
Friend Shared To_Date As FormatFieldPair
Friend Shared Reference_Date As FormatFieldPair
Friend Shared Reference_Date_Type As FormatFieldPair
Friend Shared Level As FormatFieldPair
Friend Shared Level_Increase As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Planning Group Calendar Periods")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource"))
Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Template"))
Is_Exception = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Is Exception?"))
From_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "From Date"))
To_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "To Date"))
Reference_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date"))
Reference_Date_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date Type"))
Level = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Level"))
Level_Increase = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Level Increase"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Resource = Fields.PR.ReadFieldString(Resource, Record)
MyItem.Template = Fields.PR.ReadFieldString(Template, Record)
MyItem.Is_Exception = Fields.PR.ReadFieldBool(Is_Exception, Record)
MyItem.From_Date = Fields.PR.ReadFieldDatetime(From_Date, Record)
MyItem.To_Date = Fields.PR.ReadFieldDatetime(To_Date, Record)
MyItem.Reference_Date = Fields.PR.ReadFieldDatetime(Reference_Date, Record)
MyItem.Reference_Date_Type = Fields.PR.ReadFieldString(Reference_Date_Type, Record)
MyItem.Level = Fields.PR.ReadFieldDouble(Level, Record)
MyItem.Level_Increase = Fields.PR.ReadFieldDouble(Level_Increase, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Resource As String
Friend Template As String
Friend Is_Exception As Boolean
Friend From_Date As DateTime
Friend To_Date As DateTime
Friend Reference_Date As DateTime
Friend Reference_Date_Type As String
Friend Level As Double
Friend Level_Increase As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Sku_Templates
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Reference_Date As FormatFieldPair
Friend Shared Length As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Sku Templates")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Reference_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date"))
Length = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Length"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Reference_Date = Fields.PR.ReadFieldDatetime(Reference_Date, Record)
MyItem.Length = Fields.PR.ReadFieldDouble(Length, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Reference_Date As DateTime
Friend Length As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Sku_Template_Periods
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Template As FormatFieldPair
Friend Shared Start_Offset As FormatFieldPair
Friend Shared Length As FormatFieldPair
Friend Shared Can_Sell As FormatFieldPair
Friend Shared Can_Produce As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Sku Template Periods")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Template"))
Start_Offset = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Start Offset"))
Length = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Length"))
Can_Sell = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Can Sell"))
Can_Produce = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Can Produce"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Template = Fields.PR.ReadFieldString(Template, Record)
MyItem.Start_Offset = Fields.PR.ReadFieldDouble(Start_Offset, Record)
MyItem.Length = Fields.PR.ReadFieldDouble(Length, Record)
MyItem.Can_Sell = Fields.PR.ReadFieldBool(Can_Sell, Record)
MyItem.Can_Produce = Fields.PR.ReadFieldBool(Can_Produce, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Template As String
Friend Start_Offset As Double
Friend Length As Double
Friend Can_Sell As Boolean
Friend Can_Produce As Boolean
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Sku_Calendar_Periods
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Resource As FormatFieldPair
Friend Shared Template As FormatFieldPair
Friend Shared Is_Exception As FormatFieldPair
Friend Shared From_Date As FormatFieldPair
Friend Shared To_Date As FormatFieldPair
Friend Shared Reference_Date As FormatFieldPair
Friend Shared Reference_Date_Type As FormatFieldPair
Friend Shared Can_Sell_Specified As FormatFieldPair
Friend Shared Can_Produce_Specified As FormatFieldPair
Friend Shared Can_Sell As FormatFieldPair
Friend Shared Can_Produce As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Sku Calendar Periods")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource"))
Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Template"))
Is_Exception = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Is Exception?"))
From_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "From Date"))
To_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "To Date"))
Reference_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date"))
Reference_Date_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date Type"))
Can_Sell_Specified = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Can Sell Specified"))
Can_Produce_Specified = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Can Produce Specified"))
Can_Sell = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Can Sell"))
Can_Produce = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Can Produce"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Resource = Fields.PR.ReadFieldString(Resource, Record)
MyItem.Template = Fields.PR.ReadFieldString(Template, Record)
MyItem.Is_Exception = Fields.PR.ReadFieldBool(Is_Exception, Record)
MyItem.From_Date = Fields.PR.ReadFieldDatetime(From_Date, Record)
MyItem.To_Date = Fields.PR.ReadFieldDatetime(To_Date, Record)
MyItem.Reference_Date = Fields.PR.ReadFieldDatetime(Reference_Date, Record)
MyItem.Reference_Date_Type = Fields.PR.ReadFieldString(Reference_Date_Type, Record)
MyItem.Can_Sell_Specified = Fields.PR.ReadFieldBool(Can_Sell_Specified, Record)
MyItem.Can_Produce_Specified = Fields.PR.ReadFieldBool(Can_Produce_Specified, Record)
MyItem.Can_Sell = Fields.PR.ReadFieldBool(Can_Sell, Record)
MyItem.Can_Produce = Fields.PR.ReadFieldBool(Can_Produce, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Resource As String
Friend Template As String
Friend Is_Exception As Boolean
Friend From_Date As DateTime
Friend To_Date As DateTime
Friend Reference_Date As DateTime
Friend Reference_Date_Type As String
Friend Can_Sell_Specified As Boolean
Friend Can_Produce_Specified As Boolean
Friend Can_Sell As Boolean
Friend Can_Produce As Boolean
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Sku_Planning_Group_Templates
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Reference_Date As FormatFieldPair
Friend Shared Length As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Sku Planning Group Templates")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Reference_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date"))
Length = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Length"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Reference_Date = Fields.PR.ReadFieldDatetime(Reference_Date, Record)
MyItem.Length = Fields.PR.ReadFieldDouble(Length, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Reference_Date As DateTime
Friend Length As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Sku_Planning_Group_Template_Periods
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Template As FormatFieldPair
Friend Shared Start_Offset As FormatFieldPair
Friend Shared Length As FormatFieldPair
Friend Shared Minimum_Level As FormatFieldPair
Friend Shared Maximum_Level As FormatFieldPair
Friend Shared Target_Level As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Sku Planning Group Template Periods")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Template"))
Start_Offset = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Start Offset"))
Length = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Length"))
Minimum_Level = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Minimum Level"))
Maximum_Level = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Maximum Level"))
Target_Level = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Target Level"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Template = Fields.PR.ReadFieldString(Template, Record)
MyItem.Start_Offset = Fields.PR.ReadFieldDouble(Start_Offset, Record)
MyItem.Length = Fields.PR.ReadFieldDouble(Length, Record)
MyItem.Minimum_Level = Fields.PR.ReadFieldDouble(Minimum_Level, Record)
MyItem.Maximum_Level = Fields.PR.ReadFieldDouble(Maximum_Level, Record)
MyItem.Target_Level = Fields.PR.ReadFieldDouble(Target_Level, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Template As String
Friend Start_Offset As Double
Friend Length As Double
Friend Minimum_Level As Double
Friend Maximum_Level As Double
Friend Target_Level As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Sku_Planning_Group_Calendar_Periods
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Resource As FormatFieldPair
Friend Shared Template As FormatFieldPair
Friend Shared Is_Exception As FormatFieldPair
Friend Shared From_Date As FormatFieldPair
Friend Shared To_Date As FormatFieldPair
Friend Shared Reference_Date As FormatFieldPair
Friend Shared Reference_Date_Type As FormatFieldPair
Friend Shared Minimum_Level As FormatFieldPair
Friend Shared Maximum_Level As FormatFieldPair
Friend Shared Target_Level As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Sku Planning Group Calendar Periods")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource"))
Template = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Template"))
Is_Exception = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Is Exception?"))
From_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "From Date"))
To_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "To Date"))
Reference_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date"))
Reference_Date_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date Type"))
Minimum_Level = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Minimum Level"))
Maximum_Level = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Maximum Level"))
Target_Level = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Target Level"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Resource = Fields.PR.ReadFieldString(Resource, Record)
MyItem.Template = Fields.PR.ReadFieldString(Template, Record)
MyItem.Is_Exception = Fields.PR.ReadFieldBool(Is_Exception, Record)
MyItem.From_Date = Fields.PR.ReadFieldDatetime(From_Date, Record)
MyItem.To_Date = Fields.PR.ReadFieldDatetime(To_Date, Record)
MyItem.Reference_Date = Fields.PR.ReadFieldDatetime(Reference_Date, Record)
MyItem.Reference_Date_Type = Fields.PR.ReadFieldString(Reference_Date_Type, Record)
MyItem.Minimum_Level = Fields.PR.ReadFieldDouble(Minimum_Level, Record)
MyItem.Maximum_Level = Fields.PR.ReadFieldDouble(Maximum_Level, Record)
MyItem.Target_Level = Fields.PR.ReadFieldDouble(Target_Level, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Resource As String
Friend Template As String
Friend Is_Exception As Boolean
Friend From_Date As DateTime
Friend To_Date As DateTime
Friend Reference_Date As DateTime
Friend Reference_Date_Type As String
Friend Minimum_Level As Double
Friend Maximum_Level As Double
Friend Target_Level As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_MILP_Solver_Settings
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Key As FormatFieldPair
Friend Shared Value As FormatFieldPair
Friend Shared Set_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("MILP Solver Settings")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Key = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Key"))
Value = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Value"))
Set_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Set Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Key = Fields.PR.ReadFieldString(Key, Record)
MyItem.Value = Fields.PR.ReadFieldString(Value, Record)
MyItem.Set_Id = Fields.PR.ReadFieldInt(Set_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Key As String
Friend Value As String
Friend Set_Id As Integer
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Initial_Stock_Levels_With_Age
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Facility_Id As FormatFieldPair
Friend Shared Product_Id As FormatFieldPair
Friend Shared Production_Date As FormatFieldPair
Friend Shared Stock_Level As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Initial Stock Levels With Age")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Facility_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Facility Id"))
Product_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Product Id"))
Production_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Production Date"))
Stock_Level = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Stock Level"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Facility_Id = Fields.PR.ReadFieldString(Facility_Id, Record)
MyItem.Product_Id = Fields.PR.ReadFieldString(Product_Id, Record)
MyItem.Production_Date = Fields.PR.ReadFieldDatetime(Production_Date, Record)
MyItem.Stock_Level = Fields.PR.ReadFieldDouble(Stock_Level, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Facility_Id As String
Friend Product_Id As String
Friend Production_Date As DateTime
Friend Stock_Level As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Product_Transport
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Product_Id As FormatFieldPair
Friend Shared Transport_Route As FormatFieldPair
Friend Shared Start_Date As FormatFieldPair
Friend Shared Amount As FormatFieldPair
Friend Shared Age As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Product Transport")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Product_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Product Id"))
Transport_Route = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Transport Route"))
Start_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Start Date"))
Amount = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Amount"))
Age = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Age"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Product_Id = Fields.PR.ReadFieldString(Product_Id, Record)
MyItem.Transport_Route = Fields.PR.ReadFieldString(Transport_Route, Record)
MyItem.Start_Date = Fields.PR.ReadFieldDatetime(Start_Date, Record)
MyItem.Amount = Fields.PR.ReadFieldDouble(Amount, Record)
MyItem.Age = Fields.PR.ReadFieldInt(Age, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Product_Id As String
Friend Transport_Route As String
Friend Start_Date As DateTime
Friend Amount As Double
Friend Age As Integer
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Transport_Link
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Route As FormatFieldPair
Friend Shared Start_Location As FormatFieldPair
Friend Shared End_Location As FormatFieldPair
Friend Shared Transport_Time_In_Days As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Transport Link")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Route = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Route"))
Start_Location = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Start Location"))
End_Location = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "End Location"))
Transport_Time_In_Days = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Transport Time In Days"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Route = Fields.PR.ReadFieldString(Route, Record)
MyItem.Start_Location = Fields.PR.ReadFieldString(Start_Location, Record)
MyItem.End_Location = Fields.PR.ReadFieldString(End_Location, Record)
MyItem.Transport_Time_In_Days = Fields.PR.ReadFieldInt(Transport_Time_In_Days, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Route As String
Friend Start_Location As String
Friend End_Location As String
Friend Transport_Time_In_Days As Integer
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Sku_Planning_Group
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Item As FormatFieldPair
Friend Shared Planning_Resource As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Sku Planning Group")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Item = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Item"))
Planning_Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Planning Resource"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Item = Fields.PR.ReadFieldString(Item, Record)
MyItem.Planning_Resource = Fields.PR.ReadFieldString(Planning_Resource, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Item As String
Friend Planning_Resource As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Xcelerator_Share_Settings
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Enable_Xcelerator_Share As FormatFieldPair
Friend Shared URL As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Xcelerator Share Settings")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Enable_Xcelerator_Share = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Enable Xcelerator Share"))
URL = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "URL"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Enable_Xcelerator_Share = Fields.PR.ReadFieldBool(Enable_Xcelerator_Share, Record)
MyItem.URL = Fields.PR.ReadFieldString(URL, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Enable_Xcelerator_Share As Boolean
Friend URL As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Shortages
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared External_Demand_Order As FormatFieldPair
Friend Shared Internal_Demand_Order As FormatFieldPair
Friend Shared Part_No As FormatFieldPair
Friend Shared Shortage_Quantity As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Shortages")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
External_Demand_Order = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Demand Order"))
Internal_Demand_Order = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Internal Demand Order"))
Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Part No."))
Shortage_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Shortage Quantity"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.External_Demand_Order = Fields.PR.ReadFieldInt(External_Demand_Order, Record)
MyItem.Internal_Demand_Order = Fields.PR.ReadFieldInt(Internal_Demand_Order, Record)
MyItem.Part_No = Fields.PR.ReadFieldString(Part_No, Record)
MyItem.Shortage_Quantity = Fields.PR.ReadFieldDouble(Shortage_Quantity, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend External_Demand_Order As Integer
Friend Internal_Demand_Order As Integer
Friend Part_No As String
Friend Shortage_Quantity As Double
Friend Display_Sequence_Number As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Supply
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Order_No As FormatFieldPair
Friend Shared Order_Type As FormatFieldPair
Friend Shared Table_Attribute_1 As FormatFieldPair
Friend Shared Table_Attribute_2 As FormatFieldPair
Friend Shared Table_Attribute_3 As FormatFieldPair
Friend Shared String_Attribute_1 As FormatFieldPair
Friend Shared String_Attribute_2 As FormatFieldPair
Friend Shared String_Attribute_3 As FormatFieldPair
Friend Shared Part_No As FormatFieldPair
Friend Shared Description As FormatFieldPair
Friend Shared Supply_Date As FormatFieldPair
Friend Shared Priority As FormatFieldPair
Friend Shared Quantity As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Supply")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Order_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order No."))
Order_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Type"))
Table_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 1"))
Table_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 2"))
Table_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 3"))
String_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 1"))
String_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 2"))
String_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 3"))
Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Part No."))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))
Supply_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Supply Date"))
Priority = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Priority"))
Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Quantity"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Order_No = Fields.PR.ReadFieldString(Order_No, Record)
MyItem.Order_Type = Fields.PR.ReadFieldString(Order_Type, Record)
MyItem.Table_Attribute_1 = Fields.PR.ReadFieldString(Table_Attribute_1, Record)
MyItem.Table_Attribute_2 = Fields.PR.ReadFieldString(Table_Attribute_2, Record)
MyItem.Table_Attribute_3 = Fields.PR.ReadFieldString(Table_Attribute_3, Record)
MyItem.String_Attribute_1 = Fields.PR.ReadFieldString(String_Attribute_1, Record)
MyItem.String_Attribute_2 = Fields.PR.ReadFieldString(String_Attribute_2, Record)
MyItem.String_Attribute_3 = Fields.PR.ReadFieldString(String_Attribute_3, Record)
MyItem.Part_No = Fields.PR.ReadFieldString(Part_No, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)
MyItem.Supply_Date = Fields.PR.ReadFieldDatetime(Supply_Date, Record)
MyItem.Priority = Fields.PR.ReadFieldDouble(Priority, Record)
MyItem.Quantity = Fields.PR.ReadFieldDouble(Quantity, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Order_No As String
Friend Order_Type As String
Friend Table_Attribute_1 As String
Friend Table_Attribute_2 As String
Friend Table_Attribute_3 As String
Friend String_Attribute_1 As String
Friend String_Attribute_2 As String
Friend String_Attribute_3 As String
Friend Part_No As String
Friend Description As String
Friend Supply_Date As DateTime
Friend Priority As Double
Friend Quantity As Double
Friend Display_Sequence_Number As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Demand
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Belongs_to_Order_No As FormatFieldPair
Friend Shared Number As FormatFieldPair
Friend Shared Order_No As FormatFieldPair
Friend Shared Order_Type As FormatFieldPair
Friend Shared Order_Line As FormatFieldPair
Friend Shared Table_Attribute_1 As FormatFieldPair
Friend Shared Table_Attribute_2 As FormatFieldPair
Friend Shared Table_Attribute_3 As FormatFieldPair
Friend Shared String_Attribute_1 As FormatFieldPair
Friend Shared String_Attribute_2 As FormatFieldPair
Friend Shared String_Attribute_3 As FormatFieldPair
Friend Shared String_Attribute_4 As FormatFieldPair
Friend Shared Part_No As FormatFieldPair
Friend Shared Description As FormatFieldPair
Friend Shared Demand_Date As FormatFieldPair
Friend Shared Priority As FormatFieldPair
Friend Shared Quantity As FormatFieldPair
Friend Shared Multiple_Quantity As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Demand")

Belongs_to_Order_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Belongs to Order No."))
Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Order_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order No."))
Order_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Type"))
Order_Line = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Line"))
Table_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 1"))
Table_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 2"))
Table_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 3"))
String_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 1"))
String_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 2"))
String_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 3"))
String_Attribute_4 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 4"))
Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Part No."))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))
Demand_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Demand Date"))
Priority = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Priority"))
Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Quantity"))
Multiple_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Multiple Quantity"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Belongs_to_Order_No = Fields.PR.ReadFieldString(Belongs_to_Order_No, Record)
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Order_No = Fields.PR.ReadFieldString(Order_No, Record)
MyItem.Order_Type = Fields.PR.ReadFieldString(Order_Type, Record)
MyItem.Order_Line = Fields.PR.ReadFieldInt(Order_Line, Record)
MyItem.Table_Attribute_1 = Fields.PR.ReadFieldString(Table_Attribute_1, Record)
MyItem.Table_Attribute_2 = Fields.PR.ReadFieldString(Table_Attribute_2, Record)
MyItem.Table_Attribute_3 = Fields.PR.ReadFieldString(Table_Attribute_3, Record)
MyItem.String_Attribute_1 = Fields.PR.ReadFieldString(String_Attribute_1, Record)
MyItem.String_Attribute_2 = Fields.PR.ReadFieldString(String_Attribute_2, Record)
MyItem.String_Attribute_3 = Fields.PR.ReadFieldString(String_Attribute_3, Record)
MyItem.String_Attribute_4 = Fields.PR.ReadFieldString(String_Attribute_4, Record)
MyItem.Part_No = Fields.PR.ReadFieldString(Part_No, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)
MyItem.Demand_Date = Fields.PR.ReadFieldDatetime(Demand_Date, Record)
MyItem.Priority = Fields.PR.ReadFieldDouble(Priority, Record)
MyItem.Quantity = Fields.PR.ReadFieldDouble(Quantity, Record)
MyItem.Multiple_Quantity = Fields.PR.ReadFieldInt(Multiple_Quantity, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Belongs_to_Order_No As String
Friend Number As Integer
Friend Order_No As String
Friend Order_Type As String
Friend Order_Line As Integer
Friend Table_Attribute_1 As String
Friend Table_Attribute_2 As String
Friend Table_Attribute_3 As String
Friend String_Attribute_1 As String
Friend String_Attribute_2 As String
Friend String_Attribute_3 As String
Friend String_Attribute_4 As String
Friend Part_No As String
Friend Description As String
Friend Demand_Date As DateTime
Friend Priority As Double
Friend Quantity As Double
Friend Multiple_Quantity As Integer
Friend Display_Sequence_Number As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Bill_of_Materials
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Belongs_to_BOM As FormatFieldPair
Friend Shared Number As FormatFieldPair
Friend Shared Order_No As FormatFieldPair
Friend Shared OF_NumOperation As FormatFieldPair
Friend Shared Order_Part_No As FormatFieldPair
Friend Shared Operation_Name As FormatFieldPair
Friend Shared Op_No As FormatFieldPair
Friend Shared Required_Part_No As FormatFieldPair
Friend Shared Required_Quantity As FormatFieldPair
Friend Shared Multiply_by_order_quantity As FormatFieldPair
Friend Shared Ignore_Shortages As FormatFieldPair
Friend Shared Multiple_Quantity As FormatFieldPair
Friend Shared Spare_String_Field_1 As FormatFieldPair
Friend Shared Spare_String_Field_2 As FormatFieldPair
Friend Shared Spare_String_Field_3 As FormatFieldPair
Friend Shared Spare_Number_Field As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Bill of Materials")

Belongs_to_BOM = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Belongs to BOM"))
Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Order_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order No."))
OF_NumOperation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "OF_NumOperation"))
Order_Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Part No."))
Operation_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation Name"))
Op_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Op. No."))
Required_Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Required Part No."))
Required_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Required Quantity"))
Multiply_by_order_quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Multiply by order quantity"))
Ignore_Shortages = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Ignore Shortages"))
Multiple_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Multiple Quantity"))
Spare_String_Field_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 1"))
Spare_String_Field_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 2"))
Spare_String_Field_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 3"))
Spare_Number_Field = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare Number Field"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Belongs_to_BOM = Fields.PR.ReadFieldString(Belongs_to_BOM, Record)
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Order_No = Fields.PR.ReadFieldString(Order_No, Record)
MyItem.OF_NumOperation = Fields.PR.ReadFieldString(OF_NumOperation, Record)
MyItem.Order_Part_No = Fields.PR.ReadFieldString(Order_Part_No, Record)
MyItem.Operation_Name = Fields.PR.ReadFieldString(Operation_Name, Record)
MyItem.Op_No = Fields.PR.ReadFieldInt(Op_No, Record)
MyItem.Required_Part_No = Fields.PR.ReadFieldString(Required_Part_No, Record)
MyItem.Required_Quantity = Fields.PR.ReadFieldDouble(Required_Quantity, Record)
MyItem.Multiply_by_order_quantity = Fields.PR.ReadFieldBool(Multiply_by_order_quantity, Record)
MyItem.Ignore_Shortages = Fields.PR.ReadFieldBool(Ignore_Shortages, Record)
MyItem.Multiple_Quantity = Fields.PR.ReadFieldInt(Multiple_Quantity, Record)
MyItem.Spare_String_Field_1 = Fields.PR.ReadFieldString(Spare_String_Field_1, Record)
MyItem.Spare_String_Field_2 = Fields.PR.ReadFieldString(Spare_String_Field_2, Record)
MyItem.Spare_String_Field_3 = Fields.PR.ReadFieldString(Spare_String_Field_3, Record)
MyItem.Spare_Number_Field = Fields.PR.ReadFieldDouble(Spare_Number_Field, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Belongs_to_BOM As String
Friend Number As Integer
Friend Order_No As String
Friend OF_NumOperation As String
Friend Order_Part_No As String
Friend Operation_Name As String
Friend Op_No As Integer
Friend Required_Part_No As String
Friend Required_Quantity As Double
Friend Multiply_by_order_quantity As Boolean
Friend Ignore_Shortages As Boolean
Friend Multiple_Quantity As Integer
Friend Spare_String_Field_1 As String
Friend Spare_String_Field_2 As String
Friend Spare_String_Field_3 As String
Friend Spare_Number_Field As Double
Friend Display_Sequence_Number As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Product_Bill_of_Materials
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Belongs_to_BOM As FormatFieldPair
Friend Shared Number As FormatFieldPair
Friend Shared Part_No As FormatFieldPair
Friend Shared Operation As FormatFieldPair
Friend Shared Operation_Name As FormatFieldPair
Friend Shared Op_No As FormatFieldPair
Friend Shared Required_Part_No As FormatFieldPair
Friend Shared Required_Quantity As FormatFieldPair
Friend Shared Multiply_by_order_quantity As FormatFieldPair
Friend Shared Ignore_Shortages As FormatFieldPair
Friend Shared Multiple_Quantity As FormatFieldPair
Friend Shared Spare_String_Field_1 As FormatFieldPair
Friend Shared Spare_String_Field_2 As FormatFieldPair
Friend Shared Spare_Number_Field As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Product Bill of Materials")

Belongs_to_BOM = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Belongs to BOM"))
Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Part No."))
Operation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation"))
Operation_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation Name"))
Op_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Op. No."))
Required_Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Required Part No."))
Required_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Required Quantity"))
Multiply_by_order_quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Multiply by order quantity"))
Ignore_Shortages = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Ignore Shortages"))
Multiple_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Multiple Quantity"))
Spare_String_Field_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 1"))
Spare_String_Field_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 2"))
Spare_Number_Field = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare Number Field"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Belongs_to_BOM = Fields.PR.ReadFieldString(Belongs_to_BOM, Record)
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Part_No = Fields.PR.ReadFieldString(Part_No, Record)
MyItem.Operation = Fields.PR.ReadFieldString(Operation, Record)
MyItem.Operation_Name = Fields.PR.ReadFieldString(Operation_Name, Record)
MyItem.Op_No = Fields.PR.ReadFieldInt(Op_No, Record)
MyItem.Required_Part_No = Fields.PR.ReadFieldString(Required_Part_No, Record)
MyItem.Required_Quantity = Fields.PR.ReadFieldDouble(Required_Quantity, Record)
MyItem.Multiply_by_order_quantity = Fields.PR.ReadFieldBool(Multiply_by_order_quantity, Record)
MyItem.Ignore_Shortages = Fields.PR.ReadFieldBool(Ignore_Shortages, Record)
MyItem.Multiple_Quantity = Fields.PR.ReadFieldInt(Multiple_Quantity, Record)
MyItem.Spare_String_Field_1 = Fields.PR.ReadFieldString(Spare_String_Field_1, Record)
MyItem.Spare_String_Field_2 = Fields.PR.ReadFieldString(Spare_String_Field_2, Record)
MyItem.Spare_Number_Field = Fields.PR.ReadFieldDouble(Spare_Number_Field, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Belongs_to_BOM As String
Friend Number As Integer
Friend Part_No As String
Friend Operation As String
Friend Operation_Name As String
Friend Op_No As Integer
Friend Required_Part_No As String
Friend Required_Quantity As Double
Friend Multiply_by_order_quantity As Boolean
Friend Ignore_Shortages As Boolean
Friend Multiple_Quantity As Integer
Friend Spare_String_Field_1 As String
Friend Spare_String_Field_2 As String
Friend Spare_Number_Field As Double
Friend Display_Sequence_Number As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Co_products
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Belongs_to_Co_product As FormatFieldPair
Friend Shared Number As FormatFieldPair
Friend Shared Order_No As FormatFieldPair
Friend Shared Order_Part_No As FormatFieldPair
Friend Shared Operation_Name As FormatFieldPair
Friend Shared Op_No As FormatFieldPair
Friend Shared Co_product As FormatFieldPair
Friend Shared Quantity As FormatFieldPair
Friend Shared Multiply_by_order_quantity As FormatFieldPair
Friend Shared Spare_String_Field_1 As FormatFieldPair
Friend Shared Spare_String_Field_2 As FormatFieldPair
Friend Shared Spare_Number_Field As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Co-products")

Belongs_to_Co_product = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Belongs to Co-product"))
Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Order_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order No."))
Order_Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Part No."))
Operation_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation Name"))
Op_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Op. No."))
Co_product = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Co-product"))
Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Quantity"))
Multiply_by_order_quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Multiply by order quantity"))
Spare_String_Field_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 1"))
Spare_String_Field_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 2"))
Spare_Number_Field = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare Number Field"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Belongs_to_Co_product = Fields.PR.ReadFieldString(Belongs_to_Co_product, Record)
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Order_No = Fields.PR.ReadFieldString(Order_No, Record)
MyItem.Order_Part_No = Fields.PR.ReadFieldString(Order_Part_No, Record)
MyItem.Operation_Name = Fields.PR.ReadFieldString(Operation_Name, Record)
MyItem.Op_No = Fields.PR.ReadFieldInt(Op_No, Record)
MyItem.Co_product = Fields.PR.ReadFieldString(Co_product, Record)
MyItem.Quantity = Fields.PR.ReadFieldDouble(Quantity, Record)
MyItem.Multiply_by_order_quantity = Fields.PR.ReadFieldBool(Multiply_by_order_quantity, Record)
MyItem.Spare_String_Field_1 = Fields.PR.ReadFieldString(Spare_String_Field_1, Record)
MyItem.Spare_String_Field_2 = Fields.PR.ReadFieldString(Spare_String_Field_2, Record)
MyItem.Spare_Number_Field = Fields.PR.ReadFieldDouble(Spare_Number_Field, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Belongs_to_Co_product As String
Friend Number As Integer
Friend Order_No As String
Friend Order_Part_No As String
Friend Operation_Name As String
Friend Op_No As Integer
Friend Co_product As String
Friend Quantity As Double
Friend Multiply_by_order_quantity As Boolean
Friend Spare_String_Field_1 As String
Friend Spare_String_Field_2 As String
Friend Spare_Number_Field As Double
Friend Display_Sequence_Number As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Product_Co_products
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Belongs_to_Co_product As FormatFieldPair
Friend Shared Number As FormatFieldPair
Friend Shared Co_product_ID As FormatFieldPair
Friend Shared Part_No As FormatFieldPair
Friend Shared Operation As FormatFieldPair
Friend Shared Operation_Name As FormatFieldPair
Friend Shared Op_No As FormatFieldPair
Friend Shared Co_product As FormatFieldPair
Friend Shared Quantity As FormatFieldPair
Friend Shared Multiply_by_order_quantity As FormatFieldPair
Friend Shared Spare_String_Field_1 As FormatFieldPair
Friend Shared Spare_String_Field_2 As FormatFieldPair
Friend Shared Spare_Number_Field As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Product Co-products")

Belongs_to_Co_product = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Belongs to Co-product"))
Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Co_product_ID = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Co-product ID"))
Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Part No."))
Operation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation"))
Operation_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation Name"))
Op_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Op. No."))
Co_product = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Co-product"))
Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Quantity"))
Multiply_by_order_quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Multiply by order quantity"))
Spare_String_Field_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 1"))
Spare_String_Field_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 2"))
Spare_Number_Field = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare Number Field"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Belongs_to_Co_product = Fields.PR.ReadFieldString(Belongs_to_Co_product, Record)
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Co_product_ID = Fields.PR.ReadFieldString(Co_product_ID, Record)
MyItem.Part_No = Fields.PR.ReadFieldString(Part_No, Record)
MyItem.Operation = Fields.PR.ReadFieldString(Operation, Record)
MyItem.Operation_Name = Fields.PR.ReadFieldString(Operation_Name, Record)
MyItem.Op_No = Fields.PR.ReadFieldInt(Op_No, Record)
MyItem.Co_product = Fields.PR.ReadFieldString(Co_product, Record)
MyItem.Quantity = Fields.PR.ReadFieldDouble(Quantity, Record)
MyItem.Multiply_by_order_quantity = Fields.PR.ReadFieldBool(Multiply_by_order_quantity, Record)
MyItem.Spare_String_Field_1 = Fields.PR.ReadFieldString(Spare_String_Field_1, Record)
MyItem.Spare_String_Field_2 = Fields.PR.ReadFieldString(Spare_String_Field_2, Record)
MyItem.Spare_Number_Field = Fields.PR.ReadFieldDouble(Spare_Number_Field, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Belongs_to_Co_product As String
Friend Number As Integer
Friend Co_product_ID As String
Friend Part_No As String
Friend Operation As String
Friend Operation_Name As String
Friend Op_No As Integer
Friend Co_product As String
Friend Quantity As Double
Friend Multiply_by_order_quantity As Boolean
Friend Spare_String_Field_1 As String
Friend Spare_String_Field_2 As String
Friend Spare_Number_Field As Double
Friend Display_Sequence_Number As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Purchased_Items
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Part_No As FormatFieldPair
Friend Shared Description As FormatFieldPair
Friend Shared Lead_Time As FormatFieldPair
Friend Shared Minimum_Reorder_Quantity As FormatFieldPair
Friend Shared Reorder_Multiple As FormatFieldPair
Friend Shared Table_Attribute_1 As FormatFieldPair
Friend Shared Table_Attribute_2 As FormatFieldPair
Friend Shared Table_Attribute_3 As FormatFieldPair
Friend Shared String_Attribute_1 As FormatFieldPair
Friend Shared String_Attribute_2 As FormatFieldPair
Friend Shared String_Attribute_3 As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Purchased Items")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Part No."))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))
Lead_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Lead Time"))
Minimum_Reorder_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Minimum Reorder Quantity"))
Reorder_Multiple = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reorder Multiple"))
Table_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 1"))
Table_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 2"))
Table_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 3"))
String_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 1"))
String_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 2"))
String_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 3"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Part_No = Fields.PR.ReadFieldString(Part_No, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)
MyItem.Lead_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Lead_Time, Record))
MyItem.Minimum_Reorder_Quantity = Fields.PR.ReadFieldDouble(Minimum_Reorder_Quantity, Record)
MyItem.Reorder_Multiple = Fields.PR.ReadFieldDouble(Reorder_Multiple, Record)
MyItem.Table_Attribute_1 = Fields.PR.ReadFieldString(Table_Attribute_1, Record)
MyItem.Table_Attribute_2 = Fields.PR.ReadFieldString(Table_Attribute_2, Record)
MyItem.Table_Attribute_3 = Fields.PR.ReadFieldString(Table_Attribute_3, Record)
MyItem.String_Attribute_1 = Fields.PR.ReadFieldString(String_Attribute_1, Record)
MyItem.String_Attribute_2 = Fields.PR.ReadFieldString(String_Attribute_2, Record)
MyItem.String_Attribute_3 = Fields.PR.ReadFieldString(String_Attribute_3, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Part_No As String
Friend Description As String
Friend Lead_Time As TimeSpan
Friend Minimum_Reorder_Quantity As Double
Friend Reorder_Multiple As Double
Friend Table_Attribute_1 As String
Friend Table_Attribute_2 As String
Friend Table_Attribute_3 As String
Friend String_Attribute_1 As String
Friend String_Attribute_2 As String
Friend String_Attribute_3 As String
Friend Display_Sequence_Number As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Ignore_Shortages
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared External_Demand_Order As FormatFieldPair
Friend Shared Internal_Demand_Order As FormatFieldPair
Friend Shared Part_No As FormatFieldPair
Friend Shared Ignore_Shortages As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Ignore Shortages")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
External_Demand_Order = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Demand Order"))
Internal_Demand_Order = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Internal Demand Order"))
Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Part No."))
Ignore_Shortages = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Ignore Shortages"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.External_Demand_Order = Fields.PR.ReadFieldInt(External_Demand_Order, Record)
MyItem.Internal_Demand_Order = Fields.PR.ReadFieldInt(Internal_Demand_Order, Record)
MyItem.Part_No = Fields.PR.ReadFieldString(Part_No, Record)
MyItem.Ignore_Shortages = Fields.PR.ReadFieldBool(Ignore_Shortages, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend External_Demand_Order As Integer
Friend Internal_Demand_Order As Integer
Friend Part_No As String
Friend Ignore_Shortages As Boolean
Friend Display_Sequence_Number As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Order_Links
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared From_External_Supply_Order As FormatFieldPair
Friend Shared From_Internal_Supply_Order As FormatFieldPair
Friend Shared To_External_Demand_Order As FormatFieldPair
Friend Shared To_Internal_Demand_Order As FormatFieldPair
Friend Shared Part_No As FormatFieldPair
Friend Shared Quantity As FormatFieldPair
Friend Shared Pegging_Rule_Used As FormatFieldPair
Friend Shared Verification_Code As FormatFieldPair
Friend Shared Locked As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Order Links")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
From_External_Supply_Order = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "From External Supply Order"))
From_Internal_Supply_Order = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "From Internal Supply Order"))
To_External_Demand_Order = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "To External Demand Order"))
To_Internal_Demand_Order = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "To Internal Demand Order"))
Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Part No."))
Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Quantity"))
Pegging_Rule_Used = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Pegging Rule Used"))
Verification_Code = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Verification Code"))
Locked = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Locked"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.From_External_Supply_Order = Fields.PR.ReadFieldInt(From_External_Supply_Order, Record)
MyItem.From_Internal_Supply_Order = Fields.PR.ReadFieldInt(From_Internal_Supply_Order, Record)
MyItem.To_External_Demand_Order = Fields.PR.ReadFieldInt(To_External_Demand_Order, Record)
MyItem.To_Internal_Demand_Order = Fields.PR.ReadFieldInt(To_Internal_Demand_Order, Record)
MyItem.Part_No = Fields.PR.ReadFieldString(Part_No, Record)
MyItem.Quantity = Fields.PR.ReadFieldDouble(Quantity, Record)
MyItem.Pegging_Rule_Used = Fields.PR.ReadFieldString(Pegging_Rule_Used, Record)
MyItem.Verification_Code = Fields.PR.ReadFieldInt(Verification_Code, Record)
MyItem.Locked = Fields.PR.ReadFieldBool(Locked, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend From_External_Supply_Order As Integer
Friend From_Internal_Supply_Order As Integer
Friend To_External_Demand_Order As Integer
Friend To_Internal_Demand_Order As Integer
Friend Part_No As String
Friend Quantity As Double
Friend Pegging_Rule_Used As String
Friend Verification_Code As Integer
Friend Locked As Boolean
Friend Display_Sequence_Number As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Material_Control_Configuration
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Selected_Pegging_Rule_Set As FormatFieldPair
Friend Shared Allow_Backward_Links As FormatFieldPair
Friend Shared Always_use_this_Rule_Set As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Material Control Configuration")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Selected_Pegging_Rule_Set = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Selected Pegging Rule Set"))
Allow_Backward_Links = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Allow Backward Links"))
Always_use_this_Rule_Set = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Always use this Rule Set"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Selected_Pegging_Rule_Set = Fields.PR.ReadFieldString(Selected_Pegging_Rule_Set, Record)
MyItem.Allow_Backward_Links = Fields.PR.ReadFieldBool(Allow_Backward_Links, Record)
MyItem.Always_use_this_Rule_Set = Fields.PR.ReadFieldBool(Always_use_this_Rule_Set, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Selected_Pegging_Rule_Set As String
Friend Allow_Backward_Links As Boolean
Friend Always_use_this_Rule_Set As Boolean
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Pegging_Rule_Set
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Selected_Pegging_Rule_Set As FormatFieldPair
Friend Shared Allow_Backward_Links As FormatFieldPair
Friend Shared Always_use_this_Rule_Set As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Pegging Rule Set")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Selected_Pegging_Rule_Set = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Selected Pegging Rule Set"))
Allow_Backward_Links = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Allow Backward Links"))
Always_use_this_Rule_Set = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Always use this Rule Set"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Selected_Pegging_Rule_Set = Fields.PR.ReadFieldString(Selected_Pegging_Rule_Set, Record)
MyItem.Allow_Backward_Links = Fields.PR.ReadFieldBool(Allow_Backward_Links, Record)
MyItem.Always_use_this_Rule_Set = Fields.PR.ReadFieldBool(Always_use_this_Rule_Set, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Selected_Pegging_Rule_Set As String
Friend Allow_Backward_Links As Boolean
Friend Always_use_this_Rule_Set As Boolean
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Pegging_Rules
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Belongs_to_Rule_Set As FormatFieldPair
Friend Shared Number As FormatFieldPair
Friend Shared Rule_Set As FormatFieldPair
Friend Shared Clear_Current_Links As FormatFieldPair
Friend Shared First_Pass_Clear As FormatFieldPair
Friend Shared Rule As FormatFieldPair
Friend Shared Enabled As FormatFieldPair
Friend Shared Debug_This_Rule As FormatFieldPair
Friend Shared Internal_Supply_Only As FormatFieldPair
Friend Shared Internal_Supply_Queue_Filter As FormatFieldPair
Friend Shared External_Supply_Queue_Filter_Toggle As FormatFieldPair
Friend Shared External_Supply_Queue_Filter As FormatFieldPair
Friend Shared Supply_Queue_Ranking_Toggle As FormatFieldPair
Friend Shared Supply_Queue_Ranking As FormatFieldPair
Friend Shared Inherit_From_Supply As FormatFieldPair
Friend Shared Internal_Demand_Only As FormatFieldPair
Friend Shared Include_Scheduled_Orders_in_Demand_Queue As FormatFieldPair
Friend Shared Internal_Demand_Queue_Filter As FormatFieldPair
Friend Shared External_Demand_Queue_Filter As FormatFieldPair
Friend Shared Demand_Queue_Ranking_Toggle As FormatFieldPair
Friend Shared Demand_Queue_Ranking As FormatFieldPair
Friend Shared Inherit_From_Demand As FormatFieldPair
Friend Shared Inherit_From_Demand_Toggle As FormatFieldPair
Friend Shared Inherit_From_Supply_Toggle As FormatFieldPair
Friend Shared Rule_Type As FormatFieldPair
Friend Shared User_Defined_Rule_Toggle As FormatFieldPair
Friend Shared Expression As FormatFieldPair
Friend Shared PESP_Script_Toggle As FormatFieldPair
Friend Shared PESP_Script As FormatFieldPair
Friend Shared Allocate_Multiples_Only As FormatFieldPair
Friend Shared Retain_Partial_And_Complete_Allocations As FormatFieldPair
Friend Shared Retain_Allocations_Toggle As FormatFieldPair
Friend Shared Retain_Complete_Allocations As FormatFieldPair
Friend Shared Allow_Backward_Links As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Pegging Rules")

Belongs_to_Rule_Set = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Belongs to Rule Set"))
Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Rule_Set = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Rule Set"))
Clear_Current_Links = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Clear Current Links"))
First_Pass_Clear = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "First Pass Clear"))
Rule = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Rule"))
Enabled = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Enabled"))
Debug_This_Rule = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Debug This Rule"))
Internal_Supply_Only = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Internal Supply Only"))
Internal_Supply_Queue_Filter = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Internal Supply Queue Filter"))
External_Supply_Queue_Filter_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Supply Queue Filter Toggle"))
External_Supply_Queue_Filter = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Supply Queue Filter"))
Supply_Queue_Ranking_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Supply Queue Ranking Toggle"))
Supply_Queue_Ranking = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Supply Queue Ranking"))
Inherit_From_Supply = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Inherit From Supply"))
Internal_Demand_Only = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Internal Demand Only"))
Include_Scheduled_Orders_in_Demand_Queue = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Include Scheduled Orders in Demand Queue"))
Internal_Demand_Queue_Filter = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Internal Demand Queue Filter"))
External_Demand_Queue_Filter = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Demand Queue Filter"))
Demand_Queue_Ranking_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Demand Queue Ranking Toggle"))
Demand_Queue_Ranking = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Demand Queue Ranking"))
Inherit_From_Demand = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Inherit From Demand"))
Inherit_From_Demand_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Inherit From Demand Toggle"))
Inherit_From_Supply_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Inherit From Supply Toggle"))
Rule_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Rule Type"))
User_Defined_Rule_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Defined Rule Toggle"))
Expression = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Expression"))
PESP_Script_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "PESP Script Toggle"))
PESP_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "PESP Script"))
Allocate_Multiples_Only = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Allocate Multiples Only"))
Retain_Partial_And_Complete_Allocations = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Retain Partial And Complete Allocations"))
Retain_Allocations_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Retain Allocations Toggle"))
Retain_Complete_Allocations = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Retain Complete Allocations"))
Allow_Backward_Links = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Allow Backward Links"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Belongs_to_Rule_Set = Fields.PR.ReadFieldString(Belongs_to_Rule_Set, Record)
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Rule_Set = Fields.PR.ReadFieldString(Rule_Set, Record)
MyItem.Clear_Current_Links = Fields.PR.ReadFieldBool(Clear_Current_Links, Record)
MyItem.First_Pass_Clear = Fields.PR.ReadFieldBool(First_Pass_Clear, Record)
MyItem.Rule = Fields.PR.ReadFieldString(Rule, Record)
MyItem.Enabled = Fields.PR.ReadFieldBool(Enabled, Record)
MyItem.Debug_This_Rule = Fields.PR.ReadFieldBool(Debug_This_Rule, Record)
MyItem.Internal_Supply_Only = Fields.PR.ReadFieldBool(Internal_Supply_Only, Record)
MyItem.Internal_Supply_Queue_Filter = Fields.PR.ReadFieldString(Internal_Supply_Queue_Filter, Record)
MyItem.External_Supply_Queue_Filter_Toggle = Fields.PR.ReadFieldBool(External_Supply_Queue_Filter_Toggle, Record)
MyItem.External_Supply_Queue_Filter = Fields.PR.ReadFieldString(External_Supply_Queue_Filter, Record)
MyItem.Supply_Queue_Ranking_Toggle = Fields.PR.ReadFieldBool(Supply_Queue_Ranking_Toggle, Record)
MyItem.Inherit_From_Supply = Fields.PR.ReadFieldBool(Inherit_From_Supply, Record)
MyItem.Internal_Demand_Only = Fields.PR.ReadFieldBool(Internal_Demand_Only, Record)
MyItem.Include_Scheduled_Orders_in_Demand_Queue = Fields.PR.ReadFieldBool(Include_Scheduled_Orders_in_Demand_Queue, Record)
MyItem.Internal_Demand_Queue_Filter = Fields.PR.ReadFieldString(Internal_Demand_Queue_Filter, Record)
MyItem.External_Demand_Queue_Filter = Fields.PR.ReadFieldString(External_Demand_Queue_Filter, Record)
MyItem.Demand_Queue_Ranking_Toggle = Fields.PR.ReadFieldBool(Demand_Queue_Ranking_Toggle, Record)
MyItem.Inherit_From_Demand = Fields.PR.ReadFieldBool(Inherit_From_Demand, Record)
MyItem.Inherit_From_Demand_Toggle = Fields.PR.ReadFieldBool(Inherit_From_Demand_Toggle, Record)
MyItem.Inherit_From_Supply_Toggle = Fields.PR.ReadFieldBool(Inherit_From_Supply_Toggle, Record)
MyItem.Rule_Type = Fields.PR.ReadFieldString(Rule_Type, Record)
MyItem.User_Defined_Rule_Toggle = Fields.PR.ReadFieldBool(User_Defined_Rule_Toggle, Record)
MyItem.Expression = Fields.PR.ReadFieldString(Expression, Record)
MyItem.PESP_Script_Toggle = Fields.PR.ReadFieldBool(PESP_Script_Toggle, Record)
MyItem.PESP_Script = Fields.PR.ReadFieldString(PESP_Script, Record)
MyItem.Allocate_Multiples_Only = Fields.PR.ReadFieldBool(Allocate_Multiples_Only, Record)
MyItem.Retain_Partial_And_Complete_Allocations = Fields.PR.ReadFieldBool(Retain_Partial_And_Complete_Allocations, Record)
MyItem.Retain_Allocations_Toggle = Fields.PR.ReadFieldBool(Retain_Allocations_Toggle, Record)
MyItem.Retain_Complete_Allocations = Fields.PR.ReadFieldBool(Retain_Complete_Allocations, Record)
MyItem.Allow_Backward_Links = Fields.PR.ReadFieldBool(Allow_Backward_Links, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Belongs_to_Rule_Set As String
Friend Number As Integer
Friend Rule_Set As String
Friend Clear_Current_Links As Boolean
Friend First_Pass_Clear As Boolean
Friend Rule As String
Friend Enabled As Boolean
Friend Debug_This_Rule As Boolean
Friend Internal_Supply_Only As Boolean
Friend Internal_Supply_Queue_Filter As String
Friend External_Supply_Queue_Filter_Toggle As Boolean
Friend External_Supply_Queue_Filter As String
Friend Supply_Queue_Ranking_Toggle As Boolean
Friend Inherit_From_Supply As Boolean
Friend Internal_Demand_Only As Boolean
Friend Include_Scheduled_Orders_in_Demand_Queue As Boolean
Friend Internal_Demand_Queue_Filter As String
Friend External_Demand_Queue_Filter As String
Friend Demand_Queue_Ranking_Toggle As Boolean
Friend Inherit_From_Demand As Boolean
Friend Inherit_From_Demand_Toggle As Boolean
Friend Inherit_From_Supply_Toggle As Boolean
Friend Rule_Type As String
Friend User_Defined_Rule_Toggle As Boolean
Friend Expression As String
Friend PESP_Script_Toggle As Boolean
Friend PESP_Script As String
Friend Allocate_Multiples_Only As Boolean
Friend Retain_Partial_And_Complete_Allocations As Boolean
Friend Retain_Allocations_Toggle As Boolean
Friend Retain_Complete_Allocations As Boolean
Friend Allow_Backward_Links As Boolean
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Orders
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Sous_ensemble As FormatFieldPair
Friend Shared Commande As FormatFieldPair
Friend Shared Belongs_to_Order_No As FormatFieldPair
Friend Shared Number As FormatFieldPair
Friend Shared Order_Status As FormatFieldPair
Friend Shared Order_Status_Rank As FormatFieldPair
Friend Shared Order_No As FormatFieldPair
Friend Shared Order_Type As FormatFieldPair
Friend Shared Order_Enquiry As FormatFieldPair
Friend Shared OF_DesignationOperation As FormatFieldPair
Friend Shared Part_No As FormatFieldPair
Friend Shared Product As FormatFieldPair
Friend Shared Earliest_Start_Date As FormatFieldPair
Friend Shared Latest_Start_Date As FormatFieldPair
Friend Shared Latest_End_Date As FormatFieldPair
Friend Shared Due_Date As FormatFieldPair
Friend Shared Priority As FormatFieldPair
Friend Shared Quantity As FormatFieldPair
Friend Shared Profit As FormatFieldPair
Friend Shared Order_Start As FormatFieldPair
Friend Shared Order_End As FormatFieldPair
Friend Shared Make_Span As FormatFieldPair
Friend Shared Transfer_Type As FormatFieldPair
Friend Shared Transfer_Quantity_Enabled As FormatFieldPair
Friend Shared Transfer_Quantity As FormatFieldPair
Friend Shared Start_Offset_Quantity As FormatFieldPair
Friend Shared Table_Attribute_1 As FormatFieldPair
Friend Shared Table_Attribute_1_Rank As FormatFieldPair
Friend Shared Table_Attribute_2 As FormatFieldPair
Friend Shared Table_Attribute_2_Rank As FormatFieldPair
Friend Shared Table_Attribute_3 As FormatFieldPair
Friend Shared Table_Attribute_3_Rank As FormatFieldPair
Friend Shared Table_Attribute_4 As FormatFieldPair
Friend Shared Table_Attribute_4_Rank As FormatFieldPair
Friend Shared Table_Attribute_5 As FormatFieldPair
Friend Shared Table_Attribute_5_Rank As FormatFieldPair
Friend Shared String_Attribute_1 As FormatFieldPair
Friend Shared String_Attribute_2 As FormatFieldPair
Friend Shared String_Attribute_3 As FormatFieldPair
Friend Shared String_Attribute_4 As FormatFieldPair
Friend Shared String_Attribute_5 As FormatFieldPair
Friend Shared Numerical_Attribute_1 As FormatFieldPair
Friend Shared Numerical_Attribute_2 As FormatFieldPair
Friend Shared Numerical_Attribute_3 As FormatFieldPair
Friend Shared Numerical_Attribute_4 As FormatFieldPair
Friend Shared Numerical_Attribute_5 As FormatFieldPair
Friend Shared Date_Attribute_1 As FormatFieldPair
Friend Shared Date_Save As FormatFieldPair
Friend Shared Date_Attribute_2 As FormatFieldPair
Friend Shared Duration_Attribute_1 As FormatFieldPair
Friend Shared Duration_Attribute_2 As FormatFieldPair
Friend Shared Duration_Attribute_3 As FormatFieldPair
Friend Shared Toggle_Attribute_1 As FormatFieldPair
Friend Shared Toggle_Attribute_2 As FormatFieldPair
Friend Shared Waiting_Time As FormatFieldPair
Friend Shared Total_Setup_Time As FormatFieldPair
Friend Shared Total_Process_Time As FormatFieldPair
Friend Shared Critical_Ratio As FormatFieldPair
Friend Shared Look_Ahead_Window As FormatFieldPair
Friend Shared Op_No As FormatFieldPair
Friend Shared Op_Id As FormatFieldPair
Friend Shared Operation_Name As FormatFieldPair
Friend Shared Actual_Resource As FormatFieldPair
Friend Shared Resource_Field_Enabled As FormatFieldPair
Friend Shared Resource As FormatFieldPair
Friend Shared Resource_Group As FormatFieldPair
Friend Shared Required_Resource As FormatFieldPair
Friend Shared SMT_Operation As FormatFieldPair
Friend Shared SMT_OperationString As FormatFieldPair
Friend Shared Resource_Data As FormatFieldPair
Friend Shared Automatic_Sequencing As FormatFieldPair
Friend Shared Cost_Factor_Percent As FormatFieldPair
Friend Shared Resource_Setup_Time As FormatFieldPair
Friend Shared Resource_Op_Time As FormatFieldPair
Friend Shared Resource_Rate_Per_Hour As FormatFieldPair
Friend Shared Resource_Batch_Time As FormatFieldPair
Friend Shared Resource_Real_Op_Time_per_Item As FormatFieldPair
Friend Shared Resource_Constraint As FormatFieldPair
Friend Shared Resource_Constraint_Usage As FormatFieldPair
Friend Shared Resource_Constraint_Qty As FormatFieldPair
Friend Shared Resource_Constraint_Group As FormatFieldPair
Friend Shared Resource_Selection_Timeout As FormatFieldPair
Friend Shared Set_Subsequent_Resource_Group As FormatFieldPair
Friend Shared Reset_Subsequent_Resource_Group As FormatFieldPair
Friend Shared Secondary_Constraints As FormatFieldPair
Friend Shared Constraint_Usage As FormatFieldPair
Friend Shared Constraint_Quantity As FormatFieldPair
Friend Shared Resource_Specific_Constraint_Group As FormatFieldPair
Friend Shared Selected_Resource_Specific_Constraint As FormatFieldPair
Friend Shared Constraint_Group_1 As FormatFieldPair
Friend Shared Selected_Constraint_1 As FormatFieldPair
Friend Shared Constraint_Group_2 As FormatFieldPair
Friend Shared Selected_Constraint_2 As FormatFieldPair
Friend Shared Setup_Time As FormatFieldPair
Friend Shared Process_Time_Type As FormatFieldPair
Friend Shared Rate_Per_Hour_Toggle As FormatFieldPair
Friend Shared Time_Per_Item_Toggle As FormatFieldPair
Friend Shared Time_Per_Batch_Toggle As FormatFieldPair
Friend Shared Batch_Time_Field_Toggle As FormatFieldPair
Friend Shared Resource_Time_Per_Item_Toggle As FormatFieldPair
Friend Shared Resource_Rate_Per_Hour_Toggle As FormatFieldPair
Friend Shared Resource_Batch_Time_Toggle As FormatFieldPair
Friend Shared Op_Time_per_Item As FormatFieldPair
Friend Shared Batch_Time As FormatFieldPair
Friend Shared Quantity_per_Hour As FormatFieldPair
Friend Shared Effective_Op_Time As FormatFieldPair
Friend Shared Real_Op_Time_Per_Item As FormatFieldPair
Friend Shared Slack_Time_After_Last_Operation As FormatFieldPair
Friend Shared Slack_Time_Before_Next_Operation As FormatFieldPair
Friend Shared Max_Time_Before_Next_Op As FormatFieldPair
Friend Shared Interval_Type As FormatFieldPair
Friend Shared Maximum_Operation_Span_Increase_Percent As FormatFieldPair
Friend Shared Productivity_Multiplier As FormatFieldPair
Friend Shared Delivery_Buffer As FormatFieldPair
Friend Shared Operation_Progress As FormatFieldPair
Friend Shared Mid_Batch_Time As FormatFieldPair
Friend Shared Mid_Batch_Quantity As FormatFieldPair
Friend Shared Start_Offset_End_Sync As FormatFieldPair
Friend Shared Material_Cost_Per_Item As FormatFieldPair
Friend Shared Material_Cost As FormatFieldPair
Friend Shared User_Defined_Operation_Cost As FormatFieldPair
Friend Shared Operation_Cost As FormatFieldPair
Friend Shared Order_Cost As FormatFieldPair
Friend Shared Notes As FormatFieldPair
Friend Shared Document As FormatFieldPair
Friend Shared Revision As FormatFieldPair
Friend Shared SMT_Date As FormatFieldPair
Friend Shared SMT_Side As FormatFieldPair
Friend Shared Actual_Setup_Start As FormatFieldPair
Friend Shared Actual_Start_Time As FormatFieldPair
Friend Shared Actual_End_Time As FormatFieldPair
Friend Shared Use_Actual_Times As FormatFieldPair
Friend Shared Using_Actual_Times As FormatFieldPair
Friend Shared Setup_Start As FormatFieldPair
Friend Shared Start_Time As FormatFieldPair
Friend Shared End_Time As FormatFieldPair
Friend Shared Hold As FormatFieldPair
Friend Shared Sequencing_Enabled As FormatFieldPair
Friend Shared Lock_Operation As FormatFieldPair
Friend Shared Set_Sequencer_Operation_Thumb As FormatFieldPair
Friend Shared Internal_Pegging_Information As FormatFieldPair
Friend Shared External_Pegging_Information As FormatFieldPair
Friend Shared Independent_Lots As FormatFieldPair
Friend Shared Material_Control_Complete As FormatFieldPair
Friend Shared Material_Shortage As FormatFieldPair
Friend Shared Material_Over_Supply As FormatFieldPair
Friend Shared Demand_Status As FormatFieldPair
Friend Shared Op_Seq_Marker As FormatFieldPair
Friend Shared Demand_Date As FormatFieldPair
Friend Shared Supply_Date As FormatFieldPair
Friend Shared Actual_Earliest_Start_Date As FormatFieldPair
Friend Shared Actual_Due_Date As FormatFieldPair
Friend Shared Marked_For_Deletion As FormatFieldPair
Friend Shared Original_Order_No As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair
Friend Shared Weighting As FormatFieldPair
Friend Shared Order_External_Id As FormatFieldPair
Friend Shared Operation_External_Id As FormatFieldPair
Friend Shared Client As FormatFieldPair
Friend Shared NoSeri As FormatFieldPair
Friend Shared CodeCondition As FormatFieldPair
Friend Shared DateDebut As FormatFieldPair
Friend Shared DateFin As FormatFieldPair
Friend Shared TempsTransport As FormatFieldPair
Friend Shared TempsAttente As FormatFieldPair
Friend Shared OpParallele As FormatFieldPair
Friend Shared Centre As FormatFieldPair
Friend Shared Description_Centre As FormatFieldPair
Friend Shared AJustementTemps As FormatFieldPair
Friend Shared Support As FormatFieldPair
Friend Shared SupportVisualisation As FormatFieldPair
Friend Shared Employe As FormatFieldPair
Friend Shared Planifier As FormatFieldPair
Friend Shared IlotPrecedent As FormatFieldPair
Friend Shared Qualification As FormatFieldPair
Friend Shared Identifiant As FormatFieldPair
Friend Shared GFLUX As FormatFieldPair
Friend Shared Priorite As FormatFieldPair
Friend Shared Statut_Operation As FormatFieldPair
Friend Shared Statut_Ordre As FormatFieldPair
Friend Shared Resource_External_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Orders")

Sous_ensemble = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Sous ensemble"))
Commande = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Commande"))
Belongs_to_Order_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Belongs to Order No."))
Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Order_Status = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Status"))
Order_Status_Rank = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Status Rank"))
Order_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order No."))
Order_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Type"))
Order_Enquiry = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Enquiry"))
OF_DesignationOperation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "OF_DesignationOperation"))
Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Part No."))
Product = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Product"))
Earliest_Start_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Earliest Start Date"))
Latest_Start_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Latest Start Date"))
Latest_End_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Latest End Date"))
Due_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Due Date"))
Priority = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Priority"))
Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Quantity"))
Profit = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Profit"))
Order_Start = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Start"))
Order_End = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order End"))
Make_Span = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Make Span"))
Transfer_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Transfer Type"))
Transfer_Quantity_Enabled = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Transfer Quantity Enabled"))
Transfer_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Transfer Quantity"))
Start_Offset_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Start Offset Quantity"))
Table_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 1"))
Table_Attribute_1_Rank = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 1 Rank"))
Table_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 2"))
Table_Attribute_2_Rank = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 2 Rank"))
Table_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 3"))
Table_Attribute_3_Rank = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 3 Rank"))
Table_Attribute_4 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 4"))
Table_Attribute_4_Rank = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 4 Rank"))
Table_Attribute_5 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 5"))
Table_Attribute_5_Rank = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 5 Rank"))
String_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 1"))
String_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 2"))
String_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 3"))
String_Attribute_4 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 4"))
String_Attribute_5 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 5"))
Numerical_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Numerical Attribute 1"))
Numerical_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Numerical Attribute 2"))
Numerical_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Numerical Attribute 3"))
Numerical_Attribute_4 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Numerical Attribute 4"))
Numerical_Attribute_5 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Numerical Attribute 5"))
Date_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Date Attribute 1"))
Date_Save = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Date Save"))
Date_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Date Attribute 2"))
Duration_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Duration Attribute 1"))
Duration_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Duration Attribute 2"))
Duration_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Duration Attribute 3"))
Toggle_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Toggle Attribute 1"))
Toggle_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Toggle Attribute 2"))
Waiting_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Waiting Time"))
Total_Setup_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Total Setup Time"))
Total_Process_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Total Process Time"))
Critical_Ratio = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Critical Ratio"))
Look_Ahead_Window = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Look Ahead Window"))
Op_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Op. No."))
Op_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Op. Id."))
Operation_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation Name"))
Actual_Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Actual Resource"))
Resource_Field_Enabled = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Field Enabled"))
Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource"))
Resource_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Group"))
Required_Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Required Resource"))
SMT_Operation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "SMT Operation"))
SMT_OperationString = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "SMT OperationString"))
Resource_Data = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Data"))
Automatic_Sequencing = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Automatic Sequencing?"))
Cost_Factor_Percent = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Cost Factor %"))
Resource_Setup_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Setup Time"))
Resource_Op_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Op Time"))
Resource_Rate_Per_Hour = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Rate Per Hour"))
Resource_Batch_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Batch Time"))
Resource_Real_Op_Time_per_Item = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Real Op Time per Item"))
Resource_Constraint = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Constraint"))
Resource_Constraint_Usage = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Constraint Usage"))
Resource_Constraint_Qty = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Constraint Qty"))
Resource_Constraint_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Constraint Group"))
Resource_Selection_Timeout = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Selection Timeout"))
Set_Subsequent_Resource_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Set Subsequent Resource Group"))
Reset_Subsequent_Resource_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reset Subsequent Resource Group"))
Secondary_Constraints = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Secondary Constraints"))
Constraint_Usage = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Usage"))
Constraint_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Quantity"))
Resource_Specific_Constraint_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Specific Constraint Group"))
Selected_Resource_Specific_Constraint = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Selected Resource Specific Constraint"))
Constraint_Group_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Group 1"))
Selected_Constraint_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Selected Constraint 1"))
Constraint_Group_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Group 2"))
Selected_Constraint_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Selected Constraint 2"))
Setup_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Setup Time"))
Process_Time_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Process Time Type"))
Rate_Per_Hour_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Rate Per Hour Toggle"))
Time_Per_Item_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Time Per Item Toggle"))
Time_Per_Batch_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Time Per Batch Toggle"))
Batch_Time_Field_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Batch Time Field Toggle"))
Resource_Time_Per_Item_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Time Per Item Toggle"))
Resource_Rate_Per_Hour_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Rate Per Hour Toggle"))
Resource_Batch_Time_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Batch Time Toggle"))
Op_Time_per_Item = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Op. Time per Item"))
Batch_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Batch Time"))
Quantity_per_Hour = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Quantity per Hour"))
Effective_Op_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Effective Op Time"))
Real_Op_Time_Per_Item = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Real Op Time Per Item"))
Slack_Time_After_Last_Operation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Slack Time After Last Operation"))
Slack_Time_Before_Next_Operation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Slack Time Before Next Operation"))
Max_Time_Before_Next_Op = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Max Time Before Next Op."))
Interval_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Interval Type"))
Maximum_Operation_Span_Increase_Percent = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Maximum Operation Span Increase %"))
Productivity_Multiplier = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Productivity Multiplier"))
Delivery_Buffer = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Delivery Buffer"))
Operation_Progress = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation Progress"))
Mid_Batch_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Mid Batch Time"))
Mid_Batch_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Mid Batch Quantity"))
Start_Offset_End_Sync = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Start Offset End Sync"))
Material_Cost_Per_Item = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Material Cost Per Item"))
Material_Cost = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Material Cost"))
User_Defined_Operation_Cost = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Defined Operation Cost"))
Operation_Cost = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation Cost"))
Order_Cost = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Cost"))
Notes = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Notes"))
Document = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Document"))
Revision = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Revision"))
SMT_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "SMT Date"))
SMT_Side = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "SMT Side"))
Actual_Setup_Start = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Actual Setup Start"))
Actual_Start_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Actual Start Time"))
Actual_End_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Actual End Time"))
Use_Actual_Times = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Use Actual Times"))
Using_Actual_Times = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Using Actual Times"))
Setup_Start = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Setup Start"))
Start_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Start Time"))
End_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "End Time"))
Hold = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Hold"))
Sequencing_Enabled = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Sequencing Enabled"))
Lock_Operation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Lock Operation"))
Set_Sequencer_Operation_Thumb = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Set Sequencer Operation Thumb"))
Internal_Pegging_Information = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Internal Pegging Information"))
External_Pegging_Information = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Pegging Information"))
Independent_Lots = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Independent Lots"))
Material_Control_Complete = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Material Control Complete"))
Material_Shortage = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Material Shortage"))
Material_Over_Supply = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Material Over Supply"))
Demand_Status = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Demand Status"))
Op_Seq_Marker = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Op Seq Marker"))
Demand_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Demand Date"))
Supply_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Supply Date"))
Actual_Earliest_Start_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Actual Earliest Start Date"))
Actual_Due_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Actual Due Date"))
Marked_For_Deletion = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Marked For Deletion"))
Original_Order_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Original Order No."))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))
Weighting = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Weighting"))
Order_External_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order External Id"))
Operation_External_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation External Id"))
Client = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Client"))
NoSeri = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "NoSeri"))
CodeCondition = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "CodeCondition"))
DateDebut = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "DateDebut"))
DateFin = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "DateFin"))
TempsTransport = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "TempsTransport"))
TempsAttente = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "TempsAttente"))
OpParallele = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "OpParallele"))
Centre = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Centre"))
Description_Centre = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description Centre"))
AJustementTemps = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "AJustementTemps"))
Support = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Support"))
SupportVisualisation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "SupportVisualisation"))
Employe = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Employe"))
Planifier = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Planifier"))
IlotPrecedent = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "IlotPrecedent"))
Qualification = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Qualification"))
Identifiant = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Identifiant"))
GFLUX = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "GFLUX"))
Priorite = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Priorite"))
Statut_Operation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Statut Operation"))
Statut_Ordre = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Statut Ordre"))
Resource_External_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource External Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Sous_ensemble = Fields.PR.ReadFieldBool(Sous_ensemble, Record)
MyItem.Commande = Fields.PR.ReadFieldString(Commande, Record)
MyItem.Belongs_to_Order_No = Fields.PR.ReadFieldString(Belongs_to_Order_No, Record)
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Order_Status = Fields.PR.ReadFieldString(Order_Status, Record)
MyItem.Order_Status_Rank = Fields.PR.ReadFieldInt(Order_Status_Rank, Record)
MyItem.Order_No = Fields.PR.ReadFieldString(Order_No, Record)
MyItem.Order_Type = Fields.PR.ReadFieldString(Order_Type, Record)
MyItem.Order_Enquiry = Fields.PR.ReadFieldBool(Order_Enquiry, Record)
MyItem.OF_DesignationOperation = Fields.PR.ReadFieldString(OF_DesignationOperation, Record)
MyItem.Part_No = Fields.PR.ReadFieldString(Part_No, Record)
MyItem.Product = Fields.PR.ReadFieldString(Product, Record)
MyItem.Earliest_Start_Date = Fields.PR.ReadFieldDatetime(Earliest_Start_Date, Record)
MyItem.Latest_Start_Date = Fields.PR.ReadFieldDatetime(Latest_Start_Date, Record)
MyItem.Latest_End_Date = Fields.PR.ReadFieldDatetime(Latest_End_Date, Record)
MyItem.Due_Date = Fields.PR.ReadFieldDatetime(Due_Date, Record)
MyItem.Priority = Fields.PR.ReadFieldDouble(Priority, Record)
MyItem.Quantity = Fields.PR.ReadFieldDouble(Quantity, Record)
MyItem.Profit = Fields.PR.ReadFieldDouble(Profit, Record)
MyItem.Order_Start = Fields.PR.ReadFieldDatetime(Order_Start, Record)
MyItem.Order_End = Fields.PR.ReadFieldDatetime(Order_End, Record)
MyItem.Make_Span = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Make_Span, Record))
MyItem.Transfer_Type = Fields.PR.ReadFieldInt(Transfer_Type, Record)
MyItem.Transfer_Quantity_Enabled = Fields.PR.ReadFieldBool(Transfer_Quantity_Enabled, Record)
MyItem.Transfer_Quantity = Fields.PR.ReadFieldDouble(Transfer_Quantity, Record)
MyItem.Start_Offset_Quantity = Fields.PR.ReadFieldDouble(Start_Offset_Quantity, Record)
MyItem.Table_Attribute_1 = Fields.PR.ReadFieldString(Table_Attribute_1, Record)
MyItem.Table_Attribute_1_Rank = Fields.PR.ReadFieldInt(Table_Attribute_1_Rank, Record)
MyItem.Table_Attribute_2 = Fields.PR.ReadFieldString(Table_Attribute_2, Record)
MyItem.Table_Attribute_2_Rank = Fields.PR.ReadFieldInt(Table_Attribute_2_Rank, Record)
MyItem.Table_Attribute_3 = Fields.PR.ReadFieldString(Table_Attribute_3, Record)
MyItem.Table_Attribute_3_Rank = Fields.PR.ReadFieldInt(Table_Attribute_3_Rank, Record)
MyItem.Table_Attribute_4 = Fields.PR.ReadFieldString(Table_Attribute_4, Record)
MyItem.Table_Attribute_4_Rank = Fields.PR.ReadFieldInt(Table_Attribute_4_Rank, Record)
MyItem.Table_Attribute_5 = Fields.PR.ReadFieldString(Table_Attribute_5, Record)
MyItem.Table_Attribute_5_Rank = Fields.PR.ReadFieldInt(Table_Attribute_5_Rank, Record)
MyItem.String_Attribute_1 = Fields.PR.ReadFieldString(String_Attribute_1, Record)
MyItem.String_Attribute_2 = Fields.PR.ReadFieldString(String_Attribute_2, Record)
MyItem.String_Attribute_3 = Fields.PR.ReadFieldString(String_Attribute_3, Record)
MyItem.String_Attribute_4 = Fields.PR.ReadFieldString(String_Attribute_4, Record)
MyItem.String_Attribute_5 = Fields.PR.ReadFieldString(String_Attribute_5, Record)
MyItem.Numerical_Attribute_1 = Fields.PR.ReadFieldDouble(Numerical_Attribute_1, Record)
MyItem.Numerical_Attribute_2 = Fields.PR.ReadFieldDouble(Numerical_Attribute_2, Record)
MyItem.Numerical_Attribute_3 = Fields.PR.ReadFieldDouble(Numerical_Attribute_3, Record)
MyItem.Numerical_Attribute_4 = Fields.PR.ReadFieldDouble(Numerical_Attribute_4, Record)
MyItem.Numerical_Attribute_5 = Fields.PR.ReadFieldDouble(Numerical_Attribute_5, Record)
MyItem.Date_Attribute_1 = Fields.PR.ReadFieldDatetime(Date_Attribute_1, Record)
MyItem.Date_Save = Fields.PR.ReadFieldDatetime(Date_Save, Record)
MyItem.Date_Attribute_2 = Fields.PR.ReadFieldDatetime(Date_Attribute_2, Record)
MyItem.Duration_Attribute_1 = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Duration_Attribute_1, Record))
MyItem.Duration_Attribute_2 = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Duration_Attribute_2, Record))
MyItem.Duration_Attribute_3 = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Duration_Attribute_3, Record))
MyItem.Toggle_Attribute_1 = Fields.PR.ReadFieldBool(Toggle_Attribute_1, Record)
MyItem.Toggle_Attribute_2 = Fields.PR.ReadFieldBool(Toggle_Attribute_2, Record)
MyItem.Waiting_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Waiting_Time, Record))
MyItem.Total_Setup_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Total_Setup_Time, Record))
MyItem.Total_Process_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Total_Process_Time, Record))
MyItem.Critical_Ratio = Fields.PR.ReadFieldDouble(Critical_Ratio, Record)
MyItem.Look_Ahead_Window = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Look_Ahead_Window, Record))
MyItem.Op_No = Fields.PR.ReadFieldInt(Op_No, Record)
MyItem.Op_Id = Fields.PR.ReadFieldInt(Op_Id, Record)
MyItem.Operation_Name = Fields.PR.ReadFieldString(Operation_Name, Record)
MyItem.Actual_Resource = Fields.PR.ReadFieldString(Actual_Resource, Record)
MyItem.Resource_Field_Enabled = Fields.PR.ReadFieldBool(Resource_Field_Enabled, Record)
MyItem.Resource = Fields.PR.ReadFieldString(Resource, Record)
MyItem.Resource_Group = Fields.PR.ReadFieldString(Resource_Group, Record)
MyItem.Required_Resource = Fields.PR.ReadFieldString(Required_Resource, Record)
MyItem.SMT_Operation = Fields.PR.ReadFieldBool(SMT_Operation, Record)
MyItem.SMT_OperationString = Fields.PR.ReadFieldString(SMT_OperationString, Record)
MyItem.Resource_Specific_Constraint_Group = Fields.PR.ReadFieldString(Resource_Specific_Constraint_Group, Record)
MyItem.Selected_Resource_Specific_Constraint = Fields.PR.ReadFieldString(Selected_Resource_Specific_Constraint, Record)
MyItem.Constraint_Group_1 = Fields.PR.ReadFieldString(Constraint_Group_1, Record)
MyItem.Selected_Constraint_1 = Fields.PR.ReadFieldString(Selected_Constraint_1, Record)
MyItem.Constraint_Group_2 = Fields.PR.ReadFieldString(Constraint_Group_2, Record)
MyItem.Selected_Constraint_2 = Fields.PR.ReadFieldString(Selected_Constraint_2, Record)
MyItem.Setup_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Setup_Time, Record))
MyItem.Process_Time_Type = Fields.PR.ReadFieldString(Process_Time_Type, Record)
MyItem.Rate_Per_Hour_Toggle = Fields.PR.ReadFieldBool(Rate_Per_Hour_Toggle, Record)
MyItem.Time_Per_Item_Toggle = Fields.PR.ReadFieldBool(Time_Per_Item_Toggle, Record)
MyItem.Time_Per_Batch_Toggle = Fields.PR.ReadFieldBool(Time_Per_Batch_Toggle, Record)
MyItem.Batch_Time_Field_Toggle = Fields.PR.ReadFieldBool(Batch_Time_Field_Toggle, Record)
MyItem.Resource_Time_Per_Item_Toggle = Fields.PR.ReadFieldBool(Resource_Time_Per_Item_Toggle, Record)
MyItem.Resource_Rate_Per_Hour_Toggle = Fields.PR.ReadFieldBool(Resource_Rate_Per_Hour_Toggle, Record)
MyItem.Resource_Batch_Time_Toggle = Fields.PR.ReadFieldBool(Resource_Batch_Time_Toggle, Record)
MyItem.Op_Time_per_Item = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Op_Time_per_Item, Record))
MyItem.Batch_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Batch_Time, Record))
MyItem.Quantity_per_Hour = Fields.PR.ReadFieldDouble(Quantity_per_Hour, Record)
MyItem.Effective_Op_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Effective_Op_Time, Record))
MyItem.Real_Op_Time_Per_Item = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Real_Op_Time_Per_Item, Record))
MyItem.Slack_Time_After_Last_Operation = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Slack_Time_After_Last_Operation, Record))
MyItem.Slack_Time_Before_Next_Operation = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Slack_Time_Before_Next_Operation, Record))
MyItem.Max_Time_Before_Next_Op = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Max_Time_Before_Next_Op, Record))
MyItem.Interval_Type = Fields.PR.ReadFieldString(Interval_Type, Record)
MyItem.Maximum_Operation_Span_Increase_Percent = Fields.PR.ReadFieldDouble(Maximum_Operation_Span_Increase_Percent, Record)
MyItem.Productivity_Multiplier = Fields.PR.ReadFieldDouble(Productivity_Multiplier, Record)
MyItem.Delivery_Buffer = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Delivery_Buffer, Record))
MyItem.Operation_Progress = Fields.PR.ReadFieldString(Operation_Progress, Record)
MyItem.Mid_Batch_Time = Fields.PR.ReadFieldDatetime(Mid_Batch_Time, Record)
MyItem.Mid_Batch_Quantity = Fields.PR.ReadFieldDouble(Mid_Batch_Quantity, Record)
MyItem.Start_Offset_End_Sync = Fields.PR.ReadFieldBool(Start_Offset_End_Sync, Record)
MyItem.Material_Cost_Per_Item = Fields.PR.ReadFieldDouble(Material_Cost_Per_Item, Record)
MyItem.Material_Cost = Fields.PR.ReadFieldDouble(Material_Cost, Record)
MyItem.User_Defined_Operation_Cost = Fields.PR.ReadFieldDouble(User_Defined_Operation_Cost, Record)
MyItem.Operation_Cost = Fields.PR.ReadFieldDouble(Operation_Cost, Record)
MyItem.Order_Cost = Fields.PR.ReadFieldDouble(Order_Cost, Record)
MyItem.Notes = Fields.PR.ReadFieldString(Notes, Record)
MyItem.Document = Fields.PR.ReadFieldString(Document, Record)
MyItem.Revision = Fields.PR.ReadFieldString(Revision, Record)
MyItem.SMT_Date = Fields.PR.ReadFieldDatetime(SMT_Date, Record)
MyItem.SMT_Side = Fields.PR.ReadFieldString(SMT_Side, Record)
MyItem.Actual_Setup_Start = Fields.PR.ReadFieldDatetime(Actual_Setup_Start, Record)
MyItem.Actual_Start_Time = Fields.PR.ReadFieldDatetime(Actual_Start_Time, Record)
MyItem.Actual_End_Time = Fields.PR.ReadFieldDatetime(Actual_End_Time, Record)
MyItem.Use_Actual_Times = Fields.PR.ReadFieldBool(Use_Actual_Times, Record)
MyItem.Using_Actual_Times = Fields.PR.ReadFieldBool(Using_Actual_Times, Record)
MyItem.Setup_Start = Fields.PR.ReadFieldDatetime(Setup_Start, Record)
MyItem.Start_Time = Fields.PR.ReadFieldDatetime(Start_Time, Record)
MyItem.End_Time = Fields.PR.ReadFieldDatetime(End_Time, Record)
MyItem.Hold = Fields.PR.ReadFieldBool(Hold, Record)
MyItem.Sequencing_Enabled = Fields.PR.ReadFieldBool(Sequencing_Enabled, Record)
MyItem.Lock_Operation = Fields.PR.ReadFieldBool(Lock_Operation, Record)
MyItem.Set_Sequencer_Operation_Thumb = Fields.PR.ReadFieldBool(Set_Sequencer_Operation_Thumb, Record)
MyItem.Independent_Lots = Fields.PR.ReadFieldBool(Independent_Lots, Record)
MyItem.Material_Control_Complete = Fields.PR.ReadFieldBool(Material_Control_Complete, Record)
MyItem.Material_Shortage = Fields.PR.ReadFieldBool(Material_Shortage, Record)
MyItem.Material_Over_Supply = Fields.PR.ReadFieldBool(Material_Over_Supply, Record)
MyItem.Demand_Status = Fields.PR.ReadFieldString(Demand_Status, Record)
MyItem.Op_Seq_Marker = Fields.PR.ReadFieldInt(Op_Seq_Marker, Record)
MyItem.Demand_Date = Fields.PR.ReadFieldDatetime(Demand_Date, Record)
MyItem.Supply_Date = Fields.PR.ReadFieldDatetime(Supply_Date, Record)
MyItem.Actual_Earliest_Start_Date = Fields.PR.ReadFieldDatetime(Actual_Earliest_Start_Date, Record)
MyItem.Actual_Due_Date = Fields.PR.ReadFieldDatetime(Actual_Due_Date, Record)
MyItem.Marked_For_Deletion = Fields.PR.ReadFieldBool(Marked_For_Deletion, Record)
MyItem.Original_Order_No = Fields.PR.ReadFieldString(Original_Order_No, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)
MyItem.Weighting = Fields.PR.ReadFieldDouble(Weighting, Record)
MyItem.Order_External_Id = Fields.PR.ReadFieldString(Order_External_Id, Record)
MyItem.Operation_External_Id = Fields.PR.ReadFieldString(Operation_External_Id, Record)
MyItem.Client = Fields.PR.ReadFieldString(Client, Record)
MyItem.NoSeri = Fields.PR.ReadFieldString(NoSeri, Record)
MyItem.CodeCondition = Fields.PR.ReadFieldString(CodeCondition, Record)
MyItem.DateDebut = Fields.PR.ReadFieldString(DateDebut, Record)
MyItem.DateFin = Fields.PR.ReadFieldString(DateFin, Record)
MyItem.TempsTransport = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(TempsTransport, Record))
MyItem.TempsAttente = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(TempsAttente, Record))
MyItem.OpParallele = Fields.PR.ReadFieldString(OpParallele, Record)
MyItem.Centre = Fields.PR.ReadFieldString(Centre, Record)
MyItem.Description_Centre = Fields.PR.ReadFieldString(Description_Centre, Record)
MyItem.AJustementTemps = Fields.PR.ReadFieldString(AJustementTemps, Record)
MyItem.Support = Fields.PR.ReadFieldString(Support, Record)
MyItem.SupportVisualisation = Fields.PR.ReadFieldBool(SupportVisualisation, Record)
MyItem.Employe = Fields.PR.ReadFieldString(Employe, Record)
MyItem.Planifier = Fields.PR.ReadFieldBool(Planifier, Record)
MyItem.IlotPrecedent = Fields.PR.ReadFieldString(IlotPrecedent, Record)
MyItem.Qualification = Fields.PR.ReadFieldString(Qualification, Record)
MyItem.Identifiant = Fields.PR.ReadFieldString(Identifiant, Record)
MyItem.GFLUX = Fields.PR.ReadFieldString(GFLUX, Record)
MyItem.Priorite = Fields.PR.ReadFieldString(Priorite, Record)
MyItem.Statut_Operation = Fields.PR.ReadFieldString(Statut_Operation, Record)
MyItem.Statut_Ordre = Fields.PR.ReadFieldString(Statut_Ordre, Record)
MyItem.Resource_External_Id = Fields.PR.ReadFieldString(Resource_External_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Sous_ensemble As Boolean
Friend Commande As String
Friend Belongs_to_Order_No As String
Friend Number As Integer
Friend Order_Status As String
Friend Order_Status_Rank As Integer
Friend Order_No As String
Friend Order_Type As String
Friend Order_Enquiry As Boolean
Friend OF_DesignationOperation As String
Friend Part_No As String
Friend Product As String
Friend Earliest_Start_Date As DateTime
Friend Latest_Start_Date As DateTime
Friend Latest_End_Date As DateTime
Friend Due_Date As DateTime
Friend Priority As Double
Friend Quantity As Double
Friend Profit As Double
Friend Order_Start As DateTime
Friend Order_End As DateTime
Friend Make_Span As TimeSpan
Friend Transfer_Type As Integer
Friend Transfer_Quantity_Enabled As Boolean
Friend Transfer_Quantity As Double
Friend Start_Offset_Quantity As Double
Friend Table_Attribute_1 As String
Friend Table_Attribute_1_Rank As Integer
Friend Table_Attribute_2 As String
Friend Table_Attribute_2_Rank As Integer
Friend Table_Attribute_3 As String
Friend Table_Attribute_3_Rank As Integer
Friend Table_Attribute_4 As String
Friend Table_Attribute_4_Rank As Integer
Friend Table_Attribute_5 As String
Friend Table_Attribute_5_Rank As Integer
Friend String_Attribute_1 As String
Friend String_Attribute_2 As String
Friend String_Attribute_3 As String
Friend String_Attribute_4 As String
Friend String_Attribute_5 As String
Friend Numerical_Attribute_1 As Double
Friend Numerical_Attribute_2 As Double
Friend Numerical_Attribute_3 As Double
Friend Numerical_Attribute_4 As Double
Friend Numerical_Attribute_5 As Double
Friend Date_Attribute_1 As DateTime
Friend Date_Save As DateTime
Friend Date_Attribute_2 As DateTime
Friend Duration_Attribute_1 As TimeSpan
Friend Duration_Attribute_2 As TimeSpan
Friend Duration_Attribute_3 As TimeSpan
Friend Toggle_Attribute_1 As Boolean
Friend Toggle_Attribute_2 As Boolean
Friend Waiting_Time As TimeSpan
Friend Total_Setup_Time As TimeSpan
Friend Total_Process_Time As TimeSpan
Friend Critical_Ratio As Double
Friend Look_Ahead_Window As TimeSpan
Friend Op_No As Integer
Friend Op_Id As Integer
Friend Operation_Name As String
Friend Actual_Resource As String
Friend Resource_Field_Enabled As Boolean
Friend Resource As String
Friend Resource_Group As String
Friend Required_Resource As String
Friend SMT_Operation As Boolean
Friend SMT_OperationString As String
Friend Resource_Specific_Constraint_Group As String
Friend Selected_Resource_Specific_Constraint As String
Friend Constraint_Group_1 As String
Friend Selected_Constraint_1 As String
Friend Constraint_Group_2 As String
Friend Selected_Constraint_2 As String
Friend Setup_Time As TimeSpan
Friend Process_Time_Type As String
Friend Rate_Per_Hour_Toggle As Boolean
Friend Time_Per_Item_Toggle As Boolean
Friend Time_Per_Batch_Toggle As Boolean
Friend Batch_Time_Field_Toggle As Boolean
Friend Resource_Time_Per_Item_Toggle As Boolean
Friend Resource_Rate_Per_Hour_Toggle As Boolean
Friend Resource_Batch_Time_Toggle As Boolean
Friend Op_Time_per_Item As TimeSpan
Friend Batch_Time As TimeSpan
Friend Quantity_per_Hour As Double
Friend Effective_Op_Time As TimeSpan
Friend Real_Op_Time_Per_Item As TimeSpan
Friend Slack_Time_After_Last_Operation As TimeSpan
Friend Slack_Time_Before_Next_Operation As TimeSpan
Friend Max_Time_Before_Next_Op As TimeSpan
Friend Interval_Type As String
Friend Maximum_Operation_Span_Increase_Percent As Double
Friend Productivity_Multiplier As Double
Friend Delivery_Buffer As TimeSpan
Friend Operation_Progress As String
Friend Mid_Batch_Time As DateTime
Friend Mid_Batch_Quantity As Double
Friend Start_Offset_End_Sync As Boolean
Friend Material_Cost_Per_Item As Double
Friend Material_Cost As Double
Friend User_Defined_Operation_Cost As Double
Friend Operation_Cost As Double
Friend Order_Cost As Double
Friend Notes As String
Friend Document As String
Friend Revision As String
Friend SMT_Date As DateTime
Friend SMT_Side As String
Friend Actual_Setup_Start As DateTime
Friend Actual_Start_Time As DateTime
Friend Actual_End_Time As DateTime
Friend Use_Actual_Times As Boolean
Friend Using_Actual_Times As Boolean
Friend Setup_Start As DateTime
Friend Start_Time As DateTime
Friend End_Time As DateTime
Friend Hold As Boolean
Friend Sequencing_Enabled As Boolean
Friend Lock_Operation As Boolean
Friend Set_Sequencer_Operation_Thumb As Boolean
Friend Independent_Lots As Boolean
Friend Material_Control_Complete As Boolean
Friend Material_Shortage As Boolean
Friend Material_Over_Supply As Boolean
Friend Demand_Status As String
Friend Op_Seq_Marker As Integer
Friend Demand_Date As DateTime
Friend Supply_Date As DateTime
Friend Actual_Earliest_Start_Date As DateTime
Friend Actual_Due_Date As DateTime
Friend Marked_For_Deletion As Boolean
Friend Original_Order_No As String
Friend Display_Sequence_Number As Double
Friend Weighting As Double
Friend Order_External_Id As String
Friend Operation_External_Id As String
Friend Client As String
Friend NoSeri As String
Friend CodeCondition As String
Friend DateDebut As String
Friend DateFin As String
Friend TempsTransport As TimeSpan
Friend TempsAttente As TimeSpan
Friend OpParallele As String
Friend Centre As String
Friend Description_Centre As String
Friend AJustementTemps As String
Friend Support As String
Friend SupportVisualisation As Boolean
Friend Employe As String
Friend Planifier As Boolean
Friend IlotPrecedent As String
Friend Qualification As String
Friend Identifiant As String
Friend GFLUX As String
Friend Priorite As String
Friend Statut_Operation As String
Friend Statut_Ordre As String
Friend Resource_External_Id As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Products
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Parent_Part As FormatFieldPair
Friend Shared Number As FormatFieldPair
Friend Shared Part_No As FormatFieldPair
Friend Shared Product As FormatFieldPair
Friend Shared Profit As FormatFieldPair
Friend Shared Transfer_Quantity As FormatFieldPair
Friend Shared Table_Attribute_1 As FormatFieldPair
Friend Shared Table_Attribute_2 As FormatFieldPair
Friend Shared Table_Attribute_3 As FormatFieldPair
Friend Shared Table_Attribute_4 As FormatFieldPair
Friend Shared Table_Attribute_5 As FormatFieldPair
Friend Shared String_Attribute_1 As FormatFieldPair
Friend Shared String_Attribute_2 As FormatFieldPair
Friend Shared String_Attribute_3 As FormatFieldPair
Friend Shared String_Attribute_4 As FormatFieldPair
Friend Shared String_Attribute_5 As FormatFieldPair
Friend Shared Numerical_Attribute_1 As FormatFieldPair
Friend Shared Numerical_Attribute_2 As FormatFieldPair
Friend Shared Numerical_Attribute_3 As FormatFieldPair
Friend Shared Numerical_Attribute_4 As FormatFieldPair
Friend Shared Numerical_Attribute_5 As FormatFieldPair
Friend Shared Date_Attribute_1 As FormatFieldPair
Friend Shared Date_Attribute_2 As FormatFieldPair
Friend Shared Duration_Attribute_1 As FormatFieldPair
Friend Shared Duration_Attribute_2 As FormatFieldPair
Friend Shared Duration_Attribute_3 As FormatFieldPair
Friend Shared Toggle_Attribute_1 As FormatFieldPair
Friend Shared Toggle_Attribute_2 As FormatFieldPair
Friend Shared Look_Ahead_Window As FormatFieldPair
Friend Shared Op_No As FormatFieldPair
Friend Shared Op_Id As FormatFieldPair
Friend Shared Operation_Name As FormatFieldPair
Friend Shared Operation As FormatFieldPair
Friend Shared Resource_Group As FormatFieldPair
Friend Shared Required_Resource As FormatFieldPair
Friend Shared SMT_Operation As FormatFieldPair
Friend Shared SMT_OperationString As FormatFieldPair
Friend Shared Revision As FormatFieldPair
Friend Shared SMT_Date As FormatFieldPair
Friend Shared SMT_Side As FormatFieldPair
Friend Shared Resource_Data As FormatFieldPair
Friend Shared Automatic_Sequencing As FormatFieldPair
Friend Shared Cost_Factor_Percent As FormatFieldPair
Friend Shared Resource_Setup_Time As FormatFieldPair
Friend Shared Resource_Op_Time As FormatFieldPair
Friend Shared Resource_Rate_Per_Hour As FormatFieldPair
Friend Shared Resource_Batch_Time As FormatFieldPair
Friend Shared Resource_Real_Op_Time_per_Item As FormatFieldPair
Friend Shared Resource_Constraint As FormatFieldPair
Friend Shared Resource_Constraint_Usage As FormatFieldPair
Friend Shared Resource_Constraint_Qty As FormatFieldPair
Friend Shared Resource_Constraint_Group As FormatFieldPair
Friend Shared Resource_Selection_Timeout As FormatFieldPair
Friend Shared Set_Subsequent_Resource_Group As FormatFieldPair
Friend Shared Reset_Subsequent_Resource_Group As FormatFieldPair
Friend Shared Secondary_Constraints As FormatFieldPair
Friend Shared Constraint_Usage As FormatFieldPair
Friend Shared Constraint_Quantity As FormatFieldPair
Friend Shared Constraint_Group_1 As FormatFieldPair
Friend Shared Constraint_Group_2 As FormatFieldPair
Friend Shared Setup_Time As FormatFieldPair
Friend Shared Process_Time_Type As FormatFieldPair
Friend Shared Rate_Per_Hour_Toggle As FormatFieldPair
Friend Shared Time_Per_Item_Toggle As FormatFieldPair
Friend Shared Batch_Time_Field_Toggle As FormatFieldPair
Friend Shared Resource_Time_Per_Item_Toggle As FormatFieldPair
Friend Shared Resource_Rate_Per_Hour_Toggle As FormatFieldPair
Friend Shared Resource_Batch_Time_Toggle As FormatFieldPair
Friend Shared Op_Time_per_Item As FormatFieldPair
Friend Shared Batch_Time As FormatFieldPair
Friend Shared Quantity_per_Hour As FormatFieldPair
Friend Shared Real_Op_Time_Per_Item As FormatFieldPair
Friend Shared Slack_Time_After_Last_Operation As FormatFieldPair
Friend Shared Slack_Time_Before_Next_Operation As FormatFieldPair
Friend Shared Max_Time_Before_Next_Op As FormatFieldPair
Friend Shared Interval_Type As FormatFieldPair
Friend Shared Maximum_Operation_Span_Increase_Percent As FormatFieldPair
Friend Shared Productivity_Multiplier As FormatFieldPair
Friend Shared Delivery_Buffer As FormatFieldPair
Friend Shared Material_Cost_Per_Item As FormatFieldPair
Friend Shared User_Defined_Operation_Cost As FormatFieldPair
Friend Shared Notes As FormatFieldPair
Friend Shared Document As FormatFieldPair
Friend Shared Independent_Lots As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair
Friend Shared External_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Products")

Parent_Part = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Parent Part"))
Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Part_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Part No."))
Product = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Product"))
Profit = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Profit"))
Transfer_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Transfer Quantity"))
Table_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 1"))
Table_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 2"))
Table_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 3"))
Table_Attribute_4 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 4"))
Table_Attribute_5 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Table Attribute 5"))
String_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 1"))
String_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 2"))
String_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 3"))
String_Attribute_4 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 4"))
String_Attribute_5 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "String Attribute 5"))
Numerical_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Numerical Attribute 1"))
Numerical_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Numerical Attribute 2"))
Numerical_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Numerical Attribute 3"))
Numerical_Attribute_4 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Numerical Attribute 4"))
Numerical_Attribute_5 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Numerical Attribute 5"))
Date_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Date Attribute 1"))
Date_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Date Attribute 2"))
Duration_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Duration Attribute 1"))
Duration_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Duration Attribute 2"))
Duration_Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Duration Attribute 3"))
Toggle_Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Toggle Attribute 1"))
Toggle_Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Toggle Attribute 2"))
Look_Ahead_Window = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Look Ahead Window"))
Op_No = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Op. No."))
Op_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Op. Id."))
Operation_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation Name"))
Operation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Operation"))
Resource_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Group"))
Required_Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Required Resource"))
SMT_Operation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "SMT Operation"))
SMT_OperationString = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "SMT OperationString"))
Revision = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Revision"))
SMT_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "SMT Date"))
SMT_Side = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "SMT Side"))
Resource_Data = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Data"))
Automatic_Sequencing = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Automatic Sequencing?"))
Cost_Factor_Percent = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Cost Factor %"))
Resource_Setup_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Setup Time"))
Resource_Op_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Op Time"))
Resource_Rate_Per_Hour = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Rate Per Hour"))
Resource_Batch_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Batch Time"))
Resource_Real_Op_Time_per_Item = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Real Op Time per Item"))
Resource_Constraint = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Constraint"))
Resource_Constraint_Usage = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Constraint Usage"))
Resource_Constraint_Qty = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Constraint Qty"))
Resource_Constraint_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Constraint Group"))
Resource_Selection_Timeout = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Selection Timeout"))
Set_Subsequent_Resource_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Set Subsequent Resource Group"))
Reset_Subsequent_Resource_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reset Subsequent Resource Group"))
Secondary_Constraints = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Secondary Constraints"))
Constraint_Usage = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Usage"))
Constraint_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Quantity"))
Constraint_Group_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Group 1"))
Constraint_Group_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Group 2"))
Setup_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Setup Time"))
Process_Time_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Process Time Type"))
Rate_Per_Hour_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Rate Per Hour Toggle"))
Time_Per_Item_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Time Per Item Toggle"))
Batch_Time_Field_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Batch Time Field Toggle"))
Resource_Time_Per_Item_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Time Per Item Toggle"))
Resource_Rate_Per_Hour_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Rate Per Hour Toggle"))
Resource_Batch_Time_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Batch Time Toggle"))
Op_Time_per_Item = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Op. Time per Item"))
Batch_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Batch Time"))
Quantity_per_Hour = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Quantity per Hour"))
Real_Op_Time_Per_Item = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Real Op Time Per Item"))
Slack_Time_After_Last_Operation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Slack Time After Last Operation"))
Slack_Time_Before_Next_Operation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Slack Time Before Next Operation"))
Max_Time_Before_Next_Op = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Max Time Before Next Op."))
Interval_Type = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Interval Type"))
Maximum_Operation_Span_Increase_Percent = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Maximum Operation Span Increase %"))
Productivity_Multiplier = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Productivity Multiplier"))
Delivery_Buffer = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Delivery Buffer"))
Material_Cost_Per_Item = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Material Cost Per Item"))
User_Defined_Operation_Cost = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Defined Operation Cost"))
Notes = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Notes"))
Document = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Document"))
Independent_Lots = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Independent Lots"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))
External_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Parent_Part = Fields.PR.ReadFieldString(Parent_Part, Record)
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Part_No = Fields.PR.ReadFieldString(Part_No, Record)
MyItem.Product = Fields.PR.ReadFieldString(Product, Record)
MyItem.Profit = Fields.PR.ReadFieldDouble(Profit, Record)
MyItem.Transfer_Quantity = Fields.PR.ReadFieldDouble(Transfer_Quantity, Record)
MyItem.Table_Attribute_1 = Fields.PR.ReadFieldString(Table_Attribute_1, Record)
MyItem.Table_Attribute_2 = Fields.PR.ReadFieldString(Table_Attribute_2, Record)
MyItem.Table_Attribute_3 = Fields.PR.ReadFieldString(Table_Attribute_3, Record)
MyItem.Table_Attribute_4 = Fields.PR.ReadFieldString(Table_Attribute_4, Record)
MyItem.Table_Attribute_5 = Fields.PR.ReadFieldString(Table_Attribute_5, Record)
MyItem.String_Attribute_1 = Fields.PR.ReadFieldString(String_Attribute_1, Record)
MyItem.String_Attribute_2 = Fields.PR.ReadFieldString(String_Attribute_2, Record)
MyItem.String_Attribute_3 = Fields.PR.ReadFieldString(String_Attribute_3, Record)
MyItem.String_Attribute_4 = Fields.PR.ReadFieldString(String_Attribute_4, Record)
MyItem.String_Attribute_5 = Fields.PR.ReadFieldString(String_Attribute_5, Record)
MyItem.Numerical_Attribute_1 = Fields.PR.ReadFieldDouble(Numerical_Attribute_1, Record)
MyItem.Numerical_Attribute_2 = Fields.PR.ReadFieldDouble(Numerical_Attribute_2, Record)
MyItem.Numerical_Attribute_3 = Fields.PR.ReadFieldDouble(Numerical_Attribute_3, Record)
MyItem.Numerical_Attribute_4 = Fields.PR.ReadFieldDouble(Numerical_Attribute_4, Record)
MyItem.Numerical_Attribute_5 = Fields.PR.ReadFieldDouble(Numerical_Attribute_5, Record)
MyItem.Date_Attribute_1 = Fields.PR.ReadFieldDatetime(Date_Attribute_1, Record)
MyItem.Date_Attribute_2 = Fields.PR.ReadFieldDatetime(Date_Attribute_2, Record)
MyItem.Duration_Attribute_1 = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Duration_Attribute_1, Record))
MyItem.Duration_Attribute_2 = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Duration_Attribute_2, Record))
MyItem.Duration_Attribute_3 = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Duration_Attribute_3, Record))
MyItem.Toggle_Attribute_1 = Fields.PR.ReadFieldBool(Toggle_Attribute_1, Record)
MyItem.Toggle_Attribute_2 = Fields.PR.ReadFieldBool(Toggle_Attribute_2, Record)
MyItem.Look_Ahead_Window = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Look_Ahead_Window, Record))
MyItem.Op_No = Fields.PR.ReadFieldInt(Op_No, Record)
MyItem.Op_Id = Fields.PR.ReadFieldInt(Op_Id, Record)
MyItem.Operation_Name = Fields.PR.ReadFieldString(Operation_Name, Record)
MyItem.Operation = Fields.PR.ReadFieldString(Operation, Record)
MyItem.Resource_Group = Fields.PR.ReadFieldString(Resource_Group, Record)
MyItem.Required_Resource = Fields.PR.ReadFieldString(Required_Resource, Record)
MyItem.SMT_Operation = Fields.PR.ReadFieldBool(SMT_Operation, Record)
MyItem.SMT_OperationString = Fields.PR.ReadFieldString(SMT_OperationString, Record)
MyItem.Revision = Fields.PR.ReadFieldString(Revision, Record)
MyItem.SMT_Date = Fields.PR.ReadFieldDatetime(SMT_Date, Record)
MyItem.SMT_Side = Fields.PR.ReadFieldString(SMT_Side, Record)
MyItem.Constraint_Group_1 = Fields.PR.ReadFieldString(Constraint_Group_1, Record)
MyItem.Constraint_Group_2 = Fields.PR.ReadFieldString(Constraint_Group_2, Record)
MyItem.Setup_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Setup_Time, Record))
MyItem.Process_Time_Type = Fields.PR.ReadFieldString(Process_Time_Type, Record)
MyItem.Rate_Per_Hour_Toggle = Fields.PR.ReadFieldBool(Rate_Per_Hour_Toggle, Record)
MyItem.Time_Per_Item_Toggle = Fields.PR.ReadFieldBool(Time_Per_Item_Toggle, Record)
MyItem.Batch_Time_Field_Toggle = Fields.PR.ReadFieldBool(Batch_Time_Field_Toggle, Record)
MyItem.Resource_Time_Per_Item_Toggle = Fields.PR.ReadFieldBool(Resource_Time_Per_Item_Toggle, Record)
MyItem.Resource_Rate_Per_Hour_Toggle = Fields.PR.ReadFieldBool(Resource_Rate_Per_Hour_Toggle, Record)
MyItem.Resource_Batch_Time_Toggle = Fields.PR.ReadFieldBool(Resource_Batch_Time_Toggle, Record)
MyItem.Op_Time_per_Item = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Op_Time_per_Item, Record))
MyItem.Batch_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Batch_Time, Record))
MyItem.Quantity_per_Hour = Fields.PR.ReadFieldDouble(Quantity_per_Hour, Record)
MyItem.Real_Op_Time_Per_Item = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Real_Op_Time_Per_Item, Record))
MyItem.Slack_Time_After_Last_Operation = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Slack_Time_After_Last_Operation, Record))
MyItem.Slack_Time_Before_Next_Operation = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Slack_Time_Before_Next_Operation, Record))
MyItem.Max_Time_Before_Next_Op = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Max_Time_Before_Next_Op, Record))
MyItem.Interval_Type = Fields.PR.ReadFieldString(Interval_Type, Record)
MyItem.Maximum_Operation_Span_Increase_Percent = Fields.PR.ReadFieldDouble(Maximum_Operation_Span_Increase_Percent, Record)
MyItem.Productivity_Multiplier = Fields.PR.ReadFieldDouble(Productivity_Multiplier, Record)
MyItem.Delivery_Buffer = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Delivery_Buffer, Record))
MyItem.Material_Cost_Per_Item = Fields.PR.ReadFieldDouble(Material_Cost_Per_Item, Record)
MyItem.User_Defined_Operation_Cost = Fields.PR.ReadFieldDouble(User_Defined_Operation_Cost, Record)
MyItem.Notes = Fields.PR.ReadFieldString(Notes, Record)
MyItem.Document = Fields.PR.ReadFieldString(Document, Record)
MyItem.Independent_Lots = Fields.PR.ReadFieldBool(Independent_Lots, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)
MyItem.External_Id = Fields.PR.ReadFieldString(External_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Parent_Part As String
Friend Number As Integer
Friend Part_No As String
Friend Product As String
Friend Profit As Double
Friend Transfer_Quantity As Double
Friend Table_Attribute_1 As String
Friend Table_Attribute_2 As String
Friend Table_Attribute_3 As String
Friend Table_Attribute_4 As String
Friend Table_Attribute_5 As String
Friend String_Attribute_1 As String
Friend String_Attribute_2 As String
Friend String_Attribute_3 As String
Friend String_Attribute_4 As String
Friend String_Attribute_5 As String
Friend Numerical_Attribute_1 As Double
Friend Numerical_Attribute_2 As Double
Friend Numerical_Attribute_3 As Double
Friend Numerical_Attribute_4 As Double
Friend Numerical_Attribute_5 As Double
Friend Date_Attribute_1 As DateTime
Friend Date_Attribute_2 As DateTime
Friend Duration_Attribute_1 As TimeSpan
Friend Duration_Attribute_2 As TimeSpan
Friend Duration_Attribute_3 As TimeSpan
Friend Toggle_Attribute_1 As Boolean
Friend Toggle_Attribute_2 As Boolean
Friend Look_Ahead_Window As TimeSpan
Friend Op_No As Integer
Friend Op_Id As Integer
Friend Operation_Name As String
Friend Operation As String
Friend Resource_Group As String
Friend Required_Resource As String
Friend SMT_Operation As Boolean
Friend SMT_OperationString As String
Friend Revision As String
Friend SMT_Date As DateTime
Friend SMT_Side As String
Friend Constraint_Group_1 As String
Friend Constraint_Group_2 As String
Friend Setup_Time As TimeSpan
Friend Process_Time_Type As String
Friend Rate_Per_Hour_Toggle As Boolean
Friend Time_Per_Item_Toggle As Boolean
Friend Batch_Time_Field_Toggle As Boolean
Friend Resource_Time_Per_Item_Toggle As Boolean
Friend Resource_Rate_Per_Hour_Toggle As Boolean
Friend Resource_Batch_Time_Toggle As Boolean
Friend Op_Time_per_Item As TimeSpan
Friend Batch_Time As TimeSpan
Friend Quantity_per_Hour As Double
Friend Real_Op_Time_Per_Item As TimeSpan
Friend Slack_Time_After_Last_Operation As TimeSpan
Friend Slack_Time_Before_Next_Operation As TimeSpan
Friend Max_Time_Before_Next_Op As TimeSpan
Friend Interval_Type As String
Friend Maximum_Operation_Span_Increase_Percent As Double
Friend Productivity_Multiplier As Double
Friend Delivery_Buffer As TimeSpan
Friend Material_Cost_Per_Item As Double
Friend User_Defined_Operation_Cost As Double
Friend Notes As String
Friend Document As String
Friend Independent_Lots As Boolean
Friend Display_Sequence_Number As Double
Friend External_Id As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Resource_Groups
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Resources As FormatFieldPair
Friend Shared SMT_Resource_Group As FormatFieldPair
Friend Shared SMT_Resource_GroupString As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair
Friend Shared External_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Resource Groups")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Resources = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resources"))
SMT_Resource_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "SMT Resource Group"))
SMT_Resource_GroupString = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "SMT Resource GroupString"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))
External_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.SMT_Resource_Group = Fields.PR.ReadFieldBool(SMT_Resource_Group, Record)
MyItem.SMT_Resource_GroupString = Fields.PR.ReadFieldString(SMT_Resource_GroupString, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)
MyItem.External_Id = Fields.PR.ReadFieldString(External_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend SMT_Resource_Group As Boolean
Friend SMT_Resource_GroupString As String
Friend Display_Sequence_Number As Double
Friend External_Id As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Resources
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Finite_or_Infinite As FormatFieldPair
Friend Shared Finite_Toggle As FormatFieldPair
Friend Shared Infinite_Mode_Behavior As FormatFieldPair
Friend Shared Efficiency_Percent As FormatFieldPair
Friend Shared Apply_Efficiency_to_Setups As FormatFieldPair
Friend Shared Efficiency_Multiplier As FormatFieldPair
Friend Shared Setup_Efficiency_Multiplier As FormatFieldPair
Friend Shared Resource_Window As FormatFieldPair
Friend Shared Graduation_Items As FormatFieldPair
Friend Shared Graduation_Time As FormatFieldPair
Friend Shared Vertical_Bucket_Size As FormatFieldPair
Friend Shared Gantt_Separator As FormatFieldPair
Friend Shared Secondary_Constraints As FormatFieldPair
Friend Shared Constraint_Usage As FormatFieldPair
Friend Shared Constraint_Quantity As FormatFieldPair
Friend Shared Changeover_Group As FormatFieldPair
Friend Shared Concurrent_Setup_Times As FormatFieldPair
Friend Shared Preferred_Sequence As FormatFieldPair
Friend Shared Attribute_1 As FormatFieldPair
Friend Shared Attribute_2 As FormatFieldPair
Friend Shared Attribute_3 As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair
Friend Shared Display_Order As FormatFieldPair
Friend Shared Match_Field As FormatFieldPair
Friend Shared Match_Property As FormatFieldPair
Friend Shared Resource_Display_Options As FormatFieldPair
Friend Shared Resource_Display_Style As FormatFieldPair
Friend Shared Cost_Per_Hour As FormatFieldPair
Friend Shared Use_Cost_Factor_Shift_Multiplier As FormatFieldPair
Friend Shared Exclude_from_Performance_Metrics As FormatFieldPair
Friend Shared Marge_Jalonnement As FormatFieldPair
Friend Shared External_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Resources")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Finite_or_Infinite = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Finite or Infinite"))
Finite_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Finite Toggle"))
Infinite_Mode_Behavior = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Infinite Mode Behavior"))
Efficiency_Percent = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Efficiency %"))
Apply_Efficiency_to_Setups = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Apply Efficiency to Setups?"))
Efficiency_Multiplier = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Efficiency Multiplier"))
Setup_Efficiency_Multiplier = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Setup Efficiency Multiplier"))
Resource_Window = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Window"))
Graduation_Items = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Graduation Items"))
Graduation_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Graduation Time"))
Vertical_Bucket_Size = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Vertical Bucket Size"))
Gantt_Separator = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Gantt Separator"))
Secondary_Constraints = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Secondary Constraints"))
Constraint_Usage = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Usage"))
Constraint_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Quantity"))
Changeover_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Changeover Group"))
Concurrent_Setup_Times = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Concurrent Setup Times"))
Preferred_Sequence = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Preferred Sequence"))
Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 1"))
Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 2"))
Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 3"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))
Display_Order = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Order"))
Match_Field = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Match Field"))
Match_Property = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Match Property"))
Resource_Display_Options = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Display Options"))
Resource_Display_Style = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Display Style"))
Cost_Per_Hour = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Cost Per Hour"))
Use_Cost_Factor_Shift_Multiplier = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Use Cost Factor Shift Multiplier?"))
Exclude_from_Performance_Metrics = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Exclude from Performance Metrics"))
Marge_Jalonnement = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Marge Jalonnement"))
External_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Finite_or_Infinite = Fields.PR.ReadFieldString(Finite_or_Infinite, Record)
MyItem.Finite_Toggle = Fields.PR.ReadFieldBool(Finite_Toggle, Record)
MyItem.Infinite_Mode_Behavior = Fields.PR.ReadFieldString(Infinite_Mode_Behavior, Record)
MyItem.Efficiency_Percent = Fields.PR.ReadFieldDouble(Efficiency_Percent, Record)
MyItem.Apply_Efficiency_to_Setups = Fields.PR.ReadFieldBool(Apply_Efficiency_to_Setups, Record)
MyItem.Efficiency_Multiplier = Fields.PR.ReadFieldDouble(Efficiency_Multiplier, Record)
MyItem.Setup_Efficiency_Multiplier = Fields.PR.ReadFieldDouble(Setup_Efficiency_Multiplier, Record)
MyItem.Resource_Window = Fields.PR.ReadFieldString(Resource_Window, Record)
MyItem.Graduation_Items = Fields.PR.ReadFieldString(Graduation_Items, Record)
MyItem.Graduation_Time = Fields.PR.ReadFieldInt(Graduation_Time, Record)
MyItem.Vertical_Bucket_Size = Fields.PR.ReadFieldInt(Vertical_Bucket_Size, Record)
MyItem.Gantt_Separator = Fields.PR.ReadFieldBool(Gantt_Separator, Record)
MyItem.Changeover_Group = Fields.PR.ReadFieldString(Changeover_Group, Record)
MyItem.Concurrent_Setup_Times = Fields.PR.ReadFieldBool(Concurrent_Setup_Times, Record)
MyItem.Attribute_1 = Fields.PR.ReadFieldString(Attribute_1, Record)
MyItem.Attribute_2 = Fields.PR.ReadFieldDouble(Attribute_2, Record)
MyItem.Attribute_3 = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Attribute_3, Record))
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)
MyItem.Display_Order = Fields.PR.ReadFieldDouble(Display_Order, Record)
MyItem.Match_Field = Fields.PR.ReadFieldString(Match_Field, Record)
MyItem.Match_Property = Fields.PR.ReadFieldInt(Match_Property, Record)
MyItem.Resource_Display_Options = Fields.PR.ReadFieldString(Resource_Display_Options, Record)
MyItem.Resource_Display_Style = Fields.PR.ReadFieldString(Resource_Display_Style, Record)
MyItem.Cost_Per_Hour = Fields.PR.ReadFieldDouble(Cost_Per_Hour, Record)
MyItem.Use_Cost_Factor_Shift_Multiplier = Fields.PR.ReadFieldBool(Use_Cost_Factor_Shift_Multiplier, Record)
MyItem.Exclude_from_Performance_Metrics = Fields.PR.ReadFieldBool(Exclude_from_Performance_Metrics, Record)
MyItem.Marge_Jalonnement = Fields.PR.ReadFieldDouble(Marge_Jalonnement, Record)
MyItem.External_Id = Fields.PR.ReadFieldString(External_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Finite_or_Infinite As String
Friend Finite_Toggle As Boolean
Friend Infinite_Mode_Behavior As String
Friend Efficiency_Percent As Double
Friend Apply_Efficiency_to_Setups As Boolean
Friend Efficiency_Multiplier As Double
Friend Setup_Efficiency_Multiplier As Double
Friend Resource_Window As String
Friend Graduation_Items As String
Friend Graduation_Time As Integer
Friend Vertical_Bucket_Size As Integer
Friend Gantt_Separator As Boolean
Friend Changeover_Group As String
Friend Concurrent_Setup_Times As Boolean
Friend Attribute_1 As String
Friend Attribute_2 As Double
Friend Attribute_3 As TimeSpan
Friend Display_Sequence_Number As Double
Friend Display_Order As Double
Friend Match_Field As String
Friend Match_Property As Integer
Friend Resource_Display_Options As String
Friend Resource_Display_Style As String
Friend Cost_Per_Hour As Double
Friend Use_Cost_Factor_Shift_Multiplier As Boolean
Friend Exclude_from_Performance_Metrics As Boolean
Friend Marge_Jalonnement As Double
Friend External_Id As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Secondary_Constraints
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Use_as_a_Constraint As FormatFieldPair
Friend Shared Calendar_Effect As FormatFieldPair
Friend Shared Alternate_Use_as_a_Constraint As FormatFieldPair
Friend Shared Alternate_Calendar_Effect As FormatFieldPair
Friend Shared Plot_Color As FormatFieldPair
Friend Shared Plot_Fill_Pattern As FormatFieldPair
Friend Shared Max_Value_Color As FormatFieldPair
Friend Shared Min_Value_Color As FormatFieldPair
Friend Shared Attribute_1 As FormatFieldPair
Friend Shared Attribute_2 As FormatFieldPair
Friend Shared Attribute_3 As FormatFieldPair
Friend Shared Cost_Per_Hour As FormatFieldPair
Friend Shared Use_Cost_Factor_Shift_Multiplier As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair
Friend Shared External_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Secondary Constraints")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Use_as_a_Constraint = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Use as a Constraint"))
Calendar_Effect = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Calendar Effect"))
Alternate_Use_as_a_Constraint = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Alternate Use as a Constraint"))
Alternate_Calendar_Effect = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Alternate Calendar Effect"))
Plot_Color = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Plot Color"))
Plot_Fill_Pattern = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Plot Fill Pattern"))
Max_Value_Color = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Max. Value Color"))
Min_Value_Color = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Min. Value Color"))
Attribute_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 1"))
Attribute_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 2"))
Attribute_3 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 3"))
Cost_Per_Hour = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Cost Per Hour"))
Use_Cost_Factor_Shift_Multiplier = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Use Cost Factor Shift Multiplier?"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))
External_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Use_as_a_Constraint = Fields.PR.ReadFieldBool(Use_as_a_Constraint, Record)
MyItem.Calendar_Effect = Fields.PR.ReadFieldString(Calendar_Effect, Record)
MyItem.Alternate_Use_as_a_Constraint = Fields.PR.ReadFieldBool(Alternate_Use_as_a_Constraint, Record)
MyItem.Alternate_Calendar_Effect = Fields.PR.ReadFieldString(Alternate_Calendar_Effect, Record)
MyItem.Plot_Color = Fields.PR.ReadFieldString(Plot_Color, Record)
MyItem.Plot_Fill_Pattern = Fields.PR.ReadFieldString(Plot_Fill_Pattern, Record)
MyItem.Max_Value_Color = Fields.PR.ReadFieldString(Max_Value_Color, Record)
MyItem.Min_Value_Color = Fields.PR.ReadFieldString(Min_Value_Color, Record)
MyItem.Attribute_1 = Fields.PR.ReadFieldString(Attribute_1, Record)
MyItem.Attribute_2 = Fields.PR.ReadFieldDouble(Attribute_2, Record)
MyItem.Attribute_3 = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Attribute_3, Record))
MyItem.Cost_Per_Hour = Fields.PR.ReadFieldDouble(Cost_Per_Hour, Record)
MyItem.Use_Cost_Factor_Shift_Multiplier = Fields.PR.ReadFieldBool(Use_Cost_Factor_Shift_Multiplier, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)
MyItem.External_Id = Fields.PR.ReadFieldString(External_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Use_as_a_Constraint As Boolean
Friend Calendar_Effect As String
Friend Alternate_Use_as_a_Constraint As Boolean
Friend Alternate_Calendar_Effect As String
Friend Plot_Color As String
Friend Plot_Fill_Pattern As String
Friend Max_Value_Color As String
Friend Min_Value_Color As String
Friend Attribute_1 As String
Friend Attribute_2 As Double
Friend Attribute_3 As TimeSpan
Friend Cost_Per_Hour As Double
Friend Use_Cost_Factor_Shift_Multiplier As Boolean
Friend Display_Sequence_Number As Double
Friend External_Id As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Secondary_Constraint_Groups
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Secondary_Constraints As FormatFieldPair
Friend Shared Constraint_Usage As FormatFieldPair
Friend Shared Constraint_Quantity As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Secondary Constraint Groups")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Secondary_Constraints = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Secondary Constraints"))
Constraint_Usage = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Usage"))
Constraint_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Quantity"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Order_Status
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Order_Status_Name As FormatFieldPair
Friend Shared Description As FormatFieldPair
Friend Shared Rank As FormatFieldPair
Friend Shared Spare_String_Field_1 As FormatFieldPair
Friend Shared Spare_String_Field_2 As FormatFieldPair
Friend Shared Spare_Number_Field As FormatFieldPair
Friend Shared Color As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair
Friend Shared External_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Order Status")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Order_Status_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Status Name"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))
Rank = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Rank"))
Spare_String_Field_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 1"))
Spare_String_Field_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 2"))
Spare_Number_Field = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare Number Field"))
Color = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Color"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))
External_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Order_Status_Name = Fields.PR.ReadFieldString(Order_Status_Name, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)
MyItem.Rank = Fields.PR.ReadFieldInt(Rank, Record)
MyItem.Spare_String_Field_1 = Fields.PR.ReadFieldString(Spare_String_Field_1, Record)
MyItem.Spare_String_Field_2 = Fields.PR.ReadFieldString(Spare_String_Field_2, Record)
MyItem.Spare_Number_Field = Fields.PR.ReadFieldDouble(Spare_Number_Field, Record)
MyItem.Color = Fields.PR.ReadFieldDouble(Color, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)
MyItem.External_Id = Fields.PR.ReadFieldString(External_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Order_Status_Name As String
Friend Description As String
Friend Rank As Integer
Friend Spare_String_Field_1 As String
Friend Spare_String_Field_2 As String
Friend Spare_Number_Field As Double
Friend Color As Double
Friend Display_Sequence_Number As Double
Friend External_Id As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Attribute_1
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Rank As FormatFieldPair
Friend Shared Secondary_Constraints As FormatFieldPair
Friend Shared Constraint_Usage As FormatFieldPair
Friend Shared Constraint_Quantity As FormatFieldPair
Friend Shared Valid_Resources As FormatFieldPair
Friend Shared Spare_String_Field_1 As FormatFieldPair
Friend Shared Spare_String_Field_2 As FormatFieldPair
Friend Shared Spare_Number_Field As FormatFieldPair
Friend Shared Color As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair
Friend Shared External_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Attribute 1")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Rank = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Rank"))
Secondary_Constraints = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Secondary Constraints"))
Constraint_Usage = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Usage"))
Constraint_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Quantity"))
Valid_Resources = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Valid Resources"))
Spare_String_Field_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 1"))
Spare_String_Field_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 2"))
Spare_Number_Field = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare Number Field"))
Color = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Color"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))
External_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Rank = Fields.PR.ReadFieldInt(Rank, Record)
MyItem.Spare_String_Field_1 = Fields.PR.ReadFieldString(Spare_String_Field_1, Record)
MyItem.Spare_String_Field_2 = Fields.PR.ReadFieldString(Spare_String_Field_2, Record)
MyItem.Spare_Number_Field = Fields.PR.ReadFieldDouble(Spare_Number_Field, Record)
MyItem.Color = Fields.PR.ReadFieldDouble(Color, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)
MyItem.External_Id = Fields.PR.ReadFieldString(External_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Rank As Integer
Friend Spare_String_Field_1 As String
Friend Spare_String_Field_2 As String
Friend Spare_Number_Field As Double
Friend Color As Double
Friend Display_Sequence_Number As Double
Friend External_Id As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Attribute_2
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Rank As FormatFieldPair
Friend Shared Secondary_Constraints As FormatFieldPair
Friend Shared Constraint_Usage As FormatFieldPair
Friend Shared Constraint_Quantity As FormatFieldPair
Friend Shared Valid_Resources As FormatFieldPair
Friend Shared Spare_String_Field_1 As FormatFieldPair
Friend Shared Spare_String_Field_2 As FormatFieldPair
Friend Shared Spare_Number_Field As FormatFieldPair
Friend Shared Color As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair
Friend Shared External_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Attribute 2")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Rank = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Rank"))
Secondary_Constraints = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Secondary Constraints"))
Constraint_Usage = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Usage"))
Constraint_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Quantity"))
Valid_Resources = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Valid Resources"))
Spare_String_Field_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 1"))
Spare_String_Field_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 2"))
Spare_Number_Field = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare Number Field"))
Color = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Color"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))
External_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Rank = Fields.PR.ReadFieldInt(Rank, Record)
MyItem.Spare_String_Field_1 = Fields.PR.ReadFieldString(Spare_String_Field_1, Record)
MyItem.Spare_String_Field_2 = Fields.PR.ReadFieldString(Spare_String_Field_2, Record)
MyItem.Spare_Number_Field = Fields.PR.ReadFieldDouble(Spare_Number_Field, Record)
MyItem.Color = Fields.PR.ReadFieldDouble(Color, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)
MyItem.External_Id = Fields.PR.ReadFieldString(External_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Rank As Integer
Friend Spare_String_Field_1 As String
Friend Spare_String_Field_2 As String
Friend Spare_Number_Field As Double
Friend Color As Double
Friend Display_Sequence_Number As Double
Friend External_Id As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Attribute_3
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Rank As FormatFieldPair
Friend Shared Secondary_Constraints As FormatFieldPair
Friend Shared Constraint_Usage As FormatFieldPair
Friend Shared Constraint_Quantity As FormatFieldPair
Friend Shared Valid_Resources As FormatFieldPair
Friend Shared Spare_String_Field_1 As FormatFieldPair
Friend Shared Spare_String_Field_2 As FormatFieldPair
Friend Shared Spare_Number_Field As FormatFieldPair
Friend Shared Color As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair
Friend Shared External_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Attribute 3")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Rank = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Rank"))
Secondary_Constraints = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Secondary Constraints"))
Constraint_Usage = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Usage"))
Constraint_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Quantity"))
Valid_Resources = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Valid Resources"))
Spare_String_Field_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 1"))
Spare_String_Field_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 2"))
Spare_Number_Field = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare Number Field"))
Color = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Color"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))
External_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Rank = Fields.PR.ReadFieldInt(Rank, Record)
MyItem.Spare_String_Field_1 = Fields.PR.ReadFieldString(Spare_String_Field_1, Record)
MyItem.Spare_String_Field_2 = Fields.PR.ReadFieldString(Spare_String_Field_2, Record)
MyItem.Spare_Number_Field = Fields.PR.ReadFieldDouble(Spare_Number_Field, Record)
MyItem.Color = Fields.PR.ReadFieldDouble(Color, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)
MyItem.External_Id = Fields.PR.ReadFieldString(External_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Rank As Integer
Friend Spare_String_Field_1 As String
Friend Spare_String_Field_2 As String
Friend Spare_Number_Field As Double
Friend Color As Double
Friend Display_Sequence_Number As Double
Friend External_Id As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Attribute_4
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Rank As FormatFieldPair
Friend Shared Secondary_Constraints As FormatFieldPair
Friend Shared Constraint_Usage As FormatFieldPair
Friend Shared Constraint_Quantity As FormatFieldPair
Friend Shared Valid_Resources As FormatFieldPair
Friend Shared Spare_String_Field_1 As FormatFieldPair
Friend Shared Spare_String_Field_2 As FormatFieldPair
Friend Shared Spare_Number_Field As FormatFieldPair
Friend Shared Color As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair
Friend Shared External_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Attribute 4")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Rank = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Rank"))
Secondary_Constraints = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Secondary Constraints"))
Constraint_Usage = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Usage"))
Constraint_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Quantity"))
Valid_Resources = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Valid Resources"))
Spare_String_Field_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 1"))
Spare_String_Field_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 2"))
Spare_Number_Field = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare Number Field"))
Color = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Color"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))
External_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Rank = Fields.PR.ReadFieldInt(Rank, Record)
MyItem.Spare_String_Field_1 = Fields.PR.ReadFieldString(Spare_String_Field_1, Record)
MyItem.Spare_String_Field_2 = Fields.PR.ReadFieldString(Spare_String_Field_2, Record)
MyItem.Spare_Number_Field = Fields.PR.ReadFieldDouble(Spare_Number_Field, Record)
MyItem.Color = Fields.PR.ReadFieldDouble(Color, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)
MyItem.External_Id = Fields.PR.ReadFieldString(External_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Rank As Integer
Friend Spare_String_Field_1 As String
Friend Spare_String_Field_2 As String
Friend Spare_Number_Field As Double
Friend Color As Double
Friend Display_Sequence_Number As Double
Friend External_Id As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Attribute_5
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Rank As FormatFieldPair
Friend Shared Secondary_Constraints As FormatFieldPair
Friend Shared Constraint_Usage As FormatFieldPair
Friend Shared Constraint_Quantity As FormatFieldPair
Friend Shared Valid_Resources As FormatFieldPair
Friend Shared Spare_String_Field_1 As FormatFieldPair
Friend Shared Spare_String_Field_2 As FormatFieldPair
Friend Shared Spare_Number_Field As FormatFieldPair
Friend Shared Color As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair
Friend Shared External_Id As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Attribute 5")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Rank = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Rank"))
Secondary_Constraints = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Secondary Constraints"))
Constraint_Usage = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Usage"))
Constraint_Quantity = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Constraint Quantity"))
Valid_Resources = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Valid Resources"))
Spare_String_Field_1 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 1"))
Spare_String_Field_2 = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare String Field 2"))
Spare_Number_Field = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Spare Number Field"))
Color = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Color"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))
External_Id = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "External Id"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Rank = Fields.PR.ReadFieldInt(Rank, Record)
MyItem.Spare_String_Field_1 = Fields.PR.ReadFieldString(Spare_String_Field_1, Record)
MyItem.Spare_String_Field_2 = Fields.PR.ReadFieldString(Spare_String_Field_2, Record)
MyItem.Spare_Number_Field = Fields.PR.ReadFieldDouble(Spare_Number_Field, Record)
MyItem.Color = Fields.PR.ReadFieldDouble(Color, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)
MyItem.External_Id = Fields.PR.ReadFieldString(External_Id, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Rank As Integer
Friend Spare_String_Field_1 As String
Friend Spare_String_Field_2 As String
Friend Spare_Number_Field As Double
Friend Color As Double
Friend Display_Sequence_Number As Double
Friend External_Id As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Sequencer_Configuration
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Historical_Planning_Horizon__Days_ As FormatFieldPair
Friend Shared Future_Planning_Horizon__Days_ As FormatFieldPair
Friend Shared Sequence_Overview_Mode As FormatFieldPair
Friend Shared OverviewMode As FormatFieldPair
Friend Shared Overview_Toggle As FormatFieldPair
Friend Shared Gantt_Start_Offset__Days_ As FormatFieldPair
Friend Shared Gantt_End_Offset__Days_ As FormatFieldPair
Friend Shared Set_Sequencer_Operation_Thumb As FormatFieldPair
Friend Shared Default_Earliest_Start_Date_Offset As FormatFieldPair
Friend Shared Default_Due_Date_Offset As FormatFieldPair
Friend Shared Default_Terminator_Offset As FormatFieldPair
Friend Shared Default_Start_Offset As FormatFieldPair
Friend Shared APS_Event_Script As FormatFieldPair
Friend Shared Calculate_Cost As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Sequencer Configuration")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Historical_Planning_Horizon__Days_ = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Historical Planning Horizon (Days)"))
Future_Planning_Horizon__Days_ = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Future Planning Horizon (Days)"))
Sequence_Overview_Mode = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Sequence Overview Mode"))
OverviewMode = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "OverviewMode"))
Overview_Toggle = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Overview Toggle"))
Gantt_Start_Offset__Days_ = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Gantt Start Offset [Days]"))
Gantt_End_Offset__Days_ = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Gantt End Offset [Days]"))
Set_Sequencer_Operation_Thumb = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Set Sequencer Operation Thumb"))
Default_Earliest_Start_Date_Offset = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Default Earliest Start Date Offset"))
Default_Due_Date_Offset = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Default Due Date Offset"))
Default_Terminator_Offset = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Default Terminator Offset"))
Default_Start_Offset = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Default Start Offset"))
APS_Event_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "APS Event Script"))
Calculate_Cost = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Calculate Cost"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Historical_Planning_Horizon__Days_ = Fields.PR.ReadFieldInt(Historical_Planning_Horizon__Days_, Record)
MyItem.Future_Planning_Horizon__Days_ = Fields.PR.ReadFieldInt(Future_Planning_Horizon__Days_, Record)
MyItem.Sequence_Overview_Mode = Fields.PR.ReadFieldString(Sequence_Overview_Mode, Record)
MyItem.OverviewMode = Fields.PR.ReadFieldString(OverviewMode, Record)
MyItem.Overview_Toggle = Fields.PR.ReadFieldBool(Overview_Toggle, Record)
MyItem.Gantt_Start_Offset__Days_ = Fields.PR.ReadFieldDouble(Gantt_Start_Offset__Days_, Record)
MyItem.Gantt_End_Offset__Days_ = Fields.PR.ReadFieldDouble(Gantt_End_Offset__Days_, Record)
MyItem.Set_Sequencer_Operation_Thumb = Fields.PR.ReadFieldBool(Set_Sequencer_Operation_Thumb, Record)
MyItem.Default_Earliest_Start_Date_Offset = Fields.PR.ReadFieldInt(Default_Earliest_Start_Date_Offset, Record)
MyItem.Default_Due_Date_Offset = Fields.PR.ReadFieldInt(Default_Due_Date_Offset, Record)
MyItem.Default_Terminator_Offset = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Default_Terminator_Offset, Record))
MyItem.Default_Start_Offset = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Default_Start_Offset, Record))
MyItem.APS_Event_Script = Fields.PR.ReadFieldString(APS_Event_Script, Record)
MyItem.Calculate_Cost = Fields.PR.ReadFieldString(Calculate_Cost, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Historical_Planning_Horizon__Days_ As Integer
Friend Future_Planning_Horizon__Days_ As Integer
Friend Sequence_Overview_Mode As String
Friend OverviewMode As String
Friend Overview_Toggle As Boolean
Friend Gantt_Start_Offset__Days_ As Double
Friend Gantt_End_Offset__Days_ As Double
Friend Set_Sequencer_Operation_Thumb As Boolean
Friend Default_Earliest_Start_Date_Offset As Integer
Friend Default_Due_Date_Offset As Integer
Friend Default_Terminator_Offset As TimeSpan
Friend Default_Start_Offset As TimeSpan
Friend APS_Event_Script As String
Friend Calculate_Cost As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Import_Export_Mapping
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Order_Import_Event_Script As FormatFieldPair
Friend Shared Order_Export_Event_Script As FormatFieldPair
Friend Shared Release_Schedule_Event_Script As FormatFieldPair
Friend Shared Resources_Import_Event_Script As FormatFieldPair
Friend Shared Resources_Export_Event_Script As FormatFieldPair
Friend Shared Example_Import_Event_Script As FormatFieldPair
Friend Shared Example_Export_Event_Script As FormatFieldPair
Friend Shared Select_Default_Order_Import_Script As FormatFieldPair
Friend Shared Select_Default_Order_Export_Script As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Import Export Mapping")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Order_Import_Event_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Import Event Script"))
Order_Export_Event_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Order Export Event Script"))
Release_Schedule_Event_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Release Schedule Event Script"))
Resources_Import_Event_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resources Import Event Script"))
Resources_Export_Event_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resources Export Event Script"))
Example_Import_Event_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Example Import Event Script"))
Example_Export_Event_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Example Export Event Script"))
Select_Default_Order_Import_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Select Default Order Import Script"))
Select_Default_Order_Export_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Select Default Order Export Script"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Order_Import_Event_Script = Fields.PR.ReadFieldString(Order_Import_Event_Script, Record)
MyItem.Order_Export_Event_Script = Fields.PR.ReadFieldString(Order_Export_Event_Script, Record)
MyItem.Release_Schedule_Event_Script = Fields.PR.ReadFieldString(Release_Schedule_Event_Script, Record)
MyItem.Resources_Import_Event_Script = Fields.PR.ReadFieldString(Resources_Import_Event_Script, Record)
MyItem.Resources_Export_Event_Script = Fields.PR.ReadFieldString(Resources_Export_Event_Script, Record)
MyItem.Example_Import_Event_Script = Fields.PR.ReadFieldString(Example_Import_Event_Script, Record)
MyItem.Example_Export_Event_Script = Fields.PR.ReadFieldString(Example_Export_Event_Script, Record)
MyItem.Select_Default_Order_Import_Script = Fields.PR.ReadFieldString(Select_Default_Order_Import_Script, Record)
MyItem.Select_Default_Order_Export_Script = Fields.PR.ReadFieldString(Select_Default_Order_Export_Script, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Order_Import_Event_Script As String
Friend Order_Export_Event_Script As String
Friend Release_Schedule_Event_Script As String
Friend Resources_Import_Event_Script As String
Friend Resources_Export_Event_Script As String
Friend Example_Import_Event_Script As String
Friend Example_Export_Event_Script As String
Friend Select_Default_Order_Import_Script As String
Friend Select_Default_Order_Export_Script As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Data_Transfer_Mapping
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Enabled As FormatFieldPair
Friend Shared Button_Text As FormatFieldPair
Friend Shared Event_Script As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Data Transfer Mapping")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Enabled = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Enabled"))
Button_Text = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Button Text"))
Event_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Event Script"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Enabled = Fields.PR.ReadFieldBool(Enabled, Record)
MyItem.Button_Text = Fields.PR.ReadFieldString(Button_Text, Record)
MyItem.Event_Script = Fields.PR.ReadFieldString(Event_Script, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Enabled As Boolean
Friend Button_Text As String
Friend Event_Script As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Menu_Button_Mapping
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Enabled As FormatFieldPair
Friend Shared Button_Text As FormatFieldPair
Friend Shared Event_Script As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Menu Button Mapping")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Enabled = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Enabled"))
Button_Text = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Button Text"))
Event_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Event Script"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Enabled = Fields.PR.ReadFieldBool(Enabled, Record)
MyItem.Button_Text = Fields.PR.ReadFieldString(Button_Text, Record)
MyItem.Event_Script = Fields.PR.ReadFieldString(Event_Script, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Enabled As Boolean
Friend Button_Text As String
Friend Event_Script As String
Friend Display_Sequence_Number As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Workspace_Files
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Description As FormatFieldPair
Friend Shared File_Name As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Workspace Files")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Description = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Description"))
File_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "File Name"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Description = Fields.PR.ReadFieldString(Description, Record)
MyItem.File_Name = Fields.PR.ReadFieldString(File_Name, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Description As String
Friend File_Name As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_APS_Rules_Dialog
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared APS_Rule As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("APS Rules Dialog")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
APS_Rule = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "APS Rule"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.APS_Rule = Fields.PR.ReadFieldString(APS_Rule, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend APS_Rule As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Bottleneck_Selection
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared By_Group As FormatFieldPair
Friend Shared Resource As FormatFieldPair
Friend Shared Resource_Group As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Bottleneck Selection")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
By_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "By Group"))
Resource = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource"))
Resource_Group = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Resource Group"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.By_Group = Fields.PR.ReadFieldBool(By_Group, Record)
MyItem.Resource = Fields.PR.ReadFieldString(Resource, Record)
MyItem.Resource_Group = Fields.PR.ReadFieldString(Resource_Group, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend By_Group As Boolean
Friend Resource As String
Friend Resource_Group As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Preferred_Sequence_Dialog
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Look_Ahead_Window As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Preferred Sequence Dialog")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Look_Ahead_Window = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Look Ahead Window"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Look_Ahead_Window = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Look_Ahead_Window, Record))

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Look_Ahead_Window As TimeSpan
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Minimize_Setup_Dialog
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Look_Ahead_Window As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Minimize Setup Dialog")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Look_Ahead_Window = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Look Ahead Window"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Look_Ahead_Window = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Look_Ahead_Window, Record))

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Look_Ahead_Window As TimeSpan
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Campaigning_Rule_Dialog
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Reference_Date As FormatFieldPair
Friend Shared Campaign_Period As FormatFieldPair
Friend Shared Number_of_Campaigns As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Campaigning Rule Dialog")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Reference_Date = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Reference Date"))
Campaign_Period = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Campaign Period"))
Number_of_Campaigns = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number of Campaigns"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Reference_Date = Fields.PR.ReadFieldDatetime(Reference_Date, Record)
MyItem.Campaign_Period = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Campaign_Period, Record))
MyItem.Number_of_Campaigns = Fields.PR.ReadFieldInt(Number_of_Campaigns, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Reference_Date As DateTime
Friend Campaign_Period As TimeSpan
Friend Number_of_Campaigns As Integer
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Demand_Status
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Grouping_Color As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Demand Status")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Grouping_Color = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Grouping Color"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Grouping_Color = Fields.PR.ReadFieldDouble(Grouping_Color, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Grouping_Color As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Changeover_Groups
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared Name As FormatFieldPair
Friend Shared Attribute_1_Changeover_Time As FormatFieldPair
Friend Shared Attribute_1_Changeover_Matrix As FormatFieldPair
Friend Shared Attribute_2_Changeover_Time As FormatFieldPair
Friend Shared Attribute_2_Changeover_Matrix As FormatFieldPair
Friend Shared Attribute_3_Changeover_Time As FormatFieldPair
Friend Shared Attribute_3_Changeover_Matrix As FormatFieldPair
Friend Shared Attribute_4_Changeover_Time As FormatFieldPair
Friend Shared Attribute_4_Changeover_Matrix As FormatFieldPair
Friend Shared Attribute_5_Changeover_Time As FormatFieldPair
Friend Shared Attribute_5_Changeover_Matrix As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Changeover Groups")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Name"))
Attribute_1_Changeover_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 1 Changeover Time"))
Attribute_1_Changeover_Matrix = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 1 Changeover Matrix"))
Attribute_2_Changeover_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 2 Changeover Time"))
Attribute_2_Changeover_Matrix = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 2 Changeover Matrix"))
Attribute_3_Changeover_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 3 Changeover Time"))
Attribute_3_Changeover_Matrix = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 3 Changeover Matrix"))
Attribute_4_Changeover_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 4 Changeover Time"))
Attribute_4_Changeover_Matrix = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 4 Changeover Matrix"))
Attribute_5_Changeover_Time = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 5 Changeover Time"))
Attribute_5_Changeover_Matrix = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Attribute 5 Changeover Matrix"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.Name = Fields.PR.ReadFieldString(Name, Record)
MyItem.Attribute_1_Changeover_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Attribute_1_Changeover_Time, Record))
MyItem.Attribute_2_Changeover_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Attribute_2_Changeover_Time, Record))
MyItem.Attribute_3_Changeover_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Attribute_3_Changeover_Time, Record))
MyItem.Attribute_4_Changeover_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Attribute_4_Changeover_Time, Record))
MyItem.Attribute_5_Changeover_Time = TimeSpan.FromDays(Fields.PR.ReadFieldDouble(Attribute_5_Changeover_Time, Record))
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend Name As String
Friend Attribute_1_Changeover_Time As TimeSpan
Friend Attribute_2_Changeover_Time As TimeSpan
Friend Attribute_3_Changeover_Time As TimeSpan
Friend Attribute_4_Changeover_Time As TimeSpan
Friend Attribute_5_Changeover_Time As TimeSpan
Friend Display_Sequence_Number As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Tool_Configuration
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Number As FormatFieldPair
Friend Shared User_Tool_1_Name As FormatFieldPair
Friend Shared User_Tool_1_Script As FormatFieldPair
Friend Shared User_Tool_2_Name As FormatFieldPair
Friend Shared User_Tool_2_Script As FormatFieldPair
Friend Shared User_Tool_3_Name As FormatFieldPair
Friend Shared User_Tool_3_Script As FormatFieldPair
Friend Shared User_Tool_4_Name As FormatFieldPair
Friend Shared User_Tool_4_Script As FormatFieldPair
Friend Shared User_Window_Name As FormatFieldPair
Friend Shared User_Window_Function As FormatFieldPair
Friend Shared User_Window_Label As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Tool Configuration")

Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Number"))
User_Tool_1_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Tool 1 Name"))
User_Tool_1_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Tool 1 Script"))
User_Tool_2_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Tool 2 Name"))
User_Tool_2_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Tool 2 Script"))
User_Tool_3_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Tool 3 Name"))
User_Tool_3_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Tool 3 Script"))
User_Tool_4_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Tool 4 Name"))
User_Tool_4_Script = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Tool 4 Script"))
User_Window_Name = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Window Name"))
User_Window_Function = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Window Function"))
User_Window_Label = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "User Window Label"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Number = Fields.PR.ReadFieldInt(Number, Record)
MyItem.User_Tool_1_Name = Fields.PR.ReadFieldString(User_Tool_1_Name, Record)
MyItem.User_Tool_1_Script = Fields.PR.ReadFieldString(User_Tool_1_Script, Record)
MyItem.User_Tool_2_Name = Fields.PR.ReadFieldString(User_Tool_2_Name, Record)
MyItem.User_Tool_2_Script = Fields.PR.ReadFieldString(User_Tool_2_Script, Record)
MyItem.User_Tool_3_Name = Fields.PR.ReadFieldString(User_Tool_3_Name, Record)
MyItem.User_Tool_3_Script = Fields.PR.ReadFieldString(User_Tool_3_Script, Record)
MyItem.User_Tool_4_Name = Fields.PR.ReadFieldString(User_Tool_4_Name, Record)
MyItem.User_Tool_4_Script = Fields.PR.ReadFieldString(User_Tool_4_Script, Record)
MyItem.User_Window_Name = Fields.PR.ReadFieldString(User_Window_Name, Record)
MyItem.User_Window_Function = Fields.PR.ReadFieldString(User_Window_Function, Record)
MyItem.User_Window_Label = Fields.PR.ReadFieldString(User_Window_Label, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Number As Integer
Friend User_Tool_1_Name As String
Friend User_Tool_1_Script As String
Friend User_Tool_2_Name As String
Friend User_Tool_2_Script As String
Friend User_Tool_3_Name As String
Friend User_Tool_3_Script As String
Friend User_Tool_4_Name As String
Friend User_Tool_4_Script As String
Friend User_Window_Name As String
Friend User_Window_Function As String
Friend User_Window_Label As String
Friend Display_Sequence_Number As Double
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Chemins
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Numero As FormatFieldPair
Friend Shared Display_Sequence_Number As FormatFieldPair
Friend Shared Repertoire_des_fichiers_dimportation As FormatFieldPair
Friend Shared Fichier_des_Commandes As FormatFieldPair
Friend Shared Fichier_des_OFs_Previsionnels As FormatFieldPair
Friend Shared Fichier_des_OFs_Fermes As FormatFieldPair
Friend Shared Fichier_des_Outils As FormatFieldPair
Friend Shared Fichier_des_Nomenclatures_OF As FormatFieldPair
Friend Shared Fichier_des_Stocks As FormatFieldPair
Friend Shared Fichier_des_postes_de_charges As FormatFieldPair
Friend Shared Fichier_des_calendriers As FormatFieldPair
Friend Shared Repertoire_du_fichier_OFxml As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Chemins")

Numero = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Numero"))
Display_Sequence_Number = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Display Sequence Number"))
Repertoire_des_fichiers_dimportation = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Repertoire des fichiers d'importation"))
Fichier_des_Commandes = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Fichier des Commandes"))
Fichier_des_OFs_Previsionnels = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Fichier des OFs Previsionnels"))
Fichier_des_OFs_Fermes = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Fichier des OFs Fermes"))
Fichier_des_Outils = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Fichier des Outils"))
Fichier_des_Nomenclatures_OF = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Fichier des Nomenclatures OF"))
Fichier_des_Stocks = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Fichier des Stocks"))
Fichier_des_postes_de_charges = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Fichier des postes de charges"))
Fichier_des_calendriers = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Fichier des calendriers"))
Repertoire_du_fichier_OFxml = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Repertoire du fichier OF.xml"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Numero = Fields.PR.ReadFieldInt(Numero, Record)
MyItem.Display_Sequence_Number = Fields.PR.ReadFieldDouble(Display_Sequence_Number, Record)
MyItem.Repertoire_des_fichiers_dimportation = Fields.PR.ReadFieldString(Repertoire_des_fichiers_dimportation, Record)
MyItem.Fichier_des_Commandes = Fields.PR.ReadFieldString(Fichier_des_Commandes, Record)
MyItem.Fichier_des_OFs_Previsionnels = Fields.PR.ReadFieldString(Fichier_des_OFs_Previsionnels, Record)
MyItem.Fichier_des_OFs_Fermes = Fields.PR.ReadFieldString(Fichier_des_OFs_Fermes, Record)
MyItem.Fichier_des_Outils = Fields.PR.ReadFieldString(Fichier_des_Outils, Record)
MyItem.Fichier_des_Nomenclatures_OF = Fields.PR.ReadFieldString(Fichier_des_Nomenclatures_OF, Record)
MyItem.Fichier_des_Stocks = Fields.PR.ReadFieldString(Fichier_des_Stocks, Record)
MyItem.Fichier_des_postes_de_charges = Fields.PR.ReadFieldString(Fichier_des_postes_de_charges, Record)
MyItem.Fichier_des_calendriers = Fields.PR.ReadFieldString(Fichier_des_calendriers, Record)
MyItem.Repertoire_du_fichier_OFxml = Fields.PR.ReadFieldString(Repertoire_du_fichier_OFxml, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Numero As Integer
Friend Display_Sequence_Number As Double
Friend Repertoire_des_fichiers_dimportation As String
Friend Fichier_des_Commandes As String
Friend Fichier_des_OFs_Previsionnels As String
Friend Fichier_des_OFs_Fermes As String
Friend Fichier_des_Outils As String
Friend Fichier_des_Nomenclatures_OF As String
Friend Fichier_des_Stocks As String
Friend Fichier_des_postes_de_charges As String
Friend Fichier_des_calendriers As String
Friend Repertoire_du_fichier_OFxml As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Erreurs
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Numero As FormatFieldPair
Friend Shared Ligne As FormatFieldPair
Friend Shared TableErreur As FormatFieldPair
Friend Shared Libelle_Erreur As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Erreurs")

Numero = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Numero"))
Ligne = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Ligne"))
TableErreur = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "TableErreur"))
Libelle_Erreur = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Libelle Erreur"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Numero = Fields.PR.ReadFieldInt(Numero, Record)
MyItem.Ligne = Fields.PR.ReadFieldString(Ligne, Record)
MyItem.TableErreur = Fields.PR.ReadFieldString(TableErreur, Record)
MyItem.Libelle_Erreur = Fields.PR.ReadFieldString(Libelle_Erreur, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Numero As Integer
Friend Ligne As String
Friend TableErreur As String
Friend Libelle_Erreur As String
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class



Friend Class Pr_Lien
Private Sub New()
End Sub

Friend Shared Table As Integer

Friend Shared Numero As FormatFieldPair
Friend Shared RecordCommande As FormatFieldPair
Friend Shared RecordOF As FormatFieldPair

Friend Shared List As List(Of Tbl)

Friend Shared Sub init(ByVal PR As IPreactor)

Table = PR.GetFormatNumber("Lien")

Numero = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "Numero"))
RecordCommande = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "RecordCommande"))
RecordOF = New FormatFieldPair(Table, PR.GetFieldNumber(Table, "RecordOF"))

End Sub

Private Shared MyList As List (Of Tbl)

Friend Shared Sub Init_List()
MyList = New List (Of Tbl)
Dim Records As Integer = Fields.PR.RecordCount(Table)
For Record As Integer = 1 To Records
Dim MyItem As New Tbl
MyItem.Record = Record
MyItem.Numero = Fields.PR.ReadFieldInt(Numero, Record)
MyItem.RecordCommande = Fields.PR.ReadFieldInt(RecordCommande, Record)
MyItem.RecordOF = Fields.PR.ReadFieldInt(RecordOF, Record)

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
Return  MyList.item(Record-1)
Else
Return Nothing
End If
End Get
End Property

Friend Structure Tbl
Friend Record As Integer
Friend Numero As Integer
Friend RecordCommande As Integer
Friend RecordOF As Integer
End Structure
Protected Overrides Sub Finalize()
MyBase.Finalize()
End Sub

End Class

