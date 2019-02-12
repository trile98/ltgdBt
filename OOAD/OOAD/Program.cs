using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD
{
    class Program
    {
        static string sua(string a)
        {
           
            Console.Write("nhap thong tin moi (nhan enter de bo qua):  ");
            string moi = Console.ReadLine();
            if (string.Compare(moi,"")==0) return a;
            else return moi;
        }

        static void Main(string[] args)
        {

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

            string ten = "Nguyen Van A", gt = "nam", bd = "18/3/2000", dc = "105 lo M chung cu Nguyen Kim phuong 7 quan 10", m = "anguyen1803@gmail.com";

            Console.Write("moi nhap ma hoc sinh muon chinh sua:(3 chu so) ");
            string ma = Console.ReadLine();


            if (string.Compare(ma, "001") == 0)
                Console.WriteLine("hoc sinh mang ma so tren khong ton tai!!!");
            else
            {
                Console.WriteLine("da tim thay hoc sinh mang ma {0} !!",ma);
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("--Chinh Sua Thong Tin--");
                Console.WriteLine("Ten: {0}",ten);
                ten=sua(ten);
                Console.WriteLine("Gioi Tinh: {0}", gt);
                gt = sua(gt);
                Console.WriteLine("Ngay sinh: {0}", bd);
                bd = sua(bd);
                Console.WriteLine("Dia chi: {0}", dc);
                dc = sua(dc);
                Console.WriteLine("email: {0}", m);
                m = sua(m);

                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("{0,35}","HO SO HOC SINH");
                Console.WriteLine("Ho Ten:{0,-20}Gioi Tinh:{1}\nNgay Sinh: {2,-20}Dia Chi:{3,-50}Email:{4}",ten,gt,bd,dc,m);


            }
            Console.ReadKey();
        }
    }
}
