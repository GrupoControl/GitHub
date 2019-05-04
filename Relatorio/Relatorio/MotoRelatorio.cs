using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio
{
    class MotoRelatorio
    {
        private string tipoPartida;
        private string tipoAlimentacao;
        private string tipoRefrigeracao;
        private string tipoMotor;
        private string tipoFreio;
        private string corPrincipal;
        private string corSecundaria;
        private int qtdMarchas;

        public int QtdMarchas
        {
            get { return qtdMarchas; }
            set { qtdMarchas = value; }
        }
        public string CorSecundaria
        {
            get { return corSecundaria; }
            set { corSecundaria = value; }
        }
        public string CorPrincipal
        {
            get { return corPrincipal; }
            set { corPrincipal = value; }
        }
        public string TipoFreio
        {
            get { return tipoFreio; }
            set { tipoFreio = value; }
        }
        public string TipoMotor
        {
            get { return tipoMotor; }
            set { tipoMotor = value; }
        }
        public string TipoRefrigeracao
        {
            get { return tipoRefrigeracao; }
            set { tipoRefrigeracao = value; }
        }
        public string TipoAlimentacao
        {
            get { return tipoAlimentacao; }
            set { tipoAlimentacao = value; }
        }
        public string TipoPartida
        {
            get { return tipoPartida; }
            set { tipoPartida = value; }
        }
    }
}
