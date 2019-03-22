using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PodmianaObrazka
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        //Gra polegająca na podmianie obrazków i ułożeniu ich w odpowiedniej kolejności
        //Mozliwosc tylko przesuwania pustego obrazka z innym obrazkiem znajdującym się obok
        //Plansza 4x4 obrazki Osadzone
        string[] zrodlaObrazkow = new string[16];  //tablica z zrodlami obrazków
        ImageButton[] nazwyButton = new ImageButton[16]; //tablica z przepisanymi nazwami button'ow
        int[] licz = new int[16]; // tablica, ktora wykorzystujemy do losowania bez zwracania kolejnosci obrazkow na poczatku gry
        int a = 0;
        int b = 0;
        bool pierwszy = true; //sprawdza czy gracz wybral 1 czy 2 obrazki
        int iloscRuchow = 0;
        PropertyInfo[] tablicaAtrybutow;
        Page2ViewModel daneDlaWidoku = new Page2ViewModel(); 
        public Page3()
        {
            BindingContext = daneDlaWidoku;
            InitializeComponent();
            //przypisanie przycisków do tablicy
            nazwyButton[0] = przycisk1;
            nazwyButton[1] = przycisk2;
            nazwyButton[2] = przycisk3;
            nazwyButton[3] = przycisk4;
            nazwyButton[4] = przycisk5;
            nazwyButton[5] = przycisk6;
            nazwyButton[6] = przycisk7;
            nazwyButton[7] = przycisk8;
            nazwyButton[8] = przycisk9;
            nazwyButton[9] = przycisk10;
            nazwyButton[10] = przycisk11;
            nazwyButton[11] = przycisk12;
            nazwyButton[12] = przycisk13;
            nazwyButton[13] = przycisk14;
            nazwyButton[14] = przycisk15;
            nazwyButton[15] = przycisk16;
            //przypisanie zrodla obrazkow
            zrodlaObrazkow[0] = "PodmianaObrazka.Obrazki.o1.png";
            zrodlaObrazkow[1] = "PodmianaObrazka.Obrazki.o2.png";
            zrodlaObrazkow[2] = "PodmianaObrazka.Obrazki.o3.png";
            zrodlaObrazkow[3] = "PodmianaObrazka.Obrazki.o4.png";
            zrodlaObrazkow[4] = "PodmianaObrazka.Obrazki.o5.png";
            zrodlaObrazkow[5] = "PodmianaObrazka.Obrazki.o6.png";
            zrodlaObrazkow[6] = "PodmianaObrazka.Obrazki.o7.png";
            zrodlaObrazkow[7] = "PodmianaObrazka.Obrazki.o8.png";
            zrodlaObrazkow[8] = "PodmianaObrazka.Obrazki.o9.png";
            zrodlaObrazkow[9] = "PodmianaObrazka.Obrazki.o10.png";
            zrodlaObrazkow[10] = "PodmianaObrazka.Obrazki.o11.png";
            zrodlaObrazkow[11] = "PodmianaObrazka.Obrazki.o12.png";
            zrodlaObrazkow[12] = "PodmianaObrazka.Obrazki.o13.png";
            zrodlaObrazkow[13] = "PodmianaObrazka.Obrazki.o14.png";
            zrodlaObrazkow[14] = "PodmianaObrazka.Obrazki.o15.png";
            zrodlaObrazkow[15] = "PodmianaObrazka.Obrazki.oWhite.png";
            //przypisanie atrybutow
            tablicaAtrybutow = Type.GetType("PodmianaObrazka.Page2ViewModel").GetProperties();
            
            Wymieszaj();
        }
        //metoda odpowiedzialna ze generowanie tablicy bez powtorzen
        //losowe ustawienie obrazków na początku gry
        private void Wymieszaj()
        {
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                licz[i] = -1;
            }
            int tpsRnd = rnd.Next(0, 15);

            int licznik = 0;
            bool status = true;
            for (int i = 0; i < 15; i++)
            {

                if (status == true)
                {
                    if (tpsRnd == licz[i])
                    {
                        tpsRnd = rnd.Next(0, 15);
                        i = -1;
                    }
                    else if (tpsRnd != licz[i] && licz[i] == -1)
                    {
                        licz[i] = tpsRnd;
                        tpsRnd = rnd.Next(0, 15);

                        i = -1;
                        licznik++;
                        if (licznik == 15)
                        {
                            status = false;
                        }
                    }
                }
            }
            licz[15] = 15;



            for (int i = 0; i < 15; i++)
            {

                tablicaAtrybutow[i].SetValue(daneDlaWidoku, ImageSource.FromResource(zrodlaObrazkow[licz[i]], typeof(Page2).GetTypeInfo().Assembly));
            }
        }
        //sprawdzenie czy ułożyliśmy wszystkie obrazki dobrze
        private async void Sprawdz()
        {
            int dobrzeUlozone = 0;
            for (int i = 0; i < 16; i++)
            {
                if (licz[i] == i)
                {
                    dobrzeUlozone++;
                }
                else
                {
                    dobrzeUlozone = 0;
                    i = 17;
                }
                if (dobrzeUlozone == 16)
                {
                    tablicaAtrybutow[15].SetValue(daneDlaWidoku, ImageSource.FromResource("PodmianaObrazka.Obrazki.o16.png", typeof(Page2).GetTypeInfo().Assembly));
                    var akcja = await DisplayActionSheet("Wygraleś", "Cancel", null, "Zagraj jezscze raz", "Wróć do gry", "Wyjdz");
                    switch (akcja)
                    {
                        case "Zagraj jezscze raz":

                            Wymieszaj();

                            break;
                        case "Wyjdz":

                            Environment.Exit(0);

                            break;
                    }
                }

            }

        }
        //sprawdza czy wybrane dwa obrazki są obok siebie i czy jeden jest białym obrazkiem zwraca True jesli tak
        private bool CzyMoznaTakiRuch(int a, int b)
        {
            if (b == 0 && (nazwyButton[a] == nazwyButton[1] || nazwyButton[a] == nazwyButton[4]))
            {
                return true;
            }
            else if (b == 0 && (nazwyButton[a] != nazwyButton[1] && nazwyButton[a] != nazwyButton[4]))
            {
                return false;
            }
            else if (b == 15 && (nazwyButton[a] == nazwyButton[11] || nazwyButton[a] == nazwyButton[14]))
            {
                return true;
            }
            else if(b == 15 && (nazwyButton[a] != nazwyButton[11] && nazwyButton[a] != nazwyButton[14]))
            {
                return false;
            }
            else if ((nazwyButton[a] == nazwyButton[b + 1] &&  !(a%4==0))|| (nazwyButton[a] == nazwyButton[b - 1] && !(b%4==0)) || (a == b+4 || a == b-4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //metoda która wykonuje się przy wciśnieciu przycisku
        private void Przycisk1_Clicked(object sender, EventArgs e)
        {
            ImageButton pobranyPrzycisk = sender as ImageButton;
            
            if (pierwszy == true) //kiedy wcisniemy pierwszy przycisk
            {
                for (int i = 0; i < 16; i++)
                {
                    if (pobranyPrzycisk.Source == nazwyButton[i].Source)
                    {
                        pobranyPrzycisk.BorderColor = Color.Red;
                        a = i;
                    }
                }
                pierwszy = false;
            }
            else if (pierwszy == false) //kiedy wcisniemy drugi
            {
                nazwyButton[a].BorderColor = Color.White;
                for (int i = 0; i < 16; i++)
                {
                    if (pobranyPrzycisk.Source == nazwyButton[i].Source)
                    {
                        b = i;
                    }
                }

                if ((licz[a] == 15 || licz[b] == 15) && CzyMoznaTakiRuch(a,b) == true)
                {
                    //podmienianie obrazkow
                    tablicaAtrybutow[a].SetValue(daneDlaWidoku, ImageSource.FromResource(zrodlaObrazkow[licz[b]], typeof(Page2).GetTypeInfo().Assembly));
                    tablicaAtrybutow[b].SetValue(daneDlaWidoku, ImageSource.FromResource(zrodlaObrazkow[licz[a]], typeof(Page2).GetTypeInfo().Assembly));                   
                    //zamienianie pozycji w tablicy, ktora jest sprawdzana w metodzie Sprawdz()
                    int c = licz[a];                    
                    licz[a] = licz[b];
                    licz[b] = c;

                    Sprawdz();
                    iloscRuchow++;
                    iloscruchow.Text = iloscRuchow.ToString();
                }
                pierwszy = true;
            }
        }
    }
}