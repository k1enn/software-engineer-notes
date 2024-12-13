using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest1
{
    internal class BinarySearchTree
    {
        private TreeNode root;

        // Các hàm kiểm tra
        private bool isEmpty(TreeNode node) => node == null;
        private bool isEmpty(Product product) => product == null;
        private bool isEmpty(int? id) => id < 0 || id == null;

        /* 1. Thêm mặt hàng mới: Nhập vào thông tin một mặt hàng và chèn vào cây nhị phân
         tìm kiếm với khóa là mã số của mặt hàng (nếu đã tồn tại mã số không thêm vào).*/
        public bool Insert(Product product)
        {
            if (isEmpty(product))
                return false;
            root = Insert(root, product);
            return true;
        }
        private TreeNode Insert(TreeNode node, Product product)
        {
            if (isEmpty(node)) 
                return new TreeNode(product);
            if (product.Id < node.Product.Id)
                node.Left = Insert(node.Left, product);
            else if (product.Id > node.Product.Id)
                node.Right = Insert(node.Right, product);
            else
                Console.WriteLine($"Sản phẩn mới mã số {product.Id} đã tồn tại. Bỏ qua...");
            return node;
        }

        /* 2. Tìm kiếm từ: Nhập vào một mã số mặt hàng cần tìm kiếm
         và in ra thông tin của mặt hàng này (nếu có).*/
        public Product? Search(int id)
        {
            if (isEmpty(id)) return null;
            return Search(root, id);
        }
        private Product? Search(TreeNode node, int id)
        {
            if (isEmpty(node)) return null;
            if (id == node.Product.Id)
                return node.Product;
            else if (id < node.Product.Id)
                return Search(node.Left, id);
            else 
                return Search(node.Right, id);
        }


        public SingleLinkedList ConvertToLinkedListDescending()
        {
            if (isEmpty(root)) 
                return null;
            SingleLinkedList list = new SingleLinkedList();
            ConvertToLinkedListDescending(root, list);
            return list;
        }

        private void ConvertToLinkedListDescending(TreeNode node, SingleLinkedList list)
        {
            if (node == null) return;
            ConvertToLinkedListDescending(node.Right, list); // Đi từ phải sang trái cho thứ tự giảm dần
            list.AddFirst(node.Product);
            ConvertToLinkedListDescending(node.Left, list);
        }

    }
}
