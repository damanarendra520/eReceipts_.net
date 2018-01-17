using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace eReceipts
{
    public partial class addReceipt : Form
    {
        public static string filename = "";

        public PictureBoxSizeMode sizeMode { get; set; }
        PictureBox picturebox1 = new PictureBox();

        public addReceipt()
        {
            InitializeComponent();
        }

        private void ReceiptNoKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        public void upload_Button(object sender, EventArgs e)
        {
            
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Multiselect = true;
            openDialog.Filter = "Image Files (*.png;*.jpeg)|*.png;*.jpeg| All files(*.*)|*.*";
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

            if(openDialog.ShowDialog() == DialogResult.OK)
            {
                filename = openDialog.FileName;

                receipt_upload_image.Image = new Bitmap(openDialog.FileName);
                receipt_upload_image.Size = new Size(150, 140);
                receipt_upload_image.SizeMode = PictureBoxSizeMode.CenterImage;
                receipt_upload_image.BorderStyle = BorderStyle.Fixed3D;

            }
        }

        private void add_receipt_func(object sender, EventArgs e)
        {
          

            if(string.IsNullOrWhiteSpace(receipt_number.Text) || string.IsNullOrWhiteSpace(txtbox_date1.Text) || string.IsNullOrWhiteSpace(txtbox_amount.Text) || string.IsNullOrWhiteSpace(txtbox_place.Text) || string.IsNullOrWhiteSpace(txtbox_savings.Text))
            {
                MessageBox.Show("Please fill all the fileds !");
                return;
            }
            
            if (string.IsNullOrWhiteSpace(filename))
            {
                MessageBox.Show("Please upload receipt!");
                return;
            }
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=ereceipts;uid=root;pwd='';";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                using (MySqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = string.Format("INSERT INTO bills (amount, date, place, receipt_number, savings, receipt_location) VALUES ('"+txtbox_amount.Text+"', '"+txtbox_date1.Text+"', '"+txtbox_place.Text+"', '"+receipt_number.Text+"', '"+txtbox_savings.Text+"', '"+filename+"')");
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Receipt Added Sucessfully.");
                cnn.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception caught : {0}", ex.Message);
            }
        }

        private void cancel_clk(object sender, EventArgs e)
        {
            Close();
        }
    }
}
