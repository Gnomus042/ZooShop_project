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
    public partial class AddProduct : Form
    {
        public Products product { get; set; }

        public AddProduct()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            product = new Products();
            try
            {
                product.Name = NameTB.Text;
                product.Quantity = (int)QuantityNUD.Value;
                product.Price = (float)Convert.ToDouble(PriceTB.Text);
                product.Inf = InfTB.Text;
                product.Anim_kind = (int)Anim_kindCB.SelectedValue;
                product.Product_kind = (int)Product_kindCB.SelectedValue;
            }
            catch
            {
                MessageBox.Show("Incorrect input");
            }
            this.DialogResult = DialogResult.OK;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            ZooDataLibrary.ZooShopEntities ctx = new ZooShopEntities();

            ctx.AnimalKinds.Load();
            this.animalKindsBindingSource.DataSource = ctx.AnimalKinds.Local.ToBindingList();

            ctx.ProductKinds.Load();
            this.productKindsBindingSource.DataSource = ctx.ProductKinds.Local.ToBindingList();
        }
    }
}
