using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class AutomatLogic
    {
        AutomatData productData = new AutomatData();
       
        public List<Product> GetProductData()
        {

            return productData.Products();
        }

    }
}
