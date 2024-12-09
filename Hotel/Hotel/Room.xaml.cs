using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Hotel
{
    public partial class Room : ContentPage
    {
        private decimal basePrice; 
        private int age;
        private int kol;
        private int rooms;
        private bool h;
        private bool f;
        private double discount;

        public Room(int age, decimal price, int kol, int rooms, bool h, bool f)
        {
            InitializeComponent();
            this.age = age;
            this.basePrice = price;
            this.kol = kol; 
            this.rooms = rooms;
            this.h = h;
            this.f = f;
            CalculateCost();
        }

        private void CalculateCost()
        {

            decimal finalCost;

            if (kol == 1)
            {
                if (age >= 18 && age <= 25 || age >= 60)
                {
                    discount = 0.40; 
                }
                else
                {
                    discount = 0; 
                }
                finalCost = basePrice * (1 - Convert.ToDecimal(discount));
            }
            else if (kol > 1)
            {
                
                if (rooms == 4)
                {
                    if (f) finalCost = basePrice * 0.5m * kol * Convert.ToDecimal(0.10);
                    else finalCost = basePrice * 0.5m * kol; 
                }
                else
                {
                    
                    if (h)
                    {
                        if (f) discount = 0.10;
                        else discount = 0.40; 
                    }
                    else
                    {
                        discount = 0; 
                    }
                    finalCost = basePrice * (1 - Convert.ToDecimal(discount)) * kol; 
                }
            }
            else
            {
                finalCost = basePrice;
            }

            CostLabel.Text = $"Стоимость проживания: {finalCost:C}";
        }

        private async void OnHomePageClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainSusu());
        }

        private async void OnSelectPlacesClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage(0,0));
        }
    }
}