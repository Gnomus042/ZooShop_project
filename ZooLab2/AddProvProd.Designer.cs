namespace ZooLab2
{
    partial class AddProvProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.ProductCB = new System.Windows.Forms.ComboBox();
            this.ProviderCB = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCB
            // 
            this.ProductCB.DataSource = this.productsBindingSource;
            this.ProductCB.DisplayMember = "Name";
            this.ProductCB.FormattingEnabled = true;
            this.ProductCB.Location = new System.Drawing.Point(86, 48);
            this.ProductCB.Name = "ProductCB";
            this.ProductCB.Size = new System.Drawing.Size(191, 21);
            this.ProductCB.TabIndex = 32;
            this.ProductCB.ValueMember = "Id";
            // 
            // ProviderCB
            // 
            this.ProviderCB.DataSource = this.providersBindingSource;
            this.ProviderCB.DisplayMember = "Name";
            this.ProviderCB.FormattingEnabled = true;
            this.ProviderCB.Location = new System.Drawing.Point(86, 13);
            this.ProviderCB.Name = "ProviderCB";
            this.ProviderCB.Size = new System.Drawing.Size(191, 21);
            this.ProviderCB.TabIndex = 31;
            this.ProviderCB.ValueMember = "Id";
            this.ProviderCB.SelectedIndexChanged += new System.EventHandler(this.ClientIdCB_SelectedIndexChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(106, 75);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 30;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(11, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 20);
            label2.TabIndex = 28;
            label2.Text = "Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(11, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 20);
            label1.TabIndex = 27;
            label1.Text = "Provider";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(ZooDataLibrary.Products);
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataSource = typeof(ZooDataLibrary.Providers);
            // 
            // AddProvProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 108);
            this.Controls.Add(this.ProductCB);
            this.Controls.Add(this.ProviderCB);
            this.Controls.Add(this.OK);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "AddProvProd";
            this.Text = "AddProvProd";
            this.Load += new System.EventHandler(this.AddProvProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductCB;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.ComboBox ProviderCB;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private System.Windows.Forms.Button OK;
    }
}