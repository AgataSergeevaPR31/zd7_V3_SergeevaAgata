using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Carusel : CarouselPage
    {
		public Carusel ()
		{
			InitializeComponent ();

            var mainPage = new MainPage(0,0);
            var mainSusuPage = new MainSusu();
            var roomPage = new Room(0, 0, 0, 0, false, false); 
 
            Children.Add(mainSusuPage);
            Children.Add(roomPage);
            Children.Add(mainPage);
        }
	}
}