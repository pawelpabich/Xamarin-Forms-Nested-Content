using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FormsConstraints
{
    public class App : Application
    {
        public App()
        {

           MyCode();
        }

        public void MyCode()
        {
            var mainPage = new ContentPage();

            var content = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Yellow,
                HeightRequest = 200,
                WidthRequest = 200,
                Children =
                {
                    new StackLayout()
                    {
                        BackgroundColor = Color.Blue,
                        HeightRequest = 100,
                        WidthRequest = 100,
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.Center,
                        Children =
                        {
                            new StackLayout()
                            {
                                BackgroundColor = Color.Green,
                                HeightRequest = 50,
                                WidthRequest = 50,
                                VerticalOptions = LayoutOptions.Center,
                                HorizontalOptions = LayoutOptions.Center,
                            }
                        }
                    }
                }

            };

            mainPage.Content = content;
            MainPage = mainPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
