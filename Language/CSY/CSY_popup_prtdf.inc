#VERSION 0
;
CSY POPUP HELP
1 "S touto položkou není asociováno žádné téma nápovědy.":
10 "Toto pole slouží k určení, ke které objednávce součást náleží. V první operaci dané objednávky je pole nastaveno na PARENT, v dalších operacích je nastaveno na jedinečné číslo objednávky nebo název.":
40 "Toto pole slouží k určení čísla součásti. Stisknutím tlačítka se všechna čísla součástí zobrazí v tabulce dat výrobků.":
41 "V tomto poli se nachází seznam různých stavů, které je možné pro objednávku definovat. Hodnoty jsou načítány z tabulky dat Stav objednávky, do které je možné přidávat v případě potřeby i nové stavy. Pomocí vzoru panelu operace (který se nastavuje v tabulce dat Stav objednávky pro každý typ stavu) je možné definovat vzor panelu operace objednávky, když je objednávka rozvrhnuta v Řadiči.":
45 "Toto pole slouží k určení čísla součásti.":
50 "Toto pole slouží k určení názvu výrobku. Pomocí tlačítka je možné vybrat název, číslo součásti bude změněno automaticky.":
55 "Toto pole slouží k určení názvu výrobku.":
60 "Toto pole slouží k určení čísla objednávky pro tento výrobek. Objednávka může mít interní číslo nebo může být specifikována zákazníkem. Číslo objednávky musí být jedinečné.":
70 "Toto pole může obsahovat poznámky k této objednávce. Může se jednat o připomínku k datu splatnosti nebo zprávu pro příslušného zaměstnance v dílně.":
75 "Otevře dialogové okno zobrazující všechna data atributů pro operaci.":
80 "Pomocí tohoto pole je možné nastavit prioritu zakázky, která se použije v řadiči. Nižší číslo znamená vyšší prioritu. Priorita může být i záporná, to znamená, že je důležitější než kladná. Například priorita -100 je důležitější než -1 a priorita 0 je důležitější než 10.":
90 "Toto pole nastavuje číslo operace pro zakázku. Toto číslo se používá k zařazení zakázky do posloupnosti v řadiči. Operace s nižšími čísly budou dokončeny před těmi s vyššími. Pokud ve výrobku existují dvě operace se stejným číslem, obě budou dokončeny před započetím operací s vyššími čísly.":
110 "Jedná se o písemný popis nebo název prováděné operace, která je určena také svým číslem.":
112 "Otevře dialogové okno obsahující informace o datech prostředků přiřazených k této operaci":
120 "Skupiny nastavení se definují v tabulce dat Skupiny nastavení, například Skupina nastavení 1, Skupina nastavení 2 atd. Tyto hodnoty se používají jako osy jedné z matic Doba nastavení závislá na posloupnosti, které stanovují dobu mezi změnami výrobků v různých skupinách nastavení (obvykle v tabulce dat prostředků). Jednotlivé skupiny nastavení se přidělí na výrobky v tabulce dat výrobků, výchozí hodnoty ovšem mohou být přepsány souborem hlavního rozvrhu.":
130 "Toto pole určuje skupinu platných prostředků, které mohou být použity k provedení aktuální operace.":
140 "V případě potřeby je možné toto pole použít k určení určitého prostředku, který má operaci zpracovat. Pokud bylo toto pole nastaveno v tabulce dat výrobků na položku 'Vybrat ze skupiny', pak je možné použít libovolné prostředky ve skupině zobrazené v poli Skupina prostředků. Chcete-li operaci na nějakém prostředku vynutit, vyberte požadovaný prostředek v rozevíracím seznamu.":
150 "V tomto poli se zobrazí prostředek, který zpracuje operaci. Pokud nebyla předtím objednávka rozvržena, toto pole se nastaví na hodnotu 'Nespecifikováno'. Pokud byla operace již načtena do plánovací tabulky, pak bude zobrazen prostředek, který má být načten.":
180 "Toto pole ukazuje, zda se rychlost zpracování počítá jako doba na dávku, doba na položku nebo rychlost za hodinu. Pokud je vybrána možnost 'doba na dávku', pak doba zobrazená v poli odpovídá době, kterou trvalo zpracovat všechny součásti v dávce. Pokud je vybrána možnost 'doba na položku', pak bude doba zpracování odpovídat hodnotě uvedené v poli níže vynásobené velikostí dávky. Pokud je vybrána možnost 'rychlost za hodinu', pak bude doba zpracování vypočítána přímo z počtu položek v dávce.":
220 "Možnost Typ doby zpracování je nastavena na 'Doba na položku'. Do tohoto pole je nutné zadat dobu operace pro každou položku.":
230 "Možnost Typ doby zpracování je nastavena na 'Doba na dávku'. Do tohoto pole je nutné zadat celkovou dobu operace celé dávky.":
240 "Možnost Typ doby zpracování je nastavena na 'Rychlost za hodinu'. Do tohoto pole je nutné zadat počet položek, které mohou být vyrobeny za hodinu.":
251 "Barva v tomto poli dává řadiči pokyn k zobrazení části pruhu Ganttova diagramu jinou barvou. Barva pruhu značí hodnotu, která byla zadána do polí Střední velikost dávky a Střední doba dávky.":
260 "Toto pole slouží k určení velikosti objednávky nebo dávky.":
270 "Toto pole slouží k určení zisku z objednávky nebo dávky a může být použito k ovlivnění tvorby posloupnosti při používání pravidla váhování.":
280 "Toto pole zobrazí počáteční čas první operace v této objednávce, pokud je zapnuta funkce MakeSpan":
290 "Toto pole zobrazí koncový čas poslední operace v této objednávce, pokud je zapnuta funkce MakeSpan":
300 "Tato hodnota určuje množství, které bude zpracováno před tím, než bude možné začít následující operaci. Hodnota Nespecifikováno zabraňuje překrývání operací":
360 "Slouží k určení data, před kterým není možné zakázku začít. Může se například jednat o dobu, kdy budou k dispozici materiály.":
370 "Toto pole slouží k určení data splatnosti. Datum splatnosti se používá ke zvýraznění opožděných položek v Řadiči a k nastavení priority načítání zakázek na plánovací tabulku, pokud je vybrána možnost 'datum splatnosti'.":
380 "Pomocí tohoto přepínače můžete Rozvrhovači určit, že počáteční a koncový čas obsahují 'skutečné' hodnoty. Při nastavení tento přepínač zabraňuje zrušení přidělení objednávky od prostředků v řadiči. Objednávka bude trvale připojena k plánovací tabulce.":
390 "Rozvrhovač toto pole nastaví při tvorbě posloupnosti na dobu, kdy je v zakázce rozvrženo spuštění přípravného procesu.":
400 "Rozvrhovač toto pole aktualizuje při tvorbě posloupnosti na dobu, kdy je rozvržen počátek zakázky.":
410 "Rozvrhovač toto pole aktualizuje při tvorbě posloupnosti na dobu, kdy je rozvržen konec zakázky.":
420 "Tento přepínač nastavte, pokud nechcete, aby byla tato zakázka nepřidělena po výběru možnosti Zrušit přidělení všech zakázek v řadiči. Tím dojde k uzamknutí operace. Tohoto je možné dosáhnout také v režimu hledání 'Zvýraznit uzamknuté operace' v Řadiči přemístěním ukazatele myši na operaci (ikonu nebo panel v přehledu), stisknutím klávesy shift a kliknutím levým tlačítkem myši.":
421 "Operace s aktivním přepínačem zůstanou při automatickém rozvrhování operací nepřiděleny v okně nepřidělených operací.":
430 "Umožňuje nastavit uživatelské vlastnosti na atributy výrobků, například barvu. Jednotlivé záznamy atributů mají v rámci určité vlastnosti přidělenu prioritu, například 'bílé' výrobky mají vyšší prioritu než 'žluté'. Tyto atributy jsou používány preferovanými pravidly tvorby posloupnosti rozvrhovače, čímž dochází ke slučování podobných objednávek v rámci předpovědi.":
440 "Vyplňte informace o dokončeném množství a do pole Střední doba dávky zadejte čas, kdy byla 'dávka součástí' dokončena. Rozvrhovač automaticky přepočítá 'Koncový čas' této operace.":
450 "Vyplňte čas, kdy byla 'dávka součástí' dokončena, a do pole Střední velikost dávky zadejte informace o dokončeném množství. Rozvrhovač automaticky přepočítá 'Koncový čas' této operace.":
460 "Pole Doba provádění operace používá položky v polích 'Střední velikost dávky' a 'Střední doba dávky' k výpočtu revidované doby operace podle těchto dat. Aby zařízení fungovalo správně, pole 'Střední doby dávek' a 'Střední velikosti dávek' by měly být upraveny, když je v Řadiči zobrazen Editor, v opačném případě se pole 'Doba provádění operace' změní pouze při dalším přístupu k Řadiči.":
474 "Používá se k zaznamenání nákladů na položku v době, kdy je vložena do procesu. Toto pole může být použito k uchování fixních nákladů na položku, například tepelné zpracování subdodavatelem atd.":
476 "Používá náklady na materiál položky k určení nákladů na materiál dávky v době, kdy jsou do procesu vloženy náklady na položku.":
477 "Přímé náklady na zakázku v aktuálním procesu.":
530 "Stanoví časový horizont, ve kterém je možné zakázky vložit do dávky pro výrobu. Prostředek, který dokončuje operaci v plánovací tabulce, bude postupovat od tohoto bodu v časovém horizontu stanoveném oknem Předpověď. Kritéria preferované posloupnosti nastavená v tabulce dat prostředků se použijí na vybrané zakázky, jejichž datum splatnosti spadá do tohoto časového horizontu. Okno Předpověď je možné stanovit vůči jednotlivým výrobkům v tabulce dat výrobků a je možné jej upravit pro jednotlivé objednávky v souboru hlavního rozvrhu, případně může být stanoveno jako globální pravidlo v části Informace přípravy konfigurace.":
540 "Tato položka, stanovená v tabulce dat výrobků, nabízí přístup k dokumentu aplikace Word obsahujícího informace týkající se výrobku. K dokumentu je možné získat přístup a upravovat jej také v editoru souboru hlavního rozvrhu.":
541 "Toto pole slouží k popsání postupu jednotlivých operací. Existují čtyři různé stavy postupu: Nezapočato; Nastavení; Spuštěno; Dokončeno":
550 "S výrobky mohou být asociovány určité vlastnosti, ty jsou v Rozvrhovači uloženy v tabulce dat atributů. Tyto tabulky jsou definovány uživatelem a například tabulka Atribut výrobku 1 může sloužit k ukládání barev jako záznamů nazvaných červená, modrá, zelená atd. Atributy výrobků je možné vybrat v poli Shoda podobnosti v tabulce dat výrobků a definovat tak dobu Nastavení podobnosti.":
560 "Používá se ke stanovení priorit mezi záznamy v tabulce dat Atribut výrobku 1, které se používají ve výběru tvorby posloupnosti pravidel APS.":
570 "S výrobky mohou být asociovány určité vlastnosti, ty jsou v Rozvrhovači uloženy v tabulkách dat atributů. Tyto tabulky jsou definovány uživatelem a například tabulka Atribut 2 může sloužit k ukládání materiálů jako záznamů nazvaných ocel, mosaz, měď atd. Atributy výrobků je možné vybrat v poli Shoda podobnosti v tabulce dat výrobků a definovat tak dobu Nastavení podobnosti.":
580 "Používá se ke stanovení priorit mezi záznamy v tabulce dat Atribut výrobku 2, které se používají ve výběru tvorby posloupnosti pravidel APS.":
590 "S výrobky mohou být asociovány určité vlastnosti, ty jsou v Rozvrhovači uloženy v tabulkách dat atributů. Tyto tabulky jsou definovány uživatelem a například tabulka Atribut 24 může sloužit k ukládání tlouštěk materiálů jako záznamy nazvaných 16', 18', 20', 24' atd. Atributy výrobků je možné vybrat v poli Shoda podobnosti v tabulce dat výrobků a definovat tak dobu Nastavení podobnosti.":
600 "Používá se ke stanovení priorit mezi záznamy v tabulce dat Atribut výrobku 3, které se používají ve výběru tvorby posloupnosti pravidel APS.":
602 "Toto pole vypočítá dobu trvání celé objednávky od času počátku nastavení první operace do času konce poslední operace objednávky.":
620 "Pravidlo odeslání, které vypočítá číslo indexu vydělením zbývající doby do data splatnosti očekávaným uplynulým časem k dokončení zakázky. Hodnota menší než 1 udává, že zakázka je vůči rozvrhu opožděná, hodnota větší než 1 znamená, že má vůči rozvrhu náskok.":
815 "Pomocí této možnosti je možné stanovit hodnoty pro dobu nastavení a provozu. Také se používá k aktualizaci postupu v zakázkách v celém produkčním systému.":
1020 "Určuje název skupiny prostředků. Název odlišuje jednotlivé skupiny prostředků, které mohou mít podobnou funkci.":
1030 "Určuje, které prostředky jsou pro skupinu prostředků platné. Prostředek může být členem více než jedné skupiny.":
1060 "Po zapnutí tento přepínač zobrazí graf využití pro skupinu prostředků v okně s více grafy v řadiči.":
1070 "V této barvě se zobrazí graf využití, který se zobrazí v okně více grafů v řadiči.":
1080 "Graf využití, který se nachází v okně více grafů v řadiči, zobrazí tuto barvu, když spotřeba překročí počet hodin dostupných pro prostředek nebo skupinu prostředků (pokud je Max. hodin využití nastaveno jako nespecifikované). Pokud byla hodnota zadána do pole Max. hodin využití, pak graf změní barvu podle této hodnoty.":
1090 "Graf využití v okně více grafů v řadiči pomocí této barvy vykreslí úsečku, která bude značit využití nastavení v hodinách.":
2020 "Určuje název jednotlivých prostředků.":
2023 "Hodinové náklady na provoz prostředku.":
2024 "Použije hodnoty '% faktoru nákladů' stanovené v záznamech hlavního kalendáře na hodinové náklady na prostředek.":
2030 "Toto dialogové okno obsahuje informace o způsobu, jakým má být prostředek nebo skupina prostředků zobrazena v okně Přehled posloupnosti a grafech využití.":
2040 "Možná nastavení jsou Viditelné, Minimalizované nebo Vypnuté. Řídí počáteční stav okna tohoto prostředku při spuštění Řadiče. Obvyklé nastavení je Minimalizované. Pokud je nastaveno na Vypnuté, prostředek se pro tvorbu posloupnosti nepoužije.":
2050 "Řídí vodorovné (časové) měřítko Ganttových oken prostředků v Řadiči. Rozsah může být od minut až po týdny na jednotku.":
2070 "Umožňuje nastavit kapacitu prostředku na Konečná, Nekonečná nebo Nekonečná se vzory posuvu.":
2071 "Umožňuje nastavit kapacitu prostředku na Konečná, Nekonečná nebo Nekonečná se vzory posuvu při spuštění režimu řadiče Nekonečná kapacita.":
2080 "Řídí vodorovné (časové) měřítko oken prostředků s dlaždicemi v Řadiči.":
2100 "Vybere sekundární omezení, které se použije na primární prostředek. Určuje počet omezení vyžadovaných prostředkem a způsob použití omezení na primární prostředek.":
2110 "Stanoví, kdy má být využití sekundárního prostředků zvýšeno nebo sníženo, například Přírůstek pro trvání, který pro trvání operace využívá sekundárního omezení a uvolňuje omezení po jejím dokončení. Pokud je na upínku pro několik operací umístěna zakázka, je možné určit Přírůstek na počátku pro první operaci a Úbytek na konci pro poslední operaci. Tím se zajistí, že upínku nebude možné použít pro jinou zakázku, zatímco první zakázka čeká v pořadníku na prostředek.":
2120 "Určuje požadovaný počet sekundárních omezení. Pokud je vybrána hodnota 'Množství', pak požadovaný počet je roven velikosti zpracovávané dávky.":
2130 "Definuje atribut operace, který zabrání odlišným operacím souběžné provádění u prostředků s nekonečnou kapacitou.":
2150 "Používá se ve výrobě APS ke stanovení kritérií, která budou použita preferovanými pravidly tvorby posloupností při výběru úloh ke zpracování.":
2160 "Používá se ve výrobě APS pravidly rozvrhování 'Minimalizace WIP' ke stanovení časových zásobníků, ve kterých se může WIP akumulovat před vybranými prostředky.":
2180 "Číselná hodnota, která slouží k určení pořadí, ve kterém se prostředky zobrazí v tabulce dat prostředků. Může být použita k přepsání výchozího pořadí, ve kterém jsou prostředky zobrazeny v přehledu posloupnosti.":
2181 "Zobrazí dialogové okno, ve kterém je možné podle potřeby definovat pokročilé možnosti omezení prostředků.":
2182 "Umožňuje pomocí výrazů definovat složité vztahy mezi prostředky. Podrobnosti o syntaxi a tvorbě výrazu naleznete v dokumentaci.":
2183 "Umožňuje uživateli vybrat atribut operace na prostředku s nekonečnou kapacitou. V jednu chvíli bude možné rozvrhnout pouze ty operace, které mají v tomto atributu stejnou hodnotu.":
2185 "Určuje, zda se pod prostředkem v ganttově diagramu zobrazí oddělovací čára. To může usnadnit vizualizaci prostředků ve skupinách.":
2190 "Určuje způsob, jakým se prostředek zobrazí v přehledu posloupnosti. Alternativní možnosti jsou 'Vždy', 'Pouze ve skupině' a 'Skrýt'.":
2191 "Určuje způsob zobrazení operací v přehledu posloupnosti. Dostupné možnosti jsou 'Vedle sebe', kdy se operace zobrazí na jedné přehledové linii, a 'Nad sebou', kdy se každá operace zobrazí na své vlastní přehledové linii.":
2200 "Používá se ke stanovení matice přípravných hodnot závislých na posloupnosti, čímž definuje dobu potřebnou na přípravu změny výrobku s jedním typem atributů na jiný.":
2201 "Toto pole nastavuje, která skupina přechodu je k tomuto prostředku přiřazena, a tedy určuje, které doby přechodů mezi operacemi s různými atributy se použijí.":
2202 "Určuje, zda se doby nastavení a přechodu související s operacemi tohoto prostředku použijí souběžně nebo kumulativně.":
2205 "Zaškrtnutím tohoto políčka již nebude prostředek zahrnut do výpočtů metrik výkonu rozvrhu.":
2210 "Toto pole se používá k výběru systému prohlížeče, ke kterému prostředek patří. Toto pole obsahuje seznam systémových názvů Rozvrhovače načtených z tabulky dat Adresář PCO.":
2220 "Toto tlačítko zobrazuje dialogové okno se seznamem různých atributů asociovaných s prostředkem.":
2230 "Toto pole umožňuje zadat data řetězcového atributu vůči zdroji.":
2240 "Toto pole umožňuje zadat data reálného atributu vůči zdroji.":
2250 "Toto pole umožňuje zadat data atributu trvání vůči zdroji.":
2260 "Toto pole označuje účinnost prostředku, výchozí hodnota je 100%, pokud se účinnost změní na 200%, pak jakékoliv operace rozvržené u tohoto prostředku budou zpracovány dvojnásobnou rychlostí (poloviční doba zpracování).":
2270 "Po zapnutí tohoto přepínacího pole se použije hodnota v poli Účinnost % na všechny operace, které mají doby nastavení a jsou rozvrženy u prostředku, u kterého je přepínač zapnut.":
2280 "Po zapnutí tento přepínač zobrazí graf využití pro prostředek v okně s více grafy v řadiči.":
2300 "Pomocí tohoto pole je možné vybrat sekundární skupinu omezení, ze které budou sekundární omezení přidělena při tvorbě posloupnosti.":
2310 "Do tohoto pole bude přiřazeno sekundární omezení přidělené ze skupiny sekundárních omezení.":
5035 "Násobek faktoru nákladů, který ovlivňuje provozní náklady na prostředek, na který je použit. Hodnota 100% znamená žádné zvýšení, hodnota 150% navýší provozní náklady o 50 %. Násobky jsou stanoveny v tabulce dat stavů kalendáře a používají se v souborech hlavního kalendáře jako výchozí hodnoty.":
6100 "Zobrazí dialogové okno, ve kterém je možné vybrat, které prostředky z vybrané skupiny jsou platné, a přiřadit data specifická pro prostředek.":
6110 "Toto pole určuje, zda bude prostředek vybrán během automatické tvorby posloupnosti.  Pokud není zaškrtnuto, operaci bude i nadále možné umístit do prostředku ručně.":
6120 "Pomocí tohoto pole je možné jednotlivě stanovit dobu nastavení pro každý prostředek platný pro danou operaci.":
6130 "Pomocí tohoto pole je možné jednotlivě stanovit provozní dobu pro každý prostředek platný pro danou operaci.":
6131 "Pomocí tohoto pole je možné jednotlivě stanovit rychlost za hodinu pro každý prostředek platný pro danou operaci.":
6132 "Pomocí tohoto pole je možné jednotlivě stanovit dobu dávky pro každý prostředek platný pro danou operaci.":
6140 "Toto pole slouží k definování sekundárního prostředku používaného primárním prostředkem během aktuální operace.":
6150 "Toto pole slouží k určení způsobu použití sekundárního omezení během operace, např. Přírůstek pro trvání, Pouze přírůstek doby nastavení atd.":
6160 "Toto pole značí počet sekundárních omezení vyžadovaných během aktuální operace, např. je možné určit, že operace vyžaduje jedno pevné sklíčidlo.":
6170 "Rozvrhovač toto časové období použije k pokusu o načtení aktuální operace do preferovaného prostředku. Pokud to v tomto období nestihne, pokusí se načíst operaci do libovolného jiného prostředku ve skupině.":
6180 "Možnost Nastavit další skupinu prostředků stanovuje 'vynucený seznam' prostředků, tj. těch, které jsou určeny ve vybrané skupině. Následné operace budou moci využít pouze prostředky ve 'vynuceném seznamu'. Pokud tedy trasa procesu u následné operace vyvolá skupinu prostředků, která obsahuje prostředky, které nejsou v seznamu, pak takové prostředky nebudou při tvorbě posloupnosti použity. Funkce Nastavit další skupinu prostředků je kumulativní funkcí, může být použita u více než jedné operace v trase procesu a přidává do 'vynuceného seznamu' prostředky.":
6190 "Funkce Obnovit další skupinu prostředků odebírá prostředky, které jsou ve vybrané skupině prostředků, z 'vynuceného seznamu' stanoveného příkazem Nastavit další skupinu prostředků. Pokud byla stanovena koncepční skupina prostředků 'Vše', která zahrnuje všechny dostupné prostředky, pak se v dalších operacích použijí prostředky nastavené v původní trase procesu.":
6230 "Pomocí tohoto pole je možné určit dobu nastavení a převést ji od předchozího výrobku k aktuálnímu. Hodnoty v poli Doba nastavení budou přidány k jakýmkoliv hodnotám nastavení stanoveným pro prostředek maticí Doba nastavení závislá na posloupnosti.":
6430 "Vyberte název ikony z rozevíracího seznamu. Pomocí tlačítka upravit je možné vytvořit ikony nové.":
6470 "Zobrazí dialogové okno Platná sekundární omezení, pomocí kterého je možné na jednotlivé záznamy tabulky použít platná omezení. Je možné zde také upravit vlastnosti použití omezení.":
6530 "Určuje maximální časový interval povolený mezi dvěma operacemi v posloupnosti. Maximální časový interval je určen polem 'Typ intervalu', které určuje vztahy 'Začátek na začátek', 'Konec na konec' atd.":
6540 "Stanovuje vztah použitý k provázání maximálního časového intervalu mezi dvěma nepřetržitými operacemi, který je určen v poli 'Max doba před další operací'. Může se jednat o vztah 'Konec na konec', 'Konec na začátek', 'Začátek na začátek' nebo 'Začátek na konec'.":
6550 "Určuje maximální dobu jako procentuální část z teoretické doby zpracování, na kterou se může operace protáhnout při automatickém vložení do posloupnosti Řadičem.":
6560 "Definuje danou velikost časové rezervy, která má být vytvořena mezi touto a předchozí operací.":
6565 "Definuje danou velikost časové rezervy, která má být vytvořena mezi touto a další operací.":
6580 "Toto pole slouží k použití násobku rychlosti zpracování, čímž se změní délka operace.":
6681 "Toto pole slouží k určení atributu tohoto záznamu, který je odkazován z jedné z tabulek atributů. Ty mohou být použity ke změně dob nastavení, pořadí rozvrhování a použití omezení.":
6682 "Toto pole slouží k určení atributu řetězce volného formátu pro tento záznam. Ty mohou být použity k nastavení možností zobrazení a seskupení operací.":
6683 "Toto pole slouží k určení číselného atributu pro tento záznam. Ty mohou být použity k nastavení možností zobrazení, ovlivnění pořadí rozvrhování a použití omezení.":
6684 "Toto pole slouží k určení atributu data pro tento záznam. Ty mohou být použity k nastavení možností zobrazení a ovlivnění pořadí rozvrhování.":
6685 "Toto pole slouží k určení atributu trvání pro tento záznam. Ty mohou být použity k nastavení možností zobrazení a ovlivnění pořadí rozvrhování.":
6690 "Pole Zásobník pro doručování obsahuje čas zásobníku, který se při zpětné tvorbě posloupnosti odečte od data splatnosti, takže operace budou rozvrženy na čas dřívější, než je nejpozdější možný čas. Tím vznikne prostor pro neočekáváná zpoždění v procesu.":
7020 "Počet dní před aktuálním časem, které je možné zobrazit v přehledu posloupnosti.":
7030 "Časové období po aktuálním čase, které je možné zobrazit v přehledu řadiče.":
7035 "Otevře dialogové okno nastavení konfigurace, pomocí kterého si je možné přizpůsobit přehled posloupnosti.":
7040 "Určuje posun od okamžiku zadání objednávky, před kterým není možné zakázku začít. Pokud je nastaven na Nespecifikováno, tak jediným omezením je aktuální čas.":
7050 "Určuje posun od okamžiku zadání objednávky, po kterém má být zakázka k dispozici. Je možné ho přepsat.":
7060 "Doba, o kterou je zakončení od aktuálního času posunuto. Zakončení je rovno aktuálnímu času, pokud je jeho posun nastaven na 0 hodin 00 minut.":
7067 "Stanoví možnost výpočtu nákladů, dostupné možnosti jsou: Během posloupnosti, Po posloupnosti nebo Nikdy.":
7120 "Nastaví režim přehledu posloupnosti.":
7130 "Počet dní od dneška, od kterých má přehled posloupnosti začít.":
7140 "Počet dní od dneška, po které má přehled posloupnosti skončit.":
7320 "Umožňuje skriptu požadovanému pro import objednávek, aby byl vybrán z tabulky dat 'Skripty'.":
7330 "Umožňuje skriptu požadovanému pro export objednávek, aby byl vybrán z tabulky dat 'Skripty'.":
7430 "Při zaškrtnutí tohoto přepínacího pole se na každém panelu operace v Řadiči zobrazí malý černý trojúhelník. Díky němu je možné snadněji přetahovat operace přidělené na plánovací tabulce, zvláště menší operace.":
7450 "Určuje výchozí skript události PESP, který se má spustit při importu objednávek tlačítkem 'Import objednávek' v nabídce přenosu dat.":
7470 "Určuje výchozí skript události PESP, který se má spustit při exportu objednávek tlačítkem 'Export objednávek' v nabídce přenosu dat.":
7480 "Určuje výchozí skript události PESP, který se má spustit při uvolnění rozvrhu tlačítkem 'Uvolnit rozvrh' v nabídce přenosu dat.":
7490 "Určuje výchozí skript události PESP, který se má spustit při přidělení operací v Řadiči se zapnutou možností Pravidla APS.":
8020 "Název sekundárního omezení.":
8030 "Umožňuje vybrat barvu uživatelského grafu Řadiče, když se hodnoty nacházejí mezi horní a dolní mezí.":
8040 "Nastaví vzor výplně grafu.":
8060 "Barva výplně grafu, pokud graf překročí horní mez.":
8080 "Barva výplně grafu, pokud graf překročí dolní mez.":
8090 "Určuje, zda se má toto sekundární omezení na rozvrh uplatnit během používání produktu FCS 300 nebo vyššího. Pokud v jakékoliv verzi není toto pole zaškrtnuto, Řadič přestane zobrazovat upozornění v případě, kdy budou meze tohoto sekundárního omezení překročeny.":
8091 "V režimu řadiče nekonečné kapacity toto pole určuje, zda má toto sekundární omezení omezit rozvrh při používání produktu FCS 300 nebo vyššího.":
8092 "Možnosti pro řízení chování tohoto omezení, když je systém nastaven na režim nekonečné kapacity.":
8100 "Určuje, jakým způsobem účinnost kalendáře primárního kalendáře ovlivňuje využití sekundárního omezení. Možnosti jsou: Žádný účinek; Začátek účinnosti zakázky; Podle změn účinnosti; Nad 0% použít 100%":
8101 "Toto pole v režimu řadiče s nekonečnou kapacitou určuje, jakým způsobem účinnost kalendáře primárního kalendáře ovlivňuje využití sekundárního omezení. Možnosti jsou: Žádný účinek; Začátek účinnosti zakázky; Podle změn účinnosti; Nad 0% použít 100%":
8120 "Toto tlačítko zobrazuje dialogové okno se seznamem různých atributů asociovaných se sekundárním omezením.":
8130 "Toto pole umožňuje zadat data řetězcového atributu vůči sekundárnímu omezení.":
8140 "Toto pole umožňuje zadat data reálného atributu proti sekundárnímu omezení.":
8150 "Toto pole umožňuje zadat data atributu trvání proti sekundárnímu omezení.":
8160 "Po zapnutí tento přepínač zobrazí graf využití pro sekundární omezení v okně s více grafy v řadiči.":
8200 "Název skupiny sekundárního omezení.":
8210 "Umožňuje vybrat, která sekundární omezení budou členy této skupiny.":
9020 "Nastavení názvů skupin, které tvoří osy X a Y matice Doba nastavení závislá na posloupnosti v tabulce dat zdrojů.":
12020 "Název záznamu atributu v tabulce dat Atribut výrobku 1.":
13020 "Název záznamu atributu v tabulce dat Atribut výrobku 2.":
14020 "Název záznamu atributu v tabulce dat Atribut výrobku 3.":
16020 "Název používaný jako popis konfigurace zobrazení na obrazovce uložené pod názvem souboru. Tento popis se používá také jako popisek zobrazovaný u ikon panelu nástrojů pracovního prostoru.":
16030 "Soubor je možné vybrat pomocí tlačítka nalevo od pole. Původní soubor konfigurace pracovního prostoru s příponou .WPI je možné uložit příkazem Uložit pracovní prostor pod položkou Pracovní prostor v nabídce řadiče.":
18510 "Jméno jednotlivce nebo organizace, která objednávku vytvořila.":
18520 "Jméno primárního kontaktu v organizaci, která objednávku vytvořila.":
18530 "Telefonní číslo pro použití v souvislosti s objednávkou.":
18540 "E-mailová adresa pro použití v souvislosti s objednávkou.":
21000 "Toto pole umožňuje zadat různý 'stav objednávky'. Stav objednávky je možné vybrat v souboru rozvrhu.":
21020 "Toto pole uchovává popis, co znamená název stavu objednávky, který byl zadán do pole 'Název stavu objednávky'.":
21100 "Název záznamu atributu v tabulce dat atributu.":
21110 "Slouží ke stanovení řazení podle priorit u záznamů v této tabulce dat atributu, které je možné použít v pravidlech rozvrhování":
24000 "Toto pole určuje, zda je záznam vůči sadě pravidel nadřazený nebo podřazený.":
24010 "Obsahuje název sady pravidel.":
24020 "Tento přepínač se používá k vymazání fixačních propojení pouze u objednávek, které jsou ve frontě poptávky prvního průchodu (ať už je povolena nebo ne) sady pravidel.":
24030 "Obsahuje název příslušné funkce pravidla přijetí.":
24040 "Pokud je tento přepínač nastaven na hodnotu true, pravidlo přijetí bude zapnuto, pokud je nastaven na hodnotu false, toto konkrétní pravidlo přijetí bude při spuštění sady pravidel ignorováno.":
24050 "Pokud je tento přepínač nastaven na true a je spuštěna sada pravidel, v pracovním adresáři se vytvoří soubor ladění.":
24060 "Toto pole slouží k určení kritérií, pomocí kterých je možné omezit umístění položek do interní dodavatelské fronty. Výchozí hodnota pro toto pole je VŠE, je možné ji ovšem upravit pomocí výrazu, např. (~{$Order Type}~==~Stock~). Tento dotaz vyfiltruje záznamy uložené v databázi 'Objednávky práce'.":
24070 "Toto pole obsahuje kritéria, pomocí kterých je možné ohodnotit položky v interní dodavatelské frontě. Například je možné ohodnotit vnitřní dodavatelskou frontu podle data splatnosti, nejdřívějšího počátečního data nebo priority.":
24080 "Toto pole slouží k určení kritérií, pomocí kterých je možné omezit umístění položek do fronty poptávky. Výchozí hodnota pro toto pole je VŠE, je možné ji ovšem upravit pomocí výrazu, např. (~{$Order Type}~==~Stock~). Tento dotaz vyfiltruje záznamy uložené v databázi 'Objednávky práce'.":
24090 "Toto pole obsahuje kritéria, pomocí kterých je možné ohodnotit položky ve frontě poptávky. Například je možné ohodnotit frontu poptávky podle data splatnosti, nejdřívějšího počátečního data nebo priority.":
24100 "Toto pole obsahuje seznam různých standardních pravidel fixace, které je možné použít k fixaci objednávek k sobě. Také obsahuje tři speciální položky – Uživatelské, Uživatelská funkce a Skript PESP, které umožňují tvorbu více přizpůsobených pravidel.":
24110 "Toto pole je viditelné pouze, pokud je pole 'Typ pravidla' nastaveno na hodnotu 'Uživatelské' nebo 'Uživatelská funkce'. Do tohoto pole se zadává výraz, který se má použít pro pravidlo. Příklad může vypadat takto: (~{+:$Product Attribute 1}~==~{-:$Product Attribute 1}~) – objednávky dodávek a poptávky bude možné propojit pouze, pokud budou mít pole 'Atribut výrobku 1' stejné hodnoty.":
24120 "Toto pole je viditelné pouze pokud je pole 'Typ pravidla' nastaveno na 'Skript PESP'. V tomto poli je uložen název skriptu PESP, který se použije jako pravidlo.":
24130 "Tato možnost umožňuje tvorbu propojení u řádků rozpisky, aniž by bylo nutné pro daný řádek zcela splnit množství. Položky s nedostatky budou zvýrazněny.":
24140 "Tato možnost umožní tvorbu propojení pouze u těch řádků rozpisky, kde je množství zcela splněno. Jakékoliv položky s nedostatkem budou zvýrazněny.":
24141 "Pokud je tato možnost zaškrtnuta, výchozí chování SMC bude přepsáno tak, že bude povolena tvorba zpětných propojení, když se po spotřebě zahájí výroba.":
24150 "Pokud je nastaveno na true, objednávky, které jsou již rozvrženy, mohou být znovu připojeny.":
24160 "Pokud je tento přepínač nastaven na hodnotu true, pole 'Hodnocení fronty dodávky' se aktivuje, takže bude možné hodnotit záznamy dodávky podle kritérií výběru v poli 'Hodnocení fronty dodávky'. Tuto možnost vyberte pouze, pokud jsou všechny záznamy uloženy v databázi 'Objednávky práce'.":
24170 "Toto pole slouží k určení kritérií, pomocí kterých je možné omezit umístění položek do externí dodavatelské fronty. Výchozí hodnota pro toto pole je VŠE, je možné ji ovšem upravit pomocí výrazu, např. (~{$Order Type}~==~Stock~). Tento dotaz vyfiltruje záznamy uložené v databázi 'Poptávka'.":
24180 "Bude zpracováno libovolné pole s klasifikací INHERIT FROM SUPPLY(Název pole).":
24190 "Bude zpracováno libovolné pole s klasifikací INHERIT FROM DEMAND(Název pole).":
24200 "Pokud je tento přepínač nastaven na hodnotu true, pole 'Hodnocení fronty poptávky' se aktivuje, takže bude možné hodnotit záznamy poptávky podle kritérií výběru v poli 'Hodnocení fronty poptávky'. Tuto možnost vyberte pouze, pokud jsou všechny záznamy uloženy v databázi 'Objednávky práce'.":
24210 "Pokud je tento přepínač nastaven na hodnotu true, množství ve vytvořeném propojení bude přiděleno v určitých násobcích. Tento násobek se určuje v datech rozpisky.":
24500 "Pokud je zaškrtnuto přepínací pole 'Vždy použít tuto sadu pravidel', pak se při výběru možnosti 'Fixovat materiály' v Řadiči ve výchozím stavu spustí právě sada pravidel fixace vybraná v tomto poli.":
24505 "Pokud je tato globální možnost zaškrtnuta, výchozí chování SMC bude přepsáno tak, že bude povolena tvorba zpětných propojení, když se po spotřebě zahájí výroba.":
24510 "Pokud je přepínač zaškrtnut, pak se při výběru možnosti 'Fixovat materiály' v řadiči jako výchozí spouštěné pravidlo použije pravidlo vybrané v poli 'Sada pravidel fixace'. Pokud není možnost 'Vždy použít tuto sadu pravidel' zaškrtnuta, zobrazí se při výběru možnosti 'Fixovat materiály' v řadiči dialogové okno pro výběr pravidla, ve kterém je možné určit, které pravidlo se má spustit.":
25400 "V tomto poli je uloženo číslo objednávky dodávky.":
25410 "Toto pole určuje typ objednávky, například Sklad nebo Nákup.":
25420 "Název organizace dodávající materiály pro objednávku.":
25430 "Číslo součásti, pro kterou je objednávka určena.":
25440 "Popis součásti, pro kterou je objednávka určena.":
25450 "Datum dodání materiálu.":
25500 "Toto pole slouží k určení objednávky, ke které součást náleží. První řádek objednávky bude nadřazený záznam a bude v tomto poli zobrazovat text PARENT, ostatní řádky objednávky budou podřazené záznamy a budou v tomto poli zobrazovat číslo objednávky, ke které náleží.":
25510 "V tomto poli je uloženo číslo poptávky.":
25520 "Toto pole určuje typ objednávky, například Naskladnit nebo Prodej.":
25530 "Jednoznačně identifikuje položku objednávky.":
25540 "Název organizace požadující materiály pro objednávku.":
25550 "Datum požadavku na materiál.":
25560 "Určuje násobky položky, které je nutné fixovat. Počet položek často tvoří krabici nebo pouzdro, například kde 12 konzerv tvoří 1 krabici, dorazí objednávka, která vyžaduje 60 konzerv. Dorazila objednávka dodávek na 50 konzerv. Řízení materiálu zafixuje pouze 48 konzerv z 50, poté bude zbývajících požadovaných 12 konzerv hledat jinde, ale propojení vytvoří pouze, když najde přesně 12. Aby byla tato funkce zapnuta, je nutné zaškrtnout políčko 'Přidělit pouze násobky' v databázi 'Pravidla fixace'.":
25600 "Číslo objednávky, ke které řádek rozpisky patří.":
25605 "Číslo součásti objednávky, ke které řádek rozpisky patří.":
25610 "Číslo operace, ke které řádek rozpisky patří.":
25611 "Název operace, ke které řádek rozpisky patří.":
25615 "Číslo součásti výrobku, který vyžaduje určený materiál":
25620 "Číslo součásti s položkou rozpisky.":
25630 "Požadované množství položky rozpisky.":
25640 "Pokud je toto pole nastaveno na hodnotu true, množství v objednávce bude vynásobeno požadovaným množstvím v rozpisce.":
25650 "Způsobí, že při spuštění pravidla fixace bude ignorován nedostatek. Umožňuje rozvrhnout objednávky s nedostatky.":
25700 "Číslo objednávky, ve které je vedlejší výrobek vyroben.":
25705 "Číslo součásti objednávky, ve které je vedlejší výrobek vyroben.":
25710 "Číslo operace, která vedlejší výrobek vyrábí.":
25715 "Název operace, která vedlejší výrobek vyrábí.":
25720 "Název vedlejšího výrobku.":
25730 "Počet vyrobených vedlejších výrobků.":
25740 "Pokud je toto pole nastaveno na hodnotu true, počet vedlejších výrobků bude vynásoben počtem objednávek.":
25800 "Toto pole udává typ objednávky, například: Objednávka práce, Objednávka nákupu, Objednávka prodeje nebo Sklad":
25810 "Pokud je toto pole zaškrtnuto, nerozvržené operace se již nebudou v okně 'Nerozvržené operace' zobrazovat.":
25820 "Zobrazí dialogové okno s poli související s řízením materiálu.":
25830 "Toto pole obsahuje informace o stavu poptávky po fixaci materiálů. Bude obsahovat jednu z následujících hodnot: 'Neznámý', 'Splněno', 'Všechny nedostatky ignorovány', 'Nedostatky', 'Přezásobováno', 'Přezásobováno, nedostatky', 'Přezásobováno, všechny nedostatky ignorovány'.":
25840 "Toto pole je naplněno po fixaci materiálů. Pokud se k objednávce dodávek v databázi 'Objednávky dodávek' vytvoří propojení, pole 'Datum poptávky' v databázi 'Objednávky práce' bude naplněno položkou 'Datum dodávky' objednávky, ke které je připojena. Pole 'Datum objednávky' bude vyhodnoceno proti poli 'Nejdřívější datum zahájení' a poslední datum bude použito k určení, které datum bude použito při tvorbě rozvrhů.":
25850 "Toto pole je naplněno po fixaci materiálů. Pokud se k poptávce v databázi 'Poptávky' vytvoří propojení, pole 'Datum dodání' v databázi 'Objednávky práce' bude naplněno položkou 'Datum poptávky' poptávky, ke které je připojena. Pole 'Datum poptávky' bude vyhodnoceno vůči poli 'Datum splatnosti' a dřívější datum bude použito k určení, které datum bude použito při tvorbě rozvrhů.":
25900 "Zobrazí dialogové okno s poli souvisejícími se stavem operace.":
25910 "Tuto možnost je možné vybrat při rozdělení objednávky, tato možnost umožňuje, aby každá výrobní šarže pokračovala ve výrobním procesu nezávisle, například aby mohla další operace začít, aniž by byly všechny šarže dokončeny během jedné operace.":
25920 "Toto pole určuje barvu použitou v grafu v ganttově diagramu pro tento záznam.":
26000 "Toto pole definuje název skupiny přechodu":
26100 "Toto pole nastavuje dobu přechodu, který se provede, když se zadaný atribut mění mezi operacemi rozvrhnutými z jedné na druhou.":
26200 "Zobrazovaný název uživatelského nástroje":
26210 "Skript události, který bude při výběru uživatelského nástroje spuštěn":
26220 "název nabídky nástroje uživatelského okna":
26230 "Funkce kódu k zaplnění obsahu uživatelského okna":
26240 "popisek uživatelského okna":
26300 "Název tlačítka nabídky. Značí, kde se tlačítko v systému nabídky zobrazí":
26310 "Toto pole řídí, zda je tlačítko zapnuto a zda je tedy zobrazeno":
26320 "Toto pole řídí text, který se zobrazí na tlačítku":
26330 "Skript, který bude při stisku tlačítka nabídky spuštěn":
;
