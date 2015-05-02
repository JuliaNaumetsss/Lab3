using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Grown : Film
    {
        protected string actors; 
        public string Actors
        {
            get { return actors; }
            set { actors = value; }
        }
        public Grown()
        {
        }
    }
}
