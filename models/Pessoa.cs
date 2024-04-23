using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trabalhodotnet.models
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void apresentar()
        {
            Console.WriteLine($"Olá! meu nome é {Nome} e tenho {Idade} anos de idade.");
        }
    }
}