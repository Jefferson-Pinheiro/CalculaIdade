# CalculaIdade

Programa


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


CLASSE:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    public class Pessoa
        
    {
        private int anoNascimento;

        public int AnoNascimento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }
        public  void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano de Nascimento: " + this.AnoNascimento);
            int idade = this.CalcularIdade();
            Console.WriteLine($"Idade: {idade}");
        }
        private int CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            int idade = ano - this.AnoNascimento;   
            return idade;
        }
    }
}
