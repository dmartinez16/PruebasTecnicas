using PruebaTecnica.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnica.Presentacion
{
    public partial class Reportes : Form
    {
        Factura facturas = new Factura();
        public Reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facturas facturaViwe = new Facturas();
            facturaViwe.Show();
            this.Hide();
            
        }

        private void ListarClientes()
        {
            Factura facturas = new Factura();
            cmbClienteReporte.DataSource = facturas.DaoListarClientes();
            cmbClienteReporte.DisplayMember = "NOMBRE";
            cmbClienteReporte.ValueMember = "NUME_DOC";
        }

        private void ListarEstado_Factura()
        {
            Factura facturas = new Factura();
            cmbEstado_FacturaReporte.DataSource = facturas.DaoListarEstado_Factura();
            cmbEstado_FacturaReporte.DisplayMember = "DESCRIPCION";
            cmbEstado_FacturaReporte.ValueMember = "CODI_ESTADO";
        }

       

        private void Reportes_Load(object sender, EventArgs e)
        {
            ListarClientes();
            ListarEstado_Factura();
          
            this.FormClosed += new FormClosedEventHandler(Cerrar);
        }

        private void Cerrar(object sender, EventArgs e)
        {
            Facturas facturas = new Facturas();
            Reportes reporte = new Reportes();
            this.Hide();
            facturas.Show();

        }

        private void Reportes_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbClienteReporte.SelectedValue != null && cmbEstado_FacturaReporte.SelectedValue != null)
            {
                dataReportes.DataSource = facturas.DaoBuscarCliente(Convert.ToInt32(cmbClienteReporte.SelectedValue), Convert.ToInt32(cmbEstado_FacturaReporte.SelectedValue));
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar los items de la lista de clientes y estado de la factura");
            }
        }

        
    }
}
