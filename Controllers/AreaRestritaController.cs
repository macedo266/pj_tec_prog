using Microsoft.AspNetCore.Mvc;
using Projeto_do_semestre.Dao;
using Projeto_do_semestre.Models;

namespace Projeto_do_semestre.Controllers
{
    public class AreaRestritaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdmVeiculos()
        {
            return View();
        }

        public IActionResult SalvarBasico(string nome, string descricao, int ano, int quilometragem, string cambio, double preco)
        {

            return View("Dados salvos com sucesso");
        }

        public IActionResult SalvarModerno(Carro c)
        {
            CarroDao dao = new CarroDao();

            //dao.inserir(c);

            string msg = "Dados salvos:<br>";
            msg += "Carro     = " + c.Nome + "<br>";
            msg += "Descricao = " + c.Descricao + "<br>";

            return View(msg);
        }


        public IActionResult AdmVendas() {
            return View();
        }

    }
}
