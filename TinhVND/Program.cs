using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhVND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;           
            float uSD,vND;
            Console.WriteLine("Chuyển đổi USD sang VND");
            Console.Write("Mời nhập số tiền cần đổi:");
            uSD = float.Parse(Console.ReadLine());
            vND = uSD * 23000;
            Console.WriteLine("Số tiền nhận được:" +vND+" VND");
            Console.ReadLine();


        }
    }
}
