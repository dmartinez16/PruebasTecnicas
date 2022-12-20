namespace PruebaTecnica.Presentacion
{
    partial class Facturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataVerFacturas = new System.Windows.Forms.DataGridView();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbEstado_Factura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorFactura = new System.Windows.Forms.TextBox();
            this.dateFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataVerFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataVerFacturas
            // 
            this.dataVerFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVerFacturas.Location = new System.Drawing.Point(23, 12);
            this.dataVerFacturas.Name = "dataVerFacturas";
            this.dataVerFacturas.RowTemplate.Height = 25;
            this.dataVerFacturas.Size = new System.Drawing.Size(499, 426);
            this.dataVerFacturas.TabIndex = 0;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(637, 40);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(205, 23);
            this.cmbCliente.TabIndex = 1;
            // 
            // cmbEstado_Factura
            // 
            this.cmbEstado_Factura.FormattingEnabled = true;
            this.cmbEstado_Factura.Location = new System.Drawing.Point(637, 121);
            this.cmbEstado_Factura.Name = "cmbEstado_Factura";
            this.cmbEstado_Factura.Size = new System.Drawing.Size(205, 23);
            this.cmbEstado_Factura.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(652, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estado de la Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(652, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(670, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor de la venta";
            // 
            // txtValorFactura
            // 
            this.txtValorFactura.Location = new System.Drawing.Point(637, 210);
            this.txtValorFactura.Name = "txtValorFactura";
            this.txtValorFactura.Size = new System.Drawing.Size(202, 23);
            this.txtValorFactura.TabIndex = 7;
            // 
            // dateFechaFactura
            // 
            this.dateFechaFactura.Location = new System.Drawing.Point(637, 305);
            this.dateFechaFactura.Name = "dateFechaFactura";
            this.dateFechaFactura.Size = new System.Drawing.Size(205, 23);
            this.dateFechaFactura.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(652, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de la factura";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(637, 366);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 35);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateFechaFactura);
            this.Controls.Add(this.txtValorFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEstado_Factura);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.dataVerFacturas);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVerFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataVerFacturas;
        private ComboBox cmbCliente;
        private ComboBox cmbEstado_Factura;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtValorFactura;
        private DateTimePicker dateFechaFactura;
        private Label label4;
        private Button btnGuardar;
    }
}