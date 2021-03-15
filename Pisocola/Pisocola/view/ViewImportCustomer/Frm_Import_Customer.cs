using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pisocola.com.model;
using Pisocola.com.dao;
using Pisocola.com.util;

namespace Pisocola
{
    public partial class Frm_Import_Customer : Form
    {
        public Frm_Import_Customer()
        {
            InitializeComponent();
            Btn_Import.Visible = false;
        }

        private List<Customer> customers;

        private bool validToImport = true;
        private string importFolderPath = "";
        private string currentPath = "";

        private void Btn_Select_File_Click(object sender, EventArgs e)
        {
            validToImport = true;

            OpenFileDialog ofd = new OpenFileDialog();
            Parameter path = ParameterDAO.GetInstance().GetParameterByTopicAndName("CUSTOMER_IMPORT", "IMPORT_PATH");

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string extension = System.IO.Path.GetExtension(@ofd.FileName);

                if (extension == ".csv")
                {
                    currentPath = @ofd.FileName;
                    importFolderPath = path.GetVlValue() + ofd.SafeFileName;

                    Console.WriteLine("CAMINHO ATUAL: " + currentPath);
                    Console.WriteLine("CAMINHO DESTINO: " + importFolderPath);

                    string[] lines = System.IO.File.ReadAllLines(currentPath);

                    List<Dictionary<string, string>> data = ImportCustomerDAO.PreviewImportCustomer(lines);
                    LoadListViews(data);
                }
                else
                {
                    MessageBox.Show("O arquivo deve ser CSV.", "Atenção!");
                }
            }
        }

        private void Btn_Import_Click(object sender, EventArgs e)
        {
            if(validToImport)
            {
                foreach (Customer c in customers)
                {
                    CustomerDAO.GetInstance().InsertCustomer(c);
                }

                File.Move(currentPath, importFolderPath);

                currentPath = "";
                importFolderPath = "";
                customers = null;

                ClearColumns();
                Btn_Import.Visible = false;

                MessageBox.Show("Seus novos clientes foram importados.", "Sucesso!");
            }
            else
            {
                MessageBox.Show("Ainda existem linhas com erro.", "Atenção!");
            }
        }

        private void LoadListViews(List<Dictionary<string, string>> list)
        {
            ClearColumns();

            Customer c;
            ListViewItem item;
            ListViewItem errorItem;
            customers = new List<Customer>();

            int nrLine = 1;
            string[] row = new string[7];
            string[] errorRow = new string[2];

            bool columnsError = list[0].ContainsKey("NUMBER_OF_COLUMNS_ERROR");

            if (!columnsError)
            {
                Btn_Import.Visible = true;

                foreach (Dictionary<string, string> line in list)
                {
                    row[0] = Convert.ToString(nrLine);
                    row[1] = line["NM_CUSTOMER"];
                    row[2] = line["NM_SOCIAL"];
                    row[3] = line["NR_CPF_CNPJ"];
                    row[4] = line["NR_INSC"];
                    row[5] = line["DS_ADDRESS"];
                    row[6] = line["NR_PHONE"];

                    c = new Customer();

                    c.SetNmCustomer(row[1]);
                    c.SetNmSocial(row[2]);
                    c.SetNrCpfCnpj(row[3]);
                    c.SetNrInsc(row[4]);
                    c.SetDsAddress(row[5]);
                    c.SetNrPhone(row[6]);

                    customers.Add(c);

                    item = new ListViewItem(row);
                    Grid_Import_Lines.Items.Add(item);

                    foreach (KeyValuePair<string, string> entry in line)
                    {
                        if (entry.Key.Contains("_ERROR"))
                        {
                            validToImport = false;

                            errorRow[0] = Convert.ToString(nrLine);
                            errorRow[1] = line[entry.Key];

                            errorItem = new ListViewItem(errorRow);
                            Grid_Invalid_Lines.Items.Add(errorItem);
                        }
                    }

                    nrLine++;
                }

                foreach (ColumnHeader column in Grid_Import_Lines.Columns)
                {
                    column.Width = -2;
                }

                foreach (ColumnHeader column in Grid_Invalid_Lines.Columns)
                {
                    column.Width = -2;
                }
            }
            else
            {
                Btn_Import.Visible = false;
                MessageBox.Show("O arquivo não contém o número de colunas necessário.", "Atenção!");
            }
        }

        private void ClearColumns()
        {
            Grid_Import_Lines.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Grid_Import_Lines.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Grid_Import_Lines.Items.Clear();

            Grid_Invalid_Lines.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Grid_Invalid_Lines.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Grid_Invalid_Lines.Items.Clear();
        }
    }
}
