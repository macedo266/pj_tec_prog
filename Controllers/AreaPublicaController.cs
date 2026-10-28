using Microsoft.AspNetCore.Mvc;
using Projeto_do_semestre.Dao;
using Projeto_do_semestre.Models;

namespace Projeto_do_semestre.Controllers
{
    public class AreaPublicaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult VeiculosImportados()
        {
            return View();
        }

        public IActionResult VeiculosNacionais()
        {

            Carro c1 = new Carro();
            c1.Nome = "BMW";
            c1.Descricao = "Sedã esportivo, blabla";
            c1.Ano = 2018;
            c1.Quilometragem = 18000;
            c1.Cambio = "Automatico";
            c1.Preco = 210000;

            Carro c2 = new Carro();
            c2.Nome = "Audio";
            c2.Descricao = "Hatch blabla";
            c2.Ano = 2015;
            c2.Quilometragem = 200000;
            c2.Cambio = "Manual";
            c2.Preco = 150700;

            Carro c3 = new Carro();
            c3.Nome = "Fusca";
            c3.Descricao = "Hatch blabla";
            c3.Ano = 2020;
            c3.Quilometragem = 45683;
            c3.Cambio = "Manual";
            c3.Preco = 15000;

            List<Carro> listaCarros = new List<Carro>();
            listaCarros.Add(c1);
            listaCarros.Add(c2);
            listaCarros.Add(c3);

            CarroDao dao = new CarroDao();
            listaCarros = dao.ListarCarros();

            return View(listaCarros);
        }


    }
}
