using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio
{
    public class CarroRelatorio
    {
        private string cambio;
        private string versao;
        private bool blindado;
        private string cor;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public bool Blindado
        {
            get { return blindado; }
            set { blindado = value; }
        }
        public string Versao
        {
            get { return versao; }
            set { versao = value; }
        }
        public string Cambio
        {
            get { return cambio; }
            set { cambio = value; }
        }
    }
}
