using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Week6
{
    public partial class FormAdministrator : Form
    {
        private bool isUpdate = false;
        public FormAdministrator()
        {
            InitializeComponent();
        }

        private void FormAdministrator_Load(object sender, EventArgs e)
        {
            loaddataGridView1();
            loadcomboBox1();
            setAutoId();
            enable(false);
            
        }

        private bool CheckAll()
        {
            Regex regex = new Regex(@"^+.+@.+\..+$");
            if (TextPassword.Text != TextConfirm.Text)
            {
                MessageBox.Show("Password and Confirm Password Must be Same!");
                return false;

            }

            else if (TextName.Text.Trim() == "")
            {
                MessageBox.Show("Name Must be Filled");
                return false;
            }

            else if (TextEmail.Text.Trim() == "")
            {
                MessageBox.Show("Email Must be Filled");
                return false;
            }


            else if (TextPassword.Text.Trim() == "")
            {
                MessageBox.Show("Password Must be Filled");
                return false;
            }

            else if (TextConfirm.Text.Trim() == "")
            {
                MessageBox.Show("Password Must be Filled and Same With Your Password");
                return false;
            }

            else if (TextPhoneNumber.Text.Trim() == "")
            {
                MessageBox.Show("Phone Number Must be Filled");
                return false;
            }

            else if (DateTime.Now.Year - TextBirthDate.Value.Year < 18)
            {
                MessageBox.Show("you must be 18 years old ");
                return false;
            }

            else if (!regex.IsMatch(TextEmail.Text))
            {
                MessageBox.Show("Email Format doesn't Valid");
                return false;
            }

            return true;


        }
        private void setAutoId()
        {
            DataClasses1DataContext dataClasesDataContext = new DataClasses1DataContext();
            int lastId = dataClasesDataContext.Administrators.OrderByDescending(x => x.Id).FirstOrDefault().Id;
            int intId = lastId + 1;
            TextId.Text = intId.ToString();
        }

        private void enable(bool enabled)
        {
            enableField(enabled);
            enableButton(enabled);
        }

        private void enableField(bool enabled)
        {
            TextId.Enabled = enabled;
            TextName.Enabled = enabled;
            TextEmail.Enabled = enabled;
            TextPhoneNumber.Enabled = enabled;
            TextBirthDate.Enabled = enabled;
            comboBox1.Enabled = enabled;
            TextPassword.Enabled = enabled;
            TextConfirm.Enabled = enabled;
        }

        private void enableButton(bool enabled)
        {
            button1.Enabled = !enabled;
            button2.Enabled = !enabled;
            button3.Enabled = !enabled;
            button4.Enabled = enabled;
            button5.Enabled = enabled;
        }



        int dataGridViewSelectedRow = -1;
        static DataClasses1DataContext sqlConnection = new DataClasses1DataContext(@"Data Source=DESKTOP-RNJ6567;Initial Catalog=week_2_ITSS;Integrated Security=True");

        private void loadcomboBox1()
        {
            comboBox1.Items.Clear();


            DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
            comboBox1.DataSource = dataClasses1DataContext.Roles;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "name";
        }

        private void loaddataGridView1()
        {
            dataGridView1.Rows.Clear();

            DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
            IQueryable<Administrator> administrators = dataClasses1DataContext.Administrators.Where(n => n.Name.Contains(TextSearch.Text));

            foreach (Administrator administrator in administrators)
            {
                dataGridView1.Rows.Add(administrator.Id, administrator.Name, administrator.Email, administrator.PhoneNumber, administrator.BirthDate, administrator.RoleId, administrator.Password, administrator.PhoneNumber, administrator.RoleId);
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public static bool EmailIsValid(string email)

        {
            string expression = @"^+.+@.+\..+$";

            if (Regex.IsMatch(email, expression))
            {
                if (Regex.Replace(email, expression, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clearFieldData();
            enable(true);
            isUpdate = false;
            setAutoId();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewSelectedRow != -1)
            {
                enable(true);
                isUpdate = true;
            }
            else
            {
                MessageBox.Show("Please click that row!");
            }

        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            loaddataGridView1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewSelectedRow == -1)
            {
                MessageBox.Show("Please Select the Cell");
            }
            else
            {
                if(MessageBox.Show("Are YOu Sure Want Delete This Type?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();

                    Administrator adm = dataClasses1DataContext.Administrators.Where(x => x.Id.Equals(TextId.Text)).FirstOrDefault();
                    dataClasses1DataContext.Administrators.DeleteOnSubmit(adm);

                    dataClasses1DataContext.SubmitChanges();
                    MessageBox.Show("Delete Success!");


                    loaddataGridView1();
                }
            }
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSelectedRow = e.RowIndex;

            TextId.Text = dataGridView1.Rows[dataGridViewSelectedRow].Cells[0].Value.ToString();
            TextName.Text = dataGridView1.Rows[dataGridViewSelectedRow].Cells[1].Value.ToString();
            TextEmail.Text = dataGridView1.Rows[dataGridViewSelectedRow].Cells[2].Value.ToString();
            TextPhoneNumber.Text = dataGridView1.Rows[dataGridViewSelectedRow].Cells[3].Value.ToString();
            TextBirthDate.Value = Convert.ToDateTime(dataGridView1.Rows[dataGridViewSelectedRow].Cells[4].Value);
            comboBox1.SelectedValue = dataGridView1.Rows[dataGridViewSelectedRow].Cells[5].Value;
            TextPassword.Text = dataGridView1.Rows[dataGridViewSelectedRow].Cells[6].Value.ToString();
            TextConfirm.Text = dataGridView1.Rows[dataGridViewSelectedRow].Cells[6].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enable(false);
            clearFieldData();

        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            loaddataGridView1();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
            if (isUpdate)
            {
                Administrator adm = dataClasses1DataContext.Administrators.Where(x => x.Id.Equals(TextId.Text)).FirstOrDefault();
                adm.Name = TextName.Text;
                adm.Email = TextEmail.Text;
                adm.PhoneNumber = TextPhoneNumber.Text;
                adm.Password = TextPassword.Text;
                adm.BirthDate = TextBirthDate.Value;
                adm.RoleId = Convert.ToInt32(comboBox1.SelectedValue);

                if (CheckAll())
                {
                    dataClasses1DataContext.SubmitChanges();
                    MessageBox.Show("Update Success!");
                }


            }
            else
            {
                Administrator adm = new Administrator();
                adm.PhoneNumber = TextPhoneNumber.Text;
                adm.Email = TextEmail.Text;
                adm.Name = TextName.Text;
                adm.Password = TextPassword.Text;
                adm.BirthDate = TextBirthDate.Value;
                adm.RoleId = Convert.ToInt32(comboBox1.SelectedValue);


                bool emailExist = dataClasses1DataContext.Administrators.Any(x => x.Email.Equals(TextEmail.Text));
                if (emailExist)
                {
                    MessageBox.Show("That Email Already Used");
                }
                else if (CheckAll())
                {
                    dataClasses1DataContext.Administrators.InsertOnSubmit(adm);
                    dataClasses1DataContext.SubmitChanges();
                    MessageBox.Show("Insert Success!");
                    loaddataGridView1();
                }

            }
            loaddataGridView1();
            enable(false);
            clearFieldData();
        }

        private void TextId_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearFieldData()
        {

            TextId.Text = "";
            TextName.Text = "";
            TextEmail.Text = "";
            TextPhoneNumber.Text = "";
            TextBirthDate.Value = DateTime.Now;
            comboBox1.SelectedValue = 1;
            TextPassword.Text = "";
            TextConfirm.Text = "";
        }

        private void TextSearch_TextChanged_1(object sender, EventArgs e)
        {
            loaddataGridView1();
        }
    }

}

