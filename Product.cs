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

        // 팩토리 메서드 패턴
        public static Product getInstance(string name, int price)
        {
            return new Product(name, price);
        }
        private Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
