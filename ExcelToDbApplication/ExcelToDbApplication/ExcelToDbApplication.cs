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
    public partial class ExcelToDatabase : Form
    {
        public ExcelToDatabase()
        {
            InitializeComponent();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSource_Click(object sender, EventArgs e)
        {

        }

        private void BtnDestination_Click(object sender, EventArgs e)
        {

        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {

        }

        private void createDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseSetting cDatabaseWindow = new DatabaseSetting();
            cDatabaseWindow.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
