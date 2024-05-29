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
    public partial class VulnerabilitatiForm : Form
    {
        public VulnerabilitatiForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vulnerabilitati_bunuriBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vulnerabilitati_amenintariBtn_Click(object sender, EventArgs e)
        {
            AmenintariForm amenForm = new AmenintariForm();
            amenForm.Show();
            this.Hide();
        }

        private void vulnerabilitati_vulnerabilitatiBtn_Click(object sender, EventArgs e)
        {

        }

        private void vulnerabilitati_riscuriBtn_Click(object sender, EventArgs e)
        {
            RiscuriForm riscForm = new RiscuriForm();
            riscForm.Show();
            this.Hide();
        }

        private void vulnerabilitati_tratareBtn_Click(object sender, EventArgs e)
        {
            TratareForm tratForm = new TratareForm();
            tratForm.Show();
            this.Hide();
        }
    }
}
