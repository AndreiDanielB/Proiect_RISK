using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proiect_RISK
{
    public partial class MainForm : Form
    {
        // Stringul de conexiune la baza de date (modifică-l conform necesităților tale)
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrei\Documents\tabele.mdf;Integrated Security=True;Connect Timeout=30";

        private Random random = new Random();
        public MainForm()
        {
            InitializeComponent();
            // Apelează metoda pentru a încărca datele din baza de date în DataGridView
            LoadBunuriData();
            // Apelează metoda pentru a încărca datele în combobox-uri
            LoadComboBoxData();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Deschide conexiunea
                    conn.Open();

                    // Creează comanda SQL pentru inserarea datelor
                    string insertQuery = "INSERT INTO BUNURI (Cod_Bun, Cod_proiect, Nume_Bun, Impact_minim, Impact_maxim, Domeniu_Categorie, Cost, Cost_de_reducere) " +
                                         "VALUES (@Cod_Bun, @Cod_proiect, @Nume_Bun, @Impact_minim, @Impact_maxim, @Domeniu_Categorie, @Cost, @Cost_de_reducere)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        // Generare valoare random pentru Cod_Bun și Cod_proiect
                        int codBun = random.Next(1000, 10000); // Generează un număr întreg între 1000 și 9999 pentru Cod_Bun
                        int codProiect = 1; // Setează valoarea "1" pentru Cod_proiect

                        cmd.Parameters.AddWithValue("@Cod_Bun", codBun);
                        cmd.Parameters.AddWithValue("@Cod_proiect", codProiect);

                        // Adaugă restul parametrilor
                        cmd.Parameters.AddWithValue("@Nume_Bun", main_nume.Text);
                        cmd.Parameters.AddWithValue("@Impact_minim", main_min.SelectedItem);
                        cmd.Parameters.AddWithValue("@Impact_maxim", main_max.SelectedItem);
                        cmd.Parameters.AddWithValue("@Domeniu_Categorie", main_domeniu.SelectedItem);
                        cmd.Parameters.AddWithValue("@Cost", main_cost.Text);
                        cmd.Parameters.AddWithValue("@Cost_de_reducere", main_reducere.Text);

                        // Execută comanda SQL
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("Eroare la salvarea datelor în baza de date.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void main_amenintari_Click(object sender, EventArgs e)
        {
            AmenintariForm amenForm = new AmenintariForm();
            amenForm.Show();
            this.Hide();
        }

        private void main_riscuri_Click(object sender, EventArgs e)
        {
            RiscuriForm riscForm = new RiscuriForm();
            riscForm.Show();
            this.Hide();
        }

        private void main_tratare_Click(object sender, EventArgs e)
        {
            TratareForm tratForm = new TratareForm();
            tratForm.Show();
            this.Hide();
        }

        private void main_vulnerabilitati_Click(object sender, EventArgs e)
        {
            VulnerabilitatiForm vulnForm = new VulnerabilitatiForm();
            vulnForm.Show();
            this.Hide();
        }

        private void main_bunuri_Click(object sender, EventArgs e)
        {
            // Apelează metoda pentru a încărca datele din baza de date în DataGridView
            LoadBunuriData();
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
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Nume_Bun, Impact_minim, Impact_maxim, Domeniu_Categorie, Cost, Cost_de_reducere FROM BUNURI", conn);

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
                    dataGridView1.Columns["Nume"].DataPropertyName = "Nume_Bun";
                    dataGridView1.Columns["Column1"].DataPropertyName = "Impact_minim";
                    dataGridView1.Columns["Column2"].DataPropertyName = "Impact_maxim";
                    dataGridView1.Columns["Column3"].DataPropertyName = "Domeniu_Categorie";
                    dataGridView1.Columns["Column4"].DataPropertyName = "Cost";
                    dataGridView1.Columns["Column5"].DataPropertyName = "Cost_de_reducere";

                    // Setează DataSource-ul DataGridView-ului la DataTable
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
            }
        }

        private void main_anuleazaBtn_Click(object sender, EventArgs e)
        {

        }

        private void LoadComboBoxData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Deschide conexiunea
                    conn.Open();

                    // Extrage valorile distincte pentru coloana 'Impact_minim'
                    SqlCommand cmdMin = new SqlCommand("SELECT DISTINCT Impact_minim FROM BUNURI", conn);
                    SqlDataReader readerMin = cmdMin.ExecuteReader();
                    while (readerMin.Read())
                    {
                        main_min.Items.Add(readerMin["Impact_minim"]);
                    }
                    readerMin.Close();

                    // Extrage valorile distincte pentru coloana 'Impact_maxim'
                    SqlCommand cmdMax = new SqlCommand("SELECT DISTINCT Impact_maxim FROM BUNURI", conn);
                    SqlDataReader readerMax = cmdMax.ExecuteReader();
                    while (readerMax.Read())
                    {
                        main_max.Items.Add(readerMax["Impact_maxim"]);
                    }
                    readerMax.Close();

                    // Extrage valorile distincte pentru coloana 'Domeniu_Categorie'
                    SqlCommand cmdDomeniu = new SqlCommand("SELECT DISTINCT Domeniu_Categorie FROM BUNURI", conn);
                    SqlDataReader readerDomeniu = cmdDomeniu.ExecuteReader();
                    while (readerDomeniu.Read())
                    {
                        main_domeniu.Items.Add(readerDomeniu["Domeniu_Categorie"]);
                    }
                    readerDomeniu.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
            }
        }
    }
}
