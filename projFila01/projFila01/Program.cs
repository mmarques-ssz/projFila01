using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projFila01
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> filaNomes;
            filaNomes = new Queue<string>();

            filaNomes.Enqueue("Huguinho");
            filaNomes.Enqueue("Zezinho");
            filaNomes.Enqueue("Luizinho");
            filaNomes.Enqueue("Margarida");
            filaNomes.Enqueue("Pato Donald");
            filaNomes.Enqueue("Tio Patinhas");
            filaNomes.Enqueue("Maga Patalógika");
            filaNomes.Enqueue("Patacôncio");
            filaNomes.Enqueue("Peninha");
            mostraFila(filaNomes);

            extremos(filaNomes);

            mostraFila(filaNomes);

            Console.WriteLine("Desenfileirado: {0}", filaNomes.Dequeue());
            Console.WriteLine("---------------------------");

            mostraFila(filaNomes);

            extremos(filaNomes);

            while (filaNomes.Count > 0)
            {
                Console.WriteLine("Desenfileirado: {0}", filaNomes.Dequeue());
            }
            Console.WriteLine("---------------------------");

            mostraFila(filaNomes);

            extremos(filaNomes);

            Console.ReadKey();
        }

        static void mostraFila(Queue<string> fn)
        {
            Console.WriteLine("-- Qtde elementos: {0}", fn.Count);
            foreach (string n in fn)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("---------------------------");
        }

        static void extremos(Queue<string> fn)
        {
            if (fn.Count > 0)
            {
                Console.WriteLine("Peek: {0}", fn.Peek());
                Console.WriteLine("First: {0}", fn.First());
                Console.WriteLine("Last: {0}", fn.Last());
                Console.WriteLine("---------------------------");
            }
            else
            {
                Console.WriteLine("--- Fila vazia ---");
            }
        }

    }
}
