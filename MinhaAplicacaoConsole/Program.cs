using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaAplicacaoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de uma variável do tipo String
            string strNome;
            //Mostrando uma mensagem na tela
            Console.Write("Informe seu nome: ");
            //Fazendo uma leitura do teclado
            strNome = Console.ReadLine();
            //Mostrando uma mensagem na tela, utilizando o que foi lido do teclado
            Console.WriteLine("Olá " + strNome + ". Seja bem vind@!");
            //Mostrando uma mensagem na tela
            Console.WriteLine("Precione qualquer tecla para continuar...");
            //Espera que alguma tecla seja precionada para encerrar a aplicação
            Console.ReadKey();
        }
    }
}
