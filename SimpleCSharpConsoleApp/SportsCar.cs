﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCSharpConsoleApp
{
    public class SportsCar : Car
    {
        public string getPetName()
        {
            PetName = "Fred";
            return PetName;
        }
    }
}