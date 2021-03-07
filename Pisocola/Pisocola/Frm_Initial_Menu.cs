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
using System.Text.RegularExpressions;

namespace Pisocola
{
    public partial class Frm_Initial_Menu : Form
    {
        public Frm_Initial_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<Object> list = CustomerDAO.GetInstance().GetCustomers();
            
            //Customer customer = (Customer)list[0];

            //Customer customerGet = CustomerDAO.GetInstance().GetCustomer(1);

            Customer customerIns = new Customer();

            customerIns.SetIdCustomer(10);
            customerIns.SetNmCustomer("NOME DO CLIENTE");
            customerIns.SetNmSocial("ARGAMASA PERNAMBUCO");
            customerIns.SetNrCpfCnpj("555.555.555-78");
            customerIns.SetNrInsc("9999999-09");
            customerIns.SetDsAddress("AV. COSTA AZUL, 320");
            customerIns.SetNrPhone("98534-4236");

            Customer updated = CustomerDAO.GetInstance().UpdateCustomer(customerIns);

            Customer inserted = CustomerDAO.GetInstance().InsertCustomer(customerIns);

            //CustomerDAO.GetInstance().DeleteCustomer(customerIns);

            //Console.WriteLine("NOME DO CLIENTE: " + updated.GetNmCustomer());
        }
    }
}
