using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Example
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public class Contact
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var list = new List<Contact>();
            list.Add(new Contact
            {
                Name = "Eduardo",
                Email = "example@gmail.com"
            });
            list.Add(new Contact
            {
                Name = "Jane",
                Email = "janedoe@gmail.com"
            });

            exampleListView.ItemsSource = list;
        }

        void SayHelloButton_Clicked(object sender, EventArgs eventArgs)
        {
            string userName = nameEntry.Text;
            greetingLabel.Text = $"Hello {userName}!";
        }
    }
}
