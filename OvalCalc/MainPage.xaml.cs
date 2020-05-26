using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OvalCalc
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Calc_Clicked(System.Object sender, System.EventArgs e)
        {
            double rollDiam = double.Parse( RollDiam.Text );
            double cavityDepth = double.Parse(CavityDepth.Text);
            double cavityDiam = double.Parse(CavityDiam.Text);
            string cavityDiamOut = string.Format("{0:n4}", cavityDiam);

            double diamDiff01 = rollDiam - cavityDepth;
            double diamDiff02 = rollDiam - (cavityDepth * 2.0);
            double ratio01 = rollDiam / diamDiff01;
            string ratioMinOut = string.Format("{0:n4}", ratio01);

            double ratioMinPer = (ratio01 - 1.0) * 100.0;
            string ratioMinPerOut = string.Format("{0:n2}%", ratioMinPer);

            double ratio02 = rollDiam / diamDiff02;
            string ratioMaxOut = string.Format("{0:n4}", ratio02);
            double ratioMaxPer = (ratio02 - 1.0) * 100.0;
            string ratioMaxPerOut = string.Format("{0:n2}%", ratioMaxPer);

            double Ydim01calc = ratio01 * cavityDiam;
            string Ydim01out = string.Format("{0:n4}", Ydim01calc);
            double Ydim02calc = ratio02 * cavityDiam;
            string Ydim02out = string.Format("{0:n4}", Ydim02calc);

            Result.Text = "X val = " + cavityDiamOut + " (unchanged)\n";
            Result.Text = Result.Text + "Y min val = " + Ydim01out + "\n";
            Result.Text = Result.Text + "Y max val = " + Ydim02out + "\n";
            Result.Text = Result.Text + "Y scale min = " + ratioMinOut + " (" + ratioMinPerOut + ")" + "\n";
            Result.Text = Result.Text + "Y scale max = " + ratioMaxOut + " (" + ratioMaxPerOut + ")" + "\n";
        }

        async void PopMoreInfoPage()
        {
            var moreInfoPage = new MoreInfo();
            await Navigation.PushModalAsync(moreInfoPage);
        }

        void More_Clicked(System.Object sender, System.EventArgs e)
        {
            //The more button was clicked so pull up modal
            PopMoreInfoPage();
        }
    }
}
