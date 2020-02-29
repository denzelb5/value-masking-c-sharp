using System;

namespace value_masking_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string secret;

            Console.WriteLine("Ahoy Matey!  Tell me a secret...");
            secret = Console.ReadLine();
            if (secret.Length > 4)
            {
                Console.WriteLine(
                    string.Concat(
                        "".PadLeft(12, '*'),
                        secret.Substring(secret.Length - 4)
                    )
                );
            }
            else
            {
                Console.WriteLine(secret);
            }
        }
    }
}
