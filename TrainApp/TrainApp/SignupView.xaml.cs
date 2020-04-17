using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RestSharp;

namespace TrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupView : PopupPage
    {
        public SignupView()
        {
            InitializeComponent();
        }
        private async void btSignup(object sender, EventArgs e)
        {
            var client = new RestClient("https://trainapp-a54e.restdb.io/rest/contact");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "e951252bc93c396fe5f2e7f8d37f501202f41");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\"Username\":\"" + username.Text + "\",\"Password\":\"" + password.Text + "\",\"FirstName\":\"" + firstName.Text + "\",\"LastName\":\"" + lastName.Text + "\",\"Email\":\"" + email.Text + "\",\"PhoneNo\":\"" + phoneNo.Text + "\",\"Security\":\"" + security.Text + "\",\"CouponNumber\":\"" + 0 + "\",\"Trips\":\"" + 5 + "\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);


            if (response.StatusDescription.Equals("Created"))
            {
                await DisplayAlert("Thank you", "Successfully signed up 😉", "OK");
                await Navigation.PushAsync(new Registered());
                Close();

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string filename = Path.Combine(path, "Use.txt");

                using (var streamWriter = new StreamWriter(filename, true))
                {
                    streamWriter.WriteLine(firstName.Text);
                    streamWriter.WriteLine(lastName.Text);
                    streamWriter.WriteLine(email.Text);
                    streamWriter.WriteLine(phoneNo.Text);
                    streamWriter.WriteLine(security.Text);
                    streamWriter.WriteLine(username.Text);
                    streamWriter.WriteLine(password.Text);
                }
                getId();
            }
            else
                await DisplayAlert("Error Message", "There has been an error 😥", "cancel");
        }

        public void getId()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string filename = Path.Combine(path, "Use.txt");
            string ID = "";
            using (var streamReader = new StreamReader(filename))
            {
                string content = streamReader.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(content);

                string Emai = File.ReadLines(filename).Skip(2).Take(1).First();

                var client = new RestClient("https://trainapp-a54e.restdb.io/rest/contact?q={%20%22Email%22:%20%22" + Emai + "%22%20}");
                var request = new RestRequest(Method.GET);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("x-apikey", "e951252bc93c396fe5f2e7f8d37f501202f41");
                request.AddHeader("content-type", "application/json");
                IRestResponse response = client.Execute(request);

                ID = "" + response.Content.Skip(11).Take(24).First() + response.Content.Skip(12).Take(24).First() + response.Content.Skip(13).Take(24).First() +
                          response.Content.Skip(14).Take(24).First() + response.Content.Skip(15).Take(24).First() + response.Content.Skip(16).Take(24).First() +
                          response.Content.Skip(17).Take(24).First() + response.Content.Skip(18).Take(24).First() + response.Content.Skip(19).Take(24).First() +
                          response.Content.Skip(20).Take(24).First() + response.Content.Skip(21).Take(24).First() + response.Content.Skip(22).Take(24).First() +
                          response.Content.Skip(23).Take(24).First() + response.Content.Skip(24).Take(24).First() + response.Content.Skip(25).Take(24).First() +
                          response.Content.Skip(26).Take(24).First() + response.Content.Skip(27).Take(24).First() + response.Content.Skip(28).Take(24).First() +
                          response.Content.Skip(29).Take(24).First() + response.Content.Skip(30).Take(24).First() + response.Content.Skip(31).Take(24).First() +
                          response.Content.Skip(32).Take(24).First() + response.Content.Skip(33).Take(24).First() + response.Content.Skip(34).Take(24).First();

                
            }
            using (var streamWriter = new StreamWriter(filename, true))
            {
                streamWriter.WriteLine(ID);
            }
        }

        private void btLogin(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
            PopupNavigation.Instance.PushAsync(new PopupView());
        }

        public int Close()
        {
            int i = 0;
            PopupNavigation.Instance.PopAsync(true);
            return i;
        }
    }
}