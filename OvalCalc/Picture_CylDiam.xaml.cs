using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OvalCalc
{
    public partial class Picture_CylDiam : ContentPage
    {
        public Picture_CylDiam()
        {
            InitializeComponent();
        }

        async void ClosePage()
        {
            await Navigation.PopModalAsync();
        }

        async void PopAboutUsPage()
        {
            var aboutUsPage = new AboutUsPage();
            await Navigation.PushModalAsync(aboutUsPage);
        }


        void Close_Clicked(System.Object sender, System.EventArgs e)
        {
            ClosePage();
        }

        void AboutUs_Clicked(System.Object sender, System.EventArgs e)
        {
            //The more button was clicked so pull up modal
            PopAboutUsPage();
        }

    }
}
