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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario,  int edad)
        {
            InitializeComponent();
            lblUsuario.Text = "El usuario conectado es: " + usuario;
        
                
        }

        public int Text { get; private set; }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNotaseg.Text))
            {
                string nombre = txtNombre.Text;
                var notas =  (3000-double.Parse(txtNotaseg.Text))/5+(3000*1.05-3000);
                var nota = notas;
                txtNota.Text = nota.ToString();
                var tot = double.Parse(txtNotaseg.Text) + (3000 - double.Parse(txtNotaseg.Text)) / 5 + (3000 * 1.05 - 3000) * 5;
                txttot.Text = tot.ToString();






                DisplayAlert("Mensaje de Alerta", "Tus nombres son: " + nombre + "\n Tu cuota mensual es: " + nota, "Cerrar");


            }
            else
            {
                DisplayAlert("Error", "No se ha introducido datos ", "ok");
            }
        }
        private async void BtnInformacion_Clicked2(object sender, EventArgs e)
        {

           

            DisplayAlert("Mensaje de Alerta", "Elemento Guardado", "Cerrar");

            await Navigation.PushAsync(new Resumen(lblUsuario.Text,txtNombre.Text,3750));


        }

    }
}
        
       

