using System;

namespace DIO.bank
{
    public class Conta
    {
        private TipoConta tipoConta {get; set;}
        private string nome {get; set;}
        private double saldo {get; set;}
        private double credito {get; set;}
        
        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.tipoConta = tipoConta;
            this.saldo = saldo;
            this.credito = credito;
            this.nome = nome;
        }

        public bool sacar(double valorSaque)
        {
            if (this.saldo - valorSaque < (this.credito *-1))
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            this.saldo -= valorSaque;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.nome, this.saldo);

            return true;
        }

        public void depositar(double valorDeposito)
        {
            this.saldo += valorDeposito;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.nome, this.saldo);

        }

        public void transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.sacar(valorTransferencia))     
            {
                contaDestino.depositar(valorTransferencia);
            }
        }

    public override string ToString()
    {
        string retorno = "";

        retorno += "TipoConta :: " +this.tipoConta +" | ";
        retorno += "Nome :: " +this.nome +" | ";
        retorno += "Saldo :: " +this.saldo +" | ";
        retorno += "Credito :: " +this.credito;

        return retorno;
    }



    }
}