using AbstractFactory_DesignPattern.Interfaces;
using AbstractFactory_DesignPattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DesignPattern
{
    class Client
    {
        public void method(int param)
        {
            switch (param)
            {
                case 1:
                    SaleChair(new Modern());
                    //SaleChair(new Old());
                    break;
                case 2:
                    //SaleSofa(new Modern());
                    //SaleSofa(new Old());
                    SaleSofaWithCapacity(new Modern());
                    break;                
                default:
                    Console.WriteLine("Please enter your choice Correctly");
                    break;

            }
        }
        public void SaleChair(IFurniture Furniture)
        {
            Console.WriteLine(Furniture.GetChair().HasLegs());
        }
        public void SaleSofa(IFurniture Furniture)
        {
            Console.WriteLine(Furniture.GetSofa().HasLegs());
        }
        public void SaleSofaWithCapacity(IFurniture Furniture)
        {
            Console.WriteLine(Furniture.GetSofa().SeatingCapacity());
        }
    }
    class Program
    {              
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1 to buy chair");
            Console.WriteLine("enter 2 to buy sofa");
            int input = Convert.ToInt32(Console.ReadLine());
            //if (input == 2)
            //{
            //    Console.WriteLine("enter seating capacity to buy a sofa");
            //    input = 3;// Convert.ToInt32(Console.ReadLine());
            //}
            Client client = new Client();
            client.method(input);

            Console.ReadKey();
        }
    }
}
