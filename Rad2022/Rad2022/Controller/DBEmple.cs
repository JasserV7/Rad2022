 using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Rad2022.Controller
{
    public class DBEmple
    {
         readonly SQLiteAsyncConnection _conexion;

        //Constructor vacio
        public DBEmple()
        {

        }

        //Constructor con parametros
        public DBEmple(string dbpath)
        {

            //Creando una conexion a la base de datos
            _conexion = new SQLiteAsyncConnection(dbpath);


            //Crear las tablas correspondientes en la base de datos de de SQlite
            _conexion.CreateTableAsync<Model.Empleado>().Wait();
        }

        //Crud de la aplicacion
        //Create 
        public Task<int> StoreEmple(Model.Empleado emple)
        {
            if (emple.Id != 0)
            {
                return _conexion.UpdateAsync(emple);    
            }
            else
            {
                return _conexion.InsertAsync(emple);
            }
        }

        

        //Read 
        public Task <List<Model.Empleado>> ListaEmpleados()
        {
            return _conexion.Table<Model.Empleado>().ToListAsync();
        }

        public Task<Model.Empleado> GetEmpleado (int pid)
        {
            return _conexion.Table<Model.Empleado>()
                .Where(i => i.Id == pid)
                .FirstOrDefaultAsync();
        }


        //Delete 

        public Task<int > DeleteEmpleado(Model.Empleado emple)
        {
            return _conexion.DeleteAsync(emple);
        }



    }
}
