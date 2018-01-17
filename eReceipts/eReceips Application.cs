using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eReceipts
{
    public partial class eReceipts : Form
    {

        public eReceipts(string username)
        {
            InitializeComponent();
            welcome_label.Text = "Welcome, "+username+" !";
        }

        private void Add_receipt_Click(object sender, EventArgs e)
        {
            addReceipt addRec = new addReceipt();
            addRec.ShowDialog();

        }
        private void view_receipt_clk(object sender, EventArgs e)
        {
            viewReceipts view = new viewReceipts();
            view.ShowDialog();
        }

        private void viewChartDataBtn(object sender, EventArgs e)
        {
            graphicalViewResults graph = new graphicalViewResults();
            graph.ShowDialog();
        }
    }
}
