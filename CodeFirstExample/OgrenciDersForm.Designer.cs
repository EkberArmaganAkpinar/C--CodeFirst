
namespace CodeFirstExample
{
    partial class OgrenciDersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.cmbyilsec = new System.Windows.Forms.ComboBox();
            this.cmbyariyilsec = new System.Windows.Forms.ComboBox();
            this.cmbderssec = new System.Windows.Forms.ComboBox();
            this.cmbogrencisec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtogrenciders = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(24, 202);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(990, 235);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Sil";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Sil";
            this.Delete.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Yarıyıl Seç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Yıl Seç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ders Seç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Öğrenci Seç";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(471, 148);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 33);
            this.savebtn.TabIndex = 18;
            this.savebtn.Text = "Kaydet";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(67, 148);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 33);
            this.backbtn.TabIndex = 19;
            this.backbtn.Text = "Geri";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // cmbyilsec
            // 
            this.cmbyilsec.FormattingEnabled = true;
            this.cmbyilsec.Items.AddRange(new object[] {
            "2021-2022",
            "2020-2021"});
            this.cmbyilsec.Location = new System.Drawing.Point(425, 88);
            this.cmbyilsec.Name = "cmbyilsec";
            this.cmbyilsec.Size = new System.Drawing.Size(121, 24);
            this.cmbyilsec.TabIndex = 21;
            // 
            // cmbyariyilsec
            // 
            this.cmbyariyilsec.FormattingEnabled = true;
            this.cmbyariyilsec.Items.AddRange(new object[] {
            "Güz",
            "Bahar"});
            this.cmbyariyilsec.Location = new System.Drawing.Point(425, 21);
            this.cmbyariyilsec.Name = "cmbyariyilsec";
            this.cmbyariyilsec.Size = new System.Drawing.Size(121, 24);
            this.cmbyariyilsec.TabIndex = 22;
            // 
            // cmbderssec
            // 
            this.cmbderssec.FormattingEnabled = true;
            this.cmbderssec.Location = new System.Drawing.Point(156, 88);
            this.cmbderssec.Name = "cmbderssec";
            this.cmbderssec.Size = new System.Drawing.Size(121, 24);
            this.cmbderssec.TabIndex = 23;
            // 
            // cmbogrencisec
            // 
            this.cmbogrencisec.FormattingEnabled = true;
            this.cmbogrencisec.Location = new System.Drawing.Point(156, 25);
            this.cmbogrencisec.Name = "cmbogrencisec";
            this.cmbogrencisec.Size = new System.Drawing.Size(121, 24);
            this.cmbogrencisec.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "OgrenciDersID";
            // 
            // txtogrenciders
            // 
            this.txtogrenciders.Enabled = false;
            this.txtogrenciders.Location = new System.Drawing.Point(698, 23);
            this.txtogrenciders.Name = "txtogrenciders";
            this.txtogrenciders.Size = new System.Drawing.Size(100, 22);
            this.txtogrenciders.TabIndex = 26;
            // 
            // OgrenciDersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.txtogrenciders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbogrencisec);
            this.Controls.Add(this.cmbderssec);
            this.Controls.Add(this.cmbyariyilsec);
            this.Controls.Add(this.cmbyilsec);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OgrenciDersForm";
            this.Text = "OgrenciDersForm";
            this.Load += new System.EventHandler(this.OgrenciDersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ComboBox cmbyilsec;
        private System.Windows.Forms.ComboBox cmbyariyilsec;
        private System.Windows.Forms.ComboBox cmbderssec;
        private System.Windows.Forms.ComboBox cmbogrencisec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtogrenciders;
    }
}