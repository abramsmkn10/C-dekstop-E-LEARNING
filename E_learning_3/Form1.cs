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
using System.Threading;

namespace E_learning_3
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = new MySqlConnection("Server=localhost;Port=3306;Database=elearning;Uid=root;Password=;SslMode=None;");
        int i;
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            Init_Data();
            Init_Data1();
        }
        public void StartForm()
        {
            Application.Run(new Splash_Screen());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Init_Data()
        {
            if(Properties.Settings.Default.nama == "yes")
            {
                if(Properties.Settings.Default.remme == "yes")
                {
                    bunifuMaterialTextbox8.Text = Properties.Settings.Default.nama;
                    Textbox7.Text = Properties.Settings.Default.kunci;
                    bunifuCheckbox5.Checked = true;
                }
                else
                {
                    bunifuMaterialTextbox8.Text = Properties.Settings.Default.nama;
                }
            }
        }
        private void save_data()
        {
            if(bunifuCheckbox5.Checked)
            {
                Properties.Settings.Default.nama = bunifuMaterialTextbox8.Text;
                Properties.Settings.Default.kunci = Textbox7.Text;
                Properties.Settings.Default.remme = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.nama = bunifuMaterialTextbox8.Text;
                Properties.Settings.Default.kunci = "";
                Properties.Settings.Default.remme = "yes";
                Properties.Settings.Default.Save();
            }
        }
        private void Init_Data1()
        {
            if (Properties.Settings.Default.nama == "yes")
            {
                if (Properties.Settings.Default.remme == "yes")
                {
                    Textbox1.Text = Properties.Settings.Default.nama;
                    Textbox2.Text = Properties.Settings.Default.kunci;
                    bunifuCheckbox6.Checked = true;
                }
                else
                {
                    Textbox1.Text = Properties.Settings.Default.nama;
                }
            }
        }
        private void save_data2()
        {
            if (bunifuCheckbox6.Checked)
            {
                Properties.Settings.Default.nama = Textbox1.Text;
                Properties.Settings.Default.kunci = Textbox2.Text;
                Properties.Settings.Default.remme = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.nama = Textbox1.Text;
                Properties.Settings.Default.kunci = "";
                Properties.Settings.Default.remme = "yes";
                Properties.Settings.Default.Save();
            }
        }
       
        
        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            panel4.Width = 600;
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            panel7.Width = 601;
        }
        
        private void label1_Click_1(object sender, EventArgs e)
        {
            panel10.Height = 531;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin keluar dari aplikasi ini ?", "Informasi My Applikasi", MessageBoxButtons.YesNo) == DialogResult.No) ;
            else
            {
                Application.Exit();
            }
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuCheckbox1_OnChange_1(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked)
            {
                Textbox2.isPassword = true;
            }
            else
            {
                Textbox2.isPassword = false;
            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            panel6.Width = 406;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Textbox1.Text == "")
                {
                    MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Textbox1.Focus();
                    return;
                }
                else if (Textbox2.Text == "")
                {
                    MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Textbox2.Focus();
                    return;
                }
                else
                {
                    i = 0;
                    koneksi.Open();
                    MySqlCommand cmd = koneksi.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from akun_siswa where username_siswa='" + Textbox1.Text + "'and password_siswa='" + Textbox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (i == 0)
                    {
                        MessageBox.Show("you have entered invalid username or password", "Error");
                        Textbox1.Text = "";
                        Textbox2.Text = "";
                    }
                    else
                    {
                        save_data2();
                        MessageBox.Show("Welcome Student SMKN 10 Jakarta", "Login");
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();
                        Textbox1.Text = "";
                        Textbox2.Text = "";
                    }
                    koneksi.Close();
                }
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }

        }

        private void bunifuCheckbox2_OnChange_1(object sender, EventArgs e)
        {
            if (bunifuCheckbox2.Checked)
            {
                Textbox4.isPassword = true;
            }
            else
            {
                Textbox4.isPassword = false;
            }
        }

        private void label15_Click_1(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
            Textbox4.Text = "";
            Textbox3.Text = "";
            bunifuMaterialTextbox2.Text = "";
            panel6.Width = 0;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextbox1.Text == "" || Textbox4.Text == "" || Textbox3.Text == "" || bunifuMaterialTextbox2.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into akun_siswa(`username_siswa`, `password_siswa`, `email`, `nis_siswa`) VALUES ('" + bunifuMaterialTextbox1.Text + "', '" + Textbox4.Text + "', '" + Textbox3.Text + "', '" + bunifuMaterialTextbox2.Text + "')", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil tambah data Anda");
                    bunifuMaterialTextbox1.Text = "";
                    Textbox3.Text = "";
                    Textbox4.Text = "";
                    bunifuMaterialTextbox2.Text = "";
                    panel6.Width = 0;
                }
                koneksi.Close();
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }

        }

        private void label27_Click_1(object sender, EventArgs e)
        {
            panel7.Width = 0;
            bunifuMaterialTextbox8.Text = "";
            Textbox7.Text = "";
        }

        private void label24_Click_1(object sender, EventArgs e)
        {
            panel8.Width = 407;
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextbox8.Text == "")
                {
                    MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bunifuMaterialTextbox8.Focus();
                    bunifuMaterialTextbox8.Text = "";
                    Textbox7.Text = "";
                    return;
                }
                if (Textbox7.Text == "")
                {
                    MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Textbox7.Focus();
                    bunifuMaterialTextbox8.Text = "";
                    Textbox7.Text = "";
                    return;
                }
                else
                {
                    i = 0;
                    koneksi.Open();
                    MySqlCommand cmd = koneksi.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from akun_guru where username_guru='" + bunifuMaterialTextbox8.Text + "'and password_guru='" + Textbox7.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (i == 0)
                    {
                        MessageBox.Show("you have entered invalid username or password", "Error");
                        bunifuMaterialTextbox8.Text = "";
                        Textbox7.Text = "";
                    }
                    else
                    {
                        save_data();
                        MessageBox.Show("Welcome Teacher SMKN 10 Jakarta", "Login");
                        Form4 f4 = new Form4();
                        f4.Show();
                        this.Hide();
                        bunifuMaterialTextbox8.Text = "";
                        Textbox7.Text = "";
                    }
                }
                koneksi.Close();
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void bunifuCheckbox3_OnChange_1(object sender, EventArgs e)
        {
            if (bunifuCheckbox3.Checked)
            {
                Textbox5.isPassword = true;
            }
            else
            {
                Textbox5.isPassword = false;
            }
        }

        private void label17_Click_1(object sender, EventArgs e)
        {
            bunifuMaterialTextbox6.Text = "";
            Textbox5.Text = "";
            bunifuMaterialTextbox5.Text = "";
            bunifuMaterialTextbox4.Text = "";
            panel8.Width = 0;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextbox6.Text == "" || Textbox5.Text == "" || bunifuMaterialTextbox5.Text == "" || bunifuMaterialTextbox4.Text == "")
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else
                {
                    koneksi.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into akun_guru(`username_guru`, `password_guru`, `email`, `nip_guru`) VALUES ('" + bunifuMaterialTextbox6.Text + "', '" + Textbox5.Text + "', '" + bunifuMaterialTextbox5.Text + "', '" + bunifuMaterialTextbox4.Text + "')", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil tambah data Anda", "Informasi");
                    bunifuMaterialTextbox6.Text = "";
                    Textbox5.Text = "";
                    bunifuMaterialTextbox5.Text = "";
                    bunifuMaterialTextbox4.Text = "";
                    panel8.Width = 0;
                }
                koneksi.Close();
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            panel10.Height = 0;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Textbox1.Text = "";
            Textbox2.Text = "";
            panel4.Width = 0;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox4.Checked)
            {
                Textbox7.isPassword = true;
            }
            else
            {
                Textbox7.isPassword = false;
            }
        }
        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if(imageNumber == 4)
            {
                imageNumber = 1;
            }
            hh.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
