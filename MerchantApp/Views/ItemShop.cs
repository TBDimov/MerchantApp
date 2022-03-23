using MerchantApp.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerchantApp
{
    public partial class ItemShop : Form
    {
        public ItemShop()
        {
            InitializeComponent();
            WaresController WareController = new WaresController();
        }

        private void Form1_Load(object sender, EventArgs e, WaresController waresController)
        {
            // TODO: This line of code loads data into the 'waresDBDataSet.Wares' table. You can move, or remove it, as needed.
            this.waresTableAdapter.Fill(this.waresDBDataSet.Wares);
            dgvWares.DataSource = waresController.GetAll();
        }
    }
}
