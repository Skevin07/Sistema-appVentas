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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

       
    
        private void frmVentas_Load(object sender, EventArgs e)
        {
            retornoid();
            CargarCombo();
        }

        void retornoid()
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {

                var tb_v = db.tb_venta;
                textBoxNumeroDeVenta.Text = "1";
                foreach (var iterardatostbventa in tb_v)
                {

                    int idVenta = iterardatostbventa.idVenta;
                    int suma = idVenta + 1;
                    textBoxNumeroDeVenta.Text = suma.ToString();
                   
                    // dtvUsuarios.Rows.Add(iterardatosTbUsuarios.Email, iterardatosTbUsuarios.Contrasena);
                }


            }
        }



        void CargarCombo()
        {
            using(sistema_ventasEntities1 bd = new sistema_ventasEntities1())
            {
                var clientes = bd.tb_cliente.ToList();

                comboBoxCliente.DataSource = clientes;
                comboBoxCliente.DisplayMember = "nombreCliente";
                comboBoxCliente.ValueMember = "iDCliente";



                var tipoDocu = bd.tb_documento.ToList();

                comboBoxTipoDeDocumento.DataSource = tipoDocu;
                comboBoxTipoDeDocumento.DisplayMember = "nombreDocumento";
                comboBoxTipoDeDocumento.ValueMember = "iDDocumento";


            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //no
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusqueda busqueda = new frmBusqueda();
            busqueda.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                calculo();
            }
            catch (Exception ex)
            {

            }

            dtvProductos.Rows.Add(textBoxidProducto.Text, textBoxNombreDeProducto.Text, textBoxPrecioDeProducto.Text, textBoxCantidad.Text, textBoxTotal.Text);
            Double suma = 0;
            int i = 0;
            while ( i < dtvProductos.RowCount)
            {
                String datosAOperar = dtvProductos.Rows[i].Cells[4].Value.ToString();
                Double datosConvertidos = Convert.ToDouble(datosAOperar);             
                //suma = suma + datosConvertidos;                                                                                                                        
                suma += datosConvertidos;
                textBoxTotalFinal.Text = suma.ToString();
                i++;
            }
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            calculo();
        }

        void calculo()
        {
            try
            {


                Double precioProd;
                Double cantidad;
                Double total;

                precioProd = Double.Parse(textBoxPrecioDeProducto.Text);
                cantidad = Convert.ToDouble(textBoxCantidad.Text);
                total = precioProd * cantidad;

                textBoxTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {

                textBoxCantidad.Text = "1";
              
                textBoxCantidad.Select();

            }
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {

            using (sistema_ventasEntities1 bd = new sistema_ventasEntities1())
            {


                tb_venta tb_v = new tb_venta();
                String comboTipoDoc = comboBoxTipoDeDocumento.SelectedValue.ToString();
                String comboCliente = comboBoxCliente.SelectedValue.ToString();
                tb_v.idDocumento = Convert.ToInt32(comboTipoDoc);
                tb_v.iDCliente = Convert.ToInt32(comboCliente);
                tb_v.iDUsuario = 1;
                tb_v.totalVenta = Convert.ToDecimal(textBoxTotalFinal.Text);
                tb_v.fecha = Convert.ToDateTime(dtpFecha.Value);
                bd.tb_venta.Add(tb_v);
                bd.SaveChanges();

                detalleVenta dete = new detalleVenta();


                for (int i = 0; i < dtvProductos.RowCount; i++)
                {
                    String idProducto = dtvProductos.Rows[i].Cells[0].Value.ToString(); //
                    int idProductoConvertidos = Convert.ToInt32(idProducto);

                    String cantidad = dtvProductos.Rows[i].Cells[3].Value.ToString(); 
                    int cantidadConvertidos = Convert.ToInt32(cantidad);

                    String precio = dtvProductos.Rows[i].Cells[2].Value.ToString(); 
                    Decimal precioConvertidos = Convert.ToDecimal(precio);

                    String total = dtvProductos.Rows[i].Cells[4].Value.ToString(); 
                    Decimal totalConvertidos = Convert.ToDecimal(total);

                    dete.idVenta = Convert.ToInt32(textBoxNumeroDeVenta.Text);
                    dete.idProducto = idProductoConvertidos;
                    dete.cantidad = cantidadConvertidos;
                    dete.precio = precioConvertidos;
                    dete.total = totalConvertidos;
                    bd.detalleVenta.Add(dete);
                    bd.SaveChanges();


                }
                
            }
            retornoid();
            dtvProductos.Rows.Clear();
            textBoxTotalFinal.Text = "";
        }

        private void textBoxBuscarProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxBuscarProducto.Text == "")
            {
                if (e.KeyCode== Keys.Enter)
                {
                    btnBuscar.PerformClick();
                }
              
            }
            else if (e.KeyCode == Keys.Enter)
            {
                using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
                {
                    producto pr = new producto();
                    int buscar = int.Parse(textBoxBuscarProducto.Text);
                    pr = db.producto.Where(idBuscarr => idBuscarr.idProducto == buscar).First();
                    textBoxidProducto.Text = Convert.ToString(pr.idProducto);
                    textBoxNombreDeProducto.Text = Convert.ToString(pr.nombreProducto);
                    textBoxPrecioDeProducto.Text = Convert.ToString(pr.precioProducto);
                    textBoxCantidad.Focus();
                    textBoxBuscarProducto.Text = "";
                    intentos = 2;
                }
            }
        }


        int intentos = 1;
        private void textBoxCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (intentos == 2)
                {
                    btnAgregar.PerformClick();
                   
                    textBoxidProducto.Text = "";
                    textBoxNombreDeProducto.Text = "";
                    textBoxPrecioDeProducto.Text = "";
                    textBoxTotal.Text = "";
                    intentos = 0;
                    textBoxCantidad.Text = "1";
                    textBoxBuscarProducto.Focus();
                    
                }
            }
            intentos = 1;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEliminarDatosDeDatagrid_Click(object sender, EventArgs e)
        {
            dtvProductos.Rows.Clear();
            textBoxTotalFinal.Text = "";
        }
    }
}
