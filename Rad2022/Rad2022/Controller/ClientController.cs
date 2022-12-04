using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Rad2022.Controller
{
    public static class ClientController
    {
        public async static Task<List<Model.Cliente>> getCliente()
        {
            List<Model.Cliente> ListaClientes = new List<Model.Cliente>();

            try
            {
                using (HttpClient clientRequest = new HttpClient())
                {
                    var response = await clientRequest.GetAsync(Configuracion.GetServiceList);

                    if (response.IsSuccessStatusCode)
                    {
                        var contenido = response.Content.ReadAsStringAsync().Result;
                        ListaClientes = JsonConvert.DeserializeObject<List<Model.Cliente>>(contenido);
                    }
                }
                return ListaClientes;
            }
            catch(Exception ex)
            {
                ex.ToString();
                return ListaClientes;
            }
            
        }
    }
}
