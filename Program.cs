using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09Correcao21
{
    class Program
    {
        static void Main(string[] args)
        {
            int pontos = 0;
            Random sorteador = new Random();

            Console.WriteLine("Bem- vindo ao jogo do 21");
            Console.WriteLine("Seu objetivo é chegar próximo de 21 pontos");

            while(true)
            {
              
                Console.WriteLine($"Você tem {pontos} pontos");
                Console.WriteLine("Deseja continuar? 1 para sim ou 2 para não:");
                string opção = Console.ReadLine();
                 
                if(opção == "2")
                {
                    Console.WriteLine("- FIM DE JOGO");
                    break;
                }

                int numero = sorteador.Next(1, 11);
                Console.WriteLine("Você tirou o número "+ numero);

                pontos += numero;

                //ou pontos = pontos + numero;

                if( pontos > 21)
                {
                    Console.WriteLine("Ah que pena, você estourou a pontuação");
                    break; 
                }



            }

            Console.WriteLine("FIM DE JOGO!");
            Console.WriteLine("Sua pontuação final foi de: " + pontos);

            Console.ReadKey();



        }
    }
}
