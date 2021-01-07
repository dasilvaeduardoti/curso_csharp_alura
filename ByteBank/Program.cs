using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("546.879.157-20");
            carlos.Nome = "Carlos";
            //carlos.Cpf = "546.879.157-20";
            carlos.Salario = 2000;

            Console.WriteLine("Total Funcionario: " + Funcionario.TotalFuncionaros);
            
            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            //roberta.Cpf = "454.658.148-3";
            roberta.Salario = 5000;

            Console.WriteLine("Total Funcionario: " + Funcionario.TotalFuncionaros);

            Console.WriteLine("Salário do "+ carlos.Nome + " (Funcionario): " + carlos.Salario);
            Console.WriteLine("Salário da "+ roberta.Nome + " (Diretora): " + roberta.Salario);

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            
            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());
            
            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();

        }
    }
}
