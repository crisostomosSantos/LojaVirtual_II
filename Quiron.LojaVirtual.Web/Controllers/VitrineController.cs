using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;

        public int ProdutosPorPagina = 5; 
        // GET: Vitrine
        public ActionResult ListaProdutos( int pagina = 1)
        {

             _repositorio = new ProdutosRepositorio();
             var produtos = _repositorio.Produto
                 .OrderBy(p => p.Descricao)
            .Skip((pagina - 1) * ProdutosPorPagina)
            .Take(ProdutosPorPagina);
       
        return View(produtos);
        }
    }
}