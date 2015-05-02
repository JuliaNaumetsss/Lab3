using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Melodrama: Grown
    {
        private int countOfPart;
        public int CountOfPart
        {
            get { return countOfPart; }
            set { countOfPart = value; }
        }
        public Melodrama()
        { 
        }
    }
}
