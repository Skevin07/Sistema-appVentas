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
using appVentas.VISTA.Formulariosdebusqueda;
using appVentas.VISTA;

namespace appVentas.VISTA
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void rOLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmROLES rol = new frmROLES();
            rol.MdiParent = this;
            rol.Show();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario usu = new frmUsuario();
            usu.MdiParent = this;
            usu.Show();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        public static frmVentas venta = new frmVentas();
        private void vENDERToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            venta.MdiParent = this;                                      
            venta.Show();
        }


        private void vENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    } 
}
