namespace Week6
{
    partial class FormMerchandise
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
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.Btnsave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnPhoto = new System.Windows.Forms.Button();
            this.TextImage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumericStock = new System.Windows.Forms.NumericUpDown();
            this.NumericPrice = new System.Windows.Forms.NumericUpDown();
            this.ComboModel = new System.Windows.Forms.ComboBox();
            this.TextSpec = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextId = new System.Windows.Forms.TextBox();
            this.Dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TextSearch
            // 
            this.TextSearch.Location = new System.Drawing.Point(603, 26);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(131, 20);
            this.TextSearch.TabIndex = 49;
            this.TextSearch.TextChanged += new System.EventHandler(this.TextSearch_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(556, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Search";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(523, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(329, 393);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 46;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Location = new System.Drawing.Point(329, 364);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(75, 23);
            this.Btnsave.TabIndex = 45;
            this.Btnsave.Text = "Save ";
            this.Btnsave.UseVisualStyleBackColor = true;
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(329, 335);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 44;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(329, 306);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 43;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(329, 277);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 42;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnPhoto
            // 
            this.BtnPhoto.Location = new System.Drawing.Point(654, 274);
            this.BtnPhoto.Name = "BtnPhoto";
            this.BtnPhoto.Size = new System.Drawing.Size(42, 23);
            this.BtnPhoto.TabIndex = 41;
            this.BtnPhoto.Text = "...";
            this.BtnPhoto.UseVisualStyleBackColor = true;
            this.BtnPhoto.Click += new System.EventHandler(this.BtnPhoto_Click_1);
            // 
            // TextImage
            // 
            this.TextImage.Enabled = false;
            this.TextImage.Location = new System.Drawing.Point(523, 274);
            this.TextImage.Name = "TextImage";
            this.TextImage.Size = new System.Drawing.Size(116, 20);
            this.TextImage.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Photo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "MANAGE MERCHANDISE";
            // 
            // NumericStock
            // 
            this.NumericStock.Location = new System.Drawing.Point(155, 409);
            this.NumericStock.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.NumericStock.Name = "NumericStock";
            this.NumericStock.Size = new System.Drawing.Size(120, 20);
            this.NumericStock.TabIndex = 37;
            // 
            // NumericPrice
            // 
            this.NumericPrice.Location = new System.Drawing.Point(154, 379);
            this.NumericPrice.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.NumericPrice.Name = "NumericPrice";
            this.NumericPrice.Size = new System.Drawing.Size(120, 20);
            this.NumericPrice.TabIndex = 36;
            // 
            // ComboModel
            // 
            this.ComboModel.FormattingEnabled = true;
            this.ComboModel.Location = new System.Drawing.Point(154, 352);
            this.ComboModel.Name = "ComboModel";
            this.ComboModel.Size = new System.Drawing.Size(121, 21);
            this.ComboModel.TabIndex = 35;
            // 
            // TextSpec
            // 
            this.TextSpec.Location = new System.Drawing.Point(154, 326);
            this.TextSpec.Name = "TextSpec";
            this.TextSpec.Size = new System.Drawing.Size(121, 20);
            this.TextSpec.TabIndex = 34;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(154, 300);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(120, 20);
            this.TextName.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Specification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ModelId";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ImagePath";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stock";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Specification";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Model";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // TextId
            // 
            this.TextId.Enabled = false;
            this.TextId.Location = new System.Drawing.Point(154, 274);
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(120, 20);
            this.TextId.TabIndex = 32;
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.Dgv.Location = new System.Drawing.Point(34, 53);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.Size = new System.Drawing.Size(733, 215);
            this.Dgv.TabIndex = 25;
            this.Dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick_1);
            // 
            // FormMerchandise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.Btnsave);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.BtnPhoto);
            this.Controls.Add(this.TextImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumericStock);
            this.Controls.Add(this.NumericPrice);
            this.Controls.Add(this.ComboModel);
            this.Controls.Add(this.TextSpec);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextId);
            this.Controls.Add(this.Dgv);
            this.Name = "FormMerchandise";
            this.Text = "FormMerchandise";
            this.Load += new System.EventHandler(this.FormMerchandise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button Btnsave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnPhoto;
        private System.Windows.Forms.TextBox TextImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumericStock;
        private System.Windows.Forms.NumericUpDown NumericPrice;
        private System.Windows.Forms.ComboBox ComboModel;
        private System.Windows.Forms.TextBox TextSpec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox TextId;
        private System.Windows.Forms.DataGridView Dgv;
    }
}