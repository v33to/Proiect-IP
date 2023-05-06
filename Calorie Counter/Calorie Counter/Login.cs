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
    public partial class Login : Form
    {
        private Meniu _meniu;
        public Login()
        {
            InitializeComponent();
        }

        public Login(Meniu meniu)
        {
            InitializeComponent();
            _meniu = meniu;
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void btIntoarcere_Click(object sender, EventArgs e)
        {
            _meniu.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
