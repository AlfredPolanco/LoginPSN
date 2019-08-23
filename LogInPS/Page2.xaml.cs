using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LogInPS
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();

		}
        private async void GameTab(object sender, EventArgs e)
        {
            //Al presionar el boton de games que es el unico que funciona, este te lleva al juego
            await Navigation.PushAsync(new Page3());
        }


	}
}
