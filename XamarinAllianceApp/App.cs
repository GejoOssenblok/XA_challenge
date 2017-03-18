using System;

using Xamarin.Forms;
using XamarinAllianceApp.Views;

namespace XamarinAllianceApp
{
	public class App : Application
	{
        public INavigation Navigation { get; }

		public App ()
		{
            // The root page of your application
            MainPage = new NavigationPage (new Page1());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
        //
        async void OnNextPageButtonClicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync  (new CharacterListPage ());
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        
    }
}

