﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Lib
{
    public class Zoo
    {
        public decimal EntranceFee { get; set; } = 50.0M;
        public LionCage LionCage { get; set; }

        public Zoo(decimal entrancFee)
        {
            EntranceFee = entrancFee;
        }
    }
}
