namespace BookRentApplication
{
    partial class frmKiralananKitaplar
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
            this.dgvKiralananKitaplar = new System.Windows.Forms.DataGridView();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralananKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKiralananKitaplar
            // 
            this.dgvKiralananKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiralananKitaplar.Location = new System.Drawing.Point(13, 13);
            this.dgvKiralananKitaplar.Name = "dgvKiralananKitaplar";
            this.dgvKiralananKitaplar.Size = new System.Drawing.Size(891, 406);
            this.dgvKiralananKitaplar.TabIndex = 0;
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Location = new System.Drawing.Point(677, 425);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(227, 44);
            this.btnTeslimAl.TabIndex = 1;
            this.btnTeslimAl.Text = "Teslim Al";
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // frmKiralananKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 481);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.dgvKiralananKitaplar);
            this.Name = "frmKiralananKitaplar";
            this.Text = "frmKiralananKitaplar";
            this.Load += new System.EventHandler(this.frmKiralananKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralananKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKiralananKitaplar;
        private System.Windows.Forms.Button btnTeslimAl;
    }
}