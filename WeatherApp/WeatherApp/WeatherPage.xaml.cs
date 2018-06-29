﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WeatherPage : ContentPage
	{
		public WeatherPage ()
		{
			InitializeComponent ();
            //Set the default binding to a default object for now
            BindingContext = new Weather();
		}

        private async void GetWeatherBtn_Clicked(object sender, EventArgs e) // Clicked="GetWeatherBtn_Clicked" in WeatherPage.xaml
        {
            if (!String.IsNullOrEmpty(zipCodeEntry.Text))
            {
                Weather weather = await Core.GetWeather(zipCodeEntry.Text);
                BindingContext = weather;
                getWeatherBtn.Text = "Search Again";
            }
        }
	}
}