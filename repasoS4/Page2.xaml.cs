using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace repasoS4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        string usuario;
        public Page2(string usuario, string clave)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: " + usuario;
            this.usuario = usuario;
        }

        private void txtDato_TextChanged(object sender, TextChangedEventArgs e)
        {
            // RANGO 1 - 100
            try
            {
                double dato = Double.Parse(txtDato.Text);
                if (dato > 100)
                {
                    DisplayAlert("Alerta", "Dato fuera de rango", "Ok");
                    txtDato.Text = "";
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            double dato = Double.Parse(txtDato.Text);
            string estudiante = pkEstudiante.Items[pkEstudiante.SelectedIndex];

            Navigation.PushAsync(new Page3(this.usuario, estudiante, dato));
        }
    }
}