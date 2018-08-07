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
    public partial class AddProvider : Form
    {
        public Providers provider { get;set;}

        public AddProvider()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            provider = new Providers();
            try
            {
                provider.Name = NameTB.Text;
                provider.City = (int)CityCB.SelectedValue;
            }
            catch
            {
                MessageBox.Show("Incorrect Data");
            }
            this.DialogResult = DialogResult.OK;
        }

        private void AddProvider_Load(object sender, EventArgs e)
        {
            ZooDataLibrary.ZooShopEntities ctx = new ZooShopEntities();

            ctx.Citys.Load();
            citysBindingSource.DataSource = ctx.Citys.Local.ToBindingList();
        }
    }
}
