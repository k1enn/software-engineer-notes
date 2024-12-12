using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest3
{
    internal class BinarySearchTree
    {
        private TreeNode root;

        // Các hàm kiểm tra
        private bool isEmpty(TreeNode node) => node == null;
        private bool isEmpty(Major major) => major == null;
        private bool isEmpty(int? id) => id < 0 || id == null;

        /* 1. Thêm một khoa mới: Nhập vào thông tin một khoa và chèn vào cây nhị phân tìm kiếm 
        với khóa là mã số của khoa (nếu đã tồn tại mã số không thêm vào).*/
        public bool Insert(Major major)
        {
            if (isEmpty(major))
                return false;
            root = Insert(root, major);
            return true;
        }
        private TreeNode Insert(TreeNode node, Major major)
        {
            if (isEmpty(node)) 
                return new TreeNode(major);
            if (major.Id < node.Major.Id)
                node.Left = Insert(node.Left, major);
            else if (major.Id > node.Major.Id)
                node.Right = Insert(node.Right, major);
            else
                Console.WriteLine($"Sản phẩn mới mã số {major.Id} đã tồn tại. Bỏ qua...");
            return node;
        }

        /*2. Đếm số lượng khoa được thành lập vào 1 năm nào đó: Nhập vào một năm x cần đếm và 
        đếm có bao nhiêu khoa được thành lập vào năm x (nếu có)*/
        public Major? Search(int year)
        {
            if (isEmpty(year)) return null;
            return Search(root, year);
        }
        private Major? Search(TreeNode node, int year)
        {
            if (isEmpty(node)) return null;
            if (year == node.Major.Year)
                return node.Major;
            else if (year < node.Major.Year)
                return Search(node.Left, year);
            else 
                return Search(node.Right, year);
        }

         /*3. uyệt cây theo thứ tự LNR và lưu tất cả các khoa 
         trong cây nhị phân tìm kiếm vào danh sách liên kết đơn theo dạng hàng đợi */
        public void InOrderTraversalAndEnqueue(Queue queue)
        {
            InOrderTraversal(root, queue);
        }

        private void InOrderTraversal(TreeNode node, Queue queue)
        {
            if (isEmpty(node)) return;
            
            // Left subtree
            InOrderTraversal(node.Left, queue);
            
            // Visit node (enqueue product)
            queue.Enqueue(node.Major);
            
            // Right subtree
            InOrderTraversal(node.Right, queue);
        }
        

    }
}
