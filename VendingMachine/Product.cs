using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Product
    {
        private string productName;
        private int productPrice;
        private int productStock;
        private int productNumber;

        #region GettersAndSetters
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }
        public int ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                productPrice = value;
            }
        }
        public int ProductStock
        {
            get
            {
                return productStock;
            }
            set
            {
                productStock = value;
            }
        }
        public int ProductNumber
        {
            get
            {
                return productNumber;
            }
            set
            {
                productNumber = value;
            }
        }
        #endregion

        public Product(string productName, int productPrice, int productStock, int productNumber)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productStock = productStock;
            this.productNumber = productNumber;
        }
    }
}
