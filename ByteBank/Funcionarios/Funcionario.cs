using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        /*
         private -> Apenas dentro da classe pode-se alterar o valor da propriedade
         public -> De qualquer lugar do projeto pode-se alterar o valor da propriedade
         protected -> Apenas dentro da Classe e de quem Herda a classe pode-se alterar o valor da propriedade 
         */
        public static int TotalFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        // Primeiro executa o construtora da Classe Pai depois as Filhas 
        public Funcionario(string cpf, double salario)
        {
            TotalFuncionarios++;
            Salario = salario;
        }

        // virtual -> indica que este método será sobreescristo em algum lugar, neste exemplo, será sobrescrito em Diretor
        // public virtual double GetBonificacao()
        // {
        //     return Salario * 0.1;
        // }

        // com métodos abstratos, a Classe Filha deve fazer a implementação desses métodos
        // métodos abstratos apenas em classes abstratas
        public abstract double GetBonificacao();
        public abstract void AumertarSalario();
    }
}
