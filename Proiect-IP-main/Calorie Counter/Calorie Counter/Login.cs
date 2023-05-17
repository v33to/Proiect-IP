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
        private Facade_DLL.Facade_DLL DB = new Facade_DLL.Facade_DLL();

        public Login()
        {
            InitializeComponent();
        }

        public Login(Meniu meniu)
        {
            InitializeComponent();
            _meniu = meniu;
            tbParola.UseSystemPasswordChar = true;
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            this.Hide();
        }
        //Butonul "Trimite " de pe interfata 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            
            //Username luat de pe interfata
            string User = tbUtilizator.Text;
        
            
            //Parola luata de pe interfata
            string Pass = tbParola.Text;
            
            //Verificam daca s-au introdus Date in campurile Username si Parola
            if (tbUtilizator.Text == "" && tbParola.Text == "")
            {
                MessageBox.Show("Trebuie sa introduci parola si Usernamul pentru a te loga");
            }
            else 
            {
                //Se verifica da exista contul in baza de date 
                if (DB.check(User, Pass) == 1)
                {
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Imi pare rau dar Numele de Utilizator nu exista sau Parola este gresita !!!!");
                }
            }
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
