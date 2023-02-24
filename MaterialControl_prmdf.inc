;
{CONDITIONAL},
   ELSE:pr_mc_end;
;
;
#label image EDIT_ExternalSupply:{EMBEDDED IMAGE PATH}/Supply.16.png
#label image EDIT_ExternalDemand:{EMBEDDED IMAGE PATH}/Demand.16.png
#label image EDIT_Orders:{EMBEDDED IMAGE PATH}/Blank.16.png
;
MENU_Orders : {DIALOG},
   Select Option from Menu,
   Orders:
   PUSHBUTTON,{TABLE DISPLAY NAME("Supply")},EDIT_ExternalSupply:
   PUSHBUTTON,{TABLE DISPLAY NAME("Demand")},EDIT_ExternalDemand:
   PUSHBUTTON,{TABLE DISPLAY NAME("Orders")},EDIT_Orders:
   PUSHBUTTON,Materials,MENU_Materials;
;
;
;
#label image EDIT_BillofMaterials:{EMBEDDED IMAGE PATH}/Products.16.png
#label image EDIT_Co-Products:{EMBEDDED IMAGE PATH}/Products.16.png
#label image EDIT_PeggingRules:{EMBEDDED IMAGE PATH}/Pegging.Rules.16.png
#label image EDIT_PurchasedItems:{EMBEDDED IMAGE PATH}/Products.16.png
;
MENU_Materials : {DIALOG},
   Select Option from Menu,
   Materials:
   PUSHBUTTON,{TABLE DISPLAY NAME("Bill of Materials")},EDIT_BillofMaterials:

   PUSHBUTTON,XXX,MENU_Maintenance;
;
;
#ifndef VIEWER
#ifdef AS_PRO
MENU_Material_Control : {DIALOG},
   Select Option from Menu,
   Material Control:
   PUSHBUTTON,{TABLE DISPLAY NAME("Pegging Rules")},EDIT_PeggingRules:
   PUSHBUTTON,Material Control Configuration,EDIT_MaterialControlConfiguration;
#endif
#endif
;
;
;
EDIT_Orders : PREDIT.DLL,
   "/FMT:Orders" Schedule /NGDDA /NGESA,
   Edit Orders,
   Data Editor,
   Foreground,
   ALWAYS:{RETURN};
;
;
EDIT_ExternalSupply : PREDIT.DLL,
   "/FMT:Supply" Schedule,
   Edit Supply Orders,
   Data Editor,
   Foreground,
   ALWAYS:{RETURN};
;
;
EDIT_ExternalDemand : PREDIT.DLL,
   "/FMT:Demand" Schedule,
   Edit Demand Orders,
   Data Editor,
   Foreground,
   ALWAYS:{RETURN};
;
;
EDIT_BillofMaterials : PREDIT.DLL,
   "/FMT:Bill of Materials" Schedule,
   Edit Bill of Materials,
   Data Editor,
   Foreground,
   ALWAYS:{RETURN};
;
;
EDIT_Co-Products : PREDIT.DLL,
   "/FMT:Co-products" Schedule,
   Edit Co-Products,
   Data Editor,
   Foreground,
   ALWAYS:{RETURN};
;
;
EDIT_Products_Co-Products : PREDIT.DLL,
   "/FMT:Product Co-products" Schedule,
   Edit Products Co-Products,
   Data Editor,
   Foreground,
   ALWAYS:{RETURN};
;
;
EDIT_PeggingRules : PREDIT.DLL,
   "/FMT:Pegging Rules",
   Edit Pegging Rules,
   Data Editor,
   Foreground,
   ALWAYS:{RETURN};
;
;
EDIT_PurchasedItems : PREDIT.DLL,
   "/FMT:Purchased Items",
   Edit Purchased Items,
   Data Editor,
   Foreground,
   ALWAYS:{RETURN};
;
;
EDIT_MaterialControlConfiguration : PREDIT.DLL,
   "/FMT:Material Control Configuration" /ER:0,
   Edit Material Control Settings,
   Data Editor,
   Foreground,
   ALWAYS:{RETURN};
;
;
pr_mc_end:{CONDITIONAL},
   ELSE:{NEXT};
;
