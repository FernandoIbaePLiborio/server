using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models {
    public class Veiculo {
        private int _codigo;
        private string _placa;
        private string _frota;
        private Boolean _propriedade;
        private string _tipoVeiculo;
        private string _tipoCarroceria;
        private string _fabricante;
        private string _modelo;
        private int _anoFabricacao;
        private int _anoModelo;
        private string _pais;
        private string _cidade;
        private Decimal _tara;
        private Decimal _capacidadeCarga;
        private Decimal _altura;
        private Decimal _largura;
        private Decimal _comprimento;
        private string _motorista;
        private string _proprietario;

        public Veiculo() { }

        public Veiculo(int codigo, string placa, string frota, bool propriedade, string tipoVeiculo, string tipoCarroceria, string fabricante, string modelo, int anoFabricacao, int anoModelo, string pais, string cidade, decimal tara, decimal capacidadeCarga, decimal altura, decimal largura, decimal comprimento, string motorista, string proprietario) {
            _codigo = codigo;
            _placa = placa;
            _frota = frota;
            _propriedade = propriedade;
            _tipoVeiculo = tipoVeiculo;
            _tipoCarroceria = tipoCarroceria;
            _fabricante = fabricante;
            _modelo = modelo;
            _anoFabricacao = anoFabricacao;
            _anoModelo = anoModelo;
            _pais = pais;
            _cidade = cidade;
            _tara = tara;
            _capacidadeCarga = capacidadeCarga;
            _altura = altura;
            _largura = largura;
            _comprimento = comprimento;
            _motorista = motorista;
            _proprietario = proprietario;
        }

        public int codigo { get => _codigo; set => _codigo = value; }
        public string placa { get => _placa; set => _placa = value; }
        public string frota { get => _frota; set => _frota = value; }
        public bool propriedade { get => _propriedade; set => _propriedade = value; }
        public string tipoVeiculo { get => _tipoVeiculo; set => _tipoVeiculo = value; }
        public string tipoCarroceria { get => _tipoCarroceria; set => _tipoCarroceria = value; }
        public string fabricante { get => _fabricante; set => _fabricante = value; }
        public string modelo { get => _modelo; set => _modelo = value; }
        public int anoFabricacao { get => _anoFabricacao; set => _anoFabricacao = value; }
        public int anoModelo { get => _anoModelo; set => _anoModelo = value; }
        public string pais { get => _pais; set => _pais = value; }
        public string cidade { get => _cidade; set => _cidade = value; }
        public decimal tara { get => _tara; set => _tara = value; }
       
        public decimal altura { get => _altura; set => _altura = value; }
        public decimal largura { get => _largura; set => _largura = value; }
        public decimal comprimento { get => _comprimento; set => _comprimento = value; }
        public string motorista { get => _motorista; set => _motorista = value; }
        public string proprietario { get => _proprietario; set => _proprietario = value; }
        public decimal capacidadeCarga { get => _capacidadeCarga; set => _capacidadeCarga = value; }
    }

}