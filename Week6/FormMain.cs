using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        private void FormMain_Load(object sender, EventArgs e)
        {
            if (DataStorage.administratorRole != "Manager")
            {
                FileAdministrator.Visible = false;
                FileModel.Visible = false;
                FileMerchandise.Visible = false;
            }
        }  

        private void FileLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FileCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer Customer = new FormCustomer();
            Customer.MdiParent = this;
            Customer.Show();
        }

        private void FileSales_Click(object sender, EventArgs e)
        {
            FormSales sales = new FormSales();
            sales.MdiParent = this;
            sales.Show();
        }

        private void FileAdministrator_Click(object sender, EventArgs e)
        {
            FormAdministrator administrator = new FormAdministrator();
            administrator.MdiParent = this;
            administrator.Show();
        }

        private void FileMerchandise_Click(object sender, EventArgs e)
        {
            FormMerchandise merchandise = new FormMerchandise();
            merchandise.MdiParent = this;
            merchandise.Show();
        }

        private void FileModel_Click(object sender, EventArgs e)
        {
            FormModel model = new FormModel();
            model.MdiParent = this;
            model.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
