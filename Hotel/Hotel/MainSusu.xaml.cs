using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainSusu : ContentPage
    {
        public ObservableCollection<Hotel> Hotels { get; set; }

        public MainSusu()
        {
            InitializeComponent();
            LoadHotels();
            HotelListView.ItemsSource = Hotels;
        }

        private void LoadHotels()
        {
            Hotels = new ObservableCollection<Hotel>
            {
                new Hotel { Name = "Гостиница 1", Room = "84", Director = "Иванов", Phone = "123456789", Category = "Эконом", NumberOfPlaces = 2, Price = 100, LastName = "Петров", Address = "Улица 1", Age = 30, CheckInDate = DateTime.Now, StayDuration = 3, PaymentMethod = "Безналичный", ImageUrl = "ad.jpg" },
                new Hotel { Name = "Гостиница 2", Room = "102", Director = "Сидоров", Phone = "987654321", Category = "Комфорт", NumberOfPlaces = 4, Price = 200, LastName = "Сидоров", Address = "Улица 2", Age = 25, CheckInDate = DateTime.Now, StayDuration = 2, PaymentMethod = "Наличный", ImageUrl = "ad.jpg" },
            };
        }


        private async void OnSelectPlacesClicked(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(AgeEntry.Text);
            if (HotelListView.SelectedItem is Hotel selectedHotel)
            {
                decimal price = selectedHotel.Price;
                await Navigation.PushModalAsync(new MainPage(age, price));
            }
        }

        private async void OnCalculateCostClicked(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(AgeEntry.Text);
            bool h = false;
            if (age > 18 && age < 23 || age >= 60) h = true;
            else h = false;
            if (HotelListView.SelectedItem is Hotel selectedHotel)
            {
                decimal price = selectedHotel.Price; 
                await Navigation.PushModalAsync(new Room(age, price, 1, 1, h, false)); 
            }
        }
    }
}
