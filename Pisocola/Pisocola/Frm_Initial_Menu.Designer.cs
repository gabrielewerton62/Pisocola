﻿namespace Pisocola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Initial_Menu));
            this.Panel_Side_Menu = new System.Windows.Forms.Panel();
            this.Panel_Seller_SubMenu = new System.Windows.Forms.Panel();
            this.Btn_Import_Seller = new System.Windows.Forms.Button();
            this.Btn_Register_Seller = new System.Windows.Forms.Button();
            this.Btn_Consult_Seller = new System.Windows.Forms.Button();
            this.Btn_Seller_Menu = new System.Windows.Forms.Button();
            this.Panel_Customer_SubMenu = new System.Windows.Forms.Panel();
            this.Btn_Import_Customer = new System.Windows.Forms.Button();
            this.Btn_Register_Customer = new System.Windows.Forms.Button();
            this.Btn_Consult_Customer = new System.Windows.Forms.Button();
            this.Btn_Customer_Menu = new System.Windows.Forms.Button();
            this.Panel_Child_Form = new System.Windows.Forms.Panel();
            this.Panel_Side_Menu.SuspendLayout();
            this.Panel_Seller_SubMenu.SuspendLayout();
            this.Panel_Customer_SubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Side_Menu
            // 
            this.Panel_Side_Menu.AutoScroll = true;
            this.Panel_Side_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
            this.Panel_Side_Menu.Controls.Add(this.Panel_Seller_SubMenu);
            this.Panel_Side_Menu.Controls.Add(this.Btn_Seller_Menu);
            this.Panel_Side_Menu.Controls.Add(this.Panel_Customer_SubMenu);
            this.Panel_Side_Menu.Controls.Add(this.Btn_Customer_Menu);
            this.Panel_Side_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Side_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Side_Menu.Name = "Panel_Side_Menu";
            this.Panel_Side_Menu.Size = new System.Drawing.Size(200, 561);
            this.Panel_Side_Menu.TabIndex = 1;
            // 
            // Panel_Seller_SubMenu
            // 
            this.Panel_Seller_SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Panel_Seller_SubMenu.Controls.Add(this.Btn_Import_Seller);
            this.Panel_Seller_SubMenu.Controls.Add(this.Btn_Register_Seller);
            this.Panel_Seller_SubMenu.Controls.Add(this.Btn_Consult_Seller);
            this.Panel_Seller_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Seller_SubMenu.Location = new System.Drawing.Point(0, 200);
            this.Panel_Seller_SubMenu.Name = "Panel_Seller_SubMenu";
            this.Panel_Seller_SubMenu.Size = new System.Drawing.Size(200, 120);
            this.Panel_Seller_SubMenu.TabIndex = 7;
            // 
            // Btn_Import_Seller
            // 
            this.Btn_Import_Seller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
            this.Btn_Import_Seller.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Import_Seller.FlatAppearance.BorderSize = 0;
            this.Btn_Import_Seller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Import_Seller.Font = new System.Drawing.Font("Arial", 10F);
            this.Btn_Import_Seller.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Import_Seller.Image")));
            this.Btn_Import_Seller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Import_Seller.Location = new System.Drawing.Point(0, 80);
            this.Btn_Import_Seller.Name = "Btn_Import_Seller";
            this.Btn_Import_Seller.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Import_Seller.Size = new System.Drawing.Size(200, 40);
            this.Btn_Import_Seller.TabIndex = 2;
            this.Btn_Import_Seller.Text = "Importação";
            this.Btn_Import_Seller.UseVisualStyleBackColor = false;
            // 
            // Btn_Register_Seller
            // 
            this.Btn_Register_Seller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
            this.Btn_Register_Seller.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Register_Seller.FlatAppearance.BorderSize = 0;
            this.Btn_Register_Seller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Register_Seller.Font = new System.Drawing.Font("Arial", 10F);
            this.Btn_Register_Seller.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Register_Seller.Image")));
            this.Btn_Register_Seller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Register_Seller.Location = new System.Drawing.Point(0, 40);
            this.Btn_Register_Seller.Name = "Btn_Register_Seller";
            this.Btn_Register_Seller.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Register_Seller.Size = new System.Drawing.Size(200, 40);
            this.Btn_Register_Seller.TabIndex = 0;
            this.Btn_Register_Seller.Text = "Cadastro";
            this.Btn_Register_Seller.UseVisualStyleBackColor = false;
            // 
            // Btn_Consult_Seller
            // 
            this.Btn_Consult_Seller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
            this.Btn_Consult_Seller.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Consult_Seller.FlatAppearance.BorderSize = 0;
            this.Btn_Consult_Seller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consult_Seller.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consult_Seller.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Consult_Seller.Image")));
            this.Btn_Consult_Seller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consult_Seller.Location = new System.Drawing.Point(0, 0);
            this.Btn_Consult_Seller.Name = "Btn_Consult_Seller";
            this.Btn_Consult_Seller.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Consult_Seller.Size = new System.Drawing.Size(200, 40);
            this.Btn_Consult_Seller.TabIndex = 1;
            this.Btn_Consult_Seller.Text = "Consulta";
            this.Btn_Consult_Seller.UseVisualStyleBackColor = false;
            // 
            // Btn_Seller_Menu
            // 
            this.Btn_Seller_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Btn_Seller_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Seller_Menu.FlatAppearance.BorderSize = 0;
            this.Btn_Seller_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Btn_Seller_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Seller_Menu.Font = new System.Drawing.Font("Arial", 10F);
            this.Btn_Seller_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Seller_Menu.Image")));
            this.Btn_Seller_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Seller_Menu.Location = new System.Drawing.Point(0, 160);
            this.Btn_Seller_Menu.Name = "Btn_Seller_Menu";
            this.Btn_Seller_Menu.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Seller_Menu.Size = new System.Drawing.Size(200, 40);
            this.Btn_Seller_Menu.TabIndex = 5;
            this.Btn_Seller_Menu.Text = "Vendedores";
            this.Btn_Seller_Menu.UseVisualStyleBackColor = false;
            // 
            // Panel_Customer_SubMenu
            // 
            this.Panel_Customer_SubMenu.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Customer_SubMenu.Controls.Add(this.Btn_Import_Customer);
            this.Panel_Customer_SubMenu.Controls.Add(this.Btn_Register_Customer);
            this.Panel_Customer_SubMenu.Controls.Add(this.Btn_Consult_Customer);
            this.Panel_Customer_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Customer_SubMenu.ForeColor = System.Drawing.Color.Transparent;
            this.Panel_Customer_SubMenu.Location = new System.Drawing.Point(0, 40);
            this.Panel_Customer_SubMenu.Name = "Panel_Customer_SubMenu";
            this.Panel_Customer_SubMenu.Size = new System.Drawing.Size(200, 120);
            this.Panel_Customer_SubMenu.TabIndex = 3;
            // 
            // Btn_Import_Customer
            // 
            this.Btn_Import_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
            this.Btn_Import_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Import_Customer.FlatAppearance.BorderSize = 0;
            this.Btn_Import_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Import_Customer.Font = new System.Drawing.Font("Arial", 10F);
            this.Btn_Import_Customer.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Import_Customer.Image")));
            this.Btn_Import_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Import_Customer.Location = new System.Drawing.Point(0, 80);
            this.Btn_Import_Customer.Name = "Btn_Import_Customer";
            this.Btn_Import_Customer.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Import_Customer.Size = new System.Drawing.Size(200, 40);
            this.Btn_Import_Customer.TabIndex = 2;
            this.Btn_Import_Customer.Text = "Importação";
            this.Btn_Import_Customer.UseVisualStyleBackColor = false;
            this.Btn_Import_Customer.Click += new System.EventHandler(this.Btn_Import_Customer_Click);
            // 
            // Btn_Register_Customer
            // 
            this.Btn_Register_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
            this.Btn_Register_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Register_Customer.FlatAppearance.BorderSize = 0;
            this.Btn_Register_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Register_Customer.Font = new System.Drawing.Font("Arial", 10F);
            this.Btn_Register_Customer.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Register_Customer.Image")));
            this.Btn_Register_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Register_Customer.Location = new System.Drawing.Point(0, 40);
            this.Btn_Register_Customer.Name = "Btn_Register_Customer";
            this.Btn_Register_Customer.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Register_Customer.Size = new System.Drawing.Size(200, 40);
            this.Btn_Register_Customer.TabIndex = 0;
            this.Btn_Register_Customer.Text = "Cadastro";
            this.Btn_Register_Customer.UseVisualStyleBackColor = false;
            this.Btn_Register_Customer.Click += new System.EventHandler(this.Btn_Register_Customer_Click);
            // 
            // Btn_Consult_Customer
            // 
            this.Btn_Consult_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
            this.Btn_Consult_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Consult_Customer.FlatAppearance.BorderSize = 0;
            this.Btn_Consult_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consult_Customer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consult_Customer.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Consult_Customer.Image = global::Pisocola.Properties.Resources._2;
            this.Btn_Consult_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consult_Customer.Location = new System.Drawing.Point(0, 0);
            this.Btn_Consult_Customer.Name = "Btn_Consult_Customer";
            this.Btn_Consult_Customer.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Consult_Customer.Size = new System.Drawing.Size(200, 40);
            this.Btn_Consult_Customer.TabIndex = 1;
            this.Btn_Consult_Customer.Text = "Consulta";
            this.Btn_Consult_Customer.UseVisualStyleBackColor = false;
            this.Btn_Consult_Customer.Click += new System.EventHandler(this.Btn_Consult_Customer_Click);
            // 
            // Btn_Customer_Menu
            // 
            this.Btn_Customer_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Btn_Customer_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Customer_Menu.FlatAppearance.BorderSize = 0;
            this.Btn_Customer_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Btn_Customer_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Customer_Menu.Font = new System.Drawing.Font("Arial", 10F);
            this.Btn_Customer_Menu.Image = global::Pisocola.Properties.Resources.Icon_Small;
            this.Btn_Customer_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Customer_Menu.Location = new System.Drawing.Point(0, 0);
            this.Btn_Customer_Menu.Name = "Btn_Customer_Menu";
            this.Btn_Customer_Menu.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Customer_Menu.Size = new System.Drawing.Size(200, 40);
            this.Btn_Customer_Menu.TabIndex = 1;
            this.Btn_Customer_Menu.Text = "Clientes";
            this.Btn_Customer_Menu.UseVisualStyleBackColor = false;
            this.Btn_Customer_Menu.Click += new System.EventHandler(this.Btn_Customer_Menu_Click);
            // 
            // Panel_Child_Form
            // 
            this.Panel_Child_Form.BackColor = System.Drawing.Color.Snow;
            this.Panel_Child_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Child_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_Child_Form.ForeColor = System.Drawing.SystemColors.Control;
            this.Panel_Child_Form.Location = new System.Drawing.Point(200, 0);
            this.Panel_Child_Form.Name = "Panel_Child_Form";
            this.Panel_Child_Form.Size = new System.Drawing.Size(1124, 561);
            this.Panel_Child_Form.TabIndex = 2;
            // 
            // Frm_Initial_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1324, 561);
            this.Controls.Add(this.Panel_Child_Form);
            this.Controls.Add(this.Panel_Side_Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1340, 600);
            this.Name = "Frm_Initial_Menu";
            this.Text = "Menu Inicial";
            this.Panel_Side_Menu.ResumeLayout(false);
            this.Panel_Seller_SubMenu.ResumeLayout(false);
            this.Panel_Customer_SubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Side_Menu;
        private System.Windows.Forms.Panel Panel_Customer_SubMenu;
        private System.Windows.Forms.Button Btn_Import_Customer;
        private System.Windows.Forms.Button Btn_Consult_Customer;
        private System.Windows.Forms.Button Btn_Register_Customer;
        private System.Windows.Forms.Button Btn_Customer_Menu;
        private System.Windows.Forms.Button Btn_Seller_Menu;
        private System.Windows.Forms.Panel Panel_Seller_SubMenu;
        private System.Windows.Forms.Button Btn_Import_Seller;
        private System.Windows.Forms.Button Btn_Register_Seller;
        private System.Windows.Forms.Button Btn_Consult_Seller;
        private System.Windows.Forms.Panel Panel_Child_Form;
    }
}

