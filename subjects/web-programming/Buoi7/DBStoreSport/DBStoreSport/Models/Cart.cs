using DBStoreSport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBStoreSport.Models
{
    public class CartItem
    {
        // Khai báo một mục sản phẩm mua CartItem
        public Product _product { get; set; }
        public int _quantity { get; set; }
    }
    // Giỏ hàng (Cart) gồm tập hợp các mục sản phẫm (CartItem) được chọn
    public class Cart
    {
        // Dùng cấu trúc List để lưu trữ giỏ hàng (Items)  xem như là một bảng tạm
        List<CartItem> items = new List<CartItem>();
        public IEnumerable<CartItem> Items
        {
            get { return items; }
        }
        // Phương thức lấy sản phẩm bỏ vào giỏ hàng,
        // Tham số là Product(_pro) sản phẫm được chọn và số lượng(_qua)
        public void Add_Product_Cart(Product _pro, int _quan = 1)
        {
            // item : sản phẫm có mã = _pro.ProductID
            var item = Items.FirstOrDefault(s => s._product.ProductID == _pro.ProductID);
            // Nếu sp chưa có trong giỏ hàng  ghi sản phẫm và số lượng vào items(giỏ hàng)
            if (item == null)
                items.Add(new CartItem { _product = _pro, _quantity = _quan });
            // Ngược lại, sp đã chọn rồi  tăng số lượng lên 1 (_quan = 1)
            else
                item._quantity += _quan;
        }
        // Phương thức tính tổng số lượng trong giỏ hàng
        public int Total_quantity()
        {
            return items.Sum(s => s._quantity);
        }
        // Hàm tính thành tiền cho mỗi sản phẩm trong giỏ hàng
        public decimal Total_money()
        {
            var total = items.Sum(s => s._quantity * s._product.Price);
            return (decimal)total;
        }
        // Phương thức cập nhật số lượng khi khách hàng nhập số lượng SP mua thêm
        public void Update_quantity(int id, int _new_quan)
        {
            var item = items.Find(s => s._product.ProductID == id);
            if (item != null)
                item._quantity = _new_quan;
        }
        // Phương thức xóa sản phẩm trong giỏ hàng
        public void Remove_CartItem(int id)
        {
            items.RemoveAll(s => s._product.ProductID == id);
        }
        // Phương thức xóa giỏ hàng (sau khi khách hàng thanh toán xong đơn hàng)
        public void ClearCart()
        {
            items.Clear();
        }
    }
}
