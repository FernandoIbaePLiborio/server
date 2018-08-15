using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers {

    [RoutePrefix("api/veiculo")]
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
            return listaVeiculos;
        }

    }
}
