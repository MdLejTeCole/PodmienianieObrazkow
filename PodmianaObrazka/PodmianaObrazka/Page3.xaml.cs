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
        string[] zrodla = new string[16];
        ImageButton[] nazwy = new ImageButton[16];
        int[] licz = new int[16];
        int a = 0;
        int b = 0;
        bool pierwszy = true;
        int iloscRuchow = 0;
        PropertyInfo[] myPropertyInfo;
        Page2ViewModel viewModel = new Page2ViewModel();
        public Page3()
        {
            BindingContext = viewModel;
            InitializeComponent();

            viewModel.MyProperty1 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o1.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty2 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o2.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty3 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o3.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty4 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o4.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty5 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o5.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty6 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o6.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty7 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o7.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty8 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o8.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty9 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o9.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty10 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o10.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty11 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o11.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty12 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o12.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty13 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o13.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty14 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o14.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty15 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o15.png", typeof(Page2).GetTypeInfo().Assembly);
            viewModel.MyProperty16 = ImageSource.FromResource("PodmianaObrazka.Obrazki.oWhite.png", typeof(Page2).GetTypeInfo().Assembly);

            nazwy[0] = przycisk1;
            nazwy[1] = przycisk2;
            nazwy[2] = przycisk3;
            nazwy[3] = przycisk4;
            nazwy[4] = przycisk5;
            nazwy[5] = przycisk6;
            nazwy[6] = przycisk7;
            nazwy[7] = przycisk8;
            nazwy[8] = przycisk9;
            nazwy[9] = przycisk10;
            nazwy[10] = przycisk11;
            nazwy[11] = przycisk12;
            nazwy[12] = przycisk13;
            nazwy[13] = przycisk14;
            nazwy[14] = przycisk15;
            nazwy[15] = przycisk16;

            zrodla[0] = "PodmianaObrazka.Obrazki.o1.png";
            zrodla[1] = "PodmianaObrazka.Obrazki.o2.png";
            zrodla[2] = "PodmianaObrazka.Obrazki.o3.png";
            zrodla[3] = "PodmianaObrazka.Obrazki.o4.png";
            zrodla[4] = "PodmianaObrazka.Obrazki.o5.png";
            zrodla[5] = "PodmianaObrazka.Obrazki.o6.png";
            zrodla[6] = "PodmianaObrazka.Obrazki.o7.png";
            zrodla[7] = "PodmianaObrazka.Obrazki.o8.png";
            zrodla[8] = "PodmianaObrazka.Obrazki.o9.png";
            zrodla[9] = "PodmianaObrazka.Obrazki.o10.png";
            zrodla[10] = "PodmianaObrazka.Obrazki.o11.png";
            zrodla[11] = "PodmianaObrazka.Obrazki.o12.png";
            zrodla[12] = "PodmianaObrazka.Obrazki.o13.png";
            zrodla[13] = "PodmianaObrazka.Obrazki.o14.png";
            zrodla[14] = "PodmianaObrazka.Obrazki.o15.png";
            zrodla[15] = "PodmianaObrazka.Obrazki.oWhite.png";
            myPropertyInfo = Type.GetType("PodmianaObrazka.Page2ViewModel").GetProperties();
            object value = myPropertyInfo[a].GetValue(viewModel, null);
            Wymieszaj();
        }
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

                myPropertyInfo[i].SetValue(viewModel, ImageSource.FromResource(zrodla[licz[i]], typeof(Page2).GetTypeInfo().Assembly));
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
                    myPropertyInfo[15].SetValue(viewModel, ImageSource.FromResource("PodmianaObrazka.Obrazki.o16.png", typeof(Page2).GetTypeInfo().Assembly));
                    var action = await DisplayActionSheet("Wygraleś", "Cancel", null, "Zagraj jezscze raz", "Wróć do gry", "Wyjdz");
                    switch (action)
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
        private bool CzyMoznaTakiRuch(int a, int b)
        {
            if (b == 0 && (nazwy[a] == nazwy[1] || nazwy[a] == nazwy[4]))
            {
                return true;
            }
            else if (b == 0 && (nazwy[a] != nazwy[1] && nazwy[a] != nazwy[4]))
            {
                return false;
            }
            else if (b == 15 && (nazwy[a] == nazwy[11] || nazwy[a] == nazwy[14]))
            {
                return true;
            }
            else if(b == 15 && (nazwy[a] != nazwy[11] && nazwy[a] != nazwy[14]))
            {
                return false;
            }
            else if ((nazwy[a] == nazwy[b + 1] &&  !(a%4==0))|| (nazwy[a] == nazwy[b - 1] && !(b%4==0)) || (a == b+4 || a == b-4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Przycisk1_Clicked(object sender, EventArgs e)
        {
            ImageButton p = sender as ImageButton;
            
            if (pierwszy == true)
            {
                for (int i = 0; i < 16; i++)
                {
                    if (p.Source == nazwy[i].Source)
                    {
                        p.BorderColor = Color.Red;
                        a = i;
                    }
                }
                pierwszy = false;
            }
            else if (pierwszy == false)
            {
                nazwy[a].BorderColor = Color.White;
                for (int i = 0; i < 16; i++)
                {
                    if (p.Source == nazwy[i].Source)
                    {
                        b = i;
                    }
                }

                if ((licz[a] == 15 || licz[b] == 15) && CzyMoznaTakiRuch(a,b) == true)
                {
                    myPropertyInfo[a].SetValue(viewModel, ImageSource.FromResource(zrodla[licz[b]], typeof(Page2).GetTypeInfo().Assembly));
                    myPropertyInfo[b].SetValue(viewModel, ImageSource.FromResource(zrodla[licz[a]], typeof(Page2).GetTypeInfo().Assembly));                   

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