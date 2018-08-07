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
    public partial class AddProvProd : Form
    {
        ZooDataLibrary.ZooShopEntities ctx;

        public AddProvProd()
        {
            InitializeComponent();
        }

        private void AddProvProd_Load(object sender, EventArgs e)
        {
            ctx = new ZooShopEntities();

            ctx.Providers.Load();
            this.providersBindingSource.DataSource = ctx.Providers.Local.ToBindingList();

            ctx.Products.Load();
            this.productsBindingSource.DataSource = ctx.Products.Local.ToBindingList();
        }

        private void ClientIdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)this.ProviderCB.SelectedValue;                
                int prodid = (int)this.ProductCB.SelectedValue;
                Providers provider = (from q in ctx.Providers where q.Id == id select q).FirstOrDefault();
                Products product = (from q in ctx.Products where q.Id == prodid select q).FirstOrDefault();
                if (provider.Products.Contains(product))
                {
                    throw new Exception("Already exists");
                }
                else
                {
                    ctx.Database.ExecuteSqlCommand("INSERT INTO [dbo].[Prov_Product]([Id_prod],[Id_prov])"+
                " VALUES ({0},{1})", prodid,id);
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
                
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
        }
    }
}
