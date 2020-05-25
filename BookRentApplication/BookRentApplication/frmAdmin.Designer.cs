namespace BookRentApplication
{
    partial class frmAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUyeAktif = new System.Windows.Forms.Button();
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnKiralananKitaplar = new System.Windows.Forms.Button();
            this.btnKitapTeslimAlma = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üye Listesi";
            // 
            // btnUyeAktif
            // 
            this.btnUyeAktif.Location = new System.Drawing.Point(792, 377);
            this.btnUyeAktif.Name = "btnUyeAktif";
            this.btnUyeAktif.Size = new System.Drawing.Size(128, 31);
            this.btnUyeAktif.TabIndex = 2;
            this.btnUyeAktif.Text = "Uye Aktifleştir";
            this.btnUyeAktif.UseVisualStyleBackColor = true;
            this.btnUyeAktif.Click += new System.EventHandler(this.btnUyeAktif_Click);
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.AllowUserToAddRows = false;
            this.dgvUyeler.AllowUserToDeleteRows = false;
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.Location = new System.Drawing.Point(30, 28);
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.ReadOnly = true;
            this.dgvUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUyeler.Size = new System.Drawing.Size(890, 343);
            this.dgvUyeler.TabIndex = 3;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(30, 453);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(171, 62);
            this.btnKitapEkle.TabIndex = 5;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnKiralananKitaplar
            // 
            this.btnKiralananKitaplar.Location = new System.Drawing.Point(265, 453);
            this.btnKiralananKitaplar.Name = "btnKiralananKitaplar";
            this.btnKiralananKitaplar.Size = new System.Drawing.Size(171, 62);
            this.btnKiralananKitaplar.TabIndex = 5;
            this.btnKiralananKitaplar.Text = "Kiralanan Kitaplar";
            this.btnKiralananKitaplar.UseVisualStyleBackColor = true;
            // 
            // btnKitapTeslimAlma
            // 
            this.btnKitapTeslimAlma.Location = new System.Drawing.Point(514, 453);
            this.btnKitapTeslimAlma.Name = "btnKitapTeslimAlma";
            this.btnKitapTeslimAlma.Size = new System.Drawing.Size(171, 62);
            this.btnKitapTeslimAlma.TabIndex = 5;
            this.btnKitapTeslimAlma.Text = "Kitap Teslim Alma";
            this.btnKitapTeslimAlma.UseVisualStyleBackColor = true;
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Location = new System.Drawing.Point(749, 453);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(171, 62);
            this.btnRaporlar.TabIndex = 5;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 556);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnKitapTeslimAlma);
            this.Controls.Add(this.btnKiralananKitaplar);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.dgvUyeler);
            this.Controls.Add(this.btnUyeAktif);
            this.Controls.Add(this.label1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUyeAktif;
        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnKiralananKitaplar;
        private System.Windows.Forms.Button btnKitapTeslimAlma;
        private System.Windows.Forms.Button btnRaporlar;
    }
}