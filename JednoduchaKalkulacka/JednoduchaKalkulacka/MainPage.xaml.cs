using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JednoduchaKalkulacka
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCommon_Clicked(object sender, EventArgs e)
        {
            var commonButton = sender as Button;
            if(lblDisplej.Text == "0")
            {
                lblDisplej.Text = commonButton.Text;
            }
            else
            {
                lblDisplej.Text += commonButton.Text;
            }
        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {
            lblDisplej.Text = "0";
        }

        private void btnErase_Clicked(object sender, EventArgs e)
        {
            string number = lblDisplej.Text;
            if(number != "0")
            {
                number = number.Remove(number.Length - 1, 1);
                if(string.IsNullOrEmpty(number))
                {
                    lblDisplej.Text = "0";
                }
                else
                {
                    lblDisplej.Text = number;
                }
            }
        }
    }
}
