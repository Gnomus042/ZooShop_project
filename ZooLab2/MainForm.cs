using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ZooDataLibrary;


namespace ZooLab2
{
    public partial class MainForm : Form
    {
        private ZooDataLibrary.ZooShopEntities ctx;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ctx = new ZooDataLibrary.ZooShopEntities();

            ctx.Products.Load();
            this.productsBindingSource.DataSource = ctx.Products.Local.ToBindingList();

            ctx.AnimalKinds.Load();
            this.animalKindsBindingSource.DataSource = ctx.AnimalKinds.Local.ToBindingList();

            ctx.ProductKinds.Load();
            this.productKindsBindingSource.DataSource = ctx.ProductKinds.Local.ToBindingList();

            ctx.Providers.Load();
            this.providersBindingSource.DataSource = ctx.Providers.Local.ToBindingList();

            ctx.Citys.Load();
            this.citysBindingSource.DataSource = ctx.Citys.Local.ToBindingList();

            ctx.Orders.Load();
            this.ordersBindingSource.DataSource = ctx.Orders.Local.ToBindingList();

            ctx.Clients.Load();
            this.clientsBindingSource.DataSource = ctx.Clients.Local.ToBindingList();

            ctx.Status.Load();
            this.statusBindingSource.DataSource = ctx.Status.Local.ToBindingList();

        }

        private void ProductSaveButton_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void ProvidersSaveButton_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void SaveClientButton_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void SaveOrderButton_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void ProductsAddButton_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                try
                {
                    ctx.Products.Add(form.product);
                    ctx.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void ProvidersAddButton_Click(object sender, EventArgs e)
        {
            AddProvider form = new AddProvider();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                try
                {
                    Providers p = form.provider;
                    ctx.Providers.Add(p);
                    ctx.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                try
                {
                    Clients p = form.client;
                    ctx.Clients.Add(p);
                    ctx.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            AddOrder form = new AddOrder();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                try
                {
                    ctx.Orders.Add(form.order);
                    ctx.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void ProductDeleteButton_Click(object sender, EventArgs e)
        {
            
            int col = this.ProductsDGV.Columns.Count - 1;
            int row = this.ProductsDGV.CurrentRow.Index;
            int id = (int)this.ProductsDGV[col, row].Value;
            Products p = (from q in ctx.Products where q.Id == id select q).FirstOrDefault();
            if(p.Orders.Any()||p.Providers.Any())
            {
                var result = MessageBox.Show("This product has active orders and active deliveries. Do you want to remove this product and all linked orders and deliveries?","Delete product", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    List<Orders> orders = (from q in ctx.Orders where q.Id_prod == p.Id select q).ToList();
                    ctx.Orders.RemoveRange(orders);
                    ctx.SaveChanges();

                    ctx.Products.Remove(p);
                    ctx.SaveChanges();
                }
            }
            else
            {
                ctx.Products.Remove(p);
            }
            
        }

        private void ProvidersDeleteButton_Click(object sender, EventArgs e)
        {
            int col = this.ProvidersDGV.Columns.Count - 1;
            int row = this.ProvidersDGV.CurrentRow.Index;
            int id = (int)this.ProvidersDGV[col, row].Value;
            Providers p = (from q in ctx.Providers where q.Id == id select q).FirstOrDefault();
            if (p.Products.Any())
            {
                var result = MessageBox.Show("This provider has deliveries. Do you want to delete this provider and all linked deliveries?", "Delete provider", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ctx.Providers.Remove(p);
                    ctx.SaveChanges();
                }
            }
            else
            {
                ctx.Providers.Remove(p);
            }
         
        }

        private void DeleteClientButton_Click(object sender, EventArgs e)
        {
            int col = this.ClientsDGV.Columns.Count - 1;
            int row = this.ClientsDGV.CurrentRow.Index;
            int id = (int)this.ClientsDGV[col, row].Value;
            Clients p = (from q in ctx.Clients where q.Id == id select q).FirstOrDefault();
            if (p.Orders.Any())
            {
                var result = MessageBox.Show("This client has active orders. Do you want to remove this client and all linked orders?", "Delete client", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    List<Orders> orders = (from q in ctx.Orders where q.Id_client == p.Id select q).ToList();
                    ctx.Orders.RemoveRange(orders);
                    ctx.SaveChanges();

                    ctx.Clients.Remove(p);
                    ctx.SaveChanges();
                }
            }
            else
            {
                ctx.Clients.Remove(p);
            }
            
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            int col = this.OrderDGV.Columns.Count - 1;
            int row = this.OrderDGV.CurrentRow.Index;
            int id = (int)this.OrderDGV[col, row].Value;
            Orders p = (from q in ctx.Orders where q.id == id select q).FirstOrDefault();
            ctx.Orders.Remove(p);
        }

        private void ProvByProdButton_Click(object sender, EventArgs e)
        {
            ZooDataLibrary.ZooShopEntities ctx1 = new ZooShopEntities();
            int prod_id = (int)this.ProdForProvCB.SelectedValue;
            Products product = (from q in ctx1.Products where q.Id == prod_id select q).FirstOrDefault();
            var query = (from q in ctx1.Providers select q).Where(q => q.Products.Select(w=> w.Id).ToList().Contains(prod_id));
            query.Load();
            this.providersForProductsBindingSource.DataSource = ctx1.Providers.Local.ToBindingList();
        }

        private void SearchProducts_Click(object sender, EventArgs e)
        {
            SearchProducts form = new SearchProducts();
            form.ShowDialog();
        }

        private void ProdByProvButton_Click(object sender, EventArgs e)
        {
            ZooDataLibrary.ZooShopEntities ctx1 = new ZooShopEntities();
            int prov_id = (int)this.ProvForProdCB.SelectedValue;
            Providers provider = (from q in ctx1.Providers where q.Id == prov_id select q).FirstOrDefault();
            var query = (from q in ctx1.Products select q).Where(q => q.Providers.Select(w => w.Id).ToList().Contains(prov_id));
            query.Load();
            this.productsForProvidersBindingSource.DataSource = ctx1.Products.Local.ToBindingList();
        }

        private void productsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void AddPrPrButton_Click(object sender, EventArgs e)
        {
            AddProvProd a = new AddProvProd();
            a.ShowDialog();
        }

        private void DeletePrPrButton_Click(object sender, EventArgs e)
        {
            DeleteProdProv form = new DeleteProdProv();
            form.ShowDialog();
        }

        private void SearchOrderByClientButton_Click(object sender, EventArgs e)
        {
            ZooShopEntities ctx1 = new ZooShopEntities();
            int clientid = (int)this.SearchOrderByClientCB.SelectedValue;
            var query = (from q in ctx1.Orders where q.Id_client == clientid select q);
            query.Load();
            this.ordersBindingSource.DataSource = ctx1.Orders.Local.ToBindingList();
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            this.ordersBindingSource.DataSource = ctx.Orders.Local.ToBindingList();
        }
    }
}
