using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models {
    public class Veiculo {
        private int codigo;
        private string placa;
        private string frota;
        private Boolean propriedade;
        private string tipoVeiculo;
        private string tipoCarroceria;
        private string fabricante;
        private string modelo;
        private DateTime anoFabricacao;
        private DateTime anoModelo;
        private string pais;
        private string cidade;
        private Decimal tara;
        private Decimal capacidadeDeCarga;
        private Decimal altura;
        private Decimal largura;
        private Decimal comprimento;
        private string motorista;
        private string proprietario;

        public Veiculo() { }
        public Veiculo(int codigo, string placa, string frota, Boolean propriedade, string tipoVeiculo, string tipoCarroceria, string fabricante, string modelo, DateTime anoFabricacao, DateTime anoModelo,
            string pais, string cidade, Decimal tara, Decimal capacidadeDeCarga, Decimal altura, Decimal largura, Decimal comprimento, string motorista, string proprietario) {
            this.Codigo = codigo;
            this.Placa = placa;
            this.Frota = frota;
            this.Propriedade = propriedade;
            this.TipoVeiculo = tipoVeiculo;
            this.TipoCarroceria = tipoCarroceria;
            this.Fabricante = fabricante;
            this.Modelo = modelo;
            this.AnoFabricacao = anoFabricacao;
            this.AnoModelo = anoModelo;
            this.Pais = pais;
            this.Cidade = cidade;
            this.Tara = tara;
            this.CapacidadeDeCarga = capacidadeDeCarga;
            this.Altura = altura;
            this.Largura = largura;
            this.Comprimento = comprimento;
            this.Motorista = motorista;
            this.Proprietario = proprietario;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Frota { get => frota; set => frota = value; }
        public bool Propriedade { get => propriedade; set => propriedade = value; }
        public string TipoVeiculo { get => tipoVeiculo; set => tipoVeiculo = value; }
        public string TipoCarroceria { get => tipoCarroceria; set => tipoCarroceria = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public DateTime AnoFabricacao { get => anoFabricacao; set => anoFabricacao = value; }
        public DateTime AnoModelo { get => anoModelo; set => anoModelo = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public decimal Tara { get => tara; set => tara = value; }
        public decimal CapacidadeDeCarga { get => capacidadeDeCarga; set => capacidadeDeCarga = value; }
        public decimal Altura { get => altura; set => altura = value; }
        public decimal Largura { get => largura; set => largura = value; }
        public decimal Comprimento { get => comprimento; set => comprimento = value; }
        public string Motorista { get => motorista; set => motorista = value; }
        public string Proprietario { get => proprietario; set => proprietario = value; }
    }

}