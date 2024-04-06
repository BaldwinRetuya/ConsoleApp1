using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Items
    {
        static void Main(String[] args)
        {
            CPDetails NewPhones = new CPDetails();
            NewPhones.name = "CellPhones ";

            CPBrands brandone = new CPBrands();
            brandone.Model = " Redmi Note 12 Pro 5G";
            brandone.OperatingSystem = " Android 12 + MIUI 13";
            brandone.Brand = " Xiaomi";
            brandone.Price = " ₱14,999.00";
            brandone.Processor = " Mediatek Dimensity 1080";
            Console.WriteLine(" ");

            CPBrands brandtwo = new CPBrands();
            brandtwo.Model = " iPhone XR";
            brandtwo.OperatingSystem = " iOS 12";
            brandtwo.Brand = " Apple";
            brandtwo.Price = " ₱14,990.00";
            brandtwo.Processor = " Apple A12 Bionic";
            Console.WriteLine(" ");

            CPBrands brandthree = new CPBrands();
            brandthree.Model = " infinix Zero 5G 2023";
            brandthree.OperatingSystem = " Android 12, XOS 12";
            brandthree.Brand = "Infinix";
            brandthree.Price = " ₱ 11,599.00.";
            brandthree.Processor = " Mediatek Dimensity 1080 Mediatek Dimensity 920";
            Console.WriteLine(" ");

            NewPhones.AddCPBrands(brandone);
            NewPhones.AddCPBrands(brandtwo);
            NewPhones.AddCPBrands(brandthree);

            NewPhones.SearchCPBrands(" ");
            NewPhones.DisplayCPBrandsInfo(brandone);
        }
    }
}