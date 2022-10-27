using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace evaluacion1AlexisRobalino
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {


            String usuario = "Alexis2022";
            String contrasena = "uisrael2022";

            string tUsuario = txtUsuario.Text;
            string tContrasena = txtContrasena.Text;
            if (usuario == tUsuario & contrasena == tContrasena)
            {
                DisplayAlert("Alerta", "USUARIO CORRECTO", "Cerrar");
                await Navigation.PushAsync(new Registro(txtUsuario.Text, txtContrasena.Text, 39));
            }
            else
            {
                DisplayAlert("Alerta", "USUARIO NO EXISTE", "Cerrar");
            }
        }
    }
}