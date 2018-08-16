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
            listaVeiculos.Where(v => v.Codigo == veiculo.Codigo).Select(s => {
                s.Codigo = veiculo.Codigo;
                s.Fabricante = veiculo.Fabricante;
                return s;
            }).ToList();
            return "Veículo alterado com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirVeiculo/{codigo}")]
        public string ExcluirVeiculo(int codigo) {
            Veiculo veiculo = listaVeiculos.Where(v => v.Codigo == codigo)
                .Select(v => v)
                .First();
            listaVeiculos.Remove(veiculo);
            return "Veículo excluido com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarVeiculos")]
        public List<Veiculo> ListarVeiculos() {
            listaVeiculos = new List<Veiculo>()
            { new Veiculo() { Codigo = 1, Placa = "BMW-2558", Frota = "CCV", Propriedade = true , TipoVeiculo = "Automóvel", TipoCarroceria = "Pick-Up",
                Fabricante = "Fiat", Modelo = "Uno", AnoFabricacao = 2016, AnoModelo = 2017, Pais = "Brasil", Cidade= "Curitiba", Tara = 8500, CapacidadeDeCarga = 15000, Altura = 165,
            Largura = 154, Comprimento = 300, Motorista = "Katia", Proprietario = "Lineu" },
            new Veiculo() { Codigo = 2, Placa = "BMW-2558", Frota = "CCV", Propriedade = true , TipoVeiculo = "Automóvel", TipoCarroceria = "Pick-Up",
                Fabricante = "Fiat", Modelo = "Uno", AnoFabricacao = 2016, AnoModelo = 2017, Pais = "Brasil", Cidade= "Curitiba",Tara = 8500, CapacidadeDeCarga = 15000, Altura = 165,
            Largura = 154, Comprimento = 300, Motorista = "Katia", Proprietario = "Lineu" },
            new Veiculo() { Codigo = 3, Placa = "BMW-2558", Frota = "CCV", Propriedade = true , TipoVeiculo = "Automóvel", TipoCarroceria = "Pick-Up",
                Fabricante = "Fiat", Modelo = "Uno", AnoFabricacao = 2016, AnoModelo = 2017, Pais = "Brasil", Cidade= "Curitiba", Tara = 8500, CapacidadeDeCarga = 15000, Altura = 165,
            Largura = 154, Comprimento = 300, Motorista = "Katia", Proprietario = "Lineu" },
            new Veiculo() { Codigo = 4, Placa = "BMW-2558", Frota = "CCV", Propriedade = true , TipoVeiculo = "Automóvel", TipoCarroceria = "Pick-Up",
                Fabricante = "Fiat", Modelo = "Uno", AnoFabricacao = 2016, AnoModelo = 2017, Pais = "Brasil", Cidade= "Curitiba", Tara = 8500, CapacidadeDeCarga = 15000, Altura = 165,
            Largura = 154, Comprimento = 300, Motorista = "Katia", Proprietario = "Lineu" },
            new Veiculo() { Codigo = 4, Placa = "BMW-2558", Frota = "CCV", Propriedade = true , TipoVeiculo = "Automóvel", TipoCarroceria = "Pick-Up",
                Fabricante = "Fiat", Modelo = "Uno", AnoFabricacao = 2016, AnoModelo = 2017, Pais = "Brasil", Cidade= "Curitiba", Tara = 8500, CapacidadeDeCarga = 15000, Altura = 165,
            Largura = 154, Comprimento = 300, Motorista = "Katia", Proprietario = "Lineu" }
            };
            return listaVeiculos;
        }

    }
}
