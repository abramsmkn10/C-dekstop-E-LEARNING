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
using Spire.Xls;
namespace E_learning_3
{

    public partial class Form4 : Form
    {
        public string idterpilih;
        MySqlConnection koneksi = new MySqlConnection("Server=localhost;Port=3306;Database=elearning;Uid=root;Password=;SslMode=None;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public Form4()
        {
            InitializeComponent();
            tada();
            tada3();
            tada2();
            tada4();
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
            ke2();
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
        private void nilai()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM `nilai_siswa`", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView8.DataSource = DS.Tables[0];
            dataGridView23.DataSource = DS.Tables[0];
        }
        private void ke2()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM `data_siswa`", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView7.DataSource = DS.Tables[0];
            dataGridView24.DataSource = DS.Tables[0];
        }
        private void tada()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM `kelas_ajar`", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView3.DataSource = DS.Tables[0];
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Arah.Height = button7.Height;
            Arah.Top = button7.Top;
            panel9.Height = 0;
            Import.Height = 0;
            Materi.Height = 0;
            Eksport.Width = 0;
            panel7.Height = 0;
            Siswa.Height = 518;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arah.Height = button1.Height;
            Arah.Top = button1.Top;
            panel7.Height = 0;
            panel9.Height = 0;
            Import.Height = 0;
            Eksport.Width = 0;
            Materi.Height = 0;
            Siswa.Height = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Arah.Height = button5.Height;
            Arah.Top = button5.Top;
            panel9.Height = 0;
            Materi.Height = 0;
            Import.Height = 0;
            Eksport.Width = 0;
            Siswa.Height = 0;
            panel7.Height = 518;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Arah.Height = button6.Height;
            Arah.Top = button6.Top;
            panel9.Height = 0;
            Eksport.Width = 0;
            Import.Height = 0;
            panel7.Height = 0;
            Siswa.Height = 0;
            Materi.Height = 518;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arah.Height = button3.Height;
            Arah.Top = button3.Top;
            Import.Height = 0;
            panel7.Height = 0;
            panel9.Height = 0;
            Eksport.Width = 0;
            Materi.Height = 0;
            Siswa.Height = 0;
            Eksport.Width = 687;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Arah.Height = button4.Height;
            Arah.Top = button4.Top;
            Import.Height = 518;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arah.Height = button2.Height;
            Arah.Top = button2.Top;
            Import.Height = 0;
            Eksport.Width = 0;
            Materi.Height = 0;
            panel7.Height = 0;
            Materi.Height = 0;
            Siswa.Height = 0;
            panel9.Height = 518;
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            label7.Text = Properties.Settings.Default.nama.ToString();
            label10.Text = DateTime.Now.ToLongDateString();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Akan Keluar Dari Aplikasi Ini ?", "Informasi My Applikasi", MessageBoxButtons.YesNo) == DialogResult.No) ;
            else
            {
                Application.Exit();
            }
        }
        private void comboBox4_DropDown(object sender, EventArgs e)
        {
            
        }
        private void pelajar()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `pelajaran`", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView2.DataSource = DS.Tables[0];
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox4.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT into pelajaran(`Pelajaran`, `tipe_pelajaran`, `materi`) VALUES ('" + comboBox4.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil tambah data pelajaran","Informasi");
                    pelajar();
                    comboBox4.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox4.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `pelajaran` set `pelajaran`='" + comboBox4.Text + "', `tipe_pelajaran`='" + textBox3.Text + "', `materi`='" + textBox4.Text + "' where `pelajaran`='" + comboBox4.Text + "'", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil mengubah data pelajaran", "Informasi");
                    pelajar();
                    comboBox4.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox4.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `pelajaran` WHERE `pelajaran`='" + comboBox4.Text + "'", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil menghapus data pelajaran", "Informasi");
                    pelajar();
                    comboBox4.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView2.CurrentCell.RowIndex;
            comboBox4.Text = dataGridView2.Rows[row].Cells[0].Value.ToString();
            textBox3.Text = dataGridView2.Rows[row].Cells[1].Value.ToString();
            textBox4.Text = dataGridView2.Rows[row].Cells[2].Value.ToString();
        }
        private void dataGURU()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM `data_guru`", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView4.DataSource = DS.Tables[0];
            dataGridView5.DataSource = DS.Tables[0];
        }
        private void groupBox8_Enter(object sender, EventArgs e)
        {
            dataGURU();
        }
        private void button17_Click(object sender, EventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {
            comboBox4.Items.Add("Pendidikan Agama");
            comboBox4.Items.Add("Bahasa Indonesia");
            comboBox4.Items.Add("Bahasa Inggris");
            comboBox4.Items.Add("Pendidikan Kewarganegaraan");
            comboBox4.Items.Add("Rekayasa Perangkat Lunak");
            comboBox4.Items.Add("Akuntasi");
            comboBox4.Items.Add("Pemasaran");
            comboBox4.Items.Add("Administrasi Perkantoran");
            comboBox4.Items.Add("Fisika");
            comboBox4.Items.Add("Kimia");
            comboBox4.Items.Add("Biologi");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView8.CurrentCell.RowIndex;
            idterpilih = dataGridView8.Rows[row].Cells[0].Value.ToString();
            bunifuMaterialTextbox1.Text = dataGridView8.Rows[row].Cells[1].Value.ToString();
            textBox2.Text = dataGridView8.Rows[row].Cells[2].Value.ToString();
            comboBox10.Text = dataGridView8.Rows[row].Cells[3].Value.ToString();
            comboBox8.Text = dataGridView8.Rows[row].Cells[4].Value.ToString();
            textBox16.Text = dataGridView8.Rows[row].Cells[5].Value.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextbox1.Text == "" || textBox2.Text == "" || comboBox8.Text == "" || comboBox10.Text == "" || textBox16.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT into nilai_siswa(`nama_siswa`, `kode_ajar`, `pelajaran`, `nis_siswa`, `nilai`) VALUES ('" + bunifuMaterialTextbox1.Text + "','" + textBox2.Text + "', '" + comboBox10.Text + "','" + comboBox8.Text + "', '" + textBox16.Text + "')", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil tambah data nilai ujian siswa Anda", "Informasi");
                    nilai();
                    bunifuMaterialTextbox1.Text = "";
                    textBox2.Text = "";
                    comboBox10.Text = "";
                    comboBox8.Text = "";
                    textBox16.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextbox1.Text == "" || textBox2.Text == "" || comboBox8.Text == "" || comboBox10.Text == "" || textBox16.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `nilai_siswa` where `id`='" + idterpilih + "'", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil menghapus data pelajaran", "Informasi");
                    nilai();
                    bunifuMaterialTextbox1.Text = "";
                    textBox2.Text = "";
                    comboBox10.Text = "";
                    comboBox8.Text = "";
                    textBox16.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextbox1.Text == "" || textBox2.Text == "" || comboBox8.Text == "" || comboBox10.Text == "" || textBox16.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `nilai_siswa` set `nama_siswa`='" + bunifuMaterialTextbox1.Text + "', `kode_ajar`='" + textBox2.Text + "', `pelajaran`='" + comboBox10.Text + "', `nis_siswa`='" + comboBox8.Text + "', `nilai`='" + textBox16.Text + "' where `id`='" + idterpilih + "'", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil mengubah data nilai ujian siswa Anda", "Informasi");
                    nilai();
                    bunifuMaterialTextbox1.Text = "";
                    textBox2.Text = "";
                    comboBox10.Text = "";
                    comboBox8.Text = "";
                    textBox16.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void comboBox8_DropDown(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlDataReader dr = null;
            MySqlCommand cmd = new MySqlCommand("Select * from `akun_siswa`", koneksi);
            dr = cmd.ExecuteReader();
            comboBox8.Items.Clear();
            while (dr.Read())
            {
                comboBox8.Items.Add(dr["nis_siswa"].ToString());

            }
            koneksi.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int row = dataGridView3.CurrentCell.RowIndex;
            bunifuMaterialTextbox2.Text = dataGridView3.Rows[row].Cells[0].Value.ToString();
            comboBox2.Text = dataGridView3.Rows[row].Cells[1].Value.ToString();
            comboBox3.Text = dataGridView3.Rows[row].Cells[2].Value.ToString();
            comboBox5.Text = dataGridView3.Rows[row].Cells[3].Value.ToString();
            comboBox9.Text = dataGridView3.Rows[row].Cells[4].Value.ToString();
            textBox1.Text = dataGridView3.Rows[row].Cells[5].Value.ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextbox2.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox5.Text == "" || comboBox9.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT into kelas_ajar(`kode_ajar`, `kelas`, `pelajaran`, `nip_guru`, `hari`, `jam_pelajaran`) VALUES ('" + bunifuMaterialTextbox2.Text + "','" + comboBox2.Text + "', '" + comboBox3.Text + "', '" + comboBox5.Text + "', '" + comboBox9.Text + "','" + textBox1.Text + "')", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil tambah data kelas ajar", "Informasi");
                    tada();
                    bunifuMaterialTextbox2.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    comboBox5.Text = "";
                    comboBox9.Text = "";
                    textBox1.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextbox2.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox5.Text == "" || comboBox9.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `kelas_ajar` set `kode_ajar`='" + bunifuMaterialTextbox2.Text + "', `kelas`='" + comboBox2.Text + "', `pelajaran`='" + comboBox3.Text + "', `nip_guru`='" + comboBox5.Text + "', `hari`='" + comboBox9.Text + "', `jam_pelajaran`='" + textBox1.Text + "' where `kode_ajar`='" + bunifuMaterialTextbox2.Text + "'", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil mengubah data kelas ajar", "Informasi");
                    tada();
                    bunifuMaterialTextbox2.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    comboBox5.Text = "";
                    comboBox9.Text = "";
                    textBox1.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }
        private void button34_Click(object sender, EventArgs e)
        {
            panel13.Height = 0;
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            tada();
        }
        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            tada2();
        }
        private void tada2()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X RPL%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void button35_Click(object sender, EventArgs e)
        {
            panel14.Width = 0;
            tada2();
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            panel14.Width = 680;
            tada2();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            panel15.Width = 0;
            tada3();
        }
        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            tada3();
        }

        private void tada3()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X AKL 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView9.DataSource = DS.Tables[0];
        }
        private void button12_Click_1(object sender, EventArgs e)
        {
            panel15.Width = 680;
            tada3();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            panel16.Width = 0;
            tada4();
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            tada4();
        }
        private void tada4()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X AKL 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView10.DataSource = DS.Tables[0];
        }
        private void button24_Click_1(object sender, EventArgs e)
        {
            panel16.Width = 680;
            tada4();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel17.Width = 680;
            tada5();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            panel17.Width = 0;
            tada5();
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            tada5();
        }
        private void tada5()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X BDP 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView11.DataSource = DS.Tables[0];
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel18.Width = 680;
            tada6();
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            tada6();
        }
        private void tada6()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X BDP 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView12.DataSource = DS.Tables[0];
        }

        private void button39_Click(object sender, EventArgs e)
        {
            panel18.Width = 0;
            tada6();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel8.Width = 680;
            tada7();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            panel13.Height = 489;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextbox2.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox5.Text == "" || comboBox9.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `kelas_ajar` WHERE `kode_ajar`='" + bunifuMaterialTextbox2.Text + "'", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil menghapus data jadwal pelajaran siswa Anda", "Informasi");
                    tada();
                    bunifuMaterialTextbox2.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    comboBox5.Text = "";
                    comboBox9.Text = "";
                    textBox1.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            tada7();
        }
        private void tada7()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X AP 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView13.DataSource = DS.Tables[0];
        }

        private void button43_Click(object sender, EventArgs e)
        {
            panel8.Width = 0;
            tada7();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            panel11.Width = 680;
            tada8();
        }
        private void tada8()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%X AP 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView14.DataSource = DS.Tables[0];
        }

        private void button44_Click(object sender, EventArgs e)
        {
            panel11.Width = 0;
            tada8();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            tada8();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void comboBox5_DropDown(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlDataReader dr = null;
            MySqlCommand cmd = new MySqlCommand("Select * from `akun_guru`", koneksi);
            dr = cmd.ExecuteReader();
            comboBox5.Items.Clear();
            while (dr.Read())
            {
                comboBox5.Items.Add(dr["nip_guru"].ToString());

            }
            koneksi.Close();
        }

        private void comboBox3_DropDown_1(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlDataReader dr = null;
            MySqlCommand cmd = new MySqlCommand("Select * from `pelajaran`", koneksi);
            dr = cmd.ExecuteReader();
            comboBox3.Items.Clear();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["pelajaran"].ToString());

            }
            koneksi.Close();
        }
        private void button41_Click(object sender, EventArgs e)
        {
            panel19.Height = 490;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            panel19.Height = 0;
        }
        private void button56_Click(object sender, EventArgs e)
        {
            panel22.Width = 0;
            tada9();
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

        private void button57_Click(object sender, EventArgs e)
        {
            panel23.Width = 0;
            tada10();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            panel22.Width = 680;
            tada9();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            panel23.Width = 680;
            tada10();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            panel24.Width = 0;
            tada11();
        }
        private void tada11()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XI AKL 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView17.DataSource = DS.Tables[0];
        }

        private void button50_Click(object sender, EventArgs e)
        {
            panel24.Width = 680;
            tada11();
        }
        private void tada12()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XI BDP 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView18.DataSource = DS.Tables[0];
        }

        private void button59_Click(object sender, EventArgs e)
        {
            panel25.Width = 0;
            tada12();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            panel25.Width = 680;
            tada12();
        }
        private void tada13()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XI BDP 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView19.DataSource = DS.Tables[0];
        }

        private void button60_Click(object sender, EventArgs e)
        {
            panel26.Width = 0;
            tada13();
        }
        private void tada14()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XI AP 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView20.DataSource = DS.Tables[0];
        }

        private void button61_Click(object sender, EventArgs e)
        {
            panel27.Width = 0;
            tada14();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            panel26.Width = 680;
            tada13();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            panel27.Width = 680;
            tada14();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            panel28.Width = 0;
            tada15();
        }
        private void tada15()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XI AP 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView21.DataSource = DS.Tables[0];
        }

        private void button70_Click(object sender, EventArgs e)
        {
            panel29.Height = 0;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            panel29.Height = 489;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            panel36.Width = 680;
            tada22();
        }

        private void button78_Click(object sender, EventArgs e)
        {
            panel37.Width = 0;
            tada17();
        }
        private void tada16()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII AP 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView30.DataSource = DS.Tables[0];
        }

        private void button71_Click(object sender, EventArgs e)
        {
            panel37.Width = 680;
            tada17();
        }

        private void button79_Click(object sender, EventArgs e)
        {
            panel38.Width = 0;
            tada16();
        }
        private void tada17()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII AP 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView29.DataSource = DS.Tables[0];
        }

        private void button72_Click(object sender, EventArgs e)
        {
            panel38.Width = 680;
            tada16();
        }
        private void button66_Click(object sender, EventArgs e)
        {
            panel33.Width = 0;
            tada18();
        }
        private void tada18()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII BDP 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView25.DataSource = DS.Tables[0];
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
        private void button67_Click(object sender, EventArgs e)
        {
            panel34.Width = 0;
            tada19();
        }
        private void tada19()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII AKL 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView26.DataSource = DS.Tables[0];
        }

        private void button76_Click(object sender, EventArgs e)
        {
            panel35.Width = 680;
            tada20();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            panel35.Width = 0;
            tada20();
        }
        private void tada20()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII AKL 1%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView27.DataSource = DS.Tables[0];
        }

        private void button69_Click(object sender, EventArgs e)
        {
            panel36.Width = 0;
            tada22();
        }
        private void button73_Click(object sender, EventArgs e)
        {
            panel30.Width = 680;
            tada21();
        }
        private void button63_Click(object sender, EventArgs e)
        {
            panel30.Width = 0;
            tada21();
        }
        private void tada21()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII BDP 2%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView22.DataSource = DS.Tables[0];
        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {
            tada11();
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {
            tada9();
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {
            tada10();
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {
            tada12();
        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {
            tada13();
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {
            tada14();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            tada15();
            panel28.Width = 680;
        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {
            tada15();
        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {
            tada22();
        }
        private void tada22()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("Select * from `kelas_ajar` where `kelas` LIKE '%XII RPL%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView28.DataSource = DS.Tables[0];
        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {
            tada20();
        }

        private void panel34_Paint(object sender, PaintEventArgs e)
        {
            tada19();
        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {
            tada18();
        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {
            tada21();
        }

        private void panel38_Paint(object sender, PaintEventArgs e)
        {
            tada16();
        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {
            tada17();
        }
        private void button18_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox6.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT into data_guru(`nip_guru`, `nama_guru`, `tempat_lahir`, `tanggal_lahir`, `alamat`) VALUES ('" + comboBox6.Text + "','" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "')", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil tambah data pengajar", "Informasi");
                    dataGURU();
                    comboBox6.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            dataGURU();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox6.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `data_guru` set `nip_guru`='" + comboBox6.Text + "', `nama_guru`='" + textBox6.Text + "', `tempat_lahir`='" + textBox7.Text + "', `tanggal_lahir`='" + textBox8.Text + "', `alamat`='" + textBox9.Text + "' where `nama_guru`='" + textBox6.Text + "'", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil mengubah data guru", "Informasi");
                    dataGURU();
                    comboBox6.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox6.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `data_guru` where `nama_guru`='" + textBox6.Text + "'", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil menghapus menghapus data guru", "Informasi");
                    dataGURU();
                    comboBox6.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void dataGridView5_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView5.CurrentCell.RowIndex;
            comboBox6.Text = dataGridView5.Rows[row].Cells[0].Value.ToString();
            textBox6.Text = dataGridView5.Rows[row].Cells[1].Value.ToString();
            textBox7.Text = dataGridView5.Rows[row].Cells[2].Value.ToString();
            textBox8.Text = dataGridView5.Rows[row].Cells[3].Value.ToString();
            textBox9.Text = dataGridView5.Rows[row].Cells[4].Value.ToString();
        }

        private void comboBox6_DropDown_1(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlDataReader dr = null;
            MySqlCommand cmd = new MySqlCommand("Select * from `akun_guru`", koneksi);
            dr = cmd.ExecuteReader();
            comboBox6.Items.Clear();
            while (dr.Read())
            {
                comboBox6.Items.Add(dr["nip_guru"].ToString());

            }
            koneksi.Close();
        }

        private void dataGridView7_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView7.CurrentCell.RowIndex;
            comboBox7.Text = dataGridView7.Rows[row].Cells[0].Value.ToString();
            textBox11.Text = dataGridView7.Rows[row].Cells[1].Value.ToString();
            textBox12.Text = dataGridView7.Rows[row].Cells[2].Value.ToString();
            textBox13.Text = dataGridView7.Rows[row].Cells[3].Value.ToString();
            textBox14.Text = dataGridView7.Rows[row].Cells[4].Value.ToString();
            textBox15.Text = dataGridView7.Rows[row].Cells[5].Value.ToString();
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox7.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT into data_siswa(`nis_siswa`, `nama_siswa`, `tempat_lahir`, `tanggal_lahir`, `kelas_siswa`, `alamat_siswa`) VALUES ('" + comboBox7.Text + "', '" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "')", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil tambah data siswa", "Informasi");
                    ke2();
                    comboBox7.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                    textBox12.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox7.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `data_siswa` set `nis_siswa`='" + comboBox7.Text + "', `nama_siswa`='" + textBox11.Text + "', `tempat_lahir`='" + textBox12.Text + "', `tanggal_lahir`='" + textBox13.Text + "', `kelas_siswa`='" + textBox14.Text + "', `alamat_siswa`='" + textBox15.Text + "' where `nama_siswa`='" + textBox11.Text + "'", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil mengubah data siswa", "Informasi");
                    ke2();
                    comboBox7.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                    textBox12.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox7.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox12.Text == "" || textBox14.Text == "" || textBox15.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `data_siswa` WHERE `nama_siswa`='" + textBox11.Text + "'", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil menghapus data siswa", "Informasi");
                    ke2();
                    comboBox7.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                    textBox12.Text = "";
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void comboBox7_DropDown_1(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlDataReader dr = null;
            MySqlCommand cmd = new MySqlCommand("Select * from `akun_siswa`", koneksi);
            dr = cmd.ExecuteReader();
            comboBox7.Items.Clear();
            while (dr.Read())
            {
                comboBox7.Items.Add(dr["nis_siswa"].ToString());

            }
            koneksi.Close();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            nilai();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            ke2();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void JamDigital_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
        private void c28()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `data_guru` WHERE `nama_guru` like'%" + textBox5.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            koneksi.Close();
        }
        private void textBox5_OnValueChanged(object sender, EventArgs e)
        {
            c28();
        }
        private void c30()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `data_siswa` WHERE `kelas_siswa` like'%" + comboBox1.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView24.DataSource = dt;
            koneksi.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c30();
        }

        private void Arah_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            c8();
        }
        private void c8()
        {
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandText = "SELECT*FROM `nilai_siswa` WHERE `nama_siswa` like'%" + bunifuMaterialTextbox3.Text + "%'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView8.DataSource = dt;
            koneksi.Close();
        }

        private void textBox2_DropDown(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlDataReader dr = null;
            MySqlCommand cmd = new MySqlCommand("Select * from `kelas_ajar`", koneksi);
            dr = cmd.ExecuteReader();
            textBox2.Items.Clear();
            while (dr.Read())
            {
                textBox2.Items.Add(dr["kode_ajar"].ToString());

            }
            koneksi.Close();
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {
            c1();
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            c2();
        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {
            c3();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox8.Text = "";
        }

        private void bunifuMaterialTextbox8_OnValueChanged(object sender, EventArgs e)
        {
            c4();
        }

        private void bunifuMaterialTextbox9_OnValueChanged(object sender, EventArgs e)
        {
            c5();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox9.Text = "";
        }

        private void bunifuMaterialTextbox10_OnValueChanged(object sender, EventArgs e)
        {
            c6();
        }

        private void label36_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox10.Text = "";
        }
        private void c1()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `data_guru` WHERE `nama_guru` like'%" + bunifuMaterialTextbox6.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView5.DataSource = DS.Tables[0];
        }
        private void c2()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `nilai_siswa` WHERE `nis_siswa` like'%" + bunifuMaterialTextbox5.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView8.DataSource = DS.Tables[0];
        }
        private void c3()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `data_siswa` WHERE `nama_siswa` like'%" + bunifuMaterialTextbox7.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView7.DataSource = DS.Tables[0];
        }
        private void c4()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `kelas` like'%" + bunifuMaterialTextbox8.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView3.DataSource = DS.Tables[0];
        }
        private void c5()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox9.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
        private void c6()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox10.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView9.DataSource = DS.Tables[0];
        }
        private void c7()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox11.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView10.DataSource = DS.Tables[0];
        }
        private void c9()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox12.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView11.DataSource = DS.Tables[0];
        }
        private void c10()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox13.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView12.DataSource = DS.Tables[0];
        }

        private void label37_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox11.Text = "";
        }

        private void bunifuMaterialTextbox11_OnValueChanged(object sender, EventArgs e)
        {
            c7();
        }

        private void bunifuMaterialTextbox12_OnValueChanged(object sender, EventArgs e)
        {
            c9();
        }

        private void label41_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox12.Text = "";
        }

        private void bunifuMaterialTextbox13_OnValueChanged(object sender, EventArgs e)
        {
            c10();
        }

        private void label42_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox13.Text = "";
        }
        private void c11()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox14.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView13.DataSource = DS.Tables[0];
        }

        private void bunifuMaterialTextbox14_OnValueChanged(object sender, EventArgs e)
        {
            c11();
        }

        private void label43_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox14.Text = "";
        }
        private void c12()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox15.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView14.DataSource = DS.Tables[0];
        }

        private void bunifuMaterialTextbox15_OnValueChanged(object sender, EventArgs e)
        {
            c12();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox15.Text = "";
        }
        private void c13()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox16.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView15.DataSource = DS.Tables[0];
        }

        private void bunifuMaterialTextbox16_OnValueChanged(object sender, EventArgs e)
        {
            c13();
        }

        private void label45_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox16.Text = "";
        }
        private void c14()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox17.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView16.DataSource = DS.Tables[0];
        }

        private void bunifuMaterialTextbox17_OnValueChanged(object sender, EventArgs e)
        {
            c14();
        }

        private void label46_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox17.Text = "";
        }
        private void c15()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox18.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView17.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox18_OnValueChanged(object sender, EventArgs e)
        {
            c15();
        }

        private void label48_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox18.Text = "";
        }
        private void c16()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox19.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView18.DataSource = DS.Tables[0];
        }

        private void bunifuMaterialTextbox19_OnValueChanged(object sender, EventArgs e)
        {
            c16();
        }

        private void label49_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox19.Text = "";
        }
        private void c17()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox20.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView19.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox20_OnValueChanged(object sender, EventArgs e)
        {
            c17();
        }

        private void label50_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox20.Text = "";
        }
        private void c18()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox21.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView20.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox21_OnValueChanged(object sender, EventArgs e)
        {
            c18();
        }

        private void label51_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox21.Text = "";
        }
        private void c19()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox22.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView21.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox22_OnValueChanged(object sender, EventArgs e)
        {
            c19();
        }

        private void label53_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox22.Text = "";
        }
        private void c20()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox23.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView28.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox23_OnValueChanged(object sender, EventArgs e)
        {
            c20();
        }

        private void label54_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox23.Text = "";
        }
        private void c21()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox24.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView27.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox24_OnValueChanged(object sender, EventArgs e)
        {
            c21();
        }

        private void label55_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox23.Text = "";
        }
        private void c22()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox25.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView26.DataSource = DS.Tables[0];
        }

        private void bunifuMaterialTextbox25_OnValueChanged(object sender, EventArgs e)
        {
            c22();
        }

        private void label56_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox25.Text = "";
        }
        private void c23()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox26.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView25.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox26_OnValueChanged(object sender, EventArgs e)
        {
            c23();
        }

        private void label57_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox26.Text = "";
        }
        private void c24()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox27.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView22.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox27_OnValueChanged(object sender, EventArgs e)
        {
            c24();
        }

        private void label59_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox27.Text = "";
        }
        private void c25()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox28.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView30.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox28_OnValueChanged(object sender, EventArgs e)
        {
            c25();
        }

        private void label60_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox28.Text = "";
        }
        private void c26()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + bunifuMaterialTextbox29.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView29.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox29_OnValueChanged(object sender, EventArgs e)
        {
            c26();
        }

        private void label61_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox29.Text = "";
        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string fileName;
            Spire.DataExport.XLS.CellExport cellExport = new Spire.DataExport.XLS.CellExport();
            Spire.DataExport.XLS.WorkSheet worksheet1 = new Spire.DataExport.XLS.WorkSheet();
            worksheet1.DataSource = Spire.DataExport.Common.ExportSource.DataTable;
            worksheet1.DataTable = this.dataGridView23.DataSource as DataTable;
            worksheet1.StartDataCol = ((System.Byte)(0));
            cellExport.Sheets.Add(worksheet1);
            cellExport.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
            fileName = textFileName.Text.ToString() + ".xls";
            cellExport.SaveToFile(fileName);
            textFileName.Text = "";
        }
        private void c27()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `kelas_ajar` WHERE `hari` like'%" + textFileName.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView23.DataSource = DS.Tables[0];
        }
        private void bunifuMaterialTextbox30_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label68_Click(object sender, EventArgs e)
        {
            textFileName.Text = "";
        }

        private void label71_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox3.Text = "";
        }

        private void label74_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox5.Text = "";
        }

        private void label77_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
        }

        private void label80_Click(object sender, EventArgs e)
        {
            textBox16.Text = "";
        }

        private void label83_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox6.Text = "";
        }

        private void label95_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
        }

        private void label92_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }

        private void label86_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }

        private void label89_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            comboBox6.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
            textBox2.Text = "";
            comboBox10.Text = "";
            comboBox8.Text = "";
            textBox16.Text = "";
        }

        private void label98_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox7.Text = "";
        }

        private void label101_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
        }

        private void label104_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
        }

        private void label105_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
        }

        private void label106_Click(object sender, EventArgs e)
        {
            textBox15.Text = "";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox15.Text = "";
            comboBox7.Text = "";
            textBox14.Text = "";
        }

        private void label107_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void label108_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.Text = "";
        }

        private void label110_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void label113_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox4.Text = "";
        }

        private void label116_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }
        private void c29()
        {
            MySqlDataAdapter DA = new MySqlDataAdapter("SELECT*FROM `data_siswa` WHERE `nama_siswa` like'%" + bunifuMaterialTextbox4.Text + "%'", koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView24.DataSource = DS.Tables[0];
        }
        private void label119_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox4.Text = "";
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {
            c29();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox4.Text = "";
            comboBox1.Text = "";
        }

        private void textBox16_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox17_Enter(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox5.Text = "";
            comboBox9.Text = "";
            textBox1.Text = "";
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Akan Keluar Dari Aplikasi Ini ?", "Informasi My Applikasi", MessageBoxButtons.YesNo) == DialogResult.No) ;
            else
            {
                Application.Exit();
            }
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {
            dataGURU();
        }

        private void groupBox8_Enter_1(object sender, EventArgs e)
        {

        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            ke2();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void label129_Click(object sender, EventArgs e)
        {
            textBox_path.Text = "";
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XLS files (*.xls, *.xlt)|*.xls;*.xlt";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox_path.Text = openFileDialog1.FileName;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string fileName;
            fileName = textBox_path.Text.ToString();
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(fileName);
            Worksheet sheet = workbook.Worksheets[0];
            this.dataGridView6.DataSource = sheet.ExportDataTable();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            string str;
            koneksi.Open();
            for (int index = 0; index < dataGridView6.Rows.Count - 1; index++)
            {
                str = ("INSERT into nilai_siswa(`id`, `nama_siswa`, `kode_ajar`, `pelajaran`, `nis_siswa`, `nilai`) values('" + dataGridView6.Rows[index].Cells[0].Value.ToString() + "','"+ dataGridView6.Rows[index].Cells[1].Value.ToString() + "','" 
                    + dataGridView6.Rows[index].Cells[2].Value.ToString() + "','"+ dataGridView6.Rows[index].Cells[3].Value.ToString() + "','"+ dataGridView6.Rows[index].Cells[4].Value.ToString() + "','"+ dataGridView6.Rows[index].Cells[5].Value.ToString() + "')");
                cmd = new MySqlCommand(str, koneksi);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Anda berhasil menambahkan data dari Excel ke Database", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_path.Text = "";
        }
    }
}
