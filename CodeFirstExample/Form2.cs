using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstExample
{
    public partial class vizefinalbtn : Form
    {
        public vizefinalbtn()
        {
            InitializeComponent();
        }

        private void fakulteekle_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void bolumekle_Click(object sender, EventArgs e)
        {
            BolumForm bolumform = new BolumForm();
            bolumform.Show();
            this.Hide();

        }

        private void ogrenciekle_Click(object sender, EventArgs e)
        {
            OgrenciForm ogrenciform = new OgrenciForm();
            ogrenciform.Show();
            this.Hide();

        }

        private void btndersekle_Click(object sender, EventArgs e)
        {
            DerslerForm derslerForm = new DerslerForm();
            derslerForm.Show();
            this.Hide();
        }

        private void ogrenciderseklebtn_Click(object sender, EventArgs e)
        {
            OgrenciDersForm ogrenciDersForm = new OgrenciDersForm();
            ogrenciDersForm.Show();
            this.Hide();
        }

        private void btnogrencisorgula_Click(object sender, EventArgs e)
        {
            OgrenciSorgula ogrenciSorgula = new OgrenciSorgula();
            ogrenciSorgula.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vVizeFinalForm vVizeFinalForm = new vVizeFinalForm();
            vVizeFinalForm.Show();
            this.Hide();
        }

        private void vizefinalbtn_Load(object sender, EventArgs e)
        {

        }
    }
}
