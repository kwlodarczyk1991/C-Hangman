using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hangman1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to Hangman");
            Console.WriteLine("Try to guess the password");
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
            string hashedstring = new string('*', randomString.Length);

            Console.WriteLine(hashedstring);

            //inicjuje obiekt klasy userpassword(SecretPassword) 

            SecretPassword secretpassword = new SecretPassword(hashedstring);

            int lifes = 3;

            Prevuserattempt prevuserattempt = new Prevuserattempt();
            while (lifes >= 0 && !secretpassword.unhushall())
            {
                Char keyname = Console.ReadKey().KeyChar;
                Console.WriteLine("You pressed {0}", keyname);
                var indexy = Chceckchar(randomString, keyname);

                secretpassword.Showchar(keyname, indexy);
                secretpassword.Showcurrentpasswordstate();
                
                if (indexy.Count == 0 || prevuserattempt.isused(keyname))
                {
                    lifes--;
                }
                


            }
            
            if (lifes < 0)
            {
                Console.WriteLine("You loose"); 

            } 
            else
            {
                Console.WriteLine("You Win");
            }
            Console.ReadLine();

        }

        private static List<int> Chceckchar(string randomString, char keyname)

        {
            
            return Enumerable.Range(0, randomString.Length).Where(i =>Char.ToLower(randomString[i]) ==Char.ToLower(keyname)).ToList();

        }


    }
}








//SecretPassword capitol = new SecretPassword();
//HashedPassword password = new HashedPassword();

//capitol.Addcapitol("Prague");
//capitol.Addcapitol("Rome");
//capitol.Addcapitol("Paris");
//capitol.Addcapitol("Berlin");
//capitol.Addcapitol("Warsaw");
//capitol.Addcapitol("Moscow");
//capitol.Addcapitol("Madrid");
//capitol.Addcapitol("Lisbon");
//capitol.Addcapitol("Vienna");
//capitol.Addcapitol("Zagreb");   
//Random randcap = new Random();
//int index = randcap.Next(capitols.Count);
//string randomString = capitols[index];
//string hashedstring = new string('*', randomString.Length);







//capitol.Add("Prague");
//capitol.Add("Rome");
//capitol.Add("Paris");
//capitol.Add("Berlin");
//capitol.Add("Warsaw");
//capitol.Add("Moscow");
//capitol.Add("Madrid");
//capitol.Add("Lisbon");
//capitol.Add("Vienna");
//capitol.Add("Zagreb");

//Random randcap = new Random();
//int index = randcap.Next(capitol.Count);
//string randomString = capitol[index];

//string hashedstring = new string('*', randomString.Length);
//Console.WriteLine(hashedstring);
//Console.ReadLine();