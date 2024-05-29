using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_RISK
{
    public partial class AmenintariForm : Form
    {
        // Stringul de conexiune la baza de date (modifică-l conform necesităților tale)
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrei\Documents\tabele.mdf;Integrated Security=True;Connect Timeout=30";

        public AmenintariForm()
        {
            InitializeComponent();

            LoadBunuriData();
        }

        private void AmenintariForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoadBunuriData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Deschide conexiunea
                    conn.Open();

                    // Creează un SqlDataAdapter pentru a executa interogarea
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Amenintare, Nivel_minim, Nivel_maxim FROM AMENINTARI", conn);

                    // Creează un DataTable pentru a stoca rezultatele
                    DataTable dataTable = new DataTable();

                    // Populează DataTable-ul cu datele din baza de date
                    dataAdapter.Fill(dataTable);

                    // Verifică dacă dataTable conține date
                    if (dataTable.Rows.Count > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Nu s-au găsit înregistrări în tabela BUNURI.");
                    }

                    // Maparea coloanelor din DataTable la coloanele din DataGridView
                    dataGridView1.Columns["Column1"].DataPropertyName = "Amenintare";
                    dataGridView1.Columns["Column3"].DataPropertyName = "Nivel_minim";
                    dataGridView1.Columns["Column4"].DataPropertyName = "Nivel_maxim";

                    // Setează DataSource-ul DataGridView-ului la DataTable
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
            }
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void main_salveaza_Click(object sender, EventArgs e)
        {

        }

        private void main_anuleaza_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void amenintari_bunuriBtn_Click_1(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void amenintari_vulnerabilitatiBtn_Click(object sender, EventArgs e)
        {
            VulnerabilitatiForm vulnForm = new VulnerabilitatiForm();
            vulnForm.Show();
            this.Hide();
        }

        private void amenintari_amenintariBtn_Click(object sender, EventArgs e)
        {

        }

        private void amenintari_riscuriBtn_Click(object sender, EventArgs e)
        {
            RiscuriForm riscForm = new RiscuriForm();
            riscForm.Show();
            this.Hide();
        }

        private void amenintari_tratareBtn_Click(object sender, EventArgs e)
        {
            TratareForm tratForm = new TratareForm();
            tratForm.Show();
            this.Hide();
        }
    }
}
