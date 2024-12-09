using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hotel
{
    public partial class MainPage : ContentPage
    {
        private decimal basePrice;
        private int age;
        
        public MainPage(int age, decimal price)
        {
            InitializeComponent();
            this.age = age;
            this.basePrice = price;
        }

        private async void OnMainPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainSusu());
        }

        private async void OnCalculateCostButtonClicked(object sender, EventArgs e)
        {
            int peopleCount;
            int roomCount;

            if (int.TryParse(PeopleCountEntry.Text, out peopleCount) &&
                int.TryParse(RoomCountEntry.Text, out roomCount) && roomCount > 0 && roomCount <= 4)
            {
                bool ch = chch.IsToggled;

                bool fa = fafa.IsToggled;

                await Navigation.PushModalAsync(new Room(0, basePrice, peopleCount, roomCount, ch, fa));
            }
            else
            {
                await DisplayAlert("Ошибка", "Пожалуйста, введите корректные данные. Убедитесь, что количество комнат не более 4.", "OK");
            }
        }
    }
}
