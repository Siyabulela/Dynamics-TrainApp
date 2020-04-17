using RestSharp;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class coupon : PopupPage
    {
		public coupon ()
		{
			InitializeComponent ();
		}
        private void Cancel_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
            Navigation.PushAsync(new Settings());
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string filename = Path.Combine(path, "Use.txt");

            using (var streamReader = new StreamReader(filename))
            {
                string content = streamReader.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(content);

                string id = File.ReadLines(filename).Skip(7).Take(1).First();

                var client = new RestClient("https://trainapp-a54e.restdb.io/rest/contact/" + id);
                var request = new RestRequest(Method.PUT);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("x-apikey", "e951252bc93c396fe5f2e7f8d37f501202f41");
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", "{\"CouponNumber\":\"" + CoN.Text + "\"}", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
            }

            using (var streamReader = new StreamReader(filename))
            {
                string content = streamReader.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(content);

                string id = File.ReadLines(filename).Skip(7).Take(1).First();

                var client = new RestClient("https://trainapp-a54e.restdb.io/rest/contact/" + id);
                var request = new RestRequest(Method.PUT);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("x-apikey", "e951252bc93c396fe5f2e7f8d37f501202f41");
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", "{\"CouponNumber\":\"" + CoN.Text + "\"}", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
            }
        }
    }
}