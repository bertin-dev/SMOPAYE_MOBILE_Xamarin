using SMOPAYE_MOBILE_Xamarin.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SMOPAYE_MOBILE_Xamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private Image splashImage;

        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                //Source = "C:\\Users\\Bertin-dev\\Source\\Repos\\TestScreenSplash\\TestScreenSplash\\TestScreenSplash.Android\\Resources\\drawable\\logo_screen_splash.png",
                Source = "logo_screen_splash.png",
                WidthRequest = 100,
                HeightRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(splashImage);
            //this.BackgroundColor = Color.FromHex("#429de3");
            this.Title = "Chargement Encours...";
            this.BackgroundImageSource = "bg_screen_splash.png";
            this.Content = sub;

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await splashImage.ScaleTo(1, 5000);
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            await splashImage.ScaleTo(150, 1200, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new LoginPage()); //after loading MainPage it gets Navigated
        }





    }
}
