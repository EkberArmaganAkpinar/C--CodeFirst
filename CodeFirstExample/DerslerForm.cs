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
    public partial class DerslerForm : Form
    {
        public DerslerForm()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            using (var context = new Context())
            {
                dataGridView1.DataSource = context.tDers.ToList();
              
               
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            vizefinalbtn form2 = new vizefinalbtn();
            form2.Show();
            this.Hide();
        }

        private void DerslerForm_Load(object sender, EventArgs e)
        {
            this._LoadData();

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            txtdersAd.Text = txtdersId.Text = txtdersYariyil.Text = txtdersYil.Text = String.Empty;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (e.ColumnIndex == 0)
            {
                using (var context = new Context())
                {
                    var ders = context.tDers.ToList()[index];
                    context.Entry(ders).State = System.Data.Entity.EntityState.Deleted;
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
                txtdersId.Text = dataGridView1.Rows[index].Cells["DersID"].Value.ToString();
                txtdersAd.Text = dataGridView1.Rows[index].Cells["DersAd"].Value.ToString();
                txtdersYil.Text = dataGridView1.Rows[index].Cells["DersYil"].Value.ToString();
                txtdersYariyil.Text = dataGridView1.Rows[index].Cells["DersYariyil"].Value.ToString();


            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                Dersler newDers = new Dersler()
                {
                    DersID = string.IsNullOrEmpty(txtdersId.Text) ? 0 : Convert.ToInt32(txtdersId.Text),
                    DersAd = txtdersAd.Text.ToString(),
                    DersYil = txtdersYil.Text.ToString(),
                    DersYariyil = txtdersYariyil.Text.ToString()


                  

                };

                context.tDers.Attach(newDers);
                context.Entry(newDers).State =
                    string.IsNullOrEmpty(txtdersId.Text) ?
                        System.Data.Entity.EntityState.Added : //eğer ıd varsa ekle yoksa modifiye et yani güncelle
                        System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                this._LoadData();

            }
            txtdersAd.Text = txtdersId.Text = txtdersYil.Text = txtdersYariyil.Text = String.Empty;
        }
    }
}
