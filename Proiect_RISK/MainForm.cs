using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_RISK
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
