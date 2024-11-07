using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    internal class Menu
    {
        public Menu()
        {
            Console.Clear();
            Console.Write(@$"Choose an option: 

1. Encrypt
2. Decrypt
3. Decrypt encrypted
4. Exit

Input choice: ");
        }
    }
}
