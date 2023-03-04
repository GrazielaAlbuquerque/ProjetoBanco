using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class PessoaJuridica : Cliente
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataFundacao { get; set; } 

        public PessoaJuridica(string razaoSocial, string cnpj, DateTime dataFundacao, int numeroConta, string email, string telefone,string end) : base (email, telefone, end, numeroConta, tipoConta)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            DataFundacao = dataFundacao;

        }
        public override void ResumoCliente(){ //metodo sob
        Console.WriteLine($"{NumeroConta}  | {RazaoSocial} |  {CNPF}  ");
        } 
    }
}