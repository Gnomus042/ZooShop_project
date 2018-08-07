using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooDataLibrary;
using System.Data.Entity;

namespace ZooLab2
{
    public partial class AddOrder : Form
    {

        public Orders order { get; set; }
        public AddOrder()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            order = new Orders();
            try
            {
                order.Id_client = (int)this.ClientIdCB.SelectedValue;
                order.Id_prod = (int)this.ProductIdCB.SelectedValue;
                order.Status = (int)this.StatusIdCB.SelectedValue;
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Incorrect input");
            }

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            ZooDataLibrary.ZooShopEntities ctx = new ZooShopEntities();

            ctx.Clients.Load();
            this.clientsBindingSource.DataSource = ctx.Clients.Local.ToBindingList();

            ctx.Products.Load();
            this.productsBindingSource.DataSource = ctx.Products.Local.ToBindingList();

            ctx.Status.Load();
            this.statusBindingSource.DataSource = ctx.Status.Local.ToBindingList();
        }
    }
}
