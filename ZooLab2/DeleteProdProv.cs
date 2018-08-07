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
    public partial class DeleteProdProv : Form
    {

        ZooDataLibrary.ZooShopEntities ctx;

        public DeleteProdProv()
        {
            InitializeComponent();
        }

        private void DeleteProdProv_Load(object sender, EventArgs e)
        {
            ctx = new ZooShopEntities();

            ctx.Providers.Load();
            this.providersBindingSource.DataSource = ctx.Providers.Local.ToBindingList();

            ctx.Products.Load();
            this.productsBindingSource.DataSource = ctx.Products.Local.ToBindingList();
        }

        private void ProviderCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctx = new ZooShopEntities();
            int prov_id = (int)this.ProviderCB.SelectedValue;
            Providers provider = (from q in ctx.Providers where q.Id == prov_id select q).FirstOrDefault();
            var query = (from q in ctx.Products select q).Where(q => q.Providers.Select(w => w.Id).ToList().Contains(prov_id));
            query.Load();
            this.productsBindingSource.DataSource = ctx.Products.Local.ToBindingList();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            int id = (int)this.ProviderCB.SelectedValue;
            int prodid = (int)this.ProductCB.SelectedValue;
            ctx.Database.ExecuteSqlCommand("DELETE FROM [dbo].[Prov_Product] WHERE Id_prod = {0} AND Id_prov = {1}", prodid, id);
            ctx.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }
    }
}
