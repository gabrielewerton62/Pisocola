namespace Pisocola
{
    partial class Frm_New_Customer
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
            this.Inpt_Customer_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Inpt_Social_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Search_Customer = new System.Windows.Forms.Button();
            this.Grid_Customer_Consult = new System.Windows.Forms.ListView();
            this.Field_Id_Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Nm_Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Nm_Social = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Cpf_Cnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Nr_Insc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Ds_Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Nr_Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Field_Dt_Insert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inpt_Cnpj = new System.Windows.Forms.MaskedTextBox();
            this.Inpt_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Inpt_Customer_Name
            // 
            this.Inpt_Customer_Name.Location = new System.Drawing.Point(12, 72);
            this.Inpt_Customer_Name.Name = "Inpt_Customer_Name";
            this.Inpt_Customer_Name.Size = new System.Drawing.Size(230, 20);
            this.Inpt_Customer_Name.TabIndex = 5;
            this.Inpt_Customer_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Inpt_Customer_Name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Fantasia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(248, 48);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome Social";
            // 
            // Inpt_Social_Name
            // 
            this.Inpt_Social_Name.Location = new System.Drawing.Point(248, 72);
            this.Inpt_Social_Name.Name = "Inpt_Social_Name";
            this.Inpt_Social_Name.Size = new System.Drawing.Size(230, 20);
            this.Inpt_Social_Name.TabIndex = 8;
            this.Inpt_Social_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Inpt_Social_Name_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(484, 48);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "CNPJ";
            // 
            // Btn_Search_Customer
            // 
            this.Btn_Search_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Btn_Search_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search_Customer.Location = new System.Drawing.Point(1211, 61);
            this.Btn_Search_Customer.Name = "Btn_Search_Customer";
            this.Btn_Search_Customer.Size = new System.Drawing.Size(101, 31);
            this.Btn_Search_Customer.TabIndex = 11;
            this.Btn_Search_Customer.Text = "Pesquisar";
            this.Btn_Search_Customer.UseVisualStyleBackColor = false;
            this.Btn_Search_Customer.Click += new System.EventHandler(this.Btn_Search_Customer_Click);
            // 
            // Grid_Customer_Consult
            // 
            this.Grid_Customer_Consult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Customer_Consult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Field_Id_Customer,
            this.Field_Nm_Customer,
            this.Field_Nm_Social,
            this.Field_Cpf_Cnpj,
            this.Field_Nr_Insc,
            this.Field_Ds_Address,
            this.Field_Nr_Phone,
            this.Field_Dt_Insert});
            this.Grid_Customer_Consult.HideSelection = false;
            this.Grid_Customer_Consult.Location = new System.Drawing.Point(12, 98);
            this.Grid_Customer_Consult.Name = "Grid_Customer_Consult";
            this.Grid_Customer_Consult.Size = new System.Drawing.Size(1300, 451);
            this.Grid_Customer_Consult.TabIndex = 12;
            this.Grid_Customer_Consult.UseCompatibleStateImageBehavior = false;
            this.Grid_Customer_Consult.View = System.Windows.Forms.View.Details;
            // 
            // Field_Id_Customer
            // 
            this.Field_Id_Customer.Text = "ID";
            // 
            // Field_Nm_Customer
            // 
            this.Field_Nm_Customer.Text = "Nome do Cliente";
            // 
            // Field_Nm_Social
            // 
            this.Field_Nm_Social.Text = "Nome Social";
            // 
            // Field_Cpf_Cnpj
            // 
            this.Field_Cpf_Cnpj.Text = "CPF/CNPJ";
            // 
            // Field_Nr_Insc
            // 
            this.Field_Nr_Insc.Text = "Inscrição";
            // 
            // Field_Ds_Address
            // 
            this.Field_Ds_Address.Text = "Endereço";
            // 
            // Field_Nr_Phone
            // 
            this.Field_Nr_Phone.Text = "Telefone";
            // 
            // Field_Dt_Insert
            // 
            this.Field_Dt_Insert.Text = "Data de Cadastro";
            // 
            // Inpt_Cnpj
            // 
            this.Inpt_Cnpj.Location = new System.Drawing.Point(484, 72);
            this.Inpt_Cnpj.Mask = "00,000,000/0000-00";
            this.Inpt_Cnpj.Name = "Inpt_Cnpj";
            this.Inpt_Cnpj.Size = new System.Drawing.Size(111, 20);
            this.Inpt_Cnpj.TabIndex = 13;
            // 
            // Inpt_Cpf
            // 
            this.Inpt_Cpf.Location = new System.Drawing.Point(601, 72);
            this.Inpt_Cpf.Mask = "000,000,000-00";
            this.Inpt_Cpf.Name = "Inpt_Cpf";
            this.Inpt_Cpf.Size = new System.Drawing.Size(106, 20);
            this.Inpt_Cpf.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(601, 48);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Consulta de Clientes";
            // 
            // Frm_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Inpt_Cpf);
            this.Controls.Add(this.Inpt_Cnpj);
            this.Controls.Add(this.Grid_Customer_Consult);
            this.Controls.Add(this.Btn_Search_Customer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Inpt_Social_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inpt_Customer_Name);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Frm_New_Customer";
            this.Text = "Novo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Inpt_Customer_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Inpt_Social_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Search_Customer;
        private System.Windows.Forms.ListView Grid_Customer_Consult;
        private System.Windows.Forms.ColumnHeader Field_Id_Customer;
        private System.Windows.Forms.ColumnHeader Field_Nm_Customer;
        private System.Windows.Forms.ColumnHeader Field_Nm_Social;
        private System.Windows.Forms.ColumnHeader Field_Cpf_Cnpj;
        private System.Windows.Forms.ColumnHeader Field_Nr_Insc;
        private System.Windows.Forms.ColumnHeader Field_Ds_Address;
        private System.Windows.Forms.ColumnHeader Field_Nr_Phone;
        private System.Windows.Forms.ColumnHeader Field_Dt_Insert;
        private System.Windows.Forms.MaskedTextBox Inpt_Cnpj;
        private System.Windows.Forms.MaskedTextBox Inpt_Cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}