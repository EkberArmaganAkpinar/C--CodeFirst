using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirstExample.Entities;

namespace CodeFirstExample
{
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void _LoadData()
        {
            using (var context = new Context())
            {
                dataGridView1.DataSource = context.tOgrenci.ToList();
                var listead = context.tBolum.ToList();
                comboBox1.DataSource = listead;
                comboBox1.DisplayMember = "BolumAd";
                comboBox1.ValueMember = "BolumID";
              

                
            }
        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            this._LoadData();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            txtAd.Text = txtSoyad.Text = txtOgrenciid.Text  = String.Empty;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
               
                Ogrenciler newOgrenci = new Ogrenciler()
                {
                    OgrenciID = string.IsNullOrEmpty(txtOgrenciid.Text) ? 0 : Convert.ToInt32(txtOgrenciid.Text),
                    Ad = txtAd.Text.ToString(),
                    Soyad = txtSoyad.Text.ToString(),
                    BolumID = Convert.ToInt32(comboBox1.SelectedValue),
                    Numara=txtnumber.Text.ToString()
                   
                };

                context.tOgrenci.Attach(newOgrenci);
                context.Entry(newOgrenci).State =
                    string.IsNullOrEmpty(txtOgrenciid.Text) ?
                        System.Data.Entity.EntityState.Added : //eğer textbox içerisinde id varsa ekle yoksa modifiye et yani güncelle
                        System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                this._LoadData();

            }
            txtAd.Text = txtSoyad.Text = txtOgrenciid.Text  = String.Empty;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (e.ColumnIndex == 0)
            {
                using (var context = new Context())
                {
                    var ogrenci = context.tOgrenci.ToList()[index];
                    context.Entry(ogrenci).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    this._LoadData();
                }
                
            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (e.ColumnIndex != 0)
            {
                txtOgrenciid.Text = dataGridView1.Rows[index].Cells["OgrenciID"].Value.ToString();
                txtAd.Text = dataGridView1.Rows[index].Cells["Ad"].Value.ToString();
                txtSoyad.Text = dataGridView1.Rows[index].Cells["Soyad"].Value.ToString();
                txtnumber.Text = dataGridView1.Rows[index].Cells["Numara"].Value.ToString();
                comboBox1.SelectedValue = dataGridView1.Rows[index].Cells["BolumID"].Value;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            vizefinalbtn form2 = new vizefinalbtn();
            form2.Show();
            this.Hide();
        }
    }
}
