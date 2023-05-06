using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calorie_Counter
{
    public partial class Register : Form
    {
        private Login _login;
        public Register()
        {
            InitializeComponent();
        }

        public Register(Login login)
        {
            InitializeComponent();
            _login = login;
        }

        private void btnIntoarcere_Click(object sender, EventArgs e)
        {
            _login.Show();
            this.Hide();
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            Scop scop = new Scop(this);
            scop.Show();
            this.Hide();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
