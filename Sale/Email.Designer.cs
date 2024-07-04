namespace Sale
{
    partial class Email
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
            textSend = new TextBox();
            txtSubject = new TextBox();
            txtMessage = new TextBox();
            groupBox1 = new GroupBox();
            btnSend = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lstAttachments = new ListBox();
            btnAttach = new Button();
            label4 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textSend
            // 
            textSend.Location = new Point(6, 42);
            textSend.Name = "textSend";
            textSend.Size = new Size(296, 23);
            textSend.TabIndex = 0;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(6, 110);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(296, 23);
            txtSubject.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(6, 180);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(296, 23);
            txtMessage.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSend);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMessage);
            groupBox1.Controls.Add(textSend);
            groupBox1.Controls.Add(txtSubject);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 477);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Email";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(367, 289);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(84, 36);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 162);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "Message";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 92);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Subject";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Send To :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstAttachments);
            groupBox2.Controls.Add(btnAttach);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(6, 228);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 243);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // lstAttachments
            // 
            lstAttachments.FormattingEnabled = true;
            lstAttachments.ItemHeight = 15;
            lstAttachments.Location = new Point(6, 17);
            lstAttachments.Name = "lstAttachments";
            lstAttachments.Size = new Size(284, 169);
            lstAttachments.TabIndex = 9;
            // 
            // btnAttach
            // 
            btnAttach.Location = new Point(6, 200);
            btnAttach.Name = "btnAttach";
            btnAttach.Size = new Size(75, 23);
            btnAttach.TabIndex = 8;
            btnAttach.Text = "Attach files";
            btnAttach.UseVisualStyleBackColor = true;
            btnAttach.Click += btnAttach_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(522, 25);
            button3.Name = "button3";
            button3.Size = new Size(84, 36);
            button3.TabIndex = 11;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Email
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 517);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Email";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Email";
           
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textSend;
        private TextBox txtSubject;
        private TextBox txtMessage;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnAttach;
        private Label label4;
        private Button btnSend;
        private Button button3;
        private ListBox lstAttachments;
    }
}