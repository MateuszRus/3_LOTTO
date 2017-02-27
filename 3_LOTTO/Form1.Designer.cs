namespace _3_LOTTO
{
    partial class DuzyLotek
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
            this.btDodaj = new System.Windows.Forms.Button();
            this.dataGridViewDuzy = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lp1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lp2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lp3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lp4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lp5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lp6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuzy)).BeginInit();
            this.SuspendLayout();
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(12, 168);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(75, 23);
            this.btDodaj.TabIndex = 3;
            this.btDodaj.Text = "Dodaj wyniki";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // dataGridViewDuzy
            // 
            this.dataGridViewDuzy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDuzy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.lp1,
            this.lp2,
            this.lp3,
            this.lp4,
            this.lp5,
            this.lp6});
            this.dataGridViewDuzy.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDuzy.Name = "dataGridViewDuzy";
            this.dataGridViewDuzy.Size = new System.Drawing.Size(744, 150);
            this.dataGridViewDuzy.TabIndex = 2;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // lp1
            // 
            this.lp1.HeaderText = "Liczba1";
            this.lp1.Name = "lp1";
            // 
            // lp2
            // 
            this.lp2.HeaderText = "Liczba2";
            this.lp2.Name = "lp2";
            // 
            // lp3
            // 
            this.lp3.HeaderText = "Liczba3";
            this.lp3.Name = "lp3";
            // 
            // lp4
            // 
            this.lp4.HeaderText = "Liczba4";
            this.lp4.Name = "lp4";
            // 
            // lp5
            // 
            this.lp5.HeaderText = "Liczba5";
            this.lp5.Name = "lp5";
            // 
            // lp6
            // 
            this.lp6.HeaderText = "Liczba6";
            this.lp6.Name = "lp6";
            // 
            // DuzyLotek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 206);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.dataGridViewDuzy);
            this.Name = "DuzyLotek";
            this.Text = "DuzyLotek";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuzy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.DataGridView dataGridViewDuzy;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn lp1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lp2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lp3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lp4;
        private System.Windows.Forms.DataGridViewTextBoxColumn lp5;
        private System.Windows.Forms.DataGridViewTextBoxColumn lp6;
    }
}

