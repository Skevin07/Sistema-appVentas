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


namespace appVentas.VISTA.Formulariosdebusqueda
{
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            filtro();
        }

        void filtro()
        {
            using (sistema_ventasEntities1 bd = new sistema_ventasEntities1())
            {

                String nombre = txtBusqueda.Text;

                var buscarprod = from tbprod in bd.producto

                                 where tbprod.nombreProducto.Contains(nombre)



                                 select new
                                 {

                                     Id = tbprod.idProducto,
                                     Nombre = tbprod.nombreProducto,
                                     Precio = tbprod.precioProducto

                                 };


                dtvProductos.DataSource = buscarprod.ToList();

            }
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void dtvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            envio();

        }

        void envio()
        {
            String id; id = dtvProductos.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtvProductos.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtvProductos.CurrentRow.Cells[2].Value.ToString();

            frmMenu.venta.textBoxidProducto.Text = id;
            frmMenu.venta.textBoxNombreDeProducto.Text = Nombre;
            frmMenu.venta.textBoxPrecioDeProducto.Text = Precio;

            frmMenu.venta.textBoxCantidad.Focus();
            this.Close();
        }

        private void dtvProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                envio();
            }
        }
    }
}
