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
    public partial class Marts : ContentPage
    {
        public Marts()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "Существует мнение, что первый в истории «марш пустых кастрюль» текстильщиц Нью-Йорка, прошедший 8 марта 1857 года, стал одной из предпосылок празднования Международного женского дня.";
        }
        private void batn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Дата праздника", "8 марта", "OK  ");
        }
    }
}