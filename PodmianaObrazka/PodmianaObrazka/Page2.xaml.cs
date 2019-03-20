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
    public class Page2ViewModel
    {
        public ImageSource MyProperty1 { get; set; }
        public ImageSource MyProperty2 { get; set; }
        public ImageSource MyProperty3 { get; set; }
        public ImageSource MyProperty4 { get; set; }
        public ImageSource MyProperty5 { get; set; }
        public ImageSource MyProperty6 { get; set; }

        
    }
    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider) 
        {
            if (Source == null)
            {
                return null;
            }

            // Do your translation lookup here, using whatever method you require
            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);

            return imageSource;
        }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
        String[] zrodla = new String[16];
        ImageButton[] nazwy = new ImageButton[16];
        int[] licz = new int[16];
        int a = 0;
        int b = 0;
        bool pierwszy = true;
        ImageResourceExtension odswiezObrazki = new ImageResourceExtension();
        Page2ViewModel viewModel = new Page2ViewModel();
        public Page2()
        {
            BindingContext = viewModel;
            InitializeComponent();

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
           viewModel.MyProperty1 = ImageSource.FromResource("{local:ImageResource PodmianaObrazka.Obrazki.o3.png}", typeof(Page2).GetTypeInfo().Assembly);
            //viewModel.MyProperty1 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o1.png");
            //viewModel.MyProperty1 = "PodmianaObrazka.Obrazki.o1.png";
            viewModel.MyProperty2 = "{PodmianaObrazka.Obrazki.o2.png}";
            viewModel.MyProperty3 = "{local:ImageResource PodmianaObrazka.Obrazki.o3.png}";
            viewModel.MyProperty4 = "{local:ImageResource PodmianaObrazka.Obrazki.o4.png}";
            viewModel.MyProperty5 = "{local:ImageResource PodmianaObrazka.Obrazki.o5.png}";
            viewModel.MyProperty6 = "{local:ImageResource PodmianaObrazka.Obrazki.o6.png}";
            var test = przycisk10.Source; 
            zrodla[6] = "{local:ImageResource PodmianaObrazka.Obrazki.o7.png}";
            zrodla[7] = "{local:ImageResource PodmianaObrazka.Obrazki.o8.png}";
            zrodla[8] = "{local:ImageResource PodmianaObrazka.Obrazki.o9.png}";
            zrodla[9] = "{local:ImageResource PodmianaObrazka.Obrazki.o10.png}";
            zrodla[10] = "{local:ImageResource PodmianaObrazka.Obrazki.o11.png}";
            zrodla[11] = "{local:ImageResource PodmianaObrazka.Obrazki.o12.png}";
            zrodla[12] = "{local:ImageResource PodmianaObrazka.Obrazki.o13.png}";
            zrodla[13] = "{local:ImageResource PodmianaObrazka.Obrazki.o14.png}";
            zrodla[14] = "{local:ImageResource PodmianaObrazka.Obrazki.o15.png}";
            zrodla[15] = "{local:ImageResource PodmianaObrazka.Obrazki.o16.png}";
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

            for (int i = 0; i < 16; i++)
            {
                //nazwy[i].Source = zrodla[licz[i]];
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
        private void Przycisk1_Clicked(object sender, EventArgs e)
        {
            ImageButton p = sender as ImageButton;
            
            if (pierwszy == true)
            {
                for (int i = 0; i < 16; i++)
                {
                    if (p.Source == nazwy[i].Source)
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
                    if (p.Source == nazwy[i].Source)
                    {
                        b = i;
                    }
                }
                nazwy[a].Source = zrodla[licz[b]];
                nazwy[b].Source = zrodla[licz[a]];
                viewModel.MyProperty1 = zrodla[licz[b]];
                viewModel.MyProperty2 = zrodla[licz[a]];
                int c = licz[a];
                licz[a] = licz[b];
                licz[b] = c;

                pierwszy = true;
                Sprawdz();
            }
        }
    }
}