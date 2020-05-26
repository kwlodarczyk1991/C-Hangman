using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman1
{
    public class SecretPassword
    {
        public static void Main(String[] args)
        {
            List<string> capitol = new List<string>();

            capitol.Add("Prague");
            capitol.Add("Rome");
            capitol.Add("Paris");
            capitol.Add("Berlin");
            capitol.Add("Warsaw");
            capitol.Add("Moscow");
            capitol.Add("Madrid");
            capitol.Add("Lisbon");
            capitol.Add("Vienna");
            capitol.Add("Zagreb");

            Random randcap = new Random();
            int index = randcap.Next(capitol.Count);
            string randomString = capitol[index];
        }
         

        
      
    }
}
