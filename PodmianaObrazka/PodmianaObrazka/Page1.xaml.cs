using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PodmianaObrazka
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        //Gra polegająca na podmianie obrazków z numerami i ułożeniu ich w odpowiedniej kolejności
        //Plansza 3x3, obrazki z internetu
        String[] zrodlaObrazkow = new String[9];
        ImageButton[] nazwyButtonow = new ImageButton[9];
        int[] licz = new int[9];
        int a = 0;
        int b = 0;
        bool pierwszy = true;
        public Page1()
        {
            InitializeComponent();
            nazwyButtonow[0] = przycisk1;
            nazwyButtonow[1] = przycisk2;
            nazwyButtonow[2] = przycisk3;
            nazwyButtonow[3] = przycisk4;
            nazwyButtonow[4] = przycisk5;
            nazwyButtonow[5] = przycisk6;
            nazwyButtonow[6] = przycisk7;
            nazwyButtonow[7] = przycisk8;
            nazwyButtonow[8] = przycisk9;

            zrodlaObrazkow[0] = "http://www.clker.com/cliparts/V/1/Y/3/j/Z/blue-number-1-md.png";
            zrodlaObrazkow[1] = "http://www.clker.com/cliparts/h/Y/i/C/Y/W/red-rounded-square-with-number-2-md.png";
            zrodlaObrazkow[2] = "https://i5.walmartimages.com/asr/e96b4f28-9290-4df3-a0ee-c13083fdd166_1.e5f3f16ea4ecb41b31a4a3bdaa32212a.jpeg?odnBg=ffffff";
            zrodlaObrazkow[3] = "http://www.clker.com/cliparts/3/1/b/4/12427969621529811764Number_4_in_red_rounded_square.svg.med.png";
            zrodlaObrazkow[4] = "http://www.clker.com/cliparts/y/m/n/0/x/0/red-rounded-square-with-number-5-md.png";
            zrodlaObrazkow[5] = "http://www.clker.com/cliparts/L/1/l/h/y/X/red-rounded-square-with-number-6-md.png";
            zrodlaObrazkow[6] = "http://www.clker.com/cliparts/M/t/L/7/R/P/red-rounded-square-with-number-6-md.png";
            zrodlaObrazkow[7] = "https://www.heortieg.com/ekmps/shops/classicbike86/images/race-number-8.-140970-p.jpg";
            zrodlaObrazkow[8] = "https://i5.walmartimages.com/asr/2b03b0ca-890b-42c5-9424-b2dd4fcf0a4d_1.fff26531b92904539815b716aabe14bf.jpeg?odnBg=ffffff";

            Wymieszaj();
        }
        private void Wymieszaj()
        {
            Random rnd = new Random();

            for (int i = 0; i < 9; i++)
            {
                licz[i] = -1;
            }
            int tpsRnd = rnd.Next(0, 9);

            int licznik = 0;
            bool status = true;
            for (int i = 0; i < 9; i++)
            {

                if (status == true)
                {
                    if (tpsRnd == licz[i])
                    {
                        tpsRnd = rnd.Next(0, 9);
                        i = -1;
                    }
                    else if (tpsRnd != licz[i] && licz[i] == -1)
                    {
                        licz[i] = tpsRnd;
                        tpsRnd = rnd.Next(0, 9);

                        i = -1;
                        licznik++;
                        if (licznik == 9)
                        {
                            status = false;
                        }
                    }
                }
            }

            for (int i = 0; i < 9; i++)
            {
                nazwyButtonow[i].Source = zrodlaObrazkow[licz[i]];
            }
        }
        private async void Sprawdz()
        {
            int dobrzeUlozone=0;
            for (int i = 0; i < 9; i++)
            {
                if (licz[i] == i)
                {
                    dobrzeUlozone++;
                }
                else
                {
                    dobrzeUlozone = 0;
                    i = 10;
                }
                if (dobrzeUlozone ==9)
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
                for (int i = 0; i < 9; i++)
                {
                    if (pobranyPrzycisk == nazwyButtonow[i])
                    {
                        a = i;
                    }
                }
                pierwszy = false;
            }
            else if (pierwszy == false)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (pobranyPrzycisk == nazwyButtonow[i])
                    {
                        b = i;
                    }
                }
                nazwyButtonow[a].Source = zrodlaObrazkow[licz[b]];
                nazwyButtonow[b].Source = zrodlaObrazkow[licz[a]];
                int c = licz[a];
                licz[a] = licz[b];
                licz[b] = c;
                pierwszy = true;
                b = -1;
                a = -1;
                Sprawdz();
            }
        }
    }
}