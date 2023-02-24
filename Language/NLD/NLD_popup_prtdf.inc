#VERSION 0
;
NLD POPUP HELP
1 "Er is geen Help-onderwerp gekoppeld aan dit artikel.":
10 "Met dit veld wordt bepaald bij welke order dit onderdeel hoort. Bij de eerste bewerking van een order wordt dit ingesteld op BOVENLIGGEND, bij andere bewerkingen wordt dit ingesteld op het unieke ordernummer of de unieke naam.":
40 "Met dit veld wordt het onderdeelnummer bepaald. Bij het drukken op de knop verschijnen alle onderdeelnummers in de productgegevenstabel. De naam van het product wordt automatisch aangepast als u een onderdeelnummer selecteert.":
41 "Dit veld bevat een lijst met andere statussen die voor een order kunnen worden gedefinieerd. De waarden zijn ontleend aan de gegevenstabel Orderstatus, waarin indien nodig nieuwe statussen kunnen worden toegevoegd. Met een werkbalkpatroon, dat in de gegevenstabel Orderstatus voor elk type status kan worden ingesteld, kan het patroon van de werkbalk van de order worden gedefinieerd als de order is gepland in de Sequencer.":
45 "Met dit veld wordt het onderdeelnummer bepaald.":
50 "Met dit veld wordt de naam van het product bepaald. Gebruik de knop om de naam te selecteren; het onderdeelnummer wordt automatisch gewijzigd.":
55 "Met dit veld wordt de naam van het product bepaald.":
60 "Met dit veld wordt het ordernummer voor dit product bepaald. De volgorde kan een intern ordernummer zijn of een nummer dat wordt gespecificeerd door de klant. Het ordernummer moet uniek zijn.":
70 "In dit veld kunnen notities over deze order worden opgenomen. Dit zou een herinnering kunnen zijn met betrekking tot einddatums of simpelweg een bericht aan verpakkings-/assemblagemedewerkers op de werkvloer.":
75 "Hiermee opent u een dialoogvenster met alle Kenmerk-informatie voor de bewerking.":
80 "Met dit veld stelt u de prioriteit in voor de taak die op zijn beurt wordt gebruikt door de Sequencer. Hoe lager het nummer, hoe hoger de prioriteit. Prioriteiten kunnen negatief zijn; een negatieve prioriteit is hoger dan een positieve. Voorbeeld: -100 is hoger dan -1 en 0 is hoger dan 10.":
90 "In dit veld stelt u het bewerkingsnummer voor een taak in. Dit wordt gebruikt voor het bepalen van de taakreeks in de Sequencer. Bewerkingen met het laagste nummer worden voltooid vóór bewerkingen met een hoger nummer. Als er twee bewerkingen met hetzelfde nummer voorkomen binnen een product, worden beide voltooid voordat bewerkingen met een hoger nummer worden gestart.":
110 "Dit is een schriftelijke beschrijving of naam van de bewerking die plaatsvindt; wordt ook aangeduid met een bewerkingsnummer.":
112 "Hiermee opent u een dialoogvenster met informatie over de Resource-gegevens die zijn toegewezen aan deze bewerking.":
120 "Instelgroepen worden gedefinieerd in de gegevenstabel Instelgroepen, bijvoorbeeld Instelgroep 1, Instelgroep 2, enz. Deze waarden worden gebruikt als de assen van een van de reeksafhankelijke insteltijdmatrices, waarin de overgangstijd wordt bepaald tussen producten in verschillende instelgroepen (doorgaans ingesteld in de gegevenstabel Resources). Individuele instelgroepen worden toegewezen aan producten in de gegevenstabel Producten, hoewel deze standaardwaarde kan worden overschreven in het bestand Hoofdschema.":
130 "Dit veld bepaalt de groep geldige resources die de huidige bewerking kan uitvoeren.":
140 "Indien nodig, kan met dit veld een bepaalde resource worden bepaald die de bewerking moet verwerken. Als dit in de gegevenstabel Producten is ingesteld op 'Selecteren in groep' kan elk van de resources in de groep worden gebruikt in het veld Resourcegroep. Als u de bewerking wilt afdwingen voor een specifieke resource in de groep, gebruikt u de vervolgkeuzelijst voor het selecteren van de vereiste resource.":
150 "Dit veld geeft de werkelijke resource weer waarmee de bewerking wordt verwerkt. Als de order niet eerder is gepland, wordt dit ingesteld op 'Onbekend'. Als de bewerking al is geladen in het planbord, wordt de resource waarop deze momenteel is ingesteld, weergegeven.":
180 "Met dit veld wordt bepaald of het verwerkingstarief wordt berekend als tijd per batch, tijd per artikel of op aantal per uur. Als 'Tijd per batch' is geselecteerd, wordt de tijd genomen die wordt vermeld in het onderstaande veld om alle onderdelen in de batch te verwerken. Als 'Tijd per artikel' is geselecteerd, is de verwerkingstijd de waarde in het veld hieronder vermenigvuldigd met de batchgrootte. Als 'Aantal per uur' is geselecteerd, wordt de verwerkingstijd direct berekend vanuit het aantal in de batch.":
220 "U hebt momenteel ‘Tijd per artikel’ geselecteerd voor Type verwerkingstijd. Voer een bewerkingstijd voor elk artikel in dit veld in.":
230 "U hebt momenteel ‘Tijd per batch’ geselecteerd voor Type verwerkingstijd. Geef de totale bewerkingstijd voor de batch in dit veld in.":
240 "U hebt momenteel ‘Aantal per uur’ geselecteerd voor Type verwerkingstijd. Geef in dit veld aan hoeveel artikelen per uur kunnen worden geproduceerd.":
251 "Met behulp van de kleur in dit veld geeft de Sequencer een gedeelte van het Gantt-diagram weer in een andere kleur. De balk krijgt een kleur op basis van de waarde die is ingevoerd in de velden Gem. batchaantal en Gem. batchtijd.":
260 "In dit veld geeft u het order- of batchaantal op.":
270 "In dit veld geeft u de order- of batchwinst op. U kunt dit veld gebruiken voor het beïnvloeden van de reeks bij het gebruik van de wegingsregel.":
280 "In dit veld wordt de begintijd van de eerste bewerking in deze order weergegeven als de MakeSpan-functie is ingeschakeld":
290 "In dit veld wordt de eindtijd van de laatste bewerking in deze order weergegeven als de MakeSpan-functie is ingeschakeld":
300 "Deze waarde bepaalt het aantal dat moet worden verwerkt voordat de volgende bewerking kan worden gestart. Een waarde Onbekend voorkomt dat de bewerkingen elkaar overlappen.":
360 "Hiermee geeft u een datum op waarvóór de taak kan niet worden gestart. Dit kan bijvoorbeeld het tijdstip zijn wanneer de materialen beschikbaar zijn.":
370 "In dit veld geeft u de einddatum op. De einddatum wordt gebruikt om late artikelen in de Sequencer te markeren en prioriteit toe te kennen aan het laden van taken op het planbord als de optie 'Einddatum' is geselecteerd.":
380 "Selecteer deze schakelaar om de Scheduler te laten zien dat de tijden in de begintijd en de eindtijd 'werkelijke' waarden zijn. Als deze schakelaar is ingesteld, voorkomt u dat alle resources voor de order niet in de Sequencer worden toegewezen. In feite wordt de order permanent vastgezet op het planbord.":
390 "In de Scheduler wordt dit veld tijdens het sequencen ingesteld op de tijd waarop de taak volgens planning met het instellingsproces begint.":
400 "In de Scheduler wordt dit veld tijdens het sequencen bijgewerkt naar de tijd waarop de taak volgens planning begint.":
410 "In de Scheduler wordt dit veld tijdens het sequencen bijgewerkt naar de tijd waarop de taak volgens planning eindigt.":
420 "Stel deze schakelaar in als u niet wilt dat de toewijzing van deze taak ongedaan wordt gemaakt na het selecteren van Toewijzing alle taken ongedaan maken banen in de Sequencer. Hiermee wordt de bewerking vergrendeld. Dit kan ook gebeuren bij gebruik van de locatiemodus ‘Vergrendelde bewerkingen markeren’ in de Sequencer door met de muis te wijzen naar een bewerking (pictogram of balk in het overzicht), het loslaten van de Shift-toets op het toetsenbord en er met de linkermuisknop op klikken.":
421 "Bewerkingen waarvoor deze schakelaar is ingeschakeld, blijft niet-toegewezen in het venster Niet-toegewezen bewerkingen bij het automatisch plannen van bewerkingen.":
430 "Hiermee kunt u door de gebruiker definieerbare eigenschappen toewijzen aan producten, bijvoorbeeld kleur. Binnen een specifiek kenmerk krijgen kenmerkrecords een prioriteit; 'witte' producten kunnen bijvoorbeeld een hogere prioriteit hebben dan 'gele’ producten. Deze kenmerken worden gebruikt in de Voorkeursreeksregels in de Scheduler, waardoor soortgelijke orders binnen het vooruitkijkvenster worden geconsolideerd.":
440 "Vul de informatie over het voltooide aantal in en geef de tijd op waarin de 'onderdeelbatch' werd voltooid in het veld Gem. batchtijd. De 'Eindtijd' voor deze bewerking wordt automatisch opnieuw berekend door de Scheduler.":
450 "Vul de tijd in waarin de 'onderdeelbatch' werd voltooid en vul de informatie in over het voltooide aantal in het veld Gem. batchaantal. De 'Eindtijd' voor deze bewerking wordt automatisch opnieuw berekend door de Scheduler.":
460 "In het veld ‘Werkelijke bew.tijd’ wordt invoer in de velden ‘Gem. batchaantal’ en ‘Gem. batchtijd’ gebruikt om een herziene bewerkingstijd op basis van deze informatie te berekenen. Let op! Wil deze functie goed correct werken, dan moeten de velden ‘Gem. batchaantal’ en ‘Gem. batchtijd’ worden gewijzigd wanneer de Editor wordt weergegeven binnen de Sequencer, anders verandert de ‘Werkelijke bew.tijd’ pas de volgende keer dat de Sequencer wordt geopend.":
474 "Dit veld wordt gebruikt voor het vastleggen van de kosten van een artikel op het punt waar het wordt ingevoerd in het proces. Dit veld kan worden gebruikt voor het vastleggen van vaste kosten per artikel, zoals warmtebehandeling door een onderaannemer enzovoort.":
476 "De kostenpost Materiaalkosten per artikel wordt gebruikt ten behoeve van de materiaalkosten van de batch op het punt waar de kosten per artikel worden ingevoerd in het proces.":
477 "Directe kosten van de taak in het huidige proces.":
530 "Hiermee stelt u een tijdhorizon in waarin taken kunnen worden gebundeld voor de productie. Bij een resource ter voltooiing van een bewerking op het planbord wordt vanaf dat moment over de tijdhorizon in het vooruitkijkvenster gekeken. De Voorkeursreekscriteria, die zijn ingesteld in de gegevenstabel Resources, worden toegepast op bepaalde taken van de werkzaamheden, waarvan de vervaldata binnen deze tijdhorizon vallen. Het vooruitkijkvenster kan worden ingesteld voor afzonderlijke producten in de gegevenstabel Producten en worden aangepast voor afzonderlijke orders in het bestand Hoofdschema of er kan een algemene regel van worden gemaakt in de Configuratie-instellingsgegevens.":
540 "Vanuit de gegevenstabel Producten hebt u toegang tot een Word-document dat informatie betreffende het product kan bevatten. U kunt het document ook openen en bewerken vanuit de Hoofdschema-bestandseditor.":
541 "In dit veld wordt de voortgang van een afzonderlijke bewerking beschreven. Er zijn vier verschillende voortgangsstatussen: Niet gestart; Geïnstalleerd; In uitvoering; Voltooid":
550 "Producten kunnen bepaalde kenmerken hebben die ermee worden geassocieerd. In de Scheduler worden deze ondergebracht in de gegevenstabel Kenmerk. Deze tabellen zijn door de gebruiker gedefinieerd en de tabel Productkenmerk 1 kan bijvoorbeeld worden gereserveerd voor kleuren, waarmee afzonderlijke records kunnen worden benoemd: rood, blauw, groen enz. Productkenmerken kunnen worden geselecteerd in het veld Like to Like-overeenkomst in de productgegevenstabel om een Like to Like-installatietijd te definiëren.":
560 "Wordt gebruikt om een prioriteit tussen records in de gegevenstabel Productkenmerk 1 aan te brengen. Deze tabel wordt gebruikt door de reeksselectie in APS-regels.":
570 "Producten kunnen bepaalde kenmerken hebben die ermee worden geassocieerd. In de Scheduler worden deze ondergebracht in de gegevenstabellen Kenmerk. Deze tabellen zijn door de gebruiker gedefinieerd en de tabel Kenmerk 2 kan bijvoorbeeld worden gereserveerd voor materialen, waarmee afzonderlijke records kunnen worden benoemd: staal, messing, koper enz. Productkenmerken kunnen worden geselecteerd in het veld Like to Like-overeenkomst in de productgegevenstabel om een Like to Like-installatietijd te definiëren.":
580 "Wordt gebruikt om een prioriteit tussen records in de gegevenstabel Productkenmerk 2 aan te brengen. Deze tabel wordt gebruikt door de reeksselectie in APS-regels.":
590 "Producten kunnen bepaalde kenmerken hebben die ermee worden geassocieerd. In de Scheduler worden deze ondergebracht in de gegevenstabellen Kenmerk. Deze tabellen zijn door de gebruiker gedefinieerd en de tabel Kenmerk 3 kan bijvoorbeeld worden gereserveerd voor materiaalbreedten, waarmee afzonderlijke records kunnen worden benoemd: 16', 18', 20', 24' enz. Productkenmerken kunnen worden geselecteerd in het veld Like to Like-overeenkomst in de productgegevenstabel om een Like to Like-installatietijd te definiëren.":
600 "Wordt gebruikt om een prioriteit tussen records in de gegevenstabel Productkenmerk 3 aan te brengen. Deze tabel wordt gebruikt door de reeksselectie in APS-regels.":
602 "In dit veld wordt de duur van de hele order berekend, van de start van de insteltijd voor de eerste bewerking tot de eindtijd van de laatste bewerking van de order.":
620 "Een verzendingsregel waarmee een indexnummer wordt berekend door de resterende tijd tot de einddatum te delen door de verwachte verstreken tijd om de taak te voltooien. Een verhouding van minder dan 1 wijst erop dat de taak achterloopt op schema, hoger dan 1 geeft aan dat de taak voorloopt op schema.":
815 "Met deze optie kunt u waarden voor Installatie- en bewerkingstijden instellen. Deze optie wordt ook gebruikt voor het bijwerken van de voortgang van taken door het productiesysteem.":
1020 "Hiermee geeft u de naam van de resourcegroep op. Deze wordt gebruikt voor het identificeren van specifieke groepen resources, waarmee een vergelijkbare functie kan worden uitgevoerd.":
1030 "Hiermee bepaalt u de geldige resources voor de resourcegroep. Een resource kan deel uitmaken van meer dan één groep.":
1060 "Als deze schakelaar is ingeschakeld, wordt een gebruiksplot voor de resourcegroep weergegeven in het multiplotvenster van de Sequencer.":
1070 "Deze kleur wordt weergegeven in de gebruiksplot die zichtbaar is in het multiplotvenster van de Sequencer.":
1080 "In de gebruiksplot, aanwezig in het multiplotvenster van de Sequencer, wordt deze kleur weergegeven wanneer het gebruik het aantal beschikbare uren voor de resource of resourcegroep overschrijdt (als het veld Max. uren gebruik is ingesteld als Onbekend). Als er een waarde is ingevoerd in het veld Max. uren gebruik, verandert de plot van kleur volgens deze waarde.":
1090 "In de gebruiksplot in het multiplotvenster van de Sequencer, wordt deze kleur gebruikt om een lijn te trekken die het gebruik van de Installatie in uren aangeeft.":
2020 "Hiermee geeft u de naam van de afzonderlijke Resource op.":
2023 "Het uurtarief voor het gebruik van de resource.":
2024 "Hiermee past u 'Kostenfactor%'-waarden toe in de masterkalenderrecords op het uurtarief van de resource.":
2030 "Dit dialoogvenster bevat informatie over de manier waarop een resource of resourcegroep wordt weergegeven in het venster Volgordeoverzicht en Gebruiksberekeningen.":
2040 "Deze optie kan worden ingesteld op Zichtbaar, Geminimaliseerd of Uitgeschakeld. Wordt gebruikt om de aanvankelijke status van dit resourcevenster te beheren wanneer de Sequencer wordt gestart. Normaal gesproken is dit venster ingesteld op Geminimaliseerd. Indien dit is ingesteld op Uitgeschakeld, wordt de resource niet gebruikt voor reeks.":
2050 "Hiermee bepaalt u de horizontale (tijd)schaal van de Gantt-resourcevensters in de Sequencer. Kan variëren van minuten tot weken per eenheid.":
2070 "Hiermee kunt u een resourcecapaciteit instellen op Eindig, Oneindig of Oneindig met ploegenpatronen.":
2071 "Hiermee kunt u een resourcecapaciteit instellen op Eindig, Oneindig of Oneindig met ploegenpatronen als deze werkt in de Sequencer-modus met oneindige capaciteit.":
2080 "Hiermee bepaalt u de horizontale (tijd)schaal van de resourcevensters naast elkaar in de Sequencer.":
2100 "Hiermee selecteert u de secundaire beperkingen die worden toegepast op een primaire resource. U bepaalt de beperkende hoeveelheid die nodig is voor de resource en de wijze waarop de beperking wordt toegepast op de primaire resource.":
2110 "Hiermee bepaalt u wanneer het gebruik van de secundaire resource moet toenemen of afnemen, bijvoorbeeld bij Verhogen voor duur, waarmee de secundaire beperking voor de duur van de bewerking geldt en bij voltooiing wordt vrijgegeven. Als een taak wordt geplaatst op een aansluiting voor verschillende bewerkingen wordt geplaatst, kan Toenemen bij Start voor de eerste bewerking en Afnemen bij voltooiing voor de laatste bewerking worden opgegeven. Hiermee zorgt u ervoor dat de aansluiting niet kan worden gebruikt voor een andere taak, terwijl de eerste taak in de wachtrij staat voor een resource.":
2120 "Hiermee geeft u het vereiste aantal op van de secundaire beperking. Als de waarde ‘Aantal’ is geselecteerd, is het vereiste aantal gelijk aan het batchaantal dat wordt verwerkt.":
2130 "Hiermee definieert u een kenmerk van een bewerking die voorkomt dat ongelijke bewerkingen gelijktijdig worden uitgevoerd op een resource met een oneindige capaciteit.":
2150 "Wordt gebruikt in APS-producten om de criteria te bepalen voor de voorkeursreeksregels bij de selectie van werkzaamheden voor verwerking.":
2160 "Wordt via de planningsregels in 'WIP minimaliseren' gebruikt om de tijdbuffers vast te stellen waarin WIP kan groeien vóór de geselecteerde resources.":
2180 "Een numerieke waarde waarmee de volgorde wordt gesorteerd waarin resources worden weergegeven in de gegevenstabel Resources. Deze waarde kan ook worden gebruikt om de standaardvolgorde te negeren waarin resources worden weergegeven in het reeksoverzicht.":
2181 "Hiermee geeft u het dialoogvenster weer waarin, indien vereist, geavanceerde resourcebeperkende opties kunnen worden gedefinieerd.":
2182 "Hiermee kunt u complexe interresourcerelaties met behulp van expressies definiëren. Details van de expressiesyntaxis en het maken ervan vindt u in de documentatie.":
2183 "Hiermee kan de gebruiker een kenmerk van een bewerking op een resource met een oneindige capaciteit kiezen, waarmee wordt aangegeven dat alleen bewerkingen met dezelfde waarde in het geselecteerde kenmerk op hetzelfde moment kunnen worden gepland.":
2185 "Hiermee bepaalt u of er een scheidingslijn onder de resource op het Gantt-diagram wordt weergegeven. Dit kan helpen bij het visualiseren van resources in groepen.":
2190 "Hiermee bepaalt u de wijze waarop de resource wordt getoond in het Volgordeoverzicht. De alternatieven zijn 'Altijd', 'Alleen in groep' en 'Verbergen'.":
2191 "Hiermee bepaalt u de manier waarop de bewerkingen worden weergegeven in het Volgordeoverzicht. De opties zijn 'Gestapeld' waarbij de bewerkingen worden weergegeven op één overzichtsregel, en 'Trapsgewijs' waarbij elke bewerking op een aparte overzichtsregel wordt weergegeven.":
2200 "Wordt gebruikt om een matrix van reeksafhankelijke instelwaarden vast te stellen, waarmee de vereiste insteltijd voor het wijzigen van een product met het ene kenmerktype naar het andere wordt gedefinieerd.":
2201 "In dit veld stelt u in welke omstelgroep wordt toegewezen aan deze resource en bepaalt u dientengevolge welke omsteltijden tussen bewerkingen met verschillende kenmerken worden toegepast.":
2202 "Hiermee bepaalt u of de in- en omsteltijden van de bewerkingen op deze resource gelijktijdig of cumulatief worden toegepast.":
2205 "Als u dit selectievakje inschakelt, wordt de resource niet in de berekeningen van de planningsprestatiemaatstaven opgenomen.":
2210 "In dit veld selecteert u tot welk Viewer-systeem de resource behoort. Het veld bevat een lijst met Scheduler-systeemnamen die afkomstig zijn uit de gegevenstabel van het PCO-adresboek.":
2220 "Met deze knop opent u een dialoogvenster met de verschillende kenmerken die aan de resource zijn gekoppeld.":
2230 "In dit veld kunt u tekenreekskenmerkgegevens invoeren voor de resource.":
2240 "In dit veld voert u werkelijke kenmerkgegevens in voor de resource.":
2250 "In dit veld voert u duurkenmerkgegevens in voor de resource.":
2260 "Dit veld bevat de efficiëntie van een resource; de standaardwaarde is 100%. Als de efficiëntie wordt gewijzigd in 200%, worden alle bewerkingen die voor deze resource zijn gepland, tweemaal zo snel verwerkt (de helft van de reguliere verwerkingstijd).":
2270 "Dit is een schakelaarveld waarmee, als het is ingeschakeld, de waarde in het veld Efficiëntie% wordt toegepast op alle bewerkingen die insteltijden bevatten en zijn gepland voor de resource waarop de schakelaar is ingesteld.":
2280 "Als deze schakelaar is ingeschakeld, wordt een gebruiksplot voor de resource weergeven in het multiplotvenster van de Sequencer.":
2300 "Gebruik dit veld om een groep met secundaire beperkingen te selecteren, waarbij een secundaire beperking wordt toegewezen bij sequentiëring.":
2310 "De secundaire beperking die vanuit de groep met secundaire beperkingen is toegekend, wordt aan dit veld toegewezen.":
5035 "Een kostenfactorvermenigvuldiging die van invloed is op de lopende kosten voor de resource waarop deze is toegepast. Een waarde van 100% betekent geen verhoging. Bij een waarde van 150% nemen de lopende kosten met 50% toe. De kostenfactorvermenigvuldiging is vastgesteld in de gegevenstabel Kalenderstatussen en bepaalt de standaardwaarden die worden gebruikt in de Masterkalenderbestanden.":
6100 "Hiermee wordt een dialoogvenster weergegeven waarmee wordt bepaald welke resources in de geselecteerde groep geldig zijn en waarin resourcespecifieke gegevens worden toegewezen.":
6110 "In dit veld bepaalt u of de resource tijdens een automatische reeks wordt geselecteerd. Als dit selectievakje niet wordt ingeschakeld, kan de bewerking nog steeds handmatig worden ingesteld op de resource.":
6120 "In dit veld stelt u een afzonderlijke insteltijdwaarde in die moet worden vastgesteld voor elk van de resources die geldig zijn voor de bewerking.":
6130 "In dit veld schakelt u een afzonderlijke insteltijdwaarde in die moet worden vastgesteld voor elk van de resources die geldig zijn voor de bewerking.":
6131 "In dit veld schakelt u een afzonderlijk aantal per uur in dat moet worden vastgesteld voor elk van de resources die geldig zijn voor de bewerking.":
6132 "In dit veld schakelt u een afzonderlijke tijd per batch in die moet worden vastgesteld voor elk van de resources die geldig zijn voor de bewerking.":
6140 "In dit veld definieert u een secundaire resource die wordt gebruikt door de primaire resource tijdens de huidige bewerking.":
6150 "In dit veld geeft u op hoe de secundaire beperking wordt gebruikt tijdens de bewerking, bijvoorbeeld Verhogen voor duur, Alleen insteltijd verhogen, enz.":
6160 "In dit veld geeft u het aantal van de secundaire beperking aan dat tijdens de huidige bewerking is vereist. U kunt bijvoorbeeld opgeven dat de bewerking één Vaste houder vereist.":
6170 "In de Scheduler wordt deze periode gebruikt om te proberen de huidige bewerking in de gewenste resource te laden. Als dit niet lukt vóór het einde van deze tijd, wordt geprobeerd de bewerking in andere resources in de groep te laden.":
6180 "Met Volgende resourcegroep instellen stelt u een 'geforceerde lijst’ met resources in, dat wil zeggen de resources die zijn opgegeven in de geselecteerde groep. Downstream- of latere bewerkingen worden 'geforceerd' alleen die resources te gebruiken die zich in de 'geforceerde lijst’ bevinden. Dus als een verwerkingsroute een resourcegroep aanroept op een downstreambewerking met enkele resources die geen lid zijn van de lijst, zouden deze niet tijdens de reeks worden gebruikt. Volgende resourcegroep instellen is een accumulatieve functie en kan worden gebruikt voor meer dan één bewerking in een verwerkingsroute om resources toe te voegen aan de 'geforceerde lijst'.":
6190 "Met de functie Volgende resourcegroep resetten verwijdert u alle resources die zich bevinden in de geselecteerde resourcegroep vanuit de 'geforceerde lijst' die is ingesteld via de opdracht Volgende resourcegroep instellen. Als een conceptuele resourcegroep, 'Alle', is ingesteld met alle beschikbare resources, zouden de resources die door volgende bewerkingen worden gebruikt, de bewerkingen zijn die waren ingesteld in de oorspronkelijke verwerkingsroute.":
6230 "In dit veld kunt u een insteltijd opgeven die wordt geconverteerd vanuit het vorige product naar het huidige product. Waarden in het veld Insteltijd worden toegevoegd aan alle instelwaarden die voor de resource via een Volgordeafhankelijke insteltijdmatrix zijn ingesteld.":
6430 "Selecteer de naam van een pictogram in het vervolgkeuzevak. Met de knop Bewerken maakt u nieuwe pictogrammen.":
6470 "Hiermee wordt het dialoogvenster Geldige secundaire beperkingen weergegeven, waarmee geldige beperkingen worden toegepast op afzonderlijke records in deze tabel. De kenmerken van gebruik van beperking kunnen hier ook worden bewerkt.":
6530 "Hiermee geeft u het maximale tijdinterval op dat is toegestaan tussen twee opeenvolgende bewerkingen. Het maximale tijdinterval wordt gekwalificeerd door het veld 'Type interval’ waarin 'Begin-tot-begin'-, 'Einde-tot-einde'-relaties enz. zijn vastgesteld":
6540 "Hiermee bepaalt u de relatie voor het maximale tijdinterval tussen twee opeenvolgende bewerkingen, ingesteld in het veld 'Max. tijd vóór de volgende bewerking'. Dit is wellicht een 'Einde-tot-einde'-, 'Einde-tot-begin'-, 'Begin-tot-begin'- of 'Begin-tot-einde'-relatie.":
6550 "Hiermee geeft u de maximale hoeveelheid tijd op, uitgedrukt als een percentage van de theoretische verwerkingstijd, waarmee een bewerking kan worden verlengd als de reeks hiervan automatisch is bepaald door de Sequencer.":
6560 "Hiermee definieert u een bepaalde hoeveelheid toegestane vertraging tussen deze bewerking en de vorige.":
6565 "Hiermee definieert u een bepaalde hoeveelheid toegestane vertraging tussen deze bewerking en de volgende.":
6580 "In dit veld kan past u een verwerkingsaantalvermenigvuldiging toe op de bewerkingsduur.":
6681 "In dit veld geeft u een kenmerk van dit record op waarnaar wordt verwezen vanuit een van de kenmerktabellen. Deze kunnen worden gebruikt bij de insteltijden, de planningsvolgorde en het gebruik van beperking.":
6682 "In dit veld geeft u een willekeurige tekenreeksnotatie van dit record op. Hiermee kunt u weergaveopties en groepsbewerkingen instellen.":
6683 "In dit veld geeft u een numeriek kenmerk van dit record op. Hiermee kunt u weergaveopties instellen, de planningsvolgorde en het gebruik van beperking bepalen.":
6684 "In dit veld geeft u een datumkenmerk van dit record op. Hiermee kunt u weergaveopties instellen en de planningsvolgorde bepalen.":
6685 "In dit veld geeft u een duurkenmerk van dit record op. Hiermee kunt u weergaveopties instellen en de planningsvolgorde bepalen.":
6690 "Het veld Leveringsbuffer bevat een buffertijd die wordt afgetrokken van de Einddatum bij de terugwaartse reeks, zodanig dat de bewerkingen eerder dan de laatste mogelijke tijd worden gepland. Dit wordt gedaan om onverwachte vertragingen in het proces mogelijk te maken.":
7020 "Het aantal dagen vóór de huidige tijd die kan worden weergegeven in het Volgordeoverzicht.":
7030 "De periode na de huidige tijd die kan worden weergegeven in het Volgordeoverzicht.":
7035 "Hiermee opent u een configuratie-insteldialoogvenster waarmee de gebruiker het Volgordeoverzicht kan aanpassen.":
7040 "Hiermee geeft u een offset op vanaf de orderinvoer, waarvoor een taak niet kan worden gestart. Als deze optie is ingesteld op Onbekend, geldt er geen beperking, anders dan de huidige tijd.":
7050 "Hiermee geeft u een offset op vanaf de orderinvoer, waarvoor een taak beschikbaar moet zijn. Kan worden overschreven.":
7060 "De hoeveelheid tijd waarmee de scheidslijn is verschoven ten opzichte van de huidige tijd. De scheidslijn vertegenwoordigt de huidige tijd als de scheidslijnmarge is ingesteld op 0 uur 00 min.":
7067 "Hiermee bepaalt u de kostenberekeningsopties: Tijdens reeks, Na reeks of Nooit.":
7120 "Hiermee stelt u de Volgordeoverzicht-modus in.":
7130 "Het aantal dagen vanaf nu om te beginnen met het Volgordeoverzicht.":
7140 "Het aantal dagen vanaf nu om te eindigen met het Volgordeoverzicht.":
7320 "Hiermee maakt u het mogelijk dat in het vereiste script orders kunnen worden geselecteerd en geïmporteerd uit de gegevenstabel 'Scripts'.":
7330 "Hiermee maakt u het mogelijk dat in het vereiste script orders kunnen worden geselecteerd en geëxporteerd uit de gegevenstabel 'Scripts'.":
7430 "Dit is een schakelaarveld waarmee, als het is ingeschakeld, een zwart driehoekje verschijnt voor elke bewerkingsbalk in de Sequencer. Hiermee kunnen bewerkingen die zijn toegewezen op het planbord gemakkelijker worden versleept, vooral kleinere bewerkingen.":
7450 "Hiermee bepaalt u het standaard PESP-gebeurtenisscript dat moet worden uitgevoerd bij het importeren van orders via de knop 'Orders importeren' in het menu Gegevensoverdracht.":
7470 "Hiermee bepaalt u het standaard PESP-gebeurtenisscript dat moet worden uitgevoerd bij het exporteren van orders via de knop 'Orders exporteren' in het menu Gegevensoverdracht.":
7480 "Hiermee bepaalt u het standaard PESP-gebeurtenisscript dat moet worden uitgevoerd bij het vrijgeven van een schema via de knop 'Schema vrijgeven' in het menu Gegevensoverdracht.":
7490 "Hiermee bepaalt u het standaard PESP-gebeurtenisscript dat moet worden uitgevoerd bij het toewijzen van bewerkingen in de Sequencer als de optie APS-regels is ingeschakeld.":
8020 "De naam van de secundaire beperking.":
8030 "Hiermee kunt u de kleur van het gebruikersplot in de Sequencer selecteren als de waarden tussen de hoge en lage grenzen liggen.":
8040 "Hiermee stelt u het opvulpatroon van de plot in.":
8060 "Plotopvulkleur als het plot de bovenste plotgrens overschrijdt.":
8080 "Plotopvulkleur als het plot de onderste plotgrens overschrijdt.":
8090 "Hiermee geeft u aan of deze secundaire beperking beperking het schema moet beperken bij gebruik van een 300 FCS-product of hoger. In alle versies wordt het verstrekken van waarschuwingen in de Sequencer bij overschrijding van de grenzen voor deze secundaire beperking gestopt als dit selectievakje niet is ingeschakeld.":
8091 "Met dit veld geeft u in de Sequencer-modus met oneindige capaciteit aan of deze secundaire beperking het schema moet beperken bij gebruik van een 300 FCS-product of hoger.":
8092 "Opties voor het beheren van het gedrag van deze beperking als het systeem is ingesteld op de modus met oneindige capaciteit":
8100 "Hiermee bepaalt u hoe de efficiëntie van de primaire resourcekalender van invloed is op het gebruik van deze secundaire beperking. Opties zijn: Geen effect; Taakefficiëntie starten; Efficiëntiewijzigingen volgen; 100% gebruiken indien groter dan 0%.":
8101 "Met dit veld geeft u in de Sequencer-modus met oneindige capaciteit aan hoe de efficiëntie van de primaire resourcekalender van invloed is op het gebruik van deze secundaire beperking. Opties zijn: Geen effect; Taakefficiëntie starten; Efficiëntiewijzigingen volgen; 100% gebruiken indien groter dan 0%.":
8120 "Met deze knop opent u een dialoogvenster met de verschillende kenmerken die aan de secundaire beperking zijn gekoppeld.":
8130 "In dit veld voert u echte kenmerkgegevens in voor de secundaire beperking.":
8140 "In dit veld voert u echte kenmerkgegevens in voor de secundaire beperking.":
8150 "In dit veld voert u duurkenmerkgegevens in voor de secundaire beperking.":
8160 "Als deze schakelaar is ingeschakeld, wordt een gebruiksplot voor de secundaire beperking weergegeven in het multiplotvenster van de Sequencer.":
8200 "De naam van de groep met secundaire beperkingen.":
8210 "Hiermee kunt u selecteren welke secundaire beperkingen deel uitmaken van deze groep.":
9020 "Groepsnamen instellen; deze vormen de X- en Y-as van de Volgordeafhankelijke insteltijdmatrix in de gegevenstabel Resources.":
12020 "Naam van een kenmerkrecord in de gegevenstabel Productkenmerk 1.":
13020 "Naam van een kenmerkrecord in de gegevenstabel Productkenmerk 2.":
14020 "Naam van een kenmerkrecord in de gegevenstabel Productkenmerk 3.":
16020 "De naam waarmee de schermweergaveconfiguratie is opgeslagen onder de bestandsnaam. Deze beschrijving wordt ook gebruikt als tekstballon voor de pictogrammen op de werkbalk Werkruimte.":
16030 "Het betreffende bestand wordt gekozen door een bestand te kiezen vanuit de opties onder de knop aan de linkerkant van het veld. Het oorspronkelijke werkruimteconfiguratiebestand wordt opgeslagen met een WPI-bestandsextensie via de opdracht Werkruimte opslaan onder Werkruimte in het Sequencer-menu.":
18510 "De naam van de persoon of organisatie die een order plaatst.":
18520 "Naam van de primaire contactpersoon binnen een organisatie die een order plaatst.":
18530 "Te gebruiken telefoonnummer bij een order.":
18540 "Te gebruiken e-mailadres bij een order.":
21000 "In dit veld kunt u verschillende orderstatussen invoeren; de Orderstatus selecteert u bij een order in het schemabestand.":
21020 "In dit veld staat de betekenis van de orderstatusnaam die is ingevoerd in het veld 'Orderstatusnaam'.":
21100 "Naam van een kenmerkrecord in de gegevenstabel Kenmerk.":
21110 "Wordt gebruikt om een prioriteit tussen records in de gegevenstabel Kenmerk aan te brengen. Deze tabel wordt gebruikt bij de planningsregels.":
24000 "In dit veld geeft u aan of het record een bovenliggend record van de regelset of een onderliggend record is.":
24010 "Bevat de naam van de regelset.":
24020 "Met deze schakelaar worden behoeftentraceringslinks alleen gewist voor orders die in de wachtrij van de eerste gang (of deze nu is ingeschakeld of uitgeschakeld) door de regelset staan.":
24030 "Bevat de naam van de specifieke functie van de regelgang.":
24040 "Een schakelaar die, indien deze is ingesteld op Waar, de regelgang maakt. Indien deze schakelaar is ingesteld op Onwaar wordt deze bepaalde regelgang worden genegeerd bij het uitvoeren van de regelset.":
24050 "Als deze schakelaar is ingesteld op Waar en de regelset is uitgevoerd, wordt een foutopsporingsbestand gemaakt in de werkmap.":
24060 "In dit veld geeft u criteria op waarmee u beperkt welke artikelen worden geplaatst in de Interne aanbodwachtrij. De standaardwaarde voor dit veld is ingesteld als ALLE, maar deze waarde kan worden gewijzigd door het invoeren van een expressie, bijvoorbeeld (~{$Ordertype}~==~Voorraad~). Via deze wachtrij worden records in de database 'Werkorders' gefilterd.":
24070 "Dit veld bevat de criteria waarmee u de artikelen in de Interne aanbodwachtrij rangschikt. U kunt de Interne aanbodwachtrij rangschikken op Einddatum, Vroegste begindatum of Prioriteit.":
24080 "In dit veld geeft u criteria op waarmee u beperkt welke artikelen worden geplaatst in de Interne vraagwachtrij. De standaardwaarde voor dit veld is ingesteld als ALLE, maar deze waarde kan worden gewijzigd door het invoeren van een expressie, bijvoorbeeld (~{$Ordertype}~==~Voorraad~). Via deze wachtrij worden records in de database 'Werkorders' gefilterd.":
24090 "Dit veld bevat de criteria waarmee u de artikelen in de Interne vraagwachtrij rangschikt. U kunt de Interne vraagwachtrij rangschikken op Einddatum, Vroegste begindatum of Prioriteit.":
24100 "Dit veld bevat een lijst met verschillende standaardbehoeftentraceringsregels waarmee de behoeften van alle orders samen kunnen worden getraceerd. Dit veld bevat ook drie bijzondere opties: Door de gebruiker gedefinieerd, Gebruikersfunctie en PESP-script waarmee u meer aangepaste regels maakt.":
24110 "Dit veld is alleen zichtbaar als het veld ‘Regeltype’ is ingesteld op 'Door de gebruiker gedefinieerd' of op 'Gebruikersfunctie'. De expressie die moet worden gebruikt voor de regel wordt ingevoerd in dit veld. Een voorbeeld:(~{+:$Productkenmerk 1}~==~{-:$Productkenmerk 1}~), waardoor alleen aanbod- en vraagorders worden gekoppeld als het de velden 'Productkenmerk 1' dezelfde waarde hebben.":
24120 "Dit veld is alleen zichtbaar als het veld ‘Regeltype’ is ingesteld op 'PESP-script'. Dit veld bevat de naam van het PESP-script dat moet worden gebruikt als regel.":
24130 "Met deze optie kunt u links maken op stuklijstregels waarop de hoeveelheid van de stuklijstregel niet volledig hoeft te kloppen met de link, wil deze worden gemaakt. Alle artikelen die tekort zijn, worden gemarkeerd als tekort.":
24140 "Met deze optie kunt u alleen links maken op stuklijstregels waarop de hoeveelheid van de stuklijstregel volledig klopt. Alle artikelen die tekort zijn, worden gemarkeerd als tekort.":
24141 "Wanneer deze optie is ingeschakeld, wordt het standaardgedrag van SMC overschreven, omdat terugwaartse links mogen worden gemaakt als de productie na het verbruik plaatsvindt.":
24150 "Als deze optie is ingesteld op Waar, kunnen orders die al zijn gepland, een nieuwe koppeling krijgen.":
24160 "Als deze schakelaar is ingesteld op Waar, wordt het veld 'Prioriteit aanbodwachtrij' ingeschakeld, waardoor aanbodrecords worden gerangschikt volgens de selectiecriteria in het veld 'Prioriteit aanbodwachtrij'. Schakel deze optie alleen in als alle records in de database 'Werkorders' staan.":
24170 "In dit veld geeft u criteria op waarmee u beperkt welke artikelen worden geplaatst in de Externe aanbodwachtrij. De standaardwaarde voor dit veld is ingesteld als ALLE, maar deze waarde kan worden gewijzigd door het invoeren van een expressie, bijvoorbeeld (~{$Ordertype}~==~Voorraad~). Via deze wachtrij worden records in de database 'Vraag' gefilterd.":
24180 "Elk veld met de classificatie OVERNEMEN UIT AANBOD (veldnaam) wordt verwerkt.":
24190 "Elk veld met de classificatie OVERNEMEN UIT VRAAG (veldnaam) wordt verwerkt.":
24200 "Als deze schakelaar is ingesteld op Waar, wordt het veld 'Prioriteit vraagwachtrij' ingeschakeld, waardoor vraagrecords worden gerangschikt volgens de selectiecriteria in het veld 'Prioriteit vraagwachtrij'. Schakel deze optie alleen in als alle records in de database 'Werkorders' staan.":
24210 "De hoeveelheid van een gemaakte koppeling wordt toegewezen in specifieke veelvouden als deze schakelaar is ingesteld op Waar. Deze veelvoud wordt opgegeven in de Stuklijstgegevens.":
24500 "Als de veldschakelaar 'Deze regelset altijd gebruiken' is ingeschakeld, wordt de Koppelingsregelset die is geselecteerd in dit veld, de regelset die standaard wordt uitgevoerd als de optie 'Materialen koppelen' is geselecteerd in de Sequencer.":
24505 "Wanneer deze algemene optie is ingeschakeld, wordt het standaardgedrag van SMC overschreven, omdat terugwaartse links mogen worden gemaakt als de productie na het verbruik plaatsvindt.":
24510 "Als deze schakelaar is ingesteld, wordt de regel die is geselecteerd in het veld 'Geselecteerde regelset voor materiaalkoppeling' als standaardregel uitgevoerd als de optie 'Materialen koppelen' is geselecteerd in de Sequencer. Als de optie 'Deze regelset altijd gebruiken' niet is ingeschakeld, verschijnt er een selectiedialoogvenster als u 'Materialen koppelen' selecteert in de Sequencer. Hierdoor kunt u de uit te voeren regel op dat moment selecteren.":
25400 "Dit is het veld waarin het ordernummer van de aanbodorder staat.":
25410 "Dit veld bevat het type order, bijvoorbeeld Voorraad of Inkoop.":
25420 "De naam van de organisatie die de materialen voor de order levert.":
25430 "Het onderdeelnummer voor de order.":
25440 "Beschrijving van het onderdeel voor de order.":
25450 "Datum waarop het materiaal wordt geleverd.":
25500 "In dit veld geeft u aan voor welke order het onderdeel is bedoeld. De eerste orderregel van een order is het bovenliggende record en er wordt BOVENLIGGEND weergegeven in dit veld. De overige orderregels die deel van deze order uitmaken, zijn onderliggende records. Hiervoor wordt het ordernummer waartoe ze behoren, in dit veld weergegeven.":
25510 "Dit is het veld waarin het ordernummer van de vraagorder staat.":
25520 "Dit veld bevat het type order, bijvoorbeeld Voorraad of Verkooporder.":
25530 "Hiermee wordt een regelitem van een order uniek geïdentificeerd.":
25540 "De naam van de organisatie die de materialen voor de order nodig heeft.":
25550 "Datum waarop het materiaal nodig is.":
25560 "Hiermee geeft u het veelvoud van een artikel op waarvoor een koppeling geldt. Vaak vormen een aantal artikelen een doos of een krat. Bijvoorbeeld: 12 blikjes vormen 1 doos; er komt een order  binnen voor 60 blikjes. Er is een aanbodorder voor 50 blikjes. Materiaalbeheer hanteert enkel een koppeling voor 48 blikjes van de 50 en kijkt elders naar de resterende 12 blikjes die nodig zijn, maar maakt de koppeling alleen als het exacte aantal van 12 is gevonden. Het veld 'Alleen veelvouden toewijzen' moet zijn ingeschakeld in de database 'Koppelingsregels' om deze functie in te schakelen.":
25600 "Ordernummer waartoe de stuklijstregel behoort.":
25605 "Onderdeelnummer van de order waartoe die stuklijstregel behoort.":
25610 "Bewerkingsnummer waartoe de stuklijstregel behoort.":
25611 "Naam van de bewerking waartoe de stuklijstregel behoort.":
25615 "Onderdeelnummer van het product waarvoor het opgegeven materiaal nodig is.":
25620 "Onderdeelnummer van het stuklijstartikel.":
25630 "Vereiste hoeveelheid van het stuklijstartikel.":
25640 "Als dit veld is ingesteld op Waar, wordt de hoeveelheid van de order vermenigvuldigd met het vereiste stuklijstaantal.":
25650 "Hiermee worden tekorten genegeerd bij het uitvoeren van de lopende koppelingsregel. Hiermee kunt u orders met tekorten plannen.":
25700 "Ordernummer waarin co-product wordt geproduceerd.":
25705 "Onderdeelnummer van de order waarin co-product wordt geproduceerd.":
25710 "Bewerkingsnummer waarmee co-product wordt geproduceerd.":
25715 "Bewerkingsnaam waarmee co-product wordt geproduceerd.":
25720 "Naam van co-product.":
25730 "Hoeveelheid geproduceerd co-product.":
25740 "Als dit veld is ingesteld op Waar, wordt de hoeveelheid van het co-product vermenigvuldigd met de orderhoeveelheid.":
25800 "Dit veld bevat het type order, bijvoorbeeld Werkorder, Inkopporder, Verkooporder of Voorraad.":
25810 "Als dit vakje is ingeschakeld, wordt de ongeplande bewerking niet meer weergegeven in het venster 'Ongeplande bewerkingen'.":
25820 "Hiermee wordt een dialoogvenster weergeven met velden die betrekking hebben op Materiaalbeheer.":
25830 "Dit veld bevat informatie over de status van de vraag nadat de materialenkoppeling heeft plaatsgevonden. Dit veld bevat een van de volgende waarden: 'Onbekend', 'Tevreden', 'Alle tekorten genegeerd', 'Tekorten', 'Overaanbod', 'Overaanbod, tekorten', 'Overaanbod, alle tekorten genegeerd'.":
25840 "Dit veld wordt gevuld nadat de materialenkoppeling heeft plaatsgevonden. Wanneer een koppeling naar een aanbodorder in de database 'Aanbodorders' is gemaakt, wordt het veld 'Vraagdatum' in de database 'Werkorders' gevuld met de ‘Aanboddatum’ van de aanbodorder. Het veld 'Aanboddatum' wordt beoordeeld ten opzichte van het veld 'Vroegste begindatum' en de laatste datum wordt gebruikt om te bepalen welke datum bij het plannen moet worden gebruikt.":
25850 "Dit veld wordt gevuld nadat de materialenkoppeling heeft plaatsgevonden. Wanneer een koppeling naar een vraagorder in de database 'Vraagorders' is gemaakt, wordt het veld 'Aanboddatum' in de database 'Werkorders' gevuld met de ‘Vraagdatum’ van de vraagorder waaraan deze is gekoppeld. Het veld 'Vraagdatum' wordt beoordeeld ten opzichte van het veld 'Einddatum' en de vroegste datum wordt gebruikt om te bepalen welke datum bij het plannen moet worden gebruikt.":
25900 "Hiermee wordt een dialoogvenster weergeven met velden die betrekking hebben op de status van een bewerking.":
25910 "U kunt deze optie selecteren als een order wordt gesplitst. Met deze optie kan elke productiepartij onafhankelijk door het fabricageproces worden geleid; alle partijen hoeven bijvoorbeeld niet in één bewerking te worden voltooid voordat een verdere bewerking kan beginnen.":
25920 "In dit veld geeft u de kleur van de staaf op voor dit record in het Gantt-diagram.":
26000 "In dit veld geeft u de naam van de omstelgroep op.":
26100 "In dit veld bepaalt u de hoeveelheid omsteltijd die gepaard gaat met kenmerkspecifieke wijzigingen tussen bewerkingen die naast elkaar zijn gepland.":
26200 "De weergavenaam van de gebruikerstool.":
26210 "Het script voor de gebeurtenis waarin de gebruikerstool wordt uitgevoerd, indien deze is geselecteerd.":
26220 "De naam van het toolemenu in het gebruikersvenster.":
26230 "De codefunctie voor het vullen van de inhoud in het gebruikersvenster.":
26240 "Het label van het gebruikersvenster.":
26300 "De naam van de menuknop. Deze naam geeft een indicatie waar de knop wordt weergegeven in het menusysteem.":
26310 "In dit veld bepaalt u of de knop is ingeschakeld en of deze al dan niet wordt weergegeven.":
26320 "In dit veld bepaalt u de tekst die op de knop wordt weergegeven.":
26330 "Het script voor de gebeurtenis waarin de menuknop actief is, indien deze is geselecteerd.":
;
