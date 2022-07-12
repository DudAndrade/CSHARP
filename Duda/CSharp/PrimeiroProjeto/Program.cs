// See https://aka.ms/new-console-template for more information
using System;

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta_da_barbara = new ContaCorrente ("Barbara", 12345, 789, 10);   // criando os objetos da classe
            ContaCorrente conta_da_mariana = new ContaCorrente ("Mariana", 12345, 224, 150);   
            ContaCorrente conta_do_sanches = new ContaCorrente ("Sanches", 12345, 668, 300);

            Console.WriteLine ("A conta é do(a) " + conta_da_barbara.Titular + ", a agência é "
             + conta_da_barbara.Agencia + " e o número é " + conta_da_barbara.Numero + ".");

            Console.WriteLine ("A conta é do(a) " + conta_da_mariana.Titular + ", a agência é "
             + conta_da_mariana.Agencia + " e o número é " + conta_da_mariana.Numero + ".");

            Console.WriteLine ("A conta é do(a) " + conta_do_sanches.Titular + ", a agência é "
             + conta_do_sanches.Agencia + " e o número é " + conta_do_sanches.Numero + ".");

             bool sacar_conta = conta_da_barbara.Sacar(100);
             bool sacar_conta1 = conta_da_mariana.Sacar(100);
             bool sacar_conta2 = conta_do_sanches.Sacar(100);

             Console.WriteLine ("A conta é do(a) " + conta_da_barbara.Titular + ", a agência é "
             + conta_da_barbara.Agencia + " e o número é " + conta_da_barbara.Numero + " Saldo " + conta_da_barbara.Saldo + ".");

            Console.WriteLine ("A conta é do(a) " + conta_da_mariana.Titular + ", a agência é "
             + conta_da_mariana.Agencia + " e o número é " + conta_da_mariana.Numero + " Saldo " + conta_da_mariana.Saldo + ".");

            Console.WriteLine ("A conta é do(a) " + conta_do_sanches.Titular + ", a agência é "
             + conta_do_sanches.Agencia + " e o número é " + conta_do_sanches.Numero + " Saldo " + conta_do_sanches.Saldo + ".");
        
             bool depositar_conta =  conta_da_barbara.Depositar(50);
             bool depositar_conta1 =  conta_da_mariana.Depositar(50);
             bool depositar_conta2 =  conta_do_sanches.Depositar(50);

            Console.WriteLine ("A conta é do(a) " + conta_da_barbara.Titular + ", a agência é "
             + conta_da_barbara.Agencia + " e o número é " + conta_da_barbara.Numero + " Saldo " + conta_da_barbara.Saldo + ".");

            Console.WriteLine ("A conta é do(a) " + conta_da_mariana.Titular + ", a agência é "
             + conta_da_mariana.Agencia + " e o número é " + conta_da_mariana.Numero + " Saldo " + conta_da_mariana.Saldo + ".");

            Console.WriteLine ("A conta é do(a) " + conta_do_sanches.Titular + ", a agência é "
             + conta_do_sanches.Agencia + " e o número é " + conta_do_sanches.Numero + " Saldo " + conta_do_sanches.Saldo + ".");
               
        }
    }    
}
