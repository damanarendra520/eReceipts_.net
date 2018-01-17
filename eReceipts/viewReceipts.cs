using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eReceipts
{
    public partial class viewReceipts : Form
    {
        public viewReceipts()
        {
            InitializeComponent();
            generate_receipts_data();
        }

        private void view_receipts_data(object sender, EventArgs e)
        {
            generate_receipts_data();
        }
        private void generate_receipts_data()
        {
            string connetionString = null;
            string query = "SELECT amount, date, place, receipt_number, savings FROM bills";
            MySqlConnection cnn;
            connetionString = "server=localhost;database=ereceipts;uid=root;pwd='';";
            cnn = new MySqlConnection(connetionString);

            try
            {
                cnn.Open();

                using (MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn))
                {
                    DataSet ds = new DataSet();
                    ada.Fill(ds);
                    viewReceiptsData.DataSource = ds.Tables[0];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception caught: {0}", ex.Message);
            }
        }
    }
}
