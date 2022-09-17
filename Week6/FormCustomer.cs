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
    public partial class FormCustomer : Form
    {
        private int currentSelectedRow = -1;
        private bool isUpdate = false;
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
             loadDgv();
            enable(false);
        }

        private void enable(bool enabled)
        {
            enableField(enabled);
            enableButton(enabled);
        }

        private void enableField(bool enabled)
        {
            txtName.Enabled = enabled;
            txtEmal.Enabled = enabled;
            txtPhoneNumber.Enabled = enabled;
        }

        private void enableButton(bool enabled)
        {
            btnInsert.Enabled = !enabled;
            btnUpdate.Enabled = !enabled;
            btnDelete.Enabled = !enabled;
            btnSave.Enabled = enabled;
            btnCancel.Enabled = enabled;
        }


        private void loadDgv()
        {
            dgv.Rows.Clear();

            DataClasses1DataContext dataClassesDataContext = new DataClasses1DataContext();
            IQueryable<Customer> customers = dataClassesDataContext.Customers;

            foreach (Customer customer in customers)
            {
                dgv.Rows.Add(customer.Id, customer.Name, customer.Email, customer.PhoneNumber);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearFieldData();
            setAutoId();
            enable(true);
            isUpdate = false;
        }

        private void setAutoId()
        {
            DataClasses1DataContext dataClassesDataContext = new DataClasses1DataContext();
            string lastId = dataClassesDataContext.Customers.OrderByDescending(x => x.Id).FirstOrDefault()?.Id;
            int intId = lastId == null || int.Parse(lastId.Substring(1, 4)) != DateTime.Now.Year ? 1 : int.Parse(lastId.Substring(5, 5)) + 1;
            txtID.Text = $"M{DateTime.Now.Year}{intId.ToString().PadLeft(5, '0')}";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            enable(true);
            isUpdate = true;
        }

        private bool checkAll()
        {
            if (txtName.Text.Trim() == "" || txtEmal.Text.Trim() == "" || txtPhoneNumber.Text.Trim() == "")
            {
                MessageBox.Show("All field must be filled!");
                return false;
            }

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentSelectedRow == -1)
            {
                MessageBox.Show("Please Select the Cell");
            }
            else
            {
                if (MessageBox.Show("Are YOu Sure Want Delete This Type?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataClasses1DataContext dataClassesDataContext = new DataClasses1DataContext();

                    Customer customer = dataClassesDataContext.Customers.Where(x => x.Id.Equals(txtID.Text)).FirstOrDefault();
                    dataClassesDataContext.Customers.DeleteOnSubmit(customer);

                    dataClassesDataContext.SubmitChanges();

                    loadDgv();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            enable(false);
            clearFieldData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dataClassesDataContext = new DataClasses1DataContext();
            if (checkAll())
            {
                if (isUpdate)
                {
                    Customer customer = dataClassesDataContext.Customers.Where(x => x.Id.Equals(txtID.Text)).FirstOrDefault();
                    customer.Name = txtName.Text;
                    customer.Email = txtEmal.Text;
                    customer.PhoneNumber = txtPhoneNumber.Text;

                    dataClassesDataContext.SubmitChanges();
                    reset();
                }
                else
                {
                    Customer customer = new Customer();
                    customer.Id = txtID.Text;
                    customer.Name = txtName.Text;
                    customer.Email = txtEmal.Text;
                    customer.PhoneNumber = txtPhoneNumber.Text;

                    bool emailExist = dataClassesDataContext.Customers.Any(x => x.Email.Equals(txtEmal.Text));
                    if (emailExist)
                    {
                        MessageBox.Show("Nggak boleh sama emailnya");
                    }
                    else
                    {
                        dataClassesDataContext.Customers.InsertOnSubmit(customer);
                        dataClassesDataContext.SubmitChanges();
                        reset();
                    }
                }
            }

        }

        private void reset()
        {
            loadDgv();
            enable(false);
            clearFieldData();
        }

        private void clearFieldData()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtEmal.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                currentSelectedRow = e.RowIndex;

                txtID.Text = dgv.Rows[currentSelectedRow].Cells[0].Value.ToString();
                txtName.Text = dgv.Rows[currentSelectedRow].Cells[1].Value.ToString();
                txtEmal.Text = dgv.Rows[currentSelectedRow].Cells[2].Value.ToString();
                txtPhoneNumber.Text = dgv.Rows[currentSelectedRow].Cells[3].Value.ToString();
            }
        }
    }
}
