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
    public partial class AddClient : Form
    {

        public Clients client { get; set; }

        public AddClient()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            client = new Clients();
            try
            {
                client.Name = NameTB.Text;
                client.Card = CardTB.Text;
                client.Tel = Convert.ToDouble(PhoneTB.Text).ToString();
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("IncorrectInput");
            }
            
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
          
        }
    }
}
