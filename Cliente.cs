using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class Cliente
    {
        public string Nome {get; set; }
        public string CPF {get; set; }
        public string Email {get; set; }
        public string Telefone {get; set; }
        public string Endereco {get; set; }
        public DateTime DataNascimento {get; set; }
        public int NumeroConta {get; set; }
        public double Saldo {get; set; }

        public int Idade { get {return (int) (Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365,25)); } set {}}
    

        //public List<Transacao> Extrato {get; set}

public string ResumoCliente(){
    return $"{NumeroConta}           |      {Nome}      |       {CPF}";
}

public bool EhMaior(){
    return Idade >=18;
}
}
}