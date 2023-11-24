namespace CapaUI
{
    partial class FormTicket
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicket));
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            pictureBox1 = new PictureBox();
            etiquetaFecha = new Label();
            labelCLiente = new Label();
            labelFecha = new Label();
            labelDatoCliente = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            dataGridView2 = new DataGridView();
            Cantidad = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            precioUnitario = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            labelTotalImporte = new Label();
            labelNroTotal = new Label();
            labelAclarar = new Label();
            medioPago = new Label();
            labelMedio = new Label();
            descargarPdf = new Button();
            printDocument3 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(127, 34);
            label1.Name = "label1";
            label1.Size = new Size(162, 40);
            label1.TabIndex = 0;
            label1.Text = "Fast Burger";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // etiquetaFecha
            // 
            etiquetaFecha.AutoSize = true;
            etiquetaFecha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            etiquetaFecha.Location = new Point(380, 131);
            etiquetaFecha.Name = "etiquetaFecha";
            etiquetaFecha.Size = new Size(70, 23);
            etiquetaFecha.TabIndex = 4;
            etiquetaFecha.Text = "Fecha:";
            // 
            // labelCLiente
            // 
            labelCLiente.AutoSize = true;
            labelCLiente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCLiente.Location = new Point(34, 131);
            labelCLiente.Name = "labelCLiente";
            labelCLiente.Size = new Size(76, 23);
            labelCLiente.TabIndex = 5;
            labelCLiente.Text = "Cliente:";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFecha.Location = new Point(462, 131);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(71, 23);
            labelFecha.TabIndex = 6;
            labelFecha.Text = "--/--/---";
            // 
            // labelDatoCliente
            // 
            labelDatoCliente.AutoSize = true;
            labelDatoCliente.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDatoCliente.Location = new Point(127, 131);
            labelDatoCliente.Name = "labelDatoCliente";
            labelDatoCliente.Size = new Size(72, 23);
            labelDatoCliente.TabIndex = 7;
            labelDatoCliente.Text = "fulanito";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Cantidad, Producto, precioUnitario, Total });
            dataGridView2.Location = new Point(34, 243);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView2.Size = new Size(617, 358);
            dataGridView2.TabIndex = 9;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 80;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 380;
            // 
            // precioUnitario
            // 
            precioUnitario.HeaderText = "P.U.";
            precioUnitario.MinimumWidth = 6;
            precioUnitario.Name = "precioUnitario";
            precioUnitario.Width = 80;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 80;
            // 
            // labelTotalImporte
            // 
            labelTotalImporte.AutoSize = true;
            labelTotalImporte.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalImporte.Location = new Point(390, 633);
            labelTotalImporte.Name = "labelTotalImporte";
            labelTotalImporte.Size = new Size(143, 23);
            labelTotalImporte.TabIndex = 10;
            labelTotalImporte.Text = "Importe Total $";
            // 
            // labelNroTotal
            // 
            labelNroTotal.AutoSize = true;
            labelNroTotal.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNroTotal.Location = new Point(564, 633);
            labelNroTotal.Name = "labelNroTotal";
            labelNroTotal.Size = new Size(17, 23);
            labelNroTotal.TabIndex = 11;
            labelNroTotal.Text = "-";
            // 
            // labelAclarar
            // 
            labelAclarar.AutoSize = true;
            labelAclarar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelAclarar.Location = new Point(34, 678);
            labelAclarar.Name = "labelAclarar";
            labelAclarar.Size = new Size(241, 17);
            labelAclarar.TabIndex = 12;
            labelAclarar.Text = "Documento NO válido como factura";
            // 
            // medioPago
            // 
            medioPago.AutoSize = true;
            medioPago.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            medioPago.Location = new Point(195, 187);
            medioPago.Name = "medioPago";
            medioPago.Size = new Size(80, 23);
            medioPago.TabIndex = 14;
            medioPago.Text = "Efectivo";
            // 
            // labelMedio
            // 
            labelMedio.AutoSize = true;
            labelMedio.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMedio.Location = new Point(34, 187);
            labelMedio.Name = "labelMedio";
            labelMedio.Size = new Size(153, 23);
            labelMedio.TabIndex = 13;
            labelMedio.Text = "Forma de Pago:";
            // 
            // descargarPdf
            // 
            descargarPdf.BackColor = Color.FromArgb(255, 138, 0);
            descargarPdf.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            descargarPdf.ForeColor = Color.White;
            descargarPdf.Location = new Point(34, 617);
            descargarPdf.Name = "descargarPdf";
            descargarPdf.Size = new Size(131, 39);
            descargarPdf.TabIndex = 15;
            descargarPdf.Text = "Descargar PDF";
            descargarPdf.UseVisualStyleBackColor = false;
            descargarPdf.Click += descargarPdf_Click;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(687, 713);
            Controls.Add(descargarPdf);
            Controls.Add(medioPago);
            Controls.Add(labelMedio);
            Controls.Add(labelAclarar);
            Controls.Add(labelNroTotal);
            Controls.Add(labelTotalImporte);
            Controls.Add(dataGridView2);
            Controls.Add(labelDatoCliente);
            Controls.Add(labelFecha);
            Controls.Add(labelCLiente);
            Controls.Add(etiquetaFecha);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "FormTicket";
            Text = "FormTicket";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private BindingSource bindingSource1;
        private PictureBox pictureBox1;
        private Label etiquetaFecha;
        private Label labelCLiente;
        private Label labelFecha;
        private Label labelDatoCliente;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private DataGridView dataGridView2;
        private Label labelTotalImporte;
        private Label labelNroTotal;
        private Label labelAclarar;
        private Label medioPago;
        private Label labelMedio;
        private Button descargarPdf;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn precioUnitario;
        private DataGridViewTextBoxColumn Total;
        private System.Drawing.Printing.PrintDocument printDocument3;
    }
}