﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class Dragon : PlayableEntity
    {
        public override string HandleA()
        {
            return "Run";
        }

        public override string HandleB()
        {
            return "Fly";
        }
    }
}
