using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class GerentedeConta : FuncionarioAutenticavel
    {
        public GerentedeConta(string cpf, double salario) : base(cpf, salario)
        {
        }

        public override void AumertarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
