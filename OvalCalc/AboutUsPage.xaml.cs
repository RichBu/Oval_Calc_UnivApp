using System;
using System.Collections.Generic;
using Xamarin.Essentials;

using Xamarin.Forms;
//using System.Windows.Input;

namespace OvalCalc
{
    public partial class AboutUsPage : ContentPage
    {
        //public ICommand TapCommand => new Command<string>(OpenBrowserClick);
        public AboutUsPage()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("page opened");
            InitializeComponent();
     
        }

        async void ClosePage()
        {
            await Navigation.PopModalAsync();
        }

        void Close_Clicked(System.Object sender, System.EventArgs e)
        {
            ClosePage();
        }

        public async void OpenBrowser(Uri uri)
        {
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        void HyperLink_Click(System.Object sender, System.EventArgs e)
        {
            string url = "http://www.Google.com";
            Console.WriteLine("clicked the hyperlink");
            OpenBrowser(new Uri(url));
        }
    }
}
