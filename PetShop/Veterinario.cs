using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    internal class Veterinario
    {//atributos da classe Animais
        private String nomeVet;
        private String especialidade;
        private String diasTrabalhados;
        private int CRMV;
        private DateTime datanascVet;

        //métodos da classe Animais

        public void AdicionarVet()
        {
            //método para cadastrar
            Console.WriteLine("--CADASTRO DO VETERINÁRIO--");
            Console.Write("Digite o nome do Veterinário: ");
            nomeVet = Console.ReadLine();

            Console.Write("Digite a especialidado do Veterinário: ");
            especialidade = Console.ReadLine();

            Console.Write("Digite os dias trabalhados do Veterinário: ");
            diasTrabalhados = Console.ReadLine();

            Console.Write("Digite o CRMV do Veterinário: ");
            CRMV = int.Parse(Console.ReadLine());

            Console.Write("Digite a data de nascimento do Veterinário: ");
            datanascVet = DateTime.Parse(Console.ReadLine()); //,"dd-MM-yyyy", CultureInfo.InvariantCulture);
        }

        public void ExcluirVet()
        {
            //método para excluir
            nomeVet = string.Empty;
            especialidade = string.Empty;
            datanascVet = DateTime.MinValue;
            diasTrabalhados = string.Empty;
            CRMV = 0;
            Console.WriteLine("Veterinário excluído com sucesso!");
        }

        public void AlterarVet()
        {
            //método para alterar
            Console.WriteLine("--ALTERAÇÃO DE DADOS DO VETERINÁRIO--");

            do
            {
                try
                {
                    Console.WriteLine("INFORME O NOME DO VETERINÁRIO PARA CONSULTAR SEUS DADOS:");
                    string consultaVet = Console.ReadLine().ToUpper();
                    if (consultaVet == nomeVet.ToUpper())
                    {
                        Console.Write("NOME: ");
                        nomeVet = Console.ReadLine();

                        Console.Write("ESPECIALIDADE: ");
                        especialidade = Console.ReadLine();

                        Console.Write("DIAS TRABALHADOS: ");
                        diasTrabalhados = Console.ReadLine();

                        Console.Write("CRMV: ");
                        CRMV = int.Parse(Console.ReadLine());

                        Console.Write("DATA DE NASCIMENTO: ");
                        datanascVet = DateTime.Parse(Console.ReadLine()); //, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Veterinário não encontrado!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Formato Inválido para data ou CRMV.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            } while (true);
        }

        public void ConsultarVet()
        {
            //método para consultar
            Console.WriteLine("--CONSULTAR DADOS DO VETERINÁRIO--");
            do
            {
                Console.WriteLine("INFORME O NOME DO VETERINÁRIO PARA CONSULTAR SEUS DADOS:");
                string consultaVet = Console.ReadLine().ToUpper();
                if (consultaVet == nomeVet.ToUpper())
                {
                    Console.WriteLine("NOME: " + nomeVet);
                    Console.WriteLine("ESPECIALIDADE: " + especialidade);
                    Console.WriteLine("DIAS TRABALHADOS: " + diasTrabalhados);
                    Console.WriteLine("CRMV: " + CRMV);
                    Console.WriteLine("DATA DE NASCIMENTO: " + datanascVet);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Veterinário não encontrado!");
                }
            } while (true);

        }
    }
}
