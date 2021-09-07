
namespace CodeFirstExample
{
    partial class OgrenciSorgula
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumarasorgu = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.btnsorgula = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyilsorgu = new System.Windows.Forms.TextBox();
            this.cmbyariyilsorgu = new System.Windows.Forms.ComboBox();
            this.btnsorgula2 = new System.Windows.Forms.Button();
            this.Sayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(865, 196);
            this.dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numaraya Göre Sorgula";
            // 
            // txtnumarasorgu
            // 
            this.txtnumarasorgu.Location = new System.Drawing.Point(215, 26);
            this.txtnumarasorgu.Name = "txtnumarasorgu";
            this.txtnumarasorgu.Size = new System.Drawing.Size(151, 22);
            this.txtnumarasorgu.TabIndex = 15;
            this.txtnumarasorgu.TextChanged += new System.EventHandler(this.txtnumarasorgu_TextChanged);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(37, 504);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 34);
            this.backbtn.TabIndex = 16;
            this.backbtn.Text = "Geri";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // btnsorgula
            // 
            this.btnsorgula.Location = new System.Drawing.Point(417, 26);
            this.btnsorgula.Name = "btnsorgula";
            this.btnsorgula.Size = new System.Drawing.Size(75, 33);
            this.btnsorgula.TabIndex = 17;
            this.btnsorgula.Text = "Sorgula";
            this.btnsorgula.UseVisualStyleBackColor = true;
            this.btnsorgula.Click += new System.EventHandler(this.btnsorgula_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sayi});
            this.dataGridView2.Location = new System.Drawing.Point(37, 328);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(865, 156);
            this.dataGridView2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Yarıyıla Göre Sorgula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Yıla Göre Sorgula";
            // 
            // txtyilsorgu
            // 
            this.txtyilsorgu.Location = new System.Drawing.Point(160, 287);
            this.txtyilsorgu.Name = "txtyilsorgu";
            this.txtyilsorgu.Size = new System.Drawing.Size(155, 22);
            this.txtyilsorgu.TabIndex = 21;
            // 
            // cmbyariyilsorgu
            // 
            this.cmbyariyilsorgu.FormattingEnabled = true;
            this.cmbyariyilsorgu.Items.AddRange(new object[] {
            "Bahar",
            "Güz"});
            this.cmbyariyilsorgu.Location = new System.Drawing.Point(638, 287);
            this.cmbyariyilsorgu.Name = "cmbyariyilsorgu";
            this.cmbyariyilsorgu.Size = new System.Drawing.Size(104, 24);
            this.cmbyariyilsorgu.TabIndex = 22;
            // 
            // btnsorgula2
            // 
            this.btnsorgula2.Location = new System.Drawing.Point(804, 283);
            this.btnsorgula2.Name = "btnsorgula2";
            this.btnsorgula2.Size = new System.Drawing.Size(80, 28);
            this.btnsorgula2.TabIndex = 23;
            this.btnsorgula2.Text = "Sorgula";
            this.btnsorgula2.UseVisualStyleBackColor = true;
            this.btnsorgula2.Click += new System.EventHandler(this.btnsorgula2_Click);
            // 
            // Sayi
            // 
            this.Sayi.HeaderText = "Column1";
            this.Sayi.MinimumWidth = 6;
            this.Sayi.Name = "Sayi";
            this.Sayi.Width = 125;
            // 
            // OgrenciSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 550);
            this.Controls.Add(this.btnsorgula2);
            this.Controls.Add(this.cmbyariyilsorgu);
            this.Controls.Add(this.txtyilsorgu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnsorgula);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.txtnumarasorgu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OgrenciSorgula";
            this.Text = "OgrenciSorgula";
            this.Load += new System.EventHandler(this.OgrenciSorgula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumarasorgu;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button btnsorgula;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyilsorgu;
        private System.Windows.Forms.ComboBox cmbyariyilsorgu;
        private System.Windows.Forms.Button btnsorgula2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sayi;
    }
}