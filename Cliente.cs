using Internal;
using System;

namespace ProjetoBanco
{
      public abstract class Cliente 
    {
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public int NumeroConta { get; set; }
        public string TipoConta { get; set; }
        public double Saldo {  get {return GetSaldo(); }  private set{} }
        
        public List<Transacao> Extrato { get; set; }

        public Cliente()
        {
            Extrato = new List<Transacao>();
        }
        public Cliente(string email, string telefone, string end,int numeroConta, string tipoConta) :this()
        {
            Email= email;
            Telefone =telefone; 
            Endereco = end;
            NumeroConta = numeroConta;
            TipoConta = tipoConta;
        }
        public virtual void ResumoCliente(){ //metodo sob
           Console.WriteLine($"{NumeroConta}  | {TipoConta} |  {Saldo}  ");
        }

        private double GetSaldo(){
            double saldo = 0;
            foreach(Transacao transacao  in Extrato){
                saldo += transacao.Valor;
            }
            return saldo;
        }
    }
}