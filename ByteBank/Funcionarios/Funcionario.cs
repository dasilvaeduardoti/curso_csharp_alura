using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionaros { get; private set; }
        public string Cpf { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, double salario)
        {
            Cpf = cpf;
            Salario = salario;
            TotalFuncionaros++;
        }

        //Declarando a classe como virtual, é possível sobrescrever em outro método que sera herdado
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
