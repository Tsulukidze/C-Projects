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
    public partial class FormSube : Form
    {
        public FormSube()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-56M4591\MSSQLSERVER01;Initial Catalog=MIGROSDB;Integrated Security=True");
        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From TBLSUBELER", connect);
            SqlDataAdapter data = new SqlDataAdapter(command);  // veri baglayci 
            DataTable D_table = new DataTable();
            data.Fill(D_table);
            dataGridView1.DataSource = D_table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textSubeID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textSubeSehir.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textSubeAdres.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into TBLSUBELER (SUBESEHIR,SUBEADRES) VALUES(@p1,@p2)", connect);
            command.Parameters.AddWithValue("@p1", textSubeSehir.Text);
            command.Parameters.AddWithValue("@p2", textSubeAdres.Text);

            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sube ekleme islemi tamamlandi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Delete from TBLSUBELER where SUBEID=@p1", connect);
            command.Parameters.AddWithValue("@p1", textSubeID.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sube Silme islemi tamamlandi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("update TBLSUBELER set SUBESEHIR=@p1, SUBEADRES=@p2 WHERE SUBEID=@p3", connect);
            command.Parameters.AddWithValue("@p1", textSubeSehir.Text);
            command.Parameters.AddWithValue("@p2", textSubeAdres.Text);
            command.Parameters.AddWithValue("@p3", textSubeID.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sube Guncelleme islemi tamamlandi");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TBLSUBELER WHERE SUBESEHIR=@P1", connect);
            command.Parameters.AddWithValue("@p1", textSubeSehir.Text);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable D_table = new DataTable();
            data.Fill(D_table);
            dataGridView1.DataSource = D_table;
        }
    }
}
