using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Rad2022.Model
{
    public class Empleado
    {
        // recordar hacer la clase publica 

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string nombre { get; set; }

        [MaxLength(100)]
        public string apellidos { get; set; }

        [MaxLength (20)]   
        public int telefono { get; set; }


        public string email { get; set; }
    }
}
