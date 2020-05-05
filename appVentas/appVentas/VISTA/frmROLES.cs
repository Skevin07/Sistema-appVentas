using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appVentas.Model;

namespace appVentas.VISTA
{
    public partial class frmROLES : Form
    {
        public frmROLES()
        {
            InitializeComponent();
        }

        private void frmROLES_Load(object sender, EventArgs e)
        {
           using(sistema_ventasEntities1 bd = new sistema_ventasEntities1())
           {

                var jointablas = from tbusua in bd.tb_usuarios
                                 from roles_usuarios in bd.roles_usuarios
                                 where tbusua.Id == roles_usuarios.id_Rol_Usuario

                                 select new
                                 {
                                     Id = tbusua.Id,
                                     Email = tbusua.Email,
                                     Tipo_rol = roles_usuarios.tipo_rol

                                 };


                dtVistaRoles.DataSource = jointablas.ToList();


           } 
        }
    }
}
