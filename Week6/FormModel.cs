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
    public partial class FormModel : Form
    {
        private int currentSelectedRow = -1;
        private bool isUpdate = false;
        public FormModel()
        {
            InitializeComponent();
        }

        private void FormModel_Load(object sender, EventArgs e)
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
            IQueryable<Model> models = dataClassesDataContext.Models.Where(n => n.Name.Contains(TextSearch.Text));


            foreach (Model mdl in models)
            {
                dgv.Rows.Add(mdl.Id, mdl.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearFieldData();
            enable(true);
            setAutoId();
            isUpdate = false;
        }

        private void setAutoId()
        {
            DataClasses1DataContext dataClasesDataContext = new DataClasses1DataContext();
            int lastId = dataClasesDataContext.Models.OrderByDescending(x => x.Id).FirstOrDefault().Id;
            int intId = lastId + 1;
            txtID.Text = intId.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            enable(true);
            isUpdate = true;
        }

        private bool checkAll()
        {
            return true;

            if(txtName.Text.Trim() == "")
            {
                MessageBox.Show("Name Must be Filled");
                return false;
            }

            else if(txtName.Text.Trim() == "")
            {
                MessageBox.Show("ID Must be Filled");
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentSelectedRow == -1)
            {
                MessageBox.Show("Please Select the Cell");
            }
            else
            {
                if(MessageBox.Show("Are YOu Sure Want Delete This Type?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataClasses1DataContext dataClassesDataContext = new DataClasses1DataContext();

                    Model models = dataClassesDataContext.Models.Where(x => x.Id.Equals(txtID.Text)).FirstOrDefault();
                    dataClassesDataContext.Models.DeleteOnSubmit(models);

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
                    Model mdl = dataClassesDataContext.Models.Where(x => x.Id.Equals(txtID.Text)).FirstOrDefault();
                    mdl.Id = Convert.ToInt32(txtID.Text);
                    mdl.Name = txtName.Text;

                    dataClassesDataContext.SubmitChanges();
                }
                else
                {
                    Model mdl = new Model();
                    mdl.Id = Convert.ToInt32(txtID.Text);
                    mdl.Name = txtName.Text;
                    dataClassesDataContext.Models.InsertOnSubmit(mdl); ;
                    dataClassesDataContext.SubmitChanges();

                }
                loadDgv();
                enable(false);
                clearFieldData();
            }
            
        }

        private void clearFieldData()
        {
            txtID.Text = "";
            txtName.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentSelectedRow = e.RowIndex;

                txtID.Text = dgv.Rows[currentSelectedRow].Cells[0].Value.ToString();
                txtName.Text = dgv.Rows[currentSelectedRow].Cells[1].Value.ToString();
            }
        }
    }
}
