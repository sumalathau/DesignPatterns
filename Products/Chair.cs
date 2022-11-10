using AbstractFactory_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DesignPattern.Products
{
    class Chair : IChair
    {
        public string HasLegs()
        {
            return "chair with 4 legs";
        }
    }
}
