﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DesignPattern.Interfaces
{
    interface IFurniture
    {
        IChair GetChair();
        ISofa GetSofa(); 
    }
}
