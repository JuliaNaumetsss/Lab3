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
        
        public string BoxOffice
        {
            get { return boxOffice; }
            set { boxOffice = value; }
        }
        public Fiction()
        {
        }
    }
}
