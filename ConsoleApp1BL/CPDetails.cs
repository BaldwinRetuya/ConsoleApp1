using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CPDetails
    {
        public string name;
        List<CPBrands> brand = new List<CPBrands>();
        public void AddCPBrands(CPBrands cpbrands)
        {
            brand.Add(cpbrands);
        }
        public void SearchCPBrands(string Model)
        {
            foreach (var cpbrands in brand)
            {
                if (cpbrands.Model.Contains(Model))
                {
                    Console.WriteLine("CPBrand Found");
                    Console.WriteLine(" ");
                    DisplayCPBrandsInfo(cpbrands);
                }
            }
        }

        public void DisplayCPBrandsInfo(CPBrands cpbrands)
        {
            Console.WriteLine("PHONEMODEL INFORMATION in " + name);
            Console.WriteLine("Model: " + cpbrands.Model);
            Console.WriteLine("OperatingSystem: " + cpbrands.OperatingSystem);
            Console.WriteLine("Brand: " + cpbrands.Brand);
            Console.WriteLine("Price: " + cpbrands.Price);
            Console.WriteLine("Processor: " + cpbrands.Processor);
        }
        public void DeleteCPBrands (CPBrands cpbrands)
        {
            brand.Remove (cpbrands);
        }
    }
}