﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Logica.Services
{
    public class Conexion
    {
        //Cadena de conexión a usar por la clase.
        string CadenaDeConexion { get; set; }

        //listado para agregar los parámetros para el procedimiento almacenado.

        public List<SqlParameter> ListaDeParametros = new List<SqlParameter>();

        public int EjecutarInsertUpdateDelete(String NombreSP)
        {
            int Retorno = 0;

            using (SqlConnection MyCnn = new SqlConnection(CadenaDeConexion))

            {
                SqlCommand MyComando = new SqlCommand(NombreSP, MyCnn);
                MyComando.CommandType = CommandType.StoredProcedure;

                if (ListaDeParametros != null && ListaDeParametros.Count > 0)
                {
                    foreach (SqlParameter item in ListaDeParametros)
                    {
                        MyComando.Parameters.Add(item);
                    }
                }

                MyCnn.Open();

                //Si el comando a ejecutar en un DML (update, Insert o delete) 
                //establecer SET NOCOUNT OFF; en el SP 

                Retorno = MyComando.ExecuteNonQuery();
            }

            return Retorno;
        }

        
        public DataTable EjecutarSELECT(String NombreSP, bool CargarEsquema = false)
        {
            DataTable Retorno = new DataTable();

            using (SqlConnection MyCnn = new SqlConnection(CadenaDeConexion))
            {
                SqlCommand MyComando = new SqlCommand(NombreSP, MyCnn);
                MyComando.CommandType = CommandType.StoredProcedure;
                if (ListaDeParametros != null && ListaDeParametros.Count > 0)
                {
                    foreach (SqlParameter item in ListaDeParametros)
                    {
                        MyComando.Parameters.Add(item);
                    }
                }
                SqlDataAdapter MyAdaptador = new SqlDataAdapter(MyComando);

                MyAdaptador.Fill(Retorno);
                if (CargarEsquema)
                {
                    Retorno = new DataTable();
                    MyAdaptador.FillSchema(Retorno, SchemaType.Source);
                }
            }
            return Retorno;
        }

        public Object EjecutarSELECTEscalar(String NombreSP)
        {
            Object Retorno = null;
            using (SqlConnection MyCnn = new SqlConnection(CadenaDeConexion))

            {
                SqlCommand MyComando = new SqlCommand(NombreSP, MyCnn);
                MyComando.CommandType = CommandType.StoredProcedure;

                if (ListaDeParametros != null && ListaDeParametros.Count > 0)
                {
                    foreach (SqlParameter item in ListaDeParametros)
                    {
                        MyComando.Parameters.Add(item);
                    }
                }
                MyCnn.Open();
                Retorno = MyComando.ExecuteScalar();
            }

            return Retorno;
        }

        //Constructor que  carga la info del app.config en la cadena de conexión al momento
        //de crear una instancia nueva de la clase.
        public Conexion()
        {
            this.CadenaDeConexion = ConfigurationManager.ConnectionStrings["CNNSTR"].ToString();
        }
    }
}
