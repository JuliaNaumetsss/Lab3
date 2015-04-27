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
        public Melodrama()
        { 
        }
        public void setCountOfPart(int countOfPart)
        {
            this.countOfPart = countOfPart;
        }
        public int getCountOfPart()
        {
            return countOfPart;
        }
    }
}
