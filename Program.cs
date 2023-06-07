using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leoleoleo5
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            String opcao;
            Console.WriteLine("Bem-vindo ao DETRAN");
            Console.WriteLine("DIGITE SUA IDADE:");
            idade = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"VOCÊ TEM, {idade} ANOS");

            if (idade >=18) 
            {

                Console.WriteLine("VOCÊ JA PODE TIRAR SUA CNH");
                Console.WriteLine("VOCÊ JA TEM CNH?\n DIITE 1 PARA:SIM\n DIGITE 2 PARA: NÃO:");
                opcao = Console.ReadLine();
                if (opcao == "1")
                {

                    Console.WriteLine("voce deve renovar sua CNH");

                }
                else 
                {
                    Console.WriteLine("voce esta tirando sua primeira carteira");

                }





            }
            else
            {
                Console.WriteLine("VOCÊ TERA QUE ESPERAR");
            
            
            }
            



            Console.ReadKey();
            Main(null);



        }
    }
}
