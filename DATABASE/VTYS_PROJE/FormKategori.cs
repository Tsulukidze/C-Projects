using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VTYS_PROJE
{
    public partial class FormKategori : Form
    {
        public FormKategori()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-56M4591\MSSQLSERVER01;Initial Catalog=MIGROSDB;Integrated Security=True");

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From TBLKATEGORI", connect);
            SqlDataAdapter data = new SqlDataAdapter(command);  // veri baglayci 
            DataTable D_table = new DataTable();
            data.Fill(D_table);
            dataGridView1.DataSource = D_table;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Insert Into TBLKATEGORI (KATEGORIAD) values (@p1)", connect);
            command.Parameters.AddWithValue("@p1", textKategoriAD.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("yeni Kategori Eklendi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textKategoriID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textKategoriAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand S_command = new SqlCommand("Delete From TBLKATEGORI where KATEGORIID=@p1", connect);
            S_command.Parameters.AddWithValue("@p1", textKategoriID.Text);
            S_command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sectiginiz kategori Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand G_command = new SqlCommand("Update TBLKATEGORI set KATEGORIAD=@p1 where KATEGORIID=@p2", connect);
            G_command.Parameters.AddWithValue("@p1", textKategoriAD.Text);
            G_command.Parameters.AddWithValue("@p2", textKategoriID.Text);
            G_command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sectiginiz kategori guncellenmistir");
        }

        private void FormKategori_Load(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TBLKATEGORI WHERE KATEGORIID=@P1", connect);
            command.Parameters.AddWithValue("@p1", textKategoriID.Text);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable D_table = new DataTable();
            data.Fill(D_table);
            dataGridView1.DataSource = D_table;
        }
    }

    //Data Source=DESKTOP-56M4591\MSSQLSERVER01;Initial Catalog=MIGROSDB;Integrated Security=True
}
