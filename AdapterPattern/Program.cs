using System;
using System.Text;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string message = "A very complicated and hidden message";

            Console.WriteLine("The following is a encrypted message:");
            string code = EncryptMessage(message);
            Console.WriteLine(code);

            Console.WriteLine("And now the decryption adapter will do its magic...");
            Console.WriteLine("And the result is :");
            IDecryptor decryptor = new DecryptorAdapter();
            string decription = decryptor.Decrypt(code);
            Console.WriteLine($"\"{decription}\"");

        }

        static string EncryptMessage(string message)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for(int i = 0; i < message.Length; i++)
            {
                sb.Append(message[i]);
                for(int c = 0; c < 3; c++)
                {
                    char rndChar = (char) rnd.Next(65, 123);
                    sb.Append(rndChar);
                }
            }

            return sb.ToString();
        }
    }
}
