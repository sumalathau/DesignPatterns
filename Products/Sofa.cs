using AbstractFactory_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DesignPattern.Products
{
    class Sofa : ISofa
    {
        public string HasLegs()
        {
            return "sofa with 4 legs";
        }
        public string SeatingCapacity()
        {
            return "Sofa with Seatinf Capacity";
        }
    }
}
