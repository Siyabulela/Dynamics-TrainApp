using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;

namespace TrainApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //MainPicker.Items.Add("TRAIN");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopupView());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopupView());
        }
        private async void Button_Clicked_2(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Registered());
        }
    }

}