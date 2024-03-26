using System;
using System.Security.Authentication;
using System.Transactions;

class CaesarCipher
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nCaesar Cipher Tool");
            Console.WriteLine("1. Encrypt");
            Console.WriteLine("2. Decrypt");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Select an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter text to encrypt: ");
                    var textToEncrypt = Console.ReadLine();

                    Console.WriteLine($"Encrypted text: {Encrypt(textToEncrypt, 3)}");
                    break;

                case "2":
                    Console.Write("Enter text to decrypt: ");
                    var textToDecrypt = Console.ReadLine();
                    Console.WriteLine($"Decrypted text: {Decrypt(textToDecrypt, 3)}");
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }

        }
    }

    static string Encrypt(string input, int shift)
    {
        return Cipher(input, shift);
    }


    static string Decrypt(string input, int shift)
    {
        return Cipher(input, -shift);
    }


    static string Cipher(string input, int shift)
    {
        char[] buffer = input.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            letter = (char)(letter + shift);
            if (letter > 'z')
            {
                letter = (char)(letter - 26);
            }
            else if (letter < 'a')
            {
                letter = (char)(letter + 26);
            }
            buffer[i] = letter;
        }
        return new string(buffer);
    }

}

