using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public override bool Equals(Object obj) // sobrescrever o método Equals da classe object para que ela faça a comparação de todas as propriedades do cliente e não apenas comparar o endereço da referência para o objeto
        {
            //Cliente outroCliente = (Cliente)obj;//Casting , Conversão explícita do tipo object para o tipo Cliente
            //O cast feito da primeira maneira lança uma exceção dizendo que a conversão é impossível de ser feita quando o objeto é de um tipo diferente
            //O cast feito da segunda maneira não lança exceção, apenas retornar o Valor null para o objeto
            Cliente outroCliente = obj as Cliente;//Conversão feita de outra forma. Assim, se o objeto recebido for de um tipo diferente do tipo Cliente, o resultado atríbuído vai ser 'null'
            //Assim será possível verificar o valor recebido para verificar se o tipo é diferente.
            if (outroCliente == null) return false;
            
            return Nome == outroCliente.Nome
                && CPF == outroCliente.CPF
                && Profissao == outroCliente.Profissao;


        }
    }
}
