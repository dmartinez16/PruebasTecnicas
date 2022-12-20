using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PruebaTecnica.Datos
{
    class ConexionBD
    {

        static private string CadenaConexion = "Server=DESKTOP-9FNE8Q9; Database=Prueba; Integrated Security=true";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);
        
        
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
                return Conexion;
            
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
                return Conexion;
            
        }

    }
}
