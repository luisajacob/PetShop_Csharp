using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animais> animais = new List<Animais>();

            Animais animal = new Animais();
            Veterinario vet = new Veterinario();
            ConsultaMedica consulta = new ConsultaMedica();

            Console.WriteLine("//////Bem vindos ao Petshop da Luísa//////");

            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.WriteLine("\nMENU");
                    Console.WriteLine("1 - Animais");
                    Console.WriteLine("2 - Veterinário");
                    Console.WriteLine("3 - Consulta Médica");
                    Console.WriteLine("4 - Sair");

                    int opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            bool cont = true;

                            while (cont)
                            {
                                Console.WriteLine("\nEscolha a opção desejada:");
                                Console.WriteLine("1 - Cadastrar animal");
                                Console.WriteLine("2 - Alterar dados do animal");
                                Console.WriteLine("3 - Excluir dados do animal");
                                Console.WriteLine("4 - Consultar dados do animal");
                                Console.WriteLine("5 - Voltar");

                                int num = int.Parse(Console.ReadLine());

                                switch (num)
                                {
                                    case 1:
                                        animal.Cadastrar();
                                        animais.Add(animal);
                                        break;

                                    case 2:
                                        animal.Alterar();
                                        break;

                                    case 3:
                                        animal.Excluir();
                                        break;

                                    case 4:
                                        animal.Consultar();
                                        break;

                                    case 5:
                                        Console.WriteLine("VOLTANDO...");
                                        cont = false;
                                        break;

                                    default:
                                        Console.WriteLine("OPÇÃO INVÁLIDA");
                                        Console.WriteLine("Escolha uma opção entre 1 e 5!");
                                        break;
                                }
                            }
                            break;

                        case 2:
                            bool cont1 = true;

                            while (cont1)
                            {
                                Console.WriteLine("\nEscolha a opção desejada:");
                                Console.WriteLine("1 - Cadastrar Veterinário");
                                Console.WriteLine("2 - Alterar dados do Veterinário");
                                Console.WriteLine("3 - Excluir dados do Veterinário");
                                Console.WriteLine("4 - Consultar dados do Veterinário");
                                Console.WriteLine("5 - Voltar");

                                int num1 = int.Parse(Console.ReadLine());

                                switch (num1)
                                {
                                    case 1:
                                        vet.AdicionarVet();
                                        break;

                                    case 2:
                                        vet.AlterarVet();
                                        break;

                                    case 3:
                                        vet.ExcluirVet();
                                        break;

                                    case 4:
                                        vet.ConsultarVet();
                                        break;

                                    case 5:
                                        Console.WriteLine("VOLTANDO...");
                                        cont1 = false;
                                        break;

                                    default:
                                        Console.WriteLine("OPÇÃO INVÁLIDA");
                                        Console.WriteLine("Escolha uma opção entre 1 e 5!");
                                        break;
                                }
                            }
                            break;

                        case 3:
                            bool cont2 = true;

                            while (cont2)
                            {
                                Console.WriteLine("\nEscolha a opção desejada:");
                                Console.WriteLine("1 - Agendar Consulta");
                                Console.WriteLine("2 - Registrar Consulta");
                                Console.WriteLine("3 - Exibir Consulta");
                                Console.WriteLine("4 - Voltar");

                                int num2 = int.Parse(Console.ReadLine());

                                switch (num2)
                                {
                                    case 1:
                                        consulta.AgendarConsulta();
                                        break;

                                    case 2:
                                        consulta.RegistrarConsulta();
                                        break;

                                    case 3:
                                        consulta.ExibirConsulta();
                                        break;

                                    case 4:
                                        Console.WriteLine("VOLTANDO...");
                                        cont2 = false;
                                        break;

                                    default:
                                        Console.WriteLine("OPÇÃO INVÁLIDA");
                                        Console.WriteLine("Escolha uma opção entre 1 e 5!");
                                        break;
                                }
                            }
                            break;
                        case 4:
                            Console.WriteLine("SAINDO...");
                            continuar = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
            Console.ReadKey();
        }
    }
}
