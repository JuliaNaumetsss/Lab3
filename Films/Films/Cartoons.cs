﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Cartoons :Children_s
    {
       
        private string duration;
        public string Duration 
        {
            get { return duration;}
            set { duration = value;}
        }
         public Cartoons()
         {
         }
    }
}
