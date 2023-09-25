using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class ConsultaMedica
    {
        //definindo atributos
        private DateTime dataConsulta;
        private string motivoConsulta;
        private string tratamento;

        //construtor

        //métodos

        //método para agendar a consulta
        public void AgendarConsulta()
        {
            Console.WriteLine("<<<<< Agendamento Consulta >>>>>");
            Console.WriteLine("Informe a data desejada para agendar (dd/MM/yyyy HH:mm:ss):");
            dataConsulta = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("A consulta do seu animal foi agendada em " + dataConsulta);
            //se faz necessário incluir qual o animal e qual veterinário e sua especialidade
        }

        //método para registrar o decorrer da consulta
        public void RegistrarConsulta()
        {
            Console.WriteLine("<<<<< Consulta do Animal >>>>>");
            dataConsulta = DateTime.Now;
            Console.WriteLine("Data da consulta: " + dataConsulta);
            Console.WriteLine("Informe o motivo da consulta: ");
            motivoConsulta = Console.ReadLine();
            Console.WriteLine("Informe o tratamento indicado ou outros procedimentos: ");
            tratamento = Console.ReadLine();
        }

        public void ExibirConsulta()
        {
            Console.WriteLine("Dados cadastrados:");
            Console.WriteLine("Data da consulta: " + dataConsulta);
            Console.WriteLine("Motivo da consulta: " + motivoConsulta);
            Console.WriteLine("Tratamento ou outros procedimentos: " + tratamento);
        }
    }
}
