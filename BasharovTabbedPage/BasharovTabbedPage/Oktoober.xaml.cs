using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasharovTabbedPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Oktoober : ContentPage
    {
        public Oktoober()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "Говорят, Хэллоуину не менее двух тысяч лет. Истоки этот противоречивый праздник берет из кельтской культуры. У кельтов существовали четко обозначенные «начала времен года». Их было четыре. Самайн знаменовал собой приход зимы и отмечался 31 октября.";
        }
    }
}