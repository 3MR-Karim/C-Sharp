﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP
{
    internal interface IShape
    {
        public double Area { get; set; }

        public void DisplayShapeInfo();
        
    }
}