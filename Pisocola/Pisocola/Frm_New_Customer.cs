using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pisocola.dao;
using Pisocola.model;
using System.Collections;

namespace Pisocola
{
    public partial class Frm_New_Customer : System.Windows.Forms.Form
    {
        public Frm_New_Customer()
        {
            InitializeComponent();
        }

        private void Btn_Search_Customer_Click(object sender, EventArgs e)
        {
            LoadCustomerListView();
        }

        private void Inpt_Customer_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void Inpt_Social_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void LoadCustomerListView()
        {
            Grid_Customer_Consult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Grid_Customer_Consult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Grid_Customer_Consult.Items.Clear();

            Customer c;
            ListViewItem item;

            string where = "";

            if (Inpt_Customer_Name.Text != "")
                where += "AND NM_CUSTOMER LIKE '%" + Inpt_Customer_Name.Text + "%' ";

            if (Inpt_Social_Name.Text != "")
                where += "AND NM_SOCIAL LIKE '%" + Inpt_Social_Name.Text + "%' ";

            if (Inpt_Cnpj.Text != "  .   .   /    -")
                where += "AND NR_CPF_CNPJ = '" + Inpt_Cnpj.Text + "' ";

            if (Inpt_Cpf.Text != "   .   .   -")
                where += "AND NR_CPF_CNPJ = '" + Inpt_Cpf.Text + "' ";

            List<Object> list = CustomerDAO.GetInstance().GetCustomersByWhere(where);
            string[] row = new string[8];

            for (int count = 0; count < list.Count; count++)
            {
                c = (Customer) list[count];

                row[0] = Convert.ToString(c.GetIdCustomer());
                row[1] = c.GetNmCustomer();
                row[2] = c.GetNmSocial();
                row[3] = c.GetNrCpfCnpj();
                row[4] = c.GetNrInsc();
                row[5] = c.GetDsAddress();
                row[6] = c.GetNrPhone();
                row[7] = Convert.ToString(c.GetDtInsert()).Split(' ')[0];

                item = new ListViewItem(row);
                Grid_Customer_Consult.Items.Add(item);
            }

            foreach (ColumnHeader column in Grid_Customer_Consult.Columns)
            {
                column.Width = -2;
            }
        }

    }
}
