using System;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Security;



namespace DB_DLL
{
    public class DB_Class
    {
        private SqlConnection conex = new SqlConnection(@"Data Source=DESKTOP-SJBG723\SQLEXPRESS;Initial Catalog=Persoane_Db;Integrated Security=True");

        public void addData(string User, string parola, float greutate, float inaltime, int varsta, string sex, string Niv_Activ)
        {
            try
            {
                //Se face conexiunea la baza de date
                conex.Open();
                //Se intoduce datele utilizatorului in baza de Date
                SqlCommand comm = new SqlCommand("INSERT INTO [Register_Tabel] (Utilizator,Parola,Greutate,Inaltime,Varsta,Sex,Nivel_Activitate) values(@Utilizator,@Parola,@Greutate,@Inaltime,@Varsta,@Sex,@Nivel_Activitate)", conex);
                comm.Parameters.AddWithValue("@Utilizator", User);
                comm.Parameters.AddWithValue("@Parola", parola);
                comm.Parameters.AddWithValue("@Greutate", greutate);
                comm.Parameters.AddWithValue("@Inaltime", inaltime);
                comm.Parameters.AddWithValue("@Varsta", varsta);
                comm.Parameters.AddWithValue("@Sex", sex);
                comm.Parameters.AddWithValue("@Nivel_Activitate", Niv_Activ);
                var tmp = comm.ExecuteNonQuery();
                Console.WriteLine(tmp);
                Console.WriteLine("Merge inserare in baza de date");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la introducere date in BD: " + ex.Message);
            }
            finally
            {
                //Se inchide conexiunea
                conex.Close();
            }


        }

        //Verifica daca Username si parola 
        public int check(string User, string parola)
        {
            int verif = 1;
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la deschidere BD in functia check: " + ex.Message);

            }
            try
            {
                //Se incearca cautare in Baza de Date a User si parola
                SqlCommand comm = new SqlCommand($"select count(*) from [Register_Tabel] where [Utilizator]=@Utilizator AND [Parola]=@Parola", conex);
                comm.Parameters.AddWithValue("@Utilizator", User);
                comm.Parameters.AddWithValue("@Parola", parola);
                try
                {
                    verif = Convert.ToInt32(comm.ExecuteScalar());
                }
                catch
                {
                    verif = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautare BD in functia check: " + ex.Message);
            }
            finally
            {
                conex.Close();
            }

            return verif;
        }

        public int getAge(string User, string parola)
        {
            int Age = 0;
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la deschidere BD in functia getAge" + ex.Message);
            }

            try
            {
                SqlCommand comm = new SqlCommand("SELECT Varsta FROM [Register_Tabel] where [Utilizator]='" + User + "'" + "And [Parola]='" + parola + "'", conex);
                Age = (int)comm.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautare in baza de date in functia getAge" + ex.Message);
            }
            try
            {
                conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la inchiderea Bazei de date in functia getAge" + ex.Message);
            }
            return Age;
        }

        public float getGreutate(string User, string parola)
        {
            float Greut = 0;
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erare la deschidere BD in fct getGreut" + ex.Message);
            }
            try
            {
                SqlCommand conn = new SqlCommand("Select Greutate from [Register_Tabel] where [Utilizator]='" + User + "'" + "and [parola]='" + parola + "'", conex);
                Greut = (float)conn.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautarea in baza de date in fct getGreutate" + ex.Message);
            }
            try
            {
                conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la inchiderea bazei de date in fct getGreut" + ex.Message);
            }
            return Greut;

        }

        public float getInaltime(string User, string parola)
        {
            float height = 0;
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erare la deschidere BD in fct getInaltime" + ex.Message);
            }
            try
            {
                SqlCommand conn = new SqlCommand("Select Inaltime from [Register_Tabel] where [Utilizator]='" + User + "'" + "and [parola]='" + parola + "'", conex);
                height = (float)conn.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautarea in baza de date in fct getInaltime" + ex.Message);
            }
            try
            {
                conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la inchiderea bazei de date in fct getInaltime" + ex.Message);
            }
            return height;

        }

        public string getSex(string User, string parola)
        {
            string sex = "";
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erare la deschidere BD in fct getSex" + ex.Message);
            }
            try
            {
                SqlCommand conn = new SqlCommand("Select Sex from [Register_Tabel] where [Utilizator]='" + User + "'" + "and [parola]='" + parola + "'", conex);
                sex = (string)conn.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautarea in baza de date in fct getSex" + ex.Message);
            }
            try
            {
                conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la inchiderea bazei de date in fct getSex" + ex.Message);
            }
            return sex;

        }



        public string get_Activity_Level(string User, string parola)
        {
            string ACT_LVL = "";
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erare la deschidere BD in fct get_Activity_Level" + ex.Message);
            }
            try
            {
                SqlCommand conn = new SqlCommand("Select Sex from [Register_Tabel] where [Utilizator]='" + User + "'" + "and [parola]='" + parola + "'", conex);
                ACT_LVL = (string)conn.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautarea in baza de date in fct get_Activity_Level" + ex.Message);
            }
            try
            {
                conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la inchiderea bazei de date in fct get_Activity_Level" + ex.Message);
            }
            return ACT_LVL;

        }

        public int AlreadyExist(string user) {
            //Variabila cu ajutorul careia aflam daca Userul este deja in baza de date
            int verif = 0;
            try
            {
                //Se incearca conectarea la Baza de Date
                conex.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exceptie la deschiderea bazei de date in fct AlreadyExists");
            }
            try
            {
                //Se cauta in baza de date Userul
                SqlCommand comm = new SqlCommand("SELECT * from [Register_Tabel] where Username='" + user + "'",conex);
                verif = (int)comm.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautare in baza de date " + ex.Message);
            }
            try
            {
                //Se inchide coneziunea
                conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la inchiderea bazei de date in functia AlreadyExists" + ex.Message);
            }
            return verif;

        }

    }
}