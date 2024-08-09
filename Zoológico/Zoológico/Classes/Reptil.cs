using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoológico.Classes
{
    public class Reptil : Animal
    {
        public string TipodeEscama { get; set; }

        public Reptil(string nome, int idade, string tipodeEscama) : base(nome, idade)
        {
            TipodeEscama = tipodeEscama;
        }

        public override void EmitirSom()
        {
            Console.WriteLine( $"{Nome}faz som de reptil");
        }
    }
}
