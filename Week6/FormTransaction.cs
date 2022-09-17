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
    public partial class FormTransaction : Form
    {
        private DataGridViewRowCollection data;

        public FormTransaction(DataGridViewRowCollection data)
        {
            InitializeComponent();
            this.data = data;
        }


        private void FormTransaction_Load(object sender, EventArgs e)
        {
            BtnPay.Enabled = false;
            generateTotal();
        }



        private void BtnCheck_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dataClasesDataContext = new DataClasses1DataContext();

            if (TextCID.Text != null)
            {
                bool customerIdExist = dataClasesDataContext.Customers.Any(x => x.Id.Equals(TextCID.Text));
                if (customerIdExist)
                {
                    BtnPay.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Customer kagak ada");
                }
            }

        }

        private void generateTotal()
        {
            int a = 0;
            for (int i = 0; i < data.Count; i++)
            {
                a += Convert.ToInt32(data[i].Cells[5].Value);
            }

            LabelTotal.Text = $"{a.ToString("N")}";
        }

        private void RadioCash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnPay_Click(object sender, EventArgs e)
        {

            if (RadioCash.Checked && TextCardNumber.Text != "")
            {
                MessageBox.Show("Card Number Gak Perlu Diisi");
            }
            else if (RadioCard.Checked && TextCardNumber.Text == "")
            {
                MessageBox.Show("Card Number Wajib Diisi!");
            }
            else
            {
                DataClasses1DataContext db = new DataClasses1DataContext();

                SalesHeader salesHeader = new SalesHeader();
                String lastId = db.SalesHeaders.OrderByDescending(x => x.Id).FirstOrDefault()?.Id;

                int intId = lastId != null ? (int.Parse(lastId.Substring(6, 5)) + 1) : 1;
                salesHeader.Id = $"{DateTime.Now.Year}{DateTime.Now.Month.ToString().PadLeft(2, '0')}{intId.ToString().PadLeft(5, '0')}"; ;
                salesHeader.CustomerId = TextCID.Text;
                salesHeader.AdministratordId = DataStorage.administratorId;
                salesHeader.PaymentType = RadioCash.Checked ? "cash" : "card";

                db.SalesHeaders.InsertOnSubmit(salesHeader);
                db.SubmitChanges();

                for (int i = 0; i < data.Count; i++)
                {
                    SalesDetail salesDetail = new SalesDetail();
                    salesDetail.SalesHeaderId = salesHeader.Id;
                    salesDetail.MerchandiseId = data[i].Cells[0].Value.ToString();
                    salesDetail.Qty = Convert.ToInt32(data[i].Cells[3].Value.ToString());
                    salesDetail.Price = Convert.ToInt32(data[i].Cells[4].Value.ToString());

                    db.SalesDetails.InsertOnSubmit(salesDetail);
                    db.SubmitChanges();             
                }
                this.Close();
            }



        }
    }
}
