using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoes //classe criada apenas para adicionar extensões à classe List do .NET
    {
        //utilizando o recurso do C# método de extensão
        //basta criar um método estático em uma classe estática, com o primeiro argumento do método estático sendo do tipo do qual queremos extender
        //public static void AdicionarVarios(this List<int> listaDeInteiros, params int[] itens)
        //{
        //    foreach(int item  in itens)
        //    {
        //        listaDeInteiros.Add(item);
        //    }
        //}

        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)//Método  de estensão genérico
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }


    }
}
