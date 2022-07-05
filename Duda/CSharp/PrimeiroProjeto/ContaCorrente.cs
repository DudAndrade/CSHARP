public class ContaCorrente     //classe pública 
{
    public string Titular; // esses são os atributos, ou seja, características da classe
    public int Agencia;
    public int Numero;
    public double Saldo;
    public ContaCorrente (string Titular, int Agencia, int Numero, double Saldo) // declarando o construtor  SEMPRE DENTRO DA CLASSE
    { 
        this.Titular = Titular; // representa tal característica da classe
        this.Agencia = Agencia; 
        this.Numero = Numero;
        this.Saldo = Saldo; 
     }

     public bool Sacar(double valorSaque){ // - bool(true ou false) - aqui está sendo declarado o método, ele sempre tem o tipo de retorno declarado
        if (this.Saldo >= valorSaque){
            this.Saldo = this.Saldo - valorSaque;
            return true;
        }
        return false;
     }
}
   

    
