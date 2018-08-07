namespace ZooLab2
{
    partial class AddOrder
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.OK = new System.Windows.Forms.Button();
            this.ClientIdCB = new System.Windows.Forms.ComboBox();
            this.ProductIdCB = new System.Windows.Forms.ComboBox();
            this.StatusIdCB = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(110, 114);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 23;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(13, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 20);
            label3.TabIndex = 21;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(13, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 20);
            label2.TabIndex = 19;
            label2.Text = "Id_prod";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(13, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 20);
            label1.TabIndex = 17;
            label1.Text = "Id_client";
            // 
            // ClientIdCB
            // 
            this.ClientIdCB.DataSource = this.clientsBindingSource;
            this.ClientIdCB.DisplayMember = "Name";
            this.ClientIdCB.FormattingEnabled = true;
            this.ClientIdCB.Location = new System.Drawing.Point(88, 11);
            this.ClientIdCB.Name = "ClientIdCB";
            this.ClientIdCB.Size = new System.Drawing.Size(191, 26);
            this.ClientIdCB.TabIndex = 24;
            this.ClientIdCB.ValueMember = "Id";
            // 
            // ProductIdCB
            // 
            this.ProductIdCB.DataSource = this.productsBindingSource;
            this.ProductIdCB.DisplayMember = "Name";
            this.ProductIdCB.FormattingEnabled = true;
            this.ProductIdCB.Location = new System.Drawing.Point(88, 46);
            this.ProductIdCB.Name = "ProductIdCB";
            this.ProductIdCB.Size = new System.Drawing.Size(191, 26);
            this.ProductIdCB.TabIndex = 25;
            this.ProductIdCB.ValueMember = "Id";
            // 
            // StatusIdCB
            // 
            this.StatusIdCB.DataSource = this.statusBindingSource;
            this.StatusIdCB.DisplayMember = "Name";
            this.StatusIdCB.FormattingEnabled = true;
            this.StatusIdCB.Location = new System.Drawing.Point(88, 78);
            this.StatusIdCB.Name = "StatusIdCB";
            this.StatusIdCB.Size = new System.Drawing.Size(191, 26);
            this.StatusIdCB.TabIndex = 26;
            this.StatusIdCB.ValueMember = "Id";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(ZooDataLibrary.Clients);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(ZooDataLibrary.Products);
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(ZooDataLibrary.Status);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 144);
            this.Controls.Add(this.StatusIdCB);
            this.Controls.Add(this.ProductIdCB);
            this.Controls.Add(this.ClientIdCB);
            this.Controls.Add(this.OK);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrder";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ComboBox ClientIdCB;
        private System.Windows.Forms.ComboBox ProductIdCB;
        private System.Windows.Forms.ComboBox StatusIdCB;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource statusBindingSource;
    }
}