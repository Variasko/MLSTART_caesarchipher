using System;

class CaesarCipher
{
    static void Main()
    {
        Console.WriteLine("Введите текст для шифрования: ");
        string input = Console.ReadLine();

        Console.WriteLine("Введите сдвиг: ");
        int shift = Convert.ToInt32(Console.ReadLine());

        string encryptedText = Encrypt(input, shift);
        Console.WriteLine("Зашифрованный текст: " + encryptedText);
    }

    static string Encrypt(string input, int shift)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        string encryptedText = "";

        foreach (char c in input)
        {
            if (alphabet.Contains(c))
            {
                if (alphabet.IndexOf(c) + shift > 0)
                {
                    encryptedText += alphabet[(alphabet.IndexOf(c) + shift) % 26];
                }
                else
                {
                    encryptedText += alphabet[(alphabet.IndexOf(c) + shift + 26) % 26];
                }
            }
            else
            {
                encryptedText += ' ';
            }
        }

        return encryptedText;
    }
}
