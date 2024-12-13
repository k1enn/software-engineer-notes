using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest1
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        // Override ToString để in thông tin chi tiết sản phẩm
        public override string ToString()
        {
            return $"Mã số: {Id}\n Tên sản phẩm: {Name}\nĐơn giá: {Price}";
        }
    }
}
