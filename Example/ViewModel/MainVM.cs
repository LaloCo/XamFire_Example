using System;
using System.ComponentModel;

namespace Example.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                OnPropertyChanged("Username");
                OnPropertyChanged("Greeting");
            }
        }

        public string Greeting
        {
            get
            {
                return $"Hello {Username}!";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainVM()
        {
            
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
