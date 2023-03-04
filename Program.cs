using System.Globalization;
using ProjetoBanco;

/*List<Cliente> clientes = new List<Cliente>();

clientes.Add(new Cliente("Graziela", "123456", "@email","123", "Servidão",
            new DateTime(2002, 5, 15), 1));
            
clientes.Add(new Cliente("Ricardo", "123456", "@email","123", "Servidão",
            new DateTime(2002, 5, 15), 2));
            
clientes.Add(new Cliente("Carlos", "123456", "@email","123", "Servidão",
            new DateTime(2002, 5, 15), 3));

clientes.Add(new Cliente("Eduardo", "123456", "@email","123", "Servidão",
            new DateTime(2002, 5, 15), 4));*/



string opcao;
do{
  Console.WriteLine("Bem vindos ao Banco FULL STACK BANCK, escolha uma opção");
  Console.WriteLine("1 - Criar Conta ");
  Console.WriteLine("2 - Adicionar Transacao");
  Console.WriteLine("3 - Consultar Extrato");
  Console.WriteLine("4 - Sair");
  Console.WriteLine("5 - Exibir Clientes");
  opcao = Console.ReadLine();

  if(opcao == "1"){
    CriarConta();
  }
  else if (opcao == "5"){
    ExibirClientes();
  }
  else if (opcao == "2"){
    AdicionarTransacao();
  }
  else if (opcao == "3"){
    ExibirExtrato();
  }

  Console.WriteLine("Tecle Enter para continuar");
  Console.ReadLine();
} while(opcao != "4");




void AdicionarTransacao(){
  Console.WriteLine("Qual a conta?");
  int numeroConta = int.Parse(Console.ReadLine());

  Cliente contaCliente = BuscarClientePorNumeroDeConta(numeroConta);

  if (contaCliente == null){
    Console.WriteLine("Conta não cadastrada, favor cadastrar antes");
    return;
  }

  Console.WriteLine("Qual o valor da transação?" );
  double valor = double.Parse(Console.ReadLine());
  Transacao transacao = new Transacao(DateTime.Now, valor);

  contaCliente.Extrato.Add(transacao);

}

void ExibirExtrato(){
  Console.WriteLine("Qual a conta?");
  int numeroConta = int.Parse(Console.ReadLine());

  Cliente contaCliente = BuscarClientePorNumeroDeConta(numeroConta);

  if (contaCliente == null){
    Console.WriteLine("Conta não cadastrada, favor cadastrar antes");
    return;
  }
  double saldo = 0;
  foreach(Transacao transacao  in contaCliente.Extrato){
    Console.WriteLine(" Data: " + transacao.Data + " Valor: " + transacao.Valor.ToString("C2", new CultureInfo("pt-BR")) );
    saldo += transacao.Valor;
  }

  Console.WriteLine("Saldo = " + contaCliente.Saldo);

}



Cliente BuscarClientePorNumeroDeConta (int numeroConta){; 
  foreach(Cliente cliente in clientes){
    if(cliente.NumeroConta == numeroConta){
      return cliente;
    }
  }
  return null;
}

void ExibirClientes(){
   Console.WriteLine("Número da conta        | Nome         | CPF    ");
  for(int i =0; i < clientes.Count; i++){
    Console.WriteLine(clientes[i].ResumoCliente());
  }
}

