namespace ZooLab2
{
    partial class SearchProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FilterDGV = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalKindsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productKindsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animkindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productkindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.animalKindsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productKindsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.NameChB = new System.Windows.Forms.CheckBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.PriceChB = new System.Windows.Forms.CheckBox();
            this.Anim_kindChB = new System.Windows.Forms.CheckBox();
            this.Product_kindChB = new System.Windows.Forms.CheckBox();
            this.Anim_kindCB = new System.Windows.Forms.ComboBox();
            this.Product_kindCB = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PriceFromNUD = new System.Windows.Forms.NumericUpDown();
            this.PriceToNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FilterDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalKindsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productKindsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceFromNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceToNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterDGV
            // 
            this.FilterDGV.AllowUserToAddRows = false;
            this.FilterDGV.AutoGenerateColumns = false;
            this.FilterDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FilterDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FilterDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilterDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.infDataGridViewTextBoxColumn,
            this.animkindDataGridViewTextBoxColumn,
            this.productkindDataGridViewTextBoxColumn,
            this.animalKindsDataGridViewTextBoxColumn,
            this.productKindsDataGridViewTextBoxColumn,
            this.providersDataGridViewTextBoxColumn,
            this.ordersDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.FilterDGV.DataSource = this.productsBindingSource;
            this.FilterDGV.Location = new System.Drawing.Point(277, 12);
            this.FilterDGV.Name = "FilterDGV";
            this.FilterDGV.RowHeadersVisible = false;
            this.FilterDGV.Size = new System.Drawing.Size(528, 420);
            this.FilterDGV.TabIndex = 0;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(ZooDataLibrary.Products);
            // 
            // animalKindsBindingSource
            // 
            this.animalKindsBindingSource.DataSource = typeof(ZooDataLibrary.AnimalKinds);
            // 
            // productKindsBindingSource
            // 
            this.productKindsBindingSource.DataSource = typeof(ZooDataLibrary.ProductKinds);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 126.9035F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.FillWeight = 93.27412F;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 93.27412F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // infDataGridViewTextBoxColumn
            // 
            this.infDataGridViewTextBoxColumn.DataPropertyName = "Inf";
            this.infDataGridViewTextBoxColumn.HeaderText = "Inf";
            this.infDataGridViewTextBoxColumn.Name = "infDataGridViewTextBoxColumn";
            this.infDataGridViewTextBoxColumn.Visible = false;
            // 
            // animkindDataGridViewTextBoxColumn
            // 
            this.animkindDataGridViewTextBoxColumn.DataPropertyName = "Anim_kind";
            this.animkindDataGridViewTextBoxColumn.DataSource = this.animalKindsBindingSource;
            this.animkindDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.animkindDataGridViewTextBoxColumn.FillWeight = 93.27412F;
            this.animkindDataGridViewTextBoxColumn.HeaderText = "Anim_kind";
            this.animkindDataGridViewTextBoxColumn.Name = "animkindDataGridViewTextBoxColumn";
            this.animkindDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.animkindDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.animkindDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // productkindDataGridViewTextBoxColumn
            // 
            this.productkindDataGridViewTextBoxColumn.DataPropertyName = "Product_kind";
            this.productkindDataGridViewTextBoxColumn.DataSource = this.productKindsBindingSource;
            this.productkindDataGridViewTextBoxColumn.DisplayMember = "Kind";
            this.productkindDataGridViewTextBoxColumn.FillWeight = 93.27412F;
            this.productkindDataGridViewTextBoxColumn.HeaderText = "Product_kind";
            this.productkindDataGridViewTextBoxColumn.Name = "productkindDataGridViewTextBoxColumn";
            this.productkindDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productkindDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productkindDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // animalKindsDataGridViewTextBoxColumn
            // 
            this.animalKindsDataGridViewTextBoxColumn.DataPropertyName = "AnimalKinds";
            this.animalKindsDataGridViewTextBoxColumn.HeaderText = "AnimalKinds";
            this.animalKindsDataGridViewTextBoxColumn.Name = "animalKindsDataGridViewTextBoxColumn";
            this.animalKindsDataGridViewTextBoxColumn.Visible = false;
            // 
            // productKindsDataGridViewTextBoxColumn
            // 
            this.productKindsDataGridViewTextBoxColumn.DataPropertyName = "ProductKinds";
            this.productKindsDataGridViewTextBoxColumn.HeaderText = "ProductKinds";
            this.productKindsDataGridViewTextBoxColumn.Name = "productKindsDataGridViewTextBoxColumn";
            this.productKindsDataGridViewTextBoxColumn.Visible = false;
            // 
            // providersDataGridViewTextBoxColumn
            // 
            this.providersDataGridViewTextBoxColumn.DataPropertyName = "Providers";
            this.providersDataGridViewTextBoxColumn.HeaderText = "Providers";
            this.providersDataGridViewTextBoxColumn.Name = "providersDataGridViewTextBoxColumn";
            this.providersDataGridViewTextBoxColumn.Visible = false;
            // 
            // ordersDataGridViewTextBoxColumn
            // 
            this.ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
            this.ordersDataGridViewTextBoxColumn.HeaderText = "Orders";
            this.ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
            this.ordersDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter:";
            // 
            // NameChB
            // 
            this.NameChB.AutoSize = true;
            this.NameChB.Location = new System.Drawing.Point(17, 40);
            this.NameChB.Name = "NameChB";
            this.NameChB.Size = new System.Drawing.Size(67, 22);
            this.NameChB.TabIndex = 2;
            this.NameChB.Text = "Name";
            this.NameChB.UseVisualStyleBackColor = true;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(79, 40);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(192, 24);
            this.NameTB.TabIndex = 3;
            // 
            // PriceChB
            // 
            this.PriceChB.AutoSize = true;
            this.PriceChB.Location = new System.Drawing.Point(17, 71);
            this.PriceChB.Name = "PriceChB";
            this.PriceChB.Size = new System.Drawing.Size(61, 22);
            this.PriceChB.TabIndex = 6;
            this.PriceChB.Text = "Price";
            this.PriceChB.UseVisualStyleBackColor = true;
            // 
            // Anim_kindChB
            // 
            this.Anim_kindChB.AutoSize = true;
            this.Anim_kindChB.Location = new System.Drawing.Point(17, 166);
            this.Anim_kindChB.Name = "Anim_kindChB";
            this.Anim_kindChB.Size = new System.Drawing.Size(95, 22);
            this.Anim_kindChB.TabIndex = 8;
            this.Anim_kindChB.Text = "Anim_kind";
            this.Anim_kindChB.UseVisualStyleBackColor = true;
            // 
            // Product_kindChB
            // 
            this.Product_kindChB.AutoSize = true;
            this.Product_kindChB.Location = new System.Drawing.Point(17, 204);
            this.Product_kindChB.Name = "Product_kindChB";
            this.Product_kindChB.Size = new System.Drawing.Size(114, 22);
            this.Product_kindChB.TabIndex = 10;
            this.Product_kindChB.Text = "Product_kind";
            this.Product_kindChB.UseVisualStyleBackColor = true;
            // 
            // Anim_kindCB
            // 
            this.Anim_kindCB.DataSource = this.animalKindsBindingSource;
            this.Anim_kindCB.DisplayMember = "Name";
            this.Anim_kindCB.FormattingEnabled = true;
            this.Anim_kindCB.Location = new System.Drawing.Point(118, 164);
            this.Anim_kindCB.Name = "Anim_kindCB";
            this.Anim_kindCB.Size = new System.Drawing.Size(153, 26);
            this.Anim_kindCB.TabIndex = 11;
            this.Anim_kindCB.ValueMember = "Id";
            // 
            // Product_kindCB
            // 
            this.Product_kindCB.DataSource = this.productKindsBindingSource;
            this.Product_kindCB.DisplayMember = "Kind";
            this.Product_kindCB.FormattingEnabled = true;
            this.Product_kindCB.Location = new System.Drawing.Point(17, 232);
            this.Product_kindCB.Name = "Product_kindCB";
            this.Product_kindCB.Size = new System.Drawing.Size(254, 26);
            this.Product_kindCB.TabIndex = 12;
            this.Product_kindCB.ValueMember = "Id";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(17, 264);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(105, 32);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search!";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PriceFromNUD
            // 
            this.PriceFromNUD.Location = new System.Drawing.Point(79, 95);
            this.PriceFromNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PriceFromNUD.Name = "PriceFromNUD";
            this.PriceFromNUD.Size = new System.Drawing.Size(192, 24);
            this.PriceFromNUD.TabIndex = 14;
            // 
            // PriceToNUD
            // 
            this.PriceToNUD.Location = new System.Drawing.Point(79, 125);
            this.PriceToNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PriceToNUD.Name = "PriceToNUD";
            this.PriceToNUD.Size = new System.Drawing.Size(192, 24);
            this.PriceToNUD.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "To:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(165, 264);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(106, 29);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SearchProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 444);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceToNUD);
            this.Controls.Add(this.PriceFromNUD);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Product_kindCB);
            this.Controls.Add(this.Anim_kindCB);
            this.Controls.Add(this.Product_kindChB);
            this.Controls.Add(this.Anim_kindChB);
            this.Controls.Add(this.PriceChB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.NameChB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterDGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchProducts";
            this.Text = "SearchProducts";
            this.Load += new System.EventHandler(this.SearchProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilterDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalKindsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productKindsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceFromNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceToNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FilterDGV;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource animalKindsBindingSource;
        private System.Windows.Forms.BindingSource productKindsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn animkindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productkindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalKindsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productKindsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox NameChB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.CheckBox PriceChB;
        private System.Windows.Forms.CheckBox Anim_kindChB;
        private System.Windows.Forms.CheckBox Product_kindChB;
        private System.Windows.Forms.ComboBox Anim_kindCB;
        private System.Windows.Forms.ComboBox Product_kindCB;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.NumericUpDown PriceFromNUD;
        private System.Windows.Forms.NumericUpDown PriceToNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearButton;
    }
}