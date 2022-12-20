namespace PruebaTecnica.Presentacion
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.dataReportes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstado_FacturaReporte = new System.Windows.Forms.ComboBox();
            this.cmbClienteReporte = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataReportes
            // 
            this.dataReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataReportes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReportes.Location = new System.Drawing.Point(281, 12);
            this.dataReportes.Name = "dataReportes";
            this.dataReportes.RowTemplate.Height = 25;
            this.dataReportes.Size = new System.Drawing.Size(362, 343);
            this.dataReportes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estado de la Factura";
            // 
            // cmbEstado_FacturaReporte
            // 
            this.cmbEstado_FacturaReporte.FormattingEnabled = true;
            this.cmbEstado_FacturaReporte.Location = new System.Drawing.Point(22, 128);
            this.cmbEstado_FacturaReporte.Name = "cmbEstado_FacturaReporte";
            this.cmbEstado_FacturaReporte.Size = new System.Drawing.Size(205, 23);
            this.cmbEstado_FacturaReporte.TabIndex = 7;
            // 
            // cmbClienteReporte
            // 
            this.cmbClienteReporte.FormattingEnabled = true;
            this.cmbClienteReporte.Location = new System.Drawing.Point(22, 47);
            this.cmbClienteReporte.Name = "cmbClienteReporte";
            this.cmbClienteReporte.Size = new System.Drawing.Size(205, 23);
            this.cmbClienteReporte.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(134, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 108);
            this.button1.TabIndex = 10;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(22, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 108);
            this.button2.TabIndex = 11;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(668, 367);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEstado_FacturaReporte);
            this.Controls.Add(this.cmbClienteReporte);
            this.Controls.Add(this.dataReportes);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataReportes;
        private Label label1;
        private Label label2;
        private ComboBox cmbEstado_FacturaReporte;
        private ComboBox cmbClienteReporte;
        private Button button1;
        private Button button2;
    }
}