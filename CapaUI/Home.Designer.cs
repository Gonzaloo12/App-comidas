
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
            button1 = new Button();
            btnHome = new Button();
            menu_cate = new Panel();
            iniciarSesion = new Button();
            registrate = new Button();
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
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(478, 28);
            button1.Name = "button1";
            button1.Padding = new Padding(3, 0, 0, 0);
            button1.Size = new Size(120, 50);
            button1.TabIndex = 8;
            button1.TabStop = false;
            button1.Text = "Mi carrito";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
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
            btnHome.Location = new Point(54, 26);
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
            menu_cate.Controls.Add(registrate);
            menu_cate.Location = new Point(1, 97);
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
            iniciarSesion.Location = new Point(257, 357);
            iniciarSesion.Name = "iniciarSesion";
            iniciarSesion.Size = new Size(150, 55);
            iniciarSesion.TabIndex = 15;
            iniciarSesion.Text = "Iniciar Sesión";
            iniciarSesion.UseVisualStyleBackColor = false;
            iniciarSesion.Click += iniciarSesion_Click;
            // 
            // registrate
            // 
            registrate.BackColor = Color.FromArgb(255, 138, 0);
            registrate.FlatStyle = FlatStyle.Flat;
            registrate.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            registrate.ForeColor = Color.White;
            registrate.Location = new Point(96, 357);
            registrate.Name = "registrate";
            registrate.Size = new Size(147, 55);
            registrate.TabIndex = 14;
            registrate.Text = "Registrate";
            registrate.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1394, 683);
            Controls.Add(menu_cate);
            Controls.Add(btnHome);
            Controls.Add(button1);
            Controls.Add(Menu);
            Controls.Add(AboutUs);
            Name = "Home";
            menu_cate.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button AboutUs;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button button1;
        private Button btnHome;
        private Button iniciarSesion;
        private Button registrate;
        private Panel menu_cate;
    }
}

