using System;
using System.Collections.Generic;
using System.Text;

namespace Rad2022.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Nacimiento { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Foto { get; set; }
        public string Estado { get; set; }
        public string Telefono { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }

    
}
