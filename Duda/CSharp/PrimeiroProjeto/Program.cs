// See https://aka.ms/new-console-template for more information
using System;

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta_da_barbara = new ContaCorrente ("Barbara", 12345, 789, 10);    // variável do tipo conta corrente 
            
            Console.WriteLine ("A conta é do(a) " + conta_da_barbara.Titular + ", a agência é "
             + conta_da_barbara.Agencia + " e o número é " + conta_da_barbara.Numero + ".");
// ____________________________________________________________________________________________________
            ContaCorrente conta_da_mariana = new ContaCorrente ("Mariana", 12345, 224, 21);    // variável do tipo conta corrente 
        
            Console.WriteLine ("A conta é do(a) " + conta_da_mariana.Titular + ", a agência é "
             + conta_da_mariana.Agencia + " e o número é " + conta_da_mariana.Numero + ".");
//____________________________________________________________________________________________________
            ContaCorrente conta_da_sanches = new ContaCorrente ("Sanches", 12345, 668, 26);    // variável do tipo conta corrente 

            Console.WriteLine ("A conta é do(a) " + conta_da_sanches.Titular + ", a agência é "
             + conta_da_sanches.Agencia + " e o número é " + conta_da_sanches.Numero + ".");

        }
    }    
}
