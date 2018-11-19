using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E_learning_3
{
    public partial class Form2 : Form
    {
        public string idterpilih;
        MySqlConnection koneksi = new MySqlConnection("Server=localhost;Port=3306;Database=elearning;Uid=root;Password=;SslMode=None;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public Form2()
        {
            InitializeComponent();
            tada3();
            tada2();
            tada4();
            ke2();
            tada5();
            tada6();
            tada7();
            tada8();
            tada9();
            tada11();
            tada10();
            tada12();
            tada13();
            tada14();
            tada15();
            tada16();
            tada17();
            tada18();
            tada19();
            tada20();
            tada21();
            tada22();
            pelajar();
            dataGURU();
            nilai();
            Arah.Height = button1.Height;
            Arah.Top = button1.Top;
            label7.Text = Properties.Settings.Default.nama.ToString();
        }
        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            hh.ImageLocation = string.Format(@"siswa\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void tada22()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII RPL%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView28.DataSource = DS.Tables[0];
        }
        private void tada21()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII BDP 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView22.DataSource = DS.Tables[0];
        }
        private void tada20()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII AKL 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView27.DataSource = DS.Tables[0];
        }
        private void tada19()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII AKL 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView26.DataSource = DS.Tables[0];
        }
        private void tada18()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII BDP 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView25.DataSource = DS.Tables[0];
        }
        private void tada17()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII AP 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView29.DataSource = DS.Tables[0];
        }
        private void tada16()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII AP 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView30.DataSource = DS.Tables[0];
        }
        private void tada15()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XI AP 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView21.DataSource = DS.Tables[0];
        }
        private void tada14()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XI AP 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView20.DataSource = DS.Tables[0];
        }
        private void tada13()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XI BDP 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView19.DataSource = DS.Tables[0];
        }
        private void tada12()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XI BDP 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView18.DataSource = DS.Tables[0];
        }
        private void tada11()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XI AKL 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView17.DataSource = DS.Tables[0];
        }
        private void tada9()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XI RPL%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView15.DataSource = DS.Tables[0];
        }
        private void tada10()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XI AKL 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView16.DataSource = DS.Tables[0];
        }
        private void tada8()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X AP 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView14.DataSource = DS.Tables[0];
        }

        private void tada7()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X AP 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView13.DataSource = DS.Tables[0];
        }
        private void tada6()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X BDP 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView12.DataSource = DS.Tables[0];
        }
        private void tada5()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X BDP 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView11.DataSource = DS.Tables[0];
        }
        private void tada4()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X AKL 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView10.DataSource = DS.Tables[0];
        }

        private void tada3()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X AKL 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView9.DataSource = DS.Tables[0];
        }
        private void tada2()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X RPL%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
        private void dataGURU()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM `data_guru`", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView4.DataSource = DS.Tables[0];
        }
        private void ke2()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM `data_siswa`", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView6.DataSource = DS.Tables[0];
        }
        private void pelajar()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `pelajaran`", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView2.DataSource = DS.Tables[0];
        }
        private void nilai()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM `nilai_siswa`", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView8.DataSource = DS.Tables[0];
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label7.Text = Properties.Settings.Default.nama.ToString();
            label10.Text = DateTime.Now.ToLongDateString();
        }

        private void JamDigital_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arah.Height = button1.Height;
            Arah.Top = button1.Top;
            panel7.Height = 0;
            panel9.Height = 0;
            Materi.Height = 0;
            Siswa.Height = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Akan Keluar Dari Aplikasi Ini ?", "Informasi My Applikasi", MessageBoxButtons.YesNo) == DialogResult.No) ;
            else
            {
                Application.Exit();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Arah.Height = button5.Height;
            Arah.Top = button5.Top;
            panel9.Height = 0;
            Materi.Height = 0;
            panel31.Height = 0;
            Siswa.Height = 0;
            panel7.Height = 518;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Arah.Height = button6.Height;
            Arah.Top = button6.Top;
            panel9.Height = 0;
            panel31.Height = 0;
            Siswa.Height = 0;
            panel7.Height = 0;
            Materi.Height = 518;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arah.Height = button2.Height;
            Arah.Top = button2.Top;
            Materi.Height = 0;
            panel7.Height = 0;
            Siswa.Height = 0;
            panel31.Height = 0;
            panel9.Height = 518;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Arah.Height = button7.Height;
            Arah.Top = button7.Top;
            panel9.Height = 0;
            panel7.Height = 0;
            panel31.Height = 0;
            Materi.Height = 0;
            Siswa.Height = 518;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arah.Height = button3.Height;
            Arah.Top = button3.Top;
            panel9.Height = 0;
            panel7.Height = 0;
            Materi.Height = 0;
            Siswa.Height = 0;
            panel31.Height = 518;
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView8.CurrentCell.RowIndex;
            idterpilih = dataGridView8.Rows[row].Cells[0].Value.ToString();
            bunifuMaterialTextbox1.Text = dataGridView8.Rows[row].Cells[1].Value.ToString();
            textBox2.Text = dataGridView8.Rows[row].Cells[2].Value.ToString();
            bunifuMaterialTextbox6.Text = dataGridView8.Rows[row].Cells[3].Value.ToString();
            comboBox8.Text = dataGridView8.Rows[row].Cells[4].Value.ToString();
            textBox16.Text = dataGridView8.Rows[row].Cells[5].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
            textBox2.Text = "";
            comboBox8.Text = "";
            textBox16.Text = "";
        }
        private void c8()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `nilai_siswa` WHERE `nama_siswa` like'%" + bunifuMaterialTextbox3.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView8.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            c8();
        }
        private void c2()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `nilai_siswa` WHERE `nis_siswa` like'%" + bunifuMaterialTextbox5.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView8.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            c2();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView2.CurrentCell.RowIndex;
            bunifuMaterialTextbox2.Text = dataGridView2.Rows[row].Cells[0].Value.ToString();
            textBox3.Text = dataGridView2.Rows[row].Cells[1].Value.ToString();
            textBox4.Text = dataGridView2.Rows[row].Cells[2].Value.ToString();
        }

        private void textBox5_OnValueChanged(object sender, EventArgs e)
        {
            c28();
        }
        private void c28()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `data_guru` WHERE `nama_guru` like'%" + textBox5.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView4.DataSource = DS.Tables[0];
        }
        private void label77_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }
        private void c29()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `data_siswa` WHERE `nama_siswa` like'%" + bunifuMaterialTextbox4.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView6.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {
            c29();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox4.Text = "";
        }
        private void c30()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `data_siswa` WHERE `kelas_siswa` like'%" + comboBox1.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView6.DataSource = DS.Tables[0];
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c30();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox4.Text = "";
            comboBox1.Text = "";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            panel13.Height = 489;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            panel19.Height = 490;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            panel29.Height = 489;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel14.Width = 680;
            tada2();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel15.Width = 680;
            tada3();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel16.Width = 680;
            tada4();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel17.Width = 680;
            tada5();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel18.Width = 680;
            tada6();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel8.Width = 680;
            tada7();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            panel11.Width = 680;
            tada8();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            panel13.Height = 0;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            panel14.Width = 0;
            tada2();
        }
        private void c5()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox9.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox9_OnValueChanged(object sender, EventArgs e)
        {
            c5();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox9.Text = "";
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            tada2();
        }
        private void c6()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox10.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView9.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox10_OnValueChanged(object sender, EventArgs e)
        {
            c6();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            panel15.Width = 0;
            tada3();
        }

        private void label36_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox10.Text = "";
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            tada3();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            panel16.Width = 0;
            tada4();
        }
        private void c7()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox11.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView10.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox11_OnValueChanged(object sender, EventArgs e)
        {
            c7();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox11.Text = "";
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            tada4();
        }
        private void c9()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox12.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView11.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox12_OnValueChanged(object sender, EventArgs e)
        {
            c9();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            panel17.Width = 0;
            tada5();
        }

        private void label41_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox12.Text = "";
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            tada5();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            panel18.Width = 0;
            tada6();
        }
        private void c10()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox13.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView12.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox13_OnValueChanged(object sender, EventArgs e)
        {
            c10();
        }

        private void label42_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox13.Text = "";
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            tada6();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            panel8.Width = 0;
            tada7();
        }
        private void c11()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox14.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView13.DataSource = dt;
            koneksi.Close();
        }
        private void bunifuMaterialTextbox14_OnValueChanged(object sender, EventArgs e)
        {
            c11();
        }

        private void label43_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox14.Text = "";
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            tada7();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            panel11.Width = 0;
            tada8();
        }
        private void c12()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox15.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView14.DataSource = dt;
            koneksi.Close();
        }
        private void bunifuMaterialTextbox15_OnValueChanged(object sender, EventArgs e)
        {
            c12();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox15.Text = "";
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            tada8();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            panel19.Height = 0;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            tada15();
            panel28.Width = 680;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            panel27.Width = 680;
            tada14();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            panel26.Width = 680;
            tada13();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            panel25.Width = 680;
            tada12();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            panel24.Width = 680;
            tada11();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            panel23.Width = 680;
            tada10();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            panel22.Width = 680;
            tada9();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            panel22.Width = 0;
            tada9();
        }
        private void c13()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox16.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView15.DataSource = dt;
            koneksi.Close();
        }

        private void bunifuMaterialTextbox16_OnValueChanged(object sender, EventArgs e)
        {
            c13();
        }

        private void label45_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox16.Text = "";
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {
            tada9();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            panel23.Width = 0;
            tada10();
        }
        private void c14()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox17.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView16.DataSource = dt;
            koneksi.Close();
        }
        private void label46_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox17.Text = "";
        }

        private void bunifuMaterialTextbox17_OnValueChanged(object sender, EventArgs e)
        {
            c14();
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {
            tada10();
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {
            tada11();
        }
        private void c15()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox18.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView17.DataSource = dt;
            koneksi.Close();
        }
        private void bunifuMaterialTextbox18_OnValueChanged(object sender, EventArgs e)
        {
            c15();
        }

        private void label48_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox18.Text = "";
        }

        private void button58_Click(object sender, EventArgs e)
        {
            panel24.Width = 0;
            tada11();
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {
            tada12();
        }
        private void c16()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox19.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView18.DataSource = dt;
            koneksi.Close();
        }
        private void bunifuMaterialTextbox19_OnValueChanged(object sender, EventArgs e)
        {
            c16();
        }

        private void label49_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox19.Text = "";
        }

        private void button59_Click(object sender, EventArgs e)
        {
            panel25.Width = 0;
            tada12();
        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {
            tada13();
        }
        private void c17()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox20.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView19.DataSource = dt;
            koneksi.Close();
        }
        private void bunifuMaterialTextbox20_OnValueChanged(object sender, EventArgs e)
        {
            c17();
        }

        private void label50_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox20.Text = "";
        }

        private void button60_Click(object sender, EventArgs e)
        {
            panel26.Width = 0;
            tada13();
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {
            tada14();
        }
        private void c18()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox21.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView20.DataSource = dt;
            koneksi.Close();
        }
        private void bunifuMaterialTextbox21_OnValueChanged(object sender, EventArgs e)
        {
            c18();
        }

        private void label51_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox21.Text = "";
        }

        private void button61_Click(object sender, EventArgs e)
        {
            panel27.Width = 0;
            tada14();
        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {
            tada15();
        }
        private void c19()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox22.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView21.DataSource = dt;
            koneksi.Close();
        }
        private void bunifuMaterialTextbox22_OnValueChanged(object sender, EventArgs e)
        {
            c19();
        }

        private void label53_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox22.Text = "";
        }

        private void button62_Click(object sender, EventArgs e)
        {
            panel28.Width = 0;
            tada15();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            panel29.Height = 0;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            panel37.Width = 680;
            tada17();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            panel38.Width = 680;
            tada16();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            panel30.Width = 680;
            tada21();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            panel33.Width = 680;
            tada18();
        }

        private void button75_Click(object sender, EventArgs e)
        {
            panel34.Width = 680;
            tada19();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            panel35.Width = 680;
            tada20();
        }

        private void button77_Click(object sender, EventArgs e)
        {
            panel36.Width = 680;
            tada22();
        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {
            tada22();
        }
        private void c20()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox23.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView28.DataSource = dt;
            koneksi.Close();
        }
        private void bunifuMaterialTextbox23_OnValueChanged(object sender, EventArgs e)
        {
            c20();
        }

        private void label54_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox23.Text = "";
        }

        private void button69_Click(object sender, EventArgs e)
        {
            panel36.Width = 0;
            tada22();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            panel35.Width = 0;
            tada20();
        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {
            tada20();
        }
        private void c21()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox24.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView27.DataSource = dt;
            koneksi.Close();
        }
        private void bunifuMaterialTextbox24_OnValueChanged(object sender, EventArgs e)
        {
            c21();
        }

        private void label55_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox23.Text = "";
        }

        private void button67_Click(object sender, EventArgs e)
        {
            panel34.Width = 0;
            tada19();
        }

        private void panel34_Paint(object sender, PaintEventArgs e)
        {
            tada19();
        }
        private void c22()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox25.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView26.DataSource = dt;
            koneksi.Close();
        }
        private void bunifuMaterialTextbox25_OnValueChanged(object sender, EventArgs e)
        {
            c22();
        }

        private void label56_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox25.Text = "";
        }

        private void button66_Click(object sender, EventArgs e)
        {
            panel33.Width = 0;
            tada18();
        }
        private void c23()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox26.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView25.DataSource = dt;
            koneksi.Close();
        }
        private void bunifuMaterialTextbox26_OnValueChanged(object sender, EventArgs e)
        {
            c23();
        }

        private void label57_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox26.Text = "";
        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {
            tada18();
        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {
            tada21();
        }
        private void c24()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox27.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView22.DataSource = dt;
            koneksi.Close();
        }
        private void button63_Click(object sender, EventArgs e)
        {
            panel30.Width = 0;
            tada21();
        }

        private void bunifuMaterialTextbox27_OnValueChanged(object sender, EventArgs e)
        {
            c24();
        }

        private void label59_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox27.Text = "";
        }

        private void panel38_Paint(object sender, PaintEventArgs e)
        {
            tada16();
        }
        private void c25()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox28.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView30.DataSource = dt;
            koneksi.Close();
        }
        private void bunifuMaterialTextbox28_OnValueChanged(object sender, EventArgs e)
        {
            c25();
        }

        private void label60_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox28.Text = "";
        }

        private void button79_Click(object sender, EventArgs e)
        {
            panel38.Width = 0;
            tada16();
        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {
            tada17();
        }
        private void c26()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox29.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView29.DataSource = dt;
            koneksi.Close();
        }
        private void button78_Click(object sender, EventArgs e)
        {
            panel37.Width = 0;
            tada17();
        }

        private void bunifuMaterialTextbox29_OnValueChanged(object sender, EventArgs e)
        {
            c26();
        }

        private void label61_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox29.Text = "";
        }

        private void label71_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox3.Text = "";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox5.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
