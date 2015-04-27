using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Fiction : Children_s
    {
        private string boxOffice;
        public Fiction()
        {
        }
        public void setBoxOffice(string boxOffice)
        {
            this.boxOffice = boxOffice;
        }
        public string getBoxOffice()
        {
            return boxOffice;
        }
    }
}
