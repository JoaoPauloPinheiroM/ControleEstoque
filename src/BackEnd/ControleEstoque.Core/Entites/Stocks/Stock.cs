using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Core.Entites.Stocks
{
    public class Stock
    {
        Guid ID { get; set; }
        string Name { get; set; } = string.Empty;
        string Description { get; set; } = string.Empty;
        bool Status { get; set; }
    }
}
