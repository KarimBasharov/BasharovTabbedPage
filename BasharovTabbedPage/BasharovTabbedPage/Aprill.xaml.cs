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
    public partial class Aprill : ContentPage
    {
        public Aprill()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "Откуда именно родом этот праздник — из Франции, Англии, Мексики или Швеции — тайна, которая, к сожалению, покрыта мраком.";
        }
    }
}