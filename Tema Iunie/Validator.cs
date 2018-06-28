using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Iunie
{
    class Validator
    {
        private string Trueusername = "Vlad";
        private string TruePassword = "Secret";
        private int contor = 0;

        public bool Valideaza(string username,string parola)
        {
            if(this.Trueusername == username && this.TruePassword==parola)
            {
                return true;
            }
            else
            {
                contor++;
                return false;
            }
        }

    }
}
