namespace ZooLab2
{
    partial class AddProvider
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.NameTB = new System.Windows.Forms.TextBox();
            this.CityCB = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.citysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.citysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(12, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 20);
            label2.TabIndex = 8;
            label2.Text = "City";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(69, 7);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(205, 24);
            this.NameTB.TabIndex = 9;
            // 
            // CityCB
            // 
            this.CityCB.DataSource = this.citysBindingSource;
            this.CityCB.DisplayMember = "Name";
            this.CityCB.FormattingEnabled = true;
            this.CityCB.Location = new System.Drawing.Point(69, 40);
            this.CityCB.Name = "CityCB";
            this.CityCB.Size = new System.Drawing.Size(205, 26);
            this.CityCB.TabIndex = 10;
            this.CityCB.ValueMember = "Id";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(114, 74);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 11;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // citysBindingSource
            // 
            this.citysBindingSource.DataSource = typeof(ZooDataLibrary.Citys);
            // 
            // AddProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 109);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.CityCB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProvider";
            this.Text = "AddProvider";
            this.Load += new System.EventHandler(this.AddProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citysBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.ComboBox CityCB;
        private System.Windows.Forms.BindingSource citysBindingSource;
        private System.Windows.Forms.Button OK;
    }
}