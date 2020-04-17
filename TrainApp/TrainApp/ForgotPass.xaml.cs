using RestSharp;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForgotPass : PopupPage
    {
		public ForgotPass ()
		{
			InitializeComponent ();
		}

        private void send(object sender, EventArgs e)
        {
            var client = new RestClient("https://trainapp-a54e.restdb.io/rest/contact");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "e951252bc93c396fe5f2e7f8d37f501202f41");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);

            string text = response.Content;
            string password;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string filename = Path.Combine(path, "Use.txt");

            using (var streamReader = new StreamReader(filename))
            {
                string content = streamReader.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(content);

                string firstN = File.ReadLines(filename).Skip(6).Take(1).First();
                password = firstN;
            }

            if (text.Contains(sec.Text) && text.Contains(email.Text))
            {
                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("pros.dynamics@gmail.com");
                    mail.To.Add(email.Text);
                    mail.Subject = "Your password - Train App";
                    mail.Body = password + "\nIf you did not request a change of password, please ignore this e-mail";

                    SmtpServer.Port = 587;
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.EnableSsl = true;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("pros.dynamics@gmail.com", "Dynamics123!");

                    SmtpServer.Send(mail);

                    DisplayAlert("Email sent", "Please check your emails", "OK");

                    PopupNavigation.Instance.PopAsync(true);
                    PopupNavigation.Instance.PushAsync(new PopupView());
                }
                catch (Exception ex)
                {
                    DisplayAlert("Failed", ex.Message, "OK");
                }
            }
            else
            {
                DisplayAlert("Failed", "Email or password is incorrect", "OK");
            }
        }
    }
}