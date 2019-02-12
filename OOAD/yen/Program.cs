using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yen
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string name, gt = "nam", bd = "18/3/2000", dc = "105 lo M chung cu Nguyen Kim phuong 7 quan 10", m = "nguyen1803@gmail.com";
            //    Console.Write("Nhap ten can tim kiem (viet hoa chu cai dau, khong dau): ");
            //    name = Console.ReadLine();
            //    //int i = 0;

            //    //Console.WriteLine("\nThong tin cua cac hoc sinh co ten: {0}",name);
            //    //do
            //    //{
            //    //    Console.WriteLine("-------------------------------------------");
            //    //    Console.WriteLine("{0,35}", "HO SO HOC SINH");
            //    //    Console.WriteLine("Ho Ten:{0,-20}Gioi Tinh:{1}\nNgay Sinh: {2,-20}Dia Chi:{3,-50}Email:{4}", name, gt, bd, dc, m);

            //    //    bd = "11/6/1996";
            //    //    dc = "152 Ly Thuong Kiet phuong 7 quan 10";
            //    //    gt = "nu";
            //    //    m = "nguyenle@gmail.com";
            //    //    i++;

            //    //} while (i <2);

            //    Console.WriteLine("Khong co thong tin hoc sinh theo ten vua duoc nhap!!!");

            Console.WriteLine("--CHUONG TRINH QUAN LY HOC SINH CAP BA--");
            Console.WriteLine("1. Nhap thong tin hoc sinh");
            Console.WriteLine("2. Chinh sua thong tin hoc sinh");
            Console.WriteLine("3. Tim kiem thong tin hoc sinh");
            Console.WriteLine("4. Nhap ban diem");
            Console.WriteLine("5. Sua ban diem");
            Console.WriteLine("6. Lap bao cao");
            Console.WriteLine("-------------------------------------------");
            Console.Write("\nNhap so thu tu cua chuc nang muon thuc hien: ");
            int n = Int16.Parse(Console.ReadLine());
        Console.WriteLine("-------------------------------------------");

            Console.WriteLine("--TIM KIEM THONG TIN HOC SINH--");
            Console.WriteLine("1. Tim theo ma so hoc sinh");
            Console.WriteLine("2. Tim theo ten hoc sinh");
            Console.WriteLine("-------------------------------------------");
            Console.Write("\nNhap so thu tu cua chuc nang muon thuc hien: ");
            n = Int16.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");

        }
    }
}
