using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;

namespace TrainApp
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
            web.Source = "http://www.metrorail.co.za/Timetables.html";
        }

        private void pop(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new AddCard());
        }
        private void popup(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new coupon());
        }

        public void put()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string filename = Path.Combine(path, "Use.txt");

            using (var streamReader = new StreamReader(filename))
            {
                string content = streamReader.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(content);

                //string CouponNo = File.ReadLines(filename).First();
                //first.Text = CouponNo;

                //string lastN = File.ReadLines(filename).Skip(1).Take(1).First();
                //last.Text = lastN;
            }
        }

        protected void webOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            if (e.Url.Contains(".pdf"))
            {
                // Retrieving the URL  
                var pdfUrl = new Uri(e.Url);

                // Open PDF URL with device browser to download  
                Device.OpenUri(pdfUrl);

                // Cancel the navigation on click actions   
                // (retains in the same page.)  
                e.Cancel = true;
            }
        }
    }
}