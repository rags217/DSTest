using System;
using Xamarin.Forms;

namespace DSTest
{
    public class App : Application
    {
        Label message = new Label { Text = "App started", HorizontalOptions = LayoutOptions.Center };
        public App()
        {

            Button setDependency1 = new Button { Text = "Set Dependency1"};
            setDependency1.Clicked +=(sender, e) => {
                DependencyService.Get<iDependencyBase>().initialiseTest1();
                message.Text = "Dependency1 is Set";
            };

            Button setDependency2 = new Button { Text = "Set Dependency2" };
            setDependency2.Clicked += (sender, e) => {
                DependencyService.Get<iDependencyBase>().initialiseTest2();
                message.Text = "Dependency2 is Set";
            };

            Button callDependency1 = new Button { Text = "Call Dependency1" };
            callDependency1.Clicked += (sender, e) => {
                if (DependencyService.Get<iDependencyTest1>() == null)
                    message.Text = "Dependency1 is Null";
                else
                    message.Text = "Dependency1 is Called";
            };

            Button callDependency2 = new Button { Text = "Call Dependency2" };
            callDependency2.Clicked += (sender, e) => {
                if (DependencyService.Get<iDependencyTest2>() == null)
                    message.Text = "Dependency2 is Null";
                else
                    message.Text = "Dependency2 is Called";
            };

            var content = new ContentPage
            {
                Title = "DSTest",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        setDependency1,
                        setDependency2,
                        callDependency1,
                        callDependency2,
                        message
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
