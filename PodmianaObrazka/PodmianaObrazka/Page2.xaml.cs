using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PodmianaObrazka

{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        //Gra polegająca na podmianie obrazków i ułożeniu ich w odpowiedniej kolejności
        //Plansza 4x4 obrazki Osadzone
        string[] zrodlaObrazkow = new string[16];
        ImageButton[] nazwyButton = new ImageButton[16];
        int[] licz = new int[16];
        int a = 0;
        int b = 0;
        bool pierwszy = true;
        PropertyInfo[] tablicaAtrybutow;
        Page2ViewModel daneDlaWidoku = new Page2ViewModel();
        public Page2()
        {
            BindingContext = daneDlaWidoku;
            InitializeComponent();

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
            zrodlaObrazkow[15] = "PodmianaObrazka.Obrazki.o16.png";
            Wymieszaj();
        }
        private void Wymieszaj()
        {
            Random rnd = new Random();

            for (int i = 0; i < 16; i++)
            {
                licz[i] = -1;
            }
            int tpsRnd = rnd.Next(0, 16);

            int licznik = 0;
            bool status = true;
            for (int i = 0; i < 16; i++)
            {

                if (status == true)
                {
                    if (tpsRnd == licz[i])
                    {
                        tpsRnd = rnd.Next(0, 16);
                        i = -1;
                    }
                    else if (tpsRnd != licz[i] && licz[i] == -1)
                    {
                        licz[i] = tpsRnd;
                        tpsRnd = rnd.Next(0, 16);

                        i = -1;
                        licznik++;
                        if (licznik == 16)
                        {
                            status = false;
                        }
                    }
                }
            }
            

            tablicaAtrybutow = Type.GetType("PodmianaObrazka.Page2ViewModel").GetProperties();
            object wartosc = tablicaAtrybutow[a].GetValue(daneDlaWidoku, null);
            

            for (int i = 0; i < 16; i++)
            {
                
                tablicaAtrybutow[i].SetValue(daneDlaWidoku, ImageSource.FromResource(zrodlaObrazkow[licz[i]], typeof(Page2).GetTypeInfo().Assembly));
            }
        }
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
        private void Przycisk1_Clicked(object sender, EventArgs e)
        {
            ImageButton pobranyPrzycisk = sender as ImageButton;

            if (pierwszy == true)
            {
                for (int i = 0; i < 16; i++)
                {
                    if (pobranyPrzycisk.Source == nazwyButton[i].Source)
                    {
                        a = i;
                    }
                }
                pierwszy = false;
            }
            else if (pierwszy == false)
            {
                for (int i = 0; i < 16; i++)
                {
                    if (pobranyPrzycisk.Source == nazwyButton[i].Source)
                    {
                        b = i;
                    }
                }
               
                tablicaAtrybutow = Type.GetType("PodmianaObrazka.Page2ViewModel").GetProperties();
                object value = tablicaAtrybutow[a].GetValue(daneDlaWidoku, null);
                tablicaAtrybutow[a].SetValue(daneDlaWidoku, ImageSource.FromResource(zrodlaObrazkow[licz[b]], typeof(Page2).GetTypeInfo().Assembly));
                tablicaAtrybutow[b].SetValue(daneDlaWidoku, ImageSource.FromResource(zrodlaObrazkow[licz[a]], typeof(Page2).GetTypeInfo().Assembly));
                int c = licz[a];
                licz[a] = licz[b];
                licz[b] = c;

                pierwszy = true;
                Sprawdz();
            }
        }
    }
}