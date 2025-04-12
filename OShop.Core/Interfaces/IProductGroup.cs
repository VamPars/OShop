using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OShop.Core.Interfaces
{
    public interface IProductGroup
    {
        bool CreatProductGroup(IProductGroup productGroup);
        bool UpdateProductGroup(IProductGroup productGroup);
        IEnumerable<IProductGroup> GetProductGroups();
        IProductGroup GetProductGroup(int productId);
        bool DeleteProductGroup(IProductGroup productGroup);


} }

