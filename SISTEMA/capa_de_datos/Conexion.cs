using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    internal class Conexion
    {        
        //string con parametros para conectarse a la base de datos, siendo estos: el host, el usuario de postgres, la contraseña del usuario y a la base de datos que se va a conectar
        public string con = "Host=localhost; Username=postgres; Password=5678; Database=AlmacenMiFavoritaBD1;";
    }
}
