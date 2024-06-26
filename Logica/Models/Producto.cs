﻿using CrystalDecisions.CrystalReports.Engine;
using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string ProductoNombre { get; set; }
        public string ProductoCodigoBarras { get; set; }
        public decimal CantidadStock { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal PrecioVentaUnitario { get; set; }
        public bool Activo { get; set; }

        public bool Agregar()
        {
            bool R = false;

            // Codigo funcional que invoca a un  procedimiento almacenado que contiene el DML Insert

            Conexion MiCnn = new Conexion();

            //Agregar Parametros
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.ProductoNombre));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CodigoBarras", this.ProductoCodigoBarras));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Stock", this.CantidadStock));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CostoUnitario", this.CostoUnitario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@PrecioVentaUnitario", this.PrecioVentaUnitario));

            //Extraccion del fk que se debe extraer del valor del objeto compuesto "Categoria del producto"

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdCategoriaProducto", this.MiCategoria.CategoriaID));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProductosAgregar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }


        public bool Editar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            //Agregar Parametros
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.ProductoNombre));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CodigoBarras", this.ProductoCodigoBarras));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Stock", this.CantidadStock));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CostoUnitario", this.CostoUnitario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@PrecioVentaUnitario", this.PrecioVentaUnitario));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdCategoriaProducto", this.MiCategoria.CategoriaID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProductoModificar");

            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }

        public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPProductoActivar");

            if (respuesta > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));

            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPProductoDesactivar");

            if (respuesta > 0)
            {
                R = true;
            }

            return R;
        }

         // FUNCIONES PARA LOS LISTAR 

        // Funcion que muestra la lista nueva de items en la ventana de busqueda de productos
        public DataTable ListarEnBusqueda()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSELECT("SPProductoBusquedaListar");

            return R;

        }
        public CategoriaProducto MiCategoria { get; set; }

        public Producto()
        {
            MiCategoria = new CategoriaProducto();
        }

        public DataTable ListarActivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            // Definicion del parametro en la lista del objeto conxion

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPProductosListar");
            return R;
        }

        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            // Definicion del parametro en la lista del objeto conxion

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPProductosListar");
            return R;
        }

        // FUNCIONES PARA LAS CONSULTAS

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));

            // Necesito un datatable para capturar la info proveedor
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProductoConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public Producto ConsultarPorIDRetornaProducto()
        {
            Producto R = new Producto();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));

            // Necesito un datatable para capturar la info del Producto
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProductoConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                // Se crea un objeto de tipo de tipo datarow para capturar la info contenida en index 0 del dt
                // (datatable)

                DataRow dr = dt.Rows[0];

                R.ProductoID = Convert.ToInt32(dr["ProductoID"]);
                R.ProductoCodigoBarras = Convert.ToString(dr["ProductoCodigoBarras"]);
                R.ProductoNombre = Convert.ToString(dr["ProductoNombre"]);
                R.CantidadStock = Convert.ToDecimal(dr["CantidadStock"]);
                R.CostoUnitario = Convert.ToDecimal(dr["CostoUnitario"]);
                R.PrecioVentaUnitario = Convert.ToDecimal(dr["PrecioVentaUnitario"]);

                //Composiciones 
                R.MiCategoria.CategoriaID = Convert.ToInt32(dr["CategoriaID"]);
                R.MiCategoria.CategoriaDescripcion = Convert.ToString(dr["CategoriaDescripcion"]);

            }


            return R;

        }


        public bool ConsultarProductoPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));

            // Necesito un datatable para capturar la info del usuario
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProductoConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorNombre()
        {
            bool R = false;


            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.ProductoNombre));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPProductoConsultarPorNombre");


            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorCodigoDeBarras()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            // Paramentreo cedula agregado
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CodigoBarras", this.ProductoCodigoBarras));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPProductoConsultarPorCodigoBarras");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }
            return R;
        }

        // Constructor para los reportes (Imprimir)
        public ReportDocument Imprimir(ReportDocument repo)
        {
            ReportDocument R = repo;

            CrystalReportsClass ObjCrytal = new CrystalReportsClass(R);

            //Data visual del reporte
            DataTable dt = new DataTable();

            Conexion MiCnn = new Conexion();

          //  MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));

            dt = MiCnn.EjecutarSELECT("SPProductosListarReporte");

            if (dt != null && dt.Rows.Count > 0)
            {
                ObjCrytal.dt = dt;

                R = ObjCrytal.GenerarReporte();
            }

            return R;
        }

    }
}
