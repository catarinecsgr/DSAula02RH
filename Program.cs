using System;
using Aula02RH_27022024.Models;
using Aula02RH_27022024.Models.Enuns;

namespace Aula02RH_27022024 //Alt + shift + F = realinha o código
{
    class Program
    {
        static void Main(string[] args) //Método principal / o código começa a ser executado a partir daqui
        {
            Funcionarios func = new Funcionarios(); //cria-se um obj do tipo "Funcionarios" que vai ser chamado de "func" // o operador "new" é para criar uma ref do obj na memória do computador

            /*func.Id = 10;
            func.Nome = "Neymar";
            func.Cpf = "12345678910";
            func.DataAdmissao = DateTime.Parse("01/01/2000");
            func.Salario = 10000.00M; //M = força para que a tela entenda que trata-se de um decimal
            func.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.CLT;*/

            Console.WriteLine("Digite o Id do funcionário: ");
            func.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do funcionário: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("Digite o Cpf: ");
            func.Cpf = Console.ReadLine();

            Console.WriteLine("Digite a data de admissão: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Salário: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de Funcionário (1 - CLT / 2 - Aprendiz): ");
            int opcao = int.Parse(Console.ReadLine());

            //Operador Ternário - Interpretação: Se a consição dos parênteses for verdadeira,
            //escolhe o que está depois da "?", caso contrário, escolhe o que está depois dos ":"
            func.TipoFuncionario = (opcao == 1) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;

            func.ReajustarSalario();
            decimal valorDescontoVT = func.CalcularDescontoVT(6);

            string mensagem = func.ExibirPeriodoExperiencia();
            Console.WriteLine("==============================");
            Console.WriteLine(mensagem);
            Console.WriteLine("==============================");
        }   

    }
}
