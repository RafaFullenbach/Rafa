using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroClientes.Models;
using Microsoft.AspNetCore.Mvc;
using CadastroClientes.Repository;

namespace CadastroClientes.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteRepository clienteRepository;

        public ClienteController()
        {
            clienteRepository = new ClienteRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaCliente = clienteRepository.Listar();
            return View(listaCliente);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View(new Cliente());
        }

        [HttpPost]
        public ActionResult Cadastrar(Models.Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                clienteRepository.Inserir(cliente);
                @TempData["mensagem"] = "Cliente cadastrado com sucesso!";
                return RedirectToAction("Index", "Cliente");
            }
            else
            {
                return View(cliente);
            }
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var cliente = clienteRepository.Consultar(id);
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Editar(Models.Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                clienteRepository.Alterar(cliente);
                @TempData["mensagem"] = "Cliente alterado com sucesso!";
                return RedirectToAction("Index", "Cliente");
            }
            else
            {
                return View(cliente);
            }
        }

        [HttpGet]
        public ActionResult Consultar(int id)
        {
            var cliente = clienteRepository.Consultar(id);
            return View(cliente);
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            clienteRepository.Excluir(id);
            @TempData["mensagem"] = "Cliente removido com sucesso!";
            return RedirectToAction("Index", "Cliente");
        }

        [HttpGet]
        public ActionResult Filtro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Filtro(String select, String input)
        {
            var result = select + input;
            return RedirectToAction("Filtrado", new { select, input });
        }

        [HttpGet]
        public ActionResult Filtrado(String select, String input)
        {
            var listaCliente = clienteRepository.Filtrar(select, input);
            return View(listaCliente);
        }
    }
}
