using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        //Declarando o método como override para sobrescrever o método herdado do Funcionario
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}