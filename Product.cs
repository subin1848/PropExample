using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Product
    {
        public string name;
        public int price;
        public static Product product;

        // 팩토리 메서드 패턴 + 싱글톤 패턴
        public static Product getInstance(string name, int price)
        {
            if(product == null)
            {
                product = new Product(name, price);
            }
            return product;
        }
        private Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
