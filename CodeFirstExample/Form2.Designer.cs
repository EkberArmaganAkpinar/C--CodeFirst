
namespace CodeFirstExample
{
    partial class vizefinalbtn
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
            this.fakulteekle = new System.Windows.Forms.Button();
            this.bolumekle = new System.Windows.Forms.Button();
            this.ogrenciekle = new System.Windows.Forms.Button();
            this.btndersekle = new System.Windows.Forms.Button();
            this.ogrenciderseklebtn = new System.Windows.Forms.Button();
            this.btnogrencisorgula = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fakulteekle
            // 
            this.fakulteekle.Location = new System.Drawing.Point(122, 60);
            this.fakulteekle.Name = "fakulteekle";
            this.fakulteekle.Size = new System.Drawing.Size(95, 52);
            this.fakulteekle.TabIndex = 0;
            this.fakulteekle.Text = "Fakülte Ekle";
            this.fakulteekle.UseVisualStyleBackColor = true;
            this.fakulteekle.Click += new System.EventHandler(this.fakulteekle_Click);
            // 
            // bolumekle
            // 
            this.bolumekle.Location = new System.Drawing.Point(282, 60);
            this.bolumekle.Name = "bolumekle";
            this.bolumekle.Size = new System.Drawing.Size(95, 52);
            this.bolumekle.TabIndex = 1;
            this.bolumekle.Text = "Bölüm Ekle";
            this.bolumekle.UseVisualStyleBackColor = true;
            this.bolumekle.Click += new System.EventHandler(this.bolumekle_Click);
            // 
            // ogrenciekle
            // 
            this.ogrenciekle.Location = new System.Drawing.Point(122, 156);
            this.ogrenciekle.Name = "ogrenciekle";
            this.ogrenciekle.Size = new System.Drawing.Size(95, 52);
            this.ogrenciekle.TabIndex = 2;
            this.ogrenciekle.Text = "Öğrenci Ekle";
            this.ogrenciekle.UseVisualStyleBackColor = true;
            this.ogrenciekle.Click += new System.EventHandler(this.ogrenciekle_Click);
            // 
            // btndersekle
            // 
            this.btndersekle.Location = new System.Drawing.Point(282, 156);
            this.btndersekle.Name = "btndersekle";
            this.btndersekle.Size = new System.Drawing.Size(95, 52);
            this.btndersekle.TabIndex = 3;
            this.btndersekle.Text = "Ders Ekle";
            this.btndersekle.UseVisualStyleBackColor = true;
            this.btndersekle.Click += new System.EventHandler(this.btndersekle_Click);
            // 
            // ogrenciderseklebtn
            // 
            this.ogrenciderseklebtn.Location = new System.Drawing.Point(450, 60);
            this.ogrenciderseklebtn.Name = "ogrenciderseklebtn";
            this.ogrenciderseklebtn.Size = new System.Drawing.Size(95, 52);
            this.ogrenciderseklebtn.TabIndex = 4;
            this.ogrenciderseklebtn.Text = "Öğrenci Ders Ekle";
            this.ogrenciderseklebtn.UseVisualStyleBackColor = true;
            this.ogrenciderseklebtn.Click += new System.EventHandler(this.ogrenciderseklebtn_Click);
            // 
            // btnogrencisorgula
            // 
            this.btnogrencisorgula.Location = new System.Drawing.Point(450, 156);
            this.btnogrencisorgula.Name = "btnogrencisorgula";
            this.btnogrencisorgula.Size = new System.Drawing.Size(95, 52);
            this.btnogrencisorgula.TabIndex = 5;
            this.btnogrencisorgula.Text = "Öğrenci Sorgula";
            this.btnogrencisorgula.UseVisualStyleBackColor = true;
            this.btnogrencisorgula.Click += new System.EventHandler(this.btnogrencisorgula_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vize Final ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vizefinalbtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnogrencisorgula);
            this.Controls.Add(this.ogrenciderseklebtn);
            this.Controls.Add(this.btndersekle);
            this.Controls.Add(this.ogrenciekle);
            this.Controls.Add(this.bolumekle);
            this.Controls.Add(this.fakulteekle);
            this.Name = "vizefinalbtn";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.vizefinalbtn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fakulteekle;
        private System.Windows.Forms.Button bolumekle;
        private System.Windows.Forms.Button ogrenciekle;
        private System.Windows.Forms.Button btndersekle;
        private System.Windows.Forms.Button ogrenciderseklebtn;
        private System.Windows.Forms.Button btnogrencisorgula;
        private System.Windows.Forms.Button button1;
    }
}