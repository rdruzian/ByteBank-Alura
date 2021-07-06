using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer(string cpf, double salario) : base(cpf, salario)
        {
        }

        public override void AumertarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
