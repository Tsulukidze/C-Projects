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
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-56M4591\MSSQLSERVER01;Initial Catalog=MIGROSDB;Integrated Security=True");

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From TBLPERSONEL", connect);
            SqlDataAdapter data = new SqlDataAdapter(command);  // veri baglayci 
            DataTable D_table = new DataTable();
            data.Fill(D_table);
            dataGridView1.DataSource = D_table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textPesonelID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textPersonelAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textPersonelSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into TBLPERSONEL (PERSONELAD,PERSONELSOYAD) VALUES(@p1,@p2)", connect);
            command.Parameters.AddWithValue("@p1", textPersonelAD.Text);
            command.Parameters.AddWithValue("@p2", textPersonelSoyad.Text);
    
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Personel ekleme islemi tamamlandi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Delete from TBLPERSONEL where PERSONELID=@p1", connect);
            command.Parameters.AddWithValue("@p1", textPesonelID.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Personel Silme islemi tamamlandi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("update TBLPERSONEL set PERSONELAD=@p1, PERSONELSOYAD=@p2 WHERE PERSONELID=@p3", connect);
            command.Parameters.AddWithValue("@p1", textPersonelAD.Text);
            command.Parameters.AddWithValue("@p2", textPersonelSoyad.Text);
            command.Parameters.AddWithValue("@p3", textPesonelID.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Personel Guncelleme islemi tamamlandi");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TBLPERSONEL WHERE PERSONELID=@P1", connect);
            command.Parameters.AddWithValue("@p1", textPesonelID.Text);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable D_table = new DataTable();
            data.Fill(D_table);
            dataGridView1.DataSource = D_table;
        }
    }
}
