using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadores
{
    internal class ComparadorDeContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == y)//Se os dois forem nulos ou se forem iguais, o retorno é o mesmo
            {
                return 0;
            }
            if ( x == null )
            {
                return 1;
            }
            if ( y == null )
            {
                return -1;
            }

            return x.Agencia.CompareTo(y.Agencia);

        }
    }
}
