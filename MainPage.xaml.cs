using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReschedulingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked1(object sender, EventArgs e)
        {

            //(YesReschedule.Text);

            /*bool yes = string.IsNullOrEmpty(YesReschedule.Text);
            if (yes)
            {
                Navigation.PushAsync(new ReschedulingPage());
            }*/

            //Navigation.PushAsync(new ReschedulingPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            //(YesReschedule.Text);

            /*bool yes = string.IsNullOrEmpty(YesReschedule.Text);
            if (yes)
            {
                Navigation.PushAsync(new ReschedulingPage());
            }*/

            Navigation.PushAsync(new ReschedulingPage());
        }
    }
}
