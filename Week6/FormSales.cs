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
    public partial class FormSales : Form
    {
        private int currentSelectedRow = -1;

        public FormSales()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loaddgv1();
            enable(false);
        }

        private void enable(bool enabled)
        {
            TextQty.Enabled = enabled;
            BtnAdd.Enabled = enabled;
        }

        private void loaddgv1()
        {
            dgv1.Rows.Clear();
            DataClasses1DataContext dataClasesDataContext = new DataClasses1DataContext();
            IQueryable<Merchandise> merchandises = dataClasesDataContext.Merchandises.Where(n => n.Name.Contains(TextSearch.Text));

            foreach (Merchandise merchandise in merchandises)
            {
                dgv1.Rows.Add(merchandise.Id, merchandise.Name, merchandise.Model.Name, merchandise.Specification, merchandise.Price, merchandise.ImagePath, merchandise.ModelId);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (BtnAdd.Text == "Add")
            {
                var dgvMerchandiseRows = dgv1.Rows[currentSelectedRow];
                for (int i = 0; i < dgv2.RowCount; i++)
                {
                    if (dgv2.Rows[i].Cells[0].Value == dgv1.Rows[currentSelectedRow].Cells[0].Value)
                    {
                        int Qty = Convert.ToInt32(dgv2.Rows[i].Cells[3].Value);

                        dgv2.Rows[i].Cells[3].Value = Qty + Convert.ToInt32(TextQty.Text);
                        dgv2.Rows[i].Cells[5].Value = Convert.ToInt32(dgv2.Rows[i].Cells[3].Value) * Convert.ToInt32(TextPrice.Text);
                        generateTotal();
                        return;

                    }
                }

                dgv2.Rows.Add(
                    dgv1.Rows[currentSelectedRow].Cells[0].Value.ToString(),
                    dgv1.Rows[currentSelectedRow].Cells[1].Value.ToString(),
                    dgv1.Rows[currentSelectedRow].Cells[2].Value.ToString(),
                    TextQty.Text,
                    TextPrice.Text,
                    Convert.ToInt32(TextPrice.Text) * Convert.ToInt32(TextQty.Text)

                );
            }

            else if (BtnAdd.Text == "edit")
            {
                dgv2.Rows[currentSelectedRow].Cells[3].Value = Convert.ToInt32(TextQty.Text);
                dgv2.Rows[currentSelectedRow].Cells[5].Value = Convert.ToInt32(dgv2.Rows[currentSelectedRow].Cells[3].Value) * Convert.ToInt32(TextPrice.Text);
            }
            clearFieldData();
            generateTotal();
        }

        private void clearFieldData()
        {
            TextName.Text = "";
            TextPrice.Text = "";
            TextQty.Text = "";
            pictureBox1.Image = null;
            currentSelectedRow = -1;
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BtnAdd.Text = "Add";
                currentSelectedRow = e.RowIndex;

                TextName.Text = dgv1.Rows[currentSelectedRow].Cells[1].Value.ToString();
                TextPrice.Text = dgv1.Rows[currentSelectedRow].Cells[4].Value.ToString();

                string imagePath = dgv1.Rows[currentSelectedRow].Cells[5].Value.ToString();

                if (imagePath != null)
                {
                    string path = $@"C:\Users\SMKN 10\Pictures\Merchandise Pict\{imagePath}";
                    pictureBox1.ImageLocation = path;
                }

                enable(true);
            }
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    dgv2.Rows.RemoveAt(e.RowIndex);
                    generateTotal();
                    BtnAdd.Text = "Add";
                    clearFieldData();
           
                    enable(false);
                }
                else
                {
                    BtnAdd.Text = "edit";
                    currentSelectedRow = e.RowIndex;

                    TextName.Text = dgv2.Rows[currentSelectedRow].Cells[1].Value.ToString();
                    TextQty.Text = dgv2.Rows[currentSelectedRow].Cells[3].Value.ToString();
                    TextPrice.Text = dgv2.Rows[currentSelectedRow].Cells[4].Value.ToString();

                    string imagePath = dgv1.Rows[currentSelectedRow].Cells[5].Value.ToString();

                    if (imagePath != null)
                    {
                        string path = $@"C:\Users\SMKN 10\Pictures\Merchandise Pict\{imagePath}";
                        pictureBox1.ImageLocation = path;
                    }

                    enable(true);
                }
            }
        }


        private void generateTotal()
        {
            int a = 0;
            for (int i = 0; i < dgv2.RowCount; i++)
            {
                a += Convert.ToInt32(dgv2.Rows[i].Cells[5].Value);
            }

            LabelTotal.Text = $"Total: {a.ToString("N")}";
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            FormTransaction mainForm = new FormTransaction(dgv2.Rows);
            mainForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            loaddgv1();
        }
    }
}
