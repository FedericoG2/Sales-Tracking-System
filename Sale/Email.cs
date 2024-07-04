using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale
{
    public partial class Email : Form
    {
        private string myEmail;
        private string myPassword;
        private string alias = "Sales";
        private List<string> myAdjuntos = new List<string>();
        private MailMessage mCorreo;

        public Email()
        {
            InitializeComponent();
            LoadSensitiveData();
        }

   
        private void LoadSensitiveData()
        {
            myEmail = Data.MyEmail;
            myPassword = Data.MyPassword;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        myAdjuntos.Add(file);
                    }
                    UpdateAttachmentList();
                }
            }
        }

        private void UpdateAttachmentList()
        {
            lstAttachments.Items.Clear();
            foreach (string file in myAdjuntos)
            {
                string fileName = Path.GetFileName(file);
                lstAttachments.Items.Add(fileName);
            }
        }



        private void btnSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validate that the necessary fields are complete
                if (string.IsNullOrWhiteSpace(textSend.Text))
                {
                    MessageBox.Show("Please enter an email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSubject.Text))
                {
                    MessageBox.Show("Please enter a subject.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMessage.Text))
                {
                    MessageBox.Show("Please enter a message.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                mCorreo = new MailMessage();
                mCorreo.From = new MailAddress(myEmail, alias);
                mCorreo.To.Add(textSend.Text);
                mCorreo.Subject = txtSubject.Text;
                mCorreo.Body = txtMessage.Text;
                mCorreo.IsBodyHtml = false;

                foreach (string adjunto in myAdjuntos)
                {
                    Attachment attachment = new Attachment(adjunto);
                    mCorreo.Attachments.Add(attachment);
                }

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(myEmail, myPassword);
                smtp.EnableSsl = true;

                smtp.Send(mCorreo);

                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear text boxes and attachment list
                textSend.Clear();
                txtSubject.Clear();
                txtMessage.Clear();
                myAdjuntos.Clear();
                lstAttachments.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form1
            Form1 form1 = new Form1();

            // Mostrar Form1
            form1.Show();

            // Cerrar el formulario actual (opcional)
            this.Close();
        }

    }
}



//// Eliminar los archivos de la carpeta reports
//foreach (string adjunto in myAdjuntos)
//{
//    if (File.Exists(adjunto))
//    {
//        File.Delete(adjunto);
//    }
//}