using System;
using System.Collections.Generic;
using System.Text;

namespace Rad2022.Controller
{
    public class Configuracion
    {
        private static string RestApiUrl = "http://{0}/{1}/{2}";

        private static string ipaddress = "192.168.1.37";
        private static string Restapi = "ProyectoRad";
        //-----
        private static string EndpointList = "ClientGetList.php";

        //Microservicio crud 
        public static string GetServiceList = string.Format(RestApiUrl, ipaddress, Restapi, EndpointList);
    }
}
