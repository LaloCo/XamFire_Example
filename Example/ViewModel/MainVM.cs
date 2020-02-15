using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Example.Model;
using Xamarin.Forms;

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

        public ICommand ClearCommand { get; set; }

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

            ClearCommand = new Command(ClearUsername, ClearCanExecute);
        }

        private bool ClearCanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(Username);
        }

        private void ClearUsername(object parameter)
        {
            Username = string.Empty;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
