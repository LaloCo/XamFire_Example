using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Example.Model;

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

        public ObservableCollection<Contact> Contacts { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            Contacts.Add(new Contact
            {
                Name = "Eduardo",
                Email = "example@gmail.com"
            });
            Contacts.Add(new Contact
            {
                Name = "Jane",
                Email = "janedoe@gmail.com"
            });
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
