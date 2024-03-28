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
        public static Form MiFormPrincipal = new Formularios.FrmMDI();

        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion();

        //Debemos tener un objeto de tipo usuario que permita almacenar los datos del
        //usuario que sa haya logueado correctamente 

        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        // Creacion Global para atraer el formulario, se visualiza un unica instancia... 
        // en el proyecto si debe existir esto para los mantenimientos 
        public static Formularios.FrmRegistroCompra MiFormRegistroCompra = new Formularios.FrmRegistroCompra();

        // Formulario Gestion de Proveedores
        public static Formularios.FrmProveedoresGestion MiFormGestionProveedores = new Formularios.FrmProveedoresGestion();

        public static Logica.Models.Proveedor MiProveedorGlobal = new Logica.Models.Proveedor();
    }
}
