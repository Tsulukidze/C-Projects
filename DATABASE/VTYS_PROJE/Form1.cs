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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-56M4591\MSSQLSERVER01;Initial Catalog=MIGROSDB;Integrated Security=True");

        private void btnkategori_Click(object sender, EventArgs e)
        {
            FormKategori obj = new FormKategori();
            obj.Show();
        }

        private void btnmusteri_Click(object sender, EventArgs e)
        {
            FormMusteri obj = new FormMusteri();
            obj.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Execute ISLEMLER", connect);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable D_table = new DataTable();
            data.Fill(D_table);
            dataGridView1.DataSource = D_table;
        }

        private void btnurun_Click(object sender, EventArgs e)
        {
            FormUrun obj = new FormUrun();
            obj.Show();
        }

        private void btnpersonel_Click(object sender, EventArgs e)
        {
            FormPersonel obj = new FormPersonel();
            obj.Show();
        }

        private void btnsube_Click(object sender, EventArgs e)
        {
            FormSube obj = new FormSube();
            obj.Show();
        }

        private void btnfirma_Click(object sender, EventArgs e)
        {
            FormFirma obj = new FormFirma();
            obj.Show();
        }

        private void btnteslimat_Click(object sender, EventArgs e)
        {
            FormTeslimat obj = new FormTeslimat();
            obj.Show();
        }

    }
}
