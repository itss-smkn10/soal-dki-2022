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
    public partial class FormMerchandise : Form
    {
        private int currentSelectedRow = -1;
        private bool isUpdate = false;
        public FormMerchandise()
        {
            InitializeComponent();
        }

        private void FormMerchandise_Load(object sender, EventArgs e)
        {
            loadDgv();
            loadComboModel();
            enable(false);
        }

        private void enable(bool enabled)
        {
            enableField(enabled);
            enableButton(enabled);
        }

        private void enableField(bool enabled)
        {
            TextName.Enabled = enabled;
            TextSpec.Enabled = enabled;
            ComboModel.Enabled = enabled;
            NumericPrice.Enabled = enabled;
            NumericStock.Enabled = enabled;
        }

        private void enableButton(bool enabled)
        {
            BtnInsert.Enabled = !enabled;
            BtnUpdate.Enabled = !enabled;
            BtnDelete.Enabled = !enabled;
            Btnsave.Enabled = enabled;
            BtnCancel.Enabled = enabled;
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadDgv()
        {
            Dgv.Rows.Clear();
            DataClasses1DataContext dataClasesDataContext = new DataClasses1DataContext();
            IQueryable<Merchandise> merchandises = dataClasesDataContext.Merchandises.Where(n => n.Name.Contains(TextSearch.Text));

            foreach (Merchandise merchandise in merchandises)
            {
                Dgv.Rows.Add(merchandise.Id, merchandise.Name, merchandise.Model.Name, merchandise.Specification, merchandise.Price, merchandise.Stock, merchandise.ImagePath, merchandise.ModelId);
            }

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            clearFieldData();
            enable(true);
            isUpdate = false;
            setAutoMerchandise();
        }

        private void setAutoMerchandise()
        {
            DataClasses1DataContext dataClasesDataContext = new DataClasses1DataContext();
            String lastId = dataClasesDataContext.Merchandises.OrderByDescending(x => x.Id).FirstOrDefault().Id;
            int intId = int.Parse(lastId.Substring(2, 4)) + 1;
            TextId.Text = $"PR{intId.ToString().PadLeft(4, '0')}";
        }



        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (currentSelectedRow == -1)
            {
                MessageBox.Show("Please Select the Cell");
            }
            else
            {
                enable(true);
                isUpdate = true;
            }
        }

        private bool checkAll()
        {
            return true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
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

                    Merchandise merchandise = dataClassesDataContext.Merchandises.Where(x => x.Id.Equals(TextId.Text)).FirstOrDefault();
                    dataClassesDataContext.Merchandises.DeleteOnSubmit(merchandise);

                    dataClassesDataContext.SubmitChanges();
                    clearFieldData();

                    loadDgv();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            enable(false);
            clearFieldData();
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dataClassesDataContext = new DataClasses1DataContext();

            if (isUpdate)
            {
                Merchandise merchandise = dataClassesDataContext.Merchandises.Where(x => x.Id.Equals(TextId.Text)).FirstOrDefault();
                merchandise.Id = TextId.Text;
                merchandise.Name = TextName.Text;
                merchandise.ModelId = Convert.ToInt32(ComboModel.SelectedValue);
                merchandise.Price = Convert.ToInt32(NumericPrice.Value);
                merchandise.Stock = Convert.ToInt32(NumericStock.Value);
                merchandise.Specification = TextSpec.Text;
                merchandise.ImagePath = TextImage.Text;

                if (checkAll())
                {
                    dataClassesDataContext.SubmitChanges();
                    MessageBox.Show("Update Success!");
                }
            }
            else
            {
                Merchandise mer = new Merchandise();
                mer.Id = TextId.Text;
                mer.Name = TextName.Text;
                mer.ModelId = Convert.ToInt32(ComboModel.SelectedValue);
                mer.Price = Convert.ToInt32(NumericPrice.Value);
                mer.Stock = Convert.ToInt32(NumericStock.Value);
                mer.Specification = TextSpec.Text;
                mer.ImagePath = TextImage.Text;

                if (checkAll())
                {
                    dataClassesDataContext.Merchandises.InsertOnSubmit(mer);
                    dataClassesDataContext.SubmitChanges();
                    MessageBox.Show("Insert Success!");
                    loadDgv();
                }
            }
            loadDgv();
            enable(false);
            clearFieldData();
        }

        private void clearFieldData()
        {
            TextId.Text = "";
            TextName.Text = "";
            ComboModel.SelectedValue = "";
            NumericPrice.Value = 0;
            NumericStock.Value = 0;
            TextSpec.Text = "";
            currentSelectedRow = -1;
            TextImage.Text = "";
            pictureBox1.Image = null;
        }

        private void loadComboModel()
        {
            ComboModel.Items.Clear();

            DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
            ComboModel.DataSource = dataClasses1DataContext.Models;
            ComboModel.ValueMember = "Id";
            ComboModel.DisplayMember = "Name";
        }
        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void BtnPhoto_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextSearch_TextChanged_1(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentSelectedRow = e.RowIndex;

                TextId.Text = Dgv.Rows[currentSelectedRow].Cells[0].Value.ToString();
                TextName.Text = Dgv.Rows[currentSelectedRow].Cells[1].Value.ToString();
                TextSpec.Text = Dgv.Rows[currentSelectedRow].Cells[3].Value.ToString();
                ComboModel.SelectedValue = Convert.ToInt32(Dgv.Rows[currentSelectedRow].Cells[7].Value);
                NumericPrice.Value = Convert.ToInt32(Dgv.Rows[currentSelectedRow].Cells[4].Value);
                NumericStock.Value = Convert.ToInt32(Dgv.Rows[currentSelectedRow].Cells[5].Value);
                TextImage.Text = Dgv.Rows[currentSelectedRow].Cells[6].Value.ToString();

                string imagePath = Dgv.Rows[currentSelectedRow].Cells[6].Value.ToString();

                if (imagePath != null)
                {
                    string path = $@"C:\Users\SMKN 10\Pictures\Merchandise Pict\{imagePath}";
                    pictureBox1.ImageLocation = path;
                }
            }
        }

        private void BtnPhoto_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG File|*.jpg|PNG File|*.png|All File(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                TextImage.Text = openFileDialog1.SafeFileName;
            }
        }
    }
}


