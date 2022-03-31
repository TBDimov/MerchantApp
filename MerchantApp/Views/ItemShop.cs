using MerchantApp.Controller;
using MerchantApp.Model;
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
        WaresController waresController = new WaresController();

        public ItemShop()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            dgvWares.DataSource = waresController.ShowAllWares();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Ware ware = new Ware();
            ware.Price = int.Parse(txtPrice.Text);
            ware.Item_Name = txtItem_Name.Text;
            ware.Item_Origin = txtItem_Origin.Text;
            waresController.CreateWare(ware);
            RefreshTable();
        }

        private void ItemShop_Load(object sender, EventArgs e)
        {
            dgvWares.DataSource = waresController.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvWares.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            waresController.DeleteWare(id);
            RefreshTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var row = dgvWares.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            Ware ware = new Ware();
            ware.Item_Name = txtItem_Name.Text;
            ware.Price = int.Parse(txtPrice.Text);
            waresController.UpdateWare(id, ware);
            RefreshTable();
        }
    }
}
