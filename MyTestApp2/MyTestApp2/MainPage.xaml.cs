using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyTestApp2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            _button1.Clicked += _button1_Clicked;
		}

        private void _button1_Clicked(object sender, EventArgs e)
        {
            _entry1.Text = string.Empty;
            _entry2.Text = string.Empty;
        }
    }
}
