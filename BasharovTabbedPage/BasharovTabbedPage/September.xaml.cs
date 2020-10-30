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
    public partial class September : ContentPage
    {
        public September()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "Этот праздник появился в советское время. Официально как «День знаний» он был учреждён Указом Президиума Верховного Совета СССР № 373-11 от 15 июня 1984 года";
        }
        private void batn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Дата праздника", "1 сентября", "OK  ");
        }
    }
}