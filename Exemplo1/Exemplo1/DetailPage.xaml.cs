﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exemplo1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
		public DetailPage ()
		{
			InitializeComponent ();
		}

        public void onCLicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

    }
}