using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
            //teste.MetodoPrivado(); Não é permitido pois somente a própria classe pode acessar o método que é privado
            //teste.MetodoProtegido(); Não é permitido pois somente a própria classe e derivados podem acessar o método que é protegido
        }
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            ClasseDerivada teste = new ClasseDerivada();
            teste.MetodoPublico();//OK, publico é acessado por qualquer classe
            //teste.MetodoPrivado();// Não é permitido pois somente a própria classe pode acessar o método que é privado
            teste.MetodoProtegido();//OK , é acessível pois o método é PROTEGIDO e pode ser acessado por uma classe derivada
        }
    }
    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            //Visível fora da classe "Modificadores Teste"
        }
        private void MetodoPrivado()
        {
            //Visível SOMENTE na classe "Modificadores Teste"
        }
        protected void MetodoProtegido()
        {
            //Visível APENAS NA CLASSE "Modificadores Teste" e em seus DERIVADOS (HERANÇA)
        }
        internal void MetodoInterno()
        {
            //Visível apenas para o mesmo projeto, fora do projeto ele tem o mesmo comportamento de um método privado
        }
    }
}
