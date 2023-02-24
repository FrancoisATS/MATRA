#VERSION 0
;
ENG POPUP HELP
1 "No help topic is associated with this item.":
10 "This field is used to identify what order the part belongs to.  In the first operation of an order it is set to PARENT, in other operations it is set to the unique order number or name.":
40 "This field is used to identify the part number.  Pressing the button will show all part numbers in the products data table. Selecting a part number will automatically change the name of the product.":
41 "This field contains a list of different status’ that can be defined against an order.The values are taken from the Order Status data table, where new status’ can be added if required.An operation bar pattern, set in the Order Status data table against each status type, can be used to define the pattern of the operation bar of the order when the order is scheduled in the Sequencer.":
45 "This field is used to identify the part number.":
50 "This field is used to identify the name of the product. Use the button to select the name, the part number will be automatically changed.":
55 "This field is used to identify the name of the product.":
60 "This field is used to identify the order number for this product.The order could be an internal order number or one specified by the customer. The order number must be unique.":
70 "This field can be used to contain notes about this order. It could be a reminder regarding due dates, or simply a message to the packer/assembler on the shop floor.":
75 "Opens a dialog showing all of the Attribute information for the operation.":
80 "Use this field to set the priority for the job which will in turn be used by the sequencer.The lower the number the higher the priority. Note that priorities can be negative; a negative priority is higher than a positive one.For example, -100 is higher than -1 and 0 is higher than 10.":
90 "This field sets the operation number for a job.This is used to sequence the job in the Sequencer. The lowest number operations will be completed before starting higher number operations.If there are two operations with the same number in a product then both will be completed before higher operation numbers are started.":
110 "This is a written description or name of the operation that takes places, also identified by the operation number.":
112 "Opens a dialog containing information about the Resource data assigned to this operation":
120 "Setup groups are defined in the Setup Groups data table, e.g. Setup Group 1, Setup Group 2 etc. These values are used as the axes of one of the Sequence Dependent Setup Time Matrices, which establishes the changeover time between products in different setup groups (typically set up in the resources data table). Individual setup groups are allocated to products in the Products data table, although this default value may be overwritten in the Main Schedule file.":
130 "This field identifies the group of valid resources that can carry out the current operation.":
140 "If necessary, this field can be used to identify a specific resource that should process the operation.If in the products data table this has been set to 'Select from Group' then any of the resources in the group displayed in the Resource Group field could be used.If you want to force the operation onto a specific resource in the group then use the drop down list to select the resource required.":
150 "This field will show the actual resource that will process the operation.If the order has not been scheduled before then this will be set to 'Unspecified'.If the operation has already be loaded to the planning board then the resource it is currently set to be loaded to will be displayed.":
180 "This field is used to state whether the processing rate is calculated as time per batch, time per item or rate per hour.If 'time per batch' is selected then the time shown in the field below is the time taken to process all parts in the batch. If 'time per item' is selected then the process time will be the value in the field below multiplied by the batch size.If 'rate per hour' is selected then the process time will be calculated directly from the number in the batch.":
220 "You have currently chosen a Process Time Type of 'Time Per Item'.You need to enter an operation time for each item in this field.":
230 "You have currently chosen a Process Time Type of 'Time Per Batch'.You need to indicate a total operation time for the batch in this field.":
240 "You have currently chosen a Process Time Type of 'Rate Per Hour'.You need to state how many items can be produced per hour in this field.":
251 "The color in this field instructs the sequencer to display a section of the Gantt Chart bar in a different color.The color marks the bar based on the value that has been entered into the Mid Batch Quantity and Mid Batch Time fields.":
260 "This field is used to specify the order or batch quantity.":
270 "This field is used to specify the order or batch profit and can be used to influence sequencing when using the weighting rule.":
280 "This field will show the start time of the first operation in this order if the MakeSpan feature is enabled":
290 "This field will show the end time of the last operation in this order if the MakeSpan feature is enabled":
300 "This value determines the quantity that should be processed before the subsequent operation can be started. A value of Unspecified prevents operation overlapping":
360 "Used to specify a date before which the job cannot be started.This might for example be the time when materials will be available.":
370 "This field is to be used to establish the due date.The due date is used to highlight late items in the Sequencer and to prioritize job loading to the planning board if the 'due date' option is selected.":
380 "Select this toggle to show the Scheduler that the times in the start time and end time are 'actual' values.When set, this toggle prevents the order from being unallocated from any resources in the sequencer.In effect it is fixed permanently to the planning board.":
390 "The Scheduler sets this field, during sequencing, to the time at which the job is scheduled to start the set-up process.":
400 "The Scheduler updates this field during sequencing to the time at which the job is scheduled to start.":
410 "The Scheduler updates this field during sequencing to the time at which the job is scheduled to finish.":
420 "Set this toggle if you do not wish this job to be unallocated after selecting Unallocate All Jobs in the sequencer. This will lock the operation. This can also be achieved when using 'Highlight Locked Operations' locate mode in the Sequencer by pointing with the mouse at an operation (icon or bar in the overview), depressing the shift key on the keyboard and clicking with the left mouse button.":
421 "Operations that have this toggle checked will be left unallocated in the unallocated operations window, when automatically scheduling operations.":
430 "Enables user definable characteristics to be attributed to products, e.g. color. Within a specific characteristic, attribute records are given a priority ranking, e.g. 'white' products may have a higher priority than 'yellow'. These attributes are used by the Scheduler's Preferred Sequencing Rules, consolidating similar orders within the Look Ahead.":
440 "Fill in the information on the quantity completed, and enter the time that the 'part batch' was completed in the Mid Batch Time field. The Scheduler will automatically re-calculate the 'End Time' for this operation.":
450 "Fill in the time that the 'part batch' was completed and enter the information on the quantity completed in the Mid Batch Quantity field. The Scheduler will automatically re-calculate the 'End Time' for this operation.":
460 "The Effective Op Time field uses entries in the ‘Mid Batch Quantity’ and ‘Mid Batch Time’ fields to calculate a revised operation time based on this information. It should be noted that for this facility to operate correctly, ‘Mid Batch Times’ and ‘Mid Batch Quantities’ should be modified when the Editor is displayed within the Sequencer, otherwise the ‘Effective Op Time’ will only change on the next occasion the Sequencer is entered.":
474 "Used to record the cost of an item at the point where it is introduced into the process.The field may be used to record fixed costs per item, such as sub-contract heat treatment and so on.":
476 "Uses the Material Cost Per Item to provide the material cost of the batch at the point where the cost per item is introduced into the process.":
477 "Direct cost of the job at the current process.":
530 "Establishes a time horizon in which jobs may be batched together for production. A resource completing an operation on the planning board will look forward from that point over the time horizon established by the Look Ahead Window. The Preferred Sequence Criteria, setup in the Resources data table, are applied to select jobs from work who's due date falls within this time horizon. The Look Ahead Window can be established against individual products, in the Products data table and modified for individual orders in the Main Schedule file or it can be established as a global rule in the Configuration Set Up Information.":
540 "Established in the Products data table, this provides access to a word document that can contain information concerning the product. The document can also be accessed and edited from the Main Schedule file editor.":
541 "This field is used to describe the progress of an individual operation.There are four different progress states: Not Started; Setup; Running; Complete":
550 "Products may have particular characteristics associated with them, in the Scheduler these are accommodated in the Attribute data table. These tables are user defined and for example, the Product Attribute 1 table may be reserved for color, where individual records would be named - red, blue, green etc.Product Attributes can be selected in the Like to Like Match field in the products data table to define a Like to Like Setup time.":
560 "Used to establish a priority ranking between records in the Product Attribute 1 data table, used by APS Rules sequencing selection.":
570 "Products may have particular characteristics associated with them, in the Scheduler, these are accommodated in the Attribute data tables. These tables are user defined and for example, the Attribute 2 table may be reserved for material, where individual records would be named – steel, brass, copper etc.Product Attributes can be selected in the Like to Like Match field in the products data table to define a Like to Like Setup time.":
580 "Used to establish a priority ranking between records in the Product Attribute 2 data table, used by APS Rules sequencing selection.":
590 "Products may have particular characteristics associated with them, in the Scheduler, these are accommodated in the Attribute data tables. These tables are user defined and for example, the Attribute 3 table may be reserved for material widths, where individual records would be named – 16', 18', 20', 24' etc. Product Attributes can be selected in the Like to Like Match field in the products data table to define a Like to Like Setup time.":
600 "Used to establish a priority ranking between records in the Product Attribute 3 data table, used by APS Rules sequencing selection.":
602 "This field calculates the duration of the entire order from the setup start time of the first operation to the end time of the last operation of the order.":
620 "A dispatching rule that calculates an index number by dividing the time to due date remaining by the expected elapsed time to finish the job. A ratio of less than 1 indicates the job is behind schedule, more than 1 indicates it is ahead of schedule.":
815 "This option allows values for setup and operation times to be established. It is also used to update the progress of jobs through the production system.":
1020 "Specifies the Resource Group name. This will be used to identify specific groups of resources, capable of performing similar functions.":
1030 "Identifies the valid resources for the Resource Group. A resource may be a member of more than one group.":
1060 "When switched on, this toggle will display a usage plot for the resource group in the multi plot window in the sequencer.":
1070 "This color will be displayed on the usage plot that is visible in the multi plot window in the sequencer.":
1080 "The usage plot, present in the multi plot window in the sequencer, will display this color when the usage exceeds the number of hours available for the resource or resource group (if the Usage Max. Hours field is set as unspecified).If a value has been entered into the Usage Max. Hours field, then the plot will change color as per this value.":
1090 "The usage plot, in the multi plot window in the sequencer, will use this color to draw a line that marks the setup usage measured in hours.":
2020 "Specifies the name of the individual Resource.":
2023 "The hourly cost of running the resource.":
2024 "Applies 'Cost Factor %' values, established in the Master Calendar Records, to the hourly cost of the resource.":
2030 "This dialog holds information about the way in which a resource or resource group is to be displayed in the Sequence Overview window and Usage Plots.":
2040 "Can be set to Visible, Minimized or Disabled. Used to control the initial state of this resource's window when the Sequencer starts. Normally set to Minimized. If set to Disabled, the resource is not used for sequencing.":
2050 "Controls the horizontal (time) scale of the Gantt resource windows in the Sequencer. Can vary from minutes to weeks per unit.":
2070 "Allows a resource capacity to be set to Finite, Infinite or Infinite with Shift Patterns.":
2071 "Allows a resource capacity to be set to Finite, Infinite or Infinite with Shift Patterns when running in Infinite Capacity Sequencer Mode.":
2080 "Controls the horizontal (time) scale of the tiled resource windows in the Sequencer.":
2100 "Selects the secondary constraints to be applied to a primary resource. It specifies the constraint quantity required by the resource and the manner in which the constraint is applied to the primary resource.":
2110 "Stipulates when the usage of the secondary resource should be incremented or decremented, e.g. Increment for Duration which utilizes the secondary constraint for the duration of the operation and releases it on completion. If a job is placed on a fixture for several operations, Increment at Start for the first operation and Decrement at Finish for the last operation may be specified. This will ensure that the fixture cannot be used for any other job while the first job is queuing for a resource.":
2120 "Specifies the required quantity of the secondary constraint. If the value 'Quantity' is selected the quantity required is equal to the batch quantity being processed.":
2130 "Defines an attribute of an operation that will prevent dissimilar operations being performed simultaneously on an infinite capacity resource.":
2150 "Used in APS products, to establish the criteria to be used by the preferred sequencing rules in selecting work for processing.":
2160 "Used in the APS produc, by 'Minimize WIP' scheduling rules, to establish time buffers in which WIP can accumulate, ahead selected resources.":
2180 "A numeric value used to sort the order in which resources are displayed in the resources data table. It can also be used to override the default order in which resources are displayed in the sequence overview.":
2181 "Displays the dialog where advanced resource constraint options can be defined if required":
2182 "Allows the definition of complex inter resource relationships using expressions. Details of expression syntax and creation can be found in the documentation.":
2183 "Allows the user to chose an attribute of an operation on an infinite capacity resource which specifies that only operations with the same value in the selected attribute can be scheduled at the same time.":
2185 "Determines whether a separator line is displayed below the resource on the gantt chart.  This can help when visualing resources in groups.":
2190 "Determines the manner in which the resource will be displayed in the Sequence Overview. The alternatives are 'Always', 'Only on Group' and 'Hide'.":
2191 "Determines the manner in which the operations will be displayed in the Sequence Overview. The options are 'Stacked' where the operations are displayed on one overview line, and 'Cascade' where each operation is displayed on its own overview line.":
2200 "Used to establish a matrix of sequence dependent set-up values, defining the set-up time required changing from a product of one attribute type to another.":
2201 "This field sets which changeover group is assigned to this resource and as a result determines which changeover times between operations with different attributes are applied.":
2202 "Determines whther the setup and changeover times related to operations on this resource are applied concurrently or cumulatively.":
2205 "Use of this tick box stops the resource's inclusion in the schedule performance metrics calculations.":
2210 "This field is used to select what Viewer system the resource belongs to.The field contains a list of Scheduler system names taken from the PCO Address book data table.":
2220 "This button opens up a dialog listing the different attributes associated with the resource.":
2230 "This field allows string attribute data to be entered against the resource.":
2240 "This field allows real attribute data to be entered against the resource.":
2250 "This field allows duration attribute data to be entered against the resource.":
2260 "This field denotes the efficiency of a resource, the default value is 100%, if the efficiency is changed to 200% then any operations scheduled on this resource would be processed twice as fast (half the regular process time).":
2270 "This is a toggle field which when switched on, will apply the value in the Efficiency % field to all operations that have setup times and are scheduled on the resource that the toggle is set on.":
2280 "When switched on, this toggle will display a usage plot for the resource in the multi plot window in the sequencer.":
2300 "Use this field to select a Secondary Constraint Group from which a Secondary Constraint will be allocated when Sequencing.":
2310 "The Secondary Constraint allocated from the Secondary Constraint Group will be assigned into this field.":
5035 "A cost factor multiplier, which influences the running cost of the resource to which it is applied. A value of 100% applies no increase, a value of 150% inflates the running cost by 50%. Established in the Calendar States data table they provide the default values used in the Master Calendar Files.":
6100 "Displays a dialog which allows the selection of which resources from the selected group are valid and the assigment of resource specifc data.":
6110 "This field determines whether the resource will be selected during automatic sequencing.  If unticked the operation can still be manually placed on the resource.":
6120 "This field enables an individual setup time value to be established each of the resources that are valid for the operation.":
6130 "This field enables an individual operation time to be established for each of the resources that are valid for the operation.":
6131 "This field enables an individual rate per hour to be established for each of the resources that are valid for the operation.":
6132 "This field enables an individual batch time to be established for each of the resources that are valid for the operation.":
6140 "This field is used to define a secondary resource used by the primary resource during the current operation.":
6150 "This field is used to specify how the secondary constraint is used during the operation, e.g. Increment for Duration, Increment Setup Time Only, etc.":
6160 "Use this field to indicate the amount of the secondary constraint required during the current operation, e.g. You could specify that the operation required one Chuck Steady.":
6170 "The Scheduler will utilize this period of time to attempt to load the current operation onto the preferred resource. If it is unable to do so by the end of this time, it will try to load the operation on any other resources in the group.":
6180 "Set Subsequent Resource Group establishes a 'forced list' of resources, i.e. those specified in the selected group. It 'forces' downstream or subsequent operations to use only those resources that are contained in the 'forced list'. Thus if a process route calls for a resource group at a downstream operation that contained some resources which are not members of the list, these would not be usedwhen sequencing. Set Subsequent Resource Group is an accumulative function and can be used at more than one operation in a process route, adding resources to the 'forced list'.":
6190 "Reset Subsequent Resource Group function removes any resources, contained in the Resource Group selected, from the 'forced list' established by Set Subsequent Resource Group command. If a conceptual Resource Group, 'All', were established, that included all available resources, the resources used by subsequent operations would be those set up in the original process route.":
6230 "This field enables a setup time to be specified, converting from the previous product to the current product. Values in the Setup Time field will be added to any set-up values established for the resource by a Sequence Dependent Setup Time matrix.":
6430 "Select an icon name from the drop down box.The edit button will allow you to create new icons.":
6470 "Displays the Valid Secondary Constraints Dialog, allowing valid constraints to be applied to individual records in this table. Characteristics of constraint usage can also be edited here.":
6530 "Specifies the maximum time interval that will be allowed between two sequential operations. The maximum time interval is qualified by the 'Interval Type' field which establishes 'Start to Start', 'End to End' relationships etc.":
6540 "Establishes the relationship used to interpose the maximum time interval between two contiguous operations, established in the 'Max Time Before Next Op.' field. This may be an 'End to End', 'End to Start', 'Start to Start' or 'Start to End' relationship.":
6550 "Specifies the maximum amount of time, expressed as a percentage of the theoretical process time, over which an operation may extend when automatically sequenced by the Sequencer.":
6560 "Defines a given amount of slack time to be built in between this operation and the previous.":
6565 "Defines a given amount of slack time to be built in between this operation and the next.":
6580 "This field can be used to apply a process rate multiplier order to affect the operation length.":
6681 "This field is used to specify an attribute of this record which is referenced from one of the attribute tables.  These can be used to affect setup times, scheduling order and constraint usage.":
6682 "This field is used to specify a free format string attribute of this record.  These can be used set display options and group operations.":
6683 "This field is used to specify a numerical attribute of this record.  These can be used to  set display options, affect scheduling order and constraint usage.":
6684 "This field is used to specify a date attribute of this record. These can be used to set display options and affect scheduling order.":
6685 "This field is used to specify a duration attribute of this record. These can be used to set display options and affect scheduling order.":
6690 "The Delivery Buffer field contains a buffer time that is subtracted from the Due Date when backward sequencing so that the operations are scheduled earlier than the latest time possible.This is to allow for unexpected delays in the process.":
7020 "The number of days prior to current time that can be displayed in the Sequence Overview.":
7030 "The period of time, after the current time, that can be displayed in the Sequencer Overview.":
7035 "Opens a configuration setup dialog which allows the user to customize the sequence overview.":
7040 "Specifies an offset, from the time of order entry, before which a job cannot be started. If set to Unspecified, there is no restriction other than current time.":
7050 "Specifies an offset, from the time of order entry, by which the job should be available. Can be overwritten.":
7060 "The amount of time by which the terminator has been offset from the current time. The terminator represents current time when the terminator offset is set to 0 Hours 00 Min.":
7067 "Establishes cost calculation options, these being: During Sequence, After Sequence or Never.":
7120 "Sets the sequence overview mode.":
7130 "The number of days from now to start the sequence overview from.":
7140 "The number of days from now to end the sequence overview at.":
7320 "Enables the script required to import orders to be selected from the 'Scripts' data table.":
7330 "Enables the script required to export orders to be selected from the 'Scripts' data table.":
7430 "This toggle field when checked switches on a small black triangle against each operation bar in the Sequencer.This feature makes it easier to drag operations that are allocated on the planning board, especially smaller operations.":
7450 "Specifies the default PESP event script that should run when importing orders from the 'Import Orders' button on the Data Transfer Menu.":
7470 "Specifies the default PESP event script that should run when exporting orders from the 'Export Orders' button on the Data Transfer Menu.":
7480 "Specifies the default PESP event script that should run when releasing a schedule from the 'Release Schedule' button on the Data Transfer Menu.":
7490 "Specifies the default PESP event script that should run when allocating operations in the Sequencer with the APS Rules option switched on.":
8020 "Secondary constraint name.":
8030 "Allows you to select the color of the Sequencer User Plot when the values are between the high and low limits.":
8040 "Sets the plot fill pattern.":
8060 "Plot fill color if the plot should pass the upper plot limit.":
8080 "Plot fill color if the plot should pass the lower plot limit.":
8090 "Specifies whether this secondary constraint should constraint the schedule when using a 300 FCS product or above. In all versions, not selecting this check box will stop the Sequencer from issuing warnings if the limits set for this secondary constraint are exceeded.":
8091 "When in Infinite Capacity Sequencer Mode, this field specifies whether this secondary constraint should constrain the schedule when using a 300 FCS product or above.":
8092 "Options for controlling the behaviour of this constraint when the system is set to infinite capacity mode.":
8100 "Determines how the primary resource calendar efficiency affects the usage of this secondary constraint. Options are: No Effect; Start of Job Efficiency; Follow Efficiency Changes; Use 100% if Greater Than 0%":
8101 "When in Infinite Capacity Sequencer Mode, this field will determine how the primary resource calendar efficiency affects the usage of this secondary constraint. Options are: No Effect; Start of Job Efficiency; Follow Efficiency Changes; Use 100% if Greater Than 0%":
8120 "This button opens up a dialog listing the different attributes associated with the secondary constraint.":
8130 "This field allows string attribute data to be entered against the secondary constraint.":
8140 "This field allows real attribute data to be entered against the secondary constraint.":
8150 "This field allows duration attribute data to be entered against the secondary constraint.":
8160 "When switched on, this toggle will display a usage plot for the secondary constraint in the multi plot window in the sequencer.":
8200 "The name of the Secondary Constraint Group.":
8210 "Allows you to select which Secondary Constraints are members of this group.":
9020 "Setup group names, these form the X and Y axis of the Sequence Dependent Setup Time matrixin the Resources data table.":
12020 "Name of an attribute record in the Product Attribute 1 data table.":
13020 "Name of an attribute record in the Product Attribute 2 data table.":
14020 "Name of an attribute record in the Product Attribute 3 data table.":
16020 "The name used to describe the screen display configuration saved under the File Name. This description is also used as the tip display for Workspace Tool Bar icons.":
16030 "The file is chosen by selection a file from the option offered by the button to the left of the field. The original workspace configuration file is saved, with a .WPI file extension, by using the Save Workspace command under Workspace in the Sequencer Menu.":
18510 "The name of the individual or organization that placing an order.":
18520 "Name of the primary contact within an organization placing an order.":
18530 "Telephone number to be used in connection with an order.":
18540 "E-Mail Address to be used in connection with an order.":
21000 "This field allows different ‘order status’ to be entered; the Order Status can be selected against an order in the Schedule file.":
21020 "This field is used to hold the description of what the order status name means that has been entered into the ‘Order Status Name’ field.":
21100 "Name of the attribute record in the Attribute data table.":
21110 "Used to establish a priority ranking between records in this Attribute data table which can be used by scheduling rules":
24000 "This field specifies whether the record is a parent record of the rule set or a child.":
24010 "Contains the name of the rule set.":
24020 "This toggle is used to clear pegging links only for orders that are in the demand queue of the first pass (whether enabled or not) of the rule set.":
24030 "Holds the name of the particular function of the rule pass.":
24040 "A toggle that when set to true enables the rule pass, when set to false this particular rule pass will be ignored when running the rule set.":
24050 "When this toggle is set to true, and the rule set is run, a debug file will be created in the working directory.":
24060 "This field is used to specify criteria that can be used to restrict what items are placed in the Internal Supply Queue.  The default value for this field is set as ALL, but this can be changed by entering an expression e.g. (~{$Order Type}~==~Stock~).  This queue filters records held in the 'Works Orders' database.":
24070 "This field contains criteria that can be used to rank the items in the Internal Supply Queue. For example you can rank the Internal Supply Queue by Due Date, Earliest Start Date or Priority.":
24080 "This field is used to specify criteria that can be used to restrict what items are placed in the Demand Queue.  The default value for this field is set as ALL, but this can be changed by entering an expression e.g. (~{$Order Type}~==~Stock~).  This queue filters records held in the 'Works Orders' database.":
24090 "This field contains criteria that can be used to rank the items in the Internal Demand Queue. For example you can rank the Internal Demand Queue by Due Date, Earliest Start Date or Priority.":
24100 "This field contains a list of the various standard pegging rules that can be used to peg the orders together.  It also contains three special items – User Defined, User Function and PESP Script that provide the opportunity to create more customized rules.":
24110 "This field is only visible when the 'Rule Type' field is set to either 'User Defined' or 'User Function'.  The expression to be used for the rule is entered into this field.  An example might look like this: (~{+:$Product Attribute 1}~==~{-:$Product Attribute 1}~) allowing only supply and demand orders to be linked if the 'Product Attribute 1' fields have the same value.":
24120 "This field is only visible when the 'Rule Type' field is set to 'PESP Script'.  This field holds the name of the PESP Script to be used as the rule.":
24130 "This option allows links to be created on BoM lines where the quantity of the BoM line doesn't have to be completely satisfied for the link to be made.  Any items that are short will be highlighted as a shortage.":
24140 "This option will only allow links to be created on BoM lines where the quantity of the BoM line is fully satisfied.  Any items that are short will be highlighted as a shortage.":
24141 "When this option is checked the default behavior of SMC is overridden by allowing backward links to be created when production occurs after consumption.":
24150 "When set to true, orders that are already scheduled can be re-linked.":
24160 "When this toggle is set to true, the 'Supply Queue Ranking' field becomes enabled allowing supply records to be ranked according to the selection criteria in the 'Supply Queue Ranking' field.  This option should only be selected if all records are held in the 'Works Orders' database.":
24170 "This field is used to specify criteria that can be used to restrict what items are placed in the External Supply Queue.  The default value for this field is set as ALL, but this can be changed by entering an expression e.g. (~{$Order Type}~==~Stock~).  This queue filters records held in the 'Demand' database.":
24180 "Any field with the INHERIT FROM SUPPLY(Field Name) classification will be processed.":
24190 "Any field with the INHERIT FROM DEMAND(Field Name) classification will be processed.":
24200 "When this toggle is set to true, the 'Demand Queue Ranking' field becomes enabled allowing demand records to be ranked according to the selection criteria in the 'Demand Queue Ranking' field.  This option should only be selected if all records are held in the 'Works Orders' database.":
24210 "The quantity of a link created will be allocated in specific multiples when this toggle is set to true. This multiple is specified in the BoM Data.":
24500 "If the 'Always use this Rule Set' toggle field is checked, the pegging rule set selected in this field will be the rule set that runs by default when the 'Peg Materials' option is selected in the Sequencer.":
24505 "When this global option is checked the default behavior of SMC is overridden by allowing backward links to be created when production occurs after consumption.":
24510 "When checked this toggle will use the rule selected in the 'Selected Pegging Rule Set' field as the default rule that will run when the 'Peg Materials' option is selected in the sequencer.  If the 'Always use this Rule Set' option is unchecked, a rule selection dialog will appear when selecting the 'Peg Materials' option in the sequencer, this will allow the rule that is to be run to be selected at that time.":
25400 "This is the field used to hold the order number of the supply order.":
25410 "This field identifies the type of order, for example Stock or Purchase.":
25420 "The name of the organization supplying the materials for the order.":
25430 "The part number that the order is for.":
25440 "Description of the part that the order is for.":
25450 "Date when the material is supplied.":
25500 "This field is used to identify what order the part belongs to.  The first order line of an order will be the parent record and display PARENT in this field, the other order lines that are part of this order will be child records and display the order number that they belong to in this field.":
25510 "This is the field used to hold the order number of the demand order.":
25520 "This field identifies the type of order, for example make to Stock or Sales Order.":
25530 "Uniquely identifies a line item of an order.":
25540 "The name of the organization requiring the materials for the order.":
25550 "Date when the material is required.":
25560 "Specifies the multiple of an item that must be pegged.  Often a number of items will make up a box or case, an example might be where 12 cans make up 1 box, an order requiring 60 cans arrives.  There is a supply order for 50 cans.  Material control will only peg to 48 cans of the 50, it will then look elsewhere for the remaining 12 cans that it requires, but it will only make the link if the exact amount of 12 is found.  The 'Allocate Multiples Only' field should be checked in the 'Pegging Rules' database for this feature to be turned on.":
25600 "Order number that the BoM line belongs to.":
25605 "Part number of the order that BoM line belongs to.":
25610 "Operation number that the BoM line belongs to.":
25611 "Name of the operation that the BoM line belongs to.":
25615 "Part number of the product which requires the specified material":
25620 "Part number of the BoM item.":
25630 "Required quantity of BoM item.":
25640 "When set to true, this field will cause the quantity of the order to be multiplied by the required BoM quantity.":
25650 "Causes shortages to be ignored when running pegging rule.  Allows orders with shortages to be scheduled.":
25700 "Order number that co-product is produced in.":
25705 "Part number of the order that co-product is produced in.":
25710 "Operation number that produces co-product.":
25715 "Operation name that produces co-product.":
25720 "Name of co-product.":
25730 "Quantity of co-product produced.":
25740 "When set to true, this field will cause the quantity of the co-product to be multiplied by the order quantity.":
25800 "This field identifies the type of order, for example: Works Order, Purchase Order, Sales Order or Stock":
25810 "When checked, the unscheduled operation will no longer be displayed in the 'Unscheduled Operations' window.":
25820 "Displays a dialog displaying fields related to Material Control.":
25830 "This field provides information on the status of demand after materials have been pegged.  It will contain one of the following values: 'Unknown', 'Satisfied', 'All shortages Ignored', 'Shortages', 'Over Supplied', 'Over Supplied, Shortages', 'Over Supplied, All Shortages Ignored'.":
25840 "This field is populated after materials have been pegged.  When a link to a supply order in the 'Supply Orders' database has been made, the 'Demand Date' field in the 'Works Orders' database is populated with the 'Supply Date' of the supplying order.  The 'Supply Date' field will be evaluated against the 'Earliest Start Date' field and the latest of the two dates will be used in determining which date should be used when scheduling.":
25850 "This field is populated after materials have been pegged.  When a link to a demand order in the 'Demand Orders' database has been made, the 'Supply Date' field in the 'Works Orders' database is populated with the 'Demand Date' of the demand order it is linked to.  The 'Demand Date' field will be evaluated against the 'Due Date' field and the earliest of the two dates will be used in determining which date should be used when scheduling.":
25900 "Displays a dialog with fields relating to the status of an operation.":
25910 "This option can be selected when an order is split, this option enables each production lot to proceed independently through the manufacturing process, e.g. all lots do not have to be completed at one operation before a subsequent operation can commence.":
25920 "This field specifies the color used on the bar in the gantt chart for this record.":
26000 "This field defines the name of the changeover group":
26100 "This field sets the amount of changeover time that is incured when the attribute specified changes between operations scheduled next to one another.":
26200 "The display name of the user tool":
26210 "The event script which the user tool will run when selected":
26220 "the tool menu name of the user window":
26230 "The code function to poluate the user window contents":
26240 "the label of the user window":
26300 "The name of the menu button.  This gives an indication where the button will appear in the menu system":
26310 "This field controls whether the button is enabled and thefore whether it appears":
26320 "This field controls the text that will appear on the button":
26330 "The event script which the menu button will run when selected":
;
