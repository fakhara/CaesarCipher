using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public class Cipher
    {

        public string Encrypt(string text, int shift)
        {
            var ceasarShift = new CeacarShift();
            return ceasarShift.CaesarShift(text, shift);
        }
        public string Decrypt(string text, int shift)
        {
            var ceasarShift = new CeacarShift();
            return ceasarShift.CaesarShift(text, shift);
        }
    }
}
