using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Rad2022.Controller
{
    public static class AlumnController
    {
        public async static Task<List<Model.Alumnos>> GetAlumnos()
        {
            List<Model.Alumnos> Listalumnos = new List<Model.Alumnos>();

            using(HttpClient clientRequest = new HttpClient())
            {
                var response = await clientRequest.GetAsync(Config.GetServiceList);

                if (response.IsSuccessStatusCode)
                {
                    var contenido=response.Content.ReadAsStringAsync().ToString();
                    Listalumnos= JsonConvert.DeserializeObject<List<Model.Alumnos>>(contenido);
                }
            }
            return Listalumnos;
        }
    }
}
