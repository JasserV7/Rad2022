using System;
using System.Collections.Generic;
using System.Text;

namespace Rad2022.Controller
{
    public class Config
    {
        private static string RestApiUrl = "http://{0}/{1}/{2}";

        private static string ipaddres = "192.168.1.43";
        private static string RestApi="PRAD";
        private static string EndpointList = "AlumnGetList.php";

        //Microservicios Crud

        public static string GetServiceList = string.Format(RestApiUrl, ipaddres, RestApi, EndpointList);
    }
}
