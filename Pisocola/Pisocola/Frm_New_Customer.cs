using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pisocola.model;
using Pisocola.dao;

namespace Pisocola
{
    public partial class Frm_New_Customer : Form
    {
        public Frm_New_Customer()
        {
            InitializeComponent();
            Rb_New_Cnpj.Checked = true;
        }

        private List<string> fields;

        private void SaveCustomer()
        {
            bool isValid = ValidadeFields();

            if (isValid)
            {
                Customer c = new Customer();

                c.SetNmCustomer(Inpt_Nm_Customer.Text);
                c.SetNmSocial(Inpt_Nm_Social.Text);
                c.SetDsAddress(Inpt_Ds_Address.Text);
                c.SetNrCpfCnpj(Inpt_Cpf_Cnpj.Text);
                c.SetNrInsc(Inpt_Nr_Insc.Text);
                c.SetNrPhone(Inpt_Nr_Phone.Text);

                CustomerDAO.GetInstance().InsertCustomer(c);

                Console.WriteLine("SUCESSO!");
            }
            else
            {
                string emptyFields = "";

                foreach (string item in fields)
                {
                    emptyFields += item + "\n";
                }

                MessageBox.Show("Alguns campos obrigatórios não foram preenchidos, são eles:\n\n" + emptyFields, "Atenção");
                fields = null;
            }
        }

        private bool ValidadeFields()
        {
            bool isValid = true;
            fields = new List<string>();

            if(Inpt_Nm_Customer.Text == "")
            {
                isValid = false;
                fields.Add("Nome Fantasia");
            }

            if (Inpt_Nm_Social.Text == "")
            {
                isValid = false;
                fields.Add("Nome Social");
            }

            if (Inpt_Ds_Address.Text == "")
            {
                isValid = false;
                fields.Add("Endereço");
            }

            if (Rb_New_Cpf.Checked)
            {
                if(Inpt_Cpf_Cnpj.Text == "   .   .   -")
                {
                    isValid = false;
                    fields.Add("CPF/CNPJ");
                }
            }
            else
            {
                if (Inpt_Cpf_Cnpj.Text == "   .   .   /    -")
                {
                    isValid = false;
                    fields.Add("CPF/CNPJ");
                }
            }

            if (Inpt_Nr_Insc.Text == "       -")
            {
                isValid = false;
                fields.Add("Inscrição");
            }

            return isValid;
        }

        private void Inpt_Nm_Customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void Inpt_Nm_Social_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void Inpt_Ds_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void ChangeCpfCnpjMask()
        {
            Inpt_Cpf_Cnpj.Clear();

            if (Rb_New_Cpf.Checked)
            {
                Inpt_Cpf_Cnpj.Mask = @"000,000,000-00";
            }
            else
            {
                Inpt_Cpf_Cnpj.Mask = @"000,000,000/0000-00";
            }
        }

        private void Rb_New_Cpf_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCpfCnpjMask();
        }

        private void Rb_New_Cnpj_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCpfCnpjMask();
        }

        private void Btn_Save_Customer_Click(object sender, EventArgs e)
        {
            SaveCustomer();
        }
    }
}
