#VERSION 0
;
PLK POPUP HELP
1 "Z tym elementem nie jest skojarzony żaden temat pomocy.":
10 "To pole jest używane do identyfikacji do którego zlecenia należy ten produkt. W pierwszej operacji zlecenia jest ustawione jako PARENT, w innych operacjach jest ustawione na unikalny numer lub nazwę.":
40 "To pole jest używane do identyfikacji numeru indeksu produktu. W rozwijanej liście zostaną wyświetlone wszystkie numery produktów w tabeli danych produktów. Wybór numeru produktu automatycznie zmieni nazwę produktu.":
41 "To pole zawiera listę różnych statusów, które mogą być zdefiniowane przy zamówieniu. Wartości są pobierane z danych tabeli Order Status, gdzie nowy status można dodać w razie potrzeby. Wzór paska operacji, określony jest w tabeli Order Status dla każdego rodzaju status, i może być używane do określenia wzoru pasku operacji w zamówieniu, kiedy zamówienie jest zaplanowane w Generatorze Harmonogramu.":
45 "Pole to jest używane do określenia indeksu produktu.":
50 "To pole jest używane w celu identyfikacji produktu. Użyj rozwijanej listy aby wybrać nazwę, numer pozycji zostanie automatycznie zmieniony.":
55 "Pole to służy do identyfikacji nazwy produktu.":
60 "To pole jest używane do identyfikacji numeru zamówienia dla tego produktu. Zlecenie może być wewnętrzny numer zamówienia lub jeden wskazany przez klienta. Numer zamówienia musi być unikatowy.":
70 "To pole może być stosowane do przechowywania notatek na temat tego zamówienia. Może to być przypomnienie o terminach, lub po prostu wiadomość dla operatora.":
75 "Otwiera okno, pokazujące wszystkie informacje dotyczące atrybutów dla operacji.":
80 "Pole to służy do ustawiania priorytetu dla zadania, które z kolei będzie wykorzystywane przez generator harmonogramu. Im mniejsza liczba tym większy priorytet. Należy pamiętać, że priorytety mogą być ujemne, priorytet ujemny jest wyższy niż dodatni. Na przykład, -100 jest wyższym priorytetem niż -1 a 0 jest wyższym priorytetem niż 10.":
90 "To pole określa numer operacji w zleceniu. Służy do ustalenia harmonogramowanie zadań w Generatorze Harmonogramu. Operacja o niższym numerze operacji zostanie zakończona przed rozpoczęciem operacji o wyższym numerze. Jeśli są dwie operacji z tym samym numerem w produkcie, to obie zostaną zakończone przed rozpoczęciem operacji o wyższym numerze.":
110 "Jest to tekstowy opis lub nazwa operacji która jest realizowana, zidentyfikowana przez numer operacji.":
112 "Otwiera okno dialogowe zawierające informacje o danych zasobów przypisanych do tej operacji":
120 "Grupy przezbrojeń są zdefiniowane w tabeli grup przezbrojeń np. Grupa 1, Grupa 2, Grupa 3. Wartości te są używane jako osi w macierzach czasów przezbrojeń zależnych od kolejności, w celu określenia czasów przezbrojeń pomiędzy grupami. Grupy są przypisane w bazie produktów.":
130 "To pole identyfikuje grupę zasobów, które mogą wykonywać bieżącą operację.":
140 "Jeśli to konieczne, to pole może być używane do identyfikacji konkretnego zasobu, który ma realizować operację. Jeśli w tabeli danych produktów pole zostało ustawione na 'Wybierz z grupy', system może wykorzystać każdy zasób dostępny w grupie zasobów. Jeśli chcesz, aby wymusić wykonanie operacji na konkretnym zasobie z grupy a następnie za pomocą rozwijanej listy wybierz zasób.":
150 "W tym polu będzie wyświetlany rzeczywisty zasób, który przetworzy operację. Jeśli zlecenie nie zostało zaplanowana wcześniej, w tym polu będzie wyświetlana wartość 'Nie określono'. Jeśli operacja została już umieszczona na tablicy planistycznej, zostanie wyświetlony zasób, do którego ma ona zostać przypisana.":
180 "To pole jest używane w celu określenia, czy szybkość przetwarzania jest obliczana jako czas na partię, czas na element czy liczba elementów na godzinę. Po zaznaczeniu opcji 'czas na partię' czas wyświetlany w polu poniżej to czas przetwarzania wszystkich części w tej partii. Po zaznaczeniu opcji 'czas na element' czas przetwarzania stanowi iloczyn wartości z poniższego pola i wielkości partii. Po zaznaczeniu opcji 'ilość na godzinę' czas przetwarzania będzie obliczany bezpośrednio na podstawie liczby w partii.":
220 "Aktualnie wybrany jest typ czas przetwarzania operacji 'Czas na element'. W tym polu należy wprowadzić czas pracy dla każdego elementu.":
230 "Aktualnie wybrany jest typ czas przetwarzania operacji 'Czas na partię'. W tym polu należy wprowadzić łączny czas pracy dla partii.":
240 "Aktualnie wybrany jest typ czas przetwarzania operacji ilość na godzinę'. W tym polu należy określić liczbę elementów możliwych do wyprodukowania w ciągu godziny.":
251 "Kolor w tym polu wyznacza sposób kolorowania części paska operacji, na podstawie wartości obliczony z pól Średnia ilość partii i Średni czas partii.":
260 "To pole jest używane do określenia ilości partii lub zamówienia.":
270 "To pole określa zysk na zleceniu lub partii który może być brany pod uwagę w regule ważenia.":
280 "To pole pokaże czas rozpoczęcia pierwszej operacji w tym zleceniu jeśli jest włączona funkcja MakeSpan":
290 "To pole pokaże czas zakończenia ostatniej operacji w tym zleceniu, jeśli jest włączona funkcja MakeSpan":
300 "Ta wartość określa ilości, które powinny być wyprodukowane, zanim można rozpocząć kolejną operację. Wartość Nieokreślony uniemożliwi równoległe wykonywanie operacji":
360 "Służy do określania daty, przed którą zadanie nie może zostać rozpoczęte. Może to być na przykład data, gdy materiały będą dostępne.":
370 "To pole służy do określania daty wykonania. Termin realizacji jest używana do wyróżniania opóźnionych elementów w generatorze harmonogramu oraz do określania priorytetu wczytywania zadania na tablicy planistycznej, jeśli wybrano opcję 'Terminu realizacji'.":
380 "Wybierz ten przełącznik, aby wskazać generatorowi harmonogramów, że czasy rozpoczęcia i zakończenia są wartościami 'rzeczywistymi'. Gdy ta opcja jest ustawiona, ten przełącznik zapobiega usunięciu przydziału zlecenia z wszelkich zasobów w generatorze harmonogramu. W efekcie jest on trwale przypisany do tablicy planistycznej.":
390 "Generator harmonogramu określa w tym polu, po harmonogramowaniu, czasu w którym w zadaniu rozpocznie się czas przygotowania operacji.":
400 "Generator harmonogramu aktualizuje to pole, w trakcie harmonogramowania, do czasu, w którym zadanie ma się rozpocząć.":
410 "Generator harmonogramu aktualizuje to pole, w trakcie harmonogramowania, do czasu, w którym zadanie ma się zakończyć.":
420 "Blokowanie operacji na harmonogramie. Operacja nie zostanie cofnięta z planu. Można to również osiągnąć, używając trybu lokalizacji 'Wyróżnij zablokowane operacje' w generatorze poprzez wskazanie myszą operacji (ikony lub paska w widoku podglądu), naciśnięcie klawisza Shift na klawiaturze i naciśnięcie lewego przycisku myszy.":
421 "Operacje mające ten przełącznik zaznaczony zostaną pozostawione nieprzydzielone w oknie niezaharmonogramowanych operacji, podczas automatycznego planowania operacji.":
430 "Umożliwia definiowane przez użytkownika właściwości, które zostaną przypisane do produktów, np. kolor. W ramach określonego atrybutu rekordy atrybutów otrzymują ranking priorytetów, np. 'białe' wyroby mogą mieć wyższy priorytet niż 'żółte'.":
440 "Wypełnij informacje o ilości zakończonej i wprowadź czas do którego ta 'część partii' została zakończona w polu Średni czas partii.Generator harmonogramu automatycznie oblicza 'Czas zakończenia' dla tej operacji.":
450 "Wypełnij informacje o czasie zakończenia i wprowadź czas do którego ta 'część partii' została zakończona. Generator harmonogramu automatycznie oblicza 'Czas zakończenia' dla tej operacji.":
460 "Efektywny czas operacji wykorzystuje informację z pól Średni czas partii i Średnia ilość partii do obliczenia poprawionego czasu pracy na podstawie tych informacji. Należy zauważyć, że prawidłowe działanie tej funkcji zależy od zmodyfikowania wartości 'Ilość połowy partii' i 'Czas połowy partii', gdy w generatorze wyświetlany jest. W przeciwnym razie wartość w polu 'Efektywny czas operacji' zmieni się tylko przy kolejnym otwarciu generatora.":
474 "Wykorzystywane do rejestracji kosztów elementu w punkcie gdzie jest wprowadzany do procesu. Pole może być użyte do rejestrowania kosztów stałych za sztukę, takich jak umowy podwykonawstwa obróbki cieplnej i tak dalej.":
476 "Używa Koszt materiału na element w celu podania kosztów materiałowych dla partii, w momencie w którym koszt na element jest wprowadzany do procesu.":
477 "Bezpośrednie koszty pracy w bieżącym procesie.":
530 "Określa horyzont czasowy, w którym możliwe jest łączenie zadań na potrzeby produkcji. Zasób, który kończy operację na tablicy planistycznej będzie się znajdować dalej od tego punktu na osi czasu określonej dla horyzontu czasowego w oknie modułu prognostycznego. Konfiguracja preferowanych kryteriów harmonogramowanie w tabeli danych zasobów służy do wybierania zadań, których termin realizacji przypada w tym horyzoncie czasowym. Okno modułu prognostycznego można określić dla poszczególnych produktów, w tabeli danych produktów, a także można je zmodyfikować dla poszczególnych zleceń w pliku harmonogramu głównego. Można je również określić jako regułę globalną w informacjach o konfiguracji.":
540 "Określone w tabeli danych produkty, umożliwia dostęp do dokumentu programu Word, który może zawierać informacje dotyczące produktu. Dostęp do dokumentu i jego edycji jest również możliwy w generatorze harmonogramu.":
541 "To pole jest używane do opisania przebiegu poszczególnych operacji. Istnieją cztery różne statusy postępu: Nie rozpoczęto; Czas przygotowania; Uruchomienie; Zakończone":
550 "Z produktami mogą być skojarzone określone właściwości. W generatorze harmonogramów znajdują się one w tabelach danych atrybutów. Te tabele są definiowane przez użytkownika i na przykład tabela Atrybut produktu 1 może być zarezerwowana dla koloru i zawierać konkretne rekordy - czerwony, niebieski, zielony itp. Atrybuty produktu można wybrać w polu Dopasuj podobne w tabeli danych produktów w celu zdefiniowania czasu konfiguracji funkcji Dopasuj podobne.":
560 "Wykorzystywane do ustalenia rankingu priorytetowego między rekordami w tabeli Atrybut Produkt 1, używane przez Reguły APS.":
570 "Produkty mogą mieć szczególne cechy związane z nimi, w Generatorze Harmonogramów są one uwzględnione w tabelach danych atrybutów produktów. Te tabele są zdefiniowane przez użytkownika i na przykład, atrybut produktu 2 może być zarezerwowane dla materiału, w których poszczególne rekordy będą się nazywać - stal, miedź itp.":
580 "Wykorzystywane do ustalenia rankingu priorytetowego między rekordami w tabeli Atrybut Produkt 2, używane przez Reguły APS.":
590 "Produkty mogą mieć szczególne cechy związane z nimi, w Generatorze Harmonogramów są one uwzględnione w tabelach danych atrybutów produktów. Te tabele są zdefiniowane przez użytkownika i na przykład, atrybut produktu 2 może być zarezerwowane dla materiału, w których poszczególne rekordy będą się nazywać - stal, miedź itp.":
600 "Wykorzystywane do ustalenia rankingu priorytetowego między rekordami w tabeli Atrybut Produkt 3, używane przez Reguły APS.":
602 "To pole oblicza czas trwania całego zamówienia od momentu rozpoczęcia przygotowania pierwszej operacji do czasu zakończenia ostatniej operacji zlecenia.":
620 "Reguła wysyłania, która oblicza numer indeksu, dzieląc czas pozostały do daty wykonania przez oczekiwany pozostały czas potrzebny na wykonanie zadania. Współczynnik o wartości poniżej 1 wskazuje, że wystąpiło opóźnienie, natomiast wartość powyżej 1 wskazuje na wykonanie przed czasem.":
815 "Ta opcja pozwala na wprowadzenie wartości do czasu przygotowania i czasu operacji. Jest również używany do aktualizacji postępu zadań poprzez system produkcji.":
1020 "Określa nazwę grupy zasobów. Będzie ona służyła do identyfikacji określonych grup zasobów, będących w stanie wykonać podobnye funkcje.":
1030 "Identyfikuje poprawne zasoby dla grupy zasobów. Zasób może być członkiem więcej niż jednej grupy.":
1060 "Włączenie tego przełącznika spowoduje wyświetlenie wykresu użycia dla grupy zasobów w kilku oknach wykresu w generatorze harmonogramów.":
1070 "Kolor ten będzie wyświetlany na wykresie użytkowania, który jest widoczny w kilku oknach wykresu w generatorze harmonogramów.":
1080 "Wykres wykorzystania dostępny w kilku oknach wykresu w generatorze harmonogramu wyświetli ten kolor, gdy wykorzystanie przekracza liczbę godzin dostępna dla zasobu lub grupy zasobów Jeśli wartość została wpisana to następnie wykres zmieni kolor zgodnie z tą wartością.":
1090 "Wykres wykorzystania w kilku oknach wykresu w generatorze harmonogramu będzie korzystać z tych kolorów, aby narysować linię, która oznacza wykorzystanie czasu przygotowania w godzinach.":
2020 "Określa nazwę poszczególnych zasobów.":
2023 "Koszt godziny pracy zasobu.":
2024 "Stosuje współczynnik kosztów %, określany w kalendarzu, do kosztu godzinnego dla zasobu.":
2030 "Otwiera okno dialogowe z dostępem do opcji wyświetlania zasobów, lub grup zasobów w oknie harmonogramu i wykresach wykorzystania.":
2040 "Można określić ustawienie Widoczne, Zminimalizowane lub Wyłączone. Kontrola stanu początkowego tego zasobu w oknie, gdy zaczyna pracę generatora. Normalnie ustawiony na Minimalizuj. Jeśli Wyłączony, zasób nie jest używany do harmonogramowania.":
2050 "Kontrola poziomej (czasu) skali wykresu Gantta w generatorze harmonogramu. Mogą różnić się od minuty do kilku tygodni na jednostkę.":
2070 "Pozwala ustawić pojemność zasobu jako Skończona, Nieskończona lub Nieskończona z wzorcem zmian.":
2071 "Pozwala ustawić pojemność zasobu jako Skończona, Nieskończona lub Nieskończona z wzorcem zmian, gdy w generatorze harmonogramu włączony jest tryb nieskończonej pojemności.":
2080 "Kontroli poziomej skali (czasu)  w oknie zasobów w Generatorze Harmonogramu.":
2100 "Umożliwia wybranie dodatkowych ograniczeń, które mają zostać zastosowane do zasobu podstawowego. Określa liczbę ograniczeń wymaganą przez zasób oraz sposób, w jaki ograniczenia są stosowane do zasobu pierwszorzędowe.":
2110 "Określa, kiedy należy zwiększyć lub zmniejszyć użycie zasobu drugorzędowe, np. Zwiększenie czasu trwania, które wykorzystuje dodatkowe ograniczenie dla czasu trwania operacji i zwalnia zasób po jej zakończeniu. Jeśli zadanie jest ustawione dla mocowania do wykonania kilku operacji, można określić ustawienie Zwiększ przy rozpoczęciu dla pierwszej operacji i Zmniejsz przy zakończeniu dla ostatniej operacji. Dzięki temu danego osprzętu nie będzie można użyć dla żadnego innego zadania, gdy pierwsze zadanie oczekuje w kolejce na zasób.":
2120 "Określa wymaganą ilość drugorzędowego ograniczenia. Jeżeli wartość 'Ilość' jest zaznaczona wymagana ilość równa jest ilości partii która jest wykonywana.":
2130 "Określa atrybut operacji, który zapobiegnie wykonywania niepodobnych operacji jednocześnie na zasobach o nieograniczonych zdolnościach produkcyjnych.":
2150 "Używany w produktach APS, w celu ustalenia kryteriów stosowanych przez preferowane reguły harmonogramowania w wyborze zadań do wykonania.":
2160 "Używane w produkcie APS, przez reguły planowania 'Minimalizuj WIP', w celu ustalenia buforów czasu, w którym może gromadzić się WIP, przed wybranymi zasobami.":
2180 "Wartość liczbowa użyta do sortowania kolejność, w której zasoby są wyświetlane w tabeli zasobów. Może być również użyta do nadpisania domyślnej kolejności w której zasoby są wyświetlane w generatorze harmonogramu.":
2181 "Otwiera okno dialogowe zawierające informacje o zaawansowanych ograniczeniach dla zasobu":
2182 "Umożliwia określenie złożonych relacji między zasobami przy użyciu wyrażeń. Szczegółowe informacje o składni wyrażeń i tworzeniu można znaleźć w dokumentacji.":
2183 "Określa atrybut operacji, który zapobiegnie wykonywania niepodobnych operacji jednocześnie na zasobach o nieograniczonych zdolnościach produkcyjnych.Atrybut ten określa, że tylko operacje o tej samej wartości w wybranym atrybucie mogą być planowane w tym samym czasie.":
2185 "Określa, czy linia separatora jest wyświetlany dla zasobu na wykresie Gantta. To może pomóc podczas wizualizowania zasobów w grupach.":
2190 "Określa sposób, w jaki zasób zostanie wyświetlony wykresie Gantta. Alternatywy to 'Zawsze', 'Tylko dla grupy' i 'Ukryj'.":
2191 "Określa sposób wyświetlania operacji w oknie harmonogramu operacji. Dostępne opcje to 'Stos' (operacje są wyświetlane w jednym wierszu przeglądu) i 'Kaskadowo' (każda operacja jest wyświetlana w osobnym wierszu przeglądu).":
2200 "Wykorzystywane do definicji macierzy czasów przezbrojeń zależnych od kolejności. Określa się czas przygotowania przy przezbrojeniu z jednego typu atrybutu na inny.":
2201 "W tym polu można określić, która grupa przezbrojeń jest przypisana do danego zasobu i w konsekwencji określa, które czasy przezbrojenia między operacjami o różnych atrybutach są stosowane.":
2202 "To pole określa czy czasy przezbrojeń związane z operacjami są wykonywane w tym samym czasie czy mają być łączone jako suma czasów przezbrojeń.":
2205 "Użycie tego pola wyboru zatrzymuje włączenie zasobów do statystyki harmonogramu.":
2210 "To pole jest używane do wyboru systemu Viewer do którego zasoób będzie przypisany, Zawiera listę nazw  pochodzącą z danych książki adresowej tabeli PCO.":
2220 "Ten przycisk otwiera okno dialogowe, wymieniając różne atrybuty związane z zasobami.":
2230 "To pole pozwala na wprowadzenie nazwy atrybutu dla tego zasobu.":
2240 "To pole pozwala na wprowadzenie nazwy atrybutu dla tego zasobu.":
2250 "To pole umożliwia wprowadzenie danych atrybutu czasu trwania dla zasobu.":
2260 "To pole wskazuje wydajność zasobu. Wartością domyślną jest 100%. Jeśli wydajność zostanie zmieniona na 200%, wszelkie operacje zaplanowane dla tego zasobu będą przetwarzane dwa razy szybciej (tj. połowę zwykłego czas przetwarzania operacji).":
2270 "Jest to pole przełącznika, którego włączenie powoduje zastosowanie wartości w polu % wydajności do wszystkich operacji, dla których określono czasy konfiguracji i które są zaplanowane w przypadku zasobu z włączonym przełącznikiem.":
2280 "Po włączeniu tego przełącznika zostanie wyświetlony wykres użycia dla zasobu w oknie wielu wykresów w Sekwencerze.":
2300 "To pole służy do wyboru grupy ograniczeń drugorzędowych, z której przydzielane będzie ograniczenie drugorzędowe podczas harmonogramowania.":
2310 "Do tego pola przypisane zostanie ograniczenie drugorzędowe przydzielone z grupy ograniczeń drugorzędowych.":
5035 "Mnożnik czynnika kosztowego, który ma wpływ na koszt uruchomienia zasobu, do którego jest zastosowany. Wartość 100% nie powoduje zwiększenia, natomiast wartość 150% powoduje zwiększenie kosztu uruchomienia o 50%. Ustawienia te są określane w tabeli danych stanów kalendarza i zapewniają wartości domyślne, które są używane w plikach kalendarza głównego.":
6100 "Wyświetla okno dialogowe, które pozwala na wybór prawidłowych zasobów z wybranej grupy oraz przypisanie danych specyficznych dla zasobów.":
6110 "To pole określa, czy zasób zostanie wybrany podczas sekwencjonowania automatycznego. Jeśli to pole nie jest zaznaczone, operację można mimo wszystko ręcznie ustawić dla zasobu.":
6120 "To pole umożliwia określenie indywidualnej wartości czas przygotowania dla każdego z zasobów, które są prawidłowe w danej operacji.":
6130 "To pole umożliwia określenie indywidualnego czasu konfiguracji dla każdego z zasobów, które są prawidłowe w danej operacji.":
6131 "To pole umożliwia określenie indywidualnej Ilość na godzinę dla każdego z zasobów, które są prawidłowe w danej operacji.":
6132 "To pole umożliwia określenie indywidualnego czasu partii dla każdego z zasobów, które są prawidłowe w danej operacji.":
6140 "To pole służy do definiowania zasobu drugorzędowe używanego przez zasób podstawowy podczas bieżącej operacji.":
6150 "To pole służy do określania, w jaki sposób ograniczenie dodatkowe jest używane podczas operacji, np. Zwiększenie czasu trwania lub Zwiększ tylko Czas przygotowania itp.":
6160 "Użyj tego pola, aby wskazać wielkość ograniczenia drugorzędowego wymaganego podczas bieżącej operacji. Można na przykład określić, że operacja wymaga jednego stałego uchwytu tokarskiego szczękowego.":
6170 "Menedżer harmonogramów wykorzysta ten czas na próbę wczytania bieżącej operacji do preferowanego zasobu. Jeśli w tym czasie będzie to niemożliwe, zostanie podjęta próba wczytania operacji na dowolnych innych zasobach w grupie.":
6180 "Funkcja Ustaw kolejną grupę zasobów umożliwia określenie 'wymuszonej listy' zasobów, tj. zasobów określonych w wybranej grupie. 'Wymusza' ona używanie przez dalsze operacje tylko tych zasobów które znajdują się na 'wymuszonej liście'. Dlatego jeśli ścieżka procesu wywołuje grupę zasobów w dalszej operacji, która zawierała zasoby nieznajdujące się na liście, zasoby te nie zostaną użyte podczas Sekwencjonowania. Funkcja Ustaw kolejną grupę zasobów ma charakter skumulowany i można jej użyć w więcej niż jednej operacji na ścieżce procesu poprzez dodanie zasobów do 'wymuszonej listy'.":
6190 "Funkcja Resetuj kolejną grupę zasobów służy do usuwania wszystkich zasobów znajdujących się w wybranej grupie zasobów z 'wymuszonej listy' określonej przy użyciu polecenia Ustaw kolejną grupę zasobów. Jeśli określono koncepcyjną grupę zasobów 'Wszystkie' zawierającą wszystkie dostępne zasoby, zasobami używanymi w kolejnych operacjach będą te ustawione na oryginalnej ścieżce procesu.":
6230 "To pole umożliwia określenie czasu konfiguracji związanego z przełączeniem z poprzedniego produktu na bieżący produkt. Wartości w polu Czas przygotowania zostaną dodane do wszystkich wartości konfiguracji określonych dla danego zasobu w macierzy Czas przygotowania zależny od harmonogramowanie.":
6430 "Wybierz nazwę ikony z listy rozwijanej. Przycisk edycji umożliwia tworzenie nowych ikon.":
6470 "Wyświetla okno dialogowe Prawidłowe ograniczenia drugorzędowe, umożliwiając zastosowanie prawidłowych ograniczeń do pojedynczych rekordów w tej tabeli. W tym miejscu można również edytować charakterystyki użycia ograniczeń.":
6530 "Określa maksymalny przedział czasu dozwolony pomiędzy dwiema operacjami Sekwencyjnymi. Maksymalny przedział czasu jest określany przez pole 'Typ interwału', które ustanawia relacje 'Początek-początek', 'Koniec-koniec' itp.":
6540 "Ustanawia relację używaną do wstawiania maksymalnego przedziału czasu między dwoma sąsiednimi operacjami w polu interwał maksymalny czas między dwóch sąsiadujących operacji, w polu 'Maks czas przed kolejną operacją'. Może to być relacja 'Koniec-koniec', 'Koniec-początek', 'Początek-początek' lub 'Początek-koniec'.":
6550 "Określa maksymalną ilość czasu, wyrażoną jako procent teoretycznego czas przetwarzania operacji, w którym operacja może być wykonywana, gdy jej Sekwencja jest określana automatycznie przez Sekwencer.":
6560 "Definiuje określoną ilość zapasu czasu, który ma być uwzględniony pomiędzy tą operacją i poprzednią.":
6565 "Definiuje określoną ilość zapasu czasu, który ma być uwzględniony pomiędzy tą operacją i następną.":
6580 "To pole może być używane do stosowania mnożnika szybkości przetwarzania, który wpływa na długość operacji.":
6681 "To pole służy do określania atrybutu tego rekordu, do którego odwołuje się jedna z tabel atrybutów. Mają one wpływ na czasy konfiguracji, kolejność tworzenia harmonogramu i użycie ograniczeń.":
6682 "To pole służy do określania atrybutu tego rekordu w dowolnym formacie. Można go użyć w celu ustawienia opcji wyświetlania oraz do grupowania operacji.":
6683 "To pole służy do określania atrybutu liczbowego tego rekordu. Można go użyć w celu ustawienia opcji wyświetlania, zmodyfikowania kolejności tworzenia harmonogramu oraz użycia ograniczeń.":
6684 "To pole służy do określania atrybutu daty tego rekordu. Można go użyć w celu ustawienia opcji wyświetlania i zmodyfikowania kolejności tworzenia harmonogramu.":
6685 "To pole służy do określania atrybutu czasu trwania tego rekordu. Można go użyć w celu ustawienia opcji wyświetlania i zmodyfikowania kolejności tworzenia harmonogramu.":
6690 "Pole Bufor dostawy zawiera czas bufora, który jest odejmowany od Daty wykonania podczas tworzenia harmonogramowanie wstecznej w celu zaplanowania operacji wcześniej niż najpóźniejsza możliwa godzina. Dzięki temu możliwe jest uwzględnienie nieoczekiwanych opóźnień w procesie.":
7020 "Liczba dni przed bieżącą godziną, która może być wyświetlana w przeglądzie harmonogramowanie.":
7030 "Przedział czasu po bieżącej godzinie, który może być wyświetlany w przeglądzie Sekwencera.":
7035 "Otwiera okno dialogowe ustawień konfiguracji, która pozwala użytkownikowi na dostosowywanie przeglądu harmonogramowanie.":
7040 "Określa przesunięcie względem godziny wprowadzania zlecenia, przed którą nie można rozpocząć zadania. Jeśli ustawiono wartość Nie określono, nie istnieje żadne ograniczenie poza bieżącą godziną.":
7050 "Określa przesunięcie względem godziny wprowadzenia zlecenia, przed którą zadanie powinno być dostępne. Wartość tę można zastąpić.":
7060 "Ilość czasu przesunięcia zakończenia od bieżącej godziny. Zakończenie reprezentuje bieżącą godzinę, jeśli przesunięcie zakończenia zostało ustawione na 0 godzin i 00 minut.":
7067 "Określa opcje kalkulacji kosztów, tj.: Podczas harmonogramowanie, Po harmonogramowanie lub Nigdy.":
7120 "Ustawia tryb przeglądu harmonogramowanie.":
7130 "Liczba dni od teraz do rozpoczęcia przeglądu harmonogramowanie.":
7140 "Liczba dni od teraz do końca przeglądu harmonogramowanie.":
7320 "Umożliwia wybranie z tabeli danych 'Skrypty' skryptu wymaganego do importowania zleceń.":
7330 "Umożliwia wybranie z tabeli danych 'Skrypty' skryptu wymaganego do eksportowania zleceń.":
7430 "Zaznaczenie tego pola przełącznika powoduje wyświetlenie niewielkiego czarnego trójkąta przy pasku każdej operacji w generatorze harmonogramu. Ta funkcja ułatwia przeciąganie operacji przydzielonych na tablicy planistycznej, zwłaszcza mniejszych.":
7450 "Określa domyślny skrypt zdarzenia PESP, który należy uruchomić podczas importowania zleceń przy użyciu przycisku 'Importuj zlecenia' w menu transferu danych.":
7470 "Określa domyślny skrypt zdarzenia PESP, który należy uruchomić podczas eksportowania zleceń przy użyciu przycisku 'Eksportuj zlecenia' w menu transferu danych.":
7480 "Określa domyślny skrypt zdarzenia PESP, który należy uruchomić podczas wydawania harmonogramu przy użyciu przycisku 'Wydaj harmonogram' w menu transferu danych.":
7490 "Określa domyślny skrypt zdarzenia PESP, który należy uruchomić podczas przydzielania operacji w Sekwencerze z włączoną opcją Reguły APS.":
8020 "Nazwa ograniczenia drugorzędowego.":
8030 "Pozwala wybrać kolor wydruku użytkownika Sekwencera, gdy wartości są z przedziału między górnym i dolnym limitem.":
8040 "Ustawia deseń wypełnienia wykresu.":
8060 "Kolor wypełnienia wykresu, jeśli wykres ma przechodzić przez górny limit wykresu.":
8080 "Kolor wypełnienia wykresu, jeśli wykres ma przechodzić przez dolny limit wykresu.":
8090 "Określa, czy to ograniczenie dodatkowe ma ograniczać harmonogram, gdy używany jest produkt 300 FCS lub nowszy. We wszystkich wersjach niezaznaczenie tego pola wyboru spowoduje wstrzymanie wysyłania ostrzeżeń w Sekwencerze, jeśli limity ustawione dla tego ograniczenia drugorzędowego zostaną przekroczone.":
8091 "Gdy włączony jest tryb nieskończonej zdolności Sekwencera, to pole umożliwia określenie, czy to ograniczenie dodatkowe ma ograniczać harmonogram, gdy używany jest produkt 300 FCS lub nowszy.":
8092 "Opcje do kontrolowania zachowania tego ograniczenia, gdy system jest ustawiony na tryb nieograniczonej zdolności.":
8100 "Określa, jak wydajność kalendarza zasobu podstawowego wpływa na wykorzystanie tego ograniczenia drugorzędowego. Dostępne opcje: Brak wpływu; Wydajność początku zadania; Śledź zmiany wydajności; Użyj 100% jeśli więcej niż 0%":
8101 "W trybie nieograniczonej zdolności Sekwencera to pole określa, jak wydajność kalendarza zasobu podstawowego wpływa na wykorzystanie tego ograniczenia drugorzędowego. Dostępne opcje: Brak wpływu; Wydajność początku zadania; Śledź zmiany wydajności; Użyj 100% jeśli więcej niż 0%":
8120 "Ten przycisk otwiera okno dialogowe, w którym wyświetlana jest lista różnych atrybutów powiązanych z ograniczeniem dodatkowym.":
8130 "To pole umożliwia wprowadzenie danych atrybutu dla ograniczenia drugorzędowego.":
8140 "To pole umożliwia wprowadzenie danych atrybutu rzeczywistego dla ograniczenia drugorzędowego.":
8150 "To pole umożliwia wprowadzenie danych atrybutu czasu trwania dla ograniczenia drugorzędowego.":
8160 "Po włączeniu tego przełącznika zostanie wyświetlony wykres użycia dla ograniczenia drugorzędowego w oknie wielu wykresów w Sekwencerze.":
8200 "Nazwa grupy ograniczeń drugorzędowych.":
8210 "Służy do wybierania, które ograniczenia drugorzędowe mają należeć do tej grupy.":
9020 "Nazwy grup konfiguracji. Tworzą one osie X i Y macierzy czasu konfiguracji zależnej od harmonogramowanie w tabeli danych zasobów.":
12020 "Nazwa rekordu atrybutu w tabeli danych atrybutu produktu 1.":
13020 "Nazwa rekordu atrybutu w tabeli danych atrybutu produktu 2.":
14020 "Nazwa rekordu atrybutu w tabeli danych atrybutu produktu 3.":
16020 "Nazwa używana do opisywania konfiguracji wyświetlania na ekranie, zapisana pod nazwą pliku. Ten opis jest również używany jako wyświetlana porada dla ikon paska narzędzi w obszarze roboczym.":
16030 "Plik jest wybierany przy użyciu opcji dostępnej po naciśnięciu przycisku znajdującego się z lewej strony pola. Oryginalny plik konfiguracji obszaru roboczego jest zapisywany z rozszerzeniem pliku .WPI przy użyciu polecenia Zapisz obszar roboczy, dostępnego w sekcji Obszar roboczy w menu Sekwencera.":
18510 "Nazwa osoby lub organizacji składającej zlecenie.":
18520 "Nazwa głównej osoby kontaktowej w organizacji składającej zlecenie.":
18530 "Numer telefonu, który ma być używany w związku ze zleceniem.":
18540 "Adres e-mail, który ma być używany w związku ze zleceniem.":
21000 "To pole umożliwia wprowadzanie różnych 'statusów zlecenia'. Status zlecenia można wybrać dla zlecenia w pliku harmonogramu.":
21020 "To pole służy do przechowywania opisu znaczenia nazwy statusu zlecenia, która została wprowadzona w polu 'Nazwa statusu zlecenia'.":
21100 "Nazwa rekordu atrybutu w tabeli danych atrybutu.":
21110 "Służy do określania priorytetów rekordów w tabeli danych atrybutu, która może być używana przez reguły tworzenia harmonogramu.":
24000 "To pole określa, czy dany rekord jest rekordem nadrzędnym czy podrzędnym względem zestawu reguł.":
24010 "Zawiera nazwę zestawu reguł.":
24020 "Ten przełącznik jest używany do usuwania powiązań tylko w przypadku zleceń znajdujących się w kolejce zapotrzebowania w pierwszym sprawdzeniu (niezależnie od tego, czy są włączone, czy nie) zestawu reguł.":
24030 "Przechowuje nazwę określonej funkcji sprawdzania reguły.":
24040 "Przełącznik, w przypadku którego ustawienie wartości true powoduje włączenie sprawdzenia reguły, a ustawienie wartości false dla tego konkretnego sprawdzenia reguły zostanie zignorowane, gdy uruchomiony jest zestaw reguł.":
24050 "Gdy dla tego przełącznika ustawiona jest wartość true i uruchomiony jest zestaw reguł, w katalogu roboczym tworzony jest plik debugowania.":
24060 "To pole służy do określania kryteriów, które mogą być używane do ograniczania elementów umieszczanych w wewnętrznej kolejce dostaw. Wartość domyślna tego pola jest ustawiona jako ALL, ale można ją zmienić, wprowadzając wyrażenie np. (~{$Order Type}~==~Stock~). Kolejka ta filtruje rekordy znajdujące się w bazie danych 'Zlecenie produkcyjne'.":
24070 "To pole zawiera kryteria, które mogą być używane do tworzenia rankingów elementów w wewnętrznej kolejce dostaw. Ranking w wewnętrznej kolejce dostaw można określić na przykład na podstawie daty wykonania, najwcześniejszej daty rozpoczęcia lub priorytetu.":
24080 "To pole służy do określania kryteriów, które mogą być używane do ograniczania elementów umieszczanych w kolejce zapotrzebowania. Wartość domyślna tego pola jest ustawiona jako ALL, ale można ją zmienić, wprowadzając wyrażenie np. (~{$Order Type}~==~Stock~). Kolejka ta filtruje rekordy znajdujące się w bazie danych 'Zlecenie produkcyjne'.":
24090 "To pole zawiera kryteria, które mogą być używane do tworzenia rankingów elementów w wewnętrznej kolejce zapotrzebowania. Ranking w wewnętrznej kolejce zapotrzebowania można określić na przykład na podstawie daty wykonania, najwcześniejszej daty rozpoczęcia lub priorytetu.":
24100 "To pole zawiera listę różnych standardowych reguł grupujących, które mogą być używane do grupowania zleceń. Zawiera ono również trzy specjalne elementy - zdefiniowane przez użytkownika, funkcja użytkownika i skrypt PESP, które zapewniają możliwość utworzenia bardziej dostosowanych reguł.":
24110 "To pole jest widoczne tylko w wtedy, gdy dla pola 'Typ reguły' określono ustawienie 'Zdefiniowane przez użytkownika' lub 'Funkcja użytkownika'. Wyrażenie, które ma być używane dla reguły, jest wprowadzane w tym polu. Przykład: (~{+:$Product Attribute 1}~==~{-:$Product Attribute 1}~). Takie wyrażenie pozwala łączyć zlecenia zapotrzebowania i dostaw tylko wtedy, gdy pola 'Atrybut produktu 1' mają tę samą wartość.":
24120 "To pole jest widoczne tylko w przypadku, gdy dla pola 'Typ reguły' określone jest ustawienie 'Skrypt PESP'. To pole zawiera nazwę skryptu PESP, która ma być używana jako reguła.":
24130 "Ta opcja umożliwia tworzenie powiązania do pozycji zestawienia materiałów, w przypadku których liczba w pozycji zestawienia materiałów nie musi zostać całkowicie zaspokojona, aby łącze zostało utworzone. Wszystkie elementy, których jest zbyt mało, zostaną wyróżnione jako bark materiałowy.":
24140 "Ta opcja umożliwia tworzenie powiązania tylko do pozycji zestawienia materiałów, w przypadku których liczba w pozycji zestawienia materiałów jest całkowicie zaspokojona. Wszystkie elementy, których jest zbyt mało, zostaną wyróżnione jako brak materiałowy.":
24141 "Po zaznaczeniu tej opcji domyślne zachowanie SMC jest zastępowane poprzez umożliwienie tworzenia powiązania wstecznych, gdy produkcja następuje po zużyciu.":
24150 "Gdy ustawiona jest wartość true, zlecenia, które są już zaplanowane, mogą zostać ponownie połączone.":
24160 "Kiedy dla tego przełącznika ustawiona jest wartość true, pole 'Ranking kolejki dostaw' staje się aktywne, pozwalając na ustalenie rankingu rekordów dostaw zgodnie z kryteriami wyboru w polu 'Ranking kolejki dostaw'. Tę opcję należy wybrać tylko wtedy, gdy wszystkie rekordy są przechowywane w bazie danych 'Zlecenie produkcyjne'.":
24170 "To pole służy do określania kryteriów, które mogą być używane do ograniczania elementów umieszczanych w zewnętrznej kolejce dostaw. Wartość domyślna tego pola jest ustawiona jako ALL, ale można ją zmienić, wprowadzając wyrażenie np. (~{$Order Type}~==~Stock~). Kolejka ta filtruje rekordy znajdujące się w bazie danych 'Zapotrzebowanie'.":
24180 "Zostaną przetworzone wszystkie pola z klasyfikacją INHERIT FROM SUPPLY(nazwa pola).":
24190 "Zostaną przetworzone wszystkie pola z klasyfikacją INHERIT FROM SUPPLY(nazwa pola).":
24200 "Kiedy dla tego przełącznika ustawiona jest wartość true, pole 'Ranking kolejki zapotrzebowania' staje się aktywne, pozwalając na ustalenie rankingu rekordów zapotrzebowania zgodnie z kryteriami wyboru w polu 'Ranking kolejki zapotrzebowania'. Tę opcję należy wybrać tylko wtedy, gdy wszystkie rekordy są przechowywane w bazie danych 'Zlecenie produkcyjne'.":
24210 "Po ustawieniu dla tego przełącznika wartości true, liczba utworzonych łączy będzie przydzielana w określonych wielokrotnościach. Ta wielokrotność jest określona w danych zestawienia materiałów.":
24500 "Jeśli pole przełącznika 'Zawsze używaj tego zestawu reguł' jest zaznaczone, zestawem reguł grupujących wybranym w tym polu będzie zestaw reguł, który jest uruchamiany domyślnie po wybraniu opcji 'Grupuj materiały' w Sekwencerze.":
24505 "Po zaznaczeniu tej opcji globalnej domyślne zachowanie SMC jest zastępowane poprzez umożliwienie tworzenia powiązania wstecznych, gdy produkcja następuje po zużyciu.":
24510 "Zaznaczenie tego przełącznika spowoduje użycie reguły wybranej w polu 'Wybrany zestaw reguł grupujących' jako reguły domyślnej, która zostanie uruchomiona po wybraniu opcji 'Grupuj materiały' w Sekwencerze. Jeśli opcja 'Zawsze używaj tego zestawu reguł' nie jest zaznaczona, po wybraniu opcji 'Grupuj materiały' w Sekwencerze zostanie wyświetlone okno dialogowe wyboru reguły umożliwiające wybór reguły, która ma zostać uruchomiona.":
25400 "To pole służy do przechowywania numeru zlecenia dostawy.":
25410 "To pole określa typ zlecenia, na przykład Zapasy lub Zakup.":
25420 "Nazwa organizacji dostarczającej materiały na potrzeby zlecenia.":
25430 "Numer części, której dotyczy zlecenie.":
25440 "Opis części, której dotyczy zlecenie.":
25450 "Data dostarczenia materiału.":
25500 "To pole jest używane do określenia, do którego zlecenia należy część. Pierwszy wiersz zlecenia będzie rekordem nadrzędnym i będzie dla niego w tym polu wyświetlana wartość PARENT. Pozostałe wiersze zlecenia będą rekordami podrzędnymi i będzie dla nich w tym polu wyświetlany numer zlecenia, do którego należą.":
25510 "To pole służy do przechowywania numeru zlecenia zapotrzebowania.":
25520 "To pole określa typ zlecenia, na przykład Produkcja na magazyn lub Zlecenie sprzedaży.":
25530 "Jednoznacznie identyfikuje element wiersza zlecenia.":
25540 "Nazwa organizacji wymagającej materiałów na potrzeby zlecenia.":
25550 "Data, kiedy materiał jest wymagany.":
25560 "Określa wielokrotność materiału, który musi zostać zgrupowany. Zwykle liczba elementów będzie odpowiadać wielkości pudełka lub skrzynki, np. na 1 pudełko przypada 12 puszek, a zlecenie opiewa na 60 puszek. Istnieje zlecenie dostawy 50 puszek. Kontrola materiałów zgrupuje jedynie 48 puszek z 50, a następnie przeszuka inne zasoby w poszukiwaniu pozostałych 12 wymaganych puszek, ale w przypadku znalezienia dokładnie 12 puszek zostanie jedynie utworzone łącze. Aby ta funkcja była włączona, w bazie danych 'Reguły grupujące' powinno być zaznaczone pole 'Przydzielaj tylko wielokrotności'.":
25600 "Numer zlecenia, do którego należy pozycja zestawienia materiałów.":
25605 "Numer części zlecenia, do którego należy pozycja zestawienia materiałów.":
25610 "Numer operacji, do której należy pozycja zestawienia materiałów.":
25611 "Nazwa operacji, do której należy pozycja zestawienia materiałów.":
25615 "Numer części produktu, który wymaga określonego materiału":
25620 "Numer części pozycji zestawienia materiałów.":
25630 "Wymagana liczba pozycji zestawienia materiałów.":
25640 "Gdy w tym polu ustawiona jest wartość true, liczba w zleceniu zostanie przemnożona przez wymaganą liczbę z zestawienia materiałów.":
25650 "Powoduje, że braki materiałowe są ignorowane podczas uruchamiania reguły grupującej. Pozwala na planowanie zleceń z brakami.":
25700 "Numer zlecenia, w ramach którego wytwarzany jest koprodukt.":
25705 "Numer części zlecenia, w ramach którego wytwarzany jest koprodukt.":
25710 "Numer operacji, w ramach której wytwarzany jest koprodukt.":
25715 "Nazwa operacji, w ramach której wytwarzany jest koprodukt.":
25720 "Nazwa koproduktu.":
25730 "Liczba wytworzonych koproduktów.":
25740 "Gdy w tym polu ustawiona jest wartość true, liczba koproduktów zostanie przemnożona przez liczbę ze zlecenia.":
25800 "To pole określa typ zlecenia, na przykład: Zlecenie produkcyjne, Zlecenie zakupu, Zlecenie sprzedaży lub Zapasy":
25810 "Gdy ta opcja jest zaznaczona, niezaplanowana operacja nie będzie wyświetlana w oknie 'Niezaplanowane operacje'.":
25820 "Wyświetla okno dialogowe, w którym widoczne są pola związane z kontrolą materiału.":
25830 "To pole zawiera informacje dotyczące statusu zapotrzebowania po zgrupowaniu materiałów. Będzie w nim wyświetlana jedna z następujących wartości: 'Nieznane', 'Spełnione', 'Wszystkie braki ignorowane', 'Braki materiałowe', 'Dostarczono zbyt dużo', 'Dostarczono zbyt dużo, niedobory', ''Dostarczono zbyt dużo, wszystkie braki ignorowane'.":
25840 "To pole jest wypełniane po zgrupowaniu materiałów. Po utworzeniu powiązania do zlecenia dostawy w bazie danych 'Zlecenia dostawy', pole 'Data zapotrzebowania' w bazie danych 'Zlecenie produkcyjne' jest wypełniane przy użyciu 'Daty dostawy' ze zlecenia dostawy. Pole 'Data dostawy' zostanie oszacowane na podstawie pola 'Najwcześniejsza data rozpoczęcia', aby użyć późniejszej z tych dwóch dat w celu określenia, która data ma być używana podczas tworzenia harmonogramu.":
25850 "To pole jest wypełniane po zgrupowaniu materiałów. Po utworzeniu powiązania do zlecenia zapotrzebowania w bazie danych 'Zlecenia zapotrzebowania', pole 'Data dostawy' w bazie danych 'Zlecenie produkcyjne' jest wypełniane przy użyciu 'Daty zapotrzebowania' ze zlecenia zapotrzebowania. Wartość w polu 'Data zapotrzebowania' zostanie oszacowana na podstawie pola 'Data wykonania', aby użyć najwcześniejszej spośród tych dwóch dat w celu określenia, która data ma być używana podczas tworzenia harmonogramu.":
25900 "Wyświetla okno dialogowe zawierające pola powiązane ze statusem operacji.":
25910 "Tę opcję można wybrać, gdy zlecenie jest dzielone. Ta opcja umożliwia każdej partii produkcyjnej niezależne przejście przez proces wytwarzania, np. aby rozpocząć kolejną operację, nie jest wymagane ukończenie wszystkich partii w jednej operacji.":
25920 "To pole określa kolor używany na pasku na wykresie Gantta dla tego rekordu.":
26000 "To pole definiuje nazwę grupy przezbrojeń":
26100 "To pole służy do ustawiania czasu przezbrojenie, który jest stosowany, gdy atrybut określił zmiany między operacjami zaplanowanymi obok siebie.":
26200 "Nazwa wyświetlana narzędzia użytkownika":
26210 "Skrypt zdarzenia, które zostanie uruchomione po wybraniu narzędzia użytkownika":
26220 "Nazwa menu narzędzia w oknie użytkownika":
26230 "Funkcja kodu służąca do wypełniania zawartości okna użytkownika":
26240 "Etykieta okna użytkownika":
26300 "Nazwa przycisku menu. Wskazuje miejsce wyświetlania przycisku w systemie menu":
26310 "To pole określa, czy przycisk jest włączony i czy w związku z tym jest wyświetlany":
26320 "To pole określa tekst, który będzie wyświetlany na przycisku":
26330 "Skrypt zdarzenia, który zostanie uruchomiony po wybraniu przycisku":
;
