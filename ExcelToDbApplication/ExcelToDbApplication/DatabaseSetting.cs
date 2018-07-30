using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToDbApplication
{
    public partial class DatabaseSetting : Form
    {
        public bool bDbCreatedSuccessfully_ = false;


        public DatabaseSetting()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!isFieldCompleted()) {
                MessageBox.Show("Please fill the fields completely",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            //create database
            DatabaseManager cConvert = new DatabaseManager();
            DatabaseManager.CreateDatabaseParam tDbParam;

            //complete required parameters for database creation
            tDbParam.sDbName = textDatabaseName.Text;
            tDbParam.sPath = textPath.Text;
            tDbParam.sMDfSize = textMdfSize.Text;
            tDbParam.sMDFMaxSize = textMdfMaxSize.Text;
            tDbParam.sMDFPercentFileGrowth = textMdfFileGrowth.Text;
            tDbParam.sLDFSize = textLdfSize.Text;
            tDbParam.sLDFMaxSize = textLdfMaxSize.Text;
            tDbParam.sIDFPercentFileGrowth = textLdfFileGrowth.Text;

            // Execute create database
            if(cConvert.createDatabase(tDbParam)) {
                MessageBox.Show("Database created succeessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Database created succeessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //close
            this.Close();
        }

        private void DatabaseSetting_Load(object sender, EventArgs e)
        {

            //inititalize water mark
            textDatabaseName.ForeColor = Color.Gray;
            textDatabaseName.Text = "i.e. myDatabase";
            textDatabaseName.Select(textDatabaseName.TextLength, 0);

            textPath.ForeColor = Color.Gray;
            textPath.Text = "i.e. D:\\Folder/Subfolder/";
            textPath.Select(textPath.TextLength, 0);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textDatabaseName.ForeColor = Color.Black;
            textDatabaseName.Select(textDatabaseName.TextLength, 0);
        }

        private bool isFieldCompleted()
        {
            //validate fields
            if (String.IsNullOrEmpty(textDatabaseName.Text)
            || String.IsNullOrEmpty(textPath.Text)
            || String.IsNullOrEmpty(textMdfSize.Text)
            || String.IsNullOrEmpty(textMdfMaxSize.Text)
            || String.IsNullOrEmpty(textMdfFileGrowth.Text)
            || String.IsNullOrEmpty(textLdfSize.Text)
            || String.IsNullOrEmpty(textLdfMaxSize.Text)
            || String.IsNullOrEmpty(textLdfFileGrowth.Text))
                return false;
            return true;
        }
    }
}
