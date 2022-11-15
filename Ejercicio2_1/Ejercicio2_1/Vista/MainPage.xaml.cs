using Ejercicio2_1.Config;
using Ejercicio2_1.Vista;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Ejercicio2_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void txtRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] Continentes = new String[]{ "Africa", "Americas", "Asia", "Europe", "Oceania" };
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await DisplayAlert("Advertencia", "Parece que no tienes Conexion!", "OK");
            } else
            {
                var objetoPicker = (Picker)sender;
                if (objetoPicker.SelectedIndex >= 0)
                {
                    List<Modelo.MRegion> PaisesRegion = new List<Modelo.MRegion>();
                    PaisesRegion = await Controlador.CRegion.getPaises(Continentes[objetoPicker.SelectedIndex]);
                    txtListaRegion.ItemsSource = PaisesRegion;
                }
            }
        }

        private async void txtListaRegion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Modelo.MRegion datos = (Modelo.MRegion)e.CurrentSelection.FirstOrDefault();
            bool opcion = await DisplayAlert("Pregunta", "Desea ver la capital de " + datos.translations.spa.common + " en el mapa", "Si", "No");
            if (opcion)
            {
                var mapa = new Mapa();
                Modelo.MMapa mapaDatos = new Modelo.MMapa
                {
                    pais = datos.translations.spa.common,
                    latitud = datos.latlng[0],
                    longitud = datos.latlng[1],
                    capital = datos.capital[0],
                    poblacion = datos.population
                };
                mapa.BindingContext = mapaDatos;
                await Navigation.PushAsync(mapa);
            }
        }
    }
}
