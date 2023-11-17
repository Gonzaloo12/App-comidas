
namespace TP_FINAL
{
    partial class modal
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
            this.iniciarSesion = new System.Windows.Forms.Label();
            this.correoElect = new System.Windows.Forms.Label();
            this.contrasenia = new System.Windows.Forms.Label();
            this.inputCorreo = new System.Windows.Forms.TextBox();
            this.inputContra = new System.Windows.Forms.TextBox();
            this.recordarme = new System.Windows.Forms.CheckBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iniciarSesion
            // 
            this.iniciarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(118)))));
            this.iniciarSesion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iniciarSesion.ForeColor = System.Drawing.Color.White;
            this.iniciarSesion.Location = new System.Drawing.Point(0, 0);
            this.iniciarSesion.Name = "iniciarSesion";
            this.iniciarSesion.Size = new System.Drawing.Size(515, 58);
            this.iniciarSesion.TabIndex = 2;
            this.iniciarSesion.Text = "Iniciar Sesión";
            this.iniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correoElect
            // 
            this.correoElect.AutoSize = true;
            this.correoElect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correoElect.Location = new System.Drawing.Point(41, 114);
            this.correoElect.Name = "correoElect";
            this.correoElect.Size = new System.Drawing.Size(165, 24);
            this.correoElect.TabIndex = 3;
            this.correoElect.Text = "Correo Electrónico";
            this.correoElect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.correoElect.Click += new System.EventHandler(this.correoElect_Click);
            // 
            // contrasenia
            // 
            this.contrasenia.AutoSize = true;
            this.contrasenia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contrasenia.Location = new System.Drawing.Point(41, 153);
            this.contrasenia.Name = "contrasenia";
            this.contrasenia.Size = new System.Drawing.Size(106, 24);
            this.contrasenia.TabIndex = 4;
            this.contrasenia.Text = "Contraseña";
            this.contrasenia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputCorreo
            // 
            this.inputCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputCorreo.Location = new System.Drawing.Point(245, 112);
            this.inputCorreo.Name = "inputCorreo";
            this.inputCorreo.Size = new System.Drawing.Size(222, 27);
            this.inputCorreo.TabIndex = 5;
            // 
            // inputContra
            // 
            this.inputContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputContra.Location = new System.Drawing.Point(245, 155);
            this.inputContra.Name = "inputContra";
            this.inputContra.Size = new System.Drawing.Size(222, 27);
            this.inputContra.TabIndex = 6;
            // 
            // recordarme
            // 
            this.recordarme.AutoSize = true;
            this.recordarme.Location = new System.Drawing.Point(245, 199);
            this.recordarme.Name = "recordarme";
            this.recordarme.Size = new System.Drawing.Size(112, 24);
            this.recordarme.TabIndex = 7;
            this.recordarme.Text = "Recordarme";
            this.recordarme.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(118)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(267, 262);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(131, 42);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(118)))));
            this.buttonIngresar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIngresar.ForeColor = System.Drawing.Color.White;
            this.buttonIngresar.Location = new System.Drawing.Point(102, 262);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(131, 42);
            this.buttonIngresar.TabIndex = 9;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 337);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.recordarme);
            this.Controls.Add(this.inputContra);
            this.Controls.Add(this.inputCorreo);
            this.Controls.Add(this.contrasenia);
            this.Controls.Add(this.correoElect);
            this.Controls.Add(this.iniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modal";
            this.Text = "modal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label iniciarSesion;
        private System.Windows.Forms.Label correoElect;
        private System.Windows.Forms.Label contrasenia;
        private System.Windows.Forms.TextBox inputCorreo;
        private System.Windows.Forms.TextBox inputContra;
        private System.Windows.Forms.CheckBox recordarme;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonIngresar;
    }
}