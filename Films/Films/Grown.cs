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
        public Grown()
        {
        }
        public void setActors(string actors)
        {
            this.actors = actors;
        }
        public string getActors()
        {
            return actors;
        }
    }
}
