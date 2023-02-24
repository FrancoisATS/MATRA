#VERSION 0
;
HUN POPUP HELP
1 "Ehhez az elemhez nem kapcsolódik súgótémakör.":
10 "Ezzel a mezővel azonosíthatja, hogy az adott alkatrész melyik rendeléshez tartozik. A rendelések első műveleténél ez a PARENT értékre, míg a többi műveletnél az egyedi rendelésszámra vagy -névre van állítva.":
40 "Ezzel a mezővel azonosíthatja a cikkszámot. A gomb megnyomásakor a termékek adattáblájában szereplő összes cikkszám megjelenik. Ha kiválaszt egy cikkszámot, a termék neve automatikusan megváltozik.":
41 "Ez a mező több különböző állapotot tartalmaz, amelyeket a rendelés viszonylatában meghatározhat. A rendszer a Rendelésállapot adattáblából nyeri ki az értékeket, amelybe szükség szerint felveheti az új állapotokat. A Rendelésállapot adattáblában mintát is beállíthat a műveleti sávokhoz, amelynek segítségével meghatározhatja a rendelés műveleti sávjának mintáját, amelyet a rendszer akkor használ, ha a rendelés bekerül a sorrendvezérlőbe.":
45 "Ez a mező a cikkszám azonosítására szolgál.":
50 "Ez a mező a termék nevének azonosítására szolgál. Ha a gomb segítségével kiválasztja a termék nevét, akkor a cikkszám automatikusan megváltozik.":
55 "Ez a mező a termék nevének azonosítására szolgál.":
60 "Ez a mező a termék rendelésszámának azonosítására szolgál. A rendelésszám lehet belső rendelésszám vagy egy, az ügyfél által meghatározott rendelésszám. A rendelésszámnak egyedi értéknek kell lennie.":
70 "Ez a mező a rendeléssel kapcsolatos megjegyzések írására szolgál. Ez lehet például a határidőkkel kapcsolatos megjegyzés, vagy egy egyszerű üzenet a gyártócsarnokban dolgozó csomagolók/összeszerelők számára.":
75 "Megnyit egy párbeszédpanelt, amelyen a műveletre vonatkozó attribútuminformációk láthatók.":
80 "Ennek a mezőnek a használatával határozhatja meg a feladat prioritását. A sorrendvezérlő is ezt a sorrendet fogja alkalmazni. Minél kisebb a szám, annál nagyobb a prioritás. Ne feledje, hogy a prioritások negatív értéket is felvehetnek; a negatív prioritás nagyobb prioritást jelent a pozitív prioritásnál. A -100 például nagyobb prioritást jelent a -1-es prioritásnál, a 0 pedig nagyobb prioritást jelent a 10-es prioritásnál.":
90 "Ez a mező egy adott feladathoz tartozó műveletszám megadására szolgál. A sorrendvezérlő ez alapján határozza meg a feladat sorrendbeli helyét. Az alacsonyabb számú műveleteket a rendszer a magasabb számú műveletek előtt végzi el. Ha egy termékhez két azonos műveletszámú műveletet is rendelnek, akkor a rendszer ezeket a műveleteket mindig a magasabb számú műveletek előtt végzi el.":
110 "Ez az elvégzendő művelet leírása vagy neve, azonosítása pedig a műveletszámmal történik.":
112 "Megnyit egy párbeszédpanelt, amely a művelethez rendelt erőforrásadatokkal kapcsolatos információkat tartalmaz.":
120 "A beállítási csoportok a beállítási csoportok adattáblájában vannak meghatározva, például: 1. beállítási csoport, 2. beállítási csoport stb. Ezeket az értékeket a rendszer a sorrendfüggő beállítási idők mátrixának tengelyeiként használja. Ez a mátrix a különböző beállítási csoportokban (általában az erőforrásadatok táblázatban szereplő beállítás) lévő termékek közötti átállási idő meghatározására szolgál. Az egyes beállítási csoportok a Termékadatok táblában szereplő termékekhez vannak rendelve, bár ezek alapértelmezett értékét a rendszer felülírhatja a fő ütemezési fájlban.":
130 "Ez a mező azokat az érvényes erőforrásokat azonosítja, amelyek alkalmasak az aktuális művelet elvégzésére.":
140 "Szükség esetén ez a mező használható annak a konkrét erőforrásnak az azonosítására, amelynek fel kell dolgoznia a műveletet. Ha a termékadatok táblában ehhez a „Kiválasztás csoportból” lehetőség van beállítva, akkor az Erőforráscsoport mezőben látható bármely erőforrás használható. Ha a művelet a csoportban szereplő adott erőforrással kívánja elvégezni, akkor a legördülő menüben válassza ki a kívánt erőforrást.":
150 "Ez a mező mutatja azt az erőforrást, amely valójában feldolgozza a műveletet. Ha a rendelés korábban még nem volt beütemezve, akkor a rendszer a „Nincs megadva” értéket állítja be. Ha a műveletet korábban már betöltötték a tervezőtáblába, akkor a jelenleg betöltendőként beállított erőforrás fog megjelenni.":
180 "Ez a mező a feldolgozási sebesség meghatározásához használt mértékegységet jeleníti meg: idő/köteg, idő/elem vagy óránkénti mennyiség. Az „idő/köteg” lehetőség kiválasztása esetén az alábbi mezőben látható idő a kötegben lévő összes alkatrész feldolgozásához szükséges időt jelenti. Az „idő/elem” lehetőség kiválasztása esetén a műveleti időt az alábbi mezőben lévő érték és a köteg méretének a szorzata adja meg. Az „óránként mennyiség” kiválasztása esetén a műveleti idő meghatározása közvetlenül az adott órában feldolgozott elemek alapján történik.":
220 "A műveleti idő típusaként jelenleg az „Idő/elem” lehetőség van kiválasztva. Ebben a mezőben minden egyes tételhez meg kell adnia egy műveleti időt.":
230 "A műveleti idő típusaként jelenleg az „Idő/köteg” lehetőség van kiválasztva. Ebben a mezőben a köteg feldolgozásának teljes műveleti idejét kell megadnia.":
240 "A műveleti idő típusaként jelenleg az „Óránkénti mennyiség” lehetőség van kiválasztva. Ebben a mezőben az óránként feldolgozható elemek mennyiségét kell megadnia.":
251 "Az ebben a mezőben beállított szín arra utasítja a sorrendvezérlőt, hogy az egy másik színnel jelenítse meg a Gantt-diagram oszlopának egy részét. A rendszer a Köztes kötegmennyiség és a Köztes kötegidő mezőkben megadott értékek alapján színezi be a sávot.":
260 "Ez a mező a rendelés vagy a köteg mennyiségének meghatározására szolgál.":
270 "Ez a mező a rendelés vagy a köteg nyereségének meghatározására szolgál, súlyozási szabály alkalmazásakor pedig a sorrendvezérlés befolyásolására is használható.":
280 "Ez a mező a rendelésben szereplő első művelet kezdési idejét mutatja, amennyiben a Termelési időtartam funkció engedélyezve van":
290 "Ez a mező a rendelésben szereplő utolsó művelet befejezési idejét mutatja, amennyiben a Termelési időtartam funkció engedélyezve van":
300 "Ez az érték határozza meg azt a mennyiséget, amelyet mindenképp fel kell dolgozni ahhoz, hogy a következő műveletet el lehessen indítani. A „Nincs megadva” érték megakadályozza, hogy a műveletek fedjék egymást.":
360 "Annak a dátumnak a meghatározására szolgál, amely előtt a feladat nem indítható el. Ez lehet például az az időpont, amikor az anyagok elérhetővé válnak.":
370 "Ez a mező a határidő beállítására szolgál. A „határidő” lehetőség kijelölése esetén a határidő a sorrendvezérlőben lévő késedelmes elemek jelölésére, valamint a feladatok tervezőtáblába való betöltése fontossági sorrendjének meghatározására használható.":
380 "Ezzel a váltókapcsolóval azt jelezheti, hogy az ütemezőben látható kezdési és befejezési idők ismert, fix értékek-e. Bekapcsolt váltókapcsoló esetén a rendszer megakadályozza, hogy a rendelést eltávolítsák a sorrendvezérlőben lévő bármely erőforrásból.":
390 "Ezt a mezőt az ütemező állítja be a sorrendvezérlés során arra az időpontra, amikor a feladatnak el kell indítania a beállítási folyamatot.":
400 "A sorrendvezérlés során az ütemező arra az időpontra módosítja ezt a mezőt, amikorra a feladat indítása ütemezve van.":
410 "A sorrendvezérlés során az ütemező arra az időpontra módosítja ezt a mezőt, amikorra a feladat befejezése ütemezve van.":
420 "Akkor kapcsolja be ezt a választókapcsolót, ha nem szeretné, hogy a munkát el lehessen távolítani a sorrendvezérlőben lévő „Összes feladat kiosztásának visszavonása” lehetőség kiválasztását követően. Ezzel zárolja a műveletet. Ez a sorrendvezérlőben található „Zárolt műveletek kiemelése” lehetőség használatával is elérhető. Ehhez vigye az egérkurzort egy műveletre (ikon vagy sáv az áttekintésben), nyomja le a Shift billentyűt, majd kattintson a bal egérgombbal.":
421 "Azok a műveletek, amelyeknél ez a váltókapcsoló be van kapcsolva, az automatikus ütemezési műveletek során „nem kiosztott” állapotban maradnak a nem kiosztott műveletek ablakban.":
430 "Lehetővé teszi, hogy felhasználó által definiálható jellemzőket (például színt) lehessen a termékekhez rendelni. Egy adott jellemzőn belül az attribútumrekordokhoz prioritási szintek rendelhetők, például a „fehér” termékek magasabb prioritással rendelkeznek a „sárga” termékeknél. Ezeket az attribútumokat az ütemező preferált sorrendvezérlési szabályai használják a Tervezési ablakban lévő hasonló rendelések összevonásához.":
440 "Adja meg a teljesített mennyiséggel kapcsolatos adatokat, a „Köztes kötegidő” mezőben pedig adja meg a köteg adott részének teljesítéséhez szükséges időt. Az ütemező ezt követően automatikusan újraszámolja a művelethez tartozó befejezési időt.":
450 "Adja meg a köteg adott részének teljesítéséhez szükséges időt, a „Köztes kötegmennyiség” mezőben pedig adja meg az elkészült mennyiséget. Az ütemező ezt követően automatikusan újraszámolja a művelethez tartozó befejezési időt.":
460 "A rendszer a „Tényleges műveleti idő” mezőben a „Köztes kötegmennyiség” és a „Köztes kötegidő” mezőkben megadott értékek segítségével kiszámítja az ezeken alapuló korrigált műveleti időt. Fontos megjegyezni, hogy a gyár megfelelő működése érdekében a „Köztes kötegmennyiség” és a „Köztes kötegidő” mezőkben szereplő értékeket a sorrendvezérlőben használt szerkesztő megjelenésekor módosítani kell, ellenkező esetben a „Tényleges műveleti idő” csak a sorrendvezérlő következő megnyitásakor módosul.":
474 "Arra szolgál, hogy meghatározza az elem költségét azon a ponton, amikor az elemet bevezetik a folyamatba. A mező az elemenkénti fix költségek rögzítésére szolgál, például külső fél által végzett hőkezelés stb.":
476 "Az Elemenkénti anyagköltséget használja a köteg abban a pontban érvényes anyagköltségének meghatározására, ahol az elemenkénti anyagköltséget bevezetik a folyamatba.":
477 "A feladat közvetlen költsége az aktuális folyamatban.":
530 "E funkció segítségével létrehozhat egy időhorizontot, amelyben feladatkötegek hozhatók létre a termeléshez. Egy, a tervezőtáblán szereplő műveletet befejező erőforrás ettől a ponttól tekint előre a Tervezési ablak által létrehozott időhorizonton. A rendszer az Erőforrások adattáblában meghatározott preferált sorrendvezérlési feltételek segítségével kiválasztja azokat a feladatokat, amelyek határideje erre az időhorizontra esik. A Tervezési ablak a Termékek adattáblában minden egyes termékhez külön létrehozható, továbbá lehetőség van a fő ütemezési fájlban szereplő egyes megrendelések szerinti módosítására, sőt a Konfiguráció beállítási adatai részben globális szabályként is beállítható.":
540 "Ennek a Termékek adattáblában szereplő beállításnak a segítségével elérhet egy, a termékkel kapcsolatos adatokat tartalmazó Word-dokumentumot. A dokumentum a fő ütemezési fájl szerkesztőjéből is elérhető és szerkeszthető.":
541 "Ez a mező egy adott művelet folyamatának leírására szolgál. Négy különböző fázis létezik: Nem indult el; Beállítás; Futtatás; Befejezve.":
550 "A termékekhez különböző jellemzőket lehet rendelni; az ütemezőben ezeket a jellemzőket az Attribútumadatok táblában találja. Ezeket a táblákat a felhasználók állíthatják be, például az 1. termékattribútum táblát fenntarthatják a színeknek, és az ebben szereplő rekordoknak a „piros”, „kék”, „zöld” stb. nevet adhatják. A termékattribútumok a Termékadatok tábla „Hasonló elemek párosítása” mezőjében választhatók ki a „Hasonló elemek” beállítási idejének meghatározása érdekében.":
560 "Az 1. termékattribútum adattáblában szereplő rekordok prioritási sorrendjének meghatározására szolgál, amelyet az APS-szabályok szerinti sorba rendezés alkalmaz.":
570 "A termékekhez különböző jellemzőket lehet rendelni; az ütemezőben ezeket a jellemzőket az Attribútumadatok táblában találja. Ezeket a táblákat a felhasználók állíthatják be, például a 2. attribútum táblát fenntarthatják az anyagoknak, és az ebben szereplő rekordoknak az „acél”, „sárgaréz”, „vörösréz” stb. nevet adhatják. A termékattribútumok a Termékadatok tábla „Hasonló elemek párosítása” mezőjében választhatók ki a „Hasonló elemek” beállítási idejének meghatározása érdekében.":
580 "A 2. termékattribútum adattáblában szereplő rekordok prioritási sorrendjének meghatározására szolgál, amelyet az APS-szabályok szerinti sorba rendezés alkalmaz.":
590 "A termékekhez különböző jellemzőket lehet rendelni; az ütemezőben ezeket a jellemzőket az Attribútumadatok táblában találja. Ezeket a táblákat a felhasználók állíthatják be, például a 3. attribútum táblát fenntarthatják az anyagok szélességének, és az ebben szereplő rekordoknak a „16 cm”, „18 cm”, „20 cm”, „24 cm” stb. nevet adhatják. A termékattribútumok a Termékadatok tábla „Hasonló elemek párosítása” mezőjében választhatók ki a „Hasonló elemek” beállítási idejének meghatározása érdekében.":
600 "A 3. termékattribútum adattáblában szereplő rekordok prioritási sorrendjének meghatározására szolgál, amelyet az APS-szabályok szerinti sorba rendezés alkalmaz.":
602 "Ez a mező számítja ki a teljes rendelés időtartamát az első művelet beállításának kezdési időpontja és a rendelésben lévő utolsó művelet befejezési időpontja között.":
620 "Termékkibocsátási szabály, amely a határidőig hátralévő időt a feladat befejezéséig várhatóan eltelt idővel elosztva meghatároz egy indexszámot. Az 1-es érték alatti szám azt jelzi, hogy a feladat lemaradásban van, míg az 1-nél nagyobb érték azt jelzi, hogy a feladat gyorsabban haladt az ütemtervhez képest.":
815 "Ezzel a lehetőséggel létrehozhatja a beállítási és a műveleti időkhöz használható értékeket. Ezenfelül a gyártórendszeren végbemenő feladatok előrehaladásának frissítésére is használható.":
1020 "Az erőforráscsoport nevének meghatározására szolgál. A név segítségével azonosíthatók a hasonló funkciók elvégzésére alkalmas erőforráscsoportok.":
1030 "Az erőforráscsoport érvényes erőforrásainak azonosítására szolgál. Az egyes erőforrások egynél több csoportba is tartozhatnak.":
1060 "Bekapcsolásakor ez a váltókapcsoló megjelenít egy, az erőforráscsoportra vonatkozó használati diagramot a sorrendvezérlő többdiagramos ablakában.":
1070 "Ez a szín jelenik meg a sorrendvezérlő többdiagramos ablakában látható használati diagramon.":
1080 "A sorrendvezérlő többdiagramos ablakában látható használati diagram ezzel a színnel jelenik meg, amennyiben a használati órák száma meghaladja az adott erőforrás vagy erőforráscsoport esetén engedélyezett órák számát (ha a „Használat max. órái” mező értéke nincs meghatározva). Ha a „Használat max. órái” mező ki van töltve, a diagram színe ennek az értéknek az alapján változik meg.":
1090 "A sorrendvezérlő többdiagramos ablakában látható használati diagram ezt a színt használja a beállítási művelet órákban mért hosszát ábrázoló vonal megrajzolásához.":
2020 "Az egyes erőforrások nevének meghatározására szolgál.":
2023 "Az erőforrás használatának óránkénti költsége.":
2024 "A fő naptárrekordokban meghatározott „Költségtényező (%)” alkalmazása az erőforrás óránkénti költségére.":
2030 "Ez a párbeszédpanel az erőforrások vagy az erőforráscsoportok Sorrend áttekintése ablakban és a használati diagramokon használt megjelenítési módjával kapcsolatos információkat tartalmaz.":
2040 "A Látható, Kis méret vagy Letiltva lehetőségek közül választhat. Itt állíthatja be, hogy az erőforrás ablaka a sorrendvezérlő elindításakor milyen kezdeti állapotban jelenjen meg. Alapértelmezésként a Kis méret lehetőség van beállítva. A Letiltva lehetőség kiválasztása esetén a rendszer nem használja az erőforrást a sorba állításhoz.":
2050 "A sorrendvezérlőben szereplő Gantt-erőforrásablakok vízszintes tengelyének (idő) szabályozására szolgál. A lépték a perctől egészen a hétig terjedhet.":
2070 "Az erőforrás-kapacitásoknál a következő lehetőségek beállítását teszi lehetővé: Véges, Végtelen vagy Korlátlan, műszakmintákkal.":
2071 "Az erőforrás-kapacitásoknál a következő lehetőségek beállítását teszi lehetővé: Véges, Végtelen vagy Korlátlan, műszakmintákkal (korlátlan kapacitású sorrendvezérlő üzemmód futtatásakor).":
2080 "A sorrendvezérlő mozaikos erőforrásablakaiban lévő vízszintes tengely (idő) beállítására szolgál.":
2100 "Az elsődleges erőforráson alkalmazandó másodlagos megkötések kiválasztására szolgál. Meghatározza az erőforrás által igényelt megkötések számát, illetve a megkötések elsődleges erőforráson való alkalmazásának módját.":
2110 "Meghatározza, hogy mikor kell csökkenteni vagy növelni a másodlagos erőforrás használatát, például a „Növelés adott időtartamig” mezővel, amely a művelet időtartama során végig használja a másodlagos megkötést, majd a művelet befejezésekor megszünteti annak használatát. Ha egy feladatot több művelet idejére egy rögzítőelembe helyeznek, az első műveletre vonatkozó „Növelés az indításkor” és az utolsó műveletre vonatkozó „Csökkentés a befejezéskor” mezőket kell meghatározni. Ezzel biztosítható, hogy a rögzítőelemet ne lehessen több feladathoz használni, amíg az első feladat egy erőforrásra várakozik.":
2120 "A másodlagos megkötés szükséges mennyiségét határozza meg. Ha a „Mennyiség” értékét választja ki, a szükséges mennyiség egyenlő lesz a feldolgozás alatt lévő köteg mennyiségével.":
2130 "A műveletek egy olyan attribútumát határozza meg, amely megakadályozza, hogy eltérő műveleteket párhuzamosan hajtsanak végre egy végtelen kapacitás-erőforráson.":
2150 "APS-termékek esetén azoknak a kritériumoknak a meghatározására szolgál, amelyeket a preferált sorrendvezérlési szabályok a feldolgozandó feladat kiválasztásához használnak.":
2160 "Used in the APS produc, by 'Minimize WIP' scheduling rules, to establish time buffers in which WIP can accumulate, ahead selected resources.":
2180 "A rendszer ez alapján a numerikus érték alapján határozza meg, hogy az erőforrások milyen sorrendben jelenjenek meg az erőforrások adattáblában. Ezenfelül az erőforrások a sorrend áttekintésében használt alapértelmezett sorrendjének a felülírására is használható.":
2181 "Megjeleníti a speciális erőforrásmegkötés-beállítások meghatározására szolgáló párbeszédpanelt.":
2182 "Lehetővé teszi, hogy a felhasználó kifejezések segítségével definiálja az erőforrások közötti összetett kapcsolatokat. A kifejezések szintaktikájával és létrehozásával kapcsolatos információkat a dokumentációban talál.":
2183 "Lehetővé teszi, hogy a felhasználó kiválassza egy végtelen kapacitású erőforráshoz tartozó művelet egyik attribútumát, amely meghatározza, hogy egy adott időpontban csak azokat a műveleteket lehessen beütemezni, amelyeknél ez az attribútum ugyanazt az értéket veszi fel.":
2185 "Annak meghatározására szolgál, hogy megjelenjen-e egy elválasztóvonal a Gantt-diagramon lévő erőforrás alatt. Ez a csoportokba rendezett erőforrások hatékonyabb megjelenítését teszi lehetővé.":
2190 "A Sorrend áttekintése ablakban megjelenő erőforrások megjelenítési módjának meghatározására szolgál. A következő lehetőségek közül választhat: „Mindig”, „Csak csoport esetén” és „Elrejtés”.":
2191 "Meghatározza, hogy a műveletek milyen módon jelenjenek meg a Sorrend áttekintése ablakban. A „Halmozott” beállítás használata esetén a műveletek egy áttekintési soron jelennek meg, a „Lépcsőzetes” beállítás esetén pedig minden művelet saját áttekintési sort kap.":
2200 "Sorrendfüggő beállítási értékek mátrixának létrehozására szolgál, amelyek meghatározzák, hogy mennyi beállítási idő szükséges ahhoz, hogy a rendszer egy adott attribútumtípusú termékről egy más attribútumtípusú termékre váltson.":
2201 "Ez a mező határozza meg, hogy a rendszer melyik átállási csoportot rendelje ehhez az erőforráshoz, és ezzel azt is megszabja, hogy a különböző attribútumokkal rendelkező műveletekre a rendszer melyik átállási időket alkalmazza.":
2202 "Meghatározza, hogy a rendszer egyidejűleg vagy összesítve alkalmazza az erőforráshoz tartozó beállítási és átállási időket.":
2205 "Ha bejelöli ezt a jelölőnégyzetet, a rendszer kivonja az erőforrást az ütemezés teljesítménymetrikáinak számításából.":
2210 "Ezzel a mezővel választhatja ki, hogy az erőforrás melyik megjelenítői rendszerhez tartozik. A mezőben a PCO-címtár adattáblából származó ütemezésirendszer-neveket tartalmazza.":
2220 "Ez a gomb egy párbeszédpanelt nyit meg, amely az erőforráshoz rendelt különböző attribútumokat tartalmazza.":
2230 "Ez a mező karakterláncattribútum-adatok megadását teszi lehetővé az erőforráshoz.":
2240 "Ez a mező valósattribútum-adatok megadását teszi lehetővé az erőforráshoz.":
2250 "Ez a mező időtartamattribútum-adatok megadását teszi lehetővé az erőforráshoz.":
2260 "Ez a mező határozza meg az erőforrás hatékonyságát. Az alapértelmezett érték 100%, ha a felhasználó ezt 200%-ra módosítja, az erőforrásra ütemezett műveletek kétszer olyan gyorsan mennek végbe (a normál műveleti idő fele alatt).":
2270 "Ha bekapcsolt állapotra állítja ezt a váltókapcsolót, a rendszer minden olyan műveletre alkalmazza a Hatékonyság (%) mező értékét, amelyhez beállítási idő tartozik, és a váltókapcsolóhoz tartozó erőforrásra van ütemezve.":
2280 "Bekapcsolásakor ez a váltókapcsoló megjelenít egy, az erőforrásra vonatkozó használati diagramot a sorrendvezérlő többdiagramos ablakában.":
2300 "Ezzel a mezővel kiválaszthat egy másodlagosmegkötés-csoportot, amelyből a rendszer a sorba rendezés során kiválasztja a másodlagos megkötést.":
2310 "A rendszer ehhez a mezőhöz rendeli a másodlagos megkötések csoportjából kiválasztott másodlagos megkötést.":
5035 "Költségtényező-szorzó, amely befolyásolja annak az erőforrásnak az üzemeltetési költségét, amelyre alkalmazzák. Ha az érték 100%, az nem jelent változást, a 150% azt jelenti, hogy az üzemeltetési költség 50%-kal nőtt. A fő naptárfájlokban használt alapértelmezett értékeket a Naptárállapotok adattábla határozza meg.":
6100 "Megjelenít egy párbeszédpanelt, amelyben ki lehet választani, hogy a kiválasztott csoport mely erőforrásai érvényesek, és amely lehetővé teszi az erőforrás-specifikus adatok hozzárendelését.":
6110 "Ez a mező határozza meg, hogy a rendszer kiválasztja-e az erőforrást az automatikus sorrendbe állítás során. Ha nem jelöli be, a műveletet manuális lehet elhelyezni az erőforrásokon.":
6120 "Ezzel a mezővel a művelet esetében érvényes összes erőforráshoz beállíthat egy egyéni beállítási időt.":
6130 "Ezzel a mezővel a művelet esetében érvényes összes erőforráshoz beállíthat egy egyéni műveleti időt.":
6131 "Ezzel a mezővel a művelet esetében érvényes összes erőforráshoz beállíthat egy egyéni óránkénti mennyiséget.":
6132 "Ezzel a mezővel a művelet esetében érvényes összes erőforráshoz beállíthat egy egyéni kötegidőt.":
6140 "Ezzel a mezővel határozhatja meg az elsődleges erőforrás által az aktuális művelet során használandó másodlagos erőforrást.":
6150 "Ezzel a mezővel határozhatja meg a másodlagos megkötés használatának módját a művelet során (például Növelés adott időtartamig, Csak a beállítási idő növelése stb.).":
6160 "Ezzel a mezővel adhatja meg, hogy a másodlagos megkötésből mennyire van szükség az aktuális műveletben. Megadhatja például, hogy a művelethez egy tokmány szükséges.":
6170 "Az ütemező ennyi ideig fog próbálkozni betölteni az aktuális műveletet az elsődleges erőforrásba. Ha ez az adott időn belül nem sikerül, az ütemező megpróbálja betölteni a műveletet a csoport bármely más erőforrására.":
6180 "A „Következő erőforráscsoport beállítása” létrehozza az adott csoportban lévő erőforrások „kényszerlistáját”. Ez a funkció arra kényszeríti a később műveleteket, hogy csak a „kényszerlistában” szereplő erőforrásokat használják. Ha a feldolgozási útvonal egy későbbi művelete például olyan erőforráscsoportot ír elő, amelynek egyes elemei nem szerepelnek a listán, a rendszer ezt nem fogja felhasználni a sorba rendezéshez. A „Következő erőforráscsoport beállítása” egy kumulatív függvény, és a feldolgozási útvonal több műveleténél is használható.":
6190 "A „Következő erőforráscsoport alaphelyzetbe állítása” függvény eltávolítja a kiválasztott erőforráscsoportban szereplő összes erőforrást a „Következő erőforráscsoport beállítása” parancs által létrehozott „kényszerlistáról”. Ha a felhasználó létrehozott egy „Minden” típusú erőforráscsoportot, amelyben az összes elérhető erőforrás szerepelt, a későbbi műveletek az eredeti feldolgozási útvonalban beállított erőforrásokat fogják használni.":
6230 "Ezzel a mezővel létrehozhat egy beállítási időt, amely egy korábbi termékből az aktuális termékhez konvertálható. A Beállítási idő mezőben szereplő értékeket a rendszer hozzáadja az erőforráshoz a sorrendfüggő beállítási idők mátrixában szereplő beállítási értékekhez.":
6430 "Válassza ki a kívánt ikon nevét a legördülő menüből. A szerkesztési gombbal új ikonokat is létrehozhat.":
6470 "Megjeleníti az „Érvényes másodlagos megkötések” párbeszédpanelt, amelyen az érvényes megkötéseket alkalmazhatja a táblában szereplő egyes rekordokra. A megkötések használatának jellemzőit is itt módosíthatja.":
6530 "Meghatározza, hogy két egymást követő művelet között legfeljebb mennyi idő telhessen el. A maximális intervallumot az „Intervallumtípus” mező is minősíti, hiszen ez határozza meg a „Kezdéstől kezdésig”, „Befejezéstől befejezésig” stb. kapcsolatokat.":
6540 "Meghatározza az egymást követő műveletek közé beilleszthető maximális időtartam (amelyet a „Max. időtartam a következő műveletig” mező határoz meg) viszonyát. Ez lehet „Befejezéstől befejezésig”, „Befejezéstől kezdésig”, „Kezdéstől kezdésig” vagy „Kezdéstől befejezésig”.":
6550 "Azt a maximális, az elméleti műveleti idő százalékos értékében meghatározott időt határozza meg, amennyi időt egy művelet a sorrendvezérlő által végzett automatikus sorrendvezérlés esetén igénybe vehet.":
6560 "Egy adott az adott művelet és az előző művelet közötti ráhagyás beállítására szolgál.":
6565 "Az adott művelet és a következő művelet közötti ráhagyás beállítására szolgál.":
6580 "Ebben a mezőben egy, a folyamat sebességére vonatkozó szorzót alkalmazhat a művelet hosszára.":
6681 "E mező segítségével adhatja meg a rekordnak azt az attribútumát, amelyre az egyik attribútumtábla hivatkozik. Ezekkel befolyásolni lehet a beállítási időket, az ütemezési sorrendet és a megkötések használatát.":
6682 "Ezzel a mezővel lehet szabad formátumú karakterlánc típusú attribútumot meghatározni ehhez a rekordhoz. Ezeket megjelenítési beállítások és csoportműveletek beállítására használhatja.":
6683 "Ezzel a mezővel lehet numerikus attribútumot meghatározni ehhez a rekordhoz. Ezeket a megjelenítési beállítások és a megkötés használatának beállítására, valamint az ütemezési sorrend befolyásolására használhatja.":
6684 "Ezzel a mezővel lehet dátum típusú attribútumot meghatározni ehhez a rekordhoz. Ezeket megjelenítési beállítások megadására, valamint az ütemezési sorrend befolyásolására használhatja.":
6685 "Ezzel a mezővel lehet időtartam típusú attribútumot meghatározni ehhez a rekordhoz. Ezeket megjelenítési beállítások megadására, valamint az ütemezési sorrend befolyásolására használhatja.":
6690 "Az Idő tartalék mezőben szereplő időtartamot a rendszer levonja a határidőből, amikor visszafelé irányuló sorba rendezést végez. Így a műveleteket a rendszer a legutolsó lehetséges idő előttre ütemezi. Ennek az a célja, hogy a folyamatban legyen elég idő a váratlan késésekre.":
7020 "Az aktuális dátum előtti napok száma, amelyeket szeretne megjeleníteni a Sorrend áttekintése ablakban.":
7030 "Az az időtartam az aktuális dátum után, amelyeket szeretne megjeleníteni a Sorrend áttekintése ablakot.":
7035 "Megnyit egy konfigurációbeállítási párbeszédpanelt, amelynek segítségével a felhasználó testre szabhatja a Sorrend áttekintése ablakot.":
7040 "Meghatároz egy, a rendelés bevitelétől számított eltolást, amely előtt nem szabad elkezdeni a feladatokat. Ha Nincs megadva értékre állítja, a kezdést csak az aktuális dátum korlátozza.":
7050 "Meghatároz egy, a rendelés bevitelétől számított eltolást, amelyen belül a feladatnak rendelkezésre kell állnia. Nem lehet felülírni.":
7060 "Az az időtartam, amennyivel a végvonalat eltolták az aktuális dátumtól. A végvonal egyenlő az aktuális dátummal, ha a végvonal eltolását 0 óra 00 percre állítják.":
7067 "Meghatározza a használandó költségszámítási módot, ami lehet: Sorrendvezérlés közben, Sorrendvezérlés után vagy Soha.":
7120 "A sorrend áttekintésének módját határozza meg.":
7130 "Azt határozza meg, hogy a sorrend áttekintésének kezdődátuma az aktuális dátumtól hány napra legyen.":
7140 "Azt határozza meg, hogy a sorrend áttekintésének befejezési dátuma az aktuális dátumtól hány napra legyen.":
7320 "Lehetővé teszi, hogy a rendelések importálásához szükséges parancsprogramot a „Parancsprogramok” adattáblából is ki lehessen választani.":
7330 "Lehetővé teszi, hogy a rendelések exportálásához szükséges parancsprogramot a „Parancsprogramok” adattáblából is ki lehessen választani.":
7430 "Ezzel a funkcióval bekapcsolhat egy, a sorrendvezérlő minden műveleti sávjában megjelenő kis fekete háromszöget. Így egyszerűbb elhúzni a tervezőtáblán elhelyezett műveleteket, különösen a kisebb elemeket.":
7450 "Azt határozza meg, hogy mely PESP típusú esemény-parancsprogram fusson, amikor a felhasználó az Adatátvitel menü „Rendelések importálása” gombjára kattint.":
7470 "Azt határozza meg, hogy mely PESP típusú esemény-parancsprogram fusson, amikor a felhasználó az Adatátvitel menü „Rendelések exportálása” gombjára kattint.":
7480 "Azt határozza meg, hogy mely PESP típusú esemény-parancsprogram fusson, amikor a felhasználó az Adatátvitel menü „Ütemezés kibocsátása” gombjára kattint.":
7490 "Meghatározza, hogy melyik legyen az az alapértelmezett PESP típusú esemény-parancsprogram, amelyet a rendszer a sorrendvezérlőben a műveletek kiosztására használ, ha az APS-szabályok funkció be van kapcsolva.":
8020 "Másodlagos megkötés neve.":
8030 "Ezzel a sorrendvezérlő felhasználói diagramjának azt a színét választhatja ki, amelyet a rendszer akkor jelenít meg, ha az értékek a magas és az alacsony határértékek közé esnek.":
8040 "A diagramkitöltési minta beállítására szolgál.":
8060 "A diagram kitöltési színe abban az esetben, ha a diagram átlépi a felső határértéket.":
8080 "A diagram kitöltési színe abban az esetben, ha a diagram átlépi az alsó határértéket.":
8090 "Azt határozza meg, hogy ez a másodlagos megkötés megkösse-e az ütemezést, ha a felhasználó 300 FCS vagy magasabb értékű terméket használ. Ha nem jelöli be ezt a jelölőnégyzetet, a sorrendvezérlő nem fog figyelmeztetést megjeleníteni, ha átlépi a másodlagos megkötéshez tartozó határértéket (ez a program összes verziójában így van).":
8091 "Ez a mező a korlátlan kapacitású sorrendvezérlő módban használható. Azt határozza meg, hogy ez a másodlagos megkötés kösse-e meg az ütemezést, ha 300 FCS vagy magasabb értékű terméket használnak.":
8092 "A megkötés működésének szabályozásához használható lehetőségek, amennyiben a rendszer végtelen kapacitású módra van állítva.":
8100 "Azt határozza meg, hogy az elsődleges erőforrásnaptár hatékonysága hogyan befolyásolja a másodlagos megkötés használatát. A következő lehetőségek közül választhat: „Nincs hatás”, „Hatékonyság használata a feladat kezdetén”, „A hatékonyság változásainak követése”, „100% használata, ha nagyobb mint 0%”":
8101 "Végtelen kapacitású sorrendvezérlő üzemmód esetén ez a mező azt határozza meg, hogy az elsődleges erőforrásnaptár hatékonysága hogyan befolyásolja a másodlagos megkötés használatát. A következő lehetőségek közül választhat: „Nincs hatás”, „Hatékonyság használata a feladat kezdetén”, „A hatékonyság változásainak követése”, „100% használata, ha nagyobb mint 0%”":
8120 "Ezzel a gombbal megnyithat egy párbeszédpanelt, amely a másodlagos megkötéshez rendelt különböző attribútumokat tartalmazza.":
8130 "Ez a mező karakterláncattribútum-adatok megadását teszi lehetővé a másodlagos megkötéshez.":
8140 "Ez a mező valósattribútum-adatok megadását teszi lehetővé a másodlagos megkötéshez.":
8150 "Ez a mező időtartamattribútum-adatok megadását teszi lehetővé a másodlagos megkötéshez.":
8160 "Ha bekapcsolt értékre állítják, ez a váltókapcsoló megjelenít egy, a másodlagos megkötésekre vonatkozó használati diagramot a sorrendvezérlő többdiagramos ablakában.":
8200 "A másodlagosmegkötés-csoport neve.":
8210 "Lehetővé teszi a másodlagosmegkötés-csoport tagjainak kiválasztását.":
9020 "A csoportnevek beállítására szolgál. Ezek adják az Erőforrások adattáblában szereplő sorrendfüggő beállítási idő mátrix X és Y tengelyét.":
12020 "Az 1. termékattribútum adattáblában lévő attribútumrekord neve.":
13020 "A 2. termékattribútum adattáblában lévő attribútumrekord neve.":
14020 "A 3. termékattribútum adattáblában lévő attribútumrekord neve.":
16020 "A Fájlnév alatt mentett képernyő-megjelenítési konfiguráció leírására szolgáló név. A rendszer ezt a leírást használja a munkaterületen lévő eszköztár ikonjainak elemleírásaként.":
16030 "A fájlt a mezőtől balra található gombbal lehet kiválasztani. Az eredeti munkaterület-konfiguráció fájljának (.WPI kiterjesztés) mentéséhez használja a sorrendvezérlő menüjének Munkaterület részén található Munkaterület mentése parancsot.":
18510 "A rendelést leadó személy vagy szervezet neve.":
18520 "A rendelést leadó szervezet elsődleges kapcsolattartójának neve.":
18530 "A rendeléssel kapcsolatban használandó telefonszám.":
18540 "A rendeléssel kapcsolatban használandó e-mail-cím.":
21000 "Ebben a mezőben eltérő „rendelésállapot” adható meg; a rendelésekhez kapcsolódó rendelésállapot az ütemezési fájlban választható ki.":
21020 "Ez a mező a „Rendelésállapot neve” mezőben megadott rendelésállapot nevének magyarázatára szolgáló szöveg tárolására szolgál.":
21100 "Az Attribútum adattáblában szereplő attribútumrekord neve.":
21110 "Az Attribútum adattáblában szereplő rekordok közötti prioritási rangsor meghatározására szolgál. Az ütemezési szabályok is ezt a rangsort alkalmazzák.":
24000 "Ez a mező azt határozza meg, hogy a rekord a szabálykészlet fölé- vagy alárendelt rekordja-e.":
24010 "A szabálykészlet nevét tartalmazza.":
24020 "Ez a váltókapcsoló arra szolgál, hogy törölje azoknak a rendeléseknek az összetűzési hivatkozásait, amelyek a szabálykészlet első meneténél az értékesítési várólistában szerepelnek (attól függetlenül, hogy a menet engedélyezve van-e).":
24030 "A szabálymenet egy adott függvényének nevét adja meg.":
24040 "Ha igaz értékre állítja ezt a váltókapcsolót, azzal engedélyezi a szabálymenetet, ha pedig hamis értékre, a rendszer figyelmen kívül hagyja ezt a szabálymenetet a szabálykészlet futtatása során.":
24050 "Ha a váltókapcsoló igaz értékre van állítva, és a felhasználó lefuttatja a szabálykészletet, a rendszer létrehoz egy hibakeresési fájlt a munkakönyvtárban.":
24060 "Ez a mező annak a kritériumnak a meghatározására szolgál, amelynek alapján a rendszer képes eldönteni, hogy mely elemek kerüljenek a belső ellátási várólistára. A mező alapértelmezett beállítása az ÖSSZES, de ez különböző kifejezések segítségével bármikor módosítható, pl. (~{$Order Type}~==~Stock~). Ez a várólista a „Munkarendelések” adatbázisban lévő rekordok szűrésére szolgál.":
24070 "Ez a mező a belső ellátási várólistán szereplő elemek rangsorolásához használandó kritériumot tartalmazza. A belső ellátási várólistán szereplő elemeket például határidő, legkorábbi kezdési dátum vagy prioritás szerint is rangsorolhatja.":
24080 "Ez a mező annak a kritériumnak a meghatározására szolgál, amely alapján a rendszer képes eldönteni, hogy mely elemek kerüljenek az értékesítési várólistára. A mező alapértelmezett beállítása az ÖSSZES, de ez külső kifejezések segítségével bármikor módosítható, pl. (~{$Order Type}~==~Stock~). Ez a várólista a „Munkarendelések” adatbázisban lévő rekordok szűrésére szolgál.":
24090 "Ez a mező az értékesítési várólistán szereplő elemek rangsorolásához használható kritériumot tartalmazza. Az értékesítési várólistán szereplő elemeket például határidő, legkorábbi kezdési dátum vagy prioritás szerint is rangsorolhatja.":
24100 "Ez a mező azoknak a különböző standard összetűzési szabályoknak a listáját tartalmazza, amelyek a rendelések összetűzésére használhatók. Ezenfelül három speciális elemet is tartalmaz – Felhasználó által meghatározott, Felhasználói függvény és PESP-parancsprogram, amelyek segítségével további egyéni szabályok hozhatók létre.":
24110 "Ez a mező csak akkor látható, ha a „Szabálytípus” mezőben a „Felhasználó által meghatározott” vagy a „Felhasználói függvény” lehetőség van kiválasztva. A szabályhoz használni kívánt kifejezést ebben a mezőben kell megadni. Példa: (~{+:$Product Attribute 1}~==~{-:$Product Attribute 1}~). A példában szereplő kifejezés csak akkor engedélyezi az ellátási és az értékesítési rendelések egymáshoz társítását, ha azok „1. termékattribútum” mezőjében ugyanaz az érték szerepel.":
24120 "Ez a mező csak akkor látható, ha a „Szabálytípus” mezőben a „PESP-parancsprogram” lehetőség van kiválasztva. A mező a szabályként használni kívánt PESP-parancsprogram nevét tartalmazza.":
24130 "Ez a funkció lehetővé teszi, hogy olyan anyagjegyzéksorokra vonatkozó hivatkozásokat is létrehozzanak, amelyeknél az anyagjegyzék sorában szereplő mennyiséget nem kötelező hiánytalanul teljesíteni. A rendszer azokat az elemeket, amelyekből nincs elegendő, hiánycikként jelöli meg.":
24140 "Ezzel a funkcióval beállíthatja, hogy csak olyan anyagjegyzéksorokra vonatkozó hivatkozások hozzanak létre, amelyeknél az anyagjegyzék sorában szereplő mennyiség hiánytalanul teljesült. A rendszer azokat az elemeket, amelyekből nincs elegendő, hiánycikként jelöli meg.":
24141 "E beállítás kiválasztása esetén a rendszer felülírja az SMC alapértelmezett működését, és visszafelé hivatkozások is létrehozhatók, amennyiben a termelés a felhasználást követően megy végbe.":
24150 "Ha igaz értékre állítják, a már beütemezett rendeléseknél ismét beállíthatók a hivatkozások.":
24160 "Ha igaz értékre állítják, az „Ellátási várólista rangsora” mező aktiválódik, ezzel lehetővé téve az ellátási rekordok az „Ellátási várólista rangsora” mezőben megadott kritérium szerinti rangsorolását. Ez a lehetőség csak abban az esetben használható, ha minden rekord a „Munkarendelések” adatbázisban található.":
24170 "Ez a mező annak a kritériumnak a meghatározására szolgál, amelynek alapján a rendszer képes eldönteni, hogy mely elemek kerüljenek a külső ellátási várólistára. A mező alapértelmezett beállítása az ÖSSZES, de ez különböző kifejezések segítségével bármikor módosítható, pl. (~{$Order Type}~==~Stock~). Ez a várólista az „értékesítés” adatbázisban lévő rekordok szűrésére szolgál.":
24180 "A rendszer az INHERIT FROM SUPPLY(Mező neve) besorolású összes mezőt feldolgozza.":
24190 "A rendszer az INHERIT FROM DEMAND(Mező neve) besorolású összes mezőt feldolgozza.":
24200 "Ha a váltókapcsoló be van kapcsolva, az „értékesítési várólista rangsora” mező aktiválódik, ami lehetővé teszi az ellátási rekordok az „értékesítési várólista rangsora” mezőben megadott kritérium szerinti rangsorolását. Ez a lehetőség csak abban az esetben használható, ha minden rekord a „Munkarendelések” adatbázisban található.":
24210 "Ha igaz értékre állítja, a rendszer a létrehozott hivatkozáshoz tartozó mennyiséget a megadott szorzók szerint osztja ki. A szorzót az anyagjegyzékadatok határozzák meg.":
24500 "Ha bejelöli a „Mindig ezt a szabálykészletet használja” jelölőnégyzetet, az ebben a mezőben kiválasztott összetűzési szabálykészlet fog alapértelmezésként futni, amikor a felhasználó a sorrendvezérlő „Anyagfelhasználás kiszámítása” funkcióját használja.":
24505 "E globális beállítás kiválasztása esetén a rendszer felülírja az SMC alapértelmezett működését, és visszafelé hivatkozások is létrehozhatók, amennyiben a termelés a felhasználást követően megy végbe.":
24510 "Ha bejelöli, a rendszer a „Kiválasztott összetűzési szabálykészlet” mezőben megadott szabályt fogja alapértelmezett szabályként használni, amikor a felhasználó a sorrendvezérlő „Anyagfelhasználás kiszámítása” elemét választja. Ha nincs bejelölve a „Mindig ezt a szabálykészletet használja” jelölőnégyzet, az „Anyagfelhasználás kiszámítása” funkció alkalmazásakor a rendszer megjeleníti a szabálykiválasztási párbeszédpanelt, amelyben a felhasználó kiválaszthatja a futtatni kívánt szabályt.":
25400 "Ez a mező a szállítói rendelések rendelésszámának rögzítésére szolgál.":
25410 "Ez a mező azonosítja a rendelés típusát (például Készlet vagy Vásárlás).":
25420 "A rendeléshez anyagokat szállító szervezet neve.":
25430 "A cikkszám, amelyre a rendelés vonatkozik.":
25440 "Az alkatrész leírása, amelyre a rendelés vonatkozik.":
25450 "Az anyagok beszállításának dátuma.":
25500 "Ezzel a mezővel adja meg, hogy az alkatrész melyik rendeléshez tartozik. A rendelés első sora lesz a fölérendelt rekord, és ebben a mezőben megjelenik a PARENT felirat. A többi rendelési sor alárendelt rekord lesz, ezeknél ebben a mezőben a kapcsolódó rendelés száma szerepel.":
25510 "Ez a mező az értékesítési rendelések rendelésszámának rögzítésére szolgál.":
25520 "Ez a mező azonosítja a rendelés típusát (például biztonsági készlet vagy értékesítési rendelés).":
25530 "A rendelések sorelemeinek egyedi azonosítója.":
25540 "A rendeléshez tartozó anyagokat igénylő szervezet neve.":
25550 "Az anyagok leszállításának várt dátuma.":
25560 "Az összetűzni kívánt elemek számát határozza meg. Gyakran előfordul, hogy több azonos elem egy dobozba vagy ládába kerül. Példa: 1 dobozba 12 darab kerül. Érkezik egy 60 darabra szóló rendelés. A rendszerben van egy 50 darabra szóló ellátási rendelés. A Preactor csak 48-at tűz össze az 50 darabból, és a fennmaradó 12 darabot máshol keresi meg, de ezeket csak akkor tűzi össze, ha pontosan 12 darabot talál. A funkció használatához be kell kapcsolnia az „Összetűzési szabályok” adatbázis „Csak több elem kiosztása” mezőjét.":
25600 "Az a rendelési szám, amelyhez az anyagjegyzék sora tartozik.":
25605 "Annak a rendelésnek a cikkszáma, amelyhez az anyagjegyzék sora tartozik.":
25610 "Az a műveletszám, amelyhez az anyagjegyzék sora tartozik.":
25611 "Annak a műveletnek a neve, amelyhez az anyagjegyzék sora tartozik.":
25615 "Annak a terméknek a cikkszáma, amely a megadott anyagot igényli.":
25620 "Az anyagjegyzékelem cikkszáma.":
25630 "Az anyagjegyzékelemből várt mennyiség.":
25640 "Ha igaz értékre állítja, a rendszer a rendelés mennyiségét felszorozza az anyagjegyzék szerinti szükséges mennyiséggel.":
25650 "Az összetűzési szabály futtatásakor a rendszer figyelmen kívül hagyja a hiánycikkeket. Lehetővé teszi a hiánycikkeket tartalmazó rendelések beütemezését.":
25700 "A rendelés száma, amelynek keretében a közös termék gyártása történik.":
25705 "A rendelés cikkszáma, amelynek keretében a közös termék gyártása történik.":
25710 "A művelet száma, amelynek keretében a közös termék gyártása történik.":
25715 "A művelet neve, amelynek keretében a közös termék gyártása történik.":
25720 "A közös termék neve.":
25730 "A közös termékből előállított mennyiség.":
25740 "Ha igaz értékre állítja, a rendszer a közös termék mennyiségét felszorozza a rendelési mennyiséggel.":
25800 "Ez a mező a rendelés típusának azonosítására szolgál, például: Munkarendelés, Megrendelés, Értékesítési rendelés vagy Raktárkészlet.":
25810 "Ha bejelöli, az adott nem ütemezett művelet nem fog többé megjelenni a „Nem ütemezett műveletek” ablakban.":
25820 "Megjelenít egy párbeszédpanelt, amelyen az anyagellenőrzéssel kapcsolatos mezők találhatók.":
25830 "Ez a mező az értékesítési rendelés állapotára vonatkozó információkat jelenít meg az anyagok összetűzését követően. A következő értékeket tartalmazhatja: „Ismeretlen”, „Teljesítve”, „Minden hiány figyelmen kívül hagyva”, „Hiányok”, „Túltermelés”, „Túltermelés, hiányok”, „Túltermelés, Minden hiány figyelmen kívül hagyva”.":
25840 "Ezt a mezőt a rendszer az anyagok összetűzését követően tölti ki. Ha megtörtént az összekapcsolás egy, az „Ellátási rendelések” adatbázisban szereplő ellátási rendeléssel, a rendszer beírja a „Munkarendelések” adatbázis „értékesítés dátuma” mezőjébe az ellátási rendelés „Szállítási dátum” értékét. A Preactor összehasonlítja a „Szállítási dátum” mezőt és a „Legkorábbi kezdési dátum” mezőt, és a két dátum közül a későbbit fogja használni az ütemezésben.":
25850 "Ezt a mezőt a rendszer az anyagok összetűzését követően tölti ki. Ha megtörtént az összekapcsolás egy, az „értékesítési rendelések” adatbázisban szereplő értékesítési rendeléssel, a rendszer beírja a „Munkarendelések” adatbázis „Szállítási dátum” mezőjébe a kapcsolódó értékesítési rendelés „értékesítés dátuma” értékét. A Preactor összehasonlítja az „értékesítés dátuma” mezőt és a „Határidő” mezőt, és a két dátum közül a korábbit fogja használni az ütemezésben.":
25900 "Megjelenít egy párbeszédpanelt, amely a művelet állapotával kapcsolatos mezőket tartalmaz.":
25910 "Ezt a lehetőséget a felosztott rendeléseknél lehet használni. Lehetővé teszi, hogy az egyes gyártási tételek önállóan haladjanak végig a gyártási folyamaton (azaz a következő művelet elindulásához nem szükséges az, hogy az összes tétel egy műveletben menjen végbe).":
25920 "Ez a mező határozza meg, hogy a rekord Gantt-diagramjának oszlopa milyen színt használjon.":
26000 "Ez a mező határozza meg az átállási csoport nevét.":
26100 "Ez a mező határozza meg, hogy a rendszer mennyi átállási időt állítson be, amikor a megadott attribútum két egymás utáni művelet között megváltozik.":
26200 "A felhasználói eszköz megjelenített neve.":
26210 "Az az esemény-parancsprogram, amelyet a felhasználói eszköz kiválasztása esetén futtatni kell.":
26220 "A felhasználói ablak eszközmenüjének neve.":
26230 "A felhasználói ablak kitöltésére használt kódfüggvény.":
26240 "a felhasználó ablak címkéje":
26300 "A menügomb neve. Arra is utal, hogy a gomb hol fog megjelenni a menürendszerben.":
26310 "Ez a mező határozza meg, hogy engedélyezve van-e a gomb, és így azt is, hogy a gomb megjelenik-e.":
26320 "Ez a mező határozza meg a gombon megjelenő szöveget.":
26330 "Az az esemény-parancsprogram, amelyet a menügomb kiválasztása esetén futtatni kell.":
;
