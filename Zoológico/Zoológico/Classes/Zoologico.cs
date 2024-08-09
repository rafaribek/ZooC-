using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoológico.interfaces;

namespace Zoológico.Classes
{
    public class Zoologico
    {
        private List<Animal> animais = new List<Animal>();

        private List<Tratador> tratadores = new List<Tratador>();
        public void AdicionarAnimal(Animal animal)
        {
            animais.Add(animal);
            Console.WriteLine($"{animal.Nome} foi adicionado");
        }

        public void ListarAnimais()
        {
            if ( animais.Count > 0 )
            {
                Console.WriteLine("Animais no zoologico: ");
                foreach( Animal animal in animais)
                {
                   
                    Console.WriteLine($"Nome: {animal.Nome}, Idade: {animal.Idade}");
                }
            }
            else
            {
                Console.WriteLine("A lista esta vazia!");
            }

        }
        public void AlimentarAnimais()
        {
            Console.WriteLine("Alimentando os animais...");
            foreach ( Animal animal in animais )
            {
                if(animal is IAlimentavel alimentavel)
                {
                    alimentavel.Alimentar();
                }
                
            }
        }
        public void CuidarAnimais()
        {
            Console.WriteLine("Cuidando dos animais...");
            foreach (Animal animal in animais )
            {
                if(animal is ICuidavel cuidavel)
                {
                    cuidavel.Cuidar();
                }
            }
        }

        public void AdicionarTratador(Tratador tratador)
        {
            tratadores.Add(tratador);
            Console.WriteLine($"{tratador.Nome} foi adicionado!");
        }

        public void ListarTratadores()
        {
            if (tratadores.Count > 0)
            {
                Console.WriteLine("Tratadores do zoológico: ");
                foreach (Tratador tratador in tratadores)
                {
                    Console.WriteLine($" Nome do tratador: {tratador.Nome}, Especialidade: {tratador.Especialidade}");
                }
            }
            else
            {
                Console.WriteLine("A lista está vazia!");
            }
        }
    }
}
