
namespace VTYS_PROJE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnurun = new System.Windows.Forms.Button();
            this.btnmusteri = new System.Windows.Forms.Button();
            this.btnkategori = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnpersonel = new System.Windows.Forms.Button();
            this.btnsube = new System.Windows.Forms.Button();
            this.btnfirma = new System.Windows.Forms.Button();
            this.btnteslimat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnteslimat);
            this.panel1.Controls.Add(this.btnfirma);
            this.panel1.Controls.Add(this.btnsube);
            this.panel1.Controls.Add(this.btnpersonel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnurun);
            this.panel1.Controls.Add(this.btnmusteri);
            this.panel1.Controls.Add(this.btnkategori);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 570);
            this.panel1.TabIndex = 0;
//            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnurun
            // 
            this.btnurun.BackColor = System.Drawing.Color.DarkOrange;
            this.btnurun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnurun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnurun.Location = new System.Drawing.Point(3, 319);
            this.btnurun.Name = "btnurun";
            this.btnurun.Size = new System.Drawing.Size(190, 41);
            this.btnurun.TabIndex = 2;
            this.btnurun.Text = "ÜRÜNLER";
            this.btnurun.UseVisualStyleBackColor = false;
            this.btnurun.Click += new System.EventHandler(this.btnurun_Click);
            // 
            // btnmusteri
            // 
            this.btnmusteri.BackColor = System.Drawing.Color.DarkOrange;
            this.btnmusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmusteri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmusteri.Location = new System.Drawing.Point(3, 272);
            this.btnmusteri.Name = "btnmusteri";
            this.btnmusteri.Size = new System.Drawing.Size(190, 41);
            this.btnmusteri.TabIndex = 1;
            this.btnmusteri.Text = "MÜŞTERİLER";
            this.btnmusteri.UseVisualStyleBackColor = false;
            this.btnmusteri.Click += new System.EventHandler(this.btnmusteri_Click);
            // 
            // btnkategori
            // 
            this.btnkategori.BackColor = System.Drawing.Color.DarkOrange;
            this.btnkategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkategori.Location = new System.Drawing.Point(3, 225);
            this.btnkategori.Name = "btnkategori";
            this.btnkategori.Size = new System.Drawing.Size(190, 41);
            this.btnkategori.TabIndex = 0;
            this.btnkategori.Text = "KATEGORİ";
            this.btnkategori.UseVisualStyleBackColor = false;
            this.btnkategori.Click += new System.EventHandler(this.btnkategori_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(690, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(785, 345);
            this.dataGridView1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(311, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(313, 178);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btnpersonel
            // 
            this.btnpersonel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnpersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpersonel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpersonel.Location = new System.Drawing.Point(3, 366);
            this.btnpersonel.Name = "btnpersonel";
            this.btnpersonel.Size = new System.Drawing.Size(190, 41);
            this.btnpersonel.TabIndex = 4;
            this.btnpersonel.Text = "PERSONEL";
            this.btnpersonel.UseVisualStyleBackColor = false;
            this.btnpersonel.Click += new System.EventHandler(this.btnpersonel_Click);
            // 
            // btnsube
            // 
            this.btnsube.BackColor = System.Drawing.Color.DarkOrange;
            this.btnsube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsube.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsube.Location = new System.Drawing.Point(3, 413);
            this.btnsube.Name = "btnsube";
            this.btnsube.Size = new System.Drawing.Size(190, 41);
            this.btnsube.TabIndex = 5;
            this.btnsube.Text = "ŞUBELER";
            this.btnsube.UseVisualStyleBackColor = false;
            this.btnsube.Click += new System.EventHandler(this.btnsube_Click);
            // 
            // btnfirma
            // 
            this.btnfirma.BackColor = System.Drawing.Color.DarkOrange;
            this.btnfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfirma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfirma.Location = new System.Drawing.Point(3, 460);
            this.btnfirma.Name = "btnfirma";
            this.btnfirma.Size = new System.Drawing.Size(190, 43);
            this.btnfirma.TabIndex = 6;
            this.btnfirma.Text = "TESLIMAT FIRMA";
            this.btnfirma.UseVisualStyleBackColor = false;
            this.btnfirma.Click += new System.EventHandler(this.btnfirma_Click);
            // 
            // btnteslimat
            // 
            this.btnteslimat.BackColor = System.Drawing.Color.DarkOrange;
            this.btnteslimat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnteslimat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnteslimat.Location = new System.Drawing.Point(3, 509);
            this.btnteslimat.Name = "btnteslimat";
            this.btnteslimat.Size = new System.Drawing.Size(190, 43);
            this.btnteslimat.TabIndex = 7;
            this.btnteslimat.Text = "TESLIMAT";
            this.btnteslimat.UseVisualStyleBackColor = false;
            this.btnteslimat.Click += new System.EventHandler(this.btnteslimat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1092, 570);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnkategori;
        private System.Windows.Forms.Button btnmusteri;
        private System.Windows.Forms.Button btnurun;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnpersonel;
        private System.Windows.Forms.Button btnsube;
        private System.Windows.Forms.Button btnfirma;
        private System.Windows.Forms.Button btnteslimat;
    }
}

