//using _02_ByteBank; //declara que está usando as classes definidas no namespace do bytebank


namespace _04_ByteBank
{

    class ContaCorrente
    {
        //private Cliente _titular;
        //private int agencia; substituidos pelo public XXX { get; set; }
        //private int numero;

      



        private double _saldo = 100;
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public Cliente Titular { get; set; } //Fazendo dessa forma para usar o GET e SET já que não há nenhum critério para definir ou retornar 'Cliente'
        /*{
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }


        }*/

        public static int TotalDeContasCriadas { get; private set; }


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }

        }




        /*
        public void SetSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }


            this.saldo = saldo;


        }

        public double GetSaldo()
        {
            return this.saldo;
        }
        */



        public bool Sacar(double valor) //bool define que esta função obrigatoriamente tem que retornar um valor booleano
        {

            if (valor > this._saldo)
            {

                return false;
            }

            this._saldo -= valor;

            return true;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;


        }

        public string Transferir(double valor, ContaCorrente destino)
        {
            if (this._saldo < valor)
            {
                return ("Erro ! \nSaldo insuficiente.");
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return ("Transferência efetuada ! Foi transferido o valor R$" + valor + " da conta de " + this.Titular.Nome + " para a conta de " + destino.Titular.Nome);
            }
        }


    }
}