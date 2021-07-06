using ByteBank.Funcionarios;
using ByteBank.Sistema;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("546.879.157-28", 5000);
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            sistemaInterno.Logar(roberta, "123");

            GerentedeConta camila = new GerentedeConta("326.985.628-89", 2000);
            camila.Nome = "Camila";
            camila.Senha = "abc";

            sistemaInterno.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciarBonificacao gerenciador = new GerenciarBonificacao();

            Designer pedro = new Designer("833.222.048-39", 3000);
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("546.879.157-28", 5000);
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53", 1000);
            igor.Nome = "Igor";

            GerentedeConta camila = new GerentedeConta("326.985.628-89", 2000);
            camila.Nome = "Camila";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);
        }
    }
}
