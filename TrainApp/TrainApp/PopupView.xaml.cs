using System.Data;
using MySql.Data.MySqlClient;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RestSharp;
using System.Net;

namespace TrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupView : PopupPage
    {
        public PopupView()
        {
            InitializeComponent();
        }

        private async void BtLogin(object sender, EventArgs args)
        {

            //var client = new RestClient("https://trainapp-a54e.restdb.io/rest/contact?q={%22PhoneNo%22:%220793729581%22}");
            var client = new RestClient("https://trainapp-a54e.restdb.io/rest/contact");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "e951252bc93c396fe5f2e7f8d37f501202f41");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);

            char com = '"';
            string combo = com + "Username" + com + ":" + com + user.Text + com + "," + com + "Password" + com + ":" + com + pass.Text + com;

            string text = response.Content;

            if (text.Contains(combo))
            {
                await Navigation.PushAsync(new Registered());
                await PopupNavigation.Instance.PopAsync(true);
            }
            else
                //await DisplayAlert("Message", combo, "Cancel");
            
            await DisplayAlert("Message", "Username or password is incorrect!", "Cancel");
        }

        private void btSignup(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
            PopupNavigation.Instance.PushAsync(new SignupView());

        }
        private void btForget(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
            PopupNavigation.Instance.PushAsync(new ForgotPass());

        }
        public int Close()
        {
            int i = 0;
            PopupNavigation.Instance.PopAsync(true);
            return i;
        }
    }
}