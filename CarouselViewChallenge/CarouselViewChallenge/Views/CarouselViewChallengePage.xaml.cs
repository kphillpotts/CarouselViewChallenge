using CarouselViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselViewChallengePage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            // get the position
            //var position = MyCarousel.Position;
            var selectedItem = MyCarousel.CurrentItem as Item;
            if (selectedItem == null)
                System.Diagnostics.Debug.WriteLine("Can't get current item");
            else
                Navigation.PushAsync(new ProductDetailsPage(selectedItem));

        }
    }
}