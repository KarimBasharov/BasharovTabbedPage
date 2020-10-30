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
    public partial class Juuli : ContentPage
    {
        public Juuli()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "Считается, что создателем эмоджи является Сигетака (Шигетака) Курита – сотрудник одной из коммуникационных японских компаний. Он разработал систему эмоджи для пейджеров в начале 1990-х годов, а оттуда она уже перекочевала на мобильные телефоны и в компьютеры.";
        }
        private void batn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Дата праздника", "17 июля", "OK  ");
        }
    }
}