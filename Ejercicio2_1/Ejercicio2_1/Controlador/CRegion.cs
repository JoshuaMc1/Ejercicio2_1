using Ejercicio2_1.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_1.Controlador
{
    public class CRegion
    {
        public async static Task<List<Modelo.MRegion>> getPaises(String Continente)
        {
            List<Modelo.MRegion> PaisesRegion = new List<Modelo.MRegion>();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(Config.Configuraciones.EndPointRegios + Continente);
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    PaisesRegion = JsonConvert.DeserializeObject<List<Modelo.MRegion>>(contenido);
                }
            }
            return PaisesRegion;
        }

        public async static Task<List<Modelo.MPais.MPais2>> obtenerUnPais(String Pais)
        {
            List<Modelo.MPais.MPais2> PaisDatos = new List<Modelo.MPais.MPais2>();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(Config.Configuraciones.EndPointCountry + Pais);
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    PaisDatos = JsonConvert.DeserializeObject<List<Modelo.MPais.MPais2>>(contenido);
                }
            }
            return PaisDatos;
        }
    }
}
