using System.ComponentModel.Design;

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

Input choice: ");
                string choice = (Console.ReadLine());

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Enter text to encrypt:  ");
                        string plaintext = Console.ReadLine();


                        while (true)
                        {
                            Console.Write("Enter shift key (e.g.,3): ");
                            string input = (Console.ReadLine());

                            if (int.TryParse(input, out shift) && shift >= 1 && shift <= 26)
                            {
                                encryptedText = cipher.Encrypt(plaintext, shift);
                                Console.WriteLine($"\nEncrypted Text : {encryptedText}");
                                Console.WriteLine("Press any key to go back to meny");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Shift must be between 1-26");
                            }
                        }
                        break;

                    case "2":
                        Console.Clear();
                        string decryptedText = cipher.Decrypt(encryptedText, -shift);
                        Console.WriteLine($"\nDecrypted Text: {decryptedText}");
                        Console.WriteLine("Press any key to go back to meny");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Clear();
                        Console.Write("Enter text to decrypt: ");
                        string encryptedNoKeyText = Console.ReadLine();

                        Console.WriteLine("Trying each possible key...");
                        for (int i = 1; i <= 26; i++)
                        {
                            string attemptDecryption = cipher.Decrypt(encryptedNoKeyText, i);
                            Console.WriteLine($"Key {i} : {attemptDecryption}");
                        }
                        Console.WriteLine("Press any key to go back to meny");
                        Console.ReadLine();
                        break;

                    case "4":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Try again.");
                        break;

                }
            }
        }
    }
}
  