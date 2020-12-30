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
    public partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-56M4591\MSSQLSERVER01;Initial Catalog=MIGROSDB;Integrated Security=True");

        void Listele()
        {
            SqlCommand command = new SqlCommand("Select *From TBLMUSTERI ", connect);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable D_table = new DataTable();
            data.Fill(D_table);
            dataGridView1.DataSource = D_table;
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textMusteriID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textMusteriAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textMusteriSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textMusteriSehir.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textMusteriBakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into TBLMUSTERI (MUSTERIAD, MUSTERISOYAD,MUSTERISEHIR,MUSTERIBAKIYE) VALUES(@p1,@p2,@p3,@p4)", connect);
            command.Parameters.AddWithValue("@p1", textMusteriAD.Text);
            command.Parameters.AddWithValue("@p2", textMusteriSoyad.Text);
            command.Parameters.AddWithValue("@p3", textMusteriSehir.Text);
            command.Parameters.AddWithValue("@p4", decimal.Parse(textMusteriBakiye.Text));
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Musteri ekleme islemi tamamlandi");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Delete from TBLMUSTERI where MUSTERIID=@p1", connect);
            command.Parameters.AddWithValue("@p1", textMusteriID.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Musteri Silme islemi tamamlandi");
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("update TBLMUSTERI set MUSTERIAD=@P1, MUSTERISOYAD=@P2, MUSTERISEHIR=@P3, MUSTERIBAKIYE=@P4 WHERE MUSTERIID=@P5", connect);
            command.Parameters.AddWithValue("@p1", textMusteriAD.Text);
            command.Parameters.AddWithValue("@p2", textMusteriSoyad.Text);
            command.Parameters.AddWithValue("@p3", textMusteriSehir.Text);
            command.Parameters.AddWithValue("@p4", decimal.Parse(textMusteriBakiye.Text));
            command.Parameters.AddWithValue("@p5", textMusteriID.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Musteri Guncelleme islemi tamamlandi");
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TBLMUSTERI WHERE MUSTERIAD=@P1", connect);
            command.Parameters.AddWithValue("@p1", textMusteriAD.Text);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable D_table = new DataTable();
            data.Fill(D_table);
            dataGridView1.DataSource = D_table;
        }
    }
}
