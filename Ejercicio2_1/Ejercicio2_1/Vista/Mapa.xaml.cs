using Plugin.Geolocator;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Ejercicio2_1.Vista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Mapa : ContentPage
	{
		public Mapa ()
		{
			InitializeComponent ();
		}

        protected async override void OnAppearing()
        {
            try
            {
                String pais = txtPais.Text;
                String capital = txtCapital.Text;
                String latitud = txtLatitud.Text;
                String longitud = txtLongitud.Text;
                String poblacion = txtPoblacion.Text;
                Pin ubicacion = new Pin();

                ubicacion.Label = pais;
                ubicacion.Address = "Capital: " + capital + ", Poblacion: " + poblacion;
                ubicacion.Position = new Position(Convert.ToDouble(latitud), Convert.ToDouble(longitud));
                ubicacion.Type = PinType.Place;
                txtMapa.Pins.Add(ubicacion);


                txtMapa.MoveToRegion(new MapSpan(new Position(Convert.ToDouble(latitud), Convert.ToDouble(longitud)), 1, 1));
                var localizacion = CrossGeolocator.Current;
                if (localizacion != null)
                {
                    localizacion.PositionChanged += localizacion_positionChanged;
                    if (!localizacion.IsListening)
                    {
                        await localizacion.StartListeningAsync(TimeSpan.FromSeconds(10), 100);
                    }
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Error: " + ex.Message, "Ok");
            }
            base.OnAppearing();
        }

        private void localizacion_positionChanged(object sender, Plugin.Geolocator.Abstractions.PositionEventArgs e)
        {
            var posicion_mapa = new Position(e.Position.Latitude, e.Position.Longitude);
            txtMapa.MoveToRegion(new MapSpan(posicion_mapa, 1, 1));
        }
    }
}