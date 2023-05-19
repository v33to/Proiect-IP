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
using Facade_DLL;
using TextBox = System.Windows.Forms.TextBox;

namespace Calorie_Counter
{
    public partial class Register : Form
    {
        private Login _login;
        private Facade_DLL.Facade_DLL DB = new Facade_DLL.Facade_DLL();
        public static Register instance;
        public TextBox tb1;
        public TextBox tb2;


        public Register()
        {
            InitializeComponent();

        }

        public Register(Login login)
        {
            InitializeComponent();
            _login = login;
            //butonul "pasul urmator" va fi desabled pana cand vom introudce toae datele si vom apasa pe butonul de inregistrare 
            //btnPas.Enabled = false;
            tbParola.UseSystemPasswordChar = true;
            instance= this;
            tb1 = tbUtilzator;
            tb2 = tbParola;
        }

        private void btnIntoarcere_Click(object sender, EventArgs e)
        {
            _login.Show();
            this.Hide();
        }

        private void btnPas_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Ai intrat in Fct Passss");
            //Se verifica daca campurile sunt completate pentru a adauga userul in baza de date
            if (tbUtilzator.Text != "" && tbParola.Text != "" && tbGreutate.Text != "" && tbInaltime.Text != "" && tbVarsta.Text != "" && cbSex.Text != "" && cbActivitate.Text != "")
            {
                //Se incarca in baza de date 
                DB.addData(tbUtilzator.Text, tbParola.Text, float.Parse(tbGreutate.Text), float.Parse(tbInaltime.Text), int.Parse(tbVarsta.Text), cbSex.Text, cbActivitate.Text);
                //Butonul "Pasil urmator " va fi Enabled
                btnPas.Enabled = true;
                
            }
            else
            {
                btnPas.Enabled = false;
                MessageBox.Show("Trebuie sa completezi toate camputile !!!");
            }

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
