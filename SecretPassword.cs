using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman1
{
    public class SecretPassword
    {
        
        private char[]hashedstring;

        public SecretPassword(string hashedstring)
        {
            this.hashedstring = hashedstring.ToCharArray(); 

        }

        internal void Showchar(char keyname, List<int> indexy)
        {
            indexy.ForEach(index => hashedstring[index] = keyname);
        }

        internal void Showcurrentpasswordstate()
        {
            Console.WriteLine(new String(hashedstring));
        }

        internal bool unhushall()
        {
            if (hashedstring.Contains('*')) 
            {
                return false;
            }
            return true;
        }
    }
}
