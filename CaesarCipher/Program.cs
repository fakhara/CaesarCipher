namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;
            string encryptedText = "";
            int shift = 0;

            while (!exit)
            {
                Cipher cipher = new Cipher();
                Console.Clear();
                Console.Write(@$"Choose an option: 

1. Encrypt
2. Decrypt
3. Decrypt encrypted
4. Exit

Ditt val: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Enter text to encrypt:  ");
                        string plaintext = Console.ReadLine();

                        Console.Write("Enter shift key (e.g.,3): ");
                        shift = int.Parse(Console.ReadLine());

                        encryptedText = cipher.Encrypt(plaintext, shift);
                        Console.WriteLine($"\nEncrypted Text : {encryptedText}");
                        Console.WriteLine("Press any key to go back to meny");
                        Console.ReadLine();
                        break;

                        case 2:
                        Console.Clear();
                        string decryptedText = cipher.Decrypt(encryptedText, -shift);
                        Console.WriteLine($"\nDecrypted Text: {decryptedText}");
                        Console.WriteLine("Press any key to go back to meny");
                        Console.ReadLine();
                        break;

                        case 3:
                        Console.Clear();
                        Console.Write("Enter text to decrypt: ");
                        string encryptedNoKeyText = Console.ReadLine();

                        Console.WriteLine("Trying each possible key...");
                        for(int i = 1; i <= 26; i++)
                        {
                            string attemptDecryption = cipher.Decrypt(encryptedNoKeyText, i);
                            Console.WriteLine($"Key {i} : {attemptDecryption}");
                        }
                            Console.WriteLine("Press any key to go back to meny");
                            Console.ReadLine();
                        break;

                    case 4:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Try again.");
                        break;

                }
            }

        }
        //static string Encrypt(string text, int shift)
        //{
        //    return CaesarShift(text, shift);
        //}

        //static string Decrypt(string text, int shift)
        //{
        //    return CaesarShift(text, shift);
        //}
        //static string CaesarShift(string text, int shift)
        //{
        //    char[] buffer = text.ToCharArray();

        //    for (int i = 0; i < buffer.Length; i++)
        //    {
        //        char letter = buffer[i];
        //        if (char.IsLetter(letter))
        //        {
        //            char offset = char.IsUpper(letter) ? 'A' : 'a';
        //            letter = (char)((((letter + shift) - offset + 26) % 26) + offset);
        //        }
        //        buffer[i] = letter;
        //    }
        //    return new string(buffer);
        //}
    }
}