namespace Sale
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            cmbPerson = new ComboBox();
            dataGridProducts = new DataGridView();
            groupBox2 = new GroupBox();
            btnReport = new Button();
            groupBox3 = new GroupBox();
            btnAdd = new Button();
            label4 = new Label();
            numericAmount = new NumericUpDown();
            label2 = new Label();
            cmbProduct = new ComboBox();
            btmEmail = new Button();
            groupBox4 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericAmount).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbPerson);
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 19);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "Client Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(186, 23);
            txtName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 79);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Salesperson";
            // 
            // cmbPerson
            // 
            cmbPerson.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPerson.FormattingEnabled = true;
            cmbPerson.Location = new Point(20, 97);
            cmbPerson.Name = "cmbPerson";
            cmbPerson.Size = new Size(186, 23);
            cmbPerson.TabIndex = 0;
            // 
            // dataGridProducts
            // 
            dataGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProducts.Columns.AddRange(new DataGridViewColumn[] { Product, Price, Amount, Total });
            dataGridProducts.Location = new Point(108, 22);
            dataGridProducts.Name = "dataGridProducts";
            dataGridProducts.Size = new Size(401, 205);
            dataGridProducts.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridProducts);
            groupBox2.Location = new Point(12, 169);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(598, 233);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(16, 39);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(120, 42);
            btnReport.TabIndex = 11;
            btnReport.Text = "Create report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(numericAmount);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cmbProduct);
            groupBox3.Location = new Point(303, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(301, 158);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(203, 63);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 31);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 79);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 9;
            label4.Text = "Amount";
            // 
            // numericAmount
            // 
            numericAmount.Location = new Point(20, 97);
            numericAmount.Name = "numericAmount";
            numericAmount.Size = new Size(147, 23);
            numericAmount.TabIndex = 8;
            numericAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 19);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Products";
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(20, 37);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(147, 23);
            cmbProduct.TabIndex = 6;
            // 
            // btmEmail
            // 
            btmEmail.Location = new Point(238, 39);
            btmEmail.Name = "btmEmail";
            btmEmail.Size = new Size(120, 42);
            btmEmail.TabIndex = 12;
            btmEmail.Text = "Send reports to email";
            btmEmail.UseVisualStyleBackColor = true;
            btmEmail.Click += btmEmail_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(btnReport);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(btmEmail);
            groupBox4.Location = new Point(12, 408);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(598, 98);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(462, 19);
            label7.Name = "label7";
            label7.Size = new Size(16, 15);
            label7.TabIndex = 16;
            label7.Text = "3.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 21);
            label6.Name = "label6";
            label6.Size = new Size(16, 15);
            label6.TabIndex = 15;
            label6.Text = "2.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 21);
            label5.Name = "label5";
            label5.Size = new Size(16, 15);
            label5.TabIndex = 14;
            label5.Text = "1.";
            // 
            // button2
            // 
            button2.Location = new Point(462, 39);
            button2.Name = "button2";
            button2.Size = new Size(120, 42);
            button2.TabIndex = 13;
            button2.Text = "Close program";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Product
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Product.DefaultCellStyle = dataGridViewCellStyle1;
            Product.HeaderText = "Product";
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Width = 120;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 80;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 80;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 80;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 518);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericAmount).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbPerson;
        private DataGridView dataGridProducts;
        private Label label3;
        private TextBox txtName;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private ComboBox cmbProduct;
        private Label label4;
        private NumericUpDown numericAmount;
        private Button btnAdd;
        private Button btnReport;
        private Button btmEmail;
        private GroupBox groupBox4;
        private Button button2;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Total;
    }
}
