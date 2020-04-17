using RestSharp;
using Rg.Plugins.Popup.Pages;
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
    public partial class AddCard : PopupPage
    {
        public AddCard()
        {
            InitializeComponent();
            // Browser.Source = "https://siyabulela.github.io/Validation/new.html";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Validation();
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
            Navigation.PushAsync(new Settings());
        }

        public void Validation() 
        {
            try
            {
                if (CN.Text.Length != 16 || CVV.Text.Length != 3 || CN.Text == "" || CVV.Text == null || ED.Text == "")
                {
                    DisplayAlert("Message", "Card number and/ or CVV is not correct", "Cancel");
                }
                else
                {
                    DisplayAlert("Message", "Card successfully added", "Cancel");

                    var client = new RestClient("https://trainapp-a54e.restdb.io/rest/bankcard");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("cache-control", "no-cache");
                    request.AddHeader("x-apikey", "e951252bc93c396fe5f2e7f8d37f501202f41");
                    request.AddHeader("content-type", "application/json");
                    request.AddParameter("application/json", "{\"CardNumber\":\"" + CN.Text + "\",\"CCV\":\"" + CVV.Text + "\",\"expDate\":\"" + ED.Text + "\"}", ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);


                    PopupNavigation.Instance.PopAsync(true);
                    Navigation.PushAsync(new Settings());
                }
            }
            catch (Exception)
            {
                DisplayAlert("Message", "Card number and/ or CVV is not correct", "Cancel");
            }
              
            
        }
    }
}