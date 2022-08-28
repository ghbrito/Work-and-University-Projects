// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia { get; }//Dessa forma, sem o "set", é a mesma coisa que fazer uma propriedade READONLY, somente o construtor pode definir o valor dela
        //private readonly int _numero;//readonly faz com que a variável somente possa ser alterada pelo construtor da classe
        public int Numero { get; } //Dessa forma, sem o "set", é a mesma coisa que fazer uma propriedade READONLY, somente o construtor pode definir o valor dela

        private double _saldo = 100;

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


        public ContaCorrente(int agencia, int numero)
        {
            //Fazendo uma forma de lançar a exceção de forma que ela especifique qual argumento está errado sem fazer com que o método fique muito extenso

            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));//O operador nameof retorna uma string com o nome do argumento passado "agencia"
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }


            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;




            //try
            /*{
            TaxaOperacao = 30 / TotalDeContasCriadas;
            }
            catch(DivideByZeroException erro)
            {
                //Console.WriteLine("Não é possível fazer uma divisão por 0 !");
                Console.WriteLine(erro.Message);
                TaxaOperacao = 30;
            }
            
            TotalDeContasCriadas++;*/
        }



        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                //throw new ArgumentException("Foi feita uma tentativa de saque com valor inválido de " + valor);

                throw new ArgumentException("Foi feita uma tentativa de saque com valor inválido de " + valor, nameof(valor));
            }

            if (_saldo < valor)
            {
                //comentado para usar a exceção com um construtor novo
                //throw new SaldoInsuficienteException("Saldo insuficiente para o saque no valor de : R$" + valor);
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;

        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                //throw new ArgumentException("Foi feita uma tentativa de saque com valor inválido de " + valor);

                throw new ArgumentException("Valor inválido para transferência: " + valor, nameof(valor));
            }

            /*
            if (_saldo < valor)
            {
               
            }


            _saldo -= valor;
            foi utilizado o metodo Sacar pois ele já trata todas as exceções dos argumentos e saldo insuficiente, não havendo assim duplicidade de código
            */
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException e)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada!",e);//Exceção lançada utilizando uma nova classe específica
                //para esse tipo de exceção e utilizando innerException

                //throw new Exception("Operação não realizada!", e);//Usado o construtor com o argumento e para definir como innerException a exceção que foi lançada originalmente e
                //contém informações sigilosas que não queremos passar para o operador

                //throw;

                //se for feito desta forma, "throw e;" , o stacktrace vai ser resetado pela máquina virtual e somente vai mostrar o caminho até este throw,
                //ocultando assim a parte onde o erro iniciou em sacar
                //throw e;
            }

            contaDestino.Depositar(valor);
            Console.WriteLine("Foi transferido o valor de R$" + valor + " da conta " + this.Numero + " para a conta " + contaDestino.Numero);

        }
    }
}
