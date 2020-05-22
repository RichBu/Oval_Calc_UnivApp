using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OvalCalc
{
    public partial class Picture_Main : ContentPage
    {
        public Picture_Main()
        {
            InitializeComponent();
        }

        async void ClosePage()
        {
            await Navigation.PopModalAsync();
        }

        void Close_Clicked_1(System.Object sender, System.EventArgs e)
        {
            ClosePage();
        }

    }
}
