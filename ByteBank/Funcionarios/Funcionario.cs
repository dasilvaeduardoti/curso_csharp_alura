using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        //Declarando a classe como virtual, é possível sobrescrever em outro método que sera herdado
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
