using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // : indica a Herança para a Classe Funcionário
    public class Diretor : FuncionarioAutenticavel
    {
        // : -> no construtor indica para executar o construtor da Classe Pai
        // base -> no construtor, ele passa o o valor para o construtor da Classe Pai
        public Diretor(string cpf, double salario) : base(cpf, salario)
        {
            Console.WriteLine("Criando um Diretor!");
        }
        // override -> é utilizado para realizar a sobrescrita de um método, este método existe na Classe Pai
        public override double GetBonificacao()
        {
            // base -> utiliza o método GetBOnificacao() da Classe Pai, ou seja, de Funcionario
            return Salario * 0.5;
        }

        public override void AumertarSalario()
        {
            Salario *= 1.15;
        }
    }
}
