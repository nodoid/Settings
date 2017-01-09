using System;

using Xamarin.Forms;

namespace Settings
{
    public class App : Application
    {
        public IUserSetttings UserSettings { get; set; } = DependencyService.Get<IUserSetttings>();

        public App()
        {
            // The root page of your application
            var content = new ContentPage
            {
                Title = "Settings",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);
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
