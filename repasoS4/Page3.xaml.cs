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
    public partial class Page3 : ContentPage
    {
        public Page3(string usuario, string picker, double dato)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: " + usuario;
            txtDato.Text = dato.ToString();
            txtEstudiante.Text = picker.ToString();
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {

        }
    }
}