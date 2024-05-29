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
    public partial class TratareForm : Form
    {
        public TratareForm()
        {
            InitializeComponent();
        }

        private void amenintari_bunuriBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void amenintari_amenintariBtn_Click(object sender, EventArgs e)
        {
            AmenintariForm amenForm = new AmenintariForm();
            amenForm.Show();
            this.Hide();
        }

        private void amenintari_vulnerabilitatiBtn_Click(object sender, EventArgs e)
        {
            VulnerabilitatiForm vulnForm = new VulnerabilitatiForm();
            vulnForm.Show();
            this.Hide();
        }

        private void amenintari_riscuriBtn_Click(object sender, EventArgs e)
        {
            RiscuriForm riscForm = new RiscuriForm();
            riscForm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
