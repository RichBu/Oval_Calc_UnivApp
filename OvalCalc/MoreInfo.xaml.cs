using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OvalCalc
{
    public partial class MoreInfo : ContentPage
    {
        public MoreInfo()
        {
            InitializeComponent();
        }

        async void ClosePage()
        {
            await Navigation.PopModalAsync();
        }


        async void PopMainPicturePage()
        {
            var pictureMainPage = new Picture_Main();
            await Navigation.PushModalAsync(pictureMainPage);
        }

        void Close_Clicked(System.Object sender, System.EventArgs e)
        {
            ClosePage();
        }

        void MainPicture_Clicked(System.Object sender, System.EventArgs e)
        {
            PopMainPicturePage();
        }
    }
}
