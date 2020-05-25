namespace BookRentApplication
{
    partial class frmKitapEkle
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
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPublisherID = new System.Windows.Forms.ComboBox();
            this.cmbAuthorID = new System.Windows.Forms.ComboBox();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.btnAuthorAdd = new System.Windows.Forms.Button();
            this.btnPublisherAdd = new System.Windows.Forms.Button();
            this.numPages = new System.Windows.Forms.NumericUpDown();
            this.txtAuthorNAme = new System.Windows.Forms.TextBox();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.txtAuthorLastName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.AllowUserToAddRows = false;
            this.dgvKitaplar.AllowUserToDeleteRows = false;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(12, 12);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(1044, 408);
            this.dgvKitaplar.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(159, 449);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(80, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "PublisherID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(405, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "AuthorID :";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookName.Location = new System.Drawing.Point(770, 446);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(165, 20);
            this.txtBookName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(671, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(159, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(405, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Publication Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 497);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtSummary
            // 
            this.txtSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSummary.Location = new System.Drawing.Point(232, 536);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(183, 100);
            this.txtSummary.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(159, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Summary :";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(245, 499);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(99, 20);
            this.numPrice.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(671, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pages :";
            // 
            // cmbPublisherID
            // 
            this.cmbPublisherID.FormattingEnabled = true;
            this.cmbPublisherID.Location = new System.Drawing.Point(245, 446);
            this.cmbPublisherID.Name = "cmbPublisherID";
            this.cmbPublisherID.Size = new System.Drawing.Size(99, 21);
            this.cmbPublisherID.TabIndex = 5;
            // 
            // cmbAuthorID
            // 
            this.cmbAuthorID.FormattingEnabled = true;
            this.cmbAuthorID.Location = new System.Drawing.Point(531, 441);
            this.cmbAuthorID.Name = "cmbAuthorID";
            this.cmbAuthorID.Size = new System.Drawing.Size(110, 21);
            this.cmbAuthorID.TabIndex = 6;
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(791, 592);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(144, 44);
            this.btnBookAdd.TabIndex = 7;
            this.btnBookAdd.Text = "Kitap Ekle";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // btnAuthorAdd
            // 
            this.btnAuthorAdd.Location = new System.Drawing.Point(1155, 99);
            this.btnAuthorAdd.Name = "btnAuthorAdd";
            this.btnAuthorAdd.Size = new System.Drawing.Size(144, 44);
            this.btnAuthorAdd.TabIndex = 7;
            this.btnAuthorAdd.Text = "Yazar Ekle";
            this.btnAuthorAdd.UseVisualStyleBackColor = true;
            this.btnAuthorAdd.Click += new System.EventHandler(this.btnAuthorAdd_Click);
            // 
            // btnPublisherAdd
            // 
            this.btnPublisherAdd.Location = new System.Drawing.Point(1155, 267);
            this.btnPublisherAdd.Name = "btnPublisherAdd";
            this.btnPublisherAdd.Size = new System.Drawing.Size(144, 44);
            this.btnPublisherAdd.TabIndex = 7;
            this.btnPublisherAdd.Text = "Yayınevi Ekle";
            this.btnPublisherAdd.UseVisualStyleBackColor = true;
            this.btnPublisherAdd.Click += new System.EventHandler(this.btnPublisherAdd_Click);
            // 
            // numPages
            // 
            this.numPages.Location = new System.Drawing.Point(770, 498);
            this.numPages.Name = "numPages";
            this.numPages.Size = new System.Drawing.Size(165, 20);
            this.numPages.TabIndex = 4;
            // 
            // txtAuthorNAme
            // 
            this.txtAuthorNAme.Location = new System.Drawing.Point(1107, 47);
            this.txtAuthorNAme.Name = "txtAuthorNAme";
            this.txtAuthorNAme.Size = new System.Drawing.Size(192, 20);
            this.txtAuthorNAme.TabIndex = 8;
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(1107, 232);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(192, 20);
            this.txtPublisherName.TabIndex = 8;
            // 
            // txtAuthorLastName
            // 
            this.txtAuthorLastName.Location = new System.Drawing.Point(1107, 73);
            this.txtAuthorLastName.Name = "txtAuthorLastName";
            this.txtAuthorLastName.Size = new System.Drawing.Size(192, 20);
            this.txtAuthorLastName.TabIndex = 8;
            // 
            // frmKitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 664);
            this.Controls.Add(this.txtPublisherName);
            this.Controls.Add(this.txtAuthorLastName);
            this.Controls.Add(this.txtAuthorNAme);
            this.Controls.Add(this.btnPublisherAdd);
            this.Controls.Add(this.btnAuthorAdd);
            this.Controls.Add(this.btnBookAdd);
            this.Controls.Add(this.cmbAuthorID);
            this.Controls.Add(this.cmbPublisherID);
            this.Controls.Add(this.numPages);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dgvKitaplar);
            this.Name = "frmKitapEkle";
            this.Text = "frmKitapEkle";
            this.Load += new System.EventHandler(this.frmKitapEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPublisherID;
        private System.Windows.Forms.ComboBox cmbAuthorID;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Button btnAuthorAdd;
        private System.Windows.Forms.Button btnPublisherAdd;
        private System.Windows.Forms.NumericUpDown numPages;
        private System.Windows.Forms.TextBox txtAuthorNAme;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.TextBox txtAuthorLastName;
    }
}