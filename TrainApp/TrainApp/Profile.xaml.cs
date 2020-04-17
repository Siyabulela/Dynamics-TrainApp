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
	public partial class Profile : ContentPage
	{
		public Profile ()
		{
			InitializeComponent ();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string filename = Path.Combine(path, "Use.txt");

            using (var streamReader = new StreamReader(filename))
            {
                string content = streamReader.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(content);

                string firstN = File.ReadLines(filename).First();
                first.Text = firstN;

                string lastN = File.ReadLines(filename).Skip(1).Take(1).First();
                last.Text = lastN;

                string Emai = File.ReadLines(filename).Skip(2).Take(1).First();
                email.Text = Emai;

                string phoneN = File.ReadLines(filename).Skip(3).Take(1).First();
                phone.Text = phoneN;

                string userN = File.ReadLines(filename).Skip(5).Take(1).First();
                user.Text = userN;

                string pass = File.ReadLines(filename).Skip(6).Take(1).First();
                Password.Text = Emai;

            }
        }
	}
}