using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongitudApp
{
    public class MainPage  : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonKm_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntryKm.Text))
            {
                DisplayAlert("Error", "Debe ingresar una cantidad en Kilómetros.", "Aceptar");
                return;
            }

            double km = Convert.ToDouble(EntryKm.Text);
            double metros = km * 1000;
            LabelMetros.Text = $"{metros} metros";
        }

        private void ButtonMetros_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntryMetros.Text))
            {
                DisplayAlert("Error", "Debe ingresar una cantidad en Metros.", "Aceptar");
                return;
            }

            double metros = Convert.ToDouble(EntryMetros.Text);
            double centimetros = metros * 100;
            LabelCentimetros.Text = $"{centimetros} centímetros";
        }

        private void ButtonLimpiar_Clicked(object sender, EventArgs e)
        {
            EntryKm.Text = "";
            EntryMetros.Text = "";
            LabelMetros.Text = "";
            LabelCentimetros.Text = "";
        }
    }
}
    
