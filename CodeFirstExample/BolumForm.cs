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
    public partial class BolumForm : Form
    {
        public BolumForm()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            using (var context = new Context())
            {
                dataGridView1.DataSource = context.tBolum.ToList();
                var listead = context.tFakulte.ToList();
                cmbfakulte.DataSource = listead;
                cmbfakulte.DisplayMember = "FakulteAd";
                cmbfakulte.ValueMember = "FakulteID";



            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtBolumID.Text = txtBolumAd.Text = String.Empty;
        }

        private void BolumForm_Load(object sender, EventArgs e)
        {
            this._LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                Bolumler newBolum = new Bolumler()
                {
                    BolumID = string.IsNullOrEmpty(txtBolumID.Text) ? 0 : Convert.ToInt32(txtBolumID.Text),
                    BolumAd = txtBolumAd.Text.ToString(),

                    fakulteID = Convert.ToInt32(cmbfakulte.SelectedValue)

                };

                context.tBolum.Attach(newBolum);
                context.Entry(newBolum).State =
                    string.IsNullOrEmpty(txtBolumID.Text) ?
                        System.Data.Entity.EntityState.Added : //eğer ıd varsa ekle yoksa modifiye et yani güncelle
                        System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                this._LoadData();

            }
            txtBolumAd.Text = txtBolumID.Text = String.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (e.ColumnIndex == 0)
            {
                using (var context = new Context())
                {
                    var bolum = context.tBolum.ToList()[index];
                    context.Entry(bolum).State = System.Data.Entity.EntityState.Deleted;
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
                txtBolumID.Text = dataGridView1.Rows[index].Cells["BolumID"].Value.ToString();
                txtBolumAd.Text = dataGridView1.Rows[index].Cells["BolumAd"].Value.ToString();
                 cmbfakulte.SelectedValue= dataGridView1.Rows[index].Cells["FakulteID"].Value;

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
