
using FinalTest1;
static void Test()
{
    BinarySearchTree bst = new BinarySearchTree();
    int choice;

    do
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Thêm mặt hàng mới");
        Console.WriteLine("2. Tìm kiếm mặt hàng theo mã số");
        Console.WriteLine("3. Lưu danh sách mặt hàng vào danh sách liên kết đơn (giảm dần)");
        Console.WriteLine("4. Thoát");
        Console.Write("Nhập lựa chọn của bạn: ");
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
            continue;
        }

        switch (choice)
        {
            case 1: // Thêm mặt hàng mới
                while (true)
                {
                    Console.Write("Nhập mã số sản phẩm (-1 để thoát): ");
                    if (!int.TryParse(Console.ReadLine(), out int id) || id < -1)
                    {
                        Console.WriteLine("Mã số không hợp lệ. Vui lòng thử lại.");
                        continue;
                    }
                    if (id == -1) break; // Thoát nếu người dùng nhập -1

                    Console.Write("Nhập tên sản phẩm (-1 để thoát): ");
                    string? name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Tên sản phẩm không hợp lệ. Vui lòng thử lại.");
                        continue;
                    }
                    if (name == "-1") break; // Thoát nếu người dùng nhập -1

                    int price;
                    while (true)
                    {
                        Console.Write("Nhập đơn giá sản phẩm (-1 để thoát): ");
                        if (!int.TryParse(Console.ReadLine(), out price) || price < -1)
                        {
                            Console.WriteLine("Đơn giá không hợp lệ. Vui lòng thử lại.");
                            continue;
                        }
                        if (price == -1) break; // Thoát nếu người dùng nhập -1
                        if (price >= 0) break; // Thoát vòng lặp khi đơn giá hợp lệ
                        Console.WriteLine("Đơn giá phải là số không âm. Vui lòng thử lại.");
                    }
                    if (price == -1) break; // Thoát nếu người dùng nhập -1

                    // Tạo sản phẩm và thêm vào cây
                    Product product = new Product(id, name, price);
                    if (bst.Insert(product))
                    {
                        Console.WriteLine("Thêm sản phẩm thành công.");
                    }
                    else
                    {
                        Console.WriteLine($"Sản phẩm với mã số {id} đã tồn tại. Không thêm.");
                    }
                }
                break;


            case 2: // Tìm kiếm mặt hàng
                Console.Write("Nhập mã số sản phẩm cần tìm: ");
                if (int.TryParse(Console.ReadLine(), out int searchId))
                {
                    Product? found = bst.Search(searchId);
                    if (found != null)
                    {
                        Console.WriteLine($"Sản phẩm tìm thấy: {found}");
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy sản phẩm.");
                    }
                }
                else
                {
                    Console.WriteLine("Mã số không hợp lệ.");
                }
                break;

            case 3: // Chuyển đổi sang danh sách liên kết đơn giảm dần
                SingleLinkedList linkedList = bst.ConvertToLinkedListDescending();
                if (linkedList == null || linkedList.Head == null)
                {
                    Console.WriteLine("Cây nhị phân rỗng. Không có mặt hàng để hiển thị.");
                }
                else
                {
                    Console.WriteLine("Danh sách mặt hàng (giảm dần):");
                    linkedList.Display();
                }
                break;

            case 4: // Thoát chương trình
                Console.WriteLine("Đang thoát chương trình...");
                break;

            default:
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                break;
        }
    } while (choice != 4);
}

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
Test();