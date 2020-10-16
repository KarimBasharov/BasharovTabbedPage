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
    public partial class November : ContentPage
    {
        public November()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "Инициатором учреждения праздника стал мексиканский художник Альфредо Гуати Рохо (исп. Alfredo Guati Rojo, 1918-2003).";
        }
    }
}