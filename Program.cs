using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a Idade de uma pessoa");
            Pessoa p = new Pessoa();
            Console.WriteLine("Nome da Pessoa: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Ano de Nascimento: ");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
            p.ExibirDados();
            Console.ReadKey();
        }
    }
}
