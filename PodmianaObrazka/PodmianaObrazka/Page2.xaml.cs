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
    public class Page2ViewModel : INotifyPropertyChanged
    {
        private ImageSource _myProperty1;
        public ImageSource MyProperty1
        {
            get { return _myProperty1; }
            set
            {
                _myProperty1 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty1"));
            }
        }
        private ImageSource _myProperty2;
        public ImageSource MyProperty2
        {
            get { return _myProperty2; }
            set
            {
                _myProperty2 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty2"));
            }
        }
        private ImageSource _myProperty3;
        public ImageSource MyProperty3
        {
            get { return _myProperty3; }
            set
            {
                _myProperty3 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty3"));
            }
        }
        private ImageSource _myProperty4;
        public ImageSource MyProperty4
        {
            get { return _myProperty4; }
            set
            {
                _myProperty4 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty4"));
            }
        }
        private ImageSource _myProperty5;
        public ImageSource MyProperty5
        {
            get { return _myProperty5; }
            set
            {
                _myProperty5 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty5"));
            }
        }
        private ImageSource _myProperty6;
        public ImageSource MyProperty6
        {
            get { return _myProperty6; }
            set
            {
                _myProperty6 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty6"));
            }
        }
        private ImageSource _myProperty7;
        public ImageSource MyProperty7
        {
            get { return _myProperty7; }
            set
            {
                _myProperty7 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty7"));
            }
        }
        private ImageSource _myProperty8;
        public ImageSource MyProperty8
        {
            get { return _myProperty8; }
            set
            {
                _myProperty8 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty8"));
            }
        }
        private ImageSource _myProperty9;
        public ImageSource MyProperty9
        {
            get { return _myProperty9; }
            set
            {
                _myProperty9 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty9"));
            }
        }
        private ImageSource _myProperty10;
        public ImageSource MyProperty10
        {
            get { return _myProperty10; }
            set
            {
                _myProperty10 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty10"));
            }
        }
        private ImageSource _myProperty11;
        public ImageSource MyProperty11
        {
            get { return _myProperty11; }
            set
            {
                _myProperty11 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty11"));
            }
        }
        private ImageSource _myProperty12;
        public ImageSource MyProperty12
        {
            get { return _myProperty12; }
            set
            {
                _myProperty12 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty12"));
            }
        }
        private ImageSource _myProperty13;
        public ImageSource MyProperty13
        {
            get { return _myProperty13; }
            set
            {
                _myProperty13 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty13"));
            }
        }
        private ImageSource _myProperty14;
        public ImageSource MyProperty14
        {
            get { return _myProperty14; }
            set
            {
                _myProperty14 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty14"));
            }
        }
        private ImageSource _myProperty15;
        public ImageSource MyProperty15
        {
            get { return _myProperty15; }
            set
            {
                _myProperty15 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty15"));
            }
        }
        private ImageSource _myProperty16;
        public ImageSource MyProperty16
        {
            get { return _myProperty16; }
            set
            {
                _myProperty16 = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MyProperty16"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
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
        //ImageResourceExtension odswiezObrazki = new ImageResourceExtension();
        Page2ViewModel viewModel = new Page2ViewModel();
        public Page2()
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
            viewModel.MyProperty16 = ImageSource.FromResource("PodmianaObrazka.Obrazki.o16.png", typeof(Page2).GetTypeInfo().Assembly);

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
            zrodla[15] = "PodmianaObrazka.Obrazki.o16.png";
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
            PropertyInfo[] myPropertyInfo;

            myPropertyInfo = Type.GetType("PodmianaObrazka.Page2ViewModel").GetProperties();
            object value = myPropertyInfo[a].GetValue(viewModel, null);
            

            for (int i = 0; i < 16; i++)
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

                PropertyInfo[] myPropertyInfo;

                myPropertyInfo = Type.GetType("PodmianaObrazka.Page2ViewModel").GetProperties();
                object value = myPropertyInfo[a].GetValue(viewModel, null);
                myPropertyInfo[a].SetValue(viewModel, ImageSource.FromResource(zrodla[licz[b]], typeof(Page2).GetTypeInfo().Assembly));
                myPropertyInfo[b].SetValue(viewModel, ImageSource.FromResource(zrodla[licz[a]], typeof(Page2).GetTypeInfo().Assembly));
                int c = licz[a];
                licz[a] = licz[b];
                licz[b] = c;

                pierwszy = true;
                Sprawdz();
            }
        }
    }
}