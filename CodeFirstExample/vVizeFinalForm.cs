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
    public partial class vVizeFinalForm : Form
    {
        String yiltut;
        String yariyiltut;
        int dersidtut;
        int ogrencidersidtut;

        public vVizeFinalForm()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            using (var context = new Context())
            {
                var listeders = context.tDers.ToList();
                dataGridView1.DataSource = context.tOgrenciDersler.ToList();
                 comboBox1.DataSource = listeders;
                 comboBox1.DisplayMember = "DersAd";
                 comboBox1.ValueMember = "DersID";





            }
        }
            private void vVizeFinalForm_Load(object sender, EventArgs e)
        {
            this._LoadData();
        }

        private void btnsorgu_Click(object sender, EventArgs e)
        {
            using (var context =new Context())
            {
             
                int degertut =Convert.ToInt32(comboBox1.SelectedValue.ToString()) ;
                var deger = context.tOgrenciDersler.Where(x => x.DersID == degertut);
                dataGridView1.DataSource = deger.ToList();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (e.ColumnIndex != 0)
            {
                txtogrenciid.Text = dataGridView1.Rows[index].Cells["OgrenciID"].Value.ToString();
                txtvize.Text = dataGridView1.Rows[index].Cells["Vize"].Value.ToString();
                txtfinal.Text = dataGridView1.Rows[index].Cells["Final"].Value.ToString();
                yiltut= dataGridView1.Rows[index].Cells["Yil"].Value.ToString();
                yariyiltut= dataGridView1.Rows[index].Cells["YariYil"].Value.ToString();
                dersidtut = Convert.ToInt32(dataGridView1.Rows[index].Cells["DersID"].Value.ToString());
                ogrencidersidtut = Convert.ToInt32(dataGridView1.Rows[index].Cells["OgrenciDersID"].Value.ToString());


            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                OgrenciDersler newogrenciDers = new OgrenciDersler()
                {
                    OgrenciID = string.IsNullOrEmpty(txtogrenciid.Text) ? 0 : Convert.ToInt32(txtogrenciid.Text),
                  
                     Vize=txtvize.Text.ToString(),
                     Final=txtfinal.Text.ToString(),
                     Yil=yiltut,
                     YariYil=yariyiltut,
                     DersID=dersidtut,
                     OgrenciDersID=ogrencidersidtut





                };

                context.tOgrenciDersler.Attach(newogrenciDers);
                context.Entry(newogrenciDers).State =
                    string.IsNullOrEmpty(txtogrenciid.Text) ?
                        System.Data.Entity.EntityState.Added : //eğer ıd varsa ekle yoksa modifiye et yani güncelle
                        System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                this._LoadData();

            }
            txtogrenciid.Text = txtvize.Text = txtfinal.Text = String.Empty;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            vizefinalbtn vizefinalbtn = new vizefinalbtn();
            vizefinalbtn.Show();
            this.Hide();
        }
    }
}
