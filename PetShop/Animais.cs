using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PetShop
{
    class Animais
    {
        //atributos da classe Animais
        private String nome;
        private String especie;
        private DateTime datanasc;
        private String raca;
        private float peso;

        //métodos da classe Animais

        public void Cadastrar()
        {
            //método para cadastrar
            Console.WriteLine("--CADASTRO DO ANIMAL--");
            Console.Write("Digite o nome do animal: ");
            nome = Console.ReadLine();

            Console.Write("Digite a espécie do animal: ");
            especie = Console.ReadLine();

            Console.Write("Digite a data de nascimento do animal: ");
            datanasc = DateTime.Parse(Console.ReadLine()); //,"dd-MM-yyyy", CultureInfo.InvariantCulture);

            Console.Write("Digite a raça do animal: ");
            raca = Console.ReadLine();

            Console.Write("Digite o peso do animal: ");
            peso = float.Parse(Console.ReadLine());
        }

        public void Excluir()
        {
            //método para excluir
            nome = string.Empty;
            especie = string.Empty;
            datanasc = DateTime.MinValue;
            raca = string.Empty;
            peso = 0.0f;
            Console.WriteLine("Animal excluído com sucesso!");
        }

        public void Alterar()
        {
            //método para alterar
            Console.WriteLine("--ALTERAÇÃO DE DADOS DO ANIMAL--");

            do
            {
                try
                {
                    Console.WriteLine("INFORME O NOME DO ANIMAL PARA CONSULTAR SEUS DADOS:");
                    string consultaAnimal = Console.ReadLine().ToUpper();
                    if (consultaAnimal == nome.ToUpper())
                    {
                        Console.Write("NOME: ");
                        nome = Console.ReadLine();

                        Console.Write("ESPÉCIE: ");
                        especie = Console.ReadLine();

                        Console.Write("DATA DE NASCIMENTO: ");
                        datanasc = DateTime.Parse(Console.ReadLine()); //, "yyyy/MM/dd", CultureInfo.InvariantCulture);

                        Console.Write("RAÇA: ");
                        raca = Console.ReadLine();

                        Console.Write("PESO: ");
                        peso = float.Parse(Console.ReadLine());
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Animal não encontrado!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Formato Inválido para data ou peso.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            } while (true);
        }

        public void Consultar()
        {
            //método para consultar
            Console.WriteLine("--CONSULTAR DADOS DO ANIMAL--");
            do
            {
                Console.WriteLine("INFORME O NOME DO ANIMAL PARA CONSULTAR SEUS DADOS:");
                string consultaAnimal = Console.ReadLine().ToUpper();
                if (consultaAnimal == nome.ToUpper())
                {
                    Console.WriteLine("NOME: " + nome);
                    Console.WriteLine("ESPÉCIE: " + especie);
                    Console.WriteLine("DATA DE NASCIMENTO: " + datanasc);
                    Console.WriteLine("RAÇA: " + raca);
                    Console.WriteLine("PESO: " + peso + "kg");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Animal não encontrado!");
                }
            } while (true);

        }
    }
}
