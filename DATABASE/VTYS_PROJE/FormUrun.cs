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
    public partial class FormUrun : Form
    {
        public FormUrun()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-56M4591\MSSQLSERVER01;Initial Catalog=MIGROSDB;Integrated Security=True");

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Execute URUNISLEM", connect);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable D_table = new DataTable();
            data.Fill(D_table);
            dataGridView1.DataSource = D_table;
        }

   
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textUrunID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textUrunAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textUrunMarka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textUrunKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textUrunFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textUrunDepo.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into TBLURUN (URUNAD,URUNMARKA,KATEGORI,URUNFIYATI,URUNDEPO) VALUES(@p1,@p2,@p3,@p4,@p5)", connect);
            command.Parameters.AddWithValue("@p1", textUrunAD.Text);
            command.Parameters.AddWithValue("@p2", textUrunMarka.Text);
            command.Parameters.AddWithValue("@p3", textUrunKategori.Text);
            command.Parameters.AddWithValue("@p4", decimal.Parse(textUrunFiyat.Text));
            command.Parameters.AddWithValue("@p5", textUrunDepo.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Urun ekleme islemi tamamlandi");
          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Delete from TBLURUN where URUNID=@p1", connect);
            command.Parameters.AddWithValue("@p1", textUrunID.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Urun Silme islemi tamamlandi");
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("update TBLURUN set URUNAD=@P1, URUNMARKA=@P2, KATEGORI=@P3, URUNFIYATI=@P4,URUNDEPO=@P5 WHERE URUNID=@P6", connect);
            command.Parameters.AddWithValue("@p1", textUrunAD.Text);
            command.Parameters.AddWithValue("@p2", textUrunMarka.Text);
            command.Parameters.AddWithValue("@p3", textUrunKategori.Text);
            command.Parameters.AddWithValue("@p4", decimal.Parse(textUrunFiyat.Text));
            command.Parameters.AddWithValue("@p5", textUrunDepo.Text);
            command.Parameters.AddWithValue("@p6", textUrunID.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Urun Guncelleme islemi tamamlandi");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TBLURUN WHERE URUNAD=@P1", connect);
            command.Parameters.AddWithValue("@p1", textUrunAD.Text);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable D_table = new DataTable();
            data.Fill(D_table);
            dataGridView1.DataSource = D_table;
        }
    }
}
