namespace CapaUI
{
    partial class pantallaCarrito
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
            btnPedir = new Button();
            LabelTotal = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnPedir
            // 
            btnPedir.BackColor = Color.FromArgb(255, 138, 0);
            btnPedir.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPedir.ForeColor = Color.White;
            btnPedir.Location = new Point(1147, 477);
            btnPedir.Name = "btnPedir";
            btnPedir.Size = new Size(201, 61);
            btnPedir.TabIndex = 1;
            btnPedir.Text = "Hacer Pedido";
            btnPedir.UseVisualStyleBackColor = false;
            // 
            // LabelTotal
            // 
            LabelTotal.AutoSize = true;
            LabelTotal.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotal.Location = new Point(845, 486);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(99, 37);
            LabelTotal.TabIndex = 2;
            LabelTotal.Text = "Total $";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1393, 444);
            listBox1.TabIndex = 3;
            // 
            // carrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 190, 40);
            ClientSize = new Size(1393, 585);
            Controls.Add(listBox1);
            Controls.Add(LabelTotal);
            Controls.Add(btnPedir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "carrito";
            Text = "carrito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPedir;
        private Label LabelTotal;
        public ListBox listBox1;
    }
}