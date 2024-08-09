using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoológico.Classes;

namespace ProjetoZoo
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoologico zoologico = new Zoologico();

            while (true)
            {
                Console.WriteLine("Selecione a opção: ");
                Console.WriteLine("1 Adicionar Mamifero");
                Console.WriteLine("2 Adicionar ave");
                Console.WriteLine("3 Adicionar reptil");
                Console.WriteLine("4 listar animais");
                Console.WriteLine("5 alimentar animais");
                Console.WriteLine("6 cuidar animais");
                Console.WriteLine("7 adicionar tratador de mamiferos");
                Console.WriteLine("8 adicionar tratador de aves");
                Console.WriteLine("9 Listar tratadores");
                Console.WriteLine("10 sair");
                string opcao = Console.ReadLine();

                if(opcao == "10")
                {
                    break;
                }

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do mamifero: ");
                        string nomeMamifero = Console.ReadLine();

                        Console.WriteLine("Digite a idade do mamifero: ");
                        int idadeMamifero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o tipo de pelo do animal: ");
                        string tipoPelo = Console.ReadLine();

                        Mamifero mamifero = new Mamifero(nomeMamifero, idadeMamifero, tipoPelo);

                        zoologico.AdicionarAnimal(mamifero);
                        break;

                       case "2":
                        Console.WriteLine("Digite o nome da ave: ");
                        string nomeAve = Console.ReadLine();

                        Console.WriteLine("Digite a idade da ave: ");
                        int idadeAve = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a envergadura da asa: ");
                        double envergaduraAsa = double.Parse(Console.ReadLine());

                        Ave ave = new Ave(nomeAve, idadeAve, envergaduraAsa);

                        zoologico.AdicionarAnimal(ave);

                        break;

                        case "3":
                        Console.WriteLine("Digite o nome do reptil: ");
                        string nomeReptil = Console.ReadLine();

                        Console.WriteLine("Digite a idade do Reptil: ");
                        int idadeReptil = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o tipo de escama: ");
                        string tipoEscama = Console.ReadLine();

                        Reptil reptil = new Reptil(nomeReptil, idadeReptil, tipoEscama);

                        zoologico.AdicionarAnimal(reptil);

                        break;


                        case "4":
                        zoologico.ListarAnimais();
                        break;

                        case "5":
                        zoologico.AlimentarAnimais();
                        break;

                        case "6":
                        zoologico.CuidarAnimais();
                        break;

                        case "7":
                        Console.WriteLine("Digite o nome do tratador: ");
                        string nomeTratador = Console.ReadLine();
                        string especialidadeTratador = "Mamiferos";

                      
                        TratadorMamiferos tratadorMamiferos = new TratadorMamiferos(nomeTratador, especialidadeTratador);
                       
                        zoologico.AdicionarTratador(tratadorMamiferos);

                        break;

                        case "8":

                        Console.WriteLine("Digite o nome do tratador: ");
                        string nomeTratadorAves = Console.ReadLine();
                        string especialidadeTratadorAves = "Aves";


                        TratadorAves tratadorAves = new TratadorAves(nomeTratadorAves, especialidadeTratadorAves);

                        zoologico.AdicionarTratador(tratadorAves);

                        break;

                        case "9":
                        zoologico.ListarTratadores();
                        break;
                    default:
                        Console.WriteLine("opção desconhecida!");
                        break;

                }
                   
            }
        }
    }
}
