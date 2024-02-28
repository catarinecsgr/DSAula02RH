using System;
using Aula02RH_27022024.Models.Enuns;

namespace Aula02RH_27022024.Models //Endereço físico e virtual onde está contido esse arquivo / o .Models é importante p/ referenciar
{
    public class Funcionarios //Assinatura da classe
    {
        public int Id { get; set; } //Assinatura do método
        public string Nome { get; set; } = ""; //inicia zerado
        public string Cpf { get; set; } = string.Empty; //inicia zerado
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
        public TipoFuncionarioEnum TipoFuncionario { get; set; }
        public void ReajustarSalario() //"void" não apresenta retorno, logo, não precisa adicionar "return" abaixo
        {
            Salario = Salario + (Salario * 10/100);
        }

        public string ExibirPeriodoExperiencia()
        {
            string periodoExperiencia =
                string.Format("Período de Experiência: {0} até {1}", DataAdmissao, DataAdmissao.AddMonths(3));
            return periodoExperiencia;                
        }

        public decimal CalcularDescontoVT(decimal percentual) //variável local declara-se com a letra minúscula por padrão
        {
            decimal desconto = this.Salario * percentual/100; //"this.Propriedade" serve p/ referenciar uma propriedade que está nesse doc
            return desconto;
        }

        private int ContarCaracteres(string dado)
        {
            return dado.Length;
        }

        public bool ValidarCpf()
        {
            if(ContarCaracteres(Cpf) ==11)
                return true;
            else
                return false;
        }
        
    }
}