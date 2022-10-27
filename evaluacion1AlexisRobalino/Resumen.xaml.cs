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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, int tot)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblNombre.Text = "El nombre del estudiante es: " + nombre;
            lblTotal.Text = "El Total apagar es: " + tot;
        }
        private void btnInformacion_Clicked3(object sender, EventArgs e)
        {






            DisplayAlert("Mensaje de Alerta", "Tu nombre es ", "Cerrar");



            }
        }
    }
