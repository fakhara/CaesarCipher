namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text to encrypt:  ");
            string plaintext = Console.ReadLine();

            Console.Write("Enter shift key (e.g.,3): ");
            int shift = int.Parse(Console.ReadLine());

            string encryptedText = Encrypt(plaintext, shift);
            Console.WriteLine($"Encrypted Text : {encryptedText}");

            string decryptedText = Decrypt(encryptedText, -shift);
            Console.WriteLine($"Decrypted Text: {decryptedText}");
        }
        static string Encrypt(string text, int shift)
        {
            return CaesarShift(text, shift);
        }

        static string Decrypt(string text, int shift)
        {
            return CaesarShift(text, shift);
        }
        static string CaesarShift(string text, int shift)
        {
            char[] buffer = text.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)((((letter + shift) - offset + 26) % 26) + offset);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}