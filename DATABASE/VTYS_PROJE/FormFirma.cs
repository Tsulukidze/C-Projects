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
    public partial class FormFirma : Form
    {
        public FormFirma()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-56M4591\MSSQLSERVER01;Initial Catalog=MIGROSDB;Integrated Security=True");

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From TBLTESLIMATFIRMA", connect);
            SqlDataAdapter data = new SqlDataAdapter(command);  // veri baglayci 
            DataTable D_table = new DataTable();
            data.Fill(D_table);
            dataGridView1.DataSource = D_table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textFirmaID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textFirmaAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textFirmaAdres.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into TBLTESLIMATFIRMA (FIRMAAD,FIRMAADRES) VALUES(@p1,@p2)", connect);
            command.Parameters.AddWithValue("@p1", textFirmaAD.Text);
            command.Parameters.AddWithValue("@p2", textFirmaAdres.Text);

            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Firma ekleme islemi tamamlandi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Delete from TBLTESLIMATFIRMA where FIRMAID=@p1", connect);
            command.Parameters.AddWithValue("@p1", textFirmaID.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Firma Silme islemi tamamlandi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("update TBLTESLIMATFIRMA set FIRMAAD=@p1, FIRMAADRES=@p2 WHERE FIRMAID=@p3", connect);
            command.Parameters.AddWithValue("@p1", textFirmaAD.Text);
            command.Parameters.AddWithValue("@p2", textFirmaAdres.Text);
            command.Parameters.AddWithValue("@p3", textFirmaID.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Firma Guncelleme islemi tamamlandi");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TBLTESLIMATFIRMA WHERE FIRMAAD=@P1", connect);
            command.Parameters.AddWithValue("@p1", textFirmaAD.Text);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable D_table = new DataTable();
            data.Fill(D_table);
            dataGridView1.DataSource = D_table;
        }
    }
}
