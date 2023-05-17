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
    public partial class Adauga : Form
    {
        private Main _main;
        public Adauga()
        {
            InitializeComponent();
        }

        public Adauga(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        private void Adauga_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            _main.Show();
            this.Hide();
        }
    }
}
