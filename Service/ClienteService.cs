using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBanco.Service
{
    public class ClienteService
    {
    static List<Cliente> cliente = new List<Cliente>();
    }
        public void CriarConta()
    {
    string opcao;
    do {
        Console.WriteLine("Que tipo de conta gostaria de abrir?");
        Console.WriteLine("1 - Pessoa Jurídica");
        Console.WriteLine("2 - Pessoa Física");
        Console.WriteLine("3 - Sair");
        opcao = Console.ReadLine();
        if(opcao == "1"){
        PessoaJuridica();
        }
        else if (opcao == "2"){
        PessoaFisica();
        }
        Console.WriteLine("Tecle Enter para continuar");
        Console.ReadLine();
        }while(opcao != "3");
  }

      private PessoaFisica CriarContaPF()
      {
        PessoaFisica pessoafisica = new PessoaFisica();
        Console.WriteLine("Data de Nascimento do cliente:");
        pessoafisica.DataNascimento = DateTime.Parse(Console.ReadLine());
        if(!pessoafisica.EhMaior()){
          Console.WriteLine("Não é possivel abrir a conta pois o CLiente é menor de idade");
          return null;
        }
        Console.WriteLine("A idade do cliente é " + pessoafisica.Idade);
        Console.WriteLine("Nome do cliente:");
        pessoafisica.Nome = Console.ReadLine();
        Console.WriteLine("CPF do cliente:");
        pessoafisica.CPF = Console.ReadLine();
        Console.WriteLine("Endereco do cliente:");
        pessoafisica.Endereco = Console.ReadLine();
        Console.WriteLine("Telefone do cliente:");
        pessoafisica.Telefone = Console.ReadLine();
        Console.WriteLine("Email do cliente:");
        pessoafisica.Email = Console.ReadLine();
        Console.WriteLine("Numero Da Conta");
        pessoafisica.NumeroConta = int.Parse(Console.ReadLine());
        Console.WriteLine("Tipo de conta do cliente:");
        pessoafisica.TipoConta = Console.ReadLine();
        clientes.Add(pessoafisica);
      }

      private PessoaJuridica CriarContaPF()
      {
        PessoaJuridica pessoajuridica = new PessoaJuridica();
        Console.WriteLine("Razão Social da empresa:");
        pessoajuridica.Nome = Console.ReadLine();
        Console.WriteLine("CNPJ da empresa:");
        pessoajuridica.CNPJ = Console.ReadLine();
        Console.WriteLine("Data de fundação da empresa:");
        pessoajuridica.DataFundacao = Console.ReadLine();
        Console.WriteLine("Endereco da empresa:");
        pessoajuridica.Endereco = Console.ReadLine();
        Console.WriteLine("Telefone da empresa:");
        pessoajuridica.Telefone = Console.ReadLine();
        Console.WriteLine("Email da empresa:");
        pessoajuridica.Email = Console.ReadLine();
        Console.WriteLine("Numero Da Conta");
        pessoajuridica.NumeroConta = int.Parse(Console.ReadLine());
        Console.WriteLine("Tipo de conta da empresa:");
        pessoajuridica.TipoConta = Console.ReadLine();
        clientes.Add(pessoajuridica);
      }
}