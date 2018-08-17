using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers {

    [RoutePrefix("veiculo")]
    public class VeiculoController : ApiController {
        public static List<Veiculo> listaVeiculos = new List<Veiculo>();

        [AcceptVerbs("POST")]
        [Route("IncluirVeiculo")]
        public string IncluirVeiculo(Veiculo veiculo) {
            listaVeiculos.Add(veiculo);
            return "Cadastro realizado com sucesso!";
        }

        [AcceptVerbs("PUT")]
        [Route("AlterarVeiculo")]
        public string SalvarVeiculo(Veiculo veiculo) {
            listaVeiculos.Where(v => v.codigo == veiculo.codigo).Select(s => {
                s.codigo = veiculo.codigo;
                s.fabricante = veiculo.fabricante;
                return s;
            }).ToList();
            return "Veículo alterado com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirVeiculo/{codigo}")]
        public string ExcluirVeiculo(int codigo) {
            Veiculo veiculo = listaVeiculos.Where(v => v.codigo == codigo)
                .Select(v => v)
                .First();
            listaVeiculos.Remove(veiculo);
            return "Veículo excluido com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarVeiculos")]
        public List<Veiculo> ListarVeiculos() {
            listaVeiculos = new List<Veiculo>()
            { new Veiculo() { codigo = 1, placa = "BMW-2558", frota = "CCV", propriedade = true , tipoVeiculo = "Automóvel", tipoCarroceria = "Pick-Up",
                fabricante = "Fiat", modelo = "Uno", anoFabricacao = 2016, anoModelo = 2017, pais = "Brasil", cidade= "Curitiba", tara = 15000, capacidadeCarga = 15000, altura = 165,
            largura = 154, comprimento = 300, motorista = "Carolina Benato", proprietario = "Denise Fraga" },
            new Veiculo() { codigo = 2, placa = "SDF-3215", frota = "POLICIAL", propriedade = true , tipoVeiculo = "Automóvel", tipoCarroceria = "Sedan",
                fabricante = "Fiat", modelo = "Uno", anoFabricacao = 2016, anoModelo = 2017, pais = "Brasil", cidade= "Curitiba", tara = 500, capacidadeCarga = 15000, altura = 165,
            largura = 154, comprimento = 300, motorista = "Katia Holtz", proprietario = "Lineu Pereira" },
            new Veiculo() { codigo = 3, placa = "BSE-2558", frota = "CCV", propriedade = true , tipoVeiculo = "Automóvel", tipoCarroceria = "Perua",
                fabricante = "Fiat", modelo = "Uno", anoFabricacao = 2016, anoModelo = 2017, pais = "Brasil", cidade= "Curitiba", tara = 8500, capacidadeCarga = 15000, altura = 165,
            largura = 154, comprimento = 300, motorista = "Daniel Plitz", proprietario = "Amanda Virginea" },
            new Veiculo() { codigo = 4, placa = "ASD-3223", frota = "Treinamento", propriedade = true , tipoVeiculo = "Automóvel", tipoCarroceria = "Jipe",
                fabricante = "Fiat", modelo = "Uno", anoFabricacao = 2016, anoModelo = 2017, pais = "Brasil", cidade= "Curitiba", tara = 20000, capacidadeCarga = 15000, altura = 165,
            largura = 154, comprimento = 300, motorista = "Tennorio Gomes", proprietario = "Tatiane Vasconcellos" },
            new Veiculo() { codigo = 4, placa = "BXT-2154", frota = "Ford", propriedade = true , tipoVeiculo = "Automóvel", tipoCarroceria = "Hatch",
                fabricante = "Fiat", modelo = "Uno", anoFabricacao = 2016, anoModelo = 2017, pais = "Brasil", cidade= "Curitiba", tara = 8000, capacidadeCarga = 5000, altura = 170,
            largura = 154, comprimento = 300, motorista = "Ana Maltez", proprietario = "Marcelo Roberto" }
            };
            return listaVeiculos;
        }

        [AcceptVerbs("GET")]
        [Route("BuscarVeiculo/{codigo}")]
        public Veiculo BuscarVeiculo(int codigo) {
            Veiculo veiculo = listaVeiculos.Where(v => v.codigo == codigo)
                .Select(v => v)
                .First();
            return veiculo;
        }

    }
}
