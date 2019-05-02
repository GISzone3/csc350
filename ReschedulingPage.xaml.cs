using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReschedulingApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReschedulingPage : ContentPage
	{
		public ReschedulingPage ()
		{
			InitializeComponent ();
		}
        //ZRM4JM
        private void Button_Clicked(object sender, EventArgs e)
        {
            
            bool isDay = string.IsNullOrEmpty(Month.Text);
            bool isMonth = string.IsNullOrEmpty(Day.Text);
            bool isYear = string.IsNullOrEmpty(Year.Text);
            bool isReliever = string.IsNullOrEmpty(Reliever.Text);

            if ((isDay && isMonth && isYear && isReliever) == true)
            {

            }

            else
            {
                DisplayAlert("Please re-enter one of the inputs");
                //Console.ReadLine();
            }
          
        }
    }
}