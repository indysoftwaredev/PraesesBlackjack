﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.App
{
    public class Dealer 
    {
        public Hand Hand { get; set; } = new Hand();

        public void ResetHand()
        {
            Hand = new Hand();
        }
    }
}
