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
    public partial class graphicalViewResults : Form
    {
        public graphicalViewResults()
        {
            InitializeComponent();
        }

        private void load_chart_data(object sender, EventArgs e)
        {
            filldata();
        }
        private void filldata()
        {
            string connetionString = "server=localhost;database=ereceipts;uid=root;pwd='';";
            MySqlConnection cnn = new MySqlConnection(connetionString);

            try
            {
                cnn.Open();
                using (MySqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = string.Format("SELECT amount,date FROM bills");
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        chart_data.Series["spendings"].Points.AddXY(reader[1], reader[0]);
                    
                }
                chart_data.Titles.Add("Spendings add");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception caught: {0}", ex.Message);
            }
        }
    }
}
