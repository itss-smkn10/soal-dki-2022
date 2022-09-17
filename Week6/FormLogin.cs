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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            Administrator admin = db.Administrators.Where(n => n.Email.Equals(TextEmail.Text) && n.Password.Equals(TextPassword.Text)).FirstOrDefault();
            if(admin != null)
            {
                DataStorage.administratorId = admin.Id;
                DataStorage.administratorRole = admin.Role.name;

                FormMain formMain = new FormMain();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ur email or password is wrong!");
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }

} 
