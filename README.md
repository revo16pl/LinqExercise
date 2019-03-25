# LinqExercise

# Zdefiniuj klasy Klient oraz Zamowienie.

Klasa Klient, oprócz id klienta, jego nazwy, ... i.t.p. , posiada między innymi właściwość Zamowienia, która zawiera listę obiektów typu Zamowienie.

Klasa Zamowienie posiada miedzy innymi właściwość DataZamowienia typu DateTime, która zawiera datę zamówienia oraz właściwość Razem typu decimal zawierającą kwotę na która opiewa zamówienie.

Dysponujesz również listą klientów (List<Klient> klienci).

Przyjmij, że wszystkie składniki wymienionych klas są publiczne, do odczytu i zapisu.

## Polecenie 1
Napisz kwerendę LINQ (wykorzystując operatory LINQ) zwracającą listę wszystkich klientów, którzy złożyli przynajmniej jedno zamówienie w roku 2018.

## Polecenie 2
Utwórz klasy Klient oraz Zamowienie w minimalnym zakresie - tylko takim, aby zademonstrować poprawność Twoich kwerend z poprzednich poleceń.

Utwórz stosowne obiekty, zainicjuj je odpowiednimi przykładowymi danymi - ale takimi i tylko w takiej liczbie, aby zademonstrować poprawność działania Twoich kwerend.

W metodzie Main programu głównego umieść kod uruchamiający opracowane kwerendy i wypisujący wyniki ich działania na konsoli. Pokaż, że Twoje kwerendy działają poprawnie w każdej sytuacji.

## Polecenie 3
Poniższy przykładowy napis "00:45,01:32,02:18,03:01,03:44,04:31,05:19,06:01,06:47,07:35" reprezentuje sekwencję zarejestrowanych wyników biegacza wykonującego kolejne okrążenia (minuta:sekunda), oddzielonych przecinkami.

Napisz kwerendę LINQ zwracającą liczbę okrążeń zaliczonych przez biegacza.
