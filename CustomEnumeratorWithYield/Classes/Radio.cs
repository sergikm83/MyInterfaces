﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield.Classes
{
    public class Radio
    {
        public void TurnOn(bool on) => Console.WriteLine(on? "Jamming..." : "Quet time...");
    }
}
