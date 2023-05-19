using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_DLL;


namespace Facade_DLL
{
    public class Facade_DLL
    {
        private DB_Class Data_Base;

        public Facade_DLL()
        {

            Data_Base = new DB_Class();
        }

        public void addData(string User, string parola, float greutate, float inaltime, int varsta, string sex, string Niv_Activ)
        {
            Data_Base.addData(User, parola, greutate, inaltime, varsta, sex, Niv_Activ);
        }

        public int check(string User, string parola)
        {
            return Data_Base.check(User, parola);

        }
        
        public int AlreadyExist(string user)
        {
            return Data_Base.AlreadyExist(user);
        }

        public float getGreutate(string User, string parola)
        {
            return Data_Base.getGreutate(User,parola);
        }
        public int getAge(string User, string parola)
        {
            return Data_Base.getAge(User,parola);
        }
        public float getHeight(string User, string parola)
        {
            return Data_Base.getInaltime(User,parola);
        }
        public string getSex(string User,string parola)
        {
            return Data_Base.getSex(User,parola);
        }
        public void ADD_SCOP(string user, string pass, int scope)
        {
            Data_Base.ADD_SCOP(user,pass,scope);
        }




    }
}
