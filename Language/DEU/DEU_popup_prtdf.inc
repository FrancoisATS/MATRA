#VERSION 0
;
DEU POPUP HELP
1 "Diesem Element ist kein Hilfethema zugeordnet.":
10 "Mit diesem Feld wird gekennzeichnet, zu welchem Auftrag das Teil gehört. Im ersten Vorgang eines Auftrags wird das Feld auf PARENT (Überordnung) festgelegt, in weiteren Vorgängen wird es auf die eindeutige Auftragsnummer oder den eindeutigen Auftragsnamen festgelegt.":
40 "Mit diesem Feld wird die Teilenummer bestimmt. Wird auf die Schaltfläche geklickt, werden alle Teilenummern in der Produkte-Datentabelle angezeigt. Wird eine Teilenummer ausgewählt, wird automatisch der Name des Produkts geändert.":
41 "Dieses Feld enthält eine Liste der unterschiedlichen Status, die einem Auftrag zugewiesen werden können. Die Werte werden aus der Auftragsstatus-Datentabelle entnommen, in der ggf. neue Status hinzugefügt werden können. Ein Vorgangsbalkenmuster, das in der Auftragsstatus-Datentabelle für jeden Statustyp festgelegt ist, kann dazu verwendet werden, das Muster des Vorgangsbalkens eines Auftrags zu definieren, wenn der Auftrag im Sequencer geplant wird.":
45 "Mit diesem Feld wird die Teilenummer bestimmt.":
50 "Mit diesem Feld wird der Name des Produkts bestimmt. Verwenden Sie die Schaltfläche, um den Namen auszuwählen. Die Teilenummer wird automatisch geändert.":
55 "Mit diesem Feld wird der Name des Produkts bestimmt.":
60 "Mit diesem Feld wird die Auftragsnummer für dieses Produkt bestimmt. Die Auftragsnummer kann eine interne Auftragsnummer oder eine vom Kunden angegebene Nummer sein. Die Auftragsnummer muss eindeutig sein.":
70 "Dieses Feld kann Anmerkungen zu diesem Auftrag enthalten. Dies kann eine Erinnerung hinsichtlich des Fälligkeitsdatums oder einfach eine Mitteilung an den Verpacker/Monteur in der Produktionshalle sein.":
75 "Öffnet ein Dialogfeld, in dem alle Attributinformationen für den Vorgang angezeigt werden.":
80 "Mit diesem Feld legen Sie die Priorität für die Aufgabe fest, die vom Sequencer verwendet wird. Je niedriger die Zahl ist, desto höher ist die Priorität. Eine Priorität kann negativ sein: Eine negative Priorität ist höher als eine positive. Beispielsweise ist -100 höher als -1 und 0 höher als 10.":
90 "Mit diesem Feld wird die Vorgangsnummer für eine Aufgabe festgelegt. Die Nummer wird verwendet, um die Aufgabe in die Reihenfolge im Sequencer einzusortieren. Die Vorgänge mit den niedrigsten Nummern werden vor Vorgängen mit höheren Nummern ausgeführt. Gibt es in einem Produkt zwei Vorgänge mit derselben Nummer, werden beide Vorgänge ausgeführt, bevor mit Vorgängen begonnen wird, die höhere Nummern haben.":
110 "Dies ist eine Beschreibung oder der Name des Vorgangs, der ausgeführt wird. Der Vorgang ist auch durch die Vorgangsnummer gekennzeichnet.":
112 "Öffnet ein Dialogfeld, das Informationen zu den Ressourcendaten enthält, die diesem Vorgang zugewiesen sind":
120 "Rüstgruppen sind in der Rüstgruppen-Datentabelle definiert, z. B. 'Rüstgruppe 1', 'Rüstgruppe 2' usw. Diese Werte werden als Zeilen für eine der Matrizen für planungsabhängige Rüstzeiten verwendet. Mit diesen Matrizen werden die Umrüstzeiten zwischen Produkten in unterschiedlichen Rüstgruppen festgelegt (üblicherweise eingerichtet in der Ressourcen-Datentabelle). Einzelne Rüstgruppen sind Produkten in der Produkte-Datentabelle zugewiesen, obwohl der Standardwert in der Hauptzeitplan-Datei überschrieben werden kann.":
130 "Dieses Feld gibt die Gruppe gültiger Ressourcen an, die den aktuellen Vorgang ausführen können.":
140 "Bei Bedarf kann dieses Feld dazu verwendet werden, eine bestimmte Ressource anzugeben, die den Vorgang ausführen soll. Ist die Produkte-Datentabelle auf 'Aus Gruppe auswählen' festgelegt, kann jede der Ressourcen aus der Gruppe verwendet werden, die im Feld 'Ressourcengruppe' angezeigt wird. Wenn Sie den Vorgang für eine bestimmte Ressource aus der Gruppe erzwingen möchten, wählen Sie die geforderte Ressource in der Dropdownliste aus.":
150 "Dieses Feld zeigt die tatsächliche Ressource, von der der Vorgang ausgeführt wird. Wurde der Auftrag noch nicht geplant, wird dieses Feld auf 'Nicht festgelegt' eingestellt. Wurde der Vorgang bereits in die Plantafel geladen, wird die Ressource angezeigt, die momentan als zu ladende Ressource festgelegt ist.":
180 "Mit diesem Feld wird angegeben, ob der Bearbeitungssatz als Zeit pro Charge, Zeit pro Artikel oder Durchsatz/h berechnet wird. Wird 'Zeit pro Charge' ausgewählt, entspricht die im nachstehenden Feld angezeigte Zeit der Zeit, die zum Bearbeiten aller Teile der Charge erforderlich ist. Wird 'Zeit pro Artikel' ausgewählt, ergibt sich die Bearbeitungszeit aus dem Wert im nachstehenden Feld multipliziert mit der Chargengröße. Wird 'Durchsatz/h' ausgewählt, wird die Bearbeitungszeit direkt aus der Anzahl in der Charge berechnet.":
220 "Sie haben momentan den Prozesszeittyp 'Zeit pro Artikel' ausgewählt. Sie müssen für jeden Artikel in diesem Feld eine Vorgangszeit eingeben.":
230 "Sie haben momentan den Prozesszeittyp 'Zeit pro Charge' ausgewählt. Sie müssen in diesem Feld eine Gesamtvorgangszeit für die Charge angeben.":
240 "Sie haben momentan den Prozesszeittyp 'Durchsatz/h' ausgewählt. Sie müssen in diesem Feld angeben, wie viele Artikel pro Stunde produziert werden können.":
251 "Die Farbe in diesem Feld weist den Sequencer an, einen Abschnitt des Gantt-Diagrammbalkens in einer anderen Farbe anzuzeigen. Die Farbe markiert den Balken entsprechend den Werten, die in die Felder 'Mittlere Chargenmenge' und 'Mittlere Chargenzeit' eingegeben wurden.":
260 "Mit diesem Feld wird die Auftrags- oder Chargenmenge angegeben.":
270 "Mit diesem Feld wird der Auftrags- oder Chargengewinn angegeben, und dieses Feld kann dazu verwendet, die Planung zu beeinflussen, wenn die Gewichtungsregel verwendet wird.":
280 "In diesem Feld wird die Startzeit des ersten Vorgangs dieses Auftrags angezeigt, sofern das Herstellungsdauer-Feature (MakeSpan) aktiviert ist":
290 "In diesem Feld wird die Endzeit des ersten Vorgangs dieses Auftrags angezeigt, sofern das Herstellungsdauer-Feature (MakeSpan) aktiviert ist":
300 "Dieser Wert bestimmt die Menge, die verarbeitet sein muss, bevor der nächste Vorgang begonnen werden kann. Der Wert 'Nicht festgelegt' verhindert, dass Vorgänge überlappen":
360 "Wird zur Angabe eines Datums verwendet, vor dem der Auftrag nicht begonnen werden kann. Dies kann beispielsweise der Zeitpunkt sein, zu dem Materialien zur Verfügung gestellt werden.":
370 "Mit diesem Feld wird das Fälligkeitsdatum festgelegt. Das Fälligkeitsdatum wird verwendet, um überfällige Artikel im Sequencer zu markieren sowie das Laden von Aufträgen in die Plantafel zu priorisieren, wenn die Option 'Fälligkeitsdatum' aktiviert ist.":
380 "Wählen Sie diese Umschaltfläche aus, um dem Zeitplanungsprogramm mitzuteilen, dass die für Anfangs- und Endzeit angegebenen Uhrzeiten 'tatsächliche' Werte sind. Ist diese Umschaltfläche aktiviert, wird verhindert, dass im Sequencer eine Zuweisung zwischen dem Auftrag und irgendeiner Ressource aufgehoben wird. Im Ergebnis wird der Auftrag dauerhaft an die Plantafel gebunden.":
390 "Das Zeitplanungsprogramm legt dieses Feld während der Planung der Reihenfolge auf die Uhrzeit fest, für die für den Auftrag geplant ist, den Rüstprozess zu beginnen.":
400 "Das Zeitplanungsprogramm aktualisiert dieses Feld während der Planung (Sequenzierung) auf die Uhrzeit, für die der Start des Auftrags geplant ist.":
410 "Das Zeitplanungsprogramm aktualisiert dieses Feld während der Planung der Reihenfolge auf die Uhrzeit, für die das Ende des Auftrags geplant ist.":
420 "Aktivieren Sie diese Umschaltfläche, wenn Sie nicht möchten, dass die Zuweisung dieser Aufgabe aufgehoben wird, nachdem im Sequencer die Option für 'Zuweisung aller Aufträge aufheben' ausgewählt wurde. Dadurch wird der Vorgang gesperrt. Dies lässt sich auch erreichen, wenn im Sequencer im Suchmodus 'Gesperrte Vorgänge hervorheben' mit der Maus auf einen Vorgang (Symbol oder Balken in der Übersicht) gezeigt, die Umschalttaste auf der Tastatur gedrückt und dann mit der linken Maustaste geklickt wird.":
421 "Vorgänge, für die diese Umschaltfläche aktiviert ist, werden im Fenster für nicht zugewiesene Vorgänge nicht zugewiesen, wenn Vorgänge automatisch geplant werden.":
430 "Ermöglicht, dass benutzerdefinierte Merkmale Produkten als Attribute zugewiesen werden können, z. B. Farbe. In einem bestimmten Merkmal erhalten Attributeinträge eine Prioritätsrangfolge, beispielsweise können 'weiße' Produkte eine höhere Priorität haben als 'gelbe'. Diese Attribute werden vom Zeitplanungsprogramm in seinen Regeln für bevorzugte Reihenfolge verwendet, sodass ähnliche Aufträge in der Vorschau konsolidiert werden.":
440 "Geben Sie die Informationen zur abgeschlossenen Menge ein, und geben Sie in das Feld  'Mittlere Chargenzeit' die Zeit ein, in der die Teilcharge abgeschlossen wurde. Das Zeitplanungsprogramm berechnet die 'Endzeit' für diesen Vorgang automatisch neu.":
450 "Geben Sie die Zeit ein, in der die Teilcharge abgeschlossen wurde, und geben Sie in das Feld 'Mittlere Chargenmenge' die Informationen zur abgeschlossenen Menge ein. Das Zeitplanungsprogramm berechnet die 'Endzeit' für diesen Vorgang automatisch neu.":
460 "Für das Feld 'Tatsächliche Vorgangszeit' werden Einträge in den Feldern ‘Mittlere Chargenmenge’ und ‘Mittlere Chargenzeit’ verwendet, um anhand dieser Informationen eine geänderte Vorgangszeit zu berechnen. Damit diese Funktionalität richtig funktioniert, müssen ‘Mittlere Chargenzeiten’ und ‘Mittlere Chargenmengen' geändert werden, wenn der Editor im Sequencer angezeigt wird. Andernfalls wird die ‘Tatsächliche Vorgangszeit' erst geändert, wenn der Sequencer das nächste Mal aufgerufen wird.":
474 "Wird verwendet, die Kosten eines Artikels an dem Punkt zu erfassen, an dem der Artikel in den Prozess eingeführt wird. Das Feld kann dazu verwendet werden, die Gemeinkosten pro Artikel zu erfassen, beispielsweise Wärmebehandlung usw.":
476 "Verwendet die 'Materialkosten pro Artikel', um die Materialkosten der Charge an dem Punkt bereitzustellen, an dem die pro Artikel anfallenden Kosten in den Prozess eingeführt werden.":
477 "Die Einzelkosten des Auftrags (Jobs) im aktuellen Prozess.":
530 "Legt einen Zeithorizont fest, in dem Aufträge für die Produktion zu einer Charge zusammengefasst werden können. Für eine Ressource, die einen Vorgang aus der Plantafel abgeschlossen hat, wird ab diesem Punkt durch den Zeithorizont nach vorne geschaut, der im Vorausschau-Zeitfenster festgelegt ist. Die Kriterien für die bevorzugte Reihenfolge, die in der Ressourcen-Datentabelle formuliert sind, werden angewendet, um Aufträge aus einer Arbeit auszuwählen, deren Fälligkeitsdatum in diesen Zeithorizont fällt. Das Vorausschau-Zeitfenster kann für einzelne Produkte oder in der Produkte-Datentabelle festgelegt und für einzelne Aufträge in der Hauptzeitplan-Datei geändert oder als globale Regel in den Informationen in 'Konfigurationseinrichtung' festgelegt werden.":
540 "Festgelegt in der Produkte-Datentabelle ermöglicht dies Zugriff auf ein Textdokument, das Informationen zu dem Produkt enthalten kann. Das Dokument kann auch aus dem Hauptzeitplandatei-Editor geöffnet und bearbeitet werden.":
541 "Dieses Feld wird dazu verwendet, den Fortschritt eines einzelnen Vorgangs zu beschreiben. Es gibt vier unterschiedliche Fortschrittstatus: 'Nicht gestartet', 'Einrichtung', 'Wird ausgeführt', 'Abschließen'":
550 "Jedem Produkt können bestimmte Merkmale zugeordnet sein. Im Zeitplanungsprogramm werden diese in der jeweiligen Attribut-Datentabelle angepasst. Diese Tabellen sind benutzerdefiniert und können, wie etwa die 'Produktattribut 1'-Tabelle, für Farben reserviert sein, wobei einzelne Einträge benannt sein könnten: rot, blau, grün usw. Produktattribute können im Feld 'Like to Like Match' in der Produkte-Datentabelle ausgewählt werden, um eine 'Like to Like Setup Time' zu definieren.":
560 "Wird dazu verwendet, für Einträge der 'Produktattribut 1'-Datentabelle eine Prioritätsrangfolge festzulegen, die für die Planungsauswahl der APS-Regeln verwendet wird.":
570 "Jedem Produkt können bestimmte Merkmale zugeordnet sein. Im Zeitplanungsprogramm werden diese in der jeweiligen Attribut-Datentabelle angepasst. Diese Tabellen sind benutzerdefiniert und können, wie etwa 'Attribut 2'-Tabelle, für Material reserviert sein, wobei einzelne Einträge benannt sein könnten: Stahl, Messing, Kupfer usw. Produktattribute können im Feld 'Like to Like Match' in der Produkte-Datentabelle ausgewählt werden, um eine 'Like to Like Setup Time' zu definieren.":
580 "Wird dazu verwendet, für Einträge der 'Produktattribut 2'-Datentabelle eine Prioritätsrangfolge festzulegen, die für die Planungsauswahl der APS-Regeln verwendet wird.":
590 "Jedem Produkt können bestimmte Merkmale zugeordnet sein. Im Zeitplanungsprogramm werden diese in der jeweiligen Attribut-Datentabelle angepasst. Diese Tabellen sind benutzerdefiniert und können, wie etwa die 'Attribut 3'-Tabelle, für Materialstärken reserviert sein, wobei einzelne Einträge benannt sein könnten: 40cm, 46cm, 50cm, 60cm usw. Produktattribute können im Feld 'Like to Like Match' in der Produkte-Datentabelle ausgewählt werden, um eine 'Like to Like Setup Time' zu definieren.":
600 "Wird dazu verwendet, für Einträge der 'Produktattribut 3'-Datentabelle eine Prioritätsrangfolge festzulegen, die für die Planungsauswahl der APS-Regeln verwendet wird.":
602 "In diesem Feld wird die Dauer des gesamten Auftrags von der festgelegten Anfangszeit des ersten Vorgangs bis zur Endzeit des letzten Vorgangs des Auftrags berechnet.":
620 "Eine Einlastungsregel, in der eine Indexzahl berechnet wird, indem die bis zum Fälligkeitsdatum verbleibende Zeit durch erwartete verstrichene Zeit dividiert wird, die zum Beenden des Auftrags erforderlich ist. Ein Verhältnis kleiner 1 kennzeichnet, dass der Auftrag verspätet ist, und ein Verhältnis größer 1 kennzeichnet, dass der Auftrag dem Plan voraus ist.":
815 "Mit dieser Option können Werte für Rüst- und Vorgangszeiten festgelegt werden. Sie wird auch dazu verwendet, den Fortschritt von Aufträgen durch das Produktionssystem zu aktualisieren.":
1020 "Gibt den Namen der Ressourcengruppe an. Dieser Name wird dazu verwendet, bestimmte Ressourcengruppen zu erkennen, die ähnliche Funktionen ausführen können.":
1030 "Kennzeichnet die gültigen Ressourcen für die Ressourcengruppe. Eine Ressource kann zu mehreren Gruppen gehören.":
1060 "Ist diese Umschaltfläche aktiviert, wird im Sequencer im Mehrfachdiagrammfenster ein Nutzungsdiagramm für die Ressourcengruppe angezeigt.":
1070 "Diese Farbe wird im Nutzungsdiagramm angezeigt, das im Sequencer im Mehrfachdiagrammfenster zu sehen ist.":
1080 "Im Nutzungsdiagramm, das im Sequencer im Mehrfachdiagrammfenster zu sehen ist, wird diese Farbe angezeigt, wenn die Nutzung die Anzahl von Stunden überschreitet, die für die Ressource oder Ressourcengruppe verfügbar sind (sofern das Feld für max. Nutzungsstunden auf 'Nicht festgelegt' eingestellt ist). Enthält das Feld für max. Nutzungsstunden einen Wert, wird die Farbe im Diagramm entsprechend diesem Wert geändert.":
1090 "Im Nutzungsdiagramm, das im Sequencer im Mehrfachdiagrammfenster zu sehen ist, wird diese Farbe verwendet, um eine Linie zu zeichnen, die die in Stunden gemessene festgelegte Nutzung kennzeichnet.":
2020 "Gibt den Namen der einzelnen Ressource an.":
2023 "Die Stundenkosten beim Einsetzen der Ressource.":
2024 "Wendet 'Kostenfaktor (%)'-Werte, die in den Hauptkalendereinträgen festgelegt sind, auf die Stundenkosten der Ressource an.":
2030 "Dieses Dialogfeld enthält Informationen dazu, wie eine Ressource oder Ressourcengruppe im Planungsübersichtsfenster und in Nutzungsdiagrammen angezeigt werden soll.":
2040 "Kann auf 'Sichtbar', 'Minimiert' oder 'Deaktiviert' festgelegt werden. Wird dazu verwendet, den Anfangszustand des Fensters dieser Ressource zu steuern, wenn der Sequencer gestartet wird. Ist normalerweise auf 'Minimiert' festgelegt. Ist diese Option auf 'Deaktiviert' festgelegt, wird die Ressource nicht für die Planung der Reihenfolge verwendet.":
2050 "Steuert die horizontale (Zeit-) Skalierung des Gantt-Diagramms in einem Ressourcenfenster im Sequencer. Kann von Minuten bis Wochen pro Einheit variieren.":
2070 "Hiermit kann eine Ressourcenkapazität auf 'Begrenzt', 'Unbegrenzt' oder 'Unbegrenzt mit Schichtschemas' festgelegt werden.":
2071 "Hiermit kann eine Ressourcenkapazität auf 'Begrenzt', 'Unbegrenzt' oder 'Unbegrenzt mit Schichtschemas' festgelegt werden, wenn die Ressource im Sequencermodus 'Unbegrenzte Kapazität' betrieben wird.":
2080 "Steuert die horizontale (Zeit-) Skalierung der nebeneinander angeordneten Ressourcenfenster im Sequencer.":
2100 "Wählt die sekundären Bedingungen aus, die auf eine primäre Ressource angewendet werden sollen. Die Option gibt die bedingte Menge, die für die Ressource erforderlich ist, sowie die Art und Weise an, in der die Bedingung auf die primäre Ressource angewendet wird.":
2110 "Wird gefordert, wenn die Nutzung der sekundären Ressource inkrementiert oder dekrementiert werden soll, z. B. 'Für Dauer erhöhen', wodurch die sekundäre Bedingung für die Dauer des Vorgangs genutzt und nach dessen Abschluss freigegeben wird. Ist ein Auftrag auf einer Halterung für mehrere Vorgänge platziert, können Inkrementieren bei Beginn für den ersten Vorgang und Dekrementieren bei Abschluss für den letzten Vorgang angegeben werden. Dadurch wird sichergestellt, dass die Halterung nicht für einen anderen Auftrag verwendet wird, während der erste Auftrag in die Warteschlange für eine Ressource gesetzt wird.":
2120 "Gibt die erforderliche Menge für die sekundäre Bedingung an. Ist der Wert 'Menge' ausgewählt, ist die erforderliche Menge gleich der Menge für die Charge, die verarbeitet wird.":
2130 "Definiert ein Attribut eines Vorgangs, das verhindert, dass ungleiche Vorgänge für eine Ressource mit unbegrenzter Kapazität gleichzeitig ausgeführt werden.":
2150 "Wird in APS-Produkten verwendet, um die Kriterien festzulegen, die in den Regeln für bevorzugte Reihenfolge beim Auswählen der auszuführenden Arbeit verwendet werden sollen.":
2160 "Wird im APS-Produkt durch 'Umlaufbestand minimieren'-Zeitplanregeln verwendet, um Zeitpuffer festzulegen, in denen der Umlaufbestand im Vorlauf ausgewählter Ressourcen gesammelt werden kann.":
2180 "Ein numerischer Wert, mit dem die Reihenfolge festgelegt wird, in der Ressourcen in der Ressourcen-Datentabelle angezeigt werden. Der Wert kann auch dazu verwendet werden, die Standardreihenfolge zu überschreiben, in der Ressourcen in der Planungsübersicht angezeigt werden.":
2181 "Zeigt das Dialogfeld an, in dem Optionen für erweiterte Ressourcenbedingungen definiert werden können":
2182 "Ermöglicht es, mit Ausdrücken komplexe Beziehungen zwischen Ressourcen zu definieren. Details zur Ausdruckssyntax und -erstellung finden Sie in der Dokumentation.":
2183 "Hiermit kann der Benutzer für einen Vorgang mit einer Ressource mit unbegrenzter Kapazität ein Attribut wählen, das angibt, dass nur Vorgänge gleichzeitig geplant werden können, die denselben Wert im ausgewählten Attribut haben.":
2185 "Bestimmt, ob in einem Gantt-Diagramm eine Trennlinie unter der Ressource angezeigt wird. Dies kann nützlich sein, wenn Ressourcen in Gruppen dargestellt werden.":
2190 "Bestimmt die Art und Weise, wie die Ressource in der Planungsübersicht angezeigt wird. Die Alternativen sind 'Immer', 'Nur in Gruppe' und 'Ausblenden'.":
2191 "Bestimmt die Art und Weise, wie die Vorgänge in der Planungsübersicht angezeigt werden. Die Optionen sind 'Gestapelt', wobei die Vorgänge auf einer Übersichtslinie angezeigt werden, und 'Überlappend', wobei jeder Vorgang auf seiner eigenen Übersichtslinie angezeigt wird.":
2200 "Hiermit wird eine Matrix aus planungsabhängigen Rüstwerten erstellt, die die Rüstzeiten angeben, die erforderlich sind, wenn von einem Produkt eines Attributtyps zu einem anderen gewechselt wird.":
2201 "In diesem Feld wird festgelegt, welche Umrüstgruppe dieser Ressource zugewiesen wird. Das Feld bestimmt damit, welche Umrüstzeiten zwischen Vorgängen mit unterschiedlichen Attributen angewendet werden.":
2202 "Bestimmt, ob die Rüst- und Umrüstzeiten, die zu diesen Vorgängen für diese Ressource gehören, gleichzeitig oder kumulativ angewendet werden.":
2205 "Wird dieses Kontrollkästchen aktiviert, wird diese Ressource nicht mehr in den Berechnungen der Leistungskennzahlen für den Zeitplan berücksichtigt.":
2210 "Mit diesem Feld wird ausgewählt, zu welchem Viewersystem die Ressource gehört. Das Feld enthält eine Liste mit Zeitplanungssystemnamen, die aus der Datentabelle für das PCO-Adressbuch entnommen wurden.":
2220 "Diese Schaltfläche öffnet ein Dialogfeld, in dem die unterschiedlichen Attribute aufgelistet werden, die der Ressource zugewiesen sind.":
2230 "Dieses Feld ermöglicht es, Zeichenfolgeattributdaten für die Ressource einzugeben.":
2240 "Dieses Feld ermöglicht es, reelle Attributdaten für die Ressource einzugeben.":
2250 "Dieses Feld ermöglicht es, Dauerattributdaten für die Ressource einzugeben.":
2260 "Dieses Feld gibt die Produktivität einer Ressource an. Der Standardwert ist '100%'. Wird die Produktivität in '200%' geändert, werden Vorgänge, die für diese Ressource geplant sind, doppelt so schnell verarbeitet (die Hälfte der normalen Prozesszeit).":
2270 "Ist diese Umschaltfläche aktiviert, wird der Wert des Felds 'Produktivität (%)' auf alle Vorgänge angewendet, für die es Rüstzeiten gibt und die für die Ressource geplant sind, mit der die Schaltfläche verknüpft ist.":
2280 "Ist diese Umschaltfläche aktiviert, wird im Sequencer im Mehrfachdiagrammfenster ein Nutzungsdiagramm der Ressource angezeigt.":
2300 "Verwenden Sie dieses Feld zur Auswahl einer sekundären Bedingungsgruppe, aus der eine sekundäre Bedingung für Sequenzen zugewiesen wird.":
2310 "Die sekundäre Bedingung, die aus der sekundären Bedingungsgruppe zugewiesen wurde, wird für dieses Feld zugewiesen.":
5035 "Ein Kostenfaktormultiplikator, der sich auf die variablen Kosten der Ressource auswirkt, auf die er angewendet wird. Der Wert '100%' bedeutet keine Erhöhung, der Wert '150%' erhöht die variablen Kosten um 50 %. Dieser in der Kalenderstatus-Datentabelle festgelegte Wert ist der Standardwert, der in den Hauptkalenderdateien verwendet wird.":
6100 "Zeigt ein Dialogfeld an, in dem ausgewählt werden kann, welche Ressourcen aus der ausgewählten Gruppe zulässig sind, und in dem ressourcenspezifische Daten zugeordnet werden können.":
6110 "Dieses Feld bestimmt, ob die Ressource während einer automatischen Planung der Reihenfolge ausgewählt wird. Ist das Feld nicht aktiviert, ist es weiterhin möglich, den Vorgang manuell der Ressource zuzuordnen.":
6120 "In diesem Feld kann für jede der Ressourcen, die für den Vorgang zulässig sind, eine zugehörige Rüstzeit festgelegt werden.":
6130 "In diesem Feld kann für jede der Ressourcen, die für den Vorgang zulässig sind, eine zugehörige Vorgangszeit festgelegt werden.":
6131 "In diesem Feld kann für jede der Ressourcen, die für den Vorgang zulässig sind, ein zugehöriger Durchsatz/h festgelegt werden.":
6132 "In diesem Feld kann für jede der Ressourcen, die für den Vorgang zulässig sind, eine zugehörige Chargenzeit festgelegt werden.":
6140 "In diesem Feld wird eine sekundäre Ressource angegeben, die während des aktuellen Vorgangs von der primären Ressource verwendet wird.":
6150 "In diesem Feld wird angegeben, wie die sekundäre Ressource während des Vorgangs verwendet wird, beispielsweise 'Für Dauer erhöhen', 'Nur Rüstzeit erhöhen' usw.":
6160 "Mit diesem Feld können Sie den Umfang der sekundären Bedingung angeben, die während des aktuellen Vorgangs erforderlich ist. Beispielsweise könnten Sie angeben, dass der Vorgang eine Lünette erfordert.":
6170 "Das Zeitplanungsprogramm nutzt diese Zeitspanne für den Versuch, den aktuellen Vorgang für die bevorzugte Ressource zu laden. Ist dies bis zum Ende dieser Zeitspanne nicht möglich, versucht das Zeitplanungsprogramm, den Vorgang für eine der anderen Ressourcen der Gruppe zu laden.":
6180 "Mit 'Gruppe nachfolgender Ressourcen festlegen' wird eine erzwungene Liste von Ressourcen festgelegt (also die Ressourcen, die in der ausgewählten Gruppe angegeben sind). Diese Option erzwingt, dass in nachfolgenden Vorgängen nur solche Ressourcen verwendet werden, die in der erzwungenen Liste enthalten sind. Wird in einem Prozesslaufweg in einem späteren Vorgang eine Ressourcengruppe aufgerufen, die einige Ressourcen enthält, die nicht zu der Liste gehören, werden diese Ressourcen daher bei der Planung der Reihenfolge nicht verwendet. 'Gruppe nachfolgender Ressourcen festlegen' ist eine akkumulierende Funktion und kann für mehrere Vorgänge in einem Prozesslaufweg verwendet werden, wodurch Ressourcen zur erzwungenen Liste hinzugefügt werden.":
6190 "Die Funktion 'Gruppe nachfolgender Ressourcen löschen' entfernt alle Ressourcen, die in der ausgewählten Ressourcengruppe enthalten sind, aus der erzwungenen Liste, die mit dem Befehl 'Gruppe nachfolgender Ressourcen festlegen' angelegt wurde. Wurde eine konzeptionelle Ressourcengruppe ('Alle') angelegt, die alle verfügbaren Ressourcen enthält, werden in nachfolgenden Vorgängen die Ressourcen verwendet, die im ursprünglichen Prozesslaufweg festgelegt sind.":
6230 "In diesem Feld kann eine Rüstzeit angegeben werden, die für einen Wechsel vom vorherigen Produkt zum aktuellen Produkt gilt. Ein Wert im Feld 'Rüstzeit' wird jedem Rüstzeitwert hinzugefügt, der für die Ressource durch eine Matrix planungsabhängiger Rüstzeiten festgelegt ist.":
6430 "Wählen Sie einen Symbolnamen in der Dropdownliste aus. Über die Bearbeitungsschaltfläche können Sie neue Symbole erstellen.":
6470 "Zeigt das Dialogfeld für gültige sekundäre Bedingungen an, wodurch gültige Bedingungen auf einzelne Einträge der Tabelle angewendet werden können. Eigenschaften der Bedingungsnutzung können ebenfalls hier bearbeitet werden.":
6530 "Gibt die maximale Zeitspanne an, die zwischen zwei aufeinander folgenden Vorgängen zulässig ist. Die maximale Zeitspanne wird durch das Feld 'Intervalltyp' eingeschränkt, in dem 'Anfang-bis-Anfang'-, 'Ende-bis-Ende'-Beziehungen usw. festgelegt sind.":
6540 "Gibt die Beziehung an, die zum Einfügen der maximalen Zeitspanne, die im Feld 'Max. Zeit vor nächstem Vorgang' festgelegt ist, zwischen zwei aufeinander folgenden Vorgängen verwendet wird. Dies kann eine 'Ende-bis-Ende'-, 'Ende-bis-Anfang'-, 'Anfang-bis-Anfang'- oder 'Anfang-bis-Ende'-Beziehung sein.":
6550 "Gibt, formuliert als Prozentsatz der theoretischen Prozesszeit, die maximale Zeitspanne an, um die ein Vorgang verlängert werden kann, wenn er vom Sequencer automatisch geplant wird.":
6560 "Gibt eine Pufferzeit an, die zwischen diesem Vorgang und dem vorherigen Vorgang eingefügt werden soll.":
6565 "Gibt eine Pufferzeit an, die zwischen diesem Vorgang und dem nächsten Vorgang eingefügt werden soll.":
6580 "Mit diesem Feld kann eine Prozessraten-Multiplikatorreihenfolge angewendet werden, um die Vorgangslänge zu beeinflussen.":
6681 "Mit diesem Feld wird ein Attribut dieses Eintrags angegeben, auf den aus einer der Attributtabellen verwiesen wird. Diese können dazu verwendet werden, Rüstzeiten, Planungsreihenfolge und Bedingungsnutzung zu beeinflussen.":
6682 "Mit diesem Feld wird ein als Zeichenfolge im freien Format vorliegendes Attribut dieses Eintrags angegeben. Das Attribut kann dazu verwendet werden, Anzeigeoptionen festzulegen und Vorgänge zu gruppieren.":
6683 "Mit diesem Feld wird ein numerisches Attribut dieses Eintrags angegeben. Das Attribut kann dazu verwendet werden, Anzeigeoptionen festzulegen sowie Planungsreihenfolge und Bedingungsnutzung zu beeinflussen.":
6684 "Mit diesem Feld wird ein Datumsattribut dieses Eintrags angegeben. Das Attribut kann dazu verwendet werden, Anzeigeoptionen festzulegen und die Planungsreihenfolge zu beeinflussen.":
6685 "Mit diesem Feld wird ein Dauerattribut dieses Eintrags angegeben. Das Attribut kann dazu verwendet werden, Anzeigeoptionen festzulegen und die Planungsreihenfolge zu beeinflussen.":
6690 "Das Feld 'Lieferpuffer' enthält eine Pufferzeit, die vom Fälligkeitsdatum subtrahiert wird, wenn eine Rückwärtsplanung vorgenommen wird. Dadurch werden Vorgänge früher geplant als zum spätesten möglichen Zeitpunkt. Dies ermöglicht es, unerwartete Verzögerungen im Prozess zu berücksichtigen.":
7020 "Die Anzahl von Tagen vor dem aktuellen Zeitpunkt, die in der Planungsübersicht angezeigt werden können.":
7030 "Die Zeitspanne nach dem aktuellen Zeitpunkt, die in der Planungsübersicht angezeigt werden kann.":
7035 "Öffnet ein Konfigurationsdialogfeld, in dem der Benutzer die Planungsübersicht anpassen kann.":
7040 "Gibt einen an den Zeitpunkt der Auftragseingabe anschließenden Zeitversatz an, vor dem ein Auftrag nicht begonnen werden kann. Ist diese Option auf 'Nicht festgelegt' eingestellt, gibt es keine andere Einschränkung als den aktuellen Zeitpunkt.":
7050 "Gibt einen an den Zeitpunkt der Auftragseingabe anschließenden Zeitversatz an, bei dem der Auftrag verfügbar sein sollte. Kann überschrieben werden.":
7060 "Die Zeitspanne, um die der Abschluss ab dem aktuellen Zeitpunkt versetzt wurde. Der Abschluss entspricht dem aktuellen Zeitpunkt, wenn der Abschlussversatz auf '0 Stunden 00 Min.' festgelegt ist.":
7067 "Gibt Optionen für die Kostenberechnung an. Diese sind: 'Während Planung', 'Nach Planung' und 'Nie'.":
7120 "Legt den Planungsübersichtsmodus fest.":
7130 "Die Anzahl von Tagen ab jetzt, nach denen die Planungsübersicht gestartet werden soll.":
7140 "Die Anzahl von Tagen ab jetzt, nach denen die Planungsübersicht beendet werden soll.":
7320 "Ermöglicht es, das Skript, das zum Importieren von Aufträgen erforderlich ist, in der Datentabelle 'Skripts' auszuwählen.":
7330 "Ermöglicht es, das Skript, das zum Exportieren von Aufträgen erforderlich ist, in der Datentabelle 'Skripts' auszuwählen.":
7430 "Ist dieses Umschaltfeld aktiviert, werden im Sequencer für jeden Vorgangsbalken kleine schwarze Dreiecke aktiviert. Diese Funktionalität vereinfacht ein Ziehen von Vorgängen, die auf der Plantafel zugewiesen sind (gilt insbesondere für kleinere Vorgänge).":
7450 "Gibt das Standard-PESP-Ereignisskript an, das ausgeführt werden soll, wenn Aufträge über die Schaltfläche 'Aufträge importieren' des Menüs 'Datenübertragung' importiert werden.":
7470 "Gibt das Standard-PESP-Ereignisskript an, das ausgeführt werden soll, wenn Aufträge über die Schaltfläche 'Aufträge exportieren' des Menüs 'Datenübertragung' exportiert werden.":
7480 "Gibt das Standard-PESP-Ereignisskript an, das ausgeführt werden soll, wenn ein Zeitplan über die Schaltfläche 'Zeitplan freigeben' des Menüs 'Datenübertragung' freigegeben wird.":
7490 "Gibt das Standard-PESP-Ereignisskript an, das ausgeführt werden soll, wenn im Sequencer Vorgänge bei aktivierter Option 'APS-Regeln' zugeordnet werden sollen.":
8020 "Name der sekundären Bedingung.":
8030 "Hiermit können Sie die Farbe des Sequencer-Benutzerdiagramms auswählen, wenn die Werte zwischen der oberen und der unteren Begrenzung liegen.":
8040 "Legt das Diagrammfüllmuster fest.":
8060 "Die Diagrammfüllfarbe, wenn das Diagramm die obere Diagrammbegrenzung überschreiten sollte.":
8080 "Die Diagrammfüllfarbe, wenn das Diagramm die untere Diagrammbegrenzung überschreiten sollte.":
8090 "Gibt an, ob diese sekundäre Bedingung den Zeitplan einschränken soll, wenn ein 300 FCS Produkt oder höher verwendet wird. Ist dieses Kontrollkästchen nicht aktiviert, gilt in allen Versionen, dass der Sequencer keine Warnungen ausgibt, wenn die Begrenzungen überschritten werden, die für diese sekundäre Bedingung festgelegt sind.":
8091 "Im Sequencermodus 'Unbegrenzte Kapazität' gibt dieses Feld an, ob diese sekundäre Bedingung den Zeitplan einschränken soll, wenn ein 300 FCS Produkt oder höher verwendet wird.":
8092 "Optionen zum Steuern des Verhaltens dieser Bedingung, wenn das System auf den Modus 'Unbegrenzte Kapazität' festgelegt ist.":
8100 "Bestimmt, wie sich die Kalendereffizienz der primären Ressource auf die Nutzung dieser sekundären Bedingung auswirkt. Die Optionen sind: 'Keine Auswirkung', 'Effizienz am Anfang des Jobs', 'Effizienzänderungen folgen', '100% verwenden, falls größer als 0%'":
8101 "Im Sequencermodus 'Unbegrenzte Kapazität' bestimmt dieses Feld, wie sich die Kalendereffizienz der primären Ressource auf die Nutzung dieser sekundären Bedingung auswirkt. Die Optionen sind: 'Keine Auswirkung', 'Effizienz am Anfang des Jobs', 'Effizienzänderungen folgen', '100% verwenden, falls größer als 0%'":
8120 "Mit dieser Schaltfläche wird ein Dialogfeld geöffnet, in dem die unterschiedlichen Attribute aufgelistet werden, die der sekundären Bedingung zugeordnet sind.":
8130 "Dieses Feld ermöglicht es, Zeichenfolgeattributdaten für die sekundäre Bedingung einzugeben.":
8140 "Dieses Feld ermöglicht es, reelle Attributdaten für die sekundäre Bedingung einzugeben.":
8150 "Dieses Feld ermöglicht es, Dauerattributdaten für die sekundäre Bedingung einzugeben.":
8160 "Ist diese Umschaltfläche aktiviert, wird im Sequencer im Mehrfachdiagrammfenster ein Nutzungsdiagramm für die sekundäre Bedingung angezeigt.":
8200 "Der Name der sekundären Bedingungsgruppe.":
8210 "Ermöglicht die Auswahl der sekundären Bedingungen, die in dieser Gruppe enthalten sein sollen.":
9020 "Rüstgruppennamen. Diese bilden die X- und die Y-Achse der Matrix für planungsabhängige Rüstzeiten in der Ressourcen-Datentabelle.":
12020 "Der Name eines Attributeintrags in der 'Produktattribut 1'-Datentabelle.":
13020 "Der Name eines Attributeintrags in der 'Produktattribut 2'-Datentabelle.":
14020 "Der Name eines Attributeintrags in der 'Produktattribut 3'-Datentabelle.":
16020 "Mit dem Namen wird die Bildschirmanzeigekonfiguration beschrieben, die unter dem Dateinamen gespeichert ist. Diese Beschreibung wird auch als QuickInfo-Anzeige für Symbole in einer Arbeitsbereichssymbolleiste verwendet.":
16030 "Die Datei wird über die Option ausgewählt, die zu der Schaltfläche gehört, die sich links neben dem Feld befindet. Die ursprüngliche Arbeitsbereichskonfigurationsdatei wird mit der Dateierweiterung .WPI gespeichert, indem im Sequencer-Menü unter 'Arbeitsbereich' der Befehl 'Arbeitsbereich speichern' verwendet wird.":
18510 "Der Name der Person oder des Unternehmens, die oder das einen Auftrag erteilt.":
18520 "Der Name der Hauptkontaktperson eines Unternehmens, das einen Auftrag erteilt.":
18530 "Die Telefonnummer, die im Zusammenhang eines Auftrags verwendet werden soll.":
18540 "Die E-Mail-Adresse, die im Zusammenhang eines Auftrags verwendet werden soll.":
21000 "In dieses Feld können unterschiedliche Auftragsstatus eingegeben werden. Der Auftragsstatus kann für einen Auftrag in der Zeitplandatei ausgewählt werden.":
21020 "Dieses Feld enthält die Beschreibung, welche Bedeutung der Auftragsstatusname hat, der in das Feld 'Auftragsstatusname' eingegeben wurde.":
21100 "Der Name des Attributeintrags in der Attribut-Datentabelle.":
21110 "Wird dazu verwendet, für Einträge dieser Attribut-Datentabelle eine Prioritätsrangfolge festzulegen, die für Planungsregeln verwendet werden kann":
24000 "Dieses Feld gibt an, ob der Eintrag ein übergeordneter oder untergeordneter Eintrag des Regelsatzes ist.":
24010 "Enthält den Namen des Regelsatzes.":
24020 "Mit dieser Umschaltfläche werden Verknüpfungslinks nur für Aufträge gelöscht, die sich in der Bedarfswarteschlange des ersten Durchlaufs (ob aktiviert oder nicht) des Regelsatzes befinden.":
24030 "Enthält den Namen der speziellen Funktion des Regeldurchlaufs.":
24040 "Eine Umschaltfläche, die, ist sie auf 'Wahr' festgelegt, den Regeldurchlauf ermöglicht. Ist sie auf 'Falsch' festgelegt, wird dieser spezielle Regeldurchlauf ignoriert, wenn der Regelsatz ausgeführt wird.":
24050 "Ist diese Umschaltfläche auf 'Wahr' festgelegt und wird der Regelsatz ausgeführt, wird im Arbeitsverzeichnis eine Debugdatei erstellt.":
24060 "In diesem Feld können Kriterien angegeben werden, mit denen die Artikel eingeschränkt werden können, die in die interne Lieferwarteschlange gesetzt werden. Der Standardwert für dieses Feld lautet 'Alle', dies kann aber durch Eingabe eines Ausdrucks, z. B. (~{$Auftragstyp}~==~Bestand~), geändert werden. Für diese Warteschlange werden Einträge gefiltert, die sich in der 'Works Orders'-Datenbanktabelle befinden.":
24070 "Dieses Feld enthält Kriterien, mit denen die Rangfolge der Artikel in der internen Lieferwarteschlange festgelegt werden kann. Beispielsweise können Sie die Rangfolge in der internen Lieferwarteschlange nach 'Fälligkeitsdatum', 'Frühestes Startdatum' oder 'Priorität' festlegen.":
24080 "In diesem Feld können Kriterien angegeben werden, mit denen die Artikel eingeschränkt werden können, die in die Bedarfswarteschlange gesetzt werden. Der Standardwert für dieses Feld lautet 'Alle', dies kann aber durch Eingabe eines Ausdrucks, z. B. (~{$Auftragstyp}~==~Bestand~), geändert werden. Für diese Warteschlange werden Einträge gefiltert, die sich in der 'Works Orders'-Datenbanktabelle befinden.":
24090 "Dieses Feld enthält Kriterien, mit denen die Rangfolge der Artikel in der internen Bedarfswarteschlange festgelegt werden kann. Beispielsweise können Sie die Rangfolge in der internen Bedarfswarteschlange nach 'Fälligkeitsdatum', 'Frühestes Startdatum' oder 'Priorität' festlegen.":
24100 "Dieses Feld enthält eine Liste der verschiedenen Standardverknüpfungsregeln, mit denen Aufträge verknüpft werden können. Es enthält außerdem drei spezielle Elemente ('Benutzerdefiniert', 'Benutzerfunktion' und 'PESP-Skript'), mit denen angepasste Regeln erstellt werden können.":
24110 "Dieses Feld ist nur sichtbar, wenn das Feld 'Regeltyp' auf 'Benutzerdefiniert' oder 'Benutzerfunktion' festgelegt ist. Der für die Regel zu verwendende Ausdruck wird in dieses Feld eingegeben. Ein Beispiel könnte wie folgt aussehen: (~{+:$Produktattribut 1}~==~{-:$Produktattribut 1}~), wodurch erreicht wird, dass Liefer- und Bedarfsaufträge nur verknüpft werden können, wenn die 'Produktattribut 1'-Felder denselben Wert haben.":
24120 "Dieses Feld ist nur sichtbar, wenn das Feld 'Regeltyp' auf 'PESP-Skript' festgelegt ist. Dieses Feld enthält den Namen des PESP-Skripts, das als Regel verwendet werden soll.":
24130 "Diese Option ermöglicht ein Erstellen von Verknüpfungen zu Stücklistenzeilen, in denen die geforderte Menge nicht vollständig erfüllt sein muss, damit die Verknüpfung erstellt wird. Alle Artikel, die unzureichend vorhanden sind, werden als Engpass hervorgehoben.":
24140 "Diese Option lässt ein Erstellen von Verknüpfungen nur zu Stücklistenzeilen zu, für die die geforderte Menge vollständig erfüllt ist. Alle Artikel, die unzureichend vorhanden sind, werden als Engpass hervorgehoben.":
24141 "Ist diese Option aktiviert, wird das Standardverhalten von SMC überschrieben, indem die Erstellung von Rückwärtsverknüpfungen zugelassen wird, wenn die Produktion nach dem Verbrauch stattfindet.":
24150 "Ist diese Option auf 'Wahr' festgelegt, können bereits geplante Aufträge neu verbunden werden.":
24160 "Ist dieses Umschaltfeld auf 'Wahr' festgelegt, wird das Feld 'Lieferwarteschlangenrangfolge' aktiviert. Dadurch wird es möglich, Einträge entsprechend den Auswahlkriterien, die dieses Feld enthält, dem Rang nach zu sortieren. Diese Option sollte nur ausgewählt werden, wenn sich alle Einträge in der 'Works Orders'-Datenbanktabelle befinden.":
24170 "In diesem Feld können Kriterien angegeben werden, mit denen die Artikel eingeschränkt werden können, die in die externe Lieferwarteschlange gesetzt werden. Der Standardwert für dieses Feld lautet 'Alle', dies kann aber durch Eingabe eines Ausdrucks, z. B. (~{$Auftragstyp}~==~Bestand~), geändert werden. Für diese Warteschlange werden Einträge gefiltert, die sich in der 'Bedarf'-Datenbanktabelle befinden.":
24180 "Es wird jedes Feld verarbeitet, das die Klassifizierung INHERIT FROM SUPPLY(Feldname) hat.":
24190 "Es wird jedes Feld verarbeitet, das die Klassifizierung INHERIT FROM DEMAND(Feldname) hat.":
24200 "Ist dieses Umschaltfeld auf 'Wahr' festgelegt, wird das Feld 'Bedarfswarteschlangenrangfolge' aktiviert. Dadurch wird es möglich, Einträge entsprechend den Auswahlkriterien, die dieses Feld enthält, dem Rang nach zu sortieren. Diese Option sollte nur ausgewählt werden, wenn sich alle Einträge in der 'Works Orders'-Datenbanktabelle befinden.":
24210 "Die Menge einer Verbindung wird in bestimmten Vielfachen zugewiesen, wenn diese Umschaltfläche auf 'Wahr' festgelegt ist. Das jeweilige Vielfache ist in den Stücklistendaten angegeben.":
24500 "Ist das Umschaltfeld 'Immer diesen Regelsatz verwenden' aktiviert, ist der Verknüpfungsregelsatz, der in diesem Feld ausgewählt ist, der Regelsatz, der standardmäßig ausgeführt wird, wenn im Sequencer die Option 'Materialien verknüpfen' ausgewählt ist.":
24505 "Ist diese globale Option aktiviert, wird das Standardverhalten von SMC überschrieben, indem die Erstellung von Rückwärtsverknüpfungen zugelassen wird, wenn die Produktion nach dem Verbrauch stattfindet.":
24510 "Ist dieses Umschaltfeld aktiviert, wird die Regel, die im Feld 'Verknüpfungsregelsatz' ausgewählt ist, als Standardregel verwendet, die ausgeführt wird, wenn im Sequencer die Option 'Materialien verknüpfen' ausgewählt wird. Hiermit wird ermöglicht, dass die auszuführende Regel zu diesem Zeitpunkt ausgewählt wird.":
25400 "Dies ist das Feld, das die Auftragsnummer des Lieferauftrags enthält.":
25410 "In diesem Feld wird der Typ des Auftrags angegeben, etwa 'Bestand' oder 'Bestellung'.":
25420 "Der Name des Unternehmens, das die Materialien für den Auftrag liefert.":
25430 "Die Teilenummer, auf die sich der Auftrag bezieht.":
25440 "Die Beschreibung des Teils, auf das sich der Auftrag bezieht.":
25450 "Das Datum, zu dem das Material geliefert wird.":
25500 "Mit diesem Feld wird gekennzeichnet, zu welchem Auftrag das Teil gehört. Die erste Auftragszeile eines Auftrags ist der übergeordnete Eintrag, und für sie wird PARENT in diesem Feld angezeigt. Die Auftragszeilen, die zu diesem Auftrag gehören, sind untergeordnete Einträge, und für sie wird die zugehörige Auftragsnummer in diesem Feld angezeigt.":
25510 "Dies ist das Feld, das die Auftragsnummer des Bedarfsauftrags enthält.":
25520 "In diesem Feld wird der Typ des Auftrags angegeben, etwa 'Bestand' oder 'Verkaufsauftrag'.":
25530 "Kennzeichnet eindeutig einen Einzelposten eines Auftrags.":
25540 "Der Name des Unternehmens, das die Materialien für den Auftrag benötigt.":
25550 "Das Datum, an dem das Material benötigt wird.":
25560 "Gibt das Vielfache eines Artikels an, das verknüpft werden muss. Häufig ergibt eine Anzahl von Artikeln eine Packung oder Kiste. Ein Beispiel ist der Fall, in dem 12 Dosen eine Packung ergeben und ein Auftrag eingeht, für den 60 Dosen erforderlich sind. Es gibt einen Lieferauftrag für 50 Dosen. Die Materialsteuerung verknüpft nur 48 Dosen der 50 und sucht dann an anderer Stelle nach den verbleibenden 12 erforderlichen Dosen, erstellt die Verbindung aber nur, wenn genau 12 Dosen gefunden wurden. In der 'Verknüpfungsregeln'-Datenbanktabelle muss das Feld 'Nur Vielfache zuweisen' aktiviert sein, damit diese Funktion aktiviert ist.":
25600 "Die Nummer des Auftrags, zu dem die Stücklistenzeile gehört.":
25605 "Die Teilenummer des Auftrags, zu dem die Stücklistenzeile gehört.":
25610 "Die Nummer des Vorgangs, zu dem die Stücklistenzeile gehört.":
25611 "Der Name des Vorgangs, zu dem die Stücklistenzeile gehört.":
25615 "Die Teilenummer des Produkts, für das das angegebene Material benötigt wird":
25620 "Die Teilenummer des Stücklistenpostens.":
25630 "Die erforderliche Menge des Stücklistenpostens.":
25640 "Ist dieses Feld auf 'Wahr' festgelegt, wird die Menge des Auftrags mit der geforderten Stücklistenmenge multipliziert.":
25650 "Bewirkt, dass Engpässe ignoriert werden, wenn Verknüpfungsregeln ausgeführt werden. Ermöglicht es, Aufträge mit Engpässen zu planen.":
25700 "Die Nummer des Auftrags, in dem das Kuppelprodukt produziert wird.":
25705 "Die Teilenummer des Auftrags, in dem das Kuppelprodukt produziert wird.":
25710 "Die Nummer des Vorgangs, in dem das Kuppelprodukt produziert wird.":
25715 "Der Name des Vorgangs, in dem das Kuppelprodukt produziert wird.":
25720 "Der Name des Kuppelprodukts.":
25730 "Die Menge des Kuppelprodukts.":
25740 "Ist dieses Feld auf 'Wahr' festgelegt, wird die Menge des Kuppelprodukts mit der Auftragsmenge multipliziert.":
25800 "In diesem Feld wird der Typ des Auftrags angegeben, etwa 'Arbeitsauftrag', 'Bestellung', 'Verkaufsauftrag' oder 'Bestand'":
25810 "Ist diese Option aktiviert, wird der nicht geplante Vorgang nicht mehr im Fenster 'Nicht geplante Vorgänge' angezeigt.":
25820 "Zeigt ein Dialogfeld an, in dem Felder angezeigt werden, die sich auf die Materialsteuerung beziehen.":
25830 "Dieses Feld enthält Informationen zum Status des Bedarfs, nachdem Materialien verknüpft wurden. Es enthält einen der folgenden Werte: 'Unbekannt', 'Satisfied', 'All shortages Ignored', 'Shortages', 'Over Supplied', 'Over Supplied, Shortages', 'Over Supplied, All Shortages Ignored'.":
25840 "Dieses Feld wird ausgefüllt, nachdem Materialien verknüpft wurden. Wurde eine Verknüpfung zu einem Lieferauftrag in der 'Lieferaufträge'-Datenbanktabelle erstellt, wird das Feld 'Bedarfsdatum' in der 'Works Orders'-Datenbanktabelle mit dem 'Lieferdatum' des Lieferauftrags ausgefüllt. Das Feld 'Lieferdatum' wird gegen das Feld 'Frühestes Startdatum' abgeglichen und der spätere der beiden Datumswerte wird verwendet, um zu entscheiden, welches Datum für die Planung verwendet werden soll.":
25850 "Dieses Feld wird ausgefüllt, nachdem Materialien verknüpft wurden. Wurde eine Verknüpfung zu einem Bedarfsauftrag in der 'Bedarfsaufträge'-Datenbanktabelle erstellt, wird das Feld 'Lieferdatum' in der 'Works Orders'-Datenbanktabelle mit dem 'Bedarfsdatum' des Bedarfsauftrags ausgefüllt, mit dem es verknüpft ist. Das Feld 'Bedarfsdatum' wird gegen das Feld 'Fälligkeitsdatum' abgeglichen und der frühere der beiden Datumswerte wird verwendet, um zu entscheiden, welches Datum für die Planung verwendet werden soll.":
25900 "Zeigt ein Dialogfeld mit Feldern an, die sich auf den Status eines Vorgangs beziehen.":
25910 "Diese Option kann ausgewählt werden, wenn ein Auftrag geteilt wurde. Sie ermöglicht, dass jedes Fertigungslos den Fertigungsprozess unabhängig durchlaufen kann. Beispielsweise müssen nicht alle Lose in einem Vorgang abgeschlossen werden, bevor ein nachfolgender Vorgang begonnen werden kann.":
25920 "Dieses Feld gibt die Farbe an, die für den Balken im Gantt-Diagramm dieses Eintrags verwendet wird.":
26000 "Dieses Feld enthält den Namen der Umrüstgruppe":
26100 "Dieses Feld legt die Umrüstzeit fest, die anfällt, wenn sich das angegebene Attribut zwischen Vorgängen ändert, die unmittelbar hintereinander geplant sind.":
26200 "Der Anzeigename des Benutzertools":
26210 "Das Ereignisskript, das nach Auswahl des Benutzertools ausgeführt wird":
26220 "Der Toolmenüname des Benutzerfensters":
26230 "Die Codefunktion zum Ausfüllen der Inhalte des Benutzerfensters":
26240 "Die Bezeichnung des Benutzerfensters":
26300 "Der Name der Menüschaltfläche. Der Name gibt einen Hinweis, an welcher Stelle die Schaltfläche im Menüsystem angezeigt wird":
26310 "Dieses Feld steuert, ob die Schaltfläche aktiviert ist, und steuert somit, ob sie angezeigt wird":
26320 "Dieses Feld steuert den Text, der auf der Schaltfläche angezeigt wird":
26330 "Das Ereignisskript, das nach Auswahl der Menüschalfläche ausgeführt wird":
;
