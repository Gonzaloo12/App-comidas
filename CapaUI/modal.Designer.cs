
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
            iniciarSesion = new Label();
            correoElect = new Label();
            contrasenia = new Label();
            inputCorreo = new TextBox();
            inputContra = new TextBox();
            recordarme = new CheckBox();
            buttonCancelar = new Button();
            buttonIngresar = new Button();
            SuspendLayout();
            // 
            // iniciarSesion
            // 
            iniciarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iniciarSesion.BackColor = Color.FromArgb(255, 138, 0);
            iniciarSesion.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iniciarSesion.ForeColor = Color.White;
            iniciarSesion.Location = new Point(0, 0);
            iniciarSesion.Name = "iniciarSesion";
            iniciarSesion.Size = new Size(515, 58);
            iniciarSesion.TabIndex = 2;
            iniciarSesion.Text = "Iniciar Sesión";
            iniciarSesion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // correoElect
            // 
            correoElect.AutoSize = true;
            correoElect.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            correoElect.Location = new Point(41, 114);
            correoElect.Name = "correoElect";
            correoElect.Size = new Size(165, 24);
            correoElect.TabIndex = 3;
            correoElect.Text = "Correo Electrónico";
            correoElect.TextAlign = ContentAlignment.TopCenter;
            // 
            // contrasenia
            // 
            contrasenia.AutoSize = true;
            contrasenia.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            contrasenia.Location = new Point(41, 153);
            contrasenia.Name = "contrasenia";
            contrasenia.Size = new Size(106, 24);
            contrasenia.TabIndex = 4;
            contrasenia.Text = "Contraseña";
            contrasenia.TextAlign = ContentAlignment.TopCenter;
            // 
            // inputCorreo
            // 
            inputCorreo.BackColor = Color.FromArgb(224, 224, 224);
            inputCorreo.Location = new Point(245, 112);
            inputCorreo.Name = "inputCorreo";
            inputCorreo.Size = new Size(222, 27);
            inputCorreo.TabIndex = 5;
            // 
            // inputContra
            // 
            inputContra.BackColor = Color.FromArgb(224, 224, 224);
            inputContra.Location = new Point(245, 155);
            inputContra.Name = "inputContra";
            inputContra.Size = new Size(222, 27);
            inputContra.TabIndex = 6;
            // 
            // recordarme
            // 
            recordarme.AutoSize = true;
            recordarme.Location = new Point(245, 199);
            recordarme.Name = "recordarme";
            recordarme.Size = new Size(112, 24);
            recordarme.TabIndex = 7;
            recordarme.Text = "Recordarme";
            recordarme.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(255, 138, 0);
            buttonCancelar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(267, 262);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(131, 42);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += button1_Click;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.FromArgb(255, 138, 0);
            buttonIngresar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonIngresar.ForeColor = Color.White;
            buttonIngresar.Location = new Point(102, 262);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(131, 42);
            buttonIngresar.TabIndex = 9;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += button2_Click;
            // 
            // modal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(515, 337);
            Controls.Add(buttonIngresar);
            Controls.Add(buttonCancelar);
            Controls.Add(recordarme);
            Controls.Add(inputContra);
            Controls.Add(inputCorreo);
            Controls.Add(contrasenia);
            Controls.Add(correoElect);
            Controls.Add(iniciarSesion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "modal";
            Text = "modal";
            ResumeLayout(false);
            PerformLayout();
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