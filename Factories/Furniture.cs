using AbstractFactory_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DesignPattern.Factories
{
     abstract class Furniture
    {
        public abstract IChair GetChair();
        public abstract ISofa GetSofa();        
    }
}
