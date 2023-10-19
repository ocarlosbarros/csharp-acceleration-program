using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    public class Database
    {
        public Product GetProduct(int productId)
        {
            Product product = new();
            return product;
        }

        public void Open(){
            //nothing
        }

        public void Close(){
            //nothing
        }
    }
}