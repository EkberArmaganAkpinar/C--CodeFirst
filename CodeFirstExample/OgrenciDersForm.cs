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
    public partial class OgrenciDersForm : Form
    {
        public OgrenciDersForm()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            using (var context = new Context())
            {
                dataGridView1.DataSource = context.tOgrenciDersler.ToList();
                var listeogrenci = context.tOgrenci.ToList();
         
                cmbogrencisec.DataSource = listeogrenci;
                cmbogrencisec.DisplayMember = "Numara";
                cmbogrencisec.ValueMember = "Numara";
                var listeders = context.tDers.ToList();
                cmbderssec.DataSource = listeders;
                cmbderssec.DisplayMember = "DersAd";
                cmbderssec.ValueMember = "DersID";
               
               




            }
        }
        private void OgrenciDersForm_Load(object sender, EventArgs e)
        {
            this._LoadData();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            vizefinalbtn form2 = new vizefinalbtn();
            form2.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (e.ColumnIndex == 0)
            {
                using (var context = new Context())
                {
                    var ogrenciders = context.tOgrenciDersler.ToList()[index];
                    context.Entry(ogrenciders).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    this._LoadData();
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (e.ColumnIndex != 0)
            {
                txtogrenciders.Text = dataGridView1.Rows[index].Cells["OgrenciDersID"].Value.ToString();
              
                cmbderssec.SelectedValue= dataGridView1.Rows[index].Cells["DersID"].Value;


            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {

                OgrenciDersler newOgrenciDersler = new OgrenciDersler()
                {
                    OgrenciDersID = string.IsNullOrEmpty(txtogrenciders.Text) ? 0 : Convert.ToInt32(txtogrenciders.Text),
                    OgrenciID= Convert.ToInt32(cmbogrencisec.SelectedValue),
                    DersID = Convert.ToInt32(cmbderssec.SelectedValue),
                    Yil = cmbyilsec.Text.ToString(),
                    YariYil = cmbyariyilsec.Text.ToString(),
                    Vize="",
                    Final=""

                };

                context.tOgrenciDersler.Attach(newOgrenciDersler);
                context.Entry(newOgrenciDersler).State =
                    string.IsNullOrEmpty(txtogrenciders.Text) ?
                        System.Data.Entity.EntityState.Added : //eğer ıd varsa ekle yoksa modifiye et yani güncelle
                        System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                this._LoadData();

            }


        }
    }
}
