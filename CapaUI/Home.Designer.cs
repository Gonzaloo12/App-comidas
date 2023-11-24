
namespace TP_FINAL
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            AboutUs = new Button();
            Menu = new Button();
            btnHome = new Button();
            menu_cate = new Panel();
            iniciarSesion = new Button();
            labelUser = new Label();
            sesion = new Button();
            menu_cate.SuspendLayout();
            SuspendLayout();
            // 
            // AboutUs
            // 
            AboutUs.BackColor = Color.Transparent;
            AboutUs.FlatAppearance.BorderColor = Color.Black;
            AboutUs.FlatAppearance.BorderSize = 0;
            AboutUs.FlatAppearance.MouseDownBackColor = Color.Black;
            AboutUs.FlatStyle = FlatStyle.Flat;
            AboutUs.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            AboutUs.ForeColor = Color.Transparent;
            AboutUs.Location = new Point(163, 28);
            AboutUs.Name = "AboutUs";
            AboutUs.Padding = new Padding(3, 0, 0, 0);
            AboutUs.Size = new Size(187, 50);
            AboutUs.TabIndex = 3;
            AboutUs.Text = "Sobre Nosotros";
            AboutUs.UseVisualStyleBackColor = false;
            AboutUs.Click += AboutUs_Click;
            // 
            // Menu
            // 
            Menu.BackColor = Color.Transparent;
            Menu.FlatAppearance.BorderColor = Color.Black;
            Menu.FlatAppearance.BorderSize = 0;
            Menu.FlatAppearance.MouseDownBackColor = Color.Black;
            Menu.FlatStyle = FlatStyle.Flat;
            Menu.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Menu.ForeColor = Color.Transparent;
            Menu.Location = new Point(345, 28);
            Menu.Name = "Menu";
            Menu.Padding = new Padding(3, 0, 0, 0);
            Menu.Size = new Size(124, 50);
            Menu.TabIndex = 4;
            Menu.Text = "Menú";
            Menu.UseVisualStyleBackColor = false;
            Menu.Click += Menu_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImageLayout = ImageLayout.None;
            btnHome.FlatAppearance.BorderColor = Color.White;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.Transparent;
            btnHome.Location = new Point(54, 27);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(3, 0, 0, 0);
            btnHome.Size = new Size(115, 50);
            btnHome.TabIndex = 37;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // menu_cate
            // 
            menu_cate.BackColor = Color.Transparent;
            menu_cate.Controls.Add(iniciarSesion);
            menu_cate.Location = new Point(0, 105);
            menu_cate.Name = "menu_cate";
            menu_cate.Size = new Size(1393, 585);
            menu_cate.TabIndex = 39;
            // 
            // iniciarSesion
            // 
            iniciarSesion.BackColor = Color.FromArgb(255, 138, 0);
            iniciarSesion.FlatStyle = FlatStyle.Flat;
            iniciarSesion.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            iniciarSesion.ForeColor = Color.White;
            iniciarSesion.Location = new Point(184, 381);
            iniciarSesion.Name = "iniciarSesion";
            iniciarSesion.Size = new Size(202, 63);
            iniciarSesion.TabIndex = 15;
            iniciarSesion.Text = "Iniciar Sesión";
            iniciarSesion.UseVisualStyleBackColor = false;
            iniciarSesion.Click += iniciarSesion_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.Transparent;
            labelUser.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUser.ForeColor = Color.White;
            labelUser.Location = new Point(1238, 40);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(0, 24);
            labelUser.TabIndex = 40;
            // 
            // sesion
            // 
            sesion.BackColor = Color.Transparent;
            sesion.FlatStyle = FlatStyle.Flat;
            sesion.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sesion.ForeColor = Color.White;
            sesion.Location = new Point(1193, 28);
            sesion.Name = "sesion";
            sesion.Size = new Size(161, 38);
            sesion.TabIndex = 41;
            sesion.Text = "Iniciar Sesión";
            sesion.UseVisualStyleBackColor = false;
            sesion.Click += sesion_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1394, 683);
            Controls.Add(sesion);
            Controls.Add(labelUser);
            Controls.Add(menu_cate);
            Controls.Add(btnHome);
            Controls.Add(Menu);
            Controls.Add(AboutUs);
            Name = "Home";
            menu_cate.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button AboutUs;
        private System.Windows.Forms.Button Menu;
        private Button btnHome;
        public Panel menu_cate;
        internal Button iniciarSesion;
        private Label labelUser;
        internal Button sesion;
    }
}

