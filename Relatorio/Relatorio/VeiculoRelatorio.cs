using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio
{
    public class VeiculoRelatorio
    {
        private string modelo;
        private string marca;
        private string cor;
        private string combustivel;
        private int ano;
        private double precoVeiculo;
        private double quilometragem;

        public double Quilometragem
        {
            get { return quilometragem; }
            set { quilometragem = value; }
        }
        public double PrecoVeiculo
        {
            get { return precoVeiculo; }
            set { precoVeiculo = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public string Combustivel
        {
            get { return combustivel; }
            set { combustivel = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
    }
}
