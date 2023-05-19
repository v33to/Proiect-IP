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
        public static Scop instance;
        private Facade_DLL.Facade_DLL DB = new Facade_DLL.Facade_DLL();


        public Scop()
        {
            InitializeComponent();
            
        }

        public Scop(Register register)
        {
            InitializeComponent();
            _register = register;
            instance = this;
        
        }

      /*  private void btIntoarcere_Click(object sender, EventArgs e)
        {
            

            _register.Show();
            this.Hide();
        }*/

        private void Scop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            int raspuns=0;
            
            if (rbSlabire.Checked)
            {
                raspuns = 1;
                rbMentinere.Enabled = false;
                rbMasa.Enabled = false;
            }
            if (rbMentinere.Checked)
            {
                raspuns = 2;
                rbSlabire.Enabled= false;
                rbMasa.Enabled= false;
            }
            if (rbMasa.Checked)
            {
                raspuns = 3;
                rbSlabire.Enabled = false;
                rbMentinere.Enabled= false;
            }
            Main main = new Main();
            main.Show();
            this.Hide();
            try
            {
                string user = Register.instance.tb1.Text;
                string pass  = Register.instance.tb2.Text;
                DB.ADD_SCOP(user, pass, raspuns);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Aroare in ADD_Scope  Interfata Scop",ex.Message);
            }

        }
    }
}
