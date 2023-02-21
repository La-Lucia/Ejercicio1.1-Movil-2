using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Operaciones

{
    public partial class MainPage : ContentPage
    {
        Double num1, num2;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnSumar_Clicked(object sender, EventArgs e)
        {
            if (verificar() == true)
            {
                convertir();
                var respuesta = new Models.Respuesta
                {
                    respuesta = "Respuesta: " + Sumar(num1, num2).ToString()
                };

                var pagina = new Views.PaginaDos();
                pagina.BindingContext = respuesta;
                await Navigation.PushAsync(pagina);
            }
            else
            {

                await DisplayAlert("Aviso", "Llene todos los campos", "Aceptar");

            }
        }

        private async void BtnRestar_Clicked(object sender, EventArgs e)
        {
            if (verificar() == true)
            {

                convertir();
                var respuesta = new Models.Respuesta
                {
                    respuesta = "Respuesta: " + Restar(num1, num2).ToString()
                };

                var pagina = new Views.PaginaDos();
                pagina.BindingContext = respuesta;
                await Navigation.PushAsync(pagina);

            }
            else
            {

                await DisplayAlert("Aviso", "Llene todos los campos", "Aceptar");

            }

            }

        private async void BtnMultiplicar_Clicked(object sender, EventArgs e)
        {
            if (verificar() == true)
            {
                convertir();
                var respuesta = new Models.Respuesta
                {
                    respuesta = "Respuesta: " + Multiplicar(num1, num2).ToString()
                };

                var pagina = new Views.PaginaDos();
                pagina.BindingContext = respuesta;
                await Navigation.PushAsync(pagina);

            }

            else
            {

                await DisplayAlert("Aviso", "Llene todos los campos", "Aceptar");

            }

            }

        private async void BtnDividir_Clicked(object sender, EventArgs e)
        {
            if (verificar() == true)
            {
                convertir();
                var respuesta = new Models.Respuesta
                {
                    respuesta = "Respuesta: " + Dividir(num1, num2).ToString()
                };

                var pagina = new Views.PaginaDos();
                pagina.BindingContext = respuesta;
                await Navigation.PushAsync(pagina);

            }
            else
            {

                await DisplayAlert("Aviso", "Llene todos los campos", "Aceptar");

            }

        }

        public void convertir()
        {
            num1 = Convert.ToDouble(n1.Text);
            num2 = Convert.ToDouble(n2.Text);
        }

        public Double Sumar(Double n1, Double n2)
        {
            Double sumar = n1 + n2;

            return sumar;
        }

        public Double Restar(Double n1, Double n2)
        {
            Double restar = n1 - n2;

            return restar;
        }

        public Double Multiplicar(Double n1, Double n2)
        {
            Double multiplicar = n1 * n2;

            return multiplicar;
        }

        public Double Dividir(Double n1, Double n2)
        {
            Double dividir = n1 / n2;

            return dividir;
        }

        public bool verificar() {
            Boolean v;

            if ((String.IsNullOrEmpty(n1.Text)) || (String.IsNullOrEmpty(n1.Text)))
            {
                v = false;
            }
            else {

                v = true;
            
            }

            return v;
        
        }

    }
}
