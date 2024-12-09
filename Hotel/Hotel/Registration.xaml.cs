using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private async void DDDD(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Login.Text) ||
                string.IsNullOrWhiteSpace(Password.Text))
            {
                await DisplayAlert("Ошибка", "Пожалуйста, заполните все поля!", "OK");
            }
            else if (Login.Text != "ects" && Password.Text != "ects2024")
            {
                await DisplayAlert("Ошибка", "Логин или пароль неверные.", "OK");
            }
            else
            {
                await Navigation.PushModalAsync(new Carusel());
            }
        }
    }
}