using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaTecnica.Datos;

namespace PruebaTecnica.Presentacion
{
    public partial class Facturas : Form
    {
        Factura facturas = new Factura();
        public Facturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            ListarClientes();
            ListarEstado_Factura();
            ListarFacturas();
        }

        private void ListarClientes()
        {
            Factura facturas = new Factura();
            cmbCliente.DataSource = facturas.DaoListarClientes();
            cmbCliente.DisplayMember = "NOMBRE";
            cmbCliente.ValueMember = "NUME_DOC";
        }

        private void ListarEstado_Factura()
        {
            Factura facturas = new Factura();
            cmbEstado_Factura.DataSource = facturas.DaoListarEstado_Factura();
            cmbEstado_Factura.DisplayMember = "DESCRIPCION";
            cmbEstado_Factura.ValueMember = "CODI_ESTADO";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ()
            {
                facturas.InsertarFactura(Convert.ToInt32(cmbCliente.SelectedValue), Convert.ToInt32(cmbEstado_Factura.SelectedValue),
                                    Convert.ToInt32(txtValorFactura.Text), Convert.ToString(dateFechaFactura.Value.Date.ToString("yyyy-MM-dd")));
                MessageBox.Show("Factura Registrada con Exito");
                ListarFacturas();
            }
            else
            {

            }

            

        }

        private void ListarFacturas()
        {
            Factura facturas = new Factura();
           dataVerFacturas.DataSource = facturas.DaoListarFacturas();
            
        }

    }
}
