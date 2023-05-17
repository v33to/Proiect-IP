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
    public partial class Scop : Form
    {
        private Register _register;
        public Scop()
        {
            InitializeComponent();
        }

        public Scop(Register register)
        {
            InitializeComponent();
            _register = register;
        }

        private void btIntoarcere_Click(object sender, EventArgs e)
        {
            _register.Show();
            this.Hide();
        }

        private void Scop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
