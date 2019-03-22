## Gra, w ktorej podmieniamy obrazki

#Gra na planszy 3x3
- Obrazki wczytane z internetu
- Pelna dowolnosc podmiany 
- Obrazki to liczby od 1-9

#Gra na planszy 4x4
- Obrazki osadzone w aplikacji
- Pelna dowolnosc podmiany 
- 1 obrazek w 16 fragmentach

#Gra na planszy 4x4
- Obrazki osadzone w aplikacji
- 1 obrazek w 16 fragmentach
- 1 bialy obrazek, ktory przesuwamy, aby ulozyc caly obrazek

Gra zawiera
- algorytm do losowania bez zwracania
- metode, ktora po wcisnieciu dwoch obrazkow podmienia je
- metode do sprawdzania czy wszystkie obrazki sa dobrze ulozone i wyswietleniu komunikatu metoda DisplayAlertSheet
- klase Page2ViewModel dziedzicz¹c¹ po interfejsie INotifyPropertyChanged i odswiezajaca osadzone obrazki
