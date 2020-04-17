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
    public partial class Confirm : PopupPage
    {
        public Confirm()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // await PopupNavigation.Instance.PopAsync(true);
            //await Navigation.PushAsync(new Registered());
            //Close();

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {


            if (From.SelectedIndex == 0 && To.SelectedIndex == 1 && Trip.SelectedIndex == 0)
            {
                price.Text = "R7";
            }


            if (From.SelectedIndex == 0 && To.SelectedIndex == 2 && Trip.SelectedIndex == 0)
            {
                price.Text = "R7";
            }


            if (From.SelectedIndex == 0 && To.SelectedIndex == 3 && Trip.SelectedIndex == 0)
            {
                price.Text = "R9";
            }



            if (From.SelectedIndex == 0 && To.SelectedIndex == 4 && Trip.SelectedIndex == 0)
            {
                price.Text = "R8";
            }


            if (From.SelectedIndex == 0 && To.SelectedIndex == 5 && Trip.SelectedIndex == 0)
            {
                price.Text = "R10";
            }


            ///////////////////////////////////////////////////


         

                if (From.SelectedIndex == 0 && To.SelectedIndex == 1 && Trip.SelectedIndex == 1)
                {
                    price.Text = "R16";
                }



                if (From.SelectedIndex == 0 && To.SelectedIndex == 1 && Trip.SelectedIndex == 2)
                {
                    price.Text = "R55";
                }
































                if (From.SelectedIndex == 0 && To.SelectedIndex == 1 && Trip.SelectedIndex == 3)
                {
                    price.Text = "R120";
                }


                if (From.SelectedIndex == 0 && To.SelectedIndex == 2 && Trip.SelectedIndex == 0)
                {
                    price.Text = "R10";
                }






                if (From.SelectedIndex == 0 && To.SelectedIndex == 2 && Trip.SelectedIndex == 1)
                {
                    price.Text = "R15";
                }



                if (From.SelectedIndex == 0 && To.SelectedIndex == 2 && Trip.SelectedIndex == 2)
                {
                    price.Text = "R53";
                }
















                if (From.SelectedIndex == 0 && To.SelectedIndex == 2 && Trip.SelectedIndex == 3)
                {
                    price.Text = "R122";
                }

                ////

                if (From.SelectedIndex == 0 && To.SelectedIndex == 3 && Trip.SelectedIndex == 0)
                {
                    price.Text = "R10";
                }


                if (From.SelectedIndex == 0 && To.SelectedIndex == 3 && Trip.SelectedIndex == 1)
                {
                    price.Text = "R17";
                }



                if (From.SelectedIndex == 0 && To.SelectedIndex == 3 && Trip.SelectedIndex == 2)
                {
                    price.Text = "R54";
                }


                if (From.SelectedIndex == 0 && To.SelectedIndex == 3 && Trip.SelectedIndex == 3)
                {
                    price.Text = "R123";
                }


                if (From.SelectedIndex == 0 && To.SelectedIndex == 4 && Trip.SelectedIndex == 0)
                {
                    price.Text = "R8";
                }





                if (From.SelectedIndex == 0 && To.SelectedIndex == 4 && Trip.SelectedIndex == 1)
                {
                    price.Text = "R16";
                }


                if (From.SelectedIndex == 0 && To.SelectedIndex == 4 && Trip.SelectedIndex == 2)
                {
                    price.Text = "R53";
                }


                if (From.SelectedIndex == 0 && To.SelectedIndex == 4 && Trip.SelectedIndex == 3)
                {
                    price.Text = "R122";
                }



                if (From.SelectedIndex == 0 && To.SelectedIndex == 5 && Trip.SelectedIndex == 0)
                {
                    price.Text = "R10";
                }


                if (From.SelectedIndex == 0 && To.SelectedIndex == 5 && Trip.SelectedIndex == 1)
                {
                    price.Text = "R17";
                }


                if (From.SelectedIndex == 0 && To.SelectedIndex == 5 && Trip.SelectedIndex == 2)
                {
                    price.Text = "R52";
                }





                if (From.SelectedIndex == 0 && To.SelectedIndex == 5 && Trip.SelectedIndex == 3)
                {
                    price.Text = "R131";
                }









            /////////////////////////////////////////////////////////////////////////////////////////
            ///








            if (From.SelectedIndex == 1 && To.SelectedIndex == 0 && Trip.SelectedIndex == 0)
            {
                price.Text = "R7";
            }


            if (From.SelectedIndex == 1 && To.SelectedIndex == 2 && Trip.SelectedIndex == 0)
            {
                price.Text = "R7";
            }


            if (From.SelectedIndex == 1 && To.SelectedIndex == 3 && Trip.SelectedIndex == 0)
            {
                price.Text = "R9";
            }



            if (From.SelectedIndex == 1 && To.SelectedIndex == 4 && Trip.SelectedIndex == 0)
            {
                price.Text = "R8";
            }
            

            if (From.SelectedIndex == 1 && To.SelectedIndex == 5 && Trip.SelectedIndex == 0)
            {
                price.Text = "R10";
            }


            ///////////////////////////////////////////////////




            if (From.SelectedIndex == 1 && To.SelectedIndex == 0 && Trip.SelectedIndex == 1)
            {
                price.Text = "R16";
            }



            if (From.SelectedIndex == 1 && To.SelectedIndex == 2 && Trip.SelectedIndex == 2)
            {
                price.Text = "R55";
            }
































            if (From.SelectedIndex == 1 && To.SelectedIndex == 2 && Trip.SelectedIndex == 3)
            {
                price.Text = "R120";
            }


            if (From.SelectedIndex == 1 && To.SelectedIndex == 2 && Trip.SelectedIndex == 0)
            {
                price.Text = "R10";
            }






            if (From.SelectedIndex == 1 && To.SelectedIndex == 2 && Trip.SelectedIndex == 1)
            {
                price.Text = "R15";
            }



            if (From.SelectedIndex == 0 && To.SelectedIndex == 2 && Trip.SelectedIndex == 2)
            {
                price.Text = "R53";
            }
















            if (From.SelectedIndex == 1 && To.SelectedIndex == 2 && Trip.SelectedIndex == 3)
            {
                price.Text = "R122";
            }

            ////

            if (From.SelectedIndex == 1 && To.SelectedIndex == 3 && Trip.SelectedIndex == 0)
            {
                price.Text = "R10";
            }


            if (From.SelectedIndex == 1 && To.SelectedIndex == 3 && Trip.SelectedIndex == 1)
            {
                price.Text = "R17";
            }



            if (From.SelectedIndex == 1 && To.SelectedIndex == 3 && Trip.SelectedIndex == 2)
            {
                price.Text = "R54";
            }


            if (From.SelectedIndex == 1 && To.SelectedIndex == 3 && Trip.SelectedIndex == 3)
            {
                price.Text = "R123";
            }


            if (From.SelectedIndex == 1 && To.SelectedIndex == 4 && Trip.SelectedIndex == 0)
            {
                price.Text = "R8";
            }





            if (From.SelectedIndex == 1 && To.SelectedIndex == 4 && Trip.SelectedIndex == 1)
            {
                price.Text = "R16";
            }


            if (From.SelectedIndex == 1 && To.SelectedIndex == 4 && Trip.SelectedIndex == 2)
            {
                price.Text = "R53";
            }


            if (From.SelectedIndex == 1 && To.SelectedIndex == 4 && Trip.SelectedIndex == 3)
            {
                price.Text = "R122";
            }



            if (From.SelectedIndex == 1 && To.SelectedIndex == 5 && Trip.SelectedIndex == 0)
            {
                price.Text = "R10";
            }


            if (From.SelectedIndex == 1 && To.SelectedIndex == 5 && Trip.SelectedIndex == 1)
            {
                price.Text = "R17";
            }


            if (From.SelectedIndex == 1 && To.SelectedIndex == 5 && Trip.SelectedIndex == 2)
            {
                price.Text = "R52";
            }





            if (From.SelectedIndex == 1 && To.SelectedIndex == 5 && Trip.SelectedIndex == 3)
            {
                price.Text = "R131";
            }













            //////////////////////////



        }
    }
    }





    
