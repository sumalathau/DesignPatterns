using AbstractFactory_DesignPattern.Interfaces;
using AbstractFactory_DesignPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DesignPattern.Factories
{
    class Modern : IFurniture
    {
        public ISofa GetSofa()
        {
            return new Sofa();
        }
        public IChair GetChair()
        {
            return new Chair();
        }
    }
}
