using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Counter
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSetari_Click(object sender, EventArgs e)
        {
            Setari setari = new Setari(this);
            setari.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.Show();
            this.Hide();
        }

        private void Meniu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
