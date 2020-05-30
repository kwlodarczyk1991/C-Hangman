using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hangman1
{
    class Prevuserattempt
    {
        private List<Char> prevuserattempt; 
        internal Prevuserattempt()
        {
            this.prevuserattempt = new List<Char>();
        }
         
         internal bool isused(Char keyname)
        {
            if (prevuserattempt.Contains(keyname)) 
            { 
                return true;
            }

            prevuserattempt.Add(keyname);
           
            return false;
        }
    }
}
