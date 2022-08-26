




class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool Sacar(double valor) //bool define que esta função obrigatoriamente tem que retornar um valor booleano
    {

        if (valor > this.saldo)
        {
            
            return false;
        }
        
        this.saldo -= valor;

        return true;
    }



}