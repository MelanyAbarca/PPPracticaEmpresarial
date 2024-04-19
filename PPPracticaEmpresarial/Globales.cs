using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPracticaEmpresarial
{
    public static class Globales
    {
        public static Form MiFormPrincipal = new Formularios.FrmDMI();

        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion();

        //Debemos tener un objeto de tipo usuario que permita almacenar los datos del usuario logueado correctamente 

        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        // Creacion Global para atraer el formulario.
        public static Formularios.FrmProductosGestion MiFormGestionProductos = new Formularios.FrmProductosGestion();

        // Formulario Gestion de Proveedores
        public static Formularios.FrmProveedoresGestion MiFormGestionProveedores = new Formularios.FrmProveedoresGestion();

        public static Logica.Models.Proveedor MiProveedorGlobal = new Logica.Models.Proveedor();

        // Formulario Consulta de productos en el menu procesos
        public static Formularios.FrmConsultaProductos MiFormConsultaProductos = new Formularios.FrmConsultaProductos();

    }
}
