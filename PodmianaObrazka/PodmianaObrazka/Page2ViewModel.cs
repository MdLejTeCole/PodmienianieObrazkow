using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

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
}
