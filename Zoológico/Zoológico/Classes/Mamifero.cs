using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Zoológico.interfaces;

namespace Zoológico.Classes
{
    public class Mamifero : Animal, IAlimentavel, ICuidavel
    {
        public string TipodePelo { get; set; }
        
        public Mamifero(string nome, int idade, string tipodePelo) : base(nome, idade)
        {
            TipodePelo = tipodePelo;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} faz som de mamifero");
        }

        public void Alimentar()
        {
            Console.WriteLine($"{Nome} é mamifero e esta sendo alimentado");
        }
        public void Cuidar()
        {
            Console.WriteLine($"{Nome} é mamifero esta sendo cuidado");
        }
    }
    
}
