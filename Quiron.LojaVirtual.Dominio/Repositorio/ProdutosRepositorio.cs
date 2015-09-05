using Quiron.LojaVirtual.Dominio.Entidade;
using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
         private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Produto>  Produto
        {
            get { return _context.Produtos; }
        }
    }
}
