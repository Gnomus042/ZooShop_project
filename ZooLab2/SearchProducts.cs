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
    public partial class SearchProducts : Form
    {
        ZooShopEntities ctx;

        public SearchProducts()
        {
            InitializeComponent();
        }

        private void SearchProducts_Load(object sender, EventArgs e)
        {
            ctx = new ZooShopEntities();

            ctx.Products.Load();
            this.productsBindingSource.DataSource = ctx.Products.Local.ToBindingList();

            ctx.ProductKinds.Load();
            this.productKindsBindingSource.DataSource = ctx.ProductKinds.Local.ToBindingList();

            ctx.AnimalKinds.Load();
            this.animalKindsBindingSource.DataSource = ctx.AnimalKinds.Local.ToBindingList();
        }

        private void Search()
        {
            ctx = new ZooShopEntities();
            var query = (from c in ctx.Products select c);
            if (this.NameChB.Checked)
            {
                string name = NameTB.Text.Trim();
                query = query.Where(c => c.Name.Contains(name));
            }
            if (this.PriceChB.Checked)
            {
                int pricefrom = (int)PriceFromNUD.Value;
                int priceto = (int)PriceToNUD.Value;
                query = query.Where(c => c.Price >= pricefrom && c.Price<=priceto);
            }
            if (this.Anim_kindChB.Checked)
            {
                int animid = (int)this.Anim_kindCB.SelectedValue;
                query = query.Where(c => c.Anim_kind == animid);
            }
            if (this.Product_kindChB.Checked)
            {
                int productkind = (int)this.Product_kindCB.SelectedValue;
                query = query.Where(c => c.Product_kind == productkind);
            }

            query.Load();
            this.productsBindingSource.DataSource = ctx.Products.Local.ToBindingList();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
    
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
            
                }

                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                   
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }
    }
}
