namespace ZooLab2
{
    partial class AddProduct
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.NameTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.InfTB = new System.Windows.Forms.TextBox();
            this.Anim_kindCB = new System.Windows.Forms.ComboBox();
            this.animalKindsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Product_kindCB = new System.Windows.Forms.ComboBox();
            this.productKindsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OK = new System.Windows.Forms.Button();
            this.QuantityNUD = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animalKindsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productKindsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.Location = new System.Drawing.Point(10, 160);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(102, 20);
            label6.TabIndex = 11;
            label6.Text = "Product_kind";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(10, 130);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(83, 20);
            label5.TabIndex = 10;
            label5.Text = "Anim_kind";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(10, 40);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 20);
            label4.TabIndex = 9;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(10, 70);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 20);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(10, 100);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 20);
            label2.TabIndex = 7;
            label2.Text = "Inf";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(10, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(84, 10);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(200, 22);
            this.NameTB.TabIndex = 12;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(84, 70);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(200, 22);
            this.PriceTB.TabIndex = 14;
            // 
            // InfTB
            // 
            this.InfTB.Location = new System.Drawing.Point(84, 98);
            this.InfTB.Name = "InfTB";
            this.InfTB.Size = new System.Drawing.Size(200, 22);
            this.InfTB.TabIndex = 15;
            // 
            // Anim_kindCB
            // 
            this.Anim_kindCB.DataSource = this.animalKindsBindingSource;
            this.Anim_kindCB.DisplayMember = "Name";
            this.Anim_kindCB.FormattingEnabled = true;
            this.Anim_kindCB.Location = new System.Drawing.Point(115, 126);
            this.Anim_kindCB.Name = "Anim_kindCB";
            this.Anim_kindCB.Size = new System.Drawing.Size(169, 24);
            this.Anim_kindCB.TabIndex = 16;
            this.Anim_kindCB.ValueMember = "Id";
            // 
            // animalKindsBindingSource
            // 
            this.animalKindsBindingSource.DataSource = typeof(ZooDataLibrary.AnimalKinds);
            // 
            // Product_kindCB
            // 
            this.Product_kindCB.DataSource = this.productKindsBindingSource;
            this.Product_kindCB.DisplayMember = "Kind";
            this.Product_kindCB.FormattingEnabled = true;
            this.Product_kindCB.Location = new System.Drawing.Point(115, 156);
            this.Product_kindCB.Name = "Product_kindCB";
            this.Product_kindCB.Size = new System.Drawing.Size(169, 24);
            this.Product_kindCB.TabIndex = 17;
            this.Product_kindCB.ValueMember = "Id";
            // 
            // productKindsBindingSource
            // 
            this.productKindsBindingSource.DataSource = typeof(ZooDataLibrary.ProductKinds);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(115, 193);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 18;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // QuantityNUD
            // 
            this.QuantityNUD.Location = new System.Drawing.Point(84, 40);
            this.QuantityNUD.Name = "QuantityNUD";
            this.QuantityNUD.Size = new System.Drawing.Size(200, 22);
            this.QuantityNUD.TabIndex = 19;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 228);
            this.Controls.Add(this.QuantityNUD);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Product_kindCB);
            this.Controls.Add(this.Anim_kindCB);
            this.Controls.Add(this.InfTB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalKindsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productKindsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox InfTB;
        private System.Windows.Forms.ComboBox Anim_kindCB;
        private System.Windows.Forms.ComboBox Product_kindCB;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.BindingSource animalKindsBindingSource;
        private System.Windows.Forms.BindingSource productKindsBindingSource;
        private System.Windows.Forms.NumericUpDown QuantityNUD;
    }
}