namespace Week6
{
    partial class FormTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LabelCID = new System.Windows.Forms.Label();
            this.TextCID = new System.Windows.Forms.TextBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.LabelT = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.LabelPayment = new System.Windows.Forms.Label();
            this.RadioCash = new System.Windows.Forms.RadioButton();
            this.RadioCard = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TextCardNumber = new System.Windows.Forms.TextBox();
            this.BtnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Form";
            // 
            // LabelCID
            // 
            this.LabelCID.AutoSize = true;
            this.LabelCID.Location = new System.Drawing.Point(29, 68);
            this.LabelCID.Name = "LabelCID";
            this.LabelCID.Size = new System.Drawing.Size(65, 13);
            this.LabelCID.TabIndex = 1;
            this.LabelCID.Text = "Customer ID";
            // 
            // TextCID
            // 
            this.TextCID.Location = new System.Drawing.Point(116, 65);
            this.TextCID.Name = "TextCID";
            this.TextCID.Size = new System.Drawing.Size(153, 20);
            this.TextCID.TabIndex = 2;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(306, 62);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(75, 23);
            this.BtnCheck.TabIndex = 3;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // LabelT
            // 
            this.LabelT.AutoSize = true;
            this.LabelT.Location = new System.Drawing.Point(29, 111);
            this.LabelT.Name = "LabelT";
            this.LabelT.Size = new System.Drawing.Size(31, 13);
            this.LabelT.TabIndex = 4;
            this.LabelT.Text = "Total";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(113, 111);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(13, 13);
            this.LabelTotal.TabIndex = 5;
            this.LabelTotal.Text = "0";
            // 
            // LabelPayment
            // 
            this.LabelPayment.AutoSize = true;
            this.LabelPayment.Location = new System.Drawing.Point(29, 167);
            this.LabelPayment.Name = "LabelPayment";
            this.LabelPayment.Size = new System.Drawing.Size(75, 13);
            this.LabelPayment.TabIndex = 6;
            this.LabelPayment.Text = "Payment Type";
            // 
            // RadioCash
            // 
            this.RadioCash.AutoSize = true;
            this.RadioCash.Location = new System.Drawing.Point(116, 165);
            this.RadioCash.Name = "RadioCash";
            this.RadioCash.Size = new System.Drawing.Size(49, 17);
            this.RadioCash.TabIndex = 7;
            this.RadioCash.TabStop = true;
            this.RadioCash.Text = "Cash";
            this.RadioCash.UseVisualStyleBackColor = true;
            this.RadioCash.CheckedChanged += new System.EventHandler(this.RadioCash_CheckedChanged);
            // 
            // RadioCard
            // 
            this.RadioCard.AutoSize = true;
            this.RadioCard.Location = new System.Drawing.Point(188, 165);
            this.RadioCard.Name = "RadioCard";
            this.RadioCard.Size = new System.Drawing.Size(47, 17);
            this.RadioCard.TabIndex = 8;
            this.RadioCard.TabStop = true;
            this.RadioCard.Text = "Card";
            this.RadioCard.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Card Number";
            // 
            // TextCardNumber
            // 
            this.TextCardNumber.Location = new System.Drawing.Point(117, 210);
            this.TextCardNumber.Name = "TextCardNumber";
            this.TextCardNumber.Size = new System.Drawing.Size(153, 20);
            this.TextCardNumber.TabIndex = 10;
            // 
            // BtnPay
            // 
            this.BtnPay.Enabled = false;
            this.BtnPay.Location = new System.Drawing.Point(160, 259);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(75, 23);
            this.BtnPay.TabIndex = 11;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // FormTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 311);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.TextCardNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RadioCard);
            this.Controls.Add(this.RadioCash);
            this.Controls.Add(this.LabelPayment);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.LabelT);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.TextCID);
            this.Controls.Add(this.LabelCID);
            this.Controls.Add(this.label1);
            this.Name = "FormTransaction";
            this.Text = "FormTransaction";
            this.Load += new System.EventHandler(this.FormTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCID;
        private System.Windows.Forms.TextBox TextCID;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Label LabelT;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label LabelPayment;
        private System.Windows.Forms.RadioButton RadioCash;
        private System.Windows.Forms.RadioButton RadioCard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextCardNumber;
        private System.Windows.Forms.Button BtnPay;
    }
}