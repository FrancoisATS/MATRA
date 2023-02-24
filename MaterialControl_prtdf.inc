;
RECORD_FORMAT
;
;
;
Shortages,ASSOCIATE (Orders):
   Number,-1,INTEGER,
      PRIMARY KEY
	  HIDDEN
      SHORTAGE TABLE:
   External Demand Order,-1,INTEGER, 
      EXTERNAL DEMAND KEY
      ALLOW UNSPECIFIED:
   Internal Demand Order,-1,INTEGER, 
      INTERNAL DEMAND KEY
      ALLOW UNSPECIFIED:
   Part No.,"",STRING,
      FREE FORMAT 
      MATERIAL CONTROL PART NO: 
   Shortage Quantity,0,REAL, 
      QUANTITY:
   Display Sequence Number,1,REAL,
      DISPLAY SEQUENCE
      HIDDEN;
;
;
;
; External Supply Data - Purchase Orders, Stock Information etc.
;
Supply,ASSOCIATE (Orders):
   Number,-1,INTEGER,
      PRIMARY KEY
      HIDDEN
      SUPPLY TABLE:
   Order No.,"",STRING,
      HELPPOPUPID (25400) 
      FREE FORMAT
      LOCATE
      MATERIAL CONTROL ORDER NO:
   Order Type,1,STRING,
      HELPPOPUPID (25410)
      DATABASE(Order Types(Name))
      EXCLUDE "(({#Number}==0)||({#Number}==2))"
      LOCATE
      ORDER TYPE:   
   Table Attribute 1,-1,STRING,
      HELPPOPUPID (6681)
      DATABASE(Attribute 1(Name))
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW UNSPECIFIED
	  LOOKUP UPDATE
      LIST TIPS:
   Table Attribute 2,-1,STRING,
      HELPPOPUPID (6681)
      DATABASE(Attribute 2(Name))
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW UNSPECIFIED
	  LOOKUP UPDATE
      LIST TIPS:
   Table Attribute 3,-1,STRING,
      HELPPOPUPID (6681)
      DATABASE(Attribute 3(Name))
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW UNSPECIFIED
	  LOOKUP UPDATE
      LIST TIPS:
   String Attribute 1,"",STRING,
      FREE FORMAT
      HELPPOPUPID (6682)
      DIALOG ONLY
      DIALOG LEVEL 10
	  LOOKUP UPDATE
      ALLOW EMPTY:
   String Attribute 2,"",STRING,
      FREE FORMAT
      HELPPOPUPID (6682)
      DIALOG ONLY
      DIALOG LEVEL 10
	  LOOKUP UPDATE
      ALLOW EMPTY:
   String Attribute 3,"",STRING,
      FREE FORMAT
      HELPPOPUPID (6682)
      DIALOG ONLY
      DIALOG LEVEL 10
	  LOOKUP UPDATE
      ALLOW EMPTY:
   Part No.,"",STRING,
      HELPPOPUPID (25430)
      FREE FORMAT
      LOCATE
      HEADER TIP DISPLAY
      MATERIAL CONTROL PART NO
	  LOOKUP UPDATE
	  LOOKUP SOURCE(Purchased Items(Part No.)): 
   Description,"",STRING,
      HELPPOPUPID (25440)
      FREE FORMAT
      ALLOW EMPTY
      HEADER TIP DISPLAY
	  LOOKUP UPDATE	  
	  LOOKUP SOURCE(Purchased Items(Description)):
   Supply Date,-1,TIME,
      HELPPOPUPID (25450)
      SUPPLY DATE
      HEADER TIP DISPLAY:
   Priority,0,REAL,
      HELPPOPUPID (80)
      PRIORITY
      FORMAT(.0):
   Quantity,0,REAL,
      HELPPOPUPID (260)
      QUANTITY
      HEADER TIP DISPLAY:
   Attributes,-1,DIALOG,
      HELPPOPUPID (75)
      CALL DIALOG 10:
   Display Sequence Number,1,REAL,
      DISPLAY SEQUENCE
      HIDDEN;
;
;
;
; External Demand - Sales Orders.
;
Demand,ASSOCIATE (Orders):
   Belongs to Order No.,-1,STRING,
      HELPPOPUPID (25500)  
      FAMILY(Order No.)
      DIALOG ONLY:
   Number,-1,INTEGER,
      PRIMARY KEY
      HIDDEN
      DEMAND TABLE:
   Order No.,"",STRING,
      HELPPOPUPID (25510) 
      FREE FORMAT
      LOCATE
      INHERIT FROM PARENT
      MATERIAL CONTROL ORDER NO:
   Order Type,2,STRING,
      HELPPOPUPID (25520)
      DATABASE(Order Types(Name))
      EXCLUDE "(({#Number}==0)||({#Number}==1))" 
      LOCATE
      ORDER TYPE:
   Order Line,1,INTEGER,
      HELPPOPUPID (25530)
      UNIQUE FOR FAMILY
      TIP DISPLAY:
   Table Attribute 1,-1,STRING,
      HELPPOPUPID (6681)
      DATABASE(Attribute 1(Name))
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW UNSPECIFIED
      LIST TIPS:
   Table Attribute 2,-1,STRING,
      HELPPOPUPID (6681)
      DATABASE(Attribute 2(Name))
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW UNSPECIFIED
      LIST TIPS:
   Table Attribute 3,-1,STRING,
      HELPPOPUPID (6681)
      DATABASE(Attribute 3(Name))
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW UNSPECIFIED
      LIST TIPS:
   String Attribute 1,"",STRING,
      FREE FORMAT
      HELPPOPUPID (6682)
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW EMPTY:
   String Attribute 2,"",STRING,
      FREE FORMAT
      HELPPOPUPID (6682)
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW EMPTY:
   String Attribute 3,"",STRING,
      FREE FORMAT
      HELPPOPUPID (6682)
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW EMPTY:
   String Attribute 4,"",STRING,
      FREE FORMAT
      HELPPOPUPID (6682)
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW EMPTY:
   Part No.,"",STRING,
      HELPPOPUPID (25430)
      FREE FORMAT
      LOCATE
      MATERIAL CONTROL PART NO
      TIP DISPLAY:
   Description,"",STRING,
      HELPPOPUPID (25440)
      FREE FORMAT
      ALLOW EMPTY
      TIP DISPLAY: 
   Demand Date,-1,TIME,
      HELPPOPUPID (25550)
      SHOW DATE
      DEMAND DATE
      INHERIT FROM PARENT
      HEADER TIP DISPLAY:
   Priority,0,REAL,
      HELPPOPUPID (80)
      PRIORITY
      FORMAT(.0):
   Quantity,0,REAL,
      HELPPOPUPID (260)
      QUANTITY
      TIP DISPLAY:
   Multiple Quantity,-1,INTEGER,
      HELPPOPUPID (25560)
      ALLOW UNSPECIFIED
      SUBSTITUTE(-1 -> "Unspecified")
      PEGGING MULTIPLE:
   Attributes,-1,DIALOG,
      HELPPOPUPID (75)
      CALL DIALOG 10:
   Display Sequence Number,1,REAL,
      DISPLAY SEQUENCE
      HIDDEN;
;
;
;
; Bill of Materials - Details of materials required for each Operation within and Order or Part
;
Bill of Materials,ASSOCIATE (Orders):
   Belongs to BOM,-1,STRING,
      HELPPOPUPID (10)
      FAMILY(Order No.)
      DIALOG ONLY:
   Number,-1,INTEGER,
      PRIMARY KEY
      BILL OF MATERIALS TABLE
      HIDDEN:
   Order No.,"",STRING,
      HELPPOPUPID (25600)
      FREE FORMAT 
      ORDER MATCH(Order No.)
      EXPAND REFERENCE(Orders(Order No.))
      INHERIT FROM PARENT:
OF_NumOperation,-1,STRING,
FREE FORMAT
EVALUATE "{$Order No.} _ {#Op. No.}":
   Order Part No.,"",STRING,
      HELPPOPUPID (25605)
      FREE FORMAT
      LOOKUP SOURCE(Product Bill of Materials(Part No.))
      ALLOW EMPTY
      LOOKUP UPDATE(Part No.):
   Operation Name,"",STRING,
      FREE FORMAT :
   Op. No.,0,INTEGER,
      HELPPOPUPID (25610)
      ORDER MATCH(Op. No.)
      LOOKUP UPDATE:
   Required Part No.,"",STRING,
      HELPPOPUPID (25620)
      FREE FORMAT 
      REQUIRED PART NO
      LOOKUP UPDATE: 
   Required Quantity,0,REAL,
      HELPPOPUPID (25630) 
      REQUIRED QUANTITY
      LOOKUP UPDATE:
   Multiply by order quantity,1,TOGGLE,
      HELPPOPUPID (25640)
      QUANTITY PER UNIT
      LOOKUP UPDATE:
   Ignore Shortages,0,TOGGLE,
      HELPPOPUPID (25650)
      IGNORE SHORTAGE
      GLOBAL ASSIGN
      LOOKUP UPDATE:
   Multiple Quantity,-1,INTEGER,
      HELPPOPUPID (25560)
      PEGGING MULTIPLE
      SUBSTITUTE(-1 -> "Unspecified")
      LOOKUP UPDATE:
   Spare String Field 1,"",STRING,
      FREE FORMAT(30)
      ALLOW EMPTY
      LOOKUP UPDATE:
   Spare String Field 2,"",STRING,
      FREE FORMAT(30)
      ALLOW EMPTY
      LOOKUP UPDATE:
  Spare String Field 3,"",STRING,
      FREE FORMAT(30)
      ALLOW EMPTY:
   Spare Number Field,0,REAL, 
      HIDDEN
      LOOKUP UPDATE:
   Spare Dialog 1,-1,DIALOG,
      HIDDEN
      HELPPOPUPID (112)
      CALL DIALOG 60:
   Display Sequence Number,1,REAL,
      DISPLAY SEQUENCE
      HIDDEN;
;
;
;
; Bill of Materials for Products
;
Product Bill of Materials:
   Belongs to BOM,-1,STRING,
      HELPPOPUPID (10)
      FAMILY(Part No.)
      DIALOG ONLY:
   Number,-1,INTEGER,
      PRIMARY KEY
      HIDDEN:
   Part No.,-1,STRING,
      INHERIT FROM PARENT	
      HELPPOPUPID (25605)
      EXPAND MATCH(Orders(Part No.))
      DATABASE(Products(Part No.))
      UNIQUE:
   Operation,-1,STRING,
      DATABASE(Products(Operation))
      UPDATE REFERENCE(Part No.)
      HIDDEN
      ALWAYS UPDATE:
   Operation Name,-1,STRING,
      HELPPOPUPID (25611)
      ADDITIONAL REFERENCE(Operation)
      DATABASE(Products(Operation Name))
      EXPAND MATCH(Orders(Operation Name))
      SECONDARY PICK:
   Op. No.,0,INTEGER,
      HELPPOPUPID (25610)
      DATABASE(Products(Op. No.))
      EXPAND MATCH(Orders(Op. No.))
      UPDATE REFERENCE(Operation):
   Required Part No.,"",STRING,
      HELPPOPUPID (25620)
      FREE FORMAT 
      LOOKUP SOURCE(Products(Part No.)): 
   Required Quantity,0,REAL,
      HELPPOPUPID (25630):
   Multiply by order quantity,1,TOGGLE,
      HELPPOPUPID (25640):
   Ignore Shortages,0,TOGGLE,
      HELPPOPUPID (25650)
      GLOBAL ASSIGN:
   Multiple Quantity,-1,INTEGER,
      HELPPOPUPID (25560)
      SUBSTITUTE(-1 -> "Unspecified"):
   Spare String Field 1,"",STRING,
      HIDDEN
      FREE FORMAT(30)
      ALLOW EMPTY:
   Spare String Field 2,"",STRING,
      HIDDEN
      FREE FORMAT(30)
      ALLOW EMPTY:
   Spare Number Field,0,REAL, 
      HIDDEN:
   Spare Dialog 1,-1,DIALOG,
      HIDDEN
      CALL DIALOG 60:
   Display Sequence Number,1,REAL,
      DISPLAY SEQUENCE
      HIDDEN;
#ifdef AS_PRO
;
;
;
; Details of Co-Products and By-Products produced by each Operation of an Order
;
Co-products,ASSOCIATE (Orders):
   Belongs to Co-product,-1,STRING,
      HELPPOPUPID (10)
      FAMILY(Order No.)
      DIALOG ONLY:
   Number,-1,INTEGER,
      PRIMARY KEY  
      COPRODUCT TABLE
      HIDDEN:
   Order No.,"",STRING,
      HELPPOPUPID (25700) 
      FREE FORMAT
      ORDER MATCH(Order No.)
      EXPAND REFERENCE(Orders(Order No.))
      INHERIT FROM PARENT:
   Order Part No.,"",STRING,
      HELPPOPUPID (25705)
      FREE FORMAT
      LOOKUP SOURCE(Product Co-products(Part No.))
      ALLOW EMPTY
      LOOKUP UPDATE(Co-product ID):
   Operation Name,"",STRING,
      HELPPOPUPID (25715)
      FREE FORMAT
      ORDER MATCH(Operation Name)
      LOOKUP UPDATE:
   Op. No.,0,INTEGER,
      HELPPOPUPID (25710)
      ORDER MATCH(Op. No.):
   Co-product,"",STRING,
      HELPPOPUPID (25720)
      FREE FORMAT
      COPRODUCT PART NO
      LOOKUP UPDATE: 
   Quantity,0,REAL,
      HELPPOPUPID (25730)
      COPRODUCT QUANTITY
      LOOKUP UPDATE:
   Multiply by order quantity,1,TOGGLE,
      HELPPOPUPID (25740)
      QUANTITY PER UNIT
      LOOKUP UPDATE:
   Spare String Field 1,"",STRING,
      HIDDEN
      FREE FORMAT(30)
      ALLOW EMPTY
      LOOKUP UPDATE:
   Spare String Field 2,"",STRING,
      HIDDEN
      FREE FORMAT(30)
      ALLOW EMPTY
      LOOKUP UPDATE:
   Spare Number Field,0,REAL, 
      HIDDEN
      LOOKUP UPDATE:
   Spare Dialog 1,-1,DIALOG,
      HIDDEN
      CALL DIALOG 60:
   Display Sequence Number,1,REAL,
      DISPLAY SEQUENCE
      HIDDEN;
;
;
;
; Details of Co-Products and By-Products produced by each Operation of a Part
;
Product Co-products:
   Belongs to Co-product,-1,STRING,
      HELPPOPUPID (10)
      FAMILY(Co-product ID)
      DIALOG ONLY:
   Number,-1,INTEGER,
      PRIMARY KEY  
      HIDDEN:
   Co-product ID,"",STRING,
      FREE FORMAT 
      INHERIT FROM PARENT
      EVALUATE"{$Part No.}"
      HIDDEN
      UNIQUE:
   Part No.,"",STRING,
      INHERIT FROM PARENT
      HELPPOPUPID (25700) 
      EXPAND MATCH(Orders(Part No.))
      DATABASE(Products(Part No.)):
   Operation,-1,STRING,
      DATABASE(Products(Operation))
      UPDATE REFERENCE(Part No.)
      HIDDEN
      ALWAYS UPDATE:
   Operation Name,-1,STRING,
      HELPPOPUPID (25715)
      ADDITIONAL REFERENCE(Operation)
      DATABASE(Products(Operation Name))
      EXPAND MATCH(Orders(Operation Name))
      SECONDARY PICK:
   Op. No.,0,INTEGER,
      HELPPOPUPID (25710)
      DATABASE(Products(Op. No.))
      EXPAND MATCH(Orders(Op. No.))
      UPDATE REFERENCE(Operation):
   Co-product,"",STRING,
      HELPPOPUPID (25720)      
      FREE FORMAT 
      LOOKUP SOURCE(Products(Part No.)): 
   Quantity,0,REAL,
      HELPPOPUPID (25730):
   Multiply by order quantity,1,TOGGLE,
      HELPPOPUPID (25740):
   Spare String Field 1,"",STRING,
      HIDDEN
      FREE FORMAT(30)
      ALLOW EMPTY:
   Spare String Field 2,"",STRING,
      HIDDEN
      FREE FORMAT(30)
      ALLOW EMPTY:
   Spare Number Field,0,REAL, 
      HIDDEN:
   Spare Dialog 1,-1,DIALOG,
      HIDDEN
      CALL DIALOG 60:
   Display Sequence Number,1,REAL,
      DISPLAY SEQUENCE
      HIDDEN;
#endif
;
;
;
; External Purchased Items Data - supply or purchase orders data.
;
Purchased Items:
   Number,-1,INTEGER,
      PRIMARY KEY
      HIDDEN
      PURCHASED ITEMS TABLE:
   Part No.,"",STRING,      
      FREE FORMAT      
	  INHERIT FROM PARENT
      UNIQUE
      HEADER TIP DISPLAY
      MATERIAL CONTROL PART NO:
   Description,"",STRING,      
      FREE FORMAT
      ALLOW EMPTY
	  INHERIT FROM PARENT
	  UNIQUE
      HEADER TIP DISPLAY:
   Lead Time,-1,DURATION,
      PURCHASED LEAD TIME
      HEADER TIP DISPLAY:
   Minimum Reorder Quantity,0,REAL,   
      MINREORDERQTY
      HEADER TIP DISPLAY:
   Reorder Multiple,0,REAL,     
      REORDERMULTIPLE
      HEADER TIP DISPLAY:     
   Table Attribute 1,-1,STRING,
      HELPPOPUPID (6681)
      DATABASE(Attribute 1(Name))
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW UNSPECIFIED
      LIST TIPS:
   Table Attribute 2,-1,STRING,
      HELPPOPUPID (6681)
      DATABASE(Attribute 2(Name))
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW UNSPECIFIED
      LIST TIPS:
   Table Attribute 3,-1,STRING,
      HELPPOPUPID (6681)
      DATABASE(Attribute 3(Name))
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW UNSPECIFIED
      LIST TIPS:
   String Attribute 1,"",STRING,
      FREE FORMAT
      HELPPOPUPID (6682)
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW EMPTY:
   String Attribute 2,"",STRING,
      FREE FORMAT
      HELPPOPUPID (6682)
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW EMPTY:
   String Attribute 3,"",STRING,
      FREE FORMAT
      HELPPOPUPID (6682)
      DIALOG ONLY
      DIALOG LEVEL 10
      ALLOW EMPTY:     
   Attributes,-1,DIALOG,
      HELPPOPUPID (75)
      CALL DIALOG 10:
   Display Sequence Number,1,REAL,
      DISPLAY SEQUENCE
      HIDDEN;
;
;
;
Ignore Shortages,ASSOCIATE (Orders):
   Number,-1,INTEGER,
      PRIMARY KEY
	  HIDDEN
      IGNORE SHORTAGES TABLE:
   External Demand Order,-1,INTEGER, 
      EXTERNAL DEMAND KEY
      ALLOW UNSPECIFIED:
   Internal Demand Order,-1,INTEGER, 
      INTERNAL DEMAND KEY
      ALLOW UNSPECIFIED:
   Part No.,"",STRING,
      FREE FORMAT 
      MATERIAL CONTROL PART NO: 
   Ignore Shortages,0,TOGGLE, 
      SHORTAGE IGNORED:
   Display Sequence Number,1,REAL,
      DISPLAY SEQUENCE
      HIDDEN;
;
; 
;
Order Links,ASSOCIATE (Orders):
   Number,-1,INTEGER,
      PRIMARY KEY
	  HIDDEN
      LINKS TABLE:
   From External Supply Order,-1,INTEGER,
      EXTERNAL SUPPLY KEY
      ALLOW UNSPECIFIED:
   From Internal Supply Order,-1,INTEGER, 
      INTERNAL SUPPLY KEY 
      ALLOW UNSPECIFIED:
   To External Demand Order,-1,INTEGER, 
      EXTERNAL DEMAND KEY
      ALLOW UNSPECIFIED:
   To Internal Demand Order,-1,INTEGER,
      INTERNAL DEMAND KEY
      ALLOW UNSPECIFIED:
   Part No.,"",STRING,
      FREE FORMAT 
      MATERIAL CONTROL PART NO: 
   Quantity,0,REAL, 
      QUANTITY:
   Pegging Rule Used,"",STRING,
      FREE FORMAT 
      PEGGING RULE USED:
   Verification Code,0,INTEGER,
      HIDDEN
      MATERIAL CONTROL VERIFICATION CODE:
   Locked,0,TOGGLE, 
      LINK LOCKED:
   Display Sequence Number,1,REAL,
      DISPLAY SEQUENCE
      HIDDEN;
;
;
;   Material Control Configuration
;
Material Control Configuration:
   Number,0,INTEGER,
      MATERIAL CONTROL CONFIGURATION TABLE
      PRIMARY KEY
      HIDDEN:
   Selected Pegging Rule Set,-1,STRING,
      HELPPOPUPID (24500)
      SELECTED RULE SET
	  ALLOW UNSPECIFIED
	  SUBSTITUTE(-1 -> "Default")
      DATABASE(Pegging Rules(Rule Set)):
   Allow Backward Links,0,TOGGLE,
      HELPPOPUPID (24505)
      ALLOW BACKWARD LINKS:
   Always use this Rule Set,1,TOGGLE,
      HELPPOPUPID (24510)
      FORCE DEFAULT RULE;
;
;
Pegging Rule Set:
   Number,0,INTEGER,
      PEGGING RULE SET TABLE
      PRIMARY KEY
      HIDDEN:
   Selected Pegging Rule Set,-1,STRING,
      HELPPOPUPID (24500)
      SELECTED RULE SET
      DATABASE(Pegging Rules(Rule Set)):
   Allow Backward Links,0,TOGGLE,
      ALLOW BACKWARD LINKS:
   Always use this Rule Set,1,TOGGLE,
      HELPPOPUPID (24510)
      FORCE DEFAULT RULE;
;
;
;
Pegging Rules:
   Belongs to Rule Set,-1,STRING,
      PEGGING RULES TABLE
      HELPPOPUPID (24000)
      FAMILY(Rule Set)
      DIALOG ONLY:
   Number,0,INTEGER,
      PRIMARY KEY
      HIDDEN:
   Rule Set,"",STRING,
      HELPPOPUPID (24010)
      RULE SET
      FREE FORMAT(20)
      INHERIT FROM PARENT:
   Clear Current Links,1,TOGGLE,
      HELPPOPUPID (24020)
      DIALOG ONLY
      INHERIT FROM PARENT
      CLEAR LINKS:
   First Pass Clear,0,TOGGLE,EVALUATE"({#Belongs to Rule Set}==-1)&&({#Clear Current Links}==1)"
      SWITCH OFF(Internal Supply Queue Filter)
      SWITCH OFF(Internal Supply Only)
      SWITCH OFF(Rule Type)
      SWITCH OFF(Retain Partial And Complete Allocations)
      SWITCH OFF(Retain Complete Allocations)
      SWITCH OFF(Allocate Multiples Only)
      ALWAYS UPDATE DIALOG ONLY HIDDEN:
   Rule,"",STRING,
      HELPPOPUPID (24030)
      RULE NAME
      FREE FORMAT(30):
   Enabled,1,TOGGLE,
      HELPPOPUPID (24040)
      RULE ENABLED:
   Debug This Rule,0,TOGGLE,
      HELPPOPUPID (24050)
      DEBUG ENABLED:
   Internal Supply Only,0,TOGGLE,
      HELPPOPUPID (24160)
      INTERNAL SUPPLY ONLY 
      DIALOG ONLY:
   Internal Supply Queue Filter,"ALL",STRING,
      HELPPOPUPID (24060)
      FREE FORMAT(50)
      INTERNAL SUPPLY FILTER
      MULTILINE
      MAX LENGTH (500)
      DIALOG ONLY:
   External Supply Queue Filter Toggle,0,TOGGLE,
      DIALOG ONLY HIDDEN 
      EVALUATE"(({#Internal Supply Only}==0)&&({#First Pass Clear}==0))" 
      SWITCH ON(External Supply Queue Filter):
   External Supply Queue Filter,"ALL",STRING,
      HELPPOPUPID (24170)
      FREE FORMAT(50)
      EXTERNAL SUPPLY FILTER
      MULTILINE
      MAX LENGTH (500)
      DIALOG ONLY:
   Supply Queue Ranking Toggle,0,TOGGLE,
      DIALOG ONLY HIDDEN 
      EVALUATE"(({#Internal Supply Only}==1)&&({#First Pass Clear}==0))" 
      SWITCH ON(Supply Queue Ranking):
   Supply Queue Ranking,-1,MATRIX,
      HELPPOPUPID (24070)
      INTERNAL SUPPLY RANKING
      FIELD RANKING LIST
      REMOTE(Orders(Due Date))
      REMOTE(Orders(Earliest Start Date))
      REMOTE(Orders(Priority)):
   Inherit From Supply,0,TOGGLE,
      HELPPOPUPID (24180)
      ENABLE INHERIT FROM SUPPLY
      DIALOG ONLY:
   Internal Demand Only,0,TOGGLE,
      HELPPOPUPID (24200)
      INTERNAL DEMAND ONLY
      DIALOG ONLY 
      SWITCH OFF(External Demand Queue Filter):
   Include Scheduled Orders in Demand Queue,0,TOGGLE,
      HELPPOPUPID (24150)
      DIALOG ONLY
      PEG SCHEDULED ORDERS:
   Internal Demand Queue Filter,"ALL",STRING,
      HELPPOPUPID (24080)
      FREE FORMAT(50)
      INTERNAL DEMAND FILTER
      MULTILINE
      MAX LENGTH (500)
      DIALOG ONLY:
   External Demand Queue Filter,"ALL",STRING,
      HELPPOPUPID (24080)
      FREE FORMAT(50)
      EXTERNAL DEMAND FILTER
      MULTILINE
      MAX LENGTH (500)
      DIALOG ONLY:
   Demand Queue Ranking Toggle,0,TOGGLE,
      DIALOG ONLY HIDDEN 
      EVALUATE"(({#Internal Demand Only}==1)&&({#First Pass Clear}==0))" 
      SWITCH ON(Demand Queue Ranking):
   Demand Queue Ranking,-1,MATRIX,
      HELPPOPUPID (24090)
      INTERNAL DEMAND RANKING
      FIELD RANKING LIST
      REMOTE(Orders(Due Date)):
   Inherit From Demand,0,TOGGLE,
      HELPPOPUPID (24190)
      ENABLE INHERIT FROM DEMAND
      DIALOG ONLY:
   Inherit From Demand Toggle,0,TOGGLE,
      DIALOG ONLY HIDDEN 
      EVALUATE"(({#Inherit From Supply}==0)&&({#First Pass Clear}==0))" 
      SWITCH ON(Inherit From Demand):
   Inherit From Supply Toggle,0,TOGGLE,
      DIALOG ONLY HIDDEN 
      EVALUATE"(({#Inherit From Demand}==0)&&({#First Pass Clear}==0))" 
      SWITCH ON(Inherit From Supply):
   Rule Type,99,STRING,
      HELPPOPUPID (24100)
      RULE TYPE
      LIST TIPS
      EXCLUDE "(~{Name}~==~User Function~)" 
      DATABASE(SMC Rule Types Lookup(Name)):
   User Defined Rule Toggle,0,TOGGLE,
      HELPPOPUPID (1)
      DIALOG ONLY
      HIDDEN
      SWITCH ON(Expression)
      EVALUATE "({#Rule Type}==0)||({#Rule Type}==100)"
      ALWAYS UPDATE:
   Expression,"",STRING,
      HELPPOPUPID (24110)
      USER DEFINED EXPRESSION
      HIDE WHEN DISABLED
      FREE FORMAT(50)
      MULTILINE
      MAX LENGTH (500)
      DIALOG ONLY:
   PESP Script Toggle,0,TOGGLE,
      HELPPOPUPID (1)
      DIALOG ONLY
      HIDDEN
      SWITCH ON(PESP Script)
      EVALUATE "({#Rule Type}==110)"
      ALWAYS UPDATE:
   PESP Script,"",STRING,
      HELPPOPUPID (24120)
      USER DEFINED PESP SCRIPT
      OVERWRITE PREVIOUS
      HIDE WHEN DISABLED
      FREE FORMAT(50)
      MULTILINE
      MAX LENGTH (500)
      DIALOG ONLY:
   Allocate Multiples Only,0,TOGGLE,
      HELPPOPUPID (24210)
      MULTIPLES ONLY
      DIALOG ONLY:
   Retain Partial And Complete Allocations,0,TOGGLE,
      HELPPOPUPID (24130)
      DIALOG ONLY
      RETAIN PARTIAL:
   Retain Allocations Toggle,0,TOGGLE,
      DIALOG ONLY
      HIDDEN
      SWITCH ON(Retain Complete Allocations)
      EVALUATE "(({#First Pass Clear}==0)&&({#Retain Partial And Complete Allocations}==0))"
      ALWAYS UPDATE:
   Retain Complete Allocations,0,TOGGLE,
      HELPPOPUPID (24140)
      DIALOG ONLY
      RETAIN COMPLETE:
   Allow Backward Links,0,TOGGLE,
      HELPPOPUPID (24141)
      DIALOG ONLY
      ALLOW BACKWARD LINKS;
;
;
RECORD_END
;
