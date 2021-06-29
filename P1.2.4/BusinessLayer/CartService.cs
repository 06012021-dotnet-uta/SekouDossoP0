using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CartService : ICart
    {
        // first define the context 
        private readonly P1Db _context;
        // create a constructor
        public CartService(P1Db context) { this._context = context; }
    }
}
