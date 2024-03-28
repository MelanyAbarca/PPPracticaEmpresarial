using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario_Rol
    {
        // Propiedades de la clase

        public int UsuarioRolID { get; set; }

        //private int usuarioRolID;
        //public int UsuarioRolID
        //{
        //    get { return usuarioRolID; }
        //    set { usuarioRolID = value; }
        //}

        public string UsuarioRolDescripcion { get; set; }

        // Propiedades compuestas

        //Funciones y métodos

        public DataTable Listar()
        {

            DataTable R = new DataTable();


            Services.Conexion MiCnn = new Services.Conexion();
            R = MiCnn.EjecutarSELECT("SPUsuarioRolListar");

            return R;

        }





    }
}
