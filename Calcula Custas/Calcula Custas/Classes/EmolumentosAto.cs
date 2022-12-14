using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula_Custas.Classes
{
    public class EmolumentosAto
    {

        public int codigo { get; set; }
        public float emolumentosBruto { get; set; }

        public float recompe { get; set; }
        public float issqn { get; set; }
        public float emolumentosLiq { get; set; }
        public float TFJ { get; set; }
        public float valorFinal { get; set; }

        public EmolumentosAto(int Codigo, float EmolumentosBruto, float Recompe, float Issqn, float EmolumentosLiq, float tfj, float ValorFinal)
        {
            this.codigo = Codigo;
            this.emolumentosBruto = EmolumentosBruto;
            this.recompe = Recompe;
            this.issqn = Issqn;
            this.emolumentosLiq = EmolumentosLiq;
            this.TFJ = tfj;
            this.valorFinal = ValorFinal;
        }

    }
}