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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        tb_usuarios user = new tb_usuarios();


        void cargardatos()
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {

                var tb_usuario = db.tb_usuarios;

                foreach (var iterardatosTbUsuarios in tb_usuario)
                {
                    dtvUsuarios.Rows.Add(iterardatosTbUsuarios.Email, iterardatosTbUsuarios.Contrasena);
                }



                //dtvUsuarios.DataSource = db.tb_usuarios.ToList();

            }

        }
        void limpiardatos()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
        private void btnCarga_Click(object sender, EventArgs e)
        {
            cargardatos();
            limpiardatos();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            

            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();

                user = db.tb_usuarios.Find(int.Parse(Id));
                db.tb_usuarios.Remove(user);
                db.SaveChanges();

            }
            cargardatos();
            limpiardatos();


        }

        private void dtvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            String Email = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Contra = dtvUsuarios.CurrentRow.Cells[1].Value.ToString();

            txtUsuario.Text = Email;
            txtContraseña.Text = Contra;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                user.Email = txtUsuario.Text;
                user.Contrasena = txtContraseña.Text;

                db.tb_usuarios.Add(user);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
                int idC = int.Parse(Id);
                user = db.tb_usuarios.Where(VerificarID => VerificarID.Id == idC).First();
                user.Email = txtUsuario.Text;
                user.Contrasena = txtContraseña.Text;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();


            }
            cargardatos();
            limpiardatos();

        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void dtvUsuarios_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }
    }
}
