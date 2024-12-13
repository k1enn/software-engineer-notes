using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest3
{
    internal class Major
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Major(int id, string name, int year)
        {
            Id = id;
            Name = name;
            Year = year;
        }

        // Override ToString để in thông tin chi tiết sản phẩm
        public override string ToString()
        {
            return $"Mã số: {Id}\n Tên sản phẩm: {Name}\nNăm thành lập: {Year}";
        }
    }
}
