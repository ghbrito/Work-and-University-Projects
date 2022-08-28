using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(3040,082442),
                null,
                new ContaCorrente(1529,8711),
                new ContaCorrente(1233,998877),
                new ContaCorrente(3040,203444),
                null,
                new ContaCorrente(3040,8711),
                new ContaCorrente(0482,8711),
                new ContaCorrente(1233,9977),
                null,
                new ContaCorrente(3040,203444)
            };

            //Utilizando o método Where com a expressão lambda para selecionar apenas contas não nulas
            //var contasNaoNulas = contas.Where(conta => conta != null);

            //var contasOrdenadas = contasNaoNulas.OrderBy(conta => conta.Numero);

            //Simplificando o código >>>>
            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            //Métodos como Where e OrderBy, entre outros tantos, fazem parte da biblioteca Linq do .NET

            Console.WriteLine("Usando agora o método ''OrderBy'' para ordenar\n");

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, agência {conta.Agencia}");
            }

            Console.ReadLine();
        }

        static void TestaMetodosDeOrdenacao()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(3040,082442),
                new ContaCorrente(1529,8711),
                new ContaCorrente(1233,998877),
                new ContaCorrente(3040,203444),
                new ContaCorrente(3040,8711),
                new ContaCorrente(0482,8711),
                new ContaCorrente(1233,9977),
                new ContaCorrente(3040,203444)
            };

            Console.WriteLine("Usando agora o método ''OrderBy'' para ordenar\n");


            //Expandindo a expressão lambda
            IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(conta =>
            {
                if (conta == null)
                {
                    return int.MaxValue;
                }
                return conta.Numero;
            });

            //IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(conta => conta.Numero);
            //OrderBy não altera a lista original, ele gera um retorno contendo os objetos da lista ordenados
            //pelo parâmetro definido na chamada

            foreach (var conta in contasOrdenadas)
            {
                //Console.WriteLine(conta);
                if (conta != null)
                {
                    Console.WriteLine($"Conta número {conta.Numero}, agência {conta.Agencia}");
                }
            }

            Console.WriteLine("\nUsando agora outro método para ordenar\n");

            contas.Sort();

            foreach (var conta in contas)
            {
                //Console.WriteLine(conta);
                Console.WriteLine($"Conta número {conta.Numero}, agência {conta.Agencia}");
            }

            Console.WriteLine("\nUsando agora outro método para ordenar\n");

            contas.Sort(new ComparadorDeContaCorrentePorAgencia());

            foreach (var conta in contas)
            {
                //Console.WriteLine(conta);
                Console.WriteLine($"Conta número {conta.Numero}, agência {conta.Agencia}");
            }

        }


        static void TestaSort()
        {
            var conta = new ContaCorrente(3040, 203444);
            var gerenciador = new GerenciadorBonificacao();
            var gerenciadores = new List<GerenciadorBonificacao>(); //Utilizado a palavra reservada VAR para simplificar a escrita e legibilidade do código,
            //o compilador pode inferir o tipo da variável somente quando ela é inicializada no momento em que é declarada

            var idades = new List<int>();

            idades.Add(32);
            idades.Add(654);
            idades.Add(1);
            idades.Add(65488);

            idades.Remove(32);

            idades.AddRange(new int[] { 784, 2, 699 });//Adicionando com o indexador

            //ListExtensoes.AdicionarVarios(idades, 3215, 6654, 8888, 2100);

            idades.AdicionarVarios(566665, 210000, 3, 6955);//usanto o método de extensão criado 


            idades.Sort();


            foreach (int i in idades)
            {
                Console.WriteLine(i);
            }

            List<string> nomes = new List<string>()
            {
                "Guilherme",
                "Lucas",
                "Bruno",
                "Carol"
            };

            nomes.AdicionarVarios("oloco", "testeeeeeeeee", "032226", "zaidan", "asdasda", "paula");



            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        static void TestaListaGenerica()
        {
            Lista<int> idades = new Lista<int>();//Argumento do tipo genérico utilizado na classe Lista, o tipo <int> foi definido agora

            idades.Adicionar(3);//Não aceita outros tipos além de INT no parâmetro pois o tipo foi definido na criação do objeto IDADES.
            idades.AdicionarVarios(6, 5, 321, 445, 6654, 2);

            for (int i = 0; i < idades.Tamanho; i++)
            {
                Console.WriteLine($"A idade contida no índice {i} é: {idades.GetItemNoIndice(i)}");
            }
            //lista.Adicionar(contaDoGui);


            //lista.Adicionar(new ContaCorrente(874, 5679787));
            //lista.Adicionar(new ContaCorrente(874, 5679754));
            //lista.Adicionar(new ContaCorrente(874, 5679445));




            //lista.Adicionar(new ContaCorrente(874, 5679445));
            //lista.Adicionar(new ContaCorrente(874, 5679445));
            //lista.Adicionar(new ContaCorrente(874, 5679445));
            //lista.Adicionar(new ContaCorrente(874, 5679445));
            //lista.Adicionar(new ContaCorrente(874, 5679445));
            //lista.Adicionar(new ContaCorrente(874, 5679445));
            //lista.Adicionar(new ContaCorrente(874, 5679445));
            //lista.Adicionar(new ContaCorrente(874, 5679445));







            //for (int i = 0; i < lista.Tamanho; i++)
            //{
            //    ContaCorrente contaAtual = lista.GetContaCorrenteNoIndice(i);
            //    Console.WriteLine($"Conta Corrente no índice {i} é a conta número {contaAtual.Numero}, agência {contaAtual.Agencia}");
            //}




            //lista.EscreverListaNaTela();


            //lista.Remover(contaDoGui);
            //Console.WriteLine("APÓS REMOVER CONTADOGUI");


            //lista.EscreverListaNaTela();

        }
        static void TestaParams()
        {
            Console.WriteLine("Soma: " + SomarVarios(33, 657, 20));


            //ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(111111, 1111111111);


            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 565422),
                new ContaCorrente(966, 77855522)
            };

            lista.AdicionarVarios(contas);
        }
        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(6);
            listaDeIdades.Adicionar(165);

            listaDeIdades.AdicionarVarios(654, 23, 9987);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no índice {i} é {listaDeIdades[i]}");
            }
        }

        static int SomarVarios(params int[] numeros) //utilizando PARAMS e FOREACH
        {
            int soma = 0;
            foreach (int numero in numeros)
            {
                soma += numero;
            }
            return soma;
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438)
                };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }

    }
}
