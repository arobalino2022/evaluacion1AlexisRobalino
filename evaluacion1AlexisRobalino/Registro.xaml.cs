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
        public Registro(string usuario, string clave, int edad)
        {
            InitializeComponent();
            lblUsuario.Text = "El usuario conectado es " + usuario;
            lblClave.Text = "La clave es " + clave;
        }

        public int Text { get; private set; }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNotaseg.Text) )
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                var notas = double.Parse(txtNotaseg.Text) * 0.3;
                var nota = notas 
                txtNota.Text = nota.ToString();




                DisplayAlert("Mensaje de Alerta", "Tu nombre es " + nombre + "\nTu apellido es " + apellido + "\n Tu Nota de Parcial 1 es " + nota, "Cerrar");


            }
            else
            {
                DisplayAlert("Error", "Nose introducido datos ", "ok");
            }
        }
        
        private void BtnInformacion_Clicked2(object sender, EventArgs e)
        {

            var num1 = double.Parse(txtNota.Text);
         
            var sumnotas = num1 
            if (sumnotas >= 7)
            {


                {


                    DisplayAlert("Mensaje de Alerta", "APROBADO", "Cerrar");

                }
            }
            if (sumnotas >= 5 && sumnotas < 7)
            {


                {


                    DisplayAlert("Mensaje de Alerta", "COMPLEMENTARIO", "Cerrar");

                }
            }

            if (sumnotas < 5)
            {
                DisplayAlert("Mensaje de Alerta", "REPROBADO", "Cerrar");
            }
        }

    }

}