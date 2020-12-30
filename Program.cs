using System;

namespace aplicacao_console_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int numeroDeVezes = 5;

            for (int i = 0; i < numeroDeVezes; i++)
            {
                //interpolation
                Console.WriteLine($"Bem-vindo ao curso de .NET {i}");
            }
        }
    }
}
