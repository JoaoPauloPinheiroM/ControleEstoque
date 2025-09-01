using ControleEstoque.Core.Entites.Products;
using ControleEstoque.Core.Entites.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Core.Entites.Stocks.Movement.Entries
{
    public class Entrie
    {
        public Guid ID { get; set; }
        public required double Quantity { get; set; }
        public required ProductStock Products { get; set; }
        public DateTime Date { get; set; }
        public required User User { get; set; }
        public required Stock Stock { get; set; }

    }
}
