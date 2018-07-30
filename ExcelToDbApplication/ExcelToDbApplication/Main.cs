using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExcelToDbApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            ExcelManager cExcel = new ExcelManager();
            ExcelManager.ExcelReadParam tInput;
            ExcelManager.ExcelOutputParam tExcelReadResult;

            string sTemp3 = "";

            tInput.sFileName = "myTransaction.xlsx";
            tInput.sDirectory = "D:\\draft/";

            tExcelReadResult = cExcel.OpenExcelFile(tInput);

            String sTemp = "";

            foreach(DatabaseManager.TableFieldParam tELem in tExcelReadResult.tCreateTableParamRes.vsFields) {
                sTemp += tELem.sName;
            }

            MessageBox.Show(sTemp, "TableFieldParam.sName", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int iLen = 0;
            sTemp = "";
            foreach (DatabaseManager.AddTableItemContentParam tELem in tExcelReadResult.vsAddTableItemContentParamRes) {
                iLen += tELem.vsTableContent.Count();
                foreach (DatabaseManager.TableContent tElem2 in tELem.vsTableContent) {
                    sTemp3 = "Nadaanan ako";
                    sTemp += tElem2.FieldContent;
                }

                sTemp += "\n";
            }

            MessageBox.Show(sTemp, "TableContent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;


            // if ((textUserName.Text == "JOSEPH") && (textPassword.Text == "123456")) {
            ExcelToDatabase cExcelToDbApp = new ExcelToDatabase();
               this.Hide();
               cExcelToDbApp.ShowDialog();
               this.Show();
            // }
            //  else
            //  {
            //      MessageBox.Show("Invalid Username/Password","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            // }

  
        }
    }
}
