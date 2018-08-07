namespace ZooLab2
{
    partial class AddClient
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.NameTB = new System.Windows.Forms.TextBox();
            this.CardTB = new System.Windows.Forms.TextBox();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 20);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(12, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 20);
            label2.TabIndex = 12;
            label2.Text = "Card";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(12, 79);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 20);
            label3.TabIndex = 14;
            label3.Text = "Phone";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(69, 7);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(205, 24);
            this.NameTB.TabIndex = 11;
            // 
            // CardTB
            // 
            this.CardTB.Location = new System.Drawing.Point(69, 42);
            this.CardTB.Name = "CardTB";
            this.CardTB.Size = new System.Drawing.Size(205, 24);
            this.CardTB.TabIndex = 13;
            // 
            // PhoneTB
            // 
            this.PhoneTB.Location = new System.Drawing.Point(69, 77);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(205, 24);
            this.PhoneTB.TabIndex = 15;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(109, 110);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 16;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 145);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(label3);
            this.Controls.Add(this.CardTB);
            this.Controls.Add(label2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClient";
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox CardTB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.Button OK;
    }
}