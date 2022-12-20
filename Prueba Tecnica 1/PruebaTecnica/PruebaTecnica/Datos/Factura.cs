using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Datos
{
     class Factura
    {
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable DaoListarClientes()
        {
            DataTable resultado = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "SELECT * FROM CLIENTES";
            LeerFilas= Comando.ExecuteReader();
            resultado.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return resultado;
        }

        public DataTable DaoListarEstado_Factura()
        {
            DataTable resultado = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "SELECT * FROM ESTADOS_FACTURA";
            LeerFilas = Comando.ExecuteReader();
            resultado.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return resultado;
        }

        public void InsertarFactura(int NUME_DOC, int CODI_ESTADO, int VALOR_FAC, string FECHA_FAC)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "INSERT INTO FACTURA (NUME_DOC,CODI_ESTADO,VALOR_FAC,FECHA_FAC) VALUES ('"+ NUME_DOC +"','"+ CODI_ESTADO + "','"+ VALOR_FAC + "','"+ FECHA_FAC + "')";
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        public DataTable DaoListarFacturas()
        {
            DataTable resultado = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "SELECT f.FECHA_FAC as Fecha_Factura, c.NOMBRE as Cliente, f.VALOR_FAC as Valor_Factura , e.DESCRIPCION as Descripcion\r\nFROM CLIENTES c join FACTURA f ON c.NUME_DOC = f.NUME_DOC\r\n\t join ESTADOS_FACTURA e ON e.CODI_ESTADO = f.CODI_ESTADO; ";
            LeerFilas = Comando.ExecuteReader();
            resultado.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return resultado;
        }

    }
}
