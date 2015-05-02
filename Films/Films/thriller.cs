using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Thriller : Grown
    {
        private string budget;
        public string Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        public Thriller()
        {            
        }
    }
    
}
