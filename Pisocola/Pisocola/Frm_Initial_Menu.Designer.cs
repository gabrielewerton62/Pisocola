namespace Pisocola
{
    partial class Frm_Initial_Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Side_Menu = new System.Windows.Forms.Panel();
            this.Panel_Customer_SubMenu = new System.Windows.Forms.Panel();
            this.Btn_Import_Customer = new System.Windows.Forms.Button();
            this.Btn_Register_Customer = new System.Windows.Forms.Button();
            this.Btn_Consult_Customer = new System.Windows.Forms.Button();
            this.Btn_Customer_Menu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Panel_Child_Form = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Side_Menu.SuspendLayout();
            this.Panel_Customer_SubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Side_Menu
            // 
            this.Panel_Side_Menu.AutoScroll = true;
            this.Panel_Side_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
            this.Panel_Side_Menu.Controls.Add(this.pictureBox4);
            this.Panel_Side_Menu.Controls.Add(this.Panel_Customer_SubMenu);
            this.Panel_Side_Menu.Controls.Add(this.Btn_Customer_Menu);
            this.Panel_Side_Menu.Controls.Add(this.panelLogo);
            this.Panel_Side_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Side_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Side_Menu.Name = "Panel_Side_Menu";
            this.Panel_Side_Menu.Size = new System.Drawing.Size(200, 561);
            this.Panel_Side_Menu.TabIndex = 1;
            // 
            // Panel_Customer_SubMenu
            // 
            this.Panel_Customer_SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Panel_Customer_SubMenu.Controls.Add(this.pictureBox3);
            this.Panel_Customer_SubMenu.Controls.Add(this.pictureBox2);
            this.Panel_Customer_SubMenu.Controls.Add(this.pictureBox1);
            this.Panel_Customer_SubMenu.Controls.Add(this.Btn_Import_Customer);
            this.Panel_Customer_SubMenu.Controls.Add(this.Btn_Register_Customer);
            this.Panel_Customer_SubMenu.Controls.Add(this.Btn_Consult_Customer);
            this.Panel_Customer_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Customer_SubMenu.Location = new System.Drawing.Point(0, 80);
            this.Panel_Customer_SubMenu.Name = "Panel_Customer_SubMenu";
            this.Panel_Customer_SubMenu.Size = new System.Drawing.Size(200, 120);
            this.Panel_Customer_SubMenu.TabIndex = 3;
            // 
            // Btn_Import_Customer
            // 
            this.Btn_Import_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Btn_Import_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Import_Customer.FlatAppearance.BorderSize = 0;
            this.Btn_Import_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Import_Customer.Font = new System.Drawing.Font("Arial", 10F);
            this.Btn_Import_Customer.Location = new System.Drawing.Point(0, 80);
            this.Btn_Import_Customer.Name = "Btn_Import_Customer";
            this.Btn_Import_Customer.Size = new System.Drawing.Size(200, 40);
            this.Btn_Import_Customer.TabIndex = 2;
            this.Btn_Import_Customer.Text = "Importação";
            this.Btn_Import_Customer.UseVisualStyleBackColor = false;
            this.Btn_Import_Customer.Click += new System.EventHandler(this.Btn_Import_Customer_Click);
            // 
            // Btn_Register_Customer
            // 
            this.Btn_Register_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Btn_Register_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Register_Customer.FlatAppearance.BorderSize = 0;
            this.Btn_Register_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Register_Customer.Font = new System.Drawing.Font("Arial", 10F);
            this.Btn_Register_Customer.Location = new System.Drawing.Point(0, 40);
            this.Btn_Register_Customer.Name = "Btn_Register_Customer";
            this.Btn_Register_Customer.Size = new System.Drawing.Size(200, 40);
            this.Btn_Register_Customer.TabIndex = 0;
            this.Btn_Register_Customer.Text = "Cadastro";
            this.Btn_Register_Customer.UseVisualStyleBackColor = false;
            this.Btn_Register_Customer.Click += new System.EventHandler(this.Btn_Register_Customer_Click);
            // 
            // Btn_Consult_Customer
            // 
            this.Btn_Consult_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Btn_Consult_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Consult_Customer.FlatAppearance.BorderSize = 0;
            this.Btn_Consult_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consult_Customer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consult_Customer.Location = new System.Drawing.Point(0, 0);
            this.Btn_Consult_Customer.Name = "Btn_Consult_Customer";
            this.Btn_Consult_Customer.Size = new System.Drawing.Size(200, 40);
            this.Btn_Consult_Customer.TabIndex = 1;
            this.Btn_Consult_Customer.Text = "Consulta";
            this.Btn_Consult_Customer.UseVisualStyleBackColor = false;
            this.Btn_Consult_Customer.Click += new System.EventHandler(this.Btn_Consult_Customer_Click);
            // 
            // Btn_Customer_Menu
            // 
            this.Btn_Customer_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Customer_Menu.FlatAppearance.BorderSize = 0;
            this.Btn_Customer_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Customer_Menu.Font = new System.Drawing.Font("Arial", 10F);
            this.Btn_Customer_Menu.Location = new System.Drawing.Point(0, 40);
            this.Btn_Customer_Menu.Name = "Btn_Customer_Menu";
            this.Btn_Customer_Menu.Size = new System.Drawing.Size(200, 40);
            this.Btn_Customer_Menu.TabIndex = 1;
            this.Btn_Customer_Menu.Text = "Clientes";
            this.Btn_Customer_Menu.UseVisualStyleBackColor = true;
            this.Btn_Customer_Menu.Click += new System.EventHandler(this.Btn_Customer_Menu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 40);
            this.panelLogo.TabIndex = 0;
            // 
            // Panel_Child_Form
            // 
            this.Panel_Child_Form.BackColor = System.Drawing.Color.Snow;
            this.Panel_Child_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Child_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_Child_Form.ForeColor = System.Drawing.SystemColors.Control;
            this.Panel_Child_Form.Location = new System.Drawing.Point(200, 0);
            this.Panel_Child_Form.Name = "Panel_Child_Form";
            this.Panel_Child_Form.Size = new System.Drawing.Size(1084, 561);
            this.Panel_Child_Form.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Pisocola.Properties.Resources.profile;
            this.pictureBox4.Location = new System.Drawing.Point(12, 47);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pictureBox3.Image = global::Pisocola.Properties.Resources.import;
            this.pictureBox3.Location = new System.Drawing.Point(12, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pictureBox2.Image = global::Pisocola.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(12, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pictureBox1.Image = global::Pisocola.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Initial_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.Panel_Child_Form);
            this.Controls.Add(this.Panel_Side_Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1300, 600);
            this.Name = "Frm_Initial_Menu";
            this.Text = "Menu Inicial";
            this.Panel_Side_Menu.ResumeLayout(false);
            this.Panel_Customer_SubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Side_Menu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel Panel_Customer_SubMenu;
        private System.Windows.Forms.Button Btn_Import_Customer;
        private System.Windows.Forms.Button Btn_Consult_Customer;
        private System.Windows.Forms.Button Btn_Register_Customer;
        private System.Windows.Forms.Button Btn_Customer_Menu;
        private System.Windows.Forms.Panel Panel_Child_Form;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

