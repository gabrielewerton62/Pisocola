using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pisocola.com.dao;
using Pisocola.com.model;
using Pisocola.com.util;

namespace Pisocola.com.dao
{
    class ImportCustomerDAO
    {

        public static List<Dictionary<string, string>> PreviewImportCustomer(string[] lines)
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> errorList = GetCustomerImportErrorList();

            //Numero de colunas do CSV
            int numberOfColumns = lines[0].Split(';').Length;
            string[] columns;

            string nmCustomer = "";
            string nmSocial = "";
            string nrCpfCnpj = "";
            string nrInsc = "";
            string dsAddress = "";
            string nrPhone = "";

            //CSV deve conter obrigatoriamente 6 colunas de informacao

            if (numberOfColumns != 6)
            {
                rows.Add(errorList);
                return rows;
            }

            //Percorrendo linhas do CSV para fazer as devidas validacoes de informacao
            foreach (string line in lines)
            {
                Dictionary<string, string> row = new Dictionary<string, string>();
                columns = line.Split(';');

                nmCustomer = columns[0];
                nmSocial = columns[1];
                nrCpfCnpj = columns[2];
                nrInsc = columns[3];
                dsAddress = columns[4];
                nrPhone = columns[5];

                bool cpfCnpjFormat = Util.ValidateCpfCnpj(nrCpfCnpj);
                bool cpfCnpjExists = CustomerDAO.GetInstance().VerifyCpfCnpj(nrCpfCnpj);

                //Validando formatacao de CPF/CNPJ
                if (!cpfCnpjFormat)
                {
                    row.Add("NR_CPF_CNPJ_FORMAT_ERROR", errorList["NR_CPF_CNPJ_FORMAT_ERROR"]);
                }

                //Verificando se o CPF/CNPJ ja esta cadastrado
                if (cpfCnpjExists)
                {
                    row.Add("NR_CPF_CNPJ_EXISTS_ERROR", errorList["NR_CPF_CNPJ_EXISTS_ERROR"]);
                }

                row.Add("NR_CPF_CNPJ", nrCpfCnpj);

                //Validando formatacao de numero de telefone
                bool nrPhoneIsValid = Util.ValidateNrPhone(nrPhone);

                if (!nrPhoneIsValid)
                {
                    row.Add("NR_PHONE_FORMAT_ERROR", errorList["NR_PHONE_FORMAT_ERROR"]);
                }

                row.Add("NR_PHONE", nrPhone);

                //Validando formatacao de numero de inscricao
                bool nrInscIsValid = Util.ValidateNrInsc(nrInsc);

                if (!nrInscIsValid)
                {
                    row.Add("NR_INSC_FORMAT_ERROR", errorList["NR_INSC_FORMAT_ERROR"]);
                }

                row.Add("NR_INSC", nrInsc);

                //Adicionando demais campos sem validacao de formato
                row.Add("NM_CUSTOMER", nmCustomer);
                row.Add("NM_SOCIAL", nmSocial);
                row.Add("DS_ADDRESS", dsAddress);

                rows.Add(row);
            }

            return rows;
        }

        public static Dictionary<string, string> GetCustomerImportErrorList()
        {
            List<Object> errorList = ParameterDAO.GetInstance().GetParameterByTopic("CUSTOMER_IMPORT_ERROR");
            Dictionary<string, string> errors = new Dictionary<string, string>();
            Parameter obj;

            foreach (Object error in errorList)
            {
                obj = (Parameter) error;
                errors.Add(obj.GetNmParameter(), obj.GetVlValue());
            }

            return errors;
        }

    }
}
