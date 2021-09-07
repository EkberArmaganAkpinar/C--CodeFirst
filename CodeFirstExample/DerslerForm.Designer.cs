
namespace CodeFirstExample
{
    partial class DerslerForm
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
            this.backbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.txtdersYariyil = new System.Windows.Forms.TextBox();
            this.txtdersYil = new System.Windows.Forms.TextBox();
            this.txtdersAd = new System.Windows.Forms.TextBox();
            this.txtdersId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(13, 202);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(774, 235);
            this.dataGridView1.TabIndex = 13;
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
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(43, 148);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 37);
            this.backbtn.TabIndex = 14;
            this.backbtn.Text = "Geri";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(601, 148);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 37);
            this.savebtn.TabIndex = 15;
            this.savebtn.Text = "Kaydet";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(488, 148);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 37);
            this.clearbtn.TabIndex = 16;
            this.clearbtn.Text = "Temizle";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // txtdersYariyil
            // 
            this.txtdersYariyil.Location = new System.Drawing.Point(574, 85);
            this.txtdersYariyil.Name = "txtdersYariyil";
            this.txtdersYariyil.Size = new System.Drawing.Size(118, 22);
            this.txtdersYariyil.TabIndex = 17;
            // 
            // txtdersYil
            // 
            this.txtdersYil.Location = new System.Drawing.Point(574, 22);
            this.txtdersYil.Name = "txtdersYil";
            this.txtdersYil.Size = new System.Drawing.Size(118, 22);
            this.txtdersYil.TabIndex = 18;
            // 
            // txtdersAd
            // 
            this.txtdersAd.Location = new System.Drawing.Point(134, 85);
            this.txtdersAd.Name = "txtdersAd";
            this.txtdersAd.Size = new System.Drawing.Size(119, 22);
            this.txtdersAd.TabIndex = 19;
            // 
            // txtdersId
            // 
            this.txtdersId.Enabled = false;
            this.txtdersId.Location = new System.Drawing.Point(134, 25);
            this.txtdersId.Name = "txtdersId";
            this.txtdersId.Size = new System.Drawing.Size(119, 22);
            this.txtdersId.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ders Yarılıyı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ders Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ders ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ders Adı";
            // 
            // DerslerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdersId);
            this.Controls.Add(this.txtdersAd);
            this.Controls.Add(this.txtdersYil);
            this.Controls.Add(this.txtdersYariyil);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DerslerForm";
            this.Text = "DerslerForm";
            this.Load += new System.EventHandler(this.DerslerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.TextBox txtdersYariyil;
        private System.Windows.Forms.TextBox txtdersYil;
        private System.Windows.Forms.TextBox txtdersAd;
        private System.Windows.Forms.TextBox txtdersId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}