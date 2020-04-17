using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registered : ContentPage
    {
        public Registered()
        {
            InitializeComponent();
            NavigationPage.SetTitleIconImageSource(this, "icon.png");
        }

        public int aaa()
        {
            var monkeyList = new List<string>();
            monkeyList.Add("Baboon");
            monkeyList.Add("Capuchin Monkey");
            monkeyList.Add("Blue Monkey");
            monkeyList.Add("Squirrel Monkey");
            monkeyList.Add("Golden Lion Tamarin");
            monkeyList.Add("Howler Monkey");
            monkeyList.Add("Japanese Macaque");

            var picker = new Picker { Title = "Select a monkey", TitleColor = Color.Red };
            picker.ItemsSource = monkeyList;

            
            return 1;
        }

        private async void btProfile(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile());
        }

        private async void btSettings(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }

        private async void btAbout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUs());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new Confirm());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new AddCard());
        }
    }
}