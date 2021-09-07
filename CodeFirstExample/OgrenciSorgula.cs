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
    public partial class OgrenciSorgula : Form
    {
        public OgrenciSorgula()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            using (var context = new Context())
            {
                dataGridView1.DataSource = context.tOgrenciDersler.ToList();
               dataGridView2.DataSource = context.tOgrenciDersler.ToList();
                

            }
        }
        private void OgrenciSorgula_Load(object sender, EventArgs e)
        {
            this._LoadData();

        }

        private void txtnumarasorgu_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            vizefinalbtn form2 = new vizefinalbtn();
            form2.Show();
            this.Hide();
        }

        private void btnsorgula_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                int degertut = Convert.ToInt32(txtnumarasorgu.Text);

                
                var deger = context.tOgrenciDersler.Select(x => new { ders = x.DersID,
                ogr=x.OgrenciID}).Where(x=>x.ogr==degertut);
                dataGridView1.DataSource = deger.ToList();
                degertut = 0;
            }
        }

        private void btnsorgula2_Click(object sender, EventArgs e)
        {
            using (var context=new Context())
            {
               
                var deger = context.tOgrenciDersler.Where(x => x.YariYil == cmbyariyilsorgu.Text && x.Yil == txtyilsorgu.Text); 
                var deger2 = deger.OrderBy(x => x.DersID).GroupBy(x => x.DersID).Select(y => new
                {

                    Dersid = y.Key,
                    OgrenciSayisi = y.Count()
                });
                dataGridView2.DataSource = deger2.ToList();
                
            }
        }
    }
}
