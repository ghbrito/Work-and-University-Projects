using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    // [item][item][item][item][item]
    //                                ^
    //                                 `- _proximaPosicao


    public class ListaDeObject
    {
        private object[] _itens;
        private int _proximaPosicao;

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }
        public ListaDeObject(int capacidadeInicial = 5)
        {
            _itens = new object[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void MeuMetodo(string texto = "texti padrao", int numero = 5)
        {

        }

        public void Adicionar(object item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void AdicionarVarios(params object[] itens)//Com o PARAMS é possível chamar o método utilizando um ou vários argumentos, não sendo necessário
                                                                 //escrever uma sobrecarga para cada quantidade de argumentos. O PARAMS cria um array com todos os argumentos passados para então utilizar no método
        {
            //for (int i = 0; i < itens.Length; i++)
            //{
            //    Adicionar(itens[i]);
            //}

            //Utilizando agora o "foreach"
            foreach (object item in itens)
            {
                Adicionar(item);
            }
        }

        public void Remover(object item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                if (_itens[i].Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        //public void EscreverListaNaTela()
        //{
        //    for(int i = 0; i < _proximaPosicao; i++)
        //    {
        //        ContaCorrente conta = _itens[i];
        //        Console.WriteLine($"Conta no índice {i} é a conta número {conta.Numero}, agência {conta.Agencia}");
        //    }
        //}

        public object GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }


        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            //Console.WriteLine("Aumentando capacidade da lista!");

            object[] novoArray = new object[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                //Console.WriteLine(".");
            }

            _itens = novoArray;
        }

        public object this[int indice]//Indexador, acesso por meio de índices
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }


    }
}
