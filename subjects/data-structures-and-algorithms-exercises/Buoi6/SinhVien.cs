using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
    public class SinhVien
    {
        int studentId, birthYear;
        string fullName;
        string gender;
        string major, faculty;

        public int BirthYear { get => birthYear; set => birthYear = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public string Major { get => major; set => major = value; }

        public SinhVien(int studentId, string fullName, int birthYear, string gender, string major, string faculty)
        {
            this.studentId = studentId; 
            this.fullName = fullName; 
            this.birthYear = birthYear;
            this.gender = gender; 
            this.major = major; 
            this.faculty = faculty; 
        }

        public SinhVien()
        {
            this.studentId = 0;
            this.gender = this.fullName = this.major = this.faculty = string.Empty;
            this.birthYear = 0;
        }

        public void Nhap()
        {
            Console.WriteLine("Mời nhập mã sinh viên: ");
            studentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập họ và tên: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Mời nhập năm sinh: ");
            birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập giới tính: ");
            gender = Console.ReadLine();
            Console.WriteLine("Mời nhập tên chuyên ngành: ");
            major = Console.ReadLine();
            Console.WriteLine("Mời nhập tên khoa: ");
            faculty = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine($"Mã sinh viên: {studentId}");
            Console.WriteLine($"Họ và tên: {fullName}");
            Console.WriteLine($"Năm sinh: {birthYear}");
            Console.WriteLine($"Giới tính: {gender}");
            Console.WriteLine($"Chuyên ngành: {major}");
            Console.WriteLine($"Khoa: {faculty}");
        }
    }
}
