using System;
using ImplementandoHash.Entities;

namespace ImplementandoHash
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            int chave, continua;

            MapaHash mapa = new MapaHash();
            Registro dados;

            do
            {
                Console.Write("\nDigite uma chave: ");
                chave = int.Parse(Console.ReadLine());

                Console.Write("Digite um valor: ");
                texto = Console.ReadLine();

                dados = new Registro(chave, texto);
                mapa.push(dados);

                Console.Write("\nContinua (1-sim / 0-não): ");
                continua = int.Parse(Console.ReadLine());

            } while (continua != 0);

            Console.WriteLine("\n\n::::::::::::::::::::::::::::::::");

            do
            {
                Console.Write("Digite um chave: ");
                chave = int.Parse(Console.ReadLine());
                dados = mapa.get(chave);

                if (chave != -1) 
                {
                    if (dados != null)
                        Console.WriteLine($"Registro = {dados.getValue()}");
                   
                    else
                        Console.WriteLine("Não existe");
                }


            } while (chave != -1);


        }
    }
}
