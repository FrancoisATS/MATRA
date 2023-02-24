#VERSION 0
;
ITA POPUP HELP
1 "Nessun argomento della Guida associato a questo elemento.":
10 "Questo campo consente di identificare l'ordine a cui appartiene la parte. Nella prima operazione di un ordine è impostato su PARENT, in altre operazioni è impostato sul nome o sul numero univoco dell'ordine.":
40 "Questo campo consente di identificare il numero di parte. Se si fa clic sul pulsante, vengono visualizzati tutti i numeri di parte nella tabella dati dei prodotti. La selezione di un numero di parte modifica automaticamente il nome del prodotto.":
41 "Questo campo contiene un elenco dei diversi stati che è possibile definire rispetto a un ordine. I valori sono ricavati dalla tabella dati Stato dell'ordine, a cui è possibile aggiungere nuovi stati in base alle necessità. È possibile utilizzare un motivo della barra delle operazioni, impostato nella tabella dati Stato dell'ordine in base a ogni tipo di stato, quando un ordine viene pianificato nel Sequenziatore.":
45 "Questo campo consente di identificare il numero parte.":
50 "Questo campo consente di identificare il nome del prodotto. Utilizzare il pulsante per selezionare il nome e il numero parte verrà modificato automaticamente.":
55 "Questo campo consente di identificare il nome del prodotto.":
60 "Questo campo consente di identificare il numero d'ordine di questo prodotto, ad esempio un numero d'ordine interno o specificato dal cliente. Il numero d'ordine deve essere univoco.":
70 "Questo campo può essere utilizzato per aggiungere note su questo ordine, ad esempio un promemoria relativo alle scadenze o un semplice messaggio rivolto all'imballatore/assemblatore nel reparto di fabbrica.":
75 "Apre una finestra di dialogo che mostra tutte le informazioni sull'attributo per l'operazione.":
80 "Utilizzare questo campo per impostare la priorità per il job che verrà utilizzato a sua volta dal sequenziatore. Minore è il numero, maggiore è la priorità. Tenere presente che le priorità possono essere negative; una priorità negativa è superiore a una positiva. Ad esempio, -100 è superiore a -1 e 0 è superiore a 10.":
90 "Questo campo consente di impostare il numero di operazioni per un job. È utilizzato per sequenziare il processo nel Sequenziatore. Le operazioni numeriche con il numero più basso verranno completate prima di avviare le operazioni associate a un numero più alto. Se in un prodotto esistono più operazioni con lo stesso numero, verranno entrambe completate prima di avviare le operazioni con un numero più alto.":
110 "Nome o descrizione scritta dell'operazione che viene eseguita, identificata anche dal numero di operazione.":
112 "Apre una finestra di dialogo che contiene informazioni sui dati delle risorse assegnati a questa operazione":
120 "I gruppi di configurazione sono definiti nella tabella dati Gruppi di configurazione, ad esempio Gruppo di configurazione 1, Gruppo di configurazione 2 e così via. Questi valori vengono utilizzati come assi di una delle matrici Tempo di configurazione dipendente dalla sequenza, che definisce il tempo di avvicendamento tra i prodotti che appartengono a gruppi di configurazione diversi(il tempo è in genere impostato nella tabella dati Risorse). I singoli gruppi di installazione sono allocati ai prodotti nella tabella dati Prodotti. Questo valore predefinito può tuttavia essere sovrascritto nel file Pianificazione principale.":
130 "Questo campo identifica il gruppo di risorse valide che possono eseguire l'operazione corrente.":
140 "All'occorrenza, questo campo può essere utilizzato per identificare una risorsa specifica che deve elaborare l'operazione. Se è stato impostato su 'Seleziona da gruppo' nella tabella dati dei prodotti, è possibile utilizzare una delle risorse del gruppo visualizzata nel campo Gruppo di risorse. Se si desidera forzare l'operazione per una risorsa specifica nel gruppo, utilizzare l'elenco a discesa e selezionare la risorsa desiderata.":
150 "Questo campo mostra la risorsa effettiva che elaborerà l'operazione. Se l'ordine non è già stato pianificato, il campo viene impostato su 'Non specificato'. Se l'operazione è già stata caricata nel quadro di pianificazione, verrà visualizzata la risorsa attualmente impostata per il caricamento.":
180 "Questo campo consente di specificare se la velocità di elaborazione viene calcolata come Tempo per batch, Tempo per elemento o Quantità all'ora. Se è selezionato 'Tempo per batch', il tempo indicato nel campo sottostante indica il tempo necessario per elaborare tutte le parti nel batch. Se invece è selezionato 'Tempo per elemento', il tempo di elaborazione corrisponderà al valore nel campo sottostante moltiplicato per le dimensioni del batch. Se è selezionato 'Quantità all'ora', il tempo di elaborazione verrà calcolato direttamente dal numero nel batch.":
220 "Il tipo di tempo del processo attualmente selezionato è 'Tempo per pezzo'. In questo campo è necessario immettere un tempo di operazione per ogni pezzo.":
230 "Il tipo di tempo del processo attualmente selezionato è 'Tempo per batch'. In questo campo è necessario indicare un tempo totale di operazione per il batch.":
240 "Il tipo di tempo del processo attualmente selezionato è 'Quantità all'ora'. In questo campo è necessario indicare il numero di elementi che è possibile produrre ogni ora.":
251 "Il colore in questo campo indica al Sequenziatore di mostrare una sezione della barra Diagramma di Gantt in un colore diverso. Il colore è assegnato alla barra in base al valore immesso nei campi Quantità batch intermedio e Tempo batch intermedio.":
260 "Questo campo consente di specificare la quantità dell'ordine o del batch.":
270 "Questo campo consente di specificare il profitto associato all'ordine o al batch e può essere utilizzato per influenzare il sequenziamento quando si utilizza la regola di pesatura.":
280 "Se la funzione MakeSpan è attivata, questo campo mostra l'ora di inizio della prima operazione in questo ordine":
290 "Se la funzione MakeSpan è attivata, questo campo mostra l'ora di fine dell'ultima operazione in questo ordine":
300 "Questo valore determina la quantità da elaborare per l'avvio dell'operazione successiva. Il valore Non specificato impedisce la sovrapposizione delle operazioni":
360 "Utilizzato per specificare una data prima della quale non è possibile avviare il job. Potrebbe corrispondere, ad esempio, al momento in cui i materiali saranno disponibili.":
370 "Questo campo serve per stabilire la Due Date. La Due Date viene utilizzata per evidenziare gli elementi in ritardo nel Sequenziatore e assegnare la priorità al caricamento dei job nel quadro di pianificazione se l'opzione 'Due Date' è stata selezionata.":
380 "Selezionare questa opzione per indicare allo Schedulatore che gli orari di inizio e di fine sono valori 'effettivi'. Se impostata, l'opzione impedisce che venga annullata l'allocazione dell'ordine nelle risorse del Sequenziatore. Di fatto, l'ordine viene fissato in modo permanente al quadro di pianificazione.":
390 "Durante il sequenziamento, lo Schedulatore imposta questo campo sull'ora alla quale è schedulato l'inizio del processo di set-up per il job.":
400 "Durante il sequenziamento lo Schedulatore aggiorna questo campo impostandolo sull'ora alla quale è schedulato l'inizio del job.":
410 "Durante il sequenziamento lo Schedulatore aggiorna questo campo impostandolo sull'ora alla quale è schedulata la fine del job.":
420 "Impostare questa opzione se non si desidera deallocare questo job dopo aver selezionato Deallocare tutti i job nel sequenziatore. L'operazione verrà bloccata. Lo stesso risultato si ottiene con la modalità 'Evidenzia operazioni bloccate' nel Sequenziatore: è sufficiente posizionare il puntatore del mouse su un'operazione (icona o barra nella Panoramica), premere il tasto MAIUSC sulla tastiera e fare clic con il pulsante sinistro del mouse.":
421 "Quando viene eseguita la pianificazione automatica delle operazioni, le operazioni per le quali questa opzione è selezionata resteranno non allocate nella finestra delle operazioni non allocate.":
430 "Consente di attribuire caratteristiche definibili dall'utente ai prodotti, come ad esempio il colore. All'interno di una caratteristica specifica, ai record degli attributi viene assegnato un livello di priorità, ad esempio i prodotti 'bianchi' possono avere una priorità più alta di quelli 'gialli'. Questi attributi vengono utilizzati dalle regole di impostazione della sequenza preferite dello Schedulatore, consolidando gli ordini simili all'interno del Periodo di anticipo.":
440 "Digitare le informazioni sulla quantità completata e immettere l'ora in cui il 'batch di parti' è stato completato nel campo Tempo batch intermedio. Lo Schedulatore ricalcola automaticamente l'ora di fine per questa operazione.":
450 "Digitare l'ora in cui il 'batch di parti' è stato completato e immettere le informazioni sulla quantità completata nel campo Quantità batch intermedio. Lo Schedulatore ricalcola automaticamente l'ora di fine per questa operazione.":
460 "Il campo Tempo op. effettivo utilizza le voci dei campi 'Quantità batch intermedio' e 'Tempo batch intermedio' per calcolare il tempo di un'operazione rivista, sulla base di tali informazioni. Tenere presente che il corretto funzionamento di questa funzionalità richiede che i campi 'Quantità batch intermedio' e 'Tempo batch intermedio' vengano modificati quando l'Editor è visualizzato all'interno del Sequenziatore. Altrimenti il 'Tempo op. effettivo' verrà modificato solo all'avvio successivo del Sequenziatore.":
474 "Utilizzato per registrare il costo di un elemento nel punto in cui viene introdotto nel processo. Il campo può essere utilizzato per registrare i costi fissi per elemento, come il trattamento termico subappaltato e così via.":
476 "Utilizza il Costo del materiale per elemento per fornire il costo del materiale del batch nel punto in cui il costo per elemento viene introdotto nel processo.":
477 "Costo diretto del job nel processo corrente.":
530 "Stabilisce un orizzonte temporale in cui i job possono essere raggruppati in batch ai fini della produzione. Una risorsa che completa un'operazione nel quadro di pianificazione verrà proiettata da quel punto verso l'orizzonte temporale stabilito dalla finestra Periodo di anticipo. I Criteri della sequenza preferita, impostati nella tabella dati Risorse, vengono applicati a job specifici della produzione la cui Due Date rientra in tale orizzonte temporale. La finestra Periodo di anticipo può essere stabilita per singoli prodotti, nella tabella dati Prodotti, e modificata per i singoli ordini nel file Pianificazione principale, oppure può essere definita come una regola globale nelle Informazioni sull'impostazione della configurazione.":
540 "Stabilito nella tabella dati Prodotti, consente di accedere a un documento Word che contiene informazioni riguardanti il prodotto. È inoltre possibile accedere al documento e modificarlo dall'editor dei file Pianificazione principale.":
541 "Questo campo viene utilizzato per descrivere lo stato di avanzamento di una singola operazione. Esistono quattro stati di avanzamento diversi: Non avviato; Setup; In esecuzione; Completato":
550 "Ai prodotti possono essere associate caratteristiche specifiche, che sono riportate nella tabella di dati Attributi dello Schedulatore. Queste tabelle sono definite dall'utente. La tabella Attributo prodotto 1, ad esempio, può essere riservata al colore e contenere singoli record denominati rosso, blu, verde e così via. Gli attributi di prodotto possono essere selezionati nel campo Corrispondenza Like to Like nella tabella di dati dei prodotti per definire un tempo di Configurazione Like to Like.":
560 "Consente di stabilire un livello di priorità tra record nella tabella dati Attributo prodotto 1, utilizzata dalla selezione della sequenza delle Regole APS.":
570 "Ai prodotti possono essere associate caratteristiche specifiche, che sono contenute nella tabella di dati Attributi dello Schedulatore. Queste tabelle sono definite dall'utente. La tabella Attributo 2, ad esempio, può essere riservata al materiale e contenere singoli record denominati acciaio, ottone, rame e così via. Gli attributi di prodotto possono essere selezionati nel campo Corrispondenza Like to Like nella tabella di dati dei prodotti per definire un tempo di Configurazione Like to Like.":
580 "Consente di stabilire un livello di priorità tra record nella tabella dati Attributo prodotto 2, utilizzata dalla selezione della sequenza delle Regole APS.":
590 "Ai prodotti possono essere associate caratteristiche specifiche, che sono contenute nella tabella di dati Attributi dello Schedulatore. Queste tabelle sono definite dall'utente. La tabella Attributo 3, ad esempio, può essere riservata alla larghezza del materiale e contenere singoli record denominati 16', 18', 20', 24' e così via. Gli attributi di prodotto possono essere selezionati nel campo Corrispondenza Like to Like nella tabella di dati dei prodotti per definire un tempo di Configurazione Like to Like.":
600 "Consente di stabilire un livello di priorità tra record nella tabella dati Attributo prodotto 3, utilizzata dalla selezione della sequenza delle Regole APS.":
602 "Questo campo calcola la durata dell'intero ordine dall'ora in cui inizia la configurazione della prima operazione all'ora in cui finisce l'ultima operazione dell'ordine.":
620 "Una regola di distribuzione che calcola un numero di indice dividendo il tempo che manca alla Due Date per il tempo previsto necessario per completare il job. Un rapporto inferiore a 1 indica che il job è in ritardo rispetto alla schedulazione, mentre un rapporto superiore a 1 indica che è in anticipo rispetto alla schedulazione.":
815 "Questa opzione consente di stabilire i valori dei tempi di setup e di operazione. Viene inoltre utilizzata per aggiornare l'avanzamento dei job attraverso il sistema di produzione.":
1020 "Specifica il nome del Gruppo di risorse, che verrà utilizzato per identificare gruppi specifici di risorse in grado di svolgere funzioni simili.":
1030 "Identifica le risorse valide per il Gruppo di risorse. Una risorsa può appartenere a più di un gruppo.":
1060 "Se questa opzione è attivata, consente di visualizzare il grafico di utilizzo per il gruppo di risorse nella finestra con più grafici del Sequenziatore.":
1070 "Questo colore verrà visualizzato sul grafico di utilizzo, che è visibile nella finestra con più grafici del Sequenziatore.":
1080 "Il grafico di utilizzo, presente nella finestra con più grafici del Sequenziatore, visualizza questo colore quando l'utilizzo supera il numero di ore disponibili per la risorsa o il gruppo di risorse (se il campo Ore max utilizzo è impostato come non specificato). Se nel campo Ore max utilizzo è stato invece inserito un valore, il grafico cambierà colore in base al valore specificato.":
1090 "Il grafico di utilizzo, disponibile nella finestra con più grafici del Sequenziatore, utilizza questo colore per tracciare una linea che delimita l'utilizzo della configurazione misurato in ore.":
2020 "Specifica il nome della singola risorsa.":
2023 "Il costo orario associato all'esecuzione della risorsa.":
2024 "Applica i valori del campo 'Fattore di costo (%)', stabilito in Record del calendario master, al costo orario della risorsa.":
2030 "Questa finestra di dialogo contiene informazioni sulle modalità di visualizzazione di una risorsa o di un Gruppo di risorse nella finestra Panoramica sequenza e Grafici di utilizzo.":
2040 "Può essere impostato su Visibile, Ridotto a icona o Disattivato. Utilizzato per controllare lo stato iniziale della finestra di questa risorsa quando viene avviato il Sequenziatore. Normalmente è impostato su Ridotto a icona. Se è impostato su Disattivato, la risorsa non viene utilizzata per il sequenziamento.":
2050 "Controlla la scala orizzontale (tempo) delle finestre delle risorse Gantt nel Sequenziatore. Può variare da minuti a settimane per ogni unità.":
2070 "Consente di impostare la capacità di una risorsa su Finita, Infinita o Infinita con modelli di variazione.":
2071 "Consente di impostare la capacità di una risorsa su Finita, Infinita o Infinita con modelli di variazione durante l'esecuzione della modalità Sequenziatore con capacità infinita.":
2080 "Controlla la scala orizzontale (tempo) delle finestre delle risorse affiancate nel Sequenziatore.":
2100 "Seleziona i vincoli secondari da applicare a una risorsa primaria. Specifica la quantità di vincoli richiesta dalla risorsa e il modo in cui il vincolo viene applicato alla risorsa primaria.":
2110 "Stabilisce se l'utilizzo della risorsa secondaria deve essere incrementato o decrementato, come nel caso, ad esempio, di un Incremento per durata che utilizza il vincolo secondario per tutta la durata dell'operazione e lo rilascia al completamento. Se un job viene collocato in un'apparecchiatura utilizzata per diverse operazioni, è possibile specificare un Incremento all'avvio per la prima operazione e un Decremento alla fine per l'ultima operazione. In questo modo l'apparecchiatura non verrà utilizzata per un altro job mentre il primo è in coda per una risorsa.":
2120 "Specifica la quantità richiesta del vincolo secondario. Se il valore 'Quantità' è selezionato, la quantità richiesta è uguale alla quantità del batch da elaborare.":
2130 "Definisce un attributo di un'operazione che impedirà l'esecuzione contemporanea di operazioni non analoghe in una risorsa con capacità infinita.":
2150 "Utilizzato nei prodotti APS per stabilire i criteri che devono essere utilizzati dalle regole di sequenziamento preferite nella selezione del lavoro da elaborare.":
2160 "Utilizzato nei prodotti APS dalle regole di pianificazione 'Riduci al minimo i WIP' per stabilire i margini di tempo in cui è possibile accumulare i semilavorati, prima delle risorse selezionate.":
2180 "Un valore numerico utilizzato per definire l'ordine di visualizzazione delle risorse nella tabella dei dati delle risorse. Può essere utilizzato anche per ignorare l'ordine predefinito in cui le risorse vengono visualizzate nella panoramica della sequenza.":
2181 "Visualizza la finestra di dialogo in cui è possibile definire le opzioni avanzate dei vincoli delle risorse, se necessario":
2182 "Consente di definire relazioni complesse tra le risorse tramite le espressioni. I dettagli sulla creazione e sulla sintassi delle espressioni sono disponibili nella documentazione.":
2183 "Consente all'utente di scegliere un attributo di un'operazione in una risorsa con capacità infinita, che specifica che è possibile pianificare contemporaneamente solo le operazioni con lo stesso valore nell'attributo selezionato.":
2185 "Determina se una linea di separazione viene visualizzata sotto la risorsa nel diagramma di Gantt. Può risultare utile quando le risorse vengono visualizzate in gruppi.":
2190 "Determina il modo in cui la risorsa verrà visualizzata nella Panoramica della sequenza. Le opzioni sono 'Sempre', 'Solo in gruppo' e 'Nascondi'.":
2191 "Determina il modo in cui le operazioni verranno visualizzate nella Panoramica della sequenza. Le opzioni sono 'In pila', che consente di visualizzare le operazioni in una riga della panoramica, e 'Sovrapponi', in cui ogni operazione è visualizzata su una linea di panoramica distinta.":
2200 "Utilizzato per stabilire una matrice di valori di configurazione dipendenti dalla sequenza, che definiscono il tempo di configurazione necessario per passare da un prodotto di un tipo di attributo a un altro.":
2201 "Questo campo consente di impostare il gruppo di avvicendamento assegnato a questa risorsa e determina di conseguenza i tempi di avvicendamento tra operazioni con attributi diversi.":
2202 "Determina se i tempi di configurazione e avvicendamento relativi alle operazioni su questa risorsa vengono applicati simultaneamente o in modo cumulativo.":
2205 "Se si utilizza questa casella di spunta, la risorsa non verrà più inclusa nel calcolo delle metriche relative alle prestazioni della pianificazione.":
2210 "Questo campo consente di selezionare il sistema Visualizzatore cui appartiene la risorsa. Il campo contiene un elenco di nomi di sistema dello Schedulatore ricavati dalla tabella di dati della Rubrica PCO.":
2220 "Questo pulsante consente di aprire una finestra di dialogo in cui sono elencati i diversi attributi associati alla risorsa.":
2230 "Questo campo consente di immettere i dati dell'attributo della stringa rispetto alla risorsa.":
2240 "Questo campo consente di immettere i dati dell'attributo reale rispetto alla risorsa.":
2250 "Questo campo consente di immettere i dati dell'attributo relativo alla durata rispetto alla risorsa.":
2260 "Questo campo indica l'efficienza di una risorsa. Il valore predefinito è 100%. Se l'efficienza viene impostata su 200%, le operazioni pianificate in questa risorsa verranno elaborate due volte più velocemente (metà del tempo rispetto al processo regolare).":
2270 "Campo di attivazione/disattivazione. Se è selezionato, il valore nel campo % efficienza viene applicato a tutte le operazioni che dispongono di un tempo di configurazione e sono pianificati nella risorsa su cui è impostato il campo di attivazione/disattivazione.":
2280 "Se questa opzione è attivata, consente di visualizzare il grafico di utilizzo per le risorse nella finestra con più grafici del Sequenziatore.":
2300 "Usare questo campo per selezionare un gruppo di vincoli secondari dal quale allocare un vincolo secondario durante l'ordinamento in sequenza.":
2310 "Il vincolo secondario, allocato dal gruppo di vincoli secondari, verrà assegnato in questo campo.":
5035 "Un moltiplicatore del fattore di costo, che influisce sul costo corrente della risorsa al quale è applicato. Un valore di 100% non applica alcun aumento, mentre un valore di 150% aumenta il costo corrente del 50%. Viene stabilito nella tabella dei dati Stati calendario e fornisce i valori predefiniti utilizzati nei file del calendario master.":
6100 "Visualizza una finestra di dialogo che consente di selezionare le risorse valide del gruppo selezionato e di assegnare dati specifici di una risorsa.":
6110 "Questo campo determina se la risorsa verrà selezionata durante il sequenziamento automatico. Se l'operazione non viene selezionata, sarà ancora possibile posizionarla manualmente nella risorsa.":
6120 "Questo campo consente di stabilire un singolo valore del tempo di configurazione per ciascuna delle risorse valide per l'operazione.":
6130 "Questo campo consente di stabilire un singolo tempo dell'operazione per ciascuna delle risorse valide per l'operazione.":
6131 "Questo campo consente di stabilire una singola quantità all'ora per ciascuna delle risorse valide per l'operazione.":
6132 "Questo campo consente di stabilire un singolo tempo di batch per ciascuna delle risorse valide per l'operazione.":
6140 "Questo campo viene utilizzato per definire una risorsa secondaria utilizzata dalla risorsa primaria durante l'operazione corrente.":
6150 "Questo campo viene utilizzato per specificare come viene utilizzato il vincolo secondario durante l'operazione, ad esempio Incremento per durata, Incremento solo tempo di configurazione e così via.":
6160 "Utilizzare questo campo per indicare la quantità del vincolo secondario richiesto durante l'operazione corrente, ad esempio è possibile specificare che l'operazione richiede un mandrino fisso.":
6170 "Lo Schedulatore utilizzerà questo intervallo di tempo per tentare di caricare l'operazione corrente nella risorsa preferita. Se l'operazione non va a buon fine entro questo limite di tempo, lo Schedulatore procede tentando di caricare l'operazione in altre risorse del gruppo.":
6180 "L'opzione Imposta gruppo di risorse successive definisce un 'elenco obbligatorio' di risorse, ossia quelle specificate nel gruppo selezionato. Le operazioni successive o a valle sono forzate a utilizzare solo le risorse contenute nell''elenco obbligatorio'. Pertanto, se la route di un processo chiama un gruppo di risorse in una operazione a valle che contiene elementi non inclusi nell'elenco, tali risorse non verranno utilizzate durante il sequenziamento. Imposta gruppo di risorse successive è una funzione cumulativa e può essere utilizzata in più di un'operazione nella route di un processo, aggiungendo risorse all''elenco obbligatorio'.":
6190 "La funzione Reimposta gruppo di risorse successive consente di rimuovere tutte le risorse, contenute nel Gruppo di risorse selezionato, dall''elenco obbligatorio' stabilito dal comando 'Imposta gruppo di risorse successive'. Se è stato definito un gruppo di risorse teorico denominato 'Tutto', che include tutte le risorse disponibili, nelle operazioni successive verranno utilizzate le risorse impostate nella route del processo originale.":
6230 "Questo campo consente di specificare un tempo di configurazione, effettuando la conversione dal prodotto precedente al prodotto corrente. I valori nel campo 'Tempo di configurazione' verranno aggiunti ai valori di configurazione eventualmente stabiliti per la risorsa da una matrice Tempo di configurazione dipendente dalla sequenza.":
6430 "Selezionare il nome di un'icona dall'elenco a discesa. Il pulsante di modifica consente di creare nuove icone.":
6470 "Visualizza la finestra di dialogo Vincoli secondari validi, consentendo di applicare vincoli validi a singoli record di questa tabella. In questa sezione è anche possibile modificare le caratteristiche dell'utilizzo dei vincoli.":
6530 "Specifica l'intervallo di tempo massimo consentito tra due operazioni sequenziali. L'intervallo di tempo massimo è qualificato dal campo 'Tipo di intervallo' che stabilisce le relazioni 'Inizio a inizio', 'Fine a fine' e così via.":
6540 "Stabilisce la relazione utilizzata per interporre il massimo intervallo di tempo tra due operazioni contigue, definito nel campo 'Tempo max prima dell'op. successiva'. Questa relazione può essere 'Fine a fine', 'Fine a inizio', 'Inizio a inizio' o 'Inizio a fine'.":
6550 "Specifica il periodo di tempo massimo, espresso come una percentuale del tempo di elaborazione teorico, durante il quale un'operazione può estendersi quando viene inserita in una sequenza automatica dal Sequenziatore.":
6560 "Definisce un intervallo di slack time specifico da inserire tra l'operazione corrente e l'operazione precedente.":
6565 "Definisce un intervallo di slack time specifico da inserire tra l'operazione corrente e l'operazione successiva.":
6580 "Questo campo consente di applicare un ordine di moltiplicazione alla velocità di elaborazione per modificare la durata dell'operazione.":
6681 "Questo campo consente di specificare un attributo di questo record a cui viene fatto riferimento da una delle tabelle di attributi. Può essere utilizzato per influire sui tempi di pianificazione, sull'ordine della pianificazione e sull'utilizzo dei vincoli.":
6682 "Questo campo consente di specificare un attributo di stringa in formato libero di questo record. Può essere utilizzato per impostare le opzioni di visualizzazione e raggruppare le operazioni.":
6683 "Questo campo consente di specificare un attributo numerico di questo record. Può essere utilizzato per impostare le opzioni di visualizzazione, influire sull'ordine della pianificazione e applicare vincoli all'utilizzo.":
6684 "Questo campo consente di specificare un attributo della data di questo record. Può essere utilizzato per impostare le opzioni di visualizzazione e influire sull'ordine della pianificazione.":
6685 "Questo campo consente di specificare un attributo della durata di questo record. Può essere utilizzato per impostare le opzioni di visualizzazione e influire sull'ordine della pianificazione.":
6690 "Il campo Buffer di consegna contiene il tempo di buffer che viene sottratto dalla Due Date durante il sequenziamento a ritroso, in modo tale che le operazioni siano schedulate prima dell'istante al più tardi. L'opzione consente che si verifichino ritardi imprevisti nel processo.":
7020 "Il numero di giorni prima dell'ora corrente che può essere visualizzato nella Panoramica della sequenza.":
7030 "Il periodo di tempo, dopo l'ora corrente, che può essere visualizzato nella Panoramica del Sequenziatore.":
7035 "Apre una finestra di dialogo perla configurazione che consente all'utente di personalizzare la Panoramica della sequenza.":
7040 "Specifica un periodo di scostamento, dal momento di immissione dell'ordine, prima del quale non è possibile avviare un job. Se impostato su Non specificato, non esiste alcuna restrizione diversa dall'ora corrente.":
7050 "Specifica un periodo di scostamento, dal momento di immissione dell'ordine, in base al quale il job deve essere disponibile. Sovrascrivibile.":
7060 "Il tempo di scostamento del terminatore rispetto all'ora corrente. Il terminatore rappresenta l'ora corrente quando il relativo scostamento è impostato su 0 ore 00 min.":
7067 "Stabilisce le opzioni di calcolo del costo, che comprendono: Durante la sequenza, Dopo la sequenza o Mai.":
7120 "Imposta la modalità di panoramica della sequenza.":
7130 "Il numero di giorni a partire dalla data corrente per l'avvio della panoramica della sequenza.":
7140 "Il numero di giorni a partire dalla data corrente per la fine della panoramica della sequenza.":
7320 "Consente di selezionare lo script necessario per l'importazione degli ordini dalla tabella dei dati 'Script'.":
7330 "Consente di selezionare lo script necessario per l'esportazione degli ordini dalla tabella dei dati 'Script'.":
7430 "Campo di attivazione/disattivazione. Quando viene selezionato, compare un piccolo triangolo nero su ogni barra delle operazioni nel Sequenziatore. Questa funzione semplifica l'attività di trascinamento delle operazioni allocate nel quadro di pianificazione, in particolare delle operazioni più piccole.":
7450 "Specifica lo script dell'evento PESP predefinito che deve essere eseguito durante l'importazione degli ordini dal pulsante 'Importa ordini' nel menu Trasferimento dati.":
7470 "Specifica lo script dell'evento PESP predefinito che deve essere eseguito durante l'esportazione degli ordini dal pulsante 'Esporta ordini' nel menu Trasferimento dati.":
7480 "Specifica lo script dell'evento PESP predefinito che deve essere eseguito durante il rilascio di una pianificazione dal pulsante 'Rilascia pianificazione' nel menu Trasferimento dati.":
7490 "Specifica lo script dell'evento PESP predefinito che deve essere eseguito durante l'allocazione delle operazioni nel Sequenziatore con l'opzione Regole APS attivata.":
8020 "Nome vincolo secondario.":
8030 "Consente di selezionare il colore del Grafico degli utenti del Sequenziatore quando i valori sono compresi tra il limite massimo e minimo.":
8040 "Imposta il motivo di riempimento del grafico.":
8060 "Colore del motivo di riempimento se il grafico supera il limite massimo.":
8080 "Colore del motivo di riempimento se il grafico supera il limite minimo.":
8090 "Specifica se questo vincolo secondario deve applicarsi alla pianificazione quando si utilizza un prodotto 300 FCS o versioni successive. In tutte le versioni, se questa casella di controllo non viene selezionata, il Sequenziatore non emette più avvisi quando i limiti impostati per questo vincolo secondario vengono superati.":
8091 "In modalità Sequenziatore con capacità infinita, questo campo specifica se il vincolo secondario deve essere applicato alla pianificazione quando si utilizza un prodotto 300 FCS o versioni successive.":
8092 "Opzioni per il controllo del comportamento di questo vincolo quando il sistema è impostato sulla modalità Capacità infinita.":
8100 "Determina in che modo l'efficienza del calendario delle risorse primarie influisce sull'utilizzo di questo vincolo secondario. Le opzioni sono: Nessun effetto; Efficienza all'avvio del job; Segui le variazioni dell'efficienza; Utilizza 100% se maggiore di 0%":
8101 "In modalità Sequenziatore con capacità infinita, questo campo determina in che modo l'efficienza del calendario delle risorse primarie influisce sull'utilizzo di questo vincolo secondario. Le opzioni sono: Nessun effetto; Efficienza all'avvio del job; Segui le variazioni dell'efficienza; Utilizza 100% se maggiore di 0%":
8120 "Questo pulsante consente di aprire una finestra di dialogo in cui sono elencati i diversi attributi associati al vincolo secondario.":
8130 "Questo campo consente di immettere i dati relativi agli attributi della stringa rispetto al vincolo secondario.":
8140 "Questo campo consente di immettere i dati relativi agli attributi reali rispetto al vincolo secondario.":
8150 "Questo campo consente di immettere i dati relativi agli attributi di durata rispetto al vincolo secondario.":
8160 "Se questa opzione è attivata, consente di visualizzare il grafico di utilizzo per il vincolo secondario nella finestra con più grafici del Sequenziatore.":
8200 "Il nome del gruppo di vincoli secondari.":
8210 "Consente di selezionare i vincoli secondari che fanno parte di questo gruppo.":
9020 "Nomi dei gruppi di configurazione. Rappresentano l'asse X e Y della matrice Tempo di configurazione dipendente dalla sequenza nella tabella dati Risorse.":
12020 "Nome di un record di attributo nella tabella di dati Attributo prodotto 1.":
13020 "Nome di un record di attributo nella tabella di dati Attributo prodotto 2.":
14020 "Nome di un record di attributo nella tabella di dati Attributo prodotto 3.":
16020 "Il nome utilizzato per descrivere la configurazione dello schermo salvata con Nome file. Questa descrizione viene utilizzata anche come descrizione delle icone per le barre degli strumenti dell'area di lavoro.":
16030 "Il file viene scelto tramite l'opzione offerta dal pulsante a sinistra del campo. Il file di configurazione dell'area di lavoro originale viene salvato con l'estensione .WPI utilizzando il comando Salva area di lavoro, disponibile nella sezione Area di lavoro nel menu Sequenziatore.":
18510 "Il nome dell'individuo o dell'organizzazione che effettua un ordine.":
18520 "Nome del contatto primario all'interno di un'organizzazione che effettua un ordine.":
18530 "Numero telefonico da utilizzare in relazione a un ordine.":
18540 "Indirizzo e-mail da utilizzare in relazione a un ordine.":
21000 "Questo campo consente di inserire diversi 'stati dell'ordine'. Lo Stato dell'ordine può essere selezionato in base a un ordine nel file Pianificazione.":
21020 "Questo campo contiene la descrizione del nome dello stato dell'ordine che è stato immesso nel campo 'Nome stato ordine'.":
21100 "Nome del record dell'attributo nella tabella Dati attributo.":
21110 "Consente di stabilire un livello di priorità tra record nella tabella di dati Attributo, che può essere utilizzata dalle regole di pianificazione":
24000 "Questo campo specifica se il record è un elemento padre o figlio del set di regole.":
24010 "Contiene il nome del set di regole.":
24020 "Questo interruttore viene utilizzato per cancellare i collegamenti di pegging solo per gli ordini che si trovano nella coda di domanda del primo passaggio (abilitato o meno) del set di regole.":
24030 "Contiene il nome della funzione specifica del passaggio di regola.":
24040 "Interruttore. Se è impostato su true, consente il passaggio della regola; se è impostato su false, questo passaggio di regola specifico verrà ignorato durante l'esecuzione del set di regole.":
24050 "Se questa opzione è impostata su true e viene eseguito il set di regole, nella directory di lavoro viene creato un file di debug.":
24060 "Questo campo consente di specificare criteri che possono essere utilizzati per limitare gli elementi inseriti nella Coda di approvvigionamento interno. Il valore predefinito di questo campo è impostato su ALL, ma può essere modificato inserendo un'espressione come la seguente: (~{$Order Type}~==~Stock~). Questa coda filtra i record contenuti nel database 'Ordini di lavoro'.":
24070 "Questo campo contiene criteri che possono essere utilizzati per classificare gli elementi nella Coda di approvvigionamento interno. Ad esempio, è possibile classificare la Coda di approvvigionamento interno in base a Due Date, Data di inizio al più presto o Priorità.":
24080 "Questo campo consente di specificare criteri che possono essere utilizzati per limitare gli elementi inseriti nella Coda di domanda. Il valore predefinito di questo campo è impostato su ALL, ma può essere modificato inserendo un'espressione come la seguente: (~{$Order Type}~==~Stock~). Questa coda filtra i record contenuti nel database 'Ordini di lavoro'.":
24090 "Questo campo contiene criteri che possono essere utilizzati per classificare gli elementi nella Coda di domanda interna. Ad esempio, è possibile classificare la Coda di domanda interna in base a Due Date, Data di inizio al più presto o Priorità.":
24100 "Questo campo contiene un elenco delle varie regole di pegging standard che è possibile utilizzare per eseguire il pegging degli ordini. Include tre opzioni speciali, ossia Definito dall'utente, Funzione utente e Script PESP, che consentono di creare regole più personalizzate.":
24110 "Questo campo è visibile solo se il campo 'Tipo di regola' è impostato su 'Definito dall'utente' o 'Funzione utente'. L'espressione da utilizzare per la regola viene immessa in questo campo. La seguente, ad esempio, è un'espressione tipica che consente di collegare gli ordini di domanda e approvvigionamento solo se i capi 'Attributo prodotto 1' hanno lo stesso valore: (~{+:$Product Attribute 1}~==~{-:$Product Attribute 1}~).":
24120 "Questo campo è visibile solo se il campo 'Tipo di regola' è impostato su 'Script PESP'. Contiene il nome dello script PESP da utilizzare come regola.":
24130 "Questa opzione consente di creare collegamenti alle righe DBA anche se la quantità relativa a tali righe non viene completamente soddisfatta. Tutti gli elementi in difetto verranno evidenziati come carenze.":
24140 "Questa opzione consente di creare collegamenti solo alle righe DBA in cui la quantità corrispondente viene completamente soddisfatta. Tutti gli elementi in difetto verranno evidenziati come carenze.":
24141 "Se questa opzione è selezionata, il comportamento predefinito di SMC viene ignorato ed è possibile creare collegamenti a ritroso quando la produzione viene eseguita dopo il consumo.":
24150 "Se l'opzione è impostata su true, è possibile ricollegare gli ordini già pianificati.":
24160 "Se questa opzione è impostata su true, il campo 'Classificazione coda di approvvigionamento' consente di classificare i record di approvvigionamento in base al criterio di selezione del campo 'Classificazione coda di approvvigionamento'. Questa opzione deve essere selezionata solo se tutti i record sono contenuti nel database 'Ordini di lavoro'.":
24170 "Questo campo consente di specificare criteri che possono essere utilizzati per limitare gli elementi inseriti nella Coda di approvvigionamento esterno. Il valore predefinito di questo campo è impostato su ALL, ma può essere modificato inserendo un'espressione come la seguente: (~{$Order Type}~==~Stock~). Questa coda filtra i record contenuti nel database 'Domanda'.":
24180 "Verranno elaborati tutti i campi con la classificazione INHERIT FROM SUPPLY(Field Name).":
24190 "Verranno elaborati tutti i campi con la classificazione INHERIT FROM DEMAND (Field Name).":
24200 "Se questa opzione è impostata su true, il campo 'Classificazione coda di domanda' consente di classificare i record di domanda in base al criterio di selezione del campo 'Classificazione coda di domanda'. Questa opzione deve essere selezionata solo se tutti i record sono contenuti nel database 'Ordini di lavoro'.":
24210 "Se l'opzione è impostata su true, la quantità di un collegamento creato viene allocata in multipli specifici. I multipli sono definiti in Dati DBA.":
24500 "Se l'opzione 'Utilizza sempre questo set di regole' è attivata, il set di regole di pegging selezionato in questo campo diventa il set di regole applicato per impostazione predefinita quando l'opzione 'Esegui pegging dei materiali' è selezionata nel Sequenziatore.":
24505 "Quando questa opzione globale è selezionata, il comportamento predefinito di SMC viene ignorato ed è possibile creare collegamenti a ritroso quando la produzione viene eseguita dopo il consumo.":
24510 "Se questo interruttore è attivo, la regola selezionata nel campo 'Set di regole di pegging selezionate' verrà utilizzata come regola predefinita da applicare quando l'opzione 'Esegui pegging dei materiali' è selezionata nel Sequenziatore. Se l'opzione 'Utilizza sempre questo set di regole' non è selezionata, quando si attiva l'opzione 'Esegui pegging dei materiali' nel Sequenziatore viene visualizzata una finestra di dialogo per la scelta delle regole, che consente di specificare la regola da applicare in quel momento.":
25400 "Questo è il campo che contiene il numero dell'ordine di approvvigionamento.":
25410 "Questo campo identifica il tipo di ordine, ad esempio Stock o Acquisto.":
25420 "Il nome dell'organizzazione che fornisce i materiali per l'ordine.":
25430 "Il numero di parte associato all'ordine.":
25440 "Descrizione della parte associata all'ordine.":
25450 "Data in cui viene fornito il materiale.":
25500 "Questo campo consente di identificare l'ordine a cui appartiene la parte. La prima riga di un ordine sarà il record padre e visualizzerà PARENT in questo campo, mentre le altre righe che fanno parte di questo ordine saranno il record figlio e visualizzare il numero di ordine a cui appartengono in questo campo.":
25510 "Questo è il campo che contiene il numero dell'ordine di domanda.":
25520 "Questo campo identifica il tipo di ordine, ad esempio Make-to-Stock o Ordine di vendita.":
25530 "Identifica in modo univoco una voce di un ordine.":
25540 "Il nome dell'organizzazione che richiede i materiali per l'ordine.":
25550 "Data in cui è necessario il materiale.":
25560 "Specifica il multiplo di un elemento che deve essere sottoposto a pegging. Un insieme di elementi va spesso a formare una scatola o una confezione. Ad esempio, 12 lattine formano una scatola. Arriva un ordine che richiede 60 lattine. L'ordine di approvvigionamento prevede 50 lattine. Il controllo dei materiali esegue il pegging solo per 48 lattine su 50 e cercherà altrove le altre 12 lattine richieste, ma stabilirà il collegamento solo se viene trovata la quantità esatta, pari a 12 lattine. Per attivare questa funzione, è necessario selezionare il campo 'Alloca solo multipli' nel database 'Regole di pegging'.":
25600 "Numero ordine a cui appartiene la riga DBA.":
25605 "Numero parte dell'ordine a cui appartiene la riga DBA.":
25610 "Numero operazione a cui appartiene la riga DBA.":
25611 "Nome dell'operazione a cui appartiene la riga DBA.":
25615 "Numero parte del prodotto che richiede il materiale specificato":
25620 "Numero parte dell'articolo DBA.":
25630 "Quantità richiesta dell'articolo DBA.":
25640 "Se impostato su true, questo campo determina la moltiplicazione della quantità dell'ordine per la quantità DBA richiesta.":
25650 "Ignora le carenze durante l'esecuzione della regola di pegging. Consente di pianificare gli ordini con carenze.":
25700 "Numero ordine in cui è prodotto il coprodotto.":
25705 "Numero parte dell'ordine in cui è prodotto il coprodotto.":
25710 "Numero operazione che produce il coprodotto.":
25715 "Nome dell'operazione che produce il coprodotto.":
25720 "Nome del coprodotto.":
25730 "Quantità di coprodotto prodotto.":
25740 "Se impostato su true, questo campo determina la moltiplicazione della quantità del coprodotto per la quantità dell'ordine.":
25800 "Questo campo identifica il tipo di ordine, ad esempio: Ordine di lavoro, Ordine di acquisto, Ordine di vendita o Stock":
25810 "Quando questa opzione è selezionata, l'operazione non schedulata non verrà più visualizzata nella finestra Operazioni non schedulate.":
25820 "Consente di visualizzare una finestra di dialogo che mostra i campi relativi a Controllo materiale.":
25830 "Questo campo fornisce informazioni sullo stato della domanda successivo al pegging dei materiali. I valori sono i seguenti: 'Sconosciuto', 'Soddisfatto', 'Tutte le carenze ignorate', 'Carenze', 'Approvvigionamento eccessivo', 'Approvvigionamento eccessivo, Carenze', 'Approvvigionamento eccessivo, Tutte le carenze ignorate'.":
25840 "Questo campo viene popolato dopo il pegging dei materiali. Quando viene creato un collegamento a un ordine di approvvigionamento nel database 'Ordini di approvvigionamento', il campo 'Data della domanda' nel database 'Ordini di lavoro' viene popolato con la 'Data di approvvigionamento' dell'ordine di approvvigionamento. Il campo 'Data di approvvigionamento' verrà confrontato con il campo 'Data di inizio al più presto' e verrà utilizzata la data più avanti nel tempo tra le due per stabilire quale data utilizzare durante la pianificazione.":
25850 "Questo campo viene popolato dopo il pegging dei materiali. Quando viene creato un collegamento a un ordine di domanda nel database 'Ordini di domanda', il campo 'Data di approvvigionamento' nel database 'Ordini di lavoro' viene popolato con la 'Data della domanda' dell'ordine di domanda. Il campo 'Data della domanda' verrà confrontato con il campo 'Due Date' e verrà utilizzata la data più indietro nel tempo tra le due per stabilire quale data utilizzare durante la pianificazione.":
25900 "Visualizza una finestra di dialogo con campi relativi allo stato di un'operazione.":
25910 "Questa opzione può essere selezionata quando viene suddiviso un ordine e consente a ogni lotto di produzione di procedere in maniera indipendente nel processo di produzione. Non è necessario, ad esempio, completare tutti i lotti di un'operazione prima che abbia inizio un'operazione successiva.":
25920 "Questo campo specifica il colore utilizzato nella barra nel diagramma di Gantt per questo record.":
26000 "Questo campo definisce il nome del gruppo di avvicendamento":
26100 "Questo campo imposta il tempo di avvicendamento che trascorre quando nell'attributo sono state specificate modifiche tra operazioni pianificate l'una dopo l'altra.":
26200 "Il nome visualizzato dello strumento utente":
26210 "Lo script dell'evento che viene eseguito quando si seleziona lo strumento utente":
26220 "il nome del menu degli strumenti nella finestra utente":
26230 "La funzione di codice per il popolamento dei contenuti nella finestra utente":
26240 "l'etichetta della finestra utente":
26300 "Il nome del pulsante di menu. Indica dove il pulsante viene visualizzato nel sistema di menu":
26310 "Questo campo controlla se il pulsante è abilitato e quindi se viene visualizzato":
26320 "Questo campo controlla il testo che verrà visualizzato sul pulsante":
26330 "Lo script dell'evento che viene eseguito quando si seleziona il pulsante del menu":
;
