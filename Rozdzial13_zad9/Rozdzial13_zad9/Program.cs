using System;

namespace Rozdzial13_zad9
{
    class Program // do poprawy!
    {
        public static string XORCipher(string data, string key)
        {
            int dataLen = data.Length;
            ushort keyLen = Convert.ToUInt16(key.Length);
            char[] output = new char[dataLen];

            for (int i = 0; i < dataLen; ++i)
            {
                output[i] = ((char)(Convert.ToUInt16(data[i]) ^ (ushort)key[i % keyLen]));
            }

            return new string(output);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("9. Write a program that encrypts a text by applying XOR (excluding or) operation between the given source characters and given cipher code. The encryption should be done by applying XOR between the first letter of the text and the first letter of the code, the second letter of the text and the second letter of the code, etc. until the last letter of the code, then goes back to the first letter of the code and the next letter of the text. Print the result as a series of Unicode escape characters xxxx. Sample source text: \"Test\".Sample cipher code: \"ab\". The result should be the following: \"\u0035\u0007\u0012\u0016\".");


            string text = "Test";
            string key = "ab";
            string cipherText = XORCipher(text, key);
            string plainText = XORCipher(cipherText, key);

            Console.WriteLine("\\u{0:x4}", cipherText);

            Console.ReadKey();
        }
    }
}
