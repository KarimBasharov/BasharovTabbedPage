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
    public partial class Mai : ContentPage
    {
        public Mai()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "9 мая 1945 года на Центральный аэродром имени Фрунзе приземлился самолет «Ли-2» с экипажем А.И. Семенкова, доставивший в Москву акт о капитуляции фашистской Германии. А 24 июня на Красной площади в Москве состоялся Парад Победы.";
        }
        private void batn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Дата праздника", "9 мая", "OK  ");
        }
    }
}