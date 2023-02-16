using ProjetoBanco;

List<Cliente> clientes = new List<Cliente>();
string opcao;
do{
Console.WriteLine("Bem vindo ao Banco Full Stack Banck, escolha uma opção:");
Console.WriteLine("1 - Criar Conta ");
Console.WriteLine("2 - Adicionar Transação");
Console.WriteLine("3 - Consultar Extrato");
Console.WriteLine("4 - Exibir Cliente");
Console.WriteLine("5 - Sair");
opcao = Console.ReadLine();

if(opcao == "1") {
        CriarConta();
}
if(opcao =="4"){
        ExibirClientes();
}
        Console.WriteLine("Tecle ENTER para continuar");
        Console.ReadLine();
} while(opcao != "3");

void ExibirClientes(){
Console.WriteLine("Número da Conta      |       Nome    |       CPF");
        for (int i = 0; i < clientes.Count; i++){
                Console.WriteLine(clientes[i].ResumoCliente());
        }
}

void CriarConta(){
        Cliente cliente = new Cliente() ;
        Console.WriteLine("Data de Nascimento do Cliente: ");
        cliente.DataNascimento = DateTime.Parse(Console.ReadLine());   
        if(!cliente.EhMaior()){
                Console.WriteLine("Não é possível abrir a conta pois o cliente é menor de idade.");
                return ;
        }
        Console.WriteLine("A idade do cliente é " + cliente.Idade);
        Console.WriteLine("Nome do Cliente: ");
        cliente.Nome = Console.ReadLine();
        Console.WriteLine("CPF do Cliente: ");
        cliente.CPF = Console.ReadLine();    
        Console.WriteLine("Endereço do Cliente: ");
        cliente.Endereco = Console.ReadLine();             
        Console.WriteLine("Telefone do Cliente: ");
        cliente.Telefone = Console.ReadLine();  
        Console.WriteLine("Email do Cliente: ");
        cliente.Email = Console.ReadLine();  
        Console.WriteLine("Número da conta: ");
        cliente.NumeroConta = int.Parse(Console.ReadLine()); 
        clientes.Add(cliente);
}