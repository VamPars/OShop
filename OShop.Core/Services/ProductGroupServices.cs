using OShop.Core.Interfaces;
using OShop.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OShop.Core.Services
{
    internal class ProductGroupServices : IProductGroup
    {
        private readonly OShopContext _context;
        public ProductGroupServices(OShopContext _context)
        {
            _context = _context;
        }
        public bool CreatProductGroup(IProductGroup productGroup)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); 
                return false;

            }
        }

        public bool DeleteProductGroup(IProductGroup productGroup)
        {
            throw new NotImplementedException();
        }

        public IProductGroup GetProductGroup(int productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProductGroup> GetProductGroups()
        {
            throw new NotImplementedException();
        }

        public bool UpdateProductGroup(IProductGroup productGroup)
        {
            throw new NotImplementedException();
        }
    }
}
