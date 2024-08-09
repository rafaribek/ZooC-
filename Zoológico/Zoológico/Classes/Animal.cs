using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoológico.Classes
{

    public abstract class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, int idade) 
        {
            Nome = nome;
            Idade = idade;
        }

        public abstract void EmitirSom();
    }
}
