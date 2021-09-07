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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            using (var context = new Context())
            {
                dataGridView1.DataSource = context.tFakulte.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(var context = new Context())
            {
                Fakulteler newFakulte = new Fakulteler()
                {
                    FakulteID = string.IsNullOrEmpty(txtFacultyId.Text) ? 0 : Convert.ToInt32(txtFacultyId.Text),
                    FakulteAd = txtFacultyName.Text.ToString()
                };
                context.tFakulte.Attach(newFakulte);
                context.Entry(newFakulte).State = 
                    string.IsNullOrEmpty(txtFacultyId.Text) ? 
                        System.Data.Entity.EntityState.Added : //eğer ıd varsa ekle yoksa modifiye et yani güncelle
                        System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                this._LoadData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFacultyId.Text = txtFacultyName.Text = String.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (e.ColumnIndex == 0 )
            {
                using (var context = new Context())
                {
                    var fakulte = context.tFakulte.ToList()[index];
                    context.Entry(fakulte).State = System.Data.Entity.EntityState.Deleted;//enrtry sor
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
                txtFacultyId.Text = dataGridView1.Rows[index].Cells["FakulteID"].Value.ToString();
                txtFacultyName.Text = dataGridView1.Rows[index].Cells["FakulteAd"].Value.ToString();
            }
        }

        private void txtFacultyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            vizefinalbtn form2 = new vizefinalbtn();
            form2.Show();
            this.Hide();
        }
    }
}
