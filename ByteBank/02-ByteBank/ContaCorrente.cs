using _02_ByteBank; //declara que está usando as classes definidas no namespace do bytebank


namespace _02_ByteBank
{

    class ContaCorrente
    {
        public Cliente titular;
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

        public void Depositar(double valor)
        {
            this.saldo += valor;


        }

        public string Transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
            {
                return ("Erro ! \nSaldo insuficiente.");
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return ("Transferência efetuada ! Foi transferido o valor R$" + valor + " da conta de " + this.titular.nome + " para a conta de " + destino.titular.nome);
            }
        }


    }
}