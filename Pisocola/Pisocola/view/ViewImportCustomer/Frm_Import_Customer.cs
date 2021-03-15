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
        }

        private void Btn_Select_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Parameter path = ParameterDAO.GetInstance().GetParameterByTopicAndName("CUSTOMER_IMPORT", "IMPORT_PATH");

            string importFolderPath = "";
            string currentPath = "";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                currentPath = @ofd.FileName;
                importFolderPath = path.GetVlValue() + ofd.SafeFileName;

                Console.WriteLine("CAMINHO ATUAL: " + currentPath);
                Console.WriteLine("CAMINHO DESTINO: " + importFolderPath);

                //File.Move(currentPath, importFolderPath);

                string[] lines = System.IO.File.ReadAllLines(importFolderPath);

                List<Dictionary<string, string>> data = ImportCustomerDAO.PreviewImportCustomer(lines);
                LoadListViews(data);
            }
        }

        private void LoadListViews(List<Dictionary<string, string>> list)
        {
            Grid_Import_Lines.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Grid_Import_Lines.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Grid_Import_Lines.Items.Clear();

            Grid_Invalid_Lines.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Grid_Invalid_Lines.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Grid_Invalid_Lines.Items.Clear();

            ListViewItem item;
            ListViewItem errorItem;

            int nrLine = 1;
            string[] row = new string[7];
            string[] errorRow = new string[2];

            foreach (Dictionary<string, string> line in list)
            {
                row[0] = Convert.ToString(nrLine);
                row[1] = line["NM_CUSTOMER"];
                row[2] = line["NM_SOCIAL"];
                row[3] = line["NR_CPF_CNPJ"];
                row[4] = line["NR_INSC"];
                row[5] = line["DS_ADDRESS"];
                row[6] = line["NR_PHONE"];

                item = new ListViewItem(row);
                Grid_Import_Lines.Items.Add(item);

                foreach (KeyValuePair<string, string> entry in line)
                {
                    if(entry.Key.Contains("_ERROR"))
                    {
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
    }
}
