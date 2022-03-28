using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMahasiswa1
{
    public partial class FrmDataKursus : Form
    {
        public FrmDataKursus()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int baris = 0;
            dgvDataKursus.Rows.Add();
            baris = dgvDataKursus.Rows.Count - 2;

            string jk;
            if (rdbLaki.Checked == true)
            {
                jk = "Laki-laki";
            }
            else
            {
                jk = "Perempuan";
            }

            dgvDataKursus[0, baris].Value = dgvDataKursus.Rows.Count - 1;
            dgvDataKursus[1, baris].Value = txtNama.Text;
            dgvDataKursus[2, baris].Value = jk;
            dgvDataKursus[3, baris].Value = txtTempatLahir.Text;
            dgvDataKursus[4, baris].Value = dtpTanggalLahir.Text;
            dgvDataKursus[5, baris].Value = txtAlamat.Text;
            dgvDataKursus[6, baris].Value = cmbMskn.SelectedItem.ToString();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (this.dgvDataKursus.SelectedRows.Count > 0)
            {
                dgvDataKursus.Rows.RemoveAt(this.dgvDataKursus.SelectedRows[0].Index);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
